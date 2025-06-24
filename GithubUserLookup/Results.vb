Public Class frm_Results
    Private Sub Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pb_ProfilePicture.LoadAsync("http://google.com/test.png")
    End Sub
End Class