Imports CapaNegocio
Public Class Form1

    Dim objNego As New Cls_Negocio

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ListarEmpleados()

    End Sub

    Sub ListarEmpleados()
        Dim dt As DataTable = objNego.N_ListarEmpleados
        Dgv_Empleados.DataSource = dt
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim frm2 As New Form2
        frm2.ShowDialog()
        ListarEmpleados()
    End Sub
End Class
