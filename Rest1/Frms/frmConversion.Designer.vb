<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConversion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConversion))
        Label1 = New Label()
        lstProductos = New ListView()
        Panel1 = New Panel()
        btnRemover = New Button()
        btnObtenerConversion = New Button()
        txtUoC = New TextBox()
        Label4 = New Label()
        Label2 = New Label()
        btnAgregar = New Button()
        cboInsumo = New ComboBox()
        lstConversiones = New ListView()
        Label3 = New Label()
        lblProducto = New Label()
        txtFiltro = New TextBox()
        Label5 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label1.Location = New Point(70, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(150, 19)
        Label1.TabIndex = 1
        Label1.Text = "Listado de productos"
        ' 
        ' lstProductos
        ' 
        lstProductos.Font = New Font("Segoe UI", 11F)
        lstProductos.FullRowSelect = True
        lstProductos.GridLines = True
        lstProductos.Location = New Point(1, 72)
        lstProductos.MultiSelect = False
        lstProductos.Name = "lstProductos"
        lstProductos.Size = New Size(291, 365)
        lstProductos.TabIndex = 5
        lstProductos.UseCompatibleStateImageBehavior = False
        lstProductos.View = View.Details
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnRemover)
        Panel1.Controls.Add(btnObtenerConversion)
        Panel1.Controls.Add(txtUoC)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(btnAgregar)
        Panel1.Controls.Add(cboInsumo)
        Panel1.Controls.Add(lstConversiones)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(lblProducto)
        Panel1.Location = New Point(304, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(317, 447)
        Panel1.TabIndex = 6
        ' 
        ' btnRemover
        ' 
        btnRemover.BackColor = Color.LightSalmon
        btnRemover.BackgroundImage = CType(resources.GetObject("btnRemover.BackgroundImage"), Image)
        btnRemover.BackgroundImageLayout = ImageLayout.Stretch
        btnRemover.Font = New Font("Segoe UI", 10F)
        btnRemover.ImageAlign = ContentAlignment.MiddleLeft
        btnRemover.Location = New Point(109, 397)
        btnRemover.Name = "btnRemover"
        btnRemover.Size = New Size(102, 39)
        btnRemover.TabIndex = 35
        btnRemover.Text = "Remover"
        btnRemover.TextAlign = ContentAlignment.MiddleRight
        btnRemover.UseVisualStyleBackColor = False
        ' 
        ' btnObtenerConversion
        ' 
        btnObtenerConversion.BackgroundImage = CType(resources.GetObject("btnObtenerConversion.BackgroundImage"), Image)
        btnObtenerConversion.BackgroundImageLayout = ImageLayout.Stretch
        btnObtenerConversion.Location = New Point(153, 72)
        btnObtenerConversion.Name = "btnObtenerConversion"
        btnObtenerConversion.Size = New Size(31, 34)
        btnObtenerConversion.TabIndex = 34
        btnObtenerConversion.UseVisualStyleBackColor = True
        ' 
        ' txtUoC
        ' 
        txtUoC.Location = New Point(71, 78)
        txtUoC.Name = "txtUoC"
        txtUoC.Size = New Size(79, 23)
        txtUoC.TabIndex = 32
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(1, 81)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 15)
        Label4.TabIndex = 31
        Label4.Text = "Conversión:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(1, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 15)
        Label2.TabIndex = 30
        Label2.Text = "Insumo:"
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(214, 82)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(92, 34)
        btnAgregar.TabIndex = 29
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' cboInsumo
        ' 
        cboInsumo.DropDownStyle = ComboBoxStyle.DropDownList
        cboInsumo.FormattingEnabled = True
        cboInsumo.Location = New Point(56, 42)
        cboInsumo.Name = "cboInsumo"
        cboInsumo.Size = New Size(247, 23)
        cboInsumo.TabIndex = 28
        ' 
        ' lstConversiones
        ' 
        lstConversiones.Font = New Font("Segoe UI", 11F)
        lstConversiones.FullRowSelect = True
        lstConversiones.GridLines = True
        lstConversiones.Location = New Point(7, 124)
        lstConversiones.MultiSelect = False
        lstConversiones.Name = "lstConversiones"
        lstConversiones.Size = New Size(303, 267)
        lstConversiones.TabIndex = 27
        lstConversiones.UseCompatibleStateImageBehavior = False
        lstConversiones.View = View.Details
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label3.Location = New Point(3, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 19)
        Label3.TabIndex = 26
        Label3.Text = "Producto selec:"
        ' 
        ' lblProducto
        ' 
        lblProducto.AutoSize = True
        lblProducto.Location = New Point(121, 11)
        lblProducto.Name = "lblProducto"
        lblProducto.Size = New Size(10, 15)
        lblProducto.TabIndex = 25
        lblProducto.Text = "."
        ' 
        ' txtFiltro
        ' 
        txtFiltro.BorderStyle = BorderStyle.FixedSingle
        txtFiltro.Font = New Font("Segoe UI", 10F)
        txtFiltro.Location = New Point(104, 43)
        txtFiltro.Name = "txtFiltro"
        txtFiltro.Size = New Size(189, 25)
        txtFiltro.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F)
        Label5.Location = New Point(1, 47)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 15)
        Label5.TabIndex = 7
        Label5.Text = "Buscar producto:"
        ' 
        ' frmConversion
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(622, 449)
        Controls.Add(txtFiltro)
        Controls.Add(Label5)
        Controls.Add(Panel1)
        Controls.Add(lstProductos)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "frmConversion"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Conversión de productos"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents lstProductos As ListView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtUoC As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents cboInsumo As ComboBox
    Friend WithEvents lstConversiones As ListView
    Friend WithEvents Label3 As Label
    Friend WithEvents lblProducto As Label
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnObtenerConversion As Button
    Friend WithEvents btnRemover As Button
End Class
