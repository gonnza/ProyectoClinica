Imports MySql.Data.MySqlClient
Imports entidades
Imports System.Windows.Forms

Public Class clinicaDatos
    Private _cadenaConexion As String = "Server=127.0.0.1;User=root;Password=123456;Port=3306;database=clinica_system"

    Public Sub Insertar(ByVal clinica As EClinica)
        Dim Conexion As New MySqlConnection(_cadenaConexion)
        Conexion.Open()


        Dim Query As String = "INSERT INTO `clinica` (`razon_social`) VALUES ('" & clinica.Razon_social & "');"
        Dim Comando As New MySqlCommand(Query, Conexion)
        Comando.ExecuteNonQuery()
        Conexion.Close()


    End Sub

    Public Sub Modificar(ByVal clinica As EClinica)

        Dim Conexion As New MySqlConnection(_cadenaConexion)
        Conexion.Open()
        Dim Query As String = "UPDATE `clinica` SET `razon_social`='" & clinica.Razon_social & "' WHERE  `id`=" & clinica.Id & "; "
        Dim Comando As New MySqlCommand(Query, Conexion)
        Comando.ExecuteNonQuery()
        Conexion.Close()


    End Sub

    Public Sub Eliminar(ByVal clinica As EClinica)

        Dim Conexion As New MySqlConnection(_cadenaConexion)
        Conexion.Open()
        Dim Query As String = "DELETE FROM `clinica_medico` WHERE  `id_clinica`='" & clinica.Id & "'"
        Dim Comando As New MySqlCommand(Query, Conexion)
        Comando.ExecuteNonQuery()
        Conexion.Close()


        Conexion.Open()
        Dim QueryDos As String = "DELETE FROM `clinica_paciente` WHERE  `id_clinica`='" & clinica.Id & "'"
        Dim ComandoDos As New MySqlCommand(QueryDos, Conexion)
        ComandoDos.ExecuteNonQuery()
        Conexion.Close()


        Conexion.Open()
        Dim QueryTres As String = "DELETE FROM `clinica` WHERE  `id`='" & clinica.Id & "'"
        Dim ComandoTres As New MySqlCommand(QueryTres, Conexion)
        ComandoTres.ExecuteNonQuery()
        Conexion.Close()


    End Sub

    Public Function Listar() As DataSet

        Dim Conexion As New MySqlConnection(_cadenaConexion)
        Conexion.Open()

        Dim Adaptador As MySqlDataAdapter
        Dim dataSet As New DataSet


        Dim Query As String = "Select * from clinica ;"
        Adaptador = New MySqlDataAdapter(Query, Conexion)
        Adaptador.Fill(dataSet)

        Return dataSet

    End Function


End Class
