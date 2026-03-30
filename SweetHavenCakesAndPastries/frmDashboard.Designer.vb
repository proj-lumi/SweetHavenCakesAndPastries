<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)	
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbOverview = New System.Windows.Forms.GroupBox()
        Me.lblNetProfitLabel = New System.Windows.Forms.Label()
        Me.lblNetProfit = New System.Windows.Forms.Label()
        Me.lblTotalExpensesLabel = New System.Windows.Forms.Label()
        Me.lblTotalExpenses = New System.Windows.Forms.Label()
        Me.lblTotalSalesLabel = New System.Windows.Forms.Label()
        Me.pnlPurchases = New System.Windows.Forms.Panel()
        Me.lblPurchases = New System.Windows.Forms.Label()
        Me.lblPurchaseCount = New System.Windows.Forms.Label()
        Me.pbPurchases = New System.Windows.Forms.PictureBox()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.pnlSales = New System.Windows.Forms.Panel()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.lblSalesCount = New System.Windows.Forms.Label()
        Me.pbSales = New System.Windows.Forms.PictureBox()
        Me.pnlSuppliers = New System.Windows.Forms.Panel()
        Me.lblSuppliers = New System.Windows.Forms.Label()
        Me.lblSupplierCount = New System.Windows.Forms.Label()
        Me.pbSuppliers = New System.Windows.Forms.PictureBox()
        Me.pnlCustomers = New System.Windows.Forms.Panel()
        Me.lblCustomers = New System.Windows.Forms.Label()
        Me.lblCustomerCount = New System.Windows.Forms.Label()
        Me.pbCustomers = New System.Windows.Forms.PictureBox()
        Me.pnlProducts = New System.Windows.Forms.Panel()
        Me.lblProducts = New System.Windows.Forms.Label()
        Me.lblProductCount = New System.Windows.Forms.Label()
        Me.pbProducts = New System.Windows.Forms.PictureBox()
        Me.gbDatabase = New System.Windows.Forms.GroupBox()
        Me.gbTransactions = New System.Windows.Forms.GroupBox()
        Me.lblPurchaseTransactions = New System.Windows.Forms.Label()
        Me.lblSalesTransactionsInfo = New System.Windows.Forms.Label()
        Me.lblPurchaseTransactionsInfo = New System.Windows.Forms.Label()
        Me.lblSalesTransactions = New System.Windows.Forms.Label()
        Me.gbMaster = New System.Windows.Forms.GroupBox()
        Me.lblSuppliersLabel = New System.Windows.Forms.Label()
        Me.lblSuppliersInfo = New System.Windows.Forms.Label()
        Me.lblCustomersLabel = New System.Windows.Forms.Label()
        Me.lblCustomersInfo = New System.Windows.Forms.Label()
        Me.lblProductsLabel = New System.Windows.Forms.Label()
        Me.lblProductsInfo = New System.Windows.Forms.Label()
        Me.gbOverview.SuspendLayout()
        Me.pnlPurchases.SuspendLayout()
        CType(Me.pbPurchases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSales.SuspendLayout()
        CType(Me.pbSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSuppliers.SuspendLayout()
        CType(Me.pbSuppliers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCustomers.SuspendLayout()
        CType(Me.pbCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProducts.SuspendLayout()
        CType(Me.pbProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatabase.SuspendLayout()
        Me.gbTransactions.SuspendLayout()
        Me.gbMaster.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbOverview
        '
        Me.gbOverview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.gbOverview.Controls.Add(Me.lblNetProfitLabel)
        Me.gbOverview.Controls.Add(Me.lblNetProfit)
        Me.gbOverview.Controls.Add(Me.lblTotalExpensesLabel)
        Me.gbOverview.Controls.Add(Me.lblTotalExpenses)
        Me.gbOverview.Controls.Add(Me.lblTotalSalesLabel)
        Me.gbOverview.Controls.Add(Me.pnlPurchases)
        Me.gbOverview.Controls.Add(Me.lblTotalSales)
        Me.gbOverview.Controls.Add(Me.pnlSales)
        Me.gbOverview.Controls.Add(Me.pnlSuppliers)
        Me.gbOverview.Controls.Add(Me.pnlCustomers)
        Me.gbOverview.Controls.Add(Me.pnlProducts)
        Me.gbOverview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOverview.Location = New System.Drawing.Point(12, 12)
        Me.gbOverview.Name = "gbOverview"
        Me.gbOverview.Size = New System.Drawing.Size(720, 303)
        Me.gbOverview.TabIndex = 0
        Me.gbOverview.TabStop = False
        Me.gbOverview.Text = "System Overview"
        '
        'lblNetProfitLabel
        '
        Me.lblNetProfitLabel.AutoSize = True
        Me.lblNetProfitLabel.Location = New System.Drawing.Point(18, 276)
        Me.lblNetProfitLabel.Name = "lblNetProfitLabel"
        Me.lblNetProfitLabel.Size = New System.Drawing.Size(65, 13)
        Me.lblNetProfitLabel.TabIndex = 11
        Me.lblNetProfitLabel.Text = "Net Profit:"
        '
        'lblNetProfit
        '
        Me.lblNetProfit.AutoSize = True
        Me.lblNetProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetProfit.Location = New System.Drawing.Point(82, 276)
        Me.lblNetProfit.Name = "lblNetProfit"
        Me.lblNetProfit.Size = New System.Drawing.Size(13, 13)
        Me.lblNetProfit.TabIndex = 10
        Me.lblNetProfit.Text = "0"
        '
        'lblTotalExpensesLabel
        '
        Me.lblTotalExpensesLabel.AutoSize = True
        Me.lblTotalExpensesLabel.Location = New System.Drawing.Point(17, 260)
        Me.lblTotalExpensesLabel.Name = "lblTotalExpensesLabel"
        Me.lblTotalExpensesLabel.Size = New System.Drawing.Size(98, 13)
        Me.lblTotalExpensesLabel.TabIndex = 9
        Me.lblTotalExpensesLabel.Text = "Total Expenses:"
        '
        'lblTotalExpenses
        '
        Me.lblTotalExpenses.AutoSize = True
        Me.lblTotalExpenses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalExpenses.Location = New System.Drawing.Point(114, 260)
        Me.lblTotalExpenses.Name = "lblTotalExpenses"
        Me.lblTotalExpenses.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalExpenses.TabIndex = 8
        Me.lblTotalExpenses.Text = "0"
        '
        'lblTotalSalesLabel
        '
        Me.lblTotalSalesLabel.AutoSize = True
        Me.lblTotalSalesLabel.Location = New System.Drawing.Point(17, 244)
        Me.lblTotalSalesLabel.Name = "lblTotalSalesLabel"
        Me.lblTotalSalesLabel.Size = New System.Drawing.Size(75, 13)
        Me.lblTotalSalesLabel.TabIndex = 7
        Me.lblTotalSalesLabel.Text = "Total Sales:"
        '
        'pnlPurchases
        '
        Me.pnlPurchases.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPurchases.Controls.Add(Me.lblPurchases)
        Me.pnlPurchases.Controls.Add(Me.lblPurchaseCount)
        Me.pnlPurchases.Controls.Add(Me.pbPurchases)
        Me.pnlPurchases.Location = New System.Drawing.Point(574, 37)
        Me.pnlPurchases.Name = "pnlPurchases"
        Me.pnlPurchases.Size = New System.Drawing.Size(134, 192)
        Me.pnlPurchases.TabIndex = 4
        '
        'lblPurchases
        '
        Me.lblPurchases.AutoSize = True
        Me.lblPurchases.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPurchases.Location = New System.Drawing.Point(58, 149)
        Me.lblPurchases.Name = "lblPurchases"
        Me.lblPurchases.Size = New System.Drawing.Size(19, 20)
        Me.lblPurchases.TabIndex = 2
        Me.lblPurchases.Text = "0"
        Me.lblPurchases.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPurchaseCount
        '
        Me.lblPurchaseCount.AutoSize = True
        Me.lblPurchaseCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPurchaseCount.Location = New System.Drawing.Point(39, 171)
        Me.lblPurchaseCount.Name = "lblPurchaseCount"
        Me.lblPurchaseCount.Size = New System.Drawing.Size(57, 13)
        Me.lblPurchaseCount.TabIndex = 1
        Me.lblPurchaseCount.Text = "Purchases"
        Me.lblPurchaseCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbPurchases
        '
        Me.pbPurchases.Image = Global.SweetHavenCakesAndPastries.My.Resources.Resources.purchases
        Me.pbPurchases.Location = New System.Drawing.Point(3, 2)
        Me.pbPurchases.Name = "pbPurchases"
        Me.pbPurchases.Size = New System.Drawing.Size(126, 141)
        Me.pbPurchases.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbPurchases.TabIndex = 0
        Me.pbPurchases.TabStop = False
        '
        'lblTotalSales
        '
        Me.lblTotalSales.AutoSize = True
        Me.lblTotalSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSales.Location = New System.Drawing.Point(91, 244)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalSales.TabIndex = 6
        Me.lblTotalSales.Text = "0"
        '
        'pnlSales
        '
        Me.pnlSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSales.Controls.Add(Me.lblSales)
        Me.pnlSales.Controls.Add(Me.lblSalesCount)
        Me.pnlSales.Controls.Add(Me.pbSales)
        Me.pnlSales.Location = New System.Drawing.Point(434, 37)
        Me.pnlSales.Name = "pnlSales"
        Me.pnlSales.Size = New System.Drawing.Size(134, 192)
        Me.pnlSales.TabIndex = 4
        '
        'lblSales
        '
        Me.lblSales.AutoSize = True
        Me.lblSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSales.Location = New System.Drawing.Point(56, 149)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(19, 20)
        Me.lblSales.TabIndex = 2
        Me.lblSales.Text = "0"
        Me.lblSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSalesCount
        '
        Me.lblSalesCount.AutoSize = True
        Me.lblSalesCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesCount.Location = New System.Drawing.Point(49, 171)
        Me.lblSalesCount.Name = "lblSalesCount"
        Me.lblSalesCount.Size = New System.Drawing.Size(33, 13)
        Me.lblSalesCount.TabIndex = 1
        Me.lblSalesCount.Text = "Sales"
        Me.lblSalesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbSales
        '
        Me.pbSales.Image = Global.SweetHavenCakesAndPastries.My.Resources.Resources.sales
        Me.pbSales.Location = New System.Drawing.Point(3, 2)
        Me.pbSales.Name = "pbSales"
        Me.pbSales.Size = New System.Drawing.Size(126, 141)
        Me.pbSales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbSales.TabIndex = 0
        Me.pbSales.TabStop = False
        '
        'pnlSuppliers
        '
        Me.pnlSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSuppliers.Controls.Add(Me.lblSuppliers)
        Me.pnlSuppliers.Controls.Add(Me.lblSupplierCount)
        Me.pnlSuppliers.Controls.Add(Me.pbSuppliers)
        Me.pnlSuppliers.Location = New System.Drawing.Point(294, 37)
        Me.pnlSuppliers.Name = "pnlSuppliers"
        Me.pnlSuppliers.Size = New System.Drawing.Size(134, 192)
        Me.pnlSuppliers.TabIndex = 4
        '
        'lblSuppliers
        '
        Me.lblSuppliers.AutoSize = True
        Me.lblSuppliers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuppliers.Location = New System.Drawing.Point(53, 149)
        Me.lblSuppliers.Name = "lblSuppliers"
        Me.lblSuppliers.Size = New System.Drawing.Size(19, 20)
        Me.lblSuppliers.TabIndex = 2
        Me.lblSuppliers.Text = "0"
        Me.lblSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSupplierCount
        '
        Me.lblSupplierCount.AutoSize = True
        Me.lblSupplierCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplierCount.Location = New System.Drawing.Point(39, 171)
        Me.lblSupplierCount.Name = "lblSupplierCount"
        Me.lblSupplierCount.Size = New System.Drawing.Size(50, 13)
        Me.lblSupplierCount.TabIndex = 1
        Me.lblSupplierCount.Text = "Suppliers"
        Me.lblSupplierCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbSuppliers
        '
        Me.pbSuppliers.Image = Global.SweetHavenCakesAndPastries.My.Resources.Resources.suppliers
        Me.pbSuppliers.Location = New System.Drawing.Point(3, 2)
        Me.pbSuppliers.Name = "pbSuppliers"
        Me.pbSuppliers.Size = New System.Drawing.Size(126, 141)
        Me.pbSuppliers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbSuppliers.TabIndex = 0
        Me.pbSuppliers.TabStop = False
        '
        'pnlCustomers
        '
        Me.pnlCustomers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCustomers.Controls.Add(Me.lblCustomers)
        Me.pnlCustomers.Controls.Add(Me.lblCustomerCount)
        Me.pnlCustomers.Controls.Add(Me.pbCustomers)
        Me.pnlCustomers.Location = New System.Drawing.Point(154, 37)
        Me.pnlCustomers.Name = "pnlCustomers"
        Me.pnlCustomers.Size = New System.Drawing.Size(134, 192)
        Me.pnlCustomers.TabIndex = 4
        '
        'lblCustomers
        '
        Me.lblCustomers.AutoSize = True
        Me.lblCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomers.Location = New System.Drawing.Point(55, 149)
        Me.lblCustomers.Name = "lblCustomers"
        Me.lblCustomers.Size = New System.Drawing.Size(19, 20)
        Me.lblCustomers.TabIndex = 2
        Me.lblCustomers.Text = "0"
        Me.lblCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCustomerCount
        '
        Me.lblCustomerCount.AutoSize = True
        Me.lblCustomerCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerCount.Location = New System.Drawing.Point(39, 171)
        Me.lblCustomerCount.Name = "lblCustomerCount"
        Me.lblCustomerCount.Size = New System.Drawing.Size(56, 13)
        Me.lblCustomerCount.TabIndex = 1
        Me.lblCustomerCount.Text = "Customers"
        Me.lblCustomerCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbCustomers
        '
        Me.pbCustomers.Image = Global.SweetHavenCakesAndPastries.My.Resources.Resources.customers
        Me.pbCustomers.Location = New System.Drawing.Point(3, 2)
        Me.pbCustomers.Name = "pbCustomers"
        Me.pbCustomers.Size = New System.Drawing.Size(126, 141)
        Me.pbCustomers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbCustomers.TabIndex = 0
        Me.pbCustomers.TabStop = False
        '
        'pnlProducts
        '
        Me.pnlProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlProducts.Controls.Add(Me.lblProducts)
        Me.pnlProducts.Controls.Add(Me.lblProductCount)
        Me.pnlProducts.Controls.Add(Me.pbProducts)
        Me.pnlProducts.Location = New System.Drawing.Point(14, 37)
        Me.pnlProducts.Name = "pnlProducts"
        Me.pnlProducts.Size = New System.Drawing.Size(134, 192)
        Me.pnlProducts.TabIndex = 3
        '
        'lblProducts
        '
        Me.lblProducts.AutoSize = True
        Me.lblProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducts.Location = New System.Drawing.Point(54, 149)
        Me.lblProducts.Name = "lblProducts"
        Me.lblProducts.Size = New System.Drawing.Size(19, 20)
        Me.lblProducts.TabIndex = 2
        Me.lblProducts.Text = "0"
        Me.lblProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProductCount
        '
        Me.lblProductCount.AutoSize = True
        Me.lblProductCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductCount.Location = New System.Drawing.Point(41, 171)
        Me.lblProductCount.Name = "lblProductCount"
        Me.lblProductCount.Size = New System.Drawing.Size(49, 13)
        Me.lblProductCount.TabIndex = 1
        Me.lblProductCount.Text = "Products"
        Me.lblProductCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbProducts
        '
        Me.pbProducts.Image = Global.SweetHavenCakesAndPastries.My.Resources.Resources.products
        Me.pbProducts.Location = New System.Drawing.Point(3, 2)
        Me.pbProducts.Name = "pbProducts"
        Me.pbProducts.Size = New System.Drawing.Size(126, 141)
        Me.pbProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbProducts.TabIndex = 0
        Me.pbProducts.TabStop = False
        '
        'gbDatabase
        '
        Me.gbDatabase.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.gbDatabase.Controls.Add(Me.gbTransactions)
        Me.gbDatabase.Controls.Add(Me.gbMaster)
        Me.gbDatabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatabase.Location = New System.Drawing.Point(12, 321)
        Me.gbDatabase.Name = "gbDatabase"
        Me.gbDatabase.Size = New System.Drawing.Size(720, 168)
        Me.gbDatabase.TabIndex = 4
        Me.gbDatabase.TabStop = False
        Me.gbDatabase.Text = "Database Tables"
        '
        'gbTransactions
        '
        Me.gbTransactions.Controls.Add(Me.lblPurchaseTransactions)
        Me.gbTransactions.Controls.Add(Me.lblSalesTransactionsInfo)
        Me.gbTransactions.Controls.Add(Me.lblPurchaseTransactionsInfo)
        Me.gbTransactions.Controls.Add(Me.lblSalesTransactions)
        Me.gbTransactions.Location = New System.Drawing.Point(364, 19)
        Me.gbTransactions.Name = "gbTransactions"
        Me.gbTransactions.Size = New System.Drawing.Size(350, 180)
        Me.gbTransactions.TabIndex = 1
        Me.gbTransactions.TabStop = False
        Me.gbTransactions.Text = "Transactions"
        '
        'lblPurchaseTransactions
        '
        Me.lblPurchaseTransactions.AutoSize = True
        Me.lblPurchaseTransactions.Location = New System.Drawing.Point(14, 58)
        Me.lblPurchaseTransactions.Name = "lblPurchaseTransactions"
        Me.lblPurchaseTransactions.Size = New System.Drawing.Size(145, 13)
        Me.lblPurchaseTransactions.TabIndex = 9
        Me.lblPurchaseTransactions.Text = "Purchase Transactions -"
        '
        'lblSalesTransactionsInfo
        '
        Me.lblSalesTransactionsInfo.AutoSize = True
        Me.lblSalesTransactionsInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesTransactionsInfo.Location = New System.Drawing.Point(135, 37)
        Me.lblSalesTransactionsInfo.Name = "lblSalesTransactionsInfo"
        Me.lblSalesTransactionsInfo.Size = New System.Drawing.Size(131, 13)
        Me.lblSalesTransactionsInfo.TabIndex = 6
        Me.lblSalesTransactionsInfo.Text = "Manage product inventory"
        '
        'lblPurchaseTransactionsInfo
        '
        Me.lblPurchaseTransactionsInfo.AutoSize = True
        Me.lblPurchaseTransactionsInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPurchaseTransactionsInfo.Location = New System.Drawing.Point(157, 58)
        Me.lblPurchaseTransactionsInfo.Name = "lblPurchaseTransactionsInfo"
        Me.lblPurchaseTransactionsInfo.Size = New System.Drawing.Size(130, 13)
        Me.lblPurchaseTransactionsInfo.TabIndex = 8
        Me.lblPurchaseTransactionsInfo.Text = "Manage customer records"
        '
        'lblSalesTransactions
        '
        Me.lblSalesTransactions.AutoSize = True
        Me.lblSalesTransactions.Location = New System.Drawing.Point(14, 37)
        Me.lblSalesTransactions.Name = "lblSalesTransactions"
        Me.lblSalesTransactions.Size = New System.Drawing.Size(123, 13)
        Me.lblSalesTransactions.TabIndex = 7
        Me.lblSalesTransactions.Text = "Sales Transactions -"
        '
        'gbMaster
        '
        Me.gbMaster.Controls.Add(Me.lblSuppliersLabel)
        Me.gbMaster.Controls.Add(Me.lblSuppliersInfo)
        Me.gbMaster.Controls.Add(Me.lblCustomersLabel)
        Me.gbMaster.Controls.Add(Me.lblCustomersInfo)
        Me.gbMaster.Controls.Add(Me.lblProductsLabel)
        Me.gbMaster.Controls.Add(Me.lblProductsInfo)
        Me.gbMaster.Location = New System.Drawing.Point(6, 19)
        Me.gbMaster.Name = "gbMaster"
        Me.gbMaster.Size = New System.Drawing.Size(350, 180)
        Me.gbMaster.TabIndex = 0
        Me.gbMaster.TabStop = False
        Me.gbMaster.Text = "Master Data"
        '
        'lblSuppliersLabel
        '
        Me.lblSuppliersLabel.AutoSize = True
        Me.lblSuppliersLabel.Location = New System.Drawing.Point(4, 78)
        Me.lblSuppliersLabel.Name = "lblSuppliersLabel"
        Me.lblSuppliersLabel.Size = New System.Drawing.Size(67, 13)
        Me.lblSuppliersLabel.TabIndex = 5
        Me.lblSuppliersLabel.Text = "Suppliers -"
        '
        'lblSuppliersInfo
        '
        Me.lblSuppliersInfo.AutoSize = True
        Me.lblSuppliersInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuppliersInfo.Location = New System.Drawing.Point(69, 78)
        Me.lblSuppliersInfo.Name = "lblSuppliersInfo"
        Me.lblSuppliersInfo.Size = New System.Drawing.Size(139, 13)
        Me.lblSuppliersInfo.TabIndex = 4
        Me.lblSuppliersInfo.Text = "Manage supplier information"
        '
        'lblCustomersLabel
        '
        Me.lblCustomersLabel.AutoSize = True
        Me.lblCustomersLabel.Location = New System.Drawing.Point(4, 58)
        Me.lblCustomersLabel.Name = "lblCustomersLabel"
        Me.lblCustomersLabel.Size = New System.Drawing.Size(73, 13)
        Me.lblCustomersLabel.TabIndex = 3
        Me.lblCustomersLabel.Text = "Customers -"
        '
        'lblCustomersInfo
        '
        Me.lblCustomersInfo.AutoSize = True
        Me.lblCustomersInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomersInfo.Location = New System.Drawing.Point(75, 58)
        Me.lblCustomersInfo.Name = "lblCustomersInfo"
        Me.lblCustomersInfo.Size = New System.Drawing.Size(130, 13)
        Me.lblCustomersInfo.TabIndex = 2
        Me.lblCustomersInfo.Text = "Manage customer records"
        '
        'lblProductsLabel
        '
        Me.lblProductsLabel.AutoSize = True
        Me.lblProductsLabel.Location = New System.Drawing.Point(4, 37)
        Me.lblProductsLabel.Name = "lblProductsLabel"
        Me.lblProductsLabel.Size = New System.Drawing.Size(65, 13)
        Me.lblProductsLabel.TabIndex = 1
        Me.lblProductsLabel.Text = "Products -"
        '
        'lblProductsInfo
        '
        Me.lblProductsInfo.AutoSize = True
        Me.lblProductsInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductsInfo.Location = New System.Drawing.Point(67, 37)
        Me.lblProductsInfo.Name = "lblProductsInfo"
        Me.lblProductsInfo.Size = New System.Drawing.Size(131, 13)
        Me.lblProductsInfo.TabIndex = 0
        Me.lblProductsInfo.Text = "Manage product inventory"
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(744, 501)
        Me.Controls.Add(Me.gbDatabase)
        Me.Controls.Add(Me.gbOverview)
        Me.Name = "frmDashboard"
        Me.Text = "Dashboard"
        Me.gbOverview.ResumeLayout(False)
        Me.gbOverview.PerformLayout()
        Me.pnlPurchases.ResumeLayout(False)
        Me.pnlPurchases.PerformLayout()
        CType(Me.pbPurchases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSales.ResumeLayout(False)
        Me.pnlSales.PerformLayout()
        CType(Me.pbSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSuppliers.ResumeLayout(False)
        Me.pnlSuppliers.PerformLayout()
        CType(Me.pbSuppliers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCustomers.ResumeLayout(False)
        Me.pnlCustomers.PerformLayout()
        CType(Me.pbCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProducts.ResumeLayout(False)
        Me.pnlProducts.PerformLayout()
        CType(Me.pbProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatabase.ResumeLayout(False)
        Me.gbTransactions.ResumeLayout(False)
        Me.gbTransactions.PerformLayout()
        Me.gbMaster.ResumeLayout(False)
        Me.gbMaster.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbOverview As GroupBox
    Friend WithEvents gbDatabase As GroupBox
    Friend WithEvents gbMaster As GroupBox
    Friend WithEvents gbTransactions As GroupBox
    Friend WithEvents pnlPurchases As Panel
    Friend WithEvents lblPurchases As Label
    Friend WithEvents lblPurchaseCount As Label
    Friend WithEvents pbPurchases As PictureBox
    Friend WithEvents pnlSales As Panel
    Friend WithEvents lblSales As Label
    Friend WithEvents lblSalesCount As Label
    Friend WithEvents pbSales As PictureBox
    Friend WithEvents pnlSuppliers As Panel
    Friend WithEvents lblSuppliers As Label
    Friend WithEvents lblSupplierCount As Label
    Friend WithEvents pbSuppliers As PictureBox
    Friend WithEvents pnlCustomers As Panel
    Friend WithEvents lblCustomers As Label
    Friend WithEvents lblCustomerCount As Label
    Friend WithEvents pbCustomers As PictureBox
    Friend WithEvents pnlProducts As Panel
    Friend WithEvents lblProducts As Label
    Friend WithEvents lblProductCount As Label
    Friend WithEvents pbProducts As PictureBox
    Friend WithEvents lblPurchaseTransactions As Label
    Friend WithEvents lblSalesTransactionsInfo As Label
    Friend WithEvents lblPurchaseTransactionsInfo As Label
    Friend WithEvents lblSalesTransactions As Label
    Friend WithEvents lblSuppliersLabel As Label
    Friend WithEvents lblSuppliersInfo As Label
    Friend WithEvents lblCustomersLabel As Label
    Friend WithEvents lblCustomersInfo As Label
    Friend WithEvents lblProductsLabel As Label
    Friend WithEvents lblProductsInfo As Label
    Friend WithEvents lblNetProfitLabel As Label
    Friend WithEvents lblNetProfit As Label
    Friend WithEvents lblTotalExpensesLabel As Label
    Friend WithEvents lblTotalExpenses As Label
    Friend WithEvents lblTotalSalesLabel As Label
    Friend WithEvents lblTotalSales As Label
End Class
