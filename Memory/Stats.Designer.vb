<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Stats
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
        Me.NameLB = New System.Windows.Forms.ListBox()
        Me.StatLabel = New System.Windows.Forms.Label()
        Me.MaxCarreLB = New System.Windows.Forms.ListBox()
        Me.NbPartiesLB = New System.Windows.Forms.ListBox()
        Me.MinTimeLB = New System.Windows.Forms.ListBox()
        Me.PastTimeLB = New System.Windows.Forms.ListBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.MaxCarreLabel = New System.Windows.Forms.Label()
        Me.NbPartiesLabel = New System.Windows.Forms.Label()
        Me.MinTimeLabel = New System.Windows.Forms.Label()
        Me.TotTempsLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'NameLB
        '
        Me.NameLB.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NameLB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NameLB.FormattingEnabled = True
        Me.NameLB.ItemHeight = 20
        Me.NameLB.Location = New System.Drawing.Point(33, 107)
        Me.NameLB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NameLB.Name = "NameLB"
        Me.NameLB.Size = New System.Drawing.Size(128, 24)
        Me.NameLB.TabIndex = 0
        '
        'StatLabel
        '
        Me.StatLabel.AutoSize = True
        Me.StatLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.0!)
        Me.StatLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.StatLabel.Location = New System.Drawing.Point(316, 17)
        Me.StatLabel.Name = "StatLabel"
        Me.StatLabel.Size = New System.Drawing.Size(252, 46)
        Me.StatLabel.TabIndex = 2
        Me.StatLabel.Text = "Statistiques"
        '
        'MaxCarreLB
        '
        Me.MaxCarreLB.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaxCarreLB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MaxCarreLB.FormattingEnabled = True
        Me.MaxCarreLB.ItemHeight = 20
        Me.MaxCarreLB.Location = New System.Drawing.Point(206, 107)
        Me.MaxCarreLB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaxCarreLB.Name = "MaxCarreLB"
        Me.MaxCarreLB.Size = New System.Drawing.Size(128, 24)
        Me.MaxCarreLB.TabIndex = 3
        '
        'NbPartiesLB
        '
        Me.NbPartiesLB.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NbPartiesLB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NbPartiesLB.FormattingEnabled = True
        Me.NbPartiesLB.ItemHeight = 20
        Me.NbPartiesLB.Location = New System.Drawing.Point(372, 107)
        Me.NbPartiesLB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NbPartiesLB.Name = "NbPartiesLB"
        Me.NbPartiesLB.Size = New System.Drawing.Size(128, 24)
        Me.NbPartiesLB.TabIndex = 4
        '
        'MinTimeLB
        '
        Me.MinTimeLB.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MinTimeLB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MinTimeLB.FormattingEnabled = True
        Me.MinTimeLB.ItemHeight = 20
        Me.MinTimeLB.Location = New System.Drawing.Point(532, 107)
        Me.MinTimeLB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinTimeLB.Name = "MinTimeLB"
        Me.MinTimeLB.Size = New System.Drawing.Size(128, 24)
        Me.MinTimeLB.TabIndex = 5
        '
        'PastTimeLB
        '
        Me.PastTimeLB.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PastTimeLB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PastTimeLB.FormattingEnabled = True
        Me.PastTimeLB.ItemHeight = 20
        Me.PastTimeLB.Location = New System.Drawing.Point(693, 107)
        Me.PastTimeLB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PastTimeLB.Name = "PastTimeLB"
        Me.PastTimeLB.Size = New System.Drawing.Size(128, 24)
        Me.PastTimeLB.TabIndex = 6
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.NameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NameLabel.Location = New System.Drawing.Point(69, 83)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(45, 19)
        Me.NameLabel.TabIndex = 7
        Me.NameLabel.Text = "Nom"
        '
        'MaxCarreLabel
        '
        Me.MaxCarreLabel.AutoSize = True
        Me.MaxCarreLabel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.MaxCarreLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MaxCarreLabel.Location = New System.Drawing.Point(206, 83)
        Me.MaxCarreLabel.Name = "MaxCarreLabel"
        Me.MaxCarreLabel.Size = New System.Drawing.Size(128, 19)
        Me.MaxCarreLabel.TabIndex = 8
        Me.MaxCarreLabel.Text = "Max carrés déc "
        '
        'NbPartiesLabel
        '
        Me.NbPartiesLabel.AutoSize = True
        Me.NbPartiesLabel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.NbPartiesLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NbPartiesLabel.Location = New System.Drawing.Point(359, 83)
        Me.NbPartiesLabel.Name = "NbPartiesLabel"
        Me.NbPartiesLabel.Size = New System.Drawing.Size(152, 19)
        Me.NbPartiesLabel.TabIndex = 9
        Me.NbPartiesLabel.Text = "Nbr parties jouées "
        '
        'MinTimeLabel
        '
        Me.MinTimeLabel.AutoSize = True
        Me.MinTimeLabel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.MinTimeLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MinTimeLabel.Location = New System.Drawing.Point(528, 83)
        Me.MinTimeLabel.Name = "MinTimeLabel"
        Me.MinTimeLabel.Size = New System.Drawing.Size(139, 19)
        Me.MinTimeLabel.TabIndex = 10
        Me.MinTimeLabel.Text = "Record de temps"
        '
        'TotTempsLabel
        '
        Me.TotTempsLabel.AutoSize = True
        Me.TotTempsLabel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.TotTempsLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TotTempsLabel.Location = New System.Drawing.Point(689, 83)
        Me.TotTempsLabel.Name = "TotTempsLabel"
        Me.TotTempsLabel.Size = New System.Drawing.Size(147, 19)
        Me.TotTempsLabel.TabIndex = 11
        Me.TotTempsLabel.Text = "Total temps passé"
        '
        'Stats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(871, 147)
        Me.Controls.Add(Me.TotTempsLabel)
        Me.Controls.Add(Me.MinTimeLabel)
        Me.Controls.Add(Me.NbPartiesLabel)
        Me.Controls.Add(Me.MaxCarreLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.PastTimeLB)
        Me.Controls.Add(Me.MinTimeLB)
        Me.Controls.Add(Me.NbPartiesLB)
        Me.Controls.Add(Me.MaxCarreLB)
        Me.Controls.Add(Me.StatLabel)
        Me.Controls.Add(Me.NameLB)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Stats"
        Me.Text = "Statistiques"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameLB As ListBox
    Friend WithEvents StatLabel As Label
    Friend WithEvents MaxCarreLB As ListBox
    Friend WithEvents NbPartiesLB As ListBox
    Friend WithEvents MinTimeLB As ListBox
    Friend WithEvents PastTimeLB As ListBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents MaxCarreLabel As Label
    Friend WithEvents NbPartiesLabel As Label
    Friend WithEvents MinTimeLabel As Label
    Friend WithEvents TotTempsLabel As Label
End Class
