Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient
Imports System.IO
Public Class FRM_CCLOUTLET
    Dim txtobj1 As TextObject
    Dim STR_TYPE As String

    Private Sub FRM_CCLOUTLET_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.F6 Then
                If cmd_Clear.Enabled = True Then
                    Call cmd_Clear_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F9 Then
                If cmd_View.Enabled = True Then
                    Call cmd_View_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F12 Then
                If Button5.Enabled = True Then
                    'Call button5_click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
                If Cmd_Exit.Enabled = True Then
                    ' Call Button4_Click(sender, e)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub FRM_CCLOUTLET_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Call Resize_Form()
        Try
            SYS_DATE_TIME()
            Fromdate.Value = Format(SYSDATE, "dd/MM/yyyy")
            todate.Value = Format(SYSDATE, "dd/MM/yyyy")
            Call MemberType_Load()
            ' Member_Master_Load()
            'Call GETLIST()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
                        If Controls(i_i).Name = "GroupBox4" Then
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
                        If Controls(i_i).Name = "cmd_Clear" Or Controls(i_i).Name = "cmd_View" Or Controls(i_i).Name = "Button5" Or Controls(i_i).Name = "Cmd_Exit" Then
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
    Private Sub SYS_DATE_TIME()
        Dim sqlstring As String
        Try
            sqlstring = "SELECT SERVERDATE,SERVERTIME FROM VIEW_SERVER_DATETIME "
            gconnection.getDataSet(sqlstring, "SERVERDATE")
            If gdataset.Tables("SERVERDATE").Rows.Count > 0 Then
                sysdate = Format(gdataset.Tables("SERVERDATE").Rows(0).Item("SERVERDATE"), "dd/MM/yyyy")
            End If
        Catch ex As Exception
            MessageBox.Show("Enter a valid datetime :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub

        End Try
    End Sub
    Private Sub MemberType_Load()
        Try
            Dim SSQL As String
            Dim DT As New DataTable
            CHKLIST_SELECT.Items.Clear()
            SSQL = " Select isnull(subtypecode,'') as Membertype,isnull(subtypedesc,'') as Typedesc From SUBCATEGORYMASTER "
            SSQL = SSQL & "union all select distinct isnull(MEMBERTYPECODE,'') as Membertype,'SMART CARD' as Typedesc from membermaster where MEMBERTYPECODE not in (Select isnull(subtypecode,'')  From SUBCATEGORYMASTER)"
            DT = gconnection.GetValues(SSQL)
            If DT.Rows.Count > 0 Then
                For Iteration = 0 To (DT.Rows.Count - 1)
                    CHKLIST_SELECT.Items.Add(DT.Rows(Iteration).Item("membertype") & "." & DT.Rows(Iteration).Item("typedesc"))
                Next
            Else
                CHKLIST_SELECT.Items.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmd_View_Click(sender As Object, e As EventArgs)

        GPRINT = False
        If ComboBox1.SelectedItem = "ALL" Then
            Call ALL_CATEGORY()
        ElseIf ComboBox1.SelectedItem = "PERMANENT" Then
            Call Permanent()
        ElseIf ComboBox1.SelectedItem = "CORPORATE" Then
            Call Corporate()
        ElseIf ComboBox1.SelectedItem = "CLUB WELFARE" Then
            Call CLUBWELFARE()
        ElseIf ComboBox1.SelectedItem = "TEMP MEM OF CORP HOUSE" Then
            Call TEMPMEMOFCORPHOUSE()
        End If
        'Try
        '    Dim HEADING As String
        '    Dim cmdText, dateofbillfrom, dateofbillto As String
        '    Dim Viewer As New REPORTVIEWER
        '    Dim r As New Cry_Creditadvice
        '    If ComboBox1.Text = "CREDIT ADVICE" Then
        '        cmdText = "select ISNULL(voucherno,'')AS VOUCHERNO,ISNULL(voucherdate,'')AS VOUCHERDATE,slcode,sldesc,ISNULL(amount,0)AS AMOUNT from journalentry where voucherno like'CRN%' AND Accountcode='SDRS' "
        '        If (Fromdate.Text <> "") And (todate.Text <> "") Then
        '            cmdText = cmdText & " and cast(convert(varchar(11),voucherdate,106) as datetime)between  '" & Format(Fromdate.Value, "yyyy-MM-dd") & "' and '" & Format(todate.Value, "yyyy-MM-dd") & "' "
        '            'praba
        '            dateofbillfrom = Fromdate.Text
        '            dateofbillto = todate.Text
        '            HEADING = "CREDIT ADVICE"
        '            Call Viewer.GetDetails(cmdText, "journalentry", r)
        '            txtobj1 = r.ReportDefinition.ReportObjects("Text26")
        '            txtobj1.Text = Fromdate.Text
        '            txtobj1 = r.ReportDefinition.ReportObjects("Text27")
        '            txtobj1.Text = todate.Text
        '            txtobj1 = r.ReportDefinition.ReportObjects("Text28")
        '            txtobj1.Text = UCase(HEADING)

        '            txtobj1 = r.ReportDefinition.ReportObjects("Text7")
        '            txtobj1.Text = UCase(gFinancalyearStart)
        '            txtobj1 = r.ReportDefinition.ReportObjects("Text22")
        '            txtobj1.Text = UCase(gFinancialyearEnd)

        '            ' Call Viewer.GetDetails(cmdText, "journalentry", r)
        '            txtobj1 = r.ReportDefinition.ReportObjects("Text1")
        '            txtobj1.Text = UCase(gcompanyname)
        '            txtobj1 = r.ReportDefinition.ReportObjects("Text2")
        '            txtobj1.Text = UCase(gCompanyAddress(0))
        '            txtobj1 = r.ReportDefinition.ReportObjects("Text3")
        '            txtobj1.Text = UCase(gCompanyAddress(1))
        '            txtobj1 = r.ReportDefinition.ReportObjects("Text4")
        '            txtobj1.Text = UCase(gCompanyAddress(2))
        '            txtobj1 = r.ReportDefinition.ReportObjects("Text19")
        '            txtobj1.Text = UCase(gCompanyAddress(3))
        '            txtobj1 = r.ReportDefinition.ReportObjects("Text25")
        '            txtobj1.Text = UCase(gCompanyAddress(4))


        '            txtobj1 = r.ReportDefinition.ReportObjects("Text24")
        '            txtobj1.Text = UCase(gUsername)
        '            Viewer.ssql = cmdText
        '            Viewer.Report = r
        '            Viewer.TableName = "journalentry"
        '            Viewer.Show()
        '            ' Call Cry_Creditadvice()
        '        End If

        '        '    cmdText = cmdText & " where voucherdate in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ")"
        '    Else

        '        ComboBox1.Text = "DEBIT ADVICE"

        '        cmdText = "select voucherno,voucherdate,slcode,sldesc,amount from journalentry where voucherno like'DBN%' AND Accountcode='SDRS'"
        '        If (Fromdate.Text <> "") And (todate.Text <> "") Then
        '            cmdText = cmdText & " and cast(convert(varchar(11),voucherdate,106) as datetime)between  '" & Format(Fromdate.Value, "yyyy-MM-dd") & "' and '" & Format(todate.Value, "yyyy-MM-dd") & "' "
        '            Dim r1 As New Cry_Debitadvice
        '            HEADING = "DEBIT ADVICE"
        '            Call Viewer.GetDetails(cmdText, "journalentry", r)
        '            txtobj1 = r.ReportDefinition.ReportObjects("Text26")
        '            txtobj1.Text = Fromdate.Text
        '            txtobj1 = r.ReportDefinition.ReportObjects("Text27")
        '            txtobj1.Text = todate.Text
        '            txtobj1 = r.ReportDefinition.ReportObjects("Text28")
        '            txtobj1.Text = UCase(HEADING)

        '            txtobj1 = r.ReportDefinition.ReportObjects("Text7")
        '            txtobj1.Text = UCase(gFinancalyearStart)
        '            txtobj1 = r.ReportDefinition.ReportObjects("Text22")
        '            txtobj1.Text = UCase(gFinancialyearEnd)

        '            ' Call Viewer.GetDetails(cmdText, "journalentry", r)
        '            txtobj1 = r.ReportDefinition.ReportObjects("Text1")
        '            txtobj1.Text = UCase(gcompanyname)
        '            txtobj1 = r.ReportDefinition.ReportObjects("Text2")
        '            txtobj1.Text = UCase(gCompanyAddress(0))
        '            txtobj1 = r.ReportDefinition.ReportObjects("Text3")
        '            txtobj1.Text = UCase(gCompanyAddress(1))
        '            txtobj1 = r.ReportDefinition.ReportObjects("Text4")
        '            txtobj1.Text = UCase(gCompanyAddress(2))

        '            txtobj1 = r.ReportDefinition.ReportObjects("Text21")
        '            txtobj1.Text = UCase(gCompanyAddress(3))
        '            txtobj1 = r.ReportDefinition.ReportObjects("Text24")
        '            txtobj1.Text = UCase(gCompanyAddress(4))


        '            txtobj1 = r.ReportDefinition.ReportObjects("Text17")
        '            txtobj1.Text = UCase(gUsername)
        '            Viewer.ssql = cmdText
        '            Viewer.Report = r
        '            Viewer.TableName = "journalentry"
        '            Viewer.Show()
        '        End If

        '    End If

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub
    Private Sub ALL_CATEGORY()
        ' Dim HEADING As String
        Dim cmdText, dateofbillfrom, dateofbillto As String
        Dim Viewer As New REPORTVIEWER
        Dim r As New Cry_Allcatoutlet
        cmdText = "select ISNULL(upper(A.POSDESC),'') as POSDESC,SUM(ISNULL(A.AMOUNT,0)) as AMOUNT,SUM(ISNULL(A.VAT14,0)) as VAT14,SUM(ISNULL(A.VAT25 ,0)) as VAT25,SUM(ISNULL(A.VAT35 ,0)) as VAT35,SUM(ISNULL(A.VAT7,0)) as VAT7,SUM(ISNULL(A.VAT5 ,0)) as VAT5,SUM(ISNULL(A.SERTAX4  ,0)) as SERTAX4,SUM(ISNULL(A.SERTAX12,0)) as SERTAX12,SUM(ISNULL(A.SCharge,0)) as SCharge,SUM(ISNULL(A.SERVICE_CHARGE ,0)) as SERVICE_CHARG  from MEMBER_CONSUMPTION_OUTLET a, MEMBERMASTER b"
        cmdText = cmdText & " where a.mcode=b.mcode "
        If (Fromdate.Text <> "") And (todate.Text <> "") Then
            cmdText = cmdText & " and cast(convert(varchar(11),KOTDATE,106) as datetime)between  '" & Format(Fromdate.Value, "yyyy-MM-dd") & "' and '" & Format(todate.Value, "yyyy-MM-dd") & "'  group by A.POSDESC,SNO ORDER BY SNO"
            'praba
            dateofbillfrom = Fromdate.Text
            dateofbillto = todate.Text
            'HEADING = "CREDIT ADVICE"
            ' Call Viewer.GetDetails(cmdText, "MEMBER_CONSUMPTION_OUTLET", r)
            Call Viewer.GetDetails1(cmdText, "MEMBER_CONSUMPTION_OUTLET", r)
            txtobj1 = r.ReportDefinition.ReportObjects("Text39")
            txtobj1.Text = Fromdate.Text
            txtobj1 = r.ReportDefinition.ReportObjects("Text41")
            txtobj1.Text = todate.Text
            ' txtobj1 = r.ReportDefinition.ReportObjects("Text28")
            'txtobj1.Text = UCase(HEADING)

            'txtobj1 = r.ReportDefinition.ReportObjects("Text7")
            'txtobj1.Text = UCase(gFinancalyearStart)
            'txtobj1 = r.ReportDefinition.ReportObjects("Text22")
            'txtobj1.Text = UCase(gFinancialyearEnd)

            '' Call Viewer.GetDetails(cmdText, "journalentry", r)
            txtobj1 = r.ReportDefinition.ReportObjects("Text36")
            txtobj1.Text = UCase(gcompanyname)
            'txtobj1 = r.ReportDefinition.ReportObjects("Text2")
            'txtobj1.Text = UCase(gCompanyAddress(0))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text3")
            'txtobj1.Text = UCase(gCompanyAddress(1))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text4")
            'txtobj1.Text = UCase(gCompanyAddress(2))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text19")
            'txtobj1.Text = UCase(gCompanyAddress(3))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text25")
            'txtobj1.Text = UCase(gCompanyAddress(4))


            'txtobj1 = r.ReportDefinition.ReportObjects("Text24")
            'txtobj1.Text = UCase(gUsername)
            'Viewer.ssql = cmdText
            'Viewer.Report = r
            'Viewer.TableName = "journalentry"
            txtobj1 = r.ReportDefinition.ReportObjects("Text37")
            txtobj1.Text = UCase("OUTLETWISE REVENUE SUMMARY")
            Viewer.Show()
            ' Call Cry_Creditadvice()
        End If
    End Sub
    Private Sub Permanent()
        ' Dim HEADING As String
        Dim cmdText, dateofbillfrom, dateofbillto As String
        Dim Viewer As New REPORTVIEWER
        Dim r As New Cry_Allcatoutlet
        cmdText = "select ISNULL(upper(A.POSDESC),'') as POSDESC,SUM(ISNULL(A.AMOUNT,0)) as AMOUNT,SUM(ISNULL(A.VAT14,0)) as VAT14,SUM(ISNULL(A.VAT25 ,0)) as VAT25,SUM(ISNULL(A.VAT35 ,0)) as VAT35,SUM(ISNULL(A.VAT7,0)) as VAT7,SUM(ISNULL(A.VAT5 ,0)) as VAT5,SUM(ISNULL(A.SERTAX4  ,0)) as SERTAX4,SUM(ISNULL(A.SERTAX12,0)) as SERTAX12,SUM(ISNULL(A.SCharge,0)) as SCharge,SUM(ISNULL(A.SERVICE_CHARGE ,0)) as SERVICE_CHARG  from MEMBER_CONSUMPTION_OUTLET a, MEMBERMASTER b"
        cmdText = cmdText & " where a.mcode=b.mcode and isnull(b.MEMBERTYPECODE,'') in ('P')"
        If (Fromdate.Text <> "") And (todate.Text <> "") Then
            cmdText = cmdText & " and cast(convert(varchar(11),KOTDATE,106) as datetime)between  '" & Format(Fromdate.Value, "yyyy-MM-dd") & "' and '" & Format(todate.Value, "yyyy-MM-dd") & "'  group by A.POSDESC,SNO ORDER BY SNO"
            'praba
            dateofbillfrom = Fromdate.Text
            dateofbillto = todate.Text
            'HEADING = "CREDIT ADVICE"
            ' Call Viewer.GetDetails(cmdText, "MEMBER_CONSUMPTION_OUTLET", r)
            Call Viewer.GetDetails1(cmdText, "MEMBER_CONSUMPTION_OUTLET", r)
            txtobj1 = r.ReportDefinition.ReportObjects("Text39")
            txtobj1.Text = Fromdate.Text
            txtobj1 = r.ReportDefinition.ReportObjects("Text41")
            txtobj1.Text = todate.Text
            ' txtobj1 = r.ReportDefinition.ReportObjects("Text28")
            'txtobj1.Text = UCase(HEADING)
            'txtobj1 = r.ReportDefinition.ReportObjects("Text7")
            'txtobj1.Text = UCase(gFinancalyearStart)
            'txtobj1 = r.ReportDefinition.ReportObjects("Text22")
            'txtobj1.Text = UCase(gFinancialyearEnd)
            '' Call Viewer.GetDetails(cmdText, "journalentry", r)
            txtobj1 = r.ReportDefinition.ReportObjects("Text36")
            txtobj1.Text = UCase(gcompanyname)
            'txtobj1 = r.ReportDefinition.ReportObjects("Text2")
            'txtobj1.Text = UCase(gCompanyAddress(0))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text3")
            'txtobj1.Text = UCase(gCompanyAddress(1))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text4")
            'txtobj1.Text = UCase(gCompanyAddress(2))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text19")
            'txtobj1.Text = UCase(gCompanyAddress(3))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text25")
            'txtobj1.Text = UCase(gCompanyAddress(4))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text24")
            'txtobj1.Text = UCase(gUsername)
            'Viewer.ssql = cmdText
            'Viewer.Report = r
            'Viewer.TableName = "journalentry"
            txtobj1 = r.ReportDefinition.ReportObjects("Text37")
            txtobj1.Text = UCase("Permanent-Revenue Summary")
            Viewer.Show()
            'Call Cry_Creditadvice()
        End If
    End Sub
    Private Sub Corporate()
        ' Dim HEADING As String
        Dim cmdText, dateofbillfrom, dateofbillto As String
        Dim Viewer As New REPORTVIEWER
        Dim r As New Cry_Allcatoutlet
        cmdText = "select ISNULL(upper(A.POSDESC),'') as POSDESC,SUM(ISNULL(A.AMOUNT,0)) as AMOUNT,SUM(ISNULL(A.VAT14,0)) as VAT14,SUM(ISNULL(A.VAT25 ,0)) as VAT25,SUM(ISNULL(A.VAT35 ,0)) as VAT35,SUM(ISNULL(A.VAT7,0)) as VAT7,SUM(ISNULL(A.VAT5 ,0)) as VAT5,SUM(ISNULL(A.SERTAX4  ,0)) as SERTAX4,SUM(ISNULL(A.SERTAX12,0)) as SERTAX12,SUM(ISNULL(A.SCharge,0)) as SCharge,SUM(ISNULL(A.SERVICE_CHARGE ,0)) as SERVICE_CHARG  from MEMBER_CONSUMPTION_OUTLET a, MEMBERMASTER b"
        cmdText = cmdText & " where a.mcode=b.mcode and isnull(b.MEMBERTYPECODE,'') in ('CO')"
        If (Fromdate.Text <> "") And (todate.Text <> "") Then
            cmdText = cmdText & " and cast(convert(varchar(11),KOTDATE,106) as datetime)between  '" & Format(Fromdate.Value, "yyyy-MM-dd") & "' and '" & Format(todate.Value, "yyyy-MM-dd") & "'  group by A.POSDESC,SNO ORDER BY SNO"
            'praba
            dateofbillfrom = Fromdate.Text
            dateofbillto = todate.Text
            'HEADING = "CREDIT ADVICE"
            ' Call Viewer.GetDetails(cmdText, "MEMBER_CONSUMPTION_OUTLET", r)
            Call Viewer.GetDetails1(cmdText, "MEMBER_CONSUMPTION_OUTLET", r)
            txtobj1 = r.ReportDefinition.ReportObjects("Text39")
            txtobj1.Text = Fromdate.Text
            txtobj1 = r.ReportDefinition.ReportObjects("Text41")
            txtobj1.Text = todate.Text
            ' txtobj1 = r.ReportDefinition.ReportObjects("Text28")
            'txtobj1.Text = UCase(HEADING)

            'txtobj1 = r.ReportDefinition.ReportObjects("Text7")
            'txtobj1.Text = UCase(gFinancalyearStart)
            'txtobj1 = r.ReportDefinition.ReportObjects("Text22")
            'txtobj1.Text = UCase(gFinancialyearEnd)

            '' Call Viewer.GetDetails(cmdText, "journalentry", r)
            txtobj1 = r.ReportDefinition.ReportObjects("Text36")
            txtobj1.Text = UCase(gcompanyname)
            'txtobj1 = r.ReportDefinition.ReportObjects("Text2")
            'txtobj1.Text = UCase(gCompanyAddress(0))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text3")
            'txtobj1.Text = UCase(gCompanyAddress(1))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text4")
            'txtobj1.Text = UCase(gCompanyAddress(2))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text19")
            'txtobj1.Text = UCase(gCompanyAddress(3))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text25")
            'txtobj1.Text = UCase(gCompanyAddress(4))


            'txtobj1 = r.ReportDefinition.ReportObjects("Text24")
            'txtobj1.Text = UCase(gUsername)
            'Viewer.ssql = cmdText
            'Viewer.Report = r
            'Viewer.TableName = "journalentry"
            txtobj1 = r.ReportDefinition.ReportObjects("Text37")
            txtobj1.Text = UCase("Corporate-Revenue Summary")
            Viewer.Show()
            ' Call Cry_Creditadvice()
        End If
    End Sub
    Private Sub CLUBWELFARE()
        ' Dim HEADING As String
        Dim cmdText, dateofbillfrom, dateofbillto As String
        Dim Viewer As New REPORTVIEWER
        Dim r As New Cry_Allcatoutlet
        cmdText = "select ISNULL(upper(A.POSDESC),'') as POSDESC,SUM(ISNULL(A.AMOUNT,0)) as AMOUNT,SUM(ISNULL(A.VAT14,0)) as VAT14,SUM(ISNULL(A.VAT25 ,0)) as VAT25,SUM(ISNULL(A.VAT35 ,0)) as VAT35,SUM(ISNULL(A.VAT7,0)) as VAT7,SUM(ISNULL(A.VAT5 ,0)) as VAT5,SUM(ISNULL(A.SERTAX4  ,0)) as SERTAX4,SUM(ISNULL(A.SERTAX12,0)) as SERTAX12,SUM(ISNULL(A.SCharge,0)) as SCharge,SUM(ISNULL(A.SERVICE_CHARGE ,0)) as SERVICE_CHARG  from MEMBER_CONSUMPTION_OUTLET a, MEMBERMASTER b"
        cmdText = cmdText & " where a.mcode=b.mcode and isnull(b.MEMBERTYPECODE,'') in ('CWE')"
        If (Fromdate.Text <> "") And (todate.Text <> "") Then
            cmdText = cmdText & " and cast(convert(varchar(11),KOTDATE,106) as datetime)between  '" & Format(Fromdate.Value, "yyyy-MM-dd") & "' and '" & Format(todate.Value, "yyyy-MM-dd") & "'  group by A.POSDESC,SNO ORDER BY SNO"
            'praba
            dateofbillfrom = Fromdate.Text
            dateofbillto = todate.Text
            'HEADING = "CREDIT ADVICE"
            ' Call Viewer.GetDetails(cmdText, "MEMBER_CONSUMPTION_OUTLET", r)
            Call Viewer.GetDetails1(cmdText, "MEMBER_CONSUMPTION_OUTLET", r)
            txtobj1 = r.ReportDefinition.ReportObjects("Text39")
            txtobj1.Text = Fromdate.Text
            txtobj1 = r.ReportDefinition.ReportObjects("Text41")
            txtobj1.Text = todate.Text
            ' txtobj1 = r.ReportDefinition.ReportObjects("Text28")
            'txtobj1.Text = UCase(HEADING)

            'txtobj1 = r.ReportDefinition.ReportObjects("Text7")
            'txtobj1.Text = UCase(gFinancalyearStart)
            'txtobj1 = r.ReportDefinition.ReportObjects("Text22")
            'txtobj1.Text = UCase(gFinancialyearEnd)

            '' Call Viewer.GetDetails(cmdText, "journalentry", r)
            txtobj1 = r.ReportDefinition.ReportObjects("Text36")
            txtobj1.Text = UCase(gcompanyname)
            'txtobj1 = r.ReportDefinition.ReportObjects("Text2")
            'txtobj1.Text = UCase(gCompanyAddress(0))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text3")
            'txtobj1.Text = UCase(gCompanyAddress(1))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text4")
            'txtobj1.Text = UCase(gCompanyAddress(2))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text19")
            'txtobj1.Text = UCase(gCompanyAddress(3))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text25")
            'txtobj1.Text = UCase(gCompanyAddress(4))


            'txtobj1 = r.ReportDefinition.ReportObjects("Text24")
            'txtobj1.Text = UCase(gUsername)
            'Viewer.ssql = cmdText
            'Viewer.Report = r
            'Viewer.TableName = "journalentry"
            txtobj1 = r.ReportDefinition.ReportObjects("Text37")
            txtobj1.Text = UCase("Club Welfare-Revenue Summary")
            Viewer.Show()
            ' Call Cry_Creditadvice()
        End If
    End Sub
    Private Sub TEMPMEMOFCORPHOUSE()
        ' Dim HEADING As String
        Dim cmdText, dateofbillfrom, dateofbillto As String
        Dim Viewer As New REPORTVIEWER
        Dim r As New Cry_Allcatoutlet
        cmdText = "select ISNULL(upper(A.POSDESC),'') as POSDESC,SUM(ISNULL(A.AMOUNT,0)) as AMOUNT,SUM(ISNULL(A.VAT14,0)) as VAT14,SUM(ISNULL(A.VAT25 ,0)) as VAT25,SUM(ISNULL(A.VAT35 ,0)) as VAT35,SUM(ISNULL(A.VAT7,0)) as VAT7,SUM(ISNULL(A.VAT5 ,0)) as VAT5,SUM(ISNULL(A.SERTAX4  ,0)) as SERTAX4,SUM(ISNULL(A.SERTAX12,0)) as SERTAX12,SUM(ISNULL(A.SCharge,0)) as SCharge,SUM(ISNULL(A.SERVICE_CHARGE ,0)) as SERVICE_CHARG  from MEMBER_CONSUMPTION_OUTLET a, MEMBERMASTER b"
        cmdText = cmdText & " where a.mcode=b.mcode and isnull(b.MEMBERTYPECODE,'') in ('T')"
        If (Fromdate.Text <> "") And (todate.Text <> "") Then
            cmdText = cmdText & " and cast(convert(varchar(11),KOTDATE,106) as datetime)between  '" & Format(Fromdate.Value, "yyyy-MM-dd") & "' and '" & Format(todate.Value, "yyyy-MM-dd") & "'  group by A.POSDESC,SNO ORDER BY SNO"
            'praba
            dateofbillfrom = Fromdate.Text
            dateofbillto = todate.Text
            'HEADING = "CREDIT ADVICE"
            ' Call Viewer.GetDetails(cmdText, "MEMBER_CONSUMPTION_OUTLET", r)
            Call Viewer.GetDetails1(cmdText, "MEMBER_CONSUMPTION_OUTLET", r)
            txtobj1 = r.ReportDefinition.ReportObjects("Text39")
            txtobj1.Text = Fromdate.Text
            txtobj1 = r.ReportDefinition.ReportObjects("Text41")
            txtobj1.Text = todate.Text
            ' txtobj1 = r.ReportDefinition.ReportObjects("Text28")
            'txtobj1.Text = UCase(HEADING)

            'txtobj1 = r.ReportDefinition.ReportObjects("Text7")
            'txtobj1.Text = UCase(gFinancalyearStart)
            'txtobj1 = r.ReportDefinition.ReportObjects("Text22")
            'txtobj1.Text = UCase(gFinancialyearEnd)

            ' Call Viewer.GetDetails(cmdText, "journalentry", r)
            txtobj1 = r.ReportDefinition.ReportObjects("Text36")
            txtobj1.Text = UCase(gcompanyname)
            'txtobj1 = r.ReportDefinition.ReportObjects("Text2")
            'txtobj1.Text = UCase(gCompanyAddress(0))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text3")
            'txtobj1.Text = UCase(gCompanyAddress(1))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text4")
            'txtobj1.Text = UCase(gCompanyAddress(2))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text19")
            'txtobj1.Text = UCase(gCompanyAddress(3))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text25")
            'txtobj1.Text = UCase(gCompanyAddress(4))


            'txtobj1 = r.ReportDefinition.ReportObjects("Text24")
            'txtobj1.Text = UCase(gUsername)
            'Viewer.ssql = cmdText
            'Viewer.Report = r
            'Viewer.TableName = "journalentry"
            txtobj1 = r.ReportDefinition.ReportObjects("Text37")
            txtobj1.Text = UCase("Temp. Mem of Corp House-Revenue Summary")
            Viewer.Show()
            ' Call Cry_Creditadvice()
        End If
    End Sub

    Private Sub cmd_Clear_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Cmd_Exit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Cmd_Exit_Click_1(sender As Object, e As EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub CHK_SELECT_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_SELECT.CheckedChanged
        Try
            'If e.KeyCode = Keys.F9 Then
            If CHK_SELECT.Checked = True Then
                For Iteration = 0 To (CHKLIST_SELECT.Items.Count - 1)
                    CHKLIST_SELECT.SetSelected(Iteration, True)
                    CHKLIST_SELECT.SetItemChecked(Iteration, True)
                Next
            Else
                For Iteration = 0 To (CHKLIST_SELECT.Items.Count - 1)
                    CHKLIST_SELECT.SetItemChecked(Iteration, False)
                Next
            End If
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function MeValidate() As Boolean
        Try
            MeValidate = True
            Dim MTYPECODE(0) As String
            If CHKLIST_SELECT.CheckedItems.Count > 0 Then
                For I = 0 To CHKLIST_SELECT.CheckedItems.Count - 1
                    MTYPECODE = Split(CHKLIST_SELECT.CheckedItems(I), ".")
                    STR_TYPE = STR_TYPE & " '" & Trim(MTYPECODE(1)) & "', "
                Next
                STR_TYPE = Mid(STR_TYPE, 1, Len(STR_TYPE) - 2)
                'STR_TYPE = STR_TYPE & ")"
            Else
                MsgBox("Please Select The Member Type ", vbInformation)
                MeValidate = False
                Exit Function
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Private Sub cmd_View_Click_1(sender As Object, e As EventArgs) Handles cmd_View.Click
        Dim sqlstring, BILLDT2 As String
        sqlstring = "Exec  [CP_POSTING_PARTYROOM] '" & Format(todate.Value, "dd/MMM/yyyy") & "'"
        gconnection.ExcuteStoreProcedure(sqlstring)

        Dim cmdText, dateofbillfrom, dateofbillto As String
        Dim MTYPECODE(0) As String
        Dim Viewer As New REPORTVIEWER
        'STR_TYPE = ""
        Dim r As New Cry_Allcatoutlet
        cmdText = "select ISNULL(upper(A.POSDESC),'') as POSDESC,SUM(ISNULL(A.AMOUNT,0)) as AMOUNT,SUM(ISNULL(A.VAT14,0)) as VAT14,SUM(ISNULL(A.VAT25 ,0)) as VAT25,SUM(ISNULL(A.VAT35 ,0)) as VAT35,SUM(ISNULL(A.VAT7,0)) as VAT7,SUM(ISNULL(A.VAT5 ,0)) as VAT5,SUM(ISNULL(A.SERTAX4  ,0)) as SERTAX4,SUM(ISNULL(A.SERTAX12,0)) as SERTAX12,SUM(ISNULL(A.SCharge,0)) as SCharge,SUM(ISNULL(A.SERVICE_CHARGE ,0)) as SERVICE_CHARG  from MEMBER_CONSUMPTION_OUTLET a, MEMBERMASTER b"
        cmdText = cmdText & " where a.mcode=b.mcode "
        If CHKLIST_SELECT.CheckedItems.Count <> 0 Then
            cmdText = cmdText & " and isnull(b.MEMBERTYPECODE,'')  IN ("
            For i = 0 To CHKLIST_SELECT.CheckedItems.Count - 1
                MTYPECODE = Split(CHKLIST_SELECT.CheckedItems(i), ".")
                cmdText = cmdText & "'" & MTYPECODE(0) & "', "
            Next
            cmdText = Mid(cmdText, 1, Len(cmdText) - 2)
            cmdText = cmdText & ")  "
        Else
            MessageBox.Show("Select the MEMBER(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        If (Fromdate.Text <> "") And (todate.Text <> "") Then
            cmdText = cmdText & " and cast(convert(varchar(11),KOTDATE,106) as datetime)between  '" & Format(Fromdate.Value, "yyyy-MM-dd") & "' and '" & Format(todate.Value, "yyyy-MM-dd") & "' group by A.POSDESC,SNO "
            cmdText = cmdText & "  union all select ISNULL(upper(A.POSDESC),'') as POSDESC,SUM(ISNULL(A.AMOUNT,0)) as AMOUNT,SUM(ISNULL(A.VAT14,0)) as VAT14,SUM(ISNULL(A.VAT25 ,0)) as VAT25,SUM(ISNULL(A.VAT35 ,0)) as VAT35,SUM(ISNULL(A.VAT7,0)) as VAT7,SUM(ISNULL(A.VAT5 ,0)) as VAT5,"
            cmdText = cmdText & "  SUM(ISNULL(A.SERTAX4  ,0)) as SERTAX4,SUM(ISNULL(A.SERTAX12,0)) as SERTAX12,SUM(ISNULL(A.SCharge,0)) as SCharge,SUM(ISNULL(A.SERVICE_CHARGE ,0)) as SERVICE_CHARG  from MEMBER_CONSUMPTION_OUTLET A WHERE A.MCODE not in (Select MCODE from membermaster)"
            cmdText = cmdText & " and cast(convert(varchar(11),KOTDATE,106) as datetime)between  '" & Format(Fromdate.Value, "yyyy-MM-dd") & "' and '" & Format(todate.Value, "yyyy-MM-dd") & "' group by A.POSDESC,SNO "
            'praba
            dateofbillfrom = Fromdate.Text
            dateofbillto = todate.Text
            'HEADING = "CREDIT ADVICE"
            ' Call Viewer.GetDetails(cmdText, "MEMBER_CONSUMPTION_OUTLET", r)
            Call Viewer.GetDetails1(cmdText, "MEMBER_CONSUMPTION_OUTLET", r)
            txtobj1 = r.ReportDefinition.ReportObjects("Text39")
            txtobj1.Text = Fromdate.Text
            txtobj1 = r.ReportDefinition.ReportObjects("Text41")
            txtobj1.Text = todate.Text
            ' txtobj1 = r.ReportDefinition.ReportObjects("Text28")
            'txtobj1.Text = UCase(HEADING)

            'txtobj1 = r.ReportDefinition.ReportObjects("Text7")
            'txtobj1.Text = UCase(gFinancalyearStart)
            'txtobj1 = r.ReportDefinition.ReportObjects("Text22")
            'txtobj1.Text = UCase(gFinancialyearEnd)

            ' Call Viewer.GetDetails(cmdText, "journalentry", r)
            txtobj1 = r.ReportDefinition.ReportObjects("Text36")
            txtobj1.Text = UCase(gcompanyname)
            'txtobj1 = r.ReportDefinition.ReportObjects("Text2")
            'txtobj1.Text = UCase(gCompanyAddress(0))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text3")
            'txtobj1.Text = UCase(gCompanyAddress(1))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text4")
            'txtobj1.Text = UCase(gCompanyAddress(2))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text19")
            'txtobj1.Text = UCase(gCompanyAddress(3))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text25")
            'txtobj1.Text = UCase(gCompanyAddress(4))


            'txtobj1 = r.ReportDefinition.ReportObjects("Text24")
            'txtobj1.Text = UCase(gUsername)
            'Viewer.ssql = cmdText
            'Viewer.Report = r
            'Viewer.TableName = "journalentry"
            txtobj1 = r.ReportDefinition.ReportObjects("Text37")
            ' txtobj1.Text = UCase("Temp. Mem of Corp House-Revenue Summary")
            ' txtobj1.Text = UCase("MTYPECODE")
            For i = 0 To CHKLIST_SELECT.CheckedItems.Count - 1
                MTYPECODE = Split(CHKLIST_SELECT.CheckedItems(i), ".")
                txtobj1.Text = txtobj1.Text & "'" & MTYPECODE(0) & "', "
            Next
            Viewer.Show()
            ' Call Cry_Creditadvice()
        End If
    End Sub
End Class