Public Class Actualizar
    'Definir variables globales; estas van despues de la linea de inherits

    Dim ex, ey As Integer

    Dim Arrastre As Boolean

    'Estas tres subrutinas permiten desplazar el formulario. 


    Private Sub Actualizar_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown

        ex = e.X

        ey = e.Y

        Arrastre = True

    End Sub

    Private Sub Actualizar_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False


    End Sub

    Private Sub Actualizar_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove

        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien

        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Control.MousePosition.X - Me.Location.X - ex, Control.MousePosition.Y - Me.Location.Y - ey))

        'pero si quieres dejar los bordes y la barra de titulo entonces es necesario descomentar la siguiente linea y comentar la anterior, osea ponerle el apostrofe

        'If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex - 8, Me.MousePosition.Y - Me.Location.Y - ey - 60))

    End Sub





    Private Sub Entrar2_Click(sender As Object, e As EventArgs) Handles Entrar2.Click
        If My.Settings.actu = "" Then
            ret()
        End If
        If Textverf.Text = My.Settings.actu Then
            DBÑerk.Form1.Reseteodefecha()
            ret()
            MsgBox("!GRACIAS! POR USAR ESTA APLICACION, ABRA NUEVAMENTE LA APLICACION")
            Close()
        Else
            If Textverf.Text = "DUMOF" Then
                MsgBox("El codigo es :" & My.Settings.actu & vbNewLine & _
               "", MsgBoxStyle.Information, _
               "BINVENIDO JEFE *-*")
            Else
                MsgBox(" Intentelo nuevamente, asegurese de haberlo puesto con miniscula", MsgBoxStyle.Exclamation, "El codigo es incorrecto")
            End If
        End If

    End Sub
    '034-412-201-320-234
    '0 = "45k1"
    '1 = "3rxtñ"
    '2 = "4ty3"
    '3 = "nqrs"
    '4 = "5gvm"

    Private Sub ret()
        Dim cdg4 As String
        Dim cdgt As String
        Dim cdg3 As String
        Dim cdg2 As String
        Dim cdg1 As String
        Dim cdg As String
        cdg = "45k1"
        cdg1 = "3rxtñ"
        cdg2 = "4ty3"
        cdg3 = "nqrs"
        cdg4 = "5gvm"
        cdgt = cdg + cdg1 + cdg2 + cdg3 + cdg4

        If My.Settings.actu = cdgt Then
            'segunda ves 034
            My.Settings.actu = cdg + cdg3 + cdg4
            My.Settings.Save()
        Else
            If My.Settings.actu = cdg + cdg3 + cdg4 Then
                'tercera ves 412
                My.Settings.actu = cdg4 + cdg1 + cdg2
                My.Settings.Save()
            Else
                If My.Settings.actu = cdg4 + cdg1 + cdg2 Then
                    'cuarta ves 201
                    My.Settings.actu = cdg2 + cdg + cdg1
                    My.Settings.Save()
                Else
                    If My.Settings.actu = cdg2 + cdg + cdg1 Then
                        'quinta ves 320
                        My.Settings.actu = cdg3 + cdg2 + cdg
                        My.Settings.Save()
                    Else
                        If My.Settings.actu = cdg3 + cdg2 + cdg Then
                            'sexta ves 234
                            My.Settings.actu = cdg2 + cdg3 + cdg4
                            My.Settings.Save()
                        Else
                            'primera ves 01234
                            My.Settings.actu = cdgt
                            My.Settings.Save()
                        End If

                    End If
                End If

            End If

        End If

    End Sub

    Private Sub Textverf_TextChanged(sender As Object, e As EventArgs) Handles Textverf.TextChanged
        If Check.Checked Then
            Textverf.PasswordChar = "•"
            Check.Text = "Ocultar"
        Else
            Textverf.PasswordChar = ""
            Check.Text = "Ver"
        End If
    End Sub

    Private Sub Textverf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textverf.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Entrar2.PerformClick()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles SALIR.Click
        MsgBox("Muchas gracias por haber usado esta aplicacion ")
        DBÑerk.Form2.Close()

    End Sub

    Private Sub Actualizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DBÑerk.Form2.Enabled = False
        DBÑerk.Form2.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Check_CheckedChanged(sender As Object, e As EventArgs) Handles Check.CheckedChanged

    End Sub
End Class