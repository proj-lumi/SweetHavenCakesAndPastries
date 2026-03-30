Imports MySql.Data.MySqlClient

Public Class frmProduct
    Dim dbConnection As Common.DbConnection
    Dim sqlAdapter As New MySqlDataAdapter()
    Dim dataSet As New DataSet()
    Dim connectionString As String
    Dim query As String
    Dim row As Integer
    Const APP_TITLE As String = "SweetHaven"

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

    ' ================= BUTTON STYLE (NO BLUE BORDER) =================
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

    Private Sub frmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectionString = "datasource=localhost;username=root;password=;database=sweet_haven"
        query = "SELECT * FROM product ORDER BY ProductID"
        dbConnection = New MySqlConnection(connectionString)

        SetupButtonStyles()

        ' INITIAL BUTTON STATE
        SetButtonState(btnAdd, True)
        SetButtonState(btnUpdate, False)
        SetButtonState(btnDelete, False)

        Try
            dbConnection.Open()
            sqlAdapter.SelectCommand = New MySqlCommand(query, dbConnection)
            Dim commandBuilder As New MySqlCommandBuilder(sqlAdapter)

            sqlAdapter.Fill(dataSet, "product")

            dgvList.DataSource = dataSet
            dgvList.DataMember = "product"

            ' ================= HEADERS =================
            dgvList.Columns(0).HeaderText = "ID"
            dgvList.Columns(1).HeaderText = "Product Name"
            dgvList.Columns(2).HeaderText = "Cost"
            dgvList.Columns(3).HeaderText = "Selling Price"
            dgvList.Columns(4).HeaderText = "Stock"

            ' ================= ALIGNMENT =================
            dgvList.Columns("ProductID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvList.Columns("Cost").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvList.Columns("SellingPrice").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvList.Columns("Stock").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dgvList.Columns("Cost").DefaultCellStyle.Format = "N2"
            dgvList.Columns("SellingPrice").DefaultCellStyle.Format = "N2"

            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvList.Columns("ProductName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            ' ================= DGV SELECTION COLOR =================
            dgvList.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#FFB7CC")
            dgvList.DefaultCellStyle.SelectionForeColor = Color.Black

        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, APP_TITLE)
        Finally
            dbConnection.Close()
        End Try
    End Sub

    ' ================= ADD =================
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If IsInactive(btnAdd) Then Exit Sub

        Dim dataTable As DataTable = dataSet.Tables("product")
        Dim newRow As DataRow

        Try
            ' ================= STRING VALIDATION =================
            Dim productID As String = txtProductID.Text.Trim()
            Dim productName As String = txtProductName.Text.Trim()

            If productID = "" OrElse productName = "" Then
                MsgBox("Product ID and Product Name are required.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            ' EXACT FORMAT: P###
            If Not System.Text.RegularExpressions.Regex.IsMatch(productID, "^P\d{3}$") Then
                MsgBox("Product ID must be exactly 4 characters in format P### (e.g., P001).", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            ' ProductName max length
            If productName.Length > 100 Then
                MsgBox("Product Name must not exceed 100 characters.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            ' ================= DUPLICATE CHECK =================
            For Each r As DataRow In dataTable.Rows
                If r("ProductID").ToString() = productID Then
                    MsgBox("Product ID already exists.", MsgBoxStyle.Exclamation, APP_TITLE)
                    Exit Sub
                End If
            Next

            ' ================= NUMERIC VALIDATION =================
            Dim cost As Decimal
            Dim price As Decimal
            Dim stock As Integer

            If Not Decimal.TryParse(txtProductCost.Text, cost) Then
                MsgBox("Invalid Cost.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            If Not Decimal.TryParse(txtProductPrice.Text, price) Then
                MsgBox("Invalid Selling Price.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            If Not Integer.TryParse(txtProductStock.Text, stock) Then
                MsgBox("Invalid Stock.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            ' ================= RANGE VALIDATION =================
            If cost < 0 Then
                MsgBox("Cost cannot be negative.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            If price < 0 Then
                MsgBox("Selling Price cannot be negative.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            If stock < 0 Then
                MsgBox("Stock cannot be negative.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            ' decimal(7,2) → max 99999.99
            If cost > 99999.99D Then
                MsgBox("Cost exceeds maximum allowed value (99999.99).", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            If price > 99999.99D Then
                MsgBox("Selling Price exceeds maximum allowed value (99999.99).", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            ' tinyint → max 255
            If stock > 255 Then
                MsgBox("Stock cannot exceed 255.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            ' ================= INSERT =================
            newRow = dataTable.NewRow()

            newRow("ProductID") = productID
            newRow("ProductName") = productName
            newRow("Cost") = cost
            newRow("SellingPrice") = price
            newRow("Stock") = stock

            dataTable.Rows.Add(newRow)
            sqlAdapter.Update(dataSet, "product")

            MsgBox("Product added successfully.", MsgBoxStyle.Information, APP_TITLE)

            btnClear.PerformClick()

        Catch ex As MySqlException
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, APP_TITLE)
        End Try
    End Sub

    ' ================= CLEAR =================
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtProductID.Clear()
        txtProductName.Clear()
        txtProductCost.Clear()
        txtProductPrice.Clear()
        txtProductStock.Clear()

        txtProductID.Enabled = True
        txtProductID.Focus()

        SetButtonState(btnAdd, True)
        SetButtonState(btnUpdate, False)
        SetButtonState(btnDelete, False)
    End Sub

    ' ================= GRID CLICK =================
    Private Sub dgvList_MouseUp(sender As Object, e As MouseEventArgs) Handles dgvList.MouseUp
        txtProductID.Text = dgvList.CurrentRow.Cells(0).Value.ToString
        txtProductName.Text = dgvList.CurrentRow.Cells(1).Value.ToString
        txtProductCost.Text = dgvList.CurrentRow.Cells(2).Value.ToString
        txtProductPrice.Text = dgvList.CurrentRow.Cells(3).Value.ToString
        txtProductStock.Text = dgvList.CurrentRow.Cells(4).Value.ToString

        row = dgvList.CurrentRow.Index

        txtProductID.Enabled = False

        SetButtonState(btnAdd, False)
        SetButtonState(btnUpdate, True)
        SetButtonState(btnDelete, True)

        Me.AutoScrollPosition = New Point(0, 0)
    End Sub

    ' ================= UPDATE =================
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If IsInactive(btnUpdate) Then Exit Sub

        If MsgBox("Save changes to this product?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, APP_TITLE) = MsgBoxResult.No Then Exit Sub

        Dim dataTable As DataTable = dataSet.Tables("product")

        Try
            ' ================= STRING VALIDATION =================
            If txtProductName.Text.Trim() = "" Then
                MsgBox("Product Name is required.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            If txtProductName.Text.Length > 100 Then
                MsgBox("Product Name must not exceed 100 characters.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            ' ================= NUMERIC VALIDATION =================
            Dim cost As Decimal
            Dim price As Decimal
            Dim stock As Integer

            If Not Decimal.TryParse(txtProductCost.Text, cost) Then
                MsgBox("Invalid Cost.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            If Not Decimal.TryParse(txtProductPrice.Text, price) Then
                MsgBox("Invalid Selling Price.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            If Not Integer.TryParse(txtProductStock.Text, stock) Then
                MsgBox("Invalid Stock.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            ' ================= RANGE VALIDATION =================
            If cost < 0 Then
                MsgBox("Cost cannot be negative.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            If price < 0 Then
                MsgBox("Selling Price cannot be negative.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            If stock < 0 Then
                MsgBox("Stock cannot be negative.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            If cost > 99999.99D Then
                MsgBox("Cost exceeds maximum allowed value (99999.99).", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            If price > 99999.99D Then
                MsgBox("Selling Price exceeds maximum allowed value (99999.99).", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            If stock > 255 Then
                MsgBox("Stock cannot exceed 255.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            ' ================= UPDATE =================
            dataTable.Rows(row)("ProductName") = txtProductName.Text.Trim()
            dataTable.Rows(row)("Cost") = cost
            dataTable.Rows(row)("SellingPrice") = price
            dataTable.Rows(row)("Stock") = stock

            sqlAdapter.Update(dataSet, "product")

            MsgBox("Product updated successfully.", MsgBoxStyle.Information, APP_TITLE)

            btnClear.PerformClick()

        Catch ex As MySqlException
            MsgBox(ex.ToString, MsgBoxStyle.Critical, APP_TITLE)
        End Try
    End Sub

    ' ================= DELETE =================
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If IsInactive(btnDelete) Then Exit Sub

        If MsgBox("Are you sure you want to delete this product?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, APP_TITLE) = MsgBoxResult.No Then Exit Sub

        Dim dataTable As DataTable = dataSet.Tables("product")

        Try
            dataTable.Rows(row).Delete()
            sqlAdapter.Update(dataSet, "product")

            MsgBox("Product deleted successfully.", MsgBoxStyle.Information, APP_TITLE)

            btnClear.PerformClick()

        Catch ex As MySqlException
            MsgBox(ex.ToString, MsgBoxStyle.Critical, APP_TITLE)
        End Try
    End Sub

End Class