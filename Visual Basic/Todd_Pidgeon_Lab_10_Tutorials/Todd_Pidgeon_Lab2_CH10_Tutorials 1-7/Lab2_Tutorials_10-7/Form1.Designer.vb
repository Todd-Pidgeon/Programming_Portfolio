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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtMemberId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dvgPayments = New System.Windows.Forms.DataGridView()
        Me.MemberIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KarateDataSet = New Lab2_Tutorials_10_7.KarateDataSet()
        Me.PaymentsTableAdapter = New Lab2_Tutorials_10_7.KarateDataSetTableAdapters.PaymentsTableAdapter()
        Me.btnTotal = New System.Windows.Forms.Button()
        CType(Me.dvgPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KarateDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(217, 12)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(106, 23)
        Me.btnInsert.TabIndex = 13
        Me.btnInsert.Text = "Insert Payment"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(80, 58)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 12
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(80, 32)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 20)
        Me.txtDate.TabIndex = 11
        '
        'txtMemberId
        '
        Me.txtMemberId.Location = New System.Drawing.Point(80, 6)
        Me.txtMemberId.Name = "txtMemberId"
        Me.txtMemberId.Size = New System.Drawing.Size(100, 20)
        Me.txtMemberId.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Amount:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Member ID:"
        '
        'dvgPayments
        '
        Me.dvgPayments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dvgPayments.AutoGenerateColumns = False
        Me.dvgPayments.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dvgPayments.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dvgPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgPayments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MemberIdDataGridViewTextBoxColumn, Me.PaymentDateDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn})
        Me.dvgPayments.DataSource = Me.PaymentsBindingSource
        Me.dvgPayments.Location = New System.Drawing.Point(15, 100)
        Me.dvgPayments.Name = "dvgPayments"
        Me.dvgPayments.ReadOnly = True
        Me.dvgPayments.RowHeadersVisible = False
        Me.dvgPayments.Size = New System.Drawing.Size(308, 150)
        Me.dvgPayments.TabIndex = 14
        '
        'MemberIdDataGridViewTextBoxColumn
        '
        Me.MemberIdDataGridViewTextBoxColumn.DataPropertyName = "Member_Id"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue
        Me.MemberIdDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.MemberIdDataGridViewTextBoxColumn.HeaderText = "Member_Id"
        Me.MemberIdDataGridViewTextBoxColumn.Name = "MemberIdDataGridViewTextBoxColumn"
        Me.MemberIdDataGridViewTextBoxColumn.ReadOnly = True
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
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.AmountDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PaymentsBindingSource
        '
        Me.PaymentsBindingSource.DataMember = "Payments"
        Me.PaymentsBindingSource.DataSource = Me.KarateDataSet
        '
        'KarateDataSet
        '
        Me.KarateDataSet.DataSetName = "KarateDataSet"
        Me.KarateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaymentsTableAdapter
        '
        Me.PaymentsTableAdapter.ClearBeforeFill = True
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(217, 51)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(106, 23)
        Me.btnTotal.TabIndex = 15
        Me.btnTotal.Text = "Show Total"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 262)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.dvgPayments)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtMemberId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dvgPayments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KarateDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInsert As Button
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtMemberId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dvgPayments As DataGridView
    Friend WithEvents KarateDataSet As KarateDataSet
    Friend WithEvents PaymentsBindingSource As BindingSource
    Friend WithEvents PaymentsTableAdapter As KarateDataSetTableAdapters.PaymentsTableAdapter
    Friend WithEvents MemberIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnTotal As Button
End Class
