Imports System.IO

Public Class Archivo

    'Private Shared ReadOnly archConfig As String = "conf.txt"
    'Private Shared ReadOnly archModo As String = "modo.txt"
    Private Shared ReadOnly archReg As String = "log.txt"

    Public Sub New()
        Try
            crearArchivo(archReg)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function existeArchivo(pArch As String) As Boolean
        Dim archivo As New FileInfo(pArch)
        Return archivo.Exists
    End Function

    Private Sub crearArchivo(pArch As String)
        Try
            If Not existeArchivo(pArch) Then
                Dim archivo As New FileStream(pArch, FileMode.CreateNew)
                archivo.Close()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub escribirLineaArch(pArch As String, pText As String)
        Try
            Using sw As New StreamWriter(pArch, True)
                sw.WriteLine(pText)
            End Using
        Catch ex As IOException
            Throw ex
        End Try
    End Sub

    Public Sub escribirLineaReg(pText As String)
        Try
            escribirLineaArch(archReg, pText)
        Catch ex As IOException
            Throw ex
        End Try
    End Sub
End Class
