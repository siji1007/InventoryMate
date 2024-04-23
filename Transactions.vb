Imports MySql.Data.MySqlClient

Public Class Transactions
    Private Sub Lbl_transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_transaction.Anchor = AnchorStyles.None
        Lbl_transaction.TextAlign = ContentAlignment.MiddleCenter
        Lbl_transaction.AutoSize = False
        Lbl_transaction.Width = Me.ClientSize.Width ' Adjust this if needed


        Dim centerX As Integer = (Me.ClientSize.Width - Lbl_transaction.Width) \ 2
        Lbl_transaction.Location = New Point(centerX, Lbl_transaction.Location.Y)

    End Sub


    Private Sub Cb_Products_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_Products.SelectedIndexChanged
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
    End Sub


    Private Sub Cb_Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cb_Products.Items.Clear()

        If openDB() Then
            Dim query_product = "SELECT CONCAT(prod_name, ' - ', prod_model) AS product_info FROM products"
            Using Command As New MySqlCommand(query_product, Conn)
                Try
                    Using reader = Command.ExecuteReader
                        If reader.HasRows Then
                            While reader.Read
                                ' Add the concatenated product information to the ComboBox items
                                Cb_Products.Items.Add(reader("product_info").ToString)
                            End While
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    closeDB()
                End Try
            End Using
        Else
            MessageBox.Show("The database is not connected.")
        End If
    End Sub


    Private Sub Cb_employeeName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cb_employeeName.Items.Clear()

        If openDB() Then
            Dim query_employee As String = "SELECT Emp_name FROM employee"
            Using cmd As New MySqlCommand(query_employee, Conn)
                Try
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            ' Add each Emp_name to the ComboBox
                            Cb_employeeName.Items.Add(reader("Emp_name").ToString())
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

End Class