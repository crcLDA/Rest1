<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCliente))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtId = New TextBox()
        txtNombre = New TextBox()
        txtTelefono = New TextBox()
        btnAceptar = New Button()
        btnCerrar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(17, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 15)
        Label1.TabIndex = 0
        Label1.Text = "Identificación:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 15)
        Label2.TabIndex = 1
        Label2.Text = "Nombre:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(17, 67)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 15)
        Label3.TabIndex = 2
        Label3.Text = "Teléfono:"
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(105, 3)
        txtId.Name = "txtId"
        txtId.Size = New Size(167, 23)
        txtId.TabIndex = 3
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(77, 32)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(265, 23)
        txtNombre.TabIndex = 4
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(78, 64)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(117, 23)
        txtTelefono.TabIndex = 5
        ' 
        ' btnAceptar
        ' 
        btnAceptar.BackgroundImage = CType(resources.GetObject("btnAceptar.BackgroundImage"), Image)
        btnAceptar.BackgroundImageLayout = ImageLayout.Stretch
        btnAceptar.Location = New Point(88, 102)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(51, 51)
        btnAceptar.TabIndex = 6
        btnAceptar.UseVisualStyleBackColor = True
        ' 
        ' btnCerrar
        ' 
        btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), Image)
        btnCerrar.BackgroundImageLayout = ImageLayout.Stretch
        btnCerrar.Location = New Point(209, 102)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(51, 51)
        btnCerrar.TabIndex = 7
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' frmCliente
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(361, 161)
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
        Name = "frmCliente"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mantenimiento de cliente"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCerrar As Button
End Class
