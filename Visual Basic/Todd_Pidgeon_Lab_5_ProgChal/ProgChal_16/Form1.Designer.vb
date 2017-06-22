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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picDieOne = New System.Windows.Forms.PictureBox()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.picDieTwoOne = New System.Windows.Forms.PictureBox()
        Me.picDieTwoTwo = New System.Windows.Forms.PictureBox()
        Me.picDieTwoThree = New System.Windows.Forms.PictureBox()
        Me.picDieTwoFour = New System.Windows.Forms.PictureBox()
        Me.picDieTwoFive = New System.Windows.Forms.PictureBox()
        Me.picDieTwo = New System.Windows.Forms.PictureBox()
        CType(Me.picDieOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDieTwoOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDieTwoTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDieTwoThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDieTwoFour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDieTwoFive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDieTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picDieOne
        '
        Me.picDieOne.Location = New System.Drawing.Point(35, 50)
        Me.picDieOne.Name = "picDieOne"
        Me.picDieOne.Size = New System.Drawing.Size(100, 105)
        Me.picDieOne.TabIndex = 0
        Me.picDieOne.TabStop = False
        '
        'btnRoll
        '
        Me.btnRoll.Location = New System.Drawing.Point(120, 197)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(75, 23)
        Me.btnRoll.TabIndex = 2
        Me.btnRoll.Text = "Roll Dice"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'picDieTwoOne
        '
        Me.picDieTwoOne.Image = CType(resources.GetObject("picDieTwoOne.Image"), System.Drawing.Image)
        Me.picDieTwoOne.Location = New System.Drawing.Point(180, 50)
        Me.picDieTwoOne.Name = "picDieTwoOne"
        Me.picDieTwoOne.Size = New System.Drawing.Size(100, 105)
        Me.picDieTwoOne.TabIndex = 9
        Me.picDieTwoOne.TabStop = False
        Me.picDieTwoOne.Visible = False
        '
        'picDieTwoTwo
        '
        Me.picDieTwoTwo.Image = CType(resources.GetObject("picDieTwoTwo.Image"), System.Drawing.Image)
        Me.picDieTwoTwo.Location = New System.Drawing.Point(180, 50)
        Me.picDieTwoTwo.Name = "picDieTwoTwo"
        Me.picDieTwoTwo.Size = New System.Drawing.Size(100, 105)
        Me.picDieTwoTwo.TabIndex = 10
        Me.picDieTwoTwo.TabStop = False
        Me.picDieTwoTwo.Visible = False
        '
        'picDieTwoThree
        '
        Me.picDieTwoThree.Image = CType(resources.GetObject("picDieTwoThree.Image"), System.Drawing.Image)
        Me.picDieTwoThree.Location = New System.Drawing.Point(180, 50)
        Me.picDieTwoThree.Name = "picDieTwoThree"
        Me.picDieTwoThree.Size = New System.Drawing.Size(100, 105)
        Me.picDieTwoThree.TabIndex = 11
        Me.picDieTwoThree.TabStop = False
        Me.picDieTwoThree.Visible = False
        '
        'picDieTwoFour
        '
        Me.picDieTwoFour.Image = CType(resources.GetObject("picDieTwoFour.Image"), System.Drawing.Image)
        Me.picDieTwoFour.Location = New System.Drawing.Point(180, 50)
        Me.picDieTwoFour.Name = "picDieTwoFour"
        Me.picDieTwoFour.Size = New System.Drawing.Size(100, 105)
        Me.picDieTwoFour.TabIndex = 12
        Me.picDieTwoFour.TabStop = False
        Me.picDieTwoFour.Visible = False
        '
        'picDieTwoFive
        '
        Me.picDieTwoFive.Image = CType(resources.GetObject("picDieTwoFive.Image"), System.Drawing.Image)
        Me.picDieTwoFive.Location = New System.Drawing.Point(180, 50)
        Me.picDieTwoFive.Name = "picDieTwoFive"
        Me.picDieTwoFive.Size = New System.Drawing.Size(100, 105)
        Me.picDieTwoFive.TabIndex = 13
        Me.picDieTwoFive.TabStop = False
        Me.picDieTwoFive.UseWaitCursor = True
        Me.picDieTwoFive.Visible = False
        '
        'picDieTwo
        '
        Me.picDieTwo.Location = New System.Drawing.Point(180, 50)
        Me.picDieTwo.Name = "picDieTwo"
        Me.picDieTwo.Size = New System.Drawing.Size(100, 105)
        Me.picDieTwo.TabIndex = 14
        Me.picDieTwo.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 248)
        Me.Controls.Add(Me.picDieTwo)
        Me.Controls.Add(Me.picDieTwoFive)
        Me.Controls.Add(Me.picDieTwoFour)
        Me.Controls.Add(Me.picDieTwoThree)
        Me.Controls.Add(Me.picDieTwoTwo)
        Me.Controls.Add(Me.picDieTwoOne)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.picDieOne)
        Me.Name = "Form1"
        Me.Text = "Dice Simulator"
        CType(Me.picDieOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDieTwoOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDieTwoTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDieTwoThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDieTwoFour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDieTwoFive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDieTwo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picDieOne As System.Windows.Forms.PictureBox
    Friend WithEvents btnRoll As System.Windows.Forms.Button
    Friend WithEvents picDieTwoOne As System.Windows.Forms.PictureBox
    Friend WithEvents picDieTwoTwo As System.Windows.Forms.PictureBox
    Friend WithEvents picDieTwoThree As System.Windows.Forms.PictureBox
    Friend WithEvents picDieTwoFour As System.Windows.Forms.PictureBox
    Friend WithEvents picDieTwoFive As System.Windows.Forms.PictureBox
    Friend WithEvents picDieTwo As System.Windows.Forms.PictureBox

End Class
