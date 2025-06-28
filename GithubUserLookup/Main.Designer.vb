<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Label1 = New Label()
        tb_Username = New TextBox()
        btn_Search = New Button()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        nud_NumberOfRepos = New NumericUpDown()
        Label3 = New Label()
        rb_Stargazers = New RadioButton()
        rb_Name = New RadioButton()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_NumberOfRepos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 15)
        Label1.TabIndex = 0
        Label1.Text = "Github User Lookup"
        ' 
        ' tb_Username
        ' 
        tb_Username.AutoCompleteMode = AutoCompleteMode.Suggest
        tb_Username.AutoCompleteSource = AutoCompleteSource.CustomSource
        tb_Username.Location = New Point(12, 27)
        tb_Username.Name = "tb_Username"
        tb_Username.PlaceholderText = "Username"
        tb_Username.Size = New Size(112, 23)
        tb_Username.TabIndex = 1
        ' 
        ' btn_Search
        ' 
        btn_Search.Location = New Point(12, 56)
        btn_Search.Name = "btn_Search"
        btn_Search.Size = New Size(75, 23)
        btn_Search.TabIndex = 2
        btn_Search.Text = "Search"
        btn_Search.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.github
        PictureBox1.Location = New Point(150, 9)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(80, 71)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 15)
        Label2.TabIndex = 4
        Label2.Text = "Number of Repos:"
        ' 
        ' nud_NumberOfRepos
        ' 
        nud_NumberOfRepos.Location = New Point(12, 124)
        nud_NumberOfRepos.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        nud_NumberOfRepos.Name = "nud_NumberOfRepos"
        nud_NumberOfRepos.Size = New Size(103, 23)
        nud_NumberOfRepos.TabIndex = 5
        nud_NumberOfRepos.Value = New Decimal(New Integer() {5, 0, 0, 0})
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(136, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 15)
        Label3.TabIndex = 6
        Label3.Text = "Sort Repos By:"
        ' 
        ' rb_Stargazers
        ' 
        rb_Stargazers.AutoSize = True
        rb_Stargazers.Checked = True
        rb_Stargazers.Location = New Point(136, 124)
        rb_Stargazers.Name = "rb_Stargazers"
        rb_Stargazers.Size = New Size(78, 19)
        rb_Stargazers.TabIndex = 7
        rb_Stargazers.TabStop = True
        rb_Stargazers.Text = "Stargazers"
        rb_Stargazers.UseVisualStyleBackColor = True
        ' 
        ' rb_Name
        ' 
        rb_Name.AutoSize = True
        rb_Name.Location = New Point(136, 149)
        rb_Name.Name = "rb_Name"
        rb_Name.Size = New Size(57, 19)
        rb_Name.TabIndex = 8
        rb_Name.Text = "Name"
        rb_Name.UseVisualStyleBackColor = True
        ' 
        ' frm_Main
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(240, 179)
        Controls.Add(rb_Name)
        Controls.Add(rb_Stargazers)
        Controls.Add(Label3)
        Controls.Add(nud_NumberOfRepos)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(btn_Search)
        Controls.Add(tb_Username)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frm_Main"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Github User Lookup"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_NumberOfRepos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tb_Username As TextBox
    Friend WithEvents btn_Search As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nud_NumberOfRepos As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents rb_Stargazers As RadioButton
    Friend WithEvents rb_Name As RadioButton

End Class
