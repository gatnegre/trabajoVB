<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_baja
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
        Me.BtnDarDEBaja = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.LstEmpleados = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnDarDEBaja
        '
        Me.BtnDarDEBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDarDEBaja.Location = New System.Drawing.Point(142, 199)
        Me.BtnDarDEBaja.Name = "BtnDarDEBaja"
        Me.BtnDarDEBaja.Size = New System.Drawing.Size(130, 23)
        Me.BtnDarDEBaja.TabIndex = 1
        Me.BtnDarDEBaja.Text = "Dar de Baja"
        Me.BtnDarDEBaja.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(12, 199)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(114, 23)
        Me.BtnBuscar.TabIndex = 2
        Me.BtnBuscar.Text = "Buscar..."
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'LstEmpleados
        '
        Me.LstEmpleados.FormattingEnabled = True
        Me.LstEmpleados.Location = New System.Drawing.Point(13, 67)
        Me.LstEmpleados.Name = "LstEmpleados"
        Me.LstEmpleados.Size = New System.Drawing.Size(259, 95)
        Me.LstEmpleados.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Empleados a dar de baja:"
        '
        'Form_baja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LstEmpleados)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnDarDEBaja)
        Me.Name = "Form_baja"
        Me.Text = "Baja de empleado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnDarDEBaja As Button
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents LstEmpleados As ListBox
    Friend WithEvents Label1 As Label
End Class
