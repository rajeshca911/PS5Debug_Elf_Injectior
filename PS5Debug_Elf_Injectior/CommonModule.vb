Imports System.IO

Module CommonModule
    Public appLocation As String = Application.StartupPath
    Public elfFolder As String = Path.Combine(appLocation, "Place Elfs Here")

    Public Sub RefreshElfs()

        PlistExpl.CmbElfs.Items.Clear()

        Try

            If Not Directory.Exists(elfFolder) Then
                Directory.CreateDirectory(elfFolder)
            End If

            Dim elfFiles As String() = Directory.GetFiles(elfFolder, "*.elf")

            For Each elfFile As String In elfFiles
                Dim elfName As String = Path.GetFileName(elfFile)
                If Not PlistExpl.CmbElfs.Items.Contains(elfName) Then
                    PlistExpl.CmbElfs.Items.Add(elfName)
                End If

            Next
            'With Form1.Statlabel
            '    .Text = $"Found {elfFiles.Count.ToString} elf(s)"
            '    .Update()
            'End With
            With PlistExpl.lblElfCount
                .Text = $"Found {elfFiles.Count.ToString} elf(s)"
                .Update()
            End With

            If PlistExpl.CmbElfs.Items.Count > 0 Then
                PlistExpl.CmbElfs.SelectedIndex = 0
            End If
        Catch ex As Exception

            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Module