﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
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
        Me.txtMultilinea = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDiezCaracteres = New System.Windows.Forms.TextBox()
        Me.btnMostrarLongitud = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLongitudes = New System.Windows.Forms.Label()
        Me.lstListaDatos = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnAdd2 = New System.Windows.Forms.Button()
        Me.btnEliminarDeLista = New System.Windows.Forms.Button()
        Me.btnAbrirForm = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnCambiar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.LblDiaSemana = New System.Windows.Forms.Label()
        Me.LblComparacion = New System.Windows.Forms.Label()
        Me.TextoA = New System.Windows.Forms.TextBox()
        Me.TextoB = New System.Windows.Forms.TextBox()
        Me.BtnComparar = New System.Windows.Forms.Button()
        Me.LblComTxt = New System.Windows.Forms.Label()
        Me.BtnProvocador = New System.Windows.Forms.Button()
        Me.LBLPulsando = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMultilinea
        '
        Me.txtMultilinea.Location = New System.Drawing.Point(18, 59)
        Me.txtMultilinea.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMultilinea.Name = "txtMultilinea"
        Me.txtMultilinea.Size = New System.Drawing.Size(314, 26)
        Me.txtMultilinea.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TextoMultilinea"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 182)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(314, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Texto con longiud maxima de 10 caracteres"
        '
        'txtDiezCaracteres
        '
        Me.txtDiezCaracteres.Location = New System.Drawing.Point(18, 207)
        Me.txtDiezCaracteres.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDiezCaracteres.MaxLength = 10
        Me.txtDiezCaracteres.Name = "txtDiezCaracteres"
        Me.txtDiezCaracteres.Size = New System.Drawing.Size(314, 26)
        Me.txtDiezCaracteres.TabIndex = 3
        '
        'btnMostrarLongitud
        '
        Me.btnMostrarLongitud.Location = New System.Drawing.Point(18, 243)
        Me.btnMostrarLongitud.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMostrarLongitud.Name = "btnMostrarLongitud"
        Me.btnMostrarLongitud.Size = New System.Drawing.Size(176, 35)
        Me.btnMostrarLongitud.TabIndex = 4
        Me.btnMostrarLongitud.Text = "Mostrar longitud"
        Me.btnMostrarLongitud.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 289)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Longitudes:"
        '
        'lblLongitudes
        '
        Me.lblLongitudes.AutoSize = True
        Me.lblLongitudes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLongitudes.Location = New System.Drawing.Point(22, 319)
        Me.lblLongitudes.Name = "lblLongitudes"
        Me.lblLongitudes.Size = New System.Drawing.Size(90, 18)
        Me.lblLongitudes.TabIndex = 6
        Me.lblLongitudes.Text = "Longitudes"
        '
        'lstListaDatos
        '
        Me.lstListaDatos.FormattingEnabled = True
        Me.lstListaDatos.ItemHeight = 20
        Me.lstListaDatos.Items.AddRange(New Object() {"Perro", "Gato", "Murciégalo", "Ratón", "Hámster"})
        Me.lstListaDatos.Location = New System.Drawing.Point(532, 79)
        Me.lstListaDatos.Name = "lstListaDatos"
        Me.lstListaDatos.Size = New System.Drawing.Size(130, 104)
        Me.lstListaDatos.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(416, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Lista de datos:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(339, 59)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(71, 31)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Añadir"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnAdd2
        '
        Me.btnAdd2.Location = New System.Drawing.Point(339, 202)
        Me.btnAdd2.Name = "btnAdd2"
        Me.btnAdd2.Size = New System.Drawing.Size(71, 31)
        Me.btnAdd2.TabIndex = 10
        Me.btnAdd2.Text = "Añadir"
        Me.btnAdd2.UseVisualStyleBackColor = True
        '
        'btnEliminarDeLista
        '
        Me.btnEliminarDeLista.Enabled = False
        Me.btnEliminarDeLista.Location = New System.Drawing.Point(587, 236)
        Me.btnEliminarDeLista.Name = "btnEliminarDeLista"
        Me.btnEliminarDeLista.Size = New System.Drawing.Size(75, 42)
        Me.btnEliminarDeLista.TabIndex = 11
        Me.btnEliminarDeLista.Text = "Eliminar"
        Me.btnEliminarDeLista.UseVisualStyleBackColor = True
        '
        'btnAbrirForm
        '
        Me.btnAbrirForm.Location = New System.Drawing.Point(339, 289)
        Me.btnAbrirForm.Name = "btnAbrirForm"
        Me.btnAbrirForm.Size = New System.Drawing.Size(194, 37)
        Me.btnAbrirForm.TabIndex = 12
        Me.btnAbrirForm.Text = "Abrir Form Combo Listas"
        Me.btnAbrirForm.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(621, 319)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(41, 37)
        Me.btnCerrar.TabIndex = 13
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnCambiar
        '
        Me.btnCambiar.Location = New System.Drawing.Point(214, 243)
        Me.btnCambiar.Name = "btnCambiar"
        Me.btnCambiar.Size = New System.Drawing.Size(118, 35)
        Me.btnCambiar.TabIndex = 14
        Me.btnCambiar.Text = "Cambiar"
        Me.btnCambiar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(344, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(307, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Texto largo que no entra en label pequeño"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(243, 364)
        Me.DateTimePicker1.MaxDate = New Date(2018, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(2016, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(167, 26)
        Me.DateTimePicker1.TabIndex = 16
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(18, 364)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 17
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EditarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(707, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.AbrirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarToolStripMenuItem})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.BuscarToolStripMenuItem.Text = "Buscar"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(239, 500)
        Me.DateTimePicker2.MaxDate = New Date(2018, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker2.MinDate = New Date(2016, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(171, 26)
        Me.DateTimePicker2.TabIndex = 20
        '
        'LblDiaSemana
        '
        Me.LblDiaSemana.AutoSize = True
        Me.LblDiaSemana.Location = New System.Drawing.Point(239, 432)
        Me.LblDiaSemana.Name = "LblDiaSemana"
        Me.LblDiaSemana.Size = New System.Drawing.Size(57, 20)
        Me.LblDiaSemana.TabIndex = 21
        Me.LblDiaSemana.Text = "Label6"
        '
        'LblComparacion
        '
        Me.LblComparacion.AutoSize = True
        Me.LblComparacion.Location = New System.Drawing.Point(239, 481)
        Me.LblComparacion.Name = "LblComparacion"
        Me.LblComparacion.Size = New System.Drawing.Size(57, 20)
        Me.LblComparacion.TabIndex = 22
        Me.LblComparacion.Text = "Label6"
        '
        'TextoA
        '
        Me.TextoA.Location = New System.Drawing.Point(470, 369)
        Me.TextoA.Name = "TextoA"
        Me.TextoA.Size = New System.Drawing.Size(100, 26)
        Me.TextoA.TabIndex = 23
        '
        'TextoB
        '
        Me.TextoB.Location = New System.Drawing.Point(470, 401)
        Me.TextoB.Name = "TextoB"
        Me.TextoB.Size = New System.Drawing.Size(100, 26)
        Me.TextoB.TabIndex = 24
        '
        'BtnComparar
        '
        Me.BtnComparar.Location = New System.Drawing.Point(470, 433)
        Me.BtnComparar.Name = "BtnComparar"
        Me.BtnComparar.Size = New System.Drawing.Size(100, 33)
        Me.BtnComparar.TabIndex = 25
        Me.BtnComparar.Text = "Comparar"
        Me.BtnComparar.UseVisualStyleBackColor = True
        '
        'LblComTxt
        '
        Me.LblComTxt.AutoSize = True
        Me.LblComTxt.Location = New System.Drawing.Point(470, 500)
        Me.LblComTxt.Name = "LblComTxt"
        Me.LblComTxt.Size = New System.Drawing.Size(57, 20)
        Me.LblComTxt.TabIndex = 26
        Me.LblComTxt.Text = "Label6"
        '
        'BtnProvocador
        '
        Me.BtnProvocador.Location = New System.Drawing.Point(521, 520)
        Me.BtnProvocador.Name = "BtnProvocador"
        Me.BtnProvocador.Size = New System.Drawing.Size(160, 28)
        Me.BtnProvocador.TabIndex = 27
        Me.BtnProvocador.Text = "Provocar Eventos"
        Me.BtnProvocador.UseVisualStyleBackColor = True
        '
        'LBLPulsando
        '
        Me.LBLPulsando.AutoSize = True
        Me.LBLPulsando.Location = New System.Drawing.Point(613, 405)
        Me.LBLPulsando.Name = "LBLPulsando"
        Me.LBLPulsando.Size = New System.Drawing.Size(57, 20)
        Me.LBLPulsando.TabIndex = 28
        Me.LBLPulsando.Text = "Label6"
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(707, 560)
        Me.Controls.Add(Me.LBLPulsando)
        Me.Controls.Add(Me.BtnProvocador)
        Me.Controls.Add(Me.LblComTxt)
        Me.Controls.Add(Me.BtnComparar)
        Me.Controls.Add(Me.TextoB)
        Me.Controls.Add(Me.TextoA)
        Me.Controls.Add(Me.LblComparacion)
        Me.Controls.Add(Me.LblDiaSemana)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCambiar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnAbrirForm)
        Me.Controls.Add(Me.btnEliminarDeLista)
        Me.Controls.Add(Me.btnAdd2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstListaDatos)
        Me.Controls.Add(Me.lblLongitudes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnMostrarLongitud)
        Me.Controls.Add(Me.txtDiezCaracteres)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMultilinea)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormPrincipal"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMultilinea As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDiezCaracteres As TextBox
    Friend WithEvents btnMostrarLongitud As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblLongitudes As Label
    Friend WithEvents lstListaDatos As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnAdd2 As Button
    Friend WithEvents btnEliminarDeLista As Button
    Friend WithEvents btnAbrirForm As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnCambiar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents LblDiaSemana As Label
    Friend WithEvents LblComparacion As Label
    Friend WithEvents TextoA As TextBox
    Friend WithEvents TextoB As TextBox
    Friend WithEvents BtnComparar As Button
    Friend WithEvents LblComTxt As Label
    Friend WithEvents BtnProvocador As Button
    Friend WithEvents LBLPulsando As Label
End Class
