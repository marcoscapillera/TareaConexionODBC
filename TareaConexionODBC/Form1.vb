Imports System.Data.Odbc


Public Class formPpal
    Private Sub formPpal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Dim conexion As New OdbcConnection("DRIVER=MySQL ODBC 5.3 ANSI Driver;UID=marcos;PWD=admin;PORT=3306;DATABASE=testconexion;SERVER=localhost")

        conexion.Open()
        MsgBox("Conexion Exitosa!")


        Dim comando As New OdbcCommand
        comando.CommandText = "INSERT INTO persona (id, nombre, apellido) VALUES (1,'Juan','Perez')"
        comando.Connection = conexion

        comando.ExecuteNonQuery()

        MsgBox("Persona insert correct")


    End Sub
End Class


