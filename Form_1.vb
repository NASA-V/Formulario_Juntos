Imports System.Windows
Imports System.Windows.Controls

Public Class Form_1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.AutoScroll = False
        Panel1.HorizontalScroll.Enabled = False
        Panel1.HorizontalScroll.Visible = False
        Panel1.HorizontalScroll.Maximum = 0
        Panel1.AutoScroll = True

    End Sub

    Private Sub CatalogoToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub CelealesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LineaBlancaToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Nombre_Leche2.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub LechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LechaToolStripMenuItem.Click
        'article atributes
        Nombre_leche1.Visible = True
        Button5.Visible = True
        TextBox11.Visible = True
        Label12.Visible = True

        Nombre_Leche2.Visible = True
        Button2.Visible = True
        TextBox8.Visible = True
        Label11.Visible = True

        Button3.Hide()
        TextBox9.Hide()
        Label10.Hide()

        TextBox12.Hide()
        Button6.Hide()
        Label12.Hide()

        Button4.Hide()
        Label9.Hide()
        TextBox10.Hide()




        'article names
        Nombre_leche1.Hide()
        Nombre_Leche2.Visible = False
        Label4.Visible = False
        Label7.Visible = False
        Label3.Visible = False
        Label8.Visible = False











    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs)

    End Sub
End Class
