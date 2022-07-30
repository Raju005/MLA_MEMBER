
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.IO
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Public Class RFM_RKGA_SUBSCRIPTIONDETAILS
    Dim gconnection As New GlobalClass
    Dim STR_STATUS, STR_TYPE, STR_OPCTION, STRSUBS As String
    Dim ssql As String

    Dim txtobj1 As TextObject

    Private Sub RFM_RKGA_SUBSCRIPTIONDETAILS_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.F9 Then
                Call cmd_View_Click(sender, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F6 Then
                Call cmd_Clear_Click(sender, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.Escape Or e.KeyCode = Keys.F11 Then
                Call Button4_Click(sender, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F2 Then
                If CHK_SUBSCRIPTION.Checked = True Then
                    CHK_SUBSCRIPTION.Checked = False
                Else
                    CHK_SUBSCRIPTION.Checked = True
                End If
                If CHK_SELECT.Checked = True Then
                    CHK_SELECT.Checked = False
                Else
                    CHK_SELECT.Checked = True
                End If
                If CHK_MEMBERCATEGORY.Checked = True Then
                    CHK_MEMBERCATEGORY.Checked = False
                Else
                    CHK_MEMBERCATEGORY.Checked = True
                End If
                If CHK_STATUS.Checked = True Then
                    CHK_STATUS.Checked = False
                Else
                    CHK_STATUS.Checked = True
                End If
                Exit Sub
            End If
            If e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
                If Button4.Enabled = True Then
                    Button4_Click(sender, e)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub RFM_RKGA_SUBSCRIPTIONDETAILS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            SYS_DATE_TIME()
            MemberType_Load()
            Member_Master_Load()
            Subscription_Master_Load()

            MemberType_Load1()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SYS_DATE_TIME()
        Dim sqlstring As String
        Try
            sqlstring = "SELECT SERVERDATE,SERVERTIME FROM VIEW_SERVER_DATETIME "
            gconnection.getDataSet(sqlstring, "SERVERDATE")
            If gdataset.Tables("SERVERDATE").Rows.Count > 0 Then
                SYSDATE = Format(gdataset.Tables("SERVERDATE").Rows(0).Item("SERVERDATE"), "dd/MM/yyyy")
            End If
        Catch ex As Exception
            MessageBox.Show("Enter a valid datetime :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub MemberType_Load()
        'Try
        '    Dim DT As New DataTable
        '    chklist_Membern.Items.Clear()
        '    ssql = " Select isnull(subtypecode,'') as Membertype,isnull(subtypedesc,'') as Typedesc From subcategorymaster "
        '    DT = gconnection.GetValues(ssql)
        '    If DT.Rows.Count > 0 Then
        '        For Iteration = 0 To (DT.Rows.Count - 1)
        '            chklist_Membern.Items.Add(DT.Rows(Iteration).Item("typedesc") & Space(70) & "." & DT.Rows(Iteration).Item("memberType"))
        '        Next
        '    Else
        '        chklist_Membern.Items.Clear()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub
    Private Sub MemberType_Load1()
        Try
            Dim DT As New DataTable
            chklist_Membern.Items.Clear()
            ssql = " Select isnull(subtypecode,'') as Membertype,isnull(subtypedesc,'') as Typedesc From subcategorymaster "
            DT = gconnection.GetValues(ssql)
            If DT.Rows.Count > 0 Then
                For Iteration = 0 To (DT.Rows.Count - 1)
                    chklist_Membern.Items.Add(DT.Rows(Iteration).Item("membertype") & "." & DT.Rows(Iteration).Item("typedesc"))
                Next
            Else
                chklist_Membern.Items.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Member_Master_Load()
        Try
            Dim DT As New DataTable
            chklist_Membern.Items.Clear()
            ssql = " Select isnull(Mcode,'') as Mcode,isnull(Mname,'') as Mname From MemberMaster "
            DT = gconnection.GetValues(ssql)
            If DT.Rows.Count > 0 Then
                For Iteration = 0 To (DT.Rows.Count - 1)
                    chklist_Membername.Items.Add(DT.Rows(Iteration).Item("Mcode") & "." & DT.Rows(Iteration).Item("Mname"))
                Next
            Else
                chklist_Membername.Items.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Subscription_Master_Load()
        Try
            Dim DT As New DataTable
            CHKLIST_SUBSCRIPTIONMAST.Items.Clear()
            ssql = " SELECT ISNULL(SUBSCODE,'') AS SUBSCODE,ISNULL(SUBSDESC,'') AS SUBSDESC FROM SUBSCRIPTIONMAST where freeze='N'  order by SUBSDESC "
            DT = gconnection.GetValues(ssql)
            If DT.Rows.Count > 0 Then
                For Iteration = 0 To (DT.Rows.Count - 1)
                    CHKLIST_SUBSCRIPTIONMAST.Items.Add(DT.Rows(Iteration).Item("SUBSCODE") & "." & DT.Rows(Iteration).Item("SUBSDESC"))
                Next
            Else
                CHKLIST_SUBSCRIPTIONMAST.Items.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chklist_Membername.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub cmd_Clear_Click(sender As Object, e As EventArgs) Handles cmd_Clear.Click
        Try
            CHK_MEMBERCATEGORY.Checked = False
            CHK_STATUS.Checked = False
            CHK_SELECT.Checked = False
            CHK_SUBSCRIPTION.Checked = False
            '  CbxMonth.Text = "April"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub cmd_View_Click(sender As Object, e As EventArgs) Handles cmd_View.Click
        Try
            Dim sqlstring, sqlstring1, bildt, mthyar, MONTH As String
            Dim MONTH1, Noofdays As Integer

            Dim Viewer As New REPORTVIEWER
            Dim txtobj1 As TextObject
            Dim txtobj2 As TextObject
            Dim txtobj3 As TextObject
            Dim txtobj4 As TextObject
            Dim txtobj5 As TextObject
            STR_OPCTION = ""
            STR_STATUS = ""
            STR_TYPE = ""
            STRSUBS = ""
            If MeValidate() = False Then Exit Sub

            If Mid(Me.CBXMONTH.Text, 1, 5) = "April" Then MONTH1 = 4 : Noofdays = 30 : bildt = "01/apr/" & Mid(gFinancalyearStart, 1, 4)
            If Mid(Me.CBXMONTH.Text, 1, 3) = "May" Then MONTH1 = 5 : Noofdays = 31 : bildt = "01/may/" & Mid(gFinancalyearStart, 1, 4)
            If Mid(Me.CBXMONTH.Text, 1, 3) = "Jun" Then MONTH1 = 6 : Noofdays = 30 : bildt = "01/jun/" & Mid(gFinancalyearStart, 1, 4)
            If Mid(Me.CBXMONTH.Text, 1, 4) = "July" Then MONTH1 = 7 : Noofdays = 31 : bildt = "01/jul/" & Mid(gFinancalyearStart, 1, 4)
            If Mid(Me.CBXMONTH.Text, 1, 6) = "August" Then MONTH1 = 8 : Noofdays = 31 : bildt = "01/aug/" & Mid(gFinancalyearStart, 1, 4)
            If Mid(Me.CBXMONTH.Text, 1, 9) = "September" Then MONTH1 = 9 : Noofdays = 30 : bildt = "01/sep/" & Mid(gFinancalyearStart, 1, 4)
            If Mid(Me.CBXMONTH.Text, 1, 7) = "October" Then MONTH1 = 10 : Noofdays = 31 : bildt = "01/oct/" & Mid(gFinancalyearStart, 1, 4)
            If Mid(Me.CBXMONTH.Text, 1, 8) = "November" Then MONTH1 = 11 : Noofdays = 30 : bildt = "01/nov/" & Mid(gFinancalyearStart, 1, 4)
            If Mid(Me.CBXMONTH.Text, 1, 8) = "December" Then MONTH1 = 12 : Noofdays = 31 : bildt = "01/dec/" & Mid(gFinancalyearStart, 1, 4)
            If Mid(Me.CBXMONTH.Text, 1, 7) = "January" Then MONTH1 = 1 : Noofdays = 31 : bildt = "01/jan/" & Mid(gFinancialyearEnd, 1, 4)
            If Mid(Me.CBXMONTH.Text, 1, 8) = "February" Then MONTH1 = 2 : Noofdays = 28 : bildt = "01/feb/" & Mid(gFinancialyearEnd, 1, 4)
            If Mid(Me.CBXMONTH.Text, 1, 5) = "March" Then MONTH1 = 3 : Noofdays = 31 : bildt = "01/mar/" & Mid(gFinancialyearEnd, 1, 4)

            If RDB_SUB_SUMMARY.Checked = True Then
                '  Dim r As New Cry_SUBS_SUMMARY
                Dim r As New Subscription_Summary
                mthyar = "SUBSCRIPTION SUMMARY FOR THE MONTH OF :"
                mthyar = mthyar & UCase(Mid(Me.CBXMONTH.Text, 1, 3)) & "-" & IIf(MONTH1 > 3, Mid(gFinancalyearStart, 7, 4), Mid(gFinancialyearEnd, 1, 4))
                sqlstring = " SELECT SUBSCODE,SUBSDESC,ISNULL(SUM(SUBAMOUNT),0) AS SUBAMOUNT,ISNULL(SUM(TAXAMOUNT),0) AS TAXAMOUNT FROM VIEW_SUBS_SUMMARY "
                sqlstring = sqlstring & " WHERE "
                sqlstring = sqlstring & " MONTH(BILLDATE)=" & MONTH1
                sqlstring = sqlstring & " GROUP BY SUBSCODE,SUBSDESC "
                sqlstring = sqlstring & " ORDER BY SUBSCODE,SUBSDESC "
                txtobj1 = r.ReportDefinition.ReportObjects("Text15")
                txtobj1.Text = mthyar
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
                txtobj1 = r.ReportDefinition.ReportObjects("Text16")
                txtobj1.Text = UCase(gCompanyAddress(4))
                txtobj1 = r.ReportDefinition.ReportObjects("Text22")
                txtobj1.Text = UCase(gCompanyAddress(5))



                txtobj1 = r.ReportDefinition.ReportObjects("Text27")
                txtobj1.Text = UCase(gUsername)

                txtobj1 = r.ReportDefinition.ReportObjects("Text17")
                txtobj1.Text = UCase(gFinancalyearStart)
                txtobj1 = r.ReportDefinition.ReportObjects("Text19")
                txtobj1.Text = UCase(gFinancialyearEnd)

                Call Viewer.GetDetails1(sqlstring, "VIEW_SUBS_SUMMARY", r)

            ElseIf Rtn_gstbill.Checked = True Then
                Dim r As New GSTSUBSBILLDETAILS
                sqlstring = " SELECT billno,billdate , a.membertype  AS MEMBERTYPE, SUBSCODE,subsdesc,billingbasis,type,  SUM(SUBSAMOUNT) AS SUBSAMOUNT, SUM(SGST) AS SGST, SUM(CGST) AS CGST, SUM(CESS) AS CESS,(SUM(SUBSAMOUNT)+SUM(SGST)+SUM(CGST)+SUM(CESS)) AS TOTAL , TAXDESC ,MCODE,MNAME,postingsno,  CONTADD1,  CONTADD2,  CONTADD3,  CONTCITY,  CONTSTATE,"
                sqlstring = sqlstring & "SUM(CGSTTAXPER) AS CGSTTAXPER,SUM(SGSTTAXPER) AS SGSTTAXPER,SUM(CESSTAXPER) AS	CESSTAXPER FROM GSTSUBSBILLDETAILS, membertype a    "
                sqlstring = sqlstring & " WHERE a.MEMBERTYPE=GSTSUBSBILLDETAILS.MEMBERTYPE and  a.TypeDesc IN  (" & STR_OPCTION & ") AND   subsdesc IN(" & STRSUBS & ") AND MCODE IN(" & STR_TYPE & ") and   MONTH(BILLDATE)=" & MONTH1
                sqlstring = sqlstring & " GROUP BY billno,billdate , a.membertype ,SUBSCODE,subsdesc,billingbasis,type , MNAME,  TAXDESC ,MCODE,postingsno,CONTADD1,  CONTADD2,  CONTADD3,  CONTCITY,  CONTSTATE "
                sqlstring = sqlstring & " ORDER BY SUBSTRING(MCODE,1,1),LEN(MCODE),ISNULL(MCODE,'')  "
                'txtobj1 = r.ReportDefinition.ReportObjects("Text1")
                'txtobj2 = r.ReportDefinition.ReportObjects("Text24")
                'txtobj3 = r.ReportDefinition.ReportObjects("Text25")
                'txtobj4 = r.ReportDefinition.ReportObjects("Text16")
                'txtobj5 = r.ReportDefinition.ReportObjects("Text27")
                sqlstring1 = "select * from master..clubmaster where datafile='" & gdatabase & "'"

                Call Viewer.GetDetails1(sqlstring, "GSTSUBSBILLDETAILS", r)
                Call Viewer.GetDetails1(sqlstring1, "clubmaster", r)


            ElseIf RDB_MEMBER_LIST_SUBS.Checked = True Then
                mthyar = "SUBSCRIPTION SUMMARY FOR THE MONTH OF :"
                mthyar = mthyar & UCase(Mid(Me.CBXMONTH.Text, 1, 3)) & "-" & IIf(MONTH1 > 3, Mid(gFinancalyearStart, 7, 4), Mid(gFinancialyearEnd, 1, 4))
                Dim r As New Cry_Subscription_Det2
                sqlstring = " SELECT MCODE,MNAME,ISNULL(SUM(AMOUNT),0) AS  AMOUNT,ISNULL(SUM(TAXAMOUNT),0) AS TAXAMOUNT,ISNULL(SUBSDESC,'') AS SUBSDESC FROM MM_SUBSCRIPTION_SUMMARY "
                sqlstring = sqlstring & " WHERE  MCODE IN(" & STR_TYPE & ") AND SUBSDESC IN(" & STRSUBS & ") "
                sqlstring = sqlstring & " AND MEMBERTYPE IN(" & STR_OPCTION & ") AND MONTH(BILLDATE)=" & MONTH1
                sqlstring = sqlstring & " GROUP BY MCODE,MNAME,SUBSDESC "
                sqlstring = sqlstring & " ORDER BY MCODE,SUBSDESC "
                txtobj1 = r.ReportDefinition.ReportObjects("Text1")
                txtobj2 = r.ReportDefinition.ReportObjects("Text24")
                txtobj3 = r.ReportDefinition.ReportObjects("Text25")
                txtobj4 = r.ReportDefinition.ReportObjects("Text16")
                txtobj5 = r.ReportDefinition.ReportObjects("Text27")
                Call Viewer.GetDetails1(sqlstring, "MM_SUBSCRIPTION_SUMMARY", r)
                '' Dim r As New Cry_Subscription_Det
                'Dim r As New Cry_subscriptiondetails
                'mthyar = " SUBSCRIPTION DETAILS FOR THE MONTH OF :"
                'mthyar = mthyar & UCase(Mid(Me.CbxMonth.Text, 1, 3)) & "-" & IIf(MONTH1 > 3, Mid(gFinancalyearStart, 7, 4), Mid(gFinancialyearEnd,1, 4))
                'sqlstring = " SELECT MCODE,MEM_NAME,MNAME,SUBSDESC,ISNULL(SUM(SUBAMOUNT),0) AS SUBAMOUNT,ISNULL(SUM(ISNULL(TAXAMOUNT,0)),0) AS TAXAMOUNT FROM VIEW_SUBS_SUMMARY "
                'sqlstring = sqlstring & " WHERE  MEMBERTYPE IN(" & STR_TYPE & ") AND CURRENTSTATUS IN(" & STR_STATUS & ") AND SUBSDESC IN(" & STRSUBS & ") "
                'sqlstring = sqlstring & " AND MCODE IN(" & STR_TYPE & ") AND MONTH(BILLDATE)=" & MONTH1
                'sqlstring = sqlstring & " GROUP BY MCODE,MEM_NAME,SUBSDESC,MNAME"
                'sqlstring = sqlstring & " ORDER BY MCODE,SUBSDESC "
                'txtobj1 = r.ReportDefinition.ReportObjects("Text16")
                'txtobj1.Text = mthyar
                'txtobj1 = r.ReportDefinition.ReportObjects("Text1")
                'txtobj1.Text = UCase(gCompanyname)
                'txtobj1 = r.ReportDefinition.ReportObjects("Text2")
                'txtobj1.Text = UCase(gCompanyAddress(0))
                'txtobj1 = r.ReportDefinition.ReportObjects("Text3")
                'txtobj1.Text = UCase(gCompanyAddress(1))
                'txtobj1 = r.ReportDefinition.ReportObjects("Text4")
                'txtobj1.Text = UCase(gCompanyAddress(2))
                'txtobj1 = r.ReportDefinition.ReportObjects("Text23")
                'txtobj1.Text = UCase(gCompanyAddress(3))
                'txtobj1 = r.ReportDefinition.ReportObjects("Text24")
                'txtobj1.Text = UCase(gCompanyAddress(4))
                'txtobj1 = r.ReportDefinition.ReportObjects("Text25")
                'txtobj1.Text = UCase(gCompanyAddress(5))


                'txtobj1 = r.ReportDefinition.ReportObjects("Text27")
                'txtobj1.Text = UCase(gUsername)
                'txtobj1 = r.ReportDefinition.ReportObjects("Text7")
                'txtobj1.Text = UCase(gFinancalyearStart)
                'txtobj1 = r.ReportDefinition.ReportObjects("Text22")
                'txtobj1.Text = UCase(gFinancialyearEnd)

                'Call Viewer.GetDetails1(sqlstring, "VIEW_MEM_REP_SUBS_FLT_MUM", r)
                'Call Viewer.GetDetails1(sqlstring, "VIEW_SUBS_SUMMARY", r)

            ElseIf RDB_Facility_List.Checked = True Then
                '  Dim r As New Cry_Facilit_mem_List
                Dim r As New Cry_MEMBERDOB
                mthyar = "FACILITY DETAILS FOR THE MONTH OF :"
                mthyar = mthyar & UCase(Mid(Me.CBXMONTH.Text, 1, 3)) & "-" & IIf(MONTH1 > 3, Mid(gFinancalyearStart, 7, 4), Mid(gFinancialyearEnd, 1, 4))
                sqlstring = " select MCODE,DNAME,SUBSDESC  FROM VIEW_FACILITY_LIST "
                sqlstring = sqlstring & " WHERE  MEMBERTYPE IN(" & STR_TYPE & ") AND CURRENTSTATUS IN(" & STR_STATUS & ") AND SUBSDESC IN(" & STRSUBS & ") "
                'sqlstring = sqlstring & " AND MCODE IN(" & STR_OPCTION & ") AND MONTH(BILLDATE)=" & MONTH1 & " AND YEAR(BILLDATE)= " & Year(CbxMonth.Value)
                sqlstring = sqlstring & " AND MCODE IN(" & STR_TYPE & ") "
                sqlstring = sqlstring & " ORDER BY MCODE "
                Call Viewer.GetDetails1(sqlstring, "VIEW_FACILITY_LIST", r)
            End If
            ' txtobj1.Text = UCase(gCompanyname)
            '   txtobj2.Text = Format(SYSDATE, "dd/MM/yyyy")
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function MeValidate() As Boolean
        Try
            MeValidate = True
            Dim MTYPECODE(0) As String

            If chklist_Membername.CheckedItems.Count > 0 Then
                For I = 0 To chklist_Membername.CheckedItems.Count - 1
                    MTYPECODE = Split(chklist_Membername.CheckedItems(I), ".")
                    STR_TYPE = STR_TYPE & " '" & Trim(MTYPECODE(0)) & "', "
                Next
                STR_TYPE = Mid(STR_TYPE, 1, Len(STR_TYPE) - 2)
                'STR_TYPE = STR_TYPE & ")"
            Else
                MsgBox("Please Select The Member Type ", vbInformation)
                MeValidate = False
                Exit Function
            End If

            If ChKLIST_Memberstatus.CheckedItems.Count > 0 Then
                For I = 0 To ChKLIST_Memberstatus.CheckedItems.Count - 1
                    MTYPECODE = Split(ChKLIST_Memberstatus.CheckedItems(I), ".")
                    STR_STATUS = STR_STATUS & " '" & Trim(MTYPECODE(1)) & "', "
                Next
                STR_STATUS = Mid(STR_STATUS, 1, Len(STR_STATUS) - 2)
            Else
                MsgBox("Please Select The Member Status Name", vbInformation)
                MeValidate = False
                Exit Function
            End If
            If chklist_Membern.CheckedItems.Count > 0 Then
                For I = 0 To chklist_Membern.CheckedItems.Count - 1
                    MTYPECODE = Split(chklist_Membern.CheckedItems(I), ".")
                    STR_OPCTION = STR_OPCTION & " '" & Trim(MTYPECODE(1)) & "', "
                Next
                STR_OPCTION = Mid(STR_OPCTION, 1, Len(STR_OPCTION) - 2)
            Else
                MsgBox("Please Select The Member Type", vbInformation)
                Exit Function
            End If

            If CHKLIST_SUBSCRIPTIONMAST.CheckedItems.Count > 0 Then
                For I = 0 To CHKLIST_SUBSCRIPTIONMAST.CheckedItems.Count - 1
                    MTYPECODE = Split(CHKLIST_SUBSCRIPTIONMAST.CheckedItems(I), ".")
                    STRSUBS = STRSUBS & " '" & Trim(MTYPECODE(1)) & "', "
                Next
                STRSUBS = Mid(STRSUBS, 1, Len(STRSUBS) - 2)
            Else
                MsgBox("Please Select The Member Subscription  Name", vbInformation)
                MeValidate = False
                Exit Function
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Private Sub CHK_MEMBERCATEGORY_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_MEMBERCATEGORY.CheckedChanged
        Try
            If CHK_MEMBERCATEGORY.Checked = True Then
                For Iteration = 0 To (chklist_Membern.Items.Count - 1)
                    chklist_Membern.SetSelected(Iteration, True)
                    chklist_Membern.SetItemChecked(Iteration, True)
                Next
            Else
                For Iteration = 0 To (chklist_Membern.Items.Count - 1)
                    chklist_Membern.SetItemChecked(Iteration, False)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CHK_SUBSCRIPTION_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_SUBSCRIPTION.CheckedChanged
        Try
            If CHK_SUBSCRIPTION.Checked = True Then
                For Iteration = 0 To (CHKLIST_SUBSCRIPTIONMAST.Items.Count - 1)
                    CHKLIST_SUBSCRIPTIONMAST.SetSelected(Iteration, True)
                    CHKLIST_SUBSCRIPTIONMAST.SetItemChecked(Iteration, True)
                Next
            Else
                For Iteration = 0 To (CHKLIST_SUBSCRIPTIONMAST.Items.Count - 1)
                    CHKLIST_SUBSCRIPTIONMAST.SetItemChecked(Iteration, False)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CHK_SELECT_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_SELECT.CheckedChanged
        Try
            If CHK_SELECT.Checked = True Then
                For Iteration = 0 To (chklist_Membername.Items.Count - 1)
                    chklist_Membername.SetSelected(Iteration, True)
                    chklist_Membername.SetItemChecked(Iteration, True)
                Next
            Else
                For Iteration = 0 To (chklist_Membername.Items.Count - 1)
                    chklist_Membername.SetItemChecked(Iteration, False)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CHK_STATUS_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_STATUS.CheckedChanged
        Try
            If CHK_STATUS.Checked = True Then
                For Iteration = 0 To (ChKLIST_Memberstatus.Items.Count - 1)
                    ChKLIST_Memberstatus.SetSelected(Iteration, True)
                    ChKLIST_Memberstatus.SetItemChecked(Iteration, True)
                Next
            Else
                For Iteration = 0 To (ChKLIST_Memberstatus.Items.Count - 1)
                    ChKLIST_Memberstatus.SetItemChecked(Iteration, False)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Try
        '    Dim sqlstring, bildt, mthyar, sqlstring1 As String
        '    Dim MONTH1, Noofdays As Integer
        '    Dim _export As New EXPORT
        '    STR_OPCTION = ""
        '    STR_STATUS = ""
        '    STR_TYPE = ""
        '    If MeValidate() = False Then Exit Sub
        '    If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then MONTH1 = 4 : Noofdays = 30 : bildt = "01/apr/" & Mid(gFinancalyearStart,1,4)
        '    If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then MONTH1 = 5 : Noofdays = 31 : bildt = "01/may/" & Mid(gFinancalyearStart,1,4)
        '    If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then MONTH1 = 6 : Noofdays = 30 : bildt = "01/jun/" & Mid(gFinancalyearStart,1,4)
        '    If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then MONTH1 = 7 : Noofdays = 31 : bildt = "01/jul/" & Mid(gFinancalyearStart,1,4)
        '    If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then MONTH1 = 8 : Noofdays = 31 : bildt = "01/aug/" & Mid(gFinancalyearStart,1,4)
        '    If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then MONTH1 = 9 : Noofdays = 30 : bildt = "01/sep/" & Mid(gFinancalyearStart,1,4)
        '    If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then MONTH1 = 10 : Noofdays = 31 : bildt = "01/oct/" & Mid(gFinancalyearStart,1,4)
        '    If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then MONTH1 = 11 : Noofdays = 30 : bildt = "01/nov/" & Mid(gFinancalyearStart,1,4)
        '    If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then MONTH1 = 12 : Noofdays = 31 : bildt = "01/dec/" & Mid(gFinancalyearStart,1,4)
        '    If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then MONTH1 = 1 : Noofdays = 31 : bildt = "01/jan/" & Mid(gFinancialyearEnd,1, 4)
        '    If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then MONTH1 = 2 : Noofdays = 28 : bildt = "01/feb/" & Mid(gFinancialyearEnd,1, 4)
        '    If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then MONTH1 = 3 : Noofdays = 31 : bildt = "01/mar/" & Mid(gFinancialyearEnd,1, 4)
        '    If RDB_SUB_SUMMARY.Checked = True Then
        '        ' Dim r As New Cry_SUBS_SUMMARY
        '        Dim r As New Cry_MEMBERDOB
        '        mthyar = "SUBSCRIPTION SUMMARY FOR THE MONTH OF :"
        '        mthyar = mthyar & UCase(Mid(Me.CbxMonth.Text, 1, 3)) & "-" & IIf(MONTH1 > 3, Mid(gFinancalyearStart, 7, 4), Mid(gFinancialyearEnd,1, 4))

        '        sqlstring = "ALTER VIEW EXP_SUBS_SUMM as SELECT SUBSCODE,SUBSDESC,ISNULL(SUM(SUBAMOUNT),0) AS SUBAMOUNT,ISNULL(SUM(TAXAMOUNT),0) AS TAXAMOUNT FROM VIEW_SUBS_SUMMARY WHERE  MEMBERTYPE IN(" & STR_TYPE & ") AND CURRENTSTATUS IN(" & STR_STATUS & ") AND MCODE IN(" & STR_OPCTION & ") AND MONTH(BILLDATE)=" & MONTH1 & " GROUP BY SUBSCODE,SUBSDESC "
        '        gconnection.dataOperation(1, sqlstring, "EXP_SUBS_SUMM")
        '        sqlstring1 = "SELECT SUBSCODE,SUBSDESC,SUBAMOUNT,TAXAMOUNT FROM EXP_SUBS_SUMM"

        '        _export.TABLENAME = "EXP_SUBS_SUMM"
        '        Call _export.export_excel(sqlstring1)
        '        _export.Show()

        '    ElseIf RDB_SUB_DETAIL.Checked = True Then
        '        mthyar = "SUBSCRIPTION SUMMARY FOR THE MONTH OF :"
        '        mthyar = mthyar & UCase(Mid(Me.CbxMonth.Text, 1, 3)) & "-" & IIf(MONTH1 > 3, Mid(gFinancalyearStart, 7, 4), Mid(gFinancialyearEnd,1, 4))
        '        '  Dim r As New Cry_Subs_Details
        '        Dim r As New Cry_MEMBERDOB
        '        sqlstring = "ALTER VIEW EXP_MEM_REP_SUB AS SELECT MCODE,MEM_NAME,ISNULL(SUM(SUBAMOUNT),0) AS  SUBAMOUNT,ISNULL(SUM(FLTAMOUNT),0) AS  FLTAMOUNT,ISNULL(SUM(MINAMOUNT),0) AS MINAMOUNT,ISNULL(SUM(TAXAMOUNT),0) AS TAXAMOUNT  FROM VIEW_MEM_REP_SUBS_FLT_MUM WHERE  MEMBERTYPE IN(" & STR_TYPE & ") AND CURRENTSTATUS IN(" & STR_STATUS & ") AND MCODE IN(" & STR_OPCTION & ") AND MONTH(BILLDATE)=" & MONTH1 & " GROUP BY MCODE,MEM_NAME "
        '        gconnection.dataOperation(1, sqlstring, "EXP_MEM_REP_SUB")
        '        sqlstring1 = "SELECT MCODE,MEM_NAME,SUBAMOUNT,FLTAMOUNT,MINAMOUNT,TAXAMOUNT FROM EXP_MEM_REP_SUB"
        '        _export.TABLENAME = "EXP_MEM_REP_SUB"
        '        Call _export.export_excel(sqlstring1)
        '        _export.Show()

        '    ElseIf RDB_MEMBER_LIST_SUBS.Checked = True Then
        '        ' Dim r As New Cry_Subscription_Det
        '        Dim r As New Cry_MEMBERDOB
        '        mthyar = " SUBSCRIPTION DETAILS FOR THE MONTH OF :"
        '        mthyar = mthyar & UCase(Mid(Me.CbxMonth.Text, 1, 3)) & "-" & IIf(MONTH1 > 3, Mid(gFinancalyearStart, 7, 4), Mid(gFinancialyearEnd,1, 4))
        '        sqlstring = " SELECT MCODE,MEM_NAME,SUBSDESC,ISNULL(SUM(SUBAMOUNT),0) AS SUBAMOUNT,ISNULL(SUM(ISNULL(TAXAMOUNT,0)),0) AS TAXAMOUNT FROM VIEW_SUBS_SUMMARY "
        '        sqlstring = sqlstring & " WHERE  MEMBERTYPE IN(" & STR_TYPE & ") AND CURRENTSTATUS IN(" & STR_STATUS & ") "
        '        sqlstring = sqlstring & " AND MCODE IN(" & STR_OPCTION & ") AND MONTH(BILLDATE)=" & MONTH1
        '        sqlstring = sqlstring & " GROUP BY MCODE,MEM_NAME,SUBSDESC "

        '        _export.TABLENAME = "VIEW_SUBS_SUMMARY"
        '        Call _export.export_excel(sqlstring)
        '        _export.Show()

        '    ElseIf RDB_Facility_List.Checked = True Then
        '        ' Dim r As New Cry_Facilit_mem_List
        '        Dim r As New Cry_MEMBERDOB
        '        mthyar = "FACILITY DETAILS FOR THE MONTH OF :"
        '        mthyar = mthyar & UCase(Mid(Me.CbxMonth.Text, 1, 3)) & "-" & IIf(MONTH1 > 3, Mid(gFinancalyearStart, 7, 4), Mid(gFinancialyearEnd,1, 4))
        '        sqlstring = " select MCODE,DNAME,SUBSDESC  FROM VIEW_FACILITY_LIST "
        '        sqlstring = sqlstring & " WHERE  MEMBERTYPE IN(" & STR_TYPE & ") AND CURRENTSTATUS IN(" & STR_STATUS & ") "
        '        sqlstring = sqlstring & " AND MCODE IN(" & STR_OPCTION & ") AND MONTH(BILLDATE)=" & MONTH1 & " AND YEAR(BILLDATE)= " & Year(CbxMonth.Text)

        '        _export.TABLENAME = "VIEW_FACILITY_LIST"
        '        Call _export.export_excel(sqlstring)
        '        _export.Show()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try

    End Sub

    Private Sub RDB_SUB_SUMMARY_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_SUB_SUMMARY.CheckedChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_Facility_List.CheckedChanged

    End Sub

    Private Sub CHKLIST_SUBSCRIPTIONMAST_KeyDown(sender As Object, e As KeyEventArgs) Handles CHKLIST_SUBSCRIPTIONMAST.KeyDown
        'Try
        '    If e.KeyCode = Keys.F7 Then
        '        Dim search As New frmListSearch
        '        search.listbox = CHKLIST_SUBSCRIPTIONMAST
        '        search.Text = "Subscription Search"
        '        search.ShowDialog(Me)
        '        Exit Sub
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub CHKLIST_SUBSCRIPTIONMAST_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CHKLIST_SUBSCRIPTIONMAST.SelectedIndexChanged

    End Sub
End Class