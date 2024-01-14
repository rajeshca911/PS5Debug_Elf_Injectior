Imports System.IO


Public Class Form1
    Private appLocation As String = Application.StartupPath
    Private elfFolder As String = Path.Combine(appLocation, "Place Elfs Here")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub RefreshElfs()

        CmbElfs.Items.Clear()

        Try



            If Not Directory.Exists(elfFolder) Then
                Directory.CreateDirectory(elfFolder)
            End If

            Dim elfFiles As String() = Directory.GetFiles(elfFolder, "*.elf")

            For Each elfFile As String In elfFiles
                Dim elfName As String = Path.GetFileName(elfFile)
                If Not CmbElfs.Items.Contains(elfName) Then
                    CmbElfs.Items.Add(elfName)
                End If

            Next

            If CmbElfs.Items.Count > 0 Then
                CmbElfs.SelectedIndex = 0
            End If
        Catch ex As Exception

            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CmbElfs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbElfs.SelectedIndexChanged

    End Sub

    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click

        Dim selectedElfItem As Object = CmbElfs.SelectedItem

        If selectedElfItem Is Nothing OrElse String.IsNullOrEmpty(selectedElfItem.ToString()) Then
            MessageBox.Show("No Elf Selected")
            Exit Sub
        End If
        Dim selectedElf As String = Path.Combine(elfFolder, selectedElfItem.ToString())
        Dim IPad As String = Me.TxtIPaddr.Text.ToString

        SendDebugElf(IPad, selectedElf)
    End Sub

End Class
