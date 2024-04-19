﻿Imports System.Reflection.Metadata
Imports System.Windows.Forms.Design
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Microsoft.VisualBasic.ApplicationServices

Public Class DASHBOARD
    ' Define boolean variables to track form status
    Private isProductFormOpen As Boolean = False
    Private isWarrantyFormOpen As Boolean = False
    Private isCustomerFormOpen As Boolean = False
    Private isSupplierFormOpen As Boolean = False
    Private isEmployeeFormOpen As Boolean = False


    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Maximize the window
        WindowState = FormWindowState.Maximized

        Try
            If openDB() Then
                ' Assuming Product, Warranty, Customer, Supplier, and Employee are the names of your buttons

                ' Check user privilege and status
                Dim query As New MySqlCommand("SELECT Privilege, Status FROM Users WHERE Status = 'ACTIVE';", Conn)


                Dim userPrivilege As String = ""
                Dim userStatus As String = ""

                Using reader As MySqlDataReader = query.ExecuteReader()
                    If reader.Read() Then
                        userPrivilege = reader.GetString("Privilege")
                        userStatus = reader.GetString("Status")
                    End If
                End Using



                ' Hide buttons based on user privilege and status
                If userPrivilege = "ADMIN" AndAlso userStatus = "ACTIVE" Then
                    ' Show or hide buttons based on admin privilege
                    Product.Visible = True
                    Warranty.Visible = True
                    Customer.Visible = True
                    Supplier.Visible = True
                    Employee.Visible = True
                ElseIf userPrivilege = "EMPLOYEE" AndAlso userStatus = "ACTIVE" Then
                    ' Show or hide buttons based on employee privilege
                    Product.Visible = True
                    Warranty.Visible = False
                    Customer.Visible = False
                    Supplier.Visible = False
                    Employee.Visible = False
                Else
                    ' Hide all buttons if user privilege or status doesn't match
                    Product.Visible = False
                    Warranty.Visible = False
                    Customer.Visible = False
                    Supplier.Visible = False
                    Employee.Visible = False
                End If

            Else
                MessageBox.Show("Failed to connect to the database")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            closeDB()
        End Try
    End Sub



    Public Sub ProductBTNShow()


    End Sub
    Private Sub Product_Click(sender As Object, e As EventArgs) Handles Product.Click

        Me.DoubleBuffered = True ' For forms

        If isProductFormOpen Then
            MessageBox.Show("The PRODUCT form is already open.", "Form Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim prod As New PRODUCT()
            prod.TopLevel = False
            Contents.Controls.Add(prod)
            prod.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Bottom Or AnchorStyles.Right
            prod.BringToFront()
            prod.WindowState = FormWindowState.Maximized
            prod.Show()

            ' Update form status
            isProductFormOpen = True
            isWarrantyFormOpen = False
            isCustomerFormOpen = False
            isSupplierFormOpen = False
            isEmployeeFormOpen = False
        End If
    End Sub

    Private Sub Warranty_Click(sender As Object, e As EventArgs) Handles Warranty.Click
        If isWarrantyFormOpen Then
            MessageBox.Show("The WARRANTY form is already open.", "Form Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim war As New WARRANTY()
            war.TopLevel = False
            Contents.Controls.Add(war)
            war.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Bottom Or AnchorStyles.Right
            war.BringToFront()
            war.WindowState = FormWindowState.Maximized
            war.Show()

            ' Update form status
            isWarrantyFormOpen = True
            isCustomerFormOpen = False
            isProductFormOpen = False
            isEmployeeFormOpen = False
            isSupplierFormOpen = False
        End If
    End Sub

    Private Sub Customer_Click(sender As Object, e As EventArgs) Handles Customer.Click
        If isCustomerFormOpen Then
            MessageBox.Show("The Customer form is already open", "Form Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim cus As New CUSTOMER()
            cus.TopLevel = False
            Contents.Controls.Add(cus)
            cus.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Bottom Or AnchorStyles.Right
            cus.BringToFront()
            cus.WindowState() = FormWindowState.Maximized
            cus.Show()

            isWarrantyFormOpen = False
            isProductFormOpen = False
            isCustomerFormOpen = True
            isEmployeeFormOpen = False
            isSupplierFormOpen = False
        End If
    End Sub

    Private Sub Supplier_Click(sender As Object, e As EventArgs) Handles Supplier.Click
        If isSupplierFormOpen Then
            MessageBox.Show("The Supplier form is Already open", "Form Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim sup As New SUPPLIER()
            sup.TopLevel = False
            Contents.Controls.Add(sup)
            sup.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Bottom Or AnchorStyles.Right
            sup.BringToFront()
            sup.WindowState() = FormWindowState.Maximized
            sup.Show()

            isSupplierFormOpen = True
            isWarrantyFormOpen = False
            isProductFormOpen = False
            isCustomerFormOpen = False
            isEmployeeFormOpen = False
        End If

    End Sub

    Private Sub Employee_Click(sender As Object, e As EventArgs) Handles Employee.Click
        If isEmployeeFormOpen Then
            MessageBox.Show("The Employee form is Already open", "Form Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim emp As New EMPLOYEE()
            emp.TopLevel = False
            Contents.Controls.Add(emp)
            emp.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Bottom Or AnchorStyles.Right
            emp.BringToFront()
            emp.WindowState() = FormWindowState.Maximized
            emp.Show()

            isSupplierFormOpen = False
            isWarrantyFormOpen = False
            isProductFormOpen = False
            isCustomerFormOpen = False
            isEmployeeFormOpen = True

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



    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        ' Change button color to green on mouse enter
        Button1.BackColor = Color.FromArgb(&H1, &H19, &H10)
        Button1.ForeColor = Color.White

    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        ' Change button color back to its original color on mouse leave
        Button1.BackColor = Color.Transparent ' You can set it to any default color or the color it had before the hover
        Button1.ForeColor = Color.Black
    End Sub

End Class
