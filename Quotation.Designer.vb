<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Quotation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ProductsCombo = New System.Windows.Forms.ComboBox()
        Me.Quantity = New System.Windows.Forms.TextBox()
        Me.ClientsCombo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.QuoteStatus = New System.Windows.Forms.TextBox()
        Me.QuoteDataGrid = New System.Windows.Forms.DataGridView()
        Me.AddProducts = New System.Windows.Forms.Button()
        Me.Export = New System.Windows.Forms.Button()
        Me.Reset = New System.Windows.Forms.Button()
        Me.ExitForm = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.DeleteProduct = New System.Windows.Forms.Button()
        CType(Me.QuoteDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductsCombo
        '
        Me.ProductsCombo.FormattingEnabled = True
        Me.ProductsCombo.Location = New System.Drawing.Point(15, 123)
        Me.ProductsCombo.Name = "ProductsCombo"
        Me.ProductsCombo.Size = New System.Drawing.Size(150, 21)
        Me.ProductsCombo.TabIndex = 0
        '
        'Quantity
        '
        Me.Quantity.Location = New System.Drawing.Point(206, 124)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(115, 20)
        Me.Quantity.TabIndex = 1
        '
        'ClientsCombo
        '
        Me.ClientsCombo.FormattingEnabled = True
        Me.ClientsCombo.Location = New System.Drawing.Point(12, 55)
        Me.ClientsCombo.Name = "ClientsCombo"
        Me.ClientsCombo.Size = New System.Drawing.Size(150, 21)
        Me.ClientsCombo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cotizacion para:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(203, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cantidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(366, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Estado"
        '
        'QuoteStatus
        '
        Me.QuoteStatus.Location = New System.Drawing.Point(369, 124)
        Me.QuoteStatus.Name = "QuoteStatus"
        Me.QuoteStatus.Size = New System.Drawing.Size(96, 20)
        Me.QuoteStatus.TabIndex = 7
        '
        'QuoteDataGrid
        '
        Me.QuoteDataGrid.AllowUserToAddRows = False
        Me.QuoteDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.QuoteDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.QuoteDataGrid.Location = New System.Drawing.Point(15, 172)
        Me.QuoteDataGrid.Name = "QuoteDataGrid"
        Me.QuoteDataGrid.Size = New System.Drawing.Size(906, 255)
        Me.QuoteDataGrid.TabIndex = 8
        '
        'AddProducts
        '
        Me.AddProducts.Location = New System.Drawing.Point(501, 116)
        Me.AddProducts.Name = "AddProducts"
        Me.AddProducts.Size = New System.Drawing.Size(110, 26)
        Me.AddProducts.TabIndex = 9
        Me.AddProducts.Text = "Agregar Productos"
        Me.AddProducts.UseVisualStyleBackColor = True
        '
        'Export
        '
        Me.Export.Location = New System.Drawing.Point(733, 116)
        Me.Export.Name = "Export"
        Me.Export.Size = New System.Drawing.Size(110, 26)
        Me.Export.TabIndex = 10
        Me.Export.Text = "Exportar Cotization"
        Me.Export.UseVisualStyleBackColor = True
        '
        'Reset
        '
        Me.Reset.Location = New System.Drawing.Point(632, 68)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(75, 28)
        Me.Reset.TabIndex = 11
        Me.Reset.Text = "Limpiar"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'ExitForm
        '
        Me.ExitForm.Location = New System.Drawing.Point(749, 68)
        Me.ExitForm.Name = "ExitForm"
        Me.ExitForm.Size = New System.Drawing.Size(75, 28)
        Me.ExitForm.TabIndex = 12
        Me.ExitForm.Text = "Salir"
        Me.ExitForm.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(514, 68)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(75, 28)
        Me.Save.TabIndex = 13
        Me.Save.Text = "Guardar"
        Me.Save.UseVisualStyleBackColor = True
        '
        'DeleteProduct
        '
        Me.DeleteProduct.Location = New System.Drawing.Point(617, 116)
        Me.DeleteProduct.Name = "DeleteProduct"
        Me.DeleteProduct.Size = New System.Drawing.Size(110, 26)
        Me.DeleteProduct.TabIndex = 14
        Me.DeleteProduct.Text = "Borrar Producto"
        Me.DeleteProduct.UseVisualStyleBackColor = True
        '
        'Quotation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 439)
        Me.Controls.Add(Me.DeleteProduct)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.ExitForm)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.Export)
        Me.Controls.Add(Me.AddProducts)
        Me.Controls.Add(Me.QuoteDataGrid)
        Me.Controls.Add(Me.QuoteStatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ClientsCombo)
        Me.Controls.Add(Me.Quantity)
        Me.Controls.Add(Me.ProductsCombo)
        Me.Name = "Quotation"
        Me.Text = "Ctizaciones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.QuoteDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductsCombo As ComboBox
    Friend WithEvents Quantity As TextBox
    Friend WithEvents ClientsCombo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents QuoteStatus As TextBox
    Friend WithEvents QuoteDataGrid As DataGridView
    Friend WithEvents AddProducts As Button
    Friend WithEvents Export As Button
    Friend WithEvents Reset As Button
    Friend WithEvents ExitForm As Button
    Friend WithEvents Save As Button
    Friend WithEvents DeleteProduct As Button
End Class
