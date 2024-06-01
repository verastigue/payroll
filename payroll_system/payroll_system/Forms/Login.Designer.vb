<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        ckb_check = New Guna.UI2.WinForms.Guna2ImageCheckBox()
        lbl_emp = New Label()
        lbl_register = New Label()
        Label3 = New Label()
        btn_login = New Guna.UI2.WinForms.Guna2Button()
        Label7 = New Label()
        Label2 = New Label()
        txt_password = New Guna.UI2.WinForms.Guna2TextBox()
        Label1 = New Label()
        txt_username = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Guna2Panel1.SuspendLayout()
        Guna2Panel2.SuspendLayout()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.Controls.Add(ckb_check)
        Guna2Panel1.Controls.Add(lbl_emp)
        Guna2Panel1.Controls.Add(lbl_register)
        Guna2Panel1.Controls.Add(Label3)
        Guna2Panel1.Controls.Add(btn_login)
        Guna2Panel1.Controls.Add(Label7)
        Guna2Panel1.Controls.Add(Label2)
        Guna2Panel1.Controls.Add(txt_password)
        Guna2Panel1.Controls.Add(Label1)
        Guna2Panel1.Controls.Add(txt_username)
        Guna2Panel1.CustomizableEdges = CustomizableEdges8
        Guna2Panel1.Dock = DockStyle.Left
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Margin = New Padding(3, 4, 3, 4)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges9
        Guna2Panel1.Size = New Size(629, 921)
        Guna2Panel1.TabIndex = 0
        ' 
        ' ckb_check
        ' 
        ckb_check.BackColor = Color.White
        ckb_check.Checked = True
        ckb_check.CheckedState.Image = My.Resources.Resources.icon_hide
        ckb_check.Image = My.Resources.Resources.icon_view
        ckb_check.ImageOffset = New Point(0, 0)
        ckb_check.ImageRotate = 0F
        ckb_check.Location = New Point(445, 455)
        ckb_check.Margin = New Padding(3, 4, 3, 4)
        ckb_check.Name = "ckb_check"
        ckb_check.ShadowDecoration.CustomizableEdges = CustomizableEdges1
        ckb_check.Size = New Size(29, 33)
        ckb_check.TabIndex = 47
        ' 
        ' lbl_emp
        ' 
        lbl_emp.Anchor = AnchorStyles.None
        lbl_emp.AutoSize = True
        lbl_emp.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold, GraphicsUnit.Pixel)
        lbl_emp.ForeColor = Color.FromArgb(CByte(214), CByte(40), CByte(40))
        lbl_emp.Location = New Point(14, 872)
        lbl_emp.Name = "lbl_emp"
        lbl_emp.Size = New Size(54, 28)
        lbl_emp.TabIndex = 46
        lbl_emp.Text = "EMP"
        ' 
        ' lbl_register
        ' 
        lbl_register.Anchor = AnchorStyles.None
        lbl_register.AutoSize = True
        lbl_register.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        lbl_register.ForeColor = Color.Teal
        lbl_register.Location = New Point(199, 665)
        lbl_register.Name = "lbl_register"
        lbl_register.Size = New Size(203, 25)
        lbl_register.TabIndex = 24
        lbl_register.Text = "Don't Have an Account?"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        Label3.ForeColor = Color.DimGray
        Label3.Location = New Point(213, 180)
        Label3.Name = "Label3"
        Label3.Size = New Size(191, 25)
        Label3.TabIndex = 23
        Label3.Text = "Login your credentials!"
        ' 
        ' btn_login
        ' 
        btn_login.CustomizableEdges = CustomizableEdges2
        btn_login.DisabledState.BorderColor = Color.DarkGray
        btn_login.DisabledState.CustomBorderColor = Color.DarkGray
        btn_login.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_login.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_login.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold, GraphicsUnit.Pixel)
        btn_login.ForeColor = Color.White
        btn_login.Location = New Point(143, 567)
        btn_login.Margin = New Padding(3, 4, 3, 4)
        btn_login.Name = "btn_login"
        btn_login.ShadowDecoration.BorderRadius = 0
        btn_login.ShadowDecoration.CustomizableEdges = CustomizableEdges3
        btn_login.ShadowDecoration.Depth = 64
        btn_login.ShadowDecoration.Enabled = True
        btn_login.ShadowDecoration.Shadow = New Padding(0, 0, 5, 5)
        btn_login.Size = New Size(343, 60)
        btn_login.TabIndex = 22
        btn_login.Text = "LOGIN"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold, GraphicsUnit.Pixel)
        Label7.ForeColor = Color.Teal
        Label7.Location = New Point(213, 99)
        Label7.Name = "Label7"
        Label7.Size = New Size(205, 35)
        Label7.TabIndex = 21
        Label7.Text = "Welocme BACK!"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Black", 12.0F, FontStyle.Bold, GraphicsUnit.Pixel)
        Label2.Location = New Point(143, 420)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 18)
        Label2.TabIndex = 20
        Label2.Text = "Password"
        ' 
        ' txt_password
        ' 
        txt_password.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txt_password.BackColor = Color.Transparent
        txt_password.BorderRadius = 10
        txt_password.CustomizableEdges = CustomizableEdges4
        txt_password.DefaultText = ""
        txt_password.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txt_password.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txt_password.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_password.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_password.FocusedState.BorderColor = Color.Purple
        txt_password.Font = New Font("Segoe UI", 9.0F)
        txt_password.HoverState.BorderColor = Color.Purple
        txt_password.Location = New Point(143, 447)
        txt_password.Margin = New Padding(3, 5, 3, 5)
        txt_password.Name = "txt_password"
        txt_password.PasswordChar = ChrW(0)
        txt_password.PlaceholderText = ""
        txt_password.SelectedText = ""
        txt_password.ShadowDecoration.BorderRadius = 10
        txt_password.ShadowDecoration.CustomizableEdges = CustomizableEdges5
        txt_password.ShadowDecoration.Depth = 64
        txt_password.ShadowDecoration.Enabled = True
        txt_password.ShadowDecoration.Shadow = New Padding(0, 0, 5, 5)
        txt_password.Size = New Size(343, 48)
        txt_password.TabIndex = 19
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 12.0F, FontStyle.Bold, GraphicsUnit.Pixel)
        Label1.Location = New Point(143, 281)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 18)
        Label1.TabIndex = 18
        Label1.Text = "Username"
        ' 
        ' txt_username
        ' 
        txt_username.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txt_username.BackColor = Color.Transparent
        txt_username.BorderRadius = 10
        txt_username.CustomizableEdges = CustomizableEdges6
        txt_username.DefaultText = ""
        txt_username.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txt_username.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txt_username.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_username.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_username.FocusedState.BorderColor = Color.Purple
        txt_username.Font = New Font("Segoe UI", 9.0F)
        txt_username.HoverState.BorderColor = Color.Purple
        txt_username.Location = New Point(143, 308)
        txt_username.Margin = New Padding(3, 5, 3, 5)
        txt_username.Name = "txt_username"
        txt_username.PasswordChar = ChrW(0)
        txt_username.PlaceholderText = ""
        txt_username.SelectedText = ""
        txt_username.ShadowDecoration.BorderRadius = 10
        txt_username.ShadowDecoration.CustomizableEdges = CustomizableEdges7
        txt_username.ShadowDecoration.Depth = 64
        txt_username.ShadowDecoration.Enabled = True
        txt_username.ShadowDecoration.Shadow = New Padding(0, 0, 5, 5)
        txt_username.Size = New Size(343, 48)
        txt_username.TabIndex = 17
        ' 
        ' Guna2Panel2
        ' 
        Guna2Panel2.BackColor = Color.FromArgb(CByte(33), CByte(42), CByte(57))
        Guna2Panel2.Controls.Add(Guna2PictureBox1)
        Guna2Panel2.CustomizableEdges = CustomizableEdges12
        Guna2Panel2.Dock = DockStyle.Fill
        Guna2Panel2.Location = New Point(629, 0)
        Guna2Panel2.Margin = New Padding(3, 4, 3, 4)
        Guna2Panel2.Name = "Guna2Panel2"
        Guna2Panel2.ShadowDecoration.CustomizableEdges = CustomizableEdges13
        Guna2Panel2.Size = New Size(610, 921)
        Guna2Panel2.TabIndex = 1
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges10
        Guna2PictureBox1.Image = My.Resources.Resources.icon_login
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.Location = New Point(94, 237)
        Guna2PictureBox1.Margin = New Padding(3, 4, 3, 4)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges11
        Guna2PictureBox1.Size = New Size(368, 368)
        Guna2PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        Guna2PictureBox1.TabIndex = 0
        Guna2PictureBox1.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1239, 921)
        Controls.Add(Guna2Panel2)
        Controls.Add(Guna2Panel1)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Margin = New Padding(3, 4, 3, 4)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        Guna2Panel2.ResumeLayout(False)
        Guna2Panel2.PerformLayout()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_login As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_register As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lbl_emp As Label
    Friend WithEvents ckb_check As Guna.UI2.WinForms.Guna2ImageCheckBox
End Class
