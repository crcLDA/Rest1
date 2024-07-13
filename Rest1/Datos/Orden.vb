Public Class Orden

    Public Sub New()
    End Sub

    Public Sub New(id As Long, usuario As String, fecha As String)
        _id = id
        _cedula = usuario
        _fecha = fecha
    End Sub

    Private _id As Long
    Public Property IdOrden() As Long
        Get
            Return _id
        End Get
        Set(ByVal value As Long)
            _id = value
        End Set
    End Property

    Private _cedula As String
    Public Property Usuario() As String
        Get
            Return _cedula
        End Get
        Set(ByVal value As String)
            _cedula = value
        End Set
    End Property

    Private _fecha As String
    Public Property Fecha() As String
        Get
            Return _fecha
        End Get
        Set(ByVal value As String)
            _fecha = value
        End Set
    End Property

    Public Function Info() As String
        Return "Id: " & _id & vbCr & "Cliente: " & _cedula & vbCr & "Fecha: " & _fecha
    End Function
End Class
