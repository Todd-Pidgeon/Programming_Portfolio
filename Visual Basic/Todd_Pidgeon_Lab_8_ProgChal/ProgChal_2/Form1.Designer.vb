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
        Me.lstSentences = New System.Windows.Forms.ListBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstSentences
        '
        Me.lstSentences.FormattingEnabled = True
        Me.lstSentences.Location = New System.Drawing.Point(12, 12)
        Me.lstSentences.Name = "lstSentences"
        Me.lstSentences.Size = New System.Drawing.Size(438, 173)
        Me.lstSentences.TabIndex = 0
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(12, 207)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(128, 42)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Next Sentence"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(169, 207)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(128, 42)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear Sentence"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(322, 207)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(128, 42)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 261)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lstSentences)
        Me.Name = "Form1"
        Me.Text = "Random Sentences"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstSentences As System.Windows.Forms.ListBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
