<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelMenuLateral = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panellogo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panelformulariohijo = New System.Windows.Forms.Panel()
        Me.PanelMenuLateral.SuspendLayout()
        Me.Panellogo.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenuLateral
        '
        Me.PanelMenuLateral.AutoScroll = True
        Me.PanelMenuLateral.Controls.Add(Me.Button5)
        Me.PanelMenuLateral.Controls.Add(Me.Button4)
        Me.PanelMenuLateral.Controls.Add(Me.Button3)
        Me.PanelMenuLateral.Controls.Add(Me.Button2)
        Me.PanelMenuLateral.Controls.Add(Me.Button1)
        Me.PanelMenuLateral.Controls.Add(Me.Panellogo)
        Me.PanelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenuLateral.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenuLateral.Name = "PanelMenuLateral"
        Me.PanelMenuLateral.Size = New System.Drawing.Size(289, 500)
        Me.PanelMenuLateral.TabIndex = 8
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button5.Location = New System.Drawing.Point(0, 416)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(289, 84)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Eliminar cuenta"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.Location = New System.Drawing.Point(0, 337)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(289, 79)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Cerrar sesión"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.Location = New System.Drawing.Point(0, 258)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(289, 79)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Editar metodos de pago"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.Location = New System.Drawing.Point(0, 179)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(289, 79)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Cambiar contraseña"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.Location = New System.Drawing.Point(0, 100)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(289, 79)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Editar datos de usuario"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panellogo
        '
        Me.Panellogo.Controls.Add(Me.Label1)
        Me.Panellogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panellogo.Location = New System.Drawing.Point(0, 0)
        Me.Panellogo.Name = "Panellogo"
        Me.Panellogo.Size = New System.Drawing.Size(289, 100)
        Me.Panellogo.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 37)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Perfil de usuario"
        '
        'Panelformulariohijo
        '
        Me.Panelformulariohijo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panelformulariohijo.Location = New System.Drawing.Point(289, 0)
        Me.Panelformulariohijo.Name = "Panelformulariohijo"
        Me.Panelformulariohijo.Size = New System.Drawing.Size(902, 500)
        Me.Panelformulariohijo.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1191, 500)
        Me.Controls.Add(Me.Panelformulariohijo)
        Me.Controls.Add(Me.PanelMenuLateral)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanelMenuLateral.ResumeLayout(False)
        Me.Panellogo.ResumeLayout(False)
        Me.Panellogo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenuLateral As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panellogo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panelformulariohijo As Panel
End Class
