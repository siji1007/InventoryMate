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
        Username = New TextBox()
        PictureBox1 = New PictureBox()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        LOGIN_FORM.SuspendLayout()
        Panel6.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LOGIN_FORM
        ' 
        LOGIN_FORM.Controls.Add(Panel6)
        LOGIN_FORM.Controls.Add(PictureBox1)
        LOGIN_FORM.Dock = DockStyle.Fill
        LOGIN_FORM.Location = New Point(0, 0)
        LOGIN_FORM.Name = "LOGIN_FORM"
        LOGIN_FORM.Size = New Size(800, 450)
        LOGIN_FORM.TabIndex = 3
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        Panel6.Controls.Add(Username)
        Panel6.Dock = DockStyle.Fill
        Panel6.Location = New Point(422, 0)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(378, 450)
        Panel6.TabIndex = 1
        ' 
        ' Username
        ' 
        Username.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        Username.BorderStyle = BorderStyle.None
        Username.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Username.ForeColor = SystemColors.Info
        Username.Location = New Point(55, 106)
        Username.Name = "Username"
        Username.PlaceholderText = "Username"
        Username.Size = New Size(196, 22)
        Username.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Left
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(422, 450)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' LOGIN
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LOGIN_FORM)
        Name = "LOGIN"
        Text = "LOGIN"
        LOGIN_FORM.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents LOGIN_FORM As Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Username As TextBox
End Class
