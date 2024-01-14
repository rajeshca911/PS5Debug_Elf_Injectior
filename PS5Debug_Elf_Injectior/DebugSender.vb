Imports libdebug

Module DebugSender
    Public PS5 As PS4DBG
    Public Sub SendDebugElf(IPADD As String, ElfFile As String)
        With Form1.Statlabel
            .ForeColor = Color.Green
            .Text = "[+] Connecting..Please wait"
        End With
        Try
            Application.DoEvents()
            'Dim IPADD As String = Form1.IPTextBOX.Text.Trim()

            PS5 = New PS4DBG(IPADD)
            PS5.Connect()
            Dim PL As ProcessList = PS5.GetProcessList()
            Dim P As Process = PL.FindProcess("eboot.bin")
            Form1.Statlabel.ForeColor = Color.Blue
            If P Is Nothing Then
                Form1.Statlabel.Text = "[X] process not found"
            End If
            My.Settings.IPAddr = IPADD
            My.Settings.Save()
            Dim stub As ULong = PS5.InstallRPC(P.pid)
            'Dim cleanelf As String = "PS5-CleanELF.elf"
            PS5.LoadElf(P.pid, ElfFile)
            Form1.Statlabel.Text = "[+] Elf Loaded"
            PS5.Disconnect()
        Catch ex As Exception
            With Form1.Statlabel
                .Text = "[x] Error"
                .ForeColor = Color.Red

            End With
            MessageBox.Show($"Error: {ex.Message}", "Error: " & Err.Number, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
