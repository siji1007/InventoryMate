<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Transactions
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Lbl_transaction = New Label()
        Transaction_panel = New Panel()
        GroupBox3 = New GroupBox()
        txt_EmpID = New TextBox()
        Cb_employeeName = New ComboBox()
        Label8 = New Label()
        Label7 = New Label()
        GroupBox2 = New GroupBox()
        txt_custnumber = New TextBox()
        txt_custemail = New TextBox()
        txt_custaddress = New TextBox()
        txt_custname = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        GroupBox1 = New GroupBox()
        GroupBox4 = New GroupBox()
        Total_cost = New Label()
        add_btn = New Button()
        Cb_warranty = New ComboBox()
        txt_price = New TextBox()
        txt_quantity = New TextBox()
        Cb_Products = New ComboBox()
        Label9 = New Label()
        CLEAR = New Label()
        clear_btn = New Button()
        Label2 = New Label()
        Label1 = New Label()
        lbl_name_sup = New Label()
        transaction_datagridview = New DataGridView()
        Print_btn = New Button()
        dt_id = New DataGridViewTextBoxColumn()
        dt_product_name = New DataGridViewTextBoxColumn()
        dt_quantity = New DataGridViewTextBoxColumn()
        dt_price = New DataGridViewTextBoxColumn()
        dt_warranty = New DataGridViewTextBoxColumn()
        dt_warranty_coverage = New DataGridViewTextBoxColumn()
        dt_total = New DataGridViewTextBoxColumn()
        Transaction_panel.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(transaction_datagridview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Lbl_transaction
        ' 
        Lbl_transaction.AutoSize = True
        Lbl_transaction.BackColor = Color.Transparent
        Lbl_transaction.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_transaction.ForeColor = Color.White
        Lbl_transaction.Location = New Point(496, 26)
        Lbl_transaction.Name = "Lbl_transaction"
        Lbl_transaction.Size = New Size(223, 33)
        Lbl_transaction.TabIndex = 1
        Lbl_transaction.Text = "TRANSACTION"
        ' 
        ' Transaction_panel
        ' 
        Transaction_panel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Transaction_panel.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        Transaction_panel.BorderStyle = BorderStyle.FixedSingle
        Transaction_panel.Controls.Add(GroupBox3)
        Transaction_panel.Controls.Add(GroupBox2)
        Transaction_panel.Controls.Add(GroupBox1)
        Transaction_panel.Location = New Point(65, 89)
        Transaction_panel.Name = "Transaction_panel"
        Transaction_panel.Size = New Size(1032, 612)
        Transaction_panel.TabIndex = 2
        ' 
        ' GroupBox3
        ' 
        GroupBox3.AutoSize = True
        GroupBox3.AutoSizeMode = AutoSizeMode.GrowAndShrink
        GroupBox3.Controls.Add(txt_EmpID)
        GroupBox3.Controls.Add(Cb_employeeName)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Dock = DockStyle.Bottom
        GroupBox3.FlatStyle = FlatStyle.Flat
        GroupBox3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox3.ForeColor = Color.White
        GroupBox3.Location = New Point(0, 518)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(1030, 92)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "EMPLOYEE DETAILS"
        ' 
        ' txt_EmpID
        ' 
        txt_EmpID.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        txt_EmpID.Location = New Point(681, 36)
        txt_EmpID.Name = "txt_EmpID"
        txt_EmpID.Size = New Size(224, 26)
        txt_EmpID.TabIndex = 23
        ' 
        ' Cb_employeeName
        ' 
        Cb_employeeName.AutoCompleteMode = AutoCompleteMode.Suggest
        Cb_employeeName.AutoCompleteSource = AutoCompleteSource.ListItems
        Cb_employeeName.FormattingEnabled = True
        Cb_employeeName.Location = New Point(173, 39)
        Cb_employeeName.Name = "Cb_employeeName"
        Cb_employeeName.Size = New Size(223, 28)
        Cb_employeeName.TabIndex = 19
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(635, 42)
        Label8.Name = "Label8"
        Label8.Size = New Size(26, 20)
        Label8.TabIndex = 12
        Label8.Text = "ID"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(28, 42)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 20)
        Label7.TabIndex = 11
        Label7.Text = "NAME"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.AutoSize = True
        GroupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        GroupBox2.Controls.Add(txt_custnumber)
        GroupBox2.Controls.Add(txt_custemail)
        GroupBox2.Controls.Add(txt_custaddress)
        GroupBox2.Controls.Add(txt_custname)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Dock = DockStyle.Fill
        GroupBox2.FlatStyle = FlatStyle.Flat
        GroupBox2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(0, 346)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1030, 264)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "CUSTOMER DETAILS"
        ' 
        ' txt_custnumber
        ' 
        txt_custnumber.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        txt_custnumber.Location = New Point(681, 77)
        txt_custnumber.Name = "txt_custnumber"
        txt_custnumber.Size = New Size(224, 26)
        txt_custnumber.TabIndex = 22
        ' 
        ' txt_custemail
        ' 
        txt_custemail.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        txt_custemail.Location = New Point(681, 32)
        txt_custemail.Name = "txt_custemail"
        txt_custemail.Size = New Size(224, 26)
        txt_custemail.TabIndex = 21
        ' 
        ' txt_custaddress
        ' 
        txt_custaddress.Location = New Point(172, 80)
        txt_custaddress.Name = "txt_custaddress"
        txt_custaddress.Size = New Size(224, 26)
        txt_custaddress.TabIndex = 20
        ' 
        ' txt_custname
        ' 
        txt_custname.Location = New Point(172, 38)
        txt_custname.Name = "txt_custname"
        txt_custname.Size = New Size(224, 26)
        txt_custname.TabIndex = 19
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(518, 77)
        Label6.Name = "Label6"
        Label6.Size = New Size(157, 20)
        Label6.TabIndex = 10
        Label6.Text = "CONTACT NUMBER"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(518, 35)
        Label5.Name = "Label5"
        Label5.Size = New Size(142, 20)
        Label5.TabIndex = 9
        Label5.Text = "EMAIL ADDRESS"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(28, 80)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 20)
        Label4.TabIndex = 8
        Label4.Text = "ADDRESS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(28, 38)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 20)
        Label3.TabIndex = 7
        Label3.Text = "NAME"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.AutoSize = True
        GroupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        GroupBox1.Controls.Add(GroupBox4)
        GroupBox1.Controls.Add(add_btn)
        GroupBox1.Controls.Add(Cb_warranty)
        GroupBox1.Controls.Add(txt_price)
        GroupBox1.Controls.Add(txt_quantity)
        GroupBox1.Controls.Add(Cb_Products)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(CLEAR)
        GroupBox1.Controls.Add(clear_btn)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(lbl_name_sup)
        GroupBox1.Controls.Add(transaction_datagridview)
        GroupBox1.Dock = DockStyle.Top
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1030, 346)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "PRODUCT DETAILS"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox4.Controls.Add(Total_cost)
        GroupBox4.ForeColor = Color.White
        GroupBox4.Location = New Point(743, 253)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(200, 52)
        GroupBox4.TabIndex = 20
        GroupBox4.TabStop = False
        GroupBox4.Text = "TOTAL COST"
        ' 
        ' Total_cost
        ' 
        Total_cost.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Total_cost.AutoSize = True
        Total_cost.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Total_cost.Location = New Point(8, 22)
        Total_cost.Name = "Total_cost"
        Total_cost.Size = New Size(14, 20)
        Total_cost.TabIndex = 0
        Total_cost.Text = " "
        ' 
        ' add_btn
        ' 
        add_btn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        add_btn.BackColor = Color.White
        add_btn.BackgroundImage = My.Resources.Resources.more
        add_btn.BackgroundImageLayout = ImageLayout.Center
        add_btn.Location = New Point(975, 161)
        add_btn.Name = "add_btn"
        add_btn.Size = New Size(31, 32)
        add_btn.TabIndex = 19
        add_btn.UseVisualStyleBackColor = False
        ' 
        ' Cb_warranty
        ' 
        Cb_warranty.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Cb_warranty.AutoCompleteMode = AutoCompleteMode.Suggest
        Cb_warranty.AutoCompleteSource = AutoCompleteSource.ListItems
        Cb_warranty.FormattingEnabled = True
        Cb_warranty.Location = New Point(745, 212)
        Cb_warranty.Name = "Cb_warranty"
        Cb_warranty.Size = New Size(223, 28)
        Cb_warranty.TabIndex = 18
        ' 
        ' txt_price
        ' 
        txt_price.Location = New Point(173, 295)
        txt_price.Name = "txt_price"
        txt_price.Size = New Size(224, 26)
        txt_price.TabIndex = 17
        ' 
        ' txt_quantity
        ' 
        txt_quantity.Location = New Point(172, 254)
        txt_quantity.Name = "txt_quantity"
        txt_quantity.Size = New Size(224, 26)
        txt_quantity.TabIndex = 16
        ' 
        ' Cb_Products
        ' 
        Cb_Products.AutoCompleteMode = AutoCompleteMode.Suggest
        Cb_Products.AutoCompleteSource = AutoCompleteSource.ListItems
        Cb_Products.FormattingEnabled = True
        Cb_Products.Location = New Point(173, 212)
        Cb_Products.Name = "Cb_Products"
        Cb_Products.Size = New Size(293, 28)
        Cb_Products.TabIndex = 15
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(610, 212)
        Label9.Name = "Label9"
        Label9.Size = New Size(101, 20)
        Label9.TabIndex = 14
        Label9.Text = "WARRANTY"
        ' 
        ' CLEAR
        ' 
        CLEAR.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        CLEAR.AutoSize = True
        CLEAR.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CLEAR.Location = New Point(971, 67)
        CLEAR.Name = "CLEAR"
        CLEAR.Size = New Size(42, 13)
        CLEAR.TabIndex = 13
        CLEAR.Text = "CLEAR"
        ' 
        ' clear_btn
        ' 
        clear_btn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        clear_btn.BackColor = Color.White
        clear_btn.BackgroundImage = My.Resources.Resources.eraser
        clear_btn.BackgroundImageLayout = ImageLayout.Center
        clear_btn.Location = New Point(975, 35)
        clear_btn.Name = "clear_btn"
        clear_btn.Size = New Size(31, 29)
        clear_btn.TabIndex = 12
        clear_btn.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(29, 298)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 20)
        Label2.TabIndex = 11
        Label2.Text = "PRICE"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(29, 254)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 20)
        Label1.TabIndex = 10
        Label1.Text = "QUANTITY"
        ' 
        ' lbl_name_sup
        ' 
        lbl_name_sup.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lbl_name_sup.AutoSize = True
        lbl_name_sup.BackColor = Color.Transparent
        lbl_name_sup.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_name_sup.ForeColor = Color.White
        lbl_name_sup.Location = New Point(29, 212)
        lbl_name_sup.Name = "lbl_name_sup"
        lbl_name_sup.Size = New Size(137, 20)
        lbl_name_sup.TabIndex = 9
        lbl_name_sup.Text = "PRODUCT NAME"
        ' 
        ' transaction_datagridview
        ' 
        transaction_datagridview.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        transaction_datagridview.BackgroundColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        transaction_datagridview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        transaction_datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        transaction_datagridview.Columns.AddRange(New DataGridViewColumn() {dt_id, dt_product_name, dt_quantity, dt_price, dt_warranty, dt_warranty_coverage, dt_total})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        transaction_datagridview.DefaultCellStyle = DataGridViewCellStyle2
        transaction_datagridview.GridColor = Color.White
        transaction_datagridview.Location = New Point(28, 35)
        transaction_datagridview.Name = "transaction_datagridview"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        transaction_datagridview.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        transaction_datagridview.RowHeadersVisible = False
        transaction_datagridview.Size = New Size(940, 158)
        transaction_datagridview.TabIndex = 0
        ' 
        ' Print_btn
        ' 
        Print_btn.Anchor = AnchorStyles.Bottom
        Print_btn.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        Print_btn.FlatStyle = FlatStyle.Flat
        Print_btn.ForeColor = Color.White
        Print_btn.Location = New Point(558, 706)
        Print_btn.Name = "Print_btn"
        Print_btn.Size = New Size(111, 53)
        Print_btn.TabIndex = 11
        Print_btn.Text = "PRINT"
        Print_btn.UseVisualStyleBackColor = False
        ' 
        ' dt_id
        ' 
        dt_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dt_id.HeaderText = "ID"
        dt_id.Name = "dt_id"
        dt_id.Width = 51
        ' 
        ' dt_product_name
        ' 
        dt_product_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dt_product_name.HeaderText = "PRODUCT NAME"
        dt_product_name.Name = "dt_product_name"
        ' 
        ' dt_quantity
        ' 
        dt_quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dt_quantity.HeaderText = "QUANTITY"
        dt_quantity.Name = "dt_quantity"
        dt_quantity.Width = 114
        ' 
        ' dt_price
        ' 
        dt_price.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dt_price.HeaderText = "PRICE"
        dt_price.Name = "dt_price"
        dt_price.Width = 83
        ' 
        ' dt_warranty
        ' 
        dt_warranty.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dt_warranty.HeaderText = "WARRANTY DURATION"
        dt_warranty.Name = "dt_warranty"
        ' 
        ' dt_warranty_coverage
        ' 
        dt_warranty_coverage.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dt_warranty_coverage.HeaderText = "WARRANTY COVERAGE"
        dt_warranty_coverage.Name = "dt_warranty_coverage"
        ' 
        ' dt_total
        ' 
        dt_total.HeaderText = "TOTAL"
        dt_total.Name = "dt_total"
        ' 
        ' Transactions
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.m0sag041
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1133, 772)
        ControlBox = False
        Controls.Add(Print_btn)
        Controls.Add(Transaction_panel)
        Controls.Add(Lbl_transaction)
        Name = "Transactions"
        Transaction_panel.ResumeLayout(False)
        Transaction_panel.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        CType(transaction_datagridview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_transaction As Label
    Friend WithEvents Transaction_panel As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents transaction_datagridview As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_name_sup As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Print_btn As Button
    Friend WithEvents clear_btn As Button
    Friend WithEvents CLEAR As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents Cb_Products As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_EmpID As TextBox
    Friend WithEvents Cb_employeeName As ComboBox
    Friend WithEvents txt_custnumber As TextBox
    Friend WithEvents txt_custemail As TextBox
    Friend WithEvents txt_custaddress As TextBox
    Friend WithEvents txt_custname As TextBox
    Friend WithEvents Cb_warranty As ComboBox
    Friend WithEvents add_btn As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Total_cost As Label
    Friend WithEvents dt_id As DataGridViewTextBoxColumn
    Friend WithEvents dt_product_name As DataGridViewTextBoxColumn
    Friend WithEvents dt_quantity As DataGridViewTextBoxColumn
    Friend WithEvents dt_price As DataGridViewTextBoxColumn
    Friend WithEvents dt_warranty As DataGridViewTextBoxColumn
    Friend WithEvents dt_warranty_coverage As DataGridViewTextBoxColumn
    Friend WithEvents dt_total As DataGridViewTextBoxColumn
End Class
