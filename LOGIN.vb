Public Class LOGIN


    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
    End Sub
    Private Sub SignIn_Click(sender As Object, e As EventArgs) Handles SignIn.Click
        If Username.Text = "ADMIN" AndAlso Password.Text = "ADMIN" Then
            Me.Hide()
            MessageBox.Show("Owner form: " & If(Me.Owner IsNot Nothing, Me.Owner.GetType().ToString(), "None"))


            ' Show the DASHBOARD form in the main_container panel of MAIN_FORM
            Dim mainForm As MAIN_FORM = TryCast(Me.Owner, MAIN_FORM)
            If mainForm IsNot Nothing Then
                mainForm.ShowDashboard()
            Else
                MessageBox.Show("Error accessing the parent form.")
            End If
        Else
            MessageBox.Show("Invalid username or password. Please try again.")
        End If
    End Sub




End Class
