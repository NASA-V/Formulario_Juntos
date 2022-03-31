<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_26
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pncarrito = New System.Windows.Forms.Panel()
        Me.lbc4 = New System.Windows.Forms.Label()
        Me.lbc3 = New System.Windows.Forms.Label()
        Me.lbc2 = New System.Windows.Forms.Label()
        Me.lbc1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.pncarrito.SuspendLayout()
        Me.SuspendLayout()
        '
        'pncarrito
        '
        Me.pncarrito.Controls.Add(Me.lbc4)
        Me.pncarrito.Controls.Add(Me.lbc3)
        Me.pncarrito.Controls.Add(Me.lbc2)
        Me.pncarrito.Controls.Add(Me.lbc1)
        Me.pncarrito.Location = New System.Drawing.Point(716, 313)
        Me.pncarrito.Name = "pncarrito"
        Me.pncarrito.Size = New System.Drawing.Size(72, 125)
        Me.pncarrito.TabIndex = 0
        '
        'lbc4
        '
        Me.lbc4.AutoSize = True
        Me.lbc4.Location = New System.Drawing.Point(105, 65)
        Me.lbc4.Name = "lbc4"
        Me.lbc4.Size = New System.Drawing.Size(51, 17)
        Me.lbc4.TabIndex = 3
        Me.lbc4.Text = "Label1"
        '
        'lbc3
        '
        Me.lbc3.AutoSize = True
        Me.lbc3.Location = New System.Drawing.Point(105, 48)
        Me.lbc3.Name = "lbc3"
        Me.lbc3.Size = New System.Drawing.Size(51, 17)
        Me.lbc3.TabIndex = 2
        Me.lbc3.Text = "Label1"
        '
        'lbc2
        '
        Me.lbc2.AutoSize = True
        Me.lbc2.Location = New System.Drawing.Point(105, 31)
        Me.lbc2.Name = "lbc2"
        Me.lbc2.Size = New System.Drawing.Size(51, 17)
        Me.lbc2.TabIndex = 1
        Me.lbc2.Text = "Label1"
        '
        'lbc1
        '
        Me.lbc1.AutoSize = True
        Me.lbc1.Location = New System.Drawing.Point(105, 14)
        Me.lbc1.Name = "lbc1"
        Me.lbc1.Size = New System.Drawing.Size(51, 17)
        Me.lbc1.TabIndex = 0
        Me.lbc1.Text = "Label1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(699, 70)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(698, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Atras"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(698, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "ACTUALIZAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.pncarrito)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.pncarrito.ResumeLayout(False)
        Me.pncarrito.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pncarrito As Panel
    Friend WithEvents lbc4 As Label
    Friend WithEvents lbc3 As Label
    Friend WithEvents lbc2 As Label
    Friend WithEvents lbc1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
