Imports System.Drawing.Printing

Public Class Impresion
    Private WithEvents pd As New PrintDocument()
    Private printText As String



    Public Sub Imprimir(pTexto As String)
        printText = pTexto

        Dim pd As New PrintDocument()

        AddHandler pd.PrintPage, AddressOf Me.PrintPageHandler

        pd.PrinterSettings.PrinterName = "ZKP8012"

        pd.Print()
    End Sub

    Private Sub PrintPageHandler(sender As Object, e As PrintPageEventArgs)
        Dim printFont As New Font("Courier New", 7.5, FontStyle.Bold)

        e.Graphics.DrawString(printText, printFont, Brushes.Black, 10, 10)
    End Sub
End Class
