Imports System.Windows.Forms.VisualStyles
Imports java.rmi.server
Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class Usuarios
    Private objDB As DbNoSql

    Public Sub New()
        objDB = New DbNoSql("Usuarios")
    End Sub

    Public Sub CerrarConexion()
        objDB.cerrarConexion()
    End Sub

    Public Function validateLogin(pUser As String, pPass As String) As Boolean
        Try
            If getUsuario(pUser, pPass) IsNot Nothing Then
                Return True
            End If
            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function getUsuario(pId As String) As Usuario
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("usuario", pId)
            Dim document As BsonDocument = collection.Find(filter).FirstOrDefault()

            If document IsNot Nothing Then
                Dim usuario As New Usuario() With {
                    .Usuario = document("usuario").AsString,
                    .Contrasena = document("contrasena").AsString,
                    .Rol = document("rol").AsString
                }
                Return usuario
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function getUsuario(pId As String, pPassword As String) As Usuario
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection()
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.And(
            Builders(Of BsonDocument).Filter.Eq(Of String)("usuario", pId),
            Builders(Of BsonDocument).Filter.Eq(Of String)("contrasena", pPassword)
        )
            Dim document As BsonDocument = collection.Find(filter).FirstOrDefault()

            If document IsNot Nothing Then
                Dim usuario As New Usuario() With {
                .Usuario = document("usuario").AsString,
                .Contrasena = document("contrasena").AsString,
                .Rol = document("rol").AsString
            }
                Return usuario
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
