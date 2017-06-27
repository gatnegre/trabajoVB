Public Class FormPrincipal

    Private formComboListas As FormComboListas


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Longitud de texto multilinea " & txtmultilinea.TextLength.ToString() & vbCrLf & "Longitud texto 2: " & txt10caracteres.TextLength.ToString())
        formComboListas = New FormComboListas()
    End Sub

    Private Sub TextBox1_2_TextChanged(sender As Object, e As EventArgs) Handles txtmultilinea.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txt10caracteres.TextChanged, txtmultilinea.TextChanged
        lblongitudes.Text = ("Longitud de texto multilinea " & txtmultilinea.TextLength.ToString() & vbCrLf & "Longitud texto 2: " & txt10caracteres.TextLength.ToString())
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        LstListaDatos.Items.Add(txtmultilinea.Text)
    End Sub

    Private Sub BtnADD2_Click(sender As Object, e As EventArgs) Handles BtnADD2.Click
        LstListaDatos.Items.Add(txt10caracteres.Text)
        txt10caracteres.Clear()

    End Sub

    Private Sub BotonEliminarLista_Click(sender As Object, e As EventArgs) Handles BotonEliminarLista.Click
        LstListaDatos.Items.RemoveAt(LstListaDatos.SelectedIndex)
    End Sub

    Private Sub LstListaDatos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstListaDatos.SelectedIndexChanged
        Dim siAlgunoSeleccionado As Boolean
        siAlgunoSeleccionado = (LstListaDatos.SelectedIndex >= 0)
        BotonEliminarLista.Enabled = siAlgunoSeleccionado



    End Sub

    Private Sub btnform_Click(sender As Object, e As EventArgs) Handles btnform.Click

        formComboListas.Show()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click


        formComboListas.Close()

    End Sub
End Class
