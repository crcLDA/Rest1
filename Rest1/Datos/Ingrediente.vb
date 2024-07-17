Imports java.lang

Public Class Ingrediente
    Public Sub New()
    End Sub

    Public Sub New(idIngrediente As Integer, nombre As String, existencias As Decimal)
        _idIngrediente = idIngrediente
        _nombre = nombre
        _existencias = existencias
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

    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Private _existencias As Decimal
    Public Property Existencias() As Decimal
        Get
            Return _existencias
        End Get
        Set(ByVal value As Decimal)
            _existencias = value
        End Set
    End Property

    Public Function Info() As String
        Return "Id: " & _idIngrediente & vbCr & "Nombre: " & _nombre & vbCr & "Existencias: " & _existencias
    End Function
End Class
