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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstKayak = New System.Windows.Forms.ListBox()
        Me.KayaksDataSet = New Lab_10_ProgChal_1.KayaksDataSet()
        Me.KayakTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KayakTypesTableAdapter = New Lab_10_ProgChal_1.KayaksDataSetTableAdapters.KayakTypesTableAdapter()
        Me.lblDescription = New System.Windows.Forms.Label()
        CType(Me.KayaksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayakTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select a kayak type to view a description"
        '
        'lstKayak
        '
        Me.lstKayak.DataSource = Me.KayakTypesBindingSource
        Me.lstKayak.DisplayMember = "Name"
        Me.lstKayak.FormattingEnabled = True
        Me.lstKayak.Location = New System.Drawing.Point(13, 30)
        Me.lstKayak.Name = "lstKayak"
        Me.lstKayak.Size = New System.Drawing.Size(177, 147)
        Me.lstKayak.TabIndex = 1
        Me.lstKayak.ValueMember = "Name"
        '
        'KayaksDataSet
        '
        Me.KayaksDataSet.DataSetName = "KayaksDataSet"
        Me.KayaksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KayakTypesBindingSource
        '
        Me.KayakTypesBindingSource.DataMember = "KayakTypes"
        Me.KayakTypesBindingSource.DataSource = Me.KayaksDataSet
        '
        'KayakTypesTableAdapter
        '
        Me.KayakTypesTableAdapter.ClearBeforeFill = True
        '
        'lblDescription
        '
        Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescription.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KayakTypesBindingSource, "Description", True))
        Me.lblDescription.Location = New System.Drawing.Point(219, 30)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(361, 147)
        Me.lblDescription.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 201)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lstKayak)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Kayak Browser"
        CType(Me.KayaksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayakTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstKayak As ListBox
    Friend WithEvents KayaksDataSet As KayaksDataSet
    Friend WithEvents KayakTypesBindingSource As BindingSource
    Friend WithEvents KayakTypesTableAdapter As KayaksDataSetTableAdapters.KayakTypesTableAdapter
    Friend WithEvents lblDescription As Label
End Class
