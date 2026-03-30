<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.btnPurchases = New System.Windows.Forms.Button()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.btnSuppliers = New System.Windows.Forms.Button()
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.pnlSidebar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.Panel1)
        Me.pnlSidebar.Controls.Add(Me.btnPurchases)
        Me.pnlSidebar.Controls.Add(Me.btnSales)
        Me.pnlSidebar.Controls.Add(Me.btnSuppliers)
        Me.pnlSidebar.Controls.Add(Me.btnCustomers)
        Me.pnlSidebar.Controls.Add(Me.btnProducts)
        Me.pnlSidebar.Controls.Add(Me.btnDashboard)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(200, 501)
        Me.pnlSidebar.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblMain)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 50)
        Me.Panel1.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(13, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cakes and Pastries"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.lblMain.Location = New System.Drawing.Point(12, 9)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(115, 20)
        Me.lblMain.TabIndex = 0
        Me.lblMain.Text = "Sweet Haven"
        Me.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPurchases
        '
        Me.btnPurchases.FlatAppearance.BorderSize = 0
        Me.btnPurchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPurchases.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPurchases.Image = Global.SweetHavenCakesAndPastries.My.Resources.Resources.purchases_inactive
        Me.btnPurchases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPurchases.Location = New System.Drawing.Point(3, 231)
        Me.btnPurchases.Name = "btnPurchases"
        Me.btnPurchases.Size = New System.Drawing.Size(194, 32)
        Me.btnPurchases.TabIndex = 12
        Me.btnPurchases.TabStop = False
        Me.btnPurchases.Text = " Purchase Transactions"
        Me.btnPurchases.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPurchases.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPurchases.UseVisualStyleBackColor = True
        '
        'btnSales
        '
        Me.btnSales.FlatAppearance.BorderSize = 0
        Me.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSales.Image = Global.SweetHavenCakesAndPastries.My.Resources.Resources.sales_inactive
        Me.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSales.Location = New System.Drawing.Point(3, 196)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(194, 32)
        Me.btnSales.TabIndex = 10
        Me.btnSales.TabStop = False
        Me.btnSales.Text = " Sales Transactions"
        Me.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSales.UseVisualStyleBackColor = True
        '
        'btnSuppliers
        '
        Me.btnSuppliers.FlatAppearance.BorderSize = 0
        Me.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuppliers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuppliers.Image = Global.SweetHavenCakesAndPastries.My.Resources.Resources.suppliers_inactive
        Me.btnSuppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSuppliers.Location = New System.Drawing.Point(3, 161)
        Me.btnSuppliers.Name = "btnSuppliers"
        Me.btnSuppliers.Size = New System.Drawing.Size(194, 32)
        Me.btnSuppliers.TabIndex = 9
        Me.btnSuppliers.TabStop = False
        Me.btnSuppliers.Text = " Suppliers"
        Me.btnSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSuppliers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSuppliers.UseVisualStyleBackColor = True
        '
        'btnCustomers
        '
        Me.btnCustomers.FlatAppearance.BorderSize = 0
        Me.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomers.Image = Global.SweetHavenCakesAndPastries.My.Resources.Resources.customers_inactive
        Me.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomers.Location = New System.Drawing.Point(3, 126)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(194, 32)
        Me.btnCustomers.TabIndex = 8
        Me.btnCustomers.TabStop = False
        Me.btnCustomers.Text = " Customers"
        Me.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'btnProducts
        '
        Me.btnProducts.FlatAppearance.BorderSize = 0
        Me.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProducts.Image = Global.SweetHavenCakesAndPastries.My.Resources.Resources.products_inactive
        Me.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducts.Location = New System.Drawing.Point(3, 91)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Size = New System.Drawing.Size(194, 32)
        Me.btnProducts.TabIndex = 7
        Me.btnProducts.TabStop = False
        Me.btnProducts.Text = " Products"
        Me.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProducts.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.Image = Global.SweetHavenCakesAndPastries.My.Resources.Resources.dashboard_inactive
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(3, 56)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(194, 32)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.TabStop = False
        Me.btnDashboard.Text = " Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'pnlContent
        '
        Me.pnlContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(200, 0)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(744, 501)
        Me.pnlContent.TabIndex = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 501)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlSidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sweet Haven - Cakes and Pastries"
        Me.pnlSidebar.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents pnlContent As Panel
    Friend WithEvents btnSales As Button
    Friend WithEvents btnSuppliers As Button
    Friend WithEvents btnCustomers As Button
    Friend WithEvents btnProducts As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMain As Label
    Friend WithEvents btnPurchases As Button
    Friend WithEvents Panel1 As Panel
End Class
