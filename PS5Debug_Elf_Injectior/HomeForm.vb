Imports System.IO
Imports PS5Debug_Elf_Injectior.PS5PayloadSender

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

    Private Sub BtnDebug_Click(sender As Object, e As EventArgs) Handles BtnDebug.Click
        Dim response As DialogResult = MessageBox.Show("Please refrain from sending the payload if you have already sent the debug payload or if 'etahen' is enabled in the browser. Are you sure you want to continue?", "Continue ??", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = DialogResult.No Then
            Exit Sub
        End If

        Dim debugfolder As String = Path.Combine(appLocation, "Ps5_Debugger")
        Dim debugbin As String = Path.Combine(debugfolder, "ps5debug.elf")
        If Not File.Exists(debugbin) Then
            MessageBox.Show("Please Place ps5debug.elf in Ps5_Debugger Folder", "Missing")
            Exit Sub
        End If
        Statlabel.Text = "[+]Sending Debug Payload..."
        Dim psip As String = Me.TxtIPaddr.Text
        Dim portnum As Integer = 9020
        Dim psender As New PayloadV2()
        Dim isConnected As Boolean = psender.Connect2PS5(psip, portnum)
        If isConnected Then

            Try
                Application.DoEvents()
                psender.SendPayload(debugbin)
                psender.DisconnectPayload()
                MessageBox.Show("Payload sent successfully!", "Success")
                Statlabel.Text = "[+]Payload Sent"
                BtnFetchPL.PerformClick()
            Catch ex As Exception
                Statlabel.Text = "[x]Payload Not Sent"
                MessageBox.Show("Error while sending payload: " & ex.Message)
                Exit Sub
            End Try
        Else
            Statlabel.Text = "[x]Payload Not Sent"
            MessageBox.Show("IP Not Found !!" & vbNewLine & $"{psip}:{portnum}", "Host Not Found")
        End If
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Me.Hide()
        With App_Settings
            Dim initialsize = .Size
            .StartPosition = FormStartPosition.CenterScreen
            .MinimumSize = initialsize
            .MaximumSize = initialsize
            .ShowDialog()
        End With
        Me.Show()
    End Sub

End Class