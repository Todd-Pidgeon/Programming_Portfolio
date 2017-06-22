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
        Dim IDLabel As System.Windows.Forms.Label
        Dim Member_IdLabel As System.Windows.Forms.Label
        Dim Payment_DateLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PaymentsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PaymentsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Member_IdTextBox = New System.Windows.Forms.TextBox()
        Me.Payment_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.dgvMembers = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KarateDataSet = New Lab_10_ProgChal_7.KarateDataSet()
        Me.PaymentsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaymentsTableAdapter = New Lab_10_ProgChal_7.KarateDataSetTableAdapters.PaymentsTableAdapter()
        Me.TableAdapterManager = New Lab_10_ProgChal_7.KarateDataSetTableAdapters.TableAdapterManager()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MembersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KarateDataSet1 = New Lab_10_ProgChal_7.KarateDataSet1()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MembersTableAdapter = New Lab_10_ProgChal_7.KarateDataSet1TableAdapters.MembersTableAdapter()
        IDLabel = New System.Windows.Forms.Label()
        Member_IdLabel = New System.Windows.Forms.Label()
        Payment_DateLabel = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        CType(Me.PaymentsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaymentsBindingNavigator.SuspendLayout()
        CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KarateDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KarateDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(79, 65)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'Member_IdLabel
        '
        Member_IdLabel.AutoSize = True
        Member_IdLabel.Location = New System.Drawing.Point(40, 103)
        Member_IdLabel.Name = "Member_IdLabel"
        Member_IdLabel.Size = New System.Drawing.Size(60, 13)
        Member_IdLabel.TabIndex = 3
        Member_IdLabel.Text = "Member Id:"
        '
        'Payment_DateLabel
        '
        Payment_DateLabel.AutoSize = True
        Payment_DateLabel.Location = New System.Drawing.Point(23, 130)
        Payment_DateLabel.Name = "Payment_DateLabel"
        Payment_DateLabel.Size = New System.Drawing.Size(77, 13)
        Payment_DateLabel.TabIndex = 5
        Payment_DateLabel.Text = "Payment Date:"
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.Location = New System.Drawing.Point(54, 163)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(46, 13)
        AmountLabel.TabIndex = 7
        AmountLabel.Text = "Amount:"
        '
        'PaymentsBindingNavigator
        '
        Me.PaymentsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PaymentsBindingNavigator.BindingSource = Me.PaymentsBindingSource
        Me.PaymentsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PaymentsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PaymentsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PaymentsBindingNavigatorSaveItem})
        Me.PaymentsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PaymentsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PaymentsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PaymentsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PaymentsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PaymentsBindingNavigator.Name = "PaymentsBindingNavigator"
        Me.PaymentsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PaymentsBindingNavigator.Size = New System.Drawing.Size(656, 25)
        Me.PaymentsBindingNavigator.TabIndex = 0
        Me.PaymentsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'PaymentsBindingNavigatorSaveItem
        '
        Me.PaymentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PaymentsBindingNavigatorSaveItem.Image = CType(resources.GetObject("PaymentsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PaymentsBindingNavigatorSaveItem.Name = "PaymentsBindingNavigatorSaveItem"
        Me.PaymentsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PaymentsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentsBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(106, 62)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(133, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'Member_IdTextBox
        '
        Me.Member_IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentsBindingSource, "Member_Id", True))
        Me.Member_IdTextBox.Location = New System.Drawing.Point(106, 100)
        Me.Member_IdTextBox.Name = "Member_IdTextBox"
        Me.Member_IdTextBox.Size = New System.Drawing.Size(133, 20)
        Me.Member_IdTextBox.TabIndex = 4
        '
        'Payment_DateDateTimePicker
        '
        Me.Payment_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PaymentsBindingSource, "Payment_Date", True))
        Me.Payment_DateDateTimePicker.Location = New System.Drawing.Point(106, 126)
        Me.Payment_DateDateTimePicker.Name = "Payment_DateDateTimePicker"
        Me.Payment_DateDateTimePicker.Size = New System.Drawing.Size(133, 20)
        Me.Payment_DateDateTimePicker.TabIndex = 6
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentsBindingSource, "Amount", True))
        Me.AmountTextBox.Location = New System.Drawing.Point(106, 160)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(133, 20)
        Me.AmountTextBox.TabIndex = 8
        '
        'dgvMembers
        '
        Me.dgvMembers.AutoGenerateColumns = False
        Me.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMembers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.LastNameDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn})
        Me.dgvMembers.DataSource = Me.MembersBindingSource1
        Me.dgvMembers.Location = New System.Drawing.Point(284, 51)
        Me.dgvMembers.Name = "dgvMembers"
        Me.dgvMembers.Size = New System.Drawing.Size(343, 150)
        Me.dgvMembers.TabIndex = 9
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
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
        'PaymentsBindingSource1
        '
        Me.PaymentsBindingSource1.DataMember = "Payments"
        Me.PaymentsBindingSource1.DataSource = Me.KarateDataSet
        '
        'PaymentsTableAdapter
        '
        Me.PaymentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = Lab_10_ProgChal_7.KarateDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'MembersBindingSource1
        '
        Me.MembersBindingSource1.DataMember = "Members"
        Me.MembersBindingSource1.DataSource = Me.KarateDataSet1
        '
        'KarateDataSet1
        '
        Me.KarateDataSet1.DataSetName = "KarateDataSet1"
        Me.KarateDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "Members"
        Me.MembersBindingSource.DataSource = Me.KarateDataSet1
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 236)
        Me.Controls.Add(Me.dgvMembers)
        Me.Controls.Add(AmountLabel)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Payment_DateLabel)
        Me.Controls.Add(Me.Payment_DateDateTimePicker)
        Me.Controls.Add(Member_IdLabel)
        Me.Controls.Add(Me.Member_IdTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.PaymentsBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Modify Existing Payments"
        CType(Me.PaymentsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaymentsBindingNavigator.ResumeLayout(False)
        Me.PaymentsBindingNavigator.PerformLayout()
        CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KarateDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KarateDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KarateDataSet As KarateDataSet
    Friend WithEvents PaymentsBindingSource As BindingSource
    Friend WithEvents PaymentsTableAdapter As KarateDataSetTableAdapters.PaymentsTableAdapter
    Friend WithEvents TableAdapterManager As KarateDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PaymentsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PaymentsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Member_IdTextBox As TextBox
    Friend WithEvents Payment_DateDateTimePicker As DateTimePicker
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents dgvMembers As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MemberIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentsBindingSource1 As BindingSource
    Friend WithEvents KarateDataSet1 As KarateDataSet1
    Friend WithEvents MembersBindingSource As BindingSource
    Friend WithEvents MembersTableAdapter As KarateDataSet1TableAdapters.MembersTableAdapter
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MembersBindingSource1 As BindingSource
End Class
