Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Namespace SP_BBDD
    Public Class Soporte_TicketA0
        Public Sub New()
            MyBase.New()
        End Sub

        Public Overridable Sub soporte_TicketA0(ByVal connection As System.Data.SqlClient.SqlConnection, _
              ByVal transaccion As System.Data.SqlClient.SqlTransaction, _
              ByVal MiDataTable As System.Data.DataTable, _
              ByVal Expediente As String, _
              ByVal Caja As Integer, _
              ByVal Ticket As Integer)


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
                    cmd = New System.Data.SqlClient.SqlCommand("Soporte_TicketA0", connection)
                    cmd.CommandType = System.Data.CommandType.StoredProcedure
                Else
                    cmd = New System.Data.SqlClient.SqlCommand("Soporte_TicketA0", connection, transaccion)
                    cmd.CommandType = System.Data.CommandType.StoredProcedure
                End If

                'variables que se reciben
                Dim _Expediente As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter
                _Expediente.ParameterName = "@expediente"
                _Expediente.Size = 10
                _Expediente.Value = Expediente
                cmd.Parameters.Add(_Expediente)

                Dim _Caja As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter
                _Caja.ParameterName = "@caja"
                _Caja.Size = 4
                _Caja.Value = Caja
                cmd.Parameters.Add(_Caja)

                Dim _Ticket As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter
                _Ticket.ParameterName = "@ticket"
                _Ticket.Size = 4
                _Ticket.Value = Ticket
                cmd.Parameters.Add(_Ticket)

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