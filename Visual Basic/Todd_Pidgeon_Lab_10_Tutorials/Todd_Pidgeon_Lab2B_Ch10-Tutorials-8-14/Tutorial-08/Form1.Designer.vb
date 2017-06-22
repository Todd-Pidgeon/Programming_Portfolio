<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Full_TimeToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Full_TimeToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.All_RowsToolStrip = New System.Windows.Forms.ToolStrip()
        Me.All_RowsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullTimeDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.HireDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyDataSet = New WindowsApplication1.CompanyDataSet()
        Me.SalesStaffTableAdapter = New WindowsApplication1.CompanyDataSetTableAdapters.SalesStaffTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Full_TimeToolStrip.SuspendLayout()
        Me.All_RowsToolStrip.SuspendLayout()
        CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.FullTimeDataGridViewCheckBoxColumn, Me.HireDateDataGridViewTextBoxColumn, Me.SalaryDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SalesStaffBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 53)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(683, 309)
        Me.DataGridView1.TabIndex = 0
        '
        'Full_TimeToolStrip
        '
        Me.Full_TimeToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Full_TimeToolStripButton})
        Me.Full_TimeToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.Full_TimeToolStrip.Name = "Full_TimeToolStrip"
        Me.Full_TimeToolStrip.Size = New System.Drawing.Size(683, 25)
        Me.Full_TimeToolStrip.TabIndex = 1
        Me.Full_TimeToolStrip.Text = "Full_TimeToolStrip"
        '
        'Full_TimeToolStripButton
        '
        Me.Full_TimeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Full_TimeToolStripButton.Name = "Full_TimeToolStripButton"
        Me.Full_TimeToolStripButton.Size = New System.Drawing.Size(62, 22)
        Me.Full_TimeToolStripButton.Text = "Full_Time"
        '
        'All_RowsToolStrip
        '
        Me.All_RowsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.All_RowsToolStripButton})
        Me.All_RowsToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.All_RowsToolStrip.Name = "All_RowsToolStrip"
        Me.All_RowsToolStrip.Size = New System.Drawing.Size(683, 25)
        Me.All_RowsToolStrip.TabIndex = 2
        Me.All_RowsToolStrip.Text = "All_RowsToolStrip"
        '
        'All_RowsToolStripButton
        '
        Me.All_RowsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.All_RowsToolStripButton.Name = "All_RowsToolStripButton"
        Me.All_RowsToolStripButton.Size = New System.Drawing.Size(58, 22)
        Me.All_RowsToolStripButton.Text = "All_Rows"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'FullTimeDataGridViewCheckBoxColumn
        '
        Me.FullTimeDataGridViewCheckBoxColumn.DataPropertyName = "Full_Time"
        Me.FullTimeDataGridViewCheckBoxColumn.HeaderText = "Full_Time"
        Me.FullTimeDataGridViewCheckBoxColumn.Name = "FullTimeDataGridViewCheckBoxColumn"
        '
        'HireDateDataGridViewTextBoxColumn
        '
        Me.HireDateDataGridViewTextBoxColumn.DataPropertyName = "Hire_Date"
        Me.HireDateDataGridViewTextBoxColumn.HeaderText = "Hire_Date"
        Me.HireDateDataGridViewTextBoxColumn.Name = "HireDateDataGridViewTextBoxColumn"
        '
        'SalaryDataGridViewTextBoxColumn
        '
        Me.SalaryDataGridViewTextBoxColumn.DataPropertyName = "Salary"
        Me.SalaryDataGridViewTextBoxColumn.HeaderText = "Salary"
        Me.SalaryDataGridViewTextBoxColumn.Name = "SalaryDataGridViewTextBoxColumn"
        '
        'SalesStaffBindingSource
        '
        Me.SalesStaffBindingSource.DataMember = "SalesStaff"
        Me.SalesStaffBindingSource.DataSource = Me.CompanyDataSet
        '
        'CompanyDataSet
        '
        Me.CompanyDataSet.DataSetName = "CompanyDataSet"
        Me.CompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesStaffTableAdapter
        '
        Me.SalesStaffTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 362)
        Me.Controls.Add(Me.All_RowsToolStrip)
        Me.Controls.Add(Me.Full_TimeToolStrip)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Company Sales Staff Table"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Full_TimeToolStrip.ResumeLayout(False)
        Me.Full_TimeToolStrip.PerformLayout()
        Me.All_RowsToolStrip.ResumeLayout(False)
        Me.All_RowsToolStrip.PerformLayout()
        CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CompanyDataSet As CompanyDataSet
    Friend WithEvents SalesStaffBindingSource As BindingSource
    Friend WithEvents SalesStaffTableAdapter As CompanyDataSetTableAdapters.SalesStaffTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FullTimeDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents HireDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Full_TimeToolStrip As ToolStrip
    Friend WithEvents Full_TimeToolStripButton As ToolStripButton
    Friend WithEvents All_RowsToolStrip As ToolStrip
    Friend WithEvents All_RowsToolStripButton As ToolStripButton
End Class
