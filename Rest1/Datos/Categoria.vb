Public Class Categoria
    Public Sub New()
    End Sub

    Public Sub New(id As Integer, descripcion As String)
        _id = id
        _descripcion = descripcion
    End Sub

    Private _id As Integer
    Public Property IdCategoria() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
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

    Public Function Info() As String
        Return "ID Categoria: " & _id & vbCr & "Descripción: " & _descripcion
    End Function
End Class
