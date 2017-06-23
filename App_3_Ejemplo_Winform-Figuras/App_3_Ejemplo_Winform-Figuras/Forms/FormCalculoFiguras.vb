Public Class FormCalculoFiguras
    Private Sub NumAncho_ValueChanged(sender As Object, e As EventArgs) Handles NumAncho.ValueChanged
        Dim rectangulo As Rectangulo = New Rectangulo(NumAlto.Value, NumAncho.Value)
        NumArea.Value = rectangulo.CalcularArea()
        NumPerimetro.Value = rectangulo.CalcularPerimetro()
    End Sub



    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RadCirculo.CheckedChanged, RadCirculo.CheckedChanged

        GrupoRectangulo.Visible = radRectangulo.Checked
        GrupoCirculo.Visible = RadCirculo.Checked

    End Sub

    Private Sub NumRadio_ValueChanged(sender As Object, e As EventArgs) Handles NumRadio.ValueChanged
        Dim circulo As Circulo = New Circulo(NumRadio.Value)
        NumRec2.Value = NumRadio.Value * NumRadio.Value * Math.PI
        NumPerimetroCirc.Value = NumRadio.Value * 2 * CSng(Math.PI)
    End Sub

    Private Sub NumRadio2_ValueChanged(sender As Object, e As EventArgs) Handles NumRadio2.ValueChanged, cbxTipoCalculo.SelectedIndexChanged
        Dim circulo As Circulo = New Circulo(NumRadio2.Value)
        If cbxTipoCalculo.SelectedIndex = 0 Then
            NumRec2.Value = NumRadio2.Value * NumRadio2.Value * Math.PI
        Else
            NumPerimetroCirc.Value = NumRadio2.Value * 2 * CSng(Math.PI)
        End If


    End Sub
End Class
