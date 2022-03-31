Imports MySql.Data.MySqlClient
Imports entidades

Public Class medicoDatos

    Private _cadenaConexion As String = "Server=127.0.0.1;User=root;Password=123456;Port=3306;database=clinica_system"


    Public Sub Insertar(ByVal medico As EMedico)

        Dim Conexion As New MySqlConnection(_cadenaConexion)
        Conexion.Open()
        Dim Query As String = "INSERT INTO `medico` (`nombre`, `nro_matricula`, `especialidad`) VALUES ('" & medico.Nombre & "', '" & medico.NroMatricula & "', '" & medico.Especialidad & "');"
        Dim Comando As New MySqlCommand(Query, Conexion)
        Comando.ExecuteNonQuery()
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


    Public Function Listar() As DataSet

        Dim Conexion As New MySqlConnection(_cadenaConexion)
        Conexion.Open()

        Dim Adaptador As MySqlDataAdapter
        Dim dataSet As New DataSet


        Dim Query As String = "SELECT * FROM `medico`;"
        Adaptador = New MySqlDataAdapter(Query, Conexion)
        Adaptador.Fill(dataSet)

        Return dataSet

    End Function

End Class
