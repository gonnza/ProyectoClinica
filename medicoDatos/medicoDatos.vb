Imports MySql.Data.MySqlClient
Imports entidades

Public Class medicoDatos

    Private _cadenaConexion As String = "Server=127.0.0.1;User=root;Password=123456;Port=3306;database=clinica_system"


    Public Sub Insertar(ByVal medico As EMedico, ByVal idClinica As Integer)

        Dim Conexion As New MySqlConnection(_cadenaConexion)
        Dim readerMedico As MySqlDataReader
        Dim idMedico As New Integer




        Conexion.Open()
        Dim Query As String = "INSERT INTO `medico` (`nombre`, `nro_matricula`, `especialidad`) VALUES ('" & medico.Nombre & "', '" & medico.NroMatricula & "', '" & medico.Especialidad & "');"
        Dim Comando As New MySqlCommand(Query, Conexion)
        Comando.ExecuteNonQuery()
        Conexion.Close()



        Conexion.Open()
        Dim queryIdMedico As String = "SELECT MAX(id) FROM `medico` ;"
        Dim ComandoDos As New MySqlCommand(queryIdMedico, Conexion)
        readerMedico = ComandoDos.ExecuteReader()
        If readerMedico.Read() Then
            idMedico = readerMedico(0)
        End If
        Conexion.Close()


        Conexion.Open()
        Dim QueryTres As String = "INSERT INTO `clinica_medico` (`id_medico` ,`id_clinica`) VALUES ('" & idMedico & "', '" & idClinica & "');"
        Dim ComandoTres As New MySqlCommand(QueryTres, Conexion)

        ComandoTres.ExecuteNonQuery()
        Conexion.Close()


    End Sub

    Public Sub Modificar(ByVal medico As EMedico)

        Dim Conexion As New MySqlConnection(_cadenaConexion)
        Conexion.Open()
        Dim Query As String = "UPDATE `medico` SET `nombre`='" & medico.Nombre & "', `nro_matricula`='" & medico.NroMatricula & "', `especialidad`='" & medico.Especialidad & "' WHERE  `id`=" & medico.Id & "; "
        Dim Comando As New MySqlCommand(Query, Conexion)
        Comando.ExecuteNonQuery()
        Conexion.Close()


    End Sub



    Public Sub Eliminar(ByVal medico As EMedico)

        Dim Conexion As New MySqlConnection(_cadenaConexion)
        Conexion.Open()
        Dim Query As String = "DELETE FROM `medico` WHERE  `id`='" & medico.Id & "'"
        Dim Comando As New MySqlCommand(Query, Conexion)
        Comando.ExecuteNonQuery()
        Conexion.Close()


    End Sub


    Public Function Listar(ByVal idClinica As Integer) As DataSet

        Dim Conexion As New MySqlConnection(_cadenaConexion)
        Conexion.Open()

        Dim Adaptador As MySqlDataAdapter
        Dim dataSet As New DataSet


        Dim Query As String = " SELECT m.id AS `Id`, m.nombre AS `Nombre`, m.nro_matricula AS `Matricula`, m.especialidad AS `Especialidad` FROM medico m INNER  JOIN clinica_medico c ON m.id = c.id_medico WHERE c.id_clinica = " & idClinica & ""
        Adaptador = New MySqlDataAdapter(Query, Conexion)
        Adaptador.Fill(dataSet)

        Return dataSet

    End Function

End Class
