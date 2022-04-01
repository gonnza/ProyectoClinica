Public Class EConsulta
    Private _id As Integer
    Private _fecha_realizacion As String
    Private _costo As Double
    Private _descripcion As String
    Private _costo_material As Double
    Private _tipo_consulta As String
    Private _id_paciente As String
    Private _id_medico As String

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Fecha_realizacion As String
        Get
            Return _fecha_realizacion
        End Get
        Set(value As String)
            _fecha_realizacion = value
        End Set
    End Property

    Public Property Costo As Double
        Get
            Return _costo
        End Get
        Set(value As Double)
            _costo = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Costo_material As Double
        Get
            Return _costo_material
        End Get
        Set(value As Double)
            _costo_material = value
        End Set
    End Property

    Public Property Tipo_consulta As String
        Get
            Return _tipo_consulta
        End Get
        Set(value As String)
            _tipo_consulta = value
        End Set
    End Property

    Public Property Id_paciente As String
        Get
            Return _id_paciente
        End Get
        Set(value As String)
            _id_paciente = value
        End Set
    End Property

    Public Property Id_medico As String
        Get
            Return _id_medico
        End Get
        Set(value As String)
            _id_medico = value
        End Set
    End Property
End Class
