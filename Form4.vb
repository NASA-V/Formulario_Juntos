Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlace()
        lb1.Text = estado


        Dim buscartabla As String = "SELECT * FROM ARTICULOS "
        Dim basedatos As SqlDataAdapter
        Dim tabla As New DataTable
        Try
            basedatos = New SqlDataAdapter(buscartabla, conexion)
            basedatos.Fill(tabla)
            'Me.DataGridView = da
            DataGridView1.DataSource = tabla

            ' txt1.Text = String.Format("Total datos en la tabla:{0}", tabla.Rows.Count)


        Catch ex As Exception
            '  txt1.Text = "Error: " & ex.Message
        End Try
    End Sub

    Public Sub Mostrartabla()

        Dim buscartabla As String = "SELECT * FROM Productos "
        Dim basedatos As SqlDataAdapter
        Dim tabla As New DataTable
        Try
            basedatos = New SqlDataAdapter(buscartabla, conexion)
            basedatos.Fill(tabla)
            'Me.DataGridView = da
            DataGridView1.DataSource = tabla

            ' txt1.Text = String.Format("Total datos en la tabla:{0}", tabla.Rows.Count)


        Catch ex As Exception
            '  txt1.Text = "Error: " & ex.Message
        End Try


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class