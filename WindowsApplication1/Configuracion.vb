Public Class Configuracion
    'Definir variables globales; estas van despues de la linea de inherits

    Dim ex, ey As Integer

    Dim Arrastre As Boolean

    'Estas tres subrutinas permiten desplazar el formulario. 


    Private Sub Form2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown

        ex = e.X

        ey = e.Y

        Arrastre = True

    End Sub

    Private Sub Form2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False


    End Sub

    Private Sub Form2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove

        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien

        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Control.MousePosition.X - Me.Location.X - ex, Control.MousePosition.Y - Me.Location.Y - ey))

        'pero si quieres dejar los bordes y la barra de titulo entonces es necesario descomentar la siguiente linea y comentar la anterior, osea ponerle el apostrofe

        'If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex - 8, Me.MousePosition.Y - Me.Location.Y - ey - 60))

    End Sub
    Private Sub Configuracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.Imge
        PictureBox1.ImageLocation = My.Settings.Imge
    End Sub
    Private Sub btgv_Click(sender As Object, e As EventArgs) Handles btgv.Click
        My.Settings.Imge = TextBox1.Text
        My.Settings.Save()
        If My.Settings.Imge = "" Then
        Else
            DBÑerk.Form1.PictureBox2.ImageLocation = (My.Settings.Imge)
            DBÑerk.Form2.PictureBox2.ImageLocation = (My.Settings.Imge)
        End If
        Me.Visible = False

    End Sub

    Private Sub Btexplo_Click(sender As Object, e As EventArgs) Handles Btexplo.Click
        Try
            OpenFileDialog1.Title = "Abrir Imagen"
            OpenFileDialog1.FileName = "Imagenes"
            OpenFileDialog1.Filter = "All Files |*.*"
            OpenFileDialog1.ShowDialog()
            PictureBox1.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
            TextBox1.Text = OpenFileDialog1.FileName
        Catch ex As Exception

            'Do Nothing End Try 

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        '482
        '339
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Me.Width = 339 Then
            For i = 339 To 480
                Me.Width = i
                Button7.Text = "Ocultar Info"
            Next i
        Else
            Me.Width = 339
            Button7.Text = "Ver Info"
        End If
       

    End Sub
End Class