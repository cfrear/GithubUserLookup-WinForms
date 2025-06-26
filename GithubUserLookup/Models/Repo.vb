Imports Newtonsoft.Json

Public Class Repo

    <JsonProperty(PropertyName:="id")>
    Public Property Id As Integer

    <JsonProperty(PropertyName:="name")>
    Public Property Name As String

    <JsonProperty(PropertyName:="html_url")>
    Public Property Link As String

    <JsonProperty(PropertyName:="description")>
    Public Property Description As String

    <JsonProperty(PropertyName:="stargazers_count")>
    Public Property StargazersCount As Integer
End Class
