Public Class VIEWDET

    Private Sub VIEWDET_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub LOADDATA(ByVal DC As DataTable, ByVal DET As Boolean, ByVal FORMNAME As String, ByVal SQL As String, ByVal KEYFILD As String, ByVal COLUMNSEQ As Integer)
        DGVDET.DataSource = DC
        Dim CHECKCOL As New DataGridViewCheckBoxColumn
        CHECKCOL.HeaderText = "SELECT"
        DGVDET.Columns.Add(CHECKCOL)
    End Sub

End Class