Imports App_WinForms_RRHH.Modelo

Friend Interface IPersistenciaEmpleados
    Property nombreFichero As String
    Function Importar(ByRef arrayEmpleados() As Empleado) As Boolean
    Function exportar(arrayEmpleados() As Empleado) As Boolean
End Interface
