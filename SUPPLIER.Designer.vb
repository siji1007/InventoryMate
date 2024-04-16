<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SUPPLIER
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
        Lbl_supplier = New Label()
        SuspendLayout()
        ' 
        ' Lbl_supplier
        ' 
        Lbl_supplier.AutoSize = True
        Lbl_supplier.BackColor = Color.Transparent
        Lbl_supplier.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_supplier.ForeColor = Color.White
        Lbl_supplier.Location = New Point(0, 0)
        Lbl_supplier.Name = "Lbl_supplier"
        Lbl_supplier.Size = New Size(157, 33)
        Lbl_supplier.TabIndex = 0
        Lbl_supplier.Text = "SUPPLIER"
        ' 
        ' SUPPLIER
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.m0sag04
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(Lbl_supplier)
        Name = "SUPPLIER"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_supplier As Label
End Class
