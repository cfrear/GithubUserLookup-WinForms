Imports Newtonsoft.Json

Public Class User
    <JsonProperty(PropertyName:="id")>
    Public Property Id As Integer

    <JsonProperty(PropertyName:="login")>
    Public Property Username As String

    <JsonProperty(PropertyName:="location")>
    Public Property Location As String

    <JsonProperty(PropertyName:="avatar_url")>
    Public Property PictureUrl As String

    <JsonProperty(PropertyName:="repos_url")>
    Public Property ReposUrl As String

    Public Property Repos As New List(Of Repo)
End Class
