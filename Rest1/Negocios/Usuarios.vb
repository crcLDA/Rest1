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

    Public Sub Agregar(usuario As Usuario)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim document As New BsonDocument()
            document.Add("usuario", usuario.Usuario)
            document.Add("contrasena", usuario.Contrasena)
            document.Add("rol", usuario.Rol)

            collection.InsertOne(document)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Modificar(usuario As Usuario)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("usuario", usuario.Usuario)

            Dim document As New BsonDocument()
            document.Add("usuario", usuario.Usuario)
            document.Add("contrasena", usuario.Contrasena)
            document.Add("rol", usuario.Rol)

            collection.ReplaceOne(filter, document)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Eliminar(pUsuario As String)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("usuario", pUsuario)

            collection.DeleteOne(filter)
        Catch ex As Exception
            Throw ex
        End Try
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

    Public Function getUsuarios() As List(Of Usuario)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Empty
            Dim documents As List(Of BsonDocument) = collection.Find(filter).ToList()

            Dim usuarios As New List(Of Usuario)()

            For Each doc As BsonDocument In documents
                Dim usuario As New Usuario() With {
                    .Usuario = doc("usuario").AsString,
                    .Contrasena = doc("contrasena").AsString,
                    .Rol = doc("rol").AsString
                }
                usuarios.Add(usuario)
            Next

            Return usuarios
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub cargarListView(pLST As ListView)
        Try
            pLST.Clear()
            cargarColumnas(pLST)

            Dim lista As List(Of Usuario) = getUsuarios()

            For Each usuario As Usuario In lista
                Dim item As New ListViewItem(usuario.Usuario)
                item.SubItems.Add(usuario.Contrasena)
                item.SubItems.Add(usuario.Rol)
                pLST.Items.Add(item)
            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Private Sub cargarColumnas(pLST As ListView)
        Try
            pLST.Columns.AddRange(New ColumnHeader() {
                New ColumnHeader() With {.Text = "Usuario", .Width = 150},
                New ColumnHeader() With {.Text = "Contraseña", .Width = 463},
                New ColumnHeader() With {.Text = "Rol", .Width = 200}
            })
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
