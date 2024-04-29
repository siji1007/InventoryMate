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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lbl_warranty = New Label()
        War_datagridview = New DataGridView()
        dt_id = New DataGridViewTextBoxColumn()
        dt_duration = New DataGridViewTextBoxColumn()
        dt_unit = New DataGridViewTextBoxColumn()
        dt_type = New DataGridViewTextBoxColumn()
        dt_status = New DataGridViewTextBoxColumn()
        dt_coverage = New DataGridViewTextBoxColumn()
        TextBox1 = New TextBox()
        Label5 = New Label()
        lbl_name_sup = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txt_war_days = New TextBox()
        type_war_combobox = New ComboBox()
        war_status_combobox = New ComboBox()
        war_coverage_combobox = New ComboBox()
        war_month_combobox = New ComboBox()
        Btn_add = New Button()
        Btn_update = New Button()
        Btn_delete = New Button()
        Btn_clear = New Button()
        CType(War_datagridview, ComponentModel.ISupportInitialize).BeginInit()
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
        ' War_datagridview
        ' 
        War_datagridview.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        War_datagridview.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        War_datagridview.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        War_datagridview.BackgroundColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        War_datagridview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        War_datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        War_datagridview.Columns.AddRange(New DataGridViewColumn() {dt_id, dt_duration, dt_unit, dt_type, dt_status, dt_coverage})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        War_datagridview.DefaultCellStyle = DataGridViewCellStyle3
        War_datagridview.Location = New Point(12, 127)
        War_datagridview.Name = "War_datagridview"
        War_datagridview.ReadOnly = True
        War_datagridview.RowHeadersVisible = False
        War_datagridview.Size = New Size(1109, 301)
        War_datagridview.TabIndex = 1
        ' 
        ' dt_id
        ' 
        dt_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dt_id.HeaderText = "ID"
        dt_id.Name = "dt_id"
        dt_id.ReadOnly = True
        dt_id.Width = 51
        ' 
        ' dt_duration
        ' 
        dt_duration.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dt_duration.HeaderText = "DURATION"
        dt_duration.Name = "dt_duration"
        dt_duration.ReadOnly = True
        ' 
        ' dt_unit
        ' 
        dt_unit.HeaderText = "UNIT"
        dt_unit.Name = "dt_unit"
        dt_unit.ReadOnly = True
        ' 
        ' dt_type
        ' 
        dt_type.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dt_type.HeaderText = "TYPE"
        dt_type.Name = "dt_type"
        dt_type.ReadOnly = True
        ' 
        ' dt_status
        ' 
        dt_status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dt_status.HeaderText = "STATUS"
        dt_status.Name = "dt_status"
        dt_status.ReadOnly = True
        ' 
        ' dt_coverage
        ' 
        dt_coverage.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dt_coverage.HeaderText = "COVERAGE"
        dt_coverage.Name = "dt_coverage"
        dt_coverage.ReadOnly = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TextBox1.Location = New Point(910, 98)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Search"
        TextBox1.Size = New Size(213, 23)
        TextBox1.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Image = My.Resources.Resources.search
        Label5.Location = New Point(881, 102)
        Label5.Name = "Label5"
        Label5.Size = New Size(28, 15)
        Label5.TabIndex = 22
        Label5.Text = "       "
        ' 
        ' lbl_name_sup
        ' 
        lbl_name_sup.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lbl_name_sup.AutoSize = True
        lbl_name_sup.BackColor = Color.Transparent
        lbl_name_sup.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_name_sup.ForeColor = Color.White
        lbl_name_sup.Location = New Point(12, 464)
        lbl_name_sup.Name = "lbl_name_sup"
        lbl_name_sup.Size = New Size(97, 20)
        lbl_name_sup.TabIndex = 23
        lbl_name_sup.Text = "DURATION "
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 511)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 20)
        Label1.TabIndex = 24
        Label1.Text = "TYPE"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(12, 560)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 20)
        Label2.TabIndex = 25
        Label2.Text = "STATUS"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(678, 464)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 20)
        Label3.TabIndex = 26
        Label3.Text = "COVERAGE"
        ' 
        ' txt_war_days
        ' 
        txt_war_days.Location = New Point(124, 461)
        txt_war_days.Name = "txt_war_days"
        txt_war_days.PlaceholderText = " ex. 10 Days"
        txt_war_days.Size = New Size(108, 23)
        txt_war_days.TabIndex = 27
        ' 
        ' type_war_combobox
        ' 
        type_war_combobox.AutoCompleteMode = AutoCompleteMode.Suggest
        type_war_combobox.AutoCompleteSource = AutoCompleteSource.ListItems
        type_war_combobox.DropDownStyle = ComboBoxStyle.DropDownList
        type_war_combobox.FormattingEnabled = True
        type_war_combobox.Items.AddRange(New Object() {"Limited Warranty", "Service Warranty", "Extended Warranty ", "Extended Warranty ", "Parts Warranty"})
        type_war_combobox.Location = New Point(122, 508)
        type_war_combobox.Name = "type_war_combobox"
        type_war_combobox.Size = New Size(195, 23)
        type_war_combobox.TabIndex = 29
        ' 
        ' war_status_combobox
        ' 
        war_status_combobox.AutoCompleteMode = AutoCompleteMode.Suggest
        war_status_combobox.AutoCompleteSource = AutoCompleteSource.ListItems
        war_status_combobox.DropDownStyle = ComboBoxStyle.DropDownList
        war_status_combobox.FormattingEnabled = True
        war_status_combobox.Items.AddRange(New Object() {"Active", "Expired"})
        war_status_combobox.Location = New Point(122, 557)
        war_status_combobox.Name = "war_status_combobox"
        war_status_combobox.Size = New Size(195, 23)
        war_status_combobox.TabIndex = 30
        ' 
        ' war_coverage_combobox
        ' 
        war_coverage_combobox.AutoCompleteMode = AutoCompleteMode.Suggest
        war_coverage_combobox.AutoCompleteSource = AutoCompleteSource.ListItems
        war_coverage_combobox.DropDownStyle = ComboBoxStyle.DropDownList
        war_coverage_combobox.FormattingEnabled = True
        war_coverage_combobox.Items.AddRange(New Object() {"Parts", "Labor"})
        war_coverage_combobox.Location = New Point(798, 461)
        war_coverage_combobox.Name = "war_coverage_combobox"
        war_coverage_combobox.Size = New Size(154, 23)
        war_coverage_combobox.TabIndex = 31
        ' 
        ' war_month_combobox
        ' 
        war_month_combobox.AutoCompleteMode = AutoCompleteMode.Suggest
        war_month_combobox.AutoCompleteSource = AutoCompleteSource.ListItems
        war_month_combobox.DropDownStyle = ComboBoxStyle.DropDownList
        war_month_combobox.FormattingEnabled = True
        war_month_combobox.Items.AddRange(New Object() {"Days", "Months", "Years"})
        war_month_combobox.Location = New Point(238, 461)
        war_month_combobox.Name = "war_month_combobox"
        war_month_combobox.Size = New Size(79, 23)
        war_month_combobox.TabIndex = 32
        ' 
        ' Btn_add
        ' 
        Btn_add.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Btn_add.Location = New Point(27, 696)
        Btn_add.Name = "Btn_add"
        Btn_add.Size = New Size(111, 53)
        Btn_add.TabIndex = 33
        Btn_add.Text = "CREATE"
        Btn_add.UseVisualStyleBackColor = True
        ' 
        ' Btn_update
        ' 
        Btn_update.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Btn_update.Location = New Point(266, 696)
        Btn_update.Name = "Btn_update"
        Btn_update.Size = New Size(111, 53)
        Btn_update.TabIndex = 34
        Btn_update.Text = "UPDATE"
        Btn_update.UseVisualStyleBackColor = True
        ' 
        ' Btn_delete
        ' 
        Btn_delete.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Btn_delete.Location = New Point(789, 696)
        Btn_delete.Name = "Btn_delete"
        Btn_delete.Size = New Size(111, 53)
        Btn_delete.TabIndex = 35
        Btn_delete.Text = "DELETE"
        Btn_delete.UseVisualStyleBackColor = True
        ' 
        ' Btn_clear
        ' 
        Btn_clear.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Btn_clear.Location = New Point(1012, 696)
        Btn_clear.Name = "Btn_clear"
        Btn_clear.Size = New Size(111, 53)
        Btn_clear.TabIndex = 36
        Btn_clear.Text = "CLEAR"
        Btn_clear.UseVisualStyleBackColor = True
        ' 
        ' WARRANTY
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.m0sag04
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1133, 772)
        ControlBox = False
        Controls.Add(Btn_clear)
        Controls.Add(Btn_delete)
        Controls.Add(Btn_update)
        Controls.Add(Btn_add)
        Controls.Add(war_month_combobox)
        Controls.Add(war_coverage_combobox)
        Controls.Add(war_status_combobox)
        Controls.Add(type_war_combobox)
        Controls.Add(txt_war_days)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lbl_name_sup)
        Controls.Add(Label5)
        Controls.Add(TextBox1)
        Controls.Add(War_datagridview)
        Controls.Add(lbl_warranty)
        DoubleBuffered = True
        Name = "WARRANTY"
        StartPosition = FormStartPosition.CenterScreen
        CType(War_datagridview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_warranty As Label
    Friend WithEvents War_datagridview As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_name_sup As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_war_days As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents type_war_combobox As ComboBox
    Friend WithEvents war_status_combobox As ComboBox
    Friend WithEvents war_coverage_combobox As ComboBox
    Friend WithEvents war_month_combobox As ComboBox
    Friend WithEvents Btn_add As Button
    Friend WithEvents Btn_update As Button
    Friend WithEvents Btn_delete As Button
    Friend WithEvents Btn_clear As Button
    Friend WithEvents dt_id As DataGridViewTextBoxColumn
    Friend WithEvents dt_duration As DataGridViewTextBoxColumn
    Friend WithEvents dt_unit As DataGridViewTextBoxColumn
    Friend WithEvents dt_type As DataGridViewTextBoxColumn
    Friend WithEvents dt_status As DataGridViewTextBoxColumn
    Friend WithEvents dt_coverage As DataGridViewTextBoxColumn
End Class
