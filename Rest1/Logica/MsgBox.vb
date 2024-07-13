Imports System.IO

Public Class MsgBox
    Public Sub New()
    End Sub

    Public Shared Sub Log(msg As Exception)
        Try
            Dim objArch As New Archivo()
            Dim objUtil As New Utilitarios()
            objArch.escribirLineaReg(objUtil.getHoraLog() & " " & msg.ToString)
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show("Error registrando el log", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
        End Try
    End Sub

    Public Shared Sub [Error](msg As Exception)
        Try
            Dim objArch As New Archivo()
            Dim objUtil As New Utilitarios()
            objArch.escribirLineaReg(objUtil.getHoraLog() & " " & msg.ToString)
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show("Error registrando el error", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
        End Try

        System.Windows.Forms.MessageBox.Show(msg.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
    End Sub

    Public Shared Sub Info(msg As String)
        System.Windows.Forms.MessageBox.Show(msg, "¡Atención!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information)
    End Sub

    Public Shared Function YesNo(msg As String) As Integer
        Return System.Windows.Forms.MessageBox.Show(msg, "¡Atención!", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question)
    End Function

    Public Shared Function YesResponse() As Integer
        Return System.Windows.Forms.DialogResult.Yes
    End Function

    Public Shared Function NoResponse() As Integer
        Return System.Windows.Forms.DialogResult.No
    End Function
End Class

