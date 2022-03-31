
Imports entidades
Imports servicios
Imports enums


Public Class medico
    Inherits System.Web.UI.Page

    Dim medicoService As New medicoService()

    Public dst As DataSet

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarGrid()

    End Sub


    Private Sub Limpiar()
        txtId.Text = 0
        txtNombre.Text = ""
        txtNroMatricula.Text = ""
        selectEspecialidad.SelectedValue = "Cirujano"
    End Sub


    Protected Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Limpiar()
    End Sub

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim medico As New EMedico()
        Dim validacion As Boolean

        medico.Id = Integer.Parse(txtId.Text)
        medico.Nombre = txtNombre.Text
        medico.Especialidad = selectEspecialidad.SelectedValue.ToString
        medico.NroMatricula = txtNroMatricula.Text


        validacion = medicoService.validarDatos(medico)

        If validacion = False Then Exit Sub




        If medico.Id = 0 Then
            medicoService.guardar(medico)
        Else
            medicoService.Editar(medico)
        End If



        CargarGrid()
    End Sub

    Private Sub CargarGrid()

        gridMedicos.DataSource = medicoService.Listar().Tables(0)
        gridMedicos.DataBind()
    End Sub

    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If Integer.Parse(txtId.Text) = 0 Then Exit Sub
        Dim medico As New EMedico()

        medico.Id = Integer.Parse(txtId.Text)
        medicoService.Elminar(medico)
        CargarGrid()

    End Sub





    Protected Sub gridMedicos_onSelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridMedicos.SelectedIndexChanged
        txtId.Text = HttpUtility.HtmlDecode(gridMedicos.SelectedRow.Cells.Item(1).Text.ToString)
        txtNombre.Text = HttpUtility.HtmlDecode(gridMedicos.SelectedRow.Cells.Item(2).Text.ToString)
        txtNroMatricula.Text = HttpUtility.HtmlDecode(gridMedicos.SelectedRow.Cells.Item(3).Text.ToString)
        selectEspecialidad.SelectedValue = HttpUtility.HtmlDecode(gridMedicos.SelectedRow.Cells.Item(4).Text.ToString)
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles selectEspecialidad.SelectedIndexChanged

    End Sub
End Class