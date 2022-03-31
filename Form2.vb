Imports System.Data
Imports System.Data.SqlClient
Public Class Form2
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub actualizartabla()
        Dim actualiza As String = "update Perfil set Nombre='" & TextBox1.Text & "', Apellidos='" & TextBox2.Text & "', Telefono='" & TextBox3.Text & "' Usuario='" & TextBox4.Text & "' Correo Electronico='" & TextBox5.Text
        comando = New SqlCommand(actualiza, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        MsgBox("Sus datos an sido actualizados")




    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        actualizartabla()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class