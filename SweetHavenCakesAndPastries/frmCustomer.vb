Imports MySql.Data.MySqlClient

Public Class frmCustomer
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

    Private Sub frmCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectionString = "datasource=localhost;username=root;password=;database=sweet_haven"
        query = "SELECT * FROM customer ORDER BY CustomerID"
        dbConnection = New MySqlConnection(connectionString)

        SetupButtonStyles()

        ' BUTTON STATES
        SetButtonState(btnAdd, True)
        SetButtonState(btnUpdate, False)
        SetButtonState(btnDelete, False)

        Try
            dbConnection.Open()
            sqlAdapter.SelectCommand = New MySqlCommand(query, dbConnection)
            Dim commandBuilder As New MySqlCommandBuilder(sqlAdapter)

            sqlAdapter.Fill(dataSet, "customer")

            dgvList.DataSource = dataSet
            dgvList.DataMember = "customer"

            ' HEADERS
            dgvList.Columns(0).HeaderText = "ID"
            dgvList.Columns(1).HeaderText = "First Name"
            dgvList.Columns(2).HeaderText = "Middle Name"
            dgvList.Columns(3).HeaderText = "Last Name"
            dgvList.Columns(4).HeaderText = "Contact Number"

            ' ALIGNMENT
            dgvList.Columns("CustomerID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvList.Columns("ContactNo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvList.Columns("FirstName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvList.Columns("MiddleName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dgvList.Columns("LastName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            ' SAME STYLE AS OTHER FORMS
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

        Dim dataTable As DataTable = dataSet.Tables("customer")
        Dim newRow As DataRow

        Try
            ' ================= STRING VALIDATION =================
            Dim customerID As String = txtCustomerID.Text.Trim()
            Dim firstName As String = txtCustomerFirstName.Text.Trim()
            Dim middleName As String = txtCustomerMiddleName.Text.Trim()
            Dim lastName As String = txtCustomerLastName.Text.Trim()
            Dim contactNo As String = txtCustomerContact.Text.Trim()

            ' REQUIRED FIELDS (except middle name)
            If customerID = "" OrElse firstName = "" OrElse lastName = "" OrElse contactNo = "" Then
                MsgBox("Customer ID, First Name, Last Name, and Contact Number are required.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            ' ================= CUSTOMER ID =================
            If Not System.Text.RegularExpressions.Regex.IsMatch(customerID, "^C\d{3}$") Then
                MsgBox("Customer ID must be exactly 4 characters in format C### (e.g., C001).", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            ' ================= NAME LENGTH =================
            If firstName.Length > 30 Then
                MsgBox("First Name must not exceed 30 characters.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            If middleName.Length > 30 Then
                MsgBox("Middle Name must not exceed 30 characters.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            If lastName.Length > 30 Then
                MsgBox("Last Name must not exceed 30 characters.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            ' ================= CONTACT NUMBER =================
            ' must be exactly 11 digits
            If Not System.Text.RegularExpressions.Regex.IsMatch(contactNo, "^\d{11}$") Then
                MsgBox("Contact Number must be exactly 11 digits.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            ' ================= DUPLICATE CHECK =================
            For Each r As DataRow In dataTable.Rows
                If r("CustomerID").ToString() = customerID Then
                    MsgBox("Customer ID already exists.", MsgBoxStyle.Exclamation, APP_TITLE)
                    Exit Sub
                End If
            Next

            ' ================= INSERT =================
            newRow = dataTable.NewRow()

            newRow("CustomerID") = customerID
            newRow("FirstName") = firstName
            newRow("MiddleName") = middleName   ' can be empty
            newRow("LastName") = lastName
            newRow("ContactNo") = contactNo

            dataTable.Rows.Add(newRow)
            sqlAdapter.Update(dataSet, "customer")

            MsgBox("Customer successfully added.", MsgBoxStyle.Information, APP_TITLE)

            btnClear.PerformClick()

        Catch ex As MySqlException
            MsgBox(ex.ToString, MsgBoxStyle.Critical, APP_TITLE)
        End Try
    End Sub

    ' ================= CLEAR =================
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCustomerID.Clear()
        txtCustomerFirstName.Clear()
        txtCustomerMiddleName.Clear()
        txtCustomerLastName.Clear()
        txtCustomerContact.Clear()

        txtCustomerID.Enabled = True
        txtCustomerID.Focus()

        SetButtonState(btnAdd, True)
        SetButtonState(btnUpdate, False)
        SetButtonState(btnDelete, False)
    End Sub

    ' ================= GRID CLICK =================
    Private Sub dgvList_MouseUp(sender As Object, e As MouseEventArgs) Handles dgvList.MouseUp
        txtCustomerID.Text = dgvList.CurrentRow.Cells(0).Value.ToString
        txtCustomerFirstName.Text = dgvList.CurrentRow.Cells(1).Value.ToString
        txtCustomerMiddleName.Text = dgvList.CurrentRow.Cells(2).Value.ToString
        txtCustomerLastName.Text = dgvList.CurrentRow.Cells(3).Value.ToString
        txtCustomerContact.Text = dgvList.CurrentRow.Cells(4).Value.ToString

        row = dgvList.CurrentRow.Index

        txtCustomerID.Enabled = False

        SetButtonState(btnAdd, False)
        SetButtonState(btnUpdate, True)
        SetButtonState(btnDelete, True)

        Me.AutoScrollPosition = New Point(0, 0)
    End Sub

    ' ================= UPDATE =================
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If IsInactive(btnUpdate) Then Exit Sub

        If MsgBox("Save changes to this customer?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, APP_TITLE) = MsgBoxResult.No Then Exit Sub

        Dim dataTable As DataTable = dataSet.Tables("customer")

        Try
            Dim firstName As String = txtCustomerFirstName.Text.Trim()
            Dim middleName As String = txtCustomerMiddleName.Text.Trim()
            Dim lastName As String = txtCustomerLastName.Text.Trim()
            Dim contactNo As String = txtCustomerContact.Text.Trim()

            ' REQUIRED (except middle)
            If firstName = "" OrElse lastName = "" OrElse contactNo = "" Then
                MsgBox("First Name, Last Name, and Contact Number are required.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            ' NAME LENGTH
            If firstName.Length > 30 Then
                MsgBox("First Name must not exceed 30 characters.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            If middleName.Length > 30 Then
                MsgBox("Middle Name must not exceed 30 characters.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            If lastName.Length > 30 Then
                MsgBox("Last Name must not exceed 30 characters.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            ' CONTACT NUMBER
            If Not System.Text.RegularExpressions.Regex.IsMatch(contactNo, "^\d{11}$") Then
                MsgBox("Contact Number must be exactly 11 digits.", MsgBoxStyle.Exclamation, APP_TITLE)
                Exit Sub
            End If

            ' ================= UPDATE =================
            dataTable.Rows(row)("FirstName") = firstName
            dataTable.Rows(row)("MiddleName") = middleName
            dataTable.Rows(row)("LastName") = lastName
            dataTable.Rows(row)("ContactNo") = contactNo

            sqlAdapter.Update(dataSet, "customer")

            MsgBox("Customer updated successfully.", MsgBoxStyle.Information, APP_TITLE)

            btnClear.PerformClick()

        Catch ex As MySqlException
            MsgBox(ex.ToString, MsgBoxStyle.Critical, APP_TITLE)
        End Try
    End Sub

    ' ================= DELETE =================
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If IsInactive(btnDelete) Then Exit Sub

        If MsgBox("Are you sure you want to delete this customer?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, APP_TITLE) = MsgBoxResult.No Then Exit Sub

        Dim dataTable As DataTable = dataSet.Tables("customer")

        Try
            dataTable.Rows(row).Delete()
            sqlAdapter.Update(dataSet, "customer")

            MsgBox("Customer deleted successfully.", MsgBoxStyle.Information, APP_TITLE)

            btnClear.PerformClick()

        Catch ex As MySqlException
            MsgBox(ex.ToString, MsgBoxStyle.Critical, APP_TITLE)
        End Try
    End Sub

End Class