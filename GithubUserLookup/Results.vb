Imports System.IO
Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Windows.Win32.System

Public Class frm_Results
    Public User As User
    Public NumberOfRepos As Integer
    Private Sub Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If NumberOfRepos > 0 Then
            lb_TopRepos.Text = "Top " & NumberOfRepos & " Repos:"
        Else
            lb_TopRepos.Text = "No Repos Found"
        End If

        lb_Username.Text = User.Username
        lb_Location.Text = User.Location
        lb_Bio.Text = User.Bio
        pb_ProfilePicture.LoadAsync(User.PictureUrl)

        If User.Repos IsNot Nothing And User.Repos.Count > 0 Then
            dgv_Repos.DataSource = User.Repos
        End If

        'Hide existing "Name" and "Link" columns, and add new LinkColumn version to show text as hyperlink
        dgv_Repos.Columns("Name").Visible = False
        dgv_Repos.Columns("Link").Visible = False
        Dim col As New DataGridViewLinkColumn()
        col.DataPropertyName = "Name"
        col.Name = "Name"
        dgv_Repos.Columns.Insert(1, col)

        dgv_Repos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv_Repos.AutoResizeColumns()

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

        'Add user data  
        oSheet = oBook.Worksheets(1)
        oSheet.Range("A1").Value = "Github User Lookup"
        oSheet.Range("A2").Value = User.Username
        oSheet.Range("A3").Value = User.Location
        oSheet.Range("A5").Value = "Repos:"

        'Add repo data
        oSheet.Range("B6").Value = "Name"
        oSheet.Range("C6").Value = "Description"
        oSheet.Range("D6").Value = "Stargazers"
        For i = 0 To User.Repos.Count - 1
            'Add link to repo on name cell
            oSheet.Hyperlinks.Add(oSheet.Range("B" & 7 + i), User.Repos(i).Link, "", "", User.Repos(i).Name)
            oSheet.Range("C" & 7 + i).Value = User.Repos(i).Description
            oSheet.Range("D" & 7 + i).Value = User.Repos(i).StargazersCount
        Next

        'Add Image
        'Dim webClient As New WebClient
        'Dim imageData As Byte() = webClient.DownloadData(User.PictureUrl)
        'Dim objImage As New MemoryStream(imageData)
        'Dim image As Image = Image.FromStream(objImage)
        'oSheet.Pictures.Add(image)

        'Formatting
        oSheet.Range("A1:E1").EntireColumn.AutoFit
        oSheet.Range("C6").ColumnWidth = 100
        oSheet.Range("A1, A5, B6:E6").Font.Bold = True

        Dim resourcesFolder = IO.Path.GetFullPath(Application.StartupPath & "\..\..\..\Resources\")
        Dim fileName = User.Username & "-" & DateTime.Now.ToString("yyyyMMddTHHmmss")

        'Save the Workbook and Quit Excel    
        oBook.SaveAs(resourcesFolder & fileName)
        MsgBox("File exported to: " & resourcesFolder & fileName)
        oExcel.Quit
    End Sub
End Class