Public Class Reglages
    Public Volume As Integer = 0
    Public Temps As Integer = 60
    Private Sub Reglages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VolumeBtn.Valeur = True
        VolumeBtn.Alterner()
    End Sub
    Private Sub VolumeBtn_Click(sender As Object, e As EventArgs) Handles VolumeBtn.Click
        VolumeBtn.Alterner()
        If VolumeBtn.Valeur Then
            AudioTrBar.Enabled = True
        Else
            AudioTrBar.Enabled = False
        End If
    End Sub
    Private Sub AudioTrBar_Scroll(sender As Object, e As EventArgs) Handles AudioTrBar.Scroll
        If AudioTrBar.Enabled = True Then
            Volume = AudioTrBar.Value
        Else
            Volume = 0
        End If
    End Sub
    Private Sub Settings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim quitter As MsgBoxResult = MsgBox("Êtes-vous sûr de vouloir quitter sans sauvegarder ?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Confirmation")

        If quitter = MsgBoxResult.No Then
            e.Cancel = True
        Else
            Accueil.Show()
        End If
    End Sub
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Temps = TimeSet()
        If Temps > 0 Then
            Hide()
            Accueil.Show()
        End If
    End Sub
    Private Sub CtrlS(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            e.SuppressKeyPress = True
            Temps = TimeSet()
            If Temps > 0 Then
                Hide()
                Accueil.Show()
            End If
        End If
    End Sub
    Private Sub TimeTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TimeTB.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(8) Then
            e.Handled = True
        End If
    End Sub
    Private Sub RBtn_CheckedChanged(sender As Object, e As EventArgs) Handles RBtnOther.CheckedChanged
        If RBtnOther.Checked = True Then
            TimeTB.Enabled = True
            TimeTB.Visible = True
            secLabel.Visible = True
        Else
            TimeTB.Enabled = False
            TimeTB.Visible = False
            secLabel.Visible = False
        End If
    End Sub
    Private Function TimeSet() As Integer
        If RBtn15.Checked = True Then
            Return 15
        ElseIf RBtn30.Checked = True Then
            Return 30
        ElseIf RBtn45.Checked = True Then
            Return 45
        ElseIf RBtn60.Checked = True Then
            Return 60
        ElseIf RBtnOther.Checked = True And (TimeTB.Text.Length < 1 Or TimeTB.Text = "0") Then
            MsgBox("Veuillez définir une durée valide !")
            Return -1
        Else
            Return TimeTB.Text
        End If
    End Function
End Class