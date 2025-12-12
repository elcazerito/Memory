Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Accueil
    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Decryptage()
        If Joueurs.Count > 0 Then
            For Each Player In Joueurs
                NameCB.Items.Add(Player.nom)
            Next
        End If
    End Sub
    Private Sub LeaveBtn_Click(sender As Object, e As EventArgs) Handles LeaveBtn.Click
        Dim Confirm_Exit As MsgBoxResult
        Confirm_Exit = MsgBox("Etes-vous sûr de vouloir partir ?", vbYesNo)
        If Confirm_Exit = vbYes Then
            Close()
        End If
    End Sub
    Private Sub LauchBtn_Click(sender As Object, e As EventArgs) Handles LauchBtn.Click
        If NameCB.Text.Length < 3 Then
            MsgBox("Votre nom doit faire au moins 3 caractères pour démarrer la partie !")
        Else
            Dim nomRecherche As String = NameCB.Text.Normalize()
            Dim existe As Boolean = Joueurs.Any(Function(j) j.nom.Normalize() = nomRecherche)

            If Not existe Then
                Dim Player As New Joueur()
                Player.nom = nomRecherche
                Joueurs.Add(Player)
            End If

            Jeu.Show()
            Hide()
        End If
        If Joueurs.Count > 0 Then
            NameCB.Items.Clear()
            For Each Player In Joueurs
                NameCB.Items.Add(Player.nom)
            Next
        End If
    End Sub
    Private Sub ScoreBtn_Click(sender As Object, e As EventArgs) Handles ScoreBtn.Click
        Stats.Show()
        Hide()
    End Sub
    Private Sub OptBtn_Click(sender As Object, e As EventArgs) Handles OptBtn.Click
        Hide()
        Reglages.Show()
    End Sub
    Private Sub NameCB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NameCB.KeyPress
        If e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub
    Private Sub Accueil_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Cryptage()
        Catch ex As Exception
            MessageBox.Show("Erreur dans FormClosing : " & ex.Message)
        End Try
    End Sub
End Class
