Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Namespace SP_BBDD
    Public Class Soporte_SeparacionDeCuentasCReclasificacion
        Public Sub New()
            MyBase.New()
        End Sub

        Public Overridable Sub soporte_SeparacionDeCuentasCReclasificacion(ByVal connection As System.Data.SqlClient.SqlConnection, _
              ByVal transaccion As System.Data.SqlClient.SqlTransaction, _
              ByVal MiDataTable As System.Data.DataTable, _
              ByVal Expediente As String, _
              ByVal TipoSeparacion As Integer, _
              ByVal NSE As Integer, _
              ByVal FechaInicio As Date, _
              ByVal FechaFin As Date, _
              ByVal Usuario As String, _
              ByVal UsuarioApp As Integer, _
              ByVal TipoMovimiento As Integer)


            Dim cmd As System.Data.SqlClient.SqlCommand = Nothing
            If (connection Is Nothing) Then
                Throw New System.ArgumentException("El objeto conection no puede ser null")
            Else
                'Comentario
                If (transaccion Is Nothing) Then
                    If (connection.State = System.Data.ConnectionState.Closed) Then
                        connection.Open()
                        'Abrir Conexion
                    End If
                    cmd = New System.Data.SqlClient.SqlCommand("Soporte_SeparacionDeCuentasCReclasificacion", connection)
                    cmd.CommandType = System.Data.CommandType.StoredProcedure
                Else
                    cmd = New System.Data.SqlClient.SqlCommand("Soporte_SeparacionDeCuentasCReclasificacion", connection, transaccion)
                    cmd.CommandType = System.Data.CommandType.StoredProcedure
                End If

                'variables que se reciben
                Dim _Expediente As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter
                _Expediente.ParameterName = "@expediente"
                _Expediente.Size = 10
                _Expediente.Value = Expediente
                cmd.Parameters.Add(_Expediente)

                Dim _TipoSeparacion As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter
                _TipoSeparacion.ParameterName = "@tipo_separacion"
                _TipoSeparacion.Size = 4
                _TipoSeparacion.Value = TipoSeparacion
                cmd.Parameters.Add(_TipoSeparacion)

                Dim _NSE As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter
                _NSE.ParameterName = "@NSE"
                _NSE.Size = 4
                _NSE.Value = NSE
                cmd.Parameters.Add(_NSE)

                Dim _FechaInicio As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter
                _FechaInicio.ParameterName = "@fechaInicio"
                _FechaInicio.Size = 10
                _FechaInicio.Value = FechaInicio
                cmd.Parameters.Add(_FechaInicio)

                Dim _FechaFin As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter
                _FechaFin.ParameterName = "@fechaFin"
                _FechaFin.Size = 10
                _FechaFin.Value = FechaFin
                cmd.Parameters.Add(_FechaFin)

                Dim _Usuario As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter
                _Usuario.ParameterName = "@usuario"
                _Usuario.Size = 20
                _Usuario.Value = Usuario
                cmd.Parameters.Add(_Usuario)

                Dim _UsuarioApp As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter
                _UsuarioApp.ParameterName = "@usuarioapp"
                _UsuarioApp.Size = 8
                _UsuarioApp.Value = UsuarioApp
                cmd.Parameters.Add(_UsuarioApp)

                Dim _tipoMovimiento As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter
                _tipoMovimiento.ParameterName = "@tipoMovimiento"
                _tipoMovimiento.Size = 8
                _tipoMovimiento.Value = TipoMovimiento
                cmd.Parameters.Add(_tipoMovimiento)

                'fin variables que reciben
                If (Not (MiDataTable) Is Nothing) Then
                    Dim dr As System.Data.SqlClient.SqlDataReader
                    dr = cmd.ExecuteReader
                    MiDataTable.Load(dr)
                Else
                    cmd.ExecuteScalar()
                End If
                If (transaccion Is Nothing) Then
                    connection.Close()
                End If
            End If
        End Sub

    End Class
End Namespace