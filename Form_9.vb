Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Form_9
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim datos As String = "SELECT COUNT(*) FROM LOGIN WHERE USUARIO ='" & txtusuario.Text & "' and CONTRASENA ='" & txtcontrasena.Text & "' "
            comando = New SqlCommand(datos, conexion)
            comando.CommandType = CommandType.Text
            Dim n = comando.ExecuteScalar()
            If (n > 0) Then
                MsgBox("INICIO DE SESION CORRECTO" & n)
            Else
                MsgBox("USUARIO NO EXISTE" & n)

            End If

        Catch ex As Exception
            MsgBox("ERROR")
        End Try






    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlace()
        lb1.Text = estado
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_10.Show()
    End Sub




End Class
