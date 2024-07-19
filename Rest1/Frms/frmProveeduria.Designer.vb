<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveeduria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveeduria))
        lstIngredientes = New ListView()
        Label1 = New Label()
        Label2 = New Label()
        lstProveedores = New ListView()
        txtFiltroIngrediente = New TextBox()
        Label5 = New Label()
        txtFiltroProveedor = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        btnAgregar = New Button()
        lstProveeduria = New ListView()
        lblIngredienteSelec = New Label()
        lblProveedorSelec = New Label()
        btnRemover = New Button()
        SuspendLayout()
        ' 
        ' lstIngredientes
        ' 
        lstIngredientes.Font = New Font("Segoe UI", 11F)
        lstIngredientes.FullRowSelect = True
        lstIngredientes.GridLines = True
        lstIngredientes.Location = New Point(12, 82)
        lstIngredientes.MultiSelect = False
        lstIngredientes.Name = "lstIngredientes"
        lstIngredientes.Size = New Size(303, 171)
        lstIngredientes.TabIndex = 28
        lstIngredientes.UseCompatibleStateImageBehavior = False
        lstIngredientes.View = View.Details
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label1.Location = New Point(85, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(150, 19)
        Label1.TabIndex = 29
        Label1.Text = "Listado de productos"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label2.Location = New Point(85, 267)
        Label2.Name = "Label2"
        Label2.Size = New Size(168, 19)
        Label2.TabIndex = 31
        Label2.Text = "Listado de proveedores"
        ' 
        ' lstProveedores
        ' 
        lstProveedores.Font = New Font("Segoe UI", 11F)
        lstProveedores.FullRowSelect = True
        lstProveedores.GridLines = True
        lstProveedores.Location = New Point(12, 326)
        lstProveedores.MultiSelect = False
        lstProveedores.Name = "lstProveedores"
        lstProveedores.Size = New Size(303, 171)
        lstProveedores.TabIndex = 30
        lstProveedores.UseCompatibleStateImageBehavior = False
        lstProveedores.View = View.Details
        ' 
        ' txtFiltroIngrediente
        ' 
        txtFiltroIngrediente.BorderStyle = BorderStyle.FixedSingle
        txtFiltroIngrediente.Font = New Font("Segoe UI", 10F)
        txtFiltroIngrediente.Location = New Point(113, 51)
        txtFiltroIngrediente.Name = "txtFiltroIngrediente"
        txtFiltroIngrediente.Size = New Size(189, 25)
        txtFiltroIngrediente.TabIndex = 33
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F)
        Label5.Location = New Point(10, 55)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 15)
        Label5.TabIndex = 32
        Label5.Text = "Buscar producto:"
        ' 
        ' txtFiltroProveedor
        ' 
        txtFiltroProveedor.BorderStyle = BorderStyle.FixedSingle
        txtFiltroProveedor.Font = New Font("Segoe UI", 10F)
        txtFiltroProveedor.Location = New Point(126, 295)
        txtFiltroProveedor.Name = "txtFiltroProveedor"
        txtFiltroProveedor.Size = New Size(189, 25)
        txtFiltroProveedor.TabIndex = 35
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F)
        Label3.Location = New Point(18, 299)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 15)
        Label3.TabIndex = 34
        Label3.Text = "Buscar proveedor:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F)
        Label4.Location = New Point(351, 33)
        Label4.Name = "Label4"
        Label4.Size = New Size(142, 15)
        Label4.TabIndex = 36
        Label4.Text = "Ingrediente seleccionado:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F)
        Label6.Location = New Point(351, 60)
        Label6.Name = "Label6"
        Label6.Size = New Size(136, 15)
        Label6.TabIndex = 37
        Label6.Text = "Proveedor seleccionado:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label7.Location = New Point(412, 151)
        Label7.Name = "Label7"
        Label7.Size = New Size(186, 19)
        Label7.TabIndex = 39
        Label7.Text = "Proveedores del producto"
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(551, 91)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(92, 34)
        btnAgregar.TabIndex = 40
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' lstProveeduria
        ' 
        lstProveeduria.Font = New Font("Segoe UI", 11F)
        lstProveeduria.FullRowSelect = True
        lstProveeduria.GridLines = True
        lstProveeduria.Location = New Point(351, 183)
        lstProveeduria.MultiSelect = False
        lstProveeduria.Name = "lstProveeduria"
        lstProveeduria.Size = New Size(295, 248)
        lstProveeduria.TabIndex = 38
        lstProveeduria.UseCompatibleStateImageBehavior = False
        lstProveeduria.View = View.Details
        ' 
        ' lblIngredienteSelec
        ' 
        lblIngredienteSelec.AutoSize = True
        lblIngredienteSelec.Font = New Font("Segoe UI", 9F)
        lblIngredienteSelec.Location = New Point(495, 33)
        lblIngredienteSelec.Name = "lblIngredienteSelec"
        lblIngredienteSelec.Size = New Size(10, 15)
        lblIngredienteSelec.TabIndex = 41
        lblIngredienteSelec.Text = "."
        ' 
        ' lblProveedorSelec
        ' 
        lblProveedorSelec.AutoSize = True
        lblProveedorSelec.Font = New Font("Segoe UI", 9F)
        lblProveedorSelec.Location = New Point(488, 60)
        lblProveedorSelec.Name = "lblProveedorSelec"
        lblProveedorSelec.Size = New Size(10, 15)
        lblProveedorSelec.TabIndex = 42
        lblProveedorSelec.Text = "."
        ' 
        ' btnRemover
        ' 
        btnRemover.BackColor = Color.LightSalmon
        btnRemover.BackgroundImage = CType(resources.GetObject("btnRemover.BackgroundImage"), Image)
        btnRemover.BackgroundImageLayout = ImageLayout.Stretch
        btnRemover.Font = New Font("Segoe UI", 10F)
        btnRemover.ImageAlign = ContentAlignment.MiddleLeft
        btnRemover.Location = New Point(448, 437)
        btnRemover.Name = "btnRemover"
        btnRemover.Size = New Size(102, 39)
        btnRemover.TabIndex = 43
        btnRemover.Text = "Remover"
        btnRemover.TextAlign = ContentAlignment.MiddleRight
        btnRemover.UseVisualStyleBackColor = False
        ' 
        ' frmProveeduria
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(655, 503)
        Controls.Add(btnRemover)
        Controls.Add(lblProveedorSelec)
        Controls.Add(lblIngredienteSelec)
        Controls.Add(btnAgregar)
        Controls.Add(Label7)
        Controls.Add(lstProveeduria)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(txtFiltroProveedor)
        Controls.Add(Label3)
        Controls.Add(txtFiltroIngrediente)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(lstProveedores)
        Controls.Add(Label1)
        Controls.Add(lstIngredientes)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "frmProveeduria"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmProveeduria"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstIngredientes As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lstProveedores As ListView
    Friend WithEvents txtFiltroIngrediente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFiltroProveedor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lstProveeduria As ListView
    Friend WithEvents lblIngredienteSelec As Label
    Friend WithEvents lblProveedorSelec As Label
    Friend WithEvents btnRemover As Button
End Class
