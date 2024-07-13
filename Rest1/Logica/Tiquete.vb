Imports System.Text

Public Class Tiquete
    Private tamanoLinea As Integer = 42
    Private catidadEspacios As Integer = 0
    Private vTotal As String = ""
    Dim vSubtotal As String = ""

    Public Function getTiquete(productos As String()(), fecha As String, numFactura As String, nombreEnFactura As String, cedulaEnFactura As String, pDescuento As Decimal) As String
        Try
            Dim vAux As String = ""
            If pDescuento < 0 Then
                pDescuento = 0
            End If

            vSubtotal = sumarPrecios(productos)
            vTotal = formateoDecimales(CDbl(Decimal.Parse(sumarPrecios(productos) - pDescuento)))
            'calculando impuestos
            'vSubtotal = formateoDecimales(((CDbl(Decimal.Parse(vTotal)) * 100) / 113))
            'Dim vImpuesto As String = CDbl(Decimal.Parse(vTotal)) - CDbl(Decimal.Parse(subtotal))

            Dim tiquete As String = getSangria() & getEspaciado(10) & "Secretos de Miramar" & saltoDeLinea() & saltoDeLinea()
            tiquete &= getSangria() & "Factura #: " & numFactura & saltoDeLinea()
            tiquete &= getSangria() & "Fecha y hora: " & fecha & saltoDeLinea()

            If nombreEnFactura.Trim().Length > 1 Then
                tiquete &= getSangria() & "Cliente: " & nombreEnFactura & saltoDeLinea()
            End If

            If cedulaEnFactura.Trim().Length > 1 Then
                tiquete &= getSangria() & "Cédula: " & cedulaEnFactura & saltoDeLinea()
            End If

            tiquete &= getSangria() & getLineaContinua() & saltoDeLinea()
            tiquete &= getSangria() & getCabeceraProductos() & saltoDeLinea()

            tiquete &= getSangria() & formatProductos(productos) & saltoDeLinea()

            tiquete &= getSangria() & getLineaContinua() & saltoDeLinea()

            If pDescuento > 0 Then
                vAux = formateoDecimales(CDbl(Decimal.Parse(vSubtotal)))
                tiquete &= getSangria() & "Subtotal:" & getEspaciado("Subtotal:", vAux) & vAux & saltoDeLinea()
                vAux = formateoDecimales(CDbl(Decimal.Parse(pDescuento)))
                tiquete &= getSangria() & "Descuento:" & getEspaciado("Descuento:", vAux) & vAux & saltoDeLinea()
            End If

            tiquete &= getSangria() & "TOTAL EN COLONES:" & getEspaciado("TOTAL EN COLONES:", vTotal) & vTotal & saltoDeLinea()
            tiquete &= getSangria() & getDobleLineaContinua() & saltoDeLinea()

            tiquete &= getSangria() & getEspaciado(9) & "Gracias por preferirnos!" & saltoDeLinea()

            Try
                Dim obj As New Impresion
                'obj.Imprimir(tiquete)
                MsgBox.Info(tiquete)
            Catch ex As Exception
                Throw New Exception("Error al imprimir")
            End Try

            Return tiquete
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function getSangria() As String
        Dim cantidad As Integer = catidadEspacios
        If cantidad > 0 Then
            Dim espacios As New StringBuilder()
            For i As Integer = 0 To cantidad - 1
                espacios.Append(" ")
            Next
            Return espacios.ToString()
        End If
        Return ""
    End Function

    Private Function getEspaciado(cantidad As Integer) As String
        Dim espacios As New StringBuilder()
        For i As Integer = 0 To cantidad - 1
            espacios.Append(" ")
        Next
        Return espacios.ToString()
    End Function

    Private Function getEspaciado(pInicio As String, pFinal As String) As String
        Dim cantidad As Integer = tamanoLinea - (pInicio.Length + pFinal.Length)

        Dim espacios As New StringBuilder()
        For i As Integer = 0 To cantidad - 1
            espacios.Append(" ")
        Next
        Return espacios.ToString()
    End Function

    Private Function saltoDeLinea() As String
        Return vbCrLf
    End Function

    Private Function getLineaContinua() As String
        Dim espacios As New StringBuilder()
        For i As Integer = 0 To tamanoLinea - 1
            espacios.Append("-")
        Next
        Return espacios.ToString()
    End Function

    Private Function getDobleLineaContinua() As String
        Dim espacios As New StringBuilder()
        For i As Integer = 0 To tamanoLinea - 1
            espacios.Append("=")
        Next
        Return espacios.ToString()
    End Function

    Private Function getCabeceraProductos() As String
        Return "  Producto(s)" & getEspaciado(tamanoLinea - 21) & "Precio"
    End Function

    Private Function formatProductos(array As String()()) As String
        Try
            Dim vText As String = ""
            Dim precio, nombre As String
            For Each fila As String() In array
                If Not String.IsNullOrEmpty(fila(0)) Then
                    nombre = fila(0)
                    precio = fila(1)
                    If nombre.Length > (tamanoLinea - (precio.Length + 1)) Then
                        nombre = nombre.Substring(0, tamanoLinea - (precio.Length + 10)) + "..."
                    End If
                    vText += nombre + getEspaciado(nombre, precio) + precio + saltoDeLinea() + getSangria()
                End If
            Next

            Return vText.Trim()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function sumarPrecios(array As String()()) As String
        Try
            Dim total As Double = 0.0

            For Each fila As String() In array
                If fila.Length >= 2 Then
                    Dim precio As Double = CDbl(Decimal.Parse(fila(1)))
                    total += precio
                End If
            Next

            Console.WriteLine(total)
            Return formateoDecimales(total)
        Catch ex As Exception
            Throw New Exception("No se pudo convertir el precio en imprimir factura.")
        End Try
    End Function

    Private Function formateoDecimales(numero As Double) As String
        Try
            Return String.Format("{0:0.00}", numero)
        Catch ex As Exception
            Throw New Exception("Error formateando número en dos decimales.")
        End Try
    End Function
End Class
