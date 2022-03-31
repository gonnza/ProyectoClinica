Public Class EPaciente
    Inherits Persona

    Private _nroHistoriaClinica As String
    Private _listaConsultasRealizadas As String
    Private _id As Integer

    Public Property NroHistoriaClinica As String
        Get
            Return _nroHistoriaClinica
        End Get
        Set(value As String)
            _nroHistoriaClinica = value
        End Set
    End Property

    Public Property ListaConsultasRealizadas As String
        Get
            Return _listaConsultasRealizadas
        End Get
        Set(value As String)
            _listaConsultasRealizadas = value
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
