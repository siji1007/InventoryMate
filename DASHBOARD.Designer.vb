<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DASHBOARD
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DASHBOARD))
        Sidebar = New Panel()
        PictureBox1 = New PictureBox()
        Button7 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel1 = New Panel()
        Panel3 = New Panel()
        Contents = New Panel()
        Sidebar.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Sidebar
        ' 
        Sidebar.BackColor = SystemColors.ControlLightLight
        Sidebar.BorderStyle = BorderStyle.FixedSingle
        Sidebar.Controls.Add(PictureBox1)
        Sidebar.Controls.Add(Button7)
        Sidebar.Controls.Add(Button6)
        Sidebar.Controls.Add(Button5)
        Sidebar.Controls.Add(Button4)
        Sidebar.Controls.Add(Button3)
        Sidebar.Controls.Add(Button2)
        Sidebar.Controls.Add(Button1)
        Sidebar.Controls.Add(Panel1)
        resources.ApplyResources(Sidebar, "Sidebar")
        Sidebar.Name = "Sidebar"
        ' 
        ' PictureBox1
        ' 
        resources.ApplyResources(PictureBox1, "PictureBox1")
        PictureBox1.Name = "PictureBox1"
        PictureBox1.TabStop = False
        ' 
        ' Button7
        ' 
        resources.ApplyResources(Button7, "Button7")
        Button7.FlatAppearance.BorderSize = 0
        Button7.ForeColor = SystemColors.ActiveCaptionText
        Button7.Name = "Button7"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        resources.ApplyResources(Button6, "Button6")
        Button6.FlatAppearance.BorderSize = 0
        Button6.ForeColor = SystemColors.ActiveCaptionText
        Button6.Name = "Button6"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        resources.ApplyResources(Button5, "Button5")
        Button5.FlatAppearance.BorderSize = 0
        Button5.ForeColor = SystemColors.ActiveCaptionText
        Button5.Name = "Button5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        resources.ApplyResources(Button4, "Button4")
        Button4.FlatAppearance.BorderSize = 0
        Button4.ForeColor = SystemColors.ActiveCaptionText
        Button4.Name = "Button4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        resources.ApplyResources(Button3, "Button3")
        Button3.FlatAppearance.BorderSize = 0
        Button3.ForeColor = SystemColors.ActiveCaptionText
        Button3.Name = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        resources.ApplyResources(Button2, "Button2")
        Button2.FlatAppearance.BorderSize = 0
        Button2.ForeColor = SystemColors.ActiveCaptionText
        Button2.Name = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        resources.ApplyResources(Button1, "Button1")
        Button1.FlatAppearance.BorderSize = 0
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Name = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        resources.ApplyResources(Panel1, "Panel1")
        Panel1.Name = "Panel1"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        resources.ApplyResources(Panel3, "Panel3")
        Panel3.Name = "Panel3"
        ' 
        ' Contents
        ' 
        resources.ApplyResources(Contents, "Contents")
        Contents.Name = "Contents"
        ' 
        ' DASHBOARD
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        Controls.Add(Contents)
        Controls.Add(Panel3)
        Controls.Add(Sidebar)
        Name = "DASHBOARD"
        Sidebar.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Sidebar As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Contents As Panel

End Class
