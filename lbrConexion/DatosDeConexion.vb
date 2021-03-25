Imports WinNec

Public Module DatosDeConexion
    Public Usuario As String
    Public Password As String
 

    Dim MyUsuario As New WinNec.Usuario
    Public Function CrearConexion() As Boolean

        Confuguracion.ArchivoConfiguracion = "config.xml"
        Start.MyUsuario = MyUsuario

        MyUsuario.Contraseña = Password
        MyUsuario.Usuario = Usuario

        Return MyUsuario.ActualizaUltimoAcceso()
    End Function


End Module
