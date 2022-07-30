Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class FRM_MKGA_SUBSCRIPTION_MASTER
    Dim SqlString, strVotingright, strSubscription As String
    Dim gconnection As New GlobalClass
    Dim boolchk, checkValid As Boolean
    Dim Bmonth As Integer
    Dim billingmonth As String
    Dim taxcode As Double

    Private Sub Chekbillingmonth_KeyDown(sender As Object, e As KeyEventArgs) Handles Chekbillingmonth.KeyDown
        If e.KeyCode = Keys.Enter Then
            Comb_basedon.Focus()
        End If
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Cmd_subhelp.Click

    '    Dim vform As New LIST_OPERATION1
    '    gSQLString = "Select subscode,subsdesc from subscriptionmast"
    '    M_WhereCondition = " "
    '    vform.vCaption = "subscriptionmast Help"
    '    vform.Field = "subscode,subsdesc"

    '    vform.CMB_SRC_FIELDS.Select()
    '    vform.ShowDialog(Me)
    '    If Trim(keyfield & "") <> "" Then
    '        Txt_Subcode.Text = Trim(keyfield & "")
    '        Txt_desc.Select()
    '        txtsubcode_validated()
    '    End If
    '    vform.Close()
    '    vform = Nothing
    '    Cmd_add.Text = "Update[F7]"

    'End Sub

    'Private Sub Button1_Click1(sender As Object, e As EventArgs) Handles Cmd_subhelp.Click

    '    Dim vform As New LIST_OPERATION1
    '    gSQLString = "Select subscode,subsdesc from subscriptionmast"
    '    M_WhereCondition = " "
    '    vform.vCaption = "subscriptionmast Help"
    '    vform.Field = "subscode,subsdesc"

    '    vform.CMB_SRC_FIELDS.Select()
    '    vform.ShowDialog(Me)
    '    If Trim(keyfield & "") <> "" Then
    '        Txt_Subcode.Text = Trim(keyfield & "")
    '        Txt_desc.Select()
    '        txtsubcode_validated()
    '    End If
    '    vform.Close()
    '    vform = Nothing
    '    Cmd_add.Text = "Update[F7]"

    'End Sub


    Private Sub Txt_subamount_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_subamount.KeyDown
        Dim TAX As Double
        'MODIFIED BY LOKESH
        If e.KeyCode = Keys.Enter Then
            Cmd_add.Focus()
            TAX = Format((Val(Txt_subamount.Text)), "0.00") * Format(Val(Trim(Txt_Percentage.Text & "")), "0.00")
            Txt_Taxamount.Text = Format(Val(TAX / 100), "0.00")

        End If

        ''  End If
    End Sub
    Private Sub cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub Txt_subamount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_subamount.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Txt_subamount.Text <> "" Then
                Txt_luxuryTax.Focus()
            End If
        End If
    End Sub

    Private Sub Txt_subamount_LostFocus(sender As Object, e As EventArgs) Handles Txt_subamount.LostFocus
        Txt_subamount.Text = Format(Val(Txt_subamount.Text), "0.00")
    End Sub

    Private Sub subamount_TextChanged(sender As Object, e As EventArgs) Handles Txt_subamount.TextChanged

    End Sub

    Private Sub Txt_Percentage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Percentage.KeyPress
        Txt_subamount.Focus()

    End Sub

    Private Sub Percentage_TextChanged(sender As Object, e As EventArgs) Handles Txt_Percentage.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Cmd_exit.Click
        Me.Close()
    End Sub
    Private Sub FRM_MKGA_SUBSCRIPTION_MASTER_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.F7 Then
                If Cmd_add.Enabled = True Then
                    Call Cmd_add_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F6 Then
                If cmd_clear.Enabled = True Then
                    Call cmd_Clear_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F8 Then
                If Cmd_freeze.Enabled = True Then
                    Call Cmd_freeze_Click(sender, e)
                    Exit Sub
                End If

            ElseIf e.KeyCode = Keys.F9 Then
                If Cmd_view.Enabled = True Then
                    Call Cmd_view_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F10 Then
                'If Cmd_Dos.Enabled = True Then
                '    Call Cmd_Dos_Click(sender, e)
                '    Exit Sub
                ' End If
                'ElseIf e.KeyCode = Keys.F4 Then
                '    If Cmd_Dos.Enabled = True Then
                '        Call Cmd_subhelp_Click(sender, e)
                '        Exit Sub
                '    End If
            ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
                If Cmd_exit.Enabled = True Then
                    Call cmd_Exit_Click(sender, e)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub

    Private Sub FRM_MKGA_SUBSCRIPTION_MASTER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Call Resize_Form()
        Me.lbl_freeze.Visible = False
        Me.Lbl_Basedon.Visible = False
        Me.Comb_basedon.Visible = False
        Me.lbl_freeze.Text = "Record Freezed  On "
        Me.Cmd_freeze.Text = "Void[F8]"
        Cmd_add.Text = "Add[F7]"
        Grp_Print.Visible = False
        Txt_Subcode.ReadOnly = False
        Txt_desc.ReadOnly = False
        txt_subdesc.ReadOnly = False
        Txt_taxcode.ReadOnly = False
        Txt_Percentage.ReadOnly = False
        Txt_Taxamount.ReadOnly = False
        Txt_Taxaccountin.ReadOnly = False
        Txt_subamount.ReadOnly = False
        Txt_Subcode.Focus()
        LBL_CHG.Visible = False
        CBO_FACILITY.Visible = False
        Txt_Agefrom.Visible = False
        Txt_Ageto.Visible = False
        Txt_Agefrom.Visible = False
        Txt_Ageto.Visible = False
        lbl_fromage.Visible = False
        lbl_toage.Visible = False
        LST_FACILITY.Visible = False
        LBL_APPLIEDFACILITY.Visible = False
        Cmd_add.Enabled = True
        Call FillItemTypeMaster()
        Call FILLTAX()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        Txt_Subcode.Focus()
        Call SubscriptionType()
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
                        If Controls(i_i).Name = "cmd_clear" Or Controls(i_i).Name = "Cmd_add" Or Controls(i_i).Name = "Cmd_freeze" Or Controls(i_i).Name = "Cmd_view" Or Controls(i_i).Name = "Cmd_Authantication" Or Controls(i_i).Name = "Cmd_exit" Then
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
    Private Sub FillItemTypeMaster()
        Dim i As Integer
        ChkList_ItemType.Items.Clear()
        sqlstring = " SELECT DISTINCT ISNULL(ItemTypeCode,'') AS ItemTypeCode,ISNULL(ItemTypeDesc,'') AS ItemTypeDesc  FROM ItemTypeMaster WHERE ISNULL(FREEZE,'')<>'Y' "
        GConnection.getDataSet(sqlstring, "TaxMaster")
        If gdataset.Tables("TaxMaster").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("TaxMaster").Rows.Count - 1
                With gdataset.Tables("TaxMaster").Rows(i)
                    ChkList_ItemType.Items.Add(Trim(.Item("ItemTypeCode") & "->" & .Item("ItemTypeDesc")))
                End With
            Next i
        End If
        ChkList_ItemType.Sorted = True
    End Sub
    Private Sub FILLTAX()
        Dim dt As DataTable
        List_Tax.Items.Clear()
        ' sqlstring = "SELECT distinct TAXCODE+'-->'+TAXPERCENTAGE+'-->'+TAXON as TAXPERCENTAGE FROM ITEMTYPEMASTER"
        SqlString = "SELECT distinct TAXCODE+'-->'+CAST(CAST(TAXPERCENTAGE as NUMERIC) as VARCHAR)+'-->'+TAXON as TAXPERCENTAGE FROM ITEMTYPEMASTER"
        dt = gconnection.GetValues(SqlString)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            List_Tax.Items.Add(dt.Rows(Itration).Item("TAXPERCENTAGE"))
        Next
    End Sub
    Private Sub FILLFACILITY()
        Dim DT As DataTable
        LST_FACILITY.Items.Clear()
        SqlString = "SELECT ISNULL(POSCODE,'') AS POSCODE,ISNULL(POSDESC,'') AS POSDESC FROM POSMASTER WHERE ISNULL(FREEZE,'')<>'Y' AND ISNULL(STORETYPE,'')='FACILITY'"
        gconnection.getDataSet(SqlString, "Facility")
        If gdataset.Tables("facility").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("facility").Rows.Count - 1
                With gdataset.Tables("facility").Rows(i)
                    LST_FACILITY.Items.Add(Trim(.Item("poscode") & "-" & .Item("posdesc")))

                End With
            Next
            LST_FACILITY.Items.Add("BIL-BILLIARDS")
        End If
    End Sub
    Private Sub FillItemTypeDetails()
        Try
            Dim i As Integer
            SqlString = " SELECT DISTINCT ISNULL(TAXTYPECODE,'') AS TAXTYPECODE,ISNULL(TAXTYPEDESC,'') AS TAXTYPEDESC FROM GMS_GREENFEETAXALLOCATION "
            GConnection.getDataSet(sqlstring, "TAXLINK")
            If gdataset.Tables("TAXLINK").Rows.Count > 0 Then
                ChkList_ItemType.Items.Clear()
                For i = 0 To gdataset.Tables("TAXLINK").Rows.Count - 1
                    With gdataset.Tables("TAXLINK").Rows(i)
                        ChkList_ItemType.Items.Add(Trim(.Item("TAXTYPECODE") & "->" & .Item("TAXTYPEDESC")))
                        ChkList_ItemType.SetItemChecked(i, True)
                    End With
                Next i
            End If
            SqlString = " SELECT DISTINCT ISNULL(ItemTypeCode,'') AS ItemTypeCode,ISNULL(ItemTypeDesc,'') AS ItemTypeDesc  FROM ItemTypeMaster WHERE ISNULL(FREEZE,'')<>'Y' AND ItemTypeCode NOT IN (SELECT DISTINCT TAXTYPECODE FROM GMS_GREENFEETAXALLOCATION "
            GConnection.getDataSet(sqlstring, "TAXLINK")
            If gdataset.Tables("TAXLINK").Rows.Count > 0 Then
                For i = 0 To gdataset.Tables("TAXLINK").Rows.Count - 1
                    With gdataset.Tables("TAXLINK").Rows(i)
                        ChkList_ItemType.Items.Add(Trim(.Item("ItemTypeCode") & "->" & .Item("ItemTypeDesc")))
                    End With
                Next i
            End If
        Catch ex As Exception
            MessageBox.Show("Handle the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub FillItemTypeDetails_Det()
        Try
            Dim i As Integer
            Dim Code() As String
            ChkList_ItemTypeDet.Items.Clear()
            sqlstring = " SELECT ISNULL(TAXCODE,'') AS TAXCODE,ISNULL(TAXPERCENTAGE,0) AS TAXPERC,ISNULL(TAXON,'') AS TAXON FROM ItemTypeMaster "
            If ChkList_ItemType.CheckedItems.Count <> 0 Then
                sqlstring = sqlstring & " WHERE ITEMTYPECODE IN ("
                For i = 0 To ChkList_ItemType.CheckedItems.Count - 1

                    sqlstring = sqlstring & " '" & Code(0) & "', "
                Next
                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                sqlstring = sqlstring & ")"
            Else
                'MessageBox.Show("Select the location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
            sqlstring = sqlstring & " ORDER BY TAXON "
            GConnection.getDataSet(sqlstring, "TAXLINKDET")
            If gdataset.Tables("TAXLINKDET").Rows.Count > 0 Then
                ' ChkList_ItemTypeDet.Items.Clear()
                For i = 0 To gdataset.Tables("TAXLINKDET").Rows.Count - 1
                    With gdataset.Tables("TAXLINKDET").Rows(i)
                        ChkList_ItemTypeDet.Items.Add(Trim(.Item("TAXCODE") & "->" & .Item("TAXPERC") & "->" & .Item("TAXON")))
                        ChkList_ItemTypeDet.SetItemChecked(i, True)
                    End With
                Next i
            End If
        Catch ex As Exception
            MessageBox.Show("Handle the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
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
        Me.Cmd_add.Enabled = True

        Me.Cmd_freeze.Enabled = True

        Cmd_view.Enabled = True

        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.Cmd_add.Enabled = True
                    Me.Cmd_freeze.Enabled = True
                    Me.Cmd_view.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.Cmd_add.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.Cmd_add.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.Cmd_add.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    Me.Cmd_freeze.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.Cmd_view.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles cmd_clear.Click
        clearform(Me)
        chk_billingmonth.Items.Clear()
        For i = 0 To Chekbillingmonth.Items.Count - 1
            Chekbillingmonth.SetItemChecked(i, False)
        Next i
        Com_subtypecode.SelectedIndex = -1
        Comb_billbasis.SelectedIndex = -1
        Comb_appliedon.SelectedIndex = -1
        Comb_basedon.SelectedIndex = -1
        Chekbillingmonth.SelectedIndex = -1
        chk_billingmonth.SelectedIndex = -1
        Txt_Subcode.Enabled = True
        Com_subtypecode.Enabled = True
        Comb_billbasis.Enabled = True
        Txt_Subcode.Focus()
        lbl_freeze.Visible = False
        Chekbillingmonth.Enabled = True
        Txt_Agefrom.Text = ""
        Txt_Ageto.Text = ""
        Txt_from.Text = ""
        Txt_to.Text = ""
        LBL_CHG.Visible = False
        LBL_APPLIEDFACILITY.Visible = False
        LST_FACILITY.Visible = False
        CBO_FACILITY.Visible = False
        Comb_basedon.Visible = True
        Comb_basedon.Visible = False
        Txt_taxcode.Text = ""
        Txt_taxcode.Enabled = True
        Txt_taxcode.ReadOnly = False
        Txt_Taxaccountin.ReadOnly = False
        Txt_Percentage.ReadOnly = False

        ChkList_ItemTypeDet.Items.Clear()
        For i = 0 To ChkList_ItemTypeDet.Items.Count - 1
            ChkList_ItemTypeDet.SetItemChecked(i, False)
        Next i
        'ChkList_ItemType.Items.Clear()
        For i = 0 To ChkList_ItemType.Items.Count - 1
            ChkList_ItemType.SetItemChecked(i, False)
        Next i

        Grp_Print.Visible = False
        'Cmd_taxcodehelp.Visible = False


        ' Lbl_Taxcode.Visible = True
        ' Lblpercentage.Visible = True
        ' Txt_Percentage.Visible = True
        'Txt_taxcode.Visible = True
        'Cmd_taxcodehelp.Visible = True


        Cmd_add.Text = "Add[F7]"
        Cmd_freeze.Text = "Void[F9]"

    End Sub
    Public Sub SubscriptionType()
        Dim i As Integer
        Dim dt As DataTable
        SqlString = "SELECT Code,NAME FROM Tbl_SubscriptionType_Master where freeze<>'Y'and isnull(name,'')<>''  "
        dt = gconnection.GetValues(SqlString)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            Com_subtypecode.Items.Add(dt.Rows(Itration).Item("Code"))
        Next
    End Sub

    Private Sub Com_subtypecode_Click(sender As Object, e As EventArgs) Handles Com_subtypecode.Click

    End Sub

    Private Sub Com_subtypecode_DockChanged(sender As Object, e As EventArgs) Handles Com_subtypecode.DockChanged

    End Sub

    Private Sub Com_subtypecode_KeyDown(sender As Object, e As KeyEventArgs) Handles Com_subtypecode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Comb_billbasis.Focus()
        End If
       
        If Com_subtypecode.Text = "GEN" Then
            txt_subdesc.Text = "GENERAL"
        End If
        If Com_subtypecode.Text = "MUC" Then
            txt_subdesc.Text = "MINIMUM USAGE CHARGE"
        End If
        If Com_subtypecode.Text = "FAC" Then
            txt_subdesc.Text = "FACILITY"
        End If
        If Com_subtypecode.Text = "SPECIAL" Then
            txt_subdesc.Text = "SPECIAL"
        End If
        If Com_subtypecode.Text = "GEN" Then
            txt_subdesc.Text = "GENERAL"
        End If
        'SqlString = "SELECT Code,NAME FROM Tbl_SubscriptionType_Master where Code='" & Trim(Com_subtypecode.Text) & "'and freeze<>'Y'  "
        'gconnection.getDataSet(SqlString, "MemMst")
        'If gdataset.Tables("MemMst").Rows.Count > 0 Then
        '    txt_subdesc.Text = gdataset.Tables("MemMst").Rows(0).Item("NAME")
        'End If
    End Sub

    Private Sub Com_subtypecode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Com_subtypecode.KeyPress
        'Blank(e)
    End Sub

    Private Sub Com_subtypecode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Com_subtypecode.SelectedIndexChanged
        If Mid(Com_subtypecode.Text, 1, 4) = "FAC" Then
            'LBL_CHG.Visible = True
            'LBL_APPLIEDFACILITY.Visible = True
            'LST_FACILITY.Visible = True
            'CBO_FACILITY.Visible = True
            Lbl_Basedon.Visible = True

            Comb_basedon.Visible = True
            Call FILLFACILITY()
        Else
            LBL_CHG.Visible = False
            LBL_APPLIEDFACILITY.Visible = False
            LST_FACILITY.Visible = False
            Lbl_Basedon.Visible = False
            Comb_basedon.Visible = False
            CBO_FACILITY.Visible = False
            lbl_fromage.Visible = False
            Txt_Agefrom.Visible = False
            Txt_Ageto.Visible = False
            Txt_Agefrom.Visible = False
            Txt_Ageto.Visible = False
        End If
        If Com_subtypecode.Text = "GEN" Then
            txt_subdesc.Text = "GENERAL"
        End If
        If Com_subtypecode.Text = "MUC" Then
            txt_subdesc.Text = "MINIMUM USAGE CHARGE"
        End If
        If Com_subtypecode.Text = "FAC" Then
            txt_subdesc.Text = "FACILITY"
        End If
        If Com_subtypecode.Text = "SPECIAL" Then
            txt_subdesc.Text = "SPECIAL"
        End If
        If Com_subtypecode.Text = "GEN" Then
            txt_subdesc.Text = "GENERAL"
        End If
        If Com_subtypecode.Text = "OTHERS" Then
            txt_subdesc.Text = "OTHERS"
        End If
    End Sub

    Private Sub Comb_billbasis_KeyDown(sender As Object, e As KeyEventArgs) Handles Comb_billbasis.KeyDown
        If e.KeyCode = Keys.Enter Then
            Comb_appliedon.Focus()
            'If Comb_billbasis.Text = "% %" Then
            '    ' Comb_appliedon.Focus()
            'Else
            '    'Comb_appliedon.Focus()
            'End If
        End If

        'Comb_appliedon.Focus()

    End Sub

    Private Sub Comb_billbasis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Comb_billbasis.KeyPress
        Blank(e)
        'If Asc(e.KeyChar) = 13 Then
        '    If Comb_billbasis.Text <> "" Then
        '        Comb_basedon.Focus()
        '    End If
        'End If
    End Sub

    Private Sub Comb_billbasis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Comb_billbasis.SelectedIndexChanged
        Chekbillingmonth.Enabled = True
        Chekbillingmonth.ClearSelected()
        chk_billingmonth.Items.Clear()
        For i = 0 To Chekbillingmonth.Items.Count - 1
            Chekbillingmonth.SetItemChecked(i, False)
        Next
        Try
            If Comb_billbasis.Text = "QUARTERLY" Then
                Chekbillingmonth.SetItemChecked((2), True)
                Chekbillingmonth.SetSelected(2, True)
                chk_billingmonth.Items.Add(Chekbillingmonth.SelectedItem)
                Chekbillingmonth.SetItemChecked((5), True)
                Chekbillingmonth.SetSelected(5, True)
                chk_billingmonth.Items.Add(Chekbillingmonth.SelectedItem)
                Chekbillingmonth.SetItemChecked((8), True)
                Chekbillingmonth.SetSelected(8, True)
                chk_billingmonth.Items.Add(Chekbillingmonth.SelectedItem)
                Chekbillingmonth.SetItemChecked((11), True)
                Chekbillingmonth.SetSelected(11, True)
                chk_billingmonth.Items.Add(Chekbillingmonth.SelectedItem)
                ' lbl_fromdate.Visible = False
                'lbl_todate.Visible = False
                'dtp_from.Visible = False
                'dtp_to.Visible = False
            ElseIf Comb_billbasis.Text = "HALF YEARLY" Then
                Chekbillingmonth.SetItemChecked((5), True)
                Chekbillingmonth.SetSelected(5, True)
                chk_billingmonth.Items.Add(Chekbillingmonth.SelectedItem)
                Chekbillingmonth.SetItemChecked((11), True)
                Chekbillingmonth.SetSelected(11, True)
                chk_billingmonth.Items.Add(Chekbillingmonth.SelectedItem)
                '  lbl_fromdate.Visible = False
                ' lbl_todate.Visible = False
                'dtp_from.Visible = False
                'dtp_to.Visible = False

            ElseIf Comb_billbasis.Text = "NONE" Then
                Chekbillingmonth.ClearSelected()
                ' lbl_fromdate.Visible = False
                'lbl_todate.Visible = False
                'dtp_from.Visible = False

                'dtp_to.Visible = False
            ElseIf Comb_billbasis.Text = "MONTHLY" Then
                For i = 0 To Chekbillingmonth.Items.Count - 1
                    Chekbillingmonth.SetItemChecked(i, True)
                    Chekbillingmonth.SetSelected(i, True)
                    chk_billingmonth.Items.Add(Chekbillingmonth.SelectedItem)
                Next
                'lbl_fromdate.Visible = False
                'lbl_todate.Visible = False
                'dtp_from.Visible = False
                'dtp_to.Visible = False
            ElseIf Comb_billbasis.Text = "PERIOD" Then
                'lbl_fromdate.Visible = True
                'lbl_todate.Visible = True
                'dtp_from.Visible = True
                'dtp_to.Visible = True
            Else
                'lbl_fromdate.Visible = False
                'lbl_todate.Visible = False
                'dtp_from.Visible = False
                'dtp_to.Visible = False
                Chekbillingmonth.SetItemChecked((11), True)
                Chekbillingmonth.SetSelected(11, True)
                chk_billingmonth.Items.Add(Chekbillingmonth.SelectedItem)
            End If
            Chekbillingmonth.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Comb_basedon_SelectedIndexChanged(sender As Object, e As EventArgs)
        If Comb_basedon.Text = "Personal Age Based" Then

        ElseIf Comb_basedon.Text = "Membership Age Based" Then

        Else

        End If
    End Sub

    Private Sub Comb_appliedon_Click(sender As Object, e As EventArgs) Handles Comb_appliedon.Click

    End Sub

    Private Sub Comb_appliedon_KeyDown(sender As Object, e As KeyEventArgs) Handles Comb_appliedon.KeyDown

        If Comb_appliedon.Text = "" Then
            CHARGEOCDE.Focus()
        End If

    End Sub

    Private Sub Comb_appliedon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Comb_appliedon.KeyPress
        'If Comb_appliedon.Text = " " Then
        CHARGEOCDE.Focus()
        ' End If
    End Sub

    Private Sub Comb_appliedon_KeyUp(sender As Object, e As KeyEventArgs) Handles Comb_appliedon.KeyUp

    End Sub

    Private Sub Comb_appliedon_Layout(sender As Object, e As LayoutEventArgs) Handles Comb_appliedon.Layout

    End Sub

    Private Sub Comb_appliedon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Comb_appliedon.SelectedIndexChanged

        ' Comb_billbasis.Focus()

    End Sub

    Private Sub Cmd_taxcodehelp_Click(sender As Object, e As EventArgs) Handles Cmd_taxcodehelp.Click
        Dim vform As New LIST_OPERATION1
        gSQLString = "select taxcode,taxpercentage,glaccountin from ACCOUNTSTAXMASTER"
        M_WhereCondition = " "
        vform.vCaption = "Taxcode Help"
        vform.Field = "taxcode,taxpercentage,glaccountin"

        vform.CMB_SRC_FIELDS.Select()
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            Txt_taxcode.Text = Trim(vform.keyfield & "")
            Txt_Percentage.Select()
            txtsubcode_validated1()
        End If
        vform.Close()
        vform = Nothing
        Cmd_add.Text = "Update[F7]"
    End Sub


    Private Sub Txt_Taxaccountin_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Taxaccountin.KeyDown
        Txt_taxcode_Validated(sender, e)
    End Sub

    Private Sub Txt_Taxaccountin_TextChanged(sender As Object, e As EventArgs) Handles Txt_Taxaccountin.TextChanged
        Txt_taxcode_Validated(sender, e)
    End Sub


    Private Sub Cmd_view_Click(sender As Object, e As EventArgs) Handles Cmd_view.Click
        Grp_Print.Visible = True
        'Cmd_Dos_Click(sender, e)
        '  Cmd_Dos_Click()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Grp_Print.Visible = False
        Txt_Subcode.Focus()
    End Sub
    Function basis()
        If Comb_billbasis.SelectedItem = "YEARLY" Or Comb_billbasis.SelectedItem = "QUARTERLY (For Month)" Then
            Bmonth = 3
            billingmonth = "|" & Bmonth & "|"
        ElseIf Comb_billbasis.SelectedItem = "HALF YEARLY" Then
            Bmonth = 9
            If Bmonth <= 6 Then
                billingmonth = "|" & Bmonth & "|" & (Bmonth + 6) & "|"
            Else
                billingmonth = "|" & Bmonth & "|" & (Bmonth - 6) & "|"
            End If
        ElseIf Comb_billbasis.SelectedItem = "QUARTERLY" Then
            If (Bmonth = 1 Or Bmonth = 4 Or Bmonth = 7 Or Bmonth = 10) Then
                Bmonth = 1
            ElseIf (Bmonth = 2 Or Bmonth = 5 Or Bmonth = 8 Or Bmonth = 11) Then
                Bmonth = 2
            ElseIf (Bmonth = 3 Or Bmonth = 6 Or Bmonth = 9 Or Bmonth = 12) Then
                Bmonth = 3
            End If
            Bmonth = 3
            billingmonth = Bmonth & "|" & (Bmonth + 3) & "|" & (Bmonth + 6) & "|" & (Bmonth + 9) & "|"
            'If gCompanyname = "" Then
            billingmonth = "|" & (Bmonth + 3) & "|" & (Bmonth + 6) & "|" & (Bmonth + 9) & "|" & (Bmonth) & "|"

        ElseIf Comb_billbasis.SelectedItem = "MONTHLY" Then
            billingmonth = "|" & "1" & "|" & "2" & "|" & "3" & "|" & "4" & "|" & "5" & "|" & "6" & "|" & "7" & "|" & "8" & "|" & "9" & "|" & "10" & "|" & "11" & "|" & "12" & "|"
        Else
            ' billingmonth = "N"
            'MsgBox("Enter Billing Month . . .")
            billingmonth = ""
        End If
    End Function

    Public Sub checkValidation()
        checkValid = True
        boolchk = False
        Call basis() '''-->CHECKING THE BILLING BASIS
        'If chk_Subscrption.Checked = True Then
       
        If Val(Txt_subamount.Text) <= 0 Then
            MessageBox.Show(" Total Field can't be blank ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Txt_subamount.Focus()
            checkValid = False
            Exit Sub
        End If
        'praba
        'If Val(lbl_freeze.Text) <> "" Then
        '    MessageBox.Show(" Void Record Cant be blank ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    checkValid = False
        '    Exit Sub
        'End If

        If lbl_freeze.Visible = True Then
            MessageBox.Show("This Record Already Void ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Error)
            checkValid = False
            Exit Sub
        End If

        If Com_subtypecode.Text = "" Then
            MessageBox.Show(" SubscriptionType can't be blank ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Com_subtypecode.Focus()
            checkValid = False
            Exit Sub
        End If
       
        If Comb_appliedon.Text = "" Then
            MessageBox.Show(" Applied on Membership can't be blank ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Comb_appliedon.Focus()
            checkValid = False
            Exit Sub
        End If
        If Txt_subamount.Text <= 0 Then
            MessageBox.Show("Amont Can't be Zero or Negitive Valur")
            Txt_subamount.Focus()
        End If


        If Mid(Cmd_add.Text, 1, 1) = "A" Then
            Dim SQLSTRING As String
            SQLSTRING = "SELECT SUBSCODE,SUBSDESC FROM SUBSCRIPTIONMAST"
            gconnection.getDataSet(SQLSTRING, "SUBSCRIPTIONMAST")
            If gdataset.Tables("SUBSCRIPTIONMAST").Rows.Count Then
                For i = 0 To gdataset.Tables("SUBSCRIPTIONMAST").Rows.Count - 1
                    If Trim(Txt_Subcode.Text) = gdataset.Tables("SUBSCRIPTIONMAST").Rows(i).Item("SUBSCODE") Then
                        MessageBox.Show("Specified SUBSCODE already available in database", "Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        Txt_Subcode.Focus()
                        checkValid = False
                        Exit Sub
                    End If
                    If Trim(Txt_desc.Text) = gdataset.Tables("SUBSCRIPTIONMAST").Rows(i).Item("SUBSDESC") Then
                        MessageBox.Show("Specified SUBSDESC already available in database", "Club", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        Txt_desc.Focus()
                        checkValid = False
                        Exit Sub
                    End If
                Next

            End If
        End If
        boolchk = True
    End Sub


    Private Sub Cmd_add_Click(sender As Object, e As EventArgs) Handles Cmd_add.Click
        Dim dates As String = "1900/JAN/01"
        Dim str, CHECKED As String
        Dim fdate, tdate As DateTime
        Try
            Call checkValidation()
            If checkValid = False Then Exit Sub
            If Comb_billbasis.Text = "PERIOD" Then
                ' fdate = Format(CDate(dtp_from.Text), "dd/MMM/yyyy")
            Else
                fdate = Format(CDate(dates), "dd/MMM/yyyy")
            End If
            If Comb_billbasis.Text = "PERIOD" Then
                'tdate = Format(CDate(dtp_to.Text), "dd/MMM/yyyy")
                ' & Trim(CHARGEDESC.Text) &
            Else
                tdate = Format(CDate(dates), "dd/MMM/yyyy")
            End If
            Dim CHARGEBASIS(3) As String
            ''--------PRABA FOR TEMP COMMENING
            'If Com_subtypecode.Text = "FAC" Then
            '    ' MessageBox.Show(LST_FACILITY.CheckedItems.Item(0))
            '    CHECKED = LST_FACILITY.CheckedItems.Item(0)
            '    CHARGEBASIS = CHECKED.Split("-")

            'Else
            '    CHARGEBASIS(0) = ""
            '    CHARGEBASIS(1) = ""
            'End If
            ''--------UP TO THIS



            If Cmd_add.Text = "Add[F7]" Then
                SqlString = "INSERT INTO  SubscriptionMast "
                SqlString = SqlString & "(subscode,subsdesc,type,billingbasis,billingmonth,total,CHARGECODE,CHGBASEDON,basedon,appliedon,facility_pos,FACILITY,AddUserid, AddDate,freeze, Membershipfromage,Membershiptoage,personalfromage,personaltoage)"
                'PRABA
                'SubscriptionYN, Membershipfromage,Membershiptoage,personalfromage,personaltoage,fromdate,todate,FACILITY_FLG,appliedon,basedon)"
                SqlString = SqlString & "VALUES ('" & Trim(Txt_Subcode.Text) & " ' , '"
                SqlString = SqlString & Trim(Txt_desc.Text) & "' , '" & Trim(Com_subtypecode.SelectedItem) & "' , '"
                SqlString = SqlString & Trim(Comb_billbasis.SelectedItem) & "' , '" & Trim(billingmonth) & " ' ,'" & Val(Txt_subamount.Text)
                SqlString = SqlString & "','" & Trim(CHARGEOCDE.Text) & "','" & Trim(CBO_FACILITY.SelectedItem) & "', '" & Trim(Comb_basedon.SelectedItem) & "','"
                SqlString = SqlString & Trim(Comb_appliedon.SelectedItem) & "','" & Trim(CHARGEBASIS(1)) & "','" & Trim(CHARGEBASIS(0)) & "','" & gUsername & "','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "','N', '" & Trim(Txt_Agefrom.Text) & "', '" & Trim(Txt_Ageto.Text) & "','" & Trim(Txt_from.Text) & "','" & Trim(Txt_to.Text) & "')"
                gconnection.dataOperation(1, SqlString, "SubscriptionMast")
                MessageBox.Show("Record saved  Successfully ", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cmd_Clear_Click(sender, e)
            ElseIf Cmd_add.Text = "Update[F7]" Then
                If Mid(Me.cmd_clear.Text, 1, 1) = "U" Then
                    'If Me.lbl_freeze.Visible = True Then
                    '    MsgBox(" The Frezzed Record Can Not Be Update", , "Club")
                    '    boolchk = False
                    'End If
                End If
                If Me.lbl_freeze.Visible = True Then
                    MsgBox(" The Frezzed Record Can Not Be Update", , "Club")
                    boolchk = False
                End If

                SqlString = "UPDATE  SubscriptionMast "
                SqlString = SqlString & " SET subsdesc='" & Trim(Txt_desc.Text) & "',type='" & Trim(Com_subtypecode.Text) & "',billingbasis= '" & Trim(Comb_billbasis.SelectedItem) & "',billingmonth='" & Trim(billingmonth) & "', total= '" & Val(Txt_subamount.Text) & "', CHARGECODE= '" & CHARGEOCDE.Text & "',Luxurytax= '" & Val(Txt_luxuryTax.Text) & "',facility_pos='" & CHARGEBASIS(1) & "' "
                SqlString = SqlString & ", facility='" & CHARGEBASIS(0) & "',COSTCENTER='" & Trim(Txt_Costcentre.Text) & "', AddUserid='" & Trim(gUsername) & "',AddDate='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "',"
                ' praba
                '"SubscriptionYN= '" & subscriptionys & "',"
                ' SqlString = SqlString & " Membershipfromage='" & Trim(Txt_from.Text) & "',Membershiptoage='" & Trim(Txt_to.Text) & "' ,personalfromage='" & Trim(Txt_Agefrom.Text) & "' ,personaltoage='" & Trim(Txt_Ageto.Text) & "' ,fromdate=Convert(datetime,'" & fdate & "',103) , todate=Convert(datetime,'" & tdate & "',103) , "

                If Com_subtypecode.Text = "FAC" Then
                    SqlString = SqlString & " FACILITY_FLG='F', "
                ElseIf Com_subtypecode.Text = "SPE" Then
                    SqlString = SqlString & " FACILITY_FLG='S',"
                ElseIf Com_subtypecode.Text = "MUC" Then
                    SqlString = SqlString & " FACILITY_FLG='M', "
                ElseIf Com_subtypecode.Text = "GEN" Then
                    SqlString = SqlString & " FACILITY_FLG='G', "
                Else
                    SqlString = SqlString & " FACILITY_FLG='OT', "
                End If

                If Comb_appliedon.Text = "Member" Then
                    SqlString = SqlString & " appliedon='Member',"
                ElseIf Comb_appliedon.Text = "Dependent" Then
                    SqlString = SqlString & " appliedon='Dependent',"
                End If
                'PRABA
                'If CBO_FACILITY.Text = "INDIVIDUAL" Then
                '    SqlString = SqlString & " CHGBASEDON='INDIVIDUAL',"
                'ElseIf CBO_FACILITY.Text = "FAMILY" Then
                '    SqlString = SqlString & " CHGBASEDON='FAMILY',"
                'End If
                '----
                If Comb_basedon.Text = "Consumption" Then
                    SqlString = SqlString & " basedon='Consumption'"
                ElseIf Comb_basedon.Text = "Facility" Then
                    SqlString = SqlString & " basedon='Facility'"
                ElseIf Comb_basedon.Text = "Member Category" Then
                    SqlString = SqlString & " basedon='Member Category'"
                ElseIf Comb_basedon.Text = "Personal Age Based" Then
                    SqlString = SqlString & " basedon='Personal Age Based'"
                ElseIf Comb_basedon.Text = "Membership Age Based" Then
                    SqlString = SqlString & " basedon='Membership Age Based'"
                Else
                    SqlString = SqlString & " basedon =''"
                End If

                SqlString = SqlString & " WHERE subscode = '" & Trim(Txt_Subcode.Text) & "'"
                gconnection.dataOperation(2, SqlString, "SubscriptionMast")
                MessageBox.Show("Record Updated Successfully ", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cmd_Clear_Click(sender, e)
                Cmd_add.Text = "Add[F7]"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Club")
            Exit Sub
        End Try
        Me.cmd_Clear_Click(sender, e)
        
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Lbl_Luxurytax.Click

    End Sub

    Private Sub Cmd_freeze_Click(sender As Object, e As EventArgs) Handles Cmd_freeze.Click
        Call checkValidation()
        If boolchk = False Then Exit Sub
        If lbl_freeze.Visible = True Then
            MessageBox.Show("Record already Freezed ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cmd_Clear_Click(sender, e)
        Else
            SqlString = "UPDATE  SubscriptionMast "
            SqlString = SqlString & " SET Freeze= 'Y',AddUserId='" & gUsername & " ', AddDate='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
            SqlString = SqlString & " WHERE subscode = '" & Txt_Subcode.Text & " '"
            gconnection.dataOperation(3, SqlString, "SubscriptionMast")
            ' MessageBox.Show("Record Freezed Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cmd_Clear_Click(sender, e)
            Cmd_add.Text = "Add[F7]"
        End If

        ' If lbl_freeze.Visible = True Then
        'If Mid(Me.Cmd_freeze.Text, 1, 1) = "V" Then
        '    SqlString = "UPDATE  SubscriptionMast "
        '    SqlString = SqlString & " SET Freeze= 'Y',AddUserId='" & gUsername & " ', AddDate='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
        '    SqlString = SqlString & " WHERE subscode = '" & Txt_Subcode.Text & " '"
        '    gconnection.dataOperation(3, SqlString, "SubscriptionMast")
        '    ' MessageBox.Show("Record Freezed Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Me.cmd_Clear_Click(sender, e)
        '    Cmd_add.Text = "Add[F7]"
        'Else
        '    SqlString = "UPDATE  SubscriptionMast "
        '    SqlString = SqlString & " SET Freeze= 'N',AddUserId='" & gUsername & " ', AddDate='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
        '    SqlString = SqlString & " WHERE subscode = '" & Txt_Subcode.Text & " '"
        '    gconnection.dataOperation(4, SqlString, "SubscriptionMast")
        '    'MessageBox.Show("Record Unfreezed Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Me.cmd_Clear_Click(sender, e)
        '    Cmd_add.Text = "Add[F7]"
        'End If
    End Sub
    Private Sub cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_clear.Click
        clearform(Me)
        chk_billingmonth.Items.Clear()
        For i = 0 To Chekbillingmonth.Items.Count - 1
            Chekbillingmonth.SetItemChecked(i, False)
        Next i
        Com_subtypecode.SelectedIndex = -1
        Comb_billbasis.SelectedIndex = -1
        Comb_appliedon.SelectedIndex = -1
        Comb_basedon.SelectedIndex = -1
        Chekbillingmonth.SelectedIndex = -1
        chk_billingmonth.SelectedIndex = -1
        Txt_Subcode.Enabled = True
        Com_subtypecode.Enabled = True
        Comb_billbasis.Enabled = True
        Txt_Subcode.Focus()
        lbl_freeze.Visible = False
        'praba
        Chekbillingmonth.Enabled = True
        Txt_Agefrom.Text = ""
        Txt_Ageto.Text = ""
        Txt_from.Text = ""
        Txt_to.Text = ""
        LBL_CHG.Visible = False
        LBL_APPLIEDFACILITY.Visible = False
        LST_FACILITY.Visible = False
        CBO_FACILITY.Visible = False
        Cmd_add.Text = "Add[F7]"

    End Sub

    Private Sub Txt_Subcode_Click(sender As Object, e As EventArgs) Handles Txt_Subcode.Click
        'Cmd_subhelp.Focus()
    End Sub

    Private Sub Txt_Subcode_Enter(sender As Object, e As EventArgs) Handles Txt_Subcode.Enter
        '  Cmd_subhelp.Focus()
    End Sub

    Private Sub Txt_Subcode_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Subcode.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    If Txt_Subcode.Text = "" Then
        '        Cmd_subhelp_Click(sender, e)
        '    Else
        '        Txt_desc.Focus()
        '    End If
        'ElseIf e.KeyCode = Keys.F4 Then
        '    Cmd_subhelp_Click(sender, e)
        'End If
        'Txt_taxcode.Text = Nothing
        'Txt_Percentage.Text = Nothing
        'Txt_Taxaccountin.Text = Nothing
        'Cmd_freeze.Text = "Void[F8]"

        If e.KeyCode = Keys.Enter Then
            If Txt_Subcode.Text = "" Then
                Call Cmd_subhelp_Click(sender, e)
            Else
                Txt_SubcodeFILL()
                Txt_desc.Focus()
            End If
        ElseIf e.KeyCode = Keys.F4 Then
            Cmd_subhelp_Click(sender, e)
        End If
        Txt_taxcode.Text = Nothing
        Txt_Percentage.Text = Nothing
        Txt_Taxaccountin.Text = Nothing
        Cmd_freeze.Text = "Void[F8]"
    End Sub

    Private Sub Txt_Subcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Subcode.KeyPress

    End Sub

    Private Sub Txt_Subcode_TextChanged(sender As Object, e As EventArgs) Handles Txt_Subcode.TextChanged

    End Sub
    Private Sub txtsubcode_validated()
        Dim Sreader As New DataTable
        Dim ssql, str, str1, facility, facilitydesc As String
        Dim i As Integer = 0
        Dim J As Integer = 0
        'ssql = " Select ISNULL(subsdesc,'') AS subsdesc , ISNULL(type,'') AS TYPE, ISNULL(BillingBasis,'') AS BILLINGBASIS,ISNULL(total,0) AS TOTAL,ISNULL(Instalment,0) AS INSTALMENT,ISNULL(Percentage,0) AS PERCENTAGE,ISNULL(SubsAcctIn,'') AS SUBSACCTIN,ISNULL(subsacctindesc,'')AS subsacctindesc,ISNULL(taxcode,'')AS TAX,ISNULL(TAXACCIN,'')AS TAXACCIN,ISNULL(TAXTOTAL,0)AS TAXAMT,ISNULL(SubscriptionYN,'') AS SubscriptionYN,ISNULL(billingmonth,'') AS BILLINGMONTH,ISNULL(Freeze,'N') AS FREEZE From SubscriptionMast Where subscode='" & Me.txt_BillheadCode.Text & "'"

        ssql = " Select ISNULL(subsdesc,'') AS subsdesc , ISNULL(type,'') AS TYPE, ISNULL(ADDDATE,'') AS ADDDATE,ISNULL(BillingBasis,'') AS BILLINGBASIS,ISNULL(total,0) AS TOTAL,ISNULL(Instalment,0) AS INSTALMENT,ISNULL(Percentage,0) AS Percentage,ISNULL(SubsAcctIn,'') AS SUBSACCTIN,ISNULL(SIDELEDGERCODE,'') AS SIDELEDGERCODE,ISNULL(SIDELEDGERDESC,'') AS SIDELEDGERDESC,ISNULL(subsacctindesc,'')AS subsacctindesc,ISNULL(taxcode,'')AS taxcode,ISNULL(TAXACCIN,'')AS TAXACCIN,ISNULL(TAXTOTAL,0)AS TAXTOTAL,ISNULL(SubscriptionYN,'') AS SubscriptionYN,ISNULL(billingmonth,'') AS BILLINGMONTH,ISNULL(Freeze,'N') AS FREEZE,ISNULL(FACILITY_FLG,'') AS FACILITY_FLG ,ISNULL(APPLIEDON,'') AS APPLIEDON,ISNULL(BASEDON,'') AS BASEDON,ISNULL(Membershipfromage,'') AS Membershipfromage,ISNULL(Membershiptoage,'') AS Membershiptoage,ISNULL(personalfromage,'') AS personalfromage,ISNULL(personaltoage,'') AS personaltoage,ISNULL(Luxurytax,0)AS Luxurytax,fromdate,ISNULL(CHARGECODE,'')AS CHARGECODE,todate,isnull(facility,'') as facility,isnull(facility_pos,'') as facility_pos From SubscriptionMast Where subscode='" & Me.Txt_Subcode.Text & "'"
        Sreader = gconnection.GetValues(ssql)
        If Sreader.Rows.Count > 0 Then
            Me.Txt_taxcode.Enabled = False
            Me.txt_subdesc.Enabled = False
            Me.Txt_desc.Text = Sreader.Rows(0).Item("subsdesc")

            Com_subtypecode.Text = Sreader.Rows(0).Item("type")
            Comb_appliedon.Text = Sreader.Rows(0).Item("APPLIEDON")
            Comb_basedon.Text = Sreader.Rows(0).Item("BASEDON")
            Comb_billbasis.Text = Sreader.Rows(0).Item("BillingBasis")
            Txt_subamount.Text = Format(Sreader.Rows(0).Item("total"), "0.00")
            Txt_luxuryTax.Text = Format(Sreader.Rows(0).Item("Luxurytax"), "0.00")
            Me.Txt_taxcode.Text = Sreader.Rows(0).Item("TaxCode")
            Me.Txt_Taxaccountin.Text = Sreader.Rows(0).Item("TAXACCIN")
            Me.Txt_Taxamount.Text = Sreader.Rows(0).Item("TAXTOTAL")
            Me.Txt_Percentage.Text = Sreader.Rows(0).Item("Percentage")
            Me.Txt_from.Text = Sreader.Rows(0).Item("Membershipfromage")
            Me.Txt_to.Text = Sreader.Rows(0).Item("Membershiptoage")
            Me.Txt_Agefrom.Text = Sreader.Rows(0).Item("personalfromage")
            Me.Txt_Ageto.Text = Sreader.Rows(0).Item("personaltoage")
            Me.CHARGEOCDE.Text = Sreader.Rows(0).Item("CHARGECODE")
            facility = Sreader.Rows(0).Item("FACILITY")
            facilitydesc = Sreader.Rows(0).Item("FACILITY_POS")
            If Sreader.Rows(0).Item("BILLINGBASIS") = "PERIOD" Then
                'praba
                'lbl_fromdate.Visible = True
                'lbl_todate.Visible = True
                ' dtp_from.Visible = True
                '  dtp_to.Visible = True
                '  Me.dtp_from.Value = Sreader.Rows(0).Item("fromdate")
                ' Me.dtp_to.Value = Sreader.Rows(0).Item("todate")
            Else
                ' lbl_fromdate.Visible = False
                '  lbl_todate.Visible = False
                '  dtp_from.Visible = False
                '  dtp_to.Visible = False
            End If
            'praba


            If Sreader.Rows(0).Item("SubscriptionYN") = "Y" Then
                ' chk_Subscrption.Checked = True
                'chk_Subscrption.BackColor = Color.Cyan
            Else
                ' chk_Subscrption.Checked = False
                ' chk_Subscrption.BackColor = Color.Silver
            End If
            str = ""
            str1 = ""
            str = Trim(CStr(Sreader.Rows(0).Item("billingmonth")))
            'MODIFIED  by srinivas
            Me.Cmd_add.Text = "Update[F7]"
            Dim RetriveMonth() As String
            RetriveMonth = str.Split("|")
            '----------------------------------------------
            Chekbillingmonth.Enabled = True
            Chekbillingmonth.ClearSelected()
            chk_billingmonth.Items.Clear()
            For i = 0 To Chekbillingmonth.Items.Count - 1
                Chekbillingmonth.SetItemChecked(i, False)
            Next
            Try
                If Comb_billbasis.Text = "QUARTERLY" Then
                    Chekbillingmonth.SetItemChecked((3), True)
                    Chekbillingmonth.SetSelected(0, True)
                    chk_billingmonth.Items.Add(chk_billingmonth.SelectedItem)
                    Chekbillingmonth.SetItemChecked((7), True)
                    Chekbillingmonth.SetSelected(3, True)
                    chk_billingmonth.Items.Add(Chekbillingmonth.SelectedItem)
                    Chekbillingmonth.SetItemChecked((10), True)
                    Chekbillingmonth.SetSelected(6, True)
                    chk_billingmonth.Items.Add(Chekbillingmonth.SelectedItem)
                    Chekbillingmonth.SetItemChecked((1), True)
                    Chekbillingmonth.SetSelected(9, True)
                    chk_billingmonth.Items.Add(Chekbillingmonth.SelectedItem)
                    Chekbillingmonth.SetItemChecked((0), True)
                    Chekbillingmonth.SetSelected(0, True)
                    chk_billingmonth.Items.Add(Chekbillingmonth.SelectedItem)
                    Chekbillingmonth.SetItemChecked((2), True)
                    Chekbillingmonth.SetSelected(2, True)
                    chk_billingmonth.Items.Add(Chekbillingmonth.SelectedItem)
                    Chekbillingmonth.SetItemChecked((5), True)
                    Chekbillingmonth.SetSelected(5, True)
                    chk_billingmonth.Items.Add(Chekbillingmonth.SelectedItem)
                    Chekbillingmonth.SetItemChecked((8), True)
                    Chekbillingmonth.SetSelected(8, True)
                    chk_billingmonth.Items.Add(Chekbillingmonth.SelectedItem)

                ElseIf Comb_billbasis.Text = "HALF YEARLY" Then
                    Chekbillingmonth.SetItemChecked((5), True)
                    Chekbillingmonth.SetSelected(5, True)
                    chk_billingmonth.Items.Add(Chekbillingmonth.SelectedItem)
                    Chekbillingmonth.SetItemChecked((11), True)
                    Chekbillingmonth.SetSelected(11, True)
                    chk_billingmonth.Items.Add(Chekbillingmonth.SelectedItem)
                ElseIf Comb_billbasis.Text = "NONE" Then
                    Chekbillingmonth.ClearSelected()
                    Chekbillingmonth.Enabled = False
                ElseIf Comb_billbasis.Text = "MONTHLY" Then
                    For i = 0 To Chekbillingmonth.Items.Count - 1
                        Chekbillingmonth.SetItemChecked(i, True)
                        Chekbillingmonth.SetSelected(i, True)
                        chk_billingmonth.Items.Add(Chekbillingmonth.SelectedItem)
                    Next
                Else
                    Chekbillingmonth.SetItemChecked((11), True)
                    Chekbillingmonth.SetSelected(11, True)
                    chk_billingmonth.Items.Add(Chekbillingmonth.SelectedItem)
                End If
                Chekbillingmonth.Enabled = False
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            'praba
            If RetriveMonth(0) <> "" And RetriveMonth(0) = "N" Then
                For i = 0 To RetriveMonth.Length - 2
                    Chekbillingmonth.SetItemChecked(CInt(RetriveMonth(i)) - 1, True)
                    Chekbillingmonth.SetSelected(CInt(RetriveMonth(i)) - 1, True)
                    Chekbillingmonth.SetItemChecked((Int32.Parse(RetriveMonth(i)) - 1), True)
                    Chekbillingmonth.SetSelected((Int32.Parse(RetriveMonth(i)) - 1), True)
                Next
                If RetriveMonth.Length = 1 Then
                    Chekbillingmonth.SetItemChecked((Int32.Parse(RetriveMonth(0)) - 1), True)
                    Chekbillingmonth.SetSelected((Int32.Parse(RetriveMonth(0)) - 1), True)
                End If
            End If

            'praba
            Dim I1 As Integer
            'praba
         
            SqlString = "SELECT Code,NAME FROM Tbl_SubscriptionType_Master where Code='" & Trim(Com_subtypecode.Text) & "'and freeze<>'Y'  "
            gconnection.getDataSet(SqlString, "MemMst")
            If gdataset.Tables("MemMst").Rows.Count > 0 Then
                txt_subdesc.Text = gdataset.Tables("MemMst").Rows(0).Item("NAME")
            End If


            If Sreader.Rows(0).Item("Freeze") = "Y" Then
                Me.lbl_freeze.Visible = True
                Me.lbl_freeze.Text = Me.lbl_freeze.Text & Format(Sreader.Rows(0).Item("AddDate"), "dd-MMM-yyyy")
                Me.Cmd_freeze.Text = "Void[F8]"
            Else
                Me.lbl_freeze.Visible = False
                Me.lbl_freeze.Text = "Record Freezed  On "
                Me.Cmd_freeze.Text = "Void[F8]"
            End If

        Else
            Me.Txt_Subcode.Enabled = True
            Me.Txt_desc.Text = ""
            Me.lbl_freeze.Visible = False
            Me.lbl_freeze.Text = "Record Freezed  On "
            Me.Cmd_add.Text = "Add[F7]"
        End If
        If gUserCategory <> "S" Then
            ' Call GetRights()
        End If

    End Sub



    Private Sub txtsubcode_validated1()
        Dim Sreader As New DataTable
        Dim ssql As String
        ssql = " SELECT ISNULL(TAXCODE,'')AS TAXCODE,ISNULL(GLACCOUNTIN,'')AS ACCOUNTIN,ISNULL(TAXPERCENTAGE,0)AS TAXPERCENTAGE From ACCOUNTSTAXMASTER Where TAXCODE='" & keyfield & "'"
        Sreader = gconnection.GetValues(ssql)
        If Sreader.Rows.Count > 0 Then


            Me.Txt_taxcode.Text = Sreader.Rows(0).Item("TAXCODE")
            Me.Txt_Taxaccountin.Text = Sreader.Rows(0).Item("ACCOUNTIN")
            Me.Txt_Percentage.Text = Sreader.Rows(0).Item("TAXPERCENTAGE")
        End If

    End Sub

    Private Sub Com_subtypecode_SelectedValueChanged(sender As Object, e As EventArgs) Handles Com_subtypecode.SelectedValueChanged

    End Sub

    Private Sub Comb_basedon_Enter(sender As Object, e As EventArgs) Handles Comb_basedon.Enter

    End Sub

    Private Sub Comb_basedon_KeyDown(sender As Object, e As KeyEventArgs) Handles Comb_basedon.KeyDown
        If e.KeyCode = Keys.Enter Then
            Comb_appliedon.Focus()
        End If
    End Sub

    Private Sub Comb_basedon_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles Comb_basedon.SelectedIndexChanged
        If Comb_basedon.Text = "Personal Age Based" Then
            lbl_fromage.Text = "From Age"
            lbl_fromage.Visible = True
            lbl_toage.Text = "To Age"
            lbl_toage.Visible = True
            Txt_from.Visible = False
            Txt_to.Visible = False
            Txt_Agefrom.Visible = True
            Txt_Ageto.Visible = True
        ElseIf Comb_basedon.Text = "Membership Age Based" Then
            lbl_fromage.Text = "Membership From"
            lbl_fromage.Visible = True
            lbl_toage.Text = "Membership To"
            lbl_toage.Visible = True
            Txt_from.Visible = True
            Txt_to.Visible = True
            Txt_Agefrom.Visible = False
            Txt_Ageto.Visible = False
        Else
            lbl_fromage.Visible = False
            lbl_toage.Visible = False
            Txt_from.Visible = False
            Txt_to.Visible = False
            Txt_Agefrom.Visible = False
            Txt_Ageto.Visible = False
        End If
    End Sub

    Private Sub Txt_taxcode_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_taxcode.KeyDown

        If e.KeyCode = Keys.Enter Then
            If Txt_taxcode.Text = "" Then
                Cmd_taxcodehelp_Click(sender, e)
            Else
                Txt_Percentage.Focus()
            End If
        End If


    End Sub

    Private Sub Txt_taxcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_taxcode.KeyPress
        Txt_taxcode_Validated(sender, e)
    End Sub

    Private Sub Txt_taxcode_TextChanged(sender As Object, e As EventArgs) Handles Txt_taxcode.TextChanged
        If Txt_taxcode.Text <> "" Then
            Txt_taxcode.ReadOnly = True
            Txt_Taxaccountin.ReadOnly = True
        End If
    End Sub

    Private Sub CBO_FACILITY_KeyDown(sender As Object, e As KeyEventArgs) Handles CBO_FACILITY.KeyDown
        Txt_taxcode.Visible = True
    End Sub

    Private Sub CBO_FACILITY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CBO_FACILITY.KeyPress
        Lbl_Taxcode.Visible = True
        Lblpercentage.Visible = True
        Txt_Percentage.Visible = True
        Txt_taxcode.Visible = True
        Cmd_taxcodehelp.Visible = True
    End Sub

    Private Sub CBO_FACILITY_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_FACILITY.SelectedIndexChanged

    End Sub

    Private Sub Txt_taxcode_Validated(sender As Object, e As EventArgs) Handles Txt_taxcode.Validated

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Txt_Agefrom.TextChanged

    End Sub


    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Txt_Ageto.TextChanged

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lbl_fromage.Click

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles Txt_to.TextChanged

    End Sub

    Private Sub chk_billingmonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chk_billingmonth.SelectedIndexChanged

    End Sub

    Private Sub Txt_desc_Click(sender As Object, e As EventArgs) Handles Txt_desc.Click

    End Sub

    Private Sub Txt_desc_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_desc.KeyDown
        If e.KeyCode = Keys.Enter Then
            'If chk_Subscrption.Checked = False Then
            '    txt_Total.Focus()
            'Else
            Com_subtypecode.Focus()
            'End If
        End If
    End Sub

    Private Sub Txt_desc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_desc.KeyPress
        getCharater(e)
    End Sub

    Private Sub Txt_desc_TextChanged(sender As Object, e As EventArgs) Handles Txt_desc.TextChanged

    End Sub

    Private Sub Cmd_Dos_Click(sender As Object, e As EventArgs) Handles Cmd_Dos.Click
        Dim reportdesign As New ReportDesigner
        Gheader = " MASTER VIEW "
        If Txt_Subcode.Text.Length > 0 Then
            tables = " FROM SubscriptionMast where subsCode = '" & Trim(Txt_Subcode.Text) & "'"
        Else
            tables = " FROM SubscriptionMast"
        End If
        reportdesign.DataGridView1.ColumnCount = 2
        reportdesign.DataGridView1.Columns(0).Name = "Column Name"
        reportdesign.DataGridView1.Columns(0).Width = 380
        reportdesign.DataGridView1.Columns(1).Name = "Size"
        reportdesign.DataGridView1.Columns(1).Width = 100


        Dim row As String() = New String() {"SUBSCODE", "10"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"SUBSDESC", "35"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"TYPE", "35"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"BILLINGBASIS", "35"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"APPLIEDON", "35"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"CHARGECODE", "35"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"TOTAL", "35"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"ADDUSERID", "35"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"ADDDATE", "35"}
        reportdesign.DataGridView1.Rows.Add(row)


        row = New String() {"FREEZE", "10"}
        reportdesign.DataGridView1.Rows.Add(row)

        Dim chk As New DataGridViewCheckBoxColumn()
        reportdesign.DataGridView1.Columns.Insert(0, chk)
        chk.HeaderText = "Check"
        chk.Name = "chk"

        reportdesign.ShowDialog(Me)
    End Sub

    Private Sub Cmd_Windows_Click(sender As Object, e As EventArgs) Handles Cmd_Windows.Click
        Dim txtobj1 As TextObject
        Dim Viewer As New REPORTVIEWER
        Dim r As New Cry_SUBSCRIPTIONMAST_master
        SqlString = "select * from VIEW_SUBSCRIPTIONMAST  "
        If Txt_Subcode.Text = "" Then
            SqlString = SqlString & ""
        Else
            SqlString = SqlString & " where SUBSCODE = '" & Txt_Subcode.Text & "' "
        End If
        gconnection.getDataSet(SqlString, "VIEW_SUBSCRIPTIONMAST")
        If gdataset.Tables("VIEW_SUBSCRIPTIONMAST").Rows.Count > 0 Then
            Call Viewer.GetDetails(SqlString, "VIEW_SUBSCRIPTIONMAST", r)
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
            txtobj1 = r.ReportDefinition.ReportObjects("Text23")
            txtobj1.Text = UCase(gCompanyAddress(4))
            txtobj1 = r.ReportDefinition.ReportObjects("Text24")
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

    Private Sub txt_subdesc_Click(sender As Object, e As EventArgs) Handles txt_subdesc.Click

    End Sub

    Private Sub txt_subdesc_Enter(sender As Object, e As EventArgs) Handles txt_subdesc.Enter

    End Sub

    Private Sub txt_subdesc_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_subdesc.KeyDown

    End Sub

    Private Sub txt_subdesc_TextChanged(sender As Object, e As EventArgs) Handles txt_subdesc.TextChanged
        If Mid(Com_subtypecode.Text, 1, 4) = "FAC" Then
            '  txt_subdesc
            'LBL_CHG.Visible = True
            'LBL_APPLIEDFACILITY.Visible = True
            'LST_FACILITY.Visible = True
            'CBO_FACILITY.Visible = True
            Lbl_Basedon.Visible = True

            Comb_basedon.Visible = True
        Else
            LBL_CHG.Visible = False
            LBL_APPLIEDFACILITY.Visible = False
            LST_FACILITY.Visible = False
            Lbl_Basedon.Visible = False
            Comb_basedon.Visible = False
            CBO_FACILITY.Visible = False
            lbl_fromage.Visible = False
            Txt_Agefrom.Visible = False
            Txt_Ageto.Visible = False
            Txt_Agefrom.Visible = False
            Txt_Ageto.Visible = False
        End If
    End Sub

    Private Sub Com_subtypecode_TextChanged(sender As Object, e As EventArgs) Handles Com_subtypecode.TextChanged

    End Sub
    Public Function getDataSet(ByVal strSQL As String, ByVal Tabname As String)
        Try
            gconnection.openConnection()
            Dim dt As New DataTable
            dt.Rows.Clear()
            If gdataset.Tables.Contains(Tabname) = True Then
                gdataset.Tables.Remove(Tabname)
            End If
            gadapter = New SqlDataAdapter(strSQL, gconnection.Myconn)
            gadapter.Fill(dt)
            dt.TableName = Tabname
            gdataset.Tables.Add(dt)
        Catch ex As Exception
            MsgBox("Error in Retrieving Data " & ex.Message, MsgBoxStyle.Information, Application.ProductName)
        Finally
            gconnection.closeConnection()
        End Try
    End Function

    Private Sub Cmd_Authantication_Click(sender As Object, e As EventArgs) Handles Cmd_Authantication.Click
        brows = True

        Dim VIEW1 As New VIEWHDR
        VIEW1.Show()
        VIEW1.DTGRDHDR.DataSource = Nothing
        VIEW1.DTGRDHDR.Rows.Clear()
        Dim STRQUERY As String
        STRQUERY = "SELECT * FROM SubscriptionMast"
        STRQUERY = "SELECT isnull(subscode,'')as Subscode,isnull(Subsdesc,'') as Subsdesc, type,billingbasis,billingmonth,chargecode,isnull(total,0)as Total,isnull(freeze,'')as Freeze FROM SubscriptionMast"
        gconnection.getDataSet(STRQUERY, "authorize")

        Call VIEW1.LOADGRID(gdataset.Tables("authorize"), True, gcompanyname, "SELECT * FROM SubscriptionMast", "Code", 1, Me.Txt_Subcode)
        'VIEW1.Hide()
        'VIEW1.ShowDialog(Me)
        'If Trim(keyfield & "") <> "" Then
        '    Txt_Subcode.Text = Trim(keyfield & "")
        '    Txt_desc.Select()
        '    Me.txt_feeldFILL()
        '    '  DDGRD1.Select()
        '    Cmd_add.Text = "Update [F7]"
        'End If
        'gconnection.closeConnection()
    End Sub

    Private Sub txt_feeldFILL()
        Try
            Dim I, J As Integer
            Dim MEMBERTYPE As DataTable
            Dim Sqlstr As String
            If Txt_Subcode.Text <> "" Then
                Sqlstr = "select subscode,subsdesc from SubscriptionMast WHERE subscode='" & Trim(Txt_Subcode.Text) & "'"
                gconnection.getDataSet(Sqlstr, "SubscriptionMast")
                If gdataset.Tables("SubscriptionMast").Rows.Count > 0 Then
                    Txt_Subcode.ReadOnly = True
                    Txt_desc.Text = gdataset.Tables("SubscriptionMast").Rows(0).Item("subscode")

                    Me.lbl_freeze.Visible = True
                    Me.lbl_freeze.Text = Me.lbl_freeze.Text & Format(gdataset.Tables("SubscriptionMast").Rows(0).Item("voiddate"), "dd-MMM-yyyy")
                    Me.lbl_freeze.Text = "Void[F8]"
                Else
                    Me.lbl_freeze.Visible = False
                    Me.lbl_freeze.Text = "Record Voided  On "
                    Me.lbl_freeze.Text = "Void[F8]"
                End If
                Me.Cmd_add.Text = "Update[F7]"
            Else
                Txt_Subcode.Text = ""
            End If

        Catch ex As Exception
            '  MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Txt_desc_Validated(sender As Object, e As EventArgs) Handles Txt_desc.Validated

    End Sub

    Private Sub Txt_desc_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Txt_desc.Validating

    End Sub

    Private Sub Cmd_taxcodehelp_KeyDown(sender As Object, e As KeyEventArgs) Handles Cmd_taxcodehelp.KeyDown

    End Sub

    Private Sub Cmd_taxcodehelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cmd_taxcodehelp.KeyPress

    End Sub

    Private Sub Comb_appliedon_SelectedValueChanged(sender As Object, e As EventArgs) Handles Comb_appliedon.SelectedValueChanged

    End Sub

    Private Sub Cmd_subhelp_Click(sender As Object, e As EventArgs) Handles Cmd_subhelp.Click
        Dim vform As New LIST_OPERATION1
        gSQLString = "Select SUBSCODE,SUBSDESC,billingbasis,total from subscriptionmast"
        M_WhereCondition = " "
        vform.vCaption = "subscriptionmast Help"
        vform.Field = "Subscode,Subsdesc"

        vform.CMB_SRC_FIELDS.Select()
        vform.ShowDialog(Me)
        'PRABA
        If Trim(vform.keyfield & "") <> "" Then
            Txt_Subcode.Text = Trim(vform.keyfield & "")
            Txt_desc.Select()
            Txt_SubcodeFILL()
        End If
        vform.Close()
        vform = Nothing
        Me.Cmd_freeze.Text = "Void[F8]"
    End Sub
    Private Sub Txt_SubcodeFILL()
        Cmd_add.Text = "Update[F7]"
        'praba
        Dim Sreader As New DataTable
        Dim ssql, str, str1, facility, facilitydesc As String
        Dim i As Integer = 0
        Dim J As Integer = 0
        'ssql = " Select ISNULL(subsdesc,'') AS subsdesc , ISNULL(type,'') AS TYPE, ISNULL(BillingBasis,'') AS BILLINGBASIS,ISNULL(total,0) AS TOTAL,ISNULL(Instalment,0) AS INSTALMENT,ISNULL(Percentage,0) AS PERCENTAGE,ISNULL(SubsAcctIn,'') AS SUBSACCTIN,ISNULL(subsacctindesc,'')AS subsacctindesc,ISNULL(taxcode,'')AS TAX,ISNULL(TAXACCIN,'')AS TAXACCIN,ISNULL(TAXTOTAL,0)AS TAXAMT,ISNULL(SubscriptionYN,'') AS SubscriptionYN,ISNULL(billingmonth,'') AS BILLINGMONTH,ISNULL(Freeze,'N') AS FREEZE From SubscriptionMast Where subscode='" & Me.txt_BillheadCode.Text & "'"
        ssql = " Select ISNULL(subsdesc,'') AS subsdesc , ISNULL(type,'') AS TYPE, ISNULL(ADDDATE,'') AS ADDDATE,ISNULL(BillingBasis,'') AS BILLINGBASIS,ISNULL(total,0) AS TOTAL,ISNULL(Instalment,0) AS INSTALMENT,ISNULL(Percentage,0) AS Percentage,ISNULL(SubsAcctIn,'') AS SUBSACCTIN,ISNULL(SIDELEDGERCODE,'') AS SIDELEDGERCODE,ISNULL(SIDELEDGERDESC,'') AS SIDELEDGERDESC,ISNULL(subsacctindesc,'')AS subsacctindesc,ISNULL(taxcode,'')AS taxcode,ISNULL(TAXACCIN,'')AS TAXACCIN,ISNULL(TAXTOTAL,0)AS TAXTOTAL,ISNULL(SubscriptionYN,'') AS SubscriptionYN,ISNULL(billingmonth,'') AS BILLINGMONTH,ISNULL(Freeze,'N') AS FREEZE,ISNULL(FACILITY_FLG,'') AS FACILITY_FLG ,ISNULL(APPLIEDON,'') AS APPLIEDON,ISNULL(BASEDON,'') AS BASEDON,ISNULL(Membershipfromage,'') AS Membershipfromage,ISNULL(Membershiptoage,'') AS Membershiptoage,ISNULL(personalfromage,'') AS personalfromage,ISNULL(personaltoage,'') AS personaltoage,ISNULL(Luxurytax,0)AS Luxurytax,fromdate,todate,ISNULL(CHARGECODE,'')AS CHARGECODE,ISNULL(FACILITY,'') AS FACILITY,ISNULL(FACILITY_POS,'') AS FACILITY_POS,ISNULL(CHGBASEDON,'')AS CHGBASEDON,ISNULL(COSTCENTER,'')AS COSTCENTER From SubscriptionMast Where subscode='" & Me.Txt_Subcode.Text & "'"
        Sreader = gconnection.GetValues(ssql)
        If Sreader.Rows.Count > 0 Then
            Me.Txt_Subcode.Enabled = False
            Me.txt_subdesc.Enabled = False
            Me.Txt_desc.Text = Sreader.Rows(0).Item("subsdesc")

            Com_subtypecode.Text = Sreader.Rows(0).Item("type")
            Comb_appliedon.Text = Sreader.Rows(0).Item("APPLIEDON")
            Comb_basedon.Text = Sreader.Rows(0).Item("BASEDON")
            Comb_billbasis.Text = Sreader.Rows(0).Item("BillingBasis")
            Txt_subamount.Text = Format(Sreader.Rows(0).Item("total"), "0.00")
            Txt_luxuryTax.Text = Format(Sreader.Rows(0).Item("Luxurytax"), "0.00")
            Me.Txt_taxcode.Text = Sreader.Rows(0).Item("TaxCode")
            Me.Txt_Taxaccountin.Text = Sreader.Rows(0).Item("TAXACCIN")
            Me.Txt_Taxamount.Text = Sreader.Rows(0).Item("TAXTOTAL")
            Me.Txt_Percentage.Text = Sreader.Rows(0).Item("Percentage")
            Me.Txt_from.Text = Sreader.Rows(0).Item("Membershipfromage")
            Me.Txt_to.Text = Sreader.Rows(0).Item("Membershiptoage")
            Me.Txt_Agefrom.Text = Sreader.Rows(0).Item("personalfromage")
            Me.Txt_Ageto.Text = Sreader.Rows(0).Item("personaltoage")
            Me.CHARGEOCDE.Text = Sreader.Rows(0).Item("CHARGECODE")
            Me.Txt_Costcentre.Text = Sreader.Rows(0).Item("COSTCENTER")
            facility = Sreader.Rows(0).Item("facility")
            facilitydesc = Sreader.Rows(0).Item("facility_pos")
            CBO_FACILITY.Text = Sreader.Rows(0).Item("CHGBASEDON")
            If Sreader.Rows(0).Item("BILLINGBASIS") = "PERIOD" Then


            Else

            End If
            Dim facility1() As String

            For I1 = 0 To LST_FACILITY.Items.Count - 1

                'MessageBox.Show(LST_FACILITY.GetItemText(LST_FACILITY.Items(I1)))
                facilitydesc = LST_FACILITY.GetItemText(LST_FACILITY.Items(I1))
                facility1 = facilitydesc.Split("-")
                'MessageBox.Show(facility1(0))
                If facility1(0) = facility Then
                    LST_FACILITY.SetItemChecked(I1, True)
                End If

            Next

            If Sreader.Rows(0).Item("SubscriptionYN") = "Y" Then
                'chk_Subscrption.Checked = True
                'chk_Subscrption.BackColor = Color.Cyan
            Else
                'chk_Subscrption.Checked = False
                'chk_Subscrption.BackColor = Color.Silver
            End If
            str = ""
            str1 = ""
            str = Trim(CStr(Sreader.Rows(0).Item("billingmonth")))

            Me.Cmd_add.Text = "Update[F7]"
            Dim RetriveMonth() As String
            RetriveMonth = str.Split("|")
            '----------------------------------------------
            Chekbillingmonth.Enabled = True
            Chekbillingmonth.ClearSelected()
            chk_billingmonth.Items.Clear()
            For i = 0 To Chekbillingmonth.Items.Count - 1
                Chekbillingmonth.SetItemChecked(i, False)
            Next
            Try
                If Comb_billbasis.Text = "QUARTERLY" Then
                    Chekbillingmonth.SetItemChecked((2), True)
                    Chekbillingmonth.SetSelected(2, True)
                    chk_billingmonth.Items.Add(Chekbillingmonth.SelectedItem)
                    Chekbillingmonth.SetItemChecked((5), True)
                    Chekbillingmonth.SetSelected(5, True)
                    chk_billingmonth.Items.Add(Chekbillingmonth.SelectedItem)
                    Chekbillingmonth.SetItemChecked((8), True)
                    Chekbillingmonth.SetSelected(8, True)
                    chk_billingmonth.Items.Add(Chekbillingmonth.SelectedItem)
                    Chekbillingmonth.SetItemChecked((11), True)
                    Chekbillingmonth.SetSelected(11, True)
                    chk_billingmonth.Items.Add(Chekbillingmonth.SelectedItem)

                ElseIf Comb_billbasis.Text = "HALF YEARLY" Then
                    Chekbillingmonth.SetItemChecked((5), True)
                    Chekbillingmonth.SetSelected(5, True)
                    chk_billingmonth.Items.Add(Chekbillingmonth.SelectedItem)
                    Chekbillingmonth.SetItemChecked((11), True)
                    Chekbillingmonth.SetSelected(11, True)
                    chk_billingmonth.Items.Add(Chekbillingmonth.SelectedItem)
                ElseIf Comb_billbasis.Text = "NONE" Then
                    Chekbillingmonth.ClearSelected()
                    '                chkList_BillingMonth.Enabled = False
                ElseIf Comb_billbasis.Text = "MONTHLY" Then
                    For i = 0 To Chekbillingmonth.Items.Count - 1
                        Chekbillingmonth.SetItemChecked(i, True)
                        Chekbillingmonth.SetSelected(i, True)
                        chk_billingmonth.Items.Add(Chekbillingmonth.SelectedItem)
                    Next
                Else
                    Chekbillingmonth.SetItemChecked((11), True)
                    Chekbillingmonth.SetSelected(11, True)
                    chk_billingmonth.Items.Add(Chekbillingmonth.SelectedItem)
                End If
                chk_billingmonth.Enabled = False
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            SqlString = "SELECT Code,NAME FROM Tbl_SubscriptionType_Master where Code='" & Trim(Com_subtypecode.Text) & "'and freeze<>'Y'  "
            gconnection.getDataSet(SqlString, "MemMst")
            If gdataset.Tables("MemMst").Rows.Count > 0 Then
                txt_subdesc.Text = gdataset.Tables("MemMst").Rows(0).Item("NAME")
            End If


            If Sreader.Rows(0).Item("Freeze") = "Y" Then
                Me.lbl_freeze.Visible = True
                Me.lbl_freeze.Text = "Record Freezed  On "
                Me.lbl_freeze.Text = Me.lbl_freeze.Text & Format(Sreader.Rows(0).Item("AddDate"), "dd-MMM-yyyy")
                Me.Cmd_freeze.Text = "Void[F8]"

            Else
                Me.lbl_freeze.Visible = False
                Me.lbl_freeze.Text = "Record Freezed  On "
                Me.Cmd_freeze.Text = "Void[F8]"
            End If

        Else
            Me.Txt_Subcode.Enabled = True
            Me.Txt_desc.Text = ""
            Me.lbl_freeze.Visible = False
            Me.lbl_freeze.Text = "Record Freezed  On "
            Me.Cmd_add.Text = "Add[F7]"
        End If
        'If gUserCategory <> "S" Then
        '    Call GetRights()
        'End If
        ' Dim loop1
    End Sub

    Private Sub LBL_SUBCODE_Click(sender As Object, e As EventArgs) Handles LBL_SUBCODE.Click

    End Sub

    Private Sub Lbl_subdesc_Click(sender As Object, e As EventArgs) Handles Lbl_subdesc.Click

    End Sub

    Private Sub Lbl_Type_Click(sender As Object, e As EventArgs) Handles Lbl_Type.Click

    End Sub

    Private Sub Lbl_typedesc_Click(sender As Object, e As EventArgs) Handles Lbl_typedesc.Click

    End Sub

    Private Sub Lbl_billbasis_Click(sender As Object, e As EventArgs) Handles Lbl_billbasis.Click

    End Sub

    Private Sub Lbl_billingmonth_Click(sender As Object, e As EventArgs) Handles Lbl_billingmonth.Click

    End Sub

    Private Sub Lbl_Taxcode_Click(sender As Object, e As EventArgs) Handles Lbl_Taxcode.Click

    End Sub

    Private Sub Lblpercentage_Click(sender As Object, e As EventArgs) Handles Lblpercentage.Click

    End Sub

    Private Sub Lbl_taxaccin_Click(sender As Object, e As EventArgs) Handles Lbl_taxaccin.Click

    End Sub

    Private Sub lbl_subscriptionAmount_Click(sender As Object, e As EventArgs) Handles lbl_subscriptionAmount.Click

    End Sub

    Private Sub Lbbl_taxamount_Click(sender As Object, e As EventArgs) Handles Lbbl_taxamount.Click

    End Sub

    Private Sub Txt_Taxamount_TextChanged(sender As Object, e As EventArgs) Handles Txt_Taxamount.TextChanged

    End Sub

    Private Sub Lbl_Basedon_Click(sender As Object, e As EventArgs) Handles Lbl_Basedon.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Lbl_Alliedon_Click(sender As Object, e As EventArgs) Handles Lbl_Alliedon.Click

    End Sub

    Private Sub lbl_freeze_Click(sender As Object, e As EventArgs) Handles lbl_freeze.Click

    End Sub

    Private Sub Grp_Print_Enter(sender As Object, e As EventArgs) Handles Grp_Print.Enter

    End Sub

    Private Sub Txt_luxuryTax_TextChanged(sender As Object, e As EventArgs) Handles Txt_luxuryTax.TextChanged

    End Sub

    Private Sub LBL_CHG_Click(sender As Object, e As EventArgs) Handles LBL_CHG.Click

    End Sub

    Private Sub LBL_APPLIEDFACILITY_Click(sender As Object, e As EventArgs) Handles LBL_APPLIEDFACILITY.Click

    End Sub

    Private Sub LST_FACILITY_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lbl_toage_Click(sender As Object, e As EventArgs) Handles lbl_toage.Click

    End Sub

    Private Sub Txt_from_TextChanged(sender As Object, e As EventArgs) Handles Txt_from.TextChanged

    End Sub

    Private Sub ChkList_ItemType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ChkList_ItemType.SelectedIndexChanged
        Call FillItemTypeDetails_Det()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vform As New LIST_OPERATION1
        gSQLString = "Select CHARGECODE,CHARGEDESC from CHARGEMASTER"
        M_WhereCondition = " WHERE RATE='0.00' OR RATE='0' "
        vform.vCaption = "CHARGEMASTER Help"
        vform.Field = "CHARGECODE,CHARGEDESC"
        vform.CMB_SRC_FIELDS.Select()
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            CHARGEOCDE.Text = Trim(vform.keyfield & "")
            ' Txt_subamount.Select()
            ' txt_subName_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing
        ' Cmd_add.Text = "Update[F7]"
    End Sub

    Private Sub Button1_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1.KeyDown
        ' Try
        If e.KeyCode = Keys.Enter Then
            If CHARGEOCDE.Text = "" Then
                Button1_Click(sender, e)
            Else
                Txt_subamount.Focus()
            End If
        End If
    End Sub

    Private Sub CHARGEOCDE_KeyDown(sender As Object, e As KeyEventArgs) Handles CHARGEOCDE.KeyDown
        If e.KeyCode = Keys.Enter Then
            If CHARGEOCDE.Text = "" Then
                Button1_Click(sender, e)
            Else
                Txt_subamount.Focus()
            End If
        ElseIf e.KeyCode = Keys.F4 Then
            Button1_Click(sender, e)
        End If

    End Sub

    Private Sub CHARGEOCDE_TextChanged(sender As Object, e As EventArgs) Handles CHARGEOCDE.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label1_Click_2(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub LST_FACILITY_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles LST_FACILITY.ItemCheck
        If e.NewValue = CheckState.Checked Then
            For Each i As Integer In LST_FACILITY.CheckedIndices
                LST_FACILITY.SetItemChecked(i, False)
            Next
        End If
    End Sub

    Private Sub LST_FACILITY_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles LST_FACILITY.SelectedIndexChanged

    End Sub

    Private Sub Txt_Subcode_Validated(sender As Object, e As EventArgs) Handles Txt_Subcode.Validated

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim vform As New LIST_OPERATION1
        gSQLString = "select COSTCENTERCODE,COSTCENTERDESC from ACCOUNTSCOSTCENTERMASTER"
        M_WhereCondition = " WHERE COSTCENTERCODE<>'' "
        vform.vCaption = "COSTCENTER MASTER Help"
        vform.Field = "COSTCENTERCODE,COSTCENTERDESC"
        vform.CMB_SRC_FIELDS.Select()
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            Txt_Costcentre.Text = Trim(vform.keyfield & "")
            ' Txt_subamount.Select()
            ' txt_subName_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing
        ' Cmd_add.Text = "Update[F7]"
    End Sub
End Class
