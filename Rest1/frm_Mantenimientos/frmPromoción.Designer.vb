<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuario))
        txtContrasena = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnCerrar = New Button()
        btnAceptar = New Button()
        txtUsuario = New TextBox()
        cboRol = New ComboBox()
        SuspendLayout()
        ' 
        ' txtContrasena
        ' 
        txtContrasena.Location = New Point(86, 41)
        txtContrasena.Name = "txtContrasena"
        txtContrasena.Size = New Size(251, 23)
        txtContrasena.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(11, 73)
        Label3.Name = "Label3"
        Label3.Size = New Size(27, 15)
        Label3.TabIndex = 39
        Label3.Text = "Rol:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 15)
        Label2.TabIndex = 38
        Label2.Text = "Contraseña:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 15)
        Label1.TabIndex = 37
        Label1.Text = "Usuario:"
        ' 
        ' btnCerrar
        ' 
        btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), Image)
        btnCerrar.BackgroundImageLayout = ImageLayout.Stretch
        btnCerrar.Location = New Point(207, 117)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(51, 51)
        btnCerrar.TabIndex = 5
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' btnAceptar
        ' 
        btnAceptar.BackgroundImage = CType(resources.GetObject("btnAceptar.BackgroundImage"), Image)
        btnAceptar.BackgroundImageLayout = ImageLayout.Stretch
        btnAceptar.Location = New Point(86, 117)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(51, 51)
        btnAceptar.TabIndex = 4
        btnAceptar.UseVisualStyleBackColor = True
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(68, 12)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(265, 23)
        txtUsuario.TabIndex = 1
        ' 
        ' cboRol
        ' 
        cboRol.DropDownStyle = ComboBoxStyle.DropDownList
        cboRol.FormattingEnabled = True
        cboRol.ItemHeight = 15
        cboRol.Location = New Point(68, 70)
        cboRol.Name = "cboRol"
        cboRol.Size = New Size(190, 23)
        cboRol.TabIndex = 46
        ' 
        ' frmUsuario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(357, 182)
        Controls.Add(cboRol)
        Controls.Add(txtUsuario)
        Controls.Add(btnCerrar)
        Controls.Add(btnAceptar)
        Controls.Add(txtContrasena)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmUsuario"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mantenimiento de usuario"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents cboRol As ComboBox
End Class
