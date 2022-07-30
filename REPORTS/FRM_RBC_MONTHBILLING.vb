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
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Microsoft.VisualBasic
Imports System.Net
Imports System.Text
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.HtmlControls
Imports System.Web.UI.WebControls
Public Class FRM_RBC_MONTHBILLING
    Inherits System.Windows.Forms.Form
    Dim sqlstring, sqlstring1, sqlstring2, sqlstring3, ssql, ssql1, ssql2, SSQL3, SSQL4, SSQL5, ssql6, bildt, duedt As String
    Dim gconnection As New GlobalClass
    Dim month1, noofdays As Integer
    Dim posting, posting1, dt As New DataTable
    Private objProxy1 As WebProxy = Nothing
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Rdb_ECS As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb_Previousbill As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb_Doller As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_print As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Dim GCONN As New GlobalClass

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
    Friend WithEvents cmd_view As System.Windows.Forms.Button
    Friend WithEvents Btn_close As System.Windows.Forms.Button
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents txt_Tomcode As System.Windows.Forms.TextBox
    Friend WithEvents txt_Tomname As System.Windows.Forms.TextBox
    Friend WithEvents txt_mcode As System.Windows.Forms.TextBox
    Friend WithEvents cmd_MemberCodeHelp1 As System.Windows.Forms.Button
    Friend WithEvents txt_mname As System.Windows.Forms.TextBox
    Friend WithEvents cmd_MemberCodeHelp As System.Windows.Forms.Button
    Friend WithEvents chk_PrintAll As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chk_Filter_Field As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CbxMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPduedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Rnd_Summary As System.Windows.Forms.RadioButton
    Friend WithEvents Rnd_Details As System.Windows.Forms.RadioButton
    Friend WithEvents txt_note As System.Windows.Forms.TextBox
    Friend WithEvents Gbx_summardet As System.Windows.Forms.GroupBox
    Friend WithEvents RDOCOMBINEDYES As System.Windows.Forms.RadioButton
    Friend WithEvents RDOCOMBINEDNO As System.Windows.Forms.RadioButton
    Friend WithEvents LBL_COMBINED As System.Windows.Forms.Label
    Friend WithEvents Rnd_summardet As System.Windows.Forms.RadioButton
    Friend WithEvents PIC1 As System.Windows.Forms.PictureBox
    Friend WithEvents RND_billforward As System.Windows.Forms.RadioButton
    Friend WithEvents Rnd_Posdetails As System.Windows.Forms.RadioButton
    Friend WithEvents Rnd_subscription As System.Windows.Forms.RadioButton
    Friend WithEvents Btn_Excel As System.Windows.Forms.Button
    Friend WithEvents Rnd_Xml As System.Windows.Forms.RadioButton
    Friend WithEvents Rnd_Billutil As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_msg As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_RBC_MONTHBILLING))
        Me.cmd_view = New System.Windows.Forms.Button()
        Me.Btn_close = New System.Windows.Forms.Button()
        Me.cmd_Clear = New System.Windows.Forms.Button()
        Me.txt_Tomcode = New System.Windows.Forms.TextBox()
        Me.txt_Tomname = New System.Windows.Forms.TextBox()
        Me.txt_mcode = New System.Windows.Forms.TextBox()
        Me.cmd_MemberCodeHelp1 = New System.Windows.Forms.Button()
        Me.txt_mname = New System.Windows.Forms.TextBox()
        Me.cmd_MemberCodeHelp = New System.Windows.Forms.Button()
        Me.chk_PrintAll = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chk_Filter_Field = New System.Windows.Forms.CheckedListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CbxMonth = New System.Windows.Forms.DateTimePicker()
        Me.DTPduedate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Rnd_Summary = New System.Windows.Forms.RadioButton()
        Me.Rnd_Details = New System.Windows.Forms.RadioButton()
        Me.Btn_Excel = New System.Windows.Forms.Button()
        Me.txt_note = New System.Windows.Forms.TextBox()
        Me.Gbx_summardet = New System.Windows.Forms.GroupBox()
        Me.Rdb_Doller = New System.Windows.Forms.RadioButton()
        Me.Rdb_Previousbill = New System.Windows.Forms.RadioButton()
        Me.Rdb_ECS = New System.Windows.Forms.RadioButton()
        Me.Rnd_Xml = New System.Windows.Forms.RadioButton()
        Me.Rnd_Posdetails = New System.Windows.Forms.RadioButton()
        Me.Rnd_subscription = New System.Windows.Forms.RadioButton()
        Me.RDOCOMBINEDYES = New System.Windows.Forms.RadioButton()
        Me.RDOCOMBINEDNO = New System.Windows.Forms.RadioButton()
        Me.LBL_COMBINED = New System.Windows.Forms.Label()
        Me.Rnd_summardet = New System.Windows.Forms.RadioButton()
        Me.RND_billforward = New System.Windows.Forms.RadioButton()
        Me.Rnd_Billutil = New System.Windows.Forms.RadioButton()
        Me.PIC1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_msg = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.cmd_print = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Gbx_summardet.SuspendLayout()
        CType(Me.PIC1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmd_view
        '
        Me.cmd_view.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_view.ForeColor = System.Drawing.Color.Black
        Me.cmd_view.Image = Global.Bengal_MemberMaster.My.Resources.Resources.view
        Me.cmd_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_view.Location = New System.Drawing.Point(4, 80)
        Me.cmd_view.Name = "cmd_view"
        Me.cmd_view.Size = New System.Drawing.Size(137, 50)
        Me.cmd_view.TabIndex = 12
        Me.cmd_view.Text = "VIEW [F9]"
        Me.cmd_view.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Btn_close
        '
        Me.Btn_close.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_close.ForeColor = System.Drawing.Color.Black
        Me.Btn_close.Image = Global.Bengal_MemberMaster.My.Resources.Resources._Exit
        Me.Btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_close.Location = New System.Drawing.Point(4, 141)
        Me.Btn_close.Name = "Btn_close"
        Me.Btn_close.Size = New System.Drawing.Size(137, 50)
        Me.Btn_close.TabIndex = 14
        Me.Btn_close.Text = "Exit [F11]"
        Me.Btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmd_Clear
        '
        Me.cmd_Clear.BackColor = System.Drawing.Color.Transparent
        Me.cmd_Clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Clear.ForeColor = System.Drawing.Color.Black
        Me.cmd_Clear.Image = Global.Bengal_MemberMaster.My.Resources.Resources.Clear
        Me.cmd_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Clear.Location = New System.Drawing.Point(4, 19)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(137, 50)
        Me.cmd_Clear.TabIndex = 438
        Me.cmd_Clear.Text = "Clear[F6]"
        Me.cmd_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_Clear.UseVisualStyleBackColor = False
        '
        'txt_Tomcode
        '
        Me.txt_Tomcode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Tomcode.Location = New System.Drawing.Point(492, 351)
        Me.txt_Tomcode.Name = "txt_Tomcode"
        Me.txt_Tomcode.Size = New System.Drawing.Size(120, 22)
        Me.txt_Tomcode.TabIndex = 606
        '
        'txt_Tomname
        '
        Me.txt_Tomname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Tomname.Location = New System.Drawing.Point(492, 383)
        Me.txt_Tomname.Name = "txt_Tomname"
        Me.txt_Tomname.Size = New System.Drawing.Size(224, 22)
        Me.txt_Tomname.TabIndex = 608
        '
        'txt_mcode
        '
        Me.txt_mcode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mcode.Location = New System.Drawing.Point(268, 351)
        Me.txt_mcode.Name = "txt_mcode"
        Me.txt_mcode.Size = New System.Drawing.Size(120, 22)
        Me.txt_mcode.TabIndex = 603
        '
        'cmd_MemberCodeHelp1
        '
        Me.cmd_MemberCodeHelp1.BackColor = System.Drawing.Color.Transparent
        Me.cmd_MemberCodeHelp1.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources._400_F_9130045_3SaKfvCqFL4hRJm59cddsCnbx5YyqvYj
        Me.cmd_MemberCodeHelp1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_MemberCodeHelp1.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MemberCodeHelp1.Location = New System.Drawing.Point(615, 351)
        Me.cmd_MemberCodeHelp1.Name = "cmd_MemberCodeHelp1"
        Me.cmd_MemberCodeHelp1.Size = New System.Drawing.Size(40, 23)
        Me.cmd_MemberCodeHelp1.TabIndex = 607
        Me.cmd_MemberCodeHelp1.UseVisualStyleBackColor = False
        '
        'txt_mname
        '
        Me.txt_mname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mname.Location = New System.Drawing.Point(268, 383)
        Me.txt_mname.Name = "txt_mname"
        Me.txt_mname.Size = New System.Drawing.Size(208, 22)
        Me.txt_mname.TabIndex = 605
        '
        'cmd_MemberCodeHelp
        '
        Me.cmd_MemberCodeHelp.BackColor = System.Drawing.Color.Transparent
        Me.cmd_MemberCodeHelp.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources._400_F_9130045_3SaKfvCqFL4hRJm59cddsCnbx5YyqvYj
        Me.cmd_MemberCodeHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_MemberCodeHelp.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MemberCodeHelp.Location = New System.Drawing.Point(396, 351)
        Me.cmd_MemberCodeHelp.Name = "cmd_MemberCodeHelp"
        Me.cmd_MemberCodeHelp.Size = New System.Drawing.Size(40, 23)
        Me.cmd_MemberCodeHelp.TabIndex = 604
        Me.cmd_MemberCodeHelp.UseVisualStyleBackColor = False
        '
        'chk_PrintAll
        '
        Me.chk_PrintAll.BackColor = System.Drawing.Color.Transparent
        Me.chk_PrintAll.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PrintAll.Location = New System.Drawing.Point(261, 138)
        Me.chk_PrintAll.Name = "chk_PrintAll"
        Me.chk_PrintAll.Size = New System.Drawing.Size(264, 21)
        Me.chk_PrintAll.TabIndex = 610
        Me.chk_PrintAll.Text = "Select All Categorys"
        Me.chk_PrintAll.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(188, 351)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 611
        Me.Label3.Text = "MCODE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(188, 383)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 612
        Me.Label1.Text = "MNAME"
        '
        'chk_Filter_Field
        '
        Me.chk_Filter_Field.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.chk_Filter_Field.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Filter_Field.Location = New System.Drawing.Point(6, 16)
        Me.chk_Filter_Field.Name = "chk_Filter_Field"
        Me.chk_Filter_Field.Size = New System.Drawing.Size(368, 157)
        Me.chk_Filter_Field.Sorted = True
        Me.chk_Filter_Field.TabIndex = 609
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(257, 119)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(224, 16)
        Me.Label10.TabIndex = 602
        Me.Label10.Text = "MEMBER BILL FOR THE MONTH OF : "
        '
        'CbxMonth
        '
        Me.CbxMonth.CalendarMonthBackground = System.Drawing.Color.White
        Me.CbxMonth.CustomFormat = "MMMMM"
        Me.CbxMonth.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CbxMonth.Location = New System.Drawing.Point(481, 115)
        Me.CbxMonth.Name = "CbxMonth"
        Me.CbxMonth.Size = New System.Drawing.Size(128, 22)
        Me.CbxMonth.TabIndex = 601
        '
        'DTPduedate
        '
        Me.DTPduedate.CustomFormat = "dd/MM/yyyy"
        Me.DTPduedate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPduedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPduedate.Location = New System.Drawing.Point(268, 415)
        Me.DTPduedate.Name = "DTPduedate"
        Me.DTPduedate.Size = New System.Drawing.Size(144, 22)
        Me.DTPduedate.TabIndex = 626
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(188, 415)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 625
        Me.Label5.Text = "DUE DATE"
        '
        'Rnd_Summary
        '
        Me.Rnd_Summary.BackColor = System.Drawing.Color.Transparent
        Me.Rnd_Summary.Checked = True
        Me.Rnd_Summary.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rnd_Summary.Location = New System.Drawing.Point(280, 8)
        Me.Rnd_Summary.Name = "Rnd_Summary"
        Me.Rnd_Summary.Size = New System.Drawing.Size(104, 24)
        Me.Rnd_Summary.TabIndex = 628
        Me.Rnd_Summary.TabStop = True
        Me.Rnd_Summary.Text = "Bill"
        Me.Rnd_Summary.UseVisualStyleBackColor = False
        Me.Rnd_Summary.Visible = False
        '
        'Rnd_Details
        '
        Me.Rnd_Details.BackColor = System.Drawing.Color.Transparent
        Me.Rnd_Details.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rnd_Details.Location = New System.Drawing.Point(280, 35)
        Me.Rnd_Details.Name = "Rnd_Details"
        Me.Rnd_Details.Size = New System.Drawing.Size(104, 16)
        Me.Rnd_Details.TabIndex = 627
        Me.Rnd_Details.Text = "Bill Annexure"
        Me.Rnd_Details.UseVisualStyleBackColor = False
        Me.Rnd_Details.Visible = False
        '
        'Btn_Excel
        '
        Me.Btn_Excel.BackgroundImage = CType(resources.GetObject("Btn_Excel.BackgroundImage"), System.Drawing.Image)
        Me.Btn_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Excel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Excel.ForeColor = System.Drawing.Color.White
        Me.Btn_Excel.Location = New System.Drawing.Point(-24, 560)
        Me.Btn_Excel.Name = "Btn_Excel"
        Me.Btn_Excel.Size = New System.Drawing.Size(104, 32)
        Me.Btn_Excel.TabIndex = 639
        Me.Btn_Excel.Text = "Excel[F12]"
        Me.Btn_Excel.Visible = False
        '
        'txt_note
        '
        Me.txt_note.Location = New System.Drawing.Point(659, 537)
        Me.txt_note.Multiline = True
        Me.txt_note.Name = "txt_note"
        Me.txt_note.Size = New System.Drawing.Size(16, 32)
        Me.txt_note.TabIndex = 630
        Me.txt_note.Visible = False
        '
        'Gbx_summardet
        '
        Me.Gbx_summardet.BackColor = System.Drawing.Color.Transparent
        Me.Gbx_summardet.Controls.Add(Me.Rdb_Doller)
        Me.Gbx_summardet.Controls.Add(Me.Rdb_Previousbill)
        Me.Gbx_summardet.Controls.Add(Me.Rdb_ECS)
        Me.Gbx_summardet.Controls.Add(Me.Rnd_Xml)
        Me.Gbx_summardet.Controls.Add(Me.Rnd_Posdetails)
        Me.Gbx_summardet.Controls.Add(Me.Rnd_subscription)
        Me.Gbx_summardet.Controls.Add(Me.RDOCOMBINEDYES)
        Me.Gbx_summardet.Controls.Add(Me.RDOCOMBINEDNO)
        Me.Gbx_summardet.Controls.Add(Me.LBL_COMBINED)
        Me.Gbx_summardet.Controls.Add(Me.Rnd_Summary)
        Me.Gbx_summardet.Controls.Add(Me.Rnd_Details)
        Me.Gbx_summardet.Controls.Add(Me.Rnd_summardet)
        Me.Gbx_summardet.Controls.Add(Me.RND_billforward)
        Me.Gbx_summardet.Controls.Add(Me.Rnd_Billutil)
        Me.Gbx_summardet.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gbx_summardet.Location = New System.Drawing.Point(196, 516)
        Me.Gbx_summardet.Name = "Gbx_summardet"
        Me.Gbx_summardet.Size = New System.Drawing.Size(584, 96)
        Me.Gbx_summardet.TabIndex = 637
        Me.Gbx_summardet.TabStop = False
        Me.Gbx_summardet.Text = "PRINT DETAILS"
        '
        'Rdb_Doller
        '
        Me.Rdb_Doller.BackColor = System.Drawing.Color.Transparent
        Me.Rdb_Doller.Checked = True
        Me.Rdb_Doller.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdb_Doller.Location = New System.Drawing.Point(205, 69)
        Me.Rdb_Doller.Name = "Rdb_Doller"
        Me.Rdb_Doller.Size = New System.Drawing.Size(61, 24)
        Me.Rdb_Doller.TabIndex = 658
        Me.Rdb_Doller.TabStop = True
        Me.Rdb_Doller.Text = "NRIBill"
        Me.Rdb_Doller.UseVisualStyleBackColor = False
        '
        'Rdb_Previousbill
        '
        Me.Rdb_Previousbill.BackColor = System.Drawing.Color.Transparent
        Me.Rdb_Previousbill.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdb_Previousbill.Location = New System.Drawing.Point(109, 66)
        Me.Rdb_Previousbill.Name = "Rdb_Previousbill"
        Me.Rdb_Previousbill.Size = New System.Drawing.Size(104, 24)
        Me.Rdb_Previousbill.TabIndex = 657
        Me.Rdb_Previousbill.Text = "Previous bill"
        Me.Rdb_Previousbill.UseVisualStyleBackColor = False
        '
        'Rdb_ECS
        '
        Me.Rdb_ECS.BackColor = System.Drawing.Color.Transparent
        Me.Rdb_ECS.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdb_ECS.Location = New System.Drawing.Point(18, 64)
        Me.Rdb_ECS.Name = "Rdb_ECS"
        Me.Rdb_ECS.Size = New System.Drawing.Size(118, 24)
        Me.Rdb_ECS.TabIndex = 656
        Me.Rdb_ECS.Text = "ECS"
        Me.Rdb_ECS.UseVisualStyleBackColor = False
        '
        'Rnd_Xml
        '
        Me.Rnd_Xml.BackColor = System.Drawing.Color.Transparent
        Me.Rnd_Xml.Checked = True
        Me.Rnd_Xml.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rnd_Xml.Location = New System.Drawing.Point(416, 8)
        Me.Rnd_Xml.Name = "Rnd_Xml"
        Me.Rnd_Xml.Size = New System.Drawing.Size(144, 24)
        Me.Rnd_Xml.TabIndex = 655
        Me.Rnd_Xml.TabStop = True
        Me.Rnd_Xml.Text = "Xml"
        Me.Rnd_Xml.UseVisualStyleBackColor = False
        '
        'Rnd_Posdetails
        '
        Me.Rnd_Posdetails.BackColor = System.Drawing.Color.Transparent
        Me.Rnd_Posdetails.Checked = True
        Me.Rnd_Posdetails.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rnd_Posdetails.Location = New System.Drawing.Point(448, 72)
        Me.Rnd_Posdetails.Name = "Rnd_Posdetails"
        Me.Rnd_Posdetails.Size = New System.Drawing.Size(144, 24)
        Me.Rnd_Posdetails.TabIndex = 654
        Me.Rnd_Posdetails.TabStop = True
        Me.Rnd_Posdetails.Text = "POS"
        Me.Rnd_Posdetails.UseVisualStyleBackColor = False
        Me.Rnd_Posdetails.Visible = False
        '
        'Rnd_subscription
        '
        Me.Rnd_subscription.BackColor = System.Drawing.Color.Transparent
        Me.Rnd_subscription.Checked = True
        Me.Rnd_subscription.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rnd_subscription.Location = New System.Drawing.Point(416, 8)
        Me.Rnd_subscription.Name = "Rnd_subscription"
        Me.Rnd_subscription.Size = New System.Drawing.Size(144, 24)
        Me.Rnd_subscription.TabIndex = 653
        Me.Rnd_subscription.TabStop = True
        Me.Rnd_subscription.Text = "SUBSSCRIPTION"
        Me.Rnd_subscription.UseVisualStyleBackColor = False
        Me.Rnd_subscription.Visible = False
        '
        'RDOCOMBINEDYES
        '
        Me.RDOCOMBINEDYES.BackColor = System.Drawing.Color.Transparent
        Me.RDOCOMBINEDYES.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDOCOMBINEDYES.Location = New System.Drawing.Point(152, 29)
        Me.RDOCOMBINEDYES.Name = "RDOCOMBINEDYES"
        Me.RDOCOMBINEDYES.Size = New System.Drawing.Size(48, 24)
        Me.RDOCOMBINEDYES.TabIndex = 629
        Me.RDOCOMBINEDYES.Text = "YES"
        Me.RDOCOMBINEDYES.UseVisualStyleBackColor = False
        Me.RDOCOMBINEDYES.Visible = False
        '
        'RDOCOMBINEDNO
        '
        Me.RDOCOMBINEDNO.BackColor = System.Drawing.Color.Transparent
        Me.RDOCOMBINEDNO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDOCOMBINEDNO.Location = New System.Drawing.Point(208, 29)
        Me.RDOCOMBINEDNO.Name = "RDOCOMBINEDNO"
        Me.RDOCOMBINEDNO.Size = New System.Drawing.Size(48, 24)
        Me.RDOCOMBINEDNO.TabIndex = 630
        Me.RDOCOMBINEDNO.Text = "NO"
        Me.RDOCOMBINEDNO.UseVisualStyleBackColor = False
        Me.RDOCOMBINEDNO.Visible = False
        '
        'LBL_COMBINED
        '
        Me.LBL_COMBINED.AutoSize = True
        Me.LBL_COMBINED.BackColor = System.Drawing.Color.Transparent
        Me.LBL_COMBINED.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_COMBINED.Location = New System.Drawing.Point(16, 32)
        Me.LBL_COMBINED.Name = "LBL_COMBINED"
        Me.LBL_COMBINED.Size = New System.Drawing.Size(120, 16)
        Me.LBL_COMBINED.TabIndex = 631
        Me.LBL_COMBINED.Text = "COMBINED PRINT"
        Me.LBL_COMBINED.Visible = False
        '
        'Rnd_summardet
        '
        Me.Rnd_summardet.BackColor = System.Drawing.Color.Transparent
        Me.Rnd_summardet.Checked = True
        Me.Rnd_summardet.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rnd_summardet.Location = New System.Drawing.Point(280, 32)
        Me.Rnd_summardet.Name = "Rnd_summardet"
        Me.Rnd_summardet.Size = New System.Drawing.Size(96, 24)
        Me.Rnd_summardet.TabIndex = 632
        Me.Rnd_summardet.TabStop = True
        Me.Rnd_summardet.Text = "Bill/Annexure"
        Me.Rnd_summardet.UseVisualStyleBackColor = False
        Me.Rnd_summardet.Visible = False
        '
        'RND_billforward
        '
        Me.RND_billforward.BackColor = System.Drawing.Color.Transparent
        Me.RND_billforward.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RND_billforward.Location = New System.Drawing.Point(280, 64)
        Me.RND_billforward.Name = "RND_billforward"
        Me.RND_billforward.Size = New System.Drawing.Size(256, 24)
        Me.RND_billforward.TabIndex = 643
        Me.RND_billforward.Text = "Summary Details"
        Me.RND_billforward.UseVisualStyleBackColor = False
        '
        'Rnd_Billutil
        '
        Me.Rnd_Billutil.BackColor = System.Drawing.Color.Transparent
        Me.Rnd_Billutil.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rnd_Billutil.Location = New System.Drawing.Point(419, 40)
        Me.Rnd_Billutil.Name = "Rnd_Billutil"
        Me.Rnd_Billutil.Size = New System.Drawing.Size(136, 16)
        Me.Rnd_Billutil.TabIndex = 644
        Me.Rnd_Billutil.Text = "BILL+UTILISATION"
        Me.Rnd_Billutil.UseVisualStyleBackColor = False
        Me.Rnd_Billutil.Visible = False
        '
        'PIC1
        '
        Me.PIC1.Location = New System.Drawing.Point(712, 124)
        Me.PIC1.Name = "PIC1"
        Me.PIC1.Size = New System.Drawing.Size(112, 104)
        Me.PIC1.TabIndex = 638
        Me.PIC1.TabStop = False
        Me.PIC1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(188, 457)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 639
        Me.Label2.Text = "REMARKS"
        '
        'txt_msg
        '
        Me.txt_msg.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_msg.Location = New System.Drawing.Point(268, 449)
        Me.txt_msg.Multiline = True
        Me.txt_msg.Name = "txt_msg"
        Me.txt_msg.Size = New System.Drawing.Size(424, 48)
        Me.txt_msg.TabIndex = 640
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(191, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(229, 28)
        Me.Label4.TabIndex = 641
        Me.Label4.Text = "MONTH BILL"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(4, 205)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 50)
        Me.Button1.TabIndex = 643
        Me.Button1.Text = "GENERATE PDF"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(330, 351)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 118)
        Me.GroupBox1.TabIndex = 644
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(234, 74)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(109, 41)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "CLOSE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(111, 74)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 42)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "REMIND ME LATER"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(15, 74)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 41)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "OK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.cmd_print)
        Me.GroupBox2.Controls.Add(Me.cmd_Clear)
        Me.GroupBox2.Controls.Add(Me.Btn_close)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.cmd_view)
        Me.GroupBox2.Location = New System.Drawing.Point(859, 119)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(147, 450)
        Me.GroupBox2.TabIndex = 645
        Me.GroupBox2.TabStop = False
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources.images2
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(6, 385)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(137, 50)
        Me.Button6.TabIndex = 647
        Me.Button6.Text = "SMS"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Image = Global.Bengal_MemberMaster.My.Resources.Resources.view
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(6, 328)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(137, 50)
        Me.Button5.TabIndex = 645
        Me.Button5.Text = "DOS VIEW"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmd_print
        '
        Me.cmd_print.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_print.ForeColor = System.Drawing.Color.Black
        Me.cmd_print.Image = Global.Bengal_MemberMaster.My.Resources.Resources.view
        Me.cmd_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_print.Location = New System.Drawing.Point(6, 264)
        Me.cmd_print.Name = "cmd_print"
        Me.cmd_print.Size = New System.Drawing.Size(137, 50)
        Me.cmd_print.TabIndex = 644
        Me.cmd_print.Text = "DOS PRINT"
        Me.cmd_print.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.chk_Filter_Field)
        Me.GroupBox3.Location = New System.Drawing.Point(255, 158)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(381, 178)
        Me.GroupBox3.TabIndex = 646
        Me.GroupBox3.TabStop = False
        '
        'FRM_RBC_MONTHBILLING
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources._111in1024res
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_msg)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_note)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_Tomcode)
        Me.Controls.Add(Me.txt_Tomname)
        Me.Controls.Add(Me.txt_mcode)
        Me.Controls.Add(Me.txt_mname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PIC1)
        Me.Controls.Add(Me.DTPduedate)
        Me.Controls.Add(Me.cmd_MemberCodeHelp1)
        Me.Controls.Add(Me.cmd_MemberCodeHelp)
        Me.Controls.Add(Me.chk_PrintAll)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CbxMonth)
        Me.Controls.Add(Me.Gbx_summardet)
        Me.Controls.Add(Me.Btn_Excel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_RBC_MONTHBILLING"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MonthBilling"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Gbx_summardet.ResumeLayout(False)
        Me.Gbx_summardet.PerformLayout()
        CType(Me.PIC1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub cmd_view_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_view.Click
        If Rnd_Summary.Checked = True Then
            If gcompanyname = "HYDERABAD GOLF ASSOCIATION" Or gcompanyname = "HGA1112" Then
                Call GETSUMMARY_PRINT()
            ElseIf Mid(UCase(Trim(gcompanyname)), 1, 3) = "MLA" Then
                GESUMMARYANDDETAILS1()
            Else
                Call GETSUMMARY_PRINT_OTHERS()
            End If
        End If
        If Rnd_Billutil.Checked = True Then
            Call pdfgen()
            Exit Sub
        End If
        If RND_billforward.Checked = True Then
            If gcompanyname = "HYDERABAD GOLF ASSOCIATION" Or gcompanyname = "HGA1112" Then
                Call bill_Summary_details()
            Else
                Call bill_Summary_details()
            End If
        End If
        If Rnd_Details.Checked = True Then

            Call GETSUMMARY_PRINT()
        End If
        If Rnd_summardet.Checked = True Then
            Call GETSUMMARYANDDETAILS()
        End If
        If Rnd_Xml.Checked = True Then
            Call Xml()

        End If
        If Rdb_ECS.Checked = True Then
            Call ECSSETUP()
        End If
        If Rdb_Previousbill.Checked = True Then
            'If gcompanyname = "CALCUTTA CLUB LTD" Then
            Call GETSUMMARY_PREVIOUSbill()
            'End If
        End If
        If Rdb_Doller.Checked = True Then
            Call Doller_Bill()
        End If
    End Sub
    Private Sub ECSSETUP()
        Dim SSQL, sqlstring As String
        Dim ITEMCODE As String
        Dim vcount, I As Integer
        Dim VRowCount As Short
        Dim vSAmount, PACKAMOUNT, bdt As Double
        Dim vgamount As Double
        Dim dt As Date
        Dim VOutputfile, Rowprint As String
        Dim boolOtherBill As Boolean
        Dim XMLSTR, tempstr, tempstr1, tempstr2 As String
        Randomize()
        apppath = Application.StartupPath
        Dim cmdText As String
        Dim count, T_G, T, T1 As Integer
        Dim dr, dr1, dr2, dr4 As DataRow
        Dim duedate, membertype, TYPE(0), month2 As String
        Dim bLeapYear As Boolean
        bLeapYear = Date.IsLeapYear(gFinancialyearEnd)

        Call Validation()
        If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : noofdays = 30 : bildt = "01/apr/" & gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31 : bildt = "01/may/" & gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30 : bildt = "01/jun/" & gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31 : bildt = "01/jul/" & gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31 : bildt = "01/aug/" & gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30 : bildt = "01/sep/" & gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31 : bildt = "01/oct/" & gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30 : bildt = "01/nov/" & gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31 : bildt = "01/dec/" & gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31 : bildt = "01/jan/" & Mid(gFinancialyearEnd, 1, 4)
        'If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 28 : bildt = "01/feb/" & Mid(gFinancialyearEnd, 1, 4)
        If bLeapYear = True Then
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 29 : bildt = "01/feb/" & Mid(gFinancialyearEnd, 1, 4)
        Else
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 28 : bildt = "01/feb/" & Mid(gFinancialyearEnd, 1, 4)
        End If
        If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31 : bildt = "01/mar/" & Mid(gFinancialyearEnd, 1, 4)

        If File.Exists(VFilePath) = True Then
            File.Delete(VFilePath)
        End If

        vOutfile = "ECS" & Format(Now, "ddMMyyyy")
        VFilePath = apppath & "\Reports\" & vOutfile & ".txt"
        Filewrite = File.AppendText(VFilePath)

        sqlstring = "select ISNULL (OURUSERID,'') as OURUSERID,ISNULL(OURMICR ,'') as OURMICR,ISNULL(MNAME,'') as MNAME ,ISNULL(OURBANKACCOUNTNO,'')as  OURBANKACCOUNTNO,NAMEOFORG ,ISNULL(MCODE ,'') as MCODE,REPLACE(ISNULL(AMOUNT ,0),'.','') as AMOUNT from VW_ECS WHERE  MONTH(billdate) = " & month1 & " AND ISNULL(AMOUNT,0) >0"
        gconnection.getDataSet(sqlstring, "VW_ECS")

        For Each dr In gdataset.Tables("VW_ECS").Rows
            If ITEMCODE <> Trim(CStr(dr("OURUSERID"))) Then
                If dr("AMOUNT") <> 0 Then
                    SSQL = SSQL & Space(6 - Len(Mid(Trim(CStr(dr("AMOUNT"))), 1, 6))) & Mid(Trim(CStr(dr("AMOUNT"))), 1, 6)
                Else
                    SSQL = SSQL & Space(6 - Len(Mid(Trim(CStr(dr("AMOUNT"))), 1, 6))) & Mid(Trim("-"), 1, 6)
                End If
                T_G = T_G + Trim(CStr(dr("AMOUNT")))
                T = Len(SSQL)
                vSAmount = vSAmount + Format(Val(dr("AMOUNT")), "0.00")
            End If
        Next
        ' dt = Format(DTPduedate.Value, "ddMMyyyy")
        Dim value As Double = vSAmount
        Dim a As String = String.Format("{0:0000000000}", value)
        ' Filewrite.WriteLine("557009032CALCUTTA CLUB       26/05/15                                   7002110020050101006507480000000009999999000000")
        ' Filewrite.WriteLine("{0,-20}{1,-18}{2,-62}{3,12}{4,12}", "557009032CALCUTTA CLUB       26/05/15                                   7002110020050101006507480000000009999999000000", Format(Val(vSAmount), "0.00"), Format(Val(vSAmount), "0.00"))
        ' dt = "" & Format(DTPduedate.Value)
        'Filewrite.WriteLine("{0,-20}{1,15}{2,58}{3,-1}{4,-5}", "557009032CALCUTTA CLUB", Format(DTPduedate.Value, "dd/MM/yy"), "700211002005010100650748", "", String.Format("{0:0000000009999999000000000000000000000}", value))
        sqlstring = " Select isnull(OURUID,'')++isnull(NAMEOFORG,'')  as OURUID ,isnull(OURBANKACCOUNTNO,'')++isnull(OURMICR,'') AS OURBANKACCOUNTNO from ECSSETUP  WHERE ISNULL(VOID ,'')<>'Y' "
        gconnection.getDataSet(sqlstring, "ECSSETUP")
        For Each dr In gdataset.Tables("ECSSETUP").Rows
            If ITEMCODE <> Trim(CStr(dr("OURUID"))) Then
                SSQL = Mid(Trim(CStr(dr("OURUID"))), 1, 28) & Space(29 - Len(Mid(Trim(CStr(dr("OURUID"))), 1, 29)))
                ' SSQL = SSQL & Mid(Trim(CStr(Format(DTPduedate.Value, "dd/MM/yy"))), 1, 30) & Space(40 - Len(Mid(Trim(CStr(Format(DTPduedate.Value, "dd/MM/yy"))), 1, 40)))
                SSQL = SSQL & Mid(Trim(CStr(Format(Now, "dd/MM/yy"))), 1, 30) & Space(43 - Len(Mid(Trim(CStr(Format(Now, "dd/MM/yy"))), 1, 43)))
                SSQL = SSQL & Mid(Trim(CStr(dr("OURBANKACCOUNTNO"))), 1, 58) & Space(24 - Len(Mid(Trim(CStr(dr("OURBANKACCOUNTNO"))), 1, 58)))
                'SSQL = SSQL & Mid(Trim(((String.Format("{0:0000000009999999000000000000000000000}", value)))), 1, 50) & Space(50 - Len(Mid(Trim(((String.Format("{0:0000000009999999000000000000000000000}", value)))), 1, 50)))
                SSQL = SSQL & Mid(Trim(((String.Format("{0:00000000099999990000000000000}", value)))), 1, 50) & Space(29 - Len(Mid(Trim(((String.Format("{0:00000000099999990000000000000}", value)))), 1, 50)))
                SSQL = SSQL & Mid(Trim(CStr(Format(DTPduedate.Value, "ddMMyyyy"))), 1, 8) & Space(10 - Len(Mid(Trim(CStr(Format(DTPduedate.Value, "ddMMyyyy"))), 1, 8)))
            End If
            Filewrite.WriteLine(SSQL)
        Next dr
        '  Filewrite.Close()
        'Filewrite.WriteLine("{0,-20}{1,15}{2,58}{3,-1}{4,-5}", CStr(dr("OURUSERID")), Format(DTPduedate.Value, "dd/MM/yy"), CStr(dr("OURBANKACCOUNTNO")), "", String.Format("{0:0000000009999999000000000000000000000}", value))
        ' sqlstring = "select ISNULL (OURUSERID ,'') as OURUSERID,ISNULL(OURMICR ,0) as OURMICR,ISNULL(MNAME,0) as MNAME ,ISNULL(OURBANKACCOUNTNO,0)as  OURBANKACCOUNTNO,NAMEOFORG ,ISNULL(MCODE ,0) as MCODE,ISNULL(AMOUNT ,0) as AMOUNT from VW_ECS"
        sqlstring = "select ISNULL (OURUSERID ,'') as OURUSERID,ISNULL(OURMICR ,0) as OURMICR,ISNULL(MNAME,0) as MNAME ,ISNULL(OURBANKACCOUNTNO,0)as  OURBANKACCOUNTNO,NAMEOFORG ,ISNULL(MCODE ,0) as MCODE,REPLACE(ISNULL(AMOUNT,0),'.','') AS AMOUNT from VW_ECS WHERE  MONTH(billdate) = " & month1 & " AND ISNULL(AMOUNT,0) >0 "
        gconnection.getDataSet(sqlstring, "VW_ECS")
        For Each dr In gdataset.Tables("VW_ECS").Rows
            'If PageSize > 58 Then
            '    'Filewrite.Write(StrDup(88, "="))
            '    'Filewrite.Write(Chr(12))
            '    'PageNo = PageNo + 1
            '    'Call PrintHeader(PAGEHEAD, FROMDATE, TODATE)
            '    Filewrite.WriteLine()
            '    PageSize = PageSize + 1
            'End If
            ' Dim value1 As Double = dr("AMOUNT")+Format(Val(dr("AMOUNT")), "0.00")
            Dim value1 As Double = Format(Val(dr("AMOUNT")), "0.00")
            Dim a1 As String = String.Format("{0:000000000}", value1)
            'Dim a1 As String = String.Format("{00:00000000}", value1)
            ' Dim value1 As String = Format(Val(dr("AMOUNT")), "0.00")
            If ITEMCODE <> Trim(CStr(dr("OURUSERID"))) Then
                SSQL = Mid(Trim(CStr(dr("OURUSERID"))), 1, 25) & Space(16 - Len(Mid(Trim(CStr(dr("OURUSERID"))), 1, 16)))
                SSQL = SSQL & Mid(Trim(CStr(dr("OURMICR"))), 1, 30) & Space(16 - Len(Mid(Trim(CStr(dr("OURMICR"))), 1, 16)))
                SSQL = SSQL & Mid(Trim(CStr(dr("MNAME"))), 1, 30) & Space(39 - Len(Mid(Trim(CStr(dr("MNAME"))), 1, 39)))
                SSQL = SSQL & Mid(Trim(CStr(dr("OURBANKACCOUNTNO"))), 1, 30) & Space(13 - Len(Mid(Trim(CStr(dr("OURBANKACCOUNTNO"))), 1, 13)))
                SSQL = SSQL & Mid(Trim(CStr(dr("NAMEOFORG"))), 1, 30) & Space(20 - Len(Mid(Trim(CStr(dr("NAMEOFORG"))), 1, 20)))
                SSQL = SSQL & Mid(Trim(CStr(dr("MCODE"))), 1, 30) & Space(13 - Len(Mid(Trim(CStr(dr("MCODE"))), 1, 13)))
                'SSQL = SSQL & Mid(Trim(Format(dr("DATETIME"), "dd/mm/yyyy hh:mm:ss")), 1, 18) & Space(18 - Len(Mid(Trim(Format(dr("DATETIME"), "dd/mm/yyyy")), 1, 18)))
                'Filewrite.WriteLine("557009032CALCUTTA CLUB       26/05/15                                   7002110020050101006507480000000009999999000000185928029052015")
                If dr("AMOUNT") > 0 Then
                    ' SSQL = SSQL & Space(6 - Len(Mid(Trim(CStr(dr("AMOUNT"))), 1, 6))) & Mid(Trim(CStr(dr("AMOUNT"))), 1, 6)
                    SSQL = SSQL & Space(13 - Len(Mid(Trim(String.Format("{0:0000000000000}", ((value1)))), 1, 13))) & Mid(Trim(String.Format("{0:0000000000000}", ((value1)))), 1, 13)
                    'SSQL = SSQL & Space(13 - Len(Mid(Trim(String.Format("{0:00000000000}", ((value1)))), 1, 13))) & Mid(Trim(String.Format("{0:00000000000}", ((value1)))), 1, 13)
                ElseIf dr("AMOUNT") < 0 Then
                    'SSQL = SSQL & Space(6 - Len(Mid(Trim(CStr(dr("AMOUNT"))), 1, 6))) & Mid(Trim("-"), 1, 6)
                    'SSQL = SSQL & Space(6 - Len(Mid(Trim(String.Format("{0:0000000000000}", ((value1)) * -1)), 1, 6))) & Mid(Trim("-"), 1, 6)
                    SSQL = SSQL & Space(13 - Len(Mid(Trim(String.Format("{0:0000000000000}", ((value1)) * -1)), 1, 13))) & Mid(Trim(String.Format("{0:0000000000000}", ((value1)) * -1)), 1, 13)
                    'SSQL = SSQL & Space(13 - Len(Mid(Trim(String.Format("{0:00000000000}", ((value1)) * -1)), 1, 13))) & Mid(Trim(String.Format("{0:00000000000}", ((value1)) * -1)), 1, 13)
                End If
                'T_G = T_G + Trim(CStr(dr("AMOUNT")))
                ''T_G = String.Format("{0:0000000000000}", T_G)
                'T = Len(SSQL)
                'vSAmount = vSAmount + Format(Val(dr("AMOUNT")), "0.00")
                ' Filewrite.WriteLine("{0,-20}{1,-18}{2,-62}{3,12}{4,12}", "Total Document :", Format(Val(vSAmount), "0"), "POS Total =====>", Format(Val(vSAmount), "0.00"), Format(Val(vSAmount), "0.00"))
                Filewrite.WriteLine(SSQL)
            End If
            'Filewrite.WriteLine()
        Next dr
        ' Filewrite.WriteLine("{0,-20}{1,-18}", Format(Val(vSAmount), "0.00"), Format(Val(vSAmount), "0.00"))
        Filewrite.Close()
        If GPRINT = False Then
            OpenTextFile(vOutfile)
        Else
            PrintTextFile(VFilePath)
        End If
    End Sub
    Private Sub pdfgen()
        Dim i As Integer
        Dim SSQL, TYPE(), HNAME, mcode, Years As String
        Dim posdesc(), groupcode(), itemcode(), sqlstring, membercode() As String
        Dim POSDESC2(), GROUPDESC2(), month2 As String
        Dim sqlstringCancel, VFilePathPdf, smsql As String
        Dim totalamt, totaltax, totalser, totaltips As Double
        If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : noofdays = 30 : bildt = "01/apr/" & Mid(gFinancalyearStart, 1, 4) : Years = Mid(gFinancalyearStart, 1, 4) : month2 = "04"
        If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31 : bildt = "01/may/" & Mid(gFinancalyearStart, 1, 4) : Years = Mid(gFinancalyearStart, 1, 4) : month2 = "05"
        If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30 : bildt = "01/jun/" & Mid(gFinancalyearStart, 1, 4) : Years = Mid(gFinancalyearStart, 1, 4) : month2 = "06"
        If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31 : bildt = "01/jul/" & Mid(gFinancalyearStart, 1, 4) : Years = Mid(gFinancalyearStart, 1, 4) : month2 = "07"
        If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31 : bildt = "01/aug/" & Mid(gFinancalyearStart, 1, 4) : Years = Mid(gFinancalyearStart, 1, 4) : month2 = "08"
        If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30 : bildt = "01/sep/" & Mid(gFinancalyearStart, 1, 4) : Years = Mid(gFinancalyearStart, 1, 4) : month2 = "09"
        If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31 : bildt = "01/oct/" & Mid(gFinancalyearStart, 1, 4) : Years = Mid(gFinancalyearStart, 1, 4) : month2 = "10"
        If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30 : bildt = "01/nov/" & Mid(gFinancalyearStart, 1, 4) : Years = Mid(gFinancalyearStart, 1, 4) : month2 = "11"
        If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31 : bildt = "01/dec/" & Mid(gFinancalyearStart, 1, 4) : Years = Mid(gFinancalyearStart, 1, 4) : month2 = "12"
        If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31 : bildt = "01/jan/" & gFinancialyearEnd : Years = gFinancialyearEnd : month2 = "01"
        If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 28 : bildt = "01/feb/" & gFinancialyearEnd : Years = Mid(gFinancialyearEnd, 1, 4) : month2 = "02"
        If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31 : bildt = "01/mar/" & gFinancialyearEnd : Years = Mid(gFinancialyearEnd, 1, 4) : month2 = "03"

        SSQL = "SELECT ITEMCODE,ITEMDESC,QTY AS QTY,AMOUNT AS AMOUNT,TAXAMOUNT,POSDesc,SER_CHG,PACKAMOUNT,KOTDETAILS,KOTDATE,RATE,mcode,"
        SSQL = SSQL & "MNAME,BILLAMOUNT AS BILLAMOUNT FROM VIEWKOTDETAILS "
        SSQL = SSQL & " WHERE MONTH(KOTDATE) = "
        SSQL = SSQL & " MONTH('" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "')"

        'If chklist_Type.CheckedItems.Count <> 0 Then
        '    SSQL = SSQL & " and  ITEMDESC IN("
        '    For i = 0 To chklist_Type.CheckedItems.Count - 1
        '        TYPE = Split(chklist_Type.CheckedItems(i), "-->")
        '        SSQL = SSQL & " '" & TYPE(1) & "', "
        '        HNAME = HNAME & " " & Trim(TYPE(0))
        '        'SSQL = SSQL & " '" & chklist_Type.CheckedItems(i) & "', "
        '    Next
        '    SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
        '    SSQL = SSQL & ")"

        '    'If chklist_Type.CheckedItems.Count <> 0 Then
        '    '    SSQL = SSQL & " and  TAXCODE IN("
        '    '    For i = 0 To chklist_Type.CheckedItems.Count - 1
        '    '        TYPE = Split(chklist_Type.CheckedItems(i), "-->")
        '    '        SSQL = SSQL & " '" & TYPE(1) & "', "
        '    '        HNAME = HNAME & " " & Trim(TYPE(0))
        '    '        'SSQL = SSQL & " '" & chklist_Type.CheckedItems(i) & "', "
        '    '    Next
        '    '    SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
        '    '    SSQL = SSQL & ")"
        'End If



        'If LstGroup.CheckedItems.Count <> 0 Then
        '    SSQL = SSQL & " AND GROUPCODE IN ("
        '    For i = 0 To LstGroup.CheckedItems.Count - 1
        '        TYPE = Split(LstGroup.CheckedItems(i), "-->")
        '        SSQL = SSQL & " '" & TYPE(1) & "', "

        '    Next
        '    SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
        '    SSQL = SSQL & ")"
        'End If

        'If lstcategory.CheckedItems.Count <> 0 Then
        '    SSQL = SSQL & " and CATEGORY in ("
        '    For i = 0 To lstcategory.CheckedItems.Count - 1
        '        SSQL = SSQL & " '" & lstcategory.CheckedItems(i) & "', "
        '    Next
        '    SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
        '    SSQL = SSQL & ")"
        'End If

        'If chklist_POSlocation.CheckedItems.Count <> 0 Then
        '    SSQL = SSQL & " AND POSCODE IN ("
        '    For i = 0 To chklist_POSlocation.CheckedItems.Count - 1
        '        TYPE = Split(chklist_POSlocation.CheckedItems(i), "-->")
        '        SSQL = SSQL & " '" & TYPE(1) & "', "

        '    Next
        '    SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
        '    SSQL = SSQL & ")"
        'End If

        ''====

        'If CheckedListBox1.CheckedItems.Count <> 0 Then
        '    SSQL = SSQL & " AND SCODE IN ("
        '    For i = 0 To CheckedListBox1.CheckedItems.Count - 1
        '        TYPE = Split(CheckedListBox1.CheckedItems(i), "-->")
        '        SSQL = SSQL & " '" & TYPE(1) & "', "

        '    Next
        '    SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
        '    SSQL = SSQL & ")"

        'End If

        ''========

        If Trim(txt_mcode.Text) <> "" Then
            'SSQL = SSQL & " AND MCODE ='" & Trim(txt_mcode.Text) & "'"
            SSQL = SSQL & " AND MCODE BETWEEN '" & Trim(txt_mcode.Text) & "' AND '" & Trim(txt_Tomcode.Text) & "' "
        Else
            MsgBox("PLEASE PROVIDE MEMBERCODE")
            Exit Sub
        End If



        SSQL = SSQL & " AND PAYMENTMODE IN ('CREDIT')"



        'SSQL = SSQL & " order by mcode"
        ''''  If chklist_Membername.CheckedItems.Count <> 0 Then
        ''''SSQL = SSQL & " AND mcode IN ("
        '''' For i = 0 To chklist_Membername.CheckedItems.Count - 1
        ''''   SSQL = SSQL & " '" & chklist_Membername.CheckedItems(i) & "', "
        ''SSQL = SSQL & " '" & TYPE(1) & "', "

        ''''  Next
        ''''   SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
        ''''   SSQL = SSQL & ") order by mcode"
        ''''   Else
        ''''   MsgBox("Select the MCODE", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
        ''''   Exit Sub
        ''''   End If



        'If Trim(txt_mcode.Text) <> "" And Trim(txt_Tomcode.Text) <> "" Then
        '    SSQL = SSQL & " AND MCODE between '" & Trim(txt_mcode.Text) & "' and '" & Trim(txt_Tomcode.Text) & "'"
        'Else
        '    If chklist_Membername.CheckedItems.Count <> 0 Then
        '        SSQL = SSQL & " AND MCODE IN ("
        '        For i = 0 To chklist_Membername.CheckedItems.Count - 1
        '            membercode = Split(chklist_Membername.CheckedItems(i), "-->")
        '            SSQL = SSQL & "'" & membercode(0) & "', "
        '        Next
        '        SSQL = Mid(SSQL, 1, Len(SSQL) - 2)
        '        SSQL = SSQL & ") "


        '    End If

        'End If
        SSQL = SSQL & "order by MCODE,kotdate,kotdetails"
        gconnection.getDataSet(SSQL, "RAN")
        totalamt = 0
        totaltax = 0
        Dim doc As New Document
        Dim SNO As Integer
        Dim BFTIMES As BaseFont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, False)
        Dim TIMES As New Font(BFTIMES, 9, Font.Italic, Color.BLACK)
        Dim BFTIMES1 As BaseFont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, False)
        Dim TIMES1 As New Font(BFTIMES, 14, Font.Italic, Color.BLACK)
        Dim TIMES2 As New Font(BFTIMES, 10, Font.Italic, Color.BLACK)
        Dim pdt As New PdfPTable(9)
        Dim col As New PdfPCell
        SNO = 1
        If gdataset.Tables("RAN").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("RAN").Rows.Count - 1
                If mcode <> Trim(gdataset.Tables("RAN").Rows(i).Item("MCODE")) Then

                    If SNO <> 1 Then

                        'smsql = "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------"
                        'doc.Add(New Paragraph(smsql))
                        'doc.Add(col)
                        col = New PdfPCell(New Phrase("", TIMES))

                        'col.Border = 0
                        pdt.AddCell(col)
                        'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("KOTDATE"), "dd/MMM/yyyy"), 1, 11) & Space(11 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("KOTDATE"), "dd/MMM/yyyy"), 1, 11))) & Space(1)
                        col = New PdfPCell(New Phrase("TOTAL", TIMES1))
                        'col.Border = 0
                        pdt.AddCell(col)
                        'smsql = smsql & Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14) & Space(14 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14))) & Space(1)
                        col = New PdfPCell(New Phrase("", TIMES))
                        'col.Border = 0
                        pdt.AddCell(col)
                        ''smsql = add(14 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14)), smsql)
                        'smsql = smsql & Mid(gdataset.Tables("RAN").Rows(i).Item("KOTDETAILS"), 1, 17) & Space(17 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("KOTDETAILS"), 1, 17))) & Space(1)
                        col = New PdfPCell(New Phrase("", TIMES))
                        'col.Border = 0
                        pdt.AddCell(col)
                        'smsql = smsql & Mid(gdataset.Tables("RAN").Rows(i).Item("ITEMDESC"), 1, 20) & Space(20 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("ITEMDESC"), 1, 20))) & Space(1)
                        col = New PdfPCell(New Phrase("", TIMES))
                        'col.Border = 0
                        pdt.AddCell(col)
                        col = New PdfPCell(New Phrase(Mid(Format(Val(totalamt), "0.00"), 1, 10).ToString(), TIMES)) 'col.Border = 0
                        col.HorizontalAlignment = 2
                        pdt.AddCell(col)
                        col = New PdfPCell(New Phrase(Mid(Format(Val(totaltax), "0.00"), 1, 10).ToString(), TIMES)) 'col.Border = 0
                        col.HorizontalAlignment = 2
                        pdt.AddCell(col)
                        col = New PdfPCell(New Phrase(Mid(Format(Val(totalser), "0.00"), 1, 10).ToString(), TIMES)) 'col.Border = 0
                        'col = New PdfPCell(New Phrase(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("SER_CHG"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("SER_CHG"), "0.00"), 1, 10))), TIMES))
                        col.HorizontalAlignment = 2
                        pdt.AddCell(col)
                        col = New PdfPCell(New Phrase(Mid(Format(Val(totaltips), "0.00"), 1, 10).ToString(), TIMES))
                        'col.Border = 0
                        col.HorizontalAlignment = 2
                        pdt.AddCell(col)
                        'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 10))) & Space(1)
                        col = New PdfPCell(New Phrase(Format(Val(totaltax + totalamt + totalser + totaltips), "0.00").ToString(), TIMES))
                        'col.Border = 0
                        col.HorizontalAlignment = 2
                        pdt.AddCell(col)
                        'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT"), "0.00"), 1, 10))) & Space(1)
                        col = New PdfPCell(New Phrase(Format(Val(totaltax), "0.00").ToString(), TIMES))
                        'col.Border = 0
                        col.HorizontalAlignment = 2
                        pdt.AddCell(col)
                        'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 14) & Space(14 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 14)))
                        col = New PdfPCell(New Phrase(Format(Val(totaltax + totalamt), "0.00").ToString(), TIMES))
                        'col.Border = 0
                        col.HorizontalAlignment = 2
                        pdt.AddCell(col)
                        doc.Add(pdt)
                        'smsql = "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------"
                        'doc.Add(New Paragraph(smsql))
                        'smsql = "         TOTAL                                            " & Format(totalamt, "0.00") & Space(2) & Format(totaltax, "0.00") & Space(2) & Format(totalamt + totaltax, "0.00")
                        'doc.Add(New Paragraph(smsql))
                        'smsql = "-------------------------------------------------------------------------------------------------------------------"
                        'doc.Add(New Paragraph(smsql))
                        doc.Close()
                        totalamt = 0
                        totaltax = 0
                        totalser = 0
                        totaltips = 0
                    End If

                    doc = New Document
                    VFilePathPdf = apppath & "\REPORTS\" & Trim(gdataset.Tables("RAN").Rows(i).Item("MCODE")) & "@" & Years & "@" & month2 & ".pdf"
                    If File.Exists(VFilePathPdf) Then
                        File.Delete(VFilePathPdf)
                    End If
                    PdfWriter.GetInstance(doc, New FileStream(VFilePathPdf, FileMode.OpenOrCreate))
                    doc.Open()
                    SNO = 1
                    smsql = "MEMBER POS CONSUMPTION DETAILS "
                    doc.Add(New Paragraph(smsql, TIMES1))
                    smsql = "PERIOD FOR THE MONTH OF  " & MonthName(Month(Format(CbxMonth.Value, "dd/MMM/yyyy")), False) & "," & Year(Format(CbxMonth.Value, "dd/MMM/yyyy"))
                    doc.Add(New Paragraph(smsql, TIMES2))
                    smsql = gcompanyname
                    doc.Add(New Paragraph(smsql, TIMES2))
                    smsql = gCompanyAddress(0) & "," & gCompanyAddress(1) & "," & gCompanyAddress(2)
                    doc.Add(New Paragraph(smsql, TIMES))

                    smsql = "MEMBER DETAILS FOR :-" & Trim(gdataset.Tables("RAN").Rows(i).Item("MNAME")) & "[" & Trim(gdataset.Tables("RAN").Rows(i).Item("MCODE")) & "]"
                    doc.Add(New Paragraph(smsql, TIMES2))
                    smsql = "RUN DATE :" & Format(Now, "dd-MMM-yyyy HH:mm")
                    doc.Add(New Paragraph(smsql, TIMES))
                    smsql = "--"
                    doc.Add(New Paragraph(smsql, TIMES))
                    'Dim col As New MultiColumnText
                    'col.AddSimpleColumn(10.0F, 15.0F)
                    'col.AddSimpleColumn(16.0F, 27.0F)
                    'col.AddSimpleColumn(28.0F, 42.0F)
                    'col.AddSimpleColumn(43.0F, 60.0F)
                    'col.AddSimpleColumn(61.0F, 81.0F)
                    'col.AddSimpleColumn(82.0F, 87.0F)
                    'col.AddSimpleColumn(88.0F, 98.0F)
                    'col.AddSimpleColumn(99.0F, 109.0F)
                    'col.AddSimpleColumn(110.0F, 120.0F)
                    pdt = New PdfPTable(10)
                    pdt.TotalWidth = 580.0F
                    doc.Add(col)
                    'smsql = "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------"
                    'col = New PdfPCell(New Phrase(smsql, TIMES))
                    'col.Border = 0
                    'col.Width = 600.0F
                    'pdt.AddCell(col)
                    pdt.LockedWidth = True
                    col = New PdfPCell(New Phrase("SNO  ", TIMES))
                    'col.Border = 0
                    'col.Width = 3.0F
                    pdt.AddCell(col)

                    col = New PdfPCell(New Phrase("KOT DATE     ", TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 1
                    pdt.AddCell(col)
                    col = New PdfPCell(New Phrase("LOCATION       ", TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 1
                    pdt.AddCell(col)
                    col = New PdfPCell(New Phrase("KOTDETAILS        ", TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 1
                    pdt.AddCell(col)
                    col = New PdfPCell(New Phrase("ITEMDESC             ", TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 1
                    pdt.AddCell(col)
                    col = New PdfPCell(New Phrase("AMOUNT     ", TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 1
                    pdt.AddCell(col)
                    col = New PdfPCell(New Phrase("VAT        ", TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 1
                    pdt.AddCell(col)
                    col = New PdfPCell(New Phrase("S.TAX        ", TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 1
                    pdt.AddCell(col)
                    col = New PdfPCell(New Phrase("TIPS        ", TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 1
                    pdt.AddCell(col)
                    col = New PdfPCell(New Phrase("TOTAL      ", TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 1
                    pdt.AddCell(col)
                    'smsql = "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------"
                    'doc.Add(New Paragraph(smsql))
                    'smsql = "SNo   KOT DATE     LOCATION       KOTDETAILS        ITEMDESC             QTY   RATE       AMOUNT     TAX        TOTAMT       "
                    'doc.Add(New Paragraph(smsql, TIMES))

                    'Dim para As New Paragraph(smsql, TIMES)
                    'col.AddElement(para)
                    'doc.Add(col)
                    'smsql = "-------------------------------------------------------------------------------------------------------------------"
                    'doc.Add(New Paragraph(smsql))
                    'smsql = Space(5 - Len(Mid(SNO, 1, 5))) & Mid(SNO, 1, 5) & Space(1)
                    col = New PdfPCell(New Phrase(Space(5 - Len(Mid(SNO, 1, 5))) & Mid(SNO, 1, 5), TIMES))
                    'col.Border = 0
                    pdt.AddCell(col)
                    'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("KOTDATE"), "dd/MMM/yyyy"), 1, 11) & Space(11 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("KOTDATE"), "dd/MMM/yyyy"), 1, 11))) & Space(1)
                    col = New PdfPCell(New Phrase(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("KOTDATE"), "dd-MMM-yyyy"), 1, 11) & Space(11 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("KOTDATE"), "dd-MMM-yyyy"), 1, 11))), TIMES))
                    'col.Border = 0
                    pdt.AddCell(col)
                    'smsql = smsql & Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14) & Space(14 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14))) & Space(1)
                    col = New PdfPCell(New Phrase(Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14) & Space(14 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14))), TIMES))
                    'col.Border = 0
                    pdt.AddCell(col)
                    ''smsql = add(14 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14)), smsql)
                    'smsql = smsql & Mid(gdataset.Tables("RAN").Rows(i).Item("KOTDETAILS"), 1, 17) & Space(17 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("KOTDETAILS"), 1, 17))) & Space(1)
                    col = New PdfPCell(New Phrase(Mid(gdataset.Tables("RAN").Rows(i).Item("KOTDETAILS"), 1, 17) & Space(17 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("KOTDETAILS"), 1, 17))), TIMES))
                    'col.Border = 0
                    pdt.AddCell(col)
                    'smsql = smsql & Mid(gdataset.Tables("RAN").Rows(i).Item("ITEMDESC"), 1, 20) & Space(20 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("ITEMDESC"), 1, 20))) & Space(1)
                    col = New PdfPCell(New Phrase(Mid(gdataset.Tables("RAN").Rows(i).Item("ITEMDESC"), 1, 20) & Space(20 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("ITEMDESC"), 1, 20))), TIMES))
                    'col.Border = 0
                    pdt.AddCell(col)
                    'smsql = smsql & Mid(Val(gdataset.Tables("RAN").Rows(i).Item("QTY")), 1, 5) & Space(5 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("QTY"), 1, 5))) & Space(1)
                    'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 10))) & Space(1)
                    col = New PdfPCell(New Phrase(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 10))), TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 2
                    pdt.AddCell(col)
                    'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT"), "0.00"), 1, 10))) & Space(1)
                    col = New PdfPCell(New Phrase(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT"), "0.00"), 1, 10))), TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 2
                    pdt.AddCell(col)
                    col = New PdfPCell(New Phrase(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("PACKAMOUNT"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("PACKAMOUNT"), "0.00"), 1, 10))), TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 2
                    pdt.AddCell(col)
                    col = New PdfPCell(New Phrase(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("SER_CHG"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("SER_CHG"), "0.00"), 1, 10))), TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 2
                    pdt.AddCell(col)
                    'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 14) & Space(14 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 14)))
                    col = New PdfPCell(New Phrase(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT") + gdataset.Tables("RAN").Rows(i).Item("PACKAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("SER_CHG"), "0.00"), 1, 14) & Space(14 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 14))), TIMES))
                    ' col.Border = 0
                    col.HorizontalAlignment = 2
                    pdt.AddCell(col)
                    ' doc.Add(New Paragraph(smsql, TIMES))
                    totalamt = totalamt + gdataset.Tables("RAN").Rows(i).Item("AMOUNT")
                    totaltax = totaltax + gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT")
                    totalser = totalser + gdataset.Tables("RAN").Rows(i).Item("PACKAMOUNT")
                    totaltips = totaltips + gdataset.Tables("RAN").Rows(i).Item("SER_CHG")
                Else
                    'smsql = Space(5 - Len(Mid(SNO, 1, 5))) & Mid(SNO, 1, 5) & Space(1)
                    'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("KOTDATE"), "dd/MMM/yyyy"), 1, 11) & Space(11 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("KOTDATE"), "dd/MMM/yyyy"), 1, 11))) & Space(1)
                    'smsql = smsql & Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14)
                    ''& Space(14 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14))) & Space(1)
                    'smsql = add(14 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14)), smsql)

                    'smsql = smsql & Space(1) & Mid(gdataset.Tables("RAN").Rows(i).Item("KOTDETAILS"), 1, 17) & Space(17 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("KOTDETAILS"), 1, 17))) & Space(1)
                    'smsql = smsql & Mid(gdataset.Tables("RAN").Rows(i).Item("ITEMDESC"), 1, 20) & Space(20 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("ITEMDESC"), 1, 20))) & Space(1)
                    'smsql = smsql & Mid(Val(gdataset.Tables("RAN").Rows(i).Item("QTY")), 1, 5) & Space(5 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("QTY"), 1, 5))) & Space(1)
                    'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("RATE"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("RATE"), "0.00"), 1, 10))) & Space(1)
                    'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 10))) & Space(1)
                    'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT"), "0.00"), 1, 10))) & Space(1)
                    'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 14) & Space(14 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 14)))
                    'doc.Add(New Paragraph(smsql, TIMES))
                    col = New PdfPCell(New Phrase(Space(5 - Len(Mid(SNO, 1, 5))) & Mid(SNO, 1, 5), TIMES))
                    'col.Border = 0
                    pdt.AddCell(col)
                    'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("KOTDATE"), "dd/MMM/yyyy"), 1, 11) & Space(11 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("KOTDATE"), "dd/MMM/yyyy"), 1, 11))) & Space(1)
                    col = New PdfPCell(New Phrase(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("KOTDATE"), "dd/MMM/yyyy"), 1, 11) & Space(11 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("KOTDATE"), "dd/MMM/yyyy"), 1, 11))), TIMES))
                    'col.Border = 0
                    pdt.AddCell(col)
                    'smsql = smsql & Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14) & Space(14 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14))) & Space(1)
                    col = New PdfPCell(New Phrase(Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14) & Space(14 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14))), TIMES))
                    'col.Border = 0
                    pdt.AddCell(col)
                    ''smsql = add(14 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14)), smsql)
                    'smsql = smsql & Mid(gdataset.Tables("RAN").Rows(i).Item("KOTDETAILS"), 1, 17) & Space(17 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("KOTDETAILS"), 1, 17))) & Space(1)
                    col = New PdfPCell(New Phrase(Mid(gdataset.Tables("RAN").Rows(i).Item("KOTDETAILS"), 1, 17) & Space(17 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("KOTDETAILS"), 1, 17))), TIMES))
                    'col.Border = 0
                    pdt.AddCell(col)
                    'smsql = smsql & Mid(gdataset.Tables("RAN").Rows(i).Item("ITEMDESC"), 1, 20) & Space(20 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("ITEMDESC"), 1, 20))) & Space(1)
                    col = New PdfPCell(New Phrase(Mid(gdataset.Tables("RAN").Rows(i).Item("ITEMDESC"), 1, 20) & Space(20 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("ITEMDESC"), 1, 20))), TIMES))
                    ' col.Border = 0
                    pdt.AddCell(col)
                    'smsql = smsql & Mid(Val(gdataset.Tables("RAN").Rows(i).Item("QTY")), 1, 5) & Space(5 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("QTY"), 1, 5))) & Space(1)
                    'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 10))) & Space(1)
                    col = New PdfPCell(New Phrase(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 10))), TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 2
                    pdt.AddCell(col)
                    'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT"), "0.00"), 1, 10))) & Space(1)
                    col = New PdfPCell(New Phrase(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT"), "0.00"), 1, 10))), TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 2
                    pdt.AddCell(col)
                    'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 14) & Space(14 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 14)))
                    'col = New PdfPCell(New Phrase(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 14) & Space(14 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 14))), TIMES))

                    'col.HorizontalAlignment = 2
                    'pdt.AddCell(col)
                    'col.Border = 0
                    col = New PdfPCell(New Phrase(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("PACKAMOUNT"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT"), "0.00"), 1, 10))), TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 2
                    pdt.AddCell(col)
                    col = New PdfPCell(New Phrase(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("SER_CHG"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("SER_CHG"), "0.00"), 1, 10))), TIMES))
                    'col.Border = 0
                    col.HorizontalAlignment = 2
                    pdt.AddCell(col)
                    'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 14) & Space(14 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 14)))
                    col = New PdfPCell(New Phrase(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT") + gdataset.Tables("RAN").Rows(i).Item("PACKAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("SER_CHG"), "0.00"), 1, 14) & Space(14 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 14))), TIMES))
                    ' col.Border = 0
                    col.HorizontalAlignment = 2
                    pdt.AddCell(col)
                    ' doc.Add(New Paragraph(smsql, TIMES))
                    totalamt = totalamt + gdataset.Tables("RAN").Rows(i).Item("AMOUNT")
                    totaltax = totaltax + gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT")
                    totalser = totalser + gdataset.Tables("RAN").Rows(i).Item("PACKAMOUNT")
                    totaltips = totaltips + gdataset.Tables("RAN").Rows(i).Item("SER_CHG")
                End If
                SNO = SNO + 1
                mcode = Trim(gdataset.Tables("RAN").Rows(i).Item("MCODE"))
            Next
            col = New PdfPCell(New Phrase("", TIMES))

            'col.Border = 0
            pdt.AddCell(col)
            'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("KOTDATE"), "dd/MMM/yyyy"), 1, 11) & Space(11 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("KOTDATE"), "dd/MMM/yyyy"), 1, 11))) & Space(1)
            col = New PdfPCell(New Phrase("TOTAL", TIMES1))
            'col.Border = 0
            pdt.AddCell(col)
            'smsql = smsql & Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14) & Space(14 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14))) & Space(1)
            col = New PdfPCell(New Phrase("", TIMES))
            'col.Border = 0
            pdt.AddCell(col)
            ''smsql = add(14 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("POSDesc"), 1, 14)), smsql)
            'smsql = smsql & Mid(gdataset.Tables("RAN").Rows(i).Item("KOTDETAILS"), 1, 17) & Space(17 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("KOTDETAILS"), 1, 17))) & Space(1)
            col = New PdfPCell(New Phrase("", TIMES))
            'col.Border = 0
            pdt.AddCell(col)
            'smsql = smsql & Mid(gdataset.Tables("RAN").Rows(i).Item("ITEMDESC"), 1, 20) & Space(20 - Len(Mid(gdataset.Tables("RAN").Rows(i).Item("ITEMDESC"), 1, 20))) & Space(1)
            col = New PdfPCell(New Phrase("", TIMES))
            'col.Border = 0
            pdt.AddCell(col)
            col = New PdfPCell(New Phrase(Mid(Format(Val(totalamt), "0.00"), 1, 10).ToString(), TIMES)) 'col.Border = 0
            col.HorizontalAlignment = 2
            pdt.AddCell(col)
            col = New PdfPCell(New Phrase(Mid(Format(Val(totaltax), "0.00"), 1, 10).ToString(), TIMES)) 'col.Border = 0
            col.HorizontalAlignment = 2
            pdt.AddCell(col)
            col = New PdfPCell(New Phrase(Mid(Format(Val(totalser), "0.00"), 1, 10).ToString(), TIMES)) 'col.Border = 0
            'col = New PdfPCell(New Phrase(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("SER_CHG"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("SER_CHG"), "0.00"), 1, 10))), TIMES))
            col.HorizontalAlignment = 2
            pdt.AddCell(col)
            col = New PdfPCell(New Phrase(Mid(Format(Val(totaltips), "0.00"), 1, 10).ToString(), TIMES))
            'col.Border = 0
            col.HorizontalAlignment = 2
            pdt.AddCell(col)
            'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 10))) & Space(1)
            col = New PdfPCell(New Phrase(Format(Val(totaltax + totalamt + totalser + totaltips), "0.00").ToString(), TIMES))
            'col.Border = 0
            col.HorizontalAlignment = 2
            pdt.AddCell(col)
            'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT"), "0.00"), 1, 10) & Space(10 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT"), "0.00"), 1, 10))) & Space(1)
            col = New PdfPCell(New Phrase(Format(Val(totaltax), "0.00").ToString(), TIMES))
            'col.Border = 0
            col.HorizontalAlignment = 2
            pdt.AddCell(col)
            'smsql = smsql & Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 14) & Space(14 - Len(Mid(Format(gdataset.Tables("RAN").Rows(i).Item("TAXAMOUNT") + gdataset.Tables("RAN").Rows(i).Item("AMOUNT"), "0.00"), 1, 14)))
            col = New PdfPCell(New Phrase(Format(Val(totaltax + totalamt), "0.00").ToString(), TIMES))
            'col.Border = 0
            col.HorizontalAlignment = 2
            pdt.AddCell(col)
            'doc.Add(pdt)
            'smsql = "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------"
            'doc.Add(New Paragraph(smsql))
            'smsql = "         TOTAL                                            " & Format(totalamt, "0.00") & Space(2) & Format(totaltax, "0.00") & Space(2) & Format(totalamt + totaltax, "0.00")
            'doc.Add(New Paragraph(smsql))
            'smsql = "-------------------------------------------------------------------------------------------------------------------"
            'doc.Add(New Paragraph(smsql))
            'doc.Close()
            totalamt = 0
            totaltax = 0
            totalser = 0
            totaltips = 0
            doc.Add(pdt)
            doc.Close()
            If Dir(VFilePathPdf) <> "" Then
                System.Diagnostics.Process.Start(VFilePathPdf)
            Else
                MsgBox(VFilePathPdf & "  File not found", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If


        'doc.AddHeader()
        'Dim r1 As New VatItemWiseBillwise

        'Dim Viewer As New ReportViwer

        'Dim TXTOBJ3 As CrystalDecisions.CrystalReports.Engine.TextObject
        'TXTOBJ3 = r1.ReportDefinition.ReportObjects("Text13")
        'TXTOBJ3.Text = " From  " & Format(mskFromdate.Value, "dd/MM/yyyy") & "  To " & " " & Format(mskTodate.Value, "dd/MM/yyyy") & ""


        'Dim TXTOBJ4 As CrystalDecisions.CrystalReports.Engine.TextObject
        'TXTOBJ4 = r1.ReportDefinition.ReportObjects("Text15")
        'TXTOBJ4.Text = HNAME

        'Dim TXTOBJ5 As CrystalDecisions.CrystalReports.Engine.TextObject
        'TXTOBJ5 = r1.ReportDefinition.ReportObjects("Text14")
        'TXTOBJ5.Text = gCompanyname

        'Dim TXTOBJ1 As CrystalDecisions.CrystalReports.Engine.TextObject
        'TXTOBJ1 = r1.ReportDefinition.ReportObjects("Text2")
        'TXTOBJ1.Text = "UserName : " & gUsername



        'Viewer.ssql = SSQL
        'Viewer.Report = r1
        'Viewer.TableName = "VIEWITEMWISESALESUMMARY_TAXWISE"
        'Viewer.Show()




        'SSQL = SSQL & "GROUP BY ITEMCODE,ITEMDESC "
        'Dim heading() As String = {"SALES REGISTER [ITEM WISE]", "ALL"}
        'Dim objSaleregistersummary As New BILLWISE_TAX
        'objSaleregistersummary.Detailsection(SSQL, heading, HNAME, mskFromdate.Value, mskTodate.Value)
    End Sub
    Private Sub cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Clear.Click
        chk_PrintAll.Checked = False
        txt_mcode.Text = ""
        txt_Tomcode.Text = ""
        txt_mname.Text = ""
        txt_Tomname.Text = ""
        txt_note.Text = ""
        GroupBox1.Visible = False

    End Sub

    Private Sub Btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_close.Click
        Me.Close()
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
                        If Controls(i_i).Name = "Panel" Then
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
                        If Controls(i_i).Name = "cmd_Clear" Or Controls(i_i).Name = "cmd_view" Or Controls(i_i).Name = "Btn_close" Or Controls(i_i).Name = "Button1" Then
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

    Private Sub MonthBilling_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Call Resize_Form()

        'Grp_sms.Visible = False
        ' PIC1.Image = New Bitmap(AppPath & "\tnbsa logo.JPG")
        'GCONN.SaveCLUBFoto(AppPath & "\tnbsa logo.JPG", "RSIFRONT")
        Dim SQLSTRING As String
        Dim I As Integer
        SQLSTRING = "SELECT clublogo FROM accountsSetUp "
        GCONN.getDataSet(SQLSTRING, "PHOTO")
        'If gdataset.Tables("PHOTO").Rows.Count > 0 Then
        '    For I = 0 To gdataset.Tables("PHOTO").Rows.Count - 1
        '        With SSGRID
        '            .Row = I + 1
        '            .Col = 1
        '            .Text = gdataset.Tables("PHOTO").Rows(I).Item("MCODE")
        '            .Col = 2
        '            .Text = gdataset.Tables("PHOTO").Rows(I).Item("MNAME")
        '            .MaxRows = .MaxRows + 1
        '        End With
        '    Next
        'End If

        Dim ssql As String
        Dim MEMBERTYPE As New DataTable
        ssql = "select isnull(SUBTYPECODE,'') as membertype,isnull(SUBtypedesc,'') as typedesc from SUBCATEGORYMASTER "
        MEMBERTYPE = gconnection.GetValues(ssql)
        Dim Itration
        For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
            chk_Filter_Field.Items.Add(MEMBERTYPE.Rows(Itration).Item("Membertype") & "." & MEMBERTYPE.Rows(Itration).Item("TypeDesc"))
        Next
        'LoadUnitNO()
        chk_Filter_Field.Focus()
        RDOCOMBINEDNO.Checked = True
    End Sub
    Private Sub cmd_MemberCodeHelp1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmd_MemberCodeHelp1.Click
        Dim vform As New LIST_OPERATION1
        gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM MEMBERMASTER"
        If Trim(Search) = " " Then
            M_WhereCondition = " WHERE MEMBERTYPECODE <> 'NM'"
        Else
            M_WhereCondition = " WHERE MEMBERTYPECODE <> 'NM'"
        End If
        M_Groupby = ""
        vform.Field = "MCODE,MNAME"
        'vform.vFormatstring = "     MEMBER CODE    |         MEMBER NAME                         "
        vform.vCaption = "MEMBER HELP"
        ' vform.KeyPos = 0
        'vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_Tomcode.Text = Trim(vform.keyfield & "")
            Call txt_Tomcode_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub Validation()
        boolchk = True
    End Sub
    Private Sub txt_mcode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_mcode.Validated
        Try
            If Trim(txt_mcode.Text) <> "" Then
                sqlstring = "SELECT MCODE,MNAME FROM MEMBERMASTER WHERE MCODE='" & Trim(txt_mcode.Text) & "' AND MEMBERTYPECODE <> 'NM' ORDER BY MCODE "
                gconnection.getDataSet(sqlstring, "MEMBER")
                If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                    txt_mcode.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MCODE"))
                    txt_mname.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MNAME"))
                    txt_Tomcode.Focus()
                Else
                    txt_mcode.Text = ""
                    txt_mcode.Focus()
                End If
            Else
                'txt_mcode.Text = ""
                'txt_mcode.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txt_mcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_mcode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_mcode.Text) = "" Then
                Call cmd_MemberCodeHelp_Click(sender, e)
            Else
                txt_mcode_Validated(sender, e)
            End If
        End If
    End Sub
    Private Sub cmd_MemberCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MemberCodeHelp.Click
        Dim vform As New LIST_OPERATION1
        gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM MEMBERMASTER"
        If Trim(Search) = " " Then
            M_WhereCondition = " WHERE MEMBERTYPECODE <> 'NM'"
        Else
            M_WhereCondition = " WHERE MEMBERTYPECODE <> 'NM'"
        End If
        M_Groupby = ""
        vform.Field = "MCODE,MNAME"
        'vform.vFormatstring = "     MEMBER CODE    |         MEMBER NAME                         "
        vform.vCaption = "MEMBER HELP"
        'vform.KeyPos = 0
        'vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_mcode.Text = Trim(vform.keyfield & "")
            Call txt_mcode_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub txt_Tomcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Tomcode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_Tomcode.Text) = "" Then
                Call cmd_MemberCodeHelp1_Click(sender, e)
            Else
                txt_Tomcode_Validated(sender, e)
            End If
        End If
    End Sub
    Private Sub txt_Tomcode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Tomcode.Validated
        Try
            If Trim(txt_Tomcode.Text) <> "" Then
                sqlstring = "SELECT MCODE,MNAME FROM MEMBERMASTER WHERE MCODE='" & Trim(txt_Tomcode.Text) & "' AND MEMBERTYPECODE <> 'NM' ORDER BY MCODE"
                gconnection.getDataSet(sqlstring, "MEMBER")
                If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                    txt_Tomcode.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MCODE"))
                    txt_Tomname.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MNAME"))
                    cmd_view.Focus()
                Else
                    txt_Tomcode.Text = ""
                    txt_Tomcode.Focus()
                End If
            Else
                'txt_Tomcode.Text = ""
                'txt_Tomcode.Focus()
            End If
        Catch ex As Exception
        End Try
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
    Private Sub RDOCOMBINEDYES_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDOCOMBINEDYES.CheckedChanged
        Rnd_Summary.Visible = False
        Rnd_Details.Visible = False
        Rnd_summardet.Visible = True
    End Sub

    Private Sub RDOCOMBINEDNO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDOCOMBINEDNO.CheckedChanged
        Rnd_Summary.Visible = True
        Rnd_Details.Visible = True
        Rnd_summardet.Visible = False
    End Sub
    Private Sub GESUMMARYANDDETAILS1()
        ' Private Sub GESUMMARYANDDETAILS_PRINT()
        Try
            Dim BILDT3, bildt4, BILDT5, BILDT1, BILL As String
            Dim membertype, month, TYPE(0) As String
            Dim i As Integer
            Call Validation()
            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : noofdays = 30 : bildt = "01-apr-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "30-apr-" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31 : bildt = "01-may-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "31-may-" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30 : bildt = "01-jun-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "30-jun-" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31 : bildt = "01-jul-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "31-jul-" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31 : bildt = "01-aug-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "31-aug-" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30 : bildt = "01-sep-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "30-sep-" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31 : bildt = "01-oct-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "31-oct-" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30 : bildt = "01-Nov-" & gFinancalyearStart : BILDT1 = "30-Nov-" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31 : bildt = "01-Dec-" & gFinancalyearStart : BILDT1 = "31-Dec-" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31 : bildt = "01-Jan-" & gFinancialyearEnd : BILDT1 = "31-Jan-" & gFinancialyearEnd
            If gFinancialyearEnd Mod 4 = 0 Then
                If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 29 : bildt = "01-Feb-" & gFinancialyearEnd : BILDT1 = "29-Feb-" & gFinancialyearEnd
            Else
                If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 28 : bildt = "01-Feb-" & gFinancialyearEnd : BILDT1 = "28-Feb-" & gFinancialyearEnd
            End If

            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31 : bildt = "01-Mar-" & gFinancialyearEnd : BILDT1 = "31-Mar-" & gFinancialyearEnd
            'If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : bildt4 = "MAY.'" & Mid(gFinancalyearStart, 3, 2) : noofdays = 30 : month = "April  " & gFinancalyearStart : bildt = "01/apr/" & gFinancalyearStart : BILDT1 = "01/MAY/" & gFinancalyearStart : BILDT3 = "31/05/" & gFinancalyearStart : BILDT5 = "15/05/" & gFinancalyearStart : BILL = "01st Apr " & Mid(gFinancalyearStart, 3, 2) & " to 30th Apr " & Mid(gFinancalyearStart, 3, 2)
            'If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : bildt4 = "JUN.'" & Mid(gFinancalyearStart, 3, 2) : noofdays = 31 : month = "May  " & gFinancalyearStart : bildt = "01/may/" & gFinancalyearStart : BILDT1 = "01/jun/" & gFinancalyearStart : BILDT3 = "30/06/" & gFinancalyearStart : BILDT5 = "15/06/" & gFinancalyearStart : BILL = "01st May " & Mid(gFinancalyearStart, 3, 2) & " to 30th May " & Mid(gFinancalyearStart, 3, 2)
            'If Mid(Me.CbxMonth.Text, 1, 4) = "June" Then month1 = 6 : bildt4 = "JUL.'" & Mid(gFinancalyearStart, 3, 2) : noofdays = 30 : month = "June  " & gFinancalyearStart : bildt = "01/jun/" & gFinancalyearStart : BILDT1 = "01/jul/" & gFinancalyearStart : BILDT3 = "31/07/" & gFinancalyearStart : BILDT5 = "15/07/" & gFinancalyearStart : BILL = "01st Jun " & Mid(gFinancalyearStart, 3, 2) & " to 31st Jun " & Mid(gFinancalyearStart, 3, 2)
            'If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : bildt4 = "AUG.'" & Mid(gFinancalyearStart, 3, 2) : noofdays = 31 : month = "July  " & gFinancalyearStart : bildt = "01/jul/" & gFinancalyearStart : BILDT1 = "01/aug/" & gFinancalyearStart : BILDT3 = "31/08/" & gFinancalyearStart : BILDT5 = "15/08/" & gFinancalyearStart : BILL = "01st Jul " & Mid(gFinancalyearStart, 3, 2) & " to 31st Jul " & Mid(gFinancalyearStart, 3, 2)
            'If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : bildt4 = "SEP.'" & Mid(gFinancalyearStart, 3, 2) : noofdays = 31 : month = "August  " & gFinancalyearStart : bildt = "01/aug/" & gFinancalyearStart : BILDT1 = "01/sep/" & gFinancalyearStart : BILDT3 = "30/09/" & gFinancalyearStart : BILDT5 = "15/09/" & gFinancalyearStart : BILL = "01st Aug " & Mid(gFinancalyearStart, 3, 2) & " to 31st Aug " & Mid(gFinancalyearStart, 3, 2)
            'If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : bildt4 = "OCT.'" & Mid(gFinancalyearStart, 3, 2) : noofdays = 30 : month = "September  " & gFinancalyearStart : bildt = "01/sep/" & gFinancalyearStart : BILDT1 = "01/oct/" & gFinancalyearStart : BILDT3 = "31/10/" & gFinancalyearStart : BILDT5 = "15/10/" & gFinancalyearStart : BILL = "01st Sep " & Mid(gFinancalyearStart, 3, 2) & " to 30th Sep " & Mid(gFinancalyearStart, 3, 2)
            'If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : bildt4 = "NOV.'" & Mid(gFinancalyearStart, 3, 2) : noofdays = 31 : month = "October  " & gFinancalyearStart : bildt = "01/oct/" & gFinancalyearStart : BILDT1 = "01/nov/" & gFinancalyearStart : BILDT3 = "30/11/" & gFinancalyearStart : BILDT5 = "15/11/" & gFinancalyearStart : BILL = "01st Oct " & Mid(gFinancalyearStart, 3, 2) & " to 31st Oct " & Mid(gFinancalyearStart, 3, 2)
            'If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : bildt4 = "DEC.'" & Mid(gFinancalyearStart, 3, 2) : noofdays = 30 : month = "November  " & gFinancalyearStart : bildt = "01/nov/" & gFinancalyearStart : BILDT1 = "01/dec/" & gFinancalyearStart : BILDT3 = "31/12/" & gFinancalyearStart : BILDT5 = "15/12/" & gFinancalyearStart : BILL = "01st Nov " & Mid(gFinancalyearStart, 3, 2) & " to 30th Nov " & Mid(gFinancalyearStart, 3, 2)
            'If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : bildt4 = "JAN.'" & Mid(gFinancialyearEnd, 3, 2) : noofdays = 31 : month = "December  " & gFinancalyearStart : bildt = "01/dec/" & gFinancalyearStart : BILDT1 = "01/jan/" & gFinancialyearEnd : BILDT3 = "31/01/" & gFinancialyearEnd : BILDT5 = "15/01/" & gFinancialyearEnd : BILL = "01st Dec " & Mid(gFinancalyearStart, 3, 2) & " to 31st Dec " & Mid(gFinancalyearStart, 3, 2)
            'If gFinancialyearEnd Mod 4 = 0 Then
            '    If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : bildt4 = "FEB.'" & Mid(gFinancialyearEnd, 3, 2) : noofdays = 31 : month = "January  " & gFinancialyearEnd : bildt = "01/jan/" & gFinancialyearEnd : BILDT1 = "01/feb/" & gFinancialyearEnd : BILDT3 = "29/02/" & gFinancialyearEnd : BILDT5 = "15/02/" & gFinancialyearEnd : BILL = "01st Jan " & Mid(gFinancalyearStart, 3, 2) & " to 31st Jan " & Mid(gFinancalyearStart, 3, 2)
            '    If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : bildt4 = "MAR.'" & Mid(gFinancialyearEnd, 3, 2) : noofdays = 29 : month = "February  " & gFinancialyearEnd : bildt = "01/feb/" & gFinancialyearEnd : BILDT1 = "01/mar/" & gFinancialyearEnd : BILDT3 = "31/03/" & gFinancialyearEnd : BILDT5 = "15/03/" & gFinancialyearEnd : BILL = "01st Feb " & Mid(gFinancalyearStart, 3, 2) & " to 29th Feb " & Mid(gFinancalyearStart, 3, 2)
            'Else
            '    If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : bildt4 = "FEB.'" & Mid(gFinancialyearEnd, 3, 2) : noofdays = 31 : month = "January  " & gFinancialyearEnd : bildt = "01/jan/" & gFinancialyearEnd : BILDT1 = "01/feb/" & gFinancialyearEnd : BILDT3 = "28/02/" & gFinancialyearEnd : BILDT5 = "15/02/" & gFinancialyearEnd : BILL = "01st Jan " & Mid(gFinancalyearStart, 3, 2) & " to 31st Jan " & Mid(gFinancalyearStart, 3, 2)
            '    If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : bildt4 = "MAR.'" & Mid(gFinancialyearEnd, 3, 2) : noofdays = 28 : month = "February  " & gFinancialyearEnd : bildt = "01/feb/" & gFinancialyearEnd : BILDT1 = "01/mar/" & gFinancialyearEnd : BILDT3 = "31/03/" & gFinancialyearEnd : BILDT5 = "15/03/" & gFinancialyearEnd : BILL = "01st Feb " & Mid(gFinancalyearStart, 3, 2) & " to 28th Feb " & Mid(gFinancalyearStart, 3, 2)
            'End If



            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : bildt4 = "APR.'" & Mid(gFinancialyearEnd, 3, 2) : noofdays = 31 : month = "March  " & gFinancialyearEnd : bildt = "01/mar/" & gFinancialyearEnd : BILDT1 = "01/apr/" & gFinancialyearEnd : BILDT3 = "30/04/" & gFinancialyearEnd : BILDT5 = "15/04/" & gFinancialyearEnd : BILL = "01st Mar " & Mid(gFinancalyearStart, 3, 2) & " to 31st Mar " & Mid(gFinancalyearStart, 3, 2)

            Dim Viewer As New REPORTVIEWER
            'Dim r As New CRY_MONTHBILLSUMMARY

            Dim r


            If Trim(txt_Tomcode.Text) <> "" And Trim(txt_Tomcode.Text) <> "" Then
                r = New CRY_GOLFMONTHBILLSUMMARY
                sqlstring = " SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M WHERE M.MCODE = O.SLCODE AND M.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND O.BILLDATE < '" & bildt & "' AND  CURENTSTATUS IN('LIVE','ACTIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE ORDER BY M.MCODE "
                sqlstring1 = " select substring(billno,1,2) as billno,billdate,slcode,locdesc,sum(dramount) as dramount,sum(cramount) as cramount,Isnull(instrumentno,'')as instrumentno,isnull(instrumentdate,'')as instrumentdate,isnull(loccode,'')as loccode "
                sqlstring1 = sqlstring1 & "FROM View_Rec_Det WHERE LTRIM(RTRIM(SLCODE)) BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(BILLDATE) = " & month1 & " GROUP BY billno,SLCODE,locdesc ,instrumentno,instrumentdate,loccode,billdate order by billdate"
                ssql2 = " SELECT SNO,SLCODE,UPPER(HEADDESC) AS HEADDESC,SUM(DRAMOUNT) AS DRAMOUNT,SUM(CRAMOUNT) AS CRAMOUNT,SUM(TAX) AS TAX,SUM(VAT) AS VAT,SUM(TIPS) AS TIPS  FROM View_Pos_Summary WHERE MONTH(BILLDATE) = " & month1 & " AND SLCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' GROUP BY SLCODE,HEADDESC,SNO ORDER BY SNO "
                ' sqlstring2 = "select * from MEMBERSSETUP"

                gconnection.getDataSet(sqlstring, "MEMBERMASTER")
                gconnection.getDataSet(sqlstring1, "View_Rec_Det")
                gconnection.getDataSet(ssql2, "View_Pos_Summary")
                ' gconnection.getDataSet(sqlstring2, "MEMBERSSETUP")
            Else
                ' membertype = ""

                If chk_Filter_Field.CheckedItems.Count > 0 Then
                    For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                        TYPE = Split(chk_Filter_Field.CheckedItems(i), ".")
                        membertype = membertype & "'" & TYPE(0) & "', "
                    Next
                    membertype = Mid(membertype, 1, Len(membertype) - 2)

                Else
                    MessageBox.Show("Select the Category(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    chk_Filter_Field.Focus()

                    Exit Sub
                End If
                'If Rnd_billdues.Checked = True Then
                r = New CRY_GOLFMONTHBILLSUMMARY
                sqlstring = "SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+' '+ ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M WHERE SUBSTRING(M.MCODE,1,8) = SUBSTRING(O.SLCODE,1,8)  AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ")  "
                sqlstring = sqlstring & " AND O.BILLDATE <'" & bildt & "' AND  CURENTSTATUS in('ACTIVE','LIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE ORDER BY M.MCODE"
                ' ssql = " SELECT A.BILLNO,A.SLCODE AS SLCODE,upper(A.HEADDESC),SUM(A.AMOUNT) AS AMOUNT,A.BILLDATE FROM MAINCASHRECEIPT  A, MEMBERMASTER B "
                'ssql = ssql & " WHERE Month(BILLDATE) = " & month1
                ' ssql = ssql & " AND B.membertypecode IN(" & membertype & ") AND A.SLCODE=B.MCODE "
                ' ssql = ssql & " GROUP BY A.SLCODE,A.HEADDESC,A.BILLDATE,A.BILLNO "
                sqlstring1 = " select substring(a.billno,1,2)as billno ,a.billdate,a.SLCODE,sum(a.dramount) as dramount,sum(a.cramount) as cramount,Isnull(a.instrumentno,'')as instrumentno,isnull(a.instrumentdate,'')as instrumentdate,isnull(loccode,'')as loccode  "
                sqlstring1 = sqlstring1 & "  From View_Rec_Det a, MEMBERMASTER b WHERE MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  Group by  a.billno,a.SLCODE,a.instrumentno,a.instrumentdate,a.loccode,a.billdate"
                'sqlstring2 = "select * from MEMBERSSETUP"
                ssql2 = " SELECT a.SLCODE,a.SNO,upper(a.HEADDESC) AS HEADDESC,SUM(DRAMOUNT) AS DRAMOUNT,SUM(CRAMOUNT) AS CRAMOUNT,SUM(TAX) AS TAX,SUM(VAT) AS VAT,SUM(TIPS) AS TIPS FROM View_Pos_Summary  a, MEMBERMASTER b WHERE  MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  Group by  a.SNO,a.SLcode,a.HEADDESC ORDER BY a.SNO "


            End If
            gconnection.getDataSet(sqlstring, "MEMBERMASTER")
            gconnection.getDataSet(sqlstring1, "View_Rec_Det")
            gconnection.getDataSet(ssql2, "View_Pos_Summary")
            Call Viewer.GetDetails1(sqlstring, "MEMBERMASTER", r)
            Call Viewer.GetDetails1(sqlstring1, "View_Rec_Det", r)
            ' Call Viewer.GetDetails1(sqlstring2, "MEMBERSSETUP", r)
            Call Viewer.GetDetails1(ssql2, "View_Pos_Summary", r)


            Dim txtobj1 As TextObject
            Dim txtobj As TextObject

            Dim txtobj15 As TextObject
            Dim txtobj18 As TextObject
            Dim txtobj19 As TextObject
            Dim txtobj20 As TextObject
            Dim txtobj21 As TextObject
            Dim ADD1, ADD2, ADD3, ADD4 As String

            Dim txtobj2 As TextObject

            Dim FILEPATH As String
            txtobj19 = r.ReportDefinition.ReportObjects("Text19")
            'txtobj15 = r.ReportDefinition.ReportObjects("Text2")
            txtobj18 = r.ReportDefinition.ReportObjects("Text18")
            txtobj20 = r.ReportDefinition.ReportObjects("Text20")
            'txtobj21 = r.ReportDefinition.ReportObjects("Text5")
            txtobj2 = r.ReportDefinition.ReportObjects("Text28")

            'txtobj1.Text = ADD1
            Dim MBILLDATE As Date
            MBILLDATE = BILDT1
            If MBILLDATE > "30-jun-2017" Then
                txtobj1 = r.ReportDefinition.ReportObjects("Text7")
                txtobj1.Text = "CGST"
                txtobj1 = r.ReportDefinition.ReportObjects("Text11")
                txtobj1.Text = "SGST"
                txtobj1 = r.ReportDefinition.ReportObjects("Text13")
                txtobj1.Text = "CESS"
            End If
            txtobj1 = r.ReportDefinition.ReportObjects("Text29")
            txtobj1.Text = UCase(gcompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text30")
            txtobj1.Text = UCase(gCompanyAddress(0))
            txtobj1 = r.ReportDefinition.ReportObjects("Text32")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text3")
            txtobj1.Text = UCase(gCompanyAddress(2)) + " , " + UCase(gCompanyAddress(3))
            'txtobj18.Text = bildt
            txtobj19.Text = BILDT1
            'txtobj19.Text = "01/" & IIf(month1 > 9, Str(month1), "0" & month1) & "/" & IIf(month1 > 3, Mid(gFinancialyearStart, 7, 4), Mid(gFinancialyearEnd, 7, 4))
            'txtobj18.Text = noofdays & "/" & IIf(month1 > 9, Str(month1), "0" & month1) & "/" & IIf(month1 > 3, Mid(gFinancialyearStart, 7, 4), Mid(gFinancialyearEnd, 7, 4))
            txtobj20.Text = " Opening Balance as on " & bildt
            'txtobj15.Text = " Total Due/Credit as on " & BILDT1
            txtobj2.Text = UCase(Format(CbxMonth.Value, "MMM-yyyy"))
            'txtobj21.Text = Format(DTPduedate.Value, "dd/MM/yyyy")
            'ssql = "SELECT ISNULL(NOTES,'') AS NOTES FROM MEMBERSSETUP"
            'gconnection.getDataSet(ssql, "ADD1")
            'If gdataset.Tables("ADD1").Rows.Count > 0 Then

            '    If gdataset.Tables("ADD1").Rows(0).Item("NOTES") <> "" Then
            '        '  txtobj15 = r.ReportDefinition.ReportObjects("Text4")
            '        ' txtobj15.Text = gdataset.Tables("ADD1").Rows(0).Item("NOTES")

            '    Else
            '        ' txtobj15 = r.ReportDefinition.ReportObjects("Text4")
            '        ' txtobj15.Text = ""
            '    End If
            'Else
            '    'txtobj15 = r.ReportDefinition.ReportObjects("Text4")
            '    ' txtobj15.Text = ""
            'End If
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub GETSUMMARYDETAILS_PRINT_FNCC_dos()
        Try
            Dim cmdText As String
            Dim duedate, membertype, TYPE(0), bildt1, MONTH, BILLDT2, MONTH2, BILDT3, BILLDT4, BILLPRRM As String
            Dim bLeapYear As Boolean
            Dim billamount As Double
            bLeapYear = Date.IsLeapYear(gFinancialyearEnd)
            Dim pstr, kotdetails, MCODE As String
            Dim opl, i As Integer
            Call Validation()
            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : MONTH = "APR" : noofdays = 30 : bildt = "01/apr/" & gFinancalyearStart : MONTH2 = "04" : BILLDT2 = "30/apr/" & gFinancalyearStart : BILDT3 = "01/04/" & gFinancalyearStart : BILLDT4 = "30/04/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : MONTH = "MAY" : noofdays = 31 : bildt = "01/may/" & gFinancalyearStart : MONTH2 = "05" : BILLDT2 = "31/may/" & gFinancalyearStart : BILDT3 = "01/05/" & gFinancalyearStart : BILLDT4 = "31/05/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : MONTH = "JUN" : noofdays = 30 : bildt = "01/jun/" & gFinancalyearStart : MONTH2 = "06" : BILLDT2 = "30/jun/" & gFinancalyearStart : BILDT3 = "01/06/" & gFinancalyearStart : BILLDT4 = "30/06/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : MONTH = "JUL" : noofdays = 31 : bildt = "01/jul/" & gFinancalyearStart : MONTH2 = "07" : BILLDT2 = "31/jul/" & gFinancalyearStart : BILDT3 = "01/07/" & gFinancalyearStart : BILLDT4 = "31/07/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : MONTH = "AUG" : noofdays = 31 : bildt = "01/aug/" & gFinancalyearStart : MONTH2 = "08" : BILLDT2 = "31/aug/" & gFinancalyearStart : BILDT3 = "01/08/" & gFinancalyearStart : BILLDT4 = "31/08/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : MONTH = "SEP" : noofdays = 30 : bildt = "01/sep/" & gFinancalyearStart : MONTH2 = "09" : BILLDT2 = "30/sep/" & gFinancalyearStart : BILDT3 = "01/09/" & gFinancalyearStart : BILLDT4 = "30/09/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : MONTH = "OCT" : noofdays = 31 : bildt = "01/oct/" & gFinancalyearStart : MONTH2 = "10" : BILLDT2 = "31/oct/" & gFinancalyearStart : BILDT3 = "01/10/" & gFinancalyearStart : BILLDT4 = "31/10/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : MONTH = "NOV" : noofdays = 30 : bildt = "01/nov/" & gFinancalyearStart : MONTH2 = "11" : BILLDT2 = "30/nov/" & gFinancalyearStart : BILDT3 = "01/11/" & gFinancalyearStart : BILLDT4 = "30/11/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : MONTH = "DEC" : noofdays = 31 : bildt = "01/dec/" & gFinancalyearStart : MONTH2 = "12" : BILLDT2 = "31/dec/" & gFinancalyearStart : BILDT3 = "01/12/" & gFinancalyearStart : BILLDT4 = "31/12/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : MONTH = "JAN" : noofdays = 31 : bildt = "01/jan/" & gFinancialyearEnd : MONTH2 = "01" : BILLDT2 = "31/jan/" & gFinancialyearEnd : BILDT3 = "01/01/" & gFinancialyearEnd : BILLDT4 = "31/01/" & gFinancialyearEnd
            'If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : MONTH = "FEB" : noofdays = 28 : bildt = "01/feb/" & gFinancialyearEnd : MONTH2 = "02" : BILLDT2 = "28/feb/" & gFinancialyearEnd : BILDT3 = "01/02/" & gFinancialyearEnd : BILLDT4 = "28/02/" & gFinancialyearEnd
            If bLeapYear = True Then
                If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : MONTH = "FEB" : noofdays = 29 : bildt = "01/feb/" & gFinancialyearEnd : MONTH2 = "02" : BILLDT2 = "29/feb/" & gFinancialyearEnd : BILDT3 = "01/02/" & gFinancialyearEnd : BILLDT4 = "29/02/" & gFinancialyearEnd
            Else
                If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : MONTH = "FEB" : noofdays = 28 : bildt = "01/feb/" & gFinancialyearEnd : MONTH2 = "02" : BILLDT2 = "28/feb/" & gFinancialyearEnd : BILDT3 = "01/02/" & gFinancialyearEnd : BILLDT4 = "28/02/" & gFinancialyearEnd
            End If
            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : MONTH = "MAR" : noofdays = 31 : bildt = "01/mar/" & gFinancialyearEnd : MONTH2 = "03" : BILLDT2 = "31/mar/" & gFinancialyearEnd : BILDT3 = "01/03/" & gFinancialyearEnd : BILLDT4 = "31/03/" & gFinancialyearEnd
            'BILLPRRM = Format(BILLDT4, "dd MMM yyyy")


            Randomize()
            apppath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = apppath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            Dim cnt As Integer
            cnt = 1

            If Rnd_Details.Checked = True Then

                'If Trim(txt_Tomcode.Text) <> "" And Trim(txt_Tomcode.Text) <> "" Then
                '    ssql = " SELECT * FROM MEMBERWISESALESUMMARY "
                '    ssql = ssql & " WHERE LTRIM(RTRIM(MCODE)) BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND (CAST(CONVERT(VARCHAR(11),KOTDATE,106)AS DATETIME) BETWEEN '" & bildt & "'  AND '" & bildt1 & "')"
                '    ssql = ssql & " ORDER BY KOTDATE "
                '    sqlstring = " SELECT distinct mcode,SUBSTRING(mcode,1,1) as mcode1,LEN(mcode) as mcode2,ISNULL(mcode,'') as mcode3,mname FROM MEMBERWISESALESUMMARY "
                '    sqlstring = sqlstring & " WHERE  MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND CAST(CONVERT(VARCHAR(11),KOTDATE,106)AS DATETIME) BETWEEN '" & bildt & "'  AND '" & bildt1 & "' ORDER BY  SUBSTRING(mcode,1,1),LEN(mcode),ISNULL(mcode,''),mcode,mname"
                'Else
                '    membertype = ""
                '    If chk_Filter_Field.CheckedItems.Count > 0 Then
                '        For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                '            TYPE = Split(chk_Filter_Field.CheckedItems(i), ".")
                '            membertype = membertype & "'" & TYPE(0) & "', "
                '        Next
                '        membertype = Mid(membertype, 1, Len(membertype) - 2)
                '    Else
                '        MessageBox.Show("Select the Category(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '        Exit Sub
                '    End If
                '    ssql = " SELECT * FROM MEMBERWISESALESUMMARY "
                '    ssql = ssql & " WHERE membertypecode IN(" & membertype & ") AND (CAST(CONVERT(VARCHAR(11),KOTDATE,106)AS DATETIME) BETWEEN '" & bildt & "'  AND '" & bildt1 & "') ORDER BY KOTDATE"
                '    sqlstring = " SELECT distinct mcode,SUBSTRING(mcode,1,1) as mcode1,LEN(mcode) as mcode2,ISNULL(mcode,'') as mcode3,mname FROM MEMBERWISESALESUMMARY "
                '    sqlstring = sqlstring & " WHERE membertypecode IN(" & membertype & ") AND (CAST(CONVERT(VARCHAR(11),KOTDATE,106)AS DATETIME) BETWEEN '" & bildt & "'  AND '" & bildt1 & "') ORDER BY  SUBSTRING(mcode,1,1),LEN(mcode),ISNULL(mcode,''),mcode,mname"

                'End If

                If Trim(txt_Tomcode.Text) <> "" And Trim(txt_Tomcode.Text) <> "" Then
                    sqlstring = "SELECT  DISTINCT ISNULL(MCODE,'') as MCODE from member_consumption_dettab WHERE  MONTH(KOTDATE) = '" & month1 & "' "
                    gconnection.getDataSet(sqlstring, "CheckData")
                    If gdataset.Tables("CheckData").Rows.Count > 0 Then
                    Else
                        sqlstring = "Exec  PROC_MEMBER_CONSUMPTION_DET '" & month1 & "' "
                        gconnection.ExcuteStoreProcedure(sqlstring)
                    End If
                    'sqlstring = "select isnull(qty,0) as qty,isnull(rate,0) as rate,isnull(poscode,'') as poscode,isnull(billdetails,'') as billdetails,cast(convert(varchar(11),kotdate,106) as datetime) as kotdate,isnull(itemdesc,'') as itemdesc,SUM(isnull(amount,0)) AS AMOUNT,SUM(isnull(vat,0)) as vat,SUM(isnull(service_tax,0)) as service_tax,SUM(isnull(service_charge,0)) as service_charge,m.mcode,m.mname as posdesc from member_consumption_det t,membermaster m where t.mcode=m.mcode and LTRIM(RTRIM(m.MCODE)) BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(KOTDATE) = " & MONTH2 & ""
                    'sqlstring = sqlstring & " group by qty,rate,billdetails,cast(convert(varchar(11),kotdate,106) as datetime),itemdesc,poscode,m.mcode,m.mname "
                    'sqlstring = "select isnull(qty,0) as qty,isnull(rate,0) as rate,isnull(poscode,'') as poscode,isnull(billdetails,'') as billdetails,cast(convert(varchar(11),kotdate,106) as datetime) as kotdate,isnull(itemdesc,'') as itemdesc,SUM(isnull(amount,0)) AS AMOUNT,SUM(isnull(vat,0)) as vat,SUM(isnull(service_tax,0)) as service_tax,SUM(isnull(service_charge,0)) as service_charge,m.mcode,m.mname as posdesc from member_consumption_det t,membermaster m where t.mcode=m.mcode and LTRIM(RTRIM(m.MCODE)) BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(KOTDATE) = " & MONTH2 & ""
                    'sqlstring = "select isnull(qty,0) as qty,isnull(rate,0) as rate,isnull(poscode,'') as poscode,isnull(billdetails,'') as billdetails,cast(convert(varchar(11),kotdate,106) as datetime) as kotdate,isnull(itemdesc,'') as itemdesc,SUM(isnull(amount,0)) AS AMOUNT,SUM(isnull(vat,0)) as vat,SUM(isnull(service_tax,0)) as service_tax,SUM(isnull(service_charge,0)) as service_charge,m.mcode,m.mname as posdesc from member_consumption_det t,membermaster m where t.mcode=m.mcode and LTRIM(RTRIM(m.MCODE)) like '" & txt_mcode.Text & "%' AND MONTH(KOTDATE) = " & MONTH2 & ""
                    'sqlstring = "select isnull(qty,0) as qty,isnull(rate,0) as rate,isnull(poscode,'') as poscode,isnull(billdetails,'') as billdetails,cast(convert(varchar(11),kotdate,106) as datetime) as kotdate,isnull(itemdesc,'') as itemdesc,SUM(isnull(amount,0)) AS AMOUNT,SUM(isnull(vat,0)) as vat,SUM(isnull(service_tax,0)) as service_tax,SUM(isnull(service_charge,0)) as service_charge,m.mcode,m.mname as posdesc from member_consumption_det t,membermaster m where t.mcode=m.mcode and substring(M.MCODE,1,2)+substring('00000000000',1,11-(len(M.MCODE)))+substring(M.MCODE,3,len(M.MCODE)-2) between substring('" & txt_mcode.Text & "',1,2)+substring('00000000000',1,11-(len('" & txt_mcode.Text & "')))+substring('" & txt_mcode.Text & "',3,len('" & txt_mcode.Text & "')-2)  and  substring('" & txt_Tomcode.Text & "',1,2)+substring('00000000000',1,11-(len('" & txt_Tomcode.Text & "')))+substring('" & txt_Tomcode.Text & "',3,len('" & txt_Tomcode.Text & "')-2) AND MONTH(KOTDATE) = " & MONTH2 & ""
                    'sqlstring = sqlstring & " group by qty,rate,billdetails,cast(convert(varchar(11),kotdate,106) as datetime),itemdesc,poscode,m.mcode,m.mname order by SUBSTRING(M.MCODE,1,2),LEN(M.MCODE),M.MCODE"
                    sqlstring = "select sum(isnull(qty,0)) as qty,isnull(rate,0) as rate,isnull(poscode,'') as poscode,isnull(billdetails,'') as billdetails,cast(convert(varchar(11),kotdate,106) as datetime) as kotdate,isnull(itemdesc,'') as itemdesc,SUM(isnull(amount,0)) AS AMOUNT,SUM(isnull(vat,0)) as vat,SUM(isnull(service_tax,0)) as service_tax,SUM(isnull(service_charge,0)) as service_charge,m.mcode,m.mname as posdesc,(SUM(isnull(amount,0))+SUM(isnull(vat,0))+SUM(isnull(service_tax,0))+SUM(isnull(service_charge,0)) ) AS BILLAMOUNT from member_consumption_dettab t,membermaster m where t.mcode=m.mcode and M.mcode between '" & txt_mcode.Text & "' and '" & txt_Tomcode.Text & "' AND MONTH(KOTDATE) = " & MONTH2 & ""
                    sqlstring = sqlstring & " group by  rate,billdetails,cast(convert(varchar(11),kotdate,106) as datetime),itemdesc,poscode,m.mcode,m.mname order by M.MCODE"

                    'sqlstring1 = "select t.mcode,ISNULL(t.billno ,'') as billno,  ISNULL(t.billdate ,'') as billdate, ISNULL(t.Instrumentno ,'') as Instrumentno , ISNULL(t.InstrumentType  ,'') as InstrumentType,ISNULL(t.Cramount  ,0) as Cramount,ISNULL(t.Dramount   ,0) as Dramount"
                    'sqlstring1 = sqlstring1 & ",ISNULL(t.locdesc,'') as locdesc,ISNULL(t.Description ,'') as Description,ISNULL(t.CREDITDEBIT ,'') as CREDITDEBIT from View_Recipt_DetCCL t,membermaster m where t.mcode=m.mcode and M.mcode between '" & txt_mcode.Text & "' and '" & txt_Tomcode.Text & "' AND MONTH(billdate) = " & MONTH2 & "order by  CREDITDEBIT"

                Else
                    sqlstring = ""
                    sqlstring = "Exec  PROC_MEMBER_CONSUMPTION_DET '" & month1 & "' "
                    gconnection.ExcuteStoreProcedure(sqlstring)

                    membertype = ""
                    If chk_Filter_Field.CheckedItems.Count > 0 Then
                        For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                            TYPE = Split(chk_Filter_Field.CheckedItems(i), ".")
                            membertype = membertype & "'" & TYPE(0) & "', "
                        Next
                        membertype = Mid(membertype, 1, Len(membertype) - 2)
                    Else
                        MessageBox.Show("Select the Category(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                    'sqlstring = "select ISNULL(POSCODE,'') AS POSCODE,isnull(qty,0) as qty,isnull(rate,0) as rate,isnull(billdetails,'') as billdetails,cast(convert(varchar(11),kotdate,106) as datetime) as kotdate,isnull(itemdesc,'') as itemdesc,SUM(isnull(amount,0)) AS AMOUNT,SUM(isnull(vat,0)) as vat,SUM(isnull(service_tax,0)) as service_tax,SUM(isnull(service_charge,0)) as service_charge,m.mcode,m.mname as posdesc from member_consumption_det t,membermaster m where t.mcode=m.mcode AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") AND MONTH(KOTDATE) = " & MONTH2 & ""
                    'sqlstring = sqlstring & " group by qty,rate,billdetails,cast(convert(varchar(11),kotdate,106) as datetime),itemdesc,poscode,m.mcode,m.mname"
                    'sqlstring = "select ISNULL(POSCODE,'') AS POSCODE,isnull(qty,0) as qty,isnull(rate,0) as rate,isnull(billdetails,'') as billdetails,cast(convert(varchar(11),kotdate,106) as datetime) as kotdate,isnull(itemdesc,'') as itemdesc,SUM(isnull(amount,0)) AS AMOUNT,SUM(isnull(vat,0)) as vat,SUM(isnull(service_tax,0)) as service_tax,SUM(isnull(service_charge,0)) as service_charge,m.mcode,m.mname as posdesc from member_consumption_det t,membermaster m where t.mcode=m.mcode AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") AND MONTH(KOTDATE) = " & MONTH2 & ""
                    'sqlstring = sqlstring & " group by qty,rate,billdetails,cast(convert(varchar(11),kotdate,106) as datetime),itemdesc,poscode,m.mcode,m.mname order by SUBSTRING(M.MCODE,1,2),LEN(M.MCODE),M.MCODE"
                    sqlstring = "select ISNULL(POSCODE,'') AS POSCODE,sum(isnull(qty,0)) as qty,isnull(rate,0) as rate,isnull(billdetails,'') as billdetails,cast(convert(varchar(11),kotdate,106) as datetime) as kotdate,isnull(itemdesc,'') as itemdesc,SUM(isnull(amount,0)) AS AMOUNT,SUM(isnull(vat,0)) as vat,SUM(isnull(service_tax,0)) as service_tax,SUM(isnull(service_charge,0)) as service_charge,m.mcode,m.mname as posdesc,(SUM(isnull(amount,0))+SUM(isnull(vat,0))+SUM(isnull(service_tax,0))+SUM(isnull(service_charge,0)) ) AS BILLAMOUNT from member_consumption_dettab t,membermaster m where t.mcode=m.mcode AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") AND MONTH(KOTDATE) = " & MONTH2 & ""
                    sqlstring = sqlstring & " group by  rate,billdetails,cast(convert(varchar(11),kotdate,106) as datetime),itemdesc,poscode,m.mcode,m.mname order by SUBSTRING(M.MCODE,1,2),LEN(M.MCODE),M.MCODE"
                    'sqlstring1 = "select t.mcode,ISNULL(t.billno,'') as billno,  ISNULL(t.billdate,'') as billdate, ISNULL(t.Instrumentno,'') as Instrumentno , ISNULL(t.InstrumentType,'') as InstrumentType,ISNULL(t.Cramount,0) as Cramount,ISNULL(t.Dramount,0) as Dramount"
                    'sqlstring1 = sqlstring1 & ",ISNULL(t.locdesc,'') as locdesc,ISNULL(t.Description ,'') as Description,ISNULL(t.CREDITDEBIT ,'') as CREDITDEBIT from View_Recipt_DetCCL t,membermaster m where t.mcode=m.mcode AND LTRIM(RTRIM(m.membertypecode)) IN (" & membertype & ")  AND MONTH(billdate) = " & MONTH2 & "order by  CREDITDEBIT"
                End If
                gconnection.getDataSet(sqlstring, "MEMBERWISESALESUMMARY")
                'dt = gconnection.GetValues(sqlstring)
                'dt1 = gconnection.GetValues(ssql)
                If gdataset.Tables("MEMBERWISESALESUMMARY").Rows.Count > 0 Then
                    Filewrite.WriteLine()
                    PageNo = PageNo + 1
                    PageSize = PageSize + 1
                    Dim dr As DataRow
                    For Each dr In gdataset.Tables("MEMBERWISESALESUMMARY").Rows
                        If MCODE <> Trim(CStr(dr("MCODE"))) Then
                            Filewrite.Write(Space(1) & "Mcode : " & Mid(dr("Mcode"), 1, 7) & Space(7 - Len(Mid(dr("mcode"), 1, 7))))
                            MCODE = Trim(CStr(dr("Mcode")))
                            Filewrite.Write(Space(1) & "Mname : " & Mid(dr("posdesc"), 1, 25) & Space(25 - Len(Mid(dr("posdesc"), 1, 25))))
                            'Filewrite.Write(Space(1) & "Mcode " & Mid(Trim(dt.Rows(i).Item("mcode") & ""), 1, 9))
                            'Filewrite.Write(Space(1) & "Mname " & Mid(Trim(dr("mname") & ""), 1, 25))
                            PageSize = PageSize + 1
                            Filewrite.Write("{0,-12}", Mid("'" & Format(CDate(bildt), "dd/MM/yyyy") & "'", 1, 13) & Space(13 - Len(Mid("'" & Format(CDate(bildt), "dd/MM/yyyy") & "'", 1, 13))))
                            PageSize = PageSize + 1
                            Filewrite.WriteLine("{0,-12}", "-" & Mid("'" & Format(CDate(BILLDT2), "dd/MM/yyyy") & "'", 1, 13) & Space(13 - Len(Mid("'" & Format(CDate(BILLDT2), "dd/MM/yyyy"), 1, 13))))
                            PageSize = PageSize + 1
                            Filewrite.WriteLine(StrDup(105, "."))
                            PageSize = PageSize + 1
                            Filewrite.WriteLine("Date     KOT No     Item Description       Qty    Rate    Amount      Vat       Stax    S.charges   Total")
                            PageSize = PageSize + 1
                            Filewrite.WriteLine(StrDup(105, "."))
                            PageSize = PageSize + 1

                            ssql = " SELECT isnull(qty,0) as qty,isnull(rate,0) as rate,isnull(billdetails,'') as billdetails,cast(convert(varchar(11),kotdate,106) as datetime) as kotdate,isnull(itemdesc,'') as itemdesc,SUM(isnull(amount,0)) AS AMOUNT,SUM(isnull(vat,0)) as vat,SUM(isnull(service_tax,0)) as service_tax,SUM(isnull(service_charge,0)) as service_charge,mcode, poscode as posdesc,(SUM(isnull(amount,0))+SUM(isnull(vat,0))+SUM(isnull(service_tax,0))+SUM(isnull(service_charge,0)) ) AS BILLAMOUNT FROM member_consumption_dettab "
                            ssql = ssql & " WHERE MCODE ='" & dr("Mcode") & "' AND (CAST(CONVERT(VARCHAR(11),KOTDATE,106)AS DATETIME) BETWEEN '" & bildt & "'  AND '" & BILLDT2 & "')"
                            ssql = ssql & " group by qty , rate,  billdetails,kotdate,itemdesc,mcode,poscode ORDER BY KOTDATE,billDETAILS,posdesc "
                            gconnection.getDataSet(ssql, "CREDITSALEREGISTER")
                            If gdataset.Tables("CREDITSALEREGISTER").Rows.Count > 0 Then
                                For Each dr1 In gdataset.Tables("CREDITSALEREGISTER").Rows
                                    If kotdetails <> Trim(CStr(dr1("billDETAILS"))) Then
                                        Filewrite.Write("{0,-12}", Mid(Format(dr1("KOTDATE"), "dd/MM/yyyy"), 1, 10) & Space(10 - Len(Mid(Format(dr1("KOTDATE"), "dd/MM/yyyy"), 1, 10))))
                                        Filewrite.WriteLine("{0,-20}", Mid(CStr(dr1("billDETAILS")), 1, 20) & Space(20 - Len(Mid(CStr(dr1("billDETAILS")), 1, 20))))
                                        kotdetails = Trim(CStr(dr1("billDETAILS")))
                                    End If
                                    Filewrite.Write(Space(20) & "" & Mid(dr1("ITEMDESC"), 1, 16) & Space(16 - Len(Mid(dr1("ITEMDESC"), 1, 16))))
                                    Filewrite.Write("{0,8}", Space(7 - Len(Mid(Format(Val(dr1("QTY")), "0"), 1, 8))) & Mid(Format(Val(dr1("QTY")), "0"), 1, 8))
                                    Filewrite.Write("{0,10}", Space(10 - Len(Mid(Format(Val(dr1("RATE")), "0.00"), 1, 10))) & Mid(Format(Val(dr1("RATE")), "0.00"), 1, 10))
                                    Filewrite.Write("{0,10}", Space(10 - Len(Mid(Format(Val(dr1("AMOUNT")), "0.00"), 1, 10))) & Mid(Format(Val(dr1("AMOUNT")), "0.00"), 1, 10))
                                    Filewrite.Write("{0,10}", Space(10 - Len(Mid(Format(Val(dr1("vat")), "0.00"), 1, 10))) & Mid(Format(Val(dr1("vat")), "0.00"), 1, 10))
                                    Filewrite.Write("{0,7}", Space(10 - Len(Mid(Format(Val(dr1("service_tax")), "0.00"), 1, 10))) & Mid(Format(Val(dr1("service_tax")), "0.00"), 1, 10))
                                    Filewrite.Write("{0,7}", Space(10 - Len(Mid(Format(Val(dr1("service_charge")), "0.00"), 1, 10))) & Mid(Format(Val(dr1("service_charge")), "0.00"), 1, 10))
                                    Filewrite.WriteLine("{0,10}", Space(10 - Len(Mid(Format(Val(dr1("BILLAMOUNT")), "0.00"), 1, 10))) & Mid(Format(Val(dr1("BILLAMOUNT")), "0.00"), 1, 10))
                                    PageSize = PageSize + 1
                                Next dr1
                            End If
                            ssql = " SELECT SUM(isnull(AMOUNT,0)) AS AMOUNT,SUM(isnull(vat,0)) AS vat,SUM(isnull(service_tax,0)) AS service_tax,SUM(isnull(service_charge,0)) AS service_charge,(SUM(isnull(amount,0))+SUM(isnull(vat,0))+SUM(isnull(service_tax,0))+SUM(isnull(service_charge,0)) ) AS BILLAMOUNT FROM member_consumption_dettab "
                            ssql = ssql & " WHERE MCODE ='" & dr("Mcode") & "' AND (CAST(CONVERT(VARCHAR(11),KOTDATE,106)AS DATETIME) BETWEEN '" & bildt & "'  AND '" & BILLDT2 & "')"
                            gconnection.getDataSet(ssql, "CREDITSALEREGISTER")
                            For Each dr2 In gdataset.Tables("CREDITSALEREGISTER").Rows
                                Filewrite.WriteLine(StrDup(105, "."))
                                PageSize = PageSize + 1
                                'Filewrite.WriteLine(Space(1) & "Grand Total  " & Mid(Val(dr2("AMOUNT")), 1, 25) & Space(25 - Len(Mid(Val(dr2("AMOUNT")), 1, 25))) & Mid(Val(dr2("TAXAMOUNT")), 1, 20) & Space(20 - Len(Mid(dr2("TAXAMOUNT"), 1, 20))) & Mid(Val(dr2("PACKAMOUNT")), 1, 20) & Space(20 - Len(Mid(dr2("PACKAMOUNT"), 1, 20))) & Mid(Val(dr2("BILLAMOUNT")), 1, 20) & Space(20 - Len(Mid(dr2("BILLAMOUNT"), 1, 20))))
                                Filewrite.Write(Space(3) & "Grand Total  " & "{0,48}", Space(42 - Len(Mid(Format(Val(dr2("AMOUNT")), "0.00"), 1, 48))) & Mid(Format(Val(dr2("AMOUNT")), "0.00"), 1, 48))
                                Filewrite.Write("{0,10}", Space(10 - Len(Mid(Format(Val(dr2("vat")), "0.00"), 1, 10))) & Mid(Format(Val(dr2("vat")), "0.00"), 1, 10))
                                Filewrite.Write("{0,10}", Space(10 - Len(Mid(Format(Val(dr2("service_tax")), "0.00"), 1, 10))) & Mid(Format(Val(dr2("service_tax")), "0.00"), 1, 10))
                                Filewrite.Write("{0,10}", Space(10 - Len(Mid(Format(Val(dr2("service_charge")), "0.00"), 1, 10))) & Mid(Format(Val(dr2("service_charge")), "0.00"), 1, 10))
                                'billamount = Format(Val(dr2("vat")), "0.00") + Format(Val(dr2("service_tax")), "0.00") + Format(Val(dr2("service_charge")), "0.00")
                                Filewrite.WriteLine("{0,10}", Space(10 - Len(Mid(Format(Val(dr2("BILLAMOUNT")), "0.00"), 1, 10))) & Mid(Format(Val(dr2("BILLAMOUNT")), "0.00"), 1, 10))
                                PageSize = PageSize + 1
                                Filewrite.WriteLine(StrDup(105, "."))
                                PageSize = PageSize + 1

                                Filewrite.WriteLine()
                                Filewrite.WriteLine()
                                Filewrite.WriteLine()
                            Next dr2
                        End If
                    Next dr
                    Filewrite.Write(Chr(12))
                    Filewrite.Close()
                    If GPRINT = False Then
                        OpenTextFile(vOutfile)
                    Else
                        PrintTextFile(VFilePath)
                    End If
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub GETSUMMARY_PRINT()
        Try
            Dim cmdText As String
            Dim duedate, membertype, TYPE(0), bildt1, MONTH, BILLDT2, MONTH2, BILDT3, BILLDT4, BILLPRRM As String
            Dim bLeapYear As Boolean
            bLeapYear = Date.IsLeapYear(gFinancialyearEnd)

            Dim opl, i As Integer
            Call Validation()
            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : MONTH = "APR" : noofdays = 30 : bildt = "01/apr/" & gFinancalyearStart : MONTH2 = "04" : BILLDT2 = "30/apr/" & gFinancalyearStart : BILDT3 = "01/04/" & gFinancalyearStart : BILLDT4 = "30/04/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : MONTH = "MAY" : noofdays = 31 : bildt = "01/may/" & gFinancalyearStart : MONTH2 = "05" : BILLDT2 = "31/may/" & gFinancalyearStart : BILDT3 = "01/05/" & gFinancalyearStart : BILLDT4 = "31/05/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : MONTH = "JUN" : noofdays = 30 : bildt = "01/jun/" & gFinancalyearStart : MONTH2 = "06" : BILLDT2 = "30/jun/" & gFinancalyearStart : BILDT3 = "01/06/" & gFinancalyearStart : BILLDT4 = "30/06/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : MONTH = "JUL" : noofdays = 31 : bildt = "01/jul/" & gFinancalyearStart : MONTH2 = "07" : BILLDT2 = "31/jul/" & gFinancalyearStart : BILDT3 = "01/07/" & gFinancalyearStart : BILLDT4 = "31/07/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : MONTH = "AUG" : noofdays = 31 : bildt = "01/aug/" & gFinancalyearStart : MONTH2 = "08" : BILLDT2 = "31/aug/" & gFinancalyearStart : BILDT3 = "01/08/" & gFinancalyearStart : BILLDT4 = "31/08/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : MONTH = "SEP" : noofdays = 30 : bildt = "01/sep/" & gFinancalyearStart : MONTH2 = "09" : BILLDT2 = "30/sep/" & gFinancalyearStart : BILDT3 = "01/09/" & gFinancalyearStart : BILLDT4 = "30/09/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : MONTH = "OCT" : noofdays = 31 : bildt = "01/oct/" & gFinancalyearStart : MONTH2 = "10" : BILLDT2 = "31/oct/" & gFinancalyearStart : BILDT3 = "01/10/" & gFinancalyearStart : BILLDT4 = "31/10/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : MONTH = "NOV" : noofdays = 30 : bildt = "01/nov/" & gFinancalyearStart : MONTH2 = "11" : BILLDT2 = "30/nov/" & gFinancalyearStart : BILDT3 = "01/11/" & gFinancalyearStart : BILLDT4 = "30/11/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : MONTH = "DEC" : noofdays = 31 : bildt = "01/dec/" & gFinancalyearStart : MONTH2 = "12" : BILLDT2 = "31/dec/" & gFinancalyearStart : BILDT3 = "01/12/" & gFinancalyearStart : BILLDT4 = "31/12/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : MONTH = "JAN" : noofdays = 31 : bildt = "01/jan/" & gFinancialyearEnd : MONTH2 = "01" : BILLDT2 = "31/jan/" & gFinancialyearEnd : BILDT3 = "01/01/" & gFinancialyearEnd : BILLDT4 = "31/01/" & gFinancialyearEnd
            'If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : MONTH = "FEB" : noofdays = 28 : bildt = "01/feb/" & gFinancialyearEnd : MONTH2 = "02" : BILLDT2 = "28/feb/" & gFinancialyearEnd : BILDT3 = "01/02/" & gFinancialyearEnd : BILLDT4 = "28/02/" & gFinancialyearEnd
            If bLeapYear = True Then
                If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : MONTH = "FEB" : noofdays = 29 : bildt = "01/feb/" & gFinancialyearEnd : MONTH2 = "02" : BILLDT2 = "29/feb/" & gFinancialyearEnd : BILDT3 = "01/02/" & gFinancialyearEnd : BILLDT4 = "29/02/" & gFinancialyearEnd
            Else
                If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : MONTH = "FEB" : noofdays = 28 : bildt = "01/feb/" & gFinancialyearEnd : MONTH2 = "02" : BILLDT2 = "28/feb/" & gFinancialyearEnd : BILDT3 = "01/02/" & gFinancialyearEnd : BILLDT4 = "28/02/" & gFinancialyearEnd
            End If
            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : MONTH = "MAR" : noofdays = 31 : bildt = "01/mar/" & gFinancialyearEnd : MONTH2 = "03" : BILLDT2 = "31/mar/" & gFinancialyearEnd : BILDT3 = "01/03/" & gFinancialyearEnd : BILLDT4 = "31/03/" & gFinancialyearEnd
            'BILLPRRM = Format(BILLDT4, "dd MMM yyyy")
            sqlstring = "Exec  [CP_POSTING_PARTYROOM] '" & BILLDT2 & "'"
            gconnection.ExcuteStoreProcedure(sqlstring)

            Dim Viewer As New REPORTVIEWER
            If Rnd_Details.Checked = True Then
                Dim r ''As New Cry_Det
                If Mid(UCase(Trim(gcompanyname)), 1, 3) = "MLA" Then
                    r = New CCLCry_Det_MLA
                Else
                    r = New CCLCry_Det
                End If
                If Trim(txt_Tomcode.Text) <> "" And Trim(txt_Tomcode.Text) <> "" Then
                    sqlstring = "SELECT  DISTINCT ISNULL(MCODE,'') as MCODE from member_consumption_dettab WHERE  MONTH(KOTDATE) = '" & month1 & "' "
                    gconnection.getDataSet(sqlstring, "CheckData")
                    If gdataset.Tables("CheckData").Rows.Count > 0 Then
                    Else
                        sqlstring = "Exec  PROC_MEMBER_CONSUMPTION_DET '" & month1 & "' "
                        gconnection.ExcuteStoreProcedure(sqlstring)
                    End If
                    'sqlstring = "select isnull(qty,0) as qty,isnull(rate,0) as rate,isnull(poscode,'') as poscode,isnull(billdetails,'') as billdetails,cast(convert(varchar(11),kotdate,106) as datetime) as kotdate,isnull(itemdesc,'') as itemdesc,SUM(isnull(amount,0)) AS AMOUNT,SUM(isnull(vat,0)) as vat,SUM(isnull(service_tax,0)) as service_tax,SUM(isnull(service_charge,0)) as service_charge,m.mcode,m.mname as posdesc from member_consumption_det t,membermaster m where t.mcode=m.mcode and LTRIM(RTRIM(m.MCODE)) BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(KOTDATE) = " & MONTH2 & ""
                    'sqlstring = sqlstring & " group by qty,rate,billdetails,cast(convert(varchar(11),kotdate,106) as datetime),itemdesc,poscode,m.mcode,m.mname "
                    'sqlstring = "select isnull(qty,0) as qty,isnull(rate,0) as rate,isnull(poscode,'') as poscode,isnull(billdetails,'') as billdetails,cast(convert(varchar(11),kotdate,106) as datetime) as kotdate,isnull(itemdesc,'') as itemdesc,SUM(isnull(amount,0)) AS AMOUNT,SUM(isnull(vat,0)) as vat,SUM(isnull(service_tax,0)) as service_tax,SUM(isnull(service_charge,0)) as service_charge,m.mcode,m.mname as posdesc from member_consumption_det t,membermaster m where t.mcode=m.mcode and LTRIM(RTRIM(m.MCODE)) BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(KOTDATE) = " & MONTH2 & ""
                    'sqlstring = "select isnull(qty,0) as qty,isnull(rate,0) as rate,isnull(poscode,'') as poscode,isnull(billdetails,'') as billdetails,cast(convert(varchar(11),kotdate,106) as datetime) as kotdate,isnull(itemdesc,'') as itemdesc,SUM(isnull(amount,0)) AS AMOUNT,SUM(isnull(vat,0)) as vat,SUM(isnull(service_tax,0)) as service_tax,SUM(isnull(service_charge,0)) as service_charge,m.mcode,m.mname as posdesc from member_consumption_det t,membermaster m where t.mcode=m.mcode and LTRIM(RTRIM(m.MCODE)) like '" & txt_mcode.Text & "%' AND MONTH(KOTDATE) = " & MONTH2 & ""
                    'sqlstring = "select isnull(qty,0) as qty,isnull(rate,0) as rate,isnull(poscode,'') as poscode,isnull(billdetails,'') as billdetails,cast(convert(varchar(11),kotdate,106) as datetime) as kotdate,isnull(itemdesc,'') as itemdesc,SUM(isnull(amount,0)) AS AMOUNT,SUM(isnull(vat,0)) as vat,SUM(isnull(service_tax,0)) as service_tax,SUM(isnull(service_charge,0)) as service_charge,m.mcode,m.mname as posdesc from member_consumption_det t,membermaster m where t.mcode=m.mcode and substring(M.MCODE,1,2)+substring('00000000000',1,11-(len(M.MCODE)))+substring(M.MCODE,3,len(M.MCODE)-2) between substring('" & txt_mcode.Text & "',1,2)+substring('00000000000',1,11-(len('" & txt_mcode.Text & "')))+substring('" & txt_mcode.Text & "',3,len('" & txt_mcode.Text & "')-2)  and  substring('" & txt_Tomcode.Text & "',1,2)+substring('00000000000',1,11-(len('" & txt_Tomcode.Text & "')))+substring('" & txt_Tomcode.Text & "',3,len('" & txt_Tomcode.Text & "')-2) AND MONTH(KOTDATE) = " & MONTH2 & ""
                    'sqlstring = sqlstring & " group by qty,rate,billdetails,cast(convert(varchar(11),kotdate,106) as datetime),itemdesc,poscode,m.mcode,m.mname order by SUBSTRING(M.MCODE,1,2),LEN(M.MCODE),M.MCODE"
                    sqlstring = "select sum(isnull(qty,0)) as qty,isnull(rate,0) as rate,isnull(poscode,'') as poscode,isnull(billdetails,'') as billdetails,cast(convert(varchar(11),kotdate,106) as datetime) as kotdate,isnull(itemdesc,'') as itemdesc,SUM(isnull(amount,0)) AS AMOUNT,SUM(isnull(vat,0)) as vat,SUM(isnull(service_tax,0)) as service_tax,SUM(isnull(service_charge,0)) as service_charge,m.mcode,m.mname as posdesc from member_consumption_dettab t,membermaster m where t.mcode=m.mcode and M.mcode between '" & txt_mcode.Text & "' and '" & txt_Tomcode.Text & "' AND MONTH(KOTDATE) = " & MONTH2 & ""
                    sqlstring = sqlstring & " group by  rate,billdetails,cast(convert(varchar(11),kotdate,106) as datetime),itemdesc,poscode,m.mcode,m.mname order by M.MCODE"

                    sqlstring1 = "select t.mcode,ISNULL(t.billno ,'') as billno,  ISNULL(t.billdate ,'') as billdate, ISNULL(t.Instrumentno ,'') as Instrumentno , ISNULL(t.InstrumentType  ,'') as InstrumentType,ISNULL(t.Cramount  ,0) as Cramount,ISNULL(t.Dramount   ,0) as Dramount"
                    sqlstring1 = sqlstring1 & ",ISNULL(t.locdesc,'') as locdesc,ISNULL(t.Description ,'') as Description,ISNULL(t.CREDITDEBIT ,'') as CREDITDEBIT from View_Recipt_DetCCL t,membermaster m where t.mcode=m.mcode and M.mcode between '" & txt_mcode.Text & "' and '" & txt_Tomcode.Text & "' AND MONTH(billdate) = " & MONTH2 & "order by  CREDITDEBIT"

                Else
                    sqlstring = "Exec  PROC_MEMBER_CONSUMPTION_DET '" & month1 & "' "
                    gconnection.ExcuteStoreProcedure(sqlstring)

                    membertype = ""
                    If chk_Filter_Field.CheckedItems.Count > 0 Then
                        For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                            TYPE = Split(chk_Filter_Field.CheckedItems(i), ".")
                            membertype = membertype & "'" & TYPE(0) & "', "
                        Next
                        membertype = Mid(membertype, 1, Len(membertype) - 2)
                    Else
                        MessageBox.Show("Select the Category(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                    'sqlstring = "select ISNULL(POSCODE,'') AS POSCODE,isnull(qty,0) as qty,isnull(rate,0) as rate,isnull(billdetails,'') as billdetails,cast(convert(varchar(11),kotdate,106) as datetime) as kotdate,isnull(itemdesc,'') as itemdesc,SUM(isnull(amount,0)) AS AMOUNT,SUM(isnull(vat,0)) as vat,SUM(isnull(service_tax,0)) as service_tax,SUM(isnull(service_charge,0)) as service_charge,m.mcode,m.mname as posdesc from member_consumption_det t,membermaster m where t.mcode=m.mcode AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") AND MONTH(KOTDATE) = " & MONTH2 & ""
                    'sqlstring = sqlstring & " group by qty,rate,billdetails,cast(convert(varchar(11),kotdate,106) as datetime),itemdesc,poscode,m.mcode,m.mname"
                    'sqlstring = "select ISNULL(POSCODE,'') AS POSCODE,isnull(qty,0) as qty,isnull(rate,0) as rate,isnull(billdetails,'') as billdetails,cast(convert(varchar(11),kotdate,106) as datetime) as kotdate,isnull(itemdesc,'') as itemdesc,SUM(isnull(amount,0)) AS AMOUNT,SUM(isnull(vat,0)) as vat,SUM(isnull(service_tax,0)) as service_tax,SUM(isnull(service_charge,0)) as service_charge,m.mcode,m.mname as posdesc from member_consumption_det t,membermaster m where t.mcode=m.mcode AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") AND MONTH(KOTDATE) = " & MONTH2 & ""
                    'sqlstring = sqlstring & " group by qty,rate,billdetails,cast(convert(varchar(11),kotdate,106) as datetime),itemdesc,poscode,m.mcode,m.mname order by SUBSTRING(M.MCODE,1,2),LEN(M.MCODE),M.MCODE"
                    sqlstring = "select ISNULL(POSCODE,'') AS POSCODE,sum(isnull(qty,0)) as qty,isnull(rate,0) as rate,isnull(billdetails,'') as billdetails,cast(convert(varchar(11),kotdate,106) as datetime) as kotdate,isnull(itemdesc,'') as itemdesc,SUM(isnull(amount,0)) AS AMOUNT,SUM(isnull(vat,0)) as vat,SUM(isnull(service_tax,0)) as service_tax,SUM(isnull(service_charge,0)) as service_charge,m.mcode,m.mname as posdesc from member_consumption_dettab t,membermaster m where t.mcode=m.mcode AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") AND MONTH(KOTDATE) = " & MONTH2 & ""
                    sqlstring = sqlstring & " group by  rate,billdetails,cast(convert(varchar(11),kotdate,106) as datetime),itemdesc,poscode,m.mcode,m.mname order by SUBSTRING(M.MCODE,1,2),LEN(M.MCODE),M.MCODE"
                    sqlstring1 = "select t.mcode,ISNULL(t.billno,'') as billno,  ISNULL(t.billdate,'') as billdate, ISNULL(t.Instrumentno,'') as Instrumentno , ISNULL(t.InstrumentType,'') as InstrumentType,ISNULL(t.Cramount,0) as Cramount,ISNULL(t.Dramount,0) as Dramount"
                    sqlstring1 = sqlstring1 & ",ISNULL(t.locdesc,'') as locdesc,ISNULL(t.Description ,'') as Description,ISNULL(t.CREDITDEBIT ,'') as CREDITDEBIT from View_Recipt_DetCCL t,membermaster m where t.mcode=m.mcode AND LTRIM(RTRIM(m.membertypecode)) IN (" & membertype & ")  AND MONTH(billdate) = " & MONTH2 & "order by  CREDITDEBIT"
                End If

                Call Viewer.GetDetails1(sqlstring, "member_consumption_det", r)
                Call Viewer.GetDetails2(sqlstring1, "View_Recipt_DetCCL", r)
                Dim txtobj15 As TextObject
                Dim txtobj19 As TextObject
                Dim txtobj20 As TextObject
                Dim TXTOBJ21 As TextObject
                Dim TXTOBJ22 As TextObject
                Dim TXTOBJ23 As TextObject
                Dim TXTOBJ24 As TextObject
              
                txtobj19 = r.ReportDefinition.ReportObjects("Text27")
                txtobj19.Text = MONTH & " " & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))

                TXTOBJ21 = r.ReportDefinition.ReportObjects("TEXT2")
                TXTOBJ21.Text = "Bill Detail List Consumption In Regular PERIOD : " & BILDT3 & "-" & BILLDT4
                Dim convdate As Date
                txtobj20 = r.ReportDefinition.ReportObjects("Text31")
                convdate = noofdays & "-" & IIf(month1 > 9, Str(month1), "0" & month1) & "-" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))
                txtobj20.Text = Format(convdate, "dd MMM yyyy")

                txtobj15 = r.ReportDefinition.ReportObjects("Text29")
                txtobj15.Text = "/" & MONTH & "/" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4)) & "/Regular"
                If bildt >= "01/jul/2017" Then
                    TXTOBJ22 = r.ReportDefinition.ReportObjects("Text20")
                    TXTOBJ22.Text = "CGST"
                    TXTOBJ23 = r.ReportDefinition.ReportObjects("Text19")
                    TXTOBJ23.Text = "SGST"
                    TXTOBJ24 = r.ReportDefinition.ReportObjects("Text5")
                    TXTOBJ24.Text = "CESS"
                End If
                '  Dim txtobj19 As TextObject

                ' txtobj19 = r.ReportDefinition.ReportObjects("Text41")

                'txtobj19.Text = "01/" & IIf(month1 > 9, Str(month1), "0" & month1) & "/" & IIf(month1 > 3, Mid(gFinancalyearStart,1,4), Mid(gFinancialyearEnd,1, 4))
                ' txtobj19.Text = "Bill Details List Consumption Period: Billing Period " & bildt & " To  " & bildt1
                'txtobj18.Text = noofdays & "/" & IIf(month1 > 9, Str(month1), "0" & month1) & "/" & IIf(month1 > 3, Mid(gFinancalyearStart,1,4), Mid(gFinancialyearEnd, 7, 4))
                'txtobj20.Text = " You are requested to pay the due amount on or before :" & Format(DTPduedate.Value, "dd/MM/yyyy")
                Viewer.Show()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Xml()
        Dim XMLSTR, tempstr, tempstr1, tempstr2 As String
        Randomize()
        apppath = Application.StartupPath
        Dim cmdText As String
        Dim I, count As Integer
        Dim dr, dr1, dr2, dr4 As DataRow
        Dim duedate, membertype, TYPE(0), month2 As String
        Dim bLeapYear As Boolean
        bLeapYear = Date.IsLeapYear(gFinancialyearEnd)


        If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then vOutfile = Mid(gFinancalyearStart, 1, 4) & "04" : month1 = 4 : noofdays = 30 : bildt = "01/apr/" & Mid(gFinancalyearStart, 1, 4)
        If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then vOutfile = Mid(gFinancalyearStart, 1, 4) & "05" : month1 = 5 : noofdays = 31 : bildt = "01/may/" & Mid(gFinancalyearStart, 1, 4)
        If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then vOutfile = Mid(gFinancalyearStart, 1, 4) & "06" : month1 = 6 : noofdays = 30 : bildt = "01/jun/" & Mid(gFinancalyearStart, 1, 4)
        If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then vOutfile = Mid(gFinancalyearStart, 1, 4) & "07" : month1 = 7 : noofdays = 31 : bildt = "01/jul/" & Mid(gFinancalyearStart, 1, 4)
        If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then vOutfile = Mid(gFinancalyearStart, 1, 4) & "08" : month1 = 8 : noofdays = 31 : bildt = "01/aug/" & Mid(gFinancalyearStart, 1, 4)
        If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then vOutfile = Mid(gFinancalyearStart, 1, 4) & "09" : month1 = 9 : noofdays = 30 : bildt = "01/sep/" & Mid(gFinancalyearStart, 1, 4)
        If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then vOutfile = Mid(gFinancalyearStart, 1, 4) & "10" : month1 = 10 : noofdays = 31 : bildt = "01/oct/" & Mid(gFinancalyearStart, 1, 4)
        If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then vOutfile = Mid(gFinancalyearStart, 1, 4) & "11" : month1 = 11 : noofdays = 30 : bildt = "01/nov/" & Mid(gFinancalyearStart, 1, 4)
        If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then vOutfile = Mid(gFinancalyearStart, 1, 4) & "12" : month1 = 12 : noofdays = 31 : bildt = "01/dec/" & Mid(gFinancalyearStart, 1, 4)
        If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then vOutfile = Mid(gFinancialyearEnd, 1, 4) & "01" : month1 = 1 : noofdays = 31 : bildt = "01/jan/" & Mid(gFinancialyearEnd, 1, 4)
        ' If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then vOutfile = Mid(gFinancialyearEnd, 1, 4) & "02" : month1 = 2 : noofdays = 28 : bildt = "01/feb/" & Mid(gFinancialyearEnd, 1, 4)
        If bLeapYear = True Then
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then vOutfile = Mid(gFinancialyearEnd, 1, 4) & "02" : month1 = 2 : noofdays = 29 : bildt = "01/feb/" & Mid(gFinancialyearEnd, 1, 4)
        Else
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then vOutfile = Mid(gFinancialyearEnd, 1, 4) & "02" : month1 = 2 : noofdays = 28 : bildt = "01/feb/" & Mid(gFinancialyearEnd, 1, 4)
        End If
        If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then vOutfile = Mid(gFinancialyearEnd, 1, 4) & "03" : month1 = 3 : noofdays = 31 : bildt = "01/mar/" & Mid(gFinancialyearEnd, 1, 4)

        VFilePath = apppath & "\Reports\" & vOutfile & ".xml"

        If File.Exists(VFilePath) = True Then
            File.Delete(VFilePath)
        End If

        'for new one

        membertype = ""

        If chk_Filter_Field.CheckedItems.Count > 0 Then
            For I = 0 To chk_Filter_Field.CheckedItems.Count - 1
                TYPE = Split(chk_Filter_Field.CheckedItems(I), ".")
                membertype = membertype & "'" & TYPE(0) & "', "
            Next
            membertype = Mid(membertype, 1, Len(membertype) - 2)
        Else
            MessageBox.Show("Select the Category(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            chk_Filter_Field.Focus()
            Exit Sub
        End If

        If Trim(txt_mcode.Text) <> "" Then
            'left outer joIn memberbill mb on m.mcode=mb.mcode
            sqlstring = " SELECT ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,ISNULL(B.CONTCELL,'') AS contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(ADJUSTMENT,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE,ISNULL(BILLDATE,'') AS BILLDATE FROM bengal_monthbill b, membermaster m where b.mcode=m.mcode and b.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") ORDER BY b.MCODE "

        Else
            sqlstring = " SELECT ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,ISNULL(B.CONTCELL,'') AS contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(ADJUSTMENT,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE FROM bengal_monthbill b, membermaster m where b.mcode=m.mcode and LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") and month(b.billdate)=" & month1 & "  AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") ORDER BY b.MCODE "

            ' sqlstring = " SELECT ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(ADJUSTMENT,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE,ISNULL(BILLDATE,'') AS BILLDATE FROM bengal_monthbill b, membermaster m where b.mcode=m.mcode and b.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") ORDER BY b.MCODE "

            'sql = "select isnull(billdetails,'') as billdetails,ISNULL(POSDESC,'') AS POSDESC,isnull(kotdate,'') as kotdate,isnull(mcode,'')as mcode,isnull(amount,0) as amount,isnull(vat,0) as vat,isnull(service_tax,0) as service_tax,isnull(service_charge,0) as service_charge from member_consumption where MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(kotdate)= " & month1 & "  ORDER BY MCODE "

        End If

        Filewrite = File.AppendText(VFilePath)
        printfile = VFilePath

        'new one
        'begin

        'end
        ADDRESS1 = "241,A.J.C.Bose Road"
        Dim Address2 As String
        Address2 = "Kolkata"
        gconnection.getDataSet(sqlstring, "MEMBERMASTER")

        If gdataset.Tables("MEMBERMASTER").Rows.Count > 0 Then
            count = count + 1
            XMLSTR = "<?xml version=" & Chr(34) & "1.0" & Chr(34) & " encoding=" & Chr(34) & "UTF-8" & Chr(34) & "?>" + Environment.NewLine

            XMLSTR = XMLSTR & " <bill>" + Environment.NewLine
            XMLSTR = XMLSTR & " <clubname>" & Replace(gcompanyname, "&", " AND ") & "</clubname>" + Environment.NewLine
            XMLSTR = XMLSTR & " <address>" & Replace(ADDRESS1, "&", " AND ") & "</address>" + Environment.NewLine
            '  If Address2 <> "" Then
            'XMLSTR = XMLSTR & " <city>" & Replace(Address2, "&", " AND ") & "</city>" + Environment.NewLine
            ' Else '
            'XMLSTR = XMLSTR & " <city>NIL</city>" + Environment.NewLine
            XMLSTR = XMLSTR & " <city>" & Replace(Address2, "&", " AND ") & "</city>" + Environment.NewLine
            ' End If
            tempstr = "BILL AND STATEMENT  OF ACCOUNT FOR THE   MONTH " & CbxMonth.Text & " - " & Year(bildt)
            'XMLSTR = XMLSTR & " <title>" & tempstr & "</title>" + Environment.NewLine

            Dim NetPayable As Double
            For Each dr In gdataset.Tables("MEMBERMASTER").Rows
                XMLSTR = XMLSTR & " <member>" + Environment.NewLine
                XMLSTR = XMLSTR & " <membernumber>" & Trim(Mid(dr("MCODE"), 1, 8)) & "</membernumber>" + Environment.NewLine
                tempstr = dr("MCODE") & "/" & Format(CDate(bildt), "MMM") & "/" & Format(CDate(bildt), "yyyy")

                'tempstr = Format(dr("BILLNUMBER"), "0")

                XMLSTR = XMLSTR & " <billnumber>Bill No. : " & tempstr & "</billnumber>" + Environment.NewLine
                XMLSTR = XMLSTR & " <membername>" & Replace(Trim(Mid(dr("MNAME"), 1, 30)), "&", " AND ") & "</membername>" + Environment.NewLine
                XMLSTR = XMLSTR & " <billdate>Run date : " & Format(Now, "dd/MM/yyyy") & "</billdate>" + Environment.NewLine
                XMLSTR = XMLSTR & " <memberaddress1>" & Replace(Trim(Mid(dr("CONTADD1"), 1, 50)), "&", " AND ") & "</memberaddress1>" + Environment.NewLine
                XMLSTR = XMLSTR & " <memberaddress2>" & Replace(Trim(Mid(dr("CONTADD2"), 1, 50)), "&", " AND ") & "</memberaddress2>" + Environment.NewLine
                XMLSTR = XMLSTR & " <memberaddress3>" & Replace(Trim(Mid(dr("CONTADD3"), 1, 50)), "&", " AND ") & "</memberaddress3>" + Environment.NewLine
                XMLSTR = XMLSTR & " <membercity>" & Replace(Trim(Mid(dr("CONTCITY"), 1, 50)), "&", " AND ") & "</membercity>" + Environment.NewLine
                XMLSTR = XMLSTR & " <memberpostalcode>" & Replace(Trim(Mid(dr("CONTPIN"), 1, 50)), "&", " AND ") & "</memberpostalcode>" + Environment.NewLine
                XMLSTR = XMLSTR & " <memberphonenumber>" & Replace(Trim(Mid(dr("CONTcell"), 1, 50)), "&", " AND ") & "</memberphonenumber>" + Environment.NewLine
                XMLSTR = XMLSTR & " <preface>STATEMENT OF ACCOUNTS AND BILL FOR THE MONTH OF " & CbxMonth.Text & " - " & Year(bildt) & "</preface>" + Environment.NewLine

                tempstr1 = "01/" & IIf(month1 > 9, month1, "0" & month1) & "/" & IIf(month1 > 3, Mid(gFinancalyearStart, 1, 4), Mid(gFinancialyearEnd, 1, 4))
                If gUserCategory = "S" Then
                    tempstr = DateAdd(DateInterval.Month, 1, CDate(bildt))
                    tempstr2 = noofdays & "/" & IIf(month1 > 9, month1, "0" & month1) & "/" & IIf(month1 > 3, Mid(gFinancalyearStart, 1, 4), Mid(gFinancialyearEnd, 1, 4))
                Else
                    tempstr = DateAdd(DateInterval.Month, 1, CDate(bildt))
                    tempstr2 = noofdays & "/" & IIf(month1 > 9, month1, "0" & month1) & "/" & IIf(month1 > 3, Mid(gFinancalyearStart, 1, 4), Mid(gFinancialyearEnd, 1, 4))
                End If

                Dim Debittotal, Credittotal, Tax As Double


                XMLSTR = XMLSTR & " <columnh1>Particulars</columnh1>" + Environment.NewLine
                XMLSTR = XMLSTR & " <columnh2>Debit</columnh2>" + Environment.NewLine
                XMLSTR = XMLSTR & " <columnh3>Receivables</columnh3>" + Environment.NewLine
                XMLSTR = XMLSTR & " <columnh4>Credit</columnh4>" + Environment.NewLine

                XMLSTR = XMLSTR & " <line>" + Environment.NewLine
                If dr("LAST_BALALNCE") >= 0 Then
                    XMLSTR = XMLSTR & " <particular1>Opening Balance</particular1>" + Environment.NewLine
                    XMLSTR = XMLSTR & " <amount1>" & Trim(Format(dr("LAST_BALALNCE"), "0.00")) & "</amount1>" + Environment.NewLine
                    Debittotal = Debittotal + dr("LAST_BALALNCE")
                Else
                    XMLSTR = XMLSTR & " <particular2>Opening Balance</particular2>" + Environment.NewLine
                    XMLSTR = XMLSTR & " <amount2>" & Trim(Format(dr("LAST_BALALNCE") * -1, "0.00")) & "</amount2>" + Environment.NewLine
                    Credittotal = Credittotal + dr("LAST_BALALNCE")
                End If

                NetPayable = dr("LAST_BALALNCE")
                XMLSTR = XMLSTR & " </line>" + Environment.NewLine
                Dim postotal As Double
                postotal = 0
                ssql2 = "SELECT ISNULL(POSDESC,'') AS POSDESC,ISNULL(MCODE,'') AS MCODE,SUM(AMOUNT)+SUM(VAT)+SUM(SERVICE_TAX) + SUM(SERVICE_CHARGE) AS AMOUNT FROM MEMBER_CONSUMPTION1 where MCODE='" & dr("mcode") & "'  and month(kotdate)= " & month1 & "  GROUP BY POSDESC,mcode "
                'ssql2 = " SELECT SLCODE,UPPER(HEADDESC) AS HEADDESC,SUM(DRAMOUNT) AS DRAMOUNT,SUM(CRAMOUNT) AS CRAMOUNT FROM tmp_View_Pos_Summary WHERE slcode='" & dr("mcode") & "' GROUP BY SLCODE,HEADDESC ORDER BY SLCODE "
                gconnection.getDataSet(ssql2, "View_Pos_Summary")
                Dim cc As Integer
                cc = 0
                If gdataset.Tables("View_Pos_Summary").Rows.Count > 0 Then
                    For Each dr1 In gdataset.Tables("View_Pos_Summary").Rows
                        cc = cc + 1
                        If dr1("AMOUNT") <> 0 Then
                            XMLSTR = XMLSTR & " <line>" + Environment.NewLine
                            If Trim(dr1("POSDESC")) <> "" Then
                                XMLSTR = XMLSTR & " <particular1>" & Replace(Trim(dr1("POSDESC")), "&", "AND") & "</particular1>" + Environment.NewLine
                            Else
                                XMLSTR = XMLSTR & " <particular1>On Account</particular1>" + Environment.NewLine
                            End If
                            XMLSTR = XMLSTR & " <amount1>" & Trim(Format(dr1("AMOUNT"), "0.00")) & "</amount1>" + Environment.NewLine

                            XMLSTR = XMLSTR & " </line>" + Environment.NewLine
                        End If

                        postotal = postotal + dr1("AMOUNT")

                        'Credittotal = Credittotal + dr1("CRAMOUNT")
                        'Tax = dr1("TAX") + dr1("VAT") + dr1("TIPS")

                    Next
                End If
                postotal = Math.Round(postotal, 0)
                NetPayable = NetPayable + postotal
                Debittotal = Debittotal + postotal
                sqlstring1 = "select slcode,locdesc,sum(dramount) as dramount,sum(cramount) as cramount "
                sqlstring1 = sqlstring1 & "FROM View_Rec_Det WHERE slcode='" & dr("mcode") & "' AND MONTH(BILLDATE) = " & month1 & " GROUP BY SLCODE,locdesc ORDER BY SLCODE"
                gconnection.getDataSet(sqlstring1, "View_Rec_Det")
                cc = 0
                If gdataset.Tables("View_Rec_Det").Rows.Count > 0 Then
                    For Each dr4 In gdataset.Tables("View_Rec_Det").Rows
                        cc = cc + 1
                        'locdesc,sum(dramount) as dramount,sum(cramount) as cramount 
                        If dr4("cramount") <> 0 Then
                            XMLSTR = XMLSTR & " <line>" + Environment.NewLine
                            If Trim(dr4("locdesc")) <> "" Then
                                XMLSTR = XMLSTR & " <particular2>" & Replace(Trim(dr4("locdesc")), "&", "AND") & "</particular2>" + Environment.NewLine
                            Else
                                XMLSTR = XMLSTR & " <particular2>On Account</particular2>" + Environment.NewLine
                            End If
                            XMLSTR = XMLSTR & " <amount2>" & Trim(Format(dr4("cramount"), "0.00")) & "</amount2>" + Environment.NewLine
                            XMLSTR = XMLSTR & " </line>" + Environment.NewLine
                        End If


                        If dr4("Dramount") <> 0 Then
                            XMLSTR = XMLSTR & " <line>" + Environment.NewLine
                            If Trim(dr4("locdesc")) <> "" Then
                                XMLSTR = XMLSTR & " <particular1>" & Replace(Trim(dr4("locdesc")), "&", "AND") & "</particular1>" + Environment.NewLine
                            Else
                                XMLSTR = XMLSTR & " <particular1>On Account</particular1>" + Environment.NewLine
                            End If
                            XMLSTR = XMLSTR & " <amount1>" & Trim(Format(dr4("Dramount"), "0.00")) & "</amount1>" + Environment.NewLine
                            XMLSTR = XMLSTR & " </line>" + Environment.NewLine
                        End If

                        Credittotal = Credittotal + dr4("CRAMOUNT")
                        Debittotal = Debittotal + dr4("DRAMOUNT")
                        NetPayable = NetPayable + dr4("DRAMOUNT") - dr4("CRAMOUNT")

                    Next
                End If

                'MAHINDER

                'sqlstring1 = "select slcode,'OTHERS' AS locdesc,sum(dramount) as dramount,sum(cramount) as cramount "
                'sqlstring1 = sqlstring1 & "FROM tmp_View_drcr_Det WHERE slcode='" & dr("mcode") & "' GROUP BY SLCODE ORDER BY SLCODE"
                'gconnection.getDataSet(sqlstring1, "View_drcr_Det")
                'cc = 0
                'If gdataset.Tables("View_drcr_Det").Rows.Count > 0 Then
                '    For Each dr4 In gdataset.Tables("View_drcr_Det").Rows
                '        cc = cc + 1
                '        'locdesc,sum(dramount) as dramount,sum(cramount) as cramount 
                '        If dr4("cramount") <> 0 Then
                '            XMLSTR = XMLSTR & " <line>" + Environment.NewLine
                '            If Trim(dr4("locdesc")) <> "" Then
                '                XMLSTR = XMLSTR & " <particular2>" & Replace(Trim(dr4("locdesc")), "&", "AND") & "</particular2>" + Environment.NewLine
                '            Else
                '                XMLSTR = XMLSTR & " <particular2>On Account</particular2>" + Environment.NewLine
                '            End If
                '            XMLSTR = XMLSTR & " <amount2>" & Trim(Format(dr4("cramount"), "0.00")) & "</amount2>" + Environment.NewLine
                '            XMLSTR = XMLSTR & " </line>" + Environment.NewLine
                '        End If


                '        If dr4("Dramount") <> 0 Then
                '            XMLSTR = XMLSTR & " <line>" + Environment.NewLine
                '            If Trim(dr4("locdesc")) <> "" Then
                '                XMLSTR = XMLSTR & " <particular1>" & Replace(Trim(dr4("locdesc")), "&", "AND") & "</particular1>" + Environment.NewLine
                '            Else
                '                XMLSTR = XMLSTR & " <particular1>On Account</particular1>" + Environment.NewLine
                '            End If
                '            XMLSTR = XMLSTR & " <amount1>" & Trim(Format(dr4("Dramount"), "0.00")) & "</amount1>" + Environment.NewLine
                '            XMLSTR = XMLSTR & " </line>" + Environment.NewLine
                '        End If

                '        Credittotal = Credittotal + dr4("CRAMOUNT")
                '        Debittotal = Debittotal + dr4("DRAMOUNT")
                '        NetPayable = NetPayable + dr4("DRAMOUNT") - dr4("CRAMOUNT")

                '    Next
                'End If


                ' XMLSTR = XMLSTR & " <tax>" & Trim(Format(dr1("TAX"), "0.00")) & "</tax>" + Environment.NewLine
                'XMLSTR = XMLSTR & " <vat>" & Trim(Format(dr1("VAT"), "0.00")) & "</vat>" + Environment.NewLine
                'XMLSTR = XMLSTR & " <tips>" & Trim(Format(dr1("TIPS"), "0.00")) & "</tips>" + Environment.NewLine

                'XMLSTR = XMLSTR & " <line>" + Environment.NewLine
                'XMLSTR = XMLSTR & " <particular1>Tax </particular1>" + Environment.NewLine
                'XMLSTR = XMLSTR & " <amount1>" & Trim(Format(Tax, "0.00")) & "</amount1>" + Environment.NewLine
                'XMLSTR = XMLSTR & " </line>" + Environment.NewLine
                XMLSTR = XMLSTR & " <line>" + Environment.NewLine
                XMLSTR = XMLSTR & " <particular1>Total Debit</particular1>" + Environment.NewLine
                XMLSTR = XMLSTR & " <amount1>" & Trim(Format(Debittotal, "0.00")) & "</amount1>" + Environment.NewLine

                XMLSTR = XMLSTR & " <particular2>Total Credit</particular2>" + Environment.NewLine
                XMLSTR = XMLSTR & " <amount2>" & Trim(Format(Credittotal, "0.00")) & "</amount2>" + Environment.NewLine

                XMLSTR = XMLSTR & " </line>" + Environment.NewLine

                XMLSTR = XMLSTR & " <line>" + Environment.NewLine
                If NetPayable >= 0 Then
                    XMLSTR = XMLSTR & " <particular1>Amount to be Received</particular1>" + Environment.NewLine
                    XMLSTR = XMLSTR & " <amount1>" & Trim(Format(NetPayable, "0.00")) & "</amount1>" + Environment.NewLine
                Else
                    XMLSTR = XMLSTR & " <particular2>Excess paid Amount</particular2>" + Environment.NewLine
                    XMLSTR = XMLSTR & " <amount2>" & Trim(Format(NetPayable * -1, "0.00")) & "</amount2>" + Environment.NewLine
                End If
                NetPayable = 0
                Debittotal = 0
                Credittotal = 0
                Tax = 0
                XMLSTR = XMLSTR & " </line>" + Environment.NewLine

                XMLSTR = XMLSTR & "  <note>Hereafter no reminders will be sent for payment of monthly/Arrears bills.</note>" + Environment.NewLine
                XMLSTR = XMLSTR & "  </member>" + Environment.NewLine
                Filewrite.WriteLine(XMLSTR)
                XMLSTR = ""
            Next
            XMLSTR = XMLSTR & "  </bill>" + Environment.NewLine
            Filewrite.WriteLine(XMLSTR)
        End If
        MessageBox.Show("Xml generated Successfully")
        '                Filewrite.WriteLine("over")
        Filewrite.Close()
        If GPRINT = False Then
            OpenTextFileXML(vOutfile)
        Else
            PrintTextFile(vOutfile)
        End If
        Exit Sub
    End Sub
    Private Sub GETSUMMARY_PREVIOUSbill()
        Try
            Dim cmdText, billdt2, BILDT4, BILDT5 As String
            Dim duedate, membertype, TYPE(0), month, sql, sqlstrinG, sqlstrinG4, month2 As String
            Dim opl, i As Integer
            Dim BILDATE As Date
            Dim bLeapYear As Boolean
            bLeapYear = Date.IsLeapYear(gFinancialyearEnd)

            Call Validation()
            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : month = "APR" : noofdays = 30 : bildt = "01/apr/" & gFinancalyearStart : month2 = "04" : billdt2 = "30/apr/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : month = "MAY" : noofdays = 31 : bildt = "01/may/" & gFinancalyearStart : month2 = "05" : billdt2 = "31/may/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : month = "JUN" : noofdays = 30 : bildt = "01/jun/" & gFinancalyearStart : month2 = "06" : billdt2 = "30/jun/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : month = "JUL" : noofdays = 31 : bildt = "01/jul/" & gFinancalyearStart : month2 = "07" : billdt2 = "31/jul/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : month = "AUG" : noofdays = 31 : bildt = "01/aug/" & gFinancalyearStart : month2 = "08" : billdt2 = "31/aug/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : month = "SEP" : noofdays = 30 : bildt = "01/sep/" & gFinancalyearStart : month2 = "09" : billdt2 = "30/sep/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : month = "OCT" : noofdays = 31 : bildt = "01/oct/" & gFinancalyearStart : month2 = "10" : billdt2 = "31/oct/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : month = "NOV" : noofdays = 30 : bildt = "01/nov/" & gFinancalyearStart : month2 = "11" : billdt2 = "30/nov/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : month = "DEC" : noofdays = 31 : bildt = "01/dec/" & gFinancalyearStart : month2 = "12" : billdt2 = "31/dec/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : month = "JAN" : noofdays = 31 : bildt = "01/jan/" & gFinancialyearEnd : month2 = "01" : billdt2 = "31/jan/" & gFinancialyearEnd
            'If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : month = "FEB" : noofdays = 28 : bildt = "01/feb/" & gFinancialyearEnd : month2 = "02" : billdt2 = "28/feb/" & gFinancialyearEnd
            If bLeapYear = True Then
                If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : month = "FEB" : noofdays = 29 : bildt = "01/feb/" & gFinancialyearEnd : month2 = "02" : billdt2 = "29/feb/" & gFinancialyearEnd
            Else
                If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : month = "FEB" : noofdays = 28 : bildt = "01/feb/" & gFinancialyearEnd : month2 = "02" : billdt2 = "28/feb/" & gFinancialyearEnd
            End If
            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : month = "MAR" : noofdays = 31 : bildt = "01/mar/" & gFinancialyearEnd : month2 = "03" : billdt2 = "31/mar/" & gFinancialyearEnd
            sqlstrinG = "SELECT * FROM JOURNALENTRY WHERE VOUCHERTYPE='MBILL' AND ISNULL(VOID,'')<>'Y' AND MONTH(VOUCHERDATE)='" & month2 & "'"
            gconnection.getDataSet(sqlstrinG, "member")

            If gdataset.Tables("member").Rows.Count = 0 Then
                'MessageBox.Show("Month Bill is Not processed for this month")
                'Exit Sub
            End If
            BILDATE = CDate(billdt2)
            If DTPduedate.Value < BILDATE Then
                MessageBox.Show("Bill Date should be greater than month bill date")
                Exit Sub
            End If

            'sqlstrinG = "exec BILLDATE_OUT '" & Format(DTPduedate.Value, "dd/MMM/yyyy") & "','" & Format(DTPduedate.Value, "dd/MMM/yyyy") & "','N','" & Format(BILDATE, "dd/MMM/yyyy") & "'"
            'gconnection.dataOperation(1, sqlstrinG, "BILL")
            Dim Viewer As New REPORTVIEWER
            ' Dim r As New billing
            Dim r As New CCLbilling
            'Dim r As New CALBil
            '  gSQLString1 = "EXEC MONTHBILL '" & billdt2 & "','" & bildt & "'"
            ' gconnection.dataOperation(6, gSQLString1, "monthbill")
            If Trim(txt_Tomcode.Text) <> "" And Trim(txt_Tomcode.Text) <> "" Then
                'sqlstrinG = " SELECT ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(ADJUSTMENT,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE FROM bengal_monthbill b, membermaster m where b.mcode=m.mcode and b.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") ORDER BY b.MCODE "
                'sqlstrinG = " SELECT ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(ADJUSTMENT,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE FROM bengal_monthbill b, membermaster m where b.mcode=m.mcode and b.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") order by SUBSTRING(M.MCODE,1,2),LEN(M.MCODE),M.MCODE "
                'sqlstrinG = " SELECT ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(ADJUSTMENT,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE FROM bengal_monthbill b, membermaster m where b.mcode=m.mcode and b.MCODE like '" & txt_mcode.Text & "%' and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") order by SUBSTRING(M.MCODE,1,2),LEN(M.MCODE),M.MCODE "
                ''Nitesh
                'sqlstrinG = " SELECT ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(ADJUSTMENT,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE FROM bengal_monthbill b, membermaster m where b.mcode=m.mcode and substring(B.MCODE,1,2)+substring('00000000000',1,11-(len(B.MCODE)))+substring(B.MCODE,3,len(B.MCODE)-2) between substring('" & txt_mcode.Text & "',1,2)+substring('00000000000',1,11-(len('" & txt_mcode.Text & "')))+substring('" & txt_mcode.Text & "',3,len('" & txt_mcode.Text & "')-2)  and  substring('" & txt_Tomcode.Text & "',1,2)+substring('00000000000',1,11-(len('" & txt_Tomcode.Text & "')))+substring('" & txt_Tomcode.Text & "',3,len('" & txt_Tomcode.Text & "')-2) and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") order by SUBSTRING(M.MCODE,1,2),LEN(M.MCODE),M.MCODE "
                sqlstrinG = "SELECT ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(t.vat,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(t.WBST,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE,ISNULL(BILLNO,'') AS OUTSTANDING FROM bengal_monthbill b, membermaster m,VW_PRWBST T  where b.mcode=m.mcode  and b.mcode =t.mcode and month(b.billdate)=t.kotdate  and substring(B.MCODE,1,2)+substring('00000000000',1,11-(len(B.MCODE)))+substring(B.MCODE,3,len(B.MCODE)-2) between substring('" & txt_mcode.Text & "',1,2)+substring('00000000000',1,11-(len('" & txt_mcode.Text & "')))+substring('" & txt_mcode.Text & "',3,len('" & txt_mcode.Text & "')-2)  and  substring('" & txt_Tomcode.Text & "',1,2)+substring('00000000000',1,11-(len('" & txt_Tomcode.Text & "')))+substring('" & txt_Tomcode.Text & "',3,len('" & txt_Tomcode.Text & "')-2) and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") order by SUBSTRING(M.MCODE,1,2),LEN(M.MCODE),M.MCODE "
                'sql = "select isnull(billdetails,'') as billdetails,ISNULL(POSDESC,'') AS POSDESC,isnull(kotdate,'') as kotdate,isnull(mcode,'')as mcode,isnull(amount,0) as amount,isnull(vat,0) as vat,isnull(service_tax,0) as service_tax,isnull(service_charge,0) as service_charge from member_consumption where MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(kotdate)= " & month1 & "  ORDER BY MCODE "
                'sql = "SELECT ISNULL(POSCODE,0) AS POSCODE,ISNULL(POSDESC,'') AS POSDESC,ISNULL(MCODE,'') AS MCODE,SUM(AMOUNT) AS AMOUNT,SUM(VAT) AS VAT,SUM(SERVICE_TAX) AS SERVICE_TAX,SUM(SERVICE_CHARGE) AS SERVICE_CHARGE FROM MEMBER_CONSUMPTION1 B where B.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(kotdate)= " & month1 & "  GROUP BY POSDESC,POSCODE,B.mcode  ORDER BY B.MCODE"
                'sql = "SELECT ISNULL(POSCODE,0) AS POSCODE,ISNULL(POSDESC,'') AS POSDESC,ISNULL(MCODE,'') AS MCODE,SUM(AMOUNT) AS AMOUNT,SUM(VAT) AS VAT,SUM(SERVICE_TAX) AS SERVICE_TAX,SUM(SERVICE_CHARGE) AS SERVICE_CHARGE FROM MEMBER_CONSUMPTION1 B where B.MCODE  like '" & txt_mcode.Text & "%' and month(kotdate)= " & month1 & "  GROUP BY POSDESC,POSCODE,B.mcode  ORDER BY B.MCODE"
                ''Nitesh
                sql = "SELECT ISNULL(POSCODE,0) AS POSCODE,ISNULL(POSDESC,'') AS POSDESC,ISNULL(MCODE,'') AS MCODE,SUM(AMOUNT) AS AMOUNT,SUM(VAT) AS VAT,SUM(SERVICE_TAX) AS SERVICE_TAX,SUM(SERVICE_CHARGE) AS SERVICE_CHARGE FROM MEMBER_CONSUMPTION1 B where B.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(kotdate)= " & month1 & "  GROUP BY POSDESC,POSCODE,B.mcode  ORDER BY B.MCODE"
                ' sql = "SELECT ISNULL(POSCODE,0) AS POSCODE,ISNULL(POSDESC,'') AS POSDESC,ISNULL(MCODE,'') AS MCODE,SUM(AMOUNT) AS AMOUNT,SUM(VAT) AS VAT,SUM(SERVICE_TAX) AS SERVICE_TAX,SUM(SERVICE_CHARGE) AS SERVICE_CHARGE FROM MEMBER_CONSUMPTION B where B.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(kotdate)= " & month1 & "  GROUP BY POSDESC,POSCODE,B.mcode  ORDER BY B.MCODE"
                '' '' '' '' '' ''sqlstring1 = " select slcode,locdesc,sum(dramount) as dramount,sum(cramount) as cramount "
                '' '' '' '' '' ''sqlstring1 = sqlstring1 & "FROM View_Rec_Det WHERE LTRIM(RTRIM(SLCODE)) BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(BILLDATE) = " & month1 & " GROUP BY SLCODE,locdesc "
                ' '' '' '' '' '' ''ssql2 = " SELECT SLCODE,UPPER(HEADDESC) AS HEADDESC,SUM(DRAMOUNT) AS DRAMOUNT,SUM(CRAMOUNT) AS CRAMOUNT FROM View_Pos_Summary WHERE MONTH(BILLDATE) = " & month1 & " AND SLCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' GROUP BY SLCODE,HEADDESC "
                '' '' '' '' '' ''ssql2 = "select SUM(amount)as amount,description,mcode from month_bill where (month(date)=" & month1 & " or date='1900-01-01') AND mCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' group by description,mcode,order_no order by mcode,order_no"
                '' '' '' '' '' ''sqlstring3 = " select slcode,locdesc,sum(dramount) as dramount,sum(cramount) as cramount "
                '' '' '' '' '' ''sqlstring3 = sqlstring3 & " FROM View_drcr_Det WHERE SLCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(BILLDATE) = " & month1 & " GROUP BY SLCODE,locdesc "
                'sqlstring2 = "select ClubLogo from accountsSetUp"
                'gconnection.getDataSet(sqlstring3, "View_DRCR_SUM")
                ' sqlstring3 = "select  mcode,SUM(BRAMOUNT) as BRAMOUNT   from View_DRCR_SUM where mCode ='S1031' and MONTH(billdate)=3 group by mcode"
                sqlstring3 = " select mcode,SUM(isnull(BRAMOUNT,0)) as BRAMOUNT,SUM(isnull(CRAMOUNT ,0)) as CRAMOUNT,SUM(isnull(CCRAMOUNT,0)) as CCRAMOUNT,SUM(isnull(CCNAMOUNT,0)) as CCNAMOUNT,SUM(isnull(CDNAMOUNT,0)) as CDNAMOUNT,SUM(isnull(billno,0)) as PARTYAMT  "
                sqlstring3 = sqlstring3 & " FROM View_DRCR_SUM WHERE mcode BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(BILLDATE) = " & month1 & " GROUP BY mcode "
                'SSQL4 = "select mcode,BILLDETAILS,WBST,KOTDATE ,TAXCODE ,TAXPERCENT   from VIEW_WBST WHERE mcode BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(KOTDATE) = " & month1 & ""
            Else
                ' membertype = ""
                If chk_Filter_Field.CheckedItems.Count > 0 Then
                    For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                        TYPE = Split(chk_Filter_Field.CheckedItems(i), ".")
                        membertype = membertype & "'" & TYPE(0) & "', "
                    Next
                    membertype = Mid(membertype, 1, Len(membertype) - 2)

                Else
                    MessageBox.Show("Select the Category(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    chk_Filter_Field.Focus()
                    Exit Sub
                End If
                'sqlstrinG = " SELECT ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(ADJUSTMENT,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE FROM bengal_monthbill b, membermaster m   where b.mcode=m.mcode and LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") ORDER BY b.MCODE "
                'sqlstrinG = " SELECT ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(ADJUSTMENT,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE FROM bengal_monthbill b, membermaster m   where b.mcode=m.mcode and LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") order by SUBSTRING(M.MCODE,1,2),LEN(M.MCODE),M.MCODE "
                sqlstrinG = "SELECT ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(t.vat,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(WBST,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE,ISNULL(BILLNO,'') AS OUTSTANDING FROM bengal_monthbill b, membermaster m ,VW_PRWBST T  where b.mcode=m.mcode and b.mcode=t.mcode and month(b.billdate)=t.kotdate  and LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") order by SUBSTRING(M.MCODE,1,2),LEN(M.MCODE),M.MCODE "
                sql = "select isnull(POSCODE,'') as POSCODE,ISNULL(POSDESC,'') AS POSDESC,isnull(M.mcode,'')as mcode,SUM(AMOUNT) AS AMOUNT,SUM(VAT) AS VAT,SUM(SERVICE_TAX) AS SERVICE_TAX,SUM(SERVICE_CHARGE) AS SERVICE_CHARGE from member_consumption1 a,membermaster m  where   month(kotdate)= " & month1 & " AND a.mcode=m.mcode and LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") group by poscode,posdesc,m.mcode ORDER BY m.MCODE "
                'sql = "select isnull(POSCODE,'') as POSCODE,ISNULL(POSDESC,'') AS POSDESC,isnull(M.mcode,'')as mcode,SUM(AMOUNT) AS AMOUNT,SUM(VAT) AS VAT,SUM(SERVICE_TAX) AS SERVICE_TAX,SUM(SERVICE_CHARGE) AS SERVICE_CHARGE from member_consumption a,membermaster m  where   month(kotdate)= " & month1 & " AND a.mcode=m.mcode and LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") group by poscode,posdesc,m.mcode ORDER BY m.MCODE "
                'sqlstrinG = " SELECT ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT FROM bengal_monthbill b inner join membermaster m   ON b.mcode=m.mcode and b.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "'  ORDER BY b.MCODE "


                ''''''''''''''''sqlstrinG = " SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M WHERE M.MCODE = O.SLCODE AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") AND O.BILLDATE < '" & bildt & "' AND  CURENTSTATUS IN('LIVE','ACTIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE  ORDER BY M.MCODE "
                ' '' '' ''sqlstring1 = " select a.slcode,a.locdesc,sum(a.dramount) as dramount,sum(a.cramount) as cramount "
                ' '' '' ''sqlstring1 = sqlstring1 & "FROM View_Rec_Det a ,membermaster b WHERE MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  Group by  a.SLCODE,a.locdesc "
                '' '' '' ''ssql2 = " SELECT SLCODE,UPPER(HEADDESC) AS HEADDESC,SUM(DRAMOUNT) AS DRAMOUNT,SUM(CRAMOUNT) AS CRAMOUNT FROM View_Pos_Summary WHERE MONTH(BILLDATE) = " & month1 & " AND SLCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' GROUP BY SLCODE,HEADDESC "
                ' '' '' ''ssql2 = "select SUM(A.amount)as amount,A.description,A.mcode from month_bill A,MEMBERMASTER B where (month(A.date)=" & month1 & " or A.date='1900-01-01') and b.membertypecode in(" & membertype & ") group by a.description,a.mcode,a.order_no order by a.mcode,a.order_no"
                ' '' '' ''sqlstring3 = " select a.slcode,a.locdesc,sum(a.dramount) as dramount,sum(a.cramount) as cramount "
                ' '' '' ''sqlstring3 = sqlstring3 & " FROM View_drcr_Det a,membermaster b WHERE a.slcode=b.mcode  AND MONTH(a.BILLDATE) = " & month1 & " and b.membertypecode in(" & membertype & ") GROUP BY a.SLCODE,a.locdesc "

                'sqlstring = "SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+' '+ ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M WHERE SUBSTRING(M.MCODE,1,8) = SUBSTRING(O.SLCODE,1,8)  AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ")  "
                'sqlstring = sqlstring & " AND O.BILLDATE <'" & bildt & "' AND  CURENTSTATUS in('ACTIVE','LIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE  ORDER BY M.MCODE"
                'ssql = " SELECT A.BILLNO,A.SLCODE AS SLCODE,upper(A.HEADDESC),SUM(A.AMOUNT) AS AMOUNT,A.BILLDATE FROM MAINCASHRECEIPT  A, MEMBERMASTER B "
                'ssql = ssql & " WHERE Month(BILLDATE) = " & month1
                'ssql = ssql & " AND B.membertypecode IN(" & membertype & ") AND A.SLCODE=B.MCODE "
                'ssql = ssql & " GROUP BY A.SLCODE,A.HEADDESC,A.BILLDATE,A.BILLNO "
                'sqlstring1 = " select a.SLCODE,sum(a.dramount) as dramount,sum(a.cramount) as cramount "
                'sqlstring1 = sqlstring1 & "  From View_Rec_Det a, MEMBERMASTER b WHERE MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  Group by  a.SLCODE"
                'ssql2 = " SELECT a.SLCODE,upper(a.HEADDESC) AS HEADDESC,SUM(a.DRAMOUNT) AS DRAMOUNT,SUM(a.CRAMOUNT) AS CRAMOUNT FROM View_Pos_Summary  a, MEMBERMASTER b WHERE  MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  Group by  a.SLcode,a.HEADDESC "
                'sqlstring2 = "select ClubLogo from accountsSetUp"
                'sqlstring3 = " select A.slcode,A.locdesc,sum(A.dramount) as dramount,sum(A.cramount) as cramount "
                'sqlstring3 = sqlstring3 & " FROM View_drcr_Det A,MEMBERMASTER B WHERE MONTH(BILLDATE) = " & month1 & " and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ") GROUP BY SLCODE,locdesc "
                sqlstring3 = " select a.mcode,SUM(isnull(BRAMOUNT,0)) as BRAMOUNT,SUM(isnull(CRAMOUNT ,0)) as CRAMOUNT,SUM(isnull(CCRAMOUNT,0)) as CCRAMOUNT,SUM(isnull(CCNAMOUNT,0)) as CCNAMOUNT,SUM(isnull(CDNAMOUNT,0)) as CDNAMOUNT,SUM(isnull(billno,0)) as PARTYAMT "
                sqlstring3 = sqlstring3 & " FROM View_DRCR_SUM A,MEMBERMASTER B WHERE MONTH(BILLDATE) = " & month1 & " and a.mcode=b.MCODE and b.membertypecode in(" & membertype & ") GROUP BY a.mcode"
                'SSQL4 = "select a.mcode,a.BILLDETAILS,a.WBST,a.KOTDATE ,a,TAXCODE ,a.TAXPERCENT   from VIEW_WBST  A,MEMBERMASTER B  WHERE MONTH(KOTDATE) = " & month1 & " and a.mcode=b.MCODE and b.membertypecode in(" & membertype & ") "

            End If
            Call Viewer.GetDetails1(sql, "member_consumption", r)
            Call Viewer.GetDetails1(sqlstrinG, "bengal_monthbill", r)
            Call Viewer.GetDetails2(sqlstring3, "View_DRCR_SUM", r)
            ' Call Viewer.GetDetails3(SSQL4, "VIEW_WBST", r)


            Dim name, add1, add2, add3, city, state, pin, cell As String

            'name = gdataset.Tables("bengal_monthbill").Rows(0).Item("mname")
            'add1 = gdataset.Tables("bengal_monthbill").Rows(0).Item("contadd1")
            'add2 = gdataset.Tables("bengal_monthbill").Rows(0).Item("contadd2")
            'add3 = gdataset.Tables("bengal_monthbill").Rows(0).Item("contadd3")
            'city = gdataset.Tables("bengal_monthbill").Rows(0).Item("contcity")
            'pin = gdataset.Tables("bengal_monthbill").Rows(0).Item("contpin")
            'cell = gdataset.Tables("bengal_monthbill").Rows(0).Item("contcell")


            'Call Viewer.GetDetails1(ssql2, "month_bill", r)
            'Call Viewer.GetDetails1(sqlstring1, "View_Rec_Det", r)
            'Call Viewer.GetDetails1(sqlstring3, "View_drcr_Det", r)
            'Call Viewer.GetDetails1(sqlstring2, "accountsSetUp", r)
            'Dim txtobj1 As TextObject
            'Dim txtobj As TextObject
            'Dim txtobj2 As TextObject
            Dim txtobj15 As TextObject
            Dim txtobj19 As TextObject
            Dim txtobj20 As TextObject

            'Dim txtobj48 As TextObject
            'txtobj48 = r.ReportDefinition.ReportObjects("Text48")
            'txtobj48.Text = txt_msg.Text

            Dim txtobj1 As TextObject
            Dim duedt As Date

            txtobj1 = r.ReportDefinition.ReportObjects("Text2")
            duedt = DTPduedate.Value
            txtobj1.Text = Format(duedt, "dd/MMM/yyyy")

            '" & Format(DTPduedate.Value, "dd/MMM/yyyy") & "'
            'txtobj19 = r.ReportDefinition.ReportObjects("Text20")
            'txtobj19.Text = month & " " & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))

            'Dim convdate As Date
            'txtobj20 = r.ReportDefinition.ReportObjects("Text24")
            'convdate = noofdays & "-" & IIf(month1 > 9, Str(month1), "0" & month1) & "-" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))
            'txtobj20.Text = Format(convdate, "dd MMM yyyy")

            'txtobj15 = r.ReportDefinition.ReportObjects("Text22")
            'txtobj15.Text = "/" & month & "/" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4)) & "/Regular"


            'txtobj19 = r.ReportDefinition.ReportObjects("Text31")
            'txtobj19.Text = month & " " & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))

            ''Dim convdate1 As Date
            'txtobj20 = r.ReportDefinition.ReportObjects("Text35")
            'convdate = noofdays & "-" & IIf(month1 > 9, Str(month1), "0" & month1) & "-" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))
            'txtobj20.Text = Format(convdate, "dd MMM yyyy")

            'txtobj15 = r.ReportDefinition.ReportObjects("Text33")
            'txtobj15.Text = "/" & month & "/" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4)) & "/Regular"

            'Dim txtobj18 As TextObject
            'txtobj18 = r.ReportDefinition.ReportObjects("Text5")
            ' txtobj18.Text = noofdays & "-" & IIf(month1 > 9, Str(month1), "0" & month1) & "-" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))


            'Dim txtobj1 As TextObject
            'Dim duedt As Date
            'txtobj1 = r.ReportDefinition.ReportObjects("Text27")
            'duedt = DTPduedate.Value
            'txtobj1.Text = Format(duedt, "dd.MM.yyyy")

            ' '' ''Dim txtobj1 As TextObject
            '' ''txtobj1 = r.ReportDefinition.ReportObjects("Text4")
            '' ''txtobj1.Text = name
            '' ''txtobj1 = r.ReportDefinition.ReportObjects("Text5")
            '' ''txtobj1.Text = add1
            '' ''txtobj1 = r.ReportDefinition.ReportObjects("Text6")
            '' ''txtobj1.Text = add2
            '' ''txtobj1 = r.ReportDefinition.ReportObjects("Text7")
            '' ''txtobj1.Text = add3
            '' ''txtobj1 = r.ReportDefinition.ReportObjects("Text8")
            '' ''txtobj1.Text = city & "  " & pin
            'txtobj1 = r.ReportDefinition.ReportObjects("Text9")
            'txtobj1.Text = UCase(cell)
            'txtobj15.Text = UCase(gUsername)
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub GETSUMMARY_PRINT_OTHERS()
        Try
            Dim cmdText, billdt2 As String
            Dim duedate, membertype, TYPE(0), month, sql, sqlstrinG, month2 As String
            Dim bLeapYear As Boolean
            bLeapYear = Date.IsLeapYear(gFinancialyearEnd)
            ' MessageBox.Show(bLeapYear)      

            Dim opl, i As Integer
            Call Validation()

            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : month = "APR" : noofdays = 30 : bildt = "01/apr/" & gFinancalyearStart : month2 = "04" : billdt2 = "30/apr/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : month = "MAY" : noofdays = 31 : bildt = "01/may/" & gFinancalyearStart : month2 = "05" : billdt2 = "31/may/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : month = "JUN" : noofdays = 30 : bildt = "01/jun/" & gFinancalyearStart : month2 = "06" : billdt2 = "30/jun/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : month = "JUL" : noofdays = 31 : bildt = "01/jul/" & gFinancalyearStart : month2 = "07" : billdt2 = "31/jul/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : month = "AUG" : noofdays = 31 : bildt = "01/aug/" & gFinancalyearStart : month2 = "08" : billdt2 = "31/aug/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : month = "SEP" : noofdays = 30 : bildt = "01/sep/" & gFinancalyearStart : month2 = "09" : billdt2 = "30/sep/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : month = "OCT" : noofdays = 31 : bildt = "01/oct/" & gFinancalyearStart : month2 = "10" : billdt2 = "31/oct/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : month = "NOV" : noofdays = 30 : bildt = "01/nov/" & gFinancalyearStart : month2 = "11" : billdt2 = "30/nov/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : month = "DEC" : noofdays = 31 : bildt = "01/dec/" & gFinancalyearStart : month2 = "12" : billdt2 = "31/dec/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : month = "JAN" : noofdays = 31 : bildt = "01/jan/" & gFinancialyearEnd : month2 = "01" : billdt2 = "31/jan/" & gFinancialyearEnd
            If bLeapYear = True Then
                If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : month = "FEB" : noofdays = 29 : bildt = "01/feb/" & gFinancialyearEnd : month2 = "02" : billdt2 = "29/feb/" & gFinancialyearEnd
            Else
                If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : month = "FEB" : noofdays = 28 : bildt = "01/feb/" & gFinancialyearEnd : month2 = "02" : billdt2 = "28/feb/" & gFinancialyearEnd
            End If
            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : month = "MAR" : noofdays = 31 : bildt = "01/mar/" & gFinancialyearEnd : month2 = "03" : billdt2 = "31/mar/" & gFinancialyearEnd
            sqlstrinG = "SELECT * FROM JOURNALENTRY WHERE VOUCHERTYPE='MBILL' AND ISNULL(VOID,'')<>'Y' AND MONTH(VOUCHERDATE)='" & month2 & "'"
            gconnection.getDataSet(sqlstrinG, "member")
            If gdataset.Tables("member").Rows.Count = 0 Then
                'MessageBox.Show("Month Bill is Not processed for this month")
                'Exit Sub
            End If
            sqlstrinG = "SELECT * FROM BENGAL_MONTHBILL WHERE CAST(CONVERT(VARCHAR(11),BILLDATE,106) AS DATETIME)='" & billdt2 & "' AND ISNULL(OUTSTANDING,'N')='Y'"
            gconnection.getDataSet(sqlstrinG, "member1")
            If gdataset.Tables("member1").Rows.Count = 0 Then
                'GroupBox1.Visible = True
                'GroupBox1.Text = "Do u want to fix this Bill Date? " & Format(DTPduedate.Value, "dd/MM/yyyy")
                ' Call Button3_Click()
                'Button3_Click(As sender, e)
                Button3_Click(Button3, New EventArgs())
                Exit Sub
            End If
            Dim Viewer As New REPORTVIEWER
            'Dim r As New billing
            Dim r As New CCLbilling
            '  gSQLString1 = "EXEC MONTHBILL '" & billdt2 & "','" & bildt & "'"
            ' gconnection.dataOperation(6, gSQLString1, "monthbill")
            If Trim(txt_Tomcode.Text) <> "" And Trim(txt_Tomcode.Text) <> "" Then
                'sqlstrinG = " SELECT ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(ADJUSTMENT,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE,ISNULL(BILLDATE,'') AS BILLDATE FROM bengal_monthbill b, membermaster m where b.mcode=m.mcode and b.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") ORDER BY b.MCODE "
                ' sqlstrinG = " SELECT ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(ADJUSTMENT,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE,ISNULL(BILLDATE,'') AS BILLDATE FROM bengal_monthbill b, membermaster m where b.mcode=m.mcode and b.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") order by SUBSTRING(M.MCODE,1,2),LEN(M.MCODE),M.MCODE "
                'sqlstrinG = "SELECT ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(t.vat,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(t.WBST,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE,ISNULL(BILLNO,'') AS OUTSTANDING FROM bengal_monthbill b, membermaster m,VW_WBST T  where b.mcode=m.mcode  and b.mcode =t.mcode and month(b.billdate)=t.kotdate  and substring(B.MCODE,1,2)+substring('00000000000',1,11-(len(B.MCODE)))+substring(B.MCODE,3,len(B.MCODE)-2) between substring('" & txt_mcode.Text & "',1,2)+substring('00000000000',1,11-(len('" & txt_mcode.Text & "')))+substring('" & txt_mcode.Text & "',3,len('" & txt_mcode.Text & "')-2)  and  substring('" & txt_Tomcode.Text & "',1,2)+substring('00000000000',1,11-(len('" & txt_Tomcode.Text & "')))+substring('" & txt_Tomcode.Text & "',3,len('" & txt_Tomcode.Text & "')-2) and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") order by SUBSTRING(M.MCODE,1,2),LEN(M.MCODE),M.MCODE "
                sqlstrinG = "SELECT ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(t.vat,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(t.WBST,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE,ISNULL(BILLNO,'') AS OUTSTANDING FROM bengal_monthbill b, membermaster m,VW_WBST T  where b.mcode=m.mcode  and b.mcode =t.mcode and month(b.billdate)=t.kotdate  and b.mcode BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") order by SUBSTRING(M.MCODE,1,2),LEN(M.MCODE),M.MCODE "
                'sql = "select isnull(billdetails,'') as billdetails,ISNULL(POSDESC,'') AS POSDESC,isnull(kotdate,'') as kotdate,isnull(mcode,'')as mcode,isnull(amount,0) as amount,isnull(vat,0) as vat,isnull(service_tax,0) as service_tax,isnull(service_charge,0) as service_charge from member_consumption where MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(kotdate)= " & month1 & "  ORDER BY MCODE "
                sql = "SELECT ISNULL(POSCODE,0) AS POSCODE,ISNULL(POSDESC,'') AS POSDESC,ISNULL(MCODE,'') AS MCODE,SUM(AMOUNT) AS AMOUNT,SUM(VAT) AS VAT,SUM(SERVICE_TAX) AS SERVICE_TAX,SUM(SERVICE_CHARGE) AS SERVICE_CHARGE FROM MEMBER_CONSUMPTION1 B where B.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(kotdate)= " & month1 & "  GROUP BY POSDESC,POSCODE,mcode  ORDER BY MCODE"
                ' sql = "SELECT ISNULL(POSCODE,0) AS POSCODE,ISNULL(POSDESC,'') AS POSDESC,ISNULL(MCODE,'') AS MCODE,SUM(AMOUNT) AS AMOUNT,SUM(VAT) AS VAT,SUM(SERVICE_TAX) AS SERVICE_TAX,SUM(SERVICE_CHARGE) AS SERVICE_CHARGE FROM MEMBER_CONSUMPTION B where substring(B.MCODE,1,2)+substring('00000000000',1,11-(len(B.MCODE)))+substring(B.MCODE,3,len(B.MCODE)-2)  between substring('" & txt_mcode.Text & "',1,2)+substring('00000000000',1,11-(len('" & txt_mcode.Text & "')))+substring('" & txt_mcode.Text & "',3,len('" & txt_mcode.Text & "')-2)  and  substring('" & txt_Tomcode.Text & "',1,2)+substring('00000000000',1,11-(len('" & txt_Tomcode.Text & "')))+substring('" & txt_Tomcode.Text & "',3,len('" & txt_Tomcode.Text & "')-2) and month(kotdate)= " & month1 & "  GROUP BY POSDESC,POSCODE,B.mcode,B.Sno  ORDER BY B.MCODE,B.Sno"

                '' '' '' '' '' ''sqlstring1 = " select slcode,locdesc,sum(dramount) as dramount,sum(cramount) as cramount "
                '' '' '' '' '' ''sqlstring1 = sqlstring1 & "FROM View_Rec_Det WHERE LTRIM(RTRIM(SLCODE)) BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(BILLDATE) = " & month1 & " GROUP BY SLCODE,locdesc "
                ' '' '' '' '' '' ''ssql2 = " SELECT SLCODE,UPPER(HEADDESC) AS HEADDESC,SUM(DRAMOUNT) AS DRAMOUNT,SUM(CRAMOUNT) AS CRAMOUNT FROM View_Pos_Summary WHERE MONTH(BILLDATE) = " & month1 & " AND SLCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' GROUP BY SLCODE,HEADDESC "
                '' '' '' '' '' ''ssql2 = "select SUM(amount)as amount,description,mcode from month_bill where (month(date)=" & month1 & " or date='1900-01-01') AND mCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' group by description,mcode,order_no order by mcode,order_no"
                '' '' '' '' '' ''sqlstring3 = " select slcode,locdesc,sum(dramount) as dramount,sum(cramount) as cramount "
                '' '' '' '' '' ''sqlstring3 = sqlstring3 & " FROM View_drcr_Det WHERE SLCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(BILLDATE) = " & month1 & " GROUP BY SLCODE,locdesc "
                'sqlstring2 = "select ClubLogo from accountsSetUp"
                sqlstring3 = " select mcode,SUM(isnull(BRAMOUNT,0)) as BRAMOUNT,SUM(isnull(CRAMOUNT ,0)) as CRAMOUNT,SUM(isnull(CCRAMOUNT,0)) as CCRAMOUNT,SUM(isnull(CCNAMOUNT,0)) as CCNAMOUNT,SUM(isnull(CDNAMOUNT,0)) as CDNAMOUNT "
                sqlstring3 = sqlstring3 & " ,SUM(isnull(PARTYAMT,0)) as billno FROM View_DRCR_SUM WHERE mcode BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(BILLDATE) = " & month1 & " GROUP BY mcode "

            Else
                ' membertype = ""
                If chk_Filter_Field.CheckedItems.Count > 0 Then
                    For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                        TYPE = Split(chk_Filter_Field.CheckedItems(i), ".")
                        membertype = membertype & "'" & TYPE(0) & "', "
                    Next
                    membertype = Mid(membertype, 1, Len(membertype) - 2)

                Else
                    MessageBox.Show("Select the Category(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    chk_Filter_Field.Focus()
                    Exit Sub
                End If
                ''sqlstrinG = " SELECT ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(ADJUSTMENT,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE,ISNULL(BILLDATE,'') AS BILLDATE FROM bengal_monthbill b, membermaster m   where b.mcode=m.mcode and LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") ORDER BY b.MCODE "
                ''sql = "select isnull(POSCODE,'') as POSCODE,ISNULL(POSDESC,'') AS POSDESC,isnull(M.mcode,'')as mcode,SUM(AMOUNT) AS AMOUNT,SUM(VAT) AS VAT,SUM(SERVICE_TAX) AS SERVICE_TAX,SUM(SERVICE_CHARGE) AS SERVICE_CHARGE from member_consumption1 a,membermaster m  where   month(kotdate)= " & month1 & " AND a.mcode=m.mcode and LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") group by poscode,posdesc,m.mcode ORDER BY m.MCODE "
                sqlstrinG = "SELECT ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(t.vat,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(WBST,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE,ISNULL(BILLNO,'') AS OUTSTANDING FROM bengal_monthbill b, membermaster m ,VW_WBST T  where b.mcode=m.mcode and b.mcode=t.mcode and month(b.billdate)=t.kotdate  and LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") order by SUBSTRING(M.MCODE,1,2),LEN(M.MCODE),M.MCODE "
                sql = "select isnull(POSCODE,'') as POSCODE,ISNULL(POSDESC,'') AS POSDESC,isnull(M.mcode,'')as mcode,SUM(AMOUNT) AS AMOUNT,SUM(VAT) AS VAT,SUM(SERVICE_TAX) AS SERVICE_TAX,SUM(SERVICE_CHARGE) AS SERVICE_CHARGE from member_consumption a,membermaster m  where   month(kotdate)= " & month1 & " AND a.mcode=m.mcode and LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ")  group by poscode,posdesc,m.mcode,A.SNo ORDER BY m.MCODE ,A.SNo"
                ' ''sqlstrinG = " SELECT ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT FROM bengal_monthbill b inner join membermaster m   ON b.mcode=m.mcode and b.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "'  ORDER BY b.MCODE "


                ''''''''''''''''sqlstrinG = " SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M WHERE M.MCODE = O.SLCODE AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") AND O.BILLDATE < '" & bildt & "' AND  CURENTSTATUS IN('LIVE','ACTIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE  ORDER BY M.MCODE "
                ' '' '' ''sqlstring1 = " select a.slcode,a.locdesc,sum(a.dramount) as dramount,sum(a.cramount) as cramount "
                ' '' '' ''sqlstring1 = sqlstring1 & "FROM View_Rec_Det a ,membermaster b WHERE MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  Group by  a.SLCODE,a.locdesc "
                '' '' '' ''ssql2 = " SELECT SLCODE,UPPER(HEADDESC) AS HEADDESC,SUM(DRAMOUNT) AS DRAMOUNT,SUM(CRAMOUNT) AS CRAMOUNT FROM View_Pos_Summary WHERE MONTH(BILLDATE) = " & month1 & " AND SLCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' GROUP BY SLCODE,HEADDESC "
                ' '' '' ''ssql2 = "select SUM(A.amount)as amount,A.description,A.mcode from month_bill A,MEMBERMASTER B where (month(A.date)=" & month1 & " or A.date='1900-01-01') and b.membertypecode in(" & membertype & ") group by a.description,a.mcode,a.order_no order by a.mcode,a.order_no"
                ' '' '' ''sqlstring3 = " select a.slcode,a.locdesc,sum(a.dramount) as dramount,sum(a.cramount) as cramount "
                ' '' '' ''sqlstring3 = sqlstring3 & " FROM View_drcr_Det a,membermaster b WHERE a.slcode=b.mcode  AND MONTH(a.BILLDATE) = " & month1 & " and b.membertypecode in(" & membertype & ") GROUP BY a.SLCODE,a.locdesc "

                'sqlstring = "SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+' '+ ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M WHERE SUBSTRING(M.MCODE,1,8) = SUBSTRING(O.SLCODE,1,8)  AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ")  "
                'sqlstring = sqlstring & " AND O.BILLDATE <'" & bildt & "' AND  CURENTSTATUS in('ACTIVE','LIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE  ORDER BY M.MCODE"
                'ssql = " SELECT A.BILLNO,A.SLCODE AS SLCODE,upper(A.HEADDESC),SUM(A.AMOUNT) AS AMOUNT,A.BILLDATE FROM MAINCASHRECEIPT  A, MEMBERMASTER B "
                'ssql = ssql & " WHERE Month(BILLDATE) = " & month1
                'ssql = ssql & " AND B.membertypecode IN(" & membertype & ") AND A.SLCODE=B.MCODE "
                'ssql = ssql & " GROUP BY A.SLCODE,A.HEADDESC,A.BILLDATE,A.BILLNO "
                'sqlstring1 = " select a.SLCODE,sum(a.dramount) as dramount,sum(a.cramount) as cramount "
                'sqlstring1 = sqlstring1 & "  From View_Rec_Det a, MEMBERMASTER b WHERE MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  Group by  a.SLCODE"
                'ssql2 = " SELECT a.SLCODE,upper(a.HEADDESC) AS HEADDESC,SUM(a.DRAMOUNT) AS DRAMOUNT,SUM(a.CRAMOUNT) AS CRAMOUNT FROM View_Pos_Summary  a, MEMBERMASTER b WHERE  MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  Group by  a.SLcode,a.HEADDESC "
                'sqlstring2 = "select ClubLogo from accountsSetUp"
                'sqlstring3 = " select A.slcode,A.locdesc,sum(A.dramount) as dramount,sum(A.cramount) as cramount "
                'sqlstring3 = sqlstring3 & " FROM View_drcr_Det A,MEMBERMASTER B WHERE MONTH(BILLDATE) = " & month1 & " and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ") GROUP BY SLCODE,locdesc "
                sqlstring3 = " select a.mcode,SUM(isnull(BRAMOUNT,0)) as BRAMOUNT,SUM(isnull(CRAMOUNT ,0)) as CRAMOUNT,SUM(isnull(CCRAMOUNT,0)) as CCRAMOUNT,SUM(isnull(CCNAMOUNT,0)) as CCNAMOUNT,SUM(isnull(CDNAMOUNT,0)) as CDNAMOUNT "
                sqlstring3 = sqlstring3 & " ,SUM(isnull(PARTYAMT,0)) as billno FROM View_DRCR_SUM A,MEMBERMASTER B WHERE MONTH(BILLDATE) = " & month1 & " and a.mcode=b.MCODE and b.membertypecode in(" & membertype & ") GROUP BY a.mcode"

            End If
            Call Viewer.GetDetails1(sql, "member_consumption", r)
            Call Viewer.GetDetails1(sqlstrinG, "bengal_monthbill", r)
            Call Viewer.GetDetails2(sqlstring3, "View_DRCR_SUM", r)
            'Call Viewer.GetDetails1(sql, "member_consumption", r)
            'Call Viewer.GetDetails1(sqlstrinG, "bengal_monthbill", r)

            Dim name, add1, add2, add3, city, state, pin, cell As String

            'name = gdataset.Tables("bengal_monthbill").Rows(0).Item("mname")
            'add1 = gdataset.Tables("bengal_monthbill").Rows(0).Item("contadd1")
            'add2 = gdataset.Tables("bengal_monthbill").Rows(0).Item("contadd2")
            'add3 = gdataset.Tables("bengal_monthbill").Rows(0).Item("contadd3")
            'city = gdataset.Tables("bengal_monthbill").Rows(0).Item("contcity")
            'pin = gdataset.Tables("bengal_monthbill").Rows(0).Item("contpin")
            'cell = gdataset.Tables("bengal_monthbill").Rows(0).Item("contcell")


            'Call Viewer.GetDetails1(ssql2, "month_bill", r)
            'Call Viewer.GetDetails1(sqlstring1, "View_Rec_Det", r)
            'Call Viewer.GetDetails1(sqlstring3, "View_drcr_Det", r)
            'Call Viewer.GetDetails1(sqlstring2, "accountsSetUp", r)
            'Dim txtobj1 As TextObject
            'Dim txtobj As TextObject
            'Dim txtobj2 As TextObject
            Dim txtobj15 As TextObject
            Dim txtobj19 As TextObject
            Dim txtobj20 As TextObject

            Dim txtobj1 As TextObject
            Dim duedt As Date

            txtobj1 = r.ReportDefinition.ReportObjects("Text2")
            duedt = DTPduedate.Value
            txtobj1.Text = Format(duedt, "dd/MMM/yyyy")

            'txtobj19 = r.ReportDefinition.ReportObjects("Text20")
            'txtobj19.Text = month & " " & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))

            'Dim convdate As Date
            'txtobj20 = r.ReportDefinition.ReportObjects("Text24")
            'convdate = noofdays & "-" & IIf(month1 > 9, Str(month1), "0" & month1) & "-" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))
            'txtobj20.Text = Format(convdate, "dd MMM yyyy")

            'txtobj15 = r.ReportDefinition.ReportObjects("Text22")
            'txtobj15.Text = "/" & month & "/" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4)) & "/Regular"


            'txtobj19 = r.ReportDefinition.ReportObjects("Text31")
            'txtobj19.Text = month & " " & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))

            ''Dim convdate1 As Date
            'txtobj20 = r.ReportDefinition.ReportObjects("Text35")
            'convdate = noofdays & "-" & IIf(month1 > 9, Str(month1), "0" & month1) & "-" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))
            'txtobj20.Text = Format(convdate, "dd MMM yyyy")

            'txtobj15 = r.ReportDefinition.ReportObjects("Text33")
            'txtobj15.Text = "/" & month & "/" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4)) & "/Regular"

            'Dim txtobj18 As TextObject
            'txtobj18 = r.ReportDefinition.ReportObjects("Text5")
            'txtobj18.Text = noofdays & "-" & IIf(month1 > 9, Str(month1), "0" & month1) & "-" & IIf(month1 > 3, gfinancalyearstart, Mid(gFinancialyearEnd,1, 4))


            'Dim txtobj1 As TextObject
            'Dim duedt As Date
            'txtobj1 = r.ReportDefinition.ReportObjects("Text27")
            'duedt = DTPduedate.Value
            'txtobj1.Text = Format(duedt, "dd.MM.yyyy")

            '' ''Dim txtobj1 As TextObject
            '' ''txtobj1 = r.ReportDefinition.ReportObjects("Text4")
            '' ''txtobj1.Text = name
            '' ''txtobj1 = r.ReportDefinition.ReportObjects("Text5")
            '' ''txtobj1.Text = add1
            '' ''txtobj1 = r.ReportDefinition.ReportObjects("Text6")
            '' ''txtobj1.Text = add2
            '' ''txtobj1 = r.ReportDefinition.ReportObjects("Text7")
            '' ''txtobj1.Text = add3
            '' ''txtobj1 = r.ReportDefinition.ReportObjects("Text8")
            '' ''txtobj1.Text = city & "  " & pin
            'txtobj1 = r.ReportDefinition.ReportObjects("Text9")
            'txtobj1.Text = UCase(cell)


            'txtobj15.Text = UCase(gUsername)
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub RDOCOMBINEDNO_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RDOCOMBINEDNO.Click
        Rnd_Summary.Visible = True
        Rnd_Details.Visible = True
        Rnd_summardet.Visible = False
    End Sub

    Private Sub RDOCOMBINEDYES_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RDOCOMBINEDYES.Click
        Rnd_Summary.Visible = False
        Rnd_Details.Visible = False
        Rnd_summardet.Visible = True
    End Sub

    Private Sub GETSUMMARYANDDETAILS()
        Try
            Dim cmdText As String
            Dim duedate, membertype, TYPE(0) As String
            Dim opl, i As Integer
            Call Validation()

            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : noofdays = 30 : bildt = "01/apr/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31 : bildt = "01/may/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30 : bildt = "01/jun/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31 : bildt = "01/jul/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31 : bildt = "01/aug/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30 : bildt = "01/sep/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31 : bildt = "01/oct/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30 : bildt = "01/nov/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31 : bildt = "01/dec/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31 : bildt = "01/jan/" & Mid(gFinancialyearEnd, 1, 4)
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 28 : bildt = "01/feb/" & Mid(gFinancialyearEnd, 1, 4)
            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31 : bildt = "01/mar/" & Mid(gFinancialyearEnd, 1, 4)
            Dim Viewer As New REPORTVIEWER
            'Dim r As New CRY_MONTHBILLSUMMARY
            Dim r As New CRY_MONTHBILLANDSUMMARY
            If Trim(txt_Tomcode.Text) <> "" And Trim(txt_Tomcode.Text) <> "" Then
                sqlstring = " SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M WHERE M.MCODE = O.SLCODE AND M.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND O.BILLDATE < '" & bildt & "' AND  CURENTSTATUS IN('LIVE','ACTIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE ORDER BY M.MCODE "
                sqlstring1 = " select substring(billno,1,2) as billno,slcode,locdesc,sum(dramount) as dramount,sum(cramount) as cramount,Isnull(instrumentno,'')as instrumentno,isnull(instrumentdate,'')as instrumentdate,isnull(loccode,'')as loccode "
                sqlstring1 = sqlstring1 & "FROM View_Rec_Det WHERE LTRIM(RTRIM(SLCODE)) BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(BILLDATE) = " & month1 & " GROUP BY billno,SLCODE,locdesc ,instrumentno,instrumentdate,loccode"
                ssql2 = " SELECT SLCODE,UPPER(HEADDESC) AS HEADDESC,SUM(DRAMOUNT) AS DRAMOUNT,SUM(CRAMOUNT) AS CRAMOUNT,SUM(ISNULL(TAX,0))as TAX,SUM(ISNULL(VAT,0))AS VAT,SUM(ISNULL(Tips,0))AS Tips  FROM View_Pos_Summary WHERE MONTH(BILLDATE) = " & month1 & " AND SLCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' GROUP BY SLCODE,HEADDESC "
            Else
                ' membertype = ""
                If chk_Filter_Field.CheckedItems.Count > 0 Then
                    For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                        TYPE = Split(chk_Filter_Field.CheckedItems(i), ".")
                        membertype = membertype & "'" & TYPE(0) & "', "
                    Next
                    membertype = Mid(membertype, 1, Len(membertype) - 2)

                Else
                    MessageBox.Show("Select the Category(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    chk_Filter_Field.Focus()
                    Exit Sub
                End If

                sqlstring = "SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+' '+ ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M WHERE SUBSTRING(M.MCODE,1,8) = SUBSTRING(O.SLCODE,1,8)  AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ")  "
                sqlstring = sqlstring & " AND O.BILLDATE <'" & bildt & "' AND  CURENTSTATUS in('ACTIVE','LIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE ORDER BY M.MCODE"
                ssql = " SELECT A.BILLNO,A.SLCODE AS SLCODE,upper(A.HEADDESC),SUM(A.AMOUNT) AS AMOUNT,A.BILLDATE FROM MAINCASHRECEIPT  A, MEMBERMASTER B "
                ssql = ssql & " WHERE Month(BILLDATE) = " & month1
                ssql = ssql & " AND B.membertypecode IN(" & membertype & ") AND A.SLCODE=B.MCODE "
                ssql = ssql & " GROUP BY A.SLCODE,A.HEADDESC,A.BILLDATE,A.BILLNO "
                sqlstring1 = " select substring(a.billno,1,2)as billno ,a.SLCODE,sum(a.dramount) as dramount,sum(a.cramount) as cramount,Isnull(a.instrumentno,'')as instrumentno,isnull(a.instrumentdate,'')as instrumentdate,isnull(loccode,'')as loccode  "
                sqlstring1 = sqlstring1 & "  From View_Rec_Det a, MEMBERMASTER b WHERE MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  Group by  a.billno,a.SLCODE,a.instrumentno,a.instrumentdate,a.loccode"
                ssql2 = " SELECT a.SLCODE,upper(a.HEADDESC) AS HEADDESC,SUM(a.DRAMOUNT) AS DRAMOUNT,SUM(a.CRAMOUNT) AS CRAMOUNT,SUM(ISNULL(TAX,0))as TAX,SUM(ISNULL(VAT,0))AS VAT,SUM(ISNULL(Tips,0))AS Tips  FROM View_Pos_Summary  a, MEMBERMASTER b WHERE  MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  Group by  a.SLcode,a.HEADDESC "


            End If
            Call Viewer.GetDetails1(sqlstring, "MEMBERMASTER", r)
            Call Viewer.GetDetails1(ssql2, "View_Pos_Summary", r)
            Call Viewer.GetDetails1(sqlstring1, "View_Rec_Det", r)
            Dim txtobj1 As TextObject
            Dim txtobj As TextObject
            Dim txtobj2 As TextObject
            Dim txtobj15 As TextObject
            Dim txtobj18 As TextObject
            Dim txtobj19 As TextObject
            Dim txtobj20 As TextObject
            txtobj19 = r.ReportDefinition.ReportObjects("Text19")
            'txtobj15 = r.ReportDefinition.ReportObjects("Text15")
            txtobj18 = r.ReportDefinition.ReportObjects("Text18")
            txtobj1 = r.ReportDefinition.ReportObjects("Text29")
            txtobj1.Text = UCase(gcompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text30")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text31")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text32")
            txtobj1.Text = UCase(gCompanyAddress(3))
            txtobj19.Text = "01/" & IIf(month1 > 9, Str(month1), "0" & month1) & "/" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))
            txtobj18.Text = noofdays & "/" & IIf(month1 > 9, Str(month1), "0" & month1) & "/" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))
            'txtobj15.Text = UCase(gUsername)
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub billSummarydetails()
        Try
            Dim cmdText As String
            Dim duedate, membertype, TYPE(0) As String
            Dim opl, i As Integer
            Call Validation()
            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : noofdays = 30 : bildt = "01/apr/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31 : bildt = "01/may/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30 : bildt = "01/jun/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31 : bildt = "01/jul/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31 : bildt = "01/aug/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30 : bildt = "01/sep/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31 : bildt = "01/oct/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30 : bildt = "01/nov/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31 : bildt = "01/dec/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31 : bildt = "01/jan/" & Mid(gFinancialyearEnd, 1, 4)
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 29 : bildt = "01/feb/" & Mid(gFinancialyearEnd, 1, 4)
            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31 : bildt = "01/mar/" & Mid(gFinancialyearEnd, 1, 4)
            Dim Viewer As New REPORTVIEWER
            Dim r As New Cry_Debitcredit
            If chk_Filter_Field.CheckedItems.Count > 0 Then
                For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                    TYPE = Split(chk_Filter_Field.CheckedItems(i), ".")
                    membertype = membertype & "'" & TYPE(0) & "', "
                Next
                membertype = Mid(membertype, 1, Len(membertype) - 2)

            Else
                MessageBox.Show("Select the Category(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                chk_Filter_Field.Focus()
                Exit Sub
            End If
            Dim Cmd As New SqlCommand
            Dim con As SqlConnection

            'sqlstring = "DROP VIEW opbalhga"

            'gconnection.dataOperation(2, sqlstring, "opbalhga")
            'sqlstring1 = "DROP VIEW credhga"
            'gconnection.dataOperation(3, sqlstring1, "credhga")

            sqlstring = "ALTER VIEW opbalhga as select slcode,SUM(opbalance) as openingbalance from MM_VIEW_DEBITCREDIT WHERE BILLDATE< '" & bildt & "'GROUP BY SLCODE"
            gconnection.dataOperation(3, sqlstring, "opbalhga1")
            sqlstring = "ALTER view credhga as Select B.SLCODE,B.OPENINGBALANCE,SUM(isnull(a.DEBITAMOUNT,0))AS DEBITAMOUNT,SUM(isnull(a.CREDIT,0))AS CREDIT,A.mname,A.CONTCELL  from  opbalhga b left outer join MM_VIEW_DEBITCREDIT_DET a on a.slcode=b.SLcode and MONTH(a.BILLDATE)='" & month1 & "' group by b.SLCODE,b.OPENINGBALANCE,A.MNAME,A.CONTCELL"
            gconnection.dataOperation(4, sqlstring, "credhga2")
            sqlstring1 = "ALTER view credhga1 as select a.slcode,b.mname,b.CONTCELL,a.openingbalance,a.credit,a.debitamount from credhga a inner join membermaster b on a.slcode=b.MCODE"
            gconnection.dataOperation(6, sqlstring1, "credhga4")






            'If Trim(txt_mcode.Text) <> "" Then
            '    'sqlstring1 = "SELECT ISNULL(M.MCODE,'') AS MCODE,ISNULL(M.MNAME,'') AS MNAME, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,mm_MEMBERMASTER M WHERE SUBSTRING(M.MCODE,1,8) = SUBSTRING(O.SLCODE,1,8)  AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") "
            '    'sqlstring1 = sqlstring1 & " AND O.BILLDATE <'" & bildt & "' AND  CURENTSTATUS in('ACTIVE','LIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.membertype ORDER BY M.MCODE"
            '    ''sqlstring = "select a.slcode,b.mname,b.membertypecode,SUM(balance) as prev_due,SUM(billamount) as billamount,case when SUM(balance)+SUM(billamount)>=0 then SUM(balance)+SUM(billamount) else 0 end as totaldue,case when SUM(balance)+SUM(billamount)<0 then SUM(balance)+SUM(billamount) else 0 end as totalcredit from view_monthbillsummary a inner join membermaster b  on a.slcode=b.MCODE  AND  b.MCODE = '" & txt_mcode.Text & "'  group by a.slcode,b.mname,b.membertypecode"
            '    'sqlstring = "Select a.slcode,b.mname,a.OPBALANCE,a.DEBITAMOUNT,a.CREDIT from MM_VIEW_DEBITCREDIT a inner join membermaster b where month(a.BILLDATE)='" & month1 & "' AND  b.MCODE = '" & txt_mcode.Text & "'"
            'Else
            If Trim(txt_Tomcode.Text) <> "" And Trim(txt_Tomcode.Text) <> "" Then
                sqlstring = " SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M WHERE M.MCODE = O.SLCODE AND M.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND O.BILLDATE < '" & bildt & "' AND  CURENTSTATUS IN('LIVE','ACTIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE ORDER BY M.MCODE "
                sqlstring1 = " select substring(billno,1,2) as billno,slcode,locdesc,sum(dramount) as dramount,sum(cramount) as cramount,Isnull(instrumentno,'')as instrumentno,isnull(instrumentdate,'')as instrumentdate,isnull(loccode,'')as loccode "
                sqlstring1 = sqlstring1 & "FROM View_Rec_Det WHERE LTRIM(RTRIM(SLCODE)) BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(BILLDATE) = " & month1 & " GROUP BY billno,SLCODE,locdesc ,instrumentno,instrumentdate,loccode"
                ssql2 = " SELECT SLCODE,UPPER(HEADDESC) AS HEADDESC,SUM(DRAMOUNT) AS DRAMOUNT,SUM(CRAMOUNT) AS CRAMOUNT,SUM(ISNULL(TAX,0))as TAX,SUM(ISNULL(VAT,0))AS VAT,SUM(ISNULL(Tips,0))AS Tips  FROM View_Pos_Summary WHERE MONTH(BILLDATE) = " & month1 & " AND SLCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' GROUP BY SLCODE,HEADDESC "
            Else
                ''ssql = " SELECT A.BILLNO,A.SLCODE AS SLCODE,upper(A.HEADDESC),SUM(A.AMOUNT) AS AMOUNT,A.BILLDATE FROM MAINCASHRECEIPT  A, MEMBERMASTER B "
                'ssql = ssql & " WHERE Month(BILLDATE) = " & month1
                'ssql = ssql & " AND B.membertypecode IN(" & membertype & ") AND A.SLCODE=B.MCODE "
                'ssql = ssql & " GROUP BY A.SLCODE,A.HEADDESC,A.BILLDATE,A.BILLNO "
                'sqlstring1 = "select sum(Cramount)as Cramount,SUM(Dramount)as Dramount,slcode"
                'sqlstring1 = sqlstring1 & "  From View_Rec_Det a, MEMBERMASTER b WHERE MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  Group by  a.billno,a.SLCODE"
                ''sqlstring1 = " select substring(a.billno,1,2)as billno ,a.SLCODE,sum(a.dramount) as dramount,sum(a.cramount) as cramount,Isnull(a.instrumentno,'')as instrumentno,isnull(a.instrumentdate,'')as instrumentdate,isnull(loccode,'')as loccode  "
                ''sqlstring1 = sqlstring1 & "  From View_Rec_Det a, MEMBERMASTER b WHERE MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  Group by  a.billno,a.SLCODE,a.instrumentno,a.instrumentdate,a.loccode"
                'ssql2 = " SELECT a.SLCODE,SUM(a.DRAMOUNT) AS DRAMOUNT,SUM(a.CRAMOUNT) AS CRAMOUNT,SUM(ISNULL(TAX,0))as TAX,SUM(ISNULL(VAT,0))AS VAT,SUM(ISNULL(Tips,0))AS Tips  FROM View_Pos_Summary  a, MEMBERMASTER b WHERE  MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  Group by  a.SLcode "

                'sqlstring1 = "SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+' '+ ISNULL(M.MNAME,'')) AS MNAME,'" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MM_MEMBERMASTER M WHERE SUBSTRING(M.MCODE,1,8) = SUBSTRING(O.SLCODE,1,8)  AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ")"
                'sqlstring1 = sqlstring1 & " AND O.BILLDATE <'" & bildt & "' AND  CURENTSTATUS in('ACTIVE','LIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.membertype ORDER BY M.MCODE"
                ''sqlstring = "select a.slcode,b.mname,b.membertypecode,SUM(balance) as prev_due,SUM(billamount) as billamount,case when SUM(balance)+SUM(billamount)>=0 then SUM(balance)+SUM(billamount) else 0 end as totaldue,case when SUM(balance)+SUM(billamount)<0 then SUM(balance)+SUM(billamount) else 0 end as totalcredit,sum(rcpt) as rcpt from view_monthbillsummary a inner join membermaster b  on a.slcode=b.MCODE AND B.membertypecode IN(" & membertype & ") "
                ''sqlstring = sqlstring & "group by a.slcode,b.mname,b.membertypecode having  SUM(billamount)>0 "
                'sqlstring = "Select a.slcode,b.mname,SUM(a.OPBALANCE),SUM(a.DEBITAMOUNT),SUM(a.CREDIT) from MM_VIEW_DEBITCREDIT a,membermaster b where a.slcode=b.MCODE AND B.membertypecode IN(" & membertype & ")and month(BILLDATE)='" & month1 & "' group by a.slcode,b.MNAME "
                'sqlstring = "Select a.slcode,b.mname,b.Membertype,SUM(a.OPBALANCE)AS OPBALANCE,SUM(a.DEBITAMOUNT)AS DEBITAMOUNT,SUM(a.CREDIT)AS CREDIT,sum(a.TAX)as TAX from MM_VIEW_DEBITCREDIT_DET a,membermaster b where a.slcode = b.MCODE AND B.membertypecode IN(" & membertype & ")and month(BILLDATE)='" & month1 & "' group by a.slcode,b.MNAME,b.Membertype "
                'sqlstring = "Select a.slcode,b.mname,b.Membertype,SUM(a.OPBALANCE)AS OPBALANCE,SUM(a.DEBITAMOUNT)AS DEBITAMOUNT,SUM(a.CREDIT)AS CREDIT from MM_VIEW_DEBITCREDIT_DET a,membermaster b where a.slcode = b.MCODE AND B.membertypecode IN(" & membertype & ")and month(BILLDATE)='" & month1 & "' group by a.slcode,b.MNAME,b.Membertype "
                sqlstring = "select slcode,mname,CONTCELL,openingbalance,credit,debitamount from credhga1 order by slcode"

            End If

            'Call Viewer.GetDetails1(sqlstring1, "MM_MEMBERMASTER", r)
            Call Viewer.GetDetails1(sqlstring, "credhga1", r)
            'Call Viewer.GetDetails1(sqlstring1, "MEMBERMASTER", r)
            'Call Viewer.GetDetails1(sqlstring1, "VIEW_REC_DET", r)
            'Call Viewer.GetDetails1(ssql2, "View_Pos_Summary", r)

            Dim txtobj1 As TextObject
            Dim txtobj As TextObject
            Dim txtobj2 As TextObject
            Dim txtobj18 As TextObject
            Dim txtobj19 As TextObject
            Dim txtobj20 As TextObject
            Dim txtobj15 As TextObject

            txtobj1 = r.ReportDefinition.ReportObjects("Text8")
            txtobj1.Text = UCase(gcompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text13")
            txtobj1.Text = UCase(gCompanyAddress(3))
            txtobj1 = r.ReportDefinition.ReportObjects("Text9")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text10")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj19 = r.ReportDefinition.ReportObjects("Text19")
            txtobj18 = r.ReportDefinition.ReportObjects("Text18")
            txtobj19.Text = "01/" & IIf(month1 > 9, Str(month1), "0" & month1) & "/" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))
            txtobj18.Text = noofdays & "/" & IIf(month1 > 9, Str(month1), "0" & month1) & "/" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Btn_Excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Excel.Click
        Dim cmdText, note As String
        cmdText = "Select * From VW_UNITWISE_MEMBER"
        Dim duedate, membertype, TYPE(0) As String
        Dim opl, i As Integer
        Dim unit(0) As String
        Dim unitno As String
        Dim ranklist As String
        Dim dr, dr1, dr2, dr4 As DataRow
        Call Validation()
        If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : noofdays = 30 : bildt = "01/apr/" & gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31 : bildt = "01/may/" & gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30 : bildt = "01/jun/" & gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31 : bildt = "01/jul/" & gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31 : bildt = "01/aug/" & gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30 : bildt = "01/sep/" & gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31 : bildt = "01/oct/" & gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30 : bildt = "01/nov/" & gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31 : bildt = "01/dec/" & gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31 : bildt = "01/jan/" & Mid(gFinancialyearEnd, 1, 4)
        If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 28 : bildt = "01/feb/" & Mid(gFinancialyearEnd, 1, 4)
        If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31 : bildt = "01/mar/" & Mid(gFinancialyearEnd, 1, 4)
        Dim ssql As String
        If Rnd_subscription.Checked = True Then
            Try
                Dim _export As New EXPORT
                Dim SQLSTR As String
                SQLSTR = "SELECT * FROM MM_VIEW_SUBSPOSTING WHERE month(BILLDATE)=month('" & Format(CDate(bildt), "dd/MMM/yyyy") & "')"
                _export.TABLENAME = "MM_VIEW_SUBSPOSTING"
                Call _export.export_excel(SQLSTR)
                _export.Show()
                Exit Sub
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf Rnd_Posdetails.Checked = True Then

            Try
                Dim _export As New EXPORT

                Dim SQLSTR As String
                SQLSTR = "SELECT * FROM MM_VIEW_POS_SDETAILS WHERE MONTH(KOTDATE) =month('" & Format(CDate(bildt), "dd/MMM/yyyy") & "')"
                _export.TABLENAME = "MM_VIEW_POS_SDETAILS "
                Call _export.export_excel(SQLSTR)
                _export.Show()
                Exit Sub
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub
    Public Sub bill_Summary_details()
        Try
            Dim bildt, bildt1 As Date
            Dim cmdText As String
            Dim duedate, membertype, TYPE(0) As String
            Dim opl, i As Integer
            Call Validation()
            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : noofdays = 30 : bildt = "01/apr/" & gFinancalyearStart : bildt1 = "30/apr/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31 : bildt = "01/may/" & gFinancalyearStart : bildt1 = "31/may/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30 : bildt = "01/jun/" & gFinancalyearStart : bildt1 = "30/jun/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30 : bildt = "01/jun/" & gFinancalyearStart : bildt1 = "30/jun/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31 : bildt = "01/jul/" & gFinancalyearStart : bildt1 = "31/jul/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31 : bildt = "01/aug/" & gFinancalyearStart : bildt1 = "31/aug/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30 : bildt = "01/sep/" & gFinancalyearStart : bildt1 = "30/sep/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31 : bildt = "01/oct/" & gFinancalyearStart : bildt1 = "31/oct/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30 : bildt = "01/nov/" & gFinancalyearStart : bildt1 = "30/nov/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31 : bildt = "01/dec/" & gFinancalyearStart : bildt1 = "31/dec/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31 : bildt = "01/jan/" & Mid(gFinancialyearEnd, 1, 4) : bildt1 = "31/jan/" & gFinancialyearEnd
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 29 : bildt = "01/feb/" & Mid(gFinancialyearEnd, 1, 4) : bildt1 = "28/feb/" & gFinancialyearEnd
            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31 : bildt = "01/mar/" & Mid(gFinancialyearEnd, 1, 4) : bildt1 = "31/mar/" & gFinancialyearEnd
            Dim Viewer As New REPORTVIEWER
            Dim r As New Cry_Debitcredit
            'If chk_Filter_Field.CheckedItems.Count > 0 Then
            '    For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
            '        TYPE = Split(chk_Filter_Field.CheckedItems(i), ".")
            '        membertype = membertype & "'" & TYPE(0) & "', "
            '    Next
            '    membertype = Mid(membertype, 1, Len(membertype) - 2)

            'Else
            '    MessageBox.Show("Select the Category(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    chk_Filter_Field.Focus()
            '    Exit Sub
            'End If
            Dim Cmd As New SqlCommand
            Dim con As SqlConnection
            sqlstring1 = "EXEC cp_monthsummary  '" & Format(bildt, "dd/MMM/yyyy") & "','" & Format(bildt1, "dd/MMM/yyyy") & "'"
            gconnection.ExcuteStoreProcedure(sqlstring1)
            If Trim(txt_mcode.Text) <> "" And Trim(txt_Tomcode.Text) <> "" Then
                sqlstring = "select slcode,mname,CONTCELL,openingbalance,credit,debitamount from credhga1 where slcode between '" & txt_mcode.Text & "' and '" & txt_Tomcode.Text & "' order by slcode"
            Else
                If chk_Filter_Field.CheckedItems.Count > 0 Then
                    For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                        TYPE = Split(chk_Filter_Field.CheckedItems(i), ".")
                        membertype = membertype & "'" & TYPE(0) & "', "
                    Next
                    membertype = Mid(membertype, 1, Len(membertype) - 2)

                Else
                    MessageBox.Show("Select the Category(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    chk_Filter_Field.Focus()

                    Exit Sub
                End If
                sqlstring = "select h.slcode,h.mname,h.CONTCELL,h.openingbalance,h.credit,h.debitamount,m.membertypecode from credhga1 h,membermaster m  where h.slcode=m.mcode and  LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") order by len(h.slcode),substring(h.slcode,1,1),isnull(h.slcode,'')"
            End If

            Call Viewer.GetDetails1(sqlstring, "credhga1", r)
            Dim txtobj1 As TextObject
            Dim txtobj As TextObject
            Dim txtobj2 As TextObject
            Dim txtobj18 As TextObject
            Dim txtobj19 As TextObject
            Dim txtobj20 As TextObject
            Dim txtobj15 As TextObject

            txtobj1 = r.ReportDefinition.ReportObjects("Text8")
            txtobj1.Text = UCase(gcompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text13")
            txtobj1.Text = UCase(gCompanyAddress(3))
            txtobj1 = r.ReportDefinition.ReportObjects("Text9")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text10")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj19 = r.ReportDefinition.ReportObjects("Text19")
            txtobj18 = r.ReportDefinition.ReportObjects("Text18")
            txtobj19.Text = "01/" & IIf(month1 > 9, Str(month1), "0" & month1) & "/" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))
            txtobj18.Text = noofdays & "/" & IIf(month1 > 9, Str(month1), "0" & month1) & "/" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub RND_billforward_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RND_billforward.CheckedChanged

    End Sub

    Private Sub chk_Filter_Field_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Filter_Field.SelectedIndexChanged

    End Sub

    Private Sub txt_mcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_mcode.TextChanged

    End Sub

    Private Sub Rnd_Details_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rnd_Details.CheckedChanged

    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Btn_Excel.Enabled = True
        Btn_close.Enabled = True
        cmd_view.Enabled = True
        cmd_Clear.Enabled = True
    End Sub
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            Dim cmdText, billdt2, mcode, year, PDFDATE As String
            Dim duedate, membertype, TYPE(0), month, sql, sqlstrinG, sqlstrinG_1, month2 As String
            Dim opl, i As Integer
            Dim bLeapYear As Boolean
            bLeapYear = Date.IsLeapYear(gFinancialyearEnd)
            Call Validation()
            If gpdf = "" Then
                MessageBox.Show("Pls Provide PDF Path in Dbs key")
                Exit Sub
            End If

            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : month = "APR" : noofdays = 30 : bildt = "01/apr/" & gFinancalyearStart : month2 = "04" : billdt2 = "30/apr/" & gFinancalyearStart : year = "APR_" & gFinancalyearStart : PDFDATE = "APRIL-" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : month = "MAY" : noofdays = 31 : bildt = "01/may/" & gFinancalyearStart : month2 = "05" : billdt2 = "31/may/" & gFinancalyearStart : year = "MAY_" & gFinancalyearStart : PDFDATE = "MAY-" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : month = "JUN" : noofdays = 30 : bildt = "01/jun/" & gFinancalyearStart : month2 = "06" : billdt2 = "30/jun/" & gFinancalyearStart : year = "JUN_" & gFinancalyearStart : PDFDATE = "JUNE-" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : month = "JUL" : noofdays = 31 : bildt = "01/jul/" & gFinancalyearStart : month2 = "07" : billdt2 = "31/jul/" & gFinancalyearStart : year = "JUL_" & gFinancalyearStart : PDFDATE = "JULY-" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : month = "AUG" : noofdays = 31 : bildt = "01/aug/" & gFinancalyearStart : month2 = "08" : billdt2 = "31/aug/" & gFinancalyearStart : year = "AUG_" & gFinancalyearStart : PDFDATE = "AUGUST-" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : month = "SEP" : noofdays = 30 : bildt = "01/sep/" & gFinancalyearStart : month2 = "09" : billdt2 = "30/sep/" & gFinancalyearStart : year = "SEP_" & gFinancalyearStart : PDFDATE = "SEPTEMBER-" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : month = "OCT" : noofdays = 31 : bildt = "01/oct/" & gFinancalyearStart : month2 = "10" : billdt2 = "31/oct/" & gFinancalyearStart : year = "OCT_" & gFinancalyearStart : PDFDATE = "OCTOBER-" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : month = "NOV" : noofdays = 30 : bildt = "01/nov/" & gFinancalyearStart : month2 = "11" : billdt2 = "30/nov/" & gFinancalyearStart : year = "NOV_" & gFinancalyearStart : PDFDATE = "NOVEMBER-" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : month = "DEC" : noofdays = 31 : bildt = "01/dec/" & gFinancalyearStart : month2 = "12" : billdt2 = "31/dec/" & gFinancalyearStart : year = "DEC_" & gFinancalyearStart : PDFDATE = "DECEMBER-" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : month = "JAN" : noofdays = 31 : bildt = "01/jan/" & gFinancialyearEnd : month2 = "01" : billdt2 = "31/jan/" & gFinancialyearEnd : year = "JAN_" & gFinancialyearEnd : PDFDATE = "JANUARY-" & gFinancialyearEnd
            ' If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : month = "FEB" : noofdays = 28 : bildt = "01/feb/" & gFinancialyearEnd : month2 = "02" : billdt2 = "28/feb/" & gFinancialyearEnd : year = "FEB_" & gFinancialyearEnd : PDFDATE = "FEBRUARY-" & gFinancialyearEnd
            If bLeapYear = True Then
                If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : month = "FEB" : noofdays = 29 : bildt = "01/feb/" & gFinancialyearEnd : month2 = "02" : billdt2 = "29/feb/" & gFinancialyearEnd : year = "FEB_" & gFinancialyearEnd : PDFDATE = "FEBRUARY-" & gFinancialyearEnd
            Else
                If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : month = "FEB" : noofdays = 28 : bildt = "01/feb/" & gFinancialyearEnd : month2 = "02" : billdt2 = "28/feb/" & gFinancialyearEnd : year = "FEB_" & gFinancialyearEnd : PDFDATE = "FEBRUARY-" & gFinancialyearEnd
            End If
            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : month = "MAR" : noofdays = 31 : bildt = "01/mar/" & gFinancialyearEnd : month2 = "03" : billdt2 = "31/mar/" & gFinancialyearEnd : year = "MAR_" & gFinancialyearEnd : PDFDATE = "MARCH-" & gFinancialyearEnd
            Dim Viewer As New REPORTVIEWER
            sqlstrinG_1 = ""
            If Mid(UCase(Trim(gcompanyname)), 1, 3) = "MLA" Then
               
                ' Dim r As New billing
                'Dim r As New CRY_GOLFMONTHBILLSUMMARY
                If Directory.Exists(gpdf) Then
                Else
                    MessageBox.Show(gpdf & " not exists")
                    Exit Sub
                End If
                If Directory.Exists(gpdf & "\" & year) Then
                Else
                    Directory.CreateDirectory(gpdf & "\" & year)
                End If

                ' gSQLString1 = "EXEC MONTHBILL '" & billdt2 & "','" & bildt & "'"
                'gconnection.dataOperation(6, gSQLString1, "monthbill")
                If Trim(txt_Tomcode.Text) <> "" And Trim(txt_Tomcode.Text) <> "" Then
                    'sqlstrinG = " SELECT ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE FROM bengal_monthbill b , membermaster m where b.mcode=m.mcode and b.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(b.billdate)=" & month1 & "  and ISNULL(m.CONTEMAIL,'') <> '' AND ISNULL(m.CONTEMAIL,'') <> 'x' AND (m.MCODE LIKE 'B%' OR m.MCODE LIKE 'T%') AND ISNULL(m.CURENTSTATUS,'') IN ('ACTIVE','LIVE') AND ISNULL(m.FREEZE,'') <> 'Y' AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ")  ORDER BY b.MCODE "
                    sqlstrinG_1 = " SELECT ISNULL(MCODE,'') AS MCODE FROM membermaster  where  MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "'   and ISNULL(CONTEMAIL,'') <> ''    AND ISNULL(CURENTSTATUS,'') IN ('LIVE','ACTIVE' )   ORDER BY MCODE "
                    'sql = "select isnull(billdetails,'') as billdetails,ISNULL(POSDESC,'') AS POSDESC,isnull(kotdate,'') as kotdate,isnull(mcode,'')as mcode,isnull(amount,0) as amount,isnull(vat,0) as vat,isnull(service_tax,0) as service_tax,isnull(service_charge,0) as service_charge from member_consumption where MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(kotdate)= " & month1 & "  ORDER BY MCODE "
                    gconnection.getDataSet(sqlstrinG_1, "member")
                    If gdataset.Tables("member").Rows.Count > 0 Then
                        For i = 0 To gdataset.Tables("member").Rows.Count - 1
                            mcode = gdataset.Tables("member").Rows(i).Item("mcode")
                            If mcode <> "" Then
                                Call BILLDETAILS(mcode, year)
                            End If
                        Next i
                    End If
                Else

                    ' membertype = ""
                    If chk_Filter_Field.CheckedItems.Count > 0 Then
                        For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                            TYPE = Split(chk_Filter_Field.CheckedItems(i), ".")
                            membertype = membertype & "'" & TYPE(0) & "', "
                        Next
                        membertype = Mid(membertype, 1, Len(membertype) - 2)

                    Else
                        MessageBox.Show("Select the Category(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        chk_Filter_Field.Focus()
                        Exit Sub
                    End If
                    
                    ' sqlstrinG = " SELECT ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT FROM bengal_monthbill b, membermaster m where b.mcode=m.mcode and LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") and month(b.billdate)=" & month1 & "  and ISNULL(m.CONTEMAIL,'') <> '' AND ISNULL(m.CONTEMAIL,'') <> 'x' AND (m.MCODE LIKE 'B%' OR m.MCODE LIKE 'T%') AND ISNULL(m.CURENTSTATUS,'') IN ('ACTIVE','LIVE') AND ISNULL(m.FREEZE,'') <> 'Y' AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") ORDER BY b.MCODE "
                    sqlstrinG_1 = " SELECT ISNULL(MCODE,'') AS MCODE FROM membermaster  where    LTRIM(RTRIM(membertypecode)) IN(" & membertype & ")   and ISNULL(CONTEMAIL,'') <> ''    AND ISNULL(CURENTSTATUS,'') IN ('LIVE','ACTIVE' )   ORDER BY MCODE "
                    ' sqlstrinG = " SELECT ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT FROM bengal_monthbill b, membermaster m where b.mcode=m.mcode and LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") and month(b.billdate)=" & month1 & "  and ISNULL(m.CONTEMAIL,'') <> '' AND ISNULL(m.CONTEMAIL,'') <> 'x' AND ISNULL(m.CURENTSTATUS,'') IN ('LIVE','ACTIVE','SUSPENDED','POSTED') AND ISNULL(m.FREEZE,'') <> 'Y' AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") ORDER BY b.MCODE "
                    gconnection.getDataSet(sqlstrinG_1, "member")
                    If gdataset.Tables("member").Rows.Count > 0 Then
                        For i = 0 To gdataset.Tables("member").Rows.Count - 1
                            mcode = gdataset.Tables("member").Rows(i).Item("mcode")
                            If mcode <> "" Then
                                If Rnd_Summary.Checked = True Then
                                    Dim FILEPATH As String
                                    Dim AFILE As File
                                    'FILEPATH = gpdf & "\" & year & "\" & mcode.Replace("*", " ") & "-" & PDFDATE & "bill.PDF"
                                    FILEPATH = gpdf & "\" & year & "\" & mcode.Replace("/", "_") & "-" & PDFDATE & "bill.PDF"
                                    'FILEPATH = gpdf & "\" & year & "\" & mcode.Replace("/", "_") & "-" & PDFDATE & "checklist.PDF"
                                    If AFILE.Exists(FILEPATH) Then
                                    Else
                                        Call BILLDETAILS(mcode, year)
                                    End If
                                Else
                                    Dim FILEPATH As String
                                    Dim AFILE As File
                                    'FILEPATH = gpdf & "\" & year & "\" & mcode.Replace("*", " ") & "-" & PDFDATE & "bill.PDF"
                                    FILEPATH = gpdf & "\" & year & "\" & mcode.Replace("/", "_") & "-" & PDFDATE & "checklist.PDF"
                                    If AFILE.Exists(FILEPATH) Then
                                    Else
                                        Call BILLDETAILS(mcode, year)
                                    End If
                                    ' Call BILLDETAILS(mcode, year)
                                End If
                                'Call BILLDETAILS(mcode, year)
                            End If
                        Next i
                    End If

                End If
            Else


                sqlstrinG = "SELECT * FROM JOURNALENTRY WHERE VOUCHERTYPE='MBILL' AND ISNULL(VOID,'')<>'Y' AND MONTH(VOUCHERDATE)='" & month2 & "'"
                ' sqlstrinG = "SELECT * FROM JOURNALENTRY WHERE VOUCHERTYPE='MBILL' AND ISNULL(VOID,'')<>'Y' AND VOUCHERDATE='" & Format(CDate(billdt2), "yyyy-MM-dd") & "'"
                gconnection.getDataSet(sqlstrinG, "member")
                If gdataset.Tables("member").Rows.Count = 0 Then
                    MessageBox.Show("Month Bill is Not processed for this month")
                    Exit Sub
                End If

                ' Dim r As New billing
                Dim r As New CCLbilling
                If Directory.Exists(gpdf) Then
                Else
                    MessageBox.Show(gpdf & " not exists")
                    Exit Sub
                End If
                If Directory.Exists(gpdf & "\" & year) Then
                Else
                    Directory.CreateDirectory(gpdf & "\" & year)
                End If

                ' gSQLString1 = "EXEC MONTHBILL '" & billdt2 & "','" & bildt & "'"
                'gconnection.dataOperation(6, gSQLString1, "monthbill")
                If Trim(txt_Tomcode.Text) <> "" And Trim(txt_Tomcode.Text) <> "" Then
                    'sqlstrinG = " SELECT ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE FROM bengal_monthbill b , membermaster m where b.mcode=m.mcode and b.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(b.billdate)=" & month1 & "  and ISNULL(m.CONTEMAIL,'') <> '' AND ISNULL(m.CONTEMAIL,'') <> 'x' AND (m.MCODE LIKE 'B%' OR m.MCODE LIKE 'T%') AND ISNULL(m.CURENTSTATUS,'') IN ('ACTIVE','LIVE') AND ISNULL(m.FREEZE,'') <> 'Y' AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ")  ORDER BY b.MCODE "
                    sqlstrinG = " SELECT ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE FROM bengal_monthbill b , membermaster m where b.mcode=m.mcode and b.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(b.billdate)=" & month1 & "  and ISNULL(m.CONTEMAIL,'') <> '' AND ISNULL(m.CONTEMAIL,'') <> 'x'  AND ISNULL(m.CURENTSTATUS,'') IN ('LIVE','ACTIVE','SUSPENDED','POSTED') AND ISNULL(m.FREEZE,'') <> 'Y' AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ")  ORDER BY b.MCODE "
                    'sql = "select isnull(billdetails,'') as billdetails,ISNULL(POSDESC,'') AS POSDESC,isnull(kotdate,'') as kotdate,isnull(mcode,'')as mcode,isnull(amount,0) as amount,isnull(vat,0) as vat,isnull(service_tax,0) as service_tax,isnull(service_charge,0) as service_charge from member_consumption where MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(kotdate)= " & month1 & "  ORDER BY MCODE "
                    gconnection.getDataSet(sqlstrinG, "member")
                    If gdataset.Tables("member").Rows.Count > 0 Then
                        For i = 0 To gdataset.Tables("member").Rows.Count - 1
                            mcode = gdataset.Tables("member").Rows(i).Item("mcode")
                            If mcode <> "" Then
                                Call BILLDETAILS(mcode, year)
                            End If
                        Next i
                    End If
                Else

                    ' membertype = ""
                    If chk_Filter_Field.CheckedItems.Count > 0 Then
                        For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                            TYPE = Split(chk_Filter_Field.CheckedItems(i), ".")
                            membertype = membertype & "'" & TYPE(0) & "', "
                        Next
                        membertype = Mid(membertype, 1, Len(membertype) - 2)

                    Else
                        MessageBox.Show("Select the Category(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        chk_Filter_Field.Focus()
                        Exit Sub
                    End If
                    If Rnd_Details.Checked = True Then
                        sqlstrinG = "Exec  PROC_MEMBER_CONSUMPTION_DET '" & month1 & "' "
                        gconnection.ExcuteStoreProcedure(sqlstrinG)
                    End If
                    ' sqlstrinG = " SELECT ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT FROM bengal_monthbill b, membermaster m where b.mcode=m.mcode and LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") and month(b.billdate)=" & month1 & "  and ISNULL(m.CONTEMAIL,'') <> '' AND ISNULL(m.CONTEMAIL,'') <> 'x' AND (m.MCODE LIKE 'B%' OR m.MCODE LIKE 'T%') AND ISNULL(m.CURENTSTATUS,'') IN ('ACTIVE','LIVE') AND ISNULL(m.FREEZE,'') <> 'Y' AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") ORDER BY b.MCODE "
                    sqlstrinG = " SELECT ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT FROM bengal_monthbill b, membermaster m where b.mcode=m.mcode and LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") and month(b.billdate)=" & month1 & "  and ISNULL(m.CONTEMAIL,'') <> '' AND ISNULL(m.CONTEMAIL,'') <> 'x' AND ISNULL(m.CURENTSTATUS,'') IN ('LIVE','ACTIVE','SUSPENDED','POSTED') AND ISNULL(m.FREEZE,'') <> 'Y' AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") ORDER BY b.MCODE "
                    gconnection.getDataSet(sqlstrinG, "member")
                    If gdataset.Tables("member").Rows.Count > 0 Then
                        For i = 0 To gdataset.Tables("member").Rows.Count - 1
                            mcode = gdataset.Tables("member").Rows(i).Item("mcode")
                            If mcode <> "" Then
                                If Rnd_Summary.Checked = True Then
                                    Dim FILEPATH As String
                                    Dim AFILE As File
                                    'FILEPATH = gpdf & "\" & year & "\" & mcode.Replace("*", " ") & "-" & PDFDATE & "bill.PDF"
                                    FILEPATH = gpdf & "\" & year & "\" & mcode.Replace("/", "_") & "-" & PDFDATE & "bill.PDF"
                                    'FILEPATH = gpdf & "\" & year & "\" & mcode.Replace("/", "_") & "-" & PDFDATE & "checklist.PDF"
                                    If AFILE.Exists(FILEPATH) Then
                                    Else
                                        Call BILLDETAILS(mcode, year)
                                    End If
                                Else
                                    Dim FILEPATH As String
                                    Dim AFILE As File
                                    'FILEPATH = gpdf & "\" & year & "\" & mcode.Replace("*", " ") & "-" & PDFDATE & "bill.PDF"
                                    FILEPATH = gpdf & "\" & year & "\" & mcode.Replace("/", "_") & "-" & PDFDATE & "checklist.PDF"
                                    If AFILE.Exists(FILEPATH) Then
                                    Else
                                        Call BILLDETAILS(mcode, year)
                                    End If
                                    ' Call BILLDETAILS(mcode, year)
                                End If
                                'Call BILLDETAILS(mcode, year)
                            End If
                        Next i
                    End If

                End If
            End If
            MessageBox.Show("Month Bill Successfully Created")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BILLDETAILS(ByVal MCODE As String, ByVal YEAR As String)
        Try
            Dim r
            If Rnd_Summary.Checked = True Then
                Dim cmdText, billdt2, PDFDATE As String
                Dim duedate, membertype, TYPE(0), month, sql, sqlstrinG, month2 As String
                Dim bLeapYear As Boolean
                bLeapYear = Date.IsLeapYear(gFinancialyearEnd)

                Dim opl, i As Integer
                Call Validation()
                If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : month = "APR" : noofdays = 30 : bildt = "01/apr/" & gFinancalyearStart : month2 = "04" : billdt2 = "30/apr/" & gFinancalyearStart : PDFDATE = "APRIL-" & gFinancalyearStart
                If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : month = "MAY" : noofdays = 31 : bildt = "01/may/" & gFinancalyearStart : month2 = "05" : billdt2 = "31/may/" & gFinancalyearStart : PDFDATE = "MAY-" & gFinancalyearStart
                If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : month = "JUN" : noofdays = 30 : bildt = "01/jun/" & gFinancalyearStart : month2 = "06" : billdt2 = "30/jun/" & gFinancalyearStart : PDFDATE = "JUNE-" & gFinancalyearStart
                If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : month = "JUL" : noofdays = 31 : bildt = "01/jul/" & gFinancalyearStart : month2 = "07" : billdt2 = "31/jul/" & gFinancalyearStart : PDFDATE = "JULY-" & gFinancalyearStart
                If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : month = "AUG" : noofdays = 31 : bildt = "01/aug/" & gFinancalyearStart : month2 = "08" : billdt2 = "31/aug/" & gFinancalyearStart : PDFDATE = "AUGUST-" & gFinancalyearStart
                If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : month = "SEP" : noofdays = 30 : bildt = "01/sep/" & gFinancalyearStart : month2 = "09" : billdt2 = "30/sep/" & gFinancalyearStart : PDFDATE = "SEPTEMBER-" & gFinancalyearStart
                If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : month = "OCT" : noofdays = 31 : bildt = "01/oct/" & gFinancalyearStart : month2 = "10" : billdt2 = "31/oct/" & gFinancalyearStart : PDFDATE = "OCTOBER-" & gFinancalyearStart
                If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : month = "NOV" : noofdays = 30 : bildt = "01/nov/" & gFinancalyearStart : month2 = "11" : billdt2 = "30/nov/" & gFinancalyearStart : PDFDATE = "NOVEMBER-" & gFinancalyearStart
                If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : month = "DEC" : noofdays = 31 : bildt = "01/dec/" & gFinancalyearStart : month2 = "12" : billdt2 = "31/dec/" & gFinancalyearStart : PDFDATE = "DECEMBER-" & gFinancalyearStart
                If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : month = "JAN" : noofdays = 31 : bildt = "01/jan/" & gFinancialyearEnd : month2 = "01" : billdt2 = "31/jan/" & gFinancialyearEnd : PDFDATE = "JANUARY-" & gFinancialyearEnd
                If bLeapYear = True Then
                    If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : month = "FEB" : noofdays = 29 : bildt = "01/feb/" & gFinancialyearEnd : month2 = "02" : billdt2 = "29/feb/" & gFinancialyearEnd : PDFDATE = "FEBRUARY-" & gFinancialyearEnd
                Else
                    If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : month = "FEB" : noofdays = 28 : bildt = "01/feb/" & gFinancialyearEnd : month2 = "02" : billdt2 = "28/feb/" & gFinancialyearEnd : PDFDATE = "FEBRUARY-" & gFinancialyearEnd
                End If
                '  If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : month = "FEB" : noofdays = 28 : bildt = "01/feb/" & gFinancialyearEnd : month2 = "02" : billdt2 = "28/feb/" & gFinancialyearEnd : PDFDATE = "FEBRUARY-" & gFinancialyearEnd
                If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : month = "MAR" : noofdays = 31 : bildt = "01/mar/" & gFinancialyearEnd : month2 = "03" : billdt2 = "31/mar/" & gFinancialyearEnd : PDFDATE = "MARCH-" & gFinancialyearEnd
                Dim Viewer As New REPORTVIEWER
                ' r = New billing
                If Mid(UCase(Trim(gcompanyname)), 1, 3) = "MLA" Then
                    r = New CRY_GOLFMONTHBILLSUMMARY
                    sqlstrinG = " SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M WHERE M.MCODE = O.SLCODE AND M.MCODE = '" & MCODE & "' AND O.BILLDATE < '" & bildt & "' AND  CURENTSTATUS IN('LIVE','ACTIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE ORDER BY M.MCODE "
                    sqlstring1 = " select substring(billno,1,2) as billno,billdate,slcode,locdesc,sum(dramount) as dramount,sum(cramount) as cramount,Isnull(instrumentno,'')as instrumentno,isnull(instrumentdate,'')as instrumentdate,isnull(loccode,'')as loccode "
                    sqlstring1 = sqlstring1 & "FROM View_Rec_Det WHERE LTRIM(RTRIM(SLCODE)) = '" & MCODE & "' AND MONTH(BILLDATE) = " & month1 & " GROUP BY billno,SLCODE,locdesc ,instrumentno,instrumentdate,loccode,billdate order by billdate"
                    ssql2 = " SELECT SNO,SLCODE,UPPER(HEADDESC) AS HEADDESC,SUM(DRAMOUNT) AS DRAMOUNT,SUM(CRAMOUNT) AS CRAMOUNT,SUM(TAX) AS TAX,SUM(VAT) AS VAT,SUM(TIPS) AS TIPS  FROM View_Pos_Summary WHERE MONTH(BILLDATE) = " & month1 & " AND SLCODE = '" & MCODE & "' GROUP BY SLCODE,HEADDESC,SNO ORDER BY SNO "
                    ' sqlstring2 = "select * from MEMBERSSETUP"

                    gconnection.getDataSet(sqlstrinG, "MEMBERMASTER")
                    gconnection.getDataSet(sqlstring1, "View_Rec_Det")
                    gconnection.getDataSet(ssql2, "View_Pos_Summary")
                    ' gconnection.getDataSet(sqlstring2, "MEMBERSSETUP")
                    Call Viewer.GetDetails1(sqlstrinG, "MEMBERMASTER", r)
                    Call Viewer.GetDetails1(sqlstring1, "View_Rec_Det", r)
                    ' Call Viewer.GetDetails1(sqlstring2, "MEMBERSSETUP", r)
                    Call Viewer.GetDetails1(ssql2, "View_Pos_Summary", r)
                    Dim txtobj1 As TextObject
                    Dim txtobj As TextObject

                    Dim txtobj15 As TextObject
                    Dim txtobj18 As TextObject
                    Dim txtobj19 As TextObject
                    Dim txtobj20 As TextObject
                    Dim txtobj21 As TextObject
                    Dim ADD1, ADD2, ADD3, ADD4 As String

                    Dim txtobj2 As TextObject


                    txtobj19 = r.ReportDefinition.ReportObjects("Text19")
                    'txtobj15 = r.ReportDefinition.ReportObjects("Text2")
                    txtobj18 = r.ReportDefinition.ReportObjects("Text18")
                    txtobj20 = r.ReportDefinition.ReportObjects("Text20")
                    'txtobj21 = r.ReportDefinition.ReportObjects("Text5")
                    txtobj2 = r.ReportDefinition.ReportObjects("Text28")

                    'txtobj1.Text = ADD1
                    Dim MBILLDATE As Date
                    MBILLDATE = billdt2
                    If MBILLDATE > "30-jun-2017" Then
                        txtobj1 = r.ReportDefinition.ReportObjects("Text7")
                        txtobj1.Text = "CGST"
                        txtobj1 = r.ReportDefinition.ReportObjects("Text11")
                        txtobj1.Text = "SGST"
                        txtobj1 = r.ReportDefinition.ReportObjects("Text13")
                        txtobj1.Text = "CESS"
                    End If
                    txtobj1 = r.ReportDefinition.ReportObjects("Text29")
                    txtobj1.Text = UCase(gcompanyname)
                    txtobj1 = r.ReportDefinition.ReportObjects("Text30")
                    txtobj1.Text = UCase(gCompanyAddress(0))
                    txtobj1 = r.ReportDefinition.ReportObjects("Text32")
                    txtobj1.Text = UCase(gCompanyAddress(1))
                    txtobj1 = r.ReportDefinition.ReportObjects("Text3")
                    txtobj1.Text = UCase(gCompanyAddress(2)) + " , " + UCase(gCompanyAddress(3))
                    'txtobj18.Text = bildt
                    txtobj19.Text = billdt2
                    'txtobj19.Text = "01/" & IIf(month1 > 9, Str(month1), "0" & month1) & "/" & IIf(month1 > 3, Mid(gFinancialyearStart, 7, 4), Mid(gFinancialyearEnd, 7, 4))
                    'txtobj18.Text = noofdays & "/" & IIf(month1 > 9, Str(month1), "0" & month1) & "/" & IIf(month1 > 3, Mid(gFinancialyearStart, 7, 4), Mid(gFinancialyearEnd, 7, 4))
                    txtobj20.Text = " Opening Balance as on " & bildt
                    'txtobj15.Text = " Total Due/Credit as on " & BILDT1
                    txtobj2.Text = UCase(Format(CbxMonth.Value, "MMM-yyyy"))
                    'txtobj21.Text = Format(DTPduedate.Value, "dd/MM/yyyy")
                    'ssql = "SELECT ISNULL(NOTES,'') AS NOTES FROM MEMBERSSETUP"
                    'gconnection.getDataSet(ssql, "ADD1")
                    'If gdataset.Tables("ADD1").Rows.Count > 0 Then

                    '    If gdataset.Tables("ADD1").Rows(0).Item("NOTES") <> "" Then
                    '        '  txtobj15 = r.ReportDefinition.ReportObjects("Text4")
                    '        ' txtobj15.Text = gdataset.Tables("ADD1").Rows(0).Item("NOTES")

                    '    Else
                    '        ' txtobj15 = r.ReportDefinition.ReportObjects("Text4")
                    '        ' txtobj15.Text = ""
                    '    End If
                    'Else
                    '    'txtobj15 = r.ReportDefinition.ReportObjects("Text4")
                    '    ' txtobj15.Text = ""
                    'End If
                    Viewer.Show()
                    Dim FILEPATH As String
                    Dim AFILE As File
                    'FILEPATH = gpdf & "\" & YEAR & "\" & MCODE.Replace("*", " ") & "-" & PDFDATE & "bill.PDF"
                    FILEPATH = gpdf & "\" & YEAR & "\" & MCODE.Replace("/", "_") & "-" & PDFDATE & "bill.PDF"
                    If AFILE.Exists(FILEPATH) Then
                        AFILE.Delete(FILEPATH)
                    End If
                    Dim CREXPORTOPTIONS As ExportOptions
                    Dim CRDISKFILEDESTINATIONOPTIONS As New DiskFileDestinationOptions()
                    Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
                    CRDISKFILEDESTINATIONOPTIONS.DiskFileName = FILEPATH
                    CREXPORTOPTIONS = r.ExportOptions
                    With CREXPORTOPTIONS
                        .ExportDestinationType = ExportDestinationType.DiskFile
                        .ExportFormatType = ExportFormatType.PortableDocFormat
                        '.ExportFormatType = ExportFormatType.WordForWindows                   
                        .DestinationOptions = CRDISKFILEDESTINATIONOPTIONS
                        .FormatOptions = CrFormatTypeOptions
                    End With

                    r.Export()
                    'sqlString = "SELECT CONTEMAIL FRO"            'EMAIL = "blasters11@gmail.com"            'gconnection.Mail(EMAIL, FILEPATH, MESSAGE, filename, files)           
                    r.Dispose()
                    Viewer.Close()
                    Viewer.Dispose()
                Else

                    r = New CCLbilling

                    'sqlstrinG = " SELECT ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(ADJUSTMENT,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE,ISNULL(BILLDATE,'') AS BILLDATE FROM bengal_monthbill b , membermaster m   where b.mcode=m.mcode and b.MCODE ='" & MCODE & "' and month(b.billdate)=" & month1 & "  ORDER BY b.MCODE "
                    'sqlstrinG = " SELECT ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(ADJUSTMENT,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE,ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(BILLNO,'') AS OUTSTANDING FROM bengal_monthbill b , membermaster m   where b.mcode=m.mcode and b.MCODE ='" & MCODE & "' and month(b.billdate)=" & month1 & "  ORDER BY b.MCODE "
                    sqlstrinG = " SELECT ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(t.vat,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(t.WBST,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE,ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(BILLNO,'') AS OUTSTANDING FROM bengal_monthbill b , membermaster m,VW_WBST T     where b.mcode=m.mcode and b.mcode=t.mcode and month(b.billdate)=t.kotdate and b.MCODE ='" & MCODE & "' and month(b.billdate)=" & month1 & "  ORDER BY b.MCODE "
                    'sqlstrinG = " SELECT ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(ADJUSTMENT,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE FROM bengal_monthbill b, membermaster m where b.mcode=m.mcode and substring(B.MCODE,1,2)+substring('00000000000',1,11-(len(B.MCODE)))+substring(B.MCODE,3,len(B.MCODE)-2) between substring('" & txt_mcode.Text & "',1,2)+substring('00000000000',1,11-(len('" & txt_mcode.Text & "')))+substring('" & txt_mcode.Text & "',3,len('" & txt_mcode.Text & "')-2)  and  substring('" & txt_Tomcode.Text & "',1,2)+substring('00000000000',1,11-(len('" & txt_Tomcode.Text & "')))+substring('" & txt_Tomcode.Text & "',3,len('" & txt_Tomcode.Text & "')-2) and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") order by SUBSTRING(M.MCODE,1,2),LEN(M.MCODE),M.MCODE "

                    'sql = "select isnull(billdetails,'') as billdetails,ISNULL(POSDESC,'') AS POSDESC,isnull(kotdate,'') as kotdate,isnull(mcode,'')as mcode,isnull(amount,0) as amount,isnull(vat,0) as vat,isnull(service_tax,0) as service_tax,isnull(service_charge,0) as service_charge from member_consumption where MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(kotdate)= " & month1 & "  ORDER BY MCODE "

                    'sql = "SELECT ISNULL(POSCODE,0) AS POSCODE,ISNULL(POSDESC,'') AS POSDESC,ISNULL(MCODE,'') AS MCODE,SUM(AMOUNT) AS AMOUNT,SUM(VAT) AS VAT,SUM(SERVICE_TAX) AS SERVICE_TAX,SUM(SERVICE_CHARGE) AS SERVICE_CHARGE FROM MEMBER_CONSUMPTION1 where MCODE ='" & MCODE & "' and month(kotdate)= " & month1 & "  GROUP BY POSDESC,POSCODE,mcode  ORDER BY MCODE"
                    sql = "SELECT ISNULL(POSCODE,0) AS POSCODE,ISNULL(POSDESC,'') AS POSDESC,ISNULL(MCODE,'') AS MCODE,SUM(AMOUNT) AS AMOUNT,SUM(VAT) AS VAT,SUM(SERVICE_TAX) AS SERVICE_TAX,SUM(SERVICE_CHARGE) AS SERVICE_CHARGE FROM MEMBER_CONSUMPTION where MCODE ='" & MCODE & "' and month(kotdate)= " & month1 & "  GROUP BY POSDESC,POSCODE,mcode,SNO  ORDER BY MCODE,SNO"
                    ' sql = "SELECT ISNULL(POSCODE,0) AS POSCODE,ISNULL(POSDESC,'') AS POSDESC,ISNULL(MCODE,'') AS MCODE,SUM(AMOUNT) AS AMOUNT,SUM(VAT) AS VAT,SUM(SERVICE_TAX) AS SERVICE_TAX,SUM(SERVICE_CHARGE) AS SERVICE_CHARGE FROM MEMBER_CONSUMPTION B where substring(B.MCODE,1,2)+substring('00000000000',1,11-(len(B.MCODE)))+substring(B.MCODE,3,len(B.MCODE)-2)  between substring('" & txt_mcode.Text & "',1,2)+substring('00000000000',1,11-(len('" & txt_mcode.Text & "')))+substring('" & txt_mcode.Text & "',3,len('" & txt_mcode.Text & "')-2)  and  substring('" & txt_Tomcode.Text & "',1,2)+substring('00000000000',1,11-(len('" & txt_Tomcode.Text & "')))+substring('" & txt_Tomcode.Text & "',3,len('" & txt_Tomcode.Text & "')-2) and month(kotdate)= " & month1 & "  GROUP BY POSDESC,POSCODE,B.mcode,B.Sno  ORDER BY B.MCODE,B.Sno"

                    'sql = "SELECT ISNULL(POSCODE,0) AS POSCODE,ISNULL(POSDESC,'') AS POSDESC,ISNULL(MCODE,'') AS MCODE,SUM(AMOUNT) AS AMOUNT,SUM(VAT) AS VAT,SUM(SERVICE_TAX) AS SERVICE_TAX,SUM(SERVICE_CHARGE) AS SERVICE_CHARGE FROM MEMBER_CONSUMPTION where MCODE ='" & MCODE & "' and month(kotdate)= " & month1 & "  GROUP BY POSDESC,POSCODE,mcode  ORDER BY MCODE"
                    'sqlstring3 = " select mcode,SUM(isnull(BRAMOUNT,0)) as BRAMOUNT,SUM(isnull(CRAMOUNT ,0)) as CRAMOUNT,SUM(isnull(CCRAMOUNT,0)) as CCRAMOUNT,SUM(isnull(CCNAMOUNT,0)) as CCNAMOUNT,SUM(isnull(CDNAMOUNT,0)) as CDNAMOUNT "
                    'sqlstring3 = sqlstring3 & " FROM View_DRCR_SUM WHERE mcode BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(BILLDATE) = " & month1 & " GROUP BY mcode "
                    sqlstring3 = " select mcode,SUM(isnull(BRAMOUNT,0)) as BRAMOUNT,SUM(isnull(CRAMOUNT ,0)) as CRAMOUNT,SUM(isnull(CCRAMOUNT,0)) as CCRAMOUNT,SUM(isnull(CCNAMOUNT,0)) as CCNAMOUNT,SUM(isnull(CDNAMOUNT,0)) as CDNAMOUNT "
                    sqlstring3 = sqlstring3 & " FROM View_DRCR_SUM WHERE mcode = '" & MCODE & "' AND MONTH(BILLDATE) = " & month1 & " GROUP BY mcode "


                    Call Viewer.GetDetails1(sql, "member_consumption", r)
                    Call Viewer.GetDetails1(sqlstrinG, "bengal_monthbill", r)
                    Call Viewer.GetDetails2(sqlstring3, "View_DRCR_SUM", r)

                    Dim name, add1, add2, add3, city, state, pin, cell As String


                    Dim txtobj15 As TextObject
                    Dim txtobj19 As TextObject
                    Dim txtobj20 As TextObject
                    Dim txtobj1 As TextObject
                    'txtobj1 = r.ReportDefinition.ReportObjects("Text2")
                    'duedt = DTPduedate.Value
                    'txtobj1.Text = Format(duedt, "dd/MMM/yyyy")
                    Dim duedt As Date
                    txtobj1 = r.ReportDefinition.ReportObjects("Text2")
                    duedt = DTPduedate.Value
                    txtobj1.Text = Format(duedt, "dd/MMM/yyyy")

                    'txtobj19 = r.ReportDefinition.ReportObjects("Text20")
                    'txtobj19.Text = month & " " & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))

                    'Dim convdate As Date
                    'txtobj20 = r.ReportDefinition.ReportObjects("Text24")
                    'convdate = noofdays & "-" & IIf(month1 > 9, Str(month1), "0" & month1) & "-" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))
                    'txtobj20.Text = Format(convdate, "dd MMM yyyy")

                    'txtobj15 = r.ReportDefinition.ReportObjects("Text22")
                    'txtobj15.Text = "/" & month & "/" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4)) & "/Regular"


                    'txtobj19 = r.ReportDefinition.ReportObjects("Text31")
                    'txtobj19.Text = month & " " & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))

                    ''Dim convdate1 As Date
                    'txtobj20 = r.ReportDefinition.ReportObjects("Text35")
                    'convdate = noofdays & "-" & IIf(month1 > 9, Str(month1), "0" & month1) & "-" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))
                    'txtobj20.Text = Format(convdate, "dd MMM yyyy")

                    'txtobj15 = r.ReportDefinition.ReportObjects("Text33")
                    'txtobj15.Text = "/" & month & "/" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4)) & "/Regular"

                    'Dim txtobj18 As TextObject
                    'txtobj18 = r.ReportDefinition.ReportObjects("Text5")
                    'txtobj18.Text = noofdays & "-" & IIf(month1 > 9, Str(month1), "0" & month1) & "-" & IIf(month1 > 3, gfinancalyearstart, Mid(gFinancialyearEnd,1, 4))


                    'Dim txtobj1 As TextObject
                    'Dim duedt As Date
                    'txtobj1 = r.ReportDefinition.ReportObjects("Text27")
                    'duedt = DTPduedate.Value
                    'txtobj1.Text = Format(duedt, "dd.MM.yyyy")



                    'txtobj15.Text = UCase(gUsername)
                    Viewer.Show()
                    Dim FILEPATH As String
                    Dim AFILE As File
                    'FILEPATH = gpdf & "\" & YEAR & "\" & MCODE.Replace("*", " ") & "-" & PDFDATE & "bill.PDF"
                    FILEPATH = gpdf & "\" & YEAR & "\" & MCODE.Replace("/", "_") & "-" & PDFDATE & "bill.PDF"
                    If AFILE.Exists(FILEPATH) Then
                        AFILE.Delete(FILEPATH)
                    End If
                    Dim CREXPORTOPTIONS As ExportOptions
                    Dim CRDISKFILEDESTINATIONOPTIONS As New DiskFileDestinationOptions()
                    Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
                    CRDISKFILEDESTINATIONOPTIONS.DiskFileName = FILEPATH
                    CREXPORTOPTIONS = r.ExportOptions
                    With CREXPORTOPTIONS
                        .ExportDestinationType = ExportDestinationType.DiskFile
                        .ExportFormatType = ExportFormatType.PortableDocFormat
                        '.ExportFormatType = ExportFormatType.WordForWindows                   
                        .DestinationOptions = CRDISKFILEDESTINATIONOPTIONS
                        .FormatOptions = CrFormatTypeOptions
                    End With

                    r.Export()
                    'sqlString = "SELECT CONTEMAIL FRO"            'EMAIL = "blasters11@gmail.com"            'gconnection.Mail(EMAIL, FILEPATH, MESSAGE, filename, files)           
                    r.Dispose()
                    Viewer.Close()
                    Viewer.Dispose()
                End If
            Else
                Dim cmdText As String
                Dim duedate, membertype, TYPE(0), bildt1, MONTH, BILLDT2, MONTH2, PDFDATE, BILDT3, BILLDT4 As String
                Dim opl, i As Integer
                Call Validation()
                If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : MONTH = "APR" : noofdays = 30 : bildt = "01/apr/" & gFinancalyearStart : MONTH2 = "04" : BILLDT2 = "30/apr/" & gFinancalyearStart : PDFDATE = "APRIL-" & gFinancalyearStart : BILDT3 = "01/04/" & gFinancalyearStart : BILLDT4 = "30/04/" & gFinancalyearStart
                If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : MONTH = "MAY" : noofdays = 31 : bildt = "01/may/" & gFinancalyearStart : MONTH2 = "05" : BILLDT2 = "31/may/" & gFinancalyearStart : PDFDATE = "MAY-" & gFinancalyearStart : BILDT3 = "01/05/" & gFinancalyearStart : BILLDT4 = "31/05/" & gFinancalyearStart
                If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : MONTH = "JUN" : noofdays = 30 : bildt = "01/jun/" & gFinancalyearStart : MONTH2 = "06" : BILLDT2 = "30/jun/" & gFinancalyearStart : PDFDATE = "JUNE-" & gFinancalyearStart : BILDT3 = "01/06/" & gFinancalyearStart : BILLDT4 = "30/06/" & gFinancalyearStart
                If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : MONTH = "JUL" : noofdays = 31 : bildt = "01/jul/" & gFinancalyearStart : MONTH2 = "07" : BILLDT2 = "31/jul/" & gFinancalyearStart : PDFDATE = "JULY-" & gFinancalyearStart : BILDT3 = "01/07/" & gFinancalyearStart : BILLDT4 = "31/07/" & gFinancalyearStart
                If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : MONTH = "AUG" : noofdays = 31 : bildt = "01/aug/" & gFinancalyearStart : MONTH2 = "08" : BILLDT2 = "31/aug/" & gFinancalyearStart : PDFDATE = "AUGUST-" & gFinancalyearStart : BILDT3 = "01/08/" & gFinancalyearStart : BILLDT4 = "31/08/" & gFinancalyearStart
                If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : MONTH = "SEP" : noofdays = 30 : bildt = "01/sep/" & gFinancalyearStart : MONTH2 = "09" : BILLDT2 = "30/sep/" & gFinancalyearStart : PDFDATE = "SEPTEMBER-" & gFinancalyearStart : BILDT3 = "01/09/" & gFinancalyearStart : BILLDT4 = "30/09/" & gFinancalyearStart
                If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : MONTH = "OCT" : noofdays = 31 : bildt = "01/oct/" & gFinancalyearStart : MONTH2 = "10" : BILLDT2 = "31/oct/" & gFinancalyearStart : PDFDATE = "OCTOBER-" & gFinancalyearStart : BILDT3 = "01/10/" & gFinancalyearStart : BILLDT4 = "31/10/" & gFinancalyearStart
                If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : MONTH = "NOV" : noofdays = 30 : bildt = "01/nov/" & gFinancalyearStart : MONTH2 = "11" : BILLDT2 = "30/nov/" & gFinancalyearStart : PDFDATE = "NOVEMBER-" & gFinancalyearStart : BILDT3 = "01/11/" & gFinancalyearStart : BILLDT4 = "30/11/" & gFinancalyearStart
                If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : MONTH = "DEC" : noofdays = 31 : bildt = "01/dec/" & gFinancalyearStart : MONTH2 = "12" : BILLDT2 = "31/dec/" & gFinancalyearStart : PDFDATE = "DECEMBER-" & gFinancalyearStart : BILDT3 = "01/12/" & gFinancalyearStart : BILLDT4 = "31/12/" & gFinancalyearStart
                If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : MONTH = "JAN" : noofdays = 31 : bildt = "01/jan/" & gFinancialyearEnd : MONTH2 = "01" : BILLDT2 = "31/jan/" & gFinancialyearEnd : PDFDATE = "JANUARY-" & gFinancialyearEnd : BILDT3 = "01/01/" & gFinancialyearEnd : BILLDT4 = "31/01/" & gFinancialyearEnd
                If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : MONTH = "FEB" : noofdays = 28 : bildt = "01/feb/" & gFinancialyearEnd : MONTH2 = "02" : BILLDT2 = "28/feb/" & gFinancialyearEnd : PDFDATE = "FEBRUARY-" & gFinancialyearEnd : BILDT3 = "01/02/" & gFinancialyearEnd : BILLDT4 = "28/02/" & gFinancialyearEnd
                If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : MONTH = "MAR" : noofdays = 31 : bildt = "01/mar/" & gFinancialyearEnd : MONTH2 = "03" : BILLDT2 = "31/mar/" & gFinancialyearEnd : PDFDATE = "MARCH-" & gFinancialyearEnd : BILDT3 = "01/03/" & gFinancialyearEnd : BILLDT4 = "31/03/" & gFinancialyearEnd

                Dim Viewer As New REPORTVIEWER
                If Rnd_Details.Checked = True Then
                    'r = New Cry_Det
                    ' r = New CCLCry_Det
                    Dim txtobj15 As TextObject
                    Dim txtobj19 As TextObject
                    Dim txtobj20 As TextObject
                    Dim TXTOBJ21 As TextObject
                    Dim convdate As Date
                    If Mid(UCase(Trim(gcompanyname)), 1, 3) = "MLA" Then
                        r = New CCLCry_Det_MLA
                        

                    If Trim(txt_Tomcode.Text) <> "" And Trim(txt_Tomcode.Text) <> "" Then
                        sqlstring = "SELECT  DISTINCT ISNULL(MCODE,'') as MCODE from member_consumption_dettab WHERE  MONTH(KOTDATE) = '" & month1 & "' "
                        gconnection.getDataSet(sqlstring, "CheckData")
                        If gdataset.Tables("CheckData").Rows.Count > 0 Then
                        Else
                            sqlstring = "Exec  PROC_MEMBER_CONSUMPTION_DET '" & month1 & "' "
                            gconnection.ExcuteStoreProcedure(sqlstring)
                        End If
                        'sqlstring = "select isnull(qty,0) as qty,isnull(rate,0) as rate,isnull(poscode,'') as poscode,isnull(billdetails,'') as billdetails,cast(convert(varchar(11),kotdate,106) as datetime) as kotdate,isnull(itemdesc,'') as itemdesc,SUM(isnull(amount,0)) AS AMOUNT,SUM(isnull(vat,0)) as vat,SUM(isnull(service_tax,0)) as service_tax,SUM(isnull(service_charge,0)) as service_charge,m.mcode,m.mname as posdesc from member_consumption_det t,membermaster m where t.mcode=m.mcode and LTRIM(RTRIM(m.MCODE)) BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(KOTDATE) = " & MONTH2 & ""
                        'sqlstring = sqlstring & " group by qty,rate,billdetails,cast(convert(varchar(11),kotdate,106) as datetime),itemdesc,poscode,m.mcode,m.mname "
                        'sqlstring = "select isnull(qty,0) as qty,isnull(rate,0) as rate,isnull(poscode,'') as poscode,isnull(billdetails,'') as billdetails,cast(convert(varchar(11),kotdate,106) as datetime) as kotdate,isnull(itemdesc,'') as itemdesc,SUM(isnull(amount,0)) AS AMOUNT,SUM(isnull(vat,0)) as vat,SUM(isnull(service_tax,0)) as service_tax,SUM(isnull(service_charge,0)) as service_charge,m.mcode,m.mname as posdesc from member_consumption_det t,membermaster m where t.mcode=m.mcode and LTRIM(RTRIM(m.MCODE)) BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(KOTDATE) = " & MONTH2 & ""
                        'sqlstring = "select isnull(qty,0) as qty,isnull(rate,0) as rate,isnull(poscode,'') as poscode,isnull(billdetails,'') as billdetails,cast(convert(varchar(11),kotdate,106) as datetime) as kotdate,isnull(itemdesc,'') as itemdesc,SUM(isnull(amount,0)) AS AMOUNT,SUM(isnull(vat,0)) as vat,SUM(isnull(service_tax,0)) as service_tax,SUM(isnull(service_charge,0)) as service_charge,m.mcode,m.mname as posdesc from member_consumption_det t,membermaster m where t.mcode=m.mcode and LTRIM(RTRIM(m.MCODE)) like '" & txt_mcode.Text & "%' AND MONTH(KOTDATE) = " & MONTH2 & ""
                        'sqlstring = "select isnull(qty,0) as qty,isnull(rate,0) as rate,isnull(poscode,'') as poscode,isnull(billdetails,'') as billdetails,cast(convert(varchar(11),kotdate,106) as datetime) as kotdate,isnull(itemdesc,'') as itemdesc,SUM(isnull(amount,0)) AS AMOUNT,SUM(isnull(vat,0)) as vat,SUM(isnull(service_tax,0)) as service_tax,SUM(isnull(service_charge,0)) as service_charge,m.mcode,m.mname as posdesc from member_consumption_det t,membermaster m where t.mcode=m.mcode and substring(M.MCODE,1,2)+substring('00000000000',1,11-(len(M.MCODE)))+substring(M.MCODE,3,len(M.MCODE)-2) between substring('" & txt_mcode.Text & "',1,2)+substring('00000000000',1,11-(len('" & txt_mcode.Text & "')))+substring('" & txt_mcode.Text & "',3,len('" & txt_mcode.Text & "')-2)  and  substring('" & txt_Tomcode.Text & "',1,2)+substring('00000000000',1,11-(len('" & txt_Tomcode.Text & "')))+substring('" & txt_Tomcode.Text & "',3,len('" & txt_Tomcode.Text & "')-2) AND MONTH(KOTDATE) = " & MONTH2 & ""
                        'sqlstring = sqlstring & " group by qty,rate,billdetails,cast(convert(varchar(11),kotdate,106) as datetime),itemdesc,poscode,m.mcode,m.mname order by SUBSTRING(M.MCODE,1,2),LEN(M.MCODE),M.MCODE"
                            sqlstring = "select sum(isnull(qty,0)) as qty,isnull(rate,0) as rate,isnull(poscode,'') as poscode,isnull(billdetails,'') as billdetails,cast(convert(varchar(11),kotdate,106) as datetime) as kotdate,isnull(itemdesc,'') as itemdesc,SUM(isnull(amount,0)) AS AMOUNT,SUM(isnull(vat,0)) as vat,SUM(isnull(service_tax,0)) as service_tax,SUM(isnull(service_charge,0)) as service_charge,m.mcode,m.mname as posdesc from member_consumption_dettab t,membermaster m where t.mcode=m.mcode and M.mcode = '" & MCODE & "' AND MONTH(KOTDATE) = " & MONTH2 & ""
                        sqlstring = sqlstring & " group by  rate,billdetails,cast(convert(varchar(11),kotdate,106) as datetime),itemdesc,poscode,m.mcode,m.mname order by M.MCODE"

                        sqlstring1 = "select t.mcode,ISNULL(t.billno ,'') as billno,  ISNULL(t.billdate ,'') as billdate, ISNULL(t.Instrumentno ,'') as Instrumentno , ISNULL(t.InstrumentType  ,'') as InstrumentType,ISNULL(t.Cramount  ,0) as Cramount,ISNULL(t.Dramount   ,0) as Dramount"
                            sqlstring1 = sqlstring1 & ",ISNULL(t.locdesc,'') as locdesc,ISNULL(t.Description ,'') as Description,ISNULL(t.CREDITDEBIT ,'') as CREDITDEBIT from View_Recipt_DetCCL t,membermaster m where t.mcode=m.mcode and M.mcode = '" & MCODE & "' AND MONTH(billdate) = " & MONTH2 & "order by  CREDITDEBIT"

                    Else
                        sqlstring = "Exec  PROC_MEMBER_CONSUMPTION_DET '" & month1 & "' "
                        gconnection.ExcuteStoreProcedure(sqlstring)

                        membertype = ""
                        If chk_Filter_Field.CheckedItems.Count > 0 Then
                            For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                                TYPE = Split(chk_Filter_Field.CheckedItems(i), ".")
                                membertype = membertype & "'" & TYPE(0) & "', "
                            Next
                            membertype = Mid(membertype, 1, Len(membertype) - 2)
                        Else
                            MessageBox.Show("Select the Category(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If
                        'sqlstring = "select ISNULL(POSCODE,'') AS POSCODE,isnull(qty,0) as qty,isnull(rate,0) as rate,isnull(billdetails,'') as billdetails,cast(convert(varchar(11),kotdate,106) as datetime) as kotdate,isnull(itemdesc,'') as itemdesc,SUM(isnull(amount,0)) AS AMOUNT,SUM(isnull(vat,0)) as vat,SUM(isnull(service_tax,0)) as service_tax,SUM(isnull(service_charge,0)) as service_charge,m.mcode,m.mname as posdesc from member_consumption_det t,membermaster m where t.mcode=m.mcode AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") AND MONTH(KOTDATE) = " & MONTH2 & ""
                        'sqlstring = sqlstring & " group by qty,rate,billdetails,cast(convert(varchar(11),kotdate,106) as datetime),itemdesc,poscode,m.mcode,m.mname"
                        'sqlstring = "select ISNULL(POSCODE,'') AS POSCODE,isnull(qty,0) as qty,isnull(rate,0) as rate,isnull(billdetails,'') as billdetails,cast(convert(varchar(11),kotdate,106) as datetime) as kotdate,isnull(itemdesc,'') as itemdesc,SUM(isnull(amount,0)) AS AMOUNT,SUM(isnull(vat,0)) as vat,SUM(isnull(service_tax,0)) as service_tax,SUM(isnull(service_charge,0)) as service_charge,m.mcode,m.mname as posdesc from member_consumption_det t,membermaster m where t.mcode=m.mcode AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") AND MONTH(KOTDATE) = " & MONTH2 & ""
                        'sqlstring = sqlstring & " group by qty,rate,billdetails,cast(convert(varchar(11),kotdate,106) as datetime),itemdesc,poscode,m.mcode,m.mname order by SUBSTRING(M.MCODE,1,2),LEN(M.MCODE),M.MCODE"
                            sqlstring = "select ISNULL(POSCODE,'') AS POSCODE,sum(isnull(qty,0)) as qty,isnull(rate,0) as rate,isnull(billdetails,'') as billdetails,cast(convert(varchar(11),kotdate,106) as datetime) as kotdate,isnull(itemdesc,'') as itemdesc,SUM(isnull(amount,0)) AS AMOUNT,SUM(isnull(vat,0)) as vat,SUM(isnull(service_tax,0)) as service_tax,SUM(isnull(service_charge,0)) as service_charge,m.mcode,m.mname as posdesc from member_consumption_dettab t,membermaster m where t.mcode=m.mcode AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") and m.mcode ='" & MCODE & "' AND MONTH(KOTDATE) = " & MONTH2 & ""
                        sqlstring = sqlstring & " group by  rate,billdetails,cast(convert(varchar(11),kotdate,106) as datetime),itemdesc,poscode,m.mcode,m.mname order by SUBSTRING(M.MCODE,1,2),LEN(M.MCODE),M.MCODE"
                        sqlstring1 = "select t.mcode,ISNULL(t.billno,'') as billno,  ISNULL(t.billdate,'') as billdate, ISNULL(t.Instrumentno,'') as Instrumentno , ISNULL(t.InstrumentType,'') as InstrumentType,ISNULL(t.Cramount,0) as Cramount,ISNULL(t.Dramount,0) as Dramount"
                            sqlstring1 = sqlstring1 & ",ISNULL(t.locdesc,'') as locdesc,ISNULL(t.Description ,'') as Description,ISNULL(t.CREDITDEBIT ,'') as CREDITDEBIT from View_Recipt_DetCCL t,membermaster m where t.mcode=m.mcode AND LTRIM(RTRIM(m.membertypecode)) IN (" & membertype & ") and m.mcode ='" & MCODE & "'  AND MONTH(billdate) = " & MONTH2 & "order by  CREDITDEBIT"
                    End If

                    Call Viewer.GetDetails1(sqlstring, "member_consumption_det", r)
                    Call Viewer.GetDetails2(sqlstring1, "View_Recipt_DetCCL", r)
                        'Dim txtobj15 As TextObject
                        'Dim txtobj19 As TextObject
                        'Dim txtobj20 As TextObject
                        'Dim TXTOBJ21 As TextObject
                    Dim TXTOBJ22 As TextObject
                    Dim TXTOBJ23 As TextObject
                    Dim TXTOBJ24 As TextObject

                    txtobj19 = r.ReportDefinition.ReportObjects("Text27")
                    txtobj19.Text = MONTH & " " & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))

                    TXTOBJ21 = r.ReportDefinition.ReportObjects("TEXT2")
                    TXTOBJ21.Text = "Bill Detail List Consumption In Regular PERIOD : " & BILDT3 & "-" & BILLDT4

                    txtobj20 = r.ReportDefinition.ReportObjects("Text31")
                    convdate = noofdays & "-" & IIf(month1 > 9, Str(month1), "0" & month1) & "-" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))
                    txtobj20.Text = Format(convdate, "dd MMM yyyy")

                    txtobj15 = r.ReportDefinition.ReportObjects("Text29")
                    txtobj15.Text = "/" & MONTH & "/" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4)) & "/Regular"
                    If bildt >= "01/jul/2017" Then
                        TXTOBJ22 = r.ReportDefinition.ReportObjects("Text20")
                        TXTOBJ22.Text = "CGST"
                        TXTOBJ23 = r.ReportDefinition.ReportObjects("Text19")
                        TXTOBJ23.Text = "SGST"
                        TXTOBJ24 = r.ReportDefinition.ReportObjects("Text5")
                        TXTOBJ24.Text = "CESS"
                    End If
                    '  Dim txtobj19 As TextObject

                    ' txtobj19 = r.ReportDefinition.ReportObjects("Text41")

                    'txtobj19.Text = "01/" & IIf(month1 > 9, Str(month1), "0" & month1) & "/" & IIf(month1 > 3, Mid(gFinancalyearStart,1,4), Mid(gFinancialyearEnd,1, 4))
                    ' txtobj19.Text = "Bill Details List Consumption Period: Billing Period " & bildt & " To  " & bildt1
                    'txtobj18.Text = noofdays & "/" & IIf(month1 > 9, Str(month1), "0" & month1) & "/" & IIf(month1 > 3, Mid(gFinancalyearStart,1,4), Mid(gFinancialyearEnd, 7, 4))
                    'txtobj20.Text = " You are requested to pay the due amount on or before :" & Format(DTPduedate.Value, "dd/MM/yyyy")
                    Viewer.Show()

                    Else
                        r = New CCLCry_Det


                        If Trim(txt_Tomcode.Text) <> "" And Trim(txt_Tomcode.Text) <> "" Then
                            sqlstring = "select isnull(qty,0) as qty,isnull(rate,0) as rate,isnull(poscode,'') as poscode,isnull(billdetails,'') as billdetails,cast(convert(varchar(11),kotdate,106) as datetime) as kotdate,isnull(itemdesc,'') as itemdesc,SUM(isnull(amount,0)) AS AMOUNT,SUM(isnull(vat,0)) as vat,SUM(isnull(service_tax,0)) as service_tax,SUM(isnull(service_charge,0)) as service_charge,m.mcode,m.mname as posdesc from member_consumption_det t,membermaster m where t.mcode=m.mcode and LTRIM(RTRIM(m.MCODE)) = '" & MCODE & "' AND MONTH(KOTDATE) = " & MONTH2 & ""
                            sqlstring = sqlstring & " group by qty,rate,billdetails,cast(convert(varchar(11),kotdate,106) as datetime),itemdesc,poscode,m.mcode,m.mname"
                        Else
                            sqlstring = "select isnull(qty,0) as qty,isnull(rate,0) as rate,isnull(poscode,'') as poscode,isnull(billdetails,'') as billdetails,cast(convert(varchar(11),kotdate,106) as datetime) as kotdate,isnull(itemdesc,'') as itemdesc,SUM(isnull(amount,0)) AS AMOUNT,SUM(isnull(vat,0)) as vat,SUM(isnull(service_tax,0)) as service_tax,SUM(isnull(service_charge,0)) as service_charge,m.mcode,m.mname as posdesc from member_consumption_dettab t,membermaster m where t.mcode=m.mcode and LTRIM(RTRIM(m.MCODE)) = '" & MCODE & "' AND MONTH(KOTDATE) = " & MONTH2 & ""
                            sqlstring = sqlstring & " group by qty,rate,billdetails,cast(convert(varchar(11),kotdate,106) as datetime),itemdesc,poscode,m.mcode,m.mname"
                        End If
                        'sqlstring1 = "select t.mcode,ISNULL(t.billno ,'') as billno,  ISNULL(t.billdate ,'') as billdate, ISNULL(t.Instrumentno ,'') as Instrumentno , ISNULL(t.InstrumentType  ,'') as InstrumentType,ISNULL(t.Cramount  ,0) as Cramount,ISNULL(t.Dramount   ,0) as Dramount"
                        'sqlstring1 = sqlstring1 & ",ISNULL(t.locdesc,'') as locdesc,ISNULL(t.Description ,'') as Description,ISNULL(t.CREDITDEBIT ,'') as CREDITDEBIT from View_Recipt_DetCCL t,membermaster m where t.mcode=m.mcode and M.mcode between '" & MCODE & "' and '" & MCODE & "' AND MONTH(billdate) = " & MONTH2 & "order by  CREDITDEBIT"
                        sqlstring1 = "select t.mcode,ISNULL(t.billno ,'') as billno,  ISNULL(t.billdate ,'') as billdate, ISNULL(t.Instrumentno ,'') as Instrumentno , ISNULL(t.InstrumentType  ,'') as InstrumentType,ISNULL(t.Cramount  ,0) as Cramount,ISNULL(t.Dramount   ,0) as Dramount"
                        sqlstring1 = sqlstring1 & ",ISNULL(t.locdesc,'') as locdesc,ISNULL(t.Description ,'') as Description,ISNULL(t.CREDITDEBIT ,'') as CREDITDEBIT from View_Recipt_DetCCL t,membermaster m where t.mcode=m.mcode and LTRIM(RTRIM(m.MCODE)) = '" & MCODE & "'  AND MONTH(billdate) = " & MONTH2 & "order by  CREDITDEBIT"
                    End If
                gconnection.getDataSet(sqlstring, "CheckData")
                If gdataset.Tables("CheckData").Rows.Count = 0 Then
                    Exit Sub
                End If

                Call Viewer.GetDetails1(sqlstring, "member_consumption_det", r)
                Call Viewer.GetDetails2(sqlstring1, "View_Recipt_DetCCL", r)
                'Dim txtobj15 As TextObject
                'Dim txtobj19 As TextObject
                'Dim txtobj20 As TextObject
                'txtobj19 = r.ReportDefinition.ReportObjects("Text27")
                'txtobj19.Text = MONTH & " " & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd,1, 4))

                'Dim convdate As Date
                'txtobj20 = r.ReportDefinition.ReportObjects("Text31")
                'convdate = noofdays & "-" & IIf(month1 > 9, Str(month1), "0" & month1) & "-" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd,1, 4))
                'txtobj20.Text = Format(convdate, "dd MMM yyyy")

                'txtobj15 = r.ReportDefinition.ReportObjects("Text29")
                'txtobj15.Text = "/" & MONTH & "/" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd,1, 4)) & "/Regular"

                    'Dim txtobj15 As TextObject
                    'Dim txtobj19 As TextObject
                    'Dim txtobj20 As TextObject
                    'Dim TXTOBJ21 As TextObject
                txtobj19 = r.ReportDefinition.ReportObjects("Text27")
                txtobj19.Text = MONTH & " " & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))

                TXTOBJ21 = r.ReportDefinition.ReportObjects("TEXT2")
                TXTOBJ21.Text = "Bill Detail List Consumption In Regular PERIOD : " & BILDT3 & "-" & BILLDT4
                    ' Dim convdate As Date
                txtobj20 = r.ReportDefinition.ReportObjects("Text31")
                convdate = noofdays & "-" & IIf(month1 > 9, Str(month1), "0" & month1) & "-" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))
                txtobj20.Text = Format(convdate, "dd MMM yyyy")

                txtobj15 = r.ReportDefinition.ReportObjects("Text29")
                txtobj15.Text = "/" & MONTH & "/" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4)) & "/Regular"



                '  Dim txtobj19 As TextObject

                ' txtobj19 = r.ReportDefinition.ReportObjects("Text41")

                'txtobj19.Text = "01/" & IIf(month1 > 9, Str(month1), "0" & month1) & "/" & IIf(month1 > 3, Mid(gFinancalyearStart,1,4), Mid(gFinancialyearEnd,1, 4))
                ' txtobj19.Text = "Bill Details List Consumption Period: Billing Period " & bildt & " To  " & bildt1
                'txtobj18.Text = noofdays & "/" & IIf(month1 > 9, Str(month1), "0" & month1) & "/" & IIf(month1 > 3, Mid(gFinancalyearStart,1,4), Mid(gFinancialyearEnd,1, 4))
                'txtobj20.Text = " You are requested to pay the due amount on or before :" & Format(DTPduedate.Value, "dd/MM/yyyy")
                    Viewer.Show()
                End If
                Dim FILEPATH As String
                Dim AFILE As File
                FILEPATH = gpdf & "\" & YEAR & "\" & MCODE.Replace("/", "_") & "-" & PDFDATE & "checklist.PDF"
                'FILEPATH = gpdf & "\" & YEAR & "\" & MCODE.Replace("*", " ") & "-" & PDFDATE & "checklist.PDF"
                'FILEPATH = gpdf & "\" & YEAR & "\" & MCODE.Replace("*", " ") & "_DET.PDF"
                If AFILE.Exists(FILEPATH) Then
                    AFILE.Delete(FILEPATH)
                End If
                Dim CREXPORTOPTIONS As ExportOptions
                Dim CRDISKFILEDESTINATIONOPTIONS As New DiskFileDestinationOptions()
                Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
                CRDISKFILEDESTINATIONOPTIONS.DiskFileName = FILEPATH
                CREXPORTOPTIONS = r.ExportOptions
                With CREXPORTOPTIONS
                    .ExportDestinationType = ExportDestinationType.DiskFile
                    .ExportFormatType = ExportFormatType.PortableDocFormat
                    '.ExportFormatType = ExportFormatType.WordForWindows                   
                    .DestinationOptions = CRDISKFILEDESTINATIONOPTIONS
                    .FormatOptions = CrFormatTypeOptions
                End With

                r.Export()
                'sqlString = "SELECT CONTEMAIL FRO"            'EMAIL = "blasters11@gmail.com"            'gconnection.Mail(EMAIL, FILEPATH, MESSAGE, filename, files)           
                r.Dispose()
                Viewer.Close()
                Viewer.Dispose()
            End If
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GroupBox1.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim cmdText, billdt2, BILDT4, BILDT5 As String
            Dim duedate, membertype, TYPE(0), month, sql, sqlstrinG, month2 As String
            Dim opl, i As Integer
            Dim BILDATE As Date
            Call Validation()

            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : month = "APR" : noofdays = 30 : bildt = "01/apr/" & gFinancalyearStart : month2 = "04" : billdt2 = "30/apr/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : month = "MAY" : noofdays = 31 : bildt = "01/may/" & gFinancalyearStart : month2 = "05" : billdt2 = "31/may/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : month = "JUN" : noofdays = 30 : bildt = "01/jun/" & gFinancalyearStart : month2 = "06" : billdt2 = "30/jun/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : month = "JUL" : noofdays = 31 : bildt = "01/jul/" & gFinancalyearStart : month2 = "07" : billdt2 = "31/jul/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : month = "AUG" : noofdays = 31 : bildt = "01/aug/" & gFinancalyearStart : month2 = "08" : billdt2 = "31/aug/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : month = "SEP" : noofdays = 30 : bildt = "01/sep/" & gFinancalyearStart : month2 = "09" : billdt2 = "30/sep/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : month = "OCT" : noofdays = 31 : bildt = "01/oct/" & gFinancalyearStart : month2 = "10" : billdt2 = "31/oct/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : month = "NOV" : noofdays = 30 : bildt = "01/nov/" & gFinancalyearStart : month2 = "11" : billdt2 = "30/nov/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : month = "DEC" : noofdays = 31 : bildt = "01/dec/" & gFinancalyearStart : month2 = "12" : billdt2 = "31/dec/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : month = "JAN" : noofdays = 31 : bildt = "01/jan/" & gFinancialyearEnd : month2 = "01" : billdt2 = "31/jan/" & gFinancialyearEnd
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : month = "FEB" : noofdays = 28 : bildt = "01/feb/" & gFinancialyearEnd : month2 = "02" : billdt2 = "28/feb/" & gFinancialyearEnd
            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : month = "MAR" : noofdays = 31 : bildt = "01/mar/" & gFinancialyearEnd : month2 = "03" : billdt2 = "31/mar/" & gFinancialyearEnd
            sqlstrinG = "SELECT * FROM JOURNALENTRY WHERE VOUCHERTYPE='MBILL' AND ISNULL(VOID,'')<>'Y' AND MONTH(VOUCHERDATE)='" & month2 & "'"
            gconnection.getDataSet(sqlstrinG, "member")
            If gdataset.Tables("member").Rows.Count = 0 Then
                MessageBox.Show("Month Bill is Not processed for this month")
                Exit Sub
            End If
            BILDATE = CDate(billdt2)
            If DTPduedate.Value < BILDATE Then
                MessageBox.Show("Bill Date should be greater than month bill date")
                Exit Sub
            End If
            sqlstrinG = "exec BILLDATE_OUT '" & Format(DTPduedate.Value, "dd/MMM/yyyy") & "','" & Format(DTPduedate.Value, "dd/MMM/yyyy") & "','Y','" & Format(BILDATE, "dd/MMM/yyyy") & "'"
            gconnection.dataOperation(1, sqlstrinG, "BILL")

            Dim Viewer As New REPORTVIEWER
            Dim r As New billing
            '  gSQLString1 = "EXEC MONTHBILL '" & billdt2 & "','" & bildt & "'"
            ' gconnection.dataOperation(6, gSQLString1, "monthbill")
            If Trim(txt_Tomcode.Text) <> "" And Trim(txt_Tomcode.Text) <> "" Then
                sqlstrinG = " SELECT ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(ADJUSTMENT,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE,ISNULL(BILLDATE,'') AS BILLDATE FROM bengal_monthbill b, membermaster m where b.mcode=m.mcode and b.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") ORDER BY b.MCODE "

                'sql = "select isnull(billdetails,'') as billdetails,ISNULL(POSDESC,'') AS POSDESC,isnull(kotdate,'') as kotdate,isnull(mcode,'')as mcode,isnull(amount,0) as amount,isnull(vat,0) as vat,isnull(service_tax,0) as service_tax,isnull(service_charge,0) as service_charge from member_consumption where MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(kotdate)= " & month1 & "  ORDER BY MCODE "

                sql = "SELECT ISNULL(POSCODE,0) AS POSCODE,ISNULL(POSDESC,'') AS POSDESC,ISNULL(MCODE,'') AS MCODE,SUM(AMOUNT) AS AMOUNT,SUM(VAT) AS VAT,SUM(SERVICE_TAX) AS SERVICE_TAX,SUM(SERVICE_CHARGE) AS SERVICE_CHARGE FROM MEMBER_CONSUMPTION1 where MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(kotdate)= " & month1 & "  GROUP BY POSDESC,POSCODE,mcode  ORDER BY MCODE"

                '' '' '' '' '' ''sqlstring1 = " select slcode,locdesc,sum(dramount) as dramount,sum(cramount) as cramount "
                '' '' '' '' '' ''sqlstring1 = sqlstring1 & "FROM View_Rec_Det WHERE LTRIM(RTRIM(SLCODE)) BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(BILLDATE) = " & month1 & " GROUP BY SLCODE,locdesc "
                ' '' '' '' '' '' ''ssql2 = " SELECT SLCODE,UPPER(HEADDESC) AS HEADDESC,SUM(DRAMOUNT) AS DRAMOUNT,SUM(CRAMOUNT) AS CRAMOUNT FROM View_Pos_Summary WHERE MONTH(BILLDATE) = " & month1 & " AND SLCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' GROUP BY SLCODE,HEADDESC "
                '' '' '' '' '' ''ssql2 = "select SUM(amount)as amount,description,mcode from month_bill where (month(date)=" & month1 & " or date='1900-01-01') AND mCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' group by description,mcode,order_no order by mcode,order_no"
                '' '' '' '' '' ''sqlstring3 = " select slcode,locdesc,sum(dramount) as dramount,sum(cramount) as cramount "
                '' '' '' '' '' ''sqlstring3 = sqlstring3 & " FROM View_drcr_Det WHERE SLCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(BILLDATE) = " & month1 & " GROUP BY SLCODE,locdesc "
                'sqlstring2 = "select ClubLogo from accountsSetUp"
            Else
                ' membertype = ""
                If chk_Filter_Field.CheckedItems.Count > 0 Then
                    For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                        TYPE = Split(chk_Filter_Field.CheckedItems(i), ".")
                        membertype = membertype & "'" & TYPE(0) & "', "
                    Next
                    membertype = Mid(membertype, 1, Len(membertype) - 2)

                Else
                    MessageBox.Show("Select the Category(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    chk_Filter_Field.Focus()
                    Exit Sub
                End If
                sqlstrinG = " SELECT ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(ADJUSTMENT,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE FROM bengal_monthbill b, membermaster m where b.mcode=m.mcode and LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") and month(b.billdate)=" & month1 & "  AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") ORDER BY b.MCODE "
                sql = "select isnull(POSCODE,'') as POSCODE,ISNULL(POSDESC,'') AS POSDESC,isnull(M.mcode,'')as mcode,SUM(AMOUNT) AS AMOUNT,SUM(VAT) AS VAT,SUM(SERVICE_TAX) AS SERVICE_TAX,SUM(SERVICE_CHARGE) AS SERVICE_CHARGE from member_consumption1 a,membermaster m  where   month(kotdate)= " & month1 & " AND a.mcode=m.mcode and LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") group by poscode,posdesc,m.mcode ORDER BY m.MCODE "
                'sqlstrinG = " SELECT ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT FROM bengal_monthbill b inner join membermaster m   ON b.mcode=m.mcode and b.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "'  ORDER BY b.MCODE "


                ''''''''''''''''sqlstrinG = " SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M WHERE M.MCODE = O.SLCODE AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") AND O.BILLDATE < '" & bildt & "' AND  CURENTSTATUS IN('LIVE','ACTIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE  ORDER BY M.MCODE "
                ' '' '' ''sqlstring1 = " select a.slcode,a.locdesc,sum(a.dramount) as dramount,sum(a.cramount) as cramount "
                ' '' '' ''sqlstring1 = sqlstring1 & "FROM View_Rec_Det a ,membermaster b WHERE MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  Group by  a.SLCODE,a.locdesc "
                '' '' '' ''ssql2 = " SELECT SLCODE,UPPER(HEADDESC) AS HEADDESC,SUM(DRAMOUNT) AS DRAMOUNT,SUM(CRAMOUNT) AS CRAMOUNT FROM View_Pos_Summary WHERE MONTH(BILLDATE) = " & month1 & " AND SLCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' GROUP BY SLCODE,HEADDESC "
                ' '' '' ''ssql2 = "select SUM(A.amount)as amount,A.description,A.mcode from month_bill A,MEMBERMASTER B where (month(A.date)=" & month1 & " or A.date='1900-01-01') and b.membertypecode in(" & membertype & ") group by a.description,a.mcode,a.order_no order by a.mcode,a.order_no"
                ' '' '' ''sqlstring3 = " select a.slcode,a.locdesc,sum(a.dramount) as dramount,sum(a.cramount) as cramount "
                ' '' '' ''sqlstring3 = sqlstring3 & " FROM View_drcr_Det a,membermaster b WHERE a.slcode=b.mcode  AND MONTH(a.BILLDATE) = " & month1 & " and b.membertypecode in(" & membertype & ") GROUP BY a.SLCODE,a.locdesc "

                'sqlstring = "SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+' '+ ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M WHERE SUBSTRING(M.MCODE,1,8) = SUBSTRING(O.SLCODE,1,8)  AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ")  "
                'sqlstring = sqlstring & " AND O.BILLDATE <'" & bildt & "' AND  CURENTSTATUS in('ACTIVE','LIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE  ORDER BY M.MCODE"
                'ssql = " SELECT A.BILLNO,A.SLCODE AS SLCODE,upper(A.HEADDESC),SUM(A.AMOUNT) AS AMOUNT,A.BILLDATE FROM MAINCASHRECEIPT  A, MEMBERMASTER B "
                'ssql = ssql & " WHERE Month(BILLDATE) = " & month1
                'ssql = ssql & " AND B.membertypecode IN(" & membertype & ") AND A.SLCODE=B.MCODE "
                'ssql = ssql & " GROUP BY A.SLCODE,A.HEADDESC,A.BILLDATE,A.BILLNO "
                'sqlstring1 = " select a.SLCODE,sum(a.dramount) as dramount,sum(a.cramount) as cramount "
                'sqlstring1 = sqlstring1 & "  From View_Rec_Det a, MEMBERMASTER b WHERE MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  Group by  a.SLCODE"
                'ssql2 = " SELECT a.SLCODE,upper(a.HEADDESC) AS HEADDESC,SUM(a.DRAMOUNT) AS DRAMOUNT,SUM(a.CRAMOUNT) AS CRAMOUNT FROM View_Pos_Summary  a, MEMBERMASTER b WHERE  MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  Group by  a.SLcode,a.HEADDESC "
                'sqlstring2 = "select ClubLogo from accountsSetUp"
                'sqlstring3 = " select A.slcode,A.locdesc,sum(A.dramount) as dramount,sum(A.cramount) as cramount "
                'sqlstring3 = sqlstring3 & " FROM View_drcr_Det A,MEMBERMASTER B WHERE MONTH(BILLDATE) = " & month1 & " and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ") GROUP BY SLCODE,locdesc "

            End If
            Call Viewer.GetDetails1(sql, "member_consumption", r)
            Call Viewer.GetDetails1(sqlstrinG, "bengal_monthbill", r)

            Dim name, add1, add2, add3, city, state, pin, cell As String

            'name = gdataset.Tables("bengal_monthbill").Rows(0).Item("mname")
            'add1 = gdataset.Tables("bengal_monthbill").Rows(0).Item("contadd1")
            'add2 = gdataset.Tables("bengal_monthbill").Rows(0).Item("contadd2")
            'add3 = gdataset.Tables("bengal_monthbill").Rows(0).Item("contadd3")
            'city = gdataset.Tables("bengal_monthbill").Rows(0).Item("contcity")
            'pin = gdataset.Tables("bengal_monthbill").Rows(0).Item("contpin")
            'cell = gdataset.Tables("bengal_monthbill").Rows(0).Item("contcell")


            'Call Viewer.GetDetails1(ssql2, "month_bill", r)
            'Call Viewer.GetDetails1(sqlstring1, "View_Rec_Det", r)
            'Call Viewer.GetDetails1(sqlstring3, "View_drcr_Det", r)
            'Call Viewer.GetDetails1(sqlstring2, "accountsSetUp", r)
            'Dim txtobj1 As TextObject
            'Dim txtobj As TextObject
            'Dim txtobj2 As TextObject
            Dim txtobj15 As TextObject
            Dim txtobj19 As TextObject
            Dim txtobj20 As TextObject
            txtobj19 = r.ReportDefinition.ReportObjects("Text20")
            txtobj19.Text = month & " " & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))

            Dim convdate As Date
            txtobj20 = r.ReportDefinition.ReportObjects("Text24")
            convdate = noofdays & "-" & IIf(month1 > 9, Str(month1), "0" & month1) & "-" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))
            txtobj20.Text = Format(convdate, "dd MMM yyyy")

            txtobj15 = r.ReportDefinition.ReportObjects("Text22")
            txtobj15.Text = "/" & month & "/" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4)) & "/Regular"


            txtobj19 = r.ReportDefinition.ReportObjects("Text31")
            txtobj19.Text = month & " " & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))

            'Dim convdate1 As Date
            txtobj20 = r.ReportDefinition.ReportObjects("Text35")
            convdate = noofdays & "-" & IIf(month1 > 9, Str(month1), "0" & month1) & "-" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))
            txtobj20.Text = Format(convdate, "dd MMM yyyy")

            txtobj15 = r.ReportDefinition.ReportObjects("Text33")
            txtobj15.Text = "/" & month & "/" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4)) & "/Regular"

            'Dim txtobj18 As TextObject
            'txtobj18 = r.ReportDefinition.ReportObjects("Text5")
            'txtobj18.Text = noofdays & "-" & IIf(month1 > 9, Str(month1), "0" & month1) & "-" & IIf(month1 > 3, gfinancalyearstart, Mid(gFinancialyearEnd,1, 4))


            'Dim txtobj1 As TextObject
            'Dim duedt As Date
            'txtobj1 = r.ReportDefinition.ReportObjects("Text27")
            'duedt = DTPduedate.Value
            'txtobj1.Text = Format(duedt, "dd.MM.yyyy")

            '' ''Dim txtobj1 As TextObject
            '' ''txtobj1 = r.ReportDefinition.ReportObjects("Text4")
            '' ''txtobj1.Text = name
            '' ''txtobj1 = r.ReportDefinition.ReportObjects("Text5")
            '' ''txtobj1.Text = add1
            '' ''txtobj1 = r.ReportDefinition.ReportObjects("Text6")
            '' ''txtobj1.Text = add2
            '' ''txtobj1 = r.ReportDefinition.ReportObjects("Text7")
            '' ''txtobj1.Text = add3
            '' ''txtobj1 = r.ReportDefinition.ReportObjects("Text8")
            '' ''txtobj1.Text = city & "  " & pin
            'txtobj1 = r.ReportDefinition.ReportObjects("Text9")
            'txtobj1.Text = UCase(cell)
            'txtobj15.Text = UCase(gUsername)
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Doller_Bill()
        Try
            Dim cmdText, billdt2, BILDT4, BILDT5 As String
            Dim duedate, membertype, TYPE(0), month, sql, sqlstrinG, sqlstrinG4, month2 As String
            Dim opl, i As Integer
            Dim BILDATE As Date
            Call Validation()
            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : month = "APR" : noofdays = 30 : bildt = "01/apr/" & gFinancalyearStart : month2 = "04" : billdt2 = "30/apr/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : month = "MAY" : noofdays = 31 : bildt = "01/may/" & gFinancalyearStart : month2 = "05" : billdt2 = "31/may/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : month = "JUN" : noofdays = 30 : bildt = "01/jun/" & gFinancalyearStart : month2 = "06" : billdt2 = "30/jun/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : month = "JUL" : noofdays = 31 : bildt = "01/jul/" & gFinancalyearStart : month2 = "07" : billdt2 = "31/jul/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : month = "AUG" : noofdays = 31 : bildt = "01/aug/" & gFinancalyearStart : month2 = "08" : billdt2 = "31/aug/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : month = "SEP" : noofdays = 30 : bildt = "01/sep/" & gFinancalyearStart : month2 = "09" : billdt2 = "30/sep/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : month = "OCT" : noofdays = 31 : bildt = "01/oct/" & gFinancalyearStart : month2 = "10" : billdt2 = "31/oct/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : month = "NOV" : noofdays = 30 : bildt = "01/nov/" & gFinancalyearStart : month2 = "11" : billdt2 = "30/nov/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : month = "DEC" : noofdays = 31 : bildt = "01/dec/" & gFinancalyearStart : month2 = "12" : billdt2 = "31/dec/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : month = "JAN" : noofdays = 31 : bildt = "01/jan/" & gFinancialyearEnd : month2 = "01" : billdt2 = "31/jan/" & gFinancialyearEnd
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : month = "FEB" : noofdays = 28 : bildt = "01/feb/" & gFinancialyearEnd : month2 = "02" : billdt2 = "28/feb/" & gFinancialyearEnd
            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : month = "MAR" : noofdays = 31 : bildt = "01/mar/" & gFinancialyearEnd : month2 = "03" : billdt2 = "31/mar/" & gFinancialyearEnd
            'sqlstrinG = "SELECT * FROM JOURNALENTRY WHERE VOUCHERTYPE='MBILL' AND ISNULL(VOID,'')<>'Y' AND MONTH(VOUCHERDATE)='" & month2 & "'"
            'gconnection.getDataSet(sqlstrinG, "member")
            'If gdataset.Tables("member").Rows.Count = 0 Then
            '    'MessageBox.Show("Month Bill is Not processed for this month")
            '    'Exit Sub
            'End If
            BILDATE = CDate(billdt2)
            If DTPduedate.Value < BILDATE Then
                MessageBox.Show("Bill Date should be greater than month bill date")
                Exit Sub
            End If
            sqlstrinG = "exec GETOUTSTANDSMS '" & billdt2 & "','" & bildt & "'"
            gconnection.dataOperation(1, sqlstrinG, "BILL")

            'sqlstrinG = "exec BILLDATE_OUT '" & Format(DTPduedate.Value, "dd/MMM/yyyy") & "','" & Format(DTPduedate.Value, "dd/MMM/yyyy") & "','N','" & Format(BILDATE, "dd/MMM/yyyy") & "'"
            'gconnection.dataOperation(1, sqlstrinG, "BILL")
            Dim Viewer As New REPORTVIEWER
            'Dim r As New billing
            'Dim r As New CCLbilling
            Dim r As New NRICCLbilling
            'Dim r As New CALBil
            '  gSQLString1 = "EXEC MONTHBILL '" & billdt2 & "','" & bildt & "'"
            ' gconnection.dataOperation(6, gSQLString1, "monthbill")
            If Trim(txt_Tomcode.Text) <> "" And Trim(txt_Tomcode.Text) <> "" Then
                'sqlstrinG = " SELECT ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(ADJUSTMENT,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE FROM bengal_monthbill b, membermaster m where b.mcode=m.mcode and b.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") ORDER BY b.MCODE "
                'sqlstrinG = " SELECT ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(ADJUSTMENT,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE FROM bengal_monthbill b, membermaster m where b.mcode=m.mcode and b.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") order by SUBSTRING(M.MCODE,1,2),LEN(M.MCODE),M.MCODE "
                'sqlstrinG = " SELECT ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(ADJUSTMENT,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE FROM bengal_monthbill b, membermaster m where b.mcode=m.mcode and b.MCODE like '" & txt_mcode.Text & "%' and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") order by SUBSTRING(M.MCODE,1,2),LEN(M.MCODE),M.MCODE "
                ''Nitesh
                'sqlstrinG = " SELECT ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(ADJUSTMENT,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE FROM bengal_monthbill b, membermaster m where b.mcode=m.mcode and substring(B.MCODE,1,2)+substring('00000000000',1,11-(len(B.MCODE)))+substring(B.MCODE,3,len(B.MCODE)-2) between substring('" & txt_mcode.Text & "',1,2)+substring('00000000000',1,11-(len('" & txt_mcode.Text & "')))+substring('" & txt_mcode.Text & "',3,len('" & txt_mcode.Text & "')-2)  and  substring('" & txt_Tomcode.Text & "',1,2)+substring('00000000000',1,11-(len('" & txt_Tomcode.Text & "')))+substring('" & txt_Tomcode.Text & "',3,len('" & txt_Tomcode.Text & "')-2) and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") order by SUBSTRING(M.MCODE,1,2),LEN(M.MCODE),M.MCODE "
                ' sqlstrinG = "SELECT ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(t.vat,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(t.WBST,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE,ISNULL(BILLNO,'') AS OUTSTANDING FROM bengal_monthbill b, membermaster m,VW_WBST T  where b.mcode=m.mcode  and b.mcode =t.mcode and month(b.billdate)=t.kotdate  and substring(B.MCODE,1,2)+substring('00000000000',1,11-(len(B.MCODE)))+substring(B.MCODE,3,len(B.MCODE)-2) between substring('" & txt_mcode.Text & "',1,2)+substring('00000000000',1,11-(len('" & txt_mcode.Text & "')))+substring('" & txt_mcode.Text & "',3,len('" & txt_mcode.Text & "')-2)  and  substring('" & txt_Tomcode.Text & "',1,2)+substring('00000000000',1,11-(len('" & txt_Tomcode.Text & "')))+substring('" & txt_Tomcode.Text & "',3,len('" & txt_Tomcode.Text & "')-2) and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") order by SUBSTRING(M.MCODE,1,2),LEN(M.MCODE),M.MCODE "
                sqlstrinG = "SELECT ISNULL(cast(t.BILLDATE as datetime),'') AS BILLDATE,ISNULL(b.MCODE,'') AS MCODE,(ISNULL(b.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(T.AREEAR,0) AS LAST_BALALNCE,ISNULL( t.crmonthreceipt ,0) AS LAST_PAID,0 AS PAID_AMOUNT,ISNULL(T.CURMONTHOUTSTANDING,0) AS DEBIT_AMOUNT,0  AS ADJUSTMENT,ISNULL(T.ASONOUTSTANDING,0) AS OUTSTANDING_AMT,ISNULL(t.billdate,0) AS OUTSTANDING_DATE, ISNULL(REPLACE(BILLNO,'/6-7',''),'') AS OUTSTANDING FROM membermaster b, subsposting M,OUTSTANDSMS T  where b.mcode=m.mcode  and b.mcode =t.mcode and B.MCODE  BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "'  and month(T.billdate)=" & month1 & " and m.subscode='NSUB'  AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION2 WHERE MONTH(KOTDATE)=" & month1 & ") order by b.MCODE "
                'sql = "select isnull(billdetails,'') as billdetails,ISNULL(POSDESC,'') AS POSDESC,isnull(kotdate,'') as kotdate,isnull(mcode,'')as mcode,isnull(amount,0) as amount,isnull(vat,0) as vat,isnull(service_tax,0) as service_tax,isnull(service_charge,0) as service_charge from member_consumption where MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(kotdate)= " & month1 & "  ORDER BY MCODE "
                'sql = "SELECT ISNULL(POSCODE,0) AS POSCODE,ISNULL(POSDESC,'') AS POSDESC,ISNULL(MCODE,'') AS MCODE,SUM(AMOUNT) AS AMOUNT,SUM(VAT) AS VAT,SUM(SERVICE_TAX) AS SERVICE_TAX,SUM(SERVICE_CHARGE) AS SERVICE_CHARGE FROM MEMBER_CONSUMPTION1 B where B.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(kotdate)= " & month1 & "  GROUP BY POSDESC,POSCODE,B.mcode  ORDER BY B.MCODE"
                'sql = "SELECT ISNULL(POSCODE,0) AS POSCODE,ISNULL(POSDESC,'') AS POSDESC,ISNULL(MCODE,'') AS MCODE,SUM(AMOUNT) AS AMOUNT,SUM(VAT) AS VAT,SUM(SERVICE_TAX) AS SERVICE_TAX,SUM(SERVICE_CHARGE) AS SERVICE_CHARGE FROM MEMBER_CONSUMPTION1 B where B.MCODE  like '" & txt_mcode.Text & "%' and month(kotdate)= " & month1 & "  GROUP BY POSDESC,POSCODE,B.mcode  ORDER BY B.MCODE"
                ''Nitesh
                sql = "SELECT ISNULL(POSCODE,0) AS POSCODE,ISNULL(POSDESC,'') AS POSDESC,ISNULL(MCODE,'') AS MCODE,SUM(AMOUNT) AS AMOUNT,SUM(VAT) AS VAT,SUM(SERVICE_TAX) AS SERVICE_TAX,SUM(SERVICE_CHARGE) AS SERVICE_CHARGE FROM MEMBER_CONSUMPTION2 B where B.MCODE between '" & txt_mcode.Text & "' and  '" & txt_Tomcode.Text & "' and month(kotdate)= " & month1 & "  GROUP BY POSDESC,POSCODE,B.mcode,B.Sno  ORDER BY B.MCODE,B.Sno"
                ' sql = "SELECT ISNULL(POSCODE,0) AS POSCODE,ISNULL(POSDESC,'') AS POSDESC,ISNULL(MCODE,'') AS MCODE,SUM(AMOUNT) AS AMOUNT,SUM(VAT) AS VAT,SUM(SERVICE_TAX) AS SERVICE_TAX,SUM(SERVICE_CHARGE) AS SERVICE_CHARGE FROM MEMBER_CONSUMPTION B where B.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(kotdate)= " & month1 & "  GROUP BY POSDESC,POSCODE,B.mcode  ORDER BY B.MCODE"
                '' '' '' '' '' ''sqlstring1 = " select slcode,locdesc,sum(dramount) as dramount,sum(cramount) as cramount "
                '' '' '' '' '' ''sqlstring1 = sqlstring1 & "FROM View_Rec_Det WHERE LTRIM(RTRIM(SLCODE)) BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(BILLDATE) = " & month1 & " GROUP BY SLCODE,locdesc "
                ' '' '' '' '' '' ''ssql2 = " SELECT SLCODE,UPPER(HEADDESC) AS HEADDESC,SUM(DRAMOUNT) AS DRAMOUNT,SUM(CRAMOUNT) AS CRAMOUNT FROM View_Pos_Summary WHERE MONTH(BILLDATE) = " & month1 & " AND SLCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' GROUP BY SLCODE,HEADDESC "
                '' '' '' '' '' ''ssql2 = "select SUM(amount)as amount,description,mcode from month_bill where (month(date)=" & month1 & " or date='1900-01-01') AND mCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' group by description,mcode,order_no order by mcode,order_no"
                '' '' '' '' '' ''sqlstring3 = " select slcode,locdesc,sum(dramount) as dramount,sum(cramount) as cramount "
                '' '' '' '' '' ''sqlstring3 = sqlstring3 & " FROM View_drcr_Det WHERE SLCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(BILLDATE) = " & month1 & " GROUP BY SLCODE,locdesc "
                'sqlstring2 = "select ClubLogo from accountsSetUp"
                'gconnection.getDataSet(sqlstring3, "View_DRCR_SUM")
                ' sqlstring3 = "select  mcode,SUM(BRAMOUNT) as BRAMOUNT   from View_DRCR_SUM where mCode ='S1031' and MONTH(billdate)=3 group by mcode"
                sqlstring3 = " select mcode,SUM(isnull(BRAMOUNT,0)) as BRAMOUNT,SUM(isnull(CRAMOUNT ,0)) as CRAMOUNT,SUM(isnull(CCRAMOUNT,0)) as CCRAMOUNT,SUM(isnull(CCNAMOUNT,0)) as CCNAMOUNT,SUM(isnull(CDNAMOUNT,0)) as CDNAMOUNT "
                sqlstring3 = sqlstring3 & " FROM View_DRCR_SUM_NRI WHERE mcode BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(BILLDATE) = " & month1 & " GROUP BY mcode "
                'SSQL4 = "select mcode,BILLDETAILS,WBST,KOTDATE ,TAXCODE ,TAXPERCENT   from VIEW_WBST WHERE mcode BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(KOTDATE) = " & month1 & ""
            Else
                ' membertype = ""
                If chk_Filter_Field.CheckedItems.Count > 0 Then
                    For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                        TYPE = Split(chk_Filter_Field.CheckedItems(i), ".")
                        membertype = membertype & "'" & TYPE(0) & "', "
                    Next
                    membertype = Mid(membertype, 1, Len(membertype) - 2)

                Else
                    MessageBox.Show("Select the Category(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    chk_Filter_Field.Focus()
                    Exit Sub
                End If
                'sqlstrinG = " SELECT ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(ADJUSTMENT,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE FROM bengal_monthbill b, membermaster m   where b.mcode=m.mcode and LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") ORDER BY b.MCODE "
                'sqlstrinG = " SELECT ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(ADJUSTMENT,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE FROM bengal_monthbill b, membermaster m   where b.mcode=m.mcode and LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") order by SUBSTRING(M.MCODE,1,2),LEN(M.MCODE),M.MCODE "
                sqlstrinG = "SELECT ISNULL(cast(t.BILLDATE as datetime),'') AS BILLDATE,ISNULL(b.MCODE,'') AS MCODE,(ISNULL(b.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(T.AREEAR,0) AS LAST_BALALNCE,ISNULL( t.crmonthreceipt ,0) AS LAST_PAID,0 AS PAID_AMOUNT,ISNULL(T.CURMONTHOUTSTANDING,0) AS DEBIT_AMOUNT,0  AS ADJUSTMENT,ISNULL(T.ASONOUTSTANDING,0) AS OUTSTANDING_AMT,ISNULL(t.billdate,0) AS OUTSTANDING_DATE,ISNULL(REPLACE(BILLNO,'/5-6',''),'')  AS OUTSTANDING FROM membermaster b, subsposting M,OUTSTANDSMS T  where b.mcode=m.mcode and b.mcode=t.mcode  and M.SUBSCODE='NSUB' and LTRIM(RTRIM(b.membertypecode)) IN(" & membertype & ") and month(t.billdate)=" & month1 & " and  m.subscode='NSUB' AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION2 WHERE MONTH(KOTDATE)=" & month1 & ") order by M.MCODE "
                sql = "select isnull(POSCODE,'') as POSCODE,ISNULL(POSDESC,'') AS POSDESC,isnull(M.mcode,'')as mcode,SUM(AMOUNT) AS AMOUNT,SUM(VAT) AS VAT,SUM(SERVICE_TAX) AS SERVICE_TAX,SUM(SERVICE_CHARGE) AS SERVICE_CHARGE from member_consumption2 a,membermaster m  where   month(kotdate)= " & month1 & " AND a.mcode=m.mcode and LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") group by poscode,posdesc,m.mcode,A.SNo ORDER BY m.MCODE ,A.SNo"
                'sql = "select isnull(POSCODE,'') as POSCODE,ISNULL(POSDESC,'') AS POSDESC,isnull(M.mcode,'')as mcode,SUM(AMOUNT) AS AMOUNT,SUM(VAT) AS VAT,SUM(SERVICE_TAX) AS SERVICE_TAX,SUM(SERVICE_CHARGE) AS SERVICE_CHARGE from member_consumption a,membermaster m  where   month(kotdate)= " & month1 & " AND a.mcode=m.mcode and LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") group by poscode,posdesc,m.mcode ORDER BY m.MCODE "
                'sqlstrinG = " SELECT ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT FROM bengal_monthbill b inner join membermaster m   ON b.mcode=m.mcode and b.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "'  ORDER BY b.MCODE "


                ''''''''''''''''sqlstrinG = " SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M WHERE M.MCODE = O.SLCODE AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") AND O.BILLDATE < '" & bildt & "' AND  CURENTSTATUS IN('LIVE','ACTIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE  ORDER BY M.MCODE "
                ' '' '' ''sqlstring1 = " select a.slcode,a.locdesc,sum(a.dramount) as dramount,sum(a.cramount) as cramount "
                ' '' '' ''sqlstring1 = sqlstring1 & "FROM View_Rec_Det a ,membermaster b WHERE MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  Group by  a.SLCODE,a.locdesc "
                '' '' '' ''ssql2 = " SELECT SLCODE,UPPER(HEADDESC) AS HEADDESC,SUM(DRAMOUNT) AS DRAMOUNT,SUM(CRAMOUNT) AS CRAMOUNT FROM View_Pos_Summary WHERE MONTH(BILLDATE) = " & month1 & " AND SLCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' GROUP BY SLCODE,HEADDESC "
                ' '' '' ''ssql2 = "select SUM(A.amount)as amount,A.description,A.mcode from month_bill A,MEMBERMASTER B where (month(A.date)=" & month1 & " or A.date='1900-01-01') and b.membertypecode in(" & membertype & ") group by a.description,a.mcode,a.order_no order by a.mcode,a.order_no"
                ' '' '' ''sqlstring3 = " select a.slcode,a.locdesc,sum(a.dramount) as dramount,sum(a.cramount) as cramount "
                ' '' '' ''sqlstring3 = sqlstring3 & " FROM View_drcr_Det a,membermaster b WHERE a.slcode=b.mcode  AND MONTH(a.BILLDATE) = " & month1 & " and b.membertypecode in(" & membertype & ") GROUP BY a.SLCODE,a.locdesc "

                'sqlstring = "SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+' '+ ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M WHERE SUBSTRING(M.MCODE,1,8) = SUBSTRING(O.SLCODE,1,8)  AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ")  "
                'sqlstring = sqlstring & " AND O.BILLDATE <'" & bildt & "' AND  CURENTSTATUS in('ACTIVE','LIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE  ORDER BY M.MCODE"
                'ssql = " SELECT A.BILLNO,A.SLCODE AS SLCODE,upper(A.HEADDESC),SUM(A.AMOUNT) AS AMOUNT,A.BILLDATE FROM MAINCASHRECEIPT  A, MEMBERMASTER B "
                'ssql = ssql & " WHERE Month(BILLDATE) = " & month1
                'ssql = ssql & " AND B.membertypecode IN(" & membertype & ") AND A.SLCODE=B.MCODE "
                'ssql = ssql & " GROUP BY A.SLCODE,A.HEADDESC,A.BILLDATE,A.BILLNO "
                'sqlstring1 = " select a.SLCODE,sum(a.dramount) as dramount,sum(a.cramount) as cramount "
                'sqlstring1 = sqlstring1 & "  From View_Rec_Det a, MEMBERMASTER b WHERE MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  Group by  a.SLCODE"
                'ssql2 = " SELECT a.SLCODE,upper(a.HEADDESC) AS HEADDESC,SUM(a.DRAMOUNT) AS DRAMOUNT,SUM(a.CRAMOUNT) AS CRAMOUNT FROM View_Pos_Summary  a, MEMBERMASTER b WHERE  MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  Group by  a.SLcode,a.HEADDESC "
                'sqlstring2 = "select ClubLogo from accountsSetUp"
                'sqlstring3 = " select A.slcode,A.locdesc,sum(A.dramount) as dramount,sum(A.cramount) as cramount "
                'sqlstring3 = sqlstring3 & " FROM View_drcr_Det A,MEMBERMASTER B WHERE MONTH(BILLDATE) = " & month1 & " and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ") GROUP BY SLCODE,locdesc "
                sqlstring3 = " select a.mcode,SUM(isnull(BRAMOUNT,0)) as BRAMOUNT,SUM(isnull(CRAMOUNT ,0)) as CRAMOUNT,SUM(isnull(CCRAMOUNT,0)) as CCRAMOUNT,SUM(isnull(CCNAMOUNT,0)) as CCNAMOUNT,SUM(isnull(CDNAMOUNT,0)) as CDNAMOUNT "
                sqlstring3 = sqlstring3 & " FROM View_DRCR_SUM_NRI A,MEMBERMASTER B WHERE MONTH(BILLDATE) = " & month1 & " and a.mcode=b.MCODE and b.membertypecode in(" & membertype & ") GROUP BY a.mcode"
                'SSQL4 = "select a.mcode,a.BILLDETAILS,a.WBST,a.KOTDATE ,a,TAXCODE ,a.TAXPERCENT   from VIEW_WBST  A,MEMBERMASTER B  WHERE MONTH(KOTDATE) = " & month1 & " and a.mcode=b.MCODE and b.membertypecode in(" & membertype & ") "

            End If
            Call Viewer.GetDetails1(sql, "member_consumption", r)
            Call Viewer.GetDetails1(sqlstrinG, "bengal_monthbill", r)
            Call Viewer.GetDetails2(sqlstring3, "View_DRCR_SUM", r)
            ' Call Viewer.GetDetails3(SSQL4, "VIEW_WBST", r)


            Dim name, add1, add2, add3, city, state, pin, cell As String

            'name = gdataset.Tables("bengal_monthbill").Rows(0).Item("mname")
            'add1 = gdataset.Tables("bengal_monthbill").Rows(0).Item("contadd1")
            'add2 = gdataset.Tables("bengal_monthbill").Rows(0).Item("contadd2")
            'add3 = gdataset.Tables("bengal_monthbill").Rows(0).Item("contadd3")
            'city = gdataset.Tables("bengal_monthbill").Rows(0).Item("contcity")
            'pin = gdataset.Tables("bengal_monthbill").Rows(0).Item("contpin")
            'cell = gdataset.Tables("bengal_monthbill").Rows(0).Item("contcell")


            'Call Viewer.GetDetails1(ssql2, "month_bill", r)
            'Call Viewer.GetDetails1(sqlstring1, "View_Rec_Det", r)
            'Call Viewer.GetDetails1(sqlstring3, "View_drcr_Det", r)
            'Call Viewer.GetDetails1(sqlstring2, "accountsSetUp", r)
            'Dim txtobj1 As TextObject
            'Dim txtobj As TextObject
            'Dim txtobj2 As TextObject
            Dim txtobj15 As TextObject
            Dim txtobj19 As TextObject
            Dim txtobj20 As TextObject

            'Dim txtobj48 As TextObject
            'txtobj48 = r.ReportDefinition.ReportObjects("Text48")
            'txtobj48.Text = txt_msg.Text

            Dim txtobj1 As TextObject
            Dim txtobj2 As TextObject
            Dim duedt As Date

            txtobj1 = r.ReportDefinition.ReportObjects("Text2")
            duedt = DTPduedate.Value
            txtobj1.Text = Format(duedt, "dd/MMM/yyyy")

            txtobj2 = r.ReportDefinition.ReportObjects("Text22")
            'duedt = DTPduedate.Value
            txtobj2.Text = "Yearly"

            '" & Format(DTPduedate.Value, "dd/MMM/yyyy") & "'
            'txtobj19 = r.ReportDefinition.ReportObjects("Text20")
            'txtobj19.Text = month & " " & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))

            'Dim convdate As Date
            'txtobj20 = r.ReportDefinition.ReportObjects("Text24")
            'convdate = noofdays & "-" & IIf(month1 > 9, Str(month1), "0" & month1) & "-" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))
            'txtobj20.Text = Format(convdate, "dd MMM yyyy")

            'txtobj15 = r.ReportDefinition.ReportObjects("Text22")
            'txtobj15.Text = "/" & month & "/" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4)) & "/Regular"


            'txtobj19 = r.ReportDefinition.ReportObjects("Text31")
            'txtobj19.Text = month & " " & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))

            ''Dim convdate1 As Date
            'txtobj20 = r.ReportDefinition.ReportObjects("Text35")
            'convdate = noofdays & "-" & IIf(month1 > 9, Str(month1), "0" & month1) & "-" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))
            'txtobj20.Text = Format(convdate, "dd MMM yyyy")

            'txtobj15 = r.ReportDefinition.ReportObjects("Text33")
            'txtobj15.Text = "/" & month & "/" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4)) & "/Regular"

            'Dim txtobj18 As TextObject
            'txtobj18 = r.ReportDefinition.ReportObjects("Text5")
            ' txtobj18.Text = noofdays & "-" & IIf(month1 > 9, Str(month1), "0" & month1) & "-" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))


            'Dim txtobj1 As TextObject
            'Dim duedt As Date
            'txtobj1 = r.ReportDefinition.ReportObjects("Text27")
            'duedt = DTPduedate.Value
            'txtobj1.Text = Format(duedt, "dd.MM.yyyy")

            ' '' ''Dim txtobj1 As TextObject
            '' ''txtobj1 = r.ReportDefinition.ReportObjects("Text4")
            '' ''txtobj1.Text = name
            '' ''txtobj1 = r.ReportDefinition.ReportObjects("Text5")
            '' ''txtobj1.Text = add1
            '' ''txtobj1 = r.ReportDefinition.ReportObjects("Text6")
            '' ''txtobj1.Text = add2
            '' ''txtobj1 = r.ReportDefinition.ReportObjects("Text7")
            '' ''txtobj1.Text = add3
            '' ''txtobj1 = r.ReportDefinition.ReportObjects("Text8")
            '' ''txtobj1.Text = city & "  " & pin
            'txtobj1 = r.ReportDefinition.ReportObjects("Text9")
            'txtobj1.Text = UCase(cell)
            'txtobj15.Text = UCase(gUsername)
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim cmdText, billdt2, BILDT4, BILDT5 As String
            Dim duedate, membertype, TYPE(0), month, sql, sqlstrinG, sqlstrinG4, month2 As String
            Dim opl, i As Integer
            Dim BILDATE As Date
            Dim bLeapYear As Boolean
            bLeapYear = Date.IsLeapYear(gFinancialyearEnd)
            Call Validation()
            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : month = "APR" : noofdays = 30 : bildt = "01/apr/" & gFinancalyearStart : month2 = "04" : billdt2 = "30/apr/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : month = "MAY" : noofdays = 31 : bildt = "01/may/" & gFinancalyearStart : month2 = "05" : billdt2 = "31/may/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : month = "JUN" : noofdays = 30 : bildt = "01/jun/" & gFinancalyearStart : month2 = "06" : billdt2 = "30/jun/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : month = "JUL" : noofdays = 31 : bildt = "01/jul/" & gFinancalyearStart : month2 = "07" : billdt2 = "31/jul/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : month = "AUG" : noofdays = 31 : bildt = "01/aug/" & gFinancalyearStart : month2 = "08" : billdt2 = "31/aug/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : month = "SEP" : noofdays = 30 : bildt = "01/sep/" & gFinancalyearStart : month2 = "09" : billdt2 = "30/sep/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : month = "OCT" : noofdays = 31 : bildt = "01/oct/" & gFinancalyearStart : month2 = "10" : billdt2 = "31/oct/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : month = "NOV" : noofdays = 30 : bildt = "01/nov/" & gFinancalyearStart : month2 = "11" : billdt2 = "30/nov/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : month = "DEC" : noofdays = 31 : bildt = "01/dec/" & gFinancalyearStart : month2 = "12" : billdt2 = "31/dec/" & gFinancalyearStart
            If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : month = "JAN" : noofdays = 31 : bildt = "01/jan/" & gFinancialyearEnd : month2 = "01" : billdt2 = "31/jan/" & gFinancialyearEnd
            If bLeapYear = True Then
                If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : month = "FEB" : noofdays = 29 : bildt = "01/feb/" & gFinancialyearEnd : month2 = "02" : billdt2 = "29/feb/" & gFinancialyearEnd
            Else
                If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : month = "FEB" : noofdays = 28 : bildt = "01/feb/" & gFinancialyearEnd : month2 = "02" : billdt2 = "28/feb/" & gFinancialyearEnd
            End If
            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : month = "MAR" : noofdays = 31 : bildt = "01/mar/" & gFinancialyearEnd : month2 = "03" : billdt2 = "31/mar/" & gFinancialyearEnd
            sqlstrinG = "SELECT * FROM JOURNALENTRY WHERE VOUCHERTYPE='MBILL' AND ISNULL(VOID,'')<>'Y' AND MONTH(VOUCHERDATE)='" & month2 & "'"
            gconnection.getDataSet(sqlstrinG, "member")

            If gdataset.Tables("member").Rows.Count = 0 Then
                'MessageBox.Show("Month Bill is Not processed for this month")
                'Exit Sub
            End If
            BILDATE = CDate(billdt2)
            If DTPduedate.Value < BILDATE Then
                MessageBox.Show("Bill Date should be greater than month bill date")
                Exit Sub
            End If
            sqlstrinG = "exec BILLDATE_OUT '" & Format(DTPduedate.Value, "dd/MMM/yyyy") & "','" & Format(DTPduedate.Value, "dd/MMM/yyyy") & "','N','" & Format(BILDATE, "dd/MMM/yyyy") & "'"
            gconnection.dataOperation(1, sqlstrinG, "BILL")
            Dim Viewer As New REPORTVIEWER
            'Dim r As New billing
            Dim r As New CCLbilling
            'Dim r As New CALBil
            '  gSQLString1 = "EXEC MONTHBILL '" & billdt2 & "','" & bildt & "'"
            ' gconnection.dataOperation(6, gSQLString1, "monthbill")
            If Trim(txt_Tomcode.Text) <> "" And Trim(txt_Tomcode.Text) <> "" Then
                'sqlstrinG = " SELECT ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(ADJUSTMENT,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE FROM bengal_monthbill b, membermaster m where b.mcode=m.mcode and b.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") ORDER BY b.MCODE "
                'sqlstrinG = " SELECT ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(ADJUSTMENT,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE FROM bengal_monthbill b, membermaster m where b.mcode=m.mcode and b.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") order by SUBSTRING(M.MCODE,1,2),LEN(M.MCODE),M.MCODE "
                'sqlstrinG = " SELECT ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(ADJUSTMENT,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE FROM bengal_monthbill b, membermaster m where b.mcode=m.mcode and b.MCODE like '" & txt_mcode.Text & "%' and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") order by SUBSTRING(M.MCODE,1,2),LEN(M.MCODE),M.MCODE "
                ''Nitesh
                'sqlstrinG = " SELECT ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(ADJUSTMENT,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE FROM bengal_monthbill b, membermaster m where b.mcode=m.mcode and substring(B.MCODE,1,2)+substring('00000000000',1,11-(len(B.MCODE)))+substring(B.MCODE,3,len(B.MCODE)-2) between substring('" & txt_mcode.Text & "',1,2)+substring('00000000000',1,11-(len('" & txt_mcode.Text & "')))+substring('" & txt_mcode.Text & "',3,len('" & txt_mcode.Text & "')-2)  and  substring('" & txt_Tomcode.Text & "',1,2)+substring('00000000000',1,11-(len('" & txt_Tomcode.Text & "')))+substring('" & txt_Tomcode.Text & "',3,len('" & txt_Tomcode.Text & "')-2) and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") order by SUBSTRING(M.MCODE,1,2),LEN(M.MCODE),M.MCODE "
                'sqlstrinG = "SELECT ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(t.vat,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(t.WBST,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE,ISNULL(BILLNO,'') AS OUTSTANDING FROM bengal_monthbill b, membermaster m,VW_WBST T  where b.mcode=m.mcode  and b.mcode =t.mcode and month(b.billdate)=t.kotdate  and substring(B.MCODE,1,2)+substring('00000000000',1,11-(len(B.MCODE)))+substring(B.MCODE,3,len(B.MCODE)-2) between substring('" & txt_mcode.Text & "',1,2)+substring('00000000000',1,11-(len('" & txt_mcode.Text & "')))+substring('" & txt_mcode.Text & "',3,len('" & txt_mcode.Text & "')-2)  and  substring('" & txt_Tomcode.Text & "',1,2)+substring('00000000000',1,11-(len('" & txt_Tomcode.Text & "')))+substring('" & txt_Tomcode.Text & "',3,len('" & txt_Tomcode.Text & "')-2) and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") order by SUBSTRING(M.MCODE,1,2),LEN(M.MCODE),M.MCODE "
                sqlstrinG = "SELECT ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(t.vat,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(t.WBST,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE,ISNULL(BILLNO,'') AS OUTSTANDING FROM bengal_monthbill b, membermaster m,VW_WBST T  where b.mcode=m.mcode  and b.mcode =t.mcode and month(b.billdate)=t.kotdate  and b.mcode BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") order by SUBSTRING(M.MCODE,1,2),LEN(M.MCODE),M.MCODE "
                'sql = "select isnull(billdetails,'') as billdetails,ISNULL(POSDESC,'') AS POSDESC,isnull(kotdate,'') as kotdate,isnull(mcode,'')as mcode,isnull(amount,0) as amount,isnull(vat,0) as vat,isnull(service_tax,0) as service_tax,isnull(service_charge,0) as service_charge from member_consumption where MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(kotdate)= " & month1 & "  ORDER BY MCODE "
                'sql = "SELECT ISNULL(POSCODE,0) AS POSCODE,ISNULL(POSDESC,'') AS POSDESC,ISNULL(MCODE,'') AS MCODE,SUM(AMOUNT) AS AMOUNT,SUM(VAT) AS VAT,SUM(SERVICE_TAX) AS SERVICE_TAX,SUM(SERVICE_CHARGE) AS SERVICE_CHARGE FROM MEMBER_CONSUMPTION1 B where B.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(kotdate)= " & month1 & "  GROUP BY POSDESC,POSCODE,B.mcode  ORDER BY B.MCODE"
                'sql = "SELECT ISNULL(POSCODE,0) AS POSCODE,ISNULL(POSDESC,'') AS POSDESC,ISNULL(MCODE,'') AS MCODE,SUM(AMOUNT) AS AMOUNT,SUM(VAT) AS VAT,SUM(SERVICE_TAX) AS SERVICE_TAX,SUM(SERVICE_CHARGE) AS SERVICE_CHARGE FROM MEMBER_CONSUMPTION1 B where B.MCODE  like '" & txt_mcode.Text & "%' and month(kotdate)= " & month1 & "  GROUP BY POSDESC,POSCODE,B.mcode  ORDER BY B.MCODE"
                ''Nitesh
                ' sql = "SELECT ISNULL(POSCODE,0) AS POSCODE,ISNULL(POSDESC,'') AS POSDESC,ISNULL(MCODE,'') AS MCODE,SUM(AMOUNT) AS AMOUNT,SUM(VAT) AS VAT,SUM(SERVICE_TAX) AS SERVICE_TAX,SUM(SERVICE_CHARGE) AS SERVICE_CHARGE FROM MEMBER_CONSUMPTION B where substring(B.MCODE,1,2)+substring('00000000000',1,11-(len(B.MCODE)))+substring(B.MCODE,3,len(B.MCODE)-2)  between substring('" & txt_mcode.Text & "',1,2)+substring('00000000000',1,11-(len('" & txt_mcode.Text & "')))+substring('" & txt_mcode.Text & "',3,len('" & txt_mcode.Text & "')-2)  and  substring('" & txt_Tomcode.Text & "',1,2)+substring('00000000000',1,11-(len('" & txt_Tomcode.Text & "')))+substring('" & txt_Tomcode.Text & "',3,len('" & txt_Tomcode.Text & "')-2) and month(kotdate)= " & month1 & "  GROUP BY POSDESC,POSCODE,B.mcode,B.Sno  ORDER BY B.MCODE,B.Sno"
                sql = "SELECT ISNULL(POSCODE,0) AS POSCODE,ISNULL(POSDESC,'') AS POSDESC,ISNULL(MCODE,'') AS MCODE,SUM(AMOUNT) AS AMOUNT,SUM(VAT) AS VAT,SUM(SERVICE_TAX) AS SERVICE_TAX,SUM(SERVICE_CHARGE) AS SERVICE_CHARGE FROM MEMBER_CONSUMPTION B where B.MCODE between '" & txt_mcode.Text & "' and  '" & txt_Tomcode.Text & "'  and month(kotdate)= " & month1 & " and isnull(POSCODE,'') not in ('BANQ')   GROUP BY POSDESC,POSCODE,B.mcode,B.Sno  ORDER BY B.MCODE,B.Sno"

                ' sql = "SELECT ISNULL(POSCODE,0) AS POSCODE,ISNULL(POSDESC,'') AS POSDESC,ISNULL(MCODE,'') AS MCODE,SUM(AMOUNT) AS AMOUNT,SUM(VAT) AS VAT,SUM(SERVICE_TAX) AS SERVICE_TAX,SUM(SERVICE_CHARGE) AS SERVICE_CHARGE FROM MEMBER_CONSUMPTION B where B.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' and month(kotdate)= " & month1 & "  GROUP BY POSDESC,POSCODE,B.mcode  ORDER BY B.MCODE"
                '' '' '' '' '' ''sqlstring1 = " select slcode,locdesc,sum(dramount) as dramount,sum(cramount) as cramount "
                '' '' '' '' '' ''sqlstring1 = sqlstring1 & "FROM View_Rec_Det WHERE LTRIM(RTRIM(SLCODE)) BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(BILLDATE) = " & month1 & " GROUP BY SLCODE,locdesc "
                ' '' '' '' '' '' ''ssql2 = " SELECT SLCODE,UPPER(HEADDESC) AS HEADDESC,SUM(DRAMOUNT) AS DRAMOUNT,SUM(CRAMOUNT) AS CRAMOUNT FROM View_Pos_Summary WHERE MONTH(BILLDATE) = " & month1 & " AND SLCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' GROUP BY SLCODE,HEADDESC "
                '' '' '' '' '' ''ssql2 = "select SUM(amount)as amount,description,mcode from month_bill where (month(date)=" & month1 & " or date='1900-01-01') AND mCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' group by description,mcode,order_no order by mcode,order_no"
                '' '' '' '' '' ''sqlstring3 = " select slcode,locdesc,sum(dramount) as dramount,sum(cramount) as cramount "
                '' '' '' '' '' ''sqlstring3 = sqlstring3 & " FROM View_drcr_Det WHERE SLCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(BILLDATE) = " & month1 & " GROUP BY SLCODE,locdesc "
                'sqlstring2 = "select ClubLogo from accountsSetUp"
                'gconnection.getDataSet(sqlstring3, "View_DRCR_SUM")
                ' sqlstring3 = "select  mcode,SUM(BRAMOUNT) as BRAMOUNT   from View_DRCR_SUM where mCode ='S1031' and MONTH(billdate)=3 group by mcode"
                sqlstring3 = " select mcode,SUM(isnull(BRAMOUNT,0)) as BRAMOUNT,SUM(isnull(CRAMOUNT ,0)) as CRAMOUNT,SUM(isnull(CCRAMOUNT,0)) as CCRAMOUNT,SUM(isnull(CCNAMOUNT,0)) as CCNAMOUNT,SUM(isnull(CDNAMOUNT,0)) as CDNAMOUNT "
                sqlstring3 = sqlstring3 & " ,SUM(isnull(PARTYAMT,0)) as billno FROM View_DRCR_SUM WHERE mcode BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(BILLDATE) = " & month1 & " GROUP BY mcode "
                'SSQL4 = "select mcode,BILLDETAILS,WBST,KOTDATE ,TAXCODE ,TAXPERCENT   from VIEW_WBST WHERE mcode BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND MONTH(KOTDATE) = " & month1 & ""
            Else
                ' membertype = ""
                If chk_Filter_Field.CheckedItems.Count > 0 Then
                    For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                        TYPE = Split(chk_Filter_Field.CheckedItems(i), ".")
                        membertype = membertype & "'" & TYPE(0) & "', "
                    Next
                    membertype = Mid(membertype, 1, Len(membertype) - 2)

                Else
                    MessageBox.Show("Select the Category(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    chk_Filter_Field.Focus()
                    Exit Sub
                End If
                'sqlstrinG = " SELECT ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(ADJUSTMENT,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE FROM bengal_monthbill b, membermaster m   where b.mcode=m.mcode and LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") ORDER BY b.MCODE "
                'sqlstrinG = " SELECT ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(ADJUSTMENT,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE FROM bengal_monthbill b, membermaster m   where b.mcode=m.mcode and LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") order by SUBSTRING(M.MCODE,1,2),LEN(M.MCODE),M.MCODE "
                sqlstrinG = "SELECT ISNULL(BILLDATE,'') AS BILLDATE,ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(t.vat,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT,ISNULL(WBST,0) AS ADJUSTMENT,ISNULL(OUTSTANDING_AMT,0) AS OUTSTANDING_AMT,ISNULL(OUTSTANDING_DATE,0) AS OUTSTANDING_DATE,ISNULL(BILLNO,'') AS OUTSTANDING FROM bengal_monthbill b, membermaster m ,VW_WBST T  where b.mcode=m.mcode and b.mcode=t.mcode and month(b.billdate)=t.kotdate  and LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") and month(b.billdate)=" & month1 & " AND B.MCODE IN(SELECT MCODE FROM MEMBER_CONSUMPTION1 WHERE MONTH(KOTDATE)=" & month1 & ") order by SUBSTRING(M.MCODE,1,2),LEN(M.MCODE),M.MCODE "
                sql = "select isnull(POSCODE,'') as POSCODE,ISNULL(POSDESC,'') AS POSDESC,isnull(M.mcode,'')as mcode,SUM(AMOUNT) AS AMOUNT,SUM(VAT) AS VAT,SUM(SERVICE_TAX) AS SERVICE_TAX,SUM(SERVICE_CHARGE) AS SERVICE_CHARGE from member_consumption a,membermaster m  where   month(kotdate)= " & month1 & " AND a.mcode=m.mcode and LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") and isnull(a.POSCODE,'') not in ('BANQ')   group by poscode,posdesc,m.mcode,A.SNo ORDER BY m.MCODE ,A.SNo"
                'sql = "select isnull(POSCODE,'') as POSCODE,ISNULL(POSDESC,'') AS POSDESC,isnull(M.mcode,'')as mcode,SUM(AMOUNT) AS AMOUNT,SUM(VAT) AS VAT,SUM(SERVICE_TAX) AS SERVICE_TAX,SUM(SERVICE_CHARGE) AS SERVICE_CHARGE from member_consumption a,membermaster m  where   month(kotdate)= " & month1 & " AND a.mcode=m.mcode and LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") group by poscode,posdesc,m.mcode ORDER BY m.MCODE "
                'sqlstrinG = " SELECT ISNULL(b.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(b.MNAME,'')) AS MNAME,ISNULL(b.CONTADD1,'') AS CONTADD1,ISNULL(b.CONTADD2,'') AS CONTADD2,ISNULL(b.CONTADD3,'') AS CONTADD3,ISNULL(b.CONTCITY,'') AS CONTCITY,ISNULL(b.CONTPIN,'') AS CONTPIN,b.contcell,ISNULL(b.MEMBERTYPECODE,'')AS MEMBERTYPECODE,ISNULL(b.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(LAST_BALALNCE,0) AS LAST_BALALNCE,ISNULL(LAST_PAID,'') AS LAST_PAID,ISNULL(PAID_AMOUNT,0) AS PAID_AMOUNT,ISNULL(DEBIT_AMOUNT,0) AS DEBIT_AMOUNT FROM bengal_monthbill b inner join membermaster m   ON b.mcode=m.mcode and b.MCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "'  ORDER BY b.MCODE "


                ''''''''''''''''sqlstrinG = " SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M WHERE M.MCODE = O.SLCODE AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ") AND O.BILLDATE < '" & bildt & "' AND  CURENTSTATUS IN('LIVE','ACTIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE  ORDER BY M.MCODE "
                ' '' '' ''sqlstring1 = " select a.slcode,a.locdesc,sum(a.dramount) as dramount,sum(a.cramount) as cramount "
                ' '' '' ''sqlstring1 = sqlstring1 & "FROM View_Rec_Det a ,membermaster b WHERE MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  Group by  a.SLCODE,a.locdesc "
                '' '' '' ''ssql2 = " SELECT SLCODE,UPPER(HEADDESC) AS HEADDESC,SUM(DRAMOUNT) AS DRAMOUNT,SUM(CRAMOUNT) AS CRAMOUNT FROM View_Pos_Summary WHERE MONTH(BILLDATE) = " & month1 & " AND SLCODE BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' GROUP BY SLCODE,HEADDESC "
                ' '' '' ''ssql2 = "select SUM(A.amount)as amount,A.description,A.mcode from month_bill A,MEMBERMASTER B where (month(A.date)=" & month1 & " or A.date='1900-01-01') and b.membertypecode in(" & membertype & ") group by a.description,a.mcode,a.order_no order by a.mcode,a.order_no"
                ' '' '' ''sqlstring3 = " select a.slcode,a.locdesc,sum(a.dramount) as dramount,sum(a.cramount) as cramount "
                ' '' '' ''sqlstring3 = sqlstring3 & " FROM View_drcr_Det a,membermaster b WHERE a.slcode=b.mcode  AND MONTH(a.BILLDATE) = " & month1 & " and b.membertypecode in(" & membertype & ") GROUP BY a.SLCODE,a.locdesc "

                'sqlstring = "SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+' '+ ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M WHERE SUBSTRING(M.MCODE,1,8) = SUBSTRING(O.SLCODE,1,8)  AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ")  "
                'sqlstring = sqlstring & " AND O.BILLDATE <'" & bildt & "' AND  CURENTSTATUS in('ACTIVE','LIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE  ORDER BY M.MCODE"
                'ssql = " SELECT A.BILLNO,A.SLCODE AS SLCODE,upper(A.HEADDESC),SUM(A.AMOUNT) AS AMOUNT,A.BILLDATE FROM MAINCASHRECEIPT  A, MEMBERMASTER B "
                'ssql = ssql & " WHERE Month(BILLDATE) = " & month1
                'ssql = ssql & " AND B.membertypecode IN(" & membertype & ") AND A.SLCODE=B.MCODE "
                'ssql = ssql & " GROUP BY A.SLCODE,A.HEADDESC,A.BILLDATE,A.BILLNO "
                'sqlstring1 = " select a.SLCODE,sum(a.dramount) as dramount,sum(a.cramount) as cramount "
                'sqlstring1 = sqlstring1 & "  From View_Rec_Det a, MEMBERMASTER b WHERE MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  Group by  a.SLCODE"
                'ssql2 = " SELECT a.SLCODE,upper(a.HEADDESC) AS HEADDESC,SUM(a.DRAMOUNT) AS DRAMOUNT,SUM(a.CRAMOUNT) AS CRAMOUNT FROM View_Pos_Summary  a, MEMBERMASTER b WHERE  MONTH(BILLDATE) = " & month1 & "  and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ")  Group by  a.SLcode,a.HEADDESC "
                'sqlstring2 = "select ClubLogo from accountsSetUp"
                'sqlstring3 = " select A.slcode,A.locdesc,sum(A.dramount) as dramount,sum(A.cramount) as cramount "
                'sqlstring3 = sqlstring3 & " FROM View_drcr_Det A,MEMBERMASTER B WHERE MONTH(BILLDATE) = " & month1 & " and a.slcode=b.MCODE and b.membertypecode in(" & membertype & ") GROUP BY SLCODE,locdesc "
                sqlstring3 = " select a.mcode,SUM(isnull(BRAMOUNT,0)) as BRAMOUNT,SUM(isnull(CRAMOUNT ,0)) as CRAMOUNT,SUM(isnull(CCRAMOUNT,0)) as CCRAMOUNT,SUM(isnull(CCNAMOUNT,0)) as CCNAMOUNT,SUM(isnull(CDNAMOUNT,0)) as CDNAMOUNT "
                sqlstring3 = sqlstring3 & " ,SUM(isnull(PARTYAMT,0)) as billno FROM View_DRCR_SUM A,MEMBERMASTER B WHERE MONTH(BILLDATE) = " & month1 & " and a.mcode=b.MCODE and b.membertypecode in(" & membertype & ") GROUP BY a.mcode"
                'SSQL4 = "select a.mcode,a.BILLDETAILS,a.WBST,a.KOTDATE ,a,TAXCODE ,a.TAXPERCENT   from VIEW_WBST  A,MEMBERMASTER B  WHERE MONTH(KOTDATE) = " & month1 & " and a.mcode=b.MCODE and b.membertypecode in(" & membertype & ") "

            End If
            Call Viewer.GetDetails1(sql, "member_consumption", r)
            Call Viewer.GetDetails1(sqlstrinG, "bengal_monthbill", r)
            Call Viewer.GetDetails2(sqlstring3, "View_DRCR_SUM", r)
            ' Call Viewer.GetDetails3(SSQL4, "VIEW_WBST", r)


            Dim name, add1, add2, add3, city, state, pin, cell As String

            'name = gdataset.Tables("bengal_monthbill").Rows(0).Item("mname")
            'add1 = gdataset.Tables("bengal_monthbill").Rows(0).Item("contadd1")
            'add2 = gdataset.Tables("bengal_monthbill").Rows(0).Item("contadd2")
            'add3 = gdataset.Tables("bengal_monthbill").Rows(0).Item("contadd3")
            'city = gdataset.Tables("bengal_monthbill").Rows(0).Item("contcity")
            'pin = gdataset.Tables("bengal_monthbill").Rows(0).Item("contpin")
            'cell = gdataset.Tables("bengal_monthbill").Rows(0).Item("contcell")


            'Call Viewer.GetDetails1(ssql2, "month_bill", r)
            'Call Viewer.GetDetails1(sqlstring1, "View_Rec_Det", r)
            'Call Viewer.GetDetails1(sqlstring3, "View_drcr_Det", r)
            'Call Viewer.GetDetails1(sqlstring2, "accountsSetUp", r)
            'Dim txtobj1 As TextObject
            'Dim txtobj As TextObject
            'Dim txtobj2 As TextObject
            Dim txtobj15 As TextObject
            Dim txtobj19 As TextObject
            Dim txtobj20 As TextObject

            'Dim txtobj48 As TextObject
            'txtobj48 = r.ReportDefinition.ReportObjects("Text48")
            'txtobj48.Text = txt_msg.Text

            Dim txtobj1 As TextObject
            Dim duedt As Date

            txtobj1 = r.ReportDefinition.ReportObjects("Text2")
            duedt = DTPduedate.Value
            txtobj1.Text = Format(duedt, "dd/MMM/yyyy")

            '" & Format(DTPduedate.Value, "dd/MMM/yyyy") & "'
            'txtobj19 = r.ReportDefinition.ReportObjects("Text20")
            'txtobj19.Text = month & " " & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))

            'Dim convdate As Date
            'txtobj20 = r.ReportDefinition.ReportObjects("Text24")
            'convdate = noofdays & "-" & IIf(month1 > 9, Str(month1), "0" & month1) & "-" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))
            'txtobj20.Text = Format(convdate, "dd MMM yyyy")

            'txtobj15 = r.ReportDefinition.ReportObjects("Text22")
            'txtobj15.Text = "/" & month & "/" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4)) & "/Regular"


            'txtobj19 = r.ReportDefinition.ReportObjects("Text31")
            'txtobj19.Text = month & " " & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))

            ''Dim convdate1 As Date
            'txtobj20 = r.ReportDefinition.ReportObjects("Text35")
            'convdate = noofdays & "-" & IIf(month1 > 9, Str(month1), "0" & month1) & "-" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))
            'txtobj20.Text = Format(convdate, "dd MMM yyyy")

            'txtobj15 = r.ReportDefinition.ReportObjects("Text33")
            'txtobj15.Text = "/" & month & "/" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4)) & "/Regular"

            'Dim txtobj18 As TextObject
            'txtobj18 = r.ReportDefinition.ReportObjects("Text5")
            ' txtobj18.Text = noofdays & "-" & IIf(month1 > 9, Str(month1), "0" & month1) & "-" & IIf(month1 > 3, gFinancalyearStart, Mid(gFinancialyearEnd, 1, 4))


            'Dim txtobj1 As TextObject
            'Dim duedt As Date
            'txtobj1 = r.ReportDefinition.ReportObjects("Text27")
            'duedt = DTPduedate.Value
            'txtobj1.Text = Format(duedt, "dd.MM.yyyy")

            ' '' ''Dim txtobj1 As TextObject
            '' ''txtobj1 = r.ReportDefinition.ReportObjects("Text4")
            '' ''txtobj1.Text = name
            '' ''txtobj1 = r.ReportDefinition.ReportObjects("Text5")
            '' ''txtobj1.Text = add1
            '' ''txtobj1 = r.ReportDefinition.ReportObjects("Text6")
            '' ''txtobj1.Text = add2
            '' ''txtobj1 = r.ReportDefinition.ReportObjects("Text7")
            '' ''txtobj1.Text = add3
            '' ''txtobj1 = r.ReportDefinition.ReportObjects("Text8")
            '' ''txtobj1.Text = city & "  " & pin
            'txtobj1 = r.ReportDefinition.ReportObjects("Text9")
            'txtobj1.Text = UCase(cell)
            'txtobj15.Text = UCase(gUsername)
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Rnd_Summary_CheckedChanged(sender As Object, e As EventArgs) Handles Rnd_Summary.CheckedChanged

    End Sub

    Private Sub Btn_PartyRoom_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmd_print_Click(sender As Object, e As EventArgs) Handles cmd_print.Click
        GPRINT = True
        GETSUMMARYDETAILS_PRINT_FNCC_dos()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        GPRINT = False
        GETSUMMARYDETAILS_PRINT_FNCC_dos()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
       
        Dim BDAT As DateTime
        sqlstring = "SELECT ISNULL(MAX(BILLDATE),0) AS BILLDATE FROM SUBSPOSTING WHERE MONTH(BILLDATE)=MONTH('" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "')"
        gconnection.getDataSet(sqlstring, "member")
        If gdataset.Tables("member").Rows.Count > 0 Then
            BDAT = gdataset.Tables("member").Rows(0).Item("BILLDATE")

            If BDAT = "01-01-1900 00:00:00.000" Then
                MsgBox("Please Select Currect Month Bill Date")
                Exit Sub
            End If
        End If
        Dim cmdText, SQLSTRING4, SQLSTRING5, SSQL3, ssql4, ssql5 As String
        Dim duedate, membertype, TYPE(0), BILDT1, BILDT5, month, MNAME As String
        Dim opl, i As Integer
        Dim DUEDT, AMT, amtb As String
        Dim AMT1 As Double
        DUEDT = Format(DTPduedate.Value, "dd/MMM/yyyy")

        Call Validation()
        If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month1 = 4 : month = "APR-" & gFinancalyearStart : noofdays = 30 : bildt = "01-may-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "30-apr-" & Mid(gFinancialyearStart, 7, 4) : BILDT5 = "01-apr-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : month = "MAY-" & gFinancalyearStart : noofdays = 31 : bildt = "01-jun-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "31-may-" & Mid(gFinancialyearStart, 7, 4) : BILDT5 = "01-may-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : month = "JUN-" & gFinancalyearStart : noofdays = 30 : bildt = "01-jul-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "30-jun-" & Mid(gFinancialyearStart, 7, 4) : BILDT5 = "01-jun-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : month = "JUL-" & gFinancalyearStart : noofdays = 31 : bildt = "01-aug-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "31-jul-" & Mid(gFinancialyearStart, 7, 4) : BILDT5 = "01-jul-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : month = "AUG-" & gFinancalyearStart : noofdays = 31 : bildt = "01-sep-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "31-aug-" & Mid(gFinancialyearStart, 7, 4) : BILDT5 = "01-aug-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : month = "SEP-" & gFinancalyearStart : noofdays = 30 : bildt = "01-oct-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "30-sep-" & Mid(gFinancialyearStart, 7, 4) : BILDT5 = "01-sep-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : month = "OCT-" & gFinancalyearStart : noofdays = 31 : bildt = "01-nov-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "31-oct-" & Mid(gFinancialyearStart, 7, 4) : BILDT5 = "01-oct-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : month = "NOV-" & gFinancalyearStart : noofdays = 30 : bildt = "01-dec-" & Mid(gFinancialyearStart, 7, 4) : BILDT1 = "30-nov-" & Mid(gFinancialyearStart, 7, 4) : BILDT5 = "01-nov-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : month = "DEC-" & gFinancalyearStart : noofdays = 31 : bildt = "01-jan-" & gFinancialyearEnd : BILDT1 = "31-dec-" & gFinancalyearStart : BILDT5 = "01-dec-" & gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : month = "JAN-" & gFinancialyearEnd : noofdays = 31 : bildt = "01-feb-" & gFinancialyearEnd : BILDT1 = "31-jan-" & gFinancialyearEnd : BILDT5 = "01-jan-" & gFinancialyearEnd

        If gFinancialyearEnd Mod 4 = 0 Then
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : month = "FEB-" & gFinancialyearEnd : noofdays = 29 : bildt = "01-mar-" & gFinancialyearEnd : BILDT1 = "29-feb-" & gFinancialyearEnd : BILDT5 = "01-feb-" & gFinancialyearEnd
        Else
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : month = "FEB-" & gFinancialyearEnd : noofdays = 28 : bildt = "01-mar-" & gFinancialyearEnd : BILDT1 = "28-feb-" & gFinancialyearEnd : BILDT5 = "01-feb-" & gFinancialyearEnd
        End If

        If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : month = "MAR-" & gFinancialyearEnd : noofdays = 31 : bildt = "01-apr-" & gFinancialyearEnd : BILDT1 = "31-mar-" & gFinancialyearEnd : BILDT5 = "01-mar-" & gFinancialyearEnd
        ' Dim Viewer As New REPORTVIEWER
        'Dim r As New CRY_MONTHBILLSUMMARY
        'ISNULL(S.ADDRESS1,'') AS CADD1,ISNULL(S.ADDRESS2,'') AS CADD2,ISNULL(S.ADDRESS3,'') AS CADD3,ISNULL(S.ADDRESS4,'') AS CCITY,
        ' Dim r As New Cry_Monthbill_Summary_Details_KC

        sqlstring = " ALTER  VIEW LASTMONTHOUT AS SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+' '+ ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.MEMBERTYPE,'')AS TempTermReason,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL_SMS O,MEMBERMASTER M WHERE SUBSTRING(M.MCODE,1,8) = SUBSTRING(O.SLCODE,1,8) " '  AND  LTRIM(RTRIM(M.Mcode)) = '" & MCODE & "'  "
        sqlstring = sqlstring & " AND cast(convert(varchar(11),O.BILLDATE,106) as datetime) <'" & BILDT5 & "' AND  CURENTSTATUS in('ACTIVE','LIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.membertype,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE  "
        sqlstring = sqlstring & " UNION ALL SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+' '+ ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.MEMBERTYPE,'')AS TempTermReason,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.CREDIT) * -1)  AS CREDITLIMIT FROM OPENINGBAL_SMS O,MEMBERMASTER M WHERE SUBSTRING(M.MCODE,1,8) = SUBSTRING(O.SLCODE,1,8)  " 'AND  LTRIM(RTRIM(M.Mcode)) = '" & MCODE & "'  "
        sqlstring = sqlstring & " AND cast(convert(varchar(11),O.BILLDATE,106) as datetime) >='" & BILDT5 & "' AND  CURENTSTATUS in('ACTIVE','LIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.membertype,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE  "
        gconnection.getDataSet(sqlstring, "OUT")

        sqlstring = "drop table LASTMONTHOUT_Temp"
        gconnection.getDataSet(sqlstring, "OUT")

        sqlstring = "select * into LASTMONTHOUT_Temp from LASTMONTHOUT"
        gconnection.getDataSet(sqlstring, "OUT")

        If Trim(txt_mcode.Text) <> "" And Trim(txt_Tomcode.Text) <> "" Then
            sqlstring = " SELECT M.MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,"
            sqlstring = sqlstring & " ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPE,'')AS TempTermReason,"
            sqlstring = sqlstring & "  ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPE,'')AS TempTermReason,"
            sqlstring = sqlstring & "ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, "
            sqlstring = sqlstring & "  '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL_SMS O,MEMBERMASTER M"
            sqlstring = sqlstring & "   WHERE M.MCODE = O.SLCODE AND M.MCODE  "
            sqlstring = sqlstring & "  BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "' AND O.BILLDATE < '" & bildt & "' AND  CURENTSTATUS IN('LIVE','ACTIVE') AND ISNULL(FREEZE,'')<>'Y'"
            sqlstring = sqlstring & " AND M.MEMBERTYPECODE NOT IN('ABN','CM') GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,"
            sqlstring = sqlstring & " M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE,m.membertype  ORDER BY M.MCODE "

        ElseIf Trim(txt_Tomcode.Text) = "" And Trim(txt_mcode.Text) <> "" Then
            sqlstring = " SELECT M.MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,"
            sqlstring = sqlstring & " ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,"
            sqlstring = sqlstring & " ISNULL(M.MEMBERTYPE,'')AS TempTermReason, "
            sqlstring = sqlstring & "  ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, "
            sqlstring = sqlstring & " (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL_SMS O,MEMBERMASTER M  WHERE M.MCODE = O.SLCODE AND M.MCODE '" & txt_mcode.Text & "'  AND O.BILLDATE < '" & bildt & "' AND  "
            sqlstring = sqlstring & " CURENTSTATUS IN('LIVE','ACTIVE') AND ISNULL(FREEZE,'')<>'Y' AND M.MEMBERTYPECODE NOT IN('ABN','CM') GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE,m.membertype  ORDER BY M.MCODE "

        ElseIf Trim(txt_Tomcode.Text) <> "" And Trim(txt_mcode.Text) = "" Then
            sqlstring = " SELECT M.MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3, "
            sqlstring = sqlstring & " ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPE,'')AS TempTermReason,"
            sqlstring = sqlstring & " ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, "
            sqlstring = sqlstring & " '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL_SMS O,MEMBERMASTER M "
            sqlstring = sqlstring & "   WHERE M.MCODE = O.SLCODE AND M.MCODE = '" & txt_Tomcode.Text & "'  AND O.BILLDATE < '" & bildt & "' AND "
            sqlstring = sqlstring & " CURENTSTATUS IN('LIVE','ACTIVE') AND ISNULL(FREEZE,'')<>'Y' AND M.MEMBERTYPECODE NOT IN('ABN','CM') GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,"
            sqlstring = sqlstring & " M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE,m.membertype  ORDER BY M.MCODE "

        Else
            ' membertype = ""

            If chk_Filter_Field.CheckedItems.Count > 0 Then
                For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                    TYPE = Split(chk_Filter_Field.CheckedItems(i), ".")
                    membertype = membertype & "'" & TYPE(0) & "', "
                Next
                membertype = Mid(membertype, 1, Len(membertype) - 2)

            Else
                MessageBox.Show("Select the Category(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                chk_Filter_Field.Focus()

                Exit Sub
            End If
            
        End If
        If Trim(txt_mcode.Text) <> "" And Trim(txt_Tomcode.Text) <> "" Then
            sqlstring = "SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+' '+ ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.MEMBERTYPE,'')AS TempTermReason,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL_SMS O,MEMBERMASTER M WHERE SUBSTRING(M.MCODE,1,8) = SUBSTRING(O.SLCODE,1,8)  AND  LTRIM(RTRIM(M.Mcode)) BETWEEN '" & txt_mcode.Text & "' AND '" & txt_Tomcode.Text & "'  "
            sqlstring = sqlstring & " AND O.BILLDATE <'" & bildt & "' AND  CURENTSTATUS in('ACTIVE','LIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.membertype,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE ORDER BY M.MCODE"
        Else
            sqlstring = "SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+' '+ ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.MEMBERTYPE,'')AS TempTermReason,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL_SMS O,MEMBERMASTER M WHERE SUBSTRING(M.MCODE,1,8) = SUBSTRING(O.SLCODE,1,8)  AND LTRIM(RTRIM(m.membertypecode)) IN(" & membertype & ")  "
            sqlstring = sqlstring & " AND O.BILLDATE <'" & bildt & "' AND  CURENTSTATUS in('ACTIVE','LIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.membertype,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE ORDER BY M.MCODE"
        End If
        gconnection.getDataSet(sqlstring, "member")

        If MsgBox("Do You Want To Send a SMS", MsgBoxStyle.YesNo, "Clubman") = MsgBoxResult.Yes Then
            If gdataset.Tables("member").Rows.Count > 0 Then
                Dim mcode, mobileno, MESSAGE As String
                Dim amount, asonamount As Double
                For i = 0 To gdataset.Tables("member").Rows.Count - 1
                    mcode = gdataset.Tables("member").Rows(i).Item("mcode")
                    mobileno = gdataset.Tables("member").Rows(i).Item("contcell")
                    amount = gdataset.Tables("member").Rows(i).Item("creditlimit")
                    MNAME = gdataset.Tables("member").Rows(i).Item("MNAME")

                    sqlstring1 = "SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+' '+ ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.MEMBERTYPE,'')AS TempTermReason,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL_SMS O,MEMBERMASTER M WHERE SUBSTRING(M.MCODE,1,8) =  '" & mcode & "' "
                    sqlstring1 = sqlstring1 & "   AND  CURENTSTATUS in('ACTIVE','LIVE') AND ISNULL(FREEZE,'')<>'Y' and o.SLCODE=m.mcode  GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.membertype,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE ORDER BY M.MCODE"
                    gconnection.getDataSet(sqlstring1, "blance")
                    asonamount = 0
                    If gdataset.Tables("blance").Rows.Count > 0 Then
                        asonamount = gdataset.Tables("blance").Rows(0).Item("creditlimit")
                    End If
                    If amount > 0 Then
                        AMT = amount & ""
                        AMT1 = amount
                    Else
                        AMT = (amount) * -1 & ""
                        AMT1 = amount
                    End If

                    If asonamount > 0 Then
                        amtb = asonamount
                    Else
                        amtb = (asonamount)
                    End If
                    If mobileno <> "" Then

                        ' mobileno = "9502425210"

                        Call send_sms(MNAME, mcode, month, AMT, mobileno, DUEDT, amtb, AMT1)
                    End If
                Next
                MsgBox("SMS sent Sucessfully")
            End If
        End If
    End Sub
    Private Sub send_sms(ByVal mname As String, ByVal MCODE As String, ByVal MONTH1 As String, ByVal balance As String, ByVal MOBILE As String, ByVal duedate As Date, ByVal balance1 As String, ByVal amt1 As String)
        Dim SQLSTRING, bildt5, month2 As String
        Dim MESSAGE As String
        Dim drcr, drcr1 As String
        Dim balance2 As Double
        If gFinancialyearEnd Mod 4 = 0 Then
            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month2 = "MAR" : bildt5 = "01-APR-" & Mid(gFinancialyearStart, 7, 4)
        Else
            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month2 = "MAR" : bildt5 = "01-APR-" & Mid(gFinancialyearStart, 7, 4)
        End If

        '  If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then MONTH1 = 4 : bildt5 = "30-jun-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month2 = "APR" : bildt5 = "01-MAY-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month2 = "MAY" : bildt5 = "01-JUN-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month2 = "JUN" : bildt5 = "01-JUL-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month2 = "JUL" : bildt5 = "01-AUG-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month2 = "AUG" : bildt5 = "01-SEP-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month2 = "SEP" : bildt5 = "01-OCT-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month2 = "OCT" : bildt5 = "01-NOV-" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month2 = "NOV" : bildt5 = "01-DEC-" & gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month2 = "DEC" : bildt5 = "01-JAN-" & gFinancialyearEnd

        If gFinancialyearEnd Mod 4 = 0 Then
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month2 = "JAN" : bildt5 = "01-FRB-" & gFinancialyearEnd
        Else
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month2 = "JAN" : bildt5 = "01-FEB-" & gFinancialyearEnd
        End If

        If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month2 = "FEB" : bildt5 = "01-MAR-" & gFinancialyearEnd


        'SQLSTRING = " ALTER  VIEW LASTMONTHOUT AS SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+' '+ ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.MEMBERTYPE,'')AS TempTermReason,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL_SMS O,MEMBERMASTER M WHERE SUBSTRING(M.MCODE,1,8) = SUBSTRING(O.SLCODE,1,8)  AND  LTRIM(RTRIM(M.Mcode)) = '" & MCODE & "'  "
        'SQLSTRING = SQLSTRING & " AND cast(convert(varchar(11),O.BILLDATE,106) as datetime) <='" & bildt5 & "' AND  CURENTSTATUS in('ACTIVE','LIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.membertype,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE  "
        'SQLSTRING = SQLSTRING & " UNION ALL SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+' '+ ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.MEMBERTYPE,'')AS TempTermReason,ISNULL(M.CONTCITY,'') AS CONTCITY,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell,ISNULL(M.MEMBERTYPECODE,'')AS MEMBERTYPECODE, '" & Format(CbxMonth.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.CREDIT) * -1)  AS CREDITLIMIT FROM OPENINGBAL_SMS O,MEMBERMASTER M WHERE SUBSTRING(M.MCODE,1,8) = SUBSTRING(O.SLCODE,1,8)  AND  LTRIM(RTRIM(M.Mcode)) = '" & MCODE & "'  "
        'SQLSTRING = SQLSTRING & " AND cast(convert(varchar(11),O.BILLDATE,106) as datetime) >'" & bildt5 & "' AND  CURENTSTATUS in('ACTIVE','LIVE') AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.membertype,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,MEMBERTYPECODE  "
        'gconnection.getDataSet(SQLSTRING, "OUT")

        SQLSTRING = "SELECT SUM(CREDITLIMIT) AS CREDITLIMIT  FROM LASTMONTHOUT_Temp WHERE MCODE='" & MCODE & "' "
        gconnection.getDataSet(SQLSTRING, "member1")

        balance2 = 0
        If gdataset.Tables("member1").Rows.Count > 0 Then
            balance2 = gdataset.Tables("member1").Rows(0).Item("creditlimit")
        End If
        Dim msg, Tempid, Typemsg As String
        msg = ""
        Tempid = ""
        If balance2 > 0 Then
           
            SQLSTRING = "select * from smstemplatemaster where SMSType='Month Bill'"
            Typemsg = "OverDue"

            gconnection.getDataSet(SQLSTRING, "SM_SMSDETAILS")
            If gdataset.Tables("SM_SMSDETAILS").Rows.Count > 0 Then
                msg = Trim(gdataset.Tables("SM_SMSDETAILS").Rows(0).Item("MsgBody"))
                Tempid = Trim(gdataset.Tables("SM_SMSDETAILS").Rows(0).Item("TemplateID"))
            Else
                MsgBox("Month Bill SMS Template Not Found")
                Exit Sub
            End If
            Dim a, b, c, d, e, f, g As String
            a = "@Mcode"
            b = "@Mname"
            c = "@Balance"
            d = "@BillDate"
            e = "@DueDate"
            f = "@LastMonth"
            g = "@LastBal"
            msg = msg.Replace(a, MCODE)
            msg = msg.Replace(b, mname)
            msg = msg.Replace(c, Val(balance))
            msg = msg.Replace(d, MONTH1)
            msg = msg.Replace(e, duedate)
            msg = msg.Replace(f, month2)
            msg = msg.Replace(g, balance2)

            MESSAGE = msg
            'MESSAGE = "Dear Mr. " & mname & ", NC NO- " & MCODE & " Bill For the Month of " & MONTH1 & " is Being Dispatched. Total Due Amount Rs. " & Val(balance) & " Due Date  " & duedate & "  "
            'MESSAGE = "Dear Mr. " & mname & ", MCRC NO- " & MCODE & " Bill For the Month of " & MONTH1 & " is Being Dispatched. Total Due Amount Rs. " & balance & " Due Date  " & duedate & " "
            'MESSAGE = MESSAGE & " (should clear " & month2 & " month due:" & balance2 & ", To avail the facility.)"
        Else
            If amt1 > 0 Then
                SQLSTRING = "select * from smstemplatemaster where SMSType='Month Bill1'"
                Typemsg = "OverDue"

                gconnection.getDataSet(SQLSTRING, "SM_SMSDETAILS")
                If gdataset.Tables("SM_SMSDETAILS").Rows.Count > 0 Then
                    msg = Trim(gdataset.Tables("SM_SMSDETAILS").Rows(0).Item("MsgBody"))
                    Tempid = Trim(gdataset.Tables("SM_SMSDETAILS").Rows(0).Item("TemplateID"))
                Else
                    MsgBox("Month Bill SMS Template Not Found")
                    Exit Sub
                End If
                Dim a, b, c, d, e, f, g As String
                a = "@Mcode"
                b = "@Mname"
                c = "@Balance"
                d = "@BillDate"
                e = "@DueDate"
                f = "@LastMonth"
                g = "@LastBal"
                msg = msg.Replace(a, MCODE)
                msg = msg.Replace(b, mname)
                msg = msg.Replace(c, Val(balance))
                msg = msg.Replace(d, MONTH1)
                msg = msg.Replace(e, duedate)
                msg = msg.Replace(f, month2)
                msg = msg.Replace(g, balance2)

                MESSAGE = msg
                '  MESSAGE = "Dear Mr. " & mname & ", MCRC NO- " & MCODE & " Bill For the Month of " & MONTH1 & " is Being Dispatched. Total Due Amount Rs. " & balance & "  Due Date  " & duedate & ""
            Else
                SQLSTRING = "select * from smstemplatemaster where SMSType='Month Bill2'"
                Typemsg = "OverDue"

                gconnection.getDataSet(SQLSTRING, "SM_SMSDETAILS")
                If gdataset.Tables("SM_SMSDETAILS").Rows.Count > 0 Then
                    msg = Trim(gdataset.Tables("SM_SMSDETAILS").Rows(0).Item("MsgBody"))
                    Tempid = Trim(gdataset.Tables("SM_SMSDETAILS").Rows(0).Item("TemplateID"))
                Else
                    MsgBox("Month Bill SMS Template Not Found")
                    Exit Sub
                End If
                Dim a, b, c, d, e, f, g As String
                a = "@Mcode"
                b = "@Mname"
                c = "@Balance"
                d = "@BillDate"
                e = "@DueDate"
                f = "@LastMonth"
                g = "@LastBal"
                msg = msg.Replace(a, MCODE)
                msg = msg.Replace(b, mname)
                msg = msg.Replace(c, Val(balance))
                msg = msg.Replace(d, MONTH1)
                msg = msg.Replace(e, duedate)
                msg = msg.Replace(f, month2)
                msg = msg.Replace(g, balance2)

                MESSAGE = msg
                '   MESSAGE = "Dear Mr. " & mname & ", MCRC NO- " & MCODE & " Bill For the Month of " & MONTH1 & " is Being Dispatched. Total Credit Amount Rs. " & balance & ""
            End If
        End If

        ' and Ason your outstanding Rs." & balance1 & "  "
        Dim USERID, SID, PWD, ROUTE As String
        Dim i As Integer
        SQLSTRING = "SELECT * FROM SM_SMSDETAILS"
        gconnection.getDataSet(SQLSTRING, "SM_SMSDETAILS")
        If gdataset.Tables("SM_SMSDETAILS").Rows.Count > 0 Then
            USERID = Trim(gdataset.Tables("SM_SMSDETAILS").Rows(i).Item("USERID"))
            SID = Trim(gdataset.Tables("SM_SMSDETAILS").Rows(i).Item("SENDERID"))
            PWD = Trim(gdataset.Tables("SM_SMSDETAILS").Rows(i).Item("PWD"))
            ROUTE = Trim(gdataset.Tables("SM_SMSDETAILS").Rows(i).Item("SROUTE"))
            'MBLNO = "9666056232"
        End If
        'MBLNO = 9943884124
        Call SendgSMS(MCODE, PWD, MOBILE, MESSAGE, Tempid)
        'Call gconnection.SMS(MOBILE, MESSAGE)

    End Sub
    Public Function SendgSMS(ByVal User As String, ByVal password As String, ByVal Mobile_Number As String, ByVal Message As String, ByVal Tempid As String, Optional ByVal MType As String = "N", Optional ByVal DR As String = "N", Optional ByVal SP As String = "N") As String
        Dim url, strPostData As String
        sqlstring = "select * from smstemplatemaster where SMSType='API'"
        gconnection.getDataSet(sqlstring, "SM_SMSDETAILS")
        If gdataset.Tables("SM_SMSDETAILS").Rows.Count > 0 Then
            url = Trim(gdataset.Tables("SM_SMSDETAILS").Rows(0).Item("MsgBody"))
        Else
            MsgBox("API Not Found")
            Exit Function
        End If
        Dim a, b, c As String
        a = "@Contcell"
        b = "@mssg"
        c = "@Tempid"
        url = url.Replace(c, Tempid)
        url = url.Replace(a, Mobile_Number)
        url = url.Replace(b, Message)

        strPostData = url
        'End If

        sqlstring = "INSERT INTO SENDSMS VALUES('" & User & "','" & strPostData & "','N','" & Mobile_Number & "','" & Format(Now.Date(), "dd MMM yyyy") & "','Month Bill')"
        gconnection.getDataSet(sqlstring, "SENDSMS")

        ' Dim stringpost As System.Object = "username=mcrclb&apikey=4e97ccf9213180227c89&senderid=MCRCLB&templateid=1707160380244667966&mobile=" & Mobile_Number & "&message=" & Message
        ' '''& "&SID=" & SID & "&MTYPE=" & MType & "&DR=" & DR & "&sp=" & SP

        'Dim functionReturnValue As String = Nothing
        'functionReturnValue = ""

        'Dim objWebRequest As HttpWebRequest = Nothing
        'Dim objWebResponse As HttpWebResponse = Nothing
        'Dim objStreamWriter As StreamWriter = Nothing
        'Dim objStreamReader As StreamReader = Nothing

        'Try
        '    Dim stringResult As String = Nothing

        '    ''objWebRequest = DirectCast(WebRequest.Create("http://www.smscountry.com/SMSCwebservice.asp?"), HttpWebRequest)
        '    If Mid(UCase(Trim(gCompanyname)), 1, 3) = "THE" Then
        '        objWebRequest = DirectCast(WebRequest.Create("http://smslogin.mobi/spanelv2/api.php?"), HttpWebRequest)
        '    ElseIf Mid(UCase(Trim(gcompanyname)), 1, 3) = "MLA" Then
        '        ' objWebRequest = DirectCast(WebRequest.Create("http://bulk.kitesms.com/spanelv2/api.php?"), HttpWebRequest)
        '        objWebRequest = DirectCast(WebRequest.Create("http://bulk.kitesms.com/v3/api.php?"), HttpWebRequest)
        '    End If

        '    objWebRequest.Method = "POST"

        '    If Not objProxy1 Is Nothing Then
        '        objWebRequest.Proxy = objProxy1
        '    End If

        '    ' Use below code if you want to SETUP PROXY. 
        '    'Parameters to pass: 1. ProxyAddress 2. Port 
        '    'You can find both the parameters in Connection settings of your internet explorer.

        '    'Dim myProxy As New WebProxy("YOUR PROXY", PROXPORT)
        '    'myProxy.BypassProxyOnLocal = True
        '    'wrGETURL.Proxy = myProxy

        '    objWebRequest.ContentType = "application/x-www-form-urlencoded"

        '    objStreamWriter = New StreamWriter(objWebRequest.GetRequestStream())
        '    objStreamWriter.Write(stringpost)
        '    objStreamWriter.Flush()
        '    objStreamWriter.Close()

        '    objWebResponse = DirectCast(objWebRequest.GetResponse(), HttpWebResponse)
        '    objStreamReader = New StreamReader(objWebResponse.GetResponseStream())

        '    stringResult = objStreamReader.ReadToEnd()

        '    objStreamReader.Close()
        '    Return (stringResult)
        'Catch ex As Exception
        '    Return (ex.Message)
        'Finally
        '    If Not objStreamWriter Is Nothing Then
        '        objStreamWriter.Close()
        '    End If
        '    If Not objStreamReader Is Nothing Then
        '        objStreamReader.Close()
        '    End If
        '    objWebRequest = Nothing
        '    objWebResponse = Nothing
        '    objProxy1 = Nothing
        'End Try
    End Function

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class
