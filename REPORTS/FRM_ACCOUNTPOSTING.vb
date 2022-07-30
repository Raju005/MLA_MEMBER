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
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Public Class FRM_ACCOUNTPOSTING
    Dim gconnection As New GlobalClass
    Private Sub Btn_close_Click(sender As Object, e As EventArgs) Handles Btn_close.Click
        Me.Close()
    End Sub
    Private Sub cmd_view_Click(sender As Object, e As EventArgs) Handles cmd_view.Click
        If Rdb_monthbillchk.Checked = True Then
            Call Monthchklst()
        ElseIf Rdb_Audit.Checked = True Then
            Call Audit()
        ElseIf Rdb_Dispatch.Checked = True Then
            Call Dispatchregister()
        End If
        'If Rdb_Dispatch.Checked = True Then
        '    Call Dispatchregister()
        'End If
    End Sub
    Private Sub Dispatchregister()
        Try
            Dim bildt, bildt1 As Date
            Dim TYPE(0), sqlstrinG As String
            Dim month1, noofdays As Integer
            '  Call Validation()
            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : noofdays = 30 : bildt = "01/apr/" & gFinancalyearStart : bildt1 = "30/apr/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31 : bildt = "01/may/" & gFinancalyearStart : bildt1 = "31/may/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30 : bildt = "01/jun/" & gFinancalyearStart : bildt1 = "30/jun/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30 : bildt = "01/jun/" & gFinancalyearStart : bildt1 = "30/jun/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31 : bildt = "01/jul/" & gFinancalyearStart : bildt1 = "31/jul/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31 : bildt = "01/aug/" & gFinancalyearStart : bildt1 = "31/aug/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30 : bildt = "01/sep/" & gFinancalyearStart : bildt1 = "30/sep/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31 : bildt = "01/oct/" & gFinancalyearStart : bildt1 = "31/oct/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30 : bildt = "01/nov/" & gFinancalyearStart : bildt1 = "30/nov/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31 : bildt = "01/dec/" & gFinancalyearStart : bildt1 = "31/dec/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31 : bildt = "01/jan/" & Mid(gFinancialyearEnd, 1, 4) : bildt1 = "31/jan/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 29 : bildt = "01/feb/" & Mid(gFinancialyearEnd, 1, 4) : bildt1 = "28/feb/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31 : bildt = "01/mar/" & Mid(gFinancialyearEnd, 1, 4) : bildt1 = "31/mar/" & gFinancalyearStart
            Dim Viewer As New REPORTVIEWER
            Dim r As New Cry_Monthdispatch
            sqlstrinG = "select m.MCODE,m.PREFIX+'   '+M.MNAME AS MNAME,BILLNO as outstanding_amt,debit_amount  from  bengal_monthbill b INNER JOIN  MEMBERMASTER m  on m.mcode=b.mcode   where month(billdate)=" & month1 & " AND isnull(debit_amount,0)<>0 ORDER BY MCODE "
            'sqlstrinG = sqlstrinG & " UNION ALL SELECT ISNULL(i.subsacctin,'') AS ACCODE,ISNULL(I.SubsDesc,'') AS GROUPNAME ,A.acdesc,SUM(k.AMOUNT) AS OPDEBITS,ISNULL(i.CostCenter,'') AS SUBGROUP FROM  SUBSPOSTING  K INNER JOIN subscriptionmast I ON k.subscode  =i.SubsCode INNER JOIN accountsglaccountmaster A ON i.subsacctin =a.accode  where month(k.billdate)=" & month1 & "  GROUP BY   i.subsacctin,A.acdesc,i.SubsDesc,i.CostCenter "
            ' sqlstrinG = sqlstrinG & " ORDER BY P.posdesc,i.salesacctin"
            Call Viewer.GetDetails1(sqlstrinG, "bengal_monthbill", r)
            Dim txtobj1 As TextObject
            Dim txtobj As TextObject
            Dim txtobj2 As TextObject
            Dim txtobj18 As TextObject
            Dim txtobj19 As TextObject
            Dim txtobj20 As TextObject
            Dim txtobj15 As TextObject
            txtobj1 = r.ReportDefinition.ReportObjects("Text4")
            txtobj1.Text = UCase(gcompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text5")
            txtobj1.Text = UCase(gCompanyAddress(0))

            txtobj1 = r.ReportDefinition.ReportObjects("Text13")
            txtobj1.Text = Format(CbxMonth.Value, "MMMM yyyy")
            'duedt = DTPduedate.Value
            'txtobj1.Text = Format(duedt, "dd/MMM/yyyy")

            'txtobj1 = r.ReportDefinition.ReportObjects("Text6")
            'txtobj1.Text = UCase(gCompanyAddress(1))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text7")
            'txtobj1.Text = UCase(gCompanyAddress(2))
            'txtobj19 = r.ReportDefinition.ReportObjects("Text6")
            'txtobj18 = r.ReportDefinition.ReportObjects("Text6")
            'txtobj19.Text = "01/" & IIf(month1 > 9, Str(month1), "0" & month1) & "/" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))
            'txtobj18.Text = noofdays & "/" & IIf(month1 > 9, Str(month1), "0" & month1) & "/" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Monthchklst()
        Try
            Dim bildt, bildt1 As Date
            Dim TYPE(0), sqlstrinG As String
            Dim month1, noofdays As Integer
            '  Call Validation()
            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : noofdays = 30 : bildt = "01/apr/" & gFinancalyearStart : bildt1 = "30/apr/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31 : bildt = "01/may/" & gFinancalyearStart : bildt1 = "31/may/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30 : bildt = "01/jun/" & gFinancalyearStart : bildt1 = "30/jun/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30 : bildt = "01/jun/" & gFinancalyearStart : bildt1 = "30/jun/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31 : bildt = "01/jul/" & gFinancalyearStart : bildt1 = "31/jul/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31 : bildt = "01/aug/" & gFinancalyearStart : bildt1 = "31/aug/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30 : bildt = "01/sep/" & gFinancalyearStart : bildt1 = "30/sep/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31 : bildt = "01/oct/" & gFinancalyearStart : bildt1 = "31/oct/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30 : bildt = "01/nov/" & gFinancalyearStart : bildt1 = "30/nov/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31 : bildt = "01/dec/" & gFinancalyearStart : bildt1 = "31/dec/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31 : bildt = "01/jan/" & Mid(gFinancialyearEnd, 1, 4) : bildt1 = "31/jan/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 29 : bildt = "01/feb/" & Mid(gFinancialyearEnd, 1, 4) : bildt1 = "28/feb/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31 : bildt = "01/mar/" & Mid(gFinancialyearEnd, 1, 4) : bildt1 = "31/mar/" & gFinancalyearStart
            Dim Viewer As New REPORTVIEWER
            Dim r As New Crpt_Monthbillchklst
            sqlstrinG = "SELECT ACCODE ,GROUPNAME ,acdesc ,SUM(OPDEBITS) as OPDEBITS ,SUBGROUP  FROM  VW_AutoPostedAccount   where month(KOTDATE)=" & month1 & "  GROUP BY ACCODE ,GROUPNAME ,acdesc,SUBGROUP ORDER BY GROUPNAME,ACCODE"
            'sqlstrinG = sqlstrinG & " UNION ALL SELECT ISNULL(i.subsacctin,'') AS ACCODE,ISNULL(I.SubsDesc,'') AS GROUPNAME ,A.acdesc,SUM(k.AMOUNT) AS OPDEBITS,ISNULL(i.CostCenter,'') AS SUBGROUP FROM  SUBSPOSTING  K INNER JOIN subscriptionmast I ON k.subscode  =i.SubsCode INNER JOIN accountsglaccountmaster A ON i.subsacctin =a.accode  where month(k.billdate)=" & month1 & "  GROUP BY   i.subsacctin,A.acdesc,i.SubsDesc,i.CostCenter "
            ' sqlstrinG = sqlstrinG & " ORDER BY P.posdesc,i.salesacctin"
            Call Viewer.GetDetails1(sqlstrinG, "accountsglaccountmaster", r)
            Dim txtobj1 As TextObject
            Dim txtobj As TextObject
            Dim txtobj2 As TextObject
            Dim txtobj18 As TextObject
            Dim txtobj19 As TextObject
            Dim txtobj20 As TextObject
            Dim txtobj15 As TextObject
            txtobj1 = r.ReportDefinition.ReportObjects("Text4")
            txtobj1.Text = UCase(gcompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text5")
            txtobj1.Text = UCase(gCompanyAddress(0))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text6")
            'txtobj1.Text = UCase(gCompanyAddress(1))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text7")
            'txtobj1.Text = UCase(gCompanyAddress(2))
            'txtobj19 = r.ReportDefinition.ReportObjects("Text6")
            'txtobj18 = r.ReportDefinition.ReportObjects("Text6")
            'txtobj19.Text = "01/" & IIf(month1 > 9, Str(month1), "0" & month1) & "/" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))
            'txtobj18.Text = noofdays & "/" & IIf(month1 > 9, Str(month1), "0" & month1) & "/" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Audit()
        Try
            Dim bildt, bildt1 As Date
            Dim TYPE(0), sqlstrinG As String
            Dim month1, noofdays As Integer
            '  Call Validation()
            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : noofdays = 30 : bildt = "01/apr/" & gFinancalyearStart : bildt1 = "30/apr/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31 : bildt = "01/may/" & gFinancalyearStart : bildt1 = "31/may/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30 : bildt = "01/jun/" & gFinancalyearStart : bildt1 = "30/jun/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30 : bildt = "01/jun/" & gFinancalyearStart : bildt1 = "30/jun/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31 : bildt = "01/jul/" & gFinancalyearStart : bildt1 = "31/jul/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31 : bildt = "01/aug/" & gFinancalyearStart : bildt1 = "31/aug/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30 : bildt = "01/sep/" & gFinancalyearStart : bildt1 = "30/sep/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31 : bildt = "01/oct/" & gFinancalyearStart : bildt1 = "31/oct/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30 : bildt = "01/nov/" & gFinancalyearStart : bildt1 = "30/nov/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31 : bildt = "01/dec/" & gFinancalyearStart : bildt1 = "31/dec/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31 : bildt = "01/jan/" & Mid(gFinancialyearEnd, 1, 4) : bildt1 = "31/jan/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 29 : bildt = "01/feb/" & Mid(gFinancialyearEnd, 1, 4) : bildt1 = "28/feb/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31 : bildt = "01/mar/" & Mid(gFinancialyearEnd, 1, 4) : bildt1 = "31/mar/" & gFinancalyearStart
            Dim Viewer As New REPORTVIEWER
            Dim r As New Cry_AccountsPosting
            sqlstrinG = "SELECT ACCODE ,GROUPNAME ,acdesc ,SUM(OPDEBITS) as OPDEBITS ,SUBGROUP  FROM  VW_AutoPostedAccount   where month(KOTDATE)=" & month1 & "  GROUP BY ACCODE ,GROUPNAME ,acdesc,SUBGROUP ORDER BY GROUPNAME,ACCODE"
            'sqlstrinG = sqlstrinG & " UNION ALL SELECT ISNULL(i.subsacctin,'') AS ACCODE,ISNULL(I.SubsDesc,'') AS GROUPNAME ,A.acdesc,SUM(k.AMOUNT) AS OPDEBITS,ISNULL(i.CostCenter,'') AS SUBGROUP FROM  SUBSPOSTING  K INNER JOIN subscriptionmast I ON k.subscode  =i.SubsCode INNER JOIN accountsglaccountmaster A ON i.subsacctin =a.accode  where month(k.billdate)=" & month1 & "  GROUP BY   i.subsacctin,A.acdesc,i.SubsDesc,i.CostCenter "
            ' sqlstrinG = sqlstrinG & " ORDER BY P.posdesc,i.salesacctin"
            Call Viewer.GetDetails1(sqlstrinG, "accountsglaccountmaster", r)
            Dim txtobj1 As TextObject
            Dim txtobj As TextObject
            Dim txtobj2 As TextObject
            Dim txtobj18 As TextObject
            Dim txtobj19 As TextObject
            Dim txtobj20 As TextObject
            Dim txtobj15 As TextObject
            txtobj1 = r.ReportDefinition.ReportObjects("Text4")
            txtobj1.Text = UCase(gcompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text5")
            txtobj1.Text = UCase(gCompanyAddress(0))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text6")
            'txtobj1.Text = UCase(gCompanyAddress(1))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text7")
            'txtobj1.Text = UCase(gCompanyAddress(2))
            'txtobj19 = r.ReportDefinition.ReportObjects("Text6")
            'txtobj18 = r.ReportDefinition.ReportObjects("Text6")
            'txtobj19.Text = "01/" & IIf(month1 > 9, Str(month1), "0" & month1) & "/" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))
            'txtobj18.Text = noofdays & "/" & IIf(month1 > 9, Str(month1), "0" & month1) & "/" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Cmd_AccPosting_Click(sender As Object, e As EventArgs) Handles Cmd_AccPosting.Click
        Try
            Dim bildt, bildt1 As Date
            Dim TYPE(0), sqlstrinG, lstPlayers As String
            Dim month1, noofdays As Integer
            '  Call Validation()
            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : noofdays = 30 : bildt = "01/apr/" & gFinancalyearStart : bildt1 = "30/apr/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31 : bildt = "01/may/" & gFinancalyearStart : bildt1 = "31/may/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30 : bildt = "01/jun/" & gFinancalyearStart : bildt1 = "30/jun/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30 : bildt = "01/jun/" & gFinancalyearStart : bildt1 = "30/jun/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31 : bildt = "01/jul/" & gFinancalyearStart : bildt1 = "31/jul/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31 : bildt = "01/aug/" & gFinancalyearStart : bildt1 = "31/aug/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30 : bildt = "01/sep/" & gFinancalyearStart : bildt1 = "30/sep/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31 : bildt = "01/oct/" & gFinancalyearStart : bildt1 = "31/oct/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30 : bildt = "01/nov/" & gFinancalyearStart : bildt1 = "30/nov/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31 : bildt = "01/dec/" & gFinancalyearStart : bildt1 = "31/dec/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31 : bildt = "01/jan/" & Mid(gFinancialyearEnd, 1, 4) : bildt1 = "31/jan/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 29 : bildt = "01/feb/" & Mid(gFinancialyearEnd, 1, 4) : bildt1 = "28/feb/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31 : bildt = "01/mar/" & Mid(gFinancialyearEnd, 1, 4) : bildt1 = "31/mar/" & gFinancalyearStart

            sqlstrinG = "SELECT  DISTINCT BILLDATE FROM SUBSPOSTING WHERE MONTH(BILLDATE)='" & month1 & "'AND ISNULL(ACCOUNTFLAG,'')='Y'"
            gconnection.getDataSet(sqlstrinG, "CheckData")
            If gdataset.Tables("CheckData").Rows.Count > 0 Then
                '  MessageBox.Show("Please Tag All Member Code In Accounts", "Important Note", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop)
                MessageBox.Show("Month bill proceed is done", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                'MessageBox.Show("Please Tag All Member Code In Accounts")
            End If

            sqlstrinG = "SELECT  DISTINCT MCODE,MNAME,curentstatus FROM MEMBERMASTER WHERE MCODE NOT in ( SELECT slcode from  ACCOUNTSSUBLEDGERMASTER WHERE ISNULL(ACCODE,'')='A4000')"
            gconnection.getDataSet(sqlstrinG, "CheckData")
            If gdataset.Tables("CheckData").Rows.Count > 0 Then
                MessageBox.Show("Please Tag All Member Code In Accounts", "Important Note", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop)
                Exit Sub
            Else
                'MessageBox.Show("Please Tag All Member Code In Accounts")
            End If
            sqlstrinG = "SELECT DISTINCT i.salesacctin,i.itemcode FROM KOT_DET k inner join ITEMMASTER I ON k.itemcode=i.itemcode WHERE isnull(k.kotstatus,'')<>'Y' AND isnull(k.delflag,'')<>'Y' AND isnull(i.salesacctin,'')=''"
            gconnection.getDataSet(sqlstrinG, "CheckData")
            If gdataset.Tables("CheckData").Rows.Count > 0 Then
                MessageBox.Show("Please Tag All Item Code In Account", "Important Note", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop)
                Exit Sub
            Else
                'MessageBox.Show("Please Tag All Member Code In Accounts")
            End If
            'sqlstrinG = "SELECT DISTINCT i.salesacctin,i.itemcode FROM KOT_DET k inner join ITEMMASTER I ON k.itemcode=i.itemcode WHERE isnull(k.kotstatus,'')<>'Y' AND isnull(k.delflag,'')<>'Y' AND isnull(i.salesacctin,'')=''"
            'gconnection.getDataSet(sqlstrinG, "CheckData")
            'If gdataset.Tables("CheckData").Rows.Count > 0 Then
            '    MessageBox.Show("Please Tag All Item Code In Account", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation)
            '    Exit Sub
            'Else
            '    'MessageBox.Show("Please Tag All Member Code In Accounts")
            'End If
            sqlstrinG = "SELECT distinct k.MCODE,BILLDETAILS,KOTDATE FROM kot_det K INNER JOIN CommitteeTransaction T ON k.MCODE =t.DesignationCode WHERE ISNULL(KOTSTATUS ,'')<>'Y' AND ISNULL (DelFlag ,'')<>'Y' AND  MONTH(k.KOTDATE )='" & month1 & "' AND K.mcode NOT IN (select OMcode from CommBillShare)"
            gconnection.getDataSet(sqlstrinG, "CheckData")
            If gdataset.Tables("CheckData").Rows.Count > 0 Then
                MessageBox.Show("Committee Bill Pending", "Important Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop)
                Exit Sub
            Else
                'MessageBox.Show("Please Tag All Member Code In Accounts")
            End If
            sqlstrinG = "SELECT  distinct k.SLCODE,bill_no,K.DOCDATE FROM ROOMLEDGER K  WHERE ISNULL(VOIDSTATUS ,'')<>'Y' AND ISNULL (CHECKOUT ,'')='Y' AND isnull(creditdebit,'')='CREDIT' AND  MONTH(k.DOCDATE)='" & month1 & "'  AND  K.DOCNO  NOT  IN (select VoucherNo from JOURNALENTRY WHERE ISNULL(vouchertype,'')='ROOM-BILL')"
            gconnection.getDataSet(sqlstrinG, "CheckData")
            If gdataset.Tables("CheckData").Rows.Count > 0 Then
                MessageBox.Show("All room bill not Post in accounts", "Important Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop)
                Exit Sub
            Else
                'MessageBox.Show("Please Tag All Member Code In Accounts")
            End If
            sqlstrinG = "SELECT distinct k.mcode,billno,K.PARTYDATE FROM PARTY_HDR  K  WHERE ISNULL(BOOKINGTYPE ,'')='BILLING'AND  MONTH(k.PARTYDATE)='" & month1 & "'  AND k.billno  NOT  IN (select VoucherNo from JOURNALENTRY WHERE ISNULL(vouchertype,'')='PAR')"
            gconnection.getDataSet(sqlstrinG, "CheckData")
            If gdataset.Tables("CheckData").Rows.Count > 0 Then
                MessageBox.Show("All party bill not Post in accounts", "Important Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop)
                Exit Sub
            Else
                'MessageBox.Show("Please Tag All Member Code In Accounts")
            End If
            MessageBox.Show("All Checking is done you can Proceed for month bill", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'MessageBox.Show("Is Dot Net Perls awesome?", "Important Query", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FRM_ACCOUNTPOSTING_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Call Resize_Form()
        Rdb_Audit.Checked = True
        Cmd_AccPosting.Visible = False
        Button1.Visible = False
    End Sub
    Private Sub Resize_Form()
        Dim cControl As Control
        Dim i_i As Integer
        Dim J, K, L, M, n, o, P, Q, R, S, T, U As Integer
        'If (Screen.PrimaryScreen.Bounds.Height = 768) And (Screen.PrimaryScreen.Bounds.Width = 1366) Then
        '    Exit Sub
        'End If
        J = 732
        K = 1016
        Me.ResizeRedraw = True

        T = CInt(Screen.PrimaryScreen.WorkingArea.Size.Height)
        U = CInt(Screen.PrimaryScreen.WorkingArea.Size.Width)
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        If U = 800 Then
            T = T - 20
        End If
        If U = 1280 Then
            T = T - 20
        End If
        If U = 1360 Then
            T = T - 55
        End If
        If U = 1366 Then
            T = T - 55
        End If
        Me.Width = U
        Me.Height = T
        With Me
            For i_i = 0 To .Controls.Count - 1
                ' MsgBox(Controls(i_i).Name)
                If TypeOf .Controls(i_i) Is Form Then
                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0
                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If
                ElseIf TypeOf .Controls(i_i) Is Panel Then


                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        If Controls(i_i).Name = "GroupBox1" Then
                            L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))

                            If U = 800 Then
                                L = L + 50
                            End If
                            If U = 1280 Then
                                L = L + 50
                            End If
                            If U = 1360 Then
                                L = L + 75
                            End If
                            If U = 1366 Then
                                L = L + 75
                            End If
                        Else
                            L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                            ' L = L - 5
                        End If
                    End If
                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0
                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If
                    .Controls(i_i).Left = L
                    .Controls(i_i).Top = M
                    If .Controls(i_i).Size.Width = 0 Then
                        n = 0
                    Else
                        n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Size.Height = 0 Then
                        o = 0
                    Else
                        o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If
                    .Controls(i_i).Width = n
                    .Controls(i_i).Height = o

                    For Each cControl In .Controls(i_i).Controls

                        If cControl.Location.X = 0 Then
                            R = 0
                        Else
                            R = cControl.Location.X + CInt((cControl.Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                        End If
                        If cControl.Location.Y = 0 Then
                            S = 0
                        Else
                            S = cControl.Location.Y + CInt((cControl.Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                        End If

                        cControl.Left = R
                        cControl.Top = S


                        If cControl.Size.Width = 0 Then
                            P = 0
                        Else
                            P = (cControl.Size.Width + CInt((cControl.Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width)))))
                        End If

                        If cControl.Size.Height = 0 Then
                            Q = 0
                        Else
                            Q = (cControl.Size.Height + CInt((cControl.Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height)))))
                        End If

                        cControl.Width = P
                        cControl.Height = Q
                    Next
                ElseIf TypeOf .Controls(i_i) Is GroupBox Then

                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        If Controls(i_i).Name = "GroupBox1" Then
                            L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))

                            If U = 800 Then
                                L = L + 45
                            End If
                            If U = 1280 Then
                                L = L + 45
                            End If
                            If U = 1360 Then
                                L = L + 70
                            End If
                            If U = 1366 Then
                                L = L + 70
                            End If
                        Else
                            L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                            ' L = L - 5
                        End If
                    End If

                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0
                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Left = L
                    .Controls(i_i).Top = M
                    If .Controls(i_i).Size.Width = 0 Then
                        n = 0
                    Else
                        n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Size.Height = 0 Then
                        o = 0
                    Else
                        o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Width = n
                    .Controls(i_i).Height = o

                    For Each cControl In .Controls(i_i).Controls

                        If cControl.Location.X = 0 Then
                            R = 0
                        Else
                            R = cControl.Location.X + CInt((cControl.Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                        End If
                        If cControl.Location.Y = 0 Then
                            S = 0
                        Else
                            S = cControl.Location.Y + CInt((cControl.Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                        End If

                        cControl.Left = R
                        cControl.Top = S

                        If cControl.Size.Width = 0 Then
                            P = 0
                        Else
                            P = (cControl.Size.Width + CInt((cControl.Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width)))))
                        End If

                        If cControl.Size.Height = 0 Then
                            Q = 0
                        Else
                            Q = (cControl.Size.Height + CInt((cControl.Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height)))))
                        End If

                        cControl.Width = P
                        cControl.Height = Q
                    Next
                ElseIf TypeOf .Controls(i_i) Is Label Then
                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0

                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Left = L
                    .Controls(i_i).Top = M
                    If .Controls(i_i).Size.Width = 0 Then
                        n = 0
                    Else
                        n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Size.Height = 0 Then
                        o = 0
                    Else
                        o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Width = n
                    .Controls(i_i).Height = o
                ElseIf TypeOf .Controls(i_i) Is TextBox Then
                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0

                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Left = L
                    .Controls(i_i).Top = M
                    If .Controls(i_i).Size.Width = 0 Then
                        n = 0
                    Else
                        n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Size.Height = 0 Then
                        o = 0
                    Else
                        o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Width = n
                    .Controls(i_i).Height = o
                ElseIf TypeOf .Controls(i_i) Is ComboBox Then
                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0

                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Left = L
                    .Controls(i_i).Top = M
                    If .Controls(i_i).Size.Width = 0 Then
                        n = 0
                    Else
                        n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Size.Height = 0 Then
                        o = 0
                    Else
                        o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If
                    .Controls(i_i).Width = n
                    .Controls(i_i).Height = o
                ElseIf TypeOf .Controls(i_i) Is DateTimePicker Then
                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0

                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Left = L
                    .Controls(i_i).Top = M
                    If .Controls(i_i).Size.Width = 0 Then
                        n = 0
                    Else
                        n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Size.Height = 0 Then
                        o = 0
                    Else
                        o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Width = n
                    .Controls(i_i).Height = o
                ElseIf TypeOf .Controls(i_i) Is PictureBox Then
                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0

                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Left = L
                    .Controls(i_i).Top = M
                    If .Controls(i_i).Size.Width = 0 Then
                        n = 0
                    Else
                        n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Size.Height = 0 Then
                        o = 0
                    Else
                        o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Width = n
                    .Controls(i_i).Height = o
                ElseIf TypeOf .Controls(i_i) Is CheckBox Then
                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0

                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Left = L
                    .Controls(i_i).Top = M
                    If .Controls(i_i).Size.Width = 0 Then
                        n = 0
                    Else
                        n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Size.Height = 0 Then
                        o = 0
                    Else
                        o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Width = n
                    .Controls(i_i).Height = o
                ElseIf TypeOf .Controls(i_i) Is TabControl Then
                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0

                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Left = L
                    .Controls(i_i).Top = M
                    If .Controls(i_i).Size.Width = 0 Then
                        n = 0
                    Else
                        n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Size.Height = 0 Then
                        o = 0
                    Else
                        o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Width = n
                    .Controls(i_i).Height = o
                ElseIf TypeOf .Controls(i_i) Is Button Then
                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        'If Controls(i_i).Name = "Cmd_Clear" Or Controls(i_i).Name = "Cmd_Add" Or Controls(i_i).Name = "Cmd_Delete" Or Controls(i_i).Name = "Cmd_View" Or Controls(i_i).Name = "Cmd_Print" Or Controls(i_i).Name = "Cmd_Export" Or Controls(i_i).Name = "Cmd_Exit" Or Controls(i_i).Name = "Cmd_PendingBill" Or Controls(i_i).Name = "Cmd_Bill" Then
                        If Controls(i_i).Name = "cmd_Clear" Or Controls(i_i).Name = "Cmd_AccPosting" Or Controls(i_i).Name = "cmd_view" Or Controls(i_i).Name = "Button4" Or Controls(i_i).Name = "Browse" Or Controls(i_i).Name = "Button1" Then
                            L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))

                            If U = 800 Then
                                L = L + 50
                            End If
                            If U = 1280 Then
                                L = L + 50
                            End If
                            If U = 1360 Then
                                L = L + 75
                            End If
                            If U = 1366 Then
                                L = L + 75
                            End If
                        Else
                            L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                            ' L = L - 5
                        End If
                        'L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0
                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If
                    .Controls(i_i).Left = L
                    .Controls(i_i).Top = M
                    If .Controls(i_i).Size.Width = 0 Then
                        n = 0
                    Else
                        n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Size.Height = 0 Then
                        o = 0
                    Else
                        o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If
                    .Controls(i_i).Width = n
                    .Controls(i_i).Height = o
                End If
            Next i_i
        End With
    End Sub

    Private Sub Rdb_Audit_Click(sender As Object, e As EventArgs) Handles Rdb_Audit.Click
        If Rdb_Audit.Checked = True Then
            Label2.Text = "FOR THE MONTH OF :"
            Cmd_AccPosting.Visible = False
            cmd_Clear.Visible = True
            cmd_view.Visible = True
        Else
            Label2.Text = "FOR THE MONTH OF :"
            Cmd_AccPosting.Visible = True
        End If
    End Sub

    Private Sub Rdb_Monthbill_Click(sender As Object, e As EventArgs) Handles Rdb_Monthbill.Click
        If Rdb_Monthbill.Checked = True Then
            Label2.Text = "FOR THE MONTH OF :"
            Cmd_AccPosting.Visible = True
            cmd_Clear.Visible = False
            cmd_view.Visible = False
        Else
            Label2.Text = "FOR THE MONTH OF :"
            Cmd_AccPosting.Visible = False
        End If
    End Sub

    Private Sub Rdb_monthbillchk_Click(sender As Object, e As EventArgs) Handles Rdb_monthbillchk.Click
        If Rdb_monthbillchk.Checked = True Then
            Label2.Text = "FOR THE MONTH OF :"
            Cmd_AccPosting.Visible = False
            cmd_Clear.Visible = True
            cmd_view.Visible = True
        Else
            Label2.Text = "FOR THE MONTH OF :"
            Cmd_AccPosting.Visible = True
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim monthly1, monthly, chargecode, mcode1, itemtypecode, billnos, MONTHS, month1 As String
            Dim billdate, MONTHDATE, monthdate1, DUEDATE, BILLDATE1, BILLDATE2, RECDATE, OVER As Date
            Dim subscode, day, year1, dues, accounts, bill, TAXDESC As String
            Dim YEARSTART As String
            Dim CCLMONTH As Integer
            MONTHS = Format(CbxMonth.Value, "MMM")
            If MONTHS = "Apr" Then day = 30 : CCLMONTH = 4
            If MONTHS = "May" Then day = 31 : CCLMONTH = 5
            If MONTHS = "Jun" Then day = 30 : CCLMONTH = 6
            If MONTHS = "Jul" Then day = 31 : CCLMONTH = 7
            If MONTHS = "Aug" Then day = 31 : CCLMONTH = 8
            If MONTHS = "Sep" Then day = 30 : CCLMONTH = 9
            If MONTHS = "Oct" Then day = 31 : CCLMONTH = 10
            If MONTHS = "Nov" Then day = 30 : CCLMONTH = 11
            If MONTHS = "Dec" Then day = 31 : CCLMONTH = 12
            If MONTHS = "Jan" Then day = 31 : CCLMONTH = 1
            If gFinancialEnd Mod 4 = 0 Then
                If MONTHS = "Feb" Then day = 29 : CCLMONTH = 2
            Else
                If MONTHS = "Feb" Then day = 28 : CCLMONTH = 2
            End If
            If MONTHS = "Mar" Then day = 31 : CCLMONTH = 3
            'End If
            monthly = Month(Format(CbxMonth.Value, "dd/MMM/yyyy"))
            If MONTHS = "Apr" Then year1 = gFinancalyearStart : CCLMONTH = 4
            If MONTHS = "May" Then year1 = gFinancalyearStart : CCLMONTH = 5
            If MONTHS = "Jun" Then year1 = gFinancalyearStart : CCLMONTH = 6
            If MONTHS = "Jul" Then year1 = gFinancalyearStart : CCLMONTH = 7
            If MONTHS = "Aug" Then year1 = gFinancalyearStart : CCLMONTH = 8
            If MONTHS = "Sep" Then year1 = gFinancalyearStart : CCLMONTH = 9
            If MONTHS = "Oct" Then year1 = gFinancalyearStart : CCLMONTH = 10
            If MONTHS = "Nov" Then year1 = gFinancalyearStart : CCLMONTH = 11
            If MONTHS = "Dec" Then year1 = gFinancalyearStart : CCLMONTH = 12
            If MONTHS = "Jan" Then year1 = gFinancialEnd : CCLMONTH = 1
            If MONTHS = "Feb" Then year1 = gFinancialEnd : CCLMONTH = 2
            If MONTHS = "Mar" Then year1 = gFinancialEnd : CCLMONTH = 3
            'year1 = gFinancialEnd
            MONTHDATE = day & "/" & MONTHS & "/" & year1
            monthdate1 = "01/" & MONTHS & "/" & year1
            BILLDATE1 = CDate(MONTHDATE)
            BILLDATE1 = Format(MONTHDATE, "dd MMM yyyy")
            BILLDATE2 = CDate(monthdate1)
            BILLDATE2 = Format(monthdate1, "dd MMM yyyy")

            Dim sqlString, SSQL, SQL, posting As String
            sqlString = "Exec CCL_MONTHBILL '" & Format(BILLDATE1, "dd/MMM/yyyy") & "'"
            'posting = gconnection.GetValues(sqlString)
            posting = gconnection.ExcuteStoreProcedure(sqlString)

            SSQL = "Exec CP_POSTING_PARTYROOM '" & Format(BILLDATE1, "dd/MMM/yyyy") & "'"
            'posting = gconnection.GetValues(sqlString)
            posting = gconnection.ExcuteStoreProcedure(SSQL)

            SQL = "Exec proc_MEMBER_CONSUMPTION_DET  '" & CCLMONTH & "'"
            'posting = gconnection.GetValues(sqlString)
            posting = gconnection.ExcuteStoreProcedure(SQL)
            MessageBox.Show("Month bill Process Completed Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Button1.Visible = True
        Else
            Button1.Visible = False
        End If
    End Sub
End Class