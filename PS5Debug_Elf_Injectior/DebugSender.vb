Imports System.IO
Imports System.Text
Imports libdebug

Module DebugSender

    Public PS5 As PS4DBG
    Public totalproces As Integer = 0

    Public Sub SendDebugElf(IPADD As String, ElfFile As String, Optional ByVal Pname As String = "eboot.bin")
        'With Form1.Statlabel
        '    .ForeColor = Color.Green
        '    .Text = "[+] Connecting..Please wait"
        '    .Update()
        'End With
        Try
            Application.DoEvents()
            'Dim IPADD As String = Form1.IPTextBOX.Text.Trim()

            connectps5(IPADD)
            Dim PL As ProcessList = PS5.GetProcessList()
            Dim P As Process = PL.FindProcess(Pname)
            'Form1.Statlabel.ForeColor = Color.Blue
            If P Is Nothing Then
                ' Form1.Statlabel.Text = "[X] process not found"
                MessageBox.Show($"{Pname} Not found !!")
                Disconnectps5()
                Exit Sub
            End If
            My.Settings.IPAddr = IPADD
            My.Settings.Save()
            Dim stub As ULong = PS5.InstallRPC(P.pid)
            'Dim cleanelf As String = "PS5-CleanELF.elf"
            PS5.LoadElf(P.pid, ElfFile)
            PS5.Notify(222, $"[+] Loaded: {Path.GetFileName(ElfFile)}")
            'Form1.Statlabel.Text = "[+] Elf Loaded"
            Disconnectps5()
        Catch ex As Exception
            'With Form1.Statlabel
            '    .Text = "[x] Error"
            '    .ForeColor = Color.Red
            '    .Update()
            'End With
            MessageBox.Show($"Error: {ex.Message}", "Error: " & Err.Number, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub psprocessinfo(IPADD As String, pname As String)
        Dim st As New StringBuilder
        Try

            connectps5(IPADD)
            Dim PL As ProcessList = PS5.GetProcessList()
            Dim P As Process = PL.FindProcess(pname)
            If P Is Nothing Then
                MessageBox.Show($"{pname} Not found !!")
                Disconnectps5()
                Exit Sub
            End If
            st.AppendLine(P.ToString)
            st.AppendLine("Process ID: " & P.pid)
            PlistExpl.TxtStat.Text = st.ToString
        Catch ex As Exception
            Disconnectps5()
        End Try
    End Sub

    Public Sub FetchProcessesAsync(IPADD As String)
        totalproces = 0
        With HomeForm.Statlabel
            .ForeColor = Color.Green
            .Text = "[+] Connecting.."

        End With

        Try

            'Dim IPADD As String = Form1.IPTextBOX.Text.Trim()

            connectps5(IPADD)
            Dim PL As ProcessList = PS5.GetProcessList()
            PlistExpl.CMBplist.Items.Clear()

            With HomeForm.Statlabel
                .Text = "[√] Processes fetched successfully"
                .ForeColor = Color.Green
            End With

            If PL.processes IsNot Nothing Then
                PlistExpl.CMBplist.Items.Clear()

                For Each process As Process In PL.processes
                    PlistExpl.CMBplist.Items.Add(process.name)
                Next
            End If

            'If PlistExpl.CMBplist.Items.Count > 0 AndAlso PlistExpl.CMBplist.SelectedItem IsNot Nothing AndAlso Not String.IsNullOrEmpty(PlistExpl.CMBplist.SelectedItem.ToString()) Then
            '    Dim ebut As Process = PL.FindProcess("eboot.bin")
            '    If ebut Is Nothing Then
            '        PlistExpl.CMBplist.SelectedIndex = 0
            '    Else
            '        PlistExpl.CMBplist.SelectedItem = "eboot.bin"
            '    End If
            'End If

            totalproces = PL.processes.Count
            PlistExpl.LblProcess.Text = $"Found Processes {totalproces.ToString}"

            My.Settings.IPAddr = IPADD
            My.Settings.Save()
            HomeForm.Hide()
            PlistExpl.ShowDialog()
            HomeForm.Show()
        Catch ex As Exception
            HomeForm.Statlabel.Text = "[X] Error.."
            HomeForm.Statlabel.ForeColor = Color.Red
            MessageBox.Show($"Error: {ex.Message}", "Error: " & Err.Number, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            Disconnectps5()
        End Try

    End Sub

    Public Sub connectps5(IPADD As String)
        Try

            PS5 = New PS4DBG(IPADD)
            PS5.Connect()
            PS5.Notify(222, "Connected ..!")
            'console.writeline(PS5.GetConsoleDebugVersion())
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Could Not Connect PS5")
        End Try
    End Sub

    Public Sub Disconnectps5()
        Try
            If PS5.IsConnected Then
                PS5.Notify(222, "Safely Exiting ..!")
                PS5.Disconnect()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Could Not DisConnect PS5")
        End Try
    End Sub

    Public Sub GetInfo()
        Dim dg As New StringBuilder
        connectps5(HomeForm.TxtIPaddr.Text.Trim)
        dg.AppendLine("Debug Version: " & PS5.GetConsoleDebugVersion())
        dg.AppendLine("Library Version: " & PS5.GetLibraryDebugVersion())

        Disconnectps5()
        MessageBox.Show(dg.ToString)
        PlistExpl.TxtStat.Text = dg.ToString
    End Sub

End Module