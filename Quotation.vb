Imports System.IO
Imports System.Data
Imports System.Reflection
Imports iTextSharp.text
Imports iTextSharp.text.pdf

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
        Dim GETALLPRODUCTS As String = "select p.serial_id, p.product, p.type_prod, p.description, p.file_path, p.price, p.second_price, p.third_price, p.fourth_price, CONCAT(p.serial_id, ' - ' ,p.product) AS DisplayField from products p"
        Dim queryresult As String = ""
        dataset = mydb.executeSQL_dset(GETALLPRODUCTS, queryresult)
        tblproducts = dataset.Tables(0)
        ProductsCombo.DataSource = dataset.Tables(0)
        ProductsCombo.ValueMember = "serial_id"
        ProductsCombo.DisplayMember = "DisplayField"

        For Each row As DataRow In tblproducts.Rows
            Dim p 'As String
            Dim sp 'As String
            Dim tp 'As String
            Dim fp As String
            Dim filepath As String

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

            If IsDBNull(row("file_path")) Then
                filepath = Nothing
            Else
                filepath = row("file_path")
            End If

            Dim prod = New Products(row("serial_id"), row("product"), row("type_prod"), row("description"), filepath, p, sp, tp, fp)
            prodlist.Add(prod)
        Next row

    End Sub

    Private Sub LoadDataGrid(p As Products)

        Dim qty As Integer
        Dim discount As Double
        Dim savings As Double
        Dim originalprice As Double

        If QuoteDataGrid.RowCount >= 4 Then
            QuoteDataGrid.Rows.RemoveAt(QuoteDataGrid.RowCount - 1) 'remove subtotal record
            QuoteDataGrid.Rows.RemoveAt(QuoteDataGrid.RowCount - 1) 'remove vat record
            QuoteDataGrid.Rows.RemoveAt(QuoteDataGrid.RowCount - 1) 'remove total record
            QuoteDataGrid.Rows.RemoveAt(QuoteDataGrid.RowCount - 1) 'remove savings record
        End If

        If IsNumeric(Quantity.Text) Then
            qty = Double.Parse(Quantity.Text)
        Else
            MsgBox("El campo Cantidad solo acepta numeros")
            Exit Sub
        End If

        Dim subTotal As Double

        If qty <= 11 Then
            discount = Double.Parse(p.Price)
            subTotal = qty * discount
            savings = 0
        ElseIf 11 < qty < 100 Then
            discount = Double.Parse(p.SecondPrice)
            subTotal = qty * discount
            savings = originalprice - discount
        ElseIf 100 >= qty < 200 Then
            discount = Double.Parse(p.ThirdPrice)
            subTotal = qty * discount
            savings = originalprice - discount
        ElseIf qty >= 200 Then
            discount = Double.Parse(p.FourthPrice)
            subTotal = qty * discount
            savings = originalprice - discount
        End If

        total = total + subTotal

        Dim row As String() = New String() {p.SerialId, p.Product, p.TypeProduct, p.Description, p.FilePath, p.Price, discount, Quantity.Text, subTotal}
        QuoteDataGrid.Rows.Add(row)
        Dim subrow As String() = New String() {Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "Subtotal", total}
        Dim vatrow As String() = New String() {Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "Iva", total * VAT}
        Dim totrow As String() = New String() {Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "Total", total * 1.16}

        QuoteDataGrid.Rows.Add(subrow)
        QuoteDataGrid.Rows.Add(vatrow)
        QuoteDataGrid.Rows.Add(totrow)

        Dim savingsrow As String() = New String() {Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "Tu Ahorro es", savings}
        QuoteDataGrid.Rows.Add(savingsrow)
    End Sub

    Private Sub AddProducts_Click(sender As Object, e As EventArgs) Handles AddProducts.Click
        'Add selected item to the grid
        Call LoadDataGrid(prodlist.item(ProductsCombo.SelectedIndex))
        Quantity.Text = Nothing
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

    Private Sub CalculateSavings(qty As Integer, p As Products)
        Dim originalprice As Double
        Dim discount As Double
        Dim savings As Double

        originalprice = Double.Parse(p.Price) * qty

        If qty <= 11 Then
            savings = 0
        ElseIf 11 < qty < 100 Then
            discount = Double.Parse(p.SecondPrice) * qty
            savings = originalprice - discount
        ElseIf 100 >= qty < 200 Then
            discount = Double.Parse(p.ThirdPrice) * qty
            savings = originalprice - discount
        ElseIf qty >= 200 Then
            discount = Double.Parse(p.FourthPrice) * qty
            savings = originalprice - discount
        End If
    End Sub

    Private Sub Export_Click(sender As Object, e As EventArgs) Handles Export.Click
        'Creating iTextSharp Table from the DataTable data
        Dim pdfTable As New PdfPTable(QuoteDataGrid.ColumnCount)
        pdfTable.DefaultCell.Padding = 3
        pdfTable.WidthPercentage = 100
        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT
        pdfTable.DefaultCell.BorderWidth = 1

        'Adding Header row
        For Each column As DataGridViewColumn In QuoteDataGrid.Columns
            Dim cell As New PdfPCell(New Phrase(column.HeaderText))
            cell.BackgroundColor = New iTextSharp.text.BaseColor(240, 240, 240)
            pdfTable.AddCell(cell)
        Next

        'Adding DataRow
        For Each row As DataGridViewRow In QuoteDataGrid.Rows
            For Each cell As DataGridViewCell In row.Cells
                If IsNothing(cell.Value) Then
                    cell.Value = ""
                End If
                pdfTable.AddCell(cell.Value.ToString())

            Next
        Next

        'Exporting to PDF
        Dim folderPath As String = "C:\PDFs\"
        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If

        Dim now = DateTime.Now.ToString("dd.MM.yyyy HH.mm.ss")
        Using stream As New FileStream(folderPath & "Cotizacion" & now & ".pdf", FileMode.Create)
            Dim pdfDoc As New Document(PageSize.A2, 10.0F, 10.0F, 10.0F, 0.0F)
            PdfWriter.GetInstance(pdfDoc, stream)
            pdfDoc.Open()
            pdfDoc.AddTitle("Productos Gamboa")
            pdfDoc.AddHeader("Encabezado", "Atencion a:" & ClientsCombo.GetItemText(ClientsCombo.SelectedItem))
            pdfDoc.Add(pdfTable)
            pdfDoc.Close()
            stream.Close()
        End Using
        MsgBox("El archivo fue creado exitosamente en la siguiente ruta: " & folderPath & "Cotizacion" & now & ".pdf")
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        QuoteDataGrid.Rows.Clear()
        Quantity.Text = Nothing
    End Sub

    Private Sub ExitForm_Click(sender As Object, e As EventArgs) Handles ExitForm.Click
        Me.Close()
    End Sub
End Class