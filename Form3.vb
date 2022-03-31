Imports System.Data
Imports System.Data.SqlClient
Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlace()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim actualiza As String = "update Usuario set Contraseña='" & TextBox2.Text
        comando = New SqlCommand(actualiza, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        MsgBox("Sus datos an sido actualizados")
    End Sub
End Class