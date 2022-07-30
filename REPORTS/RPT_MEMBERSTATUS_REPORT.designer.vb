<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RPT_MEMBERSTATUS_REPORT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RPT_MEMBERSTATUS_REPORT))
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.btn_view = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chk_PrintAll = New System.Windows.Forms.CheckBox()
        Me.chk_STATUS = New System.Windows.Forms.CheckBox()
        Me.chk_Filter_Field = New System.Windows.Forms.CheckedListBox()
        Me.ChK_Memberstatus = New System.Windows.Forms.CheckedListBox()
        Me.tbx_Filter_From = New System.Windows.Forms.TextBox()
        Me.tbx_filter_To = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Dtp_From = New System.Windows.Forms.DateTimePicker()
        Me.Dtp_To = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmd_MCodeToHelp = New System.Windows.Forms.Button()
        Me.cmd_MCodefromHelp = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Chk_Memsta = New System.Windows.Forms.CheckBox()
        Me.chk_terminate_det = New System.Windows.Forms.CheckBox()
        Me.chk_expired_det = New System.Windows.Forms.CheckBox()
        Me.chk_expiry_det = New System.Windows.Forms.CheckBox()
        Me.Chk_History = New System.Windows.Forms.CheckBox()
        Me.Chk_Dojwisediff = New System.Windows.Forms.CheckBox()
        Me.Chk_details = New System.Windows.Forms.CheckBox()
        Me.chk_member_status_sum = New System.Windows.Forms.CheckBox()
        Me.Chk_sumry = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.chk_dt_details = New System.Windows.Forms.CheckBox()
        Me.chk_dt_summary = New System.Windows.Forms.CheckBox()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox10.Controls.Add(Me.btn_exit)
        Me.GroupBox10.Controls.Add(Me.btn_clear)
        Me.GroupBox10.Controls.Add(Me.btn_print)
        Me.GroupBox10.Controls.Add(Me.btn_view)
        Me.GroupBox10.Location = New System.Drawing.Point(860, 186)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(147, 267)
        Me.GroupBox10.TabIndex = 63
        Me.GroupBox10.TabStop = False
        '
        'btn_exit
        '
        Me.btn_exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Image = CType(resources.GetObject("btn_exit.Image"), System.Drawing.Image)
        Me.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_exit.Location = New System.Drawing.Point(6, 203)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(137, 50)
        Me.btn_exit.TabIndex = 17
        Me.btn_exit.Text = "Exit[F11]"
        Me.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Image = CType(resources.GetObject("btn_clear.Image"), System.Drawing.Image)
        Me.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clear.Location = New System.Drawing.Point(6, 25)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(137, 50)
        Me.btn_clear.TabIndex = 11
        Me.btn_clear.Text = "Clear[F6]"
        Me.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_print
        '
        Me.btn_print.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_print.Location = New System.Drawing.Point(5, 145)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(137, 50)
        Me.btn_print.TabIndex = 12
        Me.btn_print.Text = "Print[F12]"
        Me.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'btn_view
        '
        Me.btn_view.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_view.Image = CType(resources.GetObject("btn_view.Image"), System.Drawing.Image)
        Me.btn_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_view.Location = New System.Drawing.Point(5, 86)
        Me.btn_view.Name = "btn_view"
        Me.btn_view.Size = New System.Drawing.Size(137, 50)
        Me.btn_view.TabIndex = 13
        Me.btn_view.Text = "View[F9]"
        Me.btn_view.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_view.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(180, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 25)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "MEMBER STATUS REPORT"
        '
        'chk_PrintAll
        '
        Me.chk_PrintAll.AutoSize = True
        Me.chk_PrintAll.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PrintAll.Location = New System.Drawing.Point(10, 20)
        Me.chk_PrintAll.Name = "chk_PrintAll"
        Me.chk_PrintAll.Size = New System.Drawing.Size(124, 19)
        Me.chk_PrintAll.TabIndex = 67
        Me.chk_PrintAll.Text = "Print All Category"
        Me.chk_PrintAll.UseVisualStyleBackColor = True
        '
        'chk_STATUS
        '
        Me.chk_STATUS.AutoSize = True
        Me.chk_STATUS.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_STATUS.Location = New System.Drawing.Point(9, 19)
        Me.chk_STATUS.Name = "chk_STATUS"
        Me.chk_STATUS.Size = New System.Drawing.Size(110, 19)
        Me.chk_STATUS.TabIndex = 68
        Me.chk_STATUS.Text = "Print All Status"
        Me.chk_STATUS.UseVisualStyleBackColor = True
        '
        'chk_Filter_Field
        '
        Me.chk_Filter_Field.FormattingEnabled = True
        Me.chk_Filter_Field.Location = New System.Drawing.Point(10, 46)
        Me.chk_Filter_Field.Name = "chk_Filter_Field"
        Me.chk_Filter_Field.Size = New System.Drawing.Size(268, 191)
        Me.chk_Filter_Field.TabIndex = 69
        '
        'ChK_Memberstatus
        '
        Me.ChK_Memberstatus.FormattingEnabled = True
        Me.ChK_Memberstatus.Items.AddRange(New Object() {"ACTIVE", "INACTIVE", "DEFAULTER", "SUSPENDED", "TERMINATED", "DECEASED", "EXPIRED", "RESIGNED", "POSTED", "CEASED"})
        Me.ChK_Memberstatus.Location = New System.Drawing.Point(9, 45)
        Me.ChK_Memberstatus.Name = "ChK_Memberstatus"
        Me.ChK_Memberstatus.Size = New System.Drawing.Size(268, 191)
        Me.ChK_Memberstatus.TabIndex = 70
        '
        'tbx_Filter_From
        '
        Me.tbx_Filter_From.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Filter_From.Location = New System.Drawing.Point(134, 15)
        Me.tbx_Filter_From.MaxLength = 10
        Me.tbx_Filter_From.Name = "tbx_Filter_From"
        Me.tbx_Filter_From.Size = New System.Drawing.Size(100, 21)
        Me.tbx_Filter_From.TabIndex = 71
        '
        'tbx_filter_To
        '
        Me.tbx_filter_To.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_filter_To.Location = New System.Drawing.Point(455, 19)
        Me.tbx_filter_To.MaxLength = 10
        Me.tbx_filter_To.Name = "tbx_filter_To"
        Me.tbx_filter_To.Size = New System.Drawing.Size(100, 21)
        Me.tbx_filter_To.TabIndex = 72
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "FROM DATE"
        '
        'Dtp_From
        '
        Me.Dtp_From.CustomFormat = "dd/MM/yyy"
        Me.Dtp_From.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp_From.Location = New System.Drawing.Point(134, 48)
        Me.Dtp_From.Name = "Dtp_From"
        Me.Dtp_From.Size = New System.Drawing.Size(100, 20)
        Me.Dtp_From.TabIndex = 74
        '
        'Dtp_To
        '
        Me.Dtp_To.CustomFormat = "dd/MM/yyyy"
        Me.Dtp_To.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp_To.Location = New System.Drawing.Point(455, 52)
        Me.Dtp_To.Name = "Dtp_To"
        Me.Dtp_To.Size = New System.Drawing.Size(100, 20)
        Me.Dtp_To.TabIndex = 75
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 15)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "MCODE FROM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(355, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "MCODE TO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(355, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 15)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "TO DATE"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.chk_Filter_Field)
        Me.GroupBox1.Controls.Add(Me.txtStatus)
        Me.GroupBox1.Controls.Add(Me.txtCategory)
        Me.GroupBox1.Controls.Add(Me.chk_PrintAll)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(201, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 252)
        Me.GroupBox1.TabIndex = 79
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MEMBER CATEGORY"
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(178, 211)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(100, 22)
        Me.txtStatus.TabIndex = 71
        Me.txtStatus.Visible = False
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(24, 211)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(100, 22)
        Me.txtCategory.TabIndex = 70
        Me.txtCategory.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.ChK_Memberstatus)
        Me.GroupBox2.Controls.Add(Me.chk_STATUS)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(541, 113)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(286, 252)
        Me.GroupBox2.TabIndex = 80
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MEMBER STATUS"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.cmd_MCodeToHelp)
        Me.GroupBox3.Controls.Add(Me.cmd_MCodefromHelp)
        Me.GroupBox3.Controls.Add(Me.tbx_Filter_From)
        Me.GroupBox3.Controls.Add(Me.tbx_filter_To)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Dtp_From)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Dtp_To)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(201, 559)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(626, 88)
        Me.GroupBox3.TabIndex = 70
        Me.GroupBox3.TabStop = False
        '
        'cmd_MCodeToHelp
        '
        Me.cmd_MCodeToHelp.BackgroundImage = CType(resources.GetObject("cmd_MCodeToHelp.BackgroundImage"), System.Drawing.Image)
        Me.cmd_MCodeToHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_MCodeToHelp.Location = New System.Drawing.Point(560, 17)
        Me.cmd_MCodeToHelp.Name = "cmd_MCodeToHelp"
        Me.cmd_MCodeToHelp.Size = New System.Drawing.Size(40, 23)
        Me.cmd_MCodeToHelp.TabIndex = 80
        Me.cmd_MCodeToHelp.UseVisualStyleBackColor = True
        '
        'cmd_MCodefromHelp
        '
        Me.cmd_MCodefromHelp.BackgroundImage = CType(resources.GetObject("cmd_MCodefromHelp.BackgroundImage"), System.Drawing.Image)
        Me.cmd_MCodefromHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_MCodefromHelp.Location = New System.Drawing.Point(237, 14)
        Me.cmd_MCodefromHelp.Name = "cmd_MCodefromHelp"
        Me.cmd_MCodefromHelp.Size = New System.Drawing.Size(40, 23)
        Me.cmd_MCodefromHelp.TabIndex = 79
        Me.cmd_MCodefromHelp.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Chk_Memsta)
        Me.GroupBox4.Controls.Add(Me.chk_terminate_det)
        Me.GroupBox4.Controls.Add(Me.chk_expired_det)
        Me.GroupBox4.Controls.Add(Me.chk_expiry_det)
        Me.GroupBox4.Controls.Add(Me.Chk_History)
        Me.GroupBox4.Controls.Add(Me.Chk_Dojwisediff)
        Me.GroupBox4.Controls.Add(Me.Chk_details)
        Me.GroupBox4.Controls.Add(Me.chk_member_status_sum)
        Me.GroupBox4.Controls.Add(Me.Chk_sumry)
        Me.GroupBox4.Location = New System.Drawing.Point(201, 389)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(626, 147)
        Me.GroupBox4.TabIndex = 81
        Me.GroupBox4.TabStop = False
        '
        'Chk_Memsta
        '
        Me.Chk_Memsta.AutoSize = True
        Me.Chk_Memsta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Memsta.Location = New System.Drawing.Point(329, 119)
        Me.Chk_Memsta.Name = "Chk_Memsta"
        Me.Chk_Memsta.Size = New System.Drawing.Size(122, 20)
        Me.Chk_Memsta.TabIndex = 11
        Me.Chk_Memsta.Text = "Member Status"
        Me.Chk_Memsta.UseVisualStyleBackColor = True
        '
        'chk_terminate_det
        '
        Me.chk_terminate_det.AutoSize = True
        Me.chk_terminate_det.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_terminate_det.Location = New System.Drawing.Point(329, 98)
        Me.chk_terminate_det.Name = "chk_terminate_det"
        Me.chk_terminate_det.Size = New System.Drawing.Size(150, 20)
        Me.chk_terminate_det.TabIndex = 10
        Me.chk_terminate_det.Text = "Termination Details"
        Me.chk_terminate_det.UseVisualStyleBackColor = True
        '
        'chk_expired_det
        '
        Me.chk_expired_det.AutoSize = True
        Me.chk_expired_det.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_expired_det.Location = New System.Drawing.Point(329, 71)
        Me.chk_expired_det.Name = "chk_expired_det"
        Me.chk_expired_det.Size = New System.Drawing.Size(123, 20)
        Me.chk_expired_det.TabIndex = 9
        Me.chk_expired_det.Text = "Expired Details"
        Me.chk_expired_det.UseVisualStyleBackColor = True
        '
        'chk_expiry_det
        '
        Me.chk_expiry_det.AutoSize = True
        Me.chk_expiry_det.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_expiry_det.Location = New System.Drawing.Point(329, 44)
        Me.chk_expiry_det.Name = "chk_expiry_det"
        Me.chk_expiry_det.Size = New System.Drawing.Size(114, 20)
        Me.chk_expiry_det.TabIndex = 8
        Me.chk_expiry_det.Text = "Expiry Details"
        Me.chk_expiry_det.UseVisualStyleBackColor = True
        '
        'Chk_History
        '
        Me.Chk_History.AutoSize = True
        Me.Chk_History.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_History.Location = New System.Drawing.Point(329, 19)
        Me.Chk_History.Name = "Chk_History"
        Me.Chk_History.Size = New System.Drawing.Size(173, 20)
        Me.Chk_History.TabIndex = 4
        Me.Chk_History.Text = "Member Status History "
        Me.Chk_History.UseVisualStyleBackColor = True
        '
        'Chk_Dojwisediff
        '
        Me.Chk_Dojwisediff.AutoSize = True
        Me.Chk_Dojwisediff.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Dojwisediff.Location = New System.Drawing.Point(29, 101)
        Me.Chk_Dojwisediff.Name = "Chk_Dojwisediff"
        Me.Chk_Dojwisediff.Size = New System.Drawing.Size(201, 20)
        Me.Chk_Dojwisediff.TabIndex = 3
        Me.Chk_Dojwisediff.Text = "Membership for No of Years"
        Me.Chk_Dojwisediff.UseVisualStyleBackColor = True
        '
        'Chk_details
        '
        Me.Chk_details.AutoSize = True
        Me.Chk_details.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_details.Location = New System.Drawing.Point(29, 74)
        Me.Chk_details.Name = "Chk_details"
        Me.Chk_details.Size = New System.Drawing.Size(164, 20)
        Me.Chk_details.TabIndex = 2
        Me.Chk_details.Text = "Member Details [DOJ]"
        Me.Chk_details.UseVisualStyleBackColor = True
        '
        'chk_member_status_sum
        '
        Me.chk_member_status_sum.AutoSize = True
        Me.chk_member_status_sum.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_member_status_sum.Location = New System.Drawing.Point(29, 47)
        Me.chk_member_status_sum.Name = "chk_member_status_sum"
        Me.chk_member_status_sum.Size = New System.Drawing.Size(173, 20)
        Me.chk_member_status_sum.TabIndex = 1
        Me.chk_member_status_sum.Text = "Member Status Details "
        Me.chk_member_status_sum.UseVisualStyleBackColor = True
        '
        'Chk_sumry
        '
        Me.Chk_sumry.AutoSize = True
        Me.Chk_sumry.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_sumry.Location = New System.Drawing.Point(29, 20)
        Me.Chk_sumry.Name = "Chk_sumry"
        Me.Chk_sumry.Size = New System.Drawing.Size(92, 20)
        Me.Chk_sumry.TabIndex = 0
        Me.Chk_sumry.Text = "Summary "
        Me.Chk_sumry.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.chk_dt_details)
        Me.GroupBox5.Controls.Add(Me.chk_dt_summary)
        Me.GroupBox5.Location = New System.Drawing.Point(344, 525)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(287, 35)
        Me.GroupBox5.TabIndex = 82
        Me.GroupBox5.TabStop = False
        '
        'chk_dt_details
        '
        Me.chk_dt_details.AutoSize = True
        Me.chk_dt_details.Location = New System.Drawing.Point(135, 12)
        Me.chk_dt_details.Name = "chk_dt_details"
        Me.chk_dt_details.Size = New System.Drawing.Size(58, 17)
        Me.chk_dt_details.TabIndex = 1
        Me.chk_dt_details.Text = "Details"
        Me.chk_dt_details.UseVisualStyleBackColor = True
        '
        'chk_dt_summary
        '
        Me.chk_dt_summary.AutoSize = True
        Me.chk_dt_summary.Location = New System.Drawing.Point(35, 12)
        Me.chk_dt_summary.Name = "chk_dt_summary"
        Me.chk_dt_summary.Size = New System.Drawing.Size(69, 17)
        Me.chk_dt_summary.TabIndex = 0
        Me.chk_dt_summary.Text = "Summary"
        Me.chk_dt_summary.UseVisualStyleBackColor = True
        '
        'RPT_MEMBERSTATUS_REPORT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources._111in1024res
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox10)
        Me.ForeColor = System.Drawing.SystemColors.MenuText
        Me.KeyPreview = True
        Me.Name = "RPT_MEMBERSTATUS_REPORT"
        Me.Text = "MEMBER STATUS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btn_print As System.Windows.Forms.Button
    Friend WithEvents btn_view As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chk_PrintAll As System.Windows.Forms.CheckBox
    Friend WithEvents chk_STATUS As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Filter_Field As System.Windows.Forms.CheckedListBox
    Friend WithEvents ChK_Memberstatus As System.Windows.Forms.CheckedListBox
    Friend WithEvents tbx_Filter_From As System.Windows.Forms.TextBox
    Friend WithEvents tbx_filter_To As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Dtp_From As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dtp_To As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_MCodeToHelp As System.Windows.Forms.Button
    Friend WithEvents cmd_MCodefromHelp As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Chk_History As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_Dojwisediff As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_details As System.Windows.Forms.CheckBox
    Friend WithEvents chk_member_status_sum As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_sumry As System.Windows.Forms.CheckBox
    Friend WithEvents chk_terminate_det As System.Windows.Forms.CheckBox
    Friend WithEvents chk_expired_det As System.Windows.Forms.CheckBox
    Friend WithEvents chk_expiry_det As System.Windows.Forms.CheckBox
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_dt_details As System.Windows.Forms.CheckBox
    Friend WithEvents chk_dt_summary As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_Memsta As System.Windows.Forms.CheckBox

End Class
