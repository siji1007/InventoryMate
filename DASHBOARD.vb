Imports MySql.Data.MySqlClient

Public Class DASHBOARD

    ' Define boolean variables to track form status
    Private isHomeFormOpen As Boolean = False
    Private isProductFormOpen As Boolean = False
    Private isWarrantyFormOpen As Boolean = False
    Private isCustomerFormOpen As Boolean = False
    Private isSupplierFormOpen As Boolean = False
    Private isEmployeeFormOpen As Boolean = False
    Private isTransactionFromOpen As Boolean = False

    Private Function ReadFileValueAndNotify() As Integer
        Dim filePath As String = "C:\Users\XtiaN\source\repos\InventoryMate\transac\transaction_status.txt" ' Replace with the actual file path
        Dim fileValue As Integer = 0

        Try
            ' Read the value from the text file
            If System.IO.File.Exists(filePath) Then
                Using reader As New System.IO.StreamReader(filePath)
                    Dim fileContent As String = reader.ReadLine()
                    If Integer.TryParse(fileContent, fileValue) Then
                        ' Successfully parsed the value from the file and it's greater than 0

                    End If
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error reading file: " & ex.Message)
        End Try

        ' Return the file value
        Return fileValue
    End Function





    Private Sub LOGIN_Load(sender As Object, e As EventArgs)


        ' Maximize the window
        WindowState = FormWindowState.Maximized

        Try
            If openDB Then
                ' Assuming Product, Warranty, Customer, Supplier, and Employee are the names of your buttons

                ' Check user privilege and status
                Dim query As New MySqlCommand("SELECT Privilege, Status FROM Users WHERE Status = 'ACTIVE';", Conn)


                Dim userPrivilege = ""
                Dim userStatus = ""

                Using reader = query.ExecuteReader
                    If reader.Read Then
                        userPrivilege = reader.GetString("Privilege")
                        userStatus = reader.GetString("Status")
                    End If
                End Using

                ' Hide buttons based on user privilege and status
                If userPrivilege = "ADMIN" AndAlso userStatus = "ACTIVE" Then
                    ' Show or hide buttons based on admin privilege
                    Btn_home.Visible = True
                    Product.Visible = True
                    Warranty.Visible = True
                    Customer.Visible = True
                    Supplier.Visible = True
                    Employee.Visible = True
                    Transaction.Visible = True
                    MessageBox.Show("Admin log")

                ElseIf userPrivilege = "EMPLOYEE" AndAlso userStatus = "ACTIVE" Then
                    ' Show or hide buttons based on employee privilege
                    Btn_home.Visible = True
                    Product.Visible = True

                    Warranty.Visible = False
                    Customer.Visible = False
                    Supplier.Visible = False
                    Employee.Visible = False
                    Transaction.Visible = True
                    MessageBox.Show("Employee log")

                ElseIf userPrivilege = "OWNER" AndAlso userStatus = "ACTIVE" Then
                    Btn_home.Visible = True
                    Product.Visible = True
                    Warranty.Visible = False
                    Customer.Visible = False
                    Supplier.Visible = False
                    Employee.Visible = False
                    Transaction.Visible = True
                    MessageBox.Show("Owner log")
                Else
                    ' Hide all buttons if user privilege or status doesn't match
                    Product.Visible = False
                    Warranty.Visible = False
                    Customer.Visible = False
                    Supplier.Visible = False
                    Employee.Visible = False
                End If

                Dim home As New HOME
                home.TopLevel = False
                Contents.Controls.Add(home)
                home.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Bottom Or AnchorStyles.Right
                home.BringToFront
                home.WindowState = FormWindowState.Maximized
                home.Show


            Else
                MessageBox.Show("Failed to connect to the database")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            closeDB
        End Try
    End Sub

    Private Sub Btn_home_Click(sender As Object, e As EventArgs) Handles Btn_home.Click
        Me.DoubleBuffered = True

        If isHomeFormOpen = True Then
            MessageBox.Show("The HOME form is already open.", "Form Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim fileValue As Integer = ReadFileValueAndNotify()

            ' Check if the file value is greater than zero
            If fileValue > 0 Then
                MessageBox.Show("You have pending transactions. You can't perform a different task.", "Pending Transactions", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' Proceed with opening the PRODUCT form
                Dim home As New HOME()
                home.TopLevel = False
                Contents.Controls.Add(home)
                home.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Bottom Or AnchorStyles.Right
                home.BringToFront()
                home.WindowState = FormWindowState.Maximized
                home.Show()

                ' Update form status
                isHomeFormOpen = True
                isProductFormOpen = False
                isWarrantyFormOpen = False
                isCustomerFormOpen = False
                isSupplierFormOpen = False
                isEmployeeFormOpen = False
                isTransactionFromOpen = False
            End If
        End If
    End Sub




    Private Sub Product_Click(sender As Object, e As EventArgs) Handles Product.Click
        Me.DoubleBuffered = True ' For forms

        If isProductFormOpen Then
            MessageBox.Show("The PRODUCT form is already open.", "Form Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Read the file value
            Dim fileValue As Integer = ReadFileValueAndNotify()

            ' Check if the file value is greater than zero
            If fileValue > 0 Then
                MessageBox.Show("You have pending transactions. You can't perform a different task.", "Pending Transactions", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' Proceed with opening the PRODUCT form
                Dim prod As New PRODUCT()
                prod.TopLevel = False
                Contents.Controls.Add(prod)
                prod.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Bottom Or AnchorStyles.Right
                prod.BringToFront()
                prod.WindowState = FormWindowState.Maximized
                prod.Show()

                ' Update form status
                isHomeFormOpen = False
                isProductFormOpen = True
                isWarrantyFormOpen = False
                isCustomerFormOpen = False
                isSupplierFormOpen = False
                isEmployeeFormOpen = False
                isTransactionFromOpen = False
            End If
        End If
    End Sub




    Private Sub Warranty_Click(sender As Object, e As EventArgs) Handles Warranty.Click
        If isWarrantyFormOpen Then
            MessageBox.Show("The WARRANTY form Is already open.", "Form Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else


            Dim fileValue As Integer = ReadFileValueAndNotify()
            If fileValue > 0 Then
                MessageBox.Show("You have pending transactions. You can't perform a different task.", "Pending Transactions", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim war As New WARRANTY()
                war.TopLevel = False
                Contents.Controls.Add(war)
                war.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Bottom Or AnchorStyles.Right
                war.BringToFront()
                war.WindowState = FormWindowState.Maximized
                war.Show()

                ' Update form status
                isHomeFormOpen = False
                isWarrantyFormOpen = True
                isCustomerFormOpen = False
                isProductFormOpen = False
                isEmployeeFormOpen = False
                isSupplierFormOpen = False
                isTransactionFromOpen = False
            End If

        End If
    End Sub

    Private Sub Customer_Click(sender As Object, e As EventArgs) Handles Customer.Click
        If isCustomerFormOpen Then
            MessageBox.Show("The Customer form Is already open", "Form Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            Dim FileValue As Integer = ReadFileValueAndNotify()

            If FileValue > 0 Then
                MessageBox.Show("You have pending transactions. You can't perform a different task.", "Pending Transactions", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim cus As New CUSTOMER()
                cus.TopLevel = False
                Contents.Controls.Add(cus)
                cus.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Bottom Or AnchorStyles.Right
                cus.BringToFront()
                cus.WindowState() = FormWindowState.Maximized
                cus.Show()

                isHomeFormOpen = False
                isWarrantyFormOpen = False
                isProductFormOpen = False
                isCustomerFormOpen = True
                isEmployeeFormOpen = False
                isSupplierFormOpen = False
                isTransactionFromOpen = False
            End If



        End If
    End Sub

    Private Sub Supplier_Click(sender As Object, e As EventArgs) Handles Supplier.Click
        If isSupplierFormOpen Then
            MessageBox.Show("The Supplier form Is Already open", "Form Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            Dim fileValue = ReadFileValueAndNotify()

            If fileValue > 0 Then
                MessageBox.Show("You have pending transactions. You can't perform a different task.", "Pending Transactions", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim sup As New SUPPLIER()
                sup.TopLevel = False
                Contents.Controls.Add(sup)
                sup.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Bottom Or AnchorStyles.Right
                sup.BringToFront()
                sup.WindowState() = FormWindowState.Maximized
                sup.Show()


                isHomeFormOpen = False
                isSupplierFormOpen = True
                isWarrantyFormOpen = False
                isProductFormOpen = False
                isCustomerFormOpen = False
                isEmployeeFormOpen = False
                isTransactionFromOpen = False
            End If
        End If

    End Sub


    Private Sub Employee_Click(sender As Object, e As EventArgs) Handles Employee.Click
        If isEmployeeFormOpen Then
            MessageBox.Show("The Employee form Is Already open", "Form Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            Dim FileValue As Integer = ReadFileValueAndNotify()

            If FileValue > 0 Then
                MessageBox.Show("You have pending transactions. You can't perform a different task.", "Pending Transactions", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim emp As New EMPLOYEE()
                emp.TopLevel = False
                Contents.Controls.Add(emp)
                emp.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Bottom Or AnchorStyles.Right
                emp.BringToFront()
                emp.WindowState() = FormWindowState.Maximized
                emp.Show()


                isHomeFormOpen = False
                isSupplierFormOpen = False
                isWarrantyFormOpen = False
                isProductFormOpen = False
                isCustomerFormOpen = False
                isEmployeeFormOpen = True
                isTransactionFromOpen = False
            End If


        End If
    End Sub


    Private Sub Transaction_Click(sender As Object, e As EventArgs) Handles Transaction.Click
        If isTransactionFromOpen Then
            MessageBox.Show("The Transaction form Is Already open", "Form Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim tran As New Transactions()
            tran.TopLevel = False
            Contents.Controls.Add(tran)
            tran.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Bottom Or AnchorStyles.Right
            tran.BringToFront()
            tran.WindowState() = FormWindowState.Maximized
            tran.Show()


            isHomeFormOpen = False
            isSupplierFormOpen = False
            isWarrantyFormOpen = False
            isProductFormOpen = False
            isCustomerFormOpen = False
            isEmployeeFormOpen = False
            isTransactionFromOpen = True


        End If


    End Sub


    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Dim mainForm As MAIN_FORM = TryCast(Me.Owner, MAIN_FORM)
        If result = DialogResult.Yes Then
            Try
                If openDB() Then
                    ' Update user status to OFFLINE
                    Dim updateQuery As New MySqlCommand("UPDATE Users SET Status='OFFLINE' WHERE Status= 'ACTIVE';", Conn)

                    updateQuery.ExecuteNonQuery()
                Else
                    MessageBox.Show("Failed to connect to the database")
                End If
            Catch ex As Exception
                MessageBox.Show("Error updating user status: " & ex.Message)
            Finally
                closeDB()
            End Try

            Me.Hide()
            mainForm.ShowLogin()
        Else
            ' User clicked No, do nothing or handle accordingly
        End If
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Btn_home.MouseEnter
        ' Change button color to green on mouse enter
        Btn_home.BackColor = Color.FromArgb(&H1, &H19, &H10)
        Btn_home.ForeColor = Color.White

    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Btn_home.MouseLeave
        ' Change button color back to its original color on mouse leave
        Btn_home.BackColor = Color.Transparent ' You can set it to any default color or the color it had before the hover
        Btn_home.ForeColor = Color.Black
    End Sub


    Private Sub txt_name_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Check if the database connection is successful
        If openDB() Then
            Dim query As String = "SELECT e.Emp_name, u.Privilege FROM users u INNER JOIN employee e ON u.Employee_ID = e.Emp_ID WHERE u.Status = 'ACTIVE'"
            Using cmd As New MySqlCommand(query, Conn)
                Try
                    ' Execute the query and open a data reader
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Read the data from the reader and display it in txt_name
                            Dim employeeName As String = reader("Emp_name").ToString()
                            Dim userPrivilege As String = reader("Privilege").ToString()
                            txt_name.Text = $"    |{userPrivilege}| {employeeName}"
                        Else
                            MessageBox.Show("No active employee found.")
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error executing query: " & ex.Message)
                End Try
            End Using
            ' Close the database connection after the operation is complete
            closeDB()
        Else
            MessageBox.Show("Failed to open database connection.")
        End If
    End Sub

End Class