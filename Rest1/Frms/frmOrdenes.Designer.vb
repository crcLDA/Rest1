<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenes))
        Panel1 = New Panel()
        lstProductos = New ListView()
        txtFiltro = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        btnBuscar = New Button()
        txtUsuario = New TextBox()
        Label4 = New Label()
        Panel3 = New Panel()
        lblTotal = New Label()
        Label5 = New Label()
        btnCrearFactura = New Button()
        btnCrearOrden = New Button()
        btnEliminar = New Button()
        lstPedido = New ListView()
        Label3 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Aqua
        Panel1.Controls.Add(lstProductos)
        Panel1.Controls.Add(txtFiltro)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(401, 532)
        Panel1.TabIndex = 0
        ' 
        ' lstProductos
        ' 
        lstProductos.Font = New Font("Segoe UI", 11F)
        lstProductos.FullRowSelect = True
        lstProductos.GridLines = True
        lstProductos.Location = New Point(12, 113)
        lstProductos.MultiSelect = False
        lstProductos.Name = "lstProductos"
        lstProductos.Size = New Size(371, 403)
        lstProductos.TabIndex = 4
        lstProductos.UseCompatibleStateImageBehavior = False
        lstProductos.View = View.Details
        ' 
        ' txtFiltro
        ' 
        txtFiltro.BorderStyle = BorderStyle.FixedSingle
        txtFiltro.Font = New Font("Segoe UI", 10F)
        txtFiltro.Location = New Point(144, 72)
        txtFiltro.Name = "txtFiltro"
        txtFiltro.Size = New Size(230, 25)
        txtFiltro.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(12, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 21)
        Label2.TabIndex = 2
        Label2.Text = "Buscar producto:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.Location = New Point(47, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(310, 37)
        Label1.TabIndex = 1
        Label1.Text = "Seleccione los productos"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.PeachPuff
        Panel2.Controls.Add(btnBuscar)
        Panel2.Controls.Add(txtUsuario)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(btnCrearOrden)
        Panel2.Controls.Add(btnEliminar)
        Panel2.Controls.Add(lstPedido)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(401, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(399, 532)
        Panel2.TabIndex = 1
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackgroundImage = CType(resources.GetObject("btnBuscar.BackgroundImage"), Image)
        btnBuscar.BackgroundImageLayout = ImageLayout.Zoom
        btnBuscar.Location = New Point(303, 8)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(75, 27)
        btnBuscar.TabIndex = 11
        btnBuscar.Text = "Buscar"
        btnBuscar.TextAlign = ContentAlignment.MiddleRight
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Enabled = False
        txtUsuario.Font = New Font("Segoe UI", 11F)
        txtUsuario.Location = New Point(141, 7)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(156, 27)
        txtUsuario.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(3, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(141, 21)
        Label4.TabIndex = 5
        Label4.Text = "Nombre de cliente:"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LightSteelBlue
        Panel3.Controls.Add(lblTotal)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(btnCrearFactura)
        Panel3.Location = New Point(15, 411)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(371, 112)
        Panel3.TabIndex = 9
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.BackColor = Color.Lavender
        lblTotal.Font = New Font("Segoe UI", 16F)
        lblTotal.Location = New Point(204, 4)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(25, 30)
        lblTotal.TabIndex = 13
        lblTotal.Text = "0"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14F)
        Label5.Location = New Point(151, 8)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 25)
        Label5.TabIndex = 12
        Label5.Text = "Total:"
        ' 
        ' btnCrearFactura
        ' 
        btnCrearFactura.BackgroundImage = CType(resources.GetObject("btnCrearFactura.BackgroundImage"), Image)
        btnCrearFactura.BackgroundImageLayout = ImageLayout.Zoom
        btnCrearFactura.Font = New Font("Segoe UI", 12F)
        btnCrearFactura.Location = New Point(103, 53)
        btnCrearFactura.Name = "btnCrearFactura"
        btnCrearFactura.Size = New Size(164, 52)
        btnCrearFactura.TabIndex = 11
        btnCrearFactura.Text = "Crear Factura"
        btnCrearFactura.TextAlign = ContentAlignment.MiddleRight
        btnCrearFactura.UseVisualStyleBackColor = True
        ' 
        ' btnCrearOrden
        ' 
        btnCrearOrden.BackgroundImage = CType(resources.GetObject("btnCrearOrden.BackgroundImage"), Image)
        btnCrearOrden.BackgroundImageLayout = ImageLayout.Zoom
        btnCrearOrden.Font = New Font("Segoe UI", 12F)
        btnCrearOrden.Location = New Point(118, 345)
        btnCrearOrden.Name = "btnCrearOrden"
        btnCrearOrden.Size = New Size(156, 49)
        btnCrearOrden.TabIndex = 8
        btnCrearOrden.Text = "Crear Orden"
        btnCrearOrden.TextAlign = ContentAlignment.MiddleRight
        btnCrearOrden.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.FromArgb(CByte(255), CByte(100), CByte(0))
        btnEliminar.BackgroundImage = CType(resources.GetObject("btnEliminar.BackgroundImage"), Image)
        btnEliminar.BackgroundImageLayout = ImageLayout.Zoom
        btnEliminar.Font = New Font("Segoe UI", 12F)
        btnEliminar.Location = New Point(275, 39)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(111, 43)
        btnEliminar.TabIndex = 7
        btnEliminar.Text = "Eliminar"
        btnEliminar.TextAlign = ContentAlignment.MiddleRight
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' lstPedido
        ' 
        lstPedido.Font = New Font("Segoe UI", 11F)
        lstPedido.FullRowSelect = True
        lstPedido.GridLines = True
        lstPedido.Location = New Point(6, 83)
        lstPedido.MultiSelect = False
        lstPedido.Name = "lstPedido"
        lstPedido.Size = New Size(371, 261)
        lstPedido.TabIndex = 6
        lstPedido.UseCompatibleStateImageBehavior = False
        lstPedido.View = View.Details
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 20F)
        Label3.Location = New Point(6, 39)
        Label3.Name = "Label3"
        Label3.Size = New Size(237, 37)
        Label3.TabIndex = 5
        Label3.Text = "Detalle del pedido"
        ' 
        ' frmOrdenes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 532)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "frmOrdenes"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Crear orden"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lstProductos As ListView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lstPedido As ListView
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCrearOrden As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCrearFactura As Button
    Friend WithEvents btnBuscar As Button
End Class
