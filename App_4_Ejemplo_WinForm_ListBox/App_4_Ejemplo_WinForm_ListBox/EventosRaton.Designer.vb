<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EventosRaton
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
        Me.LblBotones = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblBotones
        '
        Me.LblBotones.AutoSize = True
        Me.LblBotones.Location = New System.Drawing.Point(58, 165)
        Me.LblBotones.Name = "LblBotones"
        Me.LblBotones.Size = New System.Drawing.Size(100, 13)
        Me.LblBotones.TabIndex = 0
        Me.LblBotones.Text = "Numero de botones"
        '
        'PictureBox1
        '
        Me.PictureBox1.ImageLocation = "https://s-media-cache-ak0.pinimg.com/736x/96/94/39/96943921cecd1fbbca817cbbdaf645" &
    "f5.jpg"
        Me.PictureBox1.Location = New System.Drawing.Point(43, 65)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 163)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'EventosRaton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblBotones)
        Me.Name = "EventosRaton"
        Me.Text = "EventosRaton"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblBotones As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
