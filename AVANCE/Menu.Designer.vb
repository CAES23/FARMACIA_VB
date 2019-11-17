<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.pnlTitule = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnMinizar = New System.Windows.Forms.Button()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.PanelSubmenuReportes = New System.Windows.Forms.Panel()
        Me.btnLaboratiosRegR = New System.Windows.Forms.Button()
        Me.btnProveedores = New System.Windows.Forms.Button()
        Me.btnUsuariosR = New System.Windows.Forms.Button()
        Me.btnVentasalclienteR = New System.Windows.Forms.Button()
        Me.btnComprareproveeR = New System.Windows.Forms.Button()
        Me.btnSubMedicamentosR = New System.Windows.Forms.Button()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.PanelSubmenuConsultas = New System.Windows.Forms.Panel()
        Me.btnLaboratoriosReg = New System.Windows.Forms.Button()
        Me.btnProveedoresReg = New System.Windows.Forms.Button()
        Me.btnUsuariosReg = New System.Windows.Forms.Button()
        Me.btnVentasalcliente = New System.Windows.Forms.Button()
        Me.btnComprareprovee = New System.Windows.Forms.Button()
        Me.btnSubMedicamentos = New System.Windows.Forms.Button()
        Me.btnConsultas = New System.Windows.Forms.Button()
        Me.btnVender = New System.Windows.Forms.Button()
        Me.PanelSubmenuMedicamentos = New System.Windows.Forms.Panel()
        Me.btnRegMedicamentos = New System.Windows.Forms.Button()
        Me.btnRegLaboratorios = New System.Windows.Forms.Button()
        Me.btnRegProveedores = New System.Windows.Forms.Button()
        Me.btnMedicamentos = New System.Windows.Forms.Button()
        Me.PanelSubmenuUsuarios = New System.Windows.Forms.Panel()
        Me.btnPermisosyseguridad = New System.Windows.Forms.Button()
        Me.btnrRegUsuario = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.pnlContenido = New System.Windows.Forms.Panel()
        Me.tmOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.pnlTitule.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenu.SuspendLayout()
        Me.PanelSubmenuReportes.SuspendLayout()
        Me.PanelSubmenuConsultas.SuspendLayout()
        Me.PanelSubmenuMedicamentos.SuspendLayout()
        Me.PanelSubmenuUsuarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitule
        '
        Me.pnlTitule.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.pnlTitule.Controls.Add(Me.Panel1)
        Me.pnlTitule.Controls.Add(Me.btnMinizar)
        Me.pnlTitule.Controls.Add(Me.btnRestaurar)
        Me.pnlTitule.Controls.Add(Me.btnMaximizar)
        Me.pnlTitule.Controls.Add(Me.btnCerrar)
        Me.pnlTitule.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitule.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitule.Name = "pnlTitule"
        Me.pnlTitule.Size = New System.Drawing.Size(929, 43)
        Me.pnlTitule.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnMenu)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(259, 43)
        Me.Panel1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(53, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SYSTEM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label1.Location = New System.Drawing.Point(118, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "FARMACIA"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 37)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'btnMinizar
        '
        Me.btnMinizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinizar.BackgroundImage = CType(resources.GetObject("btnMinizar.BackgroundImage"), System.Drawing.Image)
        Me.btnMinizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMinizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinizar.FlatAppearance.BorderSize = 0
        Me.btnMinizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMinizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinizar.Location = New System.Drawing.Point(809, 0)
        Me.btnMinizar.Name = "btnMinizar"
        Me.btnMinizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinizar.TabIndex = 1
        Me.btnMinizar.UseVisualStyleBackColor = True
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.BackgroundImage = CType(resources.GetObject("btnRestaurar.BackgroundImage"), System.Drawing.Image)
        Me.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Location = New System.Drawing.Point(849, 0)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(40, 40)
        Me.btnRestaurar.TabIndex = 1
        Me.btnRestaurar.UseVisualStyleBackColor = True
        Me.btnRestaurar.Visible = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.BackgroundImage = CType(resources.GetObject("btnMaximizar.BackgroundImage"), System.Drawing.Image)
        Me.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.Location = New System.Drawing.Point(849, 0)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMaximizar.TabIndex = 1
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Location = New System.Drawing.Point(889, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'pnlMenu
        '
        Me.pnlMenu.AutoScroll = True
        Me.pnlMenu.BackColor = System.Drawing.Color.Gray
        Me.pnlMenu.Controls.Add(Me.btnHelp)
        Me.pnlMenu.Controls.Add(Me.PanelSubmenuReportes)
        Me.pnlMenu.Controls.Add(Me.btnReportes)
        Me.pnlMenu.Controls.Add(Me.PanelSubmenuConsultas)
        Me.pnlMenu.Controls.Add(Me.btnConsultas)
        Me.pnlMenu.Controls.Add(Me.btnVender)
        Me.pnlMenu.Controls.Add(Me.PanelSubmenuMedicamentos)
        Me.pnlMenu.Controls.Add(Me.btnMedicamentos)
        Me.pnlMenu.Controls.Add(Me.PanelSubmenuUsuarios)
        Me.pnlMenu.Controls.Add(Me.btnUsuarios)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 43)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(208, 513)
        Me.pnlMenu.TabIndex = 1
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.btnHelp.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHelp.FlatAppearance.BorderSize = 0
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Image = CType(resources.GetObject("btnHelp.Image"), System.Drawing.Image)
        Me.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHelp.Location = New System.Drawing.Point(0, 936)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnHelp.Size = New System.Drawing.Size(191, 45)
        Me.btnHelp.TabIndex = 10
        Me.btnHelp.Text = "Ayuda"
        Me.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'PanelSubmenuReportes
        '
        Me.PanelSubmenuReportes.BackColor = System.Drawing.Color.Black
        Me.PanelSubmenuReportes.Controls.Add(Me.btnLaboratiosRegR)
        Me.PanelSubmenuReportes.Controls.Add(Me.btnProveedores)
        Me.PanelSubmenuReportes.Controls.Add(Me.btnUsuariosR)
        Me.PanelSubmenuReportes.Controls.Add(Me.btnVentasalclienteR)
        Me.PanelSubmenuReportes.Controls.Add(Me.btnComprareproveeR)
        Me.PanelSubmenuReportes.Controls.Add(Me.btnSubMedicamentosR)
        Me.PanelSubmenuReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubmenuReportes.Location = New System.Drawing.Point(0, 687)
        Me.PanelSubmenuReportes.Name = "PanelSubmenuReportes"
        Me.PanelSubmenuReportes.Size = New System.Drawing.Size(191, 249)
        Me.PanelSubmenuReportes.TabIndex = 9
        '
        'btnLaboratiosRegR
        '
        Me.btnLaboratiosRegR.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnLaboratiosRegR.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLaboratiosRegR.FlatAppearance.BorderSize = 0
        Me.btnLaboratiosRegR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaboratiosRegR.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLaboratiosRegR.Location = New System.Drawing.Point(0, 200)
        Me.btnLaboratiosRegR.Name = "btnLaboratiosRegR"
        Me.btnLaboratiosRegR.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnLaboratiosRegR.Size = New System.Drawing.Size(191, 40)
        Me.btnLaboratiosRegR.TabIndex = 7
        Me.btnLaboratiosRegR.Text = "Laboratorios Reg."
        Me.btnLaboratiosRegR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLaboratiosRegR.UseVisualStyleBackColor = False
        '
        'btnProveedores
        '
        Me.btnProveedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProveedores.FlatAppearance.BorderSize = 0
        Me.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProveedores.ForeColor = System.Drawing.SystemColors.Control
        Me.btnProveedores.Location = New System.Drawing.Point(0, 160)
        Me.btnProveedores.Name = "btnProveedores"
        Me.btnProveedores.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnProveedores.Size = New System.Drawing.Size(191, 40)
        Me.btnProveedores.TabIndex = 6
        Me.btnProveedores.Text = "Proveedores"
        Me.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProveedores.UseVisualStyleBackColor = False
        '
        'btnUsuariosR
        '
        Me.btnUsuariosR.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnUsuariosR.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUsuariosR.FlatAppearance.BorderSize = 0
        Me.btnUsuariosR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuariosR.ForeColor = System.Drawing.SystemColors.Control
        Me.btnUsuariosR.Location = New System.Drawing.Point(0, 120)
        Me.btnUsuariosR.Name = "btnUsuariosR"
        Me.btnUsuariosR.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnUsuariosR.Size = New System.Drawing.Size(191, 40)
        Me.btnUsuariosR.TabIndex = 5
        Me.btnUsuariosR.Text = "Usuarios"
        Me.btnUsuariosR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuariosR.UseVisualStyleBackColor = False
        '
        'btnVentasalclienteR
        '
        Me.btnVentasalclienteR.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVentasalclienteR.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVentasalclienteR.FlatAppearance.BorderSize = 0
        Me.btnVentasalclienteR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentasalclienteR.ForeColor = System.Drawing.SystemColors.Control
        Me.btnVentasalclienteR.Location = New System.Drawing.Point(0, 80)
        Me.btnVentasalclienteR.Name = "btnVentasalclienteR"
        Me.btnVentasalclienteR.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnVentasalclienteR.Size = New System.Drawing.Size(191, 40)
        Me.btnVentasalclienteR.TabIndex = 4
        Me.btnVentasalclienteR.Text = "Ventas al cliente"
        Me.btnVentasalclienteR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentasalclienteR.UseVisualStyleBackColor = False
        '
        'btnComprareproveeR
        '
        Me.btnComprareproveeR.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnComprareproveeR.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnComprareproveeR.FlatAppearance.BorderSize = 0
        Me.btnComprareproveeR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComprareproveeR.ForeColor = System.Drawing.SystemColors.Control
        Me.btnComprareproveeR.Location = New System.Drawing.Point(0, 40)
        Me.btnComprareproveeR.Name = "btnComprareproveeR"
        Me.btnComprareproveeR.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnComprareproveeR.Size = New System.Drawing.Size(191, 40)
        Me.btnComprareproveeR.TabIndex = 3
        Me.btnComprareproveeR.Text = "Compras al proveedor"
        Me.btnComprareproveeR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnComprareproveeR.UseVisualStyleBackColor = False
        '
        'btnSubMedicamentosR
        '
        Me.btnSubMedicamentosR.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnSubMedicamentosR.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSubMedicamentosR.FlatAppearance.BorderSize = 0
        Me.btnSubMedicamentosR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubMedicamentosR.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSubMedicamentosR.Location = New System.Drawing.Point(0, 0)
        Me.btnSubMedicamentosR.Name = "btnSubMedicamentosR"
        Me.btnSubMedicamentosR.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnSubMedicamentosR.Size = New System.Drawing.Size(191, 40)
        Me.btnSubMedicamentosR.TabIndex = 2
        Me.btnSubMedicamentosR.Text = "Medicamentos"
        Me.btnSubMedicamentosR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubMedicamentosR.UseVisualStyleBackColor = False
        '
        'btnReportes
        '
        Me.btnReportes.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.btnReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReportes.FlatAppearance.BorderSize = 0
        Me.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportes.Image = CType(resources.GetObject("btnReportes.Image"), System.Drawing.Image)
        Me.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportes.Location = New System.Drawing.Point(0, 642)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnReportes.Size = New System.Drawing.Size(191, 45)
        Me.btnReportes.TabIndex = 8
        Me.btnReportes.Text = "Reportes"
        Me.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReportes.UseVisualStyleBackColor = False
        '
        'PanelSubmenuConsultas
        '
        Me.PanelSubmenuConsultas.BackColor = System.Drawing.Color.Black
        Me.PanelSubmenuConsultas.Controls.Add(Me.btnLaboratoriosReg)
        Me.PanelSubmenuConsultas.Controls.Add(Me.btnProveedoresReg)
        Me.PanelSubmenuConsultas.Controls.Add(Me.btnUsuariosReg)
        Me.PanelSubmenuConsultas.Controls.Add(Me.btnVentasalcliente)
        Me.PanelSubmenuConsultas.Controls.Add(Me.btnComprareprovee)
        Me.PanelSubmenuConsultas.Controls.Add(Me.btnSubMedicamentos)
        Me.PanelSubmenuConsultas.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubmenuConsultas.Location = New System.Drawing.Point(0, 393)
        Me.PanelSubmenuConsultas.Name = "PanelSubmenuConsultas"
        Me.PanelSubmenuConsultas.Size = New System.Drawing.Size(191, 249)
        Me.PanelSubmenuConsultas.TabIndex = 7
        '
        'btnLaboratoriosReg
        '
        Me.btnLaboratoriosReg.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnLaboratoriosReg.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLaboratoriosReg.FlatAppearance.BorderSize = 0
        Me.btnLaboratoriosReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaboratoriosReg.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLaboratoriosReg.Location = New System.Drawing.Point(0, 200)
        Me.btnLaboratoriosReg.Name = "btnLaboratoriosReg"
        Me.btnLaboratoriosReg.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnLaboratoriosReg.Size = New System.Drawing.Size(191, 40)
        Me.btnLaboratoriosReg.TabIndex = 7
        Me.btnLaboratoriosReg.Text = "Laboratorios Reg."
        Me.btnLaboratoriosReg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLaboratoriosReg.UseVisualStyleBackColor = False
        '
        'btnProveedoresReg
        '
        Me.btnProveedoresReg.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnProveedoresReg.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProveedoresReg.FlatAppearance.BorderSize = 0
        Me.btnProveedoresReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProveedoresReg.ForeColor = System.Drawing.SystemColors.Control
        Me.btnProveedoresReg.Location = New System.Drawing.Point(0, 160)
        Me.btnProveedoresReg.Name = "btnProveedoresReg"
        Me.btnProveedoresReg.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnProveedoresReg.Size = New System.Drawing.Size(191, 40)
        Me.btnProveedoresReg.TabIndex = 6
        Me.btnProveedoresReg.Text = "Proveedores Reg."
        Me.btnProveedoresReg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProveedoresReg.UseVisualStyleBackColor = False
        '
        'btnUsuariosReg
        '
        Me.btnUsuariosReg.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnUsuariosReg.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUsuariosReg.FlatAppearance.BorderSize = 0
        Me.btnUsuariosReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuariosReg.ForeColor = System.Drawing.SystemColors.Control
        Me.btnUsuariosReg.Location = New System.Drawing.Point(0, 120)
        Me.btnUsuariosReg.Name = "btnUsuariosReg"
        Me.btnUsuariosReg.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnUsuariosReg.Size = New System.Drawing.Size(191, 40)
        Me.btnUsuariosReg.TabIndex = 5
        Me.btnUsuariosReg.Text = "Usuarios Reg."
        Me.btnUsuariosReg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuariosReg.UseVisualStyleBackColor = False
        '
        'btnVentasalcliente
        '
        Me.btnVentasalcliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnVentasalcliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVentasalcliente.FlatAppearance.BorderSize = 0
        Me.btnVentasalcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentasalcliente.ForeColor = System.Drawing.SystemColors.Control
        Me.btnVentasalcliente.Location = New System.Drawing.Point(0, 80)
        Me.btnVentasalcliente.Name = "btnVentasalcliente"
        Me.btnVentasalcliente.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnVentasalcliente.Size = New System.Drawing.Size(191, 40)
        Me.btnVentasalcliente.TabIndex = 4
        Me.btnVentasalcliente.Text = "Ventas al cliente"
        Me.btnVentasalcliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentasalcliente.UseVisualStyleBackColor = False
        '
        'btnComprareprovee
        '
        Me.btnComprareprovee.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnComprareprovee.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnComprareprovee.FlatAppearance.BorderSize = 0
        Me.btnComprareprovee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComprareprovee.ForeColor = System.Drawing.SystemColors.Control
        Me.btnComprareprovee.Location = New System.Drawing.Point(0, 40)
        Me.btnComprareprovee.Name = "btnComprareprovee"
        Me.btnComprareprovee.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnComprareprovee.Size = New System.Drawing.Size(191, 40)
        Me.btnComprareprovee.TabIndex = 3
        Me.btnComprareprovee.Text = "Comprar e proveedores"
        Me.btnComprareprovee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnComprareprovee.UseVisualStyleBackColor = False
        '
        'btnSubMedicamentos
        '
        Me.btnSubMedicamentos.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnSubMedicamentos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSubMedicamentos.FlatAppearance.BorderSize = 0
        Me.btnSubMedicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubMedicamentos.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSubMedicamentos.Location = New System.Drawing.Point(0, 0)
        Me.btnSubMedicamentos.Name = "btnSubMedicamentos"
        Me.btnSubMedicamentos.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnSubMedicamentos.Size = New System.Drawing.Size(191, 40)
        Me.btnSubMedicamentos.TabIndex = 2
        Me.btnSubMedicamentos.Text = "Medicamentos"
        Me.btnSubMedicamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubMedicamentos.UseVisualStyleBackColor = False
        '
        'btnConsultas
        '
        Me.btnConsultas.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.btnConsultas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnConsultas.FlatAppearance.BorderSize = 0
        Me.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultas.Image = CType(resources.GetObject("btnConsultas.Image"), System.Drawing.Image)
        Me.btnConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultas.Location = New System.Drawing.Point(0, 348)
        Me.btnConsultas.Name = "btnConsultas"
        Me.btnConsultas.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnConsultas.Size = New System.Drawing.Size(191, 45)
        Me.btnConsultas.TabIndex = 6
        Me.btnConsultas.Text = "Consultas"
        Me.btnConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConsultas.UseVisualStyleBackColor = False
        '
        'btnVender
        '
        Me.btnVender.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.btnVender.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVender.FlatAppearance.BorderSize = 0
        Me.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVender.Image = CType(resources.GetObject("btnVender.Image"), System.Drawing.Image)
        Me.btnVender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVender.Location = New System.Drawing.Point(0, 303)
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnVender.Size = New System.Drawing.Size(191, 45)
        Me.btnVender.TabIndex = 4
        Me.btnVender.Text = "$Vender"
        Me.btnVender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVender.UseVisualStyleBackColor = False
        '
        'PanelSubmenuMedicamentos
        '
        Me.PanelSubmenuMedicamentos.BackColor = System.Drawing.Color.Black
        Me.PanelSubmenuMedicamentos.Controls.Add(Me.btnRegMedicamentos)
        Me.PanelSubmenuMedicamentos.Controls.Add(Me.btnRegLaboratorios)
        Me.PanelSubmenuMedicamentos.Controls.Add(Me.btnRegProveedores)
        Me.PanelSubmenuMedicamentos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubmenuMedicamentos.Location = New System.Drawing.Point(0, 177)
        Me.PanelSubmenuMedicamentos.Name = "PanelSubmenuMedicamentos"
        Me.PanelSubmenuMedicamentos.Size = New System.Drawing.Size(191, 126)
        Me.PanelSubmenuMedicamentos.TabIndex = 3
        '
        'btnRegMedicamentos
        '
        Me.btnRegMedicamentos.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnRegMedicamentos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRegMedicamentos.FlatAppearance.BorderSize = 0
        Me.btnRegMedicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegMedicamentos.ForeColor = System.Drawing.SystemColors.Control
        Me.btnRegMedicamentos.Location = New System.Drawing.Point(0, 80)
        Me.btnRegMedicamentos.Name = "btnRegMedicamentos"
        Me.btnRegMedicamentos.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnRegMedicamentos.Size = New System.Drawing.Size(191, 40)
        Me.btnRegMedicamentos.TabIndex = 0
        Me.btnRegMedicamentos.Text = "Reg. Medicamentos"
        Me.btnRegMedicamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegMedicamentos.UseVisualStyleBackColor = False
        '
        'btnRegLaboratorios
        '
        Me.btnRegLaboratorios.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnRegLaboratorios.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRegLaboratorios.FlatAppearance.BorderSize = 0
        Me.btnRegLaboratorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegLaboratorios.ForeColor = System.Drawing.SystemColors.Control
        Me.btnRegLaboratorios.Location = New System.Drawing.Point(0, 40)
        Me.btnRegLaboratorios.Name = "btnRegLaboratorios"
        Me.btnRegLaboratorios.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnRegLaboratorios.Size = New System.Drawing.Size(191, 40)
        Me.btnRegLaboratorios.TabIndex = 2
        Me.btnRegLaboratorios.Text = "Reg. Laboratorios"
        Me.btnRegLaboratorios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegLaboratorios.UseVisualStyleBackColor = False
        '
        'btnRegProveedores
        '
        Me.btnRegProveedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnRegProveedores.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRegProveedores.FlatAppearance.BorderSize = 0
        Me.btnRegProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegProveedores.ForeColor = System.Drawing.SystemColors.Control
        Me.btnRegProveedores.Location = New System.Drawing.Point(0, 0)
        Me.btnRegProveedores.Name = "btnRegProveedores"
        Me.btnRegProveedores.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnRegProveedores.Size = New System.Drawing.Size(191, 40)
        Me.btnRegProveedores.TabIndex = 1
        Me.btnRegProveedores.Text = "Reg. Proveedores"
        Me.btnRegProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegProveedores.UseVisualStyleBackColor = False
        '
        'btnMedicamentos
        '
        Me.btnMedicamentos.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.btnMedicamentos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMedicamentos.FlatAppearance.BorderSize = 0
        Me.btnMedicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMedicamentos.Image = CType(resources.GetObject("btnMedicamentos.Image"), System.Drawing.Image)
        Me.btnMedicamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMedicamentos.Location = New System.Drawing.Point(0, 132)
        Me.btnMedicamentos.Name = "btnMedicamentos"
        Me.btnMedicamentos.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnMedicamentos.Size = New System.Drawing.Size(191, 45)
        Me.btnMedicamentos.TabIndex = 2
        Me.btnMedicamentos.Text = "Medicamentos"
        Me.btnMedicamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMedicamentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMedicamentos.UseVisualStyleBackColor = False
        '
        'PanelSubmenuUsuarios
        '
        Me.PanelSubmenuUsuarios.BackColor = System.Drawing.Color.Black
        Me.PanelSubmenuUsuarios.Controls.Add(Me.btnPermisosyseguridad)
        Me.PanelSubmenuUsuarios.Controls.Add(Me.btnrRegUsuario)
        Me.PanelSubmenuUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubmenuUsuarios.Location = New System.Drawing.Point(0, 45)
        Me.PanelSubmenuUsuarios.Name = "PanelSubmenuUsuarios"
        Me.PanelSubmenuUsuarios.Size = New System.Drawing.Size(191, 87)
        Me.PanelSubmenuUsuarios.TabIndex = 1
        '
        'btnPermisosyseguridad
        '
        Me.btnPermisosyseguridad.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnPermisosyseguridad.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPermisosyseguridad.FlatAppearance.BorderSize = 0
        Me.btnPermisosyseguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPermisosyseguridad.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPermisosyseguridad.Location = New System.Drawing.Point(0, 40)
        Me.btnPermisosyseguridad.Name = "btnPermisosyseguridad"
        Me.btnPermisosyseguridad.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnPermisosyseguridad.Size = New System.Drawing.Size(191, 40)
        Me.btnPermisosyseguridad.TabIndex = 1
        Me.btnPermisosyseguridad.Text = "Permisos y seguridad"
        Me.btnPermisosyseguridad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPermisosyseguridad.UseVisualStyleBackColor = False
        '
        'btnrRegUsuario
        '
        Me.btnrRegUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnrRegUsuario.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnrRegUsuario.FlatAppearance.BorderSize = 0
        Me.btnrRegUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrRegUsuario.ForeColor = System.Drawing.SystemColors.Control
        Me.btnrRegUsuario.Location = New System.Drawing.Point(0, 0)
        Me.btnrRegUsuario.Name = "btnrRegUsuario"
        Me.btnrRegUsuario.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnrRegUsuario.Size = New System.Drawing.Size(191, 40)
        Me.btnrRegUsuario.TabIndex = 0
        Me.btnrRegUsuario.Text = "Reg.Usuario"
        Me.btnrRegUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrRegUsuario.UseVisualStyleBackColor = False
        '
        'btnUsuarios
        '
        Me.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUsuarios.FlatAppearance.BorderSize = 0
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.Image = CType(resources.GetObject("btnUsuarios.Image"), System.Drawing.Image)
        Me.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnUsuarios.Size = New System.Drawing.Size(191, 45)
        Me.btnUsuarios.TabIndex = 0
        Me.btnUsuarios.Text = "Usuarios     "
        Me.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUsuarios.UseVisualStyleBackColor = False
        '
        'pnlContenido
        '
        Me.pnlContenido.AutoScroll = True
        Me.pnlContenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenido.Location = New System.Drawing.Point(208, 43)
        Me.pnlContenido.Name = "pnlContenido"
        Me.pnlContenido.Size = New System.Drawing.Size(721, 513)
        Me.pnlContenido.TabIndex = 2
        '
        'tmOcultarMenu
        '
        '
        'tmMostrarMenu
        '
        '
        'btnMenu
        '
        Me.btnMenu.BackgroundImage = CType(resources.GetObject("btnMenu.BackgroundImage"), System.Drawing.Image)
        Me.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMenu.FlatAppearance.BorderSize = 0
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.Location = New System.Drawing.Point(221, 0)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(35, 37)
        Me.btnMenu.TabIndex = 3
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(929, 556)
        Me.Controls.Add(Me.pnlContenido)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlTitule)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(949, 599)
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlTitule.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenu.ResumeLayout(False)
        Me.PanelSubmenuReportes.ResumeLayout(False)
        Me.PanelSubmenuConsultas.ResumeLayout(False)
        Me.PanelSubmenuMedicamentos.ResumeLayout(False)
        Me.PanelSubmenuUsuarios.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTitule As System.Windows.Forms.Panel
    Friend WithEvents pnlMenu As System.Windows.Forms.Panel
    Friend WithEvents pnlContenido As System.Windows.Forms.Panel
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnMinizar As System.Windows.Forms.Button
    Friend WithEvents btnMaximizar As System.Windows.Forms.Button
    Friend WithEvents btnRestaurar As System.Windows.Forms.Button
    Friend WithEvents PanelSubmenuConsultas As System.Windows.Forms.Panel
    Friend WithEvents btnConsultas As System.Windows.Forms.Button
    Friend WithEvents btnVender As System.Windows.Forms.Button
    Friend WithEvents PanelSubmenuMedicamentos As System.Windows.Forms.Panel
    Friend WithEvents btnRegMedicamentos As System.Windows.Forms.Button
    Friend WithEvents btnRegLaboratorios As System.Windows.Forms.Button
    Friend WithEvents btnRegProveedores As System.Windows.Forms.Button
    Friend WithEvents btnMedicamentos As System.Windows.Forms.Button
    Friend WithEvents PanelSubmenuUsuarios As System.Windows.Forms.Panel
    Friend WithEvents btnPermisosyseguridad As System.Windows.Forms.Button
    Friend WithEvents btnrRegUsuario As System.Windows.Forms.Button
    Friend WithEvents btnUsuarios As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents PanelSubmenuReportes As System.Windows.Forms.Panel
    Friend WithEvents btnLaboratiosRegR As System.Windows.Forms.Button
    Friend WithEvents btnProveedores As System.Windows.Forms.Button
    Friend WithEvents btnUsuariosR As System.Windows.Forms.Button
    Friend WithEvents btnVentasalclienteR As System.Windows.Forms.Button
    Friend WithEvents btnComprareproveeR As System.Windows.Forms.Button
    Friend WithEvents btnSubMedicamentosR As System.Windows.Forms.Button
    Friend WithEvents btnReportes As System.Windows.Forms.Button
    Friend WithEvents btnLaboratoriosReg As System.Windows.Forms.Button
    Friend WithEvents btnProveedoresReg As System.Windows.Forms.Button
    Friend WithEvents btnUsuariosReg As System.Windows.Forms.Button
    Friend WithEvents btnVentasalcliente As System.Windows.Forms.Button
    Friend WithEvents btnComprareprovee As System.Windows.Forms.Button
    Friend WithEvents btnSubMedicamentos As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents tmOcultarMenu As System.Windows.Forms.Timer
    Friend WithEvents tmMostrarMenu As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnMenu As System.Windows.Forms.Button

End Class
