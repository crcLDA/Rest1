<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalcularConversion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalcularConversion))
        Label1 = New Label()
        txtPorciones = New TextBox()
        txtConversion = New TextBox()
        Label2 = New Label()
        btnCerrar = New Button()
        btnAceptar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(8, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(279, 15)
        Label1.TabIndex = 0
        Label1.Text = "Ingrese las porciones que alcanzan para el producto"
        ' 
        ' txtPorciones
        ' 
        txtPorciones.Location = New Point(293, 8)
        txtPorciones.Name = "txtPorciones"
        txtPorciones.Size = New Size(62, 23)
        txtPorciones.TabIndex = 1
        ' 
        ' txtConversion
        ' 
        txtConversion.Location = New Point(132, 38)
        txtConversion.Name = "txtConversion"
        txtConversion.Size = New Size(100, 23)
        txtConversion.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(8, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 15)
        Label2.TabIndex = 2
        Label2.Text = "Conversión sugerida:"
        ' 
        ' btnCerrar
        ' 
        btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), Image)
        btnCerrar.BackgroundImageLayout = ImageLayout.Stretch
        btnCerrar.Location = New Point(236, 78)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(51, 51)
        btnCerrar.TabIndex = 9
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' btnAceptar
        ' 
        btnAceptar.BackgroundImage = CType(resources.GetObject("btnAceptar.BackgroundImage"), Image)
        btnAceptar.BackgroundImageLayout = ImageLayout.Stretch
        btnAceptar.Location = New Point(115, 78)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(51, 51)
        btnAceptar.TabIndex = 8
        btnAceptar.UseVisualStyleBackColor = True
        ' 
        ' frmCalcularConversion
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(400, 138)
        Controls.Add(btnCerrar)
        Controls.Add(btnAceptar)
        Controls.Add(txtConversion)
        Controls.Add(Label2)
        Controls.Add(txtPorciones)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "frmCalcularConversion"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Calcular la porción"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtPorciones As TextBox
    Friend WithEvents txtConversion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnAceptar As Button
End Class
