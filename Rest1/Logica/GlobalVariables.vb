Public Class GlobalVariables
    Public Shared user As Usuario

    Public Shared Function getUser() As String
        Try
            If user IsNot Nothing Then
                Return user.Usuario
            End If
            Return "UNKNOWN"
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function getRol() As String
        Try
            If user IsNot Nothing Then
                Return user.Usuario
            End If
            Return "NONE"
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
