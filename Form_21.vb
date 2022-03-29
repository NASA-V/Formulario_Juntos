Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim st1 = txtusuario.Text
        Dim st2 = txtcontrasena.Text
        Try
            Dim datos As String = "SELECT COUNT(*) FROM [Aplicacion_Productos].[dbo].[Usuario] WHERE [Usuario] = '" + st1 + "' and [Contraseña] = '" + st2 + "'"
            'SELECT COUNT(*) FROM [Aplicacion_Productos].[dbo].[Usuario] WHERE [Usuario] = 'diego' and [Contraseña] = '1234'
            comando = New SqlCommand(datos, conexion)


            comando.CommandType = CommandType.Text
            Dim n = comando.ExecuteScalar()

            If (n > 0) Then
                MsgBox("INICIO DE SESION CORRECTO" & n)
                Form3.Show()
                Me.Hide()

            Else
                MsgBox("USUARIO NO EXISTE" & n)
            End If

        Catch ex As Exception
            MsgBox("ERROR" & st1 + st2)

        End Try


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlace()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Form3.Show()


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub
End Class
