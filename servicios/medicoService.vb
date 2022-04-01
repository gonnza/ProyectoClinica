Imports entidades
Imports datos
Imports System.Windows.Forms

Public Class medicoService

    Dim medicoDatos As New medicoDatos()
    Public Function validarDatos(ByVal medico As EMedico) As Boolean

        Dim resultado As Boolean = True

        If medico.Nombre = "" Then
            resultado = False

        End If


        Return resultado
    End Function



    Public Sub guardar(ByVal medico As EMedico, ByVal idClinica As Integer)
        medicoDatos.Insertar(medico, idClinica)
    End Sub

    Public Sub Editar(ByVal medico As EMedico)
        medicoDatos.Modificar(medico)
    End Sub

    Public Function Listar(ByVal idClinica As Integer) As DataSet
        Return medicoDatos.Listar(idClinica)
    End Function

    Public Sub Elminar(ByVal medico As EMedico)
        If MessageBox.Show("¿Estás seguro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            medicoDatos.Eliminar(medico)
        End If
    End Sub


End Class
