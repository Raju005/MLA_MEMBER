Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class DEPENDET

    Dim gconnection As New GlobalClass
    Dim vconn As New GlobalClass
    Dim boolchk As Boolean
    Dim txtobj1 As TextObject
    Dim Iteration, I, J As Integer
    Dim sqlstring As String
    Dim dt As DataTable
    Private Sub DEPENDET_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
                    ' Call btn_print_Click(sender, e)
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
    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gPrint = False

    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gPrint = True
        'Call ViewDeptRegister1()
    End Sub



    Private Sub ViewDeptRegister1()
        Try
            Dim sqlstring As String
            sqlstring = "SELECT * FROM MM_Dependent_BELOW"
            Dim o As Object
            txt_dependent.Text = ""
            Call Validation()
            If boolchk = False Then Exit Sub
            For Each o In CHK_DEPENDET.CheckedItems
                txt_dependent.Text += "'" & o.ToString() & "',"
            Next o
            If (txt_dependent.Text <> "") Then
                sqlstring = sqlstring & " where RELATION in (" & txt_dependent.Text.Substring(0, txt_dependent.Text.Length - 1) & ")"
            End If
            sqlstring = sqlstring & " and age between '" & FROMAGE.Text & "' AND '" & TOAGE.Text & "' "
            Dim Viewer As New REPORTVIEWER
            Dim r As New Cry_dependency
            Viewer.ssql = sqlstring
            txtobj1 = r.ReportDefinition.ReportObjects("Text1")
            txtobj1.Text = UCase(gCompanyname)
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
            txtobj1 = r.ReportDefinition.ReportObjects("Text6")
            txtobj1.Text = UCase(gCompanyAddress(5))

            txtobj1 = r.ReportDefinition.ReportObjects("Text25")
            txtobj1.Text = UCase(gFinancalyearStart)
            txtobj1 = r.ReportDefinition.ReportObjects("Text22")
            txtobj1.Text = UCase(gFinancialyearEnd)
            txtobj1 = r.ReportDefinition.ReportObjects("Text9")
            txtobj1.Text = UCase(gUsername)


            txtobj1 = r.ReportDefinition.ReportObjects("Text14")
            txtobj1.Text = FROMAGE.Text
            txtobj1 = r.ReportDefinition.ReportObjects("Text16")
            txtobj1.Text = TOAGE.Text

            Viewer.Report = r
            Viewer.TableName = "MM_Dependent_BELOW"
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Validation()
        boolchk = False
        If IsNumeric(FROMAGE.Text) = False Then

            MessageBox.Show("Not a Valid From Age", gCompanyname)
            Exit Sub
        End If
        If FROMAGE.Text < 1 Then
            MessageBox.Show("Not a Valid From Age", gCompanyname)
            Exit Sub
        End If
        If IsNumeric(FROMAGE.Text) = True And IsNumeric(TOAGE.Text) = True Then
            If Val(FROMAGE.Text) > Val(TOAGE.Text) Then
                MessageBox.Show("From Age Should be Lesser or Equal  To Date", gCompanyname)
                Exit Sub
            End If
        End If
        If IsNumeric(TOAGE.Text) = False Then

            MessageBox.Show("Not a Valid To Age", gCompanyname)
            Exit Sub
        End If
        If TOAGE.Text < 1 Then
            MessageBox.Show("Not a Valid To Age", gCompanyname)
            Exit Sub
        End If


        boolchk = True
    End Sub

    'Private Sub D2_Register_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
    '    Try
    '        If e.KeyCode = Keys.F6 Then
    '            If btn_clear.Enabled = True Then
    '                Call btn_clear_Click(sender, e)
    '                Exit Sub
    '            End If
    '        ElseIf e.KeyCode = Keys.F9 Then
    '            If btn_view.Enabled = True Then
    '                Call btn_view_Click(sender, e)
    '                Exit Sub
    '            End If
    '        ElseIf e.KeyCode = Keys.F12 Then
    '            If btn_print.Enabled = True Then
    '                ' Call btn_print_Click(sender, e)
    '                Exit Sub
    '            End If
    '        ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
    '            If btn_exit.Enabled = True Then
    '                Call btn_exit_Click(sender, e)
    '                Exit Sub
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    Private Sub Cmb_FromDate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmb_FromDate.KeyPress

    End Sub

    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cmb_FromDate.Text = Now.Today
        FROMAGE.Text = ""
        TOAGE.Text = ""

        ' If e.Keys = Keys.Enter Then


    End Sub

    Private Sub dependentListRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load_dependent()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        Show()
        Me.Cmb_FromDate.Focus()

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



    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub





    Private Sub tbx_Filter_From_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub tbx_Filter_From_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'If tbx_Filter_From.Text = "" Then
        '    If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F4 Then
        '        cmd_MCodefromHelp_Click(sender, e)
        '    End If
        'End If
        'tbx_filter_To.Focus()

    End Sub

    Private Sub tbx_filter_To_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub year_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles year.CheckedChanged

    End Sub









    Private Sub Chk_SelectALLDep_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_SelectALLDep.CheckedChanged
        Try
            If Chk_SelectALLDep.Checked = True Then
                For Iteration = 0 To (CHK_DEPENDET.Items.Count - 1)
                    CHK_DEPENDET.SetSelected(Iteration, True)
                    CHK_DEPENDET.SetItemChecked(Iteration, True)
                Next
            Else
                For Iteration = 0 To (CHK_DEPENDET.Items.Count - 1)
                    CHK_DEPENDET.SetItemChecked(Iteration, False)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Load_dependent()
        Dim i, Iteration As Integer
        sqlstring = "select distinct isnull(RELATION,'')as RELATION from MEMDET where isnull(RELATION,'')<>'' "
        dt = gconnection.GetValues(sqlstring)
        For Iteration = 0 To (dt.Rows.Count - 1)
            CHK_DEPENDET.Items.Add(dt.Rows(Iteration).Item("RELATION"))
        Next

    End Sub



    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        ViewDeptRegister1()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        FROMAGE.Text = ""
        TOAGE.Text = ""

        Chk_SelectALLDep.Checked = False
        Call Chk_SelectALLDep_CheckedChanged(sender, e)
        FROMAGE.Focus()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub FROMAGE_KeyDown(sender As Object, e As KeyEventArgs) Handles FROMAGE.KeyDown
        If e.KeyCode = Keys.Enter Then
            TOAGE.Focus()
        End If
    End Sub

    Private Sub FROMAGE_TextChanged(sender As Object, e As EventArgs) Handles FROMAGE.TextChanged

    End Sub
End Class