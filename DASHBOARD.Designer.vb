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
        Contents = New Panel()
        Sidebar.SuspendLayout()
        CType(logo_dashboard, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Sidebar
        ' 
        Sidebar.BackColor = SystemColors.ControlLightLight
        Sidebar.BorderStyle = BorderStyle.FixedSingle
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
        Employee.FlatAppearance.BorderSize = 0
        Employee.ForeColor = SystemColors.ActiveCaptionText
        Employee.Name = "Employee"
        Employee.UseVisualStyleBackColor = True
        ' 
        ' Supplier
        ' 
        resources.ApplyResources(Supplier, "Supplier")
        Supplier.FlatAppearance.BorderSize = 0
        Supplier.ForeColor = SystemColors.ActiveCaptionText
        Supplier.Name = "Supplier"
        Supplier.UseVisualStyleBackColor = True
        ' 
        ' Customer
        ' 
        resources.ApplyResources(Customer, "Customer")
        Customer.FlatAppearance.BorderSize = 0
        Customer.ForeColor = SystemColors.ActiveCaptionText
        Customer.Name = "Customer"
        Customer.UseVisualStyleBackColor = True
        ' 
        ' Warranty
        ' 
        resources.ApplyResources(Warranty, "Warranty")
        Warranty.FlatAppearance.BorderSize = 0
        Warranty.ForeColor = SystemColors.ActiveCaptionText
        Warranty.Name = "Warranty"
        Warranty.UseVisualStyleBackColor = True
        ' 
        ' Product
        ' 
        resources.ApplyResources(Product, "Product")
        Product.FlatAppearance.BorderSize = 0
        Product.ForeColor = SystemColors.ActiveCaptionText
        Product.Name = "Product"
        Product.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        resources.ApplyResources(Button1, "Button1")
        Button1.FlatAppearance.BorderSize = 0
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Image = My.Resources.Resources.home__3_
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
        CType(logo_dashboard, ComponentModel.ISupportInitialize).EndInit()
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

End Class
