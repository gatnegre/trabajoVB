﻿Namespace Modelo
    Public Class EmpleadosAcessCRUD
        Implements IEmpleadosCRUD

        Private cadena_conexion As String

        Public ReadOnly Property Cantidad As Integer Implements IEmpleadosCRUD.Cantidad
            Get
                Throw New NotImplementedException()
            End Get
        End Property
        Public Sub Actualizar(empleado As Empleado, empleadoModif As Empleado) Implements IEmpleadosCRUD.Actualizar
            Throw New NotImplementedException()
        End Sub
        Public Sub Crear(nuevoEmpleado As Empleado) Implements IEmpleadosCRUD.Crear
            Throw New NotImplementedException()
        End Sub
        Public Sub Eliminar(empleados As List(Of Empleado)) Implements IEmpleadosCRUD.Eliminar
            Throw New NotImplementedException()
        End Sub
        Public Sub Eliminar(empleado As Empleado) Implements IEmpleadosCRUD.Eliminar
            Throw New NotImplementedException()
        End Sub
        Public Sub EstablecerAvisarEnModificacion(funcionDelegada As TipoDelAvisarEnModificacion) Implements IEmpleadosCRUD.EstablecerAvisarEnModificacion
            Throw New NotImplementedException()
        End Sub

        Public Sub Grabar(persistenciaEmpleados As IPersistenciaEmpleados) Implements IEmpleadosCRUD.Grabar
            Throw New NotImplementedException()
        End Sub

        Public Sub Restaurar(persistenciaEmpleados As IPersistenciaEmpleados) Implements IEmpleadosCRUD.Restaurar
            cadena_conexion = EmpleadosBaseOleDB.CrearCadenaConexion(PROVEEDOR_ACCESS, persistenciaEmpleados.nombreFichero)
            consultaSQL = "SELECT Nombre, Apellidos, Genero, Categoria, Retribucion_Fija " _
                    & " FROM Empleado  ORDER BY Nombre, Apellidos ASC; "

        End Sub

        Public Function BuscarEmpleados(nombre As String, apellido As String) As List(Of Empleado) Implements IEmpleadosCRUD.BuscarEmpleados
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace
