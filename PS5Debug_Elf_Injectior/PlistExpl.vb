Imports System.IO
Imports System.Text

Public Class PlistExpl
    Private Sub PlistExpl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'im fixing size coz maximize look is not good
        Dim initialSize As Size = Me.Size
        Me.MinimumSize = initialSize
        Me.MaximumSize = initialSize
        RefreshElfs()

        If Not CMBplist.Items.Contains("eboot.bin") Then
            If CMBplist.Items.Count > 0 Then
                CMBplist.SelectedIndex = 0
            End If

        Else
            CMBplist.SelectedItem = "eboot.bin"
        End If
    End Sub



    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        Dim selectedElfItem As Object = CmbElfs.SelectedItem
        Dim IPad As String = CmbElfs.Text.ToString
        Dim pname As String = CMBplist.SelectedItem
        If selectedElfItem Is Nothing OrElse String.IsNullOrEmpty(selectedElfItem.ToString()) Then
            MessageBox.Show("No Elf Selected")
            Exit Sub
        End If


        If pname Is Nothing OrElse String.IsNullOrEmpty(pname.ToString()) Then
            MessageBox.Show("No Process Selected")
            Exit Sub
        End If
        Dim selectedElf As String = Path.Combine(elfFolder, selectedElfItem.ToString())

        SendDebugElf(IPad, selectedElf, pname)
    End Sub

    Private Sub CMBplist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBplist.SelectedIndexChanged
        If Not CMBplist.SelectedItem Is Nothing Then
            psprocessinfo(HomeForm.TxtIPaddr.Text, CMBplist.SelectedItem.ToString)
        End If

    End Sub


End Class