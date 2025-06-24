Public Class frm_Main

    Public Sub btn_Search_Click() Handles btn_Search.Click
        Dim Results As New frm_Results
        Results.Show()
        Me.Hide()
    End Sub

End Class
