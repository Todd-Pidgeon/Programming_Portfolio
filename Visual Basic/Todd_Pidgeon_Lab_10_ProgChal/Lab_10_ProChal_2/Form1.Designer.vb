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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HourlyRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DailyRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeeklyRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KayakTypesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KayaksDataSet = New Lab_10_ProChal_2.KayaksDataSet()
        Me.KayakTypesTableAdapter = New Lab_10_ProChal_2.KayaksDataSetTableAdapters.KayakTypesTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayakTypesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayaksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.HourlyRateDataGridViewTextBoxColumn, Me.DailyRateDataGridViewTextBoxColumn, Me.WeeklyRateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.KayakTypesBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(13, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(444, 195)
        Me.DataGridView1.TabIndex = 0
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HourlyRateDataGridViewTextBoxColumn
        '
        Me.HourlyRateDataGridViewTextBoxColumn.DataPropertyName = "Hourly_Rate"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.HourlyRateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.HourlyRateDataGridViewTextBoxColumn.HeaderText = "Hourly_Rate"
        Me.HourlyRateDataGridViewTextBoxColumn.Name = "HourlyRateDataGridViewTextBoxColumn"
        Me.HourlyRateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DailyRateDataGridViewTextBoxColumn
        '
        Me.DailyRateDataGridViewTextBoxColumn.DataPropertyName = "Daily_Rate"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DailyRateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.DailyRateDataGridViewTextBoxColumn.HeaderText = "Daily_Rate"
        Me.DailyRateDataGridViewTextBoxColumn.Name = "DailyRateDataGridViewTextBoxColumn"
        Me.DailyRateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WeeklyRateDataGridViewTextBoxColumn
        '
        Me.WeeklyRateDataGridViewTextBoxColumn.DataPropertyName = "Weekly_Rate"
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.WeeklyRateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.WeeklyRateDataGridViewTextBoxColumn.HeaderText = "Weekly_Rate"
        Me.WeeklyRateDataGridViewTextBoxColumn.Name = "WeeklyRateDataGridViewTextBoxColumn"
        Me.WeeklyRateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KayakTypesBindingSource1
        '
        Me.KayakTypesBindingSource1.DataMember = "KayakTypes"
        Me.KayakTypesBindingSource1.DataSource = Me.KayaksDataSet
        '
        'KayaksDataSet
        '
        Me.KayaksDataSet.DataSetName = "KayaksDataSet"
        Me.KayaksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KayakTypesTableAdapter
        '
        Me.KayakTypesTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 220)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayakTypesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayaksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents KayaksDataSet As KayaksDataSet
    Friend WithEvents KayakTypesTableAdapter As KayaksDataSetTableAdapters.KayakTypesTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KayakTypesBindingSource1 As BindingSource
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HourlyRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DailyRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeeklyRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
