Imports System.Data
Imports System.IO
Imports System.Data.SqlClient
Imports System.Drawing.Color
Imports System.Configuration
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Text.RegularExpressions
Imports CrystalDecisions.CrystalReports.Engine
Public Class FRM_MEMMASTER
    Dim gconnection As New GlobalClass
    Dim Iteration, I, J, PERIOD As Integer
    Dim expt, dob, doj, sdob, dow As DateTime
    Dim dt As DataTable
    Dim STR_STATUS, STR_TYPE, STR_OPCTION, membertype, posting As String
    Dim Sqlstr, Sqlstr1, sqlstring, Insert(0) As String
    Dim marital, spouse, VALIDITY As String
    Dim Childdob, depdow As Date
    Dim CorporateYN, validation, CLEAR As Boolean
    Dim strPhotoFilePath, strPhotoFilePath_SIG, strPhotoFilePath_Spouse, strPhotoFilePath_SpouseImg, emailst As String
    Dim dates As String = "1900/JAN/01"
    Dim strcn As String = "Data Source=" & gserver & ";Persist Security Info=False;User ID=sa;pwd=" & SQL_Password & ";Initial Catalog=  " & gdatabase & ";"
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Try
            Com_post.SelectedIndex = 1
            Dim i As Integer
            CLEAR = True
            Cmb_Category.Enabled = True
            Cmb_Category.Text = "ASSOCIATE"
            If Cmb_Category.Items.Count > 0 Then
                Cmb_Category.SelectedIndex = 0
            End If
            If cbo_BillingBasis.Items.Count > 0 Then
                cbo_BillingBasis.SelectedIndex = 0
            End If
            cbo_CurrentStatus.Enabled = True
            cbo_CurrentStatus.Text = "ACTIVE"
            If cbo_CurrentStatus.Items.Count > 0 Then
                cbo_CurrentStatus.SelectedIndex = 0
            End If
            If Cbo_designation.Items.Count > 0 Then
                Cbo_designation.SelectedIndex = 0
            End If
            Cbo_MaritalStatus.SelectedIndex = -1
            Cbo_professional.SelectedIndex = -1
            TXT_MEMLIMIT.Text = ""
            TXT_SPOUSEMOBILE.Text = ""
            txt_MemberCode.Text = ""
            Txt_Replacement.Text = ""
            Txt_Rno.Text = ""
            Txt_APPLNO.ReadOnly = False

            Txt_APPLNO.Text = ""
            dtp_ApplnDate.Text = Date.Now
            Insert.Clear(Insert, 0, Insert.Length)
            TXT_TITLE.Text = ""
            txt_FirstName.Text = ""
            txt_MiddleName.Text = ""
            txt_Surname.Text = ""
            Txt_CorporateCode.Text = ""
            Cbo_professional.Text = ""
            CHK_DOB.Checked = False
            Chk_MinYN.Checked = False
            rdo_dir.Checked = False
            CHK_DOJ.Checked = False
            chk_EXPDT.Checked = False
            Chk_spouseFreeze.Checked = False
            chk_EXPDT_CheckedChanged(sender, e)

            For i = 1 To grd_depedent.DataRowCnt
                With grd_depedent
                    .Row = i
                    .Col = 9
                    VFilePath = apppath & "\Reports\" & Trim(.Text) & ".JPG"
                    If File.Exists(VFilePath) = True Then
                        File.Delete(VFilePath)
                    End If
                End With
            Next

            gpx_spouse.Visible = False
            dtp_DOB.Text = ""
            'dtp_DOJ.Text = ""
            dtp_DOW.Text = ""
            dtp_EXPDT.Text = ""
            Dtp_Spousedob.Text = ""
            chk_male.Checked = True
            Img_Photo.Image = Nothing
            Img_Signature.Image = Nothing
            Img_Spousephoto.Image = Nothing
            Sp_Img_Signature.Image = Nothing

            strPhotoFilePath = ""
            strPhotoFilePath_SIG = ""
            strPhotoFilePath_Spouse = ""
            emailst = ""
            CHK_DOB_CheckedChanged(sender, e)
            chk_EXPDT_CheckedChanged(sender, e)
            CHK_DOJ_CheckedChanged(sender, e)
            ChK_SDOB_CheckedChanged(sender, e)
            CHK_WDT_CheckedChanged(sender, e)
            CHK_WDT.Checked = False
            ChK_SDOB.Checked = False
            chk_male.Checked = False
            chk_female.Checked = False
            dtp_DOB.Enabled = False
            dtp_DOJ.Enabled = False
            dtp_DOW.Enabled = False
            chk_EXPDT.Enabled = False
            Dtp_Spousedob.Enabled = False
            dtp_EXPDT.Enabled = False
            chk_ContactAddress1.Checked = False
            chk_ContactAddress2.Checked = False
            chk_ContactAddress3.Checked = False
            txt_Spouse.Text = ""
            txt_PA_Address1.Text = ""
            txt_PA_Address2.Text = ""
            txt_PA_Address3.Text = ""
            txt_PA_PinCode.Text = ""
            txt_PA_Phone.Text = ""
            txt_PA_Phone2.Text = ""
            txt_PA_Mobile.Text = ""
            txt_PA_Email.Text = ""
            txt_BA_Address1.Text = ""
            txt_BA_Address2.Text = ""
            txt_BA_Address3.Text = ""
            txt_BA_PinCode.Text = ""
            txt_BA_PhoneNo.Text = ""
            txt_BA_PhoneNo2.Text = ""
            txt_BA_MobileNo.Text = ""
            txt_BA_Email.Text = ""
            txt_RA_Address1.Text = ""
            txt_RA_Address2.Text = ""
            txt_RA_Address3.Text = ""
            txt_RA_PinCode.Text = ""
            txt_RA_PhoneNo.Text = ""
            txt_RA_PhoneNo2.Text = ""
            txt_RA_MobileNo.Text = ""
            txt_RA_Email.Text = ""
            Cbo_Spousesalutation.SelectedIndex = -1
            Cbo_PCity.SelectedIndex = -1
            Cbo_PState.SelectedIndex = -1
            Cbo_PCountry.SelectedIndex = -1
            Cbo_BCity.SelectedIndex = -1
            Cbo_BState.SelectedIndex = -1
            Cbo_BCountry.SelectedIndex = -1
            Cbo_CCity.SelectedIndex = -1
            Cbo_CState.SelectedIndex = -1
            Cbo_CCountry.SelectedIndex = -1
            Cbo_title.SelectedIndex = -1
            Cbo_designation.SelectedIndex = -1
            Cbo_MaritalStatus.SelectedIndex = -1

            Txt_companyName.Text = ""
            Txt_Bussinessinfo.Text = ""
            Txt_products.Text = ""
            txt_occupation.Text = ""
            Txt_turnover.Text = ""
            Txt_AgenttInfo.Text = ""
            Txt_noofEmpolyee.Text = ""
            Me.txt_Spouse.ReadOnly = False
            Me.txt_MemberCode.ReadOnly = False
            grp_address.Visible = True
            Me.txt_MemberCode.Focus()
            txt_MemberCode.Focus()

            'proposer / seconder clear
            txt_ProposerCode.Text = ""
            txt_Proposername.Text = ""
            txt_SeconderCode1.Text = ""
            txt_SeconderName1.Text = ""
            txt_SeconderCode2.Text = ""
            txt_SeconderName2.Text = "'"
            'txt_SeconderCode3.Text = ""
            'txt_SeconderName3.Text = ""
            'txt_SeconderCode4.Text = ""
            'txt_SeconderName4.Text = ""

            TabControl1.SelectedIndex = 0
            TabControl1.TabPages(0).Focus()
            txt_MemberCode.Focus()

            Cbo_newstatus.Text = ""
            dtp_resigned_on.Text = ""

            grd_depedent.DeleteRows(1, grd_depedent.DataRowCnt)
            grd_Entfee.ClearRange(1, 1, -1, -1, True)
            grd_depedent.ClearRange(1, 1, -1, -1, True)
            grd_Education.ClearRange(1, 1, -1, -1, True)
            grp_sports_inter.ClearRange(1, 1, -1, -1, True)
            Txt_pancarno.Text = ""
            Txt_BloodGroup.Text = ""
            txt_CreditNumber.Text = ""
            txt_spl_info.Text = ""
            Me.ChK_ECSYN.Checked = False
            Me.Grp_ECSSETUP.Visible = False


            Me.btn_add.Text = "Add[F7]"
            Me.btn_add.Enabled = True
            Me.txt_Spouse.ReadOnly = False
            Me.txt_MemberCode.ReadOnly = False
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            Call loadmembertype(i + 1)
            Call loadSalutation(i + 1)
            CLEAR = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub

    Private Sub FRM_MEMMASTER_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
                'ElseIf e.KeyCode = Keys.F12 Then
                '    If btn_Export.Enabled = True Then
                '        Call btn_Export_Click(sender, e)
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
            T = T - 2
        End If
        If U = 1280 Then
            T = T - 2
        End If
        If U = 1360 Then
            T = T - 35
        End If
        If U = 1366 Then
            T = T - 35
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
                        '  If Controls(i_i).Name = "Panel" Then
                        If Controls(i_i).Name = "GroupBox1" Then
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
                        If Controls(i_i).Name = "GroupBox10" Then
                            ' If Controls(i_i).Name = "TabPage1" Then
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

    Private Sub FRM_MEMMASTER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Call Resize_Form()
        Grp_ECSSETUP.Visible = False
        Try
            sqlstring = "Exec  member_membertype"
            membertype = gconnection.ExcuteStoreProcedure(sqlstring)
            FillTypeMst()
            Status()
            Relation()
            Com_post.SelectedIndex = 1
            Title()
            City()
            State()
            Country()
            MaritalStatus()
            Designation()
            Professional()
            'Call GetLastNo()
            Call loadmembertype(I + 1)
            Call loadSalutation(I + 1)
            txt_Spouse.ReadOnly = False
            cbo_CurrentStatus.Enabled = True
            cbo_BillingBasis.Enabled = True
            Call btn_clear_Click(sender, e)
            txt_MemberCode.Select()
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            Cbo_newstatus.Enabled = False
            chk_resigned.Enabled = False
            dtp_resigned_on.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub
    Private Sub GetRights()
        Try
            Dim i, j, k, x As Integer
            Dim vmain, vsmod, vssmod As Long
            Dim ssql, SQLSTRING As String
            Dim M1 As New MainMenu
            Dim chstr As String
            SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='MEMBER'  AND MODULENAME LIKE '" & Trim(GmoduleName) & "'"
            gconnection.getDataSet(SQLSTRING, "USER")
            If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
                For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                    With gdataset.Tables("USER").Rows(i)
                        chstr = abcdMINUS(.Item("RIGHTS"))
                    End With
                Next
            End If
            Me.btn_add.Enabled = False
            'Me.cmdprint.Enabled = False
            Me.btn_view.Enabled = False
            Me.btn_Export.Enabled = False
            'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
            If Len(chstr) > 0 Then
                Dim Right() As Char
                Right = chstr.ToCharArray
                For x = 0 To Right.Length - 1
                    If Right(x) = "A" Then
                        Me.btn_add.Enabled = True
                        Me.btn_view.Enabled = True
                        Me.btn_Export.Enabled = True
                        Exit Sub
                    End If
                    If UCase(Mid(Me.btn_add.Text, 1, 1)) = "A" Then
                        If Right(x) = "S" Then
                            Me.btn_add.Enabled = True
                        End If
                    Else
                        If Right(x) = "U" Then
                            Me.btn_add.Enabled = True
                        End If
                    End If
                    If Right(x) = "F" Then
                        'Me.cmd_Delete.Enabled = True
                    End If
                    If Right(x) = "V" Then
                        Me.btn_view.Enabled = True
                        Me.btn_Export.Enabled = True
                    End If
                    If Right(x) = "P" Then
                        ' Me.cmdprint.Enabled = True
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub
    Public Sub FillTypeMst()
        Dim i As Integer
        Dim SSQL, CRED As String
        Dim SUBCATEGORY As New DataTable
        sqlstring = "SELECT distinct(SubTYPEDESC) FROM subcategorymaster where freeze<>'Y' "
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            Cmb_Category.Items.Add(dt.Rows(Itration).Item("SubTYPEDESC"))
        Next
        SSQL = "select isnull(CREDITLIMIT,0) AS CREDITLIMIT,ISNULL(CREDITLIMITYN,'') AS CREDITLIMITYN FROM SUBCATEGORYMASTER WHERE subtypedesc='" & Cmb_Category.Text & "' "
        SUBCATEGORY = gconnection.GetValues(SSQL)
        If SUBCATEGORY.Rows.Count > 0 Then
            CRED = Val(SUBCATEGORY.Rows(0).Item("CREDITLIMITYN"))
        End If
        If CRED = "Y" Then
            CREDITYN = "Y"
        Else
            CREDITYN = "N"
        End If
    End Sub
    Public Sub Status()
        Dim i As Integer
        sqlstring = "SELECT distinct(Name) FROM MemberStatusMaster where freeze<>'Y'and isnull(name,'')<>''  "
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            cbo_CurrentStatus.Items.Add(dt.Rows(Itration).Item("Name"))
        Next
    End Sub
    Public Sub Relation()
        Dim i As Integer
        sqlstring = "SELECT distinct(Name) FROM Tbl_ReligionMaster where freeze<>'Y'and isnull(name,'')<>''  "
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            'Cbo_relation.Items.Add(dt.Rows(Itration).Item("Name"))
        Next
    End Sub
    Public Sub Title()
        Dim i As Integer
        sqlstring = "SELECT distinct(Name) FROM Tbl_TitleMaster where freeze<>'Y'and isnull(name,'')<>''  "
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            Cbo_title.Items.Add(dt.Rows(Itration).Item("Name"))
            Cbo_Spousesalutation.Items.Add(dt.Rows(Itration).Item("Name"))
        Next
    End Sub
    Public Sub City()
        Dim i As Integer
        sqlstring = "SELECT distinct(Name) FROM Tbl_CityMaster where freeze<>'Y' and isnull(name,'')<>'' "
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            Cbo_PCity.Items.Add(dt.Rows(Itration).Item("Name"))
            Cbo_BCity.Items.Add(dt.Rows(Itration).Item("Name"))
            Cbo_CCity.Items.Add(dt.Rows(Itration).Item("Name"))
        Next
    End Sub
    Public Sub Country()
        Dim i As Integer
        sqlstring = "SELECT distinct(Country)as name FROM Tbl_CityMaster where freeze<>'Y' and isnull(name,'')<>'' "
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            Cbo_PCountry.Items.Add(dt.Rows(Itration).Item("Name"))
            Cbo_BCountry.Items.Add(dt.Rows(Itration).Item("Name"))
            Cbo_CCountry.Items.Add(dt.Rows(Itration).Item("Name"))
        Next
    End Sub
    Public Sub State()
        Dim i As Integer
        sqlstring = "SELECT distinct(state) as name FROM Tbl_CityMaster where freeze<>'Y'and isnull(name,'')<>''  "
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            Cbo_PState.Items.Add(dt.Rows(Itration).Item("Name"))
            Cbo_BState.Items.Add(dt.Rows(Itration).Item("Name"))
            Cbo_CState.Items.Add(dt.Rows(Itration).Item("Name"))
        Next
    End Sub
    Public Sub MaritalStatus()
        Dim i As Integer
        sqlstring = "SELECT distinct(Name) FROM Tbl_MaritalStatusMaster where freeze<>'Y' and isnull(name,'')<>'' "
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            Cbo_MaritalStatus.Items.Add(dt.Rows(Itration).Item("Name"))
        Next
    End Sub
    Public Sub Designation()
        Dim i As Integer
        sqlstring = "SELECT distinct(Name) FROM Tbl_DesignationMaster where freeze<>'Y'and isnull(name,'')<>''  "
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            Cbo_designation.Items.Add(dt.Rows(Itration).Item("Name"))
        Next
    End Sub
    Public Sub Professional()
        Dim i As Integer
        sqlstring = "SELECT distinct(Name) FROM Tbl_ProfessionalMaster where freeze<>'Y'and isnull(name,'')<>''  "
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            Cbo_professional.Items.Add(dt.Rows(Itration).Item("Name"))
        Next
    End Sub
    Private Sub loadmembertype(ByVal i As Integer)
        Dim j As Integer
        Dim sqlstring, SSQL As String
        Dim SUBCATEGORY As New DataTable
        grd_depedent.TypeComboBoxClear(1, i)
        sqlstring = "SELECT Subtypecode,Subtypedesc FROM subcategorymaster WHERE Subtypecode in('ST','LI') and ISNULL(Freeze,'') <> 'Y' ORDER BY Subtypecode ASC"
        gconnection.getDataSet(sqlstring, "Subtypedesc")
        If gdataset.Tables("Subtypedesc").Rows.Count > 0 Then
            For j = 0 To gdataset.Tables("Subtypedesc").Rows.Count - 1
                grd_depedent.Col = 1
                grd_depedent.Row = i
                grd_depedent.TypeComboBoxString = Trim(gdataset.Tables("Subtypedesc").Rows(j).Item("Subtypedesc"))
                grd_depedent.TypeComboBoxIndex = j
            Next j
        End If
        SSQL = "select isnull(CREDITLIMIT,0) AS CREDITLIMIT,ISNULL(CREDITLIMITYN,'') AS CREDITLIMITYN FROM SUBCATEGORYMASTER WHERE subtypedesc='" & Cmb_Category.Text & "' "
        SUBCATEGORY = gconnection.GetValues(SSQL)
        If SUBCATEGORY.Rows.Count > 0 Then
            CREDITYN = SUBCATEGORY.Rows(0).Item("CREDITLIMITYN")
        End If
        If Cmb_Category.Text = "INSTITUTIONAL MEMBERS" Then
            Txt_Replacement.Enabled = True
            Cmd_Replacement.Enabled = True
        Else
            Txt_Replacement.Enabled = False
            Cmd_Replacement.Enabled = False

        End If
        SSQL = "select isnull(CREDITLIMIT,0) AS CREDITLIMIT,ISNULL(CREDITLIMITYN,'') AS CREDITLIMITYN,ISNULL(VALIDITY,0) AS VALIDITY,ISNULL(TENURES,'') AS TENURES FROM SUBCATEGORYMASTER WHERE subtypedesc='" & Cmb_Category.Text & "' "
        SUBCATEGORY = gconnection.GetValues(SSQL)
        If SUBCATEGORY.Rows.Count > 0 Then
            VALIDITY = SUBCATEGORY.Rows(0).Item("TENURES")
            PERIOD = Val(SUBCATEGORY.Rows(0).Item("VALIDITY"))
        End If

        If VALIDITY = "Y" Then
            chk_EXPDT.Checked = True
            dtp_EXPDT.Value = DateAdd(DateInterval.Month, PERIOD, Now)
            chk_EXPDT.Enabled = False
            dtp_EXPDT.Enabled = False
        Else
            chk_EXPDT.Checked = False
            chk_EXPDT.Enabled = True
            dtp_EXPDT.Enabled = False
            dtp_EXPDT.Value = Now
        End If
    End Sub
    Private Sub loadSalutation(ByVal i As Integer)
        Dim j, k As Integer
        Dim sqlstring As String
        sqlstring = "select code,Name from tbl_titlemaster WHERE ISNULL(Freeze,'') <> 'Y' ORDER BY code ASC "
        gconnection.getDataSet(sqlstring, "Salutation")
        If gdataset.Tables("Salutation").Rows.Count > 0 Then
            For k = 0 To 10
                grd_depedent.TypeComboBoxClear(1, k + 1)
                For j = 0 To gdataset.Tables("Salutation").Rows.Count - 1
                    grd_depedent.Col = 1
                    grd_depedent.Row = k + 1
                    grd_depedent.TypeComboBoxString = Trim(gdataset.Tables("Salutation").Rows(j).Item("Name"))
                    grd_depedent.TypeComboBoxIndex = j

                Next j
            Next k

        End If
    End Sub

    Private Sub chk_EXPDT_CheckedChanged(sender As Object, e As EventArgs) Handles chk_EXPDT.CheckedChanged
        Try
            If chk_EXPDT.Checked = True Then
                dtp_EXPDT.Enabled = True
            Else
                dtp_EXPDT.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub

    Private Sub CHK_DOB_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_DOB.CheckedChanged
        Try
            If CHK_DOB.Checked = True Then
                dtp_DOB.Enabled = True
                dtp_DOB.Focus()
            Else
                dtp_DOB.Enabled = False
                CHK_DOJ.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub

    Private Sub CHK_DOJ_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_DOJ.CheckedChanged
        If CHK_DOJ.Checked = True Then
            dtp_DOJ.Enabled = True
            dtp_DOJ.Focus()
        Else
            dtp_DOJ.Enabled = False
            If VALIDITY = "Y" Then
                Cbo_designation.Focus()
            Else
                chk_EXPDT.Focus()
            End If

        End If
    End Sub

    Private Sub ChK_SDOB_CheckedChanged(sender As Object, e As EventArgs) Handles ChK_SDOB.CheckedChanged
        If ChK_SDOB.Checked = True Then
            Dtp_Spousedob.Enabled = True
            Dtp_Spousedob.Focus()
        Else
            Dtp_Spousedob.Enabled = False
            CHK_WDT.Focus()
        End If
    End Sub

    Private Sub CHK_WDT_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_WDT.CheckedChanged
        Try
            If CHK_WDT.Checked = True Then
                dtp_DOW.Enabled = True
                dtp_DOW.Focus()

            Else
                dtp_DOW.Enabled = False
                txt_PA_Address1.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub

    Private Sub txt_MemberCode_GotFocus(sender As Object, e As EventArgs) Handles txt_MemberCode.GotFocus
        Me.txt_MemberCode.BackColor = Gold
    End Sub

    Private Sub txt_MemberCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_MemberCode.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt_MemberCode.Text = "" Then
                    cmd_MemberCodeHelp_Click(sender, e)
                Else
                    txt_membercode_valid()
                End If
            ElseIf e.KeyCode = Keys.F4 Then
                cmd_MemberCodeHelp_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub

    Private Sub txt_MemberCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_MemberCode.KeyPress
        'getAlphanumeric(e)
    End Sub

    Private Sub txt_MemberCode_LostFocus(sender As Object, e As EventArgs) Handles txt_MemberCode.LostFocus
        Me.txt_MemberCode.BackColor = White
    End Sub

    Private Sub txt_MemberCode_TextChanged(sender As Object, e As EventArgs) Handles txt_MemberCode.TextChanged

    End Sub

    Private Sub cmd_MemberCodeHelp_Click(sender As Object, e As EventArgs) Handles cmd_MemberCodeHelp.Click
        Try
            Dim vform As New LIST_OPERATION1
            gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM membermaster"
            M_WhereCondition = " "
            vform.Field = "MCODE,MNAME"
            vform.vCaption = "Member Master Help"
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txt_MemberCode.Text = Trim(vform.keyfield & "")
                txt_membercode_valid()
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub

    Private Sub txt_MemberCode_Validated(sender As Object, e As EventArgs) Handles txt_MemberCode.Validated
        'If Trim(txt_MemberCode.Text) <> "" Then
        '    Call txt_membercode_valid()
        '    Call Dependentagelimit()
        'Else
        '    txt_MemberCode.Text = ""
        '    txt_MemberCode.Focus()
        'End If
        txt_MemberCode.Text = UCase(txt_MemberCode.Text)
    End Sub
    Private Sub txt_membercode_valid()
        Try
            Dim I, J As Integer
            Dim paddress1, oaddress1, raddress1, caddress1 As String
            Dim paddress2, oaddress2, raddress2, caddress2 As String
            Dim paddress3, oaddress3, raddress3, caddress3 As String
            Dim Pcell, Ocell, Rcell, Ccell, sqlstring As String
            If txt_MemberCode.Text <> "" Then
                'Cmb_Category.Enabled = False
                cbo_CurrentStatus.Enabled = False
                Sqlstr = " SELECT isnull(P_charge,'')as P_charge,isnull(Batchno,'')as Batchno,isnull(religion,'')as religion,isnull(MEMBERTYPECODE,'') as MEMBERTYPECODE,salut,isnull(Prefix,'') as Prefix,isnull(FirstName,'') as FirstName,isnull(MiddleName,'') as MiddleName,isnull(Surname,'') as Surname,isnull(CurentStatus,'') as CurentStatus,isnull(billbasis,'') as billbasis,isnull(SEX,'') as SEX,"
                Sqlstr = Sqlstr & " Convert(varchar(11),isnull(DOB,''),106) as DOB,Convert(varchar(11),isnull(ApplDate,''),106) as ApplDate,isnull(ApplNo,'')as ApplNo,isnull(cardno,'')As cardno,Convert(varchar(11),isnull(SDOB,''),106) as SDOB,wedding_date,Convert(varchar(11),isnull(DOJ,''),106) as DOJ,Convert(varchar(11),isnull(Endingdate,''),106) as Endingdate,isnull(MARITALSTATUS,'') as MARITALSTATUS,isnull(spouse,'') as spouse,isnull(PADD1,'') as PADD1,isnull(PADD2,'') as PADD2,isnull(PADD3,'') as PADD3,PCITY,PSTATE,PCOUNTRY,PPIN,PPHONE1,PPHONE2,PCELL,PEMAIL,CADD1,CADD2,CADD3,CCITY,CSTATE,CCOUNTRY,CPIN,CPHONE1,CPHONE2,CCELL,CEMAIL,OADD1,OADD2,OADD3,OCITY,OSTATE,OCOUNTRY,OPIN,OPHONE1,OPHONE2,OCELL,OEMAIL,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTSTATE,CONTPIN,CONTPHONE1,CONTPHONE2,CONTCELL,CONTEMAIL,RankNo,ICNO,UnitNo,Convert(varchar(11),isnull(DateOfCommission,''),106) as DateOfCommission,Convert(varchar(11),isnull(DateOfCreation,''),106) as DateOfCreation,Convert(varchar(11),isnull(DateOfRelease,''),106) as DateOfRelease,isnull(MDescription,'') as MDescription,RIDCardNo,ArmService,WO,NoOfDependencies,RByMemberNo,RByName,RBYMEMBERNO2,RBYMEMBERNAME2,MEMBERTYPE,PROPOSER,PROPOSERNAME,SECONDER,SECONDERNAME,isnull(RAcopyst1,'') as RAcopyst1,isnull(PAcopyst1,'')as PAcopyst1,isnull(BAcopyst1,'')as BAcopyst1,isnull(bg,'') as bg, isnull(pano,'') as pano,isnull(criditnumber,'') as criditnumber,marital_status,occupation,COMPANY,Designation,BuisnessInfo,isnull(ProfessionInfo,'')as ProfessionInfo ,Products ,AgentsDealers ,Turnover ,NoOfEmp,oldmcode,isnull(spouseprefix,'') as spouseprefix,Isnull(Corporatecode,'') as Corporatecode,Isnull(SpouseFreeze,'')as SpouseFreeze,isnull(Catlimit,0) as catlimit,isnull(memlimit,0) as memlimit,isnull(replacement,'') as replacement,ISNULL(RNO,'') AS RNO,isnull(spl_info,'') as spl_info,isnull(SECONDER1,'') as SECONDER1,isnull(SECONDERNAME1,'') as SECONDERNAME1,isnull(spousemobile,'') as spousemobile ,isnull(PASSPORTNO,'') as PASSPORTNO,ISNULL(MINYN,'') AS MINYN, isnull(ECSYN,'') as ECSYN,isnull(DRCR,'') as DRCR,isnull(MEMBERMICR,0) as  MEMBERMICR ,isnull(OURUSERID,'') as OURUSERID,isnull(ECS_MEMACCOUNTTYPE,0) as  ECS_MEMACCOUNTTYPE,isnull(ECS_MEMBANKACCOUNTNO,0) as ECS_MEMBANKACCOUNTNO,isnull(ECS_AMOUNT,0) as ECS_AMOUNT ,isnull(ECS_SBCD,0) as ECS_SBCD,isnull(CHKDIR,'') as CHKDIR FROM MEMBERMASTER WHERE MCODE='" & txt_MemberCode.Text & "'"
                gconnection.getDataSet(Sqlstr, "MemMst")
                'Call loadMaritalstatus(I + 1)
                'Call loadmembertype(I + 1)
                If gdataset.Tables("MemMst").Rows.Count > 0 Then
                    txt_MemberCode.ReadOnly = True
                    txt_MemberCode.Select()
                    'Call Dependentagelimit()
                    Cmb_Category.Enabled = False
                    'cbo_BillingBasis.Enabled = False
                    'Call loadmembertype(I + 1)
                    'Call loadSalutation(I + 1)
                    Com_post.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("P_charge"))
                    Txt_batch.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("Batchno"))
                    Cbo_relation.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("religion"))
                    Cbo_title.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("salut"))
                    TXT_TITLE.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("Prefix"))
                    txt_FirstName.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("FirstName"))
                    txt_MiddleName.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("MiddleName"))
                    txt_Surname.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("Surname"))
                    Cmb_Category.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("MEMBERTYPE"))
                    'If Cmb_Category.Text = "INSTITUTIONAL MEMBERS" Then
                    '    Txt_Replacement.Enabled = True
                    '    Cmd_Replacement.Enabled = True
                    'Else
                    '    Txt_Replacement.Enabled = False
                    '    Cmd_Replacement.Enabled = False

                    'End If
                    sqlstring = "select isnull(creditlimityn,'') as creditlimityn,isnull(tenures,'') as tenures from subcategorymaster where subtypedesc='" & Cmb_Category.Text & "'"
                    gconnection.getDataSet(sqlstring, "subcategory")
                    If gdataset.Tables("subcategory").Rows.Count > 0 Then
                        CREDITYN = gdataset.Tables("subcategory").Rows(0).Item("CREDITLIMITYN")
                        VALIDITY = gdataset.Tables("subcategory").Rows(0).Item("tenures")

                    End If
                    If VALIDITY = "Y" Then
                        chk_EXPDT.Enabled = False
                        dtp_EXPDT.Enabled = False
                    Else

                    End If
                    Dim index As Integer
                    gconnection.getDataSet("SELECT isnull(TYPEDESC,'') as TYPEDESC,isnull(MEMBERTYPE,'') as MEMBERTYPE  FROM MEMBERTYPE WHERE ISNULL(FREEZE,'')<>'Y' and MEMBERTYPE='" & gdataset.Tables("MemMst").Rows(0).Item("MEMBERTYPECODE") & "'", "TypeMst")
                    'If gdataset.Tables("TypeMst").Rows.Count > 0 Then
                    '    Cmb_Category.Text = (gdataset.Tables("TypeMst").Rows(0).Item("TYPEDESC"))
                    'End If
                    cbo_CurrentStatus.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CurentStatus"))
                    '---------subscription Type-----------
                    If Cmb_Category.Text = "INSTITUTIONAL MEMBERS" Then
                        If cbo_CurrentStatus.Text = "ACTIVE" Or cbo_CurrentStatus.Text = "LIVE" Then
                            Txt_Replacement.Enabled = True
                            Txt_Rno.Enabled = True
                            Cmd_Replacement.Enabled = True
                        Else
                            Txt_Replacement.Enabled = False
                            Cmd_Replacement.Enabled = False
                            Txt_Rno.Enabled = False

                        End If
                    Else
                        Txt_Replacement.Enabled = False
                        Cmd_Replacement.Enabled = False

                    End If
                    validation = True
                    index = cbo_BillingBasis.FindString((gdataset.Tables("MemMst").Rows(0).Item("billbasis")))
                    If index < 0 Then
                        If Cmb_Category.Items.Count > 0 Then
                            cbo_BillingBasis.SelectedIndex = 0
                        End If
                    Else
                        cbo_BillingBasis.SelectedIndex = index
                    End If
                    If (gdataset.Tables("MemMst").Rows(0).Item("SEX")) = "F" Then
                        chk_female.Checked = True
                        chk_male.Checked = False
                    ElseIf (gdataset.Tables("MemMst").Rows(0).Item("SEX")) = "M" Then
                        chk_male.Checked = True
                        chk_female.Checked = False
                    Else
                        chk_male.Checked = False
                        chk_female.Checked = False
                    End If

                    If (gdataset.Tables("MemMst").Rows(0).Item("DOB")) = "01 Jan 1900" Then
                        'dtp_DOB.Text = ""
                        CHK_DOB.Checked = False
                    Else
                        dtp_DOB.Text = Format(CDate(gdataset.Tables("MemMst").Rows(0).Item("DOB")), "dd/MMM/yyyy")
                        CHK_DOB.Checked = True
                    End If

                    CHK_DOB_CheckedChanged(New System.EventArgs, New System.EventArgs)
                    If (gdataset.Tables("MemMst").Rows(0).Item("Endingdate")) = "01 Jan 1900" Then
                        dtp_EXPDT.Text = ""
                        chk_EXPDT.Checked = False
                    Else
                        dtp_EXPDT.Text = Format(CDate(gdataset.Tables("MemMst").Rows(0).Item("Endingdate")), "dd/MMM/yyyy")
                        chk_EXPDT.Checked = True
                        chk_EXPDT.Enabled = True
                    End If
                    chk_EXPDT_CheckedChanged(New System.EventArgs, New System.EventArgs)

                    If (gdataset.Tables("MemMst").Rows(0).Item("DOJ")) = "01 Jan 1900" Then
                        dtp_DOJ.Text = ""
                        CHK_DOJ.Checked = False
                    Else
                        dtp_DOJ.Text = Format(CDate(gdataset.Tables("MemMst").Rows(0).Item("DOJ")), "dd/MMM/yyyy")
                        CHK_DOJ.Checked = True
                    End If
                    If (gdataset.Tables("MemMst").Rows(0).Item("wedding_date")) = "01 Jan 1900" Then
                        dtp_DOW.Text = ""
                        CHK_WDT.Checked = False
                    Else
                        dtp_DOW.Text = Format(CDate(gdataset.Tables("MemMst").Rows(0).Item("wedding_date")), "dd/MMM/yyyy")
                        CHK_WDT.Checked = True
                    End If

                    If (gdataset.Tables("MemMst").Rows(0).Item("SDOB")) = "01 Jan 1900" Then
                        Dtp_Spousedob.Text = ""
                        ChK_SDOB.Checked = False
                    Else
                        Dtp_Spousedob.Text = (gdataset.Tables("MemMst").Rows(0).Item("SDOB"))
                        ChK_SDOB.Checked = True
                    End If

                    txt_Spouse.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("Spouse"))
                    txt_PA_Address1.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PADD1"))
                    txt_PA_Address2.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PADD2"))
                    txt_PA_Address3.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PADD3"))

                    Cbo_PCity.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PCITY"))
                    Cbo_PState.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PSTATE"))
                    Cbo_PCountry.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PCOUNTRY"))

                    txt_PA_PinCode.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PPIN"))
                    txt_PA_Phone.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PPHONE1"))
                    txt_PA_Phone2.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PPHONE2"))
                    txt_PA_Mobile.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PCELL"))
                    txt_PA_Email.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PEMAIL"))

                    txt_RA_Address1.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CADD1"))
                    txt_RA_Address2.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CADD2"))
                    txt_RA_Address3.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CADD3"))

                    txt_RA_City.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CCITY"))
                    txt_RA_State.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CSTATE"))

                    Cbo_CCity.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CCITY"))
                    Cbo_CState.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CSTATE"))
                    Cbo_CCountry.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CCOUNTRY"))

                    txt_RA_PinCode.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CPIN"))
                    txt_RA_PhoneNo.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CPHONE1"))
                    txt_RA_PhoneNo2.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CPHONE2"))
                    txt_RA_MobileNo.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CCELL"))
                    txt_RA_Email.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CEMAIL"))

                    txt_BA_Address1.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OADD1"))
                    txt_BA_Address2.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OADD2"))
                    txt_BA_Address3.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OADD3"))

                    Cbo_BCity.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OCITY"))
                    Cbo_BState.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OSTATE"))
                    Cbo_BCountry.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OCOUNTRY"))

                    Txt_Replacement.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("REPLACEMENT"))
                    Txt_Rno.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("RNO"))
                    txt_BA_PinCode.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OPIN"))
                    txt_BA_PhoneNo.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OPHONE1"))
                    txt_BA_PhoneNo2.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OPHONE2"))
                    txt_BA_MobileNo.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OCELL"))
                    txt_BA_Email.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("OEMAIL"))

                    Txt_APPLNO.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("ApplNo"))
                    dtp_ApplnDate.Text = Format(CDate(gdataset.Tables("MemMst").Rows(0).Item("ApplDate")), "dd/MMM/yyyy")
                    cmbRankNo.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("RankNo"))
                    txtICNO.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("ICNO"))
                    cmbUnitNo.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("UnitNo"))
                    dtpDFCommission.Text = (gdataset.Tables("MemMst").Rows(0).Item("DateOfCommission"))
                    dtpDFCreation.Text = (gdataset.Tables("MemMst").Rows(0).Item("DateOfCreation"))
                    dtpDFRelease.Text = (gdataset.Tables("MemMst").Rows(0).Item("DateOfRelease"))
                    Cbo_servives.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("MDescription"))
                    txtRIDCARDNO.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("RIDCardNo"))
                    txtArmService.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("ArmService"))
                    txtWO.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("WO"))
                    txtNFDependencies.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("NoOfDependencies"))
                    txtRBYMEMBERNO.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("RByMemberNo"))
                    txtNBYMEMBERNAME.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("RByName"))
                    txtRBYMEMBERNO2.Text() = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("RBYMEMBERNO2"))
                    txtNBYMEMBERNAME2.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("RBYMEMBERNAME2"))
                    txt_ProposerCode.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PROPOSER"))
                    txt_Proposername.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PROPOSERNAME"))
                    txt_SeconderCode1.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("SECONDER"))
                    txt_SeconderName1.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("SECONDERNAME"))
                    txt_SeconderCode2.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("SECONDER1"))
                    txt_SeconderName2.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("SECONDERNAME1"))
                    Txt_BloodGroup.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("BG"))
                    Txt_pancarno.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("PANO"))
                    txt_CreditNumber.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("criditnumber"))
                    Txt_companyName.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("COMPANY"))
                    txt_occupation.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("occupation"))
                    Cbo_MaritalStatus.Text = gdataset.Tables("MemMst").Rows(0).Item("marital_status")
                    'Txt_Professionalinfo.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("ProfessionInfo"))
                    Cbo_professional.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("ProfessionInfo"))
                    Txt_Bussinessinfo.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("BuisnessInfo"))
                    Txt_products.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("Products"))
                    Txt_turnover.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("Turnover"))
                    Txt_noofEmpolyee.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("NoOfEmp"))
                    Txt_AgenttInfo.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("AgentsDealers"))
                    Cbo_designation.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("Designation"))
                    'Txt_oldmembership.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("oldmcode"))
                    Cbo_Spousesalutation.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("spouseprefix"))
                    Txt_CorporateCode.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("Corporatecode"))
                    TXT_CATLIMIT.Text = Val(gdataset.Tables("memmst").Rows(0).Item("catlimit"))
                    TXT_MEMLIMIT.Text = Val(gdataset.Tables("memmst").Rows(0).Item("memlimit"))
                    txt_spl_info.Text = CheckDBNull(gdataset.Tables("memmst").Rows(0).Item("spl_info"))
                    TXT_SPOUSEMOBILE.Text = CheckDBNull(gdataset.Tables("memmst").Rows(0).Item("spousemobile"))
                    txt_passportno.Text = CheckDBNull(gdataset.Tables("memmst").Rows(0).Item("PASSPORTNO"))

                    '----Spouse Freeze------------
                    If CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("SpouseFreeze")) = "Y" Then
                        Me.Chk_spouseFreeze.Checked = True
                    ElseIf CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("SpouseFreeze")) = "N" Then
                        Me.Chk_spouseFreeze.Checked = False
                    End If
                    '----Minimum Y/N------------
                    If CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("MINYN")) = "Y" Then
                        Me.Chk_MinYN.Checked = True
                    Else
                        Me.Chk_MinYN.Checked = False
                    End If
                    '----CHDIR Y/N------------
                    If CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CHKDIR")) = "Y" Then
                        Me.rdo_dir.Checked = True
                    Else
                        Me.rdo_dir.Checked = False
                    End If
                    '----ECS Y/N------------
                    If CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("ECSYN")) = "Y" Then
                        Me.ChK_ECSYN.Checked = True
                        Me.Grp_ECSSETUP.Visible = True
                        Txt_DRCR.Text = CheckDBNull(gdataset.Tables("memmst").Rows(0).Item("DRCR"))
                        Txt_MemMICR.Text = CheckDBNull(gdataset.Tables("memmst").Rows(0).Item("MEMBERMICR"))
                        Txt_OurUID.Text = CheckDBNull(gdataset.Tables("memmst").Rows(0).Item("OURUSERID"))
                        Txt_MemAcType.Text = CheckDBNull(gdataset.Tables("memmst").Rows(0).Item("ECS_MEMACCOUNTTYPE"))
                        Txt_MemBankAccNo.Text = CheckDBNull(gdataset.Tables("memmst").Rows(0).Item("ECS_MEMBANKACCOUNTNO"))
                        Txt_Amount.Text = CheckDBNull(gdataset.Tables("memmst").Rows(0).Item("ECS_AMOUNT"))
                        Cmb_MemAcType.Text = CheckDBNull(gdataset.Tables("memmst").Rows(0).Item("ECS_SBCD"))
                    Else
                        Me.Grp_ECSSETUP.Visible = True = False
                    End If
                    'DEPENDENT DETAILS 
                    Sqlstr = " select ISNULL(prefix,'')AS prefix,ISNULL(mem_code,'') AS MCODE,ISNULL(child_nm,'') AS CNAME,ISNULL(child_dob,'') AS CDOB,ISNULL((relation),'') AS RELATION,ISNULL(maritalstatus,'') AS maritalstatus,dep_bloodgroup,isnull(Sex,'') as Sex,isnull(SpouseName,'')as SpouseName,isnull(membertype,'')as membertype,isnull(studentmember,'')as studentmember,isnull(dep_Doj,'')as dep_Doj,isnull(Religion,'') as Religion,isnull(anniversarydate,'') as anniversarydate,isnull(occupation,'')as occupation,isnull(Panno,0) as Panno,isnull(phone,'') as phone,isnull(mobile,'') as mobile,isnull(emailid,'') as emailid,isnull(type1,'') as type1 from memdet where type0='CHLD' AND MEM_CODE='" & txt_MemberCode.Text & "'"
                    gconnection.getDataSet(Sqlstr, "DeptMst")
                    If gdataset.Tables("DeptMst").Rows.Count > 0 Then
                        For I = 0 To gdataset.Tables("DeptMst").Rows.Count - 1
                            With grd_depedent
                                'Call loadmembertype(I + 1)
                                'Call loadSalutation(I + 1)
                                'Call loadMaritalstatus(I + 1)
                                grd_depedent.Row = I + 1
                                grd_depedent.Col = 1
                                .Text = (gdataset.Tables("DeptMst").Rows(I).Item("prefix"))
                                'Call loadmembertype(I + 1)
                                'Call loadSalutation(I + 1)
                                'Call loadMaritalstatus(I + 1)
                                grd_depedent.Col = 2
                                .Text = (gdataset.Tables("DeptMst").Rows(I).Item("CNAME"))
                                'Call loadmembertype(I + 1)
                                'Call loadSalutation(I + 1)
                                'Call loadMaritalstatus(I + 1)
                                grd_depedent.Col = 3
                                If Format(CDate(gdataset.Tables("DeptMst").Rows(I).Item("CDOB")), "yyyy/MM/dd") = "1900/01/01" Then
                                    .Text = ""
                                Else
                                    .Text = Format(CDate(gdataset.Tables("DeptMst").Rows(I).Item("CDOB")), "dd/MM/yyyy")
                                End If

                                'Call loadmembertype(I + 1)
                                'Call loadSalutation(I + 1)
                                'Call loadMaritalstatus(I + 1)
                                grd_depedent.Col = 4
                                .Text = (gdataset.Tables("DeptMst").Rows(I).Item("Sex"))

                                'Call loadmembertype(I + 1)
                                'Call loadSalutation(I + 1)
                                'Call loadMaritalstatus(I + 1)

                                grd_depedent.Col = 5
                                If ((gdataset.Tables("DeptMst").Rows(I).Item("RELATION")) = "SPOUSE") Then
                                    .Text = "SPOUSE"
                                ElseIf ((gdataset.Tables("DeptMst").Rows(I).Item("RELATION")) = "SON") Then
                                    .Text = "SON"
                                ElseIf ((gdataset.Tables("DeptMst").Rows(I).Item("RELATION")) = "DAUGHTER") Then
                                    .Text = "DAUGHTER"
                                ElseIf ((gdataset.Tables("DeptMst").Rows(I).Item("RELATION")) = "FATHER") Then
                                    .Text = "FATHER"
                                ElseIf ((gdataset.Tables("DeptMst").Rows(I).Item("RELATION")) = "MOTHER") Then
                                    .Text = "MOTHER"
                                ElseIf ((gdataset.Tables("DeptMst").Rows(I).Item("RELATION")) = "OTHERS") Then
                                    .Text = "OTHERS"
                                End If
                                'Call loadmembertype(I + 1)
                                'Call loadSalutation(I + 1)
                                'Call loadMaritalstatus(I + 1)

                                grd_depedent.Col = 6
                                .Text = CheckDBNull(gdataset.Tables("DeptMst").Rows(I).Item("SpouseName"))
                                'Call loadmembertype(I + 1)
                                'Call loadSalutation(I + 1)
                                'Call loadMaritalstatus(I + 1)
                                grd_depedent.Col = 8
                                If Format(CDate(gdataset.Tables("DeptMst").Rows(I).Item("anniversarydate")), "yyyy/MM/dd") = "1900/01/01" Then
                                    .Text = ""
                                Else
                                    .Text = Format(CDate(gdataset.Tables("DeptMst").Rows(I).Item("anniversarydate")), "dd/MM/yyyy")
                                End If
                                'Call loadmembertype(I + 1)
                                'Call loadSalutation(I + 1)
                                'Call loadMaritalstatus(I + 1)

                                grd_depedent.Col = 7
                                .Text = (gdataset.Tables("DeptMst").Rows(I).Item("maritalstatus"))
                                'Call loadmembertype(I + 1)
                                'Call loadSalutation(I + 1)


                                grd_depedent.Col = 9
                                Sqlstr = "SELECT memimage as memimage FROM memdet WHERE mem_code='" & Trim(txt_MemberCode.Text) & "' and child_nm='" & gdataset.Tables("DeptMst").Rows(I).Item("CNAME") & "'  and type0='chld' "
                                LoadFoto_chld(Sqlstr, I + 1)
                                'Call loadmembertype(I + 1)
                                'Call loadSalutation(I + 1)
                                'Call loadMaritalstatus(I + 1)
                                grd_depedent.Col = 10
                                Sqlstr = "SELECT depimagesign as depimagesign FROM memdet WHERE mem_code='" & Trim(txt_MemberCode.Text) & "' and child_nm='" & gdataset.Tables("DeptMst").Rows(I).Item("CNAME") & "'  and type0='chld' "
                                LoadFoto_chld1(Sqlstr, I + 1)
                                'Call loadmembertype(I + 1)
                                'Call loadSalutation(I + 1)
                                'Call loadMaritalstatus(I + 1)
                                grd_depedent.Col = 13
                                .Text = CheckDBNull(gdataset.Tables("DeptMst").Rows(I).Item("dep_bloodgroup"))
                                'Call loadmembertype(I + 1)
                                'Call loadSalutation(I + 1)
                                'Call loadMaritalstatus(I + 1)
                                grd_depedent.Col = 14
                                .Text = CheckDBNull(gdataset.Tables("DeptMst").Rows(I).Item("studentmember"))
                                'Call loadmembertype(I + 1)
                                'Call loadSalutation(I + 1)
                                'Call loadMaritalstatus(I + 1)
                                grd_depedent.Col = 15
                                If Format(CDate(gdataset.Tables("DeptMst").Rows(I).Item("dep_Doj")), "yyyy/MM/dd") = "1900/01/01" Then
                                    .Text = ""
                                Else
                                    .Text = Format(CDate(gdataset.Tables("DeptMst").Rows(I).Item("dep_Doj")), "dd/MM/yyyy")
                                End If
                                'Call loadmembertype(I + 1)
                                'Call loadSalutation(I + 1)
                                'Call loadMaritalstatus(I + 1)

                                grd_depedent.Col = 16
                                .Text = CheckDBNull(gdataset.Tables("DeptMst").Rows(I).Item("membertype"))
                                'Call loadmembertype(I + 1)
                                'Call loadSalutation(I + 1)
                                'Call loadMaritalstatus(I + 1)

                                grd_depedent.Col = 17
                                .Text = CheckDBNull(gdataset.Tables("DeptMst").Rows(I).Item("Religion"))
                                'Call loadmembertype(I + 1)
                                'Call loadSalutation(I + 1)
                                'Call loadMaritalstatus(I + 1)

                                grd_depedent.Col = 18
                                .Text = CheckDBNull(gdataset.Tables("DeptMst").Rows(I).Item("occupation"))
                                'Call loadmembertype(I + 1)
                                'Call loadSalutation(I + 1)
                                'Call loadMaritalstatus(I + 1)
                                grd_depedent.Col = 19
                                .Text = CheckDBNull(gdataset.Tables("DeptMst").Rows(I).Item("Panno"))
                                'Call loadmembertype(I + 1)
                                'Call loadSalutation(I + 1)
                                'Call loadMaritalstatus(I + 1)
                                grd_depedent.Col = 20
                                .Text = CheckDBNull(gdataset.Tables("DeptMst").Rows(I).Item("phone"))
                                'Call loadmembertype(I + 1)
                                'Call loadSalutation(I + 1)
                                'Call loadMaritalstatus(I + 1)
                                grd_depedent.Col = 21
                                .Text = CheckDBNull(gdataset.Tables("DeptMst").Rows(I).Item("mobile"))
                                'Call loadmembertype(I + 1)
                                'Call loadSalutation(I + 1)
                                'Call loadMaritalstatus(I + 1)
                                grd_depedent.Col = 22
                                .Text = CheckDBNull(gdataset.Tables("DeptMst").Rows(I).Item("emailid"))
                                'Call loadmembertype(I + 1)
                                'Call loadSalutation(I + 1)
                                'Call loadMaritalstatus(I + 1)
                                grd_depedent.Col = 23
                                .Text = CheckDBNull(gdataset.Tables("DeptMst").Rows(I).Item("type1"))
                                'Call loadmembertype(I + 1)
                                'Call loadSalutation(I + 1)
                                'Call loadMaritalstatus(I + 1)
                            End With
                        Next I
                    End If

                    'Member Education
                    Sqlstr = " SELECT ISNULL(QUAL_DET,'') AS QUAL_DET,ISNULL(REMARKS,'') AS REMARKS,ISNULL(YEAR_PASS,'') AS YEAR_PASS,"
                    Sqlstr = Sqlstr & "ISNULL(INSTITUTE,'') AS INSTITUTE,ISNULL(DIVISION,'') AS DIVISION FROM MEMDET WHERE TYPE0='QUAL' AND MEM_CODE='" & txt_MemberCode.Text & "'"
                    gconnection.getDataSet(Sqlstr, "QualMst1")
                    'SSgrid_Qual_det.ClearRange(1, 1, -1, -1, True)
                    If gdataset.Tables("QualMst1").Rows.Count > 0 Then
                        For I = 0 To gdataset.Tables("QualMst1").Rows.Count - 1
                            With grd_Education
                                .Row = I + 1
                                .Col = 1
                                .Text = (gdataset.Tables("QualMst1").Rows(I).Item("QUAL_DET"))
                                .Col = 2
                                .Text = (gdataset.Tables("QualMst1").Rows(I).Item("REMARKS"))
                                .Col = 3
                                .Text = (gdataset.Tables("QualMst1").Rows(I).Item("YEAR_PASS"))
                                .Col = 4
                                .Text = (gdataset.Tables("QualMst1").Rows(I).Item("INSTITUTE"))
                                .Col = 5
                                .Text = (gdataset.Tables("QualMst1").Rows(I).Item("DIVISION"))
                            End With
                        Next I
                    End If

                    'Entrance Fee
                    Sqlstr = " SELECT ISNULL(rct_no,'') AS rct_no,ISNULL(start_dt,'') AS start_dt,ISNULL(amount,0) AS amount"
                    Sqlstr = Sqlstr & " FROM MEMDET WHERE TYPE0='ENTR' AND MEM_CODE='" & txt_MemberCode.Text & "'"
                    gconnection.getDataSet(Sqlstr, "feeMst1")
                    If gdataset.Tables("feeMst1").Rows.Count > 0 Then
                        For I = 0 To gdataset.Tables("feeMst1").Rows.Count - 1
                            With grd_Entfee
                                .Row = I + 1
                                .Col = 1
                                .Text = (gdataset.Tables("feeMst1").Rows(I).Item("rct_no"))
                                .Col = 2
                                If Format(CDate(gdataset.Tables("feeMst1").Rows(I).Item("start_dt")), "yyyy/MM/dd") = "1900/01/01" Then
                                    .Text = ""
                                Else
                                    .Text = Format(CDate(gdataset.Tables("feeMst1").Rows(I).Item("start_dt")), "dd/MM/yyyy")
                                End If
                                .Col = 3
                                .Text = (gdataset.Tables("feeMst1").Rows(I).Item("amount"))
                            End With
                        Next I
                    End If
                    Sqlstr = "SELECT memimage as memimage FROM membermaster WHERE mcode='" & Trim(txt_MemberCode.Text) & "' "
                    LoadFoto_DB(Sqlstr, Img_Photo)
                    Sqlstr = "SELECT memimagesign as memimage FROM membermaster WHERE mcode='" & Trim(txt_MemberCode.Text) & "' "
                    LoadFoto_DB(Sqlstr, Img_Signature)
                    Sqlstr = "SELECT SpouseImage as memimage FROM membermaster WHERE mcode='" & Trim(txt_MemberCode.Text) & "' "
                    LoadFoto_DB(Sqlstr, Img_Spousephoto)
                    Sqlstr = "SELECT SpouseImageSign as memimage FROM membermaster WHERE mcode='" & Trim(txt_MemberCode.Text) & "' "
                    LoadFoto_DB(Sqlstr, Sp_Img_Signature)
                    btn_add.Text = "Update[F7]"
                    'paddress1 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("PADD1")))
                    'oaddress1 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("OADD1")))
                    'raddress1 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("CADD1")))
                    'caddress1 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("CONTADD1")))
                    'paddress2 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("PADD2")))
                    'oaddress2 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("OADD2")))
                    'raddress2 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("CADD2")))
                    'caddress2 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("CONTADD2")))
                    'paddress3 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("PADD3")))
                    'oaddress3 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("OADD3")))
                    'raddress3 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("CADD3")))
                    'caddress3 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("CONTADD3")))
                    'pcell = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("PCELL")))
                    'ocell = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("OCELL")))
                    'rcell = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("CCELL")))
                    'ccell = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("CONTCELL")))
                    'If paddress1 = caddress1 And paddress2 = caddress2 And paddress3 = caddress3 And Pcell = Ccell Then
                    '    chk_ContactAddress1.Checked = True
                    'ElseIf oaddress1 = caddress1 And oaddress2 = caddress2 And oaddress3 = caddress3 And Ocell = Ccell Then
                    '    chk_ContactAddress2.Checked = True
                    'ElseIf raddress1 = caddress1 And raddress2 = caddress2 And raddress3 = caddress3 And Rcell = Ccell Then
                    '    chk_ContactAddress3.Checked = True
                    'Else
                    '    chk_ContactAddress1.Checked = False
                    '    chk_ContactAddress2.Checked = False
                    '    chk_ContactAddress3.Checked = False
                    'End If
                    paddress1 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("PAcopyst1")))
                    oaddress1 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("BAcopyst1")))
                    raddress1 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("RAcopyst1")))
                    If paddress1 = "Y" Then
                        chk_ContactAddress1.Checked = True
                    ElseIf oaddress1 = "Y" Then
                        chk_ContactAddress2.Checked = True
                    ElseIf raddress1 = "Y" Then
                        chk_ContactAddress3.Checked = True
                    Else
                        chk_ContactAddress1.Checked = False
                        chk_ContactAddress2.Checked = False
                        chk_ContactAddress3.Checked = False
                    End If
                    Cbo_title.Focus()

                Else
                    txt_MemberCode.ReadOnly = False
                    btn_add.Text = "Add[F7]"
                    'Cmb_Category.SelectedIndex = 1
                    Cmb_Category.Focus()

                    'Cbo_title.Focus()
                    'Dim MEMMCODE As String
                    'MEMMCODE = txt_MemberCode.Text
                    'MessageBox.Show("INVALID MEMBER CODE", MEMMCODE)
                    'txt_MemberCode.Text = ""
                    'txt_MemberCode.Focus()
                    'Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
            ' CmdClear_Click(sender, e)
        End Try
    End Sub
    Public Sub LoadFoto_DB(ByVal quystr As String, ByVal PIC As PictureBox)
        Try
            Dim cn As New SqlConnection(strcn)
            Dim sssql As String
            'sssql = "SELECT * FROM SM_CARDFILE_HDR WHERE [16_DIGIT_CODE] ='" & Trim(CARDID.Text) & "' AND [16_DIGIT_CODE] NOT IN ( SELECT [16_DIGIT_CODE] FROM SM_CARDFILE_HDR WHERE [16_digit_code] = '" & Trim(CARDID.Text) & "' AND MEMIMAGE IS NULL)"
            Dim cmd As New SqlCommand(quystr, cn)
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "sm_image")
            Dim c As Integer = ds.Tables("SM_IMAGE").Rows.Count
            If c > 0 Then
                Dim bytMEMimage() As Byte = ds.Tables("SM_IMAGE").Rows(c - 1)("memimage")
                Dim stmMEMimage As New MemoryStream(bytMEMimage)
                PIC.Image = Image.FromStream(stmMEMimage)
            Else
                PIC.Image = Nothing
            End If
        Catch ex As Exception
            '            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub Dependentagelimit()
        Dim i As Integer
        Dim Itration
        Dim depname, age As String
        'sqlstring = "select CHILD_NM from memdet a left outer join  membermaster b on a.mEm_code =b.mcode where a.mem_code='" & Trim(txt_MemberCode.Text) & "' and relation  in ('SON','DAUGHTER','CHILD') and datediff(month,a.child_dob,getdate())-216>0  "
        sqlstring = "select CHILD_NM,datediff(month,a.child_dob,getdate())/12 as age from memdet a left outer join  membermaster b on a.mEm_code =b.mcode where a.mem_code='" & Trim(txt_MemberCode.Text) & "' and relation  in ('SON','DAUGHTER','CHILD') and datediff(month,a.child_dob,getdate())-216>0  "
        gconnection.getDataSet(sqlstring, "DeptMst")
        If gdataset.Tables("DeptMst").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("DeptMst").Rows.Count - 1
                With grd_depedent
                    grd_depedent.Row = i + 1
                    grd_depedent.Col = 2
                    .Text = (gdataset.Tables("DeptMst").Rows(i).Item("CHILD_NM"))
                    depname = .Text
                    age = (gdataset.Tables("DeptMst").Rows(i).Item("age"))
                    'MessageBox.Show("Name: " & depname & " Age is Above 18 years old ", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MessageBox.Show("Name: " & depname & " Age is Above 18 years old, Age - " & age & " ", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End With
            Next i
        End If
    End Sub
    Public Sub LoadFoto_chld1(ByVal quystr As String, ByVal row As Integer)
        Try
            Dim cn As New SqlConnection(strcn)
            Dim sssql As String
            'sssql = "SELECT * FROM SM_CARDFILE_HDR WHERE [16_DIGIT_CODE] ='" & Trim(CARDID.Text) & "' AND [16_DIGIT_CODE] NOT IN ( SELECT [16_DIGIT_CODE] FROM SM_CARDFILE_HDR WHERE [16_digit_code] = '" & Trim(CARDID.Text) & "' AND MEMIMAGE IS NULL)"
            Dim cmd As New SqlCommand(quystr, cn)
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "sm_image")
            Dim c As Integer = ds.Tables("SM_IMAGE").Rows.Count
            If c > 0 Then
                Dim bytMEMimage() As Byte = ds.Tables("SM_IMAGE").Rows(c - 1)("DEPIMAGESIGN")
                Dim stmMEMimage As New MemoryStream(bytMEMimage)
                With grd_depedent
                    .Col = 10
                    .Row = row
                    grd_depedent.TypePictPicture = Image.FromStream(stmMEMimage)
                    vOutfile = Mid("Pho" & (Rnd() * 800000), 1, 8)
                    VFilePath = apppath & "\Reports\" & vOutfile & ".JPG"
                    If File.Exists(VFilePath) = True Then
                        File.Delete(VFilePath)
                    End If
                    Dim myBitmap As Bitmap = CType(Bitmap.FromStream(stmMEMimage), Bitmap)
                    myBitmap.Save(VFilePath)
                    myBitmap.Dispose()
                    .Col = 10
                    .Row = row
                    .Text = VFilePath
                End With
            Else
                'PIC.Image = Nothing
                'Return Nothing
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Cmb_Category_KeyDown(sender As Object, e As KeyEventArgs) Handles Cmb_Category.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Txt_CorporateCode.Focus()
            Cbo_title.Focus()

        End If
    End Sub

    Private Sub Cmb_Category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Category.SelectedIndexChanged
        Dim SUBCATEGORY As New DataTable
        Dim ssql, SQL, SQL1, CRED, CORP As String
        Dim I As Integer = 0
        Dim J As Integer = 0
        ssql = " Select isnull(AddDateTime,'') AS ADDDATETIME,isnull(typecode,'')as typecode,isnull(subtypeCode,'')as subtypeCode,isnull(Subtypedesc,'')as Subtypedesc,Status,isnull(Validity,'')as Validity,Isnull(Permanent,'')as Permanent,isnull(votingright,'') as votingright,isnull(SubscriptionRequired,'') as SubscriptionRequired,isnull(Creditlimit,'') as Creditlimit,isnull(catlimit,0)as catlimit,isnull(barlimit,0) as barlimit,Freeze,isnull(ClubAccount,'')as ClubAccount,Isnull(Tenures,'')as Tenures,Isnull(Corporatemember,'')as Corporatemember From SubCategorymaster where subtypedesc='" & Cmb_Category.Text & "'"
        SUBCATEGORY = gconnection.GetValues(ssql)

        'MOHAN
        If SUBCATEGORY.Rows.Count > 0 Then
            CORP = SUBCATEGORY.Rows(0).Item("Corporatemember")
        End If

        ssql = "select isnull(CREDITLIMIT,0) AS CREDITLIMIT,ISNULL(CREDITLIMITYN,'') AS CREDITLIMITYN,ISNULL(VALIDITY,0) AS VALIDITY,ISNULL(TENURES,'') AS TENURES FROM SUBCATEGORYMASTER WHERE subtypedesc='" & Cmb_Category.Text & "' "
        SUBCATEGORY = gconnection.GetValues(ssql)
        If SUBCATEGORY.Rows.Count > 0 Then
            CRED = SUBCATEGORY.Rows(0).Item("CREDITLIMITYN")
            VALIDITY = SUBCATEGORY.Rows(0).Item("TENURES")
            PERIOD = Val(SUBCATEGORY.Rows(0).Item("VALIDITY"))
            TXT_MEMLIMIT.Text = Val(SUBCATEGORY.Rows(0).Item("CREDITLIMIT"))
        End If
        If CRED = "Y" Then
            CREDITYN = "Y"
        Else
            CREDITYN = "N"
        End If
        If VALIDITY = "Y" Then
            chk_EXPDT.Checked = True
            dtp_EXPDT.Value = DateAdd(DateInterval.Month, PERIOD, Now)
            chk_EXPDT.Enabled = False
            dtp_EXPDT.Enabled = False
            Cmb_Category.Focus()
        Else
            chk_EXPDT.Checked = False
            chk_EXPDT.Enabled = True
            dtp_EXPDT.Enabled = False
            dtp_EXPDT.Value = Now
            Cmb_Category.Focus()

        End If


        If CORP = "Y" Then
            Txt_CorporateCode.Visible = True
            cmd_CorporateCodeHelp.Visible = True
            Label109.Visible = True
        Else
            Txt_CorporateCode.Visible = False
            cmd_CorporateCodeHelp.Visible = False
            Label109.Visible = False
        End If


    End Sub

    Private Sub Txt_CorporateCode_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_CorporateCode.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Txt_CorporateCode.Text = "" Then
                    cmd_CorporateCodeHelp_Click(sender, e)
                Else
                    Call txt_corporate_valid()
                End If
            ElseIf e.KeyCode = Keys.F4 Then
                cmd_CorporateCodeHelp_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub

    Private Sub Txt_CorporateCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_CorporateCode.KeyPress
        'Dim SUBCATEGORY As New DataTable
        'Dim ssql, SQL, SQL1 As String
        'Dim I As Integer = 0
        'Dim J As Integer = 0
        'ssql = " Select isnull(AddDateTime,'') AS ADDDATETIME,isnull(typecode,'')as typecode,isnull(subtypeCode,'')as subtypeCode,isnull(Subtypedesc,'')as Subtypedesc,Status,isnull(Validity,'')as Validity,Isnull(Permanent,'')as Permanent,isnull(votingright,'') as votingright,isnull(SubscriptionRequired,'') as SubscriptionRequired,isnull(Creditlimit,'') as Creditlimit,isnull(catlimit,0)as catlimit,isnull(barlimit,0) as barlimit,Freeze,isnull(ClubAccount,'')as ClubAccount,Isnull(Tenures,'')as Tenures,Isnull(Corporatemember,'')as Corporatemember From SubCategorymaster where Corporatemember='Y' and subtypedesc='" & Cmb_Category.Text & "'"
        'SUBCATEGORY = gconnection.GetValues(ssql)
        'If SUBCATEGORY.Rows.Count > 0 Then
        '    Txt_CorporateCode.ReadOnly = False
        '    CorporateYN = True
        'Else
        '    Txt_CorporateCode.ReadOnly = True
        '    MessageBox.Show("Can't Match Corporate Code and Category", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Txt_CorporateCode.Text = ""
        '    CorporateYN = False

        'End If
    End Sub

    Private Sub Txt_CorporateCode_TextChanged(sender As Object, e As EventArgs) Handles Txt_CorporateCode.TextChanged

    End Sub

    Private Sub cmd_CorporateCodeHelp_Click(sender As Object, e As EventArgs) Handles cmd_CorporateCodeHelp.Click
        Dim vform As New LIST_OPERATION1
        gSQLString = "Select CMCorporateCode,CMCorporateName from CorporateMaster"
        M_WhereCondition = " "
        vform.Field = "CMCorporateCode,CMCorporateName"
        vform.vCaption = "Corporate Master Help"
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            Txt_CorporateCode.Text = Trim(vform.keyfield & "")
            Call txt_corporate_valid()
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub Txt_CorporateCode_Validated(sender As Object, e As EventArgs) Handles Txt_CorporateCode.Validated
        If Txt_CorporateCode.Text <> "" Then
            Call txt_corporate_valid()
        Else
            Txt_CorporateCode.Text = ""
            'Txt_CorporateCode.Focus()
        End If
    End Sub
    Private Sub txt_batch_valid()
        Dim SUBCATEGORY As New DataTable
        Dim ssql, SQL, SQL1 As String
        Dim I As Integer = 0
        Dim J As Integer = 0
        ssql = " Select isnull(Batchno,'') AS Batchno,isnull(Mcode,'') AS Mcode from membermaster where   batchno='" & Txt_batch.Text & "'"
        SUBCATEGORY = gconnection.GetValues(ssql)
        If SUBCATEGORY.Rows.Count > 0 Then
            Txt_batch.ReadOnly = False
            'CorporateYN = True
            Cbo_title.Focus()

        Else
            Txt_CorporateCode.ReadOnly = True
            MessageBox.Show("Can't Match Corporate Code and Category", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Txt_batch.Text = ""
            ' CorporateYN = False
            Txt_batch.ReadOnly = False
            Txt_batch.Focus()
        End If
    End Sub
    Private Sub txt_corporate_valid()
        Dim SUBCATEGORY As New DataTable
        Dim ssql, SQL, SQL1 As String
        Dim I As Integer = 0
        Dim J As Integer = 0
        ssql = " Select isnull(AddDateTime,'') AS ADDDATETIME,isnull(typecode,'')as typecode,isnull(subtypeCode,'')as subtypeCode,isnull(Subtypedesc,'')as Subtypedesc,Status,isnull(Validity,'')as Validity,Isnull(Permanent,'')as Permanent,isnull(votingright,'') as votingright,isnull(SubscriptionRequired,'') as SubscriptionRequired,isnull(Creditlimit,'') as Creditlimit,isnull(catlimit,0)as catlimit,isnull(barlimit,0) as barlimit,Freeze,isnull(ClubAccount,'')as ClubAccount,Isnull(Tenures,'')as Tenures,Isnull(Corporatemember,'')as Corporatemember From SubCategorymaster where Corporatemember='Y' and subtypedesc='" & Cmb_Category.Text & "'"
        SUBCATEGORY = gconnection.GetValues(ssql)
        If SUBCATEGORY.Rows.Count > 0 Then
            Txt_CorporateCode.ReadOnly = False
            CorporateYN = True
            Cbo_title.Focus()

        Else
            Txt_CorporateCode.ReadOnly = True
            MessageBox.Show("Can't Match Corporate Code and Category", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Txt_CorporateCode.Text = ""
            CorporateYN = False
            Txt_CorporateCode.ReadOnly = False
            Txt_CorporateCode.Focus()
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
        Me.Close()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            'Dim freezed As Integer
            Dim spouse As String
            Insert.Clear(Insert, 0, Insert.Length)
            Array.Clear(Insert, 0, Insert.Length)
            Dim i, j As Integer
            Dim PRONAME(0), SECNAME(0), MEMTYPE(0), CORPNAME(0)
            If btn_add.Text = "Add[F7]" Then
                If checkValidation1() = False Then Exit Sub
                Dim gender, MARITALSTATUS As String
                If chk_female.Checked = True Then
                    gender = "F"
                Else
                    gender = "M"
                End If
                If CorporateYN = True Then
                    If Corporate() = False Then Exit Sub

                End If
                If CHK_DOB.Checked = True Then
                    dob = Format(CDate(dtp_DOB.Text), "dd/MMM/yyyy")
                Else
                    dob = Format(CDate(dates), "dd/MMM/yyyy")
                End If

                If CHK_DOJ.Checked = True Then
                    doj = Format(CDate(dtp_DOJ.Text), "dd/MMM/yyyy")
                Else
                    doj = Format(CDate(dates), "dd/MMM/yyyy")
                End If

                If chk_EXPDT.Checked = True Then
                    expt = Format(CDate(dtp_EXPDT.Text), "dd/MMM/yyyy")
                Else
                    expt = Format(CDate(dates), "dd/MMM/yyyy")
                End If
                If CHK_WDT.Checked = True Then
                    dow = Format(CDate(dtp_DOW.Text), "dd/MMM/yyyy")
                Else
                    dow = Format(CDate(dates), "dd/MMM/yyyy")
                End If

                If ChK_SDOB.Checked = True Then
                    sdob = Format(CDate(Dtp_Spousedob.Text), "dd/MMM/yyyy")
                Else
                    sdob = Format(CDate(dates), "dd/MMM/yyyy")
                End If
                'if 
                '    chk_ContactAddress3.Checked = False
                'Else

                'If chk_Married.Checked = True Then
                '    MARITALSTATUS = "Y"
                'Else
                '    MARITALSTATUS = "N"
                'End If

                'sqlstring = "Exec  CAL_InsertMemCODE '" & _txt_FirstName.Text.Replace("'", "") & "','" & _txt_Surname.Text.Replace("'", "") & "'"
                'membertype = gconnection.ExcuteStoreProcedure(sqlstring)

                'sqlstring = "select MCODE from CAL_MEMCODE"
                'gconnection.getDataSet(sqlstring, "CAL_MEMCODE")
                'If gdataset.Tables("CAL_MEMCODE").Rows.Count > 0 Then
                '    txt_MemberCode.Text = CheckDBNull(gdataset.Tables("CAL_MEMCODE").Rows(0).Item("MCODE"))
                'End If

                sqlstring = "Exec  member_membertype "
                membertype = gconnection.ExcuteStoreProcedure(sqlstring)

                gconnection.getDataSet("SELECT subtypecode FROM Subcategorymaster WHERE ISNULL(FREEZE,'')<>'Y' and subTYPEDESC='" & Cmb_Category.Text & "'", "TypeMst")
                If gdataset.Tables("TypeMst").Rows.Count > 0 Then
                    txtCategory.Text = CheckDBNull(gdataset.Tables("TypeMst").Rows(0).Item("subtypecode"))
                End If
                Sqlstr = "Insert Into Membermaster(Batchno,MEMBERTYPECODE,Mcode,MName,FirstName,MiddleName,Surname,salut,Prefix,Sex,MARITALSTATUS,membertype,CurentStatus,P_charge,DOB,DOJ,wedding_date,Endingdate,SPOUSE,SDOB,ICNO,UnitNo,RankNo,DateOfCommission,DateOfRelease,DateOfCreation,MDescription,RIDCardNo,ArmService,WO,NoOfDependencies,RByMemberNo,RByName,RBYMEMBERNO2,RBYMEMBERNAME2,OADD1,OADD2,OADD3,OCITY,OSTATE,OCOUNTRY,OPIN,OPHONE1,OPHONE2,OCELL,OEMAIL,PADD1,PADD2,PADD3,PCITY,PSTATE,PCOUNTRY,PPIN,PPHONE1,PPHONE2,PCELL,PEMAIL,CADD1,CADD2,CADD3,CCITY,CSTATE,CCOUNTRY,CPIN,CPHONE1,CPHONE2,CCELL,CEMAIL,PROPOSER, PROPOSERNAME, SECONDER, SECONDERNAME,SECONDER1, SECONDERNAME1,ApplNo,ApplDate,PANO,BG,CriditNumber,MARITAL_STATUS,Billbasis,religion,Company,Designation,occupation,BuisnessInfo,ProfessionInfo,Products ,AgentsDealers ,Turnover ,NoOfEmp,spouseprefix,CATLIMIT,MEMLIMIT,REPLACEMENT,RNO,Corporatecode,ADD_DATE, ADD_USER,spl_info,spousemobile,passportno"
                Sqlstr = Sqlstr & " )VALUES ('" & _
                Trim(Txt_batch.Text.Replace("'", "")) & "','" & _
                Trim(txtCategory.Text.Replace("'", "")) & "','" & _
                Trim(txt_MemberCode.Text.Replace("'", "")) & "','" & _
                Trim(txt_FirstName.Text.Replace("'", "")) & " " & Trim(txt_MiddleName.Text.Replace("'", "")) & " " & Trim(txt_Surname.Text.Replace("'", "")) & "','" & _
                txt_FirstName.Text.Replace("'", "") & "','" & _
                txt_MiddleName.Text.Replace("'", "") & "','" & _
                txt_Surname.Text.Replace("'", "") & "','" & _
                Trim(Cbo_title.Text) & "','" & _
                Trim(TXT_TITLE.Text.Replace("'", "")) & "','" & gender & "','" & MARITALSTATUS & "','" & _
                Cmb_Category.Text.Replace("'", "") & "','" & _
                cbo_CurrentStatus.Text & "','" & _
                Com_post.Text & " ',Convert(datetime,'" & (dtp_DOB.Text) & "',103),Convert(datetime,'" & (dtp_DOJ.Text) & "',103),Convert(datetime,'" & (dow) & "',103),Convert(datetime,'" & (expt) & "',103),'" & _
                Trim(txt_Spouse.Text) & "',Convert(datetime,'" & (sdob) & "',103),'" & txtICNO.Text.Replace("'", "") & "','" & _
                cmbUnitNo.Text.Replace("'", "") & "','" & _
                cmbRankNo.Text & "',Convert(datetime,'" & dtpDFCommission.Text & "',103),Convert(datetime,'" & dtpDFRelease.Text & "',103),Convert(datetime,'" & dtpDFCreation.Text & "',103),'" & _
                Cbo_servives.Text.Replace("'", "") & "','" & _
                txtRIDCARDNO.Text.Replace("'", "") & "','" & _
                txtArmService.Text.Replace("'", "") & "','" & _
                txtWO.Text.Replace("'", "") & "','" & _
                txtNFDependencies.Text.Replace("'", "") & "','" & _
                txtRBYMEMBERNO.Text.Replace("'", "") & "','" & _
                txtNBYMEMBERNAME.Text.Replace("'", "") & "','" & _
                txtRBYMEMBERNO2.Text.Replace("'", "'") & "','" & _
                txtNBYMEMBERNAME2.Text.Replace("'", "'") & "','" & _
                Trim(txt_BA_Address1.Text.Replace("'", "")) & "','" & _
                Trim(txt_BA_Address2.Text.Replace("'", "")) & "','" & _
                Trim(txt_BA_Address3.Text.Replace("'", "")) & "','" & _
                Trim(Cbo_BCity.Text.Replace("'", "")) & "','" & _
                Trim(Cbo_BState.Text.Replace("'", "")) & "','" & _
                Trim(Cbo_BCountry.Text.Replace("'", "")) & "','" & _
                Trim(txt_BA_PinCode.Text.Replace("'", "")) & "','" & _
                Trim(txt_BA_PhoneNo.Text.Replace("'", "")) & "','" & _
                Trim(txt_BA_PhoneNo2.Text.Replace("'", "")) & "','" & _
                Trim(txt_BA_MobileNo.Text.Replace("'", "")) & "','" & _
                Trim(txt_BA_Email.Text.Replace("'", "")) & "','" & _
                Trim(txt_PA_Address1.Text.Replace("'", "")) & "','" & _
                Trim(txt_PA_Address2.Text.Replace("'", "")) & "','" & _
                Trim(txt_PA_Address3.Text.Replace("'", "")) & "','" & _
                Trim(Cbo_PCity.Text.Replace("'", "")) & "','" & _
                Trim(Cbo_PState.Text.Replace("'", "'")) & "','" & _
                Trim(Cbo_PCountry.Text.Replace("'", "'")) & "','" & _
                Trim(txt_PA_PinCode.Text.Replace("'", "")) & "','" & _
                Trim(txt_PA_Phone.Text.Replace("'", "")) & "','" & _
                Trim(txt_PA_Phone2.Text.Replace("'", "")) & "','" & _
                Trim(txt_PA_Mobile.Text.Replace("'", "")) & "','" & _
                Trim(txt_PA_Email.Text.Replace("'", "")) & "','" & _
                Trim(txt_RA_Address1.Text.Replace("'", "")) & "','" & Trim(txt_RA_Address2.Text.Replace("'", "")) & "','" & Trim(txt_RA_Address3.Text.Replace("'", "")) & "','" & _
                Trim(Cbo_CCity.Text.Replace("'", "")) & "','" & _
                Trim(Cbo_CState.Text.Replace("'", "")) & "','" & _
                Trim(Cbo_CCountry.Text.Replace("'", "")) & "','" & _
                Trim(txt_RA_PinCode.Text.Replace("'", "")) & "','" & Trim(txt_RA_PhoneNo.Text.Replace("'", "")) & "','" & Trim(txt_RA_PhoneNo2.Text.Replace("'", "")) & "','" & Trim(txt_RA_MobileNo.Text.Replace("'", "")) & "','" & Trim(txt_RA_Email.Text.Replace("'", "")) & "','" & _
                Trim(txt_ProposerCode.Text.Replace("'", "")) & "','" & Trim(txt_Proposername.Text.Replace("'", "")) & "','" & Trim(txt_SeconderCode1.Text.Replace("'", "")) & "','" & Trim(txt_SeconderName1.Text.Replace("'", "")) & "','" & Trim(txt_SeconderCode2.Text.Replace("'", "")) & "','" & Trim(txt_SeconderName2.Text.Replace("'", "")) & "','" & _
                Trim(Txt_APPLNO.Text) & "',Convert(datetime,'" & (dtp_ApplnDate.Text) & "',103),'" & Trim(Txt_pancarno.Text) & "', '" & _
                Trim(Txt_BloodGroup.Text) & "','" & _
                Trim(txt_CreditNumber.Text) & "','" & _
                Trim(Cbo_MaritalStatus.Text) & "','" & _
                  Trim(cbo_BillingBasis.Text) & "','" & _
                Trim(Cbo_relation.Text) & "','" & _
                Trim(Txt_companyName.Text) & "','" & _
                Trim(Cbo_designation.Text) & "','" & _
                Trim(txt_occupation.Text) & "','" & _
                Trim(Txt_Bussinessinfo.Text) & "','" & _
                Trim(Cbo_professional.Text) & "','" & _
                Trim(Txt_products.Text) & "','" & _
                Trim(Txt_AgenttInfo.Text) & "','" & _
                Val(Txt_turnover.Text) & "','" & _
                Val(Txt_noofEmpolyee.Text) & "','" & _
                Trim(Cbo_Spousesalutation.Text) & "'," & _
                Val(TXT_CATLIMIT.Text) & "," & _
                Val(TXT_MEMLIMIT.Text) & ",'" & _
                Trim(Txt_Replacement.Text) & "','" & _
                Trim(Txt_Rno.Text) & "','" & _
                Trim(Txt_CorporateCode.Text) & "','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "','" & gUsername & "','" & Trim(txt_spl_info.Text) & "','" & Trim(TXT_SPOUSEMOBILE.Text) & "' ,'" & Trim(txt_passportno.Text) & "' "
                Sqlstr = Sqlstr & ")"
                'gconnection.dataOperation(2, Sqlstr, "Membermaster")
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = Sqlstr
                '======Spouse Freeze
                If Chk_spouseFreeze.Checked = True Then
                    Sqlstr = " Update membermaster set SpouseFreeze='Y'"
                    'gconnection.dataOperation(2, Sqlstr, "membermaster")
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = Sqlstr
                Else
                    Sqlstr = " Update membermaster set SpouseFreeze='N'"
                    'gconnection.dataOperation(2, Sqlstr, "membermaster")
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = Sqlstr
                End If



                'DEPENTDENT DETAILS
                Sqlstr = " Delete From memdet Where Type0='CHLD' And mem_code='" & txt_MemberCode.Text.Replace("'", "") & "'"
                'gconnection.dataOperation(1, Sqlstr, "memdet")
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = Sqlstr
                For i = 1 To grd_depedent.DataRowCnt
                    With grd_depedent
                        Sqlstr = "Insert Into memdet(mem_code,type0,prefix,child_nm,SpouseName,child_dob,membertype,sex,relation,maritalstatus,dep_bloodgroup,studentmember,dep_Doj,Religion,anniversarydate,occupation,Panno,phone,mobile,emailid,type1,ADD_DATE, ADD_USER)"
                        'Sqlstr = "Insert Into memdet(mem_code,type0,prefix,child_nm,SpouseName,child_dob,membertype,sex,relation,maritalstatus,dep_bloodgroup,studentmember,dep_Doj,Religion,anniversarydate,occupation,Panno,phone,mobile,emailid,type1,ADD_DATE, ADD_USER)"
                        Sqlstr = Sqlstr & "  Values ('" & txt_MemberCode.Text.Replace("'", "") & "','CHLD'"
                        grd_depedent.Row = i
                        'prefix
                        grd_depedent.Col = 1
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'depName
                        grd_depedent.Col = 2
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'spousename
                        grd_depedent.Col = 6
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'dob
                        grd_depedent.Col = 3
                        If (.Text) <> "" Then
                            Sqlstr = Sqlstr & ",'" & Format(CDate(.Text), "yyyy/MM/dd") & "'"
                        Else
                            Sqlstr = Sqlstr & ",'1900/01/01'"
                        End If
                        'membertype
                        grd_depedent.Col = 16
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'gender
                        grd_depedent.Col = 4
                        If Mid(UCase(Trim(.Text)), 1, 1) = "F" Or Mid(UCase(Trim(.Text)), 1, 1) = "D" Then
                            Sqlstr = Sqlstr & ",'F'"
                        Else
                            Sqlstr = Sqlstr & ",'M'"
                        End If
                        'relation
                        grd_depedent.Col = 5
                        Sqlstr = Sqlstr & ",'" & Trim(.Text) & "'"
                        'marital
                        grd_depedent.Col = 7
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'BG
                        grd_depedent.Col = 13
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'sr.dep
                        grd_depedent.Col = 14
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'doj
                        grd_depedent.Col = 15
                        If (.Text) <> "" Then
                            Sqlstr = Sqlstr & ",'" & Format(CDate(.Text), "yyyy/MM/dd") & "'"
                        Else
                            Sqlstr = Sqlstr & ",'1900/01/01'"
                        End If
                        'Romancatholic
                        grd_depedent.Col = 17
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'anniversary date
                        grd_depedent.Col = 8
                        If (.Text) <> "" Then
                            Sqlstr = Sqlstr & ",'" & Format(CDate(.Text), "yyyy/MM/dd") & "'"
                        Else
                            Sqlstr = Sqlstr & ",'1900/01/01'"
                        End If
                        'occupation
                        grd_depedent.Col = 18
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'panno
                        grd_depedent.Col = 19
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'phone
                        grd_depedent.Col = 20
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'mob
                        grd_depedent.Col = 21
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'email
                        grd_depedent.Col = 22
                        Sqlstr = Sqlstr & ",'" & Trim(.Text) & "'"
                        'JunionSenior
                        grd_depedent.Col = 23
                        Sqlstr = Sqlstr & ",'" & .Text & "','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "','" & gUsername & "')"
                        ' gconnection.dataOperation(1, Sqlstr, "memdet")
                        ReDim Preserve Insert(Insert.Length)
                        Insert(Insert.Length - 1) = Sqlstr
                    End With
                Next i

                'UPDATE SPOUSE NAME INTO MEMBERMASTER
                'For i = 1 To ssgrid.DataRowCnt
                '    With ssgrid
                '        Sqlstr = "UPDATE membermaster SET SPOUSE = "
                '        .Row = i
                '        .Col = 6
                '        If (.Text) = "Spouse" Or (.Text) = "SPOUSE" Then
                '            .Row = i
                '            .Col = 1
                '            Sqlstr = Sqlstr & "'" & .Text & "' WHERE MCODE= '" & txt_MemberCode.Text.Replace("'", "") & "'"
                '        Else
                '            Sqlstr = Sqlstr & " ' ' WHERE MCODE= '" & txt_MemberCode.Text.Replace("'", "") & "' "
                '        End If
                '        gconnection.dataOperation(1, Sqlstr, "membermaster")
                '    End With
                'Next i


                'sports interested details
                'Sqlstr = " Delete From memdet Where Type0='SPRT' And mem_code='" & txt_MemberCode.Text.Replace("'", "") & "'"
                'gconnection.dataOperation(1, Sqlstr, "memdet")
                'For i = 1 To grd_Education.DataRowCnt
                '    With grd_Education
                '        Sqlstr = "INSERT INTO MEMDET(MEM_CODE,TYPE0,REMARKS,ADD_DATE, ADD_USER)"
                '        Sqlstr = Sqlstr & "  Values ('" & txt_MemberCode.Text.Replace("'", "") & "','QUAL'"
                '        .Row = i
                '        .Col = 1
                '        Sqlstr = Sqlstr & ",'" & .Text & "'"
                '        .Col = 2
                '        Sqlstr = Sqlstr & ",'" & .Text & "'"
                '        .Col = 3
                '        Sqlstr = Sqlstr & ",'" & .Text & "'"
                '        .Col = 4
                '        Sqlstr = Sqlstr & ",'" & .Text & "'"
                '        .Col = 5
                '        Sqlstr = Sqlstr & ",'" & .Text & "','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "','" & gUsername & "')"

                '        'gconnection.dataOperation(1, Sqlstr, "memdet")
                '        ReDim Preserve Insert(Insert.Length)
                '        Insert(Insert.Length - 1) = Sqlstr
                '    End With
                'Next i




                'Education DETAILS
                Sqlstr = " Delete From memdet Where Type0='QUAL' And mem_code='" & txt_MemberCode.Text.Replace("'", "") & "'"
                gconnection.dataOperation(1, Sqlstr, "memdet")
                For i = 1 To grd_Education.DataRowCnt
                    With grd_Education
                        Sqlstr = "INSERT INTO MEMDET(MEM_CODE,TYPE0,QUAL_DET,REMARKS,YEAR_PASS,INSTITUTE,DIVISION,ADD_DATE, ADD_USER)"
                        Sqlstr = Sqlstr & "  Values ('" & txt_MemberCode.Text.Replace("'", "") & "','QUAL'"
                        .Row = i
                        .Col = 1
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        .Col = 2
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        .Col = 3
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        .Col = 4
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        .Col = 5
                        Sqlstr = Sqlstr & ",'" & .Text & "','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "','" & gUsername & "')"

                        'gconnection.dataOperation(1, Sqlstr, "memdet")
                        ReDim Preserve Insert(Insert.Length)
                        Insert(Insert.Length - 1) = Sqlstr
                    End With
                Next i

                For i = 1 To grd_Education.DataRowCnt
                    With grd_Education
                        Sqlstr = "UPDATE membermaster SET Qualification" & i & "="
                        .Row = i
                        .Col = 1
                        Sqlstr = Sqlstr & "'" & .Text & "',"
                        .Col = 2
                        Sqlstr = Sqlstr & "Details" & i & "='" & .Text & "',"
                        .Col = 3
                        Sqlstr = Sqlstr & "YearOfPassing" & i & "='" & .Text & "',"
                        .Col = 4
                        Sqlstr = Sqlstr & "Institute" & i & "='" & .Text & "',"
                        .Col = 5
                        Sqlstr = Sqlstr & "Division" & i & "='" & .Text & "' WHERE MCODE= '" & txt_MemberCode.Text.Replace("'", "") & "'"
                        'gconnection.dataOperation(1, Sqlstr, "membermaster")
                        ReDim Preserve Insert(Insert.Length)
                        Insert(Insert.Length - 1) = Sqlstr
                    End With
                Next i
                Dim SQLSTR5 As String
                If chk_ContactAddress1.Checked = True Then
                    SQLSTR5 = "update membermaster set PACopyst1='Y',BACopyst1='N',RACopyst1='N' WHERE MCODE='" & txt_MemberCode.Text.Replace("'", "") & "'"
                ElseIf chk_ContactAddress2.Checked = True Then
                    SQLSTR5 = "update membermaster set PACopyst1='N',BACopyst1='Y',RACopyst1='N' WHERE MCODE='" & txt_MemberCode.Text.Replace("'", "") & "'"
                ElseIf chk_ContactAddress3.Checked = True Then
                    SQLSTR5 = "update membermaster set PACopyst1='N',BACopyst1='N',RACopyst1='Y' WHERE MCODE='" & txt_MemberCode.Text.Replace("'", "") & "'"
                Else
                    SQLSTR5 = "update membermaster set PACopyst1='N',BACopyst1='N',RACopyst1='N' WHERE MCODE='" & txt_MemberCode.Text.Replace("'", "") & "'"

                End If
                'gconnection.dataOperation(1, SQLSTR5, "membermaster")
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = Sqlstr
                'ENTERENCE FEE DETAILS
                Sqlstr = " Delete From memdet Where Type0='ENTR' And mem_code='" & txt_MemberCode.Text.Replace("'", "") & "'"
                gconnection.dataOperation(1, Sqlstr, "memdet")
                For i = 0 To grd_Entfee.DataRowCnt - 1
                    Sqlstr = "insert into memdet(MEM_CODE,type0,RCT_NO,START_DT,AMOUNT,ADD_DATE, ADD_USER)"
                    Sqlstr = Sqlstr & "  Values ('" & txt_MemberCode.Text.Replace("'", "") & "','ENTR',"
                    With grd_Entfee
                        .Row = i + 1
                        .Col = 1
                        Sqlstr = Sqlstr & "'" & Trim(.Text) & "',"
                        .Row = i + 1
                        .Col = 2
                        If Len(Trim(.Text)) > 7 Then
                            Sqlstr = Sqlstr & "'" & Format(CDate(.Text), "dd/MMM/yyyy") & "',"
                        Else
                            Sqlstr = Sqlstr & "'',"
                        End If

                        .Row = i + 1
                        .Col = 3
                        Sqlstr = Sqlstr & "'" & Trim(.Text) & "','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "','" & gUsername & "')"
                    End With
                    'gconnection.dataOperation(1, Sqlstr, "memdet")
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = Sqlstr
                Next i
                Dim SUB_ACCODE, SUB_ACDESC, SLTYPE As String
                'sqlstring = "SELECT ACCODE,ACDESC,SLTYPE FROM ACCOUNTSSDRS WHERE PREFIX='" & Trim(Mid(txt_MemberCode.Text, 1, 1)) & "'"
                sqlstring = "SELECT ACCODE,ACDESC,SLTYPE FROM ACCOUNTSSDRS WHERE ISNULL(SLTYPE,'')='MEMBER'"
                gconnection.getDataSet(sqlstring, "ACCOUNTSSDRS")
                If gdataset.Tables("ACCOUNTSSDRS").Rows.Count > 0 Then
                    SUB_ACCODE = ""
                    SUB_ACDESC = ""
                    SLTYPE = ""
                    For i = 0 To gdataset.Tables("ACCOUNTSSDRS").Rows.Count - 1
                        SUB_ACCODE = gdataset.Tables("ACCOUNTSSDRS").Rows(i).Item("ACCODE")
                        SUB_ACDESC = gdataset.Tables("ACCOUNTSSDRS").Rows(i).Item("ACDESC")
                        SLTYPE = gdataset.Tables("ACCOUNTSSDRS").Rows(i).Item("SLTYPE")

                        'Next
                        'End If
                        ' If Trim(Mid(txt_MemberCode.Text, 1, 1)) = "B" Then
                        Sqlstr = " Insert Into Accountssubledgermaster(accode,acdesc,sltype,slcode,slname,sldesc,address1,address2,address3,city,state,pin,phoneno,cellno,contactperson,ADD_DATE, ADD_USER) "
                        Sqlstr = Sqlstr & " values('" & SUB_ACCODE & "','" & SUB_ACDESC & "','" & SLTYPE & "','" & txt_MemberCode.Text & "','" & Trim(txt_FirstName.Text.Replace("'", "")) & " " & Trim(txt_MiddleName.Text.Replace("'", "")) & " " & Trim(txt_Surname.Text.Replace("'", "")) & "',"
                        Sqlstr = Sqlstr & "'" & Trim(txt_FirstName.Text) & " " & Trim(txt_MiddleName.Text) & " " & Trim(txt_Surname.Text) & "',"
                        ' Sqlstr = Sqlstr & "'" & Trim(txt_FirstName.Text) & " " & Trim(txt_MiddleName.Text) & " " & Trim(txt_Surname.Text) & "',"
                        If chk_ContactAddress1.Checked = True Then
                            Sqlstr = Sqlstr & "'" & Trim(txt_PA_Address1.Text.Replace("'", "")) & "',"
                            Sqlstr = Sqlstr & "'" & Trim(txt_PA_Address2.Text.Replace("'", "")) & "',"
                            Sqlstr = Sqlstr & "'" & Trim(txt_PA_Address3.Text.Replace("'", "")) & "',"
                            Sqlstr = Sqlstr & "'" & Trim(txt_PA_City.Text.Replace("'", "")) & "',"
                            Sqlstr = Sqlstr & "'" & Trim(txt_PA_State.Text.Replace("'", "")) & "',"
                            Sqlstr = Sqlstr & "'" & Trim(txt_PA_PinCode.Text.Replace("'", "")) & "',"
                            Sqlstr = Sqlstr & "'" & Trim(txt_PA_Phone.Text.Replace("'", "")) & "',"
                            Sqlstr = Sqlstr & "'" & Trim(txt_PA_Mobile.Text.Replace("'", "")) & "',"
                        ElseIf chk_ContactAddress2.Checked = True Then
                            Sqlstr = Sqlstr & "'" & Trim(txt_RA_Address1.Text.Replace("'", "")) & "',"
                            Sqlstr = Sqlstr & "'" & Trim(txt_RA_Address2.Text.Replace("'", "")) & "',"
                            Sqlstr = Sqlstr & "'" & Trim(txt_RA_Address3.Text.Replace("'", "")) & "',"
                            Sqlstr = Sqlstr & "'" & Trim(txt_RA_City.Text.Replace("'", "")) & "',"
                            Sqlstr = Sqlstr & "'" & Trim(txt_RA_State.Text.Replace("'", "")) & "',"
                            Sqlstr = Sqlstr & "'" & Trim(txt_RA_PinCode.Text.Replace("'", "")) & "',"
                            Sqlstr = Sqlstr & "'" & Trim(txt_RA_PhoneNo.Text.Replace("'", "")) & "',"
                            Sqlstr = Sqlstr & "'" & Trim(txt_RA_MobileNo.Text.Replace("'", "")) & "',"
                        ElseIf chk_ContactAddress3.Checked = True Then
                            Sqlstr = Sqlstr & "'" & Trim(txt_BA_Address1.Text.Replace("'", "")) & "',"
                            Sqlstr = Sqlstr & "'" & Trim(txt_BA_Address2.Text.Replace("'", "")) & "',"
                            Sqlstr = Sqlstr & "'" & Trim(txt_BA_Address3.Text.Replace("'", "")) & "',"
                            Sqlstr = Sqlstr & "'" & Trim(txt_BA_City.Text.Replace("'", "")) & "',"
                            Sqlstr = Sqlstr & "'" & Trim(txt_BA_State.Text.Replace("'", "")) & "',"
                            Sqlstr = Sqlstr & "'" & Trim(txt_BA_PinCode.Text.Replace("'", "")) & "',"
                            Sqlstr = Sqlstr & "'" & Trim(txt_BA_PhoneNo.Text.Replace("'", "")) & "',"
                            Sqlstr = Sqlstr & "'" & Trim(txt_BA_MobileNo.Text.Replace("'", "")) & "',"
                        Else
                            Sqlstr = Sqlstr & "'" & Trim(txt_PA_Address1.Text.Replace("'", "")) & "',"
                            Sqlstr = Sqlstr & "'" & Trim(txt_PA_Address2.Text.Replace("'", "")) & "',"
                            Sqlstr = Sqlstr & "'" & Trim(txt_PA_Address3.Text.Replace("'", "")) & "',"
                            Sqlstr = Sqlstr & "'" & Trim(txt_PA_City.Text.Replace("'", "")) & "',"
                            Sqlstr = Sqlstr & "'" & Trim(txt_PA_State.Text.Replace("'", "")) & "',"
                            Sqlstr = Sqlstr & "'" & Trim(txt_PA_PinCode.Text.Replace("'", "")) & "',"
                            Sqlstr = Sqlstr & "'" & Trim(txt_PA_Phone.Text.Replace("'", "")) & "',"
                            Sqlstr = Sqlstr & "'" & Trim(txt_PA_Mobile.Text.Replace("'", "")) & "',"
                        End If
                        Sqlstr = Sqlstr & "'" & Trim(txt_FirstName.Text) & " " & Trim(txt_MiddleName.Text) & " " & Trim(txt_Surname.Text) & "','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "','" & gUsername & "')"
                        ' gconnection.dataOperation(1, Sqlstr, "Accountssubledgermaster")
                        ReDim Preserve Insert(Insert.Length)
                        Insert(Insert.Length - 1) = Sqlstr
                    Next i

                End If

                Sqlstr = "Update membermaster Set"
                If chk_ContactAddress1.Checked = True Then

                    Sqlstr = Sqlstr & " CONTADD1='" & Trim(txt_PA_Address1.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTADD2='" & Trim(txt_PA_Address2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTADD3='" & Trim(txt_PA_Address3.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTCITY='" & Trim(txt_PA_City.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTSTATE='" & Trim(txt_PA_State.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTPIN='" & Trim(txt_PA_PinCode.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTPHONE1='" & Trim(txt_PA_Phone.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTPHONE2='" & Trim(txt_PA_Phone2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTCELL='" & Trim(txt_PA_Mobile.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTEMAIL='" & Trim(txt_PA_Email.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "  PAcopyst1 ='Y',"
                    Sqlstr = Sqlstr & "  BAcopyst1 ='N',"
                    Sqlstr = Sqlstr & "  RAcopyst1 ='N'"
                ElseIf chk_ContactAddress2.Checked = True Then
                    Sqlstr = Sqlstr & " CONTADD1='" & Trim(txt_BA_Address1.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTADD2='" & Trim(txt_BA_Address2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTADD3='" & Trim(txt_BA_Address3.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTCITY='" & Trim(txt_BA_City.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTSTATE='" & Trim(txt_BA_State.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTPIN='" & Trim(txt_BA_PinCode.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTPHONE1='" & Trim(txt_BA_PhoneNo.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTPHONE2='" & Trim(txt_BA_PhoneNo2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTCELL='" & Trim(txt_BA_MobileNo.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTEMAIL='" & Trim(txt_BA_Email.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "  PAcopyst1 ='N',"
                    Sqlstr = Sqlstr & "  BAcopyst1 ='Y',"
                    Sqlstr = Sqlstr & "  RAcopyst1 ='N'"
                ElseIf chk_ContactAddress3.Checked = True Then
                    Sqlstr = Sqlstr & " CONTADD1='" & Trim(txt_RA_Address1.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTADD2='" & Trim(txt_RA_Address2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTADD3='" & Trim(txt_RA_Address3.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTCITY='" & Trim(txt_RA_City.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTSTATE='" & Trim(txt_RA_State.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTPIN='" & Trim(txt_RA_PinCode.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTPHONE1='" & Trim(txt_RA_PhoneNo.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTPHONE2='" & Trim(txt_RA_PhoneNo2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTCELL='" & Trim(txt_RA_MobileNo.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTEMAIL='" & Trim(txt_RA_Email.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "  PAcopyst1 ='N',"
                    Sqlstr = Sqlstr & "  BAcopyst1 ='N',"
                    Sqlstr = Sqlstr & "  RAcopyst1 ='Y'"


                End If
                Sqlstr = Sqlstr & " Where Mcode='" & Trim(txt_MemberCode.Text.Replace("'", "")) & "'"
                'gconnection.dataOperation(1, Sqlstr, "MEMBERMSORDERNO")
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = Sqlstr

                If Chk_MinYN.Checked = True Then
                    Sqlstr = " Update membermaster set MINYN='Y' WHERE MCODE='" & txt_MemberCode.Text.Replace("'", "") & "'"
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = Sqlstr
                Else
                    Sqlstr = " Update membermaster set MINYN='N' WHERE MCODE='" & txt_MemberCode.Text.Replace("'", "") & "'"
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = Sqlstr
                End If

                gconnection.MoreTrans(Insert)
                Loadimage()
                'MessageBox.Show("Record Saved Successfully ", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                If checkValidation() = False Then Exit Sub
                If CorporateYN = True Then
                    If Corporate() = False Then Exit Sub

                End If

                Sqlstr = " Update Accountssubledgermaster Set "
                Sqlstr = Sqlstr & " slname='" & Trim(txt_FirstName.Text.Replace("'", "")) & " " & Trim(txt_MiddleName.Text.Replace("'", "")) & " " & Trim(txt_Surname.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " sldesc='" & Trim(txt_FirstName.Text.Replace("'", "")) & " " & Trim(txt_MiddleName.Text.Replace("'", "")) & " " & Trim(txt_Surname.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " contactperson='" & Trim(txt_FirstName.Text.Replace("'", "")) & " " & Trim(txt_MiddleName.Text.Replace("'", "")) & " " & Trim(txt_Surname.Text.Replace("'", "")) & "',"
                If chk_ContactAddress1.Checked = True Then
                    Sqlstr = Sqlstr & " address1='" & Trim(txt_PA_Address1.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " address2='" & Trim(txt_PA_Address2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " address3='" & Trim(txt_PA_Address3.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " city='" & Trim(txt_PA_City.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " state='" & Trim(txt_PA_State.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " pin='" & Trim(txt_PA_PinCode.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " phoneno='" & Trim(txt_PA_Phone.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " cellno='" & Trim(txt_PA_Mobile.Text.Replace("'", "")) & "',"
                ElseIf chk_ContactAddress2.Checked = True Then
                    Sqlstr = Sqlstr & " address1='" & Trim(txt_RA_Address1.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " address2='" & Trim(txt_RA_Address2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " address3='" & Trim(txt_RA_Address3.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " city='" & Trim(txt_RA_City.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " state='" & Trim(txt_RA_State.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " pin='" & Trim(txt_RA_PinCode.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " phoneno='" & Trim(txt_RA_PhoneNo.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " cellno='" & Trim(txt_RA_MobileNo.Text.Replace("'", "")) & "',"
                ElseIf chk_ContactAddress3.Checked = True Then
                    Sqlstr = Sqlstr & " address1='" & Trim(txt_BA_Address1.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " address2='" & Trim(txt_BA_Address1.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " address3='" & Trim(txt_BA_Address1.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " city='" & Trim(txt_BA_City.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " state='" & Trim(txt_BA_State.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " pin='" & Trim(txt_BA_PinCode.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " phoneno='" & Trim(txt_BA_PhoneNo.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " cellno='" & Trim(txt_BA_MobileNo.Text.Replace("'", "")) & "',"
                Else
                    Sqlstr = Sqlstr & " address1='" & Trim(txt_PA_Address1.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " address2='" & Trim(txt_PA_Address2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " address3='" & Trim(txt_PA_Address3.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " city='" & Trim(txt_PA_City.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " state='" & Trim(txt_PA_State.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " pin='" & Trim(txt_PA_PinCode.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " phoneno='" & Trim(txt_PA_Phone.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " cellno='" & Trim(txt_PA_Mobile.Text.Replace("'", "")) & "',"
                End If
                Sqlstr = Sqlstr & "UPD_DATE ='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "',"
                Sqlstr = Sqlstr & "UPD_USER  ='" & gUsername & "'"
                Sqlstr = Sqlstr & " Where Slcode='" & Trim(txt_MemberCode.Text.Replace("'", "")) & "'"
                gconnection.dataOperation(1, Sqlstr, "Accountssubledgermaster")

                sqlstring = "Exec  member_membertype"
                membertype = gconnection.ExcuteStoreProcedure(sqlstring)

                If CHK_DOB.Checked = True Then
                    dob = Format(CDate(dtp_DOB.Text), "dd/MMM/yyyy")
                Else
                    dob = Format(CDate(dates), "dd/MMM/yyyy")
                End If

                If CHK_DOJ.Checked = True Then
                    doj = Format(CDate(dtp_DOJ.Text), "dd/MMM/yyyy")
                Else
                    doj = Format(CDate(dates), "dd/MMM/yyyy")
                End If

                If chk_EXPDT.Checked = True Then
                    expt = Format(CDate(dtp_EXPDT.Text), "dd/MMM/yyyy")
                Else
                    expt = Format(CDate(dates), "dd/MMM/yyyy")
                End If

                If ChK_SDOB.Checked = True Then
                    sdob = Format(CDate(Dtp_Spousedob.Text), "dd/MMM/yyyy")
                Else
                    sdob = Format(CDate(dates), "dd/MMM/yyyy")
                End If

                If CHK_WDT.Checked = True Then
                    dow = Format(CDate(dtp_DOW.Text), "dd/MMM/yyyy")
                Else
                    dow = Format(CDate(dates), "dd/MMM/yyyy")
                End If
                Sqlstr = " Update Membermaster Set "
                Sqlstr = Sqlstr & " P_charge='" & Trim(Com_post.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " Batchno='" & Trim(Txt_batch.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " salut='" & Trim(Cbo_title.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " Prefix='" & Trim(TXT_TITLE.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " FirstName='" & Trim(txt_FirstName.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " MiddleName='" & Trim(txt_MiddleName.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " Surname='" & Trim(txt_Surname.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " Mname='" & Trim(txt_FirstName.Text.Replace("'", "")) & " " & Trim(txt_MiddleName.Text.Replace("'", "")) & " " & Trim(txt_Surname.Text.Replace("'", "")) & "',"

                Dim index As Integer
                gconnection.getDataSet("SELECT MEMBERTYPE FROM MEMBERTYPE WHERE ISNULL(FREEZE,'')<>'Y' and TYPEDESC='" & Cmb_Category.Text & "'", "TypeMst")
                Sqlstr = Sqlstr & " MEMBERTYPE ='" & Cmb_Category.Text.Replace("'", "") & "',"
                Sqlstr = Sqlstr & " Billbasis='" & Trim(cbo_BillingBasis.Text) & "',"
                If cbo_CurrentStatus.Text = "ACTIVE" Then
                    Sqlstr = Sqlstr & " CurentStatus='ACTIVE',"
                Else
                    Sqlstr = Sqlstr & " CurentStatus='" & cbo_CurrentStatus.Text & "',"
                End If

                Sqlstr = Sqlstr & " DOB=Convert(datetime,'" & (dob) & "',103),"
                Sqlstr = Sqlstr & " DOJ=Convert(datetime,'" & (doj) & "',103),"
                Sqlstr = Sqlstr & " Endingdate=Convert(datetime,'" & (expt) & "',103),"
                If chk_female.Checked = True Then
                    Sqlstr = Sqlstr & " SEX ='F',"
                Else
                    Sqlstr = Sqlstr & " SEX ='M',"
                End If
                Sqlstr = Sqlstr & " spouseprefix='" & Trim(Cbo_Spousesalutation.Text) & "',"
                Sqlstr = Sqlstr & " SPOUSE='" & Trim(txt_Spouse.Text) & "',"
                Sqlstr = Sqlstr & " spousemobile = '" & Trim(TXT_SPOUSEMOBILE.Text) & "',"
                Sqlstr = Sqlstr & "  UPD_USER ='" & gUsername & "',"
                Sqlstr = Sqlstr & "  UPD_DATE  =getdate(),"
                Sqlstr = Sqlstr & "  freeze ='N',"
                Sqlstr = Sqlstr & " spl_info='" & Trim(txt_spl_info.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " SDOB= Convert(datetime,'" & (sdob) & "',103),"
                Sqlstr = Sqlstr & " wedding_date= Convert(datetime,'" & (dow) & "',103),"
                Sqlstr = Sqlstr & " PADD1='" & Trim(txt_PA_Address1.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " PADD2='" & Trim(txt_PA_Address2.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " PADD3='" & Trim(txt_PA_Address3.Text.Replace("'", "")) & "',"

                Sqlstr = Sqlstr & " PCITY='" & Trim(Cbo_PCity.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " PSTATE='" & Trim(Cbo_PState.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " PCOUNTRY='" & Trim(Cbo_PCountry.Text.Replace("'", "")) & "',"

                Sqlstr = Sqlstr & " PPIN='" & Trim(txt_PA_PinCode.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " PPHONE1='" & Trim(txt_PA_Phone.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " PPHONE2='" & Trim(txt_PA_Phone2.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " PCELL='" & Trim(txt_PA_Mobile.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " PEMAIL='" & Trim(txt_PA_Email.Text.Replace("'", "")) & "',"

                If chk_ContactAddress1.Checked = True Then

                    Sqlstr = Sqlstr & " CONTADD1='" & Trim(txt_PA_Address1.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTADD2='" & Trim(txt_PA_Address2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTADD3='" & Trim(txt_PA_Address3.Text.Replace("'", "")) & "',"

                    Sqlstr = Sqlstr & " CONTCITY='" & Trim(Cbo_PCity.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTSTATE='" & Trim(Cbo_PState.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTCOUNTRY='" & Trim(Cbo_PCountry.Text.Replace("'", "")) & "',"

                    Sqlstr = Sqlstr & " CONTPIN='" & Trim(txt_PA_PinCode.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTPHONE1='" & Trim(txt_PA_Phone.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTPHONE2='" & Trim(txt_PA_Phone2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTCELL='" & Trim(txt_PA_Mobile.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTEMAIL='" & Trim(txt_PA_Email.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "  PAcopyst1 ='Y',"
                    Sqlstr = Sqlstr & "  BAcopyst1 ='N',"
                    Sqlstr = Sqlstr & "  RAcopyst1 ='N',"
                ElseIf chk_ContactAddress2.Checked = True Then
                    Sqlstr = Sqlstr & " CONTADD1='" & Trim(txt_BA_Address1.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTADD2='" & Trim(txt_BA_Address2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTADD3='" & Trim(txt_BA_Address3.Text.Replace("'", "")) & "',"

                    Sqlstr = Sqlstr & " CONTCITY='" & Trim(Cbo_BCity.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTSTATE='" & Trim(Cbo_BState.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTCOUNTRY='" & Trim(Cbo_BCountry.Text.Replace("'", "")) & "',"

                    Sqlstr = Sqlstr & " CONTPIN='" & Trim(txt_BA_PinCode.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTPHONE1='" & Trim(txt_BA_PhoneNo.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTPHONE2='" & Trim(txt_BA_PhoneNo2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTCELL='" & Trim(txt_BA_MobileNo.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTEMAIL='" & Trim(txt_BA_Email.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "  PAcopyst1 ='N',"
                    Sqlstr = Sqlstr & "  BAcopyst1 ='Y',"
                    Sqlstr = Sqlstr & "  RAcopyst1 ='N',"
                ElseIf chk_ContactAddress3.Checked = True Then
                    Sqlstr = Sqlstr & " CONTADD1='" & Trim(txt_RA_Address1.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTADD2='" & Trim(txt_RA_Address2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTADD3='" & Trim(txt_RA_Address3.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTCITY='" & Trim(Cbo_CCity.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTSTATE='" & Trim(Cbo_CState.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTCOUNTRY='" & Trim(Cbo_CCountry.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTPIN='" & Trim(txt_RA_PinCode.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTPHONE1='" & Trim(txt_RA_PhoneNo.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTPHONE2='" & Trim(txt_RA_PhoneNo2.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTCELL='" & Trim(txt_RA_MobileNo.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & " CONTEMAIL='" & Trim(txt_RA_Email.Text.Replace("'", "")) & "',"
                    Sqlstr = Sqlstr & "  PAcopyst1 ='N',"
                    Sqlstr = Sqlstr & "  BAcopyst1 ='N',"
                    Sqlstr = Sqlstr & "  RAcopyst1 ='Y',"
                End If

                Sqlstr = Sqlstr & " CADD1='" & Trim(txt_RA_Address1.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " CADD2='" & Trim(txt_RA_Address2.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " CADD3='" & Trim(txt_RA_Address3.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " CCITY='" & Trim(Cbo_CCity.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " CSTATE='" & Trim(Cbo_CState.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " CCOUNTRY='" & Trim(Cbo_CCountry.Text.Replace("'", "")) & "',"

                Sqlstr = Sqlstr & " CPIN='" & Trim(txt_RA_PinCode.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " CPHONE1='" & Trim(txt_RA_PhoneNo.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " CPHONE2='" & Trim(txt_RA_PhoneNo2.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " CCELL='" & Trim(txt_RA_MobileNo.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " CEMAIL='" & Trim(txt_RA_Email.Text.Replace("'", "")) & "',"

                Sqlstr = Sqlstr & " OADD1='" & Trim(txt_BA_Address1.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " OADD2='" & Trim(txt_BA_Address2.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " OADD3='" & Trim(txt_BA_Address3.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " OCITY='" & Trim(Cbo_BCity.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " OSTATE='" & Trim(Cbo_BState.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " OCOUNTRY='" & Trim(Cbo_BCountry.Text.Replace("'", "")) & "',"

                Sqlstr = Sqlstr & " OPIN='" & Trim(txt_BA_PinCode.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " OPHONE1='" & Trim(txt_BA_PhoneNo.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " OPHONE2='" & Trim(txt_BA_PhoneNo2.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " OCELL='" & Trim(txt_BA_MobileNo.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " OEMAIL='" & Trim(txt_BA_Email.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " MARITAL_STATUS='" & Trim(Cbo_MaritalStatus.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " religion='" & Trim(Cbo_relation.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " Designation='" & Trim(Cbo_designation.Text.Replace("'", "")) & "',"
                Sqlstr = Sqlstr & " BG = '" & Trim(Txt_BloodGroup.Text) & "',"
                Sqlstr = Sqlstr & " COMPANY = '" & Trim(Txt_companyName.Text) & "',"
                Sqlstr = Sqlstr & " occupation = '" & Trim(txt_occupation.Text) & "',"
                Sqlstr = Sqlstr & " BuisnessInfo = '" & Trim(Txt_Bussinessinfo.Text) & "',"
                'Sqlstr = Sqlstr & " ProfessionInfo = '" & Trim(Txt_Professionalinfo.Text) & "',"
                Sqlstr = Sqlstr & " ProfessionInfo = '" & Trim(Cbo_professional.Text) & "',"
                Sqlstr = Sqlstr & " Products = '" & Trim(Txt_products.Text) & "',"
                Sqlstr = Sqlstr & " AgentsDealers = '" & Trim(Txt_AgenttInfo.Text) & "',"
                Sqlstr = Sqlstr & " Turnover = '" & Val(Txt_turnover.Text) & "',"
                Sqlstr = Sqlstr & " NoOfEmp = '" & Val(Txt_noofEmpolyee.Text) & "',"
                'Sqlstr = Sqlstr & " oldmcode = '" & Val(Txt_oldmembership.Text) & "',"
                Sqlstr = Sqlstr & " MEMLIMIT = '" & Val(TXT_MEMLIMIT.Text) & "',"
                Sqlstr = Sqlstr & " CATLIMIT = '" & Val(TXT_CATLIMIT.Text) & "',"
                Sqlstr = Sqlstr & "SECONDER1 = '" & Trim(txt_SeconderCode2.Text) & "',"
                Sqlstr = Sqlstr & "SECONDERNAME1 = '" & Trim(txt_SeconderName2.Text) & "',"
                Sqlstr = Sqlstr & "criditnumber = '" & Trim(txt_CreditNumber.Text) & "',"
                Sqlstr = Sqlstr & " Corporatecode = '" & Trim(Txt_CorporateCode.Text) & "',"
                Sqlstr = Sqlstr & " passportno = '" & Trim(txt_passportno.Text) & "'"
                Sqlstr = Sqlstr & " Where Mcode='" & Trim(txt_MemberCode.Text.Replace("'", "")) & "'"
                gconnection.dataOperation(2, Sqlstr, "Membermaster")
                '======Spouse Freeze
                If Chk_spouseFreeze.Checked = True Then
                    Sqlstr = " Update membermaster set SpouseFreeze='Y'"
                    gconnection.dataOperation(2, Sqlstr, "membermaster")
                Else
                    Sqlstr = " Update membermaster set SpouseFreeze='N'"
                    gconnection.dataOperation(2, Sqlstr, "membermaster")
                End If
                'MIN DETAILS
                If Chk_MinYN.Checked = True Then
                    Sqlstr = " Update membermaster set MINYN='Y' WHERE MCODE='" & txt_MemberCode.Text.Replace("'", "") & "'"
                    gconnection.dataOperation(2, Sqlstr, "MinTag")
                Else
                    Sqlstr = " Update membermaster set MINYN='N' WHERE MCODE='" & txt_MemberCode.Text.Replace("'", "") & "'"
                    gconnection.dataOperation(2, Sqlstr, "MinTag")
                End If

                'ECS DETAILS
                If ChK_ECSYN.Checked = True Then
                    Grp_ECSSETUP.Visible = True
                    'Sqlstr = " Update membermaster set ECSYN='Y', DRCR='" & Txt_DRCR.Text & "' ,MEMBERMICR='" & Txt_MemMICR.Text & "' ,OURUSERID='" & Txt_OurUID.Text & "' ,ECS_MEMACCOUNTTYPE='" & Txt_MemAcType.Text & "' ,ECS_MEMBANKACCOUNTNO='" & Txt_MemBankAccNo.Text & "' ,ECS_AMOUNT='" & Txt_Amount.Text & "',ECS_SBCD='" & Cmb_MemAcType.Text & "'     WHERE MCODE='" & txt_MemberCode.Text.Replace("'", "") & "'"
                    Sqlstr = " Update membermaster set ECSYN='Y', DRCR='" & Txt_DRCR.Text & "' ,MEMBERMICR='" & Txt_MemMICR.Text & "' ,OURUSERID='" & Txt_OurUID.Text & "' ,ECS_MEMACCOUNTTYPE='" & Txt_MemAcType.Text & "' ,ECS_MEMBANKACCOUNTNO='" & Txt_MemBankAccNo.Text & "',ECS_SBCD='" & Cmb_MemAcType.Text & "'     WHERE MCODE='" & txt_MemberCode.Text.Replace("'", "") & "'"
                    gconnection.dataOperation(2, Sqlstr, "MinTag")
                Else
                    Sqlstr = " Update membermaster set ECSYN='N' WHERE MCODE='" & txt_MemberCode.Text.Replace("'", "") & "'"
                    gconnection.dataOperation(2, Sqlstr, "MinTag")
                End If

                'DIR DETAILS
                If rdo_dir.Checked = True Then
                    Sqlstr = " Update membermaster set CHKDIR='Y' WHERE MCODE='" & txt_MemberCode.Text.Replace("'", "") & "'"
                    gconnection.dataOperation(2, Sqlstr, "MinTag")
                Else
                    Sqlstr = " Update membermaster set CHKDIR='N' WHERE MCODE='" & txt_MemberCode.Text.Replace("'", "") & "'"
                    gconnection.dataOperation(2, Sqlstr, "MinTag")
                End If


                'ENTERENCE FEE DETAILS
                Sqlstr = " Delete From memdet Where Type0='ENTR' And mem_code='" & txt_MemberCode.Text.Replace("'", "") & "'"
                gconnection.dataOperation(1, Sqlstr, "memdet")

                For i = 0 To grd_Entfee.DataRowCnt - 1
                    Sqlstr = "insert into memdet(MEM_CODE,type0,RCT_NO,START_DT,AMOUNT,ADD_DATE, ADD_USER)"
                    Sqlstr = Sqlstr & "  Values ('" & txt_MemberCode.Text.Replace("'", "") & "','ENTR',"
                    With grd_Entfee
                        .Row = i + 1
                        .Col = 1
                        Sqlstr = Sqlstr & "'" & Trim(.Text) & "',"
                        .Row = i + 1
                        .Col = 2
                        If Len(Trim(.Text)) > 7 Then
                            Sqlstr = Sqlstr & "'" & Format(CDate(.Text), "dd/MMM/yyyy") & "',"
                        Else
                            Sqlstr = Sqlstr & "'',"
                        End If

                        .Row = i + 1
                        .Col = 3
                        Sqlstr = Sqlstr & "'" & Trim(.Text) & "','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "','" & gUsername & "')"
                    End With
                    gconnection.dataOperation(1, Sqlstr, "memdet")
                Next i


                'DEPENTDENT DETAILS
                Sqlstr = " Delete From memdet Where Type0='CHLD' And mem_code='" & txt_MemberCode.Text.Replace("'", "") & "'"
                gconnection.dataOperation(1, Sqlstr, "memdet")
                For i = 1 To grd_depedent.DataRowCnt
                    With grd_depedent
                        Sqlstr = "Insert Into memdet(mem_code,type0,prefix,child_nm,SpouseName,child_dob,membertype,sex,relation,maritalstatus,dep_bloodgroup,studentmember,dep_Doj,Religion,anniversarydate,occupation,Panno,phone,mobile,emailid,type1,ADD_DATE, ADD_USER)"
                        Sqlstr = Sqlstr & "  Values ('" & txt_MemberCode.Text.Replace("'", "") & "','CHLD'"
                        grd_depedent.Row = i
                        'prefix
                        grd_depedent.Col = 1
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'depName
                        grd_depedent.Col = 2
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'spousename
                        grd_depedent.Col = 6
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'dob
                        grd_depedent.Col = 3
                        If (.Text) <> "" Then
                            Sqlstr = Sqlstr & ",'" & Format(CDate(.Text), "yyyy/MM/dd") & "'"
                        Else
                            Sqlstr = Sqlstr & ",'1900/01/01'"
                        End If
                        'membertype
                        grd_depedent.Col = 16
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'gender
                        grd_depedent.Col = 4
                        If Mid(UCase(Trim(.Text)), 1, 1) = "F" Or Mid(UCase(Trim(.Text)), 1, 1) = "D" Then
                            Sqlstr = Sqlstr & ",'F'"
                        Else
                            Sqlstr = Sqlstr & ",'M'"
                        End If
                        'relation
                        grd_depedent.Col = 5
                        Sqlstr = Sqlstr & ",'" & Trim(.Text) & "'"
                        'marital
                        grd_depedent.Col = 7
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'BG
                        grd_depedent.Col = 13
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'sr.dep
                        grd_depedent.Col = 14
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'doj
                        grd_depedent.Col = 15
                        If (.Text) <> "" Then
                            Sqlstr = Sqlstr & ",'" & Format(CDate(.Text), "yyyy/MM/dd") & "'"
                        Else
                            Sqlstr = Sqlstr & ",'1900/01/01'"
                        End If
                        'Romancatholic
                        grd_depedent.Col = 16
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'anniversary date
                        grd_depedent.Col = 8
                        If (.Text) <> "" Then
                            Sqlstr = Sqlstr & ",'" & Format(CDate(.Text), "yyyy/MM/dd") & "'"
                        Else
                            Sqlstr = Sqlstr & ",'1900/01/01'"
                        End If
                        'occupation
                        grd_depedent.Col = 18
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'panno
                        grd_depedent.Col = 19
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'phone
                        grd_depedent.Col = 20
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'mob
                        grd_depedent.Col = 21
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        'email
                        grd_depedent.Col = 22
                        Sqlstr = Sqlstr & ",'" & Trim(.Text) & "'"
                        ' Junior Senior
                        grd_depedent.Col = 23
                        Sqlstr = Sqlstr & ",'" & .Text & "','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "','" & gUsername & "')"
                        gconnection.dataOperation(1, Sqlstr, "memdet")

                    End With
                Next i

                'Freeze Dependents
                Dim mcount As Long
                With grd_depedent
                    For i = 0 To grd_depedent.DataRowCnt - 1
                        .Row = i + 1
                        .Col = 23
                        If Val(.Text) > 0 Then
                            mcount = mcount + 1
                            .Row = i + 1
                            .Col = 1
                            Sqlstr = "Update memdet set freeze='Y',remarks='Freezed'where Type0='CHLD' And child_nm=('" & Trim(.Text) & "')"
                            gconnection.dataOperation(1, Sqlstr, "memdet")
                        End If
                    Next
                End With

                'Education DETAILS
                Sqlstr = " Delete From memdet Where Type0='QUAL' And mem_code='" & txt_MemberCode.Text.Replace("'", "") & "'"
                gconnection.dataOperation(1, Sqlstr, "memdet")
                For i = 1 To grd_Education.DataRowCnt
                    With grd_Education
                        Sqlstr = "INSERT INTO MEMDET(MEM_CODE,TYPE0,QUAL_DET,REMARKS,YEAR_PASS,INSTITUTE,DIVISION,ADD_DATE, ADD_USER)"
                        Sqlstr = Sqlstr & "  Values ('" & txt_MemberCode.Text.Replace("'", "") & "','QUAL'"
                        .Row = i
                        .Col = 1
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        .Col = 2
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        .Col = 3
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        .Col = 4
                        Sqlstr = Sqlstr & ",'" & .Text & "'"
                        .Col = 5
                        Sqlstr = Sqlstr & ",'" & .Text & "','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "','" & gUsername & "')"
                        gconnection.dataOperation(1, Sqlstr, "memdet")
                    End With
                Next i
                'For i = 1 To ssgrid.DataRowCnt
                '    With ssgrid
                '        Sqlstr = "UPDATE membermaster SET SPOUSE = "
                '        .Row = i
                '        .Col = 3
                '        If (.Text) = "Spouse" Or (.Text) = "SPOUSE" Then
                '            .Row = i
                '            .Col = 1
                '            Sqlstr = Sqlstr & "'" & .Text & "' WHERE MCODE= '" & txt_MemberCode.Text.Replace("'", "") & "'"
                '        Else
                '            Sqlstr = Sqlstr & " ' ' WHERE MCODE= '" & txt_MemberCode.Text.Replace("'", "") & "' "
                '        End If
                '        gconnection.dataOperation(1, Sqlstr, "membermaster")
                '    End With
                'Next i
                For i = 1 To grd_Education.DataRowCnt
                    With grd_Education
                        Sqlstr = "UPDATE membermaster SET Qualification" & i & "="
                        .Row = i
                        .Col = 1
                        Sqlstr = Sqlstr & "'" & .Text & "',"
                        .Col = 2
                        Sqlstr = Sqlstr & "Details" & i & "='" & .Text & "',"
                        .Col = 3
                        Sqlstr = Sqlstr & "YearOfPassing" & i & "='" & .Text & "',"
                        .Col = 4
                        Sqlstr = Sqlstr & "Institute" & i & "='" & .Text & "',"
                        .Col = 5
                        Sqlstr = Sqlstr & "Division" & i & "='" & .Text & "' WHERE MCODE= '" & txt_MemberCode.Text.Replace("'", "") & "'"
                        gconnection.dataOperation(1, Sqlstr, "membermaster")
                    End With
                Next i

                Sqlstr = " Update membermaster set MEMIMAGE=@memimage Where Mcode='" & txt_MemberCode.Text & "' "
                Call SaveFoto(strPhotoFilePath, Trim(txt_MemberCode.Text.Replace("'", "")), Sqlstr)

                Sqlstr = " Update membermaster set MEMIMAGESIGN=@memimage Where Mcode='" & txt_MemberCode.Text & "' "
                Call SaveFoto(strPhotoFilePath_SIG, Trim(txt_MemberCode.Text.Replace("'", "")), Sqlstr)

                Sqlstr = " Update membermaster set SpouseImage=@memimage Where Mcode='" & txt_MemberCode.Text & "' "
                Call SaveFoto(strPhotoFilePath_Spouse, Trim(txt_MemberCode.Text.Replace("'", "")), Sqlstr)

                Sqlstr = " Update membermaster set SpouseImageSign=@memimage Where Mcode='" & txt_MemberCode.Text & "' "
                Call SaveFoto(strPhotoFilePath_SpouseImg, Trim(txt_MemberCode.Text.Replace("'", "")), Sqlstr)

                For i = 1 To grd_depedent.DataRowCnt
                    With grd_depedent
                        .Row = i
                        .Col = 2
                        Sqlstr = " Update memdet set MEMIMAGE=@memimage Where  child_nm='" & Trim(.Text) & "' and mem_code='" & txt_MemberCode.Text.Replace("'", "") & "' and type0='chld'"
                        .Row = i
                        .Col = 9
                        If (.Text) <> "" Then
                            Call SaveFoto(Trim(.Text), Trim(txt_MemberCode.Text.Replace("'", "")), Sqlstr)
                        End If
                        .Col = 11
                        VFilePath = apppath & "\Reports\" & Trim(.Text) & ".JPG"
                        If File.Exists(VFilePath) = True Then
                            File.Delete(VFilePath)
                        End If
                    End With
                Next
                For i = 1 To grd_depedent.DataRowCnt
                    With grd_depedent
                        .Row = i
                        .Col = 2
                        Sqlstr = "UPDATE MEMDET SET DEPIMAGESIGN=@memimage where child_nm='" & Trim(.Text) & "' and mem_code='" & txt_MemberCode.Text.Replace("'", "") & "' and type0='chld'"
                        .Row = i
                        .Col = 10
                        If (.Text) <> "" Then
                            Call SaveFoto(Trim(.Text), Trim(txt_MemberCode.Text.Replace("'", "")), Sqlstr)
                        End If
                    End With
                Next
                If Txt_Replacement.Enabled = True Then
                    Sqlstr = "UPDATE MEMBERMASTER SET REPLACEMENT='" & Txt_Replacement.Text.Replace("'", "") & "',RNO='" & Txt_Rno.Text.Replace("'", "") & "' Where Mcode='" & txt_MemberCode.Text.Replace("'", "") & "'"
                    gconnection.dataOperation(2, Sqlstr, "membermaster")
                Else
                    Sqlstr = "UPDATE MEMBERMASTER SET REPLACEMENT='',RNO='' Where Mcode='" & txt_MemberCode.Text.Replace("'", "") & "'"
                    gconnection.dataOperation(2, Sqlstr, "membermaster")
                End If
                Sqlstr = " Update membermaster set ICNO='" & txtICNO.Text.Replace("'", "") & "',UnitNo='" & cmbUnitNo.Text.Replace("'", "") & "',RankNo='" & cmbRankNo.Text & "',DateOfCommission=Convert(datetime,'" & dtpDFCommission.Text & "',103),DateOfRelease=Convert(datetime,'" & dtpDFRelease.Text & "',103),DateOfCreation=Convert(datetime,'" & dtpDFCreation.Text & "',103),MDescription='" & Cbo_servives.Text.Replace("'", "") & "',RIDCardNo='" & txtRIDCARDNO.Text.Replace("'", "") & "',ArmService='" & txtArmService.Text.Replace("'", "") & "',WO='" & txtWO.Text.Replace("'", "") & "',NoOfDependencies='" & txtNFDependencies.Text.Replace("'", "") & "',RByMemberNo='" & txtRBYMEMBERNO.Text.Replace("'", "") & "',RByName='" & txtNBYMEMBERNAME.Text.Replace("'", "") & "',RBYMEMBERNO2='" & txtRBYMEMBERNO2.Text.Replace("'", "'") & "',RBYMEMBERNAME2='" & txtNBYMEMBERNAME2.Text.Replace("'", "'") & "',PROPOSER='" & txt_ProposerCode.Text.Replace("'", "'") & "',PROPOSERNAME='" & txt_Proposername.Text.Replace("'", "'") & "', SECONDER='" & txt_SeconderCode1.Text.Replace("'", "'") & "',SECONDERNAME='" & txt_SeconderName1.Text.Replace("'", "'") & "',ApplNo ='" & Trim(Txt_APPLNO.Text) & "',ApplDate=Convert(datetime,'" & (dtp_ApplnDate.Text) & "',103),PANO='" & Trim(Txt_pancarno.Text) & "' Where Mcode='" & txt_MemberCode.Text.Replace("'", "") & "' "
                gconnection.dataOperation(2, Sqlstr, "membermaster")
                MessageBox.Show("Record Updated Successfully ", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                'grbRSI.Visible = False


            End If
            Me.btn_clear_Click(sender, e)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub
    Private Sub Loadimage()
        Sqlstr = " Update membermaster set MEMIMAGE=@memimage Where Mcode='" & txt_MemberCode.Text & "' "
        Call SaveFoto(strPhotoFilePath, Trim(txt_MemberCode.Text.Replace("'", "")), Sqlstr)

        Sqlstr = " Update membermaster set MEMIMAGESIGN=@memimage Where Mcode='" & txt_MemberCode.Text & "' "
        Call SaveFoto(strPhotoFilePath_SIG, Trim(txt_MemberCode.Text.Replace("'", "")), Sqlstr)

        Sqlstr = " Update membermaster set SpouseImage=@memimage Where Mcode='" & txt_MemberCode.Text & "' "
        Call SaveFoto(strPhotoFilePath_Spouse, Trim(txt_MemberCode.Text.Replace("'", "")), Sqlstr)

        Sqlstr = " Update membermaster set SpouseImagesign=@memimage Where Mcode='" & txt_MemberCode.Text & "' "
        Call SaveFoto(strPhotoFilePath_SpouseImg, Trim(txt_MemberCode.Text.Replace("'", "")), Sqlstr)

        For I = 1 To grd_depedent.DataRowCnt
            With grd_depedent
                .Row = I
                .Col = 2
                Sqlstr = " Update memdet set MEMIMAGE=@memimage Where  child_nm='" & Trim(.Text) & "' and mem_code='" & txt_MemberCode.Text.Replace("'", "") & "' and type0='chld'"
                .Row = I
                .Col = 9
                If (.Text) <> "" Then
                    Call SaveFoto(Trim(.Text), Trim(txt_MemberCode.Text.Replace("'", "")), Sqlstr)
                End If
                .Col = 11
                VFilePath = apppath & "\Reports\" & Trim(.Text) & ".JPG"
                If File.Exists(VFilePath) = True Then
                    File.Delete(VFilePath)
                End If
            End With
        Next
        For I = 1 To grd_depedent.DataRowCnt

            With grd_depedent
                .Row = I
                .Col = 2
                Sqlstr = "UPDATE MEMDET SET DEPIMAGESIGN=@memimage where child_nm='" & Trim(.Text) & "' and mem_code='" & txt_MemberCode.Text.Replace("'", "") & "' and type0='chld'"
                .Row = I
                .Col = 10
                If (.Text) <> "" Then
                    Call SaveFoto(Trim(.Text), Trim(txt_MemberCode.Text.Replace("'", "")), Sqlstr)
                End If
            End With
        Next
        'MessageBox.Show("Record Added Successfully ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Function SaveFoto(ByVal FilePath As String, ByVal Mcode As String, ByVal Qurstr As String)
        Try
            '##### IN CASE NO PHOTO SELECTED ##### 
            If Trim(FilePath) = "" Then
                Exit Function
            End If
            '##### ##### ##### ##### ##### ##### #

            Dim cn As New SqlConnection(strcn)
            'Dim cmd As New SqlCommand("update membermaster set " & fieldname & _
            '" = @memimage where mcode = '" & Mcode & "' ", cn)
            Dim cmd As New SqlCommand(Qurstr, cn)
            Dim fsPhotoFile As New FileStream(FilePath, FileMode.Open, FileAccess.Read)
            Dim bytMEMimage(fsPhotoFile.Length() - 1) As Byte
            fsPhotoFile.Read(bytMEMimage, 0, bytMEMimage.Length)
            fsPhotoFile.Close()
            Dim prm As New SqlParameter("@memimage", SqlDbType.VarBinary, _
                bytMEMimage.Length, ParameterDirection.Input, False, _
                0, 0, Nothing, DataRowVersion.Current, bytMEMimage)
            cmd.Parameters.Add(prm)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Sub LoadFoto_chld(ByVal quystr As String, ByVal row As Integer)
        Try
            Dim cn As New SqlConnection(strcn)
            Dim sssql As String
            'sssql = "SELECT * FROM SM_CARDFILE_HDR WHERE [16_DIGIT_CODE] ='" & Trim(CARDID.Text) & "' AND [16_DIGIT_CODE] NOT IN ( SELECT [16_DIGIT_CODE] FROM SM_CARDFILE_HDR WHERE [16_digit_code] = '" & Trim(CARDID.Text) & "' AND MEMIMAGE IS NULL)"
            Dim cmd As New SqlCommand(quystr, cn)
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "sm_image")
            Dim c As Integer = ds.Tables("SM_IMAGE").Rows.Count
            If c > 0 Then
                Dim bytMEMimage() As Byte = ds.Tables("SM_IMAGE").Rows(c - 1)("memimage")
                Dim stmMEMimage As New MemoryStream(bytMEMimage)
                With grd_depedent
                    .Col = 9
                    .Row = row
                    grd_depedent.TypePictPicture = Image.FromStream(stmMEMimage)
                    vOutfile = Mid("Pho" & (Rnd() * 800000), 1, 8)
                    VFilePath = apppath & "\Reports\" & vOutfile & ".JPG"
                    If File.Exists(VFilePath) = True Then
                        File.Delete(VFilePath)
                    End If
                    Dim myBitmap As Bitmap = CType(Bitmap.FromStream(stmMEMimage), Bitmap)
                    myBitmap.Save(VFilePath)
                    myBitmap.Dispose()
                    .Col = 9
                    .Row = row
                    .Text = VFilePath
                    .Col = 11
                    .Text = vOutfile
                End With
            Else
                'PIC.Image = Nothing
                'Return Nothing
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
    Public Function Corporate() As Boolean
        boolchk = False
        Dim sql As String
        Dim noofmem As Integer
        Dim totmem As Integer
        Dim totalmem As Integer
        Dim i As Integer
        Try
            sql = "Select CMCorporateCode,CMCorporateName,CMNomembers from CorporateMaster WHERE CMCorporateCode='" & Txt_CorporateCode.Text & "'"
            gconnection.getDataSet(sql, "Membermaster")
            If gdataset.Tables("Membermaster").Rows.Count > 0 Then
                noofmem = CheckDBNull(gdataset.Tables("Membermaster").Rows(0).Item("CMNomembers"))
            End If
            sql = "Select Mcode,CorporateCode from MemberMaster WHERE CorporateCode='" & Txt_CorporateCode.Text & "' And CurentStatus IN('ACTIVE','LIVE')"
            gconnection.getDataSet(sql, "Corporatemaster")
            If gdataset.Tables("Corporatemaster").Rows.Count > 0 Then
                totmem = gdataset.Tables("Corporatemaster").Rows.Count
                '  For i = 0 To gdataset.Tables("Corporatemaster").Rows.Count - 1
                'totmem = CheckDBNull(gdataset.Tables("Corporatemaster").Rows(i).Item("CorporateCode"))
                'Next
                totalmem = noofmem - totmem
                If totalmem < 1 Then
                    MessageBox.Show("Corporate Code No." & Txt_CorporateCode.Text & " Has a Maximum Strength")
                    Return False
                    Exit Function
                End If
            End If

            If txt_Spouse.Text <> "" And Cbo_MaritalStatus.Text <> "MARRIED" Then
                MessageBox.Show("Please Check SpouseName and MaritalStatus!", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_Spouse.Focus()
                Return False
                Exit Function
            End If
            Return True
            boolchk = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
            Return False
        End Try
    End Function
    Public Function checkValidation() As Boolean
        Try
            If txt_MemberCode.Text = "" Then
                MessageBox.Show(" Member Code can't be blank ", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_MemberCode.Focus()
                Return False
                Exit Function
            End If
            If txt_FirstName.Text = "" Then
                MessageBox.Show(" FirstName can't be blank ", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_FirstName.Focus()
                Return False
                Exit Function
            End If

            If cbo_BillingBasis.Text = "" Then
                MessageBox.Show(" Subscription Type can't be blank ", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cbo_BillingBasis.Focus()
                Return False
                Exit Function
            End If
            If chk_male.Checked = False And chk_female.Checked = False Then
                MessageBox.Show(" Please Click Gender ", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                chk_male.Focus()
                Return False
                Exit Function
            End If
            If CHK_DOB.Checked = True Then
                'dtp_DateOfBirth.Value = ""
            End If
            If CHK_DOJ.Checked = True Then
                'dtp_DateOfBirth.Value = ""
            End If
            If chk_EXPDT.Checked = True Then
                'dtp_DateOfBirth.Value = ""
            End If
            'If ChK_SDOB.Checked = True Then
            '    'dt_sdob.Value = ""
            'End If
            If CHK_WDT.Checked = True Then
                'dtp_DOW.Value = ""
            End If

            'mohanraju added start
            If dtp_DOB.Value = Today.Date Then
                MsgBox("Date of Birth should be less than today date", MsgBoxStyle.Information, gcompanyname)
                Return False
                Exit Function
            End If
            'ended

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
            Return False
        End Try
    End Function

    Public Function checkValidation1() As Boolean
        boolchk = False
        Dim years, DAYS As Long
        Dim noofyears As String

        Try
            If txt_MemberCode.Text = "" Then
                MessageBox.Show(" Member Code can't be blank ", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_MemberCode.Focus()
                Return False
                Exit Function
            End If

            If txt_FirstName.Text = "" Then
                MessageBox.Show(" FirstName can't be blank ", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_FirstName.Focus()
                Return False
                Exit Function
            End If

            If chk_ContactAddress1.Checked = False And chk_ContactAddress2.Checked = False And chk_ContactAddress3.Checked = False Then
                MessageBox.Show("Please Check Contact Address", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Return False
                Exit Function
            End If

            If txt_PA_Address1.Text = "" Then
                If chk_ContactAddress1.Checked = True Then
                    MessageBox.Show("Address Field Can't be Blank", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                    Exit Function
                End If
            End If

            If txt_BA_Address1.Text = "" Then
                If chk_ContactAddress2.Checked = True Then
                    MessageBox.Show("Address Field Can't be Blank", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                    Exit Function
                End If
            End If
            If txt_RA_Address1.Text = "" Then
                If chk_ContactAddress3.Checked = True Then
                    MessageBox.Show("Address Field Can't be Blank", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                    Exit Function
                End If
            End If
            'If txt_RA_Address1.Text = "" Then
            '    MessageBox.Show("Residence Address Field Can't be Blank", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Return False
            '    Exit Function
            'End If
            If TXT_MEMLIMIT.Text = "" Or TXT_MEMLIMIT.Text = "0" Then
                If CREDITYN = "Y" Then
                    MessageBox.Show("Creditlimit is Applicaple for this member,Please fill CreditLimit field", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                    Exit Function
                End If
            End If

            If txt_Spouse.Text = "" And Cbo_MaritalStatus.Text = "MARRIED" Then
                MessageBox.Show("SpouseName Can't be blank !", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_Spouse.Focus()
                Return False
                Exit Function
            End If
            If txt_Spouse.Text <> "" And Cbo_MaritalStatus.Text <> "MARRIED" Then
                MessageBox.Show("Please Check SpouseName and MaritalStatus!", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_Spouse.Focus()
                Return False
                Exit Function
            End If
            For I = 1 To grd_depedent.DataRowCnt Step 1
                With grd_depedent
                    grd_depedent.Row = grd_depedent.ActiveRow
                    grd_depedent.Row = I
                    grd_depedent.Col = 6
                    spouse = grd_depedent.Text
                    grd_depedent.Row = I
                    grd_depedent.Col = 7
                    marital = grd_depedent.Text

                    If spouse <> "" And marital <> "MARRIED" Then
                        MessageBox.Show("Not Matching DependentSpouseName and Marital Status Details", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Return False
                        Exit Function
                    End If
                End With
            Next I

            If CHK_DOB.Checked = False Then
                MessageBox.Show("Please Check Member Date of Birth ", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
                Exit Function
            End If


            'mohanraju added start
            If dtp_DOB.Value = Today.Date Then
                MsgBox("Date of Birth should be less than today date", MsgBoxStyle.Information, gcompanyname)
                Return False
                Exit Function
            End If
            'ended

            years = DateDiff("yyyy", dtp_DOB.Value, Today.Date)
            If years < "12" Then
                MsgBox("Members Date of Birth should be greater than 12 years  ", MsgBoxStyle.Information, gcompanyname)
                Return False
                Exit Function
            End If
            'DAYS = DateDiff(DateInterval.Day, Today.Date, dtp_DOJ.Value)
            'If btn_add.Text = "Add[F7]" Then
            '    If DAYS < "0" Or DAYS > "0" Then
            '        MsgBox("Date of join Should be today date", MsgBoxStyle.Information, gcompanyname)
            '        Return False
            '        Exit Function
            '    End If
            'End If

            If Cbo_MaritalStatus.Text = "MARRIED" Then

                If Cbo_Spousesalutation.Text = "" Then
                    MsgBox("Spouse Salutation Can't be blank", MsgBoxStyle.Information, gcompanyname)
                    Return False
                    Exit Function
                End If

                'If Dtp_Spousedob.Value = Today.Date Then
                '    MsgBox("Spouse Date of Birth should be less than today date", MsgBoxStyle.Information, gCompanyname)
                '    Return False
                '    Exit Function
                'End If
                years = DateDiff("yyyy", Dtp_Spousedob.Value, Today.Date)
                If years < "18" Then
                    MsgBox("Spouse Date of Birth should be greater than 18 years ", MsgBoxStyle.Information, gcompanyname)
                    Return False
                    Exit Function
                End If

                If dtp_DOB.Value > dtp_DOW.Value Then
                    MsgBox("Date of Birth Less than the Date of Wedding", MsgBoxStyle.Information, gcompanyname)
                    Return False
                    Exit Function
                End If
                If Dtp_Spousedob.Value > dtp_DOW.Value Then
                    MsgBox("Spouse Date of Birth Less than the Date of Wedding", MsgBoxStyle.Information, gcompanyname)
                    Return False
                    Exit Function
                End If
            End If
            'years = DateDiff("yyyy", dtp_DOW.Value, Today.Date)
            If CHK_WDT.Checked = True Then
                If Today.Date <= dtp_DOW.Value Then
                    MsgBox("Date of Wedding should be Less than today date  ", MsgBoxStyle.Information, gcompanyname)
                    Return False
                    Exit Function
                End If
            End If
            If chk_EXPDT.Checked = True Then
                If dtp_EXPDT.Value <= dtp_DOJ.Value Then
                    MsgBox("Expiry  should not be Less than Date of Join date  ", MsgBoxStyle.Information, gcompanyname)
                    Return False
                    Exit Function
                End If
            End If
            If chk_male.Checked = False And chk_female.Checked = False Then
                MsgBox("Gender Should'nt be blank  ", MsgBoxStyle.Information, gcompanyname)
                Return False
                Exit Function
            End If
            If Cbo_professional.Text = "" Then
                MsgBox("Professional Should'nt be blank  ", MsgBoxStyle.Information, gcompanyname)
                Return False
                Exit Function
            End If
            If Cbo_designation.Text = "" Then
                MsgBox("Designation Should'nt be blank  ", MsgBoxStyle.Information, gcompanyname)
                Return False
                Exit Function
            End If
            For I = 1 To grd_depedent.DataRowCnt Step 1
                With grd_depedent
                    grd_depedent.Row = grd_depedent.ActiveRow
                    grd_depedent.Row = I
                    grd_depedent.Col = 3
                    If (grd_depedent.Text) <> "" Then
                        Childdob = Format(CDate(grd_depedent.Text), "yyyy/MM/dd")
                        If Childdob = Today.Date Then
                            MsgBox("Dependent Date of Birth should be less than today date", MsgBoxStyle.Information, gcompanyname)
                            Return False
                            Exit Function
                        End If
                        years = DateDiff("yyyy", dtp_DOB.Value, Childdob)
                        If years < "18" Then
                            MsgBox("Dependent Date of Birth should be greater than 18 years of Member Date of Birth", MsgBoxStyle.Information, gcompanyname)
                            Return False
                            Exit Function
                        End If
                    End If
                    grd_depedent.Col = 8
                    If (grd_depedent.Text) <> "" Then
                        depdow = Format(CDate(grd_depedent.Text), "yyyy/MM/dd")
                        years = DateDiff("yyyy", Childdob, depdow)
                        If years < "18" Then
                            MsgBox("Dependent Date of wedding should be greater 18 years Dependent Date of Birth", MsgBoxStyle.Information, gcompanyname)
                            Return False
                            Exit Function
                        End If
                    End If
                End With
            Next I

            'If txt_PA_Email.Text <> "" Then
            '    emailst = getEmail(txt_PA_Email)
            '    If emailst <> "T" Then
            '        Exit Function
            '    End If
            'End If
            'If txt_BA_Email.Text <> "" Then
            '    emailst = getEmail(txt_BA_Email)
            '    If emailst <> "T" Then
            '        Exit Function
            '    End If
            'End If
            'If txt_RA_Email.Text <> "" Then
            '    emailst = getEmail(txt_RA_Email)
            '    If emailst <> "T" Then
            '        Exit Function
            '    End If
            'End If
            'If dtp_DOB.Value < Childdob Then
            '    MessageBox.Show("Not Matching DependentSpouseName and Marital Status Details", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Return False
            '    Exit Function
            'End If
            Return True
            boolchk = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
            Return False
        End Try
    End Function


    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        If (txt_MemberCode.Text = "") Then
            MessageBox.Show("Select the Member Code !")
            Exit Sub
        Else
            Call member_details()
        End If
    End Sub
    Private Sub member_details()
        Try
            Dim sqlstring As String
            Dim Viewer As New REPORTVIEWER
            Dim r As New Cry_MemberMaster_New

            Dim txtobj1 As TextObject
            Sqlstr = "select * from MM_membermaster where mcode='" & txt_MemberCode.Text & "'"
            Call Viewer.GetDetails1(Sqlstr, "MM_MEMBERMASTER", r)
            Sqlstr1 = "SELECT * FROM MM_MEMDET WHERE MEM_CODE='" & txt_MemberCode.Text & "' and type0='CHLD'"
            Call Viewer.GetDetails1(Sqlstr1, "MM_MEMDET", r)
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
            txtobj1 = r.ReportDefinition.ReportObjects("Text26")
            txtobj1.Text = UCase(gCompanyAddress(4))
            txtobj1 = r.ReportDefinition.ReportObjects("Text29")
            txtobj1.Text = UCase(gCompanyAddress(5))


            txtobj1 = r.ReportDefinition.ReportObjects("Text9")
            txtobj1.Text = UCase(gFinancalyearStart)
            txtobj1 = r.ReportDefinition.ReportObjects("Text22")
            txtobj1.Text = UCase(gFinancialyearEnd)



            txtobj1 = r.ReportDefinition.ReportObjects("Text27")
            txtobj1.Text = UCase(gUsername)
            'Viewer.ssql = Sql
            'Viewer.Report = r
            'Viewer.TableName = "mm_memberidproof"


            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try


    End Sub


    Private Sub btn_Export_Click(sender As Object, e As EventArgs) Handles btn_Export.Click
        'Try
        '    Dim _export As New EXPORT
        '    Sqlstr = "Select * From Membermaster"
        '    _export.TABLENAME = "Membermaster"
        '    Call _export.export_excel(Sqlstr)
        '    _export.Show()
        '    Exit Sub
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub


    Private Sub Cbo_title_KeyDown(sender As Object, e As KeyEventArgs) Handles Cbo_title.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Cbo_title.Text = "" Then
                Cbo_title.Focus()
            Else
                TXT_TITLE.Focus()
            End If
        End If
    End Sub

    Private Sub TXT_TITLE_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_TITLE.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_FirstName.Focus()
        End If
    End Sub

    Private Sub txt_FirstName_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_FirstName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_MiddleName.Focus()
        End If
    End Sub

    Private Sub TXT_TITLE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_TITLE.KeyPress
        getCharater(e)
    End Sub

    Private Sub txt_FirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_FirstName.KeyPress
        Block_Singlequote(e)
    End Sub

    Private Sub txt_MiddleName_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_MiddleName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_Surname.Focus()
        End If
    End Sub

    Private Sub txt_MiddleName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_MiddleName.KeyPress
        Block_Singlequote(e)
    End Sub

    Private Sub txt_Surname_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Surname.KeyDown
        If e.KeyCode = Keys.Enter Then
            chk_male.Focus()
        End If
    End Sub

    Private Sub txt_Surname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Surname.KeyPress
        Block_Singlequote(e)
    End Sub

    Private Sub chk_male_Click(sender As Object, e As EventArgs) Handles chk_male.Click
        If chk_male.Checked = True Then
            chk_female.Checked = False
        Else
            chk_female.Checked = True
        End If
    End Sub

    Private Sub chk_female_Click(sender As Object, e As EventArgs) Handles chk_female.Click
        If chk_female.Checked = True Then
            chk_male.Checked = False
        Else
            chk_male.Checked = True
        End If
    End Sub

    Private Sub chk_male_CheckedChanged(sender As Object, e As EventArgs) Handles chk_male.CheckedChanged

    End Sub

    Private Sub chk_male_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_male.KeyDown
        Cbo_MaritalStatus.Focus()

    End Sub

    Private Sub chk_female_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_female.KeyDown
        Cbo_MaritalStatus.Focus()

    End Sub

    Private Sub Cbo_MaritalStatus_Click(sender As Object, e As EventArgs) Handles Cbo_MaritalStatus.Click
        If Cbo_MaritalStatus.Text = "MARRIED" Then
            dtp_DOW.Visible = True
            CHK_WDT.Visible = True
        Else
            dtp_DOW.Enabled = False
            CHK_WDT.Enabled = False
            txt_Spouse.ReadOnly = False
            Cbo_Spousesalutation.Enabled = False
        End If
    End Sub

    Private Sub Cbo_MaritalStatus_KeyDown(sender As Object, e As KeyEventArgs) Handles Cbo_MaritalStatus.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Cbo_MaritalStatus.Text = "MARRIED" Then
                Cbo_Spousesalutation.Focus()
            Else
                cbo_BillingBasis.Focus()
            End If

        End If
    End Sub

    Private Sub Cbo_MaritalStatus_LostFocus(sender As Object, e As EventArgs) Handles Cbo_MaritalStatus.LostFocus
        If Cbo_MaritalStatus.Text = "MARRIED" Then
            dtp_DOW.Visible = True
            CHK_WDT.Visible = True
            CHK_WDT.Enabled = True
            Cbo_Spousesalutation.Enabled = True
            gpx_spouse.Visible = True
        ElseIf Cbo_MaritalStatus.Text = "DIVORCED" Or Cbo_MaritalStatus.Text = "UNMARRIED" Then
            If MsgBox("Do you Want to Delete Spouse Detail", MsgBoxStyle.OkCancel, gcompanyname) = MsgBoxResult.Ok Then
                dtp_DOW.Enabled = False
                ChK_SDOB.Checked = False
                CHK_WDT.Checked = False
                txt_Spouse.Text = ""
                Cbo_Spousesalutation.Enabled = False
                Cbo_Spousesalutation.SelectedIndex = -1
                CHK_WDT.Enabled = False
                txt_Spouse.ReadOnly = False
                gpx_spouse.Visible = False
                Cbo_Spousesalutation.Enabled = True
                Exit Sub
            End If
        ElseIf Cbo_MaritalStatus.Text <> "MARRIED" Or Cbo_MaritalStatus.Text <> "DIVORCED" Or Cbo_MaritalStatus.Text <> "" Or Cbo_MaritalStatus.Text <> "UNMARRIED" Then
            If MsgBox("Do you Want to Delete Spouse and Dependent Details ", MsgBoxStyle.OkCancel, gcompanyname) = MsgBoxResult.Ok Then
                dtp_DOW.Enabled = False
                ChK_SDOB.Checked = False
                CHK_WDT.Checked = False
                txt_Spouse.Text = ""
                Cbo_Spousesalutation.Enabled = False
                Cbo_Spousesalutation.SelectedIndex = -1
                CHK_WDT.Enabled = False
                txt_Spouse.ReadOnly = False
                gpx_spouse.Visible = False
                Cbo_Spousesalutation.Enabled = True
                grd_depedent.ClearRange(1, 1, -1, -1, True)
            End If

        End If
        'txt_PA_Address1.Focus()
    End Sub

    Private Sub Cbo_MaritalStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_MaritalStatus.SelectedIndexChanged

        If Cbo_MaritalStatus.Text = "MARRIED" Then
            Sqlstr = "Select Mcode,Mname,MARITAL_STATUS,ISNULL(spouseprefix,'') AS spouseprefix,spouse,ISNULL(sdob,'') AS SDOB,Wedding_Date from membermaster where MARITAL_STATUS='MARRIED' and MCODE='" & txt_MemberCode.Text & "'"
            gconnection.getDataSet(Sqlstr, "Membermaster")
            If gdataset.Tables("Membermaster").Rows.Count > 0 Then
                dtp_DOW.Visible = True
                CHK_WDT.Visible = True
                CHK_WDT.Enabled = True
                Cbo_Spousesalutation.Enabled = True
                gpx_spouse.Visible = True
                Cbo_Spousesalutation.Text = gdataset.Tables("Membermaster").Rows(0).Item("spouseprefix")
                txt_Spouse.Text = gdataset.Tables("Membermaster").Rows(0).Item("Spouse")
                If (gdataset.Tables("Membermaster").Rows(0).Item("SDOB")) = "01 Jan 1900" Then
                    Dtp_Spousedob.Text = ""
                    ChK_SDOB.Checked = False
                Else
                    Dtp_Spousedob.Text = (gdataset.Tables("Membermaster").Rows(0).Item("SDOB"))
                    ChK_SDOB.Checked = True
                End If

                If (gdataset.Tables("Membermaster").Rows(0).Item("wedding_date")) = "01 Jan 1900" Then
                    dtp_DOW.Text = ""
                    CHK_WDT.Checked = False
                Else
                    dtp_DOW.Text = (gdataset.Tables("Membermaster").Rows(0).Item("wedding_date"))
                    CHK_WDT.Checked = True
                End If
                'DEPENDENT DETAILS 
                'Sqlstr = " select ISNULL(prefix,'')AS prefix,ISNULL(mem_code,'') AS MCODE,ISNULL(child_nm,'') AS CNAME,ISNULL(child_dob,'') AS CDOB,ISNULL((relation),'') AS RELATION,ISNULL(maritalstatus,'') AS maritalstatus,dep_bloodgroup,isnull(Sex,'') as Sex,isnull(SpouseName,'')as SpouseName,isnull(membertype,'')as membertype,isnull(studentmember,'')as studentmember,isnull(dep_Doj,'')as dep_Doj,isnull(Religion,'') as Religion,isnull(anniversarydate,'') as anniversarydate,isnull(occupation,'')as occupation,isnull(Panno,0) as Panno,isnull(phone,'') as phone,isnull(mobile,'') as mobile,isnull(emailid,'') as emailid from memdet where type0='CHLD' AND MEM_CODE='" & txt_MemberCode.Text & "'"
                'gconnection.getDataSet(Sqlstr, "DeptDet")
                'If gdataset.Tables("DeptDet").Rows.Count > 0 Then
                '    For I = 0 To gdataset.Tables("DeptDet").Rows.Count - 1
                '        With ssgrid
                '            Call loadmembertype(I + 1)
                '            Call loadSalutation(I + 1)
                '            Call loadMaritalstatus(I + 1)
                '            ssgrid.Row = I + 1
                '            ssgrid.Col = 1
                '            .Text = (gdataset.Tables("DeptDet").Rows(I).Item("prefix"))
                '            Call loadmembertype(I + 1)
                '            Call loadSalutation(I + 1)
                '            Call loadMaritalstatus(I + 1)
                '            ssgrid.Col = 2
                '            .Text = (gdataset.Tables("DeptDet").Rows(I).Item("CNAME"))
                '            Call loadmembertype(I + 1)
                '            Call loadSalutation(I + 1)
                '            Call loadMaritalstatus(I + 1)
                '            ssgrid.Col = 3
                '            If Format(CDate(gdataset.Tables("DeptDet").Rows(I).Item("CDOB")), "yyyy/MM/dd") = "1900/01/01" Then
                '                .Text = ""
                '            Else
                '                .Text = Format(CDate(gdataset.Tables("DeptDet").Rows(I).Item("CDOB")), "dd/MM/yyyy")
                '            End If

                '            Call loadmembertype(I + 1)
                '            Call loadSalutation(I + 1)
                '            Call loadMaritalstatus(I + 1)
                '            ssgrid.Col = 4
                '            .Text = (gdataset.Tables("DeptDet").Rows(I).Item("Sex"))

                '            Call loadmembertype(I + 1)
                '            Call loadSalutation(I + 1)
                '            Call loadMaritalstatus(I + 1)

                '            ssgrid.Col = 5
                '            If ((gdataset.Tables("DeptDet").Rows(I).Item("RELATION")) = "SPOUSE") Then
                '                .Text = "SPOUSE"
                '            ElseIf ((gdataset.Tables("DeptDet").Rows(I).Item("RELATION")) = "SON") Then
                '                .Text = "SON"
                '            ElseIf ((gdataset.Tables("DeptDet").Rows(I).Item("RELATION")) = "DAUGHTER") Then
                '                .Text = "DAUGHTER"
                '            ElseIf ((gdataset.Tables("DeptDet").Rows(I).Item("RELATION")) = "FATHER") Then
                '                .Text = "FATHER"
                '            ElseIf ((gdataset.Tables("DeptDet").Rows(I).Item("RELATION")) = "MOTHER") Then
                '                .Text = "MOTHER"
                '            ElseIf ((gdataset.Tables("DeptDet").Rows(I).Item("RELATION")) = "OTHERS") Then
                '                .Text = "OTHERS"
                '            End If
                '            Call loadmembertype(I + 1)
                '            Call loadSalutation(I + 1)
                '            Call loadMaritalstatus(I + 1)

                '            ssgrid.Col = 6
                '            .Text = CheckDBNull(gdataset.Tables("DeptDet").Rows(I).Item("SpouseName"))
                '            Call loadmembertype(I + 1)
                '            Call loadSalutation(I + 1)
                '            Call loadMaritalstatus(I + 1)
                '            ssgrid.Col = 7
                '            If Format(CDate(gdataset.Tables("DeptDet").Rows(I).Item("anniversarydate")), "yyyy/MM/dd") = "1900/01/01" Then
                '                .Text = ""
                '            Else
                '                .Text = Format(CDate(gdataset.Tables("DeptDet").Rows(I).Item("anniversarydate")), "dd/MM/yyyy")
                '            End If
                '            Call loadmembertype(I + 1)
                '            Call loadSalutation(I + 1)
                '            Call loadMaritalstatus(I + 1)

                '            ssgrid.Col = 8
                '            .Text = (gdataset.Tables("DeptDet").Rows(I).Item("maritalstatus"))
                '            Call loadmembertype(I + 1)
                '            Call loadSalutation(I + 1)


                '            ssgrid.Col = 9
                '            Sqlstr = "SELECT memimage as memimage FROM memdet WHERE mem_code='" & Trim(txt_MemberCode.Text) & "' and child_nm='" & gdataset.Tables("DeptDet").Rows(I).Item("CNAME") & "'  and type0='chld' "
                '            LoadFoto_chld(Sqlstr, I + 1)
                '            Call loadmembertype(I + 1)
                '            Call loadSalutation(I + 1)
                '            Call loadMaritalstatus(I + 1)
                '            ssgrid.Col = 12
                '            .Text = CheckDBNull(gdataset.Tables("DeptDet").Rows(I).Item("dep_bloodgroup"))
                '            Call loadmembertype(I + 1)
                '            Call loadSalutation(I + 1)
                '            Call loadMaritalstatus(I + 1)
                '            ssgrid.Col = 13
                '            .Text = CheckDBNull(gdataset.Tables("DeptDet").Rows(I).Item("studentmember"))
                '            Call loadmembertype(I + 1)
                '            Call loadSalutation(I + 1)
                '            Call loadMaritalstatus(I + 1)
                '            ssgrid.Col = 14
                '            If Format(CDate(gdataset.Tables("DeptDet").Rows(I).Item("dep_Doj")), "yyyy/MM/dd") = "1900/01/01" Then
                '                .Text = ""
                '            Else
                '                .Text = Format(CDate(gdataset.Tables("DeptDet").Rows(I).Item("dep_Doj")), "dd/MM/yyyy")
                '            End If
                '            Call loadmembertype(I + 1)
                '            Call loadSalutation(I + 1)
                '            Call loadMaritalstatus(I + 1)

                '            ssgrid.Col = 15
                '            .Text = CheckDBNull(gdataset.Tables("DeptDet").Rows(I).Item("membertype"))
                '            Call loadmembertype(I + 1)
                '            Call loadSalutation(I + 1)
                '            Call loadMaritalstatus(I + 1)

                '            ssgrid.Col = 16
                '            .Text = CheckDBNull(gdataset.Tables("DeptDet").Rows(I).Item("Religion"))
                '            Call loadmembertype(I + 1)
                '            Call loadSalutation(I + 1)
                '            Call loadMaritalstatus(I + 1)

                '            ssgrid.Col = 17
                '            .Text = CheckDBNull(gdataset.Tables("DeptDet").Rows(I).Item("occupation"))
                '            Call loadmembertype(I + 1)
                '            Call loadSalutation(I + 1)
                '            Call loadMaritalstatus(I + 1)
                '            ssgrid.Col = 18
                '            .Text = CheckDBNull(gdataset.Tables("DeptDet").Rows(I).Item("Panno"))
                '            Call loadmembertype(I + 1)
                '            Call loadSalutation(I + 1)
                '            Call loadMaritalstatus(I + 1)
                '            ssgrid.Col = 19
                '            .Text = CheckDBNull(gdataset.Tables("DeptDet").Rows(I).Item("phone"))
                '            Call loadmembertype(I + 1)
                '            Call loadSalutation(I + 1)
                '            Call loadMaritalstatus(I + 1)
                '            ssgrid.Col = 20
                '            .Text = CheckDBNull(gdataset.Tables("DeptDet").Rows(I).Item("mobile"))
                '            Call loadmembertype(I + 1)
                '            Call loadSalutation(I + 1)
                '            Call loadMaritalstatus(I + 1)
                '            ssgrid.Col = 21
                '            .Text = CheckDBNull(gdataset.Tables("DeptDet").Rows(I).Item("emailid"))
                '            Call loadmembertype(I + 1)
                '            Call loadSalutation(I + 1)
                '            Call loadMaritalstatus(I + 1)
                '        End With
                '    Next I
                'End If
            Else
                dtp_DOW.Visible = True
                CHK_WDT.Visible = True
                CHK_WDT.Enabled = True
                Cbo_Spousesalutation.Enabled = True
                gpx_spouse.Visible = True
            End If
        ElseIf Cbo_MaritalStatus.Text <> "MARRIED" Or Cbo_MaritalStatus.Text <> "" Then
            dtp_DOW.Enabled = False
            ChK_SDOB.Checked = False
            CHK_WDT.Checked = False
            txt_Spouse.Text = ""
            Cbo_Spousesalutation.Enabled = False
            Cbo_Spousesalutation.SelectedIndex = -1
            CHK_WDT.Enabled = False
            txt_Spouse.ReadOnly = False
            gpx_spouse.Visible = False
            Cbo_Spousesalutation.Enabled = True
            'Call Cbo_MaritalStatus_LostFocus(sender, e)
        End If
        'Cbo_Spousesalutation.Focus()
    End Sub

    Private Sub Cbo_MaritalStatus_Validated(sender As Object, e As EventArgs) Handles Cbo_MaritalStatus.Validated
        If Cbo_MaritalStatus.Text = "MARRIED" Then
            Sqlstr = "Select Mcode,Mname,MARITAL_STATUS,spouseprefix,spouse,sdob,Wedding_Date from membermaster where MARITAL_STATUS='MARRIED' and MCODE='" & txt_MemberCode.Text & "'"
            gconnection.getDataSet(Sqlstr, "MemMst")
            If gdataset.Tables("MemMst").Rows.Count > 0 Then
                dtp_DOW.Visible = True
                CHK_WDT.Visible = True
                CHK_WDT.Enabled = True
                Cbo_Spousesalutation.Enabled = True
                gpx_spouse.Visible = True
                Cbo_Spousesalutation.Text = gdataset.Tables("MemMst").Rows(0).Item("spouseprefix")
                txt_Spouse.Text = gdataset.Tables("MemMst").Rows(0).Item("Spouse")
                If (gdataset.Tables("MemMst").Rows(0).Item("SDOB")) = "01 Jan 1900" Then
                    Dtp_Spousedob.Text = ""
                    ChK_SDOB.Checked = False
                Else
                    Dtp_Spousedob.Text = (gdataset.Tables("MemMst").Rows(0).Item("SDOB"))
                    ChK_SDOB.Checked = True
                End If

                If (gdataset.Tables("MemMst").Rows(0).Item("wedding_date")) = "01 Jan 1900" Then
                    dtp_DOW.Text = ""
                    CHK_WDT.Checked = False
                Else
                    dtp_DOW.Text = (gdataset.Tables("MemMst").Rows(0).Item("wedding_date"))
                    CHK_WDT.Checked = True
                End If
            Else
                dtp_DOW.Visible = True
                CHK_WDT.Visible = True
                CHK_WDT.Enabled = True
                Cbo_Spousesalutation.Enabled = True
                gpx_spouse.Visible = True
            End If
        End If
    End Sub

    Private Sub cbo_BillingBasis_KeyDown(sender As Object, e As KeyEventArgs) Handles cbo_BillingBasis.KeyDown
        If e.KeyCode = Keys.Enter Then
            CHK_DOB.Focus()
        End If
    End Sub

    Private Sub dtp_DOB_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp_DOB.KeyDown
        If e.KeyCode = Keys.Enter Then
            CHK_DOJ.Focus()
        End If
    End Sub

    Private Sub dtp_DOB_ValueChanged(sender As Object, e As EventArgs) Handles dtp_DOB.ValueChanged
        'If CLEAR = False Then
        '    If dtp_DOJ.Value < dtp_DOB.Value Then
        '        MsgBox("Date of join should be Less then the Date of Birth", MsgBoxStyle.Information, gcompanyname)
        '        Exit Sub
        '    End If
        'End If
    End Sub

    Private Sub dtp_DOJ_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp_DOJ.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cbo_designation.Focus()
        End If
    End Sub

    Private Sub dtp_DOJ_ValueChanged(sender As Object, e As EventArgs) Handles dtp_DOJ.ValueChanged
        'If dtp_DOJ.Value <> Now Then
        '    If validation = True Then
        '        validation = False
        '    Else
        '        MsgBox("Date of join Should be check ", MsgBoxStyle.Information, gcompanyname)
        '    End If
        '    Exit Sub
        'End If
    End Sub

    Private Sub Cbo_designation_KeyDown(sender As Object, e As KeyEventArgs) Handles Cbo_designation.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cbo_professional.Focus()
        End If
    End Sub
    Private Sub Cbo_professional_KeyDown(sender As Object, e As KeyEventArgs) Handles Cbo_professional.KeyDown
        If e.KeyCode = Keys.Enter Then
            Img_Photo.Focus()
        End If
    End Sub

    Private Sub Cbo_Spousesalutation_KeyDown(sender As Object, e As KeyEventArgs) Handles Cbo_Spousesalutation.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_Spouse.Focus()
        End If
    End Sub

    Private Sub Cbo_Spousesalutation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_Spousesalutation.SelectedIndexChanged

    End Sub

    Private Sub txt_Spouse_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Spouse.KeyDown
        If e.KeyCode = Keys.Enter Then
            ChK_SDOB.Focus()
        End If
    End Sub

    Private Sub txt_Spouse_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Spouse.KeyPress
        Block_Singlequote(e)
        If Cbo_MaritalStatus.Text = "MARRIED" Then
        Else
            If MsgBox("PleaseCheck MaritalSatus!!", MsgBoxStyle.OkCancel, "ok") = MsgBoxResult.Ok Then
                txt_Spouse.Text = ""
                txt_Spouse.Clear()
            Else
                txt_Spouse.Text = ""
                txt_Spouse.Clear()
                Exit Sub
            End If
        End If
    End Sub
    Private Sub Dtp_Spousedob_KeyDown(sender As Object, e As KeyEventArgs) Handles Dtp_Spousedob.KeyDown
        If e.KeyCode = Keys.Enter Then
            CHK_WDT.Focus()
        End If
    End Sub

    Private Sub dtp_DOW_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp_DOW.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXT_SPOUSEMOBILE.Focus()
        End If
    End Sub

    Private Sub Img_Photo_Click(sender As Object, e As EventArgs) Handles Img_Photo.Click
        Try
            Dim file As New OpenFileDialog
            file.Filter = " Jpg(*.Jpg) | *.jpg"
            If Trim(txt_MemberCode.Text) <> "" Then
                If file.ShowDialog = DialogResult.OK Then
                    Img_Photo.Image = New Bitmap(file.FileName)
                    strPhotoFilePath = file.FileName
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub

    Private Sub Img_Signature_Click(sender As Object, e As EventArgs) Handles Img_Signature.Click
        Try
            Dim file As New OpenFileDialog
            file.Filter = " Jpg(*.Jpg) | *.jpg"
            If Trim(txt_MemberCode.Text) <> "" Then
                If file.ShowDialog = DialogResult.OK Then
                    Img_Signature.Image = New Bitmap(file.FileName)
                    strPhotoFilePath_SIG = file.FileName
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub

    Private Sub Img_Spousephoto_Click(sender As Object, e As EventArgs) Handles Img_Spousephoto.Click
        Try
            Dim file As New OpenFileDialog
            file.Filter = " Jpg(*.Jpg) | *.jpg"
            If Trim(txt_MemberCode.Text) <> "" Then
                If file.ShowDialog = DialogResult.OK Then
                    Img_Spousephoto.Image = New Bitmap(file.FileName)
                    strPhotoFilePath_Spouse = file.FileName
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub

    Private Sub Sp_Img_Signature_Click(sender As Object, e As EventArgs) Handles Sp_Img_Signature.Click
        Try
            Dim file As New OpenFileDialog
            file.Filter = " Jpg(*.Jpg) | *.jpg"
            If Trim(txt_MemberCode.Text) <> "" Then
                If file.ShowDialog = DialogResult.OK Then
                    Sp_Img_Signature.Image = New Bitmap(file.FileName)
                    strPhotoFilePath_SpouseImg = file.FileName
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub

    Private Sub Cbo_PCity_KeyDown(sender As Object, e As KeyEventArgs) Handles Cbo_PCity.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Cbo_PState.Focus()
            txt_PA_PinCode.Focus()

        End If
    End Sub

    Private Sub Cbo_PCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_PCity.SelectedIndexChanged
        Dim sqlstr As String
        If Cbo_PCity.Text <> "" Then
            sqlstr = " SELECT ISNULL(STATE,'') AS STATE,ISNULL(COUNTRY,'') AS COUNTRY FROM Tbl_CityMaster WHERE NAME='" & Trim(Cbo_PCity.Text) & "'"
            gconnection.getDataSet(sqlstr, "Master")
            Cbo_PState.Text = gdataset.Tables("Master").Rows(0).Item("STATE")
            Cbo_PCountry.Text = gdataset.Tables("Master").Rows(0).Item("COUNTRY")
            'txt_PA_PinCode.Focus()
        End If
    End Sub

    Private Sub Cbo_BCity_KeyDown(sender As Object, e As KeyEventArgs) Handles Cbo_BCity.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Cbo_BState.Focus()
            txt_BA_PinCode.Focus()
        End If
    End Sub

    Private Sub Cbo_BCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_BCity.SelectedIndexChanged
        Dim sqlstr As String
        If Cbo_BCity.Text <> "" Then
            sqlstr = " SELECT ISNULL(STATE,'') AS STATE,ISNULL(COUNTRY,'') AS COUNTRY FROM Tbl_CityMaster WHERE NAME='" & Trim(Cbo_BCity.Text) & "'"
            gconnection.getDataSet(sqlstr, "Master")
            Cbo_BState.Text = gdataset.Tables("Master").Rows(0).Item("STATE")
            Cbo_BCountry.Text = gdataset.Tables("Master").Rows(0).Item("COUNTRY")
        End If
    End Sub

    Private Sub Cbo_CCity_KeyDown(sender As Object, e As KeyEventArgs) Handles Cbo_CCity.KeyDown
        If e.KeyCode = Keys.Enter Then
            'Cbo_CState.Focus()
            txt_RA_PinCode.Focus()

        End If
    End Sub

    Private Sub Cbo_CCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_CCity.SelectedIndexChanged
        Dim sqlstr As String
        If Cbo_CCity.Text <> "" Then
            sqlstr = " SELECT ISNULL(STATE,'') AS STATE,ISNULL(COUNTRY,'') AS COUNTRY FROM Tbl_CityMaster WHERE NAME='" & Trim(Cbo_CCity.Text) & "'"
            gconnection.getDataSet(sqlstr, "Master")
            Cbo_CState.Text = gdataset.Tables("Master").Rows(0).Item("STATE")
            Cbo_CCountry.Text = gdataset.Tables("Master").Rows(0).Item("COUNTRY")
        End If
    End Sub

    Private Sub txt_PA_Address1_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_PA_Address1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txt_PA_Address2.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub

    Private Sub txt_PA_Address2_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_PA_Address2.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txt_PA_Address3.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub

    Private Sub txt_PA_Address3_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_PA_Address3.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Cbo_PCity.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub

    Private Sub txt_PA_PinCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_PA_PinCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_PA_Phone.Focus()
        End If
    End Sub

    Private Sub txt_PA_PinCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PA_PinCode.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                e.Handled = True
                'MsgBox(" Numbers only ")
            End If
        End If
    End Sub
    Private Sub txt_PA_Phone_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_PA_Phone.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_PA_Phone2.Focus()
        End If
    End Sub
    Private Sub txt_PA_Phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PA_Phone.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                e.Handled = True
                'MsgBox(" Numbers only ")
            End If
        End If
    End Sub
    Private Sub txt_PA_Phone2_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_PA_Phone2.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_PA_Mobile.Focus()
        End If
    End Sub

    Private Sub txt_PA_Phone2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PA_Phone2.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                e.Handled = True
                'MsgBox(" Numbers only ")
            End If
        End If
    End Sub
    Private Sub txt_PA_Mobile_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_PA_Mobile.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_PA_Email.Focus()
        End If
    End Sub

    Private Sub txt_PA_Mobile_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_PA_Mobile.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                e.Handled = True
                'MsgBox(" Numbers only ")
            End If
        End If
    End Sub
    Private Sub txt_PA_Email_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_PA_Email.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_BA_Address1.Focus()
        End If
    End Sub
    Private Sub txt_PA_Email_Validating(sender As Object, e As CancelEventArgs) Handles txt_PA_Email.Validating
        'getEmail(txt_PA_Email)
        Dim email As String = txt_PA_Email.Text
        If EmailAddressCheck(email) = False Then

            Dim result As DialogResult _
            = MessageBox.Show("The email address you entered is not valid." & _
                                       " Do you want re-enter it?", "Invalid Email Address", _
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            If result = Windows.Forms.DialogResult.Yes Then
                e.Cancel = True
            End If

        End If
    End Sub
    Function EmailAddressCheck(ByVal emailAddress As String) As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]" & _
        "*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)
        If emailAddressMatch.Success Then
            EmailAddressCheck = True
        Else
            EmailAddressCheck = False
        End If
    End Function

    Private Sub chk_ContactAddress1_CheckedChanged(sender As Object, e As EventArgs) Handles chk_ContactAddress1.CheckedChanged
        chk_ContactAddress3.Checked = False
        chk_ContactAddress2.Checked = False
    End Sub

    Private Sub txt_BA_Address1_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_BA_Address1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txt_PA_Address2.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub

    Private Sub txt_BA_Address1_TextChanged(sender As Object, e As EventArgs) Handles txt_BA_Address1.TextChanged

    End Sub

    Private Sub txt_BA_Address2_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_BA_Address2.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_BA_Address3.Focus()
        End If
    End Sub

    Private Sub txt_BA_Address2_TextChanged(sender As Object, e As EventArgs) Handles txt_BA_Address2.TextChanged

    End Sub

    Private Sub txt_PA_Address2_TextChanged(sender As Object, e As EventArgs) Handles txt_PA_Address2.TextChanged

    End Sub

    Private Sub txt_BA_Address3_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_BA_Address3.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cbo_BCity.Focus()
        End If
    End Sub

    Private Sub txt_BA_Address3_TextChanged(sender As Object, e As EventArgs) Handles txt_BA_Address3.TextChanged

    End Sub

    Private Sub txt_BA_PinCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_BA_PinCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_BA_PhoneNo.Focus()
        End If
    End Sub

    Private Sub txt_BA_PinCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_BA_PinCode.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                e.Handled = True
                'MsgBox(" Numbers only ")
            End If
        End If
    End Sub

    Private Sub txt_BA_PinCode_TextChanged(sender As Object, e As EventArgs) Handles txt_BA_PinCode.TextChanged

    End Sub

    Private Sub txt_BA_PhoneNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_BA_PhoneNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_BA_PhoneNo2.Focus()
        End If
    End Sub

    Private Sub txt_BA_PhoneNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_BA_PhoneNo.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                e.Handled = True
                'MsgBox(" Numbers only ")
            End If
        End If
    End Sub

    Private Sub txt_BA_PhoneNo_TextChanged(sender As Object, e As EventArgs) Handles txt_BA_PhoneNo.TextChanged

    End Sub

    Private Sub txt_BA_PhoneNo2_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_BA_PhoneNo2.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_BA_MobileNo.Focus()
        End If
    End Sub

    Private Sub txt_BA_PhoneNo2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_BA_PhoneNo2.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                e.Handled = True
                'MsgBox(" Numbers only ")
            End If
        End If
    End Sub

    Private Sub txt_BA_PhoneNo2_TextChanged(sender As Object, e As EventArgs) Handles txt_BA_PhoneNo2.TextChanged

    End Sub

    Private Sub txt_BA_MobileNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_BA_MobileNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_BA_Email.Focus()
        End If
    End Sub

    Private Sub txt_BA_MobileNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_BA_MobileNo.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                e.Handled = True
                'MsgBox(" Numbers only ")
            End If
        End If
    End Sub

    Private Sub txt_BA_MobileNo_TextChanged(sender As Object, e As EventArgs) Handles txt_BA_MobileNo.TextChanged

    End Sub

    Private Sub txt_BA_Email_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_BA_Email.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_RA_Address1.Focus()
        End If
    End Sub

    Private Sub txt_BA_Email_TextChanged(sender As Object, e As EventArgs) Handles txt_BA_Email.TextChanged

    End Sub

    Private Sub txt_BA_Email_Validating(sender As Object, e As CancelEventArgs) Handles txt_BA_Email.Validating
        Dim email As String = txt_BA_Email.Text
        If EmailAddressCheck(email) = False Then

            Dim result As DialogResult _
            = MessageBox.Show("The email address you entered is not valid." & _
                                       " Do you want re-enter it?", "Invalid Email Address", _
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            If result = Windows.Forms.DialogResult.Yes Then
                e.Cancel = True
            End If

        End If
    End Sub

    Private Sub chk_ContactAddress2_CheckedChanged(sender As Object, e As EventArgs) Handles chk_ContactAddress2.CheckedChanged
        chk_ContactAddress1.Checked = False
        chk_ContactAddress3.Checked = False
    End Sub

    Private Sub txt_RA_Address1_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_RA_Address1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_RA_Address2.Focus()
        End If
    End Sub

    Private Sub txt_RA_Address1_TextChanged(sender As Object, e As EventArgs) Handles txt_RA_Address1.TextChanged

    End Sub

    Private Sub txt_RA_Address2_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_RA_Address2.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_RA_Address3.Focus()
        End If
    End Sub

    Private Sub txt_RA_Address2_TextChanged(sender As Object, e As EventArgs) Handles txt_RA_Address2.TextChanged

    End Sub

    Private Sub txt_RA_Address3_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_RA_Address3.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cbo_CCity.Focus()
        End If
    End Sub

    Private Sub txt_RA_Address3_TextChanged(sender As Object, e As EventArgs) Handles txt_RA_Address3.TextChanged

    End Sub

    Private Sub txt_RA_PinCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_RA_PinCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_RA_PhoneNo.Focus()
        End If
    End Sub

    Private Sub txt_RA_PinCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_RA_PinCode.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                e.Handled = True
                'MsgBox(" Numbers only ")
            End If
        End If
    End Sub

    Private Sub txt_RA_PinCode_TextChanged(sender As Object, e As EventArgs) Handles txt_RA_PinCode.TextChanged

    End Sub

    Private Sub txt_RA_PhoneNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_RA_PhoneNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_RA_PhoneNo2.Focus()
        End If
    End Sub

    Private Sub txt_RA_PhoneNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_RA_PhoneNo.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                e.Handled = True
                'MsgBox(" Numbers only ")
            End If
        End If
    End Sub

    Private Sub txt_RA_PhoneNo_TextChanged(sender As Object, e As EventArgs) Handles txt_RA_PhoneNo.TextChanged

    End Sub

    Private Sub txt_RA_PhoneNo2_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_RA_PhoneNo2.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_RA_MobileNo.Focus()
        End If
    End Sub

    Private Sub txt_RA_PhoneNo2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_RA_PhoneNo2.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                e.Handled = True
                'MsgBox(" Numbers only ")
            End If
        End If
    End Sub

    Private Sub txt_RA_PhoneNo2_TextChanged(sender As Object, e As EventArgs) Handles txt_RA_PhoneNo2.TextChanged

    End Sub

    Private Sub txt_RA_MobileNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_RA_MobileNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_RA_Email.Focus()
        End If
    End Sub

    Private Sub txt_RA_MobileNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_RA_MobileNo.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                e.Handled = True
                'MsgBox(" Numbers only ")
            End If
        End If
    End Sub

    Private Sub txt_RA_MobileNo_TextChanged(sender As Object, e As EventArgs) Handles txt_RA_MobileNo.TextChanged

    End Sub

    Private Sub txt_RA_Email_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_RA_Email.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_add.Focus()
        End If
    End Sub

    Private Sub txt_RA_Email_TextChanged(sender As Object, e As EventArgs) Handles txt_RA_Email.TextChanged

    End Sub

    Private Sub txt_RA_Email_Validating(sender As Object, e As CancelEventArgs) Handles txt_RA_Email.Validating
        Dim email As String = txt_RA_Email.Text
        If EmailAddressCheck(email) = False Then

            Dim result As DialogResult _
            = MessageBox.Show("The email address you entered is not valid." & _
                                       " Do you want re-enter it?", "Invalid Email Address", _
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            If result = Windows.Forms.DialogResult.Yes Then
                e.Cancel = True
            End If

        End If
    End Sub

    Private Sub chk_ContactAddress3_CheckedChanged(sender As Object, e As EventArgs) Handles chk_ContactAddress3.CheckedChanged
        chk_ContactAddress1.Checked = False
        chk_ContactAddress2.Checked = False
    End Sub
    Public Function CheckDBNull(ByVal obj As Object, Optional ByVal ObjectType As enumObjectType = enumObjectType.StrType) As Object
        Dim objReturn As Object
        objReturn = obj
        If ObjectType = enumObjectType.StrType And IsDBNull(obj) Then
            objReturn = ""
        ElseIf ObjectType = enumObjectType.IntType And IsDBNull(obj) Then
            objReturn = 0
        ElseIf ObjectType = enumObjectType.DblType And IsDBNull(obj) Then
            objReturn = 0.0
        End If
        Return objReturn
    End Function
    Enum enumObjectType
        StrType = 0
        IntType = 1
        DblType = 2
    End Enum

    Private Sub grd_depedent_Advance(sender As Object, e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles grd_depedent.Advance

    End Sub

    Private Sub grd_depedent_ClickEvent(sender As Object, e As AxFPSpreadADO._DSpreadEvents_ClickEvent) Handles grd_depedent.ClickEvent
        Try
            With grd_depedent
                If grd_depedent.ActiveCol = 9 Then
                    Dim file As New OpenFileDialog
                    file.Filter = " Jpg(*.Jpg) | *.jpg"
                    If Trim(txt_MemberCode.Text) <> "" Then
                        If file.ShowDialog = DialogResult.OK Then
                            .Col = 9
                            .Row = .ActiveRow
                            grd_depedent.TypePictPicture = New Bitmap(file.FileName)
                            'strPhotoFilePath = file.FileName
                            .Col = 9
                            .Row = .ActiveRow
                            .Text = file.FileName
                        End If
                    End If
                End If
                If grd_depedent.ActiveCol = 10 Then
                    Dim file As New OpenFileDialog
                    file.Filter = " Jpg(*.Jpg) | *.jpg"
                    If Trim(txt_MemberCode.Text) <> "" Then
                        If file.ShowDialog = DialogResult.OK Then
                            .Col = 10
                            .Row = .ActiveRow
                            grd_depedent.TypePictPicture = New Bitmap(file.FileName)
                            'strPhotoFilePath = file.FileName
                            .Col = 10
                            .Row = .ActiveRow
                            .Text = file.FileName
                        End If
                    End If
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub

    Private Sub grd_depedent_KeyDownEvent(sender As Object, e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles grd_depedent.KeyDownEvent
        Try
            If e.keyCode = Keys.F2 Then
                grd_depedent.InsertRows(grd_depedent.ActiveRow, 1)
            End If
            If e.keyCode = Keys.F3 Then
                grd_depedent.DeleteRows(grd_depedent.ActiveRow, 1)
                grd_depedent.SetActiveCell(1, grd_depedent.ActiveRow)
            End If
            If e.keyCode = Keys.Enter Then
                If grd_depedent.ActiveRow = 3 And grd_depedent.ActiveCol = 7 Then
                End If
            End If
            If e.keyCode = Keys.Enter Then
                With grd_depedent
                    If grd_depedent.ActiveCol = 1 Then
                        .Row = .ActiveRow
                        .Col = 1
                        If (.Text) <> "" Then
                            .SetActiveCell(2, .ActiveRow)
                        Else
                            .SetActiveCell(1, .ActiveRow)
                        End If
                    End If
                    If .ActiveCol = 2 Then
                        .Row = .ActiveRow
                        .Col = 2
                        If (.Text) <> "" Then
                            .SetActiveCell(3, .ActiveRow)
                        Else
                            .SetActiveCell(2, .ActiveRow)
                        End If
                    End If
                    If .ActiveCol = 3 Then
                        .Row = .ActiveRow
                        .Col = 3
                        If (.Text) <> "" Then
                            .SetActiveCell(4, .ActiveRow)
                        Else
                            .SetActiveCell(3, .ActiveRow)
                        End If
                    End If
                    If .ActiveCol = 4 Then
                        .Row = .ActiveRow
                        .Col = 4
                        If (.Text) <> "" Then
                            .SetActiveCell(5, .ActiveRow)
                        Else
                            .SetActiveCell(4, .ActiveRow)
                        End If
                    End If
                    If .ActiveCol = 5 Then
                        .Row = .ActiveRow
                        .Col = 5
                        If (.Text) <> "" Then
                            .SetActiveCell(9, .ActiveRow)
                        Else
                            .SetActiveCell(5, .ActiveRow)
                        End If
                    End If


                    If grd_depedent.ActiveCol = 9 Then
                        grd_depedent.Row = grd_depedent.ActiveRow
                        grd_depedent.Col = 9
                        Dim file As New OpenFileDialog
                        file.Filter = " Jpg(*.Jpg) | *.jpg"
                        If Trim(txt_MemberCode.Text) <> "" Then
                            If file.ShowDialog = DialogResult.OK Then
                                grd_depedent.Col = 9
                                grd_depedent.Row = grd_depedent.ActiveRow
                                grd_depedent.TypePictPicture = New Bitmap(file.FileName)
                                ''strPhotoFilePath = file.FileName
                                grd_depedent.Col = 11
                                grd_depedent.Row = grd_depedent.ActiveRow
                                grd_depedent.Text = file.FileName
                            End If
                        End If

                    End If

                    If grd_depedent.ActiveCol = 10 Then
                        grd_depedent.Row = grd_depedent.ActiveRow
                        grd_depedent.ActiveCol = 10
                        Dim file As New OpenFileDialog
                        file.Filter = " Jpg(*.Jpg) | *.jpg"
                        If Trim(txt_MemberCode.Text) <> "" Then
                            If file.ShowDialog = DialogResult.OK Then
                                grd_depedent.Col = 10
                                grd_depedent.Row = grd_depedent.ActiveRow
                                grd_depedent.TypePictPicture = New Bitmap(file.FileName)
                                ''strPhotoFilePath = file.FileName

                            End If
                        End If
                    End If

                    If .ActiveCol = 10 Then
                        .Row = .ActiveRow
                        .Col = 10
                        'If (.Text) <> "" Then
                        '    .SetActiveCell(9, .ActiveRow)
                        'Else
                        '    .SetActiveCell(5, .ActiveRow)
                        'End If

                        .SetActiveCell(1, .ActiveRow + 1)
                    End If
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub

    Private Sub Txt_APPLNO_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_APPLNO.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Txt_APPLNO.Text = "" Then
                    MessageBox.Show("Application Number Should not be Blank", gcompanyname, MessageBoxButtons.OK)
                Else
                    txt_applno_valid()

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub
    Private Sub txt_applno_valid()
        'sqlstring = "select ISNULL(applno,'') AS MNAME,isnull(DOB,'') as DOB from membermaster where mcode='" & txt_MemberCode.Text & "'"
        'gconnection.getDataSet(sqlstring, "membermaster")
        'If gdataset.Tables("membermaster").Rows.Count > 0 Then
        '    txt_membername.Text = CheckDBNull(gdataset.Tables("membermaster").Rows(0).Item("mname"))
        '    dtp_DOB.Text = Format(CDate(gdataset.Tables("membermaster").Rows(0).Item("DOB")), "dd/MMM/yyyy")
        'End If
        dtp_ApplnDate.Focus()



    End Sub
    Private Sub Txt_APPLNO_TextChanged(sender As Object, e As EventArgs) Handles Txt_APPLNO.TextChanged

    End Sub

    Private Sub dtp_ApplnDate_KeyDown(sender As Object, e As KeyEventArgs) Handles dtp_ApplnDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txt_pancarno.Focus()
        End If
    End Sub

    Private Sub dtp_ApplnDate_ValueChanged(sender As Object, e As EventArgs) Handles dtp_ApplnDate.ValueChanged

    End Sub

    Private Sub Txt_pancarno_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_pancarno.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Txt_pancarno.Text = "" Then
                    Txt_pancarno.Focus()
                Else
                    Txt_BloodGroup.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub


    Private Sub Txt_pancarno_TextChanged(sender As Object, e As EventArgs) Handles Txt_pancarno.TextChanged

    End Sub

    Private Sub txt_CreditNumber_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_CreditNumber.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                'txt_spl_info.Focus()
                txt_passportno.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub

    Private Sub txt_CreditNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_CreditNumber.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                e.Handled = True
                'MsgBox(" Numbers only ")
            End If
        End If
    End Sub

    Private Sub txt_CreditNumber_TextChanged(sender As Object, e As EventArgs) Handles txt_CreditNumber.TextChanged

    End Sub

    Private Sub Txt_BloodGroup_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_BloodGroup.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Txt_BloodGroup.Text = "" Then
                    Txt_BloodGroup.Focus()
                Else
                    txt_CreditNumber.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub

    Private Sub grd_Entfee_Advance(sender As Object, e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles grd_Entfee.Advance

    End Sub

    Private Sub grd_Entfee_KeyDownEvent(sender As Object, e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles grd_Entfee.KeyDownEvent
        Try
            If e.keyCode = Keys.F2 Then
                grd_Entfee.InsertRows(grd_Entfee.ActiveRow, 1)
            End If
            If e.keyCode = Keys.F3 Then
                grd_Entfee.DeleteRows(grd_Entfee.ActiveRow, 1)
                grd_Entfee.SetActiveCell(1, grd_Entfee.ActiveRow)
            End If
            If e.keyCode = Keys.Enter Then
                If grd_Entfee.ActiveRow = 3 And grd_Entfee.ActiveCol = 7 Then
                End If
            End If
            If e.keyCode = Keys.Enter Then
                With grd_Entfee
                    If grd_Entfee.ActiveCol = 1 Then
                        .Row = .ActiveRow
                        .Col = 1
                        If (.Text) <> "" Then
                            .SetActiveCell(2, .ActiveRow)
                        Else
                            .SetActiveCell(1, .ActiveRow)
                        End If
                    End If
                    If .ActiveCol = 2 Then
                        .Row = .ActiveRow
                        .Col = 2
                        If (.Text) <> "" Then
                            .SetActiveCell(3, .ActiveRow)
                        Else
                            .SetActiveCell(2, .ActiveRow)
                        End If
                    End If
                    If .ActiveCol = 3 Then
                        .Row = .ActiveRow
                        .Col = 3
                        If (.Text) <> "" Then
                            .SetActiveCell(1, .ActiveRow + 1)
                        Else
                            .SetActiveCell(3, .ActiveRow)
                        End If
                    End If
                End With

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub

    Private Sub txt_ProposerCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ProposerCode.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt_ProposerCode.Text = "" Then
                    cmd_ProposerCodeHelp_Click(sender, e)
                Else
                    Call txt_ProposerCode_Validated(sender, e)
                End If
            ElseIf e.KeyCode = Keys.F4 Then
                cmd_ProposerCodeHelp_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub

    Private Sub txt_ProposerCode_TextChanged(sender As Object, e As EventArgs) Handles txt_ProposerCode.TextChanged

    End Sub

    Private Sub cmd_ProposerCodeHelp_Click(sender As Object, e As EventArgs) Handles cmd_ProposerCodeHelp.Click
        Dim vform As New LIST_OPERATION1
        gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM membermaster"
        M_WhereCondition = " "
        vform.Field = "MCODE,MNAME"
        vform.vCaption = "Proposer Master Help"
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_ProposerCode.Text = Trim(vform.keyfield & "")
            'txt_Proposername.Text = Trim(vform.keyfield1)
            'txt_SeconderCode1.Focus()
            Call txt_ProposerCode_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub txt_SeconderCode1_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_SeconderCode1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt_SeconderCode1.Text = "" Then
                    cmd_SeconderCodeHelp_Click(sender, e)
                Else
                    Call txt_SeconderCode1_Validated(sender, e)
                End If
            ElseIf e.KeyCode = Keys.F4 Then
                cmd_SeconderCodeHelp_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try

    End Sub

    Private Sub txt_SeconderCode1_TextChanged(sender As Object, e As EventArgs) Handles txt_SeconderCode1.TextChanged

    End Sub

    Private Sub cmd_SeconderCodeHelp_Click(sender As Object, e As EventArgs) Handles cmd_SeconderCodeHelp.Click
        Dim vform As New LIST_OPERATION1
        gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM membermaster"
        M_WhereCondition = " "
        vform.Field = "MCODE,MNAME"
        vform.vCaption = "Seconder Master Help"
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_SeconderCode1.Text = Trim(vform.keyfield & "")
            'txt_SeconderName1.Text = Trim(vform.keyfield1)
            'txt_SeconderCode2.Focus()
            Call txt_SeconderCode1_Validated(sender, e)

        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub txt_SeconderCode2_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_SeconderCode2.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt_SeconderCode2.Text = "" Then
                    Button1_Click(sender, e)
                Else
                    Call txt_SeconderCode2_Validated(sender, e)
                End If
            ElseIf e.KeyCode = Keys.F4 Then
                Button1_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub

    Private Sub txt_SeconderCode2_TextChanged(sender As Object, e As EventArgs) Handles txt_SeconderCode2.TextChanged

    End Sub

    Private Sub txt_ProposerCode_Validated(sender As Object, e As EventArgs) Handles txt_ProposerCode.Validated
        Dim I, J As Integer

        Sqlstr = " SELECT isnull(mcode,'')as mcode,isnull(mname,'') as Mname FROM membermaster WHERE mcode='" & txt_ProposerCode.Text & "'"
        gconnection.getDataSet(Sqlstr, "MemMst")

        If gdataset.Tables("MemMst").Rows.Count > 0 Then
            txt_ProposerCode.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("Mcode"))
            txt_Proposername.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("Mname"))
            txt_SeconderCode1.Focus()
        End If
    End Sub

    Private Sub txt_SeconderCode1_Validated(sender As Object, e As EventArgs) Handles txt_SeconderCode1.Validated
        Dim I, J As Integer

        Sqlstr = " SELECT isnull(mcode,'')as mcode,isnull(mname,'') as Mname FROM membermaster WHERE mcode='" & txt_SeconderCode1.Text & "'"
        gconnection.getDataSet(Sqlstr, "MemMst")

        If gdataset.Tables("MemMst").Rows.Count > 0 Then
            txt_SeconderCode1.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("Mcode"))
            txt_SeconderName1.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("Mname"))
            txt_SeconderCode2.Focus()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vform As New LIST_OPERATION1
        gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM membermaster"
        M_WhereCondition = " "
        vform.Field = "MCODE,MNAME"
        vform.vCaption = "Seconder Master Help"
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_SeconderCode2.Text = Trim(vform.keyfield & "")
            'txt_SeconderName1.Text = Trim(vform.keyfield1)
            'txt_SeconderCode2.Focus()
            Call txt_SeconderCode2_Validated(sender, e)

        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub txt_SeconderCode2_Validated(sender As Object, e As EventArgs) Handles txt_SeconderCode2.Validated
        Dim I, J As Integer

        Sqlstr = " SELECT isnull(mcode,'')as mcode,isnull(mname,'') as Mname FROM membermaster WHERE mcode='" & txt_SeconderCode2.Text & "'"
        gconnection.getDataSet(Sqlstr, "MemMst")

        If gdataset.Tables("MemMst").Rows.Count > 0 Then
            txt_SeconderCode2.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("Mcode"))
            txt_SeconderName2.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("Mname"))

        End If
    End Sub

    Private Sub Txt_companyName_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_companyName.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txt_turnover.Focus()
        End If
    End Sub

    Private Sub Txt_companyName_TextChanged(sender As Object, e As EventArgs) Handles Txt_companyName.TextChanged

    End Sub

    Private Sub Txt_turnover_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_turnover.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txt_Bussinessinfo.Focus()
        End If
    End Sub

    Private Sub Txt_turnover_TextChanged(sender As Object, e As EventArgs) Handles Txt_turnover.TextChanged

    End Sub

    Private Sub Txt_Bussinessinfo_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Bussinessinfo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txt_AgenttInfo.Focus()
        End If
    End Sub

    Private Sub Txt_Bussinessinfo_TextChanged(sender As Object, e As EventArgs) Handles Txt_Bussinessinfo.TextChanged

    End Sub

    Private Sub Txt_AgenttInfo_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_AgenttInfo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txt_products.Focus()
        End If
    End Sub

    Private Sub Txt_AgenttInfo_TextChanged(sender As Object, e As EventArgs) Handles Txt_AgenttInfo.TextChanged

    End Sub

    Private Sub Txt_products_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_products.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txt_noofEmpolyee.Focus()
        End If
    End Sub

    Private Sub Txt_products_TextChanged(sender As Object, e As EventArgs) Handles Txt_products.TextChanged

    End Sub

    Private Sub Txt_noofEmpolyee_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_noofEmpolyee.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_occupation.Focus()
        End If
    End Sub

    Private Sub Txt_noofEmpolyee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_noofEmpolyee.KeyPress
        getNumeric(e)
    End Sub

    Private Sub Txt_noofEmpolyee_TextChanged(sender As Object, e As EventArgs) Handles Txt_noofEmpolyee.TextChanged

    End Sub

    Private Sub txt_occupation_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_occupation.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_add.Focus()
        End If
    End Sub

    Private Sub txt_occupation_TextChanged(sender As Object, e As EventArgs) Handles txt_occupation.TextChanged

    End Sub

    Private Sub grd_Education_Advance(sender As Object, e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles grd_Education.Advance

    End Sub

    Private Sub grd_Education_KeyDownEvent(sender As Object, e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles grd_Education.KeyDownEvent
        Try
            If e.keyCode = Keys.F2 Then
                grd_Education.InsertRows(grd_Education.ActiveRow, 1)
            End If
            If e.keyCode = Keys.F3 Then
                grd_Education.DeleteRows(grd_Education.ActiveRow, 1)
                grd_Education.SetActiveCell(1, grd_Education.ActiveRow)
            End If
            If e.keyCode = Keys.Enter Then
                If grd_Education.ActiveRow = 3 And grd_Education.ActiveCol = 7 Then
                End If
            End If
            If e.keyCode = Keys.Enter Then
                With grd_Education
                    If grd_Education.ActiveCol = 1 Then
                        .Row = .ActiveRow
                        .Col = 1
                        If (.Text) <> "" Then
                            .SetActiveCell(2, .ActiveRow)
                        Else
                            .SetActiveCell(1, .ActiveRow)
                        End If
                    End If
                    If .ActiveCol = 2 Then
                        .Row = .ActiveRow
                        .Col = 2
                        If (.Text) <> "" Then
                            .SetActiveCell(3, .ActiveRow)
                        Else
                            .SetActiveCell(2, .ActiveRow)
                        End If
                    End If
                    If .ActiveCol = 3 Then
                        .Row = .ActiveRow
                        .Col = 3
                        If (.Text) <> "" Then
                            .SetActiveCell(4, .ActiveRow)
                        Else
                            .SetActiveCell(3, .ActiveRow)
                        End If
                    End If
                    If .ActiveCol = 4 Then
                        .Row = .ActiveRow
                        .Col = 4
                        If (.Text) <> "" Then
                            .SetActiveCell(5, .ActiveRow)
                        Else
                            .SetActiveCell(4, .ActiveRow)
                        End If
                    End If
                    If .ActiveCol = 5 Then
                        .Row = .ActiveRow
                        .Col = 5
                        If (.Text) <> "" Then
                            .SetActiveCell(1, .ActiveRow + 1)
                        Else
                            .SetActiveCell(5, .ActiveRow)
                        End If
                    End If
                End With

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub

    Private Sub txt_spl_info_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_spl_info.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_add.Focus()

        End If
    End Sub

    Private Sub txt_spl_info_TextChanged(sender As Object, e As EventArgs) Handles txt_spl_info.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chk_sports.CheckedChanged
        If chk_sports.Checked = True Then
            grp_sports_inter.Visible = True
        Else
            grp_sports_inter.Visible = False

        End If
    End Sub

    Private Sub grp_sports_inter_Advance(sender As Object, e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles grp_sports_inter.Advance

    End Sub

    Private Sub grp_sports_inter_KeyDownEvent(sender As Object, e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles grp_sports_inter.KeyDownEvent
        If e.keyCode = Keys.F2 Then
            grp_sports_inter.InsertRows(grp_sports_inter.ActiveRow, 1)
        End If
        If e.keyCode = Keys.F3 Then
            grp_sports_inter.DeleteRows(grp_sports_inter.ActiveRow, 1)
            grp_sports_inter.SetActiveCell(1, grp_sports_inter.ActiveRow)
        End If
        If e.keyCode = Keys.Enter Then
            With grp_sports_inter
                If grp_sports_inter.ActiveCol = 1 Then
                    .Row = .ActiveRow
                    .Col = 1
                    If (.Text) <> "" Then
                        .SetActiveCell(2, .ActiveRow)
                    Else
                        .SetActiveCell(1, .ActiveRow)
                    End If
                End If
                If .ActiveCol = 2 Then
                    .Row = .ActiveRow
                    .Col = 2
                    If (.Text) <> "" Then
                        .SetActiveCell(3, .ActiveRow)
                    Else
                        .SetActiveCell(2, .ActiveRow)
                    End If
                End If
                If .ActiveCol = 3 Then
                    .Row = .ActiveRow
                    .Col = 3
                    If (.Text) <> "" Then
                        .SetActiveCell(1, .ActiveRow + 1)
                    Else
                        .SetActiveCell(3, .ActiveRow)
                    End If
                End If
            End With

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
            SSQLSTR2 = " SELECT * FROM MEMBERMASTER  WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER1,'')=''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH1USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH1USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE")
                If gdataset.Tables("AUTHORIZE").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND ISNULL(AUTHORIZELEVEL,0)>0 "
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM MEMBERMASTER  WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER1,'')=''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()


                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE MEMBERMASTER  set  ", "MCODE", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 1, 5)
                        End If
                    Else
                        MsgBox("NO AUTHORIZATION REQUIRED FOR THE ENTRY")
                    End If
                End If
            End If
        ElseIf USERT = 2 Then
            SSQLSTR2 = " SELECT * FROM MEMBERMASTER  WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')='' AND ISNULL(AUTHORISE_USER1,'')<>''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH2USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH2USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE1")
                If gdataset.Tables("AUTHORIZE1").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "'"
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM MEMBERMASTER  WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')=''AND ISNULL(AUTHORISE_USER1,'')<>''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()


                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE MEMBERMASTER  set  ", "MCODE", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 2, 5)
                        End If
                    End If
                End If
            End If
        ElseIf USERT = 3 Then
            SSQLSTR2 = " SELECT * FROM MEMBERMASTER  WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')=''AND ISNULL(AUTHORISE_USER1,'')<>''  AND ISNULL(AUTHORISE_USER2,'')<>''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH3USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH3USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE2")
                If gdataset.Tables("AUTHORIZE2").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "'"
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM MEMBERMASTER  WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')=''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()
                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE MEMBERMASTER  set  ", "MCODE", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 3, 5)
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
        STRQUERY = "SELECT * FROM MEMBERMASTER"
        gconnection.getDataSet(STRQUERY, "authorize")

        Call VIEW1.LOADGRID(gdataset.Tables("authorize"), True, "", "SELECT * FROM MEMBERMASTER", "membercode", 1, Me.txt_MemberCode)
    End Sub

    Private Sub txt_passportno_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_passportno.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                txt_spl_info.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try

    End Sub

    Private Sub txt_passportno_TextChanged(sender As Object, e As EventArgs) Handles txt_passportno.TextChanged

    End Sub

    Private Sub TXT_TITLE_TextChanged(sender As Object, e As EventArgs) Handles TXT_TITLE.TextChanged

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click
        'If txt_PA_Address1.Text <> "" Then
        '    txt_PA_Address1.Focus()
        'ElseIf txt_BA_Address1.Text <> "" Then
        '    txt_BA_Address1.Focus()
        'ElseIf txt_RA_Address1.Text <> "" Then
        '    txt_RA_Address1.Focus()
        'Else
        '    txt_PA_Address1.Focus()
        'End If
    End Sub

    Private Sub TXT_SPOUSEMOBILE_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_SPOUSEMOBILE.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TXT_SPOUSEMOBILE.Text = "" Then
                TXT_SPOUSEMOBILE.Focus()
            Else
                cbo_BillingBasis.Focus()
            End If
        End If
    End Sub

    Private Sub TXT_SPOUSEMOBILE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_SPOUSEMOBILE.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                e.Handled = True
                'MsgBox(" Numbers only ")
            End If
        End If
    End Sub

    Private Sub TXT_SPOUSEMOBILE_TextChanged(sender As Object, e As EventArgs) Handles TXT_SPOUSEMOBILE.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ChK_ECSYN_Click(sender As Object, e As EventArgs) Handles ChK_ECSYN.Click
        If ChK_ECSYN.Checked = True Then
            Me.Grp_ECSSETUP.Visible = True
            Me.Txt_MemAcType.ReadOnly = True
        Else
            Me.Grp_ECSSETUP.Visible = False
        End If
    End Sub

    Private Sub Cmb_MemAcType_Click(sender As Object, e As EventArgs) Handles Cmb_MemAcType.Click
        If Cmb_MemAcType.Text = "SB" Then
            Txt_MemAcType.Text = "10"
        Else
            Txt_MemAcType.Text = "11"
        End If
    End Sub

    Private Sub Cmb_MemAcType_KeyDown(sender As Object, e As KeyEventArgs) Handles Cmb_MemAcType.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txt_Amount.Focus()
        End If
    End Sub

    Private Sub Cmb_MemAcType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_MemAcType.SelectedIndexChanged
        If Cmb_MemAcType.Text = "SB" Then
            Txt_MemAcType.Text = "10"
        Else
            Txt_MemAcType.Text = "11"
        End If
    End Sub

    Private Sub Txt_DRCR_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_DRCR.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txt_MemMICR.Focus()
        End If
    End Sub

    'Private Sub Txt_DRCR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_DRCR.KeyPress
    '    If Txt_DRCR.Text <> "" Then
    '        Txt_MemMICR.Focus()
    '    End If
    'End Sub
    Private Sub Txt_MemMICR_keydown(sender As Object, e As KeyEventArgs) Handles Txt_MemMICR.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txt_OurUID.Focus()
        End If
    End Sub

    Private Sub Txt_OurUID_keydown(sender As Object, e As KeyEventArgs) Handles Txt_OurUID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txt_MemBankAccNo.Focus()
        End If
    End Sub

    Private Sub Txt_MemBankAccNo_keydown(sender As Object, e As KeyEventArgs) Handles Txt_MemBankAccNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cmb_MemAcType.Focus()
        End If
    End Sub

    Private Sub Label73_Click(sender As Object, e As EventArgs) Handles Label73.Click

    End Sub

    Private Sub Txt_batch_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_batch.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Txt_batch.Text = "" Then
                    Btn_batch_Click(sender, e)
                Else
                    txt_batch_valid()
                End If
            ElseIf e.KeyCode = Keys.F4 Then
                Btn_batch_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub

    Private Sub Txt_batch_LostFocus(sender As Object, e As EventArgs) Handles Txt_batch.LostFocus
        Me.Txt_batch.BackColor = White
    End Sub

    Private Sub Txt_batch_MouseDown(sender As Object, e As MouseEventArgs) Handles Txt_batch.MouseDown

    End Sub

    Private Sub Txt_batch_MouseEnter(sender As Object, e As EventArgs) Handles Txt_batch.MouseEnter

    End Sub

    Private Sub Txt_batch_TextChanged(sender As Object, e As EventArgs) Handles Txt_batch.TextChanged

    End Sub

    Private Sub Btn_batch_Click(sender As Object, e As EventArgs) Handles Btn_batch.Click
        Dim vform As New LIST_OPERATION1
        gSQLString = "Select batchno,mcode from memberMaster"
        M_WhereCondition = " "
        vform.Field = "batchno,mcode"
        vform.vCaption = "Batch No Master Help"
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            Txt_batch.Text = Trim(vform.keyfield & "")
            Call txt_batch_valid()
        End If
        vform.Close()
        vform = Nothing
    End Sub
End Class





