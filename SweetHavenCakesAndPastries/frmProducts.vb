Imports MySql.Data.MySqlClient

Public Class frmProducts
    Dim productConnection As Common.DbConnection
    Dim productAdapter As New MySqlDataAdapter()
    Dim productDataset As New DataSet()
    Dim connectionString As String
    Dim productQuery As String
    Dim row As Integer

    Private Sub frmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connectionString = "datasource=localhost;username=root;password=;database=sweet_haven"
        productQuery = "SELECT * FROM product ORDER BY ProductName"
        productConnection = New MySqlConnection(connectionString)

        btnUpdateProduct.Enabled = False
        btnDeleteProduct.Enabled = False

        Try
            productConnection.Open()
            productAdapter.SelectCommand = New MySqlCommand(productQuery, productConnection)
            Dim productCommandBuilder As New MySqlCommandBuilder(productAdapter)

            productAdapter.Fill(productDataset, "product")

            dgvProducts.DataSource = productDataset
            dgvProducts.DataMember = "product"

            dgvProducts.Columns(0).HeaderText = "ID"
            dgvProducts.Columns(1).HeaderText = "Product Name"
            dgvProducts.Columns(2).HeaderText = "Cost"
            dgvProducts.Columns(3).HeaderText = "Selling Price"
            dgvProducts.Columns(4).HeaderText = "Stock"
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            productConnection.Close()
        End Try
    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Dim productDataTable As DataTable = productDataset.Tables("product")
        Dim newProduct As DataRow

        Try
            newProduct = productDataTable.NewRow()

            newProduct("ProductID") = txtProductID.Text
            newProduct("ProductName") = txtProductName.Text
            newProduct("Cost") = txtProductCost.Text
            newProduct("SellingPrice") = txtProductPrice.Text
            newProduct("Stock") = txtProductStock.Text


            productDataTable.Rows.Add(newProduct)

            productAdapter.Update(productDataset, "product")

            MsgBox("The new product was successfully added.", MsgBoxStyle.Information, "Add Product")

            txtProductID.Clear()
            txtProductName.Clear()
            txtProductStock.Clear()
            txtProductPrice.Clear()
            txtProductStock.Clear()

            txtProductID.Focus()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnClearProduct_Click(sender As Object, e As EventArgs) Handles btnClearProduct.Click
        txtProductID.Clear()
        txtProductName.Clear()
        txtProductPrice.Clear()

        txtProductID.Enabled = True
        txtProductID.Focus()

        btnAddProduct.Enabled = True
        btnDeleteProduct.Enabled = False
        btnUpdateProduct.Enabled = False
    End Sub

    Private Sub dgvProducts_MouseUp(sender As Object, e As MouseEventArgs) Handles dgvProducts.MouseUp
        txtProductID.Text = dgvProducts.CurrentRow.Cells(0).Value.ToString
        txtProductName.Text = dgvProducts.CurrentRow.Cells(1).Value.ToString
        txtProductCost.Text = dgvProducts.CurrentRow.Cells(2).Value.ToString
        txtProductPrice.Text = dgvProducts.CurrentRow.Cells(3).Value.ToString
        txtProductStock.Text = dgvProducts.CurrentRow.Cells(4).Value.ToString

        row = dgvProducts.CurrentRow.Index

        btnAddProduct.Enabled = False
        btnDeleteProduct.Enabled = True
        btnUpdateProduct.Enabled = True
        txtProductID.Enabled = False
    End Sub

    Private Sub btnUpdateProduct_Click(sender As Object, e As EventArgs) Handles btnUpdateProduct.Click
        Dim productDataTable As DataTable = productDataset.Tables("product")

        Try
            productDataTable.Rows(row)("ProductID") = txtProductID.Text
            productDataTable.Rows(row)("ProductName") = txtProductName.Text
            productDataTable.Rows(row)("Cost") = txtProductCost.Text
            productDataTable.Rows(row)("SellingPrice") = txtProductPrice.Text
            productDataTable.Rows(row)("Stock") = txtProductStock.Text

            productAdapter.Update(productDataset, "product")

            MsgBox("The changes in the record were successfully saved.", MsgBoxStyle.Information, "Update Product")

            txtProductID.Clear()
            txtProductName.Clear()
            txtProductCost.Clear()
            txtProductPrice.Clear()
            txtProductStock.Clear()

            txtProductID.Enabled = True
            txtProductID.Focus()

            btnAddProduct.Enabled = True
            btnDeleteProduct.Enabled = False
            btnUpdateProduct.Enabled = False
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnDeleteProduct_Click(sender As Object, e As EventArgs) Handles btnDeleteProduct.Click
        Dim productDataTable As DataTable = productDataset.Tables("product")
        Dim answer As MsgBoxResult
        answer = MsgBox("Are you sure you want to delete this product?", MsgBoxStyle.YesNo, "Delete Product")

        If (answer = MsgBoxResult.Yes) Then
            Try
                productDataTable.Rows(row).Delete()

                productAdapter.Update(productDataset, "product")

                MsgBox("The product was successfully deleted.", MsgBoxStyle.Information, "Delete Product")

                txtProductID.Clear()
                txtProductName.Clear()
                txtProductCost.Clear()
                txtProductPrice.Clear()
                txtProductStock.Clear()

                txtProductID.Enabled = True
                txtProductID.Focus()
                btnAddProduct.Enabled = True
                btnDeleteProduct.Enabled = False
                btnUpdateProduct.Enabled = False
            Catch ex As MySqlException
                MsgBox(ex.ToString)
            End Try
        ElseIf answer = MsgBoxResult.No Then
            MsgBox("Aborting deletion process...", MsgBoxStyle.OkOnly)

            txtProductID.Clear()
            txtProductName.Clear()
            txtProductCost.Clear()
            txtProductPrice.Clear()
            txtProductStock.Clear()

            txtProductID.Enabled = True
            txtProductID.Focus()
            btnAddProduct.Enabled = True
            btnDeleteProduct.Enabled = False
            btnUpdateProduct.Enabled = False
        End If
    End Sub
End Class