Imports DBÑerk.Actualizar

Public Class Form2
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
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        confuser.Text = My.Settings.Usuario
        confpass.Text = My.Settings.Contraseña
        confpass2.Text = My.Settings.Contraseña2
        confpass3.Text = My.Settings.Contraseña3
        confuser2.Text = My.Settings.Usuario2
        confuser3.Text = My.Settings.Usuario3
        admpass.Text = My.Settings.admc
        admuser.Text = My.Settings.admu
        If My.Settings.Imge = "" Then

        Else
            PictureBox2.ImageLocation = (My.Settings.Imge)
        End If
        ending()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Entrar.Click
        'ADM

        If contra.Text = "admin" Then
            If user.Text = "admin" Then
                Form1.Show()
                DBÑerk.Form1.Label7.Location = New Point(390, -15)
                DBÑerk.Form1.Label8.Location = New Point(752, -15)
                Me.Visible = False
                DBÑerk.Form1.Button4.Visible = False
                MsgBox("MODO ADMINISTRADOR", MsgBoxStyle.Information, "Bienvenido")
            Else
            End If


        Else

            If user.Text = My.Settings.admu Then
                If contra.Text = My.Settings.admc Then
                    Form1.Show()
                    DBÑerk.Form1.Label7.Location = New Point(390, -15)
                    DBÑerk.Form1.Label8.Location = New Point(752, -15)
                    Me.Visible = False
                    DBÑerk.Form1.Button4.Visible = False
                    MsgBox("MODO ADMINISTRADOR", MsgBoxStyle.Information, "Bienvenido")

                End If
            Else

                If contra.Text = My.Settings.Contraseña And user.Text = My.Settings.Usuario Then
                    Dim cuser As String = My.Settings.Usuario
                    Form1.Show()
                    Me.Visible = False
                    DBÑerk.Form1.Slid.Visible = False
                    DBÑerk.Form1.desdetext.Enabled = False
                    DBÑerk.Form1.EXPA.Visible = False
                    DBÑerk.Form1.EXPA2.Visible = False
                    DBÑerk.Form1.Label7.Location = New Point(421, -14)
                    DBÑerk.Form1.Label8.Location = New Point(786, -11)

                    My.Settings.cph = My.Settings.Usuario
                    My.Settings.Save()

                    DBÑerk.Form1.TURNO()

                    MsgBox("Usuario " & cuser & vbNewLine & _
                      "Acceso concedido.", _
                      MsgBoxStyle.Information, "BIENVENIDO!")
                Else
                    If contra.Text = My.Settings.Contraseña2 And user.Text = My.Settings.Usuario2 Then
                        Dim cuser2 As String = My.Settings.Usuario2
                        Form1.Show()
                        Me.Visible = False
                        DBÑerk.Form1.Slid.Visible = False
                        DBÑerk.Form1.desdetext.Enabled = False
                        DBÑerk.Form1.EXPA.Visible = False
                        DBÑerk.Form1.EXPA2.Visible = False
                        DBÑerk.Form1.Label8.Location = New Point(786, -11)
                        DBÑerk.Form1.Label7.Location = New Point(421, -14)


                        My.Settings.cph = My.Settings.Usuario2
                        My.Settings.Save()
                        DBÑerk.Form1.TURNO()
                        MsgBox("Usuario " & cuser2 & vbNewLine & _
                      "Acceso concedido.", _
                      MsgBoxStyle.Information, "BIENVENIDO!")
                    Else
                        If contra.Text = My.Settings.Contraseña3 And user.Text = My.Settings.Usuario3 Then
                            Dim cuser3 As String = My.Settings.Usuario3
                            Form1.Show()
                            Me.Visible = False
                            DBÑerk.Form1.Slid.Visible = False
                            DBÑerk.Form1.desdetext.Enabled = False
                            DBÑerk.Form1.EXPA2.Visible = False
                            DBÑerk.Form1.EXPA.Visible = False
                            DBÑerk.Form1.Label8.Location = New Point(786, -11)
                            DBÑerk.Form1.Label7.Location = New Point(421, -14)


                            My.Settings.cph = My.Settings.Usuario3
                            My.Settings.Save()

                            DBÑerk.Form1.TURNO()
                            MsgBox("Usuario " & cuser3 & vbNewLine & _
                       "Acceso concedido.", _
                       MsgBoxStyle.Information, "BIENVENIDO!")
                        Else
                            MsgBox("" & vbNewLine & _
                      "El usuario y/o contraseña ingresado no coincide con el registro", _
                      MsgBoxStyle.Information, "NO ENCONTRADO")
                        End If
                    End If
                End If

            End If

        End If


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Guard.Click
        My.Settings.Usuario = confuser.Text
        My.Settings.Contraseña = confpass.Text
        My.Settings.admc = admpass.Text
        My.Settings.admu = admuser.Text
        My.Settings.Contraseña2 = confpass2.Text
        My.Settings.Contraseña3 = confpass3.Text
        My.Settings.Usuario2 = confuser2.Text
        My.Settings.Usuario3 = confuser3.Text
        My.Settings.Save()
        Form1.Show()
        Me.Visible = False


        'admin
        If admuser.Text = "" Then
        Else
            GroupBox2.Text = admuser.Text
        End If
        '1
        If confuser.Text = "" Then
        Else
            GroupBox1.Text = confuser.Text
        End If
        '2
        If confuser2.Text = "" Then
        Else
            GroupBox3.Text = confuser2.Text
        End If
        '3
        If confuser3.Text = "" Then
        Else
            GroupBox4.Text = confuser3.Text
        End If
    End Sub

    Private Sub user_Click(sender As Object, e As EventArgs) Handles user.Click
        user.Text = ""
    End Sub

    Private Sub contraseña_Click(sender As Object, e As EventArgs) Handles contra.Click
        contra.Text = ""
    End Sub

    Private Sub Salida_Click(sender As Object, e As EventArgs) Handles Salida.Click
        Close()
        DBÑerk.Form1.Close()
    End Sub

    Private Sub user_KeyPress(sender As Object, e As KeyPressEventArgs) Handles user.KeyPress
        If Asc(e.KeyChar) = 13 Then
            contra.Focus()
        End If
    End Sub

    Private Sub contra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles contra.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Entrar.PerformClick()
        End If
    End Sub

    Private Sub Form2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Entrar.PerformClick()
        End If
    End Sub
    Private Sub ending()

        Dim fecad As String
        Dim fechahoy As String
        fechahoy = Format(Now, "MM")
        fecad = My.Settings.mes
        If fecad = fechahoy Then
            Actualizar.Show()

        End If
    End Sub

End Class