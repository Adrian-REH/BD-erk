<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Actualizar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Actualizar))
        Me.Entrar2 = New System.Windows.Forms.Button()
        Me.Textverf = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.Check = New System.Windows.Forms.CheckBox()
        Me.SALIR = New System.Windows.Forms.Button()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Entrar2
        '
        Me.Entrar2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Entrar2.FlatAppearance.BorderSize = 0
        Me.Entrar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.Entrar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Entrar2.Location = New System.Drawing.Point(12, 151)
        Me.Entrar2.Name = "Entrar2"
        Me.Entrar2.Size = New System.Drawing.Size(254, 51)
        Me.Entrar2.TabIndex = 3
        Me.Entrar2.Text = "VERIFICAR"
        Me.Entrar2.UseVisualStyleBackColor = False
        '
        'Textverf
        '
        Me.Textverf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textverf.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textverf.Location = New System.Drawing.Point(25, 114)
        Me.Textverf.Multiline = True
        Me.Textverf.Name = "Textverf"
        Me.Textverf.Size = New System.Drawing.Size(218, 20)
        Me.Textverf.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Humanst521 BT", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 87)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Ingrese el codigo que se le envio al haber pagado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Ingrese el codigo aqui"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Space Bd BT", 6.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 11)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "DexterÑerk © Copyright 2018" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = Global.DBÑerk.My.Resources.Resources._22
        Me.PictureBox12.Location = New System.Drawing.Point(206, 35)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(72, 50)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox12.TabIndex = 50
        Me.PictureBox12.TabStop = False
        '
        'Check
        '
        Me.Check.AutoSize = True
        Me.Check.Location = New System.Drawing.Point(25, 135)
        Me.Check.Name = "Check"
        Me.Check.Size = New System.Drawing.Size(41, 17)
        Me.Check.TabIndex = 51
        Me.Check.Text = "ver"
        Me.Check.UseVisualStyleBackColor = True
        '
        'SALIR
        '
        Me.SALIR.BackColor = System.Drawing.Color.Transparent
        Me.SALIR.BackgroundImage = Global.DBÑerk.My.Resources.Resources.Ic_close_48px1
        Me.SALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SALIR.FlatAppearance.BorderSize = 0
        Me.SALIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure
        Me.SALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SALIR.Location = New System.Drawing.Point(252, 4)
        Me.SALIR.Name = "SALIR"
        Me.SALIR.Size = New System.Drawing.Size(25, 20)
        Me.SALIR.TabIndex = 52
        Me.SALIR.UseVisualStyleBackColor = False
        '
        'Actualizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(280, 225)
        Me.Controls.Add(Me.SALIR)
        Me.Controls.Add(Me.Entrar2)
        Me.Controls.Add(Me.Textverf)
        Me.Controls.Add(Me.Check)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Actualizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar"
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Entrar2 As System.Windows.Forms.Button
    Friend WithEvents Textverf As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents Check As System.Windows.Forms.CheckBox
    Friend WithEvents SALIR As System.Windows.Forms.Button
End Class
