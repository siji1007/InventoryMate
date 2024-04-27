﻿Imports System.CodeDom
Imports System.Threading.Tasks.Dataflow
Imports MySql.Data.MySqlClient

Public Class Transactions
    Private dashboardForm As New DASHBOARD()



    Private Sub Lbl_transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dashboardForm = New DASHBOARD

        Lbl_transaction.TextAlign = ContentAlignment.MiddleCenter
        Lbl_transaction.AutoSize = False
        Lbl_transaction.Width = ClientSize.Width ' Adjust this if needed


        Dim centerX = (ClientSize.Width - Lbl_transaction.Width) \ 2
        Lbl_transaction.Location = New Point(centerX, Lbl_transaction.Location.Y)

        LoadProducts()
        LoadWarranty()
        LoadEmployee()
        LoadCustomer()


    End Sub

    Private Sub Cb_Products_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_Products.SelectedIndexChanged
        ' Check if a product is selected in the ComboBox
        If Cb_Products.SelectedIndex <> -1 Then
            ' Get the selected product name from the ComboBox
            Dim selectedProduct As String = Cb_Products.SelectedItem.ToString()

            ' Check if the database connection is open
            If openDB() Then
                ' Query to retrieve the stock, price, and warranty ID of the selected product
                Dim queryStockPriceWarranty As String = "SELECT prod_stocks, prod_price, Warranty_ID FROM products WHERE CONCAT(prod_name, ' - ', prod_model) = @productName"

                Using commandStockPriceWarranty As New MySqlCommand(queryStockPriceWarranty, Conn)
                    commandStockPriceWarranty.Parameters.AddWithValue("@productName", selectedProduct)

                    Try
                        Dim readerStockPriceWarranty As MySqlDataReader = commandStockPriceWarranty.ExecuteReader()

                        If readerStockPriceWarranty.Read() Then
                            Dim availableStock As Integer = Convert.ToInt32(readerStockPriceWarranty("prod_stocks"))
                            Dim price As Decimal = Convert.ToDecimal(readerStockPriceWarranty("prod_price"))
                            Dim warrantyID As Integer = Convert.ToInt32(readerStockPriceWarranty("Warranty_ID"))

                            ' Update the labels with the retrieved information
                            lbl_stock.Text = "Available Stock: " & availableStock.ToString()
                            txt_price.Text = price.ToString()
                            readerStockPriceWarranty.Close()
                            ' Now, query the warranty information based on the retrieved warranty ID
                            Dim queryWarrantyInfo As String = "SELECT CONCAT(War_Duration, '-', War_DurationUnit) AS warranty_info FROM warranty WHERE War_ID = @warrantyID"

                            Using commandWarrantyInfo As New MySqlCommand(queryWarrantyInfo, Conn)
                                commandWarrantyInfo.Parameters.AddWithValue("@warrantyID", warrantyID)

                                Dim readerWarrantyInfo As MySqlDataReader = commandWarrantyInfo.ExecuteReader()

                                If readerWarrantyInfo.Read() Then
                                    Dim warrantyInfo As String = readerWarrantyInfo("warranty_info").ToString()
                                    ' Set the ComboBox value to the retrieved warranty info
                                    Cb_warranty.Text = warrantyInfo
                                Else
                                    MessageBox.Show("Warranty information not found")
                                End If

                                readerWarrantyInfo.Close()
                            End Using
                        Else
                            lbl_stock.Text = "Stock information not found"
                            txt_price.Text = "Price information not found"
                        End If

                        readerStockPriceWarranty.Close()
                    Catch ex As Exception
                        MessageBox.Show("Error retrieving stock and price information: " & ex.Message)
                    End Try
                End Using

                ' Close the database connection
                closeDB()
            Else
                MessageBox.Show("Database connection failed")
            End If
        End If
    End Sub



    Private Sub LoadProducts()
        Cb_Products.Items.Clear()

        If openDB() Then
            Dim query_product = "SELECT CONCAT(prod_name, ' - ', prod_model) AS product_info FROM products WHERE prod_stocks > 0"
            Using Command As New MySqlCommand(query_product, Conn)
                Try
                    Using reader = Command.ExecuteReader
                        While reader.Read
                            ' Add the concatenated product information to the ComboBox items
                            Cb_Products.Items.Add(reader("product_info").ToString)
                        End While
                        reader.Close()
                    End Using

                Catch ex As Exception
                    MessageBox.Show(ex.Message & " product load")
                Finally
                    closeDB()
                End Try
            End Using
        Else
            MessageBox.Show("The database is not connected.")
        End If

    End Sub


    Private Sub LoadWarranty()


        If openDB() Then
            Dim query_warranty = "SELECT CONCAT(War_Duration, '-', War_DurationUnit) AS warranty_info FROM warranty"
            Using cmd As New MySqlCommand(query_warranty, Conn)
                Try
                    Using reader = cmd.ExecuteReader
                        If reader.HasRows Then
                            While reader.Read
                                Cb_warranty.Items.Add(reader("warranty_info").ToString)
                            End While
                        End If
                        reader.Close()
                    End Using
                Catch ex As Exception
                    MessageBox.Show(ex.Message & "WARRANTY LOAD")
                Finally
                    closeDB()

                End Try

            End Using


        Else
            MessageBox.Show("The Database failed to connect.")
        End If


    End Sub

    Private Sub LoadEmployee()
        If openDB() Then
            Dim query_employee = "SELECT Emp_name FROM employee"
            Using cmd As New MySqlCommand(query_employee, Conn)
                Try
                    Using reader = cmd.ExecuteReader
                        While reader.Read
                            ' Add each Emp_name to the ComboBox
                            Cb_employeeName.Items.Add(reader("Emp_name").ToString)
                        End While
                        reader.Close()
                    End Using

                Catch ex As Exception
                    MessageBox.Show(ex.Message & " Employee load")
                Finally
                    closeDB()
                End Try
            End Using
        Else
            MessageBox.Show("The database is not connected!")
        End If
    End Sub


    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click

        Dim ProdName As String = Cb_Products.Text
        Dim ProdQuantity As String = txt_quantity.Text
        Dim ProdPrice As String = txt_price.Text
        Dim ProdWarrantyDuration As String = Cb_warranty.Text
        Dim ProdWarrantyCoverage As String = ""

        ' Check if the database is open and retrieve the warranty coverage
        If openDB() Then
            Dim query As String = "SELECT War_Coverage FROM warranty"
            Using command As New MySqlCommand(query, Conn)
                Try
                    Using reader = command.ExecuteReader()
                        If reader.HasRows Then
                            If reader.Read() Then
                                ProdWarrantyCoverage = reader("War_Coverage").ToString()
                            End If
                        End If
                    End Using ' Close the reader here
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    closeDB()
                End Try
            End Using
        Else
            MessageBox.Show("Database failed to connect")
            Exit Sub ' Exit the method if the database connection fails
        End If

        ' Validate and convert quantity to integer
        Dim ProdQuantityInt As Integer
        If Not Integer.TryParse(ProdQuantity, ProdQuantityInt) Then
            dashboardForm.Product.Enabled = False
            MessageBox.Show("Invalid quantity. Please enter a valid numeric value for quantity.")
            Exit Sub ' Exit the method if quantity is invalid
        End If

        ' Check if the product stock is available
        Dim queryStock As String = "SELECT prod_stocks, prod_id FROM products WHERE CONCAT(prod_name, ' - ', prod_model) = @productInfo"
        If openDB() Then
            Using commandStock As New MySqlCommand(queryStock, Conn)
                commandStock.Parameters.AddWithValue("@productInfo", ProdName)
                Dim readerStock = commandStock.ExecuteReader()
                If readerStock.HasRows AndAlso readerStock.Read() Then
                    Dim availableStock As Integer = Convert.ToInt32(readerStock("prod_stocks"))
                    Dim productId As Integer = Convert.ToInt32(readerStock("prod_id"))
                    If availableStock >= ProdQuantityInt Then
                        ' Deduct the quantity from stock
                        Dim newStock As Integer = availableStock - ProdQuantityInt
                        readerStock.Close() ' Close the reader here

                        ' Update the stock in the database
                        Dim updateQuery As String = "UPDATE products SET prod_stocks = @newStock WHERE prod_id = @productId"
                        Using updateCommand As New MySqlCommand(updateQuery, Conn)
                            updateCommand.Parameters.AddWithValue("@newStock", newStock)
                            updateCommand.Parameters.AddWithValue("@productId", productId)
                            Dim rowsAffected = updateCommand.ExecuteNonQuery()
                            If rowsAffected > 0 Then
                                ' Calculate total for the current product
                                Dim ProdPriceDec As Decimal
                                If Not Decimal.TryParse(ProdPrice, ProdPriceDec) Then
                                    MessageBox.Show("Invalid price. Please enter a valid numeric value for price.")
                                    Exit Sub ' Exit the method if price is invalid
                                End If

                                Dim ProdTotal As Decimal = ProdQuantityInt * ProdPriceDec

                                ' Add the product details to the DataGridView
                                Dim row As String() = {productId.ToString(), ProdName, ProdQuantity, ProdPrice, ProdWarrantyDuration, ProdWarrantyCoverage, ProdTotal.ToString()}
                                transaction_datagridview.Rows.Add(row)

                                ' Calculate total cost for all rows in the DataGridView
                                Dim totalCost As Decimal = 0
                                For Each dgvRow As DataGridViewRow In transaction_datagridview.Rows
                                    Dim rowTotal As Decimal
                                    If Decimal.TryParse(dgvRow.Cells("dt_total").Value?.ToString(), rowTotal) Then
                                        totalCost += rowTotal
                                    End If
                                Next

                                ' Update Total_cost label with the calculated total cost
                                Total_cost.Text = "PHP " & totalCost.ToString()

                                ' Clear input fields and selections
                                Cb_Products.SelectedIndex = -1
                                txt_quantity.Clear()
                                txt_price.Clear()
                                Cb_warranty.SelectedIndex = -1


                                Dim filePath As String = "C:\Users\XtiaN\source\repos\InventoryMate\transac\transaction_status.txt"


                                Try
                                    ' Read the current value from the text file
                                    Dim currentValue As Integer = 0
                                    If System.IO.File.Exists(filePath) Then
                                        Dim currentValueText As String = My.Computer.FileSystem.ReadAllText(filePath)
                                        Integer.TryParse(currentValueText, currentValue)
                                    End If

                                    ' Increment the current value by 1
                                    currentValue += 1

                                    ' Write the updated value back to the text file
                                    My.Computer.FileSystem.WriteAllText(filePath, currentValue.ToString(), False)

                                    MessageBox.Show("Value updated in the text file: " & currentValue.ToString())
                                Catch ex As Exception
                                    MessageBox.Show("Error updating the text file: " & ex.Message)
                                End Try



                                ' Debug message to verify if data is added
                                MessageBox.Show("Product added to DataGridView.")
                                LoadProducts()
                                lbl_stock.Text = "STOCKS"
                            Else
                                MessageBox.Show("Failed to update stock in the database.")
                            End If
                        End Using
                    Else
                        readerStock.Close()
                        MessageBox.Show("The stock available is only " & availableStock & " for this product.")
                    End If
                Else
                    MessageBox.Show("Product information not found in the database.")
                End If
            End Using
        Else
            MessageBox.Show("Database failed to connect")
        End If
    End Sub








    Private Sub Cb_employeeName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_employeeName.SelectedIndexChanged
        ' Get the selected Emp_name from the ComboBox
        Dim selectedEmpName As String = Cb_employeeName.SelectedItem?.ToString()

        If Not String.IsNullOrEmpty(selectedEmpName) Then
            If openDB() Then
                Dim query_id As String = "SELECT Emp_ID FROM employee WHERE Emp_name = @empName"

                Using command As New MySqlCommand(query_id, Conn)
                    command.Parameters.AddWithValue("@empName", selectedEmpName)

                    Try
                        Dim empID As Object = command.ExecuteScalar()
                        If empID IsNot Nothing AndAlso Not DBNull.Value.Equals(empID) Then
                            ' Update txt_id with the retrieved Emp_ID
                            txt_EmpID.Text = empID.ToString()
                        Else
                            txt_EmpID.Text = "ID not found"
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally
                        closeDB()
                    End Try
                End Using
            Else
                MessageBox.Show("The database is not connected!")
            End If
        End If
    End Sub

    Private Sub transaction_datagridview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles transaction_datagridview.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = transaction_datagridview.Rows(e.RowIndex)

            Dim ProdName As String = selectedRow.Cells("dt_product_name").Value.ToString()
            Dim ProdQuantity As String = selectedRow.Cells("dt_quantity").Value.ToString()
            Dim ProdPrice As String = selectedRow.Cells("dt_price").Value.ToString()
            Dim ProdWarDuration As String = selectedRow.Cells("dt_warranty").Value.ToString()
            Dim ProdWarCoverage As String = selectedRow.Cells("dt_warranty_coverage").Value.ToString()
            Dim ProdTotal As String = selectedRow.Cells("dt_total").Value.ToString()


            For Each row As DataGridViewRow In transaction_datagridview.Rows


                If row.Index = e.RowIndex Then
                    row.Selected = True
                Else
                    row.Selected = False
                End If

            Next



        End If
    End Sub

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        ' Check if there is a selected row
        If transaction_datagridview.SelectedRows.Count > 0 Then
            ' Get the prod_id from the selected row
            Dim productId As Integer = Convert.ToInt32(transaction_datagridview.SelectedRows(0).Cells("dt_id").Value)

            ' Get the quantity to be restored from the selected row
            Dim quantityToRestore As Integer = 0
            If Integer.TryParse(transaction_datagridview.SelectedRows(0).Cells("dt_quantity").Value?.ToString(), quantityToRestore) Then
                ' Check if the database is open
                If openDB() Then
                    ' Retrieve the current stock for the selected product
                    Dim queryStock As String = "SELECT prod_stocks FROM products WHERE prod_id = @productId"
                    Using commandStock As New MySqlCommand(queryStock, Conn)
                        commandStock.Parameters.AddWithValue("@productId", productId)
                        Dim currentStock As Integer = Convert.ToInt32(commandStock.ExecuteScalar())

                        commandStock.Dispose()

                        ' Calculate the new stock after restoration
                        Dim newStock As Integer = currentStock + quantityToRestore

                        ' Update the stock in the database
                        Dim updateQuery As String = "UPDATE products SET prod_stocks = @newStock WHERE prod_id = @productId"
                        Using updateCommand As New MySqlCommand(updateQuery, Conn)
                            updateCommand.Parameters.AddWithValue("@newStock", newStock)
                            updateCommand.Parameters.AddWithValue("@productId", productId)
                            Dim rowsAffected = updateCommand.ExecuteNonQuery()
                            If rowsAffected > 0 Then
                                ' Remove the selected row from the DataGridView
                                transaction_datagridview.Rows.Remove(transaction_datagridview.SelectedRows(0))

                                ' Update Total_cost label by deducting the rowTotal
                                Dim totalCost As Decimal = 0
                                For Each dgvRow As DataGridViewRow In transaction_datagridview.Rows
                                    Dim rowSubTotal As Decimal
                                    If Decimal.TryParse(dgvRow.Cells("dt_total").Value?.ToString(), rowSubTotal) Then
                                        totalCost += rowSubTotal
                                    End If
                                Next
                                Total_cost.Text = totalCost.ToString()

                                ' Debug message
                                MessageBox.Show("Stock restored and row cleared.")
                                LoadProducts()



                                'READ THE FILE AND DICREAMENT THE CURRENT VALUE TO 1, MEANS THAT DEDUCTED DATA IS PERFORM IN THE DATAGRID
                                Dim filePath As String = "C:\Users\XtiaN\source\repos\InventoryMate\transac\transaction_status.txt"

                                Try
                                    ' Read the current value from the text file
                                    Dim currentValue As Integer = 0
                                    If System.IO.File.Exists(filePath) Then
                                        Dim currentValueText As String = My.Computer.FileSystem.ReadAllText(filePath)
                                        Integer.TryParse(currentValueText, currentValue)
                                    End If

                                    ' Deduct 1 from the current value
                                    currentValue -= 1

                                    ' Write the updated value back to the text file
                                    My.Computer.FileSystem.WriteAllText(filePath, currentValue.ToString(), False)

                                    MessageBox.Show("Value updated in the text file: " & currentValue.ToString())
                                Catch ex As Exception
                                    MessageBox.Show("Error updating the text file: " & ex.Message)
                                End Try
                            Else
                                MessageBox.Show("Failed to update stock in the database.")
                            End If
                        End Using
                    End Using
                    closeDB()
                Else
                    MessageBox.Show("Database failed to connect")
                End If
            Else
                MessageBox.Show("Invalid quantity to restore.")
            End If
        Else
            MessageBox.Show("Please select a row to clear.")
        End If
    End Sub













    Private Sub Print_btn_Click(sender As Object, e As EventArgs) Handles Print_btn.Click
        Dim message As String = ""

        ' Variables for calculating total cost and service fee
        Dim totalPrice As Decimal = 0
        Dim serviceFee As Decimal = 0

        ' Check if the DataGridView has rows
        If transaction_datagridview.Rows.Count > 1 Then
            ' Open the database connection
            If openDB() Then
                Dim selectedProductId As Integer = Convert.ToInt32(transaction_datagridview.Rows(0).Cells("dt_id").Value)

                ' Include customer details in the message
                message &= "Customer Details:" & vbCrLf
                message &= "Name: " & txt_Custname.Text & vbCrLf
                message &= "Address: " & txt_custaddress.Text & vbCrLf
                message &= "Email: " & txt_custemail.Text & vbCrLf
                message &= "Number: " & txt_custnumber.Text & vbCrLf & vbCrLf

                ' Include selected employee in the message
                message &= "Selected Employee: " & Cb_employeeName.Text & vbCrLf & vbCrLf

                ' Include selected products and quantities from the DataGridView in the message
                message &= "Selected Products and Quantities:" & vbCrLf
                For Each row As DataGridViewRow In transaction_datagridview.Rows
                    ' Check if the row is not a new row and is selected
                    If Not row.IsNewRow Then
                        ' Get the product name, quantity, price, and duration of warranty from the row
                        Dim productId As String = row.Cells("dt_id").Value.ToString()
                        Dim productName As String = row.Cells("dt_product_name").Value.ToString()
                        Dim quantity As Integer = Convert.ToInt32(row.Cells("dt_quantity").Value)
                        Dim price As Decimal = Convert.ToDecimal(row.Cells("dt_price").Value)
                        Dim warrantyDuration As String = row.Cells("dt_warranty").Value.ToString()

                        ' Calculate total price for each product
                        Dim productTotalPrice As Decimal = price * quantity
                        totalPrice += productTotalPrice

                        ' Concatenate the product details to the message
                        message &= productId & "  " & productName & ": " & quantity & " x ₱" & price.ToString("0.00") & " (" & warrantyDuration & ") = ₱" & productTotalPrice.ToString("0.00") & vbCrLf
                    End If
                Next

                ' Include service fee in the total cost calculation
                If Decimal.TryParse(txt_service_fee.Text, serviceFee) Then
                    totalPrice += serviceFee
                    message &= vbCrLf & "Service Fee: ₱" & serviceFee.ToString("0.00") & vbCrLf
                Else
                    MessageBox.Show("Invalid service fee. Please enter a valid numeric value.")
                    Exit Sub ' Exit the method if service fee is invalid
                End If

                ' Include total cost in the message
                message &= vbCrLf & "Total Cost: ₱" & totalPrice.ToString("0.00") & vbCrLf

                Dim currentDate As String = Date.Now.ToString("yyyy-MM-dd HH:mm:ss")

                message &= vbCrLf & "DATE OF TRANSACTION " & currentDate.ToString()

                ' Display the message box with all the data
                MessageBox.Show(message)

                ' Now, insert the transaction data into your database
                InsertTransactionToDatabase(totalPrice, serviceFee, currentDate)
            Else
                ' Display a message if failed to open the database connection
                MessageBox.Show("Failed to open the database connection.")
            End If
        Else
            ' Display a message if there are no rows in the DataGridView
            MessageBox.Show("Can't perform print action. No product has been inserted.")
        End If
    End Sub
    Private Sub InsertTransactionToDatabase(totalPrice As Decimal, serviceFee As Decimal, currentDate As String)
        If openDB() Then
            Dim customerId As Integer = GetCustomerIdByName(txt_Custname.Text)

            ' Validate Customer ID
            If customerId <= 0 Then
                MessageBox.Show("Invalid customer selected.")
                Exit Sub
            End If

            ' Loop through each row in the DataGridView
            For Each row As DataGridViewRow In transaction_datagridview.Rows
                ' Check if the row is not a new row
                If Not row.IsNewRow Then
                    ' Retrieve the values from the current row
                    Dim selectedProductId As Integer = Convert.ToInt32(row.Cells("dt_id").Value)
                    Dim warrantyId As Integer = GetWarrantyIdFromProduct(selectedProductId)
                    Dim quantity As Integer = Convert.ToInt32(row.Cells("dt_quantity").Value)

                    ' Validate Warranty ID
                    If warrantyId <= 0 Then
                        MessageBox.Show("Invalid warranty for product ID: " & selectedProductId & ". Skipping insertion for this product.")
                        Continue For ' Skip this product and move to the next one
                    End If

                    ' Insert into Transactions table for this row
                    Try
                        If openDB() Then
                            Dim query As String = "INSERT INTO Transactions (Prod_ID, Customer_ID, Emp_ID, Warr_ID, Quantity, S_fee, Total_cost, Transact_date) " &
  "VALUES (@Prod_ID, @Customer_ID, @Emp_ID, @Warr_ID, @Quantity, @S_fee, @Total_cost, @Transac_date)"

                            Using cmd As New MySqlCommand(query, Conn)
                                cmd.Parameters.AddWithValue("@Prod_ID", selectedProductId)
                                cmd.Parameters.AddWithValue("@Customer_ID", customerId)
                                cmd.Parameters.AddWithValue("@Emp_ID", txt_EmpID.Text)
                                cmd.Parameters.AddWithValue("@Warr_ID", warrantyId)
                                cmd.Parameters.AddWithValue("@Quantity", quantity)
                                cmd.Parameters.AddWithValue("@S_fee", serviceFee)
                                cmd.Parameters.AddWithValue("@Total_cost", totalPrice)
                                cmd.Parameters.AddWithValue("@Transac_date", currentDate)

                                Try
                                    cmd.ExecuteNonQuery()
                                Catch ex As Exception
                                    MessageBox.Show("Error inserting product ID " & selectedProductId & ": " & ex.Message)

                                End Try

                            End Using
                        Else
                            MessageBox.Show("Failed to Connect database")
                        End If

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally
                        closeDB()
                    End Try



                End If
            Next

            MessageBox.Show("Transaction data inserted successfully.")
            closeDB()
        Else
            MessageBox.Show("Failed to connect to the database.")
        End If
    End Sub





    Private Function GetWarrantyIdFromProduct(prodId As Integer) As Integer
        Dim warrantyId As Integer = -1 ' Default value if warranty ID is not found

        If openDB() Then
            Dim query As String = "SELECT Warranty_ID FROM products WHERE prod_id = @ProdId"

            Using cmd As New MySqlCommand(query, Conn)
                cmd.Parameters.AddWithValue("@ProdId", prodId)

                Try
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        warrantyId = Convert.ToInt32(result)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error retrieving warranty ID: " & ex.Message)
                End Try
            End Using

            closeDB()
        Else
            MessageBox.Show("Failed to connect to the database.")
        End If

        Return warrantyId
    End Function


    Private Function GetCustomerIdByName(customerName As String) As Integer
        Dim customerId As Integer = -1 ' Default value if customer ID is not found

        If openDB() Then
            Dim query As String = "SELECT Cust_ID FROM customer WHERE Cust_name = @CustomerName"

            Using cmd As New MySqlCommand(query, Conn)
                cmd.Parameters.AddWithValue("@CustomerName", customerName)

                Try
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        customerId = Convert.ToInt32(result)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error retrieving customer ID: " & ex.Message)
                End Try
            End Using

            closeDB()
        Else
            MessageBox.Show("Failed to connect to the database.")
        End If

        Return customerId
    End Function

    Private Function GetTotalQuantity() As Integer
        Dim totalQuantity As Integer = 0

        ' Calculate total quantity from the DataGridView
        For Each row As DataGridViewRow In transaction_datagridview.Rows
            ' Check if the row is not a new row and is selected
            If Not row.IsNewRow Then
                ' Get the quantity from the row and add it to totalQuantity
                Dim quantity As Integer = Convert.ToInt32(row.Cells("dt_quantity").Value)
                totalQuantity += quantity
            End If
        Next

        Return totalQuantity
    End Function














    Private Sub LoadCustomer()
        Try
            If openDB() Then
                Dim query As New MySqlCommand("SELECT Cust_name FROM Customer;", Conn)

                Using reader As MySqlDataReader = query.ExecuteReader()
                    While reader.Read()
                        Dim custName As String = reader.GetString("Cust_name")
                        txt_Custname.Items.Add(custName) ' Assuming ListBox1 is the name of your ListBox control
                    End While
                End Using
            Else
                MessageBox.Show("Failed to connect to the database")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            closeDB()
        End Try
    End Sub




    Private Sub txt_Empname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_Custname.SelectedIndexChanged
        ' Clear the TextBoxes when no item is selected in the ComboBox
        If txt_Custname.SelectedIndex = -1 Then
            txt_custaddress.Text = ""
            txt_custnumber.Text = ""
            txt_custemail.Text = ""
            ' You can clear other TextBoxes as needed
            Return
        End If

        Try
            If openDB() Then
                Dim selectedCustName As String = txt_Custname.SelectedItem.ToString()
                Dim query As New MySqlCommand("SELECT * FROM Customer WHERE Cust_name = @CustName;", Conn)
                query.Parameters.AddWithValue("@CustName", selectedCustName)

                Using reader As MySqlDataReader = query.ExecuteReader()
                    If reader.Read() Then
                        ' Check if the data is not DBNull before assigning to variables
                        If Not reader.IsDBNull(reader.GetOrdinal("Cust_address")) Then
                            txt_custaddress.Text = reader.GetString("Cust_address")
                        End If

                        If Not reader.IsDBNull(reader.GetOrdinal("Cust_cnumber")) Then
                            txt_custnumber.Text = reader.GetString("Cust_cnumber")
                        End If

                        If Not reader.IsDBNull(reader.GetOrdinal("Cust_email")) Then
                            txt_custemail.Text = reader.GetString("Cust_email")
                        End If

                        ' You can handle other attributes similarly
                    Else
                        MessageBox.Show("No data found for the selected customer.")
                    End If
                End Using
            Else
                MessageBox.Show("Failed to connect to the database")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            closeDB()
        End Try
    End Sub







    Private Sub InsertCustomerToDatabase()
        Dim Cust_name As String = txt_Custname.Text.Trim()
        Dim Cust_address As String = txt_custaddress.Text.Trim()
        Dim Cust_email As String = txt_custemail.Text.Trim()
        Dim Cust_cnumber As String = txt_custnumber.Text.Trim()

        ' Check if the contact number starts with "+63" and remove it
        If Cust_cnumber.StartsWith("+63") AndAlso Cust_cnumber.Length > 3 Then
            Cust_cnumber = Cust_cnumber.Substring(3) ' Remove "+63"
        End If

        If String.IsNullOrWhiteSpace(Cust_name) OrElse String.IsNullOrWhiteSpace(Cust_address) OrElse String.IsNullOrWhiteSpace(Cust_email) OrElse String.IsNullOrWhiteSpace(Cust_cnumber) OrElse Cust_cnumber.Length <> 10 Then
            MessageBox.Show("Please fill the information properly.")
        Else
            If openDB() Then
                Dim query As String = "INSERT INTO customer VALUES(NULL, @C_name, @C_address, @C_email, @C_cnumber)"
                Dim cmd As New MySqlCommand(query, Conn)
                cmd.Parameters.AddWithValue("@C_name", Cust_name.ToUpper())
                cmd.Parameters.AddWithValue("@C_address", Cust_address.ToUpper())
                cmd.Parameters.AddWithValue("@C_email", Cust_email.ToUpper())
                cmd.Parameters.AddWithValue("@C_cnumber", Cust_cnumber)

                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Customer added successfully!")


                    CustomerComboboxLoad()
                    txt_custaddress.Clear()
                    txt_custemail.Clear()
                    txt_custnumber.Clear()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    closeDB()
                End Try
            Else
                MessageBox.Show("Failed to connect to the database!")
            End If
        End If
    End Sub

    Private Sub CustomerComboboxLoad()
        If txt_Custname.SelectedIndex = -1 Then
            ' Clear the ComboBox selection and text
            txt_Custname.Text = ""
            txt_Custname.SelectedItem = Nothing

            ' Clear other customer details input fields if needed
            txt_custaddress.Clear()
            txt_custemail.Clear()
            txt_custnumber.Clear()

            ' Set focus to the first input field for new customer details
            txt_Custname.Focus()
        End If
    End Sub

    Private Sub BTN_Cbrefresh_Click(sender As Object, e As EventArgs) Handles BTN_Cbrefresh.Click
        txt_Custname.Items.Clear()
        LoadCustomer()
    End Sub
End Class

