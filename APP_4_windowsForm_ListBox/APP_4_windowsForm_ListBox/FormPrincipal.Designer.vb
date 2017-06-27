<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Me.txtmultilinea = New System.Windows.Forms.TextBox()
        Me.txt10caracteres = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblongitudes = New System.Windows.Forms.Label()
        Me.LstListaDatos = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnADD2 = New System.Windows.Forms.Button()
        Me.BotonEliminarLista = New System.Windows.Forms.Button()
        Me.btnform = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtmultilinea
        '
        Me.txtmultilinea.Location = New System.Drawing.Point(31, 32)
        Me.txtmultilinea.Multiline = True
        Me.txtmultilinea.Name = "txtmultilinea"
        Me.txtmultilinea.Size = New System.Drawing.Size(241, 84)
        Me.txtmultilinea.TabIndex = 0
        '
        'txt10caracteres
        '
        Me.txt10caracteres.Location = New System.Drawing.Point(31, 138)
        Me.txt10caracteres.MaxLength = 10
        Me.txt10caracteres.Name = "txt10caracteres"
        Me.txt10caracteres.Size = New System.Drawing.Size(100, 20)
        Me.txt10caracteres.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "TextoMultilinea"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Texto con longitud de 10 caracteres"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(93, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 28)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Mostrar Longitud"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(34, 229)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 5
        '
        'lblongitudes
        '
        Me.lblongitudes.AutoSize = True
        Me.lblongitudes.Location = New System.Drawing.Point(31, 302)
        Me.lblongitudes.Name = "lblongitudes"
        Me.lblongitudes.Size = New System.Drawing.Size(59, 13)
        Me.lblongitudes.TabIndex = 6
        Me.lblongitudes.Text = "Longitudes"
        '
        'LstListaDatos
        '
        Me.LstListaDatos.FormattingEnabled = True
        Me.LstListaDatos.Items.AddRange(New Object() {"Perro", "Gato", "Murcielago", "Ratón"})
        Me.LstListaDatos.Location = New System.Drawing.Point(436, 32)
        Me.LstListaDatos.Name = "LstListaDatos"
        Me.LstListaDatos.Size = New System.Drawing.Size(202, 95)
        Me.LstListaDatos.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(433, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Lista de Datos"
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(310, 32)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 9
        Me.BtnAdd.Text = "Añadir"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnADD2
        '
        Me.BtnADD2.Location = New System.Drawing.Point(310, 92)
        Me.BtnADD2.Name = "BtnADD2"
        Me.BtnADD2.Size = New System.Drawing.Size(75, 23)
        Me.BtnADD2.TabIndex = 10
        Me.BtnADD2.Text = "Añadir"
        Me.BtnADD2.UseVisualStyleBackColor = True
        '
        'BotonEliminarLista
        '
        Me.BotonEliminarLista.Location = New System.Drawing.Point(436, 192)
        Me.BotonEliminarLista.Name = "BotonEliminarLista"
        Me.BotonEliminarLista.Size = New System.Drawing.Size(75, 23)
        Me.BotonEliminarLista.TabIndex = 11
        Me.BotonEliminarLista.Text = "Eliminar de lista"
        Me.BotonEliminarLista.UseVisualStyleBackColor = True
        '
        'btnform
        '
        Me.btnform.Location = New System.Drawing.Point(436, 355)
        Me.btnform.Name = "btnform"
        Me.btnform.Size = New System.Drawing.Size(188, 23)
        Me.btnform.TabIndex = 12
        Me.btnform.Text = "Boton abrir formulario"
        Me.btnform.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(326, 355)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCerrar.TabIndex = 13
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 417)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.btnform)
        Me.Controls.Add(Me.BotonEliminarLista)
        Me.Controls.Add(Me.BtnADD2)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LstListaDatos)
        Me.Controls.Add(Me.lblongitudes)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt10caracteres)
        Me.Controls.Add(Me.txtmultilinea)
        Me.Name = "FormPrincipal"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtmultilinea As TextBox
    Friend WithEvents txt10caracteres As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lblongitudes As Label
    Friend WithEvents LstListaDatos As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnADD2 As Button
    Friend WithEvents BotonEliminarLista As Button
    Friend WithEvents btnform As Button
    Friend WithEvents BtnCerrar As Button
End Class
