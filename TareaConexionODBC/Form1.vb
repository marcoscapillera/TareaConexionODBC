Imports System.Data.Odbc


Public Class formPpal

    Private stringDeConexion = "DRIVER=MySQL ODBC 5.3 ANSI Driver;UID=marcos;PWD=admin;PORT=3306;DATABASE=testconexion;SERVER=localhost"
    Private lector As OdbcDataReader

    Private Sub formPpal_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim conexion As New OdbcConnection(stringDeConexion)
        conexion.Open()
        Dim comando As New OdbcCommand
        If txtMail.Text = "" Then
            comando.CommandText = "INSERT INTO persona (id, nombre, apellido) VALUES (" + txtId.Text + ",'" + txtNombre.Text + "',' " + txtApellido.Text + "')"
            MsgBox(comando.CommandText)
            comando.Connection = conexion
        Else
            comando.CommandText = "INSERT INTO persona (id, nombre, apellido,mail) VALUES (" + txtId.Text + ",'" + txtNombre.Text + "',' " + txtApellido.Text + "',' " + txtMail.Text + "')"
            MsgBox(comando.CommandText)
            comando.Connection = conexion
        End If

        comando.ExecuteNonQuery()
        MsgBox("Persona insert correct")
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Dim conexion As New OdbcConnection(stringDeConexion)
        conexion.Open()
        Dim comando As New OdbcCommand
        comando.CommandText = "UPDATE  persona SET  nombre = '" + txtNombre.Text + "', apellido = ' " + txtApellido.Text + "', mail = ' " + txtMail.Text + "'  WHERE id = " + txtId.Text + " "
        MsgBox(comando.CommandText)
        comando.Connection = conexion
        comando.ExecuteNonQuery()
        MsgBox("Persona update correct")

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim conexion As New OdbcConnection(stringDeConexion)
        conexion.Open()
        Dim comando As New OdbcCommand
        comando.CommandText = "DELETE FROM persona WHERE id= " + txtId.Text + ""
        MsgBox(comando.CommandText)
        comando.Connection = conexion
        comando.ExecuteNonQuery()
        MsgBox("Persona Delete correct")
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Dim conexion As New OdbcConnection(stringDeConexion)
        conexion.Open()
        Dim comando As New OdbcCommand
        comando.CommandText = "SELECT * FROM  persona"
        MsgBox(comando.CommandText)
        comando.Connection = conexion
        lector = comando.ExecuteReader()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lector.Read()

        txtId.Text = lector(0).ToString()
        txtNombre.Text = lector(1).ToString()
        txtApellido.Text = lector(2).ToString()
        txtMail.Text = lector(3).ToString()
    End Sub
End Class


