
Imports MySql.Data.MySqlClient
Public Class PRODUCT

    Private Sub PRODUCT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True

    End Sub





    Private Sub Product_title_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' Set the form's start position to CenterScreen
        Me.StartPosition = FormStartPosition.CenterScreen

        Me.Width = 400 ' Adjust this value as needed

        ' Anchor the title label or control to the center horizontally
        Product_title.Anchor = AnchorStyles.None
        Product_title.TextAlign = ContentAlignment.MiddleCenter
        Product_title.AutoSize = False
        Product_title.Width = Me.ClientSize.Width ' Adjust this if needed


        Dim centerX As Integer = (Me.ClientSize.Width - Product_title.Width) \ 2
        Product_title.Location = New Point(centerX, Product_title.Location.Y)

        LoadData()

    End Sub

    Private Sub Btn_add_prod_Click(sender As Object, e As EventArgs) Handles Btn_add_prod.Click
        Dim P_name As String = txt_product_name.Text.Trim()
        Dim P_model As String = txt_product_model.Text.Trim()
        Dim P_color As String = txt_product_color.Text.Trim()
        Dim P_stocks As Integer
        Dim P_price As Integer

        If String.IsNullOrWhiteSpace(P_name) Then
            MessageBox.Show("Please enter a product name.", "Fill properly", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf String.IsNullOrWhiteSpace(P_model) Then
            MessageBox.Show("Please enter a product model.", "Fill properly", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Not Integer.TryParse(txt_stocks.Text.Trim(), P_stocks) Then
            MessageBox.Show("Please enter a valid number for stocks.", "Fill properly", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Not Integer.TryParse(txt_price.Text.Trim(), P_price) Then
            MessageBox.Show("Please enter a valid number for price.", "Fill properly", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If openDB() Then
                ' Proceed with database insertion
                Dim query As String = "INSERT INTO products (prod_name, prod_model, prod_color, prod_stocks, prod_price) VALUES (@P_name, @P_model, @P_color, @P_stocks, @P_price)"
                Dim cmd As New MySqlCommand(query, Conn)
                cmd.Parameters.AddWithValue("@P_name", P_name.ToUpper())
                cmd.Parameters.AddWithValue("@P_model", P_model.ToUpper())
                cmd.Parameters.AddWithValue("@P_color", P_color.ToUpper())
                cmd.Parameters.AddWithValue("@P_stocks", P_stocks)
                cmd.Parameters.AddWithValue("@P_price", P_price)

                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Product added successfully.")
                    prod_datagridview.Rows.Clear()
                    LoadData()

                    ' Clear textboxes after successful insertion
                    txt_product_name.Clear()
                    txt_product_model.Clear()
                    txt_product_color.Clear()
                    txt_stocks.Clear()
                    txt_price.Clear()

                Catch ex As Exception
                    MessageBox.Show("Error adding product: " & ex.Message)
                Finally
                    closeDB() ' Close the database after the insertion
                End Try
            Else
                MessageBox.Show("Failed to connect to the database.")
            End If
        End If
    End Sub


    Private Sub LoadData()
        Try
            If openDB() Then ' Check if database connection is successful
                Dim query As New MySqlCommand("SELECT * FROM products", Conn) ' Assuming Conn is your MySqlConnection object from openDB()
                Using dr As MySqlDataReader = query.ExecuteReader
                    While dr.Read
                        Dim price As Double = Convert.ToDouble(dr.Item("prod_price"))
                        Dim formattedPrice As String = FormatPrice(price) ' Format the price with peso sign and commas

                        Dim rowIndex As Integer = prod_datagridview.Rows.Add(dr.Item("prod_id"), dr.Item("prod_name"), dr.Item("prod_model"), dr.Item("prod_color"), dr.Item("prod_stocks"), formattedPrice)

                        ' Check and set row color based on prod_stocks value
                        Dim stocks As Integer = Convert.ToInt32(dr.Item("prod_stocks"))
                        If stocks = 0 Then
                            prod_datagridview.Rows(rowIndex).DefaultCellStyle.BackColor = Color.Red
                        End If
                    End While
                End Using
            Else
                MessageBox.Show("Failed to connect to the database.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub

    Private Function FormatPrice(price As Double) As String
        ' Format the price with peso sign and commas
        Return "₱" & price.ToString("N0")
    End Function



    Private Sub prod_datagridview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles prod_datagridview.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then ' Check if a valid cell is clicked
            Dim selectedRow As DataGridViewRow = prod_datagridview.Rows(e.RowIndex)

            ' Access the data in the selected row as needed
            Dim prodId As String = selectedRow.Cells("prod_id").Value.ToString()
            Dim prodName As String = selectedRow.Cells("prod_name_dt").Value.ToString()
            Dim prodModel As String = selectedRow.Cells("prod_model_dt").Value.ToString()
            Dim prodColor As String = selectedRow.Cells("prod_color_dt").Value.ToString()
            Dim prodStocks As Integer = Convert.ToInt32(selectedRow.Cells("prod_stocks_dt").Value)
            Dim prodPriceFormatted As String = selectedRow.Cells("prod_price_dt").Value.ToString()

            For Each row As DataGridViewRow In prod_datagridview.Rows
                If row.Index = e.RowIndex Then
                    row.Selected = True
                Else
                    row.Selected = False
                End If
            Next

            ' Extract the numeric part of the formatted price (remove peso sign and commas)
            Dim prodPriceNumeric As Decimal
            If Decimal.TryParse(prodPriceFormatted.Replace("₱", "").Replace(",", ""), prodPriceNumeric) Then
                ' Update TextBoxes with data
                txt_product_name.Text = prodName
                txt_product_model.Text = prodModel
                txt_product_color.Text = prodColor
                txt_stocks.Text = prodStocks.ToString()
                txt_price.Text = prodPriceNumeric.ToString() ' Display the numeric price in the TextBox
            Else
                ' Handle invalid formatted price
                MessageBox.Show("Invalid price format.")
            End If
        End If
    End Sub



    Private Sub Btn_update_prod_Click(sender As Object, e As EventArgs) Handles Btn_update_prod.Click
        Dim P_id As Integer ' Assuming you have a product ID to identify the record to update
        If Integer.TryParse(prod_datagridview.CurrentRow.Cells("prod_id").Value.ToString(), P_id) Then
            Dim P_name As String = txt_product_name.Text
            Dim P_model As String = txt_product_model.Text
            Dim P_color As String = txt_product_color.Text
            Dim P_stocks As Integer
            Dim P_price As Integer

            If String.IsNullOrWhiteSpace(P_name) OrElse String.IsNullOrWhiteSpace(P_model) OrElse String.IsNullOrWhiteSpace(P_color) OrElse Not Integer.TryParse(txt_stocks.Text, P_stocks) OrElse Not Integer.TryParse(txt_price.Text, P_price) Then
                MessageBox.Show("Please fill all information properly.", "Fill properly", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If openDB() Then
                    Dim query As String = "UPDATE products SET prod_name = @P_name, prod_model = @P_model, prod_color = @P_color, prod_stocks = @P_stocks, prod_price = @P_price WHERE prod_id = @P_id"
                    Dim cmd As New MySqlCommand(query, Conn)
                    cmd.Parameters.AddWithValue("@P_id", P_id)
                    cmd.Parameters.AddWithValue("@P_name", P_name.ToUpper())
                    cmd.Parameters.AddWithValue("@P_model", P_model.ToUpper())
                    cmd.Parameters.AddWithValue("@P_color", P_color.ToUpper())
                    cmd.Parameters.AddWithValue("@P_stocks", P_stocks)
                    cmd.Parameters.AddWithValue("@P_price", P_price)

                    Try
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Product updated successfully.")
                        prod_datagridview.Rows.Clear() ' Clear the DataGridView
                        LoadData() ' Reload data into the DataGridView

                        ' Clear textboxes after updating
                        txt_product_name.Clear()
                        txt_product_model.Clear()
                        txt_product_color.Clear()
                        txt_stocks.Clear()
                        txt_price.Clear()

                    Catch ex As Exception
                        MessageBox.Show("Error updating product: " & ex.Message)
                    Finally
                        closeDB() ' Close the database after updating
                    End Try
                Else
                    MessageBox.Show("Failed to connect to the database.")
                End If
            End If
        Else
            MessageBox.Show("Please select a product to update.")
        End If
    End Sub


    Private Sub Btn_delete_prod_Click(sender As Object, e As EventArgs) Handles Btn_delete_prod.Click
        If prod_datagridview.SelectedRows.Count > 0 Then ' Check if any row is selected
            Dim selectedRow As DataGridViewRow = prod_datagridview.SelectedRows(0)
            Dim prodId As Integer = Convert.ToInt32(selectedRow.Cells("prod_id").Value)

            If openDB() Then
                Dim query As String = "DELETE FROM products WHERE prod_id = @prodId"
                Dim cmd As New MySqlCommand(query, Conn)
                cmd.Parameters.AddWithValue("@prodId", prodId)

                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Product deleted successfully.")
                    prod_datagridview.Rows.Remove(selectedRow) ' Remove the selected row from the DataGridView

                    ' Clear textboxes after deletion
                    txt_product_name.Clear()
                    txt_product_model.Clear()
                    txt_product_color.Clear()
                    txt_stocks.Clear()
                    txt_price.Clear()

                Catch ex As Exception
                    MessageBox.Show("Error deleting product: " & ex.Message)
                Finally
                    closeDB() ' Close the database after deletion
                End Try
            Else
                MessageBox.Show("Failed to connect to the database.")
            End If
        Else
            MessageBox.Show("Please select a product to delete.")
        End If
    End Sub

    Private Sub Btn_clear_prod_Click(sender As Object, e As EventArgs) Handles Btn_clear_prod.Click
        ' Clear the selected row in the DataGridView
        If prod_datagridview.SelectedRows.Count > 0 Then
            prod_datagridview.ClearSelection()
        End If

        ' Clear all textboxes
        txt_product_name.Clear()
        txt_product_model.Clear()
        txt_product_color.Clear()
        txt_stocks.Clear()
        txt_price.Clear()
    End Sub

    Private Sub prod_search_TextChanged(sender As Object, e As EventArgs) Handles prod_search.TextChanged
        Dim searchValue As String = prod_search.Text.Trim().ToLower()
        For Each row As DataGridViewRow In prod_datagridview.Rows
            ' Check if the row is not a new row and then perform search filtering
            If Not row.IsNewRow Then
                Dim productName As String = row.Cells("prod_name_dt").Value.ToString().ToLower()
                If searchValue = "" OrElse productName.Contains(searchValue) Then
                    row.Visible = True
                Else
                    row.Visible = False
                End If
            End If
        Next
    End Sub



End Class