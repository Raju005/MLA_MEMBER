Imports CrystalDecisions.CrystalReports.Engine

Public Class frm_mkga_subcategorymaster
    Dim gconnection As New GlobalClass
    Dim accode, ACCDESC As String
    Dim SqlString As String
    Dim boolchk, Dupchk, datachk As Boolean
    Dim MTYPECODE As String


    Private Sub frm_mkga_subcategorymaster_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.F7 Then
                If btn_addnew.Enabled = True Then
                    Call btn_addnew_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F6 Then
                If btn_clear.Enabled = True Then
                    Call btn_clear_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F9 Then
                If btn_view.Enabled = True Then
                    'Call btn_view_Click(sender, e)
                    GR3.Visible = True
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F8 Then
                If btn_freeze.Enabled = True Then
                    Call btn_freeze_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
                If btn_exit.Enabled = True Then
                    Call btn_exit_Click(sender, e)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub frm_mkga_subcategorymaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Resize_Form()
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Call Resize_Form()

        categorybool = True
        Call FillTypeMst()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        ' cmd_CategoryCodeHelp.Visible = True

        txt_CategoryName.Enabled = False
        Txt_subcategorycode.Enabled = True
        Txt_subcategorycode.Focus()
        'lbl_Validity.Visible = False
        'Txt_Validity.Visible = False
        'lbl_unit.Visible = False
        chbx_prmno.Checked = True
        chbx_tenyes.Checked = True
        chbx_crprty.Checked = True
        lbl_crlmtamt.Visible = False
        txt_amt.Visible = False
        chbx_yescrlmt.Checked = True
        lbl_Frez.Visible = False
        chk_applyes.Checked = True
        chk_applno.Checked = False
        chk_propsryes.Checked = True
        DDGRD1.Rows.Add()
        GR3.Visible = False

    End Sub
    'Private Sub Resize_Form()
    '    Dim cControl As Control
    '    Dim i_i As Integer
    '    Dim J, K, L, M, n, o, P, Q, R, S As Integer
    '    If (Screen.PrimaryScreen.Bounds.Height = 780) And (Screen.PrimaryScreen.Bounds.Width = 1036) Then
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
    '    '    L = Me.Location.X + CInt((Me.Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - 1036) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
    '    'End If
    '    'If Me.Location.Y = 0 Then
    '    '    L = 0

    '    'Else
    '    '    M = Me.Location.Y + CInt((Me.Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - 780) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
    '    'End If
    '    'Me.Width = L
    '    'Me.Height = M

    '    With Me
    '        For i_i = 0 To .Controls.Count - 1




    '            If TypeOf .Controls(i_i) Is Label Then
    '                If .Controls(i_i).Location.X = 0 Then
    '                    L = 0
    '                Else
    '                    L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - 1036) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
    '                End If
    '                If .Controls(i_i).Location.Y = 0 Then
    '                    L = 0

    '                Else
    '                    M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - 780) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
    '                End If

    '                .Controls(i_i).Left = L
    '                .Controls(i_i).Top = M
    '                If .Controls(i_i).Size.Width = 0 Then
    '                    n = 0
    '                Else
    '                    n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - 1036) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
    '                End If
    '                If .Controls(i_i).Size.Height = 0 Then
    '                    o = 0
    '                Else
    '                    o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - 780) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
    '                End If

    '                .Controls(i_i).Width = n
    '                .Controls(i_i).Height = o
    '            End If
    '            If TypeOf .Controls(i_i) Is GroupBox Then


    '                If .Controls(i_i).Location.X = 0 Then
    '                    L = 0
    '                Else
    '                    L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - 1036) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
    '                End If
    '                If .Controls(i_i).Location.Y = 0 Then
    '                    L = 0

    '                Else
    '                    M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - 780) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
    '                End If

    '                .Controls(i_i).Left = L
    '                .Controls(i_i).Top = M
    '                If .Controls(i_i).Size.Width = 0 Then
    '                    n = 0
    '                Else
    '                    n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - 1036) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
    '                End If
    '                If .Controls(i_i).Size.Height = 0 Then
    '                    o = 0
    '                Else
    '                    o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - 780) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
    '                End If

    '                .Controls(i_i).Width = n
    '                .Controls(i_i).Height = o

    '                For Each cControl In .Controls(i_i).Controls

    '                    If cControl.Location.X = 0 Then
    '                        R = 0
    '                    Else
    '                        R = cControl.Location.X + CInt((cControl.Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - 1036) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
    '                    End If
    '                    If cControl.Location.Y = 0 Then
    '                        S = 0
    '                    Else
    '                        S = cControl.Location.Y + CInt((cControl.Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - 780) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
    '                    End If

    '                    cControl.Left = R
    '                    cControl.Top = S


    '                    If cControl.Size.Width = 0 Then
    '                        P = 0
    '                    Else
    '                        P = (cControl.Size.Width + CInt((cControl.Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - 1036) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width)))))
    '                    End If

    '                    If cControl.Size.Height = 0 Then
    '                        Q = 0
    '                    Else
    '                        Q = (cControl.Size.Height + CInt((cControl.Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - 780) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height)))))
    '                    End If

    '                    cControl.Width = P
    '                    cControl.Height = Q
    '                Next
    '            ElseIf TypeOf .Controls(i_i) Is Label Then
    '                If .Controls(i_i).Location.X = 0 Then
    '                    L = 0
    '                Else
    '                    L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - 1036) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
    '                End If
    '                If .Controls(i_i).Location.Y = 0 Then
    '                    L = 0

    '                Else
    '                    M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - 780) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
    '                End If

    '                .Controls(i_i).Left = L
    '                .Controls(i_i).Top = M
    '                If .Controls(i_i).Size.Width = 0 Then
    '                    n = 0
    '                Else
    '                    n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - 1036) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
    '                End If
    '                If .Controls(i_i).Size.Height = 0 Then
    '                    o = 0
    '                Else
    '                    o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - 780) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
    '                End If

    '                .Controls(i_i).Width = n
    '                .Controls(i_i).Height = o
    '            ElseIf TypeOf .Controls(i_i) Is Panel Then


    '                If .Controls(i_i).Location.X = 0 Then
    '                    L = 0
    '                Else
    '                    L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - 1036) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
    '                End If
    '                If .Controls(i_i).Location.Y = 0 Then
    '                    L = 0

    '                Else
    '                    M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - 780) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
    '                End If

    '                .Controls(i_i).Left = L
    '                .Controls(i_i).Top = M
    '                If .Controls(i_i).Size.Width = 0 Then
    '                    n = 0
    '                Else
    '                    n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - 1036) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
    '                End If
    '                If .Controls(i_i).Size.Height = 0 Then
    '                    o = 0
    '                Else
    '                    o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - 780) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
    '                End If

    '                .Controls(i_i).Width = n
    '                .Controls(i_i).Height = o

    '                For Each cControl In .Controls(i_i).Controls

    '                    If cControl.Location.X = 0 Then
    '                        R = 0
    '                    Else
    '                        R = cControl.Location.X + CInt((cControl.Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - 1036) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
    '                    End If
    '                    If cControl.Location.Y = 0 Then
    '                        S = 0
    '                    Else
    '                        S = cControl.Location.Y + CInt((cControl.Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - 780) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
    '                    End If

    '                    cControl.Left = R
    '                    cControl.Top = S


    '                    If cControl.Size.Width = 0 Then
    '                        P = 0
    '                    Else
    '                        P = (cControl.Size.Width + CInt((cControl.Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - 1036) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width)))))
    '                    End If

    '                    If cControl.Size.Height = 0 Then
    '                        Q = 0
    '                    Else
    '                        Q = (cControl.Size.Height + CInt((cControl.Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - 780) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height)))))
    '                    End If

    '                    cControl.Width = P
    '                    cControl.Height = Q
    '                Next

    '            End If
    '        Next i_i
    '    End With
    'End Sub
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
                            'If Controls(i_i).Name = "GroupBox2" Then
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
                        If Controls(i_i).Name = "GroupBox4" Then
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
                        If Controls(i_i).Name = "btn_clear" Or Controls(i_i).Name = "btn_addnew" Or Controls(i_i).Name = "btn_freeze" Or Controls(i_i).Name = "btn_view" Or Controls(i_i).Name = "Button1" Or Controls(i_i).Name = "btn_authorize" Or Controls(i_i).Name = "btn_exit" Then
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

    Private Sub Txt_subcategorycode_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_subcategorycode.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Txt_subcategorycode.Text = "" Then
                Call cmd_SubCategoryCodeHelp_Click(sender, e)
                Txt_subcategorycode.Select()
            Else
                Call txt_subcategorycodefill()
            End If
        End If
        If e.KeyCode = Keys.F4 Then
            Call cmd_SubCategoryCodeHelp_Click(sender, e)
        End If
    End Sub

    Private Sub Txt_subcategorycode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_subcategorycode.KeyPress
        getAlphanumeric(e)
    End Sub

    Private Sub Txt_subcategorycode_TextChanged(sender As Object, e As EventArgs) Handles Txt_subcategorycode.TextChanged

    End Sub

    Private Sub txt_SubCategoryName_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_SubCategoryName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_CategoryCode.Select()
        End If
    End Sub

    Private Sub txt_SubCategoryName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_SubCategoryName.KeyPress
        'getCharater(e)
        getAlphanumeric(e)

    End Sub

    Private Sub txt_SubCategoryName_TextChanged(sender As Object, e As EventArgs) Handles txt_SubCategoryName.TextChanged

    End Sub

    Private Sub txt_CategoryCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_CategoryCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_CategoryCode.Text = "" Then
                Call cmd_CategoryCodeHelp_Click(sender, e)
            Else
                txt_CategoryCode_Validated(sender, e)
            End If

        End If
        If e.KeyCode = Keys.F4 Then
            Call cmd_CategoryCodeHelp_Click(sender, e)

        End If
    End Sub

    Private Sub txt_CategoryCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_CategoryCode.KeyPress
        getAlphanumeric(e)
    End Sub

    Private Sub txt_CategoryCode_TextChanged(sender As Object, e As EventArgs) Handles txt_CategoryCode.TextChanged

    End Sub

    Private Sub Cbo_ClubAccount_KeyDown(sender As Object, e As KeyEventArgs) Handles Cbo_ClubAccount.KeyDown
        If e.KeyCode = Keys.Enter Then
            chbx_prmyes.Select()
        End If
    End Sub

    Private Sub Cbo_ClubAccount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_ClubAccount.SelectedIndexChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub chbx_prmno_CheckedChanged(sender As Object, e As EventArgs) Handles chbx_prmno.CheckedChanged
        If chbx_prmno.Checked = True Then
            chbx_prmyes.Checked = False
            lbl_Ten.Visible = True
            chbx_tenyes.Visible = True
            chbx_tenno.Visible = True
            chbx_vtrtsyes.Checked = False
        Else
            chbx_prmyes.Checked = True
            chbx_prmno.Checked = False
            lbl_Ten.Visible = False
            chbx_tenyes.Visible = False
            chbx_tenno.Visible = False
            chbx_vtrtsno.Checked = False
        End If
    End Sub

    Private Sub lbl_Valitity_Click(sender As Object, e As EventArgs) Handles lbl_Validity.Click

    End Sub

    Private Sub chbx_crprty_CheckedChanged(sender As Object, e As EventArgs) Handles chbx_crprty.CheckedChanged

        If chbx_crprty.Checked = True Then
            chbx_crprtn.Checked = False
            txt_nofnomne.Enabled = True
            txt_Maxnofnomne.Enabled = True
        Else
            chbx_crprtn.Checked = True
            txt_nofnomne.Enabled = False
            txt_Maxnofnomne.Enabled = False
        End If

    End Sub

    Private Sub chbx_crprtn_CheckedChanged(sender As Object, e As EventArgs) Handles chbx_crprtn.CheckedChanged

        If chbx_crprtn.Checked = True Then
            txt_nofnomne.Enabled = False
            txt_Maxnofnomne.Enabled = False
            chbx_crprty.Checked = False
        Else
            chbx_crprty.Checked = True
            txt_nofnomne.Enabled = True
            txt_Maxnofnomne.Enabled = True
        End If

    End Sub

    Private Sub chbx_prmyes_CheckedChanged(sender As Object, e As EventArgs) Handles chbx_prmyes.CheckedChanged
        If chbx_prmyes.Checked = True Then
            chbx_prmno.Checked = False
            lbl_Ten.Visible = False
            chbx_tenyes.Visible = False
            chbx_tenyes.Checked = False
            chbx_tenno.Visible = False
            chbx_vtrtsyes.Checked = True
        Else
            chbx_prmno.Checked = True
            lbl_Ten.Visible = True
            chbx_tenyes.Visible = True
            chbx_tenyes.Checked = True
            chbx_tenno.Visible = True
            'chbx_vtrtsyes.Enabled = False
            ' chbx_vtrtsno.Enabled = False
            chbx_vtrtsyes.Checked = False
        End If
    End Sub

    Private Sub chbx_tenyes_CheckedChanged(sender As Object, e As EventArgs) Handles chbx_tenyes.CheckedChanged
        If chbx_tenyes.Checked = True Then
            lbl_Validity.Visible = True
            Txt_Validity.Visible = True
            lbl_unit.Visible = True
            chbx_tenno.Checked = False
        Else
            lbl_Validity.Visible = False
            Txt_Validity.Visible = False
            lbl_unit.Visible = False
            chbx_tenno.Checked = True
            chbx_tenyes.Checked = False
        End If
    End Sub

    Private Sub chbx_tenno_CheckedChanged(sender As Object, e As EventArgs) Handles chbx_tenno.CheckedChanged
        If chbx_tenno.Checked = True Then
            lbl_Validity.Visible = False
            Txt_Validity.Visible = False
            lbl_unit.Visible = False
            chbx_tenyes.Checked = False
        Else
            chbx_tenyes.Checked = True
            lbl_Validity.Visible = True
            Txt_Validity.Visible = True
            lbl_unit.Visible = True
        End If
    End Sub

    Private Sub chbx_yescrlmt_CheckedChanged(sender As Object, e As EventArgs) Handles chbx_yescrlmt.CheckedChanged
        If chbx_yescrlmt.Checked = True Then
            chbx_nocrlmt.Checked = False
            lbl_crlmtamt.Visible = True
            txt_amt.Visible = True
        Else
            chbx_nocrlmt.Checked = True
            lbl_crlmtamt.Visible = False
            txt_amt.Visible = False
        End If

    End Sub

    Private Sub chbx_nocrlmt_CheckedChanged(sender As Object, e As EventArgs) Handles chbx_nocrlmt.CheckedChanged
        If chbx_nocrlmt.Checked = True Then
            chbx_yescrlmt.Checked = False
            lbl_crlmtamt.Visible = False
            txt_amt.Visible = False
        Else
            chbx_yescrlmt.Checked = True
            chbx_nocrlmt.Checked = False
            lbl_crlmtamt.Visible = True
            txt_amt.Visible = True
        End If
    End Sub

    Private Sub chbx_vtrtsyes_CheckedChanged(sender As Object, e As EventArgs) Handles chbx_vtrtsyes.CheckedChanged
        If chbx_vtrtsyes.Checked = True Then
            chbx_vtrtsno.Checked = False
        Else
            chbx_vtrtsno.Checked = True
            chbx_vtrtsyes.Checked = False
        End If
    End Sub

    Private Sub chbx_vtrtsno_CheckedChanged(sender As Object, e As EventArgs) Handles chbx_vtrtsno.CheckedChanged
        If chbx_vtrtsno.Checked = True Then
            chbx_vtrtsyes.Checked = False
        Else
            chbx_vtrtsyes.Checked = True
            chbx_vtrtsno.Checked = False
        End If
    End Sub

    Private Sub txt_amt_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_amt.KeyDown
        If e.KeyCode = Keys.Enter Then
            DDGRD1.Select()
        End If
    End Sub

    Private Sub txt_amt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_amt.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                e.Handled = True
                'MsgBox(" Numbers only ")
            End If
        End If
    End Sub

    Private Sub txt_amt_TextChanged(sender As Object, e As EventArgs) Handles txt_amt.TextChanged

    End Sub
    Private Sub txt_subcategorycodefill()
        Dim MEMBERTYPE As New DataTable
        Dim SUBCATEGORY As New DataTable
        Dim subsmast As New DataTable
        Dim CATEGORYDETAILS As New DataTable
        Dim SUBSCRIPTIONMASTER As New DataTable
        Dim C1 As New DataTable
        Dim ssql, SQL, SQL1 As String
        Dim i, j As Integer
        i = 0
        j = 0

        ssql = " Select isnull(AddDateTime,'') AS ADDDATETIME,isnull(voiddate,'') AS voiddate,isnull(typecode,'')as typecode,isnull(subtypeCode,'')as subtypeCode,isnull(Subtypedesc,'')as Subtypedesc,Status,isnull(Validity,'')as Validity,Isnull(Permanent,'')as Permanent,isnull(votingright,'') as votingright,isnull(SubscriptionRequired,'') as SubscriptionRequired,isnull(Creditlimit,'') as Creditlimit,Freeze,isnull(ClubAccount,'')as ClubAccount,Isnull(Tenures,'')as Tenures,Isnull(Corporatemember,'')as Corporatemember,Isnull(creditlimityn,'')as creditlimityn,ISNULL(applentry,'') as applentry,ISNULL(memlimit,0) as MEMBERLIMIT,ISNULL(conslimit,0) as CONSIDERATION_LIMIT,ISNULL(proposeryn,'') as proposeryn,ISNULL(nofseconder,0) as nofseconder,ISNULL(nofnomne ,0) as nofnomne,ISNULL(Maxnofnomne,0) as Maxnofnomne From SubCategorymaster Where subtypeCode='" & Me.Txt_subcategorycode.Text & "'"
        SUBCATEGORY = gconnection.GetValues(ssql)
        If SUBCATEGORY.Rows.Count > 0 Then

            Txt_subcategorycode.ReadOnly = True
            accode = SUBCATEGORY.Rows(0).Item("typecode")
            txt_amt.Text = SUBCATEGORY.Rows(0).Item("Creditlimit")
            Me.Txt_subcategorycode.Text = SUBCATEGORY.Rows(0).Item("subtypeCode")
            Me.Txt_Validity.Text = SUBCATEGORY.Rows(0).Item("Validity")
            Me.txt_SubCategoryName.Text = SUBCATEGORY.Rows(0).Item("Subtypedesc")
            Me.Cbo_ClubAccount.Text = SUBCATEGORY.Rows(0).Item("ClubAccount")
            Me.Txt_subcategorycode.Enabled = True
            If SUBCATEGORY.Rows(0).Item("SubscriptionRequired") = "Y" Then
                Me.Chk_subsyes.Checked = True
                Me.Chk_subsyes.BackColor = Color.Cyan
            ElseIf SUBCATEGORY.Rows(0).Item("SubscriptionRequired") = "N" Then
                Me.Chk_subsNo.Checked = True
            End If
            If SUBCATEGORY.Rows(0).Item("Permanent") = "Y" Then
                Me.chbx_prmyes.Checked = True
            ElseIf SUBCATEGORY.Rows(0).Item("Permanent") = "N" Then
                Me.chbx_prmno.Checked = True
            End If
            If SUBCATEGORY.Rows(0).Item("votingright") = "Y" Then
                Me.chbx_vtrtsyes.Checked = True
            ElseIf SUBCATEGORY.Rows(0).Item("votingright") = "N" Then
                Me.chbx_vtrtsno.Checked = True
            End If
            If SUBCATEGORY.Rows(0).Item("Freeze") = "Y" Then
                Me.lbl_Frez.Visible = True
                Me.lbl_Frez.Text = Me.lbl_Frez.Text & Format(SUBCATEGORY.Rows(0).Item("voiddate"), "dd-MMM-yyyy")
                Me.btn_freeze.Text = "UnVoid [F8]"
            Else
                Me.lbl_Frez.Visible = False
                Me.lbl_Frez.Text = "Record Voided  On "
                Me.btn_freeze.Text = "Void [F8]"
            End If
            If SUBCATEGORY.Rows(0).Item("Tenures") = "Y" Then
                Me.chbx_tenyes.Checked = True
                lbl_Ten.Visible = True
                chbx_tenyes.Visible = True
                chbx_tenno.Visible = True
                lbl_Validity.Visible = True
                lbl_unit.Visible = True
                Txt_Validity.Visible = True
            ElseIf SUBCATEGORY.Rows(0).Item("Tenures") = "N" Then
                Me.chbx_tenno.Checked = True
            End If
            If SUBCATEGORY.Rows(0).Item("Corporatemember") = "Y" Then
                Me.chbx_crprty.Checked = True
                txt_Maxnofnomne.Text = SUBCATEGORY.Rows(0).Item("Maxnofnomne")

                txt_nofnomne.Text = SUBCATEGORY.Rows(0).Item("nofnomne")
            ElseIf SUBCATEGORY.Rows(0).Item("Corporatemember") = "N" Then
                Me.chbx_crprtn.Checked = True
                txt_Maxnofnomne.Enabled = False
                txt_nofnomne.Enabled = False
            End If
            If SUBCATEGORY.Rows(0).Item("creditlimityn") = "Y" Then
                chbx_yescrlmt.Checked = True
                txt_amt.Visible = True
                txt_amt.Text = SUBCATEGORY.Rows(0).Item("Creditlimit")
            ElseIf SUBCATEGORY.Rows(0).Item("creditlimityn") = "N" Then
                chbx_nocrlmt.Checked = True
            End If
            If SUBCATEGORY.Rows(0).Item("applentry") = "Y" Then
                chk_applyes.Checked = True
                txt_limit.Enabled = True
                txt_conslimit.Enabled = True
                txt_limit.Text = SUBCATEGORY.Rows(0).Item("MEMBERLIMIT")
                txt_conslimit.Text = SUBCATEGORY.Rows(0).Item("CONSIDERATION_LIMIT")
            ElseIf SUBCATEGORY.Rows(0).Item("applentry") = "N" Then
                chk_applno.Checked = True

            End If
            Dim a As String = SUBCATEGORY.Rows(0).Item("proposeryn")
            If SUBCATEGORY.Rows(0).Item("proposeryn") = "Y" Then
                chk_propsryes.Checked = True
                txt_noscndr.Enabled = True
                Me.txt_noscndr.Text = SUBCATEGORY.Rows(0).Item("nofseconder")
            Else
                chk_propsrno.Checked = True
                txt_noscndr.Enabled = False
            End If
            cmd_CategoryCodeHelp.Enabled = False
            txt_CategoryCode.ReadOnly = True
            txt_CategoryName.ReadOnly = True
            cmd_CategoryCodeHelp.Enabled = False
            Me.btn_addnew.Text = "Update [F7]"
        Else
            Me.Txt_subcategorycode.Enabled = True
            txt_CategoryCode.Select()

            Me.accode = ""
            Me.chk_SubscriptionRequired.Checked = False
            Me.lbl_Frez.Visible = False
            Me.lbl_Frez.Text = "Record Voided  On "
            Me.btn_addnew.Text = "Add [F7]"
        End If
        ssql = "select membertype,typedesc from membertype where membertype='" & accode & "'"
        MEMBERTYPE = gconnection.GetValues(ssql)
        If MEMBERTYPE.Rows.Count > 0 Then
            Me.txt_CategoryCode.Text = MEMBERTYPE.Rows(0).Item("membertype")
            Me.txt_CategoryName.Text = MEMBERTYPE.Rows(0).Item("TypeDesc")
            Me.txt_CategoryName.Enabled = False
        End If

        gconnection.closeConnection()
        ssql = "Select MembertypeDtl.SubsCode,Subsdesc from MembertypeDtl inner join SubscriptionMast on SubscriptionMast.subscode=MembertypeDtl.subscode where Membertype = '" & Trim(Me.Txt_subcategorycode.Text & "") & "' and isnull(SubscriptionMast.Freeze,'') <> 'Y'"
        subsmast = gconnection.GetValues(ssql)
        If subsmast.Rows.Count > 0 Then
            DDGRD1.Select()
            For i = 0 To subsmast.Rows.Count - 1
                DDGRD1.Rows.Insert(i, 1)
                DDGRD1.Item(0, i).Value() = subsmast.Rows(i).Item("subscode")
                DDGRD1.Item(1, i).Value() = subsmast.Rows(i).Item("Subsdesc")
            Next i
        End If
        datachk = False
        Dim MEMBERTYPE1 As New DataTable
        Dim MEMBERTYPE2 As New DataTable
        Dim STRQUERY As String
        STRQUERY = "select  distinct(SUBTYPECODE) from SUBCATEGORYMASTER where  SUBTYPECODE='" & Trim(Txt_subcategorycode.Text) & "' "
        MEMBERTYPE2 = gconnection.GetValues(STRQUERY)
        If MEMBERTYPE2.Rows.Count > 0 Then
            STRQUERY = "select  distinct(MEMBERTYPECODE) from membermaster where  MEMBERTYPECODE='" & Trim(Txt_subcategorycode.Text) & "' and CurentStatus='ACTIVE'"
            MEMBERTYPE = gconnection.GetValues(STRQUERY)
            STRQUERY = "select  distinct(MEMBERTYPECODE) from member_application_master where  MEMBERTYPECODE='" & Trim(Txt_subcategorycode.Text) & "'"
            MEMBERTYPE1 = gconnection.GetValues(STRQUERY)
            If MEMBERTYPE.Rows.Count > 0 Or MEMBERTYPE1.Rows.Count > 0 Then
                datachk = True
            Else
                datachk = False
            End If
        Else
            datachk = False
        End If

        If datachk = True Then
            txt_SubCategoryName.ReadOnly = True
            '  MessageBox.Show("Sub Category is Already used in MEMBER Details So it cant be Change", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If gUserCategory <> "S" Then
            Call GetRights()
        Else
            txt_SubCategoryName.Select()
        End If
        Call FillTypeMst()
    End Sub


    Private Sub Txt_subcategorycode_Validated(sender As Object, e As EventArgs) Handles Txt_subcategorycode.Validated

    End Sub
    Private Sub GetRights()
        Dim i, j, k, x As Integer
        ' Dim vmain, vsmod, vssmod As Long
        'Dim ssql, SQLSTRING As String
        Dim M1 As New MainMenu
        Dim chstr As String
        SqlString = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='MEMBER' AND MODULENAME LIKE '" & Trim(GmoduleName) & "%'"
        gconnection.getDataSet(SqlString, "USER")
        If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                With gdataset.Tables("USER").Rows(i)
                    chstr = abcdMINUS(.Item("RIGHTS"))
                End With
            Next
        End If
        Me.btn_addnew.Enabled = False
        Me.btn_freeze.Enabled = False
        Me.btn_view.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.btn_addnew.Enabled = True
                    Me.btn_freeze.Enabled = True
                    Me.btn_view.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.btn_addnew.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.btn_addnew.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.btn_addnew.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    Me.btn_freeze.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.btn_view.Enabled = True
                End If
            Next
        End If
    End Sub
    Public Sub FillTypeMst()
        Dim i As Integer
        Dim SSQL As String
        Dim dt, MEMBERTYPE As DataTable
        Select_Category.Items.Clear()
        SqlString = "SELECT distinct(SubTYPEDESC) FROM subcategorymaster where freeze<>'Y' and subtypecode<>'" & Trim(Txt_subcategorycode.Text) & "'"
        dt = gconnection.GetValues(SqlString)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            Select_Category.Items.Add(dt.Rows(Itration).Item("SubTYPEDESC"))
        Next
        SSQL = "SELECT Membertypecode,Membersubtypecode,Membertype FROM MemberCategoryConversion WHERE MemberSubtypecode='" & Trim(Me.Txt_subcategorycode.Text & "") & "' AND ISNULL(FREEZE,'') <> 'Y'"
        MEMBERTYPE = gconnection.GetValues(SSQL)
        If MEMBERTYPE.Rows.Count > 0 Then
            For i = 0 To (MEMBERTYPE.Rows.Count - 1)
                For J = 0 To Select_Category.Items.Count - 1
                    If Trim(MEMBERTYPE.Rows(i).Item("Membertype")) = Select_Category.GetItemText(Select_Category.Items(J)) Then
                        Select_Category.SetItemChecked(J, True)
                    End If

                Next
            Next
        Else
            'MessageBox.Show("Current Category Cannot be converted!", gCompanyname, MessageBoxButtons.OK)
            'Exit Sub
        End If




    End Sub





    Private Sub cmd_SubCategoryCodeHelp_Click(sender As Object, e As EventArgs) Handles cmd_SubCategoryCodeHelp.Click
        Dim vform As New LIST_OPERATION1
        gSQLString = "Select  subtypecode,subtypedesc  from subcategorymaster"
        M_WhereCondition = " "
        vform.Field = "subtypecode,subtypedesc"
        vform.vCaption = "Subcatgory Master Help "
        vform.TXT_SEARCH_TXT.Select()
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            Txt_subcategorycode.Text = Trim(vform.keyfield & "")
            Txt_subcategorycode.Select()
            Call txt_subcategorycodefill()
            vform.Close()
            vform = Nothing
            btn_addnew.Text = "Update [F7]"
        End If
        gconnection.closeConnection()
    End Sub

    Private Sub cmd_CategoryCodeHelp_Click(sender As Object, e As EventArgs) Handles cmd_CategoryCodeHelp.Click
        Dim vform As New LIST_OPERATION1
        gSQLString = "Select  membertype,typedesc  from membertype "
        M_WhereCondition = "where VOID<>'Y' and isnull(typedesc,'')<>''"
        vform.Field = "membertype,typedesc"
        vform.vCaption = "Category Master Help "
        vform.TXT_SEARCH_TXT.Select()
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_CategoryCode.Text = Trim(vform.keyfield & "")
            vform.TXT_SEARCH_TXT.Select()
            Me.txt_CategoryCode_Validated(sender, e)
            vform.Close()
            vform = Nothing
        End If
        gconnection.closeConnection()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        clearform(Me)
        Me.lbl_Frez.Visible = False
        Txt_subcategorycode.Enabled = True
        txt_CategoryCode.ReadOnly = False
        cmd_CategoryCodeHelp.Enabled = True
        Txt_subcategorycode.ReadOnly = False
        txt_SubCategoryName.ReadOnly = False
        txt_CategoryCode.Text = ""
        txt_CategoryName.Text = ""
        chk_SubscriptionRequired.Checked = False
        chbx_prmno.Checked = True
        chbx_crprty.Visible = True
        chbx_vtrtsyes.Checked = False
        Chk_subsNo.Checked = False
        Chk_subsyes.Checked = False
        chbx_tenyes.Checked = True
        chbx_crprtn.Checked = False
        chbx_crprty.Checked = True

        Txt_Validity.Visible = True
        lbl_unit.Visible = True
        lbl_Validity.Visible = True
        Txt_Validity.Text = ""
        txt_limit.Text = ""
        txt_conslimit.Text = ""

        txt_noscndr.Text = ""
        Cbo_ClubAccount.SelectedIndex = -1
        DDGRD1.DataSource = Nothing
        DDGRD1.Rows.Clear()
        Me.btn_addnew.Text = "Add [F7]"
        Me.btn_freeze.Text = "Void [F8]"
        txt_amt.Text = ""
        Me.Txt_subcategorycode.Select()

        For Iteration = 0 To (Select_Category.Items.Count - 1)
            Select_Category.SetSelected(Iteration, False)
            Select_Category.SetItemChecked(Iteration, False)
        Next
        DDGRD1.AllowUserToAddRows = True
        DDGRD1.Rows.Add(1)
        DDGRD1.AllowUserToAddRows = False
        Me.lbl_Frez.Text = "Record Voided  On "
        GR3.Visible = False

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        GR3.Visible = True

    End Sub



    'Private Sub DDGRD1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DDGRD1.RowsAdded
    '    Dim I, j As Integer
    '    I = DDGRD1.CurrentCellAddress.Y

    '    ' I = DDGRD1.Rows.Count
    '    If I = 0 Then
    '        If I <= 1 Then
    '            DDGRD1.Rows.Add()
    '        End If
    '    End If

    '    'DDGRD1.Rows.Add()
    '    'DDGRD1.Rows(I + 1).Cells.Item(0).Value = ""
    '    'DDGRD1.Rows(I + 1).Cells.Item(3).Value = I + 2
    'End Sub

    Private Sub DDGRD1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DDGRD1.CellContentClick

    End Sub
    Private Sub DDGRD1_KeyDown(sender As Object, e As KeyEventArgs) Handles DDGRD1.KeyDown
        Dim col As Integer
        Dim Row As Integer
        Try
            If e.KeyCode = Keys.F4 Then
                Call SubsciptionList()
            End If
            If e.KeyCode = Keys.F2 Then
                DDGRD1.Rows.Insert(DDGRD1.CurrentRow.Index, 1)
            End If
            If e.KeyCode = Keys.F3 Then
                ' DDGRD1.Rows.Clear()


                If DDGRD1.CurrentCell.RowIndex = 0 Then
                    If Not DDGRD1.CurrentRow.IsNewRow Then
                        DDGRD1.Rows.Remove(DDGRD1.CurrentRow)
                    End If
                    DDGRD1.Rows.Add()
                Else
                    If Not DDGRD1.CurrentRow.IsNewRow Then
                        DDGRD1.Rows.Remove(DDGRD1.CurrentRow)
                    End If
                End If
            End If
            If e.KeyCode = Keys.Enter Then
                With DDGRD1
                    If Trim(.CurrentCell.ColumnIndex) = 0 Then
                        If Trim(.CurrentCell.Value) = "" Then
                            Call SubsciptionList()
                        Else
                            SUBSCRIPTION_VALID()
                        End If

                    ElseIf Trim(.CurrentCell.ColumnIndex) = 1 Then
                        If Trim(.CurrentCell.Value) = "" Then
                            Call SubsciptionList()
                        Else
                            SUBSCRIPTION_VALID()
                        End If
                    End If
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SUBSCRIPTION_VALID()
        Dim scode, sname, ssql As String
        Dim col As Integer
        Dim Row As Integer
        Try
            With DDGRD1
                '.SetActiveCell(1, 1)
                col = 0
                Row = .CurrentRow.Index
                scode = ""
                scode = Trim(.CurrentCell.Value)
                If scode <> "" Then
                    gSQLString1 = "Select SubsCode,SubsDesc from SubscriptionMast WHERE SubsCode='" & Trim(scode) & "' and  Freeze='N'"
                    Dim SUBSCRIPTION As New DataTable
                    SUBSCRIPTION = gconnection.GetValues(gSQLString1)
                    If SUBSCRIPTION.Rows.Count <> 0 Then
                        For I = 0 To SUBSCRIPTION.Rows.Count - 1
                            DDGRD1.Rows(Row).Cells(0).Value = SUBSCRIPTION.Rows(I).Item("subscode")
                            DDGRD1.Rows(Row).Cells(1).Value = SUBSCRIPTION.Rows(I).Item("SubsDesc")
                        Next
                        Call check_Duplicate(Trim(SUBSCRIPTION.Rows(0).Item("subscode")))
                        If Dupchk = True Then
                            col = 0
                            Row = DDGRD1.CurrentCell.RowIndex
                            DDGRD1.Rows(Row).Cells(0).Value = ""
                            DDGRD1.Rows(Row).Cells(1).Value = ""
                            DDGRD1.CurrentCell = DDGRD1(0, Row)
                            DDGRD1.Focus()
                            Exit Sub
                        End If
                    Else
                        MsgBox("THIS ITEM NOT FOUND")
                        DDGRD1.Rows(Row).Cells(0).Value = ""
                    End If
                    If DDGRD1.Rows(Row).Cells(1).Value <> Nothing Then
                        DDGRD1.AllowUserToAddRows = True
                        DDGRD1.Rows.Add(1)
                        DDGRD1.AllowUserToAddRows = False
                    End If
                End If

                gconnection.closeConnection()





                '.CurrentCell = DDGRD1(0, DDGRD1.CurrentRow.Index)
                'ssql = "Select SubsCode,SubsDesc from SubscriptionMast where subscode='" & scode & "'"
                'gconnection.getDataSet(ssql, "SUB")
                'If gdataset.Tables("SUB").Rows.Count > 0 Then
                '    col = 0
                '    Row = .CurrentRow.Index
                '    DDGRD1.Rows(Row).Cells(0).Value = gdataset.Tables("SUB").Rows(0).Item("SubsCode")
                '    col = 1
                '    Row = .CurrentRow.Index
                '    ' .Text =
                '    DDGRD1.Rows(Row).Cells(1).Value = gdataset.Tables("SUB").Rows(0).Item("SubsDesc")
                '    Call check_Duplicate(Trim(gdataset.Tables("SUB").Rows(0).Item("SubsCode")))
                '    If Dupchk = True Then
                '        col = 0
                '        Row = DDGRD1.CurrentCell.RowIndex
                '        DDGRD1.Rows(Row).Cells(0).Value = ""
                '        DDGRD1.Rows(Row).Cells(1).Value = ""
                '        DDGRD1.CurrentCell = DDGRD1(0, Row)
                '        DDGRD1.Focus()
                '        Exit Sub
                '    End If


                '    If DDGRD1.Rows(Row).Cells(col).Value <> Nothing Then
                '        DDGRD1.AllowUserToAddRows = True
                '        DDGRD1.Rows.Add(1)
                '        DDGRD1.AllowUserToAddRows = False
                '    End If
                'Else
                '    col = 1
                '    Row = .CurrentRow.Index
                '    .Text = ""
                '    col = 2
                '    Row = .CurrentRow.Index
                '    .Text = ""
                '    .CurrentCell = DDGRD1(1, DDGRD1.CurrentRow.Index)
                'End If
                'End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub SubsciptionList()
        Dim I, J As Integer
        Dim row As Integer
        Dim col As Integer
        row = DDGRD1.CurrentCellAddress.Y
        Dim vform As New LIST_OPERATION1
        gSQLString = "Select SubsCode,SubsDesc from SubscriptionMast "
        M_WhereCondition = " where Freeze='N' "
        vform.Field = "SubsCode,SubsDesc"
        vform.vCaption = "SUBSCRIPTION MASTER HELP "
        vform.TXT_SEARCH_TXT.Select()
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            gSQLString1 = "Select SubsCode,SubsDesc from SubscriptionMast WHERE SubsCode='" & Trim(vform.keyfield) & "'"
            Dim SUBSCRIPTION As New DataTable
            SUBSCRIPTION = gconnection.GetValues(gSQLString1)
            For I = 0 To SUBSCRIPTION.Rows.Count - 1
                DDGRD1.Rows(row).Cells(0).Value = SUBSCRIPTION.Rows(I).Item("subscode")
                DDGRD1.Rows(row).Cells(1).Value = SUBSCRIPTION.Rows(I).Item("SubsDesc")
            Next
            Call check_Duplicate(Trim(SUBSCRIPTION.Rows(0).Item("subscode")))
            If Dupchk = True Then
                col = 0
                row = DDGRD1.CurrentCell.RowIndex
                DDGRD1.Rows(row).Cells(0).Value = ""
                DDGRD1.Rows(row).Cells(1).Value = ""
                DDGRD1.CurrentCell = DDGRD1(0, row)
                DDGRD1.Focus()
                Exit Sub
            End If
            If DDGRD1.Rows(row).Cells(J).Value <> Nothing Then
                DDGRD1.AllowUserToAddRows = True
                DDGRD1.Rows.Add(1)
                DDGRD1.AllowUserToAddRows = False
            End If
        End If
        vform.Close()
        vform = Nothing
        gconnection.closeConnection()
    End Sub
    Private Function check_Duplicate(ByVal Itemcode As String)
        Dim i As Integer
        Dim row As Integer
        Dim col As Integer
        row = DDGRD1.CurrentCellAddress.Y
        col = DDGRD1.CurrentCellAddress.X
        Dupchk = False
        col = 0
        For i = 0 To DDGRD1.Rows.Count - 1
            row = i
            If i <> DDGRD1.CurrentCell.RowIndex Then
                If Trim(DDGRD1.Rows(row).Cells(0).Value) = Trim(Itemcode) Then
                    MsgBox("subscription is Already exists", MsgBoxStyle.Critical, "Duplicate")
                    Dupchk = True
                End If
            End If
        Next
    End Function
    Public Sub checkValidation()
        boolchk = False
        '''********* Checked the status for votingright and also SubscriptionRequired
        '''********** Check Category Code is blank
        If Txt_subcategorycode.Text = "" Then
            MessageBox.Show(" Category Code can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Txt_subcategorycode.Focus()
            boolchk = False
            Exit Sub
        End If
        If txt_SubCategoryName.Text = "" Then
            MessageBox.Show(" subCategory name can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txt_SubCategoryName.Focus()
            boolchk = False
            Exit Sub
        End If
        If txt_CategoryCode.Text = "" Then
            MessageBox.Show(" Category Code can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txt_CategoryCode.Focus()
            boolchk = False
            Exit Sub
        End If
        '''********** Check Category Name is blank
        'If txt_CategoryName.Text = "" Then
        '    MessageBox.Show(" Category Name can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    'txt_CategoryName.Focus()
        '    boolchk = False
        '    Exit Sub
        'End If

        If chbx_prmyes.Checked = False And chbx_prmno.Checked = False Then
            MessageBox.Show("Membership Permanent Can't be blank !!!", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            'txt_CategoryName.Focus()
            boolchk = False
            Exit Sub
        End If
        If chbx_vtrtsyes.Checked = False And chbx_vtrtsno.Checked = False Then
            MessageBox.Show("Membership Votingrights Can't be blank !!!", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            'txt_CategoryName.Focus()
            boolchk = False
            Exit Sub
        End If
        If chbx_tenyes.Checked = True And Txt_Validity.Text = "" Then
            MessageBox.Show("Validity Period Can't be blank !!!", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Txt_Validity.Focus()
            boolchk = False
            Exit Sub
        End If
        If chbx_tenyes.Checked = True Then
            If Val(Txt_Validity.Text) < 1 Then
                MessageBox.Show(" Validity can't give less than the 1 ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Txt_Validity.Focus()
                Exit Sub
            End If
        End If
        If chk_applyes.Checked = True And txt_limit.Text = "" Then
            MessageBox.Show("member limit   Can't be blank !!!", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            'txt_CategoryName.Focus()
            boolchk = False
            Exit Sub
        End If
        If chk_applyes.Checked = True And txt_conslimit.Text = "" Then
            MessageBox.Show("consideration limit Period Can't be blank !!!", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            'txt_CategoryName.Focus()
            boolchk = False
            Exit Sub
        End If

        If Cbo_ClubAccount.Text = "" Then
            MessageBox.Show(" Club Account can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            'txt_CategoryName.Focus()
            boolchk = False
            Exit Sub
        End If
        If Val(txt_conslimit.Text) > Val(txt_limit.Text) Then
            MessageBox.Show(" Consideration Limit  can't give more than the Limit ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_limit.Focus()
            Exit Sub
        End If
        If Val(txt_Maxnofnomne.Text) > 4 Then
            MessageBox.Show(" MAXIMUM NOMINEE can't give more than the 4 ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Maxnofnomne.Focus()
            Exit Sub
        End If
        If chbx_crprty.Checked = True Then
            If txt_nofnomne.Text = "" Then
                MessageBox.Show(" NOMINE  can't blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_nofnomne.Focus()
                Exit Sub
            End If
            If txt_Maxnofnomne.Text = "" Then
                MessageBox.Show(" Max no of NOMINE  can't blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_nofnomne.Focus()
                Exit Sub
            End If
            If Val(txt_nofnomne.Text) > Val(txt_Maxnofnomne.Text) Then
                MessageBox.Show(" NOMINEE NOT MORE THAN MAXIMUM Limit  can't give more than the Limit ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_nofnomne.Focus()
                Exit Sub
            End If
        End If
        If chk_propsryes.Checked = True Then
            If txt_noscndr.Text = "" Then
                MessageBox.Show(" SECONDER can't blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_noscndr.Focus()
                Exit Sub
            End If
            If 5 < Val(txt_noscndr.Text) Then
                MessageBox.Show(" SECONDER can't give more than the 4 ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_noscndr.Focus()
                Exit Sub
            End If
            If 1 > Val(txt_noscndr.Text) Then
                MessageBox.Show(" SECONDER can't give less than the 1 ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_noscndr.Focus()
                Exit Sub
            End If
        End If

        If chbx_yescrlmt.Checked = True Then
            If txt_amt.Text = "" Then
                MessageBox.Show(" credit limit yes is need to fill amount", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_Maxnofnomne.Focus()
                Exit Sub
            End If
        End If
        boolchk = True
    End Sub
    Public Sub checkValidation1()
        boolchk = False
        '''********* Checked the status for votingright and also SubscriptionRequired
        '''********** Check Category Code is blank
        If Txt_subcategorycode.Text = "" Then
            MessageBox.Show(" Category Code can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Txt_subcategorycode.Focus()
            boolchk = False
            Exit Sub
        End If







        datachk = False
        Dim MEMBERTYPE, MEMBERTYPE1 As New DataTable
        Dim STRQUERY As String
        STRQUERY = "select  distinct(MEMBERTYPECODE) from membermaster where  MEMBERTYPECODE='" & Trim(Txt_subcategorycode.Text) & "' and CurentStatus='ACTIVE'"
        MEMBERTYPE = gconnection.GetValues(STRQUERY)
        STRQUERY = "select  distinct(MEMBERTYPECODE) from member_application_master where  MEMBERTYPECODE='" & Trim(Txt_subcategorycode.Text) & "'"
        MEMBERTYPE1 = gconnection.GetValues(STRQUERY)
        If MEMBERTYPE.Rows.Count > 0 Or MEMBERTYPE1.Rows.Count > 0 Then
            datachk = True
        End If





        If datachk = True Then
            txt_SubCategoryName.ReadOnly = True
            MessageBox.Show("Sub Category is Already used in MEMBER Details So it cant be Change", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            datachk = False
            boolchk = False
            Exit Sub
        End If




        If txt_SubCategoryName.Text = "" Then
            MessageBox.Show(" subCategory name can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txt_SubCategoryName.Focus()
            boolchk = False
            Exit Sub
        End If
        If txt_CategoryCode.Text = "" Then
            MessageBox.Show(" Category Code can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txt_CategoryCode.Focus()
            boolchk = False
            Exit Sub
        End If
        '''********** Check Category Name is blank
        'If txt_CategoryName.Text = "" Then
        '    MessageBox.Show(" Category Name can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    'txt_CategoryName.Focus()
        '    boolchk = False
        '    Exit Sub
        'End If

        If chbx_prmyes.Checked = False And chbx_prmno.Checked = False Then
            MessageBox.Show("Membership Permanent Can't be blank !!!", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            'txt_CategoryName.Focus()
            boolchk = False
            Exit Sub
        End If
        If chbx_vtrtsyes.Checked = False And chbx_vtrtsno.Checked = False Then
            MessageBox.Show("Membership Votingrights Can't be blank !!!", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            'txt_CategoryName.Focus()
            boolchk = False
            Exit Sub
        End If
        If chbx_tenyes.Checked = True And Txt_Validity.Text = "" Then
            MessageBox.Show("Validity Period Can't be blank !!!", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            'txt_CategoryName.Focus()
            boolchk = False
            Exit Sub
        End If
        If chk_applyes.Checked = True And txt_limit.Text = "" Then
            MessageBox.Show("member limit   Can't be blank !!!", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            'txt_CategoryName.Focus()
            boolchk = False
            Exit Sub
        End If
        If chk_applyes.Checked = True And txt_conslimit.Text = "" Then
            MessageBox.Show("consideration limit Period Can't be blank !!!", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            'txt_CategoryName.Focus()
            boolchk = False
            Exit Sub
        End If

        If Cbo_ClubAccount.Text = "" Then
            MessageBox.Show(" Club Account can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            'txt_CategoryName.Focus()
            boolchk = False
            Exit Sub
        End If
        If Val(txt_conslimit.Text) > Val(txt_limit.Text) Then
            MessageBox.Show(" Consideration Limit  can't give more than the Limit ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_limit.Focus()
            Exit Sub
        End If
        If Val(txt_Maxnofnomne.Text) > 4 Then
            MessageBox.Show(" MAXIMUM NOMINEE can't give more than the 4 ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Maxnofnomne.Focus()
            Exit Sub
        End If
        If chbx_crprty.Checked = True Then
            If txt_nofnomne.Text = "" Then
                MessageBox.Show(" NOMINE  can't blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_nofnomne.Focus()
                Exit Sub
            End If
            If txt_Maxnofnomne.Text = "" Then
                MessageBox.Show(" Max no of NOMINE  can't blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_nofnomne.Focus()
                Exit Sub
            End If
            If Val(txt_nofnomne.Text) > Val(txt_Maxnofnomne.Text) Then
                MessageBox.Show(" NOMINEE NOT MORE THAN MAXIMUM Limit  can't give more than the Limit ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_nofnomne.Focus()
                Exit Sub
            End If

        End If
        If chk_propsryes.Checked = True Then
            If txt_noscndr.Text = "" Then
                MessageBox.Show(" SECONDER can't blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_noscndr.Focus()
                Exit Sub
            End If
            If 5 < Val(txt_noscndr.Text) Then
                MessageBox.Show(" SECONDER can't give more than the 4 ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_noscndr.Focus()
                Exit Sub
            End If
            If 1 > Val(txt_noscndr.Text) Then
                MessageBox.Show(" SECONDER can't give less than the 1 ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_noscndr.Focus()
                Exit Sub
            End If
        End If

        If chbx_yescrlmt.Checked = True Then
            If txt_amt.Text = "" Then
                MessageBox.Show(" credit limit yes is need to fill amount", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_Maxnofnomne.Focus()
                Exit Sub
            End If
        End If
        boolchk = True
    End Sub
    Private Sub btn_addnew_Click(sender As Object, e As EventArgs) Handles btn_addnew.Click
        Dim subcode, subdesc As String
        Dim permanent, VotingRight, Tenures, Corporatemember, creditlimityn, creditlimit, Validity, applentry, memlimit, conslimit, proposeryn, nofseconder, nofnomne, Maxnofnomne As String
        Try
            If btn_addnew.Text = "Add [F7]" Then
                Call checkValidation()
                If boolchk = False Then Exit Sub
                SqlString = "INSERT INTO SubCategorymaster"
                SqlString = SqlString & "(typeCode,subtypeCode,Subtypedesc,ADDUSERID,AddDatetime,Freeze,ClubAccount) VALUES ('" & txt_CategoryCode.Text & "' , '"
                SqlString = SqlString & Txt_subcategorycode.Text & "','" & Trim(txt_SubCategoryName.Text) & "','" & gUsername & " ' ,'" & Format(Date.Now, "dd-MMM-yyyy HH:mm") & "','N','" & Cbo_ClubAccount.Text & "')"
                gconnection.closeConnection()
                gconnection.dataOperation(1, SqlString, "MemberType")
                If chbx_prmyes.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET permanent = 'Y', Tenures = 'N',validity= '0'   WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If chbx_vtrtsyes.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET VotingRight = 'Y' WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If chbx_tenyes.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET Tenures = 'Y',validity= '" & Txt_Validity.Text & "' WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If chbx_crprty.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET Corporatemember = 'Y',nofnomne= '" & txt_nofnomne.Text & "',Maxnofnomne= '" & txt_Maxnofnomne.Text & "' WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If chbx_prmno.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET permanent = 'N' WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If chbx_vtrtsno.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET VotingRight = 'N' WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If chbx_tenno.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET Tenures = 'N',validity='0' WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If chbx_crprtn.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET Corporatemember = 'N',nofnomne= '0',Maxnofnomne= '0' WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If chbx_yescrlmt.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET  "
                    SqlString = SqlString & " creditlimityn='Y',creditlimit ='" & txt_amt.Text & "' where  subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If chbx_nocrlmt.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET  "
                    SqlString = SqlString & " creditlimityn='N',creditlimit ='0'  where  subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If chk_applyes.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET  "
                    SqlString = SqlString & " applentry='Y',memlimit ='" & txt_limit.Text & "',conslimit ='" & txt_conslimit.Text & "' where  subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If chk_applno.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET  "
                    SqlString = SqlString & " applentry='N',memlimit ='0',conslimit ='0'  where  subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If chk_propsryes.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET  "
                    SqlString = SqlString & "  proposeryn='Y',nofseconder ='" & txt_noscndr.Text & "' where  subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If chk_propsrno.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET  "
                    SqlString = SqlString & "  proposeryn='N',nofseconder ='0'  where  subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                For loopindex = 0 To DDGRD1.Rows.Count - 1
                    subcode = Nothing
                    subdesc = Nothing
                    Dim col As Integer
                    Dim Row As Integer

                    col = 0
                    Row = loopindex
                    subcode = DDGRD1.Rows(Row).Cells(col).Value
                    col = 1
                    Row = loopindex
                    subdesc = DDGRD1.Rows(Row).Cells(col).Value
                    If IsNothing(DDGRD1.Rows(Row).Cells(col).Value) Then
                    Else
                        SqlString = "Insert into MembertypeDtl(Membertype,SubsCode,AddUser,AddDate,Freeze)values('" & Trim(Txt_subcategorycode.Text & "") & "',"
                        SqlString = SqlString & " '" & Trim(subcode & "") & "','" & gUsername & " ','" & Format(Date.Now, "dd-MMM-yyyy HH:mm") & "','N')"
                        gconnection.dataOperation(1, SqlString, "MemberType")
                    End If
                Next loopindex

                If Select_Category.CheckedItems.Count > 0 Then
                    For I = 0 To Select_Category.CheckedItems.Count - 1
                        MTYPECODE = Select_Category.CheckedItems(I)
                        SqlString = "INSERT INTO MemberCategoryConversion"
                        SqlString = SqlString & "(Membertypecode,MemberSubtypecode,Membertype,Adduser,Adddatetime,Freeze) VALUES ('" & txt_CategoryCode.Text & " ' , '"
                        SqlString = SqlString & Txt_subcategorycode.Text & "','" & MTYPECODE & "', '" & gUsername & " ' ,'" & Format(Date.Now, "dd-MMM-yyyy HH:mm") & "','N')"
                        gconnection.dataOperation(1, SqlString, "MemberType")
                    Next
                End If

                MessageBox.Show("Record Saved Successfully ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.btn_clear_Click(sender, e)
            ElseIf btn_addnew.Text = "Update [F7]" Then
                Call checkValidation()
                If Mid(Me.btn_addnew.Text, 1, 1) = "U" Then
                    If Me.lbl_Frez.Visible = True Then
                        MsgBox(" The Voided Record Can Not Be Update", , gCompanyname)
                        boolchk = False
                    End If
                End If
                If boolchk = False Then Exit Sub
                SqlString = "Delete from MemberTypeDtl where MemberType ='" & Trim(Txt_subcategorycode.Text & "") & "'"
                gconnection.dataOperation(1, SqlString, "MemberType")
                gconnection.closeConnection()
                SqlString = "UPDATE  SubCategorymaster SET Subtypedesc = '"
                SqlString = SqlString & txt_SubCategoryName.Text & "'"
                SqlString = SqlString & ",typeCode = '" & txt_CategoryCode.Text
                SqlString = SqlString & "',UPD_USER ='" & gUsername

                ' SqlString = SqlString & "',nofproposer ='" & txt_noprpsr.Text
                '  SqlString = SqlString & "',nofseconder ='" & txt_noscndr.Text
                SqlString = SqlString & "',ClubAccount ='" & Cbo_ClubAccount.Text
                SqlString = SqlString & "',UPD_DATE='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "',FREEZE = 'N'"
                SqlString = SqlString & " WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                gconnection.dataOperation(2, SqlString, "membertype")
                gconnection.closeConnection()
                If chbx_prmyes.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET permanent = 'Y', Tenures = 'N',validity= '0'   WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If chbx_vtrtsyes.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET VotingRight = 'Y' WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If chbx_tenyes.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET Tenures = 'Y',validity= '" & Txt_Validity.Text & "' WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If chbx_crprty.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET Corporatemember = 'Y',nofnomne= '" & txt_nofnomne.Text & "',Maxnofnomne= '" & txt_Maxnofnomne.Text & "' WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If chbx_prmno.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET permanent = 'N' WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If chbx_vtrtsno.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET VotingRight = 'N' WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If chbx_tenno.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET Tenures = 'N',validity='0' WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If chbx_crprtn.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET Corporatemember = 'N',nofnomne= '0',Maxnofnomne= '0' WHERE subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If chbx_yescrlmt.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET  "
                    SqlString = SqlString & " creditlimityn='Y',creditlimit ='" & txt_amt.Text & "' where  subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If chbx_nocrlmt.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET  "
                    SqlString = SqlString & " creditlimityn='N',creditlimit ='0'  where  subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If chk_applyes.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET  "
                    SqlString = SqlString & " applentry='Y',memlimit ='" & txt_limit.Text & "',conslimit ='" & txt_conslimit.Text & "' where  subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If chk_applno.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET  "
                    SqlString = SqlString & " applentry='N',memlimit ='0',conslimit ='0'  where  subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If chk_propsryes.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET  "
                    SqlString = SqlString & "  proposeryn='Y',nofseconder ='" & txt_noscndr.Text & "' where  subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                If chk_propsrno.Checked = True Then
                    SqlString = " UPDATE  SubCategorymaster SET  "
                    SqlString = SqlString & "  proposeryn='N',nofseconder ='0'  where  subtypeCode = '" & Txt_subcategorycode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "membertype")
                    gconnection.closeConnection()
                End If
                For loopindex = 0 To DDGRD1.Rows.Count - 1
                    subcode = Nothing
                    subdesc = Nothing
                    Dim col As Integer
                    Dim Row As Integer

                    col = 0
                    Row = loopindex
                    subcode = DDGRD1.Rows(Row).Cells(col).Value
                    col = 1
                    Row = loopindex
                    subdesc = DDGRD1.Rows(Row).Cells(col).Value
                    If IsNothing(DDGRD1.Rows(Row).Cells(col).Value) Then
                    Else
                        SqlString = "Insert into MembertypeDtl(Membertype,SubsCode,AddUser,AddDate,Freeze)values('" & Trim(Txt_subcategorycode.Text & "") & "',"
                        SqlString = SqlString & " '" & Trim(subcode & "") & "','" & gUsername & " ','" & Format(Date.Now, "dd-MMM-yyyy HH:mm") & "','N')"
                        gconnection.dataOperation(1, SqlString, "MemberType")
                        gconnection.closeConnection()
                    End If
                Next loopindex
                gconnection.closeConnection()
                SqlString = "Delete from MemberCategoryConversion where Membertypecode='" & txt_CategoryCode.Text & "'and Membersubtypecode='" & Txt_subcategorycode.Text & "'"
                gconnection.dataOperation(1, SqlString, "MemberType")
                If Select_Category.CheckedItems.Count > 0 Then
                    For I = 0 To Select_Category.CheckedItems.Count - 1
                        MTYPECODE = Select_Category.CheckedItems(I)
                        SqlString = "INSERT INTO MemberCategoryConversion"
                        SqlString = SqlString & "(Membertypecode,MemberSubtypecode,Membertype,Adduser,Adddatetime,Freeze) VALUES ('" & txt_CategoryCode.Text & " ' , '"
                        SqlString = SqlString & Txt_subcategorycode.Text & "','" & MTYPECODE & "', '" & gUsername & " ' ,'" & Format(Date.Now, "dd-MMM-yyyy HH:mm") & "','N')"
                        gconnection.dataOperation(1, SqlString, "MemberType")
                    Next
                End If
                If chbx_prmyes.Checked = True Then
                    permanent = "Y"
                End If
                If chbx_vtrtsyes.Checked = True Then
                    VotingRight = "Y"
                End If
                If chbx_tenyes.Checked = True Then
                    Tenures = "Y"
                    Validity = Txt_Validity.Text
                End If
                If chbx_crprty.Checked = True Then
                    Corporatemember = "Y"
                    nofnomne = txt_nofnomne.Text
                    Maxnofnomne = txt_Maxnofnomne.Text
                End If
                If chbx_prmno.Checked = True Then
                    permanent = "N"
                End If
                If chbx_vtrtsno.Checked = True Then
                    VotingRight = "N"
                End If
                If chbx_tenno.Checked = True Then
                    Tenures = "N"
                    Validity = 0
                End If
                If chbx_crprtn.Checked = True Then
                    Corporatemember = "N"
                    nofnomne = 0
                    Maxnofnomne = 0
                End If
                If chbx_yescrlmt.Checked = True Then
                    creditlimityn = "Y"
                    creditlimit = txt_amt.Text
                End If
                If chbx_nocrlmt.Checked = True Then
                    creditlimityn = "N"
                    creditlimit = 0
                End If
                If chk_applyes.Checked = True Then
                    applentry = "Y"
                    memlimit = txt_limit.Text
                    conslimit = txt_conslimit.Text
                End If
                If chk_applno.Checked = True Then
                    applentry = "N"
                    memlimit = 0
                    conslimit = 0
                End If
                If chk_propsryes.Checked = True Then
                    proposeryn = "Y"
                    nofseconder = txt_noscndr.Text
                End If
                If chk_propsrno.Checked = True Then
                    proposeryn = "N"
                    nofseconder = 0
                End If
                SqlString = "INSERT INTO SubCategorymaster_log"
                SqlString = SqlString & "(typeCode,subtypeCode,Subtypedesc,proposeryn,nofseconder,applentry,memlimit,conslimit,ADDUSERID,AddDatetime,Freeze,ClubAccount,VotingRight,Tenures,Validity,Corporatemember,nofnomne,Maxnofnomne,creditlimityn,creditlimit) VALUES ('" & txt_CategoryCode.Text & " ' , '"
                SqlString = SqlString & Txt_subcategorycode.Text & "','" & Trim(txt_SubCategoryName.Text) & "','" & proposeryn & "'," & nofseconder & ",'" & applentry & "'," & memlimit & "," & conslimit & ",'" & gUsername & "','" & Format(Date.Now, "dd-MMM-yyyy HH:mm") & "','N','" & Cbo_ClubAccount.Text & "','" & VotingRight & "','" & Tenures & "','" & Validity & "','" & Corporatemember & "'," & nofnomne & "," & Maxnofnomne & ",'" & creditlimityn & "'," & creditlimit & ")"
                gconnection.dataOperation(1, SqlString, "MemberType")
                gconnection.closeConnection()
                MessageBox.Show("Record Updated Successfully ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.btn_clear_Click(sender, e)
                'btn_addnew.Text = "Add [F7]"
            End If
        Catch ex As Exception
            MessageBox.Show("Error in Retriveing records : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.btn_clear_Click(sender, e)
        Finally
            ' Me.btn_clear_Click(sender, e)
        End Try
    End Sub

    Private Sub DDGRD1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DDGRD1.KeyPress
        Dim I, J As Integer
        I = DDGRD1.CurrentCellAddress.Y
        J = DDGRD1.CurrentCellAddress.X
        If Asc(e.KeyChar) = 13 Then
            If DDGRD1.CurrentCellAddress.X = 0 Then
                If DDGRD1.Rows(I).Cells(J).Value <> Nothing Then
                    'DDGRD1.AllowUserToAddRows = True
                    ' DDGRD1.Rows.Add(1)
                    'DDGRD1.AllowUserToAddRows = False

                    If Dupchk = False Then
                        DDGRD1.CurrentCell = DDGRD1(J, I)
                    Else
                        DDGRD1.CurrentCell = DDGRD1(J, I + 1)
                    End If


                Else
                    DDGRD1.CurrentCell = DDGRD1(J, I)
                End If
            End If
        End If
    End Sub

    Private Sub DDGRD1_Leave(sender As Object, e As EventArgs) Handles DDGRD1.Leave
        Dim I, J As Integer
        I = DDGRD1.CurrentCellAddress.Y
        J = DDGRD1.CurrentCellAddress.X
        If DDGRD1.CurrentCellAddress.X = 0 Then
            If DDGRD1.Rows(I).Cells(J).Value <> Nothing Then
                DDGRD1.CurrentCell = DDGRD1(J + 1, I)
            Else
                DDGRD1.CurrentCell = DDGRD1(J, I)
            End If
        End If
    End Sub

    Private Sub DDGRD1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DDGRD1.RowsAdded

    End Sub

    Private Sub btn_freeze_Click(sender As Object, e As EventArgs) Handles btn_freeze.Click
        Call checkValidation1()
        If boolchk = False Then Exit Sub
        If Mid(Me.btn_freeze.Text, 1, 1) = "V" And Mid(Me.btn_addnew.Text, 1, 1) = "U" Then
            SqlString = "UPDATE  SubCategorymaster "
            SqlString = SqlString & " SET Freeze= 'Y',voiduser='" & gUsername & "', voiddate='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
            SqlString = SqlString & " WHERE subtypeCode = '" & Txt_subcategorycode.Text & " '"
            gconnection.dataOperation(3, SqlString, "MemberType")
            SqlString = "UPDATE  SubCategorymaster_log"
            SqlString = SqlString & " SET  subtypeCode = '" & Txt_subcategorycode.Text & "',Freeze= 'Y',voiduser='" & gUsername & "', voiddate='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
            gconnection.dataOperation(3, SqlString, "subcategorymaster")
            gconnection.closeConnection()
            MessageBox.Show("Record Voided Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.btn_clear_Click(sender, e)
            btn_addnew.Text = "Add [F7]"
        ElseIf Mid(Me.btn_freeze.Text, 1, 1) = "U" And Mid(Me.btn_addnew.Text, 1, 1) = "U" Then
            MsgBox("This Unvoid Process Can't Proceed")
            'SqlString = "UPDATE  SubCategorymaster "
            'SqlString = SqlString & " SET Freeze= 'N',voiduser='" & gUsername & " ', voiddate='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
            'SqlString = SqlString & " WHERE subtypeCode = '" & Txt_subcategorycode.Text & " '"
            'gconnection.dataOperation(4, SqlString, "MemberType")

            'SqlString = "UPDATE  SubCategorymaster_log"
            'SqlString = SqlString & " SET  subtypeCode = '" & Txt_subcategorycode.Text & "',Freeze= 'N',voiduser='" & gUsername & " ', voiddate='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
            'gconnection.dataOperation(3, SqlString, "subcategorymaster")
            'gconnection.closeConnection()
            'MessageBox.Show("Record UnFreezed Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Me.btn_clear_Click(sender, e)
            'btn_addnew.Text = "Add [F7]"
        End If
    End Sub

    Private Sub btn_authorize_Click(sender As Object, e As EventArgs) Handles btn_authorize.Click
       



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
            SSQLSTR2 = " SELECT * FROM SUBCATEGORYMASTER WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER1,'')=''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH1USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH1USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE")
                If gdataset.Tables("AUTHORIZE").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND ISNULL(AUTHORIZELEVEL,0)>0 "
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM SUBCATEGORYMASTER WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER1,'')=''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()


                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE SUBCATEGORYMASTER set  ", "subtypecode", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 1, 1)
                        End If
                    Else
                        MsgBox("NO AUTHORIZATION REQUIRED FOR THE ENTRY")
                    End If
                End If
            End If
        ElseIf USERT = 2 Then
            SSQLSTR2 = " SELECT * FROM SUBCATEGORYMASTER WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')='' AND ISNULL(AUTHORISE_USER1,'')<>''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH2USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH2USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE1")
                If gdataset.Tables("AUTHORIZE1").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "'"
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM SUBCATEGORYMASTER WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')=''AND ISNULL(AUTHORISE_USER1,'')<>''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()


                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE SUBCATEGORYMASTER set  ", "subtypecode", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 2, 1)
                        End If
                    End If
                End If
            End If
        ElseIf USERT = 3 Then
            SSQLSTR2 = " SELECT * FROM SUBCATEGORYMASTER WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')=''AND ISNULL(AUTHORISE_USER1,'')<>''  AND ISNULL(AUTHORISE_USER2,'')<>''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH3USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH3USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE2")
                If gdataset.Tables("AUTHORIZE2").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "'"
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM SUBCATEGORYMASTER WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')=''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()
                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE SUBCATEGORYMASTER set  ", "subtypecode", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 3, 1)
                        End If
                    End If
                End If
            Else
                MsgBox("U R NOT ELIGIBLE TO AUTHORISE IN ANY LEVEL", MsgBoxStyle.Critical)
            End If
        End If


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

    Private Sub txt_CategoryCode_Validated(sender As Object, e As EventArgs) Handles txt_CategoryCode.Validated
        If Trim(txt_CategoryCode.Text) <> "" Then
            Dim MEMBERTYPE As New DataTable
            Dim STRQUERY As String
            STRQUERY = "SELECT ISNULL(membertype,'') as CATEGORY_CODE,ISNULL(typedesc,'') AS CATEGORY_NAME   FROM membertype  WHERE membertype='" & Trim(txt_CategoryCode.Text) & "' and VOID<>'Y' and isnull(typedesc,'')<>''"
            MEMBERTYPE = gconnection.GetValues(STRQUERY)
            If MEMBERTYPE.Rows.Count > 0 Then
                txt_CategoryCode.Text = MEMBERTYPE.Rows(0).Item("CATEGORY_CODE")
                txt_CategoryName.Text = MEMBERTYPE.Rows(0).Item("CATEGORY_NAME")
                txt_CategoryCode.ReadOnly = True
                Cbo_ClubAccount.Select()
            End If
        End If
    End Sub


    Private Sub cmd_SubCategoryCodeHelp_KeyDown(sender As Object, e As KeyEventArgs) Handles cmd_SubCategoryCodeHelp.KeyDown

    End Sub

    Private Sub Txt_Validity_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Validity.KeyDown
        If e.KeyCode = Keys.Enter Then
            chk_applyes.Select()
        End If
    End Sub

    Private Sub Txt_Validity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Validity.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                e.Handled = True
                'MsgBox(" Numbers only ")
            End If
        End If
    End Sub

    Private Sub Txt_Validity_TextChanged(sender As Object, e As EventArgs) Handles Txt_Validity.TextChanged

    End Sub

    Private Sub chk_applyes_CheckedChanged(sender As Object, e As EventArgs) Handles chk_applyes.CheckedChanged
        If chk_applyes.Checked = True Then
            chk_applyes.Checked = True
            chk_applno.Checked = False
            txt_limit.Enabled = True
            txt_conslimit.Enabled = True
        Else
            chk_applyes.Checked = False
            chk_applno.Checked = True
        End If
    End Sub

    Private Sub chk_applno_CheckedChanged(sender As Object, e As EventArgs) Handles chk_applno.CheckedChanged
        If chk_applno.Checked = True Then
            chk_applno.Checked = True
            chk_applyes.Checked = False
            txt_limit.Enabled = False
            txt_conslimit.Enabled = False
        Else
            chk_applyes.Checked = True
            chk_applno.Checked = False
        End If
    End Sub

    Private Sub lbl_Ten_Click(sender As Object, e As EventArgs) Handles lbl_Ten.Click

    End Sub

    Private Sub chk_propsryes_CheckedChanged(sender As Object, e As EventArgs) Handles chk_propsryes.CheckedChanged
        If chk_propsryes.Checked = True Then
            chk_propsryes.Checked = True
            chk_propsrno.Checked = False
            txt_noscndr.Enabled = True
        Else
            chk_propsrno.Checked = True
            chk_propsryes.Checked = False
            txt_noscndr.Enabled = False
        End If
    End Sub

    Private Sub chk_propsrno_CheckedChanged(sender As Object, e As EventArgs) Handles chk_propsrno.CheckedChanged
        If chk_propsrno.Checked = True Then
            chk_propsrno.Checked = True
            chk_propsryes.Checked = False
            txt_noscndr.Enabled = False
        Else
            txt_noscndr.Enabled = True
            chk_propsryes.Checked = True
            chk_propsrno.Checked = False
        End If
    End Sub

    Private Sub txt_limit_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_limit.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_conslimit.Select()
        End If

    End Sub

    Private Sub txt_limit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_limit.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                e.Handled = True
                'MsgBox(" Numbers only ")
            End If
        End If
    End Sub

    Private Sub txt_limit_TextChanged(sender As Object, e As EventArgs) Handles txt_limit.TextChanged

    End Sub

    Private Sub txt_conslimit_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_conslimit.KeyDown
        If e.KeyCode = Keys.Enter Then
            chbx_crprty.Select()
        End If
    End Sub

    Private Sub txt_conslimit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_conslimit.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                e.Handled = True
                'MsgBox(" Numbers only ")
            End If
        End If
    End Sub

    Private Sub txt_conslimit_TextChanged(sender As Object, e As EventArgs) Handles txt_conslimit.TextChanged

    End Sub

    Private Sub txt_nofnomne_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_nofnomne.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_Maxnofnomne.Select()
        End If
    End Sub

    Private Sub txt_nofnomne_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nofnomne.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                e.Handled = True
                'MsgBox(" Numbers only ")
            End If
        End If
    End Sub

    Private Sub txt_nofnomne_TextChanged(sender As Object, e As EventArgs) Handles txt_nofnomne.TextChanged

    End Sub

    Private Sub txt_Maxnofnomne_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Maxnofnomne.KeyDown
        If e.KeyCode = Keys.Enter Then
            chk_propsryes.Select()
        End If
    End Sub

    Private Sub txt_Maxnofnomne_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Maxnofnomne.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                e.Handled = True
                'MsgBox(" Numbers only ")
            End If
        End If
    End Sub

    Private Sub txt_Maxnofnomne_TextChanged(sender As Object, e As EventArgs) Handles txt_Maxnofnomne.TextChanged

    End Sub

    Private Sub txt_noscndr_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_noscndr.KeyDown
        If e.KeyCode = Keys.Enter Then
            DDGRD1.Select()
        End If
    End Sub

    Private Sub txt_noscndr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_noscndr.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                e.Handled = True
                'MsgBox(" Numbers only ")
            End If
        End If
    End Sub

    Private Sub txt_noscndr_TextChanged(sender As Object, e As EventArgs) Handles txt_noscndr.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim VIEW1 As New VIEWHDR
        'VIEW1.Show()
        'VIEW1.DTGRDHDR.DataSource = Nothing
        'VIEW1.DTGRDHDR.Rows.Clear()
        'Dim STRQUERY As String
        ''STRQUERY = "SELECT serialno ,modulename ,menutype ,menuserial ,displayname ,formname  FROM menumaster"
        'STRQUERY = "SELECT ISNULL(membertype,'') as CATEGORY_CODE,ISNULL(typedesc,'') AS CATEGORY_NAME,ISNULL(ADDDATETIME,'') AS ADDDATETIME,ISNULL(FREEZE,'') AS FREEZE  FROM membertype"
        'gconnection.getDataSet(STRQUERY, "MENUMASTER")
        'Call VIEW1.LOADGRID(gdataset.Tables("MENUMASTER"), False, "MENUMASTER", "SELECT serialno ,modulename ,menutype ,menuserial ,displayname ,formname  FROM menumaster", "SERIALNO", 0)

        brows = True

        Dim VIEW1 As New VIEWHDR
        VIEW1.Show()
        VIEW1.DTGRDHDR.DataSource = Nothing
        VIEW1.DTGRDHDR.Rows.Clear()
        Dim STRQUERY As String
        STRQUERY = "SELECT subtypecode,* FROM SubCategorymaster"
        'STRQUERY = "SELECT isnull(MODULENAME,'')as MODULENAME,isnull(FORMNAME,'') as FORMNAME,isnull(FORMTYPE,'')as FORMTYPE,isnull(AUTHORIZELEVEL,'')as AUTHORIZELEVEL,isnull(AUTH1USER1,'')as AUTH1USER1,isnull(AUTH1USER2,'') as AUTH1USER2,isnull(AUTH2USER1,'')as  AUTH2USER1,isnull(AUTH2USER2,'')as AUTH2USER2,isnull(AUTH3USER1,'')as AUTH3USER1,isnull(AUTH3USER2,'') as AUTH3USER2,isnull(void,'') as void,isnull(ADDUSERID,'')as ADDUSERID,isnull(ADDDATETIME,'')as ADDDATETIME FROM authorize"
        gconnection.getDataSet(STRQUERY, "authorize")

        Call VIEW1.LOADGRID(gdataset.Tables("authorize"), True, gcompanyname, "SELECT * FROM SubCategorymaster", "subtypecode", 1, Me.Txt_subcategorycode)
        'VIEW1.Hide()
        'VIEW1.ShowDialog(Me)
        'If Trim(keyfield & "") <> "" Then
        '    Txt_subcategorycode.Text = Trim(keyfield & "")
        '    Txt_subcategorycode.Select()
        '    Call txt_subcategorycodefill()
        '    VIEW1.Close()
        '    VIEW1 = Nothing
        '    btn_addnew.Text = "Update [F7]"
        'End If
        'gconnection.closeConnection()
    End Sub

    Private Sub chbx_prmyes_KeyDown(sender As Object, e As KeyEventArgs) Handles chbx_prmyes.KeyDown
        If e.KeyCode = Keys.Enter Then
            chbx_prmno.Select()
        End If
    End Sub

    Private Sub chbx_prmno_KeyDown(sender As Object, e As KeyEventArgs) Handles chbx_prmno.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chbx_prmno.Checked = True Then
                chbx_tenyes.Select()
            Else
                chbx_vtrtsyes.Select()
            End If

        End If
    End Sub

    Private Sub chbx_tenyes_KeyDown(sender As Object, e As KeyEventArgs) Handles chbx_tenyes.KeyDown
        If e.KeyCode = Keys.Enter Then
            chbx_tenno.Select()
        End If
    End Sub

    Private Sub chbx_tenno_KeyDown(sender As Object, e As KeyEventArgs) Handles chbx_tenno.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chbx_tenno.Checked = True Then
                chk_applyes.Select()
            Else
                Txt_Validity.Select()
            End If

        End If
    End Sub

    Private Sub chk_applyes_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_applyes.KeyDown
        If e.KeyCode = Keys.Enter Then
            chk_applno.Select()
        End If
    End Sub

    Private Sub chk_applno_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_applno.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chk_applno.Checked = True Then
                chbx_crprty.Select()
            Else
                txt_limit.Select()
            End If

        End If
    End Sub

    Private Sub chbx_crprty_KeyDown(sender As Object, e As KeyEventArgs) Handles chbx_crprty.KeyDown
        If e.KeyCode = Keys.Enter Then
            chbx_crprtn.Select()
        End If
    End Sub

    Private Sub chbx_crprtn_KeyDown(sender As Object, e As KeyEventArgs) Handles chbx_crprtn.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chbx_crprtn.Checked = True Then
                chk_propsryes.Select()
            Else
                txt_nofnomne.Select()
            End If

        End If
    End Sub

    Private Sub chk_propsryes_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_propsryes.KeyDown
        If e.KeyCode = Keys.Enter Then
            chk_propsrno.Select()
        End If
    End Sub

    Private Sub chk_propsrno_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_propsrno.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chk_propsrno.Checked = True Then
                chbx_yescrlmt.Select()
            Else
                txt_noscndr.Select()
            End If

        End If
    End Sub

    Private Sub chbx_yescrlmt_KeyDown(sender As Object, e As KeyEventArgs) Handles chbx_yescrlmt.KeyDown
        If e.KeyCode = Keys.Enter Then
            chbx_nocrlmt.Select()
        End If
    End Sub

    Private Sub chbx_nocrlmt_KeyDown(sender As Object, e As KeyEventArgs) Handles chbx_nocrlmt.KeyDown
        If e.KeyCode = Keys.Enter Then
            If chbx_nocrlmt.Checked = True Then
                DDGRD1.Select()
            Else
                txt_amt.Select()
            End If

        End If
    End Sub

    Private Sub Select_Category_KeyDown(sender As Object, e As KeyEventArgs) Handles Select_Category.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_addnew.Select()
        End If
    End Sub

    Private Sub Select_Category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_Category.SelectedIndexChanged

    End Sub

    Private Sub CheckBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles CheckBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_addnew.Select()
        End If
    End Sub

    Private Sub chk_propsryes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles chk_propsryes.KeyPress

    End Sub

    Private Sub BTN_DOS_Click(sender As Object, e As EventArgs) Handles BTN_DOS.Click
        Dim reportdesign As New ReportDesigner
        gheader = " SUBCATEGORY MASTER VIEW "
        If txt_CategoryCode.Text.Length > 0 Then
            tables = " FROM SubCategorymaster where subtypeCode = '" & Trim(Txt_subcategorycode.Text) & "'"
        Else
            tables = " FROM SubCategorymaster"
        End If
        reportdesign.DataGridView1.ColumnCount = 2
        reportdesign.DataGridView1.Columns(0).Name = "Column Name"
        reportdesign.DataGridView1.Columns(0).Width = 380
        reportdesign.DataGridView1.Columns(1).Name = "Size"
        reportdesign.DataGridView1.Columns(1).Width = 100
        Dim row As String() = New String() {"SubtypeCode", "10"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"Subtypedesc", "35"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"Typecode", "15"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"Creditlimit", "15"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"Freeze", "10"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"AddUserId", "10"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"Adddatetime", "15"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"Upd_User", "10"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"Upd_Date", "15"}
        ' reportdesign.DataGridView1.Rows.Add(row)
        ' row = New String() {"TypeCode", "25"}
        reportdesign.DataGridView1.Rows.Add(row)
        Dim chk As New DataGridViewCheckBoxColumn()
        reportdesign.DataGridView1.Columns.Insert(0, chk)
        chk.HeaderText = "Check"
        chk.Name = "chk"
        reportdesign.BUT_GEN_VIEW.Select()
        reportdesign.ShowDialog(Me)
    End Sub

    Private Sub BTN_EXIT_GR3_Click(sender As Object, e As EventArgs) Handles BTN_EXIT_GR3.Click
        GR3.Visible = False
        Txt_subcategorycode.Focus()
    End Sub

    Private Sub BTN_WINDOWS_Click(sender As Object, e As EventArgs) Handles BTN_WINDOWS.Click
        Dim txtobj1 As TextObject
        Dim Viewer As New REPORTVIEWER
        SqlString = "select * from VIEW_SubCategorymaster"
        If Txt_subcategorycode.Text = "" Then
            SqlString = SqlString & ""
        Else
            SqlString = SqlString & " WHERE SUBTYPECODE ='" & Txt_subcategorycode.Text & "' "
        End If
        Dim r As New Cry_Subcategorymaster
        gconnection.getDataSet(SqlString, "VIEW_SubCategorymaster")
        If gdataset.Tables("VIEW_SubCategorymaster").Rows.Count > 0 Then
            Viewer.TableName = "VIEW_SubCategorymaster"
            Call Viewer.GetDetails(SqlString, "VIEW_SubCategorymaster", r)
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
            txtobj1 = r.ReportDefinition.ReportObjects("Text21")
            txtobj1.Text = UCase(gCompanyAddress(4))
            txtobj1 = r.ReportDefinition.ReportObjects("Text23")
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
End Class