Imports ZXing
Public Class Camara

    Private Sub Acercade_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim IMAGEN As New Bitmap(VSverif.GetCurrentVideoFrame)
            Dim DECOD As BarcodeReader = New BarcodeReader
            WindowsApplication1.Form1.Texver.Text = DECOD.Decode(IMAGEN).ToString
        Catch ex As Exception
        End Try
    End Sub
End Class