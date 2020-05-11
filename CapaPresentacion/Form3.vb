Imports CapaNegocio
Imports CapaEntidad
Public Class Form3

    Dim objNeg As New Cls_Negocio
    Dim objEnt As New Cls_Entidad
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        objEnt.codEmp = TxtCod.Text
        objEnt.nomEmp = TxtNombre.Text
        objEnt.sexoEmp = TxtSexo.Text
        objEnt.edadEmp = TxtEdad.Text
        objEnt.sueldoEmp = TxtSueldo.Text

        objNeg.N_ActualizarEmpleados(objEnt)
        MessageBox.Show("Empleado actualizado correctamente")
        Me.Close()

    End Sub
End Class