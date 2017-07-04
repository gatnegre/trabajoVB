<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormComboListas
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LblTextoaAnadir = New System.Windows.Forms.Label()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.CmbTextos = New System.Windows.Forms.ComboBox()
        Me.BtnPasar = New System.Windows.Forms.Button()
        Me.BtnQuitar = New System.Windows.Forms.Button()
        Me.ChkListTextos = New System.Windows.Forms.CheckedListBox()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 33)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(215, 20)
        Me.TextBox1.TabIndex = 0
        '
        'LblTextoaAnadir
        '
        Me.LblTextoaAnadir.AutoSize = True
        Me.LblTextoaAnadir.Location = New System.Drawing.Point(10, 9)
        Me.LblTextoaAnadir.Name = "LblTextoaAnadir"
        Me.LblTextoaAnadir.Size = New System.Drawing.Size(76, 13)
        Me.LblTextoaAnadir.TabIndex = 1
        Me.LblTextoaAnadir.Text = "Texto a Añadir"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(153, 77)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 2
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'CmbTextos
        '
        Me.CmbTextos.FormattingEnabled = True
        Me.CmbTextos.Location = New System.Drawing.Point(13, 126)
        Me.CmbTextos.Name = "CmbTextos"
        Me.CmbTextos.Size = New System.Drawing.Size(215, 21)
        Me.CmbTextos.TabIndex = 3
        '
        'BtnPasar
        '
        Me.BtnPasar.Location = New System.Drawing.Point(271, 77)
        Me.BtnPasar.Name = "BtnPasar"
        Me.BtnPasar.Size = New System.Drawing.Size(75, 23)
        Me.BtnPasar.TabIndex = 4
        Me.BtnPasar.Text = "Pasar"
        Me.BtnPasar.UseVisualStyleBackColor = True
        '
        'BtnQuitar
        '
        Me.BtnQuitar.Location = New System.Drawing.Point(271, 126)
        Me.BtnQuitar.Name = "BtnQuitar"
        Me.BtnQuitar.Size = New System.Drawing.Size(75, 23)
        Me.BtnQuitar.TabIndex = 5
        Me.BtnQuitar.Text = "Quitar"
        Me.BtnQuitar.UseVisualStyleBackColor = True
        '
        'ChkListTextos
        '
        Me.ChkListTextos.FormattingEnabled = True
        Me.ChkListTextos.Location = New System.Drawing.Point(380, 33)
        Me.ChkListTextos.Name = "ChkListTextos"
        Me.ChkListTextos.Size = New System.Drawing.Size(155, 94)
        Me.ChkListTextos.TabIndex = 6
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(541, 9)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TrackBar1.Size = New System.Drawing.Size(45, 170)
        Me.TrackBar1.TabIndex = 7
        Me.TrackBar1.Value = 10
        '
        'FormComboListas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 321)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.ChkListTextos)
        Me.Controls.Add(Me.BtnQuitar)
        Me.Controls.Add(Me.BtnPasar)
        Me.Controls.Add(Me.CmbTextos)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.LblTextoaAnadir)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "FormComboListas"
        Me.Text = "FormComboListas"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LblTextoaAnadir As Label
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents CmbTextos As ComboBox
    Friend WithEvents BtnPasar As Button
    Friend WithEvents BtnQuitar As Button
    Friend WithEvents ChkListTextos As CheckedListBox
    Friend WithEvents TrackBar1 As TrackBar
End Class
