Public Class Usuario
    Public Sub New()
    End Sub

    Public Sub New(usuario As String, contrasena As String, rol As String)
        _usuario = usuario
        _contrasena = contrasena
        _rol = rol
    End Sub

    Private _usuario As String
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Private _contrasena As String
    Public Property Contrasena() As String
        Get
            Return _contrasena
        End Get
        Set(ByVal value As String)
            _contrasena = value
        End Set
    End Property

    Private _rol As String
    Public Property Rol() As String
        Get
            Return _rol
        End Get
        Set(ByVal value As String)
            _rol = value
        End Set
    End Property

    Public Function Info() As String
        Return "Usuario: " & _usuario & vbCr & "Contraseña: " & _contrasena & vbCr & "Rol: " & _rol
    End Function
End Class
