Imports System
Imports System.Text
Imports System.Globalization
Imports System.Windows.Forms

Public Class Utilitarios
    Public Function getHora() As String
        Dim fechaHoraActual As DateTime = DateTime.Now

        ' Formatear la fecha y hora
        Dim formatter As String = "dd-MM-yyyy HH:mm:ss"
        Return fechaHoraActual.ToString(formatter)
    End Function

    Public Function getHoraLog() As String
        Dim fechaHoraActual As DateTime = DateTime.Now

        ' Formatear la fecha y hora
        Dim formatter As String = "dd-MM-yyyy HH:mm:ss"
        Return "[" & fechaHoraActual.ToString(formatter) & "]"
    End Function

    Function FormatearNumeroConEspacios(numero As Integer) As String
        Try
            Dim numeroConComas As String = numero.ToString("N0", CultureInfo.InvariantCulture)
            Return numeroConComas.Replace(",", " ")
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function validaTxtLleno(pTxt As TextBox) As Boolean
        Return pTxt.Text.Trim().Length > 0
    End Function

    Public Function validaTxtInteger(pTxt As TextBox) As Boolean
        Dim aux As Boolean = True
        Try
            If pTxt.Text.Contains("-") Then
                pTxt.Text = pTxt.Text.Replace("-", "")
            End If
            Dim i As Integer = Integer.Parse(pTxt.Text)
        Catch ex As FormatException
            aux = False
        End Try
        Return aux
    End Function

    Public Function validaTxtFloat(pTxt As TextBox) As Boolean
        Try
            Dim i As Single = Single.Parse(pTxt.Text, CultureInfo.InvariantCulture)
        Catch ex As FormatException
            Return False
        End Try
        Return True
    End Function

    Public Function validaFloat(pTxt As String) As Boolean
        Dim aux As Boolean = True
        Try
            Dim i As Single = Single.Parse(pTxt, CultureInfo.InvariantCulture)
        Catch ex As FormatException
            aux = False
        End Try
        Return aux
    End Function

    Public Function validaCboSeleccionado(pCbo As ComboBox) As Boolean
        Try
            Return pCbo.SelectedIndex <> -1
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Cifrar(input As String) As String
        Try
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(input)
            Dim encodedString As String = Convert.ToBase64String(bytes)
            Return encodedString
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Decifrar(input As String) As String
        Try
            Dim bytes As Byte() = Convert.FromBase64String(input)
            Dim decodedString As String = Encoding.UTF8.GetString(bytes)
            Return decodedString
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
