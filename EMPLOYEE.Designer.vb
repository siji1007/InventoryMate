<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EMPLOYEE
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
        lbl_employee = New Label()
        SuspendLayout()
        ' 
        ' lbl_employee
        ' 
        lbl_employee.AutoSize = True
        lbl_employee.BackColor = Color.Transparent
        lbl_employee.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_employee.ForeColor = Color.White
        lbl_employee.Location = New Point(0, 0)
        lbl_employee.Name = "lbl_employee"
        lbl_employee.Size = New Size(174, 33)
        lbl_employee.TabIndex = 0
        lbl_employee.Text = "EMPLOYEE"
        ' 
        ' EMPLOYEE
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.m0sag04
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(lbl_employee)
        Name = "EMPLOYEE"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_employee As Label
End Class
