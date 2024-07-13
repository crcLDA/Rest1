Public Class Factura

    Public Sub New()
    End Sub

    Public Sub New(id As Long, idOrden As Long, idVendedor As String, fecha As String, total As Decimal, descuento As Decimal, cedula As String)
        _id = id
        _idOrden = idOrden
        _idVendedor = idVendedor
        _fecha = fecha
        _total = total
        _descuento = descuento
        _cedula = cedula
    End Sub

    Private _id As Long
    Public Property idFactura() As Long
        Get
            Return _id
        End Get
        Set(ByVal value As Long)
            _id = value
        End Set
    End Property

    Private _cedula As String
    Public Property cedula() As String
        Get
            Return _cedula
        End Get
        Set(ByVal value As String)
            _cedula = value
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

    Private _idVendedor As String
    Public Property idVendedor() As String
        Get
            Return _idVendedor
        End Get
        Set(ByVal value As String)
            _idVendedor = value
        End Set
    End Property

    Private _fecha As String
    Public Property fecha() As String
        Get
            Return _fecha
        End Get
        Set(ByVal value As String)
            _fecha = value
        End Set
    End Property

    Private _total As Decimal
    Public Property Total() As Decimal
        Get
            Return _total
        End Get
        Set(ByVal value As Decimal)
            _total = value
        End Set
    End Property

    Private _descuento As Decimal
    Public Property descuento() As Decimal
        Get
            Return _descuento
        End Get
        Set(ByVal value As Decimal)
            _descuento = value
        End Set
    End Property
End Class
