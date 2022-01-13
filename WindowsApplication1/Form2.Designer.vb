<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Salida = New System.Windows.Forms.Button()
        Me.Guard = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.user = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Entrar = New System.Windows.Forms.Button()
        Me.contra = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.confpass2 = New System.Windows.Forms.TextBox()
        Me.confuser2 = New System.Windows.Forms.TextBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape7 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape8 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.confpass3 = New System.Windows.Forms.TextBox()
        Me.confuser3 = New System.Windows.Forms.TextBox()
        Me.ShapeContainer5 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape9 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape10 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.confuser = New System.Windows.Forms.TextBox()
        Me.confpass = New System.Windows.Forms.TextBox()
        Me.admuser = New System.Windows.Forms.TextBox()
        Me.admpass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Salida
        '
        Me.Salida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Salida.Location = New System.Drawing.Point(135, 328)
        Me.Salida.Name = "Salida"
        Me.Salida.Size = New System.Drawing.Size(123, 35)
        Me.Salida.TabIndex = 22
        Me.Salida.Text = "SALIR"
        Me.Salida.UseVisualStyleBackColor = True
        '
        'Guard
        '
        Me.Guard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Guard.Location = New System.Drawing.Point(135, 328)
        Me.Guard.Name = "Guard"
        Me.Guard.Size = New System.Drawing.Size(123, 33)
        Me.Guard.TabIndex = 19
        Me.Guard.Text = "Guardar"
        Me.Guard.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ShapeContainer4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(4, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(186, 152)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ADMINISTRADOR"
        '
        'ShapeContainer4
        '
        Me.ShapeContainer4.Location = New System.Drawing.Point(3, 19)
        Me.ShapeContainer4.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer4.Name = "ShapeContainer4"
        Me.ShapeContainer4.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape3})
        Me.ShapeContainer4.Size = New System.Drawing.Size(180, 130)
        Me.ShapeContainer4.TabIndex = 0
        Me.ShapeContainer4.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.SelectionColor = System.Drawing.Color.Transparent
        Me.LineShape4.X1 = 17
        Me.LineShape4.X2 = 133
        Me.LineShape4.Y1 = 84
        Me.LineShape4.Y2 = 84
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.SelectionColor = System.Drawing.Color.Transparent
        Me.LineShape3.X1 = 16
        Me.LineShape3.X2 = 132
        Me.LineShape3.Y1 = 35
        Me.LineShape3.Y2 = 35
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.Controls.Add(Me.user)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Entrar)
        Me.Panel1.Controls.Add(Me.contra)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(-2, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(398, 326)
        Me.Panel1.TabIndex = 3
        '
        'user
        '
        Me.user.BackColor = System.Drawing.Color.Azure
        Me.user.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.user.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.Location = New System.Drawing.Point(61, 165)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(257, 19)
        Me.user.TabIndex = 0
        Me.user.Text = "USUARIO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label5.Location = New System.Drawing.Point(114, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 31)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "INGRESAR"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.DBÑerk.My.Resources.Resources.Sin_título_121
        Me.PictureBox2.Location = New System.Drawing.Point(80, 29)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(226, 132)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'Entrar
        '
        Me.Entrar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Entrar.FlatAppearance.BorderSize = 0
        Me.Entrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan
        Me.Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Entrar.Location = New System.Drawing.Point(70, 267)
        Me.Entrar.Name = "Entrar"
        Me.Entrar.Size = New System.Drawing.Size(254, 51)
        Me.Entrar.TabIndex = 2
        Me.Entrar.Text = "ACCEDER"
        Me.Entrar.UseVisualStyleBackColor = False
        '
        'contra
        '
        Me.contra.BackColor = System.Drawing.Color.Azure
        Me.contra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.contra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contra.Location = New System.Drawing.Point(61, 229)
        Me.contra.Name = "contra"
        Me.contra.Size = New System.Drawing.Size(257, 19)
        Me.contra.TabIndex = 1
        Me.contra.Text = "CONTRASEÑA"
        Me.contra.UseSystemPasswordChar = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(398, 326)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.SelectionColor = System.Drawing.Color.Transparent
        Me.LineShape2.X1 = 61
        Me.LineShape2.X2 = 319
        Me.LineShape2.Y1 = 186
        Me.LineShape2.Y2 = 186
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.SelectionColor = System.Drawing.Color.Transparent
        Me.LineShape1.X1 = 62
        Me.LineShape1.X2 = 320
        Me.LineShape1.Y1 = 250
        Me.LineShape1.Y2 = 250
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.confpass2)
        Me.GroupBox3.Controls.Add(Me.confuser2)
        Me.GroupBox3.Controls.Add(Me.ShapeContainer2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(4, 172)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(186, 152)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "2° USER"
        '
        'confpass2
        '
        Me.confpass2.BackColor = System.Drawing.Color.DarkCyan
        Me.confpass2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.confpass2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confpass2.Location = New System.Drawing.Point(21, 87)
        Me.confpass2.Name = "confpass2"
        Me.confpass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.confpass2.Size = New System.Drawing.Size(115, 16)
        Me.confpass2.TabIndex = 27
        '
        'confuser2
        '
        Me.confuser2.BackColor = System.Drawing.Color.DarkCyan
        Me.confuser2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.confuser2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confuser2.Location = New System.Drawing.Point(19, 38)
        Me.confuser2.Name = "confuser2"
        Me.confuser2.Size = New System.Drawing.Size(117, 16)
        Me.confuser2.TabIndex = 26
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 19)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape7, Me.LineShape8})
        Me.ShapeContainer2.Size = New System.Drawing.Size(180, 130)
        Me.ShapeContainer2.TabIndex = 0
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape7
        '
        Me.LineShape7.Name = "LineShape4"
        Me.LineShape7.SelectionColor = System.Drawing.Color.Transparent
        Me.LineShape7.X1 = 17
        Me.LineShape7.X2 = 133
        Me.LineShape7.Y1 = 84
        Me.LineShape7.Y2 = 84
        '
        'LineShape8
        '
        Me.LineShape8.Name = "LineShape3"
        Me.LineShape8.SelectionColor = System.Drawing.Color.Transparent
        Me.LineShape8.X1 = 16
        Me.LineShape8.X2 = 132
        Me.LineShape8.Y1 = 35
        Me.LineShape8.Y2 = 35
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.confpass3)
        Me.GroupBox4.Controls.Add(Me.confuser3)
        Me.GroupBox4.Controls.Add(Me.ShapeContainer5)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(199, 172)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(186, 152)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "3° USER"
        '
        'confpass3
        '
        Me.confpass3.BackColor = System.Drawing.Color.DarkCyan
        Me.confpass3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.confpass3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confpass3.Location = New System.Drawing.Point(20, 87)
        Me.confpass3.Name = "confpass3"
        Me.confpass3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.confpass3.Size = New System.Drawing.Size(115, 16)
        Me.confpass3.TabIndex = 27
        '
        'confuser3
        '
        Me.confuser3.BackColor = System.Drawing.Color.DarkCyan
        Me.confuser3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.confuser3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confuser3.Location = New System.Drawing.Point(18, 38)
        Me.confuser3.Name = "confuser3"
        Me.confuser3.Size = New System.Drawing.Size(117, 16)
        Me.confuser3.TabIndex = 26
        '
        'ShapeContainer5
        '
        Me.ShapeContainer5.Location = New System.Drawing.Point(3, 19)
        Me.ShapeContainer5.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer5.Name = "ShapeContainer5"
        Me.ShapeContainer5.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape9, Me.LineShape10})
        Me.ShapeContainer5.Size = New System.Drawing.Size(180, 130)
        Me.ShapeContainer5.TabIndex = 0
        Me.ShapeContainer5.TabStop = False
        '
        'LineShape9
        '
        Me.LineShape9.Name = "LineShape4"
        Me.LineShape9.SelectionColor = System.Drawing.Color.Transparent
        Me.LineShape9.X1 = 17
        Me.LineShape9.X2 = 133
        Me.LineShape9.Y1 = 84
        Me.LineShape9.Y2 = 84
        '
        'LineShape10
        '
        Me.LineShape10.Name = "LineShape3"
        Me.LineShape10.SelectionColor = System.Drawing.Color.Transparent
        Me.LineShape10.X1 = 16
        Me.LineShape10.X2 = 132
        Me.LineShape10.Y1 = 35
        Me.LineShape10.Y2 = 35
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(3, 19)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape5, Me.LineShape6})
        Me.ShapeContainer3.Size = New System.Drawing.Size(186, 131)
        Me.ShapeContainer3.TabIndex = 0
        Me.ShapeContainer3.TabStop = False
        '
        'LineShape5
        '
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.SelectionColor = System.Drawing.Color.Transparent
        Me.LineShape5.X1 = 18
        Me.LineShape5.X2 = 134
        Me.LineShape5.Y1 = 35
        Me.LineShape5.Y2 = 35
        '
        'LineShape6
        '
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.SelectionColor = System.Drawing.Color.Transparent
        Me.LineShape6.X1 = 18
        Me.LineShape6.X2 = 134
        Me.LineShape6.Y1 = 83
        Me.LineShape6.Y2 = 83
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ShapeContainer3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(196, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(192, 153)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "1°USER"
        '
        'confuser
        '
        Me.confuser.BackColor = System.Drawing.Color.DarkCyan
        Me.confuser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.confuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confuser.Location = New System.Drawing.Point(218, 50)
        Me.confuser.Name = "confuser"
        Me.confuser.Size = New System.Drawing.Size(117, 16)
        Me.confuser.TabIndex = 17
        '
        'confpass
        '
        Me.confpass.BackColor = System.Drawing.Color.DarkCyan
        Me.confpass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.confpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confpass.Location = New System.Drawing.Point(218, 98)
        Me.confpass.Name = "confpass"
        Me.confpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.confpass.Size = New System.Drawing.Size(115, 16)
        Me.confpass.TabIndex = 18
        '
        'admuser
        '
        Me.admuser.BackColor = System.Drawing.Color.DarkCyan
        Me.admuser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.admuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admuser.Location = New System.Drawing.Point(22, 49)
        Me.admuser.Name = "admuser"
        Me.admuser.Size = New System.Drawing.Size(117, 16)
        Me.admuser.TabIndex = 20
        '
        'admpass
        '
        Me.admpass.BackColor = System.Drawing.Color.DarkCyan
        Me.admpass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.admpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admpass.Location = New System.Drawing.Point(24, 98)
        Me.admpass.Name = "admpass"
        Me.admpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.admpass.Size = New System.Drawing.Size(117, 16)
        Me.admpass.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Azure
        Me.Label1.Location = New System.Drawing.Point(67, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 20)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "CONFIGURACION DE CUENTAS"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(393, 367)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.admpass)
        Me.Controls.Add(Me.admuser)
        Me.Controls.Add(Me.confpass)
        Me.Controls.Add(Me.confuser)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Salida)
        Me.Controls.Add(Me.Guard)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresar"
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Salida As System.Windows.Forms.Button
    Friend WithEvents Guard As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ShapeContainer4 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Entrar As System.Windows.Forms.Button
    Friend WithEvents user As System.Windows.Forms.TextBox
    Friend WithEvents contra As System.Windows.Forms.TextBox
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents confpass2 As System.Windows.Forms.TextBox
    Friend WithEvents confuser2 As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape7 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape8 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents confpass3 As System.Windows.Forms.TextBox
    Friend WithEvents confuser3 As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer5 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape9 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape10 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents ShapeContainer3 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents confuser As System.Windows.Forms.TextBox
    Friend WithEvents confpass As System.Windows.Forms.TextBox
    Friend WithEvents admuser As System.Windows.Forms.TextBox
    Friend WithEvents admpass As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
