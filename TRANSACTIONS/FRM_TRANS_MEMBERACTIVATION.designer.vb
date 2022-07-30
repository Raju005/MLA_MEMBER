<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_TRANS_MEMBERACTIVATION
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_TRANS_MEMBERACTIVATION))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbo_NewStatus = New System.Windows.Forms.ComboBox()
        Me.cmd_MemberCodeHelp = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Cbo_reasons = New System.Windows.Forms.ComboBox()
        Me.dtp_EffectiveFrom = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Effectivefrom = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cbo_reasons1 = New System.Windows.Forms.TextBox()
        Me.txt_PresentStatus = New System.Windows.Forms.TextBox()
        Me.txt_MemberName = New System.Windows.Forms.TextBox()
        Me.txt_MemberCode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_freeze = New System.Windows.Forms.Button()
        Me.dtp_EffectiveTo = New System.Windows.Forms.DateTimePicker()
        Me.lbl_EffectiveTo = New System.Windows.Forms.Label()
        Me.lbl_freeze = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GR2 = New System.Windows.Forms.GroupBox()
        Me.BTN_EXIT_GR2 = New System.Windows.Forms.Button()
        Me.BTN_WINDOWS = New System.Windows.Forms.Button()
        Me.BTN_DOS = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_view = New System.Windows.Forms.Button()
        Me.btn_authorize = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_browse = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GR2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(179, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MEMBERSHIP ACTIVATION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Member Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Present Status"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cbo_NewStatus)
        Me.GroupBox1.Controls.Add(Me.cmd_MemberCodeHelp)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Cbo_reasons)
        Me.GroupBox1.Controls.Add(Me.dtp_EffectiveFrom)
        Me.GroupBox1.Controls.Add(Me.lbl_Effectivefrom)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Cbo_reasons1)
        Me.GroupBox1.Controls.Add(Me.txt_PresentStatus)
        Me.GroupBox1.Controls.Add(Me.txt_MemberName)
        Me.GroupBox1.Controls.Add(Me.txt_MemberCode)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(201, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(637, 386)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'cbo_NewStatus
        '
        Me.cbo_NewStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_NewStatus.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_NewStatus.FormattingEnabled = True
        Me.cbo_NewStatus.Items.AddRange(New Object() {"ACTIVE"})
        Me.cbo_NewStatus.Location = New System.Drawing.Point(138, 170)
        Me.cbo_NewStatus.Name = "cbo_NewStatus"
        Me.cbo_NewStatus.Size = New System.Drawing.Size(246, 23)
        Me.cbo_NewStatus.TabIndex = 5
        '
        'cmd_MemberCodeHelp
        '
        Me.cmd_MemberCodeHelp.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources._400_F_9130045_3SaKfvCqFL4hRJm59cddsCnbx5YyqvYj
        Me.cmd_MemberCodeHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_MemberCodeHelp.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MemberCodeHelp.Location = New System.Drawing.Point(244, 63)
        Me.cmd_MemberCodeHelp.Name = "cmd_MemberCodeHelp"
        Me.cmd_MemberCodeHelp.Size = New System.Drawing.Size(40, 23)
        Me.cmd_MemberCodeHelp.TabIndex = 2
        Me.cmd_MemberCodeHelp.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(312, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Member Name"
        '
        'Cbo_reasons
        '
        Me.Cbo_reasons.FormattingEnabled = True
        Me.Cbo_reasons.Location = New System.Drawing.Point(34, 344)
        Me.Cbo_reasons.Name = "Cbo_reasons"
        Me.Cbo_reasons.Size = New System.Drawing.Size(471, 21)
        Me.Cbo_reasons.TabIndex = 11
        Me.Cbo_reasons.Visible = False
        '
        'dtp_EffectiveFrom
        '
        Me.dtp_EffectiveFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtp_EffectiveFrom.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_EffectiveFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_EffectiveFrom.Location = New System.Drawing.Point(138, 295)
        Me.dtp_EffectiveFrom.Name = "dtp_EffectiveFrom"
        Me.dtp_EffectiveFrom.Size = New System.Drawing.Size(103, 21)
        Me.dtp_EffectiveFrom.TabIndex = 7
        '
        'lbl_Effectivefrom
        '
        Me.lbl_Effectivefrom.AutoSize = True
        Me.lbl_Effectivefrom.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Effectivefrom.Location = New System.Drawing.Point(32, 297)
        Me.lbl_Effectivefrom.Name = "lbl_Effectivefrom"
        Me.lbl_Effectivefrom.Size = New System.Drawing.Size(88, 15)
        Me.lbl_Effectivefrom.TabIndex = 9
        Me.lbl_Effectivefrom.Text = "Effective From"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Remarks"
        '
        'Cbo_reasons1
        '
        Me.Cbo_reasons1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_reasons1.Location = New System.Drawing.Point(138, 219)
        Me.Cbo_reasons1.MaxLength = 50
        Me.Cbo_reasons1.Multiline = True
        Me.Cbo_reasons1.Name = "Cbo_reasons1"
        Me.Cbo_reasons1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Cbo_reasons1.Size = New System.Drawing.Size(404, 50)
        Me.Cbo_reasons1.TabIndex = 6
        '
        'txt_PresentStatus
        '
        Me.txt_PresentStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_PresentStatus.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PresentStatus.Location = New System.Drawing.Point(138, 117)
        Me.txt_PresentStatus.MaxLength = 19
        Me.txt_PresentStatus.Name = "txt_PresentStatus"
        Me.txt_PresentStatus.Size = New System.Drawing.Size(246, 21)
        Me.txt_PresentStatus.TabIndex = 4
        '
        'txt_MemberName
        '
        Me.txt_MemberName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MemberName.Location = New System.Drawing.Point(420, 62)
        Me.txt_MemberName.MaxLength = 28
        Me.txt_MemberName.Name = "txt_MemberName"
        Me.txt_MemberName.Size = New System.Drawing.Size(193, 21)
        Me.txt_MemberName.TabIndex = 3
        '
        'txt_MemberCode
        '
        Me.txt_MemberCode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MemberCode.Location = New System.Drawing.Point(138, 63)
        Me.txt_MemberCode.MaxLength = 15
        Me.txt_MemberCode.Name = "txt_MemberCode"
        Me.txt_MemberCode.Size = New System.Drawing.Size(100, 21)
        Me.txt_MemberCode.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "New Status"
        '
        'btn_freeze
        '
        Me.btn_freeze.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_freeze.Image = CType(resources.GetObject("btn_freeze.Image"), System.Drawing.Image)
        Me.btn_freeze.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_freeze.Location = New System.Drawing.Point(941, 40)
        Me.btn_freeze.Name = "btn_freeze"
        Me.btn_freeze.Size = New System.Drawing.Size(137, 50)
        Me.btn_freeze.TabIndex = 44
        Me.btn_freeze.Text = "Freeze[F8]"
        Me.btn_freeze.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_freeze.UseVisualStyleBackColor = True
        Me.btn_freeze.Visible = False
        '
        'dtp_EffectiveTo
        '
        Me.dtp_EffectiveTo.CustomFormat = "dd/MM/yyyy"
        Me.dtp_EffectiveTo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_EffectiveTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_EffectiveTo.Location = New System.Drawing.Point(1029, 43)
        Me.dtp_EffectiveTo.Name = "dtp_EffectiveTo"
        Me.dtp_EffectiveTo.Size = New System.Drawing.Size(29, 21)
        Me.dtp_EffectiveTo.TabIndex = 49
        Me.dtp_EffectiveTo.Visible = False
        '
        'lbl_EffectiveTo
        '
        Me.lbl_EffectiveTo.AutoSize = True
        Me.lbl_EffectiveTo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EffectiveTo.Location = New System.Drawing.Point(1013, 9)
        Me.lbl_EffectiveTo.Name = "lbl_EffectiveTo"
        Me.lbl_EffectiveTo.Size = New System.Drawing.Size(72, 15)
        Me.lbl_EffectiveTo.TabIndex = 48
        Me.lbl_EffectiveTo.Text = "Effective To"
        Me.lbl_EffectiveTo.Visible = False
        '
        'lbl_freeze
        '
        Me.lbl_freeze.AutoSize = True
        Me.lbl_freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_freeze.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_freeze.Location = New System.Drawing.Point(584, 40)
        Me.lbl_freeze.Name = "lbl_freeze"
        Me.lbl_freeze.Size = New System.Drawing.Size(193, 29)
        Me.lbl_freeze.TabIndex = 50
        Me.lbl_freeze.Text = "Record Freezed On"
        Me.lbl_freeze.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(200, 538)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 20)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Press [F4] For Help"
        '
        'GR2
        '
        Me.GR2.BackColor = System.Drawing.Color.Transparent
        Me.GR2.Controls.Add(Me.BTN_EXIT_GR2)
        Me.GR2.Controls.Add(Me.BTN_WINDOWS)
        Me.GR2.Controls.Add(Me.BTN_DOS)
        Me.GR2.Location = New System.Drawing.Point(360, 538)
        Me.GR2.Name = "GR2"
        Me.GR2.Size = New System.Drawing.Size(402, 69)
        Me.GR2.TabIndex = 52
        Me.GR2.TabStop = False
        '
        'BTN_EXIT_GR2
        '
        Me.BTN_EXIT_GR2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EXIT_GR2.Location = New System.Drawing.Point(264, 22)
        Me.BTN_EXIT_GR2.Name = "BTN_EXIT_GR2"
        Me.BTN_EXIT_GR2.Size = New System.Drawing.Size(100, 30)
        Me.BTN_EXIT_GR2.TabIndex = 2
        Me.BTN_EXIT_GR2.Text = "EXIT"
        Me.BTN_EXIT_GR2.UseVisualStyleBackColor = True
        '
        'BTN_WINDOWS
        '
        Me.BTN_WINDOWS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_WINDOWS.Location = New System.Drawing.Point(148, 22)
        Me.BTN_WINDOWS.Name = "BTN_WINDOWS"
        Me.BTN_WINDOWS.Size = New System.Drawing.Size(100, 30)
        Me.BTN_WINDOWS.TabIndex = 1
        Me.BTN_WINDOWS.Text = "WINDOWS"
        Me.BTN_WINDOWS.UseVisualStyleBackColor = True
        '
        'BTN_DOS
        '
        Me.BTN_DOS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DOS.Location = New System.Drawing.Point(34, 22)
        Me.BTN_DOS.Name = "BTN_DOS"
        Me.BTN_DOS.Size = New System.Drawing.Size(100, 30)
        Me.BTN_DOS.TabIndex = 0
        Me.BTN_DOS.Text = "DOS"
        Me.BTN_DOS.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btn_browse)
        Me.GroupBox2.Controls.Add(Me.btn_clear)
        Me.GroupBox2.Controls.Add(Me.btn_authorize)
        Me.GroupBox2.Controls.Add(Me.btn_view)
        Me.GroupBox2.Controls.Add(Me.btn_exit)
        Me.GroupBox2.Controls.Add(Me.btn_add)
        Me.GroupBox2.Location = New System.Drawing.Point(858, 142)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(147, 386)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add.Location = New System.Drawing.Point(6, 78)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(137, 50)
        Me.btn_add.TabIndex = 8
        Me.btn_add.Text = "Add[F7]"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Image = CType(resources.GetObject("btn_exit.Image"), System.Drawing.Image)
        Me.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_exit.Location = New System.Drawing.Point(6, 328)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(137, 50)
        Me.btn_exit.TabIndex = 12
        Me.btn_exit.Text = "Exit[F11]"
        Me.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_view
        '
        Me.btn_view.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_view.Image = CType(resources.GetObject("btn_view.Image"), System.Drawing.Image)
        Me.btn_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_view.Location = New System.Drawing.Point(6, 139)
        Me.btn_view.Name = "btn_view"
        Me.btn_view.Size = New System.Drawing.Size(137, 50)
        Me.btn_view.TabIndex = 9
        Me.btn_view.Text = "View[F9]"
        Me.btn_view.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_view.UseVisualStyleBackColor = True
        '
        'btn_authorize
        '
        Me.btn_authorize.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_authorize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_authorize.Location = New System.Drawing.Point(6, 200)
        Me.btn_authorize.Name = "btn_authorize"
        Me.btn_authorize.Size = New System.Drawing.Size(137, 50)
        Me.btn_authorize.TabIndex = 10
        Me.btn_authorize.Text = "Authorize"
        Me.btn_authorize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_authorize.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Image = CType(resources.GetObject("btn_clear.Image"), System.Drawing.Image)
        Me.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clear.Location = New System.Drawing.Point(6, 19)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(137, 50)
        Me.btn_clear.TabIndex = 13
        Me.btn_clear.Text = "Clear[F6]"
        Me.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_browse
        '
        Me.btn_browse.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_browse.Location = New System.Drawing.Point(6, 263)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(137, 50)
        Me.btn_browse.TabIndex = 11
        Me.btn_browse.Text = "Browse"
        Me.btn_browse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_browse.UseVisualStyleBackColor = True
        '
        'FRM_TRANS_MEMBERACTIVATION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GR2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbl_freeze)
        Me.Controls.Add(Me.dtp_EffectiveTo)
        Me.Controls.Add(Me.lbl_EffectiveTo)
        Me.Controls.Add(Me.btn_freeze)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "FRM_TRANS_MEMBERACTIVATION"
        Me.Text = "MEMBER ACTIVATION"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GR2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Cbo_reasons As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_EffectiveFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Effectivefrom As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Cbo_reasons1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_PresentStatus As System.Windows.Forms.TextBox
    Friend WithEvents txt_MemberName As System.Windows.Forms.TextBox
    Friend WithEvents txt_MemberCode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbo_NewStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_MemberCodeHelp As System.Windows.Forms.Button
    Friend WithEvents btn_freeze As System.Windows.Forms.Button
    Friend WithEvents dtp_EffectiveTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_EffectiveTo As System.Windows.Forms.Label
    Friend WithEvents lbl_freeze As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GR2 As System.Windows.Forms.GroupBox
    Friend WithEvents BTN_EXIT_GR2 As System.Windows.Forms.Button
    Friend WithEvents BTN_WINDOWS As System.Windows.Forms.Button
    Friend WithEvents BTN_DOS As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_browse As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btn_authorize As System.Windows.Forms.Button
    Friend WithEvents btn_view As System.Windows.Forms.Button
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
End Class
