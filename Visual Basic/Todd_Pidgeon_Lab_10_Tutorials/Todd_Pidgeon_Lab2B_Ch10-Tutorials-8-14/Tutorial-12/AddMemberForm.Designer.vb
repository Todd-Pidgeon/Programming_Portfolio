<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMemberForm
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
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim Date_JoinedLabel As System.Windows.Forms.Label
        Me.AllMembersDataSet = New Tutorial_09.AllMembersDataSet()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MembersTableAdapter = New Tutorial_09.AllMembersDataSetTableAdapters.MembersTableAdapter()
        Me.TableAdapterManager = New Tutorial_09.AllMembersDataSetTableAdapters.TableAdapterManager()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.Date_JoinedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseWithoutSavingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        IDLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        Date_JoinedLabel = New System.Windows.Forms.Label()
        CType(Me.AllMembersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(61, 66)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(24, 16)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(61, 94)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(76, 16)
        Last_NameLabel.TabIndex = 3
        Last_NameLabel.Text = "Last Name:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(61, 122)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(76, 16)
        First_NameLabel.TabIndex = 5
        First_NameLabel.Text = "First Name:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(61, 150)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(50, 16)
        PhoneLabel.TabIndex = 7
        PhoneLabel.Text = "Phone:"
        '
        'Date_JoinedLabel
        '
        Date_JoinedLabel.AutoSize = True
        Date_JoinedLabel.Location = New System.Drawing.Point(61, 179)
        Date_JoinedLabel.Name = "Date_JoinedLabel"
        Date_JoinedLabel.Size = New System.Drawing.Size(84, 16)
        Date_JoinedLabel.TabIndex = 9
        Date_JoinedLabel.Text = "Date Joined:"
        '
        'AllMembersDataSet
        '
        Me.AllMembersDataSet.DataSetName = "AllMembersDataSet"
        Me.AllMembersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "Members"
        Me.MembersBindingSource.DataSource = Me.AllMembersDataSet
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MembersTableAdapter = Me.MembersTableAdapter
        Me.TableAdapterManager.UpdateOrder = Tutorial_09.AllMembersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(151, 63)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(200, 22)
        Me.IDTextBox.TabIndex = 2
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(151, 91)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Last_NameTextBox.TabIndex = 4
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "First_Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(151, 119)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.First_NameTextBox.TabIndex = 6
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(151, 147)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(200, 22)
        Me.PhoneTextBox.TabIndex = 8
        '
        'Date_JoinedDateTimePicker
        '
        Me.Date_JoinedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MembersBindingSource, "Date_Joined", True))
        Me.Date_JoinedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_JoinedDateTimePicker.Location = New System.Drawing.Point(151, 175)
        Me.Date_JoinedDateTimePicker.Name = "Date_JoinedDateTimePicker"
        Me.Date_JoinedDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.Date_JoinedDateTimePicker.TabIndex = 10
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(408, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileSave, Me.CloseWithoutSavingToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.Size = New System.Drawing.Size(153, 22)
        Me.mnuFileSave.Text = "Save and Close"
        '
        'CloseWithoutSavingToolStripMenuItem
        '
        Me.CloseWithoutSavingToolStripMenuItem.Name = "CloseWithoutSavingToolStripMenuItem"
        Me.CloseWithoutSavingToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.CloseWithoutSavingToolStripMenuItem.Text = "Close without saving"
        '
        'AddMemberForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 322)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(Date_JoinedLabel)
        Me.Controls.Add(Me.Date_JoinedDateTimePicker)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddMemberForm"
        Me.Text = "Add New Member"
        CType(Me.AllMembersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AllMembersDataSet As AllMembersDataSet
    Friend WithEvents MembersBindingSource As BindingSource
    Friend WithEvents MembersTableAdapter As AllMembersDataSetTableAdapters.MembersTableAdapter
    Friend WithEvents TableAdapterManager As AllMembersDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MembersBindingNavigator As BindingNavigator
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
    Friend WithEvents MembersBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents Date_JoinedDateTimePicker As DateTimePicker
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuFileSave As ToolStripMenuItem
    Friend WithEvents CloseWithoutSavingToolStripMenuItem As ToolStripMenuItem
End Class
