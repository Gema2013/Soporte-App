Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Namespace SP_BBDD
    Public Class Soporte_AgregarFacturaAlCorte
        Public Sub New()
            MyBase.New()
        End Sub

        Public Overridable Sub soporte_AgregarFacturaAlCorte(ByVal connection As System.Data.SqlClient.SqlConnection, _
              ByVal transaccion As System.Data.SqlClient.SqlTransaction, _
              ByVal MiDataTable As System.Data.DataTable, _
              ByVal Folio As String, _
              ByVal Concepto1 As String, _
              ByVal Concepto2 As String, _
              ByVal Concepto3 As String, _
              ByVal Importe As Decimal, _
              ByVal RFC As String, _
              ByVal Fecha As Date, _
              ByVal Usuario As String)


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
                    cmd = New System.Data.SqlClient.SqlCommand("Soporte_AgregarFacturaAlCorte", connection)
                    cmd.CommandType = System.Data.CommandType.StoredProcedure
                Else
                    cmd = New System.Data.SqlClient.SqlCommand("Soporte_AgregarFacturaAlCorte", connection, transaccion)
                    cmd.CommandType = System.Data.CommandType.StoredProcedure
                End If

                'variables que se reciben
                Dim _Folio As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter
                _Folio.ParameterName = "@FolioFactura"
                _Folio.Size = 15
                _Folio.Value = Folio
                cmd.Parameters.Add(_Folio)

                Dim _Concepto1 As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter
                _Concepto1.ParameterName = "@Concepto1"
                _Concepto1.Size = 30
                _Concepto1.Value = Concepto1
                cmd.Parameters.Add(_Concepto1)

                Dim _Concepto2 As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter
                _Concepto2.ParameterName = "@Concepto2"
                _Concepto2.Size = 30
                _Concepto2.Value = Concepto2
                cmd.Parameters.Add(_Concepto2)

                Dim _Concepto3 As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter
                _Concepto3.ParameterName = "@Concepto3"
                _Concepto3.Size = 30
                _Concepto3.Value = Concepto3
                cmd.Parameters.Add(_Concepto3)

                Dim _Importe As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter
                _Importe.ParameterName = "@Importe"
                _Importe.Size = 8
                _Importe.Value = Importe
                cmd.Parameters.Add(_Importe)

                Dim _RFC As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter
                _RFC.ParameterName = "@RFC"
                _RFC.Size = 30
                _RFC.Value = RFC
                cmd.Parameters.Add(_RFC)

                Dim _Fecha As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter
                _Fecha.ParameterName = "@Fecha"
                _Fecha.Size = 10
                _Fecha.Value = Fecha
                cmd.Parameters.Add(_Fecha)

                Dim _Usuario As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter
                _Usuario.ParameterName = "@Usuario"
                _Usuario.Size = 10
                _Usuario.Value = Usuario
                cmd.Parameters.Add(_Usuario)

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