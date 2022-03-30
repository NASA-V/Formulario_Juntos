Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Form_23

    Public superf3(99) As Label
    Public descrpcionf3(99) As Label
    Public preciof3(99) As Label
    Public vertical As Integer = 85
    Public horizontal As Integer = 450
    Public busca As Integer = 0
    Public n As Integer = 0
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        hidesubmenu()
        'Panel7.Visible = False
        ' Panel6.Visible = False
        ' Panel4.Visible = False
    End Sub

    Public Sub showsubmenu(submenu As Panel)
        If submenu.Visible = False Then
            hidesubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False

        End If









    End Sub





    Public Sub hidesubmenu()

        Panel3.Visible = False

    End Sub

    Private Sub CatálogoToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)


        OpenFileDialog1.InitialDirectory = "C:\Users\alexa\Desktop\Proyecto comparador de producto\Imagenes\img1.jpg"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            '  pb1.Image = Image.FromFile(OpenFileDialog1.FileName)
            ' pb2.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If

    End Sub

    Public Sub filtro()
        Dim resultado As String = txtbusqueda.Text
        ' If (resultado = "leche") Then
        ' Leche()
        PictureBox1.Image = Image.FromFile("C:\Users\alexa\Desktop\Proyecto comparador de producto\ComparadorDeProductos\ComparadorDeProductos\img\LechePinito1.jpg")

        Try
                Dim datos As New SqlDataAdapter("SELECT * FROM Articulos  WHERE Nombre='" & txtbusqueda.Text & "'", conexion)
                Dim ds As New DataSet()
                datos.Fill(ds, "Articulos")

            Dim a = 0
            For x = 1 To 6

                superf3(x) = New Label
                superf3(x).Text = ds.Tables("Articulos").Rows(a).Item(1)
                    superf3(x).TextAlign = ContentAlignment.MiddleCenter
                    superf3(x).BorderStyle = BorderStyle.FixedSingle
                    superf3(x).Font = New Font("Arial", 10, FontStyle.Bold)
                    superf3(x).Location = New Point(horizontal, vertical)
                    Me.Controls.Add(superf3(x))
                vertical = vertical + 30

                descrpcionf3(x) = New Label
                    descrpcionf3(x).Text = ds.Tables("Articulos").Rows(a).Item(2)
                    descrpcionf3(x).TextAlign = ContentAlignment.MiddleCenter
                    descrpcionf3(x).BorderStyle = BorderStyle.FixedSingle
                    descrpcionf3(x).Font = New Font("Arial", 10, FontStyle.Bold)
                    descrpcionf3(x).Location = New Point(horizontal, vertical)
                    Me.Controls.Add(descrpcionf3(x))
                vertical = vertical + 30

                preciof3(x) = New Label
                    preciof3(x).Text = ds.Tables("Articulos").Rows(a).Item(3)
                    preciof3(x).TextAlign = ContentAlignment.MiddleCenter
                    preciof3(x).BorderStyle = BorderStyle.FixedSingle
                    preciof3(x).Font = New Font("Arial", 10, FontStyle.Bold)
                    preciof3(x).Location = New Point(horizontal, vertical)
                    Me.Controls.Add(preciof3(x))
                    a = a + 1
                    horizontal = horizontal + 300
                    vertical = vertical - 60
                If x = 2 Or x = 4 Or x = 6 Then
                    horizontal = 450
                    vertical = vertical + 150
                End If

                n = x

            Next

            Catch ex As Exception
                MsgBox("Id no existe")
                ' txt1.Text = "Id ya existe " & ex.Message
            End Try


        '  End If
    End Sub
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Limpiar()
        filtro()
        busca = busca + 1
        vertical = 85
        horizontal = 450
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        showsubmenu(Panel3)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        hidesubmenu()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        hidesubmenu()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        hidesubmenu()
    End Sub



    Private Sub Limpiar()

        For x = 1 To n
            If busca > 0 Then
                If superf3(x).Text <> "" Then
                    superf3(x).Visible = False
                    descrpcionf3(x).Visible = False
                    preciof3(x).Visible = False

                End If
            End If
        Next

        Dim datos As String = "SELECT COUNT(*) FROM ARTICULO WHERE Nombre ='" & txtbusqueda.Text & "'"
            Dim basedatos As SqlDataAdapter
            Dim tabla As New DataTable
            Try
            basedatos = New SqlDataAdapter(datos, conexion)
            basedatos.Fill(tabla)
            'Me.DataGridView = da
            ' DataGridView1.DataSource = tabla

            txt1.Text = String.Format("Total datos en la tabla:{0}", tabla.Rows.Count)


        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim Img As Image = Image.FromFile("C:\Users\gamer\Desktop\imagenes de proyecto\LechePinito1.jpg")
        'DataGridView1.Rows.Add("LechePinito1", Img)

        ' DataGridView1.CurrentRow.Cells("Leche").Value = Image.FromFile("C:\Users\gamer\Desktop\imagenes de proyecto\LechePinito1.jpg")
    End Sub

    Private Sub CatalogoToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub CelealesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LineaBlancaToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    ' Private Sub PanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PanToolStripMenuItem.Click
    'Limpiar()
    'Dim Img1 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\Pan1.jpg")
    'PictureBox1.Image = Img1
    ''Label1.Text = "Pan"
    'Label7.Text = "655"
    'Dim Img2 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\Pan2.jpg")
    'PictureBox2.BackgroundImage = Img2
    'Label2.Text = "Pan"
    'Label8.Text = "1000"
    'Dim Img3 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\Pan1.jpg")
    'PictureBox3.Image = Img3
    ''Label3.Text = "Pan"
    ' Label9.Text = "2100"
    'Dim Img4 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\LechePinito1.jpg")
    'PictureBox4.BackgroundImage = Img4
    ' Label4.Text = "Leche 1L"
    ' Label10.Text = "2000"
    ' Dim Img5 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\LechePinito1.jpg")
    ' PictureBox5.Image = Img5
    ' Label5.Text = "Leche 1L"
    ' Label11.Text = "2000"
    '  Dim Img6 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\LechePinito1.jpg")
    '  PictureBox6.BackgroundImage = Img6
    ' Label6.Text = "Leche 1L"
    '  Label12.Text = "2000"

    ' End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub


    ' Private Sub Leche()
    ' Limpiar()
    ' Dim Img1 As Image = Image.FromFile("C:\Users\alexa\Desktop\Proyecto comparador de producto\ComparadorDeProductos\ComparadorDeProductos\img\LechePinito1.jpg")
    ' PictureBox1.Image = Img1
    ' Label1.Text = "Leche 1L"
    ' Label7.Text = "2345"
    ' Dim Img2 As Image = Image.FromFile("C:\Users\alexa\Desktop\Proyecto comparador de producto\ComparadorDeProductos\ComparadorDeProductos\img\LechePinito1.jpg")
    ' PictureBox2.BackgroundImage = Img2
    ' Label2.Text = "Leche 1L"
    ' Label8.Text = "2000"
    ' Dim Img3 As Image = Image.FromFile("C:\Users\alexa\Desktop\Proyecto comparador de producto\ComparadorDeProductos\ComparadorDeProductos\img\LechePinito1.jpg")
    ' PictureBox3.Image = Img3
    ' Label3.Text = "Leche 1L"
    ' Label9.Text = "2100"
    '  Dim Img4 As Image = Image.FromFile("C:\Users\alexa\Desktop\Proyecto comparador de producto\ComparadorDeProductos\ComparadorDeProductos\img\LechePinito1.jpg")
    '  PictureBox4.BackgroundImage = Img4
    '  Label4.Text = "Leche 1L"
    '  Label10.Text = "2000"
    '   Dim Img5 As Image = Image.FromFile("C:\Users\alexa\Desktop\Proyecto comparador de producto\ComparadorDeProductos\ComparadorDeProductos\img\LechePinito1.jpg")
    ' PictureBox5.Image = Img5
    ' Label5.Text = "Leche 1L"
    '  Label11.Text = "2000"
    '  Dim Img6 As Image = Image.FromFile("C:\Users\alexa\Desktop\Proyecto comparador de producto\ComparadorDeProductos\ComparadorDeProductos\img\LechePinito1.jpg")
    '   PictureBox6.BackgroundImage = Img6
    '    Label6.Text = "Leche 1L"
    '     Label12.Text = "2000"
    '  End Sub

    '    Private Sub CelularesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CelularesToolStripMenuItem.Click
    '        Limpiar()
    '        Dim Img1 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\Celular1.jpg")
    '        PictureBox1.Image = Img1
    '        Label1.Text = "Nokia c4"
    '        Label7.Text = "236475"
    '        Dim Img2 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\Celular2.jpg")
    '        PictureBox2.BackgroundImage = Img2
    '        Label2.Text = "one plus 4"
    '        Label8.Text = "367786"
    '        Dim Img3 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\Celular3.jpg")
    '        PictureBox3.Image = Img3
    '        Label3.Text = "Xiaomi 45"
    '        Label9.Text = "197665"
    '        Dim Img4 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\Celular2.jpg")
    '        PictureBox4.BackgroundImage = Img4
    '        Label4.Text = "Poco f5"
    '        Label10.Text = "256456"
    '        Dim Img5 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\Celular3.jpg")
    '        PictureBox5.Image = Img5
    '        Label5.Text = "Nokia 8"
    '        Label11.Text = "206770"
    'Dim Img6 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\")
    'PictureBox6.BackgroundImage = Img6
    'Label6.Text = ""
    'Label12.Text = ""
    '
    '  End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        ' DataGridView1.CurrentRow.Cells("LechePinito1.jpg").Value = Image.FromFile("C:\Users\gamer\Desktop\imagenes de proyecto\LechePinito1.jpg")
    End Sub

    'Private Sub LineaBlancaToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LineaBlancaToolStripMenuItem.Click

    'End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    '   Private Sub AguaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AguaToolStripMenuItem.Click
    '       Limpiar()
    '       Dim Img1 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\AguaBotella1.jpg")
    '       PictureBox1.Image = Img1
    '       Label1.Text = "Agua 1L"
    '       Label7.Text = "2345"
    'v       Dim Img2 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\AguaBotella1.jpg")
    '       PictureBox2.BackgroundImage = Img2
    '       Label2.Text = "Agua 1L"
    '       Label8.Text = "2000"
    '       Dim Img3 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\AguaBotella1.jpg")
    '       PictureBox3.Image = Img3
    '       Label3.Text = "Agua 1L"
    'v       Label9.Text = "2100"
    '       Dim Img4 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\AguaBotella1.jpg")
    '       PictureBox4.BackgroundImage = Img4
    '       Label4.Text = "Agua 1L"
    '       Label10.Text = "1200"
    '       Dim Img5 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\AguaBotella1.jpg")
    '       PictureBox5.Image = Img5
    '       Label5.Text = "Agua 1L"
    '       Label11.Text = "2000"
    '       Dim Img6 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\AguaBotella1.jpg")
    '      PictureBox6.BackgroundImage = Img6
    '      Label6.Text = "Agua 1L"
    '      Label12.Text = "1000"
    '  End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LineaBlanca()
        Limpiar()

        'Dim Img1 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\Cocina1.jpg")
        ' PictureBox1.Image = Img1
        '  Label1.Text = "Cocina"
        ' Label7.Text = "234556"
        'Dim Img2 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\Cocina2.jpg")
        ' PictureBox2.BackgroundImage = Img2
        '  Label2.Text = "Cocina"
        ' Label8.Text = "256000"
        ' Dim Img3 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\Cocina3.jpg")
        'PictureBox3.Image = Img3
        '  Label3.Text = "Cocina "
        ' Label9.Text = "217800"
        ' Dim Img4 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\.jpg")
        'PictureBox4.BackgroundImage = Img4
        '  Label4.Text = ""
        ' Label10.Text = ""
        'Dim Img5 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\jpg")
        'PictureBox5.Image = Img5
        '  Label5.Text = ""
        '  Label11.Text = ""
        'Dim Img6 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\.jpg")
        'PictureBox6.BackgroundImage = Img6
        '   Label6.Text = ""
        '  Label12.Text = ""
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

        End Sub

        Private Sub PictureBox7_Click(sender As Object, e As EventArgs)

        End Sub

    Private Sub carrito_Click(sender As Object, e As EventArgs) Handles carrito.Click
        totalcarr.Text = totalcarr.Text & 1


    End Sub

    Private Sub carrito1_Click(sender As Object, e As EventArgs) Handles carrito1.Click

    End Sub


End Class