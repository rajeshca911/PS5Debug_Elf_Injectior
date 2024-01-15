Imports System.IO

Public Class App_Settings

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try

            Dim ipadd As String = Me.TxtIPAddr.Text.Trim
            Dim portnum As Integer = CInt(Me.TXTpayload.Text.Trim)
            Dim dbp As String = Me.TxtDebug.Text.Trim

            'saving part
            My.Settings.IPAddr = ipadd
            My.Settings.portnumber = portnum
            My.Settings.DebugPayload = dbp
            My.Settings.Save()
            loadValues()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub loadValues()
        Try
            If Not String.IsNullOrEmpty(My.Settings.IPAddr) Then
                TxtIPAddr.Text = My.Settings.IPAddr
            End If

            If Not String.IsNullOrEmpty(My.Settings.portnumber.ToString) Then
                TXTpayload.Text = My.Settings.portnumber
            End If
            If Not String.IsNullOrEmpty(My.Settings.DebugPayload) Then
                TxtDebug.Text = My.Settings.DebugPayload
            Else
                Dim dgbfolder As String = Path.Combine(appLocation, "Ps5_Debugger")
                Dim binlocation As String = Path.Combine(dgbfolder, "ps5debug.elf")
                If File.Exists(binlocation) Then
                    TxtDebug.Text = binlocation
                Else
                    MessageBox.Show("Debug Payload Missing.! Locate the file")
                    BtnBrowse.PerformClick()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub App_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadValues()
    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        '
        '"All files (*.*)|*.*|All files (*.*)|*.*"

        Dim sfile As String = Browseforfile("All files (*.*)|*.*|Binary Files (*.bin, *.elf)|*.bin;*.elf")
        If Not String.IsNullOrEmpty(sfile) Then
            TxtDebug.Text = sfile
        End If

    End Sub

End Class