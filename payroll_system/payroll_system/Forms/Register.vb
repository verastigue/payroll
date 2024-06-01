Public Class Register
    'FORM LOAD
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ckb_hideCon.Checked = True
        txt_confirmPass.UseSystemPasswordChar = True


        ckb_hide.Checked = True
        txt_pasword.UseSystemPasswordChar = True
    End Sub

    'LOGIN ACCOUNT
    Private Sub lbl_login_Click(sender As Object, e As EventArgs) Handles lbl_login.Click
        Me.Hide()
        Login.Show()
        txt_username.Clear()
        txt_email.Clear()
        txt_pasword.Clear()
        txt_confirmPass.Clear()
    End Sub

    'REGISTER ACCOUNT
    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        Dim username As String = txt_username.Text
        Dim email As String = txt_email.Text.Trim
        Dim password As String = txt_pasword.Text.Trim
        Dim conPass As String = txt_confirmPass.Text.Trim

        If username = "" Or email = "" Or password = "" Or conPass = "" Then
            MessageBox.Show("Fill all the required Fields")
        ElseIf UsernameTaken(username) Then
            MessageBox.Show("Username is Already Taken!")
        ElseIf EmailTaken(email) Then
            MessageBox.Show("Email is Already Taken!")

        Else
            If password <> conPass Then
                MessageBox.Show("password and confirm password does not match!")
            Else
                executeQuery("INSERT INTO users(username, email, password) VALUES('" & username & "', '" & email & "', '" & password & "')")
                MessageBox.Show("Successfully Register!")
                Me.Hide()
                Login.Show()
                txt_username.Clear()
                txt_email.Clear()
                txt_pasword.Clear()
                txt_confirmPass.Clear()
            End If
        End If
    End Sub

    Function UsernameTaken(username As String) As Boolean
        Dim count As Integer = 0

        count = countData("SELECT COUNT(*) FROM users WHERE username = '" & username & "'")

        If count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Function EmailTaken(email As String) As Boolean
        Dim count As Integer = 0

        count = countData("SELECT COUNT(*) FROM users WHERE email = '" & email & "'")

        If count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    'HIDE AND SHOW PASSWORD
    Private Sub ckb_hide_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_hide.CheckedChanged
        If ckb_hide.Checked = True Then
            txt_pasword.UseSystemPasswordChar = True
        Else
            txt_pasword.UseSystemPasswordChar = False
        End If
    End Sub

    'HIDE AND SHOW CONFIRM PASSWORD
    Private Sub ckb_hideCon_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_hideCon.CheckedChanged
        If ckb_hideCon.Checked = True Then
            txt_confirmPass.UseSystemPasswordChar = True
        Else
            txt_confirmPass.UseSystemPasswordChar = False
        End If
    End Sub

End Class