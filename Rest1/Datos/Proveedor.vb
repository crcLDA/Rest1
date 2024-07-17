Public Class Proveedor
    Public Sub New()
    End Sub

    Public Sub New(idProveedor As Integer, nombre As String, telefono As String, direccion As String)
        _idProveedor = idProveedor
        _nombre = nombre
        _telefono = telefono
        _direccion = direccion
    End Sub

    Private _idProveedor As Integer
    Public Property IdProveedor() As Integer
        Get
            Return _idProveedor
        End Get
        Set(ByVal value As Integer)
            _idProveedor = value
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

    Private _telefono As String
    Public Property Telefono() As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property

    Private _direccion As String
    Public Property Direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property

    Public Function Info() As String
        Return "Id: " & _idProveedor & vbCr & "Nombre: " & _nombre & vbCr & "Teléfono: " & _telefono & vbCr & "Dirección: " & _direccion
    End Function
End Class
