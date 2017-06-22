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
        Me.lstStudent = New System.Windows.Forms.ListBox()
        Me.lstClub = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lblClubSize = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstStudent
        '
        Me.lstStudent.FormattingEnabled = True
        Me.lstStudent.Items.AddRange(New Object() {"Adams, Ben", "Baker, Sally", "Canseco, Juan", "Davis, Sharon", "Etienne, Jean", "Gonzalez, Jose", "Johnson, Eric", "Koenig, Johann", "Matsunaga, Akiko", "Nakamura, Ken", "Ramirez, Maria"})
        Me.lstStudent.Location = New System.Drawing.Point(12, 49)
        Me.lstStudent.Name = "lstStudent"
        Me.lstStudent.Size = New System.Drawing.Size(120, 160)
        Me.lstStudent.TabIndex = 0
        '
        'lstClub
        '
        Me.lstClub.FormattingEnabled = True
        Me.lstClub.Location = New System.Drawing.Point(249, 49)
        Me.lstClub.Name = "lstClub"
        Me.lstClub.Size = New System.Drawing.Size(120, 160)
        Me.lstClub.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "General Student List"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(246, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Club Membership List"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(138, 93)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(93, 61)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add selected student"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(375, 93)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(93, 61)
        Me.btnRemove.TabIndex = 5
        Me.btnRemove.Text = "Remove selected member"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'lblClubSize
        '
        Me.lblClubSize.Location = New System.Drawing.Point(376, 175)
        Me.lblClubSize.Name = "lblClubSize"
        Me.lblClubSize.Size = New System.Drawing.Size(100, 23)
        Me.lblClubSize.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 261)
        Me.Controls.Add(Me.lblClubSize)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstClub)
        Me.Controls.Add(Me.lstStudent)
        Me.Name = "Form1"
        Me.Text = "Adding Students to a Club"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstStudent As System.Windows.Forms.ListBox
    Friend WithEvents lstClub As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents lblClubSize As System.Windows.Forms.Label

End Class
