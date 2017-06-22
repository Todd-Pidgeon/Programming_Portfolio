<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllPaymentsForm
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dvgPayments = New System.Windows.Forms.DataGridView()
        Me.AllPaymentsDataSet = New Tutorial_09.AllPaymentsDataSet()
        Me.PaymentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaymentsTableAdapter = New Tutorial_09.AllPaymentsDataSetTableAdapters.PaymentsTableAdapter()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dvgPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllPaymentsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(402, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'dvgPayments
        '
        Me.dvgPayments.AllowUserToAddRows = False
        Me.dvgPayments.AllowUserToDeleteRows = False
        Me.dvgPayments.AutoGenerateColumns = False
        Me.dvgPayments.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dvgPayments.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dvgPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgPayments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.PaymentDateDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn})
        Me.dvgPayments.DataSource = Me.PaymentsBindingSource
        Me.dvgPayments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dvgPayments.Location = New System.Drawing.Point(0, 24)
        Me.dvgPayments.Name = "dvgPayments"
        Me.dvgPayments.ReadOnly = True
        Me.dvgPayments.RowHeadersVisible = False
        Me.dvgPayments.Size = New System.Drawing.Size(402, 238)
        Me.dvgPayments.TabIndex = 1
        '
        'AllPaymentsDataSet
        '
        Me.AllPaymentsDataSet.DataSetName = "AllPaymentsDataSet"
        Me.AllPaymentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaymentsBindingSource
        '
        Me.PaymentsBindingSource.DataMember = "Payments"
        Me.PaymentsBindingSource.DataSource = Me.AllPaymentsDataSet
        '
        'PaymentsTableAdapter
        '
        Me.PaymentsTableAdapter.ClearBeforeFill = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PaymentDateDataGridViewTextBoxColumn
        '
        Me.PaymentDateDataGridViewTextBoxColumn.DataPropertyName = "Payment_Date"
        Me.PaymentDateDataGridViewTextBoxColumn.HeaderText = "Payment_Date"
        Me.PaymentDateDataGridViewTextBoxColumn.Name = "PaymentDateDataGridViewTextBoxColumn"
        Me.PaymentDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AllPaymentsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 262)
        Me.Controls.Add(Me.dvgPayments)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AllPaymentsForm"
        Me.Text = "Payments By All Members"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dvgPayments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllPaymentsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dvgPayments As DataGridView
    Friend WithEvents AllPaymentsDataSet As AllPaymentsDataSet
    Friend WithEvents PaymentsBindingSource As BindingSource
    Friend WithEvents PaymentsTableAdapter As AllPaymentsDataSetTableAdapters.PaymentsTableAdapter
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
