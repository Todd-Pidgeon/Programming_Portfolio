<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesStaff1
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
        Me.SalesStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyDataSet = New Lab2_Tutorials_10_1.CompanyDataSet()
        Me.SalesStaffTableAdapter = New Lab2_Tutorials_10_1.CompanyDataSetTableAdapters.SalesStaffTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CompanyDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.DataSource = Me.CompanyDataSetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'CompanyDataSetBindingSource
        '
        Me.CompanyDataSetBindingSource.DataSource = Me.CompanyDataSet
        Me.CompanyDataSetBindingSource.Position = 0
        '
        'SalesStaff1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 363)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SalesStaff1"
        Me.Text = "Company Sales Staff Table"
        CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CompanyDataSet As CompanyDataSet
    Friend WithEvents SalesStaffBindingSource As BindingSource
    Friend WithEvents SalesStaffTableAdapter As CompanyDataSetTableAdapters.SalesStaffTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CompanyDataSetBindingSource As BindingSource
End Class
