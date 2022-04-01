Imports entidades
Imports datos
Imports System.Windows.Forms

Public Class pacienteService
    Dim pacienteDatos As New pacienteDatos()

    Public Function validarDatos(ByVal paciente As EPaciente) As Boolean

        Dim resultado As Boolean = True

        If paciente.Nombre = "" Then
            resultado = False

        End If


        Return resultado
    End Function

    Public Sub guardar(ByVal paciente As EPaciente, ByVal idClinica As Integer)
        pacienteDatos.Insertar(paciente, idClinica)
    End Sub

    Public Sub Editar(ByVal paciente As EPaciente)
        pacienteDatos.Modificar(paciente)
    End Sub


    Public Sub Elminar(ByVal paciente As EPaciente)
        If MessageBox.Show("¿Estás seguro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            pacienteDatos.Eliminar(paciente)
        End If
    End Sub


    Public Function Listar(ByVal idClinica As Integer) As DataSet
        Return pacienteDatos.Listar(idClinica)
    End Function
End Class
