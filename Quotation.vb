

Public Class Quotation
    Dim prodlist = New List(Of Products)
    Dim gridlist = New List(Of Products)
    Public Const VAT = 0.16 ' Value Added Tax (IVA in Spanish)
    Dim total As Double

    Private Sub Quotation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load Customers
        Call LoadCustomers()
        'Load Products
        Call LoadProducts()
        'Test DataGrid
        QuoteStatus.Text = "Nueva"
        QuoteStatus.Enabled = False
        InitGrid()
        total = 0.0
    End Sub

    Private Sub LoadCustomers()
        Dim mydb As New mySqlDB
        Dim dataset As New DataSet
        Dim GETALLCUSTOMERS As String = "select c.serial_id, concat(c.first_name,' ', c.last_name) as Fullname from client c"
        Dim queryresult As String = ""
        dataset = mydb.executeSQL_dset(GETALLCUSTOMERS, queryresult)
        ClientsCombo.DataSource = dataset.Tables(0)
        ClientsCombo.ValueMember = "serial_id"
        ClientsCombo.DisplayMember = "Fullname"
    End Sub

    Private Sub LoadProducts()
        Dim mydb As New mySqlDB
        Dim dataset As New DataSet
        Dim tblproducts As New DataTable
        Dim GETALLPRODUCTS As String = "select p.serial_id, p.product, p.type_prod, p.description, p.file_path, p.price, p.second_price, p.third_price, p.fourth_price from products p"
        Dim queryresult As String = ""
        dataset = mydb.executeSQL_dset(GETALLPRODUCTS, queryresult)
        tblproducts = dataset.Tables(0)
        ProductsCombo.DataSource = dataset.Tables(0)
        ProductsCombo.ValueMember = "serial_id"
        ProductsCombo.DisplayMember = "product"

        For Each row As DataRow In tblproducts.Rows
            Dim p As String
            Dim sp As String
            Dim tp As String
            Dim fp As String

            If IsDBNull(row("price")) Then
                p = Nothing
            Else
                p = row("price")
            End If

            If IsDBNull(row("second_price")) Then
                sp = Nothing
            Else
                sp = row("second_price")
            End If

            If IsDBNull(row("third_price")) Then
                tp = Nothing
            Else
                tp = row("third_price")
            End If

            If IsDBNull(row("fourth_price")) Then
                fp = Nothing
            Else
                fp = row("fourth_price")
            End If

            Dim prod = New Products(row("serial_id"), row("product"), row("type_prod"), row("description"), row("file_path"), p, sp, tp, fp)
            prodlist.Add(prod)
        Next row

    End Sub

    Private Sub LoadDataGrid(p As Products)
        If QuoteDataGrid.RowCount >= 4 Then
            QuoteDataGrid.Rows.RemoveAt(QuoteDataGrid.RowCount - 1)
            QuoteDataGrid.Rows.RemoveAt(QuoteDataGrid.RowCount - 1)
            QuoteDataGrid.Rows.RemoveAt(QuoteDataGrid.RowCount - 1)
        End If
        Dim qty As Integer
        Dim precioDescuento As Double


        If IsNumeric(Quantity.Text) Then
            qty = Double.Parse(Quantity.Text)
        Else
            MsgBox("El campo Cantidad solo acepta numeros")
            Exit Sub
        End If

        Dim subTotal As Double
        If qty <= 11 Then
            precioDescuento = Double.Parse(p.Price)
            subTotal = qty * precioDescuento
        ElseIf 11 < qty < 100 Then
            precioDescuento = Double.Parse(p.SecondPrice)
            subTotal = qty * precioDescuento
        ElseIf 100 >= qty < 200 Then
            precioDescuento = Double.Parse(p.ThirdPrice)
            subTotal = qty * precioDescuento
        ElseIf qty >= 200 Then
            precioDescuento = Double.Parse(p.FourthPrice)
            subTotal = qty * precioDescuento
        End If

        total = total + subTotal

        Dim row As String() = New String() {p.SerialId, p.Product, p.TypeProduct, p.Description, p.FilePath, p.Price, precioDescuento, Quantity.Text, subTotal}
        QuoteDataGrid.Rows.Add(row)
        Dim subrow As String() = New String() {Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "Subtotal", total}
        Dim vatrow As String() = New String() {Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "Iva", total * VAT}
        Dim totrow As String() = New String() {Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "Total", total * 1.16}
        QuoteDataGrid.Rows.Add(subrow)
        QuoteDataGrid.Rows.Add(vatrow)
        QuoteDataGrid.Rows.Add(totrow)
    End Sub

    Private Sub AddProducts_Click(sender As Object, e As EventArgs) Handles AddProducts.Click
        'Add selected item to the grid
        Call LoadDataGrid(prodlist.item(ProductsCombo.SelectedIndex))
    End Sub

    Private Sub InitGrid()
        With QuoteDataGrid
            .ColumnCount = 9
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "ID"
            .Columns(1).HeaderCell.Value = "Producto"
            .Columns(2).HeaderCell.Value = "Tipo de Producto"
            .Columns(3).HeaderCell.Value = "Descripcion"
            .Columns(4).HeaderCell.Value = "Archivo Imagen"
            .Columns(5).HeaderCell.Value = "Precio Unitario"
            .Columns(6).HeaderCell.Value = "Precio Descuento"
            .Columns(7).HeaderCell.Value = "Cantidad"
            .Columns(8).HeaderCell.Value = "Total"
        End With
    End Sub

    Private Function CalculateVAT(subtotal As Double)
        Return subtotal * VAT
    End Function

End Class