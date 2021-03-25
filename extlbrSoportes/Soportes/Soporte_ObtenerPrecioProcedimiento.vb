Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Namespace SP_BBDD
    Public Class Soporte_ObtenerPrecioProcedimiento
        Public Sub New()
            MyBase.New()
        End Sub

        Public Overridable Sub Soporte_ObtenerPrecioProcedimiento(ByVal connection As System.Data.SqlClient.SqlConnection, _
              ByVal transaccion As System.Data.SqlClient.SqlTransaction, _
              ByVal MiDataTable As System.Data.DataTable, _
              ByVal Clave As String, _
              ByVal NSE As Integer)


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
                    cmd = New System.Data.SqlClient.SqlCommand("Soporte_ObtenerPrecioProcedimiento", connection)
                    cmd.CommandType = System.Data.CommandType.StoredProcedure
                Else
                    cmd = New System.Data.SqlClient.SqlCommand("Soporte_ObtenerPrecioProcedimiento", connection, transaccion)
                    cmd.CommandType = System.Data.CommandType.StoredProcedure
                End If

                'variables que se reciben
                Dim _Clave As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter
                _Clave.ParameterName = "@clave"
                _Clave.Size = 20
                _Clave.Value = Clave
                cmd.Parameters.Add(_Clave)

                Dim _NSE As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter
                _NSE.ParameterName = "@NSE"
                _NSE.Size = 4
                _NSE.Value = NSE
                cmd.Parameters.Add(_NSE)

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