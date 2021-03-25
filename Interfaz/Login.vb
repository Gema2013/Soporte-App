Imports System.Data.Sql
Imports lbrConexion

Public Class Login

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Ingresar()
    End Sub

    Private Sub Login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TextBox1.Focus()
    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, i As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        Select Case i.KeyData
            Case Keys.Enter
                Ingresar()
        End Select
    End Sub

    Public Sub Ingresar()
        Dim frm As New Interfaz()
        Dim Conexion As New lbrConexion.ValConexion

        lbrConexion.Usuario = "usuarios"
        lbrConexion.Password = "usu@r10s._"

        Try
            lbrConexion.CrearConexion()
            Dim opcion As Integer
            opcion = Conexion.checkData(TextBox1.Text, TextBox2.Text)
            If (opcion = 1) Then
                MessageBox.Show("Conexión establecida")
                frm.Propiedad = Conexion.getUserID(TextBox1.Text)
                frm.Show()
                Me.Close()
            Else
                If (opcion = 0) Then
                    MessageBox.Show("Usuario incorrecto")
                End If
                If (opcion = 2) Then
                    MessageBox.Show("Contraseña incorrecta")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("No se pudo iniciar sesión, verifique su conexión")
        End Try
    End Sub

End Class