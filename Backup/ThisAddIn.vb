Public Class ThisAddIn

    Private WithEvents inspectors As Outlook.Inspectors

    Private Sub ThisAddIn_Startup() Handles Me.Startup
        inspectors = Me.Application.Inspectors
    End Sub

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

    End Sub

    Private Sub inspectors_NewInspector(ByVal Inspector As Microsoft.Office.Interop.Outlook.Inspector) Handles inspectors.NewInspector
        Dim mailItem As Outlook.MailItem = TryCast(inspector.CurrentItem, Outlook.MailItem)
        If Not (mailItem Is Nothing) Then
            If mailItem.EntryID Is Nothing Then
                mailItem.Subject = "This text was added by using code"
                mailItem.Body = "This text was added by using code"
            End If
        End If
    End Sub

End Class
