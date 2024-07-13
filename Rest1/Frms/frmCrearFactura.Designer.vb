<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrearFactura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCrearFactura))
        Label6 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        txtDescuento = New TextBox()
        txtTotal = New TextBox()
        txtSubtotal = New TextBox()
        btnFacturar = New Button()
        chkNombre = New CheckBox()
        chkCedula = New CheckBox()
        btnCancelar = New Button()
        Label3 = New Label()
        txtPago = New TextBox()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11F)
        Label6.Location = New Point(26, 15)
        Label6.Name = "Label6"
        Label6.Size = New Size(88, 20)
        Label6.TabIndex = 16
        Label6.Text = "Subtotal:   ₡"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F)
        Label1.Location = New Point(12, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 20)
        Label1.TabIndex = 17
        Label1.Text = "Descuento:   ₡"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F)
        Label2.Location = New Point(49, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 20)
        Label2.TabIndex = 18
        Label2.Text = "Total:   ₡"
        ' 
        ' txtDescuento
        ' 
        txtDescuento.Location = New Point(120, 41)
        txtDescuento.Name = "txtDescuento"
        txtDescuento.Size = New Size(89, 23)
        txtDescuento.TabIndex = 22
        txtDescuento.Text = "0"
        ' 
        ' txtTotal
        ' 
        txtTotal.Enabled = False
        txtTotal.Location = New Point(120, 70)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(89, 23)
        txtTotal.TabIndex = 23
        txtTotal.Text = "0"
        ' 
        ' txtSubtotal
        ' 
        txtSubtotal.Enabled = False
        txtSubtotal.Location = New Point(120, 12)
        txtSubtotal.Name = "txtSubtotal"
        txtSubtotal.Size = New Size(89, 23)
        txtSubtotal.TabIndex = 24
        txtSubtotal.Text = "0"
        ' 
        ' btnFacturar
        ' 
        btnFacturar.BackColor = SystemColors.GradientInactiveCaption
        btnFacturar.BackgroundImage = CType(resources.GetObject("btnFacturar.BackgroundImage"), Image)
        btnFacturar.BackgroundImageLayout = ImageLayout.Zoom
        btnFacturar.FlatStyle = FlatStyle.Popup
        btnFacturar.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnFacturar.Location = New Point(127, 222)
        btnFacturar.Name = "btnFacturar"
        btnFacturar.Size = New Size(107, 41)
        btnFacturar.TabIndex = 25
        btnFacturar.Text = "Facturar"
        btnFacturar.TextAlign = ContentAlignment.MiddleRight
        btnFacturar.UseVisualStyleBackColor = False
        ' 
        ' chkNombre
        ' 
        chkNombre.AutoSize = True
        chkNombre.CheckAlign = ContentAlignment.MiddleRight
        chkNombre.Font = New Font("Segoe UI", 11F)
        chkNombre.Location = New Point(38, 160)
        chkNombre.Name = "chkNombre"
        chkNombre.Size = New Size(155, 24)
        chkNombre.TabIndex = 26
        chkNombre.Text = "¿Imprimir nombre?"
        chkNombre.TextAlign = ContentAlignment.MiddleCenter
        chkNombre.UseVisualStyleBackColor = True
        ' 
        ' chkCedula
        ' 
        chkCedula.AutoSize = True
        chkCedula.CheckAlign = ContentAlignment.MiddleRight
        chkCedula.Font = New Font("Segoe UI", 11F)
        chkCedula.Location = New Point(46, 190)
        chkCedula.Name = "chkCedula"
        chkCedula.Size = New Size(147, 24)
        chkCedula.TabIndex = 27
        chkCedula.Text = "¿Imprimir cédula?"
        chkCedula.TextAlign = ContentAlignment.MiddleCenter
        chkCedula.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.BackColor = Color.Coral
        btnCancelar.BackgroundImage = CType(resources.GetObject("btnCancelar.BackgroundImage"), Image)
        btnCancelar.BackgroundImageLayout = ImageLayout.Zoom
        btnCancelar.FlatStyle = FlatStyle.Popup
        btnCancelar.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnCancelar.Location = New Point(7, 222)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(107, 41)
        btnCancelar.TabIndex = 28
        btnCancelar.Text = "Cancelar"
        btnCancelar.TextAlign = ContentAlignment.MiddleRight
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F)
        Label3.Location = New Point(7, 121)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 20)
        Label3.TabIndex = 29
        Label3.Text = "Paga con:   ₡"
        ' 
        ' txtPago
        ' 
        txtPago.Font = New Font("Segoe UI", 11F)
        txtPago.Location = New Point(104, 118)
        txtPago.Name = "txtPago"
        txtPago.Size = New Size(89, 27)
        txtPago.TabIndex = 30
        ' 
        ' frmCrearFactura
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        ClientSize = New Size(246, 268)
        Controls.Add(txtPago)
        Controls.Add(Label3)
        Controls.Add(btnCancelar)
        Controls.Add(chkCedula)
        Controls.Add(chkNombre)
        Controls.Add(btnFacturar)
        Controls.Add(txtSubtotal)
        Controls.Add(txtTotal)
        Controls.Add(txtDescuento)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label6)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmCrearFactura"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Crear factura"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents btnFacturar As Button
    Friend WithEvents chkNombre As CheckBox
    Friend WithEvents chkCedula As CheckBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPago As TextBox
End Class
