﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCalculoFiguras
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadCirculo = New System.Windows.Forms.RadioButton()
        Me.radRectangulo = New System.Windows.Forms.RadioButton()
        Me.GrupoRectangulo = New System.Windows.Forms.GroupBox()
        Me.NumPerimetro = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumArea = New System.Windows.Forms.NumericUpDown()
        Me.NumAncho = New System.Windows.Forms.NumericUpDown()
        Me.NumAlto = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrupoCirculo = New System.Windows.Forms.GroupBox()
        Me.NumPerimetroCirc = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NumRadio = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumRec2 = New System.Windows.Forms.NumericUpDown()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.PestañaRectangulo = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NumRadio2 = New System.Windows.Forms.NumericUpDown()
        Me.cbxTipoCalculo = New System.Windows.Forms.ComboBox()
        Me.PestañaCirculo = New System.Windows.Forms.TabPage()
        Me.NumPerimetroCirc3 = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.NumRec3 = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NumRadio3 = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GrupoRectangulo.SuspendLayout()
        CType(Me.NumPerimetro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumAncho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumAlto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrupoCirculo.SuspendLayout()
        CType(Me.NumPerimetroCirc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumRadio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumRec2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.PestañaRectangulo.SuspendLayout()
        CType(Me.NumRadio2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PestañaCirculo.SuspendLayout()
        CType(Me.NumPerimetroCirc3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumRec3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumRadio3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadCirculo)
        Me.GroupBox1.Controls.Add(Me.radRectangulo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(285, 118)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione una figura"
        '
        'RadCirculo
        '
        Me.RadCirculo.AutoSize = True
        Me.RadCirculo.Location = New System.Drawing.Point(25, 81)
        Me.RadCirculo.Name = "RadCirculo"
        Me.RadCirculo.Size = New System.Drawing.Size(96, 28)
        Me.RadCirculo.TabIndex = 1
        Me.RadCirculo.TabStop = True
        Me.RadCirculo.Text = "Circulos"
        Me.RadCirculo.UseVisualStyleBackColor = True
        '
        'radRectangulo
        '
        Me.radRectangulo.AutoSize = True
        Me.radRectangulo.Location = New System.Drawing.Point(25, 46)
        Me.radRectangulo.Name = "radRectangulo"
        Me.radRectangulo.Size = New System.Drawing.Size(133, 28)
        Me.radRectangulo.TabIndex = 0
        Me.radRectangulo.TabStop = True
        Me.radRectangulo.Text = "Rectangulos"
        Me.radRectangulo.UseVisualStyleBackColor = True
        '
        'GrupoRectangulo
        '
        Me.GrupoRectangulo.Controls.Add(Me.NumPerimetro)
        Me.GrupoRectangulo.Controls.Add(Me.Label4)
        Me.GrupoRectangulo.Controls.Add(Me.NumArea)
        Me.GrupoRectangulo.Controls.Add(Me.NumAncho)
        Me.GrupoRectangulo.Controls.Add(Me.NumAlto)
        Me.GrupoRectangulo.Controls.Add(Me.Label3)
        Me.GrupoRectangulo.Controls.Add(Me.Label2)
        Me.GrupoRectangulo.Controls.Add(Me.Label1)
        Me.GrupoRectangulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoRectangulo.Location = New System.Drawing.Point(12, 185)
        Me.GrupoRectangulo.Name = "GrupoRectangulo"
        Me.GrupoRectangulo.Size = New System.Drawing.Size(296, 156)
        Me.GrupoRectangulo.TabIndex = 1
        Me.GrupoRectangulo.TabStop = False
        Me.GrupoRectangulo.Text = "Rectangulo:"
        Me.GrupoRectangulo.Visible = False
        '
        'NumPerimetro
        '
        Me.NumPerimetro.Location = New System.Drawing.Point(112, 122)
        Me.NumPerimetro.Name = "NumPerimetro"
        Me.NumPerimetro.ReadOnly = True
        Me.NumPerimetro.Size = New System.Drawing.Size(120, 29)
        Me.NumPerimetro.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Perimetro"
        '
        'NumArea
        '
        Me.NumArea.DecimalPlaces = 2
        Me.NumArea.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumArea.Location = New System.Drawing.Point(112, 80)
        Me.NumArea.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumArea.Name = "NumArea"
        Me.NumArea.ReadOnly = True
        Me.NumArea.Size = New System.Drawing.Size(120, 29)
        Me.NumArea.TabIndex = 5
        '
        'NumAncho
        '
        Me.NumAncho.DecimalPlaces = 2
        Me.NumAncho.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumAncho.Location = New System.Drawing.Point(112, 27)
        Me.NumAncho.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumAncho.Name = "NumAncho"
        Me.NumAncho.Size = New System.Drawing.Size(120, 29)
        Me.NumAncho.TabIndex = 2
        '
        'NumAlto
        '
        Me.NumAlto.DecimalPlaces = 2
        Me.NumAlto.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumAlto.Location = New System.Drawing.Point(112, 53)
        Me.NumAlto.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumAlto.Name = "NumAlto"
        Me.NumAlto.Size = New System.Drawing.Size(120, 29)
        Me.NumAlto.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Area"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Alto:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ancho:"
        '
        'GrupoCirculo
        '
        Me.GrupoCirculo.Controls.Add(Me.NumPerimetroCirc)
        Me.GrupoCirculo.Controls.Add(Me.Label6)
        Me.GrupoCirculo.Controls.Add(Me.Label7)
        Me.GrupoCirculo.Controls.Add(Me.NumRadio)
        Me.GrupoCirculo.Controls.Add(Me.Label5)
        Me.GrupoCirculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrupoCirculo.Location = New System.Drawing.Point(71, 406)
        Me.GrupoCirculo.Name = "GrupoCirculo"
        Me.GrupoCirculo.Size = New System.Drawing.Size(285, 176)
        Me.GrupoCirculo.TabIndex = 2
        Me.GrupoCirculo.TabStop = False
        Me.GrupoCirculo.Text = "Circulo"
        '
        'NumPerimetroCirc
        '
        Me.NumPerimetroCirc.Location = New System.Drawing.Point(124, 147)
        Me.NumPerimetroCirc.Name = "NumPerimetroCirc"
        Me.NumPerimetroCirc.ReadOnly = True
        Me.NumPerimetroCirc.Size = New System.Drawing.Size(120, 29)
        Me.NumPerimetroCirc.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 24)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Perimetro"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 24)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Area"
        '
        'NumRadio
        '
        Me.NumRadio.Location = New System.Drawing.Point(112, 59)
        Me.NumRadio.Name = "NumRadio"
        Me.NumRadio.Size = New System.Drawing.Size(132, 29)
        Me.NumRadio.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Radio"
        '
        'NumRec2
        '
        Me.NumRec2.DecimalPlaces = 2
        Me.NumRec2.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumRec2.Location = New System.Drawing.Point(10, 72)
        Me.NumRec2.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumRec2.Name = "NumRec2"
        Me.NumRec2.ReadOnly = True
        Me.NumRec2.Size = New System.Drawing.Size(120, 20)
        Me.NumRec2.TabIndex = 9
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.PestañaRectangulo)
        Me.TabControl1.Controls.Add(Me.PestañaCirculo)
        Me.TabControl1.Location = New System.Drawing.Point(342, 37)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(332, 324)
        Me.TabControl1.TabIndex = 10
        '
        'PestañaRectangulo
        '
        Me.PestañaRectangulo.Controls.Add(Me.Label8)
        Me.PestañaRectangulo.Controls.Add(Me.NumRadio2)
        Me.PestañaRectangulo.Controls.Add(Me.NumRec2)
        Me.PestañaRectangulo.Controls.Add(Me.cbxTipoCalculo)
        Me.PestañaRectangulo.Location = New System.Drawing.Point(4, 22)
        Me.PestañaRectangulo.Name = "PestañaRectangulo"
        Me.PestañaRectangulo.Padding = New System.Windows.Forms.Padding(3)
        Me.PestañaRectangulo.Size = New System.Drawing.Size(324, 298)
        Me.PestañaRectangulo.TabIndex = 0
        Me.PestañaRectangulo.Text = "Rectangulo"
        Me.PestañaRectangulo.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Radio"
        '
        'NumRadio2
        '
        Me.NumRadio2.DecimalPlaces = 2
        Me.NumRadio2.Location = New System.Drawing.Point(6, 19)
        Me.NumRadio2.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumRadio2.Name = "NumRadio2"
        Me.NumRadio2.Size = New System.Drawing.Size(120, 20)
        Me.NumRadio2.TabIndex = 7
        '
        'cbxTipoCalculo
        '
        Me.cbxTipoCalculo.FormattingEnabled = True
        Me.cbxTipoCalculo.Items.AddRange(New Object() {"Calcular Area", "Calcular Perimetro"})
        Me.cbxTipoCalculo.Location = New System.Drawing.Point(7, 45)
        Me.cbxTipoCalculo.Name = "cbxTipoCalculo"
        Me.cbxTipoCalculo.Size = New System.Drawing.Size(121, 21)
        Me.cbxTipoCalculo.TabIndex = 8
        '
        'PestañaCirculo
        '
        Me.PestañaCirculo.Controls.Add(Me.NumPerimetroCirc3)
        Me.PestañaCirculo.Controls.Add(Me.Label11)
        Me.PestañaCirculo.Controls.Add(Me.NumRec3)
        Me.PestañaCirculo.Controls.Add(Me.Label10)
        Me.PestañaCirculo.Controls.Add(Me.NumRadio3)
        Me.PestañaCirculo.Controls.Add(Me.Label9)
        Me.PestañaCirculo.Location = New System.Drawing.Point(4, 22)
        Me.PestañaCirculo.Name = "PestañaCirculo"
        Me.PestañaCirculo.Padding = New System.Windows.Forms.Padding(3)
        Me.PestañaCirculo.Size = New System.Drawing.Size(324, 298)
        Me.PestañaCirculo.TabIndex = 1
        Me.PestañaCirculo.Text = "Circulo"
        Me.PestañaCirculo.UseVisualStyleBackColor = True
        '
        'NumPerimetroCirc3
        '
        Me.NumPerimetroCirc3.Location = New System.Drawing.Point(153, 236)
        Me.NumPerimetroCirc3.Name = "NumPerimetroCirc3"
        Me.NumPerimetroCirc3.ReadOnly = True
        Me.NumPerimetroCirc3.Size = New System.Drawing.Size(120, 20)
        Me.NumPerimetroCirc3.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(52, 236)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Perimetro"
        '
        'NumRec3
        '
        Me.NumRec3.Location = New System.Drawing.Point(145, 188)
        Me.NumRec3.Name = "NumRec3"
        Me.NumRec3.ReadOnly = True
        Me.NumRec3.Size = New System.Drawing.Size(132, 20)
        Me.NumRec3.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(54, 189)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Area"
        '
        'NumRadio3
        '
        Me.NumRadio3.Location = New System.Drawing.Point(145, 139)
        Me.NumRadio3.Name = "NumRadio3"
        Me.NumRadio3.Size = New System.Drawing.Size(132, 20)
        Me.NumRadio3.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(48, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Radio"
        '
        'FormCalculoFiguras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 577)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GrupoCirculo)
        Me.Controls.Add(Me.GrupoRectangulo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormCalculoFiguras"
        Me.Text = "Calculo de areas y perimetros figuras"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GrupoRectangulo.ResumeLayout(False)
        Me.GrupoRectangulo.PerformLayout()
        CType(Me.NumPerimetro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumAncho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumAlto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrupoCirculo.ResumeLayout(False)
        Me.GrupoCirculo.PerformLayout()
        CType(Me.NumPerimetroCirc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumRadio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumRec2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.PestañaRectangulo.ResumeLayout(False)
        Me.PestañaRectangulo.PerformLayout()
        CType(Me.NumRadio2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PestañaCirculo.ResumeLayout(False)
        Me.PestañaCirculo.PerformLayout()
        CType(Me.NumPerimetroCirc3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumRec3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumRadio3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadCirculo As RadioButton
    Friend WithEvents radRectangulo As RadioButton
    Friend WithEvents GrupoRectangulo As GroupBox
    Friend WithEvents NumArea As NumericUpDown
    Friend WithEvents NumAncho As NumericUpDown
    Friend WithEvents NumAlto As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NumPerimetro As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents GrupoCirculo As GroupBox
    Friend WithEvents NumPerimetroCirc As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents NumRec2 As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents NumRadio As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents PestañaRectangulo As TabPage
    Friend WithEvents PestañaCirculo As TabPage
    Friend WithEvents cbxTipoCalculo As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents NumRadio2 As NumericUpDown
    Friend WithEvents NumPerimetroCirc3 As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents NumRec3 As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents NumRadio3 As NumericUpDown
    Friend WithEvents Label9 As Label
End Class
