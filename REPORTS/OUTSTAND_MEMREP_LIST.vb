Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.IO
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Microsoft.VisualBasic
Imports System.Net
Imports System.Text
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.HtmlControls
Imports System.Web.UI.WebControls
Public Class OUTSTAND_MEMREP_LIST
    Dim gconnection As New GlobalClass
    Dim Iteration, I, J As Integer
    Dim STR_STATUS, STR_TYPE, STR_OPCTION As String
    Dim ssql As String
    Private objProxy1 As WebProxy = Nothing

    Private Sub OUTSTAND_MEMREP_LIST_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.F9 Then
                Call btn_view_Click(sender, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F6 Then
                Call cmd_Clear_Click(sender, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.Escape Or e.KeyCode = Keys.F11 Then
                Call btn_exit_Click(sender, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F2 Then
                If CHK_SELECT.Checked = True Then
                    CHK_SELECT.Checked = False
                Else
                    CHK_SELECT.Checked = True
                End If
                'If CHK_MEMBERCATEGORY.Checked = False Then
                '    CHK_MEMBERCATEGORY.Checked = False
                'Else
                '    CHK_MEMBERCATEGORY.Checked = True          
                'End If
                'CATEGORY SELECT
                If CHK_MEMBERCATEGORY.Checked = True Then
                    CHK_MEMBERCATEGORY.Checked = False
                Else
                    CHK_MEMBERCATEGORY.Checked = True
                End If
                'STATUS SELECT
                If CHK_STATUS.Checked = True Then
                    CHK_STATUS.Checked = False
                Else
                    CHK_STATUS.Checked = True
                End If
                Exit Sub
            End If

         
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CHK_STATUS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_STATUS.CheckedChanged
        Try
            If CHK_STATUS.Checked = True Then
                For Iteration = 0 To (ChKLIST_Memberstatus.Items.Count - 1)
                    ChKLIST_Memberstatus.SetSelected(Iteration, True)
                    ChKLIST_Memberstatus.SetItemChecked(Iteration, True)
                Next
            Else
                For Iteration = 0 To (ChKLIST_Memberstatus.Items.Count - 1)
                    ChKLIST_Memberstatus.SetItemChecked(Iteration, False)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub OUTSTAND_MEMREP_LIST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Call Resize_Form()
        Try
            SYS_DATE_TIME()
            DTP_RECDATE.Value = Format(SYSDATE, "dd/MM/yyyy")
            DTPBILLDATE.Value = Format(SYSDATE, "dd/MM/yyyy")
            MemberType_Load()
            ' Member_Master_Load()
            Call GETLIST()
            MemberStatus()
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
                        If Controls(i_i).Name = "GroupBox6" Then
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
                        If Controls(i_i).Name = "GroupBox6" Then
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
 
    Public Sub GETLIST()
        Try
            Dim DT As New DataTable
            CHKLIST_SELECT.Items.Clear()
            ssql = " Select isnull(Mcode,'') as Mcode,isnull(Mname,'') as Mname From MemberMaster order by mcode,mname asc"
            DT = gconnection.GetValues(ssql)
            If DT.Rows.Count > 0 Then
                For Iteration = 0 To (DT.Rows.Count - 1)
                    CHKLIST_SELECT.Items.Add(DT.Rows(Iteration).Item("Mcode") & "." & DT.Rows(Iteration).Item("Mname"))
                Next
            Else
                CHKLIST_SELECT.Items.Clear()
            End If
            'LIST SEARCH

            'Dim loopindex As Integer
            'If gdataset.Tables("SubledgerList1").Rows.Count > 0 Then
            '    If CHKLIST_SELECT.DataRowCnt < gdataset.Tables("SubledgerList1").Rows.Count - 1 Then
            '        CHKLIST_SELECT.MaxRows = gdataset.Tables("SubledgerList1").Rows.Count + 3
            '    End If
            '    For loopindex = 0 To gdataset.Tables("SubledgerList1").Rows.Count - 1
            '        grdSelectionList.Col = 1
            '        grdSelectionList.Row = loopindex + 1
            '        grdSelectionList.Text = CStr(gdataset.Tables("SubledgerList1").Rows(loopindex).Item("Subcode"))
            '        grdSelectionList.Col = 2
            '        grdSelectionList.Row = loopindex + 1
            '        grdSelectionList.Text = CStr(gdataset.Tables("SubledgerList1").Rows(loopindex).Item("SubName"))
            '    Next
            'Else
            '    'lblAmount.Text = ""
            '    MsgBox("Details not found.", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "" & gCompanyname)
            '    txtSelection.Text = ""
            '    FormUnload = True
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub MemberType_Load()
        Try
            ' Dim SSQL As String
            Dim DT As New DataTable
            chklist_Membername.Items.Clear()
            ssql = " Select isnull(subtypecode,'') as Membertype,isnull(subtypedesc,'') as Typedesc From SUBCATEGORYMASTER "
            DT = gconnection.GetValues(ssql)
            If DT.Rows.Count > 0 Then
                For Iteration = 0 To (DT.Rows.Count - 1)
                    chklist_Membername.Items.Add(DT.Rows(Iteration).Item("membertype") & "." & DT.Rows(Iteration).Item("typedesc"))
                    'chklist_Membername.Items.Add(DT.Rows(Iteration).Item("Typedesc") & "." & DT.Rows(Iteration).Item("Membertype"))
                Next
            Else
                chklist_Membername.Items.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub MemberStatus()
        Try
            ' Dim SSQL As String
            Dim DT As New DataTable
            ChKLIST_Memberstatus.Items.Clear()
            ssql = " Select distinct isnull(curentstatus,'') as curentstatus From membermaster "
            DT = gconnection.GetValues(ssql)
            If DT.Rows.Count > 0 Then
                For Iteration = 0 To (DT.Rows.Count - 1)
                    ChKLIST_Memberstatus.Items.Add(DT.Rows(Iteration).Item("curentstatus") & "." & DT.Rows(Iteration).Item("curentstatus"))
                    'chklist_Membername.Items.Add(DT.Rows(Iteration).Item("Typedesc") & "." & DT.Rows(Iteration).Item("Membertype"))
                Next
            Else
                ChKLIST_Memberstatus.Items.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Cmd_Exit_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub RDB_defaulter_list_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_defaulter_list.CheckedChanged
        If RDB_defaulter_list.Checked = True Then
            DTPBILLDATE.Value = Format(sysdate, "dd/MM/yyyy")
            DTPBILLDATE.Enabled = True
            TXT_AMOUNT.Enabled = True
            DTPBILLDATE.Value = Format(sysdate, "dd/MM/yyyy")
            'TXT_AMOUNT.Text = ""
        End If
    End Sub

    Private Sub cmd_Clear_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RDB_OUTSNDING_LIST_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_OUTSNDING_LIST.CheckedChanged
        If RDB_OUTSNDING_LIST.Checked = True Then
            DTPBILLDATE.Value = Format(sysdate, "dd/MM/yyyy")
            DTPBILLDATE.Enabled = False
            TXT_AMOUNT.Enabled = True
            DTPBILLDATE.Value = Format(sysdate, "dd/MM/yyyy")
            'TXT_AMOUNT.Text = ""

        End If
    End Sub

    Private Sub CHK_MEMBERCATEGORY_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_MEMBERCATEGORY.CheckedChanged
        Try
            'If e.KeyCode = Keys.F9 Then
            If CHK_MEMBERCATEGORY.Checked = True Then
                For Iteration = 0 To (chklist_Membername.Items.Count - 1)
                    chklist_Membername.SetSelected(Iteration, True)
                    chklist_Membername.SetItemChecked(Iteration, True)
                Next
            Else
                For Iteration = 0 To (chklist_Membername.Items.Count - 1)
                    chklist_Membername.SetItemChecked(Iteration, False)
                Next
            End If
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub CHK_SELECT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_SELECT.CheckedChanged

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
    Private Sub CHKLIST_SELECT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CHKLIST_SELECT.KeyDown
        Try
         
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtSelection_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSelection.TextChanged
        If Trim(txtSelection.Text) <> "" Then
            Call txtSelection_Leave(eventSender, eventArgs)
        End If
    End Sub

    Private Sub txtSelection_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtSelection.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim SideLedgerList As Object
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            CHKLIST_SELECT.Focus()
        End If
        If KeyAscii = System.Windows.Forms.Keys.Escape Then
            'Unload(SideLedgerList)
            SideLedgerList = Nothing
        End If
        KeyAscii = Asc(UCase(Chr(KeyAscii)))
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtSelection_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSelection.Leave
        Try
            Dim vFormatstring As String
            If OptOthers.Checked Then
                Call GETLIST()
            Else
                vFormatstring = "MEMBER NAME                                                    | MEMBER CODE "
                'GETLIST.ClearRange(1, 1, -1, -1, True)
                Call GETLIST()
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        Try
            Dim sqlstring, sqlstring1, HEADING, HEADING1 As String
            Dim BILLDATE, RECPTDATE As String
            Dim Viewer As New REPORTVIEWER
            Dim LIMIT As String

            Dim txtobj1 As TextObject
            Dim txtobj2 As TextObject
            Dim txtobj3 As TextObject
            Dim txtobj4 As TextObject
            Dim txtobj5 As TextObject
            Dim txtobj6 As TextObject
            Dim txtobj7 As TextObject
            Dim txtobj8 As TextObject
            Dim txtobj9 As TextObject
            Dim txtobj10 As TextObject
            Dim txtobj50 As TextObject
            Dim txtobj12 As TextObject


            STR_OPCTION = ""
            STR_STATUS = ""
            STR_TYPE = ""
            If MeValidate() = False Then Exit Sub
            If Chk_Doller.Checked = False Then
                sqlstring1 = "EXEC cp_creditlimit_REP  '" & Format(DTPBILLDATE.Value, "dd/MMM/yyyy") & "','" & Format(DTP_RECDATE.Value, "dd/MMM/yyyy") & "'"
                gconnection.ExcuteStoreProcedure(sqlstring1)
            Else
                sqlstring1 = "EXEC cp_creditlimit_REP_Doller '" & Format(DTPBILLDATE.Value, "dd/MMM/yyyy") & "','" & Format(DTP_RECDATE.Value, "dd/MMM/yyyy") & "'"
                gconnection.ExcuteStoreProcedure(sqlstring1)
            End If

            sqlstring1 = "SELECT ISNULL(MEMCREDITLIMIT,0) AS LIMIT FROM POSSETUP"
            gconnection.getDataSet(sqlstring1, "POSSETUP")
            If gdataset.Tables("POSSETUP").Rows.Count > 0 Then
                LIMIT = gdataset.Tables("POSSETUP").Rows(0).Item("LIMIT")
            End If
            Dim r As New Cry_arrear
            sqlstring = " SELECT MCODE,MNAME,MEM_NAME,CURRENTSTATUS,ISNULL(CDR,0) AS CDR,ISNULL(CCR,0) AS CCR,ISNULL(USAGE,0) AS USAGE,ISNULL(CONTACTNO,'') AS CONTACTNO FROM VIEW_MEM_CREDIT_DEFAULTER "
            sqlstring = sqlstring & " WHERE MEMBERTYPE IN(" & STR_TYPE & ") AND CURRENTSTATUS IN(" & STR_STATUS & ")"
            If chklist_Membername.CheckedItems.Count > 0 Then
                sqlstring = sqlstring & " AND MCODE IN (" & STR_OPCTION & ")"
            End If

            ' sqlstring = sqlstring & " where MEMBERTYPE in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ") AND CURRENTSTATUS IN(" & STR_STATUS & ")"
            If RDB_OUTSNDING_LIST.Checked = True Then
                HEADING = "OUTSTANDING LIST"
                HEADING1 = "AS ON DATE  " & Format(DTP_RECDATE.Value, "dd/MMM/yyyy")
            ElseIf RDB_CREDIT_STOP_LIST.Checked = True Then
                sqlstring = sqlstring & "  AND FLAG='C' "
                HEADING = "CREDIT STOP  LIST"
                HEADING1 = "CREDIT AMOUNT  " & LIMIT

            ElseIf Rnd_nousage.Checked = True Then
                sqlstring = sqlstring & "  AND FLAG='R' "
                HEADING = "YET PAYMENT NOT DONE"
                HEADING1 = "AS ON DATE  " & Format(DTP_RECDATE.Value, "dd/MMM/yyyy")
                sqlstring1 = "UPDATE CREDITSTOP_MCODE_REP SET FLAG='R',USAGE=(PDR)-(PCR) WHERE   cdr-ccr>0 and mcode not in (select mcode from CREDITSTOP_MCODE_REP_jour ) "
                gconnection.getDataSet(sqlstring1, "NONPAYMENT")
                sqlstring1 = "delete from CREDITSTOP_MCODE_REP where mcode in (select distinct mcode from KOT_det where kotdate <='" & Format(DTPBILLDATE.Value, "dd/MMM/yyyy") & "') "
                gconnection.getDataSet(sqlstring1, "NONPAYMENT")

            ElseIf NonReciept.Checked = True Then
                sqlstring = sqlstring & "  AND FLAG='R' "
                HEADING = "YET PAYMENT NOT DONE"
                HEADING1 = "AS ON DATE  " & Format(DTP_RECDATE.Value, "dd/MMM/yyyy")
                sqlstring1 = "UPDATE CREDITSTOP_MCODE_REP SET FLAG='R',USAGE=(PDR)-(PCR) WHERE   cdr-ccr>0 and mcode not in (select mcode from CREDITSTOP_MCODE_REP_jour ) "
                gconnection.getDataSet(sqlstring1, "NONPAYMENT")
            ElseIf RDB_defaulter_list.Checked = True Then
                HEADING = "DEFAULTER LIST"
                HEADING1 = "BILL DATE  " & Format(DTP_RECDATE.Value, "dd/MMM/yyyy")
            Else
                sqlstring = sqlstring & "  AND ISNULL(USAGE,0) >=0"
                HEADING = "ARREAR LIST"
                HEADING1 = "BILL DATE  " & Format(DTPBILLDATE.Value, "dd/MMM/yyyy") & "  REC DATE " & Format(DTP_RECDATE.Value, "dd/MMM/yyyy")
            End If

            If TXT_AMOUNT.Text <> "" Then
                sqlstring = sqlstring & " AND ISNULL(USAGE,0)>=" & Val(TXT_AMOUNT.Text)
            End If
            BILLDATE = Format(DTPBILLDATE.Value, "dd/MMM/yyyy")
            RECPTDATE = Format(DTP_RECDATE.Value, "dd/MMM/yyyy")
            ' sqlstring = sqlstring & " ORDER BY prefixmcode,msorderno "
            txtobj1 = r.ReportDefinition.ReportObjects("Text1")
            txtobj1.Text = UCase(gcompanyname)
            txtobj8 = r.ReportDefinition.ReportObjects("Text2")
            txtobj8.Text = UCase(gCompanyAddress(0))
            txtobj9 = r.ReportDefinition.ReportObjects("Text3")
            txtobj9.Text = UCase(gCompanyAddress(1))

            txtobj10 = r.ReportDefinition.ReportObjects("Text4")
            txtobj10.Text = UCase(gCompanyAddress(2))
            txtobj50 = r.ReportDefinition.ReportObjects("Text5")
            txtobj50.Text = UCase(gCompanyAddress(3))
            txtobj12 = r.ReportDefinition.ReportObjects("Text7")
            txtobj12.Text = UCase(gCompanyAddress(4))
            txtobj12 = r.ReportDefinition.ReportObjects("Text10")
            txtobj12.Text = UCase(gCompanyAddress(5))

            txtobj1 = r.ReportDefinition.ReportObjects("Text19")
            txtobj1.Text = UCase(gFinancalyearStart)
            txtobj1 = r.ReportDefinition.ReportObjects("Text25")
            txtobj1.Text = UCase(gFinancialyearEnd)
            'txtobj3 = r.ReportDefinition.ReportObjects("Text4")
            'txtobj3.Text = gFinancialyearEnd
            txtobj4 = r.ReportDefinition.ReportObjects("Text23")
            txtobj4.Text = UCase(gUsername)
            txtobj5 = r.ReportDefinition.ReportObjects("Text8")
            txtobj5.Text = UCase(HEADING)
            'txtobj6 = r.ReportDefinition.ReportObjects("Text20")
            txtobj7 = r.ReportDefinition.ReportObjects("Text21")
            txtobj7.Text = HEADING1
            Call Viewer.GetDetails1(sqlstring, "VIEW_MEM_CREDIT_DEFAULTER", r)


            ' txtobj3.Text = Mid(gFinancalyearStart,1,4) & " - " & Mid(gFinancialyearEnd,1, 4)



            'txtobj6.Text = BILLDATE

            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function MeValidate() As Boolean

        'Try
        '    ' Dim SSQL As String
        '    Dim DT As New DataTable
        '    chklist_Membername.Items.Clear()
        '    ssql = " Select isnull(subtypedesc,'') as Membertype  From SUBCATEGORYMASTER "
        '    DT = gconnection.GetValues(ssql)
        '    If DT.Rows.Count > 0 Then
        '        For Iteration = 0 To (DT.Rows.Count - 1)
        '            STR_TYPE = chklist_Membername.Items.Add(DT.Rows(Iteration).Item("membertype"))
        '        Next
        '    Else
        '        chklist_Membername.Items.Clear()
        '    End If

        Dim o As Object
        For Each o In chklist_Membername.CheckedItems
            txtCategory.Text += "'" & o.ToString() & "',"
        Next o

        Try
            MeValidate = True
            Dim MTYPECODE(0), MMTYPECODE(0) As String
            If chklist_Membername.CheckedItems.Count > 0 Then
                For I = 0 To chklist_Membername.CheckedItems.Count - 1
                    'MTYPECODE = Split(chklist_Membername.CheckedItems(I), ".")
                    MMTYPECODE = Split(chklist_Membername.CheckedItems(I), ".")
                    STR_TYPE = STR_TYPE & " '" & Trim(MMTYPECODE(1)) & "', "
                Next
                STR_TYPE = Mid(STR_TYPE, 1, Len(STR_TYPE) - 2)
                'STR_TYPE = STR_TYPE & ")"
            Else
                MsgBox("Please Select The Member Type ", vbInformation)
                MeValidate = False
                Exit Function
            End If

            If ChKLIST_Memberstatus.CheckedItems.Count > 0 Then
                For I = 0 To ChKLIST_Memberstatus.CheckedItems.Count - 1
                    MTYPECODE = Split(ChKLIST_Memberstatus.CheckedItems(I), ".")
                    STR_STATUS = STR_STATUS & " '" & Trim(MTYPECODE(1)) & "', "
                Next
                STR_STATUS = Mid(STR_STATUS, 1, Len(STR_STATUS) - 2)
            Else
                MsgBox("Please Select The Member Status Name", vbInformation)
                MeValidate = False
                Exit Function
            End If
            If CHKLIST_SELECT.CheckedItems.Count > 0 Then
                For I = 0 To CHKLIST_SELECT.CheckedItems.Count - 1
                    MTYPECODE = Split(CHKLIST_SELECT.CheckedItems(I), ".")
                    STR_OPCTION = STR_OPCTION & " '" & Trim(MTYPECODE(0)) & "', "
                Next
                STR_OPCTION = Mid(STR_OPCTION, 1, Len(STR_OPCTION) - 2)
            Else
                MsgBox("Please Select The Member(S)", vbInformation)
                Exit Function
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

   

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Try
            Chk_sms1.Checked = False
            Chk_sms2.Checked = False
            TXT_AMOUNT.Text = ""
            CHK_MEMBERCATEGORY.Checked = False
            CHK_STATUS.Checked = False
            CHK_SELECT.Checked = False
            DTP_RECDATE.Value = Format(SYSDATE, "dd/MM/yyyy")
            DTPBILLDATE.Value = Format(SYSDATE, "dd/MM/yyyy")
            Call CHK_MEMBERCATEGORY_CheckedChanged(sender, e)
            Call CHK_STATUS_CheckedChanged(sender, e)
            DTPBILLDATE.Value = Format(SYSDATE, "dd/MM/yyyy")
            DTPBILLDATE.Enabled = True
            TXT_AMOUNT.Enabled = True
            DTPBILLDATE.Value = Format(SYSDATE, "dd/MM/yyyy")
            'TXT_AMOUNT.Text = ""
            TXT_AMOUNT.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RDB_CREDIT_STOP_LIST_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_CREDIT_STOP_LIST.CheckedChanged
        If RDB_CREDIT_STOP_LIST.Checked = True Then
            DTPBILLDATE.Value = Format(sysdate, "dd/MM/yyyy")
            DTPBILLDATE.Enabled = False
            TXT_AMOUNT.Enabled = False
            DTPBILLDATE.Value = Format(sysdate, "dd/MM/yyyy")
            TXT_AMOUNT.Text = ""

        End If
    End Sub

    Private Sub Rdo_arriarslist_CheckedChanged(sender As Object, e As EventArgs) Handles Rdo_arriarslist.CheckedChanged
        If Rdo_arriarslist.Checked = True Then
            DTPBILLDATE.Value = Format(sysdate, "dd/MM/yyyy")
            DTPBILLDATE.Enabled = True
            TXT_AMOUNT.Enabled = True
            DTPBILLDATE.Value = Format(sysdate, "dd/MM/yyyy")
            'TXT_AMOUNT.Text = ""

        End If
    End Sub

    Private Sub Btn_sms_Click(sender As Object, e As EventArgs) Handles Btn_sms.Click
           Try
            Dim sqlstring, sqlstring1, HEADING, HEADING1 As String
            Dim BILLDATE, RECPTDATE As String
            Dim Viewer As New REPORTVIEWER
            Dim LIMIT As String

            Dim txtobj1 As TextObject
            Dim txtobj2 As TextObject
            Dim txtobj3 As TextObject
            Dim txtobj4 As TextObject
            Dim txtobj5 As TextObject
            Dim txtobj6 As TextObject
            Dim txtobj7 As TextObject
            Dim txtobj8 As TextObject
            Dim txtobj9 As TextObject
            Dim txtobj10 As TextObject
            Dim txtobj50 As TextObject
            Dim txtobj12 As TextObject


            STR_OPCTION = ""
            STR_STATUS = ""
            STR_TYPE = ""
            If MeValidate() = False Then Exit Sub
            If Chk_Doller.Checked = False Then
                sqlstring1 = "EXEC cp_creditlimit_REP  '" & Format(DTPBILLDATE.Value, "dd/MMM/yyyy") & "','" & Format(DTP_RECDATE.Value, "dd/MMM/yyyy") & "'"
                gconnection.ExcuteStoreProcedure(sqlstring1)
            Else
                sqlstring1 = "EXEC cp_creditlimit_REP_Doller '" & Format(DTPBILLDATE.Value, "dd/MMM/yyyy") & "','" & Format(DTP_RECDATE.Value, "dd/MMM/yyyy") & "'"
                gconnection.ExcuteStoreProcedure(sqlstring1)
            End If

            sqlstring1 = "SELECT ISNULL(MEMCREDITLIMIT,0) AS LIMIT FROM POSSETUP"
            gconnection.getDataSet(sqlstring1, "POSSETUP")
            If gdataset.Tables("POSSETUP").Rows.Count > 0 Then
                LIMIT = gdataset.Tables("POSSETUP").Rows(0).Item("LIMIT")
            End If
            Dim r As New Cry_arrear
            sqlstring = " SELECT MCODE,MNAME,MEM_NAME,CURRENTSTATUS,ISNULL(CDR,0) AS CDR,ISNULL(CCR,0) AS CCR,ISNULL(USAGE,0) AS USAGE,ISNULL(CONTACTNO,'') AS CONTACTNO FROM VIEW_MEM_CREDIT_DEFAULTER "
            sqlstring = sqlstring & " WHERE MEMBERTYPE IN(" & STR_TYPE & ") AND CURRENTSTATUS IN(" & STR_STATUS & ")"
            If chklist_Membername.CheckedItems.Count > 0 Then
                sqlstring = sqlstring & " AND MCODE IN (" & STR_OPCTION & ")"
            End If
            ' sqlstring = sqlstring & " where MEMBERTYPE in (" & txtCategory.Text.Substring(0, txtCategory.Text.Length - 1) & ") AND CURRENTSTATUS IN(" & STR_STATUS & ")"
            If RDB_OUTSNDING_LIST.Checked = True Then
                HEADING = "OUTSTANDING LIST"
                HEADING1 = "AS ON DATE  " & Format(DTP_RECDATE.Value, "dd/MMM/yyyy")
            ElseIf RDB_CREDIT_STOP_LIST.Checked = True Then
                sqlstring = sqlstring & "  AND FLAG='C' "
                HEADING = "CREDIT STOP  LIST"
                HEADING1 = "CREDIT AMOUNT  " & LIMIT
            ElseIf RDB_defaulter_list.Checked = True Then
                HEADING = "DEFAULTER LIST"
                HEADING1 = "BILL DATE  " & Format(DTP_RECDATE.Value, "dd/MMM/yyyy")
            Else
                sqlstring = sqlstring & "  AND ISNULL(USAGE,0) >=0"
                HEADING = "ARREAR LIST"
                HEADING1 = "BILL DATE  " & Format(DTPBILLDATE.Value, "dd/MMM/yyyy") & "  REC DATE " & Format(DTP_RECDATE.Value, "dd/MMM/yyyy")
            End If

            If TXT_AMOUNT.Text <> "" Then
                sqlstring = sqlstring & " AND ISNULL(USAGE,0)>=" & Val(TXT_AMOUNT.Text)
            End If
            BILLDATE = Format(DTPBILLDATE.Value, "dd/MMM/yyyy")
            RECPTDATE = Format(DTP_RECDATE.Value, "dd/MMM/yyyy")
            ' sqlstring = sqlstring & " ORDER BY prefixmcode,msorderno "
            txtobj1 = r.ReportDefinition.ReportObjects("Text1")
            txtobj1.Text = UCase(gcompanyname)
            txtobj8 = r.ReportDefinition.ReportObjects("Text2")
            txtobj8.Text = UCase(gCompanyAddress(0))
            txtobj9 = r.ReportDefinition.ReportObjects("Text3")
            txtobj9.Text = UCase(gCompanyAddress(1))

            txtobj10 = r.ReportDefinition.ReportObjects("Text4")
            txtobj10.Text = UCase(gCompanyAddress(2))
            txtobj50 = r.ReportDefinition.ReportObjects("Text5")
            txtobj50.Text = UCase(gCompanyAddress(3))
            txtobj12 = r.ReportDefinition.ReportObjects("Text7")
            txtobj12.Text = UCase(gCompanyAddress(4))
            txtobj12 = r.ReportDefinition.ReportObjects("Text10")
            txtobj12.Text = UCase(gCompanyAddress(5))

            txtobj1 = r.ReportDefinition.ReportObjects("Text19")
            txtobj1.Text = UCase(gFinancalyearStart)
            txtobj1 = r.ReportDefinition.ReportObjects("Text25")
            txtobj1.Text = UCase(gFinancialyearEnd)
            'txtobj3 = r.ReportDefinition.ReportObjects("Text4")
            'txtobj3.Text = gFinancialyearEnd
            txtobj4 = r.ReportDefinition.ReportObjects("Text23")
            txtobj4.Text = UCase(gUsername)
            txtobj5 = r.ReportDefinition.ReportObjects("Text8")
            txtobj5.Text = UCase(HEADING)
            'txtobj6 = r.ReportDefinition.ReportObjects("Text20")
            txtobj7 = r.ReportDefinition.ReportObjects("Text21")
            txtobj7.Text = HEADING1
            Call Viewer.GetDetails1(sqlstring, "VIEW_MEM_CREDIT_DEFAULTER", r)
            If MsgBox("Do You Want To Send a SMS", MsgBoxStyle.YesNo, "Clubman") = MsgBoxResult.Yes Then
                Dim K As Integer
                Dim BALANCE, ASONBALANCE As Double
                Dim MCODE, MOBILENO, MONTH, mname As String
                Dim count As Integer
                If gdataset.Tables("VIEW_MEM_CREDIT_DEFAULTER").Rows.Count > 0 Then
                    For K = 0 To gdataset.Tables("VIEW_MEM_CREDIT_DEFAULTER").Rows.Count - 1
                        BALANCE = gdataset.Tables("VIEW_MEM_CREDIT_DEFAULTER").Rows(K).Item("usage")
                        mname = gdataset.Tables("VIEW_MEM_CREDIT_DEFAULTER").Rows(K).Item("Mname")
                        MCODE = gdataset.Tables("VIEW_MEM_CREDIT_DEFAULTER").Rows(K).Item("mcode")
                        'ASONBALANCE = gdataset.Tables("VIEW_MEM_CREDIT_DEFAULTER").Rows(K).Item("asonCLBAL")
                        MOBILENO = gdataset.Tables("VIEW_MEM_CREDIT_DEFAULTER").Rows(K).Item("CONTACTNO")
                        If BALANCE > 0 And MOBILENO <> "" Then
                            count = count + 1
                            ' MCODE = "A010"
                            ' MOBILENO = "9490216648"
                            Call send_sms(mname, MCODE, BALANCE, MOBILENO, BILLDATE)
                        End If

                    Next
                    If count > 0 Then
                        MessageBox.Show("SMS Sended Successfully")
                        ' Exit Sub
                    End If
                End If
            Else
            End If
            'txtobj1.Text = UCase(gcompanyname)
            'txtobj8.Text = UCase(gCompanyAddress(1))
            'txtobj9.Text = UCase(gCompanyAddress(2))
            '' txtobj3.Text = Mid(gFinancialyearStart, 7, 4) & " - " & Mid(gFinancialyearEnd, 7, 4)
            'txtobj3.Text = gFinancialyearEnd
            'txtobj4.Text = UCase(gUsername)
            'txtobj5.Text = UCase(HEADING)
            ''txtobj6.Text = BILLDATE
            'txtobj7.Text = HEADING1
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub send_sms(ByVal mname As String, ByVal MCODE As String, ByVal balance As Double, ByVal MOBILE As String, ByVal duedate As Date)
        Dim SQLSTRING, sqlstring1 As String
        Dim MESSAGE, BILLDATE, TEXT_AMOUNT As String
        Dim drcr, drcr1 As String
        Dim amount, asonamount As Double
        Dim amtb As String
        sqlstring1 = "SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+' '+ ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.MEMBERTYPE,'')AS TempTermReason,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(DTP_RECDATE.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL_SMS O,MEMBERMASTER M WHERE SUBSTRING(M.MCODE,1,8) =  '" & MCODE & "' "
        sqlstring1 = sqlstring1 & "   AND  CURENTSTATUS in('ACTIVE','LIVE') AND ISNULL(FREEZE,'')<>'Y' and o.SLCODE=m.mcode  GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.membertype,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE ORDER BY M.MCODE"
        gconnection.getDataSet(sqlstring1, "blance")
        asonamount = 0
        If gdataset.Tables("blance").Rows.Count > 0 Then
            asonamount = gdataset.Tables("blance").Rows(0).Item("creditlimit")
        End If

        If asonamount > 0 Then
            amtb = asonamount & " DEBIT"
        Else
            amtb = (asonamount) * -1 & " CREDIT"
        End If
        BILLDATE = Format(DTPBILLDATE.Value, "MMMM")
        TEXT_AMOUNT = "" & TXT_AMOUNT.Text & ""
        MESSAGE = ""
        If Chk_sms1.Checked = True Then
            ' MR.G.PRATHAP REDDY, NC NO-P054   DUE ON XXX  RS.XXX, KINDLY ARRANGE PAYMENT TO UTILIZE SERVICES. IF ANY QUIRES PLS CALL  27700379,27805769
            MESSAGE = "Dear Mr. " & mname & ", MCRC NO- " & MCODE & " Your OutStanding amount for the month of " & BILLDATE & " Rs. " & Val(balance) & " is due. As on balance Rs." & amtb & ".Please ignore if you already paid. If Any Quires Plz Call 23552711,23552712,23552714."
        End If
        If Chk_sms2.Checked = True Then
            MESSAGE = "Dear Mr. " & mname & ", MCRC NO- " & MCODE & " You have utilised your credit limit of Rs." & TEXT_AMOUNT & " /-, may we request you to clear the dues to continue the services. Your account balance is as on Rs." & amtb & ". Please ignore if you already paid. If Any Quires Plz Call 23552711,23552712,23552714."
        End If

        Dim USERID, SID, PWD, ROUTE As String
        Dim i As Integer
        SQLSTRING = "SELECT * FROM SM_SMSDETAILS"
        gconnection.getDataSet(SQLSTRING, "SM_SMSDETAILS")
        If gdataset.Tables("SM_SMSDETAILS").Rows.Count > 0 Then
            USERID = Trim(gdataset.Tables("SM_SMSDETAILS").Rows(i).Item("USERID"))
            SID = Trim(gdataset.Tables("SM_SMSDETAILS").Rows(i).Item("SENDERID"))
            PWD = Trim(gdataset.Tables("SM_SMSDETAILS").Rows(i).Item("PWD"))
            ROUTE = Trim(gdataset.Tables("SM_SMSDETAILS").Rows(i).Item("SROUTE"))
            'MBLNO = "9666056232"
        End If
        'MBLNO = 9943884124
        If MESSAGE <> "" Then
            Call SendgSMS(USERID, PWD, MOBILE, MESSAGE, SID)
        Else
            MessageBox.Show("Click any sms checkbox")
        End If
    End Sub
    Public Function SendgSMS(ByVal User As String, ByVal password As String, ByVal Mobile_Number As String, ByVal Message As String, ByVal SID As String, Optional ByVal MType As String = "N", Optional ByVal DR As String = "N", Optional ByVal SP As String = "N") As String
        'mobilenumber = "7845255495"

        Dim stringpost As System.Object = "username=" & User & "&password=" & password & "&to=" & Mobile_Number & "&from=" & SID & "&message=" & Message

        '''& "&SID=" & SID & "&MTYPE=" & MType & "&DR=" & DR & "&sp=" & SP

        Dim functionReturnValue As String = Nothing
        functionReturnValue = ""

        Dim objWebRequest As HttpWebRequest = Nothing
        Dim objWebResponse As HttpWebResponse = Nothing
        Dim objStreamWriter As StreamWriter = Nothing
        Dim objStreamReader As StreamReader = Nothing

        Try
            Dim stringResult As String = Nothing

            ''objWebRequest = DirectCast(WebRequest.Create("http://www.smscountry.com/SMSCwebservice.asp?"), HttpWebRequest)
            If Mid(UCase(Trim(gCompanyname)), 1, 3) = "THE" Then
                objWebRequest = DirectCast(WebRequest.Create("http://smslogin.mobi/spanelv2/api.php?"), HttpWebRequest)
            ElseIf Mid(UCase(Trim(gcompanyname)), 1, 3) = "MLA" Then
                objWebRequest = DirectCast(WebRequest.Create("http://bulk.kitesms.com/spanelv2/api.php?"), HttpWebRequest)
            End If

            objWebRequest.Method = "POST"

            If Not objProxy1 Is Nothing Then
                objWebRequest.Proxy = objProxy1
            End If

            ' Use below code if you want to SETUP PROXY. 
            'Parameters to pass: 1. ProxyAddress 2. Port 
            'You can find both the parameters in Connection settings of your internet explorer.

            'Dim myProxy As New WebProxy("YOUR PROXY", PROXPORT)
            'myProxy.BypassProxyOnLocal = True
            'wrGETURL.Proxy = myProxy

            objWebRequest.ContentType = "application/x-www-form-urlencoded"

            objStreamWriter = New StreamWriter(objWebRequest.GetRequestStream())
            objStreamWriter.Write(stringpost)
            objStreamWriter.Flush()
            objStreamWriter.Close()

            objWebResponse = DirectCast(objWebRequest.GetResponse(), HttpWebResponse)
            objStreamReader = New StreamReader(objWebResponse.GetResponseStream())

            stringResult = objStreamReader.ReadToEnd()

            objStreamReader.Close()
            Return (stringResult)
        Catch ex As Exception
            Return (ex.Message)
        Finally
            If Not objStreamWriter Is Nothing Then
                objStreamWriter.Close()
            End If
            If Not objStreamReader Is Nothing Then
                objStreamReader.Close()
            End If
            objWebRequest = Nothing
            objWebResponse = Nothing
            objProxy1 = Nothing
        End Try
    End Function

    Private Sub Chk_sms1_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_sms1.CheckedChanged
        Chk_sms1.Checked = True
        Chk_sms2.Checked = False
    End Sub

    Private Sub Chk_sms2_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_sms2.CheckedChanged
        Chk_sms1.Checked = False
        Chk_sms2.Checked = True
    End Sub
End Class