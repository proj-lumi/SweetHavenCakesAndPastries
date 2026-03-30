Imports MySql.Data.MySqlClient

Public Class frmPurchase
    Dim dbConnection As Common.DbConnection
    Dim sqlAdapter As New MySqlDataAdapter()
    Dim dataSet As New DataSet()
    Dim connectionString As String
    Dim query As String
    Dim row As Integer
    Const APP_TITLE As String = "SweetHaven"

    Private supplierTable As New DataTable()
    Private productTable As New DataTable()

    ' ================= GET STOCK =================
    Private Function GetProductStock(productID As String) As Integer
        Dim stock As Integer = 0

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand("SELECT Stock FROM product WHERE ProductID=@ProductID", conn)
                cmd.Parameters.AddWithValue("@ProductID", productID)
                conn.Open()

                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then stock = Convert.ToInt32(result)
            End Using
        End Using

        Return stock
    End Function

    ' ================= GET COST =================
    Private Function GetProductCost(productID As String) As Decimal
        Dim cost As Decimal = 0

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand("SELECT Cost FROM product WHERE ProductID=@ProductID", conn)
                cmd.Parameters.AddWithValue("@ProductID", productID)
                conn.Open()

                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing Then cost = Convert.ToDecimal(result)
            End Using
        End Using

        Return cost
    End Function

    ' ================= UPDATE STOCK =================
    Private Sub UpdateProductStock(productID As String, quantityChange As Integer)
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand("UPDATE product SET Stock = Stock + @qty WHERE ProductID=@id", conn)
                cmd.Parameters.AddWithValue("@qty", quantityChange)
                cmd.Parameters.AddWithValue("@id", productID)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' ================= BUTTON STATE =================
    Private Sub SetButtonState(btn As Button, isActive As Boolean)
        If isActive Then
            btn.Tag = "active"
            btn.ForeColor = Color.Black
        Else
            btn.Tag = "inactive"
            btn.ForeColor = Color.Gray
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
    Private Sub frmPurchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectionString = "datasource=localhost;username=root;password=;database=sweet_haven"

        SetupButtonStyles()

        LoadSuppliers()
        LoadProducts()
        LoadHistory()

        txtPrice.ReadOnly = True
        txtTotal.ReadOnly = True
        txtStock.ReadOnly = True

        dtpDate.Format = DateTimePickerFormat.Custom
        dtpDate.CustomFormat = "yyyy-MM-dd"

        SetButtonState(btnAdd, True)
        SetButtonState(btnUpdate, False)
        SetButtonState(btnDelete, False)
    End Sub

    ' ================= LOAD SUPPLIERS =================
    Private Sub LoadSuppliers()
        Dim da As New MySqlDataAdapter("SELECT SupplierID, SupplierName FROM supplier", connectionString)
        supplierTable.Clear()
        da.Fill(supplierTable)

        Dim r = supplierTable.NewRow()
        r("SupplierID") = ""
        r("SupplierName") = "-- Select Supplier --"
        supplierTable.Rows.InsertAt(r, 0)

        cbSupplier.DataSource = supplierTable
        cbSupplier.DisplayMember = "SupplierName"
        cbSupplier.ValueMember = "SupplierID"
        cbSupplier.SelectedIndex = 0
    End Sub

    ' ================= LOAD PRODUCTS =================
    Private Sub LoadProducts()
        Dim da As New MySqlDataAdapter("SELECT ProductID, ProductName FROM product", connectionString)
        productTable.Clear()
        da.Fill(productTable)

        Dim r = productTable.NewRow()
        r("ProductID") = ""
        r("ProductName") = "-- Select Product --"
        productTable.Rows.InsertAt(r, 0)

        cbProduct.DataSource = productTable
        cbProduct.DisplayMember = "ProductName"
        cbProduct.ValueMember = "ProductID"
        cbProduct.SelectedIndex = 0
    End Sub

    ' ================= HISTORY =================
    Private Sub LoadHistory()
        Try
            query = "
        SELECT 
            p.PurchaseID,
            p.SupplierID,
            p.ProductID,
            s.SupplierName,
            pr.ProductName,
            p.Date,
            p.Quantity,
            pr.Cost AS UnitPrice,
            (p.Quantity * pr.Cost) AS Total
        FROM purchase p
        INNER JOIN supplier s ON p.SupplierID = s.SupplierID
        INNER JOIN product pr ON p.ProductID = pr.ProductID
        ORDER BY p.PurchaseID"

            dataSet.Clear()
            dgvList.DataSource = Nothing

            dbConnection = New MySqlConnection(connectionString)
            dbConnection.Open()

            sqlAdapter = New MySqlDataAdapter(query, dbConnection)
            sqlAdapter.Fill(dataSet, "purchase")

            dgvList.DataSource = dataSet
            dgvList.DataMember = "purchase"

            ' ================= HEADERS =================
            dgvList.Columns(0).HeaderText = "ID"
            dgvList.Columns(1).Visible = False
            dgvList.Columns(2).Visible = False
            dgvList.Columns(3).HeaderText = "Supplier Name"
            dgvList.Columns(4).HeaderText = "Product Name"
            dgvList.Columns(5).HeaderText = "Date"
            dgvList.Columns(6).HeaderText = "Quantity"
            dgvList.Columns(7).HeaderText = "Unit Price"
            dgvList.Columns(8).HeaderText = "Total"

            ' ================= ALIGNMENT =================
            dgvList.Columns("PurchaseID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvList.Columns("Quantity").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvList.Columns("UnitPrice").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvList.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvList.Columns("Date").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            ' ================= FORMATTING =================
            dgvList.Columns("UnitPrice").DefaultCellStyle.Format = "N2"
            dgvList.Columns("Total").DefaultCellStyle.Format = "N2"
            dgvList.Columns("Date").DefaultCellStyle.Format = "yyyy-MM-dd"

            ' ================= AUTOSIZE =================
            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvList.Columns("SupplierName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvList.Columns("ProductName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            ' ================= STYLE =================
            dgvList.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#FFB7CC")
            dgvList.DefaultCellStyle.SelectionForeColor = Color.Black

        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, APP_TITLE)
        Finally
            If dbConnection IsNot Nothing Then dbConnection.Close()
        End Try
    End Sub

    ' ================= GRID CLICK (RESTORED) =================
    Private Sub dgvList_MouseUp(sender As Object, e As MouseEventArgs) Handles dgvList.MouseUp
        txtPurchaseID.Text = dgvList.CurrentRow.Cells("PurchaseID").Value.ToString()
        cbSupplier.SelectedValue = dgvList.CurrentRow.Cells("SupplierID").Value.ToString()
        cbProduct.SelectedValue = dgvList.CurrentRow.Cells("ProductID").Value.ToString()
        dtpDate.Value = dgvList.CurrentRow.Cells("Date").Value
        txtQuantity.Text = dgvList.CurrentRow.Cells("Quantity").Value.ToString()

        txtStock.Text = GetProductStock(cbProduct.SelectedValue.ToString()).ToString()

        txtPurchaseID.Enabled = False

        SetButtonState(btnAdd, False)
        SetButtonState(btnUpdate, True)
        SetButtonState(btnDelete, True)

        Me.AutoScrollPosition = New Point(0, 0)
    End Sub

    ' ================= ADD =================
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If IsInactive(btnAdd) Then Exit Sub

        Try
            ' ================= DROPDOWN VALIDATION =================
            If cbSupplier.SelectedIndex = 0 OrElse cbProduct.SelectedIndex = 0 Then
                MsgBox("Please select a valid Supplier and Product.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            ' ================= PURCHASE ID VALIDATION =================
            Dim purchaseID As String = txtPurchaseID.Text.Trim()

            If Not System.Text.RegularExpressions.Regex.IsMatch(purchaseID, "^PUR\d{5}$") Then
                MsgBox("Purchase ID must be exactly 8 characters in format PUR##### (e.g., PUR00001).", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            ' ================= DUPLICATE CHECK =================
            For Each r As DataRow In dataSet.Tables("purchase").Rows
                If r.RowState <> DataRowState.Deleted AndAlso r("PurchaseID").ToString() = purchaseID Then
                    MsgBox("Purchase ID already exists.", MsgBoxStyle.Exclamation, APP_TITLE)
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

            ' ================= INSERT =================
            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand("
            INSERT INTO purchase VALUES (@id,@sup,@prod,@date,@qty)", conn)

                    cmd.Parameters.AddWithValue("@id", purchaseID)
                    cmd.Parameters.AddWithValue("@sup", cbSupplier.SelectedValue)
                    cmd.Parameters.AddWithValue("@prod", cbProduct.SelectedValue)
                    cmd.Parameters.AddWithValue("@date", dtpDate.Value)
                    cmd.Parameters.AddWithValue("@qty", qty)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            UpdateProductStock(cbProduct.SelectedValue.ToString(), qty)

            MsgBox("Purchase added successfully.", MsgBoxStyle.Information, APP_TITLE)
            btnClear.PerformClick()
            LoadHistory()

        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, APP_TITLE)
        End Try
    End Sub

    ' ================= UPDATE (RESTORED) =================
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If IsInactive(btnUpdate) Then Exit Sub

        If MsgBox("Save changes to this purchase?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, APP_TITLE) = MsgBoxResult.No Then Exit Sub

        Try
            ' ================= DROPDOWN VALIDATION =================
            If cbSupplier.SelectedIndex = 0 OrElse cbProduct.SelectedIndex = 0 Then
                MsgBox("Please select a valid Supplier and Product.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            ' ================= PURCHASE ID VALIDATION =================
            Dim purchaseID As String = txtPurchaseID.Text.Trim()

            If Not System.Text.RegularExpressions.Regex.IsMatch(purchaseID, "^PUR\d{5}$") Then
                MsgBox("Purchase ID must be exactly 8 characters in format PUR##### (e.g., PUR00001).", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            ' ================= QUANTITY VALIDATION =================
            If txtQuantity.Text = "" OrElse Not IsNumeric(txtQuantity.Text) Then
                MsgBox("Enter valid quantity.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            Dim newQty As Integer = Convert.ToInt32(txtQuantity.Text)

            If newQty <= 0 Then
                MsgBox("Quantity must be greater than 0.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            Dim oldQty As Integer = Convert.ToInt32(dgvList.CurrentRow.Cells("Quantity").Value)
            Dim prodID As String = cbProduct.SelectedValue.ToString()

            ' ================= UPDATE =================
            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand("
            UPDATE purchase SET SupplierID=@sup, ProductID=@prod, Quantity=@qty, Date=@date
            WHERE PurchaseID=@id", conn)

                    cmd.Parameters.AddWithValue("@id", purchaseID)
                    cmd.Parameters.AddWithValue("@sup", cbSupplier.SelectedValue)
                    cmd.Parameters.AddWithValue("@prod", prodID)
                    cmd.Parameters.AddWithValue("@qty", newQty)
                    cmd.Parameters.AddWithValue("@date", dtpDate.Value)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            UpdateProductStock(prodID, newQty - oldQty)

            MsgBox("Purchase updated successfully.", MsgBoxStyle.Information, APP_TITLE)
            btnClear.PerformClick()
            LoadHistory()

        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, APP_TITLE)
        End Try
    End Sub

    ' ================= DELETE (RESTORED) =================
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If IsInactive(btnDelete) Then Exit Sub

        If MsgBox("Are you sure you want to delete this purchase?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, APP_TITLE) = MsgBoxResult.No Then Exit Sub

        Try
            Dim qty As Integer = Convert.ToInt32(dgvList.CurrentRow.Cells("Quantity").Value)
            Dim prodID As String = dgvList.CurrentRow.Cells("ProductID").Value.ToString()

            Using conn As New MySqlConnection(connectionString)
                Using cmd As New MySqlCommand("DELETE FROM purchase WHERE PurchaseID=@id", conn)
                    cmd.Parameters.AddWithValue("@id", txtPurchaseID.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            UpdateProductStock(prodID, -qty)

            MsgBox("Purchase deleted successfully.", MsgBoxStyle.Information, APP_TITLE)
            btnClear.PerformClick()
            LoadHistory()

        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, APP_TITLE)
        End Try
    End Sub

    ' ================= CLEAR =================
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPurchaseID.Clear()
        txtQuantity.Clear()
        txtPrice.Clear()
        txtTotal.Clear()
        txtStock.Clear()

        cbSupplier.SelectedIndex = 0
        cbProduct.SelectedIndex = 0

        txtPurchaseID.Enabled = True

        SetButtonState(btnAdd, True)
        SetButtonState(btnUpdate, False)
        SetButtonState(btnDelete, False)
    End Sub

    Private Sub cbProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProduct.SelectedIndexChanged
        If cbProduct.SelectedIndex = 0 Then
            txtPrice.Clear()
            txtTotal.Clear()
            txtStock.Clear()
            Exit Sub
        End If

        Dim cost As Decimal = GetProductCost(cbProduct.SelectedValue.ToString())

        txtPrice.Text = cost.ToString("N2")
        txtStock.Text = GetProductStock(cbProduct.SelectedValue.ToString()).ToString()

        If IsNumeric(txtQuantity.Text) Then
            txtTotal.Text = (cost * Convert.ToDecimal(txtQuantity.Text)).ToString("N2")
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

        Dim cost As Decimal = GetProductCost(cbProduct.SelectedValue.ToString())

        txtPrice.Text = cost.ToString("N2")
        txtStock.Text = GetProductStock(cbProduct.SelectedValue.ToString()).ToString()

        If IsNumeric(txtQuantity.Text) Then
            txtTotal.Text = (cost * Convert.ToDecimal(txtQuantity.Text)).ToString("N2")
        Else
            txtTotal.Clear()
        End If
    End Sub

End Class