<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Attendance
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
        components = New ComponentModel.Container()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        lbl_hr = New Label()
        btn_timeOut = New Guna.UI2.WinForms.Guna2Button()
        btn_timeIn = New Guna.UI2.WinForms.Guna2Button()
        lbl_time = New Label()
        lbl_date = New Label()
        Label4 = New Label()
        txt_email = New Guna.UI2.WinForms.Guna2TextBox()
        Label3 = New Label()
        Label7 = New Label()
        Label1 = New Label()
        txt_employeeId = New Guna.UI2.WinForms.Guna2TextBox()
        Timer1 = New Timer(components)
        Guna2Panel1.SuspendLayout()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Guna2Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.FromArgb(CByte(33), CByte(42), CByte(57))
        Guna2Panel1.Controls.Add(Guna2PictureBox1)
        Guna2Panel1.CustomizableEdges = CustomizableEdges3
        Guna2Panel1.Dock = DockStyle.Left
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Margin = New Padding(3, 4, 3, 4)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Panel1.Size = New Size(629, 921)
        Guna2Panel1.TabIndex = 0
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges1
        Guna2PictureBox1.Image = My.Resources.Resources.icon_attendance
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.Location = New Point(101, 167)
        Guna2PictureBox1.Margin = New Padding(3, 4, 3, 4)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2PictureBox1.Size = New Size(368, 490)
        Guna2PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        Guna2PictureBox1.TabIndex = 0
        Guna2PictureBox1.TabStop = False
        ' 
        ' Guna2Panel2
        ' 
        Guna2Panel2.Controls.Add(lbl_hr)
        Guna2Panel2.Controls.Add(btn_timeOut)
        Guna2Panel2.Controls.Add(btn_timeIn)
        Guna2Panel2.Controls.Add(lbl_time)
        Guna2Panel2.Controls.Add(lbl_date)
        Guna2Panel2.Controls.Add(Label4)
        Guna2Panel2.Controls.Add(txt_email)
        Guna2Panel2.Controls.Add(Label3)
        Guna2Panel2.Controls.Add(Label7)
        Guna2Panel2.Controls.Add(Label1)
        Guna2Panel2.Controls.Add(txt_employeeId)
        Guna2Panel2.CustomizableEdges = CustomizableEdges13
        Guna2Panel2.Dock = DockStyle.Fill
        Guna2Panel2.Location = New Point(629, 0)
        Guna2Panel2.Margin = New Padding(3, 4, 3, 4)
        Guna2Panel2.Name = "Guna2Panel2"
        Guna2Panel2.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        Guna2Panel2.Size = New Size(610, 921)
        Guna2Panel2.TabIndex = 1
        ' 
        ' lbl_hr
        ' 
        lbl_hr.Anchor = AnchorStyles.None
        lbl_hr.AutoSize = True
        lbl_hr.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        lbl_hr.ForeColor = Color.FromArgb(CByte(214), CByte(40), CByte(40))
        lbl_hr.Location = New Point(537, 859)
        lbl_hr.Name = "lbl_hr"
        lbl_hr.Size = New Size(40, 28)
        lbl_hr.TabIndex = 45
        lbl_hr.Text = "HR"
        ' 
        ' btn_timeOut
        ' 
        btn_timeOut.CustomizableEdges = CustomizableEdges5
        btn_timeOut.DisabledState.BorderColor = Color.DarkGray
        btn_timeOut.DisabledState.CustomBorderColor = Color.DarkGray
        btn_timeOut.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_timeOut.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_timeOut.FillColor = Color.FromArgb(CByte(214), CByte(40), CByte(40))
        btn_timeOut.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel)
        btn_timeOut.ForeColor = Color.White
        btn_timeOut.Location = New Point(134, 709)
        btn_timeOut.Margin = New Padding(3, 4, 3, 4)
        btn_timeOut.Name = "btn_timeOut"
        btn_timeOut.ShadowDecoration.BorderRadius = 0
        btn_timeOut.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btn_timeOut.ShadowDecoration.Depth = 64
        btn_timeOut.ShadowDecoration.Enabled = True
        btn_timeOut.ShadowDecoration.Shadow = New Padding(0, 0, 5, 5)
        btn_timeOut.Size = New Size(343, 60)
        btn_timeOut.TabIndex = 44
        btn_timeOut.Text = "TIME OUT"
        ' 
        ' btn_timeIn
        ' 
        btn_timeIn.CustomizableEdges = CustomizableEdges7
        btn_timeIn.DisabledState.BorderColor = Color.DarkGray
        btn_timeIn.DisabledState.CustomBorderColor = Color.DarkGray
        btn_timeIn.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn_timeIn.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn_timeIn.FillColor = Color.FromArgb(CByte(4), CByte(150), CByte(36))
        btn_timeIn.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel)
        btn_timeIn.ForeColor = Color.White
        btn_timeIn.Location = New Point(134, 619)
        btn_timeIn.Margin = New Padding(3, 4, 3, 4)
        btn_timeIn.Name = "btn_timeIn"
        btn_timeIn.ShadowDecoration.BorderRadius = 0
        btn_timeIn.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btn_timeIn.ShadowDecoration.Depth = 64
        btn_timeIn.ShadowDecoration.Enabled = True
        btn_timeIn.ShadowDecoration.Shadow = New Padding(0, 0, 5, 5)
        btn_timeIn.Size = New Size(343, 60)
        btn_timeIn.TabIndex = 43
        btn_timeIn.Text = "TIME IN"
        ' 
        ' lbl_time
        ' 
        lbl_time.Anchor = AnchorStyles.None
        lbl_time.AutoSize = True
        lbl_time.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        lbl_time.ForeColor = Color.Teal
        lbl_time.Location = New Point(134, 533)
        lbl_time.Name = "lbl_time"
        lbl_time.Size = New Size(70, 28)
        lbl_time.TabIndex = 42
        lbl_time.Text = "TIme :"
        ' 
        ' lbl_date
        ' 
        lbl_date.Anchor = AnchorStyles.None
        lbl_date.AutoSize = True
        lbl_date.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        lbl_date.ForeColor = Color.Teal
        lbl_date.Location = New Point(134, 461)
        lbl_date.Name = "lbl_date"
        lbl_date.Size = New Size(68, 28)
        lbl_date.TabIndex = 41
        lbl_date.Text = "Date :"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Left
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
        Label4.Location = New Point(134, 335)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 18)
        Label4.TabIndex = 40
        Label4.Text = "Email"
        ' 
        ' txt_email
        ' 
        txt_email.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txt_email.BackColor = Color.Transparent
        txt_email.BorderRadius = 10
        txt_email.CustomizableEdges = CustomizableEdges9
        txt_email.DefaultText = ""
        txt_email.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txt_email.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txt_email.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_email.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_email.FocusedState.BorderColor = Color.Purple
        txt_email.Font = New Font("Segoe UI", 9F)
        txt_email.HoverState.BorderColor = Color.Purple
        txt_email.Location = New Point(134, 361)
        txt_email.Margin = New Padding(3, 5, 3, 5)
        txt_email.Name = "txt_email"
        txt_email.PasswordChar = ChrW(0)
        txt_email.PlaceholderText = ""
        txt_email.SelectedText = ""
        txt_email.ShadowDecoration.BorderRadius = 10
        txt_email.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        txt_email.ShadowDecoration.Depth = 64
        txt_email.ShadowDecoration.Enabled = True
        txt_email.ShadowDecoration.Shadow = New Padding(0, 0, 5, 5)
        txt_email.Size = New Size(343, 48)
        txt_email.TabIndex = 36
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Pixel)
        Label3.ForeColor = Color.DimGray
        Label3.Location = New Point(200, 163)
        Label3.Name = "Label3"
        Label3.Size = New Size(189, 25)
        Label3.TabIndex = 39
        Label3.Text = "Input your credentials!"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.None
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Pixel)
        Label7.ForeColor = Color.Teal
        Label7.Location = New Point(238, 89)
        Label7.Name = "Label7"
        Label7.Size = New Size(150, 35)
        Label7.TabIndex = 38
        Label7.Text = "Attendance"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Pixel)
        Label1.Location = New Point(134, 239)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 18)
        Label1.TabIndex = 37
        Label1.Text = "Employee Id"
        ' 
        ' txt_employeeId
        ' 
        txt_employeeId.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        txt_employeeId.BackColor = Color.Transparent
        txt_employeeId.BorderRadius = 10
        txt_employeeId.CustomizableEdges = CustomizableEdges11
        txt_employeeId.DefaultText = ""
        txt_employeeId.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txt_employeeId.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txt_employeeId.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_employeeId.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txt_employeeId.FocusedState.BorderColor = Color.Purple
        txt_employeeId.Font = New Font("Segoe UI", 9F)
        txt_employeeId.HoverState.BorderColor = Color.Purple
        txt_employeeId.Location = New Point(134, 265)
        txt_employeeId.Margin = New Padding(3, 5, 3, 5)
        txt_employeeId.Name = "txt_employeeId"
        txt_employeeId.PasswordChar = ChrW(0)
        txt_employeeId.PlaceholderText = ""
        txt_employeeId.SelectedText = ""
        txt_employeeId.ShadowDecoration.BorderRadius = 10
        txt_employeeId.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        txt_employeeId.ShadowDecoration.Depth = 64
        txt_employeeId.ShadowDecoration.Enabled = True
        txt_employeeId.ShadowDecoration.Shadow = New Padding(0, 0, 5, 5)
        txt_employeeId.Size = New Size(343, 48)
        txt_employeeId.TabIndex = 35
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Attendance
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1239, 921)
        Controls.Add(Guna2Panel2)
        Controls.Add(Guna2Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Margin = New Padding(3, 4, 3, 4)
        Name = "Attendance"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Attendance"
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Guna2Panel2.ResumeLayout(False)
        Guna2Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lbl_time As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_email As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_employeeId As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_timeOut As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_timeIn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbl_hr As Label
End Class
