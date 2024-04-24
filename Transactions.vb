Imports MySql.Data.MySqlClient

Public Class Transactions
    Private Sub Lbl_transaction_Load(sender As Object, e As EventArgs)
        Lbl_transaction.TextAlign = ContentAlignment.MiddleCenter
        Lbl_transaction.AutoSize = False
        Lbl_transaction.Width = ClientSize.Width ' Adjust this if needed


        Dim centerX = (ClientSize.Width - Lbl_transaction.Width) \ 2
        Lbl_transaction.Location = New Point(centerX, Lbl_transaction.Location.Y)



    End Sub


    Private Sub Cb_Products_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_Products.SelectedIndexChanged
        If Cb_Products.SelectedItem IsNot Nothing Then
            If openDB() Then
                Dim selectedProduct As String = Cb_Products.SelectedItem.ToString()
                Dim productName As String = selectedProduct.Split("-"c)(0).Trim()
                Dim productModel As String = selectedProduct.Split("-"c)(1).Trim()

                Dim query_price As String = "SELECT prod_price FROM products WHERE prod_name = @productName AND prod_model = @productModel"

                Using command As New MySqlCommand(query_price, Conn)
                    command.Parameters.AddWithValue("@productName", productName)
                    command.Parameters.AddWithValue("@productModel", productModel)

                    Try
                        Dim price As Object = command.ExecuteScalar()
                        If price IsNot Nothing AndAlso Not DBNull.Value.Equals(price) Then
                            txt_price.Text = price.ToString()
                        Else
                            txt_price.Text = "Price not found"
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally
                        closeDB()
                    End Try
                End Using
            Else
                MessageBox.Show("The database is not connected.")
            End If
        Else
            ' Handle case when no item is selected in ComboBox
            txt_price.Text = "No product selected"
        End If
    End Sub


    Private Sub Cb_Products_Load(sender As Object, e As EventArgs)
        Cb_Products.Items.Clear

        If openDB Then
            Dim query_product = "SELECT CONCAT(prod_name, ' - ', prod_model) AS product_info FROM products WHERE prod_stocks > 0"
            Using Command As New MySqlCommand(query_product, Conn)
                Try
                    Using reader = Command.ExecuteReader
                        While reader.Read
                            ' Add the concatenated product information to the ComboBox items
                            Cb_Products.Items.Add(reader("product_info").ToString)
                        End While
                    End Using
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    closeDB
                End Try
            End Using
        Else
            MessageBox.Show("The database is not connected.")
        End If
    End Sub




    Private Sub Cb_warranty_Load(sender As Object, e As EventArgs)
        Cb_employeeName.Items.Clear

        If openDB Then
            Dim query_warranty = "SELECT CONCAT(War_Duration, '-', War_DurationUnit) AS warranty_info FROM warranty"
            Using cmd As New MySqlCommand(query_warranty, Conn)
                Try
                    Using reader = cmd.ExecuteReader
                        If reader.HasRows Then
                            While reader.Read
                                Cb_warranty.Items.Add(reader("warranty_info").ToString)
                            End While
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try

            End Using


        Else
            MessageBox.Show("The Database failed to connect.")
        End If

    End Sub

    Private Sub Cb_employeeName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cb_employeeName.Items.Clear()

        If openDB() Then
            Dim query_employee = "SELECT Emp_name FROM employee"
            Using cmd As New MySqlCommand(query_employee, Conn)
                Try
                    Using reader = cmd.ExecuteReader
                        While reader.Read
                            ' Add each Emp_name to the ComboBox
                            Cb_employeeName.Items.Add(reader("Emp_name").ToString)
                        End While
                    End Using
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
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
                    End Using
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
            MessageBox.Show("Invalid quantity. Please enter a valid numeric value for quantity.")
            Exit Sub ' Exit the method if quantity is invalid
        End If

        ' Check if the product stock is available
        Dim queryStock As String = "SELECT prod_stocks FROM products WHERE CONCAT(prod_name, ' - ', prod_model) = @productInfo"
        If openDB() Then
            Using commandStock As New MySqlCommand(queryStock, Conn)
                commandStock.Parameters.AddWithValue("@productInfo", ProdName)
                Dim availableStock As Integer = Convert.ToInt32(commandStock.ExecuteScalar())
                If availableStock >= ProdQuantityInt Then
                    ' Validate and convert price to decimal
                    Dim ProdPriceDec As Decimal
                    If Not Decimal.TryParse(ProdPrice, ProdPriceDec) Then
                        MessageBox.Show("Invalid price. Please enter a valid numeric value for price.")
                        Exit Sub ' Exit the method if price is invalid
                    End If

                    ' Calculate total for the current product
                    Dim ProdTotal As Decimal = ProdQuantityInt * ProdPriceDec

                    ' Add the product details to the DataGridView
                    Dim row As String() = {ProdName, ProdQuantity, ProdPrice, ProdWarrantyDuration, ProdWarrantyCoverage, ProdTotal.ToString()}
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

                    ' Debug message to verify if data is added
                    MessageBox.Show("Product added to DataGridView.")
                Else
                    MessageBox.Show("The stock available is only " & availableStock & " for this product.")
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
            ' Get the total of the row to be removed
            Dim rowTotal As Decimal = 0
            If Decimal.TryParse(transaction_datagridview.SelectedRows(0).Cells("dt_total").Value?.ToString(), rowTotal) Then
                ' Remove the selected row
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
            Else
                MessageBox.Show("Invalid row total. Could not deduct from Total_cost.")
            End If
        Else
            MessageBox.Show("Please select a row to clear.")
        End If
    End Sub





    Private Sub Print_btn_Click(sender As Object, e As EventArgs) Handles Print_btn.Click
        Dim message As String = ""

        ' Check if the DataGridView has rows
        If transaction_datagridview.Rows.Count > 1 Then
            For Each row As DataGridViewRow In transaction_datagridview.Rows
                ' Check if the row is not a new row and is selected
                If Not row.IsNewRow Then
                    ' Get the product name and quantity from the row
                    Dim productName As String = row.Cells("dt_product_name").Value.ToString()
                    Dim quantity As Integer
                    If Integer.TryParse(row.Cells("dt_quantity").Value.ToString(), quantity) Then
                        ' Concatenate the product name and quantity to the message
                        message &= productName & ": " & quantity & vbCrLf
                    End If
                End If
            Next

            ' Display the message box with the concatenated product names and quantities
            If message <> "" Then
                MessageBox.Show("Selected Products and Quantities:" & vbCrLf & message)
            Else
                MessageBox.Show("No products selected.")
            End If
        Else
            ' Display a message if there are no rows in the DataGridView
            MessageBox.Show("Can't perform print action. No product has been inserted.")
        End If
    End Sub







End Class