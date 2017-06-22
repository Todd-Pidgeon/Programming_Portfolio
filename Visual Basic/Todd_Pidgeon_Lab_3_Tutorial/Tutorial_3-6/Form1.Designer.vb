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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picFiveCents = New System.Windows.Forms.PictureBox()
        Me.picTenCents = New System.Windows.Forms.PictureBox()
        Me.picTwentyFiveCents = New System.Windows.Forms.PictureBox()
        Me.PicFiftyCents = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picFiveCents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTenCents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTwentyFiveCents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFiftyCents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Click the Coins"
        '
        'picFiveCents
        '
        Me.picFiveCents.Image = CType(resources.GetObject("picFiveCents.Image"), System.Drawing.Image)
        Me.picFiveCents.Location = New System.Drawing.Point(12, 32)
        Me.picFiveCents.Name = "picFiveCents"
        Me.picFiveCents.Size = New System.Drawing.Size(125, 181)
        Me.picFiveCents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picFiveCents.TabIndex = 1
        Me.picFiveCents.TabStop = False
        '
        'picTenCents
        '
        Me.picTenCents.Image = CType(resources.GetObject("picTenCents.Image"), System.Drawing.Image)
        Me.picTenCents.Location = New System.Drawing.Point(143, 32)
        Me.picTenCents.Name = "picTenCents"
        Me.picTenCents.Size = New System.Drawing.Size(125, 181)
        Me.picTenCents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picTenCents.TabIndex = 2
        Me.picTenCents.TabStop = False
        '
        'picTwentyFiveCents
        '
        Me.picTwentyFiveCents.Image = CType(resources.GetObject("picTwentyFiveCents.Image"), System.Drawing.Image)
        Me.picTwentyFiveCents.Location = New System.Drawing.Point(12, 219)
        Me.picTwentyFiveCents.Name = "picTwentyFiveCents"
        Me.picTwentyFiveCents.Size = New System.Drawing.Size(125, 181)
        Me.picTwentyFiveCents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picTwentyFiveCents.TabIndex = 3
        Me.picTwentyFiveCents.TabStop = False
        '
        'PicFiftyCents
        '
        Me.PicFiftyCents.Image = CType(resources.GetObject("PicFiftyCents.Image"), System.Drawing.Image)
        Me.PicFiftyCents.Location = New System.Drawing.Point(143, 219)
        Me.PicFiftyCents.Name = "PicFiftyCents"
        Me.PicFiftyCents.Size = New System.Drawing.Size(125, 181)
        Me.PicFiftyCents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicFiftyCents.TabIndex = 4
        Me.PicFiftyCents.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 418)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(109, 415)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(123, 23)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(95, 465)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 512)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PicFiftyCents)
        Me.Controls.Add(Me.picTwentyFiveCents)
        Me.Controls.Add(Me.picTenCents)
        Me.Controls.Add(Me.picFiveCents)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Change Counter"
        CType(Me.picFiveCents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTenCents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTwentyFiveCents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFiftyCents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents picFiveCents As PictureBox
    Friend WithEvents picTenCents As PictureBox
    Friend WithEvents picTwentyFiveCents As PictureBox
    Friend WithEvents PicFiftyCents As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnExit As Button
End Class
