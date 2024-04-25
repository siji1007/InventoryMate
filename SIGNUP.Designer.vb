<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SIGNUP
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
        GroupBox1 = New GroupBox()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        GroupBox1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(143, 23)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(404, 538)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "SIGN UP"
        ' 
        ' SIGNUP
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackgroundImage = My.Resources.Resources.m0sag04
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(671, 573)
        Controls.Add(GroupBox1)
        ForeColor = Color.Cornsilk
        MaximizeBox = False
        MinimizeBox = False
        Name = "SIGNUP"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SIGNUP"
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
End Class
