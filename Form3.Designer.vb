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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'clientButton
        '
        Me.clientButton.Location = New System.Drawing.Point(298, 83)
        Me.clientButton.Name = "clientButton"
        Me.clientButton.Size = New System.Drawing.Size(194, 42)
        Me.clientButton.TabIndex = 0
        Me.clientButton.Text = "Clientes"
        Me.clientButton.UseVisualStyleBackColor = True
        '
        'productsButton
        '
        Me.productsButton.Location = New System.Drawing.Point(300, 170)
        Me.productsButton.Name = "productsButton"
        Me.productsButton.Size = New System.Drawing.Size(194, 42)
        Me.productsButton.TabIndex = 1
        Me.productsButton.Text = "Productos"
        Me.productsButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(300, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(194, 42)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Cotzacion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(795, 382)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.productsButton)
        Me.Controls.Add(Me.clientButton)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents clientButton As System.Windows.Forms.Button
    Friend WithEvents productsButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
