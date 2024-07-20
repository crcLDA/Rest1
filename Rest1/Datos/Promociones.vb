Public Class Promocion
    Public Property IdPromocion As Integer
    Public Property Nombre As String
    Public Property Descripcion As String
    Public Property FechaInicio As Date
    Public Property FechaFin As Date
    Public Property Descuento As Decimal
    Public Property IdProducto As Integer
    Public Property Activo As Boolean

    Public Sub New()
    End Sub

    Public Sub New(id As Integer, nombre As String, descripcion As String, fechaInicio As Date, fechaFin As Date, descuento As Decimal, idProducto As Integer, activo As Boolean)
        IdPromocion = id
        nombre = nombre
        descripcion = descripcion
        fechaInicio = fechaInicio
        fechaFin = fechaFin
        descuento = descuento
        idProducto = idProducto
        activo = activo
    End Sub
End Class



