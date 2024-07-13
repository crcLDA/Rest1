<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLista))
        btnAgregar = New Button()
        btnConsultar = New Button()
        btnEliminar = New Button()
        btnModificar = New Button()
        lstDatos = New ListView()
        SuspendLayout()
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackgroundImage = CType(resources.GetObject("btnAgregar.BackgroundImage"), Image)
        btnAgregar.BackgroundImageLayout = ImageLayout.Stretch
        btnAgregar.Location = New Point(189, 12)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(60, 60)
        btnAgregar.TabIndex = 0
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' btnConsultar
        ' 
        btnConsultar.BackgroundImage = CType(resources.GetObject("btnConsultar.BackgroundImage"), Image)
        btnConsultar.BackgroundImageLayout = ImageLayout.Stretch
        btnConsultar.Location = New Point(576, 12)
        btnConsultar.Name = "btnConsultar"
        btnConsultar.Size = New Size(60, 60)
        btnConsultar.TabIndex = 1
        btnConsultar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackgroundImage = CType(resources.GetObject("btnEliminar.BackgroundImage"), Image)
        btnEliminar.BackgroundImageLayout = ImageLayout.Stretch
        btnEliminar.Location = New Point(444, 12)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(60, 60)
        btnEliminar.TabIndex = 2
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnModificar
        ' 
        btnModificar.BackgroundImage = CType(resources.GetObject("btnModificar.BackgroundImage"), Image)
        btnModificar.BackgroundImageLayout = ImageLayout.Stretch
        btnModificar.Location = New Point(321, 12)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(60, 60)
        btnModificar.TabIndex = 3
        btnModificar.UseVisualStyleBackColor = True
        ' 
        ' lstDatos
        ' 
        lstDatos.Cursor = Cursors.Hand
        lstDatos.FullRowSelect = True
        lstDatos.GridLines = True
        lstDatos.Location = New Point(3, 82)
        lstDatos.MultiSelect = False
        lstDatos.Name = "lstDatos"
        lstDatos.Size = New Size(834, 360)
        lstDatos.TabIndex = 4
        lstDatos.UseCompatibleStateImageBehavior = False
        lstDatos.View = View.Details
        ' 
        ' frmLista
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(838, 444)
        Controls.Add(lstDatos)
        Controls.Add(btnModificar)
        Controls.Add(btnEliminar)
        Controls.Add(btnConsultar)
        Controls.Add(btnAgregar)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "frmLista"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Listado"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnConsultar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents lstDatos As ListView
End Class
