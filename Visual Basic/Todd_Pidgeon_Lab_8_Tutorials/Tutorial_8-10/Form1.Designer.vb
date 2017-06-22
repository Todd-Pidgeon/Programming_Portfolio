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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lstFriends = New System.Windows.Forms.ListBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a friend's name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(26, 71)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(124, 20)
        Me.txtName.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(57, 119)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lstFriends
        '
        Me.lstFriends.FormattingEnabled = True
        Me.lstFriends.Location = New System.Drawing.Point(177, 33)
        Me.lstFriends.Name = "lstFriends"
        Me.lstFriends.Size = New System.Drawing.Size(148, 121)
        Me.lstFriends.TabIndex = 3
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(177, 177)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(148, 23)
        Me.btnShow.TabIndex = 4
        Me.btnShow.Text = "Show All"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 230)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.lstFriends)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Friend List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lstFriends As ListBox
    Friend WithEvents btnShow As Button
End Class
