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
        Me.btnCatchMe = New System.Windows.Forms.Button()
        Me.tmrGameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnCatchMe
        '
        Me.btnCatchMe.Location = New System.Drawing.Point(97, 112)
        Me.btnCatchMe.Name = "btnCatchMe"
        Me.btnCatchMe.Size = New System.Drawing.Size(75, 23)
        Me.btnCatchMe.TabIndex = 0
        Me.btnCatchMe.Text = "Catch Me!"
        Me.btnCatchMe.UseVisualStyleBackColor = True
        '
        'tmrGameTimer
        '
        Me.tmrGameTimer.Enabled = True
        Me.tmrGameTimer.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnCatchMe)
        Me.Name = "Form1"
        Me.Text = "Catch Me"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCatchMe As Button
    Friend WithEvents tmrGameTimer As Timer
End Class
