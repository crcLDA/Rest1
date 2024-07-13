<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedor))
        txtDireccion = New TextBox()
        Label4 = New Label()
        btnCerrar = New Button()
        btnAceptar = New Button()
        txtTelefono = New TextBox()
        txtNombre = New TextBox()
        txtId = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(78, 99)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(265, 23)
        txtDireccion.TabIndex = 40
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(18, 102)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 15)
        Label4.TabIndex = 39
        Label4.Text = "Dirección:"
        ' 
        ' btnCerrar
        ' 
        btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), Image)
        btnCerrar.BackgroundImageLayout = ImageLayout.Stretch
        btnCerrar.Location = New Point(219, 135)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(51, 51)
        btnCerrar.TabIndex = 38
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' btnAceptar
        ' 
        btnAceptar.BackgroundImage = CType(resources.GetObject("btnAceptar.BackgroundImage"), Image)
        btnAceptar.BackgroundImageLayout = ImageLayout.Stretch
        btnAceptar.Location = New Point(98, 135)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(51, 51)
        btnAceptar.TabIndex = 37
        btnAceptar.UseVisualStyleBackColor = True
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(78, 70)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(154, 23)
        txtTelefono.TabIndex = 36
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(78, 41)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(265, 23)
        txtNombre.TabIndex = 35
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(45, 12)
        txtId.Name = "txtId"
        txtId.Size = New Size(69, 23)
        txtId.TabIndex = 34
        txtId.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(17, 73)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 15)
        Label3.TabIndex = 33
        Label3.Text = "Teléfono:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(18, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 15)
        Label2.TabIndex = 32
        Label2.Text = "Nombre:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(18, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(21, 15)
        Label1.TabIndex = 31
        Label1.Text = "ID:"
        ' 
        ' frmProveedor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(359, 194)
        Controls.Add(txtDireccion)
        Controls.Add(Label4)
        Controls.Add(btnCerrar)
        Controls.Add(btnAceptar)
        Controls.Add(txtTelefono)
        Controls.Add(txtNombre)
        Controls.Add(txtId)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "frmProveedor"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mantenimiento de proveedor"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
