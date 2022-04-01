Imports entidades
Imports datos
Imports System.Windows.Forms

Public Class consultaService
    Dim consultaDatos As New consultaDatos()

    Public Function validarDatos(ByVal consulta As EConsulta) As Boolean

        Dim resultado As Boolean = True

        If consulta.Id_medico = "" Then
            resultado = False
            MessageBox.Show("Debe indicar un medico asignado")
        End If

        If consulta.Id_paciente = "" Then
            resultado = False
            MessageBox.Show("Debe indicar un paciente")
        End If
        If consulta.Tipo_consulta = "" Then
            resultado = False
            MessageBox.Show("Debe indicar el tipo de consulta")
        End If

        Return resultado
    End Function

    Public Sub guardar(ByVal consulta As EConsulta)
        consultaDatos.Insertar(consulta)
    End Sub

    Public Function Listar(ByVal idPaciente As Integer) As DataSet
        Return consultaDatos.Listar(idPaciente)
    End Function

    Public Sub Editar(ByVal consulta As EConsulta)
        consultaDatos.Modificar(consulta)
    End Sub

    Public Sub Elminar(ByVal consulta As EConsulta)
        If MessageBox.Show("¿Estás seguro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            consultaDatos.Eliminar(consulta)
        End If
    End Sub

End Class
