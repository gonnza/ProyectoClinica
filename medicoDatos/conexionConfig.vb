Public Class conexionConfig
    Private _cadena_conexion As String = "Server=127.0.0.1;User=root;Password=123456;Port=3306;database=clinica_system"


    Public Property Cadena_conexion As String
        Get
            Return _cadena_conexion
        End Get
        Set(value As String)
            _cadena_conexion = value
        End Set
    End Property
End Class
