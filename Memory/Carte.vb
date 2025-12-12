Public Class Carte
    Inherits PictureBox

    Private front As Image
    Private back As Image = My.Resources.Back
    Dim CardName As String
    Private isFaceVisible As Boolean = False
    Private estRetournable As Boolean = True
    Private val As Integer

    Public Property Valeur As Integer
        Set(value As Integer)
            Select Case value
                Case 0
                    front = My.Resources._06_BOULS
                    CardName = "_06_BOULS"
                Case 1
                    front = My.Resources._08_BOULS
                    CardName = "_08_BOULS"
                Case 2
                    front = My.Resources._21_BOULS
                    CardName = "_21_BOULS"
                Case 3
                    front = My.Resources._23_BOULS
                    CardName = "_23_BOULS"
                Case 4
                    front = My.Resources._25_BOULS
                    CardName = "_25_BOULS"
            End Select
            val = value
        End Set
        Get
            Return val
        End Get
    End Property
    Public Sub AfficherDos()
        Image = back
        isFaceVisible = False
    End Sub
    Private Sub AfficherFace()
        Image = front
        isFaceVisible = True
    End Sub
    Public Function estVisible()
        Return isFaceVisible
    End Function
    Public Sub Retourner()
        If estRetournable = True Then
            If isFaceVisible = True Then
                AfficherDos()
            Else
                AfficherFace()
            End If
        End If
    End Sub
    Public Sub Griser()
        estRetournable = False
        Dim greyName As String = CardName & "_Grey"
        Dim greyImg As Image = CType(My.Resources.ResourceManager.GetObject(greyName), Image)

        If greyImg IsNot Nothing Then
            Image = greyImg
        Else
            Image = front
        End If
        Me.Refresh()
    End Sub

End Class
