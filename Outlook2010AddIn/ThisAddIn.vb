Public Class ThisAddIn

    Private WithEvents inspectors As Outlook.Inspectors

    Private Sub ThisAddIn_Startup() Handles Me.Startup
        inspectors = Me.Application.Inspectors
    End Sub

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown
        inspectors = Nothing
    End Sub

    Private Sub inspectors_NewInspector(ByVal Inspector As Microsoft.Office.Interop.Outlook.Inspector) Handles inspectors.NewInspector
        Dim mailItem As Outlook.MailItem = TryCast(Inspector.CurrentItem, Outlook.MailItem)

        mailItem.BodyFormat = Outlook.OlBodyFormat.olFormatHTML

        If Not (mailItem Is Nothing) Then
            If mailItem.EntryID Is Nothing Then
                mailItem.HTMLBody = "<HTML>"
                mailItem.HTMLBody &= "<BODY>"
                mailItem.HTMLBody &= "<img src='http://www.haikucandy.com/haiku_australian_stones.jpg' border='0' alt='Download Haiku from http://www.HaikuCandy.com/'><br><font size='1' face='Verdana'>Haiku email signature from: <a href='http://www.haikucandy.com/'>www.HaikuCandy.com</a></font><br/><a href='http://www.haikucandy.com/'><img src='http://www.haikucandy.com/logo' border='0'></a>"
                mailItem.HTMLBody &= "</BODY>"
                mailItem.HTMLBody &= "</HTML>"
            End If
        End If
    End Sub

End Class
