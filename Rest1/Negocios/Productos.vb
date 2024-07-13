Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class Productos
    Private objDB As DbNoSql

    Public Sub New()
        objDB = New DbNoSql("Productos")
    End Sub

    Public Sub CerrarConexion()
        objDB.cerrarConexion()
    End Sub

    Public Function getNextID() As Integer
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection()
            Dim filterSort As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Empty
            Dim sortDefinition As SortDefinition(Of BsonDocument) = Builders(Of BsonDocument).Sort.Descending("id_producto")
            Dim categoriaDoc As BsonDocument = collection.Find(filterSort).Sort(sortDefinition).Limit(1).FirstOrDefault()

            If categoriaDoc IsNot Nothing Then
                Return categoriaDoc("id_producto").AsInt32 + 1
            Else
                Return 1
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Agregar(producto As Producto)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection()
            Dim document As New BsonDocument()

            document.Add("id_producto", getNextID())
            document.Add("nombre", producto.Nombre)
            document.Add("descripcion", producto.Descripcion)
            document.Add("precio", producto.Precio)
            document.Add("id_categoria", producto.IdCategoria)
            document.Add("activo", producto.Activo)

            collection.InsertOne(document)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Modificar(producto As Producto)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("id_producto", producto.IdProducto)

            Dim document As New BsonDocument()
            document.Add("id_producto", producto.IdProducto)
            document.Add("nombre", producto.Nombre)
            document.Add("descripcion", producto.Descripcion)
            document.Add("precio", producto.Precio)
            document.Add("id_categoria", producto.IdCategoria)
            document.Add("activo", producto.Activo)

            collection.ReplaceOne(filter, document)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Sub Eliminar(pId As Integer)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("id_producto", pId)

            collection.DeleteOne(filter)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CargarListView(pLST As ListView)
        Try
            pLST.Clear()
            cargarColumnas(pLST)

            Dim listaProductos As List(Of Producto) = getProductos()

            For Each producto As Producto In listaProductos
                Dim item As New ListViewItem(producto.IdProducto.ToString())
                item.SubItems.Add(producto.Nombre)
                item.SubItems.Add(producto.Descripcion)
                item.SubItems.Add(producto.Precio.ToString("F2"))
                item.SubItems.Add(producto.IdCategoria.ToString())
                item.SubItems.Add(If(producto.Activo, "Sí", "No"))

                pLST.Items.Add(item)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Function ConsultarID(id As Integer) As Producto
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection()

            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of Integer)("id_producto", id)
            Dim productoDoc As BsonDocument = collection.Find(filter).FirstOrDefault()

            If productoDoc IsNot Nothing Then
                Dim producto As New Producto() With {
                .IdProducto = productoDoc("id_producto").AsInt32,
                .Nombre = productoDoc("nombre").AsString,
                .Descripcion = productoDoc("descripcion").AsString,
                .Precio = productoDoc("precio").ToDecimal(),
                .IdCategoria = productoDoc("id_categoria").AsInt32,
                .Activo = productoDoc("activo").AsBoolean
            }
                Return producto
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function getProductos() As List(Of Producto)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection()

            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Empty
            Dim documents As List(Of BsonDocument) = collection.Find(filter).ToList()

            Dim productos As New List(Of Producto)()

            For Each doc As BsonDocument In documents
                Dim producto As New Producto() With {
                .IdProducto = doc("id_producto").AsInt32,
                .Nombre = doc("nombre").AsString,
                .Descripcion = doc("descripcion").AsString,
                .Precio = doc("precio").ToDecimal(),
                .IdCategoria = doc("id_categoria").AsInt32,
                .Activo = doc("activo").AsBoolean
            }
                productos.Add(producto)
            Next

            Return productos
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub cargarColumnas(pLST As ListView)
        Try
            pLST.Columns.AddRange(New ColumnHeader() {
                New ColumnHeader() With {.Text = "ID", .Width = 50},
                New ColumnHeader() With {.Text = "Nombre", .Width = 250},
                New ColumnHeader() With {.Text = "Descripción", .Width = 213},
                New ColumnHeader() With {.Text = "Precio", .Width = 100},
                New ColumnHeader() With {.Text = "Categoría", .Width = 150},
                New ColumnHeader() With {.Text = "Activo", .Width = 50}
            })
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class

