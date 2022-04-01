Imports entidades
Imports servicios
Imports System.Windows.Forms


Public Class WebForm1
    Inherits System.Web.UI.Page
    Dim consultaService As New consultaService()
    Dim idPaciente As Integer
    Public dst As DataSet

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        idPaciente = Request.QueryString("id")
        CargarGrid()
    End Sub

    Private Sub Limpiar()
        txtId.Text = 0
        txtDescripcion.Text = ""
        txtCosto.Text = ""
        txtCostoPractica.Text = ""
        nroHistoriaClinica.Text = ""
        nroMatricula.Text = ""
        selectTipoConsulta.SelectedValue = "Consulta"

    End Sub

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim consulta As New EConsulta()

        Dim dato As String
        Dim validacion As Boolean
        dato = Calendar1.SelectedDate.Date.ToString("yyyy/MM/dd")

        consulta.Id = Integer.Parse(txtId.Text)
        consulta.Descripcion = txtDescripcion.Text
        consulta.Fecha_realizacion = dato
        consulta.Costo = Double.Parse(txtCosto.Text)
        consulta.Costo_material = Double.Parse(txtCostoPractica.Text)
        consulta.Tipo_consulta = selectTipoConsulta.SelectedValue.ToString
        consulta.Id_paciente = nroHistoriaClinica.Text
        consulta.Id_medico = nroMatricula.Text
        validacion = consultaService.validarDatos(consulta)

        If validacion = False Then Exit Sub

        If selectTipoConsulta.SelectedValue = "Consulta" Then
            consulta.Costo_material = 0

        End If

        If consulta.Id = 0 Then
            consultaService.guardar(consulta)
        Else
            consultaService.Editar(consulta)
        End If


        CargarGrid()

    End Sub


    Protected Sub gridConsultas_onSelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridConsultas.SelectedIndexChanged
        Dim consulta As New EConsulta
        nroHistoriaClinica.Enabled = False
        nroMatricula.Enabled = False
        txtId.Text = HttpUtility.HtmlDecode(gridConsultas.SelectedRow.Cells.Item(1).Text.ToString)
        Calendar1.SelectedDate = HttpUtility.HtmlDecode(gridConsultas.SelectedRow.Cells.Item(2).Text.ToString)
        txtDescripcion.Text = HttpUtility.HtmlDecode(gridConsultas.SelectedRow.Cells.Item(3).Text.ToString)
        selectTipoConsulta.SelectedValue = HttpUtility.HtmlDecode(gridConsultas.SelectedRow.Cells.Item(4).Text.ToString)
        txtCosto.Text = HttpUtility.HtmlDecode(gridConsultas.SelectedRow.Cells.Item(5).Text.ToString)
        txtCostoPractica.Text = HttpUtility.HtmlDecode(gridConsultas.SelectedRow.Cells.Item(6).Text.ToString)
        nroMatricula.Text = HttpUtility.HtmlDecode(gridConsultas.SelectedRow.Cells.Item(8).Text.ToString)
        nroHistoriaClinica.Text = HttpUtility.HtmlDecode(gridConsultas.SelectedRow.Cells.Item(11).Text.ToString)
    End Sub


    Private Sub CargarGrid()

        gridConsultas.DataSource = consultaService.Listar(idPaciente).Tables(0)
        gridConsultas.DataBind()
    End Sub

    Protected Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        nroHistoriaClinica.Enabled = True
        nroMatricula.Enabled = True
        Limpiar()
    End Sub


    Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click


        Dim consulta As New EConsulta()

        consulta.Id = Integer.Parse(txtId.Text)
        consultaService.Elminar(consulta)
        CargarGrid()
        Limpiar()
    End Sub

    Protected Sub Unnamed1_Click(sender As Object, e As EventArgs)
        Response.Redirect("~/index.aspx")
    End Sub
End Class