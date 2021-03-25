Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Namespace SP_BBDD

    Public Class Soporte_AgregarCPyColoniaCartaCompromiso
        Public Sub New()
            MyBase.New()
        End Sub
        Public Overridable Sub soporte_AgregarCPyColoniaCartaCompromiso(ByVal connection As System.Data.SqlClient.SqlConnection, _
                    ByVal transaccion As System.Data.SqlClient.SqlTransaction, _
                   ByVal MiDataTable As System.Data.DataTable, _
                   ByVal Estado As Integer, _
                   ByVal Delegacion As Integer, _
                   ByVal Asentamiento As String, _
                   ByVal CP As Integer)


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
                    cmd = New System.Data.SqlClient.SqlCommand("Soporte_AgregarCPyColoniaCartaCompromiso", connection)
                    cmd.CommandType = System.Data.CommandType.StoredProcedure
                Else
                    cmd = New System.Data.SqlClient.SqlCommand("Soporte_AgregarCPyColoniaCartaCompromiso", connection, transaccion)
                    cmd.CommandType = System.Data.CommandType.StoredProcedure
                End If

                'variables que se reciben
                Dim _Estado As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter
                _Estado.ParameterName = "@estado"
                _Estado.Size = 4
                _Estado.Value = Estado
                cmd.Parameters.Add(_Estado)

                Dim _Delegacion As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter
                _Delegacion.ParameterName = "@delegacion"
                _Delegacion.Size = 4
                _Delegacion.Value = Delegacion
                cmd.Parameters.Add(_Delegacion)

                Dim _Asentamiento As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter
                _Asentamiento.ParameterName = "@asentamiento"
                _Asentamiento.Size = 100
                _Asentamiento.Value = Asentamiento
                cmd.Parameters.Add(_Asentamiento)

                Dim _CP As System.Data.SqlClient.SqlParameter = New System.Data.SqlClient.SqlParameter
                _CP.ParameterName = "@codigo"
                _CP.Size = 4
                _CP.Value = CP
                cmd.Parameters.Add(_CP)

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