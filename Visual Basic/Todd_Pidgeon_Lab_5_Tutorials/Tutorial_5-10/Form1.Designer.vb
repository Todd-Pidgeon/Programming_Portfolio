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
        Me.picHeads = New System.Windows.Forms.PictureBox()
        Me.picTails = New System.Windows.Forms.PictureBox()
        Me.btnToss = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picHeads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picHeads
        '
        Me.picHeads.Image = CType(resources.GetObject("picHeads.Image"), System.Drawing.Image)
        Me.picHeads.Location = New System.Drawing.Point(12, 12)
        Me.picHeads.Name = "picHeads"
        Me.picHeads.Size = New System.Drawing.Size(120, 119)
        Me.picHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHeads.TabIndex = 0
        Me.picHeads.TabStop = False
        Me.picHeads.Visible = False
        '
        'picTails
        '
        Me.picTails.Image = CType(resources.GetObject("picTails.Image"), System.Drawing.Image)
        Me.picTails.Location = New System.Drawing.Point(138, 12)
        Me.picTails.Name = "picTails"
        Me.picTails.Size = New System.Drawing.Size(120, 119)
        Me.picTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTails.TabIndex = 1
        Me.picTails.TabStop = False
        Me.picTails.Visible = False
        '
        'btnToss
        '
        Me.btnToss.Location = New System.Drawing.Point(32, 151)
        Me.btnToss.Name = "btnToss"
        Me.btnToss.Size = New System.Drawing.Size(84, 23)
        Me.btnToss.TabIndex = 2
        Me.btnToss.Text = "&Toss the Coin"
        Me.btnToss.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(156, 151)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 199)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnToss)
        Me.Controls.Add(Me.picTails)
        Me.Controls.Add(Me.picHeads)
        Me.Name = "Form1"
        Me.Text = "Coin Toss"
        CType(Me.picHeads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picHeads As System.Windows.Forms.PictureBox
    Friend WithEvents picTails As System.Windows.Forms.PictureBox
    Friend WithEvents btnToss As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
