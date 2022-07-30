Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Public Class frm_rkga_MemberAddressList
    Dim gconnection As New GlobalClass
    Public selectNo As Integer
    Private Sub chk_pin_CheckedChanged(sender As Object, e As EventArgs) Handles chk_pin.CheckedChanged
        If chk_pin.Checked = True Then
            chk_pin.Enabled = True
            txt_pin.Enabled = True
            chk_City.Checked = False
            chk_City.Enabled = True
            Cbo_PCity.Enabled = False
            Cbo_PCity.Text = ""
            chk_State.Checked = False
            chk_State.Enabled = True
            Cbo_PState.Enabled = False
            Cbo_PState.Text = ""
            chk_Country.Checked = False
            chk_Country.Enabled = True
            Cbo_PCountry.Enabled = False
            Cbo_PCountry.Text = ""
        End If
       
    End Sub

    Private Sub frm_rkga_MemberAddressList_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.F6 Then
                If btn_clear.Enabled = True Then
                    Call btn_clear_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F9 Then
                If btn_view.Enabled = True Then
                    Call btn_view_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F12 Then
                If btn_print.Enabled = True Then
                    Call btn_print_Click(sender, e)
                    Exit Sub
                End If
                'ElseIf e.KeyCode = Keys.F7 Then
                '    If btnExport.Enabled = True Then
                '        Call btnExport_Click(sender, e)
                '        Exit Sub
                '    End If

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

    Private Sub frm_rkga_MemberAddressList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Call Resize_Form()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        Cbo_PCity.Enabled = False
        Cbo_PCountry.Enabled = False
        Cbo_PState.Enabled = False
        rbtn1.Checked = True
        rbtn2.Checked = False
        Fillcat()
        Fillstts()
        fillcity()
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
                        If Controls(i_i).Name = "GroupBox5" Then
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
                        If Controls(i_i).Name = "GroupBox5" Then
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
                        If Controls(i_i).Name = "btn_clear" Or Controls(i_i).Name = "btn_view" Or Controls(i_i).Name = "btn_print" Or Controls(i_i).Name = "btn_exit" Then
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
        Me.btn_print.Enabled = False
        Me.btn_view.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.btn_view.Enabled = True
                    Me.btn_print.Enabled = True
                    Exit Sub
                End If
                If Right(x) = "V" Then
                    Me.btn_view.Enabled = True
                End If
                If Right(x) = "P" Then
                    Me.btn_print.Enabled = True
                End If
            Next
        End If
    End Sub
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_PCountry.SelectedIndexChanged

    End Sub

    Private Sub Select_Category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Select_Category.SelectedIndexChanged



    End Sub

    Private Sub Fillcat()
        CheckBox1.Checked = False
        Dim Fill_Chk_str As String
        Select_Category.Items.Clear()
        Dim MEMBERTYPE As New DataTable
        selectNo = 0
        Fill_Chk_str = "select  subtypeCode,Subtypedesc  from subcategorymaster"
        MEMBERTYPE = gconnection.GetValues(Fill_Chk_str)
        Dim Itration
        For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
            Select_Category.Items.Add(MEMBERTYPE.Rows(Itration).Item("Subtypedesc"))
        Next
    End Sub
    Private Sub Fillstts()
        CheckBox2.Checked = False
        Try
            For Iteration = 0 To (Select_Status.Items.Count - 1)
                Select_Status.SetItemChecked(Iteration, False)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        '  Dim Fill_Chk_str As String
        ' Select_Status.Items.Clear()
        'Dim MEMBERTYPE As New DataTable
        'selectNo = 0
        'Fill_Chk_str = "SELECT MEMBERTYPE,typedesc FROM MEMBERTYPE"
        'MEMBERTYPE = gconnection.GetValues(Fill_Chk_str)
        'Dim Itration
        'For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
        '    Select_Status.Items.Add(MEMBERTYPE.Rows(Itration).Item("typedesc"))
        'Next
    End Sub
    Private Sub fillcity()
        Cbo_PCity.Items.Clear()
        Cbo_PCity.SelectedIndex = -1
        Cbo_PState.Items.Clear()
        Cbo_PState.SelectedIndex = -1
        Cbo_PCountry.Items.Clear()
        Cbo_PCountry.SelectedIndex = -1
        Dim Sqlstr As String
        Dim MEMBERTYPE As New DataTable
        Sqlstr = " SELECT   DISTINCT(NAME) FROM Tbl_CityMaster"
        MEMBERTYPE = gconnection.GetValues(Sqlstr)
        Dim Itration
        For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
            Cbo_PCity.Items.Add(MEMBERTYPE.Rows(Itration).Item("Name"))
        Next
        Sqlstr = " SELECT  DISTINCT(STATE)  FROM Tbl_CityMaster"
        MEMBERTYPE = gconnection.GetValues(Sqlstr)
        For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
            Cbo_PState.Items.Add(MEMBERTYPE.Rows(Itration).Item("STATE"))
        Next
        Sqlstr = "  SELECT  DISTINCT(COUNTRY)   FROM  Tbl_CityMaster"
        MEMBERTYPE = gconnection.GetValues(Sqlstr)
        For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
            Cbo_PCountry.Items.Add(MEMBERTYPE.Rows(Itration).Item("COUNTRY"))
        Next
    End Sub
    Private Sub fillcity1()
        '  fillcity()
        Dim Sqlstr As String
        Dim MEMBERTYPE As New DataTable
        Sqlstr = " SELECT   DISTINCT(NAME),STATE,COUNTRY FROM Tbl_CityMaster where name='" & Cbo_PCity.Text & "'"
        MEMBERTYPE = gconnection.GetValues(Sqlstr)
        Dim Itration
        For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
            Cbo_PCity.Text = MEMBERTYPE.Rows(Itration).Item("Name")
            Cbo_PState.Text = MEMBERTYPE.Rows(Itration).Item("STATE")
            Cbo_PCountry.Text = MEMBERTYPE.Rows(Itration).Item("COUNTRY")
        Next
    End Sub
    Private Sub fillsate()
        Cbo_PCity.Text = Nothing
        Dim Sqlstr As String
        Dim MEMBERTYPE As New DataTable
        Sqlstr = " SELECT  DISTINCT(STATE),COUNTRY  FROM Tbl_CityMaster where state='" & Cbo_PState.Text & "'"
        MEMBERTYPE = gconnection.GetValues(Sqlstr)
        For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
            Cbo_PState.Text = MEMBERTYPE.Rows(Itration).Item("STATE")
            Cbo_PCountry.Text = MEMBERTYPE.Rows(Itration).Item("COUNTRY")
        Next
    End Sub
    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        If (Select_Category.CheckedItems.Count <= 0) Then
            MessageBox.Show("Select the Category Items")
            Exit Sub
        End If
        If (Select_Status.CheckedItems.Count <= 0) Then
            MessageBox.Show("Select the status")
            Exit Sub
        End If
        PRINTREP = False
        If rbtn1.Checked = True Then
            Call print_stikers()
        ElseIf rbtn2.Checked = True Then
            Call print_stikers1()
        End If
    End Sub
    Public Sub print_stikers()
        Try
            Dim cmdText, phone, mcode, mobile, serialno, email As String
            Dim txtobj1 As TextObject
            Dim txtobj2 As TextObject
            If rdb_wmobile.Checked = True Then
                mobile = "isnull(contcell,'') as contcell"
            Else
                mobile = "'' as contcell"
            End If
            If rdb_wmcode.Checked = True Then
                mcode = "isnull(mcode,'') as mcode"
            Else
                mcode = "'' as mcode"
            End If
            If rdb_wphone.Checked = True Then
                phone = "isnull(CONTPHONE1,'') as CONTPHONE1"
            Else
                phone = "'' as CONTPHONE1"
            End If
            If Chk_Email.Checked = True Then
                email = "isnull(CONTemail,'') as CONTemail"
            Else
                email = "'' as CONTemail"
            End If
            Dim Sqlstr As String
            Dim MEMBERTYPE As New DataTable
            If chk_City.Checked = True Then
                If Cbo_PCity.Text <> "" Then
                    Sqlstr = "select  distinct(CONTCITY) from membermaster  where CONTCITY='" & Cbo_PCity.Text & "'"
                    MEMBERTYPE = gconnection.GetValues(Sqlstr)
                    If MEMBERTYPE.Rows.Count > 0 Then
                        Cbo_PCity.Text = MEMBERTYPE.Rows(0).Item("CONTCITY")
                        cmdText = "select " & email & "," & mcode & "," & phone & "," & mobile & ",mname,isnull(prefix,'') as prefix,isnull(contadd1,'') as contadd1,isnull(contadd2,'') as contadd2,isnull(contadd3,'') as contadd3,isnull(contpin,'') as contpin,isnull(contcity,'') as contcity   from MM_VIEW_MEMBERMASTER where  contcity='" & Cbo_PCity.Text & "'"
                    Else
                        MsgBox("Selected City not found for Any member of Selected Category  ")
                        Exit Sub
                    End If
                Else
                    MsgBox("Select city  ")
                    Exit Sub
                End If
            ElseIf chk_State.Checked = True Then
                If Cbo_PState.Text <> "" Then
                    Sqlstr = "  select  distinct(CONTSTATE) from membermaster  where CONTSTATE='" & Cbo_PState.Text & "'"
                    MEMBERTYPE = gconnection.GetValues(Sqlstr)
                    If MEMBERTYPE.Rows.Count > 0 Then
                        Cbo_PState.Text = MEMBERTYPE.Rows(0).Item("CONTSTATE")
                        cmdText = "select " & email & "," & mcode & "," & phone & "," & mobile & ",mname,isnull(prefix,'') as prefix,isnull(contadd1,'') as contadd1,isnull(contadd2,'') as contadd2,isnull(contadd3,'') as contadd3,isnull(contpin,'') as contpin,isnull(contcity,'') as contcity   from MM_VIEW_MEMBERMASTER where  CONTSTATE='" & Cbo_PState.Text & "'"
                    Else
                        MsgBox("Selected State not found for Any member of Selected Category  ")
                        Exit Sub
                        ' Cbo_PState.Text = MEMBERTYPE.Rows(0).Item("CONTSTATE")
                        'cmdText = "select " & mcode & "," & phone & "," & mobile & ",mname,isnull(prefix,'') as prefix,isnull(contadd1,'') as contadd1,isnull(contadd2,'') as contadd2,isnull(contadd3,'') as contadd3,isnull(contpin,'') as contpin,isnull(contcity,'') as contcity   from MM_VIEW_MEMBERMASTER where  CONTSTATE='" & Cbo_PState.Text & "'"
                    End If
                Else
                    MsgBox("Select State  ")
                    Exit Sub
                End If
            ElseIf chk_Country.Checked = True Then
                If Cbo_PCountry.Text <> "" Then
                    Sqlstr = " SELECT  distinct(CONTCOUNTRY)  FROM membermaster where CONTCOUNTRY='" & Cbo_PCountry.Text & "'"
                    MEMBERTYPE = gconnection.GetValues(Sqlstr)
                    If MEMBERTYPE.Rows.Count > 0 Then
                        Cbo_PCountry.Text = MEMBERTYPE.Rows(0).Item("CONTCOUNTRY")
                        cmdText = "select " & email & "," & mcode & "," & phone & "," & mobile & ",mname,isnull(prefix,'') as prefix,isnull(contadd1,'') as contadd1,isnull(contadd2,'') as contadd2,isnull(contadd3,'') as contadd3,isnull(contpin,'') as contpin,isnull(contcity,'') as contcity   from MM_VIEW_MEMBERMASTER where   CONTCOUNTRY='" & Cbo_PCountry.Text & "'"
                    Else
                        MsgBox("Selected country not found for Any member of Selected Category  ")
                        Exit Sub
                    End If
                Else
                    MsgBox("Select Country  ")
                    Exit Sub
                End If
            ElseIf chk_pin.Checked = True Then
                If txt_pin.Text <> "" Then
                    Sqlstr = "  select  distinct(CONTPIN) from membermaster  where CONTPIN='" & txt_pin.Text & "'"
                    MEMBERTYPE = gconnection.GetValues(Sqlstr)
                    If MEMBERTYPE.Rows.Count > 0 Then
                        txt_pin.Text = MEMBERTYPE.Rows(0).Item("CONTPIN")
                        cmdText = "select " & email & "," & mcode & "," & phone & "," & mobile & ",mname,isnull(prefix,'') as prefix,isnull(contadd1,'') as contadd1,isnull(contadd2,'') as contadd2,isnull(contadd3,'') as contadd3,isnull(contpin,'') as contpin,isnull(contcity,'') as contcity   from MM_VIEW_MEMBERMASTER where CONTPIN='" & txt_pin.Text & "'"
                    Else
                        MsgBox("Entered Pin not found  for Any member of Selected Category ")
                        Exit Sub
                    End If
                Else
                    MsgBox("Enter  pin ")
                    Exit Sub
                End If
            ElseIf chk_all.Checked = True Then
                cmdText = "select " & email & "," & mcode & "," & phone & "," & mobile & ",mname,isnull(prefix,'') as prefix,isnull(contadd1,'') as contadd1,isnull(contadd2,'') as contadd2,isnull(contadd3,'') as contadd3,isnull(contpin,'') as contpin,isnull(contcity,'') as contcity   from MM_VIEW_MEMBERMASTER "
            Else
                MsgBox("Select  city or state or country or pin ")
                Exit Sub
            End If
            txtCategory.Text = ""
                    txt_status.Text = ""
                    Dim o As Object
                    For Each o In Select_Category.CheckedItems
                        txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            If chk_all.Checked = True And chk_City.Checked = False And chk_Country.Checked = False And chk_pin.Checked = False And chk_State.Checked = False Then
                cmdText = cmdText & " where memberType in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            ElseIf chk_all.Checked = True And (chk_City.Checked = True Or chk_Country.Checked = True Or chk_pin.Checked = True Or chk_State.Checked = True) Then
                cmdText = cmdText & " and memberType in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            Else
                cmdText = cmdText & " and memberType in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            End If

                    For Each o In Select_Status.CheckedItems
                        txt_status.Text += "'" & o.ToString() & "',"
                    Next o
                    cmdText = cmdText & " and curentstatus in (" & txt_status.Text.Substring(0, txt_status.Text.Length - 1) & ")"
                    If (txt_mcode2.Text <> "" And txt_mcode1.Text <> "") Then
                        cmdText = cmdText & " and mcode between '" & txt_mcode2.Text & "' and '" & txt_mcode1.Text & "'"
                    End If
                    cmdText = cmdText & "order by mcode asc"
                    gconnection.getDataSet(cmdText, "MM_VIEW_MEMBERMASTER")
                    If gdataset.Tables("MM_VIEW_MEMBERMASTER").Rows.Count <= 0 Then
                        MessageBox.Show("Address Not Found Or Give Correct Input")
                    Else
                Dim Viewer As New REPORTVIEWER
                        If rdb_wserialno.Checked = True Then
                            Dim r As New Cry_contact_stikers
                            Call Viewer.GetDetails(cmdText, "MM_VIEW_MEMBERMASTER", r)
                            'txtobj1 = r.ReportDefinition.ReportObjects("Text1")
                            'txtobj1.Text = UCase(gCompanyname)
                            'txtobj1 = r.ReportDefinition.ReportObjects("Text2")
                            'txtobj1.Text = UCase(gCompanyAddress(1))
                            'txtobj1 = r.ReportDefinition.ReportObjects("Text3")
                            'txtobj1.Text = UCase(gCompanyAddress(2))
                            ''txtobj1 = r.ReportDefinition.ReportObjects("Text4")
                            ''txtobj1.Text = UCase(gCompanyAddress(3))
                            ''txtobj1 = r.ReportDefinition.ReportObjects("Text5")
                            ''txtobj1.Text = UCase(gCompanyAddress(4))
                            'txtobj1 = r.ReportDefinition.ReportObjects("Text6")
                            'txtobj1.Text = UCase(gUsername)
                            Viewer.TableName = "MM_VIEW_MEMBERMASTER"
                            Viewer.Show()
                        Else
                            Dim r As New Cry_contact_stikers2
                            Call Viewer.GetDetails(cmdText, "MM_VIEW_MEMBERMASTER", r)
                            'txtobj1 = r.ReportDefinition.ReportObjects("Text1")
                            'txtobj1.Text = UCase(gCompanyname)
                            'txtobj1 = r.ReportDefinition.ReportObjects("Text2")
                            'txtobj1.Text = UCase(gCompanyAddress(1))
                            'txtobj1 = r.ReportDefinition.ReportObjects("Text3")
                            'txtobj1.Text = UCase(gCompanyAddress(2))
                            ''txtobj1 = r.ReportDefinition.ReportObjects("Text4")
                            ''txtobj1.Text = UCase(gCompanyAddress(3))
                            ''txtobj1 = r.ReportDefinition.ReportObjects("Text5")
                            ''txtobj1.Text = UCase(gCompanyAddress(4))
                            'txtobj1 = r.ReportDefinition.ReportObjects("Text6")
                            'txtobj1.Text = UCase(gUsername)
                            Viewer.TableName = "MM_VIEW_MEMBERMASTER"
                            Viewer.Show()
                        End If
                    End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub print_stikers1()
        Try
            Dim cmdText, phone, mcode, mobile, serialno, email As String
            Dim txtobj1 As TextObject
            Dim txtobj2 As TextObject
            If rdb_wmobile.Checked = True Then
                mobile = "isnull(contcell,'') as contcell"
            Else
                mobile = "''"
            End If
            If rdb_wmcode.Checked = True Then
                mcode = "isnull(mcode,'') as mcode"
            Else
                mcode = "''"
            End If
            If rdb_wphone.Checked = True Then
                phone = "isnull(CONTPHONE1,'') as CONTPHONE1"
            Else
                phone = "''"
            End If
            If Chk_Email.Checked = True Then
                email = "isnull(CONTemail,'') as CONTemail"
            Else
                email = "'' as CONTemail"
            End If
            Dim Sqlstr As String
            Dim MEMBERTYPE As New DataTable
            If chk_City.Checked = True Then
                If Cbo_PCity.Text <> "" Then
                    Sqlstr = "select  distinct(CONTCITY) from membermaster  where CONTCITY='" & Cbo_PCity.Text & "'"
                    MEMBERTYPE = gconnection.GetValues(Sqlstr)
                    If MEMBERTYPE.Rows.Count > 0 Then
                        Cbo_PCity.Text = MEMBERTYPE.Rows(0).Item("CONTCITY")
                        cmdText = "select " & email & "," & mcode & "," & phone & "," & mobile & ",mname,isnull(prefix,'') as prefix,isnull(contadd1,'') as contadd1,isnull(contadd2,'') as contadd2,isnull(contadd3,'') as contadd3,isnull(contpin,'') as contpin,isnull(contcity,'') as contcity   from MM_VIEW_MEMBERMASTER where  contcity='" & Cbo_PCity.Text & "'"
                    Else
                        MsgBox("Selected City not found for Any member of Selected Category  ")
                        Exit Sub
                    End If
                Else
                    MsgBox("Select city  ")
                    Exit Sub
                End If
            ElseIf chk_State.Checked = True Then
                If Cbo_PState.Text <> "" Then
                    Sqlstr = "  select  distinct(CONTSTATE) from membermaster  where CONTSTATE='" & Cbo_PState.Text & "'"
                    MEMBERTYPE = gconnection.GetValues(Sqlstr)
                    If MEMBERTYPE.Rows.Count > 0 Then
                        Cbo_PState.Text = MEMBERTYPE.Rows(0).Item("CONTSTATE")
                        cmdText = "select " & email & "," & mcode & "," & phone & "," & mobile & ",mname,isnull(prefix,'') as prefix,isnull(contadd1,'') as contadd1,isnull(contadd2,'') as contadd2,isnull(contadd3,'') as contadd3,isnull(contpin,'') as contpin,isnull(contcity,'') as contcity   from MM_VIEW_MEMBERMASTER where  CONTSTATE='" & Cbo_PState.Text & "'"
                    Else
                        MsgBox("Selected State not found for Any member of Selected Category  ")
                        Exit Sub
                        ' Cbo_PState.Text = MEMBERTYPE.Rows(0).Item("CONTSTATE")
                        'cmdText = "select " & mcode & "," & phone & "," & mobile & ",mname,isnull(prefix,'') as prefix,isnull(contadd1,'') as contadd1,isnull(contadd2,'') as contadd2,isnull(contadd3,'') as contadd3,isnull(contpin,'') as contpin,isnull(contcity,'') as contcity   from MM_VIEW_MEMBERMASTER where  CONTSTATE='" & Cbo_PState.Text & "'"
                    End If
                Else
                    MsgBox("Select State  ")
                    Exit Sub
                End If
            ElseIf chk_Country.Checked = True Then
                If Cbo_PCountry.Text <> "" Then
                    Sqlstr = " SELECT  distinct(CONTCOUNTRY)  FROM membermaster where CONTCOUNTRY='" & Cbo_PCountry.Text & "'"
                    MEMBERTYPE = gconnection.GetValues(Sqlstr)
                    If MEMBERTYPE.Rows.Count > 0 Then
                        Cbo_PCountry.Text = MEMBERTYPE.Rows(0).Item("CONTCOUNTRY")
                        cmdText = "select " & email & "," & mcode & "," & phone & "," & mobile & ",mname,isnull(prefix,'') as prefix,isnull(contadd1,'') as contadd1,isnull(contadd2,'') as contadd2,isnull(contadd3,'') as contadd3,isnull(contpin,'') as contpin,isnull(contcity,'') as contcity   from MM_VIEW_MEMBERMASTER where   CONTCOUNTRY='" & Cbo_PCountry.Text & "'"
                    Else
                        MsgBox("Selected country not found for Any member of Selected Category  ")
                        Exit Sub
                    End If
                Else
                    MsgBox("Select Country  ")
                    Exit Sub
                End If
            ElseIf chk_pin.Checked = True Then
                If txt_pin.Text <> "" Then
                    Sqlstr = "  select  distinct(CONTPIN) from membermaster  where CONTPIN='" & txt_pin.Text & "'"
                    MEMBERTYPE = gconnection.GetValues(Sqlstr)
                    If MEMBERTYPE.Rows.Count > 0 Then
                        txt_pin.Text = MEMBERTYPE.Rows(0).Item("CONTPIN")
                        cmdText = "select " & email & "," & mcode & "," & phone & "," & mobile & ",mname,isnull(prefix,'') as prefix,isnull(contadd1,'') as contadd1,isnull(contadd2,'') as contadd2,isnull(contadd3,'') as contadd3,isnull(contpin,'') as contpin,isnull(contcity,'') as contcity   from MM_VIEW_MEMBERMASTER where CONTPIN='" & txt_pin.Text & "'"
                    Else
                        MsgBox("Entered Pin not found  for Any member of Selected Category ")
                        Exit Sub
                    End If
                Else
                    MsgBox("Enter  pin ")
                    Exit Sub
                End If
            ElseIf chk_all.Checked = True Then
                cmdText = "select " & email & "," & mcode & "," & phone & "," & mobile & ",mname,isnull(prefix,'') as prefix,isnull(contadd1,'') as contadd1,isnull(contadd2,'') as contadd2,isnull(contadd3,'') as contadd3,isnull(contpin,'') as contpin,isnull(contcity,'') as contcity   from MM_VIEW_MEMBERMASTER "
            Else
                MsgBox("Select  city or state or country or pin ")
                Exit Sub
            End If
            txtCategory.Text = ""
            txt_status.Text = ""
            Dim o As Object
            For Each o In Select_Category.CheckedItems
                txtCategory.Text += "'" & o.ToString() & "',"
            Next o
            If chk_all.Checked = True And chk_City.Checked = False And chk_Country.Checked = False And chk_pin.Checked = False And chk_State.Checked = False Then
                cmdText = cmdText & " where memberType in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            ElseIf chk_all.Checked = True And (chk_City.Checked = True Or chk_Country.Checked = True Or chk_pin.Checked = True Or chk_State.Checked = True) Then
                cmdText = cmdText & " and memberType in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            Else
                cmdText = cmdText & " and memberType in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
            End If

            For Each o In Select_Status.CheckedItems
                txt_status.Text += "'" & o.ToString() & "',"
            Next o
            cmdText = cmdText & " and curentstatus in (" & txt_status.Text.Substring(0, txt_status.Text.Length - 1) & ")"
            If (txt_mcode2.Text <> "" And txt_mcode1.Text <> "") Then
                cmdText = cmdText & " and mcode between '" & txt_mcode2.Text & "' and '" & txt_mcode1.Text & "'"
            End If
            cmdText = cmdText & "order by mcode asc"
            gconnection.getDataSet(cmdText, "MM_VIEW_MEMBERMASTER")
            If gdataset.Tables("MM_VIEW_MEMBERMASTER").Rows.Count <= 0 Then
                MessageBox.Show("Address Not Found Or Give Correct Input")
            Else
                Dim Viewer As New REPORTVIEWER
                If rdb_wserialno.Checked = True Then
                    Dim r As New Cry_contact_stikers1
                    Call Viewer.GetDetails(cmdText, "MM_VIEW_MEMBERMASTER", r)
                    'txtobj1 = r.ReportDefinition.ReportObjects("Text1")
                    'txtobj1.Text = UCase(gCompanyname)
                    'txtobj1 = r.ReportDefinition.ReportObjects("Text2")
                    'txtobj1.Text = UCase(gCompanyAddress(1))
                    'txtobj1 = r.ReportDefinition.ReportObjects("Text3")
                    'txtobj1.Text = UCase(gCompanyAddress(2))
                    ''txtobj1 = r.ReportDefinition.ReportObjects("Text4")
                    ''txtobj1.Text = UCase(gCompanyAddress(3))
                    ''txtobj1 = r.ReportDefinition.ReportObjects("Text5")
                    ''txtobj1.Text = UCase(gCompanyAddress(4))
                    'txtobj1 = r.ReportDefinition.ReportObjects("Text6")
                    '   txtobj1.Text = UCase(gUsername)
                    Viewer.TableName = "MM_VIEW_MEMBERMASTER"
                    Viewer.Show()
                Else
                    Dim r As New Cry_contact_stikers3
                    Call Viewer.GetDetails(cmdText, "MM_VIEW_MEMBERMASTER", r)
                    'txtobj1 = r.ReportDefinition.ReportObjects("Text1")
                    'txtobj1.Text = UCase(gCompanyname)
                    'txtobj1 = r.ReportDefinition.ReportObjects("Text2")
                    'txtobj1.Text = UCase(gCompanyAddress(1))
                    'txtobj1 = r.ReportDefinition.ReportObjects("Text3")
                    'txtobj1.Text = UCase(gCompanyAddress(2))
                    ''txtobj1 = r.ReportDefinition.ReportObjects("Text4")
                    ''txtobj1.Text = UCase(gCompanyAddress(3))
                    ''txtobj1 = r.ReportDefinition.ReportObjects("Text5")
                    ''txtobj1.Text = UCase(gCompanyAddress(4))
                    'txtobj1 = r.ReportDefinition.ReportObjects("Text6")
                    'txtobj1.Text = UCase(gUsername)
                    Viewer.TableName = "MM_VIEW_MEMBERMASTER"
                    Viewer.Show()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
 

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        fillcity()
        Fillcat()
        Fillstts()
        Chk_Email.Checked = False
        chk_City.Checked = False
        chk_State.Checked = False
        chk_Country.Checked = False
        rdb_wmcode.Checked = False
        rdb_wmobile.Checked = False
        rdb_wphone.Checked = False
        rdb_wserialno.Checked = False
        Cbo_PCity.Enabled = False
        Cbo_PCountry.Enabled = False
        Cbo_PState.Enabled = False
        txt_mcode1.Text = ""
        txt_mcode2.Text = ""
        txt_pin.Text = ""
        txt_status.Text = ""
        txtCategory.Text = ""
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click

    End Sub



    Private Sub btn_mcodehelp_Click_1(sender As Object, e As EventArgs) Handles btn_mcodehelp.Click
        Dim vform As New LIST_OPERATION1
        gSQLString = "Select   ISNULL(MCODE,'') as MEMBEER_CODE,ISNULL(MNAME,'') AS MEMBER_NAME  from membermaster "
        M_WhereCondition = " where curentstatus='ACTIVE' "
        vform.Field = "MCODE,MNAME"
        vform.vCaption = "MEMBER MASTER HELP "
        vform.TXT_SEARCH_TXT.Select()
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_mcode2.Text = Trim(vform.keyfield & "")
            Me.mcodeFILL2()
            vform.Close()
            vform = Nothing
        End If
        gconnection.closeConnection()
    End Sub
    Private Sub mcodeFILL2()
        If Trim(txt_mcode2.Text) <> "" Then
            Dim MEMBERNAME As New DataTable
            Dim STRQUERY As String
            Dim freezeflag As String
            STRQUERY = "SELECT ISNULL(MCODE,'') as MEMBEER_CODE,ISNULL(MNAME,'') AS MEMBER_NAME  FROM MEMBERMASTER  WHERE MCODE='" & Trim(txt_mcode2.Text) & "'"
            MEMBERNAME = gconnection.GetValues(STRQUERY)
            If MEMBERNAME.Rows.Count > 0 Then
                txt_mcode2.ReadOnly = True
                txt_mcode2.Text = MEMBERNAME.Rows(0).Item("MEMBEER_CODE")
                txt_mcode2.ReadOnly = True
                txt_mcode1.Select()
            End If
        End If
    End Sub
    Private Sub mcodeFILL1()
        If Trim(txt_mcode1.Text) <> "" Then
            Dim MEMBERNAME As New DataTable
            Dim STRQUERY As String
            Dim freezeflag As String
            STRQUERY = "SELECT ISNULL(MCODE,'') as MEMBEER_CODE,ISNULL(MNAME,'') AS MEMBER_NAME  FROM MEMBERMASTER  WHERE MCODE='" & Trim(txt_mcode1.Text) & "'"
            MEMBERNAME = gconnection.GetValues(STRQUERY)
            If MEMBERNAME.Rows.Count > 0 Then
                txt_mcode1.ReadOnly = True
                txt_mcode1.Text = MEMBERNAME.Rows(0).Item("MEMBEER_CODE")
                txt_mcode1.ReadOnly = True
            End If
        End If
    End Sub
    Private Sub btn_mcodehelp1_Click(sender As Object, e As EventArgs) Handles btn_mcodehelp1.Click
        Dim vform As New LIST_OPERATION1
        gSQLString = "Select   ISNULL(MCODE,'') as MEMBEER_CODE,ISNULL(MNAME,'') AS MEMBER_NAME  from membermaster "
        M_WhereCondition = " where curentstatus='ACTIVE' "
        vform.Field = "MCODE,MNAME"
        vform.vCaption = "MEMBER MASTER HELP "
        vform.TXT_SEARCH_TXT.Select()
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_mcode1.Text = Trim(vform.keyfield & "")
            Me.mcodeFILL1()
            vform.Close()
            vform = Nothing
        End If
        gconnection.closeConnection()
    End Sub

    Private Sub txt_mcode2_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_mcode2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btn_mcodehelp_Click_1(sender, e)
        ElseIf e.KeyCode = Keys.F4 Then
            btn_mcodehelp_Click_1(sender, e)
        End If
    End Sub


    Private Sub txt_mcode2_TextChanged(sender As Object, e As EventArgs) Handles txt_mcode2.TextChanged

    End Sub

    Private Sub rbtn1_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn1.CheckedChanged
        If rbtn1.Checked = True Then
            rbtn2.Checked = False
            rbtn1.Checked = True
        Else
            rbtn2.Checked = True
            rbtn1.Checked = False
        End If
    End Sub

    Private Sub rbtn2_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn2.CheckedChanged
        If rbtn2.Checked = True Then
            rbtn2.Checked = True
            rbtn1.Checked = False
        Else
            rbtn2.Checked = False
            rbtn1.Checked = True
        End If
    End Sub

    Private Sub chk_City_CheckedChanged(sender As Object, e As EventArgs) Handles chk_City.CheckedChanged
        If chk_City.Checked = True Then
            chk_City.Enabled = True
            chk_State.Enabled = True
            chk_Country.Enabled = True
            Cbo_PCity.Enabled = True
            Cbo_PState.Enabled = False
            Cbo_PCountry.Enabled = False
            chk_State.Checked = False
            chk_Country.Checked = False
            chk_pin.Checked = False
            chk_pin.Enabled = True
            txt_pin.Enabled = False
            txt_pin.Text = ""
        End If
    End Sub

    Private Sub chk_State_CheckedChanged(sender As Object, e As EventArgs) Handles chk_State.CheckedChanged
        If chk_State.Checked = True Then
            chk_City.Enabled = True
            Cbo_PCity.Enabled = False
            chk_City.Checked = False
            chk_Country.Checked = False
            Cbo_PCity.Text = ""
            Cbo_PCountry.Enabled = False
            Cbo_PState.Enabled = True
            chk_pin.Checked = False
            chk_pin.Enabled = True
            txt_pin.Enabled = False
            txt_pin.Text = ""
        End If
    End Sub

    Private Sub chk_Country_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Country.CheckedChanged
        If chk_Country.Checked = True Then
            chk_City.Checked = False
            chk_City.Enabled = True
            Cbo_PCity.Enabled = False
            Cbo_PCity.Text = ""
            chk_pin.Checked = False
            chk_pin.Enabled = True
            txt_pin.Enabled = False
            txt_pin.Text = ""
            chk_State.Checked = False
            chk_State.Enabled = True
            Cbo_PState.Enabled = False
            Cbo_PState.Text = ""
            chk_Country.Checked = True
            chk_Country.Enabled = True
            Cbo_PCountry.Enabled = True
        End If
    End Sub

    Private Sub Cbo_PCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_PCity.SelectedIndexChanged
        If chk_City.Checked = True Then
            fillcity1()
        End If
    End Sub

    Private Sub Cbo_PState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_PState.SelectedIndexChanged
        If chk_State.Checked = True Then
            fillsate()
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

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Dim Iteration As Integer
        If CheckBox2.Checked = True Then
            Try
                For Iteration = 0 To (Select_Status.Items.Count - 1)
                    Select_Status.SetSelected(Iteration, True)
                    Select_Status.SetItemChecked(Iteration, True)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                For Iteration = 0 To (Select_Status.Items.Count - 1)
                    Select_Status.SetItemChecked(Iteration, False)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub txt_mcode1_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_mcode1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btn_mcodehelp1_Click(sender, e)
        ElseIf e.KeyCode = Keys.F4 Then
            btn_mcodehelp1_Click(sender, e)
        End If
    End Sub

    Private Sub txt_mcode1_TextChanged(sender As Object, e As EventArgs) Handles txt_mcode1.TextChanged

    End Sub


End Class