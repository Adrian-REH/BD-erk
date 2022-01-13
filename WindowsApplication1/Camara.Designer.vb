<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Camara
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.VSverif = New AForge.Controls.VideoSourcePlayer()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'VSverif
        '
        Me.VSverif.Location = New System.Drawing.Point(52, 28)
        Me.VSverif.Name = "VSverif"
        Me.VSverif.Size = New System.Drawing.Size(259, 197)
        Me.VSverif.TabIndex = 0
        Me.VSverif.Text = "VideoSourcePlayer1"
        Me.VSverif.VideoSource = Nothing
        '
        'Acercade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 309)
        Me.Controls.Add(Me.VSverif)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Acercade"
        Me.Text = "Acercade"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents VSverif As AForge.Controls.VideoSourcePlayer
End Class
