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
        Me.dvgFilms = New System.Windows.Forms.DataGridView()
        Me.FilmsDataSet = New Tutorial_14.FilmsDataSet()
        Me.FilmsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FilmsTableAdapter = New Tutorial_14.FilmsDataSetTableAdapters.FilmsTableAdapter()
        Me.FilmIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirectorsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FilmsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dvgFilms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FilmsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FilmsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FilmsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dvgFilms
        '
        Me.dvgFilms.AutoGenerateColumns = False
        Me.dvgFilms.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dvgFilms.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dvgFilms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgFilms.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FilmIdDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.DirectorsDataGridViewTextBoxColumn, Me.YearDataGridViewTextBoxColumn})
        Me.dvgFilms.DataSource = Me.FilmsBindingSource1
        Me.dvgFilms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dvgFilms.Location = New System.Drawing.Point(0, 0)
        Me.dvgFilms.Name = "dvgFilms"
        Me.dvgFilms.RowHeadersVisible = False
        Me.dvgFilms.Size = New System.Drawing.Size(403, 262)
        Me.dvgFilms.TabIndex = 0
        '
        'FilmsDataSet
        '
        Me.FilmsDataSet.DataSetName = "FilmsDataSet"
        Me.FilmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FilmsBindingSource
        '
        Me.FilmsBindingSource.DataMember = "Films"
        Me.FilmsBindingSource.DataSource = Me.FilmsDataSet
        '
        'FilmsTableAdapter
        '
        Me.FilmsTableAdapter.ClearBeforeFill = True
        '
        'FilmIdDataGridViewTextBoxColumn
        '
        Me.FilmIdDataGridViewTextBoxColumn.DataPropertyName = "FilmId"
        Me.FilmIdDataGridViewTextBoxColumn.HeaderText = "FilmId"
        Me.FilmIdDataGridViewTextBoxColumn.Name = "FilmIdDataGridViewTextBoxColumn"
        Me.FilmIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        '
        'DirectorsDataGridViewTextBoxColumn
        '
        Me.DirectorsDataGridViewTextBoxColumn.DataPropertyName = "Directors"
        Me.DirectorsDataGridViewTextBoxColumn.HeaderText = "Directors"
        Me.DirectorsDataGridViewTextBoxColumn.Name = "DirectorsDataGridViewTextBoxColumn"
        '
        'YearDataGridViewTextBoxColumn
        '
        Me.YearDataGridViewTextBoxColumn.DataPropertyName = "Year"
        Me.YearDataGridViewTextBoxColumn.HeaderText = "Year"
        Me.YearDataGridViewTextBoxColumn.Name = "YearDataGridViewTextBoxColumn"
        '
        'FilmsBindingSource1
        '
        Me.FilmsBindingSource1.DataMember = "Films"
        Me.FilmsBindingSource1.DataSource = Me.FilmsDataSet
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 262)
        Me.Controls.Add(Me.dvgFilms)
        Me.Name = "Form1"
        Me.Text = "Films"
        CType(Me.dvgFilms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FilmsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FilmsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FilmsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dvgFilms As DataGridView
    Friend WithEvents FilmsDataSet As FilmsDataSet
    Friend WithEvents FilmsBindingSource As BindingSource
    Friend WithEvents FilmsTableAdapter As FilmsDataSetTableAdapters.FilmsTableAdapter
    Friend WithEvents FilmIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DirectorsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FilmsBindingSource1 As BindingSource
End Class
