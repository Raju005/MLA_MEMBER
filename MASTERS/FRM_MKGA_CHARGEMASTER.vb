Imports CrystalDecisions.CrystalReports.Engine
Public Class FRM_MKGA_CHARGEMASTER
    Inherits System.Windows.Forms.Form
    Dim boolchk As Boolean
    Dim status, code, chargecode As String
    Dim gconnection As New GlobalClass
    Dim loopindex As Long
    Dim accode, ACCDESC As String
    Dim sqlstring, TempString(3) As String
    Dim TAXCODE, TAXNAME, TAXPERSENT As String
    Dim subscode, subsdesc As String

    Private Sub FRM_MKGA_CHARGEMASTER_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.F7 Then
                If cmd_Add.Enabled = True Then
                    Call cmd_Add_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F6 Then
                If cmd_Clear.Enabled = True Then
                    Call cmd_Clear_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F8 Then
                If cmd_Freeze.Enabled = True Then
                    Call cmd_Freeze_Click(sender, e)
                    Exit Sub
                End If

            ElseIf e.KeyCode = Keys.F9 Then
                If cmd_View.Enabled = True Then
                    'Call cmd_View_Click(sender, e)
                    Gr2.Visible = True
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
                If Button4.Enabled = True Then
                    Call Button4_Click(sender, e)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub

    Private Sub FRM_MKGA_CHARGEMASTER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImageLayout = ImageLayout.Stretch

        Call Resize_Form()

        CHARGEDESC.Select()
        Me.lbl_freeze.Visible = False
        Me.lbl_freeze.Text = "Record Freezed  On "
        Me.cmd_Freeze.Text = "Void[F8]"
        cmd_Add.Text = "Add[F7]"
        CHARGEDESC.ReadOnly = False
        Textname.ReadOnly = False
        Call FillItemTypeMaster()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        Textrate.Text = "0.00"
        Textrate.ReadOnly = False
        Call FILLTAX()
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
                        If Controls(i_i).Name = "GroupBox3" Then
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
                        If Controls(i_i).Name = "GroupBox3" Then
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
        Me.cmd_Add.Enabled = True

        Me.cmd_Freeze.Enabled = True

        cmd_View.Enabled = True

        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.cmd_Add.Enabled = True
                    Me.cmd_Freeze.Enabled = True
                    Me.cmd_View.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.cmd_Add.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.cmd_Add.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.cmd_Add.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    Me.cmd_Freeze.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.cmd_View.Enabled = True
                End If
            Next
        End If
    End Sub
    Private Sub FILLTAX()

        Dim dt As DataTable
        List_Tax.Items.Clear()
        sqlstring = "SELECT distinct TAXCODE+'-->'+TAXPERCENTAGE+'-->'+TAXON as TAXPERCENTAGE FROM ITEMTYPEMASTER"
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            List_Tax.Items.Add(dt.Rows(Itration).Item("TAXPERCENTAGE"))
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        brows = True

        Dim VIEW1 As New VIEWHDR
        VIEW1.Show()
        VIEW1.DTGRDHDR.DataSource = Nothing
        VIEW1.DTGRDHDR.Rows.Clear()
        Dim STRQUERY As String
        STRQUERY = "SELECT * FROM chargemaster"
        'STRQUERY = "SELECT isnull(MODULENAME,'')as MODULENAME,isnull(FORMNAME,'') as FORMNAME,isnull(FORMTYPE,'')as FORMTYPE,isnull(AUTHORIZELEVEL,'')as AUTHORIZELEVEL,isnull(AUTH1USER1,'')as AUTH1USER1,isnull(AUTH1USER2,'') as AUTH1USER2,isnull(AUTH2USER1,'')as  AUTH2USER1,isnull(AUTH2USER2,'')as AUTH2USER2,isnull(AUTH3USER1,'')as AUTH3USER1,isnull(AUTH3USER2,'') as AUTH3USER2,isnull(void,'') as void,isnull(ADDUSERID,'')as ADDUSERID,isnull(ADDDATETIME,'')as ADDDATETIME FROM authorize"
        gconnection.getDataSet(STRQUERY, "authorize")

        Call VIEW1.LOADGRID(gdataset.Tables("authorize"), True, gcompanyname, "SELECT * FROM chargemaster", "Code", 1, Me.CHARGEDESC)
        'VIEW1.Hide()
        'VIEW1.ShowDialog(Me)
        'If Trim(keyfield & "") <> "" Then
        '    CHARGEDESC.Text = Trim(keyfield & "")
        '    CHARGEDESC.Select()
        '    Me.txt_feeldFILL()
        '    '  DDGRD1.Select()
        '    cmd_Add.Text = "Update [F7]"
        'End If
        'gconnection.closeConnection()


    End Sub
    Private Sub txt_feeldFILL()
        Try
            Dim I, J As Integer
            Dim MEMBERTYPE As DataTable
            Dim Sqlstr As String
            If CHARGEDESC.Text <> "" Then
                Sqlstr = "select chargecode,chargedesc,rate,taxtypecode,taxtypedesc from chargemaster WHERE chargecode='" & Trim(CHARGEDESC.Text) & "'"
                gconnection.getDataSet(Sqlstr, "chargemaster")
                If gdataset.Tables("Master").Rows.Count > 0 Then
                    CHARGEDESC.ReadOnly = True
                    Textname.Text = gdataset.Tables("chargemaster").Rows(0).Item("chargedesc")
                    Textname.Text = gdataset.Tables("chargemaster").Rows(0).Item("rate")
                    ChkList_ItemType.Text = gdataset.Tables("chargemaster").Rows(0).Item("taxtypecode")
                    ChkList_ItemTypeDet.Text = gdataset.Tables("chargemaster").Rows(0).Item("taxtypedesc")
                    Me.lbl_freeze.Visible = True
                    Me.lbl_freeze.Text = Me.lbl_freeze.Text & Format(gdataset.Tables("Master").Rows(0).Item("voiddate"), "dd-MMM-yyyy")
                    Me.lbl_freeze.Text = "Void[F8]"
                Else
                    Me.lbl_freeze.Visible = False
                    Me.lbl_freeze.Text = "Record Voided  On "
                    Me.lbl_freeze.Text = "Void[F8]"
                End If
                Me.cmd_Add.Text = "Update[F7]"
            Else
                CHARGEDESC.Text = ""
            End If

        Catch ex As Exception
            '  MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub cmd_Add_Click(sender As Object, e As EventArgs) Handles cmd_Add.Click
        Dim ADDUSER As String
        Dim ADDDATE As DateTime
        Try
            Call checkValidation() '''--->CHECK VALIDATION
            If boolchk = False Then Exit Sub
            If cmd_Add.Text = "Add[F7]" Then
                For i = 0 To ChkList_ItemType.Items.Count - 1
                    If ChkList_ItemType.GetItemChecked(i) = True Then
                        TempString = Split(ChkList_ItemType.Items.Item(i), "->")
                        subscode = Trim(TempString(0))
                        subsdesc = Trim(TempString(1))

                        sqlstring = "INSERT INTO  chargemaster "
                        sqlstring = sqlstring & "(CHARGECODE,CHARGEDESC,TAXTYPECODE,TAXTYPEDESC,RATE,ADDUSER,ADDDATETIME) VALUES ('" & Trim(CHARGEDESC.Text) & " ' ,'" & Trim(Textname.Text) & "','" & _
                       subscode & " ','" & subsdesc & "','" & Trim(Textrate.Text) & " ','" & gUsername & "','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "')"
                        subscode = ""
                        subsdesc = ""
                        cmd_Add.Text = "Update[F7]"
                        gconnection.dataOperation(2, sqlstring, "chargemaster")
                        'End If
                    Else
                        sqlstring = "INSERT INTO  chargemaster "
                        sqlstring = sqlstring & "(CHARGECODE,CHARGEDESC,TAXTYPECODE,TAXTYPEDESC,RATE,ADDUSER,ADDDATETIME) VALUES ('" & Trim(CHARGEDESC.Text) & " ' ,'" & Trim(Textname.Text) & "','" & _
                       subscode & " ','" & subsdesc & "','" & Trim(Textrate.Text) & " ','" & gUsername & "','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "')"
                        subscode = ""
                        subsdesc = ""
                        gconnection.dataOperation(2, sqlstring, "chargemaster")
                        cmd_Add.Text = "Update[F7]"
                    End If

                Next i
                If gcommit = True Then
                    MessageBox.Show("Record Saved Successfully ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ''cmd_Add.Text = "Add[F7]"
                End If

                '---------------WILL CHECK HERE---------
            ElseIf cmd_Add.Text = "Update[F7]" Then
                sqlstring = "select adduser,adddatetime from chargemaster WHERE CHARGECODE='" & Trim(CHARGEDESC.Text) & "'"
                gconnection.getDataSet(sqlstring, "CHARGE")
                If gdataset.Tables("CHARGE").Rows.Count > 0 Then
                    ADDUSER = gdataset.Tables("CHARGE").Rows(0).Item(0)
                    ADDDATE = gdataset.Tables("CHARGE").Rows(0).Item(1)
                End If
                sqlstring = " DELETE FROM chargemaster WHERE CHARGECODE='" & Trim(CHARGEDESC.Text) & "'"
                gconnection.dataOperation(6, sqlstring, "chargemaster")
                For i = 0 To ChkList_ItemType.Items.Count - 1
                    If ChkList_ItemType.GetItemChecked(i) = True Then
                        TempString = Split(ChkList_ItemType.Items.Item(i), "->")
                        subscode = Trim(TempString(0))
                        subsdesc = Trim(TempString(1))
                        sqlstring = "INSERT INTO  chargemaster "
                        sqlstring = sqlstring & "(CHARGECODE,CHARGEDESC,TAXTYPECODE,TAXTYPEDESC,RATE,ADDUSER,ADDDATETIME,updateuser,updatedatetime) VALUES ('" & Trim(CHARGEDESC.Text) & " ' ,'" & Trim(Textname.Text) & "','" & _
                       subscode & " ','" & subsdesc & "','" & Trim(Textrate.Text) & " ','" & ADDUSER & "','" & Format(ADDDATE, "dd-MMM-yyyy hh:mm") & "','" & gUsername & "','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "')"
                        subscode = ""
                        subsdesc = ""
                        gconnection.dataOperation(2, sqlstring, "chargemaster")
                    Else
                        sqlstring = "INSERT INTO  chargemaster "
                        sqlstring = sqlstring & "(CHARGECODE,CHARGEDESC,TAXTYPECODE,TAXTYPEDESC,RATE,ADDUSER,ADDDATETIME,updateuser,updatedatetime) VALUES ('" & Trim(CHARGEDESC.Text) & " ' ,'" & Trim(Textname.Text) & "','" & _
                       subscode & " ','" & subsdesc & "','" & Trim(Textrate.Text) & " ','" & ADDUSER & "','" & Format(ADDDATE, "dd-MMM-yyyy hh:mm") & "','" & gUsername & "','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "')"
                        subscode = ""
                        subsdesc = ""
                        gconnection.dataOperation(2, sqlstring, "chargemaster")
                        cmd_Add.Text = "Update[F7]"


                    End If
                Next i
                If gcommit = True Then
                    MessageBox.Show("Record Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cmd_Add.Text = "Add[F7]"
                End If

            End If
            'gconnection.dataOperation(2, "UPDATE MEMBERMASTER SET TAG = 'Y' WHERE MCODE = '" & Trim(txt_MemberCode.Text) & "'", "MemberMaster")
            Me.cmd_Clear_Click(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub checkValidation()
        boolchk = False

        If Trim(CHARGEDESC.Text) = "" Then
            MessageBox.Show(" Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CHARGEDESC.Focus()
            Exit Sub
        End If
        If lbl_freeze.Visible = True Then
            MessageBox.Show("This Record Already Void ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Trim(Textname.Text) = "" Then
            MessageBox.Show(" Name can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CHARGEDESC.Focus()
            Exit Sub
        End If
        If Trim(Textrate.Text) < 0 Then
            MessageBox.Show(" Rate can't be Negitive Value ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Textrate.Focus()
            Exit Sub
        End If
        boolchk = True
    End Sub

    Private Sub lbl_freeze_Click(sender As Object, e As EventArgs) Handles lbl_freeze.Click

    End Sub

    Private Sub List_Tax_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub CODE_HELP_Click(sender As Object, e As EventArgs) Handles CODE_HELP.Click

        Dim vform As New LIST_OPERATION1
        gSQLString = "Select CHARGECODE,CHARGEDESC,RATE from ChargeMaster"
        M_WhereCondition = " "
        vform.vCaption = "ChargeCode Help"
        vform.Field = "Chargecode,Chargedesc,Rate"
        vform.CMB_SRC_FIELDS.Select()
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            CHARGEDESC.Text = Trim(vform.keyfield & "")
            Textname.Select()
            CODE_HELP_Validated(sender, e)
            'Call FillItemTypeMaster()
            '' Call FillTypeMst1()
            'Call FillItemTypeDetails_Det()
            Call FillItemTypeMaster()
            Call FillTypeMst1()
            Call FillItemTypeDetails_Det()

        End If
        vform.Close()
        vform = Nothing
        '  cmd_Add.Text = "Update[F7]"
        cmd_Freeze.Text = "Void[F8]"

    End Sub

    Public Sub FillTypeMst1()
        Dim i As Integer
        Dim SSQL As String
        Dim dt, MEMBERTYPE As DataTable
        '   ChkList_ItemType.Items.Clear()
        sqlstring = "select TAXTYPECODE from chargemaster where CHARGECODE='" & CHARGEDESC.Text & "'"
        MEMBERTYPE = gconnection.GetValues(sqlstring)
        If MEMBERTYPE.Rows.Count > 0 Then
            For i = 0 To (MEMBERTYPE.Rows.Count - 1)
                For J = 0 To ChkList_ItemType.Items.Count - 1
                    TempString = Split(ChkList_ItemType.Items.Item(J), "->")
                    code = Trim(TempString(0))
                    '                desc = Trim(TempString(1))
                    ' code = MEMBERTYPE.Rows(i).Item("TAXTYPECODE")
                    If Trim(MEMBERTYPE.Rows(i).Item("TAXTYPECODE")) = code Then
                        ChkList_ItemType.SetItemChecked(J, True)
                    End If
                Next
            Next
        Else
            'MessageBox.Show("Current Category Cannot be converted!", gCompanyname, MessageBoxButtons.OK)
            'Exit Sub
        End If
    End Sub
    Public Sub FillTypeMst()
        Dim i As Integer
        Dim SSQL As String
        Dim dt, MEMBERTYPE As DataTable
        '   ChkList_ItemType.Items.Clear()
        sqlstring = "SELECT CHARGECODE FROM chargemaster where CHARGECODE='" & Trim(CHARGEDESC.Text) & "'"
        dt = gconnection.GetValues(sqlstring)
        'Dim Itration
        'For Itration = 0 To (dt.Rows.Count - 1)
        '    ChkList_ItemType.Items.Add(dt.Rows(Itration).Item("SubTYPEDESC"))
        'Next
        SSQL = "SELECT TAXTYPECODE,TAXTYPEDESC FROM ENTRANCEFEE_TAXALLOCATION where effective_from='" & Trim(CHARGEDESC.Text) & "'"
        MEMBERTYPE = gconnection.GetValues(SSQL)
        If MEMBERTYPE.Rows.Count > 0 Then
            For i = 0 To (MEMBERTYPE.Rows.Count - 1)
                For J = 0 To ChkList_ItemType.Items.Count - 1
                    TempString = Split(ChkList_ItemType.Items.Item(J), "->")
                    subscode = Trim(TempString(0))
                    subsdesc = Trim(TempString(1))
                    'If Trim(MEMBERTYPE.Rows(i).Item("TAXTYPECODE")) = ChkList_ItemType.GetItemText(ChkList_ItemType.Items(J)) Then
                    If Trim(MEMBERTYPE.Rows(i).Item("TAXTYPECODE")) = subscode Then
                        ChkList_ItemType.SetItemChecked(J, True)
                    End If
                    Dim A As String

                    'Select_Category.Items.Add(MEMBERTYPE.Rows(I).Item("Membersubtypecode") & "." & MEMBERTYPE.Rows(I).Item("Membertype"))
                Next
            Next
        Else
            'MessageBox.Show("Current Category Cannot be converted!", gCompanyname, MessageBoxButtons.OK)
            'Exit Sub
        End If
    End Sub
    Private Sub Textcode_KeyDown(sender As Object, e As KeyEventArgs) Handles CHARGEDESC.KeyDown
        If e.KeyCode = Keys.Enter Then
            If CHARGEDESC.Text = "" Then
                CODE_HELP_Click(sender, e)
            Else
                CODE_HELP_Validated(sender, e)
                Call FillItemTypeMaster()
                Call FillTypeMst1()
                Call FillItemTypeDetails_Det()

                Textname.Focus()
            End If
        ElseIf e.KeyCode = Keys.F4 Then
            CODE_HELP_Click(sender, e)
        End If
    End Sub

    Private Sub Textcode_TextChanged(sender As Object, e As EventArgs) Handles CHARGEDESC.TextChanged

    End Sub

    Private Sub Textcode_Validated(sender As Object, e As EventArgs) Handles CHARGEDESC.Validated

    End Sub

    Private Sub cmd_View_Click(sender As Object, e As EventArgs) Handles cmd_View.Click
        Gr2.Visible = True
    End Sub

    Private Sub cmd_Clear_Click(sender As Object, e As EventArgs) Handles cmd_Clear.Click
        Me.lbl_freeze.Visible = False
        Me.lbl_freeze.Text = "Record Freezed  On "
        ChkList_ItemTypeDet.Items.Clear()
        For i = 0 To ChkList_ItemTypeDet.Items.Count - 1
            ChkList_ItemTypeDet.SetItemChecked(i, False)
        Next i
        'ChkList_ItemType.Items.Clear()
        For i = 0 To ChkList_ItemType.Items.Count - 1
            ChkList_ItemType.SetItemChecked(i, False)
        Next i

        cmd_Freeze.Visible = True
        List_Tax.SelectedIndex = -1
        CHARGEDESC.Text = ""
        Textname.Text = ""
        Textrate.Text = ""
        Textrate.Text = "0.00"
        Textrate.ReadOnly = False

        cmd_Add.Text = "Add[F7]"
        Me.cmd_Freeze.Text = "Void[F8]"
        clearform(Me)
        CHARGEDESC.Focus()
        Gr2.Visible = False

    End Sub

    Private Sub Textname_KeyDown(sender As Object, e As KeyEventArgs) Handles Textname.KeyDown
        If e.KeyCode = Keys.Enter Then
            Textrate.Focus()
        End If

        ' Textrate.Focus()
    End Sub

    Private Sub Textname_TextChanged(sender As Object, e As EventArgs) Handles Textname.TextChanged

    End Sub

    Private Sub cmd_Freeze_Click(sender As Object, e As EventArgs) Handles cmd_Freeze.Click
        Call checkValidation() ''-->Check Validation
        If boolchk = False Then Exit Sub
        If lbl_freeze.Visible = True Then
            MessageBox.Show("Record already Freezed ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cmd_Clear_Click(sender, e)
        Else
            'If Mid(Me.cmd_Freeze.Text, 1, 1) = "F" Then
            '    sqlstring = "UPDATE  chargemaster "
            '    sqlstring = sqlstring & " SET Freeze= 'Y',Adduser='" & gUsername & " ', Adddatetime=getdate()"
            '    sqlstring = sqlstring & " WHERE Code = '" & Trim(CHARGEDESC.Text) & "'"
            '    gconnection.dataOperation(3, sqlstring, "ReasonMaster")
            '    'MessageBox.Show("Record Freeze Successfully ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Me.cmd_Clear_Click(sender, e)
            '    cmd_Add.Text = "Add[F7]"
            '  Else
            sqlstring = "UPDATE  chargemaster "
            sqlstring = sqlstring & " SET Freeze= 'Y',Adduser='" & gUsername & " ', Adddatetime=getdate()"
            sqlstring = sqlstring & " WHERE chargeCode = '" & Trim(CHARGEDESC.Text) & "'"
            gconnection.dataOperation(4, sqlstring, "ReasonMaster")
            MessageBox.Show("Record Freeze Successfully ", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cmd_Clear_Click(sender, e)
            cmd_Add.Text = "Add[F7]"
        End If
    End Sub

    Private Sub List_Tax_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles List_Tax.SelectedIndexChanged

    End Sub

    'Private Sub ChkList_ItemType_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles ChkList_ItemType.ItemCheck
    '    If e.NewValue = CheckState.Checked Then

    '        For i As Integer = 0 To Me.ChkList_ItemType.Items.Count - 1 Step 1

    '            If i <> e.Index Then

    '                Me.ChkList_ItemType.SetItemChecked(i, False)

    '            End If
    '        Next i

    '    End If
    'End Sub
    '  End Sub


    Private Sub ChkList_ItemType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ChkList_ItemType.SelectedIndexChanged
        Call FillItemTypeDetails_Det()



    End Sub

    Private Sub ChkList_ItemType_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles ChkList_ItemType.ItemCheck

        If e.NewValue = CheckState.Checked Then
            For Each i As Integer In ChkList_ItemType.CheckedIndices
                ChkList_ItemType.SetItemChecked(i, False)
            Next
        End If
    End Sub

    Private Sub FillItemTypeMaster()
        Dim i As Integer
        ChkList_ItemType.Items.Clear()
        sqlstring = " SELECT DISTINCT ISNULL(ItemTypeCode,'') AS ItemTypeCode,ISNULL(ItemTypeDesc,'') AS ItemTypeDesc  FROM ItemTypeMaster WHERE  ISNULL(FREEZE,'')<>'Y' "
        gconnection.getDataSet(sqlstring, "TaxMaster")
        If gdataset.Tables("TaxMaster").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("TaxMaster").Rows.Count - 1
                With gdataset.Tables("TaxMaster").Rows(i)
                    ChkList_ItemType.Items.Add(Trim(.Item("ItemTypeCode") & "->" & .Item("ItemTypeDesc")))
                End With
            Next i
        End If
        ChkList_ItemType.Sorted = True
    End Sub
    Private Sub FillItemTypeDetails()
        Try
            Dim i As Integer
            sqlstring = " SELECT DISTINCT ISNULL(TAXTYPECODE,'') AS TAXTYPECODE,ISNULL(TAXTYPEDESC,'') AS TAXTYPEDESC FROM GMS_GREENFEETAXALLOCATION WHERE CATEGORYCODE = '" & Trim(CHARGEDESC.Text) & "'"
            gconnection.getDataSet(sqlstring, "TAXLINK")
            If gdataset.Tables("TAXLINK").Rows.Count > 0 Then
                ChkList_ItemType.Items.Clear()
                For i = 0 To gdataset.Tables("TAXLINK").Rows.Count - 1
                    With gdataset.Tables("TAXLINK").Rows(i)
                        ChkList_ItemType.Items.Add(Trim(.Item("TAXTYPECODE") & "->" & .Item("TAXTYPEDESC")))
                        ChkList_ItemType.SetItemChecked(i, True)
                    End With
                Next i
            End If
            sqlstring = " SELECT DISTINCT ISNULL(ItemTypeCode,'') AS ItemTypeCode,ISNULL(ItemTypeDesc,'') AS ItemTypeDesc  FROM ItemTypeMaster WHERE ISNULL(FREEZE,'')<>'Y' AND ItemTypeCode NOT IN (SELECT DISTINCT TAXTYPECODE FROM GMS_GREENFEETAXALLOCATION WHERE CATEGORYCODE = '" & Trim(CHARGEDESC.Text) & "')"
            gconnection.getDataSet(sqlstring, "TAXLINK")
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
                    Code = Split(ChkList_ItemType.CheckedItems(i), "->")
                    'sqlstring = sqlstring & " '" & ChkList_ItemType.CheckedItems(i) & "', "
                    sqlstring = sqlstring & " '" & Code(0) & "', "
                Next
                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                sqlstring = sqlstring & ")"
            Else
                'MessageBox.Show("Select the location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
            sqlstring = sqlstring & " ORDER BY TAXON "
            gconnection.getDataSet(sqlstring, "TAXLINKDET")
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub ChkList_ItemTypeDet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ChkList_ItemTypeDet.SelectedIndexChanged

    End Sub
    Private Sub CODE_HELP_Validated(sender As Object, e As EventArgs) Handles CODE_HELP.Validated
        If Trim(CHARGEDESC.Text) <> "" Then
            sqlstring = " Select ISNULL(CHARGECODE,'')AS CHARGECODE,ISNULL(CHARGEDESC,'')AS CHARGEDESC,ISNULL(RATE,0)AS RATE,ISNULL(TAXTYPECODE,'')AS TAXTYPECODE,ISNULL(FREEZE,'')AS FREEZE,adddatetime From CHARGEMASTER Where CHARGECODE='" & CHARGEDESC.Text & "'"
            gconnection.getDataSet(sqlstring, "CHARGEMASTER")
            If gdataset.Tables("CHARGEMASTER").Rows.Count > 0 Then
                CHARGEDESC.Text = gdataset.Tables("CHARGEMASTER").Rows(0).Item("CHARGECODE")
                Textname.Text = gdataset.Tables("CHARGEMASTER").Rows(0).Item("CHARGEDESC")
                If gdataset.Tables("CHARGEMASTER").Rows(0).Item("Rate") = "0.00" Then
                    Textrate.Text = gdataset.Tables("CHARGEMASTER").Rows(0).Item("Rate")
                    Textrate.ReadOnly = True
                Else
                    Textrate.Text = gdataset.Tables("CHARGEMASTER").Rows(0).Item("Rate")
                End If
                Textrate.Text = gdataset.Tables("CHARGEMASTER").Rows(0).Item("Rate")
                ChkList_ItemType.Text = gdataset.Tables("CHARGEMASTER").Rows(0).Item("TAXTYPECODE")

                If gdataset.Tables("CHARGEMASTER").Rows(0).Item("FREEZE") = "Y" Then
                    Me.lbl_freeze.Visible = True
                    Me.lbl_freeze.Text = "Record Freezed  On " & Format(CDate(gdataset.Tables("CHARGEMASTER").Rows(0).Item("adddatetime")), "dd/MMM/yyyy")
                    ' Me.lbl_freeze.Text = "Record Freezed  On : " & Format(CDate(gdataset.Tables("CHARGEMASTER").Rows(0).Item("adddatetime")), "dd-MMM-yyyy")
                    Me.cmd_Freeze.Text = "Void[F8]"
                Else
                    Me.lbl_freeze.Visible = False
                    Me.lbl_freeze.Text = ""
                    Me.cmd_Freeze.Text = "Void[F8]"
                End If
                Me.cmd_Add.Text = "Update[F7]"
            Else

            End If

        End If

    End Sub
    'Private Sub ChkList_ItemType_ItemCheck(sender As Object, e As ItemCheckEventArgs)
    '    'If ChkList_ItemType.CheckedIndices.Count > 1 Then
    '    '    e.NewValue = CheckState.Unchecked
    '    '    MessageBox.Show("already three item selected")
    '    'End If
    '    If e.NewValue = CheckState.Checked Then

    '        For i As Integer = 0 To Me.ChkList_ItemType.Items.Count - 1

    '            If i <> e.Index Then

    '                Me.ChkList_ItemType.SetItemChecked(i, False)

    '            End If
    '        Next i

    '    End If
    '   End Sub

    Private Sub Textrate_KeyDown(sender As Object, e As KeyEventArgs) Handles Textrate.KeyDown
        ' ChkList_ItemType.Focus()
        If e.KeyCode = Keys.Enter Then
            ChkList_ItemType.Focus()
        End If
    End Sub

    Private Sub Textrate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textrate.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                e.Handled = True
                'MsgBox(" Numbers only ")
            End If
        End If
    End Sub

    Private Sub Textrate_TextChanged(sender As Object, e As EventArgs) Handles Textrate.TextChanged

    End Sub

    Private Sub CMD_DOS_Click(sender As Object, e As EventArgs) Handles CMD_DOS.Click
        Dim reportdesign As New ReportDesigner
        gheader = " MASTER VIEW "
        If CHARGEDESC.Text.Length > 0 Then
            tables = " FROM CHARGEMASTER where Code = '" & Trim(CHARGEDESC.Text) & "'"
        Else
            tables = " FROM CHARGEMASTER"
        End If
        reportdesign.DataGridView1.ColumnCount = 2
        reportdesign.DataGridView1.Columns(0).Name = "Column Name"
        reportdesign.DataGridView1.Columns(0).Width = 380
        reportdesign.DataGridView1.Columns(1).Name = "Size"
        reportdesign.DataGridView1.Columns(1).Width = 100


        Dim row As String() = New String() {"CHARGECODE", "10"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"CHARGEDESC", "35"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"TAXAPPLY", "15"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"FREEZE", "3"}
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
        sqlstring = "select * from view_chargemaster"
        If CHARGEDESC.Text = "" Then
            sqlstring = sqlstring & ""
        Else
            sqlstring = sqlstring & " WHERE CHARGECODE= '" & CHARGEDESC.Text & "'"
        End If
        Dim r As New Cry_chargemaster
        gconnection.getDataSet(sqlstring, "view_chargemaster")

        If gdataset.Tables("view_chargemaster").Rows.Count > 0 Then

            Viewer.TableName = "view_chargemaster"
            Call Viewer.GetDetails(sqlstring, "view_chargemaster", r)
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

    Private Sub cmd_exit1_Click(sender As Object, e As EventArgs) Handles cmd_exit1.Click
        Gr2.Visible = False
        CHARGEDESC.Focus()
    End Sub
End Class