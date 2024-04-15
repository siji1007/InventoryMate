<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOGIN))
        LOGIN_FORM = New Panel()
        Panel6 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        SignUp = New Button()
        SignIn = New Button()
        Password = New TextBox()
        login_title = New Label()
        Username = New TextBox()
        login_logo = New PictureBox()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        LOGIN_FORM.SuspendLayout()
        Panel6.SuspendLayout()
        CType(login_logo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LOGIN_FORM
        ' 
        LOGIN_FORM.Controls.Add(Panel6)
        LOGIN_FORM.Controls.Add(login_logo)
        LOGIN_FORM.Dock = DockStyle.Fill
        LOGIN_FORM.Location = New Point(0, 0)
        LOGIN_FORM.Name = "LOGIN_FORM"
        LOGIN_FORM.Size = New Size(800, 450)
        LOGIN_FORM.TabIndex = 3
        ' 
        ' Panel6
        ' 
        Panel6.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel6.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        Panel6.Controls.Add(Label4)
        Panel6.Controls.Add(Label3)
        Panel6.Controls.Add(Label2)
        Panel6.Controls.Add(SignUp)
        Panel6.Controls.Add(SignIn)
        Panel6.Controls.Add(Password)
        Panel6.Controls.Add(login_title)
        Panel6.Controls.Add(Username)
        Panel6.Dock = DockStyle.Right
        Panel6.Location = New Point(332, 0)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(468, 450)
        Panel6.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.FlatStyle = FlatStyle.Flat
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(52, 264)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 20)
        Label4.TabIndex = 7
        Label4.Text = "PASSWORD"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.FlatStyle = FlatStyle.Flat
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(52, 218)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 20)
        Label3.TabIndex = 6
        Label3.Text = "USERNAME"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(196, 392)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 18)
        Label2.TabIndex = 5
        Label2.Text = "Forgot Password?"
        ' 
        ' SignUp
        ' 
        SignUp.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        SignUp.AutoSizeMode = AutoSizeMode.GrowAndShrink
        SignUp.FlatStyle = FlatStyle.Flat
        SignUp.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SignUp.ForeColor = SystemColors.ControlLight
        SignUp.Location = New Point(316, 324)
        SignUp.Name = "SignUp"
        SignUp.Size = New Size(81, 33)
        SignUp.TabIndex = 4
        SignUp.Text = "Sign Up"
        SignUp.UseVisualStyleBackColor = True
        ' 
        ' SignIn
        ' 
        SignIn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        SignIn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        SignIn.FlatStyle = FlatStyle.Flat
        SignIn.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SignIn.ForeColor = SystemColors.ControlLight
        SignIn.Location = New Point(119, 324)
        SignIn.Name = "SignIn"
        SignIn.Size = New Size(81, 33)
        SignIn.TabIndex = 3
        SignIn.Text = "Sign In"
        SignIn.UseVisualStyleBackColor = True
        ' 
        ' Password
        ' 
        Password.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Password.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        Password.BorderStyle = BorderStyle.FixedSingle
        Password.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Password.ForeColor = SystemColors.Info
        Password.Location = New Point(167, 255)
        Password.Name = "Password"
        Password.PasswordChar = "*"c
        Password.PlaceholderText = "Password"
        Password.Size = New Size(196, 29)
        Password.TabIndex = 2
        ' 
        ' login_title
        ' 
        login_title.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        login_title.AutoSize = True
        login_title.FlatStyle = FlatStyle.Flat
        login_title.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        login_title.ForeColor = SystemColors.ButtonHighlight
        login_title.Location = New Point(205, 41)
        login_title.Name = "login_title"
        login_title.Size = New Size(104, 31)
        login_title.TabIndex = 1
        login_title.Text = "LOGIN"
        ' 
        ' Username
        ' 
        Username.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Username.AutoCompleteMode = AutoCompleteMode.Suggest
        Username.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        Username.BorderStyle = BorderStyle.FixedSingle
        Username.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Username.ForeColor = SystemColors.Info
        Username.Location = New Point(167, 209)
        Username.Name = "Username"
        Username.PlaceholderText = "Username"
        Username.Size = New Size(196, 29)
        Username.TabIndex = 0
        ' 
        ' login_logo
        ' 
        login_logo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        login_logo.Image = CType(resources.GetObject("login_logo.Image"), Image)
        login_logo.Location = New Point(3, 0)
        login_logo.Name = "login_logo"
        login_logo.Size = New Size(422, 450)
        login_logo.SizeMode = PictureBoxSizeMode.StretchImage
        login_logo.TabIndex = 0
        login_logo.TabStop = False
        ' 
        ' LOGIN
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(LOGIN_FORM)
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "LOGIN"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        WindowState = FormWindowState.Maximized
        LOGIN_FORM.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(login_logo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents LOGIN_FORM As Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel6 As Panel
    Friend WithEvents login_logo As PictureBox
    Friend WithEvents Username As TextBox
    Friend WithEvents login_title As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents SignIn As Button
    Friend WithEvents SignUp As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
