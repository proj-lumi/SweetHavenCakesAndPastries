Public Class frmMain
    Private currentForm As Form = Nothing
    Private activeButton As Button = Nothing

    ' ================= OPEN CHILD FORM =================
    Private Sub OpenChildForm(childForm As Form)
        If currentForm IsNot Nothing Then
            currentForm.Dispose()
        End If

        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(childForm)

        childForm.BringToFront()
        childForm.Show()
    End Sub

    ' ================= NAVIGATION STYLE =================
    Private Sub navigateButton(button As Button)

        Dim buttons As Button() = {btnDashboard, btnProducts, btnCustomers, btnSuppliers, btnSales, btnPurchases}

        ' RESET ALL (INACTIVE)
        For Each btn In buttons
            btn.BackColor = ColorTranslator.FromHtml("#FFF1F5")
            btn.ForeColor = Color.Black

            ' 🔥 INACTIVE IMAGES
            If btn Is btnDashboard Then btn.Image = My.Resources.dashboard_inactive
            If btn Is btnProducts Then btn.Image = My.Resources.products_inactive
            If btn Is btnCustomers Then btn.Image = My.Resources.customers_inactive
            If btn Is btnSuppliers Then btn.Image = My.Resources.suppliers_inactive
            If btn Is btnSales Then btn.Image = My.Resources.sales_inactive
            If btn Is btnPurchases Then btn.Image = My.Resources.purchases_inactive
        Next

        ' SET ACTIVE
        activeButton = button
        button.BackColor = ColorTranslator.FromHtml("#FF9BB8")
        button.ForeColor = ColorTranslator.FromHtml("#FFF1F5")

        ' 🔥 ACTIVE IMAGE
        If button Is btnDashboard Then button.Image = My.Resources.dashboard_active
        If button Is btnProducts Then button.Image = My.Resources.products_active
        If button Is btnCustomers Then button.Image = My.Resources.customers_active
        If button Is btnSuppliers Then button.Image = My.Resources.suppliers_active
        If button Is btnSales Then button.Image = My.Resources.sales_active
        If button Is btnPurchases Then button.Image = My.Resources.purchases_active

    End Sub

    ' ================= FORM LOAD =================
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenChildForm(New frmDashboard())
        navigateButton(btnDashboard)
    End Sub

    ' ================= BUTTON EVENTS =================

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        If activeButton Is btnDashboard Then Exit Sub
        OpenChildForm(New frmDashboard())
        navigateButton(btnDashboard)
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        If activeButton Is btnProducts Then Exit Sub
        OpenChildForm(New frmProduct())
        navigateButton(btnProducts)
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        If activeButton Is btnCustomers Then Exit Sub
        OpenChildForm(New frmCustomer())
        navigateButton(btnCustomers)
    End Sub

    Private Sub btnSuppliers_Click(sender As Object, e As EventArgs) Handles btnSuppliers.Click
        If activeButton Is btnSuppliers Then Exit Sub
        OpenChildForm(New frmSupplier())
        navigateButton(btnSuppliers)
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        If activeButton Is btnSales Then Exit Sub
        OpenChildForm(New frmSales())
        navigateButton(btnSales)
    End Sub

    Private Sub btnPurchases_Click(sender As Object, e As EventArgs) Handles btnPurchases.Click
        If activeButton Is btnPurchases Then Exit Sub
        OpenChildForm(New frmPurchase())
        navigateButton(btnPurchases)
    End Sub

End Class