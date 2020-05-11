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

    Private Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click
        Dim frm3 As New Form3
        frm3.ShowDialog()
        ListarEmpleados()
    End Sub

    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        Dim frm4 As New Form4
        frm4.ShowDialog()
        ListarEmpleados()
    End Sub
End Class
