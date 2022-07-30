Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports CrystalDecisions.CrystalReports.Engine
Imports System
Imports System.Net
Imports System.Text
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.HtmlControls
Imports System.Web.UI.WebControls



Public Class GlobalClass
    Public connect As New SqlConnection
    Dim ds As DataSet
    Dim da As New SqlDataAdapter
    Public sqlconnection, sqlconnection1, vconn As String
    Public myconn As New SqlConnection
    Dim mytrans As SqlTransaction
    Dim cmd As New SqlCommand
    Dim ssql As String
    Dim DataString As String
    Dim intI As Integer
    Dim strTemp As String
    Private objProxy1 As WebProxy = Nothing
    'Public sqlconnection As String = "Data Source= " & Trim(gserver) & ";Persist Security Info=False;User ID=" & strDataSqlUsr & "; pwd=" & strDataSqlPwd & "; Initial Catalog=" & Trim(gdatabase)
    'Property farPoint As AxFPUSpreadADO.AxfpSpread
    Dim strcn As String = "data source=" & gserver & ";Persist Security Info=False;User ID= '" & SQL_UserName & "' ;Pwd= '" & SQL_Password & "'; Initial Catalog= " & gdatabase & ";"
    Public Enum genum
        Add = 1
        Update = 2
        Freeze = 3
        unFreeze = 4
        View = 5
        Delete = 6
    End Enum
   
    Public Sub SMS(ByVal MOBILE, ByVal MESSAGE)

        Dim xmlobj
        Dim strPostData As String
        Dim SQLSTRING As String
        Dim OUTSTAND As String
        Dim billdate As Date
        Dim Userid, password As String
        'Dim USERID, SID, PWD, APPID, SUBAPPID As String
        Dim i As Integer
        Dim gconnection As New GlobalClass
        SQLSTRING = "SELECT * FROM SM_SMSDETAILS"
        gconnection.getDataSet(SQLSTRING, "SM_SMSDETAILS")
        If gdataset.Tables("SM_SMSDETAILS").Rows.Count > 0 Then
            Userid = Trim(gdataset.Tables("SM_SMSDETAILS").Rows(i).Item("userid"))
            password = Trim(gdataset.Tables("SM_SMSDETAILS").Rows(i).Item("PWD"))
        End If
        Try
            ' objWebRequest = DirectCast(WebRequest.Create("http://bulk.kitesms.com/spanelv2/api.php?"), HttpWebRequest)
            xmlobj = CreateObject("msxml2.XMLHTTP")
            strPostData = "http://bulk.kitesms.com/spanelv2/api.php?username=" & Userid & "&password=" & password & "&from=NEWCLB&to=" & MOBILE & "&msg=" & MESSAGE & "&type=1&dnd_check=0"

            'strPostData = "http://<SMS_Service_URL>/api/web2sms.php?workingkey=" & Userid & "&password=" & password & "&from=NEWCLB&to=" & MOBILE & "&msg=" & MESSAGE & "&type=1&dnd_check=0"

            '            http://<SMS_Service_URL>/api/web2sms.php?workingkey=<API_KEY>&to=<MOBILENUMBER>&sen

            'der=<SENDERID>&message=<MESSAGE>

            'xmlobj.open()

            xmlobj.open("POST", strPostData, True)
            xmlobj.send()
            'MsgBox(xmlobj.responseText)
            'xmlobj = DropObject("msxml2.XMLHTTP")

            xmlobj = Nothing

        Catch
            MsgBox("Please Check Your Internet Connection")
        End Try
        'End If
    End Sub
    Public Sub PrintTextFile1(ByVal VOutputfile As String)

        Dim Filewrite As StreamWriter
        If Dir(Trim(VOutputfile & "")) <> "" Then
            'If Dir(AppPath & "\Reports\" & Trim(VOutputfile & "") & ".txt") <> "" Then
            VOutputfile = Mid(VOutputfile, 1, VOutputfile.Length - 4)
            Filewrite = File.AppendText(VOutputfile & ".bat")
            If computername = "" Or Printername = "" Then
                Filewrite.WriteLine("Type " & VOutputfile & ".txt > " & gport)
            Else
                Filewrite.WriteLine("Type " & VOutputfile & ".txt > \\" & computername & "\" & Printername)
            End If
            Filewrite.Close()
            Call Shell(VOutputfile & ".bat", vbHide)
        Else
            MsgBox(VOutputfile & " File not found", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If File.Exists(VOutputfile) Then
            File.Delete(VOutputfile)
        End If
    End Sub
    Public Sub openConnection()
        Try
            If Trim(gserver & "") <> "" Then
                sqlconnection = "Data Source=" & gserver & ";Persist Security Info=False;User ID= '" & SQL_UserName & "' ;Pwd= '" & SQL_Password & "'; Initial Catalog= " & gDatabase & ";"
            Else
                sqlconnection = "Data Source= (local);Persist Security Info=False;User ID='" & SQL_UserName & "' ;Pwd= '" & SQL_Password & "';Initial Catalog= " & gdatabase & ";"
            End If
            Call closeConnection()
            Myconn.ConnectionString = sqlconnection
            Myconn.Open()
        Catch ex As Exception
            MessageBox.Show("!! Warning !!Your system is not connected with SERVER", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Public Sub closeconnection()
        If myconn.State = ConnectionState.Open Then
            myconn.Close()
        End If
    End Sub
    Public Function Getconnection() As String
        Try
            sqlconnection = " Data Source =" & gserver & ";Persist Security Info=False;User ID='" & SQL_UserName & "' ;Pwd= '" & SQL_Password & "';Initial Catalog=" & gDatabase & ";"
            'sqlconnection = "Data Source=" & gserver & ";Persist Security Info=False;User ID=sa; Initial Catalog= " & gDatabase & ";"
            Return sqlconnection
        Catch ex As Exception
            MessageBox.Show("!! Warning !!Your system is not connected with SERVER, Bcoz " & ex.Message.ToString, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Function
        End Try
    End Function
    Public Function GetValues(ByVal ssql As String) As DataTable
        Dim Dt As New DataTable
        Dim Sqladapter As New SqlDataAdapter(ssql, myconn)
        Try
            If myconn.State <> ConnectionState.Open Then
                openConnection()
            End If
            Sqladapter.SelectCommand.CommandTimeout = 99999999
            Sqladapter.Fill(Dt)
            Return Dt
        Catch ex As Exception
            MessageBox.Show("Error in Retriveing Data as " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Function
        Finally
            closeConnection()
        End Try
    End Function
    Public Function getDataSet(ByVal strSQL As String, ByVal Tabname As String)
        Dim dt As New DataTable
        Try
            If myconn.State <> ConnectionState.Open Then
                openConnection()
            End If
            gadapter = New SqlDataAdapter(strSQL, myconn)
            gadapter.SelectCommand.CommandTimeout = 99999999
            gadapter.Fill(dt)
            dt.TableName = Tabname
            If gdataset.Tables.Contains(Tabname) = True Then
                gdataset.Tables.Remove(Tabname)
            End If
            gdataset.Tables.Add(dt)
        Catch ex As Exception
            MessageBox.Show("Error in retrieving records :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Function
        Finally
            closeconnection()
        End Try
    End Function
    Public Sub dataOperation1(ByVal genum As Integer, ByVal STR() As String)
        Dim I As Integer
        Try
            If Myconn.State <> ConnectionState.Open Then
                openConnection()
            End If
            MyTrans = Myconn.BeginTransaction()
            Select Case genum
                Case 1
                    Cmd.Transaction = MyTrans
                    Cmd.Connection = Myconn
                    Cmd.CommandTimeout = 1000000
                    For I = 0 To STR.Length - 1
                        If STR(I) Is Nothing = False Then
                            Cmd.CommandText = STR(I)
                            Cmd.CommandType = CommandType.Text
                            Cmd.ExecuteNonQuery()
                        End If
                    Next I
                    MyTrans.Commit()
                    ' MessageBox.Show("Record Saved Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case 2
                    Cmd.Transaction = MyTrans
                    Cmd.CommandTimeout = 1000000
                    Cmd.Connection = Myconn
                    For I = 0 To STR.Length - 1
                        If STR(I) Is Nothing = False Then
                            Cmd.CommandText = STR(I)
                            Cmd.CommandType = CommandType.Text
                            Cmd.ExecuteNonQuery()
                        End If
                    Next I
                    MyTrans.Commit()
                    MessageBox.Show("Record Updated Successfully ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    '''**************************** $ Freeze record into Database $ **************************'''
                Case 3
                    Cmd.Transaction = MyTrans
                    Cmd.CommandTimeout = 1000000
                    Cmd.Connection = Myconn
                    For I = 0 To STR.Length - 1
                        If STR(I) Is Nothing = False Then
                            Cmd.CommandText = STR(I)
                            Cmd.CommandType = CommandType.Text
                            Cmd.ExecuteNonQuery()
                        End If
                    Next I
                    MyTrans.Commit()
                    MessageBox.Show("Record Freezed Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    '''***************************** $ UnFreezed record into Database $ ************************'''
                Case 4
                    Cmd.Transaction = MyTrans
                    Cmd.CommandTimeout = 1000000
                    Cmd.Connection = Myconn
                    For I = 0 To STR.Length - 1
                        If STR(I) Is Nothing = False Then
                            Cmd.CommandText = STR(I)
                            Cmd.CommandType = CommandType.Text
                            Cmd.ExecuteNonQuery()
                        End If
                    Next I
                    MyTrans.Commit()
                    MessageBox.Show("Record Unfreezed Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case 5
                    Cmd.Transaction = MyTrans
                    Cmd.CommandTimeout = 1000000
                    Cmd.Connection = Myconn
                    For I = 0 To STR.Length - 1
                        If STR(I) Is Nothing = False Then
                            Cmd.CommandText = STR(I)
                            Cmd.CommandType = CommandType.Text
                            Cmd.ExecuteNonQuery()
                        End If
                    Next I
                    MyTrans.Commit()
                Case 6
                    Cmd.Transaction = MyTrans
                    Cmd.CommandTimeout = 1000000
                    Cmd.Connection = Myconn
                    For I = 0 To STR.Length - 1
                        If STR(I) Is Nothing = False Then
                            Cmd.CommandText = STR(I)
                            Cmd.CommandType = CommandType.Text
                            Cmd.ExecuteNonQuery()
                        End If
                    Next I
                    MyTrans.Commit()
            End Select


        Catch ex As Exception
            MyTrans.Rollback()
            MessageBox.Show("Error in Retriveing Data as " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Finally
            closeConnection()
        End Try
    End Sub
    Public Function ExcuteStoreProcedure(ByVal qry As String)
        Dim i As Integer
        myconn.ConnectionString = sqlconnection
        Try
            If myconn.State <> ConnectionState.Open Then
                openConnection()
            End If
            mytrans = myconn.BeginTransaction()
            cmd.CommandTimeout = 99999999
            cmd.Transaction = mytrans
            cmd.Connection = myconn
            cmd.CommandText = qry
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            mytrans.Commit()
            myconn.Close()
        Catch ex As Exception
            mytrans.Rollback()
            myconn.Close()
            MessageBox.Show("Error in Retriveing Data as " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Function
        End Try
    End Function
    Public Sub dataOperation(ByVal genum As Integer, ByVal ssql As String, Optional ByVal Tabname As String = "MyTable")
        Try
            If myconn.State <> ConnectionState.Open Then
                openConnection()
            End If
            gtrans = myconn.BeginTransaction
            Select Case genum
                '''****************************** $ Insert record into Database $ **************************'''
                Case 1
                    gcommand = New SqlCommand(ssql, myconn)
                    gcommand.Transaction = gtrans
                    gcommand.CommandTimeout = 99999999
                    gcommand.ExecuteNonQuery()
                    gtrans.Commit()
                    gcommit = True

                    'MessageBox.Show("Record Saved Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    '''**************************** $ Update record into Database $ *************************'''
                Case 2
                    gcommand = New SqlCommand(ssql, myconn)
                    gcommand.Transaction = gtrans
                    gcommand.CommandTimeout = 99999999
                    gcommand.ExecuteNonQuery()
                    gtrans.Commit()
                    gcommit = True

                    'MessageBox.Show("Record Updated Successfully ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    '''**************************** $ Freeze record into Database $ **************************'''
                Case 3
                    gcommand = New SqlCommand(ssql, myconn)
                    gcommand.Transaction = gtrans
                    gcommand.CommandTimeout = 99999999
                    gcommand.ExecuteNonQuery()
                    gtrans.Commit()
                    gcommit = True

                    'MessageBox.Show("Record Freezed Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    '''***************************** $ UnFreezed record into Database $ ************************'''
                Case 4
                    gcommand = New SqlCommand(ssql, myconn)
                    gcommand.Transaction = gtrans
                    gcommand.CommandTimeout = 99999999
                    gcommand.ExecuteNonQuery()
                    gtrans.Commit()
                    gcommit = True

                    'MessageBox.Show("Record Unfreezed Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case 5
                    '****************************** $ Always Give Full Select Statement without Any Condition $ *******'''
                    gadapter = New SqlDataAdapter(ssql, myconn)
                    If gdataset.Tables.Contains(Tabname) = True Then
                        gdataset.Tables.Remove(Tabname)
                    End If
                    gadapter.SelectCommand.CommandTimeout = 99999999
                    gadapter.Fill(gdataset.Tables(Tabname))
                    gtrans.Commit()
                    gcommit = True


                Case 6
                    gcommand = New SqlCommand(ssql, myconn)
                    gcommand.Transaction = gtrans
                    gcommand.CommandTimeout = 99999999
                    gcommand.ExecuteNonQuery()
                    gtrans.Commit()
                    gcommit = True

            End Select
        Catch ex As Exception
            gtrans.Rollback()
            gcommit = False
            MessageBox.Show("Error in Retriveing Data as " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Finally
            closeconnection()
        End Try
    End Sub

    Public Function MoreTrans(ByVal str() As String) As Boolean
        Dim i As Integer
        Try
            'Myconn.Open()
            openConnection()
            mytrans = myconn.BeginTransaction()
            cmd.Transaction = mytrans
            cmd.CommandTimeout = 1000000
            cmd.Connection = myconn
            For i = 0 To str.Length - 1
                If str(i) Is Nothing = False Then
                    cmd.CommandText = str(i)
                    cmd.CommandType = CommandType.Text
                    cmd.ExecuteNonQuery()
                End If
            Next i
            mytrans.Commit()
            MsgBox("Transaction completed suessfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, Application.ProductName)
            MoreTrans = True
            myconn.Close()
        Catch ex As Exception
            MsgBox(Err.Description & ex.Source & "Error in Transaction Operation", MsgBoxStyle.Information, Application.ProductName)
            mytrans.Rollback()
            MoreTrans = False
            myconn.Close()
        End Try
    End Function
    Public Function Getconnection1() As String
        Try
            sqlconnection = "Data Source=" & gserver & ";Persist Security Info=False;User ID=" & strDataSqlUsr & ";pwd=" & strDataSqlPwd & ";Initial Catalog= " & gdatabase & ";"
            Return sqlconnection
        Catch ex As Exception
            'MessageBox.Show("!! Warning !!Your system is not connected with SERVER, Bcoz " & ex.Message.ToString, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return ""
            Exit Function
        End Try
    End Function
    'Public Function setAsTypeMode()
    '    With farPoint
    '        For intI = 1 To 500
    '            For intJ = 2 To 4
    '                .Row = intI
    '                .Col = intJ
    '                .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
    '            Next
    '            .Col = 5
    '            .CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
    '        Next
    '    End With

    'End Function
    Public Sub GetfrontConnection()
        Try
            If Trim(gserver & "") <> "" Then
                'sqlconnection1 = "Data Source=" & gserver & ";Persist Security Info=False;User ID=sa;Initial Catalog= MASTER;"
                sqlconnection1 = "Data Source=" & gserver & ";Persist Security Info=False;User ID=" & strDataSqlUsr & "; pwd=" & strDataSqlPwd & "; Initial Catalog= MASTER;"
            Else
                'sqlconnection1 = "Data Source= (local);Persist Security Info=False;User ID=sa;Initial Catalog= MASTER;"
                sqlconnection1 = "Data Source= (local);Persist Security Info=False;User ID=" & strDataSqlUsr & "; pwd=" & strDataSqlPwd & "; Initial Catalog= MASTER;"
            End If
            Myconn.ConnectionString = sqlconnection1
            Myconn.Open()
        Catch ex As Exception
            MessageBox.Show("!! Warning !!Your system is not connected with SERVER", "ACCOUNTS", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Public Function getCompanyinfo(ByVal strSQL As String, ByVal Tabname As String)
        Try
            Call GetfrontConnection()
            Dim dt As New DataTable
            gadapter = New SqlDataAdapter(strSQL, Myconn)
            gadapter.SelectCommand.CommandTimeout = 1000000
            gadapter.Fill(dt)
            dt.TableName = Tabname
            If gdataset.Tables.Contains(Tabname) = True Then
                gdataset.Tables.Remove(Tabname)
            End If
            gdataset.Tables.Add(dt)
        Catch ex As Exception
            MsgBox("Error in Retrieving Data as " & ex.Message, MsgBoxStyle.Critical, "ACCOUNTS")
            Return ""
            Exit Function
        Finally
            closeConnection()
        End Try
        Return ""
    End Function
    Public Function getvalue(ByVal qry As String)
        Myconn.ConnectionString = sqlconnection
        Dim xxa As Object
        xxa = ""
        If Myconn.ConnectionString <> "" Then
            Myconn.Open()
            Cmd.CommandTimeout = 1000000
            Cmd.Connection = Myconn
            Cmd.CommandText = qry
            Cmd.CommandType = CommandType.Text
            xxa = Cmd.ExecuteScalar()
            Myconn.Close()
            Return xxa
        End If
        Return xxa
    End Function
    Public Function FillDataSet(ByVal strSQL As String, ByVal Tabname As String)
        Try
            openConnection()
            Dim dt As New DataTable
            dt.Rows.Clear()
            If fdataset.Tables.Contains(Tabname) = True Then
                fdataset.Tables.Remove(Tabname)
            End If
            gadapter = New SqlDataAdapter(strSQL, Myconn)
            gadapter.SelectCommand.CommandTimeout = 1000000
            gadapter.Fill(dt)
            dt.TableName = Tabname
            fdataset.Tables.Add(dt)
        Catch ex As Exception
            MsgBox("Error in Retrieving Data " & ex.Message, MsgBoxStyle.Information, Application.ProductName)
        Finally
            closeConnection()
        End Try
        Return ""
    End Function
    Public Function getMonthName(ByVal intMonth As Int16) As String
        Select Case intMonth
            Case 4
                Return "APRIL"
            Case 5
                Return "MAY"
            Case 6
                Return "JUNE"
            Case 7
                Return "JULY"
            Case 8
                Return "AUGUST"
            Case 9
                Return "SEPTEMBER"
            Case 10
                Return "OCTOBER"
            Case 11
                Return "NOVEMBER"
            Case 12
                Return "DECEMBER"
            Case 1
                Return "JANUARY"
            Case 2
                Return "FEBRUARY"
            Case 3
                Return "MARCH"
            Case Else
                Return "Not Found For " & Trim(CStr(intMonth))
        End Select
    End Function
    Public Function getMonthNo(ByVal strMonth As String) As Int16
        Select Case strMonth
            Case "APRIL"
                Return 4
            Case "MAY"
                Return 5
            Case "JUNE"
                Return 6
            Case "JULY"
                Return 7
            Case "AUGUST"
                Return 8
            Case "SEPTEMBER"
                Return 9
            Case "OCTOBER"
                Return 10
            Case "NOVEMBER"
                Return 11
            Case "DECEMBER"
                Return 12
            Case "JANUARY"
                Return 1
            Case "FEBRUARY"
                Return 2
            Case "MARCH"
                Return 3
        End Select

    End Function

    Public Function chkMonthClose(ByVal dtDate As DateTimePicker, ByVal intMsgYesNo As Int16) As Boolean
        chkMonthClose = True
        strSqlString = "SELECT ISNULL(GLOBALCLOSE,'') AS GLOBALCLOSE FROM MONTHCLOSE WHERE MONTHNO = MONTH('" & Format(dtDate.Value, "dd-MMM-yyyy") & "') "
        getDataSet(strSqlString, "MONTHCLOSE")
        If gdataset.Tables("MONTHCLOSE").Rows.Count > 0 Then
            If Trim(gdataset.Tables("MONTHCLOSE").Rows(0).Item("GLOBALCLOSE")) = "Y" Then
                If intMsgYesNo = 1 Then
                    MessageBox.Show("For This Month Transaction is Closed....", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                End If
                chkMonthClose = False
                dtDate.Focus()
            End If
        End If
    End Function
    Public Function MoreTrans1(ByVal str() As String) As Boolean
        Dim i As Integer
        Try
            'Myconn.Open()
            openConnection()
            MyTrans = Myconn.BeginTransaction()
            Cmd.Transaction = MyTrans
            Cmd.CommandTimeout = 1000000
            Cmd.Connection = Myconn
            For i = 0 To str.Length - 1
                If str(i) Is Nothing = False Then
                    Cmd.CommandText = str(i)
                    Cmd.CommandType = CommandType.Text
                    Cmd.ExecuteNonQuery()
                End If
            Next i
            MyTrans.Commit()
            'MsgBox("Transaction completed suessfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, Application.ProductName)
            MoreTrans1 = True
            Myconn.Close()
        Catch ex As Exception
            MsgBox(Err.Description & ex.Source & "Error in Transaction Operation", MsgBoxStyle.Information, Application.ProductName)
            MyTrans.Rollback()
            MoreTrans1 = False
            Myconn.Close()
        End Try
    End Function

    Public Function SaveCLUBFoto(ByVal FilePath As String, ByVal Cardid As String)
        Try


            '##### IN CASE NO PHOTO SELECTED ##### 
            If Trim(FilePath) = "" Then
                Exit Function
            End If
            '##### ##### ##### ##### ##### ##### #

            Dim cn As New SqlConnection(strcn)
            Dim cmd As New SqlCommand("update accountsSetUp set ClubLogo " & _
                " = @memimage", cn)

            Dim fsPhotoFile As New FileStream(FilePath, FileMode.Open, FileAccess.Read)
            Dim bytMEMimage(fsPhotoFile.Length() - 1) As Byte
            fsPhotoFile.Read(bytMEMimage, 0, bytMEMimage.Length)
            fsPhotoFile.Close()
            Dim prm As New SqlParameter("@memimage", SqlDbType.VarBinary, _
                bytMEMimage.Length, ParameterDirection.Input, False, _
                0, 0, Nothing, DataRowVersion.Current, bytMEMimage)
            cmd.Parameters.Add(prm)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
End Class

