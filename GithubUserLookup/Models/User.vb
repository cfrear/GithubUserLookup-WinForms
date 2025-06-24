Public Class User
    Public Property Id As Integer
    Public Property Username As String
    Public Property Location As String
    Public Property PictureUrl As String
    Public Property ReposUrl As String
    Public Property Repos As List(Of Repo)
End Class
