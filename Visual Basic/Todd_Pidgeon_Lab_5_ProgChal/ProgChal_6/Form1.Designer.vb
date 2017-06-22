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
        Me.cmbRegions = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbProvince = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbCity = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblRegion = New System.Windows.Forms.Label()
        Me.lblProvinces = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbRegions
        '
        Me.cmbRegions.FormattingEnabled = True
        Me.cmbRegions.Items.AddRange(New Object() {"NorthEast", "SouthEast", "NorthWest"})
        Me.cmbRegions.Location = New System.Drawing.Point(12, 48)
        Me.cmbRegions.Name = "cmbRegions"
        Me.cmbRegions.Size = New System.Drawing.Size(159, 21)
        Me.cmbRegions.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select a Region"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Select a Province"
        '
        'cmbProvince
        '
        Me.cmbProvince.FormattingEnabled = True
        Me.cmbProvince.Location = New System.Drawing.Point(12, 105)
        Me.cmbProvince.Name = "cmbProvince"
        Me.cmbProvince.Size = New System.Drawing.Size(159, 21)
        Me.cmbProvince.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Select a City"
        '
        'cmbCity
        '
        Me.cmbCity.FormattingEnabled = True
        Me.cmbCity.Location = New System.Drawing.Point(12, 166)
        Me.cmbCity.Name = "cmbCity"
        Me.cmbCity.Size = New System.Drawing.Size(159, 21)
        Me.cmbCity.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(225, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Selections:"
        '
        'lblRegion
        '
        Me.lblRegion.Location = New System.Drawing.Point(225, 46)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.Size = New System.Drawing.Size(170, 23)
        Me.lblRegion.TabIndex = 7
        '
        'lblProvinces
        '
        Me.lblProvinces.Location = New System.Drawing.Point(225, 105)
        Me.lblProvinces.Name = "lblProvinces"
        Me.lblProvinces.Size = New System.Drawing.Size(170, 23)
        Me.lblProvinces.TabIndex = 10
        '
        'lblCity
        '
        Me.lblCity.Location = New System.Drawing.Point(225, 166)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(170, 23)
        Me.lblCity.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 261)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblProvinces)
        Me.Controls.Add(Me.lblRegion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbCity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbProvince)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbRegions)
        Me.Name = "Form1"
        Me.Text = "Selecting Regions, Provinces and Cities"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbRegions As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbProvince As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbCity As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblRegion As System.Windows.Forms.Label
    Friend WithEvents lblProvinces As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label

End Class
