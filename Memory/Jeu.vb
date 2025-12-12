Imports System.Drawing.Text
Imports System.Threading
Imports WMPLib

Public Class Jeu
    Dim TempsSelectionne As Integer
    Dim Temps As Integer
    Dim nbCartes As Integer
    Dim nbPaire As Integer
    Dim lignes As Integer = 4
    Dim colonnes As Integer = 5
    Dim nbModCarte As Integer = 5
    Dim CartesDecouvertes As New List(Of Carte)
    Private lecteur As New WindowsMediaPlayer
    Private Sub RepartirHorizontalement(GB As GroupBox)
        Dim nbControles As Integer = GB.Controls.Count
        If nbControles = 0 Then Exit Sub

        Dim espaceDisponible As Integer = GB.Width
        Dim largeurControle As Integer = GB.Controls(0).Width
        Dim marge As Integer = (espaceDisponible - (largeurControle * nbControles)) \ (nbControles + 1)

        For i As Integer = 0 To nbControles - 1
            Dim ctrl As Control = GB.Controls(i)
            ctrl.Left = marge * (i + 1) + largeurControle * i
            ctrl.Top = (GB.Height - ctrl.Height) \ 2
        Next
    End Sub
    Private Sub RepartirEnGrille(GB As GroupBox)
        Dim total As Integer = lignes * colonnes
        Dim nbControles As Integer = GB.Controls.Count
        If nbControles = 0 Then Exit Sub

        Dim largeurDisponible As Integer = GB.Width
        Dim hauteurDisponible As Integer = GB.Height

        Dim margeH As Integer = 5
        Dim margeV As Integer = 5

        Dim caseLargeur As Integer = (largeurDisponible - margeH * (colonnes + 1)) \ colonnes
        Dim caseHauteur As Integer = (hauteurDisponible - margeV * (lignes + 1)) \ lignes

        For i As Integer = 0 To nbControles - 1
            Dim ctrl As Control = GB.Controls(i)
            Dim ligne As Integer = i \ colonnes
            Dim colonne As Integer = i Mod colonnes

            Dim x As Integer = margeH + colonne * (caseLargeur + margeH)
            Dim y As Integer = margeV + ligne * (caseHauteur + margeV)

            ctrl.Left = x
            ctrl.Top = y
            ctrl.Width = caseLargeur
            ctrl.Height = caseHauteur
        Next
    End Sub
    Private Sub Melanger(GB As GroupBox)
        Dim cartes As List(Of Carte) = GB.Controls.OfType(Of Carte)().ToList()

        Dim totalCartes As Integer = cartes.Count
        If totalCartes = 0 Then Exit Sub

        Dim valeurs As New List(Of Integer)

        Dim repeteParValeur As Integer = totalCartes \ nbModCarte
        nbCartes = repeteParValeur
        Dim reste As Integer = totalCartes Mod nbModCarte

        For i As Integer = 0 To nbModCarte - 1
            For j As Integer = 1 To repeteParValeur
                valeurs.Add(i)
            Next
        Next

        Dim rnd As New Random()
        For i As Integer = 1 To reste
            valeurs.Add(rnd.Next(0, nbModCarte))
        Next

        valeurs = valeurs.OrderBy(Function() rnd.Next()).ToList()

        For i As Integer = 0 To cartes.Count - 1
            cartes(i).Valeur = valeurs(i)
        Next
    End Sub
    Private Sub AfficherDosCartes(GB As GroupBox)
        For Each card As Carte In GB.Controls
            card.AfficherDos()
        Next
    End Sub
    Private Sub CompareCartesDecouvertes()
        If CartesDecouvertes.Count > 1 Then
            For i As Integer = 1 To CartesDecouvertes.Count - 1
                If CartesDecouvertes(i).Valeur <> CartesDecouvertes(i - 1).Valeur Then
                    Refresh()
                    Thread.Sleep(1000)
                    For Each Carte In CartesDecouvertes
                        Carte.Retourner()
                    Next
                    CartesDecouvertes.Clear()
                End If
            Next
            If CartesDecouvertes.Count = nbCartes Then
                nbPaire += 1
                For Each Carte In CartesDecouvertes
                    Carte.Griser()
                Next
                lecteur.settings.volume = 75
                lecteur.controls.play()
            End If
        End If
    End Sub
    Private Sub Jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TempsSelectionne = Reglages.Temps
        Temps = TempsSelectionne
        PlayerLabel.Text = "Joueur : " + Accueil.NameCB.Text
        TimeLabel.Text = "Temps : " + Temps.ToString()
        nbPaire = 0
        RepartirHorizontalement(HeadGB)
        RepartirEnGrille(CardsGB)
        AfficherDosCartes(CardsGB)
        Melanger(CardsGB)
        lecteur.URL = "src/roucoulement.mp3"
        For Each carte As Carte In CardsGB.Controls.OfType(Of Carte)()
            AddHandler carte.Click, AddressOf Carte_Click
        Next
        getIndex()
    End Sub
    Private Sub Carte_Click(sender As Object, e As EventArgs)
        Dim carteCliquee As Carte = CType(sender, Carte)
        If Temps > 0 And carteCliquee.estVisible = False Then
            carteCliquee.Retourner()
            CartesDecouvertes.Add(carteCliquee)
            CompareCartesDecouvertes()
        End If
        If GameTimer.Enabled = False And Temps > 0 Then
            GameTimer.Enabled = True
        End If
        If VerificationVictoire(CardsGB) Then
            Accueil.Show()
            Dispose()
        End If
        lecteur.settings.volume = Reglages.Volume
    End Sub
    Private Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles GameTimer.Tick
        Temps -= 1
        TimeLabel.Text = "Temps : " + Temps.ToString
        If Temps = 0 Then
            GameTimer.Enabled = False
            MsgBox("Temps écoulé")
        End If
    End Sub
    Private Sub ForfaitBtn_Click(sender As Object, e As EventArgs) Handles ForfaitBtn.Click
        Accueil.Show()
        Dispose()
    End Sub
    Private Sub DataComplete(Abandon As Boolean)
        Dim i As Integer = getIndex()
        Dim j As Joueur = Joueurs(i)
        If Joueurs(i).nom = Accueil.NameCB.Text Then
            If Joueurs(i).maxCarres < nbPaire Then
                j.maxCarres = nbPaire
            End If
            If Abandon = False Then
                If Joueurs(i).tempsMin = 0 Or TempsSelectionne - Temps < Joueurs(i).tempsMin Then
                    j.tempsMin = TempsSelectionne - Temps
                End If
            End If
            j.nbParties = Joueurs(i).nbParties + 1
            j.tempsEcoule = Joueurs(i).tempsEcoule + TempsSelectionne - Temps
        End If
        Joueurs(i) = j
    End Sub
    Private Sub JeuDispose() Handles Me.Disposed
        DataComplete(True)
        Accueil.Show()
    End Sub
    Private Function VerificationVictoire(GB As GroupBox) As Boolean
        Return (nbModCarte * (nbPaire - 1) = lignes * colonnes)
    End Function
End Class