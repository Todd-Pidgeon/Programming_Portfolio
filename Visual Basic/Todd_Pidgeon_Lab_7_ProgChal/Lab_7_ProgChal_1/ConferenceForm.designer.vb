<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConferenceForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkOpeningNight = New System.Windows.Forms.CheckBox()
        Me.chkConRef = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstWorkshops = New System.Windows.Forms.ListBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chkOpeningNight)
        Me.GroupBox1.Controls.Add(Me.chkConRef)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Conference"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(251, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "$30"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(251, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "$895"
        '
        'chkOpeningNight
        '
        Me.chkOpeningNight.AutoSize = True
        Me.chkOpeningNight.Location = New System.Drawing.Point(7, 57)
        Me.chkOpeningNight.Name = "chkOpeningNight"
        Me.chkOpeningNight.Size = New System.Drawing.Size(182, 17)
        Me.chkOpeningNight.TabIndex = 1
        Me.chkOpeningNight.Text = "Opening Night Dinner && Keynote "
        Me.chkOpeningNight.UseVisualStyleBackColor = True
        '
        'chkConRef
        '
        Me.chkConRef.AutoSize = True
        Me.chkConRef.Location = New System.Drawing.Point(7, 20)
        Me.chkConRef.Name = "chkConRef"
        Me.chkConRef.Size = New System.Drawing.Size(140, 17)
        Me.chkConRef.TabIndex = 0
        Me.chkConRef.Text = "Conference Registration"
        Me.chkConRef.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lstWorkshops)
        Me.GroupBox2.Location = New System.Drawing.Point(314, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Preconference Workshops"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Select One"
        '
        'lstWorkshops
        '
        Me.lstWorkshops.FormattingEnabled = True
        Me.lstWorkshops.Items.AddRange(New Object() {"Intro to E-commerce" & Global.Microsoft.VisualBasic.ChrW(9) & "$295", "The Future of the Web" & Global.Microsoft.VisualBasic.ChrW(9) & "$295", "Advanced Visual Basic" & Global.Microsoft.VisualBasic.ChrW(9) & "$395", "Network Security" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "$395"})
        Me.lstWorkshops.Location = New System.Drawing.Point(6, 32)
        Me.lstWorkshops.Name = "lstWorkshops"
        Me.lstWorkshops.Size = New System.Drawing.Size(188, 56)
        Me.lstWorkshops.TabIndex = 0
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(314, 133)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 39)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(395, 133)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 39)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'ConferenceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 194)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ConferenceForm"
        Me.Text = "Conference Options"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkOpeningNight As CheckBox
    Friend WithEvents chkConRef As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lstWorkshops As ListBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnClose As Button
End Class
