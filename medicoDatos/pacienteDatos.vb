Imports MySql.Data.MySqlClient
Imports entidades

Public Class pacienteDatos

    Private _cadenaConexion As String = "Server=127.0.0.1;User=root;Password=123456;Port=3306;database=clinica_system"
    Dim idClin As Integer

    Public Sub Insertar(ByVal paciente As EPaciente, ByVal idClinica As Integer)
        Dim readerPaciente As MySqlDataReader
        Dim Conexion As New MySqlConnection(_cadenaConexion)
        Dim idPaciente As New Integer



        Conexion.Open()
        Dim Query As String = "INSERT INTO `paciente` (`nro_historia_clinica` ,`nombre`) VALUES ('" & paciente.NroHistoriaClinica & "', '" & paciente.Nombre & "');"
        Dim Comando As New MySqlCommand(Query, Conexion)
        Comando.ExecuteNonQuery()
        Conexion.Close()

        Conexion.Open()

        Dim queryIdPaciente As String = "SELECT MAX(id) FROM `paciente` ;"
        Dim ComandoUno As New MySqlCommand(queryIdPaciente, Conexion)

        readerPaciente = ComandoUno.ExecuteReader()
        If readerPaciente.Read() Then
            idPaciente = readerPaciente(0)
        End If
        Conexion.Close()

        Conexion.Open()
        Dim QueryDos As String = "INSERT INTO `clinica_paciente` (`id_paciente` ,`id_clinica`) VALUES ('" & idPaciente & "', '" & idClinica & "');"
        Dim ComandoDos As New MySqlCommand(QueryDos, Conexion)

        ComandoDos.ExecuteNonQuery()
        Conexion.Close()


    End Sub


    Public Sub Modificar(ByVal paciente As EPaciente)

        Dim Conexion As New MySqlConnection(_cadenaConexion)
        Conexion.Open()
        Dim Query As String = "UPDATE `paciente` SET `nro_historia_clinica`='" & paciente.NroHistoriaClinica & "', `nombre`='" & paciente.Nombre & "'; "
        Dim Comando As New MySqlCommand(Query, Conexion)
        Comando.ExecuteNonQuery()
        Conexion.Close()


    End Sub



    Public Sub Eliminar(ByVal paciente As EPaciente)
        Dim Conexion As New MySqlConnection(_cadenaConexion)


        Conexion.Open()
        Dim QueryDos As String = "DELETE FROM `clinica_paciente` WHERE  `id_paciente`='" & paciente.Id & "'"
        Dim ComandoDos As New MySqlCommand(QueryDos, Conexion)
        ComandoDos.ExecuteNonQuery()
        Conexion.Close()


        Conexion.Open()
        Dim Query As String = "DELETE FROM `paciente` WHERE  `id`='" & paciente.Id & "'"
        Dim Comando As New MySqlCommand(Query, Conexion)
        Comando.ExecuteNonQuery()
        Conexion.Close()



    End Sub


    Public Function Listar(ByVal idClinica As Integer) As DataSet

        Dim Conexion As New MySqlConnection(_cadenaConexion)
        Conexion.Open()

        Dim Adaptador As MySqlDataAdapter
        Dim dataSet As New DataSet


        Dim Query As String = "SELECT p.id As `Id`, p.nro_historia_clinica As `Nro Historia Clinica`, p.nombre as `Nombre` FROM paciente p INNER  JOIN clinica_paciente c ON p.id = c.id_paciente WHERE c.id_clinica = " & idClinica & ";"
        Adaptador = New MySqlDataAdapter(Query, Conexion)
        Adaptador.Fill(dataSet)

        Return dataSet

    End Function

End Class
