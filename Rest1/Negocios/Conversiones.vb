Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class Conversiones
    Private objDB As DbNoSql

    Public Sub New()
        objDB = New DbNoSql("Conversion")
    End Sub

    Public Sub CerrarConexion()
        objDB.cerrarConexion()
    End Sub

    Public Sub Agregar(conversion As Conversion)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim document As New BsonDocument()
            document.Add("id_producto", conversion.IdProducto)
            document.Add("id_ingrediente", conversion.IdIngrediente)
            document.Add("conversion", conversion.Conversion)

            collection.InsertOne(document)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Modificar(conversion As Conversion)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.And(
                Builders(Of BsonDocument).Filter.Eq(Of Integer)("id_ingrediente", conversion.IdIngrediente),
                Builders(Of BsonDocument).Filter.Eq(Of Integer)("id_producto", conversion.IdProducto)
            )


            Dim document As New BsonDocument()
            document.Add("id_ingrediente", conversion.IdIngrediente)
            document.Add("id_producto", conversion.IdProducto)
            document.Add("conversion", conversion.Conversion)

            collection.ReplaceOne(filter, document)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Eliminar(conversion As Conversion)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.And(
                Builders(Of BsonDocument).Filter.Eq(Of Integer)("id_ingrediente", conversion.IdIngrediente),
                Builders(Of BsonDocument).Filter.Eq(Of Integer)("id_producto", conversion.IdProducto)
            )

            collection.DeleteOne(filter)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function getConversion(conversion As Conversion) As Conversion
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.And(
                Builders(Of BsonDocument).Filter.Eq(Of Integer)("id_ingrediente", conversion.IdIngrediente),
                Builders(Of BsonDocument).Filter.Eq(Of Integer)("id_producto", conversion.IdProducto)
            )
            Dim document As BsonDocument = collection.Find(filter).FirstOrDefault()

            If document IsNot Nothing Then
                Dim newConversion As New Conversion() With {
                    .IdProducto = document("id_producto").AsInt32,
                    .IdIngrediente = document("id_ingrediente").AsInt32,
                    .Conversion = document("conversion").AsDecimal
                }
                Return newConversion
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function getConversiones() As List(Of Conversion)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Empty
            Dim documents As List(Of BsonDocument) = collection.Find(filter).ToList()

            Dim ingredientes As New List(Of Conversion)()

            For Each doc As BsonDocument In documents
                Dim ingrediente As New Conversion() With {
                    .IdIngrediente = doc("id_ingrediente").AsInt32,
                    .IdProducto = doc("id_producto").AsInt32,
                    .Conversion = doc("conversion").AsDecimal
                }
                ingredientes.Add(ingrediente)
            Next

            Return ingredientes
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function existe(conversion As Conversion) As Boolean
        Try
            If getConversion(conversion) Is Nothing Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function cargarLstConversiones(productoId As Integer) As List(Of Conversion)
        Try
            Dim vLista As New List(Of Conversion)()
            Dim conversionCollection As IMongoCollection(Of BsonDocument) = objDB.GetCollection()
            Dim productosCollection As IMongoCollection(Of BsonDocument) = objDB.GetCollection("Productos")

            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of Integer)("id_producto", productoId)
            Dim documents As List(Of BsonDocument) = conversionCollection.Find(filter).ToList()

            For Each doc As BsonDocument In documents
                Dim conv As New Conversion(
                    doc("id_producto").AsInt32,
                    doc("id_ingrediente").AsInt32,
                    doc("conversion").AsDecimal
                )
                vLista.Add(conv)
            Next

            Return vLista
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
