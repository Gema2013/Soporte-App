Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Namespace SP_BBDD
    Public Class Soporte_InhabilitarAnticipo
        Public Sub New()
            MyBase.New()
        End Sub

        Public Overridable Sub soporte_InhabiitarAnticipo(ByVal connection As System.Data.SqlClient.SqlConnection, _
              ByVal transaccion As System.Data.SqlClient.SqlTransaction, _
              ByVal MiDataTable As System.Data.DataTable, _
              ByVal Expediente As String, _
              ByVal NumeroAnticipo As Integer, _
              ByVal Monto As Decimal, _
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
                    cmd = New System.Data.SqlClient.SqlCommand("Soporte_InhabilitarAnticipo", connection)
                    cmd.CommandType = System.Data.CommandType.StoredProcedure
                Else
                    cmd = New System.Data.SqlClient.SqlCommand("Soporte_InhabilitarAnticipo", connection, transaccion)
                    cmd.CommandType = System.Data.CommandType.StoredProcedure
                End If

                'variables que se reciben
                Dim _Expediente As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter
                _Expediente.ParameterName = "@expediente"
                _Expediente.Size = 10
                _Expediente.Value = Expediente
                cmd.Parameters.Add(_Expediente)

                Dim _NumeroAnticipo As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter
                _NumeroAnticipo.ParameterName = "@NoAnticipo"
                _NumeroAnticipo.Size = 4
                _NumeroAnticipo.Value = NumeroAnticipo
                cmd.Parameters.Add(_NumeroAnticipo)

                Dim _Monto As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter
                _Monto.ParameterName = "@Monto"
                _Monto.Size = 8
                _Monto.Value = Monto
                cmd.Parameters.Add(_Monto)

                Dim _Fecha As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter
                _Fecha.ParameterName = "@fecha"
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