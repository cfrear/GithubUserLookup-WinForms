Public Class frm_Results
    Public User As User
    Private Sub Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lb_Username.Text = User.Username
        lb_Location.Text = User.Location
        dgv_Repos.DataSource = User.Repos
        pb_ProfilePicture.LoadAsync(User.PictureUrl)

        dgv_Repos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_Repos.AutoResizeColumns()
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        frm_Main.Show()
        Me.Hide()
    End Sub
End Class