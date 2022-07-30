Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Web
'Imports System.Web.UI
Imports System.Net
Imports System.Text
Imports System.Configuration
Imports System.Xml
Imports System.Collections
Imports System.ComponentModel
Imports x = Microsoft.Office.Interop.Excel
Imports ClosedXML.Excel
'Imports System.Web.HttpApplication
Public Class Frm_Outstandingsms
    Dim Sqlstring, bildt As String
    Dim gconnection As New GlobalClass
    Public selectNo As Integer
    Public MEMBERTYPE, Fill_Chk_str, substype As String
    Dim i As Integer
    Dim Response() As String
    Dim Response1() As Integer
    Dim a(), b As String
    Dim month1, noofdays As Integer
    Dim str As String
    Dim memtype1, memTYPE(0), substype1, Subtype(0) As String
    Dim UsedAmt, UsedAmt1, UsedAmt2 As Double
    Public farPoint As AxFPSpreadADO.AxfpSpread
    Public boolSearchNext, boolSearchResult As Boolean
    Private Sub Frm_Outstandingsms_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F7 Then
            Search = InputBox("ENTER TEXT", "SEARCH")
            ' If chklist_Membername.SelectedIndex = 0 Then
            If SSGRID_OUTSMS.Col >= 0 Then
                With SSGRID_OUTSMS
                    Call subSearch(Search)
                End With
            End If
        End If
    End Sub
    Public Sub subSearch(ByVal searchText As String)
        If Len(Trim(Search)) = 0 Then
            MsgBox("Search Text Can't Be Blank....", MsgBoxStyle.OkOnly, Application.ProductName)
            SSGRID_OUTSMS.Focus()
            Exit Sub
        End If
        Dim i, j, intStringLength, intRow As Int16
        If SSGRID_OUTSMS.DataRowCnt > 2 Then
            boolSearchResult = False
            If boolSearchNext = False Then
                intRow = 1
            Else
                intRow = SSGRID_OUTSMS.ActiveRow + 1
            End If
            For i = intRow To SSGRID_OUTSMS.DataRowCnt
                SSGRID_OUTSMS.Row = i
                SSGRID_OUTSMS.Col = SSGRID_OUTSMS.ActiveCol
                'intStringLength = farPoint.Text.Length
                intStringLength = Search.Length
                For j = 0 To intStringLength - 1
                    If UCase(Mid(Trim(SSGRID_OUTSMS.Text), j + 1, Len(Trim(Search)))) = UCase(Trim(Search)) Then
                        SSGRID_OUTSMS.SetActiveCell(SSGRID_OUTSMS.ActiveCol, i)
                        boolSearchResult = True
                        '  grpSearch.Focus()
                        Exit For
                    End If
                Next
                If boolSearchResult = True Then
                    Exit For
                End If
            Next
            If boolSearchResult = False Then
                MsgBox("Sorry, No Match Found...", MsgBoxStyle.OkOnly, Application.ProductName)
                'searchText.()
                Exit Sub
            End If
        End If
        SSGRID_OUTSMS.Focus()
    End Sub
    'Public Function Search_Item(ByVal searchText As String)
    '    Dim temp As Integer = 0
    '    For i As Integer = 0 To SSGRID_OUTSMS.Row - 1
    '        For j As Integer = 0 To SSGRID_OUTSMS.Col - 1
    '            'If SSGRID_OUTSMS.Row(0).Col(0).Value.ToString = TextBox1.Text Then
    '            '    MsgBox("Item found")
    '            '    temp = 1
    '            '    ' End If
    '            'End If
    '            With SSGRID_OUTSMS
    '                .Col = 1
    '                .Row = 1
    '                .Text = TextBox1.Text
    '            End With
    '        Next
    '    Next
    '    If temp = 0 Then
    '        MsgBox("Item not found")
    '    End If
    'End Function
    Private Sub Frm_Outstandingsms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label7.Visible = False
        Call Internet()
        Call Fillcat()
        Call Fillsubs()
        DataGridView1.Visible = False
        GroupBox1.Visible = False
        Me.BackgroundImageLayout = ImageLayout.Stretch
        '  Call Resize_Form()
        'SSGRID_OUTSMS.ClearRange(1, 1, -1, -1, True)
        ' Call Fillcat()
        'If Select_Category.CheckedItems.Count > 0 Then
        '    For i = 0 To Select_Category.CheckedItems.Count - 1
        '        memTYPE = Split(Select_Category.CheckedItems(i), ".")
        '        memtype1 = memtype1 & "'" & memTYPE(0) & "', "
        '    Next
        '    memtype1 = Mid(memtype1, 1, Len(memtype1) - 2)
        'Else
        '    MessageBox.Show("Select the Member Type", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Select_Category.Focus()
        '    Exit Sub
        'End If
        Sqlstring = " SELECT ISNULL(MCODE,'') AS MCODE,(ISNULL(PREFIX,'')+ ' ' +ISNULL(MNAME,''))AS MNAME,REPLACE(CONTCELL,' ','')AS CONTCELL FROM MEMBERMASTER "
        Sqlstring = Sqlstring & " WHERE membertypecode in ('') and  ISNULL(CONTCELL,'') <> '' AND ISNULL(CURENTSTATUS,'') = 'ACTIVE' ORDER BY MCODE"
        gconnection.getDataSet(Sqlstring, "Master")
        If gdataset.Tables("Master").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("Master").Rows.Count - 1
                With SSGRID_OUTSMS
                    .Col = 1
                    .Row = i + 1
                    .Text = Trim(gdataset.Tables("Master").Rows(i).Item("MCODE"))
                    .Col = 2
                    .Row = i + 1
                    .Text = Trim(gdataset.Tables("Master").Rows(i).Item("MNAME"))
                    .Col = 3
                    .Row = i + 1
                    .Text = Trim(gdataset.Tables("Master").Rows(i).Item("CONTCELL"))
                    .Col = 5
                    .Row = i + 1
                    .Text = "No"
                End With
            Next
        End If
        'rdo_Gen.Checked = True
    End Sub
    Private Sub Internet()
        Label7.Visible = True
        If My.Computer.Network.IsAvailable Then
            ' MsgBox("Computer is connected with internet.")
            Label7.Text = "Computer is connected with internet."
        Else
            ' MsgBox("Computer is not connected internet.")
            Label7.Text = "Computer is not connected with internet."
            Exit Sub
        End If
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
                        If Controls(i_i).Name = "Panel" Then
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
                        If Controls(i_i).Name = "process" Or Controls(i_i).Name = "cancel" Or Controls(i_i).Name = "Btn_close" Or Controls(i_i).Name = "btn_browse" Then
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
    Private Sub Fillcat()
        Dim ssql As String
        Dim MEMBERTYPE As New DataTable
        ssql = "select isnull(SUBTYPECODE,'') as membertype,isnull(SUBtypedesc,'') as typedesc from SUBCATEGORYMASTER "
        MEMBERTYPE = gconnection.GetValues(ssql)
        Dim Itration
        For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
            Select_Category.Items.Add(MEMBERTYPE.Rows(Itration).Item("Membertype") & "." & MEMBERTYPE.Rows(Itration).Item("TypeDesc"))
        Next
        'LoadUnitNO()
        Select_Category.Focus()
    End Sub
    Private Sub Fillsubs()
        Dim ssql As String
        Dim SUBTYPE As New DataTable
        ssql = "select isnull(SubsCode ,'') as SubsCode,isnull(SubsDesc ,'') as SubsDesc from subscriptionmast"
        SUBTYPE = gconnection.GetValues(ssql)
        Dim Itration
        For Itration = 0 To (SUBTYPE.Rows.Count - 1)
            Select_Subs.Items.Add(SUBTYPE.Rows(Itration).Item("SubsCode") & "." & SUBTYPE.Rows(Itration).Item("SubsDesc"))
        Next
        'LoadUnitNO()
        Select_Subs.Focus()
    End Sub
    Private Sub Select_Category_KeyDown(sender As Object, e As KeyEventArgs) Handles Select_Category.KeyDown
        SSGRID_OUTSMS.ClearRange(1, 1, -1, -1, True)
        ' Call Fillcat()
        memtype1 = ""
        If Select_Category.CheckedItems.Count > 0 Then
            For i = 0 To Select_Category.CheckedItems.Count - 1
                memTYPE = Split(Select_Category.CheckedItems(i), ".")
                memtype1 = memtype1 & "'" & memTYPE(0) & "', "
            Next
            memtype1 = Mid(memtype1, 1, Len(memtype1) - 2)
        Else
            MessageBox.Show("Select the Member Type", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Select_Category.Focus()
            Exit Sub
        End If
        Sqlstring = " SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'')AS MNAME,REPLACE(CONTCELL,' ','')AS CONTCELL  FROM MEMBERMASTER "
        Sqlstring = Sqlstring & " WHERE   MEMBERTYPECODE in (" & memtype1 & ")  AND  ISNULL(CONTCELL,'') <> '' AND ISNULL(CURENTSTATUS,'') = 'ACTIVE'  ORDER BY MCODE"
        'End If
        gconnection.getDataSet(Sqlstring, "Master")
        If gdataset.Tables("Master").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("Master").Rows.Count - 1
                With SSGRID_OUTSMS
                    .Col = 1
                    .Row = i + 1
                    .Text = Trim(gdataset.Tables("Master").Rows(i).Item("MCODE"))
                    .Col = 2
                    .Row = i + 1
                    .Text = Trim(gdataset.Tables("Master").Rows(i).Item("MNAME"))
                    .Col = 3
                    .Row = i + 1
                    .Text = Trim(gdataset.Tables("Master").Rows(i).Item("CONTCELL"))
                    .Col = 5
                    .Row = i + 1
                    .Text = "No"
                End With
            Next
        End If
        '  rdo_Gen.Checked = True
    End Sub
    Private Sub Select_Category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_Category.SelectedIndexChanged
        SSGRID_OUTSMS.ClearRange(1, 1, -1, -1, True)
        ' Call Fillcat()
        memtype1 = ""
        If Select_Category.CheckedItems.Count > 0 Then
            For i = 0 To Select_Category.CheckedItems.Count - 1
                memTYPE = Split(Select_Category.CheckedItems(i), ".")
                memtype1 = memtype1 & "'" & memTYPE(0) & "', "
            Next
            memtype1 = Mid(memtype1, 1, Len(memtype1) - 2)
        Else
            '    MessageBox.Show("Select the Member Type", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Select_Category.Focus()
            '    Exit Sub
        End If
        If memtype1 = "" Then
            Sqlstring = " SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'')AS MNAME,REPLACE(CONTCELL,' ','')AS CONTCELL  FROM MEMBERMASTER  "
            Sqlstring = Sqlstring & " WHERE MEMBERTYPECODE in('') and ISNULL(CONTCELL,'') <> '' AND ISNULL(CURENTSTATUS,'') = 'ACTIVE' AND MCODE in (select distinct MCODE from CCL_OUTSTANDINGSMS)  ORDER BY MCODE"
        Else
            Sqlstring = " SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'')AS MNAME,REPLACE(CONTCELL,' ','')AS CONTCELL  FROM MEMBERMASTER "
            Sqlstring = Sqlstring & " WHERE   MEMBERTYPECODE in (" & memtype1 & ")  AND  ISNULL(CONTCELL,'') <> '' AND ISNULL(CURENTSTATUS,'') = 'ACTIVE' and MCODE in (select distinct MCODE from CCL_OUTSTANDINGSMS)  ORDER BY MCODE"
        End If
        'End If
        gconnection.getDataSet(Sqlstring, "Master")
        If gdataset.Tables("Master").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("Master").Rows.Count - 1
                With SSGRID_OUTSMS
                    .Col = 1
                    .Row = i + 1
                    .Text = Trim(gdataset.Tables("Master").Rows(i).Item("MCODE"))
                    .Col = 2
                    .Row = i + 1
                    .Text = Trim(gdataset.Tables("Master").Rows(i).Item("MNAME"))
                    .Col = 3
                    .Row = i + 1
                    .Text = Trim(gdataset.Tables("Master").Rows(i).Item("CONTCELL"))
                    .Col = 5
                    .Row = i + 1
                    .Text = "No"
                End With
            Next
        End If
        '  rdo_Gen.Checked = True
    End Sub
    Private Sub Outstanding()
        Dim GenMsg, mcode, SqlStr As String
        Dim Phoneno As String
        Dim k As Integer
        Dim VREF As String
        If rdo_Curr.Checked = True Then
            GenMsg = "Dear Member, "
            With SSGRID_OUTSMS
                For k = 1 To .DataRowCnt
                    GenMsg = "Dear Member, "
                    .Row = k
                    .Col = 5
                    VREF = Trim(.Text)
                    If VREF = "YES" Then
                        GenMsg = "Dear Member, "
                        .Col = 1
                        .Row = k
                        mcode = Trim(.Text)
                        .Col = 3
                        .Row = k
                        Phoneno = Trim(.Text)
                        If Trim(Phoneno) <> "" And Len(Phoneno) = 10 And Trim(GenMsg) <> "" And Trim(mcode) <> "" Then
                            .Row = k
                            .Col = 4
                            .Text = "Sending..."
                            Call CreditBal_Check(mcode)
                            'If UsedAmt > 0 Then
                            '    GenMsg = GenMsg & " Your Outstanding As on Rs " & UsedAmt & " Dr. Regards"
                            'ElseIf UsedAmt < 0 Then
                            '    GenMsg = GenMsg & " Your Outstanding As on Rs " & UsedAmt & " Cr. Regards"
                            'ElseIf UsedAmt = 0 Then
                            '    GenMsg = GenMsg & " Your Outstanding As on is NILL   Regards"
                            'End If
                            If UsedAmt1 > 0 Then
                                GenMsg = GenMsg & "[" & Trim(mcode) & "]" & ", Your total outstanding as on date Rs " & UsedAmt & " and out of that Rs. " & UsedAmt1 & " is overdue considering bill up to " & Format(Dtp_premonth.Value, "dd/MMM/yyyy") & " and payment up to " & Format(dtp_rec.Value, "dd/MMM/yyyy") & " . Pl. pay"
                            End If
                            Call SendSMSEMC(GenMsg, Phoneno)
                            'If Response(0) = 402 Then
                            '    .Row = k
                            '    .Col = 4
                            '    .Text = "Sent"
                            'Else
                            '    .Row = k
                            '    .Col = 4
                            '    .Text = "Failed Check Phone No"
                            'End If
                            .Row = k
                            .Col = 4
                            .Text = "Sent"
                            'SqlStr = "INSERT INTO SendSmsStatus( mcode,Response1 ,BILLDATE ,Messagebox) VALUES('" & mcode & "'," & a(1) & ",'" & Format(dtp_curmonth.Value, "dd/MMM/yyyy") & "','" & GenMsg & "' )"
                            'gconnection.ExcuteStoreProcedure(SqlStr)
                        Else
                            .Row = k
                            .Col = 4
                            .Text = "Failed Check Phone No"
                        End If
                    End If
                Next
            End With
            MsgBox("Done.", MsgBoxStyle.OkOnly, "EMCKOL")
        End If
    End Sub
    Public Sub SendSMSEMC(ByVal Msg As String, ByVal Ph As String)
        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim url As String
        Dim reader As StreamReader
        Dim data As String = ""
        Dim username As String = ""
        Dim password As String = ""
        Dim uname As String = ""
        Dim pass As String = ""
        If Cbo_API.Text = "" Then
            MessageBox.Show("Please Select Gatway")
            Cbo_API.Focus()
            Exit Sub
        End If

        '  Dim host As String = "http://dndopen.loyalsmsindia.co.in/api/web2sms.php?"
        ' Dim host As String = "http://smsc.smsconnexion.com/api/gateway.aspx?action=send"
        Dim host As String
        If Cbo_API.Text = "Celusion" Then
            host = "http://smsc.smsconnexion.com/api/gateway.aspx?action=send"
        Else
            host = "http://103.247.98.91/API/SendMsg.aspx?"
        End If
        'Dim host As String = "http://103.247.98.91/API/SendMsg.aspx?"
        'Dim originator As String = "EMCKOL"
        Dim originator As String = "calcuttaclub"
        Dim Message As String
        Try
            If Ph <> "" And Len(Ph) = 10 And Msg <> "" Then
                'Message = "workingkey=A2f3266d41a2eae4b16443fb578859fdf&sender=EMCKOL&to=91" & Ph & "&message=" & Msg
                'Message = "&username=calcuttaclub&passphrase=123456&phone=91" & Ph & "&message=" & Msg
                'Message = "&username=calcuttaclub&passphrase=123456&message=" & Msg & "&phone=91" & Ph
                ' Message = "&uname=20152702&pass=123456&send=PROMO&dest=91" & Ph & "&msg = " & Msg
                If Cbo_API.Text = "Celusion" Then
                    Message = "&username=calcuttaclub&passphrase=123456&message=" & Msg & "&phone=91" & Ph
                Else
                    Message = "uname=20152702&pass=CALCLB123&send=CALCLB&dest=" & Ph & "&msg=" & Msg
                End If
                'Message = "&username=calcuttaclub&&passphrase=123456&route=2&senderid=BBSCLB&destination=" & CCELL & "&message=Bhubaneswar Club(" & Trim(mcode) & ")BILL till " & Format(Billdate, "dd/MM/yyyy") & " is Rs." & Format(ASONOUTSTANDING) & " . " & Format(Billdate, "MMM") & " dues Rs. " & Format(CURMONTHOUTSTANDING) & ".Previous dues Rs." & Format(AREEAR) & " .Total dues Rs." & Format(TOTALDUES) & ". " & Format(Billdate, "MMM") & " receipts Rs." & Format(CRMONTHRECEIPT) & "."
                url = host + "" & Message & ""
                request = DirectCast(WebRequest.Create(url), HttpWebRequest)
                response = DirectCast(request.GetResponse(), HttpWebResponse)
                reader = New StreamReader(response.GetResponseStream())
                data = reader.ReadToEnd()
                a = data.Split("-")
                'Dim strResult() As String
                'strResult = data.Split(FormatNumber(Environment.NewLine))
                ' MessageBox.Show("Response: " & response.StatusDescription)
            End If
        Catch ex As Exception
            MessageBox.Show("Netwrok Error.." & ex.ToString())
        End Try
    End Sub
    Private Function CreditBal_Check(ByVal membercode As String)
        Dim SqlStr, sqlstring As String
        ' SqlStr = "SELECT SUM(ISNULL(DRAMT,0)) AS DRAMT,SUM(ISNULL(CRAMT,0)) AS CRAMT FROM CREDITLIMIT_VIEW WHERE SLCODE = '" & Trim(membercode) & "' GROUP BY SLCODE"
        SqlStr = "select ASOUTSTANDING,PREOUTSTANDING from CCL_OUTSTANDING WHERE SLCODE = '" & Trim(membercode) & "'"
        gconnection.getDataSet(SqlStr, "Use")
        If gdataset.Tables("Use").Rows.Count > 0 Then
            UsedAmt = Val(gdataset.Tables("Use").Rows(0).Item("ASOUTSTANDING"))
            UsedAmt1 = Val(gdataset.Tables("Use").Rows(0).Item("PREOUTSTANDING"))
        Else
            UsedAmt = 0
            UsedAmt1 = 0
        End If
    End Function

    Private Sub Btn_close_Click(sender As Object, e As EventArgs) Handles Btn_close.Click
        Me.Close()
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
    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        DataGridView1.Visible = True
        GroupBox1.Visible = True
        Dim cmdText, billdt2, BILDT4, BILDT5, ssql As String
        Dim duedate, membertype, TYPE(0), month, sql, sqlstrinG, sqlstrinG4, month2 As String
        Dim opl, i As Integer
        Dim BILDATE As Date
        ' Call Validation()
        If Mid(Me.dtp_rec.Text, 1, 5) = "April" Then month1 = 4 : month = "APR" : noofdays = 30 : bildt = "01/apr/" & gFinancalyearStart : month2 = "04" : billdt2 = "30/apr/" & gFinancalyearStart
        If Mid(Me.dtp_rec.Text, 1, 3) = "May" Then month1 = 5 : month = "MAY" : noofdays = 31 : bildt = "01/may/" & gFinancalyearStart : month2 = "05" : billdt2 = "31/may/" & gFinancalyearStart
        If Mid(Me.dtp_rec.Text, 1, 3) = "Jun" Then month1 = 6 : month = "JUN" : noofdays = 30 : bildt = "01/jun/" & gFinancalyearStart : month2 = "06" : billdt2 = "30/jun/" & gFinancalyearStart
        If Mid(Me.dtp_rec.Text, 1, 4) = "July" Then month1 = 7 : month = "JUL" : noofdays = 31 : bildt = "01/jul/" & gFinancalyearStart : month2 = "07" : billdt2 = "31/jul/" & gFinancalyearStart
        If Mid(Me.dtp_rec.Text, 1, 6) = "August" Then month1 = 8 : month = "AUG" : noofdays = 31 : bildt = "01/aug/" & gFinancalyearStart : month2 = "08" : billdt2 = "31/aug/" & gFinancalyearStart
        If Mid(Me.dtp_rec.Text, 1, 9) = "September" Then month1 = 9 : month = "SEP" : noofdays = 30 : bildt = "01/sep/" & gFinancalyearStart : month2 = "09" : billdt2 = "30/sep/" & gFinancalyearStart
        If Mid(Me.dtp_rec.Text, 1, 7) = "October" Then month1 = 10 : month = "OCT" : noofdays = 31 : bildt = "01/oct/" & gFinancalyearStart : month2 = "10" : billdt2 = "31/oct/" & gFinancalyearStart
        If Mid(Me.dtp_rec.Text, 1, 8) = "November" Then month1 = 11 : month = "NOV" : noofdays = 30 : bildt = "01/nov/" & gFinancalyearStart : month2 = "11" : billdt2 = "30/nov/" & gFinancalyearStart
        If Mid(Me.dtp_rec.Text, 1, 8) = "December" Then month1 = 12 : month = "DEC" : noofdays = 31 : bildt = "01/dec/" & gFinancalyearStart : month2 = "12" : billdt2 = "31/dec/" & gFinancalyearStart
        If Mid(Me.dtp_rec.Text, 1, 7) = "January" Then month1 = 1 : month = "JAN" : noofdays = 31 : bildt = "01/jan/" & gFinancialyearEnd : month2 = "01" : billdt2 = "31/jan/" & gFinancialyearEnd
        If Mid(Me.dtp_rec.Text, 1, 8) = "February" Then month1 = 2 : month = "FEB" : noofdays = 28 : bildt = "01/feb/" & gFinancialyearEnd : month2 = "02" : billdt2 = "28/feb/" & gFinancialyearEnd
        If Mid(Me.dtp_rec.Text, 1, 5) = "March" Then month1 = 3 : month = "MAR" : noofdays = 31 : bildt = "01/mar/" & gFinancialyearEnd : month2 = "03" : billdt2 = "31/mar/" & gFinancialyearEnd

        sqlstrinG = "exec PROC_GETPROCOUTSTANDSMS '" & Format(dtp_curmonth.Value, "dd/MMM/yyyy") & "','" & Format(Dtp_premonth.Value, "dd/MMM/yyyy") & "','" & Format(dtp_rec.Value, "dd/MMM/yyyy") & "'"
        gconnection.dataOperation(1, sqlstrinG, "PROC_GETOUTSTANDSMS")

        substype1 = ""
        If Select_Subs.CheckedItems.Count > 0 Then
            For i = 0 To Select_Subs.CheckedItems.Count - 1
                Subtype = Split(Select_Subs.CheckedItems(i), ".")
                substype1 = substype1 & "'" & Subtype(0) & "', "
            Next
            substype1 = Mid(substype1, 1, Len(substype1) - 2)
        End If

        memtype1 = ""
        If Select_Category.CheckedItems.Count > 0 Then
            For i = 0 To Select_Category.CheckedItems.Count - 1
                memTYPE = Split(Select_Category.CheckedItems(i), ".")
                memtype1 = memtype1 & "'" & memTYPE(0) & "', "
            Next
            memtype1 = Mid(memtype1, 1, Len(memtype1) - 2)
            'Else
            '    MessageBox.Show("Select the Member Type", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Select_Category.Focus()
            '    Exit Sub
        End If
        If substype1 <> "" Then
            sqlstrinG = "UPDATE PROCOUTSTANDSMS SET subsamt=ISNULL((Select sum(amount) as amount from SUBSPOSTING B where b.subscode in (" & substype1 & ") and month(CAST(CONVERT(VARCHAR(50),billdate,106)as DATETIME))=month('" & Format(dtp_curmonth.Value, "dd/MMM/yyyy") & "') AND B.mcode=PROCOUTSTANDSMS.MCODE  ),0)"
            gconnection.dataOperation(1, sqlstrinG, "PROCOUTSTANDSMS")
        Else
        End If
        'brows = True
        'Dim VIEW1 As New VIEWHDR
        'VIEW1.Show()
        'VIEW1.DTGRDHDR.DataSource = Nothing
        'VIEW1.DTGRDHDR.Rows.Clear()
        'Dim STRQUERY As String
        'STRQUERY = "SELECT * FROM MEMBERMASTER"
        'gconnection.getDataSet(STRQUERY, "authorize")


        ' Dim connectionString As String = "Data Source=.;Initial Catalog=pubs;Integrated Security=True"
        Dim NITS As String
        If memtype1 = "" Then
            NITS = "select isnull(M.Prefix,'') as Prefix,SLCODE as MCODE,M.MNAME as MNAME,ASOUTSTANDING,PREOUTSTANDING,isnull(CONTADD1,'') as  CONTADD1,isnull(CONTADD2,'') as CONTADD2 ,isnull(CONTADD3,'') as CONTADD3,isnull(CONTADD4,'') as CONTADD4, isnull(CONTCELL ,'') as CONTCELL,isnull(CONTCITY  ,'') as CONTCITY , isnull(CONTSTATE ,'') as CONTSTATE , isnull(CONTEMAIL,'') as CONTEMAIL,isnull(CONTCOUNTRY,'') as CONTCOUNTRY ,isnull(CONTPIN,'') as  CONTPIN   from CCL_OUTSTANDING O inner join membermaster m on o.SLCODE =m.MCODE  and m.MEMBERTYPECODE in (" & memtype1 & ")  and isnull(CurentStatus ,'') in ('LIVE','ACTIVE') and isnull(PREOUTSTANDING,0)>0 "
        Else
            ' NITS = "select SLCODE as MCODE,ASOUTSTANDING,PREOUTSTANDING,isnull(CONTADD1,'') as  CONTADD1,isnull(CONTADD2,'') as CONTADD2 ,isnull(CONTADD3,'') as CONTADD3, isnull(CONTCELL ,'') as CONTCELL   from CCL_OUTSTANDING O inner join membermaster m on o.SLCODE =m.MCODE and m.membertypecode in (" & memtype1 & ") and isnull(CurentStatus ,'') in ('LIVE','ACTIVE') "
            NITS = "select isnull(M.Prefix,'') as Prefix,SLCODE as MCODE,M.MNAME,ASOUTSTANDING,PREOUTSTANDING,isnull(CONTADD1,'') as  CONTADD1,isnull(CONTADD2,'') as CONTADD2 ,isnull(CONTADD3,'') as CONTADD3,isnull(CONTADD4,'') as CONTADD4, isnull(CONTCELL ,'') as CONTCELL,isnull(CONTCITY  ,'') as CONTCITY , isnull(CONTSTATE,'') as CONTSTATE , isnull(CONTEMAIL ,'') as CONTEMAIL,isnull(CONTCOUNTRY,'') as CONTCOUNTRY, isnull(CONTPIN,'') as  CONTPIN   from CCL_OUTSTANDING O inner join membermaster m on o.SLCODE =m.MCODE  and m.MEMBERTYPECODE in (" & memtype1 & ")   and isnull(CurentStatus ,'') in ('LIVE','ACTIVE') and isnull(PREOUTSTANDING,0)>0 "

        End If
        ' Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter
        Dim ds As New DataSet()
        'connection.Open()
        ' dataadapter.Fill(ds, "CCL_OUTSTANDING")
        gconnection.getDataSet(NITS, "CCL_OUTSTANDING")
        'connection.Close()
        'DataGridView1.DataSource = ds
        'DataGridView1.DataMember = "CCL_OUTSTANDING"

        'Call VIEW1.LOADGRID(gdataset.Tables("authorize"), True, "", "SELECT * FROM MEMBERMASTER", "membercode", 1, "membercode")

        If gdataset.Tables("CCL_OUTSTANDING").Rows.Count > 0 Then
            DataGridView1.Rows.Add(gdataset.Tables("CCL_OUTSTANDING").Rows.Count - 1)
            For i = 0 To gdataset.Tables("CCL_OUTSTANDING").Rows.Count - 1

                With DataGridView1
                    DataGridView1.Rows(i).Cells(0).Value = gdataset.Tables("CCL_OUTSTANDING").Rows(i).Item("Prefix")
                    DataGridView1.Rows(i).Cells(1).Value = gdataset.Tables("CCL_OUTSTANDING").Rows(i).Item("Mcode")
                    DataGridView1.Rows(i).Cells(2).Value = gdataset.Tables("CCL_OUTSTANDING").Rows(i).Item("MNAME")
                    DataGridView1.Rows(i).Cells(3).Value = gdataset.Tables("CCL_OUTSTANDING").Rows(i).Item("ASOUTSTANDING")
                    DataGridView1.Rows(i).Cells(4).Value = gdataset.Tables("CCL_OUTSTANDING").Rows(i).Item("PREOUTSTANDING")
                    DataGridView1.Rows(i).Cells(5).Value = gdataset.Tables("CCL_OUTSTANDING").Rows(i).Item("CONTADD1")
                    DataGridView1.Rows(i).Cells(6).Value = gdataset.Tables("CCL_OUTSTANDING").Rows(i).Item("CONTADD2")
                    DataGridView1.Rows(i).Cells(7).Value = gdataset.Tables("CCL_OUTSTANDING").Rows(i).Item("CONTADD3")
                    DataGridView1.Rows(i).Cells(8).Value = gdataset.Tables("CCL_OUTSTANDING").Rows(i).Item("CONTADD4")
                    DataGridView1.Rows(i).Cells(9).Value = gdataset.Tables("CCL_OUTSTANDING").Rows(i).Item("CONTCELL")
                    DataGridView1.Rows(i).Cells(10).Value = gdataset.Tables("CCL_OUTSTANDING").Rows(i).Item("CONTCITY")
                    DataGridView1.Rows(i).Cells(11).Value = gdataset.Tables("CCL_OUTSTANDING").Rows(i).Item("CONTSTATE")
                    DataGridView1.Rows(i).Cells(12).Value = gdataset.Tables("CCL_OUTSTANDING").Rows(i).Item("CONTEMAIL")
                    DataGridView1.Rows(i).Cells(13).Value = gdataset.Tables("CCL_OUTSTANDING").Rows(i).Item("CONTCOUNTRY")
                    DataGridView1.Rows(i).Cells(14).Value = gdataset.Tables("CCL_OUTSTANDING").Rows(i).Item("CONTPIN")

                    ' DataGridView1.Rows(i).Cells(7).Value = gdataset.Tables("CCL_OUTSTANDING").Rows(i).Item("CONTCELL")
                    Dim senior As DataGridViewCheckBoxCell = New DataGridViewCheckBoxCell

                    'DataGridView1.Rows(i).Cells(3).Value = True

                End With
            Next i

        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Call exportnew(DataGridView1, Path)
        Dim dgData As DataGridView = DirectCast(DataGridView1, DataGridView)
        With SaveFileDialog1
            .Filter = "Excel|*.xlsx"
            .Title = "Save griddata in Excel"
            If .ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                'Dim o As New ExcelExporter
                Dim b = exportnew(dgData, .FileName)
                MsgBox("EXPORT COMPLETED SUCCESSFULY")
            End If
            .Dispose()
        End With
        'Call ButtonExport()

        'Dim XLWorkbook As Microsoft.Office.Interop.Excel.Workbook
        'Dim dt As New DataTable()

        ''Adding the Columns
        'For Each column As DataGridViewColumn In DataGridView1.Columns
        '    dt.Columns.Add(column.HeaderText, column.ValueType)
        'Next

        ''Adding the Rows
        'For Each row As DataGridViewRow In DataGridView1.Rows
        '    dt.Rows.Add()
        '    For Each cell As DataGridViewCell In row.Cells
        '        dt.Rows(dt.Rows.Count - 1)(cell.ColumnIndex) = cell.Value.ToString()
        '    Next
        'Next

        ''Exporting to Excel

        'Dim folderPath As String = "C:\Excel\"
        'If Not Directory.Exists(folderPath) Then
        '    Directory.CreateDirectory(folderPath)
        'End If
        '' Dim xp As New x.Application
        'Dim wBook As Microsoft.Office.Interop.Excel.Workbook
        'Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

        'Using wb As New XLWorkbook()
        '    wb.Worksheets.Add(dt, "Customers")
        '    wb.SaveAs(folderPath & Convert.ToString("DataGridViewExport.xlsx"))
        'End Using
        'Dim xlApp As Excel.Application
        'Dim xlWorkBook As Excel.Workbook
        'Dim xlWorkSheet As Excel.Worksheet
        'Dim Path As String
        'xlWorkSheet.SaveAs("D:\OUT.xlsx")
        '' xlWorkBook.SaveAs(Path & ".xls")
        'xlWorkBook.Close()
        'xlApp.Quit()

        'releaseObject(xlApp)
        'releaseObject(xlWorkBook)
        'releaseObject(xlWorkSheet)
        'MsgBox("You can find the file D:\OUT.xlsx")

        '====================================
        Dim Path As String
        'Dim default_location As String = Path & ".xls"
        ''Creating dataset to export
        'Dim dset As New DataSet
        ''add table to dataset
        'dset.Tables.Add()
        ''add column to that table
        'For i As Integer = 0 To DataGridView1.ColumnCount - 1
        '    dset.Tables(0).Columns.Add(DataGridView1.Columns(i).HeaderText)
        'Next
        ''add rows to the table
        'Dim dr1 As DataRow
        'For i As Integer = 0 To DataGridView1.RowCount - 1
        '    dr1 = dset.Tables(0).NewRow
        '    For j As Integer = 0 To DataGridView1.Columns.Count - 1
        '        dr1(j) = DataGridView1.Rows(i).Cells(j).Value
        '    Next
        '    dset.Tables(0).Rows.Add(dr1)
        'Next

        'Dim excel As New Microsoft.Office.Interop.Excel.ApplicationClass
        'Dim wBook As Microsoft.Office.Interop.Excel.Workbook
        'Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

        'excel.Visible = True
        'excel.UserControl = True

        'wBook = excel.Workbooks.Add(System.Reflection.Missing.Value)
        'wSheet = wBook.Sheets("sheet1")
        'excel.Range("A50:I50").EntireColumn.AutoFit()
        'With wBook
        '    .Sheets("Sheet1").Select()
        '    .Sheets(1).Name = "NameYourSheet"
        'End With

        'Dim dt As System.Data.DataTable = dset.Tables(0)
        'wSheet.Cells(1).value = Path
        '' Dim i As Integer

        'For i = 0 To DataGridView1.RowCount - 1
        '    For j = 0 To DataGridView1.ColumnCount - 1
        '        wSheet.Cells(i + 1, j + 1).value = DataGridView1.Rows(i).Cells(j).Value.tosring
        '    Next j
        'Next i

        'wSheet.Columns.AutoFit()
        'Dim blnFileOpen As Boolean = False
        'Try
        '    Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(default_location)
        '    fileTemp.Close()
        'Catch ex As Exception
        '    blnFileOpen = False
        'End Try

        'If System.IO.File.Exists(default_location) Then
        '    System.IO.File.Delete(default_location)
        'End If

        'wBook.SaveAs(default_location)
        'excel.Workbooks.Open(default_location)
        'excel.Visible = True
    End Sub
    Private Function exportnew(ByRef datagridview1 As DataGridView, ByVal Path As String) As Boolean
        Dim i, j As Integer
        Dim default_location As String = Path & ".xls"
        'Creating dataset to export
        Dim dset As New DataSet
        'add table to dataset
        dset.Tables.Add()
        'add column to that table
        For i = 0 To datagridview1.ColumnCount - 1
            dset.Tables(0).Columns.Add(datagridview1.Columns(i).HeaderText)
        Next
        'add rows to the table
        Dim dr1 As DataRow
        For i = 0 To datagridview1.RowCount - 1
            dr1 = dset.Tables(0).NewRow
            For j = 0 To datagridview1.Columns.Count - 1
                dr1(j) = datagridview1.Rows(i).Cells(j).Value
            Next
            dset.Tables(0).Rows.Add(dr1)
        Next

        Dim xp As New x.Application
        Dim wBook As Microsoft.Office.Interop.Excel.Workbook
        Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

        xp.Visible = True
        xp.UserControl = True

        wBook = xp.Workbooks.Add(System.Reflection.Missing.Value)
        wSheet = wBook.Sheets("sheet1")
        xp.Range("A50:I50").EntireColumn.AutoFit()
        With wBook
            .Sheets("Sheet1").Select()
            .Sheets(1).Name = "NameYourSheet"
        End With

        Dim dt As System.Data.DataTable = dset.Tables(0)
        wSheet.Cells(1).value = Path
        ' Dim i As Integer
        Dim s As String
        Dim colcount = 0
        Dim ColNames As Generic.List(Of String) = (From col As DataGridViewColumn _
                                           In datagridview1.Columns.Cast(Of DataGridViewColumn)() _
                                           Where (col.Visible = True) _
                                           Order By col.DisplayIndex _
                                           Select col.Name).ToList
        For Each s In ColNames
            colcount += 1
            wSheet.Cells(1, colcount) = datagridview1.Columns.Item(s).HeaderText.ToString
        Next
        For i = 0 To datagridview1.RowCount - 1
            For j = 0 To datagridview1.ColumnCount - 1
                If IsDBNull(datagridview1.Rows(i).Cells(j).Value) = False Or datagridview1.Rows(i).Cells(j).Value.ToString() <> Nothing Then
                    wSheet.Cells(i + 2, j + 1).value = datagridview1.Rows(i).Cells(j).Value.ToString()
                Else
                    wSheet.Cells(i + 2, j + 1).value = ""
                End If

            Next j
        Next i

        wSheet.Columns.AutoFit()
        Dim blnFileOpen As Boolean = False
        Try
            Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(default_location)
            fileTemp.Close()
        Catch ex As Exception
            blnFileOpen = False
        End Try

        If System.IO.File.Exists(default_location) Then
            System.IO.File.Delete(default_location)
        End If

        wBook.SaveAs(default_location)
        xp.Workbooks.Open(default_location)
        xp.Visible = True
    End Function

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GroupBox1.Visible = False
        DataGridView1.Visible = False
    End Sub
    Private Sub SSGRID_OUTSMS_KeyDownEvent(sender As Object, e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles SSGRID_OUTSMS.KeyDownEvent
        Dim I As Integer
        Dim VSTR As Integer
        If e.keyCode = Keys.F2 Then
            For I = SSGRID_OUTSMS.ActiveRow To SSGRID_OUTSMS.DataRowCnt
                With SSGRID_OUTSMS
                    .Row = I
                    .Col = 5
                    .Text = "YES"
                End With
            Next
        ElseIf e.keyCode = Keys.F3 Then
            For I = SSGRID_OUTSMS.ActiveRow To SSGRID_OUTSMS.DataRowCnt
                With SSGRID_OUTSMS
                    .Row = I
                    .Col = 5
                    .Text = "NO"
                End With
            Next
        End If
        If e.keyCode = Keys.F7 Then
            Search = InputBox("ENTER TEXT", "SEARCH")
            ' If chklist_Membername.SelectedIndex = 0 Then
            If SSGRID_OUTSMS.Col >= 0 Then
                With SSGRID_OUTSMS
                    Call subSearch(Search)
                End With
            End If
        End If
    End Sub
    Private Sub process_Click(sender As Object, e As EventArgs) Handles process.Click
        If rdo_Curr.Checked = True Then
            Call Outstanding()
        End If
    End Sub
End Class