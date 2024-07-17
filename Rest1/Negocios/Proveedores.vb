Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class Proveedores
    Private objDB As DbNoSql

    Public Sub New()
        objDB = New DbNoSql("Proveedores")
    End Sub

    Public Sub CerrarConexion()
        objDB.cerrarConexion()
    End Sub

    Public Function getNextID() As Integer
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection()
            Dim filterSort As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Empty
            Dim sortDefinition As SortDefinition(Of BsonDocument) = Builders(Of BsonDocument).Sort.Descending("id_proveedor")
            Dim proveedorDoc As BsonDocument = collection.Find(filterSort).Sort(sortDefinition).Limit(1).FirstOrDefault()

            If proveedorDoc IsNot Nothing Then
                Return proveedorDoc("id_proveedor").AsInt32 + 1
            Else
                Return 1
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Agregar(proveedor As Proveedor)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim document As New BsonDocument()
            document.Add("id_proveedor", getNextID())
            document.Add("nombre", proveedor.Nombre)
            document.Add("telefono", proveedor.Telefono)
            document.Add("direccion", proveedor.Direccion)

            collection.InsertOne(document)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Modificar(proveedor As Proveedor)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of Integer)("id_proveedor", proveedor.IdProveedor)

            Dim document As New BsonDocument()
            document.Add("id_proveedor", proveedor.IdProveedor)
            document.Add("nombre", proveedor.Nombre)
            document.Add("telefono", proveedor.Telefono)
            document.Add("direccion", proveedor.Direccion)

            collection.ReplaceOne(filter, document)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Eliminar(pId As Integer)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of Integer)("id_proveedor", pId)

            collection.DeleteOne(filter)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function getProveedor(pId As Integer) As Proveedor
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of Integer)("id_proveedor", pId)
            Dim document As BsonDocument = collection.Find(filter).FirstOrDefault()

            If document IsNot Nothing Then
                Dim proveedor As New Proveedor() With {
                    .IdProveedor = document("id_proveedor").AsInt32,
                    .Nombre = document("nombre").AsString,
                    .Telefono = document("telefono").AsString,
                    .Direccion = document("direccion").AsString
                }
                Return proveedor
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function getProveedores() As List(Of Proveedor)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Empty
            Dim documents As List(Of BsonDocument) = collection.Find(filter).ToList()

            Dim proveedores As New List(Of Proveedor)()

            For Each doc As BsonDocument In documents
                Dim proveedor As New Proveedor() With {
                    .IdProveedor = doc("id_proveedor").AsInt32,
                    .Nombre = doc("nombre").AsString,
                    .Telefono = doc("telefono").AsString,
                    .Direccion = doc("direccion").AsString
                }
                proveedores.Add(proveedor)
            Next

            Return proveedores
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub cargarListView(pLST As ListView)
        Try
            pLST.Clear()
            cargarColumnas(pLST)

            Dim lista As List(Of Proveedor) = getProveedores()

            For Each proveedor As Proveedor In lista
                Dim item As New ListViewItem(proveedor.IdProveedor)
                item.SubItems.Add(proveedor.Nombre)
                item.SubItems.Add(proveedor.Telefono)
                item.SubItems.Add(proveedor.Direccion)
                pLST.Items.Add(item)
            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Private Sub cargarColumnas(pLST As ListView)
        Try
            pLST.Columns.AddRange(New ColumnHeader() {
                New ColumnHeader() With {.Text = "Id", .Width = 50},
                New ColumnHeader() With {.Text = "Nombre", .Width = 263},
                New ColumnHeader() With {.Text = "Teléfono", .Width = 100},
                New ColumnHeader() With {.Text = "Dirección", .Width = 400}
            })
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
