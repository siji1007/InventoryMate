Imports System.Diagnostics.Eventing
Imports MySql.Data.MySqlClient

Public Class LOGIN
    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub SignIn_Click(sender As Object, e As EventArgs) Handles SignIn.Click
        Try
            If openDB() Then
                Dim query As New MySqlCommand("SELECT * FROM Users WHERE Username=@Username AND PasswordHash=@Password;", Conn)

                query.Parameters.AddWithValue("@Username", Username.Text)
                query.Parameters.AddWithValue("@Password", Password.Text)



                Using reader As MySqlDataReader = query.ExecuteReader()
                    If reader.Read() Then
                        ' Retrieve user information including Status
                        Dim userID As Integer = reader.GetInt32("UserID")
                        Dim userPrivilege As String = reader.GetString("Privilege")
                        Dim userStatus As String = reader.GetString("Status")

                        MessageBox.Show("Login successful! UserID: " & userID & ", Privilege: " & userPrivilege & ", Status: " & userStatus)
                        MessageBox.Show("User Privilege: " & userPrivilege)

                        If userPrivilege = "ADMIN" Or userPrivilege = "EMPLOYEE" Or userPrivilege = "OWNER" Then
                            If userStatus = "OFFLINE" Then
                                closeDB()
                                Try
                                    If openDB() Then
                                        Dim updateQuery As New MySqlCommand("UPDATE Users SET Status='ACTIVE' WHERE Username=@Username;", Conn)
                                        updateQuery.Parameters.AddWithValue("@Username", Username.Text)
                                        updateQuery.ExecuteNonQuery()

                                    End If
                                Catch ex As Exception
                                    MessageBox.Show(ex.Message)
                                Finally
                                    closeDB()

                                End Try


                            End If
                            ' Show admin dashboard or perform admin-specific actions
                            Me.Hide()
                            Dim mainForm As MAIN_FORM = TryCast(Me.Owner, MAIN_FORM)
                            If mainForm IsNot Nothing Then
                                mainForm.ShowDashboard()
                            Else
                                MessageBox.Show("Error accessing the parent form.")
                            End If


                        Else
                            ' Invalid user or account status
                            MessageBox.Show("Invalid username, password, or account status.")
                        End If
                    Else
                        MessageBox.Show("Invalid username or password. Please try again.")
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

    Private Sub Pass_show_Click(sender As Object, e As EventArgs) Handles Pass_show.Click
        If Password.PasswordChar = Char.MinValue Then
            ' If password masking is disabled, enable it with '*'
            Password.PasswordChar = "*"
        Else
            ' If password masking is enabled, disable it
            Password.PasswordChar = Char.MinValue
        End If
    End Sub



End Class
