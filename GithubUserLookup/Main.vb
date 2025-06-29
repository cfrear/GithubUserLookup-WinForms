﻿Imports System.IO
Imports System.Net.Cache
Imports System.Net.Http

Public Class frm_Main

    Public Sub btn_Search_Click() Handles btn_Search.Click

        'Get user from username
        Dim user As New User()
        user = GetUser().Result

        'Get repos from url returned in user result
        Dim repos As New List(Of Repo)
        repos = GetRepos(user.ReposUrl).Result

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

        Dim Results As New frm_Results
        Results.User = user
        Results.NumberOfRepos = nud_NumberOfRepos.Value
        Results.Show()
        Me.Hide()
    End Sub

    Public Async Function GetUser() As Task(Of User)
        Dim apiUrl As String = "https://api.github.com/users/"
        Dim user As New User

        Dim client As New HttpClient()
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

        client.Dispose()
    End Function

    Public Async Function GetRepos(repoUrl As String) As Task(Of List(Of Repo))

        Dim client As New HttpClient()
        client.BaseAddress = New Uri(repoUrl)
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

        client.Dispose()
    End Function

    Private Sub tb_Username_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_Username.KeyUp
        If e.KeyCode = Keys.Enter Then
            btn_Search.PerformClick()
        End If
    End Sub

    Private Sub AddToSearchHistory()
        Dim path As String = IO.Path.GetFullPath(Application.StartupPath & "\..\..\..\Resources\") & "searchhistory.txt"
        If File.Exists(path) = False Then
            'Create a file to write to.
            Using sw As StreamWriter = File.CreateText(path)
                sw.WriteLine(tb_Username.Text)
            End Using
        Else
            'Write to existing file
            File.AppendAllText(path, tb_Username.Text & Environment.NewLine)
        End If

        Using sr As StreamReader = New StreamReader(path)
            sr.
        End Using
        Dim history As New AutoCompleteStringCollection
        history =
        tb_Username.AutoCompleteCustomSource =

    End Sub
End Class
