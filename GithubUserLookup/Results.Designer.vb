<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Results
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Results))
        lb_Username = New Label()
        lb_Location = New Label()
        pb_ProfilePicture = New PictureBox()
        dgv_Repos = New DataGridView()
        btn_Back = New Button()
        lb_TopRepos = New Label()
        lb_Bio = New Label()
        CType(pb_ProfilePicture, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgv_Repos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lb_Username
        ' 
        lb_Username.AutoSize = True
        lb_Username.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lb_Username.Location = New Point(154, 9)
        lb_Username.Name = "lb_Username"
        lb_Username.Size = New Size(126, 25)
        lb_Username.TabIndex = 0
        lb_Username.Text = "lb_Username"
        ' 
        ' lb_Location
        ' 
        lb_Location.AutoSize = True
        lb_Location.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lb_Location.Location = New Point(154, 34)
        lb_Location.Name = "lb_Location"
        lb_Location.Size = New Size(74, 17)
        lb_Location.TabIndex = 1
        lb_Location.Text = "lb_Location"
        ' 
        ' pb_ProfilePicture
        ' 
        pb_ProfilePicture.Location = New Point(12, 9)
        pb_ProfilePicture.Name = "pb_ProfilePicture"
        pb_ProfilePicture.Size = New Size(136, 116)
        pb_ProfilePicture.SizeMode = PictureBoxSizeMode.Zoom
        pb_ProfilePicture.TabIndex = 2
        pb_ProfilePicture.TabStop = False
        ' 
        ' dgv_Repos
        ' 
        dgv_Repos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_Repos.Location = New Point(12, 149)
        dgv_Repos.Name = "dgv_Repos"
        dgv_Repos.ReadOnly = True
        dgv_Repos.RowHeadersVisible = False
        dgv_Repos.Size = New Size(776, 289)
        dgv_Repos.TabIndex = 3
        ' 
        ' btn_Back
        ' 
        btn_Back.Location = New Point(713, 9)
        btn_Back.Name = "btn_Back"
        btn_Back.Size = New Size(75, 23)
        btn_Back.TabIndex = 4
        btn_Back.Text = "Back"
        btn_Back.UseVisualStyleBackColor = True
        ' 
        ' lb_TopRepos
        ' 
        lb_TopRepos.AutoSize = True
        lb_TopRepos.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lb_TopRepos.Location = New Point(12, 128)
        lb_TopRepos.Name = "lb_TopRepos"
        lb_TopRepos.Size = New Size(79, 17)
        lb_TopRepos.TabIndex = 5
        lb_TopRepos.Text = "lb_TopRepos"
        ' 
        ' lb_Bio
        ' 
        lb_Bio.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lb_Bio.Location = New Point(154, 66)
        lb_Bio.Name = "lb_Bio"
        lb_Bio.Size = New Size(475, 59)
        lb_Bio.TabIndex = 6
        lb_Bio.Text = "lb_Bio"
        ' 
        ' frm_Results
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lb_Bio)
        Controls.Add(lb_TopRepos)
        Controls.Add(btn_Back)
        Controls.Add(dgv_Repos)
        Controls.Add(pb_ProfilePicture)
        Controls.Add(lb_Location)
        Controls.Add(lb_Username)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frm_Results"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Results"
        CType(pb_ProfilePicture, ComponentModel.ISupportInitialize).EndInit()
        CType(dgv_Repos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lb_Username As Label
    Friend WithEvents lb_Location As Label
    Friend WithEvents pb_ProfilePicture As PictureBox
    Friend WithEvents dgv_Repos As DataGridView
    Friend WithEvents btn_Back As Button
    Friend WithEvents lb_TopRepos As Label
    Friend WithEvents lb_Bio As Label
End Class
