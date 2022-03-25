Public Class Form_20

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
    End Sub
    Private Sub Limpiar()
        PictureBox1.Image = PictureBox7.Image
        Label13.Text = ""
        Label1.Text = ""
        Label7.Text = ""
        Button1.Visible = False
        PictureBox2.BackgroundImage = PictureBox7.Image
        Label14.Text = ""
        Label2.Text = ""
        Label8.Text = ""
        Button2.Visible = False
        PictureBox3.Image = PictureBox7.Image
        Label15.Text = ""
        Label3.Text = " "
        Label9.Text = ""
        Button3.Visible = False
        PictureBox4.BackgroundImage = PictureBox7.Image
        Label16.Text = ""
        Label4.Text = ""
        Label10.Text = ""
        Button4.Visible = False
        PictureBox5.Image = PictureBox7.Image
        Label17.Text = ""
        Label5.Text = ""
        Label11.Text = ""
        Button5.Visible = False
        PictureBox6.BackgroundImage = PictureBox7.Image
        Label18.Text = ""
        Label6.Text = ""
        Label12.Text = ""
        Button6.Visible = False
    End Sub
    Private Sub Agua()

        Dim Img1 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\AguaBotella1.jpg")
        PictureBox1.Image = Img1
        Label13.Text = "Pali"
        Label1.Text = "Agua 1L"
        Label7.Text = "2345"
        Button1.Visible = True
        Dim Img2 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\AguaBotella1.jpg")
        PictureBox2.BackgroundImage = Img2
        Label14.Text = "Mega"
        Label2.Text = "Agua 1L"
        Label8.Text = "2000"
        Button2.Visible = True
        Dim Img3 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\AguaBotella1.jpg")
        PictureBox3.Image = Img3
        Label15.Text = "Maxi"
        Label3.Text = "Agua 1L"
        Label9.Text = "2100"
        Button3.Visible = True
        Dim Img4 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\AguaBotella1.jpg")
        PictureBox4.BackgroundImage = Img4
        Label16.Text = "Hatillo"
        Label4.Text = "Agua 1L"
        Label10.Text = "1200"
        Button4.Visible = True
        Dim Img5 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\AguaBotella1.jpg")
        PictureBox5.Image = Img5
        Label17.Text = "Walmart"
        Label5.Text = "Agua 1L"
        Label11.Text = "2000"
        Button5.Visible = True
        Dim Img6 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\AguaBotella1.jpg")
        PictureBox6.BackgroundImage = Img6
        Label18.Text = " Chino"
        Label6.Text = "Agua 1L"
        Label12.Text = "1000"
        Button6.Visible = True
    End Sub
    Private Sub Arroz()

    End Sub
    Private Sub Azucar()

    End Sub
    Private Sub Cafe()

    End Sub
    Private Sub Celulares()

        Dim Img1 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\Celular1.jpg")
        PictureBox1.Image = Img1
        Label13.Text = "Pali"
        Label1.Text = "Nokia c4"
        Label7.Text = "236475"
        Button1.Visible = True
        Dim Img2 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\Celular2.jpg")
        PictureBox2.BackgroundImage = Img2
        Label14.Text = "Mega"
        Label2.Text = "one plus 4"
        Label8.Text = "367786"
        Button2.Visible = True
        Dim Img3 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\Celular3.jpg")
        PictureBox3.Image = Img3
        Label15.Text = "Maxi"
        Label3.Text = "Xiaomi 45"
        Label9.Text = "197665"
        Button3.Visible = True
        Dim Img4 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\Celular2.jpg")
        PictureBox4.BackgroundImage = Img4
        Label16.Text = "Hatillo"
        Label4.Text = "Poco f5"
        Label10.Text = "256456"
        Button4.Visible = True
        Dim Img5 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\Celular3.jpg")
        PictureBox5.Image = Img5
        Label17.Text = "Walmart"
        Label5.Text = "Nokia 8"
        Label11.Text = "206770"
        Button5.Visible = True
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
        Label7.Text = "2345"
        Button1.Visible = True
        Dim Img2 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\LechePinito1.jpg")
        PictureBox2.BackgroundImage = Img2
        Label14.Text = "Mega"
        Label2.Text = "Leche 1L"
        Label8.Text = "2000"
        Button2.Visible = True
        Dim Img3 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\LechePinito1.jpg")
        PictureBox3.Image = Img3
        Label15.Text = "Maxi"
        Label3.Text = "Leche 1L"
        Label9.Text = "2100"
        Button3.Visible = True
        Dim Img4 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\LechePinito1.jpg")
        PictureBox4.BackgroundImage = Img4
        Label16.Text = "Hatillo"
        Label4.Text = "Leche 1L"
        Label10.Text = "2000"
        Button4.Visible = True
        Dim Img5 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\LechePinito1.jpg")
        PictureBox5.Image = Img5
        Label17.Text = "Walmart"
        Label5.Text = "Leche 1L"
        Label11.Text = "2000"
        Button5.Visible = True
        Dim Img6 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\LechePinito1.jpg")
        PictureBox6.BackgroundImage = Img6
        Label18.Text = " Chino"
        Label6.Text = "Leche 1L"
        Label12.Text = "2000"
        Button6.Visible = True
    End Sub
    Private Sub Libros()

    End Sub
    Private Sub LineaBlanca()

        Dim Img1 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\Cocina1.jpg")
        PictureBox1.Image = Img1
        Label13.Text = "Pali"
        Label1.Text = "Cocina"
        Label7.Text = "234556"
        Button1.Visible = True
        Dim Img2 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\Cocina2.jpg")
        PictureBox2.BackgroundImage = Img2
        Label14.Text = "Mega"
        Label2.Text = "Cocina"
        Label8.Text = "256000"
        Button2.Visible = True
        Dim Img3 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\Cocina3.jpg")
        PictureBox3.Image = Img3
        Label15.Text = "Maxi"
        Label3.Text = "Cocina "
        Label9.Text = "217800"
        Button3.Visible = True
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
        Button1.Visible = True
        Dim Img2 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\Pan2.jpg")
        PictureBox2.BackgroundImage = Img2
        Label14.Text = "Mega"
        Label2.Text = "Pan"
        Label8.Text = "1000"
        Button2.Visible = True
        Dim Img3 As Image = Image.FromFile("C:\Users\imagenesdeproyecto\Pan1.jpg")
        PictureBox3.Image = Img3
        Label3.Text = "Pan"
        Label9.Text = "2100"
        Button3.Visible = True
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
End Class