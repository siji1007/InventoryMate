Imports System.Security.AccessControl
Imports System.Web
Imports MySql.Data.MySqlClient

Public Class SUPPLIER
    Private Sub Lbl_supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        Lbl_supplier.Anchor = AnchorStyles.None
        Lbl_supplier.TextAlign = ContentAlignment.MiddleCenter
        Lbl_supplier.AutoSize = False
        Lbl_supplier.Width = Me.ClientSize.Width ' Adjust this if needed


        Dim centerX As Integer = (Me.ClientSize.Width - Lbl_supplier.Width) \ 2
        Lbl_supplier.Location = New Point(centerX, Lbl_supplier.Location.Y)

        LoadDataSup()

    End Sub


    Private Sub LoadDataSup()
        Try
            If openDB() Then
                Dim query As New MySqlCommand("SELECT * FROM supplier", Conn)
                Using dr As MySqlDataReader = query.ExecuteReader
                    While dr.Read
                        Dim rowIndex As Integer = sup_datagridview.Rows.Add(dr.Item("Supp_ID"), dr.Item("Supp_name"), dr.Item("Supp_store"), dr.Item("Supp_address"), dr.Item("Supp_email"), dr.Item("Supp_cnumber"))
                    End While
                End Using
            Else
                MessageBox.Show("Failed to connect to the database", "DATABASE CONNECTION FAILED!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub

    Private Sub sup_datagridview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles sup_datagridview.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim SelectedRow As DataGridViewRow = sup_datagridview.Rows(e.RowIndex)
            Dim supId As String = SelectedRow.Cells("Supp_ID").Value.ToString()
            Dim supName As String = SelectedRow.Cells("Supp_name").Value.ToString()
            Dim supStore As String = SelectedRow.Cells("Supp_store").Value.ToString()
            Dim supAddress As String = SelectedRow.Cells("Supp_address").Value.ToString()
            Dim supEmail As String = SelectedRow.Cells("Supp_email").Value.ToString()
            Dim supContact As Integer = Convert.ToInt64(SelectedRow.Cells("Supp_cnumber").Value)



            For Each row_sup As DataGridViewRow In sup_datagridview.Rows
                If row_sup.Index = e.RowIndex Then
                    row_sup.Selected = True
                Else
                    row_sup.Selected = False
                End If
            Next

            txt_sup_name.Text = supName
            txt_store_name.Text = supStore
            txt_sup_address.Text = supAddress
            txt_sup_email.Text = supEmail
            txt_sup_cnumber.Text = supContact.ToString()

        End If
    End Sub

    Private Sub Btn_create_Click(sender As Object, e As EventArgs) Handles Btn_create.Click
        Dim S_name = txt_sup_name.Text.Trim()
        Dim S_store = txt_store_name.Text.Trim()
        Dim S_address = txt_sup_address.Text.Trim()
        Dim S_email = txt_sup_email.Text.Trim()
        Dim S_contact As Integer

        If String.IsNullOrWhiteSpace(S_name) OrElse String.IsNullOrWhiteSpace(S_store) OrElse String.IsNullOrWhiteSpace(S_address) OrElse String.IsNullOrWhiteSpace(S_email) OrElse Not Integer.TryParse(txt_sup_cnumber.Text.Trim(), S_contact) Then
            MessageBox.Show("Please fill all information properly.", "Fill properly", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            If openDB() Then
                Dim query As String = "INSERT INTO supplier VALUES(NULL, @S_name, @S_store, @S_address, @S_email, @S_contact)"
                Dim cmd As New MySqlCommand(query, Conn)
                cmd.Parameters.AddWithValue("@S_name", S_name.ToUpper())
                cmd.Parameters.AddWithValue("@S_store", S_store.ToUpper())
                cmd.Parameters.AddWithValue("@S_address", S_address.ToUpper())
                cmd.Parameters.AddWithValue("@S_email", S_email.ToUpper())
                cmd.Parameters.AddWithValue("@S_contact", S_contact)


                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Supplier added Succesfully")
                    sup_datagridview.Rows.Clear()
                    LoadDataSup()


                    txt_sup_name.Clear()
                    txt_store_name.Clear()
                    txt_sup_address.Clear()
                    txt_sup_email.Clear()
                    txt_sup_cnumber.Clear()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                Finally
                    closeDB()
                End Try
            Else
                MessageBox.Show("Failed to Connect database")

            End If

        End If
    End Sub

    Private Sub Btn_update_Click(sender As Object, e As EventArgs) Handles Btn_update.Click
        Dim S_id As Integer
        If Integer.TryParse(sup_datagridview.CurrentRow.Cells("Supp_ID").Value.ToString(), S_id) Then

            Dim S_name As String = txt_sup_name.Text
            Dim S_store As String = txt_store_name.Text
            Dim S_address As String = txt_sup_address.Text
            Dim S_email As String = txt_sup_email.Text
            Dim S_contact As Integer

            If String.IsNullOrWhiteSpace(S_name) OrElse String.IsNullOrWhiteSpace(S_store) OrElse String.IsNullOrWhiteSpace(S_address) OrElse String.IsNullOrWhiteSpace(S_email) OrElse Not Integer.TryParse(txt_sup_cnumber.Text, S_contact) Then
                MessageBox.Show("Please fill the information properly", "Fill properly", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                If openDB() Then
                    Dim query As String = "UPDATE supplier SET Supp_name = @S_name, Supp_store = @S_store, Supp_address = @S_address , Supp_email = @S_email, Supp_cnumber = @S_contact WHERE Supp_ID = @S_id"
                    Dim cmd As New MySqlCommand(query, Conn)
                    cmd.Parameters.AddWithValue("@S_id", S_id)
                    cmd.Parameters.AddWithValue("@S_name", S_name)
                    cmd.Parameters.AddWithValue("@S_store", S_store)
                    cmd.Parameters.AddWithValue("@S_address", S_address)
                    cmd.Parameters.AddWithValue("@S_email", S_email)
                    cmd.Parameters.AddWithValue("@S_contact", S_contact)



                    Try
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Supplier updated successfully ")
                        sup_datagridview.Rows.Clear()
                        LoadDataSup()

                        txt_sup_name.Clear()
                        txt_store_name.Clear()
                        txt_sup_address.Clear()
                        txt_sup_email.Clear()
                        txt_sup_cnumber.Clear()





                    Catch ex As Exception
                        MessageBox.Show(ex.Message)

                    Finally
                        closeDB()
                    End Try

                Else
                    MessageBox.Show("Failed to connect to the database")
                End If
            End If

        Else
            MessageBox.Show("Please select a product to update.")

        End If

    End Sub



    Private Sub Btn_delete_Click(sender As Object, e As EventArgs) Handles Btn_delete.Click
        If sup_datagridview.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = sup_datagridview.SelectedRows(0)
            Dim S_id As Integer = Convert.ToInt32(selectedRow.Cells("Supp_ID").Value)


            If openDB() Then
                Dim query As String = "DELETE FROM supplier WHERE Supp_ID = @S_id"
                Dim cmd As New MySqlCommand(query, Conn)
                cmd.Parameters.AddWithValue("@S_id", S_id)


                txt_sup_name.Clear()
                txt_store_name.Clear()
                txt_sup_address.Clear()
                txt_sup_email.Clear()
                txt_sup_cnumber.Clear()


                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Supplier deleted successfully")
                    sup_datagridview.Rows.Remove(selectedRow)


                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    closeDB()

                End Try


            Else
                MessageBox.Show("Failed to connect to database")


            End If

        Else
            MessageBox.Show("Please select a supplier to delete")

        End If

    End Sub

    Private Sub Btn_clear_Click(sender As Object, e As EventArgs) Handles Btn_clear.Click
        If sup_datagridview.SelectedRows.Count > 0 Then
            sup_datagridview.ClearSelection()
        End If

        txt_sup_name.Clear()
        txt_store_name.Clear()
        txt_sup_address.Clear()
        txt_sup_email.Clear()
        txt_sup_cnumber.Clear()

    End Sub
End Class