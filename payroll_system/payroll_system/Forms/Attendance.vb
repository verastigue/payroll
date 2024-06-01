Public Class Attendance
    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_date.Text = "Date: " + Date.Now.ToString("MMMM dd yyyy")
        lbl_time.Text = "Time: " + Date.Now.ToString("hh:mm:ss tt")
    End Sub

    'TIME IN
    Private Sub btn_timeIn_Click(sender As Object, e As EventArgs) Handles btn_timeIn.Click
        If txt_email.Text = "" Or txt_employeeId.Text = "" Then
            MessageBox.Show("Fill up all Fields")
        ElseIf Not EmployeeExists(txt_employeeId.Text, txt_email.Text) Then
            MessageBox.Show("Employee not exist")
        Else

            If AlreadyAttendace(txt_employeeId.Text, txt_email.Text, Date.Now.ToString("yyyy-MM-dd")) Then
                MessageBox.Show("already Time in")
            Else
                executeQuery("INSERT INTO attendance(EmployeeId, Email, Date, TimeIn) VALUES('" & txt_employeeId.Text & "', '" & txt_email.Text & "', '" & Date.Now.ToString("yyyy-MM-dd") & "', '" & Date.Now.ToString("HH:mm:ss") & "')")
                MainForm.RefreshData()
                txt_email.Clear()
                txt_employeeId.Clear()
            End If

        End If
    End Sub

    'TIME OUT
    Private Sub btn_TimeOut_Click(sender As Object, e As EventArgs) Handles btn_timeOut.Click

        If txt_email.Text = "" Or txt_employeeId.Text = "" Then
            MessageBox.Show("Fill up all Fields")
        Else

            If Not AlreadyAttendace(txt_employeeId.Text, txt_email.Text, Date.Now.ToString("yyyy-MM-dd")) Then
                MessageBox.Show("No time in record found for today")
            Else
                executeQuery("UPDATE attendance SET TimeOut = '" & Date.Now.ToString("HH:mm:ss") & "' WHERE EmployeeId = '" & txt_employeeId.Text & "' AND Email = '" & txt_email.Text & "' AND Date = '" & Date.Now.ToString("yyyy-MM-dd") & "'")
                MainForm.RefreshData()
                txt_email.Clear()
                txt_employeeId.Clear()
            End If
        End If

    End Sub

    'CHECK IF ALREADY ATTENDANCE
    Private Function AlreadyAttendace(employeeId As String, email As String, thisDay As String) As Boolean
        Dim count As Integer = 0

        count = countData("SELECT COUNT(*) FROM attendance WHERE EmployeeId = '" & employeeId & "'  AND Email = '" & email & "' AND Date = '" & thisDay & "'")

        Return count > 0
    End Function

    'CHECK IF EMPLOYEE EXIST
    Private Function EmployeeExists(employeeId As String, email As String) As Boolean
        Dim count As Integer = 0

        count = countData("SELECT COUNT(*) FROM employee WHERE EmployeeId = '" & employeeId & "'  AND Email = '" & email & "'")

        Return count > 0
    End Function

    Private Sub lbl_hr_Click(sender As Object, e As EventArgs) Handles lbl_hr.Click
        Me.Hide()
        Login.Show()
        txt_email.Clear()
        txt_employeeId.Clear()
    End Sub
End Class