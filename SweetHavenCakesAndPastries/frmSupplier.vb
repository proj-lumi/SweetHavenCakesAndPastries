Imports MySql.Data.MySqlClient

Public Class frmSupplier
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

    Private Sub frmSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectionString = "datasource=localhost;username=root;password=;database=sweet_haven"
        query = "SELECT * FROM supplier ORDER BY SupplierID"
        dbConnection = New MySqlConnection(connectionString)

        SetupButtonStyles()

        SetButtonState(btnAdd, True)
        SetButtonState(btnUpdate, False)
        SetButtonState(btnDelete, False)

        Try
            dbConnection.Open()
            sqlAdapter.SelectCommand = New MySqlCommand(query, dbConnection)
            Dim commandBuilder As New MySqlCommandBuilder(sqlAdapter)

            sqlAdapter.Fill(dataSet, "supplier")

            dgvList.DataSource = dataSet
            dgvList.DataMember = "supplier"

            dgvList.Columns(0).HeaderText = "ID"
            dgvList.Columns(1).HeaderText = "Supplier Name"
            dgvList.Columns(2).HeaderText = "Contact Number"

            dgvList.Columns("SupplierID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvList.Columns("ContactNo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvList.Columns("SupplierName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

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

        Dim dataTable As DataTable = dataSet.Tables("supplier")
        Dim newRow As DataRow

        Try
            Dim supplierID As String = txtSupplierID.Text.Trim()
            Dim supplierName As String = txtSupplierName.Text.Trim()
            Dim contactNo As String = txtSupplierContact.Text.Trim()

            If supplierID = "" OrElse supplierName = "" OrElse contactNo = "" Then
                MsgBox("Supplier ID, Supplier Name, and Contact Number are required.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            If Not System.Text.RegularExpressions.Regex.IsMatch(supplierID, "^S\d{3}$") Then
                MsgBox("Supplier ID must be exactly 4 characters in format S### (e.g., S001).", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            If supplierName.Length > 100 Then
                MsgBox("Supplier Name must not exceed 100 characters.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            If Not System.Text.RegularExpressions.Regex.IsMatch(contactNo, "^\d{11}$") Then
                MsgBox("Contact Number must be exactly 11 digits.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            For Each r As DataRow In dataTable.Rows
                If r("SupplierID").ToString() = supplierID Then
                    MsgBox("Supplier ID already exists.", MsgBoxStyle.Exclamation, APP_TITLE)
                    Exit Sub
                End If
            Next

            newRow = dataTable.NewRow()

            newRow("SupplierID") = supplierID
            newRow("SupplierName") = supplierName
            newRow("ContactNo") = contactNo

            dataTable.Rows.Add(newRow)
            sqlAdapter.Update(dataSet, "supplier")

            MsgBox("Supplier added successfully.", MsgBoxStyle.Information, APP_TITLE)

            btnClear.PerformClick()

        Catch ex As MySqlException
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, APP_TITLE)
        End Try
    End Sub

    ' ================= CLEAR =================
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSupplierID.Clear()
        txtSupplierName.Clear()
        txtSupplierContact.Clear()

        txtSupplierID.Enabled = True
        txtSupplierID.Focus()

        SetButtonState(btnAdd, True)
        SetButtonState(btnUpdate, False)
        SetButtonState(btnDelete, False)
    End Sub

    ' ================= GRID CLICK =================
    Private Sub dgvList_MouseUp(sender As Object, e As MouseEventArgs) Handles dgvList.MouseUp
        txtSupplierID.Text = dgvList.CurrentRow.Cells(0).Value.ToString
        txtSupplierName.Text = dgvList.CurrentRow.Cells(1).Value.ToString
        txtSupplierContact.Text = dgvList.CurrentRow.Cells(2).Value.ToString

        row = dgvList.CurrentRow.Index

        txtSupplierID.Enabled = False

        SetButtonState(btnAdd, False)
        SetButtonState(btnUpdate, True)
        SetButtonState(btnDelete, True)

        Me.AutoScrollPosition = New Point(0, 0)
    End Sub

    ' ================= UPDATE =================
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If IsInactive(btnUpdate) Then Exit Sub

        If MsgBox("Save changes to this supplier?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, APP_TITLE) = MsgBoxResult.No Then Exit Sub

        Dim dataTable As DataTable = dataSet.Tables("supplier")

        Try
            Dim supplierName As String = txtSupplierName.Text.Trim()
            Dim contactNo As String = txtSupplierContact.Text.Trim()

            If supplierName = "" OrElse contactNo = "" Then
                MsgBox("Supplier Name and Contact Number are required.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            If supplierName.Length > 100 Then
                MsgBox("Supplier Name must not exceed 100 characters.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            If Not System.Text.RegularExpressions.Regex.IsMatch(contactNo, "^\d{11}$") Then
                MsgBox("Contact Number must be exactly 11 digits.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            dataTable.Rows(row)("SupplierName") = supplierName
            dataTable.Rows(row)("ContactNo") = contactNo

            sqlAdapter.Update(dataSet, "supplier")

            MsgBox("Supplier updated successfully.", MsgBoxStyle.Information, APP_TITLE)

            btnClear.PerformClick()

        Catch ex As MySqlException
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, APP_TITLE)
        End Try
    End Sub

    ' ================= DELETE =================
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If IsInactive(btnDelete) Then Exit Sub

        If MsgBox("Are you sure you want to delete this supplier?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, APP_TITLE) = MsgBoxResult.No Then Exit Sub

        Dim dataTable As DataTable = dataSet.Tables("supplier")

        Try
            dataTable.Rows(row).Delete()
            sqlAdapter.Update(dataSet, "supplier")

            MsgBox("Supplier deleted successfully.", MsgBoxStyle.Information, APP_TITLE)

            btnClear.PerformClick()

        Catch ex As MySqlException
            MsgBox(ex.ToString(), MsgBoxStyle.Critical, APP_TITLE)
        End Try
    End Sub

End Class