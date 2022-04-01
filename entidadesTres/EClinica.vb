Public Class EClinica
    Private _razon_social As String
    Private _listaPacientes As List(Of EPaciente)
    Private _listaMedicos As List(Of EMedico)
    Private _id As Integer

    Public Property Razon_social As String
        Get
            Return _razon_social
        End Get
        Set(value As String)
            _razon_social = value
        End Set
    End Property

    Public Property ListaPacientes As List(Of EPaciente)
        Get
            Return _listaPacientes
        End Get
        Set(value As List(Of EPaciente))
            _listaPacientes = value
        End Set
    End Property

    Public Property ListaMedicos As List(Of EMedico)
        Get
            Return _listaMedicos
        End Get
        Set(value As List(Of EMedico))
            _listaMedicos = value
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
