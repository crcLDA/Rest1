<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistorial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistorial))
        Label1 = New Label()
        chkNombre = New CheckBox()
        lstDatos = New ListView()
        btnImprimir = New Button()
        chkCedula = New CheckBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F)
        Label1.Location = New Point(168, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(180, 25)
        Label1.TabIndex = 0
        Label1.Text = "Historial de facturas"
        ' 
        ' chkNombre
        ' 
        chkNombre.AutoSize = True
        chkNombre.BackColor = SystemColors.ControlLight
        chkNombre.CheckAlign = ContentAlignment.MiddleRight
        chkNombre.Font = New Font("Segoe UI", 11F)
        chkNombre.Location = New Point(177, 37)
        chkNombre.Name = "chkNombre"
        chkNombre.Size = New Size(155, 24)
        chkNombre.TabIndex = 1
        chkNombre.Text = "¿Imprimir nombre?"
        chkNombre.TextAlign = ContentAlignment.MiddleCenter
        chkNombre.UseVisualStyleBackColor = False
        ' 
        ' lstDatos
        ' 
        lstDatos.FullRowSelect = True
        lstDatos.GridLines = True
        lstDatos.Location = New Point(12, 92)
        lstDatos.MultiSelect = False
        lstDatos.Name = "lstDatos"
        lstDatos.Size = New Size(474, 334)
        lstDatos.TabIndex = 2
        lstDatos.UseCompatibleStateImageBehavior = False
        lstDatos.View = View.Details
        ' 
        ' btnImprimir
        ' 
        btnImprimir.BackgroundImage = CType(resources.GetObject("btnImprimir.BackgroundImage"), Image)
        btnImprimir.BackgroundImageLayout = ImageLayout.Zoom
        btnImprimir.Font = New Font("Segoe UI", 11F)
        btnImprimir.Location = New Point(193, 435)
        btnImprimir.Name = "btnImprimir"
        btnImprimir.Size = New Size(113, 49)
        btnImprimir.TabIndex = 3
        btnImprimir.Text = "Imprimir"
        btnImprimir.TextAlign = ContentAlignment.MiddleRight
        btnImprimir.UseVisualStyleBackColor = True
        ' 
        ' chkCedula
        ' 
        chkCedula.AutoSize = True
        chkCedula.BackColor = Color.MistyRose
        chkCedula.CheckAlign = ContentAlignment.MiddleRight
        chkCedula.Font = New Font("Segoe UI", 11F)
        chkCedula.Location = New Point(177, 62)
        chkCedula.Name = "chkCedula"
        chkCedula.Size = New Size(147, 24)
        chkCedula.TabIndex = 4
        chkCedula.Text = "¿Imprimir cédula?"
        chkCedula.TextAlign = ContentAlignment.MiddleCenter
        chkCedula.UseVisualStyleBackColor = False
        ' 
        ' frmHistorial
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(498, 496)
        Controls.Add(chkCedula)
        Controls.Add(btnImprimir)
        Controls.Add(lstDatos)
        Controls.Add(chkNombre)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "frmHistorial"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Historial de pedidos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents chkNombre As CheckBox
    Friend WithEvents lstDatos As ListView
    Friend WithEvents btnImprimir As Button
    Friend WithEvents chkCedula As CheckBox
End Class
