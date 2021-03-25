<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Interfaz
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdEjecutar = New System.Windows.Forms.Button()
        Me.txtExpediente = New System.Windows.Forms.TextBox()
        Me.lblExpediente = New System.Windows.Forms.Label()
        Me.lblCaja = New System.Windows.Forms.Label()
        Me.lblTicket = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.lblImporte = New System.Windows.Forms.Label()
        Me.txtTicket = New System.Windows.Forms.TextBox()
        Me.lblNSE = New System.Windows.Forms.Label()
        Me.txtAnticipo = New System.Windows.Forms.TextBox()
        Me.lblAnticipo = New System.Windows.Forms.Label()
        Me.lblFecha1 = New System.Windows.Forms.Label()
        Me.lblFecha2 = New System.Windows.Forms.Label()
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.cboSoporte = New System.Windows.Forms.ComboBox()
        Me.lblSoporte = New System.Windows.Forms.Label()
        Me.cboCaja = New System.Windows.Forms.ComboBox()
        Me.cboNSE = New System.Windows.Forms.ComboBox()
        Me.cboProcedimiento = New System.Windows.Forms.ComboBox()
        Me.lblProcedimiento = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblOpcion = New System.Windows.Forms.Label()
        Me.cboOpcion = New System.Windows.Forms.ComboBox()
        Me.lblConcepto1 = New System.Windows.Forms.Label()
        Me.lblRFC = New System.Windows.Forms.Label()
        Me.txtConcepto1 = New System.Windows.Forms.TextBox()
        Me.txtRFC = New System.Windows.Forms.TextBox()
        Me.lblNumIC = New System.Windows.Forms.Label()
        Me.txtNumIC = New System.Windows.Forms.TextBox()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.lblFactura = New System.Windows.Forms.Label()
        Me.lblCama = New System.Windows.Forms.Label()
        Me.cboCama = New System.Windows.Forms.ComboBox()
        Me.cboTipoSeparacion = New System.Windows.Forms.ComboBox()
        Me.lblTipoSeparacion = New System.Windows.Forms.Label()
        Me.chkCama = New System.Windows.Forms.CheckBox()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.cboServicio = New System.Windows.Forms.ComboBox()
        Me.cboDiagnostico = New System.Windows.Forms.ComboBox()
        Me.lblDiagnostico = New System.Windows.Forms.Label()
        Me.lblServicio = New System.Windows.Forms.Label()
        Me.lblUsuario2 = New System.Windows.Forms.Label()
        Me.txtUsuario2 = New System.Windows.Forms.TextBox()
        Me.lblBase = New System.Windows.Forms.Label()
        Me.txtUsuarioTicket0 = New System.Windows.Forms.TextBox()
        Me.lblUsuarioTicket0 = New System.Windows.Forms.Label()
        Me.lblTipoCaja = New System.Windows.Forms.Label()
        Me.cboTipoCaja = New System.Windows.Forms.ComboBox()
        Me.txtNombrePaciente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdEjecutar
        '
        Me.cmdEjecutar.Location = New System.Drawing.Point(434, 250)
        Me.cmdEjecutar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdEjecutar.Name = "cmdEjecutar"
        Me.cmdEjecutar.Size = New System.Drawing.Size(137, 42)
        Me.cmdEjecutar.TabIndex = 0
        Me.cmdEjecutar.Text = "Ejecutar"
        Me.cmdEjecutar.UseVisualStyleBackColor = True
        '
        'txtExpediente
        '
        Me.txtExpediente.Location = New System.Drawing.Point(176, 84)
        Me.txtExpediente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtExpediente.MaxLength = 9
        Me.txtExpediente.Name = "txtExpediente"
        Me.txtExpediente.Size = New System.Drawing.Size(270, 26)
        Me.txtExpediente.TabIndex = 1
        '
        'lblExpediente
        '
        Me.lblExpediente.AutoSize = True
        Me.lblExpediente.Location = New System.Drawing.Point(85, 86)
        Me.lblExpediente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExpediente.Name = "lblExpediente"
        Me.lblExpediente.Size = New System.Drawing.Size(89, 20)
        Me.lblExpediente.TabIndex = 2
        Me.lblExpediente.Text = "Expediente"
        '
        'lblCaja
        '
        Me.lblCaja.AutoSize = True
        Me.lblCaja.Location = New System.Drawing.Point(547, 86)
        Me.lblCaja.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCaja.Name = "lblCaja"
        Me.lblCaja.Size = New System.Drawing.Size(41, 20)
        Me.lblCaja.TabIndex = 4
        Me.lblCaja.Text = "Caja"
        '
        'lblTicket
        '
        Me.lblTicket.AutoSize = True
        Me.lblTicket.Location = New System.Drawing.Point(40, 124)
        Me.lblTicket.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTicket.Name = "lblTicket"
        Me.lblTicket.Size = New System.Drawing.Size(133, 20)
        Me.lblTicket.TabIndex = 8
        Me.lblTicket.Text = "Número de Ticket"
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(177, 120)
        Me.txtImporte.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(268, 26)
        Me.txtImporte.TabIndex = 7
        '
        'lblImporte
        '
        Me.lblImporte.AutoSize = True
        Me.lblImporte.Location = New System.Drawing.Point(109, 123)
        Me.lblImporte.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(64, 20)
        Me.lblImporte.TabIndex = 6
        Me.lblImporte.Text = "Importe"
        '
        'txtTicket
        '
        Me.txtTicket.Location = New System.Drawing.Point(176, 121)
        Me.txtTicket.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTicket.Name = "txtTicket"
        Me.txtTicket.Size = New System.Drawing.Size(233, 26)
        Me.txtTicket.TabIndex = 5
        '
        'lblNSE
        '
        Me.lblNSE.AutoSize = True
        Me.lblNSE.Location = New System.Drawing.Point(11, 124)
        Me.lblNSE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNSE.Name = "lblNSE"
        Me.lblNSE.Size = New System.Drawing.Size(163, 20)
        Me.lblNSE.TabIndex = 12
        Me.lblNSE.Text = "Nivel Socioeconómico"
        '
        'txtAnticipo
        '
        Me.txtAnticipo.Location = New System.Drawing.Point(607, 121)
        Me.txtAnticipo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAnticipo.Name = "txtAnticipo"
        Me.txtAnticipo.Size = New System.Drawing.Size(261, 26)
        Me.txtAnticipo.TabIndex = 11
        '
        'lblAnticipo
        '
        Me.lblAnticipo.AutoSize = True
        Me.lblAnticipo.Location = New System.Drawing.Point(457, 127)
        Me.lblAnticipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAnticipo.Name = "lblAnticipo"
        Me.lblAnticipo.Size = New System.Drawing.Size(148, 20)
        Me.lblAnticipo.TabIndex = 10
        Me.lblAnticipo.Text = "Número de Anticipo"
        '
        'lblFecha1
        '
        Me.lblFecha1.AutoSize = True
        Me.lblFecha1.Location = New System.Drawing.Point(512, 87)
        Me.lblFecha1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFecha1.Name = "lblFecha1"
        Me.lblFecha1.Size = New System.Drawing.Size(96, 20)
        Me.lblFecha1.TabIndex = 16
        Me.lblFecha1.Text = "Fecha inicial"
        Me.lblFecha1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFecha2
        '
        Me.lblFecha2.AutoSize = True
        Me.lblFecha2.Location = New System.Drawing.Point(517, 128)
        Me.lblFecha2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFecha2.Name = "lblFecha2"
        Me.lblFecha2.Size = New System.Drawing.Size(87, 20)
        Me.lblFecha2.TabIndex = 14
        Me.lblFecha2.Text = "Fecha final"
        '
        'dtpFecha1
        '
        Me.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha1.Location = New System.Drawing.Point(607, 85)
        Me.dtpFecha1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(213, 26)
        Me.dtpFecha1.TabIndex = 17
        Me.dtpFecha1.TabStop = False
        '
        'dtpFecha2
        '
        Me.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha2.Location = New System.Drawing.Point(607, 121)
        Me.dtpFecha2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(174, 26)
        Me.dtpFecha2.TabIndex = 18
        Me.dtpFecha2.TabStop = False
        '
        'cboSoporte
        '
        Me.cboSoporte.FormattingEnabled = True
        Me.cboSoporte.Location = New System.Drawing.Point(170, 13)
        Me.cboSoporte.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboSoporte.Name = "cboSoporte"
        Me.cboSoporte.Size = New System.Drawing.Size(690, 28)
        Me.cboSoporte.TabIndex = 19
        '
        'lblSoporte
        '
        Me.lblSoporte.AutoSize = True
        Me.lblSoporte.Location = New System.Drawing.Point(88, 16)
        Me.lblSoporte.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSoporte.Name = "lblSoporte"
        Me.lblSoporte.Size = New System.Drawing.Size(66, 20)
        Me.lblSoporte.TabIndex = 20
        Me.lblSoporte.Text = "Soporte"
        '
        'cboCaja
        '
        Me.cboCaja.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboCaja.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCaja.FormattingEnabled = True
        Me.cboCaja.Location = New System.Drawing.Point(606, 84)
        Me.cboCaja.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboCaja.Name = "cboCaja"
        Me.cboCaja.Size = New System.Drawing.Size(348, 26)
        Me.cboCaja.TabIndex = 21
        '
        'cboNSE
        '
        Me.cboNSE.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboNSE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboNSE.FormattingEnabled = True
        Me.cboNSE.Location = New System.Drawing.Point(176, 122)
        Me.cboNSE.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboNSE.Name = "cboNSE"
        Me.cboNSE.Size = New System.Drawing.Size(269, 28)
        Me.cboNSE.TabIndex = 22
        '
        'cboProcedimiento
        '
        Me.cboProcedimiento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboProcedimiento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProcedimiento.DropDownHeight = 200
        Me.cboProcedimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProcedimiento.FormattingEnabled = True
        Me.cboProcedimiento.IntegralHeight = False
        Me.cboProcedimiento.Location = New System.Drawing.Point(175, 84)
        Me.cboProcedimiento.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboProcedimiento.Name = "cboProcedimiento"
        Me.cboProcedimiento.Size = New System.Drawing.Size(768, 26)
        Me.cboProcedimiento.TabIndex = 26
        '
        'lblProcedimiento
        '
        Me.lblProcedimiento.AutoSize = True
        Me.lblProcedimiento.Location = New System.Drawing.Point(64, 87)
        Me.lblProcedimiento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProcedimiento.Name = "lblProcedimiento"
        Me.lblProcedimiento.Size = New System.Drawing.Size(110, 20)
        Me.lblProcedimiento.TabIndex = 25
        Me.lblProcedimiento.Text = "Procedimiento"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(110, 87)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(64, 20)
        Me.lblUsuario.TabIndex = 27
        Me.lblUsuario.Text = "Usuario"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(175, 85)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUsuario.MaxLength = 15
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(270, 26)
        Me.txtUsuario.TabIndex = 28
        '
        'lblOpcion
        '
        Me.lblOpcion.AutoSize = True
        Me.lblOpcion.Location = New System.Drawing.Point(114, 124)
        Me.lblOpcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOpcion.Name = "lblOpcion"
        Me.lblOpcion.Size = New System.Drawing.Size(59, 20)
        Me.lblOpcion.TabIndex = 29
        Me.lblOpcion.Text = "Opcion"
        '
        'cboOpcion
        '
        Me.cboOpcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOpcion.FormattingEnabled = True
        Me.cboOpcion.Location = New System.Drawing.Point(174, 123)
        Me.cboOpcion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboOpcion.Name = "cboOpcion"
        Me.cboOpcion.Size = New System.Drawing.Size(385, 26)
        Me.cboOpcion.TabIndex = 30
        '
        'lblConcepto1
        '
        Me.lblConcepto1.AutoSize = True
        Me.lblConcepto1.Location = New System.Drawing.Point(94, 163)
        Me.lblConcepto1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConcepto1.Name = "lblConcepto1"
        Me.lblConcepto1.Size = New System.Drawing.Size(78, 20)
        Me.lblConcepto1.TabIndex = 31
        Me.lblConcepto1.Text = "Concepto"
        '
        'lblRFC
        '
        Me.lblRFC.AutoSize = True
        Me.lblRFC.Location = New System.Drawing.Point(131, 199)
        Me.lblRFC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRFC.Name = "lblRFC"
        Me.lblRFC.Size = New System.Drawing.Size(42, 20)
        Me.lblRFC.TabIndex = 34
        Me.lblRFC.Text = "RFC"
        '
        'txtConcepto1
        '
        Me.txtConcepto1.Location = New System.Drawing.Point(175, 159)
        Me.txtConcepto1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtConcepto1.MaxLength = 90
        Me.txtConcepto1.Name = "txtConcepto1"
        Me.txtConcepto1.Size = New System.Drawing.Size(768, 26)
        Me.txtConcepto1.TabIndex = 35
        '
        'txtRFC
        '
        Me.txtRFC.Location = New System.Drawing.Point(175, 195)
        Me.txtRFC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(271, 26)
        Me.txtRFC.TabIndex = 38
        '
        'lblNumIC
        '
        Me.lblNumIC.AutoSize = True
        Me.lblNumIC.Location = New System.Drawing.Point(66, 123)
        Me.lblNumIC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumIC.Name = "lblNumIC"
        Me.lblNumIC.Size = New System.Drawing.Size(107, 20)
        Me.lblNumIC.TabIndex = 39
        Me.lblNumIC.Text = "Numero de IC"
        '
        'txtNumIC
        '
        Me.txtNumIC.Location = New System.Drawing.Point(175, 122)
        Me.txtNumIC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNumIC.Name = "txtNumIC"
        Me.txtNumIC.Size = New System.Drawing.Size(274, 26)
        Me.txtNumIC.TabIndex = 40
        '
        'txtFactura
        '
        Me.txtFactura.Location = New System.Drawing.Point(606, 121)
        Me.txtFactura.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(262, 26)
        Me.txtFactura.TabIndex = 41
        '
        'lblFactura
        '
        Me.lblFactura.AutoSize = True
        Me.lblFactura.Location = New System.Drawing.Point(480, 127)
        Me.lblFactura.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFactura.Name = "lblFactura"
        Me.lblFactura.Size = New System.Drawing.Size(124, 20)
        Me.lblFactura.TabIndex = 42
        Me.lblFactura.Text = "Folio de Factura"
        '
        'lblCama
        '
        Me.lblCama.AutoSize = True
        Me.lblCama.Location = New System.Drawing.Point(554, 86)
        Me.lblCama.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCama.Name = "lblCama"
        Me.lblCama.Size = New System.Drawing.Size(51, 20)
        Me.lblCama.TabIndex = 43
        Me.lblCama.Text = "Cama"
        '
        'cboCama
        '
        Me.cboCama.DropDownHeight = 200
        Me.cboCama.DropDownWidth = 20
        Me.cboCama.FormattingEnabled = True
        Me.cboCama.IntegralHeight = False
        Me.cboCama.ItemHeight = 20
        Me.cboCama.Location = New System.Drawing.Point(607, 83)
        Me.cboCama.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboCama.Name = "cboCama"
        Me.cboCama.Size = New System.Drawing.Size(329, 28)
        Me.cboCama.TabIndex = 44
        '
        'cboTipoSeparacion
        '
        Me.cboTipoSeparacion.FormattingEnabled = True
        Me.cboTipoSeparacion.Location = New System.Drawing.Point(174, 158)
        Me.cboTipoSeparacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboTipoSeparacion.Name = "cboTipoSeparacion"
        Me.cboTipoSeparacion.Size = New System.Drawing.Size(271, 28)
        Me.cboTipoSeparacion.TabIndex = 45
        '
        'lblTipoSeparacion
        '
        Me.lblTipoSeparacion.AutoSize = True
        Me.lblTipoSeparacion.Location = New System.Drawing.Point(27, 163)
        Me.lblTipoSeparacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipoSeparacion.Name = "lblTipoSeparacion"
        Me.lblTipoSeparacion.Size = New System.Drawing.Size(146, 20)
        Me.lblTipoSeparacion.TabIndex = 46
        Me.lblTipoSeparacion.Text = "Tipo de Separación"
        '
        'chkCama
        '
        Me.chkCama.AutoSize = True
        Me.chkCama.Location = New System.Drawing.Point(268, 121)
        Me.chkCama.Name = "chkCama"
        Me.chkCama.Size = New System.Drawing.Size(437, 24)
        Me.chkCama.TabIndex = 47
        Me.chkCama.Text = "Si desea liberar la cama directamente, habilite esta opción"
        Me.chkCama.UseVisualStyleBackColor = True
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(488, 122)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(72, 20)
        Me.lbltotal.TabIndex = 48
        Me.lbltotal.Text = "Importe: "
        '
        'cboServicio
        '
        Me.cboServicio.DropDownHeight = 150
        Me.cboServicio.DropDownWidth = 300
        Me.cboServicio.FormattingEnabled = True
        Me.cboServicio.IntegralHeight = False
        Me.cboServicio.Location = New System.Drawing.Point(176, 121)
        Me.cboServicio.Name = "cboServicio"
        Me.cboServicio.Size = New System.Drawing.Size(298, 28)
        Me.cboServicio.TabIndex = 50
        '
        'cboDiagnostico
        '
        Me.cboDiagnostico.DropDownWidth = 298
        Me.cboDiagnostico.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.cboDiagnostico.FormattingEnabled = True
        Me.cboDiagnostico.IntegralHeight = False
        Me.cboDiagnostico.Location = New System.Drawing.Point(594, 121)
        Me.cboDiagnostico.Name = "cboDiagnostico"
        Me.cboDiagnostico.Size = New System.Drawing.Size(349, 26)
        Me.cboDiagnostico.TabIndex = 51
        '
        'lblDiagnostico
        '
        Me.lblDiagnostico.AutoSize = True
        Me.lblDiagnostico.Location = New System.Drawing.Point(495, 121)
        Me.lblDiagnostico.Name = "lblDiagnostico"
        Me.lblDiagnostico.Size = New System.Drawing.Size(93, 20)
        Me.lblDiagnostico.TabIndex = 52
        Me.lblDiagnostico.Text = "Diagnóstico"
        '
        'lblServicio
        '
        Me.lblServicio.AutoSize = True
        Me.lblServicio.Location = New System.Drawing.Point(105, 124)
        Me.lblServicio.Name = "lblServicio"
        Me.lblServicio.Size = New System.Drawing.Size(64, 20)
        Me.lblServicio.TabIndex = 53
        Me.lblServicio.Text = "Servicio"
        '
        'lblUsuario2
        '
        Me.lblUsuario2.AutoSize = True
        Me.lblUsuario2.Location = New System.Drawing.Point(535, 87)
        Me.lblUsuario2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuario2.Name = "lblUsuario2"
        Me.lblUsuario2.Size = New System.Drawing.Size(64, 20)
        Me.lblUsuario2.TabIndex = 54
        Me.lblUsuario2.Text = "Usuario"
        '
        'txtUsuario2
        '
        Me.txtUsuario2.Location = New System.Drawing.Point(616, 84)
        Me.txtUsuario2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUsuario2.MaxLength = 15
        Me.txtUsuario2.Name = "txtUsuario2"
        Me.txtUsuario2.Size = New System.Drawing.Size(327, 26)
        Me.txtUsuario2.TabIndex = 55
        '
        'lblBase
        '
        Me.lblBase.AutoSize = True
        Me.lblBase.Location = New System.Drawing.Point(128, 298)
        Me.lblBase.Name = "lblBase"
        Me.lblBase.Size = New System.Drawing.Size(46, 20)
        Me.lblBase.TabIndex = 56
        Me.lblBase.Text = "Base"
        '
        'txtUsuarioTicket0
        '
        Me.txtUsuarioTicket0.Location = New System.Drawing.Point(607, 158)
        Me.txtUsuarioTicket0.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUsuarioTicket0.MaxLength = 15
        Me.txtUsuarioTicket0.Name = "txtUsuarioTicket0"
        Me.txtUsuarioTicket0.Size = New System.Drawing.Size(270, 26)
        Me.txtUsuarioTicket0.TabIndex = 58
        '
        'lblUsuarioTicket0
        '
        Me.lblUsuarioTicket0.AutoSize = True
        Me.lblUsuarioTicket0.Location = New System.Drawing.Point(535, 163)
        Me.lblUsuarioTicket0.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuarioTicket0.Name = "lblUsuarioTicket0"
        Me.lblUsuarioTicket0.Size = New System.Drawing.Size(64, 20)
        Me.lblUsuarioTicket0.TabIndex = 57
        Me.lblUsuarioTicket0.Text = "Usuario"
        '
        'lblTipoCaja
        '
        Me.lblTipoCaja.AutoSize = True
        Me.lblTipoCaja.Location = New System.Drawing.Point(70, 163)
        Me.lblTipoCaja.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipoCaja.Name = "lblTipoCaja"
        Me.lblTipoCaja.Size = New System.Drawing.Size(97, 20)
        Me.lblTipoCaja.TabIndex = 60
        Me.lblTipoCaja.Text = "Tipo de Caja"
        '
        'cboTipoCaja
        '
        Me.cboTipoCaja.FormattingEnabled = True
        Me.cboTipoCaja.Location = New System.Drawing.Point(174, 159)
        Me.cboTipoCaja.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboTipoCaja.Name = "cboTipoCaja"
        Me.cboTipoCaja.Size = New System.Drawing.Size(271, 28)
        Me.cboTipoCaja.TabIndex = 59
        '
        'txtNombrePaciente
        '
        Me.txtNombrePaciente.Location = New System.Drawing.Point(170, 50)
        Me.txtNombrePaciente.Name = "txtNombrePaciente"
        Me.txtNombrePaciente.Size = New System.Drawing.Size(784, 26)
        Me.txtNombrePaciente.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 20)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Base de datos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(260, 298)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "| Versión: "
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(346, 298)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(63, 20)
        Me.lblVersion.TabIndex = 64
        Me.lblVersion.Text = "Version"
        '
        'Interfaz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(985, 327)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombrePaciente)
        Me.Controls.Add(Me.lblTipoCaja)
        Me.Controls.Add(Me.cboTipoCaja)
        Me.Controls.Add(Me.txtUsuarioTicket0)
        Me.Controls.Add(Me.lblUsuarioTicket0)
        Me.Controls.Add(Me.lblBase)
        Me.Controls.Add(Me.lblServicio)
        Me.Controls.Add(Me.lblDiagnostico)
        Me.Controls.Add(Me.cboDiagnostico)
        Me.Controls.Add(Me.cboServicio)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.chkCama)
        Me.Controls.Add(Me.lblTipoSeparacion)
        Me.Controls.Add(Me.cboTipoSeparacion)
        Me.Controls.Add(Me.lblFactura)
        Me.Controls.Add(Me.txtFactura)
        Me.Controls.Add(Me.txtNumIC)
        Me.Controls.Add(Me.lblNumIC)
        Me.Controls.Add(Me.txtRFC)
        Me.Controls.Add(Me.txtConcepto1)
        Me.Controls.Add(Me.lblRFC)
        Me.Controls.Add(Me.lblConcepto1)
        Me.Controls.Add(Me.cboOpcion)
        Me.Controls.Add(Me.lblOpcion)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lblProcedimiento)
        Me.Controls.Add(Me.cboNSE)
        Me.Controls.Add(Me.cboCaja)
        Me.Controls.Add(Me.lblSoporte)
        Me.Controls.Add(Me.cboSoporte)
        Me.Controls.Add(Me.dtpFecha2)
        Me.Controls.Add(Me.dtpFecha1)
        Me.Controls.Add(Me.lblFecha2)
        Me.Controls.Add(Me.lblNSE)
        Me.Controls.Add(Me.txtAnticipo)
        Me.Controls.Add(Me.lblAnticipo)
        Me.Controls.Add(Me.lblTicket)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.lblImporte)
        Me.Controls.Add(Me.txtTicket)
        Me.Controls.Add(Me.lblCaja)
        Me.Controls.Add(Me.lblExpediente)
        Me.Controls.Add(Me.txtExpediente)
        Me.Controls.Add(Me.cmdEjecutar)
        Me.Controls.Add(Me.txtUsuario2)
        Me.Controls.Add(Me.cboProcedimiento)
        Me.Controls.Add(Me.cboCama)
        Me.Controls.Add(Me.lblUsuario2)
        Me.Controls.Add(Me.lblCama)
        Me.Controls.Add(Me.lblFecha1)
        Me.Controls.Add(Me.txtUsuario)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.MenuText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Interfaz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Soportes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdEjecutar As System.Windows.Forms.Button
    Friend WithEvents txtExpediente As System.Windows.Forms.TextBox
    Friend WithEvents lblExpediente As System.Windows.Forms.Label
    Friend WithEvents lblCaja As System.Windows.Forms.Label
    Friend WithEvents lblTicket As System.Windows.Forms.Label
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents lblImporte As System.Windows.Forms.Label
    Friend WithEvents txtTicket As System.Windows.Forms.TextBox
    Friend WithEvents lblNSE As System.Windows.Forms.Label
    Friend WithEvents txtAnticipo As System.Windows.Forms.TextBox
    Friend WithEvents lblAnticipo As System.Windows.Forms.Label
    Friend WithEvents lblFecha1 As System.Windows.Forms.Label
    Friend WithEvents lblFecha2 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboSoporte As System.Windows.Forms.ComboBox
    Friend WithEvents lblSoporte As System.Windows.Forms.Label
    Friend WithEvents cboCaja As System.Windows.Forms.ComboBox
    Friend WithEvents cboNSE As System.Windows.Forms.ComboBox
    Friend WithEvents cboProcedimiento As System.Windows.Forms.ComboBox
    Friend WithEvents lblProcedimiento As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblOpcion As System.Windows.Forms.Label
    Friend WithEvents cboOpcion As System.Windows.Forms.ComboBox
    Friend WithEvents lblConcepto1 As System.Windows.Forms.Label
    Friend WithEvents lblRFC As System.Windows.Forms.Label
    Friend WithEvents txtConcepto1 As System.Windows.Forms.TextBox
    Friend WithEvents txtRFC As System.Windows.Forms.TextBox
    Friend WithEvents lblNumIC As System.Windows.Forms.Label
    Friend WithEvents txtNumIC As System.Windows.Forms.TextBox
    Friend WithEvents txtFactura As System.Windows.Forms.TextBox
    Friend WithEvents lblFactura As System.Windows.Forms.Label
    Friend WithEvents lblCama As System.Windows.Forms.Label
    Friend WithEvents cboCama As System.Windows.Forms.ComboBox
    Friend WithEvents cboTipoSeparacion As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoSeparacion As System.Windows.Forms.Label
    Friend WithEvents chkCama As System.Windows.Forms.CheckBox
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents cboServicio As System.Windows.Forms.ComboBox
    Friend WithEvents cboDiagnostico As System.Windows.Forms.ComboBox
    Friend WithEvents lblDiagnostico As System.Windows.Forms.Label
    Friend WithEvents lblServicio As System.Windows.Forms.Label
    Friend WithEvents lblUsuario2 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario2 As System.Windows.Forms.TextBox
    Friend WithEvents lblBase As System.Windows.Forms.Label
    Friend WithEvents txtUsuarioTicket0 As System.Windows.Forms.TextBox
    Friend WithEvents lblUsuarioTicket0 As System.Windows.Forms.Label
    Friend WithEvents lblTipoCaja As System.Windows.Forms.Label
    Friend WithEvents cboTipoCaja As System.Windows.Forms.ComboBox
    Friend WithEvents txtNombrePaciente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label

End Class
