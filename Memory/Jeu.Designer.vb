<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Jeu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.HeadGB = New System.Windows.Forms.GroupBox()
        Me.ForfaitBtn = New System.Windows.Forms.Button()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.PlayerLabel = New System.Windows.Forms.Label()
        Me.GameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.CardsGB = New System.Windows.Forms.GroupBox()
        Me.Carte16 = New Memory.Carte()
        Me.Carte17 = New Memory.Carte()
        Me.Carte18 = New Memory.Carte()
        Me.Carte19 = New Memory.Carte()
        Me.Carte20 = New Memory.Carte()
        Me.Carte11 = New Memory.Carte()
        Me.Carte12 = New Memory.Carte()
        Me.Carte13 = New Memory.Carte()
        Me.Carte14 = New Memory.Carte()
        Me.Carte15 = New Memory.Carte()
        Me.Carte6 = New Memory.Carte()
        Me.Carte7 = New Memory.Carte()
        Me.Carte8 = New Memory.Carte()
        Me.Carte9 = New Memory.Carte()
        Me.Carte10 = New Memory.Carte()
        Me.Carte5 = New Memory.Carte()
        Me.Carte4 = New Memory.Carte()
        Me.Carte3 = New Memory.Carte()
        Me.Carte2 = New Memory.Carte()
        Me.Carte1 = New Memory.Carte()
        Me.HeadGB.SuspendLayout()
        Me.CardsGB.SuspendLayout()
        CType(Me.Carte16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Carte17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Carte18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Carte19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Carte20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Carte11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Carte12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Carte13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Carte14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Carte15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Carte6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Carte7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Carte8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Carte9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Carte10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Carte5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Carte4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Carte3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Carte2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Carte1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HeadGB
        '
        Me.HeadGB.Controls.Add(Me.ForfaitBtn)
        Me.HeadGB.Controls.Add(Me.TimeLabel)
        Me.HeadGB.Controls.Add(Me.PlayerLabel)
        Me.HeadGB.Location = New System.Drawing.Point(22, -3)
        Me.HeadGB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.HeadGB.Name = "HeadGB"
        Me.HeadGB.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.HeadGB.Size = New System.Drawing.Size(1012, 55)
        Me.HeadGB.TabIndex = 0
        Me.HeadGB.TabStop = False
        '
        'ForfaitBtn
        '
        Me.ForfaitBtn.BackColor = System.Drawing.Color.Red
        Me.ForfaitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForfaitBtn.ForeColor = System.Drawing.Color.White
        Me.ForfaitBtn.Location = New System.Drawing.Point(8, 15)
        Me.ForfaitBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ForfaitBtn.Name = "ForfaitBtn"
        Me.ForfaitBtn.Size = New System.Drawing.Size(138, 34)
        Me.ForfaitBtn.TabIndex = 2
        Me.ForfaitBtn.Text = "Abandonner"
        Me.ForfaitBtn.UseVisualStyleBackColor = False
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TimeLabel.Location = New System.Drawing.Point(477, 22)
        Me.TimeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(74, 19)
        Me.TimeLabel.TabIndex = 1
        Me.TimeLabel.Text = "Temps : "
        '
        'PlayerLabel
        '
        Me.PlayerLabel.AutoSize = True
        Me.PlayerLabel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PlayerLabel.Location = New System.Drawing.Point(938, 22)
        Me.PlayerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PlayerLabel.Name = "PlayerLabel"
        Me.PlayerLabel.Size = New System.Drawing.Size(73, 19)
        Me.PlayerLabel.TabIndex = 0
        Me.PlayerLabel.Text = "Joueur :"
        '
        'GameTimer
        '
        Me.GameTimer.Interval = 1000
        '
        'CardsGB
        '
        Me.CardsGB.Controls.Add(Me.Carte16)
        Me.CardsGB.Controls.Add(Me.Carte17)
        Me.CardsGB.Controls.Add(Me.Carte18)
        Me.CardsGB.Controls.Add(Me.Carte19)
        Me.CardsGB.Controls.Add(Me.Carte20)
        Me.CardsGB.Controls.Add(Me.Carte11)
        Me.CardsGB.Controls.Add(Me.Carte12)
        Me.CardsGB.Controls.Add(Me.Carte13)
        Me.CardsGB.Controls.Add(Me.Carte14)
        Me.CardsGB.Controls.Add(Me.Carte15)
        Me.CardsGB.Controls.Add(Me.Carte6)
        Me.CardsGB.Controls.Add(Me.Carte7)
        Me.CardsGB.Controls.Add(Me.Carte8)
        Me.CardsGB.Controls.Add(Me.Carte9)
        Me.CardsGB.Controls.Add(Me.Carte10)
        Me.CardsGB.Controls.Add(Me.Carte5)
        Me.CardsGB.Controls.Add(Me.Carte4)
        Me.CardsGB.Controls.Add(Me.Carte3)
        Me.CardsGB.Controls.Add(Me.Carte2)
        Me.CardsGB.Controls.Add(Me.Carte1)
        Me.CardsGB.Location = New System.Drawing.Point(22, 49)
        Me.CardsGB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CardsGB.Name = "CardsGB"
        Me.CardsGB.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CardsGB.Size = New System.Drawing.Size(1012, 883)
        Me.CardsGB.TabIndex = 1
        Me.CardsGB.TabStop = False
        '
        'Carte16
        '
        Me.Carte16.Location = New System.Drawing.Point(801, 675)
        Me.Carte16.Name = "Carte16"
        Me.Carte16.Size = New System.Drawing.Size(150, 150)
        Me.Carte16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Carte16.TabIndex = 19
        Me.Carte16.TabStop = False
        Me.Carte16.Valeur = 0
        '
        'Carte17
        '
        Me.Carte17.Location = New System.Drawing.Point(609, 675)
        Me.Carte17.Name = "Carte17"
        Me.Carte17.Size = New System.Drawing.Size(150, 150)
        Me.Carte17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Carte17.TabIndex = 18
        Me.Carte17.TabStop = False
        Me.Carte17.Valeur = 0
        '
        'Carte18
        '
        Me.Carte18.Location = New System.Drawing.Point(423, 675)
        Me.Carte18.Name = "Carte18"
        Me.Carte18.Size = New System.Drawing.Size(150, 150)
        Me.Carte18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Carte18.TabIndex = 17
        Me.Carte18.TabStop = False
        Me.Carte18.Valeur = 0
        '
        'Carte19
        '
        Me.Carte19.Location = New System.Drawing.Point(231, 675)
        Me.Carte19.Name = "Carte19"
        Me.Carte19.Size = New System.Drawing.Size(150, 150)
        Me.Carte19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Carte19.TabIndex = 16
        Me.Carte19.TabStop = False
        Me.Carte19.Valeur = 0
        '
        'Carte20
        '
        Me.Carte20.Location = New System.Drawing.Point(44, 675)
        Me.Carte20.Name = "Carte20"
        Me.Carte20.Size = New System.Drawing.Size(150, 150)
        Me.Carte20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Carte20.TabIndex = 15
        Me.Carte20.TabStop = False
        Me.Carte20.Valeur = 0
        '
        'Carte11
        '
        Me.Carte11.Location = New System.Drawing.Point(801, 491)
        Me.Carte11.Name = "Carte11"
        Me.Carte11.Size = New System.Drawing.Size(150, 150)
        Me.Carte11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Carte11.TabIndex = 14
        Me.Carte11.TabStop = False
        Me.Carte11.Valeur = 0
        '
        'Carte12
        '
        Me.Carte12.Location = New System.Drawing.Point(609, 491)
        Me.Carte12.Name = "Carte12"
        Me.Carte12.Size = New System.Drawing.Size(150, 150)
        Me.Carte12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Carte12.TabIndex = 13
        Me.Carte12.TabStop = False
        Me.Carte12.Valeur = 0
        '
        'Carte13
        '
        Me.Carte13.Location = New System.Drawing.Point(423, 491)
        Me.Carte13.Name = "Carte13"
        Me.Carte13.Size = New System.Drawing.Size(150, 150)
        Me.Carte13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Carte13.TabIndex = 12
        Me.Carte13.TabStop = False
        Me.Carte13.Valeur = 0
        '
        'Carte14
        '
        Me.Carte14.Location = New System.Drawing.Point(231, 491)
        Me.Carte14.Name = "Carte14"
        Me.Carte14.Size = New System.Drawing.Size(150, 150)
        Me.Carte14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Carte14.TabIndex = 11
        Me.Carte14.TabStop = False
        Me.Carte14.Valeur = 0
        '
        'Carte15
        '
        Me.Carte15.Location = New System.Drawing.Point(44, 491)
        Me.Carte15.Name = "Carte15"
        Me.Carte15.Size = New System.Drawing.Size(150, 150)
        Me.Carte15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Carte15.TabIndex = 10
        Me.Carte15.TabStop = False
        Me.Carte15.Valeur = 0
        '
        'Carte6
        '
        Me.Carte6.Location = New System.Drawing.Point(801, 313)
        Me.Carte6.Name = "Carte6"
        Me.Carte6.Size = New System.Drawing.Size(150, 150)
        Me.Carte6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Carte6.TabIndex = 9
        Me.Carte6.TabStop = False
        Me.Carte6.Valeur = 0
        '
        'Carte7
        '
        Me.Carte7.Location = New System.Drawing.Point(609, 313)
        Me.Carte7.Name = "Carte7"
        Me.Carte7.Size = New System.Drawing.Size(150, 150)
        Me.Carte7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Carte7.TabIndex = 8
        Me.Carte7.TabStop = False
        Me.Carte7.Valeur = 0
        '
        'Carte8
        '
        Me.Carte8.Location = New System.Drawing.Point(423, 313)
        Me.Carte8.Name = "Carte8"
        Me.Carte8.Size = New System.Drawing.Size(150, 150)
        Me.Carte8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Carte8.TabIndex = 7
        Me.Carte8.TabStop = False
        Me.Carte8.Valeur = 0
        '
        'Carte9
        '
        Me.Carte9.Location = New System.Drawing.Point(231, 313)
        Me.Carte9.Name = "Carte9"
        Me.Carte9.Size = New System.Drawing.Size(150, 150)
        Me.Carte9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Carte9.TabIndex = 6
        Me.Carte9.TabStop = False
        Me.Carte9.Valeur = 0
        '
        'Carte10
        '
        Me.Carte10.Location = New System.Drawing.Point(44, 313)
        Me.Carte10.Name = "Carte10"
        Me.Carte10.Size = New System.Drawing.Size(150, 150)
        Me.Carte10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Carte10.TabIndex = 5
        Me.Carte10.TabStop = False
        Me.Carte10.Valeur = 0
        '
        'Carte5
        '
        Me.Carte5.Location = New System.Drawing.Point(801, 134)
        Me.Carte5.Name = "Carte5"
        Me.Carte5.Size = New System.Drawing.Size(150, 150)
        Me.Carte5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Carte5.TabIndex = 4
        Me.Carte5.TabStop = False
        Me.Carte5.Valeur = 0
        '
        'Carte4
        '
        Me.Carte4.Location = New System.Drawing.Point(609, 134)
        Me.Carte4.Name = "Carte4"
        Me.Carte4.Size = New System.Drawing.Size(150, 150)
        Me.Carte4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Carte4.TabIndex = 3
        Me.Carte4.TabStop = False
        Me.Carte4.Valeur = 0
        '
        'Carte3
        '
        Me.Carte3.Location = New System.Drawing.Point(423, 134)
        Me.Carte3.Name = "Carte3"
        Me.Carte3.Size = New System.Drawing.Size(150, 150)
        Me.Carte3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Carte3.TabIndex = 2
        Me.Carte3.TabStop = False
        Me.Carte3.Valeur = 0
        '
        'Carte2
        '
        Me.Carte2.Location = New System.Drawing.Point(231, 134)
        Me.Carte2.Name = "Carte2"
        Me.Carte2.Size = New System.Drawing.Size(150, 150)
        Me.Carte2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Carte2.TabIndex = 1
        Me.Carte2.TabStop = False
        Me.Carte2.Valeur = 0
        '
        'Carte1
        '
        Me.Carte1.Location = New System.Drawing.Point(44, 134)
        Me.Carte1.Name = "Carte1"
        Me.Carte1.Size = New System.Drawing.Size(150, 150)
        Me.Carte1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Carte1.TabIndex = 0
        Me.Carte1.TabStop = False
        Me.Carte1.Valeur = 0
        '
        'Jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1064, 947)
        Me.Controls.Add(Me.HeadGB)
        Me.Controls.Add(Me.CardsGB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Jeu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jeu"
        Me.HeadGB.ResumeLayout(False)
        Me.HeadGB.PerformLayout()
        Me.CardsGB.ResumeLayout(False)
        CType(Me.Carte16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Carte17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Carte18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Carte19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Carte20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Carte11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Carte12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Carte13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Carte14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Carte15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Carte6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Carte7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Carte8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Carte9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Carte10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Carte5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Carte4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Carte3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Carte2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Carte1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HeadGB As GroupBox
    Friend WithEvents PlayerLabel As Label
    Friend WithEvents ForfaitBtn As Button
    Friend WithEvents TimeLabel As Label
    Friend WithEvents GameTimer As Timer
    Friend WithEvents Carte1 As Carte
    Friend WithEvents Carte2 As Carte
    Friend WithEvents Carte3 As Carte
    Friend WithEvents Carte4 As Carte
    Friend WithEvents Carte5 As Carte
    Friend WithEvents Carte10 As Carte
    Friend WithEvents Carte9 As Carte
    Friend WithEvents Carte8 As Carte
    Friend WithEvents Carte7 As Carte
    Friend WithEvents Carte6 As Carte
    Friend WithEvents Carte15 As Carte
    Friend WithEvents Carte14 As Carte
    Friend WithEvents Carte13 As Carte
    Friend WithEvents Carte12 As Carte
    Friend WithEvents Carte11 As Carte
    Friend WithEvents Carte20 As Carte
    Friend WithEvents Carte19 As Carte
    Friend WithEvents Carte18 As Carte
    Friend WithEvents Carte17 As Carte
    Friend WithEvents Carte16 As Carte
    Friend WithEvents CardsGB As GroupBox
End Class
