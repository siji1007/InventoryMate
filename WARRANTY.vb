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


End Class



