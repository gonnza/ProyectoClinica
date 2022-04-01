Imports entidades
Imports datos
Imports System.Windows.Forms

Public Class clinicaService

    Dim clinicaDatos As New clinicaDatos()


    Public Function validarDatos(ByVal clinica As EClinica) As Boolean

        Dim resultado As Boolean = True

        If clinica.Razon_social = "" Then
            resultado = False

        End If


        Return resultado
    End Function

    Public Sub guardar(ByVal clinica As EClinica)
        clinicaDatos.Insertar(clinica)
    End Sub

    Public Sub Editar(ByVal clinica As EClinica)
        clinicaDatos.Modificar(clinica)
    End Sub

    Public Function Listar() As DataSet
        Return clinicaDatos.Listar()
    End Function

    Public Sub Elminar(ByVal clinica As EClinica)

        clinicaDatos.Eliminar(clinica)
    End Sub
End Class
