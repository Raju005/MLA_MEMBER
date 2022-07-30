Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data
Public Class DESIGNATION_MASTER

    Dim boolchk As Boolean
    Dim sqlstring As String
    Dim vSeqNo As Double
    Dim gconnection As New GlobalClass
    Dim CAL As CalendarColumn

    Dim flg As Boolean = False

    Public Function MaritalStatusCode() As Boolean
        flg = False
        sqlstring = "select * from Tbl_DesignationMaster where Code='" & Trim(Txtcode.Text) & "'"
        gconnection.getDataSet(sqlstring, "DesignationMaster")
        If gdataset.Tables("DesignationMaster").Rows.Count > 0 Then
            flg = True
        Else
            flg = False
        End If
        Return flg

    End Function

    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        Dim insert(0) As String
        Dim dt As New DataTable

        Dim FINALLEVEL As Integer
        Dim SSQLSTR2 As String
        Dim USERT As Integer
        Dim gSQLString As String = ""

        flg = False

        If Cmd_Add.Text = "Add[F7]" Then
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            '===========CHECKING MARITIALSTATUS CODE=================
            If MaritalStatusCode() Then
                MessageBox.Show(" Marital Status code alread exists", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Txtcode.Focus()
                Exit Sub
            End If
            '========================================================
            sqlstring = "Insert into Tbl_DesignationMaster"
            sqlstring = sqlstring + "(Code,Name,Freeze,AddUser,Adddatetime)"
            sqlstring = sqlstring + "values('" + Trim(Txtcode.Text) + "','" + Trim(txtName.Text) + "', 'N','" & gUsername & " ', '" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
            gconnection.dataOperation(1, sqlstring, "Tbl_DesignationMaster")
            ' MessageBox.Show("Record Saved Successfully ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Cmd_Clear_Click(sender, e)
        ElseIf Cmd_Add.Text = "Update[F7]" Then
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            If Mid(Me.Cmd_Add.Text, 1, 1) = "U" Then

                If Me.lbl_Freeze.Visible = True Then
                    MessageBox.Show(" void Record Can't Be Updated !", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    boolchk = False
                End If
            End If
            If boolchk = False Then Exit Sub

            SSQLSTR2 = " SELECT * FROM Tbl_DesignationMaster WHERE  Code='" + Trim(Txtcode.Text) + "' AND ISNULL(freeze,'')<>'Y'"
            'SSQLSTR2 = " SELECT * FROM Tbl_DesignationMaster WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')='' AND Code='" + Trim(Txtcode.Text) + "' AND ISNULL(freeze,'')<>'Y'"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then

                flg = updateDesignation()
                If flg Then
                    MsgBox("Record updated successfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, gcompanyname)
                    Me.Cmd_Clear_Click(sender, e)
                    Cmd_Add.Text = "Add[F7]"
                End If
                Exit Sub
            End If
            gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH1USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH1USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "')"
            gconnection.getDataSet(gSQLString, "AUTHORIZELUSER")
            If gdataset.Tables("AUTHORIZELUSER").Rows.Count > 0 Then
                USERT = 1
                FINALLEVEL = Val(gdataset.Tables("AUTHORIZELUSER").Rows(0).Item("AUTHORIZELEVEL"))
            End If
            gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH2USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH2USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "')"
            gconnection.getDataSet(gSQLString, "AUTHORIZELUSER")
            If gdataset.Tables("AUTHORIZELUSER").Rows.Count > 0 Then
                USERT = 2
                FINALLEVEL = Val(gdataset.Tables("AUTHORIZELUSER").Rows(0).Item("AUTHORIZELEVEL"))
            End If
            gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH3USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH3USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "')"
            gconnection.getDataSet(gSQLString, "AUTHORIZELUSER")
            If gdataset.Tables("AUTHORIZELUSER").Rows.Count > 0 Then
                USERT = 3
                FINALLEVEL = Val(gdataset.Tables("AUTHORIZELUSER").Rows(0).Item("AUTHORIZELEVEL"))
            End If
            If USERT = 1 Then
                If USERT = 1 And FINALLEVEL = 1 Then
                    flg = updateDesignation()
                    If flg Then
                        Me.Cmd_Clear_Click(sender, e)
                        Cmd_Add.Text = "Add[F7]"

                    End If
                ElseIf USERT = 1 And FINALLEVEL <> 1 Then 'SELECT * FROM Tbl_DesignationMaster WHERE  Code='" + Trim(Txtcode.Text) + "'"

                    SSQLSTR2 = " SELECT * FROM Tbl_DesignationMaster WHERE  Code='" + Trim(Txtcode.Text) + "' AND ISNULL(freeze,'')<>'Y'"
                    'SSQLSTR2 = " SELECT * FROM Tbl_DesignationMaster WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')='' AND Code='" + Trim(Txtcode.Text) + "' AND ISNULL(freeze,'')<>'Y'"
                    gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                    If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then

                        flg = updateDesignation()
                        If flg Then
                            MsgBox("Record updated successfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, gcompanyname)
                            Me.Cmd_Clear_Click(sender, e)
                            Cmd_Add.Text = "Add[F7]"
                        End If
                    Else
                        MsgBox("Only final level users can update ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
                    End If
                Else
                    MsgBox("Only final level users can update ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
                End If
            ElseIf USERT = 2 Then
                If USERT = 2 And FINALLEVEL = 2 Then
                    flg = updateDesignation()
                    If flg Then
                        MsgBox("Record updated successfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, gcompanyname)
                        Me.Cmd_Clear_Click(sender, e)
                        Cmd_Add.Text = "Add[F7]"
                    End If
                ElseIf USERT = 2 And FINALLEVEL <> 2 Then
                    SSQLSTR2 = " SELECT * FROM Tbl_DesignationMaster WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')='' AND  ISNULL(freeze,'')<>'Y' AND Code='" + Trim(Txtcode.Text) + "' "
                    gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                    If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then

                        flg = updateDesignation()
                        If flg Then
                            MsgBox("Record updated successfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, gcompanyname)
                            Me.Cmd_Clear_Click(sender, e)
                            Cmd_Add.Text = "Add[F7]"
                        End If
                    Else
                        MsgBox("Only final level users can update ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
                    End If
                Else
                    MsgBox(" Only final level users can update ! ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
                End If
            ElseIf USERT = 3 Then
                If USERT = 3 And FINALLEVEL = 3 Then
                    flg = updateDesignation()
                    If flg Then
                        MsgBox("Record updated successfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, gcompanyname)
                        Me.Cmd_Clear_Click(sender, e)
                        Cmd_Add.Text = "Add[F7]"
                    End If
                ElseIf USERT = 3 And FINALLEVEL <> 3 Then
                    SSQLSTR2 = " SELECT * FROM Tbl_DesignationMaster WHERE ISNULL(AUTHORISED,'')<>'Y'  AND ISNULL(freeze,'')<>'Y' AND Code='" + Trim(Txtcode.Text) + "' "
                    gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                    If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                        flg = updateDesignation()
                        If flg Then
                            MsgBox("Record updated successfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, gcompanyname)
                            Me.Cmd_Clear_Click(sender, e)
                            Cmd_Add.Text = "Add[F7]"
                        End If
                    Else
                        MsgBox("Only final level users can update ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
                    End If
                Else
                    MsgBox(" Only final level users can update ! ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
                End If
            Else
                MsgBox("You are not authorized to update! ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
            End If
            End If
    End Sub

    Private Function updateDesignation() As Boolean

        Dim dt As New DataTable
        Dim insert(0) As String
        Dim flg As Boolean = False

        sqlstring = "SELECT * FROM Tbl_DesignationMaster WHERE  Code='" + Trim(Txtcode.Text) + "'"
        dt = gconnection.GetValues(sqlstring)
        If dt.Rows.Count > 0 Then
            sqlstring = "INSERT INTO Tbl_DesignationMaster_LOG (Code,Name,Freeze,Adduser,Adddatetime,UPDATEUSER,UPDATEDATETIME ) VALUES "
            sqlstring = sqlstring & "('" & dt.Rows(0).Item("Code").ToString & "','" & dt.Rows(0).Item("Name").ToString & "','" & dt.Rows(0).Item("Freeze").ToString & "','" & dt.Rows(0).Item("Adduser").ToString & "','" & Format(dt.Rows(0).Item("Adddatetime"), "dd-MMM-yyyy") & "','" & Trim(gUsername) & "','" & Now.ToString("dd-MMM-yyyy") & "') "
        End If
        ReDim Preserve insert(insert.Length)
        insert(insert.Length - 1) = sqlstring
        '==============================================================================
        sqlstring = "Update Tbl_DesignationMaster SET "
        sqlstring = sqlstring + "Name='" + Trim(txtName.Text) + "',Freeze= 'N',UPDATEUSER='" & gUsername & " ', UPDATEDATETIME='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "' Where Code='" + Trim(Txtcode.Text) + "'"
        ReDim Preserve insert(insert.Length)
        insert(insert.Length - 1) = sqlstring

        flg = gconnection.MoreTrans1(insert)

        Return flg

    End Function



    Private Sub Cmd_Freeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Freeze.Click

        Dim FINALLEVEL As Integer
        Dim SSQLSTR2 As String
        Dim USERT As Integer
        Dim gSQLString As String = ""

        Call checkValidation() ''-->Check Validation
        If boolchk = False Then Exit Sub

        gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH1USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH1USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "')"
        gconnection.getDataSet(gSQLString, "AUTHORIZELUSER")
        If gdataset.Tables("AUTHORIZELUSER").Rows.Count > 0 Then
            USERT = 1
            FINALLEVEL = Val(gdataset.Tables("AUTHORIZELUSER").Rows(0).Item("AUTHORIZELEVEL"))
        End If
        gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH2USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH2USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "')"
        gconnection.getDataSet(gSQLString, "AUTHORIZELUSER")
        If gdataset.Tables("AUTHORIZELUSER").Rows.Count > 0 Then
            USERT = 2
            FINALLEVEL = Val(gdataset.Tables("AUTHORIZELUSER").Rows(0).Item("AUTHORIZELEVEL"))
        End If
        gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH3USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH3USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "')"
        gconnection.getDataSet(gSQLString, "AUTHORIZELUSER")
        If gdataset.Tables("AUTHORIZELUSER").Rows.Count > 0 Then
            USERT = 3
            FINALLEVEL = Val(gdataset.Tables("AUTHORIZELUSER").Rows(0).Item("AUTHORIZELEVEL"))
        End If
        If USERT = 1 Then
            If USERT = 1 And FINALLEVEL = 1 Then
                flg = FREEZEDATA()
                If flg Then
                    MsgBox("Record updated successfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, gCompanyname)
                    Me.Cmd_Clear_Click(sender, e)
                    Cmd_Add.Text = "Add[F7]"

                End If
            ElseIf USERT = 1 And FINALLEVEL <> 1 Then 'SELECT * FROM Tbl_DesignationMaster WHERE  Code='" + Trim(Txtcode.Text) + "'"
                SSQLSTR2 = " SELECT * FROM Tbl_DesignationMaster WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')='' AND Code='" + Trim(Txtcode.Text) + "' "
                gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then

                    flg = FREEZEDATA()
                    If flg Then
                        MsgBox("Record updated successfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, gCompanyname)
                        Me.Cmd_Clear_Click(sender, e)
                        Cmd_Add.Text = "Add[F7]"
                    End If
                Else
                    MsgBox("Only final level users can update ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gCompanyname)
                End If
            Else
                MsgBox("Only final level users can update ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gCompanyname)
            End If
        ElseIf USERT = 2 Then

            If USERT = 2 And FINALLEVEL = 2 Then
                flg = FREEZEDATA()
                If flg Then
                    MsgBox("Record updated successfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, gCompanyname)
                    Me.Cmd_Clear_Click(sender, e)
                    Cmd_Add.Text = "Add[F7]"

                End If
            ElseIf USERT = 2 And FINALLEVEL <> 2 Then

                SSQLSTR2 = " SELECT * FROM Tbl_DesignationMaster WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')='' AND Code='" + Trim(Txtcode.Text) + "' "
                gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then

                    flg = FREEZEDATA()
                    If flg Then
                        MsgBox("Record updated successfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, gCompanyname)
                        Me.Cmd_Clear_Click(sender, e)
                        Cmd_Add.Text = "Add[F7]"
                    End If
                Else
                    MsgBox("Only final level users can update ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gCompanyname)
                End If
            Else
                MsgBox(" Only final level users can update ! ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gCompanyname)
            End If

        ElseIf USERT = 3 Then
            If USERT = 3 And FINALLEVEL = 3 Then
                flg = FREEZEDATA()
                If flg Then
                    MsgBox("Record updated successfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, gCompanyname)
                    Me.Cmd_Clear_Click(sender, e)
                    Cmd_Add.Text = "Add[F7]"
                End If
            ElseIf USERT = 3 And FINALLEVEL <> 3 Then

                SSQLSTR2 = " SELECT * FROM Tbl_DesignationMaster WHERE ISNULL(AUTHORISED,'')<>'Y'   AND Code='" + Trim(Txtcode.Text) + "' "
                gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then

                    flg = FREEZEDATA()
                    If flg Then
                        MsgBox("Record updated successfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, gCompanyname)
                        Me.Cmd_Clear_Click(sender, e)
                        Cmd_Add.Text = "Add[F7]"
                    End If

                Else
                    MsgBox("Only final level users can update ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gCompanyname)
                End If
            Else
                MsgBox(" Only final level users can update ! ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gCompanyname)
            End If
        Else
            MsgBox("You are not authorized to update! ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gCompanyname)
        End If




        
    End Sub

    Private Function FREEZEDATA() As Boolean

        Dim insert(0) As String
        Dim DAT As DataTable
        flg = False
        '==================inserting in log table=======================
        sqlstring = "SELECT * FROM Tbl_DesignationMaster WHERE  Code='" + Trim(Txtcode.Text) + "'"
        DAT = gconnection.GetValues(sqlstring)
        If DAT.Rows.Count > 0 Then
            sqlstring = "INSERT INTO Tbl_DesignationMaster_LOG (Code,Name,Freeze,Adduser,Adddatetime,VOIDUSER,VOIDDATETIME ) VALUES "
            sqlstring = sqlstring & "('" & DAT.Rows(0).Item("Code") & "','" & DAT.Rows(0).Item("Name") & "','" & DAT.Rows(0).Item("Freeze") & "','" & DAT.Rows(0).Item("Adduser") & "','" & Format(DAT.Rows(0).Item("Adddatetime"), "dd-MMM-yyyy") & "','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm") & "') "
        End If
        ReDim Preserve insert(insert.Length)
        insert(insert.Length - 1) = sqlstring
        '==========================================
        If Mid(Me.Cmd_Freeze.Text, 1, 1) = "F" Then
            sqlstring = "UPDATE  Tbl_DesignationMaster "
            sqlstring = sqlstring & " SET Freeze= 'Y',VOIDUSER='" & gUsername & " ', VOIDDATETIME=getdate()"
            sqlstring = sqlstring & " WHERE Code = '" & Trim(Txtcode.Text) & "'"
        Else
            sqlstring = "UPDATE  Tbl_DesignationMaster "
            sqlstring = sqlstring & " SET Freeze= 'N',VOIDUSER='" & gUsername & " ', VOIDDATETIME=getdate()"
            sqlstring = sqlstring & " WHERE Code = '" & Trim(Txtcode.Text) & "'"
        End If
        ReDim Preserve insert(insert.Length)
        insert(insert.Length - 1) = sqlstring
        flg = gconnection.MoreTrans1(insert)
        

        Return flg
    End Function


    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        Gr2.Visible = True

    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
       Me.Close()
    End Sub
    Public Sub checkValidation()
        boolchk = False

        If Trim(Txtcode.Text) = "" Then
            MessageBox.Show(" Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Txtcode.Focus()
            Exit Sub
        End If

        If Trim(txtName.Text) = "" Then
            MessageBox.Show(" Description can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtName.Focus()
            Exit Sub
        End If
        boolchk = True
    End Sub

    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        Call clearform(Me)
        Me.lbl_Freeze.Visible = False
        Me.lbl_Freeze.Text = "Record void  On "
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        Cmd_Add.Text = "Add[F7]"
        Txtcode.Text = ""
        txtName.Text = ""
        Txtcode.ReadOnly = False
        txtName.ReadOnly = False
        Cmd_Freeze.Enabled = True
        Cmd_Add.Text = "Add[F7]"
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        Gr2.Visible = False
        Txtcode.Focus()
    End Sub
   
    Private Sub Designation_Master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Call Resize_Form()
        ServerMastbool = True
        Cmd_Clear_Click(sender, e)
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
                        If Controls(i_i).Name = "GroupBox2" Then
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
                        If Controls(i_i).Name = "GroupBox2" Then
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
                        If Controls(i_i).Name = "Cmd_Clear" Or Controls(i_i).Name = "Cmd_Add" Or Controls(i_i).Name = "Cmd_freeze" Or Controls(i_i).Name = "Cmd_view" Or Controls(i_i).Name = "Cmd_Authantication" Or Controls(i_i).Name = "Cmd_exit" Then
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

    Private Sub Designation_Master_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F7 Then
                If Cmd_Add.Enabled = True Then
                    Call Cmd_Add_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F6 Then
                If Cmd_Clear.Enabled = True Then
                    Call Cmd_Clear_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F9 Then
                If Cmd_View.Enabled = True Then
                    'Call Cmd_View_Click(sender, e)
                    Gr2.Visible = True
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F8 Then
                If Cmd_Freeze.Enabled = True Then
                    Call Cmd_Freeze_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F11 Then
                If Cmd_Exit.Enabled = True Then
                    Call Cmd_Exit_Click(sender, e)
                    Exit Sub
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Designation_Master_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        ServerMastbool = False
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
        Me.Cmd_Add.Enabled = False
        Me.Cmd_Freeze.Enabled = False
        Cmd_View.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.Cmd_Add.Enabled = True
                    Me.Cmd_Freeze.Enabled = True
                    Me.Cmd_View.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.Cmd_Add.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.Cmd_Add.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.Cmd_Add.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    Me.Cmd_Freeze.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.Cmd_View.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub cmdRankMasterHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMasterHelp.Click
        Dim vform As New LIST_OPERATION1
        gSQLString = "SELECT ISNULL(CODE,'') AS CODE,ISNULL(NAME,'') AS NAME  FROM Tbl_DesignationMaster "
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = ""
        End If
        vform.Field = "NAME"
        vform.vCaption = "MASTER HELP "
        vform.CMB_SRC_FIELDS.Select()
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            Txtcode.Text = Trim(vform.keyfield & "")
            txtName.Text = Trim(vform.keyfield1 & "")
            Cmd_Add.Text = "Update[F7]"
            Txtcode.ReadOnly = True
            txtName.Focus()
        End If
        vform.Close()
        vform = Nothing
       
        Dim dt As New DataTable
        Dim ssql As String
        ssql = " Select *  From Tbl_DesignationMaster Where Code='" & Txtcode.Text & "'"
        dt = gconnection.GetValues(ssql)
        If dt.Rows.Count > 0 Then
            If dt.Rows(0).Item("Freeze") = "Y" Then
                Me.Cmd_Freeze.Text = "UnFreeze[F8]"
                lbl_Freeze.Text = "Report void on "
                lbl_Freeze.Text = lbl_Freeze.Text + "" + DateTime.Parse(dt.Rows(0).Item("VOIDDATETIME")).ToShortDateString()
                lbl_Freeze.Visible = True
            Else
                Me.Cmd_Freeze.Text = "Freeze[F8]"
            End If
            Me.Cmd_Add.Text = "Update[F7]"
            txtName.Focus()
        Else
            Me.Cmd_Add.Text = "Add[F7]"
        End If
        gconnection.closeConnection()
    End Sub


    Private Sub Txtcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtcode.TextChanged

    End Sub


    Private Sub Txtcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtcode.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Txtcode.Text = "" Then
                    cmdRankMasterHelp_Click(sender, e)
                Else
                    Dim dt As New DataTable
                    Dim ssql As String
                    ssql = " SELECT *  FROM Tbl_DesignationMaster Where Code='" & Txtcode.Text & "'"
                    dt = gconnection.GetValues(ssql)
                    If dt.Rows.Count > 0 Then

                        If dt.Rows(0).Item("Freeze") = "Y" Then
                            Me.Cmd_Freeze.Text = "UnFreeze[F8]"
                            lbl_Freeze.Text = "Report void on "
                            lbl_Freeze.Text = lbl_Freeze.Text & DateTime.Parse(dt.Rows(0).Item("VOIDDATETIME")).ToShortDateString()
                            lbl_Freeze.Visible = True
                        Else
                            Me.Cmd_Freeze.Text = "Freeze[F8]"
                        End If
                        Me.Cmd_Add.Text = "Update[F7]"
                        Txtcode.ReadOnly = True
                        txtName.Focus()
                        Me.txtName.Text = dt.Rows(0).Item("NAME")
                    Else
                        Me.Cmd_Add.Text = "Add[F7]"
                        txtName.Focus()
                    End If
                    gconnection.closeconnection()
                End If
            ElseIf e.KeyCode = Keys.F4 Then
                cmdRankMasterHelp_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub


    Private Sub Txtcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtcode.KeyPress
        getAlphanumeric(e)
    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        getCharater(e)
    End Sub

    Private Sub Txtcode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtcode.Validated

    End Sub

    Private Sub BUT_AUTHRIZE_Click(sender As Object, e As EventArgs) Handles BUT_AUTHRIZE.Click
        Dim SSQLSTR, SSQLSTR2 As String
        Dim USERT As Integer
        gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH1USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH1USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "')"
        gconnection.getDataSet(gSQLString, "AUTHORIZELUSER")
        If gdataset.Tables("AUTHORIZELUSER").Rows.Count > 0 Then
            USERT = 1
        End If
        gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH2USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH2USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "')"
        gconnection.getDataSet(gSQLString, "AUTHORIZELUSER")
        If gdataset.Tables("AUTHORIZELUSER").Rows.Count > 0 Then
            USERT = 2
        End If
        gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH3USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH3USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "')"
        gconnection.getDataSet(gSQLString, "AUTHORIZELUSER")
        If gdataset.Tables("AUTHORIZELUSER").Rows.Count > 0 Then
            USERT = 3
        End If
        If USERT = 1 Then
            SSQLSTR2 = " SELECT * FROM Tbl_DesignationMaster WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER1,'')=''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH1USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH1USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE")
                If gdataset.Tables("AUTHORIZE").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND ISNULL(AUTHORIZELEVEL,0)>0 "
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM Tbl_DesignationMaster WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER1,'')=''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()
                           
                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE Tbl_DesignationMaster set  ", "CODE", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 1, 1)
                        End If
                    Else
                        MsgBox("NO AUTHORIZATION REQUIRED FOR THE ENTRY")
                    End If
                End If
            End If
        ElseIf USERT = 2 Then
            SSQLSTR2 = " SELECT * FROM Tbl_DesignationMaster WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')='' AND ISNULL(AUTHORISE_USER1,'')<>''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH2USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH2USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE1")
                If gdataset.Tables("AUTHORIZE1").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "'"
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM Tbl_DesignationMaster WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')=''AND ISNULL(AUTHORISE_USER1,'')<>''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()
                           
                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE Tbl_DesignationMaster set  ", "CODE", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 2, 1)
                        End If
                    End If
                End If
            End If
            ElseIf USERT = 3 Then
            SSQLSTR2 = " SELECT * FROM Tbl_DesignationMaster WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')=''AND ISNULL(AUTHORISE_USER1,'')<>''  AND ISNULL(AUTHORISE_USER2,'')<>''"
                gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH3USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH3USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "')"
                    gconnection.getDataSet(gSQLString, "AUTHORIZE2")
                    If gdataset.Tables("AUTHORIZE2").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "'"
                        gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                        If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM Tbl_DesignationMaster WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')=''"
                            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                                Dim VIEW1 As New AUTHORISATION
                                VIEW1.Show()
                                VIEW1.DTAUTH.DataSource = Nothing
                                VIEW1.DTAUTH.Rows.Clear()
                                
                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE Tbl_DesignationMaster set  ", "CODE", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 3, 1)
                            End If
                        End If
                    End If
                Else
                    MsgBox("U R NOT ELIGIBLE TO AUTHORISE IN ANY LEVEL", MsgBoxStyle.Critical)
                End If
            End If
        ' End If
    End Sub

    Private Sub BUT_BROWSE_Click(sender As Object, e As EventArgs) Handles BUT_BROWSE.Click
        brows = True
        Dim VIEW1 As New VIEWHDR
        VIEW1.Show()
        VIEW1.DTGRDHDR.DataSource = Nothing
        VIEW1.DTGRDHDR.Rows.Clear()
        Dim STRQUERY As String
        STRQUERY = "SELECT * FROM Tbl_DesignationMaster"
        'STRQUERY = "SELECT isnull(MODULENAME,'')as MODULENAME,isnull(FORMNAME,'') as FORMNAME,isnull(FORMTYPE,'')as FORMTYPE,isnull(AUTHORIZELEVEL,'')as AUTHORIZELEVEL,isnull(AUTH1USER1,'')as AUTH1USER1,isnull(AUTH1USER2,'') as AUTH1USER2,isnull(AUTH2USER1,'')as  AUTH2USER1,isnull(AUTH2USER2,'')as AUTH2USER2,isnull(AUTH3USER1,'')as AUTH3USER1,isnull(AUTH3USER2,'') as AUTH3USER2,isnull(void,'') as void,isnull(ADDUSERID,'')as ADDUSERID,isnull(ADDDATETIME,'')as ADDDATETIME FROM authorize"
        gconnection.getDataSet(STRQUERY, "authorize")

        Call VIEW1.LOADGRID(gdataset.Tables("authorize"), True, gcompanyname, "SELECT * FROM Tbl_DesignationMaster", "Code", 1, Me.Txtcode)
    End Sub

    Private Sub CMD_DOS_Click(sender As Object, e As EventArgs) Handles CMD_DOS.Click
        Dim reportdesign As New ReportDesigner
        gheader = " MASTER VIEW "
        If Txtcode.Text.Length > 0 Then
            tables = " FROM Tbl_DesignationMaster where Code = '" & Trim(Txtcode.Text) & "'"
        Else
            tables = " FROM Tbl_DesignationMaster "
        End If
        reportdesign.DataGridView1.ColumnCount = 2
        reportdesign.DataGridView1.Columns(0).Name = "Column Name"
        reportdesign.DataGridView1.Columns(0).Width = 380
        reportdesign.DataGridView1.Columns(1).Name = "Size"
        reportdesign.DataGridView1.Columns(1).Width = 100

        Dim row As String() = New String() {"CODE", "10"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"NAME", "20"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"FREEZE", "10"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"ADDUSER", "12"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"ADDDATETIME", "11"}
        reportdesign.DataGridView1.Rows.Add(row)

        row = New String() {"UPDATEUSER", "12"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"UPDATEDATETIME", "11"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"VOIDUSER", "12"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"VOIDDATETIME", "11"}
        reportdesign.DataGridView1.Rows.Add(row)


        Dim chk As New DataGridViewCheckBoxColumn()
        reportdesign.DataGridView1.Columns.Insert(0, chk)
        chk.HeaderText = "Check"
        chk.Name = "chk"
        reportdesign.BUT_GEN_VIEW.Select()
        reportdesign.ShowDialog(Me)
    End Sub

    Private Sub CMD_WINDOWS_Click(sender As Object, e As EventArgs) Handles CMD_WINDOWS.Click
        Dim txtobj1 As TextObject
        Dim Viewer As New REPORTVIEWER
        sqlstring = "select * from view_DesignationMaster"
        If Txtcode.Text = "" Then
            sqlstring = sqlstring & ""
        Else
            sqlstring = sqlstring & "WHERE Code = '" & Txtcode.Text & "' "
        End If
        Dim r As New Cry_Designationmaster
        gconnection.getDataSet(sqlstring, "view_DesignationMaster")

        If gdataset.Tables("view_DesignationMaster").Rows.Count > 0 Then

            Viewer.TableName = "view_DesignationMaster"

            Call Viewer.GetDetails(sqlstring, "view_DesignationMaster", r)
            txtobj1 = r.ReportDefinition.ReportObjects("Text13")
            txtobj1.Text = UCase(gcompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text14")
            txtobj1.Text = UCase(gCompanyAddress(0))
            txtobj1 = r.ReportDefinition.ReportObjects("Text15")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text16")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text17")
            txtobj1.Text = UCase(gCompanyAddress(3))
            txtobj1 = r.ReportDefinition.ReportObjects("Text7")
            txtobj1.Text = UCase(gCompanyAddress(4))
            txtobj1 = r.ReportDefinition.ReportObjects("Text8")
            txtobj1.Text = UCase(gCompanyAddress(5))

            txtobj1 = r.ReportDefinition.ReportObjects("Text19")
            txtobj1.Text = UCase(gFinancalyearStart)
            txtobj1 = r.ReportDefinition.ReportObjects("Text22")
            txtobj1.Text = UCase(gFinancialyearEnd)

            txtobj1 = r.ReportDefinition.ReportObjects("Text27")
            txtobj1.Text = UCase(gUsername)

            Viewer.Show()
        Else
            MsgBox(" NO RECORD AVAILABLE ! ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)

        End If
       
    End Sub

    Private Sub cmd_exit1_Click(sender As Object, e As EventArgs) Handles cmd_exit1.Click
        Gr2.Visible = False
        Txtcode.Focus()
    End Sub
End Class
