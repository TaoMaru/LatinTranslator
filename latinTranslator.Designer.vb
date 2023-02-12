<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class latinTranslator
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
        Me.btnSinister = New System.Windows.Forms.Button()
        Me.btnMedium = New System.Windows.Forms.Button()
        Me.btnDexter = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblLeft = New System.Windows.Forms.Label()
        Me.lblMiddle = New System.Windows.Forms.Label()
        Me.lblRight = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSinister
        '
        Me.btnSinister.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.btnSinister.Location = New System.Drawing.Point(38, 205)
        Me.btnSinister.Name = "btnSinister"
        Me.btnSinister.Size = New System.Drawing.Size(114, 29)
        Me.btnSinister.TabIndex = 0
        Me.btnSinister.Text = "Sinister"
        Me.btnSinister.UseVisualStyleBackColor = True
        '
        'btnMedium
        '
        Me.btnMedium.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.btnMedium.Location = New System.Drawing.Point(184, 205)
        Me.btnMedium.Name = "btnMedium"
        Me.btnMedium.Size = New System.Drawing.Size(114, 29)
        Me.btnMedium.TabIndex = 1
        Me.btnMedium.Text = "Medium"
        Me.btnMedium.UseVisualStyleBackColor = True
        '
        'btnDexter
        '
        Me.btnDexter.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.btnDexter.Location = New System.Drawing.Point(330, 205)
        Me.btnDexter.Name = "btnDexter"
        Me.btnDexter.Size = New System.Drawing.Size(114, 29)
        Me.btnDexter.TabIndex = 2
        Me.btnDexter.Text = "Dexter"
        Me.btnDexter.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.btnExit.Location = New System.Drawing.Point(184, 266)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(114, 29)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblLeft
        '
        Me.lblLeft.Location = New System.Drawing.Point(61, 38)
        Me.lblLeft.Name = "lblLeft"
        Me.lblLeft.Size = New System.Drawing.Size(100, 23)
        Me.lblLeft.TabIndex = 4
        Me.lblLeft.Text = "Label1"
        '
        'lblMiddle
        '
        Me.lblMiddle.Location = New System.Drawing.Point(81, 110)
        Me.lblMiddle.Name = "lblMiddle"
        Me.lblMiddle.Size = New System.Drawing.Size(100, 23)
        Me.lblMiddle.TabIndex = 5
        Me.lblMiddle.Text = "Label2"
        '
        'lblRight
        '
        Me.lblRight.Location = New System.Drawing.Point(170, 71)
        Me.lblRight.Name = "lblRight"
        Me.lblRight.Size = New System.Drawing.Size(100, 23)
        Me.lblRight.TabIndex = 6
        Me.lblRight.Text = "Label3"
        '
        'latinTranslator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 323)
        Me.Controls.Add(Me.lblRight)
        Me.Controls.Add(Me.lblMiddle)
        Me.Controls.Add(Me.lblLeft)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDexter)
        Me.Controls.Add(Me.btnMedium)
        Me.Controls.Add(Me.btnSinister)
        Me.Name = "latinTranslator"
        Me.Text = "Latin Translator"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSinister As Button
    Friend WithEvents btnMedium As Button
    Friend WithEvents btnDexter As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblLeft As Label
    Friend WithEvents lblMiddle As Label
    Friend WithEvents lblRight As Label
End Class
