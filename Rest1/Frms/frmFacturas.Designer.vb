<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacturas))
        Panel1 = New Panel()
        lstOrdenPendientes = New ListView()
        Label1 = New Label()
        Panel2 = New Panel()
        btnSeleccionarTodo = New Button()
        lblNombre = New Label()
        Label4 = New Label()
        lstProdPendientes = New ListView()
        Label2 = New Label()
        Panel3 = New Panel()
        lblSubtotal = New Label()
        Label6 = New Label()
        btnFacturar = New Button()
        btnEliminar = New Button()
        lstProdFactura = New ListView()
        Label3 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lstOrdenPendientes)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-2, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(335, 337)
        Panel1.TabIndex = 0
        ' 
        ' lstOrdenPendientes
        ' 
        lstOrdenPendientes.Font = New Font("Segoe UI", 10F)
        lstOrdenPendientes.FullRowSelect = True
        lstOrdenPendientes.GridLines = True
        lstOrdenPendientes.Location = New Point(14, 51)
        lstOrdenPendientes.MultiSelect = False
        lstOrdenPendientes.Name = "lstOrdenPendientes"
        lstOrdenPendientes.Size = New Size(306, 273)
        lstOrdenPendientes.TabIndex = 1
        lstOrdenPendientes.UseCompatibleStateImageBehavior = False
        lstOrdenPendientes.View = View.Details
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label1.Location = New Point(67, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(189, 25)
        Label1.TabIndex = 0
        Label1.Text = "Ordenes pendientes"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnSeleccionarTodo)
        Panel2.Controls.Add(lblNombre)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(lstProdPendientes)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(339, 1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(335, 337)
        Panel2.TabIndex = 2
        ' 
        ' btnSeleccionarTodo
        ' 
        btnSeleccionarTodo.BackColor = SystemColors.Info
        btnSeleccionarTodo.BackgroundImage = CType(resources.GetObject("btnSeleccionarTodo.BackgroundImage"), Image)
        btnSeleccionarTodo.BackgroundImageLayout = ImageLayout.Zoom
        btnSeleccionarTodo.Font = New Font("Segoe UI", 11F)
        btnSeleccionarTodo.Location = New Point(84, 286)
        btnSeleccionarTodo.Name = "btnSeleccionarTodo"
        btnSeleccionarTodo.Size = New Size(178, 41)
        btnSeleccionarTodo.TabIndex = 4
        btnSeleccionarTodo.Text = "   Seleccionar todo"
        btnSeleccionarTodo.TextAlign = ContentAlignment.MiddleRight
        btnSeleccionarTodo.UseVisualStyleBackColor = False
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.BackColor = SystemColors.ActiveCaptionText
        lblNombre.Font = New Font("Segoe UI", 11F)
        lblNombre.ForeColor = SystemColors.Info
        lblNombre.Location = New Point(84, 42)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(15, 20)
        lblNombre.TabIndex = 3
        lblNombre.Text = "-"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F)
        Label4.Location = New Point(12, 42)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 20)
        Label4.TabIndex = 2
        Label4.Text = "Orden de:"
        ' 
        ' lstProdPendientes
        ' 
        lstProdPendientes.Font = New Font("Segoe UI", 10F)
        lstProdPendientes.FullRowSelect = True
        lstProdPendientes.GridLines = True
        lstProdPendientes.Location = New Point(12, 65)
        lstProdPendientes.MultiSelect = False
        lstProdPendientes.Name = "lstProdPendientes"
        lstProdPendientes.Size = New Size(306, 212)
        lstProdPendientes.TabIndex = 1
        lstProdPendientes.UseCompatibleStateImageBehavior = False
        lstProdPendientes.View = View.Details
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label2.Location = New Point(11, 13)
        Label2.Name = "Label2"
        Label2.Size = New Size(313, 25)
        Label2.TabIndex = 0
        Label2.Text = "Productos pendientes de la orden"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(lblSubtotal)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(btnFacturar)
        Panel3.Controls.Add(btnEliminar)
        Panel3.Controls.Add(lstProdFactura)
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(680, 1)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(314, 337)
        Panel3.TabIndex = 3
        ' 
        ' lblSubtotal
        ' 
        lblSubtotal.AutoSize = True
        lblSubtotal.BackColor = Color.Transparent
        lblSubtotal.Font = New Font("Segoe UI", 11F)
        lblSubtotal.Location = New Point(89, 265)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Size = New Size(17, 20)
        lblSubtotal.TabIndex = 16
        lblSubtotal.Text = "0"
        lblSubtotal.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11F)
        Label6.Location = New Point(5, 265)
        Label6.Name = "Label6"
        Label6.Size = New Size(88, 20)
        Label6.TabIndex = 15
        Label6.Text = "Subtotal:   ₡"
        ' 
        ' btnFacturar
        ' 
        btnFacturar.BackColor = SystemColors.GradientInactiveCaption
        btnFacturar.BackgroundImage = CType(resources.GetObject("btnFacturar.BackgroundImage"), Image)
        btnFacturar.BackgroundImageLayout = ImageLayout.Zoom
        btnFacturar.FlatStyle = FlatStyle.Popup
        btnFacturar.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnFacturar.Location = New Point(101, 293)
        btnFacturar.Name = "btnFacturar"
        btnFacturar.Size = New Size(120, 41)
        btnFacturar.TabIndex = 14
        btnFacturar.Text = "Facturar"
        btnFacturar.TextAlign = ContentAlignment.MiddleRight
        btnFacturar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.FromArgb(CByte(255), CByte(100), CByte(0))
        btnEliminar.BackgroundImage = CType(resources.GetObject("btnEliminar.BackgroundImage"), Image)
        btnEliminar.BackgroundImageLayout = ImageLayout.Zoom
        btnEliminar.Font = New Font("Segoe UI", 12F)
        btnEliminar.Location = New Point(187, 3)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(111, 47)
        btnEliminar.TabIndex = 13
        btnEliminar.Text = "Quitar   "
        btnEliminar.TextAlign = ContentAlignment.MiddleRight
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' lstProdFactura
        ' 
        lstProdFactura.Font = New Font("Segoe UI", 10F)
        lstProdFactura.FullRowSelect = True
        lstProdFactura.GridLines = True
        lstProdFactura.Location = New Point(5, 51)
        lstProdFactura.MultiSelect = False
        lstProdFactura.Name = "lstProdFactura"
        lstProdFactura.Size = New Size(306, 212)
        lstProdFactura.TabIndex = 1
        lstProdFactura.UseCompatibleStateImageBehavior = False
        lstProdFactura.View = View.Details
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label3.Location = New Point(36, 13)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 25)
        Label3.TabIndex = 0
        Label3.Text = "Facturar"
        ' 
        ' frmFacturas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(994, 338)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "frmFacturas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Facturación"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lstOrdenPendientes As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lstProdPendientes As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lstProdFactura As ListView
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnSeleccionarTodo As Button
    Friend WithEvents lblNombre As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnFacturar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lblSubtotal As Label
End Class
