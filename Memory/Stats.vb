Public Class Stats
    Private Sub Stats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StatsAutoSize()
        For Each Player In Joueurs
            NameLB.Items.Add(Player.nom.ToString())
            MaxCarreLB.Items.Add(Player.maxCarres.ToString())
            NbPartiesLB.Items.Add(Player.nbParties.ToString())
            MinTimeLB.Items.Add(Player.tempsMin.ToString())
            PastTimeLB.Items.Add(Player.tempsEcoule.ToString())
        Next
    End Sub
    Private Sub NameLB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NameLB.SelectedIndexChanged
        If NameLB.SelectedIndex >= 0 And NameLB.SelectedIndex < NameLB.Items.Count Then
            MaxCarreLB.SelectedIndex = NameLB.SelectedIndex
            NbPartiesLB.SelectedIndex = NameLB.SelectedIndex
            MinTimeLB.SelectedIndex = NameLB.SelectedIndex
            PastTimeLB.SelectedIndex = NameLB.SelectedIndex
        End If
    End Sub
    Private Sub MaxCarreLB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MaxCarreLB.SelectedIndexChanged
        If MaxCarreLB.SelectedIndex >= 0 And MaxCarreLB.SelectedIndex < MaxCarreLB.Items.Count Then
            NameLB.SelectedIndex = MaxCarreLB.SelectedIndex
            NbPartiesLB.SelectedIndex = MaxCarreLB.SelectedIndex
            MinTimeLB.SelectedIndex = MaxCarreLB.SelectedIndex
            PastTimeLB.SelectedIndex = MaxCarreLB.SelectedIndex
        End If
    End Sub
    Private Sub NbPartiesLB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NbPartiesLB.SelectedIndexChanged
        If NbPartiesLB.SelectedIndex >= 0 And NbPartiesLB.SelectedIndex < NbPartiesLB.Items.Count Then
            NameLB.SelectedIndex = NbPartiesLB.SelectedIndex
            MaxCarreLB.SelectedIndex = NbPartiesLB.SelectedIndex
            MinTimeLB.SelectedIndex = NbPartiesLB.SelectedIndex
            PastTimeLB.SelectedIndex = NbPartiesLB.SelectedIndex
        End If
    End Sub
    Private Sub MinTimeLB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MinTimeLB.SelectedIndexChanged
        If MinTimeLB.SelectedIndex >= 0 And MinTimeLB.SelectedIndex < MinTimeLB.Items.Count Then
            NameLB.SelectedIndex = MinTimeLB.SelectedIndex
            MaxCarreLB.SelectedIndex = MinTimeLB.SelectedIndex
            NbPartiesLB.SelectedIndex = MinTimeLB.SelectedIndex
            PastTimeLB.SelectedIndex = MinTimeLB.SelectedIndex
        End If
    End Sub
    Private Sub PastTimeLB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PastTimeLB.SelectedIndexChanged
        If PastTimeLB.SelectedIndex >= 0 And PastTimeLB.SelectedIndex < PastTimeLB.Items.Count Then
            NameLB.SelectedIndex = PastTimeLB.SelectedIndex
            MaxCarreLB.SelectedIndex = PastTimeLB.SelectedIndex
            NbPartiesLB.SelectedIndex = PastTimeLB.SelectedIndex
            MinTimeLB.SelectedIndex = PastTimeLB.SelectedIndex
        End If
    End Sub
    Private Sub Stats_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Accueil.Show()
    End Sub
    Private Sub StatsAutoSize()
        Dim hauteur As Integer = 4 + (Joueurs.Count) * 20
        If Joueurs.Count > 2 Then
            hauteur -= 20
        End If
        NameLB.Height = hauteur
        MaxCarreLB.Height = hauteur
        NbPartiesLB.Height = hauteur
        MinTimeLB.Height = hauteur
        PastTimeLB.Height = hauteur
        Height = 203 + (Joueurs.Count - 1) * 20
    End Sub
End Class