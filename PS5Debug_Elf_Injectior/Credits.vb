Public Class Credits

    Private Sub Credits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim initialSize As Size = Me.Size
        Me.MinimumSize = initialSize
        Me.MaximumSize = initialSize
        CreditsInfo()
    End Sub

    Private Sub CreditsInfo()
        RichTextBox1.Rtf = "{\rtf" &
        "{\fonttbl{\f0\fnil\fcharset0 Courier New;}}" &
        "{\colortbl ;\red0\green0\blue0;\red0\green0\blue255;\red0\green128\blue0;\red255\green0\blue0;}" &
        "\fs24\b\cf1 Dlls & Code Samples\fs18\par" &
        "\par" &
        "\fs22\b1\cf4 SiSTRO\fs18\par" &
        "\ul\cf2 https://github.com/SiSTR0\ulnone\par" &
        "\par" &
        "\fs22\b1\cf4 ctn123\fs18\par" &
        "\ul\cf2 https://github.com/ctn123\ulnone\par" &
        "\par" &
        "\fs22\b1\cf4 _Kameleon\fs18\par" &
        "\ul\cf2 https://github.com/kmeps4/PS5Debug_Elf_Injection\ulnone\par" &
        "\par" &
        "\fs22\b1\cf4 PS5DEBUG\fs18\par" &
        "\ul\cf2 https://github.com/GoldHEN/ps5debug\ulnone\par" &
        "\par" &
        "\fs22\b1\cf3 My Github Page\fs18\par" &
        "\ul\cf2 https://github.com/rajeshca911\ulnone\par" &
        "\par" &
        "}"
        AddHandler RichTextBox1.LinkClicked, AddressOf LinkClicked
    End Sub

    Private Sub LinkClicked(sender As Object, e As LinkClickedEventArgs)
        ' Open the clicked link in the default web browser
        Process.Start(e.LinkText)
    End Sub

End Class