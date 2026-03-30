<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupplier
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
        Me.txtSupplierContact = New System.Windows.Forms.TextBox()
        Me.lblSupplierContact = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtSupplierName = New System.Windows.Forms.TextBox()
        Me.lblSupplierName = New System.Windows.Forms.Label()
        Me.txtSupplierID = New System.Windows.Forms.TextBox()
        Me.lblSupplierID = New System.Windows.Forms.Label()
        Me.gbSuppliers = New System.Windows.Forms.GroupBox()
        Me.gbProductInformation = New System.Windows.Forms.GroupBox()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSuppliers.SuspendLayout()
        Me.gbProductInformation.SuspendLayout()
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
        Me.dgvList.Size = New System.Drawing.Size(714, 354)
        Me.dgvList.TabIndex = 0
        Me.dgvList.TabStop = False
        '
        'txtSupplierContact
        '
        Me.txtSupplierContact.Location = New System.Drawing.Point(324, 35)
        Me.txtSupplierContact.Name = "txtSupplierContact"
        Me.txtSupplierContact.Size = New System.Drawing.Size(150, 20)
        Me.txtSupplierContact.TabIndex = 3
        '
        'lblSupplierContact
        '
        Me.lblSupplierContact.AutoSize = True
        Me.lblSupplierContact.Location = New System.Drawing.Point(321, 19)
        Me.lblSupplierContact.Name = "lblSupplierContact"
        Me.lblSupplierContact.Size = New System.Drawing.Size(84, 13)
        Me.lblSupplierContact.TabIndex = 12
        Me.lblSupplierContact.Text = "Contact Number"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(255, 61)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(174, 61)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(93, 61)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 61)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtSupplierName
        '
        Me.txtSupplierName.Location = New System.Drawing.Point(93, 35)
        Me.txtSupplierName.Name = "txtSupplierName"
        Me.txtSupplierName.Size = New System.Drawing.Size(225, 20)
        Me.txtSupplierName.TabIndex = 2
        '
        'lblSupplierName
        '
        Me.lblSupplierName.AutoSize = True
        Me.lblSupplierName.Location = New System.Drawing.Point(90, 19)
        Me.lblSupplierName.Name = "lblSupplierName"
        Me.lblSupplierName.Size = New System.Drawing.Size(35, 13)
        Me.lblSupplierName.TabIndex = 2
        Me.lblSupplierName.Text = "Name"
        '
        'txtSupplierID
        '
        Me.txtSupplierID.Location = New System.Drawing.Point(12, 35)
        Me.txtSupplierID.Name = "txtSupplierID"
        Me.txtSupplierID.Size = New System.Drawing.Size(75, 20)
        Me.txtSupplierID.TabIndex = 1
        '
        'lblSupplierID
        '
        Me.lblSupplierID.AutoSize = True
        Me.lblSupplierID.Location = New System.Drawing.Point(9, 19)
        Me.lblSupplierID.Name = "lblSupplierID"
        Me.lblSupplierID.Size = New System.Drawing.Size(18, 13)
        Me.lblSupplierID.TabIndex = 0
        Me.lblSupplierID.Text = "ID"
        '
        'gbSuppliers
        '
        Me.gbSuppliers.Controls.Add(Me.dgvList)
        Me.gbSuppliers.Location = New System.Drawing.Point(12, 116)
        Me.gbSuppliers.Name = "gbSuppliers"
        Me.gbSuppliers.Size = New System.Drawing.Size(720, 373)
        Me.gbSuppliers.TabIndex = 4
        Me.gbSuppliers.TabStop = False
        Me.gbSuppliers.Text = "Supplier List"
        '
        'gbProductInformation
        '
        Me.gbProductInformation.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.gbProductInformation.Controls.Add(Me.txtSupplierContact)
        Me.gbProductInformation.Controls.Add(Me.lblSupplierContact)
        Me.gbProductInformation.Controls.Add(Me.btnClear)
        Me.gbProductInformation.Controls.Add(Me.btnDelete)
        Me.gbProductInformation.Controls.Add(Me.btnUpdate)
        Me.gbProductInformation.Controls.Add(Me.btnAdd)
        Me.gbProductInformation.Controls.Add(Me.txtSupplierName)
        Me.gbProductInformation.Controls.Add(Me.lblSupplierName)
        Me.gbProductInformation.Controls.Add(Me.txtSupplierID)
        Me.gbProductInformation.Controls.Add(Me.lblSupplierID)
        Me.gbProductInformation.Location = New System.Drawing.Point(12, 12)
        Me.gbProductInformation.Name = "gbProductInformation"
        Me.gbProductInformation.Size = New System.Drawing.Size(720, 98)
        Me.gbProductInformation.TabIndex = 3
        Me.gbProductInformation.TabStop = False
        Me.gbProductInformation.Text = "Supplier Information"
        '
        'frmSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(744, 501)
        Me.Controls.Add(Me.gbSuppliers)
        Me.Controls.Add(Me.gbProductInformation)
        Me.Name = "frmSupplier"
        Me.Text = "Supplier"
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSuppliers.ResumeLayout(False)
        Me.gbProductInformation.ResumeLayout(False)
        Me.gbProductInformation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvList As DataGridView
    Friend WithEvents txtSupplierContact As TextBox
    Friend WithEvents lblSupplierContact As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtSupplierName As TextBox
    Friend WithEvents lblSupplierName As Label
    Friend WithEvents txtSupplierID As TextBox
    Friend WithEvents lblSupplierID As Label
    Friend WithEvents gbSuppliers As GroupBox
    Friend WithEvents gbProductInformation As GroupBox
End Class
