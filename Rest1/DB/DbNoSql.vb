Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class DbNoSql
    Dim connectionString As String = "mongodb+srv://proyeAdmin:1234@cluster0.munmhkd.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0"
    Dim client As New MongoClient(connectionString)
    Dim database As IMongoDatabase = client.GetDatabase("Proyecto")
    Dim Collection As IMongoCollection(Of BsonDocument)

    Public Sub New(coleccion As String)
        Try
            Collection = database.GetCollection(Of BsonDocument)(coleccion)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function GetCollection() As IMongoCollection(Of BsonDocument)
        Try
            Return Collection
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetCollection(coleccion As String) As IMongoCollection(Of BsonDocument)
        Try
            Return database.GetCollection(Of BsonDocument)(coleccion)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub cerrarConexion()
        Try
            If client IsNot Nothing Then
                client = Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
