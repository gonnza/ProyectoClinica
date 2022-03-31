Imports entidades
Imports datos

Public Class pacienteService
    Dim pacienteDatos As New pacienteDatos()
    Public Sub guardar(ByVal paciente As EPaciente)
        pacienteDatos.Insertar(paciente)
    End Sub

    Public Function Listar() As DataSet
        Return pacienteDatos.Listar()
    End Function
End Class
