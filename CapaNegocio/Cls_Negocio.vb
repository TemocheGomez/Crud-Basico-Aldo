Imports CapaDatos
Imports CapaEntidad
Public Class Cls_Negocio

	Private objDatos As New Cls_Datos

	Public Function N_ListarEmpleados() As DataTable
		Return objDatos.D_ListarEmpleados
	End Function

	Public Sub N_InsertarEmpleados(enti As Cls_Entidad)
		objDatos.D_InsertarEmpleados(enti)
	End Sub

End Class
