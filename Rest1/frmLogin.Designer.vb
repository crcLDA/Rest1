<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        txtUsuario = New TextBox()
        btnIniciar = New Button()
        txtContrasena = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(16, 31)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(236, 23)
        txtUsuario.TabIndex = 0
        ' 
        ' btnIniciar
        ' 
        btnIniciar.BackgroundImage = CType(resources.GetObject("btnIniciar.BackgroundImage"), Image)
        btnIniciar.BackgroundImageLayout = ImageLayout.Stretch
        btnIniciar.ImageAlign = ContentAlignment.MiddleLeft
        btnIniciar.Location = New Point(69, 123)
        btnIniciar.Name = "btnIniciar"
        btnIniciar.Size = New Size(119, 36)
        btnIniciar.TabIndex = 2
        btnIniciar.Text = "Iniciar Sesión"
        btnIniciar.TextAlign = ContentAlignment.MiddleRight
        btnIniciar.UseVisualStyleBackColor = True
        ' 
        ' txtContrasena
        ' 
        txtContrasena.Location = New Point(16, 88)
        txtContrasena.Name = "txtContrasena"
        txtContrasena.PasswordChar = "*"c
        txtContrasena.Size = New Size(236, 23)
        txtContrasena.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Label1.Location = New Point(90, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 30)
        Label1.TabIndex = 3
        Label1.Text = "Bienvenido"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        Label2.Location = New Point(55, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(187, 25)
        Label2.TabIndex = 4
        Label2.Text = "Secretos de Miramar"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtUsuario)
        Panel1.Controls.Add(btnIniciar)
        Panel1.Controls.Add(txtContrasena)
        Panel1.Location = New Point(12, 78)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(270, 162)
        Panel1.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(16, 70)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 15)
        Label4.TabIndex = 4
        Label4.Text = "Contraseña"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(16, 13)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 15)
        Label3.TabIndex = 3
        Label3.Text = "Usuario"
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(293, 251)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents btnIniciar As Button
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
