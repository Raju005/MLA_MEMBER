Imports System.Drawing.Font
Imports CrystalDecisions.CrystalReports.Engine
Public Class frm_mkga_categorymaster
    Public freezeflg As String
    Public SqlString As String
    Dim boolchk, datachk As Boolean
    Dim gconnection As New GlobalClass
    Public chstr As String

    Private Sub frm_mkga_categorymaster_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
                    gr2.Visible = True
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
    Private Sub frm_mkga_categorymaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Call Resize_Form()
        'btn_addnew.Font = New Font(btn_addnew.Font, FontStyle.Underline)
        categorybool = True
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        apppath = Application.StartupPath
        Lbl_freeze.Visible = False
        Call GetServe()
        txt_Categorycode.Select()
        gr2.Visible = False

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
    '            If TypeOf .Controls(i_i) Is GroupBox Then


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
                        If Controls(i_i).Name = "btn_clear" Or Controls(i_i).Name = "btn_addnew" Or Controls(i_i).Name = "btn_freeze" Or Controls(i_i).Name = "btn_view" Or Controls(i_i).Name = "Cmd_Print" Or Controls(i_i).Name = "browse" Or Controls(i_i).Name = "btn_exit" Or Controls(i_i).Name = "btn_authorize" Then
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



    Private Sub btn_addnew_Click(sender As Object, e As EventArgs)
        ' Dim subcode, subdesc As String
        Try
            If btn_addnew.Text = "Add [F7]" Then
                Call checkValidation()
                If boolchk = False Then Exit Sub
                SqlString = "INSERT INTO MEMBERTYPE"
                SqlString = SqlString & "(Membertype,TypeDesc,AddUserId,AddDatetime,void) VALUES ('" & txt_Categorycode.Text & "', '"
                SqlString = SqlString & txt_CategoryName.Text & "','" & gUsername & "' ,'" & Format(Date.Now, "dd-MMM-yyyy HH:mm") & "','N')"
                gconnection.closeconnection()
                gconnection.dataOperation(1, SqlString, "MemberType")
                MessageBox.Show("Record Added Successfully ", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                btn_clear_Click(sender, e)
            ElseIf btn_addnew.Text = "Update [F7]" Then
                Call checkValidation1()
                If Mid(Me.btn_addnew.Text, 1, 1) = "U" Then
                    If Me.Lbl_freeze.Visible = True Then
                        MsgBox(" The Voided Record Can Not Be Update", , gcompanyname)
                        boolchk = False
                    End If
                End If
                If boolchk = False Then Exit Sub
                SqlString = "UPDATE  MemberType SET TYPEDESC = '"
                SqlString = SqlString & txt_CategoryName.Text & "',"
                'SqlString = SqlString & "CATMEMLIMIT ='" & txt_limit.Text
                SqlString = SqlString & "UPD_USER ='" & gUsername
                SqlString = SqlString & "',UPD_DATE='" & Format(Date.Now, "dd-MMM-yyyy HH:mm") & "',void = 'N'"
                SqlString = SqlString & " WHERE MEMBERTYPE = '" & txt_Categorycode.Text & "'"
                gconnection.dataOperation(2, SqlString, "membertype")
                gconnection.closeconnection()
                SqlString = "INSERT INTO MEMBERTYPE_log"
                SqlString = SqlString & "(Membertype,TypeDesc,AddUser,AddDate,Freeze,UPD_USER,UPD_DATE,void,VOIDUSER,VOIDDATE) VALUES ('" & txt_Categorycode.Text & "', '"
                SqlString = SqlString & txt_CategoryName.Text & "','" & gUsername & "' ,'" & Format(Date.Now, "dd-MMM-yyyy HH:mm") & "','N','" & gUsername & "' ,'" & Format(Date.Now, "dd-MMM-yyyy HH:mm") & "','N','" & gUsername & "' ,'" & Format(Date.Now, "dd-MMM-yyyy HH:mm") & "')"
                gconnection.closeconnection()
                gconnection.dataOperation(1, SqlString, "MemberType")
                MessageBox.Show("Record Updated Successfully ", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                btn_clear_Click(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show("Error in Retriveing records : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.btn_clear_Click(sender, e)
        Finally
            ' btn_clear_Click(sender, e)
        End Try
    End Sub


    Private Sub btn_clear_Click(sender As Object, e As EventArgs)
        txt_Categorycode.ReadOnly = False
        txt_Categorycode.Select()
        txt_Categorycode.Text = ""
        txt_CategoryName.ReadOnly = False
        txt_CategoryName.Text = ""
        txt_limit.Text = ""
        'Lbl_freeze.Text = ""
        Me.Lbl_freeze.Visible = False
        ' Me.txt_Categorycode.Enabled = True
        'Me.txt_Categorycode.Focus()
        Me.btn_addnew.Text = "Add [F7]"
        Me.btn_freeze.Text = "Void [F8]"
        Lbl_freeze.Text = "Record Voided  On "
        gr2.Visible = False
    End Sub
    Public Sub checkValidation()
        boolchk = False

        ' Check Category Code is blank
        If txt_Categorycode.Text = "" Then
            MessageBox.Show(" Category Code can't be blank ", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Categorycode.Focus()
            Exit Sub
        End If
        'Check Category Name is blank
        If txt_CategoryName.Text = "" Then
            MessageBox.Show(" Category Name can't be blank ", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_CategoryName.Focus()
            Exit Sub
        End If


        ' ''mohan hided bengal club 06-08-2013
        ' ''If txt_limit.Text = "" Then
        ' ''    MessageBox.Show(" Yearly Limit can't be blank ", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ' ''    txt_limit.Focus()
        ' ''    Exit Sub
        ' ''End If



        datachk = False
        Dim MEMBERTYPE, MEMBERTYPE1 As New DataTable
        Dim STRQUERY As String
        STRQUERY = " select distinct(subtypeCode)  from   subcategorymaster where typeCode='" & Trim(txt_Categorycode.Text) & "' and freeze='N'"
        MEMBERTYPE = gconnection.GetValues(STRQUERY)

        If MEMBERTYPE.Rows.Count > 0 Or MEMBERTYPE1.Rows.Count > 0 Then
            datachk = True
        End If





        If datachk = True Then
            txt_CategoryName.ReadOnly = True
            MessageBox.Show("Category is Already used in Subcategory Details So it cant be Change", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            datachk = False
            boolchk = False
            Exit Sub
        End If










        boolchk = True
    End Sub

    Public Sub checkValidation1()
        boolchk = False

        ' Check Category Code is blank
        If txt_Categorycode.Text = "" Then
            MessageBox.Show(" Category Code can't be blank ", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Categorycode.Focus()
            Exit Sub
        End If
        'Check Category Name is blank
        If txt_CategoryName.Text = "" Then
            MessageBox.Show(" Category Name can't be blank ", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_CategoryName.Focus()
            Exit Sub
        End If


        ' ''mohan hided bengal club 06-08-2013
        ''If txt_limit.Text = "" Then
        ''    MessageBox.Show(" Category Name can't be blank ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ''    txt_limit.Focus()
        ''    Exit Sub
        ''End If
        datachk = False
        Dim MEMBERTYPE, MEMBERTYPE1 As New DataTable
        Dim STRQUERY As String
        STRQUERY = " select distinct(subtypeCode)  from   subcategorymaster where typeCode='" & Trim(txt_Categorycode.Text) & "' and freeze='N'"
        MEMBERTYPE = gconnection.GetValues(STRQUERY)

        If MEMBERTYPE.Rows.Count > 0 Or MEMBERTYPE1.Rows.Count > 0 Then
            datachk = True
        End If
        If datachk = True Then
            txt_CategoryName.ReadOnly = True
            MessageBox.Show("Category is Already used in Subcategory Details So it cant be Change", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            datachk = False
            boolchk = False
            Exit Sub
        End If

        boolchk = True
    End Sub

    Private Sub txt_Categorycode_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Categorycode.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_Categorycode.Text = "" Then
                Call Btn_help_Click(sender, e)
            ElseIf txt_Categorycode.Text <> "" Then
                Call CategorycodeFILL()
            End If
        ElseIf e.KeyCode = Keys.F4 Then
            Call Btn_help_Click(sender, e)
        End If
    End Sub

    Private Sub Btn_help_Click(sender As Object, e As EventArgs) Handles Btn_help.Click
        Dim vform As New LIST_OPERATION1
        gSQLString = "Select  MEMBERTYPE,TYPEDESC  from membertype"
        M_WhereCondition = " "
        '  M_WhereCondition1 = " "
        vform.Field = "MEMBERTYPE,TYPEDESC"
        vform.vCaption = "Category Master Help"
        vform.TXT_SEARCH_TXT.Select()
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_Categorycode.Text = Trim(vform.keyfield & "")
            txt_Categorycode.Select()
            vform.TXT_SEARCH_TXT.Select()
            Me.CategorycodeFILL()
            txt_CategoryName.Focus()
            vform.Close()
            vform = Nothing
            btn_addnew.Text = "Update [F7]"
        End If
        gconnection.closeconnection()
    End Sub
    Private Sub btn_freeze_Click(sender As Object, e As EventArgs)
        Call checkValidation1()
        If boolchk = False Then Exit Sub
        If Mid(Me.btn_freeze.Text, 1, 1) = "V" And Mid(Me.btn_addnew.Text, 1, 1) = "U" Then
            SqlString = "UPDATE  MemberType"
            SqlString = SqlString & " SET VOID= 'Y',VOIDUSER='" & gUsername & " ', VOIDDATE='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
            SqlString = SqlString & " WHERE membertype = '" & txt_Categorycode.Text & " '"
            gconnection.dataOperation(3, SqlString, "MemberType")
            gconnection.closeconnection()

            SqlString = "INSERT INTO MEMBERTYPE_log"
            SqlString = SqlString & "(Membertype,TypeDesc,catmemlimit,AddUser,AddDate,Freeze,UPD_USER,UPD_DATE,VOID,VOIDUSER,VOIDDATE) VALUES ('" & txt_Categorycode.Text & "', '"
            SqlString = SqlString & txt_CategoryName.Text & "','" & txt_limit.Text & "','" & gUsername & "' ,'" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "','Y','" & gUsername & "' ,'" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "','Y','" & gUsername & "' ,'" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "')"
            gconnection.dataOperation(3, SqlString, "MemberType_log")
            gconnection.closeconnection()

            MessageBox.Show("Record Voided Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.btn_clear_Click(sender, e)
            btn_addnew.Text = "Add [F7]"
        ElseIf Mid(Me.btn_freeze.Text, 1, 1) = "U" And Mid(Me.btn_addnew.Text, 1, 1) = "U" Then
            MsgBox("This Unvoid Process Can't Proceed")
            '    SqlString = "UPDATE  MemberType "
            '    SqlString = SqlString & " SET VOID= 'N',VOIDUSER='" & gUsername & " ', VOIDDATE='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
            '    SqlString = SqlString & " WHERE membertype = '" & txt_Categorycode.Text & " '"
            '    gconnection.dataOperation(4, SqlString, "MemberType")
            '    gconnection.closeConnection()

            '    SqlString = "INSERT INTO MEMBERTYPE_log"
            '    SqlString = SqlString & "(Membertype,TypeDesc,catmemlimit,AddUser,AddDate,Freeze,UPD_USER,UPD_DATE,VOID,VOIDUSER,VOIDDATE) VALUES ('" & txt_Categorycode.Text & "', '"
            '    SqlString = SqlString & txt_CategoryName.Text & "','" & txt_limit.Text & "','" & gUsername & "' ,'" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "','N','" & gUsername & "' ,'" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "','N','" & gUsername & "' ,'" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "')"
            '    gconnection.dataOperation(3, SqlString, "MemberType_log")
            '    gconnection.closeConnection()


            '    'SqlString = "UPDATE  MemberType_log"
            '    'SqlString = SqlString & " SET Freeze= 'N',AddUser='" & gUsername & " ', AddDate='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
            '    'gconnection.dataOperation(3, SqlString, "MemberType")
            '    'gconnection.closeConnection()
            '    MessageBox.Show("Record UnFreezed Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Me.btn_clear_Click(sender, e)
            '    btn_addnew.Text = "Add [F7]"
        Else
            MsgBox("The Record is not found ")

        End If


    End Sub
    Private Sub GetRights()
        Dim i, x As Integer
        Dim M1 As New MainMenu
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

    Private Sub btn_view_Click(sender As Object, e As EventArgs)
        Dim reportdesign As New ReportDesigner
        gheader = " MASTER VIEW "
        If txt_Categorycode.Text.Length > 0 Then
            tables = " FROM MEMBERTYPE where MEMBERTYPE = '" & Trim(txt_Categorycode.Text) & "'"
        Else
            tables = " FROM MEMBERTYPE"
        End If
        reportdesign.DataGridView1.ColumnCount = 2
        reportdesign.DataGridView1.Columns(0).Name = "Column Name"
        reportdesign.DataGridView1.Columns(0).Width = 380
        reportdesign.DataGridView1.Columns(1).Name = "Size"
        reportdesign.DataGridView1.Columns(1).Width = 100
        Dim row As String() = New String() {"Membertype", "10"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"Typedesc", "35"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"Void", "6"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"AddUserId", "15"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"AddDateTime", "15"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"Upd_User", "15"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"Upd_Date", "15"}
        reportdesign.DataGridView1.Rows.Add(row)
        Dim chk As New DataGridViewCheckBoxColumn()
        chk.HeaderText = "Check"
        chk.Name = "chk"
        reportdesign.DataGridView1.Columns.Insert(0, chk)
        reportdesign.BUT_GEN_VIEW.Select()
        reportdesign.ShowDialog(Me)
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub CategorycodeFILL()
        If Trim(txt_Categorycode.Text) <> "" Then
            Dim MEMBERTYPE As New DataTable
            Dim STRQUERY As String
            Dim freezeflag As String
            STRQUERY = "SELECT ISNULL(membertype,'') as CATEGORY_CODE,ISNULL(typedesc,'') AS CATEGORY_NAME,ISNULL(catmemlimit,0) AS CATEGORY_MEMBERLIMIT,ISNULL(ADDDATETIME,'') AS ADDDATETIME,ISNULL(VOID,'') AS VOID,ISNULL(VOIDDATE,'') AS  VOIDDATE  FROM membertype  WHERE membertype='" & Trim(txt_Categorycode.Text) & "'"
            MEMBERTYPE = gconnection.GetValues(STRQUERY)
            If MEMBERTYPE.Rows.Count > 0 Then
                txt_Categorycode.ReadOnly = True
                txt_CategoryName.Text = MEMBERTYPE.Rows(0).Item("CATEGORY_NAME")
                txt_limit.Text = MEMBERTYPE.Rows(0).Item("CATEGORY_MEMBERLIMIT")
                freezeflag = MEMBERTYPE.Rows(0).Item("VOID")
                ' txt_CategoryName.ReadOnly = True
                btn_addnew.Text = "Update [F7]"
                If freezeflag = "Y" Then
                    Lbl_freeze.Visible = True
                    Lbl_freeze.Text = "Record Voided On "
                    Me.Lbl_freeze.Text = Me.Lbl_freeze.Text & Format(MEMBERTYPE.Rows(0).Item("VOIDDATE"), "dd-MMM-yyyy")
                    btn_freeze.Text = "UnVoid [F8]"
                Else
                    Lbl_freeze.Visible = False
                    btn_freeze.Text = "Void [F8]"
                End If
                Dim MEMBERTYPE1 As New DataTable
                STRQUERY = " select distinct(subtypeCode)  from   subcategorymaster where typeCode='" & Trim(txt_Categorycode.Text) & "' and freeze='N'"
                MEMBERTYPE = gconnection.GetValues(STRQUERY)

                If MEMBERTYPE.Rows.Count > 0 Or MEMBERTYPE1.Rows.Count > 0 Then
                    datachk = True
                Else
                    datachk = False
                End If
                If datachk = True Then
                    txt_CategoryName.ReadOnly = True
                    ' MessageBox.Show("Category is Already used in Subcategory Details So it cant be Change", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If
            If gUserCategory <> "S" Then
                Call GetRights()
            Else
                txt_CategoryName.Select()
            End If

        End If
    End Sub

    Private Sub txt_Categorycode_Validated(sender As Object, e As EventArgs) Handles txt_Categorycode.Validated


    End Sub

    Private Sub btn_authorize_Click(sender As Object, e As EventArgs)
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
            SSQLSTR2 = " SELECT * FROM MEMBERTYPE WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER1,'')=''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH1USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH1USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE")
                If gdataset.Tables("AUTHORIZE").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND ISNULL(AUTHORIZELEVEL,0)>0 "
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM MEMBERTYPE WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER1,'')=''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()


                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE MEMBERTYPE set  ", "MEMBERTYPE", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 1, 1)
                        End If
                    Else
                        MsgBox("NO AUTHORIZATION REQUIRED FOR THE ENTRY")
                    End If
                End If
            End If
        ElseIf USERT = 2 Then
            SSQLSTR2 = " SELECT * FROM MEMBERTYPE WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')='' AND ISNULL(AUTHORISE_USER1,'')<>''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH2USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH2USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE1")
                If gdataset.Tables("AUTHORIZE1").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "'"
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM MEMBERTYPE WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')=''AND ISNULL(AUTHORISE_USER1,'')<>''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()


                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE MEMBERTYPE set  ", "MEMBERTYPE", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 2, 1)
                        End If
                    End If
                End If
            End If
        ElseIf USERT = 3 Then
            SSQLSTR2 = " SELECT * FROM MEMBERTYPE WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')=''AND ISNULL(AUTHORISE_USER1,'')<>''  AND ISNULL(AUTHORISE_USER2,'')<>''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH3USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH3USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE2")
                If gdataset.Tables("AUTHORIZE2").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "'"
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM MEMBERTYPE WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')=''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()
                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE MEMBERTYPE set  ", "MEMBERTYPE", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 3, 1)
                        End If
                    End If
                End If
            Else
                MsgBox("U R NOT ELIGIBLE TO AUTHORISE IN ANY LEVEL", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub txt_CategoryName_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_CategoryName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_limit.Select()
        End If
    End Sub

    Private Sub txt_CategoryName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_CategoryName.KeyPress
        getCharater(e)
    End Sub

    Private Sub browse_Click(sender As Object, e As EventArgs)
        'Dim VIEW1 As New VIEWHDR
        'VIEW1.Show()
        'VIEW1.DTGRDHDR.DataSource = Nothing
        'VIEW1.DTGRDHDR.Rows.Clear()
        'Dim STRQUERY As String
        ''STRQUERY = "SELECT serialno ,modulename ,menutype ,menuserial ,displayname ,formname  FROM menumaster"
        'STRQUERY = "SELECT ISNULL(membertype,'') as CATEGORY_CODE,ISNULL(typedesc,'') AS CATEGORY_NAME,ISNULL(ADDDATETIME,'') AS ADDDATETIME,ISNULL(FREEZE,'') AS FREEZE  FROM membertype"
        'gconnection.getDataSet(STRQUERY, "MENUMASTER")
        'Call VIEW1.LOADGRID(gdataset.Tables("MENUMASTER"), False, "MENUMASTER", "SELECT serialno ,modulename ,menutype ,menuserial ,displayname ,formname  FROM menumaster", "SERIALNO", 0)







        'Dim brovse As New browse
        'brovse.DTGRD.DataSource = Nothing
        'brovse.DTGRD.Rows.Clear()
        'Dim STRQUERY As String
        'If Trim(Search) = " " Then
        '    M_WhereCondition = ""
        'Else
        '    M_WhereCondition = ""
        'End If
        'gSQLString = "SELECT ISNULL(MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(TYPEDESC,'') AS TYPEDESC,ISNULL(MEMLIMIT,0) AS MEMLIMIT,ISNULL(ADDDATETIME,'') AS ADDDATETIME,ISNULL(FREEZE,'') AS FREEZE  FROM membertype"
        'gconnection.getDataSet(gSQLString, "MENUMASTER")
        'If gdataset.Tables("MENUMASTER").Rows.Count > 0 Then
        '    ' For I = 0 To gdataset.Tables("MENUMASTER").Rows.Count - 1
        '    'brovse.DTGRD.Rows.Add()
        '    Call brovse.LOADGRID(gdataset.Tables("MENUMASTER"), False, "MENUMASTER", "SELECT  ISNULL(MEMBERTYPE,''),ISNULL(TYPEDESC,''),ISNULL(MEMLIMIT,0)  FROM membertype")
        '    'DTGRD.Rows(I).Cells(0).Value = gdataset.Tables("MENUMASTER").Rows(I).Item(0).ToString
        '    'DTGRD.Rows(I).Cells(1).Value = gdataset.Tables("MENUMASTER").Rows(I).Item(1).ToString
        '    'DTGRD.Rows(I).Cells(2).Value = gdataset.Tables("MENUMASTER").Rows(I).Item(2).ToString
        '    'DTGRD.Rows(I).Cells(3).Value = gdataset.Tables("MENUMASTER").Rows(I).Item(3).ToString
        '    'DTGRD.Rows(I).Cells(4).Value = gdataset.Tables("MENUMASTER").Rows(I).Item(4).ToString
        '    'DTGRD.Rows(I).Cells(5).Value = gdataset.Tables("MENUMASTER").Rows(I).Item(5).ToString
        '    ' Next

        '    brovse.ShowDialog(Me)
        'End If



        brows = True
        Dim VIEW1 As New VIEWHDR
        VIEW1.Show()
        VIEW1.DTGRDHDR.DataSource = Nothing
        VIEW1.DTGRDHDR.Rows.Clear()
        Dim STRQUERY As String
        STRQUERY = "SELECT MEMBERTYPE,* FROM MEMBERTYPE"
        'STRQUERY = "SELECT isnull(MODULENAME,'')as MODULENAME,isnull(FORMNAME,'') as FORMNAME,isnull(FORMTYPE,'')as FORMTYPE,isnull(AUTHORIZELEVEL,'')as AUTHORIZELEVEL,isnull(AUTH1USER1,'')as AUTH1USER1,isnull(AUTH1USER2,'') as AUTH1USER2,isnull(AUTH2USER1,'')as  AUTH2USER1,isnull(AUTH2USER2,'')as AUTH2USER2,isnull(AUTH3USER1,'')as AUTH3USER1,isnull(AUTH3USER2,'') as AUTH3USER2,isnull(void,'') as void,isnull(ADDUSERID,'')as ADDUSERID,isnull(ADDDATETIME,'')as ADDDATETIME FROM authorize"
        gconnection.getDataSet(STRQUERY, "authorize")

        Call VIEW1.LOADGRID(gdataset.Tables("authorize"), True, gcompanyname, "SELECT MEMBERTYPE,* FROM MEMBERTYPE", "MEMBERTYPE", 1, Me.txt_Categorycode)
        'VIEW1.Hide()
        'VIEW1.ShowDialog(Me)
        'If Trim(keyfield & "") <> "" Then
        '    txt_Categorycode.Text = Trim(keyfield & "")
        '    txt_Categorycode.Select()
        '    Me.CategorycodeFILL()
        '    txt_CategoryName.Focus()
        '    btn_addnew.Text = "Update [F7]"
        'End If
        'gconnection.closeConnection()








    End Sub





    Private Sub txt_Categorycode_TextChanged(sender As Object, e As EventArgs) Handles txt_Categorycode.TextChanged
        If brows = True Then
            Call Me.CategorycodeFILL()
        End If
    End Sub

    Private Sub txt_Categorycode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Categorycode.KeyPress
        getAlphanumeric(e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim txtobj1 As TextObject
        'Dim Viewer As New REPORTVIEWER
        'Dim r As New Cry_categorymaster
        'SqlString = "select ISNULL(MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(TYPEDESC,'') AS TYPEDESC,ISNULL(FREEZE,'') AS FREEZE  from membertype where ISNULL(FREEZE,'')='N'"
        'Call Viewer.GetDetails1(SqlString, "MM_CATEGORYMASTER", r)
        'txtobj1 = r.ReportDefinition.ReportObjects("Text4")
        'txtobj1.Text = UCase(gCompanyname)
        'txtobj1 = r.ReportDefinition.ReportObjects("Text5")
        'txtobj1.Text = UCase(gCompanyAddress(1))
        'txtobj1 = r.ReportDefinition.ReportObjects("Text6")
        'txtobj1.Text = UCase(gCompanyAddress(2))
        'txtobj1 = r.ReportDefinition.ReportObjects("Text7")
        ''txtobj1.Text = UCase(gCompanyAddress(3))
        ''txtobj1 = r.ReportDefinition.ReportObjects("Text13")
        'txtobj1.Text = UCase(gUsername)
        'Viewer.Show()



        'Dim txtobj1 As TextObject
        ' Dim Viewer As New ReportViwer
        ' Dim r As New Cry_categorymaster
        ' ' If Chk_freeze.Checked = True Then
        ' '   SqlString = "select * from membertype where freeze='Y'"
        ' ' Else
        ' SqlString = "select * from membertype where freeze='N'"
        ' '  End If
        ' Call Viewer.GetDetails1(SqlString, "MM_CATEGORYMASTER", r)
        ' txtobj1 = r.ReportDefinition.ReportObjects("Text6")
        ' txtobj1.Text = UCase(gCompanyname)
        ' txtobj1 = r.ReportDefinition.ReportObjects("Text7")
        ' txtobj1.Text = UCase(gCompanyAddress(1))
        ' txtobj1 = r.ReportDefinition.ReportObjects("Text9")
        ' txtobj1.Text = UCase(gCompanyAddress(2))
        ' txtobj1 = r.ReportDefinition.ReportObjects("Text8")
        ' txtobj1.Text = UCase(gCompanyAddress(3))
        ' txtobj1 = r.ReportDefinition.ReportObjects("Text13")
        ' txtobj1.Text = UCase(gUsername)
        ' Viewer.Show()








    End Sub

    Private Sub txt_CategoryName_TextChanged(sender As Object, e As EventArgs) Handles txt_CategoryName.TextChanged

    End Sub

    Private Sub txt_limit_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_limit.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_addnew.Select()
        End If
    End Sub

    Private Sub txt_limit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_limit.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                e.Handled = True
                ' MsgBox(" Numbers only ")
            End If
        End If

    End Sub

    Private Sub txt_limit_TextChanged(sender As Object, e As EventArgs) Handles txt_limit.TextChanged

    End Sub






    Private Sub btn_clear_Click_1(sender As Object, e As EventArgs) Handles btn_clear.Click
        Me.btn_clear_Click(sender, e)
    End Sub

    Private Sub btn_addnew_Click_1(sender As Object, e As EventArgs) Handles btn_addnew.Click
        Me.btn_addnew_Click(sender, e)
    End Sub

    Private Sub btn_freeze_Click_1(sender As Object, e As EventArgs) Handles btn_freeze.Click
        Me.btn_freeze_Click(sender, e)
    End Sub

    Private Sub btn_view_Click_1(sender As Object, e As EventArgs) Handles btn_view.Click
        gr2.Visible = True
    End Sub

    Private Sub browse_Click_1(sender As Object, e As EventArgs) Handles browse.Click
        Me.browse_Click(sender, e)
    End Sub

    Private Sub btn_authorize_Click_1(sender As Object, e As EventArgs) Handles btn_authorize.Click
        Me.btn_authorize_Click(sender, e)
    End Sub

    Private Sub btn_exit_Click_1(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.btn_exit_Click(sender, e)
    End Sub


    Private Sub btn_dos_Click(sender As Object, e As EventArgs) Handles btn_dos.Click
        Me.btn_view_Click(sender, e)
    End Sub

    Private Sub btn_exit_gr2_Click(sender As Object, e As EventArgs) Handles btn_exit_gr2.Click
        gr2.Visible = False
        txt_Categorycode.Focus()
    End Sub

    Private Sub btn_windows_Click(sender As Object, e As EventArgs) Handles btn_windows.Click
        Dim txtobj1 As TextObject
        Dim Viewer As New REPORTVIEWER
        Dim r As New Cry_categorymaster
        SqlString = "select * from membertype "
        If txt_Categorycode.Text = "" Then
            SqlString = SqlString & ""
        Else
            SqlString = SqlString & " where Membertype = '" & txt_Categorycode.Text & "' "
        End If
        gconnection.getDataSet(SqlString, "view_CorporateMaster")
        If gdataset.Tables("view_CorporateMaster").Rows.Count > 0 Then
            Call Viewer.GetDetails(SqlString, "membertype", r)
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
End Class