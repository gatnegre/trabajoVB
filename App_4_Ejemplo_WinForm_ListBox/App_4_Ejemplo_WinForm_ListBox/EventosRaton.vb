Public Class EventosRaton

    Private nuevoBoton As Button
    Private listaBotones As List(Of Button)

    Private Sub EventosRaton_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaBotones = New List(Of Button)()
    End Sub
    Private Sub Form_OnMouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        nuevoBoton = New Button
        nuevoBoton.Size = New Size(30, 30)
        nuevoBoton.Text = "X"
        nuevoBoton.Parent = Me
        nuevoBoton.Location = e.Location + PictureBox1.Location

        nuevoBoton.BringToFront()

        AddHandler PictureBox1.MouseMove, AddressOf Form_OnMouseMove


    End Sub
    Private Sub Form_OnMouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        'Mover el boton
        If Not nuevoBoton Is Nothing Then
            nuevoBoton.Location = e.Location
        End If

    End Sub
    Private Sub Form_OnMouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        AddHandler PictureBox1.MouseMove, AddressOf Form_OnMouseMove
        RemoveHandler Me.MouseMove, AddressOf Form_OnMouseMove
        'cambiar a negrita la fuente
        nuevoBoton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        'Añadirlo a una lista (list) de botones
        listaBotones.Add(nuevoBoton)
        'mostrar en una etiqueta el numero de botones creados
        LblBotones.Text = "Nº botones: " & listaBotones.Count


        nuevoBoton = Nothing


    End Sub

    Private Sub PictureBox1_OnMouseLeave(sender As Object, e As EventArgs) _
        Handles PictureBox1.MouseLeave, PictureBox1.MouseEnter

        MessageBox.Show("Entrando o saliendo")
    End Sub

End Class