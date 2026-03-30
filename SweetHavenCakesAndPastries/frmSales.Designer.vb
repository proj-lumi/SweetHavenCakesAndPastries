<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
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
        Me.dgvList = New System.Windows.Forms.DataGridView()
        Me.gbSales = New System.Windows.Forms.GroupBox()
        Me.gbSaleInformation = New System.Windows.Forms.GroupBox()
        Me.gbProduct = New System.Windows.Forms.GroupBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblSalesQuantity = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.cbProduct = New System.Windows.Forms.ComboBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.cbCustomer = New System.Windows.Forms.ComboBox()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtSalesID = New System.Windows.Forms.TextBox()
        Me.lblSalesID = New System.Windows.Forms.Label()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSales.SuspendLayout()
        Me.gbSaleInformation.SuspendLayout()
        Me.gbProduct.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvList
        '
        Me.dgvList.AllowUserToAddRows = False
        Me.dgvList.AllowUserToDeleteRows = False
        Me.dgvList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvList.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.dgvList.Location = New System.Drawing.Point(3, 16)
        Me.dgvList.Name = "dgvList"
        Me.dgvList.ReadOnly = True
        Me.dgvList.Size = New System.Drawing.Size(707, 354)
        Me.dgvList.TabIndex = 0
        Me.dgvList.TabStop = False
        '
        'gbSales
        '
        Me.gbSales.Controls.Add(Me.dgvList)
        Me.gbSales.Location = New System.Drawing.Point(12, 184)
        Me.gbSales.Name = "gbSales"
        Me.gbSales.Size = New System.Drawing.Size(713, 373)
        Me.gbSales.TabIndex = 4
        Me.gbSales.TabStop = False
        Me.gbSales.Text = "Sales List"
        '
        'gbSaleInformation
        '
        Me.gbSaleInformation.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.gbSaleInformation.Controls.Add(Me.gbProduct)
        Me.gbSaleInformation.Controls.Add(Me.lblDate)
        Me.gbSaleInformation.Controls.Add(Me.dtpDate)
        Me.gbSaleInformation.Controls.Add(Me.cbCustomer)
        Me.gbSaleInformation.Controls.Add(Me.lblCustomerName)
        Me.gbSaleInformation.Controls.Add(Me.btnClear)
        Me.gbSaleInformation.Controls.Add(Me.btnDelete)
        Me.gbSaleInformation.Controls.Add(Me.btnUpdate)
        Me.gbSaleInformation.Controls.Add(Me.btnAdd)
        Me.gbSaleInformation.Controls.Add(Me.txtSalesID)
        Me.gbSaleInformation.Controls.Add(Me.lblSalesID)
        Me.gbSaleInformation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gbSaleInformation.Location = New System.Drawing.Point(12, 12)
        Me.gbSaleInformation.Name = "gbSaleInformation"
        Me.gbSaleInformation.Size = New System.Drawing.Size(713, 166)
        Me.gbSaleInformation.TabIndex = 3
        Me.gbSaleInformation.TabStop = False
        Me.gbSaleInformation.Text = "Sales Information"
        '
        'gbProduct
        '
        Me.gbProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.gbProduct.Controls.Add(Me.txtStock)
        Me.gbProduct.Controls.Add(Me.lblStock)
        Me.gbProduct.Controls.Add(Me.lblProductName)
        Me.gbProduct.Controls.Add(Me.txtTotal)
        Me.gbProduct.Controls.Add(Me.lblSalesQuantity)
        Me.gbProduct.Controls.Add(Me.lblTotal)
        Me.gbProduct.Controls.Add(Me.txtQuantity)
        Me.gbProduct.Controls.Add(Me.txtPrice)
        Me.gbProduct.Controls.Add(Me.cbProduct)
        Me.gbProduct.Controls.Add(Me.lblPrice)
        Me.gbProduct.Location = New System.Drawing.Point(6, 60)
        Me.gbProduct.Name = "gbProduct"
        Me.gbProduct.Size = New System.Drawing.Size(701, 67)
        Me.gbProduct.TabIndex = 4
        Me.gbProduct.TabStop = False
        Me.gbProduct.Text = "Product Details"
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(321, 31)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(75, 20)
        Me.txtStock.TabIndex = 26
        Me.txtStock.TabStop = False
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(318, 15)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(35, 13)
        Me.lblStock.TabIndex = 25
        Me.lblStock.Text = "Stock"
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Location = New System.Drawing.Point(6, 16)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(75, 13)
        Me.lblProductName.TabIndex = 2
        Me.lblProductName.Text = "Product Name"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(483, 33)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(75, 20)
        Me.txtTotal.TabIndex = 22
        Me.txtTotal.TabStop = False
        '
        'lblSalesQuantity
        '
        Me.lblSalesQuantity.AutoSize = True
        Me.lblSalesQuantity.Location = New System.Drawing.Point(237, 15)
        Me.lblSalesQuantity.Name = "lblSalesQuantity"
        Me.lblSalesQuantity.Size = New System.Drawing.Size(46, 13)
        Me.lblSalesQuantity.TabIndex = 6
        Me.lblSalesQuantity.Text = "Quantity"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(480, 17)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblTotal.TabIndex = 21
        Me.lblTotal.Text = "Total"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(240, 31)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(75, 20)
        Me.txtQuantity.TabIndex = 2
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(402, 32)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(75, 20)
        Me.txtPrice.TabIndex = 20
        Me.txtPrice.TabStop = False
        '
        'cbProduct
        '
        Me.cbProduct.FormattingEnabled = True
        Me.cbProduct.Location = New System.Drawing.Point(9, 31)
        Me.cbProduct.Name = "cbProduct"
        Me.cbProduct.Size = New System.Drawing.Size(225, 21)
        Me.cbProduct.TabIndex = 1
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(399, 16)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(53, 13)
        Me.lblPrice.TabIndex = 19
        Me.lblPrice.Text = "Unit Price"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(88, 16)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 18
        Me.lblDate.Text = "Date"
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(87, 34)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(75, 20)
        Me.dtpDate.TabIndex = 2
        '
        'cbCustomer
        '
        Me.cbCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCustomer.FormattingEnabled = True
        Me.cbCustomer.Location = New System.Drawing.Point(168, 33)
        Me.cbCustomer.Name = "cbCustomer"
        Me.cbCustomer.Size = New System.Drawing.Size(225, 21)
        Me.cbCustomer.TabIndex = 3
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Location = New System.Drawing.Point(165, 18)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(82, 13)
        Me.lblCustomerName.TabIndex = 15
        Me.lblCustomerName.Text = "Customer Name"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(246, 133)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(165, 133)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(84, 133)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(3, 133)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtSalesID
        '
        Me.txtSalesID.Location = New System.Drawing.Point(6, 34)
        Me.txtSalesID.Name = "txtSalesID"
        Me.txtSalesID.Size = New System.Drawing.Size(75, 20)
        Me.txtSalesID.TabIndex = 1
        '
        'lblSalesID
        '
        Me.lblSalesID.AutoSize = True
        Me.lblSalesID.Location = New System.Drawing.Point(3, 18)
        Me.lblSalesID.Name = "lblSalesID"
        Me.lblSalesID.Size = New System.Drawing.Size(18, 13)
        Me.lblSalesID.TabIndex = 0
        Me.lblSalesID.Text = "ID"
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(0, 10)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(744, 501)
        Me.Controls.Add(Me.gbSales)
        Me.Controls.Add(Me.gbSaleInformation)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "frmSales"
        Me.Text = "Sale"
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSales.ResumeLayout(False)
        Me.gbSaleInformation.ResumeLayout(False)
        Me.gbSaleInformation.PerformLayout()
        Me.gbProduct.ResumeLayout(False)
        Me.gbProduct.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvList As DataGridView
    Friend WithEvents gbSales As GroupBox
    Friend WithEvents gbSaleInformation As GroupBox
    Friend WithEvents gbProduct As GroupBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents lblStock As Label
    Friend WithEvents lblProductName As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblSalesQuantity As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents cbProduct As ComboBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents cbCustomer As ComboBox
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtSalesID As TextBox
    Friend WithEvents lblSalesID As Label
End Class
