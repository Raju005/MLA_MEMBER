Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine


Public Class RPT_MEMBERSTATUS_REPORT
    Dim FltrStr, status, TempString(2), DispString, addFltrStr As String
    Dim sqlStringFinal, sqlstring As String
    Dim Sqlstr, Sqlstr1, Insert(0) As String

    Public selectNo As Integer
    Dim txtobj1 As TextObject
    Private Sub RPT_MEMBERSTATUS_REPORT_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.F6 Then
                If btn_clear.Enabled = True Then
                    Call BTN_CLEAR_CLICK(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F9 Then
                If btn_view.Enabled = True Then
                    Call BTN_VIEW_CLICK(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F12 Then
                If BTN_PRINT.Enabled = True Then
                    Call btn_print_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
                If btn_exit.Enabled = True Then
                    Call btn_exit_click(sender, e)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub RPT_MEMBERSTATUS_REPORT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        Dim ssql As String
        Dim MEMBERTYPE As New DataTable
        ssql = "select isnull(subtypecode,'') as subtypecode,isnull(subtypedesc,'') as subtypedesc from subcategorymaster"
        MEMBERTYPE = gconnection.GetValues(ssql)
        Dim Itration
        For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
            chk_Filter_Field.Items.Add(MEMBERTYPE.Rows(Itration).Item("subtypedesc"))
        Next
        chk_Filter_Field.Focus()
        GroupBox5.Visible = False

    End Sub
    Private Sub GetRights()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql, SQLSTRING As String
        Dim M1 As New MainMenu
        Dim chstr As String
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='MEMBER' AND MODULENAME LIKE '" & Trim(GmoduleName) & "%'"
        gconnection.getDataSet(SQLSTRING, "USER")
        If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                With gdataset.Tables("USER").Rows(i)
                    chstr = abcdMINUS(.Item("RIGHTS"))
                End With
            Next
        End If
        Me.btn_print.Enabled = False
        '  Me.btn_freeze.Enabled = False
        Me.btn_view.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.btn_print.Enabled = True
                    '   Me.btn_freeze.Enabled = True
                    Me.btn_view.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.btn_print.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.btn_print.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.btn_print.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    ' Me.btn_freeze.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.btn_view.Enabled = True
                End If
            Next
        End If
    End Sub
    Private Sub cmb_Filter_By_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            chk_Filter_Field.Select()
        End If
    End Sub


    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        PRINTREP = True
        If Chk_sumry.Checked = True Then
            Call Summary()
        Else
            'Call Member_Status_Report()
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        tbx_Filter_From.Text = ""
        tbx_filter_To.Text = ""
        chk_PrintAll.Checked = False
        GroupBox1.Visible = True
        Chk_sumry.Checked = False
        chk_member_status_sum.Checked = False
        Chk_details.Checked = False
        Chk_Dojwisediff.Checked = False
        Chk_History.Checked = False
        chk_expiry_det.Checked = False
        chk_expired_det.Checked = False
        chk_terminate_det.Checked = False

        Call chk_STATUS_CheckedChanged(sender, e)
        chk_STATUS.Checked = False
        Call chk_PrintAll_CheckedChanged(sender, e)
        chk_PrintAll.Checked = False
        GroupBox5.Visible = False


        Dtp_From.Text = ""
        Dtp_To.Text = ""
        Label4.Text = "Effective From"
        Label5.Text = "Effective To"
        'If rdb_date.Checked = True Then
        Dtp_From.Visible = True
        Dtp_To.Visible = True
        'Else
        'Dtp_From.Visible = False
        'Dtp_To.Visible = False
        'End If
        chk_Filter_Field.Focus()
    End Sub

    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        If (chk_Filter_Field.CheckedItems.Count <= 0) Then
            MessageBox.Show("Select the Category Items")
            Exit Sub
        ElseIf (ChK_Memberstatus.CheckedItems.Count <= 0) Then

            MessageBox.Show("Select the Member Status Items")
            Exit Sub
        End If

        PRINTREP = False
        If Chk_sumry.Checked = True Then
            Call Summary()
        ElseIf chk_member_status_sum.Checked = True Then
            Call Member_Status_det_report()
        ElseIf Chk_details.Checked = True Then
            Call Member_details_doj_report()
        ElseIf Chk_Dojwisediff.Checked = True Then
            If chk_dt_summary.Checked = True Then
                'Call membership_noofyears_summary()
            ElseIf chk_dt_details.Checked = True Then
                Call membership_noofyears_summary()
            End If
        ElseIf Chk_History.Checked = True Then
            Call Member_Status_History_report()
        ElseIf chk_expiry_det.Checked = True Then
            Call member_expiry_det_report()
        ElseIf chk_expired_det.Checked = True Then
            Call member_expired_det_report()
        ElseIf chk_terminate_det.Checked = True Then
            Call member_termination_det_report()
        ElseIf Chk_Memsta.Checked = True Then
            Call Member_Status_History_report1()
        End If


    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub chk_STATUS_CheckedChanged(sender As Object, e As EventArgs) Handles chk_STATUS.CheckedChanged
        Dim Iteration As Integer
        If chk_STATUS.Checked = True Then
            Try
                For Iteration = 0 To (ChK_Memberstatus.Items.Count - 1)
                    ChK_Memberstatus.SetSelected(Iteration, True)
                    ChK_Memberstatus.SetItemChecked(Iteration, True)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                For Iteration = 0 To (ChK_Memberstatus.Items.Count - 1)
                    ChK_Memberstatus.SetItemChecked(Iteration, False)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub chk_PrintAll_CheckedChanged(sender As Object, e As EventArgs) Handles chk_PrintAll.CheckedChanged
        Dim Iteration As Integer
        If chk_PrintAll.Checked = True Then
            Try
                For Iteration = 0 To (chk_Filter_Field.Items.Count - 1)
                    chk_Filter_Field.SetSelected(Iteration, True)
                    chk_Filter_Field.SetItemChecked(Iteration, True)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                For Iteration = 0 To (chk_Filter_Field.Items.Count - 1)
                    chk_Filter_Field.SetItemChecked(Iteration, False)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub tbx_Filter_From_KeyDown(sender As Object, e As KeyEventArgs) Handles tbx_Filter_From.KeyDown
        'If tbx_Filter_From.Text = "" Then
        '    If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F4 Then
        '        Call cmd_MCodefromHelp_Click(sender, e)
        '        tbx_filter_To.Focus()
        '    End If
        'End If

        Try
            If e.KeyCode = Keys.Enter Then
                If tbx_Filter_From.Text = "" Then
                    cmd_MCodefromHelp_Click(sender, e)
                Else
                    Call txt_membercode_valid()
                End If
            ElseIf e.KeyCode = Keys.F4 Then
                cmd_MCodefromHelp_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try

    End Sub

    Private Sub cmd_MCodefromHelp_Click(sender As Object, e As EventArgs) Handles cmd_MCodefromHelp.Click
        Try
            Dim vform As New LIST_OPERATION1
            '''************************************** $ View MCODE,MNAME from Membermaster $ **************************************'''
            gSQLString = "SELECT MCODE,MNAME FROM membermaster"
            M_WhereCondition = " "
            vform.Field = "Mname,Mcode,Curentstatus"
            'vform.vFormatstring = "  Member Code  | Member Name  | Current Status                          "
            vform.vCaption = "Member Master Help"
            'vform.KeyPos = 0
            'vform.KeyPos1 = 1
            'vform.KeyPos2 = 2
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                tbx_Filter_From.Text = Trim(vform.keyfield & "")
                txt_membercode_valid()
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub
    Private Sub txt_membercode_valid()
        Sqlstr = "SELECT isnull(MCODE,'') as MCODE,isnull(MNAME,'') as MNAME,isnull(CURENTSTATUS,'') as CURENTSTATUS FROM membermaster"
        Sqlstr = Sqlstr & " where mcode='" & tbx_Filter_From.Text & "'"
        gconnection.getDataSet(Sqlstr, "membermaster")
        If gdataset.Tables("membermaster").Rows.Count > 0 Then
            tbx_Filter_From.Text = (gdataset.Tables("membermaster").Rows(0).Item("mcode"))
        Else
            MessageBox.Show("INVALID MEMBER CODE", tbx_Filter_From.Text)
            tbx_Filter_From.Focus()
            tbx_Filter_From.Text = ""
            Exit Sub
        End If
    End Sub
    Private Sub txt_membercodeTO_valid()
        Sqlstr = "SELECT isnull(MCODE,'') as MCODE,isnull(MNAME,'') as MNAME,isnull(CURENTSTATUS,'') as CURENTSTATUS FROM membermaster"
        Sqlstr = Sqlstr & " where mcode='" & tbx_filter_To.Text & "'"
        gconnection.getDataSet(Sqlstr, "membermaster")
        If gdataset.Tables("membermaster").Rows.Count > 0 Then
            tbx_filter_To.Text = (gdataset.Tables("membermaster").Rows(0).Item("mcode"))
        Else
            MessageBox.Show("INVALID MEMBER CODE", tbx_filter_To.Text)
            tbx_filter_To.Focus()
            tbx_filter_To.Text = ""
            Exit Sub
        End If
    End Sub
    Private Sub chkfilterfield()
        Dim i As Long
        status = ""
        DispString = ""
        Try
            For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                If i = 0 Then
                    TempString = Split((chk_Filter_Field.Text), ".")
                    TempString = Split((chk_Filter_Field.CheckedItems.Item(i)), ".")
                    DispString = Trim(TempString(1))
                    addFltrStr = FltrStr & Trim(TempString(selectNo))
                Else
                    TempString = Split((chk_Filter_Field.CheckedItems.Item(i)), ".")
                    DispString = Trim(DispString) & "," & Trim(TempString(1))
                    addFltrStr = addFltrStr & "','" & Trim(TempString(selectNo))
                End If
            Next i
            For i = 0 To ChK_Memberstatus.CheckedItems.Count - 1
                If i = 0 Then
                    TempString = Split((ChK_Memberstatus.CheckedItems.Item(i)), ".")
                    status = TempString(1)
                Else
                    TempString = Split((ChK_Memberstatus.CheckedItems.Item(i)), ".")
                    status = status & "','" & TempString(1)
                End If
            Next i
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub tbx_filter_To_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbx_filter_To.KeyDown
        'If tbx_filter_To.Text = "" Then
        '    If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F4 Then
        '        cmd_MCodeToHelp_Click(sender, e)
        '    End If
        'End If
        Try
            If e.KeyCode = Keys.Enter Then
                If tbx_filter_To.Text = "" Then
                    cmd_MCodeToHelp_Click(sender, e)
                Else
                    Call txt_membercodeTO_valid()
                End If
            ElseIf e.KeyCode = Keys.F4 Then
                cmd_MCodeToHelp_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub
    Private Sub chk_Filter_Field_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            tbx_Filter_From.Focus()
        End If
    End Sub
    Private Sub tbx_Filter_From_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Filter_From.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            tbx_filter_To.Focus()
        End If
    End Sub
    Private Sub tbx_filter_To_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_filter_To.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            btn_view.Focus()
        End If
    End Sub
    Public Sub Summary()
        'Try
        '    Dim SQL As String
        '    Dim Viewer As New REPORTVIEWER
        '    Dim r As New Cry_MemberStatus_summay
        '    SQL = "SELECT * FROM VW_MEMBERSTATUS_SUMMARY"

        '    txtCategory.Text = ""
        '    txtStatus.Text = ""
        '    Dim o As Object
        '    For Each o In chk_Filter_Field.CheckedItems
        '        txtCategory.Text += "'" & o.ToString() & "',"
        '    Next o
        '    Dim j As Object
        '    For Each j In ChK_Memberstatus.CheckedItems
        '        txtStatus.Text += "'" & j.ToString() & "',"
        '    Next j
        '    txtobj1 = r.ReportDefinition.ReportObjects("Text1")
        '    txtobj1.Text = UCase(gcompanyname)
        '    txtobj1 = r.ReportDefinition.ReportObjects("Text2")
        '    txtobj1.Text = UCase(gCompanyAddress(1))
        '    txtobj1 = r.ReportDefinition.ReportObjects("Text3")
        '    txtobj1.Text = UCase(gCompanyAddress(2))
        '    'txtobj1 = r.ReportDefinition.ReportObjects("Text4")
        '    'txtobj1.Text = UCase(gCompanyAddress(3))
        '    'txtobj1 = r.ReportDefinition.ReportObjects("Text5")
        '    'txtobj1.Text = UCase(gCompanyAddress(4))
        '    txtobj1 = r.ReportDefinition.ReportObjects("Text16")
        '    txtobj1.Text = UCase(gFinancalyearStart)
        '    txtobj1 = r.ReportDefinition.ReportObjects("Text22")
        '    txtobj1.Text = UCase(gFinancialyearEnd)

        '    txtobj1 = r.ReportDefinition.ReportObjects("Text14")
        '    txtobj1.Text = UCase(gUsername)

        '    SQL = SQL & " where TypeDesc in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ") and CURENTSTATUS in (" & txtStatus.Text.Substring(0, txtStatus.Text.Length - 1) & ")"
        '    SQL = SQL & " ORDER BY membertypecode asc"

        '    Viewer.ssql = SQL
        '    Viewer.Report = r
        '    Viewer.TableName = "VW_MEMBERSTATUS_SUMMARY"
        '    Viewer.Show()

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try

        Try
            Dim SQL As String
            Dim Viewer As New REPORTVIEWER
            Dim r As New Cry_MemberStatus_summay
            SQL = "SELECT * FROM VW_MEMBERSTATUS_SUMMARY"

            txtCategory.Text = ""
            txtStatus.Text = ""
            Dim o As Object
            For Each o In chk_Filter_Field.CheckedItems
                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            Dim j As Object
            For Each j In ChK_Memberstatus.CheckedItems
                txtStatus.Text += "'" & j.ToString() & "',"
            Next j
            SQL = SQL & " where TypeDesc in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ") and CURENTSTATUS in (" & txtStatus.Text.Substring(0, txtStatus.Text.Length - 1) & ")"
            SQL = SQL & " ORDER BY membertypecode asc"
            gconnection.getDataSet(SQL, "VW_MEMBERSTATUS_SUMMARY")
            If gdataset.Tables("VW_MEMBERSTATUS_SUMMARY").Rows.Count > 0 Then
                Viewer.ssql = SQL
                Viewer.Report = r
                Viewer.TableName = "VW_MEMBERSTATUS_SUMMARY"
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
                txtobj1 = r.ReportDefinition.ReportObjects("Text17")
                txtobj1.Text = UCase(gCompanyAddress(4))
                txtobj1 = r.ReportDefinition.ReportObjects("Text23")
                txtobj1.Text = UCase(gCompanyAddress(5))

                txtobj1 = r.ReportDefinition.ReportObjects("Text16")
                txtobj1.Text = UCase(gFinancalyearStart)
                txtobj1 = r.ReportDefinition.ReportObjects("Text22")
                txtobj1.Text = UCase(gFinancialyearEnd)

                txtobj1 = r.ReportDefinition.ReportObjects("Text14")
                txtobj1.Text = UCase(gUsername)

                Viewer.Show()
            Else
                MsgBox("NO RECORD FOR THIS CONDITION ! ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub Member_Status_det_report()
        Try
            Dim SQL, EFF As String
            Dim Viewer As New REPORTVIEWER
            Dim r As New Cry_MemberStatusdetails
            SQL = "SELECT * FROM MM_MEMBERMASTER"
            txtCategory.Text = ""
            txtStatus.Text = ""
            Dim o As Object
            For Each o In chk_Filter_Field.CheckedItems
                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            Dim j As Object
            For Each j In ChK_Memberstatus.CheckedItems
                txtStatus.Text += "'" & j.ToString() & "',"
            Next j

            SQL = SQL & " where MemberType in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ") and CURENTSTATUS in (" & txtStatus.Text.Substring(0, txtStatus.Text.Length - 1) & ")"
            SQL = SQL & " ORDER BY membertypecode asc"
            gconnection.getDataSet(SQL, "MM_MEMBERMASTER")

            If gdataset.Tables("MM_MEMBERMASTER").Rows.Count > 0 Then
                Viewer.ssql = SQL
                Viewer.Report = r
                Viewer.TableName = "MM_MEMBERMASTER"

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
                txtobj1 = r.ReportDefinition.ReportObjects("Text19")
                txtobj1.Text = UCase(gCompanyAddress(4))
                txtobj1 = r.ReportDefinition.ReportObjects("Text21")
                txtobj1.Text = UCase(gCompanyAddress(5))


                txtobj1 = r.ReportDefinition.ReportObjects("Text16")
                txtobj1.Text = UCase(gFinancalyearStart)
                txtobj1 = r.ReportDefinition.ReportObjects("Text22")
                txtobj1.Text = UCase(gFinancialyearEnd)

                txtobj1 = r.ReportDefinition.ReportObjects("Text23")
                txtobj1.Text = UCase(gUsername)
                Viewer.Show()

            Else
                MsgBox("NO RECORD FOR THIS CONDITION ! ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub Member_details_doj_report()
        Try
            Dim SQL As String
            Dim Viewer As New REPORTVIEWER
            Dim r As New Cry_memberdetails_doj
            SQL = "SELECT * FROM MM_MEMBERMASTER"
            txtCategory.Text = ""
            txtStatus.Text = ""
            Dim o As Object
            For Each o In chk_Filter_Field.CheckedItems
                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            Dim j As Object
            For Each j In ChK_Memberstatus.CheckedItems
                txtStatus.Text += "'" & j.ToString() & "',"
            Next j
            If (txtCategory.Text <> "") Then
                SQL = SQL & " where MemberType in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ") and curentstatus in (" & txtStatus.Text.Substring(0, txtStatus.Text.Length - 1) & ")"
            End If
            If (tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "") Then
                SQL = SQL & " and mcode between '" & tbx_Filter_From.Text & "' and '" & tbx_filter_To.Text & "'"
            End If
            If (Dtp_From.Text <> "" And Dtp_To.Text <> "") Then
                SQL = SQL & " and doj between Convert(datetime,'" & Dtp_From.Text & "',103) and Convert(datetime,'" & Dtp_To.Text & "',103)"
            End If
            gconnection.getDataSet(SQL, "MM_MEMBERMASTER")

            If gdataset.Tables("MM_MEMBERMASTER").Rows.Count > 0 Then
                Viewer.ssql = SQL
                Viewer.Report = r
                Viewer.TableName = "MM_MEMBERMASTER"
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
                txtobj1 = r.ReportDefinition.ReportObjects("Text21")
                txtobj1.Text = UCase(gCompanyAddress(4))
                txtobj1 = r.ReportDefinition.ReportObjects("Text23")
                txtobj1.Text = UCase(gCompanyAddress(5))


                txtobj1 = r.ReportDefinition.ReportObjects("Text19")
                txtobj1.Text = UCase(gFinancalyearStart)
                txtobj1 = r.ReportDefinition.ReportObjects("Text22")
                txtobj1.Text = UCase(gFinancialyearEnd)

                txtobj1 = r.ReportDefinition.ReportObjects("Text27")
                txtobj1.Text = UCase(gUsername)
                Viewer.Show()
            Else
                MsgBox("NO RECORD FOR THIS CONDITION ! ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub membership_noofyears_summary()
        Try
            Dim SQL As String
            Dim Viewer As New REPORTVIEWER
            Dim r As New Cry_membership_doj_summary
            SQL = "SELECT * FROM MM_VIEW_DATEOFJOIN"
            txtCategory.Text = ""
            txtStatus.Text = ""
            Dim o As Object
            For Each o In chk_Filter_Field.CheckedItems
                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            Dim j As Object
            For Each j In ChK_Memberstatus.CheckedItems
                txtStatus.Text += "'" & j.ToString() & "',"
            Next j

            If (txtCategory.Text <> "") Then
                SQL = SQL & " where MemberType in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ") and curentstatus in (" & txtStatus.Text.Substring(0, txtStatus.Text.Length - 1) & ")"
            End If

            If (tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "") Then
                SQL = SQL & " and mcode between '" & tbx_Filter_From.Text & "' and '" & tbx_filter_To.Text & "'"
            End If

            If (Dtp_From.Text <> "" And Dtp_To.Text <> "") Then
                SQL = SQL & " and doj between Convert(datetime,'" & Dtp_From.Text & "',103) and Convert(datetime,'" & Dtp_To.Text & "',103)"
            End If

            SQL = SQL & " order by mcode Asc"
            gconnection.getDataSet(SQL, "MM_VIEW_DATEOFJOIN")

            If gdataset.Tables("MM_VIEW_DATEOFJOIN").Rows.Count > 0 Then
                Viewer.ssql = SQL
                Viewer.Report = r
                Viewer.TableName = "MM_VIEW_DATEOFJOIN"

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
                txtobj1 = r.ReportDefinition.ReportObjects("Text19")
                txtobj1.Text = UCase(gCompanyAddress(4))
                txtobj1 = r.ReportDefinition.ReportObjects("Text21")
                txtobj1.Text = UCase(gCompanyAddress(5))


                txtobj1 = r.ReportDefinition.ReportObjects("Text16")
                txtobj1.Text = UCase(gFinancalyearStart)
                txtobj1 = r.ReportDefinition.ReportObjects("Text22")
                txtobj1.Text = UCase(gFinancialyearEnd)


                txtobj1 = r.ReportDefinition.ReportObjects("Text27")
                txtobj1.Text = UCase(gUsername)

                Viewer.Show()
            Else
                MsgBox("NO RECORD FOR THIS CONDITION ! ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub Member_Status_History_report1()
        Try
            Dim SQL As String

            Dim Viewer As New REPORTVIEWER
            'Dim r As New Cry_MemberStatusHistory_report
            Dim r As New CCLCry_MemberStatusHistory_report
            SQL = "SELECT * FROM MM_Memberledger1"
            txtCategory.Text = ""
            txtStatus.Text = ""
            Dim o As Object
            For Each o In chk_Filter_Field.CheckedItems
                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            Dim j As Object
            For Each j In ChK_Memberstatus.CheckedItems
                txtStatus.Text += "'" & j.ToString() & "',"
            Next j
            SQL = SQL & " where MEMBERTYPE in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ") and NEWSTATUS in (" & txtStatus.Text.Substring(0, txtStatus.Text.Length - 1) & ")"

            gconnection.getDataSet(SQL, "MM_Memberledger")

            If gdataset.Tables("MM_Memberledger").Rows.Count > 0 Then
                Viewer.ssql = SQL
                Viewer.Report = r
                Viewer.TableName = "MM_Memberledger"

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
                txtobj1 = r.ReportDefinition.ReportObjects("Text8")
                txtobj1.Text = UCase(gCompanyAddress(4))
                txtobj1 = r.ReportDefinition.ReportObjects("Text17")
                txtobj1.Text = UCase(gCompanyAddress(5))

                txtobj1 = r.ReportDefinition.ReportObjects("Text16")
                txtobj1.Text = UCase(gFinancalyearStart)
                txtobj1 = r.ReportDefinition.ReportObjects("Text22")
                txtobj1.Text = UCase(gFinancialyearEnd)
                txtobj1 = r.ReportDefinition.ReportObjects("Text27")
                txtobj1.Text = UCase(gUsername)
                Viewer.Show()
            Else
                MsgBox("NO RECORD FOR THIS CONDITION ! ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub Member_Status_History_report()
        Try
            Dim SQL As String

            Dim Viewer As New REPORTVIEWER
            Dim r As New Cry_MemberStatusHistory_report
            SQL = "SELECT * FROM MM_Memberledger"
            txtCategory.Text = ""
            txtStatus.Text = ""
            Dim o As Object
            For Each o In chk_Filter_Field.CheckedItems
                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            Dim j As Object
            For Each j In ChK_Memberstatus.CheckedItems
                txtStatus.Text += "'" & j.ToString() & "',"
            Next j
            SQL = SQL & " where MEMBERTYPE in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ") and NEWSTATUS in (" & txtStatus.Text.Substring(0, txtStatus.Text.Length - 1) & ")"
           
            gconnection.getDataSet(SQL, "MM_Memberledger")

            If gdataset.Tables("MM_Memberledger").Rows.Count > 0 Then
                Viewer.ssql = SQL
                Viewer.Report = r
                Viewer.TableName = "MM_Memberledger"

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
                txtobj1 = r.ReportDefinition.ReportObjects("Text8")
                txtobj1.Text = UCase(gCompanyAddress(4))
                txtobj1 = r.ReportDefinition.ReportObjects("Text17")
                txtobj1.Text = UCase(gCompanyAddress(5))

                txtobj1 = r.ReportDefinition.ReportObjects("Text16")
                txtobj1.Text = UCase(gFinancalyearStart)
                txtobj1 = r.ReportDefinition.ReportObjects("Text22")
                txtobj1.Text = UCase(gFinancialyearEnd)
                txtobj1 = r.ReportDefinition.ReportObjects("Text27")
                txtobj1.Text = UCase(gUsername)
                Viewer.Show()
            Else
                MsgBox("NO RECORD FOR THIS CONDITION ! ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub member_expiry_det_report()
        Try
            Dim SQL As String

            Dim Viewer As New REPORTVIEWER
            Dim r As New Cry_member_expiry_details_rpt
            SQL = "SELECT * FROM mm_expirydet_membermaster"
            txtCategory.Text = ""
            txtStatus.Text = ""
            Dim o As Object
            For Each o In chk_Filter_Field.CheckedItems
                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            Dim j As Object
           
            SQL = SQL & " where MEMBERTYPE in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ") and CURENTSTATUS in ('ACTIVE','LIVE')"
            If (Dtp_From.Text <> "" And Dtp_To.Text <> "") Then
                SQL = SQL & " AND ENDINGDATE between Convert(datetime,'" & Dtp_From.Text & "',103) and Convert(datetime,'" & Dtp_To.Text & "',103)"
            End If

            gconnection.getDataSet(SQL, "mm_expirydet_membermaster")

            If gdataset.Tables("mm_expirydet_membermaster").Rows.Count > 0 Then
                Viewer.ssql = SQL
                Viewer.Report = r
                Viewer.TableName = "mm_expirydet_membermaster"

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
                txtobj1 = r.ReportDefinition.ReportObjects("Text14")
                txtobj1.Text = UCase(gCompanyAddress(4))
                txtobj1 = r.ReportDefinition.ReportObjects("Text17")
                txtobj1.Text = UCase(gCompanyAddress(5))

                txtobj1 = r.ReportDefinition.ReportObjects("Text16")
                txtobj1.Text = UCase(gFinancalyearStart)
                txtobj1 = r.ReportDefinition.ReportObjects("Text22")
                txtobj1.Text = UCase(gFinancialyearEnd)

                txtobj1 = r.ReportDefinition.ReportObjects("Text27")
                txtobj1.Text = UCase(gUsername)

                Viewer.Show()
            Else
                MsgBox("NO RECORD FOR THIS CONDITION ! ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub member_expired_det_report()
        Try
            Dim SQL As String

            Dim Viewer As New REPORTVIEWER
            Dim r As New Cry_member_expired_details_rpt
            SQL = "SELECT * FROM mm_expirydet_membermaster"
            txtCategory.Text = ""
            txtStatus.Text = ""
            Dim o As Object
            For Each o In chk_Filter_Field.CheckedItems
                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            Dim j As Object
          
            SQL = SQL & " where MEMBERTYPE in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ") and CURENTSTATUS in ('DECEASED')"
            If (Dtp_From.Text <> "" And Dtp_To.Text <> "") Then
                SQL = SQL & " AND ENDINGDATE between Convert(datetime,'" & Dtp_From.Text & "',103) and Convert(datetime,'" & Dtp_To.Text & "',103)"
            End If


            gconnection.getDataSet(SQL, "mm_expirydet_membermaster")

            If gdataset.Tables("mm_expirydet_membermaster").Rows.Count > 0 Then
                Viewer.ssql = SQL
                Viewer.Report = r
                Viewer.TableName = "mm_expirydet_membermaster"
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

                txtobj1 = r.ReportDefinition.ReportObjects("Text17")
                txtobj1.Text = UCase(gCompanyAddress(4))
                txtobj1 = r.ReportDefinition.ReportObjects("Text19")
                txtobj1.Text = UCase(gCompanyAddress(5))



                txtobj1 = r.ReportDefinition.ReportObjects("Text16")
                txtobj1.Text = UCase(gFinancalyearStart)
                txtobj1 = r.ReportDefinition.ReportObjects("Text22")
                txtobj1.Text = UCase(gFinancialyearEnd)

                txtobj1 = r.ReportDefinition.ReportObjects("Text27")
                txtobj1.Text = UCase(gUsername)

                Viewer.Show()
            Else
                MsgBox("NO RECORD FOR THIS CONDITION ! ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub member_termination_det_report()
        Try
            Dim SQL As String

            Dim Viewer As New REPORTVIEWER
            Dim r As New Cry_member_termination_details_rpt
            SQL = "SELECT * FROM mm_expirydet_membermaster"
            txtCategory.Text = ""
            txtStatus.Text = ""
            Dim o As Object
            For Each o In chk_Filter_Field.CheckedItems
                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            Dim j As Object
            SQL = SQL & " where MEMBERTYPE in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ") and CURENTSTATUS in ('TERMINATION','TERMINATE','TERMINATED')"
            If (tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "") Then
                SQL = SQL & " and  mcode between '" & tbx_Filter_From.Text & "' and '" & tbx_filter_To.Text & "'"
            End If
            If (Dtp_From.Text <> "" And Dtp_To.Text <> "") Then
                SQL = SQL & " AND ENDINGDATE between Convert(datetime,'" & Dtp_From.Text & "',103) and Convert(datetime,'" & Dtp_To.Text & "',103)"
            End If
            gconnection.getDataSet(SQL, "mm_expirydet_membermaster")

            If gdataset.Tables("mm_expirydet_membermaster").Rows.Count > 0 Then

                Viewer.ssql = SQL
                Viewer.Report = r
                Viewer.TableName = "mm_expirydet_membermaster"

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
                txtobj1 = r.ReportDefinition.ReportObjects("Text14")
                txtobj1.Text = UCase(gCompanyAddress(4))
                txtobj1 = r.ReportDefinition.ReportObjects("Text17")
                txtobj1.Text = UCase(gCompanyAddress(5))

                txtobj1 = r.ReportDefinition.ReportObjects("Text16")
                txtobj1.Text = UCase(gFinancalyearStart)
                txtobj1 = r.ReportDefinition.ReportObjects("Text22")
                txtobj1.Text = UCase(gFinancialyearEnd)
                txtobj1 = r.ReportDefinition.ReportObjects("Text27")
                txtobj1.Text = UCase(gUsername)
                Viewer.Show()
            Else
                MsgBox("NO RECORD FOR THIS CONDITION ! ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub cmd_MCodeToHelp_Click(sender As Object, e As EventArgs) Handles cmd_MCodeToHelp.Click
        Try
            Dim vform As New LIST_OPERATION1
            '''************************************** $ View MCODE,MNAME from Membermaster $ **************************************'''
            gSQLString = "SELECT MCODE,MNAME FROM membermaster"
            M_WhereCondition = " "
            vform.Field = "Mname,Mcode,Curentstatus"
            'vform.vFormatstring = "  Member Code  | Member Name  | Current Status                          "
            vform.vCaption = "Member Master Help"
            'vform.KeyPos = 0
            'vform.KeyPos1 = 1
            'vform.KeyPos2 = 2
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                tbx_filter_To.Text = Trim(vform.keyfield & "")
                txt_membercodeTO_valid()
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub

    Private Sub Chk_sumry_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_sumry.CheckedChanged
        If Chk_sumry.Checked = True Then
            GroupBox3.Visible = False
            GroupBox5.Visible = False
            chk_member_status_sum.Checked = False
            Chk_details.Checked = False
            Chk_Dojwisediff.Checked = False
            Chk_History.Checked = False
            chk_expiry_det.Checked = False
            chk_expired_det.Checked = False
            chk_terminate_det.Checked = False
            'Else
            '    GroupBox3.Visible = True
        End If
    End Sub

    Private Sub chk_member_status_sum_CheckedChanged(sender As Object, e As EventArgs) Handles chk_member_status_sum.CheckedChanged
        If chk_member_status_sum.Checked = True Then
            GroupBox3.Visible = False
            GroupBox5.Visible = False
            Chk_sumry.Checked = False
            Chk_details.Checked = False
            Chk_Dojwisediff.Checked = False
            Chk_History.Checked = False
            chk_expiry_det.Checked = False
            chk_expired_det.Checked = False
            chk_terminate_det.Checked = False
            'Else
            '    GroupBox3.Visible = True
        End If
    End Sub

    Private Sub Chk_details_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_details.CheckedChanged
        If Chk_details.Checked = True Then
            Label4.Text = "Date of Join From"
            Label5.Text = "Date of Join To"
            GroupBox3.Visible = True
            GroupBox5.Visible = False
            Chk_sumry.Checked = False
            chk_member_status_sum.Checked = False
            Chk_Dojwisediff.Checked = False
            Chk_History.Checked = False
            chk_expiry_det.Checked = False
            chk_expired_det.Checked = False
            chk_terminate_det.Checked = False
        Else
            GroupBox3.Visible = True
            Label4.Text = "From Date "
            Label5.Text = "To Date "
        End If
    End Sub

    Private Sub Chk_Dojwisediff_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Dojwisediff.CheckedChanged
        If Chk_Dojwisediff.Checked = True Then
            Label4.Text = "Date of Join From"
            Label5.Text = "Date of Join To"
            GroupBox3.Visible = True
            GroupBox5.Visible = True
            Chk_sumry.Checked = False
            chk_member_status_sum.Checked = False
            Chk_details.Checked = False
            Chk_History.Checked = False
            chk_expiry_det.Checked = False
            chk_expired_det.Checked = False
            chk_terminate_det.Checked = False
        Else
            GroupBox3.Visible = True
            GroupBox5.Visible = False
            Label4.Text = "Effective From"
            Label5.Text = "Effective To"
        End If
    End Sub

    Private Sub chk_dt_summary_CheckedChanged(sender As Object, e As EventArgs) Handles chk_dt_summary.CheckedChanged
        If chk_dt_summary.Checked = True Then
            chk_dt_details.Checked = False
        End If
    End Sub

    Private Sub chk_dt_details_CheckedChanged(sender As Object, e As EventArgs) Handles chk_dt_details.CheckedChanged
        If chk_dt_details.Checked = True Then
            chk_dt_summary.Checked = False

        End If
    End Sub

    Private Sub Chk_History_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_History.CheckedChanged
        If (Chk_History.Checked = True) Then
            'Label4.Text = "Effective From"
            'Label5.Text = "Effective To"
            GroupBox3.Visible = False
            GroupBox5.Visible = False
            Chk_sumry.Checked = False
            chk_member_status_sum.Checked = False
            Chk_details.Checked = False
            Chk_Dojwisediff.Checked = False
            chk_expiry_det.Checked = False
            chk_expired_det.Checked = False
            chk_terminate_det.Checked = False
            'Else
            '    GroupBox3.Visible = True

        End If
    End Sub

    Private Sub chk_expiry_det_CheckedChanged(sender As Object, e As EventArgs) Handles chk_expiry_det.CheckedChanged
        If (chk_expiry_det.Checked = True) Then
            Label4.Text = "Expiry From"
            Label5.Text = "Expiry To"
            GroupBox3.Visible = True
            GroupBox5.Visible = False
            Chk_sumry.Checked = False
            chk_member_status_sum.Checked = False
            Chk_details.Checked = False
            Chk_Dojwisediff.Checked = False
            Chk_History.Checked = False
            chk_expiry_det.Checked = True
            chk_expired_det.Checked = False
            chk_terminate_det.Checked = False
        Else
            GroupBox3.Visible = True
            Label4.Text = "Effective From"
            Label5.Text = "Effective To"
        End If
    End Sub

    Private Sub chk_expired_det_CheckedChanged(sender As Object, e As EventArgs) Handles chk_expired_det.CheckedChanged
        If (chk_expired_det.Checked = True) Then
            Label4.Text = "Expiry From"
            Label5.Text = "Expiry To"
            GroupBox3.Visible = True
            GroupBox5.Visible = False
            Chk_sumry.Checked = False
            chk_member_status_sum.Checked = False
            Chk_details.Checked = False
            Chk_Dojwisediff.Checked = False
            chk_expiry_det.Checked = False
            chk_expired_det.Checked = True
            chk_terminate_det.Checked = False
        Else
            GroupBox3.Visible = True
            Label4.Text = "Effective From"
            Label5.Text = "Effective To"
        End If
    End Sub

    Private Sub chk_terminate_det_CheckedChanged(sender As Object, e As EventArgs) Handles chk_terminate_det.CheckedChanged
        If (chk_terminate_det.Checked = True) Then
            Label4.Text = "Expiry From"
            Label5.Text = "Expiry To"
            GroupBox3.Visible = True
            GroupBox5.Visible = False
            Chk_sumry.Checked = False
            chk_member_status_sum.Checked = False
            Chk_details.Checked = False
            Chk_Dojwisediff.Checked = False
            chk_expiry_det.Checked = False
            chk_expired_det.Checked = False
            chk_terminate_det.Checked = True
        Else
            GroupBox3.Visible = True
            Label4.Text = "Effective From"
            Label5.Text = "Effective To"
        End If
    End Sub

    Private Sub tbx_Filter_From_TextChanged(sender As Object, e As EventArgs) Handles tbx_Filter_From.TextChanged

    End Sub

    Private Sub tbx_filter_To_TextChanged(sender As Object, e As EventArgs) Handles tbx_filter_To.TextChanged

    End Sub
End Class
