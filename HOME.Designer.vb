<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HOME
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
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Lbl_home = New Label()
        GroupBox1 = New GroupBox()
        Total_cost = New Label()
        Label3 = New Label()
        Top_sale = New Label()
        Label2 = New Label()
        daily_datagridview = New DataGridView()
        ProdName = New DataGridViewTextBoxColumn()
        Quantity = New DataGridViewTextBoxColumn()
        CustName = New DataGridViewTextBoxColumn()
        War_exp = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        daily_date = New Label()
        GroupBox1.SuspendLayout()
        CType(daily_datagridview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Lbl_home
        ' 
        Lbl_home.AutoSize = True
        Lbl_home.BackColor = Color.Transparent
        Lbl_home.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_home.ForeColor = Color.White
        Lbl_home.Location = New Point(347, 9)
        Lbl_home.Name = "Lbl_home"
        Lbl_home.Size = New Size(102, 33)
        Lbl_home.TabIndex = 2
        Lbl_home.Text = "HOME"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        GroupBox1.Controls.Add(Total_cost)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Top_sale)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(daily_datagridview)
        GroupBox1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(44, 99)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(727, 439)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "DAILY TRANSACTION"
        ' 
        ' Total_cost
        ' 
        Total_cost.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Total_cost.AutoSize = True
        Total_cost.Location = New Point(593, 384)
        Total_cost.Name = "Total_cost"
        Total_cost.Size = New Size(59, 20)
        Total_cost.TabIndex = 6
        Total_cost.Text = "TOTAL"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Location = New Point(524, 384)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 20)
        Label3.TabIndex = 5
        Label3.Text = "TOTAL:"
        ' 
        ' Top_sale
        ' 
        Top_sale.AutoSize = True
        Top_sale.FlatStyle = FlatStyle.Flat
        Top_sale.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Top_sale.Location = New Point(199, 384)
        Top_sale.Name = "Top_sale"
        Top_sale.Size = New Size(71, 20)
        Top_sale.TabIndex = 4
        Top_sale.Text = "Product"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 384)
        Label2.Name = "Label2"
        Label2.Size = New Size(172, 20)
        Label2.TabIndex = 3
        Label2.Text = "TOP SALE PRODUCT:"
        ' 
        ' daily_datagridview
        ' 
        daily_datagridview.AllowUserToAddRows = False
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        daily_datagridview.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        daily_datagridview.BackgroundColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle8.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle8.ForeColor = Color.White
        DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        daily_datagridview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        daily_datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        daily_datagridview.Columns.AddRange(New DataGridViewColumn() {ProdName, Quantity, CustName, War_exp})
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle9.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle9.ForeColor = Color.White
        DataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.False
        daily_datagridview.DefaultCellStyle = DataGridViewCellStyle9
        daily_datagridview.GridColor = Color.White
        daily_datagridview.Location = New Point(0, 45)
        daily_datagridview.Name = "daily_datagridview"
        daily_datagridview.ReadOnly = True
        daily_datagridview.RowHeadersVisible = False
        daily_datagridview.Size = New Size(727, 323)
        daily_datagridview.TabIndex = 0
        ' 
        ' ProdName
        ' 
        ProdName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ProdName.HeaderText = "PRODUCT NAME"
        ProdName.Name = "ProdName"
        ProdName.ReadOnly = True
        ' 
        ' Quantity
        ' 
        Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Quantity.HeaderText = "QUANTITY"
        Quantity.Name = "Quantity"
        Quantity.ReadOnly = True
        ' 
        ' CustName
        ' 
        CustName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        CustName.HeaderText = "CUSTOMER NAME"
        CustName.Name = "CustName"
        CustName.ReadOnly = True
        ' 
        ' War_exp
        ' 
        War_exp.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        War_exp.HeaderText = "WARRANTY EXPIRATION"
        War_exp.Name = "War_exp"
        War_exp.ReadOnly = True
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(582, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 20)
        Label1.TabIndex = 2
        Label1.Text = "DATE:"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' daily_date
        ' 
        daily_date.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        daily_date.AutoSize = True
        daily_date.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        daily_date.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        daily_date.ForeColor = Color.White
        daily_date.Location = New Point(644, 79)
        daily_date.Name = "daily_date"
        daily_date.Size = New Size(52, 20)
        daily_date.TabIndex = 1
        daily_date.Text = "DATE"
        daily_date.TextAlign = ContentAlignment.TopCenter
        ' 
        ' HOME
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.m0sag04
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1133, 772)
        ControlBox = False
        Controls.Add(GroupBox1)
        Controls.Add(Lbl_home)
        Controls.Add(daily_date)
        Controls.Add(Label1)
        DoubleBuffered = True
        Name = "HOME"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(daily_datagridview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_home As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents daily_datagridview As DataGridView
    Friend WithEvents ProdName As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents CustName As DataGridViewTextBoxColumn
    Friend WithEvents War_exp As DataGridViewTextBoxColumn
    Friend WithEvents daily_date As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Top_sale As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Total_cost As Label
End Class
