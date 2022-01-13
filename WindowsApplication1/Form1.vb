Imports System.Data.OleDb
Imports DBÑerk.Form2
Imports ZXing
Imports AForge.Video.DirectShow
Public Class Form1
    Dim dispositivos As FilterInfoCollection
    Dim FuenteVideo As VideoCaptureDevice

    Dim Provider As String
    Dim dataFile As String
    Dim connString As String
    Dim Access As String = "Provider=microsoft.ace.oledb.12.0;data source=" + My.Computer.FileSystem.CurrentDirectory + "\BD.accdb"
    Dim myconnection As OleDbConnection = New OleDbConnection(Access)
    'Definir variables globales; estas van despues de la linea de inherits

    Dim ex, ey As Integer

    Dim Arrastre As Boolean

    'Estas tres subrutinas permiten desplazar el formulario. 


    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown

        ex = e.X

        ey = e.Y

        Arrastre = True

    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False


    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove

        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien

        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Control.MousePosition.X - Me.Location.X - ex, Control.MousePosition.Y - Me.Location.Y - ey))

        'pero si quieres dejar los bordes y la barra de titulo entonces es necesario descomentar la siguiente linea y comentar la anterior, osea ponerle el apostrofe

        'If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex - 8, Me.MousePosition.Y - Me.Location.Y - ey - 60))

    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDDataSet.Tabla1' Puede moverla o quitarla según sea necesario.
        Me.Tabla1TableAdapter.Fill(Me.BDDataSet.Tabla1)
        'TODO: esta línea de código carga datos en la tabla 'BDDataSet.Us1' Puede moverla o quitarla según sea necesario.
        Me.Us1TableAdapter.Fill(Me.BDDataSet.Us1)
        'TODO: esta línea de código carga datos en la tabla 'BDDataSet.Us3' Puede moverla o quitarla según sea necesario.
        Me.Us3TableAdapter.Fill(Me.BDDataSet.Us3)
        'TODO: esta línea de código carga datos en la tabla 'BDDataSet.Us2' Puede moverla o quitarla según sea necesario.
        Me.Us2TableAdapter.Fill(Me.BDDataSet.Us2)
        'TODO: esta línea de código carga datos en la tabla 'BDDataSet.Tabla3' Puede moverla o quitarla según sea necesario.
        Me.Tabla3TableAdapter.Fill(Me.BDDataSet.Tabla3)

        'TODO: esta línea de código carga datos en la tabla 'BDDataSet.Tabla2' Puede moverla o quitarla según sea necesario.
        Me.Tabla2TableAdapter.Fill(Me.BDDataSet.Tabla2)

        'TODO: esta línea de código carga datos en la tabla 'BDDataSet.Tabla2' Puede moverla o quitarla según sea necesario.
        Me.Tabla2TableAdapter.Fill(Me.BDDataSet.Tabla2)


        With DataGridView1
            .ClearSelection()
            .ReadOnly = True
            .MultiSelect = False
        End With

        Dim colors() As String = [Enum].GetNames(GetType(KnownColor))
        If DBÑerk.Form2.contra.Text = My.Settings.admc And DBÑerk.Form2.user.Text = My.Settings.admu Then
            Me.Exp2()

        Else
            If DBÑerk.Form2.contra.Text = "admin" And DBÑerk.Form2.user.Text = "admin" Then
                Me.Exp2()


            End If
        End If

        Me.Exp()

        Me.reset()
        Me.Slid.Width = 30
        Me.Slid2.Height = 25
        'Me.FINMS()

        'CAMARA combobox auto seleccion
        dispositivos = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        For Each x As FilterInfo In dispositivos
            ComboBox1.Items.Add(x.Name)
        Next
        If ComboBox1 IsNot Nothing Then
        Else
            ComboBox1.SelectedIndex = 0
        End If
        If My.Settings.Imge = "" Then
        Else
            PictureBox2.ImageLocation = (My.Settings.Imge)
            DBÑerk.Form2.PictureBox2.ImageLocation = (My.Settings.Imge)
        End If

    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Tabla1BindingSource.MovePrevious()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Tabla1BindingSource.MoveNext()
    End Sub





    Private Sub Button3_Click(sender As Object, e As EventArgs)

        If MessageBox.Show("¿Quiere borrarlo?", "Delete Record", MessageBoxButtons.YesNo, _
                           MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = _
                       Windows.Forms.DialogResult.Yes Then
            Tabla1BindingSource.RemoveCurrent()
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

        Dim msg As String = "¿Quire salir?. Asegurese de haber guardado"
        Dim title As String = "Finalizar"

        If MessageBox.Show(msg, title, MessageBoxButtons.YesNo, _
                           MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = _
                       Windows.Forms.DialogResult.Yes Then
            Tabla1BindingSource.RemoveCurrent()

            Me.Close() 'Fin
        End If

    End Sub

    ' Private Sub cboDfColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDfColor.SelectedIndexChanged
    '  cboDfColor.BackColor = Color.FromName(cboDfColor.SelectedItem)
    ' txtSearch.Select()

    'End Sub

    'Private Sub cboAltColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAltColor.SelectedIndexChanged
    '   cboAltColor.BackColor = Color.FromName(cboAltColor.SelectedItem)
    '  txtSearch.Select()
    'End Sub

    'COLOREAR *-*
    Private Sub reset()

        Dim txtS As TextBox = txtSearch
        With txtS
            .Text = ""
            .Select()
        End With



        'Color para las celdas CBO
        ' cboDfColor.BackColor = Color.White
        ' cboAltColor.BackColor = Color.White

        If DataGridView1.DataSource Is Nothing Then
            Exit Sub
        End If
        If DataGridView3.DataSource Is Nothing Then
            Exit Sub
        End If

        Dim dgv2 As DataGridView = DataGridView3
        With dgv2
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro
        End With

        Dim dgv1 As DataGridView = DataGridView1
        With dgv1
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro
        End With

    End Sub


    Private Sub dgvFill()

        txtSearch.BackColor = Color.White

        If DataGridView1.DataSource Is Nothing Then
            Exit Sub
        End If


        Dim myDGV1 As DataGridView = DataGridView1
        With myDGV1
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro
        End With

    End Sub

    Private Sub notFound()

        Dim txtS As TextBox = txtSearch
        With txtS
            .BackColor = Color.Azure
            .Select()
            .SelectAll()
        End With

        If DataGridView1.DataSource Is Nothing Then
            Exit Sub
        End If

    End Sub


    Private Function vbNreLine() As String
        Throw New NotImplementedException
    End Function

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fch As String = Format(Now, "dd/MM/yyyy")
        If fch = "" Then
            Exit Sub

        Else

            Dim cantFind As String = fch

            Tabla1BindingSource.Filter = "(Convert(Fecha2, 'System.String') LIKE '" & fch & "')"

            If Tabla1BindingSource.Count <> 0 Then
                With DataGridView1
                    .DataSource = Tabla1BindingSource
                End With

            Else

                MsgBox("-> " & cantFind & vbNewLine & _
                       "No hay vencimientos en esta fecha", _
                        MsgBoxStyle.Information, "Sin vencimiento!")

                Tabla1BindingSource.Filter = Nothing

            End If

        End If

        Exit Sub
    End Sub


    Private Sub Insert2()
        'FUNCIONA PERO CON CONDICION 
        Try
            Dim str As String = "Insert Into Tabla2([Nombre],[Apellido],[Celular],[Fecha2]) Values (?,?,?,?)"
            Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)

            For i = 0 To Tabla1BindingSource1.Count - 1
                ' If (myconnection.State <> ConnectionState.Open) Then
                cmd.Parameters.Clear()
                cmd.Parameters.Add(New OleDbParameter("Nombre", (Tabla1BindingSource1(i)("Nombre"))))
                cmd.Parameters.Add(New OleDbParameter("Apellido", (Tabla1BindingSource1(i)("Apellido"))))
                cmd.Parameters.Add(New OleDbParameter("Celular", (Tabla1BindingSource1(i)("Celular"))))
                cmd.Parameters.Add(New OleDbParameter("Fecha2", (Tabla1BindingSource1(i)("Fecha2"))))

                myconnection.Open()
                cmd.ExecuteNonQuery()
                myconnection.Close()
            Next i

        Catch ex As Exception
            myconnection.Close()
            MsgBox(ex.Message)
        End Try




    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.BuSema()
        Me.Tabla2TableAdapter.Fill(Me.BDDataSet.Tabla2)


    End Sub



    Private Sub BuSema()
        Dim cantFind As String
        Dim fecha As DateTime = DateTime.Today
        cantFind = DateAdd(DateInterval.Day, 0, fecha).ToShortDateString

        If 1 = 1 Then
            Tabla1BindingSource1.Filter = "(Convert(Fecha2, 'System.String') LIKE '" & cantFind & "')"
            If Tabla1BindingSource1.Count >= 1 Then
                Me.Insert2()
            End If
            cantFind = DateAdd(DateInterval.Day, -1, fecha).ToShortDateString
            Tabla1BindingSource1.Filter = "(Convert(Fecha2, 'System.String') LIKE '" & cantFind & "')"
            If Tabla1BindingSource1.Count >= 1 Then
                Me.Insert2()
            End If

            cantFind = DateAdd(DateInterval.Day, -2, fecha).ToShortDateString
            Tabla1BindingSource1.Filter = "(Convert(Fecha2, 'System.String') LIKE '" & cantFind & "')"
            If Tabla1BindingSource1.Count >= 1 Then
                Me.Insert2()
            End If
            cantFind = DateAdd(DateInterval.Day, -3, fecha).ToShortDateString
            Tabla1BindingSource1.Filter = "(Convert(Fecha2, 'System.String') LIKE '" & cantFind & "')"
            If Tabla1BindingSource1.Count >= 1 Then
                Me.Insert2()
            End If
            cantFind = DateAdd(DateInterval.Day, -4, fecha).ToShortDateString
            Tabla1BindingSource1.Filter = "(Convert(Fecha2, 'System.String') LIKE '" & cantFind & "')"
            If Tabla1BindingSource1.Count >= 1 Then
                Me.Insert2()
            End If
            cantFind = DateAdd(DateInterval.Day, -5, fecha).ToShortDateString
            Tabla1BindingSource1.Filter = "(Convert(Fecha2, 'System.String') LIKE '" & cantFind & "')"
            If Tabla1BindingSource1.Count >= 1 Then
                Me.Insert2()
            End If
            cantFind = DateAdd(DateInterval.Day, -6, fecha).ToShortDateString
            Tabla1BindingSource1.Filter = "(Convert(Fecha2, 'System.String') LIKE '" & cantFind & "')"
            If Tabla1BindingSource1.Count >= 1 Then
                Me.Insert2()
            End If
            cantFind = DateAdd(DateInterval.Day, -7, fecha).ToShortDateString
            Tabla1BindingSource1.Filter = "(Convert(Fecha2, 'System.String') LIKE '" & cantFind & "')"
            If Tabla1BindingSource1.Count >= 1 Then
                Me.Insert2()
            End If
            Exit Sub

        Else




        End If

    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
        DBÑerk.Form2.Close()

    End Sub




    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        Me.con()


    End Sub

    Private Sub con()
        If Button7.Visible = False Then
            Me.Slid.Width = 154
            Button7.Visible = True
            Button10.Visible = False
            BCFCU.Visible = True

        Else

            Me.Slid.Width = 30
            Button7.Visible = False
            Button10.Visible = True
            BCFCU.Visible = False


        End If
    End Sub
    Private Sub con2()
        If Button14.Visible = False Then
            'EXPANDIR
            If Slid.Visible = False Then
                Me.Slid2.Height = 97
                BSLM.Visible = True
                Button15.Visible = False
                Button14.Visible = True
            Else
                Me.Slid2.Height = 168
                BSLM.Visible = False
                Button15.Visible = False
                Button14.Visible = True
            End If
        Else

            Me.Slid2.Height = 25
            Button15.Visible = True
            Button14.Visible = False
            BSLM.Visible = False
        End If
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        If MessageBox.Show("¿Quiere borrar todos los Expirados?", "RESETEO COMPLETO", MessageBoxButtons.YesNo, _
           MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = _
       Windows.Forms.DialogResult.Yes Then
            For i = 0 To Tabla2BindingSource.Count - 1
                Tabla2BindingSource.RemoveCurrent()
            Next i
            Tabla2BindingSource.EndEdit()
            Tabla2TableAdapter.Update(BDDataSet.Tabla2)
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

        On Error GoTo searchErr
        If txtSearch.Text = "" Then
            Call notFound()
            Exit Sub

        Else

            Dim cantFind As String = txtSearch.Text
            Me.dgvFill()

            Tabla1BindingSource.Filter = "(Convert(Fecha2, 'System.String') LIKE '*" & txtSearch.Text & "*')" & _
             "OR (Nombre LIKE '*" & txtSearch.Text & "*') OR (Apellido LIKE '*" & txtSearch.Text & "*')" & _
             "OR (Fecha1 LIKE '*" & txtSearch.Text & "*') OR (Celular LIKE '*" & txtSearch.Text & "*') OR (Usasig LIKE '*" & txtSearch.Text & "*')"

            If Tabla1BindingSource.Count <> 0 Then
                With DataGridView1
                    .DataSource = Tabla1BindingSource
                End With

            Else

                Me.notFound()

                MsgBox("-> " & cantFind & vbNewLine & _
                       "No se encontro.", _
                       MsgBoxStyle.Information, "ESO NO EXISTE!")

                Tabla1BindingSource.Filter = Nothing

                With DataGridView1
                    .ClearSelection()
                    .ReadOnly = True
                    .MultiSelect = False
                    .DataSource = Tabla1BindingSource

                End With

            End If

        End If
ErrExit:
        Exit Sub
searchErr:

        MsgBox("Error Number " & Err.Number & vbNreLine() & _
               "Error Description " & Err.Description, MsgBoxStyle.Critical, _
               "Reset Error!")
        Resume ErrExit


    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        On Error GoTo ErrRe
        txtSearch.Select()
        Tabla1BindingSource.Filter = Nothing

        With DataGridView1
            .ClearSelection()
            .ReadOnly = True
            .MultiSelect = False
            .DataSource = Tabla1BindingSource
        End With

        Me.reset()


ErrEx:
        Exit Sub
ErrRe:
        MsgBox("Error Number " & Err.Number & vbNewLine & _
               "Error Description " & Err.Description, MsgBoxStyle.Critical, _
               "Reset Error!")
        Resume ErrEx
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Tabla1BindingSource.AddNew()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If MessageBox.Show("¿Quiere borrarlo?", "Delete Record", MessageBoxButtons.YesNo, _
                   MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = _
               Windows.Forms.DialogResult.Yes Then
            Tabla1BindingSource.RemoveCurrent()
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If TextBox5.Text = "" Then
            TextBox5.Text = "0"
        End If
        Texcrear.Text = ""
        Texcrear2.Text = ""
        On Error GoTo SaveErr
        UsasigTextBox.Text = DBÑerk.Form2.user.Text
        Tabla1BindingSource.EndEdit()
        Tabla1TableAdapter.Update(BDDataSet.Tabla1)
        Me.Tabla1TableAdapter.Fill(Me.BDDataSet.Tabla1)
        MessageBox.Show("Guardado")

ErrEx:

        Exit Sub
SaveErr:
        MsgBox("Error Number " & Err.Number & vbNewLine & _
               "Error Description " & Err.Description, MsgBoxStyle.Critical, _
               "Reset Error!")
        Resume ErrEx
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Dim cantFind As String
        Dim fecha As DateTime = DateTime.Today
        cantFind = DateAdd(DateInterval.Month, 1, fecha).ToShortDateString
        hastatext.Text = cantFind
        desdetext.Text = Format(Now, "dd/MM/yyyy")

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Exp()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        con2()
        Me.Exp()
    End Sub

    Public Sub Reseteodefecha()
        Dim fechahoy As DateTime = DateTime.Today
        Dim fechafin As String
        fechafin = DateAdd(DateInterval.Month, 2, fechahoy).Month
        My.Settings.mes = fechafin
        My.Settings.Save()

    End Sub

    Private Sub fmr()
        Form2.Show()
        If 1 = 1 Then
            Me.Visible = False
            DBÑerk.Form2.Panel1.Visible = False
        End If
    End Sub


    Private Sub usuarios_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TURNOF()
        If DBÑerk.Form2.user.Text = DBÑerk.Form2.confuser.Text Then
            'Me.Usuario1()
        Else
            If DBÑerk.Form2.user.Text = DBÑerk.Form2.confuser2.Text Then
                'Me.usuario2()
            Else
                If DBÑerk.Form2.user.Text = DBÑerk.Form2.confuser3.Text Then
                    ' Me.Usuario3()
                End If
            End If

        End If


        Me.Close()
        DBÑerk.Form2.Visible = True
        DBÑerk.Form2.Panel1.Visible = True


        Me.ret()
        My.Forms.Form2.Salida.Visible = True
    End Sub
    Private Sub ret()
        Dim pas As TextBox = DBÑerk.Form2.contra
        With pas
            .Text = "CONTRASEÑA"
        End With
        Dim us As TextBox = DBÑerk.Form2.user
        With us
            .Text = "USUARIO"
        End With
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            OpenFileDialog1.Title = "Abrir Imagen"
            OpenFileDialog1.FileName = "Imagenes"
            OpenFileDialog1.Filter = "All Files |*.*"
            OpenFileDialog1.ShowDialog()
            FotoPictureBox.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)

        Catch ex As Exception

            'Do Nothing End Try 

        End Try
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Dim msg As String = "¿Quire salir?. Asegurese de haber guardado"
        Dim title As String = "Finalizar"

        If MessageBox.Show(msg, title, MessageBoxButtons.YesNo, _
                           MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = _
                       Windows.Forms.DialogResult.Yes Then
            'Tabla1BindingSource.RemoveCurrent()

            Me.Close() 'Fin
            DBÑerk.Form2.Close()
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Close() 'Fin
        DBÑerk.Form2.Close()
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Me.con()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.con()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles CONT.Click
        con2()
        Me.Exp2()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        On Error GoTo searchErr
        If txtSearch2.Text = "" Then
            Dim txtS As TextBox = txtSearch2
            With txtS
                .BackColor = Color.Azure
                .Select()
                .SelectAll()
            End With
            Exit Sub

        Else

            Dim cantFind As String = txtSearch2.Text
            Me.dgvFill()

            Tabla3BindingSource.Filter = "(Convert(Horarios, 'System.String') LIKE '*" & txtSearch2.Text & "*')" & _
             "OR (Nombre LIKE '*" & txtSearch2.Text & "*')"

            If Tabla3BindingSource.Count <> 0 Then
                With DataTurnos
                    .DataSource = Tabla3BindingSource
                End With

            Else

                Me.notFound()

                MsgBox("-> " & cantFind & vbNewLine & _
                       "No se encontro.", _
                       MsgBoxStyle.Information, "ESO NO EXISTE!")

                Tabla1BindingSource.Filter = Nothing

                With DataTurnos
                    .ClearSelection()
                    .ReadOnly = True
                    .MultiSelect = False
                    .DataSource = Tabla3BindingSource

                End With

            End If

        End If
ErrExit:
        Exit Sub
searchErr:

        MsgBox("Error Number " & Err.Number & vbNreLine() & _
               "Error Description " & Err.Description, MsgBoxStyle.Critical, _
               "Reset Error!")
        Resume ErrExit

    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        On Error GoTo ErrRe
        txtSearch2.Select()
        Tabla3BindingSource.Filter = Nothing
        Me.Tabla3TableAdapter.Fill(Me.BDDataSet.Tabla3)
        With DataTurnos
            .ClearSelection()
            .ReadOnly = True
            .MultiSelect = False
            .DataSource = Tabla3BindingSource
        End With

        Dim txtS As TextBox = txtSearch2
        With txtS
            .Text = ""
            .Select()
        End With


ErrEx:
        Exit Sub
ErrRe:
        MsgBox("Error Number " & Err.Number & vbNewLine & _
               "Error Description " & Err.Description, MsgBoxStyle.Critical, _
               "Reset Error!")
        Resume ErrEx
    End Sub
    Public Sub TURNO()
        Tabla3BindingSource.AddNew()
        Dim cuenta As String = My.Settings.cph
        Hora.Text = Format(Now, "dd/MM/yyyy hh:mm")
        Nec.Text = cuenta + " Inicio"
        Tabla3BindingSource.EndEdit()
        Tabla3TableAdapter.Update(BDDataSet.Tabla3)

    End Sub
    Private Sub TURNOF()
        Tabla3BindingSource.AddNew()
        Dim cuenta As String = My.Settings.cph
        Hora.Text = Format(Now, "dd/MM/yyyy hh:mm")
        Nec.Text = cuenta + " Finalizo"
        Tabla3BindingSource.EndEdit()
        Tabla3TableAdapter.Update(BDDataSet.Tabla3)
    End Sub


    Private Sub EXPA_Click(sender As Object, e As EventArgs) Handles EXPA.Click
        Me.Exp2()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click

        If MessageBox.Show("¿Quiere borrar todo El Registro de pagos de esta tabla?", "RESETEO COMPLETO", MessageBoxButtons.YesNo, _
          MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = _
      Windows.Forms.DialogResult.Yes Then
            For i = 0 To Tabla3BindingSource.Count - 1
                Tabla3BindingSource.RemoveCurrent()
            Next i
            Tabla3BindingSource.EndEdit()
            Tabla3TableAdapter.Update(BDDataSet.Tabla3)
        End If
    End Sub
    Public Sub Expandir()
        Dim ABC As Integer = 1043
        Dim AB As Integer = 815
        Dim AC As Integer = 680
        Dim D As Integer = 592
        Dim C As Integer = 228
        Dim A As Integer = 452
        Dim B As Integer = 363
    End Sub

    Private Sub Exp()
        If Button2.Visible = True Then
            'CONTRAE
            Me.Width = 451
            'CONTRAE Y EXP
            Button2.Visible = False
            Button3.Visible = True

            'BOTONES DE MIN Y MAX
            Button6.Visible = True
            Label7.Visible = True
            EXPA4.Visible = True

            'DETALLES DE LOGO
            PictureBox13.Visible = True
            Label2.Visible = False

            'SLIDER DE CONFIGURACION
            If Slid.Visible = True Then
                'expandir para administrador
                EXPA.Visible = True
                EXPA2.Visible = True
            End If
        Else
            'EXPANDE
            Me.Width = 815
            'CONT
            Button2.Visible = True
            'NOSE

            'DETALLES DE LOGO
            PictureBox13.Visible = False
            Label2.Visible = True

            'salir y min
            If Slid.Visible = True Then
                'expandir para administrador
                Button9.Location = New Point(784, -1)
                Label8.Location = New Point(752, -15)
            Else
                Label8.Location = New Point(784, -15)
            End If
            Label7.Visible = False
            Button6.Visible = False

            'PANELES O PESTAÑAS
            Panel1.Visible = False
            Panel3.Visible = False
            Panel4.Visible = False
            PanelExp.Visible = True
            'BOTONES expandir
            Button3.Visible = False
            EXPA4.Visible = False
            EXPA.Visible = False
            EXPA2.Visible = False
            'TITULOS
            LABEXP.Visible = True
            LABTUR.Visible = False
            LABPAG.Visible = False
            CGQ.Visible = False
            'SLID2
            Button14.Visible = False
            BSLM.Visible = False
        End If


1359:

    End Sub
    Private Sub Exp2()
        If CONT.Visible = True Then
            'CONTRAE
            Me.Width = 451
            CONT.Visible = False

            'EXPANDIR
            EXPA.Visible = True
            EXPA4.Visible = True
            Button3.Visible = True
            EXPA2.Visible = True
            'DETALLES DE LOGO
            PictureBox13.Visible = True
            Label2.Visible = False
            'BOTONES DE MIN Y MAX
            Button6.Visible = True
            Label7.Visible = True

        Else
            'EXPANDE
            Me.Width = 680
            'PANELES O PESTAÑAS
            PanelExp.Visible = False
            Panel1.Visible = False
            Panel3.Visible = True
            Panel4.Visible = False

            'CONTRA
            CONT.Visible = True
            'BOTONES  EXPANDIR
            EXPA.Visible = False
            Button3.Visible = False
            EXPA2.Visible = False
            EXPA4.Visible = False
            ' SALIR O MIN
            Button9.Location = New Point(644, -1)
            Label8.Location = New Point(612, -15)
            Button6.Visible = False
            Label7.Visible = False
            'TITULOS
            LABEXP.Visible = False
            LABTUR.Visible = True
            CGQ.Visible = False
            LABPAG.Visible = False
            'DETALLES DE LOGO
            PictureBox13.Visible = False
            Label2.Visible = True
            'SLID2
            BSLM.Visible = False
            Button14.Visible = False

        End If
    End Sub
    Private Sub Exp3()

        If CONT2.Visible = True Then
            'CONTRAE
            Me.Width = 451
            CONT2.Visible = False


            'EXPANDIR BOTONES
            EXPA4.Visible = True
            Button3.Visible = True
            EXPA.Visible = True
            EXPA2.Visible = True
            'DETALLES DE LOGO
            PictureBox13.Visible = True
            Label2.Visible = False
            'BOTONES DE MIN Y MAX
            Button6.Visible = True
            Label7.Visible = True
        Else
            'EXPANDE
            Me.Width = 1043
            'PANELES O PESTAÑAS
            PanelExp.Visible = False
            Panel3.Visible = False
            Panel4.Visible = False
            Panel1.Visible = True

            CONT2.Visible = True

            'SALIR Y MIN
            Button9.Location = New Point(1011, -2)
            Label8.Location = New Point(979, -16)
            Button6.Visible = False
            Label7.Visible = False
            'BOTONES DE EXPANDIR
            Button3.Visible = False
            EXPA.Visible = False
            EXPA2.Visible = False
            EXPA4.Visible = False
            'TITULOS
            LABEXP.Visible = False
            LABTUR.Visible = False
            CGQ.Visible = False
            LABPAG.Visible = True
            'DETALLES DE LOGO
            PictureBox13.Visible = False
            Label2.Visible = True
            'SLID2
            Button14.Visible = False
            BSLM.Visible = False
            '1
            If DBÑerk.Form2.confuser.Text = "" Then
            Else
                Grouser.Text = DBÑerk.Form2.confuser.Text
            End If
            '3
            If DBÑerk.Form2.confuser3.Text = "" Then
            Else
                Grouser3.Text = DBÑerk.Form2.confuser3.Text
            End If
            '2
            If DBÑerk.Form2.confuser2.Text = "" Then
            Else
                Grouser2.Text = DBÑerk.Form2.confuser2.Text
            End If
        End If
    End Sub
    Private Sub Exp4()

        If CONT4.Visible = True Then
            'CONTRAE
            Me.Width = 451
            CONT4.Visible = False

            'BOTONES EXPANDIR
            EXPA4.Visible = True
            Button3.Visible = True
            'DETALLES DE LOGO
            PictureBox13.Visible = True
            Label2.Visible = False
            'BOTONES DE MIN Y MAX
            Button6.Visible = True
            Label7.Visible = True
            'SLIDER DE CONFIGURACION
            If Slid.Visible = True Then
                'expandir para administrador
                EXPA.Visible = True
                EXPA2.Visible = True
            End If
        Else
            'EXPANDE
            Me.Width = 331 + 451
            'PANELES O PESTAÑAS
            PanelExp.Visible = False
            Panel3.Visible = False
            Panel1.Visible = False
            Panel4.Visible = True

            CONT4.Visible = True

            'BOTONES SALIR Y MIN
            If Slid.Visible = True Then
                'expandir para administrador
                Button9.Location = New Point(750, -1)
                Label8.Location = New Point(718, -15)
            Else
                Label8.Location = New Point(750, -15)
            End If

            Button6.Visible = False
            Label7.Visible = False
            'EXPANDIR BOTONES
            Button3.Visible = False
            EXPA.Visible = False
            EXPA4.Visible = False
            EXPA2.Visible = False
            'titulos
            LABEXP.Visible = False
            LABTUR.Visible = False
            CGQ.Visible = True
            LABPAG.Visible = False
            'DETALLES DE LOGO
            PictureBox13.Visible = False
            Label2.Visible = True
            'SLID2
            Button14.Visible = False
            BSLM.Visible = False

        End If
    End Sub

    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles EXPA2.Click
        Me.Exp3()
    End Sub

    Private Sub CONT2_Click(sender As Object, e As EventArgs) Handles CONT2.Click
        con2()
        Me.Exp3()
    End Sub

    Private Sub Usuario1()
        'FUNCIONA PERO CON CONDICION 
        Try
            Dim str As String = "Insert Into Us1([Nombre],[Apellido],[Monto],[Usasig]) Values (?,?,?,?)"
            Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)

            For i = 0 To Tabla1BindingSource.Count - 1
                ' If (myconnection.State <> ConnectionState.Open) Then
                cmd.Parameters.Clear()
                cmd.Parameters.Add(New OleDbParameter("Nombre", (Tabla1BindingSource(i)("Nombre"))))
                cmd.Parameters.Add(New OleDbParameter("Apellido", (Tabla1BindingSource(i)("Apellido"))))
                cmd.Parameters.Add(New OleDbParameter("Monto", (Tabla1BindingSource(i)("Celular"))))
                cmd.Parameters.Add(New OleDbParameter("Usasig", (Tabla1BindingSource(i)("Usasig"))))

                myconnection.Open()
                cmd.ExecuteNonQuery()
                myconnection.Close()
            Next i

        Catch ex As Exception
            myconnection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub usuario2()
        'FUNCIONA PERO CON CONDICION 
        Try
            Dim str As String = "Insert Into Us2([Nombre],[Apellido],[Monto],[Usasig]) Values (?,?,?,?)"
            Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)

            For i = 0 To Tabla1BindingSource.Count - 1
                ' If (myconnection.State <> ConnectionState.Open) Then
                cmd.Parameters.Clear()
                cmd.Parameters.Add(New OleDbParameter("Nombre", (Tabla1BindingSource(i)("Nombre"))))
                cmd.Parameters.Add(New OleDbParameter("Apellido", (Tabla1BindingSource(i)("Apellido"))))
                cmd.Parameters.Add(New OleDbParameter("Monto", (Tabla1BindingSource(i)("Celular"))))
                cmd.Parameters.Add(New OleDbParameter("Usasig", (Tabla1BindingSource(i)("Usasig"))))

                myconnection.Open()
                cmd.ExecuteNonQuery()
                myconnection.Close()
            Next i

        Catch ex As Exception
            myconnection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Usuario3()
        'FUNCIONA PERO CON CONDICION 
        Try
            Dim str As String = "Insert Into Us3([Nombre],[Apellido],[Monto],[Usasig]) Values (?,?,?,?)"
            Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)

            For i = 0 To Tabla1BindingSource.Count - 1
                ' If (myconnection.State <> ConnectionState.Open) Then
                cmd.Parameters.Clear()
                cmd.Parameters.Add(New OleDbParameter("Nombre", (Tabla1BindingSource(i)("Nombre"))))
                cmd.Parameters.Add(New OleDbParameter("Apellido", (Tabla1BindingSource(i)("Apellido"))))
                cmd.Parameters.Add(New OleDbParameter("Monto", (Tabla1BindingSource(i)("Celular"))))
                cmd.Parameters.Add(New OleDbParameter("Usasig", (Tabla1BindingSource(i)("Usasig"))))

                myconnection.Open()
                cmd.ExecuteNonQuery()
                myconnection.Close()
            Next i

        Catch ex As Exception
            myconnection.Close()
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TextBox5.Focus()
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Asc(e.KeyChar) = 13 Then

        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

        If Asc(e.KeyChar) = 13 Then
            TextBox2.Focus()
        End If
    End Sub


    Private Sub Button11_Click_2(sender As Object, e As EventArgs) Handles Button11.Click
        Chart1.Series(0).Points.Clear()

        Dim Us As String
        Dim Us3 As String
        Dim Us2 As String
        Us = DBÑerk.Form2.confuser.Text
        Us3 = DBÑerk.Form2.confuser3.Text
        Us2 = DBÑerk.Form2.confuser2.Text

        Dim to1 As String
        Dim to2 As String
        Dim to3 As String
        to3 = TextUs3.Text
        to1 = TextUs1.Text
        to2 = TextUs2.Text

        Me.Chart1.Series("Series1").Points.AddXY("" & Us & vbNewLine & _
                       "", to1)

        Me.Chart1.Series("Series1").Points.AddXY("" & Us2 & vbNewLine & _
                       "", to2)

        Me.Chart1.Series("Series1").Points.AddXY("" & Us3 & vbNewLine & _
                       "", to3)
    End Sub


    Private Sub bosus_Click(sender As Object, e As EventArgs) Handles bosus.Click
        Dim Total As Double = 0
        Dim Total2 As Double = 0
        Dim Total3 As Double = 0
        Dim Fila As DataGridViewRow = New DataGridViewRow()


        For Each Fila In DataGridView4.Rows
            Total3 += Convert.ToDouble(Fila.Cells("monus3").Value)

        Next
        TextUs3.Text = Convert.ToString(Total3)

        For Each Fila In DataGridView8.Rows
            Total2 += Convert.ToDouble(Fila.Cells("monus2").Value)
        Next
        TextUs2.Text = Convert.ToString(Total2)

        For Each Fila In DataGridView5.Rows
            Total += Convert.ToDouble(Fila.Cells("monus").Value)
        Next
        TextUs1.Text = Convert.ToString(Total)





        Grouser.Text = DBÑerk.Form2.confuser.Text
        Grouser2.Text = DBÑerk.Form2.confuser2.Text
        Grouser3.Text = DBÑerk.Form2.confuser3.Text
        Laus3.Text = "Monto de " + DBÑerk.Form2.confuser3.Text
        Laus.Text = "Monto de " + DBÑerk.Form2.confuser.Text
        Laus2.Text = "Monto de " + DBÑerk.Form2.confuser2.Text
    End Sub
    Private Sub Bumonto()
        Dim bususe1 As String
        Dim bususe2 As String
        Dim bususe3 As String
        bususe3 = DBÑerk.Form2.confuser3.Text
        bususe2 = DBÑerk.Form2.confuser2.Text
        bususe1 = DBÑerk.Form2.confuser.Text
        If 1 = 1 Then
            Tabla1BindingSource.Filter = "(Convert(Usasig, 'System.String') LIKE '*" & bususe1 & "*')"
            If Tabla1BindingSource.Count >= 1 Then
                Me.Usuario1()
            End If

            Tabla1BindingSource.Filter = "(Convert(Usasig, 'System.String') LIKE '" & bususe2 & "')"
            If Tabla1BindingSource.Count >= 1 Then
                Me.usuario2()
            End If

            Tabla1BindingSource.Filter = "(Convert(Usasig, 'System.String') LIKE '" & bususe3 & "')"
            If Tabla1BindingSource.Count >= 1 Then
                Me.Usuario3()
            End If

        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.Bumonto()
        Me.Us1TableAdapter.Fill(Me.BDDataSet.Us1)
        Me.Us2TableAdapter.Fill(Me.BDDataSet.Us2)
        Me.Us3TableAdapter.Fill(Me.BDDataSet.Us3)
        Tabla1BindingSource.Filter = Nothing
    End Sub



    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        If MessageBox.Show("¿Quiere borrar todo El Registro de pagos de esta tabla?", "RESETEO COMPLETO", MessageBoxButtons.YesNo, _
           MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = _
       Windows.Forms.DialogResult.Yes Then
            For i = 0 To Us2BindingSource.Count - 1
                Us2BindingSource.RemoveCurrent()
            Next i
            Us2BindingSource.EndEdit()
            Us2TableAdapter.Update(BDDataSet.Us2)
        End If

    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        If MessageBox.Show("¿Quiere borrar todo El Registro de pagos de esta tabla?", "RESETEO COMPLETO", MessageBoxButtons.YesNo, _
           MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = _
       Windows.Forms.DialogResult.Yes Then
            For i = 0 To Us1BindingSource.Count - 1
                Us1BindingSource.RemoveCurrent()
            Next i
            Us1BindingSource.EndEdit()
            Us1TableAdapter.Update(BDDataSet.Us1)
        End If

    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        If MessageBox.Show("¿Quiere borrar todo El Registro de pagos de esta tabla?", "RESETEO COMPLETO", MessageBoxButtons.YesNo, _
           MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) = _
       Windows.Forms.DialogResult.Yes Then
            For i = 0 To Us3BindingSource.Count - 1
                Us3BindingSource.RemoveCurrent()
            Next i
            Us3BindingSource.EndEdit()
            Us3TableAdapter.Update(BDDataSet.Us3)
        End If

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        con2()

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        con2()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles EXPA4.Click
        Exp4()
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles CONT4.Click
        Exp4()
        con2()
    End Sub

    Private Sub BSLM_Click(sender As Object, e As EventArgs) Handles BSLM.Click
        con2()

    End Sub
    Private Sub Button16_Click_1(sender As Object, e As EventArgs) Handles Button16.Click
        Me.Close()
        DBÑerk.Form2.Visible = True
        DBÑerk.Form2.Panel1.Visible = True
        Me.ret()
        My.Forms.Form2.Salida.Visible = True
    End Sub


    Private Sub BCFCU_Click(sender As Object, e As EventArgs) Handles BCFCU.Click
        Me.fmr()
        My.Forms.Form2.Salida.Visible = False
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        SaveFileDialog1.DefaultExt = ".PNG"
        SaveFileDialog1.FileName = Texcrear.Text 'SE USARA ESE NOMBRE PARA GUARDAR

        If SaveFileDialog1.ShowDialog Then
            Try 'GUARDA LA IMAGEN 
                Pictcrear.Image.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Png)
                MsgBox("GUARDADO")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles BCQR.Click
        Dim GENERADOR As BarcodeWriter = New BarcodeWriter 'INICIA EL GENERADOR
        GENERADOR.Format = BarcodeFormat.QR_CODE
        Try
            Dim texnom As String = Texcrear.Text
            Dim texape As String = Texcrear2.Text
            Dim texcompleto As String
            texcompleto = texape + " " + texnom
            TexQRC.Text = texcompleto
            Dim IMG As Bitmap = New Bitmap(GENERADOR.Write(texcompleto), Pictcrear.Width, Pictcrear.Height)
            Pictcrear.Image = IMG
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles Button13.Click
        If TextBox5.Text = "" Then
            TextBox5.Text = "0"
        End If
        If Checkasg.Checked Then
            UsasigTextBox.Text = DBÑerk.Form2.user.Text
        Else
        End If
        Tabla1BindingSource.EndEdit()
        Tabla1TableAdapter.Update(BDDataSet.Tabla1)
        Me.Tabla1TableAdapter.Fill(Me.BDDataSet.Tabla1)
        MessageBox.Show("QR Guardado")
    End Sub

    Private Sub Checkasg_CheckedChanged(sender As Object, e As EventArgs) Handles Checkasg.CheckedChanged
        If Checkasg.Checked Then
            Checkasg.Text = "Desasignar Usuario"
        Else
            Checkasg.Text = "Asignar usuario"
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        On Error GoTo searchErr
        If Texver.Text = "" Then
            Dim txtS As TextBox = Texver
            With txtS
                .BackColor = Color.Azure
                .Select()
                .SelectAll()
            End With
            Exit Sub

        Else

            Dim cantFind As String = Texver.Text
            Me.dgvFill()

            Tabla1BindingSource.Filter = "(Convert(ASCGQR, 'System.String') LIKE '*" & Texver.Text & "*')"
            If Tabla1BindingSource.Count <> 0 Then
                With DataGridView1
                    .DataSource = Tabla1BindingSource
                End With

            Else

                Me.notFound()

                MsgBox("-> " & cantFind & vbNewLine & _
                       "No se encontro.", _
                       MsgBoxStyle.Information, " NO EXISTE!")

                Tabla1BindingSource.Filter = Nothing

                With DataGridView1
                    .ClearSelection()
                    .ReadOnly = True
                    .MultiSelect = False
                    .DataSource = Tabla1BindingSource

                End With

            End If

        End If
ErrExit:
        Exit Sub
searchErr:

        MsgBox("Error Number " & Err.Number & vbNreLine() & _
               "Error Description " & Err.Description, MsgBoxStyle.Critical, _
               "Reset Error!")
        Resume ErrExit


    End Sub

    Private Sub Button20_Click_1(sender As Object, e As EventArgs) Handles Button20.Click
        Timer1.Enabled = True
        Timer1.Start()
        FuenteVideo = New VideoCaptureDevice(dispositivos(ComboBox1.SelectedIndex).MonikerString)
        VSverif.VideoSource = FuenteVideo
        VSverif.Start()

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Timer1.Enabled = False
        VSverif.Stop()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim IMAGEN As New Bitmap(VSverif.GetCurrentVideoFrame)
            Dim DECOD As BarcodeReader = New BarcodeReader
            Texver.Text = DECOD.Decode(IMAGEN).ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Configuracion.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub hastatext_TextChanged(sender As Object, e As EventArgs) Handles hastatext.TextChanged

    End Sub
End Class
