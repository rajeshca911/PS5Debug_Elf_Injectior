Imports System.Net
Imports System.Net.Sockets

Namespace PS5PayloadSender

    Public Class PayloadV2
        Public psocket As Socket
        Public pDConnected As Boolean
        Public PayloadException As String ' Rename Exception to avoid conflict with the Exception class
        Public path As String

        Public Function Connect2PS5(ByVal ip As String, ByVal port As String) As Boolean
            Application.DoEvents()

            Try
                psocket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
                psocket.ReceiveTimeout = 3000
                psocket.SendTimeout = 3000
                psocket.Connect(New IPEndPoint(IPAddress.Parse(ip), Int32.Parse(port)))
                pDConnected = True
                Return True
            Catch ex As Exception
                pDConnected = False
                PayloadException = ex.ToString()
                If ex.Message.Contains("established connection failed because connected host has failed to respond") Then
                    PayloadException = "IP is not responding !! Please check IP and Connectivity"
                Else
                    PayloadException = ex.Message
                End If
                Return False
            End Try
        End Function

        Public Sub SendPayload(ByVal filename As String)
            psocket.SendFile(filename)
        End Sub

        Public Sub DisconnectPayload()
            pDConnected = False
            psocket.Close()
        End Sub

    End Class

End Namespace