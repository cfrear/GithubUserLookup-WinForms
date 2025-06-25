Imports Windows.Win32.System

Public Class frm_Results
    Public User As User
    Private Sub Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lb_Username.Text = User.Username
        lb_Location.Text = User.Location
        dgv_Repos.DataSource = User.Repos
        pb_ProfilePicture.LoadAsync(User.PictureUrl)
        dgv_Repos.Columns("Link").Visible = False


        Dim col As New DataGridViewLinkColumn()
        col.DataPropertyName = "Link"
        col.Name = "Link"
        dgv_Repos.Columns.Insert(3, col)


        dgv_Repos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_Repos.AutoResizeColumns()
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        frm_Main.Show()
        Me.Hide()
    End Sub

    Private Sub dgv_Repos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Repos.CellClick
        If e.ColumnIndex = 2 Then
            System.Diagnostics.Process.Start(User.Repos(e.RowIndex).Link)
        End If
    End Sub
End Class