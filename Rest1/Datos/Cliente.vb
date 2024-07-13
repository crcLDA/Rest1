Public Class Cliente
    Public Sub New()
    End Sub

    Public Sub New(cedula As String, nombre As String, telefono As String)
        Me._cedula = cedula
        Me._nombre = nombre
        Me._telefono = telefono
    End Sub

    Private _cedula As String
    Public Property Cedula() As String
        Get
            Return _cedula
        End Get
        Set(ByVal value As String)
            _cedula = value
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

    Public Function Info() As String
        Return "Id: " & _cedula & vbCr & "Nombre: " & _nombre & vbCr & "Teléfono: " & _telefono
    End Function
End Class
