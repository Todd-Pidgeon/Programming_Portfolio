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
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Date_JoinedLabel As System.Windows.Forms.Label
        Me.lslMembers = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KarateDataSet = New Lab2_Tutorials_10_5.KarateDataSet()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MembersTableAdapter = New Lab2_Tutorials_10_5.KarateDataSetTableAdapters.MembersTableAdapter()
        Me.TableAdapterManager = New Lab2_Tutorials_10_5.KarateDataSetTableAdapters.TableAdapterManager()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Date_JoinedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        PhoneLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Date_JoinedLabel = New System.Windows.Forms.Label()
        CType(Me.KarateDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lslMembers
        '
        Me.lslMembers.DataSource = Me.MembersBindingSource
        Me.lslMembers.DisplayMember = "Last_Name"
        Me.lslMembers.FormattingEnabled = True
        Me.lslMembers.Location = New System.Drawing.Point(12, 41)
        Me.lslMembers.Name = "lslMembers"
        Me.lslMembers.Size = New System.Drawing.Size(125, 147)
        Me.lslMembers.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Member Names"
        '
        'KarateDataSet
        '
        Me.KarateDataSet.DataSetName = "KarateDataSet"
        Me.KarateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "Members"
        Me.MembersBindingSource.DataSource = Me.KarateDataSet
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MembersTableAdapter = Me.MembersTableAdapter
        Me.TableAdapterManager.UpdateOrder = Lab2_Tutorials_10_5.KarateDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(182, 131)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 2
        PhoneLabel.Text = "Phone:"
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(229, 128)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(138, 20)
        Me.PhoneTextBox.TabIndex = 3
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(202, 37)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 4
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(229, 34)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(138, 20)
        Me.IDTextBox.TabIndex = 5
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(162, 70)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(61, 13)
        Last_NameLabel.TabIndex = 6
        Last_NameLabel.Text = "Last Name:"
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(229, 67)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(138, 20)
        Me.Last_NameTextBox.TabIndex = 7
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(163, 103)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(60, 13)
        First_NameLabel.TabIndex = 8
        First_NameLabel.Text = "First Name:"
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "First_Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(229, 100)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(138, 20)
        Me.First_NameTextBox.TabIndex = 9
        '
        'Date_JoinedLabel
        '
        Date_JoinedLabel.AutoSize = True
        Date_JoinedLabel.Location = New System.Drawing.Point(156, 165)
        Date_JoinedLabel.Name = "Date_JoinedLabel"
        Date_JoinedLabel.Size = New System.Drawing.Size(67, 13)
        Date_JoinedLabel.TabIndex = 10
        Date_JoinedLabel.Text = "Date Joined:"
        '
        'Date_JoinedDateTimePicker
        '
        Me.Date_JoinedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MembersBindingSource, "Date_Joined", True))
        Me.Date_JoinedDateTimePicker.Location = New System.Drawing.Point(229, 161)
        Me.Date_JoinedDateTimePicker.Name = "Date_JoinedDateTimePicker"
        Me.Date_JoinedDateTimePicker.Size = New System.Drawing.Size(138, 20)
        Me.Date_JoinedDateTimePicker.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 229)
        Me.Controls.Add(Date_JoinedLabel)
        Me.Controls.Add(Me.Date_JoinedDateTimePicker)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lslMembers)
        Me.Name = "Form1"
        Me.Text = "Member List"
        CType(Me.KarateDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lslMembers As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents KarateDataSet As KarateDataSet
    Friend WithEvents MembersBindingSource As BindingSource
    Friend WithEvents MembersTableAdapter As KarateDataSetTableAdapters.MembersTableAdapter
    Friend WithEvents TableAdapterManager As KarateDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Date_JoinedDateTimePicker As DateTimePicker
End Class
