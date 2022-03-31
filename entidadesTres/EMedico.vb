Public Class EMedico
    Inherits Persona

    Private _nroMatricula As String
    Private _especialidad As String
    Private _id As Integer

    Public Property NroMatricula As String
        Get
            Return _nroMatricula
        End Get
        Set(value As String)
            _nroMatricula = value
        End Set
    End Property

    Public Property Especialidad As String
        Get
            Return _especialidad
        End Get
        Set(value As String)
            _especialidad = value
        End Set
    End Property

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
End Class
