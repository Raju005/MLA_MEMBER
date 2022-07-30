Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class FRM_TRANS_MEMBERACTIVATION
    Dim boolchk As Boolean
    Dim SqlString As String
    Dim TERMINATED, TERMINATION, DECEASED, EXPIRED, ter As String
    Dim gconnection As New GlobalClass
    Private Sub FRM_TRANS_MEMBERACTIVATION_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F7 Then
            Call btn_add_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F6 Then
            Call btn_clear_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F8 Then
            Call btn_freeze_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F9 Then
            Call btn_view_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            Call btn_exit_Click(sender, e)
            Exit Sub
        End If
    End Sub
    Private Sub FRM_TRANS_MEMBERACTIVATION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Call Resize_Form()


        If gUserCategory <> "S" Then
            Call GetRights()
            TERMINATED = "N"
            TERMINATION = "N"
            DECEASED = "N"
            EXPIRED = "N"
        Else
            TERMINATED = "Y"
            TERMINATION = "Y"
            DECEASED = "Y"
            EXPIRED = "Y"

        End If

        Call Reasons()
        ' Call Status()
        SYS_DATE_TIME()

        statusconversionbool = True
        Me.txt_MemberCode.Enabled = True
        Me.txt_MemberName.ReadOnly = True
        Me.txt_PresentStatus.ReadOnly = True
        GR2.Visible = False

    End Sub
    Private Sub SYS_DATE_TIME()
        Dim sqlstring As String
        Try
            sqlstring = "SELECT SERVERDATE,SERVERTIME FROM VIEW_SERVER_DATETIME "
            gconnection.getDataSet(sqlstring, "SERVERDATE")
            If gdataset.Tables("SERVERDATE").Rows.Count > 0 Then
                SYSDATE = Format(gdataset.Tables("SERVERDATE").Rows(0).Item("SERVERDATE"), "dd/MM/yyyy")
            End If
            dtp_EffectiveFrom.Value = SYSDATE
        Catch ex As Exception
            MessageBox.Show("Enter a valid datetime :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
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
                        If Controls(i_i).Name = "btn_clear" Or Controls(i_i).Name = "btn_add" Or Controls(i_i).Name = "btn_view" Or Controls(i_i).Name = "btn_authorize" Or Controls(i_i).Name = "btn_browse" Or Controls(i_i).Name = "btn_exit" Then
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
    Public Sub Reasons()
        Dim i As Integer
        Dim dt As DataTable
        SqlString = "SELECT distinct(Name) FROM ReasonMaster where freeze='N'and isnull(name,'')<>''  "
        dt = gconnection.GetValues(SqlString)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            Cbo_reasons.Items.Add(dt.Rows(Itration).Item("Name"))
        Next
    End Sub
    Public Sub Status()
        Dim i As Integer
        Dim dt As DataTable
        SqlString = "SELECT distinct(Name) FROM MemberStatusMaster where isnull(STATUS,'')='RELEASE' and freeze<>'Y'and isnull(STATUS,'')<>''  "
        dt = gconnection.GetValues(SqlString)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            cbo_NewStatus.Items.Add(dt.Rows(Itration).Item("Name"))
        Next
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
        Me.btn_add.Enabled = False
        Me.btn_freeze.Enabled = False
        Me.btn_view.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.btn_add.Enabled = True
                    Me.btn_freeze.Enabled = True
                    Me.btn_view.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.btn_add.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.btn_add.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.btn_add.Enabled = True
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
    Public Sub checkValidation()
        boolchk = False
        If cbo_NewStatus.Text = "Select New Status" Then
            MessageBox.Show(" Status Can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbo_NewStatus.Focus()
            Exit Sub
        End If
        '''****************************** $ Check Member Code is blank $ **************************************'''
        If Trim(txt_MemberCode.Text) = "" Then
            MessageBox.Show(" Member Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_MemberCode.Focus()
            Exit Sub
        End If
        '''***************************** $ Check Member Name is blank & **************************************'''
        If Trim(txt_MemberName.Text) = "" Then
            MessageBox.Show(" Member Name can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_MemberName.Focus()
            Exit Sub
        End If
        '''***************************** $ Present Status can't be blank & **************************************'''
        If Trim(txt_PresentStatus.Text) = "" Then
            MessageBox.Show(" Present Status can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_PresentStatus.Focus()
            Exit Sub
        End If
        '''***************************** $ New status can't be blank & **************************************'''
        If Trim(cbo_NewStatus.Text) = "" Then
            MessageBox.Show(" New Status can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbo_NewStatus.Focus()
            Exit Sub
        End If
        If Trim(Cbo_reasons1.Text) = "" Then
            MessageBox.Show(" Reason can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbo_NewStatus.Focus()
            Exit Sub
        End If
        If dtp_EffectiveFrom.Value < SYSDATE Then
            MessageBox.Show("Effective from should not be less than server date", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        boolchk = True
    End Sub
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            Dim pstatus, nstatus As String
            If (txt_PresentStatus.Text = "TERMINATED") Or (txt_PresentStatus.Text = "TERMINATION") Or (txt_PresentStatus.Text = "DECEASED") Or (txt_PresentStatus.Text = "EXPIRED") Then
                If TERMINATED = "Y" Then
                    If MessageBox.Show("Terminated/Deceased member can not be altered to any other status. Would you still like to go ahead  (Y)es / (N)o ", gcompanyname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                        ter = "N"
                        Exit Sub
                    Else
                        ter = "Y"
                    End If
                Else
                    TERMINATED = "N"
                    MessageBox.Show("You have not rights to Terminated/Deceased member this member", MyCompanyName, MessageBoxButtons.AbortRetryIgnore)
                    Exit Sub
                End If
            End If

            If btn_add.Text = "Update[F7]" Then
                If (txt_PresentStatus.Text = cbo_NewStatus.Text) Then
                    MessageBox.Show("Present Status and Current Status should'nt be same!")
                    cbo_NewStatus.Text = ""
                    Exit Sub
                End If

                If (txt_PresentStatus.Text = "ACTIVE" And cbo_NewStatus.Text = "DEFAULTER") Or (txt_PresentStatus.Text = "DEFAULTER" And cbo_NewStatus.Text = "ACTIVE") Then

                    pstatus = txt_PresentStatus.Text
                    pstatus = txt_PresentStatus.Text
                    If cbo_NewStatus.Text = "ACTIVE" Then
                        'nstatus = "LIVE"
                        nstatus = "ACTIVE"
                    Else
                        nstatus = cbo_NewStatus.Text
                    End If
                    '  End If
                    lbl_Effectivefrom.Visible = True
                    dtp_EffectiveFrom.Visible = True
                ElseIf (txt_PresentStatus.Text = "ACTIVE" And cbo_NewStatus.Text = "ABSENTEE") Or (txt_PresentStatus.Text = "ABSENTEE" And cbo_NewStatus.Text = "ACTIVE") Then
                    pstatus = txt_PresentStatus.Text
                    If cbo_NewStatus.Text = "ACTIVE" Then
                        nstatus = "ACTIVE"
                    Else
                        nstatus = cbo_NewStatus.Text
                    End If
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True
                ElseIf (txt_PresentStatus.Text = "ACTIVE" And cbo_NewStatus.Text = "SUSPENDED") Or (txt_PresentStatus.Text = "SUSPENDED" And cbo_NewStatus.Text = "ACTIVE") Then
                    pstatus = txt_PresentStatus.Text
                    If cbo_NewStatus.Text = "ACTIVE" Then
                        nstatus = "ACTIVE"
                    Else
                        nstatus = cbo_NewStatus.Text
                    End If
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True

                ElseIf (Trim(txt_PresentStatus.Text) = "DEFAULTER" And Trim(cbo_NewStatus.Text) = "ABSENTEE" Or Trim((txt_PresentStatus.Text) = "ABSENTEE" And Trim(cbo_NewStatus.Text) = "DEFAULTER")) Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = False
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = False
                ElseIf (txt_PresentStatus.Text = "DEFAULTER" And cbo_NewStatus.Text = "SUSPENDED") Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True
                ElseIf (txt_PresentStatus.Text = "ACTIVE" And cbo_NewStatus.Text = "DECEASED") Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True

                ElseIf (txt_PresentStatus.Text = "DECEASED" And cbo_NewStatus.Text = "ACTIVE") Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True
                ElseIf (txt_PresentStatus.Text = "BLOCKED" And cbo_NewStatus.Text = "ACTIVE") Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True
                ElseIf (txt_PresentStatus.Text = "ACTIVE" And cbo_NewStatus.Text = "INACTIVE") Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True
                ElseIf (txt_PresentStatus.Text = "INACTIVE" And cbo_NewStatus.Text = "ACTIVE") Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True
                ElseIf (txt_PresentStatus.Text = "N" And cbo_NewStatus.Text = "ACTIVE") Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True
                ElseIf (txt_PresentStatus.Text = "LIVE" And cbo_NewStatus.Text = "INACTIVE") Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True
                ElseIf (txt_PresentStatus.Text = "INACTIVE" And cbo_NewStatus.Text = "LIVE") Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True
                ElseIf (txt_PresentStatus.Text = "ABSENTEE" And cbo_NewStatus.Text = "SUSPENDED") Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True
                ElseIf (txt_PresentStatus.Text = "SUSPENDED" And cbo_NewStatus.Text = "TERMINATED") Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True

                ElseIf (txt_PresentStatus.Text = "SUSPENDED" And cbo_NewStatus.Text = "ACTIVE") Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True


                ElseIf (txt_PresentStatus.Text = "ABSENTEE" And cbo_NewStatus.Text = "DEFAULTER") Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True
                ElseIf (txt_PresentStatus.Text = "TERMINATED" And cbo_NewStatus.Text = "ACTIVE") Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True
                ElseIf (txt_PresentStatus.Text = "ACTIVE" And cbo_NewStatus.Text = "DECEASED") Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True

                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True
                ElseIf (txt_PresentStatus.Text = "INACTIVE" And cbo_NewStatus.Text = "DECEASED") Then
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True


                Else
                    pstatus = txt_PresentStatus.Text
                    nstatus = cbo_NewStatus.Text
                    lbl_Effectivefrom.Visible = True
                    lbl_EffectiveTo.Visible = True
                    dtp_EffectiveFrom.Visible = True
                    dtp_EffectiveTo.Visible = True
                    'MessageBox.Show("Your Select Status cannot Convert!")
                    'cbo_NewStatus.Select()
                    'lbl_Effectivefrom.Visible = False
                    'lbl_EffectiveTo.Visible = False
                    'dtp_EffectiveFrom.Visible = False
                    'dtp_EffectiveTo.Visible = False
                    'Exit Sub
                End If
            End If

            If btn_add.Text = "Add[F7]" Then
                If (txt_PresentStatus.Text = cbo_NewStatus.Text) Then
                    MessageBox.Show("Present Status and Current Status should'nt be same!", MyCompanyName)
                    cbo_NewStatus.Text = ""
                    Exit Sub
                End If

                'MsgBox("Member Not available...")
                '''******************************************************** $ Insert record into MEMBER LEDGER $ **************************************************************'''
                Call checkValidation() '''---> CHECK VALIDATION
                If boolchk = False Then Exit Sub
                SqlString = "INSERT INTO  Memberledger"
                SqlString = SqlString & "(MCODE,MNAME,PRESENTSTATUS,NEWSTATUS,REMARKS,EFFECTIVEFROM,EFFECTIVETO,ADD_USER,ADD_DATE)VALUES ('" & Trim(txt_MemberCode.Text) & " ' , '"
                SqlString = SqlString & Trim(txt_MemberName.Text) & "','" & Trim(pstatus) & "','" & Trim(nstatus) & "','" & Trim(Cbo_reasons1.Text) & "',"
                SqlString = SqlString & "Convert(datetime,'" & (dtp_EffectiveFrom.Text) & "',103),Convert(datetime,'" & (dtp_EffectiveTo.Text) & "',103),'" & gUsername & "' ,getdate())"
                gconnection.dataOperation(1, SqlString, "Memberledger")

                'MEMBERLEDGER_LOG TABLE INSERT

                SqlString = "INSERT INTO  MEMBERLEDGERDET_LOG"
                SqlString = SqlString & "(MCODE,MNAME,PRESENTSTATUS,NEWSTATUS,REMARKS,EFFECTIVEFROM,EFFECTIVETO,ADD_USER,ADD_DATE)VALUES ('" & Trim(txt_MemberCode.Text) & " ' , '"
                SqlString = SqlString & Trim(txt_MemberName.Text) & "','" & Trim(pstatus) & "','" & Trim(nstatus) & "','" & Trim(Cbo_reasons1.Text) & "',"
                SqlString = SqlString & "Convert(datetime,'" & (dtp_EffectiveFrom.Text) & "',103),Convert(datetime,'" & (dtp_EffectiveTo.Text) & "',103),'" & gUsername & "' ,getdate())"
                gconnection.dataOperation(1, SqlString, "MEMBERLEDGER_LOG")


                '''''******************************************************* $ Update record into MEMBER MASTER $ **************************************************************'''
                'SqlString = " UPDATE membermaster SET CurentStatus='" & cbo_NewStatus.Text & "' WHERE MCODE='" & txt_MemberCode.Text & "'"
                'gconnection.dataOperation(2, SqlString, "Memberledger")
                If dtp_EffectiveFrom.Text <= gdate Then
                    SqlString = " UPDATE membermaster SET CurentStatus='" & cbo_NewStatus.Text & "',STATUSDATEFROM=Convert(datetime,'" & (dtp_EffectiveFrom.Text) & "',103)  WHERE MCODE='" & txt_MemberCode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "Memberledger")

                    ''MEMBERNEWSTATUS_LOG TABLE INSERT
                    SqlString = "INSERT INTO  MEMBERNEWSTATUS_LOG"
                    SqlString = SqlString & "(MCODE,MNAME,CurentStatus,REMARKS,STATUSDATEFROM,STATUSDATETO,ADD_USER,ADD_DATE)VALUES ('" & Trim(txt_MemberCode.Text) & " ' , '"
                    SqlString = SqlString & Trim(txt_MemberName.Text) & "','" & cbo_NewStatus.Text & "','" & Trim(Cbo_reasons1.Text) & "',"
                    SqlString = SqlString & "Convert(datetime,'" & (dtp_EffectiveFrom.Text) & "',103),Convert(datetime,'" & (dtp_EffectiveTo.Text) & "',103),'" & gUsername & "' ,getdate())"
                    gconnection.dataOperation(2, SqlString, "MEMBERNEWSTATUS_LOG")

                Else
                    SqlString = " UPDATE membermaster SET NewStatus='" & cbo_NewStatus.Text & "',STATUSDATEFROM=Convert(datetime,'" & (dtp_EffectiveFrom.Text) & "',103)  WHERE MCODE='" & txt_MemberCode.Text & "'"
                    gconnection.dataOperation(2, SqlString, "Memberledger")

                    ''MEMBERNEWSTATUS_LOG TABLE INSERT
                    SqlString = "INSERT INTO  MEMBERNEWSTATUS_LOG"
                    SqlString = SqlString & "(MCODE,MNAME,NEWSTATUS,REMARKS,STATUSDATEFROM,STATUSDATETO,ADD_USER,ADD_DATE)VALUES ('" & Trim(txt_MemberCode.Text) & " ' , '"
                    SqlString = SqlString & Trim(txt_MemberName.Text) & "','" & cbo_NewStatus.Text & "','" & Trim(Cbo_reasons1.Text) & "',"
                    SqlString = SqlString & "Convert(datetime,'" & (dtp_EffectiveFrom.Text) & "',103),Convert(datetime,'" & (dtp_EffectiveTo.Text) & "',103),'" & gUsername & "' ,getdate())"
                    gconnection.dataOperation(2, SqlString, "MEMBERNEWSTATUS_LOG")

                End If


                SqlString = "insert into memdet(MEM_CODE,type0,type1,start_dt,end_dt,remarks,ADD_DATE,ADD_USER)"
                SqlString = SqlString & "values('" & txt_MemberCode.Text & "','STAT','" & Mid(Trim(cbo_NewStatus.Text), 1, 1) & "',Convert(datetime,'" & (dtp_EffectiveFrom.Text) & "',103),Convert(datetime,'" & (dtp_EffectiveTo.Text) & "',103),'" & Cbo_reasons1.Text & "','" & gUsername & "' ,getdate())"
                gconnection.dataOperation(2, SqlString, "Memberledger")

                'MEMBERDET_LOG TABLE INSERT
                SqlString = "insert into MEMBERDET_LOG (MEM_CODE,type0,type1,start_dt,end_dt,remarks,ADD_DATE,ADD_USER)"
                SqlString = SqlString & "values('" & txt_MemberCode.Text & "','STAT','" & Mid(Trim(cbo_NewStatus.Text), 1, 1) & "',Convert(datetime,'" & (dtp_EffectiveFrom.Text) & "',103),Convert(datetime,'" & (dtp_EffectiveTo.Text) & "',103),'" & Cbo_reasons1.Text & "','" & gUsername & "' ,getdate())"
                gconnection.dataOperation(2, SqlString, "Memberledger")


                MessageBox.Show("Record Saved Successfully!", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.btn_clear_Click(sender, e)

            ElseIf btn_add.Text = "Update[F7]" Then
                '''******************************************************** $ Update record into MEMBER LEDGER $ ****************************************************************'''
                If (txt_PresentStatus.Text = cbo_NewStatus.Text) Then
                    MessageBox.Show("Present Status and Current Status should'nt be same!")
                    cbo_NewStatus.Text = ""
                    Exit Sub
                End If
                Call checkValidation() '''---> CHECK VALIDATION
                Dim SQLSTRING1 As String
                Dim SQLSTRING2 As String
                If boolchk = False Then Exit Sub
                SQLSTRING1 = "insert into Memberledger (MCODE,MNAME,NEWSTATUS,PRESENTSTATUS,REMARKS,EFFECTIVEFROM,EFFECTIVETO,ADD_USER,ADD_DATE) values('" & txt_MemberCode.Text & "','" & Trim(txt_MemberName.Text) & "','" & cbo_NewStatus.Text & "','" & txt_PresentStatus.Text & "','" & Cbo_reasons1.Text & "',Convert(datetime,'" & (dtp_EffectiveFrom.Text) & "',103),Convert(datetime,'" & (dtp_EffectiveTo.Text) & "',103),'" & gUsername & "',getdate())"

                gconnection.dataOperation(2, SQLSTRING1, "Memberledger")

                'MEMBERLEDGER_LOG TABLE INSERT

                SqlString = "INSERT INTO  MEMBERLEDGERDET_LOG"
                SqlString = SqlString & "(MCODE,MNAME,PRESENTSTATUS,NEWSTATUS,REMARKS,EFFECTIVEFROM,EFFECTIVETO,ADD_USER,ADD_DATE)VALUES ('" & Trim(txt_MemberCode.Text) & " ' , '"
                SqlString = SqlString & Trim(txt_MemberName.Text) & "','" & Trim(pstatus) & "','" & Trim(nstatus) & "','" & Trim(Cbo_reasons1.Text) & "',"
                SqlString = SqlString & "Convert(datetime,'" & (dtp_EffectiveFrom.Text) & "',103),Convert(datetime,'" & (dtp_EffectiveTo.Text) & "',103),'" & gUsername & "' ,getdate())"
                gconnection.dataOperation(1, SqlString, "MEMBERLEDGER_LOG")

                ' SQLSTRING2 = " UPDATE membermaster SET CurentStatus='" & Trim(nstatus) & "',StatusDateFrom=Convert(datetime,'" & (dtp_EffectiveFrom.Text) & "',103),StatusDateTo=Convert(datetime,'" & (dtp_EffectiveTo.Text) & "',103) WHERE MCODE='" & txt_MemberCode.Text & "'"
                If dtp_EffectiveFrom.Text <= gdate Then
                    SQLSTRING2 = " UPDATE membermaster SET CurentStatus='" & cbo_NewStatus.Text & "',STATUSDATEFROM=Convert(datetime,'" & (dtp_EffectiveFrom.Text) & "',103)  WHERE MCODE='" & txt_MemberCode.Text & "'"
                    gconnection.dataOperation(1, SQLSTRING2, "MemberMaster")

                    ''MEMBERNEWSTATUS_LOG TABLE INSERT
                    SqlString = "INSERT INTO  MEMBERNEWSTATUS_LOG"
                    SqlString = SqlString & "(MCODE,MNAME,CurentStatus,REMARKS,STATUSDATEFROM,STATUSDATETO,ADD_USER,ADD_DATE)VALUES ('" & Trim(txt_MemberCode.Text) & " ' , '"
                    SqlString = SqlString & Trim(txt_MemberName.Text) & "','" & cbo_NewStatus.Text & "','" & Trim(Cbo_reasons1.Text) & "',"
                    SqlString = SqlString & "Convert(datetime,'" & (dtp_EffectiveFrom.Text) & "',103),Convert(datetime,'" & (dtp_EffectiveTo.Text) & "',103),'" & gUsername & "' ,getdate())"
                    gconnection.dataOperation(2, SqlString, "MEMBERNEWSTATUS_LOG")

                Else
                    SQLSTRING2 = " UPDATE membermaster SET NewStatus='" & cbo_NewStatus.Text & "',STATUSDATEFROM=Convert(datetime,'" & (dtp_EffectiveFrom.Text) & "',103)  WHERE MCODE='" & txt_MemberCode.Text & "'"
                    gconnection.dataOperation(1, SQLSTRING2, "MemberMaster")


                    ''MEMBERNEWSTATUS_LOG TABLE INSERT
                    SqlString = "INSERT INTO  MEMBERNEWSTATUS_LOG"
                    SqlString = SqlString & "(MCODE,MNAME,NEWSTATUS,REMARKS,STATUSDATEFROM,STATUSDATETO,ADD_USER,ADD_DATE)VALUES ('" & Trim(txt_MemberCode.Text) & " ' , '"
                    SqlString = SqlString & Trim(txt_MemberName.Text) & "','" & cbo_NewStatus.Text & "','" & Trim(Cbo_reasons1.Text) & "',"
                    SqlString = SqlString & "Convert(datetime,'" & (dtp_EffectiveFrom.Text) & "',103),Convert(datetime,'" & (dtp_EffectiveTo.Text) & "',103),'" & gUsername & "' ,getdate())"
                    gconnection.dataOperation(2, SqlString, "MEMBERNEWSTATUS_LOG")

                End If


                SqlString = "insert into memdet(MEM_CODE,type0,type1,start_dt,end_dt,remarks,ADD_USER,ADD_DATE)"
                SqlString = SqlString & "values('" & txt_MemberCode.Text & "','STAT','" & Mid(Trim(cbo_NewStatus.Text), 1, 1) & "',Convert(datetime,'" & (dtp_EffectiveFrom.Text) & "',103),Convert(datetime,'" & (dtp_EffectiveTo.Text) & "',103),'" & Cbo_reasons.Text & "','" & gUsername & "' ,getdate())"
                gconnection.dataOperation(2, SqlString, "Memberledger")

                'MEMBERDET_LOG TABLE INSERT
                SqlString = "insert into MEMBERDET_LOG (MEM_CODE,type0,type1,start_dt,end_dt,remarks,ADD_USER,ADD_DATE)"
                SqlString = SqlString & "values('" & txt_MemberCode.Text & "','STAT','" & Mid(Trim(cbo_NewStatus.Text), 1, 1) & "',Convert(datetime,'" & (dtp_EffectiveFrom.Text) & "',103),Convert(datetime,'" & (dtp_EffectiveTo.Text) & "',103),'" & Cbo_reasons1.Text & "','" & gUsername & "' ,getdate())"
                gconnection.dataOperation(2, SqlString, "Memberledger")



                MessageBox.Show("Record Updated Successfully! ", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.btn_clear_Click(sender, e)
                btn_add.Text = "Add[F7]"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub NewStatusconversion_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        statusconversionbool = False
    End Sub
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        clearform(Me)
        txt_MemberCode.Text = ""
        txt_MemberName.Text = ""
        txt_PresentStatus.Text = ""
        cbo_NewStatus.SelectedIndex = -1
        cbo_NewStatus.Text = ""
        dtp_EffectiveFrom.Value = SYSDATE
        Cbo_reasons.Text = ""
        Cbo_reasons1.Text = ""
        dtp_EffectiveFrom.Text = ""
        dtp_EffectiveTo.Text = ""
        txt_MemberCode.Enabled = True
        txt_MemberCode.Focus()
        lbl_Effectivefrom.Visible = False
        lbl_EffectiveTo.Visible = False
        dtp_EffectiveFrom.Visible = False
        dtp_EffectiveTo.Visible = False
        btn_add.Text = "Add[F7]"

        GR2.Visible = False
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub
    Private Sub txt_MemberCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_MemberCode.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt_MemberCode.Text = "" Then
                    cmd_MemberCodeHelp_Click(sender, e)
                Else
                    Call txt_memcodefill()

                    'Call txt_MemberCode_Validated(sender, e)
                End If
            ElseIf e.KeyCode = Keys.F4 Then
                cmd_MemberCodeHelp_Click(sender, e)
            End If
            'btn_add.Text = "Update[F7]"
            '' '' ''Dim posting As DataTable
            '' '' ''Dim sqlstr As String
            '' '' ''Dim vform As New LISTOPERATION
            '' '' ''Dim dr As SqlDataReader
            '' '' ''If e.KeyCode = Keys.Enter And Trim(txt_MemberCode.Text) <> "" Then
            '' '' ''    gSQLString = "SELECT MCODE,MNAME,curentstatus FROM membermaster where mcode='" & txt_MemberCode.Text & "'"
            '' '' ''    posting = gconnection.GetValues(gSQLString)
            '' '' ''    If posting.Rows.Count > 0 Then
            '' '' ''        txt_MemberName.Text = posting.Rows(0).Item("mname")
            '' '' ''        txt_PresentStatus.Text = posting.Rows(0).Item("curentstatus")
            '' '' ''        txt_PresentStatus.Focus()
            '' '' ''    End If
            '' '' ''    gconnection.closeconnection()
            '' '' ''    SqlString = "SELECT count(MCODE) FROM Memberledger WHERE MCODE='" & Trim(txt_MemberCode.Text) & "' "
            '' '' ''    gconnection.openConnection()
            '' '' ''    gcommand = New SqlCommand(SqlString, gconnection.myconn)
            '' '' ''    gdreader = gcommand.ExecuteReader
            '' '' ''    If gdreader.Read Then
            '' '' ''        If gdreader(0) = 0 Then
            '' '' ''            btn_add.Text = "Add[F7]"
            '' '' ''            txt_MemberCode.Enabled = False
            '' '' ''            txt_MemberName.ReadOnly = True
            '' '' ''            txt_PresentStatus.ReadOnly = True
            '' '' ''            cbo_NewStatus.Focus()
            '' '' ''        Else
            '' '' ''            btn_add.Text = "Update[F7]"
            '' '' ''            txt_MemberCode.Enabled = False
            '' '' ''            txt_MemberName.ReadOnly = True
            '' '' ''            txt_PresentStatus.ReadOnly = True
            '' '' ''            cbo_NewStatus.Focus()
            '' '' ''        End If
            '' '' ''        gdreader.Close()
            '' '' ''        gcommand.Dispose()
            '' '' ''        gconnection.closeconnection()
            '' '' ''        If (txt_PresentStatus.Text = "ACTIVE") Or (txt_PresentStatus.Text = "Active") Then
            '' '' ''            MessageBox.Show("MEMBER ALREADY IN ACTIVE STATUS !")
            '' '' ''            cbo_NewStatus.Text = ""
            '' '' ''            Call btn_clear_Click(New System.Object(), New System.EventArgs())
            '' '' ''            Exit Sub
            '' '' ''        End If
            '' '' ''        cbo_NewStatus.Focus()

            '' '' ''    Else
            '' '' ''        gdreader.Close()
            '' '' ''        gcommand.Dispose()
            '' '' ''        gconnection.closeconnection()
            '' '' ''    End If

            '' '' ''End If



            '' '' ''If e.KeyCode = Keys.Enter Then
            '' '' ''    If txt_MemberCode.Text = "" Then
            '' '' ''        cmd_MemberCodeHelp_Click(sender, e)
            '' '' ''    End If
            '' '' ''ElseIf e.KeyCode = Keys.F4 Then
            '' '' ''    cmd_MemberCodeHelp_Click(sender, e)
            '' '' ''End If

            'If e.KeyCode = Keys.Enter And Trim(txt_MemberCode.Text) = "" Then
            '    Call cmd_MemberCodeHelp_Click(sender, e)
            'End If
            '  Call cmd_MemberCodeHelp_Click(sender, e)
            btn_add.Text = "Update[F7]"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub
    Private Sub txt_memcodefill()
        Dim posting As DataTable
        Dim sqlstr As String
        Dim vform As New LIST_OPERATION1
        Dim dr As SqlDataReader
        If Trim(txt_MemberCode.Text) <> "" Then
            gSQLString = "SELECT MCODE,MNAME,curentstatus FROM membermaster where mcode='" & txt_MemberCode.Text & "'"
            posting = gconnection.GetValues(gSQLString)
            If posting.Rows.Count > 0 Then
                txt_MemberName.Text = posting.Rows(0).Item("mname")
                txt_PresentStatus.Text = posting.Rows(0).Item("curentstatus")
                txt_PresentStatus.Focus()
            End If
            gconnection.closeconnection()
            SqlString = "SELECT count(MCODE) FROM Memberledger WHERE MCODE='" & Trim(txt_MemberCode.Text) & "' "
            gconnection.openConnection()
            gcommand = New SqlCommand(SqlString, gconnection.myconn)
            gdreader = gcommand.ExecuteReader
            If gdreader.Read Then
                If gdreader(0) = 0 Then
                    btn_add.Text = "Add[F7]"
                    txt_MemberCode.Enabled = False
                    txt_MemberName.ReadOnly = True
                    txt_PresentStatus.ReadOnly = True
                    cbo_NewStatus.Focus()
                Else
                    btn_add.Text = "Update[F7]"
                    txt_MemberCode.Enabled = False
                    txt_MemberName.ReadOnly = True
                    txt_PresentStatus.ReadOnly = True
                    cbo_NewStatus.Focus()
                End If
                gdreader.Close()
                gcommand.Dispose()
                gconnection.closeconnection()
                If (txt_PresentStatus.Text = "ACTIVE") Or (txt_PresentStatus.Text = "Active") Then

                    MessageBox.Show("MEMBER ALREADY IN ACTIVE STATUS !")

                    'cbo_NewStatus.Text = ""
                    Call btn_clear_Click(New System.Object(), New System.EventArgs())
                    Exit Sub
                Else
                    cbo_NewStatus.Focus()
                End If


            Else
                gdreader.Close()
                gcommand.Dispose()
                gconnection.closeconnection()
            End If

        End If

    End Sub
    Private Sub txt_MemberCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_MemberCode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_MemberName.Focus()
        End If
    End Sub

    Private Sub txt_MemberName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_MemberName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_PresentStatus.Focus()
        End If
    End Sub

    Private Sub txt_PresentStatus_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_PresentStatus.KeyDown

    End Sub

    Private Sub txt_PresentStatus_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PresentStatus.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            cbo_NewStatus.Focus()
        End If
    End Sub

    Private Sub cbo_NewStatus_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_NewStatus.KeyDown
        If (e.KeyCode) = Keys.Enter Then
            If cbo_NewStatus.Text = "" Then
                cbo_NewStatus.Focus()
            Else
                Cbo_reasons1.Focus()

            End If
        End If
    End Sub

    Private Sub cbo_NewStatus_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_NewStatus.KeyPress
        BLANK(e)
        If Asc(e.KeyChar) = 13 Then
            Cbo_reasons.Focus()
        End If
    End Sub

    Private Sub txt_Remarks_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            dtp_EffectiveFrom.Focus()
        End If
    End Sub


    Private Sub cmd_MemberCodeHelp_Click(sender As Object, e As EventArgs) Handles cmd_MemberCodeHelp.Click
        Dim vform As New LIST_OPERATION1
        'Call btn_clear_Click(sender, e)
        '''************************************** $ View MCODE,MNAME from Membermaster $ **************************************'''
        gSQLString = "SELECT isnull(MCODE,'') as MCODE,isnull(MNAME,'') as MNAME,isnull(CURENTSTATUS,'') as CURENTSTATUS FROM membermaster"
        M_WhereCondition = " WHERE ISNULL(CURENTSTATUS,'') NOT IN('ACTIVE','LIVE') "
        vform.Field = "Mcode,Mname,Curentstatus"
        ' vform.vFormatstring = "  Member Code  | Member Name  | Current Status                          "
        vform.vCaption = "Member Master Help"
        'vform.KeyPos = 0
        'vform.KeyPos1 = 1
        'vform.KeyPos2 = 2
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_MemberCode.Text = Trim(vform.keyfield & "")
            If txt_MemberCode.Text <> "" Then
                txt_memcodefill()
            End If

            'txt_MemberCode_KeyDown(sender, e)
            'txt_MemberCode_Validated(sender, e)

            'txt_MemberName.Text = Trim(vform.keyfield1)
            'If (vform.keyfield2 = "LIVE") Or (vform.keyfield2 = "ACTIVE") Then
            '    'txt_PresentStatus.Text = Trim(vform.keyfield2)
            '    txt_PresentStatus.Text = "ACTIVE"
            'Else
            '    txt_PresentStatus.Text = Trim(vform.keyfield2)
            'End If

        End If
        vform.Close()
        vform = Nothing
        '''************************************************************ $ End Validating $ *******************************************************'''
        '''************************************* $ Check if MCODE is present in MEMBERLEDGER then update command will show $ *********************'''
        'SqlString = "SELECT count(MCODE) FROM Memberledger WHERE MCODE='" & Trim(txt_MemberCode.Text) & "' "
        'gconnection.openConnection()
        'gcommand = New SqlCommand(SqlString, gconnection.myconn)
        'gdreader = gcommand.ExecuteReader
        'If gdreader.Read Then
        '    If gdreader(0) = 0 Then
        '        btn_add.Text = "Add[F7]"
        '        txt_MemberCode.Enabled = False
        '        txt_MemberName.ReadOnly = True
        '        txt_PresentStatus.ReadOnly = True
        '        cbo_NewStatus.Focus()
        '    Else
        '        btn_add.Text = "Update[F7]"
        '        txt_MemberCode.Enabled = False
        '        txt_MemberName.ReadOnly = True
        '        txt_PresentStatus.ReadOnly = True
        '        cbo_NewStatus.Focus()
        '    End If
        '    gdreader.Close()
        '    gcommand.Dispose()
        '    gconnection.closeconnection()
        '    'Call txt_MemberCode_KeyDown(sender, e)
        '    'Call txt_memcodefill()
        'Else
        '    gdreader.Close()
        '    gcommand.Dispose()
        '    gconnection.closeconnection()
        'End If
        '''************************************************************ $ End Validating $ ******************************************************'''

    End Sub

    Private Sub txt_MemberCode_Validated(sender As Object, e As EventArgs) Handles txt_MemberCode.Validated
        'If txt_MemberCode.Text <> "" Then
        '    Call txt_memcodefill()
        'End If

        'Try
        '    If txt_MemberCode.Text <> "" Then

        '        '''******************************************** $ Validate Member Code while entering data $ **********************************'''
        '        SqlString = "SELECT count(mcode) FROM membermaster WHERE mcode='" & Trim(txt_MemberCode.Text) & "'"
        '        gconnection.closeconnection()
        '        gconnection.openConnection()
        '        gcommand = New SqlCommand(SqlString, gconnection.myconn)
        '        gdreader = gcommand.ExecuteReader
        '        If gdreader.Read = False Then
        '            If gdreader(0) = 0 Then
        '                txt_MemberCode.Text = ""
        '                txt_MemberCode.Enabled = True
        '                txt_MemberCode.Focus()
        '            Else
        '                gdreader.Close()
        '                gcommand.Dispose()
        '                gconnection.closeconnection()
        '                Exit Sub
        '            End If
        '            gdreader.Close()
        '            gcommand.Dispose()
        '            gconnection.closeconnection()
        '        Else
        '            gdreader.Close()
        '            gcommand.Dispose()
        '            gconnection.closeconnection()
        '        End If
        '        '----------
        '        '''*********************************************************** $ End Validating $ ********************************************'''
        '        '''*********************************************************** $ View all record $ *******************************************'''
        '        Dim Statusconv As New DataTable
        '        Dim Statusconv1 As New DataTable
        '        Dim strSQL As String
        '        'strSQL = " SELECT isnull(ReferenceNo,'') as ReferenceNo,isnull(ReferenceName,'') as ReferenceName,isnull(MCODE,'') as MCODE,isnull(PRESENTSTATUS,'') as PRESENTSTATUS,isnull(NEWSTATUS,'') as NEWSTATUS,isnull(REMARKS,'') as REMARKS,isnull(EFFECTIVEFROM,'') as EFFECTIVEFROM,isnull(EFFECTIVETO,'') as EFFECTIVETO,isnull(USERID,'') as USERID,isnull(ADDDATE,'') as ADDDATE FROM memberledger WHERE mcode='" & Trim(Me.txt_MemberCode.Text) & "'"
        '        strSQL = " SELECT isnull(ReferenceNo,'') as ReferenceNo,isnull(ReferenceName,'') as ReferenceName,isnull(MCODE,'') as MCODE,isnull(PRESENTSTATUS,'') as PRESENTSTATUS,isnull(NEWSTATUS,'') as NEWSTATUS,isnull(REMARKS,'') as REMARKS,isnull(Convert(datetime,EFFECTIVEFROM,103),'') as EFFECTIVEFROM,isnull(Convert(datetime,EFFECTIVETO,103),'') as EFFECTIVETO,isnull(ADD_USER,'') as ADD_USER,isnull(Convert(datetime,ADD_DATE,103),'') as ADD_DATE,ISNULL(FREEZE,'') AS FREEZE,ISNULL(VOIDDATE,'') AS VOIDDATE FROM memberledger WHERE mcode='" & Trim(Me.txt_MemberCode.Text) & "' AND slno = (select max(slno) from memberledger where mcode = '" & Trim(Me.txt_MemberCode.Text) & "') "
        '        Statusconv = gconnection.GetValues(strSQL)
        '        If Statusconv.Rows.Count > 0 Then
        '            Me.txt_MemberCode.Enabled = False
        '            Me.txt_MemberName.ReadOnly = True
        '            Me.txt_PresentStatus.ReadOnly = True
        '            Me.txt_PresentStatus.Text = Statusconv.Rows(0).Item("NEWSTATUS")
        '            Me.cbo_NewStatus.Text = Statusconv.Rows(0).Item("PRESENTSTATUS")
        '            Me.Cbo_reasons1.Text = Statusconv.Rows(0).Item("REMARKS")
        '            Me.dtp_EffectiveFrom.Text = Statusconv.Rows(0).Item("EFFECTIVEFROM")
        '            Me.dtp_EffectiveTo.Text = Statusconv.Rows(0).Item("EFFECTIVETO")

        '            'If gdataset.Tables("MEMBERLEDGER").Rows(0).Item("Freeze") = "Y" Then
        '            '    Me.lbl_freeze.Visible = True
        '            '    Me.lbl_freeze.Text = Me.lbl_freeze.Text & Format(gdataset.Tables("MEMBERLEDGER").Rows(0).Item("VOIDDATE"), "dd-MMM-yyyy")
        '            '    Me.btn_freeze.Text = "UnFreeze[F8]"
        '            'Else
        '            '    Me.lbl_freeze.Visible = False
        '            '    Me.lbl_freeze.Text = "Record Freezed On  "
        '            '    Me.btn_freeze.Text = "Freeze[F8]"
        '            'End If

        '            strSQL = " SELECT isnull(mname,'') as mname,isnull(curentstatus,'') as curentstatus,isnull(Convert(datetime,doj,103),'') as doj FROM memberMASTER WHERE mcode='" & Trim(Me.txt_MemberCode.Text) & "'"
        '            Statusconv1 = gconnection.GetValues(strSQL)
        '            If Statusconv.Rows.Count > 0 Then
        '                'Me.txt_PresentStatus.Text = Statusconv1.Rows(0).Item("CURENTSTATUS")
        '                'Me.cbo_NewStatus.Text = "ACTIVE"
        '                Me.btn_add.Text = "Add[F7]"
        '            End If


        '            Me.btn_add.Text = "Update[F7]"
        '        Else
        '            strSQL = " SELECT isnull(mname,'') as mname,isnull(curentstatus,'') as curentstatus,isnull(Convert(datetime,doj,103),'') as doj FROM memberMASTER WHERE mcode='" & Trim(Me.txt_MemberCode.Text) & "'"
        '            Statusconv = gconnection.GetValues(strSQL)
        '            If Statusconv.Rows.Count > 0 Then
        '                Me.txt_MemberCode.Enabled = False
        '                Me.txt_MemberName.ReadOnly = True
        '                Me.txt_PresentStatus.ReadOnly = True
        '                Me.txt_MemberName.Text = Statusconv.Rows(0).Item("MNAME")
        '                Me.cbo_NewStatus.Text = "Select New Status"
        '                'Me.txt_Remarks.Text = "No Details availabel in Data Base"
        '                'Me.dtp_EffectiveFrom.Text = Statusconv.Rows(0).Item("DOJ")
        '                Me.btn_add.Text = "Add[F7]"
        '            End If
        '        End If
        '    Else
        '        txt_MemberCode.Text = ""
        '        txt_MemberName.Text = ""
        '        txt_MemberCode.Focus()
        '    End If

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        'lbl_Effectivefrom.Visible = True
        'lbl_EffectiveTo.Visible = True
        'dtp_EffectiveFrom.Visible = True
        'dtp_EffectiveTo.Visible = True
    End Sub

    Private Sub dtp_EffectiveFrom_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp_EffectiveFrom.KeyDown
        If (e.KeyCode) = Keys.Enter Then
            btn_clear.Focus()
        End If

    End Sub
    Private Sub dtp_EffectiveFrom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_EffectiveFrom.KeyPress
        'If Asc(e.KeyChar) = 13 Then
        '    dtp_EffectiveTo.Focus()
        'End If
    End Sub
    Private Sub dtp_EffectiveTo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_EffectiveTo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btn_add.Focus()
        End If

    End Sub

    Private Sub cbo_NewStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_NewStatus.SelectedIndexChanged
        If cbo_NewStatus.SelectedIndex > 0 Then
            If (txt_PresentStatus.Text = cbo_NewStatus.Text) Then
                MessageBox.Show("Present Status and Current Status should'nt be same!")
                cbo_NewStatus.Text = ""
                Exit Sub
            End If
        End If
        If (txt_PresentStatus.Text = "ACTIVE" And cbo_NewStatus.Text = "DEFAULTER") Or (txt_PresentStatus.Text = "DEFAULTER" And cbo_NewStatus.Text = "ACTIVE") Then
            lbl_Effectivefrom.Visible = True
            lbl_EffectiveTo.Visible = True
            dtp_EffectiveFrom.Visible = True
            dtp_EffectiveTo.Visible = True
        ElseIf (txt_PresentStatus.Text = "LIVE" And cbo_NewStatus.Text = "DEFAULTER") Or (txt_PresentStatus.Text = "DEFAULTER" And cbo_NewStatus.Text = "LIVE") Then
            lbl_Effectivefrom.Visible = True
            lbl_EffectiveTo.Visible = True
            dtp_EffectiveFrom.Visible = True
            dtp_EffectiveTo.Visible = True
        ElseIf (txt_PresentStatus.Text = "ACTIVE" And cbo_NewStatus.Text = "INACTIVE") Or (txt_PresentStatus.Text = "INACTIVE" And cbo_NewStatus.Text = "ACTIVE") Then
            lbl_Effectivefrom.Visible = True
            lbl_EffectiveTo.Visible = True
            dtp_EffectiveFrom.Visible = True
            dtp_EffectiveTo.Visible = True
        ElseIf (txt_PresentStatus.Text = "ACTIVE" And cbo_NewStatus.Text = "ABSENTEE") Or (txt_PresentStatus.Text = "ABSENTEE" And cbo_NewStatus.Text = "ACTIVE") Then
            lbl_Effectivefrom.Visible = True
            lbl_EffectiveTo.Visible = True
            dtp_EffectiveFrom.Visible = True
            dtp_EffectiveTo.Visible = True
        ElseIf (txt_PresentStatus.Text = "ACTIVE" And cbo_NewStatus.Text = "SUSPENDED") Then
            lbl_Effectivefrom.Visible = True
            lbl_EffectiveTo.Visible = True
            dtp_EffectiveFrom.Visible = True
            dtp_EffectiveTo.Visible = True
        ElseIf (txt_PresentStatus.Text = "ACTIVE" And cbo_NewStatus.Text = "TERIMINATED") Or (txt_PresentStatus.Text = "TERIMINATED" And cbo_NewStatus.Text = "ACTIVE") Then
            lbl_Effectivefrom.Visible = True
            lbl_EffectiveTo.Visible = True
            dtp_EffectiveFrom.Visible = True
            dtp_EffectiveTo.Visible = True
        ElseIf (txt_PresentStatus.Text = "DEFAULTER" And cbo_NewStatus.Text = "ACTIVE") Then
            lbl_Effectivefrom.Visible = True
            lbl_EffectiveTo.Visible = True
            dtp_EffectiveFrom.Visible = True
            dtp_EffectiveTo.Visible = True
        ElseIf (txt_PresentStatus.Text = "DEFAULTER" And cbo_NewStatus.Text = "ABSENTEE") Then
            lbl_Effectivefrom.Visible = False
            lbl_EffectiveTo.Visible = False
            dtp_EffectiveFrom.Visible = False
            dtp_EffectiveTo.Visible = False
        ElseIf (txt_PresentStatus.Text = "DEFAULTER" And cbo_NewStatus.Text = "SUSPENDED") Then
            lbl_Effectivefrom.Visible = True
            lbl_EffectiveTo.Visible = True
            dtp_EffectiveFrom.Visible = True
            dtp_EffectiveTo.Visible = True
        ElseIf (txt_PresentStatus.Text = "ABSENTEE" And cbo_NewStatus.Text = "SUSPENDED") Then
            lbl_Effectivefrom.Visible = True
            lbl_EffectiveTo.Visible = True
            dtp_EffectiveFrom.Visible = True
            dtp_EffectiveTo.Visible = True
        ElseIf (txt_PresentStatus.Text = "ABSENTEE" And cbo_NewStatus.Text = "DEFAULTER") Then
            lbl_Effectivefrom.Visible = True
            lbl_EffectiveTo.Visible = True
            dtp_EffectiveFrom.Visible = True
            dtp_EffectiveTo.Visible = True
        Else
            'MessageBox.Show("Your Select Status cannot Convert!")
            cbo_NewStatus.Select()
            lbl_Effectivefrom.Visible = True
            lbl_EffectiveTo.Visible = False
            dtp_EffectiveFrom.Visible = True
            dtp_EffectiveTo.Visible = False

            Exit Sub
        End If

    End Sub

    Private Sub btn_freeze_Click(sender As Object, e As EventArgs) Handles btn_freeze.Click
        'Call checkValidation()
        'If boolchk = False Then Exit Sub
        'If Mid(Me.btn_freeze.Text, 1, 1) = "F" Then
        '    SqlString = "UPDATE  MEMBERLEDGER "
        '    SqlString = SqlString & " SET Freeze= 'Y',VOIDUSER='" & gUsername & " ', VOIDDATE='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
        '    SqlString = SqlString & " WHERE mcode = '" & txt_MemberCode.Text & " '"
        '    gconnection.dataOperation(3, SqlString, "MEMBERLEDGER")
        '    MessageBox.Show("Record Freezed Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Me.btn_clear_Click(sender, e)
        '    btn_add.Text = "Add[F7]"
        'Else
        '    SqlString = "UPDATE  MEMBERLEDGER "
        '    SqlString = SqlString & " SET Freeze= 'N',VOIDUSER='" & gUsername & " ', VOIDDATE='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
        '    SqlString = SqlString & " WHERE mcode = '" & txt_MemberCode.Text & " '"
        '    gconnection.dataOperation(4, SqlString, "MEMBERLEDGER")
        '    MessageBox.Show("Record Unfreezed Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Me.btn_clear_Click(sender, e)
        '    btn_add.Text = "Add[F7]"
        'End If
    End Sub

    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        GR2.Visible = True
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
            SSQLSTR2 = " SELECT * FROM MEMBERLEDGER  WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER1,'')=''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH1USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH1USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE")
                If gdataset.Tables("AUTHORIZE").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND ISNULL(AUTHORIZELEVEL,0)>0 "
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM MEMBERLEDGER  WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER1,'')=''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()


                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE MEMBERLEDGER  set  ", "MCODE", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 1, 3)
                        End If
                    Else
                        MsgBox("NO AUTHORIZATION REQUIRED FOR THE ENTRY")
                    End If
                End If
            End If
        ElseIf USERT = 2 Then
            SSQLSTR2 = " SELECT * FROM MEMBERLEDGER  WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')='' AND ISNULL(AUTHORISE_USER1,'')<>''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH2USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH2USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE1")
                If gdataset.Tables("AUTHORIZE1").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "'"
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM MEMBERLEDGER  WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')=''AND ISNULL(AUTHORISE_USER1,'')<>''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()


                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE MEMBERLEDGER  set  ", "MCODE", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 2, 3)
                        End If
                    End If
                End If
            End If
        ElseIf USERT = 3 Then
            SSQLSTR2 = " SELECT * FROM MEMBERLEDGER  WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')=''AND ISNULL(AUTHORISE_USER1,'')<>''  AND ISNULL(AUTHORISE_USER2,'')<>''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH3USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH3USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE2")
                If gdataset.Tables("AUTHORIZE2").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "'"
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM MEMBERLEDGER  WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')=''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()
                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE MEMBERLEDGER  set  ", "MCODE", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 3, 3)
                        End If
                    End If
                End If
            Else
                MsgBox("U R NOT ELIGIBLE TO AUTHORISE IN ANY LEVEL", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        brows = True
        Dim VIEW1 As New VIEWHDR
        VIEW1.Show()
        VIEW1.DTGRDHDR.DataSource = Nothing
        VIEW1.DTGRDHDR.Rows.Clear()
        Dim STRQUERY As String
        STRQUERY = "SELECT mcode,* FROM memberledger"
        gconnection.getDataSet(STRQUERY, "authorize")

        Call VIEW1.LOADGRID(gdataset.Tables("authorize"), True, "", "SELECT mcode,* FROM memberledger", "membercode", 1, Me.txt_MemberCode)
        'VIEW1.Hide()
        'VIEW1.ShowDialog(Me)
        'If Trim(keyfield & "") <> "" Then
        '    txt_MemberCode.Text = Trim(keyfield & "")
        '    Call txt_memcodefill()
        'End If
        'VIEW1.Close()
        'VIEW1 = Nothing
    End Sub

    Private Sub txt_MemberCode_TextChanged(sender As Object, e As EventArgs) Handles txt_MemberCode.TextChanged

    End Sub

    Private Sub Cbo_reasons1_KeyDown(sender As Object, e As KeyEventArgs) Handles Cbo_reasons1.KeyDown
        If (e.KeyCode) = Keys.Enter Then
            If Cbo_reasons1.Text = "" Then
                Cbo_reasons1.Focus()
            Else
                dtp_EffectiveFrom.Focus()
            End If
        End If
    End Sub

    Private Sub BTN_EXIT_GR2_Click(sender As Object, e As EventArgs) Handles BTN_EXIT_GR2.Click
        GR2.Visible = False
        txt_MemberCode.Focus()

    End Sub

    Private Sub BTN_DOS_Click(sender As Object, e As EventArgs) Handles BTN_DOS.Click
        Dim reportdesign As New ReportDesigner
        gheader = " MEMBER ACTIVATION  DETAILS"
        If txt_MemberCode.Text.Length > 0 Then
            tables = " FROM memberledger where mcode = '" & Trim(txt_MemberCode.Text) & "'"
        Else
            tables = " FROM memberledger"
        End If
        reportdesign.DataGridView1.ColumnCount = 2
        reportdesign.DataGridView1.Columns(0).Name = "Column Name"
        reportdesign.DataGridView1.Columns(0).Width = 380
        reportdesign.DataGridView1.Columns(1).Name = "Size"
        reportdesign.DataGridView1.Columns(1).Width = 100
        Dim row As String() = New String() {"MCODE", "12"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"MNAME", "30"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"NEWSTATUS", "20"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"PRESENTSTATUS", "20"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"REMARKS", "20"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"EFFECTIVEFROM", "20"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"EFFECTIVETO", "20"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"ADD_DATE", "20"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"UPD_DATE", "20"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"FREEZE", "9"}
        reportdesign.DataGridView1.Rows.Add(row)
        Dim chk As New DataGridViewCheckBoxColumn()
        reportdesign.DataGridView1.Columns.Insert(0, chk)
        chk.HeaderText = "Check"
        chk.Name = "chk"
        reportdesign.Button3.Select()
        reportdesign.ShowDialog(Me)

    End Sub

    Private Sub BTN_WINDOWS_Click(sender As Object, e As EventArgs) Handles BTN_WINDOWS.Click
        Dim txtobj1 As TextObject
        Dim Viewer As New REPORTVIEWER
        Dim r As New Cry_MEMBERACTDEACT
        SqlString = "select * from VIEW_MEMBERLEDGER "
        If txt_MemberCode.Text = "" Then
            SqlString = SqlString & "WHERE NEWSTATUS='ACTIVE'"
        Else
            SqlString = SqlString & " where MCODE = '" & txt_MemberCode.Text & "' AND NEWSTATUS='ACTIVE'"
        End If
        gconnection.getDataSet(SqlString, "VIEW_MEMBERLEDGER")
        If gdataset.Tables("VIEW_MEMBERLEDGER").Rows.Count > 0 Then
            Call Viewer.GetDetails(SqlString, "VIEW_MEMBERLEDGER", r)
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
End Class