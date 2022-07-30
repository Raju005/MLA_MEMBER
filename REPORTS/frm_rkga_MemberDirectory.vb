Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine


Public Class frm_rkga_MemberDirectory
    Dim gconnection As New GlobalClass
    Public selectNo As Integer
    Dim txtobj1 As TextObject
    Dim cmdText, mcode, memimage, spouse, SPOUSEIMAGE As String

    Private Sub frm_rkga_MemberDirectory_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.F6 Then
                If btn_clear.Enabled = True Then
                    Call btn_clear_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F9 Then
                If btn_view.Enabled = True Then
                    Call btn_view_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F12 Then
                If btn_print.Enabled = True Then
                    Call btn_print_click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
                If btn_exit.Enabled = True Then
                    Call btn_exit_Click(sender, e)
                    Exit Sub
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    Private Sub frm_rkga_MemberDirectory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        Fillcat()
        Fillstts()
    End Sub
    Private Sub Fillcat()
        CheckBox1.Checked = False
        Dim Fill_Chk_str As String
        Select_Category.Items.Clear()
        Dim MEMBERTYPE As New DataTable
        selectNo = 0
        Fill_Chk_str = "select  subtypeCode,Subtypedesc  from subcategorymaster"
        MEMBERTYPE = gconnection.GetValues(Fill_Chk_str)
        Dim Itration
        For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
            Select_Category.Items.Add(MEMBERTYPE.Rows(Itration).Item("Subtypedesc"))
        Next
    End Sub
    Private Sub Fillstts()
        CheckBox2.Checked = False
        Try
            For Iteration = 0 To (Select_Status.Items.Count - 1)
                Select_Status.SetItemChecked(Iteration, False)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
        Me.btn_view.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.btn_view.Enabled = True
                    Me.btn_print.Enabled = True
                    Exit Sub
                End If
                If Right(x) = "V" Then
                    Me.btn_view.Enabled = True
                End If
                If Right(x) = "P" Then
                    Me.btn_print.Enabled = True
                End If
            Next
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim Iteration As Integer
        If CheckBox1.Checked = True Then
            Try
                For Iteration = 0 To (Select_Category.Items.Count - 1)
                    Select_Category.SetSelected(Iteration, True)
                    Select_Category.SetItemChecked(Iteration, True)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                For Iteration = 0 To (Select_Category.Items.Count - 1)
                    Select_Category.SetItemChecked(Iteration, False)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Dim Iteration As Integer
        If CheckBox2.Checked = True Then
            Try
                For Iteration = 0 To (Select_Status.Items.Count - 1)
                    Select_Status.SetSelected(Iteration, True)
                    Select_Status.SetItemChecked(Iteration, True)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                For Iteration = 0 To (Select_Status.Items.Count - 1)
                    Select_Status.SetItemChecked(Iteration, False)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub btn_mcodehelp_Click_1(sender As Object, e As EventArgs) Handles btn_mcodehelp.Click
        Dim vform As New LIST_OPERATION1
        gSQLString = "Select   ISNULL(MCODE,'') as MEMBEER_CODE,ISNULL(MNAME,'') AS MEMBER_NAME  from membermaster "
        M_WhereCondition = " where curentstatus='ACTIVE' "
        vform.Field = "MCODE,MNAME"
        vform.vCaption = "MEMBER MASTER HELP "
        vform.TXT_SEARCH_TXT.Select()
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_mcode2.Text = Trim(vform.keyfield & "")
            Me.mcodeFILL2()
            vform.Close()
            vform = Nothing
        End If
        gconnection.closeConnection()
    End Sub
    Private Sub mcodeFILL2()
        If Trim(txt_mcode2.Text) <> "" Then
            Dim MEMBERNAME As New DataTable
            Dim STRQUERY As String
            Dim freezeflag As String
            STRQUERY = "SELECT ISNULL(MCODE,'') as MEMBEER_CODE,ISNULL(MNAME,'') AS MEMBER_NAME  FROM MEMBERMASTER  WHERE MCODE='" & Trim(txt_mcode2.Text) & "'"
            MEMBERNAME = gconnection.GetValues(STRQUERY)
            If MEMBERNAME.Rows.Count > 0 Then
                txt_mcode2.ReadOnly = True
                txt_mcode2.Text = MEMBERNAME.Rows(0).Item("MEMBEER_CODE")
                txt_mcode2.ReadOnly = True
                txt_mcode1.Select()
            End If
        End If
    End Sub
    Private Sub mcodeFILL1()
        If Trim(txt_mcode1.Text) <> "" Then
            Dim MEMBERNAME As New DataTable
            Dim STRQUERY As String
            Dim freezeflag As String
            STRQUERY = "SELECT ISNULL(MCODE,'') as MEMBEER_CODE,ISNULL(MNAME,'') AS MEMBER_NAME  FROM MEMBERMASTER  WHERE MCODE='" & Trim(txt_mcode1.Text) & "'"
            MEMBERNAME = gconnection.GetValues(STRQUERY)
            If MEMBERNAME.Rows.Count > 0 Then
                txt_mcode1.ReadOnly = True
                txt_mcode1.Text = MEMBERNAME.Rows(0).Item("MEMBEER_CODE")
                txt_mcode1.ReadOnly = True
            End If
        End If
    End Sub
    Private Sub btn_mcodehelp1_Click(sender As Object, e As EventArgs) Handles btn_mcodehelp1.Click
        Dim vform As New LIST_OPERATION1
        gSQLString = "Select   ISNULL(MCODE,'') as MEMBEER_CODE,ISNULL(MNAME,'') AS MEMBER_NAME  from membermaster "
        M_WhereCondition = " where curentstatus='ACTIVE' "
        vform.Field = "MCODE,MNAME"
        vform.vCaption = "MEMBER MASTER HELP "
        vform.TXT_SEARCH_TXT.Select()
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_mcode1.Text = Trim(vform.keyfield & "")
            Me.mcodeFILL1()
            vform.Close()
            vform = Nothing
        End If
        gconnection.closeConnection()
    End Sub

    Private Sub txt_mcode2_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_mcode2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btn_mcodehelp_Click_1(sender, e)
        ElseIf e.KeyCode = Keys.F4 Then
            btn_mcodehelp_Click_1(sender, e)
        End If
    End Sub

    Private Sub txt_mcode2_TextChanged(sender As Object, e As EventArgs) Handles txt_mcode2.TextChanged

    End Sub
    Private Sub txt_mcode1_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_mcode1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btn_mcodehelp1_Click(sender, e)
        ElseIf e.KeyCode = Keys.F4 Then
            btn_mcodehelp1_Click(sender, e)

        End If
    End Sub

    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        If (Select_Category.CheckedItems.Count <= 0) Then
            MessageBox.Show("Select the Category Items")
            Exit Sub
        ElseIf (Select_Status.CheckedItems.Count <= 0) Then
            MessageBox.Show("Select the Status Items")
            Exit Sub
        ElseIf (Cmb_add_filter.SelectedItem = "") Then
            MessageBox.Show("Select the Address Filter")
            Exit Sub
        Else
            PRINTREP = False
            Call Memberlist1()
        End If
    End Sub
    Public Sub Memberlist1()
        Try
            If chk_photo.Checked = True Then
                memimage = "isnull(memimage,'') as memimage"
                SPOUSEIMAGE = "isnull(SPOUSEIMAGE,'') as SPOUSEIMAGE"
            Else
                memimage = "''"
                SPOUSEIMAGE = "''"
            End If
            If chk_spsname.Checked = True Then
                spouse = "isnull(SPOUSE,'') as SPOUSE"
            Else
                spouse = "''"
            End If
            If Trim(Cmb_add_filter.Text) = "Contact Address" Then
                cmdText = "select  " & memimage & "," & spouse & "," & SPOUSEIMAGE & ",MEMBERTYPE ,MNAME,SPOUSE,OCCUPATION,DOB,DOJ,WEDDING_DATE,isnull(mcode,'') as mcode,isnull(mname,'') as mname,isnull(prefix,'') as prefix,isnull(contadd1,'') as contadd1,isnull(contadd2,'') as contadd2,isnull(contadd3,'') as contadd3,isnull(contpin,'') as contpin,CONTCELL from VIEW_MM_DIRECTORY"
            ElseIf Trim(Cmb_add_filter.Text) = "Permanent Address" Then
                cmdText = "select  " & memimage & "," & spouse & "," & SPOUSEIMAGE & ",MEMBERTYPE ,MNAME,SPOUSE,OCCUPATION,DOB,DOJ,WEDDING_DATE,isnull(mcode,'') as mcode,isnull(mname,'') as mname,isnull(prefix,'') as prefix,isnull(padd1,'') as padd1,isnull(padd2,'') as padd2,isnull(padd3,'') as padd3,isnull(ppin,'') as ppin,pCELL from VIEW_MM_DIRECTORY"
            ElseIf Trim(Cmb_add_filter.Text) = "Residence Address" Then
                cmdText = "select  " & memimage & "," & spouse & "," & SPOUSEIMAGE & ",MEMBERTYPE ,MNAME,SPOUSE,OCCUPATION,DOB,DOJ,WEDDING_DATE,isnull(mcode,'') as mcode,isnull(mname,'') as mname,isnull(prefix,'') as prefix,isnull(contadd1,'') as contadd1,isnull(contadd2,'') as contadd2,isnull(contadd3,'') as contadd3,isnull(contpin,'') as contpin,CONTCELL from VIEW_MM_DIRECTORY"
            ElseIf Trim(Cmb_add_filter.Text) = "Business Address" Then
                cmdText = "select  " & memimage & "," & spouse & "," & SPOUSEIMAGE & ",MEMBERTYPE ,MNAME,SPOUSE,OCCUPATION,DOB,DOJ,WEDDING_DATE,isnull(mcode,'') as mcode,isnull(mname,'') as mname,isnull(prefix,'') as prefix,isnull(oadd1,'') as oadd1,isnull(oadd2,'') as oadd2,isnull(oadd3,'') as oadd3,isnull(opin,'') as opin,oCELL from VIEW_MM_DIRECTORY"
            End If
            Dim SQL, SQL1 As String
            Dim Viewer As New REPORTVIEWER
            txtCategory.Text = ""
            txt_status.Text = ""
            Dim o As Object
            For Each o In Select_Category.CheckedItems
                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            Dim j As Object
            For Each j In Select_Status.CheckedItems
                txt_status.Text += "'" & j.ToString() & "',"
            Next j

            cmdText = cmdText & " where MEMBERTYPE in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"

            cmdText = cmdText & " and curentstatus in (" & txt_status.Text.Substring(0, txt_status.Text.Length - 1) & ")"


            If (txt_mcode2.Text <> "" And txt_mcode1.Text <> "") Then
                cmdText = cmdText & " and mcode between '" & txt_mcode2.Text & "' and '" & txt_mcode1.Text & "'"
            End If

            'If (Dtp_From.Text <> "" And Dtp_To.Text <> "") Then
            '    SQL = SQL & " AND DOJ between Convert(datetime,'" & Dtp_From.Text & "',103) and Convert(datetime,'" & Dtp_To.Text & "',103)"
            'End If
            'SQL = SQL & " AND MEMIMAGE IS NOT NULL"
            cmdText = cmdText & " order by mcode Asc"
            If Trim(Cmb_add_filter.Text) = "Contact Address" Then
                Dim r As New Cry_Member_List_Photo
                Call Viewer.GetDetails1(cmdText, "VIEW_MM_DIRECTORY", r)
                'Call Viewer.GetDetails1(SQL1, "MEMBERIMAGE", r)
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
                txtobj1 = r.ReportDefinition.ReportObjects("Text13")
                txtobj1.Text = UCase(gCompanyAddress(4))
                txtobj1 = r.ReportDefinition.ReportObjects("Text9")
                txtobj1.Text = UCase(gCompanyAddress(5))
                txtobj1 = r.ReportDefinition.ReportObjects("Text19")
                txtobj1.Text = UCase(gFinancalyearStart)
                txtobj1 = r.ReportDefinition.ReportObjects("Text22")
                txtobj1.Text = UCase(gFinancialyearEnd)
                txtobj1 = r.ReportDefinition.ReportObjects("Text6")
                txtobj1.Text = UCase(gUsername)
                Viewer.Show()
            ElseIf Trim(Cmb_add_filter.Text) = "Permanent Address" Then
                Dim r As New Cry_Member_List_Photo1
                Call Viewer.GetDetails1(cmdText, "VIEW_MM_DIRECTORY", r)
                'Call Viewer.GetDetails1(SQL1, "MEMBERIMAGE", r)
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
                txtobj1 = r.ReportDefinition.ReportObjects("Text12")
                txtobj1.Text = UCase(gCompanyAddress(4))
                txtobj1 = r.ReportDefinition.ReportObjects("Text9")
                txtobj1.Text = UCase(gCompanyAddress(5))
                txtobj1 = r.ReportDefinition.ReportObjects("Text19")
                txtobj1.Text = UCase(gFinancalyearStart)
                txtobj1 = r.ReportDefinition.ReportObjects("Text22")
                txtobj1.Text = UCase(gFinancialyearEnd)
                txtobj1 = r.ReportDefinition.ReportObjects("Text6")
                txtobj1.Text = UCase(gUsername)
                Viewer.Show()
            ElseIf Trim(Cmb_add_filter.Text) = "Residence Address" Then
                Dim r As New Cry_Member_List_Photo
                Call Viewer.GetDetails1(cmdText, "VIEW_MM_DIRECTORY", r)
                'Call Viewer.GetDetails1(SQL1, "MEMBERIMAGE", r)
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
                txtobj1 = r.ReportDefinition.ReportObjects("Text13")
                txtobj1.Text = UCase(gCompanyAddress(4))
                txtobj1 = r.ReportDefinition.ReportObjects("Text9")
                txtobj1.Text = UCase(gCompanyAddress(5))
                txtobj1 = r.ReportDefinition.ReportObjects("Text19")
                txtobj1.Text = UCase(gFinancalyearStart)
                txtobj1 = r.ReportDefinition.ReportObjects("Text22")
                txtobj1.Text = UCase(gFinancialyearEnd)
                txtobj1 = r.ReportDefinition.ReportObjects("Text6")
                txtobj1.Text = UCase(gUsername)
                Viewer.Show()
            ElseIf Trim(Cmb_add_filter.Text) = "Business Address" Then
                Dim r As New Cry_Member_List_Photo2
                Call Viewer.GetDetails1(cmdText, "VIEW_MM_DIRECTORY", r)
                'Call Viewer.GetDetails1(SQL1, "MEMBERIMAGE", r)
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
                txtobj1 = r.ReportDefinition.ReportObjects("Text13")
                txtobj1.Text = UCase(gCompanyAddress(4))
                txtobj1 = r.ReportDefinition.ReportObjects("Text9")
                txtobj1.Text = UCase(gCompanyAddress(5))
                txtobj1 = r.ReportDefinition.ReportObjects("Text19")
                txtobj1.Text = UCase(gFinancalyearStart)
                txtobj1 = r.ReportDefinition.ReportObjects("Text22")
                txtobj1.Text = UCase(gFinancialyearEnd)

                txtobj1 = r.ReportDefinition.ReportObjects("Text6")
                txtobj1.Text = UCase(gUsername)
                Viewer.Show()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Cmb_add_filter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_add_filter.SelectedIndexChanged

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Fillcat()
        Fillstts()
        chk_photo.Checked = False
        chk_spsname.Checked = False
        txt_mcode1.Text = ""
        txt_mcode2.Text = ""
        Cmb_add_filter.Text = ""
        txt_status.Text = ""
        txtCategory.Text = ""
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub txt_mcode1_TextChanged(sender As Object, e As EventArgs) Handles txt_mcode1.TextChanged

    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click

    End Sub
    
End Class