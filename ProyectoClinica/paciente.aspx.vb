Imports entidades
Imports servicios

Public Class paciente
    Inherits System.Web.UI.Page

    Dim pacienteService As New pacienteService()
    Public dst As DataSet

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarGrid()
    End Sub

    Protected Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

    End Sub

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim paciente As New EPaciente()

        paciente.Nombre = txtNombre.Text
        paciente.NroHistoriaClinica = txtNroHistoriaClinica.Text


        pacienteService.guardar(paciente)
        CargarGrid()
    End Sub

    Private Sub CargarGrid()

        gridPacientes.DataSource = pacienteService.Listar().Tables(0)
        gridPacientes.DataBind()
    End Sub
End Class