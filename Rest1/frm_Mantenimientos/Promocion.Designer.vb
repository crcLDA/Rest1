<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Promocion
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
        txtId = New TextBox()
        txtNombre = New TextBox()
        txtDescripcion = New TextBox()
        txtDescuento = New TextBox()
        dtpFechaIncio = New DateTimePicker()
        dtpFechaFin = New DateTimePicker()
        cboProducto = New ComboBox()
        chkActivo = New CheckBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(325, 55)
        txtId.Name = "txtId"
        txtId.Size = New Size(100, 23)
        txtId.TabIndex = 0
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(325, 84)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(100, 23)
        txtNombre.TabIndex = 1
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(325, 127)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(100, 23)
        txtDescripcion.TabIndex = 2
        ' 
        ' txtDescuento
        ' 
        txtDescuento.Location = New Point(325, 171)
        txtDescuento.Name = "txtDescuento"
        txtDescuento.Size = New Size(100, 23)
        txtDescuento.TabIndex = 3
        ' 
        ' dtpFechaIncio
        ' 
        dtpFechaIncio.Location = New Point(588, 12)
        dtpFechaIncio.Name = "dtpFechaIncio"
        dtpFechaIncio.Size = New Size(200, 23)
        dtpFechaIncio.TabIndex = 4
        ' 
        ' dtpFechaFin
        ' 
        dtpFechaFin.Location = New Point(588, 64)
        dtpFechaFin.Name = "dtpFechaFin"
        dtpFechaFin.Size = New Size(200, 23)
        dtpFechaFin.TabIndex = 5
        ' 
        ' cboProducto
        ' 
        cboProducto.FormattingEnabled = True
        cboProducto.Location = New Point(325, 230)
        cboProducto.Name = "cboProducto"
        cboProducto.Size = New Size(121, 23)
        cboProducto.TabIndex = 6
        ' 
        ' chkActivo
        ' 
        chkActivo.AutoSize = True
        chkActivo.Location = New Point(165, 46)
        chkActivo.Name = "chkActivo"
        chkActivo.Size = New Size(85, 19)
        chkActivo.TabIndex = 7
        chkActivo.Text = "CheckBox1"
        chkActivo.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(280, 281)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 8
        Button1.Text = "Aceptar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(402, 281)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 9
        Button2.Text = "Cerrar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Promocion
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(chkActivo)
        Controls.Add(cboProducto)
        Controls.Add(dtpFechaFin)
        Controls.Add(dtpFechaIncio)
        Controls.Add(txtDescuento)
        Controls.Add(txtDescripcion)
        Controls.Add(txtNombre)
        Controls.Add(txtId)
        Name = "Promocion"
        Text = "Promocion"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtId As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents dtpFechaIncio As DateTimePicker
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents cboProducto As ComboBox
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
