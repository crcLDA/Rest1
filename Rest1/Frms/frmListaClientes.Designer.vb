<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaClientes))
        lstDatos = New ListView()
        btnCancelar = New Button()
        SuspendLayout()
        ' 
        ' lstDatos
        ' 
        lstDatos.FullRowSelect = True
        lstDatos.GridLines = True
        lstDatos.Location = New Point(12, 12)
        lstDatos.MultiSelect = False
        lstDatos.Name = "lstDatos"
        lstDatos.Size = New Size(270, 419)
        lstDatos.TabIndex = 0
        lstDatos.UseCompatibleStateImageBehavior = False
        lstDatos.View = View.Details
        ' 
        ' btnCancelar
        ' 
        btnCancelar.BackColor = Color.Red
        btnCancelar.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnCancelar.ForeColor = SystemColors.ControlLightLight
        btnCancelar.Location = New Point(104, 435)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(89, 30)
        btnCancelar.TabIndex = 1
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' frmListaClientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(296, 477)
        Controls.Add(btnCancelar)
        Controls.Add(lstDatos)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmListaClientes"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmListaClientes"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lstDatos As ListView
    Friend WithEvents btnCancelar As Button
End Class
