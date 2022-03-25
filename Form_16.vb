Public Class Form_16
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x As String = txtNcontrasena.Text
        Dim n As String = txtCNcontrasena.Text
        If (x = n) Then
            Try
                Dim consulta As String = "INSERT INTO USUARIO VALUES(@USUARIO, @CONTRASENA)"
                comando = New SqlClient.SqlCommand(consulta, conexion)
                comando.Parameters.AddWithValue("@USUARIO", txtNusuario.Text.ToUpper)
                comando.Parameters.AddWithValue("@CONTRASENA", txtNcontrasena.Text.ToUpper)
                comando.ExecuteNonQuery()
                MsgBox("Usuario agregado")
                Form_15.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox("Id ya existe")
            End Try
        Else
            MsgBox("Contraseña incorrecta")
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_15.Show()
        Me.Hide()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class