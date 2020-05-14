Imports CapaNegocio
Imports CapaEntidad
Public Class Form4

    Dim objNeg As New Cls_Negocio
    Dim objEnt As New Cls_Entidad
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        objEnt.codEmp = TxtCod.Text

        objNeg.N_EliminarEmpleados(objEnt)
        MessageBox.Show("Empleado eliminado correctamente")
        Me.Close()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class