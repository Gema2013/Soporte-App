Public Class Soporte_CPyColonia

    Private _UsuarioActivo2 As Integer

    Public WriteOnly Property Propiedad() As Integer
        Set(ByVal value As Integer)
            _UsuarioActivo2 = value
        End Set
    End Property

    Dim Conexion As New lbrConexion.ValConexion
    Dim Negocios As New lbrNegocios.ValNegocios

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim dtEstado As New DataTable
        dtEstado = Conexion.loadEstados
        With ComboBox1
            .DisplayMember = "datseodescripcion"
            .ValueMember = "datseoid"
            .DataSource = dtEstado
            .SelectedIndex = -1
        End With

        ComboBox2.Enabled = False
        ComboBox3.Enabled = False
        ComboBox4.Enabled = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        CheckBox1.Visible = False
        CheckBox2.Visible = False


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectionChangeCommitted

        Dim dtDelegaciones As New DataTable
        dtDelegaciones = Conexion.loadDelegaciones(ComboBox1.SelectedValue)
        With ComboBox2
            .DisplayMember = "gelednoicainumyoipicdescripcion"
            .ValueMember = "gelednoicainumyoipicid"
            .DataSource = dtDelegaciones
            .SelectedIndex = -1
        End With

        With ComboBox3
            .Enabled = False
            .Visible = True
            .DataSource = Nothing
            .SelectedIndex = -1
        End With

        With ComboBox4
            .Enabled = False
            .Visible = True
            .DataSource = Nothing
            .SelectedIndex = -1
        End With

        ComboBox2.Enabled = True
        CheckBox1.Visible = False
        CheckBox2.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox2.SelectionChangeCommitted

        ComboBox3.Enabled = True
        ComboBox3.Visible = True

        Dim dtColonia As New DataTable
        dtColonia = Conexion.loadColonias(ComboBox2.SelectedValue)
        With ComboBox3
            .DisplayMember = "asentamientodescripcioX"
            .ValueMember = "asentamientoiX"
            .DataSource = dtColonia
            .SelectedIndex = -1
        End With

        CheckBox1.Visible = True
        CheckBox1.Checked = False
        CheckBox2.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False

        With ComboBox4
            .Enabled = False
            .DataSource = Nothing
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox3.SelectionChangeCommitted
        ComboBox4.Enabled = True

        Dim dtColonia As New DataTable
        dtColonia = Conexion.loadCP(ComboBox3.SelectedValue)
        With ComboBox4
            .DisplayMember = "codigopostaliX"
            .ValueMember = "codigopostaliX"
            .DataSource = dtColonia
            .SelectedIndex = -1
        End With

        CheckBox2.Visible = True
        CheckBox2.Checked = False

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox1.Visible = True
            TextBox1.Text = ""
            ComboBox3.Visible = False
            ComboBox4.Enabled = True
            CheckBox2.Visible = True
            CheckBox2.Checked = True
            TextBox1.Focus()
        Else
            TextBox1.Visible = False
            ComboBox3.Visible = True
            ComboBox4.Enabled = False
            CheckBox2.Checked = False
        End If


    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            TextBox2.Visible = True
            TextBox2.Text = ""
            TextBox2.Focus()
            ComboBox4.Visible = False
        Else
            TextBox2.Visible = False
            ComboBox4.Visible = True
        End If

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If Not (Negocios.comboOption(ComboBox1.SelectedIndex)) Then
            MessageBox.Show("Selecciona un estado válido")
            Exit Sub
        End If

        If Not (Negocios.comboOption(ComboBox2.SelectedIndex)) Then
            MessageBox.Show("Selecciona una delegación válida")
            Exit Sub
        End If

        If CheckBox1.Checked Then
            If Not (Negocios.texto(TextBox1.Text)) Then
                MessageBox.Show("Selecciona una colonia válida")
                Exit Sub
            End If
        Else
            If Not (Negocios.comboOption(ComboBox3.SelectedIndex)) Then
                MessageBox.Show("Selecciona una colonia válida")
                Exit Sub
            End If
        End If

        If CheckBox2.Checked Then
            If Not (Negocios.isCP(TextBox2.Text)) Then
                MessageBox.Show("Selecciona un Código Postal válido")
                Exit Sub
            End If
        Else
            If Not (Negocios.isCP(ComboBox4.Text)) Then
                MessageBox.Show("Selecciona un Código Postal válido")
                Exit Sub
            End If
        End If
        ''''''''''''''''''''''


        If CheckBox1.Checked And CheckBox2.Checked Then
            If MsgBox(String.Format("La dirección que está a punto de ingresar es la siguiente:{0}Estado: {1}, Delegación: {2}, Colonia: {3} y Código Postal: {4}. ¿Es correcto?", vbCrLf, ComboBox1.Text, ComboBox2.Text, TextBox1.Text, TextBox2.Text), (vbQuestion + vbYesNo)) = vbNo Then
                Exit Sub
            End If

            If (Conexion.EjecutaStore_AgregarCPyColoniaCartaCompromiso(ComboBox1.SelectedValue, ComboBox2.SelectedValue, TextBox1.Text, CInt(TextBox2.Text))) Then
                MessageBox.Show("Completado")
                Conexion.insertSoporte(String.Format("Estado: {0} | Delegación: {1}| Colonia: {2}| CP: {3}", ComboBox1.Text, ComboBox2.Text, TextBox1.Text, (TextBox2.Text)), 3, _UsuarioActivo2)
            End If
            ''''''
        ElseIf CheckBox1.Checked And Not CheckBox2.Checked Then
            If MsgBox(String.Format("La dirección que está a punto de ingresar es la siguiente:{0}Estado: {1}, Delegación: {2}, Colonia: {3} y Código Postal: {4}. ¿Es correcto?", vbCrLf, ComboBox1.Text, ComboBox2.Text, TextBox1.Text, ComboBox4.Text), (vbQuestion + vbYesNo)) = vbNo Then
                Exit Sub
            End If

            If (Conexion.EjecutaStore_AgregarCPyColoniaCartaCompromiso(ComboBox1.SelectedValue, ComboBox2.SelectedValue, TextBox1.Text, ComboBox4.Text)) Then
                MessageBox.Show("Completado")
                Conexion.insertSoporte(String.Format("Estado: {0} | Delegación: {1}| Colonia: {2}| CP: {3}", ComboBox1.Text, ComboBox2.Text, TextBox1.Text, ComboBox4.Text), 3, _UsuarioActivo2)
            End If
            ''''
        ElseIf Not CheckBox1.Checked And CheckBox2.Checked Then
            If MsgBox(String.Format("La dirección que está a punto de ingresar es la siguiente:{0}Estado: {1}, Delegación: {2}, Colonia: {3} y Código Postal: {4}. ¿Es correcto?", vbCrLf, ComboBox1.Text, ComboBox2.Text, ComboBox3.Text, TextBox2.Text), (vbQuestion + vbYesNo)) = vbNo Then
                Exit Sub
            End If

            If (Conexion.EjecutaStore_AgregarCPyColoniaCartaCompromiso(ComboBox1.SelectedValue, ComboBox2.SelectedValue, ComboBox3.Text, TextBox2.Text)) Then
                MessageBox.Show("Completado")
                Conexion.insertSoporte(String.Format("Estado: {0} | Delegación: {1}| Colonia: {2}| CP: {3}", ComboBox1.Text, ComboBox2.Text, ComboBox3.Text, TextBox2.Text), 3, _UsuarioActivo2)
            End If

            ''''''
        ElseIf Not CheckBox1.Checked And Not CheckBox2.Checked Then
            If MsgBox(String.Format("La dirección que está a punto de ingresar es la siguiente:{0}Estado: {1}, Delegación: {2}, Colonia: {3} y Código Postal: {4}. ¿Es correcto?", vbCrLf, ComboBox1.Text, ComboBox2.Text, ComboBox3.Text, ComboBox4.Text), (vbQuestion + vbYesNo)) = vbNo Then
                Exit Sub
            End If

            If (Conexion.EjecutaStore_AgregarCPyColoniaCartaCompromiso(ComboBox1.SelectedValue, ComboBox2.SelectedValue, ComboBox3.Text, ComboBox4.SelectedValue)) Then
                MessageBox.Show("Completado")
                Conexion.insertSoporte(String.Format("Estado: {0} | Delegación: {1}| Colonia: {2}| CP: {3}", ComboBox1.Text, ComboBox2.Text, ComboBox3.Text, ComboBox4.Text), 3, _UsuarioActivo2)
            End If

        End If
    End Sub

End Class