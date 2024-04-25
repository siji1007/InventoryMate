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
        Transaction = New Button()
        logo_dashboard = New PictureBox()
        LogOut = New Button()
        Employee = New Button()
        Supplier = New Button()
        Customer = New Button()
        Warranty = New Button()
        Product = New Button()
        Button1 = New Button()
        Panel1 = New Panel()
        Panel3 = New Panel()
        txt_name = New Label()
        Contents = New Panel()
        Sidebar.SuspendLayout()
        CType(logo_dashboard, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Sidebar
        ' 
        Sidebar.BackColor = SystemColors.ControlLightLight
        Sidebar.BorderStyle = BorderStyle.FixedSingle
        Sidebar.Controls.Add(Transaction)
        Sidebar.Controls.Add(logo_dashboard)
        Sidebar.Controls.Add(LogOut)
        Sidebar.Controls.Add(Employee)
        Sidebar.Controls.Add(Supplier)
        Sidebar.Controls.Add(Customer)
        Sidebar.Controls.Add(Warranty)
        Sidebar.Controls.Add(Product)
        Sidebar.Controls.Add(Button1)
        Sidebar.Controls.Add(Panel1)
        resources.ApplyResources(Sidebar, "Sidebar")
        Sidebar.Name = "Sidebar"
        ' 
        ' Transaction
        ' 
        resources.ApplyResources(Transaction, "Transaction")
        Transaction.BackColor = Color.Transparent
        Transaction.FlatAppearance.BorderSize = 0
        Transaction.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        Transaction.ForeColor = SystemColors.ActiveCaptionText
        Transaction.Image = My.Resources.Resources.transfer_bank__1_
        Transaction.Name = "Transaction"
        Transaction.UseVisualStyleBackColor = False
        ' 
        ' logo_dashboard
        ' 
        resources.ApplyResources(logo_dashboard, "logo_dashboard")
        logo_dashboard.Name = "logo_dashboard"
        logo_dashboard.TabStop = False
        ' 
        ' LogOut
        ' 
        resources.ApplyResources(LogOut, "LogOut")
        LogOut.FlatAppearance.BorderSize = 0
        LogOut.ForeColor = SystemColors.ActiveCaptionText
        LogOut.Name = "LogOut"
        LogOut.UseVisualStyleBackColor = True
        ' 
        ' Employee
        ' 
        resources.ApplyResources(Employee, "Employee")
        Employee.BackColor = Color.Transparent
        Employee.FlatAppearance.BorderSize = 0
        Employee.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        Employee.ForeColor = SystemColors.ActiveCaptionText
        Employee.Name = "Employee"
        Employee.UseVisualStyleBackColor = False
        ' 
        ' Supplier
        ' 
        resources.ApplyResources(Supplier, "Supplier")
        Supplier.BackColor = Color.Transparent
        Supplier.FlatAppearance.BorderSize = 0
        Supplier.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        Supplier.ForeColor = SystemColors.ActiveCaptionText
        Supplier.Name = "Supplier"
        Supplier.UseVisualStyleBackColor = False
        ' 
        ' Customer
        ' 
        resources.ApplyResources(Customer, "Customer")
        Customer.BackColor = Color.Transparent
        Customer.FlatAppearance.BorderSize = 0
        Customer.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        Customer.ForeColor = SystemColors.ActiveCaptionText
        Customer.Name = "Customer"
        Customer.UseVisualStyleBackColor = False
        ' 
        ' Warranty
        ' 
        resources.ApplyResources(Warranty, "Warranty")
        Warranty.BackColor = Color.Transparent
        Warranty.FlatAppearance.BorderSize = 0
        Warranty.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        Warranty.ForeColor = SystemColors.ActiveCaptionText
        Warranty.Name = "Warranty"
        Warranty.UseVisualStyleBackColor = False
        ' 
        ' Product
        ' 
        resources.ApplyResources(Product, "Product")
        Product.BackColor = Color.Transparent
        Product.FlatAppearance.BorderSize = 0
        Product.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        Product.ForeColor = SystemColors.ActiveCaptionText
        Product.Name = "Product"
        Product.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        resources.ApplyResources(Button1, "Button1")
        Button1.BackColor = Color.Transparent
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Image = My.Resources.Resources.home__3_
        Button1.Name = "Button1"
        Button1.UseVisualStyleBackColor = False
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
        Panel3.Controls.Add(txt_name)
        resources.ApplyResources(Panel3, "Panel3")
        Panel3.Name = "Panel3"
        ' 
        ' txt_name
        ' 
        resources.ApplyResources(txt_name, "txt_name")
        txt_name.FlatStyle = FlatStyle.Flat
        txt_name.ForeColor = Color.White
        txt_name.Image = My.Resources.Resources.user__2_
        txt_name.Name = "txt_name"
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
        CType(logo_dashboard, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Sidebar As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Product As Button
    Friend WithEvents Employee As Button
    Friend WithEvents Supplier As Button
    Friend WithEvents Customer As Button
    Friend WithEvents Warranty As Button
    Friend WithEvents LogOut As Button
    Friend WithEvents logo_dashboard As PictureBox
    Friend WithEvents Contents As Panel
    Friend WithEvents Transaction As Button
    Friend WithEvents txt_name As Label

End Class
