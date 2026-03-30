Imports MySql.Data.MySqlClient

Public Class frmDashboard

    Dim connectionString As String = "datasource=localhost;username=root;password=;database=sweet_haven"

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCounts()
        LoadFinancials()
    End Sub

    ' ================= COUNTS =================
    Private Sub LoadCounts()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                lblProducts.Text = GetCount(conn, "product")
                lblCustomers.Text = GetCount(conn, "customer")
                lblSuppliers.Text = GetCount(conn, "supplier")
                lblSales.Text = GetCount(conn, "sales")
                lblPurchases.Text = GetCount(conn, "purchase")

            End Using
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Function GetCount(conn As MySqlConnection, tableName As String) As String
        Dim query As String = "SELECT COUNT(*) FROM " & tableName

        Using cmd As New MySqlCommand(query, conn)
            Dim result = cmd.ExecuteScalar()
            Return result.ToString()
        End Using
    End Function

    ' ================= FINANCIALS =================
    Private Sub LoadFinancials()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim totalSales As Decimal = GetTotalSales(conn)
                Dim totalExpenses As Decimal = GetTotalExpenses(conn)
                Dim netProfit As Decimal = totalSales - totalExpenses

                lblTotalSales.Text = "Php " & totalSales.ToString("N2")
                lblTotalExpenses.Text = "Php " & totalExpenses.ToString("N2")
                lblNetProfit.Text = "Php " & netProfit.ToString("N2")

            End Using
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    ' ================= TOTAL SALES =================
    Private Function GetTotalSales(conn As MySqlConnection) As Decimal
        Dim query As String = "
        SELECT IFNULL(SUM(s.Quantity * p.SellingPrice), 0)
        FROM sales s
        INNER JOIN product p ON s.ProductID = p.ProductID"

        Using cmd As New MySqlCommand(query, conn)
            Dim result = cmd.ExecuteScalar()
            Return Convert.ToDecimal(result)
        End Using
    End Function

    ' ================= TOTAL EXPENSES =================
    Private Function GetTotalExpenses(conn As MySqlConnection) As Decimal
        Dim query As String = "
        SELECT IFNULL(SUM(pu.Quantity * pr.Cost), 0)
        FROM purchase pu
        INNER JOIN product pr ON pu.ProductID = pr.ProductID"

        Using cmd As New MySqlCommand(query, conn)
            Dim result = cmd.ExecuteScalar()
            Return Convert.ToDecimal(result)
        End Using
    End Function

End Class