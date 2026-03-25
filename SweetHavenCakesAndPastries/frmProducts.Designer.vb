<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducts
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
        Me.gbProductInformation = New System.Windows.Forms.GroupBox()
        Me.txtProductCost = New System.Windows.Forms.TextBox()
        Me.lblProductCost = New System.Windows.Forms.Label()
        Me.btnClearProduct = New System.Windows.Forms.Button()
        Me.btnDeleteProduct = New System.Windows.Forms.Button()
        Me.btnUpdateProduct = New System.Windows.Forms.Button()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.txtProductStock = New System.Windows.Forms.TextBox()
        Me.lblProductStock = New System.Windows.Forms.Label()
        Me.txtProductPrice = New System.Windows.Forms.TextBox()
        Me.lblProductPrice = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.gbProducts = New System.Windows.Forms.GroupBox()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.gbProductInformation.SuspendLayout()
        Me.gbProducts.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbProductInformation
        '
        Me.gbProductInformation.Controls.Add(Me.txtProductCost)
        Me.gbProductInformation.Controls.Add(Me.lblProductCost)
        Me.gbProductInformation.Controls.Add(Me.btnClearProduct)
        Me.gbProductInformation.Controls.Add(Me.btnDeleteProduct)
        Me.gbProductInformation.Controls.Add(Me.btnUpdateProduct)
        Me.gbProductInformation.Controls.Add(Me.btnAddProduct)
        Me.gbProductInformation.Controls.Add(Me.txtProductStock)
        Me.gbProductInformation.Controls.Add(Me.lblProductStock)
        Me.gbProductInformation.Controls.Add(Me.txtProductPrice)
        Me.gbProductInformation.Controls.Add(Me.lblProductPrice)
        Me.gbProductInformation.Controls.Add(Me.txtProductName)
        Me.gbProductInformation.Controls.Add(Me.lblProductName)
        Me.gbProductInformation.Controls.Add(Me.txtProductID)
        Me.gbProductInformation.Controls.Add(Me.lblProductID)
        Me.gbProductInformation.Location = New System.Drawing.Point(12, 12)
        Me.gbProductInformation.Name = "gbProductInformation"
        Me.gbProductInformation.Size = New System.Drawing.Size(720, 98)
        Me.gbProductInformation.TabIndex = 1
        Me.gbProductInformation.TabStop = False
        Me.gbProductInformation.Text = "Product Information"
        '
        'txtProductCost
        '
        Me.txtProductCost.Location = New System.Drawing.Point(324, 35)
        Me.txtProductCost.Name = "txtProductCost"
        Me.txtProductCost.Size = New System.Drawing.Size(150, 20)
        Me.txtProductCost.TabIndex = 13
        '
        'lblProductCost
        '
        Me.lblProductCost.AutoSize = True
        Me.lblProductCost.Location = New System.Drawing.Point(321, 19)
        Me.lblProductCost.Name = "lblProductCost"
        Me.lblProductCost.Size = New System.Drawing.Size(28, 13)
        Me.lblProductCost.TabIndex = 12
        Me.lblProductCost.Text = "Cost"
        '
        'btnClearProduct
        '
        Me.btnClearProduct.Location = New System.Drawing.Point(255, 61)
        Me.btnClearProduct.Name = "btnClearProduct"
        Me.btnClearProduct.Size = New System.Drawing.Size(75, 23)
        Me.btnClearProduct.TabIndex = 11
        Me.btnClearProduct.Text = "Clear"
        Me.btnClearProduct.UseVisualStyleBackColor = True
        '
        'btnDeleteProduct
        '
        Me.btnDeleteProduct.Location = New System.Drawing.Point(174, 61)
        Me.btnDeleteProduct.Name = "btnDeleteProduct"
        Me.btnDeleteProduct.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteProduct.TabIndex = 10
        Me.btnDeleteProduct.Text = "Delete"
        Me.btnDeleteProduct.UseVisualStyleBackColor = True
        '
        'btnUpdateProduct
        '
        Me.btnUpdateProduct.Location = New System.Drawing.Point(93, 61)
        Me.btnUpdateProduct.Name = "btnUpdateProduct"
        Me.btnUpdateProduct.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateProduct.TabIndex = 9
        Me.btnUpdateProduct.Text = "Update"
        Me.btnUpdateProduct.UseVisualStyleBackColor = True
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Location = New System.Drawing.Point(12, 61)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(75, 23)
        Me.btnAddProduct.TabIndex = 8
        Me.btnAddProduct.Text = "Add New"
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'txtProductStock
        '
        Me.txtProductStock.Location = New System.Drawing.Point(636, 35)
        Me.txtProductStock.Name = "txtProductStock"
        Me.txtProductStock.Size = New System.Drawing.Size(75, 20)
        Me.txtProductStock.TabIndex = 7
        '
        'lblProductStock
        '
        Me.lblProductStock.AutoSize = True
        Me.lblProductStock.Location = New System.Drawing.Point(633, 19)
        Me.lblProductStock.Name = "lblProductStock"
        Me.lblProductStock.Size = New System.Drawing.Size(35, 13)
        Me.lblProductStock.TabIndex = 6
        Me.lblProductStock.Text = "Stock"
        '
        'txtProductPrice
        '
        Me.txtProductPrice.Location = New System.Drawing.Point(480, 35)
        Me.txtProductPrice.Name = "txtProductPrice"
        Me.txtProductPrice.Size = New System.Drawing.Size(150, 20)
        Me.txtProductPrice.TabIndex = 5
        '
        'lblProductPrice
        '
        Me.lblProductPrice.AutoSize = True
        Me.lblProductPrice.Location = New System.Drawing.Point(477, 19)
        Me.lblProductPrice.Name = "lblProductPrice"
        Me.lblProductPrice.Size = New System.Drawing.Size(31, 13)
        Me.lblProductPrice.TabIndex = 4
        Me.lblProductPrice.Text = "Price"
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(93, 35)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(225, 20)
        Me.txtProductName.TabIndex = 3
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Location = New System.Drawing.Point(90, 19)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(75, 13)
        Me.lblProductName.TabIndex = 2
        Me.lblProductName.Text = "Product Name"
        '
        'txtProductID
        '
        Me.txtProductID.Location = New System.Drawing.Point(12, 35)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(75, 20)
        Me.txtProductID.TabIndex = 1
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.Location = New System.Drawing.Point(9, 19)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(18, 13)
        Me.lblProductID.TabIndex = 0
        Me.lblProductID.Text = "ID"
        '
        'gbProducts
        '
        Me.gbProducts.Controls.Add(Me.dgvProducts)
        Me.gbProducts.Location = New System.Drawing.Point(12, 116)
        Me.gbProducts.Name = "gbProducts"
        Me.gbProducts.Size = New System.Drawing.Size(720, 373)
        Me.gbProducts.TabIndex = 2
        Me.gbProducts.TabStop = False
        Me.gbProducts.Text = "Product List"
        '
        'dgvProducts
        '
        Me.dgvProducts.AllowUserToAddRows = False
        Me.dgvProducts.AllowUserToDeleteRows = False
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProducts.Location = New System.Drawing.Point(3, 16)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.ReadOnly = True
        Me.dgvProducts.Size = New System.Drawing.Size(714, 354)
        Me.dgvProducts.TabIndex = 0
        '
        'frmProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 501)
        Me.Controls.Add(Me.gbProducts)
        Me.Controls.Add(Me.gbProductInformation)
        Me.Name = "frmProducts"
        Me.Text = "Products"
        Me.gbProductInformation.ResumeLayout(False)
        Me.gbProductInformation.PerformLayout()
        Me.gbProducts.ResumeLayout(False)
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbProductInformation As GroupBox
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents lblProductID As Label
    Friend WithEvents btnClearProduct As Button
    Friend WithEvents btnDeleteProduct As Button
    Friend WithEvents btnUpdateProduct As Button
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents txtProductStock As TextBox
    Friend WithEvents lblProductStock As Label
    Friend WithEvents txtProductPrice As TextBox
    Friend WithEvents lblProductPrice As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents lblProductName As Label
    Friend WithEvents txtProductCost As TextBox
    Friend WithEvents lblProductCost As Label
    Friend WithEvents gbProducts As GroupBox
    Friend WithEvents dgvProducts As DataGridView
End Class
