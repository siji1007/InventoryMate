Public Class WARRANTY
    Private Sub lbl_warranty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_warranty.Anchor = AnchorStyles.None
        lbl_warranty.TextAlign = ContentAlignment.MiddleCenter
        lbl_warranty.AutoSize = False
        lbl_warranty.Width = Me.ClientSize.Width ' Adjust this if needed


        Dim centerX As Integer = (Me.ClientSize.Width - lbl_warranty.Width) \ 2
        lbl_warranty.Location = New Point(centerX, lbl_warranty.Location.Y)

    End Sub








End Class