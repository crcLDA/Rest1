Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class ProductoOrdenes
    Private objDB As DbNoSql

    Public Sub New()
        objDB = New DbNoSql("Detalles")
    End Sub

    Public Sub CerrarConexion()
        objDB.cerrarConexion()
    End Sub

    Public Function getNextOrdenID() As Integer
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection("Ordenes")
            Dim filterSort As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Empty
            Dim sortDefinition As SortDefinition(Of BsonDocument) = Builders(Of BsonDocument).Sort.Descending("id_orden")
            Dim categoriaDoc As BsonDocument = collection.Find(filterSort).Sort(sortDefinition).Limit(1).FirstOrDefault()

            If categoriaDoc IsNot Nothing Then
                Return categoriaDoc("id_orden").AsInt32 + 1
            Else
                Return 1
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function getNextFacturaID() As Integer
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection("Facturas")
            Dim filterSort As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Empty
            Dim sortDefinition As SortDefinition(Of BsonDocument) = Builders(Of BsonDocument).Sort.Descending("id_factura")
            Dim categoriaDoc As BsonDocument = collection.Find(filterSort).Sort(sortDefinition).Limit(1).FirstOrDefault()

            If categoriaDoc IsNot Nothing Then
                Return categoriaDoc("id_factura").AsInt32 + 1
            Else
                Return 1
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function getNextDetalleID() As Integer
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection("Detalles")
            Dim filterSort As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Empty
            Dim sortDefinition As SortDefinition(Of BsonDocument) = Builders(Of BsonDocument).Sort.Descending("id_detalle")
            Dim categoriaDoc As BsonDocument = collection.Find(filterSort).Sort(sortDefinition).Limit(1).FirstOrDefault()

            If categoriaDoc IsNot Nothing Then
                Return categoriaDoc("id_detalle").AsInt32 + 1
            Else
                Return 1
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function cargarLstProductos() As List(Of Producto)
        Try
            Dim vLista As New List(Of Producto)()
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection("Productos")
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of Boolean)("activo", True)
            Dim documents As List(Of BsonDocument) = collection.Find(filter).ToList()

            For Each doc As BsonDocument In documents
                Dim producto As New Producto(
                    doc("id_producto").AsInt32,
                    doc("nombre").AsString,
                    doc("descripcion").AsString,
                    doc("precio").AsDecimal,
                    doc("id_categoria").AsInt32,
                    doc("activo").AsBoolean
                )
                vLista.Add(producto)
            Next

            Return vLista
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function agregarOrden(pOrden As Orden)
        Try
            Dim vId As Integer = getNextOrdenID()
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection("Ordenes")
            Dim document As New BsonDocument()
            document.Add("id_orden", vId)
            document.Add("cedula", pOrden.Usuario)
            document.Add("fecha", pOrden.Fecha)

            collection.InsertOne(document)
            Return vId
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub agregarDetalles(pDetalles As List(Of DetalleOrden))
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection()
            Dim documents As New List(Of BsonDocument)()
            Dim vNumDetalle As Integer = getNextDetalleID()

            rebajarProducto(pDetalles)

            For Each detalle As DetalleOrden In pDetalles
                Dim document As New BsonDocument()
                document.Add("id_detalle", vNumDetalle)
                document.Add("id_orden", detalle.idOrden)
                document.Add("id_factura", detalle.idFactura)
                document.Add("id_producto", detalle.idProducto)
                document.Add("subtotal", detalle.subtotal)
                document.Add("cancelado", detalle.cancelado)

                documents.Add(document)
                vNumDetalle += 1
            Next

            collection.InsertMany(documents)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function agregarFactura(pFactura As Factura)
        Try
            Dim vId As Integer
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection("Facturas")
            Dim document As New BsonDocument()
            vId = getNextFacturaID()
            document.Add("id_factura", vId)
            document.Add("id_orden", pFactura.idOrden)
            document.Add("cedula", pFactura.cedula)
            document.Add("id_vendedor", pFactura.idVendedor)
            document.Add("fecha", pFactura.fecha)
            document.Add("total", pFactura.Total)
            document.Add("descuento", pFactura.descuento)

            collection.InsertOne(document)

            Return vId
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetProductosByFactura(pFiltro As Long) As String()()
        Try
            Dim detallesCollection As IMongoCollection(Of BsonDocument) = objDB.GetCollection()
            Dim productosCollection As IMongoCollection(Of BsonDocument) = objDB.GetCollection("Productos")

            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of Long)("id_factura", pFiltro)
            Dim detalles As List(Of BsonDocument) = detallesCollection.Find(filter).ToList()

            Dim listaResultados As New List(Of String())

            ' buscar sobre los detalles
            For Each detalle As BsonDocument In detalles
                Dim idProducto As Integer = detalle("id_producto").AsInt32
                Dim productoFilter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of Integer)("id_producto", idProducto)
                Dim producto As BsonDocument = productosCollection.Find(productoFilter).FirstOrDefault()

                If producto IsNot Nothing Then
                    Dim fila As String() = New String(1) {}
                    fila(0) = producto("nombre").AsString
                    fila(1) = CInt(producto("precio").AsDecimal128).ToString()
                    listaResultados.Add(fila)
                End If
            Next

            Dim mat As String()() = listaResultados.ToArray()

            Return mat
        Catch ex As Exception
            Throw New Exception("Error al obtener productos por factura", ex)
        End Try
    End Function

    Public Sub GetProductosByOrden(pFiltro As Long, pLST As ListView)
        Try
            pLST.Items.Clear()

            Dim detallesCollection As IMongoCollection(Of BsonDocument) = objDB.GetCollection("Detalles")
            Dim productosCollection As IMongoCollection(Of BsonDocument) = objDB.GetCollection("Productos")

            ' Filtro para obtener los detalles de la orden especificada
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of Long)("id_orden", pFiltro)
            Dim detalles As List(Of BsonDocument) = detallesCollection.Find(filter).ToList()

            ' Iterar sobre los detalles para obtener los productos relacionados
            For Each detalle As BsonDocument In detalles
                If Not detalle("cancelado").AsBoolean Then
                    Dim idProducto As Integer = detalle("id_producto").AsInt32
                    Dim productoFilter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of Integer)("id_producto", idProducto)
                    Dim producto As BsonDocument = productosCollection.Find(productoFilter).FirstOrDefault()

                    If producto IsNot Nothing Then
                        Dim item As New ListViewItem(detalle("id_detalle").AsInt32.ToString)
                        item.SubItems.Add(producto("nombre").AsString)
                        item.SubItems.Add(detalle("subtotal").AsDecimal.ToString())

                        pLST.Items.Add(item)
                    End If
                End If
            Next
        Catch ex As Exception
            Throw New Exception("Error al obtener productos por orden", ex)
        End Try
    End Sub

    Public Sub pagarDetalles(vFactura As Long, vDetalles As List(Of Integer))
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection("Detalles")

            For Each idDetalle As Integer In vDetalles
                Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of Integer)("id_detalle", idDetalle)

                Dim updateDoc As New BsonDocument("$set", New BsonDocument("id_factura", vFactura).Add("cancelado", True))

                Dim updateOpts As New UpdateOptions()
                updateOpts.IsUpsert = False

                collection.UpdateOne(filter, updateDoc, updateOpts)
            Next

        Catch ex As Exception
            Throw New Exception("Error al pagar detalles de órdenes", ex)
        End Try
    End Sub

    Public Function validaDisponibilidad(idProductos As List(Of Integer)) As Boolean
        Try
            Dim objConversiones As New Conversiones
            Dim objIngredientes As New Ingredientes
            Dim objProductos As New Productos
            Dim vListaConversiones As New List(Of Conversion)
            Dim vListaIngredientes As New List(Of Ingrediente)
            Dim vListaProductos As New List(Of Producto)
            vListaIngredientes = objIngredientes.getIngredientes
            vListaConversiones = objConversiones.getConversiones()
            vListaProductos = objProductos.getProductos()

            For Each id In idProductos
                buscaIngredientes(id, getNombreProducto(id, vListaProductos), vListaConversiones, vListaIngredientes)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function getNombreProducto(idProducto As Integer, listadoProductos As List(Of Producto)) As String
        Try
            For Each producto In listadoProductos
                If producto.IdProducto = idProducto Then
                    Return producto.Nombre
                End If
            Next
            Return ""
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub buscaIngredientes(pId As Integer, pNombre As String, listadoConversion As List(Of Conversion), listadoIngrediente As List(Of Ingrediente))
        Try
            Dim vExistencias As Decimal = 0

            For Each conversion In listadoConversion
                If conversion.IdProducto = pId Then
                    vExistencias = getExistenciasIngrediente(conversion.IdIngrediente, listadoIngrediente)
                    If (vExistencias - conversion.Conversion) < 0 Then
                        Throw New Exception("Las existencias son negativas, no se puede facturar: " + pNombre)
                    End If
                End If
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function getExistenciasIngrediente(idIngrediente As Integer, listadoIngrediente As List(Of Ingrediente)) As Decimal
        Try
            For Each ingrediente In listadoIngrediente
                If ingrediente.IdIngrediente = idIngrediente Then
                    Return ingrediente.Existencias
                End If
            Next
            Throw New Exception("No se encontraron existencias para el ingrediente id: " + idIngrediente)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub rebajarProducto(ByVal listaDetalles As List(Of DetalleOrden))
        Try
            Dim objConversiones As New Conversiones
            Dim objIngredientes As New Ingredientes
            Dim vListaConversiones As New List(Of Conversion)
            Dim vListaIngredientes As New List(Of Ingrediente)
            vListaIngredientes = objIngredientes.getIngredientes
            vListaConversiones = objConversiones.getConversiones()


            For Each detalle As DetalleOrden In listaDetalles
                buscaIngredienteEnLista(detalle.idProducto, vListaConversiones, vListaIngredientes)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub buscaIngredienteEnLista(pId As Integer, listadoConversion As List(Of Conversion), listadoIngrediente As List(Of Ingrediente))
        Try
            For Each conversion In listadoConversion
                If conversion.IdProducto = pId Then
                    rebajarIngrediente(conversion.IdIngrediente, conversion.Conversion, listadoIngrediente)

                End If
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub rebajarIngrediente(pId As Integer, pRebajo As Decimal, listadoIngrediente As List(Of Ingrediente))
        Try
            Dim vExistencias As Decimal = 0
            Dim obj As New Ingredientes

            For Each ingrediente In listadoIngrediente
                If ingrediente.IdIngrediente = pId Then
                    ingrediente.Existencias = ingrediente.Existencias - pRebajo
                    obj.Modificar(ingrediente)
                End If
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
