Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.SqlClient
Public Class BULK_DR

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
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents frmbut As System.Windows.Forms.GroupBox
    Friend WithEvents CmdAdd As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents SSGrid_AccountSetup As AxFPSpreadADO.AxfpSpread
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Dtp_VoucherDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt_VoucherNo As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_VoucherNoHelp As System.Windows.Forms.Button
    Friend WithEvents CmdDelete As System.Windows.Forms.Button
    Friend WithEvents lbl_void As System.Windows.Forms.Label
    Friend WithEvents Txt_reason As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txt_taxcode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txt_oppgl As System.Windows.Forms.TextBox
    Friend WithEvents Txt_amount As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Filter_Field As System.Windows.Forms.CheckedListBox
    Friend WithEvents chk_PrintAll As System.Windows.Forms.CheckBox
    Friend WithEvents Cmd_FillData As System.Windows.Forms.Button
    Friend WithEvents cmd_taxcodehelp As System.Windows.Forms.Button
    Friend WithEvents cmd_glCodeHelp As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BULK_DR))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SSGrid_AccountSetup = New AxFPSpreadADO.AxfpSpread()
        Me.frmbut = New System.Windows.Forms.GroupBox()
        Me.CmdDelete = New System.Windows.Forms.Button()
        Me.CmdAdd = New System.Windows.Forms.Button()
        Me.CmdView = New System.Windows.Forms.Button()
        Me.cmdexit = New System.Windows.Forms.Button()
        Me.CmdClear = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Dtp_VoucherDate = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Txt_VoucherNo = New System.Windows.Forms.TextBox()
        Me.Cmd_VoucherNoHelp = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_void = New System.Windows.Forms.Label()
        Me.Txt_reason = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_taxcode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_oppgl = New System.Windows.Forms.TextBox()
        Me.Txt_amount = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chk_Filter_Field = New System.Windows.Forms.CheckedListBox()
        Me.chk_PrintAll = New System.Windows.Forms.CheckBox()
        Me.Cmd_FillData = New System.Windows.Forms.Button()
        Me.cmd_taxcodehelp = New System.Windows.Forms.Button()
        Me.cmd_glCodeHelp = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        CType(Me.SSGrid_AccountSetup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmbut.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(187, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(215, 25)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "BULK DEBIT"
        '
        'SSGrid_AccountSetup
        '
        Me.SSGrid_AccountSetup.DataSource = Nothing
        Me.SSGrid_AccountSetup.Location = New System.Drawing.Point(81, 334)
        Me.SSGrid_AccountSetup.Name = "SSGrid_AccountSetup"
        Me.SSGrid_AccountSetup.OcxState = CType(resources.GetObject("SSGrid_AccountSetup.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSGrid_AccountSetup.Size = New System.Drawing.Size(756, 343)
        Me.SSGrid_AccountSetup.TabIndex = 88
        '
        'frmbut
        '
        Me.frmbut.BackColor = System.Drawing.Color.Transparent
        Me.frmbut.Controls.Add(Me.CmdDelete)
        Me.frmbut.Controls.Add(Me.CmdAdd)
        Me.frmbut.Controls.Add(Me.CmdView)
        Me.frmbut.Controls.Add(Me.cmdexit)
        Me.frmbut.Controls.Add(Me.CmdClear)
        Me.frmbut.Location = New System.Drawing.Point(862, 147)
        Me.frmbut.Name = "frmbut"
        Me.frmbut.Size = New System.Drawing.Size(141, 321)
        Me.frmbut.TabIndex = 90
        Me.frmbut.TabStop = False
        '
        'CmdDelete
        '
        Me.CmdDelete.BackColor = System.Drawing.Color.Transparent
        Me.CmdDelete.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources.Delete
        Me.CmdDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdDelete.Enabled = False
        Me.CmdDelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CmdDelete.Location = New System.Drawing.Point(2, 252)
        Me.CmdDelete.Name = "CmdDelete"
        Me.CmdDelete.Size = New System.Drawing.Size(137, 51)
        Me.CmdDelete.TabIndex = 5
        Me.CmdDelete.Text = "Delete[F8]"
        Me.CmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdDelete.UseVisualStyleBackColor = False
        '
        'CmdAdd
        '
        Me.CmdAdd.BackColor = System.Drawing.Color.Transparent
        Me.CmdAdd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAdd.ForeColor = System.Drawing.Color.Black
        Me.CmdAdd.Image = Global.Bengal_MemberMaster.My.Resources.Resources.save
        Me.CmdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdAdd.Location = New System.Drawing.Point(2, 76)
        Me.CmdAdd.Name = "CmdAdd"
        Me.CmdAdd.Size = New System.Drawing.Size(137, 50)
        Me.CmdAdd.TabIndex = 0
        Me.CmdAdd.Text = "Add [F7]"
        Me.CmdAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdAdd.UseVisualStyleBackColor = False
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.Transparent
        Me.CmdView.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdView.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.Black
        Me.CmdView.Image = Global.Bengal_MemberMaster.My.Resources.Resources.view
        Me.CmdView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdView.Location = New System.Drawing.Point(2, 136)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(137, 50)
        Me.CmdView.TabIndex = 3
        Me.CmdView.Text = "View[F9]"
        Me.CmdView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdView.UseVisualStyleBackColor = False
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.Transparent
        Me.cmdexit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdexit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.Black
        Me.cmdexit.Image = Global.Bengal_MemberMaster.My.Resources.Resources._Exit
        Me.cmdexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdexit.Location = New System.Drawing.Point(2, 196)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(137, 50)
        Me.cmdexit.TabIndex = 4
        Me.cmdexit.Text = "Exit [F11]"
        Me.cmdexit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdexit.UseVisualStyleBackColor = False
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.Transparent
        Me.CmdClear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.Black
        Me.CmdClear.Image = Global.Bengal_MemberMaster.My.Resources.Resources.Clear
        Me.CmdClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdClear.Location = New System.Drawing.Point(2, 16)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(137, 50)
        Me.CmdClear.TabIndex = 1
        Me.CmdClear.Text = "Clear [F6]"
        Me.CmdClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdClear.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Location = New System.Drawing.Point(179, 316)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(684, 367)
        Me.GroupBox1.TabIndex = 92
        Me.GroupBox1.TabStop = False
        '
        'Dtp_VoucherDate
        '
        Me.Dtp_VoucherDate.CustomFormat = "dd-MMM-yyyy"
        Me.Dtp_VoucherDate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_VoucherDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp_VoucherDate.Location = New System.Drawing.Point(343, 15)
        Me.Dtp_VoucherDate.Name = "Dtp_VoucherDate"
        Me.Dtp_VoucherDate.Size = New System.Drawing.Size(110, 22)
        Me.Dtp_VoucherDate.TabIndex = 922
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(274, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(59, 23)
        Me.Label20.TabIndex = 923
        Me.Label20.Text = "Doc.Date"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Txt_VoucherNo)
        Me.GroupBox2.Controls.Add(Me.Cmd_VoucherNoHelp)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Dtp_VoucherDate)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Location = New System.Drawing.Point(353, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(470, 43)
        Me.GroupBox2.TabIndex = 924
        Me.GroupBox2.TabStop = False
        '
        'Txt_VoucherNo
        '
        Me.Txt_VoucherNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_VoucherNo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_VoucherNo.Location = New System.Drawing.Point(55, 13)
        Me.Txt_VoucherNo.MaxLength = 20
        Me.Txt_VoucherNo.Name = "Txt_VoucherNo"
        Me.Txt_VoucherNo.Size = New System.Drawing.Size(187, 22)
        Me.Txt_VoucherNo.TabIndex = 928
        '
        'Cmd_VoucherNoHelp
        '
        Me.Cmd_VoucherNoHelp.Image = CType(resources.GetObject("Cmd_VoucherNoHelp.Image"), System.Drawing.Image)
        Me.Cmd_VoucherNoHelp.Location = New System.Drawing.Point(246, 13)
        Me.Cmd_VoucherNoHelp.Name = "Cmd_VoucherNoHelp"
        Me.Cmd_VoucherNoHelp.Size = New System.Drawing.Size(25, 24)
        Me.Cmd_VoucherNoHelp.TabIndex = 930
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 23)
        Me.Label1.TabIndex = 924
        Me.Label1.Text = "Doc No"
        '
        'lbl_void
        '
        Me.lbl_void.AutoSize = True
        Me.lbl_void.BackColor = System.Drawing.Color.Transparent
        Me.lbl_void.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_void.ForeColor = System.Drawing.Color.Red
        Me.lbl_void.Location = New System.Drawing.Point(542, 47)
        Me.lbl_void.Name = "lbl_void"
        Me.lbl_void.Size = New System.Drawing.Size(144, 22)
        Me.lbl_void.TabIndex = 925
        Me.lbl_void.Text = "Deleted Voucher"
        Me.lbl_void.Visible = False
        '
        'Txt_reason
        '
        Me.Txt_reason.Location = New System.Drawing.Point(85, 119)
        Me.Txt_reason.MaxLength = 100
        Me.Txt_reason.Multiline = True
        Me.Txt_reason.Name = "Txt_reason"
        Me.Txt_reason.Size = New System.Drawing.Size(160, 53)
        Me.Txt_reason.TabIndex = 948
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 947
        Me.Label5.Text = "Reason"
        '
        'Txt_taxcode
        '
        Me.Txt_taxcode.Location = New System.Drawing.Point(86, 95)
        Me.Txt_taxcode.Name = "Txt_taxcode"
        Me.Txt_taxcode.Size = New System.Drawing.Size(100, 20)
        Me.Txt_taxcode.TabIndex = 946
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 945
        Me.Label4.Text = "Taxcode"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 944
        Me.Label3.Text = "Oppglcode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 943
        Me.Label2.Text = "Amount"
        '
        'Txt_oppgl
        '
        Me.Txt_oppgl.Location = New System.Drawing.Point(86, 68)
        Me.Txt_oppgl.Name = "Txt_oppgl"
        Me.Txt_oppgl.Size = New System.Drawing.Size(100, 20)
        Me.Txt_oppgl.TabIndex = 942
        '
        'Txt_amount
        '
        Me.Txt_amount.Location = New System.Drawing.Point(86, 41)
        Me.Txt_amount.Name = "Txt_amount"
        Me.Txt_amount.Size = New System.Drawing.Size(100, 20)
        Me.Txt_amount.TabIndex = 941
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.chk_Filter_Field)
        Me.GroupBox3.Location = New System.Drawing.Point(192, 122)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(381, 178)
        Me.GroupBox3.TabIndex = 940
        Me.GroupBox3.TabStop = False
        '
        'chk_Filter_Field
        '
        Me.chk_Filter_Field.BackColor = System.Drawing.Color.Gray
        Me.chk_Filter_Field.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Filter_Field.Location = New System.Drawing.Point(7, 24)
        Me.chk_Filter_Field.Name = "chk_Filter_Field"
        Me.chk_Filter_Field.Size = New System.Drawing.Size(368, 148)
        Me.chk_Filter_Field.Sorted = True
        Me.chk_Filter_Field.TabIndex = 609
        '
        'chk_PrintAll
        '
        Me.chk_PrintAll.BackColor = System.Drawing.Color.Transparent
        Me.chk_PrintAll.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PrintAll.Location = New System.Drawing.Point(192, 102)
        Me.chk_PrintAll.Name = "chk_PrintAll"
        Me.chk_PrintAll.Size = New System.Drawing.Size(264, 21)
        Me.chk_PrintAll.TabIndex = 939
        Me.chk_PrintAll.Text = "Select All Category"
        Me.chk_PrintAll.UseVisualStyleBackColor = False
        '
        'Cmd_FillData
        '
        Me.Cmd_FillData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_FillData.Location = New System.Drawing.Point(37, 9)
        Me.Cmd_FillData.Name = "Cmd_FillData"
        Me.Cmd_FillData.Size = New System.Drawing.Size(82, 22)
        Me.Cmd_FillData.TabIndex = 938
        Me.Cmd_FillData.Text = "Fill Data"
        Me.Cmd_FillData.UseVisualStyleBackColor = True
        '
        'cmd_taxcodehelp
        '
        Me.cmd_taxcodehelp.BackColor = System.Drawing.Color.Transparent
        Me.cmd_taxcodehelp.BackgroundImage = CType(resources.GetObject("cmd_taxcodehelp.BackgroundImage"), System.Drawing.Image)
        Me.cmd_taxcodehelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_taxcodehelp.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_taxcodehelp.Location = New System.Drawing.Point(188, 94)
        Me.cmd_taxcodehelp.Name = "cmd_taxcodehelp"
        Me.cmd_taxcodehelp.Size = New System.Drawing.Size(40, 23)
        Me.cmd_taxcodehelp.TabIndex = 950
        Me.cmd_taxcodehelp.UseVisualStyleBackColor = False
        '
        'cmd_glCodeHelp
        '
        Me.cmd_glCodeHelp.BackColor = System.Drawing.Color.Transparent
        Me.cmd_glCodeHelp.BackgroundImage = CType(resources.GetObject("cmd_glCodeHelp.BackgroundImage"), System.Drawing.Image)
        Me.cmd_glCodeHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_glCodeHelp.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_glCodeHelp.Location = New System.Drawing.Point(188, 64)
        Me.cmd_glCodeHelp.Name = "cmd_glCodeHelp"
        Me.cmd_glCodeHelp.Size = New System.Drawing.Size(40, 23)
        Me.cmd_glCodeHelp.TabIndex = 949
        Me.cmd_glCodeHelp.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.cmd_taxcodehelp)
        Me.GroupBox4.Controls.Add(Me.Cmd_FillData)
        Me.GroupBox4.Controls.Add(Me.cmd_glCodeHelp)
        Me.GroupBox4.Controls.Add(Me.Txt_amount)
        Me.GroupBox4.Controls.Add(Me.Txt_reason)
        Me.GroupBox4.Controls.Add(Me.Txt_oppgl)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Txt_taxcode)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(579, 113)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(266, 187)
        Me.GroupBox4.TabIndex = 951
        Me.GroupBox4.TabStop = False
        '
        'BULK_DR
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources._111in1024res
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 769)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.chk_PrintAll)
        Me.Controls.Add(Me.lbl_void)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.SSGrid_AccountSetup)
        Me.Controls.Add(Me.frmbut)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "BULK_DR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BULK DEBIT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.SSGrid_AccountSetup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmbut.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim strActype As String
    Dim VCONN As New GlobalClass
    Dim gconnection As New GlobalClass
    Dim VSEARCH As String


    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub


    Private Sub ReceiptsPayments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Resize_Form()
        Try

            GroupBox1.Controls.Add(SSGrid_AccountSetup)
            SSGrid_AccountSetup.Dock = DockStyle.Fill
            'GroupBox1.Controls.Add(SSGrid_AccountSetup)
            'SSGrid_AccountSetup.Location = New Point(70, 15)
            '' GRIDFILL()
            'GBL_FUNCTION_APPLY_DESIGN(Me)
            Dim ROW, COL As Integer
            SSGrid_AccountSetup.Row = 1
            SSGrid_AccountSetup.Col = 1
            SSGrid_AccountSetup.Focus()
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            CmdDelete.Enabled = False
            Me.lbl_void.Visible = False
            Dim ssql As String
            Dim MEMBERTYPE As New DataTable
            ssql = "select isnull(SUBTYPECODE,'') as membertype,isnull(SUBtypedesc,'') as typedesc from SUBCATEGORYMASTER  where isnull(Freeze ,'')<>'Y'"
            MEMBERTYPE = gconnection.GetValues(ssql)
            Dim Itration
            For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
                chk_Filter_Field.Items.Add(MEMBERTYPE.Rows(Itration).Item("Membertype") & "." & MEMBERTYPE.Rows(Itration).Item("TypeDesc"))
            Next
            Call autogenerate()
        Catch ex As Exception
            MessageBox.Show("Error on Page Load: " & ex.Message)
        End Try
    End Sub
    Private Sub GetRights()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql, SQLSTRING As String
        Dim M1 As New MainMenu
        Dim chstr As String
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='" & GmoduleName & "' AND MODULENAME LIKE '" & Trim(GmoduleName) & "%'"
        gconnection.getDataSet(SQLSTRING, "USER")
        If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                With gdataset.Tables("USER").Rows(i)
                    chstr = abcdMINUS(.Item("RIGHTS"))
                End With
            Next
        End If
        Me.CmdAdd.Enabled = False
        Me.CmdView.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.CmdAdd.Enabled = True
                    Me.CmdView.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.CmdAdd.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.CmdAdd.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.CmdAdd.Enabled = True
                    End If
                End If
                If Right(x) = "V" Then
                    Me.CmdView.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Function Duplicate() As Boolean
        Dim I As Integer
        Dim K As Integer
        Dim RMNO1, RMNO2 As String
        With SSGrid_AccountSetup
            For K = 1 To .DataRowCnt
                .Col = 1
                .Row = K
                RMNO1 = Trim(.Text)
                For I = 1 To .DataRowCnt
                    .Row = I
                    .Col = 1
                    RMNO2 = Trim(.Text)
                    If (I <> K) Then
                        If Trim(RMNO1) = Trim(RMNO2) Then
                            MsgBox(" MULTIPLE TIMES CODE SELECTION ", MsgBoxStyle.Critical, "PLS SELECT CODE ONCE")
                            Duplicate = True
                            .DeleteRows(.Row, 1)
                            .SetActiveCell(0, .ActiveRow)
                            .Focus()
                            Exit Function
                        End If
                    End If
                Next I
            Next K
            Duplicate = False
        End With
    End Function

    Function GRIDFILL()
        Dim STRSQL As String
        Dim i As Integer

        STRSQL = "SELECT ISNULL(voucherno,'') voucherno,ISNULL(slcode,'')slcode,isnull(reason,'')reason, ISNULL(sldesc,'')sldesc, ISNULL(amount,'0')amount, ISNULL(accountcode,'')accountcode, ISNULL(accountcodedesc,'')accountcodedesc, ISNULL(voucherdate,'')voucherdate,  Adduserid , Adddatetime,isnull(void,'')as void  FROM BULKDEBIT WHERE voucherno='" & Trim(Txt_VoucherNo.Text) & "' "
        VCONN.getDataSet(STRSQL, "TRANS")
        If gdataset.Tables("TRANS").Rows.Count > 0 Then
            Dtp_VoucherDate.Text = gdataset.Tables("TRANS").Rows(0).Item("voucherdate")
            With SSGrid_AccountSetup
                For i = 0 To gdataset.Tables("TRANS").Rows.Count - 1
                    .Col = 1
                    .Row = i + 1
                    .Text = Trim(gdataset.Tables("TRANS").Rows(i).Item("slcode"))
                    .Col = 2
                    .Row = i + 1
                    .Text = Trim(gdataset.Tables("TRANS").Rows(i).Item("sldesc"))
                    .Col = 3
                    .Row = i + 1
                    .Text = Trim(gdataset.Tables("TRANS").Rows(i).Item("amount"))
                    .Col = 4
                    .Row = i + 1
                    .Text = Trim(gdataset.Tables("TRANS").Rows(i).Item("accountcode"))
                    .Col = 5
                    .Row = i + 1
                    .Text = Trim(gdataset.Tables("TRANS").Rows(i).Item("accountcodedesc"))
                    .Col = 6
                    .Row = i + 1
                    .Text = Trim(gdataset.Tables("TRANS").Rows(i).Item("reason"))
                    '.Col = 7
                    '.Row = i + 1
                    '.Text = Trim(gdataset.Tables("TRANS").Rows(i).Item("COSTCENTERDESC"))



                Next
                Me.Txt_VoucherNo.Enabled = False
                Me.Dtp_VoucherDate.Enabled = False
                .SetActiveCell(1, 1)
                .Focus()
            End With
        End If
        ' End If
    End Function

    Public Function FillTYPE_ACCOUNTHD()
        With SSGrid_AccountSetup
            Dim vform As New LIST_OPERATION1
            gSQLString = "SELECT ACCODE, ACDESC  from accountsglaccountmaster "
            M_WhereCondition = " WHERE ISNULL(FREEZEFLAG,'')<>'Y' "
            vform.Field = "ACCODE,ACDESC"
            'vform.vFormatstring = "           CODE                                     |            DESCRIPTION                   "
            vform.vCaption = "ACCOUNT CODE HELP"
            'vform.KeyPos = 0
            'vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                .Col = 4
                .Row = .ActiveRow
                .Text = Trim(vform.keyfield)

                .Col = 5
                .Row = .ActiveRow
                .Text = Trim(vform.keyfield1)
                .SetActiveCell(5, .ActiveRow)
                .Focus()
            Else
                .Text = ""
                .SetActiveCell(4, .ActiveRow)
                .Focus()
            End If
            vform.Close()
            vform = Nothing
        End With
    End Function

    Public Function FillTYPE_COSTCENTER()
        With SSGrid_AccountSetup
            Dim vform As New LIST_OPERATION1
            gSQLString = "SELECT  COSTCENTERCODE,COSTCENTERDESC from ACCOUNTSCOSTCENTERMASTER "
            M_WhereCondition = " WHERE ISNULL(FREEZEFLAG,'')<>'Y' "
            vform.Field = "COSTCENTERCODE,COSTCENTERDESC"
            'vform.vFormatstring = "           CODE                                     |            DESCRIPTION                   "
            vform.vCaption = "ACCOUNT CODE HELP"
            ' vform.KeyPos = 0
            'vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                .Col = 6
                .Row = .ActiveRow
                .Text = Trim(vform.keyfield)

                .Col = 7
                .Row = .ActiveRow
                .Text = Trim(vform.keyfield1)


                .SetActiveCell(7, .ActiveRow)
                .Focus()
            Else

                .Text = ""
                .SetActiveCell(6, .ActiveRow)
                .Focus()
            End If
            vform.Close()
            vform = Nothing
        End With
    End Function


    Public Function FillTYPE()
        With SSGrid_AccountSetup
            Dim vform As New LIST_OPERATION1
            gSQLString = " Select  PACKAGECODE AS CODE, PACKAGENAME AS DESCRIPTION FROM ROOMPACKAGEMASTER  "
            gSQLString = gSQLString & " UNION ALL  SELECT CODE, DESCRIPTION FROM ROOMCONTROLMASTER where TYPE='SVM'  "
            M_WhereCondition = " AND ISNULL(FREEZE,'N')<>'Y' "
            vform.Field = "CODE,DESCRIPTION"
            'vform.vFormatstring = "           CODE                                          |            DESCRIPTION                                     "
            vform.vCaption = "ACCOUNT CODE SETUP HELP"
            'vform.KeyPos = 0
            'vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                .Col = 1
                .Row = .ActiveRow
                .Text = Trim(vform.keyfield)

                .Col = 2
                .Row = .ActiveRow
                .Text = Trim(vform.keyfield1)


                .SetActiveCell(3, .ActiveRow)
                .Focus()
            Else

                .Text = ""
                .SetActiveCell(0, .ActiveRow)
                .Focus()
            End If
            vform.Close()
            vform = Nothing
        End With
    End Function

    Private Sub SSGrid_ReceiptsPayments_KeyDownEvent(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles SSGrid_AccountSetup.KeyDownEvent
        ''Dim i, j, rooms As Integer
        ''Dim rate As Double
        ''Dim roomno, ratecode, ocptype, roomtype, MALE, FEMALE, CHILD, extrabed, ac, tv, locker, ssql As String
        ''If e.keyCode = Keys.F3 Then
        ''    SSGrid_AccountSetup.DeleteRows(SSGrid_AccountSetup.ActiveRow, 1)
        ''    SSGrid_AccountSetup.SetActiveCell(1, SSGrid_AccountSetup.ActiveRow)
        ''    SSGrid_AccountSetup.Focus()
        ''End If




        If e.keyCode = Keys.F3 Then
            Dim DCSTATUS As String
            With SSGrid_AccountSetup
                .Col = 1
                .Row = .ActiveRow
                DCSTATUS = .Text
                .DeleteRows(.ActiveRow, 1)
                .Col = 1
                .Row = .ActiveRow
            End With
        End If


        ''With SSGrid_AccountSetup
        ''    i = .ActiveRow
        ''    Dim rmrate, rmoctype As String
        ''    If .ActiveCol = 1 Then
        ''        .Col = 1
        ''        .Row = i
        ''        If Trim(.Text) = "" Then
        ''            Call FillTYPE()
        ''        ElseIf Trim(.Text) <> "" Then
        ''            roomtype = SSGrid_AccountSetup.Text
        ''            ssql = ssql & " Select  PACKAGECODE AS CODE, PACKAGENAME AS DESCRIPTION FROM ROOMPACKAGEMASTER  "
        ''            ssql = ssql & " UNION ALL  SELECT CODE, DESCRIPTION FROM ROOMCONTROLMASTER where TYPE='SVM'   "
        ''            M_WhereCondition = " AND ISNULL(FREEZE,'N')<>'Y' "
        ''            gconnection.getDataSet(ssql, "TYPEMASTER")
        ''            If gdataset.Tables("TYPEMASTER").Rows.Count > 0 Then
        ''                .Col = 1
        ''                .Text = Trim(gdataset.Tables("TYPEMASTER").Rows(0).Item("CODE"))
        ''                .Col = 2
        ''                .Text = Trim(gdataset.Tables("TYPEMASTER").Rows(0).Item("DESC"))
        ''                .SetActiveCell(2, i)
        ''                .Focus()
        ''            Else
        ''                MsgBox("TYPE NOT FOUND", MsgBoxStyle.Information)
        ''                .Text = ""
        ''                .SetActiveCell(0, i)
        ''                .Focus()
        ''            End If
        ''        End If
        ''    ElseIf .ActiveCol = 2 Then
        ''        .Col = 3
        ''        .Focus()
        ''    ElseIf .ActiveCol = 3 Then
        ''        .Col = 3
        ''        .Row = i
        ''        ratecode = .Text
        ''        If Trim(.Text) = "" Then
        ''            .Col = 3
        ''            .SetActiveCell(.Col, .ActiveRow)
        ''            .Col = 4
        ''            .SetActiveCell(.Col, .Row)
        ''            .Focus()
        ''        Else
        ''            .Col = 4
        ''            .SetActiveCell(.Col, .Row)
        ''            .Focus()
        ''        End If
        ''    ElseIf .ActiveCol = 4 Then
        ''        .Col = 4
        ''        .Row = i
        ''        ocptype = .Text
        ''        If Trim(.Text) = "" Then
        ''            Call FillTYPE_ACCOUNTHD()
        ''        ElseIf Trim(.Text) <> "" Then
        ''            .Col = 4
        ''            .Row = i
        ''            ssql = "SELECT ACCODE, ACDESC  from AccountsGLAccountmaster  WHERE ISNULL(FREEZEFLAG,'N')<>'Y'  "
        ''            gconnection.getDataSet(ssql, "GLACC")
        ''            If gdataset.Tables("GLACC").Rows.Count > 0 Then
        ''                .Col = 4
        ''                .Row = i
        ''                .Text = Trim(gdataset.Tables("GLACC").Rows(0).Item("ACCODE"))
        ''                .Col = 5
        ''                .Row = i
        ''                .Text = Trim(gdataset.Tables("GLACC").Rows(0).Item("ACDESC"))
        ''                .Col = 6
        ''                .SetActiveCell(.Col, .Row)
        ''                .Focus()
        ''            Else
        ''                MsgBox("Specified GLCODE Type Not Available", MsgBoxStyle.Information)
        ''                .SetActiveCell(3, i)

        ''                .Focus()
        ''            End If
        ''        End If
        ''    ElseIf .ActiveCol = 5 Then
        ''        .Col = 6
        ''        .Focus()
        ''    ElseIf .ActiveCol = 6 Then
        ''        .Col = 6
        ''        .Row = i
        ''        ocptype = .Text
        ''        If Trim(.Text) = "" Then
        ''            Call FillTYPE_COSTCENTER()
        ''        ElseIf Trim(.Text) <> "" Then
        ''            .Col = 6
        ''            .Row = i
        ''            ssql = "SELECT COSTCENTERCODE,COSTCENTERDESC from ACCOUNTSCOSTCENTERMASTER  WHERE ISNULL(FREEZE,'N')<>'Y'  "
        ''            gconnection.getDataSet(ssql, "GLACC")
        ''            If gdataset.Tables("GLACC").Rows.Count > 0 Then
        ''                .Col = 4
        ''                .Row = i
        ''                .Text = Trim(gdataset.Tables("GLACC").Rows(0).Item("COSTCENTERCODE"))
        ''                .Col = 7
        ''                .SetActiveCell(.Col, .Row)
        ''                .Focus()
        ''            Else
        ''                MsgBox("Specified GLCODE Type Not Available", MsgBoxStyle.Information)
        ''                .SetActiveCell(1, i + 1)
        ''                .Focus()
        ''            End If
        ''        End If
        ''    ElseIf .ActiveCol = 7 Then
        ''        .Col = 1
        ''        .Row = i + 1
        ''        .Focus()
        ''    End If
        ''End With
    End Sub



    Private Function Validations() As Boolean
        Validations = True
        Dim i As Integer
        Dim achead As String
        Dim amount As Double
        Dim gl As Boolean
        Dim fend As String
        Dim Fstart As String


        With SSGrid_AccountSetup
            If .DataRowCnt = 0 Then
                MsgBox("There is Nothing To Save")
                Validations = False
                Exit Function
            End If
            For i = 1 To .DataRowCnt
                achead = Nothing
                .Col = 2
                .Row = i
                achead = .Text
                If Trim(achead) <> "" Then
                    gl = True
                    Exit For
                End If
            Next
            If gl = False Then
                MsgBox("There is No GL Nothing To Save")
                Me.SSGrid_AccountSetup.Focus()
                Validations = False
                Exit Function
            End If
            For i = 1 To .DataRowCnt
                achead = Nothing
                .Col = 2
                .Row = i
                achead = .Text
                If Trim(achead) <> "" Then
                    .Col = 3
                    .Row = i
                    If Trim(.Text) = "" Then
                        MsgBox("Pls Enter The SubLedger Code For " & achead)
                        Me.SSGrid_AccountSetup.Focus()
                        Validations = False
                        Exit Function
                    End If
                End If
                If Trim(achead) <> "" Then
                    .Col = 4
                    .Row = i
                    If Trim(.Text) = "" Then
                        MsgBox("Pls Enter The CostCentre Code For " & achead)
                        Me.SSGrid_AccountSetup.Focus()
                        Validations = False
                        Exit Function
                    End If
                End If
                If Trim(achead) <> "" Then
                    .Col = 5
                    .Row = i
                    If Val(.Text) = 0 Then
                        MsgBox("Pls Enter The Amount Code For " & achead)
                        Me.SSGrid_AccountSetup.Focus()
                        Validations = False
                        Exit Function
                    End If
                End If
                If Trim(achead) <> "" Then
                    .Col = 5
                    .Row = i
                    amount = amount + Val(.Text)
                End If
            Next

        End With


    End Function

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        SSGrid_AccountSetup.ClearRange(1, 1, -1, -1, True)
        SSGrid_AccountSetup.Row = 1
        SSGrid_AccountSetup.Col = 1
        SSGrid_AccountSetup.Focus()
        chk_PrintAll.Checked = False

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
        Txt_amount.Text = ""
        Txt_oppgl.Text = ""
        Txt_reason.Text = ""
        Txt_taxcode.Text = ""
        CmdView.Focus()
        Me.Txt_VoucherNo.Enabled = True
        Me.Dtp_VoucherDate.Enabled = True
        Dtp_VoucherDate.Text = Now
        CmdAdd.Text = "Add [F7]"
        CmdAdd.Enabled = True
        CmdDelete.Enabled = False
        Me.lbl_void.Visible = False
        Call autogenerate()
    End Sub


    Private Sub CmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MessageBox.Show("Are You Sure To Delete!", Application.ProductName, MessageBoxButtons.YesNo) = DialogResult.Yes Then

        Else
            MsgBox("Deletion is Cancelled!", MsgBoxStyle.OkOnly, gcompanyname)
        End If

    End Sub
    Private Sub ReceiptsPayments_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Me.CmdClear_Click(sender, e)
        End If
        If e.KeyCode = Keys.F7 Then
            If Me.CmdAdd.Enabled = True Then

            End If
        End If
        If e.KeyCode = Keys.F11 Then
            Me.cmdexit_Click(sender, e)
        End If
        If e.KeyCode = Keys.F9 Then
            Me.CmdView_Click(sender, e)
        End If

    End Sub
    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        'GPRINT = False
        'GRIDFILL()
        'GPRINT = False
        'GRIDFILL()
        '  Dim r As New Cry_Facilit_mem_List
        Dim txtobj1, txtobj9, txtobj10, txtobj50, txtobj12 As TextObject
        Dim sqlstring As String
        Dim Viewer As New REPORTVIEWER
        Dim r As New BLK_DR

        sqlstring = " select *  FROM BULKDEBIT WHERE VOUCHERNO='" & Trim(Txt_VoucherNo.Text) & "' "
        gconnection.getDataSet(sqlstring, "BULKDEBIT")
        If gdataset.Tables("BULKDEBIT").Rows.Count > 0 Then
            ''sqlstring = sqlstring & " ORDER BY mcode "
            Call Viewer.GetDetails1(sqlstring, "BULKDEBIT", r)
            txtobj1 = r.ReportDefinition.ReportObjects("Text1")
            txtobj1.Text = UCase(gcompanyname)

            txtobj1 = r.ReportDefinition.ReportObjects("Text9")
            txtobj1.Text = UCase(gCompanyAddress(0))
            txtobj9 = r.ReportDefinition.ReportObjects("Text12")
            txtobj9.Text = UCase(gCompanyAddress(1))

            txtobj10 = r.ReportDefinition.ReportObjects("Text4")
            txtobj10.Text = UCase(gCompanyAddress(2))
            txtobj50 = r.ReportDefinition.ReportObjects("Text5")
            txtobj50.Text = UCase(gCompanyAddress(3))
            txtobj12 = r.ReportDefinition.ReportObjects("Text7")
            txtobj12.Text = UCase(gCompanyAddress(4))
            txtobj12 = r.ReportDefinition.ReportObjects("Text10")
            txtobj12.Text = UCase(gCompanyAddress(5))

            Viewer.TableName = "BULKDEBIT"
            Viewer.Show()
        Else

            MessageBox.Show(" No records....! ", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            Exit Sub

        End If

    End Sub
    Private Function GetGridAccountcode() As String
        'here to check if there in grid not to show in combo
        Dim i As Integer
        Dim sql As String
        Dim accounthead() As String
        Dim glcode As String
        sql = ""
        For i = 1 To SSGrid_AccountSetup.DataRowCnt
            With SSGrid_AccountSetup
                .Col = 2
                .Row = i
                glcode = Nothing
                glcode = .Text
                If Trim(glcode) <> "" Then
                    accounthead = glcode.Split("-->>")
                    If Trim(sql) = "" Then
                        sql = "'" & accounthead(0) & "'"
                    Else
                        sql = sql & ",'" & accounthead(0) & "'"
                    End If
                End If
            End With
        Next
        GetGridAccountcode = sql
    End Function

    Public Sub checkValidation()
        boolchk = False
        Dim i As Integer
        With SSGrid_AccountSetup
            For i = 1 To .DataRowCnt
                .Row = i
                .Col = 1
                If Trim(.Text) <> "" Then
                    .Row = i
                    .Col = 2
                    If Trim(.Text) = "" Then
                        MessageBox.Show("MNAME Can't be Blank", "Grid Validation", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        .SetActiveCell(2, i)
                        .Focus()
                        Exit Sub

                    End If
                    .Row = i
                    .Col = 3
                    If Trim(.Text) = "" Then
                        MessageBox.Show("AMOUNT Can't be Blank", "Grid Validation", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        .SetActiveCell(3, i)
                        .Focus()
                        Exit Sub
                    End If
                    .Row = i
                    .Col = 4
                    If Trim(.Text) = "" Then
                        MessageBox.Show("CHARGE Account Code Can't be Blank", "Grid Validation", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        .SetActiveCell(4, i)
                        .Focus()
                        Exit Sub
                    End If
                    '.Row = i
                    '.Col = 5
                    'If Trim(.Text) = "" Then
                    '    MessageBox.Show("Account Description Can't be Blank", "Grid Validation", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    '    .SetActiveCell(5, i)
                    '    .Focus()
                    '    Exit Sub
                    'End If

                End If
            Next i
        End With



        With SSGrid_AccountSetup
            For i = 1 To .DataRowCnt
                .Col = 1
                .Row = i
                If Trim(.Text) = "" Then
                    MessageBox.Show("MCODE  Code Can't be Blank", "Grid Validation", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    .SetActiveCell(1, i)
                    .Focus()
                    Exit Sub
                End If
            Next
        End With

        With SSGrid_AccountSetup
            If SSGrid_AccountSetup.DataRowCnt <= 0 Then
                MessageBox.Show("NO RECORDS TO DO TRANSACTION...!", "Grid Validation", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                .SetActiveCell(1, i)
                boolchk = False
                Exit Sub

            End If
        End With


        With SSGrid_AccountSetup
            Dim memcode, chcode As String
            For i = 1 To .DataRowCnt
                .Col = 1
                .Row = i
                memcode = .Text
                If memcode <> "" Then
                    strSqlString = " select * from  membermaster where mcode='" & memcode & "'"
                    gconnection.getDataSet(strSqlString, "membermaster")
                    If gdataset.Tables("membermaster").Rows.Count > 0 Then
                    Else
                        MessageBox.Show("Invalid MCODE, Please Check the MCODE...!", "Grid Validation", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        .SetActiveCell(1, i)
                        boolchk = False
                        .Focus()
                        Exit Sub
                    End If
                End If

                .Col = 4
                .Row = i
                chcode = .Text
                If chcode <> "" Then
                    strSqlString = " SELECT *   FROM CHARGEMASTER  WHERE CHARGECODE ='" & chcode & "'"
                    gconnection.getDataSet(strSqlString, "CHARGEMASTER")
                    If gdataset.Tables("CHARGEMASTER").Rows.Count > 0 Then
                    Else
                        MessageBox.Show("Invalid CHARGE CODE, Please Check the CHARGE CODE...!", "Grid Validation", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        .SetActiveCell(4, i)
                        boolchk = False
                        .Focus()
                        Exit Sub
                    End If
                End If

            Next

        End With

        boolchk = True
    End Sub

    Private Sub autogenerate()
        Dim sqlstring As String
        Dim financalyear As String
        '   Dim BillPrefix As String
        Dim splitvouchernostr(5) As String
        gcommand = New SqlCommand
        Dim docprefixreader As SqlDataReader
        If gcompanyname = "THE TNCA CLUB" Then
            financalyear = (Format(Now, "dd-MMM"))
        Else
            financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialyearEnd, 3, 4)
        End If
        '  Dim voucherno As String
        Try

            'sqlstring = "SELECT MAX(SUBSTRING(VOUCHERNO,8,6)) FROM journalentry WHERE VoucherType='DBN' AND DESCRIPTION='BULKDEBIT'"

            sqlstring = "SELECT MAX(SUBSTRING(VOUCHERNO,11,7)) FROM journalentry WHERE VoucherType='DBN' AND DESCRIPTION='BULKDEBIT' AND VOUCHERNO NOT LIKE 'BLK%' "
            gconnection.openConnection()
            gcommand.CommandText = sqlstring
            gcommand.CommandType = CommandType.Text
            gcommand.Connection = gconnection.myconn
            docprefixreader = gcommand.ExecuteReader
            If docprefixreader.Read Then
                ' BillPrefix = "CMD"
                If docprefixreader(0) Is System.DBNull.Value Then
                    Txt_VoucherNo.Text = "BLKDBN" & "/000001/" & financalyear
                    ' Txt_VoucherNo.Text = "BDBN" & "/001/" & financalyear
                    docprefixreader.Close()
                    gcommand.Dispose()
                    gconnection.closeconnection()
                Else
                    Txt_VoucherNo.Text = "BLKDBN" & "/" & Format(docprefixreader(0) + 1, "000000") & "/" & financalyear
                    '  Txt_VoucherNo.Text = "BDBN" & "/" & Format(docprefixreader(0) + 1, "000") & "/" & financalyear
                    docprefixreader.Close()
                    gcommand.Dispose()
                    gconnection.closeconnection()
                End If
            Else
                Txt_VoucherNo.Text = "BLKDBN" & "/000001/" & financalyear
                ' Txt_VoucherNo.Text = "BDBN" & "/001/" & financalyear
                docprefixreader.Close()
                gcommand.Dispose()
                gconnection.closeconnection()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        Finally
            docprefixreader.Close()
            gcommand.Dispose()
            gconnection.closeconnection()
        End Try

    End Sub
    Private Function AutogenerateN() As Integer
        Dim sqlstring As String
        sqlstring = "SELECT MAX(Cast(applno As Numeric)) FROM MEM_CANCELLATION"
        '        sqlstring = "SELECT MAX(Cast(SUBSTRING(GRNNO,1,6) As Numeric)) FROM GRN_HEADER"
        gcommand = New SqlClient.SqlCommand()
        gconnection.openConnection()
        gcommand.CommandText = sqlstring
        gcommand.CommandType = CommandType.Text
        gcommand.Connection = gconnection.myconn
        gdreader = gcommand.ExecuteReader
        If gdreader.Read Then
            If gdreader(0) Is System.DBNull.Value Then
                Return 1
                gdreader.Close()
                gcommand.Dispose()
                gconnection.closeconnection()


            Else
                Return gdreader(0) + 1
                gdreader.Close()
                gcommand.Dispose()
                gconnection.closeconnection()
            End If
        End If
    End Function

    Private Sub CmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdd.Click
        Dim sqlstring As String
        Dim INSERT(0), Update2(0) As String
        Dim SQL(0) As String
        'Call Duplicate()
        ''If Duplicate() = True Then
        ''    Exit Sub
        ''End If
        If Txt_oppgl.Text = "" Then
            MessageBox.Show("OPP GL code should not be blank", "Grid Validation", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Exit Sub
            Txt_oppgl.Focus()
        End If

        If Txt_taxcode.Text = "" Then
            MessageBox.Show("taxcode should not be blank", "Grid Validation", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Exit Sub
            Txt_taxcode.Focus()
        End If

        If Txt_reason.Text = "" Then
            MessageBox.Show("Reason should not be blank", "Grid Validation", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Exit Sub
            Txt_reason.Focus()
        End If
        Call checkValidation()
        If boolchk = False Then
            Exit Sub
        End If

        Call autogenerate()
        Dim I As Integer
        Dim MCODE, MNAME, ACDHEAD, ACDESC, SDRSCOD, SDRSDES As String
        Dim AMOUNT As Decimal
        Dim TAXCODE As String
        Dim Tpercent, TAXAMOUNT As Double
        Dim TAXON, ACCOUNT, ACCOUNTDESC, ITYPE, TYPEOFTAX, reason As String


        Try


            With SSGrid_AccountSetup
                sqlstring = "SELECT *  FROM  ACCOUNTSSETUP"
                gconnection.getDataSet(sqlstring, "ACCOUNTSSETUP")
                If gdataset.Tables("ACCOUNTSSETUP").Rows.Count > 0 Then
                    SDRSCOD = gdataset.Tables("ACCOUNTSSETUP").Rows(0).Item("SdrsCode")
                    SDRSDES = gdataset.Tables("ACCOUNTSSETUP").Rows(0).Item("SdrsDesc")
                End If
                For I = 1 To .DataRowCnt
                    .Row = I
                    .Col = 1
                    MCODE = Trim(.Text)

                    .Row = I
                    .Col = 2
                    MNAME = Trim(.Text)

                    .Row = I
                    .Col = 3
                    AMOUNT = Val(.Text)

                    .Row = I
                    .Col = 4
                    ACDHEAD = Trim(.Text)

                    .Row = I
                    .Col = 5
                    ACDESC = Trim(.Text)


                    .Row = I
                    .Col = 6
                    reason = Trim(.Text)


                    sqlstring = "Insert into JournalEntry (voucherno,ReceiptNo,voucherdate,VoucherCategory,VoucherType,accountcode,accountcodedesc,slcode,sldesc,creditdebit,amount,void,adduserid,adddatetime,Description,CHARGECODE) values("
                    sqlstring = sqlstring & " 'BD/' + '" & MCODE & "' + '/' + '" & Trim(Mid(Txt_VoucherNo.Text, 8, 6)) & "','" & Trim(Txt_VoucherNo.Text) & "' ,'" & Trim(Dtp_VoucherDate.Text) & "','DBN','DBN','" & SDRSCOD & "','" & SDRSDES & "','" & MCODE & "','" & MNAME & "','DEBIT'," & Val(AMOUNT) & ",'N','" & gUsername & "', '" & Format(Now, "dd-MMM-yyyy HH:mm") & "','BULKDEBIT','" + ACDHEAD + "')"
                    ReDim Preserve INSERT(INSERT.Length)
                    INSERT(INSERT.Length - 1) = sqlstring

                    sqlstring = "Insert into JournalEntry"
                    sqlstring = sqlstring + "(voucherno,ReceiptNo,voucherdate,VoucherCategory,VoucherType,accountcode,accountcodedesc,slcode,sldesc,creditdebit,amount,void,adduserid,adddatetime,Description,OPPSLCODE)"
                    sqlstring = sqlstring & " values('BD/' + '" & MCODE & "' + '/' + '" & Trim(Mid(Txt_VoucherNo.Text, 8, 6)) & "','" & Trim(Txt_VoucherNo.Text) & "','" & Trim(Dtp_VoucherDate.Text) & "','DBN','DBN','" & Txt_oppgl.Text & "','','','','CREDIT'," & Val(AMOUNT) & ",'N','" & gUsername & "', '" & Format(Now, "dd-MMM-yyyy HH:mm") & "','BULKDEBIT','" & MCODE & "')"
                    ReDim Preserve INSERT(INSERT.Length)
                    INSERT(INSERT.Length - 1) = sqlstring




                    '''''''DMY'''''''

                    sqlstring = "Insert into BULKDEBIT (voucherno,voucherdate,VoucherCategory,VoucherType,accountcode,accountcodedesc,slcode,sldesc,creditdebit,amount,void,adduserid,adddatetime,Description,CHARGECODE,reason) values("
                    sqlstring = sqlstring & " '" & Trim(Txt_VoucherNo.Text) & "','" & Trim(Dtp_VoucherDate.Text) & "','DBN','DBN','" & ACDHEAD & "','" & ACDESC & "','" & MCODE & "','" & MNAME & "','DEBIT','" & Val(AMOUNT) & "','N','" & gUsername & " ', '" & Format(Now, "dd-MMM-yyyy HH:mm") & "','BULKDEBIT','" + ACDHEAD + "','" & reason & "')"
                    ReDim Preserve INSERT(INSERT.Length)
                    INSERT(INSERT.Length - 1) = sqlstring

                    sqlstring = "SELECT isnull(TAXTypecode,''),ISNULL(SER_CHGCODE,''),ISNULL(SER_CHGDESC,''),ISNULL(VAT_CHGCODE,''),ISNULL(VAT_CHGDESC,''),ISNULL(ENT_CHGCODE,''),ISNULL(ENT_CHGDESC,'')FROM CHARGEMASTER WHERE CHARGECODE = '" & ACDHEAD & "' "
                    gconnection.getDataSet(sqlstring, "CODE_CHECK")
                    If gdataset.Tables("CODE_CHECK").Rows.Count >= 0 Then
                        TAXCODE = Trim(gdataset.Tables("CODE_CHECK").Rows(0).Item(0))
                    End If

                    sqlstring = "SELECT ISNULL(A.TYPEOFTAX,'') AS TYPEOFTAX,ISNULL(I.ItemTypeCode,'') AS ITEMTYPECODE,ISNULL(I.TaxCode,'') AS TAXCODE,ISNULL(I.TAXON,'') AS TAXON,ISNULL(I.TaxPercentage,0) AS TaxPercentage,ISNULL(A.GLACCOUNTIN,'') AS ACCOUNTCODE,ISNULL(A.GLACCOUNTDESC,'') AS GLACCOUNTDESC FROM ITEMTYPEMASTER I INNER JOIN ACCOUNTSTAXMASTER A ON I.TAXCODE=A.TAXCODE AND ISNULL(FREEZEFLAG,'')<>'Y'  WHERE ItemTypeCode = '" & TAXCODE & "' ORDER BY TAXON"
                    gconnection.getDataSet(sqlstring, "ITEMTYPEMASTER")
                    If gdataset.Tables("ITEMTYPEMASTER").Rows.Count > 0 Then
                        For J = 0 To gdataset.Tables("ITEMTYPEMASTER").Rows.Count - 1
                            ITYPE = Trim(gdataset.Tables("ITEMTYPEMASTER").Rows(J).Item("ItemTypeCode"))
                            TAXCODE = Trim(gdataset.Tables("ITEMTYPEMASTER").Rows(J).Item("TaxCode"))
                            TYPEOFTAX = Trim(gdataset.Tables("ITEMTYPEMASTER").Rows(J).Item("TYPEOFTAX"))
                            'TAXDESC = Trim(gdataset.Tables("TAXON").Rows(J).Item("TAXDESC"))
                            TAXON = Trim(gdataset.Tables("ITEMTYPEMASTER").Rows(J).Item("TAXON"))
                            Tpercent = gdataset.Tables("ITEMTYPEMASTER").Rows(J).Item("TaxPercentage")
                            ACCOUNT = gdataset.Tables("ITEMTYPEMASTER").Rows(J).Item("ACCOUNTCODE")
                            ACCOUNTDESC = gdataset.Tables("ITEMTYPEMASTER").Rows(J).Item("GLACCOUNTDESC")


                            If Tpercent <> "0" Or Tpercent <> "0.00" Then

                                TAXAMOUNT = (AMOUNT * Tpercent) / 100

                                sqlstring = "Insert into JournalEntry (voucherno,ReceiptNo,voucherdate,VoucherCategory,VoucherType,accountcode,accountcodedesc,slcode,sldesc,creditdebit,amount,void,adduserid,adddatetime,Description,CHARGECODE)"
                                sqlstring = sqlstring & "values('BD/' + '" & MCODE & "' + '/' + '" & Trim(Mid(Txt_VoucherNo.Text, 8, 6)) & "','" & Trim(Txt_VoucherNo.Text) & "','" & Trim(Dtp_VoucherDate.Text) & "','DBN','DBN','" & SDRSCOD & "','" & SDRSDES & "','" & MCODE & "','" & MNAME & "','DEBIT'," & Val(TAXAMOUNT) & ",'N','" & gUsername & "', '" & Format(Now, "dd-MMM-yyyy HH:mm") & "','BULKDEBIT','')"
                                ReDim Preserve INSERT(INSERT.Length)
                                INSERT(INSERT.Length - 1) = sqlstring

                                sqlstring = "Insert into JournalEntry"
                                sqlstring = sqlstring & "(voucherno,ReceiptNo,voucherdate,VoucherCategory,VoucherType,accountcode,accountcodedesc,slcode,sldesc,creditdebit,amount,void,adduserid,adddatetime,Description,CHARGECODE)"
                                sqlstring = sqlstring & "values('BD/' + '" & MCODE & "' + '/' + '" & Trim(Mid(Txt_VoucherNo.Text, 8, 6)) & "','" & Trim(Txt_VoucherNo.Text) & "','" & Trim(Dtp_VoucherDate.Text) & "','DBN','DBN','" & ACCOUNT & "','" & ACCOUNTDESC & "','','','CREDIT'," & Val(TAXAMOUNT) & ",'N','" & gUsername & "', '" & Format(Now, "dd-MMM-yyyy HH:mm") & "','BULKDEBIT','')"
                                ReDim Preserve INSERT(INSERT.Length)
                                INSERT(INSERT.Length - 1) = sqlstring

                            End If

                        Next
                    End If



                Next I
            End With
            '  VCONN.MoreTrans(SQL)
            gconnection.MoreTrans(INSERT)
            Call CmdClear_Click(sender, e)
        Catch ex As Exception
            MsgBox("ERROR IN : " & ex.Message)
        End Try
    End Sub

    Private Sub SSGrid_AccountSetup_LeaveCell(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_LeaveCellEvent) Handles SSGrid_AccountSetup.LeaveCell

    End Sub

    Private Sub SSGrid_AccountSetup_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles SSGrid_AccountSetup.Advance

    End Sub

    Private Sub Room_accountSetup_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        '  MAKE_SCREENSAVER_TIMER_ZERO()
    End Sub

    Private Sub Room_accountSetup_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        '  MAKE_SCREENSAVER_TIMER_ZERO()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If GBL_ShowScreenSaver_TIME > 5000 And ShowScreenSaver = False Then
        '    GBL_ShowScreenSaver_TIME = 0
        '    ShowScreenSaver = True
        '    Call Show_Screensaver()
        'Else
        '    GBL_ShowScreenSaver_TIME = GBL_ShowScreenSaver_TIME + 1
        'End If
    End Sub

    Private Sub Room_accountSetup_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        '  MAKE_SCREENSAVER_TIMER_ZERO()
    End Sub

    Private Sub SSGrid_AccountSetup_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles SSGrid_AccountSetup.Validated

    End Sub





    Private Sub Resize_Form()
        Dim cControl As Control
        Dim i_i As Integer
        Dim J, K, L, M, n, o, P, Q, R, S, T, U As Integer
        'If (Screen.PrimaryScreen.Bounds.Height = 768) And (Screen.PrimaryScreen.Bounds.Width = 1366) Then
        '    Exit Sub
        'End If

        J = 769
        K = 1024
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
        If U = 1920 Then
            T = T - 55
        End If
        If U = 1024 Then
            T = T - 2
        End If
        If U = 1600 Then
            T = T - 90
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
                        If Controls(i_i).Name = "Panel" Or Controls(i_i).Name = "Panel1" Or Controls(i_i).Name = "Panel2" Or Controls(i_i).Name = "Panel3" Or Controls(i_i).Name = "Panel4" Or Controls(i_i).Name = "Panel5" Or Controls(i_i).Name = "Panel6" Or Controls(i_i).Name = "Panel7" Or Controls(i_i).Name = "Panel8" Or Controls(i_i).Name = "Panel9" Then
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
                                T = T - 55
                            End If
                            If U = 1920 Then
                                T = T - 75
                            End If
                            If U = 1024 Then
                                T = T - 55
                            End If
                            If U = 1600 Then
                                T = T - 90
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
                        If Controls(i_i).Name = "GroupBox1" Or Controls(i_i).Name = "GroupBox2" Or Controls(i_i).Name = "GroupBox3" Or Controls(i_i).Name = "GroupBox4" Or Controls(i_i).Name = "GroupBox5" Or Controls(i_i).Name = "GroupBox6" Or Controls(i_i).Name = "Gbx_summardet" Or Controls(i_i).Name = "GroupBox8" Or Controls(i_i).Name = "GroupBox9" Or Controls(i_i).Name = "GroupBox10" Or Controls(i_i).Name = "frmbut" Then
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
                            If U = 1440 Then
                                L = L + 110
                            End If
                            If U = 1024 Then
                                L = L - 2
                            End If
                            If U = 1920 Then
                                L = L + 400
                            End If
                            If U = 1600 Then
                                L = L + 175
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
                ElseIf TypeOf .Controls(i_i) Is CheckedListBox Then
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
                ElseIf TypeOf .Controls(i_i) Is Button Then
                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        If Controls(i_i).Name = "CmdAdd" Or Controls(i_i).Name = "CmdClear" Or Controls(i_i).Name = "Cmd_Freeze" Or Controls(i_i).Name = "Cmdview" Or Controls(i_i).Name = "cmdreport" Or Controls(i_i).Name = "Cmdbwse" Or Controls(i_i).Name = "Cmdauth" Or Controls(i_i).Name = "cmdexit" Or Controls(i_i).Name = "Cmd_SControl" Then
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
                            If U = 1024 Then
                                T = T - 50
                            End If

                            If U = 1600 Then
                                T = T - 90
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

    Private Sub Txt_VoucherNo_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_VoucherNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Txt_VoucherNo.Text = "" Then
            Else
                GRIDFILL()
            End If
        End If
    End Sub

    Private Sub Txt_VoucherNo_TextChanged(sender As Object, e As EventArgs) Handles Txt_VoucherNo.TextChanged

    End Sub

    Private Sub Txt_VoucherNo_Validated(sender As Object, e As EventArgs) Handles Txt_VoucherNo.Validated

        Dim SQLSTRING As String
        SQLSTRING = "SELECT ISNULL(voucherno,'') voucherno,ISNULL(slcode,'')slcode, ISNULL(sldesc,'')sldesc, ISNULL(amount,'0')amount, ISNULL(accountcode,'')accountcode, ISNULL(accountcodedesc,'')accountcodedesc, ISNULL(voucherdate,'')voucherdate,  Adduserid , Adddatetime,isnull(void,'') as void  FROM BULKDEBIT WHERE voucherno='" & Trim(Txt_VoucherNo.Text) & "' "
        VCONN.getDataSet(SQLSTRING, "TRANS")
        If gdataset.Tables("TRANS").Rows.Count > 0 Then
            If UCase(gdataset.Tables("TRANS").Rows(0).Item("void")) = "Y" Then
                Me.lbl_void.Visible = True
                CmdDelete.Enabled = False
                CmdAdd.Enabled = False
            Else
                CmdAdd.Text = "Update"
                CmdAdd.Enabled = False
                CmdDelete.Enabled = True
            End If
            GRIDFILL()
        End If
    End Sub

    Private Sub Cmd_VoucherNoHelp_Click(sender As Object, e As EventArgs) Handles Cmd_VoucherNoHelp.Click

    End Sub

    Private Sub CmdDelete_Click_1(sender As Object, e As EventArgs) Handles CmdDelete.Click
        Dim ssql As String
        'ssql = "select isnull(max(billdate),(select fromdate from master..clubmaster where datafile='" & gdatabase & "')) as date1 from bengal_monthbill "
        'VCONN.getDataSet(ssql, "bill")
        'If gdataset.Tables("bill").Rows.Count > 0 Then
        '    ssql = "select distinct voucherdate from  journalentry where voucherno='" & Trim(Me.Txt_VoucherNo.Text) & "' and voucherdate>'" & Format(gdataset.Tables("bill").Rows(0).Item("date1"), "dd-MMM-yyyy") & "' order by voucherdate desc "
        '    VCONN.getDataSet(ssql, "bill1")
        '    If gdataset.Tables("bill1").Rows.Count > 0 Then
        '        ssql = "update journalentry set void='Y' where voucherno='" & Trim(Me.Txt_VoucherNo.Text) & "'"
        '        VCONN.ExcuteStoreProcedure(ssql)
        '        ssql = "update BULKDEBIT set void='Y' where voucherno='" & Trim(Me.Txt_VoucherNo.Text) & "'"
        '        VCONN.ExcuteStoreProcedure(ssql)
        '        MsgBox("TRANSACTION COMPLETED SUCCESSFULY")
        '    Else
        '        MsgBox("Bill IS GENERTED FOR THE MONTH U CANNOT VOID")
        '        Exit Sub
        '    End If
        'Else
        '    MsgBox("No Bill date Defined")
        '    Exit Sub
        'End If

        ssql = "select isnull(max(billdate),'') DATE1 from bengal_monthbill "
        VCONN.getDataSet(ssql, "bill")
        If gdataset.Tables("bill").Rows.Count > 0 Then
            ssql = "select distinct voucherdate from  journalentry where RECEIPTNO='" & Trim(Me.Txt_VoucherNo.Text) & "'   and MONTH(voucherdate)=MONTH('" & Format(gdataset.Tables("bill").Rows(0).Item("date1"), "dd-MMM-yyyy") & "') order by voucherdate desc "
            VCONN.getDataSet(ssql, "bill1")
            If gdataset.Tables("bill1").Rows.Count > 0 Then
                MsgBox("Bill IS GENERTED FOR THE MONTH U CANNOT VOID")
                Exit Sub
            Else

                ssql = "update journalentry set void='Y' where RECEIPTNO='" & Trim(Me.Txt_VoucherNo.Text) & "'  AND VOUCHERCATEGORY='DBN'"
                VCONN.ExcuteStoreProcedure(ssql)
                ssql = "update BULKDEBIT set void='Y' where voucherno='" & Trim(Me.Txt_VoucherNo.Text) & "'"
                VCONN.ExcuteStoreProcedure(ssql)
                MsgBox("TRANSACTION COMPLETED SUCCESSFULY")
                CmdClear_Click(sender, e)
            End If
        Else
            MsgBox("No Bill date Defined")
            Exit Sub
        End If
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
    Private Sub FillGrid(ByVal SqlStr As String)
        Dim StrString As String
        Dim i, j As Integer
        Dim row As Integer
        row = 0
        Try
            j = 0
            StrString = SqlStr
            gconnection.getDataSet(StrString, "Master")
            If gdataset.Tables("Master").Rows.Count > 0 Then


                ' j = ssclosure.DataRowCnt
                ' ssclosure.MaxRows = gdataset.Tables("Master").Rows.Count + 10
                For i = 0 To gdataset.Tables("Master").Rows.Count - 1
                    ' row = row + 1
                    j = j + 1
                    With SSGrid_AccountSetup
                        SSGrid_AccountSetup.SetText(1, row + i + 1, Trim(gdataset.Tables("Master").Rows(i).Item("MCODE")))
                        SSGrid_AccountSetup.SetText(2, row + i + 1, Trim(gdataset.Tables("Master").Rows(i).Item("MNAME")))
                        ' SSGrid_AccountSetup.SetText(3, row + i + 1, Trim(gdataset.Tables("Master").Rows(i).Item("MEMBERTYPE")))
                        SSGrid_AccountSetup.SetText(3, row + i + 1, Val(Txt_amount.Text))
                        SSGrid_AccountSetup.SetText(4, row + i + 1, Trim(Txt_taxcode.Text))
                        SSGrid_AccountSetup.SetText(5, row + i + 1, Trim("Taxdesc"))
                        SSGrid_AccountSetup.SetText(6, row + i + 1, Trim(Txt_reason.Text))
                        'SSGrid_AccountSetup.SetText(4, row + i + 1, Val(1))
                    End With
                Next
                row = row + j
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Cmd_FillData_Click(sender As Object, e As EventArgs) Handles Cmd_FillData.Click
        Dim sqlstring As String = ""
        Dim membertype, TYPE(0) As String
        membertype = ""
        If Txt_oppgl.Text = "" Then
            MessageBox.Show("OPP GL code should not be blank", "Grid Validation", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Exit Sub
            Txt_oppgl.Focus()
        End If

        If Txt_taxcode.Text = "" Then
            MessageBox.Show("taxcode should not be blank", "Grid Validation", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Exit Sub
            Txt_taxcode.Focus()
        End If

        If Txt_reason.Text = "" Then
            MessageBox.Show("Reason should not be blank", "Grid Validation", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Exit Sub
            Txt_reason.Focus()
        End If
        SSGrid_AccountSetup.ClearRange(1, 1, -1, -1, True)

        SSGrid_AccountSetup.Row = 1
        SSGrid_AccountSetup.Col = 1
        SSGrid_AccountSetup.Focus()

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

        If chk_Filter_Field.CheckedItems.Count > 0 Then
            sqlstring = "SELECT MCODE,MNAME,MEMBERTYPE FROM MM_MEMBERMASTER WHERE ISNULL(FREEZE,'') <> 'Y' AND LTRIM(RTRIM(membertypecode)) IN(" & membertype & ") AND ISNULL(MEMBERTYPE,'')<>'' ORDER BY SUBSTRING(MCODE,1,1),LEN(MCODE),MCODE "
        End If
        If sqlstring <> "" Then
            Call FillGrid(sqlstring)
        Else

        End If
    End Sub


    Private Sub TXTTAXCODE(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            Dim sqlstring As String
            If Trim(Txt_taxcode.Text) <> "" Then
                sqlstring = "SELECT ISNULL(TAXTYPECODE,'') AS TAXTYPECODE,ISNULL(TAXTYPEDESC,'') AS TAXTYPEDESC FROM chargemaster WHERE TAXTYPECODE='" & Trim(Txt_taxcode.Text) & "'  ORDER BY TAXTYPECODE"
                gconnection.getDataSet(sqlstring, "MEMBER")
                If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                    Txt_taxcode.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("TAXTYPECODE"))

                    ''FillGrid.Focus()
                Else
                    Txt_taxcode.Text = ""
                    Txt_taxcode.Focus()
                End If
            Else
                'txt_Tomcode.Text = ""
                'txt_Tomcode.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub TXTACCODE(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            Dim sqlstring As String
            If Trim(Txt_oppgl.Text) <> "" Then
                sqlstring = "SELECT ISNULL(accode,'') AS accode,ISNULL(acdesc,'') AS acdesc FROM accountsglaccountmaster WHERE accode='" & Trim(Txt_oppgl.Text) & "'  ORDER BY accode"
                gconnection.getDataSet(sqlstring, "MEMBER")
                If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                    Txt_oppgl.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("accode"))

                    Txt_taxcode.Focus()
                Else
                    Txt_oppgl.Text = ""
                    Txt_oppgl.Focus()
                End If
            Else
                'txt_Tomcode.Text = ""
                'txt_Tomcode.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub



   
    Private Sub cmd_glCodeHelp_Click(sender As Object, e As EventArgs) Handles cmd_glCodeHelp.Click
        Dim vform As New LIST_OPERATION1
        gSQLString = "SELECT ISNULL(accode,'') AS accode,ISNULL(acdesc,'') AS acdesc FROM accountsglaccountmaster"
        If Trim(Search) = " " Then
            M_WhereCondition = " WHERE isnull(freezeflag,'') <> 'Y'"
        Else
            M_WhereCondition = " WHERE isnull(freezeflag,'') <> 'Y'"
        End If
        M_Groupby = ""
        vform.Field = "accode,acdesc"
        'vform.vFormatstring = "     MEMBER CODE    |         MEMBER NAME                         "
        vform.vCaption = "acdesc HELP"
        'vform.KeyPos = 0
        'vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            Txt_oppgl.Text = Trim(vform.keyfield & "")
            Call TXTACCODE(sender, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub cmd_taxcodehelp_Click(sender As Object, e As EventArgs) Handles cmd_taxcodehelp.Click
        Dim vform As New LIST_OPERATION1
        gSQLString = "SELECT ISNULL(TAXTYPECODE,'') AS TAXTYPECODE,ISNULL(TAXTYPEDESC,'') AS TAXTYPEDESC FROM chargemaster"
        If Trim(Search) = " " Then
            M_WhereCondition = " WHERE TAXTYPECODE <> 'NM'"
        Else
            M_WhereCondition = " WHERE TAXTYPECODE <> 'NM'"
        End If
        M_Groupby = ""
        vform.Field = "TAXTYPECODE,TAXTYPEDESC"
        'vform.vFormatstring = "     MEMBER CODE    |         MEMBER NAME                         "
        vform.vCaption = "TAXTYPEDESC HELP"
        'vform.KeyPos = 0
        'vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            Txt_taxcode.Text = Trim(vform.keyfield & "")
            Call TXTTAXCODE(sender, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub
End Class