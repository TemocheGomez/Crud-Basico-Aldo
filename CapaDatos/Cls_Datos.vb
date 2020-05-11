Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports CapaEntidad
Public Class Cls_Datos
    Private cn As New SqlConnection(ConfigurationManager.ConnectionStrings("conexionBD").ConnectionString)

	'Mostrar Tabla
	Public Function D_ListarEmpleados() As DataTable
		Dim cmd As New SqlCommand("Select * from empleados", cn)
		cn.Open()
		cmd.CommandType = CommandType.Text
		Dim da As New SqlDataAdapter(cmd)
		Dim dt As New DataTable
		da.Fill(dt)
		cn.Close()
		Return dt
	End Function

	Public Sub D_InsertarEmpleados(enti As Cls_Entidad)
		Dim cmd As New SqlCommand("insert into empleados values (@nomEmp,@edadEmp,@sexoEmp,@sueldoEmp)", cn)
		cn.Open()
		cmd.CommandType = CommandType.Text
		With cmd.Parameters
			.AddWithValue("@nomEmp", enti.nomEmp)
			.AddWithValue("@edadEmp", enti.edadEmp)
			.AddWithValue("@sexoEmp", enti.sexoEmp)
			.AddWithValue("@sueldoEmp", enti.sueldoEmp)
		End With
		cmd.ExecuteNonQuery()
		cn.Close()
		cmd.Parameters.Clear()
	End Sub
	Public Sub D_ActualizarEmpleados(enti As Cls_Entidad)
		Dim cmd As New SqlCommand("UPDATE empleados SET nomEmp=@nomEmp,Edademp=@edadEmp,sexoEmp=@sexoEmp,sueldoEmp=@sueldoEmp where codEmp=@codEmp", cn)
		cn.Open()
		cmd.CommandType = CommandType.Text
		With cmd.Parameters
			.AddWithValue("@codEmp", enti.codEmp)
			.AddWithValue("@nomEmp", enti.nomEmp)
			.AddWithValue("@edadEmp", enti.edadEmp)
			.AddWithValue("@sexoEmp", enti.sexoEmp)
			.AddWithValue("@sueldoEmp", enti.sueldoEmp)
		End With
		cmd.ExecuteNonQuery()
		cn.Close()
		cmd.Parameters.Clear()
	End Sub

	Public Sub D_EliminarEmpleados(enti As Cls_Entidad)
		Dim cmd As New SqlCommand("DELETE from empleados where codEmp=@codEmp", cn)
		cn.Open()
		cmd.CommandType = CommandType.Text
		With cmd.Parameters
			.AddWithValue("@codEmp", enti.codEmp)
		End With
		cmd.ExecuteNonQuery()
		cn.Close()
		cmd.Parameters.Clear()
	End Sub


End Class

