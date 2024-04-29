﻿Imports MySql.Data.MySqlClient

Public Class WARRANTY
    Private Sub lbl_warranty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_warranty.Anchor = AnchorStyles.None
        lbl_warranty.TextAlign = ContentAlignment.MiddleCenter
        lbl_warranty.AutoSize = False
        lbl_warranty.Width = Me.ClientSize.Width ' Adjust this if needed


        Dim centerX As Integer = (Me.ClientSize.Width - lbl_warranty.Width) \ 2
        lbl_warranty.Location = New Point(centerX, lbl_warranty.Location.Y)

        LoadDataWarranty()

    End Sub


    Private Sub LoadDataWarranty()
        Try
            If openDB() Then
                Dim query As New MySqlCommand("SELECT * FROM warranty", Conn)
                Using dr As MySqlDataReader = query.ExecuteReader
                    While dr.Read
                        Dim RowIndex As Integer = War_datagridview.Rows.Add(dr.Item("War_ID"), dr.Item("War_Duration"), dr.Item("War_DurationUnit"), dr.Item("War_Type"), dr.Item("War_Status"), dr.Item("War_Coverage"))


                    End While

                End Using

            Else
                MessageBox.Show("Database is not Connected!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub War_datagridview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles War_datagridview.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = War_datagridview.Rows(e.RowIndex)


            Dim WarID As String = selectedRow.Cells("dt_id").Value.ToString()
            Dim WarDuration As String = selectedRow.Cells("dt_duration").Value.ToString()
            Dim WarUnit As String = selectedRow.Cells("dt_unit").Value.ToString()
            Dim Wartype As String = selectedRow.Cells("dt_type").Value.ToString()
            Dim WarStatus As String = selectedRow.Cells("dt_status").Value.ToString()
            Dim WarCoverage As String = selectedRow.Cells("dt_coverage").Value.ToString()


            For Each row As DataGridViewRow In War_datagridview.Rows
                If row.Index = e.RowIndex Then
                    row.Selected = True
                Else
                    row.Selected = False
                End If
            Next


            txt_war_days.Text = WarDuration
            war_month_combobox.Text = WarUnit
            type_war_combobox.Text = Wartype
            war_status_combobox.Text = WarStatus
            war_coverage_combobox.Text = WarCoverage








        End If

    End Sub



    'ADD BTN, CREATE A FUNCTION FOR ADD, UPDATE, DELETE AND CLEAR 4/23/2024. DON'T WASTE TIME BITCH. 
    Private Sub Btn_add_Click(sender As Object, e As EventArgs) Handles Btn_add.Click
        Dim WarDuration As String = txt_war_days.Text.Trim()
        Dim WarUnit As String = war_month_combobox.Text.Trim()
        Dim WarType As String = type_war_combobox.Text.Trim()
        Dim WarStatus As String = war_status_combobox.Text.Trim()
        Dim WarCoverage As String = war_coverage_combobox.Text.Trim()

        If String.IsNullOrEmpty(WarDuration) OrElse String.IsNullOrEmpty(WarUnit) OrElse String.IsNullOrEmpty(WarType) OrElse String.IsNullOrEmpty(WarStatus) OrElse String.IsNullOrEmpty(WarCoverage) Then
            MessageBox.Show("Please fill the information properly")
        Else
            If WarrantyExists(WarDuration, WarUnit, WarType, WarStatus, WarCoverage) Then
                MessageBox.Show("This warranty already exists.", "Duplicate Warranty", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to add this warranty?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    If openDB() Then
                        Dim query As String = "INSERT INTO warranty VALUES (WarDuration, WarUnit, WarType, WarStatus, WarCoverage)"
                        Dim cmd As New MySqlCommand(query, Conn)
                        cmd.Parameters.AddWithValue("War_Duration", Convert.ToInt32(WarDuration))
                        cmd.Parameters.AddWithValue("War_DurationUnit", WarUnit.ToUpper())
                        cmd.Parameters.AddWithValue("War_Type", WarType.ToUpper())
                        cmd.Parameters.AddWithValue("War_Status", WarStatus.ToUpper())
                        cmd.Parameters.AddWithValue("War_Coverage", WarCoverage.ToUpper())

                        Try
                            cmd.ExecuteNonQuery()
                            MessageBox.Show("Warranty Added Successfully!")
                            War_datagridview.Rows.Clear()
                            LoadDataWarranty()

                            txt_war_days.Clear()
                            war_month_combobox.SelectedIndex = -1
                            type_war_combobox.SelectedIndex = -1
                            war_status_combobox.SelectedIndex = -1
                            war_coverage_combobox.SelectedIndex = -1

                        Catch ex As Exception
                            MessageBox.Show("Error adding warranty: " & ex.Message)
                        Finally
                            closeDB()
                        End Try
                    Else
                        MessageBox.Show("Failed to connect to the database")
                    End If
                End If
            End If
        End If
    End Sub


    Private Function WarrantyExists(duration As String, unit As String, type As String, status As String, coverage As String) As Boolean
        Dim exists As Boolean = False
        ' Query to check if a warranty with the same values already exists
        Dim query As String = "SELECT COUNT(*) FROM warranty WHERE War_Duration = @W_duration AND War_DurationUnit = @W_unit AND War_Type = @W_type AND War_Status = @W_status AND War_Coverage = @W_coverage"

        Try
            If openDB() Then
                Using cmd As New MySqlCommand(query, Conn)
                    cmd.Parameters.AddWithValue("@W_duration", Convert.ToInt32(duration))
                    cmd.Parameters.AddWithValue("@W_unit", unit.ToUpper())
                    cmd.Parameters.AddWithValue("@W_type", type.ToUpper())
                    cmd.Parameters.AddWithValue("@W_status", status.ToUpper())
                    cmd.Parameters.AddWithValue("@W_coverage", coverage.ToUpper())

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    exists = count > 0
                End Using
            Else
                MessageBox.Show("Failed to connect to the database")
            End If
        Catch ex As Exception
            MessageBox.Show("Error checking warranty existence: " & ex.Message)
        Finally
            closeDB()
        End Try

        Return exists
    End Function






    Private Sub Btn_clear_Click(sender As Object, e As EventArgs) Handles Btn_clear.Click


        If War_datagridview.SelectedRows.Count > 0 Then
            War_datagridview.ClearSelection()
        End If


        txt_war_days.Clear()
        war_month_combobox.SelectedIndex = -1
        type_war_combobox.SelectedIndex = -1
        war_status_combobox.SelectedIndex = -1
        war_coverage_combobox.SelectedIndex = -1



    End Sub

    Private Sub Btn_update_Click(sender As Object, e As EventArgs) Handles Btn_update.Click
        Dim WarID As Integer

        If Integer.TryParse(War_datagridview.CurrentRow.Cells("dt_id").Value.ToString(), WarID) Then
            Dim WarDuration As String = txt_war_days.Text
            Dim WarUnit As String = war_month_combobox.Text
            Dim WarType As String = type_war_combobox.Text
            Dim WarStatus As String = war_status_combobox.Text
            Dim WarCoverage As String = war_coverage_combobox.Text

            If String.IsNullOrEmpty(WarDuration) OrElse String.IsNullOrEmpty(WarUnit) OrElse String.IsNullOrEmpty(WarType) OrElse String.IsNullOrEmpty(WarStatus) OrElse String.IsNullOrEmpty(WarCoverage) Then
                MessageBox.Show("Please fill the information properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If WarrantyExists(WarDuration, WarUnit, WarType, WarStatus, WarCoverage) Then
                    MessageBox.Show("This warranty already exists.", "Duplicate Warranty", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Try
                        If openDB() Then
                            Dim queryUpdate As String = "UPDATE warranty SET War_Duration = @W_duration, War_DurationUnit = @W_unit, War_Type = @W_type, War_Status = @W_status, War_Coverage = @W_coverage WHERE War_ID = @W_ID"
                            Dim cmdUpdate As New MySqlCommand(queryUpdate, Conn)
                            cmdUpdate.Parameters.AddWithValue("@W_ID", WarID)
                            cmdUpdate.Parameters.AddWithValue("@W_duration", Convert.ToInt32(WarDuration))
                            cmdUpdate.Parameters.AddWithValue("@W_unit", WarUnit.ToUpper())
                            cmdUpdate.Parameters.AddWithValue("@W_type", WarType.ToUpper())
                            cmdUpdate.Parameters.AddWithValue("@W_status", WarStatus.ToUpper())
                            cmdUpdate.Parameters.AddWithValue("@W_coverage", WarCoverage.ToUpper())

                            cmdUpdate.ExecuteNonQuery()
                            MessageBox.Show("Warranty is updated")
                            War_datagridview.Rows.Clear()
                            LoadDataWarranty()

                            txt_war_days.Clear()
                            war_month_combobox.SelectedIndex = -1
                            type_war_combobox.SelectedIndex = -1
                            war_status_combobox.SelectedIndex = -1
                            war_coverage_combobox.SelectedIndex = -1
                        Else
                            MessageBox.Show("Failed to connect to the database!", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error updating warranty: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        closeDB()
                    End Try
                End If
            End If
        End If
    End Sub





    Private Sub Btn_delete_Click(sender As Object, e As EventArgs) Handles Btn_delete.Click
        If War_datagridview.SelectedRows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this warranty?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Dim selectedRow As DataGridViewRow = War_datagridview.SelectedRows(0)
                Dim WarID As Integer = Convert.ToInt32(selectedRow.Cells("dt_id").Value)

                If openDB() Then

                    Dim query As String = "DELETE FROM warranty WHERE War_ID = @W_ID"
                    Dim cmd As New MySqlCommand(query, Conn)
                    cmd.Parameters.AddWithValue("@W_ID", WarID)

                    Try
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("The selected warranty is deleted.")
                        War_datagridview.Rows.Clear()
                        LoadDataWarranty()


                        txt_war_days.Clear()
                        war_month_combobox.SelectedIndex = -1
                        type_war_combobox.SelectedIndex = -1
                        war_status_combobox.SelectedIndex = -1
                        war_coverage_combobox.SelectedIndex = -1



                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally
                        closeDB()

                    End Try
                Else
                    MessageBox.Show("The database failed to Connect!")

                End If

            Else
                ' Code to handle the user's "No" response or do nothing
            End If


        End If


    End Sub
End Class



