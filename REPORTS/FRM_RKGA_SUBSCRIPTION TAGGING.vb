Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient
Imports System.IO
Public Class FRM_RKGA_SUBSCRIPTION_TAGGING


    Dim ssql As String
    Dim sqlstring, TempString(2) As String
    Dim txtobj1 As TextObject
    Dim gconnection As New GlobalClass

    Private Sub FRM_RKGA_SUBSCRIPTION_TAGGING_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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


    Private Sub FRM_RKGA_SUBSCRIPTION_TAGGING_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        Subscription_Master_Load()

        CheckBox1.Focus()
        CheckBox1.Select()

    End Sub
    Private Sub Subscription_Master_Load()
        Dim i As Integer
        chkList_Subscription.Items.Clear()
        ' sqlstring = "SELECT MEMBERTYPE,TYPEDESC FROM MEMBERTYPE ORDER BY MEMBERTYPE"
        ssql = "SELECT subsdesc from subscriptionmast ORDER BY subsdesc"
        gconnection.getDataSet(ssql, "subsdesc")
        If gdataset.Tables("subsdesc").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("subsdesc").Rows.Count - 1
                With gdataset.Tables("subsdesc").Rows(i)
                    'chk_Filter_Field.Items.Add(Trim(.Item("MEMBERTYPE")) & "==>" & .Item("TYPEDESC"))
                    chkList_Subscription.Items.Add(Trim(.Item("subsdesc")))
                End With
            Next i
        End If
        chkList_Subscription.Sorted = True


    End Sub

    Private Sub mcodefrom_KeyDown(sender As Object, e As KeyEventArgs) Handles mcodefrom.KeyDown
        If e.KeyCode = Keys.Enter Then

        End If
        If mcodefrom.Text = "" Then
            cmd_MemberCodeHelp_Click(sender, e)
        Else
            membercodeto.Focus()
        End If
    End Sub

    Private Sub mcodefrom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mcodefrom.KeyPress
        '  membercodeto.Focus()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles mcodefrom.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub membercodeto_KeyDown(sender As Object, e As KeyEventArgs) Handles membercodeto.KeyDown
        If e.KeyCode = Keys.Enter Then

        End If
        If membercodeto.Text = "" Then
            Button1_Click(sender, e)
        Else
            RadioButton2.Focus()
        End If
    End Sub

    Private Sub membercodeto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles membercodeto.KeyPress

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles membercodeto.TextChanged

    End Sub

    Private Sub cmd_Clear_Click(sender As Object, e As EventArgs) Handles cmd_Clear.Click
        membercodeto.Text = ""
        mcodefrom.Text = ""
        membercodeto.Enabled = True
        membercodeto.Text = Nothing
        ' chkList_Subscription.Items.Clear()
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        CheckBox1.Checked = False
    End Sub

    Private Sub cmd_View_Click(sender As Object, e As EventArgs) Handles cmd_View.Click
        If (chkList_Subscription.CheckedItems.Count <= 0) = True Then
            MessageBox.Show("Select the Type of Subscription")
        ElseIf RadioButton2.Checked = True And RadioButton3.Checked = False Then
            Call Reportdetails_summary1()
        ElseIf RadioButton2.Checked = False And RadioButton3.Checked = True Then
            Call Reportdetails_summary2()
        Else
            '   Call subscription_summary1()
        End If
    End Sub
    Public Sub Reportdetails_summary1()
        Try
            Dim HEADING As String
            Dim cmdText, dateofbirthfrom, dateofbirthto, dateofweddingfrom, dateofweddingto As String
            Dim Viewer As New REPORTVIEWER
            Dim r As New Cry_Memwisesubscriptiontagging
            cmdText = "select subscode,subscriptiontype,mcode,ISNULL(mname,'') AS MNAME from subscriptiontagging"

            chkList_Subscription.Text = ""
            Dim o As Object
            For Each o In chkList_Subscription.CheckedItems
                txtCategory.Text += "'" & o.ToString() & "',"
            Next o

            cmdText = cmdText & " where subscriptiontype in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"

            If RadioButton2.Checked = True Then
                ''If mcodefrom.Text <> "" And membercodeto.Text = "" Then
                ''    cmdText = cmdText & "  and mcode  BETWEEN('" & Trim(mcodefrom.Text) & "','" & Trim(mcodefrom.Text) & "')"

                ''End If
                If (mcodefrom.Text <> "") And (membercodeto.Text <> "") Then
                    cmdText = cmdText & " and mcode between '" & mcodefrom.Text & "' and '" & membercodeto.Text & "'"
                End If





                Call Viewer.GetDetails(cmdText, "subscriptiontagging", r)
                '  txtobj1 = r.ReportDefinition.ReportObjects("Text26")
                '  txtobj1.Text = dateofbirthfrom


                '  txtobj1 = r.ReportDefinition.ReportObjects("Text27")
                '  txtobj1.Text = dateofbirthto
                '  txtobj1 = r.ReportDefinition.ReportObjects("Text28")
                '  txtobj1.Text = UCase(HEADING)

                'End If
            End If

            txtobj1 = r.ReportDefinition.ReportObjects("Text1")
            txtobj1.Text = UCase(gCompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text2")
            txtobj1.Text = UCase(gCompanyAddress(0))
            txtobj1 = r.ReportDefinition.ReportObjects("Text3")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text14")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text16")
            txtobj1.Text = UCase(gCompanyAddress(3))
            txtobj1 = r.ReportDefinition.ReportObjects("Text17")
            txtobj1.Text = UCase(gCompanyAddress(4))
            txtobj1 = r.ReportDefinition.ReportObjects("Text19")
            txtobj1.Text = UCase(gCompanyAddress(5))

            txtobj1 = r.ReportDefinition.ReportObjects("Text4")
            txtobj1.Text = UCase(gFinancalyearStart)
            txtobj1 = r.ReportDefinition.ReportObjects("Text22")
            txtobj1.Text = UCase(gFinancialyearEnd)
            txtobj1 = r.ReportDefinition.ReportObjects("Text27")
            txtobj1.Text = UCase(gUsername)
            Viewer.ssql = cmdText
            Viewer.Report = r
            Viewer.TableName = "subscriptiontagging"
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub Reportdetails_summary2()
        Try
            Dim HEADING As String
            Dim cmdText, dateofbirthfrom, dateofbirthto, dateofweddingfrom, dateofweddingto As String
            Dim Viewer As New REPORTVIEWER
            Dim r As New CRY_SUBSCRIPTIONTAGGING
            cmdText = "select subscode,subscriptiontype,mcode,mname from subscriptiontagging"

            chkList_Subscription.Text = ""
            Dim o As Object
            For Each o In chkList_Subscription.CheckedItems
                txtCategory.Text += "'" & o.ToString() & "',"
            Next o

            cmdText = cmdText & " where subscriptiontype in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"

            If RadioButton2.Checked = True Then

                cmdText = cmdText & "  and mcode in('" & Trim(mcodefrom.Text) & "','" & Trim(mcodefrom.Text) & "')"


                Call Viewer.GetDetails(cmdText, "subscriptiontagging", r)
                '  txtobj1 = r.ReportDefinition.ReportObjects("Text26")
                '  txtobj1.Text = dateofbirthfrom

                txtobj1 = r.ReportDefinition.ReportObjects("Text7")
                txtobj1.Text = UCase(gFinancalyearStart)
                txtobj1 = r.ReportDefinition.ReportObjects("Text22")
                txtobj1.Text = UCase(gFinancialyearEnd)



                '  txtobj1 = r.ReportDefinition.ReportObjects("Text27")
                '  txtobj1.Text = dateofbirthto
                '  txtobj1 = r.ReportDefinition.ReportObjects("Text28")
                '  txtobj1.Text = UCase(HEADING)

                'End If
            End If

            txtobj1 = r.ReportDefinition.ReportObjects("Text1")
            txtobj1.Text = UCase(gCompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text2")
            txtobj1.Text = UCase(gCompanyAddress(0))
            txtobj1 = r.ReportDefinition.ReportObjects("Text3")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text4")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text16")
            txtobj1.Text = UCase(gCompanyAddress(3))
            txtobj1 = r.ReportDefinition.ReportObjects("Text17")
            txtobj1.Text = UCase(gCompanyAddress(4))

            txtobj1 = r.ReportDefinition.ReportObjects("Text19")
            txtobj1.Text = UCase(gCompanyAddress(5))



            txtobj1 = r.ReportDefinition.ReportObjects("Text27")
            txtobj1.Text = UCase(gUsername)

            txtobj1 = r.ReportDefinition.ReportObjects("Text7")
            txtobj1.Text = UCase(gFinancalyearStart)
            txtobj1 = r.ReportDefinition.ReportObjects("Text22")
            txtobj1.Text = UCase(gFinancialyearEnd)
            Viewer.ssql = cmdText
            Viewer.Report = r
            Viewer.TableName = "subscriptiontagging"
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Try
            If CheckBox1.Checked = True Then
                For Iteration = 0 To (chkList_Subscription.Items.Count - 1)
                    chkList_Subscription.SetSelected(Iteration, True)
                    chkList_Subscription.SetItemChecked(Iteration, True)
                Next
            Else
                For Iteration = 0 To (chkList_Subscription.Items.Count - 1)
                    chkList_Subscription.SetItemChecked(Iteration, False)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub chkList_Subscription_KeyDown(sender As Object, e As KeyEventArgs) Handles chkList_Subscription.KeyDown
        mcodefrom.Focus()
    End Sub

    Private Sub chkList_Subscription_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chkList_Subscription.SelectedIndexChanged

    End Sub

    Private Sub cmd_MemberCodeHelp_Click(sender As Object, e As EventArgs) Handles cmd_MemberCodeHelp.Click
        Dim vform As New LIST_OPERATION1
        gSQLString = "Select MCODE,MNAME from membermaster"
        M_WhereCondition = " "
        vform.vCaption = "Membercode Help"
        vform.Field = "MNAME,MCODE"
        vform.CMB_SRC_FIELDS.Select()
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            mcodefrom.Text = Trim(vform.keyfield & "")
            membercodeto.Select()
            mcodefrom_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing

    End Sub
    Private Sub mcodefrom_Validated(sender As Object, e As EventArgs) Handles mcodefrom.Validated
        Dim strsubscription, STRSQL As String
        Dim dr As DataRow
        Dim j As Long
        If mcodefrom.Text <> "" Then
            sqlstring = " SELECT *  FROM Membermaster WHERE mcode='" & Me.mcodefrom.Text & "'"
            gconnection.getDataSet(sqlstring, "Membermaster")
            If gdataset.Tables("Membermaster").Rows.Count > 0 Then
                Me.mcodefrom.Text = gdataset.Tables("membermaster").Rows(0).Item("mcode")
            Else
                MsgBox("member not available.........")
                membercodeto.Focus()
            End If
        End If
    End Sub
    Private Sub cmd_MemberCodeHelp_KeyDown(sender As Object, e As KeyEventArgs) Handles cmd_MemberCodeHelp.KeyDown

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vform As New LIST_OPERATION1
        gSQLString = "Select MCODE,MNAME from membermaster"
        M_WhereCondition = " "
        vform.vCaption = "Membercode Help"
        vform.Field = "MNAME,MCODE"
        vform.CMB_SRC_FIELDS.Select()
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            membercodeto.Text = Trim(vform.keyfield & "")
            membercodeto.Select()
            membercodeto_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub membercodeto_Validated(sender As Object, e As EventArgs) Handles membercodeto.Validated
        Dim strsubscription, STRSQL As String
        Dim dr As DataRow
        Dim j As Long
        If membercodeto.Text <> "" Then
            sqlstring = " SELECT *  FROM Membermaster WHERE mcode='" & Me.membercodeto.Text & "'"
            gconnection.getDataSet(sqlstring, "Membermaster")
            If gdataset.Tables("Membermaster").Rows.Count > 0 Then
                Me.membercodeto.Text = gdataset.Tables("membermaster").Rows(0).Item("mcode")
            Else
                MsgBox("member not available.........")
                membercodeto.Focus()
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub
End Class