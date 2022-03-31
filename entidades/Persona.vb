Public Class Persona
    Private _nombre As String

    Public Sub New()

    End Sub

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
End Class
