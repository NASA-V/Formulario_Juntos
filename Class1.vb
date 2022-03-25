Public Class Class1
    Inherits Form_1
    Dim articulos() As String = {Nombre_Leche2.Text, Nombre_leche1.Text, Label4.Text, Label7.Text, Label3.Text, Label8.Text}
    Public Sub func()

        Dim leche1 As Object = {Nombre_leche1, Button5, TextBox11, Label12}
        Dim leche2 As Object = {Nombre_Leche2, Button2, TextBox8, Label11}



    End Sub
    Public Sub leches()

    End Sub

    Private Sub LechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LechaToolStripMenuItem.Click



        'For Each arrayItem In articulos
        '    If arrayItem.Contains("leche") Then

        '    End If
        'Next


    End Sub

    Private Sub logic(x As String)

    End Sub
    Private Sub articles()

    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Class1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1031, 605)
        Me.Name = "Class1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub Class1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
