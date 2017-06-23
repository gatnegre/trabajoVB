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
        NumAreaCirc.Value = NumRadio.Value * NumRadio.Value * Math.PI
        NumPerimetroCirc.Value = NumRadio.Value * 2 * CSng(Math.PI)
    End Sub
End Class
