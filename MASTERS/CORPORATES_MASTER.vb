Imports CrystalDecisions.CrystalReports.Engine
Imports System.Text.RegularExpressions
Imports System.Data
Imports System.Data.SqlClient

Public Class CORPORATES_MASTER

    Dim SqlString, emailst As String
    Dim boolchk As Boolean
    Dim gconnection As New GlobalClass
    Dim MembershipTo_VAL As String
    Dim ssql As String
    Dim CUR As Integer
    Dim memdet As New DataTable
    Public dt As New DataTable
    Dim CAL As CalendarColumn
    Dim CALC As CalendarCell
    Dim CALCC As CalendarEditingControl





    '==================COLUMNS ADDED IN CORPORATEMASTER TABLE============================

    'ALTER TABLE CorporateMaster ADD PAID_UP_CAPITAL NUMERIC
    'ALTER TABLE CorporateMaster ADD NETWORTH NUMERIC
    'ALTER TABLE CorporateMaster ADD CORPORATE_TYPE VARCHAR(20)

    '====================================================================================

    Private Sub BUT_CCODE_HELP_Click(sender As Object, e As EventArgs) Handles BUT_CCODE_HELP.Click

        Dim vform As New LIST_OPERATION1
        gSQLString = "Select DISTINCT CMCorporateCode,CMCorporateName from CorporateMaster"
        M_WhereCondition = " "
        vform.vCaption = "Corporate Master Help"
        vform.Field = "CMCorporateName,CMCorporateCode"

        vform.CMB_SRC_FIELDS.Select()
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            TXT_C_CODE.Text = Trim(vform.keyfield & "")
            TXT_C_NAME.Select()
            TXT_C_CODE_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing
        BUT_ADD.Text = "Update[F7]"
        '====gridview can't be updated==
        DataGridView1.ReadOnly = True

    End Sub

    'Private Sub autogenerate()
    '    Dim sqlstring As String
    '    'Dim financalyear As String 
    '    Try
    '        gcommand = New SqlCommand
    '        'financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialyearEnd, 3, 4)
    '        sqlstring = "SELECT  MAX(Isnull(CMCorporateCode,0)) FROM CORPORATEMASTER"
    '        gconnection.openConnection()
    '        gcommand.CommandText = sqlstring
    '        gcommand.CommandType = CommandType.Text
    '        gcommand.Connection = gconnection.Myconn
    '        gdreader = gcommand.ExecuteReader
    '        If gdreader.Read Then
    '            If gdreader(0) Is System.DBNull.Value Then
    '                TXT_C_CODE.Text = "0000001"
    '                gdreader.Close()
    '                gcommand.Dispose()
    '                gconnection.closeConnection()
    '            Else
    '                TXT_C_CODE.Text = Format(gdreader(0) + 1, "0000000")
    '                gdreader.Close()
    '                gcommand.Dispose()
    '                gconnection.closeConnection()
    '            End If
    '        Else
    '            TXT_C_CODE.Text = "0000001"
    '            gdreader.Close()
    '            gcommand.Dispose()
    '            gconnection.closeConnection()
    '        End If
    '    Catch ex As Exception
    '        Exit Sub
    '    Finally
    '        gdreader.Close()
    '        gcommand.Dispose()
    '        gconnection.closeConnection()
    '    End Try
    'End Sub

    'Public Function SHOWGRID()

    '    DataGridView1.Rows.Clear()
    '    DataGridView1.ColumnCount = 10
    '    DataGridView1.Columns(0).Name = "NAME"
    '    DataGridView1.Columns(0).Width = 200
    '    DataGridView1.Columns(1).Name = "ADDRESS1"
    '    DataGridView1.Columns(1).Width = 100
    '    DataGridView1.Columns(2).Name = "ADDRESS2"
    '    DataGridView1.Columns(2).Width = 100
    '    DataGridView1.Columns(3).Name = "ADDRESS3"
    '    DataGridView1.Columns(3).Width = 100
    '    DataGridView1.Columns(4).Name = "CITY"
    '    DataGridView1.Columns(4).Width = 100
    '    DataGridView1.Columns(5).Name = "STATE"
    '    DataGridView1.Columns(5).Width = 100
    '    DataGridView1.Columns(6).Name = "PINCODE"
    '    DataGridView1.Columns(6).Width = 100
    '    DataGridView1.Columns(7).Name = "CELLNO"
    '    DataGridView1.Columns(7).Width = 100
    '    DataGridView1.Columns(8).Name = "EMAIL"
    '    DataGridView1.Columns(8).Width = 100
    '    DataGridView1.Columns(9).Name = "REMARKS"
    '    DataGridView1.Columns(9).Width = 100

    '    Dim delbtn As New DataGridViewButtonColumn()
    '    DataGridView1.Columns.Insert(0, delbtn)
    '    delbtn.HeaderText = "Click Delete"
    '    delbtn.Text = "Delete"
    '    delbtn.Name = "del"
    '    DataGridView1.Columns(0).Width = 50
    '    delbtn.UseColumnTextForButtonValue = True

    '
    '    Dim desig As New DataGridViewComboBoxColumn()
    '    desig.HeaderText = "Designation"
    '    desig.Name = "desig"
    '    desig.MaxDropDownItems = 4
    '    desig.Items.Add("")
    '    desig.Items.Add("Director")
    '    desig.Items.Add("Executive")
    '    DataGridView1.Columns.Insert(2, desig)

    '    Dim col As New CalendarColumn()
    '    Me.DataGridView1.Columns.Insert(3, col)
    '    DataGridView1.Columns(3).Width = 100
    '    col.HeaderText = "DOB"
    '    col.Name = "DOB"

    '    'BIND_CITYC()

    'End Function
   


    Private Sub BUT_NOMINEE_DET_Click(sender As Object, e As EventArgs) Handles BUT_NOMINEE_DET.Click

        If TXT_C_CODE.Text.Length > 0 Then

            Dim i As Integer
            memdet = Nothing
            Call ClrGrid()

            SqlString = "SELECT ISNULL(MNAME,'') AS MNAME,ISNULL(Designation,'')AS DESIGNATION,ISNULL(CAST(CONVERT(VARCHAR(11),DOB,106)AS DATETIME),'')AS DOB,ISNULL(CONTADD1,'')AS CADD1,ISNULL(CONTADD2,'')AS CADD2,ISNULL(CONTADD3,'')AS CADD3,ISNULL(CONTCITY,'')AS CCITY,ISNULL(CONTSTATE,'')AS CSTATE,ISNULL(CONTCOUNTRY,'')AS CCOUNTRY,ISNULL(CONTPIN,'')AS CPIN ,ISNULL(CONTCELL,'')AS CCELL ,ISNULL(CONTEMAIL,'')AS CEMAIL FROM membermaster where isnull(corporatecode,'')='" & TXT_C_CODE.Text & "'order by mcode"
            memdet = gconnection.GetValues(SqlString)
            If memdet.Rows.Count > 0 Then
                GroupBox4.Visible = True

                For i = 0 To memdet.Rows.Count - 1
                    DataGridView1.Rows.Add(1)
                    Dim CITY As DataGridViewComboBoxCell = New DataGridViewComboBoxCell
                    CITY.DataSource = memdet
                    CITY.DisplayMember = "CCITY"
                    CITY.ValueMember = "CCITY"
                    DataGridView1.Rows(i).Cells(6) = CITY

                    DataGridView1.Rows(i).Cells(0).Value = memdet.Rows(i).Item("MNAME").ToString
                    DataGridView1.Rows(i).Cells(3).Value = memdet.Rows(i).Item("CADD1").ToString
                    DataGridView1.Rows(i).Cells(4).Value = memdet.Rows(i).Item("CADD2").ToString
                    DataGridView1.Rows(i).Cells(5).Value = memdet.Rows(i).Item("CADD3").ToString
                    DataGridView1.Rows(i).Cells(6).Value = memdet.Rows(i).Item("CCITY").ToString
                    DataGridView1.Rows(i).Cells(7).Value = memdet.Rows(i).Item("CSTATE").ToString
                    DataGridView1.Rows(i).Cells(8).Value = memdet.Rows(i).Item("CCOUNTRY").ToString
                    DataGridView1.Rows(i).Cells(9).Value = memdet.Rows(i).Item("CPIN").ToString
                    DataGridView1.Rows(i).Cells(10).Value = memdet.Rows(i).Item("CCELL").ToString
                    DataGridView1.Rows(i).Cells(11).Value = memdet.Rows(i).Item("CEMAIL").ToString
                    DataGridView1.Rows(i).Cells(2).Value = DateTime.Parse(memdet.Rows(i).Item("DOB")).ToShortDateString
                    DataGridView1.Rows(i).Cells(1).Value = memdet.Rows(i).Item("DESIGNATION").ToString
                Next
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
            Else
                GroupBox4.Visible = True
            End If



        End If
    End Sub

    Public Function bindGridCity()
        memdet = Nothing

        SqlString = "select Name from Tbl_CityMaster order by Name"
        memdet = gconnection.GetValues(SqlString)
        If memdet.Rows.Count > 0 Then
            For i = 0 To DataGridView1.RowCount - 1
                Dim CITY As DataGridViewComboBoxCell = New DataGridViewComboBoxCell
                CITY.DataSource = memdet
                CITY.DisplayMember = "Name"
                CITY.ValueMember = "Name"
                DataGridView1.Rows(i).Cells(6) = CITY
                DataGridView1.Columns(6).Width = 200
            Next
        End If

    End Function

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)

        'Dim cnt As Integer = 0
        'If dt.Rows.Count = 0 Then
        '    SqlString = "select Name from Tbl_CityMaster order by Name"
        '    dt = gconnection.GetValues(SqlString)
        'End If
        'Try

        'If e.ColumnIndex = 0 Then
        '    If DataGridView1.Rows.Count > 1 Then
        '        DataGridView1.Rows.RemoveAt(DataGridView1.CurrentCell.RowIndex)
        '    End If
        'ElseIf e.ColumnIndex = 6 Then
        '        'Dim CITY As DataGridViewComboBoxCell = New DataGridViewComboBoxCell
        'If dt.Rows.Count > 0 Then
        '    For i = 0 To DataGridView1.RowCount - 1
        '        If (DataGridView1.NewRowIndex = i) Then

        '            CITY.DataSource = dt
        '            CITY.DisplayMember = "Name"
        '            CITY.ValueMember = "Name"
        '            DataGridView1.Rows(i).Cells(6) = CITY
        '        End If
        '    Next
        'Else
        '    MsgBox("UNABLE TO BIND CITY !")
        'End If
        'End If
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        Try

            'If e.ColumnIndex = 0 Then
            '    If DataGridView1.Rows.Count > 1 Then
            '        DataGridView1.Rows.RemoveAt(DataGridView1.CurrentCell.RowIndex)
            '    End If
            'End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub DataGridView1_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs)

        If dt.Rows.Count = 0 Then
            SqlString = "select Name from Tbl_CityMaster order by Name"
            dt = gconnection.GetValues(SqlString)
        End If

        Dim CITY As DataGridViewComboBoxCell = New DataGridViewComboBoxCell
        If dt.Rows.Count > 0 Then
            For i = 0 To DataGridView1.RowCount - 1
                If (DataGridView1.NewRowIndex = i) Then

                    CITY.DataSource = dt
                    CITY.DisplayMember = "Name"
                    CITY.ValueMember = "Name"
                    DataGridView1.Rows(i).Cells(6) = CITY
                End If
            Next
        Else
            MsgBox("UNABLE TO BIND CITY !")
        End If


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
        Me.BUT_ADD.Enabled = False
        Me.BUT_FREEZE.Enabled = False
        Me.BUT_LST_VIEW.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.BUT_ADD.Enabled = True
                    Me.BUT_FREEZE.Enabled = True
                    Me.BUT_LST_VIEW.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.BUT_ADD.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.BUT_ADD.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.BUT_ADD.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    Me.BUT_FREEZE.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.BUT_LST_VIEW.Enabled = True
                End If
            Next
        End If
    End Sub


    Private Sub CORPORATES_MASTER_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.F7 Then
            Call BUT_ADD_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F6 Then
            Call BUT_CLR_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F8 Then
            Call BUT_FREEZE_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F9 Then
            'Call BUT_LST_VIEW_Click(sender, e)
            Gr2.Visible = True
            Exit Sub
        ElseIf e.KeyCode = Keys.F11 Then
            Call BUT_EXIT_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F10 Then
            BUT_OK_Click_1(sender, e)

        End If

    End Sub

    Private Sub CORPORATES_MASTER_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackgroundImageLayout = ImageLayout.Stretch
        Call Resize_Form()
        ' Call Resize_Form()
        Call Clrs()
        CMB_CITY_SelectedIndexChanged(sender, e)
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
                        If Controls(i_i).Name = "Panel1" Then
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
                        If Controls(i_i).Name = "Panel1" Then
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
                        If Controls(i_i).Name = "BUT_CLR" Or Controls(i_i).Name = "BUT_ADD" Or Controls(i_i).Name = "BUT_FREEZE" Or Controls(i_i).Name = "BUT_LST_VIEW" Or Controls(i_i).Name = "BUT_BROWSE" Or Controls(i_i).Name = "BUT_AUTHRIZE" Or Controls(i_i).Name = "BUT_EXIT" Then
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
    'Private Sub Resize_Form()
    '    Dim cControl As Control
    '    Dim i_i As Integer
    '    Dim J, K, L, M, n, o, P, Q, R, S As Integer
    '    If (Screen.PrimaryScreen.Bounds.Height = 768) And (Screen.PrimaryScreen.Bounds.Width = 1024) Then
    '        Exit Sub
    '    End If

    '    Me.ResizeRedraw = True
    '    J = CInt(Screen.PrimaryScreen.WorkingArea.Size.Height)
    '    K = CInt(Screen.PrimaryScreen.WorkingArea.Size.Width)
    '    Me.Location = Screen.PrimaryScreen.WorkingArea.Location
    '    Me.StartPosition = FormStartPosition.CenterScreen
    '    Me.Size = Screen.PrimaryScreen.WorkingArea.Size
    '    Me.Width = K
    '    Me.Height = J
    '    'If Me.Location.X = 0 Then
    '    '    L = 0
    '    'Else
    '    '    L = Me.Location.X + CInt((Me.Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - 1024) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
    '    'End If
    '    'If Me.Location.Y = 0 Then
    '    '    L = 0

    '    'Else
    '    '    M = Me.Location.Y + CInt((Me.Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - 768) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
    '    'End If
    '    'Me.Width = L
    '    'Me.Height = M

    '    With Me
    '        For i_i = 0 To .Controls.Count - 1




    '            If TypeOf .Controls(i_i) Is Label Then
    '                If .Controls(i_i).Location.X = 0 Then
    '                    L = 0
    '                Else
    '                    L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - 1024) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
    '                End If
    '                If .Controls(i_i).Location.Y = 0 Then
    '                    L = 0

    '                Else
    '                    M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - 768) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
    '                End If

    '                .Controls(i_i).Left = L
    '                .Controls(i_i).Top = M
    '                If .Controls(i_i).Size.Width = 0 Then
    '                    n = 0
    '                Else
    '                    n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - 1024) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
    '                End If
    '                If .Controls(i_i).Size.Height = 0 Then
    '                    o = 0
    '                Else
    '                    o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - 768) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
    '                End If

    '                .Controls(i_i).Width = n
    '                .Controls(i_i).Height = o
    '            End If
    '            '''''''''''''''''''''''''''''''''''''
    '            If TypeOf .Controls(i_i) Is Form Then


    '                If .Controls(i_i).Location.X = 0 Then
    '                    L = 0
    '                Else
    '                    L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - 1024) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
    '                End If
    '                If .Controls(i_i).Location.Y = 0 Then
    '                    L = 0

    '                Else
    '                    M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - 768) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
    '                End If

    '                .Controls(i_i).Left = L
    '                .Controls(i_i).Top = M
    '                If .Controls(i_i).Size.Width = 0 Then
    '                    n = 0
    '                Else
    '                    n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - 1024) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
    '                End If
    '                If .Controls(i_i).Size.Height = 0 Then
    '                    o = 0
    '                Else
    '                    o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - 768) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
    '                End If

    '                .Controls(i_i).Width = n
    '                .Controls(i_i).Height = o

    '                For Each cControl In .Controls(i_i).Controls

    '                    If cControl.Location.X = 0 Then
    '                        R = 0
    '                    Else
    '                        R = cControl.Location.X + CInt((cControl.Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - 1024) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
    '                    End If
    '                    If cControl.Location.Y = 0 Then
    '                        S = 0
    '                    Else
    '                        S = cControl.Location.Y + CInt((cControl.Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - 768) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
    '                    End If

    '                    cControl.Left = R
    '                    cControl.Top = S


    '                    If cControl.Size.Width = 0 Then
    '                        P = 0
    '                    Else
    '                        P = (cControl.Size.Width + CInt((cControl.Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - 1024) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width)))))
    '                    End If

    '                    If cControl.Size.Height = 0 Then
    '                        Q = 0
    '                    Else
    '                        Q = (cControl.Size.Height + CInt((cControl.Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - 768) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height)))))
    '                    End If

    '                    cControl.Width = P
    '                    cControl.Height = Q
    '                Next

    '                '''''''''''''''''''''''''''''
    '            ElseIf TypeOf .Controls(i_i) Is GroupBox Then


    '                If .Controls(i_i).Location.X = 0 Then
    '                    L = 0
    '                Else
    '                    L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - 1024) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
    '                End If
    '                If .Controls(i_i).Location.Y = 0 Then
    '                    L = 0

    '                Else
    '                    M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - 768) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
    '                End If

    '                .Controls(i_i).Left = L
    '                .Controls(i_i).Top = M
    '                If .Controls(i_i).Size.Width = 0 Then
    '                    n = 0
    '                Else
    '                    n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - 1024) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
    '                End If
    '                If .Controls(i_i).Size.Height = 0 Then
    '                    o = 0
    '                Else
    '                    o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - 768) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
    '                End If

    '                .Controls(i_i).Width = n
    '                .Controls(i_i).Height = o

    '                For Each cControl In .Controls(i_i).Controls

    '                    If cControl.Location.X = 0 Then
    '                        R = 0
    '                    Else
    '                        R = cControl.Location.X + CInt((cControl.Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - 1024) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
    '                    End If
    '                    If cControl.Location.Y = 0 Then
    '                        S = 0
    '                    Else
    '                        S = cControl.Location.Y + CInt((cControl.Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - 768) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
    '                    End If

    '                    cControl.Left = R
    '                    cControl.Top = S


    '                    If cControl.Size.Width = 0 Then
    '                        P = 0
    '                    Else
    '                        P = (cControl.Size.Width + CInt((cControl.Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - 1024) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width)))))
    '                    End If

    '                    If cControl.Size.Height = 0 Then
    '                        Q = 0
    '                    Else
    '                        Q = (cControl.Size.Height + CInt((cControl.Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - 768) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height)))))
    '                    End If

    '                    cControl.Width = P
    '                    cControl.Height = Q
    '                Next
    '            ElseIf TypeOf .Controls(i_i) Is Label Then
    '                If .Controls(i_i).Location.X = 0 Then
    '                    L = 0
    '                Else
    '                    L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - 1024) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
    '                End If
    '                If .Controls(i_i).Location.Y = 0 Then
    '                    L = 0

    '                Else
    '                    M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - 768) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
    '                End If

    '                .Controls(i_i).Left = L
    '                .Controls(i_i).Top = M
    '                If .Controls(i_i).Size.Width = 0 Then
    '                    n = 0
    '                Else
    '                    n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - 1024) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
    '                End If
    '                If .Controls(i_i).Size.Height = 0 Then
    '                    o = 0
    '                Else
    '                    o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - 768) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
    '                End If

    '                .Controls(i_i).Width = n
    '                .Controls(i_i).Height = o
    '            ElseIf TypeOf .Controls(i_i) Is Panel Then


    '                If .Controls(i_i).Location.X = 0 Then
    '                    L = 0
    '                Else
    '                    L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - 1024) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
    '                End If
    '                If .Controls(i_i).Location.Y = 0 Then
    '                    L = 0

    '                Else
    '                    M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - 768) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
    '                End If

    '                .Controls(i_i).Left = L
    '                .Controls(i_i).Top = M
    '                If .Controls(i_i).Size.Width = 0 Then
    '                    n = 0
    '                Else
    '                    n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - 1024) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
    '                End If
    '                If .Controls(i_i).Size.Height = 0 Then
    '                    o = 0
    '                Else
    '                    o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - 768) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
    '                End If

    '                .Controls(i_i).Width = n
    '                .Controls(i_i).Height = o

    '                For Each cControl In .Controls(i_i).Controls

    '                    If cControl.Location.X = 0 Then
    '                        R = 0
    '                    Else
    '                        R = cControl.Location.X + CInt((cControl.Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - 1024) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
    '                    End If
    '                    If cControl.Location.Y = 0 Then
    '                        S = 0
    '                    Else
    '                        S = cControl.Location.Y + CInt((cControl.Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - 768) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
    '                    End If

    '                    cControl.Left = R
    '                    cControl.Top = S


    '                    If cControl.Size.Width = 0 Then
    '                        P = 0
    '                    Else
    '                        P = (cControl.Size.Width + CInt((cControl.Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - 1024) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width)))))
    '                    End If

    '                    If cControl.Size.Height = 0 Then
    '                        Q = 0
    '                    Else
    '                        Q = (cControl.Size.Height + CInt((cControl.Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - 768) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height)))))
    '                    End If

    '                    cControl.Width = P
    '                    cControl.Height = Q
    '                Next

    '            End If
    '        Next i_i
    '    End With
    'End Sub

    Private Sub BUT_EXIT_Click(sender As Object, e As EventArgs) Handles BUT_EXIT.Click
          Me.Close()
    End Sub
    '==========CHK VALIDATION FOR CORPORATENAME=========
    Public Function CheckCorporateName() As Boolean
        Dim flg As Boolean = False
        ssql = "select * from CorporateMaster where CMCorporateName='" & Trim(TXT_C_NAME.Text) & "'"
        gconnection.getDataSet(ssql, "CorporateMaster")
        If BUT_ADD.Text = "Add[F7]" Then
            If gdataset.Tables("CorporateMaster").Rows.Count > 0 Then
                flg = False
            Else
                flg = True
            End If
        ElseIf BUT_ADD.Text = "Update[F7]" Then
            If gdataset.Tables("CorporateMaster").Rows.Count > 1 Then
                flg = False
            Else
                flg = True
            End If
        End If

        Return flg

    End Function
    '=========CHECK VALIDATION FOR CORPORATECODE=========
    Public Function CheckCorporateCode() As Boolean
        Dim flg As Boolean = False
        ssql = "select * from CorporateMaster where CMCorporateCode='" & Trim(TXT_C_CODE.Text) & "'"
        gconnection.getDataSet(ssql, "CorporateMaster")
        If BUT_ADD.Text = "Add[F7]" Then
            If gdataset.Tables("CorporateMaster").Rows.Count > 0 Then
                flg = False
            Else
                flg = True
            End If
        ElseIf BUT_ADD.Text = "Update[F7]" Then
            If gdataset.Tables("CorporateMaster").Rows.Count > 1 Then
                flg = False
            Else
                flg = True
            End If
        End If

        Return flg

    End Function

    Public Function checkValidation()
        boolchk = False
        '''********** Check Corporate Code is blank
        If TXT_C_CODE.Text = "" Then
            MessageBox.Show(" Category Code can't be blank ", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TXT_C_CODE.Focus()
            Exit Function
        End If
        '''********** Check Corporate Name is blank
        If TXT_C_NAME.Text = "" Then
            MessageBox.Show(" Category Name can't be blank ", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TXT_C_NAME.Focus()
            Exit Function
        End If
        If TXT_NOOF_NOMINEE.Text = "" Then
            MessageBox.Show(" No. of nominee can't be blank ", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TXT_NOOF_NOMINEE.Focus()
            Exit Function
        End If
        '''********** Check Corporate Name is blank 
        If TXT_STATE.Text = "" Then
            MessageBox.Show(" State field can't be blank ", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TXT_STATE.Focus()
            Exit Function
        End If

        ''*********** Check Email Id is blank
        If TXT_EMAIL.Text <> "" Then
            emailst = getEmail(TXT_EMAIL)
            If emailst <> "T" Then
                Exit Function
            End If
        End If
        '''************* Check Billing Basis
        If CMB_BILL_BASIS.Text = "" Then
            MessageBox.Show(" Billing Basis field can't be blank ", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CMB_BILL_BASIS.Focus()
            Exit Function
        End If
        '''**************** Check Current Status
        If CMB_CUR_STATUS.Text = "" Then
            MessageBox.Show(" Current Status field can't be blank ", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CMB_CUR_STATUS.Focus()
            Exit Function
        End If
        If TXT_CONT_PERSON.Text = "" Then
            MessageBox.Show(" Contact person field can't be blank ", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TXT_CONT_PERSON.Focus()
            Exit Function
        End If



        boolchk = True
    End Function

    Function EmailAddressCheck(ByVal emailAddress As String)
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)
        If emailAddressMatch.Success Then

        Else
            MessageBox.Show("E-mail Id field is not in correct format!")
            TXT_EMAIL.Select()
        End If
    End Function

    Private Sub BUT_ADD_Click(sender As Object, e As EventArgs) Handles BUT_ADD.Click
        Dim Sreader As New DataTable
        Dim dt As New DataTable
        Dim flg As Boolean = False
        Dim ssql, insert(0) As String
        Dim strSQL As String

        Dim FINALLEVEL As Integer

        Dim SSQLSTR2 As String
        Dim USERT As Integer
        Dim gSQLString As String = ""


        Call checkValidation() '''--->Check Validation
        If boolchk = False Then Exit Sub

        '''''*************Check Corporate Name if exists
        If CheckCorporateCode() = False Then
            MessageBox.Show(" Corporate Code has duplicate entry ! ", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TXT_C_CODE.Focus()
            Exit Sub
        End If

        '''''*************Check Corporate Name if exists
        If CheckCorporateName() = False Then
            MessageBox.Show(" Corporate name already exists ! ", CompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TXT_C_NAME.Focus()
            Exit Sub
        End If

        If BUT_ADD.Text = "Add[F7]" Then

            strSQL = "INSERT INTO CorporateMaster(CMCorporateCode,CMCorporateName,CMBilling,REMARKS," & _
            "CurrentStatus,CMNomembers,CMAddress1,CMAddress2,CMAddress3,CMCity,CMState,CMCountry,CMPin,CMPhone,CMFax,CMPager," & _
            "CMEmail,CMClass,AddUser,AddDate,freeze,paid_up_capital,NETWORTH,CORPORATE_TYPE"
            strSQL = strSQL & ")"
            strSQL = strSQL & "VALUES ( '" & Trim(TXT_C_CODE.Text) & " '," & _
            "'" & LTrim(RTrim(TXT_C_NAME.Text)) & "','" & LTrim(RTrim(CMB_BILL_BASIS.Text)) & "','" & LTrim(RTrim(TXT_REMARK.Text)) & "'," & _
            "'" & CMB_CUR_STATUS.Text & "'," & Trim(Val(TXT_NOOF_NOMINEE.Text)) & "," & _
            "'" & LTrim(RTrim(TXT_ADD1.Text)) & "','" & LTrim(RTrim(TXT_ADD2.Text)) & "','" & LTrim(RTrim(TXT_ADD3.Text)) & "','" & Trim(CMB_CITY.Text) & "'," & _
            "'" & Trim(TXT_STATE.Text) & "','" & Trim(TXT_COUNTRY.Text) & "','" & Trim(TXT_PIN.Text) & "','" & Trim(TXT_PHONE.Text) & "','" & Trim(TXT_FAX.Text) & "'," & _
            "'" & Trim(TXT_MOBILE.Text) & "','" & LTrim(RTrim(TXT_EMAIL.Text)) & "','" & Trim(TXT_CONT_PERSON.Text) & "'," & _
            "'" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm") & "','N','" & Trim(Val(TXT_PAIDUP_CAP.Text)) & "','" & Trim(Val(TXT_NETWORTH.Text)) & "','" & Trim(CMB_CORPORATE_TYPE.Text) & "'"
            strSQL = strSQL & ")"
            ReDim Preserve insert(insert.Length)
            insert(insert.Length - 1) = strSQL

            '-------*commented to stop adding nominee details.

            'If DataGridView1.RowCount > 0 Then

            '    For i = 0 To DataGridView1.RowCount - 2

            '        strSQL = "INSERT INTO membermaster (MNAME, Designation, DOB, CONTADD1, CONTADD2, CONTADD3, CONTCITY, CONTSTATE, CONTCOUNTRY, CONTPIN, CONTCELL, CONTEMAIL,corporatecode, adduser, adddate,freeze) VALUES  ( "
            '        strSQL = strSQL + "LTRIM(RTRIM('" & DataGridView1.Rows(i).Cells(0).Value & "')), '" & DataGridView1.Rows(i).Cells(1).Value & "',"
            '        strSQL = strSQL + "LTRIM(RTRIM('" & DataGridView1.Rows(i).Cells(2).Value & "')),LTRIM(RTRIM('" & DataGridView1.Rows(i).Cells(3).Value & "')), "
            '        strSQL = strSQL + "LTRIM(RTRIM('" & DataGridView1.Rows(i).Cells(4).Value & "')), LTRIM(RTRIM('" & DataGridView1.Rows(i).Cells(5).Value & "')), "
            '        strSQL = strSQL + "LTRIM(RTRIM('" & DataGridView1.Rows(i).Cells(6).Value & "')), LTRIM(RTRIM('" & DataGridView1.Rows(i).Cells(7).Value & "')), "
            '        strSQL = strSQL + "LTRIM(RTRIM('" & DataGridView1.Rows(i).Cells(8).Value & "')),LTRIM(RTRIM('" & DataGridView1.Rows(i).Cells(9).Value & "')), "
            '        strSQL = strSQL + "LTRIM(RTRIM('" & DataGridView1.Rows(i).Cells(10).Value & "')),LTRIM(RTRIM('" & DataGridView1.Rows(i).Cells(11).Value & "')),LTRIM(RTRIM('" & TXT_C_CODE.Text & "')), "
            '        strSQL = strSQL + "'" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm") & "','N') "

            '        ReDim Preserve insert(insert.Length)
            '        insert(insert.Length - 1) = strSQL
            '    Next

            'End If


            flg = gconnection.MoreTrans(insert)
            If flg Then
                MessageBox.Show("Record Added Successfully ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.BUT_CLR_Click(sender, e)
            End If

        ElseIf BUT_ADD.Text = "Update[F7]" Then

            If Mid(Me.BUT_ADD.Text, 1, 1) = "U" Then

                If Me.LBL_FREEZE.Visible = True Then
                    MessageBox.Show(" void Record Can't Be Updated !", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    boolchk = False
                End If
            End If
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
                    flg = UpdateCorporate()
                    If flg Then
                        BUT_CLR_Click(sender, e)
                        BUT_ADD.Text = "Add[F7]"
                        DataGridView1.ReadOnly = True
                    End If
                ElseIf USERT = 1 And FINALLEVEL <> 1 Then 'WHERE CMCorporateCode = '" & Trim(TXT_C_CODE.Text) & "'
                    SSQLSTR2 = " SELECT * FROM CorporateMaster WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')='' AND CMCorporateCode = '" & Trim(TXT_C_CODE.Text) & "' AND ISNULL(freeze,'')<>'Y'"
                    gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                    If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then

                        flg = UpdateCorporate()
                        If flg Then
                            BUT_CLR_Click(sender, e)
                            BUT_ADD.Text = "Add[F7]"
                            DataGridView1.ReadOnly = True
                        End If
                    Else
                        MsgBox("Only final level users can update ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gCompanyname)
                    End If
                Else
                    MsgBox("Only final level users can update ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gCompanyname)
                End If
            ElseIf USERT = 2 Then

                If USERT = 2 And FINALLEVEL = 2 Then
                    flg = UpdateCorporate()
                    If flg Then
                        BUT_CLR_Click(sender, e)
                        BUT_ADD.Text = "Add[F7]"
                        DataGridView1.ReadOnly = True
                    End If
                ElseIf USERT = 2 And FINALLEVEL <> 2 Then

                    SSQLSTR2 = " SELECT * FROM CorporateMaster WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')='' AND  ISNULL(freeze,'')<>'Y' AND CMCorporateCode = '" & Trim(TXT_C_CODE.Text) & "' "
                    gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                    If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then

                        flg = UpdateCorporate()
                        If flg Then
                            BUT_CLR_Click(sender, e)
                            BUT_ADD.Text = "Add[F7]"
                            DataGridView1.ReadOnly = True
                        End If
                    Else
                        MsgBox("Only final level users can update ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gCompanyname)
                    End If
                Else
                    MsgBox(" Only final level users can update ! ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gCompanyname)
                End If

            ElseIf USERT = 3 Then
                If USERT = 3 And FINALLEVEL = 3 Then
                    flg = UpdateCorporate()
                    If flg Then
                        BUT_CLR_Click(sender, e)
                        BUT_ADD.Text = "Add[F7]"
                        DataGridView1.ReadOnly = True
                    End If
                ElseIf USERT = 3 And FINALLEVEL <> 3 Then

                    SSQLSTR2 = " SELECT * FROM CorporateMaster WHERE ISNULL(AUTHORISED,'')<>'Y'  AND ISNULL(freeze,'')<>'Y' AND CMCorporateCode = '" & Trim(TXT_C_CODE.Text) & "' "
                    gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                    If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then

                        flg = UpdateCorporate()
                        If flg Then
                            BUT_CLR_Click(sender, e)
                            BUT_ADD.Text = "Add[F7]"
                            DataGridView1.ReadOnly = True
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

        End If

    End Sub

    Private Function UpdateCorporate() As Boolean

        Dim insert(0) As String
        Dim flg As Boolean = False
        '=============================INSERTING DATA INTO LOG TABLE=====================================
        Try

            SqlString = "Select isnull(remarks,'')as rem,isnull(NETWORTH,0)as networks,isnull(paid_up_capital,0)as paidupcapital,isnull(CORPORATE_TYPE,'')as CORPORATETP,* From CorporateMaster Where CMCorporateCode='" & Me.TXT_C_CODE.Text & "'"
            dt = gconnection.GetValues(SqlString)
            If dt.Rows.Count > 0 Then

                SqlString = "INSERT INTO CorporateMaster_LOG (CMCorporateCode,CMCorporateName,CMBilling,REMARKS," & _
                "CurrentStatus,CMNomembers,CMAddress1,CMAddress2,CMAddress3,CMCity,CMState,CMCountry,CMPin,CMPhone,CMFax,CMPager," & _
                "CMEmail,CMClass,AddUser,AddDate,freeze,paid_up_capital,NETWORTH,CORPORATE_TYPE,UPDATEUSER,UPDATEDATETIME) values "
                SqlString = SqlString & "('" & Trim(dt.Rows(0).Item("CMCorporateCode")) & "','" & Trim(dt.Rows(0).Item("CMCorporateName")) & "','" & Trim(dt.Rows(0).Item("CMBilling")) & "',"
                SqlString = SqlString & " '" & LTrim(RTrim(dt.Rows(0).Item("rem"))) & "','" & dt.Rows(0).Item("CurrentStatus") & "','" & Trim(Val(dt.Rows(0).Item("CMNomembers"))) & "',"
                SqlString = SqlString & " '" & LTrim(RTrim(dt.Rows(0).Item("CMAddress1"))) & "','" & LTrim(RTrim(dt.Rows(0).Item("CMAddress2"))) & "','" & LTrim(RTrim(dt.Rows(0).Item("CMAddress3"))) & "',"
                SqlString = SqlString & " '" & dt.Rows(0).Item("CMCity") & "','" & dt.Rows(0).Item("CMState") & "','" & Trim(dt.Rows(0).Item("CMCountry")) & "',"
                SqlString = SqlString & " '" & Trim(dt.Rows(0).Item("CMPin")) & "','" & dt.Rows(0).Item("CMPhone") & "','" & dt.Rows(0).Item("CMFax") & "',"
                SqlString = SqlString & " '" & Trim(dt.Rows(0).Item("CMPager")) & "','" & LTrim(RTrim(dt.Rows(0).Item("CMEmail"))) & "','" & LTrim(RTrim(dt.Rows(0).Item("CMClass"))) & "',"
                SqlString = SqlString & " '" & dt.Rows(0).Item("AddUser") & "','" & Format(dt.Rows(0).Item("AddDate"), "dd-MMM-yyyy") & "','" & dt.Rows(0).Item("freeze") & "',"
                SqlString = SqlString & " '" & Trim(dt.Rows(0).Item("paidupcapital")) & "','" & Trim(dt.Rows(0).Item("networkS")) & "','" & dt.Rows(0).Item("CORPORATETP") & "',"
                SqlString = SqlString & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm") & "')"

                ReDim Preserve insert(insert.Length)
                insert(insert.Length - 1) = SqlString

            End If
            '=========================================================
            SqlString = "UPDATE  CorporateMaster"
            SqlString = SqlString & " SET CMCorporateName='" & Trim(TXT_C_NAME.Text) & "',CMBilling='" & Trim(CMB_BILL_BASIS.Text) & "'," & _
            "remarks='" & TXT_REMARK.Text & "',CurrentStatus='" & CMB_CUR_STATUS.Text & "',CMNomembers='" & Trim(TXT_NOOF_NOMINEE.Text) & "',CMAddress1='" & Trim(TXT_ADD1.Text) & "'," & _
            "CMAddress2='" & Trim(TXT_ADD2.Text) & "',CMAddress3='" & Trim(TXT_ADD3.Text) & "',CMCity='" & Trim(CMB_CITY.Text) & "',CMState='" & Trim(TXT_STATE.Text) & "',CMCountry='" & Trim(TXT_COUNTRY.Text) & "',CMPin='" & Trim(TXT_PIN.Text) & "'," & _
            "CMPhone='" & Trim(TXT_PHONE.Text) & "',CMFax='" & Trim(TXT_FAX.Text) & "',CMPager='" & Trim(TXT_MOBILE.Text) & "'," & _
            "CMEmail='" & Trim(TXT_EMAIL.Text) & "',CMClass='" & Trim(TXT_CONT_PERSON.Text) & "',UPDATEUSER='" & Trim(gUsername) & "',UPDATEDATETIME='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "',freeze='N',paid_up_capital='" & Val(TXT_PAIDUP_CAP.Text) & "',NETWORTH='" & Val(TXT_NETWORTH.Text) & "', CORPORATE_TYPE='" & Trim(CMB_CORPORATE_TYPE.Text) & "'"
            SqlString = SqlString & " WHERE CMCorporateCode = '" & Trim(TXT_C_CODE.Text) & "'"
            ReDim Preserve insert(insert.Length)
            insert(insert.Length - 1) = SqlString

            flg = gconnection.MoreTrans(insert)



        Catch ex As Exception
            MsgBox("Update Error:" & ex.Message)
            flg = False
        End Try

        Return flg

    End Function




    Private Sub TXT_PHONE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_PHONE.KeyPress
        ' If Not IsNumeric(e.KeyChar) Then e.Handled = True 
        getNumeric(e)
    End Sub

    Private Sub TXT_PIN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_PIN.KeyPress
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TXT_MOBILE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MOBILE.KeyPress
        If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                MsgBox("Only numeric values are allowed!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, " Validating Mobile No.")
            End If
        End If
    End Sub



    Private Sub TXT_NOOF_NOMINEE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_NOOF_NOMINEE.KeyPress

        If CMB_CORPORATE_TYPE.SelectedIndex = 0 Then
            If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 Then
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 52 Then
                    e.Handled = True
                    MsgBox("Only 4 nominees are allowed for corporate type- 1 ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, " Validating Nominees ")
                End If
            End If
        ElseIf CMB_CORPORATE_TYPE.SelectedIndex = 1 Then
            If Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13 Then
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 50 Then
                    e.Handled = True
                    MsgBox("Only 2 nominees are allowed for corporate type- 2", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, " Validating Nominees ")

                End If
            End If
        End If
    End Sub

    Private Sub TXT_PAIDUP_CAP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_PAIDUP_CAP.KeyPress
        getNumeric(e)
    End Sub

    Private Sub TXT_NETWORK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_NETWORTH.KeyPress
        getNumeric(e)
    End Sub
    Public Function ClrGrid()
        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()
        DataGridView1.Rows.Clear()
    End Function

    Public Function Clrs()
        ClrGrid()
        bindGridCity()
        BIND_CITY()
        'FILLCATEGORY()
        ' autogenerate()
        FILLCATEGORY()
        TXT_C_CODE.Text = ""
        TXT_NETWORTH.Text = ""
        TXT_PAIDUP_CAP.Text = ""
        TXT_C_NAME.Text = ""
        TXT_ADD1.Text = ""
        TXT_ADD2.Text = ""
        TXT_ADD3.Text = ""
        TXT_CONT_PERSON.Text = ""
        TXT_FAX.Text = ""
        TXT_EMAIL.Text = ""
        TXT_MOBILE.Text = ""
        TXT_NOOF_NOMINEE.Text = ""
        TXT_PHONE.Text = ""
        TXT_PIN.Text = ""
        TXT_REMARK.Text = ""

        CMB_BILL_BASIS.SelectedIndex = 0
        CMB_CORPORATE_TYPE.SelectedIndex = 0
        CMB_CUR_STATUS.SelectedIndex = 0
        CMB_CORPORATE_TYPE.SelectedIndex = 0
        CMB_BILL_BASIS.SelectedIndex = 0
        CMB_CUR_STATUS.SelectedIndex = 0
        CMB_CITY.SelectedIndex = 0

        BUT_ADD.Text = "Add[F7]"
        DataGridView1.DataSource = Nothing
        GroupBox4.Visible = False
        DataGridView1.ReadOnly = False

        BUT_FREEZE.Text = "Freeze[F8]"
        Me.TXT_C_CODE.Enabled = True
        Me.CMB_CUR_STATUS.Enabled = False
        LBL_FREEZE.Visible = False
        TXT_C_CODE.Focus()
        Gr2.Visible = False
    End Function

    Private Sub BUT_CLR_Click(sender As Object, e As EventArgs) Handles BUT_CLR.Click
        Call Clrs()
    End Sub

    Private Sub TXT_C_CODE_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_C_CODE.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TXT_C_CODE.Text = "" Then
                Call BUT_CCODE_HELP_Click(sender, e)
            Else
                TXT_C_CODE_Validated(sender, e)
            End If
        ElseIf e.KeyCode = Keys.F4 Then
            Call BUT_CCODE_HELP_Click(sender, e)
        End If
    End Sub

    Private Sub TXT_C_CODE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_C_CODE.KeyPress
        getAlphaNumeric1(e)
    End Sub

    Private Sub TXT_C_CODE_Validated(sender As Object, e As EventArgs) Handles TXT_C_CODE.Validated
        Dim Sreader As New DataTable
        Dim ssql As String
        ssql = " Select isnull(remarks,'')as rem,isnull(NETWORTH,0)as networks,isnull(paid_up_capital,0)as paidupcapital,isnull(CORPORATE_TYPE,'')as CORPORATETP,* From CorporateMaster Where CMCorporateCode='" & Me.TXT_C_CODE.Text & "'"
        Sreader = gconnection.GetValues(ssql)


        If Sreader.Rows.Count > 0 Then
            Me.TXT_C_CODE.Enabled = False
            Me.CMB_CUR_STATUS.Enabled = False
            Me.TXT_C_NAME.Text = Sreader.Rows(0).Item("CMCorporateName").ToString
            Me.CMB_BILL_BASIS.Text = Sreader.Rows(0).Item("CMBilling").ToString
            Me.TXT_REMARK.Text = Sreader.Rows(0).Item("rem").ToString
            Me.CMB_CUR_STATUS.Text = Sreader.Rows(0).Item("CurrentStatus").ToString
            Me.TXT_ADD1.Text = Sreader.Rows(0).Item("CMAddress1").ToString
            Me.TXT_ADD2.Text = Sreader.Rows(0).Item("CMAddress2").ToString
            Me.TXT_ADD3.Text = Sreader.Rows(0).Item("CMAddress3").ToString

            Me.CMB_CORPORATE_TYPE.Text = Sreader.Rows(0).Item("CORPORATETP").ToString
            Me.CMB_CITY.Text = Sreader.Rows(0).Item("CMCity").ToString

            Me.TXT_NOOF_NOMINEE.Text = Sreader.Rows(0).Item("CMNomembers").ToString
            Me.TXT_STATE.Text = Sreader.Rows(0).Item("CMState").ToString
            Me.TXT_COUNTRY.Text = Sreader.Rows(0).Item("CMCountry").ToString
            Me.TXT_PIN.Text = Sreader.Rows(0).Item("CMPin").ToString
            Me.TXT_PHONE.Text = Sreader.Rows(0).Item("CMPhone").ToString
            Me.TXT_FAX.Text = Sreader.Rows(0).Item("CMFax").ToString
            Me.TXT_MOBILE.Text = Sreader.Rows(0).Item("CMPager").ToString
            Me.TXT_EMAIL.Text = Sreader.Rows(0).Item("CMEmail").ToString
            Me.TXT_CONT_PERSON.Text = Sreader.Rows(0).Item("CMClass").ToString
            Me.TXT_NETWORTH.Text = Sreader.Rows(0).Item("networks").ToString
            Me.TXT_PAIDUP_CAP.Text = Sreader.Rows(0).Item("paidupcapital").ToString
            ''>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            If Sreader.Rows(0).Item("Freeze") = "Y" Then
                Me.LBL_FREEZE.Visible = True
                Me.LBL_FREEZE.Text = "Record void  On "
                Me.LBL_FREEZE.Text = Me.LBL_FREEZE.Text & Format(Sreader.Rows(0).Item("VOIDDATETIME"), "dd-MMM-yyyy")
                Me.BUT_FREEZE.Text = "UnFreeze[F8]"
            Else
                Me.LBL_FREEZE.Visible = False
                Me.LBL_FREEZE.Text = "Record void  On "
                Me.BUT_FREEZE.Text = "Freeze[F8]"
            End If

            Me.BUT_ADD.Text = "Update[F7]"
            ' BUT_NOMINEE_DET_Click(sender, e)
            '====gridview can't be updated==
            DataGridView1.ReadOnly = True
            TXT_C_NAME.Select()
        Else
            Me.TXT_C_CODE.Enabled = True
            Me.TXT_C_NAME.Text = ""
            Me.LBL_FREEZE.Visible = False
            Me.LBL_FREEZE.Text = "Record void  On "
            Me.BUT_ADD.Text = "Add[F7]"
            '====gridview can't be updated==
            DataGridView1.ReadOnly = False
            TXT_C_NAME.Select()
        End If

    End Sub

    Public Function BIND_CITYC(ByRef cmb As ComboBox)
        Dim sqlstr As String
        sqlstr = "select Name,state,country from Tbl_CityMaster order by Name "
        gconnection.getDataSet(sqlstr, "Tbl_CityMaster")
        cmb.DataSource = gdataset.Tables("Tbl_CityMaster")
        cmb.ValueMember = "Name"
        cmb.DisplayMember = "Name"
    End Function


    Public Function BIND_CITY()
        Dim sqlstr As String
        sqlstr = "select Name,state,country from Tbl_CityMaster order by Name "
        gconnection.getDataSet(sqlstr, "Tbl_CityMaster")
        CMB_CITY.DataSource = gdataset.Tables("Tbl_CityMaster")
        CMB_CITY.ValueMember = "Name"
        CMB_CITY.DisplayMember = "Name"
    End Function

    Private Sub CMB_CITY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_CITY.SelectedIndexChanged
        Dim sqlstr As String
        If CMB_CITY.Items.Count > 0 And CMB_CITY.SelectedValue.ToString <> "System.Data.DataRowView" Then
            sqlstr = "select state,country from Tbl_CityMaster where name='" & CMB_CITY.SelectedValue.ToString & "' "
            gconnection.getDataSet(sqlstr, "Tbl_CityMaster")
            TXT_STATE.Text = gdataset.Tables("Tbl_CityMaster").Rows(0).Item("state") & ""
            TXT_COUNTRY.Text = gdataset.Tables("Tbl_CityMaster").Rows(0).Item("country") & ""
        End If

    End Sub
    'Private Function BINDCATEGORY()
    '    '    ALLCATEGORIES = ""
    '    '    Dim CNT As Integer = 0
    '    '    '===============BINDING CATEGORY TYPE ===================
    '    dt = Nothing
    '    SqlString = "select subtypeCode ,Subtypedesc from subcategorymaster where Corporatemember = 'Y' AND Freeze <> 'Y' ORDER BY Subtypedesc ASC "
    '    dt = gconnection.GetValues(SqlString)
    '    CMB_CATEGORY.DataSource = dt
    '    CMB_CATEGORY.ValueMember = "subtypeCode"
    '    CMB_CATEGORY.DisplayMember = "Subtypedesc"

    '    '    '===============CREATE CATEGORY TYPE FOR QUERY ===================
    '    '    For I = 0 To CMB_CATEGORY.Items.Count - 1
    '    '        CMB_CATEGORY.SelectedIndex = I
    '    '        If CNT = 0 Then
    '    '            ALLCATEGORIES = "'" + CMB_CATEGORY.Text + "'"
    '    '        Else
    '    '            ALLCATEGORIES = ALLCATEGORIES + "," + "'" + CMB_CATEGORY.Text + "'"
    '    '        End If
    '    '        CNT += 1
    '    '    Next
    '    '    CMB_CATEGORY.SelectedIndex = -1
    'End Function


    Private Function FILLCATEGORY()
        SqlString = "select subtypeCode ,Subtypedesc from subcategorymaster where Corporatemember = 'Y' AND Freeze <> 'Y' ORDER BY Subtypedesc ASC "
        dt = gconnection.GetValues(SqlString)
        CMB_CORPORATE_TYPE.DataSource = dt
        CMB_CORPORATE_TYPE.DisplayMember = "Subtypedesc"
        CMB_CORPORATE_TYPE.ValueMember = "subtypeCode"

        'Dim Itration
        'For Itration = 0 To (dt.Rows.Count - 1)
        '    CMB_CORPORATE_TYPE.Items.Add(dt.Rows(Itration).Item("Subtypedesc"))
        'Next
        Return Nothing
    End Function

    Private Sub CMB_CORPORATE_TYPE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_CORPORATE_TYPE.SelectedIndexChanged
        TXT_NOOF_NOMINEE.Text = ""
    End Sub

    Private Sub TXT_FAX_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_FAX.KeyPress
        getNumeric(e)
    End Sub

    Private Sub BUT_FREEZE_Click(sender As Object, e As EventArgs) Handles BUT_FREEZE.Click
        Dim dt As New DataTable
        Dim flg As Boolean = False
        Dim insert(0) As String

        Call checkValidation() ''-->Check Validation
        If boolchk = False Then Exit Sub

        '====================INSERTING DATA INTO LOG TABLE=====================================

        SqlString = "Select isnull(Freeze,'')as Freeze,isnull(AddUser,'')as AddUser,isnull(AddDate,'')as AddDate,isnull(REMARKS,'')as REMARKS From CorporateMaster Where CMCorporateCode='" & Me.TXT_C_CODE.Text & "'"
        dt = gconnection.GetValues(SqlString)
        If dt.Rows.Count > 0 Then

            SqlString = "INSERT INTO CorporateMaster_LOG (CMCorporateCode,Freeze,AddUser,AddDate,REMARKS,UPDATEUSER,UPDATEDATETIME) values "
            SqlString = SqlString & "('" & Me.TXT_C_CODE.Text & "','" & dt.Rows(0).Item("Freeze") & "','" & dt.Rows(0).Item("AddUser") & "',"
            SqlString = SqlString & " '" & Format(dt.Rows(0).Item("AddDate"), "dd-MMM-yyyy") & "','" & dt.Rows(0).Item("REMARKS") & "',"
            SqlString = SqlString & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm") & "')"
            ReDim Preserve insert(insert.Length)
            insert(insert.Length - 1) = SqlString

        End If
        '=======================================================================================

        If Mid(Me.BUT_FREEZE.Text, 1, 1) = "F" Then
            SqlString = "UPDATE  CorporateMaster "
            SqlString = SqlString & " SET Freeze= 'Y',VOIDUSER='" & gUsername & " ', VOIDDATETIME='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
            SqlString = SqlString & " WHERE CMCorporateCode = '" & TXT_C_CODE.Text & " '"
        Else
            SqlString = "UPDATE  CorporateMaster "
            SqlString = SqlString & " SET Freeze= 'N',VOIDUSER='" & gUsername & " ', VOIDDATETIME='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
            SqlString = SqlString & " WHERE CMCorporateCode = '" & TXT_C_CODE.Text & " '"
        End If

        ReDim Preserve insert(insert.Length)
        insert(insert.Length - 1) = SqlString
        flg = gconnection.MoreTrans(insert)
        If flg Then
            Me.BUT_CLR_Click(sender, e)
            BUT_ADD.Text = "Add[F7]"
            DataGridView1.ReadOnly = False
        End If
    End Sub

    Private Sub BUT_LST_VIEW_Click(sender As Object, e As EventArgs) Handles BUT_LST_VIEW.Click
        Gr2.Visible = True
    End Sub

    'reportdesign.DataGridView1.Rows(2).Cells(0).Value = True
    Private Sub TXT_C_NAME_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_C_NAME.KeyDown
        If e.KeyCode = Keys.Enter Then
            CMB_BILL_BASIS.Focus()
            'CMB_BILL_BASIS.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub CMB_BILL_BASIS_KeyDown(sender As Object, e As KeyEventArgs) Handles CMB_BILL_BASIS.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXT_PAIDUP_CAP.Focus()
        End If
    End Sub

    Private Sub TXT_PAIDUP_CAP_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_PAIDUP_CAP.KeyDown
        If e.KeyCode = Keys.Enter Then
            CMB_CORPORATE_TYPE.Focus()
        End If
    End Sub

    Private Sub CMB_CORPORATE_TYPE_KeyDown(sender As Object, e As KeyEventArgs) Handles CMB_CORPORATE_TYPE.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXT_NOOF_NOMINEE.Focus()
        End If
    End Sub

    Private Sub TXT_NOOF_NOMINEE_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_NOOF_NOMINEE.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXT_NETWORTH.Focus()
        ElseIf e.KeyCode = Keys.F5 Then
            BUT_NOMINEE_DET_Click(sender, e)
        End If
    End Sub

    Private Sub TXT_NETWORK_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_NETWORTH.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXT_ADD1.Focus()
        End If
    End Sub

    Private Sub TXT_ADD1_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_ADD1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXT_ADD2.Focus()
        End If
    End Sub

    Private Sub TXT_ADD2_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_ADD2.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXT_ADD3.Focus()
        End If
    End Sub

    Private Sub TXT_ADD3_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_ADD3.KeyDown
        If e.KeyCode = Keys.Enter Then
            CMB_CITY.Focus()
        End If
    End Sub

    Private Sub CMB_CITY_KeyDown(sender As Object, e As KeyEventArgs) Handles CMB_CITY.KeyDown

        If e.KeyCode = Keys.Enter Then
            TXT_PIN.Focus()
        End If
    End Sub

    Private Sub TXT_PIN_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_PIN.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXT_PHONE.Focus()
        End If
    End Sub

    Private Sub TXT_PHONE_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_PHONE.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXT_FAX.Focus()
        End If
    End Sub

    Private Sub TXT_FAX_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_FAX.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXT_MOBILE.Focus()
        End If
    End Sub

    Private Sub TXT_MOBILE_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_MOBILE.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXT_EMAIL.Focus()
        End If
    End Sub

    Private Sub TXT_EMAIL_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_EMAIL.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXT_CONT_PERSON.Focus()
        End If
    End Sub

    Private Sub TXT_CONT_PERSON_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_CONT_PERSON.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXT_REMARK.Focus()
        End If
    End Sub

    Private Sub CMB_BILL_BASIS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CMB_BILL_BASIS.KeyPress
        Blank(e)
    End Sub



    Private Sub BUT_OK_Click(sender As Object, e As EventArgs)
        GroupBox4.Visible = False
    End Sub

    '==================== WORK WITH COMBOBOX SELECTEDINDEXCHANGED EVENT IN GIRD======================
    'Temporary Controls to represent the Editing Cells   

    Private cboCase As DataGridViewComboBoxEditingControl = Nothing
    ' Private txtReportTime As DataGridViewTextBoxCell = Nothing

    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs)

        If TypeOf (e.Control) Is DataGridViewComboBoxEditingControl Then

            'Cast the current cell to the temporary control   
            cboCase = DirectCast(e.Control, DataGridViewComboBoxEditingControl)

            'Cast the other cell to the other temporary control   
            'txtReportTime = DirectCast(DataGridView1.CurrentRow.Cells("colreportTime"), DataGridViewTextBoxCell)

            If cboCase IsNot Nothing Then
                'Add an EventHandler to the first temporary control   
                AddHandler cboCase.SelectedIndexChanged, AddressOf cboCase_SelectedIndexChanged
            End If
        End If
    End Sub

    'Do your thing in the EventHandler   
    Private Sub cboCase_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)

        Dim sqlstr As String
        sqlstr = "select state,country from Tbl_CityMaster where Name='" & cboCase.Text & "' "
        memdet = gconnection.GetValues(sqlstr)
        If memdet.Rows.Count > 0 Then
            DataGridView1.CurrentRow.Cells(7).Value = memdet.Rows(0).Item("state")
            DataGridView1.CurrentRow.Cells(8).Value = memdet.Rows(0).Item("country")
        End If


        'DataGridView1.CurrentRow.Cells(7).Value = cboCase.Text

    End Sub

    'After editing, remove the eventHandler  
    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs)
        If cboCase IsNot Nothing Then
            RemoveHandler cboCase.SelectedIndexChanged, AddressOf cboCase_SelectedIndexChanged
            cboCase = Nothing
        End If
    End Sub
    '==============================================================================================================

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub TXT_NOOF_NOMINEE_TextChanged(sender As Object, e As EventArgs) Handles TXT_NOOF_NOMINEE.TextChanged
        'If TXT_NOOF_NOMINEE.Text.Length > 0 Then
        '    GroupBox4.Visible = True
        'Else
        '    GroupBox4.Visible = False

        'End If
    End Sub


    Private Sub BUT_OK_Click_1(sender As Object, e As EventArgs) Handles BUT_OK.Click
        GroupBox4.Visible = False
    End Sub


    Private Sub TXT_EMAIL_Validated(sender As Object, e As EventArgs) Handles TXT_EMAIL.Validated
        getEmail1(TXT_EMAIL)
    End Sub



    Private Sub TXT_REMARK_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_REMARK.KeyDown
        If e.KeyCode = Keys.Enter Then

            TXT_REMARK.SelectionStart = TXT_REMARK.TextLength
            TXT_REMARK.Focus()
        End If
    End Sub

    Private Sub BUT_BROWSE_Click(sender As Object, e As EventArgs) Handles BUT_BROWSE.Click

        brows = True
        Dim VIEW1 As New VIEWHDR
        VIEW1.Show()
        VIEW1.DTGRDHDR.DataSource = Nothing
        VIEW1.DTGRDHDR.Rows.Clear()
        Dim STRQUERY As String
        STRQUERY = "SELECT * FROM CORPORATEMASTER"
        'STRQUERY = "SELECT isnull(MODULENAME,'')as MODULENAME,isnull(FORMNAME,'') as FORMNAME,isnull(FORMTYPE,'')as FORMTYPE,isnull(AUTHORIZELEVEL,'')as AUTHORIZELEVEL,isnull(AUTH1USER1,'')as AUTH1USER1,isnull(AUTH1USER2,'') as AUTH1USER2,isnull(AUTH2USER1,'')as  AUTH2USER1,isnull(AUTH2USER2,'')as AUTH2USER2,isnull(AUTH3USER1,'')as AUTH3USER1,isnull(AUTH3USER2,'') as AUTH3USER2,isnull(void,'') as void,isnull(ADDUSERID,'')as ADDUSERID,isnull(ADDDATETIME,'')as ADDDATETIME FROM authorize"
        gconnection.getDataSet(STRQUERY, "authorize")

        Call VIEW1.LOADGRID(gdataset.Tables("authorize"), True, gcompanyname, "SELECT * FROM CORPORATEMASTER", "CMCorporateCode", 1, Me.TXT_C_CODE)

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
            SSQLSTR2 = " SELECT * FROM CORPORATEMASTER WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER1,'')=''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH1USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH1USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE")
                If gdataset.Tables("AUTHORIZE").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND ISNULL(AUTHORIZELEVEL,0)>0 "
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM CORPORATEMASTER WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER1,'')=''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()
                           

                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE CORPORATEMASTER set  ", "CMCorporateCode", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 1, 1)
                        End If
                    Else
                        MsgBox("NO AUTHORIZATION REQUIRED FOR THE ENTRY")
                    End If
                End If
            End If
        ElseIf USERT = 2 Then
            SSQLSTR2 = " SELECT * FROM CORPORATEMASTER WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')='' AND ISNULL(AUTHORISE_USER1,'')<>''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH2USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH2USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE1")
                If gdataset.Tables("AUTHORIZE1").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "'"
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM CORPORATEMASTER WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')=''AND ISNULL(AUTHORISE_USER1,'')<>''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()
                           

                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE CORPORATEMASTER set  ", "CMCorporateCode", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 2, 1)
                        End If
                    End If
                End If
            End If
        ElseIf USERT = 3 Then
            SSQLSTR2 = " SELECT * FROM CORPORATEMASTER WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')=''AND ISNULL(AUTHORISE_USER1,'')<>''  AND ISNULL(AUTHORISE_USER2,'')<>''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH3USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH3USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE2")
                If gdataset.Tables("AUTHORIZE2").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "'"
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM CORPORATEMASTER WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')=''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()
                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE CORPORATEMASTER set  ", "CMCorporateCode", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 3, 1)
                        End If
                    End If
                End If
            Else
                MsgBox("U R NOT ELIGIBLE TO AUTHORISE IN ANY LEVEL", MsgBoxStyle.Critical)
            End If
        End If



    End Sub

    Private Sub TXT_C_CODE_TextChanged(sender As Object, e As EventArgs) Handles TXT_C_CODE.TextChanged
        If brows = True Then
            Call Me.TXT_C_CODE_Validated(sender, e)
        End If
    End Sub

    Private Sub TXT_C_NAME_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_C_NAME.KeyPress
        getAlphanumeric(e)
    End Sub

    Private Sub TXT_ADD1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_ADD1.KeyPress
        getAlphanumeric(e)
    End Sub

    Private Sub TXT_ADD2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_ADD2.KeyPress
        getAlphanumeric(e)
    End Sub

    Private Sub TXT_ADD3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_ADD3.KeyPress
        getAlphanumeric(e)
    End Sub

    Private Sub TXT_CONT_PERSON_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_CONT_PERSON.KeyPress
        getAlphanumeric(e)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub CMD_DOS_Click(sender As Object, e As EventArgs) Handles CMD_DOS.Click
        Dim reportdesign As New ReportDesigner
        If TXT_C_NAME.Text.Length > 0 Then
            tables = " FROM CorporateMaster where CMCorporateName='" & TXT_C_NAME.Text & "' "
        Else
            tables = " FROM CorporateMaster"
        End If
        gheader = "CORPORATE MASTER"

        reportdesign.DataGridView1.ColumnCount = 2
        reportdesign.DataGridView1.Columns(0).Name = "Column Name"
        reportdesign.DataGridView1.Columns(0).Width = 250
        reportdesign.DataGridView1.Columns(0).ReadOnly = True
        reportdesign.DataGridView1.Columns(1).Name = "Size"
        reportdesign.DataGridView1.Columns(1).Width = 100


        Dim row As String() = New String() {"CMCORPORATECODE", "16"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"CMCORPORATENAME", "25"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"CMBILLING", "10"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"CORPORATE_TYPE", "32"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"PAID_UP_CAPITAL", "16"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"NETWORTH", "15"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"FREEZE", "8"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"CURRENTSTATUS", "14"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"CMNOMEMBERS", "12"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"CMFAX", "15"}
        reportdesign.DataGridView1.Rows.Add(row)


        row = New String() {"CMADDRESS1", "25"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"CMADDRESS2", "25"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"CMADDRESS3", "25"}
        reportdesign.DataGridView1.Rows.Add(row)

        row = New String() {"CMCITY", "20"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"CMSTATE", "15"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"CMCOUNTRY", "15"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"CMPIN", "8"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"CMPHONE", "15"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"CMFAX", "15"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"CMPAGER", "15"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"CMEMAIL", "25"}
        reportdesign.DataGridView1.Rows.Add(row)

        row = New String() {"CMCLASS", "20"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"REMARKS", "25"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"ADDUSER", "12"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"ADDDATE", "11"}

        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"UPDATEUSER", "12"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"UPDATEDATETIME", "15"}

        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"VOIDUSER", "12"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"VOIDDATETIME", "13"}
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
        SqlString = "select * from view_CorporateMaster"
        If TXT_C_CODE.Text = "" Then
            SqlString = SqlString & ""
        Else
            SqlString = SqlString & " WHERE CMCorporateCode= '" & TXT_C_CODE.Text & "' "
        End If
        Dim r As New Cry_Corporatemaster
        gconnection.getDataSet(SqlString, "view_CorporateMaster")
        If gdataset.Tables("view_CorporateMaster").Rows.Count > 0 Then

            Viewer.TableName = "view_CorporateMaster"
            Call Viewer.GetDetails(SqlString, "view_CorporateMaster", r)

            txtobj1 = r.ReportDefinition.ReportObjects("Text20")
            txtobj1.Text = UCase(gcompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text21")
            txtobj1.Text = UCase(gCompanyAddress(0))
            txtobj1 = r.ReportDefinition.ReportObjects("Text23")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text24")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text5")
            txtobj1.Text = UCase(gCompanyAddress(3))
            txtobj1 = r.ReportDefinition.ReportObjects("Text3")
            txtobj1.Text = UCase(gCompanyAddress(4))
            txtobj1 = r.ReportDefinition.ReportObjects("Text6")
            txtobj1.Text = UCase(gCompanyAddress(5))

            txtobj1 = r.ReportDefinition.ReportObjects("Text16")
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
        TXT_C_CODE.Focus()
    End Sub
End Class