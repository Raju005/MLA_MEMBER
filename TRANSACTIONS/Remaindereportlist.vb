Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.IO
Imports CrystalDecisions.reportsource
Imports CrystalDecisions.shared
Imports CrystalDecisions.web
Public Class Remaindereportlist
    Inherits System.Windows.Forms.Form
    Dim gconnection As New GlobalClass
    Dim sqlString, chk_month, vtypedesc As String
    Public sqlStringFinal, DispString, membertype, lettertype, vhead, firstdate As String
    Dim iNumber, row, addamt, docno As Integer
    Dim billno As Long
    Public TempString(2), bill As String
    Dim storedPro_str As String
    Dim Fromdate, ToDate As String
    Dim postype, Vcatefile, sout, rout, MONTH1 As String
    Dim posting, posting1 As New DataTable
    Dim dr As DataRow
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim BOOLCHK As Boolean
    Dim dt As New DataTable
    Dim Processed_Chk(4) As Integer
    Friend WithEvents txt_docno As System.Windows.Forms.TextBox
    Friend WithEvents dtp_docdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Dtp_Last As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btn_Revert As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TXT_REFNO As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GRID_REMINDER As System.Windows.Forms.DataGridView
    Friend WithEvents MCODE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MNAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BALANCE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CHECKED As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GRP_SMS As System.Windows.Forms.GroupBox
    Friend WithEvents GRID_SMS As System.Windows.Forms.DataGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BALANCE1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATE1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RBTREMINDERLIST As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RBTREMINDERADDRESS As System.Windows.Forms.RadioButton
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Chk_lttr As System.Windows.Forms.CheckBox
    Dim txtobj1 As TextObject
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_close As System.Windows.Forms.Button
    Friend WithEvents BTNSCREEN As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CMBLETERNO As System.Windows.Forms.ComboBox
    Friend WithEvents letterno As System.Windows.Forms.Label
    Friend WithEvents CHKCATEGORY As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpASNODATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents BTNPRINT As System.Windows.Forms.Button
    Friend WithEvents RBTREMINDERSUMMARY As System.Windows.Forms.RadioButton
    Friend WithEvents RBTREMINDERLETTER As System.Windows.Forms.RadioButton
    Friend WithEvents cmd_MCodeToHelp As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXTMCODETO As System.Windows.Forms.TextBox
    Friend WithEvents chk_PrintAll As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Dtp_CutOffDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cmb_ReminderType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txt_CreditLimit As System.Windows.Forms.TextBox
    Friend WithEvents cmd_MCodefromHelp As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXTMCODEFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DTP_FIRST As System.Windows.Forms.Label
    Friend WithEvents Dtp_rem As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTNSCREEN = New System.Windows.Forms.Button()
        Me.Btn_close = New System.Windows.Forms.Button()
        Me.BTNPRINT = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBTREMINDERLIST = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TXT_REFNO = New System.Windows.Forms.TextBox()
        Me.Dtp_Last = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Dtp_rem = New System.Windows.Forms.DateTimePicker()
        Me.DTP_FIRST = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmd_MCodefromHelp = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTMCODEFrom = New System.Windows.Forms.TextBox()
        Me.Txt_CreditLimit = New System.Windows.Forms.TextBox()
        Me.Cmb_ReminderType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Dtp_CutOffDate = New System.Windows.Forms.DateTimePicker()
        Me.chk_PrintAll = New System.Windows.Forms.CheckBox()
        Me.cmd_MCodeToHelp = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTMCODETO = New System.Windows.Forms.TextBox()
        Me.RBTREMINDERSUMMARY = New System.Windows.Forms.RadioButton()
        Me.RBTREMINDERLETTER = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpASNODATE = New System.Windows.Forms.DateTimePicker()
        Me.CMBLETERNO = New System.Windows.Forms.ComboBox()
        Me.letterno = New System.Windows.Forms.Label()
        Me.CHKCATEGORY = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GRID_REMINDER = New System.Windows.Forms.DataGridView()
        Me.MCODE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BALANCE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CHECKED = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GRP_SMS = New System.Windows.Forms.GroupBox()
        Me.GRID_SMS = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BALANCE1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATE1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txt_docno = New System.Windows.Forms.TextBox()
        Me.dtp_docdate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_Revert = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.RBTREMINDERADDRESS = New System.Windows.Forms.RadioButton()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Chk_lttr = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GRID_REMINDER, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRP_SMS.SuspendLayout()
        CType(Me.GRID_SMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(182, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 23)
        Me.Label2.TabIndex = 386
        Me.Label2.Text = "REMINDER LETTER"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(177, 553)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(656, 56)
        Me.GroupBox2.TabIndex = 391
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(869, 463)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 50)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "SMS"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Visible = False
        '
        'BTNSCREEN
        '
        Me.BTNSCREEN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTNSCREEN.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSCREEN.ForeColor = System.Drawing.Color.Black
        Me.BTNSCREEN.Image = Global.Bengal_MemberMaster.My.Resources.Resources.view
        Me.BTNSCREEN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNSCREEN.Location = New System.Drawing.Point(867, 160)
        Me.BTNSCREEN.Name = "BTNSCREEN"
        Me.BTNSCREEN.Size = New System.Drawing.Size(137, 50)
        Me.BTNSCREEN.TabIndex = 12
        Me.BTNSCREEN.Text = "VIEW [F5]"
        Me.BTNSCREEN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Btn_close
        '
        Me.Btn_close.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_close.ForeColor = System.Drawing.Color.Black
        Me.Btn_close.Image = Global.Bengal_MemberMaster.My.Resources.Resources._Exit
        Me.Btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_close.Location = New System.Drawing.Point(868, 332)
        Me.Btn_close.Name = "Btn_close"
        Me.Btn_close.Size = New System.Drawing.Size(137, 50)
        Me.Btn_close.TabIndex = 14
        Me.Btn_close.Text = "Exit [F11]"
        Me.Btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BTNPRINT
        '
        Me.BTNPRINT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTNPRINT.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNPRINT.ForeColor = System.Drawing.Color.Black
        Me.BTNPRINT.Image = Global.Bengal_MemberMaster.My.Resources.Resources.print
        Me.BTNPRINT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNPRINT.Location = New System.Drawing.Point(868, 276)
        Me.BTNPRINT.Name = "BTNPRINT"
        Me.BTNPRINT.Size = New System.Drawing.Size(137, 50)
        Me.BTNPRINT.TabIndex = 13
        Me.BTNPRINT.Text = "PRINT [F6]"
        Me.BTNPRINT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(400, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 18)
        Me.Label5.TabIndex = 363
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Chk_lttr)
        Me.GroupBox1.Controls.Add(Me.RBTREMINDERLIST)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TXT_REFNO)
        Me.GroupBox1.Controls.Add(Me.Dtp_Last)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Dtp_rem)
        Me.GroupBox1.Controls.Add(Me.DTP_FIRST)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmd_MCodefromHelp)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TXTMCODEFrom)
        Me.GroupBox1.Controls.Add(Me.Txt_CreditLimit)
        Me.GroupBox1.Controls.Add(Me.Cmb_ReminderType)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Dtp_CutOffDate)
        Me.GroupBox1.Controls.Add(Me.chk_PrintAll)
        Me.GroupBox1.Controls.Add(Me.cmd_MCodeToHelp)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TXTMCODETO)
        Me.GroupBox1.Controls.Add(Me.RBTREMINDERSUMMARY)
        Me.GroupBox1.Controls.Add(Me.RBTREMINDERLETTER)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpASNODATE)
        Me.GroupBox1.Controls.Add(Me.CMBLETERNO)
        Me.GroupBox1.Controls.Add(Me.letterno)
        Me.GroupBox1.Controls.Add(Me.CHKCATEGORY)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(177, 150)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(656, 454)
        Me.GroupBox1.TabIndex = 387
        Me.GroupBox1.TabStop = False
        '
        'RBTREMINDERLIST
        '
        Me.RBTREMINDERLIST.BackColor = System.Drawing.Color.Transparent
        Me.RBTREMINDERLIST.Checked = True
        Me.RBTREMINDERLIST.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTREMINDERLIST.Location = New System.Drawing.Point(388, 414)
        Me.RBTREMINDERLIST.Name = "RBTREMINDERLIST"
        Me.RBTREMINDERLIST.Size = New System.Drawing.Size(221, 22)
        Me.RBTREMINDERLIST.TabIndex = 622
        Me.RBTREMINDERLIST.TabStop = True
        Me.RBTREMINDERLIST.Text = "Reminder Sticker List"
        Me.RBTREMINDERLIST.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(218, 216)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(221, 22)
        Me.RadioButton1.TabIndex = 444
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Reminder List"
        Me.RadioButton1.UseVisualStyleBackColor = False
        Me.RadioButton1.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(409, 379)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 18)
        Me.Label14.TabIndex = 443
        Me.Label14.Text = "REF NO :"
        '
        'TXT_REFNO
        '
        Me.TXT_REFNO.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_REFNO.Location = New System.Drawing.Point(513, 375)
        Me.TXT_REFNO.Name = "TXT_REFNO"
        Me.TXT_REFNO.Size = New System.Drawing.Size(160, 26)
        Me.TXT_REFNO.TabIndex = 442
        '
        'Dtp_Last
        '
        Me.Dtp_Last.CalendarMonthBackground = System.Drawing.Color.White
        Me.Dtp_Last.CustomFormat = "yyyy"
        Me.Dtp_Last.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_Last.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_Last.Location = New System.Drawing.Point(185, 374)
        Me.Dtp_Last.Name = "Dtp_Last"
        Me.Dtp_Last.Size = New System.Drawing.Size(136, 26)
        Me.Dtp_Last.TabIndex = 441
        Me.Dtp_Last.Value = New Date(2009, 2, 12, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(31, 377)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 18)
        Me.Label11.TabIndex = 440
        Me.Label11.Text = "LAST DATE: "
        '
        'Dtp_rem
        '
        Me.Dtp_rem.CalendarMonthBackground = System.Drawing.Color.White
        Me.Dtp_rem.CustomFormat = "yyyy"
        Me.Dtp_rem.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_rem.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_rem.Location = New System.Drawing.Point(512, 336)
        Me.Dtp_rem.Name = "Dtp_rem"
        Me.Dtp_rem.Size = New System.Drawing.Size(136, 26)
        Me.Dtp_rem.TabIndex = 439
        Me.Dtp_rem.Value = New Date(2009, 2, 12, 0, 0, 0, 0)
        '
        'DTP_FIRST
        '
        Me.DTP_FIRST.AutoSize = True
        Me.DTP_FIRST.BackColor = System.Drawing.Color.Transparent
        Me.DTP_FIRST.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_FIRST.Location = New System.Drawing.Point(368, 339)
        Me.DTP_FIRST.Name = "DTP_FIRST"
        Me.DTP_FIRST.Size = New System.Drawing.Size(148, 18)
        Me.DTP_FIRST.TabIndex = 438
        Me.DTP_FIRST.Text = "LETTER DATED: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(80, 336)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 18)
        Me.Label6.TabIndex = 437
        Me.Label6.Text = "AMOUNT :"
        '
        'cmd_MCodefromHelp
        '
        Me.cmd_MCodefromHelp.BackColor = System.Drawing.Color.Transparent
        Me.cmd_MCodefromHelp.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodefromHelp.Location = New System.Drawing.Point(120, 120)
        Me.cmd_MCodefromHelp.Name = "cmd_MCodefromHelp"
        Me.cmd_MCodefromHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodefromHelp.TabIndex = 435
        Me.cmd_MCodefromHelp.UseVisualStyleBackColor = False
        Me.cmd_MCodefromHelp.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-111, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 18)
        Me.Label3.TabIndex = 436
        Me.Label3.Text = "MCODE FROM : "
        Me.Label3.Visible = False
        '
        'TXTMCODEFrom
        '
        Me.TXTMCODEFrom.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXTMCODEFrom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTMCODEFrom.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMCODEFrom.Location = New System.Drawing.Point(48, 72)
        Me.TXTMCODEFrom.Name = "TXTMCODEFrom"
        Me.TXTMCODEFrom.Size = New System.Drawing.Size(112, 26)
        Me.TXTMCODEFrom.TabIndex = 434
        Me.TXTMCODEFrom.Visible = False
        '
        'Txt_CreditLimit
        '
        Me.Txt_CreditLimit.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_CreditLimit.Location = New System.Drawing.Point(184, 336)
        Me.Txt_CreditLimit.Name = "Txt_CreditLimit"
        Me.Txt_CreditLimit.Size = New System.Drawing.Size(100, 26)
        Me.Txt_CreditLimit.TabIndex = 433
        Me.Txt_CreditLimit.Text = "1"
        '
        'Cmb_ReminderType
        '
        Me.Cmb_ReminderType.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Cmb_ReminderType.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_ReminderType.ItemHeight = 18
        Me.Cmb_ReminderType.Items.AddRange(New Object() {"MEMBER", "NRI MEMBER"})
        Me.Cmb_ReminderType.Location = New System.Drawing.Point(184, 256)
        Me.Cmb_ReminderType.Name = "Cmb_ReminderType"
        Me.Cmb_ReminderType.Size = New System.Drawing.Size(144, 26)
        Me.Cmb_ReminderType.TabIndex = 431
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 18)
        Me.Label4.TabIndex = 432
        Me.Label4.Text = "REMINDER TYPE : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(336, 300)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(178, 18)
        Me.Label9.TabIndex = 427
        Me.Label9.Text = "RECEIPTS  UPTO : "
        '
        'Dtp_CutOffDate
        '
        Me.Dtp_CutOffDate.CalendarMonthBackground = System.Drawing.Color.White
        Me.Dtp_CutOffDate.CustomFormat = "yyyy"
        Me.Dtp_CutOffDate.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_CutOffDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_CutOffDate.Location = New System.Drawing.Point(512, 296)
        Me.Dtp_CutOffDate.Name = "Dtp_CutOffDate"
        Me.Dtp_CutOffDate.Size = New System.Drawing.Size(136, 26)
        Me.Dtp_CutOffDate.TabIndex = 426
        Me.Dtp_CutOffDate.Value = New Date(2009, 2, 12, 0, 0, 0, 0)
        '
        'chk_PrintAll
        '
        Me.chk_PrintAll.BackColor = System.Drawing.Color.Transparent
        Me.chk_PrintAll.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PrintAll.Location = New System.Drawing.Point(184, 16)
        Me.chk_PrintAll.Name = "chk_PrintAll"
        Me.chk_PrintAll.Size = New System.Drawing.Size(216, 32)
        Me.chk_PrintAll.TabIndex = 424
        Me.chk_PrintAll.Text = "Check all Category"
        Me.chk_PrintAll.UseVisualStyleBackColor = False
        '
        'cmd_MCodeToHelp
        '
        Me.cmd_MCodeToHelp.BackColor = System.Drawing.Color.Transparent
        Me.cmd_MCodeToHelp.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodeToHelp.Location = New System.Drawing.Point(632, 88)
        Me.cmd_MCodeToHelp.Name = "cmd_MCodeToHelp"
        Me.cmd_MCodeToHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodeToHelp.TabIndex = 7
        Me.cmd_MCodeToHelp.UseVisualStyleBackColor = False
        Me.cmd_MCodeToHelp.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(488, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 18)
        Me.Label8.TabIndex = 420
        Me.Label8.Text = "MCODE TO : "
        Me.Label8.Visible = False
        '
        'TXTMCODETO
        '
        Me.TXTMCODETO.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXTMCODETO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTMCODETO.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMCODETO.Location = New System.Drawing.Point(512, 88)
        Me.TXTMCODETO.Name = "TXTMCODETO"
        Me.TXTMCODETO.Size = New System.Drawing.Size(104, 26)
        Me.TXTMCODETO.TabIndex = 6
        Me.TXTMCODETO.Visible = False
        '
        'RBTREMINDERSUMMARY
        '
        Me.RBTREMINDERSUMMARY.BackColor = System.Drawing.Color.Transparent
        Me.RBTREMINDERSUMMARY.Checked = True
        Me.RBTREMINDERSUMMARY.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTREMINDERSUMMARY.Location = New System.Drawing.Point(211, 414)
        Me.RBTREMINDERSUMMARY.Name = "RBTREMINDERSUMMARY"
        Me.RBTREMINDERSUMMARY.Size = New System.Drawing.Size(221, 22)
        Me.RBTREMINDERSUMMARY.TabIndex = 9
        Me.RBTREMINDERSUMMARY.TabStop = True
        Me.RBTREMINDERSUMMARY.Text = "Reminder List"
        Me.RBTREMINDERSUMMARY.UseVisualStyleBackColor = False
        '
        'RBTREMINDERLETTER
        '
        Me.RBTREMINDERLETTER.BackColor = System.Drawing.Color.Transparent
        Me.RBTREMINDERLETTER.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTREMINDERLETTER.Location = New System.Drawing.Point(29, 414)
        Me.RBTREMINDERLETTER.Name = "RBTREMINDERLETTER"
        Me.RBTREMINDERLETTER.Size = New System.Drawing.Size(216, 22)
        Me.RBTREMINDERLETTER.TabIndex = 8
        Me.RBTREMINDERLETTER.Text = "Reminder Letter"
        Me.RBTREMINDERLETTER.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 18)
        Me.Label1.TabIndex = 405
        Me.Label1.Text = "BILL UPTO : "
        '
        'dtpASNODATE
        '
        Me.dtpASNODATE.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpASNODATE.CustomFormat = "MMMMM"
        Me.dtpASNODATE.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpASNODATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpASNODATE.Location = New System.Drawing.Point(184, 296)
        Me.dtpASNODATE.Name = "dtpASNODATE"
        Me.dtpASNODATE.Size = New System.Drawing.Size(144, 26)
        Me.dtpASNODATE.TabIndex = 3
        Me.dtpASNODATE.Value = New Date(2009, 2, 12, 0, 0, 0, 0)
        '
        'CMBLETERNO
        '
        Me.CMBLETERNO.BackColor = System.Drawing.Color.AntiqueWhite
        Me.CMBLETERNO.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBLETERNO.ItemHeight = 18
        Me.CMBLETERNO.Items.AddRange(New Object() {"1", "2", "3"})
        Me.CMBLETERNO.Location = New System.Drawing.Point(512, 256)
        Me.CMBLETERNO.Name = "CMBLETERNO"
        Me.CMBLETERNO.Size = New System.Drawing.Size(136, 26)
        Me.CMBLETERNO.TabIndex = 0
        '
        'letterno
        '
        Me.letterno.AutoSize = True
        Me.letterno.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.letterno.Location = New System.Drawing.Point(376, 256)
        Me.letterno.Name = "letterno"
        Me.letterno.Size = New System.Drawing.Size(138, 18)
        Me.letterno.TabIndex = 402
        Me.letterno.Text = "LETTER  NO : "
        '
        'CHKCATEGORY
        '
        Me.CHKCATEGORY.BackColor = System.Drawing.Color.AntiqueWhite
        Me.CHKCATEGORY.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKCATEGORY.Location = New System.Drawing.Point(184, 48)
        Me.CHKCATEGORY.Name = "CHKCATEGORY"
        Me.CHKCATEGORY.Size = New System.Drawing.Size(296, 193)
        Me.CHKCATEGORY.Sorted = True
        Me.CHKCATEGORY.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.GRID_REMINDER)
        Me.GroupBox3.Location = New System.Drawing.Point(212, 62)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(709, 410)
        Me.GroupBox3.TabIndex = 444
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "REMINDER"
        Me.GroupBox3.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(380, 355)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(125, 43)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "CANCEL"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(225, 356)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 42)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "OK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GRID_REMINDER
        '
        Me.GRID_REMINDER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRID_REMINDER.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MCODE, Me.MNAME, Me.BALANCE, Me.CHECKED})
        Me.GRID_REMINDER.Location = New System.Drawing.Point(10, 25)
        Me.GRID_REMINDER.Name = "GRID_REMINDER"
        Me.GRID_REMINDER.Size = New System.Drawing.Size(777, 311)
        Me.GRID_REMINDER.TabIndex = 0
        '
        'MCODE
        '
        Me.MCODE.HeaderText = "MCODE"
        Me.MCODE.Name = "MCODE"
        Me.MCODE.ReadOnly = True
        Me.MCODE.Width = 130
        '
        'MNAME
        '
        Me.MNAME.HeaderText = "MNAME"
        Me.MNAME.MinimumWidth = 50
        Me.MNAME.Name = "MNAME"
        Me.MNAME.ReadOnly = True
        Me.MNAME.Width = 300
        '
        'BALANCE
        '
        Me.BALANCE.HeaderText = "BALANCE"
        Me.BALANCE.Name = "BALANCE"
        Me.BALANCE.ReadOnly = True
        Me.BALANCE.Width = 150
        '
        'CHECKED
        '
        Me.CHECKED.HeaderText = "CHECKED"
        Me.CHECKED.Name = "CHECKED"
        '
        'GRP_SMS
        '
        Me.GRP_SMS.Controls.Add(Me.GRID_SMS)
        Me.GRP_SMS.Controls.Add(Me.Button4)
        Me.GRP_SMS.Controls.Add(Me.Button5)
        Me.GRP_SMS.Location = New System.Drawing.Point(156, 144)
        Me.GRP_SMS.Name = "GRP_SMS"
        Me.GRP_SMS.Size = New System.Drawing.Size(804, 414)
        Me.GRP_SMS.TabIndex = 445
        Me.GRP_SMS.TabStop = False
        Me.GRP_SMS.Text = "SMS"
        Me.GRP_SMS.Visible = False
        '
        'GRID_SMS
        '
        Me.GRID_SMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GRID_SMS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.BALANCE1, Me.DATE1, Me.DataGridViewCheckBoxColumn1})
        Me.GRID_SMS.Location = New System.Drawing.Point(6, 25)
        Me.GRID_SMS.Name = "GRID_SMS"
        Me.GRID_SMS.Size = New System.Drawing.Size(793, 311)
        Me.GRID_SMS.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "MCODE"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 120
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "MNAME"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 178
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "MOBILE NO"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'BALANCE1
        '
        Me.BALANCE1.HeaderText = "BALANCE"
        Me.BALANCE1.Name = "BALANCE1"
        Me.BALANCE1.ReadOnly = True
        '
        'DATE1
        '
        Me.DATE1.HeaderText = "FROM DATE"
        Me.DATE1.Name = "DATE1"
        Me.DATE1.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "CHECKED"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(432, 355)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(125, 43)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "CANCEL"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(277, 356)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(125, 42)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "SMS"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txt_docno
        '
        Me.txt_docno.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_docno.Location = New System.Drawing.Point(732, 109)
        Me.txt_docno.Name = "txt_docno"
        Me.txt_docno.Size = New System.Drawing.Size(100, 21)
        Me.txt_docno.TabIndex = 617
        '
        'dtp_docdate
        '
        Me.dtp_docdate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_docdate.CustomFormat = "yyyy"
        Me.dtp_docdate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_docdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_docdate.Location = New System.Drawing.Point(733, 133)
        Me.dtp_docdate.Name = "dtp_docdate"
        Me.dtp_docdate.Size = New System.Drawing.Size(100, 21)
        Me.dtp_docdate.TabIndex = 616
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(666, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 15)
        Me.Label7.TabIndex = 615
        Me.Label7.Text = "DOC. DATE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(665, 112)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 15)
        Me.Label10.TabIndex = 614
        Me.Label10.Text = "DOC.NO."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(646, 45)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 25)
        Me.Label12.TabIndex = 618
        Me.Label12.Text = "Label12"
        '
        'btn_Revert
        '
        Me.btn_Revert.Enabled = False
        Me.btn_Revert.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Revert.ForeColor = System.Drawing.Color.Black
        Me.btn_Revert.Image = Global.Bengal_MemberMaster.My.Resources.Resources.Delete
        Me.btn_Revert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Revert.Location = New System.Drawing.Point(867, 220)
        Me.btn_Revert.Name = "btn_Revert"
        Me.btn_Revert.Size = New System.Drawing.Size(137, 50)
        Me.btn_Revert.TabIndex = 619
        Me.btn_Revert.Text = "Void [F6]"
        Me.btn_Revert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.Color.Black
        Me.btn_clear.Image = Global.Bengal_MemberMaster.My.Resources.Resources.Clear
        Me.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clear.Location = New System.Drawing.Point(867, 390)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(137, 50)
        Me.btn_clear.TabIndex = 620
        Me.btn_clear.Text = "Clear[F7]"
        Me.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(595, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 25)
        Me.Label13.TabIndex = 621
        '
        'RBTREMINDERADDRESS
        '
        Me.RBTREMINDERADDRESS.BackColor = System.Drawing.Color.Transparent
        Me.RBTREMINDERADDRESS.Checked = True
        Me.RBTREMINDERADDRESS.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTREMINDERADDRESS.Location = New System.Drawing.Point(775, 565)
        Me.RBTREMINDERADDRESS.Name = "RBTREMINDERADDRESS"
        Me.RBTREMINDERADDRESS.Size = New System.Drawing.Size(231, 22)
        Me.RBTREMINDERADDRESS.TabIndex = 623
        Me.RBTREMINDERADDRESS.TabStop = True
        Me.RBTREMINDERADDRESS.Text = "Reminder Address List"
        Me.RBTREMINDERADDRESS.UseVisualStyleBackColor = False
        Me.RBTREMINDERADDRESS.Visible = False
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(869, 519)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(137, 50)
        Me.Button6.TabIndex = 624
        Me.Button6.Text = "EMAIL"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.Visible = False
        '
        'Chk_lttr
        '
        Me.Chk_lttr.AutoSize = True
        Me.Chk_lttr.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_lttr.Location = New System.Drawing.Point(335, 378)
        Me.Chk_lttr.Name = "Chk_lttr"
        Me.Chk_lttr.Size = New System.Drawing.Size(137, 22)
        Me.Chk_lttr.TabIndex = 623
        Me.Chk_lttr.Text = "LETTER HEAD"
        Me.Chk_lttr.UseVisualStyleBackColor = True
        '
        'Remaindereportlist
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources._111in1024res
        Me.ClientSize = New System.Drawing.Size(1008, 614)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.RBTREMINDERADDRESS)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_Revert)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_docno)
        Me.Controls.Add(Me.dtp_docdate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BTNSCREEN)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTNPRINT)
        Me.Controls.Add(Me.Btn_close)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GRP_SMS)
        Me.KeyPreview = True
        Me.Name = "Remaindereportlist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reminder Letter"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.GRID_REMINDER, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRP_SMS.ResumeLayout(False)
        CType(Me.GRID_SMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
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
        Me.BTNSCREEN.Enabled = False
        Me.BTNPRINT.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.BTNSCREEN.Enabled = True
                    Me.BTNPRINT.Enabled = True
                    Exit Sub
                End If
                If Right(x) = "V" Then
                    Me.BTNSCREEN.Enabled = True
                End If
                If Right(x) = "P" Then
                    Me.BTNPRINT.Enabled = True
                End If
            Next
        End If
    End Sub

    Public Function reminder1() As Boolean
        Dim SSQL As String
        BOOLCHK = False
        If txt_docno.Text <> "" Or txt_docno.Enabled = False Then

        Else
            If CMBLETERNO.Text = "1" Then
                SSQL = "SELECT * FROM REMINDERHISTORY WHERE ISNULL(FROMDATE,'')='" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "' AND REMINDERNO=" & CMBLETERNO.Text & " AND ISNULL(VOID,'')<>'Y' AND TYPE='" & Cmb_ReminderType.Text & "'"
                gconnection.getDataSet(SSQL, "REMINDER")
                If gdataset.Tables("REMINDER").Rows.Count > 0 Then
                    MsgBox("Reminder Already Generated for this Month")
                    BOOLCHK = False
                    Exit Function

                End If
            Else
                SSQL = "SELECT * FROM REMINDERHISTORY WHERE ISNULL(FROMDATE,'')='" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "' AND REMINDERNO=" & CMBLETERNO.Text & " AND ISNULL(VOID,'')<>'Y'"
                gconnection.getDataSet(SSQL, "REMINDER")
                If gdataset.Tables("REMINDER").Rows.Count > 0 Then
                    MsgBox("Reminder Already Generated for this Month")
                    BOOLCHK = False
                    Exit Function

                End If
            End If
        End If
        BOOLCHK = True
    End Function

    Private Sub BTNSCREEN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSCREEN.Click
        GPRINT = False
        If txt_docno.Text <> "" Or txt_docno.Enabled = False Then

        Else

            If CHKCATEGORY.CheckedItems.Count = 0 Then
                MessageBox.Show("Please Select  the Member Category")
                CHKCATEGORY.Focus()
                Exit Sub
            End If
            If CMBLETERNO.Text = "" Then
                MessageBox.Show("Please Select The Letter No ")
                CMBLETERNO.Focus()
                Exit Sub
            End If
        End If
        reminder1()
        If BOOLCHK = False Then Exit Sub

        If CMBLETERNO.Text = "1" Or CMBLETERNO.Text = "2" Or CMBLETERNO.Text = "3" Or CMBLETERNO.Text = "4" Then
            If RBTREMINDERLETTER.Checked = True Then
                Call Printoperation2()


            ElseIf RBTREMINDERSUMMARY.Checked = True Then
                Call Summary2()
            ElseIf RBTREMINDERLIST.Checked = True Then

                Call printdata11()
            ElseIf RBTREMINDERADDRESS.Checked = True Then
                Call print_stikers()

            End If
        End If
        ' If
    End Sub
    Private Sub ADDRESS()

    End Sub
    Private Sub printoutstanding()
        Dim DT As New DataTable
        Dim I As Integer
        Dim vSql As Object
        Dim month1 As Object
        Dim Loopindex As Object
        Dim vtype() As Object
        Dim VTYPE1 As String
        Dim vsplit() As String
        Dim ssql, appcode() As String
        'Dim I As Integer
        Dim LAST As DateTime
        Dim cmonth, pmonth, CATEGORY As String

        vSql = ""
        LAST = DateAdd(DateInterval.Month, -1, dtpASNODATE.Value)
        sqlString = "SELECT dbo.[ufn_GetLastDayOfMonth]('" & Format(LAST, "yyyy-MM-dd") & "')"
        gconnection.getDataSet(sqlString, "mem")
        If gdataset.Tables("mem").Rows.Count > 0 Then
            LAST = gdataset.Tables("mem").Rows(0).Item(0)

        End If
        cmonth = Format(dtpASNODATE.Value, "MMM")
        pmonth = Format(LAST, "MMM")

        If txt_docno.Text <> "" Or txt_docno.Enabled = False Then

            ssql = ""
            ssql = "SELECT FROMDATE,TODATE,ASONDATE,MEMBERTYPECODE,BALANCE,MCODE,MNAME,REMINDERDATE,ADDUSER,ADDDATETIME,VOID,VOIDUSER,VOIDDATETIME,DOCNO,DOCDATE,REMINDERNO,CREDITLIMIT,REFNO,CAST(REFNO_DET AS VARCHAR) AS REFNO_DET,CMONTH,PMONTH,PUSAGE,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTCOUNTRY,CONTEMAIL,CONTSTATE,CONTCELL,CONTPIN,CONTPHONE1,CONTPHONE2,MEMBERTYPE,SALUT FROM MM_REMINDERHISTORY WHERE ISNULL(FROMDATE,'')='" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "' AND ISNULL(REMINDERNO,0)=" & CMBLETERNO.Text & " AND ISNULL(VOID,'')<>'Y' ORDER BY REFNO_DET"
            gconnection.getDataSet(ssql, "REMINDER")
            If gdataset.Tables("REMINDER").Rows.Count > 0 Then

            End If
            
        End If
        Exit Sub
    End Sub
    Private Function printdata11()
        Dim vMCode(2) As String
        Dim vMName(2) As String
        Dim vMAdd1(2) As String
        Dim vMAdd2(2) As String
        Dim vMAdd3(2) As String
        Dim sno As Integer
        Dim vMCity(2) As String
        Dim vMState(2) As String
        Dim vMTel(2) As String
        Dim vOption As Boolean
        Dim vMPinCode(2) As String
        Dim vsplit() As String
        Dim rcount As Integer
        Dim vAns As Double
        Dim str()() As String
        Dim i, j, lp, prn, lpNext1, lpNext2, pagesize As Integer
        Dim pageno As Long
        Dim count As Integer = 0
        Dim cnt As Integer
        Dim dr1 As DataRow
        Dim dr2 As DataRow
        Dim STR0 As String
        Dim STR1 As String
        Dim STR2 As String
        Dim STR3 As String
        Dim STR4 As String
        Dim STR5 As String
        Dim STR6 As String
        Dim STR7 As String
        Dim STR8 As String
        Dim STR9 As String
        Dim vDoj(2) As String
        Dim vspouse(2) As String
        Dim vOrgName(2) As String
        Dim vDesignation(2) As String
        Dim vMCompany(2) As String
        Dim vMFax(2) As String
        Dim vMCell(2) As String
        Dim vMEmail(2) As String
        Dim tname As String
        Dim SMem As String
        Dim SelMem As String
        Dim loopindex As Integer
        Try
            Dim cmdText As String

            Randomize()
            tname = "master1"
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            pageno = 1
            
            Dim icount As Integer
            'MessageBox.Show(dt.Rows.Count)

            If txt_docno.Text <> "" Or txt_docno.Enabled = False Then

                cmdText = ""
                'cmdText = ""


                pagesize = 1
                ' cmdText = "SELECT FROMDATE,TODATE,ASONDATE,MEMBERTYPECODE,BALANCE,MCODE,MNAME,REMINDERDATE,ADDUSER,ADDDATETIME,VOID,VOIDUSER,VOIDDATETIME,DOCNO,DOCDATE,REMINDERNO,CREDITLIMIT,REFNO,CAST(REFNO_DET AS VARCHAR) AS REFNO_DET,CMONTH,PMONTH,PUSAGE,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTCOUNTRY,CONTEMAIL,CONTSTATE,CONTCELL,CONTPIN,CONTPHONE1,CONTPHONE2,MEMBERTYPE,SALUT FROM MM_REMINDERHISTORY WHERE ISNULL(FROMDATE,'')='" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "' AND ISNULL(REMINDERNO,0)=" & CMBLETERNO.Text & " AND ISNULL(VOID,'')<>'Y' ORDER BY LEN(REFNO_DET),REFNO_DET"
                ' gconnection.getDataSet(cmdText, "REMINDER")
                ' dt = gconnection.GetValues(cmdText)
                If CMBLETERNO.Text = "1" Then

                    If Cmb_ReminderType.Text = "MEMBER" Then
                        'ssql = ""
                        cmdText = "SELECT FROMDATE,TODATE,ASONDATE,MEMBERTYPECODE,BALANCE,MCODE,MNAME,REMINDERDATE,ADDUSER,ADDDATETIME,VOID,VOIDUSER,VOIDDATETIME,DOCNO,DOCDATE,REMINDERNO,CREDITLIMIT,REFNO,CAST(REFNO_DET AS VARCHAR) AS REFNO_DET,CMONTH,PMONTH,PUSAGE,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTCOUNTRY,CONTEMAIL,CONTSTATE,CONTCELL,CONTPIN,CONTPHONE1,CONTPHONE2,MEMBERTYPE,SALUT FROM MM_REMINDERHISTORY WHERE ISNULL(FROMDATE,'')='" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "' AND ISNULL(DOCNO,0)=" & txt_docno.Text & " AND ISNULL(VOID,'')<>'Y' ORDER BY MCODE"
                        dt = gconnection.GetValues(cmdText)
                    ElseIf Cmb_ReminderType.Text = "PARTY" Then
                        cmdText = ""
                        cmdText = "SELECT FROMDATE,TODATE,ASONDATE,MEMBERTYPECODE,BALANCE,MCODE,MNAME,REMINDERDATE,ADDUSER,ADDDATETIME,VOID,VOIDUSER,VOIDDATETIME,DOCNO,DOCDATE,REMINDERNO,CREDITLIMIT,REFNO,CAST(REFNO_DET AS VARCHAR) AS REFNO_DET,CMONTH,PMONTH,PUSAGE,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTCOUNTRY,CONTEMAIL,CONTSTATE,CONTCELL,CONTPIN,CONTPHONE1,CONTPHONE2,MEMBERTYPE,SALUT FROM MM_REMINDERHISTORY WHERE ISNULL(FROMDATE,'')='" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "' AND ISNULL(DOCNO,0)=" & txt_docno.Text & " AND ISNULL(VOID,'')<>'Y' ORDER BY MCODE"
                        dt = gconnection.GetValues(cmdText)
                    ElseIf Cmb_ReminderType.Text = "CHAMBER" Then
                        cmdText = ""
                        cmdText = "SELECT FROMDATE,TODATE,ASONDATE,MEMBERTYPECODE,BALANCE,MCODE,MNAME,REMINDERDATE,ADDUSER,ADDDATETIME,VOID,VOIDUSER,VOIDDATETIME,DOCNO,DOCDATE,REMINDERNO,CREDITLIMIT,REFNO,CAST(REFNO_DET AS VARCHAR) AS REFNO_DET,CMONTH,PMONTH,PUSAGE,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTCOUNTRY,CONTEMAIL,CONTSTATE,CONTCELL,CONTPIN,CONTPHONE1,CONTPHONE2,MEMBERTYPE,SALUT FROM MM_REMINDERHISTORY WHERE ISNULL(FROMDATE,'')='" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "' AND ISNULL(DOCNO,0)=" & txt_docno.Text & " AND ISNULL(VOID,'')<>'Y' ORDER BY MCODE"
                        dt = gconnection.GetValues(cmdText)


                    End If
                Else
                    cmdText = ""
                    cmdText = "SELECT FROMDATE,TODATE,ASONDATE,MEMBERTYPECODE,BALANCE,MCODE,MNAME,REMINDERDATE,ADDUSER,ADDDATETIME,VOID,VOIDUSER,VOIDDATETIME,DOCNO,DOCDATE,REMINDERNO,CREDITLIMIT,REFNO,CAST(REFNO_DET AS VARCHAR) AS REFNO_DET,CMONTH,PMONTH,PUSAGE,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTCOUNTRY,CONTEMAIL,CONTSTATE,CONTCELL,CONTPIN,CONTPHONE1,CONTPHONE2,MEMBERTYPE,SALUT FROM MM_REMINDERHISTORY WHERE ISNULL(FROMDATE,'')='" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "' AND ISNULL(DOCNO,0)=" & txt_docno.Text & " AND ISNULL(VOID,'')<>'Y' ORDER BY MCODE"
                    dt = gconnection.GetValues(cmdText)

                End If


                If dt.Rows.Count > 0 Then

                    sno = 1
                    For i = 0 To dt.Rows.Count - 1
                        prn = 1
                        For j = 0 To 2
                            If i < dt.Rows.Count Then
                                vMCode(j) = Mid(Trim(dt.Rows(i).Item("mcode") & ""), 1, 40)
                                vMName(j) = Mid(Trim(dt.Rows(i).Item("SALUT") & ""), 1, 40) & " " & Mid(Trim(dt.Rows(i).Item("mname") & ""), 1, 40)
                                'vMName(j) = Mid(Trim(dt.Rows(i).Item("prefix") & ""), 1, 40)
                                vMAdd1(j) = Mid(Trim(dt.Rows(i).Item("contadd1") & ""), 1, 40)
                                vMAdd2(j) = Mid(Trim(dt.Rows(i).Item("contadd2") & ""), 1, 40)
                                vMAdd3(j) = Mid(Trim(dt.Rows(i).Item("contadd3") & ""), 1, 40)
                                vMCity(j) = Mid(Trim(dt.Rows(i).Item("contcity")) & IIf(Trim(dt.Rows(i).Item("contcity")) = "", "", "-") & Trim(dt.Rows(i).Item("contpin")), 1, 40)
                                vMTel(j) = "Tel. " & Trim(dt.Rows(i).Item("contphone1"))
                                i = i + 1
                            End If
                            sno = sno + 1
                        Next

                        Filewrite.WriteLine(Chr(14) & Chr(15))
                        Filewrite.WriteLine(Mid(vMCode(0), 1, 30) & Space(30 - Len(Mid(vMCode(0), 1, 30))) & Space(20) & Mid(vMCode(1), 1, 30) & Space(30 - Len(Mid(vMCode(1), 1, 30))) & Space(20) & Mid(vMCode(2), 1, 30) & Space(30 - Len(Mid(vMCode(2), 1, 30))))
                        pagesize = pagesize + 1
                        Filewrite.WriteLine(Mid(vMName(0), 1, 30) & Space(30 - Len(Mid(vMName(0), 1, 30))) & Space(20) & Mid(vMName(1), 1, 30) & Space(30 - Len(Mid(vMName(1), 1, 30))) & Space(20) & Mid(vMName(2), 1, 30) & Space(30 - Len(Mid(vMName(2), 1, 30))))
                        pagesize = pagesize + 1
                        Filewrite.WriteLine(Mid(vMAdd1(0), 1, 30) & Space(30 - Len(Mid(vMAdd1(0), 1, 30))) & Space(20) & Mid(vMAdd1(1), 1, 30) & Space(30 - Len(Mid(vMAdd1(1), 1, 30))) & Space(20) & Mid(vMAdd1(2), 1, 30) & Space(30 - Len(Mid(vMAdd1(2), 1, 30))))
                        pagesize = pagesize + 1
                        Filewrite.WriteLine(Mid(vMAdd2(0), 1, 30) & Space(30 - Len(Mid(vMAdd2(0), 1, 30))) & Space(20) & Mid(vMAdd2(1), 1, 30) & Space(30 - Len(Mid(vMAdd2(1), 1, 30))) & Space(20) & Mid(vMAdd2(2), 1, 30) & Space(30 - Len(Mid(vMAdd2(2), 1, 30))))
                        pagesize = pagesize + 1
                        Filewrite.WriteLine(Mid(vMAdd3(0), 1, 30) & Space(30 - Len(Mid(vMAdd3(0), 1, 30))) & Space(20) & Mid(vMAdd3(1), 1, 30) & Space(30 - Len(Mid(vMAdd3(1), 1, 30))) & Space(20) & Mid(vMAdd3(2), 1, 30) & Space(30 - Len(Mid(vMAdd3(2), 1, 30))))
                        pagesize = pagesize + 1
                        Filewrite.WriteLine(Mid(vMCity(0), 1, 30) & Space(30 - Len(Mid(vMCity(0), 1, 30))) & Space(20) & Mid(vMCity(1), 1, 30) & Space(30 - Len(Mid(vMCity(1), 1, 30))) & Space(20) & Mid(vMCity(2), 1, 30) & Space(30 - Len(Mid(vMCity(2), 1, 30))))
                        pagesize = pagesize + 1
                        Filewrite.WriteLine()
                        Filewrite.WriteLine()

                        pagesize = pagesize + 1

                        For j = 0 To 2
                            vMCode(j) = ""
                            vMName(j) = ""
                            vMAdd1(j) = ""
                            vMAdd2(j) = ""
                            vMAdd3(j) = ""
                            vMCity(j) = ""
                            vMState(j) = ""
                            vMPinCode(j) = ""
                            vMTel(j) = ""
                        Next
                        If i > dt.Rows.Count Then
                            i = dt.Rows.Count
                        Else
                            i = i - 1
                        End If
                    Next
                Else
                    MsgBox("No Record to View", MsgBoxStyle.Information, MyCompanyName)
                    Exit Function
                End If
                Filewrite.Close()
                'If GPRINT = False Then
                OpenTextFile(vOutfile)
                'E() 'lse
                PrintTextFile(vOutfile)
                'End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try

    End Function
    Private Sub Partyletter()
        Dim MNTH, vbilldate As String
        Dim noofdays As Double
        Dim I, J, vhead
        Dim vFromDate, vToDate, SSQL As String
        Dim appcode() As String
        Randomize()
        'If Txt_Orderno.Text = "" Then
        '    MsgBox("Please Fill the Order No!!!")
        '    Exit Sub
        'End If
        Dim vpageNo, vtdueamt As Double
        Dim Loopindex, vPhone, Vdate, vTotAmtDue, vCrAmt, Vrowcout, vPrnAmt, vMonth, vletterno
        Dim monthcnt As Integer
        Dim pno, psize As Integer
        Dim vString, vPrefix, vCompany, vMid, vName, vAdd1, vAdd2, vCity, vState, vpin, vadd3, vslcode
        Dim vSql, mdate, gAdd As String
        Dim dbltotop As Double
        Dim vsplit() As String
        Dim Order As String

        SSQL = ""
        'SSQL = "Select Orderno,Orderdate,Mcode from Party_Order where Orderno = '" & Trim(Txt_Orderno.Text) & "'"
        SSQL = "Select Orderno,Orderdate,Mcode from Party_Order"
        gconnection.getDataSet(SSQL, "Party")
        If gdataset.Tables("Party").Rows.Count > 0 Then
            Order = gdataset.Tables("Party").Rows(0).Item(0)
            vOutfile = Mid("REM" & (Rnd() * 800000), 1, 8)
            VFilePath = apppath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            'vletterno = CMBLETERNO.Text
            pno = 1
            psize = 0

            For I = 0 To gdataset.Tables("Party").Rows.Count - 1
                vSql = "select ISNULL(MID,'') AS MID,ISNULL(COMPANY,'') AS COMPANY,ISNULL(PREFIX,'') AS PREFIX,isnull(mcode,'') as SLCODE,ISNULL                      (MNAME,'') AS SLNAME,ISNULL(PADD1,'') AS ADDRESS1, ISNULL(PADD2,'') AS ADDRESS2,ISNULL(PADD3,'') AS ADDRESS3,ISNULL(PCITY,'')                     AS CITY,ISNULL(PSTATE,'') AS STATE,ISNULL(PPIN,'') AS PIN from MEMBERMASTER where  Mcode ='" & Trim(gdataset.Tables("Party").Rows(I).Item("Mcode")) & "'"
                gconnection.getDataSet(vSql, "MEMBER")
                If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                    vslcode = Trim(gdataset.Tables("MEMBER").Rows(0).Item("SLCODE") & "")
                    vPrefix = Trim(gdataset.Tables("MEMBER").Rows(0).Item("PREFIX") & "")
                    vCompany = Trim(gdataset.Tables("MEMBER").Rows(0).Item("COMPANY") & "")
                    vMid = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MID") & "")
                    vName = Trim(gdataset.Tables("MEMBER").Rows(0).Item("SLNAME") & "")
                    vAdd1 = Trim(gdataset.Tables("MEMBER").Rows(0).Item("ADDRESS1") & "")
                    vAdd2 = Trim(gdataset.Tables("MEMBER").Rows(0).Item("ADDRESS2") & "")
                    vadd3 = Trim(gdataset.Tables("MEMBER").Rows(0).Item("ADDRESS3") & "")
                    vCity = Trim(gdataset.Tables("MEMBER").Rows(0).Item("CITY") & "")
                    vState = Trim(gdataset.Tables("MEMBER").Rows(0).Item("STATE") & "")
                    vpin = Trim(gdataset.Tables("MEMBER").Rows(0).Item("PIN") & "")
                End If
                For J = 0 To 2
                    Filewrite.WriteLine()
                Next
                psize = psize + 2
                gAdd = "CHENNAI - 600008"
                Filewrite.WriteLine(Space(15) & Chr(18) & Chr(14) & gcompanyname & Chr(18))
                Filewrite.WriteLine(Space(18) & Chr(18) & Chr(14) & gAdd & Chr(18))
                ' Filewrite.WriteLine(Space(2) & gCompanyAddress(0) & "," & gCompanyAddress(1))
                'Filewrite.WriteLine(Space(2) & gCompanyAddress(1))
                'Filewrite.WriteLine(Space(2) & gCompanyAddress(2))
                psize = psize + 2
                For J = 0 To 2
                    Filewrite.WriteLine()
                Next
                Filewrite.WriteLine(Space(2) & Format(DateTime.Now, "dd/MM/yyyy"))
                Filewrite.WriteLine()
                Filewrite.WriteLine(Space(2) & "To")
                Filewrite.WriteLine()
                Filewrite.WriteLine(Space(2) & vPrefix & Space(1) & vMid & Space(1) & vName & Space(2) & "(" & vslcode & ")")
                If vCompany <> "" Then
                    Filewrite.WriteLine(Space(2) & vCompany)
                Else
                    Filewrite.WriteLine(Space(2) & vAdd1)
                    vAdd1 = ""
                End If
                If vAdd1 <> "" Then
                    Filewrite.WriteLine(Space(2) & vAdd1)
                ElseIf vAdd2 <> "" Then
                    Filewrite.WriteLine(Space(2) & vAdd2)
                    vAdd2 = ""
                Else
                    Filewrite.WriteLine(Space(2) & vadd3)
                    vadd3 = ""
                End If
                If vAdd2 <> "" Then
                    Filewrite.WriteLine(Space(2) & vAdd2)
                ElseIf vadd3 <> "" Then
                    Filewrite.WriteLine(Space(2) & vadd3)
                    vadd3 = ""
                Else
                    Filewrite.WriteLine(Space(2) & vCity & " - " & Trim(vpin))
                    vCity = ""
                    vpin = ""
                End If
                If vadd3 <> "" Then
                    Filewrite.WriteLine(Space(2) & vadd3)
                ElseIf vCity <> "" Or vpin <> "" Then
                    Filewrite.WriteLine(Space(2) & vCity & " - " & Trim(vpin))
                    vCity = ""
                    vpin = ""
                End If
                If vCity <> "" Or vpin <> "" Then
                    Filewrite.WriteLine(Space(2) & vCity & " - " & Trim(vpin))
                End If
                Vrowcout = 0
                psize = psize + 8
                Filewrite.WriteLine()
                'Filewrite.WriteLine(Space(2) & "Dear " & vPrefix & Space(1) & vName)
                Filewrite.WriteLine(Space(2) & "Dear Sir/Madam")
                Filewrite.WriteLine()
                psize = psize + 3
                SSQL = "SELECT KOTNO,KOTDATE,MCODE,MNAME,BILLAMOUNT FROM KOT_HDR WHERE KOTNO = '" & Trim(Order) & "' AND PAYMENTTYPE = 'CREDIT' AND                DELFLAG <> 'Y'"
                gconnection.getDataSet(SSQL, "LETTER")
                Filewrite.WriteLine(Space(2) & "Ref.: Party Bill No. " & gdataset.Tables("Letter").Rows(0).Item("Kotno") & " Dated " & Format(gdataset.Tables("Letter").Rows(0).Item("Kotdate"), "dd/MM/yyyy"))
                Filewrite.WriteLine("")
                Filewrite.WriteLine(Space(2) & "The above party bill for Rs. " & gdataset.Tables("Letter").Rows(0).Item("billamount") & " is sent herewith for payment.")
                Filewrite.WriteLine()
                Filewrite.WriteLine(Space(2) & "As per the Club Rules, the party bill is to be settled within,")
                Filewrite.WriteLine()
                Filewrite.WriteLine(Space(2) & "THREE DAYS of the party.")
                Filewrite.WriteLine()
                Filewrite.WriteLine()
                Filewrite.WriteLine(Space(2) & "Yours faithfully")
                Filewrite.WriteLine(Space(2) & "for THE PRESIDENCY CLUB")
                Filewrite.WriteLine()
                Filewrite.WriteLine()
                Filewrite.WriteLine()
                Filewrite.WriteLine()
                Filewrite.WriteLine(Space(2) & "EXECUTIVE SECRETARY")
                Filewrite.WriteLine()
                Filewrite.WriteLine(Space(2) & "Encl : Party Bill")
                Filewrite.WriteLine()
                Filewrite.WriteLine(Space(2) & "If payment is already made please ignore this letter")

                'Filewrite.WriteLine(Chr(12))
                'pno = pno + 1
            Next
            'For I = 0 To 5
            '    Filewrite.WriteLine()
            'Next
            Filewrite.Close()
            If GPRINT = False Then
                Call OpenTextFile(vOutfile)
            Else
                Call PrintTextFile(vOutfile)
            End If
        End If
    End Sub
    Private Sub PrintOperation1()
        Dim MNTH, vbilldate As String
        Dim noofdays As Double
        Dim I, J, vhead
        Dim vFromDate, vToDate, SSQL As String
        Dim appcode() As String
        Randomize()
        If Cmb_ReminderType.Text <> "MEMBER" Then
            MsgBox("Contact Admin!!!")
            Exit Sub
        End If
        Dim vpageNo, vtdueamt As Double
        Dim Loopindex, vPhone, Vdate, vTotAmtDue, vCrAmt, Vrowcout, vPrnAmt, vMonth, vletterno
        Dim monthcnt As Integer
        Dim pno, psize As Integer
        Dim vString, vPrefix, vCompany, vMid, vName, vAdd1, vAdd2, vCity, vState, vpin, vadd3, vslcode
        Dim vSql, mdate, gAdd As String
        Dim dbltotop As Double
        Dim vsplit() As String
        vletterno = CMBLETERNO.Text
        If dtpASNODATE.Value > Dtp_CutOffDate.Value Then
            MsgBox("Please Check the Sales Upto Date", vbOKOnly, vbInformation)
            Exit Sub
        End If
        If CHKCATEGORY.CheckedItems.Count = 0 Then
            If TXTMCODEFrom.Text = "" Or TXTMCODETO.Text = "" Then
                MsgBox("Select Atleast any one Member Category")
                Exit Sub
            End If
        End If
        If TXTMCODEFrom.Text <> "" And TXTMCODETO.Text = "" Then
            MsgBox("Member Code To Can't be Blank")
            Exit Sub
        ElseIf TXTMCODEFrom.Text = "" And TXTMCODETO.Text <> "" Then
            MsgBox("Member Code From Can't be Blank")
            Exit Sub
        End If
        'MONTH1 = Month(Dtp_CutOffDate.Value)
        MONTH1 = Month(dtpASNODATE.Value)
        SSQL = ""
        'sqlString = "Select isnull(slcode,'') as mcode,isnull(slname,'') as mname,"
        sqlString = "SELECT isnull(Mcode,'') as MCODE,(isnull(Prefix,'')+' '+isnull(Mname,'')) as MNAME,ISNULL(MEMBERTYPECODE,'') AS MEMBERTYPECODE,ISNULL(CONTADD1,'') AS ADD1,ISNULL(CONTADD2,'') AS ADD2,ISNULL(CONTADD3,'') AS ADD3,ISNULL(CONTCITY,'') AS CITY,ISNULL(CONTPIN,'') AS PIN,"
        Call Opbalance()
        'If Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") = "31-Mar-2009" Then
        '    SSQL = " Select * From Vw_Reminder1 WHERE ISNULL(MEMBERTYPECODE,'') IN ("
        'Else
        '    SSQL = " Select * From Vw_Reminder WHERE ISNULL(MEMBERTYPECODE,'') IN ("
        'End If
        sqlString = sqlString & "  isnull(membertypecode,'') in ("
        'SSQL = " Select * From Vw_Reminder WHERE ISNULL(MEMBERTYPECODE,'') IN ("
        For I = 0 To CHKCATEGORY.CheckedItems.Count - 1
            appcode = Split(CHKCATEGORY.CheckedItems(I), ".")
            'SSQL = SSQL & " '" & appcode(0) & "', "
            sqlString = sqlString & " '" & appcode(0) & "', "
        Next
        'SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
        'SSQL = SSQL & ")"
        sqlString = Mid(sqlString, 1, Len(sqlString) - 2)
        sqlString = sqlString & ") AND CURENTSTATUS = 'LIVE' order by A.slcode "
        If TXTMCODEFrom.Text <> "" And TXTMCODETO.Text <> "" Then
            SSQL = SSQL & " AND MCODE BETWEEN '" & Trim(TXTMCODEFrom.Text) & "' AND '" & Trim(TXTMCODETO.Text) & "' "
        End If
        'SSQL = SSQL & " and ClosingBalance >=  " & Val(Txt_CreditLimit.Text) & "  order by mcode "
        'gconnection.getDataSet(sqlString, "REMINDER")
        Dim Viewer As New REPORTVIEWER
        Dim r As New Reminder1
        Viewer.ssql = sqlString
        If vletterno = 1 Then
            Viewer.Report = r
        ElseIf vletterno = 2 Then

        End If
        Viewer.TableName = "VW_REMINDER"
        Viewer.Show()
        'If gdataset.Tables("REMINDER").Rows.Count > 0 Then
        '    vOutfile = Mid("REM" & (Rnd() * 800000), 1, 8)
        '    VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
        '    Filewrite = File.AppendText(VFilePath)

        '    vletterno = CMBLETERNO.Text
        '    pno = 1
        '    psize = 0

        '    For I = 0 To gdataset.Tables("REMINDER").Rows.Count - 1
        '        'vSql = "select * from accountssubledgermaster where  slcode ='" & Trim(gdataset.Tables("REMINDER").Rows(I).Item("Mcode")) & "' and accode = 'dr1001'"
        '        vSql = "select ISNULL(MID,'') AS MID,ISNULL(COMPANY,'') AS COMPANY,ISNULL(PREFIX,'') AS PREFIX,isnull(mcode,'') as SLCODE,ISNULL(MNAME,'') AS SLNAME,ISNULL(PADD1,'') AS ADDRESS1, ISNULL(PADD2,'') AS ADDRESS2,ISNULL(PADD3,'') AS ADDRESS3,ISNULL(PCITY,'') AS CITY,ISNULL(PSTATE,'') AS STATE,ISNULL(PPIN,'') AS PIN from MEMBERMASTER where  Mcode ='" & Trim(gdataset.Tables("REMINDER").Rows(I).Item("Mcode")) & "'"
        '        gconnection.getDataSet(vSql, "MEMBER")
        '        If gdataset.Tables("MEMBER").Rows.Count > 0 Then
        '            vslcode = Trim(gdataset.Tables("MEMBER").Rows(0).Item("SLCODE") & "")
        '            vPrefix = Trim(gdataset.Tables("MEMBER").Rows(0).Item("PREFIX") & "")
        '            vCompany = Trim(gdataset.Tables("MEMBER").Rows(0).Item("COMPANY") & "")
        '            vMid = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MID") & "")
        '            vName = Trim(gdataset.Tables("MEMBER").Rows(0).Item("SLNAME") & "")
        '            vAdd1 = Trim(gdataset.Tables("MEMBER").Rows(0).Item("ADDRESS1") & "")
        '            vAdd2 = Trim(gdataset.Tables("MEMBER").Rows(0).Item("ADDRESS2") & "")
        '            vadd3 = Trim(gdataset.Tables("MEMBER").Rows(0).Item("ADDRESS3") & "")
        '            vCity = Trim(gdataset.Tables("MEMBER").Rows(0).Item("CITY") & "")
        '            vState = Trim(gdataset.Tables("MEMBER").Rows(0).Item("STATE") & "")
        '            vpin = Trim(gdataset.Tables("MEMBER").Rows(0).Item("PIN") & "")
        '        End If
        '        For J = 0 To 2
        '            Filewrite.WriteLine()
        '        Next
        '        psize = psize + 2
        '        gAdd = "CHENNAI - 600008"
        '        Filewrite.WriteLine(Space(15) & Chr(18) & Chr(14) & gCompanyname & Chr(18))
        '        Filewrite.WriteLine(Space(18) & Chr(18) & Chr(14) & gAdd & Chr(18))
        '        ' Filewrite.WriteLine(Space(2) & gCompanyAddress(0) & "," & gCompanyAddress(1))
        '        'Filewrite.WriteLine(Space(2) & gCompanyAddress(1))
        '        'Filewrite.WriteLine(Space(2) & gCompanyAddress(2))
        '        psize = psize + 2

        '        For J = 0 To 2
        '            Filewrite.WriteLine()
        '        Next
        '        Filewrite.WriteLine(Space(2) & Format(Dtp_CutOffDate.Value, "dd/MM/yyyy"))
        '        Filewrite.WriteLine()
        '        Filewrite.WriteLine(Space(2) & vPrefix & Space(1) & vMid & Space(1) & vName & Space(2) & "(" & vslcode & ")")
        '        If vCompany <> "" Then
        '            Filewrite.WriteLine(Space(2) & vCompany)
        '        Else
        '            Filewrite.WriteLine(Space(2) & vAdd1)
        '            vAdd1 = ""
        '        End If
        '        If vAdd1 <> "" Then
        '            Filewrite.WriteLine(Space(2) & vAdd1)
        '        ElseIf vAdd2 <> "" Then
        '            Filewrite.WriteLine(Space(2) & vAdd2)
        '            vAdd2 = ""
        '        Else
        '            Filewrite.WriteLine(Space(2) & vadd3)
        '            vadd3 = ""
        '        End If
        '        If vAdd2 <> "" Then
        '            Filewrite.WriteLine(Space(2) & vAdd2)
        '        ElseIf vadd3 <> "" Then
        '            Filewrite.WriteLine(Space(2) & vadd3)
        '            vadd3 = ""
        '        Else
        '            Filewrite.WriteLine(Space(2) & vCity & " - " & Trim(vpin))
        '            vCity = ""
        '            vpin = ""
        '        End If
        '        If vadd3 <> "" Then
        '            Filewrite.WriteLine(Space(2) & vadd3)
        '        ElseIf vCity <> "" Or vpin <> "" Then
        '            Filewrite.WriteLine(Space(2) & vCity & " - " & Trim(vpin))
        '            vCity = ""
        '            vpin = ""
        '        End If
        '        If vCity <> "" Or vpin <> "" Then
        '            Filewrite.WriteLine(Space(2) & vCity & " - " & Trim(vpin))
        '        End If
        '        Vrowcout = 0
        '        psize = psize + 8
        '        If vletterno = 1 Then
        '            vhead = "FIRST"
        '        ElseIf vletterno = 2 Then
        '            vhead = "SECOND"
        '        Else
        '            vhead = "THIRD"
        '        End If
        '        Filewrite.WriteLine()
        '        Filewrite.WriteLine()
        '        Filewrite.WriteLine(Space(2) & "Dear " & vPrefix & Space(1) & vName)
        '        psize = psize + 3
        '        SSQL = "select * From terminateletter where doctype='" & vhead & "' order by slno"
        '        gconnection.getDataSet(SSQL, "LETTER")
        '        Dim samt() As String
        '        For Loopindex = 0 To gdataset.Tables("LETTER").Rows.Count - 1
        '            If InStr(gdataset.Tables("LETTER").Rows(Loopindex).Item("MESSAGE"), "(Rs.)") Then
        '                SSQL = gdataset.Tables("LETTER").Rows(Loopindex).Item("MESSAGE")
        '                samt = Split(SSQL, "(Rs.)")
        '                'SSQL = Space(2) & Trim(samt(0)) & " Rs." & Format(gdataset.Tables("REMINDER").Rows(I).Item("CLOSINGBALANCE"), "0.00") & " " & Trim(samt(1))
        '                SSQL = Space(2) & Trim(samt(0)) & " Rs." & Format(gdataset.Tables("REMINDER").Rows(I).Item("Amount"), "0.00") & " " & Trim(samt(1))
        '                Filewrite.WriteLine(SSQL)
        '                psize = psize + 1
        '            Else
        '                Filewrite.WriteLine(Space(2) & gdataset.Tables("LETTER").Rows(Loopindex).Item("MESSAGE"))
        '                psize = psize + 1
        '            End If
        '        Next
        '        Filewrite.WriteLine(Chr(12))
        '        pno = pno + 1
        '    Next
        '    For I = 0 To 5
        '        Filewrite.WriteLine()
        '    Next
        '    Filewrite.Close()
        '    If gPrint = False Then
        '        Call OpenTextFile(vOutfile)
        '    Else
        '        Call PrintTextFile(vOutfile)
        '    End If
        'End If
    End Sub

    Private Sub CHKCATEGORY_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKCATEGORY.SelectedIndexChanged
        Call remi()
    End Sub
    Private Sub remi()
        'Dim i As Long
        'Dim cat As String
        'posting = Nothing
        'catecode = ""
        'vtypedesc = ""
        'Try
        '    Dim remindercode, fromdate, todate, asondate, membertypecode As String
        '    Dim remindercount As Integer
        '    'fromdate = Format(DTPFROM.Value, "dd/MMM/yyyy")
        '    'Todate = Format(DTPFROM.Value, "dd/MMM/yyyy")
        '    asondate = Format(dtpASNODATE.Value, "dd/MMM/yyyy")

        '    If Trim(CMBLETERNO.Text) = 1 Then
        '        lettertype = "Subscription First Reminder Letter For :"
        '        addamt = 0
        '        vhead = "FIRST"
        '    ElseIf Trim(CMBLETERNO.Text) = 2 Then
        '        addamt = 100
        '        vhead = "SECOND"
        '        lettertype = "Subscription second Reminder Letter For :"
        '    ElseIf Trim(CMBLETERNO.Text) = 3 Then
        '        lettertype = "Subscription Third Reminder Letter For :"
        '        addamt = 0
        '        vhead = "THIRD"
        '    End If

        '    For i = 0 To CHKCATEGORY.Items.Count - 1
        '        If CHKCATEGORY.GetItemChecked(i) = True Then
        '            TempString = Split(CHKCATEGORY.Items.Item(i), ".")
        '            If catecode = "" Then
        '                catecode = "'" & TempString(0)
        '                cat = TempString(0)
        '                vtypedesc = TempString(1)
        '            Else
        '                catecode = catecode & "','" & TempString(0)
        '                vtypedesc = TempString(1)
        '            End If
        '        End If
        '    Next i
        '    catecode = catecode & "'"
        '    If ChKALL.Checked = False Then
        '        If Trim(CMBLETERNO.Text) <> "" And cat <> "" And Trim(cboBillingBasis.Text) <> "" Then
        '            sqlString = "SELECT ISNULL(ASONDATE,'') AS ASDATE,isnull(fromdate,'') as fromdate,isnull(todate,'') as todate FROM  reminderhistory "
        '            sqlString = sqlString & " where  remindercount=" & Trim(CMBLETERNO.Text)
        '            sqlString = sqlString & " and membertypecode='" & Trim(cat) & "'"
        '            sqlString = sqlString & " and  remindercode='" & Trim(cboBillingBasis.Text) & "'"
        '            posting = gconnection.GetValues(sqlString)
        '            If posting.Rows.Count > 0 Then
        '                'dtpASNODATE.Value = Format(posting.Rows(0).Item("asdate"), "dd/MM/yyyy")
        '                'DTPFROM.Value = Format(posting.Rows(0).Item("fromdate"), "dd/MM/yyyy")
        '                'DTPTO.Value = Format(posting.Rows(0).Item("todate"), "dd/MM/yyyy")
        '            End If
        '            firstdate = ""
        '            sqlString = "SELECT ISNULL(ASONDATE,'') AS ASDATE,isnull(fromdate,'') as fromdate,isnull(todate,'') as todate FROM  reminderhistory "
        '            sqlString = sqlString & " where  remindercount=1"
        '            sqlString = sqlString & " and membertypecode='" & Trim(cat) & "'"
        '            sqlString = sqlString & " and  remindercode='" & Trim(cboBillingBasis.Text) & "'"
        '            posting = gconnection.GetValues(sqlString)
        '            If posting.Rows.Count > 0 Then
        '                firstdate = Format(posting.Rows(0).Item("asdate"), "dd/MM/yyyy")
        '            End If
        '        End If
        '    Else
        '        firstdate = Format(Now(), "dd/MM/yyyy")
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub
    Private Function details()
        '        Dim sno, i, j, k As Integer
        '        Dim PERIOD, VTYPE As String
        '        Dim TAXAMOUNT As Double
        '        Dim dt As New DataTable
        '        Dim dt1 As New DataTable
        '        Dim ssql As String
        '        Dim lettertype, vhead, samt() As String
        '        Dim totbillamount, totadjamount, totbalamount, totaddamount, addamt
        '        Dim pagebillamount, pageadjamount, pagebalamount, pageaddamount, netbal
        '        Dim pageno, pagesize
        '        Try
        '            If Trim(CMBLETERNO.Text) = 1 Then
        '                lettertype = "Subscription First Reminder Letter For :"
        '                addamt = 0
        '                vhead = "FIRST"
        '            ElseIf Trim(CMBLETERNO.Text) = 2 Then
        '                addamt = 100
        '                vhead = "SECOND"
        '                lettertype = "Subscription second Reminder Letter For :"
        '            ElseIf Trim(CMBLETERNO.Text) = 3 Then
        '                lettertype = "Subscription Third Reminder Letter For :"
        '                addamt = 0
        '                vhead = "THIRD"
        '            End If

        '            'PERIOD = Format(DTPFROM.Value, "dd-MMM-yyyy") & " TO " & Format(DTPTO.Value, "dd-MMM-yyyy")
        '            If ChKALL.Checked = False Then
        '                If Trim(TXTMCODEFrom.Text) <> "" And Trim(TXTMCODETO.Text) <> "" Then
        '                    ssql = "SELECT C.BILLINGBASIS,A.MCODE, A.TYPEDESC,A.MNAME,A.MID,A.ADD1,A.ADD2,A.ADD3,A.CITY,A.STATE,A.COUNTRY,"
        '                    ssql = ssql & " A.PINCODE,A.PHONE1,A.PHONE2,A.CELLNO,A.VOUCHERNO, A.VOUCHERDATE,ISNULL(ISNULL(A.AMOUNT,0)-ISNULL((SUM(C.TAXAMOUNT+C.AMOUNT)),0),0) AS AMOUNT,"
        '                    ssql = ssql & " ISNULL(SUM(B.ADJAMOUNT),0) AS ADJAMOUNT,ISNULL((SUM(C.TAXAMOUNT+C.AMOUNT)),0) AS OPLAMOUNT,"
        '                    ssql = ssql & " ISNULL(A.AMOUNT-(ISNULL(SUM(B.ADJAMOUNT),0) + ISNULL(SUM(C.TAXAMOUNT+C.AMOUNT),0)),0) AS BALAMOUNT "
        '                    ssql = ssql & " FROM VIEWREMINDERBILLAMOUNT A "
        '                    ssql = ssql & " LEFT OUTER JOIN VIEWREMINDERMMATCHING  B ON "
        '                    ssql = ssql & " B.VOUCHERNO=A.VOUCHERNO AND B.AVOUCHERDATE<='" & Format(dtpASNODATE.Value, "dd/MMM/yyyy") & "'"
        '                    ssql = ssql & " LEFT OUTER JOIN  VIEWREMINDEROPTIONAL C ON "

        '                    ssql = ssql & " C.MCODE=A.MCODE AND C.PERIOD='" & Trim(PERIOD) & "' AND C.BILLINGBASIS='" & cboBillingBasis.Text & "'"
        '                    'ssql = ssql & " AND A.MEMBERTYPECODE IN(" & catecode & ") "
        '                    ssql = ssql & " AND C.BILLINGBASIS='" & cboBillingBasis.Text & "' AND ISNULL(C.BILLINGBASIS,'')<>'' " 'AND A.MEMBERTYPECODE IN(" & catecode & ")"
        '                    'ssql = ssql & " AND  A.VOUCHERDATE='" & Format(DTPFROM.Value, "dd/MMM/yyyy") & "' WHERE  A.Mcode BETWEEN '" & TXTMCODEFrom.Text & "' AND  '" & TXTMCODETO.Text & "'"
        '                    ssql = ssql & " GROUP BY C.BILLINGBASIS,A.MCODE,A.TYPEDESC,A.MNAME,A.MID,A.ADD1,A.ADD2,A.ADD3,A.CITY,A.STATE,A.COUNTRY,"
        '                    ssql = ssql & " A.PINCODE, A.PHONE1, A.PHONE2,A.CELLNO, A.VOUCHERNO, A.VOUCHERDATE, A.AMOUNT "
        '                    'ssql = ssql & " HAVING  A.VOUCHERDATE='" & Format(DTPFROM.Value, "dd/MMM/yyyy") & "'  AND ISNULL(A.AMOUNT-(ISNULL(SUM(B.ADJAMOUNT),0) + ISNULL(SUM(C.TAXAMOUNT+C.AMOUNT),0)),0)>0  AND isnull(C.BILLINGBASIS,'')<>'' "
        '                    'ssql = ssql & " HAVING  A.VOUCHERDATE='" & Format(DTPFROM.Value, "dd/MMM/yyyy") & "'  AND ISNULL(A.AMOUNT-(ISNULL(SUM(B.ADJAMOUNT),0) + ISNULL(SUM(C.TAXAMOUNT+C.AMOUNT),0)),0)>0  "
        '                    ssql = ssql & " ORDER BY A.MCODE"
        '                Else
        '                    ssql = "SELECT C.BILLINGBASIS,A.MCODE, A.TYPEDESC,A.MNAME,A.MID,A.ADD1,A.ADD2,A.ADD3,A.CITY,A.STATE,A.COUNTRY,"
        '                    ssql = ssql & " A.PINCODE,A.PHONE1,A.PHONE2,A.CELLNO,A.VOUCHERNO, A.VOUCHERDATE,ISNULL(ISNULL(A.AMOUNT,0)-ISNULL((SUM(C.TAXAMOUNT+C.AMOUNT)),0),0) AS AMOUNT,"
        '                    ssql = ssql & " ISNULL(SUM(B.ADJAMOUNT),0) AS ADJAMOUNT,ISNULL((SUM(C.TAXAMOUNT+C.AMOUNT)),0) AS OPLAMOUNT,"
        '                    ssql = ssql & " ISNULL(A.AMOUNT-(ISNULL(SUM(B.ADJAMOUNT),0) + ISNULL(SUM(C.TAXAMOUNT+C.AMOUNT),0)),0) AS BALAMOUNT "
        '                    ssql = ssql & " FROM VIEWREMINDERBILLAMOUNT A "
        '                    ssql = ssql & " LEFT OUTER JOIN VIEWREMINDERMMATCHING  B ON "
        '                    ssql = ssql & " B.VOUCHERNO=A.VOUCHERNO AND B.AVOUCHERDATE<='" & Format(dtpASNODATE.Value, "dd/MMM/yyyy") & "'"
        '                    ssql = ssql & " LEFT OUTER JOIN  VIEWREMINDEROPTIONAL C ON "

        '                    ssql = ssql & " C.MCODE=A.MCODE AND C.PERIOD='" & Trim(PERIOD) & "' AND C.BILLINGBASIS='" & cboBillingBasis.Text & "'"
        '                    'ssql = ssql & " AND A.MEMBERTYPECODE IN(" & catecode & ") "
        '                    ssql = ssql & " AND C.BILLINGBASIS='" & cboBillingBasis.Text & "' AND ISNULL(C.BILLINGBASIS,'')<>'' " 'AND A.MEMBERTYPECODE IN(" & catecode & ")"
        '                    'ssql = ssql & " AND  A.VOUCHERDATE='" & Format(DTPFROM.Value, "dd/MMM/yyyy") & "' "
        '                    ssql = ssql & " WHERE A.MEMBERTYPECODE IN (" & catecode & ") "
        '                    ssql = ssql & " GROUP BY C.BILLINGBASIS,A.MCODE,A.TYPEDESC,A.MNAME,A.MID,A.ADD1,A.ADD2,A.ADD3,A.CITY,A.STATE,A.COUNTRY,"
        '                    ssql = ssql & " A.PINCODE, A.PHONE1, A.PHONE2, A.CELLNO, A.VOUCHERNO, A.VOUCHERDATE, A.AMOUNT "
        '                    'ssql = ssql & "HAVING A.VOUCHERDATE='" & Format(DTPFROM.Value, "dd/MMM/yyyy") & "' AND ISNULL(A.AMOUNT-(ISNULL(SUM(B.ADJAMOUNT),0) + ISNULL(SUM(C.TAXAMOUNT+C.AMOUNT),0)),0)>0 and isnull(C.BILLINGBASIS,'')<>'' "
        '                    'ssql = ssql & "HAVING A.VOUCHERDATE='" & Format(DTPFROM.Value, "dd/MMM/yyyy") & "' AND ISNULL(A.AMOUNT-(ISNULL(SUM(B.ADJAMOUNT),0) + ISNULL(SUM(C.TAXAMOUNT+C.AMOUNT),0)),0)>0 "
        '                    ssql = ssql & " ORDER BY A.MCODE"
        '                End If
        '            Else
        '                If Trim(TXTMCODEFrom.Text) <> "" And Trim(TXTMCODETO.Text) <> "" Then
        '                    ssql = "SELECT C.BILLINGBASIS,A.MCODE, A.TYPEDESC,A.MNAME,A.MID,A.ADD1,A.ADD2,A.ADD3,A.CITY,A.STATE,A.COUNTRY,"
        '                    ssql = ssql & " A.PINCODE,A.PHONE1,A.PHONE2,A.CELLNO,A.VOUCHERNO, A.VOUCHERDATE,ISNULL(ISNULL(A.AMOUNT,0)-ISNULL((SUM(C.TAXAMOUNT+C.AMOUNT)),0),0) AS AMOUNT,"
        '                    ssql = ssql & " ISNULL(SUM(B.ADJAMOUNT),0) AS ADJAMOUNT,ISNULL((SUM(C.TAXAMOUNT+C.AMOUNT)),0) AS OPLAMOUNT,"
        '                    ssql = ssql & " ISNULL(A.AMOUNT-(ISNULL(SUM(B.ADJAMOUNT),0) + ISNULL(SUM(C.TAXAMOUNT+C.AMOUNT),0)),0) AS BALAMOUNT "
        '                    ssql = ssql & " FROM VIEWREMINDERBILLAMOUNT A "
        '                    ssql = ssql & " LEFT OUTER JOIN VIEWREMINDERMMATCHING  B ON "
        '                    ssql = ssql & " B.VOUCHERNO=A.VOUCHERNO AND B.AVOUCHERDATE<='" & Format(dtpASNODATE.Value, "dd/MMM/yyyy") & "'"
        '                    ssql = ssql & " LEFT OUTER JOIN  VIEWREMINDEROPTIONAL C ON "

        '                    ssql = ssql & " C.MCODE=A.MCODE "
        '                    ssql = ssql & " AND A.MEMBERTYPECODE IN(" & catecode & ") "
        '                    ssql = ssql & " AND ISNULL(C.BILLINGBASIS,'')<>'' AND A.MEMBERTYPECODE IN(" & catecode & ")"
        '                    'ssql = ssql & " AND  A.VOUCHERDATE='" & Format(DTPFROM.Value, "dd/MMM/yyyy") & "' AND  A.Mcode BETWEEN '" & TXTMCODEFrom.Text & "' AND  '" & TXTMCODETO.Text & "'"
        '                    ssql = ssql & " GROUP BY C.BILLINGBASIS,A.MCODE,A.TYPEDESC,A.MNAME,A.MID,A.ADD1,A.ADD2,A.ADD3,A.CITY,A.STATE,A.COUNTRY,"
        '                    ssql = ssql & " A.PINCODE, A.PHONE1, A.PHONE2,A.CELLNO, A.VOUCHERNO, A.VOUCHERDATE, A.AMOUNT "
        '                    'ssql = ssql & "HAVING  A.VOUCHERDATE='" & Format(DTPFROM.Value, "dd/MMM/yyyy") & "'  AND ISNULL(A.AMOUNT-(ISNULL(SUM(B.ADJAMOUNT),0) + ISNULL(SUM(C.TAXAMOUNT+C.AMOUNT),0)),0)>0  AND isnull(C.BILLINGBASIS,'')<>'' "
        '                    'ssql = ssql & "HAVING  A.VOUCHERDATE='" & Format(DTPFROM.Value, "dd/MMM/yyyy") & "'  AND ISNULL(A.AMOUNT-(ISNULL(SUM(B.ADJAMOUNT),0) + ISNULL(SUM(C.TAXAMOUNT+C.AMOUNT),0)),0)>0  "
        '                    ssql = ssql & " ORDER BY A.MCODE"
        '                Else
        '                    ssql = "SELECT C.BILLINGBASIS,A.MCODE, A.TYPEDESC,A.MNAME,A.MID,A.ADD1,A.ADD2,A.ADD3,A.CITY,A.STATE,A.COUNTRY,"
        '                    ssql = ssql & " A.PINCODE,A.PHONE1,A.PHONE2,A.CELLNO,A.VOUCHERNO, A.VOUCHERDATE,ISNULL(ISNULL(A.AMOUNT,0)-ISNULL((SUM(C.TAXAMOUNT+C.AMOUNT)),0),0) AS AMOUNT,"
        '                    ssql = ssql & " ISNULL(SUM(B.ADJAMOUNT),0) AS ADJAMOUNT,ISNULL((SUM(C.TAXAMOUNT+C.AMOUNT)),0) AS OPLAMOUNT,"
        '                    ssql = ssql & " ISNULL(A.AMOUNT-(ISNULL(SUM(B.ADJAMOUNT),0) + ISNULL(SUM(C.TAXAMOUNT+C.AMOUNT),0)),0) AS BALAMOUNT "
        '                    ssql = ssql & " FROM VIEWREMINDERBILLAMOUNT A "
        '                    ssql = ssql & " LEFT OUTER JOIN VIEWREMINDERMMATCHING  B ON "
        '                    ssql = ssql & " B.VOUCHERNO=A.VOUCHERNO AND B.AVOUCHERDATE<='" & Format(dtpASNODATE.Value, "dd/MMM/yyyy") & "'"
        '                    ssql = ssql & " LEFT OUTER JOIN  VIEWREMINDEROPTIONAL C ON "

        '                    ssql = ssql & " C.MCODE=A.MCODE "
        '                    ssql = ssql & " AND A.MEMBERTYPECODE IN(" & catecode & ")"
        '                    ssql = ssql & " AND ISNULL(C.BILLINGBASIS,'')<>'' AND A.MEMBERTYPECODE IN(" & catecode & ")"
        '                    'ssql = ssql & " AND  A.VOUCHERDATE='" & Format(DTPFROM.Value, "dd/MMM/yyyy") & "' "
        '                    ssql = ssql & " GROUP BY C.BILLINGBASIS,A.MCODE,A.TYPEDESC,A.MNAME,A.MID,A.ADD1,A.ADD2,A.ADD3,A.CITY,A.STATE,A.COUNTRY,"
        '                    ssql = ssql & " A.PINCODE, A.PHONE1, A.PHONE2, A.CELLNO, A.VOUCHERNO, A.VOUCHERDATE, A.AMOUNT "
        '                    'ssql = ssql & "HAVING  A.VOUCHERDATE='" & Format(DTPFROM.Value, "dd/MMM/yyyy") & "'  AND ISNULL(A.AMOUNT-(ISNULL(SUM(B.ADJAMOUNT),0) + ISNULL(SUM(C.TAXAMOUNT+C.AMOUNT),0)),0)>0 and isnull(C.BILLINGBASIS,'')<>'' "
        '                    'ssql = ssql & "HAVING  A.VOUCHERDATE='" & Format(DTPFROM.Value, "dd/MMM/yyyy") & "'  AND ISNULL(A.AMOUNT-(ISNULL(SUM(B.ADJAMOUNT),0) + ISNULL(SUM(C.TAXAMOUNT+C.AMOUNT),0)),0)>0 "
        '                    ssql = ssql & " ORDER BY A.MCODE"
        '                End If
        '            End If
        '            dt = Nothing
        '            dt = gconnection.GetValues(ssql)
        '            pageno = 1
        '            Randomize()
        '            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
        '            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
        '            Filewrite = File.AppendText(VFilePath)
        '            Filewrite.WriteLine()
        '            pagesize = 5
        '            If dt.Rows.Count > 0 Then
        '                sno = 1
        '                For i = 0 To dt.Rows.Count - 1
        '                    If Trim(CMBLETERNO.Text) = 1 Then
        '                        Filewrite.WriteLine(Chr(18) & "From :")
        '                        Filewrite.WriteLine(Chr(27) + "E" & "THE SECRETARY" & Chr(27) + "F")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(0), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(0), 1, 30))) & Space(25) & "Date      :" & Format(dtpASNODATE.Value, "dd/MM/yyyy") & Chr(27) + "F")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(1), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(1), 1, 30))) & Space(25) & "Member No :" & dt.Rows(i).Item("mcode") & Chr(27) + "F")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(2), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(2), 1, 30))) & Space(25) & "Category  :" & dt.Rows(i).Item("TYPEDESC") & Chr(27) + "F")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(3), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(3), 1, 30))) & Chr(27) + "F")
        '                        Filewrite.WriteLine("")
        '                        Filewrite.WriteLine("")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Space(30) & "FIRST REMINDER" & Chr(27) + "F")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Space(30) & "--------------" & Chr(27) + "F")
        '                        For j = 0 To 3
        '                            Filewrite.WriteLine("")
        '                        Next
        '                        Filewrite.WriteLine("TO,")
        '                        Filewrite.WriteLine(dt.Rows(i).Item("MID") & Space(1) & dt.Rows(i).Item("MNAME"))
        '                        Filewrite.WriteLine(dt.Rows(i).Item("add1"))
        '                        Filewrite.WriteLine(dt.Rows(i).Item("add2"))
        '                        Filewrite.WriteLine(dt.Rows(i).Item("add3"))
        '                        Filewrite.WriteLine(dt.Rows(i).Item("city") & " " & dt.Rows(i).Item("pincode"))
        '                        Filewrite.WriteLine(dt.Rows(i).Item("state") & Space(1) & dt.Rows(i).Item("COUNTRY"))
        '                        Filewrite.WriteLine("Tel.No :" & dt.Rows(i).Item("phone1") & Space(1) & dt.Rows(i).Item("phone2"))
        '                        For j = 0 To 5
        '                            Filewrite.WriteLine("")
        '                        Next
        '                        ssql = "select * From terminateletter where doctype='" & vhead & "' order by slno"
        '                        dt1 = Nothing
        '                        dt1 = gconnection.GetValues(ssql)
        '                        If dt1.Rows.Count > 0 Then
        '                            For j = 0 To dt1.Rows.Count - 1
        '                                If j + 1 = dt1.Rows.Count Then
        '                                    'Filewrite.WriteLine(dt1.Rows(j).Item("message") & Space(1) & Format(DTPFROM.Value, "dd/MM/yyyy") & " To " & Format(DTPTO.Value, "dd/MM/yyyy"))
        '                                Else
        '                                    Filewrite.WriteLine(dt1.Rows(j).Item("message"))
        '                                End If
        '                            Next
        '                            Filewrite.WriteLine("as per Bill No :" & Chr(27) & "E" & Trim(dt.Rows(i).Item("voucherno")) & " Bill Amount Rs." & Format(dt.Rows(i).Item("amount"), "0.00" & "  Paid Amount "))
        '                            'Filewrite.WriteLine("Rs." & Format(dt.Rows(i).Item("adjamount"), "0.00") & " Due Amount Rs." & Format(dt.Rows(i).Item("balamount"), "0.00") & " is due from :" & Format(DTPFROM.Value, "dd/MM/yyyy") & Chr(27) & "F")
        '                            For j = 0 To 5
        '                                Filewrite.WriteLine("")
        '                            Next
        '                            Filewrite.WriteLine(Space(40) & "For The Presidency Club")
        '                            For j = 0 To 5
        '                                Filewrite.WriteLine("")
        '                            Next
        '                            Filewrite.WriteLine(Space(40) & "      SECRETARY")
        '                            Filewrite.WriteLine("")
        '                            Filewrite.WriteLine(StrDup(80, "-"))
        '                            Filewrite.WriteLine(Chr(27) + "E" & "If you have already paid please ignore this reminder." & Chr(27) + "F")
        '                            Filewrite.WriteLine(Chr(12))
        '                        End If
        '9:                  End If

        '                    If Trim(CMBLETERNO.Text) = 2 Then
        '                        Filewrite.WriteLine(Chr(18) & "From :")
        '                        Filewrite.WriteLine("THE SECRETARY")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(0), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(0), 1, 30))) & Space(25) & "Date      :" & Format(dtpASNODATE.Value, "dd/MM/yyyy") & Chr(27) + "F")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(1), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(1), 1, 30))) & Space(25) & "Member No :" & dt.Rows(i).Item("mcode") & Chr(27) + "F")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(2), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(2), 1, 30))) & Space(25) & "Category  :" & dt.Rows(i).Item("TYPEDESC") & Chr(27) + "F")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(3), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(3), 1, 30))) & Chr(27) + "F")
        '                        Filewrite.WriteLine("")
        '                        Filewrite.WriteLine("")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Space(30) & "SECOND REMINDER" & Chr(27) + "F")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Space(30) & "--------------" & Chr(27) + "F")
        '                        If Trim(cboBillingBasis.Text) = "QUARTERLY" Then
        '                            VTYPE = "QUARTER"
        '                        Else
        '                            VTYPE = "YEAR"
        '                        End If
        '                        Trim(cboBillingBasis.Text)
        '                        'Filewrite.WriteLine(Chr(27) + "E" & Space(15) & " Sub: Payment of Subscription for the " & Trim(VTYPE) & " ending " & Mid(Format(DTPTO.Value, "dd/MMM/yyyy"), 4, 3) & "-" & Year(DTPTO.Value) & Chr(27) + "F")
        '                        'Filewrite.WriteLine(Chr(27) + "E" & Space(15) & " Re.: Bill No. : " & dt.Rows(i).Item("voucherno") & " dated " & Format(DTPFROM.Value, "dd/MM/yyyy") & Chr(27) + "F")
        '                        For j = 0 To 3
        '                            Filewrite.WriteLine("")
        '                        Next
        '                        Filewrite.WriteLine("TO,")
        '                        Filewrite.WriteLine(dt.Rows(i).Item("MID") & Space(1) & dt.Rows(i).Item("MNAME"))
        '                        Filewrite.WriteLine(dt.Rows(i).Item("add1"))
        '                        Filewrite.WriteLine(dt.Rows(i).Item("add2"))
        '                        Filewrite.WriteLine(dt.Rows(i).Item("add3"))
        '                        Filewrite.WriteLine(dt.Rows(i).Item("city") & " " & dt.Rows(i).Item("pincode"))
        '                        Filewrite.WriteLine(dt.Rows(i).Item("state") & Space(1) & dt.Rows(i).Item("COUNTRY"))
        '                        Filewrite.WriteLine("Tel.No :" & dt.Rows(i).Item("phone1") & Space(1) & dt.Rows(i).Item("phone2"))
        '                        For j = 0 To 5
        '                            Filewrite.WriteLine("")
        '                        Next
        '                        ssql = "select * From terminateletter where doctype='" & vhead & "' order by slno"
        '                        dt1 = Nothing
        '                        dt1 = gconnection.GetValues(ssql)
        '                        If dt1.Rows.Count > 0 Then
        '                            ssql = "select asondate from reminderhistory where  "
        '                            For j = 0 To dt1.Rows.Count - 1
        '                                If InStr(CStr(dt1.Rows(j).Item("message")), "(DATE)") Then
        '                                    samt = Split(CStr(dt1.Rows(j).Item("message")), "(DATE)")
        '                                    ssql = Trim(samt(0)) & " " & Trim(firstdate) & " " & Trim(samt(1))
        '                                    Filewrite.WriteLine(ssql)
        '                                Else
        '                                    Filewrite.WriteLine(dt1.Rows(j).Item("message"))
        '                                End If
        '                            Next
        '                        End If
        '                        Filewrite.WriteLine(StrDup(80, "-"))
        '                        'Filewrite.WriteLine(Chr(27) + "E" & "Bill No:" & Trim(dt.Rows(i).Item("voucherno")) & Space(5) & "Bill Period :" & Trim(Format(DTPFROM.Value, "dd/MM/yyyy")) & Space(2) & "To" & Space(2) & Trim(Format(DTPTO.Value, "dd/MM/yyyy")) & Chr(27) + "F")
        '                        Filewrite.WriteLine(Space(10) & "................................................................")
        '                        'PERIOD = Format(DTPFROM.Value, "dd-MMM-yyyy") & " TO " & Format(DTPTO.Value, "dd-MMM-yyyy")
        '                        If Trim(CMBLETERNO.Text) = 2 And Trim(cboBillingBasis.Text) = "YEARLY" Then
        '                            ssql = " SELECT a.MCODE,a.SUBSCODE,ISNULL(b.SUBSDESC,'') AS DESC1,ISNULL(a.AMOUNT,0) AS AMOUNT ,ISNULL(a.TAXAMOUNT,0) AS TAXAMOUNT "
        '                            ssql = ssql & " FROM SUBSPOSTING a, SUBSCRIPTIONMAST B WHERE A.PERIOD='" & Trim(PERIOD) & "' AND A.POSTINGCODE='" & cboBillingBasis.Text & "' AND B.SUBSDESC not like '%OPTIONAL%' AND A.Mcode='" & dt.Rows(i).Item("mcode") & "' AND A.SUBSCODE=B.SUBSCODE ORDER BY A.MCODE"
        '                        Else
        '                            ssql = " SELECT A.MCODE,A.SUBSCODE,ISNULL(B.SUBSDESC,'') AS DESC1,ISNULL(A.AMOUNT,0) AS AMOUNT ,ISNULL(A.TAXAMOUNT,0) AS TAXAMOUNT "
        '                            ssql = ssql & " FROM SUBSPOSTING  A,SUBSCRIPTIONMAST B WHERE A.PERIOD='" & Trim(PERIOD) & "' AND A.POSTINGCODE='" & cboBillingBasis.Text & "' AND B.SUBSDESC not like '%OPTIONAL%' AND A.Mcode='" & dt.Rows(i).Item("mcode") & "' AND A.SUBSCODE=B.SUBSCODE ORDER BY A.MCODE"
        '                        End If
        '                        dt1 = Nothing
        '                        dt1 = gconnection.GetValues(ssql)
        '                        netbal = 0
        '                        TAXAMOUNT = 0
        '                        If dt1.Rows.Count > 0 Then
        '                            For j = 0 To dt1.Rows.Count - 1
        '                                Filewrite.WriteLine(Space(10) & Mid(Trim(dt1.Rows(j).Item("desc1")), 1, 30) & Space(30 - Len(Mid(Trim(dt1.Rows(j).Item("desc1")), 1, 30))) & Space(4) & Space(8 - Len(Format(dt1.Rows(j).Item("amount"), "0.00"))) & Format(dt1.Rows(j).Item("amount"), "0.00"))
        '                                netbal = netbal + Val(dt1.Rows(j).Item("amount"))
        '                                TAXAMOUNT = TAXAMOUNT + Val(dt1.Rows(j).Item("TAXamount"))
        '                            Next
        '                        End If
        '                        Filewrite.WriteLine(Space(10) & Mid(Trim("SERVICE TAX"), 1, 30) & Space(30 - Len(Mid(Trim("SERVICE TAX"), 1, 30))) & Space(4) & Space(8 - Len(Mid(Format(TAXAMOUNT, "0.00"), 1, 8))) & Mid(Format(TAXAMOUNT, "0.00"), 1, 8))
        '                        Filewrite.WriteLine(Space(10) & Mid(Trim("ADMINISTRATIVE CHARGES"), 1, 30) & Space(30 - Len(Mid(Trim("ADMINISTRATIVE CHARGES"), 1, 30))) & Space(4) & Space(8 - Len(Mid(Format(addamt, "0.00"), 1, 8))) & Mid(Format(addamt, "0.00"), 1, 8))
        '                        netbal = netbal + addamt + TAXAMOUNT
        '                        Filewrite.WriteLine(Space(40) & "-----------------")
        '                        Filewrite.WriteLine(Space(10) & "Total" & Space(29) & Space(8 - Len(Mid(Format(netbal, "0.00"), 1, 8))) & Mid(Format(netbal, "0.00"), 1, 8))
        '                        Filewrite.WriteLine(Space(40) & "-----------------")
        '                        'netbal = netbal + addamt
        '                        Filewrite.WriteLine(Space(10) & "................................................................")
        '                        Filewrite.WriteLine(StrDup(80, "-") & Chr(12))
        '                    End If
        '                    If Trim(CMBLETERNO.Text) = 3 Then
        '                        'THIRD letter
        '                        Filewrite.WriteLine(Chr(18) & "From :")
        '                        Filewrite.WriteLine("The SECRETARY")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(0), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(0), 1, 30))) & Space(25) & "Date      :" & Format(dtpASNODATE.Value, "dd/MM/yyyy") & Chr(27) + "F")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(1), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(1), 1, 30))) & Space(25) & "Member No :" & dt.Rows(i).Item("mcode") & Chr(27) + "F")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(2), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(2), 1, 30))) & Space(25) & "Category  :" & dt.Rows(i).Item("TYPEDESC") & Chr(27) + "F")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(3), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(3), 1, 30))) & Chr(27) + "F")
        '                        Filewrite.WriteLine("")
        '                        Filewrite.WriteLine("")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Space(30) & "POSTING LETTER" & Chr(27) + "F")
        '                        Filewrite.WriteLine(Chr(27) + "E" & Space(30) & "--------------" & Chr(27) + "F")
        '                        For j = 0 To 3
        '                            Filewrite.WriteLine("")
        '                        Next
        '                        Filewrite.WriteLine("TO,")
        '                        Filewrite.WriteLine(dt.Rows(i).Item("MID") & Space(1) & dt.Rows(i).Item("MNAME"))
        '                        Filewrite.WriteLine(dt.Rows(i).Item("add1"))
        '                        Filewrite.WriteLine(dt.Rows(i).Item("add2"))
        '                        Filewrite.WriteLine(dt.Rows(i).Item("add3"))
        '                        Filewrite.WriteLine(dt.Rows(i).Item("city") & " " & dt.Rows(i).Item("pincode"))
        '                        Filewrite.WriteLine(dt.Rows(i).Item("state") & Space(1) & dt.Rows(i).Item("COUNTRY"))
        '                        Filewrite.WriteLine("Tel.No :" & dt.Rows(i).Item("phone1") & Space(1) & dt.Rows(i).Item("phone2"))
        '                        For j = 0 To 5
        '                            Filewrite.WriteLine("")
        '                        Next
        '                        ssql = "select * From terminateletter where doctype='" & vhead & "' order by slno"
        '                        dt1 = Nothing
        '                        dt1 = gconnection.GetValues(ssql)
        '                        If dt1.Rows.Count > 0 Then
        '                            For j = 0 To dt1.Rows.Count - 1
        '                                If InStr(CStr(dt1.Rows(j).Item("message")), "(DATE)") Then
        '                                    samt = Split(CStr(dt1.Rows(j).Item("message")), "(DATE)")
        '                                    ssql = Trim(samt(0)) & " " & Trim(dtpASNODATE.Value) & " " & Trim(samt(1))
        '                                    Filewrite.WriteLine(ssql)
        '                                Else
        '                                    Filewrite.WriteLine(dt1.Rows(j).Item("message"))
        '                                End If
        '                            Next
        '                        End If
        '                        Filewrite.WriteLine(StrDup(80, "-") & Chr(12))
        '                    End If
        '                Next i
        '            End If
        '            Filewrite.Close()
        '        Catch ex As Exception
        '            MessageBox.Show(ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '        End Try
        '        If PRINTREP = False Then
        '            OpenTextFile(vOutfile)
        '        Else
        '            PrintTextFile(vOutfile)
        '        End If
    End Function

    Private Function SUMMARY()
        Try
            Dim pageno, pagesize, sno, k, i, j
            Dim ssql, appcode() As String
            Dim pagebillamount, pageadjamount, pagebalamount, pageaddamount As Double
            Dim totbillamount, totadjamount, totbalamount, totaddamount As Double
            Dim Interest As Double
            Dim str, T As String

            'If Txt_Interest.Text = "" Then
            '    Txt_Interest.Text = 0
            '    'MsgBox("Please Enter the Interest Amount", vbOKOnly, vbInformation)
            '    'Exit Function
            'End If
            If dtpASNODATE.Value > Dtp_CutOffDate.Value Then
                MsgBox("Please Check the Sales Upto Date", vbOKOnly, vbInformation)
                Exit Function
            End If
            If CHKCATEGORY.CheckedItems.Count = 0 Then
                If TXTMCODEFrom.Text = "" Or TXTMCODETO.Text = "" Then
                    MsgBox("Select Atleast any one Member Category")

                    Exit Try

                End If
            End If
            If TXTMCODEFrom.Text <> "" And TXTMCODETO.Text = "" Then
                MsgBox("Member Code To Can't be Blank")
                Exit Try
            ElseIf TXTMCODEFrom.Text = "" And TXTMCODETO.Text <> "" Then
                MsgBox("Member Code From Can't be Blank")
                Exit Try
            End If
            'MONTH1 = Month(Dtp_CutOffDate.Value)
            MONTH1 = Month(dtpASNODATE.Value)
            ssql = ""
            'sqlString = "Select isnull(slcode,'') as mcode,isnull(slname,'') as mname,"
            sqlString = "SELECT isnull(Mcode,'') as MCODE,isnull(Mname,'') as MNAME,ISNULL(MEMBERTYPECODE,'') AS MEMBERTYPECODE,ISNULL(CONTADD1,'') AS ADD1,ISNULL(CONTADD2,'') AS ADD2,ISNULL(CONTADD3,'') AS ADD3,ISNULL(CONTCITY,'') AS CITY,ISNULL(CONTPIN,'') AS PIN,"
            Call Opbalance()

            'If Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") = "31-Mar-2009" Then
            '    ssql = " Select * From Vw_Reminder1 WHERE ISNULL(MEMBERTYPECODE,'') IN ("
            'Else
            '    ssql = " Select * From Vw_Reminder WHERE ISNULL(MEMBERTYPECODE,'') IN ("
            'End If
            sqlString = sqlString & "  isnull(membertypecode,'') in ("
            For i = 0 To CHKCATEGORY.CheckedItems.Count - 1
                appcode = Split(CHKCATEGORY.CheckedItems(i), ".")
                ssql = ssql & " '" & appcode(0) & "', "
                sqlString = sqlString & " '" & appcode(0) & "', "
            Next
            ssql = Mid(ssql, 1, Len(ssql) - 2)
            ssql = ssql & ")"
            sqlString = Mid(sqlString, 1, Len(sqlString) - 2)
            sqlString = sqlString & ") AND CURENTSTATUS = 'LIVE' order by A.slcode"
            If TXTMCODEFrom.Text <> "" And TXTMCODETO.Text <> "" Then
                ssql = ssql & " AND MCODE BETWEEN '" & Trim(TXTMCODEFrom.Text) & "' AND '" & Trim(TXTMCODETO.Text) & "' "
            End If
            'ssql = ssql & " and ClosingBalance >=  " & Val(Txt_CreditLimit.Text) & "  order by mcode "
            'gconnection.getDataSet(ssql, "REMINDER")
            'gconnection.getDataSet(sqlString, "REMINDER")

            Dim Viewer As New REPORTVIEWER
            Dim r As New Remainder1Summary
            Viewer.ssql = sqlString
            Viewer.Report = r
            Viewer.TableName = "VW_REMINDER"
            Viewer.Show()


            'pageno = 1 : pagesize = 1
            'If gdataset.Tables("REMINDER").Rows.Count > 0 Then
            '    vOutfile = Mid("REM" & (Rnd() * 800000), 1, 8)
            '    VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            '    Filewrite = File.AppendText(VFilePath)

            '    CompanyAddress = "ETHIRAJ SALAI, EGMORE, MADRAS"
            '    Filewrite.WriteLine(Chr(27) & "@")
            '    Filewrite.WriteLine(Chr(27) & "A" & Chr(11))
            '    Filewrite.WriteLine(StrDup(80, "*"))
            '    Filewrite.WriteLine(Chr(27) & "E")
            '    Filewrite.WriteLine("{0,-80}", gCompanyname)
            '    Filewrite.Write(Chr(27) & "F")
            '    Filewrite.WriteLine("{0,-80}", CompanyAddress)
            '    'Filewrite.WriteLine("{0,-80}", StrDup(Len(CompanyAddress), "_"))
            '    Filewrite.Write(Chr(27) & "E")
            '    Filewrite.WriteLine("{0,-80}", "Report: Reminder Letter Summary")
            '    Filewrite.WriteLine(Chr(27) & "F")
            '    str = "{0,-20}{1," & (80 - 40) & "}"
            '    Filewrite.WriteLine(str, "Printed On: " & Date.Now, "Page Number:" & pageno)
            '    Filewrite.WriteLine(StrDup(80, "*"))

            '    Filewrite.WriteLine("Reminder Date: " & Format(dtpASNODATE.Value, "dd/MM/yyyy") & Space(58)) '& "Page No:" & Trim(CStr(pageno)))
            '    Filewrite.WriteLine(StrDup(80, "-"))
            '    'Filewrite.WriteLine(Space(1) & " Sno  Mbr No.  Name                        Bill No            Date         Amt.") 'Amt     AdjAmt     addamt    BalAmt")
            '    Filewrite.WriteLine(Space(1) & " Sno  Mbr No.  Name                                                 Amt.") 'Amt     AdjAmt     addamt    BalAmt")
            '    Filewrite.WriteLine(StrDup(80, "-"))
            '    pagesize = pagesize + 5
            '    sno = 1

            '    For i = 0 To gdataset.Tables("REMINDER").Rows.Count - 1
            '        If pagesize >= 60 Then
            '            pageno = pageno + 1
            '            Filewrite.WriteLine(StrDup(80, "-"))

            '            CompanyAddress = "8, ADYAR CLUB GATE ROAD, MADRAS, 600 028"
            '            Filewrite.WriteLine(Chr(27) & "@")
            '            Filewrite.WriteLine(Chr(27) & "A" & Chr(11))
            '            Filewrite.WriteLine(StrDup(80, "*"))
            '            Filewrite.WriteLine(Chr(27) & "E")
            '            Filewrite.WriteLine("{0,-80}", gCompanyname)
            '            Filewrite.Write(Chr(27) & "F")
            '            Filewrite.WriteLine("{0,-80}", CompanyAddress)
            '            'Filewrite.WriteLine("{0,-80}", StrDup(Len(CompanyAddress), "_"))
            '            Filewrite.Write(Chr(27) & "E")
            '            Filewrite.WriteLine("{0,-80}", "Report: Reminder Letter Summary")
            '            Filewrite.WriteLine(Chr(27) & "F")
            '            str = "{0,-20}{1," & (80 - 40) & "}"
            '            Filewrite.WriteLine(str, "Printed On: " & Date.Now, "Page Number:" & pageno)
            '            Filewrite.WriteLine(StrDup(80, "*"))

            '            ssql = Space(10) & "              " & Space(47) & Space(10 - Len(Mid(Format(Val(totbillamount), "0.00"), 1, 10))) & Mid(Format(Val(totbillamount), "0.00"), 1, 10)
            '            ssql = ssql & Space(1) & Space(10 - Len(Mid(Format(Val(pageadjamount), "0.00"), 1, 10))) & Mid(Format(Val(pageadjamount), "0.00"), 1, 10)
            '            ssql = ssql & Space(1) & Space(10 - Len(Mid(Format(Val(pageaddamount), "0.00"), 1, 10))) & Mid(Format(Val(pageaddamount), "0.00"), 1, 10)
            '            ssql = ssql & Space(1) & Space(10 - Len(Mid(Format(Val(pagebalamount), "0.00"), 1, 10))) & Mid(Format(Val(pagebalamount), "0.00"), 1, 10)
            '            Filewrite.WriteLine(ssql)
            '            Filewrite.WriteLine(StrDup(80, "-") & Chr(12))
            '            pagebillamount = 0
            '            pageadjamount = 0
            '            pagebalamount = 0
            '            pageaddamount = 0
            '            Filewrite.WriteLine(Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
            '            pagesize = 1
            '            'Filewrite.WriteLine(Chr(27) + "E" & Trim(lettertype) & Trim(vtypedesc) & Chr(27) + "F")
            '            If Len(vtypedesc) <= 74 Then
            '                Filewrite.WriteLine(Chr(27) + "E" & Trim(lettertype) & Trim(vtypedesc) & Chr(27) + "F")
            '                pagesize = pagesize + 1
            '            Else
            '                Filewrite.Write(Chr(27) + "E" & Trim(lettertype))
            '                j = 0
            '                For k = 1 To Len(Trim(vtypedesc))
            '                    If j = 0 Then
            '                        Filewrite.WriteLine(Mid(Trim(vtypedesc), k, 74))
            '                        pagesize = pagesize + 1
            '                        k = k + 73
            '                    Else
            '                        Filewrite.WriteLine(Mid(Trim(vtypedesc), k, 115))
            '                        pagesize = pagesize + 1
            '                        k = k + 114
            '                    End If
            '                    j = j + 1
            '                Next
            '            End If
            '            'Filewrite.WriteLine("Period From " & Format(DTPFROM.Value, "dd/MM/yyyy") & " To " & Format(DTPTO.Value, "dd/MM/yyyy"))
            '            Filewrite.WriteLine("Reminder Date: " & Format(dtpASNODATE.Value, "dd/MM/yyyy") & Space(58) & "Page No:" & Trim(CStr(pageno)))
            '            Filewrite.WriteLine(StrDup(80, "-"))
            '            Filewrite.WriteLine(Space(1) & " Sno  Mbr No.  Name                                                 Amt.") 'Amt     AdjAmt     addamt    BalAmt")
            '            Filewrite.WriteLine(StrDup(80, "-"))
            '            pagesize = pagesize + 5
            '        End If
            '        'Interest = Val(gdataset.Tables("REMINDER").Rows(i).Item("CLOSINGBALANCE"))
            '        Interest = Val(gdataset.Tables("REMINDER").Rows(i).Item("Amount"))
            '        Interest = (Interest * Val(Txt_Interest.Text)) / 100
            '        ssql = Space(1) & Mid(sno, 1, 4) & Space(4 - Len(Mid(sno, 1, 4))) & Space(1) & Mid(gdataset.Tables("REMINDER").Rows(i).Item("mcode"), 1, 7) & Space(7 - Len(Mid(gdataset.Tables("REMINDER").Rows(i).Item("mcode"), 1, 7))) & Mid(gdataset.Tables("REMINDER").Rows(i).Item("mname"), 1, 53) & Space(1) & Space(53 - Len(Mid(gdataset.Tables("REMINDER").Rows(i).Item("mname"), 1, 53)))
            '        'ssql = ssql & Space(1) & Space(10 - Len(Mid(Format(Val(gdataset.Tables("REMINDER").Rows(i).Item("CLOSINGBALANCE")), "0.00"), 1, 10))) & Mid(Format(Val(gdataset.Tables("REMINDER").Rows(i).Item("CLOSINGBALANCE")), "0.00"), 1, 10)
            '        ssql = ssql & Space(1) & Space(10 - Len(Mid(Format(Val(gdataset.Tables("REMINDER").Rows(i).Item("Amount")), "0.00"), 1, 10))) & Mid(Format(Val(gdataset.Tables("REMINDER").Rows(i).Item("Amount")), "0.00"), 1, 10)
            '        'ssql = ssql & Space(1) & Space(10 - Len(Mid(Format(Val(addamt), "0.00"), 1, 10))) & Mid(Format(Val(addamt), "0.00"), 1, 10)
            '        'ssql = ssql & Space(1) & Space(10 - Len(Mid(Format(Val(dt.Rows(i).Item("balamount") + addamt), "0.00"), 1, 10))) & Mid(Format(Val(dt.Rows(i).Item("balamount") + addamt), "0.00"), 1, 10)
            '        Filewrite.WriteLine(ssql)
            '        pagesize = pagesize + 1
            '        'pagebillamount = pagebillamount + Val(gdataset.Tables("REMINDER").Rows(i).Item("closingbalance"))
            '        pagebillamount = pagebillamount + Val(gdataset.Tables("REMINDER").Rows(i).Item("Amount"))
            '        'pageadjamount = pageadjamount + Val(dt.Rows(i).Item("adjamount"))
            '        'pagebalamount = pagebalamount + Val(dt.Rows(i).Item("balamount")) + addamt
            '        'pageaddamount = pageaddamount + addamt
            '        ''totaddamount = pageaddamount + addamt
            '        'totbillamount = totbillamount + Val(dt.Rows(i).Item("amount"))
            '        'totadjamount = totadjamount + Val(dt.Rows(i).Item("adjamount"))
            '        'totbalamount = totbalamount + Val(dt.Rows(i).Item("balamount")) + addamt
            '        'totaddamount = totaddamount + addamt
            '        sno = sno + 1
            '    Next
            '    sno = sno - 1
            '    If pagesize <= 60 Then
            '        Filewrite.WriteLine(StrDup(80, "-"))
            '        ssql = Space(10) & "              " & Space(42) & Space(10 - Len(Mid(Format(Val(pagebillamount), "0.00"), 1, 10))) & Mid(Format(Val(pagebillamount), "0.00"), 1, 10)
            '        'ssql = ssql & Space(1) & Space(10 - Len(Mid(Format(Val(pageadjamount), "0.00"), 1, 10))) & Mid(Format(Val(pageadjamount), "0.00"), 1, 10)
            '        'ssql = ssql & Space(1) & Space(10 - Len(Mid(Format(Val(pageaddamount), "0.00"), 1, 10))) & Mid(Format(Val(pageaddamount), "0.00"), 1, 10)
            '        'ssql = ssql & Space(1) & Space(10 - Len(Mid(Format(Val(pagebalamount), "0.00"), 1, 10))) & Mid(Format(Val(pagebalamount), "0.00"), 1, 10)
            '        Filewrite.WriteLine(ssql)
            '        Filewrite.WriteLine(StrDup(80, "-"))
            '        pagebillamount = 0
            '        pageadjamount = 0
            '        pagebalamount = 0
            '    End If
            '    ssql = "No.of(Members) =  " & Mid(Trim(CStr(sno)), 1, 5) & Space(5 - Len(Mid(Trim(CStr(sno)), 1, 5))) ' & Space(48) & Space(10 - Len(Mid(Format(Val(totbillamount), "0.00"), 1, 10))) & Mid(Format(Val(totbillamount), "0.00"), 1, 10)
            '    'ssql = ssql & Space(1) & Space(10 - Len(Mid(Format(Val(totadjamount), "0.00"), 1, 10))) & Mid(Format(Val(totadjamount), "0.00"), 1, 10)
            '    'ssql = ssql & Space(1) & Space(10 - Len(Mid(Format(Val(totaddamount), "0.00"), 1, 10))) & Mid(Format(Val(totaddamount), "0.00"), 1, 10)
            '    'ssql = ssql & Space(1) & Space(10 - Len(Mid(Format(Val(totbalamount), "0.00"), 1, 10))) & Mid(Format(Val(totbalamount), "0.00"), 1, 10)
            '    Filewrite.WriteLine(ssql)
            '    Filewrite.WriteLine(StrDup(80, "-") & Chr(12))

            '    Filewrite.Close()
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
        'If gPrint = False Then
        '    OpenTextFile(vOutfile)
        'Else
        '    PrintTextFile(vOutfile)
        'End If
    End Function
    Private Sub screenprint()
        'Dim i As Integer
        'If Trim(CMBLETERNO.Text) = "" Then
        '    MessageBox.Show("Please Select Letter Code")
        '    Exit Sub
        'End If
        'If TXTMCODEFrom.Text = "" And TXTMCODETO.Text = "" Then
        '    If Trim(catecode) = "" Then
        '        MessageBox.Show("Please Select Category Code")
        '        Exit Sub
        '    End If
        'End If
        'If ChKALL.Checked = False Then
        '    If Trim(cboBillingBasis.Text) = "" Then
        '        MessageBox.Show("Please Select the Bill Type")
        '        Exit Sub
        '    End If
        'End If
        'catecode = ""
        'For i = 0 To CHKCATEGORY.Items.Count - 1
        '    If CHKCATEGORY.GetItemChecked(i) = True Then
        '        TempString = Split(CHKCATEGORY.Items.Item(i), ".")
        '        If catecode = "" Then
        '            catecode = "'" & TempString(0)
        '            vtypedesc = Trim(TempString(1))
        '        Else
        '            catecode = catecode & "','" & TempString(0)
        '            vtypedesc = Trim(vtypedesc) & "," & Trim(TempString(1))
        '        End If
        '    End If
        'Next i
        'catecode = catecode & "'"
        'If ChKALL.Checked = False Then
        '    If TXTMCODEFrom.Text = "" And TXTMCODETO.Text = "" Then
        '        If Trim(CMBLETERNO.Text) <> "" And catecode <> "" And Trim(cboBillingBasis.Text) <> "" Then
        '            sqlString = "update reminderhistory set  asondate='" & Format(dtpASNODATE.Value, "dd/MMM/yyyy") & "'"
        '            sqlString = sqlString & " where  remindercount=" & Trim(CMBLETERNO.Text)
        '            sqlString = sqlString & " and membertypecode in(" & Trim(catecode) & ")"
        '            sqlString = sqlString & " and  remindercode='" & Trim(cboBillingBasis.Text) & "'"
        '            'sqlString = sqlString & " and  fromdate='" & Format(DTPFROM.Value, "dd/MMM/yyyy") & "'"
        '            'sqlString = sqlString & " and  todate='" & Format(DTPTO.Value, "dd/MMM/yyyy") & "'"
        '            posting = gconnection.GetValues(sqlString)
        '        End If
        '    End If
        'End If
        'If RBTREMINDERLETTER.Checked = True Then
        '    Call details()
        'Else
        '    Call SUMMARY()
        'End If
    End Sub
    Private Sub BTNPRINT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNPRINT.Click
        '''gPrint = True
        '''If RBTREMINDERLETTER.Checked = True Then
        '''    Call PrintOperation1()
        '''End If
        '''If RBTREMINDERSUMMARY.Checked = True Then
        '''    Call SUMMARY()
        '''End If
        'Call screenprint()

        GPRINT = True

        If CHKCATEGORY.CheckedItems.Count = 0 Then
            MessageBox.Show("Please Select  the Member Category")
            CHKCATEGORY.Focus()
            Exit Sub
        End If
        If CMBLETERNO.Text = "" Then
            MessageBox.Show("Please Select The Letter No ")
            CMBLETERNO.Focus()
            Exit Sub
        End If

        If CMBLETERNO.Text = "1" Or CMBLETERNO.Text = "2" Or CMBLETERNO.Text = "3" Or CMBLETERNO.Text = "4" Then
            If RBTREMINDERLETTER.Checked = True Then
                Call Printoperation2()
            End If
            If RBTREMINDERSUMMARY.Checked = True Then
                Call Summary2()

            End If
            If RBTREMINDERLIST.Checked = True Then
                Call printdata11()
            End If
            If RBTREMINDERADDRESS.Checked = True Then
                Call print_stikers()
            End If
        End If
    End Sub
    Public Sub print_stikers()
        Try
            Dim cmdText, phone, mcode, mcode1, mobile, serialno As String
            Dim txtobj1 As TextObject
            Dim txtobj2 As TextObject
           
            Dim Sqlstr As String
            Dim MEMBERTYPE As New DataTable
            Sqlstr = "SELECT FROMDATE,TODATE,ASONDATE,MEMBERTYPECODE,BALANCE,MCODE,MNAME,REMINDERDATE,ADDUSER,ADDDATETIME,VOID,VOIDUSER,VOIDDATETIME,DOCNO,DOCDATE,REMINDERNO,CREDITLIMIT,REFNO,CAST(REFNO_DET AS VARCHAR) AS REFNO_DET,CMONTH,PMONTH,PUSAGE,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTCOUNTRY,CONTEMAIL,CONTSTATE,CONTCELL,CONTPIN,CONTPHONE1,CONTPHONE2,MEMBERTYPE,SALUT FROM MM_REMINDERHISTORY WHERE ISNULL(FROMDATE,'')='" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "' AND ISNULL(REMINDERNO,0)=" & CMBLETERNO.Text & " AND ISNULL(VOID,'')<>'Y' ORDER BY LEN(REFNO_DET),REFNO_DET"
            
            gconnection.getDataSet(Sqlstr, "MM_REMINDERHISTORY")
            If gdataset.Tables("MM_REMINDERHISTORY").Rows.Count <= 0 Then
                MessageBox.Show("Address Not Found Or Give Correct Input")
            Else
                Dim Viewer As New REPORTVIEWER
              
                Dim r As New Cry_contact_stikers2
                Call Viewer.GetDetails(Sqlstr, "MM_REMINDERHISTORY", r)
                    'txtobj1 = r.ReportDefinition.ReportObjects("Text1")
                    'txtobj1.Text = UCase(gCompanyname)
                    'txtobj1 = r.ReportDefinition.ReportObjects("Text2")
                    'txtobj1.Text = UCase(gCompanyAddress(1))
                    'txtobj1 = r.ReportDefinition.ReportObjects("Text3")
                    'txtobj1.Text = UCase(gCompanyAddress(2))
                    ''txtobj1 = r.ReportDefinition.ReportObjects("Text4")
                    ''txtobj1.Text = UCase(gCompanyAddress(3))
                    ''txtobj1 = r.ReportDefinition.ReportObjects("Text5")
                    ''txtobj1.Text = UCase(gCompanyAddress(4))
                    'txtobj1 = r.ReportDefinition.ReportObjects("Text6")
                    'txtobj1.Text = UCase(gUsername)
                Viewer.TableName = "MM_REMINDERHISTORY"
                Viewer.Show()
                If GPRINT = True Then
                    Try
                        r.PrintOptions.PrinterName = Printername
                        r.PrintToPrinter(1, False, 0, 0)
                        'Viewer.Visible = False
                        'Viewprint = False
                    Catch EX As Exception
                    End Try
                    Viewer.Close()
                End If
                End If
                'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
   
    Private Sub dtpASNODATE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpASNODATE.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            TXTMCODEFrom.Focus()
        End If
    End Sub
    Private Sub TXTMCODETO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTMCODETO.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            BTNSCREEN.Focus()
        End If
    End Sub
    Private Sub TXTMCODEFrom_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            TXTMCODETO.Focus()
        End If
    End Sub
    Private Sub CHKCATEGORY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CHKCATEGORY.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            TXTMCODEFrom.Focus()
        End If
    End Sub
    Private Sub CMBLETERNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMBLETERNO.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            'cboBillingBasis.Focus()
        End If
    End Sub
    Private Sub cboBillingBasis_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            CHKCATEGORY.Focus()
        End If
    End Sub
    Private Sub Btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_close.Click
        Me.Hide()
    End Sub
    Private Sub TXTMCODEFrom_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F4 Then
            If TXTMCODEFrom.Text = "" Then
                'cmd_MCodefromHelp_Click(sender, e)
            End If
            TXTMCODETO.Focus()
        End If
    End Sub
    Private Sub TXTMCODETO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXTMCODETO.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F4 Then
            If TXTMCODETO.Text = "" Then
                ' cmd_MCodeToHelp_Click(sender, e)
            End If
            BTNSCREEN.Focus()
        End If
    End Sub
    Private Sub CHKCATEGORY_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CHKCATEGORY.LostFocus
        Call remi()
    End Sub
    Private Sub cboBillingBasis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim i As Long
        'posting = Nothing
        'Try
        '    sqlString = "select ISNULL(POSTINGCODE,'') AS POSTINGTYPE FROM postingmast group by postingcode"
        '    posting = gconnection.GetValues(sqlString)
        '    If posting.Rows.Count > 0 Then
        '        cboBillingBasis.Items.Clear()
        '        For i = 0 To posting.Rows.Count - 1
        '            cboBillingBasis.Items.Add(posting.Rows(i).Item("POSTINGTYPE"))
        '        Next
        '    End If
        '    gconnection.closeConnection()
        '    dtpASNODATE.Focus()
        '    CMBLETERNO.SelectedIndex = 0
        '    cboBillingBasis.SelectedIndex = 0
        '    sqlString = "SELECT Membertype,TypeDesc FROM MEMBERTYPE"
        '    posting = gconnection.GetValues(sqlString)
        '    CHKCATEGORY.Items.Clear()
        '    If posting.Rows.Count > 1 Then
        '        For i = 0 To (posting.Rows.Count - 1)
        '            CHKCATEGORY.Items.Add(posting.Rows(i).Item("Membertype") & "." & posting.Rows(i).Item("TypeDesc"))
        '        Next
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub
    Private Sub chk_PrintAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_PrintAll.CheckedChanged
        Dim Iteration As Integer
        If chk_PrintAll.Checked = True Then
            Try
                For Iteration = 0 To (CHKCATEGORY.Items.Count - 1)

                    CHKCATEGORY.SetSelected(Iteration, True)
                    CHKCATEGORY.SetItemChecked(Iteration, True)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                For Iteration = 0 To (CHKCATEGORY.Items.Count - 1)
                    CHKCATEGORY.SetItemChecked(Iteration, False)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub reminder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cmb_ReminderType.SelectedIndex = 0
        CMBLETERNO.SelectedIndex = 0
        Dim i As Long
        posting = Nothing
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        btn_Revert.Enabled = False
        Txt_CreditLimit.Text = 0.0
        'sqlString = "SELECT ISNULL(reminder,0) AS REMINDER FROM MEMBERSSETUP"
        'posting = gconnection.GetValues(sqlString)
        '' CHKCATEGORY.Items.Clear()
        'If posting.Rows.Count > 0 Then
        '    Txt_CreditLimit.Text = Val(posting.Rows(0).Item("REMINDER"))
        '    Txt_CreditLimit.Enabled = False

        'End If
        Try
            CMBLETERNO.SelectedIndex = 0
            sqlString = "SELECT ISNULL(SUBTYPECODE,'') AS MEMBERTYPE,ISNULL(SUBTypeDesc,'') AS TYPEDESC FROM SUBCATEGORYMASTER"
            posting = gconnection.GetValues(sqlString)
            CHKCATEGORY.Items.Clear()
            If posting.Rows.Count > 1 Then
                For i = 0 To (posting.Rows.Count - 1)
                    CHKCATEGORY.Items.Add(posting.Rows(i).Item("Membertype") & "." & posting.Rows(i).Item("TypeDesc"))
                Next
            End If
            dtpASNODATE.Value = Date.Now
            Dtp_CutOffDate.Value = Date.Now
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        posting = Nothing
        sqlString = "select ISNULL(MAX(ISNULL(DOCNO,0)),0) AS DOCNO FROM reminderhistory "
        posting = gconnection.GetValues(sqlString)
        If posting.Rows.Count = 1 Then
            Label12.Text = "Last Doc No.is " & posting.Rows(0).Item("docno")
        Else
            Label12.Text = "Last Doc No.is 0"
        End If
        posting1 = Nothing
        sqlString = "select ISNULL(MAX(ISNULL(DOCNO,0)),0)+1 AS DOCNO FROM reminderhistory "
        posting1 = gconnection.GetValues(sqlString)
        If posting1.Rows.Count = 1 Then
            docno = posting1.Rows(0).Item("docno")
        Else
            docno = 1
        End If
        RBTREMINDERLETTER.Checked = True
        RBTREMINDERADDRESS.Checked = False

        Dtp_rem.Visible = True
        DTP_FIRST.Visible = True
        Dtp_Last.Value = Now()
        Dtp_rem.Value = Now()
        PLoad()
        Call picture()
    End Sub
    Public Sub picture()
        'PIC1.Image = New Bitmap(AppPath & "\tnbsa logo.JPG")
        'gconnection.SaveCLUBFoto(AppPath & "\tnbsa logo.JPG", "RSIFRONT")
        'Dim SQLSTRING As String
        'Dim I As Integer
        'SQLSTRING = "SELECT clublogo FROM accountsSetUp "
        'gconnection.getDataSet(SQLSTRING, "PHOTO")
        ''If gdataset.Tables("PHOTO").Rows.Count > 0 Then
        ''    For I = 0 To gdataset.Tables("PHOTO").Rows.Count - 1
        ''        With SSGRID
        ''            .Row = I + 1
        ''            .Col = 1
        ''            .Text = gdataset.Tables("PHOTO").Rows(I).Item("MCODE")
        ''            .Col = 2
        ''            .Text = gdataset.Tables("PHOTO").Rows(I).Item("MNAME")
        ''            .MaxRows = .MaxRows + 1
        ''        End With
        ''    Next
        ''End If

        'Dim ssql As String
        'Dim MEMBERTYPE As New DataTable
        'ssql = "select isnull(membertype,'') as membertype,isnull(typedesc,'') as typedesc from membertype"
        'MEMBERTYPE = gconnection.GetValues(ssql)
        'Dim Itration
        'For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
        '    chk_Filter_Field.Items.Add(MEMBERTYPE.Rows(Itration).Item("Membertype") & "." & MEMBERTYPE.Rows(Itration).Item("TypeDesc"))
        'Next
        'LoadUnitNO()
        'chk_Filter_Field.Focus()
        'RDOCOMBINEDNO.Checked = True
    End Sub
    Function Opbalance()
        'sqlString = " SELECT SLCODE,"
        Dim S, R As String
        S = Format(dtpASNODATE.Value, "MMM-yyyy")
        R = Format(Dtp_CutOffDate.Value, "dd/MMM/yyyy")

        Select Case (MONTH1)
            Case 4
                sqlString = sqlString & "isnull(isnull(opdebits,0)- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE  from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                sqlString = sqlString & " where isnull(isnull(opdebits,0)- (isnull(opcredits,0)+ isnull(APRcredits,0)+isnull(maycredits,0)),0)  > '" & Val(Txt_CreditLimit.Text) & "' AND "
            Case 5
                sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "

                'sqlString = sqlString & "isnull((isnull(opdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                'sqlString = sqlString & " where isnull((isnull(opdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
            Case 6
                sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
                'sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                'sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
            Case 7
                sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
                'sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                'sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
            Case 8
                sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
                'sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                'sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
            Case 9
                sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
                'sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                'sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
            Case 10
                sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
                'sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                'sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
            Case 11
                sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
                'sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                'sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
            Case 12
                sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0)+isnull(novdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)+isnull(jancredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0)+isnull(novdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)+isnull(jancredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
                'sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                'sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
            Case 1
                sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0)+isnull(novdebits,0)+isnull(decdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)+isnull(jancredits,0)+isnull(febcredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0)+isnull(novdebits,0)+isnull(decdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)+isnull(jancredits,0)+isnull(febcredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
                'sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0)+isnull(novdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)+isnull(jancredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                'sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0)+isnull(novdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)+isnull(jancredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
            Case 2
                sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0)+isnull(novdebits,0)+isnull(decdebits,0)+isnull(jandebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)+isnull(jancredits,0)+isnull(febcredits,0)+isnull(marcredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0)+isnull(novdebits,0)+isnull(decdebits,0)+isnull(jandebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)+isnull(jancredits,0)+isnull(febcredits,0)+isnull(marcredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
                'sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0)+isnull(novdebits,0)+isnull(decdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)+isnull(jancredits,0)+isnull(febcredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                'sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0)+isnull(novdebits,0)+isnull(decdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)+isnull(jancredits,0)+isnull(febcredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
            Case 3
                sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0)+isnull(novdebits,0)+isnull(decdebits,0)+isnull(jandebits,0)+isnull(febdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)+isnull(jancredits,0)+isnull(febcredits,0)+isnull(marcredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0)+isnull(novdebits,0)+isnull(decdebits,0)+isnull(jandebits,0)+isnull(febdebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)+isnull(jancredits,0)+isnull(febcredits,0)+isnull(marcredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
                'sqlString = sqlString & "isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0)+isnull(novdebits,0)+isnull(decdebits,0)+isnull(jandebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)+isnull(jancredits,0)+isnull(febcredits,0)+isnull(marcredits,0)),0) as CLOSINGBALANCE,'" & S & "' as SMONTH,'" & R & "' as RMONTH,ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from accountssubledgermaster a INNER JOIN MEMBERMASTER B ON B.MCODE = A.SLCODE INNER JOIN MEMBERTYPE C ON B.MEMBERTYPECODE = C.MEMBERTYPE  "
                'sqlString = sqlString & " where isnull((isnull(opdebits,0)+isnull(aprdebits,0)+isnull(maydebits,0)+isnull(jundebits,0)+isnull(juldebits,0)+isnull(augdebits,0)+isnull(sepdebits,0)+isnull(octdebits,0)+isnull(novdebits,0)+isnull(decdebits,0)+isnull(jandebits,0))- (isnull(opcredits,0)+isnull(aprcredits,0)+isnull(maycredits,0)+isnull(juncredits,0)+isnull(julcredits,0)+isnull(augcredits,0)+isnull(sepcredits,0)+isnull(octcredits,0)+isnull(novcredits,0)+isnull(deccredits,0)+isnull(jancredits,0)+isnull(febcredits,0)+isnull(marcredits,0)),0) > '" & Val(Txt_CreditLimit.Text) & "' AND "
        End Select
    End Function

    Private Sub rbtPartyLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim pleter As New PLetter
        'pleter.Show()
    End Sub

    'Private Sub OrdernoHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim vform As New ListOperation
    '    gSQLString = "Select Orderno ,Orderdate  from Party_Order"
    '    M_WhereCondition = " "
    '    vform.Field = "Orderno,Orderdate "
    '    vform.vFormatstring = "  Order No.  | Order Date                      "
    '    vform.vCaption = "Party Order Help"
    '    vform.KeyPos = 0
    '    vform.KeyPos1 = 1
    '    vform.ShowDialog(Me)
    '    If Trim(vform.keyfield & "") <> "" Then
    '        Txt_Orderno.Text = Trim(vform.keyfield & "")
    '    End If
    '    vform.Close()
    '    vform = Nothing
    'End Sub

    'Private Sub Txt_Orderno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyCode = Keys.Enter Then
    '        If Txt_Orderno.Text = "" Then
    '            Call OrdernoHelp_Click(sender, e)
    '        End If
    '    End If
    '    If e.KeyCode = Keys.F4 Then
    '        Call OrdernoHelp_Click(sender, e)
    '    End If
    'End Sub

    Private Sub rbtPartyLetter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If rbtPartyLetter.Checked = True Then
        '    Txt_Orderno.Visible = True
        '    OrdernoHelp.Visible = True
        'Else
        '    Txt_Orderno.Visible = False
        '    OrdernoHelp.Visible = False
        'End If
    End Sub

    Private Sub Summary1()
        Dim DT As New DataTable
        Dim I As Integer
        Dim vSql As Object
        Dim month1 As Object
        Dim Loopindex As Object
        Dim vtype() As Object
        Dim VTYPE1 As String
        Dim vsplit() As String
        Dim ssql, appcode() As String
        Try
            'vCaption = "MEMBER OUTSTANDING DETAILS AS ON :" & IIf(month1 = Month(dd), Format(dd, "dd/MMM/yyyy"), Format(Dtp_CutOffDate.Value, "dd/MMM/yyyy"))
            'vSql = "EXEC TP_OUTSTANDING_SUMMARY  " & "'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "','" & mdate & "'"
            vSql = "EXEC TP_OUTSTANDING_SUMMARY  " & "'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "','" & Format(dtpASNODATE.Value, "dd-MMM-yyyy") & "'"
            gconnection.GetValues(vSql)
            If Val(Txt_CreditLimit.Text) > 0 Then
                If Txt_CreditLimit.Text = "" Then
                    'vSql = "select mcode,SLname,clbal from outstandrpt_summary where clbal <> 0  ORDER BY MCODE"
                    'vSql = "SELECT isnull(O.Mcode,'') as MCODE,isnull(Mname,'') as MNAME,ISNULL(MEMBERTYPECODE,'') AS MEMBERTYPECODE,ISNULL(CONTADD1,'') AS ADD1,ISNULL(CONTADD2,'') AS ADD2,ISNULL(CONTADD3,'') AS ADD3,ISNULL(CONTCITY,'') AS CITY,ISNULL(CONTPIN,'') AS PIN,ISNULL(CLBAL,0)CLOSINGBAL FROM OUTSTANDRPT_SUMMARY O, MEMBERMASTER M WHERE O.MCODE = M.MCODE AND CLBAL <> 0 AND CURENTSTATUS = 'LIVE'"
                    vSql = "SELECT isnull(O.Mcode,'') as MCODE,isnull(Mname,'') as MNAME,ISNULL(MEMBERTYPECODE,'') AS MEMBERTYPECODE,ISNULL(CONTADD1,'') AS ADD1,ISNULL(CONTADD2,'') AS ADD2,ISNULL(CONTADD3,'') AS ADD3,ISNULL(CONTCITY,'') AS CITY,ISNULL(CONTPIN,'') AS PIN, isnull(CLBAL,0) as CLOSINGBALANCE, '" & Format(dtpASNODATE.Value, "dd-MMM-yyyy") & "' as SMONTH,'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "' as RMONTH,"
                    vSql = vSql & "ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from OUTSTANDRPT_SUMMARY O INNER JOIN MEMBERMASTER M ON O.MCODE = M.MCODE INNER JOIN MEMBERTYPE C ON M.MEMBERTYPECODE = C.MEMBERTYPE where isnull(CLBAL,0) <> 0 AND  "
                    'vSql = vSql & "isnull(membertypecode,'') in ( 'F ',  'HM ',  'I ',  'L ',  'LA ',  'R ',  'SD ',  'T ') AND CURENTSTATUS = 'LIVE' order by O.MCODE"
                Else
                    'vSql = "select mcode,SLname,clbal from outstandrpt_summary where clbal >= " & Format(Val(Txt_CreditLimit.Text), "0.00") & "  ORDER BY MCODE"
                    'vSql = "SELECT isnull(O.Mcode,'') as MCODE,isnull(Mname,'') as MNAME,ISNULL(MEMBERTYPECODE,'') AS MEMBERTYPECODE,ISNULL(CONTADD1,'') AS ADD1,ISNULL(CONTADD2,'') AS ADD2,ISNULL(CONTADD3,'') AS ADD3,ISNULL(CONTCITY,'') AS CITY,ISNULL(CONTPIN,'') AS PIN,ISNULL(CLBAL,0)CLOSINGBAL FROM OUTSTANDRPT_SUMMARY O, MEMBERMASTER M WHERE O.MCODE = M.MCODE AND CLBAL >=  " & Format(Val(Txt_CreditLimit.Text), "0.00") & " AND CURENTSTATUS = 'LIVE'"
                    vSql = "SELECT isnull(O.Mcode,'') as MCODE,isnull(Mname,'') as MNAME,ISNULL(MEMBERTYPECODE,'') AS MEMBERTYPECODE,ISNULL(CONTADD1,'') AS ADD1,ISNULL(CONTADD2,'') AS ADD2,ISNULL(CONTADD3,'') AS ADD3,ISNULL(CONTCITY,'') AS CITY,ISNULL(CONTPIN,'') AS PIN, isnull(CLBAL,0) as CLOSINGBALANCE, '" & Format(dtpASNODATE.Value, "dd-MMM-yyyy") & "' as SMONTH,'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "' as RMONTH,"
                    vSql = vSql & "ISNULL(CONTPHONE1,'') AS PHONE,ISNULL(TYPEDESC,'') AS TYPE from OUTSTANDRPT_SUMMARY O INNER JOIN MEMBERMASTER M ON O.MCODE = M.MCODE INNER JOIN MEMBERTYPE C ON M.MEMBERTYPECODE = C.MEMBERTYPE where isnull(CLBAL,0) >= " & Format(Val(Txt_CreditLimit.Text), "0.00") & " AND  "
                End If
            End If
            vSql = ""
            If CMBLETERNO.Text = "1" Then
                vSql = "select * from OUTSTANDRPT_SUMMARY where  isnull(CLBAL,0) >= 1000 " & " AND "
            Else
                vSql = "select * from OUTSTANDRPT_SUMMARY where  isnull(CLBAL,0) >= " & Format(Val(Txt_CreditLimit.Text), "0.00") & " AND "
            End If

            vSql = vSql & " isnull(type,'') in ("
            For I = 0 To CHKCATEGORY.CheckedItems.Count - 1
                appcode = Split(CHKCATEGORY.CheckedItems(I), ".")
                vSql = vSql & " '" & appcode(0) & "', "
            Next
            vSql = Mid(vSql, 1, Len(vSql) - 2)
            vSql = vSql & ") AND CURENTSTATUS = 'LIVE' order by MCODE "
            'DT = gconnection.GetValues(vSql)

            Dim Viewer As New REPORTVIEWER
            Dim r As New Remainder1Summary
            Viewer.ssql = vSql
            Viewer.Report = r
            Viewer.TableName = "OUTSTANDRPT_SUMMARY"
            Viewer.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Exit Sub
    End Sub
    Private Sub Printoperation2()
        Dim DT As New DataTable
        Dim I As Integer
        Dim vSql As Object
        Dim month1 As Object
        Dim Loopindex As Object
        Dim vtype() As Object
        Dim VTYPE1, bill As String
        Dim vsplit() As String
        Dim ssql, appcode() As String
        Dim LAST As DateTime
        Dim cmonth, pmonth, CATEGORY As String

        vSql = ""
        'LAST = DateAdd(DateInterval.Month, -1, dtpASNODATE.Value)
        'sqlString = "SELECT dbo.[ufn_GetLastDayOfMonth]('" & Format(LAST, "yyyy-MM-dd") & "')"
        'gconnection.getDataSet(sqlString, "mem")
        'If gdataset.Tables("mem").Rows.Count > 0 Then
        '    LAST = gdataset.Tables("mem").Rows(0).Item(0)

        'End If
        'cmonth = Format(dtpASNODATE.Value, "MMM")
        'pmonth = Format(LAST, "MMM")

        If txt_docno.Text <> "" Or txt_docno.Enabled = False Then

            'ssql = Mid(ssql, 1, Len(ssql) - 2)
            '' ssql = ssql & ") "
            If CMBLETERNO.Text = "1" Then
                If Cmb_ReminderType.Text = "MEMBER" Then
                    'ssql = "SELECT FROMDATE,TODATE,ASONDATE,MEMBERTYPECODE,round(BALANCE,0) as balance,MCODE,MNAME,REMINDERDATE,ADDUSER,ADDDATETIME,VOID,VOIDDATETIME,DOCNO,DOCDATE,REMINDERNO,CREDITLIMIT,REFNO,CAST(REFNO_DET AS VARCHAR) AS REFNO_DET,CMONTH,PMONTH,PUSAGE,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTCOUNTRY,CONTEMAIL,CONTSTATE,CONTCELL,CONTPIN,CONTPHONE1,CONTPHONE2,MEMBERTYPE,SALUT,'Regular'as VOIDUSER FROM MM_REMINDERHISTORY_BILL WHERE ISNULL(FROMDATE,'')='" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "' AND ISNULL(DOCNO,0)=" & txt_docno.Text & " AND ISNULL(VOID,'')<>'Y' AND round(PUSAGE,0)>0  ORDER BY MCODE"
                    ssql = "SELECT FROMDATE,TODATE,ASONDATE,MEMBERTYPECODE,round(BALANCE,0) as balance,MCODE,MNAME,REMINDERDATE,ADDUSER,ADDDATETIME,VOID,VOIDDATETIME,DOCNO,DOCDATE,REMINDERNO,CREDITLIMIT,REFNO,CAST(REFNO_DET AS VARCHAR) AS REFNO_DET,CMONTH,PMONTH,PUSAGE,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTCOUNTRY,CONTEMAIL,CONTSTATE,CONTCELL,CONTPIN,CONTPHONE1,CONTPHONE2,TYPE as MEMBERTYPE,SALUT,'MEMBER'as VOIDUSER,G_BALANCE FROM MM_REMINDERHISTORY_BILL WHERE ISNULL(FROMDATE,'')='" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "' AND ISNULL(DOCNO,0)=" & txt_docno.Text & " AND ISNULL(VOID,'')<>'Y'   ORDER BY MCODE"
                    gconnection.GetValues(ssql)
                    'ElseIf Cmb_ReminderType.Text = "PARTY" 
                ElseIf Cmb_ReminderType.Text = "NRI MEMBER" Then
                    '  ssql = "SELECT FROMDATE,TODATE,ASONDATE,MEMBERTYPECODE,round(P_BALANCE,0) AS BALANCE,MCODE,MNAME,REMINDERDATE,ADDUSER,ADDDATETIME,VOID,VOIDDATETIME,DOCNO,DOCDATE,REMINDERNO,CREDITLIMIT,REFNO,CAST(REFNO_DET AS VARCHAR) AS REFNO_DET,CMONTH,PMONTH,PUSAGE,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTCOUNTRY,CONTEMAIL,CONTSTATE,CONTCELL,CONTPIN,CONTPHONE1,CONTPHONE2,MEMBERTYPE,SALUT,'Party'as VOIDUSER  FROM MM_REMINDERHISTORY_BILL WHERE ISNULL(FROMDATE,'')='" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "' AND ISNULL(DOCNO,0)=" & txt_docno.Text & " AND ISNULL(VOID,'')<>'Y' AND round(P_BALANCE,0)>0 ORDER BY MCODE"
                    ssql = "SELECT FROMDATE,TODATE,ASONDATE,MEMBERTYPECODE,round(P_BALANCE,0) AS BALANCE,MCODE,MNAME,REMINDERDATE,ADDUSER,ADDDATETIME,VOID,VOIDDATETIME,DOCNO,DOCDATE,REMINDERNO,CREDITLIMIT,REFNO,CAST(REFNO_DET AS VARCHAR) AS REFNO_DET,CMONTH,PMONTH,PUSAGE,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTCOUNTRY,CONTEMAIL,CONTSTATE,CONTCELL,CONTPIN,CONTPHONE1,CONTPHONE2,TYPE as MEMBERTYPE,SALUT,'NRI MEMBER'as VOIDUSER ,G_BALANCE FROM MM_REMINDERHISTORY_BILL WHERE ISNULL(FROMDATE,'')='" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "' AND ISNULL(DOCNO,0)=" & txt_docno.Text & " AND ISNULL(VOID,'')<>'Y'  ORDER BY MCODE"
                    gconnection.GetValues(ssql)
                ElseIf Cmb_ReminderType.Text = "CHAMBER" Then
                    ssql = "SELECT FROMDATE,TODATE,ASONDATE,MEMBERTYPECODE,round(G_BALANCE,0) AS BALANCE,MCODE,MNAME,REMINDERDATE,ADDUSER,ADDDATETIME,VOID,VOIDDATETIME,DOCNO,DOCDATE,REMINDERNO,CREDITLIMIT,REFNO,CAST(REFNO_DET AS VARCHAR) AS REFNO_DET,CMONTH,PMONTH,PUSAGE,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTCOUNTRY,CONTEMAIL,CONTSTATE,CONTCELL,CONTPIN,CONTPHONE1,CONTPHONE2,TYPE as MEMBERTYPE,SALUT,'Chamber'as VOIDUSER  FROM MM_REMINDERHISTORY_BILL WHERE ISNULL(FROMDATE,'')='" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "' AND ISNULL(DOCNO,0)=" & txt_docno.Text & " AND ISNULL(VOID,'')<>'Y' ORDER BY MCODE"
                    gconnection.GetValues(ssql)
                End If
            Else
                ssql = "SELECT FROMDATE,TODATE,ASONDATE,MEMBERTYPECODE,round(BALANCE,0) as BALANCE,round(P_BALANCE,0) as P_BALANCE ,round(G_BALANCE,0) as G_BALANCE,MCODE,MNAME,REMINDERDATE,ADDUSER,ADDDATETIME,VOID,VOIDUSER,VOIDDATETIME,DOCNO,DOCDATE,REMINDERNO,CREDITLIMIT,REFNO,CAST(REFNO_DET AS VARCHAR) AS REFNO_DET,CMONTH,PMONTH,PUSAGE,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTCOUNTRY,CONTEMAIL,CONTSTATE,CONTCELL,CONTPIN,CONTPHONE1,CONTPHONE2,TYPE as MEMBERTYPE,SALUT  FROM MM_REMINDERHISTORY_BILL WHERE ISNULL(FROMDATE,'')='" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "' AND ISNULL(DOCNO,0)=" & txt_docno.Text & " AND ISNULL(VOID,'')<>'Y' ORDER BY MCODE"
                gconnection.GetValues(ssql)
            End If

            'ssql = ""

            Dim Viewer As New REPORTVIEWER
            Dim r2
            ' Dim r As New Reminder1
            If Mid(UCase(Trim(gcompanyname)), 1, 3) = "MLA" Then
                If Chk_lttr.Checked = True Then
                    r2 = New MlaReminder1_ltt
                Else
                    r2 = New MlaReminder1
                End If

            Else
                r2 = New Reminder3
            End If

            Dim r1 As New Reminder2
            Dim r As New CCLReminder1

            If Mid(Me.dtpASNODATE.Text, 4, 2) = "04" Then bill = "April " & Mid(gFinancalyearStart, 1, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "05" Then bill = "May " & Mid(gFinancalyearStart, 1, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "06" Then bill = "June " & Mid(gFinancalyearStart, 1, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "07" Then bill = "July " & Mid(gFinancalyearStart, 1, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "08" Then bill = "August " & Mid(gFinancalyearStart, 1, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "09" Then bill = "September " & Mid(gFinancalyearStart, 1, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "10" Then bill = "October " & Mid(gFinancalyearStart, 1, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "11" Then bill = "November " & Mid(gFinancalyearStart, 1, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "12" Then bill = "December " & Mid(gFinancalyearStart, 1, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "01" Then bill = "January " & Mid(gFinancialyearEnd, 1, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "02" Then bill = "February " & Mid(gFinancialyearEnd, 1, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "03" Then bill = "March  " & Mid(gFinancialyearEnd, 1, 4)
            Viewer.ssql = ssql
            If CMBLETERNO.Text = "1" Then
                Viewer.Report = r
            ElseIf CMBLETERNO.Text = "2" Then

                Viewer.Report = r1
            ElseIf CMBLETERNO.Text = "3" Then

                Viewer.Report = r2
            End If

            If CMBLETERNO.Text = "3" Then
                txtobj1 = r2.ReportDefinition.ReportObjects("Text12")
                txtobj1.Text = UCase(TXT_REFNO.Text)
                txtobj1 = r2.ReportDefinition.ReportObjects("Text3")
                txtobj1.Text = Format(Dtp_rem.Value, "dd/MMM/yyyy")
            End If

            Viewer.TableName = "MM_REMINDERHISTORY"
            Viewer.Show()
        Else
            'For I=0 TO 
            For I = 0 To CHKCATEGORY.CheckedItems.Count - 1
                appcode = Split(CHKCATEGORY.CheckedItems(I), ".")
                CATEGORY = CATEGORY & " '" & appcode(0) & "', "
            Next
            CATEGORY = Mid(CATEGORY, 1, Len(CATEGORY) - 2)

            If Cmb_ReminderType.Text = "MEMBER" Then
                vSql = "EXEC cp_creditlimit_REMINDER  '" & Format(dtpASNODATE.Value, "dd/MMM/yyyy") & "','" & Format(Dtp_CutOffDate.Value, "dd/MMM/yyyy") & "','N','" & CMBLETERNO.Text & "'"
                'vSql = "EXEC TP_OUTSTANDING_SUMMARY  " & "'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "','" & Format(dtpASNODATE.Value, "dd-MMM-yyyy") & "'"
                gconnection.GetValues(vSql)
            Else
                vSql = "EXEC cp_creditlimit_REMINDER_Doller  '" & Format(dtpASNODATE.Value, "dd/MMM/yyyy") & "','" & Format(Dtp_CutOffDate.Value, "dd/MMM/yyyy") & "','N','" & CMBLETERNO.Text & "'"
                'vSql = "EXEC TP_OUTSTANDING_SUMMARY  " & "'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "','" & Format(dtpASNODATE.Value, "dd-MMM-yyyy") & "'"
                gconnection.GetValues(vSql)
            End If
           
            vSql = "DELETE FROM REMINDERHISTORY_TRIAL"
            gconnection.GetValues(vSql)
            If CMBLETERNO.Text = "1" Then


                If Cmb_ReminderType.Text = "MEMBER" Then
                    ssql = ""
                    ssql = "insert into reminderhistory_TRIAL(docno,docdate,membertypecode,mcode,mname,fromdate,todate,balance,reminderdate,adduser,adddatetime,reminderno,asondate,creditlimit,REFNO,REFNO_DET,CMONTH,PMONTH,PUSAGE)"
                    ssql = ssql & " select '" & docno & "','" & Format(dtp_docdate.Value, "yyyy-MM-dd") & "',MEMBERTYPECODE,mcode,MNAME,'" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "','" & Format(Dtp_CutOffDate.Value, "yyyy-MM-dd") & "',USAGE,'" & Format(Dtp_rem.Value, "yyyy-MM-dd") & "','" & gUsername & "','" & Format(Now(), "yyyy-MM-dd HH:MM") & "','" & CMBLETERNO.Text & "','" & Format(Dtp_Last.Value, "yyyy-MM-dd") & "'," & Txt_CreditLimit.Text & ",'" & TXT_REFNO.Text & "',REF_ORDER,CMONTH,PMONTH,PUSAGE from VIEW_MEM_CREDIT_REMINDER where  isnull(USAGE,0) >= " & Format(Val(Txt_CreditLimit.Text), "0.00") & " AND "
                    ssql = ssql & " isnull(MEMBERTYPECODE,'') in ("
                    'vSql = vSql & " isnull(MT.TypeDesc,'') in ("
                    For I = 0 To CHKCATEGORY.CheckedItems.Count - 1
                        appcode = Split(CHKCATEGORY.CheckedItems(I), ".")
                        ssql = ssql & " '" & appcode(0) & "', "
                    Next

                    ssql = Mid(ssql, 1, Len(ssql) - 2)
                    ssql = ssql & ") "
                    gconnection.GetValues(ssql)
                    GroupBox3.Visible = True
                    Dim checked As String
                    ssql = "SELECT FROMDATE,TODATE,ASONDATE,MEMBERTYPECODE,BALANCE,MCODE,MNAME,REMINDERDATE,ADDUSER,ADDDATETIME,VOID,VOIDUSER,VOIDDATETIME,DOCNO,DOCDATE,REMINDERNO,CREDITLIMIT,REFNO,CAST(REFNO_DET AS VARCHAR) AS REFNO_DET,CMONTH,PMONTH,PUSAGE,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTCOUNTRY,CONTEMAIL,CONTSTATE,CONTCELL,CONTPIN,CONTPHONE1,CONTPHONE2,MEMBERTYPE,SALUT FROM MM_REMINDERHISTORY_TRIAL WHERE ISNULL(FROMDATE,'')='" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "' AND ISNULL(REMINDERNO,0)=" & CMBLETERNO.Text & " AND ISNULL(BALANCE,0)>0 AND ISNULL(VOID,'')<>'Y' ORDER BY mcode,len(mcode)"
                    ' ElseIf Cmb_ReminderType.Text = "PARTY" Then
                ElseIf Cmb_ReminderType.Text = "NRI MEMBER" Then
                    ssql = ""
                    ssql = "insert into reminderhistory_TRIAL(docno,docdate,membertypecode,mcode,mname,fromdate,todate,P_balance,reminderdate,adduser,adddatetime,reminderno,asondate,creditlimit,REFNO,REFNO_DET,CMONTH,PMONTH,PUSAGE)"
                    ssql = ssql & " select '" & docno & "','" & Format(dtp_docdate.Value, "yyyy-MM-dd") & "',MEMBERTYPECODE,mcode,MNAME,'" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "','" & Format(Dtp_CutOffDate.Value, "yyyy-MM-dd") & "',P_USAGE,'" & Format(Dtp_rem.Value, "yyyy-MM-dd") & "','" & gUsername & "','" & Format(Now(), "yyyy-MM-dd HH:MM") & "','" & CMBLETERNO.Text & "','" & Format(Dtp_Last.Value, "yyyy-MM-dd") & "'," & Txt_CreditLimit.Text & ",'" & TXT_REFNO.Text & "',REF_ORDER,CMONTH,PMONTH,PUSAGE from VIEW_MEM_CREDIT_REMINDER where  isnull(P_USAGE,0) >= " & Format(Val(Txt_CreditLimit.Text), "0.00") & " AND "
                    ssql = ssql & " isnull(MEMBERTYPECODE,'') in ("
                    'vSql = vSql & " isnull(MT.TypeDesc,'') in ("
                    For I = 0 To CHKCATEGORY.CheckedItems.Count - 1
                        appcode = Split(CHKCATEGORY.CheckedItems(I), ".")
                        ssql = ssql & " '" & appcode(0) & "', "
                    Next

                    ssql = Mid(ssql, 1, Len(ssql) - 2)
                    ssql = ssql & ") "
                    gconnection.GetValues(ssql)
                    GroupBox3.Visible = True
                    Dim checked As String
                    ssql = "SELECT FROMDATE,TODATE,ASONDATE,MEMBERTYPECODE,P_BALANCE AS BALANCE,MCODE,MNAME,REMINDERDATE,ADDUSER,ADDDATETIME,VOID,VOIDUSER,VOIDDATETIME,DOCNO,DOCDATE,REMINDERNO,CREDITLIMIT,REFNO,CAST(REFNO_DET AS VARCHAR) AS REFNO_DET,CMONTH,PMONTH,PUSAGE,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTCOUNTRY,CONTEMAIL,CONTSTATE,CONTCELL,CONTPIN,CONTPHONE1,CONTPHONE2,MEMBERTYPE,SALUT FROM MM_REMINDERHISTORY_TRIAL WHERE ISNULL(FROMDATE,'')='" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "' AND ISNULL(REMINDERNO,0)=" & CMBLETERNO.Text & " AND ISNULL(P_BALANCE,0)>0 AND ISNULL(VOID,'')<>'Y' ORDER BY mcode,len(mcode)"
                ElseIf Cmb_ReminderType.Text = "CHAMBER" Then
                    ssql = ""
                    ssql = "insert into reminderhistory_TRIAL(docno,docdate,membertypecode,mcode,mname,fromdate,todate,G_balance,reminderdate,adduser,adddatetime,reminderno,asondate,creditlimit,REFNO,REFNO_DET,CMONTH,PMONTH,PUSAGE)"
                    ssql = ssql & " select '" & docno & "','" & Format(dtp_docdate.Value, "yyyy-MM-dd") & "',MEMBERTYPECODE,mcode,MNAME,'" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "','" & Format(Dtp_CutOffDate.Value, "yyyy-MM-dd") & "',G_USAGE,'" & Format(Dtp_rem.Value, "yyyy-MM-dd") & "','" & gUsername & "','" & Format(Now(), "yyyy-MM-dd HH:MM") & "','" & CMBLETERNO.Text & "','" & Format(Dtp_Last.Value, "yyyy-MM-dd") & "'," & Txt_CreditLimit.Text & ",'" & TXT_REFNO.Text & "',REF_ORDER,CMONTH,PMONTH,PUSAGE from VIEW_MEM_CREDIT_REMINDER where  isnull(G_USAGE,0) >= " & Format(Val(Txt_CreditLimit.Text), "0.00") & " AND "
                    ssql = ssql & " isnull(MEMBERTYPECODE,'') in ("
                    'vSql = vSql & " isnull(MT.TypeDesc,'') in ("
                    For I = 0 To CHKCATEGORY.CheckedItems.Count - 1
                        appcode = Split(CHKCATEGORY.CheckedItems(I), ".")
                        ssql = ssql & " '" & appcode(0) & "', "
                    Next

                    ssql = Mid(ssql, 1, Len(ssql) - 2)
                    ssql = ssql & ") "
                    gconnection.GetValues(ssql)
                    GroupBox3.Visible = True

                    Dim checked As String
                    ssql = "SELECT FROMDATE,TODATE,ASONDATE,MEMBERTYPECODE,round(G_BALANCE,0) AS BALANCE,MCODE,MNAME,REMINDERDATE,ADDUSER,ADDDATETIME,VOID,VOIDUSER,VOIDDATETIME,DOCNO,DOCDATE,REMINDERNO,CREDITLIMIT,REFNO,CAST(REFNO_DET AS VARCHAR) AS REFNO_DET,CMONTH,PMONTH,PUSAGE,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTCOUNTRY,CONTEMAIL,CONTSTATE,CONTCELL,CONTPIN,CONTPHONE1,CONTPHONE2,MEMBERTYPE,SALUT FROM MM_REMINDERHISTORY_TRIAL WHERE ISNULL(FROMDATE,'')='" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "' AND ISNULL(REMINDERNO,0)=" & CMBLETERNO.Text & " AND ISNULL(G_BALANCE,0)>0 AND ISNULL(VOID,'')<>'Y' ORDER BY mcode,len(mcode)"
                End If
            Else
                ssql = ""
                ssql = "insert into reminderhistory_TRIAL(docno,docdate,membertypecode,mcode,mname,fromdate,todate,balance,P_BALANCE,G_BALANCE,reminderdate,adduser,adddatetime,reminderno,asondate,creditlimit,REFNO,REFNO_DET,CMONTH,PMONTH,PUSAGE)"
                ssql = ssql & " select '" & docno & "','" & Format(dtp_docdate.Value, "yyyy-MM-dd") & "',MEMBERTYPECODE,mcode,MNAME,'" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "','" & Format(Dtp_CutOffDate.Value, "yyyy-MM-dd") & "',USAGE,P_USAGE,G_USAGE,'" & Format(Dtp_rem.Value, "yyyy-MM-dd") & "','" & gUsername & "','" & Format(Now(), "yyyy-MM-dd HH:MM") & "','" & CMBLETERNO.Text & "','" & Format(Dtp_Last.Value, "yyyy-MM-dd") & "'," & Txt_CreditLimit.Text & ",'" & TXT_REFNO.Text & "',REF_ORDER,CMONTH,PMONTH,PUSAGE from VIEW_MEM_CREDIT_REMINDER where  isnull(USAGE,0)+ISNULL(P_USAGE,0)+ISNULL(G_USAGE,0) >= " & Format(Val(Txt_CreditLimit.Text), "0.00") & " AND "
                ssql = ssql & " isnull(MEMBERTYPECODE,'') in ("
                'vSql = vSql & " isnull(MT.TypeDesc,'') in ("
                For I = 0 To CHKCATEGORY.CheckedItems.Count - 1
                    appcode = Split(CHKCATEGORY.CheckedItems(I), ".")
                    ssql = ssql & " '" & appcode(0) & "', "
                Next

                ssql = Mid(ssql, 1, Len(ssql) - 2)
                ssql = ssql & ") "
                gconnection.GetValues(ssql)
                GroupBox3.Visible = True
                Dim checked As String
                ssql = "SELECT FROMDATE,TODATE,ASONDATE,MEMBERTYPECODE,round(balance,0) as balance,round(P_BALANCE,0)as P_BALANCE,round(G_BALANCE,0) as G_BALANCE,MCODE,MNAME,REMINDERDATE,ADDUSER,ADDDATETIME,VOID,VOIDUSER,VOIDDATETIME,DOCNO,DOCDATE,REMINDERNO,CREDITLIMIT,REFNO,CAST(REFNO_DET AS VARCHAR) AS REFNO_DET,CMONTH,PMONTH,PUSAGE,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTCOUNTRY,CONTEMAIL,CONTSTATE,CONTCELL,CONTPIN,CONTPHONE1,CONTPHONE2,MEMBERTYPE,SALUT FROM MM_REMINDERHISTORY_TRIAL WHERE ISNULL(FROMDATE,'')='" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "' AND ISNULL(REMINDERNO,0)=" & CMBLETERNO.Text & " AND ISNULL(BALANCE,0)+ISNULL(P_BALANCE,0)+ISNULL(G_BALANCE,0)>0 AND ISNULL(VOID,'')<>'Y' ORDER BY mcode,len(mcode)"
            End If
            gconnection.getDataSet(ssql, "DeptMst")

            If gdataset.Tables("DeptMst").Rows.Count > 0 Then
                GRID_REMINDER.Rows.Add(gdataset.Tables("DeptMst").Rows.Count - 1)
                For I = 0 To gdataset.Tables("DeptMst").Rows.Count - 1

                    With GRID_REMINDER

                        GRID_REMINDER.Rows(I).Cells(0).Value = gdataset.Tables("DeptMst").Rows(I).Item("mcode")

                        GRID_REMINDER.Rows(I).Cells(1).Value = gdataset.Tables("DeptMst").Rows(I).Item("mname")
                        GRID_REMINDER.Rows(I).Cells(2).Value = gdataset.Tables("DeptMst").Rows(I).Item("balance")

                        Dim senior As DataGridViewCheckBoxCell = New DataGridViewCheckBoxCell


                        GRID_REMINDER.Rows(I).Cells(3).Value = True



                    End With
                Next I
            End If


            'ss= ""
            'gconnection.GetValues(ssql)
        End If

        Exit Sub
    End Sub

    Private Sub Summary2()
        Dim DT As New DataTable
        Dim I As Integer
        Dim vSql As Object
        Dim month1 As Object
        Dim Loopindex As Object
        Dim vtype() As Object
        Dim VTYPE1 As String
        Dim vsplit() As String
        Dim ssql, appcode() As String
        Try

            If txt_docno.Text <> "" Or txt_docno.Enabled = False Then
                If CMBLETERNO.Text = "1" Then

                    If Cmb_ReminderType.Text = "MEMBER" Then
                        ssql = ""
                        ssql = "SELECT REFNO_DET,MCODE,MNAME,BALANCE,SALUT,CONTCELL FROM MM_REMINDERHISTORY WHERE ISNULL(FROMDATE,'')='" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "' AND ISNULL(DOCNO,0)=" & txt_docno.Text & " AND ISNULL(VOID,'')<>'Y' ORDER BY MCODE"
                        gconnection.GetValues(ssql)
                    ElseIf Cmb_ReminderType.Text = "PARTY" Then
                        ssql = ""
                        ssql = "SELECT REFNO_DET,MCODE,MNAME,P_BALANCE AS BALANCE,SALUT,CONTCELL FROM MM_REMINDERHISTORY WHERE ISNULL(FROMDATE,'')='" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "' AND ISNULL(DOCNO,0)=" & txt_docno.Text & " AND ISNULL(VOID,'')<>'Y' ORDER BY MCODE"
                        gconnection.GetValues(ssql)
                    ElseIf Cmb_ReminderType.Text = "CHAMBER" Then
                        ssql = ""
                        ssql = "SELECT REFNO_DET,MCODE,MNAME,G_BALANCE AS BALANCE,SALUT,CONTCELL FROM MM_REMINDERHISTORY WHERE ISNULL(FROMDATE,'')='" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "' AND ISNULL(DOCNO,0)=" & txt_docno.Text & " AND ISNULL(VOID,'')<>'Y' ORDER BY MCODE"
                        gconnection.GetValues(ssql)


                    End If
                Else
                    ssql = "SELECT REFNO_DET,MCODE,MNAME,BALANCE AS BALANCE,SALUT,CONTCELL FROM MM_REMINDERHISTORY WHERE ISNULL(FROMDATE,'')='" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "' AND ISNULL(DOCNO,0)=" & txt_docno.Text & " AND ISNULL(VOID,'')<>'Y' ORDER BY MCODE"
                    gconnection.GetValues(ssql)
                End If
                Dim Viewer As New REPORTVIEWER

                Dim r As New Remainder1Summary
                Dim r1 As New Remainder1Summary
                Dim r2 As New Remainder1Summary

                If Mid(Me.dtpASNODATE.Text, 4, 2) = "04" Then bill = "April " & Mid(gFinancalyearStart, 1, 4)
                If Mid(Me.dtpASNODATE.Text, 4, 2) = "05" Then bill = "May " & Mid(gFinancalyearStart, 1, 4)
                If Mid(Me.dtpASNODATE.Text, 4, 2) = "06" Then bill = "June " & Mid(gFinancalyearStart, 1, 4)
                If Mid(Me.dtpASNODATE.Text, 4, 2) = "07" Then bill = "July " & Mid(gFinancalyearStart, 1, 4)
                If Mid(Me.dtpASNODATE.Text, 4, 2) = "08" Then bill = "August " & Mid(gFinancalyearStart, 1, 4)
                If Mid(Me.dtpASNODATE.Text, 4, 2) = "09" Then bill = "September " & Mid(gFinancalyearStart, 1, 4)
                If Mid(Me.dtpASNODATE.Text, 4, 2) = "10" Then bill = "October " & Mid(gFinancalyearStart, 1, 4)
                If Mid(Me.dtpASNODATE.Text, 4, 2) = "11" Then bill = "November " & Mid(gFinancalyearStart, 1, 4)
                If Mid(Me.dtpASNODATE.Text, 4, 2) = "12" Then bill = "December " & Mid(gFinancalyearStart, 1, 4)
                If Mid(Me.dtpASNODATE.Text, 4, 2) = "01" Then bill = "January " & Mid(gFinancialyearEnd, 1, 4)
                If Mid(Me.dtpASNODATE.Text, 4, 2) = "02" Then bill = "February " & Mid(gFinancialyearEnd, 1, 4)
                If Mid(Me.dtpASNODATE.Text, 4, 2) = "03" Then bill = "March  " & Mid(gFinancialyearEnd, 1, 4)
                Viewer.ssql = ssql

                If CMBLETERNO.Text = "1" Then
                    Viewer.Report = r


                ElseIf CMBLETERNO.Text = "2" Then

                    Viewer.Report = r1
                ElseIf CMBLETERNO.Text = "3" Then

                    Viewer.Report = r2
                End If
                'txtobj1 = r.ReportDefinition.ReportObjects("Text5")
                'txtobj1.Text = UCase(gcompanyname)
                'txtobj1 = r.ReportDefinition.ReportObjects("Text7")
                'txtobj1.Text = UCase(gCompanyAddress(1))
                'txtobj1 = r.ReportDefinition.ReportObjects("Text8")
                'txtobj1.Text = UCase(gCompanyAddress(2))
                'txtobj1 = r.ReportDefinition.ReportObjects("Text10")
                'txtobj1.Text = UCase(gCompanyAddress(3))
                'txtobj1 = r1.ReportDefinition.ReportObjects("Text5")
                'txtobj1.Text = UCase(gCompanyname)
                'txtobj1 = r1.ReportDefinition.ReportObjects("Text7")
                'txtobj1.Text = UCase(gCompanyAddress(1))
                'txtobj1 = r1.ReportDefinition.ReportObjects("Text8")
                'txtobj1.Text = UCase(gCompanyAddress(2))
                'txtobj1 = r1.ReportDefinition.ReportObjects("Text10")
                'txtobj1.Text = UCase(gCompanyAddress(3))
                'txtobj1 = r3.ReportDefinition.ReportObjects("Text3")
                'txtobj1.Text = UCase(gCompanyname)
                'txtobj1 = r3.ReportDefinition.ReportObjects("Text4")
                'txtobj1.Text = UCase(gCompanyAddress(1))

                'txtobj1 = r.ReportDefinition.ReportObjects("Text12")
                'txtobj1.Text = dtpASNODATE.Text
                '' txtobj1 = r.ReportDefinition.ReportObjects("Text14")
                ''txtobj1.Text = bill
                'txtobj1 = r1.ReportDefinition.ReportObjects("Text14")
                'txtobj1.Text = bill
                ' 'txtobj1 = r.ReportDefinition.ReportObjects("Text16")
                ''txtobj1.Text = Dtp_rem.Value
                'txtobj1 = r1.ReportDefinition.ReportObjects("Text18")
                'txtobj1.Text = Dtp_rem.Value

                Viewer.TableName = "MM_REMINDERHISTORY"
                Viewer.Show()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Exit Sub
    End Sub

    Private Sub abv_10000_lttr_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub reminder_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            If BTNSCREEN.Enabled = True Then
                BTNSCREEN_Click(sender, e)
            End If
        End If
        If e.KeyCode = Keys.F6 Then
            If BTNPRINT.Enabled = True Then
                BTNPRINT_Click(sender, e)
            End If
        End If
        If e.KeyCode = Keys.F11 Then
            Btn_close_Click(sender, e)
        End If
        If e.KeyCode = Keys.F7 Then
            Button1_Click(sender, e)
        End If
    End Sub


    Private Sub CMBLETERNO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBLETERNO.SelectedIndexChanged
        PLoad()
    End Sub
    Public Sub PLoad()
        Dim sql As String
        If CMBLETERNO.Text = "1" Then
            DTP_FIRST.Text = "LETTER DATED"
        ElseIf CMBLETERNO.Text = "2" Then
            DTP_FIRST.Text = "MEETING DATED"
        End If
        'sql = "Select convert(varchar,getdate()-25,103) as CDate"


        'ElseIf CMBLETERNO.Text = "2" Then
        '    sql = "Select convert(varchar,getdate()-60,103) as CDate"

        'ElseIf CMBLETERNO.Text = "3" Then
        '    sql = "Select convert(varchar,getdate()-70,103) as CDate"

        'ElseIf CMBLETERNO.Text = "4" Then
        '    sql = "Select convert(varchar,getdate()-100,103) as CDate"


        'End If
        'posting = gconnection.GetValues(sql)
        'If posting.Rows.Count > 0 Then
        '    dtpASNODATE.Value = (posting.Rows(0).Item("CDate"))

        'End If
    End Sub
    Public Sub ParameterString(ByVal chkcat As String, ByVal bdate As String, ByVal rdate As String)
        Dim I As Integer
        Dim category, categoryall As String
        'For I = 0 To CHKCATEGORY.CheckedItems.Count - 1
        '    category = Split(CHKCATEGORY.CheckedItems(I))
        '    categoryall =  '" & category(0) & "', "
        'Next



    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub
    Private Sub Dtp_CutOffDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dtp_CutOffDate.ValueChanged

    End Sub
    Private Sub TXTMCODEFrom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub TXTMCODETO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTMCODETO.TextChanged

    End Sub
    Private Sub letterno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letterno.Click

    End Sub
    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub dtpASNODATE_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpASNODATE.ValueChanged
        TXT_REFNO.Text = ""
        TXT_REFNO.Text = "Ref: BILLS/" + Format(dtpASNODATE.Value, "MMM") + "/" + Format(dtpASNODATE.Value, "yyyy")
    End Sub
    Private Sub Txt_CreditLimit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_CreditLimit.TextChanged

    End Sub
    Private Sub Cmb_ReminderType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_ReminderType.SelectedIndexChanged

    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cmd_MCodefromHelp_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MCodefromHelp.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTP_FIRST.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'If Button1.Text = "SMS" Then
        Dim DT As New DataTable
        Dim I As Integer
        Dim vSql As Object
        Dim month1 As Object
        Dim Loopindex As Object
        Dim vtype() As Object
        Dim VTYPE1, bill As String
        Dim vsplit() As String
        Dim ssql, appcode() As String
        Dim LAST As DateTime
        Dim cmonth, pmonth, CATEGORY As String

        vSql = ""
        LAST = DateAdd(DateInterval.Month, -1, dtpASNODATE.Value)
        sqlString = "SELECT dbo.[ufn_GetLastDayOfMonth]('" & Format(LAST, "yyyy-MM-dd") & "')"
        gconnection.getDataSet(sqlString, "mem")
        If gdataset.Tables("mem").Rows.Count > 0 Then
            LAST = gdataset.Tables("mem").Rows(0).Item(0)

        End If
        cmonth = Format(dtpASNODATE.Value, "MMM")
        pmonth = Format(LAST, "MMM")


        For I = 0 To CHKCATEGORY.CheckedItems.Count - 1
            appcode = Split(CHKCATEGORY.CheckedItems(I), ".")
            CATEGORY = CATEGORY & " '" & appcode(0) & "', "
        Next
        CATEGORY = Mid(CATEGORY, 1, Len(CATEGORY) - 2)
        vSql = "EXEC cp_creditlimit_REMINDER  '" & Format(dtpASNODATE.Value, "dd/MMM/yyyy") & "','" & Format(Dtp_CutOffDate.Value, "dd/MMM/yyyy") & "','" & Format(LAST, "dd/MMM/yyyy") & "','" & cmonth & "','" & pmonth & "','N','" & CMBLETERNO.Text & "'"
        'vSql = "EXEC TP_OUTSTANDING_SUMMARY  " & "'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "','" & Format(dtpASNODATE.Value, "dd-MMM-yyyy") & "'"
        gconnection.GetValues(vSql)
        ssql = ""
        ssql = "DELETE FROM REMINDERHISTORY_SMS"
        gconnection.GetValues(ssql)
        ssql = ""

        ssql = "insert into reminderhistory_SMS(docno,docdate,membertypecode,mcode,mname,fromdate,todate,balance,reminderdate,adduser,adddatetime,reminderno,asondate,creditlimit,REFNO,REFNO_DET,CMONTH,PMONTH,PUSAGE)"
        ssql = ssql & " select '" & docno & "','" & Format(dtp_docdate.Value, "yyyy-MM-dd") & "',MEMBERTYPECODE,mcode,MNAME,'" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "','" & Format(Dtp_CutOffDate.Value, "yyyy-MM-dd") & "',USAGE,'" & Format(Dtp_rem.Value, "yyyy-MM-dd") & "','" & gUsername & "','" & Format(Now(), "yyyy-MM-dd HH:MM") & "','" & CMBLETERNO.Text & "','" & Format(Dtp_Last.Value, "yyyy-MM-dd") & "'," & Txt_CreditLimit.Text & ",'" & TXT_REFNO.Text & "',REF_ORDER,CMONTH,PMONTH,PUSAGE from VIEW_MEM_CREDIT_REMINDER where  isnull(USAGE,0) >= " & Format(Val(Txt_CreditLimit.Text), "0.00") & " AND "
        ssql = ssql & " isnull(MEMBERTYPECODE,'') in ("
        'vSql = vSql & " isnull(MT.TypeDesc,'') in ("
        For I = 0 To CHKCATEGORY.CheckedItems.Count - 1
            appcode = Split(CHKCATEGORY.CheckedItems(I), ".")
            ssql = ssql & " '" & appcode(0) & "', "
        Next

        ssql = Mid(ssql, 1, Len(ssql) - 2)
        ssql = ssql & ") "
        gconnection.GetValues(ssql)
        ssql = "SELECT FROMDATE,TODATE,ASONDATE,MEMBERTYPECODE,BALANCE,MCODE,MNAME,REMINDERDATE,ADDUSER,ADDDATETIME,VOID,VOIDUSER,VOIDDATETIME,DOCNO,DOCDATE,REMINDERNO,CREDITLIMIT,REFNO,CAST(REFNO_DET AS VARCHAR) AS REFNO_DET,CMONTH,PMONTH,PUSAGE,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTCOUNTRY,CONTEMAIL,CONTSTATE,CONTCELL,CONTPIN,CONTPHONE1,CONTPHONE2,MEMBERTYPE,SALUT FROM MM_REMINDERHISTORY_SMS ORDER BY LEN(REFNO_DET),REFNO_DET"
        gconnection.GetValues(ssql)
        'ss= ""
        'gconnection.GetValues(ssql)

        Dim Viewer As New REPORTVIEWER

        Dim r As New Remainder1Summary
        Dim r1 As New Reminder2
        Dim r2 As New Reminder3

        If Mid(Me.dtpASNODATE.Text, 4, 2) = "04" Then bill = "April " & Mid(gFinancalyearStart, 1, 4)
        If Mid(Me.dtpASNODATE.Text, 4, 2) = "05" Then bill = "May " & Mid(gFinancalyearStart, 1, 4)
        If Mid(Me.dtpASNODATE.Text, 4, 2) = "06" Then bill = "June " & Mid(gFinancalyearStart, 1, 4)
        If Mid(Me.dtpASNODATE.Text, 4, 2) = "07" Then bill = "July " & Mid(gFinancalyearStart, 1, 4)
        If Mid(Me.dtpASNODATE.Text, 4, 2) = "08" Then bill = "August " & Mid(gFinancalyearStart, 1, 4)
        If Mid(Me.dtpASNODATE.Text, 4, 2) = "09" Then bill = "September " & Mid(gFinancalyearStart, 1, 4)
        If Mid(Me.dtpASNODATE.Text, 4, 2) = "10" Then bill = "October " & Mid(gFinancalyearStart, 1, 4)
        If Mid(Me.dtpASNODATE.Text, 4, 2) = "11" Then bill = "November " & Mid(gFinancalyearStart, 1, 4)
        If Mid(Me.dtpASNODATE.Text, 4, 2) = "12" Then bill = "December " & Mid(gFinancalyearStart, 1, 4)
        If Mid(Me.dtpASNODATE.Text, 4, 2) = "01" Then bill = "January " & Mid(gFinancialyearEnd, 1, 4)
        If Mid(Me.dtpASNODATE.Text, 4, 2) = "02" Then bill = "February " & Mid(gFinancialyearEnd, 1, 4)
        If Mid(Me.dtpASNODATE.Text, 4, 2) = "03" Then bill = "March  " & Mid(gFinancialyearEnd, 1, 4)
        Viewer.ssql = ssql

        If CMBLETERNO.Text = "1" Then
            Viewer.Report = r


        ElseIf CMBLETERNO.Text = "2" Then

            Viewer.Report = r1
        ElseIf CMBLETERNO.Text = "3" Then

            Viewer.Report = r2
        End If
        txtobj1 = r.ReportDefinition.ReportObjects("Text3")
        txtobj1.Text = "REMINDER AS ON " & Format(dtpASNODATE.Value, "dd/MMM/yyyy")


        Viewer.TableName = "MM_REMINDERHISTORY"
        Viewer.Show()
        GRP_SMS.Visible = True
        Dim checked As String
        Dim SSQL3 As String
        SSQL3 = "SELECT FROMDATE,TODATE,ASONDATE,MEMBERTYPECODE,BALANCE,MCODE,MNAME,REMINDERDATE,ADDUSER,ADDDATETIME,VOID,VOIDUSER,VOIDDATETIME,DOCNO,DOCDATE,REMINDERNO,CREDITLIMIT,REFNO,CAST(REFNO_DET AS VARCHAR) AS REFNO_DET,CMONTH,PMONTH,PUSAGE,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTCOUNTRY,CONTEMAIL,CONTSTATE,CONTCELL,CONTPIN,CONTPHONE1,CONTPHONE2,MEMBERTYPE,SALUT FROM MM_REMINDERHISTORY_SMS ORDER BY len(refno_det),REFNO_DET"
        gconnection.getDataSet(ssql, "DeptMst")

        If gdataset.Tables("DeptMst").Rows.Count > 0 Then
            GRID_SMS.Rows.Add(gdataset.Tables("DeptMst").Rows.Count - 1)
            For I = 0 To gdataset.Tables("DeptMst").Rows.Count - 1

                With GRP_SMS

                    GRID_SMS.Rows(I).Cells(0).Value = gdataset.Tables("DeptMst").Rows(I).Item("mcode")

                    GRID_SMS.Rows(I).Cells(1).Value = gdataset.Tables("DeptMst").Rows(I).Item("mname")
                    GRID_SMS.Rows(I).Cells(2).Value = gdataset.Tables("DeptMst").Rows(I).Item("CONTCELL")
                    GRID_SMS.Rows(I).Cells(3).Value = gdataset.Tables("DeptMst").Rows(I).Item("BALANCE")
                    GRID_SMS.Rows(I).Cells(4).Value = gdataset.Tables("DeptMst").Rows(I).Item("FROMDATE")
                    Dim senior As DataGridViewCheckBoxCell = New DataGridViewCheckBoxCell
                    GRID_SMS.Rows(I).Cells(5).Value = True



                End With
            Next I
        End If



        ' End If
        'Dim mcode, SSQL1 As String
        'Dim fromdate, mobile As String
        'Dim amount As Double
        'If Button1.Text = "SEND SMS" Then
        '    SSQL1 = "SELECT FROMDATE,TODATE,ASONDATE,MEMBERTYPECODE,BALANCE,MCODE,MNAME,REMINDERDATE,ADDUSER,ADDDATETIME,VOID,VOIDUSER,VOIDDATETIME,DOCNO,DOCDATE,REMINDERNO,CREDITLIMIT,REFNO,CAST(REFNO_DET AS VARCHAR) AS REFNO_DET,CMONTH,PMONTH,PUSAGE,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTCOUNTRY,CONTEMAIL,CONTSTATE,CONTCELL,CONTPIN,CONTPHONE1,CONTPHONE2,MEMBERTYPE,SALUT FROM MM_REMINDERHISTORY_SMS ORDER BY len(refno_det),REFNO_DET"
        '    gconnection.getDataSet(SSQL1, "sms")
        '    If gdataset.Tables("sms").Rows.Count > 0 Then
        '        For I = 0 To gdataset.Tables("sms").Rows.Count - 1
        '            mcode = gdataset.Tables("sms").Rows(I).Item("mcode")
        '            fromdate = Format(gdataset.Tables("SMS").Rows(I).Item("FROMDATE"), "MMM yyyy")
        '            mobile = gdataset.Tables("sms").Rows(I).Item("contcell")
        '            amount = Val(gdataset.Tables("sms").Rows(I).Item("BALANCE"))
        '            If mobile <> "" Then
        '                Call gconnection.SMS_rem(mcode, fromdate, mobile, amount)
        '            End If


        '        Next
        '    End If
        'End If

        '  Button1.Text = "SMS"

    End Sub





    Private Sub btn_clear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_clear.Click
        btn_Revert.Enabled = False
        chk_PrintAll.Checked = False
        txt_docno.Enabled = True
        dtp_docdate.Enabled = True
        GRP_SMS.Visible = False
        Button6.Enabled = False
        Button1.Text = "SMS"
        Label13.Text = ""
        txt_docno.Text = ""
        TXT_REFNO.Text = ""
        'Txt_CreditLimit.Text = ""
        posting = Nothing
        Dtp_Last.Value = Now()
        Dtp_rem.Value = Now()
        sqlString = "select ISNULL(MAX(ISNULL(DOCNO,0)),0) AS DOCNO FROM reminderhistory "
        posting = gconnection.GetValues(sqlString)
        If posting.Rows.Count = 1 Then
            Label12.Text = "Last Doc No.is " & posting.Rows(0).Item("docno")
        Else
            Label12.Text = "Last Doc No.is 0"
        End If

    End Sub
    Private Sub txt_docno_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_docno.KeyPress
        If Asc(e.KeyChar) = 13 And Trim(Me.txt_docno.Text) <> "" Then
            Call getreminder()
        End If
    End Sub
    Private Sub getreminder()
        Dim SSQL As String
        Dim FREEZE As String
        If txt_docno.Text <> "" Then
            SSQL = "SELECT ISNULL(CREDITLIMIT,0) AS CREDITLIMIT,reminderno,FROMDATE,REFNO,TODATE,ISNULL(TYPE,'') AS TYPE,ASONDATE,MEMBERTYPECODE,ISNULL(BALANCE,0) AS BALANCE,ISNULL(G_BALANCE,0) AS G_BALANCE,ISNULL(P_BALANCE,0) AS P_BALANCE,REMINDERDATE,DOCDATE,ASONDATE,ISNULL(VOID,'') as void,VOIDUSER,VOIDDATETIME FROM REMINDERHISTORY WHERE DOCNO=" & txt_docno.Text & ""
            gconnection.getDataSet(SSQL, "REMINDER")
            If gdataset.Tables("REMINDER").Rows.Count > 0 Then
                If gdataset.Tables("REMINDER").Rows(0).Item("VOID") = "Y" Then
                    Label13.Text = "RECORD IS VOIDED ON " & gdataset.Tables("REMINDER").Rows(0).Item("VOIDDATETIME")
                    CMBLETERNO.Text = gdataset.Tables("REMINDER").Rows(0).Item("REMINDERNO")
                    If CMBLETERNO.Text = "1" Then
                        If gdataset.Tables("REMINDER").Rows(0).Item("TYPE") = "MEMBER" Then
                            Cmb_ReminderType.Text = "MEMBER"
                        ElseIf gdataset.Tables("REMINDER").Rows(0).Item("TYPE") = "NRI MEMBER" Then
                            'Cmb_ReminderType.Text = "PARTY"
                            Cmb_ReminderType.Text = "NRI MEMBER"
                        ElseIf gdataset.Tables("REMINDER").Rows(0).Item("TYPE") = "CHAMBER" Then
                            Cmb_ReminderType.Text = "CHAMBER"
                        End If
                    Else
                        Cmb_ReminderType.Text = "MEMBER"
                    End If
                    dtpASNODATE.Text = Format(gdataset.Tables("REMINDER").Rows(0).Item("fromdate"), "dd/MM/yyyy")
                    Dtp_CutOffDate.Text = Format(gdataset.Tables("REMINDER").Rows(0).Item("todate"), "dd/MM/yyyy")
                    Dtp_Last.Text = Format(gdataset.Tables("REMINDER").Rows(0).Item("asondate"), "dd/MM/yyyy")
                    Dtp_rem.Text = Format(gdataset.Tables("REMINDER").Rows(0).Item("reminderdate"), "dd/MM/yyyy")
                    Txt_CreditLimit.Text = gdataset.Tables("REMINDER").Rows(0).Item("creditlimit")
                    TXT_REFNO.Text = gdataset.Tables("REMINDER").Rows(0).Item("REFNO")
                    btn_Revert.Enabled = False
                    txt_docno.Enabled = False
                    dtp_docdate.Enabled = False
                    Button6.Enabled = False
                Else
                    CMBLETERNO.Text = gdataset.Tables("REMINDER").Rows(0).Item("REMINDERNO")
                    If CMBLETERNO.Text = "1" Then
                        If Val(gdataset.Tables("REMINDER").Rows(0).Item("BALANCE")) > 0 Then
                            Cmb_ReminderType.Text = "MEMBER"
                        ElseIf Val(gdataset.Tables("REMINDER").Rows(0).Item("P_BALANCE")) > 0 Then
                            Cmb_ReminderType.Text = "NRI MEMBER"
                        ElseIf Val(gdataset.Tables("REMINDER").Rows(0).Item("G_BALANCE")) > 0 Then
                            Cmb_ReminderType.Text = "CHAMBER"
                        End If
                    Else
                        Cmb_ReminderType.Text = "MEMBER"
                    End If
                    dtpASNODATE.Text = Format(gdataset.Tables("REMINDER").Rows(0).Item("fromdate"), "dd/MM/yyyy")
                    Dtp_CutOffDate.Text = Format(gdataset.Tables("REMINDER").Rows(0).Item("todate"), "dd/MM/yyyy")
                    Dtp_Last.Text = Format(gdataset.Tables("REMINDER").Rows(0).Item("asondate"), "dd/MM/yyyy")
                    Dtp_rem.Text = Format(gdataset.Tables("REMINDER").Rows(0).Item("reminderdate"), "dd/MM/yyyy")
                    Txt_CreditLimit.Text = gdataset.Tables("REMINDER").Rows(0).Item("creditlimit")
                    TXT_REFNO.Text = gdataset.Tables("REMINDER").Rows(0).Item("REFNO")
                    btn_Revert.Enabled = True
                    txt_docno.Enabled = False
                    dtp_docdate.Enabled = False
                    Button6.Enabled = True
                End If
            End If
        End If
        TXT_REFNO.Text = ""
        TXT_REFNO.Text = "Ref: BILLS/" + Format(dtpASNODATE.Value, "MMM") + "/" + Format(dtpASNODATE.Value, "yyyy")

    End Sub

    Private Sub btn_Revert_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Revert.Click
        Dim SSQL As String
        SSQL = "SELECT reminderno,FROMDATE,TODATE,ASONDATE,MEMBERTYPECODE,REMINDERDATE,DOCDATE,ASONDATE,ISNULL(VOID,'') as void,VOIDUSER,VOIDDATETIME FROM REMINDERHISTORY WHERE DOCNO=" & txt_docno.Text & ""
        gconnection.getDataSet(SSQL, "REMINDER")
        If gdataset.Tables("REMINDER").Rows.Count > 0 Then
            If gdataset.Tables("REMINDER").Rows(0).Item("VOID") = "Y" Then
            Else
                SSQL = "UPDATE REMINDERHISTORY SET VOID='Y',VOIDDATETIME='" & Format(Now(), "yyyy-MM-dd HH:MM") & "',VOIDUSER='" & gUsername & "' WHERE DOCNO=" & txt_docno.Text & ""
                gconnection.GetValues(SSQL)
                MessageBox.Show("Record is Voided Successfully")
            End If
        End If
        Me.Close()

    End Sub

    Private Sub RBTREMINDERSUMMARY_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RBTREMINDERSUMMARY.CheckedChanged
        RBTREMINDERADDRESS.Checked = False
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles GroupBox3.Enter

    End Sub
    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Dim DT As New DataTable
        Dim I As Integer
        Dim vSql As Object
        Dim month1 As Object
        Dim Loopindex As Object
        Dim vtype() As Object
        Dim CHECK As Boolean
        Dim VTYPE1, bill, mcode As String
        Dim vsplit() As String
        Dim ssql, appcode() As String
        Dim LAST As DateTime
        Dim cmonth, pmonth, CATEGORY As String
        posting1 = Nothing
        sqlString = "select ISNULL(MAX(ISNULL(DOCNO,0)),0)+1 AS DOCNO FROM reminderhistory "
        posting1 = gconnection.GetValues(sqlString)
        If posting1.Rows.Count = 1 Then
            docno = posting1.Rows(0).Item("docno")
        Else
            docno = 1
        End If
        Try
            For I = 0 To GRID_REMINDER.Rows.Count - 1

                'GRID_REMINDER.Rows.Add(gdataset.Tables("DeptMst").Rows.Count)
                With GRID_REMINDER
                    CHECK = GRID_REMINDER.Rows(I).Cells(3).Value
                    If CHECK = False Then
                        mcode = mcode & "'" & GRID_REMINDER.Rows(I).Cells(0).Value & "',"
                    End If
                End With
            Next I
            If Len(mcode) >= 1 Then
                mcode = mcode.Substring(0, mcode.Length - 1)
                vSql = "DELETE FROM CREDITSTOP_MCODE_REMINDER WHERE MCODE IN(" & mcode & ")"
                gconnection.GetValues(vSql)
            End If

            vSql = ""

            For I = 0 To CHKCATEGORY.CheckedItems.Count - 1
                appcode = Split(CHKCATEGORY.CheckedItems(I), ".")
                CATEGORY = CATEGORY & " '" & appcode(0) & "', "
            Next
            CATEGORY = Mid(CATEGORY, 1, Len(CATEGORY) - 2)
            GroupBox3.Visible = False
            'vSql = "EXEC cp_creditlimit_REMINDER  '" & Format(dtpASNODATE.Value, "dd/MMM/yyyy") & "','" & Format(Dtp_CutOffDate.Value, "dd/MMM/yyyy") & "','Y','" & CMBLETERNO.Text & "'"
            ''vSql = "EXEC TP_OUTSTANDING_SUMMARY  " & "'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "','" & Format(dtpASNODATE.Value, "dd-MMM-yyyy") & "'"
            'gconnection.GetValues(vSql)
            'If Cmb_ReminderType.Text = "MEMBER" Then
            '    vSql = "EXEC cp_creditlimit_REMINDER  '" & Format(dtpASNODATE.Value, "dd/MMM/yyyy") & "','" & Format(Dtp_CutOffDate.Value, "dd/MMM/yyyy") & "','N','" & CMBLETERNO.Text & "'"
            '    'vSql = "EXEC TP_OUTSTANDING_SUMMARY  " & "'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "','" & Format(dtpASNODATE.Value, "dd-MMM-yyyy") & "'"
            '    gconnection.GetValues(vSql)
            'Else
            '    vSql = "EXEC cp_creditlimit_REMINDER_Doller  '" & Format(dtpASNODATE.Value, "dd/MMM/yyyy") & "','" & Format(Dtp_CutOffDate.Value, "dd/MMM/yyyy") & "','N','" & CMBLETERNO.Text & "'"
            '    'vSql = "EXEC TP_OUTSTANDING_SUMMARY  " & "'" & Format(Dtp_CutOffDate.Value, "dd-MMM-yyyy") & "','" & Format(dtpASNODATE.Value, "dd-MMM-yyyy") & "'"
            '    gconnection.GetValues(vSql)
            'End If

            ssql = ""
            If CMBLETERNO.Text = "1" Then
                If Cmb_ReminderType.Text = "MEMBER" Then
                    ssql = "insert into reminderhistory(docno,docdate,membertypecode,mcode,mname,fromdate,todate,balance,reminderdate,adduser,adddatetime,reminderno,asondate,creditlimit,REFNO,REFNO_DET,CMONTH,PMONTH,PUSAGE,TYPE,g_balance)"
                    ssql = ssql & " select '" & docno & "','" & Format(dtp_docdate.Value, "yyyy-MM-dd") & "',MEMBERTYPECODE,mcode,MNAME,'" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "','" & Format(Dtp_CutOffDate.Value, "yyyy-MM-dd") & "',USAGE,'" & Format(Dtp_rem.Value, "yyyy-MM-dd") & "','" & gUsername & "','" & Format(Now(), "yyyy-MM-dd HH:MM") & "','" & CMBLETERNO.Text & "','" & Format(Dtp_Last.Value, "yyyy-MM-dd") & "'," & Txt_CreditLimit.Text & ",'" & TXT_REFNO.Text & "',REF_ORDER,CMONTH,PMONTH,PUSAGE,'MEMBER',G_USAGE from VIEW_MEM_CREDIT_REMINDER where  isnull(USAGE,0) >= " & Format(Val(Txt_CreditLimit.Text), "0.00") & " AND "
                    ssql = ssql & " isnull(MEMBERTYPECODE,'') in ("
                    'vSql = vSql & " isnull(MT.TypeDesc,'') in ("
                    For I = 0 To CHKCATEGORY.CheckedItems.Count - 1
                        appcode = Split(CHKCATEGORY.CheckedItems(I), ".")
                        ssql = ssql & " '" & appcode(0) & "', "
                    Next

                    ssql = Mid(ssql, 1, Len(ssql) - 2)
                    ssql = ssql & ") "
                    gconnection.GetValues(ssql)
                    ssql = "SELECT FROMDATE,TODATE,ASONDATE,MEMBERTYPECODE,BALANCE,MCODE,MNAME,REMINDERDATE,ADDUSER,ADDDATETIME,VOID,VOIDUSER,VOIDDATETIME,DOCNO,DOCDATE,REMINDERNO,CREDITLIMIT,REFNO,CAST(REFNO_DET AS VARCHAR) AS REFNO_DET,CMONTH,PMONTH,PUSAGE,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTCOUNTRY,CONTEMAIL,CONTSTATE,CONTCELL,CONTPIN,CONTPHONE1,CONTPHONE2,MEMBERTYPE,SALUT,g_balance FROM MM_REMINDERHISTORY_BILL WHERE ISNULL(FROMDATE,'')='" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "' AND ISNULL(REMINDERNO,0)=" & CMBLETERNO.Text & " AND ISNULL(BALANCE,0)>0 AND ISNULL(VOID,'')<>'Y' ORDER BY MCODE"
                    gconnection.GetValues(ssql)
                    'ElseIf Cmb_ReminderType.Text = "PARTY" Then
                ElseIf Cmb_ReminderType.Text = "NRI MEMBER" Then
                    ssql = "insert into reminderhistory(docno,docdate,membertypecode,mcode,mname,fromdate,todate,P_balance,reminderdate,adduser,adddatetime,reminderno,asondate,creditlimit,REFNO,REFNO_DET,CMONTH,PMONTH,PUSAGE,TYPE,g_balance)"
                    ssql = ssql & " select '" & docno & "','" & Format(dtp_docdate.Value, "yyyy-MM-dd") & "',MEMBERTYPECODE,mcode,MNAME,'" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "','" & Format(Dtp_CutOffDate.Value, "yyyy-MM-dd") & "',P_USAGE,'" & Format(Dtp_rem.Value, "yyyy-MM-dd") & "','" & gUsername & "','" & Format(Now(), "yyyy-MM-dd HH:MM") & "','" & CMBLETERNO.Text & "','" & Format(Dtp_Last.Value, "yyyy-MM-dd") & "'," & Txt_CreditLimit.Text & ",'" & TXT_REFNO.Text & "',REF_ORDER,CMONTH,PMONTH,PUSAGE,'NRI MEMBER',G_USAGE from VIEW_MEM_CREDIT_REMINDER where  isnull(P_USAGE,0) >= " & Format(Val(Txt_CreditLimit.Text), "0.00") & " AND "
                    ssql = ssql & " isnull(MEMBERTYPECODE,'') in ("
                    'vSql = vSql & " isnull(MT.TypeDesc,'') in ("
                    For I = 0 To CHKCATEGORY.CheckedItems.Count - 1
                        appcode = Split(CHKCATEGORY.CheckedItems(I), ".")
                        ssql = ssql & " '" & appcode(0) & "', "
                    Next

                    ssql = Mid(ssql, 1, Len(ssql) - 2)
                    ssql = ssql & ") "
                    gconnection.GetValues(ssql)
                    ssql = "SELECT FROMDATE,TODATE,ASONDATE,MEMBERTYPECODE,P_BALANCE AS BALANCE,MCODE,MNAME,REMINDERDATE,ADDUSER,ADDDATETIME,VOID,VOIDUSER,VOIDDATETIME,DOCNO,DOCDATE,REMINDERNO,CREDITLIMIT,REFNO,CAST(REFNO_DET AS VARCHAR) AS REFNO_DET,CMONTH,PMONTH,PUSAGE,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTCOUNTRY,CONTEMAIL,CONTSTATE,CONTCELL,CONTPIN,CONTPHONE1,CONTPHONE2,MEMBERTYPE,SALUT,g_balance FROM MM_REMINDERHISTORY_BILL WHERE ISNULL(FROMDATE,'')='" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "' AND ISNULL(REMINDERNO,0)=" & CMBLETERNO.Text & " AND ISNULL(P_BALANCE,0)>0 AND ISNULL(VOID,'')<>'Y' ORDER BY MCODE"
                    gconnection.GetValues(ssql)
                ElseIf Cmb_ReminderType.Text = "CHAMBER" Then
                    ssql = "insert into reminderhistory(docno,docdate,membertypecode,mcode,mname,fromdate,todate,G_balance,reminderdate,adduser,adddatetime,reminderno,asondate,creditlimit,REFNO,REFNO_DET,CMONTH,PMONTH,PUSAGE,TYPE)"
                    ssql = ssql & " select '" & docno & "','" & Format(dtp_docdate.Value, "yyyy-MM-dd") & "',MEMBERTYPECODE,mcode,MNAME,'" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "','" & Format(Dtp_CutOffDate.Value, "yyyy-MM-dd") & "',G_USAGE,'" & Format(Dtp_rem.Value, "yyyy-MM-dd") & "','" & gUsername & "','" & Format(Now(), "yyyy-MM-dd HH:MM") & "','" & CMBLETERNO.Text & "','" & Format(Dtp_Last.Value, "yyyy-MM-dd") & "'," & Txt_CreditLimit.Text & ",'" & TXT_REFNO.Text & "',REF_ORDER,CMONTH,PMONTH,PUSAGE,'CHAMBER' from VIEW_MEM_CREDIT_REMINDER where  isnull(G_USAGE,0) >= " & Format(Val(Txt_CreditLimit.Text), "0.00") & " AND "
                    ssql = ssql & " isnull(MEMBERTYPECODE,'') in ("
                    'vSql = vSql & " isnull(MT.TypeDesc,'') in ("
                    For I = 0 To CHKCATEGORY.CheckedItems.Count - 1
                        appcode = Split(CHKCATEGORY.CheckedItems(I), ".")
                        ssql = ssql & " '" & appcode(0) & "', "
                    Next

                    ssql = Mid(ssql, 1, Len(ssql) - 2)
                    ssql = ssql & ") "
                    gconnection.GetValues(ssql)

                    ssql = "SELECT FROMDATE,TODATE,ASONDATE,MEMBERTYPECODE,G_BALANCE AS BALANCE,MCODE,MNAME,REMINDERDATE,ADDUSER,ADDDATETIME,VOID,VOIDUSER,VOIDDATETIME,DOCNO,DOCDATE,REMINDERNO,CREDITLIMIT,REFNO,CAST(REFNO_DET AS VARCHAR) AS REFNO_DET,CMONTH,PMONTH,PUSAGE,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTCOUNTRY,CONTEMAIL,CONTSTATE,CONTCELL,CONTPIN,CONTPHONE1,CONTPHONE2,MEMBERTYPE,SALUT,g_balance FROM MM_REMINDERHISTORY_BILL WHERE ISNULL(FROMDATE,'')='" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "' AND ISNULL(REMINDERNO,0)=" & CMBLETERNO.Text & " AND ISNULL(G_BALANCE,0)>0 AND ISNULL(VOID,'')<>'Y' ORDER BY MCODE"
                    gconnection.GetValues(ssql)
                End If
            Else
                ssql = "insert into reminderhistory(docno,docdate,membertypecode,mcode,mname,fromdate,todate,BALANCE,P_BALANCE,G_balance,reminderdate,adduser,adddatetime,reminderno,asondate,creditlimit,REFNO,REFNO_DET,CMONTH,PMONTH,PUSAGE)"
                ssql = ssql & " select '" & docno & "','" & Format(dtp_docdate.Value, "yyyy-MM-dd") & "',MEMBERTYPECODE,mcode,MNAME,'" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "','" & Format(Dtp_CutOffDate.Value, "yyyy-MM-dd") & "',USAGE,P_USAGE,G_USAGE,'" & Format(Dtp_rem.Value, "yyyy-MM-dd") & "','" & gUsername & "','" & Format(Now(), "yyyy-MM-dd HH:MM") & "','" & CMBLETERNO.Text & "','" & Format(Dtp_Last.Value, "yyyy-MM-dd") & "'," & Txt_CreditLimit.Text & ",'" & TXT_REFNO.Text & "',REF_ORDER,CMONTH,PMONTH,PUSAGE  from VIEW_MEM_CREDIT_REMINDER where  isnull(G_USAGE,0)+ISNULL(P_USAGE,0)+ISNULL(USAGE,0) >= " & Format(Val(Txt_CreditLimit.Text), "0.00") & " AND "
                ssql = ssql & " isnull(MEMBERTYPECODE,'') in ("
                'vSql = vSql & " isnull(MT.TypeDesc,'') in ("
                For I = 0 To CHKCATEGORY.CheckedItems.Count - 1
                    appcode = Split(CHKCATEGORY.CheckedItems(I), ".")
                    ssql = ssql & " '" & appcode(0) & "', "
                Next

                ssql = Mid(ssql, 1, Len(ssql) - 2)
                ssql = ssql & ") "
                gconnection.GetValues(ssql)

                ssql = "SELECT FROMDATE,TODATE,ASONDATE,MEMBERTYPECODE,G_BALANCE,P_BALANCE, BALANCE,MCODE,MNAME,REMINDERDATE,ADDUSER,ADDDATETIME,VOID,VOIDUSER,VOIDDATETIME,DOCNO,DOCDATE,REMINDERNO,CREDITLIMIT,REFNO,CAST(REFNO_DET AS VARCHAR) AS REFNO_DET,CMONTH,PMONTH,PUSAGE,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTCOUNTRY,CONTEMAIL,CONTSTATE,CONTCELL,CONTPIN,CONTPHONE1,CONTPHONE2,MEMBERTYPE,SALUT FROM MM_REMINDERHISTORY_BILL WHERE ISNULL(FROMDATE,'')='" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "' AND ISNULL(REMINDERNO,0)=" & CMBLETERNO.Text & " AND ISNULL(VOID,'')<>'Y' ORDER BY MCODE"
                gconnection.GetValues(ssql)
            End If

            Dim Viewer As New REPORTVIEWER

            Dim r2
            ' Dim r As New Reminder1
            If Mid(UCase(Trim(gcompanyname)), 1, 3) = "MLA" Then
                r2 = New MlaReminder1
            Else
                r2 = New Reminder3
            End If

            Dim r1 As New Reminder2
            Dim r As New CCLReminder1

            If Mid(Me.dtpASNODATE.Text, 4, 2) = "04" Then bill = "April " & Mid(gFinancalyearStart, 1, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "05" Then bill = "May " & Mid(gFinancalyearStart, 1, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "06" Then bill = "June " & Mid(gFinancalyearStart, 1, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "07" Then bill = "July " & Mid(gFinancalyearStart, 1, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "08" Then bill = "August " & Mid(gFinancalyearStart, 1, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "09" Then bill = "September " & Mid(gFinancalyearStart, 1, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "10" Then bill = "October " & Mid(gFinancalyearStart, 1, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "11" Then bill = "November " & Mid(gFinancalyearStart, 1, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "12" Then bill = "December " & Mid(gFinancalyearStart, 1, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "01" Then bill = "January " & Mid(gFinancialyearEnd, 1, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "02" Then bill = "February " & Mid(gFinancialyearEnd, 1, 4)
            If Mid(Me.dtpASNODATE.Text, 4, 2) = "03" Then bill = "March  " & Mid(gFinancialyearEnd, 1, 4)
            Viewer.ssql = ssql
            If CMBLETERNO.Text = "1" Then
                Viewer.Report = r
            ElseIf CMBLETERNO.Text = "2" Then

                Viewer.Report = r1
            ElseIf CMBLETERNO.Text = "3" Then

                Viewer.Report = r2
            End If
            If CMBLETERNO.Text = "3" Then
                txtobj1 = r2.ReportDefinition.ReportObjects("Text12")
                txtobj1.Text = UCase(TXT_REFNO.Text)
                txtobj1 = r2.ReportDefinition.ReportObjects("Text3")
                txtobj1.Text = Format(Dtp_rem.Value, "dd/MMM/yyyy")
            End If
           


            Viewer.TableName = "MM_REMINDERHISTORY"
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            GroupBox3.Visible = False
        End Try
        Exit Sub

    End Sub

    Private Sub GRID_REMINDER_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles GRID_REMINDER.CellContentClick

    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        GroupBox3.Visible = False
    End Sub

    Private Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click
        Dim SSQL1 As String
        Dim MOBILE As String
        Dim MCODE, VSQL As String
        Dim AMOUNT As Double
        Dim CHECK As Boolean
        Dim FDATE, LDATE As String
        If MessageBox.Show("Do you want to send sms?", Application.ProductName, MessageBoxButtons.YesNo) = DialogResult.Yes Then


            For I = 0 To GRID_SMS.Rows.Count - 1

                'GRID_REMINDER.Rows.Add(gdataset.Tables("DeptMst").Rows.Count)
                With GRID_SMS

                    CHECK = GRID_SMS.Rows(I).Cells(5).Value
                    If CHECK = True Then
                        MCODE = GRID_SMS.Rows(I).Cells(0).Value
                        MOBILE = GRID_SMS.Rows(I).Cells(2).Value
                        AMOUNT = GRID_SMS.Rows(I).Cells(3).Value
                        FDATE = Format(GRID_SMS.Rows(I).Cells(4).Value, "MMM yyyy")
                        LDATE = Format(Dtp_Last.Value, "dd-MM-yyyy")
                        If MOBILE <> "" And MCODE <> "" Then
                            '   Call gconnection.SMS_rem(MCODE, FDATE, MOBILE, AMOUNT, LDATE)
                        End If
                        '  MCODE = MCODE & "'" & GRID_SMS.Rows(I).Cells(0).Value & "',"
                    End If
                End With
            Next I
            GRP_SMS.Visible = False

            MessageBox.Show("SMS Sended Successfully")
            Exit Sub
        Else
            GRP_SMS.Visible = False
            Exit Sub
        End If
        'If Len(MCODE) >= 1 Then
        '    MCODE = MCODE.Substring(0, MCODE.Length - 1)
        '    vSql = "DELETE FROM REMINDERHISTORY_TRIAL WHERE MCODE IN(" & MCODE & ")"
        '    gconnection.GetValues(vSql)
        'End If

        'SSQL1 = "SELECT FROMDATE,TODATE,ASONDATE,MEMBERTYPECODE,BALANCE,MCODE,MNAME,REMINDERDATE,ADDUSER,ADDDATETIME,VOID,VOIDUSER,VOIDDATETIME,DOCNO,DOCDATE,REMINDERNO,CREDITLIMIT,REFNO,CAST(REFNO_DET AS VARCHAR) AS REFNO_DET,CMONTH,PMONTH,PUSAGE,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTCOUNTRY,CONTEMAIL,CONTSTATE,CONTCELL,CONTPIN,CONTPHONE1,CONTPHONE2,MEMBERTYPE,SALUT FROM MM_REMINDERHISTORY_SMS ORDER BY len(refno_det),REFNO_DET"
        'gconnection.getDataSet(SSQL1, "sms")
        'If gdataset.Tables("sms").Rows.Count > 0 Then
        '    For I = 0 To gdataset.Tables("sms").Rows.Count - 1
        '        MCODE = gdataset.Tables("sms").Rows(I).Item("mcode")
        '        Fromdate = Format(gdataset.Tables("SMS").Rows(I).Item("FROMDATE"), "MMM yyyy")
        '        mobile = gdataset.Tables("sms").Rows(I).Item("contcell")
        '        amount = Val(gdataset.Tables("sms").Rows(I).Item("BALANCE"))
        '        If mobile <> "" Then
        '            Call gconnection.SMS_rem(MCODE, Fromdate, mobile, amount)
        '        End If


        '    Next
        'End If
        'End If

    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles GRP_SMS.Enter

    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
        GRP_SMS.Visible = False
    End Sub

    Private Sub GRID_SMS_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles GRID_SMS.CellContentClick

    End Sub

    Private Sub RBTREMINDERLIST_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RBTREMINDERLIST.CheckedChanged
        RBTREMINDERADDRESS.Checked = False
    End Sub

    Private Sub RBTREMINDERADDRESS_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RBTREMINDERADDRESS.CheckedChanged
        If RBTREMINDERADDRESS.Checked = True Then
            RBTREMINDERLETTER.Checked = False
            RBTREMINDERLIST.Checked = False
            RBTREMINDERSUMMARY.Checked = False
        Else
            RBTREMINDERADDRESS.Checked = False
        End If
    End Sub

    Private Sub RBTREMINDERLETTER_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RBTREMINDERLETTER.CheckedChanged
        RBTREMINDERADDRESS.Checked = False
    End Sub

    Private Sub Button6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button6.Click
        Dim SSQL As String
        Dim MCODE As String
        Dim EMAIL As String
        If txt_docno.Text <> "" Or txt_docno.Enabled = False Then
            SSQL = "SELECT FROMDATE,TODATE,ASONDATE,MEMBERTYPECODE,BALANCE,MCODE,MNAME,REMINDERDATE,ADDUSER,ADDDATETIME,VOID,VOIDUSER,VOIDDATETIME,DOCNO,DOCDATE,REMINDERNO,CREDITLIMIT,REFNO,CAST(REFNO_DET AS VARCHAR) AS REFNO_DET,CMONTH,PMONTH,PUSAGE,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTCOUNTRY,CONTEMAIL,CONTSTATE,CONTCELL,CONTPIN,CONTPHONE1,CONTPHONE2,MEMBERTYPE,SALUT FROM MM_REMINDERHISTORY WHERE ISNULL(FROMDATE,'')='" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "' AND ISNULL(REMINDERNO,0)=" & CMBLETERNO.Text & " AND ISNULL(VOID,'')<>'Y' ORDER BY LEN(REFNO_DET),REFNO_DET"
            gconnection.getDataSet(SSQL, "REMINDER")
            If gdataset.Tables("REMINDER").Rows.Count > 0 Then
                For I = 0 To gdataset.Tables("REMINDER").Rows.Count - 1
                    EMAIL = gdataset.Tables("REMINDER").Rows(I).Item("CONTEMAIL")
                    MCODE = gdataset.Tables("REMINDER").Rows(I).Item("MCODE")



                    'ssql = Mid(ssql, 1, Len(ssql) - 2)
                    '' ssql = ssql & ") "
                    SSQL = ""
                    SSQL = "SELECT FROMDATE,TODATE,ASONDATE,MEMBERTYPECODE,BALANCE,MCODE,MNAME,REMINDERDATE,ADDUSER,ADDDATETIME,VOID,VOIDUSER,VOIDDATETIME,DOCNO,DOCDATE,REMINDERNO,CREDITLIMIT,REFNO,CAST(REFNO_DET AS VARCHAR) AS REFNO_DET,CMONTH,PMONTH,PUSAGE,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTCOUNTRY,CONTEMAIL,CONTSTATE,CONTCELL,CONTPIN,CONTPHONE1,CONTPHONE2,MEMBERTYPE,SALUT FROM MM_REMINDERHISTORY WHERE ISNULL(FROMDATE,'')='" & Format(dtpASNODATE.Value, "yyyy-MM-dd") & "' AND ISNULL(REMINDERNO,0)=" & CMBLETERNO.Text & " AND ISNULL(VOID,'')<>'Y' AND MCODE='" & MCODE & "' ORDER BY LEN(REFNO_DET),REFNO_DET"
                    ' gconnection.GetValues(SSQL)
                    gconnection.GetValues(SSQL)

                    Dim Viewer As New REPORTVIEWER

                    Dim r As New Reminder1
                    Dim r1 As New Reminder2
                    Dim r2 As New Reminder3

                    If Mid(Me.dtpASNODATE.Text, 4, 2) = "04" Then bill = "April " & Mid(gFinancalyearStart, 1, 4)
                    If Mid(Me.dtpASNODATE.Text, 4, 2) = "05" Then bill = "May " & Mid(gFinancalyearStart, 1, 4)
                    If Mid(Me.dtpASNODATE.Text, 4, 2) = "06" Then bill = "June " & Mid(gFinancalyearStart, 1, 4)
                    If Mid(Me.dtpASNODATE.Text, 4, 2) = "07" Then bill = "July " & Mid(gFinancalyearStart, 1, 4)
                    If Mid(Me.dtpASNODATE.Text, 4, 2) = "08" Then bill = "August " & Mid(gFinancalyearStart, 1, 4)
                    If Mid(Me.dtpASNODATE.Text, 4, 2) = "09" Then bill = "September " & Mid(gFinancalyearStart, 1, 4)
                    If Mid(Me.dtpASNODATE.Text, 4, 2) = "10" Then bill = "October " & Mid(gFinancalyearStart, 1, 4)
                    If Mid(Me.dtpASNODATE.Text, 4, 2) = "11" Then bill = "November " & Mid(gFinancalyearStart, 1, 4)
                    If Mid(Me.dtpASNODATE.Text, 4, 2) = "12" Then bill = "December " & Mid(gFinancalyearStart, 1, 4)
                    If Mid(Me.dtpASNODATE.Text, 4, 2) = "01" Then bill = "January " & Mid(gFinancialyearEnd, 1, 4)
                    If Mid(Me.dtpASNODATE.Text, 4, 2) = "02" Then bill = "February " & Mid(gFinancialyearEnd, 1, 4)
                    If Mid(Me.dtpASNODATE.Text, 4, 2) = "03" Then bill = "March  " & Mid(gFinancialyearEnd, 1, 4)
                    Viewer.ssql = SSQL
                    If CMBLETERNO.Text = "1" Then
                        Viewer.Report = r
                    ElseIf CMBLETERNO.Text = "2" Then

                        Viewer.Report = r1
                    ElseIf CMBLETERNO.Text = "3" Then

                        Viewer.Report = r2
                    End If
                    Viewer.TableName = "MM_REMINDERHISTORY"
                    Viewer.Show()
                    Dim MESSAGE As String
                    MESSAGE = "REMINDER AS ON " & Format(dtpASNODATE.Value, "dd/MMM/yyyy")
                    Dim FILEPATH As String
                    Dim filename As String
                    Dim files As String = "REMINDER"

                    filename = MESSAGE
                    'End If

                    Dim afile As File
                    FILEPATH = apppath & "\Reports\REMINDER.DOC"
                    If afile.Exists(FILEPATH) Then
                        afile.Delete(FILEPATH)
                    End If
                    Dim CrExportOptions As ExportOptions
                    Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
                    Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
                    CrDiskFileDestinationOptions.DiskFileName = FILEPATH
                    If CMBLETERNO.Text = "1" Then
                        CrExportOptions = r.ExportOptions
                    Else
                        CrExportOptions = r1.ExportOptions
                    End If

                    With CrExportOptions
                        .ExportDestinationType = ExportDestinationType.DiskFile
                        .ExportFormatType = ExportFormatType.WordForWindows
                        .DestinationOptions = CrDiskFileDestinationOptions
                        .FormatOptions = CrFormatTypeOptions
                    End With
                    If CMBLETERNO.Text = "1" Then
                        r.Export()
                    ElseIf CMBLETERNO.Text = "2" Then

                        r1.Export()
                    ElseIf CMBLETERNO.Text = "3" Then

                        r2.Export()
                    End If

                    'sqlString = "SELECT CONTEMAIL FRO"
                    'EMAIL = "blasters11@gmail.com"
                    ' gconnection.Mail(EMAIL, FILEPATH, MESSAGE, filename, files)
                    'Viewer.Close()
                    If CMBLETERNO.Text = "1" Then
                        r.Dispose()
                    ElseIf CMBLETERNO.Text = "2" Then

                        r1.Dispose()
                    ElseIf CMBLETERNO.Text = "3" Then

                        r2.Dispose()
                    End If

                    Viewer.Close()
                    Viewer.Dispose()
                Next
            End If
        End If
    End Sub

    Private Sub TXT_REFNO_TextChanged(sender As Object, e As EventArgs) Handles TXT_REFNO.TextChanged

    End Sub
End Class
