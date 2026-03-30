<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomer
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
        Me.txtCustomerMiddleName = New System.Windows.Forms.TextBox()
        Me.lblCustomerMiddleName = New System.Windows.Forms.Label()
        Me.txtCustomerContact = New System.Windows.Forms.TextBox()
        Me.lblCustomerContact = New System.Windows.Forms.Label()
        Me.txtCustomerLastName = New System.Windows.Forms.TextBox()
        Me.lblCustomerLastName = New System.Windows.Forms.Label()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.gbCustomers = New System.Windows.Forms.GroupBox()
        Me.dgvList = New System.Windows.Forms.DataGridView()
        Me.gbCustomerInformation = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.gbCustomerName = New System.Windows.Forms.GroupBox()
        Me.txtCustomerFirstName = New System.Windows.Forms.TextBox()
        Me.lblCustomerFirstName = New System.Windows.Forms.Label()
        Me.gbCustomers.SuspendLayout()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCustomerInformation.SuspendLayout()
        Me.gbCustomerName.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCustomerMiddleName
        '
        Me.txtCustomerMiddleName.Location = New System.Drawing.Point(221, 35)
        Me.txtCustomerMiddleName.Name = "txtCustomerMiddleName"
        Me.txtCustomerMiddleName.Size = New System.Drawing.Size(200, 20)
        Me.txtCustomerMiddleName.TabIndex = 2
        '
        'lblCustomerMiddleName
        '
        Me.lblCustomerMiddleName.AutoSize = True
        Me.lblCustomerMiddleName.Location = New System.Drawing.Point(218, 19)
        Me.lblCustomerMiddleName.Name = "lblCustomerMiddleName"
        Me.lblCustomerMiddleName.Size = New System.Drawing.Size(117, 13)
        Me.lblCustomerMiddleName.TabIndex = 12
        Me.lblCustomerMiddleName.Text = "Middle Name (Optional)"
        '
        'txtCustomerContact
        '
        Me.txtCustomerContact.Location = New System.Drawing.Point(12, 154)
        Me.txtCustomerContact.Name = "txtCustomerContact"
        Me.txtCustomerContact.Size = New System.Drawing.Size(153, 20)
        Me.txtCustomerContact.TabIndex = 3
        '
        'lblCustomerContact
        '
        Me.lblCustomerContact.AutoSize = True
        Me.lblCustomerContact.Location = New System.Drawing.Point(9, 138)
        Me.lblCustomerContact.Name = "lblCustomerContact"
        Me.lblCustomerContact.Size = New System.Drawing.Size(84, 13)
        Me.lblCustomerContact.TabIndex = 6
        Me.lblCustomerContact.Text = "Contact Number"
        '
        'txtCustomerLastName
        '
        Me.txtCustomerLastName.Location = New System.Drawing.Point(427, 35)
        Me.txtCustomerLastName.Name = "txtCustomerLastName"
        Me.txtCustomerLastName.Size = New System.Drawing.Size(200, 20)
        Me.txtCustomerLastName.TabIndex = 3
        '
        'lblCustomerLastName
        '
        Me.lblCustomerLastName.AutoSize = True
        Me.lblCustomerLastName.Location = New System.Drawing.Point(424, 19)
        Me.lblCustomerLastName.Name = "lblCustomerLastName"
        Me.lblCustomerLastName.Size = New System.Drawing.Size(55, 13)
        Me.lblCustomerLastName.TabIndex = 4
        Me.lblCustomerLastName.Text = "LastName"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(12, 35)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(75, 20)
        Me.txtCustomerID.TabIndex = 1
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
        'gbCustomers
        '
        Me.gbCustomers.Controls.Add(Me.dgvList)
        Me.gbCustomers.Location = New System.Drawing.Point(12, 231)
        Me.gbCustomers.Name = "gbCustomers"
        Me.gbCustomers.Size = New System.Drawing.Size(708, 373)
        Me.gbCustomers.TabIndex = 4
        Me.gbCustomers.TabStop = False
        Me.gbCustomers.Text = "Customer List"
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
        Me.dgvList.Size = New System.Drawing.Size(702, 354)
        Me.dgvList.TabIndex = 0
        Me.dgvList.TabStop = False
        '
        'gbCustomerInformation
        '
        Me.gbCustomerInformation.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.gbCustomerInformation.Controls.Add(Me.btnClear)
        Me.gbCustomerInformation.Controls.Add(Me.btnDelete)
        Me.gbCustomerInformation.Controls.Add(Me.btnUpdate)
        Me.gbCustomerInformation.Controls.Add(Me.btnAdd)
        Me.gbCustomerInformation.Controls.Add(Me.gbCustomerName)
        Me.gbCustomerInformation.Controls.Add(Me.txtCustomerContact)
        Me.gbCustomerInformation.Controls.Add(Me.lblCustomerContact)
        Me.gbCustomerInformation.Controls.Add(Me.txtCustomerID)
        Me.gbCustomerInformation.Controls.Add(Me.lblProductID)
        Me.gbCustomerInformation.Location = New System.Drawing.Point(12, 12)
        Me.gbCustomerInformation.Name = "gbCustomerInformation"
        Me.gbCustomerInformation.Size = New System.Drawing.Size(705, 213)
        Me.gbCustomerInformation.TabIndex = 3
        Me.gbCustomerInformation.TabStop = False
        Me.gbCustomerInformation.Text = "Customer Information"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(255, 180)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(174, 180)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(93, 180)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 180)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'gbCustomerName
        '
        Me.gbCustomerName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.gbCustomerName.Controls.Add(Me.txtCustomerFirstName)
        Me.gbCustomerName.Controls.Add(Me.lblCustomerLastName)
        Me.gbCustomerName.Controls.Add(Me.txtCustomerLastName)
        Me.gbCustomerName.Controls.Add(Me.lblCustomerMiddleName)
        Me.gbCustomerName.Controls.Add(Me.txtCustomerMiddleName)
        Me.gbCustomerName.Controls.Add(Me.lblCustomerFirstName)
        Me.gbCustomerName.Location = New System.Drawing.Point(12, 61)
        Me.gbCustomerName.Name = "gbCustomerName"
        Me.gbCustomerName.Size = New System.Drawing.Size(687, 74)
        Me.gbCustomerName.TabIndex = 2
        Me.gbCustomerName.TabStop = False
        Me.gbCustomerName.Text = "Name"
        '
        'txtCustomerFirstName
        '
        Me.txtCustomerFirstName.Location = New System.Drawing.Point(15, 35)
        Me.txtCustomerFirstName.Name = "txtCustomerFirstName"
        Me.txtCustomerFirstName.Size = New System.Drawing.Size(200, 20)
        Me.txtCustomerFirstName.TabIndex = 1
        '
        'lblCustomerFirstName
        '
        Me.lblCustomerFirstName.AutoSize = True
        Me.lblCustomerFirstName.Location = New System.Drawing.Point(12, 19)
        Me.lblCustomerFirstName.Name = "lblCustomerFirstName"
        Me.lblCustomerFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblCustomerFirstName.TabIndex = 14
        Me.lblCustomerFirstName.Text = "First Name"
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMargin = New System.Drawing.Size(0, 10)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(744, 501)
        Me.Controls.Add(Me.gbCustomers)
        Me.Controls.Add(Me.gbCustomerInformation)
        Me.Name = "frmCustomer"
        Me.Text = "Customer"
        Me.gbCustomers.ResumeLayout(False)
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCustomerInformation.ResumeLayout(False)
        Me.gbCustomerInformation.PerformLayout()
        Me.gbCustomerName.ResumeLayout(False)
        Me.gbCustomerName.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCustomerMiddleName As TextBox
    Friend WithEvents lblCustomerMiddleName As Label
    Friend WithEvents txtCustomerContact As TextBox
    Friend WithEvents lblCustomerContact As Label
    Friend WithEvents txtCustomerLastName As TextBox
    Friend WithEvents lblCustomerLastName As Label
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents lblProductID As Label
    Friend WithEvents gbCustomers As GroupBox
    Friend WithEvents gbCustomerInformation As GroupBox
    Friend WithEvents txtCustomerFirstName As TextBox
    Friend WithEvents lblCustomerFirstName As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents gbCustomerName As GroupBox
    Friend WithEvents dgvList As DataGridView
End Class
