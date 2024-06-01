Public Class Login
    'FORM LOAD
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ckb_check.Checked = True
        txt_password.UseSystemPasswordChar = True
    End Sub

    'LOGIN ACCOUNT
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        Dim username As String = txt_username.Text.Trim
        Dim password As String = txt_password.Text.Trim

        If username = "" Or password = "" Then
            MessageBox.Show("Fill all the required fields")
        ElseIf Not AccountExist(username, password) Then
            MessageBox.Show("Incorrect credentials!")
        Else
            MessageBox.Show("Successfully Login!")
            Me.Hide()
            MainForm.Show()
            MainForm.lbl_username.Text = username
            txt_username.Clear()
            txt_password.Clear()
        End If
    End Sub

    Function AccountExist(username As String, password As String) As Boolean
        Dim count As Integer = 0


        count = countData("SELECT COUNT(*) FROM users WHERE username = '" & username & "' AND password = '" & password & "'")

        If count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    'REGISTER ACCOUNT
    Private Sub lbl_register_Click(sender As Object, e As EventArgs) Handles lbl_register.Click
        Me.Hide()
        Register.Show()
        txt_username.Clear()
        txt_password.Clear()
    End Sub

    Private Sub lbl_emp_Click(sender As Object, e As EventArgs) Handles lbl_emp.Click
        Me.Hide()
        Attendance.Show()
        txt_username.Clear()
        txt_password.Clear()
    End Sub

    Private Sub ckb_check_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_check.CheckedChanged
        If ckb_check.Checked = True Then
            txt_password.UseSystemPasswordChar = True
        Else
            txt_password.UseSystemPasswordChar = False
        End If
    End Sub


End Class