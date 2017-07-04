Imports App_WinForms_RRHH.Modelo
Public Class Form_Lista

    Public listaEmpleados As List(Of Empleado)
    Private Sub CmbNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbNombre.SelectedIndexChanged
        BuscarEmpleado()
    End Sub

    Private Sub cmbNombre_textChanged(sender As Object, e As EventArgs) Handles CmbNombre.TextChanged, CmbApellidos.TextChanged
        BuscarEmpleado()

    End Sub
    Private Sub BuscarEmpleado()

        LstListaEmpleados.Items.Clear()


        listaEmpleados = EmpleadosCRUD.BuscarEmpleados(CmbNombre.Text, CmbApellidos.Text)

        For Each empleado As Empleado In listaEmpleados
            LstListaEmpleados.Items.Add(empleado.nombre & " " & empleado.apellidos)
        Next


    End Sub
End Class