Imports System.IO


Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs)
        'im fixing size coz maximize look is not good
        Dim initialSize As Size = Me.Size
        Me.MinimumSize = initialSize
        Me.MaximumSize = initialSize
        'load savedip
        Dim ipad As String = My.Settings.IPAddr.ToString.Trim()
        If Not String.IsNullOrEmpty(ipad) Then
            Me.TxtIPaddr.Text = ipad
        End If
        'Refresh Elfs
        RefreshElfs()
    End Sub

    Private Sub BtnFetchPL_Click(sender As Object, e As EventArgs) Handles BtnFetchPL.Click

        Statlabel.Text = "[+]Connecting.."
        Dim ipaddress As String = Me.TxtIPaddr.Text.Trim()
        FetchProcessesAsync(ipaddress)
        ' Any code after the FetchProcessesAsync call will be executed after the asynchronous operation completes.
        Statlabel.Text = "[🅘] Idle."

        'delete the following later
        PlistExpl.Show()
    End Sub
End Class
