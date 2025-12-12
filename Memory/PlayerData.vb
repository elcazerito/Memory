Module PlayerData
    Dim caracteres As String = "ABCDEFGHIJKLMNO²PQRSTUVWXdefghi°&{}*¤~jklmrstu|vwxyz0123`#@^456nopq78YZabc9!/%§$_-()[]:;,<> "
    Dim id As String = "§!/%$"
    Dim lienLog As String = "src/logs.txt"
    Structure Joueur
        Public nom As String 'Nom servant d'identifiant au joueur
        Public maxCarres As Integer 'Nombre maximum de carres que le joueur a reussi a indentifier
        Public nbParties As Integer 'Nombre de parties jouees
        Public tempsMin As Integer 'Temps minimum au bout duquel le joueur a reussi a indentifier un carre
        Public tempsEcoule As Integer 'Temps de jeu total du joueur
    End Structure

    Public Joueurs As New List(Of Joueur)
    Public Function getIndex() As Integer
        For i As Integer = 0 To Joueurs.Count - 1
            If Joueurs(i).nom = Accueil.NameCB.Text Then
                Return i
            End If
        Next
        Return -1
    End Function
    Public Sub Cryptage()
        Dim lignes As New List(Of String)
        Dim rnd As New Random()
        Dim cle As String = keyGenerator(rnd)

        IO.File.WriteAllText(lienLog, "")
        lignes.Add(keyGenerator(rnd))
        lignes.Add(id.Chars(0) & cle)

        For i As Integer = 0 To Joueurs.Count - 1
            lignes.Add(keyGenerator(rnd))
            Try
                lignes.Add(Crypte(JoueurtoString(i), cle, rnd.Next(1, 5)))
            Catch ex As Exception
            End Try
        Next

        IO.File.AppendAllLines(lienLog, lignes)
    End Sub
    Public Sub Decryptage()
        Dim cle As String = ""
        Dim lignes() As String = IO.File.ReadAllLines(lienLog)

        For Each ligne In lignes
            If ligne.Chars(0) = id.Chars(0) Then
                cle = ligne.Substring(1)
            ElseIf id.Contains(ligne.Chars(0)) And cle <> "" Then
                CompletePlayer(Decrypte(ligne, cle))
            End If
        Next
    End Sub
    Private Sub CompletePlayer(joueur As String)
        Dim savedPlayer As New Joueur()
        Dim i As Integer = 0

        ' Récupération du nom
        Dim j As Integer = i
        Do While joueur.Chars(i) <> " "
            i += 1
        Loop
        savedPlayer.nom = joueur.Substring(j, i - j)
        i += 1

        ' Récupération de maxCarres
        j = i
        Do While joueur.Chars(i) <> " "
            i += 1
        Loop
        savedPlayer.maxCarres = Integer.Parse(joueur.Substring(j, i - j))
        i += 1

        ' Récupération de nbParties
        j = i
        Do While joueur.Chars(i) <> " "
            i += 1
        Loop
        savedPlayer.nbParties = Integer.Parse(joueur.Substring(j, i - j))
        i += 1

        ' Récupération de tempsMin
        j = i
        Do While joueur.Chars(i) <> " "
            i += 1
        Loop
        savedPlayer.tempsMin = Double.Parse(joueur.Substring(j, i - j))
        i += 1

        ' Récupération de tempsEcoule
        j = i
        While i < joueur.Length AndAlso joueur.Chars(i) <> " "
            i += 1
        End While
        savedPlayer.tempsEcoule = Double.Parse(joueur.Substring(j, i - j))

        Joueurs.Add(savedPlayer)
    End Sub
    Private Function JoueurtoString(i As Integer) As String
        Dim result As String
        result = Joueurs(i).nom & " " & Joueurs(i).maxCarres.ToString()
        result &= " " & Joueurs(i).nbParties.ToString() & " " & Joueurs(i).tempsMin.ToString() & " "
        result &= Joueurs(i).tempsEcoule.ToString()
        Return result
    End Function
    Private Function keyGenerator(rnd As Random) As String
        Dim longueur As Integer = rnd.Next(5, 13)
        Dim resultat As String = ""
        Dim premier As Char

        Do
            premier = caracteres(rnd.Next(caracteres.Length))
        Loop While id.Contains(premier)

        resultat &= premier

        For i As Integer = 1 To longueur - 1
            resultat &= caracteres(rnd.Next(caracteres.Length))
        Next

        Return resultat
    End Function
    Private Function Crypte(mot As String, cle As String, index As Integer) As String
        Dim result As String = ""

        If index >= 0 AndAlso index < id.Length Then
            result &= id.Chars(index)
        Else
            result &= "?"
        End If

        For i As Integer = 0 To mot.Length - 1
            Dim val1 As Integer = caracteres.IndexOf(mot.Chars(i))
            If val1 = -1 Then Continue For

            Dim j As Integer = i
            Do While j >= cle.Length
                j -= cle.Length
            Loop

            Dim val2 As Integer = caracteres.IndexOf(cle.Chars(j))
            If val2 = -1 Then Continue For

            Dim somme As Integer = val1 + val2
            Do While somme >= caracteres.Length
                somme -= caracteres.Length
            Loop

            result &= caracteres.Chars(somme)
        Next

        Return result
    End Function
    Private Function Decrypte(mot As String, cle As String) As String
        Dim motNonModifie = mot.Substring(1)
        Dim result As String = ""

        For i As Integer = 0 To motNonModifie.Length - 1
            Dim val1 As Integer = caracteres.IndexOf(motNonModifie.Chars(i))
            If val1 = -1 Then Continue For

            Dim j As Integer = i Mod cle.Length

            Dim val2 As Integer = caracteres.IndexOf(cle.Chars(j))
            If val2 = -1 Then Continue For

            Dim difference As Integer = val1 - val2
            If difference < 0 Then
                difference += caracteres.Length
            End If

            result &= caracteres.Chars(difference)
        Next

        Return result
    End Function
End Module