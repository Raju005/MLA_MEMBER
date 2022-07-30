Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient
Public Class FRM_MKGA_SubscriptionTagging
    Inherits System.Windows.Forms.Form
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Public WithEvents Label124 As System.Windows.Forms.Label
    Friend WithEvents lbl_MembeName As System.Windows.Forms.Label
    Friend WithEvents lbl_MemberCode As System.Windows.Forms.Label
    Friend WithEvents chkList_Subscription As System.Windows.Forms.CheckedListBox
    Friend WithEvents txt_MemberName As System.Windows.Forms.TextBox
    Friend WithEvents cmd_MemberCodeHelp As System.Windows.Forms.Button
    Friend WithEvents Cmd_exit As System.Windows.Forms.Button
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_add As System.Windows.Forms.Button
    Friend WithEvents Cmd_freeze As System.Windows.Forms.Button
    Friend WithEvents Cmd_view As System.Windows.Forms.Button
    Friend WithEvents Grp_Print As System.Windows.Forms.GroupBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Frez As System.Windows.Forms.Label
    Friend WithEvents Browse As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Gr2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_exit1 As System.Windows.Forms.Button
    Friend WithEvents CMD_WINDOWS As System.Windows.Forms.Button
    Friend WithEvents CMD_DOS As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_MemberCode As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_MKGA_SubscriptionTagging))
        Me.lbl_MembeName = New System.Windows.Forms.Label()
        Me.lbl_MemberCode = New System.Windows.Forms.Label()
        Me.Label124 = New System.Windows.Forms.Label()
        Me.chkList_Subscription = New System.Windows.Forms.CheckedListBox()
        Me.txt_MemberName = New System.Windows.Forms.TextBox()
        Me.cmd_MemberCodeHelp = New System.Windows.Forms.Button()
        Me.txt_MemberCode = New System.Windows.Forms.TextBox()
        Me.Cmd_exit = New System.Windows.Forms.Button()
        Me.cmd_Clear = New System.Windows.Forms.Button()
        Me.Cmd_add = New System.Windows.Forms.Button()
        Me.Cmd_freeze = New System.Windows.Forms.Button()
        Me.Cmd_view = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Frez = New System.Windows.Forms.Label()
        Me.Browse = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Gr2 = New System.Windows.Forms.GroupBox()
        Me.cmd_exit1 = New System.Windows.Forms.Button()
        Me.CMD_WINDOWS = New System.Windows.Forms.Button()
        Me.CMD_DOS = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.Gr2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_MembeName
        '
        Me.lbl_MembeName.AutoSize = True
        Me.lbl_MembeName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MembeName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MembeName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_MembeName.Location = New System.Drawing.Point(279, 29)
        Me.lbl_MembeName.Name = "lbl_MembeName"
        Me.lbl_MembeName.Size = New System.Drawing.Size(96, 15)
        Me.lbl_MembeName.TabIndex = 12
        Me.lbl_MembeName.Text = "Member Name :"
        '
        'lbl_MemberCode
        '
        Me.lbl_MemberCode.AutoSize = True
        Me.lbl_MemberCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MemberCode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MemberCode.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_MemberCode.Location = New System.Drawing.Point(21, 29)
        Me.lbl_MemberCode.Name = "lbl_MemberCode"
        Me.lbl_MemberCode.Size = New System.Drawing.Size(95, 15)
        Me.lbl_MemberCode.TabIndex = 11
        Me.lbl_MemberCode.Text = "Member  Code :"
        '
        'Label124
        '
        Me.Label124.AutoSize = True
        Me.Label124.BackColor = System.Drawing.Color.Transparent
        Me.Label124.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label124.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label124.ForeColor = System.Drawing.Color.Black
        Me.Label124.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label124.Location = New System.Drawing.Point(15, 16)
        Me.Label124.Name = "Label124"
        Me.Label124.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label124.Size = New System.Drawing.Size(131, 16)
        Me.Label124.TabIndex = 14
        Me.Label124.Text = "Select Subscription"
        Me.Label124.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'chkList_Subscription
        '
        Me.chkList_Subscription.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chkList_Subscription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.chkList_Subscription.ColumnWidth = 25
        Me.chkList_Subscription.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkList_Subscription.Location = New System.Drawing.Point(17, 40)
        Me.chkList_Subscription.Name = "chkList_Subscription"
        Me.chkList_Subscription.ScrollAlwaysVisible = True
        Me.chkList_Subscription.Size = New System.Drawing.Size(594, 206)
        Me.chkList_Subscription.TabIndex = 3
        '
        'txt_MemberName
        '
        Me.txt_MemberName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_MemberName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MemberName.Location = New System.Drawing.Point(392, 26)
        Me.txt_MemberName.MaxLength = 35
        Me.txt_MemberName.Name = "txt_MemberName"
        Me.txt_MemberName.ReadOnly = True
        Me.txt_MemberName.Size = New System.Drawing.Size(217, 21)
        Me.txt_MemberName.TabIndex = 2
        '
        'cmd_MemberCodeHelp
        '
        Me.cmd_MemberCodeHelp.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources._400_F_9130045_3SaKfvCqFL4hRJm59cddsCnbx5YyqvYj
        Me.cmd_MemberCodeHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_MemberCodeHelp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MemberCodeHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd_MemberCodeHelp.Location = New System.Drawing.Point(232, 24)
        Me.cmd_MemberCodeHelp.Name = "cmd_MemberCodeHelp"
        Me.cmd_MemberCodeHelp.Size = New System.Drawing.Size(40, 23)
        Me.cmd_MemberCodeHelp.TabIndex = 1
        '
        'txt_MemberCode
        '
        Me.txt_MemberCode.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_MemberCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_MemberCode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MemberCode.Location = New System.Drawing.Point(135, 26)
        Me.txt_MemberCode.MaxLength = 15
        Me.txt_MemberCode.Name = "txt_MemberCode"
        Me.txt_MemberCode.Size = New System.Drawing.Size(88, 21)
        Me.txt_MemberCode.TabIndex = 0
        '
        'Cmd_exit
        '
        Me.Cmd_exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_exit.Image = CType(resources.GetObject("Cmd_exit.Image"), System.Drawing.Image)
        Me.Cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_exit.Location = New System.Drawing.Point(5, 315)
        Me.Cmd_exit.Name = "Cmd_exit"
        Me.Cmd_exit.Size = New System.Drawing.Size(137, 50)
        Me.Cmd_exit.TabIndex = 889
        Me.Cmd_exit.Text = "Exit[F11]"
        Me.Cmd_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_exit.UseVisualStyleBackColor = True
        '
        'cmd_Clear
        '
        Me.cmd_Clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Clear.Image = CType(resources.GetObject("cmd_Clear.Image"), System.Drawing.Image)
        Me.cmd_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Clear.Location = New System.Drawing.Point(5, 16)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(137, 50)
        Me.cmd_Clear.TabIndex = 885
        Me.cmd_Clear.Text = "Clear[F6]"
        Me.cmd_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_Clear.UseVisualStyleBackColor = True
        '
        'Cmd_add
        '
        Me.Cmd_add.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_add.Image = CType(resources.GetObject("Cmd_add.Image"), System.Drawing.Image)
        Me.Cmd_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_add.Location = New System.Drawing.Point(5, 79)
        Me.Cmd_add.Name = "Cmd_add"
        Me.Cmd_add.Size = New System.Drawing.Size(137, 50)
        Me.Cmd_add.TabIndex = 886
        Me.Cmd_add.Text = "Add[F7]"
        Me.Cmd_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_add.UseVisualStyleBackColor = True
        '
        'Cmd_freeze
        '
        Me.Cmd_freeze.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_freeze.Image = CType(resources.GetObject("Cmd_freeze.Image"), System.Drawing.Image)
        Me.Cmd_freeze.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_freeze.Location = New System.Drawing.Point(5, 138)
        Me.Cmd_freeze.Name = "Cmd_freeze"
        Me.Cmd_freeze.Size = New System.Drawing.Size(137, 50)
        Me.Cmd_freeze.TabIndex = 887
        Me.Cmd_freeze.Text = "Void[F8]"
        Me.Cmd_freeze.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_freeze.UseVisualStyleBackColor = True
        '
        'Cmd_view
        '
        Me.Cmd_view.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_view.Image = CType(resources.GetObject("Cmd_view.Image"), System.Drawing.Image)
        Me.Cmd_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_view.Location = New System.Drawing.Point(5, 197)
        Me.Cmd_view.Name = "Cmd_view"
        Me.Cmd_view.Size = New System.Drawing.Size(137, 50)
        Me.Cmd_view.TabIndex = 888
        Me.Cmd_view.Text = "View[F9]"
        Me.Cmd_view.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_view.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(181, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(223, 25)
        Me.Label1.TabIndex = 890
        Me.Label1.Text = "SUBSCRIPTION TAGGING"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_Frez
        '
        Me.lbl_Frez.AutoSize = True
        Me.lbl_Frez.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Frez.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Frez.ForeColor = System.Drawing.Color.Red
        Me.lbl_Frez.Location = New System.Drawing.Point(565, 41)
        Me.lbl_Frez.Name = "lbl_Frez"
        Me.lbl_Frez.Size = New System.Drawing.Size(171, 29)
        Me.lbl_Frez.TabIndex = 891
        Me.lbl_Frez.Text = "Record Freezed  "
        '
        'Browse
        '
        Me.Browse.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Browse.Location = New System.Drawing.Point(5, 256)
        Me.Browse.Name = "Browse"
        Me.Browse.Size = New System.Drawing.Size(137, 50)
        Me.Browse.TabIndex = 892
        Me.Browse.Text = "Browse"
        Me.Browse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Browse.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label124)
        Me.GroupBox1.Controls.Add(Me.chkList_Subscription)
        Me.GroupBox1.Location = New System.Drawing.Point(201, 272)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(626, 259)
        Me.GroupBox1.TabIndex = 893
        Me.GroupBox1.TabStop = False
        '
        'Gr2
        '
        Me.Gr2.BackColor = System.Drawing.Color.Transparent
        Me.Gr2.Controls.Add(Me.cmd_exit1)
        Me.Gr2.Controls.Add(Me.CMD_WINDOWS)
        Me.Gr2.Controls.Add(Me.CMD_DOS)
        Me.Gr2.Location = New System.Drawing.Point(405, 537)
        Me.Gr2.Name = "Gr2"
        Me.Gr2.Size = New System.Drawing.Size(422, 70)
        Me.Gr2.TabIndex = 918
        Me.Gr2.TabStop = False
        Me.Gr2.Visible = False
        '
        'cmd_exit1
        '
        Me.cmd_exit1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_exit1.Location = New System.Drawing.Point(277, 27)
        Me.cmd_exit1.Name = "cmd_exit1"
        Me.cmd_exit1.Size = New System.Drawing.Size(100, 30)
        Me.cmd_exit1.TabIndex = 2
        Me.cmd_exit1.Text = "EXIT"
        Me.cmd_exit1.UseVisualStyleBackColor = True
        '
        'CMD_WINDOWS
        '
        Me.CMD_WINDOWS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_WINDOWS.Location = New System.Drawing.Point(163, 26)
        Me.CMD_WINDOWS.Name = "CMD_WINDOWS"
        Me.CMD_WINDOWS.Size = New System.Drawing.Size(100, 30)
        Me.CMD_WINDOWS.TabIndex = 1
        Me.CMD_WINDOWS.Text = "WINDOWS"
        Me.CMD_WINDOWS.UseVisualStyleBackColor = True
        '
        'CMD_DOS
        '
        Me.CMD_DOS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_DOS.Location = New System.Drawing.Point(48, 26)
        Me.CMD_DOS.Name = "CMD_DOS"
        Me.CMD_DOS.Size = New System.Drawing.Size(100, 30)
        Me.CMD_DOS.TabIndex = 0
        Me.CMD_DOS.Text = "DOS"
        Me.CMD_DOS.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lbl_MembeName)
        Me.GroupBox2.Controls.Add(Me.cmd_MemberCodeHelp)
        Me.GroupBox2.Controls.Add(Me.txt_MemberName)
        Me.GroupBox2.Controls.Add(Me.lbl_MemberCode)
        Me.GroupBox2.Controls.Add(Me.txt_MemberCode)
        Me.GroupBox2.Location = New System.Drawing.Point(201, 189)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(626, 63)
        Me.GroupBox2.TabIndex = 894
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(198, 567)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 15)
        Me.Label2.TabIndex = 895
        Me.Label2.Text = "Press [F4] For Help"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.cmd_Clear)
        Me.GroupBox3.Controls.Add(Me.Cmd_view)
        Me.GroupBox3.Controls.Add(Me.Cmd_freeze)
        Me.GroupBox3.Controls.Add(Me.Cmd_add)
        Me.GroupBox3.Controls.Add(Me.Cmd_exit)
        Me.GroupBox3.Controls.Add(Me.Browse)
        Me.GroupBox3.Location = New System.Drawing.Point(858, 189)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(148, 373)
        Me.GroupBox3.TabIndex = 919
        Me.GroupBox3.TabStop = False
        '
        'FRM_MKGA_SubscriptionTagging
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Gr2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_Frez)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "FRM_MKGA_SubscriptionTagging"
        Me.Text = "SubscriptionTagging "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Gr2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim gconnection As New GlobalClass
    Dim boolchk As Boolean
    Dim sqlstring, TempString(2) As String
    Dim subscode, subsdesc As String
    Dim i As Integer


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
        Me.Cmd_add.Enabled = False
        Me.Cmd_freeze.Enabled = False
        Me.Cmd_view.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.Cmd_add.Enabled = True
                    Me.Cmd_freeze.Enabled = True
                    Me.Cmd_view.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.Cmd_add.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.Cmd_add.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.Cmd_add.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    Me.Cmd_freeze.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.Cmd_view.Enabled = True
                End If
            Next
        End If
    End Sub



    Private Sub txt_MemberCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_MemberCode.KeyPress
        'getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_MemberName.Focus()
        End If
    End Sub

    Private Sub txt_MemberName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_MemberName.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = 13 Then
            chkList_Subscription.Focus()
        End If
    End Sub


    Private Sub cmd_MemberCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MemberCodeHelp.Click
        Dim vform As New LIST_OPERATION1
        gSQLString = "Select MCODE,MNAME from membermaster"
        M_WhereCondition = " "
        vform.vCaption = "Membercode Help"
        vform.Field = "MNAME,MCODE"
        vform.CMB_SRC_FIELDS.Select()
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_MemberCode.Text = Trim(vform.keyfield & "")
            'txt_MemberName.Select()
            txt_MemberCode_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing
        'Cmd_add.Text = "Update[F7]"

    End Sub
    Private Sub chkList_Subscription_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chkList_Subscription.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Cmd_add.Focus()
        End If
    End Sub
    Private Sub cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If MsgBox("Do U Want to Close this Form........", MsgBoxStyle.OKCancel + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.OK Then
        Me.Close()
        'Else
        '    txt_MemberCode.Focus()
        'End If

    End Sub
    Private Sub cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.lbl_Frez.Visible = False
        Me.lbl_Frez.Text = "Record Freezed  On "
        clearform(Me)
        For i = 0 To chkList_Subscription.Items.Count - 1
            chkList_Subscription.SetItemChecked(i, False)
        Next i
        txt_MemberCode.Enabled = True
        txt_MemberCode.Focus()
        chkList_Subscription.Enabled = True
        Cmd_add.Text = "Add[F7]"
        Me.Cmd_freeze.Text = "Void[F8]"
    End Sub
    
    Public Sub checkValidation()
        boolchk = False
        '''********** Check Member Code is blank
        If Trim(txt_MemberCode.Text) = "" Then
            MessageBox.Show(" Member Code can't be blank ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_MemberCode.Focus()
            Exit Sub
        End If
        If lbl_Frez.Visible = True Then
            MessageBox.Show("This Record Already Void ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        '''********** Check Member Name is blank
        If Trim(txt_MemberName.Text) = "" Then
            MessageBox.Show(" Member Name can't be blank ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_MemberName.Focus()
            Exit Sub
        End If
        '''********** Check Subscription Field is blank
        If Cmd_add.Text = "Add[F7]" Then
            If chkList_Subscription.CheckedItems.Count = 0 Then
                MessageBox.Show(" Subscription Field can't be blank ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Error)
                chkList_Subscription.Focus()
                Exit Sub
            End If
        End If

        boolchk = True
    End Sub
    Private Sub SubscriptionTagging_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F7 Then
            If Cmd_add.Enabled = True Then
                Call Cmd_add_Click(sender, e)
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.F6 Then
            If cmd_Clear.Enabled = True Then
                Call cmd_Clear_Click_1(sender, e)
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.F9 Then
            If Cmd_view.Enabled = True Then
                Call Cmd_view_Click(sender, e)
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.F8 Then
            If Cmd_freeze.Enabled = True Then
                Call cmd_Freeze_Click(sender, e)
                Exit Sub
            End If
            
            'ElseIf e.KeyCode = Keys.F4 Then
            '    Call cmd_MemberCodeHelp_Click(sender, e)
            '    Exit Sub
        ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            If Cmd_exit.Enabled = True Then
                Call cmd_Exit_Click(sender, e)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub cmd_ListView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  Grp_Print.Visible = True
    End Sub
    Private Sub cmd_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Call checkValidation() '''--->CHECK VALIDATION
            If boolchk = False Then Exit Sub
            sqlstring = " DELETE FROM SubscriptionTagging WHERE MCODE='" & Trim(txt_MemberCode.Text) & "'"
            gconnection.dataOperation(6, sqlstring, "SubscriptionTagging")
            MessageBox.Show("Record Deleted ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Information)
            gconnection.dataOperation(2, "UPDATE MEMBERMASTER SET TAG = 'N'", "MemberMaster")
            Me.cmd_Clear_Click(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SubscriptionTagging_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        'FRM_MKGA_SubscriptionTagging = False
    End Sub
    Private Sub txt_MemberCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_MemberCode.Validated
        Dim strsubscription, STRSQL As String
        Dim dr As DataRow
        Dim j As Long
        If txt_MemberCode.Text <> "" Then
            sqlstring = " SELECT *  FROM Membermaster WHERE mcode='" & Me.txt_MemberCode.Text & "'"
            gconnection.getDataSet(sqlstring, "Membermaster")
            If gdataset.Tables("Membermaster").Rows.Count > 0 Then
                Me.txt_MemberName.Text = gdataset.Tables("membermaster").Rows(0).Item("mname")
            Else
                MsgBox("member not available.........")
                txt_MemberCode.Focus()
            End If
        End If
        sqlstring = "SELECT  subscriptiontype,ISNULL(freeze,'')AS FREEZE,ISNULL(AddDate,'')AS AddDate FROM subscriptiontagging WHERE mcode='" & txt_MemberCode.Text & "'"
        gconnection.getDataSet(sqlstring, "substagging")
        If gdataset.Tables("substagging").Rows.Count > 0 Then
            Cmd_add.Text = "Update[F7]"
            'Do
            For i = 0 To gdataset.Tables("substagging").Rows.Count - 1
                For j = 0 To chkList_Subscription.Items.Count - 1
                    TempString = Split(chkList_Subscription.Items.Item(j), " | ")
                    subscode = Trim(TempString(1))
                    subsdesc = Trim(TempString(0))
                    If Trim(CStr(gdataset.Tables("substagging").Rows(i).Item("subscriptiontype"))) = Trim(CStr(subsdesc)) Then
                        chkList_Subscription.SetItemChecked(j, True)
                    End If

                    subscode = ""
                    subsdesc = ""
                Next j
            Next i
            If gdataset.Tables("substagging").Rows(0).Item("freeze") = "Y" Then
                lbl_Frez.Visible = True
                Me.lbl_Frez.Visible = True
                Me.lbl_Frez.Text = "Record Freezed On  "
                Me.lbl_Frez.Text = Me.lbl_Frez.Text & Format(gdataset.Tables("substagging").Rows(0).Item("AddDate"), "dd-MMM-yyyy")

                ' Me.lbl_Frez.Text = "Record Freezed  On : " & Format(CDate(gdataset.Tables("subscriptiontagging").Rows(0).Item("AddDatetime")), "dd-MMM-yyyy")
                ' Me.lbl_Frez.Text = "Record Freezed  On : " & Format(CDate(gdataset.Tables("subscriptiontagging").Rows(0).Item("AddDatetime")), "dd-MMM-yyyy")
            End If



        Else

        End If
    End Sub
    Private Sub txt_MemberCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_MemberCode.KeyDown
        If e.KeyCode = Keys.Return Then
            If txt_MemberCode.Text = "" Then
                Call cmd_MemberCodeHelp_Click(sender, e)
            Else
                txt_MemberCode_Validated(sender, e)
            End If
        ElseIf e.KeyCode = Keys.F4 Then
            Call cmd_MemberCodeHelp_Click(sender, e)
        End If
       

    End Sub


    Private Sub cmd_Freeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call checkValidation()
        If boolchk = False Then Exit Sub
        If Mid(Me.Cmd_freeze.Text, 1, 1) = "F" Then
            sqlstring = "UPDATE  subscriptiontagging "
            sqlstring = sqlstring & " SET Freeze= 'Y',AddUser='" & gUsername & " ', AddDate='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
            sqlstring = sqlstring & " WHERE MCODE = '" & txt_MemberCode.Text & " '"
            gconnection.dataOperation(3, sqlstring, "MCODE")

            sqlstring = "UPDATE  subscriptiontagging "
            sqlstring = sqlstring & " SET Freeze= 'Y',AddUser='" & gUsername & " ', AddDate='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
            gconnection.dataOperation(3, sqlstring, "MCODE")
            gconnection.closeConnection()
            MessageBox.Show("Record Freezed Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cmd_Clear_Click(sender, e)
            Cmd_add.Text = "Add[F7]"
        Else
            sqlstring = "UPDATE  subscriptiontagging "
            sqlstring = sqlstring & " SET Freeze= 'N',AddUser='" & gUsername & " ', AddDate='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
            sqlstring = sqlstring & " WHERE MCODE = '" & txt_MemberCode.Text & " '"
            gconnection.dataOperation(4, sqlstring, "MCODE")

            sqlstring = "UPDATE  subscriptiontagging "
            sqlstring = sqlstring & " SET Freeze= 'N',AddUser='" & gUsername & " ', AddDate='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
            gconnection.dataOperation(3, sqlstring, "MCODE")
            gconnection.closeConnection()
            MessageBox.Show("Record UNFreezed Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cmd_Clear_Click(sender, e)
            Cmd_add.Text = "Add[F7]"
        End If

    End Sub

    Private Sub CMD_DOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FrReport As New ReportDesigner
        tables = "FROM subscriptiontagging"
        Gheader = "SUBSCRIPTION TAGGING"
        'FrReport.SsGridReport.SetText(2, 1, "MCODE")
        'FrReport.SsGridReport.SetText(3, 1, 15)
        'FrReport.SsGridReport.SetText(2, 2, "SUBSCRIPTIONTYPE")
        'FrReport.SsGridReport.SetText(3, 2, 50)
        FrReport.Show()
    End Sub

    Private Sub CMD_WINDOWS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Dim txtobj1 As TextObject
        ' Dim Viewer As New ReportViwer
        ' Dim r As New Cry_SUBSCRIPTIONTAGGING
        'If Chk_freeze.Checked = True Then
        '    sqlstring = "select * from MM_VIEW_SUBSCRIPTIONTAGGING where freeze='Y'"
        'Else
        sqlstring = "select * from MM_VIEW_SUBSCRIPTIONTAGGING "
        'End If
        ' Call Viewer.GetDetails1(sqlstring, "MM_VIEW_SUBSCRIPTIONTAGGING", r)
        'txtobj1 = r.ReportDefinition.ReportObjects("Text6")

    End Sub

    Private Sub CMDEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Btn_Validation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim REP As New report_det
        'REP.Show()
        'If GmoduleName = "Subscription Tagging" Then
        '    With REP.ssgrid
        '        .Row = 1
        '        .Text = "1. SUBSCRIPTION TAGGING DATE CANNOT BE CREATER THEN MEMBERSHIP EXPIRY DATE  "
        '        .Row = 2
        '        .Text = "2. SUBSCRIPTIONS CANCELTIONS SHOULD BE MAINTAIN FOR TRACKING LOG "

        '    End With
        'End If
        System.Diagnostics.Process.Start(AppPath & "/STUDY/SUBSCRIPTIONTAGGING.XLS")
    End Sub

    Private Sub chkList_Subscription_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chkList_Subscription.SelectedIndexChanged

    End Sub

    Private Sub FRM_MKGA_SubscriptionTagging_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Call Resize_Form()

        Dim DR As DataRow
        'sqlstring = "SELECT isnull(subscode,'') as subscode,isnull(SubsDesc,'') as SubsDesc FROM subscriptionmast  where  ltrim(rtrim(type))='SPECIAL'"
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        lbl_Frez.Visible = False
        txt_MemberCode.Select()

        'AppPath = Application.StartupPath
        'gconnection.GetServer()
        sqlstring = "SELECT isnull(subscode,'') as subscode,isnull(SubsDesc,'') as SubsDesc FROM subscriptionmast where Type='SPECIAL'order by SubsDesc"
        gconnection.getDataSet(sqlstring, "substagging")
        Try
            If gdataset.Tables("substagging").Rows.Count > 0 Then
                For Each DR In gdataset.Tables("substagging").Rows
                    '                    chkList_Subscription.Items.Add(Trim(DR("subscode")) & " | " & Trim(DR("subsdesc")))
                    chkList_Subscription.Items.Add(Trim(Mid(DR("subsdesc"), 1, 50)) & Space(50 - Len(Trim(Mid(DR("subsdesc"), 1, 50)))) & Space(200) & " | " & DR("subscode"))
                Next
                gdataset.Tables("SubsTagging").Dispose()
            End If
        Catch ex As Exception
            MsgBox("Sorry! there is an Error! Bcoz " & ex.Message.ToString(), MsgBoxStyle.OkOnly, "Error!")
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
                        If Controls(i_i).Name = "cmd_Clear" Or Controls(i_i).Name = "Cmd_add" Or Controls(i_i).Name = "Cmd_freeze" Or Controls(i_i).Name = "Cmd_view" Or Controls(i_i).Name = "Browse" Or Controls(i_i).Name = "Cmd_exit" Then
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

    Private Sub Cmd_add_Click(sender As Object, e As EventArgs) Handles Cmd_add.Click
        Try
            Dim user As String
            Dim udate As Date

            '''--->CHECK VALIDATION

            If Cmd_add.Text = "Add[F7]" Then
                Call checkValidation()
                If boolchk = False Then Exit Sub
                For i = 0 To chkList_Subscription.Items.Count - 1
                    If chkList_Subscription.GetItemChecked(i) = True Then
                        TempString = Split(chkList_Subscription.Items.Item(i), " | ")
                        subscode = Trim(TempString(1))
                        subsdesc = Trim(TempString(0))
                        sqlstring = "INSERT INTO  SubscriptionTagging "
                        sqlstring = sqlstring & "(MCODE,MNAME,SUBSCRIPTIONTYPE,SUBSCODE,ADDUSER,ADDDATE) VALUES ('" & Trim(txt_MemberCode.Text) & " ' ,'" & Trim(txt_MemberName.Text) & "','" & _
                        subsdesc & " ','" & subscode & "','" & gUsername & "','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "')"
                        'chkList_Subscription.Items.Item(i) & " ','" & gUsername & "','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "')"
                        gconnection.dataOperation(1, sqlstring, "SubscriptionMast")
                        subscode = ""
                        subsdesc = ""
                    End If
                Next i
                MessageBox.Show("Record Saved Successfully", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cmd_Clear_Click_1(sender, e)
            ElseIf Cmd_add.Text = "Update[F7]" Then
                'FOR REF
                Call checkValidation()
                If boolchk = False Then Exit Sub
                sqlstring = "select isnull(adduser,'') as adduser,isnull(adddate,'') as adddate,mcode from subscriptiontagging where mcode='" & Trim(txt_MemberCode.Text) & "'"
                gconnection.getDataSet(sqlstring, "subscription")
                If gdataset.Tables("subscription").Rows.Count > 0 Then
                    user = gdataset.Tables("subscription").Rows(0).Item("adduser")
                    udate = gdataset.Tables("subscription").Rows(0).Item("adddate")
                End If
                sqlstring = "delete from subscriptiontagging where mcode='" & Trim(txt_MemberCode.Text) & "'"
                gconnection.dataOperation(1, sqlstring, "SubscriptionMast")
                For i = 0 To chkList_Subscription.Items.Count - 1
                    If chkList_Subscription.GetItemChecked(i) = True Then
                        TempString = Split(chkList_Subscription.Items.Item(i), " | ")
                        subscode = Trim(TempString(1))
                        subsdesc = Trim(TempString(0))
                        sqlstring = "INSERT INTO  SubscriptionTagging "
                        sqlstring = sqlstring & "(MCODE,MNAME,SUBSCRIPTIONTYPE,SUBSCODE,ADDUSER,ADDDATE,UPDATEUSER,UPDATETIME) VALUES ('" & Trim(txt_MemberCode.Text) & " ' ,'" & Trim(txt_MemberName.Text) & "','" & _
                        subsdesc & " ','" & subscode & "','" & user & "','" & Format(udate, "dd-MMM-yyyy hh:mm") & "','" & gUsername & "','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "')"
                        'chkList_Subscription.Items.Item(i) & " ','" & gUsername & "','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "')"
                        gconnection.dataOperation(1, sqlstring, "SubscriptionMast")

                        subscode = ""
                        subsdesc = ""
                    End If
                Next i
                MessageBox.Show("Record Updated Successfully ", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cmd_Clear_Click_1(sender, e)
                '------------------------------------------   
            End If

            Me.cmd_Clear_Click_1(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub cmd_Clear_Click_1(sender As Object, e As EventArgs) Handles cmd_Clear.Click
        Me.lbl_Frez.Visible = False
        Me.lbl_Frez.Text = "Record Freezed  On "
        Cmd_freeze.Visible = True
        'clearform(Me)
        txt_MemberCode.Text = ""
        txt_MemberName.Text = ""
        For i = 0 To chkList_Subscription.Items.Count - 1
            chkList_Subscription.SetItemChecked(i, False)
        Next i
        txt_MemberCode.Enabled = True
        txt_MemberCode.Focus()
        chkList_Subscription.Enabled = True
        Cmd_add.Text = "Add[F7]"
        Me.Cmd_freeze.Text = "Void[F8]"
        Gr2.Visible = False

    End Sub


    Private Sub Cmd_view_Click(sender As Object, e As EventArgs) Handles Cmd_view.Click
        Gr2.Visible = True


    End Sub

    Private Sub Cmd_exit_Click_1(sender As Object, e As EventArgs) Handles Cmd_exit.Click
        Me.Close()
    End Sub

    Private Sub cmd_Clear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmd_Clear.KeyPress
        ' Cmd_freeze.Visible = True
    End Sub

    Private Sub txt_MemberCode_TextChanged(sender As Object, e As EventArgs) Handles txt_MemberCode.TextChanged
        ' Cmd_freeze.Visible = True
    End Sub

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        Dim VIEW1 As New VIEWHDR
        VIEW1.Show()
        VIEW1.DTGRDHDR.DataSource = Nothing
        VIEW1.DTGRDHDR.Rows.Clear()
        Dim STRQUERY As String
        STRQUERY = "SELECT * FROM SubscriptionTagging"
        STRQUERY = "SELECT MCODE,MNAME,SUBSCODE,SUBSCRIPTIONTYPE FROM SubscriptionTagging"
        gconnection.getDataSet(STRQUERY, "authorize")
        'Call VIEW1.LOADGRID(gdataset.Tables("MENUMASTER"), False, "MENUMASTER", "SELECT serialno ,modulename ,menutype ,menuserial ,displayname ,formname  FROM menumaster", "SERIALNO", 0)


        brows = True

    

        Call VIEW1.LOADGRID(gdataset.Tables("authorize"), True, gcompanyname, "SELECT * FROM Application_ReasonMaster", "Code", 1, Me.txt_MemberCode)
        'VIEW1.Hide()
        'VIEW1.ShowDialog(Me)
        'If Trim(keyfield & "") <> "" Then
        '    txt_MemberCode.Text = Trim(keyfield & "")
        '    txt_MemberName.Select()
        '    Me.txt_feeldFILL()
        '    '  DDGRD1.Select()
        '    Cmd_add.Text = "Update [F7]"
        'End If
        'gconnection.closeConnection()
    End Sub
    Private Sub txt_feeldFILL()
        Try
            Dim I, J As Integer
            Dim MEMBERTYPE As DataTable
            Dim Sqlstr As String
            If txt_MemberCode.Text <> "" Then
                Sqlstr = "SELECT * FROM SubscriptionTagging WHERE MCODE='" & Trim(txt_MemberCode.Text) & "'"
                gconnection.getDataSet(Sqlstr, "SubscriptionTagging")
                If gdataset.Tables("Master").Rows.Count > 0 Then
                    txt_MemberCode.ReadOnly = True
                    ' Txtcode.Text = gdataset.Tables("Application_ReasonMaster").Rows(0).Item("code")
                    txt_MemberName.Text = gdataset.Tables("SubscriptionTagging").Rows(0).Item("MNAME")

                    Me.lbl_Frez.Visible = True
                    Me.lbl_Frez.Text = Me.lbl_Frez.Text & Format(gdataset.Tables("Master").Rows(0).Item("voiddate"), "dd-MMM-yyyy")
                    Me.lbl_Frez.Text = "Void[F8]"
                Else
                    Me.lbl_Frez.Visible = False
                    Me.lbl_Frez.Text = "Record Voided  On "
                    Me.lbl_Frez.Text = "Void[F8]"
                End If
                Me.Cmd_add.Text = "Update[F7]"
            Else
                txt_MemberName.Text = ""
            End If

        Catch ex As Exception
            '  MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FRM_MKGA_SubscriptionTagging_TextChanged(sender As Object, e As EventArgs) Handles Me.TextChanged

    End Sub

    Private Sub lbl_MemberCode_Validated(sender As Object, e As EventArgs) Handles lbl_MemberCode.Validated

    End Sub

    Private Sub Cmd_freeze_Click_1(sender As Object, e As EventArgs) Handles Cmd_freeze.Click
        Call checkValidation()
        If boolchk = False Then Exit Sub
        If lbl_Frez.Visible = True Then
            MessageBox.Show("Record ALREADY Freeze  ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_MemberCode.Focus()
            Me.cmd_Clear_Click(sender, e)
            Cmd_add.Text = "Add[F7]"
            'Me.cmd_Clear_Click(sender, e)
            'Cmd_add.Text = "Add[F7]"
        Else
            sqlstring = "UPDATE  subscriptiontagging "
            sqlstring = sqlstring & " SET Freeze= 'Y',AddUser='" & gUsername & " ', AddDate='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
            sqlstring = sqlstring & " WHERE MCODE = '" & txt_MemberCode.Text & " '"
            gconnection.dataOperation(4, sqlstring, "MCODE")

            MessageBox.Show("Record Freezed Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cmd_Clear_Click(sender, e)
            '  Cmd_add.Text = "Add[F7]"
        End If
    End Sub

    Private Sub CMD_DOS_Click_1(sender As Object, e As EventArgs) Handles CMD_DOS.Click
        '  Grp_Print.Visible = True
        Dim reportdesign As New ReportDesigner
        gheader = " MASTER VIEW "
        If txt_MemberCode.Text.Length > 0 Then
            tables = " FROM subscriptiontagging where MCode = '" & Trim(txt_MemberCode.Text) & "'"
        Else
            tables = " FROM subscriptiontagging"
        End If
        reportdesign.DataGridView1.ColumnCount = 2
        reportdesign.DataGridView1.Columns(0).Name = "Column Name"
        reportdesign.DataGridView1.Columns(0).Width = 380
        reportdesign.DataGridView1.Columns(1).Name = "Size"
        reportdesign.DataGridView1.Columns(1).Width = 100


        Dim row As String() = New String() {"MCODE", "10"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"MNAME", "35"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"SUBSCRIPTIONTYPE", "35"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"FREEZE", "10"}
        reportdesign.DataGridView1.Rows.Add(row)

        Dim chk As New DataGridViewCheckBoxColumn()
        reportdesign.DataGridView1.Columns.Insert(0, chk)
        chk.HeaderText = "Check"
        chk.Name = "chk"

        reportdesign.ShowDialog(Me)
    End Sub

    Private Sub CMD_WINDOWS_Click_1(sender As Object, e As EventArgs) Handles CMD_WINDOWS.Click
        Dim txtobj1 As TextObject
        Dim Viewer As New REPORTVIEWER
        sqlstring = "select * from view_subscriptiontagging "
        If txt_MemberCode.Text = "" Then
            sqlstring = sqlstring & ""
        Else
            sqlstring = sqlstring & "WHERE MCODE = '" & txt_MemberCode.Text & "' "
        End If
        Dim r As New CRY_SUBSCRIPTIONTAGGING1
        gconnection.getDataSet(sqlstring, "view_subscriptiontagging")
        If gdataset.Tables("view_subscriptiontagging").Rows.Count > 0 Then
            Viewer.TableName = "view_subscriptiontagging"
            Call Viewer.GetDetails(sqlstring, "view_subscriptiontagging", r)
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
            txtobj1 = r.ReportDefinition.ReportObjects("Text14")
            txtobj1.Text = UCase(gCompanyAddress(4))
            txtobj1 = r.ReportDefinition.ReportObjects("Text21")
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
        txt_MemberCode.Focus()
    End Sub
End Class

