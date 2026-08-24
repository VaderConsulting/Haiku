Imports Microsoft.Win32

' http://www.slipstick.com/mail1/siggraphic.htm

' Outlook 97:
' Look in your Windows folder for an .rtf file that matches the name of your Outlook profile, e.g. Outlook Settings.rtf. 
' Open this in WordPad or Word. Now, use a graphics program to open the graphic and copy it to the Clipboard. 
' Go back to the .rtf file, and paste in the graphic. Then close and save the .rtf file.  
' Once you add a graphic, any changes to the AutoSignature need to be made by editing the .rtf file. 
' Updating it with Tools | AutoSignature will remove the graphic. 


' Outlook 2000
' 1. Choose Tools | Options | Mail Format. 
' 2. Make sure the default format is set to HTML.
' 3. Click Signature Picker. 
' 4. On the Signature Picker dialog, select the signature, then click Edit. 
' 5. On the Edit Signature dialog, click Advanced Edit. This will open the .htm file for the signature in your system's default HTML editor. 
' 6. Use your HTML editor's tools to insert a graphic.
' 7. Save the file and click OK until you return to Outlook.
'
' If you don't have an HTML editor, you can locate the .htm file for the signature in your Windows\Application Data\Microsoft\Signatures folder, 
' then edit it in Notepad to add an HTML image tag like this:
' <img border="0" src="file:///E:/Pix/Sliplogo.gif">

Public Class frmMain

    Private _SignaturePath As String = ""

    Private Sub tmrMain_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMain.Tick
        tmrMain.Enabled = False

        Initialise()
    End Sub

    Private Sub Initialise()
        Dim OSVersion As String = GetWindowsVersion()
        Dim OfficeVersion As String = GetOutlookVersion()

        lblWindowsVersion.Text = OSVersion
        lblOutlookVersion.Text = OfficeVersion

        Select Case lblWindowsVersion.Text
            Case "Win3.1"  ' IMPOSSIBLE AS .NET DOESN'T WORK ON THIS PLATFORM
                ' NOT SUPPORTED
            Case "Win95"   ' IMPOSSIBLE AS .NET DOESN'T WORK ON THIS PLATFORM
                ' NOT SUPPORTED
            Case "Win98"   ' HIGHLY UNLIKELY, and only .NET 2.0
                _SignaturePath = "%USERPROFILE%\Application Data\Microsoft\Signatures" ' Untested
            Case "WinME"   ' HIGHLY UNLIKELY, and only .NET 2.0
                _SignaturePath = "%USERPROFILE%\Application Data\Microsoft\Signatures" ' Untested
            Case "NT3.51"  ' IMPOSSIBLE AS .NET DOESN'T WORK ON THIS PLATFORM
                ' NOT SUPPORTED
            Case "NT4.0"   ' IMPOSSIBLE AS .NET DOESN'T WORK ON THIS PLATFORM
                ' NOT SUPPORTED
            Case "Win2000" ' Only .NET 2.0
                _SignaturePath = "%USERPROFILE%\Application Data\Microsoft\Signatures" ' Untested
            Case "WinXP"
                ' .NET 2.0 and 3.5, but not 4.0
                _SignaturePath = "%USERPROFILE%\Application Data\Microsoft\Signatures" ' Untested
            Case "Win2003"
                _SignaturePath = "%USERPROFILE%\Application Data\Microsoft\Signatures" ' Untested
            Case "WinVista"
                _SignaturePath = "%USERPROFILE%\AppData\Roaming\microsoft\signatures" ' Untested
            Case "Win2008"
                _SignaturePath = "%USERPROFILE%\AppData\Roaming\microsoft\signatures" ' Untested
            Case "Win7"
                _SignaturePath = "%USERPROFILE%\AppData\Roaming\microsoft\signatures" ' CONFIRMED
            Case "WinCE"
                ' NOT SUPPORTED (YET?)
            Case "MacOSX"
                ' NOT SUPPORTED (YET?)
            Case "Unix"
                ' NOT SUPPORTED (YET?)
            Case "Xbox"
                ' NOT SUPPORTED (YET?)
            Case Else
                ' NOT SUPPORTED (YET?)
        End Select

    End Sub

    Public Function GetWindowsVersion() As String
        Select Case Environment.OSVersion.Platform
            Case PlatformID.Win32S
                Return "Win3.1"
            Case PlatformID.Win32Windows
                Select Case Environment.OSVersion.Version.Minor
                    Case 0
                        Return "Win95"
                    Case 10
                        Return "Win98"
                    Case 90
                        Return "WinME"
                    Case Else
                        Return "Unknown" & Environment.OSVersion.Version.Major & "." & Environment.OSVersion.Version.Minor
                End Select
            Case PlatformID.Win32NT
                Select Case Environment.OSVersion.Version.Major
                    Case 3
                        Return "NT3.51"
                    Case 4
                        Return "NT4.0"
                    Case 5
                        Select Case Environment.OSVersion.Version.Minor
                            Case 0
                                Return "Win2000"
                            Case 1
                                Return "WinXP"
                            Case 2
                                Return "Win2003"
                            Case Else
                                Return "Unknown" & Environment.OSVersion.Version.Major & "." & Environment.OSVersion.Version.Minor
                        End Select
                    Case 6
                        Select Case Environment.OSVersion.Version.Minor
                            Case 0
                                If My.Computer.Info.OSFullName Like "Vista" Then
                                    Return "WinVista"
                                ElseIf My.Computer.Info.OSFullName Like "2008" Then
                                    Return "Win2008"
                                Else
                                    Return "Unknown" & Environment.OSVersion.Version.Major & "." & Environment.OSVersion.Version.Minor
                                End If
                            Case 1
                                Return "Win7"
                            Case Else
                                Return "Unknown" & Environment.OSVersion.Version.Major & "." & Environment.OSVersion.Version.Minor
                        End Select
                    Case Else
                        Return "Unknown" & Environment.OSVersion.Version.Major & "." & Environment.OSVersion.Version.Minor
                End Select
            Case PlatformID.WinCE
                Return "WinCE"
            Case PlatformID.MacOSX
                Return "MacOSX"
            Case PlatformID.Unix
                Return "Unix"
            Case PlatformID.Xbox
                Return "Xbox"
            Case Else
                Return "Unknown" & Environment.OSVersion.Version.Major & "." & Environment.OSVersion.Version.Minor
        End Select
    End Function

    Private Function GetOutlookVersion() As String
        Dim RegKey As RegistryKey = Registry.ClassesRoot
        Dim OutlookFullName As String = RegKey.OpenSubKey("Outlook.Application\CurVer").GetValue("")
        Dim OutlookVersion As String = "Unknown"

        RegKey = Nothing

        If OutlookFullName.Trim.Length > 0 Then
            OutlookVersion = OutlookFullName.Substring(OutlookFullName.LastIndexOf(".") + 1)
        End If

        Select Case OutlookVersion
            Case "7"
                Return "95"
            Case "8"
                Return "97"
            Case "9"
                Return "2000"
            Case "10"
                Return "XP" ' Sometimes known as 2002
            Case "11"
                Return "2003"
            Case "12"
                Return "2007"
            Case "13"
                Return "Unknown" ' No version 13 exists
            Case "14"
                Return "2010"
            Case "15"
                Return "2012"
            Case Else
                Return "Unknown"
        End Select

    End Function

    Private Sub btnConfigure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigure.Click

        ' Edit the signature according to the Outlook version that is installed
        Select Case lblOutlookVersion.Text
            Case "7" ' 95

            Case "8" ' 97

            Case "9" ' 2000

            Case "10" ' XP (Sometimes known as 2002)

            Case "11" ' 2003
                ' Outlook 2003: (Also works with 2010)
                ' http://www.haikucandy.com/page/how_use_outlook2003
                '
                ' Signature filename = default.htm (by default)

                ' Content:
                ' ===============================================================================
                ' <!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
                ' <HTML><HEAD><TITLE>Default Signature</TITLE>
                ' <META Content="text/html; charset=windows-1252" http-equiv=Content-Type>
                ' <META name=GENERATOR content="MSHTML 8.00.6001.18904"></HEAD>
                ' <BODY>
                ' <DIV align=left></DIV>
                ' <img src="http://www.haikucandy.com/haiku_australian_haikucandy.jpg" border="0" alt="Download Haiku from http://www.HaikuCandy.com/"><br>
                ' </BODY></HTML>
                ' ===============================================================================

            Case "12" ' 2007
                ' Outlook 2007:
                ' http://www.haikucandy.com/page/how_use_outlook2007
            Case "13" ' No version 13 exists

            Case "14" ' 2010

            Case "15" ' 2012

            Case Else
                ' Windows Mail and Outlook Express:
                ' http://www.haikucandy.com/page/how_use_winmail
        End Select
    End Sub

    Private Sub EditOutlookSignature()

    End Sub

End Class
