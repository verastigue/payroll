-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 31, 2024 at 12:07 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.1.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `payroll_schema`
--

-- --------------------------------------------------------

--
-- Table structure for table `attendance`
--

CREATE TABLE `attendance` (
  `Id` int(11) NOT NULL,
  `EmployeeID` varchar(255) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `Date` date NOT NULL,
  `TimeIn` time NOT NULL,
  `TimeOut` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Triggers `attendance`
--
DELIMITER $$
CREATE TRIGGER `after_delete_attendance` AFTER DELETE ON `attendance` FOR EACH ROW BEGIN
    DECLARE total_work_hours INT;
    DECLARE regular_hours INT;
    DECLARE overtime_hours INT;
    DECLARE work_days INT;
    DECLARE net_income DECIMAL(10, 2);
    DECLARE emp_position ENUM('Regular', 'Head', 'Doctorate');
    DECLARE hourly_rate DECIMAL(10, 2);
    DECLARE overtime_rate DECIMAL(10, 2);
    DECLARE total_pay DECIMAL(10, 2);
    DECLARE tax DECIMAL(10, 2);
    DECLARE total_deduction DECIMAL(10, 2);
    DECLARE net_pay DECIMAL(10, 2);
    DECLARE today DATE;
    DECLARE formatted_month_year VARCHAR(20);

    -- Fetch the employee's position
    SELECT Position INTO emp_position
    FROM employee
    WHERE EmployeeID = OLD.EmployeeID;

    -- Determine the hourly rate based on the employee's position
    SET hourly_rate = CASE
        WHEN emp_position = 'Regular' THEN 75.00
        WHEN emp_position = 'Head' THEN 93.75
        WHEN emp_position = 'Doctorate' THEN 125.00
        ELSE 0.00
    END;

    -- Overtime rate (extra 50 for all positions)
    SET overtime_rate = hourly_rate + 50.00;

    -- Calculate total work hours, regular hours, and overtime hours for the current month
    SELECT
        SUM(TIMESTAMPDIFF(HOUR, TimeIn, TimeOut)),
        SUM(CASE WHEN TIMESTAMPDIFF(HOUR, TimeIn, TimeOut) <= 8 THEN TIMESTAMPDIFF(HOUR, TimeIn, TimeOut) ELSE 8 END),
        SUM(CASE WHEN TIMESTAMPDIFF(HOUR, TimeIn, TimeOut) > 8 THEN TIMESTAMPDIFF(HOUR, TimeIn, TimeOut) - 8 ELSE 0 END)
    INTO total_work_hours, regular_hours, overtime_hours
    FROM attendance
    WHERE EmployeeID = OLD.EmployeeID
      AND MONTH(Date) = MONTH(OLD.Date)
      AND YEAR(Date) = YEAR(OLD.Date);

    -- Calculate total pay (NetIncome)
    SET net_income = (regular_hours * hourly_rate) + (overtime_hours * overtime_rate);

    -- Calculate the number of workdays for the current month
    SELECT COUNT(DISTINCT Date)
    INTO work_days
    FROM attendance
    WHERE EmployeeID = OLD.EmployeeID
      AND TimeIn IS NOT NULL
      AND TimeOut IS NOT NULL
      AND MONTH(Date) = MONTH(OLD.Date)
      AND YEAR(Date) = YEAR(OLD.Date);

    -- Calculate total pay (without deductions)
    SET total_pay = net_income;

    -- Check if it's the last day of the month
    SET today = CURDATE();
    IF LAST_DAY(today) = today THEN
        -- Calculate tax and total deduction on the last day of the month
        SET tax = 0.05;
        SET total_deduction = net_income * tax;
        SET net_pay = net_income - total_deduction;
    ELSE
        -- No deduction applied on other days
        SET tax = 0.00;
        SET total_deduction = 0.00;
        SET net_pay = net_income;
    END IF;

    -- Define the formatted month and year
    SET formatted_month_year = DATE_FORMAT(OLD.Date, '%M %Y');

    -- Check if a salary record exists for the current month
    IF EXISTS (
        SELECT 1 FROM salary
        WHERE EmployeeId = OLD.EmployeeID
          AND thisMonth = formatted_month_year
    ) THEN
        -- Update the existing salary record
        UPDATE salary
        SET TRegHours = regular_hours,
            TOverHours = overtime_hours,
            workDays = work_days,
            NetIncome = net_income,
            Tax = tax,
            TDeduction = total_deduction,
            Netpay = net_pay,
            thisMonth = formatted_month_year
        WHERE EmployeeId = OLD.EmployeeID
          AND thisMonth = formatted_month_year;
    ELSE
        -- Insert a new salary record for the new month
        INSERT INTO salary (EmployeeId, thisMonth, Name, workDays, NetIncome, TRegHours, TOverHours, Tax, TDeduction, Netpay)
        VALUES (OLD.EmployeeID, formatted_month_year,
                (SELECT CONCAT(Firstname, ' ', Lastname) FROM employee WHERE EmployeeID = OLD.EmployeeID),
                work_days, net_income, regular_hours, overtime_hours, tax, total_deduction, net_pay);
    END IF;
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `after_update_attendance` AFTER UPDATE ON `attendance` FOR EACH ROW BEGIN
    DECLARE total_work_hours INT;
    DECLARE regular_hours INT;
    DECLARE overtime_hours INT;
    DECLARE work_days INT;
    DECLARE net_income DECIMAL(10, 2);
    DECLARE emp_position ENUM('Regular', 'Head', 'Doctorate');
    DECLARE hourly_rate DECIMAL(10, 2);
    DECLARE overtime_rate DECIMAL(10, 2);
    DECLARE total_pay DECIMAL(10, 2);
    DECLARE tax DECIMAL(10, 2);
    DECLARE total_deduction DECIMAL(10, 2);
    DECLARE net_pay DECIMAL(10, 2);
    DECLARE today DATE;
    DECLARE formatted_month_year VARCHAR(20);

    -- Fetch the employee's position
    SELECT Position INTO emp_position
    FROM employee
    WHERE EmployeeID = NEW.EmployeeID;

    -- Determine the hourly rate based on the employee's position
    SET hourly_rate = CASE
        WHEN emp_position = 'Regular' THEN 75.00
        WHEN emp_position = 'Head' THEN 93.75
        WHEN emp_position = 'Doctorate' THEN 125.00
        ELSE 0.00
    END;

    -- Overtime rate (extra 50 for all positions)
    SET overtime_rate = hourly_rate + 50.00;

    -- Calculate total work hours, regular hours, and overtime hours for the current month
    SELECT
        SUM(TIMESTAMPDIFF(HOUR, TimeIn, TimeOut)),
        SUM(CASE WHEN TIMESTAMPDIFF(HOUR, TimeIn, TimeOut) <= 8 THEN TIMESTAMPDIFF(HOUR, TimeIn, TimeOut) ELSE 8 END),
        SUM(CASE WHEN TIMESTAMPDIFF(HOUR, TimeIn, TimeOut) > 8 THEN TIMESTAMPDIFF(HOUR, TimeIn, TimeOut) - 8 ELSE 0 END)
    INTO total_work_hours, regular_hours, overtime_hours
    FROM attendance
    WHERE EmployeeID = NEW.EmployeeID
      AND MONTH(Date) = MONTH(NEW.Date)
      AND YEAR(Date) = YEAR(NEW.Date);

    -- Calculate total pay (NetIncome)
    SET net_income = (regular_hours * hourly_rate) + (overtime_hours * overtime_rate);

    -- Calculate the number of workdays for the current month
    SELECT COUNT(DISTINCT Date)
    INTO work_days
    FROM attendance
    WHERE EmployeeID = NEW.EmployeeID
      AND TimeIn IS NOT NULL
      AND TimeOut IS NOT NULL
      AND MONTH(Date) = MONTH(NEW.Date)
      AND YEAR(Date) = YEAR(NEW.Date);

    -- Calculate total pay (without deductions)
    SET total_pay = net_income;

    -- Check if it's the last day of the month
    SET today = CURDATE();
    IF LAST_DAY(today) = today THEN
        -- Calculate tax and total deduction on the last day of the month
        SET tax = 0.05;
        SET total_deduction = net_income * tax;
        SET net_pay = net_income - total_deduction;
    ELSE
        -- No deduction applied on other days
        SET tax = 0.00;
        SET total_deduction = 0.00;
        SET net_pay = net_income;
    END IF;

    -- Define the formatted month and year
    SET formatted_month_year = DATE_FORMAT(NEW.Date, '%M %Y');

    -- Check if a salary record exists for the current month
    IF EXISTS (
        SELECT 1 FROM salary
        WHERE EmployeeId = NEW.EmployeeID
          AND thisMonth = formatted_month_year
    ) THEN
        -- Update the existing salary record
        UPDATE salary
        SET TRegHours = regular_hours,
            TOverHours = overtime_hours,
            workDays = work_days,
            NetIncome = net_income,
            Tax = tax,
            TDeduction = total_deduction,
            Netpay = net_pay,
            thisMonth = formatted_month_year
        WHERE EmployeeId = NEW.EmployeeID
          AND thisMonth = formatted_month_year;
    ELSE
        -- Insert a new salary record for the new month
        INSERT INTO salary (EmployeeId, thisMonth, Name, workDays, NetIncome, TRegHours, TOverHours, Tax, TDeduction, Netpay)
        VALUES (NEW.EmployeeID, formatted_month_year,
                (SELECT CONCAT(Firstname, ' ', Lastname) FROM employee WHERE EmployeeID = NEW.EmployeeID),
                work_days, net_income, regular_hours, overtime_hours, tax, total_deduction, net_pay);
    END IF;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `Id` int(11) NOT NULL,
  `EmployeeID` varchar(255) NOT NULL,
  `Firstname` varchar(100) NOT NULL,
  `Lastname` varchar(100) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Status` enum('Part-time','Full-time','','') NOT NULL,
  `Position` enum('Regular','Head','Doctorate','') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `salary`
--

CREATE TABLE `salary` (
  `Id` int(11) NOT NULL,
  `thisMonth` varchar(20) DEFAULT NULL,
  `EmployeeId` varchar(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `workDays` int(11) NOT NULL,
  `NetIncome` double NOT NULL,
  `TRegHours` double NOT NULL,
  `TOverHours` double NOT NULL,
  `Tax` double NOT NULL,
  `TDeduction` double NOT NULL,
  `Netpay` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `attendance`
--
ALTER TABLE `attendance`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `EmployeeID` (`EmployeeID`),
  ADD KEY `Email` (`Email`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `EmployeeID` (`EmployeeID`),
  ADD UNIQUE KEY `Email` (`Email`);

--
-- Indexes for table `salary`
--
ALTER TABLE `salary`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `EmployeeId` (`EmployeeId`,`thisMonth`) USING BTREE;

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`),
  ADD UNIQUE KEY `email` (`email`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `attendance`
--
ALTER TABLE `attendance`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `salary`
--
ALTER TABLE `salary`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `attendance`
--
ALTER TABLE `attendance`
  ADD CONSTRAINT `attendance_ibfk_1` FOREIGN KEY (`EmployeeID`) REFERENCES `employee` (`EmployeeID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `attendance_ibfk_2` FOREIGN KEY (`Email`) REFERENCES `employee` (`Email`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `salary`
--
ALTER TABLE `salary`
  ADD CONSTRAINT `salary_ibfk_1` FOREIGN KEY (`EmployeeId`) REFERENCES `employee` (`EmployeeID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
