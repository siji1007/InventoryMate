Public Class SUPPLIER
    Private Sub Lbl_supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lbl_supplier.Anchor = AnchorStyles.None
        Lbl_supplier.TextAlign = ContentAlignment.MiddleCenter
        Lbl_supplier.AutoSize = False
        Lbl_supplier.Width = Me.ClientSize.Width ' Adjust this if needed


        Dim centerX As Integer = (Me.ClientSize.Width - Lbl_supplier.Width) \ 2
        Lbl_supplier.Location = New Point(centerX, Lbl_supplier.Location.Y)

    End Sub
End Class