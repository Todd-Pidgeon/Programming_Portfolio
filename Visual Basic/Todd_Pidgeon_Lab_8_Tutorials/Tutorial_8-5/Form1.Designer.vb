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
        Me.lblLowest = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblHighest = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLowest
        '
        Me.lblLowest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLowest.Location = New System.Drawing.Point(171, 148)
        Me.lblLowest.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLowest.Name = "lblLowest"
        Me.lblLowest.Size = New System.Drawing.Size(101, 28)
        Me.lblLowest.TabIndex = 16
        Me.lblLowest.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(225, 226)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 46)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        '
        'lblHighest
        '
        Me.lblHighest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHighest.Location = New System.Drawing.Point(171, 108)
        Me.lblHighest.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHighest.Name = "lblHighest"
        Me.lblHighest.Size = New System.Drawing.Size(101, 28)
        Me.lblHighest.TabIndex = 15
        Me.lblHighest.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAverage
        '
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage.Location = New System.Drawing.Point(171, 69)
        Me.lblAverage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(101, 28)
        Me.lblAverage.TabIndex = 14
        Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(171, 30)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(101, 28)
        Me.lblTotal.TabIndex = 13
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(53, 148)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 28)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Lowest Sales"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblLowest)
        Me.GroupBox1.Controls.Add(Me.lblHighest)
        Me.GroupBox1.Controls.Add(Me.lblAverage)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 16)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(317, 197)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sales Data"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(43, 108)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 28)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Highest Sales"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(43, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 28)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Average Sales"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(64, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 28)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Total Sales"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(63, 226)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(140, 46)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "&Calculate Sales Data"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 288)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Sales Data"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblLowest As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblHighest As System.Windows.Forms.Label
    Friend WithEvents lblAverage As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button

End Class
