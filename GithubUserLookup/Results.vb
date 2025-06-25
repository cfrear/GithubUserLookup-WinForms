Public Class frm_Results
    Public User As User
    Private Sub Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lb_Username.Text = User.Username
        lb_Location.Text = User.Location


        pb_ProfilePicture.LoadAsync(User.PictureUrl)
    End Sub
End Class