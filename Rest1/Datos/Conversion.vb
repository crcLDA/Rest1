Public Class Conversion
    Public Sub New()
    End Sub

    Public Sub New(idProd As Integer, idIng As Integer, UoC As Decimal)
        _idProducto = idProd
        _idIngrediente = idIng
        _conversion = UoC
    End Sub

    Private _idProducto As Integer
    Public Property IdProducto() As Integer
        Get
            Return _idProducto
        End Get
        Set(ByVal value As Integer)
            _idProducto = value
        End Set

    End Property
    Private _idIngrediente As Integer
    Public Property IdIngrediente() As Integer
        Get
            Return _idIngrediente
        End Get
        Set(ByVal value As Integer)
            _idIngrediente = value
        End Set
    End Property

    Private _conversion As Decimal
    Public Property Conversion() As Decimal
        Get
            Return _conversion
        End Get
        Set(ByVal value As Decimal)
            _conversion = value
        End Set
    End Property
End Class
