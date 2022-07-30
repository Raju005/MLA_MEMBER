Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient
Imports System.IO
Public Class FRM_RKGA_MEMBER_DOB_AND_WEDDING_LIST
    Dim sqlstring As String
    Dim gconnection As New GlobalClass
    Dim txtobj1 As TextObject

    Private Sub FRM_RKGA_MEMBER_DOB_AND_WEDDING_LIST_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.F6 Then
                If cmd_Clear.Enabled = True Then
                    Call cmd_Clear_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F9 Then
                If cmd_View.Enabled = True Then
                    Call cmd_View_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F12 Then
                If Button5.Enabled = True Then
                    Call button5_click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
                If Button4.Enabled = True Then
                    Call Button4_Click(sender, e)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
   
    Private Sub FRM_RKGA_MEMBER_DOB_AND_WEDDING_LIST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillMEMBERTYPE()
        Chk_FILTER_FIELD.Focus()
        Show()
    End Sub
    Private Sub FillMEMBERTYPE()
        Dim i As Integer
        Chk_FILTER_FIELD.Items.Clear()
        ' sqlstring = "SELECT MEMBERTYPE,TYPEDESC FROM MEMBERTYPE ORDER BY MEMBERTYPE"
        sqlstring = "SELECT subtypecode,subtypedesc FROM subcategorymaster ORDER BY subtypecode"
        gconnection.getDataSet(sqlstring, "subtypecode")
        If gdataset.Tables("subtypecode").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("subtypecode").Rows.Count - 1
                With gdataset.Tables("subtypecode").Rows(i)
                    'chk_Filter_Field.Items.Add(Trim(.Item("MEMBERTYPE")) & "==>" & .Item("TYPEDESC"))
                    Chk_FILTER_FIELD.Items.Add(Trim(.Item("subtypedesc")))
                End With
            Next i
        End If
        Chk_FILTER_FIELD.Sorted = True
    End Sub

    Private Sub Lbltodate_Click(sender As Object, e As EventArgs) Handles Lbltodate.Click

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles Todate.ValueChanged

    End Sub

    Private Sub cmd_Clear_Click(sender As Object, e As EventArgs) Handles cmd_Clear.Click
        Chkdob.Checked = False
        Fromdate.Text = ""
        Todate.Text = ""
        Chkdob.Checked = False
        Chkwedding.Checked = False
        Chkdep.Checked = False
        Chkphoto.Checked = False
        Dim i As Integer
        chk_PrintAll.Checked = False

        For i = 0 To (Chk_FILTER_FIELD.Items.Count - 1)
            Chk_FILTER_FIELD.SetItemChecked(i, False)
        Next


    End Sub

    Private Sub cmd_View_Click(sender As Object, e As EventArgs) Handles cmd_View.Click
        If (Chk_FILTER_FIELD.CheckedItems.Count <= 0) = True Then
            MessageBox.Show("Select the Member Type Items")
        ElseIf Chkdob.Checked = True And Chkdep.Checked = True Then
            Call Reportdetails_summary1()
        ElseIf Chkdob.Checked = True And Chkphoto.Checked = True Then
            Call Reportdetails_summary2()
        ElseIf Chkwedding.Checked = True And Chkdep.Checked = True Then
            Call Reportdetails_summary3()
        ElseIf Chkwedding.Checked = True And Chkphoto.Checked = True Then
            Call Reportdetails_summary4()
        ElseIf Chkwedding.Checked = True Then
            Call Reportdetails_summary3()
        Else
            Call Reportdetails_summary1()
        End If
    End Sub
    Public Sub Reportdetails_summary1()
        Try
            Dim HEADING As String
            Dim cmdText, dateofbirthfrom, dateofbirthto, dateofweddingfrom, dateofweddingto As String
            Dim Viewer As New REPORTVIEWER
            Dim r As New Cry_MEMBERDOB
            cmdText = "select mcode,mname,ISNULL(dob,'') AS DOB,membertype,contcell,contemail,wedding_date,memimage from mm_membermaster"
            txtCategory.Text = ""
            Dim o As Object
            For Each o In Chk_FILTER_FIELD.CheckedItems
                txtCategory.Text += "'" & o.ToString() & "',"
            Next o

            cmdText = cmdText & " where MEMBERTYPE in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            'If (txt_mcode.Text <> "") And (txt_Tomcode.Text <> "") Then
            '    cmdText = cmdText & " and mcode between '" & txt_mcode.Text & "' and '" & txt_Tomcode.Text & "'"
            'End If

            If Chkdob.Checked = True Then
                If (Fromdate.Text <> "") And (Todate.Text <> "") Then
                    cmdText = cmdText & "  and DATEADD(YEAR, DATEDIFF(YEAR,  dob, convert(datetime,'" & Fromdate.Text & "',103)), dob) BETWEEN convert(datetime,'" & Fromdate.Text & "',103) AND convert(datetime,'" & Todate.Text & "',103) "
                    cmdText = cmdText & "   OR DATEADD(YEAR, DATEDIFF(YEAR,  dob, convert(datetime,'" & Todate.Text & "',103)), dob) BETWEEN convert(datetime,'" & Fromdate.Text & "',103) AND convert(datetime,'" & Todate.Text & "',103) "
                    cmdText = cmdText & " ORDER BY CASE WHEN DATEADD(YEAR, DATEDIFF(YEAR,  dob,convert(datetime,'" & Fromdate.Text & "',103)), dob) BETWEEN convert(datetime,'" & Fromdate.Text & "',103)  AND convert(datetime,'" & Todate.Text & "',103) "
                    cmdText = cmdText & " THEN 1 ELSE 2 END,DATEPART(MONTH, dob), DATEPART(DAY, dob)"
                    dateofbirthfrom = Fromdate.Text
                    dateofbirthto = Todate.Text
                    HEADING = "DATE OF BIRTH"


                    Call Viewer.GetDetails(cmdText, "MM_MEMBERMASTER", r)
                    txtobj1 = r.ReportDefinition.ReportObjects("Text26")
                    txtobj1.Text = Fromdate.Text
                    txtobj1 = r.ReportDefinition.ReportObjects("Text27")
                    txtobj1.Text = Todate.Text
                    '' txtobj1 = r.ReportDefinition.ReportObjects("Text28")
                    ' txtobj1.Text = UCase(HEADING)
                End If
            End If

            txtobj1 = r.ReportDefinition.ReportObjects("Text1")
            txtobj1.Text = UCase(gcompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text2")
            txtobj1.Text = UCase(gCompanyAddress(0))
            txtobj1 = r.ReportDefinition.ReportObjects("Text3")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text4")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text5")
            txtobj1.Text = UCase(gCompanyAddress(3))
            txtobj1 = r.ReportDefinition.ReportObjects("Text22")
            txtobj1.Text = UCase(gCompanyAddress(4))
            txtobj1 = r.ReportDefinition.ReportObjects("Text25")
            txtobj1.Text = UCase(gCompanyAddress(5))

            txtobj1 = r.ReportDefinition.ReportObjects("Text21")
            txtobj1.Text = UCase(gFinancalyearStart)
            txtobj1 = r.ReportDefinition.ReportObjects("Text24")
            txtobj1.Text = UCase(gFinancialyearEnd)
            txtobj1 = r.ReportDefinition.ReportObjects("Text29")
            txtobj1.Text = UCase(gUsername)
            Viewer.ssql = cmdText
            Viewer.Report = r
            Viewer.TableName = "mm_membermaster"
            Viewer.Show()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    '  ---praba
    Public Sub Reportdetails_summary2()
        Try
            Dim HEADING As String
            Dim cmdText, dateofbirthfrom, dateofbirthto, dateofweddingfrom, dateofweddingto As String
            Dim Viewer As New REPORTVIEWER
            Dim r As New Cry_MEMBERDOB
            cmdText = "select mcode,mname,ISNULL(dob,'') AS DOB,membertype,contcell,contemail,memimage from mm_membermaster"
            txtCategory.Text = ""
            Dim o As Object
            For Each o In Chk_FILTER_FIELD.CheckedItems
                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            cmdText = cmdText & " where MEMBERTYPE in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            'If (txt_mcode.Text <> "") And (txt_Tomcode.Text <> "") Then
            '    cmdText = cmdText & " and mcode between '" & txt_mcode.Text & "' and '" & txt_Tomcode.Text & "'"
            'End If

            If Chkdob.Checked = True Then
                If (Fromdate.Text <> "") And (Todate.Text <> "") Then
                    cmdText = cmdText & "  and DATEADD(YEAR, DATEDIFF(YEAR,  dob, convert(datetime,'" & Fromdate.Text & "',103)), dob) BETWEEN convert(datetime,'" & Fromdate.Text & "',103) AND convert(datetime,'" & Todate.Text & "',103) "
                    cmdText = cmdText & "   OR DATEADD(YEAR, DATEDIFF(YEAR,  dob, convert(datetime,'" & Todate.Text & "',103)), dob) BETWEEN convert(datetime,'" & Fromdate.Text & "',103) AND convert(datetime,'" & Todate.Text & "',103) "
                    cmdText = cmdText & " ORDER BY CASE WHEN DATEADD(YEAR, DATEDIFF(YEAR,  dob,convert(datetime,'" & Fromdate.Text & "',103)), dob) BETWEEN convert(datetime,'" & Fromdate.Text & "',103)  AND convert(datetime,'" & Todate.Text & "',103) "
                    cmdText = cmdText & " THEN 1 ELSE 2 END,DATEPART(MONTH, dob), DATEPART(DAY, dob)"
                    dateofbirthfrom = Fromdate.Text
                    dateofbirthto = Todate.Text
                    HEADING = "DATE OF BIRTH"
                    txtobj1 = r.ReportDefinition.ReportObjects("Text26")
                    txtobj1.Text = dateofbirthfrom
                    txtobj1 = r.ReportDefinition.ReportObjects("Text27")
                    txtobj1.Text = dateofbirthto
                    txtobj1 = r.ReportDefinition.ReportObjects("Text28")
                    txtobj1.Text = UCase(HEADING)

                    txtobj1 = r.ReportDefinition.ReportObjects("Text21")
                    txtobj1.Text = UCase(gFinancalyearStart)
                    txtobj1 = r.ReportDefinition.ReportObjects("Text24")
                    txtobj1.Text = UCase(gFinancialyearEnd)


                End If
            End If

            txtobj1 = r.ReportDefinition.ReportObjects("Text1")
            txtobj1.Text = UCase(gCompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text2")
            txtobj1.Text = UCase(gCompanyAddress(0))
            txtobj1 = r.ReportDefinition.ReportObjects("Text3")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text4")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text5")
            txtobj1.Text = UCase(gCompanyAddress(3))
            txtobj1 = r.ReportDefinition.ReportObjects("Text22")
            txtobj1.Text = UCase(gCompanyAddress(4))
            txtobj1 = r.ReportDefinition.ReportObjects("Text25")
            txtobj1.Text = UCase(gCompanyAddress(5))
            txtobj1 = r.ReportDefinition.ReportObjects("Text29")
            txtobj1.Text = UCase(gUsername)
            Viewer.ssql = cmdText
            Viewer.Report = r
            Viewer.TableName = "mm_membermaster"
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub Reportdetails_summary3()
        Try
            Dim HEADING As String
            Dim cmdText, dateofbirthfrom, dateofbirthto, dateofweddingfrom, dateofweddingto As String
            Dim Viewer As New REPORTVIEWER
            Dim r As New Cry_MEMBERDOW
            cmdText = "select mcode,mname,ISNULL(WEDDING_DATE,'') AS WEDDING_DATE,membertype,contcell,contemail from mm_membermaster"
            txtCategory.Text = ""
            Dim o As Object
            For Each o In Chk_FILTER_FIELD.CheckedItems
                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            cmdText = cmdText & " where MEMBERTYPE in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            If Chkdob.Checked = True Then
                If (Fromdate.Text <> "") And (Todate.Text <> "") Then
                    cmdText = cmdText & "  and DATEADD(YEAR, DATEDIFF(YEAR,  WEDDING_DATE, convert(datetime,'" & Fromdate.Text & "',103)), DOW) BETWEEN convert(datetime,'" & Fromdate.Text & "',103) AND convert(datetime,'" & Todate.Text & "',103) "
                    cmdText = cmdText & "   OR DATEADD(YEAR, DATEDIFF(YEAR,  WEDDING_DATE, convert(datetime,'" & Todate.Text & "',103)), WEDDING_DATE) BETWEEN convert(datetime,'" & Fromdate.Text & "',103) AND convert(datetime,'" & Todate.Text & "',103) "
                    cmdText = cmdText & " ORDER BY CASE WHEN DATEADD(YEAR, DATEDIFF(YEAR,  WEDDING_DATE,convert(datetime,'" & Fromdate.Text & "',103)), WEDDING_DATE) BETWEEN convert(datetime,'" & Fromdate.Text & "',103)  AND convert(datetime,'" & Todate.Text & "',103) "
                    cmdText = cmdText & " THEN 1 ELSE 2 END,DATEPART(MONTH, WEDDING_DATE), DATEPART(DAY, WEDDING_DATE)"
                    dateofbirthfrom = Fromdate.Text
                    dateofbirthto = Todate.Text
                    HEADING = "DATE OF WEDDING_DATE"
                    txtobj1 = r.ReportDefinition.ReportObjects("Text26")
                    txtobj1.Text = Fromdate.Text
                    ' txtobj1.Text = dateofbirthfrom
                    '  txtobj1 = r.ReportDefinition.ReportObjects("Text27")
                    'txtobj1.Text = dateofbirthto
                    ' txtobj1.Text = Todate.Text
                    txtobj1 = r.ReportDefinition.ReportObjects("Text28")
                    txtobj1.Text = UCase(HEADING)

                    

                End If
            End If

            txtobj1 = r.ReportDefinition.ReportObjects("Text1")
            txtobj1.Text = UCase(gCompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text2")
            txtobj1.Text = UCase(gCompanyAddress(0))
            txtobj1 = r.ReportDefinition.ReportObjects("Text3")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text4")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text5")
            txtobj1.Text = UCase(gCompanyAddress(3))
            txtobj1 = r.ReportDefinition.ReportObjects("Text15")
            txtobj1.Text = UCase(gCompanyAddress(4))
            txtobj1 = r.ReportDefinition.ReportObjects("Text22")
            txtobj1.Text = UCase(gCompanyAddress(5))

            txtobj1 = r.ReportDefinition.ReportObjects("Text25")
            txtobj1.Text = UCase(gUsername)
            txtobj1 = r.ReportDefinition.ReportObjects("Text26")
            txtobj1.Text = Fromdate.Text
            txtobj1 = r.ReportDefinition.ReportObjects("Text27")
            txtobj1.Text = Todate.Text
            txtobj1 = r.ReportDefinition.ReportObjects("Text19")
            txtobj1.Text = UCase(gFinancalyearStart)
            txtobj1 = r.ReportDefinition.ReportObjects("Text23")
            txtobj1.Text = UCase(gFinancialyearEnd)

            ' txtobj1.Text = Todate.Text
            Viewer.ssql = cmdText
            Viewer.Report = r
            Viewer.TableName = "mm_membermaster"
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Reportdetails_summary4()
        Try
            Dim HEADING As String
            Dim cmdText, dateofbirthfrom, dateofbirthto, dateofweddingfrom, dateofweddingto As String
            Dim Viewer As New REPORTVIEWER
            Dim r As New Cry_MEMBERDOB
            cmdText = "select mcode,mname,ISNULL(dob,'') AS DOB,membertype,contcell,contemail from mm_membermaster"
            txtCategory.Text = ""
            Dim o As Object
            For Each o In Chk_FILTER_FIELD.CheckedItems
                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            cmdText = cmdText & " where MEMBERTYPE in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            If Chkdob.Checked = True Then
                If (Fromdate.Text <> "") And (Todate.Text <> "") Then
                    cmdText = cmdText & "  and DATEADD(YEAR, DATEDIFF(YEAR,  dob, convert(datetime,'" & Fromdate.Text & "',103)), dob) BETWEEN convert(datetime,'" & Fromdate.Text & "',103) AND convert(datetime,'" & Todate.Text & "',103) "
                    cmdText = cmdText & "   OR DATEADD(YEAR, DATEDIFF(YEAR,  dob, convert(datetime,'" & Todate.Text & "',103)), dob) BETWEEN convert(datetime,'" & Fromdate.Text & "',103) AND convert(datetime,'" & Todate.Text & "',103) "
                    cmdText = cmdText & " ORDER BY CASE WHEN DATEADD(YEAR, DATEDIFF(YEAR,  dob,convert(datetime,'" & Fromdate.Text & "',103)), dob) BETWEEN convert(datetime,'" & Fromdate.Text & "',103)  AND convert(datetime,'" & Todate.Text & "',103) "
                    cmdText = cmdText & " THEN 1 ELSE 2 END,DATEPART(MONTH, dob), DATEPART(DAY, dob)"
                    dateofbirthfrom = Fromdate.Text
                    dateofbirthto = Todate.Text
                    HEADING = "DATE OF BIRTH"
                    txtobj1 = r.ReportDefinition.ReportObjects("Text26")
                    txtobj1.Text = dateofbirthfrom
                    txtobj1 = r.ReportDefinition.ReportObjects("Text27")
                    txtobj1.Text = dateofbirthto
                    txtobj1 = r.ReportDefinition.ReportObjects("Text28")
                    txtobj1.Text = UCase(HEADING)
                    txtobj1 = r.ReportDefinition.ReportObjects("Text21")
                    txtobj1.Text = UCase(gFinancalyearStart)
                    txtobj1 = r.ReportDefinition.ReportObjects("Text24")
                    txtobj1.Text = UCase(gFinancialyearEnd)


                End If
            End If

            txtobj1 = r.ReportDefinition.ReportObjects("Text1")
            txtobj1.Text = UCase(gCompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text2")
            txtobj1.Text = UCase(gCompanyAddress(0))
            txtobj1 = r.ReportDefinition.ReportObjects("Text3")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text4")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text5")
            txtobj1.Text = UCase(gCompanyAddress(3))
            txtobj1 = r.ReportDefinition.ReportObjects("Text22")
            txtobj1.Text = UCase(gCompanyAddress(4))
            txtobj1 = r.ReportDefinition.ReportObjects("Text25")
            txtobj1.Text = UCase(gCompanyAddress(5))

            txtobj1 = r.ReportDefinition.ReportObjects("Text21")
            txtobj1.Text = UCase(gFinancalyearStart)
            txtobj1 = r.ReportDefinition.ReportObjects("Text24")
            txtobj1.Text = UCase(gFinancialyearEnd)

            txtobj1 = r.ReportDefinition.ReportObjects("Text29")
            txtobj1.Text = UCase(gUsername)
            Viewer.ssql = cmdText
            Viewer.Report = r
            Viewer.TableName = "mm_membermaster"
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub chk_PrintAll_CheckedChanged(sender As Object, e As EventArgs) Handles chk_PrintAll.CheckedChanged
        Dim Iteration As Integer
        If chk_PrintAll.Checked = True Then
            Try
                For Iteration = 0 To (Chk_FILTER_FIELD.Items.Count - 1)
                    Chk_FILTER_FIELD.SetSelected(Iteration, True)
                    Chk_FILTER_FIELD.SetItemChecked(Iteration, True)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                For Iteration = 0 To (Chk_FILTER_FIELD.Items.Count - 1)
                    Chk_FILTER_FIELD.SetSelected(Iteration, False)
                    Chk_FILTER_FIELD.SetItemChecked(Iteration, False)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Chk_FILTER_FIELD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Chk_FILTER_FIELD.SelectedIndexChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Chkdob_CheckedChanged(sender As Object, e As EventArgs) Handles Chkdob.CheckedChanged
        If Chkdob.Checked = True Then
            Chkwedding.Checked = False
        Else
            Chkwedding.Checked = True
            Chkdob.Checked = False
        End If
    End Sub

    Private Sub Chkwedding_CheckedChanged(sender As Object, e As EventArgs) Handles Chkwedding.CheckedChanged
        If Chkwedding.Checked = True Then
            Chkdob.Checked = False
        Else
            Chkdob.Checked = True
            Chkwedding.Checked = False
        End If
    End Sub

    Private Function r() As Object
        Throw New NotImplementedException
    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub
End Class