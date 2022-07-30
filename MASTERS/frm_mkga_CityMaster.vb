Imports CrystalDecisions.CrystalReports.Engine
Public Class frm_mkga_CityMaster
    Dim boolchk, datachk As Boolean
    Dim sqlstring As String
    Dim vSeqNo As Double
    Dim gconnection As New GlobalClass
     
    Private Sub Txtcode_KeyDown(sender As Object, e As KeyEventArgs) Handles Txtcode.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Txtcode.Text = "" Then
                    btn_help_Click(sender, e)
                Else
                    Call TxtcodeFILL()
                    txtName.Focus()
                End If
            ElseIf e.KeyCode = Keys.F4 Then
                btn_help_Click(sender, e)

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gCompanyname)
        End Try
    End Sub

    Private Sub Txtcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtcode.KeyPress
        getAlphanumeric(e)
    End Sub

    Private Sub Txtcode_TextChanged(sender As Object, e As EventArgs) Handles Txtcode.TextChanged

    End Sub

    Private Sub frm_mkga_CityMaster_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
                    Call btn_view_Click(sender, e)
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
    Private Sub frm_mkga_CityMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Resize_Form()
        ServerMastbool = True
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        Call City()
        Txtcode.Select()
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Call Resize_Form()

        ' Call country()
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
                        If Controls(i_i).Name = "btn_clear" Or Controls(i_i).Name = "btn_addnew" Or Controls(i_i).Name = "btn_freeze" Or Controls(i_i).Name = "btn_view" Or Controls(i_i).Name = "BROWSE" Or Controls(i_i).Name = "btn_authorize" Or Controls(i_i).Name = "btn_exit" Then
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
        Me.btn_addnew.Enabled = False
        Me.btn_freeze.Enabled = False
        btn_view.Enabled = False
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
    'Public Sub City()
    '    Dim i As Integer
    '    Dim dt As DataTable
    '    sqlstring = "SELECT distinct Name  FROM Tbl_stateMaster where freeze<>'Y' and isnull(name,'')<>'' "
    '    dt = gconnection.GetValues(sqlstring)
    '    Dim Itration
    '    For Itration = 0 To (dt.Rows.Count - 1)
    '        Cbo_PState.Items.Add(dt.Rows(Itration).Item("name"))
    '    Next
    'End Sub
    'Public Sub country()
    '    Dim i As Integer
    '    Dim dt As DataTable
    '    sqlstring = "SELECT distinct(Name) FROM tbl_countrymaster where freeze<>'Y' and isnull(name,'')<>'' "
    '    dt = gconnection.GetValues(sqlstring)
    '    Dim Itration
    '    For Itration = 0 To (dt.Rows.Count - 1)
    '        Cbo_PCountry.Items.Add(dt.Rows(Itration).Item("Name"))
    '    Next
    'End Sub

    Private Sub btn_help_Click(sender As Object, e As EventArgs) Handles btn_help.Click
         
        Dim vform As New LIST_OPERATION1
        gSQLString = "SELECT ISNULL(CODE,'') AS CODE,ISNULL(NAME,'') AS NAME,ISNULL(STATE,'') AS STATE,ISNULL(COUNTRY,'') AS COUNTRY  FROM Tbl_CityMaster "
        M_WhereCondition = " "
        vform.Field = "CODE,NAME"
        vform.vCaption = "City MASTER HELP "
        vform.TXT_SEARCH_TXT.Select()
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            Txtcode.Text = Trim(vform.keyfield & "")
            Txtcode.Select()
            Me.TxtcodeFILL()
            vform.Close()
            vform = Nothing
            btn_addnew.Text = "Update [F7]"
        End If
        gconnection.closeConnection()



    End Sub
    Private Sub TxtcodeFILL()
        Try
            Dim I, J As Integer
            Dim MEMBERTYPE As DataTable
            Dim Sqlstr As String
            If Txtcode.Text <> "" Then
                Sqlstr = " SELECT ISNULL(CODE,'') AS CODE,ISNULL(NAME,'') AS NAME,ISNULL(STATE,'') AS STATE,ISNULL(COUNTRY,'') AS COUNTRY ,isnull(voiddate,'')as voiddate,ISNULL(FREEZE,'') AS FREEZE FROM Tbl_CityMaster WHERE CODE='" & Trim(Txtcode.Text) & "'"
                gconnection.getDataSet(Sqlstr, "Master")
                If gdataset.Tables("Master").Rows.Count > 0 Then
                    Txtcode.ReadOnly = True
                    txtName.Text = gdataset.Tables("Master").Rows(0).Item("Name")
                    Cbo_PState.Text = gdataset.Tables("Master").Rows(0).Item("STATE")
                    Cbo_PCountry.Text = gdataset.Tables("Master").Rows(0).Item("COUNTRY")
                    If gdataset.Tables("Master").Rows(0).Item("Freeze") = "Y" Then
                        Me.lbl_Freeze.Visible = True
                        Me.lbl_Freeze.Text = Me.lbl_Freeze.Text & Format(gdataset.Tables("Master").Rows(0).Item("voiddate"), "dd-MMM-yyyy")
                        Me.btn_freeze.Text = "Unvoid [F8]"
                    Else
                        Me.lbl_Freeze.Visible = False
                        Me.lbl_Freeze.Text = "Record Voided  On "
                        Me.btn_freeze.Text = "Void [F8]"
                    End If
                    Me.btn_addnew.Text = "Update [F7]"
                Else
                    txtName.Text = ""
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Txtcode_Validated(sender As Object, e As EventArgs) Handles Txtcode.Validated
        
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Call clearform(Me)
        Me.lbl_Freeze.Visible = False
        Me.lbl_Freeze.Text = "Record Voided  On "
        Me.btn_freeze.Text = "Void [F8]"
        btn_addnew.Text = "Add [F7]"
        Cbo_PState.SelectedIndex = -1
        Cbo_PCountry.SelectedIndex = -1
        Txtcode.Text = ""
        txtName.Text = ""
        Cbo_PState.Enabled = True
        Cbo_PCountry.Enabled = True
        Txtcode.ReadOnly = False
        txtName.ReadOnly = False
        btn_freeze.Enabled = True
        btn_addnew.Text = "Add [F7]"
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        Txtcode.Focus()
        Gr2.Visible = False
        lbl_Freeze.Text = "Record Voided  On "
    End Sub

    Private Sub btn_freeze_Click(sender As Object, e As EventArgs) Handles btn_freeze.Click
        Call checkValidation() ''-->Check Validation
        If boolchk = False Then Exit Sub
        If Mid(Me.btn_freeze.Text, 1, 1) = "V" And Mid(Me.btn_addnew.Text, 1, 1) = "U" Then
            sqlstring = "UPDATE  Tbl_CityMaster "
            sqlstring = sqlstring & " SET Freeze= 'Y',voiduser='" & gUsername & " ', voiddate='" & Format(Now, "dd-MMM-yyyy HH:mm") & "'"
            sqlstring = sqlstring & " WHERE Code = '" & Trim(Txtcode.Text) & "'"
            gconnection.dataOperation(3, sqlstring, "Tbl_CityMaster")
            MessageBox.Show("Record Voided Successfully ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.btn_clear_Click(sender, e)
            btn_addnew.Text = "Add [F7]"
        ElseIf Mid(Me.btn_freeze.Text, 1, 1) = "U" And Mid(Me.btn_addnew.Text, 1, 1) = "U" Then
            MsgBox("This Unvoid Process Can't Proceed")
            'sqlstring = "UPDATE  Tbl_CityMaster "
            'sqlstring = sqlstring & " SET Freeze= 'N',voiduser='" & gUsername & " ', voiddate=getdate()"
            'sqlstring = sqlstring & " WHERE Code = '" & Trim(Txtcode.Text) & "'"
            'gconnection.dataOperation(4, sqlstring, "Tbl_CityMaster")
            'MessageBox.Show("Record UnFreezed Successfully ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Me.btn_clear_Click(sender, e)
            'btn_addnew.Text = "Add [F7]"
        End If
    End Sub

    Public Sub checkValidation()
        boolchk = False
        ''********** Check  Server desc Can't be blank *********************'''
        If Trim(Txtcode.Text) = "" Then
            MessageBox.Show(" Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Txtcode.Focus()
            Exit Sub
        End If
        If Trim(txtName.Text) = "" Then
            MessageBox.Show(" City Name can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtName.Focus()
            Exit Sub
        End If
        If Trim(Cbo_PState.Text) = "" Then
            MessageBox.Show(" State Name can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtName.Focus()
            Exit Sub
        End If
        If Trim(Cbo_PCountry.Text) = "" Then
            MessageBox.Show(" Country Name can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtName.Focus()
            Exit Sub
        End If



        'datachk = False
        'Dim MEMBERTYPE, MEMBERTYPE1 As New DataTable
        'Dim STRQUERY As String
        'STRQUERY = " select distinct(PCITY) from member_application_master  where PCITY='" & Trim(txtName.Text) & "'"
        'MEMBERTYPE = gconnection.GetValues(STRQUERY)
        'STRQUERY = "select  distinct(PCITY) from membermaster   where PCITY='" & Trim(txtName.Text) & "'"
        'MEMBERTYPE1 = gconnection.GetValues(STRQUERY)
        'If MEMBERTYPE.Rows.Count > 0 Or MEMBERTYPE1.Rows.Count > 0 Then
        '    datachk = True
        'End If

        'If datachk = True Then
        '    txtName.ReadOnly = True
        '    MessageBox.Show("City is Already used in MEMBER Details So it cant be Change", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    datachk = False
        '    boolchk = False
        '    Exit Sub
        'End If

        boolchk = True
    End Sub

    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        Gr2.Visible = True
       
    End Sub

    Private Sub btn_addnew_Click(sender As Object, e As EventArgs) Handles btn_addnew.Click
        If btn_addnew.Text = "Add [F7]" Then
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            sqlstring = "Insert into Tbl_CityMaster"
            sqlstring = sqlstring + "(Code,Name,Freeze,State,country,AddUser,Adddatetime)"
            sqlstring = sqlstring + "values('" + Trim(Txtcode.Text) + "','" + Trim(txtName.Text) + "', 'N','" + Trim(Cbo_PState.Text) + "','" + Trim(Cbo_PCountry.Text) + "','" & gUsername & " ', '" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "')"
            gconnection.dataOperation(1, sqlstring, "Tbl_CityMaster")
            MessageBox.Show("Record Saved Successfully ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.btn_clear_Click(sender, e)
        ElseIf btn_addnew.Text = "Update [F7]" Then
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            If Mid(Me.btn_addnew.Text, 1, 1) = "U" Then
                If Me.lbl_Freeze.Visible = True Then
                    MessageBox.Show(" The Voided Record Can Not Be Update", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    boolchk = False
                    Exit Sub
                End If
            End If
            sqlstring = "Update Tbl_CityMaster SET "
            sqlstring = sqlstring + "Name='" + Trim(txtName.Text) + "',State ='" + Trim(Cbo_PState.Text) + "',country ='" + Trim(Cbo_PCountry.Text) + "',Freeze= 'N',UPD_USER='" & gUsername & " ', UPD_DATE='" & Format(Now, "dd-MMM-yyyy HH:mm") & "' Where Code='" + Trim(Txtcode.Text) + "'"
            gconnection.dataOperation(2, sqlstring, "Tbl_CityMaster")
            MessageBox.Show("Record Updated Successfully ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.btn_clear_Click(sender, e)
            btn_addnew.Text = "Add [F7]"
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub txtName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtName.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txtName.Text = "" Then
                    txtName.Select()
                Else
                    Cbo_PState.Select()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gCompanyname)
        End Try
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        getCharater(e)
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub Cbo_PState_KeyDown(sender As Object, e As KeyEventArgs) Handles Cbo_PState.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Cbo_PState.Text = "" Then
                    Cbo_PState.Select()
                Else
                    Cbo_PCountry.Select()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gCompanyname)
        End Try
    End Sub
    Public Sub City()
        Dim i As Integer
        Dim dt As DataTable
        sqlstring = "SELECT distinct(Name) AS NAME,country FROM Tbl_STATEMASTER where freeze<>'Y' and isnull(name,'')<>'' "
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            Cbo_PState.Items.Add(dt.Rows(Itration).Item("NAME"))
            Cbo_PCountry.Items.Add(dt.Rows(Itration).Item("country"))
        Next
    End Sub
    Private Sub Cbo_PState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_PState.SelectedIndexChanged
        Dim I As Integer
        Dim DT As DataTable
        Dim SSQL As String
        'Cbo_PCountry.Enabled = True
        SSQL = "SELECT DISTINCT(COUNTRY) AS COUNTRY FROM TBL_STATEMASTER WHERE NAME='" & Cbo_PState.Text & "' AND ISNULL(FREEZE,'')<>'Y'"
        gconnection.getDataSet(SSQL, "Master1")
        If gdataset.Tables("Master1").Rows.Count > 0 Then
            'MessageBox.Show(gdataset.Tables("Master1").Rows(0).Item("COUNTRY"))
            Cbo_PCountry.Text = gdataset.Tables("Master1").Rows(0).Item("COUNTRY")
            Cbo_PCountry.Enabled = False
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
            SSQLSTR2 = " SELECT * FROM Tbl_CityMaster WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER1,'')=''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH1USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH1USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE")
                If gdataset.Tables("AUTHORIZE").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND ISNULL(AUTHORIZELEVEL,0)>0 "
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM Tbl_CityMaster WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER1,'')=''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()


                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE Tbl_CityMaster set  ", "Code", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 1, 1)
                        End If
                    Else
                        MsgBox("NO AUTHORIZATION REQUIRED FOR THE ENTRY")
                    End If
                End If
            End If
        ElseIf USERT = 2 Then
            SSQLSTR2 = " SELECT * FROM Tbl_CityMaster WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')='' AND ISNULL(AUTHORISE_USER1,'')<>''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH2USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH2USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE1")
                If gdataset.Tables("AUTHORIZE1").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "'"
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM Tbl_CityMaster WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')=''AND ISNULL(AUTHORISE_USER1,'')<>''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()


                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE Tbl_CityMaster set  ", "Code", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 2, 1)
                        End If
                    End If
                End If
            End If
        ElseIf USERT = 3 Then
            SSQLSTR2 = " SELECT * FROM Tbl_CityMaster WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')=''AND ISNULL(AUTHORISE_USER1,'')<>''  AND ISNULL(AUTHORISE_USER2,'')<>''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH3USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH3USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE2")
                If gdataset.Tables("AUTHORIZE2").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "'"
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM Tbl_CityMaster WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')=''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()
                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE Tbl_CityMaster set  ", "Code", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 3, 1)
                        End If
                    End If
                End If
            Else
                MsgBox("U R NOT ELIGIBLE TO AUTHORISE IN ANY LEVEL", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BROWSE.Click
        brows = True
        Dim VIEW1 As New VIEWHDR
        VIEW1.Show()
        VIEW1.DTGRDHDR.DataSource = Nothing
        VIEW1.DTGRDHDR.Rows.Clear()
        Dim STRQUERY As String
        STRQUERY = "SELECT code,* FROM TBL_CITYMASTER"
        'STRQUERY = "SELECT isnull(MODULENAME,'')as MODULENAME,isnull(FORMNAME,'') as FORMNAME,isnull(FORMTYPE,'')as FORMTYPE,isnull(AUTHORIZELEVEL,'')as AUTHORIZELEVEL,isnull(AUTH1USER1,'')as AUTH1USER1,isnull(AUTH1USER2,'') as AUTH1USER2,isnull(AUTH2USER1,'')as  AUTH2USER1,isnull(AUTH2USER2,'')as AUTH2USER2,isnull(AUTH3USER1,'')as AUTH3USER1,isnull(AUTH3USER2,'') as AUTH3USER2,isnull(void,'') as void,isnull(ADDUSERID,'')as ADDUSERID,isnull(ADDDATETIME,'')as ADDDATETIME FROM authorize"
        gconnection.getDataSet(STRQUERY, "authorize")

        Call VIEW1.LOADGRID(gdataset.Tables("authorize"), True, gcompanyname, "SELECT * FROM TBL_CITYMASTER", "code", 1, Me.Txtcode)
        'VIEW1.Hide()
        'VIEW1.ShowDialog(Me)
        'If Trim(keyfield & "") <> "" Then
        '    Txtcode.Text = Trim(keyfield & "")
        '    Txtcode.Select()
        '    Me.TxtcodeFILL()
        '    txtName.Focus()
        '    btn_addnew.Text = "Update [F7]"
        'End If
        'gconnection.closeConnection()

    End Sub

    Private Sub Cbo_PCountry_KeyDown(sender As Object, e As KeyEventArgs) Handles Cbo_PCountry.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_addnew.Select()
        End If
    End Sub

    Private Sub Cbo_PCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_PCountry.SelectedIndexChanged

    End Sub

    Private Sub CMD_WINDOWS_Click(sender As Object, e As EventArgs) Handles CMD_WINDOWS.Click
        Dim txtobj1 As TextObject
        Dim Viewer As New REPORTVIEWER
        sqlstring = "select * from view_Citymaster "
        If Txtcode.Text = "" Then
            sqlstring = sqlstring & ""
        Else
            sqlstring = sqlstring & " WHERE Code= '" & Txtcode.Text & "' "
        End If
        Dim r As New Cry_Citymaster

        gconnection.getDataSet(sqlstring, "view_Citymaster")

        If gdataset.Tables("view_Citymaster").Rows.Count > 0 Then

            Viewer.TableName = "view_Citymaster"
            Call Viewer.GetDetails(sqlstring, "view_Citymaster", r)
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
            txtobj1 = r.ReportDefinition.ReportObjects("Text13")
            txtobj1.Text = UCase(gCompanyAddress(4))
            txtobj1 = r.ReportDefinition.ReportObjects("Text14")
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

    Private Sub CMD_DOS_Click(sender As Object, e As EventArgs) Handles CMD_DOS.Click
        Dim reportdesign As New ReportDesigner
        gheader = " CITY MASTER VIEW "
        If Txtcode.Text.Length > 0 Then
            tables = " FROM tbl_citymaster where code = '" & Trim(Txtcode.Text) & "'"
        Else
            tables = " FROM tbl_citymaster"
        End If
        reportdesign.DataGridView1.ColumnCount = 2
        reportdesign.DataGridView1.Columns(0).Name = "Column Name"
        reportdesign.DataGridView1.Columns(0).Width = 380
        reportdesign.DataGridView1.Columns(1).Name = "Size"
        reportdesign.DataGridView1.Columns(1).Width = 100
        Dim row As String() = New String() {"Code", "10"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"name", "25"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"State", "25"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"Country", "25"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"Freeze", "10"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"AddUser", "10"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"Adddatetime", "15"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"Upd_User", "10"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"Upd_Date", "15"}
        reportdesign.DataGridView1.Rows.Add(row)
        Dim chk As New DataGridViewCheckBoxColumn()
        reportdesign.DataGridView1.Columns.Insert(0, chk)
        chk.HeaderText = "Check"
        chk.Name = "chk"
        reportdesign.BUT_GEN_VIEW.Select()
        reportdesign.ShowDialog(Me)
    End Sub
End Class