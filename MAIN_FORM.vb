Public Class MAIN_FORM
    Private Sub MAIN_FORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get the screen's working area (excluding taskbar)
        Dim workingArea As Rectangle = Screen.GetWorkingArea(Me)

        ' Set the form's size and position to cover the entire screen
        Me.Bounds = workingArea

        ' Show your login form or any other content
        ShowLogin()
    End Sub




    Public Sub ShowLogin()
        ' Create an instance of the LOGIN form
        Dim loginForm As New LOGIN()

        ' Set the owner form to MAIN_FORM
        loginForm.Owner = Me


        ' Set LOGIN form properties
        loginForm.TopLevel = False
        loginForm.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Bottom Or AnchorStyles.Right
        loginForm.WindowState = FormWindowState.Maximized



        ' Add LOGIN form to main_container panel and show it
        main_container.Controls.Add(loginForm)
        loginForm.BringToFront()
        loginForm.Show()
    End Sub

    Public Sub CloseDashboard()
        ' Find and close the dashboard if it's currently open
        For Each ctrl As Control In main_container.Controls
            If TypeOf ctrl Is DASHBOARD Then
                ctrl.Dispose()
                Exit For
            End If
        Next
    End Sub

    Public Sub ShowDashboard()
        ' Close any existing LOGIN form
        For Each ctrl As Control In main_container.Controls
            If TypeOf ctrl Is LOGIN Then
                main_container.Controls.Remove(ctrl)
                ctrl.Dispose()
                Exit For
            End If
        Next

        ' Create an instance of the DASHBOARD form
        Dim dashboard As New DASHBOARD()

        ' Set the owner of the DASHBOARD form to MAIN_FORM
        dashboard.Owner = Me

        ' Set DASHBOARD form properties
        dashboard.TopLevel = False
        dashboard.FormBorderStyle = FormBorderStyle.None
        dashboard.Dock = DockStyle.Fill

        ' Add the DASHBOARD form to the main_container panel
        main_container.Controls.Add(dashboard)

        ' Bring the DASHBOARD form to the front and show it
        dashboard.BringToFront()
        dashboard.WindowState = FormWindowState.Maximized
        dashboard.Show()
    End Sub

    Private Sub main_container_Paint(sender As Object, e As PaintEventArgs) Handles main_container.Paint

    End Sub
End Class