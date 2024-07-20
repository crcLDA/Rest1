Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class Promociones
    Private objDB As DbNoSql

    Public Sub New()
        objDB = New DbNoSql("Promociones")
    End Sub

    Public Sub CerrarConexion()
        objDB.cerrarConexion()
    End Sub

    Public Function getNextID() As Integer
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection()
            Dim filterSort As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Empty
            Dim sortDefinition As SortDefinition(Of BsonDocument) = Builders(Of BsonDocument).Sort.Descending("id_promocion")
            Dim promocionDoc As BsonDocument = collection.Find(filterSort).Sort(sortDefinition).Limit(1).FirstOrDefault()

            If promocionDoc IsNot Nothing Then
                Return promocionDoc("id_promocion").AsInt32 + 1
            Else
                Return 1
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub Agregar(promocion As Promocion)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection()
            Dim document As New BsonDocument()

            document.Add("id_promocion", getNextID())
            document.Add("nombre", promocion.Nombre)
            document.Add("descripcion", promocion.Descripcion)
            document.Add("fecha_inicio", promocion.FechaInicio)
            document.Add("fecha_fin", promocion.FechaFin)
            document.Add("descuento", promocion.Descuento)
            document.Add("id_producto", promocion.IdProducto)
            document.Add("activo", promocion.Activo)

            collection.InsertOne(document)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Modificar(promocion As Promocion)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of Integer)("id_promocion", promocion.IdPromocion)

            Dim document As New BsonDocument()
            document.Add("id_promocion", promocion.IdPromocion)
            document.Add("nombre", promocion.Nombre)
            document.Add("descripcion", promocion.Descripcion)
            document.Add("fecha_inicio", promocion.FechaInicio)
            document.Add("fecha_fin", promocion.FechaFin)
            document.Add("descuento", promocion.Descuento)
            document.Add("id_producto", promocion.IdProducto)
            document.Add("activo", promocion.Activo)

            collection.ReplaceOne(filter, document)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Eliminar(pId As Integer)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection
            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of Integer)("id_promocion", pId)

            collection.DeleteOne(filter)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub CargarListView(pLST As ListView)
        Try
            pLST.Clear()
            cargarColumnas(pLST)

            Dim listaPromociones As List(Of Promocion) = getPromociones()

            For Each promocion As Promocion In listaPromociones
                Dim item As New ListViewItem(promocion.IdPromocion.ToString())
                item.SubItems.Add(promocion.Nombre)
                item.SubItems.Add(promocion.Descripcion)
                item.SubItems.Add(promocion.FechaInicio.ToString("dd/MM/yyyy"))
                item.SubItems.Add(promocion.FechaFin.ToString("dd/MM/yyyy"))
                item.SubItems.Add(promocion.Descuento.ToString("P"))
                item.SubItems.Add(promocion.IdProducto.ToString())
                item.SubItems.Add(If(promocion.Activo, "Sí", "No"))

                pLST.Items.Add(item)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ConsultarID(id As Integer) As Promocion
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection()

            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of Integer)("id_promocion", id)
            Dim promocionDoc As BsonDocument = collection.Find(filter).FirstOrDefault()

            If promocionDoc IsNot Nothing Then
                Dim promocion As New Promocion() With {
                    .IdPromocion = promocionDoc("id_promocion").AsInt32,
                    .Nombre = promocionDoc("nombre").AsString,
                    .Descripcion = promocionDoc("descripcion").AsString,
                    .FechaInicio = promocionDoc("fecha_inicio").ToUniversalTime(),
                    .FechaFin = promocionDoc("fecha_fin").ToUniversalTime(),
                    .Descuento = promocionDoc("descuento").AsDecimal,
                    .IdProducto = promocionDoc("id_producto").AsInt32,
                    .Activo = promocionDoc("activo").AsBoolean
                }
                Return promocion
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function getPromociones() As List(Of Promocion)
        Try
            Dim collection As IMongoCollection(Of BsonDocument) = objDB.GetCollection()

            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Empty
            Dim documents As List(Of BsonDocument) = collection.Find(filter).ToList()

            Dim promociones As New List(Of Promocion)()

            For Each doc As BsonDocument In documents
                Dim promocion As New Promocion() With {
                    .IdPromocion = doc("id_promocion").AsInt32,
                    .Nombre = doc("nombre").AsString,
                    .Descripcion = doc("descripcion").AsString,
                    .FechaInicio = doc("fecha_inicio").ToUniversalTime(),
                    .FechaFin = doc("fecha_fin").ToUniversalTime(),
                    .Descuento = doc("descuento").AsDecimal,
                    .IdProducto = doc("id_producto").AsInt32,
                    .Activo = doc("activo").AsBoolean
                }
                promociones.Add(promocion)
            Next

            Return promociones
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub cargarColumnas(pLST As ListView)
        Try
            pLST.Columns.AddRange(New ColumnHeader() {
                New ColumnHeader() With {.Text = "ID", .Width = 50},
                New ColumnHeader() With {.Text = "Nombre", .Width = 200},
                New ColumnHeader() With {.Text = "Descripción", .Width = 200},
                New ColumnHeader() With {.Text = "Fecha Inicio", .Width = 100},
                New ColumnHeader() With {.Text = "Fecha Fin", .Width = 100},
                New ColumnHeader() With {.Text = "Descuento", .Width = 100},
                New ColumnHeader() With {.Text = "ID Producto", .Width = 100},
                New ColumnHeader() With {.Text = "Activo", .Width = 50}
            })
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class