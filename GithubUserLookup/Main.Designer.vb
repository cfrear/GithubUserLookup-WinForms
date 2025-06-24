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
        Label1 = New Label()
        tb_Username = New TextBox()
        btn_Search = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
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
        PictureBox1.Location = New Point(150, 9)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(140, 71)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' frm_Main
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(302, 92)
        Controls.Add(PictureBox1)
        Controls.Add(btn_Search)
        Controls.Add(tb_Username)
        Controls.Add(Label1)
        Name = "frm_Main"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Github User Lookup"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tb_Username As TextBox
    Friend WithEvents btn_Search As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
