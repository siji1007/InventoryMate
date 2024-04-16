Public Class CUSTOMER
    Private Sub Lbl_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_customer.Anchor = AnchorStyles.None
        Lbl_customer.TextAlign = ContentAlignment.MiddleCenter
        Lbl_customer.AutoSize = False
        Lbl_customer.Width = Me.ClientSize.Width ' Adjust this if needed


        Dim centerX As Integer = (Me.ClientSize.Width - Lbl_customer.Width) \ 2
        Lbl_customer.Location = New Point(centerX, Lbl_customer.Location.Y)

    End Sub
End Class