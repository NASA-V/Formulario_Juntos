Public Class Form_4


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
    End Sub
    Private Sub Limpiar()
        PictureBox1.Image = PictureBox7.Image
        Label13.Text = ""
        Label1.Text = ""
        Label7.Text = ""
        Carrito1.Visible = False
        PictureBox2.BackgroundImage = PictureBox7.Image
        Label14.Text = ""
        Label2.Text = ""
        Label8.Text = ""
        Carrito3.Visible = False
        PictureBox3.Image = PictureBox7.Image
        Label15.Text = ""
        Label3.Text = " "
        Label9.Text = ""
        Carrito5.Visible = False
        PictureBox4.BackgroundImage = PictureBox7.Image
        Label16.Text = ""
        Label4.Text = ""
        Label10.Text = ""
        Carrito2.Visible = False
        PictureBox5.Image = PictureBox7.Image
        Label17.Text = ""
        Label5.Text = ""
        Label11.Text = ""
        Carrito4.Visible = False
        PictureBox6.BackgroundImage = PictureBox7.Image
        Label18.Text = ""
        Label6.Text = ""
        Label12.Text = ""
        Carrito6.Visible = False
    End Sub
    Private Sub Agua()

        Dim Img1 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\AguaBotella2.jpg")
        Dim valor0 As Integer

        PictureBox1.Image = Img1
        Label13.Text = "Pali"
        Label1.Text = "Agua 1L"
        Label7.Text = "2345"
        Carrito1.Visible = True

        Dim Img2 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\AguaBotella2.jpg")
        PictureBox2.BackgroundImage = Img2
        Label14.Text = "Mega"
        Label2.Text = "Agua 1L"
        Label8.Text = "2000"
        Carrito3.Visible = True
        Dim Img3 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\AguaBotella2.jpg")
        PictureBox3.Image = Img3
        Label15.Text = "Maxi"
        Label3.Text = "Agua 1L"
        Label9.Text = "2100"
        Carrito5.Visible = True
        Dim Img4 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\AguaBotella2.jpg")
        PictureBox4.BackgroundImage = Img4
        Label16.Text = "Hatillo"
        Label4.Text = "Agua 1L"
        Label10.Text = "1200"
        Carrito2.Visible = True
        Dim Img5 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\AguaBotella2.jpg")
        PictureBox5.Image = Img5
        Label17.Text = "Walmart"
        Label5.Text = "Agua 1L"
        Label11.Text = "2000"
        Carrito4.Visible = True
        Dim Img6 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\AguaBotella2.jpg")
        PictureBox6.BackgroundImage = Img6
        Label18.Text = " Chino"
        Label6.Text = "Agua 1L"
        Label12.Text = "1000"
        Carrito6.Visible = True

    End Sub
    Private Sub Arroz()

    End Sub
    Private Sub Azucar()

    End Sub
    Private Sub Cafe()

    End Sub
    Private Sub Celulares()

        Dim Img1 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\Celular2.jpg")
        PictureBox1.Image = Img1
        Label13.Text = "Pali"
        Label1.Text = "Nokia c4"
        Label7.Text = "236475"
        Carrito1.Visible = True
        Dim Img2 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\Celular2.jpg")
        PictureBox2.BackgroundImage = Img2
        Label14.Text = "Mega"
        Label2.Text = "one plus 4"
        Label8.Text = "367786"
        Carrito3.Visible = True
        Dim Img3 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\Celular2.jpg")
        PictureBox3.Image = Img3
        Label15.Text = "Maxi"
        Label3.Text = "Xiaomi 45"
        Label9.Text = "197665"
        Carrito5.Visible = True
        Dim Img4 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\Celular2.jpg")
        PictureBox4.BackgroundImage = Img4
        Label16.Text = "Hatillo"
        Label4.Text = "Poco f5"
        Label10.Text = "256456"
        Carrito2.Visible = True
        Dim Img5 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\Celular2.jpg")
        PictureBox5.Image = Img5
        Label17.Text = "Walmart"
        Label5.Text = "Nokia 8"
        Label11.Text = "206770"
        Carrito4.Visible = True
        'Dim Img6 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\")
        'PictureBox6.BackgroundImage = Img6
        Label18.Text = " "
        'Label6.Text = ""
        'Label12.Text = ""
        'Button6.Visible = True
    End Sub
    Private Sub Consolas()

    End Sub
    Private Sub Desinfectantes()

    End Sub
    Private Sub Huevo()

    End Sub
    Private Sub Jabon()

    End Sub
    Private Sub jamon()

    End Sub
    Private Sub Juegos()

    End Sub
    Private Sub Lactocrema()

    End Sub
    Private Sub Leche()

        Dim Img1 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\LechePinito1.jpg")
        PictureBox1.Image = Img1
        Label13.Text = "Pali"
        Label1.Text = "Leche 1L"
        Label17.Text = "2345"
        Carrito1.Visible = True
        Dim Img2 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\LechePinito1.jpg")
        PictureBox2.BackgroundImage = Img2
        Label14.Text = "Mega"
        Label2.Text = "Leche 1L"
        Label8.Text = "2000"
        Carrito3.Visible = True
        Dim Img3 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\LechePinito1.jpg")
        PictureBox3.Image = Img3
        Label15.Text = "Maxi"
        Label3.Text = "Leche 1L"
        Label9.Text = "2100"
        Carrito5.Visible = True
        Dim Img4 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\LechePinito1.jpg")
        PictureBox4.BackgroundImage = Img4
        Label16.Text = "Hatillo"
        Label4.Text = "Leche 1L"
        Label10.Text = "2000"
        Carrito2.Visible = True
        Dim Img5 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\LechePinito1.jpg")
        PictureBox5.Image = Img5
        Label17.Text = "Walmart"
        Label5.Text = "Leche 1L"
        Label11.Text = "2000"
        Carrito4.Visible = True
        Dim Img6 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\LechePinito1.jpg")
        PictureBox6.BackgroundImage = Img6
        Label18.Text = " Chino"
        Label6.Text = "Leche 1L"
        Label12.Text = "2000"
        Carrito6.Visible = True
    End Sub
    Private Sub Libros()

    End Sub
    Private Sub LineaBlanca()

        Dim Img1 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\Cocina1.jpg")
        PictureBox1.Image = Img1
        Label13.Text = "Pali"
        Label1.Text = "Cocina"
        Label7.Text = "234556"
        Carrito1.Visible = True
        Dim Img2 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\Cocina2.jpg")
        PictureBox2.BackgroundImage = Img2
        Label14.Text = "Mega"
        Label2.Text = "Cocina"
        Label8.Text = "256000"
        Carrito3.Visible = True
        Dim Img3 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\Cocina3.jpg")
        PictureBox3.Image = Img3
        Label15.Text = "Maxi"
        Label3.Text = "Cocina "
        Label9.Text = "217800"
        Carrito5.Visible = True
        ' Dim Img4 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\.jpg")
        'PictureBox4.BackgroundImage = Img4
        Label16.Text = ""
        Label4.Text = ""
        Label10.Text = ""
        'Button4.Visible = True
        'Dim Img5 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\jpg")
        'PictureBox5.Image = Img5
        Label17.Text = ""
        Label5.Text = ""
        Label11.Text = ""
        'Button5.Visible = True
        'Dim Img6 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\.jpg")
        'PictureBox6.BackgroundImage = Img6
        Label18.Text = " "
        Label6.Text = ""
        Label12.Text = ""
    End Sub
    Private Sub Natilla()

    End Sub
    Private Sub Pan()

        Dim Img1 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\Pan1.jpg")
        PictureBox1.Image = Img1

        Label13.Text = "Pali"
        Label1.Text = "Pan"
        Label7.Text = "655"
        Carrito1.Visible = True
        Dim Img2 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\Pan2.jpg")
        PictureBox2.BackgroundImage = Img2
        Label14.Text = "Mega"
        Label2.Text = "Pan"
        Label8.Text = "1000"
        Carrito3.Visible = True
        Dim Img3 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\Pan1.jpg")
        PictureBox3.Image = Img3
        Label3.Text = "Pan"
        Label9.Text = "2100"
        Carrito5.Visible = True
        'Dim Img4 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\LechePinito1.jpg")
        'PictureBox4.BackgroundImage = Img4
        Label16.Text = ""
        ' Label4.Text = "Leche 1L"
        ' Label10.Text = "2000"
        'Button4.Visible = True

        ' Dim Img5 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\LechePinito1.jpg")
        ' PictureBox5.Image = Img5
        Label17.Text = ""
        ' Label5.Text = "Leche 1L"
        ' Label11.Text = "2000"
        'Button5.Visible = True
        '  Dim Img6 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\LechePinito1.jpg")
        '  PictureBox6.BackgroundImage = Img6
        Label18.Text = " "
        ' Label6.Text = "Leche 1L"
        '  Label12.Text = "2000"
        'Button6.Visible = True
    End Sub
    Private Sub Queso()

    End Sub
    Private Sub Pastadedientes()

    End Sub
    Private Sub Ropa()

    End Sub
    Private Sub Sal()

    End Sub

    Private Sub PanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PanToolStripMenuItem.Click
        Limpiar()
        Pan()

    End Sub

    Private Sub AguaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AguaToolStripMenuItem.Click
        Limpiar()
        Agua()

    End Sub

    Private Sub CelularesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CelularesToolStripMenuItem.Click
        Limpiar()
        Celulares()


    End Sub

    Private Sub LineaBlancaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LineaBlancaToolStripMenuItem.Click
        Limpiar()
        LineaBlanca()

    End Sub

    Private Sub LecheToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LecheToolStripMenuItem.Click
        Limpiar()
        Leche()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Carrito1.Click
        Module_1.Img1 = PictureBox1.Image
        Dim f2 As New Form_5
        f2.Show()
    End Sub

    Private Sub Carrito2_Click(sender As Object, e As EventArgs) Handles Carrito2.Click
        Module_1.Img2 = PictureBox1.Image
        Dim f2 As New Form_5
        f2.Show()
    End Sub

    Private Sub Carrito5_Click(sender As Object, e As EventArgs) Handles Carrito5.Click
        Module_1.Img5 = PictureBox1.Image
        Dim f2 As New Form_5
        f2.Show()
    End Sub

    Private Sub Carrito3_Click(sender As Object, e As EventArgs) Handles Carrito3.Click
        Module_1.Img3 = PictureBox1.Image
        Dim f2 As New Form_5
        f2.Show()
    End Sub

    Private Sub Carrito4_Click(sender As Object, e As EventArgs) Handles Carrito4.Click
        Module_1.Img4 = PictureBox1.Image
        Dim f2 As New Form_5
        f2.Show()
    End Sub

    Private Sub Carrito6_Click(sender As Object, e As EventArgs) Handles Carrito6.Click
        Module_1.Img6 = PictureBox1.Image
        Dim f2 As New Form_5
        f2.Show()
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        Label19.Image = PictureBox1.Image
    End Sub

    Private Sub Carrito0_Click(sender As Object, e As EventArgs) Handles Carrito0.Click

    End Sub
End Class