Public Class Producto
    Public Sub New()
    End Sub

    Public Sub New(idProducto As Integer, nombre As String, descripcion As String, precio As Decimal, idCategoria As Integer, activo As Boolean)
        Me._idProducto = idProducto
        Me._nombre = nombre
        Me._descripcion = descripcion
        Me._precio = precio
        Me._idCategoria = idCategoria
        Me._activo = activo
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

    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Private _descripcion As String
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Private _precio As Decimal
    Public Property Precio() As Decimal
        Get
            Return _precio
        End Get
        Set(ByVal value As Decimal)
            _precio = value
        End Set
    End Property

    Private _idCategoria As Integer
    Public Property IdCategoria() As Integer
        Get
            Return _idCategoria
        End Get
        Set(ByVal value As Integer)
            _idCategoria = value
        End Set
    End Property

    Private _activo As Boolean
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property


    Public Function Info() As String
        Return "ID Producto: " & _idProducto & vbCr & "Nombre: " & _nombre & vbCr & "Descripción: " & _descripcion & vbCr & "Precio: " & _precio & vbCr & "ID Categoría: " & _idCategoria & vbCr & "Activo: " & _activo
    End Function
End Class

