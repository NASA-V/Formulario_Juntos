Public Class Form_7

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Aplicacion_ProductosDataSet.Articulos' Puede moverla o quitarla según sea necesario.
        Me.ArticulosTableAdapter.Fill(Me.Aplicacion_ProductosDataSet.Articulos)
        'TODO: esta línea de código carga datos en la tabla 'Aplicacion_ProductosDataSet.Carrito_' Puede moverla o quitarla según sea necesario.
        Me.Carrito_TableAdapter.Fill(Me.Aplicacion_ProductosDataSet.Carrito_)
        PictureBo1.Image = Module_1.Img1
        PictureBox2.Image = Module_1.Img2
        PictureBox3.Image = Module_1.Img3
        PictureBox4.Image = Module_1.Img4
        PictureBox5.Image = Module_1.Img5


        EMPRESA1.Text = Form_8.Label13.Text
        EMPRESA2.Text = Form_8.Label14.Text
        EMPRESA3.Text = Form_8.Label15.Text
        EMPRESA4.Text = Form_8.Label16.Text
        EMPRESA5.Text = Form_8.Label17.Text

        PRODUCTO2.Text = Form_8.Label12.Text
        PRODUCTO3.Text = Form_8.Label13.Text
        PRODUCTO4.Text = Form_8.Label14.Text
        PRODUCTO5.Text = Form_8.Label15.Text

        Precio1.Text = Form_8.Label7.Text
        Precio2.Text = Form_8.Label8.Text
        Precio3.Text = Form_8.Label9.Text
        Precio4.Text = Form_8.Label10.Text
        Precio5.Text = Form_8.Label11.Text










        PRODUCTO1.Text = Form_8.Label11.Text



        Dim super(99) As Label
        Dim descrpcion(99) As Label
        Dim precio(99) As Label
        Dim disponible(99) As Label
        Dim TextBoxArray(6) As TextBox





    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBo1_Click(sender As Object, e As EventArgs) Handles PictureBo1.Click

    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged

    End Sub
    Private Sub AGUA()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Precio4.Click

    End Sub

    Private Sub Carrito_BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Carrito_BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Carrito_BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Aplicacion_ProductosDataSet)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.ArticulosTableAdapter.FillBy(Me.Aplicacion_ProductosDataSet.Articulos)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class