﻿Imports MySql.Data.MySqlClient

Public Class CUSTOMER
    Private Sub Lbl_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_customer.Anchor = AnchorStyles.None
        Lbl_customer.TextAlign = ContentAlignment.MiddleCenter
        Lbl_customer.AutoSize = False
        Lbl_customer.Width = Me.ClientSize.Width ' Adjust this if needed


        Dim centerX As Integer = (Me.ClientSize.Width - Lbl_customer.Width) \ 2
        Lbl_customer.Location = New Point(centerX, Lbl_customer.Location.Y)


        LoadDataCustomer()


    End Sub


    'LOAD HERE THE DATA FROM DATABASE TO DATAGRIDVIEW 
    Private Sub LoadDataCustomer()
        Try
            If openDB() Then
                Dim query As New MySqlCommand("SELECT * FROM customer", Conn)
                Using dr As MySqlDataReader = query.ExecuteReader
                    While dr.Read
                        Dim Cust_cnumber As String = dr.Item("Cust_cnumber").ToString()
                        ' Check if the contact number does not start with "+63" and add it
                        If Not Cust_cnumber.StartsWith("+63") Then
                            Cust_cnumber = "+63" & Cust_cnumber ' Add "+63" prefix
                        End If

                        Dim rowIndex As Integer = customer_datagridview.Rows.Add(dr.Item("Cust_ID"), dr.Item("Cust_name"), dr.Item("Cust_address"), dr.Item("Cust_email"), Cust_cnumber)
                    End While
                End Using
            Else
                MessageBox.Show("Failed to connect to the database")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub customer_datagridview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles customer_datagridview.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = customer_datagridview.Rows(e.RowIndex)

            'Access the data in the selected row as needed 
            Dim CustID As String = selectedRow.Cells("cl_ID").Value.ToString()
            Dim CustName As String = selectedRow.Cells("CL_NAME").Value.ToString()
            Dim CustAddress As String = selectedRow.Cells("CL_ADDRESS").Value.ToString()
            Dim CustEmail As String = selectedRow.Cells("CL_EMAIL").Value.ToString()
            Dim CustCnumber As String = selectedRow.Cells("CL_CNUMBER").Value.ToString()



            For Each row As DataGridViewRow In customer_datagridview.Rows
                If row.Index = e.RowIndex Then
                    row.Selected = True
                Else
                    row.Selected = False
                End If
            Next


            'Display the selected row on its corresponding txtbox 

            txt_cname.Text = CustName
            txt_caddress.Text = CustAddress
            txt_cemail.Text = CustEmail
            txt_cnumber.Text = CustCnumber

        End If
    End Sub



    'add function
    Private Sub Add_cust_btn_Click(sender As Object, e As EventArgs) Handles Add_cust_btn.Click
        Dim Cust_name As String = txt_cname.Text.Trim()
        Dim Cust_address As String = txt_caddress.Text.Trim()
        Dim Cust_email As String = txt_cemail.Text.Trim()
        Dim Cust_cnumber As String = txt_cnumber.Text.Trim()

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
                    customer_datagridview.Rows.Clear()
                    LoadDataCustomer()

                    txt_cname.Clear()
                    txt_caddress.Clear()
                    txt_cemail.Clear()
                    txt_cnumber.Text = "+63"

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










    Private Sub Update_cust_btn_Click(sender As Object, e As EventArgs) Handles Update_cust_btn.Click
        Dim Cust_id As Integer
        If Integer.TryParse(customer_datagridview.CurrentRow.Cells("cl_ID").Value.ToString(), Cust_id) Then
            Dim Cust_name As String = txt_cname.Text
            Dim Cust_address As String = txt_caddress.Text
            Dim Cust_email As String = txt_cemail.Text
            Dim Cust_cnumber As String = txt_cnumber.Text.Trim()

            ' Check if the contact number starts with "+63" and remove it
            If Cust_cnumber.StartsWith("+63") AndAlso Cust_cnumber.Length > 3 Then
                Cust_cnumber = Cust_cnumber.Substring(3) ' Remove "+63"
            End If

            If String.IsNullOrWhiteSpace(Cust_name) OrElse String.IsNullOrWhiteSpace(Cust_address) OrElse String.IsNullOrWhiteSpace(Cust_email) OrElse String.IsNullOrWhiteSpace(Cust_cnumber) OrElse Cust_cnumber.Length <> 10 Then
                MessageBox.Show("Please fill the information properly.")
            Else
                If openDB() Then
                    Dim query As String = "UPDATE customer SET Cust_name = @Cname, Cust_address = @C_address, Cust_email = @C_email, Cust_cnumber = @C_cnumber WHERE Cust_ID = @C_ID"
                    Dim cmd As New MySqlCommand(query, Conn)
                    cmd.Parameters.AddWithValue("@C_ID", Cust_id)
                    cmd.Parameters.AddWithValue("@Cname", Cust_name.ToUpper())
                    cmd.Parameters.AddWithValue("@C_address", Cust_address.ToUpper())
                    cmd.Parameters.AddWithValue("@C_email", Cust_email.ToUpper())
                    cmd.Parameters.AddWithValue("@C_cnumber", Cust_cnumber)

                    Try
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Customer updated successfully!")
                        customer_datagridview.Rows.Clear()
                        LoadDataCustomer()

                        txt_cname.Clear()
                        txt_caddress.Clear()
                        txt_cemail.Clear()
                        txt_cnumber.Text = "+63"
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
            MessageBox.Show("Please select a customer to update")
        End If
    End Sub


    Private Sub Delete_cust_btn_Click(sender As Object, e As EventArgs) Handles Delete_cust_btn.Click
        If customer_datagridview.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = customer_datagridview.SelectedRows(0)
            Dim Cust_ID As Integer = Convert.ToInt32(selectedRow.Cells("cl_ID").Value)
            If openDB() Then
                Dim query As String = "DELETE FROM customer WHERE Cust_ID = @c_id"
                Dim cmd As New MySqlCommand(query, Conn)
                cmd.Parameters.AddWithValue("@c_id", Cust_ID)

                Try
                    cmd.ExecuteNonQuery()
                    customer_datagridview.Rows.Clear()
                    LoadDataCustomer()

                    txt_cname.Clear()
                    txt_caddress.Clear()
                    txt_cemail.Clear()
                    txt_cnumber.Text = "+63"



                Catch ex As Exception

                    MessageBox.Show(ex.Message)

                Finally
                    closeDB()

                End Try
            Else
                MessageBox.Show("The database is not connected!")

            End If

        Else
            MessageBox.Show("Please select customer to delete!")


        End If

    End Sub

    Private Sub Clear_cust_btn_Click(sender As Object, e As EventArgs) Handles Clear_cust_btn.Click
        If customer_datagridview.SelectedRows.Count > 0 Then
            customer_datagridview.ClearSelection()
        End If


        txt_cname.Clear()
        txt_caddress.Clear()
        txt_cemail.Clear()
        txt_cnumber.Clear()

    End Sub

    Private Sub txt_caddress_TextChanged(sender As Object, e As EventArgs) Handles txt_caddress.TextChanged

    End Sub
End Class