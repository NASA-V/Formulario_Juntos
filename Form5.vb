Imports System.Data
Imports System.Data.SqlClient
Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Try
            Dim consulta As String = "INSERT INTO Usuario VALUES(@Usuario, @Contraseña)"
            comando = New SqlClient.SqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@Usuario", TxtUsuario.Text.ToUpper)
            comando.Parameters.AddWithValue("@Contraseña", TxtContraseña.Text.ToUpper)
            comando.ExecuteNonQuery()
            MsgBox("Listo se a registrado exitosamente")
        Catch ex As Exception
            MsgBox("Error no se puede registrar")

        End Try

        Me.Hide()




    End Sub


End Class