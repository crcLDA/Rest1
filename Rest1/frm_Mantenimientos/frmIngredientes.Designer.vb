<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngredientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIngredientes))
        btnCerrar = New Button()
        btnAceptar = New Button()
        txtExistencias = New TextBox()
        txtNombre = New TextBox()
        txtId = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnCerrar
        ' 
        btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), Image)
        btnCerrar.BackgroundImageLayout = ImageLayout.Stretch
        btnCerrar.Location = New Point(214, 110)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(51, 51)
        btnCerrar.TabIndex = 28
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' btnAceptar
        ' 
        btnAceptar.BackgroundImage = CType(resources.GetObject("btnAceptar.BackgroundImage"), Image)
        btnAceptar.BackgroundImageLayout = ImageLayout.Stretch
        btnAceptar.Location = New Point(93, 110)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(51, 51)
        btnAceptar.TabIndex = 27
        btnAceptar.UseVisualStyleBackColor = True
        ' 
        ' txtExistencias
        ' 
        txtExistencias.Location = New Point(73, 69)
        txtExistencias.Name = "txtExistencias"
        txtExistencias.Size = New Size(117, 23)
        txtExistencias.TabIndex = 26
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(73, 40)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(265, 23)
        txtNombre.TabIndex = 25
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(40, 11)
        txtId.Name = "txtId"
        txtId.Size = New Size(69, 23)
        txtId.TabIndex = 24
        txtId.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 72)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 15)
        Label3.TabIndex = 23
        Label3.Text = "Teléfono:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(13, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 15)
        Label2.TabIndex = 22
        Label2.Text = "Nombre:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(21, 15)
        Label1.TabIndex = 21
        Label1.Text = "ID:"
        ' 
        ' frmIngredientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(364, 174)
        Controls.Add(btnCerrar)
        Controls.Add(btnAceptar)
        Controls.Add(txtExistencias)
        Controls.Add(txtNombre)
        Controls.Add(txtId)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "frmIngredientes"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mantenimiento de ingredientes"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtExistencias As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
