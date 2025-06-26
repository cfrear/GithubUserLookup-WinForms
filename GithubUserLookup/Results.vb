Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Windows.Win32.System

Public Class frm_Results
    Public User As User
    Public NumberOfRepos As Integer
    Private Sub Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lb_TopRepos.Text = "Top " & NumberOfRepos & " Repos:"
        lb_Username.Text = User.Username
        lb_Location.Text = User.Location
        lb_Bio.Text = User.Bio
        dgv_Repos.DataSource = User.Repos
        pb_ProfilePicture.LoadAsync(User.PictureUrl)

        'Hide existing "Name" and "Link" columns, and add new LinkColumn version to show text as hyperlink
        dgv_Repos.Columns("Name").Visible = False
        dgv_Repos.Columns("Link").Visible = False
        Dim col As New DataGridViewLinkColumn()
        col.DataPropertyName = "Name"
        col.Name = "Name"
        dgv_Repos.Columns.Insert(1, col)

        dgv_Repos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_Repos.AutoResizeColumns()
        'dgv_Repos.Columns(4).DefaultCellStyle.WrapMode = DataGridViewTriState.True

    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        frm_Main.Show()
        Me.Hide()
    End Sub

    Private Sub dgv_Repos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Repos.CellContentClick
        If e.ColumnIndex = 1 Then
            Dim process As New Process()
            process.StartInfo.UseShellExecute = True
            process.StartInfo.FileName = "chrome"
            process.StartInfo.Arguments = User.Repos(e.RowIndex).Link
            process.Start()
        End If
    End Sub

    Private Sub btn_Export_Click(sender As Object, e As EventArgs) Handles btn_Export.Click

        Dim oExcel As Object
        Dim oBook As Object
        Dim oSheet As Object

        'Start a new workbook in Excel    
        oExcel = CreateObject("Excel.Application")
        oBook = oExcel.Workbooks.Add

        'Add data to cells of the first worksheet in the new workbook    
        oSheet = oBook.Worksheets(1)
        oSheet.Range("A1").Value = "Last Name"
        oSheet.Range("B1").Value = "First Name"
        oSheet.Range("A1:B1").Font.Bold = True
        oSheet.Range("A2").Value = "Doe"
        oSheet.Range("B2").Value = "John"

        Dim resourcesFolder = IO.Path.GetFullPath(Application.StartupPath & "\..\..\..\Resources\")
        Dim fileName = User.Username & "-" & DateTime.Now.ToString("yyyyMMddTHHmmss")

        'Save the Workbook and Quit Excel    
        oBook.SaveAs(resourcesFolder & fileName)
        MsgBox("File exported to: " & resourcesFolder & fileName)
        oExcel.Quit
    End Sub
End Class