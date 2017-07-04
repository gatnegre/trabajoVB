Public Class FormComboListas
    Private Sub FormComboListas_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        For i = 0 To My.Application.OpenForms.Count - 1
            LblTextoaAnadir.Text += My.Application.OpenForms.Item(i).Text & vbCrLf
        Next
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click, TextBox1.TextChanged
        CmbTextos.Items.Add(TextBox1.Text)
        CmbTextos.SelectedItem = TextBox1
        TextBox1.Clear()
        TextBox1.Focus()


    End Sub

    Private Sub BtnPasar_Click(sender As Object, e As EventArgs) Handles BtnPasar.Click
        If ChkListTextos.Items.Count < TrackBar1.Value Then


            ChkListTextos.Items.Add(CmbTextos.SelectedItem)
            CmbTextos.Items.Remove(CmbTextos.SelectedItem)
        End If
    End Sub

    Private Sub BtnQuitar_Click(sender As Object, e As EventArgs) Handles BtnQuitar.Click
        While ChkListTextos.CheckedItems.Count > 0
            CmbTextos.Items.Add(ChkListTextos.CheckedItems.Item(0))
            ChkListTextos.Items.Remove(ChkListTextos.CheckedItems.Item(0))
        End While

    End Sub


End Class