

Public Class Quotation
    Dim prodlist = New List(Of Products)
    Dim gridlist = New List(Of Products)

    Private Sub Quotation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load Customers
        Call LoadCustomers()
        'Load Products
        Call LoadProducts()
        'Test DataGrid
        QuoteStatus.Text = "Nueva"
        QuoteStatus.Enabled = False
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

        For Each row As DataRow In tblproducts.Rows
            prodlist.Add(New Products(row("serial_id"), row("product"), row("type_prod"), row("description"), row("file_path"), row("price"), row("second_price"), row("third_price"), row("fourth_price")))
        Next row
        ProductsCombo.DataSource = dataset.Tables(0)
        ProductsCombo.ValueMember = "serial_id"
        ProductsCombo.DisplayMember = "product"
    End Sub

    Private Sub LoadDataGrid(list As List(Of Products))
        QuoteDataGrid.DataSource = Nothing
        QuoteDataGrid.DataSource = list
        With QuoteDataGrid
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

    Private Sub AddProducts_Click(sender As Object, e As EventArgs) Handles AddProducts.Click
        'Add selected item to the grid
        gridlist.Add(prodlist.item(ProductsCombo.SelectedIndex))
        Call LoadDataGrid(gridlist)
    End Sub

End Class