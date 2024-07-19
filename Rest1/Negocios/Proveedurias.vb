Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class Proveedurias
    Private objDB As DbNoSql

    Public Sub New()
        objDB = New DbNoSql("Proveeduria")
    End Sub

    Public Sub CerrarConexion()
        objDB.cerrarConexion()
    End Sub

    Public Sub Agregar(proveeduria As Proveeduria)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim document As New BsonDocument()
            document.Add("id_ingrediente", proveeduria.IdIngrediente)
            document.Add("id_proveedor", proveeduria.IdProveedor)

            collection.InsertOne(document)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Eliminar(proveeduria As Proveeduria)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.And(
                Builders(Of BsonDocument).Filter.Eq(Of Integer)("id_ingrediente", proveeduria.IdIngrediente),
                Builders(Of BsonDocument).Filter.Eq(Of Integer)("id_proveedor", proveeduria.IdProveedor)
            )

            collection.DeleteOne(filter)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function getProveeduria(proveeduria As Proveeduria) As Proveeduria
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.And(
                Builders(Of BsonDocument).Filter.Eq(Of Integer)("id_ingrediente", proveeduria.IdIngrediente),
                Builders(Of BsonDocument).Filter.Eq(Of Integer)("id_proveedor", proveeduria.IdProveedor)
            )
            Dim document As BsonDocument = collection.Find(filter).FirstOrDefault()

            If document IsNot Nothing Then
                Dim newProveeduria As New Proveeduria() With {
                    .IdIngrediente = document("id_ingrediente").AsInt32,
                    .IdProveedor = document("id_proveedor").AsInt32
                }
                Return newProveeduria
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function getProveedurias() As List(Of Proveeduria)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Empty
            Dim documents As List(Of BsonDocument) = collection.Find(filter).ToList()

            Dim ingredientes As New List(Of Proveeduria)()

            For Each doc As BsonDocument In documents
                Dim ingrediente As New Proveeduria() With {
                    .IdIngrediente = doc("id_ingrediente").AsInt32,
                    .IdProveedor = doc("id_proveedor").AsInt32
                }
                ingredientes.Add(ingrediente)
            Next

            Return ingredientes
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function existe(proveeduria As Proveeduria) As Boolean
        Try
            If getProveeduria(proveeduria) Is Nothing Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub cargarLstProveeduriaByIngrediente(pId As Integer, pLST As ListView)
        Try
            cargarLst(pId, "id_ingrediente", pLST)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub cargarLstProveeduriaByProveedor(pId As Integer, pLST As ListView)
        Try
            cargarLst(pId, "id_proveedor", pLST)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cargarLst(pId As Integer, pFiltro As String, pLST As ListView)
        Try
            pLST.Items.Clear()
            cargarColumnas(pLST)

            Dim objIngredientes As New Ingredientes
            Dim objProveedores As New Proveedores

            Dim proveeduriaCollection As IMongoCollection(Of BsonDocument) = objDB.GetCollection()
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of Integer)(pFiltro, pId)

            Dim listaProveeduria As List(Of BsonDocument) = proveeduriaCollection.Find(filter).ToList()
            Dim listaIngredientes As List(Of Ingrediente) = objIngredientes.getIngredientes
            Dim listaProveedores As List(Of Proveedor) = objProveedores.getProveedores


            For Each detalle As BsonDocument In listaProveeduria
                Dim item As New ListViewItem(detalle("id_ingrediente").AsInt32.ToString)
                item.SubItems.Add(detalle("id_proveedor").AsInt32)
                item.SubItems.Add(getNombreIngrediente(detalle("id_ingrediente").AsInt32, listaIngredientes))
                item.SubItems.Add(getNombreProveedor(detalle("id_proveedor").AsInt32, listaProveedores))

                pLST.Items.Add(item)

            Next
        Catch ex As Exception
            Throw New Exception("Error al obtener productos por orden", ex)
        End Try
    End Sub

    Private Sub cargarColumnas(pLST As ListView)
        Try
            pLST.Columns.AddRange(New ColumnHeader() {
                New ColumnHeader() With {.Text = "ID Ingrediente", .Width = 5},
                New ColumnHeader() With {.Text = "Id Proveedor", .Width = 5},
                New ColumnHeader() With {.Text = "Ingrediente", .Width = 213},
                New ColumnHeader() With {.Text = "Proveedor", .Width = 250}
            })
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function getNombreIngrediente(id As Integer, listado As List(Of Ingrediente)) As String
        Try
            For Each ingrediente In listado
                If ingrediente.IdIngrediente = id Then
                    Return ingrediente.Nombre
                End If
            Next
            Return ""
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function getNombreProveedor(id As Integer, listado As List(Of Proveedor)) As String
        Try
            For Each proveedor In listado
                If proveedor.IdProveedor = id Then
                    Return proveedor.Nombre
                End If
            Next
            Return ""
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
