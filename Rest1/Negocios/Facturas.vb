Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class Facturas
    Private objDB As DbNoSql

    Public Sub New()
        objDB = New DbNoSql("Facturas")
    End Sub

    Public Sub CerrarConexion()
        objDB.cerrarConexion()
    End Sub

    Public Function getFactura(pIdFactura As Long) As Factura
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of Long)("id_factura", pIdFactura)
            Dim document As BsonDocument = collection.Find(filter).FirstOrDefault()

            If document IsNot Nothing Then
                Dim factura As New Factura() With {
                .idFactura = document("id_factura").AsInt32,
                .idOrden = document("id_orden").AsInt64,
                .idVendedor = document("id_vendedor").AsString,
                .fecha = document("fecha").AsString,
                .descuento = document("descuento").AsDecimal,
                .Total = document("total").AsDecimal
            }
                Return factura
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub getHistorial(pLST As ListView)
        Try

            pLST.Items.Clear()
            cargarColumnas(pLST)

            Dim facturasCollection As IMongoCollection(Of BsonDocument) = objDB.GetCollection("Facturas")
            Dim clientesCollection As IMongoCollection(Of BsonDocument) = objDB.GetCollection("Clientes")

            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Empty
            Dim sortDefinition As SortDefinition(Of BsonDocument) = Builders(Of BsonDocument).Sort.Descending("id_factura")
            Dim facturasDocs As List(Of BsonDocument) = facturasCollection.Find(filter).Sort(sortDefinition).Limit(25).ToList()
            Dim clientesDocs As List(Of BsonDocument) = clientesCollection.Find(Builders(Of BsonDocument).Filter.Empty).ToList()

            Dim clientesMap As New Dictionary(Of String, BsonDocument)()
            For Each clienteDoc As BsonDocument In clientesDocs
                Dim cedulaCliente As String = clienteDoc("cedula").AsString
                If Not clientesMap.ContainsKey(cedulaCliente) Then
                    clientesMap.Add(cedulaCliente, clienteDoc)
                End If
            Next

            For Each facturaDoc As BsonDocument In facturasDocs
                Dim idFactura As Long = facturaDoc("id_factura").AsInt32
                Dim fecha As String = facturaDoc("fecha").AsString
                Dim cedulaCliente As String = facturaDoc("cedula").AsString

                Dim clienteDoc As BsonDocument = Nothing
                If clientesMap.ContainsKey(cedulaCliente) Then
                    clienteDoc = clientesMap(cedulaCliente)
                End If

                Dim nombreCliente As String = If(clienteDoc IsNot Nothing, clienteDoc("nombre").AsString, "")

                Dim item As New ListViewItem(idFactura.ToString())
                item.SubItems.Add(cedulaCliente)
                item.SubItems.Add(nombreCliente)
                item.SubItems.Add(fecha)

                pLST.Items.Add(item)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cargarColumnas(pLST As ListView)
        Try
            pLST.Columns.AddRange(New ColumnHeader() {
                New ColumnHeader() With {.Text = "ID", .Width = 20},
                New ColumnHeader() With {.Text = "Cédula", .Width = 164},
                New ColumnHeader() With {.Text = "Nombre", .Width = 170},
                New ColumnHeader() With {.Text = "Fecha", .Width = 115}
            })
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
