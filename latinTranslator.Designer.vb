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
        Me.btnSinister.BackColor = System.Drawing.Color.LightGray
        Me.btnSinister.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSinister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSinister.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnSinister.Location = New System.Drawing.Point(33, 152)
        Me.btnSinister.Name = "btnSinister"
        Me.btnSinister.Size = New System.Drawing.Size(105, 33)
        Me.btnSinister.TabIndex = 0
        Me.btnSinister.Text = "Sinister"
        Me.btnSinister.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSinister.UseVisualStyleBackColor = False
        '
        'btnMedium
        '
        Me.btnMedium.BackColor = System.Drawing.Color.LightGray
        Me.btnMedium.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMedium.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnMedium.Location = New System.Drawing.Point(149, 152)
        Me.btnMedium.Name = "btnMedium"
        Me.btnMedium.Size = New System.Drawing.Size(105, 33)
        Me.btnMedium.TabIndex = 1
        Me.btnMedium.Text = "Medium"
        Me.btnMedium.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMedium.UseVisualStyleBackColor = False
        '
        'btnDexter
        '
        Me.btnDexter.BackColor = System.Drawing.Color.LightGray
        Me.btnDexter.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDexter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDexter.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnDexter.Location = New System.Drawing.Point(264, 152)
        Me.btnDexter.Name = "btnDexter"
        Me.btnDexter.Size = New System.Drawing.Size(105, 33)
        Me.btnDexter.TabIndex = 2
        Me.btnDexter.Text = "Dexter"
        Me.btnDexter.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDexter.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightGray
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnExit.Location = New System.Drawing.Point(149, 192)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(105, 33)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblLeft
        '
        Me.lblLeft.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblLeft.Location = New System.Drawing.Point(146, 60)
        Me.lblLeft.Name = "lblLeft"
        Me.lblLeft.Size = New System.Drawing.Size(110, 39)
        Me.lblLeft.TabIndex = 4
        Me.lblLeft.Text = "Left"
        Me.lblLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLeft.Visible = False
        '
        'lblMiddle
        '
        Me.lblMiddle.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblMiddle.Location = New System.Drawing.Point(146, 60)
        Me.lblMiddle.Name = "lblMiddle"
        Me.lblMiddle.Size = New System.Drawing.Size(110, 39)
        Me.lblMiddle.TabIndex = 5
        Me.lblMiddle.Text = "Middle"
        Me.lblMiddle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMiddle.Visible = False
        '
        'lblRight
        '
        Me.lblRight.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblRight.Location = New System.Drawing.Point(146, 60)
        Me.lblRight.Name = "lblRight"
        Me.lblRight.Size = New System.Drawing.Size(110, 39)
        Me.lblRight.TabIndex = 6
        Me.lblRight.Text = "Right"
        Me.lblRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblRight.Visible = False
        '
        'latinTranslator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(402, 233)
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
