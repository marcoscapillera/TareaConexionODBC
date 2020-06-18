Imports System.Data.Odbc
Imports CapaLogica


Public Class formPpal

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            ControladorPersona.DarDeAlta(txtId.Text, txtNombre.Text, txtApellido.Text, txtMail.Text)
            MsgBox("Persona creada")
        Catch ex As Exception
            MsgBox("Hubo un error")
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Try
            If txtId.Text = "" Then
                MsgBox("Por favor, indique un id")
            Else
                ControladorPersona.Modificar(txtId.Text, txtNombre.Text, txtApellido.Text, txtMail.Text)
                MsgBox("Persona modificada correctamente")
            End If

        Catch ex As Exception
            MsgBox("Hubo un error")

        End Try

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            ControladorPersona.Borrar(txtId.Text)
            MsgBox("Persona eliminada correctamente")
        Catch ex As Exception
            MsgBox("Hubo un error")
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        Try
            MsgBox(ControladorPersona.ObtenerCantidad())
        Catch ex As Exception
            MsgBox("Hubo un error")
        End Try
    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        Try
            Dim tabla As New DataTable
            tabla.Load(ControladorPersona.ListarTodo())
            GrillaPersona.DataSource = tabla
        Catch ex As Exception
            MsgBox("Hubo un error")
        End Try


    End Sub
End Class


