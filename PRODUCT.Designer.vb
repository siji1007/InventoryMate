<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRODUCT
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Product_title = New Label()
        prod_datagridview = New DataGridView()
        prod_id = New DataGridViewTextBoxColumn()
        prod_name_dt = New DataGridViewTextBoxColumn()
        prod_model_dt = New DataGridViewTextBoxColumn()
        prod_color_dt = New DataGridViewTextBoxColumn()
        prod_stocks_dt = New DataGridViewTextBoxColumn()
        prod_price_dt = New DataGridViewTextBoxColumn()
        prod_name_label = New Label()
        product_model_label = New Label()
        product_color_label = New Label()
        Label1 = New Label()
        Label2 = New Label()
        txt_product_name = New TextBox()
        txt_product_model = New TextBox()
        txt_product_color = New TextBox()
        txt_stocks = New TextBox()
        txt_price = New TextBox()
        Btn_add_prod = New Button()
        Btn_update_prod = New Button()
        Btn_delete_prod = New Button()
        Btn_clear_prod = New Button()
        prod_search = New TextBox()
        Label3 = New Label()
        CType(prod_datagridview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Product_title
        ' 
        Product_title.AutoSize = True
        Product_title.BackColor = Color.Transparent
        Product_title.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Product_title.ForeColor = SystemColors.ControlLightLight
        Product_title.Location = New Point(0, 0)
        Product_title.Name = "Product_title"
        Product_title.Size = New Size(178, 33)
        Product_title.TabIndex = 0
        Product_title.Text = "PRODUCTS"
        ' 
        ' prod_datagridview
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        prod_datagridview.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        prod_datagridview.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        prod_datagridview.BackgroundColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        prod_datagridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        prod_datagridview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        prod_datagridview.ColumnHeadersHeight = 50
        prod_datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        prod_datagridview.Columns.AddRange(New DataGridViewColumn() {prod_id, prod_name_dt, prod_model_dt, prod_color_dt, prod_stocks_dt, prod_price_dt})
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.White
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        prod_datagridview.DefaultCellStyle = DataGridViewCellStyle4
        prod_datagridview.GridColor = Color.White
        prod_datagridview.Location = New Point(12, 127)
        prod_datagridview.Name = "prod_datagridview"
        prod_datagridview.ReadOnly = True
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        prod_datagridview.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        prod_datagridview.RowHeadersVisible = False
        prod_datagridview.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = Color.White
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = Color.White
        prod_datagridview.RowsDefaultCellStyle = DataGridViewCellStyle6
        prod_datagridview.ScrollBars = ScrollBars.Vertical
        prod_datagridview.Size = New Size(1109, 301)
        prod_datagridview.TabIndex = 1
        ' 
        ' prod_id
        ' 
        prod_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(0))
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.White
        prod_id.DefaultCellStyle = DataGridViewCellStyle3
        prod_id.HeaderText = "ID"
        prod_id.Name = "prod_id"
        prod_id.ReadOnly = True
        prod_id.Width = 52
        ' 
        ' prod_name_dt
        ' 
        prod_name_dt.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        prod_name_dt.HeaderText = "PRODUCT NAME"
        prod_name_dt.Name = "prod_name_dt"
        prod_name_dt.ReadOnly = True
        ' 
        ' prod_model_dt
        ' 
        prod_model_dt.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        prod_model_dt.HeaderText = "MODEL"
        prod_model_dt.Name = "prod_model_dt"
        prod_model_dt.ReadOnly = True
        ' 
        ' prod_color_dt
        ' 
        prod_color_dt.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        prod_color_dt.HeaderText = "COLOR"
        prod_color_dt.Name = "prod_color_dt"
        prod_color_dt.ReadOnly = True
        ' 
        ' prod_stocks_dt
        ' 
        prod_stocks_dt.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        prod_stocks_dt.HeaderText = "STOCKS"
        prod_stocks_dt.Name = "prod_stocks_dt"
        prod_stocks_dt.ReadOnly = True
        prod_stocks_dt.Width = 111
        ' 
        ' prod_price_dt
        ' 
        prod_price_dt.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        prod_price_dt.HeaderText = "PRICE"
        prod_price_dt.Name = "prod_price_dt"
        prod_price_dt.ReadOnly = True
        prod_price_dt.Width = 90
        ' 
        ' prod_name_label
        ' 
        prod_name_label.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        prod_name_label.AutoSize = True
        prod_name_label.BackColor = Color.Transparent
        prod_name_label.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        prod_name_label.ForeColor = SystemColors.ControlLightLight
        prod_name_label.Location = New Point(27, 453)
        prod_name_label.Name = "prod_name_label"
        prod_name_label.Size = New Size(110, 20)
        prod_name_label.TabIndex = 2
        prod_name_label.Text = "Product Name"
        ' 
        ' product_model_label
        ' 
        product_model_label.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        product_model_label.AutoSize = True
        product_model_label.BackColor = Color.Transparent
        product_model_label.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        product_model_label.ForeColor = SystemColors.ControlLightLight
        product_model_label.Location = New Point(27, 495)
        product_model_label.Name = "product_model_label"
        product_model_label.Size = New Size(111, 20)
        product_model_label.TabIndex = 3
        product_model_label.Text = "Product Model"
        ' 
        ' product_color_label
        ' 
        product_color_label.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        product_color_label.AutoSize = True
        product_color_label.BackColor = Color.Transparent
        product_color_label.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        product_color_label.ForeColor = SystemColors.ControlLightLight
        product_color_label.Location = New Point(27, 537)
        product_color_label.Name = "product_color_label"
        product_color_label.Size = New Size(105, 20)
        product_color_label.TabIndex = 4
        product_color_label.Text = "Product Color"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(648, 453)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 20)
        Label1.TabIndex = 5
        Label1.Text = "Stocks"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(648, 495)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 20)
        Label2.TabIndex = 6
        Label2.Text = "Price"
        ' 
        ' txt_product_name
        ' 
        txt_product_name.Location = New Point(143, 450)
        txt_product_name.Name = "txt_product_name"
        txt_product_name.Size = New Size(230, 23)
        txt_product_name.TabIndex = 7
        ' 
        ' txt_product_model
        ' 
        txt_product_model.Location = New Point(143, 492)
        txt_product_model.Name = "txt_product_model"
        txt_product_model.Size = New Size(230, 23)
        txt_product_model.TabIndex = 8
        ' 
        ' txt_product_color
        ' 
        txt_product_color.Location = New Point(143, 534)
        txt_product_color.Name = "txt_product_color"
        txt_product_color.Size = New Size(230, 23)
        txt_product_color.TabIndex = 9
        ' 
        ' txt_stocks
        ' 
        txt_stocks.Location = New Point(712, 450)
        txt_stocks.Name = "txt_stocks"
        txt_stocks.Size = New Size(230, 23)
        txt_stocks.TabIndex = 10
        ' 
        ' txt_price
        ' 
        txt_price.Location = New Point(712, 492)
        txt_price.Name = "txt_price"
        txt_price.Size = New Size(230, 23)
        txt_price.TabIndex = 11
        ' 
        ' Btn_add_prod
        ' 
        Btn_add_prod.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Btn_add_prod.BackgroundImageLayout = ImageLayout.None
        Btn_add_prod.FlatStyle = FlatStyle.Flat
        Btn_add_prod.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_add_prod.Location = New Point(27, 814)
        Btn_add_prod.Name = "Btn_add_prod"
        Btn_add_prod.Size = New Size(111, 53)
        Btn_add_prod.TabIndex = 12
        Btn_add_prod.Text = "CREATE"
        Btn_add_prod.UseVisualStyleBackColor = True
        ' 
        ' Btn_update_prod
        ' 
        Btn_update_prod.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Btn_update_prod.FlatStyle = FlatStyle.Flat
        Btn_update_prod.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_update_prod.Location = New Point(266, 814)
        Btn_update_prod.Name = "Btn_update_prod"
        Btn_update_prod.Size = New Size(111, 53)
        Btn_update_prod.TabIndex = 13
        Btn_update_prod.Text = "UPDATE"
        Btn_update_prod.UseVisualStyleBackColor = True
        ' 
        ' Btn_delete_prod
        ' 
        Btn_delete_prod.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Btn_delete_prod.FlatStyle = FlatStyle.Flat
        Btn_delete_prod.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_delete_prod.Location = New Point(789, 814)
        Btn_delete_prod.Name = "Btn_delete_prod"
        Btn_delete_prod.Size = New Size(111, 53)
        Btn_delete_prod.TabIndex = 14
        Btn_delete_prod.Text = "DELETE"
        Btn_delete_prod.UseVisualStyleBackColor = True
        ' 
        ' Btn_clear_prod
        ' 
        Btn_clear_prod.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Btn_clear_prod.FlatStyle = FlatStyle.Flat
        Btn_clear_prod.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_clear_prod.Location = New Point(1012, 814)
        Btn_clear_prod.Name = "Btn_clear_prod"
        Btn_clear_prod.Size = New Size(111, 53)
        Btn_clear_prod.TabIndex = 15
        Btn_clear_prod.Text = "CLEAR"
        Btn_clear_prod.UseVisualStyleBackColor = True
        ' 
        ' prod_search
        ' 
        prod_search.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        prod_search.Location = New Point(910, 98)
        prod_search.Name = "prod_search"
        prod_search.PlaceholderText = "Search"
        prod_search.Size = New Size(213, 23)
        prod_search.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Image = My.Resources.Resources.search
        Label3.Location = New Point(881, 102)
        Label3.Name = "Label3"
        Label3.Size = New Size(28, 15)
        Label3.TabIndex = 17
        Label3.Text = "       "
        ' 
        ' PRODUCT
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackgroundImage = My.Resources.Resources.m0sag04
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1133, 890)
        ControlBox = False
        Controls.Add(Label3)
        Controls.Add(prod_search)
        Controls.Add(Btn_clear_prod)
        Controls.Add(Btn_delete_prod)
        Controls.Add(Btn_update_prod)
        Controls.Add(Btn_add_prod)
        Controls.Add(txt_price)
        Controls.Add(txt_stocks)
        Controls.Add(txt_product_color)
        Controls.Add(txt_product_model)
        Controls.Add(txt_product_name)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(product_color_label)
        Controls.Add(product_model_label)
        Controls.Add(prod_name_label)
        Controls.Add(prod_datagridview)
        Controls.Add(Product_title)
        MaximizeBox = False
        MinimizeBox = False
        Name = "PRODUCT"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterParent
        WindowState = FormWindowState.Maximized
        CType(prod_datagridview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Product_title As Label
    Friend WithEvents prod_datagridview As DataGridView
    Friend WithEvents prod_name_label As Label
    Friend WithEvents product_model_label As Label
    Friend WithEvents product_color_label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_product_name As TextBox
    Friend WithEvents txt_product_model As TextBox
    Friend WithEvents txt_product_color As TextBox
    Friend WithEvents txt_stocks As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents Btn_add_prod As Button
    Friend WithEvents Btn_update_prod As Button
    Friend WithEvents Btn_delete_prod As Button
    Friend WithEvents Btn_clear_prod As Button
    Friend WithEvents prod_search As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents prod_id As DataGridViewTextBoxColumn
    Friend WithEvents prod_name_dt As DataGridViewTextBoxColumn
    Friend WithEvents prod_model_dt As DataGridViewTextBoxColumn
    Friend WithEvents prod_color_dt As DataGridViewTextBoxColumn
    Friend WithEvents prod_stocks_dt As DataGridViewTextBoxColumn
    Friend WithEvents prod_price_dt As DataGridViewTextBoxColumn
End Class
