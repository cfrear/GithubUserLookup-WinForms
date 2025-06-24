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
        lb_Username = New Label()
        lb_Location = New Label()
        pb_ProfilePicture = New PictureBox()
        dgv_Repos = New DataGridView()
        CType(pb_ProfilePicture, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgv_Repos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lb_Username
        ' 
        lb_Username.AutoSize = True
        lb_Username.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lb_Username.Location = New Point(12, 9)
        lb_Username.Name = "lb_Username"
        lb_Username.Size = New Size(126, 25)
        lb_Username.TabIndex = 0
        lb_Username.Text = "lb_Username"
        ' 
        ' lb_Location
        ' 
        lb_Location.AutoSize = True
        lb_Location.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lb_Location.Location = New Point(12, 47)
        lb_Location.Name = "lb_Location"
        lb_Location.Size = New Size(74, 17)
        lb_Location.TabIndex = 1
        lb_Location.Text = "lb_Location"
        ' 
        ' pb_ProfilePicture
        ' 
        pb_ProfilePicture.Location = New Point(144, 9)
        pb_ProfilePicture.Name = "pb_ProfilePicture"
        pb_ProfilePicture.Size = New Size(136, 116)
        pb_ProfilePicture.TabIndex = 2
        pb_ProfilePicture.TabStop = False
        ' 
        ' dgv_Repos
        ' 
        dgv_Repos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_Repos.Location = New Point(12, 131)
        dgv_Repos.Name = "dgv_Repos"
        dgv_Repos.Size = New Size(268, 172)
        dgv_Repos.TabIndex = 3
        ' 
        ' frm_Results
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgv_Repos)
        Controls.Add(pb_ProfilePicture)
        Controls.Add(lb_Location)
        Controls.Add(lb_Username)
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
End Class
