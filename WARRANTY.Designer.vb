<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WARRANTY
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
        lbl_warranty = New Label()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbl_warranty
        ' 
        lbl_warranty.AutoSize = True
        lbl_warranty.BackColor = Color.Transparent
        lbl_warranty.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_warranty.ForeColor = Color.White
        lbl_warranty.Location = New Point(0, 0)
        lbl_warranty.Name = "lbl_warranty"
        lbl_warranty.Size = New Size(181, 33)
        lbl_warranty.TabIndex = 0
        lbl_warranty.Text = "WARRANTY"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 127)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(1109, 301)
        DataGridView1.TabIndex = 1
        ' 
        ' WARRANTY
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.m0sag04
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1133, 890)
        ControlBox = False
        Controls.Add(DataGridView1)
        Controls.Add(lbl_warranty)
        Name = "WARRANTY"
        StartPosition = FormStartPosition.CenterScreen
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_warranty As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
