Imports MySql.Data.MySqlClient

Public Class frmSales
    Dim dbConnection As Common.DbConnection
    Dim sqlAdapter As New MySqlDataAdapter()
    Dim dataSet As New DataSet()
    Dim connectionString As String
    Dim query As String
    Dim row As Integer
    Const APP_TITLE As String = "SweetHaven"

    Private customerTable As New DataTable()
    Private productTable As New DataTable()

    ' ================= BUTTON STATE =================
    Private Sub SetButtonState(btn As Button, isActive As Boolean)
        If isActive Then
            btn.Tag = "active"
            btn.ForeColor = Color.Black
            btn.BackColor = SystemColors.Control
        Else
            btn.Tag = "inactive"
            btn.ForeColor = Color.Gray
            btn.BackColor = SystemColors.Control
        End If
    End Sub

    Private Function IsInactive(btn As Button) As Boolean
        Return btn.Tag IsNot Nothing AndAlso btn.Tag.ToString() = "inactive"
    End Function

    ' ================= BUTTON STYLE =================
    Private Sub SetupButtonStyles()
        Dim buttons As Button() = {btnAdd, btnUpdate, btnDelete, btnClear}

        For Each btn In buttons
            btn.FlatStyle = FlatStyle.Flat
            btn.UseVisualStyleBackColor = False
            btn.FlatAppearance.BorderSize = 1
            btn.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#BFBFBF")
            btn.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#FFC9D8")
            btn.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml("#FFB7CC")
        Next
    End Sub

    ' ================= LOAD =================
    Private Sub frmSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectionString = "datasource=localhost;username=root;password=;database=sweet_haven"

        SetupButtonStyles()

        LoadCustomers()
        LoadProducts()
        LoadHistory()

        txtPrice.ReadOnly = True
        txtTotal.ReadOnly = True
        txtStock.ReadOnly = True

        dtpDate.Format = DateTimePickerFormat.Custom
        dtpDate.CustomFormat = "yyyy-MM-dd"
        dtpDate.Value = DateTime.Now

        SetButtonState(btnAdd, True)
        SetButtonState(btnUpdate, False)
        SetButtonState(btnDelete, False)
    End Sub

    ' ================= LOAD CUSTOMERS =================
    Private Sub LoadCustomers()
        Try
            Dim query As String = "
            SELECT 
                CustomerID,
                TRIM(CONCAT(FirstName,' ',
                IF(MiddleName = '', '', CONCAT(MiddleName,' ')),
                LastName)) AS FullName
            FROM customer"

            Dim da As New MySqlDataAdapter(query, connectionString)
            customerTable.Clear()
            da.Fill(customerTable)

            Dim newRow As DataRow = customerTable.NewRow()
            newRow("CustomerID") = ""
            newRow("FullName") = "-- Select Customer --"
            customerTable.Rows.InsertAt(newRow, 0)

            cbCustomer.DataSource = customerTable
            cbCustomer.DisplayMember = "FullName"
            cbCustomer.ValueMember = "CustomerID"
            cbCustomer.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, APP_TITLE)
        End Try
    End Sub

    ' ================= LOAD PRODUCTS =================
    Private Sub LoadProducts()
        Try
            Dim query As String = "SELECT ProductID, ProductName FROM product"

            Dim da As New MySqlDataAdapter(query, connectionString)
            productTable.Clear()
            da.Fill(productTable)

            Dim newRow As DataRow = productTable.NewRow()
            newRow("ProductID") = ""
            newRow("ProductName") = "-- Select Product --"
            productTable.Rows.InsertAt(newRow, 0)

            cbProduct.DataSource = productTable
            cbProduct.DisplayMember = "ProductName"
            cbProduct.ValueMember = "ProductID"
            cbProduct.SelectedIndex = 0

        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, APP_TITLE)
        End Try
    End Sub

    ' ================= LOAD HISTORY =================
    Private Sub LoadHistory()
        Try
            query = "
            SELECT 
                s.SalesID,
                s.CustomerID,
                s.ProductID,
                TRIM(CONCAT(c.FirstName,' ',
                IF(c.MiddleName = '', '', CONCAT(c.MiddleName,' ')),
                c.LastName)) AS CustomerName,
                p.ProductName,
                s.Date,
                s.Quantity,
                p.SellingPrice AS UnitPrice,
                (s.Quantity * p.SellingPrice) AS Total
            FROM sales s
            INNER JOIN customer c ON s.CustomerID = c.CustomerID
            INNER JOIN product p ON s.ProductID = p.ProductID
            ORDER BY s.SalesID"

            dataSet.Clear()
            dgvList.DataSource = Nothing

            dbConnection = New MySqlConnection(connectionString)
            dbConnection.Open()

            sqlAdapter = New MySqlDataAdapter(query, dbConnection)
            sqlAdapter.Fill(dataSet, "sales")

            dgvList.DataSource = dataSet
            dgvList.DataMember = "sales"

            dgvList.Columns(0).HeaderText = "ID"
            dgvList.Columns(1).Visible = False
            dgvList.Columns(2).Visible = False
            dgvList.Columns(3).HeaderText = "Customer Name"
            dgvList.Columns(4).HeaderText = "Product Name"
            dgvList.Columns(5).HeaderText = "Date"
            dgvList.Columns(6).HeaderText = "Quantity"
            dgvList.Columns(7).HeaderText = "Unit Price"
            dgvList.Columns(8).HeaderText = "Total"

            dgvList.Columns("SalesID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvList.Columns("Quantity").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvList.Columns("UnitPrice").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvList.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvList.Columns("Date").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgvList.Columns("UnitPrice").DefaultCellStyle.Format = "N2"
            dgvList.Columns("Total").DefaultCellStyle.Format = "N2"
            dgvList.Columns("Date").DefaultCellStyle.Format = "yyyy-MM-dd"

            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvList.Columns("CustomerName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvList.Columns("ProductName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            dgvList.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#FFB7CC")
            dgvList.DefaultCellStyle.SelectionForeColor = Color.Black

        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, APP_TITLE)
        Finally
            If dbConnection IsNot Nothing Then dbConnection.Close()
        End Try
    End Sub

    ' ================= GET PRICE =================
    Private Function GetProductPrice(productID As String) As Decimal
        Dim price As Decimal = 0

        Try
            Dim query As String = "SELECT SellingPrice FROM product WHERE ProductID = @ProductID"

            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ProductID", productID)
                    conn.Open()

                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        price = Convert.ToDecimal(result)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, APP_TITLE)
        End Try

        Return price
    End Function

    ' ================= GET STOCK =================
    Private Function GetProductStock(productID As String) As Integer
        Dim stock As Integer = 0

        Try
            Dim query As String = "SELECT Stock FROM product WHERE ProductID = @ProductID"

            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ProductID", productID)
                    conn.Open()

                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        stock = Convert.ToInt32(result)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, APP_TITLE)
        End Try

        Return stock
    End Function

    ' ================= UPDATE STOCK =================
    Private Sub UpdateProductStock(productID As String, quantityChange As Integer)
        Try
            Dim query As String = "
            UPDATE product
            SET Stock = Stock + @QuantityChange
            WHERE ProductID = @ProductID"

            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@QuantityChange", quantityChange)
                    cmd.Parameters.AddWithValue("@ProductID", productID)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, APP_TITLE)
        End Try
    End Sub

    ' ================= ADD =================
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If IsInactive(btnAdd) Then Exit Sub

        Try
            ' ================= DROPDOWN VALIDATION =================
            If cbCustomer.SelectedIndex = 0 OrElse cbProduct.SelectedIndex = 0 Then
                MsgBox("Please select a valid Customer and Product.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            ' ================= SALES ID VALIDATION =================
            Dim salesID As String = txtSalesID.Text.Trim()

            If Not System.Text.RegularExpressions.Regex.IsMatch(salesID, "^SAL\d{5}$") Then
                MsgBox("Sales ID must be exactly 8 characters in format SAL##### (e.g., SAL00001).", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            ' ================= DUPLICATE CHECK =================
            For Each r As DataRow In dataSet.Tables("sales").Rows
                If r.RowState <> DataRowState.Deleted AndAlso r("SalesID").ToString() = salesID Then
                    MsgBox("Sales ID already exists.", MsgBoxStyle.Exclamation, APP_TITLE)
                    Exit Sub
                End If
            Next

            ' ================= QUANTITY VALIDATION =================
            If txtQuantity.Text = "" OrElse Not IsNumeric(txtQuantity.Text) Then
                MsgBox("Enter valid quantity.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            Dim qty As Integer = Convert.ToInt32(txtQuantity.Text)

            If qty <= 0 Then
                MsgBox("Quantity must be greater than 0.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            Dim stock As Integer = GetProductStock(cbProduct.SelectedValue.ToString())

            If qty > stock Then
                MsgBox("Not enough stock.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            ' ================= INSERT =================
            Dim insertQuery As String = "
        INSERT INTO sales (SalesID, CustomerID, ProductID, Quantity, Date)
        VALUES (@SalesID, @CustomerID, @ProductID, @Quantity, @Date)"

            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(insertQuery, conn)
                    cmd.Parameters.AddWithValue("@SalesID", salesID)
                    cmd.Parameters.AddWithValue("@CustomerID", cbCustomer.SelectedValue)
                    cmd.Parameters.AddWithValue("@ProductID", cbProduct.SelectedValue)
                    cmd.Parameters.AddWithValue("@Quantity", qty)
                    cmd.Parameters.AddWithValue("@Date", dtpDate.Value)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            UpdateProductStock(cbProduct.SelectedValue.ToString(), -qty)

            MsgBox("Sale added successfully.", MsgBoxStyle.Information, APP_TITLE)
            btnClear.PerformClick()
            LoadHistory()

        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, APP_TITLE)
        End Try
    End Sub

    ' ================= UPDATE =================
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If IsInactive(btnUpdate) Then Exit Sub

        If MsgBox("Save changes to this sale?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, APP_TITLE) = MsgBoxResult.No Then Exit Sub

        Try
            ' ================= DROPDOWN VALIDATION =================
            If cbCustomer.SelectedIndex = 0 OrElse cbProduct.SelectedIndex = 0 Then
                MsgBox("Please select a valid Customer and Product.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            ' ================= SALES ID VALIDATION =================
            Dim salesID As String = txtSalesID.Text.Trim()

            If Not System.Text.RegularExpressions.Regex.IsMatch(salesID, "^SAL\d{5}$") Then
                MsgBox("Sales ID must be exactly 8 characters in format SAL##### (e.g., SAL00001).", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            ' ================= QUANTITY VALIDATION =================
            If txtQuantity.Text = "" OrElse Not IsNumeric(txtQuantity.Text) Then
                MsgBox("Enter valid quantity.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            Dim newQuantity As Integer = Convert.ToInt32(txtQuantity.Text)

            If newQuantity <= 0 Then
                MsgBox("Quantity must be greater than 0.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            ' ================= EXISTING VALUES =================
            Dim oldProductID As String = dgvList.CurrentRow.Cells("ProductID").Value.ToString()
            Dim newProductID As String = cbProduct.SelectedValue.ToString()
            Dim oldQuantity As Integer = Convert.ToInt32(dgvList.CurrentRow.Cells("Quantity").Value)

            ' ================= STOCK CHECK =================
            If oldProductID = newProductID Then
                Dim availableStock As Integer = GetProductStock(newProductID) + oldQuantity
                If newQuantity > availableStock Then
                    MsgBox("Not enough stock.", MsgBoxStyle.Exclamation, APP_TITLE)
                    Exit Sub
                End If
            Else
                Dim availableStock As Integer = GetProductStock(newProductID)
                If newQuantity > availableStock Then
                    MsgBox("Not enough stock for the selected product.", MsgBoxStyle.Exclamation, APP_TITLE)
                    Exit Sub
                End If
            End If

            ' ================= UPDATE =================
            Dim updateQuery As String = "
        UPDATE sales
        SET CustomerID=@CustomerID, ProductID=@ProductID, Quantity=@Quantity, Date=@Date
        WHERE SalesID=@SalesID"

            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@SalesID", salesID)
                    cmd.Parameters.AddWithValue("@CustomerID", cbCustomer.SelectedValue)
                    cmd.Parameters.AddWithValue("@ProductID", newProductID)
                    cmd.Parameters.AddWithValue("@Quantity", newQuantity)
                    cmd.Parameters.AddWithValue("@Date", dtpDate.Value)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' ================= STOCK ADJUST =================
            If oldProductID = newProductID Then
                UpdateProductStock(newProductID, oldQuantity - newQuantity)
            Else
                UpdateProductStock(oldProductID, oldQuantity)
                UpdateProductStock(newProductID, -newQuantity)
            End If

            MsgBox("Sale updated successfully.", MsgBoxStyle.Information, APP_TITLE)
            btnClear.PerformClick()
            LoadHistory()

        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, APP_TITLE)
        End Try
    End Sub

    ' ================= DELETE =================
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If IsInactive(btnDelete) Then Exit Sub

        If MsgBox("Are you sure you want to delete this sale?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, APP_TITLE) = MsgBoxResult.No Then Exit Sub

        Try
            Dim deletedProductID As String = dgvList.CurrentRow.Cells("ProductID").Value.ToString()
            Dim deletedQuantity As Integer = Convert.ToInt32(dgvList.CurrentRow.Cells("Quantity").Value)

            Dim deleteQuery As String = "DELETE FROM sales WHERE SalesID=@SalesID"

            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand(deleteQuery, conn)
                    cmd.Parameters.AddWithValue("@SalesID", txtSalesID.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            UpdateProductStock(deletedProductID, deletedQuantity)

            MsgBox("Sale deleted successfully.", MsgBoxStyle.Information, APP_TITLE)
            btnClear.PerformClick()
            LoadHistory()

        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, APP_TITLE)
        End Try
    End Sub

    ' ================= CLEAR =================
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSalesID.Clear()
        txtQuantity.Clear()
        txtPrice.Clear()
        txtTotal.Clear()
        txtStock.Clear()

        cbCustomer.SelectedIndex = 0
        cbProduct.SelectedIndex = 0

        txtSalesID.Enabled = True

        SetButtonState(btnAdd, True)
        SetButtonState(btnUpdate, False)
        SetButtonState(btnDelete, False)
    End Sub

    ' ================= GRID CLICK =================
    Private Sub dgvList_MouseUp(sender As Object, e As MouseEventArgs) Handles dgvList.MouseUp
        txtSalesID.Text = dgvList.CurrentRow.Cells("SalesID").Value.ToString()
        cbCustomer.SelectedValue = dgvList.CurrentRow.Cells("CustomerID").Value.ToString()
        cbProduct.SelectedValue = dgvList.CurrentRow.Cells("ProductID").Value.ToString()
        dtpDate.Value = dgvList.CurrentRow.Cells("Date").Value
        txtQuantity.Text = dgvList.CurrentRow.Cells("Quantity").Value.ToString()

        txtStock.Text = GetProductStock(cbProduct.SelectedValue.ToString()).ToString()

        txtSalesID.Enabled = False

        SetButtonState(btnAdd, False)
        SetButtonState(btnUpdate, True)
        SetButtonState(btnDelete, True)

        Me.AutoScrollPosition = New Point(0, 0)
    End Sub

    ' ================= CALCULATIONS =================
    Private Sub cbProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProduct.SelectedIndexChanged
        If cbProduct.SelectedIndex = 0 Then
            txtPrice.Clear()
            txtTotal.Clear()
            txtStock.Clear()
            Exit Sub
        End If

        Dim price As Decimal = GetProductPrice(cbProduct.SelectedValue.ToString())
        txtPrice.Text = price.ToString("N2")
        txtStock.Text = GetProductStock(cbProduct.SelectedValue.ToString()).ToString()

        If IsNumeric(txtQuantity.Text) Then
            txtTotal.Text = (price * Convert.ToDecimal(txtQuantity.Text)).ToString("N2")
        Else
            txtTotal.Clear()
        End If
    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        If cbProduct.SelectedIndex = 0 Then
            txtPrice.Clear()
            txtTotal.Clear()
            txtStock.Clear()
            Exit Sub
        End If

        Dim price As Decimal = GetProductPrice(cbProduct.SelectedValue.ToString())
        txtPrice.Text = price.ToString("N2")
        txtStock.Text = GetProductStock(cbProduct.SelectedValue.ToString()).ToString()

        If IsNumeric(txtQuantity.Text) Then
            txtTotal.Text = (price * Convert.ToDecimal(txtQuantity.Text)).ToString("N2")
        Else
            txtTotal.Clear()
        End If
    End Sub

End Class