Imports com.sun.xml.internal.bind.v2.model.core

Public Class DetalleOrden

    Public Sub New()
    End Sub

    Public Sub New(id As Long, idOrden As Long, idFactura As Long, idProducto As Integer, subtotal As Decimal, cancelado As Boolean)
        _id = id
        _idOrden = idOrden
        _idFactura = idFactura
        _idProducto = idProducto
        _subtotal = subtotal
        _cancelado = cancelado
    End Sub


    Private _id As Long
    Public Property idDetalle() As Long
        Get
            Return _id
        End Get
        Set(ByVal value As Long)
            _id = value
        End Set
    End Property

    Private _idOrden As Long
    Public Property idOrden() As Long
        Get
            Return _idOrden
        End Get
        Set(ByVal value As Long)
            _idOrden = value
        End Set
    End Property

    Private _idFactura As Long
    Public Property idFactura() As Long
        Get
            Return _idFactura
        End Get
        Set(ByVal value As Long)
            _idFactura = value
        End Set
    End Property

    Private _idProducto As Integer
    Public Property idProducto() As Integer
        Get
            Return _idProducto
        End Get
        Set(ByVal value As Integer)
            _idProducto = value
        End Set
    End Property

    Private _subtotal As Decimal
    Public Property subtotal() As Decimal
        Get
            Return _subtotal
        End Get
        Set(ByVal value As Decimal)
            _subtotal = value
        End Set
    End Property

    Private _cancelado As Boolean
    Public Property cancelado() As Boolean
        Get
            Return _cancelado
        End Get
        Set(ByVal value As Boolean)
            _cancelado = value
        End Set
    End Property

    Public Function Info() As String
        Return "ID Detalle: " & _id & vbCrLf & "ID Orden: " & _idOrden & vbCrLf & "ID Factura: " & _idFactura & vbCrLf & "ID Producto: " & _idProducto & vbCrLf & "Subtotal: " & _subtotal & vbCrLf & "Cancelado: " & _cancelado
    End Function
End Class
