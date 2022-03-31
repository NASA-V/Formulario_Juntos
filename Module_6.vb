Imports System.Data.Sql
Imports System.Data.SqlClient

Module Module_6

    Public conexion As New SqlConnection
    Public comando As New SqlCommand
    Public estado As String

    Sub enlace()
        Try
            conexion.ConnectionString = "Data Source=DMC;Initial Catalog=Aplicacion_Productos;Integrated Security=True"
            conexion.Open()
            estado = "Conectado"
        Catch ex As Exception
            estado = "Desconectado"
        End Try
    End Sub

End Module