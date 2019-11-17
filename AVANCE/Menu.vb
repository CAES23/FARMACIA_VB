Imports System.Runtime.InteropServices
Public Class Menu

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnMinizar_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub btnCerrar_Click_1(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnMaximizar_Click_1(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        'para maximizar
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnMinizar_Click_1(sender As Object, e As EventArgs) Handles btnMinizar.Click
        'Para minizar
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub hideSubmenu()
        'Guardar los paneles
        PanelSubmenuConsultas.Visible = False
        PanelSubmenuMedicamentos.Visible = False
        PanelSubmenuReportes.Visible = False
        PanelSubmenuUsuarios.Visible = False
    End Sub

    Private Sub ShowSubmenu(submenu As Panel)
        'al momento q un panel esta en falso se cambia a verdad y viceversa
        If submenu.Visible = False Then
            hideSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Lo publicas para q se muestre cuando se inicia
        hideSubmenu()
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        'publicas la accion showsubmenu a solo el panelSubmenuUsuarios
        ShowSubmenu(PanelSubmenuUsuarios)
    End Sub

    Private Sub btnMedicamentos_Click(sender As Object, e As EventArgs) Handles btnMedicamentos.Click
        ShowSubmenu(PanelSubmenuMedicamentos)
    End Sub

    Private Sub btnConsultas_Click(sender As Object, e As EventArgs) Handles btnConsultas.Click
        ShowSubmenu(PanelSubmenuConsultas)
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        ShowSubmenu(PanelSubmenuReportes)
    End Sub
#Region "Cerrar Submenus con los submenus"
    Private Sub btnrRegUsuario_Click(sender As Object, e As EventArgs) Handles btnrRegUsuario.Click
        AbrirFormenPanel(New Form3)
        'cuando se selecciona un submenu se cierra la lista de submenu
        hideSubmenu()
    End Sub

    Private Sub btnPermisosyseguridad_Click(sender As Object, e As EventArgs) Handles btnPermisosyseguridad.Click
        AbrirFormenPanel(New Login)
        hideSubmenu()
    End Sub

    Private Sub btnRegProveedores_Click(sender As Object, e As EventArgs) Handles btnRegProveedores.Click
        hideSubmenu()
    End Sub

    Private Sub btnRegLaboratorios_Click(sender As Object, e As EventArgs) Handles btnRegLaboratorios.Click
        hideSubmenu()
    End Sub

    Private Sub btnRegMedicamentos_Click(sender As Object, e As EventArgs) Handles btnRegMedicamentos.Click
        hideSubmenu()
    End Sub

    Private Sub btnProveedoresReg_Click(sender As Object, e As EventArgs) Handles btnProveedoresReg.Click
        hideSubmenu()
    End Sub

    Private Sub btnSubMedicamentos_Click(sender As Object, e As EventArgs) Handles btnSubMedicamentos.Click
        hideSubmenu()
    End Sub
    Private Sub btnComprareprovee_Click(sender As Object, e As EventArgs) Handles btnComprareprovee.Click
        hideSubmenu()
    End Sub

    Private Sub btnVentasalcliente_Click(sender As Object, e As EventArgs) Handles btnVentasalcliente.Click
        hideSubmenu()
    End Sub

    Private Sub btnUsuariosReg_Click(sender As Object, e As EventArgs) Handles btnUsuariosReg.Click
        hideSubmenu()
    End Sub

    Private Sub btnLaboratoriosReg_Click(sender As Object, e As EventArgs) Handles btnLaboratoriosReg.Click
        hideSubmenu()
    End Sub

    Private Sub btnSubMedicamentosR_Click(sender As Object, e As EventArgs) Handles btnSubMedicamentosR.Click
        hideSubmenu()
    End Sub

    Private Sub btnComprareproveeR_Click(sender As Object, e As EventArgs) Handles btnComprareproveeR.Click
        hideSubmenu()
    End Sub

    Private Sub btnVentasalclienteR_Click(sender As Object, e As EventArgs) Handles btnVentasalclienteR.Click
        hideSubmenu()
    End Sub

    Private Sub btnUsuariosR_Click(sender As Object, e As EventArgs) Handles btnUsuariosR.Click
        hideSubmenu()
    End Sub

    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        hideSubmenu()
    End Sub

    Private Sub btnLaboratiosRegR_Click(sender As Object, e As EventArgs) Handles btnLaboratiosRegR.Click
        hideSubmenu()
    End Sub

#End Region
#Region "Mover la ventana"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()

    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

    End Sub
    Private Sub pnlTitule_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlTitule.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
#End Region

    Private Sub tmOcultarMenu_Tick(sender As Object, e As EventArgs) Handles tmOcultarMenu.Tick
        If pnlMenu.Width <= 58 Then
            Me.tmOcultarMenu.Enabled = False
        Else
            Me.pnlMenu.Width = pnlMenu.Width - 20
        End If
    End Sub

    Private Sub tmMostrarMenu_Tick(sender As Object, e As EventArgs) Handles tmMostrarMenu.Tick
        If pnlMenu.Width >= 278 Then
            Me.tmOcultarMenu.Enabled = False
        Else
            Me.pnlMenu.Width = pnlMenu.Width + 20
        End If
    End Sub

    Private Sub AbrirFormenPanel(ByVal Formijo As Object)
        If Me.pnlContenido.Controls.Count > 0 Then
            Me.pnlContenido.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(Formijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.pnlContenido.Controls.Add(fh)
        Me.pnlContenido.Tag = fh
        fh.Show()

    End Sub

    Private Sub pnlTitule_Paint(sender As Object, e As PaintEventArgs) Handles pnlTitule.Paint

    End Sub

    Private Sub btnMenu_Click_1(sender As Object, e As EventArgs) Handles btnMenu.Click
        If pnlMenu.Width = 278 Then
            tmOcultarMenu.Enabled = True
        ElseIf pnlMenu.Width = 58 Then
            tmOcultarMenu.Enabled = True
        End If
    End Sub
End Class
