Imports MySql.Data.MySqlClient
Imports entidades

Public Class pacienteDatos

    Private _cadenaConexion As String = "Server=127.0.0.1;User=root;Password=123456;Port=3306;database=clinica_system"


    Public Sub Insertar(ByVal paciente As EPaciente)

        Dim Conexion As New MySqlConnection(_cadenaConexion)
        Conexion.Open()
        Dim Query As String = "INSERT INTO `paciente` (`nro_historia_clinica` ,`nombre`) VALUES ('" & paciente.NroHistoriaClinica & "', '" & paciente.Nombre & "');"
        Dim Comando As New MySqlCommand(Query, Conexion)
        Comando.ExecuteNonQuery()
        Conexion.Close()


    End Sub


    Public Function Listar() As DataSet

        Dim Conexion As New MySqlConnection(_cadenaConexion)
        Conexion.Open()

        Dim Adaptador As MySqlDataAdapter
        Dim dataSet As New DataSet


        Dim Query As String = "SELECT * FROM `paciente`;"
        Adaptador = New MySqlDataAdapter(Query, Conexion)
        Adaptador.Fill(dataSet)

        Return dataSet

    End Function

End Class
