Imports entidades
Imports servicios

Public Class paciente
    Inherits System.Web.UI.Page

    Dim pacienteService As New pacienteService()
    Public dst As DataSet
    Dim idClinica As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        idClinica = Request.QueryString("id")

        CargarGrid()
    End Sub


    Private Sub Limpiar()
        txtId.Text = 0
        txtNombre.Text = ""
        txtNroHistoriaClinica.Text = ""
    End Sub


    Protected Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Limpiar()
    End Sub

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim paciente As New EPaciente()
        Dim validacion As Boolean
        paciente.Id = Integer.Parse(txtId.Text)
        paciente.Nombre = txtNombre.Text
        paciente.NroHistoriaClinica = txtNroHistoriaClinica.Text


        validacion = pacienteService.validarDatos(paciente)

        If validacion = False Then Exit Sub




        If paciente.Id = 0 Then
            pacienteService.guardar(paciente, idClinica)
        Else
            pacienteService.Editar(paciente)
        End If

        CargarGrid()
        Limpiar()
    End Sub


    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If Integer.Parse(txtId.Text) = 0 Then Exit Sub
        Dim paciente As New EPaciente()

        paciente.Id = Integer.Parse(txtId.Text)
        pacienteService.Elminar(paciente)
        CargarGrid()
        Limpiar()
    End Sub


    Protected Sub gridPacientes_onSelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridPacientes.SelectedIndexChanged
        txtId.Text = HttpUtility.HtmlDecode(gridPacientes.SelectedRow.Cells.Item(1).Text.ToString)
        txtNombre.Text = HttpUtility.HtmlDecode(gridPacientes.SelectedRow.Cells.Item(3).Text.ToString)
        txtNroHistoriaClinica.Text = HttpUtility.HtmlDecode(gridPacientes.SelectedRow.Cells.Item(2).Text.ToString)

    End Sub


    Private Sub CargarGrid()

        gridPacientes.DataSource = pacienteService.Listar(idClinica).Tables(0)
        gridPacientes.DataBind()
    End Sub

    Protected Sub btnPaci_Click(sender As Object, e As EventArgs) Handles btnPaci.Click
        Response.Redirect("~/consulta.aspx?id=" + txtId.Text)
    End Sub
End Class