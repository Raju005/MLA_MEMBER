Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Public Class frm_mkga_countrymaster
    Dim boolchk As Boolean
    Dim sqlstring As String
    Dim vSeqNo As Double
    Dim gconnection As New GlobalClass
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If btn_add.Text = "Add [F7]" Then
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            sqlstring = "Insert into Tbl_CountryMaster"
            sqlstring = sqlstring + "(Code,Name,Freeze,AddUser,Adddatetime)"
            sqlstring = sqlstring + "values('" + Trim(txt_code.Text) + "','" + Trim(txt_desc.Text) + "', 'N','" & gUsername & " ', '" & Format(Now, "dd-MMM-yyyy HH:mm") & "')"
            gconnection.dataOperation(1, sqlstring, "Tbl_CountryMaster")
            MessageBox.Show("Record Saved Successfully ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.btn_clear_Click(sender, e)
        ElseIf btn_add.Text = "Update [F7]" Then
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            If Mid(Me.btn_add.Text, 1, 1) = "U" Then
                If Me.lbl_Freeze.Visible = True Then
                    MessageBox.Show(" The Frezzed Record Can Not Be Update", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    boolchk = False

                    Exit Sub
                End If
            End If
            sqlstring = "Update Tbl_CountryMaster SET "
            sqlstring = sqlstring + "Name='" + Trim(txt_desc.Text) + "',Freeze= 'N',UPD_USER='" & gUsername & " ', UPD_DATE='" & Format(Now, "dd-MMM-yyyy HH:mm:ss") & "' Where Code='" + Trim(txt_code.Text) + "'"
            gconnection.dataOperation(2, sqlstring, "Tbl_CountryMaster")
            MessageBox.Show("Record Updated Successfully ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.btn_clear_Click(sender, e)
            btn_add.Text = "Add [F7]"
        End If
    End Sub

    Private Sub frm_mkga_countrymaster_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        ServerMastbool = False
    End Sub

    Private Sub frm_mkga_countrymaster_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
       Try
            If e.KeyCode = Keys.F7 Then
                If btn_add.Enabled = True Then
                    Call btn_add_Click(sender, e)
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

    Private Sub frm_mkga_countrymaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Resize_Form()
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Call Resize_Form()

        ServerMastbool = True
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        txt_code.Select()

        '  tTip.IsBalloon = False
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
    Public Sub checkValidation()
        boolchk = False
        ''********** Check  Server desc Can't be blank *********************'''
        If Trim(txt_code.Text) = "" Then
            MessageBox.Show(" Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_code.Focus()
            Exit Sub
        End If

        If Trim(txt_desc.Text) = "" Then
            MessageBox.Show(" Country Name can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_desc.Focus()
            Exit Sub
        End If
        boolchk = True
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Call clearform(Me)
        Me.lbl_Freeze.Visible = False
        Me.btn_freeze.Text = "Void [F8]"
        txt_code.ReadOnly = False
        txt_desc.ReadOnly = False
        btn_freeze.Enabled = True
        btn_add.Text = "Add [F7]"
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        txt_code.Focus()
        lbl_Freeze.Text = "Record Voided  On "
        txt_code.Text = ""
        txt_desc.Text = ""
        Gr2.Visible = False

    End Sub

    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        Gr2.Visible = True
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_freeze_Click(sender As Object, e As EventArgs) Handles btn_freeze.Click
        Call checkValidation() ''-->Check Validation
        If boolchk = False Then Exit Sub
        If Mid(Me.btn_freeze.Text, 1, 1) = "V" And Mid(Me.btn_add.Text, 1, 1) = "U" Then
            sqlstring = "UPDATE  Tbl_CountryMaster "
            sqlstring = sqlstring & " SET Freeze= 'Y',voiduser='" & gUsername & " ', voiddate='" & Format(Now, "dd-MMM-yyyy HH:mm") & "'"
            sqlstring = sqlstring & " WHERE Code = '" & Trim(txt_code.Text) & "'"
            gconnection.dataOperation(3, sqlstring, "Tbl_CountryMaster")
            MessageBox.Show("Record Voided Successfully ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.btn_clear_Click(sender, e)
            btn_add.Text = "Add [F7]"
        ElseIf Mid(Me.btn_freeze.Text, 1, 1) = "U" And Mid(Me.btn_add.Text, 1, 1) = "U" Then
            MsgBox("This Unvoid Process Can't Proceed")
            'sqlstring = "UPDATE  Tbl_CountryMaster "
            'sqlstring = sqlstring & " SET Freeze= 'N',voiduser='" & gUsername & " ', voiddate=getdate()"
            'sqlstring = sqlstring & " WHERE Code = '" & Trim(txt_code.Text) & "'"
            'gconnection.dataOperation(4, sqlstring, "Tbl_CountryMaster")
            'MessageBox.Show("Record UnFreeze Successfully ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Me.btn_clear_Click(sender, e)
            'btn_add.Text = "Add [F7]"
        End If
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
        btn_view.Enabled = False
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

    Private Sub txt_code_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_code.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt_code.Text = "" Then
                    Btn_help_Click(sender, e)
                Else
                    Call TXT_CODEFILL()
                    txt_desc.Focus()
                End If
            ElseIf e.KeyCode = Keys.F4 Then
                Btn_help_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub

    Private Sub txt_code_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_code.KeyPress
        getAlphanumeric(e)
    End Sub

    Private Sub txt_code_TextChanged(sender As Object, e As EventArgs) Handles txt_code.TextChanged

    End Sub
    Private Sub TXT_CODEFILL()
        Try
            Dim MEMBERTYPE As DataTable
            Dim I, J As Integer
            Dim Sqlstr As String
            If txt_code.Text <> "" Then
                Sqlstr = " SELECT ISNULL(CODE,'') AS CODE,ISNULL(NAME,'') AS NAME,ISNULL(voiddate,'') AS voiddate,ISNULL(FREEZE,'') AS FREEZE  FROM TBL_COUNTRYMASTER  WHERE CODE='" & Trim(txt_code.Text) & "'"
                gconnection.getDataSet(Sqlstr, "Master")
                If gdataset.Tables("Master").Rows.Count > 0 Then
                    txt_code.ReadOnly = True
                    txt_desc.Text = gdataset.Tables("Master").Rows(0).Item("Name")
                    If gdataset.Tables("Master").Rows(0).Item("Freeze") = "Y" Then
                        Me.lbl_Freeze.Visible = True
                        Me.lbl_Freeze.Text = "Record Voided  On "
                        Me.lbl_Freeze.Text = Me.lbl_Freeze.Text & Format(gdataset.Tables("Master").Rows(0).Item("voiddate"), "dd-MMM-yyyy")
                        Me.btn_freeze.Text = "Unvoid[F8]"
                    Else
                        Me.lbl_Freeze.Visible = False
                        Me.lbl_Freeze.Text = "Record Voided  On "
                        Me.btn_freeze.Text = "Void [F8]"
                    End If
                    btn_add.Text = "Update [F7]"
                Else
                    txt_desc.Text = ""
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txt_code_Validated(sender As Object, e As EventArgs) Handles txt_code.Validated
       
    End Sub


    Private Sub Btn_help_Click(sender As Object, e As EventArgs) Handles Btn_help.Click
        Dim vform As New LIST_OPERATION1
        gSQLString = "SELECT ISNULL(code,'') as CODE,ISNULL(name,'') AS NAME, ISNULL(FREEZE,'') AS FREEZE  FROM Tbl_CountryMaster"
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = ""
        End If
        vform.Field = "CODE,NAME"
        vform.vCaption = "COUNTRY MASTER HELP "
        keyfield = txt_code.Text
        vform.TXT_SEARCH_TXT.Select()
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_code.Text = Trim(vform.keyfield & "")
            txt_code.Select()
            Me.TXT_CODEFILL()
            vform.Close()
            vform = Nothing
            btn_add.Text = "Update [F7]"
        End If
        gconnection.closeConnection()
    End Sub

    Private Sub txt_desc_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_desc.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                btn_add.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gCompanyname)
        End Try
    End Sub

    Private Sub txt_desc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_desc.KeyPress
        getCharater(e)
    End Sub

    Private Sub txt_desc_TextChanged(sender As Object, e As EventArgs) Handles txt_desc.TextChanged

    End Sub

    Private Sub lbl_Freeze_Click(sender As Object, e As EventArgs) Handles lbl_Freeze.Click

    End Sub

    Private Sub frm_mkga_countrymaster_MaximumSizeChanged(sender As Object, e As EventArgs) Handles Me.MaximumSizeChanged

    End Sub

    Private Sub btn_add_MouseHover(sender As Object, e As EventArgs) Handles btn_add.MouseHover
        'With tTip
        '    .BackColor = Color.Black
        '    .ForeColor = Color.Orange
        '    .IsBalloon = True
        '    .Show("Hydrogen", Me, New System.Drawing.Point(0, 0))
        'End With
    End Sub

    Private Sub btn_clear_MouseHover(sender As Object, e As EventArgs) Handles btn_clear.MouseHover
        'With tTip

        '    .IsBalloon = True
        '    .Show("clear", Me, New System.Drawing.Point(1098, 272))
        'End With
        'btn_clear.BackColor = Color.Gray
        'btn_clear.ForeColor = Color.DimGray

        'btn_clear.FlatStyle = FlatStyle.Flat


      
    End Sub

    Public StartPoint, FirstPoint, LastPoint, EndPoint, Point As Point
    Private Sub btn_clear_MouseLeave(sender As Object, e As EventArgs) Handles btn_clear.MouseLeave


        'tTip.IsBalloon = False



        'btn_clear.BackColor = Color.Transparent
        'btn_clear.ForeColor = Color.Black

        'btn_clear.FlatStyle = FlatStyle.Standard
        
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
            SSQLSTR2 = " SELECT * FROM TBL_COUNTRYMASTER WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER1,'')=''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH1USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH1USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE")
                If gdataset.Tables("AUTHORIZE").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND ISNULL(AUTHORIZELEVEL,0)>0 "
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM TBL_COUNTRYMASTER WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER1,'')=''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()


                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE TBL_COUNTRYMASTER set  ", "Code", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 1, 1)
                        End If
                    Else
                        MsgBox("NO AUTHORIZATION REQUIRED FOR THE ENTRY")
                    End If
                End If
            End If
        ElseIf USERT = 2 Then
            SSQLSTR2 = " SELECT * FROM TBL_COUNTRYMASTER WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')='' AND ISNULL(AUTHORISE_USER1,'')<>''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH2USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH2USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE1")
                If gdataset.Tables("AUTHORIZE1").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "'"
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM TBL_COUNTRYMASTER WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')=''AND ISNULL(AUTHORISE_USER1,'')<>''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()


                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE TBL_COUNTRYMASTER set  ", "Code", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 2, 1)
                        End If
                    End If
                End If
            End If
        ElseIf USERT = 3 Then
            SSQLSTR2 = " SELECT * FROM TBL_COUNTRYMASTER WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')=''AND ISNULL(AUTHORISE_USER1,'')<>''  AND ISNULL(AUTHORISE_USER2,'')<>''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH3USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH3USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE2")
                If gdataset.Tables("AUTHORIZE2").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "'"
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM TBL_COUNTRYMASTER WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')=''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()
                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE TBL_COUNTRYMASTER set  ", "Code", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 3, 1)
                        End If
                    End If
                End If
            Else
                MsgBox("U R NOT ELIGIBLE TO AUTHORISE IN ANY LEVEL", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub browse_Click(sender As Object, e As EventArgs) Handles browse.Click
        brows = True
        Dim VIEW1 As New VIEWHDR
        VIEW1.Show()
        VIEW1.DTGRDHDR.DataSource = Nothing
        VIEW1.DTGRDHDR.Rows.Clear()
        Dim STRQUERY As String
        STRQUERY = "SELECT code,* FROM TBl_countryMASTER"
        'STRQUERY = "SELECT isnull(MODULENAME,'')as MODULENAME,isnull(FORMNAME,'') as FORMNAME,isnull(FORMTYPE,'')as FORMTYPE,isnull(AUTHORIZELEVEL,'')as AUTHORIZELEVEL,isnull(AUTH1USER1,'')as AUTH1USER1,isnull(AUTH1USER2,'') as AUTH1USER2,isnull(AUTH2USER1,'')as  AUTH2USER1,isnull(AUTH2USER2,'')as AUTH2USER2,isnull(AUTH3USER1,'')as AUTH3USER1,isnull(AUTH3USER2,'') as AUTH3USER2,isnull(void,'') as void,isnull(ADDUSERID,'')as ADDUSERID,isnull(ADDDATETIME,'')as ADDDATETIME FROM authorize"
        gconnection.getDataSet(STRQUERY, "authorize")

        Call VIEW1.LOADGRID(gdataset.Tables("authorize"), True, gcompanyname, "SELECT * FROM TBl_countryMASTER", "code", 1, Me.txt_code)
        'VIEW1.Hide()
        'VIEW1.ShowDialog(Me)
        'If Trim(keyfield & "") <> "" Then
        '    txt_code.Text = Trim(keyfield & "")
        '    txt_code.Select()
        '    Me.TXT_CODEFILL()
        '    txt_desc.Select()
        '    btn_add.Text = "Update [F7]"
        'End If
        'gconnection.closeConnection()


    End Sub

    Private Sub CMD_DOS_Click(sender As Object, e As EventArgs) Handles CMD_DOS.Click
        Dim reportdesign As New ReportDesigner
        gheader = " MASTER VIEW "
        If txt_code.Text.Length > 0 Then
            tables = " FROM Tbl_CountryMaster where code = '" & Trim(txt_code.Text) & "'"
        Else
            tables = " FROM Tbl_CountryMaster"
        End If
        reportdesign.DataGridView1.ColumnCount = 2
        reportdesign.DataGridView1.Columns(0).Name = "Column Name"
        reportdesign.DataGridView1.Columns(0).Width = 380
        reportdesign.DataGridView1.Columns(1).Name = "Size"
        reportdesign.DataGridView1.Columns(1).Width = 100
        Dim row As String() = New String() {"code", "10"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"Name", "25"}
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

    Private Sub CMD_WINDOWS_Click(sender As Object, e As EventArgs) Handles CMD_WINDOWS.Click
        Dim txtobj1 As TextObject
        Dim Viewer As New REPORTVIEWER
        sqlstring = "select * from view_countrymaster "
        If txt_code.Text = "" Then
            sqlstring = sqlstring & ""
        Else
            sqlstring = sqlstring & " WHERE Code = '" & txt_code.Text & "' "
        End If
        Dim r As New Cry_Countrymaster
        gconnection.getDataSet(sqlstring, "view_countrymaster")
        If gdataset.Tables("view_countrymaster").Rows.Count > 0 Then
            Viewer.TableName = "view_countrymaster"
            Call Viewer.GetDetails(sqlstring, "view_countrymaster", r)
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
            txtobj1 = r.ReportDefinition.ReportObjects("Text12")
            txtobj1.Text = UCase(gCompanyAddress(4))
            txtobj1 = r.ReportDefinition.ReportObjects("Text11")
            txtobj1.Text = UCase(gCompanyAddress(5))


            txtobj1 = r.ReportDefinition.ReportObjects("Text19")
            txtobj1.Text = UCase(gFinancalyearStart)
            txtobj1 = r.ReportDefinition.ReportObjects("Text9")
            txtobj1.Text = UCase(gFinancialyearEnd)
            txtobj1 = r.ReportDefinition.ReportObjects("Text10")
            txtobj1.Text = UCase(gUsername)
            Viewer.Show()
        Else
            MsgBox(" NO RECORD AVAILABLE ! ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End If

        
    End Sub

    Private Sub cmd_exit1_Click(sender As Object, e As EventArgs) Handles cmd_exit1.Click
        Gr2.Visible = False
        txt_code.Focus()
    End Sub
End Class