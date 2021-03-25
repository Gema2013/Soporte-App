Public Class Interfaz

    Private _UsuarioActivo As Integer

    Public WriteOnly Property Propiedad() As Integer
        Set(ByVal value As Integer)
            _UsuarioActivo = value
        End Set
    End Property

    Private Sub cmdEjecutar_Click(sender As System.Object, e As System.EventArgs) Handles cmdEjecutar.Click

        Dim Negocios As New lbrNegocios.ValNegocios
        Dim Conexion As New lbrConexion.ValConexion

        If cboSoporte.SelectedValue = 1 Then
            If Not (Negocios.isExpediente(txtExpediente.Text)) Then
                MessageBox.Show("Ingrese un expediente válido")
                Exit Sub
            End If
            If Not (Conexion.existExpediente(txtExpediente.Text)) Then
                MessageBox.Show("El expediente no existe en la Base de Datos")
                Exit Sub
            End If

            If (Conexion.EjecutaStore_ActivarBrazalete(txtExpediente.Text)) Then
                MessageBox.Show("COMPLETADO")
                Conexion.insertSoporte(String.Format("Expediente: {0}", txtExpediente.Text), cboSoporte.SelectedValue, _UsuarioActivo)
            Else
                MessageBox.Show("OCURRIÓ UN ERROR")
            End If

        End If

        If cboSoporte.SelectedValue = 2 Then
            If Not (Conexion.existUsuario(txtUsuario.Text)) Then
                MessageBox.Show("El usuario no existe en la Base de Datos")
                Exit Sub
            End If
            If (Conexion.EjecutaStore_ActivarDesactivarUsuario(txtUsuario.Text, cboOpcion.SelectedIndex)) Then
                MessageBox.Show("COMPLETADO")
                Conexion.insertSoporte(String.Format("Usuario: {0} | Opción: {1}", txtUsuario.Text, cboOpcion.Text), cboSoporte.SelectedValue, _UsuarioActivo)
            Else
                MessageBox.Show("OCURRIÓ UN ERROR")
            End If
        End If

        'If cboSoporte.SelectedValue = 3 Then


        'End If

        If cboSoporte.SelectedValue = 4 Then
            If Not (Conexion.existFolioFactura(txtFactura.Text)) Then
                MessageBox.Show("El Folio ya está facturado")
                Exit Sub
            End If
            If Not (Conexion.existUsuario(txtUsuario.Text)) Then
                MessageBox.Show("El usuario no existe en la Base de Datos")
                Exit Sub
            End If

            Dim concepto As String
            concepto = txtConcepto1.Text

            Dim split As String() = concepto.Split(New [Char]() {" "c})

            Dim concepto1 As String = ""
            Dim concepto2 As String = ""
            Dim concepto3 As String = ""

            Dim counter1 As Integer = 0
            Dim counter2 As Integer = 0
            Dim counter3 As Integer = 0

            Dim Flag1 As Boolean = False
            Dim Flag2 As Boolean = False

            For Each s As String In split
                If s.Trim() <> "" Then
                    '
                    If (counter1 + s.Length + 1) <= 31 And Flag1 = False Then
                        concepto1 = concepto1 & s & " "
                        counter1 = counter1 + s.Length + 1

                    ElseIf (counter2 + s.Length + 1) <= 31 And Flag2 = False Then
                        concepto2 = concepto2 & s & " "
                        counter2 = counter2 + s.Length + 1
                        Flag1 = True

                    ElseIf Flag1 = True Then
                        concepto3 = concepto3 & s & " "
                        counter3 = counter3 + s.Length + 1
                        Flag2 = True

                    End If
                End If

            Next s

            If concepto1.Length > 0 Then
                concepto1 = concepto1.Remove(concepto1.Length - 1)
            End If

            If concepto2.Length > 0 Then
                concepto2 = concepto2.Remove(concepto2.Length - 1)
            End If

            If concepto3.Length > 0 Then

                concepto3 = concepto3.Remove(concepto3.Length - 1)
                If concepto3.Length > 30 Then
                    concepto3 = concepto3.Remove(30)
                End If

            End If

            dtpFecha1.Value = DateAdd(DateInterval.Hour, 12, dtpFecha1.Value.Date)

            If (Conexion.EjecutaStore_AgregarFacturaAlCorte(txtFactura.Text, concepto1, concepto2, concepto3, txtImporte.Text, txtRFC.Text, DateAdd(DateInterval.Hour, 12, dtpFecha1.Value.Date), txtUsuario.Text)) Then
                MessageBox.Show("COMPLETADO")
                Conexion.insertSoporte(String.Format("Folio: {0}| Concepto: {1} {2} {3}| Importe: {4}| RFC: {5}| Fecha: {6}| Usuario: {7}", txtFactura.Text, concepto1, concepto2, concepto3, txtImporte.Text, txtRFC.Text, dtpFecha1.Text, txtUsuario.Text), cboSoporte.SelectedValue, _UsuarioActivo)
            Else
                MessageBox.Show("OCURRIÓ UN ERROR")
            End If
        End If

        If cboSoporte.SelectedValue = 5 Then
            If Not (Negocios.isExpediente(txtExpediente.Text)) Then
                MessageBox.Show("Ingrese un expediente válido")
                Exit Sub
            End If
            If Not (Conexion.existExpediente(txtExpediente.Text)) Then
                MessageBox.Show("El expediente no existe en la Base de Datos")
                Exit Sub
            End If
            If Not (Conexion.existAnticipo(txtAnticipo.Text)) Then
                MessageBox.Show("El anticipo no existe")
                Exit Sub
            End If
            If (Conexion.EjecutaStore_AnticipoA0(txtExpediente.Text, txtAnticipo.Text, txtImporte.Text, dtpFecha1.Value.Date)) Then
                MessageBox.Show("COMPLETADO")
                Conexion.insertSoporte(String.Format("Expediente: {0}| Num. Anticipo: {1}| Importe: {2}|Fecha: {3}", txtExpediente.Text, txtAnticipo.Text, txtImporte.Text, dtpFecha1.Text), cboSoporte.SelectedValue, _UsuarioActivo)
            Else
                MessageBox.Show("OCURRIÓ UN ERROR")
            End If
        End If

        If cboSoporte.SelectedValue = 6 Then
            If Not (Negocios.isExpediente(txtExpediente.Text)) Then
                MessageBox.Show("Ingrese un expediente válido")
                Exit Sub
            End If
            If Not (Conexion.existExpediente(txtExpediente.Text)) Then
                MessageBox.Show("El expediente no existe en la Base de Datos")
                Exit Sub
            End If
            If Not (Conexion.existNumIC(txtNumIC.Text)) Then
                MessageBox.Show("El número de IC no existe")
                Exit Sub
            End If
            If (Conexion.EjecutaStore_CambiarFechaIC(txtExpediente.Text, txtNumIC.Text, dtpFecha1.Value.Date)) Then
                MessageBox.Show("COMPLETADO")
                Conexion.insertSoporte(String.Format("Expediente: {0}| Num. IC: {1}|Fecha: {2}", txtExpediente.Text, txtNumIC.Text, dtpFecha1.Text), cboSoporte.SelectedValue, _UsuarioActivo)
            Else
                MessageBox.Show("OCURRIÓ UN ERROR")
            End If
        End If

        If cboSoporte.SelectedValue = 7 Then
            If Not (Negocios.isExpediente(txtExpediente.Text)) Then
                MessageBox.Show("Ingrese un expediente válido")
                Exit Sub
            End If
            If Not (Conexion.existExpediente(txtExpediente.Text)) Then
                MessageBox.Show("El expediente no existe en la Base de Datos")
                Exit Sub
            End If

            If (Conexion.EjecutaStore_CancelarInformeMedico(txtExpediente.Text)) Then
                MessageBox.Show("COMPLETADO")
                Conexion.insertSoporte(String.Format("Expediente: {0}", txtExpediente.Text), cboSoporte.SelectedValue, _UsuarioActivo)
            Else
                MessageBox.Show("OCURRIÓ UN ERROR")
            End If

        End If

        If cboSoporte.SelectedValue = 8 Then
            If Not (Negocios.isExpediente(txtExpediente.Text)) Then
                MessageBox.Show("Ingrese un expediente válido")
                Exit Sub
            End If

            If Not (Negocios.isAnticipo(txtAnticipo.Text)) Then
                MessageBox.Show("Ingrese un número de Anticipo válido")
                Exit Sub
            End If

            If Not (Negocios.isMonto(txtImporte.Text)) Then
                MessageBox.Show("Ingrese un monto válido")
                Exit Sub
            End If

            If (Conexion.EjecutaStore_InhabilitarAnticipo(txtExpediente.Text, txtAnticipo.Text, txtImporte.Text, dtpFecha1.Value.Date)) Then
                MessageBox.Show("COMPLETADO")
                Conexion.insertSoporte(String.Format("Expediente: {0}| Num. Anticipo: {1}| Importe: {2}| Fecha: {3}", txtExpediente.Text, txtAnticipo.Text, txtImporte.Text, dtpFecha1.Text), cboSoporte.SelectedValue, _UsuarioActivo)
            Else
                MessageBox.Show("OCURRIÓ UN ERROR")
            End If

        End If

        If cboSoporte.SelectedValue = 9 Then
            If Not (Negocios.isExpediente(txtExpediente.Text)) Then
                MessageBox.Show("Ingrese un expediente válido")
                Exit Sub
            End If
            If Not (Conexion.existExpediente(txtExpediente.Text)) Then
                MessageBox.Show("El expediente no existe en la Base de Datos")
                Exit Sub
            End If

            If Not (Negocios.isAnticipo(txtAnticipo.Text)) Then
                MessageBox.Show("Ingrese un número de Anticipo válido")
                Exit Sub
            End If

            If Not (Negocios.isMonto(txtImporte.Text)) Then
                MessageBox.Show("Ingrese un monto válido")
                Exit Sub
            End If

            If (Conexion.EjecutaStore_HabilitarAnticipo(txtExpediente.Text, txtAnticipo.Text, txtImporte.Text, dtpFecha1.Value.Date)) Then
                MessageBox.Show("COMPLETADO")
                Conexion.insertSoporte(String.Format("Expediente: {0}| Num. Anticipo: {1}| Importe: {2}| Fecha: {3}", txtExpediente.Text, txtAnticipo.Text, txtImporte.Text, dtpFecha1.Text), cboSoporte.SelectedValue, _UsuarioActivo)
            Else
                MessageBox.Show("OCURRIÓ UN ERROR")
            End If
        End If

        If cboSoporte.SelectedValue = 10 Then
            If Not (Negocios.comboOption(cboNSE.SelectedValue)) Then
                MessageBox.Show("Selecciona un número de Nivel socioeconómico válido ")
                Exit Sub
            End If

            If Not (Negocios.comboOption(cboProcedimiento.SelectedValue)) Then
                MessageBox.Show("Selecciona un procedimiento válido ")
                Exit Sub
            End If

            Dim dt As DataTable
            dt = Conexion.EjecutaStore_ObtenerPrecioProcedimiento(cboProcedimiento.SelectedValue, cboNSE.SelectedValue)
            If (dt.Rows.Count > 0) Then
                lbltotal.Text = ("Importe: " & FormatCurrency(dt.Rows.Item(0)!IMPORTE))
                Conexion.insertSoporte(String.Format("Procedimiento: {0}| NSE: {1}", cboProcedimiento.Text, cboNSE.Text), cboSoporte.SelectedValue, _UsuarioActivo)
            Else
                MessageBox.Show("No existe precio para este procedimiento")
            End If

        End If

        If cboSoporte.SelectedValue = 11 Then
            If chkCama.Checked Then
                If Not (Negocios.comboOption(cboCama.SelectedValue)) Then
                    MessageBox.Show("Selecciona una cama")
                    Exit Sub
                End If
                If (Conexion.EjecutaStore_QuitarAislamiento(Nothing, cboCama.Text)) Then
                    MessageBox.Show("COMPLETADO")
                    Conexion.insertSoporte(String.Format("Num.Cama {0}", cboCama.Text), cboSoporte.SelectedValue, _UsuarioActivo)
                Else
                    MessageBox.Show("OCURRIÓ UN ERROR")
                End If
            Else
                If Not (Negocios.isExpediente(txtExpediente.Text)) Then
                    MessageBox.Show("Ingrese un expediente válido")
                    Exit Sub
                End If
                If Not (Conexion.existExpediente(txtExpediente.Text)) Then
                    MessageBox.Show("El expediente no existe en la Base de Datos")
                    Exit Sub
                End If
                If (Conexion.EjecutaStore_QuitarAislamiento(txtExpediente.Text, Nothing)) Then
                    MessageBox.Show("COMPLETADO")
                    Conexion.insertSoporte(String.Format("Expediente: {0}", txtExpediente.Text), cboSoporte.SelectedValue, _UsuarioActivo)
                Else
                    MessageBox.Show("OCURRIÓ UN ERROR")
                End If
            End If
            txtExpediente.Enabled = True
        End If

        If cboSoporte.SelectedValue = 12 Then
            If Not (Negocios.isExpediente(txtExpediente.Text)) Then
                MessageBox.Show("Ingrese un expediente válido")
                Exit Sub
            End If
            If Not (Conexion.existExpediente(txtExpediente.Text)) Then
                MessageBox.Show("El expediente no existe en la Base de Datos")
                Exit Sub
            End If
            If Not (Negocios.comboOption(cboNSE.SelectedValue)) Then
                MessageBox.Show("Ingrese un número de Nivel socioeconómico válido ")
                Exit Sub
            End If

            If Not (Negocios.isFecha(dtpFecha1.Value.Date, dtpFecha2.Value.Date)) Then
                MessageBox.Show("La Fecha FINAL no puede ser menor que la INICIAL")
                Exit Sub
            End If

            If Not (Conexion.existUsuario(txtUsuarioTicket0.Text)) Then
                MessageBox.Show("El usuario no existe en la Base de Datos")
                Exit Sub
            End If

            If Not (Conexion.existTipoCaja(cboTipoCaja.SelectedValue)) Then
                MessageBox.Show("Seleccione el tipo de Caja")
                Exit Sub
            End If
            If (Conexion.EjecutaStore_ReclasificacionDeProcedimientos(txtExpediente.Text, cboNSE.SelectedValue, dtpFecha1.Value.Date, dtpFecha2.Value.Date, txtUsuarioTicket0.Text, _UsuarioActivo, 5, cboTipoCaja.SelectedValue)) Then
                MessageBox.Show("COMPLETADO")
                Conexion.insertSoporte(String.Format("Expediente: {0}| NSE: {1}| Fecha inicial: {2}| Fecha final: {3}| Usuario: {4}", txtExpediente.Text, cboNSE.Text, dtpFecha1.Text, dtpFecha2.Text, txtUsuarioTicket0.Text), cboSoporte.SelectedValue, _UsuarioActivo)
            Else
                MessageBox.Show("OCURRIÓ UN ERROR")
            End If
        End If

        If cboSoporte.SelectedValue = 13 Then
            If Not (Negocios.isExpediente(txtExpediente.Text)) Then
                MessageBox.Show("Ingrese un expediente válido")
                Exit Sub
            End If
            If Not (Conexion.existExpediente(txtExpediente.Text)) Then
                MessageBox.Show("El expediente no existe en la Base de Datos")
                Exit Sub
            End If
            If Not (Negocios.texto(cboOpcion.Text)) Then
                MessageBox.Show("Ingrese una opción válida")
                Exit Sub
            End If

            If (Conexion.EjecutaStore_ReenviarInformacionSIGAF(txtExpediente.Text, cboOpcion.SelectedIndex + 1)) Then
                MessageBox.Show("COMPLETADO")
                Conexion.insertSoporte(String.Format("Expediente: {0}| Opcion: {1}", txtExpediente.Text, cboOpcion.Text), cboSoporte.SelectedValue, _UsuarioActivo)
            Else
                MessageBox.Show("OCURRIÓ UN ERROR")
            End If
        End If

        If cboSoporte.SelectedValue = 14 Then
            If Not (Negocios.isExpediente(txtExpediente.Text)) Then
                MessageBox.Show("Ingrese un expediente válido")
                Exit Sub
            End If
            If Not (Conexion.existExpediente(txtExpediente.Text)) Then
                MessageBox.Show("El expediente no existe en la Base de Datos")
                Exit Sub
            End If
            If Not (Conexion.existNumIC(txtNumIC.Text)) Then
                MessageBox.Show("El número de IC no existe")
                Exit Sub
            End If
            If (Conexion.EjecutaStore_RegresarIC(txtExpediente.Text, txtNumIC.Text)) Then
                MessageBox.Show("COMPLETADO")
                Conexion.insertSoporte(String.Format("Expediente: {0}| Num. IC: {1}", txtExpediente.Text, txtNumIC.Text), cboSoporte.SelectedValue, _UsuarioActivo)
            Else
                MessageBox.Show("OCURRIÓ UN ERROR")
            End If
        End If

        If cboSoporte.SelectedValue = 15 Then
            If Not (Negocios.isExpediente(txtExpediente.Text)) Then
                MessageBox.Show("Ingrese un expediente válido")
                Exit Sub
            End If
            If Not (Conexion.existExpediente(txtExpediente.Text)) Then
                MessageBox.Show("El expediente no existe en la Base de Datos")
                Exit Sub
            End If

            If Not (Negocios.texto(cboOpcion.SelectedIndex)) Then
                MessageBox.Show("Seleccione un tipo de clasificación ")
                Exit Sub
            End If

            If Not (Negocios.comboOption(cboNSE.SelectedValue)) Then
                MessageBox.Show("Ingrese un número de Nivel socioeconómico válido ")
                Exit Sub
            End If

            If Not (Negocios.isFecha(dtpFecha1.Value.Date, dtpFecha2.Value.Date)) Then
                MessageBox.Show("La Fecha FINAL no puede ser menor que la INICIAL")
                Exit Sub
            End If

            If Not (Conexion.existUsuario(txtUsuarioTicket0.Text)) Then
                MessageBox.Show("El usuario no existe en la Base de Datos")
                Exit Sub
            End If

            'If Not (Conexion.existTipoCaja(cboTipoCaja.SelectedValue)) Then
            '    MessageBox.Show("Selecciona un tipo de caja válido")
            '    Exit Sub
            'End If

            If (Conexion.EjecutaStore_SeparacionCuentasCReclasificacion(txtExpediente.Text, cboTipoSeparacion.SelectedIndex + 1, cboNSE.SelectedValue, dtpFecha1.Value.Date, dtpFecha2.Value.Date, txtUsuarioTicket0.Text, _UsuarioActivo, cboTipoSeparacion.SelectedIndex + 1)) Then
                MessageBox.Show("COMPLETADO")
                Conexion.insertSoporte(String.Format("Expediente: {0}| Tipo Separacion: {1}| NSE: {2}| Fecha inicial: {3}|Fecha final: {4}|Usuario: {5}", txtExpediente.Text, cboTipoSeparacion.Text, cboNSE.Text, dtpFecha1.Text, dtpFecha2.Text, txtUsuarioTicket0.Text), cboSoporte.SelectedValue, _UsuarioActivo)
            Else
                MessageBox.Show("OCURRIÓ UN ERROR")
            End If
        End If

        If cboSoporte.SelectedValue = 16 Then
            If Not (Negocios.isExpediente(txtExpediente.Text)) Then
                MessageBox.Show("Ingrese un expediente válido")
                Exit Sub
            End If
            If Not (Conexion.existExpediente(txtExpediente.Text)) Then
                MessageBox.Show("El expediente no existe en la Base de Datos")
                Exit Sub
            End If

            If Not (Negocios.texto(cboOpcion.SelectedIndex)) Then
                MessageBox.Show("Seleccione un tipo de clasificación")
                Exit Sub
            End If

            If Not (Negocios.comboOption(cboNSE.SelectedValue)) Then
                MessageBox.Show("Ingrese un número de Nivel socioeconómico válido")
                Exit Sub
            End If

            If Not (Negocios.isFecha(dtpFecha1.Value.Date, dtpFecha2.Value.Date)) Then
                MessageBox.Show("La Fecha FINAL no puede ser menor que la INICIAL")
                Exit Sub
            End If

            If Not (Conexion.existUsuario(txtUsuarioTicket0.Text)) Then
                MessageBox.Show("El usuario no existe en la Base de Datos")
                Exit Sub
            End If

            If (Conexion.EjecutaStore_SeparacionCuentasCReclasificacionCE(txtExpediente.Text, cboTipoSeparacion.SelectedIndex + 1, cboNSE.SelectedValue, dtpFecha1.Value.Date, dtpFecha2.Value.Date, txtUsuarioTicket0.Text, _UsuarioActivo, cboTipoSeparacion.SelectedIndex + 1)) Then
                MessageBox.Show("COMPLETADO")
                Conexion.insertSoporte(String.Format("Expediente: {0}| Tipo Separacion: {1}| NSE: {2}| Fecha inicial: {3}|Fecha final: {4} | Usuario: {5}", txtExpediente.Text, cboTipoSeparacion.Text, cboNSE.Text, dtpFecha1.Text, dtpFecha2.Text, txtUsuarioTicket0.Text), cboSoporte.SelectedValue, _UsuarioActivo)
            Else
                MessageBox.Show("OCURRIÓ UN ERROR")
            End If
        End If

        If cboSoporte.SelectedValue = 17 Then
            If Not (Negocios.isExpediente(txtExpediente.Text)) Then
                MessageBox.Show("Ingrese un expediente válido")
                Exit Sub
            End If
            If Not (Conexion.existExpediente(txtExpediente.Text)) Then
                MessageBox.Show("El expediente no existe en la Base de Datos")
                Exit Sub
            End If

            If Not (Negocios.isTicket(txtTicket.Text)) Then
                MessageBox.Show("Ingrese un número de Ticket válido")
                Exit Sub
            End If

            If Not (Negocios.comboOption(cboCaja.SelectedValue)) Then
                MessageBox.Show("Seleccione un número de caja válido")
                Exit Sub
            End If

            If Not (Conexion.existUsuario(txtUsuarioTicket0.Text)) Then
                MessageBox.Show("El usuario no existe en la Base de Datos")
                Exit Sub
            End If

            If (Conexion.EjecutaStore_TicketA0(txtExpediente.Text, cboCaja.SelectedValue, txtTicket.Text)) Then
                MessageBox.Show("COMPLETADO")
                Conexion.insertSoporte(String.Format("Expediente: {0}| Num. Caja: {1}| Num. Ticket: {2}|Usuario: {3}", txtExpediente.Text, cboCaja.Text, txtTicket.Text, txtUsuarioTicket0.Text), cboSoporte.SelectedValue, _UsuarioActivo)
            Else
                MessageBox.Show("OCURRIÓ UN ERROR")
            End If
        End If

        If cboSoporte.SelectedValue = 18 Then
            If Not (Negocios.isExpediente(txtExpediente.Text)) Then
                MessageBox.Show("Ingrese un expediente válido")
                Exit Sub
            End If
            If Not (Conexion.existExpediente(txtExpediente.Text)) Then
                MessageBox.Show("El expediente no existe en la Base de Datos")
                Exit Sub
            End If

            If Not (Conexion.existUsuario(txtUsuario2.Text)) Then
                MessageBox.Show("El usuario no existe")
                Exit Sub
            End If

            If Not (Negocios.comboOption(cboServicio.SelectedValue)) Then
                MessageBox.Show("Seleccione un servicio válido")
                Exit Sub
            End If

            If Not (Negocios.comboOption(cboDiagnostico.SelectedValue)) Then
                MessageBox.Show("Seleccione un dianostico válido")
                Exit Sub
            End If

            If (Conexion.EjecutaSeparacionSP(txtExpediente.Text, cboServicio.SelectedValue, cboDiagnostico.SelectedValue)) Then
                Conexion.EjecutaSeparacionSPUsuario(txtExpediente.Text, txtUsuario2.Text)
                MessageBox.Show("COMPLETADO")
                Conexion.insertSoporte(String.Format("Expediente: {0}| Usuario: {1}| Servicio: {2}| Diagnóstico: {3}", txtExpediente.Text, txtUsuario2.Text, cboServicio.Text, cboDiagnostico.Text), cboSoporte.SelectedValue, _UsuarioActivo)
            Else
                MessageBox.Show("OCURRIÓ UN ERROR")
            End If
        End If

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        lblVersion.Text = "1.2.4"

        txtNombrePaciente.Enabled = True
        txtNombrePaciente.BorderStyle = 0
        txtNombrePaciente.BackColor = Me.BackColor
        txtNombrePaciente.TabStop = False

        lblTipoCaja.Visible = False
        cboTipoCaja.Visible = False
        lblUsuarioTicket0.Visible = False
        txtUsuarioTicket0.Visible = False
        lblUsuario2.Visible = False
        txtUsuario2.Visible = False
        txtUsuario2.Text = ""
        lblServicio.Visible = False
        cboServicio.Visible = False
        lblDiagnostico.Visible = False
        cboDiagnostico.Visible = False
        txtNombrePaciente.Text = ""
        txtNombrePaciente.Visible = False
        chkCama.Visible = False
        lblTipoSeparacion.Visible = False
        cboTipoSeparacion.Visible = False
        lblCama.Visible = False
        cboCama.Visible = False
        lblFactura.Visible = False
        txtFactura.Visible = False
        lblNumIC.Visible = False
        txtNumIC.Visible = False
        lblConcepto1.Visible = False
        txtConcepto1.Visible = False
        lblRFC.Visible = False
        txtRFC.Visible = False
        lblUsuario.Visible = False
        txtUsuario.Visible = False
        cboOpcion.Visible = False
        lblOpcion.Visible = False
        txtExpediente.Visible = False
        cboCaja.Visible = False
        txtTicket.Visible = False
        txtImporte.Visible = False
        cboNSE.Visible = False
        txtAnticipo.Visible = False
        dtpFecha1.Visible = False
        dtpFecha2.Visible = False
        lblExpediente.Visible = False
        lblCaja.Visible = False
        lblTicket.Visible = False
        lblImporte.Visible = False
        lblNSE.Visible = False
        lblAnticipo.Visible = False
        lblFecha1.Visible = False
        lblFecha2.Visible = False
        lblProcedimiento.Visible = False
        cboProcedimiento.Visible = False
        lbltotal.Visible = False

        Dim Conexion As New lbrConexion.ValConexion
        'Carga de ComboBox

        Dim DtBase As New DataTable
        DtBase = Conexion.loadDataBaseNAme()
        lblBase.Text = DtBase.Rows(0).Item(0).ToString

        Dim DtSoportes As New DataTable
        DtSoportes = Conexion.loadListaSoportes()

        'Anexo de Soportes con permisos especiales a la lista
        If Conexion.loadSoporteTicketA0Permisos(_UsuarioActivo) Then
            Dim dtTicketA0 As DataTable
            dtTicketA0 = Conexion.loadSoporteTicketA0
            DtSoportes.Merge(dtTicketA0)
        End If
        'fin Anexo

        'Ordenar Soportes por orden alfabético
        Dim dataView As New DataView(DtSoportes)
        dataView.Sort = "catalogosoportedescripcion ASC"
        DtSoportes = dataView.ToTable()
        'Fin Ordenamiento

        With (cboSoporte)
            .DisplayMember = "catalogosoportedescripcion"
            .ValueMember = "catalogosoporteid"
            .DataSource = DtSoportes
            .SelectedIndex = -1
        End With

        Dim DtCajas As New DataTable
        DtCajas = Conexion.loadCajas()
        With cboCaja
            .DisplayMember = "sajacdescripcion"
            .ValueMember = "sajacid"
            .DataSource = DtCajas
            .SelectedIndex = -1
        End With

        Dim DtTipoCajas As New DataTable
        DtTipoCajas = Conexion.loadTipoCaja()
        With cboTipoCaja
            .DisplayMember = "copitsajadescripcion"
            .ValueMember = "copitsajaid"
            .DataSource = DtTipoCajas
            .SelectedIndex = -1
        End With

        Dim dtNSE As New DataTable
        dtNSE = Conexion.loadNSE()
        With cboNSE
            .DisplayMember = "levinoicosonoceocimclasificacion"
            .ValueMember = "levinoicosonoceocimid"
            .DataSource = dtNSE
            .SelectedIndex = -1
        End With

        Dim dtCamas As New DataTable
        dtCamas = Conexion.loadCamas()
        With cboCama
            .DisplayMember = "samacipsohlatdescripcion"
            .ValueMember = "samacipsohlatid"
            .DataSource = dtCamas
            .SelectedIndex = -1
        End With

        Dim dtProcedimientos As New DataTable
        dtProcedimientos = Conexion.loadProcedimientos
        With cboProcedimiento
            .DisplayMember = "ecorpeimidsotndescripcion"
            .ValueMember = "ecorpeimidsotnclave"
            .DataSource = dtProcedimientos
            .SelectedIndex = -1
        End With

        Dim dtServicios As New DataTable
        dtServicios = Conexion.loadServicios
        With cboServicio
            .DisplayMember = "descripcion"
            .ValueMember = "id"
            .DataSource = dtServicios
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboSoporte.SelectionChangeCommitted
        If cboSoporte.SelectedValue = 1 Or cboSoporte.SelectedValue = 7 Then
            lblTipoCaja.Visible = False
            cboTipoCaja.Visible = False
            lblUsuarioTicket0.Visible = False
            txtUsuarioTicket0.Visible = False
            lblUsuario2.Visible = False
            txtUsuario2.Visible = False
            txtUsuario2.Text = ""
            lblServicio.Visible = False
            cboServicio.Visible = False
            lblDiagnostico.Visible = False
            cboDiagnostico.Visible = False
            txtNombrePaciente.Text = ""
            txtNombrePaciente.Visible = True
            chkCama.Visible = False
            lblTipoSeparacion.Visible = False
            cboTipoSeparacion.Visible = False
            lblCama.Visible = False
            cboCama.Visible = False
            lblFactura.Visible = False
            txtFactura.Visible = False
            lblNumIC.Visible = False
            txtNumIC.Visible = False
            lblConcepto1.Visible = False
            txtConcepto1.Visible = False
            lblRFC.Visible = False
            txtRFC.Visible = False
            lblUsuario.Visible = False
            txtUsuario.Visible = False
            cboOpcion.Visible = False
            lblOpcion.Visible = False
            txtExpediente.Visible = True
            txtExpediente.Text = ""
            cboCaja.Visible = False
            txtTicket.Visible = False
            txtImporte.Visible = False
            cboNSE.Visible = False
            txtAnticipo.Visible = False
            dtpFecha1.Visible = False
            dtpFecha2.Visible = False
            lblExpediente.Visible = True
            lblCaja.Visible = False
            lblTicket.Visible = False
            lblImporte.Visible = False
            lblNSE.Visible = False
            lblAnticipo.Visible = False
            lblFecha1.Visible = False
            lblFecha2.Visible = False
            lblProcedimiento.Visible = False
            cboProcedimiento.Visible = False
            lbltotal.Visible = False

        ElseIf cboSoporte.SelectedValue = 2 Then
            lblTipoCaja.Visible = False
            cboTipoCaja.Visible = False
            lblUsuarioTicket0.Visible = False
            txtUsuarioTicket0.Visible = False
            lblUsuario2.Visible = False
            txtUsuario2.Visible = False
            txtUsuario2.Text = ""
            lblServicio.Visible = False
            cboServicio.Visible = False
            lblDiagnostico.Visible = False
            cboDiagnostico.Visible = False
            txtNombrePaciente.Text = ""
            txtNombrePaciente.Visible = False
            chkCama.Visible = False
            lblTipoSeparacion.Visible = False
            cboTipoSeparacion.Visible = False
            lblCama.Visible = False
            cboCama.Visible = False
            cboOpcion.Items.Clear()
            cboOpcion.Items.Add("Deshabilitar Usuario")
            cboOpcion.Items.Add("Habilitar Usuario")
            lblFactura.Visible = False
            txtFactura.Visible = False
            lblNumIC.Visible = False
            txtNumIC.Visible = False
            lblConcepto1.Visible = False
            txtConcepto1.Visible = False
            lblRFC.Visible = False
            txtRFC.Visible = False
            lblUsuario.Visible = True
            txtUsuario.Visible = True
            txtUsuario.Text = ""
            cboOpcion.Visible = True
            cboOpcion.Text = ""
            lblOpcion.Visible = True
            txtExpediente.Visible = False
            cboCaja.Visible = False
            txtTicket.Visible = False
            txtImporte.Visible = False
            cboNSE.Visible = False
            txtAnticipo.Visible = False
            dtpFecha1.Visible = False
            dtpFecha2.Visible = False
            lblExpediente.Visible = False
            lblCaja.Visible = False
            lblTicket.Visible = False
            lblImporte.Visible = False
            lblNSE.Visible = False
            lblAnticipo.Visible = False
            lblFecha1.Visible = False
            lblFecha2.Visible = False
            lblProcedimiento.Visible = False
            cboProcedimiento.Visible = False
            lbltotal.Visible = False

        ElseIf cboSoporte.SelectedValue = 3 Then
            lblTipoCaja.Visible = False
            cboTipoCaja.Visible = False
            lblUsuarioTicket0.Visible = False
            txtUsuarioTicket0.Visible = False
            lblUsuario2.Visible = False
            txtUsuario2.Visible = False
            txtUsuario2.Text = ""
            lblServicio.Visible = False
            cboServicio.Visible = False
            lblDiagnostico.Visible = False
            cboDiagnostico.Visible = False
            txtNombrePaciente.Text = ""
            txtNombrePaciente.Visible = False
            chkCama.Visible = False
            lblTipoSeparacion.Visible = False
            cboTipoSeparacion.Visible = False
            lblCama.Visible = False
            cboCama.Visible = False
            lblFactura.Visible = False
            txtFactura.Visible = False
            lblNumIC.Visible = False
            txtNumIC.Visible = False
            lblConcepto1.Visible = False
            txtConcepto1.Visible = False
            lblRFC.Visible = False
            txtRFC.Visible = False
            lblUsuario.Visible = False
            txtUsuario.Visible = False
            cboOpcion.Visible = False
            lblOpcion.Visible = False
            txtExpediente.Visible = False
            cboCaja.Visible = False
            txtTicket.Visible = False
            txtImporte.Visible = False
            cboNSE.Visible = False
            txtAnticipo.Visible = False
            dtpFecha1.Visible = False
            dtpFecha2.Visible = False
            lblExpediente.Visible = False
            lblCaja.Visible = False
            lblTicket.Visible = False
            lblImporte.Visible = False
            lblNSE.Visible = False
            lblAnticipo.Visible = False
            lblFecha1.Visible = False
            lblFecha2.Visible = False
            lblProcedimiento.Visible = False
            cboProcedimiento.Visible = False
            lbltotal.Visible = False

            Dim frm As New Soporte_CPyColonia()
            frm.Propiedad = _UsuarioActivo
            frm.Show()

        ElseIf cboSoporte.SelectedValue = 4 Then
            lblTipoCaja.Visible = False
            cboTipoCaja.Visible = False
            lblUsuarioTicket0.Visible = False
            txtUsuarioTicket0.Visible = False
            lblUsuario2.Visible = False
            txtUsuario2.Visible = False
            txtUsuario2.Text = ""
            lblServicio.Visible = False
            cboServicio.Visible = False
            lblDiagnostico.Visible = False
            cboDiagnostico.Visible = False
            txtNombrePaciente.Text = ""
            txtNombrePaciente.Visible = False
            chkCama.Visible = False
            lblTipoSeparacion.Visible = False
            cboTipoSeparacion.Visible = False
            lblCama.Visible = False
            cboCama.Visible = False
            lblFactura.Visible = True
            txtFactura.Visible = True
            txtFactura.Text = ""
            lblNumIC.Visible = False
            txtNumIC.Visible = False
            lblConcepto1.Visible = True
            txtConcepto1.Visible = True
            txtConcepto1.Text = ""
            lblRFC.Visible = True
            txtRFC.Visible = True
            txtRFC.Text = ""
            lblUsuario.Visible = True
            txtUsuario.Visible = True
            txtUsuario.Text = ""
            cboOpcion.Visible = False
            lblOpcion.Visible = False
            txtExpediente.Visible = False
            cboCaja.Visible = False
            txtTicket.Visible = False
            txtImporte.Visible = True
            txtImporte.Text = ""
            cboNSE.Visible = False
            txtAnticipo.Visible = False
            dtpFecha1.Visible = True
            dtpFecha2.Visible = False
            lblExpediente.Visible = False
            lblCaja.Visible = False
            lblTicket.Visible = False
            lblImporte.Visible = True
            lblNSE.Visible = False
            lblAnticipo.Visible = False
            lblFecha1.Visible = True
            lblFecha1.Text = "Fecha"
            lblFecha2.Visible = False
            lblProcedimiento.Visible = False
            cboProcedimiento.Visible = False
            lbltotal.Visible = False

        ElseIf cboSoporte.SelectedValue = 5 Or cboSoporte.SelectedValue = 8 Or cboSoporte.SelectedValue = 9 Then
            lblTipoCaja.Visible = False
            cboTipoCaja.Visible = False
            lblUsuarioTicket0.Visible = False
            txtUsuarioTicket0.Visible = False
            lblUsuario2.Visible = False
            txtUsuario2.Visible = False
            txtUsuario2.Text = ""
            lblServicio.Visible = False
            cboServicio.Visible = False
            lblDiagnostico.Visible = False
            cboDiagnostico.Visible = False
            txtNombrePaciente.Text = ""
            txtNombrePaciente.Visible = True
            chkCama.Visible = False
            lblTipoSeparacion.Visible = False
            cboTipoSeparacion.Visible = False
            lblCama.Visible = False
            cboCama.Visible = False
            lblFactura.Visible = False
            txtFactura.Visible = False
            lblNumIC.Visible = False
            txtNumIC.Visible = False
            lblConcepto1.Visible = False
            txtConcepto1.Visible = False
            lblRFC.Visible = False
            txtRFC.Visible = False
            lblUsuario.Visible = False
            txtUsuario.Visible = False
            cboOpcion.Visible = False
            lblOpcion.Visible = False
            txtExpediente.Visible = True
            txtExpediente.Text = ""
            cboCaja.Visible = False
            txtTicket.Visible = False
            txtImporte.Visible = True
            txtImporte.Text = ""
            cboNSE.Visible = False
            txtAnticipo.Visible = True
            txtAnticipo.Text = ""
            dtpFecha1.Visible = True
            lblFecha1.Text = "Fecha"
            dtpFecha2.Visible = False
            lblExpediente.Visible = True
            lblCaja.Visible = False
            lblTicket.Visible = False
            lblImporte.Visible = True
            lblNSE.Visible = False
            lblAnticipo.Visible = True
            lblFecha1.Visible = True
            lblFecha2.Visible = False
            lblProcedimiento.Visible = False
            cboProcedimiento.Visible = False
            lbltotal.Visible = False

        ElseIf cboSoporte.SelectedValue = 6 Then
            lblTipoCaja.Visible = False
            cboTipoCaja.Visible = False
            lblUsuarioTicket0.Visible = False
            txtUsuarioTicket0.Visible = False
            lblUsuario2.Visible = False
            txtUsuario2.Visible = False
            txtUsuario2.Text = ""
            lblServicio.Visible = False
            cboServicio.Visible = False
            lblDiagnostico.Visible = False
            cboDiagnostico.Visible = False
            txtNombrePaciente.Text = ""
            txtNombrePaciente.Visible = True
            chkCama.Visible = False
            lblTipoSeparacion.Visible = False
            cboTipoSeparacion.Visible = False
            lblCama.Visible = False
            cboCama.Visible = False
            lblFactura.Visible = False
            txtFactura.Visible = False
            lblNumIC.Visible = True
            txtNumIC.Visible = True
            txtNumIC.Text = ""
            lblConcepto1.Visible = False
            txtConcepto1.Visible = False
            lblRFC.Visible = False
            txtRFC.Visible = False
            lblUsuario.Visible = False
            txtUsuario.Visible = False
            cboOpcion.Visible = False
            lblOpcion.Visible = False
            txtExpediente.Visible = True
            txtExpediente.Text = ""
            cboCaja.Visible = False
            txtTicket.Visible = False
            txtImporte.Visible = False
            cboNSE.Visible = False
            txtAnticipo.Visible = False
            dtpFecha1.Visible = True
            dtpFecha2.Visible = False
            lblExpediente.Visible = True
            lblCaja.Visible = False
            lblTicket.Visible = False
            lblImporte.Visible = False
            lblNSE.Visible = False
            lblAnticipo.Visible = False
            lblFecha1.Visible = True
            lblFecha1.Text = "Fecha"
            lblFecha2.Visible = False
            lblProcedimiento.Visible = False
            cboProcedimiento.Visible = False
            lbltotal.Visible = False

        ElseIf cboSoporte.SelectedValue = 10 Then
            lblTipoCaja.Visible = False
            cboTipoCaja.Visible = False
            lblUsuarioTicket0.Visible = False
            txtUsuarioTicket0.Visible = False
            lblUsuario2.Visible = False
            txtUsuario2.Visible = False
            txtUsuario2.Text = ""
            lblServicio.Visible = False
            cboServicio.Visible = False
            lblDiagnostico.Visible = False
            cboDiagnostico.Visible = False
            txtNombrePaciente.Text = ""
            txtNombrePaciente.Visible = False
            chkCama.Visible = False
            lblTipoSeparacion.Visible = False
            cboTipoSeparacion.Visible = False
            lblCama.Visible = False
            cboCama.Visible = False
            lblFactura.Visible = False
            txtFactura.Visible = False
            lblNumIC.Visible = False
            txtNumIC.Visible = False
            lblConcepto1.Visible = False
            txtConcepto1.Visible = False
            lblRFC.Visible = False
            txtRFC.Visible = False
            lblUsuario.Visible = False
            txtUsuario.Visible = False
            cboOpcion.Visible = False
            lblOpcion.Visible = False
            txtExpediente.Visible = False
            cboCaja.Visible = False
            txtTicket.Visible = False
            txtImporte.Visible = False
            cboNSE.Visible = True
            cboNSE.Text = ""
            txtAnticipo.Visible = False
            dtpFecha1.Visible = False
            dtpFecha2.Visible = False
            lblExpediente.Visible = False
            lblCaja.Visible = False
            lblTicket.Visible = False
            lblImporte.Visible = False
            lblNSE.Visible = True
            lblAnticipo.Visible = False
            lblFecha1.Visible = False
            lblFecha2.Visible = False
            lblProcedimiento.Visible = True
            cboProcedimiento.Visible = True
            cboProcedimiento.Text = ""
            lbltotal.Visible = True
            lbltotal.Text = ""

        ElseIf cboSoporte.SelectedValue = 11 Then
            lblTipoCaja.Visible = False
            cboTipoCaja.Visible = False
            lblUsuarioTicket0.Visible = False
            txtUsuarioTicket0.Visible = False
            lblUsuario2.Visible = False
            txtUsuario2.Visible = False
            txtUsuario2.Text = ""
            lblServicio.Visible = False
            cboServicio.Visible = False
            lblDiagnostico.Visible = False
            cboDiagnostico.Visible = False
            txtNombrePaciente.Text = ""
            txtNombrePaciente.Visible = True
            chkCama.Visible = True
            lblTipoSeparacion.Visible = False
            cboTipoSeparacion.Visible = False
            cboTipoSeparacion.Text = ""
            lblCama.Visible = True
            cboCama.Visible = True
            cboCama.Text = ""
            cboCama.Enabled = False
            lblFactura.Visible = False
            txtFactura.Visible = False
            lblNumIC.Visible = False
            txtNumIC.Visible = False
            lblConcepto1.Visible = False
            txtConcepto1.Visible = False
            lblRFC.Visible = False
            txtRFC.Visible = False
            lblUsuario.Visible = False
            txtUsuario.Visible = False
            cboOpcion.Visible = False
            lblOpcion.Visible = False
            txtExpediente.Visible = True
            txtExpediente.Text = ""
            cboCaja.Visible = False
            txtTicket.Visible = False
            txtImporte.Visible = False
            cboNSE.Visible = False
            txtAnticipo.Visible = False
            dtpFecha1.Visible = False
            dtpFecha2.Visible = False
            lblExpediente.Visible = True
            lblCaja.Visible = False
            lblTicket.Visible = False
            lblImporte.Visible = False
            lblNSE.Visible = False
            lblAnticipo.Visible = False
            lblFecha1.Visible = False
            lblFecha2.Visible = False
            lblProcedimiento.Visible = False
            cboProcedimiento.Visible = False
            lbltotal.Visible = False

        ElseIf cboSoporte.SelectedValue = 12 Then
            lblTipoCaja.Visible = True
            cboTipoCaja.Visible = True
            lblUsuarioTicket0.Visible = True
            txtUsuarioTicket0.Visible = True
            lblUsuario2.Visible = False
            txtUsuario2.Visible = False
            txtUsuario2.Text = ""
            lblServicio.Visible = False
            cboServicio.Visible = False
            lblDiagnostico.Visible = False
            cboDiagnostico.Visible = False
            txtNombrePaciente.Text = ""
            txtNombrePaciente.Visible = True
            chkCama.Visible = False
            lblTipoSeparacion.Visible = False
            cboTipoSeparacion.Visible = False
            lblCama.Visible = False
            cboCama.Visible = False
            lblFactura.Visible = False
            txtFactura.Visible = False
            lblNumIC.Visible = False
            txtNumIC.Visible = False
            lblConcepto1.Visible = False
            txtConcepto1.Visible = False
            lblRFC.Visible = False
            txtRFC.Visible = False
            lblUsuario.Visible = False
            txtUsuario.Visible = False
            cboOpcion.Visible = False
            lblOpcion.Visible = False
            txtExpediente.Visible = True
            txtExpediente.Text = ""
            cboCaja.Visible = False
            txtTicket.Visible = False
            txtImporte.Visible = False
            cboNSE.Visible = True
            cboNSE.Text = ""
            txtAnticipo.Visible = False
            dtpFecha1.Visible = True
            dtpFecha2.Visible = True
            lblExpediente.Visible = True
            lblCaja.Visible = False
            lblTicket.Visible = False
            lblImporte.Visible = False
            lblNSE.Visible = True
            lblAnticipo.Visible = False
            lblFecha1.Visible = True
            lblFecha1.Text = "Fecha inicial"
            lblFecha2.Visible = True
            lblProcedimiento.Visible = False
            cboProcedimiento.Visible = False
            cboProcedimiento.Text = ""
            lbltotal.Visible = False

        ElseIf cboSoporte.SelectedValue = 13 Then
            lblTipoCaja.Visible = False
            cboTipoCaja.Visible = False
            lblUsuarioTicket0.Visible = False
            txtUsuarioTicket0.Visible = False
            lblUsuario2.Visible = False
            txtUsuario2.Visible = False
            txtUsuario2.Text = ""
            lblServicio.Visible = False
            cboServicio.Visible = False
            lblDiagnostico.Visible = False
            cboDiagnostico.Visible = False
            txtNombrePaciente.Text = ""
            txtNombrePaciente.Visible = True
            chkCama.Visible = False
            lblTipoSeparacion.Visible = False
            cboTipoSeparacion.Visible = False
            lblCama.Visible = False
            cboCama.Visible = False
            cboOpcion.Items.Clear()
            cboOpcion.Items.Add("Cambios de pacientes en COE o en Cancer de pulmón.")
            cboOpcion.Items.Add("Cambios realizados en el paciente.")
            cboOpcion.Items.Add("Cambios realizados en pacientes de protocolo.")
            cboOpcion.Items.Add("Cambios realizado en pacientes de seguro popular.")
            cboOpcion.Items.Add("Cambio en paciente subrogados.")
            lblFactura.Visible = False
            txtFactura.Visible = False
            lblNumIC.Visible = False
            txtNumIC.Visible = False
            lblConcepto1.Visible = False
            txtConcepto1.Visible = False
            lblRFC.Visible = False
            txtRFC.Visible = False
            lblUsuario.Visible = False
            txtUsuario.Visible = False
            cboOpcion.Visible = True
            cboOpcion.Text = ""
            lblOpcion.Visible = True
            txtExpediente.Visible = True
            txtExpediente.Text = ""
            cboCaja.Visible = False
            txtTicket.Visible = False
            txtImporte.Visible = False
            cboNSE.Visible = False
            txtAnticipo.Visible = False
            dtpFecha1.Visible = False
            dtpFecha2.Visible = False
            lblExpediente.Visible = True
            lblCaja.Visible = False
            lblTicket.Visible = False
            lblImporte.Visible = False
            lblNSE.Visible = False
            lblAnticipo.Visible = False
            lblFecha1.Visible = False
            lblFecha2.Visible = False
            lblProcedimiento.Visible = False
            cboProcedimiento.Visible = False
            lbltotal.Visible = False

        ElseIf cboSoporte.SelectedValue = 14 Then
            lblTipoCaja.Visible = False
            cboTipoCaja.Visible = False
            lblUsuarioTicket0.Visible = False
            txtUsuarioTicket0.Visible = False
            lblUsuario2.Visible = False
            txtUsuario2.Visible = False
            txtUsuario2.Text = ""
            lblServicio.Visible = False
            cboServicio.Visible = False
            lblDiagnostico.Visible = False
            cboDiagnostico.Visible = False
            txtNombrePaciente.Text = ""
            txtNombrePaciente.Visible = True
            chkCama.Visible = False
            lblTipoSeparacion.Visible = False
            cboTipoSeparacion.Visible = False
            lblCama.Visible = False
            cboCama.Visible = False
            lblFactura.Visible = False
            txtFactura.Visible = False
            lblNumIC.Visible = True
            txtNumIC.Visible = True
            txtNumIC.Text = ""
            lblConcepto1.Visible = False
            txtConcepto1.Visible = False
            lblRFC.Visible = False
            txtRFC.Visible = False
            lblUsuario.Visible = False
            txtUsuario.Visible = False
            cboOpcion.Visible = False
            lblOpcion.Visible = False
            txtExpediente.Visible = True
            txtExpediente.Text = ""
            cboCaja.Visible = False
            txtTicket.Visible = False
            txtImporte.Visible = False
            cboNSE.Visible = False
            txtAnticipo.Visible = False
            dtpFecha1.Visible = False
            dtpFecha2.Visible = False
            lblExpediente.Visible = True
            lblCaja.Visible = False
            lblTicket.Visible = False
            lblImporte.Visible = False
            lblNSE.Visible = False
            lblAnticipo.Visible = False
            lblFecha1.Visible = False
            lblFecha2.Visible = False
            lblProcedimiento.Visible = False
            cboProcedimiento.Visible = False
            lbltotal.Visible = False

        ElseIf cboSoporte.SelectedValue = 15 Or cboSoporte.SelectedValue = 16 Then
            lblTipoCaja.Visible = False
            cboTipoCaja.Visible = False
            lblUsuarioTicket0.Visible = True
            txtUsuarioTicket0.Visible = True
            lblUsuario2.Visible = False
            txtUsuario2.Visible = False
            txtUsuario2.Text = ""
            lblServicio.Visible = False
            cboServicio.Visible = False
            lblDiagnostico.Visible = False
            cboDiagnostico.Visible = False
            txtNombrePaciente.Text = ""
            txtNombrePaciente.Visible = True
            chkCama.Visible = False
            lblTipoSeparacion.Visible = True
            cboTipoSeparacion.Visible = True
            cboTipoSeparacion.Text = ""
            cboTipoSeparacion.Items.Clear()
            cboTipoSeparacion.Items.Add("Seguro popular.")
            cboTipoSeparacion.Items.Add("Protocolo.")
            cboTipoSeparacion.Items.Add("Subrogados.")
            cboTipoSeparacion.Items.Add("Paciente.")
            lblCama.Visible = False
            cboCama.Visible = False
            lblFactura.Visible = False
            txtFactura.Visible = False
            lblNumIC.Visible = False
            txtNumIC.Visible = False
            lblConcepto1.Visible = False
            txtConcepto1.Visible = False
            lblRFC.Visible = False
            txtRFC.Visible = False
            lblUsuario.Visible = False
            txtUsuario.Visible = False
            cboOpcion.Visible = False
            lblOpcion.Visible = False
            txtExpediente.Visible = True
            txtExpediente.Text = ""
            cboCaja.Visible = False
            txtTicket.Visible = False
            txtImporte.Visible = False
            cboNSE.Visible = True
            cboNSE.Text = ""
            txtAnticipo.Visible = False
            dtpFecha1.Visible = True
            dtpFecha2.Visible = True
            lblExpediente.Visible = True
            lblCaja.Visible = False
            lblTicket.Visible = False
            lblImporte.Visible = False
            lblNSE.Visible = True
            lblAnticipo.Visible = False
            lblFecha1.Visible = True
            lblFecha1.Text = "Fecha inicial"
            lblFecha2.Visible = True
            lblProcedimiento.Visible = False
            cboProcedimiento.Visible = False
            lbltotal.Visible = False

        ElseIf cboSoporte.SelectedValue = 17 Then
            lblTipoCaja.Visible = False
            cboTipoCaja.Visible = False
            lblUsuarioTicket0.Visible = True
            txtUsuarioTicket0.Visible = True
            lblUsuario2.Visible = False
            txtUsuario2.Visible = False
            txtUsuario2.Text = ""
            lblServicio.Visible = False
            cboServicio.Visible = False
            lblDiagnostico.Visible = False
            cboDiagnostico.Visible = False
            txtNombrePaciente.Text = ""
            txtNombrePaciente.Visible = True
            chkCama.Visible = False
            lblTipoSeparacion.Visible = False
            cboTipoSeparacion.Visible = False
            lblCama.Visible = False
            cboCama.Visible = False
            lblFactura.Visible = False
            txtFactura.Visible = False
            lblNumIC.Visible = False
            txtNumIC.Visible = False
            lblConcepto1.Visible = False
            txtConcepto1.Visible = False
            lblRFC.Visible = False
            txtRFC.Visible = False
            lblUsuario.Visible = False
            txtUsuario.Visible = False
            cboOpcion.Visible = False
            lblOpcion.Visible = False
            txtExpediente.Visible = True
            txtExpediente.Text = ""
            cboCaja.Visible = True
            cboCaja.Text = ""
            txtTicket.Visible = True
            txtTicket.Text = ""
            txtImporte.Visible = False
            cboNSE.Visible = False
            txtAnticipo.Visible = False
            dtpFecha1.Visible = False
            dtpFecha2.Visible = False
            lblExpediente.Visible = True
            lblCaja.Visible = True
            lblTicket.Visible = True
            lblImporte.Visible = False
            lblNSE.Visible = False
            lblAnticipo.Visible = False
            lblFecha1.Visible = False
            lblFecha2.Visible = False
            lblProcedimiento.Visible = False
            cboProcedimiento.Visible = False
            lbltotal.Visible = False

        ElseIf cboSoporte.SelectedValue = 18 Then
            lblTipoCaja.Visible = False
            cboTipoCaja.Visible = False
            lblUsuarioTicket0.Visible = False
            txtUsuarioTicket0.Visible = False
            lblUsuario2.Visible = True
            txtUsuario2.Visible = True
            txtUsuario2.Text = ""
            lblServicio.Visible = True
            cboServicio.Visible = True
            lblDiagnostico.Visible = True
            cboDiagnostico.Visible = True
            txtNombrePaciente.Text = ""
            txtNombrePaciente.Visible = True
            chkCama.Visible = False
            lblTipoSeparacion.Visible = False
            cboTipoSeparacion.Visible = False
            lblCama.Visible = False
            cboCama.Visible = False
            lblFactura.Visible = False
            txtFactura.Visible = False
            lblNumIC.Visible = False
            txtNumIC.Visible = False
            lblConcepto1.Visible = False
            txtConcepto1.Visible = False
            lblRFC.Visible = False
            txtRFC.Visible = False
            lblUsuario.Visible = False
            txtUsuario.Visible = False
            cboOpcion.Visible = False
            lblOpcion.Visible = False
            txtExpediente.Visible = True
            txtExpediente.Text = ""
            cboCaja.Visible = False
            cboCaja.Text = ""
            txtTicket.Visible = False
            txtTicket.Text = ""
            txtImporte.Visible = False
            cboNSE.Visible = False
            txtAnticipo.Visible = False
            dtpFecha1.Visible = False
            dtpFecha2.Visible = False
            lblExpediente.Visible = True
            lblCaja.Visible = False
            lblTicket.Visible = False
            lblImporte.Visible = False
            lblNSE.Visible = False
            lblAnticipo.Visible = False
            lblFecha1.Visible = False
            lblFecha2.Visible = False
            lblProcedimiento.Visible = False
            cboProcedimiento.Visible = False
            lbltotal.Visible = False
        End If
    End Sub

    Private Sub chkCama_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkCama.CheckedChanged
        If chkCama.Checked Then
            txtExpediente.Text = ""
            cboCama.Enabled = True
            cboCama.Text = ""
            txtExpediente.Enabled = False
        Else
            cboCama.Enabled = False
            txtExpediente.Enabled = True
            txtExpediente.Text = ""
            txtExpediente.Focus()
        End If

    End Sub

    Private Sub cboTipoSeparacion_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboTipoSeparacion.SelectionChangeCommitted

        Dim Conexion As New lbrConexion.ValConexion

        If cboTipoSeparacion.SelectedIndex = 0 Then
            cboNSE.SelectedIndex = 7
        End If
        If cboTipoSeparacion.SelectedIndex = 1 Then
            cboNSE.SelectedIndex = -1
        End If
        If cboTipoSeparacion.SelectedIndex = 2 Then
            cboNSE.SelectedIndex = 8
        End If
        If cboTipoSeparacion.SelectedIndex = 3 Then
            cboNSE.SelectedValue = Conexion.loadNSEPaciente(txtExpediente.Text)
        End If
    End Sub

    Private Sub cboProcedimiento_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboProcedimiento.SelectionChangeCommitted
        lbltotal.Text = ""
    End Sub

    Private Sub cboNSE_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboNSE.SelectionChangeCommitted
        lbltotal.Text = ""
    End Sub

    Private Sub txtExpediente_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtExpediente.TextChanged
        Dim Conexion As New lbrConexion.ValConexion
        If (txtExpediente.TextLength = 9) Then
            Dim dt As DataTable
            dt = Conexion.obtenerPaciente(txtExpediente.Text)
            If (dt.Rows.Count > 0) Then
                txtNombrePaciente.Text = (dt.Rows.Item(0)!eicapetnapellidopaterno) + " " + (dt.Rows.Item(0)!eicapetnapellidomaterno) + " " + (dt.Rows.Item(0)!eicapetnnombre)
                ''''''''
                If cboSoporte.SelectedValue = 15 Or cboSoporte.SelectedValue = 16 Then
                    If cboTipoSeparacion.SelectedIndex = 3 Then
                        cboNSE.SelectedValue = Conexion.loadNSEPaciente(txtExpediente.Text)
                    End If
                End If

                If cboSoporte.SelectedValue = 18 Then
                    If Conexion.existExpedienteSP(txtExpediente.Text) Then
                        cboServicio.SelectedValue = Conexion.getServicio(txtExpediente.Text)

                        Dim dtDiagnostico As New DataTable
                        dtDiagnostico = Conexion.loadDiagnosticos(cboServicio.SelectedValue)
                        With cboDiagnostico
                            .DisplayMember = "ngaidcitsougesopoporraludescripcion"
                            .ValueMember = "ngaidcitsougesopoporraluid"
                            .DataSource = dtDiagnostico
                            .SelectedIndex = -1
                        End With

                        cboDiagnostico.SelectedValue = Conexion.getDiagnostico(txtExpediente.Text)
                    Else
                        MessageBox.Show("El paciente no está en Seguro Popular")
                        cboServicio.SelectedIndex = -1
                        cboDiagnostico.SelectedIndex = -1
                    End If
                    'Fin de llenado de campos
                End If
            Else
                txtNombrePaciente.Text = "No existe algún paciente con ese Expediente"
                cboServicio.SelectedIndex = -1
                cboDiagnostico.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub cboServicio_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboServicio.SelectionChangeCommitted

        Dim Conexion As New lbrConexion.ValConexion

        Dim dtDiagnostico As New DataTable
        dtDiagnostico = Conexion.loadDiagnosticos(cboServicio.SelectedValue)
        With cboDiagnostico
            .DisplayMember = "ngaidcitsougesopoporraludescripcion"
            .ValueMember = "ngaidcitsougesopoporraluid"
            .DataSource = dtDiagnostico
            .SelectedIndex = -1
        End With
    End Sub

End Class