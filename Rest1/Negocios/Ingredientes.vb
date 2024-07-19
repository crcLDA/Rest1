Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class Ingredientes
    Private objDB As DbNoSql

    Public Sub New()
        objDB = New DbNoSql("Ingredientes")
    End Sub

    Public Sub CerrarConexion()
        objDB.cerrarConexion()
    End Sub

    Public Function getNextID() As Integer
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection()
            Dim filterSort As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Empty
            Dim sortDefinition As SortDefinition(Of BsonDocument) = Builders(Of BsonDocument).Sort.Descending("id_ingrediente")
            Dim doc As BsonDocument = collection.Find(filterSort).Sort(sortDefinition).Limit(1).FirstOrDefault()

            If doc IsNot Nothing Then
                Return doc("id_ingrediente").AsInt32 + 1
            Else
                Return 1
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Agregar(ingrediente As Ingrediente)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim document As New BsonDocument()
            document.Add("id_ingrediente", getNextID())
            document.Add("nombre", ingrediente.Nombre)
            document.Add("existencias", ingrediente.Existencias)

            collection.InsertOne(document)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Modificar(ingrediente As Ingrediente)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of Integer)("id_ingrediente", ingrediente.IdIngrediente)

            Dim document As New BsonDocument()
            document.Add("id_ingrediente", ingrediente.IdIngrediente)
            document.Add("nombre", ingrediente.Nombre)
            document.Add("existencias", ingrediente.Existencias)

            collection.ReplaceOne(filter, document)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Eliminar(pId As Integer)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of Integer)("id_ingrediente", pId)

            collection.DeleteOne(filter)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function getIngrediente(pId As Integer) As Ingrediente
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of Integer)("id_ingrediente", pId)
            Dim document As BsonDocument = collection.Find(filter).FirstOrDefault()

            If document IsNot Nothing Then
                Dim ingrediente As New Ingrediente() With {
                    .IdIngrediente = document("id_ingrediente").AsInt32,
                    .Nombre = document("nombre").AsString,
                    .Existencias = document("existencias").AsDecimal
                }
                Return ingrediente
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function getIngredientes() As List(Of Ingrediente)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Empty
            Dim documents As List(Of BsonDocument) = collection.Find(filter).ToList()

            Dim ingredientes As New List(Of Ingrediente)()

            For Each doc As BsonDocument In documents
                Dim ingrediente As New Ingrediente() With {
                    .IdIngrediente = doc("id_ingrediente").AsInt32,
                    .Nombre = doc("nombre").AsString,
                    .Existencias = doc("existencias").AsDecimal
                }
                ingredientes.Add(ingrediente)
            Next

            Return ingredientes
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub cargarCBO(pCBO As ComboBox)
        Try
            pCBO.Items.Clear()

            Dim lista As List(Of Ingrediente) = getIngredientes().OrderBy(Function(ing) ing.Nombre).ToList()

            pCBO.DataSource = lista
            pCBO.DisplayMember = "Nombre"
            pCBO.ValueMember = "IdIngrediente"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cargarColumnas(pLST As ListView)
        Try
            pLST.Columns.AddRange(New ColumnHeader() {
                New ColumnHeader() With {.Text = "Id", .Width = 150},
                New ColumnHeader() With {.Text = "Nombre", .Width = 463},
                New ColumnHeader() With {.Text = "Existencias", .Width = 200}
            })
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub cargarListView(pLST As ListView)
        Try
            pLST.Clear()
            cargarColumnas(pLST)

            Dim lista As List(Of Ingrediente) = getIngredientes()

            For Each ing As Ingrediente In lista
                Dim item As New ListViewItem(ing.IdIngrediente)
                item.SubItems.Add(ing.Nombre)
                item.SubItems.Add(ing.Existencias)
                pLST.Items.Add(item)
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
