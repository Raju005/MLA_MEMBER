Imports System.Text.RegularExpressions
Imports System.IO
Imports System


Module GlobalFunction
    Public gconnection As New GlobalClass
    Dim regexp As Regex
    Public boolexp As Boolean = False
    Public boolexp1 As Boolean = False
    Public boolexp2 As Boolean = False

    Public Function GetPass(ByVal vUser As String) As String
        Dim Vdesc As String
        Dim vAsc As Long
        Dim vPass As String
        Dim Loopindex As Long
        Vdesc = ""
        For Loopindex = 1 To Len(vUser)
            Vdesc = Mid(vUser, Loopindex, 1)
            vAsc = Asc(Vdesc) + 150
            vPass = Trim(vPass) & Chr(vAsc)
        Next Loopindex
        GetPass = vPass
    End Function
    Public Function abcdMINUS(ByVal vString As String) As String
        Dim vDesc As String
        Dim vAsc As Long
        Dim vDes As String
        Dim vDt As String
        Dim Loopindex As Long
        vDesc = vString
        For Loopindex = 1 To Len(vDesc)
            vDes = Trim(Mid(vDesc, Loopindex, 1) & "")
            vAsc = Asc(vDes) - 150
            If vDt = "" Then
                vDt = Chr(vAsc)
            Else
                vDt = vDt & Chr(vAsc)
            End If
        Next Loopindex
        abcdMINUS = vDt
    End Function
    Public Sub getAlphanumeric(ByVal b As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(b.KeyChar)
            Case 33 To 47
                b.Handled = True
            Case 58 To 64
                b.Handled = True
            Case 91 To 96
                b.Handled = True
            Case 123 To 135
                b.Handled = True

        End Select
    End Sub
    Public Sub getAlphaNumeric1(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim ch As Char = e.KeyChar
        If ch.IsLetter(ch) OrElse ch.IsNumber(ch) OrElse Convert.ToByte(ch) = 8 OrElse Convert.ToByte(ch) = 13 Then

        Else
            e.Handled = True
        End If
    End Sub

    Public Sub getAlphadecimal(ByVal b As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(b.KeyChar)
            Case 33 To 47
                b.Handled = True
            Case 58 To 64
                b.Handled = True
            Case 91 To 96
                b.Handled = True
            Case 123 To 135
                b.Handled = True
        End Select
    End Sub
    Public Sub getCharater(ByVal b As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(b.KeyChar)
            Case 33 To 64
                b.Handled = True
            Case 91 To 96
                b.Handled = True
            Case 91 To 96
                b.Handled = True
            Case 123 To 135
                b.Handled = True
        End Select
    End Sub
    Public Sub Block_Singlequote(ByVal b As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(b.KeyChar)
            Case 33 To 64
                b.Handled = True
            Case 39
                b.Handled = True 'Blocked single quote
        End Select
    End Sub
    Public Sub getPincode(ByVal txtbox As System.Windows.Forms.TextBox)
        Dim boolexp As Boolean = False
        If Regex.IsMatch(txtbox.Text, "^\d{5}(-\d{4})?$") Then
            boolexp = True
            txtbox.ForeColor = Color.Blue
        Else
            MsgBox(" Pincode field is not in correct format", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, " Validating Phoneno ")
            txtbox.ForeColor = Color.Red
            txtbox.Select()
            boolexp = False
        End If

    End Sub
    Public Sub getNumeric(ByVal a As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(a.KeyChar)
            Case 65 To 127
                a.Handled = True
            Case 33 To 38
                a.Handled = True
            Case 40 To 44
                a.Handled = True
            Case 58 To 64
                a.Handled = True
        End Select
    End Sub
    '*************************************************************************
    'Purpose:To Validate , Data-entry at End-User.It only allows Alpha-Numeric
    'Function Name:getEmail
    'Input Type:Textbox
    'Returm Type:Nothing
    'Auther:Avinash
    'Date:30/08/2006
    '*************************************************************************
    Public Function getEmail(ByVal txtbox As System.Windows.Forms.TextBox) As String
        Dim emailstatus As String
        If regexp.IsMatch(txtbox.Text, "^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$") Then
            emailstatus = "T"
            txtbox.ForeColor = Color.Blue
            Return emailstatus
        Else
            MsgBox(" E-mail Id field is not in correct format", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, " Validating Phoneno ")
            txtbox.ForeColor = Color.Red
            txtbox.Select()
            emailstatus = "F"
            Return emailstatus
            Exit Function
        End If
    End Function
    Public Function getEmail1(ByVal txtbox As System.Windows.Forms.TextBox) As String
        Dim emailstatus As String
        If regexp.IsMatch(txtbox.Text, "^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$") Then
            emailstatus = "T"
            txtbox.ForeColor = Color.Blue
            Return emailstatus
        Else
            If txtbox.Text = "" Then
                'MsgBox(" E-mail Id is blank!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, " Validating Phoneno ")
                txtbox.ForeColor = Color.Red
                emailstatus = "F"
            Else
                MsgBox(" E-mail Id field is not in correct format", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, " Validating Phoneno ")
                txtbox.ForeColor = Color.Red
                txtbox.Select()
                emailstatus = "F"

            End If
            Return emailstatus
            Exit Function
        End If
    End Function

    Public Sub getPhoneno(ByVal txtbox As System.Windows.Forms.TextBox)
        If Regex.IsMatch(txtbox.Text, "^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$") Then
            boolexp = True
            txtbox.ForeColor = Color.Blue
        Else
            MsgBox(" Phoneno field is not in correct format", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, " Validating Phoneno ")
            txtbox.ForeColor = Color.Red
            txtbox.Select()
            boolexp = False
        End If

    End Sub
    Public Sub PrintTextFile(ByVal VOutputfile As String)
        Dim Filewrite As StreamWriter
        If Dir(apppath & "\Reports\" & Trim(VOutputfile & "") & ".txt") <> "" Then
            Filewrite = File.AppendText(apppath & "\Reports\" & VOutputfile & ".bat")
            Filewrite.WriteLine("Type " & apppath & "\Reports\" & VOutputfile & ".txt >prn")
            Filewrite.Close()
            Call Shell(apppath & "\Reports\" & VOutputfile & ".bat", vbHide)
        Else
            MessageBox.Show(VOutputfile & " Not Found in your System", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
    End Sub
    Public Sub OpenTextFile(ByVal VOutputfile As String)
        If Dir(apppath & "\Reports\" & Trim(VOutputfile & "") & ".txt") <> "" Then
            If Dir(apppath & "\Wordpad.exe") <> "" Then
                Shell(apppath & "\Wordpad.exe " & apppath & "\Reports\" & VOutputfile & ".txt", vbMaximizedFocus)
            Else
                MsgBox("Wordpad.exe not found", MsgBoxStyle.Critical)
                Exit Sub
            End If
        Else
            MsgBox(VOutputfile & "  File not found", MsgBoxStyle.Critical)
            Exit Sub
        End If
    End Sub
    Public Sub clearform(ByVal frm As System.Windows.Forms.Form)
        Dim ctrl As New Control
        For Each ctrl In frm.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
            If TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
            If TypeOf ctrl Is CheckBox Then
                ctrl.Text = ""
            End If
        Next ctrl
    End Sub
    Public Sub BLANK(ByVal b As System.Windows.Forms.KeyPressEventArgs)
        If Asc(b.KeyChar) > 0 And Asc(b.KeyChar) < 225 Then
            b.Handled = True
        End If
    End Sub
    Public Sub GetServe()
        Dim ServerConn As New OleDb.OleDbConnection
        Dim servercmd As New OleDb.OleDbDataAdapter
        Dim gclsConnection As New GlobalClass
        Dim getserver As New DataSet
        Dim sql, ssql As String
        sql = "Provider=Microsoft.Jet.OLEDB.4.0;Data source="
        sql = sql & apppath & "\DBS_KEY.MDB"
        ServerConn.ConnectionString = sql
        Try
            ServerConn.Open()
            ssql = "SELECT SERVER, UserName, Password, Company_ID,DATABASE FROM DBSKEY"
            servercmd = New OleDb.OleDbDataAdapter(ssql, ServerConn)
            servercmd.Fill(getserver)
            If getserver.Tables(0).Rows.Count > 0 Then
                gserver = Trim(getserver.Tables(0).Rows(0).Item(0) & "")

                strDataSqlUsr = Trim(getserver.Tables(0).Rows(0).Item(1) & "")
                strDataSqlPwd = Trim(getserver.Tables(0).Rows(0).Item(2) & "")
                strCompany_ID = Trim(getserver.Tables(0).Rows(0).Item(3) & "")
                'gdatabase = Trim(getserver.Tables(0).Rows(0).Item(4) & "")
            Else
                MessageBox.Show("Failed to connect to Data Source")

            End If
        Catch ex As Exception
            MessageBox.Show("Failed to connect to data source")
            MsgBox(ex.Message)
        Finally
            ServerConn.Close()
        End Try
    End Sub
    Public Function abcdADD(ByVal vString As String) As String
        Dim vDesc As String
        Dim vAsc As Long
        Dim vDes As String
        Dim vDt As String
        Dim Loopindex As Long
        vDesc = vString
        For Loopindex = 1 To Len(vDesc)
            vDes = Trim(Mid(vDesc, Loopindex, 1) & "")
            vAsc = Asc(vDes) + 150
            If vDt = "" Then
                vDt = Chr(vAsc)
            Else
                vDt = vDt & Chr(vAsc)
            End If
        Next Loopindex
        abcdADD = vDt
    End Function
    Public Function ExportTo(ByVal ssgrid As AxFPSpreadADO.AxfpSpread)
        Try
            Dim X As Boolean
            Dim vpath As String
            Dim vLog As String
            Dim strpath As String
            vpath = Application.StartupPath & "\Reports\Monprtn"
            vLog = Application.StartupPath & "\Reports\Monprtn.Txt"
            'X = ssgrid.ExportRangeToTextFile(0, 0, ssgrid.Col2, ssgrid.Row2, Application.StartupPath & "\Reports\One.txt", "", ",", vbCrLf, FPSpreadADO.ExportRangeToTextFileConstants.ExportRangeToTextFileCreateNewFile, Application.StartupPath & "\Reports\One.log")
            With ssgrid
                If Dir(vpath & ".Xls") <> "" Then
                    Kill(vpath & ".Xls")
                End If
                X = .ExportToExcel(vpath & ".Xls", "", "")
                strpath = strexcelpath & " " & vpath & ".xls"
                Call Shell(strpath, AppWinStyle.NormalFocus)
            End With
        Catch ex As Exception
            MessageBox.Show("Before Opening New EXCEL Sheet Close Previous EXCEL sheet", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Function
        End Try
    End Function

    Public Sub getdecimal(ByVal a As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(a.KeyChar)
            Case 65 To 127
                a.Handled = True
            Case 33 To 38
                a.Handled = True
            Case 40 To 44
                a.Handled = True
            Case 58 To 64
                a.Handled = True
        End Select
    End Sub
    Public Function SELECTALLCHECKEDLIST(ByVal CHKLST As CheckedListBox)
        Dim I As Int16
        For I = 0 To CHKLST.Items.Count - 1
            CHKLST.SetItemChecked(I, True)
        Next
    End Function
    Public Function DESELECTALLCHECKEDLIST(ByVal CHKLST As CheckedListBox)
        Dim I As Int16
        For I = 0 To CHKLST.Items.Count - 1
            CHKLST.SetItemChecked(I, False)
        Next
    End Function
    Public Sub OpenTextFileCMD(ByVal VOutputfile As String)
        If Dir(apppath & "\Reports\" & Trim(VOutputfile & "") & ".txt") <> "" Then
            Dim Filewrite As StreamWriter
            If Dir(apppath & "\Reports\" & Trim(VOutputfile & "") & ".txt") <> "" Then
                Filewrite = File.AppendText(apppath & "\Reports\" & VOutputfile & ".bat")
                Filewrite.WriteLine("Edit " & apppath & "\Reports\" & VOutputfile & ".txt")
                Filewrite.Close()
                Call Shell(apppath & "\Reports\" & VOutputfile & ".bat", AppWinStyle.NormalFocus)
            Else
                MsgBox(VOutputfile & " File not found", MsgBoxStyle.Critical)
                Exit Sub
            End If
        Else
            MsgBox(VOutputfile & "  File not found", MsgBoxStyle.Critical)
            Exit Sub
        End If
    End Sub
    Public Function FyearDateCheck(ByVal Vdate As String) As Boolean
        FyearDateCheck = True
        Dim StartDate As String
        Dim EndDate As String
        StartDate = "01-APR-" & gFinancalyearStart
        EndDate = "31-MAR-" & gFinancialyearEnd
        If CDate(Vdate) >= CDate(StartDate) And CDate(Vdate) <= CDate(EndDate) Then
            FyearDateCheck = True
        Else
            FyearDateCheck = False
        End If
    End Function
    Public Function GreateDateCheck(ByVal Vdate As String) As Boolean
        GreateDateCheck = True
        Dim StartDate As String
        Dim EndDate As String
        StartDate = "01-APR-" & gFinancalyearStart
        EndDate = "31-MAR-" & gFinancialyearEnd
        If CDate(Vdate) <= CDate(Now) Then
            GreateDateCheck = True
        Else
            GreateDateCheck = False
        End If
    End Function


    Public Function Checkdatevalidate(ByVal Startdate As Date) As Boolean
        chkdatevalidate = True
        If DateDiff(DateInterval.Day, Startdate, DateValue(Now)) < 0 Then
            MessageBox.Show("To Date cannot be greater than Current Date", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            chkdatevalidate = False
            'Exit Function
        End If

        If FyearDateCheck(Startdate) = False Then
            chkdatevalidate = False
            MessageBox.Show("Date should be within the Financial year", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            'Exit Function
        End If

        'If (DateDiff(DateInterval.Day, Startdate, DateValue("01-APR-" & gFinancalyearStart)) < 0) Or (DateDiff(DateInterval.Day, DateValue("31-MAR-" & gFinancialyearEnd), Startdate) < 0) Then
        '    MsgBox(DateDiff(DateInterval.Day, Startdate, DateValue("01-APR-" & gFinancalyearStart)))
        '    MsgBox(DateDiff(DateInterval.Day, DateValue("31-MAR-" & gFinancialyearEnd), Startdate))
        '    MessageBox.Show("Date should be within the Financial year", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    chkdatevalidate = False
        '    Exit Function
        'End If
        Return chkdatevalidate
    End Function
    Public Function Checkdaterangevalidate(ByVal Startdate As Date, ByVal Enddate As Date) As Boolean
        chkdatevalidate = True
        If DateDiff(DateInterval.Day, Enddate, DateValue(Now)) < 0 Then
            MessageBox.Show("To Date cannot be greater than Current Date", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            chkdatevalidate = False
            Exit Function
        End If


        If DateDiff(DateInterval.Day, Startdate, Enddate) < 0 Then
            MessageBox.Show("From Date cannot be greater than To Date", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            chkdatevalidate = False
            Exit Function
        End If

        'If CDate(Startdate) >= CDate(Startdate) And CDate(Enddate) <= CDate(Enddate) Then
        '    chkdatevalidate = True
        'Else
        '    MsgBox("Date should be within Financial Year", MsgBoxStyle.Critical)
        '    chkdatevalidate = False
        '    Exit Function
        'End If

        If Year(Startdate) >= gFinancalyearStart And Year(Enddate) <= gFinancialyearEnd Then
            chkdatevalidate = True
        Else
            MsgBox("Date should be within Financial Year", MsgBoxStyle.Critical)
            chkdatevalidate = False
            Exit Function
        End If
        Return chkdatevalidate
    End Function

    Function RupeesToWord(ByVal MyNumber)
        Dim Temp
        Dim Rupees, Paisa As String
        Dim DecimalPlace, iCount
        Dim Hundreds, Words As String
        Dim place(9) As String
        place(0) = " Thousand "
        place(2) = " Lakh "
        place(4) = " Crore "
        place(6) = " Arab "
        place(8) = " Kharab "
        On Error Resume Next
        ' Convert MyNumber to a string, trimming extra spaces.
        MyNumber = Trim(Str(MyNumber))

        ' Find decimal place.
        DecimalPlace = InStr(MyNumber, ".")

        ' If we find decimal place...
        If DecimalPlace > 0 Then
            ' Convert Paisa
            Temp = Left(Mid(MyNumber, DecimalPlace + 1) & "00", 2)
            Paisa = " and " & ConvertTens(Temp) & " Paisa"

            ' Strip off paisa from remainder to convert.
            MyNumber = Trim(Left(MyNumber, DecimalPlace - 1))
        End If

        '===============================================================
        Dim TM As String  ' If MyNumber between Rs.1 To 99 Only.
        TM = Right(MyNumber, 2)

        If Len(MyNumber) > 0 And Len(MyNumber) <= 2 Then
            If Len(TM) = 1 Then
                Words = ConvertDigit(TM)
                RupeesToWord = Words & Paisa & " Only"

                Exit Function

            Else
                If Len(TM) = 2 Then
                    Words = ConvertTens(TM)
                    RupeesToWord = Words & Paisa & " Only"
                    Exit Function

                End If
            End If
        End If
        '===============================================================


        ' Convert last 3 digits of MyNumber to ruppees in word.
        Hundreds = ConvertHundreds(Right(MyNumber, 3))
        ' Strip off last three digits
        MyNumber = Left(MyNumber, Len(MyNumber) - 3)

        iCount = 0
        Do While MyNumber <> ""
            'Strip last two digits
            Temp = Right(MyNumber, 2)
            If Len(MyNumber) = 1 Then


                If Trim(Words) = "Thousand" Or _
                Trim(Words) = "Lakh  Thousand" Or _
                Trim(Words) = "Lakh" Or _
                Trim(Words) = "Crore" Or _
                Trim(Words) = "Crore  Lakh  Thousand" Or _
                Trim(Words) = "Arab  Crore  Lakh  Thousand" Or _
                Trim(Words) = "Arab" Or _
                Trim(Words) = "Kharab  Arab  Crore  Lakh  Thousand" Or _
                Trim(Words) = "Kharab" Then

                    Words = ConvertDigit(Temp) & place(iCount)
                    MyNumber = Left(MyNumber, Len(MyNumber) - 1)

                Else

                    Words = ConvertDigit(Temp) & place(iCount) & Words
                    MyNumber = Left(MyNumber, Len(MyNumber) - 1)

                End If
            Else

                If Trim(Words) = "Thousand" Or _
                   Trim(Words) = "Lakh  Thousand" Or _
                   Trim(Words) = "Lakh" Or _
                   Trim(Words) = "Crore" Or _
                   Trim(Words) = "Crore  Lakh  Thousand" Or _
                   Trim(Words) = "Arab  Crore  Lakh  Thousand" Or _
                   Trim(Words) = "Arab" Then


                    Words = ConvertTens(Temp) & place(iCount)


                    MyNumber = Left(MyNumber, Len(MyNumber) - 2)
                Else

                    '=================================================================
                    ' if only Lakh, Crore, Arab, Kharab

                    If Trim(ConvertTens(Temp) & place(iCount)) = "Lakh" Or _
                       Trim(ConvertTens(Temp) & place(iCount)) = "Crore" Or _
                       Trim(ConvertTens(Temp) & place(iCount)) = "Arab" Then

                        Words = Words
                        MyNumber = Left(MyNumber, Len(MyNumber) - 2)
                    Else
                        Words = ConvertTens(Temp) & place(iCount) & Words
                        MyNumber = Left(MyNumber, Len(MyNumber) - 2)
                    End If

                End If
            End If

            iCount = iCount + 2
        Loop

        RupeesToWord = Words & Hundreds & Paisa & " Only"
    End Function
    Function RupeesToWordASCA(ByVal MyNumber)
        Dim Temp
        Dim Rupees, Paisa As String
        Dim DecimalPlace, iCount
        Dim Hundreds, Words As String
        Dim place(9) As String
        place(0) = " Thousand "
        place(2) = " Lakh "
        place(4) = " Crore "
        place(6) = " Arab "
        place(8) = " Kharab "
        On Error Resume Next
        ' Convert MyNumber to a string, trimming extra spaces.
        MyNumber = Trim(Str(MyNumber))

        ' Find decimal place.
        DecimalPlace = InStr(MyNumber, ".")

        ' If we find decimal place...
        If DecimalPlace > 0 Then
            ' Convert Paisa
            Temp = Left(Mid(MyNumber, DecimalPlace + 1) & "00", 2)
            Paisa = " and " & ConvertTens(Temp) & " Paisa"

            ' Strip off paisa from remainder to convert.
            MyNumber = Trim(Left(MyNumber, DecimalPlace - 1))
        End If

        '===============================================================
        Dim TM As String  ' If MyNumber between Rs.1 To 99 Only.
        TM = Right(MyNumber, 2)

        If Len(MyNumber) > 0 And Len(MyNumber) <= 2 Then
            If Len(TM) = 1 Then
                Words = ConvertDigit(TM)
                RupeesToWordASCA = Words & Paisa & " Only."

                Exit Function

            Else
                If Len(TM) = 2 Then
                    Words = ConvertTens(TM)
                    RupeesToWordASCA = Words & Paisa & " Only."
                    Exit Function

                End If
            End If
        End If
        '===============================================================


        ' Convert last 3 digits of MyNumber to ruppees in word.
        Hundreds = ConvertHundreds(Right(MyNumber, 3))
        ' Strip off last three digits
        MyNumber = Left(MyNumber, Len(MyNumber) - 3)

        iCount = 0
        Do While MyNumber <> ""
            'Strip last two digits
            Temp = Right(MyNumber, 2)
            If Len(MyNumber) = 1 Then


                If Trim(Words) = "Thousand" Or _
                Trim(Words) = "Lakh  Thousand" Or _
                Trim(Words) = "Lakh" Or _
                Trim(Words) = "Crore" Or _
                Trim(Words) = "Crore  Lakh  Thousand" Or _
                Trim(Words) = "Arab  Crore  Lakh  Thousand" Or _
                Trim(Words) = "Arab" Or _
                Trim(Words) = "Kharab  Arab  Crore  Lakh  Thousand" Or _
                Trim(Words) = "Kharab" Then

                    Words = ConvertDigit(Temp) & place(iCount)
                    MyNumber = Left(MyNumber, Len(MyNumber) - 1)

                Else

                    Words = ConvertDigit(Temp) & place(iCount) & Words
                    MyNumber = Left(MyNumber, Len(MyNumber) - 1)

                End If
            Else

                If Trim(Words) = "Thousand" Or _
                   Trim(Words) = "Lakh  Thousand" Or _
                   Trim(Words) = "Lakh" Or _
                   Trim(Words) = "Crore" Or _
                   Trim(Words) = "Crore  Lakh  Thousand" Or _
                   Trim(Words) = "Arab  Crore  Lakh  Thousand" Or _
                   Trim(Words) = "Arab" Then


                    Words = ConvertTens(Temp) & place(iCount)


                    MyNumber = Left(MyNumber, Len(MyNumber) - 2)
                Else

                    '=================================================================
                    ' if only Lakh, Crore, Arab, Kharab

                    If Trim(ConvertTens(Temp) & place(iCount)) = "Lakh" Or _
                       Trim(ConvertTens(Temp) & place(iCount)) = "Crore" Or _
                       Trim(ConvertTens(Temp) & place(iCount)) = "Arab" Then

                        Words = Words
                        MyNumber = Left(MyNumber, Len(MyNumber) - 2)
                    Else
                        Words = ConvertTens(Temp) & place(iCount) & Words
                        MyNumber = Left(MyNumber, Len(MyNumber) - 2)
                    End If

                End If
            End If

            iCount = iCount + 2
        Loop

        RupeesToWordASCA = Words & Hundreds & Paisa & " Only."
    End Function

    ' Conversion for hundreds
    '*****************************************
    Private Function ConvertHundreds(ByVal MyNumber)
        Dim Result As String

        ' Exit if there is nothing to convert.
        If Val(MyNumber) = 0 Then Exit Function

        ' Append leading zeros to number.
        MyNumber = Right("000" & MyNumber, 3)

        ' Do we have a hundreds place digit to convert?
        If Left(MyNumber, 1) <> "0" Then
            Result = ConvertDigit(Left(MyNumber, 1)) & " Hundred "
        End If

        ' Do we have a tens place digit to convert?
        If Mid(MyNumber, 2, 1) <> "0" Then
            Result = Result & ConvertTens(Mid(MyNumber, 2))
        Else
            ' If not, then convert the ones place digit.
            Result = Result & ConvertDigit(Mid(MyNumber, 3))
        End If

        ConvertHundreds = Trim(Result)
    End Function
    Public Sub OpenTextFileXML(ByVal VOutputfile As String)
        If Dir(apppath & "\Reports\" & Trim(VOutputfile & "") & ".XML") <> "" Then
            If Dir(apppath & "\IEXPLORE.exe") <> "" Then
                Shell(apppath & "\IEXPLORE.exe " & apppath & "\Reports\" & VOutputfile & ".XML", vbMaximizedFocus)
            Else
                MsgBox("IEXPLORE.exe not found", MsgBoxStyle.Critical)
                Exit Sub
            End If
        Else
            MsgBox(VOutputfile & "  File not found", MsgBoxStyle.Critical)
            Exit Sub
        End If
    End Sub

    ' Conversion for tens
    '*****************************************
    Private Function ConvertTens(ByVal MyTens)
        Dim Result As String

        ' Is value between 10 and 19?
        If Val(Left(MyTens, 1)) = 1 Then
            Select Case Val(MyTens)
                Case 10 : Result = "Ten"
                Case 11 : Result = "Eleven"
                Case 12 : Result = "Twelve"
                Case 13 : Result = "Thirteen"
                Case 14 : Result = "Fourteen"
                Case 15 : Result = "Fifteen"
                Case 16 : Result = "Sixteen"
                Case 17 : Result = "Seventeen"
                Case 18 : Result = "Eighteen"
                Case 19 : Result = "Nineteen"
                Case Else
            End Select
        Else
            ' .. otherwise it's between 20 and 99.
            Select Case Val(Left(MyTens, 1))
                Case 2 : Result = "Twenty "
                Case 3 : Result = "Thirty "
                Case 4 : Result = "Forty "
                Case 5 : Result = "Fifty "
                Case 6 : Result = "Sixty "
                Case 7 : Result = "Seventy "
                Case 8 : Result = "Eighty "
                Case 9 : Result = "Ninety "
                Case Else
            End Select

            ' Convert ones place digit.
            Result = Result & ConvertDigit(Right(MyTens, 1))
        End If

        ConvertTens = Result
    End Function

    Private Function ConvertDigit(ByVal MyDigit)
        Select Case Val(MyDigit)
            Case 1 : ConvertDigit = "One"
            Case 2 : ConvertDigit = "Two"
            Case 3 : ConvertDigit = "Three"
            Case 4 : ConvertDigit = "Four"
            Case 5 : ConvertDigit = "Five"
            Case 6 : ConvertDigit = "Six"
            Case 7 : ConvertDigit = "Seven"
            Case 8 : ConvertDigit = "Eight"
            Case 9 : ConvertDigit = "Nine"
            Case Else : ConvertDigit = ""
        End Select
    End Function


End Module
