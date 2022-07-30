Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports System.Drawing.Color
Imports System.Configuration
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Text.RegularExpressions
Imports CrystalDecisions.CrystalReports.Engine


Public Class SMSMaster
    Dim Insert(0) As String
    Dim gconnection As New GlobalClass
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            Dim sqlstring As String
            sqlstring = "delete from SMSTemplateMaster where SMSType='" & Cmb_smstype.Text & "'"
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = sqlstring
            sqlstring = "Insert into SMSTemplateMaster(SMSType,SMSdate,MsgBody,Void,Adduser,Addtatetime,TemplateID)"
            sqlstring = sqlstring & " Select '" & Cmb_smstype.Text & "','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "','" & Txt_smsbody.Text & "'"
            sqlstring = sqlstring & ",'N','" & gUsername & "','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "','" & Txt_tempid.Text & "'"
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = sqlstring
            gconnection.MoreTrans(Insert) 'All Queries Excution
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub SMSMaster_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F7 Then
            Me.btn_add_Click(sender, e)
        End If
        If (e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape) Then
            Me.btn_exit_Click(sender, e)
        End If
    End Sub

    Private Sub SMSMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim SqlString As String
            LBL_COMPANYNAME.Text = gcompanyname
            SqlString = "SELECT MONTHIMAGE as MONTHIMAGE FROM memberssetup "

            'gconnection.LoadFoto_DB_logo(SqlString, PictureBox1)
            Dim strstring As String
            strstring = "  SELECT NAME FROM SYSOBJECTS  WHERE TYPE='U' AND NAME  = 'SMSTemplateMaster'"
            gconnection.getDataSet(strstring, "A")
            If gdataset.Tables("A").Rows.Count = 0 Then
                strstring = "create table SMSTemplateMaster(SMSType varchar(50),SMSdate datetime,MsgBody varchar(250),Void varchar(1),Adduser varchar(50),Addtatetime datetime)"
                gconnection.getDataSet(strstring, "SMS")
            End If
            SqlString = " IF EXISTS(SELECT 1 FROM SYSOBJECTS WHERE NAME ='SMSTemplateMaster') AND NOT EXISTS (SELECT 1  from information_schema.COLUMNS WHERE  table_name='SMSTemplateMaster' AND column_name = 'TemplateID') BEGIN ALTER TABLE SMSTemplateMaster ADD  TemplateID varchar(100) END "
            gconnection.dataOperation(6, SqlString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cmb_smstype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_smstype.SelectedIndexChanged
        Dim Sqlstr As String
        Txt_smsbody.Text = ""
        Sqlstr = " select MsgBody,isnull(TemplateID,'') as TemplateID from SMSTemplateMaster where   SMSType='" & Cmb_smstype.Text & "'"
        gconnection.getDataSet(Sqlstr, "Sms")
        If gdataset.Tables("Sms").Rows.Count > 0 Then
            Txt_smsbody.Text = gdataset.Tables("Sms").Rows(0).Item("MsgBody")
            Txt_tempid.Text = gdataset.Tables("Sms").Rows(0).Item("TemplateID")
        End If
    End Sub

End Class