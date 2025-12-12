Public Class Volume
    Inherits PictureBox

    Private OnImage As Image = My.Resources.volume_on
    Private offImage As Image = My.Resources.volume_off
    Private Actif As Boolean

    Public Property Valeur As Boolean
        Set(value As Boolean)
            Actif = value
        End Set
        Get
            Return Actif
        End Get
    End Property
    Private Sub AfficherOn()
        Image = OnImage
    End Sub
    Private Sub AfficherOff()
        Image = offImage
    End Sub
    Public Sub Alterner()
        If Actif Then
            AfficherOff()
            Actif = False
        Else
            AfficherOn()
            Actif = True
        End If
        Refresh()
    End Sub
End Class
