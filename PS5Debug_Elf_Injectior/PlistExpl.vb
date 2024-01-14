Imports System.IO

Public Class PlistExpl
    Private Sub PlistExpl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'im fixing size coz maximize look is not good
        Dim initialSize As Size = Me.Size
        Me.MinimumSize = initialSize
        Me.MaximumSize = initialSize
        RefreshElfs()
    End Sub



    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        Dim selectedElfItem As Object = CmbElfs.SelectedItem
        Dim pname As String = CMBplist.SelectedItem
        If selectedElfItem Is Nothing OrElse String.IsNullOrEmpty(selectedElfItem.ToString()) Then
            MessageBox.Show("No Elf Selected")
            Exit Sub
        End If

        Dim IPad As String = CmbElfs.Text.ToString
        If pname Is Nothing OrElse String.IsNullOrEmpty(pname.ToString()) Then
            MessageBox.Show("No Process Selected")
            Exit Sub
        End If
        Dim selectedElf As String = Path.Combine(elfFolder, selectedElfItem.ToString())

        SendDebugElf(IPad, selectedElf, pname)
    End Sub

End Class