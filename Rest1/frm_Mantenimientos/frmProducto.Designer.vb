<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProducto))
        btnCerrar = New Button()
        btnAceptar = New Button()
        txtPrecio = New TextBox()
        txtNombre = New TextBox()
        txtId = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtDescripcion = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        cboCategoria = New ComboBox()
        chkActivo = New CheckBox()
        SuspendLayout()
        ' 
        ' btnCerrar
        ' 
        btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), Image)
        btnCerrar.BackgroundImageLayout = ImageLayout.Stretch
        btnCerrar.Location = New Point(213, 234)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(51, 51)
        btnCerrar.TabIndex = 15
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' btnAceptar
        ' 
        btnAceptar.BackgroundImage = CType(resources.GetObject("btnAceptar.BackgroundImage"), Image)
        btnAceptar.BackgroundImageLayout = ImageLayout.Stretch
        btnAceptar.Location = New Point(92, 234)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(51, 51)
        btnAceptar.TabIndex = 14
        btnAceptar.UseVisualStyleBackColor = True
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(72, 131)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(117, 23)
        txtPrecio.TabIndex = 13
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(72, 35)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(265, 23)
        txtNombre.TabIndex = 12
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(39, 6)
        txtId.Name = "txtId"
        txtId.Size = New Size(69, 23)
        txtId.TabIndex = 11
        txtId.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(11, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 15)
        Label3.TabIndex = 10
        Label3.Text = "Precio:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 15)
        Label2.TabIndex = 9
        Label2.Text = "Nombre:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(21, 15)
        Label1.TabIndex = 8
        Label1.Text = "ID:"
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(80, 64)
        txtDescripcion.Multiline = True
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(257, 61)
        txtDescripcion.TabIndex = 17
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 67)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 15)
        Label4.TabIndex = 16
        Label4.Text = "Descripción:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 163)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 15)
        Label5.TabIndex = 18
        Label5.Text = "Categoria:"
        ' 
        ' cboCategoria
        ' 
        cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList
        cboCategoria.FormattingEnabled = True
        cboCategoria.Location = New Point(79, 160)
        cboCategoria.Name = "cboCategoria"
        cboCategoria.Size = New Size(200, 23)
        cboCategoria.TabIndex = 19
        ' 
        ' chkActivo
        ' 
        chkActivo.AutoSize = True
        chkActivo.Checked = True
        chkActivo.CheckState = CheckState.Checked
        chkActivo.Location = New Point(12, 189)
        chkActivo.Name = "chkActivo"
        chkActivo.Size = New Size(60, 19)
        chkActivo.TabIndex = 20
        chkActivo.Text = "Activo"
        chkActivo.UseVisualStyleBackColor = True
        ' 
        ' frmProducto
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(359, 297)
        Controls.Add(chkActivo)
        Controls.Add(cboCategoria)
        Controls.Add(Label5)
        Controls.Add(txtDescripcion)
        Controls.Add(Label4)
        Controls.Add(btnCerrar)
        Controls.Add(btnAceptar)
        Controls.Add(txtPrecio)
        Controls.Add(txtNombre)
        Controls.Add(txtId)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "frmProducto"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mantenimiento de producto"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents chkActivo As CheckBox
End Class
