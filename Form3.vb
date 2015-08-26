Public Class Form3

    Private Sub clientButton_Click(sender As Object, e As EventArgs) Handles clientButton.Click
        Form2.Show()
    End Sub

    Private Sub productsButton_Click(sender As Object, e As EventArgs) Handles productsButton.Click

        FormProducts.Show()

    End Sub

<<<<<<< HEAD
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Quotation.Show()

=======
    Private Sub Quotation_Click(sender As Object, e As EventArgs) Handles QuotationButton.Click
        Quotation.Show()
>>>>>>> f6250416ab4ed4b208467152761ec4f1be713576
    End Sub
End Class