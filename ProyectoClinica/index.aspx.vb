Imports entidades
Imports servicios

Public Class clinica
    Inherits System.Web.UI.Page

    Dim clinicaService As New clinicaService()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarGrid()
    End Sub

    Private Sub Limpiar()
        txtId.Text = 0
        razonSocial.Text = ""

    End Sub

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim clinica As New EClinica()
        Dim validacion As Boolean

        clinica.Id = Integer.Parse(txtId.Text)
        clinica.Razon_social = razonSocial.Text



        validacion = clinicaService.validarDatos(clinica)

        If validacion = False Then Exit Sub


        If clinica.Id = 0 Then
            clinicaService.guardar(clinica)
        Else
            clinicaService.Editar(clinica)
        End If

        CargarGrid()
        Limpiar()
    End Sub


    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If Integer.Parse(txtId.Text) = 0 Then Exit Sub
        Dim clinica As New EClinica()

        clinica.Id = Integer.Parse(txtId.Text)
        clinicaService.Elminar(clinica)
        CargarGrid()
        Limpiar()
    End Sub

    Private Sub CargarGrid()

        gridClinicas.DataSource = clinicaService.Listar().Tables(0)
        gridClinicas.DataBind()
    End Sub


    Protected Sub gridClinicas_onSelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridClinicas.SelectedIndexChanged
        txtId.Text = HttpUtility.HtmlDecode(gridClinicas.SelectedRow.Cells.Item(1).Text.ToString)
        razonSocial.Text = HttpUtility.HtmlDecode(gridClinicas.SelectedRow.Cells.Item(2).Text.ToString)

    End Sub


    Protected Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Limpiar()
    End Sub

    Protected Sub btnPaciente_Click(sender As Object, e As EventArgs) Handles btnPaciente.Click
        Response.Redirect("~/paciente.aspx?id=" + txtId.Text)
    End Sub

    Protected Sub btnMedico_Click(sender As Object, e As EventArgs) Handles btnMedico.Click
        Response.Redirect("~/medico.aspx?id=" + txtId.Text)
    End Sub
End Class