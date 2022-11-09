Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Public Class MDIParent1
    Dim gconnection As New GlobalClass
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub
    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer
    Private Sub MDIParent1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub MDIParent1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F12 Then
            GmoduleName = "MEMBER LEDGER / OUTSTANDING"
            Try
                Dim accounttagging As New FRM_RBC_MEMBERLEDGER
                accounttagging.Show()
                accounttagging.MdiParent = Me
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim i As Integer

        'apppath = Application.StartupPath
        'Call gconnection.GetServer()
        Call GetServer()
        Call getserverdate()
        Call GETSTATUS()
        'sql = "update lockerallotmaster set  where isnull(freeze,'')<>'y' and isnull(expirydate,'')='" & gdate & "'"
        'gconnection.getDataSet(sql, "locker")
        'If gdataset.Tables("locker").Rows.Count >= 1 Then
        '    For i = 0 To gdataset.Tables("locker").Rows.Count - 1

        '    Next
        '    'End If
        Dim ssql As String
        Dim tb As New DataTable
        ssql = "select * from accountsSetUp "
        tb = gconnection.GetValues(ssql)
        If tb.Rows.Count > 0 Then
            gDebtors = tb.Rows(0).Item("SdrsCode")
            gDebdesc = tb.Rows(0).Item("SdrsDesc")
            gCreditors = tb.Rows(0).Item("SCrsCode")
        End If
        'Me.Text = Trim(CStr(gFinancalyearStart)) & "-" & Trim(CStr(gFinancialyearEnd)) & " " & Trim(gcompanyname) & " [" & "ACCOUNTS" & " ] - " & Trim(gUsername) & " ] Last Updated " & Format(dtLastWriteTime, "dd/MMM/yyyy HH:mm:ss") & " Size " & CStr(FileSize)
        Me.Text = "[" & " MEMBER " & "] -   " & "[ " & Trim(CStr(gFinancalyearStart)) & " - " & Trim(CStr(gFinancialyearEnd)) & " ]  " & "  [ " & Trim(gcompanyname) & " ] " & "  USER NAME  -  [ " & Trim(gUsername) & " ] "
        Call Activateuseradmin()
    End Sub
    Private Sub Activateuseradmin()
        Dim totmenu As Integer = 0
        Dim i, j, k, ckhmn, ckhmn1 As Integer
        Call menublock()
        For i = 0 To Me.Menu.MenuItems.Count - 2
            ckhmn1 = Me.Menu.MenuItems(i).MenuItems.Count()
            If ckhmn1 <> 0 Then
                For j = 0 To Me.Menu.MenuItems(i).MenuItems.Count() - 1
                    ckhmn = Me.Menu.MenuItems(i).MenuItems(j).MenuItems.Count()
                    If ckhmn <> 0 Then
                        For k = 0 To Me.Menu.MenuItems(i).MenuItems(j).MenuItems.Count() - 1
                            totmenu = totmenu + 1
                        Next
                    Else
                        totmenu = totmenu + 1
                    End If
                Next
            Else
                totmenu = totmenu + 1
            End If
        Next
        gconnection.getDataSet("SELECT COUNT(*) FROM  modulemaster WHERE PackageName='MEMBER'", "chk")
        If gdataset.Tables("chk").Rows.Count <> totmenu Then
            gconnection.ExcuteStoreProcedure("DELETE FROM modulemaster WHERE PackageName='MEMBER'")
            Call checkmenulist()
        End If
        If gUserCategory = "S" Or gUserCategory = "A" Then
            Call menuclear()
        Else
            Call relemenu()
        End If
    End Sub
    Sub menuclear()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        vmain = Me.Menu.MenuItems.Count.ToString
        For i = 0 To vmain - 2
            vsmod = Me.Menu.MenuItems(i).MenuItems.Count
            If vsmod <> 0 Then
                For j = 0 To vsmod - 1
                    vssmod = Me.Menu.MenuItems(i).MenuItems(j).MenuItems.Count
                    If vssmod <> 0 Then
                        For k = 0 To vssmod - 1
                            Me.Menu.MenuItems(i).MenuItems(j).MenuItems(k).Enabled = True
                        Next
                    Else
                        Me.Menu.MenuItems(i).MenuItems(j).Enabled = True
                    End If
                Next
            Else
                Me.Menu.MenuItems(i).Enabled = True
            End If
        Next
    End Sub
    Sub menublock()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long

        vmain = Me.Menu.MenuItems.Count
        For i = 0 To vmain - 2
            vsmod = Me.Menu.MenuItems(i).MenuItems.Count
            If vsmod <> 0 Then
                For j = 0 To vsmod - 1
                    vssmod = Me.Menu.MenuItems(i).MenuItems(j).MenuItems.Count
                    If vssmod <> 0 Then
                        For k = 0 To vssmod - 1
                            Me.Menu.MenuItems(i).MenuItems(j).MenuItems(k).Enabled = False
                        Next
                    Else
                        Me.Menu.MenuItems(i).MenuItems(j).Enabled = False
                    End If
                Next
            Else
                Me.Menu.MenuItems(i).Enabled = False
            End If
        Next
    End Sub
    Sub relemenu1()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql As String
        Dim ds As New DataSet
        Dim chstr As String
        gconnection.getDataSet("SELECT * FROM USERADMIN WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='MEMBER'", "user")
        If gdataset.Tables("user").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("user").Rows.Count - 1
                With gdataset.Tables("user").Rows(i)
                    If Trim(gdataset.Tables("user").Rows(i).Item("mainmoduleid") & "") <> "" And Trim(.Item("submoduleid") & "") <> "" And Trim(.Item("ssubmoduleid") & "") <> "" Then
                        Me.Menu.MenuItems(.Item("mainmoduleid")).MenuItems(Val(.Item("submoduleid"))).MenuItems(Val(.Item("ssubmoduleid"))).Enabled = True
                        chstr = abcdMINUS(.Item("rights"))
                    ElseIf Trim(gdataset.Tables("user").Rows(i).Item("mainmoduleid") & "") <> "" And Trim(gdataset.Tables("user").Rows(i).Item("submoduleid") & "") <> "" Then
                        Me.Menu.MenuItems(gdataset.Tables("user").Rows(i).Item("mainmoduleid")).MenuItems(Val(gdataset.Tables("user").Rows(i).Item("submoduleid"))).Enabled = True
                        chstr = abcdMINUS(.Item("rights"))
                    ElseIf Trim(.Item("mainmoduleid") & "") <> "" Then
                        Me.Menu.MenuItems(.Item("mainmoduleid")).Enabled = True
                        chstr = abcdMINUS(.Item("rights"))
                    End If
                End With
            Next
        End If
    End Sub
    Sub relemenu()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql As String
        Dim ds As New DataSet
        Dim chstr As String
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        gconnection.getDataSet("SELECT * FROM USERADMIN WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='MEMBER'", "user")
        If gdataset.Tables("user").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("user").Rows.Count - 1
                With gdataset.Tables("user").Rows(i)
                    If Trim(.Item("mainmoduleid") & "") <> "" And Trim(.Item("submoduleid") & "") <> "" And Trim(.Item("ssubmoduleid") & "") <> "" Then
                        a = .Item("mainmoduleid")
                        b = Val(.Item("submoduleid"))
                        c = Val(.Item("ssubmoduleid"))
                        Menu.MenuItems(a).MenuItems(b).MenuItems(c).Enabled = True
                        chstr = abcdMINUS(.Item("rights"))
                    ElseIf Trim(.Item("mainmoduleid") & "") <> "" And Trim(.Item("submoduleid") & "") <> "" Then
                        a = gdataset.Tables("user").Rows(i).Item("mainmoduleid")
                        b = Val(gdataset.Tables("user").Rows(i).Item("submoduleid"))
                        Menu.MenuItems(a).MenuItems(b).Enabled = True
                        chstr = abcdMINUS(.Item("rights"))
                    ElseIf Trim(.Item("mainmoduleid") & "") <> "" Then
                        Menu.MenuItems((.Item("mainmoduleid"))).Enabled = True
                        chstr = abcdMINUS(.Item("rights"))
                    End If
                End With
            Next
        End If
    End Sub
    Public Sub checkmenulist()
        Dim i, j, k, x As Integer
        Dim vsql() As String
        Dim vmain, vsmod, vssmod As Long
        x = 0
        ReDim vsql(x)
        vmain = Me.Menu.MenuItems.Count
        If vmain <> 0 Then
            For i = 0 To vmain - 2
                vsmod = Me.Menu.MenuItems(i).MenuItems.Count
                If vsmod <> 0 Then
                    For j = 0 To vsmod - 1
                        vssmod = Me.Menu.MenuItems(i).MenuItems(j).MenuItems.Count
                        If vssmod <> 0 Then
                            For k = 0 To vssmod - 1
                                If Me.Menu.MenuItems(i).MenuItems(j).MenuItems(k).Visible = True Then
                                    vsql(vsql.Length - 1) = "insert into Modulemaster(Mainmoduleid,MainModulename,SubModuleid,SubModulename,SsubModuleid,SsubModuleName,PackageName) values "
                                    vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & " ('" & i & "','" & Trim(Me.Menu.MenuItems(i).Text.Replace("&", "") & "") & "',"
                                    vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'" & j & "','" & Trim(Me.Menu.MenuItems(i).MenuItems(j).Text.Replace("&", "") & "") & "',"
                                    vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'" & k & "','" & Trim(Me.Menu.MenuItems(i).MenuItems(j).MenuItems(k).Text.Replace("&", "") & "") & "','MEMBER')"
                                    ReDim Preserve vsql(vsql.Length)
                                End If
                            Next
                        Else
                            If Me.Menu.MenuItems(i).MenuItems(j).Visible = True Then
                                vsql(vsql.Length - 1) = "insert into Modulemaster(Mainmoduleid,MainModulename,SubModuleid,SubModulename,SsubModuleid,SsubModuleName,PackageName ) values "
                                vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & " ('" & i & "','" & Trim(Me.Menu.MenuItems(i).Text.Replace("&", "") & "") & "',"
                                vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'" & j & "','" & Trim(Me.Menu.MenuItems(i).MenuItems(j).Text.Replace("&", "") & "") & "',"
                                vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'','','MEMBER')"
                                ReDim Preserve vsql(vsql.Length)
                            End If
                        End If
                    Next
                Else
                    If Me.Menu.MenuItems(i).Visible = True Then
                        vsql(vsql.Length - 1) = "insert into Modulemaster(Mainmoduleid,MainModulename,SubModuleid,SubModulename,SsubModuleid,SsubModuleName,PackageName) values "
                        vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & " ('" & i & "','" & Trim(Me.Menu.MenuItems(i).Text.Replace("&", "") & "") & "',"
                        vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'','',"
                        vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'','','MEMBER')"
                        ReDim Preserve vsql(vsql.Length)
                    End If
                End If
            Next
            ReDim Preserve vsql(vsql.Length - 2)
            gconnection.MoreTrans1(vsql)
        End If
    End Sub
    Public Sub GETSTATUS()
        Dim SQL As String
        SQL = "UPDATE MEMBERMASTER SET CURENTSTATUS=NEWSTATUS,STATUSDATEFROM='',NEWSTATUS='' WHERE ISNULL(NEWSTATUS,'')<>'' AND STATUSDATEFROM<='" & Format(gdate, "yyyy-MM-dd") & "'"
        gconnection.dataOperation(2, SQL, "member")

    End Sub
    Public Sub getserverdate()
        Dim sql As String
        sql = "select * from view_server_datetime"
        gconnection.getDataSet(sql, "server")
        If gdataset.Tables("server").Rows.Count >= 1 Then
            gdate = gdataset.Tables("server").Rows(0).Item("serverdate")

        End If
    End Sub
    Public Sub GetServer()
        Dim ServerConn As New OleDb.OleDbConnection
        Dim servercmd As New OleDb.OleDbDataAdapter
        Dim getserver As New DataSet
        Dim sql, ssql As String
        sql = "Provider=Microsoft.Jet.OLEDB.4.0;Data source="
        sql = sql & apppath & "\DBS_KEY.MDB"
        ServerConn.ConnectionString = sql
        Try
            ServerConn.Open()
            ssql = "SELECT SERVER, UserName, Password FROM DBSKEY"
            servercmd = New OleDb.OleDbDataAdapter(ssql, ServerConn)
            servercmd.Fill(getserver)
            If getserver.Tables(0).Rows.Count > 0 Then
                gserver = Trim(getserver.Tables(0).Rows(0).Item(0) & "")
                SQL_UserName = Trim(getserver.Tables(0).Rows(0).Item(1) & "")
                SQL_Password = Trim(getserver.Tables(0).Rows(0).Item(2) & "")
            Else
                MessageBox.Show("Failed to connect to Data Source")
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to connect to data source")
            MsgBox(ex.Message)
        Finally
            ServerConn.Close()
        End Try
    End Sub
    Private Sub CLOSEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLOSEToolStripMenuItem.Click
        End
    End Sub
    Private Sub MEMBERMASTERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MEMBERMASTERToolStripMenuItem.Click
        GmoduleName = "MEMBER MASTER"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim MEM As New FRM_MEMMASTER
            MEM.Show()
            MEM.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CATEGORYMASTERToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SUBCATEGORYMASTERToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        GmoduleName = "SUBSCRIPTION MASTER"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim subscriptionmas As New FRM_MKGA_SUBSCRIPTION_MASTER
            subscriptionmas.Show()
            subscriptionmas.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub COUNTRYMASTERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COUNTRYMASTERToolStripMenuItem.Click
        GmoduleName = "COUNTRY MASTER"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim COUTNRY As New frm_mkga_countrymaster
            COUTNRY.Show()
            COUTNRY.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub STATEMASTERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STATEMASTERToolStripMenuItem.Click
        GmoduleName = "STATE MASTER"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim STATE As New frm_mkga_Statemaster
            STATE.Show()
            STATE.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CITYMASTERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CITYMASTERToolStripMenuItem.Click
        GmoduleName = "CITY MASTER"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim CITY As New frm_mkga_CityMaster
            CITY.Show()
            CITY.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub REASONMASTERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REASONMASTERToolStripMenuItem.Click
        GmoduleName = "REASON MASTER"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim REASON As New FRM_MKGA_REASONMASTER
            REASON.Show()
            REASON.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SUBSCRIPTIONTAGGINGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SUBSCRIPTIONTAGGINGToolStripMenuItem.Click
        GmoduleName = "SUBSCRIPTION TAGGING"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SUBTAGGING As New FRM_MKGA_SubscriptionTagging
            SUBTAGGING.Show()
            SUBTAGGING.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AFFILIATEDCLUBDETAILSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AFFILIATEDCLUBDETAILSToolStripMenuItem.Click
        GmoduleName = "AFFILIATED CLUB DETAILS"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim AFFILIATED As New FRM_MKGA_AffiliatedClubDetails
            AFFILIATED.Show()
            AFFILIATED.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        GmoduleName = "CATEGORY CONVERSTION"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim CATCON As New frm_tkga_CategoryConversion
            CATCON.Show()
            CATCON.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MEMBERACTIVATIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MEMBERACTIVATIONToolStripMenuItem.Click
        GmoduleName = "MEMBER ACTIVATION"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim memactive As New FRM_TRANS_MEMBERACTIVATION
            memactive.Show()
            memactive.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MEMBERDEACTIVATIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MEMBERDEACTIVATIONToolStripMenuItem.Click
        GmoduleName = "MEMBER DEACTIVATION"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim memdeactive As New FRM_TRANS_MEMBERDEACTIVATION
            memdeactive.Show()
            memdeactive.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MEMBERADDRESSLISTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MEMBERADDRESSLISTToolStripMenuItem.Click
        GmoduleName = "MEMBER ADDRESS LIST"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim ADDLIST As New frm_rkga_MemberAddressList
            ADDLIST.Show()
            ADDLIST.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MEMBERDIRECTORYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MEMBERDIRECTORYToolStripMenuItem.Click
        GmoduleName = "MEMBER DIRECTORY"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim MEMDIR As New frm_rkga_MemberDirectory
            MEMDIR.Show()
            MEMDIR.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MEMBERSTATUSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MEMBERSTATUSToolStripMenuItem.Click
        GmoduleName = "MEMBER STATUS"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim MEMSTATRPT As New RPT_MEMBERSTATUS_REPORT
            MEMSTATRPT.Show()
            MEMSTATRPT.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MEMBERDOBANDWEDDINGLISTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MEMBERDOBANDWEDDINGLISTToolStripMenuItem.Click
        GmoduleName = "MEMBER DOB AND  WEDDING LIST"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim WEDD As New FRM_RKGA_MEMBER_DOB_AND_WEDDING_LIST
            WEDD.Show()
            WEDD.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SUBSCRIPTIONDETAILSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SUBSCRIPTIONDETAILSToolStripMenuItem.Click
        GmoduleName = "SUBSCRIPTION DETAILS"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SUBDET As New RFM_RKGA_SUBSCRIPTIONDETAILS
            SUBDET.Show()
            SUBDET.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MEMBERCREDITADVICEANDDEBITADVICEToolStripMenuItem_Click(sender As Object, e As EventArgs)
        GmoduleName = "MEMBER CREDIT ADVICE AND DEBIT ADVICE"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim CREDEB As New FRM_RKGA_MEMCREDEB_ADVICE
            CREDEB.Show()
            CREDEB.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SUBSCRIPTIONTAGGINGToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SUBSCRIPTIONTAGGINGToolStripMenuItem1.Click
        GmoduleName = "SUBSCRIPTION TAGGING"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SUBTAG As New FRM_RKGA_SUBSCRIPTION_TAGGING
            SUBTAG.Show()
            SUBTAG.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        GmoduleName = "CORPORATE MASTER"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim CORP As New CORPORATES_MASTER
            CORP.Show()
            CORP.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        GmoduleName = "SALUTATION MASTER"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SAL As New SALUTATION_MASTER
            SAL.Show()
            SAL.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        GmoduleName = "DESIGNATION MASTER"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim DESIGN As New DESIGNATION_MASTER
            DESIGN.Show()
            DESIGN.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        GmoduleName = "PREFESSION MASTER"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim PROFES As New PROFESSION_MASTER
            PROFES.Show()
            PROFES.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        GmoduleName = "MARITAL STATUS MASTER"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim MARITAL As New MARTIALSTATUS_MASTER
            MARITAL.Show()
            MARITAL.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        GmoduleName = "CHARGE MASTER"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim CHARGE As New FRM_MKGA_CHARGEMASTER
            CHARGE.Show()
            CHARGE.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MASTERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MASTERToolStripMenuItem.Click

    End Sub

    Private Sub SelectCompanyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectCompanyToolStripMenuItem.Click
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Me.Close()
            Dim selectcompany As New CompanyList1
            selectcompany.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SUBSCRIPTIONPOSTINGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SUBSCRIPTIONPOSTINGToolStripMenuItem.Click
        GmoduleName = "SUBSCRIPTION POSTING"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SUBPOS As New FRM_TKGA_SUBSCRIPTIONPOSTING
            SUBPOS.Show()
            SUBPOS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ACCOUNTTAGGINGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACCOUNTTAGGINGToolStripMenuItem.Click
        GmoduleName = "Accounttagging"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim accounttagging As New ACCOUNTSITEMTAGGING
            accounttagging.Show()
            accounttagging.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem11.Click
        GmoduleName = "MEMBER LEDGER / OUTSTANDING"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim accounttagging As New FRM_RBC_MEMBERLEDGER
            accounttagging.Show()
            accounttagging.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem13.Click
        GmoduleName = "DEPENDENT DETALS"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim DEPENDENT As New DEPENDET
            DEPENDENT.Show()
            DEPENDENT.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub OUTSTANDINGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OUTSTANDINGToolStripMenuItem.Click
        GmoduleName = "OUTSTANDING LIST"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim OUTSTAND As New OUTSTAND_MEMREP_LIST
            OUTSTAND.Show()
            OUTSTAND.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

        GmoduleName = "CATEGORY MASTER"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim CATE As New frm_mkga_categorymaster
            CATE.Show()
            CATE.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripMenuItem14_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem14.Click
        GmoduleName = "SUBCATEGORY MASTER"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SUBCATE As New frm_mkga_subcategorymaster
            SUBCATE.Show()
            SUBCATE.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripMenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem12.Click
        GmoduleName = "MONTH BILL DETAILS"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SUBCATE As New FRM_RBC_MONTHBILLING
            SUBCATE.Show()
            SUBCATE.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub REPORTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPORTSToolStripMenuItem.Click

    End Sub

    Private Sub ACCOUNTPOSTINGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACCOUNTPOSTINGToolStripMenuItem.Click
        GmoduleName = "ACCOUNT POSTING"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SUBCATE As New JournalRegister
            SUBCATE.Show()
            SUBCATE.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LOCKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOCKToolStripMenuItem.Click
        GmoduleName = "LOCK"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SUBCATE As New LOCK
            SUBCATE.Show()
            SUBCATE.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub REMINDERREPORTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REMINDERREPORTToolStripMenuItem.Click
        GmoduleName = "REMINDER LETTER"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SUBCATE As New Remaindereportlist
            SUBCATE.Show()
            SUBCATE.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EMAILPOSTINGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EMAILPOSTINGToolStripMenuItem.Click
        GmoduleName = "EMAIL_POSTING"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SUBCATE As New EMAILPOSTING
            SUBCATE.Show()
            SUBCATE.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SENDSMSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SENDSMSToolStripMenuItem.Click
        GmoduleName = "SEND SMS"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim ADDLIST As New SendSms
            ADDLIST.Show()
            ADDLIST.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CommitteeDesignationMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommitteeDesignationMasterToolStripMenuItem.Click
        GmoduleName = "Committee Designation Master "
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SUBCATE As New ElectionMaster
            SUBCATE.Show()
            SUBCATE.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CommitteeListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommitteeListToolStripMenuItem.Click
        GmoduleName = "Committee Designation Master "
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SUBCATE As New CommitteeTransaction
            SUBCATE.Show()
            SUBCATE.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem80_Click(sender As Object, e As EventArgs) Handles MenuItem80.Click
        GmoduleName = "CATEGORY MASTER"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim CATE As New frm_mkga_categorymaster
            CATE.Show()
            CATE.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem81_Click(sender As Object, e As EventArgs) Handles MenuItem81.Click
        GmoduleName = "SUBCATEGORY MASTER"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SUBCATE As New frm_mkga_subcategorymaster
            SUBCATE.Show()
            SUBCATE.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem4_Click(sender As Object, e As EventArgs) Handles MenuItem4.Click
        GmoduleName = "SUBSCRIPTION MASTER"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim subscriptionmas As New FRM_MKGA_SUBSCRIPTION_MASTER
            subscriptionmas.Show()
            subscriptionmas.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem5_Click(sender As Object, e As EventArgs) Handles MenuItem5.Click
        GmoduleName = "MEMBER MASTER"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim MEM As New FRM_MEMMASTER
            MEM.Show()
            MEM.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem6_Click(sender As Object, e As EventArgs) Handles MenuItem6.Click
        GmoduleName = "COUNTRY MASTER"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim COUTNRY As New frm_mkga_countrymaster
            COUTNRY.Show()
            COUTNRY.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem7_Click(sender As Object, e As EventArgs) Handles MenuItem7.Click
        GmoduleName = "STATE MASTER"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim STATE As New frm_mkga_Statemaster
            STATE.Show()
            STATE.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem8_Click(sender As Object, e As EventArgs) Handles MenuItem8.Click
        GmoduleName = "CITY MASTER"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim CITY As New frm_mkga_CityMaster
            CITY.Show()
            CITY.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem9_Click(sender As Object, e As EventArgs) Handles MenuItem9.Click
        GmoduleName = "CHARGE MASTER"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim CHARGE As New FRM_MKGA_CHARGEMASTER
            CHARGE.Show()
            CHARGE.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem16_Click(sender As Object, e As EventArgs) Handles MenuItem16.Click
        GmoduleName = "REASON MASTER"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim REASON As New FRM_MKGA_REASONMASTER
            REASON.Show()
            REASON.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem10_Click(sender As Object, e As EventArgs) Handles MenuItem10.Click
        GmoduleName = "CORPORATE MASTER"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim CORP As New CORPORATES_MASTER
            CORP.Show()
            CORP.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem11_Click(sender As Object, e As EventArgs) Handles MenuItem11.Click
        GmoduleName = "SALUTATION MASTER"

        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SAL As New SALUTATION_MASTER
            SAL.Show()
            SAL.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem12_Click(sender As Object, e As EventArgs) Handles MenuItem12.Click

        GmoduleName = "DESIGNATION MASTER"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim DESIGN As New DESIGNATION_MASTER
            DESIGN.Show()
            DESIGN.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem13_Click(sender As Object, e As EventArgs) Handles MenuItem13.Click
        GmoduleName = "PREFESSION MASTER"

        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim PROFES As New PROFESSION_MASTER
            PROFES.Show()
            PROFES.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem14_Click(sender As Object, e As EventArgs) Handles MenuItem14.Click
        GmoduleName = "MARITAL STATUS MASTER"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim MARITAL As New MARTIALSTATUS_MASTER
            MARITAL.Show()
            MARITAL.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem17_Click(sender As Object, e As EventArgs) Handles MenuItem17.Click
        GmoduleName = "SUBSCRIPTION TAGGING"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SUBTAGGING As New FRM_MKGA_SubscriptionTagging
            SUBTAGGING.Show()
            SUBTAGGING.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem18_Click(sender As Object, e As EventArgs)
        GmoduleName = "AFFILIATED CLUB DETAILS"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim AFFILIATED As New FRM_MKGA_AffiliatedClubDetails
            AFFILIATED.Show()
            AFFILIATED.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem42_Click(sender As Object, e As EventArgs) Handles MenuItem42.Click
        GmoduleName = "Committee Designation Master "
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SUBCATE As New ElectionMaster
            SUBCATE.Show()
            SUBCATE.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem18_Click_1(sender As Object, e As EventArgs) Handles MenuItem18.Click
        GmoduleName = "AFFILIATED CLUB DETAILS"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim AFFILIATED As New FRM_MKGA_AffiliatedClubDetails
            AFFILIATED.Show()
            AFFILIATED.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem25_Click(sender As Object, e As EventArgs) Handles MenuItem25.Click
        GmoduleName = "CATEGORY CONVERSTION"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim CATCON As New frm_tkga_CategoryConversion
            CATCON.Show()
            CATCON.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem36_Click(sender As Object, e As EventArgs) Handles MenuItem36.Click
        GmoduleName = "MEMBER ACTIVATION"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim memactive As New FRM_TRANS_MEMBERACTIVATION
            memactive.Show()
            memactive.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem37_Click(sender As Object, e As EventArgs) Handles MenuItem37.Click
        GmoduleName = "MEMBER DEACTIVATION"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim memdeactive As New FRM_TRANS_MEMBERDEACTIVATION
            memdeactive.Show()
            memdeactive.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem47_Click(sender As Object, e As EventArgs) Handles MenuItem47.Click
        GmoduleName = "SUBSCRIPTION POSTING"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SUBPOS As New FRM_TKGA_SUBSCRIPTIONPOSTING
            SUBPOS.Show()
            SUBPOS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem29_Click(sender As Object, e As EventArgs) Handles MenuItem29.Click
        GmoduleName = "Accounttagging"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim accounttagging As New ACCOUNTSITEMTAGGING
            accounttagging.Show()
            accounttagging.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem43_Click(sender As Object, e As EventArgs) Handles MenuItem43.Click
        GmoduleName = "ACCOUNT POSTING"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SUBCATE As New JournalRegister
            SUBCATE.Show()
            SUBCATE.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem44_Click(sender As Object, e As EventArgs) Handles MenuItem44.Click
        GmoduleName = "LOCK"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SUBCATE As New LOCK
            SUBCATE.Show()
            SUBCATE.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem45_Click(sender As Object, e As EventArgs) Handles MenuItem45.Click
        GmoduleName = "REMINDER LETTER"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SUBCATE As New Remaindereportlist
            SUBCATE.Show()
            SUBCATE.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem41_Click(sender As Object, e As EventArgs) Handles MenuItem41.Click
        GmoduleName = "EMAIL_POSTING"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SUBCATE As New EMAILPOSTING
            SUBCATE.Show()
            SUBCATE.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem40_Click(sender As Object, e As EventArgs) Handles MenuItem40.Click
        GmoduleName = "SEND SMS"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim ADDLIST As New SendSms
            ADDLIST.Show()
            ADDLIST.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem46_Click(sender As Object, e As EventArgs) Handles MenuItem46.Click
        GmoduleName = "Committee Designation Master "
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SUBCATE As New CommitteeTransaction
            SUBCATE.Show()
            SUBCATE.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem52_Click(sender As Object, e As EventArgs) Handles MenuItem52.Click
        GmoduleName = "MEMBER ADDRESS LIST"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim ADDLIST As New frm_rkga_MemberAddressList
            ADDLIST.Show()
            ADDLIST.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem53_Click(sender As Object, e As EventArgs) Handles MenuItem53.Click
        GmoduleName = "MEMBER DIRECTORY"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim MEMDIR As New frm_rkga_MemberDirectory
            MEMDIR.Show()
            MEMDIR.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem55_Click(sender As Object, e As EventArgs) Handles MenuItem55.Click
        GmoduleName = "MEMBER STATUS"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim MEMSTATRPT As New RPT_MEMBERSTATUS_REPORT
            MEMSTATRPT.Show()
            MEMSTATRPT.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem56_Click(sender As Object, e As EventArgs) Handles MenuItem56.Click
        GmoduleName = "MEMBER DOB AND  WEDDING LIST"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim WEDD As New FRM_RKGA_MEMBER_DOB_AND_WEDDING_LIST
            WEDD.Show()
            WEDD.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem57_Click(sender As Object, e As EventArgs) Handles MenuItem57.Click
        GmoduleName = "DEPENDENT DETALS"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim DEPENDENT As New DEPENDET
            DEPENDENT.Show()
            DEPENDENT.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem67_Click(sender As Object, e As EventArgs) Handles MenuItem67.Click
        GmoduleName = "SUBSCRIPTION DETAILS"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SUBDET As New RFM_RKGA_SUBSCRIPTIONDETAILS
            SUBDET.Show()
            SUBDET.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem70_Click(sender As Object, e As EventArgs) Handles MenuItem70.Click
        GmoduleName = "SUBSCRIPTION TAGGING"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SUBTAG As New FRM_RKGA_SUBSCRIPTION_TAGGING
            SUBTAG.Show()
            SUBTAG.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem58_Click(sender As Object, e As EventArgs) Handles MenuItem58.Click
        GmoduleName = "MEMBER LEDGER / OUTSTANDING"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim accounttagging As New FRM_RBC_MEMBERLEDGER
            accounttagging.Show()
            accounttagging.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem65_Click(sender As Object, e As EventArgs) Handles MenuItem65.Click
        GmoduleName = "MONTH BILL DETAILS"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SUBCATE As New FRM_RBC_MONTHBILLING
            SUBCATE.Show()
            SUBCATE.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem71_Click(sender As Object, e As EventArgs) Handles MenuItem71.Click
        GmoduleName = "OUTSTANDING LIST"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim OUTSTAND As New OUTSTAND_MEMREP_LIST
            OUTSTAND.Show()
            OUTSTAND.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem77_Click(sender As Object, e As EventArgs) Handles MenuItem77.Click
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            ' Me.Close()
            Dim selectcompany As New CompanyList1
            selectcompany.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem79_Click(sender As Object, e As EventArgs) Handles MenuItem79.Click
        Me.Close()
    End Sub

    Private Sub MenuItem78_Click(sender As Object, e As EventArgs) Handles MenuItem78.Click

    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click

    End Sub

    Private Sub MenuItem49_Click(sender As Object, e As EventArgs) Handles MenuItem49.Click
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            'Me.Close()
            GmoduleName = "OUTLET"
            Dim selectcompany As New FRM_CCLOUTLET
            selectcompany.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem50_Click(sender As Object, e As EventArgs) Handles MenuItem50.Click
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            'Me.Close()
            GmoduleName = "ECSSetup"
            Dim selectcompany As New Frm_ECSSetup
            selectcompany.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem59_Click(sender As Object, e As EventArgs) Handles MenuItem59.Click
        GmoduleName = "NRI SUBSCRIPTION POSTING"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SUBPOS As New FRM_NRI_SUBSCRIPTIONPOSTING
            SUBPOS.Show()
            SUBPOS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem60_Click(sender As Object, e As EventArgs) Handles MenuItem60.Click
        GmoduleName = "ACCOUNT POSTING"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SUBPOS As New FRM_ACCOUNTPOSTING
            SUBPOS.Show()
            SUBPOS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub MenuItem83_Click(sender As Object, e As EventArgs) Handles MenuItem83.Click

    End Sub
    Private Sub MenuItem61_Click(sender As Object, e As EventArgs) Handles MenuItem61.Click
        GmoduleName = "OUTSTANDING SMS"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SUBPOS As New Frm_Outstandingsms
            SUBPOS.Show()
            SUBPOS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem23_Click(sender As Object, e As EventArgs) Handles MenuItem23.Click

    End Sub

    Private Sub MenuItem30_Click(sender As Object, e As EventArgs) Handles MenuItem30.Click

    End Sub

    Private Sub MenuItem54_Click(sender As Object, e As EventArgs) Handles MenuItem54.Click

    End Sub

    Private Sub MenuItem22_Click(sender As Object, e As EventArgs) Handles MenuItem22.Click

    End Sub

    Private Sub MenuItem34_Click(sender As Object, e As EventArgs) Handles MenuItem34.Click

    End Sub

    Private Sub MenuItem27_Click(sender As Object, e As EventArgs) Handles MenuItem27.Click

    End Sub

    Private Sub MenuItem62_Click(sender As Object, e As EventArgs) Handles MenuItem62.Click
        GmoduleName = "BULK DEBIT NOTE"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SUBPOS As New BULK_DR
            SUBPOS.Show()
            SUBPOS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem63_Click(sender As Object, e As EventArgs) Handles MenuItem63.Click
        GmoduleName = "BULK CREDIT NOTE"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SUBPOS As New BULK_CR
            SUBPOS.Show()
            SUBPOS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem28_Click(sender As Object, e As EventArgs) Handles MenuItem28.Click

    End Sub

    Private Sub MenuItem64_Click(sender As Object, e As EventArgs) Handles MenuItem64.Click
        GmoduleName = "TEMPLATE MASTER"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SUBPOS As New SMSMaster
            SUBPOS.Show()
            SUBPOS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem66_Click(sender As Object, e As EventArgs) Handles MenuItem66.Click
        GmoduleName = "BILLSETUP"
        Try
            If Not (Me.ActiveMdiChild Is Nothing) Then
                Me.ActiveMdiChild.Close()
            End If
            Dim SUBPOS As New POSFUNDMASTER
            SUBPOS.Show()
            SUBPOS.MdiParent = Me
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MenuItem39_Click(sender As Object, e As EventArgs) Handles MenuItem39.Click

    End Sub

    Private Sub MenuItem20_Click(sender As Object, e As EventArgs) Handles MenuItem20.Click

    End Sub
End Class


