<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        MenuStrip1 = New MenuStrip()
        AgregarClienteToolStripMenuItem = New ToolStripMenuItem()
        MantenimientoToolStripMenuItem = New ToolStripMenuItem()
        ProductosToolStripMenuItem = New ToolStripMenuItem()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        CategoriasToolStripMenuItem = New ToolStripMenuItem()
        IngredientesToolStripMenuItem = New ToolStripMenuItem()
        ProveedoresToolStripMenuItem = New ToolStripMenuItem()
        UsuariosToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        ConsumosStripMenuItem = New ToolStripMenuItem()
        ProveeduriaToolStripMenuItem = New ToolStripMenuItem()
        btnOrdenes = New Button()
        Panel1 = New Panel()
        Panel2 = New Panel()
        btnSync = New Button()
        btnEliminar = New Button()
        lstPendientes = New ListView()
        Label1 = New Label()
        btnHistorial = New Button()
        btnFacturar = New Button()
        lblUsuario = New Label()
        ProveeduríaToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {AgregarClienteToolStripMenuItem, MantenimientoToolStripMenuItem, ProveeduríaToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(731, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' AgregarClienteToolStripMenuItem
        ' 
        AgregarClienteToolStripMenuItem.BackColor = SystemColors.ActiveCaption
        AgregarClienteToolStripMenuItem.ForeColor = SystemColors.ControlText
        AgregarClienteToolStripMenuItem.Image = CType(resources.GetObject("AgregarClienteToolStripMenuItem.Image"), Image)
        AgregarClienteToolStripMenuItem.Name = "AgregarClienteToolStripMenuItem"
        AgregarClienteToolStripMenuItem.Size = New Size(115, 20)
        AgregarClienteToolStripMenuItem.Text = "Agregar cliente"
        ' 
        ' MantenimientoToolStripMenuItem
        ' 
        MantenimientoToolStripMenuItem.BackColor = Color.Orange
        MantenimientoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ProductosToolStripMenuItem, ClientesToolStripMenuItem, CategoriasToolStripMenuItem, IngredientesToolStripMenuItem, ProveedoresToolStripMenuItem, UsuariosToolStripMenuItem, ToolStripSeparator1, ConsumosStripMenuItem, ProveeduriaToolStripMenuItem})
        MantenimientoToolStripMenuItem.Image = CType(resources.GetObject("MantenimientoToolStripMenuItem.Image"), Image)
        MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        MantenimientoToolStripMenuItem.Size = New Size(117, 20)
        MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        ' 
        ' ProductosToolStripMenuItem
        ' 
        ProductosToolStripMenuItem.BackColor = Color.LightCoral
        ProductosToolStripMenuItem.Image = CType(resources.GetObject("ProductosToolStripMenuItem.Image"), Image)
        ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        ProductosToolStripMenuItem.Size = New Size(139, 22)
        ProductosToolStripMenuItem.Text = "Productos"
        ' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.BackColor = Color.LightCoral
        ClientesToolStripMenuItem.Image = CType(resources.GetObject("ClientesToolStripMenuItem.Image"), Image)
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Size = New Size(139, 22)
        ClientesToolStripMenuItem.Text = "Clientes"
        ' 
        ' CategoriasToolStripMenuItem
        ' 
        CategoriasToolStripMenuItem.BackColor = Color.LightCoral
        CategoriasToolStripMenuItem.Image = CType(resources.GetObject("CategoriasToolStripMenuItem.Image"), Image)
        CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        CategoriasToolStripMenuItem.Size = New Size(139, 22)
        CategoriasToolStripMenuItem.Text = "Categorias"
        ' 
        ' IngredientesToolStripMenuItem
        ' 
        IngredientesToolStripMenuItem.BackColor = Color.LightCoral
        IngredientesToolStripMenuItem.Image = CType(resources.GetObject("IngredientesToolStripMenuItem.Image"), Image)
        IngredientesToolStripMenuItem.Name = "IngredientesToolStripMenuItem"
        IngredientesToolStripMenuItem.Size = New Size(139, 22)
        IngredientesToolStripMenuItem.Text = "Ingredientes"
        ' 
        ' ProveedoresToolStripMenuItem
        ' 
        ProveedoresToolStripMenuItem.BackColor = Color.LightCoral
        ProveedoresToolStripMenuItem.Image = CType(resources.GetObject("ProveedoresToolStripMenuItem.Image"), Image)
        ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        ProveedoresToolStripMenuItem.Size = New Size(139, 22)
        ProveedoresToolStripMenuItem.Text = "Proveedores"
        ' 
        ' UsuariosToolStripMenuItem
        ' 
        UsuariosToolStripMenuItem.BackColor = Color.LightCoral
        UsuariosToolStripMenuItem.Image = CType(resources.GetObject("UsuariosToolStripMenuItem.Image"), Image)
        UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        UsuariosToolStripMenuItem.Size = New Size(139, 22)
        UsuariosToolStripMenuItem.Text = "Usuarios"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(136, 6)
        ' 
        ' ConsumosStripMenuItem
        ' 
        ConsumosStripMenuItem.BackColor = Color.LightCoral
        ConsumosStripMenuItem.Image = CType(resources.GetObject("ConsumosStripMenuItem.Image"), Image)
        ConsumosStripMenuItem.Name = "ConsumosStripMenuItem"
        ConsumosStripMenuItem.Size = New Size(139, 22)
        ConsumosStripMenuItem.Text = "Consumos"
        ' 
        ' ProveeduriaToolStripMenuItem
        ' 
        ProveeduriaToolStripMenuItem.BackColor = Color.LightCoral
        ProveeduriaToolStripMenuItem.Image = CType(resources.GetObject("ProveeduriaToolStripMenuItem.Image"), Image)
        ProveeduriaToolStripMenuItem.Name = "ProveeduriaToolStripMenuItem"
        ProveeduriaToolStripMenuItem.Size = New Size(139, 22)
        ProveeduriaToolStripMenuItem.Text = "Proveeduría"
        ' 
        ' btnOrdenes
        ' 
        btnOrdenes.BackgroundImage = CType(resources.GetObject("btnOrdenes.BackgroundImage"), Image)
        btnOrdenes.BackgroundImageLayout = ImageLayout.Zoom
        btnOrdenes.FlatStyle = FlatStyle.Popup
        btnOrdenes.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnOrdenes.Location = New Point(53, 60)
        btnOrdenes.Name = "btnOrdenes"
        btnOrdenes.Size = New Size(120, 55)
        btnOrdenes.TabIndex = 1
        btnOrdenes.Text = "Ordenes"
        btnOrdenes.TextAlign = ContentAlignment.MiddleRight
        btnOrdenes.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Zoom
        Panel1.Location = New Point(37, 157)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(300, 274)
        Panel1.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Aqua
        Panel2.Controls.Add(btnSync)
        Panel2.Controls.Add(btnEliminar)
        Panel2.Controls.Add(lstPendientes)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(425, 56)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(306, 404)
        Panel2.TabIndex = 3
        ' 
        ' btnSync
        ' 
        btnSync.BackgroundImage = CType(resources.GetObject("btnSync.BackgroundImage"), Image)
        btnSync.BackgroundImageLayout = ImageLayout.Zoom
        btnSync.Location = New Point(261, 58)
        btnSync.Name = "btnSync"
        btnSync.Size = New Size(32, 34)
        btnSync.TabIndex = 13
        btnSync.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.FromArgb(CByte(255), CByte(100), CByte(0))
        btnEliminar.BackgroundImage = CType(resources.GetObject("btnEliminar.BackgroundImage"), Image)
        btnEliminar.BackgroundImageLayout = ImageLayout.Zoom
        btnEliminar.Font = New Font("Segoe UI", 12F)
        btnEliminar.Location = New Point(192, 4)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(111, 47)
        btnEliminar.TabIndex = 12
        btnEliminar.Text = "Anular  "
        btnEliminar.TextAlign = ContentAlignment.MiddleRight
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' lstPendientes
        ' 
        lstPendientes.Font = New Font("Segoe UI", 11F)
        lstPendientes.FullRowSelect = True
        lstPendientes.GridLines = True
        lstPendientes.Location = New Point(15, 57)
        lstPendientes.MultiSelect = False
        lstPendientes.Name = "lstPendientes"
        lstPendientes.Size = New Size(279, 344)
        lstPendientes.TabIndex = 11
        lstPendientes.UseCompatibleStateImageBehavior = False
        lstPendientes.View = View.Details
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13F)
        Label1.Location = New Point(15, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(171, 25)
        Label1.TabIndex = 10
        Label1.Text = "Ordenes pendientes"
        ' 
        ' btnHistorial
        ' 
        btnHistorial.BackColor = Color.DarkGray
        btnHistorial.BackgroundImage = CType(resources.GetObject("btnHistorial.BackgroundImage"), Image)
        btnHistorial.BackgroundImageLayout = ImageLayout.Zoom
        btnHistorial.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnHistorial.Location = New Point(438, 4)
        btnHistorial.Name = "btnHistorial"
        btnHistorial.Size = New Size(122, 42)
        btnHistorial.TabIndex = 4
        btnHistorial.Text = "Historial"
        btnHistorial.TextAlign = ContentAlignment.MiddleRight
        btnHistorial.UseVisualStyleBackColor = False
        ' 
        ' btnFacturar
        ' 
        btnFacturar.BackgroundImage = CType(resources.GetObject("btnFacturar.BackgroundImage"), Image)
        btnFacturar.BackgroundImageLayout = ImageLayout.Zoom
        btnFacturar.FlatStyle = FlatStyle.Popup
        btnFacturar.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnFacturar.Location = New Point(203, 60)
        btnFacturar.Name = "btnFacturar"
        btnFacturar.Size = New Size(120, 55)
        btnFacturar.TabIndex = 5
        btnFacturar.Text = "Facturar"
        btnFacturar.TextAlign = ContentAlignment.MiddleRight
        btnFacturar.UseVisualStyleBackColor = True
        ' 
        ' lblUsuario
        ' 
        lblUsuario.AutoSize = True
        lblUsuario.Location = New Point(0, 445)
        lblUsuario.Name = "lblUsuario"
        lblUsuario.Size = New Size(41, 15)
        lblUsuario.TabIndex = 6
        lblUsuario.Text = "Label2"
        ' 
        ' ProveeduríaToolStripMenuItem
        ' 
        ProveeduríaToolStripMenuItem.BackColor = Color.PaleGreen
        ProveeduríaToolStripMenuItem.Name = "ProveeduríaToolStripMenuItem"
        ProveeduríaToolStripMenuItem.Size = New Size(82, 20)
        ProveeduríaToolStripMenuItem.Text = "Proveeduría"
        ' 
        ' frmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(731, 461)
        Controls.Add(lblUsuario)
        Controls.Add(btnFacturar)
        Controls.Add(btnHistorial)
        Controls.Add(Panel2)
        Controls.Add(btnOrdenes)
        Controls.Add(MenuStrip1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "frmPrincipal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Secretos de Miramar"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AgregarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnOrdenes As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSync As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents lstPendientes As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnHistorial As Button
    Friend WithEvents btnFacturar As Button
    Friend WithEvents lblUsuario As Label
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IngredientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsumosStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ProveeduriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveeduríaToolStripMenuItem As ToolStripMenuItem

End Class
