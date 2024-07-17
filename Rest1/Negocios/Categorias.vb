Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class Categorias
    Private objDB As DbNoSql

    Public Sub New()
        objDB = New DbNoSql("Categorias")
    End Sub

    Public Sub CerrarConexion()
        objDB.cerrarConexion()
    End Sub

    Public Function getNextID() As Integer
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection()
            Dim filterSort As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Empty
            Dim sortDefinition As SortDefinition(Of BsonDocument) = Builders(Of BsonDocument).Sort.Descending("id_categoria")
            Dim categoriaDoc As BsonDocument = collection.Find(filterSort).Sort(sortDefinition).Limit(1).FirstOrDefault()

            If categoriaDoc IsNot Nothing Then
                Return categoriaDoc("id_categoria").AsInt32 + 1
            Else
                Return 1
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Agregar(categoria As Categoria)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim document As New BsonDocument()
            document.Add("id_categoria", getNextID())
            document.Add("nombre", categoria.Descripcion)

            collection.InsertOne(document)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Modificar(categoria As Categoria)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of Integer)("id_categoria", categoria.IdCategoria)

            Dim document As New BsonDocument()
            document.Add("id_categoria", categoria.IdCategoria)
            document.Add("nombre", categoria.Descripcion)

            collection.ReplaceOne(filter, document)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Eliminar(pId As Integer)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of Integer)("id_categoria", pId)

            collection.DeleteOne(filter)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function getCategoria(pId As Integer) As Categoria
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of Integer)("id_categoria", pId)
            Dim document As BsonDocument = collection.Find(filter).FirstOrDefault()

            If document IsNot Nothing Then
                Dim categoria As New Categoria() With {
                    .IdCategoria = document("id_categoria").AsInt32,
                    .Descripcion = document("nombre").AsString
                }
                Return categoria
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function getCategorias() As List(Of Categoria)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Empty
            Dim documents As List(Of BsonDocument) = collection.Find(filter).ToList()

            Dim categorias As New List(Of Categoria)()

            For Each doc As BsonDocument In documents
                Dim categoria As New Categoria() With {
                    .IdCategoria = doc("id_categoria").AsInt32,
                    .Descripcion = doc("nombre").AsString
                }
                categorias.Add(categoria)
            Next

            Return categorias
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub cargarCBO(pCBO As ComboBox)
        Try
            pCBO.Items.Clear()

            Dim listaCategorias As List(Of Categoria) = getCategorias()

            pCBO.DataSource = listaCategorias
            pCBO.DisplayMember = "Descripcion"
            pCBO.ValueMember = "IdCategoria"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub cargarListView(pLST As ListView)
        Try
            pLST.Clear()
            cargarColumnas(pLST)

            Dim lista As List(Of Categoria) = getCategorias()

            For Each categoria As Categoria In lista
                Dim item As New ListViewItem(categoria.IdCategoria)
                item.SubItems.Add(categoria.Descripcion)
                pLST.Items.Add(item)
            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub cargarColumnas(pLST As ListView)
        Try
            pLST.Columns.AddRange(New ColumnHeader() {
                New ColumnHeader() With {.Text = "Id", .Width = 150},
                New ColumnHeader() With {.Text = "Nombre", .Width = 663}
            })
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
