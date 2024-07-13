Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class Clientes
    Private objDB As DbNoSql

    Public Sub New()
        objDB = New DbNoSql("Clientes")
    End Sub

    Public Sub CerrarConexion()
        objDB.cerrarConexion()
    End Sub

    Public Sub Agregar(cliente As Cliente)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim document As New BsonDocument()
            document.Add("cedula", cliente.Cedula)
            document.Add("nombre", cliente.Nombre)
            document.Add("telefono", cliente.Telefono)

            collection.InsertOne(document)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Modificar(cliente As Cliente)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("cedula", cliente.Cedula)

            Dim document As New BsonDocument()
            document.Add("cedula", cliente.Cedula)
            document.Add("nombre", cliente.Nombre)
            document.Add("telefono", cliente.Telefono)

            collection.ReplaceOne(filter, document)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Eliminar(pCedula As String)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("cedula", pCedula)

            collection.DeleteOne(filter)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function getCliente(pCedula As String) As Cliente
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("cedula", pCedula)
            Dim document As BsonDocument = collection.Find(filter).FirstOrDefault()

            If document IsNot Nothing Then
                Dim cliente As New Cliente() With {
                    .Cedula = document("cedula").AsString,
                    .Nombre = document("nombre").AsString,
                    .Telefono = document("telefono").AsString
                }
                Return cliente
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function getClientes() As List(Of Cliente)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Empty
            Dim documents As List(Of BsonDocument) = collection.Find(filter).ToList()

            Dim clientes As New List(Of Cliente)()

            For Each doc As BsonDocument In documents
                Dim cliente As New Cliente() With {
                    .Cedula = doc("cedula").AsString,
                    .Nombre = doc("nombre").AsString,
                    .Telefono = doc("telefono").AsString
                }
                clientes.Add(cliente)
            Next

            Return clientes
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub cargarListView(pLST As ListView)
        Try
            pLST.Clear()
            cargarColumnas(pLST)

            Dim lista As List(Of Cliente) = getClientes()

            For Each cliente As Cliente In lista
                Dim item As New ListViewItem(cliente.Cedula)
                item.SubItems.Add(cliente.Nombre)
                item.SubItems.Add(cliente.Telefono)
                pLST.Items.Add(item)
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub cargarListViewSeleccionar(pLST As ListView)
        Try
            pLST.Clear()
            pLST.Columns.AddRange(New ColumnHeader() {
                New ColumnHeader() With {.Text = "Cédula", .Width = 68},
                New ColumnHeader() With {.Text = "Nombre", .Width = 200}
            })

            Dim lista As List(Of Cliente) = getClientes()

            For Each cliente As Cliente In lista
                Dim item As New ListViewItem(cliente.Cedula)
                item.SubItems.Add(cliente.Nombre)
                pLST.Items.Add(item)
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cargarColumnas(pLST As ListView)
        Try
            pLST.Columns.AddRange(New ColumnHeader() {
                New ColumnHeader() With {.Text = "Cédula", .Width = 150},
                New ColumnHeader() With {.Text = "Nombre", .Width = 463},
                New ColumnHeader() With {.Text = "Teléfono", .Width = 200}
            })
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function existe(pId As String) As Boolean
        Try
            If getCliente(pId) Is Nothing Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
