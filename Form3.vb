Public Class Form3

    Private Sub clientButton_Click(sender As Object, e As EventArgs) Handles clientButton.Click
        Form2.Show()
    End Sub

    Private Sub productsButton_Click(sender As Object, e As EventArgs) Handles productsButton.Click

        FormProducts.Show()

    End Sub


    Private Sub Quotation_Click(sender As Object, e As EventArgs) Handles QuotationButton.Click

        Quotation.Show()

    End Sub

    Private Sub proveedoresButton_Click(sender As Object, e As EventArgs) Handles proveedoresButton.Click
        Proveedores.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class