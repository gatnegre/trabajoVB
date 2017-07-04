Imports App_WinForms_RRHH.Modelo
Public Class Form_baja

    Private frmLista As New Form_Lista


    Public Sub AlActivarseFormulario(sender As Object, e As EventArgs) _
        Handles Me.Activated

        Me.MdiParent.Text = "Baja empleado"
    End Sub
    Public Sub AlDesactivarseFormulario(sender As Object, e As EventArgs) _
        Handles Me.Deactivate

        Me.MdiParent.Text = "Aplicación empleados"
    End Sub

    Private Sub BtnDarDEBaja_Click(sender As Object, e As EventArgs) Handles BtnDarDEBaja.Click

        EmpleadosCRUD.Eliminar(frmLista.listaEmpleados)
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        frmLista.MdiParent = Me.MdiParent
        frmLista.ShowDialog()
        LstEmpleados.Items.Clear()
        LstEmpleados.Items.AddRange(frmLista.LstListaEmpleados.Items)


    End Sub
End Class