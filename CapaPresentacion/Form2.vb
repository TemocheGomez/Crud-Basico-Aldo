Imports CapaNegocio
Imports CapaEntidad
Public Class Form2
    Dim objNeg As New Cls_Negocio
    Dim objEnt As New Cls_Entidad
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        objEnt.nomEmp = txtNombre.Text
        objEnt.sexoEmp = txtSexo.Text
        objEnt.edadEmp = txtEdad.text
        objEnt.sueldoEmp = txtSueldo.Text

        objNeg.N_InsertarEmpleados(objEnt)
        MessageBox.Show("Empleado agregado correctamente")
        Me.Close()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class