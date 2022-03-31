Imports System.ComponentModel
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports PdfSharp.Drawing
Imports System.Data

Imports System.Text
Imports System.Data.OleDb
Imports System.IO
Imports System.Drawing.Bitmap
Public Class Form_24
    Public cnn As New SqlConnection
    Public boton(99) As Button
    Public botonborrar(99) As Button
    Public ID(99) As Label
    Public superf3(99) As Label
    Public descrpcionf3(99) As Label
    Public preciof3(99) As Label
    Public imagex(99) As Label
    Public vertical As Integer = 85
    Public horizontal As Integer = 300
    Public verticalimg As Integer = 85
    Public horizontalimg As Integer = 200

    Public busca As Integer = 0
    Public n As Integer = 0
    Public car As Integer = 1
    Public nuevon As Integer = 0
    Public super(99) As Label
    Public descrpcion(99) As Label
    Public precio(99) As Label
    Public disponible(99) As Label
    Public x As Integer = 1
    Public almacena(99) As String
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
        ' PictureBox1.Image = Image.FromFile("C:\Users\alexa\Desktop\Proyecto comparador de producto\ComparadorDeProductos\ComparadorDeProductos\img\LechePinito1.jpg")

        Try
            Dim datos As New SqlDataAdapter("SELECT * FROM Articulos  WHERE Nombre='" & txtbusqueda.Text & "'", conexion)
            Dim ds As New DataSet()
            datos.Fill(ds, "Articulos")


            Dim a = 0
            For x = 1 To 6



                imagex(x) = New Label
                imagex(x).Image = System.Drawing.Image.FromFile(ds.Tables("Articulos").Rows(a).Item(3))
                imagex(x).Size = New Size(100, 100)
                imagex(x).Location = New Point(horizontalimg, verticalimg)
                Me.Controls.Add(imagex(x))



                ID(x) = New Label
                ID(x).Text = ds.Tables("Articulos").Rows(a).Item(2)
                ID(x).TextAlign = ContentAlignment.MiddleCenter
                ID(x).BorderStyle = BorderStyle.FixedSingle
                ID(x).Font = New Font("Arial", 10, FontStyle.Bold)
                ID(x).Location = New Point(horizontal + 120, vertical)

                Me.Controls.Add(ID(x))
                '  Me.Controls.Add(panel)
                superf3(x) = New Label
                superf3(x).Text = ds.Tables("Articulos").Rows(a).Item(4)
                superf3(x).TextAlign = ContentAlignment.MiddleCenter
                superf3(x).BorderStyle = BorderStyle.FixedSingle
                superf3(x).Font = New Font("Arial", 10, FontStyle.Bold)
                superf3(x).Location = New Point(horizontal, vertical)
                Me.Controls.Add(superf3(x))
                vertical = vertical + 30

                descrpcionf3(x) = New Label
                descrpcionf3(x).Text = ds.Tables("Articulos").Rows(a).Item(0)
                descrpcionf3(x).TextAlign = ContentAlignment.MiddleCenter
                descrpcionf3(x).BorderStyle = BorderStyle.FixedSingle
                descrpcionf3(x).Font = New Font("Arial", 10, FontStyle.Bold)
                descrpcionf3(x).Location = New Point(horizontal, vertical)
                Me.Controls.Add(descrpcionf3(x))
                vertical = vertical + 30

                preciof3(x) = New Label
                preciof3(x).Text = ds.Tables("Articulos").Rows(a).Item(1)
                preciof3(x).TextAlign = ContentAlignment.MiddleCenter
                preciof3(x).BorderStyle = BorderStyle.FixedSingle
                preciof3(x).Font = New Font("Arial", 10, FontStyle.Bold)
                preciof3(x).Location = New Point(horizontal, vertical)
                Me.Controls.Add(preciof3(x))
                vertical = vertical + 30

                boton(x) = New Button
                boton(x).Text = "carrito"
                boton(x).Width = 60
                boton(x).Height = 30
                boton(x).Location = New Point(horizontal, vertical)
                Me.Controls.Add(boton(x))

                botonborrar(x) = New Button
                botonborrar(x).Text = "quitar"
                botonborrar(x).Width = 60
                botonborrar(x).Height = 30
                botonborrar(x).Location = New Point(horizontal + 70, vertical)
                Me.Controls.Add(botonborrar(x))

                a = a + 1
                horizontal = horizontal + 300
                horizontalimg = horizontalimg + 300
                vertical = vertical - 90
                If x Mod 2 = 0 Then
                    horizontal = 300
                    horizontalimg = 200
                    vertical = vertical + 150
                    verticalimg = verticalimg + 150

                End If
                Select Case x
                    Case 1
                        AddHandler boton(1).Click, AddressOf Me.accion1
                        AddHandler botonborrar(1).Click, AddressOf Me.accionb1
                    Case 2
                        AddHandler boton(2).Click, AddressOf Me.accion2
                    Case 3
                        AddHandler boton(3).Click, AddressOf Me.accion3
                    Case 4
                        AddHandler boton(4).Click, AddressOf Me.accion4
                    Case 5
                        AddHandler boton(5).Click, AddressOf Me.accion5
                    Case 6
                        AddHandler boton(6).Click, AddressOf Me.accion6
                    Case Else

                End Select

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

    Private Sub accionb1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        For c = 1 To 99
            If almacena(c) = ID(1).Text Then
                almacena(c) = 0
                txt1.Text = txt1.Text & almacena(c)
                c = 100
            End If

        Next



    End Sub
    Private Sub accion1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        For c = 1 To 99
            If almacena(c) = "" Then
                almacena(c) = ID(1).Text
                txt1.Text = txt1.Text & almacena(c)
                c = 100
            End If

        Next



    End Sub



    Private Sub accion2(ByVal sender As System.Object, ByVal e As System.EventArgs)

        For c = 1 To 99
            If almacena(c) = "" Then
                almacena(c) = ID(2).Text
                txt1.Text = txt1.Text & almacena(c)
                c = 100
            End If

        Next


    End Sub
    Private Sub accion3(ByVal sender As System.Object, ByVal e As System.EventArgs)

        For c = 1 To 99
            If almacena(c) = "" Then
                almacena(c) = ID(3).Text
                txt1.Text = txt1.Text & almacena(c)
                c = 100
            End If

        Next


    End Sub
    Private Sub accion4(ByVal sender As System.Object, ByVal e As System.EventArgs)

        For c = 1 To 99
            If almacena(c) = "" Then
                almacena(c) = ID(4).Text
                txt1.Text = txt1.Text & almacena(c)
                c = 100
            End If

        Next


    End Sub
    Private Sub accion5(ByVal sender As System.Object, ByVal e As System.EventArgs)

        For c = 1 To 99
            If almacena(c) = "" Then
                almacena(c) = ID(5).Text
                txt1.Text = txt1.Text & almacena(c)
                c = 100
            End If

        Next


    End Sub
    Private Sub accion6(ByVal sender As System.Object, ByVal e As System.EventArgs)

        For c = 1 To 99
            If almacena(c) = "" Then
                almacena(c) = ID(6).Text
                txt1.Text = txt1.Text & almacena(c)
                c = 100
            End If

        Next


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        horizontal = 300
        verticalimg = 85
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


        For i = 1 To n
            If busca > 0 Then
                If superf3(i).Text <> "" Then
                    superf3(i).Visible = False
                    descrpcionf3(i).Visible = False
                    preciof3(i).Visible = False
                    ID(i).Visible = False
                    boton(i).Visible = False
                    imagex(i).Visible = False

                End If
            End If

        Next

        Dim datos As String = "Select COUNT(*) FROM ARTICULO WHERE Nombre ='" & txtbusqueda.Text & "'"
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


    Private Sub carrito_Click(sender As Object, e As EventArgs)
        txt1.Text = ID(1).Text

    End Sub

    Private Sub carrito1_Click(sender As Object, e As EventArgs)
        Form_26.Show()
    End Sub

    Public Sub almcarrito()



    End Sub

    Private Sub totalcarr_Click(sender As Object, e As EventArgs) Handles totalcarr.Click


        Form_26.Show()
        Form_26.Form5_Load(e, e)
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub txt1_TextChanged(sender As Object, e As EventArgs) Handles txt1.TextChanged

    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles BindingSource1.CurrentChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click


    End Sub

End Class