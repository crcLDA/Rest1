<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerProvedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVerProvedores))
        btnIngrediente = New Button()
        btnProveedor = New Button()
        Panel1 = New Panel()
        txtFiltro = New TextBox()
        Label5 = New Label()
        lstFiltro = New ListView()
        Panel2 = New Panel()
        lstResultados = New ListView()
        lbl1 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnIngrediente
        ' 
        btnIngrediente.BackgroundImage = CType(resources.GetObject("btnIngrediente.BackgroundImage"), Image)
        btnIngrediente.BackgroundImageLayout = ImageLayout.Stretch
        btnIngrediente.Location = New Point(17, 18)
        btnIngrediente.Name = "btnIngrediente"
        btnIngrediente.Size = New Size(145, 45)
        btnIngrediente.TabIndex = 0
        btnIngrediente.Text = "Por ingrediente:"
        btnIngrediente.TextAlign = ContentAlignment.MiddleRight
        btnIngrediente.UseVisualStyleBackColor = True
        ' 
        ' btnProveedor
        ' 
        btnProveedor.BackgroundImage = CType(resources.GetObject("btnProveedor.BackgroundImage"), Image)
        btnProveedor.BackgroundImageLayout = ImageLayout.Stretch
        btnProveedor.Location = New Point(177, 18)
        btnProveedor.Name = "btnProveedor"
        btnProveedor.Size = New Size(145, 45)
        btnProveedor.TabIndex = 1
        btnProveedor.Text = "Por proveedor:"
        btnProveedor.TextAlign = ContentAlignment.MiddleRight
        btnProveedor.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLight
        Panel1.Controls.Add(btnIngrediente)
        Panel1.Controls.Add(btnProveedor)
        Panel1.Location = New Point(22, 10)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(339, 83)
        Panel1.TabIndex = 2
        ' 
        ' txtFiltro
        ' 
        txtFiltro.BorderStyle = BorderStyle.FixedSingle
        txtFiltro.Font = New Font("Segoe UI", 10F)
        txtFiltro.Location = New Point(155, 110)
        txtFiltro.Name = "txtFiltro"
        txtFiltro.Size = New Size(189, 25)
        txtFiltro.TabIndex = 36
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F)
        Label5.Location = New Point(39, 114)
        Label5.Name = "Label5"
        Label5.Size = New Size(111, 15)
        Label5.TabIndex = 35
        Label5.Text = "Buscar por nombre:"
        ' 
        ' lstFiltro
        ' 
        lstFiltro.Font = New Font("Segoe UI", 11F)
        lstFiltro.FullRowSelect = True
        lstFiltro.GridLines = True
        lstFiltro.Location = New Point(41, 141)
        lstFiltro.MultiSelect = False
        lstFiltro.Name = "lstFiltro"
        lstFiltro.Size = New Size(303, 233)
        lstFiltro.TabIndex = 34
        lstFiltro.UseCompatibleStateImageBehavior = False
        lstFiltro.View = View.Details
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(lstFiltro)
        Panel2.Controls.Add(txtFiltro)
        Panel2.Controls.Add(Panel1)
        Panel2.Controls.Add(Label5)
        Panel2.Location = New Point(12, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(376, 383)
        Panel2.TabIndex = 37
        ' 
        ' lstResultados
        ' 
        lstResultados.Font = New Font("Segoe UI", 11F)
        lstResultados.FullRowSelect = True
        lstResultados.GridLines = True
        lstResultados.Location = New Point(413, 40)
        lstResultados.MultiSelect = False
        lstResultados.Name = "lstResultados"
        lstResultados.Size = New Size(488, 355)
        lstResultados.TabIndex = 38
        lstResultados.UseCompatibleStateImageBehavior = False
        lstResultados.View = View.Details
        ' 
        ' lbl1
        ' 
        lbl1.AutoSize = True
        lbl1.Font = New Font("Segoe UI", 9F)
        lbl1.Location = New Point(413, 12)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(10, 15)
        lbl1.TabIndex = 37
        lbl1.Text = "."
        ' 
        ' frmVerProvedores
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(913, 403)
        Controls.Add(lbl1)
        Controls.Add(lstResultados)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "frmVerProvedores"
        StartPosition = FormStartPosition.CenterParent
        Text = "frmVerProvedores"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnIngrediente As Button
    Friend WithEvents btnProveedor As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lstFiltro As ListView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lstResultados As ListView
    Friend WithEvents lbl1 As Label
End Class
