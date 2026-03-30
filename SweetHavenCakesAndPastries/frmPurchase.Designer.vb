<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchase
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
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblSupplierName = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.cbProduct = New System.Windows.Forms.ComboBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.gbProduct = New System.Windows.Forms.GroupBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.lblPurchaseQuantity = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.cbSupplier = New System.Windows.Forms.ComboBox()
        Me.gbPurchases = New System.Windows.Forms.GroupBox()
        Me.dgvList = New System.Windows.Forms.DataGridView()
        Me.gbPurchaseInformation = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtPurchaseID = New System.Windows.Forms.TextBox()
        Me.lblPurchaseID = New System.Windows.Forms.Label()
        Me.gbProduct.SuspendLayout()
        Me.gbPurchases.SuspendLayout()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPurchaseInformation.SuspendLayout()
        Me.SuspendLayout()
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
        'lblSupplierName
        '
        Me.lblSupplierName.AutoSize = True
        Me.lblSupplierName.Location = New System.Drawing.Point(165, 18)
        Me.lblSupplierName.Name = "lblSupplierName"
        Me.lblSupplierName.Size = New System.Drawing.Size(76, 13)
        Me.lblSupplierName.TabIndex = 15
        Me.lblSupplierName.Text = "Supplier Name"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(483, 33)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(75, 20)
        Me.txtTotal.TabIndex = 22
        Me.txtTotal.TabStop = False
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
        'gbProduct
        '
        Me.gbProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.gbProduct.Controls.Add(Me.txtStock)
        Me.gbProduct.Controls.Add(Me.lblStock)
        Me.gbProduct.Controls.Add(Me.lblProductName)
        Me.gbProduct.Controls.Add(Me.txtTotal)
        Me.gbProduct.Controls.Add(Me.lblPurchaseQuantity)
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
        Me.txtStock.TabIndex = 24
        Me.txtStock.TabStop = False
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(318, 15)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(35, 13)
        Me.lblStock.TabIndex = 23
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
        'lblPurchaseQuantity
        '
        Me.lblPurchaseQuantity.AutoSize = True
        Me.lblPurchaseQuantity.Location = New System.Drawing.Point(237, 15)
        Me.lblPurchaseQuantity.Name = "lblPurchaseQuantity"
        Me.lblPurchaseQuantity.Size = New System.Drawing.Size(46, 13)
        Me.lblPurchaseQuantity.TabIndex = 6
        Me.lblPurchaseQuantity.Text = "Quantity"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(240, 31)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(75, 20)
        Me.txtQuantity.TabIndex = 2
        '
        'cbSupplier
        '
        Me.cbSupplier.FormattingEnabled = True
        Me.cbSupplier.Location = New System.Drawing.Point(168, 33)
        Me.cbSupplier.Name = "cbSupplier"
        Me.cbSupplier.Size = New System.Drawing.Size(225, 21)
        Me.cbSupplier.TabIndex = 3
        '
        'gbPurchases
        '
        Me.gbPurchases.Controls.Add(Me.dgvList)
        Me.gbPurchases.Location = New System.Drawing.Point(12, 184)
        Me.gbPurchases.Name = "gbPurchases"
        Me.gbPurchases.Size = New System.Drawing.Size(713, 373)
        Me.gbPurchases.TabIndex = 24
        Me.gbPurchases.TabStop = False
        Me.gbPurchases.Text = "Purchase List"
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
        'gbPurchaseInformation
        '
        Me.gbPurchaseInformation.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.gbPurchaseInformation.Controls.Add(Me.gbProduct)
        Me.gbPurchaseInformation.Controls.Add(Me.lblDate)
        Me.gbPurchaseInformation.Controls.Add(Me.dtpDate)
        Me.gbPurchaseInformation.Controls.Add(Me.cbSupplier)
        Me.gbPurchaseInformation.Controls.Add(Me.lblSupplierName)
        Me.gbPurchaseInformation.Controls.Add(Me.btnClear)
        Me.gbPurchaseInformation.Controls.Add(Me.btnDelete)
        Me.gbPurchaseInformation.Controls.Add(Me.btnUpdate)
        Me.gbPurchaseInformation.Controls.Add(Me.btnAdd)
        Me.gbPurchaseInformation.Controls.Add(Me.txtPurchaseID)
        Me.gbPurchaseInformation.Controls.Add(Me.lblPurchaseID)
        Me.gbPurchaseInformation.Location = New System.Drawing.Point(12, 12)
        Me.gbPurchaseInformation.Name = "gbPurchaseInformation"
        Me.gbPurchaseInformation.Size = New System.Drawing.Size(713, 166)
        Me.gbPurchaseInformation.TabIndex = 2
        Me.gbPurchaseInformation.TabStop = False
        Me.gbPurchaseInformation.Text = "Purchase Information"
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
        'txtPurchaseID
        '
        Me.txtPurchaseID.Location = New System.Drawing.Point(6, 34)
        Me.txtPurchaseID.Name = "txtPurchaseID"
        Me.txtPurchaseID.Size = New System.Drawing.Size(75, 20)
        Me.txtPurchaseID.TabIndex = 1
        '
        'lblPurchaseID
        '
        Me.lblPurchaseID.AutoSize = True
        Me.lblPurchaseID.Location = New System.Drawing.Point(3, 18)
        Me.lblPurchaseID.Name = "lblPurchaseID"
        Me.lblPurchaseID.Size = New System.Drawing.Size(18, 13)
        Me.lblPurchaseID.TabIndex = 0
        Me.lblPurchaseID.Text = "ID"
        '
        'frmPurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(744, 501)
        Me.Controls.Add(Me.gbPurchases)
        Me.Controls.Add(Me.gbPurchaseInformation)
        Me.Name = "frmPurchase"
        Me.Text = "Purchase"
        Me.gbProduct.ResumeLayout(False)
        Me.gbProduct.PerformLayout()
        Me.gbPurchases.ResumeLayout(False)
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPurchaseInformation.ResumeLayout(False)
        Me.gbPurchaseInformation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblDate As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents lblSupplierName As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents cbProduct As ComboBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents gbProduct As GroupBox
    Friend WithEvents lblProductName As Label
    Friend WithEvents lblPurchaseQuantity As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents cbSupplier As ComboBox
    Friend WithEvents gbPurchases As GroupBox
    Friend WithEvents dgvList As DataGridView
    Friend WithEvents gbPurchaseInformation As GroupBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtPurchaseID As TextBox
    Friend WithEvents lblPurchaseID As Label
    Friend WithEvents txtStock As TextBox
    Friend WithEvents lblStock As Label
End Class
