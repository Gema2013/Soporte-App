Imports System.Data.SqlClient
Imports WinNec

Public Class ValConexion

    Public Function EjecutaStore_ActivarBrazalete(ByVal Expediente As String) As Boolean
        Dim MiConexion As System.Data.SqlClient.SqlConnection = Nothing
        Dim MiTransaccion As System.Data.SqlClient.SqlTransaction = Nothing
        Dim MiDataTable As New DataTable
        Dim Success = False
        Try
            MiConexion = ConexionNet.Conexion
            MiConexion.Open()
            MiTransaccion = MiConexion.BeginTransaction(IsolationLevel.ReadUncommitted)
            Dim Store As New lbrSoportes.SP_BBDD.Soporte_ActivarBrazalete
            Store.soporte_ActivarBrazalete(MiConexion, MiTransaccion, MiDataTable, Expediente)
            Success = True
        Catch ex As Exception
            If MiTransaccion IsNot Nothing Then
                Mensajes.Mensaje("Error intentado guardar la información : " & ex.Message())
                MiTransaccion.Rollback()
            End If
            Success = False
        Finally
            If Success And MiTransaccion IsNot Nothing Then
                'Me.Close()
                MiTransaccion.Commit()
            End If
            If MiConexion IsNot Nothing Then
                MiConexion.Close()
                MiConexion.Dispose()
            End If
        End Try
        Return Success
    End Function

    Public Function EjecutaStore_ActivarDesactivarUsuario(ByVal Usuario As String, ByVal Opcion As Integer) As Boolean
        Dim MiConexion As System.Data.SqlClient.SqlConnection = Nothing
        Dim MiTransaccion As System.Data.SqlClient.SqlTransaction = Nothing
        Dim MiDataTable As New DataTable
        Dim Success = False
        Try
            MiConexion = ConexionNet.Conexion
            MiConexion.Open()
            MiTransaccion = MiConexion.BeginTransaction(IsolationLevel.ReadUncommitted)
            Dim Store As New lbrSoportes.SP_BBDD.Soporte_ActivarDesactivarUsuario
            Store.soporte_ActivarDesactivarUsuario(MiConexion, MiTransaccion, MiDataTable, Usuario, Opcion)
            Success = True
        Catch ex As Exception
            If MiTransaccion IsNot Nothing Then
                Mensajes.Mensaje("Error intentado guardar la información : " & ex.Message())
                MiTransaccion.Rollback()
            End If
            Success = False
        Finally
            If Success And MiTransaccion IsNot Nothing Then
                'Me.Close()
                MiTransaccion.Commit()
            End If
            If MiConexion IsNot Nothing Then
                MiConexion.Close()
                MiConexion.Dispose()
            End If
        End Try
        Return Success
    End Function

    Public Function EjecutaStore_AgregarCPyColoniaCartaCompromiso(ByVal Estado As Integer, ByVal Delegacion As Integer, ByVal Asentamiento As String, ByVal CP As Integer) As Boolean

        Dim MiConexion As System.Data.SqlClient.SqlConnection = Nothing
        Dim MiTransaccion As System.Data.SqlClient.SqlTransaction = Nothing
        Dim MiDataTable As New DataTable
        Dim Success = False
        Try
            MiConexion = ConexionNet.Conexion
            MiConexion.Open()
            MiTransaccion = MiConexion.BeginTransaction(IsolationLevel.ReadUncommitted)
            Dim Store As New lbrSoportes.SP_BBDD.Soporte_AgregarCPyColoniaCartaCompromiso
            Store.soporte_AgregarCPyColoniaCartaCompromiso(MiConexion, MiTransaccion, MiDataTable, Estado, Delegacion, Asentamiento, CP)
            Success = True
        Catch ex As Exception
            If MiTransaccion IsNot Nothing Then
                Mensajes.Mensaje("Error intentado guardar la información : " & ex.Message())
                MiTransaccion.Rollback()
            End If
            Success = False
        Finally
            If Success And MiTransaccion IsNot Nothing Then
                'Me.Close()
                MiTransaccion.Commit()
            End If
            If MiConexion IsNot Nothing Then
                MiConexion.Close()
                MiConexion.Dispose()
            End If
        End Try
        Return Success
    End Function

    Public Function EjecutaStore_AgregarFacturaAlCorte(ByVal Folio As String, ByVal Concepto1 As String, ByVal Concepto2 As String, ByVal Concepto3 As String, ByVal Importe As Decimal, ByVal RFC As String, ByVal Fecha As Date, ByVal Usuario As String) As Boolean

        Dim MiConexion As System.Data.SqlClient.SqlConnection = Nothing
        Dim MiTransaccion As System.Data.SqlClient.SqlTransaction = Nothing
        Dim MiDataTable As New DataTable
        Dim Success = False
        Try
            MiConexion = ConexionNet.Conexion
            MiConexion.Open()
            MiTransaccion = MiConexion.BeginTransaction(IsolationLevel.ReadUncommitted)
            Dim Store As New lbrSoportes.SP_BBDD.Soporte_AgregarFacturaAlCorte
            Store.soporte_AgregarFacturaAlCorte(MiConexion, MiTransaccion, MiDataTable, Folio, Concepto1, Concepto2, Concepto3, Importe, RFC, Fecha, Usuario)
            Success = True
        Catch ex As Exception
            If MiTransaccion IsNot Nothing Then
                Mensajes.Mensaje("Error intentado guardar la información : " & ex.Message())
                MiTransaccion.Rollback()
            End If
            Success = False
        Finally
            If Success And MiTransaccion IsNot Nothing Then
                'Me.Close()
                MiTransaccion.Commit()
            End If
            If MiConexion IsNot Nothing Then
                MiConexion.Close()
                MiConexion.Dispose()
            End If
        End Try
        Return Success
    End Function

    Public Function EjecutaStore_AnticipoA0(ByVal Expediente As String, ByVal NoAnticipo As Integer, ByVal Monto As Decimal, ByVal Fecha As Date) As Boolean

        Dim MiConexion As System.Data.SqlClient.SqlConnection = Nothing
        Dim MiTransaccion As System.Data.SqlClient.SqlTransaction = Nothing
        Dim MiDataTable As New DataTable
        Dim Success = False
        Try
            MiConexion = ConexionNet.Conexion
            MiConexion.Open()
            MiTransaccion = MiConexion.BeginTransaction(IsolationLevel.ReadUncommitted)
            Dim Store As New lbrSoportes.SP_BBDD.Soporte_AnticipoA0
            Store.soporte_AnticipoA0(MiConexion, MiTransaccion, MiDataTable, Expediente, NoAnticipo, Monto, Fecha)
            Success = True
        Catch ex As Exception
            If MiTransaccion IsNot Nothing Then
                Mensajes.Mensaje("Error intentado guardar la información : " & ex.Message())
                MiTransaccion.Rollback()
            End If
            Success = False
        Finally
            If Success And MiTransaccion IsNot Nothing Then
                'Me.Close()
                MiTransaccion.Commit()
            End If
            If MiConexion IsNot Nothing Then
                MiConexion.Close()
                MiConexion.Dispose()
            End If
        End Try
        Return Success
    End Function

    Public Function EjecutaStore_CambiarFechaIC(ByVal Expediente As String, ByVal NoIC As String, ByVal Fecha As Date) As Boolean

        Dim MiConexion As System.Data.SqlClient.SqlConnection = Nothing
        Dim MiTransaccion As System.Data.SqlClient.SqlTransaction = Nothing
        Dim MiDataTable As New DataTable
        Dim Success = False
        Try
            MiConexion = ConexionNet.Conexion
            MiConexion.Open()
            MiTransaccion = MiConexion.BeginTransaction(IsolationLevel.ReadUncommitted)
            Dim Store As New lbrSoportes.SP_BBDD.Soporte_CambiarFechaIC
            Store.soporte_CambiarFechaIC(MiConexion, MiTransaccion, MiDataTable, Expediente, NoIC, Fecha)
            Success = True
        Catch ex As Exception
            If MiTransaccion IsNot Nothing Then
                Mensajes.Mensaje("Error intentado guardar la información : " & ex.Message())
                MiTransaccion.Rollback()
            End If
            Success = False
        Finally
            If Success And MiTransaccion IsNot Nothing Then
                'Me.Close()
                MiTransaccion.Commit()
            End If
            If MiConexion IsNot Nothing Then
                MiConexion.Close()
                MiConexion.Dispose()
            End If
        End Try
        Return Success
    End Function

    Public Function EjecutaStore_CancelarInformeMedico(ByVal Expediente As String) As Boolean
        Dim MiConexion As System.Data.SqlClient.SqlConnection = Nothing
        Dim MiTransaccion As System.Data.SqlClient.SqlTransaction = Nothing
        Dim MiDataTable As New DataTable
        Dim Success = False
        Try
            MiConexion = ConexionNet.Conexion
            MiConexion.Open()
            MiTransaccion = MiConexion.BeginTransaction(IsolationLevel.ReadUncommitted)
            Dim Store As New lbrSoportes.SP_BBDD.Soporte_CancelacionInformeMedico
            Store.soporte_CancelarInformeMedico(MiConexion, MiTransaccion, MiDataTable, Expediente)
            Success = True
        Catch ex As Exception
            If MiTransaccion IsNot Nothing Then
                Mensajes.Mensaje("Error intentado guardar la información : " & ex.Message())
                MiTransaccion.Rollback()
            End If
            Success = False
        Finally
            If Success And MiTransaccion IsNot Nothing Then
                'Me.Close()
                MiTransaccion.Commit()
            End If
            If MiConexion IsNot Nothing Then
                MiConexion.Close()
                MiConexion.Dispose()
            End If
        End Try
        Return Success
    End Function

    Public Function EjecutaStore_HabilitarAnticipo(ByVal Expediente As String, ByVal NumeroAnticipo As Integer, ByVal Monto As Decimal, ByVal Fecha As Date) As Boolean
        Dim MiConexion As System.Data.SqlClient.SqlConnection = Nothing
        Dim MiTransaccion As System.Data.SqlClient.SqlTransaction = Nothing
        Dim MiDataTable As New DataTable
        Dim Success = False
        Try
            MiConexion = ConexionNet.Conexion
            MiConexion.Open()
            MiTransaccion = MiConexion.BeginTransaction(IsolationLevel.ReadUncommitted)
            Dim Store As New lbrSoportes.SP_BBDD.Soporte_HabilitarAnticipo
            Store.soporte_HabilitarAnticipo(MiConexion, MiTransaccion, MiDataTable, Expediente, NumeroAnticipo, Monto, Fecha)
            Success = True
        Catch ex As Exception
            If MiTransaccion IsNot Nothing Then
                Mensajes.Mensaje("Error intentado guardar la información : " & ex.Message())
                MiTransaccion.Rollback()
            End If
            Success = False
        Finally
            If Success And MiTransaccion IsNot Nothing Then
                'Me.Close()
                MiTransaccion.Commit()
            End If
            If MiConexion IsNot Nothing Then
                MiConexion.Close()
                MiConexion.Dispose()
            End If
        End Try
        Return Success
    End Function

    Public Function EjecutaStore_InhabilitarAnticipo(ByVal Expediente As String, ByVal NumeroAnticipo As Integer, ByVal Monto As Decimal, ByVal Fecha As Date) As Boolean
        Dim MiConexion As System.Data.SqlClient.SqlConnection = Nothing
        Dim MiTransaccion As System.Data.SqlClient.SqlTransaction = Nothing
        Dim MiDataTable As New DataTable
        Dim Success = False
        Try
            MiConexion = ConexionNet.Conexion
            MiConexion.Open()
            MiTransaccion = MiConexion.BeginTransaction(IsolationLevel.ReadUncommitted)
            Dim Store As New lbrSoportes.SP_BBDD.Soporte_InhabilitarAnticipo
            Store.soporte_InhabiitarAnticipo(MiConexion, MiTransaccion, MiDataTable, Expediente, NumeroAnticipo, Monto, Fecha)
            Success = True
        Catch ex As Exception
            If MiTransaccion IsNot Nothing Then
                Mensajes.Mensaje("Error intentado guardar la información : " & ex.Message())
                MiTransaccion.Rollback()
            End If
            Success = False
        Finally
            If Success And MiTransaccion IsNot Nothing Then
                'Me.Close()
                MiTransaccion.Commit()
            End If
            If MiConexion IsNot Nothing Then
                MiConexion.Close()
                MiConexion.Dispose()
            End If
        End Try
        Return Success
    End Function

    Public Function EjecutaStore_ObtenerPrecioProcedimiento(ByVal Clave As String, ByVal NSE As Integer) As DataTable
        Dim MiConexion As System.Data.SqlClient.SqlConnection = Nothing
        Dim MiTransaccion As System.Data.SqlClient.SqlTransaction = Nothing
        Dim MiDataTable As New DataTable
        Try
            MiConexion = ConexionNet.Conexion
            MiConexion.Open()
            MiTransaccion = MiConexion.BeginTransaction(IsolationLevel.ReadUncommitted)
            Dim Store As New lbrSoportes.SP_BBDD.Soporte_ObtenerPrecioProcedimiento
            Store.Soporte_ObtenerPrecioProcedimiento(MiConexion, MiTransaccion, MiDataTable, Clave, NSE)
            Return MiDataTable
        Catch ex As Exception
            Mensajes.Mensaje("Error intentado obtener la información : " & ex.Message())
        Finally
            If MiConexion IsNot Nothing Then
                MiConexion.Close()
                MiConexion.Dispose()
            End If
        End Try
        Return MiDataTable
    End Function

    Public Function EjecutaStore_QuitarAislamiento(ByVal Expediente As String, ByVal NoCama As String) As Boolean
        Dim MiConexion As System.Data.SqlClient.SqlConnection = Nothing
        Dim MiTransaccion As System.Data.SqlClient.SqlTransaction = Nothing
        Dim MiDataTable As New DataTable
        Dim Success = False
        Try
            MiConexion = ConexionNet.Conexion
            MiConexion.Open()
            MiTransaccion = MiConexion.BeginTransaction(IsolationLevel.ReadUncommitted)
            Dim Store As New lbrSoportes.SP_BBDD.Soporte_QuitarAislamiento
            Store.soporte_QuitarAislamiento(MiConexion, MiTransaccion, MiDataTable, Expediente, NoCama)
            Success = True
        Catch ex As Exception
            If MiTransaccion IsNot Nothing Then
                Mensajes.Mensaje("Error intentado guardar la información : " & ex.Message())
                MiTransaccion.Rollback()
            End If
            Success = False
        Finally
            If Success And MiTransaccion IsNot Nothing Then
                'Me.Close()
                MiTransaccion.Commit()
            End If
            If MiConexion IsNot Nothing Then
                MiConexion.Close()
                MiConexion.Dispose()
            End If
        End Try
        Return Success
    End Function

    Public Function EjecutaStore_ReenviarInformacionSIGAF(ByVal Expediente As String, ByVal Opcion As Integer) As Boolean
        Dim MiConexion As System.Data.SqlClient.SqlConnection = Nothing
        Dim MiTransaccion As System.Data.SqlClient.SqlTransaction = Nothing
        Dim MiDataTable As New DataTable
        Dim Success = False
        Try
            MiConexion = ConexionNet.Conexion
            MiConexion.Open()
            MiTransaccion = MiConexion.BeginTransaction(IsolationLevel.ReadUncommitted)
            Dim Store As New lbrSoportes.SP_BBDD.Soporte_ReenviarInformacionSIGAF
            Store.soporte_ReenviarInformacionSIGAF(MiConexion, MiTransaccion, MiDataTable, Expediente, Opcion)
            Success = True
        Catch ex As Exception
            If MiTransaccion IsNot Nothing Then
                Mensajes.Mensaje("Error intentado guardar la información : " & ex.Message())
                MiTransaccion.Rollback()
            End If
            Success = False
        Finally
            If Success And MiTransaccion IsNot Nothing Then
                'Me.Close()
                MiTransaccion.Commit()
            End If
            If MiConexion IsNot Nothing Then
                MiConexion.Close()
                MiConexion.Dispose()
            End If
        End Try
        Return Success
    End Function

    Public Function EjecutaStore_ReclasificacionDeProcedimientos(ByVal Expediente As String, ByVal NSE As Integer, ByVal FechaInicio As Date, ByVal FechaFin As Date, Usuario As String, UsuarioApp As Integer, TipoMovimiento As Integer, TipoCaja As Integer) As Boolean

        Dim MiConexion As System.Data.SqlClient.SqlConnection = Nothing
        Dim MiTransaccion As System.Data.SqlClient.SqlTransaction = Nothing
        Dim MiDataTable As New DataTable
        Dim Success = False
        Try
            MiConexion = ConexionNet.Conexion
            MiConexion.Open()
            MiTransaccion = MiConexion.BeginTransaction(IsolationLevel.ReadUncommitted)
            Dim Store As New lbrSoportes.SP_BBDD.Soporte_ReclasificacionDeProcedimientos
            Store.soporte_ReclasificacionDeProcedimientos(MiConexion, MiTransaccion, MiDataTable, Expediente, NSE, FechaInicio, FechaFin, Usuario, UsuarioApp, TipoMovimiento, TipoCaja)
            Success = True
        Catch ex As Exception
            If MiTransaccion IsNot Nothing Then
                Mensajes.Mensaje("Error intentado guardar la información : " & ex.Message())
                MiTransaccion.Rollback()
            End If
            Success = False
        Finally
            If Success And MiTransaccion IsNot Nothing Then
                'Me.Close()
                MiTransaccion.Commit()
            End If
            If MiConexion IsNot Nothing Then
                MiConexion.Close()
                MiConexion.Dispose()
            End If
        End Try
        Return Success
    End Function

    Public Function EjecutaStore_RegresarIC(ByVal Expediente As String, ByVal NoIC As String) As Boolean
        Dim MiConexion As System.Data.SqlClient.SqlConnection = Nothing
        Dim MiTransaccion As System.Data.SqlClient.SqlTransaction = Nothing
        Dim MiDataTable As New DataTable
        Dim Success = False
        Try
            MiConexion = ConexionNet.Conexion
            MiConexion.Open()
            MiTransaccion = MiConexion.BeginTransaction(IsolationLevel.ReadUncommitted)
            Dim Store As New lbrSoportes.SP_BBDD.Soporte_RegresarIC
            Store.soporte_RegresarIC(MiConexion, MiTransaccion, MiDataTable, Expediente, NoIC)
            Success = True
        Catch ex As Exception
            If MiTransaccion IsNot Nothing Then
                Mensajes.Mensaje("Error intentado guardar la información : " & ex.Message())
                MiTransaccion.Rollback()
            End If
            Success = False
        Finally
            If Success And MiTransaccion IsNot Nothing Then
                'Me.Close()
                MiTransaccion.Commit()
            End If
            If MiConexion IsNot Nothing Then
                MiConexion.Close()
                MiConexion.Dispose()
            End If
        End Try
        Return Success
    End Function

    Public Function EjecutaStore_SeparacionCuentasCReclasificacion(ByVal Expediente As String, ByVal TipoSeparacion As Integer, ByVal NSE As Integer, ByVal FechaInicio As Date, ByVal FechaFin As Date, ByVal Usuario As String, ByVal UsuarioApp As Integer, ByVal TipoMovimiento As Integer) As Boolean
        Dim MiConexion As System.Data.SqlClient.SqlConnection = Nothing
        Dim MiTransaccion As System.Data.SqlClient.SqlTransaction = Nothing
        Dim MiDataTable As New DataTable
        Dim Success = False
        Try
            MiConexion = ConexionNet.Conexion
            MiConexion.Open()
            MiTransaccion = MiConexion.BeginTransaction(IsolationLevel.ReadUncommitted)
            Dim Store As New lbrSoportes.SP_BBDD.Soporte_SeparacionDeCuentasCReclasificacion
            Store.soporte_SeparacionDeCuentasCReclasificacion(MiConexion, MiTransaccion, MiDataTable, Expediente, TipoSeparacion, NSE, FechaInicio, FechaFin, Usuario, UsuarioApp, TipoMovimiento)
            Success = True
        Catch ex As Exception
            If MiTransaccion IsNot Nothing Then
                Mensajes.Mensaje("Error intentado guardar la información : " & ex.Message())
                MiTransaccion.Rollback()
            End If
            Success = False
        Finally
            If Success And MiTransaccion IsNot Nothing Then
                'Me.Close()
                MiTransaccion.Commit()
            End If
            If MiConexion IsNot Nothing Then
                MiConexion.Close()
                MiConexion.Dispose()
            End If
        End Try
        Return Success
    End Function

    Public Function EjecutaStore_SeparacionCuentasCReclasificacionCE(ByVal Expediente As String, ByVal TipoSeparacion As Integer, ByVal NSE As Integer, ByVal FechaInicio As Date, ByVal FechaFin As Date, ByVal Usuario As String, ByVal UsuarioApp As Integer, ByVal TipoMovimiento As Integer) As Boolean
        Dim MiConexion As System.Data.SqlClient.SqlConnection = Nothing
        Dim MiTransaccion As System.Data.SqlClient.SqlTransaction = Nothing
        Dim MiDataTable As New DataTable
        Dim Success = False
        Try
            MiConexion = ConexionNet.Conexion
            MiConexion.Open()
            MiTransaccion = MiConexion.BeginTransaction(IsolationLevel.ReadUncommitted)
            Dim Store As New lbrSoportes.SP_BBDD.Soporte_SeparacionDeCuentasCReclasificacionCE
            Store.soporte_SeparacionDeCuentasCReclasificacionCE(MiConexion, MiTransaccion, MiDataTable, Expediente, TipoSeparacion, NSE, FechaInicio, FechaFin, Usuario, UsuarioApp, TipoMovimiento)
            Success = True
        Catch ex As Exception
            If MiTransaccion IsNot Nothing Then
                Mensajes.Mensaje("Error intentado guardar la información : " & ex.Message())
                MiTransaccion.Rollback()
            End If
            Success = False
        Finally
            If Success And MiTransaccion IsNot Nothing Then
                'Me.Close()
                MiTransaccion.Commit()
            End If
            If MiConexion IsNot Nothing Then
                MiConexion.Close()
                MiConexion.Dispose()
            End If
        End Try
        Return Success
    End Function

    Public Function EjecutaStore_TicketA0(ByVal Expediente As String, ByVal Caja As Integer, ByVal Ticket As Integer) As Boolean
        Dim MiConexion As System.Data.SqlClient.SqlConnection = Nothing
        Dim MiTransaccion As System.Data.SqlClient.SqlTransaction = Nothing
        Dim MiDataTable As New DataTable
        Dim Success = False
        Try
            MiConexion = ConexionNet.Conexion
            MiConexion.Open()
            MiTransaccion = MiConexion.BeginTransaction(IsolationLevel.ReadUncommitted)
            Dim Store As New lbrSoportes.SP_BBDD.Soporte_TicketA0
            Store.soporte_TicketA0(MiConexion, MiTransaccion, MiDataTable, Expediente, Caja, Ticket)
            Success = True
        Catch ex As Exception
            If MiTransaccion IsNot Nothing Then
                Mensajes.Mensaje("Error intentado guardar la información : " & ex.Message())
                MiTransaccion.Rollback()
            End If
            Success = False
        Finally
            If Success And MiTransaccion IsNot Nothing Then
                'Me.Close()
                MiTransaccion.Commit()
            End If
            If MiConexion IsNot Nothing Then
                MiConexion.Close()
                MiConexion.Dispose()
            End If
        End Try
        Return Success
    End Function

    Public Function EjecutaSeparacionSP(ByVal Expediente As String, ByVal Servicio As Integer, ByVal Diagnostico As Integer) As Boolean
        Dim MiConexion As System.Data.SqlClient.SqlConnection = Nothing
        Dim MiTransaccion As System.Data.SqlClient.SqlTransaction = Nothing
        Dim MiDataTable As New DataTable
        Dim Success = False
        Try
            MiConexion = ConexionNet.Conexion
            MiConexion.Open()
            MiTransaccion = MiConexion.BeginTransaction(IsolationLevel.ReadUncommitted)
            Dim Store As New lbrSoportes.SP_BBDD.Soporte_SeparacionSP
            Store.soporte_SeparacionSP(MiConexion, MiTransaccion, MiDataTable, Expediente, Servicio, Diagnostico)
            Success = True
        Catch ex As Exception
            If MiTransaccion IsNot Nothing Then
                Mensajes.Mensaje("Error intentado guardar la información: " & ex.Message())
                MiTransaccion.Rollback()
            End If
            Success = False
        Finally
            If Success And MiTransaccion IsNot Nothing Then
                'Me.Close()
                MiTransaccion.Commit()
            End If
            If MiConexion IsNot Nothing Then
                MiConexion.Close()
                MiConexion.Dispose()
            End If
        End Try
        Return Success
    End Function

    Public Function EjecutaSeparacionSPUsuario(ByVal Expediente As String, ByVal Usuario As String) As Boolean
        Dim MiConexion As System.Data.SqlClient.SqlConnection = Nothing
        Dim MiTransaccion As System.Data.SqlClient.SqlTransaction = Nothing
        Dim MiDataTable As New DataTable
        Dim Success = False
        Try
            MiConexion = ConexionNet.Conexion
            MiConexion.Open()
            MiTransaccion = MiConexion.BeginTransaction(IsolationLevel.ReadUncommitted)
            Dim Store As New lbrSoportes.SP_BBDD.Soporte_SeparacionSPUsuario
            Store.soporte_SeparacionSPUsuario(MiConexion, MiTransaccion, MiDataTable, Expediente, Usuario)
            Success = True
        Catch ex As Exception
            If MiTransaccion IsNot Nothing Then
                Mensajes.Mensaje("Error intentado guardar la información: " & ex.Message())
                MiTransaccion.Rollback()
            End If
            Success = False
        Finally
            If Success And MiTransaccion IsNot Nothing Then
                'Me.Close()
                MiTransaccion.Commit()
            End If
            If MiConexion IsNot Nothing Then
                MiConexion.Close()
                MiConexion.Dispose()
            End If
        End Try
        Return Success
    End Function

    Public Function existExpediente(ByVal expediente As String) As Boolean
        Dim dt As New DataTable
        dt = ConexionNet.EjecutaSQL(String.Format("SELECT eicapetnexpediente FROM  EICAPSETN where eicapetnexpediente = '{0}' order by eicapetnexpediente", expediente))
        If dt.Rows.Count > 0 Then
            Return True
        End If
        Return False
    End Function

    Public Function existExpedienteSP(ByVal expediente As String) As Boolean
        Dim dt As New DataTable
        dt = ConexionNet.EjecutaSQL(String.Format("select eicapetnexpediente from EICAPSSETNORUGELUPOPRA where eicapetnexpediente = '{0}' and eicapssetnorugelupoprahabilitado = 1", expediente))
        If dt.Rows.Count > 0 Then
            Return True
        End If
        Return False
    End Function

    Public Function existUsuario(ByVal usuario As String) As Boolean
        Dim dt As New DataTable
        dt = ConexionNet.EjecutaSQL(String.Format("SELECT ceridoirotitsniotutnumeroempleado FROM  CERIDOIROTITSNIOTUT where ceridoirotitsniotutnumeroempleado = '{0}' order by ceridoirotitsniotutnumeroempleado", usuario))
        If dt.Rows.Count > 0 Then
            Return True
        End If
        Return False
    End Function

    Public Function existTipoCaja(ByVal Caja As Integer) As Boolean
        Dim dt As New DataTable
        dt = ConexionNet.EjecutaSQL(String.Format("SELECT copitsajaid FROM  COPITSAJA where copitsajaid = {0}", Caja))
        If dt.Rows.Count > 0 Then
            Return True
        End If
        Return False
    End Function

    Public Function existRFC(ByVal RFC As String) As Boolean
        Dim dt As New DataTable
        dt = ConexionNet.EjecutaSQL(String.Format("SELECT rtnoceyubisetnrfc FROM  RTNOCEYUBISETN where rtnoceyubisetnrfc = '{0}' order by rtnoceyubisetnrfc", RFC))
        If dt.Rows.Count > 0 Then
            Return True
        End If
        Return False
    End Function

    Public Function existNumIC(ByVal NumIC As String) As Boolean
        Dim dt As New DataTable
        dt = ConexionNet.EjecutaSQL(String.Format("SELECT cilosedutiidutstapsoigolosocic  FROM CILOSEDUTIIDUTSTAPSOIGOLOSOC  where cilosedutiidutstapsoigolosocic  = '{0}' ", NumIC))
        If dt.Rows.Count > 0 Then
            Return True
        End If
        Return False
    End Function

    Public Function existFolioFactura(ByVal FolioFactura As String) As Boolean
        Dim dt As New DataTable
        dt = ConexionNet.EjecutaSQL(String.Format("SELECT utcafoicarnnumerofactura FROM  UTCAFOICARN  where utcafoicarnnumerofactura = '{0}'", FolioFactura))
        If dt.Rows.Count > 0 Then
            Return False
        End If
        Return True
    End Function

    Public Function existAnticipo(ByVal Anticipo As String) As Boolean
        Dim dt As New DataTable
        dt = ConexionNet.EjecutaSQL(String.Format("SELECT biceritnaosopicid FROM  BICERITNAOSOPIC  where biceritnaosopicid = '{0}'", Anticipo))
        If dt.Rows.Count > 0 Then
            Return True
        End If
        Return False
    End Function

    Public Function existTicket(ByVal Ticket As String) As Boolean
        Dim dt As New DataTable
        dt = ConexionNet.EjecutaSQL(String.Format("SELECT recibonX FROM  ECORPEIMIDSSOTNICILOSODAT where recibonX = '{0}'", Ticket))
        If dt.Rows.Count > 0 Then
            Return True
        End If
        Return False
    End Function

    Public Function obtenerPaciente(ByVal Expediente As String) As DataTable
        Dim dt As New DataTable
        dt = ConexionNet.EjecutaSQL(String.Format("SELECT eicapetnnombre, eicapetnapellidopaterno, eicapetnapellidomaterno from EICAPSETN where eicapetnexpediente = '{0}'", Expediente))
        Return dt
    End Function

    Public Function loadListaSoportes() As DataTable
        Dim dt As New DataTable
        dt = ConexionNet.EjecutaSQL("SELECT catalogosoporteid, catalogosoportedescripcion FROM CATALOGOSOPORTE where catalogosoporteid <> 17 order by catalogosoportedescripcion asc")
        Return dt
    End Function

    Public Function loadNSEPaciente(paciente As String) As Integer
        If paciente = "" Then
            Mensajes.Mensaje("Debe colocar un expediente válido")
            Return -1
        End If
        Dim dt As New DataTable
        dt = ConexionNet.EjecutaSQL("SELECT levinoicosonoceocimid FROM EICAPSETN where eicapetnexpediente = '" & paciente & "'")

        If dt.Rows.Count = 0 Then
            Mensajes.Mensaje("Debe colocar un expediente válido")
            Return -1
        End If
        Return dt.Rows.Item(0)!levinoicosonoceocimid
    End Function

    Public Function loadTipoCaja() As DataTable
        Dim dt As New DataTable
        dt = ConexionNet.EjecutaSQL(String.Format("SELECT copitsajaid, copitsajadescripcion FROM  COPITSAJA where copitsajaid = 1 or copitsajaid = 2"))
        Return dt
    End Function

    Public Function loadSoporteTicketA0() As DataTable
        Dim dt As New DataTable
        dt = ConexionNet.EjecutaSQL("SELECT catalogosoporteid, catalogosoportedescripcion FROM CATALOGOSOPORTE where catalogosoporteid = 17")
        Return dt
    End Function

    Public Function loadSoporteTicketA0Permisos(Usuario As Integer) As Boolean
        Dim dt As New DataTable
        dt = ConexionNet.EjecutaSQL("SELECT usuariossoporteid FROM USUARIOSSOPORTE where usuariossoporteTicket0 = 1 and usuariossoporteid = " & Usuario)
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function loadDataBaseNAme() As DataTable
        Dim dt As New DataTable
        dt = ConexionNet.EjecutaSQL("SELECT DB_NAME() AS DataBaseName")
        Return dt
    End Function

    Public Function loadCamas() As DataTable
        Dim dt As New DataTable
        dt = ConexionNet.EjecutaSQL("SELECT samacipsohlatid, samacipsohlatdescripcion FROM SAMACIPSOHLAT where samacipsohlathabilitado = 1 order by samacipsohlatdescripcion")
        Return dt
    End Function

    Public Function loadServicios() As DataTable
        Dim dt As New DataTable
        dt = ConexionNet.EjecutaSQL("SELECT IVRESSSOICORUGELUPOPRA.ivresssoicorugelupopraid as id, IVRESSOIC.ivressoicdescripcion as descripcion FROM IVRESSSOICORUGELUPOPRA INNER JOIN IVRESSOIC ON IVRESSSOICORUGELUPOPRA.ivressoicid = IVRESSOIC.ivressoicid ORDER BY IVRESSOIC.ivressoicdescripcion")
        Return dt
    End Function

    Public Function loadDiagnosticos(servicio As String) As DataTable
        Dim dt As New DataTable
        dt = ConexionNet.EjecutaSQL(String.Format("select ngaidcitsougesopoporraluid, ngaidcitsougesopoporraludescripcion from NGAIDCITSOUGESOPOPORRALU where ivresssoicorugelupopraid = {0} order by ngaidcitsougesopoporraludescripcion asc", servicio))
        Return dt
    End Function

    Public Function loadCajas() As DataTable
        Dim dt As New DataTable
        dt = ConexionNet.EjecutaSQL("SELECT sajacid, sajacdescripcion FROM  SAJAC where sajacHabilitada = 1 order by sajacdescripcion")
        Return dt
    End Function

    Public Function loadNSE() As DataTable
        Dim dt As New DataTable
        dt = ConexionNet.EjecutaSQL("SELECT levinoicosonoceocimid, levinoicosonoceocimclasificacion FROM  LEVINOICOSONOCEOCIM")
        Return dt
    End Function

    Public Function loadEstados() As DataTable
        Dim dt As New DataTable
        dt = ConexionNet.EjecutaSQL("SELECT datseoid, datseodescripcion from DATSESO")
        Return dt
    End Function

    Public Function loadDelegaciones(Estado As Integer) As DataTable
        Dim dt As New DataTable
        dt = ConexionNet.EjecutaSQL("SELECT gelednoicainumyoipicid, gelednoicainumyoipicdescripcion from GELEDNOICAUMYSEPICINSOI where datseoid = " & Estado & " order by gelednoicainumyoipicdescripcion")
        Return dt
    End Function

    Public Function loadColonias(Delegacion As Integer) As DataTable
        Dim dt As New DataTable
        dt = ConexionNet.EjecutaSQL("SELECT asentamientoiX, asentamientodescripcioX from TNESANEIMASOT where gelednoicainumyoipicid = " & Delegacion & " order by asentamientodescripcioX")
        Return dt
    End Function

    Public Function loadCP(Asentamiento As Integer) As DataTable
        Dim dt As New DataTable
        dt = ConexionNet.EjecutaSQL("select codigopostaliX from TNESANEIMASOT where asentamientoiX = " & Asentamiento)
        Return dt
    End Function

    Public Function loadProcedimientos() As DataTable
        Dim dt As New DataTable
        dt = ConexionNet.EjecutaSQL("SELECT ecorpeimidsotnclave, ecorpeimidsotndescripcion FROM  ECORPEIMIDSOTN where ecorpeimidsotnhabilitado = 1 order by ecorpeimidsotndescripcion")
        Return dt
    End Function

    Public Function insertSoporte(Texto As String, TipoSoporte As Integer, UsuarioID As Integer) As Boolean
        Dim MiConexion As System.Data.SqlClient.SqlConnection = Nothing
        Dim MiTransaccion As System.Data.SqlClient.SqlTransaction = Nothing
        Dim MiDataTable As New DataTable
        Dim Success = False
        Try
            MiConexion = ConexionNet.Conexion
            MiConexion.Open()
            MiTransaccion = MiConexion.BeginTransaction(IsolationLevel.ReadUncommitted)
            ConexionNet.EjecutaTSQL(String.Format("INSERT INTO DETALLESSOPORTE ( detallessoportedescripcion, catalogosoporteid, usuariossoporteid) VALUES ('{0}', {1}, {2})", Texto, TipoSoporte, UsuarioID), MiConexion, MiTransaccion)
            Success = True
        Catch ex As Exception
            If MiTransaccion IsNot Nothing Then
                Mensajes.Mensaje("Error intentado guardar la información: " & ex.Message())
                MiTransaccion.Rollback()
            End If
            Success = False
        Finally
            If Success And MiTransaccion IsNot Nothing Then
                MiTransaccion.Commit()
            End If
            If MiConexion IsNot Nothing Then
                MiConexion.Close()
                MiConexion.Dispose()
            End If
        End Try
        Return Success

    End Function

    Public Function getUserID(Usuario As String) As Integer
        Dim dt As New DataTable
        dt = ConexionNet.EjecutaSQL(String.Format("select usuariossoporteid as ID from USUARIOSSOPORTE where usuariossoporteusuario = '{0}'", Usuario))
        Return dt.Rows.Item(0)!ID
    End Function

    Public Function getServicio(Expediente As String) As Integer
        Dim dt As New DataTable
        dt = ConexionNet.EjecutaSQL(String.Format("select ivresssoicorugelupopraid as ID from EICAPSSETNORUGELUPOPRA where eicapetnexpediente = '{0}' and eicapssetnorugelupoprahabilitado = 1", Expediente))
        Return dt.Rows.Item(0)!ID
    End Function

    Public Function getDiagnostico(Expediente As String) As Integer
        Dim dt As New DataTable
        dt = ConexionNet.EjecutaSQL(String.Format("select ngaidcitsougesopoporraluid as ID from EICAPSSETNORUGELUPOPRA where eicapetnexpediente = '{0}' and eicapssetnorugelupoprahabilitado = 1", Expediente))
        Return dt.Rows.Item(0)!ID
    End Function

    Public Function checkData(Usuario As String, Password As String) As Integer
        Dim pass As String
        Dim dt As New DataTable 'Validar usuario existente en base
        dt = ConexionNet.EjecutaSQL(String.Format("select usuariossoporteusuario from USUARIOSSOPORTE where usuariossoporteusuario = '{0}' and usuariossoportehabilitado = 1 ", Usuario))
        If (dt.Rows.Count() = 0) Then
            Return 0
        End If
        dt.Clear()
        dt = ConexionNet.EjecutaSQL(String.Format("select dbo.fnDesencripta(usuariossoportepassword) as PASS from USUARIOSSOPORTE where usuariossoporteusuario = '{0}' and usuariossoportehabilitado = 1 ", Usuario))
        pass = dt.Rows.Item(0)!PASS
        If (Password.Equals(pass)) Then
            Return 1
        End If
        Return 2
    End Function

End Class