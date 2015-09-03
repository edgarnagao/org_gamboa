<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.clientButton = New System.Windows.Forms.Button()
        Me.productsButton = New System.Windows.Forms.Button()
        Me.proveedoresButton = New System.Windows.Forms.Button()
        Me.QuotationButton = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'clientButton
        '
        Me.clientButton.Location = New System.Drawing.Point(12, 209)
        Me.clientButton.Name = "clientButton"
        Me.clientButton.Size = New System.Drawing.Size(194, 42)
        Me.clientButton.TabIndex = 0
        Me.clientButton.Text = "Clientes"
        Me.clientButton.UseVisualStyleBackColor = True
        '
        'productsButton
        '
        Me.productsButton.Location = New System.Drawing.Point(212, 209)
        Me.productsButton.Name = "productsButton"
        Me.productsButton.Size = New System.Drawing.Size(194, 42)
        Me.productsButton.TabIndex = 1
        Me.productsButton.Text = "Productos"
        Me.productsButton.UseVisualStyleBackColor = True
        '
        'proveedoresButton
        '
        Me.proveedoresButton.Location = New System.Drawing.Point(612, 209)
        Me.proveedoresButton.Name = "proveedoresButton"
        Me.proveedoresButton.Size = New System.Drawing.Size(194, 42)
        Me.proveedoresButton.TabIndex = 2
        Me.proveedoresButton.Text = "Proveedores"
        Me.proveedoresButton.UseVisualStyleBackColor = True
        '
        'QuotationButton
        '
        Me.QuotationButton.Location = New System.Drawing.Point(412, 209)
        Me.QuotationButton.Name = "QuotationButton"
        Me.QuotationButton.Size = New System.Drawing.Size(194, 42)
        Me.QuotationButton.TabIndex = 2
        Me.QuotationButton.Text = "Cotizaciones"
        Me.QuotationButton.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Organzador.My.Resources.Resources.titulo
        Me.PictureBox2.Location = New System.Drawing.Point(120, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(586, 191)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(837, 461)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.proveedoresButton)
        Me.Controls.Add(Me.QuotationButton)
        Me.Controls.Add(Me.productsButton)
        Me.Controls.Add(Me.clientButton)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents clientButton As System.Windows.Forms.Button
    Friend WithEvents productsButton As System.Windows.Forms.Button
    Friend WithEvents proveedoresButton As System.Windows.Forms.Button
    Friend WithEvents QuotationButton As Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
