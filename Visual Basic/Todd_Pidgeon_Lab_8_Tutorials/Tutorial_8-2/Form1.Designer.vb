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
        Me.lstFriends = New System.Windows.Forms.ListBox()
        Me.btnEnterNames = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstFriends
        '
        Me.lstFriends.FormattingEnabled = True
        Me.lstFriends.Location = New System.Drawing.Point(22, 22)
        Me.lstFriends.Name = "lstFriends"
        Me.lstFriends.Size = New System.Drawing.Size(229, 134)
        Me.lstFriends.TabIndex = 0
        '
        'btnEnterNames
        '
        Me.btnEnterNames.Location = New System.Drawing.Point(22, 186)
        Me.btnEnterNames.Name = "btnEnterNames"
        Me.btnEnterNames.Size = New System.Drawing.Size(91, 23)
        Me.btnEnterNames.TabIndex = 1
        Me.btnEnterNames.Text = "Enter &Names"
        Me.btnEnterNames.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(160, 186)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(91, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEnterNames)
        Me.Controls.Add(Me.lstFriends)
        Me.Name = "Form1"
        Me.Text = "Friends List"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstFriends As ListBox
    Friend WithEvents btnEnterNames As Button
    Friend WithEvents btnExit As Button
End Class
