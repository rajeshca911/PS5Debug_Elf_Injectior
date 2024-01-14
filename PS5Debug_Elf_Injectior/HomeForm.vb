Imports System.IO

Public Class HomeForm

    Private Sub BtnFetchPL_Click(sender As Object, e As EventArgs) Handles BtnFetchPL.Click

        Dim ipaddress As String = Me.TxtIPaddr.Text.Trim
        FetchProcessesAsync(ipaddress)

    End Sub

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ipaddr As String = My.Settings.IPAddr.Trim
        If Not String.IsNullOrEmpty(ipaddr) Then
            Me.TxtIPaddr.Text = ipaddr
        End If
        'check folder exists or not
        Dim placeelfs As String = Path.Combine(appLocation, "Place Elfs Here")
        If Not Directory.Exists(placeelfs) Then
            Directory.CreateDirectory(placeelfs)
        End If
    End Sub

End Class