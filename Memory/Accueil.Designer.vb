<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Accueil
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
        Me.NameCB = New System.Windows.Forms.ComboBox()
        Me.HomeLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.LauchBtn = New System.Windows.Forms.Button()
        Me.ScoreBtn = New System.Windows.Forms.Button()
        Me.LeaveBtn = New System.Windows.Forms.Button()
        Me.OptBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NameCB
        '
        Me.NameCB.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NameCB.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameCB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NameCB.FormattingEnabled = True
        Me.NameCB.Location = New System.Drawing.Point(92, 89)
        Me.NameCB.Name = "NameCB"
        Me.NameCB.Size = New System.Drawing.Size(457, 28)
        Me.NameCB.TabIndex = 0
        '
        'HomeLabel
        '
        Me.HomeLabel.AutoSize = True
        Me.HomeLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.HomeLabel.Location = New System.Drawing.Point(229, 22)
        Me.HomeLabel.Name = "HomeLabel"
        Me.HomeLabel.Size = New System.Drawing.Size(167, 46)
        Me.HomeLabel.TabIndex = 1
        Me.HomeLabel.Text = "Accueil"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Arial Narrow", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NameLabel.Location = New System.Drawing.Point(38, 93)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(46, 20)
        Me.NameLabel.TabIndex = 2
        Me.NameLabel.Text = "Nom :"
        '
        'LauchBtn
        '
        Me.LauchBtn.BackColor = System.Drawing.Color.Red
        Me.LauchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LauchBtn.ForeColor = System.Drawing.Color.White
        Me.LauchBtn.Location = New System.Drawing.Point(27, 138)
        Me.LauchBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.LauchBtn.Name = "LauchBtn"
        Me.LauchBtn.Size = New System.Drawing.Size(173, 34)
        Me.LauchBtn.TabIndex = 3
        Me.LauchBtn.Text = "Lancer la partie"
        Me.LauchBtn.UseVisualStyleBackColor = False
        '
        'ScoreBtn
        '
        Me.ScoreBtn.BackColor = System.Drawing.Color.Red
        Me.ScoreBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreBtn.ForeColor = System.Drawing.Color.White
        Me.ScoreBtn.Location = New System.Drawing.Point(217, 138)
        Me.ScoreBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.ScoreBtn.Name = "ScoreBtn"
        Me.ScoreBtn.Size = New System.Drawing.Size(208, 34)
        Me.ScoreBtn.TabIndex = 4
        Me.ScoreBtn.Text = "Afficher les scores"
        Me.ScoreBtn.UseVisualStyleBackColor = False
        '
        'LeaveBtn
        '
        Me.LeaveBtn.BackColor = System.Drawing.Color.Red
        Me.LeaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LeaveBtn.ForeColor = System.Drawing.Color.White
        Me.LeaveBtn.Location = New System.Drawing.Point(443, 138)
        Me.LeaveBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.LeaveBtn.Name = "LeaveBtn"
        Me.LeaveBtn.Size = New System.Drawing.Size(106, 34)
        Me.LeaveBtn.TabIndex = 5
        Me.LeaveBtn.Text = "Quitter"
        Me.LeaveBtn.UseVisualStyleBackColor = False
        '
        'OptBtn
        '
        Me.OptBtn.BackColor = System.Drawing.Color.Red
        Me.OptBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptBtn.ForeColor = System.Drawing.Color.White
        Me.OptBtn.Location = New System.Drawing.Point(264, 181)
        Me.OptBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.OptBtn.Name = "OptBtn"
        Me.OptBtn.Size = New System.Drawing.Size(122, 34)
        Me.OptBtn.TabIndex = 6
        Me.OptBtn.Text = "Options"
        Me.OptBtn.UseVisualStyleBackColor = False
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(597, 254)
        Me.Controls.Add(Me.OptBtn)
        Me.Controls.Add(Me.LeaveBtn)
        Me.Controls.Add(Me.ScoreBtn)
        Me.Controls.Add(Me.LauchBtn)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.HomeLabel)
        Me.Controls.Add(Me.NameCB)
        Me.Name = "Accueil"
        Me.Text = "Accueil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameCB As ComboBox
    Friend WithEvents HomeLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents LauchBtn As Button
    Friend WithEvents ScoreBtn As Button
    Friend WithEvents LeaveBtn As Button
    Friend WithEvents OptBtn As Button
End Class
