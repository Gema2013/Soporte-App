Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Namespace SP_BBDD
    Public Class Soporte_CambiarFechaIC
        Public Sub New()
            MyBase.New()
        End Sub

        Public Overridable Sub soporte_CambiarFechaIC(ByVal connection As System.Data.SqlClient.SqlConnection, _
              ByVal transaccion As System.Data.SqlClient.SqlTransaction, _
              ByVal MiDataTable As System.Data.DataTable, _
              ByVal Expediente As String, _
              ByVal NumeroIC As String, _
              ByVal Fecha As Date)


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
                    cmd = New System.Data.SqlClient.SqlCommand("Soporte_CambiarFechaIC", connection)
                    cmd.CommandType = System.Data.CommandType.StoredProcedure
                Else
                    cmd = New System.Data.SqlClient.SqlCommand("Soporte_CambiarFechaIC", connection, transaccion)
                    cmd.CommandType = System.Data.CommandType.StoredProcedure
                End If

                'variables que se reciben
                Dim _Expediente As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter
                _Expediente.ParameterName = "@expediente"
                _Expediente.Size = 10
                _Expediente.Value = Expediente
                cmd.Parameters.Add(_Expediente)

                Dim _NumeroIC As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter
                _NumeroIC.ParameterName = "@IC"
                _NumeroIC.Size = 50
                _NumeroIC.Value = NumeroIC
                cmd.Parameters.Add(_NumeroIC)

                Dim _Fecha As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter
                _Fecha.ParameterName = "@Fecha"
                _Fecha.Size = 10
                _Fecha.Value = Fecha
                cmd.Parameters.Add(_Fecha)

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