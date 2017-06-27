Public Class FormPrincipal
    Private miFormComboListas As FormComboListas
    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        miFormComboListas = New FormComboListas()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("longitud de texto multilena: " & txtMultilinea.TextLength.ToString() &
                        vbCrLf & "longitud texto 2: " & txtDiezCaracteres.TextLength.ToString())
    End Sub
    Private Sub TextBox1_2_TextChanged(sender As Object, e As EventArgs) Handles txtMultilinea.TextChanged, txtDiezCaracteres.TextChanged
        lblLongitudes.Text = "longitud de texto multilena: " & txtMultilinea.TextLength.ToString() &
                        vbCrLf & "longitud texto 2: " & txtDiezCaracteres.TextLength.ToString()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lstListaDatos.Items.Add(txtMultilinea.Text)
    End Sub
    Private Sub btnAdd2_Click(sender As Object, e As EventArgs) Handles btnAdd2.Click
        lstListaDatos.Items.Add(txtDiezCaracteres.Text)
        txtDiezCaracteres.Clear()
    End Sub
    Private Sub btnEliminarDeLista_Click(sender As Object, e As EventArgs) Handles btnEliminarDeLista.Click
        lstListaDatos.Items.RemoveAt(lstListaDatos.SelectedIndex)
    End Sub
    Private Sub lstListaDatos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstListaDatos.SelectedIndexChanged

        btnEliminarDeLista.Enabled = (lstListaDatos.SelectedIndex >= 0)
    End Sub
    Private Sub btnAbrirForm_Click(sender As Object, e As EventArgs) Handles btnAbrirForm.Click
        If miFormComboListas Is Nothing Or miFormComboListas.IsDisposed Then
            miFormComboListas = New FormComboListas()
        End If
        miFormComboListas.Show()
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        miFormComboListas.Hide()  'nuevoFormComboListas.Close()
    End Sub

    Private Sub BtnCambiar_Click(sender As Object, e As EventArgs) Handles BtnCambiar.Click
        Dim tipoFuente As Integer
        tipoFuente = System.Drawing.FontStyle.Italic + System.Drawing.FontStyle.Underline

        Me.lblLongitudes.Font = New Font("Microsoft Sans Serif", 16, tipoFuente, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        'Ampliar tamaño del txtmultilinea
        Me.txtMultilinea.Multiline = True
        Dim tamanoTxtMult As Size = Me.txtMultilinea.Size
        tamanoTxtMult.Height += 100
        Me.txtMultilinea.Size = tamanoTxtMult

        'Mover a la derecha boton pulsado
        Dim esteBoton As Button = CType(sender, Button)
        esteBoton.Location = New Point(esteBoton.Location.X + 20, esteBoton.Location.Y)

        'Poner btnabrirForm a la izquierda del boton cerrar

        btnAbrirForm.Location = New Point(btnCerrar.Location.X - btnAbrirForm.Size.Width, btnCerrar.Location.Y)

        'cambiar propiedades del propio formulario
        Me.BackColor = Color.BurlyWood
        Me.Text = "nuevo Titulo ventana"
        Me.BackColor = Color.FromArgb(255, 255, 255, 0) ' 32 bits. 8 bit por color, 1 byte por color

        '417;45 /245;184

        lstListaDatos.SetBounds(417, 45, 245, 185)
        lstListaDatos.BringToFront()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim fecha As Date = DateTimePicker1.Value
        Me.Text = "Ventana: " & fecha.ToString()

        If fecha.Year = 2017 Then
            Me.Text += "¿Este mismo año!"
        End If
    End Sub
End Class
