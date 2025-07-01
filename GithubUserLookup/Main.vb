Imports System.Buffers.Text
Imports System.IO
Imports System.Net
Imports System.Net.Cache
Imports System.Net.Http

Public Class frm_Main
    Dim SearchHistoryPath As String = IO.Path.GetFullPath(Application.StartupPath & "\..\..\..\Resources\") & "searchhistory.txt"

    Public Sub btn_Search_Click() Handles btn_Search.Click

        If tb_Username.Text Is Nothing Or tb_Username.Text = "" Then
            Exit Sub
        End If

        'Get user from username
        Dim user As New User()
        user = GetUser().Result

        If user Is Nothing Then
            Exit Sub
        End If

        'Get repos from url returned in user result
        Dim repos As New List(Of Repo)
        repos = GetRepos(user.ReposUrl).Result

        If repos IsNot Nothing Or repos.Count > 1 Then
            'Sort and count repos
            Dim sortedRepos As List(Of Repo)
            If rb_Stargazers.Checked Then
                sortedRepos = repos.OrderByDescending(Function(x As Repo) x.StargazersCount).ToList()
            ElseIf rb_Name.Checked Then
                sortedRepos = repos.OrderBy(Function(x As Repo) x.Name).ToList()
            End If

            Dim reposToList As Integer = Math.Min(sortedRepos.Count, nud_NumberOfRepos.Value)
            For i = 0 To reposToList - 1
                user.Repos.Add(sortedRepos(i))
            Next

            AddToSearchHistory()
            ReadSearchHistory()

            Dim Results As New frm_Results
            Results.User = user
            Results.NumberOfRepos = nud_NumberOfRepos.Value
            Results.Show()
            Me.Hide()
        End If
    End Sub

    Public Async Function GetUser() As Task(Of User)
        Dim apiUrl As String = "https://api.github.com/users/"
        Dim user As New User

        Using client As New HttpClient()
            client.BaseAddress = New Uri(apiUrl)
            client.DefaultRequestHeaders.Accept.Clear()
            client.DefaultRequestHeaders.Accept.Add(New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/vnd.github+json"))
            client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "http://developer.github.com/v3/#user-agent-required")

            Dim response As HttpResponseMessage
            response = client.GetAsync(tb_Username.Text).Result

            If response.IsSuccessStatusCode Then
                Dim data As String = Await response.Content.ReadAsStringAsync()
                user = Newtonsoft.Json.JsonConvert.DeserializeObject(Of User)(data)
                Return user
            Else
                Return Nothing
            End If
        End Using
    End Function

    Public Async Function GetRepos(repoUrl As String) As Task(Of List(Of Repo))

        Using client As New HttpClient()
            client.BaseAddress = New Uri(repoUrl & "?per_page=100")
            client.DefaultRequestHeaders.Accept.Clear()
            client.DefaultRequestHeaders.Accept.Add(New System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/vnd.github+json"))
            client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "http://developer.github.com/v3/#user-agent-required")

            Dim response As HttpResponseMessage
            response = client.GetAsync("").Result

            If response.IsSuccessStatusCode Then
                Dim data As String = Await response.Content.ReadAsStringAsync()
                Dim repos As New List(Of Repo)

                repos = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of Repo))(data)
                Return repos
            Else
                Return Nothing
            End If
        End Using
    End Function

    Private Sub tb_Username_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_Username.KeyUp
        If e.KeyCode = Keys.Enter Then
            btn_Search.PerformClick()
        End If
    End Sub

    Private Sub AddToSearchHistory()

        If File.Exists(SearchHistoryPath) = False Then
            'Create a file to write to.
            Using sw As StreamWriter = File.CreateText(SearchHistoryPath)
                sw.WriteLine(tb_Username.Text)
            End Using
        Else
            'Write to existing file
            File.AppendAllText(SearchHistoryPath, tb_Username.Text & Environment.NewLine)
        End If
    End Sub

    Private Sub ReadSearchHistory()
        Dim history As New AutoCompleteStringCollection

        Using sr As StreamReader = New StreamReader(SearchHistoryPath)
            Dim line As String = sr.ReadLine()
            Do While Not line = Nothing
                history.Add(line)
                line = sr.ReadLine()
            Loop
        End Using

        tb_Username.AutoCompleteCustomSource = history
    End Sub

    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists(SearchHistoryPath) Then
            ReadSearchHistory()
        End If
    End Sub
End Class
