<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.idclient = New System.Windows.Forms.ComboBox()
        Me.agregarButton = New System.Windows.Forms.Button()
        Me.clientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gamboadbDataSet = New Organzador.gamboadbDataSet()
        Me.clientTableAdapter = New Organzador.gamboadbDataSetTableAdapters.clientTableAdapter()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.editarButton = New System.Windows.Forms.Button()
        Me.cancelarButton = New System.Windows.Forms.Button()
        Me.nombreBox = New System.Windows.Forms.TextBox()
        Me.apellidosBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.calleBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.coloniaBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.codigoBox = New System.Windows.Forms.TextBox()
        Me.idBox = New System.Windows.Forms.TextBox()
        Me.groupclient = New System.Windows.Forms.GroupBox()
        Me.rfcBox = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.empresaBox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ciudadBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.estadoBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.correoClienteBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.celularBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.telefonoBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.fechaBox = New System.Windows.Forms.TextBox()
        Me.nuevoButton = New System.Windows.Forms.Button()
        Me.eliminarButton = New System.Windows.Forms.Button()
        Me.buscarNombre = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cotizacionButton = New System.Windows.Forms.Button()
        CType(Me.clientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gamboadbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupclient.SuspendLayout()
        Me.SuspendLayout()
        '
        'idclient
        '
        Me.idclient.FormattingEnabled = True
        Me.idclient.Location = New System.Drawing.Point(713, 75)
        Me.idclient.Name = "idclient"
        Me.idclient.Size = New System.Drawing.Size(69, 21)
        Me.idclient.TabIndex = 0
        '
        'agregarButton
        '
        Me.agregarButton.Location = New System.Drawing.Point(710, 191)
        Me.agregarButton.Name = "agregarButton"
        Me.agregarButton.Size = New System.Drawing.Size(146, 26)
        Me.agregarButton.TabIndex = 12
        Me.agregarButton.Text = "Agregar"
        Me.agregarButton.UseVisualStyleBackColor = True
        '
        'clientBindingSource
        '
        Me.clientBindingSource.DataMember = "client"
        Me.clientBindingSource.DataSource = Me.gamboadbDataSet
        '
        'gamboadbDataSet
        '
        Me.gamboadbDataSet.DataSetName = "gamboadbDataSet"
        Me.gamboadbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'clientTableAdapter
        '
        Me.clientTableAdapter.ClearBeforeFill = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(710, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Buscar por ID"
        '
        'editarButton
        '
        Me.editarButton.Location = New System.Drawing.Point(710, 230)
        Me.editarButton.Name = "editarButton"
        Me.editarButton.Size = New System.Drawing.Size(146, 26)
        Me.editarButton.TabIndex = 18
        Me.editarButton.Text = "Editar"
        Me.editarButton.UseVisualStyleBackColor = True
        '
        'cancelarButton
        '
        Me.cancelarButton.Location = New System.Drawing.Point(710, 262)
        Me.cancelarButton.Name = "cancelarButton"
        Me.cancelarButton.Size = New System.Drawing.Size(146, 26)
        Me.cancelarButton.TabIndex = 19
        Me.cancelarButton.Text = "Cancelar"
        Me.cancelarButton.UseVisualStyleBackColor = True
        '
        'nombreBox
        '
        Me.nombreBox.Location = New System.Drawing.Point(29, 100)
        Me.nombreBox.Name = "nombreBox"
        Me.nombreBox.Size = New System.Drawing.Size(210, 20)
        Me.nombreBox.TabIndex = 1
        '
        'apellidosBox
        '
        Me.apellidosBox.Location = New System.Drawing.Point(257, 100)
        Me.apellidosBox.Name = "apellidosBox"
        Me.apellidosBox.Size = New System.Drawing.Size(267, 20)
        Me.apellidosBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombe(s)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(254, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Apellidos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Calle y Numero"
        '
        'calleBox
        '
        Me.calleBox.Location = New System.Drawing.Point(29, 149)
        Me.calleBox.Name = "calleBox"
        Me.calleBox.Size = New System.Drawing.Size(135, 20)
        Me.calleBox.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(176, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Colonia"
        '
        'coloniaBox
        '
        Me.coloniaBox.Location = New System.Drawing.Point(176, 149)
        Me.coloniaBox.Name = "coloniaBox"
        Me.coloniaBox.Size = New System.Drawing.Size(348, 20)
        Me.coloniaBox.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Codigo Postal"
        '
        'codigoBox
        '
        Me.codigoBox.Location = New System.Drawing.Point(29, 206)
        Me.codigoBox.Name = "codigoBox"
        Me.codigoBox.Size = New System.Drawing.Size(81, 20)
        Me.codigoBox.TabIndex = 5
        '
        'idBox
        '
        Me.idBox.Location = New System.Drawing.Point(29, 45)
        Me.idBox.Name = "idBox"
        Me.idBox.Size = New System.Drawing.Size(64, 20)
        Me.idBox.TabIndex = 16
        '
        'groupclient
        '
        Me.groupclient.Controls.Add(Me.rfcBox)
        Me.groupclient.Controls.Add(Me.Label16)
        Me.groupclient.Controls.Add(Me.Label15)
        Me.groupclient.Controls.Add(Me.empresaBox)
        Me.groupclient.Controls.Add(Me.Label14)
        Me.groupclient.Controls.Add(Me.ciudadBox)
        Me.groupclient.Controls.Add(Me.Label13)
        Me.groupclient.Controls.Add(Me.estadoBox)
        Me.groupclient.Controls.Add(Me.Label12)
        Me.groupclient.Controls.Add(Me.correoClienteBox)
        Me.groupclient.Controls.Add(Me.Label11)
        Me.groupclient.Controls.Add(Me.celularBox)
        Me.groupclient.Controls.Add(Me.Label10)
        Me.groupclient.Controls.Add(Me.telefonoBox)
        Me.groupclient.Controls.Add(Me.Label8)
        Me.groupclient.Controls.Add(Me.idBox)
        Me.groupclient.Controls.Add(Me.codigoBox)
        Me.groupclient.Controls.Add(Me.fechaBox)
        Me.groupclient.Controls.Add(Me.Label6)
        Me.groupclient.Controls.Add(Me.coloniaBox)
        Me.groupclient.Controls.Add(Me.Label5)
        Me.groupclient.Controls.Add(Me.calleBox)
        Me.groupclient.Controls.Add(Me.Label4)
        Me.groupclient.Controls.Add(Me.Label3)
        Me.groupclient.Controls.Add(Me.Label2)
        Me.groupclient.Controls.Add(Me.Label1)
        Me.groupclient.Controls.Add(Me.apellidosBox)
        Me.groupclient.Controls.Add(Me.nombreBox)
        Me.groupclient.Location = New System.Drawing.Point(42, 30)
        Me.groupclient.Name = "groupclient"
        Me.groupclient.Size = New System.Drawing.Size(662, 350)
        Me.groupclient.TabIndex = 20
        Me.groupclient.TabStop = False
        Me.groupclient.Text = "Informacion de Cliente"
        '
        'rfcBox
        '
        Me.rfcBox.Location = New System.Drawing.Point(353, 302)
        Me.rfcBox.Name = "rfcBox"
        Me.rfcBox.Size = New System.Drawing.Size(171, 20)
        Me.rfcBox.TabIndex = 32
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(350, 286)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 13)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "RFC"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(28, 286)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 13)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Empresa"
        '
        'empresaBox
        '
        Me.empresaBox.Location = New System.Drawing.Point(29, 302)
        Me.empresaBox.Name = "empresaBox"
        Me.empresaBox.Size = New System.Drawing.Size(298, 20)
        Me.empresaBox.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(350, 239)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Ciudad"
        '
        'ciudadBox
        '
        Me.ciudadBox.Location = New System.Drawing.Point(353, 255)
        Me.ciudadBox.Name = "ciudadBox"
        Me.ciudadBox.Size = New System.Drawing.Size(171, 20)
        Me.ciudadBox.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(156, 239)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Estado"
        '
        'estadoBox
        '
        Me.estadoBox.Location = New System.Drawing.Point(156, 255)
        Me.estadoBox.Name = "estadoBox"
        Me.estadoBox.Size = New System.Drawing.Size(171, 20)
        Me.estadoBox.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(116, 190)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Correo Cliente"
        '
        'correoClienteBox
        '
        Me.correoClienteBox.Location = New System.Drawing.Point(116, 206)
        Me.correoClienteBox.Name = "correoClienteBox"
        Me.correoClienteBox.Size = New System.Drawing.Size(262, 20)
        Me.correoClienteBox.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(28, 239)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Celular"
        '
        'celularBox
        '
        Me.celularBox.Location = New System.Drawing.Point(30, 255)
        Me.celularBox.Name = "celularBox"
        Me.celularBox.Size = New System.Drawing.Size(109, 20)
        Me.celularBox.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(387, 190)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Telefono"
        '
        'telefonoBox
        '
        Me.telefonoBox.Location = New System.Drawing.Point(384, 206)
        Me.telefonoBox.Name = "telefonoBox"
        Me.telefonoBox.Size = New System.Drawing.Size(140, 20)
        Me.telefonoBox.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(518, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Fecha de ingreso"
        '
        'fechaBox
        '
        Me.fechaBox.Location = New System.Drawing.Point(521, 45)
        Me.fechaBox.Name = "fechaBox"
        Me.fechaBox.Size = New System.Drawing.Size(135, 20)
        Me.fechaBox.TabIndex = 17
        '
        'nuevoButton
        '
        Me.nuevoButton.Location = New System.Drawing.Point(710, 156)
        Me.nuevoButton.Name = "nuevoButton"
        Me.nuevoButton.Size = New System.Drawing.Size(146, 26)
        Me.nuevoButton.TabIndex = 21
        Me.nuevoButton.Text = "Nuevo"
        Me.nuevoButton.UseVisualStyleBackColor = True
        '
        'eliminarButton
        '
        Me.eliminarButton.Location = New System.Drawing.Point(710, 294)
        Me.eliminarButton.Name = "eliminarButton"
        Me.eliminarButton.Size = New System.Drawing.Size(146, 26)
        Me.eliminarButton.TabIndex = 22
        Me.eliminarButton.Text = "Eliminar"
        Me.eliminarButton.UseVisualStyleBackColor = True
        '
        'buscarNombre
        '
        Me.buscarNombre.FormattingEnabled = True
        Me.buscarNombre.Location = New System.Drawing.Point(710, 129)
        Me.buscarNombre.Name = "buscarNombre"
        Me.buscarNombre.Size = New System.Drawing.Size(146, 21)
        Me.buscarNombre.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(710, 113)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Buscar por Nombre y Apellido"
        '
        'cotizacionButton
        '
        Me.cotizacionButton.Location = New System.Drawing.Point(710, 326)
        Me.cotizacionButton.Name = "cotizacionButton"
        Me.cotizacionButton.Size = New System.Drawing.Size(146, 26)
        Me.cotizacionButton.TabIndex = 23
        Me.cotizacionButton.Text = "Realizar Cotizacion"
        Me.cotizacionButton.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1256, 563)
        Me.Controls.Add(Me.cotizacionButton)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.eliminarButton)
        Me.Controls.Add(Me.buscarNombre)
        Me.Controls.Add(Me.nuevoButton)
        Me.Controls.Add(Me.cancelarButton)
        Me.Controls.Add(Me.groupclient)
        Me.Controls.Add(Me.editarButton)
        Me.Controls.Add(Me.agregarButton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.idclient)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda client"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.clientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gamboadbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupclient.ResumeLayout(False)
        Me.groupclient.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents idclient As System.Windows.Forms.ComboBox
    Friend WithEvents agregarButton As System.Windows.Forms.Button
    Friend WithEvents gamboadbDataSet As Organzador.gamboadbDataSet
    Friend WithEvents clientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents clientTableAdapter As Organzador.gamboadbDataSetTableAdapters.clientTableAdapter
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents editarButton As System.Windows.Forms.Button
    Friend WithEvents cancelarButton As System.Windows.Forms.Button
    Friend WithEvents nombreBox As System.Windows.Forms.TextBox
    Friend WithEvents apellidosBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents calleBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents coloniaBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents codigoBox As System.Windows.Forms.TextBox
    Friend WithEvents idBox As System.Windows.Forms.TextBox
    Friend WithEvents groupclient As System.Windows.Forms.GroupBox
    Friend WithEvents nuevoButton As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents fechaBox As System.Windows.Forms.TextBox
    Friend WithEvents eliminarButton As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents buscarNombre As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents telefonoBox As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents celularBox As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents correoClienteBox As System.Windows.Forms.TextBox
    Friend WithEvents cotizacionButton As System.Windows.Forms.Button
    Friend WithEvents rfcBox As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents empresaBox As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ciudadBox As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents estadoBox As System.Windows.Forms.TextBox
End Class
