Imports MySql.Data.MySqlClient
Imports entidades
Imports System.Windows.Forms

Public Class consultaDatos

    Private conexionConfig As New conexionConfig

    Private _cadenaConexion As String = conexionConfig.Cadena_conexion

    Public Sub Insertar(ByVal consulta As EConsulta)

        Dim readerPaciente As MySqlDataReader
        Dim readerMedico As MySqlDataReader
        Dim dataSet As New DataSet
        Dim idPaciente As Integer
        Dim idMedico As Integer

        Dim Conexion As New MySqlConnection(_cadenaConexion)
        Conexion.Open()

        Dim queryIdPaciente As String = "SELECT `id` FROM `paciente` WHERE `nro_historia_clinica`= '" & consulta.Id_paciente & "';"
        Dim ComandoUno As New MySqlCommand(queryIdPaciente, Conexion)

        readerPaciente = ComandoUno.ExecuteReader()
        If readerPaciente.Read() Then
            idPaciente = readerPaciente(0)
        End If
        Conexion.Close()
        Conexion.Open()
        Dim queryIdMedico As String = "SELECT `id` FROM `medico` WHERE `nro_matricula`= '" & consulta.Id_medico & "' ;"
        Dim ComandoDos As New MySqlCommand(queryIdMedico, Conexion)
        readerMedico = ComandoDos.ExecuteReader()

        If readerMedico.Read() Then
            idMedico = readerMedico(0)
        End If
        Conexion.Close()

        If idMedico <> 0 & idPaciente <> 0 Then
            Conexion.Open()
            Dim Query As String = "INSERT INTO `consultas` (`fecha_realizacion`, `costo`, `descripcion`, `costo_material`, `tipo_consulta`, `id_paciente`, `id_medico`) VALUES ('" & consulta.Fecha_realizacion & "','" & consulta.Costo & "','" & consulta.Descripcion & "','" & consulta.Costo_material & "','" & consulta.Tipo_consulta & "','" & idPaciente & "','" & idMedico & "');"
            Dim Comando As New MySqlCommand(Query, Conexion)
            Comando.ExecuteNonQuery()
            Conexion.Close()
        Else
            MessageBox.Show("Paciente o medico no encontrados")
            Exit Sub
        End If




    End Sub

    Public Sub Modificar(ByVal consulta As EConsulta)
        Dim Conexion As New MySqlConnection(_cadenaConexion)
        Dim readerPaciente As MySqlDataReader
        Dim readerMedico As MySqlDataReader
        Dim dataSet As New DataSet
        Dim idPaciente As Integer
        Dim idMedico As Integer

        Conexion.Open()

        Dim queryIdPaciente As String = "SELECT `id` FROM `paciente` WHERE `nro_historia_clinica`= '" & consulta.Id_paciente & "';"
        Dim ComandoUno As New MySqlCommand(queryIdPaciente, Conexion)

        readerPaciente = ComandoUno.ExecuteReader()
        If readerPaciente.Read() Then
            idPaciente = readerPaciente(0)
        End If
        Conexion.Close()

        Conexion.Open()
        Dim queryIdMedico As String = "SELECT `id` FROM `medico` WHERE `nro_matricula`= '" & consulta.Id_medico & "' ;"
        Dim ComandoDos As New MySqlCommand(queryIdMedico, Conexion)
        readerMedico = ComandoDos.ExecuteReader()

        If readerMedico.Read() Then
            idMedico = readerMedico(0)
        End If
        Conexion.Close()

        If idMedico <> 0 & idPaciente <> 0 Then
            Conexion.Open()
            Dim Query As String = "UPDATE `consultas` SET `fecha_realizacion`='" & consulta.Fecha_realizacion & "', `costo`='" & consulta.Costo & "', `descripcion`='" & consulta.Descripcion & "' , `costo_material`='" & consulta.Costo_material & "', `tipo_consulta`='" & consulta.Tipo_consulta & "', `id_paciente`='" & idPaciente & "', `id_medico`='" & idMedico & "' WHERE  `id`=" & consulta.Id & "; "
            Dim Comando As New MySqlCommand(Query, Conexion)
            Comando.ExecuteNonQuery()
            Conexion.Close()
        Else
            MessageBox.Show("Paciente o medico no encontrados")
            Exit Sub
        End If


    End Sub



    Public Sub Eliminar(ByVal consulta As EConsulta)

        Dim Conexion As New MySqlConnection(_cadenaConexion)
        Conexion.Open()
        Dim Query As String = "DELETE FROM `consultas` WHERE  `id`='" & consulta.Id & "'"
        Dim Comando As New MySqlCommand(Query, Conexion)
        Comando.ExecuteNonQuery()
        Conexion.Close()


    End Sub


    Public Function Listar(ByVal idPaciente As Integer) As DataSet

        Dim Conexion As New MySqlConnection(_cadenaConexion)
        Conexion.Open()

        Dim Adaptador As MySqlDataAdapter
        Dim dataSet As New DataSet


        Dim Query As String = "Select c.id , c.fecha_realizacion As `Fecha` , c.descripcion As `Descripcion`, c.tipo_consulta As `Tipo de Consulta`, c.costo As `Costo Consulta`, c.costo_material As `Costo de Material`
        ,  m.nombre AS `Medico`, m.nro_matricula AS `Matricula`, m.especialidad AS `Especialidad`
        , p.nombre AS `Paciente`, p.nro_historia_clinica AS `Historia Clinica`   FROM consultas c 
        INNER Join medico m ON c.id_medico = m.id
        INNER Join paciente p ON c.id_paciente = p.id WHERE p.id = " & idPaciente & ""
        Adaptador = New MySqlDataAdapter(Query, Conexion)
        Adaptador.Fill(dataSet)

        Return dataSet

    End Function

End Class
