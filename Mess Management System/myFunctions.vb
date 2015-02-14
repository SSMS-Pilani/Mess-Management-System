Module myFunctions

    Public Sub enterToTab(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Public Sub enable(sender As Object)
        sender.Enabled = True
        Try
            sender.ReadOnly = False
        Catch
        End Try

    End Sub

    Public Sub disable(sender As Object)
        sender.ReadOnly = True
        sender.Enabled = False
    End Sub

    Public Function proceedAndEnable(current As Object, nextField As Object, Optional unlock As Boolean = False)

        If current.text <> "" Then
            If Not unlock Then disable(current)
            enable(nextField)
            nextField.focus()
            Return True
        Else
            Return False
        End If
    End Function

End Module
