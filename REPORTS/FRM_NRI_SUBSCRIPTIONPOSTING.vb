Imports System.Data.SqlClient
Public Class FRM_NRI_SUBSCRIPTIONPOSTING
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
    Friend WithEvents ChkList_month As System.Windows.Forms.CheckedListBox
    Friend WithEvents dtp_year As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents cbo_BillingBasis As System.Windows.Forms.ComboBox
    Friend WithEvents chk_Filter_Field As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ssGrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents process As System.Windows.Forms.Button
    Friend WithEvents SSGRID1 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents subsamount As System.Windows.Forms.TextBox
    Friend WithEvents totalamount As System.Windows.Forms.TextBox
    Friend WithEvents taxamount As System.Windows.Forms.TextBox
    Friend WithEvents SSGRID2 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents ltax As System.Windows.Forms.Label
    Friend WithEvents ltotal As System.Windows.Forms.Label
    Friend WithEvents lsubs As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Revert As System.Windows.Forms.Button
    Friend WithEvents Btn_close As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtp_docdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_docno As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Btn_ok As System.Windows.Forms.Button
    Friend WithEvents Btn_okD As System.Windows.Forms.Button
    Friend WithEvents btn_process As System.Windows.Forms.Button
    Friend WithEvents Overdue As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtp_recdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents chk_PrintAll As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_NRI_SUBSCRIPTIONPOSTING))
        Me.ChkList_month = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_year = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_docno = New System.Windows.Forms.TextBox()
        Me.dtp_docdate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.process = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chk_PrintAll = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chk_Filter_Field = New System.Windows.Forms.CheckedListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbo_BillingBasis = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.subsamount = New System.Windows.Forms.TextBox()
        Me.totalamount = New System.Windows.Forms.TextBox()
        Me.ltax = New System.Windows.Forms.Label()
        Me.ltotal = New System.Windows.Forms.Label()
        Me.lsubs = New System.Windows.Forms.Label()
        Me.taxamount = New System.Windows.Forms.TextBox()
        Me.btn_Revert = New System.Windows.Forms.Button()
        Me.Btn_close = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Btn_ok = New System.Windows.Forms.Button()
        Me.Btn_okD = New System.Windows.Forms.Button()
        Me.btn_process = New System.Windows.Forms.Button()
        Me.Overdue = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtp_recdate = New System.Windows.Forms.DateTimePicker()
        Me.SSGRID2 = New AxFPSpreadADO.AxfpSpread()
        Me.ssGrid = New AxFPSpreadADO.AxfpSpread()
        Me.SSGRID1 = New AxFPSpreadADO.AxfpSpread()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.SSGRID2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSGRID1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChkList_month
        '
        Me.ChkList_month.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ChkList_month.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkList_month.Location = New System.Drawing.Point(160, 80)
        Me.ChkList_month.Name = "ChkList_month"
        Me.ChkList_month.Size = New System.Drawing.Size(312, 208)
        Me.ChkList_month.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(149, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 15)
        Me.Label1.TabIndex = 358
        Me.Label1.Text = "POSTING FOR THE MONTH OF"
        '
        'dtp_year
        '
        Me.dtp_year.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_year.CustomFormat = "MMMMM"
        Me.dtp_year.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_year.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_year.Location = New System.Drawing.Point(336, 31)
        Me.dtp_year.Name = "dtp_year"
        Me.dtp_year.Size = New System.Drawing.Size(112, 21)
        Me.dtp_year.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txt_docno)
        Me.GroupBox1.Controls.Add(Me.dtp_docdate)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.process)
        Me.GroupBox1.Controls.Add(Me.cancel)
        Me.GroupBox1.Controls.Add(Me.txtdesc)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.dtp_year)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(181, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(671, 480)
        Me.GroupBox1.TabIndex = 360
        Me.GroupBox1.TabStop = False
        '
        'txt_docno
        '
        Me.txt_docno.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_docno.Location = New System.Drawing.Point(565, 16)
        Me.txt_docno.Name = "txt_docno"
        Me.txt_docno.Size = New System.Drawing.Size(100, 21)
        Me.txt_docno.TabIndex = 613
        '
        'dtp_docdate
        '
        Me.dtp_docdate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_docdate.CustomFormat = "yyyy"
        Me.dtp_docdate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_docdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_docdate.Location = New System.Drawing.Point(566, 40)
        Me.dtp_docdate.Name = "dtp_docdate"
        Me.dtp_docdate.Size = New System.Drawing.Size(100, 21)
        Me.dtp_docdate.TabIndex = 612
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(499, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 15)
        Me.Label7.TabIndex = 611
        Me.Label7.Text = "DOC. DATE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(498, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 15)
        Me.Label6.TabIndex = 610
        Me.Label6.Text = "DOC.NO."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(400, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 18)
        Me.Label5.TabIndex = 363
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(83, 401)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 360
        Me.Label3.Text = "DESCRIPTION"
        Me.Label3.Visible = False
        '
        'process
        '
        Me.process.BackgroundImage = CType(resources.GetObject("process.BackgroundImage"), System.Drawing.Image)
        Me.process.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.process.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.process.ForeColor = System.Drawing.Color.White
        Me.process.Image = CType(resources.GetObject("process.Image"), System.Drawing.Image)
        Me.process.Location = New System.Drawing.Point(86, 392)
        Me.process.Name = "process"
        Me.process.Size = New System.Drawing.Size(104, 32)
        Me.process.TabIndex = 381
        Me.process.Text = "Process [F4]"
        Me.process.Visible = False
        '
        'cancel
        '
        Me.cancel.BackgroundImage = CType(resources.GetObject("cancel.BackgroundImage"), System.Drawing.Image)
        Me.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cancel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel.ForeColor = System.Drawing.Color.White
        Me.cancel.Image = CType(resources.GetObject("cancel.Image"), System.Drawing.Image)
        Me.cancel.Location = New System.Drawing.Point(198, 392)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(104, 32)
        Me.cancel.TabIndex = 382
        Me.cancel.Text = "Cancel"
        Me.cancel.Visible = False
        '
        'txtdesc
        '
        Me.txtdesc.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesc.Location = New System.Drawing.Point(208, 403)
        Me.txtdesc.MaxLength = 50
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(392, 21)
        Me.txtdesc.TabIndex = 3
        Me.txtdesc.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chk_PrintAll)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.chk_Filter_Field)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.cbo_BillingBasis)
        Me.GroupBox3.Controls.Add(Me.ChkList_month)
        Me.GroupBox3.Location = New System.Drawing.Point(36, 58)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(596, 321)
        Me.GroupBox3.TabIndex = 364
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
        '
        'chk_PrintAll
        '
        Me.chk_PrintAll.BackColor = System.Drawing.Color.Transparent
        Me.chk_PrintAll.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PrintAll.Location = New System.Drawing.Point(8, 48)
        Me.chk_PrintAll.Name = "chk_PrintAll"
        Me.chk_PrintAll.Size = New System.Drawing.Size(8, 24)
        Me.chk_PrintAll.TabIndex = 394
        Me.chk_PrintAll.Text = "Select All Categorys"
        Me.chk_PrintAll.UseVisualStyleBackColor = False
        Me.chk_PrintAll.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(-8, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 16)
        Me.Label9.TabIndex = 389
        Me.Label9.Text = "CATEGORY "
        Me.Label9.Visible = False
        '
        'chk_Filter_Field
        '
        Me.chk_Filter_Field.BackColor = System.Drawing.Color.AntiqueWhite
        Me.chk_Filter_Field.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Filter_Field.Location = New System.Drawing.Point(8, 72)
        Me.chk_Filter_Field.Name = "chk_Filter_Field"
        Me.chk_Filter_Field.Size = New System.Drawing.Size(8, 242)
        Me.chk_Filter_Field.Sorted = True
        Me.chk_Filter_Field.TabIndex = 386
        Me.chk_Filter_Field.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(160, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 16)
        Me.Label4.TabIndex = 362
        Me.Label4.Text = "Select Month for  Posting"
        '
        'cbo_BillingBasis
        '
        Me.cbo_BillingBasis.BackColor = System.Drawing.Color.AntiqueWhite
        Me.cbo_BillingBasis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_BillingBasis.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbo_BillingBasis.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_BillingBasis.Location = New System.Drawing.Point(160, 56)
        Me.cbo_BillingBasis.Name = "cbo_BillingBasis"
        Me.cbo_BillingBasis.Size = New System.Drawing.Size(312, 24)
        Me.cbo_BillingBasis.TabIndex = 1
        '
        'CheckBox1
        '
        Me.CheckBox1.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(572, 48)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(112, 16)
        Me.CheckBox1.TabIndex = 365
        Me.CheckBox1.Text = "Auto Adjust"
        Me.CheckBox1.Visible = False
        '
        'subsamount
        '
        Me.subsamount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subsamount.Location = New System.Drawing.Point(656, 574)
        Me.subsamount.MaxLength = 15
        Me.subsamount.Name = "subsamount"
        Me.subsamount.ReadOnly = True
        Me.subsamount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.subsamount.Size = New System.Drawing.Size(160, 21)
        Me.subsamount.TabIndex = 384
        Me.subsamount.Visible = False
        '
        'totalamount
        '
        Me.totalamount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalamount.Location = New System.Drawing.Point(656, 639)
        Me.totalamount.MaxLength = 15
        Me.totalamount.Name = "totalamount"
        Me.totalamount.ReadOnly = True
        Me.totalamount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.totalamount.Size = New System.Drawing.Size(160, 21)
        Me.totalamount.TabIndex = 384
        Me.totalamount.Visible = False
        '
        'ltax
        '
        Me.ltax.AutoSize = True
        Me.ltax.BackColor = System.Drawing.Color.Transparent
        Me.ltax.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltax.Location = New System.Drawing.Point(552, 608)
        Me.ltax.Name = "ltax"
        Me.ltax.Size = New System.Drawing.Size(84, 16)
        Me.ltax.TabIndex = 360
        Me.ltax.Text = "Tax Amount"
        Me.ltax.Visible = False
        '
        'ltotal
        '
        Me.ltotal.AutoSize = True
        Me.ltotal.BackColor = System.Drawing.Color.Transparent
        Me.ltotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltotal.Location = New System.Drawing.Point(552, 639)
        Me.ltotal.Name = "ltotal"
        Me.ltotal.Size = New System.Drawing.Size(92, 16)
        Me.ltotal.TabIndex = 360
        Me.ltotal.Text = "Total Amount"
        Me.ltotal.Visible = False
        '
        'lsubs
        '
        Me.lsubs.AutoSize = True
        Me.lsubs.BackColor = System.Drawing.Color.Transparent
        Me.lsubs.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsubs.Location = New System.Drawing.Point(552, 575)
        Me.lsubs.Name = "lsubs"
        Me.lsubs.Size = New System.Drawing.Size(92, 16)
        Me.lsubs.TabIndex = 360
        Me.lsubs.Text = "Subs Amount"
        Me.lsubs.Visible = False
        '
        'taxamount
        '
        Me.taxamount.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taxamount.Location = New System.Drawing.Point(656, 607)
        Me.taxamount.MaxLength = 15
        Me.taxamount.Name = "taxamount"
        Me.taxamount.ReadOnly = True
        Me.taxamount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.taxamount.Size = New System.Drawing.Size(160, 21)
        Me.taxamount.TabIndex = 384
        Me.taxamount.Visible = False
        '
        'btn_Revert
        '
        Me.btn_Revert.Enabled = False
        Me.btn_Revert.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Revert.ForeColor = System.Drawing.Color.Black
        Me.btn_Revert.Image = Global.Bengal_MemberMaster.My.Resources.Resources.Delete
        Me.btn_Revert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Revert.Location = New System.Drawing.Point(866, 296)
        Me.btn_Revert.Name = "btn_Revert"
        Me.btn_Revert.Size = New System.Drawing.Size(137, 50)
        Me.btn_Revert.TabIndex = 606
        Me.btn_Revert.Text = "Void [F6]"
        Me.btn_Revert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Btn_close
        '
        Me.Btn_close.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_close.ForeColor = System.Drawing.Color.Black
        Me.Btn_close.Image = Global.Bengal_MemberMaster.My.Resources.Resources._Exit
        Me.Btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_close.Location = New System.Drawing.Point(866, 353)
        Me.Btn_close.Name = "Btn_close"
        Me.Btn_close.Size = New System.Drawing.Size(137, 50)
        Me.Btn_close.TabIndex = 608
        Me.Btn_close.Text = "Exit [F11]"
        Me.Btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(181, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(382, 32)
        Me.Label2.TabIndex = 609
        Me.Label2.Text = "NRI SUBSCRIPTION POSTING"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(725, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 25)
        Me.Label8.TabIndex = 610
        Me.Label8.Text = "Label8"
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.Color.Black
        Me.btn_clear.Image = Global.Bengal_MemberMaster.My.Resources.Resources.Clear
        Me.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clear.Location = New System.Drawing.Point(866, 408)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(137, 50)
        Me.btn_clear.TabIndex = 611
        Me.btn_clear.Text = "Clear[F7]"
        Me.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(879, 454)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 32)
        Me.Button1.TabIndex = 611
        Me.Button1.Text = "Clear[F7]"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(535, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 25)
        Me.Label10.TabIndex = 612
        '
        'Btn_ok
        '
        Me.Btn_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_ok.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ok.ForeColor = System.Drawing.Color.Black
        Me.Btn_ok.Image = Global.Bengal_MemberMaster.My.Resources.Resources.save
        Me.Btn_ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_ok.Location = New System.Drawing.Point(866, 241)
        Me.Btn_ok.Name = "Btn_ok"
        Me.Btn_ok.Size = New System.Drawing.Size(137, 50)
        Me.Btn_ok.TabIndex = 613
        Me.Btn_ok.Text = "Add [F5]"
        Me.Btn_ok.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Btn_okD
        '
        Me.Btn_okD.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_okD.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_okD.ForeColor = System.Drawing.Color.Black
        Me.Btn_okD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_okD.Location = New System.Drawing.Point(866, 171)
        Me.Btn_okD.Name = "Btn_okD"
        Me.Btn_okD.Size = New System.Drawing.Size(137, 50)
        Me.Btn_okD.TabIndex = 605
        Me.Btn_okD.Text = "Add [F5]"
        Me.Btn_okD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_okD.UseVisualStyleBackColor = False
        '
        'btn_process
        '
        Me.btn_process.Enabled = False
        Me.btn_process.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_process.ForeColor = System.Drawing.Color.Black
        Me.btn_process.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_process.Location = New System.Drawing.Point(866, 464)
        Me.btn_process.Name = "btn_process"
        Me.btn_process.Size = New System.Drawing.Size(137, 50)
        Me.btn_process.TabIndex = 614
        Me.btn_process.Text = "Process[F4]"
        Me.btn_process.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Overdue
        '
        Me.Overdue.AutoSize = True
        Me.Overdue.Location = New System.Drawing.Point(186, 608)
        Me.Overdue.Name = "Overdue"
        Me.Overdue.Size = New System.Drawing.Size(145, 21)
        Me.Overdue.TabIndex = 617
        Me.Overdue.Text = "Over Due Charges"
        Me.Overdue.UseVisualStyleBackColor = True
        Me.Overdue.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(341, 613)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 16)
        Me.Label12.TabIndex = 622
        Me.Label12.Text = "Receipt_Date"
        Me.Label12.Visible = False
        '
        'dtp_recdate
        '
        Me.dtp_recdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_recdate.Location = New System.Drawing.Point(446, 608)
        Me.dtp_recdate.Name = "dtp_recdate"
        Me.dtp_recdate.Size = New System.Drawing.Size(98, 23)
        Me.dtp_recdate.TabIndex = 621
        Me.dtp_recdate.Visible = False
        '
        'SSGRID2
        '
        Me.SSGRID2.DataSource = Nothing
        Me.SSGRID2.Location = New System.Drawing.Point(218, 182)
        Me.SSGRID2.Name = "SSGRID2"
        Me.SSGRID2.OcxState = CType(resources.GetObject("SSGRID2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSGRID2.Size = New System.Drawing.Size(590, 376)
        Me.SSGRID2.TabIndex = 385
        Me.SSGRID2.Visible = False
        '
        'ssGrid
        '
        Me.ssGrid.DataSource = Nothing
        Me.ssGrid.Location = New System.Drawing.Point(10, 10)
        Me.ssGrid.Name = "ssGrid"
        Me.ssGrid.OcxState = CType(resources.GetObject("ssGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssGrid.Size = New System.Drawing.Size(896, 504)
        Me.ssGrid.TabIndex = 380
        Me.ssGrid.Visible = False
        '
        'SSGRID1
        '
        Me.SSGRID1.DataSource = Nothing
        Me.SSGRID1.Location = New System.Drawing.Point(48, 171)
        Me.SSGRID1.Name = "SSGRID1"
        Me.SSGRID1.OcxState = CType(resources.GetObject("SSGRID1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSGRID1.Size = New System.Drawing.Size(920, 344)
        Me.SSGRID1.TabIndex = 385
        '
        'FRM_NRI_SUBSCRIPTIONPOSTING
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources._111in1024res
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dtp_recdate)
        Me.Controls.Add(Me.Overdue)
        Me.Controls.Add(Me.btn_process)
        Me.Controls.Add(Me.Btn_ok)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.SSGRID2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_close)
        Me.Controls.Add(Me.btn_Revert)
        Me.Controls.Add(Me.subsamount)
        Me.Controls.Add(Me.totalamount)
        Me.Controls.Add(Me.ltax)
        Me.Controls.Add(Me.ltotal)
        Me.Controls.Add(Me.lsubs)
        Me.Controls.Add(Me.taxamount)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FRM_NRI_SUBSCRIPTIONPOSTING"
        Me.Text = "SUBSCRIPTION POSTING"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.SSGRID2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSGRID1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim gconnection As New GlobalClass
    Dim sqlString, sqlString1, chk_month As String
    Public sqlStringFinal, DispString, membertype As String
    Dim iNumber, row, row1 As Integer
    Dim billno As Long
    Dim INSERT(0), Update2(0) As String


    Public TempString(2), bill, catecode, catecode1 As String
    Dim storedPro_str As String
    Dim Fromdate, ToDate As String
    Dim monthly, postype, Vcatefile, sout, rout As String
    Dim posting, posting1, posting2, posting3 As New DataTable
    Dim dr As DataRow
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    'Dim processed As Integer
    Dim Processed_Chk(4) As Integer
    Dim docno As Integer
    Private Sub SubscriptionPosting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Long
        posting = Nothing
        Try
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            sqlString = "select ISNULL(POSTINGCODE,'') AS POSTINGTYPE FROM postingmast group by postingcode"
            posting = gconnection.GetValues(sqlString)
            If posting.Rows.Count > 0 Then
                ChkList_month.Items.Clear()
                For i = 0 To posting.Rows.Count - 1
                    cbo_BillingBasis.Items.Add(posting.Rows(i).Item("POSTINGTYPE"))
                Next
            End If
            posting = Nothing
            sqlString = "select ISNULL(MAX(ISNULL(DOCNO,0)),0) AS DOCNO FROM SUBSPOSTING "
            posting = gconnection.GetValues(sqlString)
            If posting.Rows.Count = 1 Then
                Label8.Text = "Last Doc No.is " & posting.Rows(0).Item("docno")
            Else
                Label8.Text = "Last Doc No.is 0"
            End If
            posting1 = Nothing
            sqlString = "select ISNULL(MAX(ISNULL(DOCNO,0)),0)+1 AS DOCNO FROM SUBSPOSTING "
            posting1 = gconnection.GetValues(sqlString)
            If posting1.Rows.Count = 1 Then
                docno = posting1.Rows(0).Item("docno")
            Else
                docno = 1
            End If
            '    sqlString = "select * FROM memberssetup WHERE ISNULL(ACCOUNTS,'')='Y'"
            '   posting1 = gconnection.GetValues(sqlString)
            '  If posting1.Rows.Count = 1 Then
            '  docno = posting1.Rows(0).Item("docno")
            'btn_process.Visible = True
            'Else
            'btn_process.Visible = False
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        INSERT.Clear(INSERT, 0, INSERT.Length)
        gconnection.closeconnection()
        dtp_year.Focus()
        'cbo_BillingBasis.SelectedIndex = 0
        sqlString = "SELECT Membertype,TypeDesc FROM MEMBERTYPE"
        posting = gconnection.GetValues(sqlString)
        If posting.Rows.Count > 1 Then
            For i = 0 To (posting.Rows.Count - 1)
                chk_Filter_Field.Items.Add(posting.Rows(i).Item("Membertype") & "." & posting.Rows(i).Item("TypeDesc"))
            Next
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
        Me.Btn_ok.Enabled = False
        Me.process.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.Btn_ok.Enabled = True
                    Me.process.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.process.Text, 1, 1)) = "P" Then
                    If Right(x) = "S" Then
                        Me.process.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.process.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    'Me.cmd_Delete.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.Btn_ok.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub Btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If MsgBox("Do U Want to Close this Form........", MsgBoxStyle.OKCancel + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.OK Then
        Me.Close()
        'Else
        'dtp_year.Focus()
        'End If
    End Sub

    Private Sub btn_Revert_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim ssql1, monthly As String
            monthly = Month(Format(dtp_year.Value, "dd/MMM/yyyy"))
            ssql1 = "delete from subsposting where month(billdate)=" & monthly
            gconnection.getDataSet(ssql1, "SUBSPOSTING")
            MsgBox("REVERTING OF POSTING IS DONE...")
            btn_Revert.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dtp_year_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_year.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            chk_Filter_Field.Focus()
        End If
    End Sub
    Private Sub btn_Revert_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
        End If
    End Sub
    Private Sub ChkList_month_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ChkList_month.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtdesc.Focus()
        End If
    End Sub
    Private Sub txtdesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdesc.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Btn_ok.Focus()
        End If
    End Sub
    Private Sub ChkList_type_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            ChkList_month.Focus()
        End If
    End Sub
    Private Sub fillpostingtype()
        ChkList_month.Items.Clear()
        Dim i As Long
        posting = Nothing
        Try
            sqlString = "select isnull(postingsno,0) as postingsno, isnull(POSTINGCODE,'') AS POSTINGTYPE,ISNULL(POSTINGDESC,'') as postingdesc,isnull(postingsno,0) as postingsno "
            sqlString = sqlString & " from postingmast where  isnull(postingcode,'')='" & Me.cbo_BillingBasis.Text & "'"
            posting = gconnection.GetValues(sqlString)
            If posting.Rows.Count > 0 Then
                ChkList_month.Items.Clear()
                For i = 0 To posting.Rows.Count - 1
                    ChkList_month.Items.Add(posting.Rows(i).Item("POSTINGSNO") & "." & posting.Rows(i).Item("POSTINGDESC"))
                Next
            Else
                ChkList_month.Items.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cbo_BillingBasis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_BillingBasis.SelectedIndexChanged
        Call fillpostingtype()
    End Sub
    Private Sub cbo_BillingBasis_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbo_BillingBasis.KeyDown
        If e.KeyCode = Keys.Enter Then
            ChkList_month.Focus()
        End If
    End Sub
    Private Sub dtp_year_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_year.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbo_BillingBasis.Focus()
        End If
    End Sub
    Private Sub chkmonth()
        Dim i As Long
        Try
            If ChkList_month.CheckedItems.Count > 0 Then
                TempString = Split((ChkList_month.CheckedItems.Item(0)), ".")
                'DispString = TempString(1)
                chk_month = "'" & cbo_BillingBasis.Text & "','" & Trim(TempString(0)) & "')"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub chk_Filter_Field_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_Filter_Field.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            cbo_BillingBasis.Focus()
        End If
    End Sub
    Private Sub cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        SSGRID2.ClearRange(1, 1, -1, -1, True)
        SSGRID2.Visible = False
        ssGrid.Visible = False
        process.Visible = False
        btn_process.Enabled = False
        cancel.Visible = False
        taxamount.Visible = False
        subsamount.Visible = False
        totalamount.Visible = False
        lsubs.Visible = False
        ltax.Visible = False
        ltotal.Visible = False
        dtp_year.Focus()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles process.Click
     
    End Sub
    Private Sub export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If SSGRID2.Visible = True Then
                Call ExportTo(SSGRID2)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub
    Private Sub SubscriptionPosting_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            If Btn_ok.Enabled = True Then
                Call Btn_ok_Click_1(sender, e)
                Exit Sub
            End If

        ElseIf e.KeyCode = Keys.F6 Then
            If btn_Revert.Enabled = True Then
                Call btn_Revert_Click(sender, e)
            End If

            Exit Sub
        ElseIf e.KeyCode = Keys.Escape Or e.KeyCode = Keys.F11 Then
            Call Btn_close_Click_1(sender, e)
            Exit Sub
            'ElseIf e.KeyCode = Keys.F12 Then
            '    Call export_Click(sender, e)
            '    Exit Sub
            'ElseIf e.KeyCode = Keys.F4 And SSGRID2.Visible = True Then
            '    Call Button1_Click(sender, e)
            '    Exit Sub
        End If
    End Sub

    Private Sub chk_PrintAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_PrintAll.CheckedChanged
        Dim Iteration As Integer
        If chk_PrintAll.Checked = True Then
            Try
                For Iteration = 0 To (chk_Filter_Field.Items.Count - 1)
                    chk_Filter_Field.SetSelected(Iteration, True)
                    chk_Filter_Field.SetItemChecked(Iteration, True)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                For Iteration = 0 To (chk_Filter_Field.Items.Count - 1)
                    chk_Filter_Field.SetItemChecked(Iteration, False)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    Dim _export As New EXPORT
        '    Dim SQLSTR As String
        '    SQLSTR = "select * from MM_View_MUC_Annexure where MONTH(billdate)=" & Month(dtp_year.Value)
        '    _export.TABLENAME = "MM_View_MUC_Annexure"
        '    Call _export.export_excel(SQLSTR)
        '    _export.Show()
        '    Exit Sub
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try

    End Sub

    Private Sub export_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub


    Private Sub Btn_ok_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_okD.Click
       
    End Sub

    Private Sub Btn_close_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_close.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click, Button1.Click
        SSGRID2.ClearRange(1, 1, -1, -1, True)
        SSGRID2.Visible = False
        ssGrid.Visible = False
        process.Visible = False
        cancel.Visible = False
        taxamount.Visible = False
        subsamount.Visible = False
        totalamount.Visible = False
        lsubs.Visible = False
        ltax.Visible = False
        ltotal.Visible = False
        dtp_year.Focus()
        Btn_ok.Enabled = True
        btn_Revert.Enabled = False
        txt_docno.Enabled = True
        dtp_year.Enabled = True
        dtp_docdate.Enabled = True
        Label10.Text = ""
        txt_docno.Text = ""
        dtp_docdate.Text = ""
        'SSGRID2.SendToBack()
        posting = Nothing
        btn_process.Enabled = False
        sqlString = "select ISNULL(MAX(ISNULL(DOCNO,0)),0) AS DOCNO FROM SUBSPOSTING "
        posting = gconnection.GetValues(sqlString)
        If posting.Rows.Count = 1 Then
            Label8.Text = "Last Doc No.is " & posting.Rows(0).Item("docno")
        Else
            Label8.Text = "Last Doc No.is 0"
        End If
        posting1 = Nothing
        sqlString = "select ISNULL(MAX(ISNULL(DOCNO,0)),0)+1 AS DOCNO FROM SUBSPOSTING "
        posting1 = gconnection.GetValues(sqlString)
        If posting1.Rows.Count = 1 Then
            docno = posting1.Rows(0).Item("docno")
        Else
            docno = 1
        End If
        INSERT.Clear(INSERT, 0, INSERT.Length)
        Dim i As Integer
        For i = 0 To ChkList_month.Items.Count - 1
            ChkList_month.SetItemChecked(i, False)
        Next
    End Sub

    Private Sub btn_Revert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Revert.Click
        Try
            Dim ssql1, monthly, YEARLY As String
            monthly = Month(Format(dtp_year.Value, "dd/MMM/yyyy"))
            YEARLY = Year(Format(dtp_year.Value, "dd/MMM/yyyy"))
            ssql1 = "SELECT * FROM SUBSPOSTING WHERE ISNULL(LOCK,'')='Y' AND MONTH(BILLDATE)=" & monthly & ""
            gconnection.getDataSet(ssql1, "SUBS")
            If gdataset.Tables("SUBS").Rows.Count > 0 Then
                MessageBox.Show("Can't Revert the Subscrition", gcompanyname)
                Exit Sub
            End If
            ssql1 = "SELECT * FROM JOURNALENTRY WHERE VOUCHERTYPE='MBILL' AND ISNULL(VOID,'')<>'Y' AND MONTH(VOUCHERDATE)='" & monthly & "' AND YEAR(VOUCHERDATE)='" & YEARLY & "' AND ISNULL(LOCK,'')='Y'"
            gconnection.getDataSet(ssql1, "SUBS")
            If gdataset.Tables("SUBS").Rows.Count > 0 Then
                MessageBox.Show("Month is Locked, Can't Revert the Subscrition", gcompanyname)
                Exit Sub
            End If
            ssql1 = "UPDATE subsposting SET VOID='Y',POSTINGFLAG='N',VOIDUSERID='" & gUsername & "',VOIDDATETIME='" & Format(Now(), "yyyy-MM-dd") & "' where DOCNO=" & Val(txt_docno.Text) & ""
            gconnection.getDataSet(ssql1, "SUBSPOSTING")
            ssql1 = "UPDATE SUBSCRIPTION_TAX SET VOID='Y',VOIDUSER='" & gUsername & "',VOIDDATE='" & Format(Now(), "yyyy-MM-dd") & "' where DOCNO=" & Val(txt_docno.Text) & ""
            gconnection.getDataSet(ssql1, "SUBSCRIPTION_TAX")
            ssql1 = "UPDATE JOURNALENTRY_MEM SET VOID='Y' WHERE VOUCHERTYPE='SBIL' AND MONTH(VOUCHERDATE)=" & monthly & ""
            gconnection.getDataSet(ssql1, "JOURNALENTRY")
            ssql1 = "delete from bengal_monthbill where month(billdate)=" & monthly & ""
            gconnection.getDataSet(ssql1, "bengal_monthbill")
            ssql1 = "delete from member_consumption1 where month(kotdate)=" & monthly & ""
            gconnection.getDataSet(ssql1, "member_consumption1")
            MsgBox("REVERTING OF POSTING IS DONE...")
            btn_process.Enabled = False
            'btn_Revert.Enabled = False
            'SSGRID2.ClearRange(1, 1, -1, -1, True)
            'SSGRID2.Visible = False
            'ssGrid.Visible = False
            'process.Visible = False
            'cancel.Visible = False
            'taxamount.Visible = False
            'subsamount.Visible = False
            'totalamount.Visible = False
            'lsubs.Visible = False
            'ltax.Visible = False
            'ltotal.Visible = False
            'dtp_year.Focus()
            'Btn_ok.Enabled = True
            'btn_Revert.Enabled = False
            'txt_docno.Enabled = True
            'dtp_year.Enabled = True
            'Label10.Text = ""
            'txt_docno.Text = ""
            'dtp_docdate.Text = ""
            'dtp_docdate.Enabled = True
            Button1_Click_2(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_docno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_docno.KeyPress
        If Asc(e.KeyChar) = 13 And Trim(Me.txt_docno.Text) <> "" Then
            Call GETSUBSPOSTING()
        End If
    End Sub

    Public Function GETSUBSPOSTING()
        Randomize()
        Dim i, Startno As Long
        Dim monthly As String
        monthly = Month(Format(dtp_year.Value, "dd/MMM/yyyy"))
        posting = Nothing
        Vcatefile = Mid("SUBS" & CStr(Int(Rnd() * 75000)), 1, 8)
        Try


            sqlString = "select isnull(billno,'') as billno,isnull(mcode,'') as mcode,sum(isnull(amount,0)) as subsamount,sum(isnull(taxamount,0)) as taxamount,isnull(period,'') as period,isnull(subsdesc,'TEST') as subsdesc,isnull(subcd,'') as subcd,"
            sqlString = sqlString & " ISNULL(VOID,'') AS VOID,ISNULL(DOCNO,0) AS DOCNO,ISNULL(DOCDATE,'') AS DOCDATE,ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(VOIDDATETIME,'') AS VOIDDATETIME"
            sqlString = sqlString & " from subsposting where ISNULL(DOCNO,0)=" & Val(txt_docno.Text) & ""
            sqlString = sqlString & " group by billno,mcode,subsacctin,taxcode,period,subsdesc,subcd,VOID,VOIDDATETIME,DOCNO,DOCDATE,BILLDATE order by mcode,subsdesc"
            posting = gconnection.GetValues(sqlString)

            If posting.Rows.Count >= 1 Then
                Dim ssql1 As String
                ssql1 = "SELECT DOCNO,BILLDATE FROM SUBSPOSTING WHERE ISNULL(VOID,'')<>'Y' AND ISNULL(DOCNO,0)=" & Val(txt_docno.Text) & " AND ISNULL(ACCOUNTFLAG,'')='Y'"
                gconnection.getDataSet(ssql1, "VOUCHER")
                If gdataset.Tables("VOUCHER").Rows.Count > 0 Then
                    btn_process.Enabled = False
                Else
                    btn_process.Enabled = True
                End If
                SSGRID2.Visible = True
                'process.Visible = True
                cancel.Visible = True
                taxamount.Visible = True
                subsamount.Visible = True
                totalamount.Visible = True
                ltax.Visible = True
                lsubs.Visible = True
                ltotal.Visible = True
                Btn_ok.Enabled = False
                btn_Revert.Enabled = True
                taxamount.Text = ""
                subsamount.Text = ""
                totalamount.Text = ""
                dtp_docdate.Enabled = False
                'txt_docno.Text = docno
                txt_docno.Enabled = False
                dtp_year.Enabled = False
                If posting.Rows(0).Item("VOID") = "Y" Then
                    Label10.Text = "RECORD IS VOIDED ON " & posting.Rows(0).Item("VOIDDATETIME")
                    btn_Revert.Enabled = False
                    btn_process.Enabled = False
                End If
                txt_docno.Text = posting.Rows(0).Item("DOCNO")
                dtp_year.Text = posting.Rows(0).Item("BILLDATE")
                dtp_docdate.Text = posting.Rows(0).Item("DOCDATE")
                SSGRID2.ClearRange(1, 1, -1, -1, True)
                SSGRID2.Row = 1
                SSGRID2.Col = 1
                SSGRID2.SetActiveCell(1, 1)
                SSGRID2.Row = 1
                SSGRID2.Col = 1
                SSGRID2.Text = "BillNo"
                SSGRID2.Col = 2
                SSGRID2.Text = "BillDate"
                SSGRID2.Col = 3
                SSGRID2.Text = "Mcode"
                SSGRID2.Col = 4
                SSGRID2.Text = "Mname"
                SSGRID2.Col = 5
                SSGRID2.Text = "Period"
                SSGRID2.Col = 6
                SSGRID2.Text = "Subsdesc"
                SSGRID2.Col = 7
                SSGRID2.Text = "SubsAmount"
                SSGRID2.Col = 10
                SSGRID2.Text = "TaxAmount"
                SSGRID2.Col = 11
                SSGRID2.Text = "TotalAmount"
                SSGRID2.Col = 12
                SSGRID2.Text = "balance"

                SSGRID2.Row = 2
                SSGRID2.Col = 1
                SSGRID2.SetActiveCell(1, 2)
                SSGRID2.MaxRows = (posting.Rows.Count * 2)
                Dim mcode, c
                Dim balance As Double
                mcode = ""
                For row = 0 To posting.Rows.Count - 1
                    Startno = Startno + 1
                    c = c + 1
                    With SSGRID2

                        'bill = "SBIL/" & Mid(Year(dtp_year.Value), 3, 2) & Format(Month(dtp_year.Value), "00") & "/" & Trim(posting.Rows(row).Item("subcd"))
                        If Len(Trim(Str(Startno))) = 1 Then
                            bill = "SBIL/00000" & Trim(Str(Startno)) & "/" & Trim(Mid(gFinancalyearStart, 3, 2) & "-" & Mid(gFinancialyearEnd, 8, 2))
                        ElseIf Len(Trim(Str(Startno))) = 2 Then
                            bill = "SBIL/0000" & Trim(Str(Startno)) & "/" & Trim(Mid(gFinancalyearStart, 3, 2) & "-" & Mid(gFinancialyearEnd, 8, 2))
                        ElseIf Len(Trim(Str(Startno))) = 3 Then
                            bill = "SBIL/000" & Trim(Str(Startno)) & "/" & Trim(Mid(gFinancalyearStart, 3, 2) & "-" & Mid(gFinancialyearEnd, 8, 2))
                        ElseIf Len(Trim(Str(Startno))) = 4 Then
                            bill = "SBIL/00" & Trim(Str(Startno)) & "/" & Trim(Mid(gFinancalyearStart, 3, 2) & "-" & Mid(gFinancialyearEnd, 8, 2))
                        ElseIf Len(Trim(Str(Startno))) = 5 Then
                            bill = "SBIL/0" & Trim(Str(Startno)) & "/" & Trim(Mid(gFinancalyearStart, 3, 2) & "-" & Mid(gFinancialyearEnd, 8, 2))
                        Else
                            bill = "SBIL/" & Trim(Str(Startno)) & "/" & Trim(Mid(gFinancalyearStart, 3, 2) & "-" & Mid(gFinancialyearEnd, 8, 2))
                        End If
                        If mcode <> posting.Rows(row).Item("mcode") Then
                            c = c + 1
                        End If

                        .Row = c

                        .Col = 1
                        .Text = posting.Rows(row).Item("billno")

                        .Col = 2
                        .Text = Format(dtp_year.Value, "dd/MMM/yyyy")

                        .Col = 3
                        .Text = posting.Rows(row).Item("mcode")

                        .Col = 4
                        sqlString = "select isnull(mname,'') as mname  from membermaster where mcode='" & posting.Rows(row).Item("mcode") & "'"
                        posting1 = gconnection.GetValues(sqlString)
                        If posting1.Rows.Count > 0 Then
                            .Text = posting1.Rows(0).Item("mname")
                        End If

                        .Col = 5
                        .Text = posting.Rows(row).Item("period")

                        .Col = 6
                        .Text = posting.Rows(row).Item("subsdesc")

                        .Col = 7
                        .Text = posting.Rows(row).Item("subsamount")
                        If Val(posting.Rows(row).Item("subsamount")) > 0 Then
                            subsamount.Text = Format(Val(subsamount.Text) + Val(posting.Rows(row).Item("subsamount")), "0.00")
                        End If
                        .Col = 10
                        If posting.Rows(row).Item("taxamount") > 0 Then
                            .Text = posting.Rows(row).Item("taxamount")
                        Else
                            .Text = ""
                        End If
                        If Val(posting.Rows(row).Item("taxamount")) > 0 Then
                            taxamount.Text = Format(Val(taxamount.Text) + Val(posting.Rows(row).Item("taxamount")), "0.00")
                        End If
                        .Col = 11
                        .Text = Format(Val(posting.Rows(row).Item("taxamount") + posting.Rows(row).Item("subsamount")), "0.00")
                        If Val(posting.Rows(row).Item("subsamount")) > 0 Or Val(posting.Rows(row).Item("taxamount")) > 0 Then
                            totalamount.Text = Format(Val(totalamount.Text) + Format(Val(posting.Rows(row).Item("taxamount") + posting.Rows(row).Item("subsamount")), "0.00"), "0.00")
                        End If
                        '                        balance = balance + Val(posting.Rows(row).Item("subsamount")) + Val(posting.Rows(row).Item("taxamount"))
                        If mcode <> posting.Rows(row).Item("mcode") And mcode <> "" Then
                            .Row = c - 1
                            .Col = 12
                            .Text = Format(Val(balance), "0.00")
                            balance = 0
                        End If
                        If Val(posting.Rows(row).Item("subsamount")) > 0 Or Val(posting.Rows(row).Item("taxamount")) > 0 Then
                            balance = balance + Val(posting.Rows(row).Item("subsamount")) + Val(posting.Rows(row).Item("taxamount"))
                        End If
                        mcode = posting.Rows(row).Item("mcode")
                    End With
                Next row
                Me.Cursor = Cursors.Default
            Else
                MsgBox("No Record Pls Check...", MsgBoxStyle.OkOnly)
                'btn_Revert.Enabled = True
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub txt_docno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_docno.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ok.Click
        Randomize()
        Dim i, Startno As Long
        ' INSERT(INSERT.Length - 1) = 0
        btn_process.Enabled = False
        INSERT.Clear(INSERT, 0, INSERT.Length)
        Dim DOCNOS As Integer
        Dim RATE, AMOUNT, GRDTAXAMOUNT, GRDTAXAMT As Double
        Dim Zero, ZeroA, ZeroB, One, OneA, OneB, Two, TwoA, TwoB, Three, ThreeA, ThreeB, Tpercent As Double
        Dim GZero, GZeroA, GZeroB, GOne, GOneA, GOneB, GTwo, GTwoA, GTwoB, GThree, GThreeA, GThreeB, GrdRate As Double
        Dim TAXCODE, itype, taxon, SSQL, SUBSDESC, MNAMES, ACCOUNT As String
        Dim RoomPer, PartyPer As Double
        Dim TPackAmt, TTipsAmt, TAdchgAmt, TPartyAmt, TRoomAmt, GAmt, PKOTAMT, QTY As Double
        Dim monthly1, chargecode, mcode1, itemtypecode, billnos, MONTHS As String
        Dim billdate, MONTHDATE, DUEDATE, BILLDATE1, RECDATE, OVER As Date
        Dim subscode, day, year1, dues, accounts, bill, TAXDESC As String
        Dim YEARSTART As String
        BILL = DateAdd(DateInterval.Month, -1, dtp_year.Value)
        YEARSTART = Mid(gFinancalyearStart, 3, 2) & "-" & Format(gFinancialyearEnd, "yy")

        'sqlString = "select billdate,isnull(dues,'') as dues,ISNULL(ACCOUNTS,'') AS ACCOUNTS,ISNULL(DUE_DATE,'') AS DUE_DATE from memberssetup"
        'gconnection.getDataSet(sqlString, "memberssetup")
        'If gdataset.Tables("memberssetup").Rows.Count = 0 Then
        '    MessageBox.Show("Please Tag a Bill Date in Member Setup")
        '    Exit Sub
        'Else
        '    day = gdataset.Tables("memberssetup").Rows(0).Item("billdate")
        '    dues = gdataset.Tables("memberssetup").Rows(0).Item("dues")
        '    accounts = gdataset.Tables("memberssetup").Rows(0).Item("accounts")
        '    DUEDATE = gdataset.Tables("memberssetup").Rows(0).Item("DUE_DATE")
        'End If
        'If day = 30 Or day = 31 Then
        MONTHS = Format(dtp_year.Value, "MMM")
        If MONTHS = "Apr" Then day = 30
        If MONTHS = "May" Then day = 31
        If MONTHS = "Jun" Then day = 30
        If MONTHS = "Jul" Then day = 31
        If MONTHS = "Aug" Then day = 31
        If MONTHS = "Sep" Then day = 30
        If MONTHS = "Oct" Then day = 31
        If MONTHS = "Nov" Then day = 30
        If MONTHS = "Dec" Then day = 31
        If MONTHS = "Jan" Then day = 31
        If gFinancialEnd Mod 4 = 0 Then

            If MONTHS = "Feb" Then day = 29
        Else
            If MONTHS = "Feb" Then day = 28
        End If
        If MONTHS = "Mar" Then day = 31
        'End If
        monthly = Month(Format(dtp_year.Value, "dd/MMM/yyyy"))

        If MONTHS = "Apr" Then year1 = gFinancalyearStart
        If MONTHS = "May" Then year1 = gFinancalyearStart
        If MONTHS = "Jun" Then year1 = gFinancalyearStart
        If MONTHS = "Jul" Then year1 = gFinancalyearStart
        If MONTHS = "Aug" Then year1 = gFinancalyearStart
        If MONTHS = "Sep" Then year1 = gFinancalyearStart
        If MONTHS = "Oct" Then year1 = gFinancalyearStart
        If MONTHS = "Nov" Then year1 = gFinancalyearStart
        If MONTHS = "Dec" Then year1 = gFinancalyearStart
        If MONTHS = "Jan" Then year1 = gFinancialEnd
        If MONTHS = "Feb" Then year1 = gFinancialEnd
        If MONTHS = "Mar" Then year1 = gFinancialEnd
        'year1 = gFinancialEnd
        MONTHDATE = day & "/" & MONTHS & "/" & year1
        BILLDATE1 = CDate(MONTHDATE)
        BILLDATE1 = Format(MONTHDATE, "dd MMM yyyy")

        'MONTHDATE = monthly
        'sqlString = "SELECT * FROM SUBSPOSTING WHERE cast(convert(varchar(11),BILLDATE,106) as datetime)='" & Format(BILLDATE1, "dd MMM yyyy") & "' AND ISNULL(VOID,'')<>'Y' AND MEMBERTYPE ='NR' AND TYPE='GEN' AND billingbasis ='YEARLY'"
        'gconnection.getDataSet(sqlString, "Stno")
        'If gdataset.Tables("Stno").Rows.Count > 0 Then
        '    MessageBox.Show("Suscription Already Posted for this Month")
        '    Exit Sub
        'End If

        'MONTHDATE = monthly
        posting = Nothing
        Vcatefile = Mid("SUBS" & CStr(Int(Rnd() * 75000)), 1, 8)
        Try
            sqlString = " Select Substring(voucherno,6,6)  as Stno from JOURNALENTRY_MEM where Substring(voucherno,1,4)='SBIL' order by Substring(voucherno,6,6) "
            gconnection.getDataSet(sqlString, "Stno")
            If gdataset.Tables("Stno").Rows.Count > 0 Then
                Startno = Val(gdataset.Tables("Stno").Rows(0).Item("Stno"))
            Else
                Startno = 0
            End If
            sqlString = "select * From sysobjects where type='U' and name='" & Vcatefile & "'"
            gconnection.getDataSet(sqlString, "Temp")
            If gdataset.Tables("Temp").Rows.Count > 0 Then
                sqlString = "Drop table " & Vcatefile
                gconnection.dataOperation(6, sqlString, "Temp")
            Else
                sqlString = " select membertype into  " & Vcatefile & " from membertype where 1<0 "
                gconnection.dataOperation(6, sqlString, "Temp")
            End If

            'If ChkList_month.CheckedItems.Count = 0 Then
            '    MsgBox("Please Select Posting Type", MsgBoxStyle.Critical, gcompanyname)
            '    ChkList_month.Focus()
            '    Exit Sub
            'End If



            'If ChkList_month.CheckedItems.Count > 0 Then
            '    TempString = Split((ChkList_month.CheckedItems.Item(0)), ".")
            '    chk_month = "'" & cbo_BillingBasis.Text & "'," & Trim(TempString(0))
            'End If
            ''MessageBox.Show(TempString(0), "MM")
            'If TempString(1) <> UCase(monthly1) Then
            '    MessageBox.Show("Please show correct posting month", gcompanyname)
            '    Exit Sub
            'End If
            'If monthly <> 4 Then
            '    sqlString = "SELECT * FROM SUBSPOSTING WHERE MONTH(BILLDATE)=" & monthly - 1 & " AND ISNULL(VOID,'')<>'Y'"
            '    gconnection.getDataSet(sqlString, "Stno")
            '    If gdataset.Tables("Stno").Rows.Count = 0 Then
            '        MessageBox.Show("Please Post for Previous Month", gcompanyname)
            '        Exit Sub
            '    End If
            'End If

            'sqlString = "select isnull(period,'') as period from postingmast "
            'sqlString = sqlString & " where postingcode= '" & Trim(cbo_BillingBasis.Text) & "'"
            'sqlString = sqlString & " and postingsno=" & Trim(TempString(0))
            'posting = gconnection.GetValues(sqlString)



            sqlString = "Exec  tp_subscriptionview_NRI '" & Format(MONTHDATE, "dd/MMM/yyyy") & "','" & TempString(0) & "'"
            'sqlString = sqlString & ",'" & gFinancialyearStart & "','" & gFinancialyearEnd & "'"
            sqlString = sqlString & ",'" & gvoucherdate & "','" & gfinnyrend & "'"
            posting = gconnection.ExcuteStoreProcedure(sqlString)

            'End If
            sqlString = "select  ISNULL(max(cast(substring(voucherno,6,5) as int)),0)+1  as maxno from journalentry_MEM "
            sqlString = sqlString & " where substring(voucherno,1,3)='SUB'"
            posting = gconnection.GetValues(sqlString)

            If posting.Rows.Count > 0 Then
                billno = Val(posting.Rows(0).Item("maxno"))
            Else : billno = 0
            End If


            sqlString = "select isnull(billno,'') as billno,isnull(mcode,'') as mcode,sum(isnull(amount,0)) as subsamount,sum(isnull(taxamount,0)) as taxamount,isnull(period,'') as period,isnull(subsdesc,'TEST') as subsdesc,isnull(subcd,'') as subcd"
            'sqlString = sqlString & " from subsposting where billingbasis='" & Trim(cbo_BillingBasis.Text) & "'"
            sqlString = sqlString & " from subsposting where month(billdate)=" & monthly
            sqlString = sqlString & " and isnull(VOID,'')<> 'Y' AND ISNULL(POSTINGFLAG,'')<>'Y' AND ISNULL(SUBSCODE,'')='NSUB' group by billno,mcode,subsacctin,taxcode,period,subsdesc,subcd order by mcode,subsdesc"
            posting = gconnection.GetValues(sqlString)

            If posting.Rows.Count >= 1 Then
                sqlString1 = "Update subsposting set postingflag='Y',docno= " & docno & ",docdate='" & Format(MONTHDATE, "yyyy-MM-dd") & "', adduserid='" & gUsername & "',adddatetime='" & Format(Now(), "yyyy-MM-dd") & "'"
                sqlString1 = sqlString1 & " where billdate='" & Format(MONTHDATE, "dd/MMM/yyyy") & "' AND ISNULL(VOID,'')<>'Y' AND MEMBERTYPE ='NR' AND TYPE='GEN' AND billingbasis ='YEARLY' AND ISNULL(SUBSCODE,'')='NSUB'"
                posting2 = gconnection.GetValues(sqlString1)
                sqlString1 = "Update subsposting set LOCK='Y'"
                sqlString1 = sqlString1 & " where MONTH(billdate)=" & monthly - 1 & " AND ISNULL(VOID,'')<>'Y'"
                posting2 = gconnection.GetValues(sqlString1)
                'sqlString1 = "SELECT CHARGECODE,BILLDATE,MCODE,SUBSCODE FROM SUBSPOSTING '" & Format(dtp_year.Value, "dd/MMM/yyyy") & "' AND ISNULL(VOID,'')<>'Y'"
                'posting2 = gconnection.GetValues(sqlString1)
                sqlString1 = "select ISNULL(DOCNO,0) AS DOCNO,ISNULL(subscode,'') AS SUBSCODE,ISNULL(chargecode,'') AS CHARGECODE,ISNULL(mcode,'') AS MCODE,ISNULL(SUBSDESC,'') AS SUBSDESC,ISNULL(MNAME,'')AS MNAME,ISNULL(billdate,'')AS BILLDATE,ISNULL(billno,'') AS BILLNO,ISNULL(AMOUNT,0) AS AMOUNT from subsposting where DOCNO=" & docno & " AND ISNULL(VOID,'')<>'Y'"
                posting3 = gconnection.GetValues(sqlString1)
                For row1 = 0 To posting3.Rows.Count - 1
                    Zero = 0.0 : ZeroA = 0.0 : ZeroB = 0.0 : One = 0.0 : OneA = 0.0 : OneB = 0.0 : Two = 0.0 : TwoA = 0.0 : TwoB = 0.0 : Three = 0.0 : ThreeA = 0.0 : ThreeB = 0.0 : Tpercent = 0.0
                    GZero = 0.0 : GZeroA = 0.0 : GZeroB = 0.0 : GOne = 0.0 : GOneA = 0.0 : GOneB = 0.0 : GTwo = 0.0 : GTwoA = 0.0 : GTwoB = 0.0 : GThree = 0.0 : GThreeA = 0.0 : GThreeB = 0.0 : GrdRate = 0.0
                    DOCNOS = posting3.Rows(row1).Item("DOCNO")
                    chargecode = posting3.Rows(row1).Item("chargecode")
                    subscode = posting3.Rows(row1).Item("subscode")
                    SUBSDESC = posting3.Rows(row1).Item("subsDESC")
                    mcode1 = posting3.Rows(row1).Item("mcode")
                    MNAMES = posting3.Rows(row1).Item("mNAME")
                    billdate = posting3.Rows(row1).Item("billdate")
                    billnos = posting3.Rows(row1).Item("billno")
                    RATE = posting3.Rows(row1).Item("AMOUNT")
                    sqlString = "SELECT isnull(TAXTypecode,'') FROM CHARGEMASTER WHERE CHARGECODE = '" & Trim(chargecode) & "' "
                    gconnection.getDataSet(sqlString, "CODE_CHECK")
                    If gdataset.Tables("CODE_CHECK").Rows.Count - 1 >= 0 Then
                        itemtypecode = Trim(gdataset.Tables("CODE_CHECK").Rows(0).Item(0))
                    Else
                        itemtypecode = ""
                    End If
                    sqlString = "SELECT ISNULL(I.ItemTypeCode,'') AS ITEMTYPECODE,ISNULL(I.TaxCode,'') AS TAXCODE,ISNULL(I.TAXON,'') AS TAXON,ISNULL(I.TaxPercentage,0) AS TaxPercentage,ISNULL(A.GLACCOUNTIN,'') AS ACCOUNTCODE FROM ITEMTYPEMASTER I INNER JOIN ACCOUNTSTAXMASTER A ON I.TAXCODE=A.TAXCODE AND ISNULL(FREEZEFLAG,'')<>'Y'  WHERE ItemTypeCode = '" & Trim(itemtypecode) & "' ORDER BY TAXON"
                    gconnection.getDataSet(sqlString, "TAXON")
                    QTY = 1
                    If gdataset.Tables("TAXON").Rows.Count - 1 >= 0 Then
                        For J = 0 To gdataset.Tables("TAXON").Rows.Count - 1
                            itype = Trim(gdataset.Tables("TAXON").Rows(J).Item("ItemTypeCode"))
                            TAXCODE = Trim(gdataset.Tables("TAXON").Rows(J).Item("TaxCode"))
                            'TAXDESC = Trim(gdataset.Tables("TAXON").Rows(J).Item("TAXDESC"))
                            taxon = Trim(gdataset.Tables("TAXON").Rows(J).Item("TAXON"))
                            Tpercent = gdataset.Tables("TAXON").Rows(J).Item("TaxPercentage")
                            ACCOUNT = gdataset.Tables("TAXON").Rows(J).Item("ACCOUNTCODE")
                            SSQL = "INSERT INTO SUBSCRIPTION_TAX (DOCNO,BILLNO,BILLDATE,SUBSCODE,SUBSDESC,MCODE,MNAME,TAXCODE,TAXON,TAXPERCENT,TAXAMT,TAXACCOUNTCODE,ADD_USER,ADD_DATE,VOID) VALUES ( "
                            SSQL = SSQL & "" & DOCNOS & ",'" & billnos & "','" & Format(billdate, "yyyy-MM-dd") & "','" & Trim(subscode) & "','" & Trim(SUBSDESC) & "','" & Trim(mcode1) & "','" & Trim(MNAMES) & "','" & Trim(TAXCODE) & "','" & Trim(taxon) & "'," & (Tpercent) & ","
                            If gdataset.Tables("TAXON").Rows(J).Item("TAXON") = "0" Then
                                Zero = (RATE * gdataset.Tables("TAXON").Rows(J).Item("TaxPercentage")) / 100
                                GZero = GZero + Zero
                                GRDTAXAMOUNT = GRDTAXAMOUNT + Format(Val(Zero) * QTY, "0.00")
                                SSQL = SSQL & "" & Format(Val(Zero) * QTY, "0.00") & ","
                            ElseIf gdataset.Tables("TAXON").Rows(J).Item("TAXON") = "0A" Then
                                ZeroA = (GZero * gdataset.Tables("TAXON").Rows(J).Item("TaxPercentage")) / 100
                                GZeroA = GZeroA + ZeroA
                                GRDTAXAMOUNT = GRDTAXAMOUNT + Format(Val(ZeroA) * QTY, "0.00")
                                SSQL = SSQL & "" & Format(Val(ZeroA) * QTY, "0.00") & ","
                            ElseIf gdataset.Tables("TAXON").Rows(J).Item("TAXON") = "0B" Then
                                ZeroB = ((GZero + GZeroA) * gdataset.Tables("TAXON").Rows(J).Item("TaxPercentage")) / 100
                                GZeroB = GZeroB + ZeroB
                                SSQL = SSQL & "" & Format(Val(ZeroB) * QTY, "0.00") & ","
                                GRDTAXAMOUNT = GRDTAXAMOUNT + Format(Val(ZeroB) * QTY, "0.00")
                            ElseIf gdataset.Tables("TAXON").Rows(J).Item("TAXON") = "1" Then
                                One = ((RATE + GZero + GZeroA) * gdataset.Tables("TAXON").Rows(J).Item("TaxPercentage")) / 100
                                GOne = GOne + One
                                GRDTAXAMOUNT = GRDTAXAMOUNT + Format(Val(One) * QTY, "0.00")
                                SSQL = SSQL & "" & Val(One) * QTY & ","
                            ElseIf gdataset.Tables("TAXON").Rows(J).Item("TAXON") = "1A" Then
                                OneA = (One * gdataset.Tables("TAXON").Rows(J).Item("TaxPercentage")) / 100
                                GOneA = GOneA + OneA
                                GRDTAXAMOUNT = GRDTAXAMOUNT + Format(Val(OneA) * QTY, "0.00")
                                SSQL = SSQL & "" & Val(OneA) * QTY & ","
                            ElseIf gdataset.Tables("TAXON").Rows(J).Item("TAXON") = "1B" Then
                                OneB = ((GOne + GOneA) * gdataset.Tables("TAXON").Rows(J).Item("TaxPercentage")) / 100
                                GOneB = GOneB + OneB
                                GRDTAXAMOUNT = GRDTAXAMOUNT + Format(Val(OneB) * QTY, "0.00")
                                SSQL = SSQL & "" & Val(OneB) * QTY & ","
                            ElseIf gdataset.Tables("TAXON").Rows(J).Item("TAXON") = "2" Then
                                Two = ((RATE + GZero + GZeroA + GOne + GOneA) * gdataset.Tables("TAXON").Rows(J).Item("TaxPercentage")) / 100
                                GTwo = GTwo + Two
                                GRDTAXAMOUNT = GRDTAXAMOUNT + Format(Val(Two) * QTY, "0.00")
                                SSQL = SSQL & "" & Val(Two) * QTY & ","
                            ElseIf gdataset.Tables("TAXON").Rows(J).Item("TAXON") = "2A" Then
                                TwoA = (Two * gdataset.Tables("TAXON").Rows(J).Item("TaxPercentage")) / 100
                                GTwoA = GTwoA + TwoA
                                GRDTAXAMOUNT = GRDTAXAMOUNT + Format(Val(TwoA) * QTY, "0.00")
                                SSQL = SSQL & "" & Val(TwoA) * QTY & ","
                            ElseIf gdataset.Tables("TAXON").Rows(J).Item("TAXON") = "2B" Then
                                TwoB = ((GTwo + GTwoA) * gdataset.Tables("TAXON").Rows(J).Item("TaxPercentage")) / 100
                                GTwoB = GTwoB + TwoB
                                GRDTAXAMOUNT = GRDTAXAMOUNT + Format(Val(TwoB) * QTY, "0.00")
                                SSQL = SSQL & "" & Val(TwoB) * QTY & ","
                            ElseIf gdataset.Tables("TAXON").Rows(J).Item("TAXON") = "3" Then
                                Three = ((RATE + GZero + GZeroA + GOne + GOneA + GTwo + GTwoA) * gdataset.Tables("TAXON").Rows(J).Item("TaxPercentage")) / 100
                                GThree = GThree + Three
                                GRDTAXAMOUNT = GRDTAXAMOUNT + Format(Val(Three) * QTY, "0.00")
                                SSQL = SSQL & "" & Val(Three) * QTY & ","
                            ElseIf gdataset.Tables("TAXON").Rows(J).Item("TAXON") = "3A" Then
                                ThreeA = (Three * gdataset.Tables("TAXON").Rows(J).Item("TaxPercentage")) / 100
                                GThreeA = GThreeA + ThreeA
                                GRDTAXAMOUNT = GRDTAXAMOUNT + Format(Val(GThreeA) * QTY, "0.00")
                                SSQL = SSQL & "" & Val(ThreeA) * QTY & ","
                            ElseIf gdataset.Tables("TAXON").Rows(J).Item("TAXON") = "3B" Then
                                ThreeB = ((GThree + GThreeA) * gdataset.Tables("TAXON").Rows(J).Item("TaxPercentage")) / 100
                                GThreeB = GThreeB + ThreeB
                                GRDTAXAMOUNT = GRDTAXAMOUNT + Format(Val(GThreeB) * QTY, "0.00")
                                SSQL = SSQL & "" & Val(ThreeB) * QTY & ","
                            End If
                            SSQL = SSQL & "'" & ACCOUNT & "','" & Trim(gUsername) & "',getdate(),'N')"
                            ReDim Preserve INSERT(INSERT.Length)
                            INSERT(INSERT.Length - 1) = SSQL
                        Next
                        GRDTAXAMT = GZero + GZeroA + GZeroB + GOne + GOneA + GOneB + GTwo + GTwoA + GTwoB + GThree + GThreeA + GThreeB
                    End If
                Next
                SSQL = "UPDATE SUBSPOSTING SET TAXAMOUNT=(SELECT SUM(TAXAMT) FROM SUBSCRIPTION_TAX T WHERE T.MCODE=SUBSPOSTING.MCODE AND T.SUBSCODE=SUBSPOSTING.SUBSCODE AND T.BILLNO=SUBSPOSTING.BILLNO AND CAST(CONVERT(VARCHAR(11),T.BILLDATE,106) AS DATETIME)=CAST(CONVERT(VARCHAR(11),SUBSPOSTING.BILLDATE,106) AS DATETIME) AND ISNULL(T.VOID,'')<>'Y') WHERE ISNULL(BILLDATE,'')='" & Format(MONTHDATE, "yyyy-MM-dd") & "' AND DOCNO=" & DOCNOS & ""
                ReDim Preserve INSERT(INSERT.Length)
                INSERT(INSERT.Length - 1) = SSQL
                gconnection.dataOperation1(1, INSERT)
                sqlString = "select isnull(billno,'') as billno,isnull(mcode,'') as mcode,sum(isnull(amount,0)) as subsamount,sum(isnull(taxamount,0)) as taxamount,isnull(period,'') as period,isnull(subsdesc,'TEST') as subsdesc,isnull(subcd,'') as subcd"
                'sqlString = sqlString & " from subsposting where billingbasis='" & Trim(cbo_BillingBasis.Text) & "'"
                sqlString = sqlString & " from subsposting where month(billdate)=" & monthly
                sqlString = sqlString & " and isnull(VOID,'')<> 'Y'  AND MEMBERTYPE ='NR' AND TYPE='GEN' AND billingbasis ='YEARLY'   group by billno,mcode,subsacctin,taxcode,period,subsdesc,subcd order by mcode,subsdesc"
                posting = gconnection.GetValues(sqlString)

                SSGRID2.Visible = True
                process.Visible = True
                cancel.Visible = True
                taxamount.Visible = True
                subsamount.Visible = True
                totalamount.Visible = True
                ltax.Visible = True
                lsubs.Visible = True
                ltotal.Visible = True
                Btn_ok.Enabled = False
                btn_Revert.Enabled = True
                taxamount.Text = ""
                subsamount.Text = ""
                totalamount.Text = ""
                txt_docno.Text = docno
                txt_docno.Enabled = False
                dtp_year.Enabled = False
                btn_process.Enabled = True
                Label10.Text = ""
                SSGRID2.ClearRange(1, 1, -1, -1, True)
                SSGRID2.Row = 1
                SSGRID2.Col = 1
                SSGRID2.SetActiveCell(1, 1)
                SSGRID2.Row = 1
                SSGRID2.Col = 1
                SSGRID2.Text = "BillNo"
                SSGRID2.Col = 2
                SSGRID2.Text = "BillDate"
                SSGRID2.Col = 3
                SSGRID2.Text = "Mcode"
                SSGRID2.Col = 4
                SSGRID2.Text = "Mname"
                SSGRID2.Col = 5
                SSGRID2.Text = "Period"
                SSGRID2.Col = 6
                SSGRID2.Text = "Subsdesc"
                SSGRID2.Col = 7
                SSGRID2.Text = "SubsAmount"
                SSGRID2.Col = 10
                SSGRID2.Text = "TaxAmount"
                SSGRID2.Col = 11
                SSGRID2.Text = "TotalAmount"
                SSGRID2.Col = 12
                SSGRID2.Text = "balance"

                SSGRID2.Row = 2
                SSGRID2.Col = 1
                SSGRID2.SetActiveCell(1, 2)
                SSGRID2.MaxRows = (posting.Rows.Count * 2)
                Dim mcode, c
                Dim balance As Double
                mcode = ""
                For row = 0 To posting.Rows.Count - 1
                    Startno = Startno + 1
                    c = c + 1
                    With SSGRID2

                        'bill = "SBIL/" & Mid(Year(dtp_year.Value), 3, 2) & Format(Month(dtp_year.Value), "00") & "/" & Trim(posting.Rows(row).Item("subcd"))
                        If Len(Trim(Str(Startno))) = 1 Then
                            bill = "SBIL/00000" & Trim(Str(Startno)) & "/" & Trim(Mid(gFinancalyearStart, 3, 2) & "-" & Mid(gFinancialyearEnd, 3, 2))
                        ElseIf Len(Trim(Str(Startno))) = 2 Then
                            bill = "SBIL/0000" & Trim(Str(Startno)) & "/" & Trim(Mid(gFinancalyearStart, 3, 2) & "-" & Mid(gFinancialyearEnd, 3, 2))
                        ElseIf Len(Trim(Str(Startno))) = 3 Then
                            bill = "SBIL/000" & Trim(Str(Startno)) & "/" & Trim(Mid(gFinancalyearStart, 3, 2) & "-" & Mid(gFinancialyearEnd, 3, 2))
                        ElseIf Len(Trim(Str(Startno))) = 4 Then
                            bill = "SBIL/00" & Trim(Str(Startno)) & "/" & Trim(Mid(gFinancalyearStart, 3, 2) & "-" & Mid(gFinancialyearEnd, 3, 2))
                        ElseIf Len(Trim(Str(Startno))) = 5 Then
                            bill = "SBIL/0" & Trim(Str(Startno)) & "/" & Trim(Mid(gFinancalyearStart, 3, 2) & "-" & Mid(gFinancialyearEnd, 3, 2))
                        Else
                            bill = "SBIL/" & Trim(Str(Startno)) & "/" & Trim(Mid(gFinancalyearStart, 3, 2) & "-" & Mid(gFinancialyearEnd, 3, 2))
                        End If
                        If mcode <> posting.Rows(row).Item("mcode") Then
                            c = c + 1
                        End If

                        .Row = c

                        .Col = 1
                        .Text = posting.Rows(row).Item("billno")

                        .Col = 2
                        .Text = Format(dtp_year.Value, "dd/MMM/yyyy")

                        .Col = 3
                        .Text = posting.Rows(row).Item("mcode")

                        .Col = 4
                        sqlString = "select isnull(mname,'') as mname  from membermaster where mcode='" & posting.Rows(row).Item("mcode") & "'"
                        posting1 = gconnection.GetValues(sqlString)
                        If posting1.Rows.Count > 0 Then
                            .Text = posting1.Rows(0).Item("mname")
                        End If

                        .Col = 5
                        .Text = posting.Rows(row).Item("period")

                        .Col = 6
                        .Text = posting.Rows(row).Item("subsdesc")

                        .Col = 7
                        .Text = posting.Rows(row).Item("subsamount")
                        If Val(posting.Rows(row).Item("subsamount")) > 0 Then
                            subsamount.Text = Format(Val(subsamount.Text) + Val(posting.Rows(row).Item("subsamount")), "0.00")
                        End If
                        .Col = 10
                        If posting.Rows(row).Item("taxamount") > 0 Then
                            .Text = posting.Rows(row).Item("taxamount")
                        Else
                            .Text = ""
                        End If
                        If Val(posting.Rows(row).Item("taxamount")) > 0 Then
                            taxamount.Text = Format(Val(taxamount.Text) + Val(posting.Rows(row).Item("taxamount")), "0.00")
                        End If
                        .Col = 11
                        .Text = Format(Val(posting.Rows(row).Item("taxamount") + posting.Rows(row).Item("subsamount")), "0.00")
                        If Val(posting.Rows(row).Item("subsamount")) > 0 Or Val(posting.Rows(row).Item("taxamount")) > 0 Then
                            totalamount.Text = Format(Val(totalamount.Text) + Format(Val(posting.Rows(row).Item("taxamount") + posting.Rows(row).Item("subsamount")), "0.00"), "0.00")
                        End If
                        '                        balance = balance + Val(posting.Rows(row).Item("subsamount")) + Val(posting.Rows(row).Item("taxamount"))
                        If mcode <> posting.Rows(row).Item("mcode") And mcode <> "" Then
                            .Row = c - 1
                            .Col = 12
                            .Text = Format(Val(balance), "0.00")
                            balance = 0
                        End If
                        If Val(posting.Rows(row).Item("subsamount")) > 0 Or Val(posting.Rows(row).Item("taxamount")) > 0 Then
                            balance = balance + Val(posting.Rows(row).Item("subsamount")) + Val(posting.Rows(row).Item("taxamount"))
                        End If
                        mcode = posting.Rows(row).Item("mcode")
                    End With
                Next row
                Me.Cursor = Cursors.Default
            Else
                MsgBox("No Record Pls Check...", MsgBoxStyle.OkOnly)
                'btn_Revert.Enabled = True
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_process_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_process.Click
        Try
            Dim monthly1, chargecode, mcode1, itemtypecode, billnos, MONTHS As String
            Dim billdate, MONTHDATE, monthdate1, DUEDATE, BILLDATE1, BILLDATE2, RECDATE, OVER As Date
            Dim subscode, day, year1, dues, accounts, bill, TAXDESC As String
            Dim YEARSTART As String
            MONTHS = Format(dtp_year.Value, "MMM")
            If MONTHS = "Apr" Then Day = 30
            If MONTHS = "May" Then Day = 31
            If MONTHS = "Jun" Then Day = 30
            If MONTHS = "Jul" Then Day = 31
            If MONTHS = "Aug" Then Day = 31
            If MONTHS = "Sep" Then Day = 30
            If MONTHS = "Oct" Then Day = 31
            If MONTHS = "Nov" Then Day = 30
            If MONTHS = "Dec" Then Day = 31
            If MONTHS = "Jan" Then Day = 31
            If gFinancialEnd Mod 4 = 0 Then

                If MONTHS = "Feb" Then Day = 29
            Else
                If MONTHS = "Feb" Then Day = 28
            End If
            If MONTHS = "Mar" Then Day = 31
            'End If
            monthly = Month(Format(dtp_year.Value, "dd/MMM/yyyy"))

            If MONTHS = "Apr" Then year1 = gFinancalyearStart
            If MONTHS = "May" Then year1 = gFinancalyearStart
            If MONTHS = "Jun" Then year1 = gFinancalyearStart
            If MONTHS = "Jul" Then year1 = gFinancalyearStart
            If MONTHS = "Aug" Then year1 = gFinancalyearStart
            If MONTHS = "Sep" Then year1 = gFinancalyearStart
            If MONTHS = "Oct" Then year1 = gFinancalyearStart
            If MONTHS = "Nov" Then year1 = gFinancalyearStart
            If MONTHS = "Dec" Then year1 = gFinancalyearStart
            If MONTHS = "Jan" Then year1 = gFinancialEnd
            If MONTHS = "Feb" Then year1 = gFinancialEnd
            If MONTHS = "Mar" Then year1 = gFinancialEnd
            'year1 = gFinancialEnd
            MONTHDATE = day & "/" & MONTHS & "/" & year1
            monthdate1 = "01/" & MONTHS & "/" & year1
            BILLDATE1 = CDate(MONTHDATE)
            BILLDATE1 = Format(MONTHDATE, "dd MMM yyyy")
            BILLDATE2 = CDate(monthdate1)
            BILLDATE2 = Format(monthdate1, "dd MMM yyyy")

            Dim ssql1 As String
            ssql1 = "SELECT VOUCHERNO,VOUCHERTYPE FROM JOURNALENTRY WHERE VOUCHERTYPE = 'SBIL' AND VOUCHERDATE = '" & Format(dtp_year.Value, "dd/MMM/yyyy") & "' AND ISNULL(VOID,'')<>'Y'"
            gconnection.getDataSet(ssql1, "VOUCHER")
            If gdataset.Tables("VOUCHER").Rows.Count > 0 Then
                MessageBox.Show("Subscription Already Posted")
                Exit Sub
            End If
            '(@Postingdate varchar(11),@Postingtype varchar(30),@postingsno varchar(5),@postingdesc varchar(50),
            '@period varchar(50),@FinancalyearStart varchar(11),@FinancialYearEnd varchar(11))
            'sqlString = "Exec tp_subscriptionpost '" & Format(dtp_year.Value, "dd/MMM/yyyy") & "','" & Trim(cbo_BillingBasis.Text) & "','" & TempString(0) & "',"
            ' sqlString = "Exec tp_subscriptionpost '" & Format(BILLDATE1, "dd/MMM/yyyy") & "','" & Trim(cbo_BillingBasis.Text) & "','" & TempString(0) & "',"
            sqlString = "Exec tp_subscriptionpost_NRI '" & Format(BILLDATE1, "dd/MMM/yyyy") & "','" & Trim(cbo_BillingBasis.Text) & "','" & TempString(0) & "',"
            sqlString = sqlString & "'" & Replace(txtdesc.Text, "'", " ") & "','" & posting.Rows(0).Item("period") & "','" & gFinancalyearStart & "','" & gFinancialyearEnd & "','" & Format(BILLDATE2, "dd/MMM/yyyy") & "'"
            'posting = gconnection.GetValues(sqlString)
            posting = gconnection.ExcuteStoreProcedure(sqlString)
            '=============Change on 02.10.08 Begin
            'If CheckBox1.Checked = True Then
            '    If MsgBox("Auto Matching Adjsutment......", MsgBoxStyle.OKCancel + MsgBoxStyle.DefaultButton1, "Confirmation") = MsgBoxResult.OK Then
            '        sqlString = "Exec tp_Auto_matching1_CSC '01/Apr/1994','" & Format(dtp_year.Value, "dd/MMM/yyyy") & "'"
            '        posting = gconnection.GetValues(sqlString)
            '    End If
            'End If
            '==================================End
            'sqlString = "INSERT INTO OUTSTANDING(VOUCHERNO,VOUCHERDATE,VOUCHERTYPE,VOUCHERCATEGORY,ACCOUNTCODE,SLCODE,AMOUNT,DESCRIPTION,CREDITDEBIT,OPPACCOUNTCODE)"
            'sqlString = sqlString & "SELECT BILLNO,BILLDATE,'SBIL','SBIL',(SELECT SDRSCODE FROM ACCOUNTSSETUP),MCODE,ISNULL(AMOUNT,0)+ISNULL(TAXAMOUNT,0),SUBSDESC,'DEBIT',SUBSCODE FROM SUBSPOSTING WHERE MONTH(BILLDATE)='" & Format(dtp_year.Value, "MM") & "'"
            'posting = gconnection.GetValues(sqlString)

            'sqlString = " INSERT INTO Outstanding(VoucherNo,VoucherDate,VoucherType,VoucherCategory,AccountCode,SLCode,Amount,Description,CreditDebit,OPPACCOUNTCODE)"
            'sqlString = sqlString & " SELECT BILLNO,S.BILLDATE,'SBIL','SBIL',(SELECT SDRSCODE FROM ACCOUNTSSETUP),MCODE,SUM(AMOUNT)+ISNULL(OPDEBITS,0),SUBSDESC,'DEBIT',SUBSCODE FROM SUBSPOSTING_OVER S,ACCOUNTSSUBLEDGERMASTER A WHERE A.slcode=S.mcode AND A.ACCODE=(SELECT SDRSCODE FROM ACCOUNTSSETUP) AND S.type='OVER' AND ISNULL(A.OPDEBITS,0)>0 GROUP BY billno,S.BILLDATE,mcode,subscode,subsdesc,A.opdebits"
            'posting = gconnection.GetValues(sqlString)
            ''sqlString = "Update postingmast set postingflag='Y', postingdate='" & Format(dtp_year.Value, "dd/MMM/yyyy") & "'," & "userid='" & gUsername & "'"
            'sqlString = sqlString & " where postingsno='" & TempString(0) & "' and postingcode='" & Trim(cbo_BillingBasis.Text) & "'"
            'posting = gconnection.GetValues(sqlString)

            'sqlString = "update subsposting set ACCOUNTFLAG='Y' "
            'sqlString = sqlString & " where postingsno=" & TempString(0) & " and postingcode='" & Trim(cbo_BillingBasis.Text) & "'"
            'sqlString = sqlString & " and isnull(ACCOUNTFLAG,'')<> 'Y'"
            'posting = gconnection.GetValues(sqlString)

            MessageBox.Show("Subscription Posting Completed Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call cancel_Click(sender, e)
        Catch ex As Exception

        End Try
    End Sub
End Class
