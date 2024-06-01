Imports Guna.UI2.WinForms

Public Class MainForm

    Private dataEmployee As DataTable = getData("SELECT EmployeeID, Firstname, Lastname, Email, Status, Position FROM employee")
    Private dataAttendance As DataTable = getData("SELECT Id, EmployeeID, Email, Date, TIME_FORMAT(TimeIn, '%h:%i %p') AS TimeIn, CASE WHEN TimeOut = '00:00:00' THEN '--/--' ELSE TIME_FORMAT(TimeOut, '%h:%i %p') END AS TimeOut FROM attendance")
    Private dataSalary As DataTable = getData("SELECT thisMonth, EmployeeId, Name, workDays, NetIncome, TRegHours, TOverHours, Tax, TDeduction, Netpay FROM salary")


    'FORM LOAD
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim textboxes() As Guna2TextBox = {txt_employeeId, txt_firstname, txt_lastname, txt_email}
        RefreshData()
        ClearTextbox(textboxes)
    End Sub

    'CLEAR ALL THE TEXTBOX
    Sub ClearTextbox(textboxes As IEnumerable(Of Guna2TextBox))
        For Each textbox As Guna2TextBox In textboxes
            textbox.Clear()
        Next
    End Sub

    'CLEAR DETAILS
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Dim textboxes = {txt_employeeId, txt_firstname, txt_lastname, txt_email}
        ClearTextbox(textboxes)

        For Each row As DataGridViewRow In dtgv_employee.SelectedRows
            row.Selected = False
        Next
    End Sub

    'REFRESH DATA
    Sub RefreshData()
        RefreshEmployee()
        RefreshAttendance()
        RefreshSalary()
        CountALlData()
    End Sub

    Sub RefreshEmployee()
        dtgv_employee.DataSource = getData("SELECT EmployeeID, Firstname, Lastname, Email, Status, Position FROM employee")
        For Each row As DataGridViewRow In dtgv_employee.SelectedRows
            row.Selected = False
        Next
    End Sub

    Sub RefreshAttendance()
        dtgv_attendance.DataSource = getData("SELECT Id, EmployeeID, Email, Date, TIME_FORMAT(TimeIn, '%h:%i %p') AS TimeIn, CASE WHEN TimeOut = '00:00:00' THEN '--/--' ELSE TIME_FORMAT(TimeOut, '%h:%i %p') END AS TimeOut FROM attendance")
        For Each row As DataGridViewRow In dtgv_attendance.SelectedRows
            row.Selected = False
        Next
    End Sub

    Sub CountALlData()
        lbl_countEmployee.Text = CountEmployee()
        lbl_countSalary.Text = CountSalary()
        lbl_countWorks.Text = CountWorkDays()
    End Sub

    Function CountSalary()
        Dim count As Integer = 0
        count = countData("SELECT SUM(Netpay) FROM salary")

        Return count
    End Function

    Function CountEmployee()
        Dim count As Integer = 0
        count = countData("SELECT COUNT(EmployeeId) FROM employee")

        Return count
    End Function

    Function CountWorkDays()
        Dim count As Integer = 0
        count = countData("SELECT COUNT(DISTINCT Date) FROM attendance")

        Return count
    End Function

    Sub RefreshSalary()
        dtgv_salary.DataSource = getData("SELECT thisMonth, EmployeeId, Name, workDays, NetIncome, TRegHours, TOverHours, Tax, TDeduction, Netpay FROM salary")
        For Each row As DataGridViewRow In dtgv_salary.SelectedRows
            row.Selected = False
        Next
    End Sub


    'LOGOUT
    Private Sub btn_logout_Click_1(sender As Object, e As EventArgs) Handles btn_logout.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Hide()
            Login.Show()
        End If
    End Sub

    'SEARCH BAR
    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Dim stSearch As String = txt_search.Text.Trim()

        Try
            If tabControl.SelectedTab Is tab_employee Then
                Dim filteredView As DataView = dataEmployee.DefaultView

                filteredView.RowFilter = String.Format("EmployeeID LIKE '%{0}%' OR Firstname LIKE '%{0}%' OR Lastname LIKE '%{0}%' OR Email LIKE '%{0}%' OR Status LIKE '%{0}%' OR Position LIKE '%{0}%'", stSearch)
                dtgv_employee.DataSource = filteredView

            ElseIf tabControl.SelectedTab Is tab_attendance Then
                Dim filteredView As DataView = dataAttendance.DefaultView

                filteredView.RowFilter = String.Format("EmployeeID LIKE '%{0}%' OR Email LIKE '%{0}%' OR TimeIn LIKE '%{0}%' OR TimeOut LIKE '%{0}%'", stSearch)
                dtgv_attendance.DataSource = filteredView

            ElseIf tabControl.SelectedTab Is tab_salary Then
                Dim filteredView As DataView = dataSalary.DefaultView

                filteredView.RowFilter = String.Format("Name LIKE '%{0}%' OR EmployeeId LIKE '%{0}%' ", stSearch)
                dtgv_salary.DataSource = filteredView
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub


    'EMPLOYEE
    Dim oldId As String

    'SELECTED EMPLOYEE
    Private Sub dtgv_employee_SelectionChanged(sender As Object, e As EventArgs) Handles dtgv_employee.SelectionChanged
        If dtgv_employee.SelectedRows.Count > 0 Then
            Dim selectedRows = dtgv_employee.SelectedRows(0)

            txt_employeeId.Text = selectedRows.Cells("EmployeeID").Value.ToString
            txt_firstname.Text = selectedRows.Cells("Firstname").Value.ToString
            txt_lastname.Text = selectedRows.Cells("Lastname").Value.ToString
            txt_email.Text = selectedRows.Cells("Email").Value.ToString
            cb_status.SelectedItem = selectedRows.Cells("Status").Value.ToString
            cb_position.SelectedItem = selectedRows.Cells("Position").Value.ToString

            oldId = selectedRows.Cells("EmployeeID").Value.ToString

            btn_add.Cursor = Cursors.No
            btn_update.Cursor = Cursors.Hand
            btn_delete.Cursor = Cursors.Hand

        Else
            btn_add.Cursor = Cursors.Hand
            btn_update.Cursor = Cursors.No
            btn_delete.Cursor = Cursors.No
        End If
    End Sub

    'ADD EMPLOYEE
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim textboxes = {txt_employeeId, txt_firstname, txt_lastname, txt_email}

        If btn_add.Cursor = Cursors.Hand Then
            If txt_employeeId.Text = "" Or txt_firstname.Text = "" Or txt_lastname.Text = "" Or txt_email.Text = "" Then
                MessageBox.Show("All fields must be filled out.")
            Else
                executeQuery("INSERT INTO employee (EmployeeID, Firstname, Lastname, Email, Status, Position) VALUES('" & txt_employeeId.Text & "', '" & txt_firstname.Text & "', '" & txt_lastname.Text & "', '" & txt_email.Text & "', '" & cb_status.SelectedItem & "', '" & cb_position.SelectedItem & "')")
                RefreshData()

                ClearTextbox(textboxes)
            End If
        End If
    End Sub

    'UPDATE EMPLOYEE
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim textboxes = {txt_employeeId, txt_firstname, txt_lastname, txt_email}

        If btn_update.Cursor = Cursors.Hand Then
            If txt_employeeId.Text = "" Or txt_firstname.Text = "" Or txt_lastname.Text = "" Or txt_email.Text = "" Then
                MessageBox.Show("All fields must be filled out.")
            Else
                executeQuery("UPDATE employee SET EmployeeID = '" & txt_employeeId.Text & "', Firstname = '" & txt_firstname.Text & "', Lastname = '" & txt_lastname.Text & "', Email = '" & txt_email.Text & "', Status = '" & cb_status.SelectedItem & "', Position = '" & cb_position.SelectedItem & "' WHERE EmployeeId = '" & oldId & "'")
                RefreshData()

                ClearTextbox(textboxes)
            End If
        End If

    End Sub

    'DELETE EMPLOYEE
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim textboxes = {txt_employeeId, txt_firstname, txt_lastname, txt_email}

        If btn_delete.Cursor = Cursors.Hand Then
            Dim result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                executeQuery("DELETE FROM employee WHERE EmployeeID = '" & oldId & "'")
                RefreshData()

                ClearTextbox(textboxes)
            End If
        End If
    End Sub



    'ATTENDANCE
    'SELECTED ATTENDANCE

    Dim attID As Integer
    Private Sub dtgv_attendance_SelectionChanged(sender As Object, e As EventArgs) Handles dtgv_attendance.SelectionChanged
        If dtgv_attendance.SelectedRows.Count > 0 Then
            Dim selectedRow = dtgv_attendance.SelectedRows(0)

            txt_attEmploId.Text = selectedRow.Cells("EmployeeID").Value.ToString()
            txt_attEmail.Text = selectedRow.Cells("Email").Value.ToString()
            dtp_attDate.Value = Convert.ToDateTime(selectedRow.Cells("Date").Value)

            dtp_attTimeIn.Value = Convert.ToDateTime(selectedRow.Cells("TimeIn").Value)

            If selectedRow.Cells("TimeOut").Value <> "--/--" Then
                dtp_attTimeOut.Value = Convert.ToDateTime(selectedRow.Cells("TimeOut").Value)
            End If

            attID = selectedRow.Cells("Id").Value

            btn_updateAtt.Cursor = Cursors.Hand
            btn_deleteAtt.Cursor = Cursors.Hand
        Else
            btn_updateAtt.Cursor = Cursors.No
            btn_deleteAtt.Cursor = Cursors.No
        End If
    End Sub

    'UPDATE ATTENDANCE
    Private Sub btn_updateAtt_Click(sender As Object, e As EventArgs) Handles btn_updateAtt.Click
        Dim textboxes = {txt_attEmploId, txt_attEmail}

        If btn_updateAtt.Cursor = Cursors.Hand Then


            executeQuery("UPDATE attendance SET Date = '" & dtp_attDate.Value.ToString("yyyy-MM-dd") & "', TimeIn = '" & dtp_attTimeIn.Value.ToString("HH:mm:ss") & "', TimeOut = '" & dtp_attTimeOut.Value.ToString("HH:mm:ss") & "' WHERE Id = '" & attID & "'")
            RefreshData()

            ClearTextbox(textboxes)
        End If
    End Sub

    'DELETE ATTENDANCE
    Private Sub btn_deleteAtt_Click(sender As Object, e As EventArgs) Handles btn_deleteAtt.Click
        Dim textboxes = {txt_attEmploId, txt_attEmail}

        If btn_deleteAtt.Cursor = Cursors.Hand Then
            Dim result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                executeQuery("DELETE FROM attendance WHERE Id = '" & attID & "'")
                RefreshData()

                ClearTextbox(textboxes)
            End If
        End If
    End Sub
End Class