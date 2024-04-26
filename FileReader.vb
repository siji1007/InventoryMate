Module FileReader

    Public Function CheckFileValueAndDisableButton(filePath As String, buttonToDisable As Button) As Boolean
        Try
            ' Read the current value from the text file
            Dim currentValue As Integer = 0
            If System.IO.File.Exists(filePath) Then
                Dim currentValueText As String = My.Computer.FileSystem.ReadAllText(filePath)
                Integer.TryParse(currentValueText, currentValue)
            End If

            ' Check if the current value is greater than 0
            If currentValue > 0 Then
                buttonToDisable.Enabled = False ' Disable the button
                Return True ' Indicate that the button was disabled
            Else
                buttonToDisable.Enabled = True ' Enable the button
                Return False ' Indicate that the button was enabled
            End If
        Catch ex As Exception
            MessageBox.Show("Error reading file or disabling button: " & ex.Message)
            Return False ' Indicate that an error occurred
        End Try
    End Function
End Module
