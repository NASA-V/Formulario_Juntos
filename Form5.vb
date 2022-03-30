Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Form5
    Public horizontal As Integer = 50
    Public vertical As Integer = 50
    Public supern(99) As Label
    Public image(99) As Label
    Public descrpcion(99) As Label
    Public precio(99) As Label
    Public botonsuma(99) As Button
    Public botonresta(99) As Button
    Public botonborrar(99) As Button
    Public campo(99) As TextBox
    Public total(99) As TextBox
    Public alamcenaid(99) As Integer
    Public restar As Integer = 0
    Public sumar As Integer = 0

    ' Public disponible(99) As Label
    'Dim TextBoxArray(6) As TextBox


    Public Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cargar

        For cargar = 1 To 20
            If Form3.almacena(cargar) > 0 Then
                alamcenaid(cargar) = Form3.almacena(cargar)
            End If
        Next

        vertical = 50
        Try


            Dim a = 0
            For x = 1 To 20
                If Form3.almacena(x) > 0 Then



                    Dim datos As New SqlDataAdapter("SELECT * FROM Articulos  WHERE _id='" & Form3.almacena(x) & "'", conexion)
                    Dim ds As New DataSet()
                    datos.Fill(ds, "Articulos")
                    TextBox1.Text = Form3.almacena(x)
                    image(x) = New Label
                    image(x).Image = System.Drawing.Image.FromFile(ds.Tables("Articulos").Rows(a).Item(3))
                    image(x).Size = New Size(100, 100)
                    image(x).Location = New Point(250, vertical)
                    Me.Controls.Add(image(x))

                    supern(x) = New Label
                    supern(x).Text = ds.Tables("Articulos").Rows(a).Item(4)
                    supern(x).TextAlign = ContentAlignment.MiddleCenter
                    supern(x).BorderStyle = BorderStyle.FixedSingle
                    supern(x).Font = New Font("Arial", 10, FontStyle.Bold)
                    supern(x).Location = New Point(horizontal, vertical)
                    Me.Controls.Add(supern(x))
                    vertical = vertical + 30

                    descrpcion(x) = New Label
                    descrpcion(x).Text = ds.Tables("Articulos").Rows(a).Item(0)
                    descrpcion(x).TextAlign = ContentAlignment.MiddleCenter
                    descrpcion(x).BorderStyle = BorderStyle.FixedSingle
                    descrpcion(x).Font = New Font("Arial", 10, FontStyle.Bold)
                    descrpcion(x).Location = New Point(horizontal, vertical)
                    Me.Controls.Add(descrpcion(x))
                    vertical = vertical + 30

                    precio(x) = New Label
                    precio(x).Text = ds.Tables("Articulos").Rows(a).Item(1)
                    precio(x).TextAlign = ContentAlignment.MiddleCenter
                    precio(x).BorderStyle = BorderStyle.FixedSingle
                    precio(x).Font = New Font("Arial", 10, FontStyle.Bold)
                    precio(x).Location = New Point(horizontal, vertical)
                    Me.Controls.Add(precio(x))
                    vertical = vertical + 30

                    botonresta(x) = New Button
                    botonresta(x).Text = "-"
                    botonresta(x).Width = 60
                    botonresta(x).Height = 20
                    botonresta(x).Location = New Point(100, vertical)
                    Me.Controls.Add(botonresta(x))


                    campo(x) = New TextBox
                    campo(x).Text = 1
                    campo(x).Location = New Point(180, vertical)

                    Me.Controls.Add(campo(x))

                    total(x) = New TextBox
                    total(x).Text = campo(x).Text * precio(x).Text
                    total(x).Location = New Point(400, vertical)

                    Me.Controls.Add(total(x))

                    botonsuma(x) = New Button
                    botonsuma(x).Text = "+"
                    botonsuma(x).Width = 60
                    botonsuma(x).Height = 20
                    botonsuma(x).Location = New Point(300, vertical)
                    Me.Controls.Add(botonsuma(x))

                    botonborrar(x) = New Button
                    botonborrar(x).Text = "borrar"
                    botonborrar(x).Width = 60
                    botonborrar(x).Height = 30
                    botonborrar(x).Location = New Point(600, vertical)
                    Me.Controls.Add(botonborrar(x))

                    vertical = vertical + 100


                    Select Case x
                        Case 1
                            AddHandler botonresta(1).Click, AddressOf Me.accion1
                            AddHandler botonsuma(1).Click, AddressOf Me.accions1
                            AddHandler botonborrar(1).Click, AddressOf Me.accionb1
                        Case 2
                            AddHandler botonresta(2).Click, AddressOf Me.accion2
                            AddHandler botonsuma(2).Click, AddressOf Me.accions2
                            AddHandler botonborrar(2).Click, AddressOf Me.accionb2
                        Case 3
                            AddHandler botonresta(3).Click, AddressOf Me.accion3
                            AddHandler botonsuma(3).Click, AddressOf Me.accions3
                            AddHandler botonborrar(3).Click, AddressOf Me.accionb3
                        Case 4
                            AddHandler botonresta(4).Click, AddressOf Me.accion4
                            AddHandler botonsuma(4).Click, AddressOf Me.accions4
                            AddHandler botonborrar(4).Click, AddressOf Me.accionb4
                        Case 5
                            AddHandler botonresta(5).Click, AddressOf Me.accion5
                            AddHandler botonsuma(5).Click, AddressOf Me.accions5
                            AddHandler botonborrar(5).Click, AddressOf Me.accionb5
                        Case 6
                            AddHandler botonresta(6).Click, AddressOf Me.accion6
                            AddHandler botonsuma(6).Click, AddressOf Me.accions6
                            AddHandler botonborrar(6).Click, AddressOf Me.accionb6
                        Case 7
                            AddHandler botonresta(7).Click, AddressOf Me.accion7
                            AddHandler botonsuma(7).Click, AddressOf Me.accions7
                            AddHandler botonborrar(7).Click, AddressOf Me.accionb7
                        Case 8
                            AddHandler botonresta(8).Click, AddressOf Me.accion8
                            AddHandler botonsuma(8).Click, AddressOf Me.accions8
                            AddHandler botonborrar(8).Click, AddressOf Me.accionb8
                        Case 9
                            AddHandler botonresta(9).Click, AddressOf Me.accion9
                            AddHandler botonsuma(9).Click, AddressOf Me.accions9
                            AddHandler botonborrar(9).Click, AddressOf Me.accionb9
                        Case 10
                            AddHandler botonresta(10).Click, AddressOf Me.accion10
                            AddHandler botonsuma(10).Click, AddressOf Me.accions10
                            AddHandler botonborrar(10).Click, AddressOf Me.accionb10
                        Case 11
                            AddHandler botonresta(11).Click, AddressOf Me.accion11
                            AddHandler botonsuma(11).Click, AddressOf Me.accions11
                            AddHandler botonborrar(11).Click, AddressOf Me.accionb11
                        Case 12
                            AddHandler botonresta(12).Click, AddressOf Me.accion12
                            AddHandler botonsuma(12).Click, AddressOf Me.accions12
                            AddHandler botonborrar(12).Click, AddressOf Me.accionb12
                        Case 13
                            AddHandler botonresta(13).Click, AddressOf Me.accion13
                            AddHandler botonsuma(13).Click, AddressOf Me.accions13
                            AddHandler botonborrar(13).Click, AddressOf Me.accionb13
                        Case 14
                            AddHandler botonresta(14).Click, AddressOf Me.accion14
                            AddHandler botonsuma(14).Click, AddressOf Me.accions14
                            AddHandler botonborrar(14).Click, AddressOf Me.accionb14
                        Case 15
                            AddHandler botonresta(15).Click, AddressOf Me.accion15
                            AddHandler botonsuma(15).Click, AddressOf Me.accions15
                            AddHandler botonborrar(15).Click, AddressOf Me.accionb15
                        Case 16
                            AddHandler botonresta(16).Click, AddressOf Me.accion16
                            AddHandler botonsuma(16).Click, AddressOf Me.accions16
                            AddHandler botonborrar(16).Click, AddressOf Me.accionb16
                        Case 17
                            AddHandler botonresta(17).Click, AddressOf Me.accion17
                            AddHandler botonsuma(17).Click, AddressOf Me.accions17
                            AddHandler botonborrar(17).Click, AddressOf Me.accionb17
                        Case 18
                            AddHandler botonresta(18).Click, AddressOf Me.accion18
                            AddHandler botonsuma(18).Click, AddressOf Me.accions18
                            AddHandler botonborrar(18).Click, AddressOf Me.accionb18
                        Case 19
                            AddHandler botonresta(19).Click, AddressOf Me.accion19
                            AddHandler botonsuma(19).Click, AddressOf Me.accions19
                            AddHandler botonborrar(19).Click, AddressOf Me.accionb19
                        Case 20
                            AddHandler botonresta(20).Click, AddressOf Me.accion20
                            AddHandler botonsuma(20).Click, AddressOf Me.accions20
                            AddHandler botonborrar(20).Click, AddressOf Me.accionb20



                        Case Else

                    End Select
                Else
                    If Form3.almacena(x) = 0 Then
                        Dim f
                        Dim tempo
                        For f = x To 20
                            Form3.almacena(x) = Form3.almacena(x + 1)

                        Next

                    End If


                End If
                TextBox1.Text = TextBox1.Text & alamcenaid(x)
            Next

        Catch ex As Exception
            MsgBox("Id no existe")
            ' txt1.Text = "Id ya existe " & ex.Message
        End Try

    End Sub

    Public Sub restarn()
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If

    End Sub
    Public Sub suman()
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub

    Private Sub accion1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 1
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Private Sub accion2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 2
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Private Sub accion3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 3
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Private Sub accion4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 4
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Private Sub accion5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 5
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Private Sub accion6(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 6
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Private Sub accion7(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 7
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Private Sub accion8(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 8
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Private Sub accion9(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 9
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Private Sub accion10(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 10
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Private Sub accion11(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 11
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Private Sub accion12(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 12
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Private Sub accion13(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 13
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Private Sub accion14(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 14
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Private Sub accion15(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 15
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Private Sub accion16(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 16
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Private Sub accion17(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 17
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Private Sub accion18(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 18
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Private Sub accion19(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 19
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub
    Private Sub accion20(ByVal sender As System.Object, ByVal e As System.EventArgs)
        restar = 20
        If campo(restar).Text > 1 Then
            campo(restar).Text = campo(restar).Text - 1
            total(restar).Text = campo(restar).Text * precio(1).Text
        End If
    End Sub


    Private Sub accions1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 1
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Private Sub accions2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 2
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Private Sub accions3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 3
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Private Sub accions4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 4
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Private Sub accions5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 5
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Private Sub accions6(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 6
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Private Sub accions7(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 7
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Private Sub accions8(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 8
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Private Sub accions9(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 9
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Private Sub accions10(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 10
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Private Sub accions11(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 11
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Private Sub accions12(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 12
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub

    Private Sub accions13(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 13
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Private Sub accions14(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 14
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub

    Private Sub accions15(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 15
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Private Sub accions16(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 16
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Private Sub accions17(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 17
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Private Sub accions18(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 18
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Private Sub accions19(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 19
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Private Sub accions20(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sumar = 20
        If campo(sumar).Text < 20 Then
            campo(sumar).Text = campo(sumar).Text + 1
            total(sumar).Text = campo(sumar).Text * precio(sumar).Text
        End If
    End Sub
    Public Sub accionb1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 1
        Form3.almacena(x) = 0
        alamcenaid(x) = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 2
        Form3.almacena(x) = 0
        alamcenaid(x) = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 3
        Form3.almacena(x) = 0
        alamcenaid(x) = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 4
        Form3.almacena(x) = 0
        alamcenaid(x) = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 5
        Form3.almacena(x) = 0
        alamcenaid(x) = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb6(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 6
        Form3.almacena(x) = 0
        alamcenaid(x) = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb7(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 7
        Form3.almacena(x) = 0
        alamcenaid(x) = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb8(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 8
        Form3.almacena(x) = 0
        alamcenaid(x) = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb9(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 9
        Form3.almacena(x) = 0
        alamcenaid(x) = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb10(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 10
        Form3.almacena(x) = 0
        alamcenaid(x) = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb11(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 11
        Form3.almacena(x) = 0
        alamcenaid(x) = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb12(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 12
        Form3.almacena(x) = 0
        alamcenaid(x) = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb13(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 13
        Form3.almacena(x) = 0
        alamcenaid(x) = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb14(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 14
        Form3.almacena(x) = 0
        alamcenaid(x) = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb15(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 15
        Form3.almacena(x) = 0
        alamcenaid(x) = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb16(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 16
        Form3.almacena(x) = 0
        alamcenaid(x) = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb17(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 17
        Form3.almacena(x) = 0
        alamcenaid(x) = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb18(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 18
        Form3.almacena(x) = 0
        alamcenaid(x) = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb19(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 19
        Form3.almacena(x) = 0
        alamcenaid(x) = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form5_Load(e, e)
    End Sub
    Public Sub accionb20(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim x = 20
        Form3.almacena(x) = 0
        alamcenaid(x) = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form5_Load(e, e)
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cargar

        For cargar = 1 To 20
            If alamcenaid(cargar) = 0 Then
                cargar = 99
            Else
                Form3.almacena(cargar) = alamcenaid(cargar)
            End If

        Next
        Me.Hide()

        Form3.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Controls.Clear()
        InitializeComponent()
        Form5_Load(e, e)
    End Sub



End Class