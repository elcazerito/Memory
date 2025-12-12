<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reglages
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.AudioGB = New System.Windows.Forms.GroupBox()
        Me.AudioTrBar = New System.Windows.Forms.TrackBar()
        Me.VolumeBtn = New Memory.Volume()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.secLabel = New System.Windows.Forms.Label()
        Me.TimeTB = New System.Windows.Forms.TextBox()
        Me.RBtnOther = New System.Windows.Forms.RadioButton()
        Me.RBtn60 = New System.Windows.Forms.RadioButton()
        Me.RBtn45 = New System.Windows.Forms.RadioButton()
        Me.RBtn30 = New System.Windows.Forms.RadioButton()
        Me.RBtn15 = New System.Windows.Forms.RadioButton()
        Me.SettingsLabel = New System.Windows.Forms.Label()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.AudioGB.SuspendLayout()
        CType(Me.AudioTrBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VolumeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AudioGB
        '
        Me.AudioGB.Controls.Add(Me.AudioTrBar)
        Me.AudioGB.Controls.Add(Me.VolumeBtn)
        Me.AudioGB.Location = New System.Drawing.Point(17, 61)
        Me.AudioGB.Name = "AudioGB"
        Me.AudioGB.Size = New System.Drawing.Size(771, 143)
        Me.AudioGB.TabIndex = 0
        Me.AudioGB.TabStop = False
        Me.AudioGB.Text = "Audio"
        '
        'AudioTrBar
        '
        Me.AudioTrBar.Enabled = False
        Me.AudioTrBar.Location = New System.Drawing.Point(147, 74)
        Me.AudioTrBar.Maximum = 100
        Me.AudioTrBar.Name = "AudioTrBar"
        Me.AudioTrBar.Size = New System.Drawing.Size(575, 69)
        Me.AudioTrBar.TabIndex = 0
        Me.AudioTrBar.Value = 50
        '
        'VolumeBtn
        '
        Me.VolumeBtn.Location = New System.Drawing.Point(17, 32)
        Me.VolumeBtn.Name = "VolumeBtn"
        Me.VolumeBtn.Size = New System.Drawing.Size(100, 100)
        Me.VolumeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.VolumeBtn.TabIndex = 0
        Me.VolumeBtn.TabStop = False
        Me.VolumeBtn.Valeur = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.secLabel)
        Me.GroupBox1.Controls.Add(Me.TimeTB)
        Me.GroupBox1.Controls.Add(Me.RBtnOther)
        Me.GroupBox1.Controls.Add(Me.RBtn60)
        Me.GroupBox1.Controls.Add(Me.RBtn45)
        Me.GroupBox1.Controls.Add(Me.RBtn30)
        Me.GroupBox1.Controls.Add(Me.RBtn15)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 210)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(769, 147)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Temps"
        '
        'secLabel
        '
        Me.secLabel.AutoSize = True
        Me.secLabel.Location = New System.Drawing.Point(551, 103)
        Me.secLabel.Name = "secLabel"
        Me.secLabel.Size = New System.Drawing.Size(17, 20)
        Me.secLabel.TabIndex = 6
        Me.secLabel.Text = "s"
        Me.secLabel.Visible = False
        '
        'TimeTB
        '
        Me.TimeTB.Enabled = False
        Me.TimeTB.Location = New System.Drawing.Point(345, 97)
        Me.TimeTB.Name = "TimeTB"
        Me.TimeTB.Size = New System.Drawing.Size(200, 26)
        Me.TimeTB.TabIndex = 5
        Me.TimeTB.Visible = False
        '
        'RBtnOther
        '
        Me.RBtnOther.AutoSize = True
        Me.RBtnOther.Location = New System.Drawing.Point(244, 99)
        Me.RBtnOther.Name = "RBtnOther"
        Me.RBtnOther.Size = New System.Drawing.Size(81, 24)
        Me.RBtnOther.TabIndex = 4
        Me.RBtnOther.TabStop = True
        Me.RBtnOther.Text = "Autre :"
        Me.RBtnOther.UseVisualStyleBackColor = True
        '
        'RBtn60
        '
        Me.RBtn60.AutoSize = True
        Me.RBtn60.Checked = True
        Me.RBtn60.Location = New System.Drawing.Point(646, 37)
        Me.RBtn60.Name = "RBtn60"
        Me.RBtn60.Size = New System.Drawing.Size(60, 24)
        Me.RBtn60.TabIndex = 3
        Me.RBtn60.TabStop = True
        Me.RBtn60.Text = "60s"
        Me.RBtn60.UseVisualStyleBackColor = True
        '
        'RBtn45
        '
        Me.RBtn45.AutoSize = True
        Me.RBtn45.Location = New System.Drawing.Point(466, 37)
        Me.RBtn45.Name = "RBtn45"
        Me.RBtn45.Size = New System.Drawing.Size(60, 24)
        Me.RBtn45.TabIndex = 2
        Me.RBtn45.TabStop = True
        Me.RBtn45.Text = "45s"
        Me.RBtn45.UseVisualStyleBackColor = True
        '
        'RBtn30
        '
        Me.RBtn30.AutoSize = True
        Me.RBtn30.Location = New System.Drawing.Point(265, 37)
        Me.RBtn30.Name = "RBtn30"
        Me.RBtn30.Size = New System.Drawing.Size(60, 24)
        Me.RBtn30.TabIndex = 1
        Me.RBtn30.TabStop = True
        Me.RBtn30.Text = "30s"
        Me.RBtn30.UseVisualStyleBackColor = True
        '
        'RBtn15
        '
        Me.RBtn15.AutoSize = True
        Me.RBtn15.Location = New System.Drawing.Point(42, 37)
        Me.RBtn15.Name = "RBtn15"
        Me.RBtn15.Size = New System.Drawing.Size(60, 24)
        Me.RBtn15.TabIndex = 0
        Me.RBtn15.TabStop = True
        Me.RBtn15.Text = "15s"
        Me.RBtn15.UseVisualStyleBackColor = True
        '
        'SettingsLabel
        '
        Me.SettingsLabel.AutoSize = True
        Me.SettingsLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.0!)
        Me.SettingsLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.SettingsLabel.Location = New System.Drawing.Point(300, 12)
        Me.SettingsLabel.Name = "SettingsLabel"
        Me.SettingsLabel.Size = New System.Drawing.Size(204, 46)
        Me.SettingsLabel.TabIndex = 3
        Me.SettingsLabel.Text = "Réglages"
        '
        'SaveBtn
        '
        Me.SaveBtn.BackColor = System.Drawing.Color.Red
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.ForeColor = System.Drawing.Color.White
        Me.SaveBtn.Location = New System.Drawing.Point(324, 365)
        Me.SaveBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(138, 34)
        Me.SaveBtn.TabIndex = 4
        Me.SaveBtn.Text = "Sauvegarder"
        Me.SaveBtn.UseVisualStyleBackColor = False
        '
        'Reglages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 422)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SettingsLabel)
        Me.Controls.Add(Me.AudioGB)
        Me.ForeColor = System.Drawing.Color.Black
        Me.KeyPreview = True
        Me.Name = "Reglages"
        Me.Text = "Réglages"
        Me.AudioGB.ResumeLayout(False)
        Me.AudioGB.PerformLayout()
        CType(Me.AudioTrBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VolumeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AudioGB As GroupBox
    Friend WithEvents VolumeBtn As Volume
    Friend WithEvents AudioTrBar As TrackBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SettingsLabel As Label
    Friend WithEvents RBtn30 As RadioButton
    Friend WithEvents RBtn15 As RadioButton
    Friend WithEvents secLabel As Label
    Friend WithEvents TimeTB As TextBox
    Friend WithEvents RBtnOther As RadioButton
    Friend WithEvents RBtn60 As RadioButton
    Friend WithEvents RBtn45 As RadioButton
    Friend WithEvents SaveBtn As Button
End Class
