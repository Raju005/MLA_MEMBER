<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OUTSTAND_MEMREP_LIST
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OUTSTAND_MEMREP_LIST))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSelection = New System.Windows.Forms.TextBox()
        Me.optMCode = New System.Windows.Forms.RadioButton()
        Me.optAccName = New System.Windows.Forms.RadioButton()
        Me.OptOthers = New System.Windows.Forms.RadioButton()
        Me.Rdo_arriarslist = New System.Windows.Forms.RadioButton()
        Me.RDB_CREDIT_STOP_LIST = New System.Windows.Forms.RadioButton()
        Me.RDB_defaulter_list = New System.Windows.Forms.RadioButton()
        Me.RDB_OUTSNDING_LIST = New System.Windows.Forms.RadioButton()
        Me.CHK_SELECT = New System.Windows.Forms.CheckBox()
        Me.CHK_MEMBERCATEGORY = New System.Windows.Forms.CheckBox()
        Me.CHK_STATUS = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CHKLIST_SELECT = New System.Windows.Forms.CheckedListBox()
        Me.chklist_Membername = New System.Windows.Forms.CheckedListBox()
        Me.ChKLIST_Memberstatus = New System.Windows.Forms.CheckedListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXT_AMOUNT = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DTPBILLDATE = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DTP_RECDATE = New System.Windows.Forms.DateTimePicker()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_view = New System.Windows.Forms.Button()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Rnd_nousage = New System.Windows.Forms.RadioButton()
        Me.NonReciept = New System.Windows.Forms.RadioButton()
        Me.RDN_DEBIT = New System.Windows.Forms.RadioButton()
        Me.RDN_CREDIT = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Btn_sms = New System.Windows.Forms.Button()
        Me.Chk_Doller = New System.Windows.Forms.CheckBox()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.Chk_sms1 = New System.Windows.Forms.CheckBox()
        Me.Chk_sms2 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(178, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "OUTSTANDING DETAILS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(201, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SEARCH"
        Me.Label2.Visible = False
        '
        'txtSelection
        '
        Me.txtSelection.Location = New System.Drawing.Point(258, 118)
        Me.txtSelection.Name = "txtSelection"
        Me.txtSelection.Size = New System.Drawing.Size(174, 20)
        Me.txtSelection.TabIndex = 2
        Me.txtSelection.Visible = False
        '
        'optMCode
        '
        Me.optMCode.AutoSize = True
        Me.optMCode.BackColor = System.Drawing.Color.Transparent
        Me.optMCode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMCode.Location = New System.Drawing.Point(451, 121)
        Me.optMCode.Name = "optMCode"
        Me.optMCode.Size = New System.Drawing.Size(57, 19)
        Me.optMCode.TabIndex = 3
        Me.optMCode.TabStop = True
        Me.optMCode.Text = "CODE"
        Me.optMCode.UseVisualStyleBackColor = False
        Me.optMCode.Visible = False
        '
        'optAccName
        '
        Me.optAccName.AutoSize = True
        Me.optAccName.BackColor = System.Drawing.Color.Transparent
        Me.optAccName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAccName.Location = New System.Drawing.Point(576, 121)
        Me.optAccName.Name = "optAccName"
        Me.optAccName.Size = New System.Drawing.Size(58, 19)
        Me.optAccName.TabIndex = 4
        Me.optAccName.TabStop = True
        Me.optAccName.Text = "NAME"
        Me.optAccName.UseVisualStyleBackColor = False
        Me.optAccName.Visible = False
        '
        'OptOthers
        '
        Me.OptOthers.AutoSize = True
        Me.OptOthers.BackColor = System.Drawing.Color.Transparent
        Me.OptOthers.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptOthers.Location = New System.Drawing.Point(703, 121)
        Me.OptOthers.Name = "OptOthers"
        Me.OptOthers.Size = New System.Drawing.Size(72, 19)
        Me.OptOthers.TabIndex = 5
        Me.OptOthers.TabStop = True
        Me.OptOthers.Text = "OTHERS"
        Me.OptOthers.UseVisualStyleBackColor = False
        Me.OptOthers.Visible = False
        '
        'Rdo_arriarslist
        '
        Me.Rdo_arriarslist.AutoSize = True
        Me.Rdo_arriarslist.BackColor = System.Drawing.Color.Transparent
        Me.Rdo_arriarslist.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdo_arriarslist.Location = New System.Drawing.Point(497, 19)
        Me.Rdo_arriarslist.Name = "Rdo_arriarslist"
        Me.Rdo_arriarslist.Size = New System.Drawing.Size(112, 20)
        Me.Rdo_arriarslist.TabIndex = 6
        Me.Rdo_arriarslist.TabStop = True
        Me.Rdo_arriarslist.Text = "ARREAR LIST"
        Me.Rdo_arriarslist.UseVisualStyleBackColor = False
        '
        'RDB_CREDIT_STOP_LIST
        '
        Me.RDB_CREDIT_STOP_LIST.AutoSize = True
        Me.RDB_CREDIT_STOP_LIST.BackColor = System.Drawing.Color.Transparent
        Me.RDB_CREDIT_STOP_LIST.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDB_CREDIT_STOP_LIST.Location = New System.Drawing.Point(186, 19)
        Me.RDB_CREDIT_STOP_LIST.Name = "RDB_CREDIT_STOP_LIST"
        Me.RDB_CREDIT_STOP_LIST.Size = New System.Drawing.Size(146, 20)
        Me.RDB_CREDIT_STOP_LIST.TabIndex = 7
        Me.RDB_CREDIT_STOP_LIST.TabStop = True
        Me.RDB_CREDIT_STOP_LIST.Text = "CREDIT STOP LIST"
        Me.RDB_CREDIT_STOP_LIST.UseVisualStyleBackColor = False
        '
        'RDB_defaulter_list
        '
        Me.RDB_defaulter_list.AutoSize = True
        Me.RDB_defaulter_list.BackColor = System.Drawing.Color.Transparent
        Me.RDB_defaulter_list.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDB_defaulter_list.Location = New System.Drawing.Point(346, 19)
        Me.RDB_defaulter_list.Name = "RDB_defaulter_list"
        Me.RDB_defaulter_list.Size = New System.Drawing.Size(133, 20)
        Me.RDB_defaulter_list.TabIndex = 8
        Me.RDB_defaulter_list.TabStop = True
        Me.RDB_defaulter_list.Text = "DEFAULTER LIST"
        Me.RDB_defaulter_list.UseVisualStyleBackColor = False
        '
        'RDB_OUTSNDING_LIST
        '
        Me.RDB_OUTSNDING_LIST.AutoSize = True
        Me.RDB_OUTSNDING_LIST.BackColor = System.Drawing.Color.Transparent
        Me.RDB_OUTSNDING_LIST.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDB_OUTSNDING_LIST.Location = New System.Drawing.Point(21, 19)
        Me.RDB_OUTSNDING_LIST.Name = "RDB_OUTSNDING_LIST"
        Me.RDB_OUTSNDING_LIST.Size = New System.Drawing.Size(152, 20)
        Me.RDB_OUTSNDING_LIST.TabIndex = 9
        Me.RDB_OUTSNDING_LIST.TabStop = True
        Me.RDB_OUTSNDING_LIST.Text = "OUTSTANDING LIST"
        Me.RDB_OUTSNDING_LIST.UseVisualStyleBackColor = False
        '
        'CHK_SELECT
        '
        Me.CHK_SELECT.AutoSize = True
        Me.CHK_SELECT.BackColor = System.Drawing.Color.Transparent
        Me.CHK_SELECT.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_SELECT.Location = New System.Drawing.Point(10, 40)
        Me.CHK_SELECT.Name = "CHK_SELECT"
        Me.CHK_SELECT.Size = New System.Drawing.Size(88, 20)
        Me.CHK_SELECT.TabIndex = 10
        Me.CHK_SELECT.Text = "SELECT ALL"
        Me.CHK_SELECT.UseVisualStyleBackColor = False
        '
        'CHK_MEMBERCATEGORY
        '
        Me.CHK_MEMBERCATEGORY.AutoSize = True
        Me.CHK_MEMBERCATEGORY.BackColor = System.Drawing.Color.Transparent
        Me.CHK_MEMBERCATEGORY.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_MEMBERCATEGORY.Location = New System.Drawing.Point(9, 41)
        Me.CHK_MEMBERCATEGORY.Name = "CHK_MEMBERCATEGORY"
        Me.CHK_MEMBERCATEGORY.Size = New System.Drawing.Size(95, 19)
        Me.CHK_MEMBERCATEGORY.TabIndex = 11
        Me.CHK_MEMBERCATEGORY.Text = "SELECT ALL"
        Me.CHK_MEMBERCATEGORY.UseVisualStyleBackColor = False
        '
        'CHK_STATUS
        '
        Me.CHK_STATUS.AutoSize = True
        Me.CHK_STATUS.BackColor = System.Drawing.Color.Transparent
        Me.CHK_STATUS.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_STATUS.Location = New System.Drawing.Point(8, 40)
        Me.CHK_STATUS.Name = "CHK_STATUS"
        Me.CHK_STATUS.Size = New System.Drawing.Size(88, 20)
        Me.CHK_STATUS.TabIndex = 12
        Me.CHK_STATUS.Text = "SELECT ALL"
        Me.CHK_STATUS.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "PRESS(F2) S(D)ELECT ALL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "PRESS(F2) S(D)ELECT ALL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "PRESS(F2) S(D)ELECT ALL"
        '
        'CHKLIST_SELECT
        '
        Me.CHKLIST_SELECT.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKLIST_SELECT.FormattingEnabled = True
        Me.CHKLIST_SELECT.Location = New System.Drawing.Point(6, 67)
        Me.CHKLIST_SELECT.Name = "CHKLIST_SELECT"
        Me.CHKLIST_SELECT.Size = New System.Drawing.Size(210, 244)
        Me.CHKLIST_SELECT.TabIndex = 16
        '
        'chklist_Membername
        '
        Me.chklist_Membername.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chklist_Membername.FormattingEnabled = True
        Me.chklist_Membername.Location = New System.Drawing.Point(9, 68)
        Me.chklist_Membername.Name = "chklist_Membername"
        Me.chklist_Membername.Size = New System.Drawing.Size(209, 244)
        Me.chklist_Membername.TabIndex = 17
        '
        'ChKLIST_Memberstatus
        '
        Me.ChKLIST_Memberstatus.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChKLIST_Memberstatus.FormattingEnabled = True
        Me.ChKLIST_Memberstatus.Items.AddRange(New Object() {"1.ABSENTEE", "2.DELETED", "3.EXPIRED", "4.INACTIVE", "5.LIVE", "6.RESIGNED", "7.SURRENDERED", "8.ACTIVE", "9.POSTED", "10.CEASED"})
        Me.ChKLIST_Memberstatus.Location = New System.Drawing.Point(6, 67)
        Me.ChKLIST_Memberstatus.Name = "ChKLIST_Memberstatus"
        Me.ChKLIST_Memberstatus.Size = New System.Drawing.Size(175, 244)
        Me.ChKLIST_Memberstatus.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(54, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 16)
        Me.Label9.TabIndex = 893
        Me.Label9.Text = "AMOUNT"
        '
        'TXT_AMOUNT
        '
        Me.TXT_AMOUNT.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_AMOUNT.Location = New System.Drawing.Point(114, 19)
        Me.TXT_AMOUNT.Name = "TXT_AMOUNT"
        Me.TXT_AMOUNT.Size = New System.Drawing.Size(100, 22)
        Me.TXT_AMOUNT.TabIndex = 894
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(236, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 16)
        Me.Label10.TabIndex = 895
        Me.Label10.Text = "BILL DATE"
        '
        'DTPBILLDATE
        '
        Me.DTPBILLDATE.CustomFormat = "dd/MM/yyyy"
        Me.DTPBILLDATE.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPBILLDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPBILLDATE.Location = New System.Drawing.Point(309, 19)
        Me.DTPBILLDATE.Name = "DTPBILLDATE"
        Me.DTPBILLDATE.Size = New System.Drawing.Size(94, 21)
        Me.DTPBILLDATE.TabIndex = 896
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(418, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 16)
        Me.Label11.TabIndex = 897
        Me.Label11.Text = "RECEIPT DATE"
        '
        'DTP_RECDATE
        '
        Me.DTP_RECDATE.CustomFormat = "dd/MM/yyyy"
        Me.DTP_RECDATE.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_RECDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_RECDATE.Location = New System.Drawing.Point(516, 19)
        Me.DTP_RECDATE.Name = "DTP_RECDATE"
        Me.DTP_RECDATE.Size = New System.Drawing.Size(99, 21)
        Me.DTP_RECDATE.TabIndex = 898
        '
        'btn_exit
        '
        Me.btn_exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Image = CType(resources.GetObject("btn_exit.Image"), System.Drawing.Image)
        Me.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_exit.Location = New System.Drawing.Point(4, 189)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(137, 50)
        Me.btn_exit.TabIndex = 902
        Me.btn_exit.Text = "Exit[F11]"
        Me.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Image = CType(resources.GetObject("btn_clear.Image"), System.Drawing.Image)
        Me.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clear.Location = New System.Drawing.Point(4, 11)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(137, 50)
        Me.btn_clear.TabIndex = 899
        Me.btn_clear.Text = "Clear[F6]"
        Me.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_view
        '
        Me.btn_view.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_view.Image = CType(resources.GetObject("btn_view.Image"), System.Drawing.Image)
        Me.btn_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_view.Location = New System.Drawing.Point(3, 72)
        Me.btn_view.Name = "btn_view"
        Me.btn_view.Size = New System.Drawing.Size(137, 50)
        Me.btn_view.TabIndex = 901
        Me.btn_view.Text = "View[F9]"
        Me.btn_view.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_view.UseVisualStyleBackColor = True
        '
        'btn_print
        '
        Me.btn_print.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_print.Location = New System.Drawing.Point(3, 131)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(137, 50)
        Me.btn_print.TabIndex = 900
        Me.btn_print.Text = "Print[F12]"
        Me.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CHK_MEMBERCATEGORY)
        Me.GroupBox1.Controls.Add(Me.chklist_Membername)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(183, 161)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 325)
        Me.GroupBox1.TabIndex = 903
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MEMBER TYPE"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CHK_SELECT)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.CHKLIST_SELECT)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(419, 162)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(229, 324)
        Me.GroupBox2.TabIndex = 904
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MEMBER LIST"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.CHK_STATUS)
        Me.GroupBox3.Controls.Add(Me.ChKLIST_Memberstatus)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(654, 162)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(190, 324)
        Me.GroupBox3.TabIndex = 905
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "MEMBER STATUS"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Rnd_nousage)
        Me.GroupBox4.Controls.Add(Me.NonReciept)
        Me.GroupBox4.Controls.Add(Me.RDN_DEBIT)
        Me.GroupBox4.Controls.Add(Me.RDN_CREDIT)
        Me.GroupBox4.Controls.Add(Me.RDB_CREDIT_STOP_LIST)
        Me.GroupBox4.Controls.Add(Me.Rdo_arriarslist)
        Me.GroupBox4.Controls.Add(Me.RDB_defaulter_list)
        Me.GroupBox4.Controls.Add(Me.RDB_OUTSNDING_LIST)
        Me.GroupBox4.Location = New System.Drawing.Point(192, 557)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(643, 82)
        Me.GroupBox4.TabIndex = 906
        Me.GroupBox4.TabStop = False
        '
        'Rnd_nousage
        '
        Me.Rnd_nousage.AutoSize = True
        Me.Rnd_nousage.BackColor = System.Drawing.Color.Transparent
        Me.Rnd_nousage.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rnd_nousage.Location = New System.Drawing.Point(398, 44)
        Me.Rnd_nousage.Name = "Rnd_nousage"
        Me.Rnd_nousage.Size = New System.Drawing.Size(183, 20)
        Me.Rnd_nousage.TabIndex = 913
        Me.Rnd_nousage.TabStop = True
        Me.Rnd_nousage.Text = "Non Receipts and No Kot"
        Me.Rnd_nousage.UseVisualStyleBackColor = False
        '
        'NonReciept
        '
        Me.NonReciept.AutoSize = True
        Me.NonReciept.BackColor = System.Drawing.Color.Transparent
        Me.NonReciept.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NonReciept.Location = New System.Drawing.Point(279, 44)
        Me.NonReciept.Name = "NonReciept"
        Me.NonReciept.Size = New System.Drawing.Size(113, 20)
        Me.NonReciept.TabIndex = 912
        Me.NonReciept.TabStop = True
        Me.NonReciept.Text = "Non Receipts "
        Me.NonReciept.UseVisualStyleBackColor = False
        '
        'RDN_DEBIT
        '
        Me.RDN_DEBIT.AutoSize = True
        Me.RDN_DEBIT.BackColor = System.Drawing.Color.Transparent
        Me.RDN_DEBIT.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDN_DEBIT.Location = New System.Drawing.Point(185, 45)
        Me.RDN_DEBIT.Name = "RDN_DEBIT"
        Me.RDN_DEBIT.Size = New System.Drawing.Size(88, 19)
        Me.RDN_DEBIT.TabIndex = 911
        Me.RDN_DEBIT.TabStop = True
        Me.RDN_DEBIT.Text = "DEBIT LIST"
        Me.RDN_DEBIT.UseVisualStyleBackColor = False
        Me.RDN_DEBIT.Visible = False
        '
        'RDN_CREDIT
        '
        Me.RDN_CREDIT.AutoSize = True
        Me.RDN_CREDIT.BackColor = System.Drawing.Color.Transparent
        Me.RDN_CREDIT.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDN_CREDIT.Location = New System.Drawing.Point(20, 45)
        Me.RDN_CREDIT.Name = "RDN_CREDIT"
        Me.RDN_CREDIT.Size = New System.Drawing.Size(98, 19)
        Me.RDN_CREDIT.TabIndex = 910
        Me.RDN_CREDIT.TabStop = True
        Me.RDN_CREDIT.Text = "CREDIT LIST"
        Me.RDN_CREDIT.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.DTPBILLDATE)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.TXT_AMOUNT)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.DTP_RECDATE)
        Me.GroupBox5.Location = New System.Drawing.Point(192, 492)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(643, 56)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.Btn_sms)
        Me.GroupBox6.Controls.Add(Me.btn_clear)
        Me.GroupBox6.Controls.Add(Me.btn_print)
        Me.GroupBox6.Controls.Add(Me.btn_view)
        Me.GroupBox6.Controls.Add(Me.btn_exit)
        Me.GroupBox6.Location = New System.Drawing.Point(850, 212)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(143, 304)
        Me.GroupBox6.TabIndex = 907
        Me.GroupBox6.TabStop = False
        '
        'Btn_sms
        '
        Me.Btn_sms.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_sms.ForeColor = System.Drawing.Color.Black
        Me.Btn_sms.Image = Global.Bengal_MemberMaster.My.Resources.Resources.images2
        Me.Btn_sms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_sms.Location = New System.Drawing.Point(3, 245)
        Me.Btn_sms.Name = "Btn_sms"
        Me.Btn_sms.Size = New System.Drawing.Size(137, 50)
        Me.Btn_sms.TabIndex = 909
        Me.Btn_sms.Text = "SMS"
        Me.Btn_sms.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Chk_Doller
        '
        Me.Chk_Doller.AutoSize = True
        Me.Chk_Doller.BackColor = System.Drawing.Color.Transparent
        Me.Chk_Doller.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Doller.Location = New System.Drawing.Point(209, 645)
        Me.Chk_Doller.Name = "Chk_Doller"
        Me.Chk_Doller.Size = New System.Drawing.Size(115, 20)
        Me.Chk_Doller.TabIndex = 908
        Me.Chk_Doller.Text = "Doller Outstanding"
        Me.Chk_Doller.UseVisualStyleBackColor = False
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(369, 645)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(322, 20)
        Me.txtCategory.TabIndex = 909
        Me.txtCategory.Visible = False
        '
        'Chk_sms1
        '
        Me.Chk_sms1.AutoSize = True
        Me.Chk_sms1.BackColor = System.Drawing.Color.Transparent
        Me.Chk_sms1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_sms1.Location = New System.Drawing.Point(311, 539)
        Me.Chk_sms1.Name = "Chk_sms1"
        Me.Chk_sms1.Size = New System.Drawing.Size(72, 22)
        Me.Chk_sms1.TabIndex = 899
        Me.Chk_sms1.Text = "SMS1"
        Me.Chk_sms1.UseVisualStyleBackColor = False
        '
        'Chk_sms2
        '
        Me.Chk_sms2.AutoSize = True
        Me.Chk_sms2.BackColor = System.Drawing.Color.Transparent
        Me.Chk_sms2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_sms2.Location = New System.Drawing.Point(389, 539)
        Me.Chk_sms2.Name = "Chk_sms2"
        Me.Chk_sms2.Size = New System.Drawing.Size(137, 22)
        Me.Chk_sms2.TabIndex = 910
        Me.Chk_sms2.Text = "CR LIMIT SMS"
        Me.Chk_sms2.UseVisualStyleBackColor = False
        '
        'OUTSTAND_MEMREP_LIST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.Chk_sms2)
        Me.Controls.Add(Me.Chk_sms1)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.Chk_Doller)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.OptOthers)
        Me.Controls.Add(Me.optAccName)
        Me.Controls.Add(Me.optMCode)
        Me.Controls.Add(Me.txtSelection)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "OUTSTAND_MEMREP_LIST"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OUTSTANDING LIST"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
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
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSelection As System.Windows.Forms.TextBox
    Friend WithEvents optMCode As System.Windows.Forms.RadioButton
    Friend WithEvents optAccName As System.Windows.Forms.RadioButton
    Friend WithEvents OptOthers As System.Windows.Forms.RadioButton
    Friend WithEvents Rdo_arriarslist As System.Windows.Forms.RadioButton
    Friend WithEvents RDB_CREDIT_STOP_LIST As System.Windows.Forms.RadioButton
    Friend WithEvents RDB_defaulter_list As System.Windows.Forms.RadioButton
    Friend WithEvents RDB_OUTSNDING_LIST As System.Windows.Forms.RadioButton
    Friend WithEvents CHK_SELECT As System.Windows.Forms.CheckBox
    Friend WithEvents CHK_MEMBERCATEGORY As System.Windows.Forms.CheckBox
    Friend WithEvents CHK_STATUS As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CHKLIST_SELECT As System.Windows.Forms.CheckedListBox
    Friend WithEvents chklist_Membername As System.Windows.Forms.CheckedListBox
    Friend WithEvents ChKLIST_Memberstatus As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TXT_AMOUNT As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DTPBILLDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DTP_RECDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btn_view As System.Windows.Forms.Button
    Friend WithEvents btn_print As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Chk_Doller As System.Windows.Forms.CheckBox
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents Btn_sms As System.Windows.Forms.Button
    Friend WithEvents RDN_DEBIT As System.Windows.Forms.RadioButton
    Friend WithEvents RDN_CREDIT As System.Windows.Forms.RadioButton
    Friend WithEvents Chk_sms1 As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_sms2 As System.Windows.Forms.CheckBox
    Friend WithEvents NonReciept As System.Windows.Forms.RadioButton
    Friend WithEvents Rnd_nousage As System.Windows.Forms.RadioButton
End Class
