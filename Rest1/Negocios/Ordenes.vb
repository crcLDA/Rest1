Imports MongoDB.Bson
Imports MongoDB.Driver

Public Class Ordenes
    Private objDB As DbNoSql

    Public Sub New()
        objDB = New DbNoSql("Ordenes")
    End Sub

    Public Sub CerrarConexion()
        objDB.cerrarConexion()
    End Sub

    Public Sub EliminarPedido(ID As String)
        Try
            Dim detallesCollection As IMongoCollection(Of BsonDocument) = objDB.GetCollection("Detalles")
            Dim ordenesCollection As IMongoCollection(Of BsonDocument) = objDB.GetCollection("Ordenes")

            Dim filter As FilterDefinition(Of BsonDocument) = Builders(Of BsonDocument).Filter.Eq(Of String)("id_orden", ID)

            detallesCollection.DeleteMany(filter)
            ordenesCollection.DeleteOne(filter)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub cargarOrdenesPendientes(pLST As ListView)
        Try
            pLST.Clear()
            cargarColumnas(pLST)

            Dim ordenesCollection As IMongoCollection(Of BsonDocument) = objDB.GetCollection("Ordenes")

            ' Definir la pipeline de agregación
            Dim pipeline As New List(Of BsonDocument)

            ' $lookup
            Dim lookupStage As New BsonDocument("$lookup", New BsonDocument().
            Add("from", "Detalles").
            Add("localField", "id_orden").
            Add("foreignField", "id_orden").
            Add("as", "detallesRes"))
            pipeline.Add(lookupStage)

            ' $unwind
            Dim unwindStage As New BsonDocument("$unwind", "$detallesRes")
            pipeline.Add(unwindStage)

            ' $match
            Dim matchStage As New BsonDocument("$match", New BsonDocument("detallesRes.cancelado", False))
            pipeline.Add(matchStage)

            ' $group
            Dim groupStage As New BsonDocument("$group", New BsonDocument().
            Add("_id", "$id_orden").
            Add("cedula", New BsonDocument("$first", "$cedula")).
            Add("fecha", New BsonDocument("$first", "$fecha")))
            pipeline.Add(groupStage)

            ' $project
            Dim projectStage As New BsonDocument("$project", New BsonDocument().
            Add("id_orden", "$_id").
            Add("cedula", "$cedula").
            Add("fecha", "$fecha"))
            pipeline.Add(projectStage)

            ' Ejecutar la pipeline de agregación
            Dim result As List(Of BsonDocument) = ordenesCollection.Aggregate(Of BsonDocument)(pipeline).ToList()

            ' Procesar los resultados
            For Each doc As BsonDocument In result
                Dim item As New ListViewItem(doc("id_orden").AsInt32.ToString())
                item.SubItems.Add(doc("cedula").AsString)
                item.SubItems.Add(doc("fecha").ToString())
                pLST.Items.Add(item)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cargarColumnas(pLST As ListView)
        Try
            pLST.Columns.AddRange(New ColumnHeader() {
                New ColumnHeader() With {.Text = "ID", .Width = 30},
                New ColumnHeader() With {.Text = "Cliente", .Width = 133},
                New ColumnHeader() With {.Text = "Fecha", .Width = 95}
            })
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
