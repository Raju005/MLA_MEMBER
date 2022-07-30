Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient
Imports System.IO

Public Class FRM_RKGA_MEMCREDEB_ADVICE
    Dim txtobj1 As TextObject

    Private Sub FRM_RKGA_MEMCREDEB_ADVICE_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub FRM_RKGA_MEMCREDEB_ADVICE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub cmd_Clear_Click(sender As Object, e As EventArgs) Handles cmd_Clear.Click

    End Sub


    Private Sub cmd_View_Click(sender As Object, e As EventArgs) Handles cmd_View.Click
        Try
            Dim HEADING As String
            Dim cmdText, dateofbillfrom, dateofbillto, dateofweddingfrom, dateofweddingto As String
            Dim Viewer As New REPORTVIEWER
            Dim r As New Cry_Creditadvice
            If ComboBox1.Text = "CREDIT ADVICE" Then
                cmdText = "select ISNULL(voucherno,'')AS VOUCHERNO,ISNULL(voucherdate,'')AS VOUCHERDATE,slcode,sldesc,ISNULL(amount,0)AS AMOUNT from journalentry where voucherno like'CRN%' AND Accountcode='SDRS' "
                If (Fromdate.Text <> "") And (todate.Text <> "") Then
                    cmdText = cmdText & " and cast(convert(varchar(11),voucherdate,106) as datetime)between  '" & Format(Fromdate.Value, "yyyy-MM-dd") & "' and '" & Format(todate.Value, "yyyy-MM-dd") & "' "
                    'praba
                    dateofbillfrom = Fromdate.Text
                    dateofbillto = todate.Text
                    HEADING = "CREDIT ADVICE"
                    Call Viewer.GetDetails(cmdText, "journalentry", r)
                    txtobj1 = r.ReportDefinition.ReportObjects("Text26")
                    txtobj1.Text = Fromdate.Text
                    txtobj1 = r.ReportDefinition.ReportObjects("Text27")
                    txtobj1.Text = todate.Text
                    txtobj1 = r.ReportDefinition.ReportObjects("Text28")
                    txtobj1.Text = UCase(HEADING)

                    txtobj1 = r.ReportDefinition.ReportObjects("Text7")
                    txtobj1.Text = UCase(gFinancalyearStart)
                    txtobj1 = r.ReportDefinition.ReportObjects("Text22")
                    txtobj1.Text = UCase(gFinancialyearEnd)

                    ' Call Viewer.GetDetails(cmdText, "journalentry", r)
                    txtobj1 = r.ReportDefinition.ReportObjects("Text1")
                    txtobj1.Text = UCase(gCompanyname)
                    txtobj1 = r.ReportDefinition.ReportObjects("Text2")
                    txtobj1.Text = UCase(gCompanyAddress(0))
                    txtobj1 = r.ReportDefinition.ReportObjects("Text3")
                    txtobj1.Text = UCase(gCompanyAddress(1))
                    txtobj1 = r.ReportDefinition.ReportObjects("Text4")
                    txtobj1.Text = UCase(gCompanyAddress(2))
                    txtobj1 = r.ReportDefinition.ReportObjects("Text19")
                    txtobj1.Text = UCase(gCompanyAddress(3))
                    txtobj1 = r.ReportDefinition.ReportObjects("Text25")
                    txtobj1.Text = UCase(gCompanyAddress(4))


                    txtobj1 = r.ReportDefinition.ReportObjects("Text24")
                    txtobj1.Text = UCase(gUsername)
                    Viewer.ssql = cmdText
                    Viewer.Report = r
                    Viewer.TableName = "journalentry"
                    Viewer.Show()
                    ' Call Cry_Creditadvice()
                End If

                '    cmdText = cmdText & " where voucherdate in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            Else

                ComboBox1.Text = "DEBIT ADVICE"

                cmdText = "select voucherno,voucherdate,slcode,sldesc,amount from journalentry where voucherno like'DBN%' AND Accountcode='SDRS'"
                If (Fromdate.Text <> "") And (todate.Text <> "") Then
                    cmdText = cmdText & " and cast(convert(varchar(11),voucherdate,106) as datetime)between  '" & Format(Fromdate.Value, "yyyy-MM-dd") & "' and '" & Format(todate.Value, "yyyy-MM-dd") & "' "
                    Dim r1 As New Cry_Debitadvice
                    HEADING = "DEBIT ADVICE"
                    Call Viewer.GetDetails(cmdText, "journalentry", r)
                    txtobj1 = r.ReportDefinition.ReportObjects("Text26")
                    txtobj1.Text = Fromdate.Text
                    txtobj1 = r.ReportDefinition.ReportObjects("Text27")
                    txtobj1.Text = todate.Text
                    txtobj1 = r.ReportDefinition.ReportObjects("Text28")
                    txtobj1.Text = UCase(HEADING)

                    txtobj1 = r.ReportDefinition.ReportObjects("Text7")
                    txtobj1.Text = UCase(gFinancalyearStart)
                    txtobj1 = r.ReportDefinition.ReportObjects("Text22")
                    txtobj1.Text = UCase(gFinancialyearEnd)

                    ' Call Viewer.GetDetails(cmdText, "journalentry", r)
                    txtobj1 = r.ReportDefinition.ReportObjects("Text1")
                    txtobj1.Text = UCase(gCompanyname)
                    txtobj1 = r.ReportDefinition.ReportObjects("Text2")
                    txtobj1.Text = UCase(gCompanyAddress(0))
                    txtobj1 = r.ReportDefinition.ReportObjects("Text3")
                    txtobj1.Text = UCase(gCompanyAddress(1))
                    txtobj1 = r.ReportDefinition.ReportObjects("Text4")
                    txtobj1.Text = UCase(gCompanyAddress(2))

                    txtobj1 = r.ReportDefinition.ReportObjects("Text21")
                    txtobj1.Text = UCase(gCompanyAddress(3))
                    txtobj1 = r.ReportDefinition.ReportObjects("Text24")
                    txtobj1.Text = UCase(gCompanyAddress(4))


                    txtobj1 = r.ReportDefinition.ReportObjects("Text17")
                    txtobj1.Text = UCase(gUsername)
                    Viewer.ssql = cmdText
                    Viewer.Report = r
                    Viewer.TableName = "journalentry"
                    Viewer.Show()
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Fromdate_ValueChanged(sender As Object, e As EventArgs) Handles Fromdate.ValueChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub
End Class