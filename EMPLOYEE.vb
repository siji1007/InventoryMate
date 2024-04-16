Public Class EMPLOYEE
    Private Sub lbl_employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_employee.Anchor = AnchorStyles.None
        lbl_employee.TextAlign = ContentAlignment.MiddleCenter
        lbl_employee.AutoSize = False
        lbl_employee.Width = Me.ClientSize.Width ' Adjust this if needed


        Dim centerX As Integer = (Me.ClientSize.Width - lbl_employee.Width) \ 2
        lbl_employee.Location = New Point(centerX, lbl_employee.Location.Y)

    End Sub
End Class