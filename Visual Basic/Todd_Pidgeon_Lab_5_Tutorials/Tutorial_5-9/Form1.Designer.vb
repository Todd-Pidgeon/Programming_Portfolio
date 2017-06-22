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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboCountries = New System.Windows.Forms.ComboBox()
        Me.cboPlays = New System.Windows.Forms.ComboBox()
        Me.cboArtists = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblArtist = New System.Windows.Forms.Label()
        Me.lblPlay = New System.Windows.Forms.Label()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choose a Country:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Choose a Play:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Choose an Artist:"
        '
        'cboCountries
        '
        Me.cboCountries.FormattingEnabled = True
        Me.cboCountries.Items.AddRange(New Object() {"England", "Ireland", "Scotland", "Wales"})
        Me.cboCountries.Location = New System.Drawing.Point(113, 13)
        Me.cboCountries.Name = "cboCountries"
        Me.cboCountries.Size = New System.Drawing.Size(121, 21)
        Me.cboCountries.TabIndex = 3
        '
        'cboPlays
        '
        Me.cboPlays.FormattingEnabled = True
        Me.cboPlays.Items.AddRange(New Object() {"Hamlet", "Much Ado about Nothing", "Romeo and Juliet", "A Comedt of Errors", "The Merchant of Venice"})
        Me.cboPlays.Location = New System.Drawing.Point(113, 54)
        Me.cboPlays.Name = "cboPlays"
        Me.cboPlays.Size = New System.Drawing.Size(121, 21)
        Me.cboPlays.TabIndex = 4
        '
        'cboArtists
        '
        Me.cboArtists.FormattingEnabled = True
        Me.cboArtists.Items.AddRange(New Object() {"Michelangelo", "Raphael", "da Vinci"})
        Me.cboArtists.Location = New System.Drawing.Point(112, 113)
        Me.cboArtists.Name = "cboArtists"
        Me.cboArtists.Size = New System.Drawing.Size(121, 21)
        Me.cboArtists.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblArtist)
        Me.GroupBox1.Controls.Add(Me.lblPlay)
        Me.GroupBox1.Controls.Add(Me.lblCountry)
        Me.GroupBox1.Location = New System.Drawing.Point(260, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 128)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Your Choices"
        '
        'lblArtist
        '
        Me.lblArtist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblArtist.Location = New System.Drawing.Point(21, 93)
        Me.lblArtist.Name = "lblArtist"
        Me.lblArtist.Size = New System.Drawing.Size(184, 23)
        Me.lblArtist.TabIndex = 2
        '
        'lblPlay
        '
        Me.lblPlay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPlay.Location = New System.Drawing.Point(21, 57)
        Me.lblPlay.Name = "lblPlay"
        Me.lblPlay.Size = New System.Drawing.Size(184, 23)
        Me.lblPlay.TabIndex = 1
        '
        'lblCountry
        '
        Me.lblCountry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCountry.Location = New System.Drawing.Point(21, 25)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(184, 23)
        Me.lblCountry.TabIndex = 0
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(112, 170)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 34)
        Me.btnShow.TabIndex = 7
        Me.btnShow.Text = "&Show Selection"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(208, 170)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 34)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "&Reset Form"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(308, 170)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 34)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 227)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cboArtists)
        Me.Controls.Add(Me.cboPlays)
        Me.Controls.Add(Me.cboCountries)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Combo Box Demo"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboCountries As System.Windows.Forms.ComboBox
    Friend WithEvents cboPlays As System.Windows.Forms.ComboBox
    Friend WithEvents cboArtists As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCountry As System.Windows.Forms.Label
    Friend WithEvents lblArtist As System.Windows.Forms.Label
    Friend WithEvents lblPlay As System.Windows.Forms.Label
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
