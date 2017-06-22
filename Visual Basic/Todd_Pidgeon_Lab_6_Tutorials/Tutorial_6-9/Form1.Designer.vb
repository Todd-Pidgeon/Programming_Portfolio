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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkPeach = New System.Windows.Forms.CheckBox()
        Me.chkBlueberry = New System.Windows.Forms.CheckBox()
        Me.chkRaspberry = New System.Windows.Forms.CheckBox()
        Me.chkButter = New System.Windows.Forms.CheckBox()
        Me.chkCreamCheese = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radWheat = New System.Windows.Forms.RadioButton()
        Me.radWhite = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.radRegCoffee = New System.Windows.Forms.RadioButton()
        Me.radNoCoffee = New System.Windows.Forms.RadioButton()
        Me.radCappuccino = New System.Windows.Forms.RadioButton()
        Me.radCafeAuLait = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Brandi's Bagel House"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(189, 277)
        Me.Panel1.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkPeach)
        Me.GroupBox2.Controls.Add(Me.chkBlueberry)
        Me.GroupBox2.Controls.Add(Me.chkRaspberry)
        Me.GroupBox2.Controls.Add(Me.chkButter)
        Me.GroupBox2.Controls.Add(Me.chkCreamCheese)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(150, 139)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pick your Toppings"
        '
        'chkPeach
        '
        Me.chkPeach.AutoSize = True
        Me.chkPeach.Location = New System.Drawing.Point(6, 112)
        Me.chkPeach.Name = "chkPeach"
        Me.chkPeach.Size = New System.Drawing.Size(113, 17)
        Me.chkPeach.TabIndex = 4
        Me.chkPeach.Text = "Peach Jelly  ($.75)"
        Me.ToolTip1.SetToolTip(Me.chkPeach, "Click here to choose peach jelly.")
        Me.chkPeach.UseVisualStyleBackColor = True
        '
        'chkBlueberry
        '
        Me.chkBlueberry.AutoSize = True
        Me.chkBlueberry.Location = New System.Drawing.Point(5, 66)
        Me.chkBlueberry.Name = "chkBlueberry"
        Me.chkBlueberry.Size = New System.Drawing.Size(125, 17)
        Me.chkBlueberry.TabIndex = 3
        Me.chkBlueberry.Text = "Blueberry Jam  ($.75)"
        Me.ToolTip1.SetToolTip(Me.chkBlueberry, "Click here to choose blueberry jam.")
        Me.chkBlueberry.UseVisualStyleBackColor = True
        '
        'chkRaspberry
        '
        Me.chkRaspberry.AutoSize = True
        Me.chkRaspberry.Location = New System.Drawing.Point(5, 89)
        Me.chkRaspberry.Name = "chkRaspberry"
        Me.chkRaspberry.Size = New System.Drawing.Size(126, 17)
        Me.chkRaspberry.TabIndex = 2
        Me.chkRaspberry.Text = "Raspberry Jam ($.75)"
        Me.ToolTip1.SetToolTip(Me.chkRaspberry, "Click here to choose raspberry jame.")
        Me.chkRaspberry.UseVisualStyleBackColor = True
        '
        'chkButter
        '
        Me.chkButter.AutoSize = True
        Me.chkButter.Location = New System.Drawing.Point(6, 43)
        Me.chkButter.Name = "chkButter"
        Me.chkButter.Size = New System.Drawing.Size(84, 17)
        Me.chkButter.TabIndex = 1
        Me.chkButter.Text = "Butter ($.25)"
        Me.ToolTip1.SetToolTip(Me.chkButter, "Click here to choose butter.")
        Me.chkButter.UseVisualStyleBackColor = True
        '
        'chkCreamCheese
        '
        Me.chkCreamCheese.AutoSize = True
        Me.chkCreamCheese.Location = New System.Drawing.Point(6, 20)
        Me.chkCreamCheese.Name = "chkCreamCheese"
        Me.chkCreamCheese.Size = New System.Drawing.Size(125, 17)
        Me.chkCreamCheese.TabIndex = 0
        Me.chkCreamCheese.Text = "Cream Cheese ($.50)"
        Me.ToolTip1.SetToolTip(Me.chkCreamCheese, "Click here to choose cream cheese.")
        Me.chkCreamCheese.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radWheat)
        Me.GroupBox1.Controls.Add(Me.radWhite)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(150, 77)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pick A Bagel"
        '
        'radWheat
        '
        Me.radWheat.AutoSize = True
        Me.radWheat.Location = New System.Drawing.Point(6, 43)
        Me.radWheat.Name = "radWheat"
        Me.radWheat.Size = New System.Drawing.Size(127, 17)
        Me.radWheat.TabIndex = 1
        Me.radWheat.Text = "Whole Wheat ($1.50)"
        Me.ToolTip1.SetToolTip(Me.radWheat, "Click here to choose a whole wheat bagel.")
        Me.radWheat.UseVisualStyleBackColor = True
        '
        'radWhite
        '
        Me.radWhite.AutoSize = True
        Me.radWhite.Checked = True
        Me.radWhite.Location = New System.Drawing.Point(7, 20)
        Me.radWhite.Name = "radWhite"
        Me.radWhite.Size = New System.Drawing.Size(89, 17)
        Me.radWhite.TabIndex = 0
        Me.radWhite.TabStop = True
        Me.radWhite.Text = "White ($1.25)"
        Me.ToolTip1.SetToolTip(Me.radWhite, "Click here to choose a whole white bagel.")
        Me.radWhite.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.GroupBox4)
        Me.Panel2.Location = New System.Drawing.Point(224, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(204, 277)
        Me.Panel2.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Controls.Add(Me.lblTax)
        Me.GroupBox3.Controls.Add(Me.lblSubtotal)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 139)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(171, 127)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Price"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.radCafeAuLait)
        Me.GroupBox4.Controls.Add(Me.radCappuccino)
        Me.GroupBox4.Controls.Add(Me.radRegCoffee)
        Me.GroupBox4.Controls.Add(Me.radNoCoffee)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 15)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(171, 118)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Want Coffee with That?"
        '
        'radRegCoffee
        '
        Me.radRegCoffee.AutoSize = True
        Me.radRegCoffee.Checked = True
        Me.radRegCoffee.Location = New System.Drawing.Point(6, 43)
        Me.radRegCoffee.Name = "radRegCoffee"
        Me.radRegCoffee.Size = New System.Drawing.Size(132, 17)
        Me.radRegCoffee.TabIndex = 1
        Me.radRegCoffee.TabStop = True
        Me.radRegCoffee.Text = "Regular Coffee ($1.25)"
        Me.ToolTip1.SetToolTip(Me.radRegCoffee, "Click here to choose regular coffee.")
        Me.radRegCoffee.UseVisualStyleBackColor = True
        '
        'radNoCoffee
        '
        Me.radNoCoffee.AutoSize = True
        Me.radNoCoffee.Location = New System.Drawing.Point(7, 20)
        Me.radNoCoffee.Name = "radNoCoffee"
        Me.radNoCoffee.Size = New System.Drawing.Size(51, 17)
        Me.radNoCoffee.TabIndex = 0
        Me.radNoCoffee.Text = "None"
        Me.ToolTip1.SetToolTip(Me.radNoCoffee, "Click here to choose no coffee.")
        Me.radNoCoffee.UseVisualStyleBackColor = True
        '
        'radCappuccino
        '
        Me.radCappuccino.AutoSize = True
        Me.radCappuccino.Location = New System.Drawing.Point(7, 66)
        Me.radCappuccino.Name = "radCappuccino"
        Me.radCappuccino.Size = New System.Drawing.Size(118, 17)
        Me.radCappuccino.TabIndex = 2
        Me.radCappuccino.Text = "Cappuccino ($2.00)"
        Me.ToolTip1.SetToolTip(Me.radCappuccino, "Click here to choose cappuccino.")
        Me.radCappuccino.UseVisualStyleBackColor = True
        '
        'radCafeAuLait
        '
        Me.radCafeAuLait.AutoSize = True
        Me.radCafeAuLait.Location = New System.Drawing.Point(7, 89)
        Me.radCafeAuLait.Name = "radCafeAuLait"
        Me.radCafeAuLait.Size = New System.Drawing.Size(118, 17)
        Me.radCafeAuLait.TabIndex = 3
        Me.radCafeAuLait.Text = "Cafe au Lait ($1.75)"
        Me.ToolTip1.SetToolTip(Me.radCafeAuLait, "Click here to choose cafe au lait.")
        Me.radCafeAuLait.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Subtotal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tax"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Total"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotal.Location = New System.Drawing.Point(59, 14)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(100, 23)
        Me.lblSubtotal.TabIndex = 3
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(59, 49)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(100, 23)
        Me.lblTax.TabIndex = 4
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(59, 83)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(45, 362)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(113, 23)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "&Calculate Total"
        Me.ToolTip1.SetToolTip(Me.btnCalculate, "Click here to calculate the total of the order.")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(164, 362)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(113, 23)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "&Reset Form"
        Me.ToolTip1.SetToolTip(Me.btnReset, "Click here to clear the form and start over.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(283, 362)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(113, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Click here to exit.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 406)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Bagel and Coffee Price Calculator"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkPeach As CheckBox
    Friend WithEvents chkBlueberry As CheckBox
    Friend WithEvents chkRaspberry As CheckBox
    Friend WithEvents chkButter As CheckBox
    Friend WithEvents chkCreamCheese As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radWheat As RadioButton
    Friend WithEvents radWhite As RadioButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents radCafeAuLait As System.Windows.Forms.RadioButton
    Friend WithEvents radCappuccino As System.Windows.Forms.RadioButton
    Friend WithEvents radRegCoffee As System.Windows.Forms.RadioButton
    Friend WithEvents radNoCoffee As System.Windows.Forms.RadioButton
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
