Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Web
Imports System.Web.UI
Imports System.Net
Imports System.Text
Imports System.Configuration
Imports System.Xml
Imports System.Collections
Imports System.ComponentModel
Imports System.Web.HttpApplication
Public Class SendSms
    Inherits System.Windows.Forms.Form
    Dim Sqlstring, bildt As String
    Dim gconnection As New GlobalClass
    Public selectNo As Integer
    Public MEMBERTYPE, Fill_Chk_str As String
    Dim i As Integer
    Dim Response() As String
    Dim Response1() As Integer
    Dim a(), b As String
    Dim month1, noofdays As Integer
    Friend WithEvents Rdb_Month As System.Windows.Forms.RadioButton
    Friend WithEvents CbxMonth As System.Windows.Forms.DateTimePicker
    Dim UsedAmt, UsedAmt1, UsedAmt2 As Double
    Friend WithEvents Chk_mem As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_Spouse As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_Jr As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_Sr As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Filter_Field As System.Windows.Forms.CheckedListBox
    Friend WithEvents chk_PrintAll As System.Windows.Forms.CheckBox
    Friend WithEvents Lbl_Count As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Select_Category As System.Windows.Forms.CheckedListBox
    Friend WithEvents Cbx_Gatway As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Dim type1 As String

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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbl_Caption As System.Windows.Forms.Label
    Friend WithEvents ssGrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Btn_close As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_Curr As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_Gen As System.Windows.Forms.RadioButton
    Friend WithEvents process As System.Windows.Forms.Button
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents TxtMsg As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SendSms))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ssGrid = New AxFPSpreadADO.AxfpSpread()
        Me.lbl_Caption = New System.Windows.Forms.Label()
        Me.Btn_close = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Rdb_Month = New System.Windows.Forms.RadioButton()
        Me.rdo_Gen = New System.Windows.Forms.RadioButton()
        Me.rdo_Curr = New System.Windows.Forms.RadioButton()
        Me.process = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.Button()
        Me.TxtMsg = New System.Windows.Forms.TextBox()
        Me.CbxMonth = New System.Windows.Forms.DateTimePicker()
        Me.Chk_mem = New System.Windows.Forms.CheckBox()
        Me.Chk_Spouse = New System.Windows.Forms.CheckBox()
        Me.Chk_Jr = New System.Windows.Forms.CheckBox()
        Me.Chk_Sr = New System.Windows.Forms.CheckBox()
        Me.chk_Filter_Field = New System.Windows.Forms.CheckedListBox()
        Me.chk_PrintAll = New System.Windows.Forms.CheckBox()
        Me.Lbl_Count = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Select_Category = New System.Windows.Forms.CheckedListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cbx_Gatway = New System.Windows.Forms.ComboBox()
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(8, 456)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.Visible = False
        '
        'ssGrid
        '
        Me.ssGrid.DataSource = Nothing
        Me.ssGrid.Location = New System.Drawing.Point(199, 116)
        Me.ssGrid.Name = "ssGrid"
        Me.ssGrid.OcxState = CType(resources.GetObject("ssGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssGrid.Size = New System.Drawing.Size(623, 240)
        Me.ssGrid.TabIndex = 386
        '
        'lbl_Caption
        '
        Me.lbl_Caption.AutoSize = True
        Me.lbl_Caption.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Caption.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Caption.Location = New System.Drawing.Point(187, 73)
        Me.lbl_Caption.Name = "lbl_Caption"
        Me.lbl_Caption.Size = New System.Drawing.Size(144, 29)
        Me.lbl_Caption.TabIndex = 387
        Me.lbl_Caption.Text = "SMS FORM"
        Me.lbl_Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_close
        '
        Me.Btn_close.BackgroundImage = CType(resources.GetObject("Btn_close.BackgroundImage"), System.Drawing.Image)
        Me.Btn_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_close.ForeColor = System.Drawing.Color.White
        Me.Btn_close.Location = New System.Drawing.Point(308, 537)
        Me.Btn_close.Name = "Btn_close"
        Me.Btn_close.Size = New System.Drawing.Size(104, 32)
        Me.Btn_close.TabIndex = 388
        Me.Btn_close.Text = "Exit"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Cbx_Gatway)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Rdb_Month)
        Me.GroupBox1.Controls.Add(Me.rdo_Gen)
        Me.GroupBox1.Controls.Add(Me.rdo_Curr)
        Me.GroupBox1.Location = New System.Drawing.Point(197, 353)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(625, 48)
        Me.GroupBox1.TabIndex = 389
        Me.GroupBox1.TabStop = False
        '
        'Rdb_Month
        '
        Me.Rdb_Month.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdb_Month.Location = New System.Drawing.Point(20, 15)
        Me.Rdb_Month.Name = "Rdb_Month"
        Me.Rdb_Month.Size = New System.Drawing.Size(95, 24)
        Me.Rdb_Month.TabIndex = 2
        Me.Rdb_Month.Text = "Month Bill"
        '
        'rdo_Gen
        '
        Me.rdo_Gen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_Gen.Location = New System.Drawing.Point(252, 16)
        Me.rdo_Gen.Name = "rdo_Gen"
        Me.rdo_Gen.Size = New System.Drawing.Size(87, 24)
        Me.rdo_Gen.TabIndex = 1
        Me.rdo_Gen.Text = "General Message"
        '
        'rdo_Curr
        '
        Me.rdo_Curr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_Curr.Location = New System.Drawing.Point(141, 16)
        Me.rdo_Curr.Name = "rdo_Curr"
        Me.rdo_Curr.Size = New System.Drawing.Size(85, 24)
        Me.rdo_Curr.TabIndex = 0
        Me.rdo_Curr.Text = "Current Outstaing"
        Me.rdo_Curr.Visible = False
        '
        'process
        '
        Me.process.BackgroundImage = CType(resources.GetObject("process.BackgroundImage"), System.Drawing.Image)
        Me.process.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.process.ForeColor = System.Drawing.Color.White
        Me.process.Location = New System.Drawing.Point(192, 537)
        Me.process.Name = "process"
        Me.process.Size = New System.Drawing.Size(104, 32)
        Me.process.TabIndex = 390
        Me.process.Text = "Send"
        '
        'cancel
        '
        Me.cancel.BackgroundImage = CType(resources.GetObject("cancel.BackgroundImage"), System.Drawing.Image)
        Me.cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel.ForeColor = System.Drawing.Color.White
        Me.cancel.Location = New System.Drawing.Point(432, 537)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(104, 32)
        Me.cancel.TabIndex = 392
        Me.cancel.Text = "Clear"
        '
        'TxtMsg
        '
        Me.TxtMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMsg.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMsg.Location = New System.Drawing.Point(192, 435)
        Me.TxtMsg.MaxLength = 960
        Me.TxtMsg.Multiline = True
        Me.TxtMsg.Name = "TxtMsg"
        Me.TxtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtMsg.Size = New System.Drawing.Size(630, 96)
        Me.TxtMsg.TabIndex = 393
        '
        'CbxMonth
        '
        Me.CbxMonth.CalendarMonthBackground = System.Drawing.Color.White
        Me.CbxMonth.CustomFormat = "MMMMM"
        Me.CbxMonth.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CbxMonth.Location = New System.Drawing.Point(194, 409)
        Me.CbxMonth.Name = "CbxMonth"
        Me.CbxMonth.Size = New System.Drawing.Size(128, 22)
        Me.CbxMonth.TabIndex = 602
        '
        'Chk_mem
        '
        Me.Chk_mem.AutoSize = True
        Me.Chk_mem.BackColor = System.Drawing.Color.Transparent
        Me.Chk_mem.Location = New System.Drawing.Point(333, 79)
        Me.Chk_mem.Name = "Chk_mem"
        Me.Chk_mem.Size = New System.Drawing.Size(73, 17)
        Me.Chk_mem.TabIndex = 603
        Me.Chk_mem.Text = "MEMBER"
        Me.Chk_mem.UseVisualStyleBackColor = False
        Me.Chk_mem.Visible = False
        '
        'Chk_Spouse
        '
        Me.Chk_Spouse.AutoSize = True
        Me.Chk_Spouse.BackColor = System.Drawing.Color.Transparent
        Me.Chk_Spouse.Location = New System.Drawing.Point(429, 79)
        Me.Chk_Spouse.Name = "Chk_Spouse"
        Me.Chk_Spouse.Size = New System.Drawing.Size(70, 17)
        Me.Chk_Spouse.TabIndex = 604
        Me.Chk_Spouse.Text = "SPOUSE"
        Me.Chk_Spouse.UseVisualStyleBackColor = False
        Me.Chk_Spouse.Visible = False
        '
        'Chk_Jr
        '
        Me.Chk_Jr.AutoSize = True
        Me.Chk_Jr.BackColor = System.Drawing.Color.Transparent
        Me.Chk_Jr.Location = New System.Drawing.Point(521, 79)
        Me.Chk_Jr.Name = "Chk_Jr"
        Me.Chk_Jr.Size = New System.Drawing.Size(39, 17)
        Me.Chk_Jr.TabIndex = 605
        Me.Chk_Jr.Text = "JR"
        Me.Chk_Jr.UseVisualStyleBackColor = False
        Me.Chk_Jr.Visible = False
        '
        'Chk_Sr
        '
        Me.Chk_Sr.AutoSize = True
        Me.Chk_Sr.BackColor = System.Drawing.Color.Transparent
        Me.Chk_Sr.Location = New System.Drawing.Point(580, 79)
        Me.Chk_Sr.Name = "Chk_Sr"
        Me.Chk_Sr.Size = New System.Drawing.Size(41, 17)
        Me.Chk_Sr.TabIndex = 606
        Me.Chk_Sr.Text = "SR"
        Me.Chk_Sr.UseVisualStyleBackColor = False
        Me.Chk_Sr.Visible = False
        '
        'chk_Filter_Field
        '
        Me.chk_Filter_Field.BackColor = System.Drawing.Color.White
        Me.chk_Filter_Field.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Filter_Field.Location = New System.Drawing.Point(864, 382)
        Me.chk_Filter_Field.Name = "chk_Filter_Field"
        Me.chk_Filter_Field.Size = New System.Drawing.Size(134, 124)
        Me.chk_Filter_Field.TabIndex = 610
        '
        'chk_PrintAll
        '
        Me.chk_PrintAll.BackColor = System.Drawing.Color.Transparent
        Me.chk_PrintAll.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PrintAll.Location = New System.Drawing.Point(867, 346)
        Me.chk_PrintAll.Name = "chk_PrintAll"
        Me.chk_PrintAll.Size = New System.Drawing.Size(84, 21)
        Me.chk_PrintAll.TabIndex = 611
        Me.chk_PrintAll.Text = "Select All Categorys"
        Me.chk_PrintAll.UseVisualStyleBackColor = False
        Me.chk_PrintAll.Visible = False
        '
        'Lbl_Count
        '
        Me.Lbl_Count.AutoSize = True
        Me.Lbl_Count.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Count.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Count.Location = New System.Drawing.Point(783, 552)
        Me.Lbl_Count.Name = "Lbl_Count"
        Me.Lbl_Count.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Count.TabIndex = 612
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(511, 369)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 613
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(865, 363)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 614
        Me.Label2.Text = "Member Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(189, 580)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(297, 15)
        Me.Label3.TabIndex = 615
        Me.Label3.Text = " * After Check Member Type please press enter key"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(865, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 15)
        Me.Label4.TabIndex = 618
        Me.Label4.Text = "Member Category"
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(866, 125)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(84, 21)
        Me.CheckBox1.TabIndex = 617
        Me.CheckBox1.Text = "Select All Categorys"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Select_Category
        '
        Me.Select_Category.BackColor = System.Drawing.Color.White
        Me.Select_Category.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Select_Category.Location = New System.Drawing.Point(864, 148)
        Me.Select_Category.Name = "Select_Category"
        Me.Select_Category.Size = New System.Drawing.Size(134, 184)
        Me.Select_Category.Sorted = True
        Me.Select_Category.TabIndex = 619
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(345, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Gatway :"
        '
        'Cbx_Gatway
        '
        Me.Cbx_Gatway.FormattingEnabled = True
        Me.Cbx_Gatway.Items.AddRange(New Object() {"Celusion", "Ebiz"})
        Me.Cbx_Gatway.Location = New System.Drawing.Point(419, 17)
        Me.Cbx_Gatway.Name = "Cbx_Gatway"
        Me.Cbx_Gatway.Size = New System.Drawing.Size(121, 21)
        Me.Cbx_Gatway.TabIndex = 4
        '
        'SendSms
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources._111in1024res
        Me.ClientSize = New System.Drawing.Size(1022, 750)
        Me.Controls.Add(Me.Select_Category)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lbl_Count)
        Me.Controls.Add(Me.chk_PrintAll)
        Me.Controls.Add(Me.chk_Filter_Field)
        Me.Controls.Add(Me.Chk_Sr)
        Me.Controls.Add(Me.Chk_Jr)
        Me.Controls.Add(Me.Chk_Spouse)
        Me.Controls.Add(Me.Chk_mem)
        Me.Controls.Add(Me.CbxMonth)
        Me.Controls.Add(Me.TxtMsg)
        Me.Controls.Add(Me.lbl_Caption)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.process)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btn_close)
        Me.Controls.Add(Me.ssGrid)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.Name = "SendSms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SendSms"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim faser As fast.falertwsdl = New fast.falertwsdl
        ''Dim msg As String = faser.SendSMS("ORDNANCECLUB", "ORDCLUB", "a1b2c3", "test", "9038850188")
        ''Dim msg As String = faser.SendBulkSMS("ordnanceclub", "ordclb", "a1b2c3", "test mess", "9038850188")
        'Dim msg1 As String = faser.SendSMSwithDR("ordnanceclub", "ORDCLB", "a1b2c3", "Todays Test", "9038850188")
        'MsgBox("Send Successfully." + msg1, MsgBoxStyle.OKOnly, "Message Sent")
    End Sub
    Private Sub Chk()
        'type1 = " "
        'If Chk_mem.Checked = True Then
        '    type1 &= Chk_mem.Text
        '    type1 = " "
        '    'type1 = "MEMBER"
        'ElseIf Chk_Spouse.Checked = True Then
        '    type1 &= Chk_Spouse.Text
        '    type1 = " "
        '    'type1 = "SPOUSE"
        'ElseIf Chk_Jr.Checked = True Then
        '    type1 &= Chk_Jr.Text
        '    type1 = " "
        '    'type1 = "J"
        'ElseIf Chk_Sr.Checked = True Then
        '    type1 &= Chk_Sr.Text
        '    type1 = " "
        '    ' type1 = "S"
        'End If
        'Dim  
      
    End Sub
    Public Function CountCharacter(ByVal value As String, ByVal ch As Char) As Integer
        Dim cnt As Integer = 0
        For Each c As Char In value
            If c = ch Then cnt += 1
        Next
        Return cnt
    End Function
    Private Sub Fillcat()
        'CheckBox1.Checked = False
        'Dim Fill_Chk_str As String
        'Select_Category.Items.Clear()
        'Dim MEMBERTYPE As New DataTable
        'selectNo = 0
        'Fill_Chk_str = "select  subtypeCode,Subtypedesc  from subcategorymaster"
        'MEMBERTYPE = gconnection.GetValues(Fill_Chk_str)
        'Dim Itration
        'For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
        '    Select_Category.Items.Add(MEMBERTYPE.Rows(Itration).Item("Subtypedesc"))
        'Next
        Dim ssql As String
        Dim MEMBERTYPE As New DataTable
        ssql = "select isnull(SUBTYPECODE,'') as membertype,isnull(SUBtypedesc,'') as typedesc from SUBCATEGORYMASTER "
        MEMBERTYPE = gconnection.GetValues(ssql)
        Dim Itration
        For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
            Select_Category.Items.Add(MEMBERTYPE.Rows(Itration).Item("Membertype") & "." & MEMBERTYPE.Rows(Itration).Item("TypeDesc"))
        Next
        'LoadUnitNO()
        Select_Category.Focus()
    End Sub
    Private Sub SendSms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Sqlstring = "SELECT 'P001'AS MCODE,'PANKAJ KUMAR' AS MNAME,'9038850188'AS CONTCELL UNION ALL "
        'Sqlstring = Sqlstring & " SELECT 'P002'AS MCODE,'JAYMAL' AS MNAME,'9038447030'AS CONTCELL UNION ALL "
        'Call Chk()
        Dim str As String
        'Lbl_Count.Text = TxtMsg.count(Function(x) Char.IsLetter(x) = True)
        'Lbl_Count.Text = CountCharacter(str, "e"c)
        Call Fillcat()
        Dim ssql As String
        Dim type1 As New DataTable
        ssql = "select isnull(type1,'') as type1 from SMS_VW  order by SNO asc  "
        type1 = gconnection.GetValues(ssql)
        Dim Itration
        For Itration = 0 To (type1.Rows.Count - 1)
            chk_Filter_Field.Items.Add(type1.Rows(Itration).Item("type1") & ".")
        Next

            ''LoadUnitNO()
            'chk_Filter_Field.Focus()
            '' RDOCOMBINEDNO.Checked = True

            'Dim TYPE(0), MEMTYPE As String

            'ssGrid.ClearRange(1, 1, -1, -1, True)
            'If chk_Filter_Field.CheckedItems.Count = 0 Then
            Sqlstring = " SELECT ISNULL(MCODE,'') AS MCODE,(ISNULL(PREFIX,'')+ ' ' +ISNULL(MNAME,''))AS MNAME,REPLACE(CONTCELL,' ','')AS CONTCELL FROM MEMBERMASTER "
            Sqlstring = Sqlstring & " WHERE ISNULL(CONTCELL,'') <> '' AND ISNULL(CURENTSTATUS,'') = 'ACTIVE' ORDER BY MCODE"
            'Else
            '    MEMTYPE = ""
            '    If chk_Filter_Field.CheckedItems.Count > 0 Then
            '        For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
            '            TYPE = Split(chk_Filter_Field.CheckedItems(i), ".")
            '            MEMTYPE = MEMTYPE & "'" & TYPE(0) & "', "
            '        Next
            '        MEMTYPE = Mid(MEMTYPE, 1, Len(MEMTYPE) - 2)
            '    Else
            '        MessageBox.Show("Select the Member Type", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '        chk_Filter_Field.Focus()
            '        Exit Sub
            '    End If
            '    Sqlstring = " SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'')AS MNAME,REPLACE(CONTCELL,' ','')AS CONTCELL  FROM SMS_MEMSPOUSEDEP "
            '    Sqlstring = Sqlstring & " WHERE type1 in('" & MEMTYPE & "')  ORDER BY MCODE"
            'End If
            gconnection.getDataSet(Sqlstring, "Master")
            If gdataset.Tables("Master").Rows.Count > 0 Then
                For i = 0 To gdataset.Tables("Master").Rows.Count - 1
                    With ssGrid
                        .Col = 1
                        .Row = i + 1
                        .Text = Trim(gdataset.Tables("Master").Rows(i).Item("MCODE"))
                        .Col = 2
                        .Row = i + 1
                        .Text = Trim(gdataset.Tables("Master").Rows(i).Item("MNAME"))
                        .Col = 3
                        .Row = i + 1
                        .Text = Trim(gdataset.Tables("Master").Rows(i).Item("CONTCELL"))
                        .Col = 5
                        .Row = i + 1
                        .Text = "No"
                    End With
                Next
            End If
            rdo_Gen.Checked = True
    End Sub

    Private Sub Btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_close.Click
        Me.Close()
    End Sub

    Private Sub ssGrid_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssGrid.KeyDownEvent
        Dim I As Integer
        Dim VSTR As Integer
        If e.keyCode = Keys.F2 Then
            For I = ssGrid.ActiveRow To ssGrid.DataRowCnt
                With ssGrid
                    .Row = I
                    .Col = 5
                    .Text = "Yes"
                End With
            Next
        ElseIf e.keyCode = Keys.F3 Then
            For I = ssGrid.ActiveRow To ssGrid.DataRowCnt
                With ssGrid
                    .Row = I
                    .Col = 5
                    .Text = "No"
                End With
            Next
        End If
    End Sub

    Private Sub rdo_Gen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Gen.CheckedChanged
        If rdo_Gen.Checked = True Then
            TxtMsg.Visible = True
            CbxMonth.Visible = False
        ElseIf rdo_Curr.Checked = True Then
            TxtMsg.Visible = False
            CbxMonth.Visible = False
        ElseIf Rdb_Month.Checked = True Then
            TxtMsg.Visible = False
            CbxMonth.Visible = True
        End If
    End Sub

    Private Sub rdo_Curr_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdo_Curr.CheckedChanged
        If rdo_Gen.Checked = True Then
            TxtMsg.Visible = True
            CbxMonth.Visible = False
        ElseIf rdo_Curr.Checked = True Then
            TxtMsg.Visible = False
            CbxMonth.Visible = False
        ElseIf Rdb_Month.Checked = True Then
            TxtMsg.Visible = False
            CbxMonth.Visible = True
        End If
    End Sub

    Private Sub cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        rdo_Gen.Checked = True
        Call rdo_Gen_CheckedChanged(sender, e)
        TxtMsg.Text = ""
        For i = 1 To ssGrid.DataRowCnt
            With ssGrid
                .Row = i
                .Col = 4
                .Text = ""
                .Row = i
                .Col = 5
                .Text = "No"
            End With
        Next
    End Sub
    Private Sub General()
        Dim GenMsg, SqlStr, BILDT1 As String
        Dim Phoneno, mcode As String
        Dim k As Integer
        Dim VREF As String

        If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : noofdays = 30 : bildt = "01-Apr-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "30 Apr " & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31 : bildt = "01-may-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "31 May " & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30 : bildt = "01-jun-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "30-jun-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31 : bildt = "01-jul-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "31-jul-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31 : bildt = "01-aug-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "31-aug-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30 : bildt = "01-SEP-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "30-Sep-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31 : bildt = "01-OCT-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "31-Oct-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30 : bildt = "01-NOV-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "30-Nov-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31 : bildt = "01-DEC-2014" & Mid(2014, 7, 4) : BILDT1 = "31-DEC-2014" & Mid(2014, 7, 4)

        If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31 : bildt = "01-JAN-" & gFinancialyearEnd : BILDT1 = "31-Jan-" & gFinancialyearEnd
        If gFinancialyearEnd Mod 4 = 0 Then
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 29 : bildt = "01-Feb-" & gFinancialyearEnd : BILDT1 = "29-Feb-" & gFinancialyearEnd
        Else
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 28 : bildt = "01-Feb-" & gFinancialyearEnd : BILDT1 = "28-Feb-" & gFinancialyearEnd
        End If
        If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31 : bildt = "01-Mar-" & gFinancialyearEnd : BILDT1 = "31-Mar-" & gFinancialyearEnd


        If rdo_Gen.Checked = True And Trim(TxtMsg.Text) <> "" Then
            GenMsg = Trim(TxtMsg.Text)
            With ssGrid
                For k = 1 To .DataRowCnt
                    .Row = k
                    .Col = 5
                    VREF = Trim(.Text)
                    If VREF = "Yes" Then
                        .Col = 1
                        .Row = k
                        mcode = Trim(.Text)
                        .Col = 3
                        .Row = k
                        Phoneno = Trim(.Text)
                        If Trim(Phoneno) <> "" And Len(Phoneno) = 10 And Trim(GenMsg) <> "" Then
                            .Row = k
                            .Col = 4
                            .Text = "Sending..."
                            Call SendSMSEMC(GenMsg, Phoneno)
                            'Call SendSMSProcess(GenMsg, Phoneno)
                            'If Response(0) = 402 Then
                            '    .Row = k
                            '    .Col = 4
                            '    .Text = "Sent"
                            'Else
                            '    .Row = k
                            '    .Col = 4
                            '    .Text = "Failed Check Phone No"
                            'End If
                            '.Row = k
                            '.Col = 4
                            '.Text = "Sent"
                            'SqlStr = "INSERT INTO SendSmsStatus VALUES('" & mcode & "'," & Response1(0) & ", GETDATE(),'" & GenMsg & "' )"
                            'gconnection.ExcuteStoreProcedure(SqlStr)
                            If GenMsg <> "" Then
                                ' Call SendSMSEMC(GenMsg, Phoneno)
                                .Row = k
                                .Col = 4
                                .Text = "Sent"
                                ' SqlStr = "INSERT INTO SendSmsStatus VALUES('" & mcode & "'," & a(1) & ",'" & Format((CbxMonth.Value), "dd-MMM-yyyy") & "','" & GenMsg & "' )"
                                'SqlStr = "INSERT INTO SendSmsStatus( mcode,Response1 ,BILLDATE ,Messagebox) VALUES('" & mcode & "'," & a(1) & ",'" & Format((CbxMonth.Text), "dd-MMM-yyyy") & "','" & GenMsg & "' )"
                                'gconnection.ExcuteStoreProcedure(SqlStr)
                                SqlStr = "INSERT INTO SendSmsStatus( mcode,Response1 ,BILLDATE ,Messagebox) VALUES('" & mcode & "'," & a(1) & ",'" & Format((CbxMonth.Value), "dd-MMM-yyyy") & "','" & GenMsg & "' )"
                                gconnection.ExcuteStoreProcedure(SqlStr)
                            End If
                        Else
                            .Row = k
                            .Col = 4
                            .Text = "Failed Check Phone No"
                        End If
                    End If
                Next
            End With
            MsgBox("Done.", MsgBoxStyle.OkOnly, "EMCKOL")
        End If
    End Sub

    Private Sub SendSMS()
        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim url As String
        Dim username As String = "punjabclub"
        Dim password As String = "punjabclub123"
        Dim host As String = "http://dndopen.loyalsmsindia.co.in/web2sms.php?"
        Dim originator As String = "THECPC"

        'http://dndopen.loyalsmsindia.co.in/web2sms.php?username=punjabclub&password=punjabclub123&to=9038850188&sender=THECPC&message=PUNJAB%20CLUB%20CELEBRATES%20VALENTINE%20DAY%20ON%2014TH%20FEB%20AT%208.30%20PM%20AT%20THE%20CLUB'S%20MAIN%20HALL.%20LIMITED%20DINNER%20CUM%20ENTRY%20TICKETS%20AVAILABLE%20AT%20THE%20RECEPTION.%20BOOK%20EARLY%20TO%20AVOID%20DISAPPOINTMENT.%20ANIL%20KAPOOR.%20HONY.%20SECRETARY

        url = host + "" _
        & "username=" & HttpUtility.UrlEncode(username) _
        & "&password=" + HttpUtility.UrlEncode(password) _
        & "&to=" + HttpUtility.UrlEncode("9038850188") _
        & "&sender=" + HttpUtility.UrlEncode(originator) _
        & "&message=" + HttpUtility.UrlEncode("hello") _
        '& "&originator=" + HttpUtility.UrlEncode(originator) _
        '& "&serviceprovider=" _
        '& "&responseformat=html"

        request = DirectCast(WebRequest.Create(url), HttpWebRequest)

        response = DirectCast(request.GetResponse(), HttpWebResponse)

        MessageBox.Show("Response: " & response.StatusDescription)



    End Sub
    Public Sub SendSMSEMC(ByVal Msg As String, ByVal Ph As String)
        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim url As String
        Dim reader As StreamReader
        Dim data As String = ""
        Dim username As String = ""
        Dim password As String = ""
        Dim uname As String = ""
        Dim pass As String = ""
        '  Dim host As String = "http://dndopen.loyalsmsindia.co.in/api/web2sms.php?"
        ' Dim host As String = "http://smsc.smsconnexion.com/api/gateway.aspx?action=send"
        Dim host As String
        If Cbx_Gatway.Text = "" Then
            MessageBox.Show("Please Select Gatway")
            Cbx_Gatway.Focus()
            Exit Sub
        End If
        If Cbx_Gatway.Text = "Celusion" Then
            host = "http://smsc.smsconnexion.com/api/gateway.aspx?action=send"
        Else
            host = "http://103.247.98.91/API/SendMsg.aspx?"
        End If


        'Dim originator As String = "EMCKOL"
        Dim originator As String = "calcuttaclub"
        Dim Message As String
        Try
            If Ph <> "" And Len(Ph) = 10 And Msg <> "" Then
                'Message = "workingkey=A2f3266d41a2eae4b16443fb578859fdf&sender=EMCKOL&to=91" & Ph & "&message=" & Msg
                'Message = "&username=calcuttaclub&passphrase=123456&phone=91" & Ph & "&message=" & Msg
                'Message = "&username=calcuttaclub&passphrase=123456&message=" & Msg & "&phone=91" & Ph
                ' Message = "&uname=20152702&pass=123456&send=PROMO&dest=91" & Ph & "&msg = " & Msg
                'If Cbx_Gatway.Text = "Celusion" Then

                'Else
                '    Message = "uname=20152702&pass=CALCLB123&send=CALCLB&dest=" & Ph & "&msg=" & Msg
                'End If

                If Cbx_Gatway.Text = "Celusion" Then
                    Message = "&username=calcuttaclub&passphrase=123456&message=" & Msg & "&phone=91" & Ph
                Else
                    Message = "uname=20152702&pass=CALCLB123&send=CALCLB&dest=" & Ph & "&msg=" & Msg
                End If

                'Message = "&username=calcuttaclub&&passphrase=123456&route=2&senderid=BBSCLB&destination=" & CCELL & "&message=Bhubaneswar Club(" & Trim(mcode) & ")BILL till " & Format(Billdate, "dd/MM/yyyy") & " is Rs." & Format(ASONOUTSTANDING) & " . " & Format(Billdate, "MMM") & " dues Rs. " & Format(CURMONTHOUTSTANDING) & ".Previous dues Rs." & Format(AREEAR) & " .Total dues Rs." & Format(TOTALDUES) & ". " & Format(Billdate, "MMM") & " receipts Rs." & Format(CRMONTHRECEIPT) & "."
                url = host + "" & Message & ""
                request = DirectCast(WebRequest.Create(url), HttpWebRequest)
                response = DirectCast(request.GetResponse(), HttpWebResponse)
                reader = New StreamReader(response.GetResponseStream())
                data = reader.ReadToEnd()
                If Cbx_Gatway.Text = "Celusion" Then
                    a = data.Split(",")
                Else
                    a = data.Split("-")
                End If

                'Dim strResult() As String
                'strResult = data.Split(FormatNumber(Environment.NewLine))
                ' MessageBox.Show("Response: " & response.StatusDescription)
            End If
        Catch ex As Exception
            MessageBox.Show("Netwrok Error.." & ex.ToString())
        End Try
    End Sub
    Private Sub Outstanding1()
        Dim GenMsg, mcode As String
        Dim Phoneno As String
        Dim k As Integer
        Dim VREF As Integer
        If rdo_Curr.Checked = True Then
            GenMsg = "Dear Member, "
            With ssGrid
                For k = 1 To .DataRowCnt
                    GenMsg = "Dear Member, "
                    .Row = k
                    .Col = 5
                    VREF = Val(.Text)
                    If VREF = 1 Then
                        GenMsg = "Dear Member, "
                        .Col = 1
                        .Row = k
                        mcode = Trim(.Text)
                        .Col = 3
                        .Row = k
                        Phoneno = Trim(.Text)
                        If Trim(Phoneno) <> "" And Len(Phoneno) = 10 And Trim(GenMsg) <> "" And Trim(mcode) <> "" Then
                            .Row = k
                            .Col = 4
                            .Text = "Sending..."
                            Call CreditBal_Check(mcode)
                            If UsedAmt > 0 Then
                                GenMsg = GenMsg & " Your Current Outstanding is " & UsedAmt & " Dr.  Regards EMC."
                            ElseIf UsedAmt < 0 Then
                                GenMsg = GenMsg & " Your Current Outstanding is " & UsedAmt & " Cr.  Regards EMC."
                            ElseIf UsedAmt = 0 Then
                                GenMsg = GenMsg & " Your Current Outstanding is NILL   Regards EMC."
                            End If
                            Call SendSMSProcess(GenMsg, Phoneno)
                            If Response(0) = 402 Then
                                .Row = k
                                .Col = 4
                                .Text = "Sent"
                            Else
                                .Row = k
                                .Col = 4
                                .Text = "Failed Check Phone No"
                            End If
                        Else
                            .Row = k
                            .Col = 4
                            .Text = "Failed Check Phone No"
                        End If
                    End If
                Next
            End With
            MsgBox("Done.", MsgBoxStyle.OkOnly, "EMCKOL")
        End If
    End Sub
    Private Sub Outstanding()
        Dim GenMsg, mcode As String
        Dim Phoneno As String
        Dim k As Integer
        Dim VREF As String
        If rdo_Curr.Checked = True Then
            GenMsg = "Dear Member, "
            With ssGrid
                For k = 1 To .DataRowCnt
                    GenMsg = "Dear Member, "
                    .Row = k
                    .Col = 5
                    VREF = Trim(.Text)
                    If VREF = "Yes" Then
                        GenMsg = "Dear Member, "
                        .Col = 1
                        .Row = k
                        mcode = Trim(.Text)
                        .Col = 3
                        .Row = k
                        Phoneno = Trim(.Text)
                        If Trim(Phoneno) <> "" And Len(Phoneno) = 10 And Trim(GenMsg) <> "" And Trim(mcode) <> "" Then
                            .Row = k
                            .Col = 4
                            .Text = "Sending..."
                            Call CreditBal_Check(mcode)
                            If UsedAmt > 0 Then
                                GenMsg = GenMsg & " Your Outstanding As on Rs " & UsedAmt & " Dr. Regards"
                            ElseIf UsedAmt < 0 Then
                                GenMsg = GenMsg & " Your Outstanding As on Rs " & UsedAmt & " Cr. Regards"
                            ElseIf UsedAmt = 0 Then
                                GenMsg = GenMsg & " Your Outstanding As on is NILL   Regards"
                            End If
                            Call SendSMSEMC(GenMsg, Phoneno)
                            'If Response(0) = 402 Then
                            '    .Row = k
                            '    .Col = 4
                            '    .Text = "Sent"
                            'Else
                            '    .Row = k
                            '    .Col = 4
                            '    .Text = "Failed Check Phone No"
                            'End If
                            .Row = k
                            .Col = 4
                            .Text = "Sent"
                        Else
                            .Row = k
                            .Col = 4
                            .Text = "Failed Check Phone No"
                        End If
                    End If
                Next
            End With
            MsgBox("Done.", MsgBoxStyle.OkOnly, "EMCKOL")
        End If
    End Sub
    Private Sub MonthBill()
        Dim GenMsg, mcode As String
        Dim Phoneno As String
        Dim k As Integer
        Dim VREF As String
        Dim SqlStr As String
        Dim BILDT1 As String
        Dim TYPE(0) As String
        Dim opl, i As Integer

        If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : noofdays = 30 : bildt = "01-Apr-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "30 Apr " & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31 : bildt = "01-may-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "31 May " & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30 : bildt = "01-jun-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "30-jun-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31 : bildt = "01-jul-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "31-jul-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31 : bildt = "01-aug-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "31-aug-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30 : bildt = "01-SEP-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "30-Sep-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31 : bildt = "01-OCT-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "31-Oct-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30 : bildt = "01-NOV-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "30-Nov-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31 : bildt = "01-DEC-2014" & Mid(2014, 7, 4) : BILDT1 = "31-DEC-2014" & Mid(2014, 7, 4)

        If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31 : bildt = "01-JAN-" & gFinancialyearEnd : BILDT1 = "31-Jan-" & gFinancialyearEnd
        If gFinancialyearEnd Mod 4 = 0 Then
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 29 : bildt = "01-Feb-" & gFinancialyearEnd : BILDT1 = "29-Feb-" & gFinancialyearEnd
        Else
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 28 : bildt = "01-Feb-" & gFinancialyearEnd : BILDT1 = "28-Feb-" & gFinancialyearEnd
        End If
        If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31 : bildt = "01-Mar-" & gFinancialyearEnd : BILDT1 = "31-Mar-" & gFinancialyearEnd

        SqlStr = "SELECT * FROM bengal_monthbill WHERE MONTH(BILLDATE)= " & month1 & " "
        gconnection.getDataSet(SqlStr, "Use")
        If gdataset.Tables("Use").Rows.Count > 0 Then

        Else
            '  MessageBox.Show("Bill Not Generted For this Month Plz Check", "EMC")
            MessageBox.Show("Bill Not Generted For this Month Plz Check", "CCL")
            Exit Sub
        End If
        'Dim vSdate As Date
        'Dim vEdate As Date
        'Dim vsplit() As String
        'Dim vMonthno As Integer
        'Dim vMon As String
        'Dim vMonthName As String
        'vsplit = Split(VB6.GetItemString(CbxMonth, CbxMonth.Text), "=>")
        'vMonthName = Trim(vsplit(0) & "")
        'vMonthno = CInt(Trim(vsplit(1) & ""))
        'vMon = Trim(vsplit(1) & "")
        'If CDbl(vMon) >= 4 And CDbl(vMon) <= 12 Then
        '    vSdate = CDate("01/" & vMon & "/" & Year(gFinancialyearStart))
        '    vEdate = DateAdd(Microsoft.VisualBasic.DateInterval.Month, 1, vSdate)
        '    vEdate = DateAdd(Microsoft.VisualBasic.DateInterval.Day, -1, vEdate)
        'Else
        '    vSdate = CDate("01/" & vMon & "/" & Year(gFinancialyearEnd))
        '    vEdate = DateAdd(Microsoft.VisualBasic.DateInterval.Month, 1, vSdate)
        '    vEdate = DateAdd(Microsoft.VisualBasic.DateInterval.Day, -1, vEdate)
        'End If
        'Call SendSMSDCL(vEdate, vSdate)

        If Rdb_Month.Checked = True Then
            GenMsg = "Dear Member, "
            With ssGrid
                For k = 1 To .DataRowCnt
                    GenMsg = "Dear Member, "
                    .Row = k
                    .Col = 5
                    VREF = Trim(.Text)
                    If VREF = "Yes" Then
                        GenMsg = "Dear Member, "
                        .Col = 1
                        .Row = k
                        mcode = Trim(.Text)
                        .Col = 3
                        .Row = k
                        Phoneno = Trim(.Text)
                        If Trim(Phoneno) <> "" And Len(Phoneno) = 10 And Trim(GenMsg) <> "" And Trim(mcode) <> "" Then
                            .Row = k
                            .Col = 4
                            .Text = "Sending..."
                            Call MonthBillCheck(mcode)
                            ' GenMsg = GenMsg & " Your bill for " & Trim(Me.CbxMonth.Text) & " Rs " & UsedAmt & "has been generated.Total outstanding as on " & Trim(Me.CbxMonth.Text) & " is Rs " & UsedAmt1 & "."
                            If UsedAmt > 0 Then
                                'GenMsg = GenMsg & " Your Monthly Charges for " & Trim(Me.CbxMonth.Text) & " Rs " & UsedAmt & " Regards CalcuttaClub"
                                If UsedAmt1 >= 0 Then
                                    ' GenMsg = "Your bill for " & Trim(Me.CbxMonth.Text) & " Rs " & UsedAmt & " has been generated. Outstanding as on " & BILDT1 & " is Rs " & UsedAmt1 & "."
                                    GenMsg = "(" & mcode & ") Your bill for " & Trim(Me.CbxMonth.Text) & " Rs " & UsedAmt & " has been generated. Outstanding as on " & BILDT1 & " is Rs " & UsedAmt1 & "."
                                Else
                                    'GenMsg = "Your bill for " & Trim(Me.CbxMonth.Text) & " Rs " & UsedAmt & " has been generated. Outstanding as on " & BILDT1 & " is Rs " & UsedAmt1 * -1 & "CR" & "."
                                    GenMsg = "(" & mcode & ") Your bill for " & Trim(Me.CbxMonth.Text) & " Rs " & UsedAmt & " has been generated. Balance as on " & BILDT1 & " is Rs " & UsedAmt1 * -1 & " CR" & "."
                                End If

                                'ElseIf UsedAmt < 0 Then
                                '    GenMsg = GenMsg & " Your Outstanding As on Rs " & UsedAmt & " Cr. Regards"
                                'ElseIf UsedAmt = 0 Then
                                '    GenMsg = GenMsg & " Your Monthly Charges for " & Trim(Me.CbxMonth.Text) & " NILL   Regards"
                            Else
                                GenMsg = ""
                            End If
                            'Call SendSMSEMC(GenMsg, Phoneno)
                            If GenMsg <> "" Then
                                'Call SendSMSProcess(GenMsg, Phoneno)
                                Call SendSMSEMC(GenMsg, Phoneno)
                                .Row = k
                                .Col = 4
                                .Text = "Sent"
                                ' SqlStr = "INSERT INTO SendSmsStatus VALUES('" & mcode & "'," & Response1(0) & ",'" & Format((CbxMonth.Value), "dd-MMM-yyyy") & "','" & GenMsg & "' )"
                                SqlStr = "INSERT INTO SendSmsStatus( mcode,Response1 ,BILLDATE ,Messagebox) VALUES('" & mcode & "'," & a(1) & ",'" & Format((CbxMonth.Value), "dd-MMM-yyyy") & "','" & GenMsg & "' )"
                                gconnection.ExcuteStoreProcedure(SqlStr)
                            End If
                            ''If Response1(0) = 1 Then
                            ''    .Row = k
                            ''    .Col = 4
                            ''    .Text = "Sent"
                            ''Else
                            ''    .Row = k
                            ''    .Col = 4
                            ''    .Text = "Failed Check Phone No"
                            ''End If

                        Else
                            .Row = k
                            .Col = 4
                            .Text = "Failed Check Phone No"
                        End If
                    End If
                Next
            End With
            MsgBox("Done.", MsgBoxStyle.OkOnly, "Calcuttaclub")
        End If
    End Sub
    Public Sub SendSMSDCL(ByVal Billdate As DateTime, ByVal MONTHSTARTDATE As DateTime)
        Dim Message, sqlMsg, MnthName, sqlString, User As String
        sqlMsg = "EXEC GETOUTSTANDSMS '" & Format(Billdate, "dd-MMM-yyyy") & "','" & Format(MONTHSTARTDATE, "dd-MMM-yyyy") & "'"
        gconnection.dataOperation(1, sqlMsg, "BILL")
    End Sub
    Private Sub SendSMSProcess(ByVal Msg As String, ByVal Ph As String)
        'Dim Ph1(), Msg2(), Sender() As String
        Dim Ph1() As String = {Ph}
        Dim Msg2() As String = {Msg}
        Dim Sender() As String = {"CALCLB"}
        'Dim send() As String = {"PROMO"}
        Response1 = Nothing
        Dim faser As New CalRef.Gateway
        Response1 = faser.SendSMS("calcuttaclub", "123456", Ph1, Msg2, Sender)
        'Dim Ph1() As String = {"91966666", "96966666"}
        'Dim Msg2() As String = {"Msg1", "Msg2"}
        'Dim Sender() As String = {"CALCLB", "CALCLB"}
        'Response1 = Nothing
        'Dim faser As New CalRef.Gateway
        'Response1 = faser.SendSMS("calcuttaclub", "123456", Ph1, Msg2, Sender)

        'MsgBox("Send Successfully." + msg1, MsgBoxStyle.OKOnly, "Message Sent") ---calcuttaclub&passphrase=123456
    End Sub


    Private Sub process_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles process.Click
        If rdo_Gen.Checked = True Then
            Call General()
        ElseIf rdo_Curr.Checked = True Then
            Call Outstanding()
        ElseIf Rdb_Month.Checked = True Then
            Call MonthBill()
        End If
        'Call SendSMS()
    End Sub
    Private Function CreditBal_Check(ByVal membercode As String)
        Dim SqlStr As String
        SqlStr = "SELECT SUM(ISNULL(DRAMT,0)) AS DRAMT,SUM(ISNULL(CRAMT,0)) AS CRAMT FROM CREDITLIMIT_VIEW WHERE SLCODE = '" & Trim(membercode) & "' GROUP BY SLCODE"
        gconnection.getDataSet(SqlStr, "Use")
        If gdataset.Tables("Use").Rows.Count > 0 Then
            UsedAmt = Val(gdataset.Tables("Use").Rows(0).Item(0) - gdataset.Tables("Use").Rows(0).Item(1))
        Else
            UsedAmt = 0
        End If
    End Function
    Private Function MonthBillCheck(ByVal membercode As String)
        Dim SqlStr As String
        Dim BILDT1 As String
        Dim TYPE(0) As String
        Dim opl, i As Integer

        If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : noofdays = 30 : bildt = "01-apr-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "30-apr-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31 : bildt = "01-may-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "31-may-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30 : bildt = "01-jun-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "30-jun-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31 : bildt = "01-jul-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "31-jul-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31 : bildt = "01-aug-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "31-aug-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30 : bildt = "01-SEP-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "30-SEP-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31 : bildt = "01-OCT-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "31-OCT-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30 : bildt = "01-NOV-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "30-NOV-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31 : bildt = "01-DEC-2014" & Mid(2014, 7, 4) : BILDT1 = "31-DEC-2014" & Mid(2014, 7, 4)

        If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31 : bildt = "01-JAN-" & gFinancialyearEnd : BILDT1 = "31-JAN-" & gFinancialyearEnd
        If gFinancialyearEnd Mod 4 = 0 Then
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 29 : bildt = "01-feb-" & gFinancialyearEnd : BILDT1 = "29-feb-" & gFinancialyearEnd
        Else
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 28 : bildt = "01-feb-" & gFinancialyearEnd : BILDT1 = "28-feb-" & gFinancialyearEnd
        End If
        If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31 : bildt = "01-mar-" & gFinancialyearEnd : BILDT1 = "31-mar-" & gFinancialyearEnd

        ' SqlStr = "SELECT ROUND(ISNULL(DEBIT,0)+ISNULL(OPENING,0)-isnull(CREDIT,0),0) AS DEBIT FROM MEMBERBILLSUMMARY WHERE MONTH(BILLDATE)= " & month1 & " AND mcode = '" & Trim(membercode) & "'"
        'SqlStr = "SELECT ISNULL(DEBIT,0) AS DEBIT FROM SMS_EMC WHERE MONTH(BILLDATE)= " & month1 & " AND mcode = '" & Trim(membercode) & "'"
        Dim UsedAmt2 As Double
        SqlStr = "SELECT ISNULL(debit_amount,0) AS DEBIT,ISNULL(outstanding_amt ,0)  AS CREDIT FROM bengal_monthbill WHERE MONTH(BILLDATE)= " & month1 & " AND mcode = '" & Trim(membercode) & "'"
        gconnection.getDataSet(SqlStr, "Use")
        If gdataset.Tables("Use").Rows.Count > 0 Then
            'UsedAmt1 = Val(gdataset.Tables("Use").Rows(0).Item(0))
            'For i = 0 To gdataset.Tables("Use").Rows.Count - 1
            'UsedAmt = Val(gdataset.Tables("Use").Rows(0).Item(0) - gdataset.Tables("Use").Rows(0).Item(1))
            UsedAmt = Val(gdataset.Tables("Use").Rows(0).Item("DEBIT"))
            UsedAmt1 = Val(gdataset.Tables("Use").Rows(0).Item("CREDIT"))

            ' ASONOUTSTANDING = Val(gdataset.Tables("MemPh").Rows(i).Item("ASONOUTSTANDING"))
            'Next
        Else
            UsedAmt = 0
            UsedAmt1 = 0

        End If
        'Dim UsedAmt1 As Double
        'SqlStr = "SELECT   ISNULL(outstanding_amt ,0)  AS DEBIT FROM bengal_monthbill WHERE MONTH(BILLDATE)= " & month1 & " AND mcode = '" & Trim(membercode) & "'"
        'gconnection.getDataSet(SqlStr, "Use1")
        'If gdataset.Tables("Use1").Rows.Count > 0 Then
        '    UsedAmt1 = Val(gdataset.Tables("Use1").Rows(0).Item(0))
        'Else
        '    UsedAmt1 = 0
        'End If
    End Function
    Private Sub Rdb_Month_CheckedChanged(sender As Object, e As EventArgs) Handles Rdb_Month.CheckedChanged
        If rdo_Gen.Checked = True Then
            TxtMsg.Visible = True
            CbxMonth.Visible = False
        ElseIf rdo_Curr.Checked = True Then
            TxtMsg.Visible = False
            CbxMonth.Visible = False
        ElseIf Rdb_Month.Checked = True Then
            TxtMsg.Visible = False
            CbxMonth.Visible = True
        End If
    End Sub

    Private Function HttpUtility() As Object
        Throw New NotImplementedException
    End Function

    Private Function VB6() As Object
        Throw New NotImplementedException
    End Function
    Private Sub Chk_mem_Click(sender As Object, e As EventArgs) Handles Chk_mem.Click
        If Chk_mem.Checked = True Then
            type1 = Chk_mem.Text
        Else
            type1 = ""
        End If
    End Sub
    Private Sub Chk_Spouse_Click(sender As Object, e As EventArgs) Handles Chk_Spouse.Click
        If Chk_Spouse.Checked = True Then
            type1 = Chk_Spouse.Text
        Else
            type1 = ""
        End If
    End Sub
    Private Sub chk_Filter_Field_Click(sender As Object, e As EventArgs) Handles chk_Filter_Field.Click
        ''Call SendSms_Load(sender, e)
        'Dim type1, TYPE(0) As String
        ''If chk_Filter_Field.CheckedItems.Count = 0 Then
        ''    Sqlstring = " SELECT ISNULL(MCODE,'') AS MCODE,(ISNULL(PREFIX,'')+ ' ' +ISNULL(MNAME,''))AS MNAME,REPLACE(CONTCELL,' ','')AS CONTCELL FROM MEMBERMASTER "
        ''    Sqlstring = Sqlstring & " WHERE ISNULL(CONTCELL,'') <> '' AND ISNULL(CURENTSTATUS,'') = 'ACTIVE' ORDER BY MCODE"
        ''Else
        ''type1 = ""
        'ssGrid.ClearRange(1, 1, -1, -1, True)
        'If chk_Filter_Field.CheckedItems.Count > 0 Then
        '    For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
        '        TYPE = Split(chk_Filter_Field.CheckedItems(i), ".")
        '        type1 = type1 & "'" & TYPE(0) & "', "
        '    Next
        '    type1 = Mid(type1, 1, Len(type1) - 2)
        'Else
        '    MessageBox.Show("Select the Member Type", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    chk_Filter_Field.Focus()
        '    Exit Sub
        'End If

        'Sqlstring = " SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'')AS MNAME,REPLACE(CONTCELL,' ','')AS CONTCELL  FROM SMS_MEMSPOUSEDEP "
        'Sqlstring = Sqlstring & " WHERE type1 in( " & type1 & " )  ORDER BY MCODE"
        ''End If
        'gconnection.getDataSet(Sqlstring, "Master")
        'If gdataset.Tables("Master").Rows.Count > 0 Then
        '    For i = 0 To gdataset.Tables("Master").Rows.Count - 1
        '        With ssGrid
        '            .Col = 1
        '            .Row = i + 1
        '            .Text = Trim(gdataset.Tables("Master").Rows(i).Item("MCODE"))
        '            .Col = 2
        '            .Row = i + 1
        '            .Text = Trim(gdataset.Tables("Master").Rows(i).Item("MNAME"))
        '            .Col = 3
        '            .Row = i + 1
        '            .Text = Trim(gdataset.Tables("Master").Rows(i).Item("CONTCELL"))
        '            .Col = 5
        '            .Row = i + 1
        '            .Text = "No"
        '        End With
        '    Next
        'End If
        'rdo_Gen.Checked = True
    End Sub
    Private Sub chk_PrintAll_CheckedChanged(sender As Object, e As EventArgs) Handles chk_PrintAll.CheckedChanged
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

    Private Sub chk_Filter_Field_DoubleClick(sender As Object, e As EventArgs) Handles chk_Filter_Field.DoubleClick
        Dim type1, TYPE(0) As String
        Dim memtype1, memTYPE(0) As String
        'If chk_Filter_Field.CheckedItems.Count = 0 Then
        '    Sqlstring = " SELECT ISNULL(MCODE,'') AS MCODE,(ISNULL(PREFIX,'')+ ' ' +ISNULL(MNAME,''))AS MNAME,REPLACE(CONTCELL,' ','')AS CONTCELL FROM MEMBERMASTER "
        '    Sqlstring = Sqlstring & " WHERE ISNULL(CONTCELL,'') <> '' AND ISNULL(CURENTSTATUS,'') = 'ACTIVE' ORDER BY MCODE"
        'Else
        'type1 = ""
        ssGrid.ClearRange(1, 1, -1, -1, True)
        ' Call Fillcat()
        If Select_Category.CheckedItems.Count > 0 Then
            For i = 0 To Select_Category.CheckedItems.Count - 1
                memTYPE = Split(Select_Category.CheckedItems(i), ".")
                memtype1 = memtype1 & "'" & memTYPE(0) & "', "
            Next
            memtype1 = Mid(memtype1, 1, Len(memtype1) - 2)
        Else
            MessageBox.Show("Select the Member Type", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Select_Category.Focus()
            Exit Sub
        End If

        If chk_Filter_Field.CheckedItems.Count > 0 Then
            For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                TYPE = Split(chk_Filter_Field.CheckedItems(i), ".")
                type1 = type1 & "'" & TYPE(0) & "', "
            Next
            type1 = Mid(type1, 1, Len(type1) - 2)
        Else
            'MessageBox.Show("Select the Member Type", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            chk_Filter_Field.Focus()
            Exit Sub
        End If
        Sqlstring = " SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'')AS MNAME,REPLACE(CONTCELL,' ','')AS CONTCELL  FROM SMS_MEMSPOUSEDEP "
        Sqlstring = Sqlstring & " WHERE   MEMBERTYPE in (" & memtype1 & ") and  type1 in( " & type1 & " )    ORDER BY MCODE"
        'End If
        gconnection.getDataSet(Sqlstring, "Master")
        If gdataset.Tables("Master").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("Master").Rows.Count - 1
                With ssGrid
                    .Col = 1
                    .Row = i + 1
                    .Text = Trim(gdataset.Tables("Master").Rows(i).Item("MCODE"))
                    .Col = 2
                    .Row = i + 1
                    .Text = Trim(gdataset.Tables("Master").Rows(i).Item("MNAME"))
                    .Col = 3
                    .Row = i + 1
                    .Text = Trim(gdataset.Tables("Master").Rows(i).Item("CONTCELL"))
                    .Col = 5
                    .Row = i + 1
                    .Text = "No"
                End With
            Next
        End If
        rdo_Gen.Checked = True
    End Sub
    Private Sub chk_Filter_Field_Enter(sender As Object, e As EventArgs) Handles chk_Filter_Field.Enter
        Dim type1, TYPE(0) As String
        Dim memtype1, memTYPE(0) As String
        'If chk_Filter_Field.CheckedItems.Count = 0 Then
        '    Sqlstring = " SELECT ISNULL(MCODE,'') AS MCODE,(ISNULL(PREFIX,'')+ ' ' +ISNULL(MNAME,''))AS MNAME,REPLACE(CONTCELL,' ','')AS CONTCELL FROM MEMBERMASTER "
        '    Sqlstring = Sqlstring & " WHERE ISNULL(CONTCELL,'') <> '' AND ISNULL(CURENTSTATUS,'') = 'ACTIVE' ORDER BY MCODE"
        'Else
        'type1 = ""
        ssGrid.ClearRange(1, 1, -1, -1, True)
        If Select_Category.CheckedItems.Count > 0 Then
            For i = 0 To Select_Category.CheckedItems.Count - 1
                memTYPE = Split(Select_Category.CheckedItems(i), ".")
                memtype1 = memtype1 & "'" & memTYPE(0) & "', "
            Next
            memtype1 = Mid(memtype1, 1, Len(memtype1) - 2)
        Else
            MessageBox.Show("Select the Member Type", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Select_Category.Focus()
            Exit Sub
        End If

        If chk_Filter_Field.CheckedItems.Count > 0 Then
            For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                TYPE = Split(chk_Filter_Field.CheckedItems(i), ".")
                type1 = type1 & "'" & TYPE(0) & "', "
            Next
            type1 = Mid(type1, 1, Len(type1) - 2)
        Else
            'MessageBox.Show("Select the Member Type", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            chk_Filter_Field.Focus()
            Exit Sub
        End If

        Sqlstring = " SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'')AS MNAME,REPLACE(CONTCELL,' ','')AS CONTCELL  FROM SMS_MEMSPOUSEDEP "
        Sqlstring = Sqlstring & " WHERE  MEMBERTYPE in (" & memtype1 & ")  and type1 in( " & type1 & " )  ORDER BY MCODE"
        'End If
        gconnection.getDataSet(Sqlstring, "Master")
        If gdataset.Tables("Master").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("Master").Rows.Count - 1
                With ssGrid
                    .Col = 1
                    .Row = i + 1
                    .Text = Trim(gdataset.Tables("Master").Rows(i).Item("MCODE"))
                    .Col = 2
                    .Row = i + 1
                    .Text = Trim(gdataset.Tables("Master").Rows(i).Item("MNAME"))
                    .Col = 3
                    .Row = i + 1
                    .Text = Trim(gdataset.Tables("Master").Rows(i).Item("CONTCELL"))
                    .Col = 5
                    .Row = i + 1
                    .Text = "No"
                End With
            Next
        End If
        rdo_Gen.Checked = True
    End Sub
    Private Sub chk_Filter_Field_KeyDown(sender As Object, e As KeyEventArgs) Handles chk_Filter_Field.KeyDown
        Dim type1, TYPE(0) As String
        Dim memtype1, memTYPE(0) As String
        'If chk_Filter_Field.CheckedItems.Count = 0 Then
        '    Sqlstring = " SELECT ISNULL(MCODE,'') AS MCODE,(ISNULL(PREFIX,'')+ ' ' +ISNULL(MNAME,''))AS MNAME,REPLACE(CONTCELL,' ','')AS CONTCELL FROM MEMBERMASTER "
        '    Sqlstring = Sqlstring & " WHERE ISNULL(CONTCELL,'') <> '' AND ISNULL(CURENTSTATUS,'') = 'ACTIVE' ORDER BY MCODE"
        'Else
        'type1 = ""
        ssGrid.ClearRange(1, 1, -1, -1, True)
        'Call Fillcat()
        If Select_Category.CheckedItems.Count > 0 Then
            For i = 0 To Select_Category.CheckedItems.Count - 1
                memTYPE = Split(Select_Category.CheckedItems(i), ".")
                memtype1 = memtype1 & "'" & memTYPE(0) & "', "
            Next
            memtype1 = Mid(memtype1, 1, Len(memtype1) - 2)
        Else
            MessageBox.Show("Select the Member Type", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Select_Category.Focus()
            Exit Sub
        End If

        If chk_Filter_Field.CheckedItems.Count > 0 Then
            For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                TYPE = Split(chk_Filter_Field.CheckedItems(i), ".")
                type1 = type1 & "'" & TYPE(0) & "', "
            Next
            type1 = Mid(type1, 1, Len(type1) - 2)
        Else
            ' MessageBox.Show("Select the Member Type", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            chk_Filter_Field.Focus()
            Exit Sub
        End If

        Sqlstring = " SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'')AS MNAME,REPLACE(CONTCELL,' ','')AS CONTCELL  FROM SMS_MEMSPOUSEDEP "
        Sqlstring = Sqlstring & " WHERE  MEMBERTYPE in (" & memtype1 & ")  and type1 in( " & type1 & " )  ORDER BY MCODE"
        'End If
        gconnection.getDataSet(Sqlstring, "Master")
        If gdataset.Tables("Master").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("Master").Rows.Count - 1
                With ssGrid
                    .Col = 1
                    .Row = i + 1
                    .Text = Trim(gdataset.Tables("Master").Rows(i).Item("MCODE"))
                    .Col = 2
                    .Row = i + 1
                    .Text = Trim(gdataset.Tables("Master").Rows(i).Item("MNAME"))
                    .Col = 3
                    .Row = i + 1
                    .Text = Trim(gdataset.Tables("Master").Rows(i).Item("CONTCELL"))
                    .Col = 5
                    .Row = i + 1
                    .Text = "No"
                End With
            Next
        End If
        rdo_Gen.Checked = True
    End Sub
    Private Sub Lbl_Count_Leave(sender As Object, e As EventArgs) Handles Lbl_Count.Leave
        Dim count As Integer = 0
        TxtMsg.Text = TxtMsg.Text
        Lbl_Count.Text = TxtMsg.Text.Split(" ").Length - 1
    End Sub
    Private Sub TxtMsg_TextChanged(sender As Object, e As EventArgs) Handles TxtMsg.TextChanged
        Lbl_Count.Text = Len(TxtMsg.Text) / 160
        If Lbl_Count.Text < "1.00625" Then
            Lbl_Count.Text = "1 SMS"
        ElseIf Lbl_Count.Text > "1.00625" And Lbl_Count.Text < "2.00625" Then
            Lbl_Count.Text = "2 SMS"
        ElseIf Lbl_Count.Text > "2.00625" And Lbl_Count.Text < "3.00625" Then
            Lbl_Count.Text = "3 SMS"
        ElseIf Lbl_Count.Text > "3.00625" And Lbl_Count.Text < "4.00625" Then
            Lbl_Count.Text = "4 SMS"
        ElseIf Lbl_Count.Text > "4.00625" And Lbl_Count.Text < "5.00625" Then
            Lbl_Count.Text = "4 SMS"
        ElseIf Lbl_Count.Text > "5.00625" And Lbl_Count.Text < "5.00625" Then
            Lbl_Count.Text = "5 SMS"
        ElseIf Lbl_Count.Text > "6.00625" And Lbl_Count.Text < "7.00625" Then
            Lbl_Count.Text = "6 SMS"
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim Iteration As Integer
        If CheckBox1.Checked = True Then
            Try
                For Iteration = 0 To (Select_Category.Items.Count - 1)
                    Select_Category.SetSelected(Iteration, True)
                    Select_Category.SetItemChecked(Iteration, True)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                For Iteration = 0 To (Select_Category.Items.Count - 1)
                    Select_Category.SetItemChecked(Iteration, False)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
End Class
