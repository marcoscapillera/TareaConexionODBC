Imports System.Data.Odbc


Public Class formPpal
    Private Sub formPpal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Dim conexion As New OdbcConnection("DRIVER=MySQL ODBC 5.3 ANSI Driver;UID=marcos;PWD=admin;PORT=3306;DATABASE=testconexion;SERVER=localhost")

        conexion.Open()



        Dim comando As New OdbcCommand
        comando.CommandText = "INSERT INTO persona (id, nombre, apellido) VALUES (" + txtId.Text + ",'" + txtNombre.Text + "',' " + txtApellido.Text + "')"
        MsgBox(comando.CommandText)
        comando.Connection = conexion

        comando.ExecuteNonQuery()

        MsgBox("Persona insert correct")


    End Sub
End Class


