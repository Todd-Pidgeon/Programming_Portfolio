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
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColorRed = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColorGreen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColorBlue = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColorBlack = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuColorVisable = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(103, 222)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(65, 13)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "Hello World!"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuColor, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.mnuFileExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuFileExit.Text = "E&xit"
        '
        'mnuColor
        '
        Me.mnuColor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColorRed, Me.mnuColorGreen, Me.mnuColorBlue, Me.mnuColorBlack, Me.ToolStripMenuItem1, Me.mnuColorVisable})
        Me.mnuColor.Name = "mnuColor"
        Me.mnuColor.Size = New System.Drawing.Size(48, 20)
        Me.mnuColor.Text = "&Color"
        '
        'mnuColorRed
        '
        Me.mnuColorRed.Name = "mnuColorRed"
        Me.mnuColorRed.Size = New System.Drawing.Size(152, 22)
        Me.mnuColorRed.Text = "&Red"
        '
        'mnuColorGreen
        '
        Me.mnuColorGreen.Name = "mnuColorGreen"
        Me.mnuColorGreen.Size = New System.Drawing.Size(152, 22)
        Me.mnuColorGreen.Text = "&Green"
        '
        'mnuColorBlue
        '
        Me.mnuColorBlue.Name = "mnuColorBlue"
        Me.mnuColorBlue.Size = New System.Drawing.Size(152, 22)
        Me.mnuColorBlue.Text = "&Blue"
        '
        'mnuColorBlack
        '
        Me.mnuColorBlack.Name = "mnuColorBlack"
        Me.mnuColorBlack.Size = New System.Drawing.Size(152, 22)
        Me.mnuColorBlack.Text = "Blac&k"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'mnuColorVisable
        '
        Me.mnuColorVisable.Checked = True
        Me.mnuColorVisable.CheckOnClick = True
        Me.mnuColorVisable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuColorVisable.Name = "mnuColorVisable"
        Me.mnuColorVisable.Size = New System.Drawing.Size(152, 22)
        Me.mnuColorVisable.Text = "Visable"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(152, 22)
        Me.mnuHelpAbout.Text = "&About"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Menu Demo"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMessage As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuColor As ToolStripMenuItem
    Friend WithEvents mnuColorRed As ToolStripMenuItem
    Friend WithEvents mnuColorGreen As ToolStripMenuItem
    Friend WithEvents mnuColorBlue As ToolStripMenuItem
    Friend WithEvents mnuColorBlack As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents mnuColorVisable As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
End Class
