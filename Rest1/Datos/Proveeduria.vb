Public Class Proveeduria
    Public Sub New()
    End Sub

    Public Sub New(idIngrediente As Integer, idProveedor As Integer)
        _idIngrediente = idIngrediente
        _idProveedor = idProveedor
    End Sub

    Private _idIngrediente As Integer
    Public Property IdIngrediente() As Integer
        Get
            Return _idIngrediente
        End Get
        Set(ByVal value As Integer)
            _idIngrediente = value
        End Set
    End Property

    Private _idProveedor As Integer
    Public Property IdProveedor() As Integer
        Get
            Return _idProveedor
        End Get
        Set(ByVal value As Integer)
            _idProveedor = value
        End Set
    End Property
End Class
