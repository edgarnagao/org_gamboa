<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProducts
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
        Me.descriptionBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nameProductBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.idProductoBox = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.widthBox = New System.Windows.Forms.TextBox()
        Me.weighBox = New System.Windows.Forms.TextBox()
        Me.longBox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.highBox = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.fourthPrice = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.thirdPrice = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.secondPrice = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.firstPrice = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.eliminarButton = New System.Windows.Forms.Button()
        Me.nuevoButton = New System.Windows.Forms.Button()
        Me.cancelarButton = New System.Windows.Forms.Button()
        Me.editarButton = New System.Windows.Forms.Button()
        Me.agregarButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.idProduct = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.typeBox = New System.Windows.Forms.TextBox()
        Me.saveModification = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'descriptionBox
        '
        Me.descriptionBox.Location = New System.Drawing.Point(75, 181)
        Me.descriptionBox.Multiline = True
        Me.descriptionBox.Name = "descriptionBox"
        Me.descriptionBox.Size = New System.Drawing.Size(358, 69)
        Me.descriptionBox.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(72, 165)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(167, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Descipcion adicional del producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nombre de producto"
        '
        'nameProductBox
        '
        Me.nameProductBox.Location = New System.Drawing.Point(182, 73)
        Me.nameProductBox.Name = "nameProductBox"
        Me.nameProductBox.Size = New System.Drawing.Size(240, 20)
        Me.nameProductBox.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Id producto (Codigo)"
        '
        'idProductoBox
        '
        Me.idProductoBox.Location = New System.Drawing.Point(181, 34)
        Me.idProductoBox.Name = "idProductoBox"
        Me.idProductoBox.Size = New System.Drawing.Size(100, 20)
        Me.idProductoBox.TabIndex = 16
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(75, 284)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(580, 121)
        Me.TabControl1.TabIndex = 26
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.widthBox)
        Me.TabPage1.Controls.Add(Me.weighBox)
        Me.TabPage1.Controls.Add(Me.longBox)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.highBox)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(572, 95)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Medidas"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Peso de producto"
        '
        'widthBox
        '
        Me.widthBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.widthBox.Location = New System.Drawing.Point(301, 41)
        Me.widthBox.Name = "widthBox"
        Me.widthBox.Size = New System.Drawing.Size(100, 20)
        Me.widthBox.TabIndex = 19
        '
        'weighBox
        '
        Me.weighBox.Location = New System.Drawing.Point(18, 41)
        Me.weighBox.Name = "weighBox"
        Me.weighBox.Size = New System.Drawing.Size(100, 20)
        Me.weighBox.TabIndex = 14
        '
        'longBox
        '
        Me.longBox.Location = New System.Drawing.Point(442, 41)
        Me.longBox.Name = "longBox"
        Me.longBox.Size = New System.Drawing.Size(100, 20)
        Me.longBox.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(124, 44)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(20, 13)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Kg"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(439, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Largo"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(170, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(25, 13)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Alto"
        '
        'highBox
        '
        Me.highBox.Location = New System.Drawing.Point(173, 41)
        Me.highBox.Name = "highBox"
        Me.highBox.Size = New System.Drawing.Size(100, 20)
        Me.highBox.TabIndex = 17
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(298, 25)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(38, 13)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Ancho"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TabPage2.Controls.Add(Me.fourthPrice)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.thirdPrice)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.secondPrice)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.firstPrice)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(572, 95)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Precios"
        '
        'fourthPrice
        '
        Me.fourthPrice.Location = New System.Drawing.Point(419, 44)
        Me.fourthPrice.Name = "fourthPrice"
        Me.fourthPrice.Size = New System.Drawing.Size(100, 20)
        Me.fourthPrice.TabIndex = 32
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(416, 28)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 13)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "Precio 200 piezas"
        '
        'thirdPrice
        '
        Me.thirdPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.thirdPrice.Location = New System.Drawing.Point(291, 44)
        Me.thirdPrice.Name = "thirdPrice"
        Me.thirdPrice.Size = New System.Drawing.Size(100, 20)
        Me.thirdPrice.TabIndex = 30
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(288, 28)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(91, 13)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "Precio 100 piezas"
        '
        'secondPrice
        '
        Me.secondPrice.Location = New System.Drawing.Point(158, 44)
        Me.secondPrice.Name = "secondPrice"
        Me.secondPrice.Size = New System.Drawing.Size(100, 20)
        Me.secondPrice.TabIndex = 28
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(155, 28)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 13)
        Me.Label20.TabIndex = 27
        Me.Label20.Text = " Precio 12 piezas"
        '
        'firstPrice
        '
        Me.firstPrice.Location = New System.Drawing.Point(23, 44)
        Me.firstPrice.Name = "firstPrice"
        Me.firstPrice.Size = New System.Drawing.Size(100, 20)
        Me.firstPrice.TabIndex = 26
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(20, 28)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(76, 13)
        Me.Label21.TabIndex = 25
        Me.Label21.Text = "Precio Unitario"
        '
        'eliminarButton
        '
        Me.eliminarButton.Location = New System.Drawing.Point(504, 165)
        Me.eliminarButton.Name = "eliminarButton"
        Me.eliminarButton.Size = New System.Drawing.Size(146, 26)
        Me.eliminarButton.TabIndex = 31
        Me.eliminarButton.Text = "Eliminar"
        Me.eliminarButton.UseVisualStyleBackColor = True
        '
        'nuevoButton
        '
        Me.nuevoButton.Location = New System.Drawing.Point(504, 34)
        Me.nuevoButton.Name = "nuevoButton"
        Me.nuevoButton.Size = New System.Drawing.Size(146, 26)
        Me.nuevoButton.TabIndex = 30
        Me.nuevoButton.Text = "Nuevo"
        Me.nuevoButton.UseVisualStyleBackColor = True
        '
        'cancelarButton
        '
        Me.cancelarButton.Location = New System.Drawing.Point(504, 133)
        Me.cancelarButton.Name = "cancelarButton"
        Me.cancelarButton.Size = New System.Drawing.Size(146, 26)
        Me.cancelarButton.TabIndex = 29
        Me.cancelarButton.Text = "Cancelar"
        Me.cancelarButton.UseVisualStyleBackColor = True
        '
        'editarButton
        '
        Me.editarButton.Location = New System.Drawing.Point(504, 101)
        Me.editarButton.Name = "editarButton"
        Me.editarButton.Size = New System.Drawing.Size(146, 26)
        Me.editarButton.TabIndex = 28
        Me.editarButton.Text = "Editar"
        Me.editarButton.UseVisualStyleBackColor = True
        '
        'agregarButton
        '
        Me.agregarButton.Location = New System.Drawing.Point(504, 69)
        Me.agregarButton.Name = "agregarButton"
        Me.agregarButton.Size = New System.Drawing.Size(146, 26)
        Me.agregarButton.TabIndex = 27
        Me.agregarButton.Text = "Agregar"
        Me.agregarButton.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(711, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Buscar por ID"
        '
        'idProduct
        '
        Me.idProduct.FormattingEnabled = True
        Me.idProduct.Location = New System.Drawing.Point(714, 50)
        Me.idProduct.Name = "idProduct"
        Me.idProduct.Size = New System.Drawing.Size(131, 21)
        Me.idProduct.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Tipo de producto"
        '
        'typeBox
        '
        Me.typeBox.Location = New System.Drawing.Point(182, 111)
        Me.typeBox.Name = "typeBox"
        Me.typeBox.Size = New System.Drawing.Size(100, 20)
        Me.typeBox.TabIndex = 35
        '
        'saveModification
        '
        Me.saveModification.Location = New System.Drawing.Point(504, 197)
        Me.saveModification.Name = "saveModification"
        Me.saveModification.Size = New System.Drawing.Size(146, 26)
        Me.saveModification.TabIndex = 36
        Me.saveModification.Text = "Guardar Modificacion "
        Me.saveModification.UseVisualStyleBackColor = True
        '
        'FormProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 581)
        Me.Controls.Add(Me.saveModification)
        Me.Controls.Add(Me.typeBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.idProduct)
        Me.Controls.Add(Me.eliminarButton)
        Me.Controls.Add(Me.nuevoButton)
        Me.Controls.Add(Me.cancelarButton)
        Me.Controls.Add(Me.editarButton)
        Me.Controls.Add(Me.agregarButton)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.descriptionBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nameProductBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.idProductoBox)
        Me.Name = "FormProducts"
        Me.Text = "Productos"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents descriptionBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nameProductBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents idProductoBox As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents widthBox As System.Windows.Forms.TextBox
    Friend WithEvents weighBox As System.Windows.Forms.TextBox
    Friend WithEvents longBox As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents highBox As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents fourthPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents thirdPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents secondPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents firstPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents eliminarButton As System.Windows.Forms.Button
    Friend WithEvents nuevoButton As System.Windows.Forms.Button
    Friend WithEvents cancelarButton As System.Windows.Forms.Button
    Friend WithEvents editarButton As System.Windows.Forms.Button
    Friend WithEvents agregarButton As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents idProduct As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents typeBox As System.Windows.Forms.TextBox
    Friend WithEvents saveModification As System.Windows.Forms.Button
End Class
