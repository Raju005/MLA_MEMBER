Imports System.Data.SqlClient
Imports Bengal_MemberMaster.FRM_MEMMASTER
Imports CrystalDecisions.CrystalReports.Engine

Public Class CommitteeTransaction
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Private Property memimage As String

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
    Friend WithEvents frmbut As System.Windows.Forms.GroupBox
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Menuitemcode As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTypeName As System.Windows.Forms.TextBox
    Friend WithEvents txtTypeCode As System.Windows.Forms.TextBox
    Friend WithEvents txtYearName As System.Windows.Forms.TextBox
    Friend WithEvents ssGrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Cmd_Delete As System.Windows.Forms.Button
    Friend WithEvents Cmd_TypeCodeHelp As System.Windows.Forms.Button
    Friend WithEvents Frm_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents To_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmd_MemberCodeHelp As System.Windows.Forms.Button
    Friend WithEvents txt_MemberCode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_MemberCode As System.Windows.Forms.Label
    Friend WithEvents txt_FirstName As System.Windows.Forms.TextBox
    Friend WithEvents txt_RA_Email As System.Windows.Forms.TextBox
    Friend WithEvents txt_RA_MobileNo As System.Windows.Forms.TextBox
    Friend WithEvents Img_Photo As System.Windows.Forms.PictureBox
    Friend WithEvents DDGRD1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_SubCategoryCodeHelp As System.Windows.Forms.Button
    Friend WithEvents txt_SubCategoryName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Txt_subcategorycode As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents MCODE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MNAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCELL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CEMAIL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Public WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdAdd As System.Windows.Forms.Button
    Friend WithEvents CmdExit1 As System.Windows.Forms.Button
    Friend WithEvents Cmd_Clear1 As System.Windows.Forms.Button
    Friend WithEvents CmdAdd1 As System.Windows.Forms.Button
    Friend WithEvents Cmd_freeze As System.Windows.Forms.Button
    Friend WithEvents CmdView1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CommitteeTransaction))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.frmbut = New System.Windows.Forms.GroupBox()
        Me.CmdClear = New System.Windows.Forms.Button()
        Me.CmdAdd = New System.Windows.Forms.Button()
        Me.Cmd_Clear = New System.Windows.Forms.Button()
        Me.Cmd_View = New System.Windows.Forms.Button()
        Me.Cmd_Delete = New System.Windows.Forms.Button()
        Me.Cmd_Add = New System.Windows.Forms.Button()
        Me.Cmd_Exit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cmd_TypeCodeHelp = New System.Windows.Forms.Button()
        Me.txtTypeName = New System.Windows.Forms.TextBox()
        Me.txtTypeCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtYearName = New System.Windows.Forms.TextBox()
        Me.lbl_Menuitemcode = New System.Windows.Forms.Label()
        Me.Frm_date = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.To_date = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Img_Photo = New System.Windows.Forms.PictureBox()
        Me.txt_RA_MobileNo = New System.Windows.Forms.TextBox()
        Me.txt_RA_Email = New System.Windows.Forms.TextBox()
        Me.txt_FirstName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmd_MemberCodeHelp = New System.Windows.Forms.Button()
        Me.txt_MemberCode = New System.Windows.Forms.TextBox()
        Me.lbl_MemberCode = New System.Windows.Forms.Label()
        Me.DDGRD1 = New System.Windows.Forms.DataGridView()
        Me.MCODE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmd_SubCategoryCodeHelp = New System.Windows.Forms.Button()
        Me.txt_SubCategoryName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_subcategorycode = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ssGrid = New AxFPSpreadADO.AxfpSpread()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CmdExit1 = New System.Windows.Forms.Button()
        Me.Cmd_Clear1 = New System.Windows.Forms.Button()
        Me.CmdAdd1 = New System.Windows.Forms.Button()
        Me.Cmd_freeze = New System.Windows.Forms.Button()
        Me.CmdView1 = New System.Windows.Forms.Button()
        Me.frmbut.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Img_Photo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DDGRD1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'frmbut
        '
        Me.frmbut.BackColor = System.Drawing.Color.Transparent
        Me.frmbut.Controls.Add(Me.CmdClear)
        Me.frmbut.Controls.Add(Me.CmdAdd)
        Me.frmbut.Controls.Add(Me.Cmd_Clear)
        Me.frmbut.Controls.Add(Me.Cmd_View)
        Me.frmbut.Controls.Add(Me.Cmd_Delete)
        Me.frmbut.Controls.Add(Me.Cmd_Add)
        Me.frmbut.Controls.Add(Me.Cmd_Exit)
        Me.frmbut.Location = New System.Drawing.Point(185, 518)
        Me.frmbut.Name = "frmbut"
        Me.frmbut.Size = New System.Drawing.Size(592, 56)
        Me.frmbut.TabIndex = 37
        Me.frmbut.TabStop = False
        Me.frmbut.Visible = False
        '
        'CmdClear
        '
        Me.CmdClear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdClear.Location = New System.Drawing.Point(240, -146)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(137, 50)
        Me.CmdClear.TabIndex = 899
        Me.CmdClear.Text = "Clear[F6]"
        Me.CmdClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdClear.UseVisualStyleBackColor = True
        '
        'CmdAdd
        '
        Me.CmdAdd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAdd.Image = CType(resources.GetObject("CmdAdd.Image"), System.Drawing.Image)
        Me.CmdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdAdd.Location = New System.Drawing.Point(240, -83)
        Me.CmdAdd.Name = "CmdAdd"
        Me.CmdAdd.Size = New System.Drawing.Size(137, 50)
        Me.CmdAdd.TabIndex = 900
        Me.CmdAdd.Text = "Add[F7]"
        Me.CmdAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdAdd.UseVisualStyleBackColor = True
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.Location = New System.Drawing.Point(16, 12)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Clear.TabIndex = 18
        Me.Cmd_Clear.Text = "Clear[F6]"
        Me.Cmd_Clear.UseVisualStyleBackColor = False
        Me.Cmd_Clear.Visible = False
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(360, 12)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 16
        Me.Cmd_View.Text = " View[F9]"
        Me.Cmd_View.UseVisualStyleBackColor = False
        Me.Cmd_View.Visible = False
        '
        'Cmd_Delete
        '
        Me.Cmd_Delete.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Delete.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Delete.ForeColor = System.Drawing.Color.White
        Me.Cmd_Delete.Image = CType(resources.GetObject("Cmd_Delete.Image"), System.Drawing.Image)
        Me.Cmd_Delete.Location = New System.Drawing.Point(248, 12)
        Me.Cmd_Delete.Name = "Cmd_Delete"
        Me.Cmd_Delete.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Delete.TabIndex = 15
        Me.Cmd_Delete.Text = "Delete[F8]"
        Me.Cmd_Delete.UseVisualStyleBackColor = False
        Me.Cmd_Delete.Visible = False
        '
        'Cmd_Add
        '
        Me.Cmd_Add.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Add.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Add.ForeColor = System.Drawing.Color.White
        Me.Cmd_Add.Image = CType(resources.GetObject("Cmd_Add.Image"), System.Drawing.Image)
        Me.Cmd_Add.Location = New System.Drawing.Point(128, 12)
        Me.Cmd_Add.Name = "Cmd_Add"
        Me.Cmd_Add.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Add.TabIndex = 14
        Me.Cmd_Add.Text = "Add [F7]"
        Me.Cmd_Add.UseVisualStyleBackColor = False
        Me.Cmd_Add.Visible = False
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(472, 12)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 17
        Me.Cmd_Exit.Text = "Exit[F11]"
        Me.Cmd_Exit.UseVisualStyleBackColor = False
        Me.Cmd_Exit.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Cmd_TypeCodeHelp)
        Me.GroupBox1.Controls.Add(Me.txtTypeName)
        Me.GroupBox1.Controls.Add(Me.txtTypeCode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtYearName)
        Me.GroupBox1.Controls.Add(Me.lbl_Menuitemcode)
        Me.GroupBox1.Location = New System.Drawing.Point(96, -8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 30)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'Cmd_TypeCodeHelp
        '
        Me.Cmd_TypeCodeHelp.Image = CType(resources.GetObject("Cmd_TypeCodeHelp.Image"), System.Drawing.Image)
        Me.Cmd_TypeCodeHelp.Location = New System.Drawing.Point(238, 64)
        Me.Cmd_TypeCodeHelp.Name = "Cmd_TypeCodeHelp"
        Me.Cmd_TypeCodeHelp.Size = New System.Drawing.Size(23, 26)
        Me.Cmd_TypeCodeHelp.TabIndex = 28
        Me.Cmd_TypeCodeHelp.Visible = False
        '
        'txtTypeName
        '
        Me.txtTypeName.BackColor = System.Drawing.Color.Wheat
        Me.txtTypeName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTypeName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTypeName.Location = New System.Drawing.Point(384, 64)
        Me.txtTypeName.MaxLength = 50
        Me.txtTypeName.Name = "txtTypeName"
        Me.txtTypeName.Size = New System.Drawing.Size(208, 26)
        Me.txtTypeName.TabIndex = 27
        Me.txtTypeName.Visible = False
        '
        'txtTypeCode
        '
        Me.txtTypeCode.BackColor = System.Drawing.Color.Wheat
        Me.txtTypeCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTypeCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTypeCode.Location = New System.Drawing.Point(128, 64)
        Me.txtTypeCode.MaxLength = 6
        Me.txtTypeCode.Name = "txtTypeCode"
        Me.txtTypeCode.Size = New System.Drawing.Size(104, 26)
        Me.txtTypeCode.TabIndex = 26
        Me.txtTypeCode.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(267, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "TYPE NAME :"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "TYPE CODE :"
        Me.Label1.Visible = False
        '
        'txtYearName
        '
        Me.txtYearName.BackColor = System.Drawing.Color.Wheat
        Me.txtYearName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtYearName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYearName.Location = New System.Drawing.Point(128, 22)
        Me.txtYearName.MaxLength = 4
        Me.txtYearName.Name = "txtYearName"
        Me.txtYearName.Size = New System.Drawing.Size(104, 26)
        Me.txtYearName.TabIndex = 23
        Me.txtYearName.Visible = False
        '
        'lbl_Menuitemcode
        '
        Me.lbl_Menuitemcode.AutoSize = True
        Me.lbl_Menuitemcode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Menuitemcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Menuitemcode.Location = New System.Drawing.Point(64, 24)
        Me.lbl_Menuitemcode.Name = "lbl_Menuitemcode"
        Me.lbl_Menuitemcode.Size = New System.Drawing.Size(68, 20)
        Me.lbl_Menuitemcode.TabIndex = 22
        Me.lbl_Menuitemcode.Text = "YEAR :"
        Me.lbl_Menuitemcode.Visible = False
        '
        'Frm_date
        '
        Me.Frm_date.Location = New System.Drawing.Point(394, 162)
        Me.Frm_date.Name = "Frm_date"
        Me.Frm_date.Size = New System.Drawing.Size(100, 20)
        Me.Frm_date.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(286, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "From Date :"
        '
        'To_date
        '
        Me.To_date.Location = New System.Drawing.Point(611, 162)
        Me.To_date.Name = "To_date"
        Me.To_date.Size = New System.Drawing.Size(100, 20)
        Me.To_date.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(529, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 20)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "To Date :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Img_Photo)
        Me.GroupBox2.Controls.Add(Me.txt_RA_MobileNo)
        Me.GroupBox2.Controls.Add(Me.txt_RA_Email)
        Me.GroupBox2.Controls.Add(Me.txt_FirstName)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cmd_MemberCodeHelp)
        Me.GroupBox2.Controls.Add(Me.txt_MemberCode)
        Me.GroupBox2.Controls.Add(Me.lbl_MemberCode)
        Me.GroupBox2.Location = New System.Drawing.Point(200, 322)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(600, 100)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Committe Add  List"
        Me.GroupBox2.Visible = False
        '
        'Img_Photo
        '
        Me.Img_Photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Img_Photo.Location = New System.Drawing.Point(590, 25)
        Me.Img_Photo.Name = "Img_Photo"
        Me.Img_Photo.Size = New System.Drawing.Size(108, 101)
        Me.Img_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Img_Photo.TabIndex = 72
        Me.Img_Photo.TabStop = False
        '
        'txt_RA_MobileNo
        '
        Me.txt_RA_MobileNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RA_MobileNo.Location = New System.Drawing.Point(448, 48)
        Me.txt_RA_MobileNo.MaxLength = 15
        Me.txt_RA_MobileNo.Name = "txt_RA_MobileNo"
        Me.txt_RA_MobileNo.Size = New System.Drawing.Size(141, 21)
        Me.txt_RA_MobileNo.TabIndex = 48
        '
        'txt_RA_Email
        '
        Me.txt_RA_Email.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_RA_Email.Location = New System.Drawing.Point(300, 50)
        Me.txt_RA_Email.MaxLength = 50
        Me.txt_RA_Email.Name = "txt_RA_Email"
        Me.txt_RA_Email.Size = New System.Drawing.Size(141, 21)
        Me.txt_RA_Email.TabIndex = 47
        '
        'txt_FirstName
        '
        Me.txt_FirstName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FirstName.Location = New System.Drawing.Point(432, 73)
        Me.txt_FirstName.MaxLength = 30
        Me.txt_FirstName.Name = "txt_FirstName"
        Me.txt_FirstName.Size = New System.Drawing.Size(134, 21)
        Me.txt_FirstName.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(623, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 15)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Image"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(454, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 15)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Mobile No"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(305, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 15)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Emailid"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(161, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 15)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Name"
        '
        'cmd_MemberCodeHelp
        '
        Me.cmd_MemberCodeHelp.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources._400_F_9130045_3SaKfvCqFL4hRJm59cddsCnbx5YyqvYj
        Me.cmd_MemberCodeHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_MemberCodeHelp.Location = New System.Drawing.Point(110, 50)
        Me.cmd_MemberCodeHelp.Name = "cmd_MemberCodeHelp"
        Me.cmd_MemberCodeHelp.Size = New System.Drawing.Size(40, 23)
        Me.cmd_MemberCodeHelp.TabIndex = 40
        Me.cmd_MemberCodeHelp.UseVisualStyleBackColor = True
        '
        'txt_MemberCode
        '
        Me.txt_MemberCode.BackColor = System.Drawing.SystemColors.Control
        Me.txt_MemberCode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MemberCode.Location = New System.Drawing.Point(10, 52)
        Me.txt_MemberCode.MaxLength = 15
        Me.txt_MemberCode.Name = "txt_MemberCode"
        Me.txt_MemberCode.Size = New System.Drawing.Size(98, 21)
        Me.txt_MemberCode.TabIndex = 39
        '
        'lbl_MemberCode
        '
        Me.lbl_MemberCode.AutoSize = True
        Me.lbl_MemberCode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MemberCode.Location = New System.Drawing.Point(11, 13)
        Me.lbl_MemberCode.Name = "lbl_MemberCode"
        Me.lbl_MemberCode.Size = New System.Drawing.Size(96, 15)
        Me.lbl_MemberCode.TabIndex = 41
        Me.lbl_MemberCode.Text = "Membership No"
        '
        'DDGRD1
        '
        Me.DDGRD1.AllowUserToAddRows = False
        Me.DDGRD1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DDGRD1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DDGRD1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MCODE, Me.MNAME})
        Me.DDGRD1.Location = New System.Drawing.Point(190, 222)
        Me.DDGRD1.Name = "DDGRD1"
        Me.DDGRD1.Size = New System.Drawing.Size(642, 192)
        Me.DDGRD1.TabIndex = 46
        '
        'MCODE
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MCODE.DefaultCellStyle = DataGridViewCellStyle1
        Me.MCODE.HeaderText = "MCODE [F4]"
        Me.MCODE.MaxInputLength = 10
        Me.MCODE.Name = "MCODE"
        Me.MCODE.Width = 90
        '
        'MNAME
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MNAME.DefaultCellStyle = DataGridViewCellStyle2
        Me.MNAME.HeaderText = "MNAME"
        Me.MNAME.Name = "MNAME"
        Me.MNAME.ReadOnly = True
        Me.MNAME.Width = 320
        '
        'cmd_SubCategoryCodeHelp
        '
        Me.cmd_SubCategoryCodeHelp.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources._400_F_9130045_3SaKfvCqFL4hRJm59cddsCnbx5YyqvYj
        Me.cmd_SubCategoryCodeHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_SubCategoryCodeHelp.Location = New System.Drawing.Point(392, 192)
        Me.cmd_SubCategoryCodeHelp.Name = "cmd_SubCategoryCodeHelp"
        Me.cmd_SubCategoryCodeHelp.Size = New System.Drawing.Size(40, 23)
        Me.cmd_SubCategoryCodeHelp.TabIndex = 49
        Me.cmd_SubCategoryCodeHelp.UseVisualStyleBackColor = True
        '
        'txt_SubCategoryName
        '
        Me.txt_SubCategoryName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SubCategoryName.Location = New System.Drawing.Point(608, 191)
        Me.txt_SubCategoryName.MaxLength = 40
        Me.txt_SubCategoryName.Name = "txt_SubCategoryName"
        Me.txt_SubCategoryName.Size = New System.Drawing.Size(228, 21)
        Me.txt_SubCategoryName.TabIndex = 50
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(481, 193)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 15)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Designation Name : "
        '
        'Txt_subcategorycode
        '
        Me.Txt_subcategorycode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_subcategorycode.Location = New System.Drawing.Point(310, 191)
        Me.Txt_subcategorycode.MaxLength = 8
        Me.Txt_subcategorycode.Name = "Txt_subcategorycode"
        Me.Txt_subcategorycode.Size = New System.Drawing.Size(76, 21)
        Me.Txt_subcategorycode.TabIndex = 47
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(192, 193)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 15)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Designation Code : "
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn1.HeaderText = "MCODE [F4]"
        Me.DataGridViewTextBoxColumn1.MaxInputLength = 10
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 90
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn2.HeaderText = "MNAME"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 320
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "CONTACT"
        Me.DataGridViewTextBoxColumn3.MaxInputLength = 12
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "EMAIL"
        Me.DataGridViewTextBoxColumn4.MaxInputLength = 20
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'ssGrid
        '
        Me.ssGrid.DataSource = Nothing
        Me.ssGrid.Location = New System.Drawing.Point(192, 77)
        Me.ssGrid.Name = "ssGrid"
        Me.ssGrid.OcxState = CType(resources.GetObject("ssGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssGrid.Size = New System.Drawing.Size(574, 10)
        Me.ssGrid.TabIndex = 10
        Me.ssGrid.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(185, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(251, 25)
        Me.Label11.TabIndex = 892
        Me.Label11.Text = "Committee Designation List "
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CmdExit1
        '
        Me.CmdExit1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdExit1.Image = CType(resources.GetObject("CmdExit1.Image"), System.Drawing.Image)
        Me.CmdExit1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdExit1.Location = New System.Drawing.Point(859, 395)
        Me.CmdExit1.Name = "CmdExit1"
        Me.CmdExit1.Size = New System.Drawing.Size(137, 50)
        Me.CmdExit1.TabIndex = 903
        Me.CmdExit1.Text = "Exit[F11]"
        Me.CmdExit1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdExit1.UseVisualStyleBackColor = True
        '
        'Cmd_Clear1
        '
        Me.Cmd_Clear1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear1.Image = CType(resources.GetObject("Cmd_Clear1.Image"), System.Drawing.Image)
        Me.Cmd_Clear1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Clear1.Location = New System.Drawing.Point(859, 158)
        Me.Cmd_Clear1.Name = "Cmd_Clear1"
        Me.Cmd_Clear1.Size = New System.Drawing.Size(137, 50)
        Me.Cmd_Clear1.TabIndex = 899
        Me.Cmd_Clear1.Text = "Clear[F6]"
        Me.Cmd_Clear1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Clear1.UseVisualStyleBackColor = True
        '
        'CmdAdd1
        '
        Me.CmdAdd1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAdd1.Image = CType(resources.GetObject("CmdAdd1.Image"), System.Drawing.Image)
        Me.CmdAdd1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdAdd1.Location = New System.Drawing.Point(859, 221)
        Me.CmdAdd1.Name = "CmdAdd1"
        Me.CmdAdd1.Size = New System.Drawing.Size(137, 50)
        Me.CmdAdd1.TabIndex = 900
        Me.CmdAdd1.Text = "Add[F7]"
        Me.CmdAdd1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdAdd1.UseVisualStyleBackColor = True
        '
        'Cmd_freeze
        '
        Me.Cmd_freeze.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_freeze.Image = CType(resources.GetObject("Cmd_freeze.Image"), System.Drawing.Image)
        Me.Cmd_freeze.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_freeze.Location = New System.Drawing.Point(859, 280)
        Me.Cmd_freeze.Name = "Cmd_freeze"
        Me.Cmd_freeze.Size = New System.Drawing.Size(137, 50)
        Me.Cmd_freeze.TabIndex = 901
        Me.Cmd_freeze.Text = "Void[F8]"
        Me.Cmd_freeze.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_freeze.UseVisualStyleBackColor = True
        '
        'CmdView1
        '
        Me.CmdView1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView1.Image = CType(resources.GetObject("CmdView1.Image"), System.Drawing.Image)
        Me.CmdView1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdView1.Location = New System.Drawing.Point(859, 339)
        Me.CmdView1.Name = "CmdView1"
        Me.CmdView1.Size = New System.Drawing.Size(137, 50)
        Me.CmdView1.TabIndex = 902
        Me.CmdView1.Text = "View[F9]"
        Me.CmdView1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdView1.UseVisualStyleBackColor = True
        '
        'CommitteeTransaction
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources._111in1024res
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.CmdExit1)
        Me.Controls.Add(Me.Cmd_Clear1)
        Me.Controls.Add(Me.CmdAdd1)
        Me.Controls.Add(Me.Cmd_freeze)
        Me.Controls.Add(Me.CmdView1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmd_SubCategoryCodeHelp)
        Me.Controls.Add(Me.txt_SubCategoryName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Txt_subcategorycode)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DDGRD1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.To_date)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Frm_date)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.frmbut)
        Me.Controls.Add(Me.ssGrid)
        Me.Name = "CommitteeTransaction"
        Me.Text = "CommitteeTransaction"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.frmbut.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Img_Photo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DDGRD1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim i As Integer
    Dim boolchk As Boolean
    Dim sqlstring, StrString As String
    Dim gconnection As New GlobalClass
    Dim vsearch, vitem, accountcode As String
    Dim strPhotoFilePath, strPhotoFilePath_SIG, strPhotoFilePath_Spouse, strPhotoFilePath_SpouseImg, emailst As String
    Dim strcn As String = "Data Source=" & gserver & ";Persist Security Info=False;User ID=sa;pwd=" & SQL_Password & ";Initial Catalog=  " & gdatabase & ";"
    Dim Dupchk, datachk As Boolean
    Private Sub CommitteeTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim I, J As Integer
        Dim row As Integer
        Dim col As Integer
        row = DDGRD1.CurrentCellAddress.Y
        Dim K As Integer
        I = 0
        ' If Trim(txtYearName.Text) <> "" And Trim(txtTypeCode.Text) <> "" Then
        Try
            sqlstring = "SELECT ID,DesignationCode ,Designation ,NoOfPost ,Constant ,order_comm FROM CommitteeMaster"
            'sqlstring = sqlstring & " ISNULL(C_NAME,'') AS C_NAME,ISNULL(LIMIT,0) AS LIMIT FROM ELECTIONMASTER WHERE ISNULL(YEARNAME,'')  ='" & Val(txtYearName.Text) & "' AND ISNULL(EL_CODE,'') = '" & Trim(txtTypeCode.Text) & "'"
            gconnection.getDataSet(sqlstring, "COMMASTER")
            If gdataset.Tables("COMMASTER").Rows.Count > 0 Then
                For J = 0 To gdataset.Tables("COMMASTER").Rows.Count - 1
                    ssGrid.SetText(1, J + 1, Trim(gdataset.Tables("COMMASTER").Rows(J).Item("ID")))
                    ssGrid.SetText(2, J + 1, Trim(gdataset.Tables("COMMASTER").Rows(J).Item("DesignationCode")))
                    ssGrid.SetText(3, J + 1, Trim(gdataset.Tables("COMMASTER").Rows(J).Item("Designation")))
                    'ssGrid.SetText(4, J + 1, Trim(gdataset.Tables("COMMASTER").Rows(J).Item("NoOfPost")))
                    'ssGrid.SetText(6, J + 1, Trim(gdataset.Tables("COMMASTER").Rows(J).Item("Constant")))
                    'ssGrid.SetText(5, J + 1, Trim(gdataset.Tables("COMMASTER").Rows(J).Item("order_comm")))
                    'ssGrid.SetText(7, J + 1, Trim(gdataset.Tables("COMMASTER").Rows(J).Item("order_comm")))
                    ' Me.GroupBox2.Visible = False
                Next J
                ' Me.Cmd_Add.Text = "Update[F7]"
                ' txtYearName.ReadOnly = True
                'txtTypeCode.ReadOnly = True
                'txtTypeName.ReadOnly = True
                'Me.Cmd_Add.Text = "Update[F7]"
            Else
                txtTypeName.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Enter a valid TYPE CODE ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        'Else
        'End If
        Me.Show()
        txtYearName.Focus()
        Me.GroupBox2.Visible = False
        '  Me.DDGRD1.Visible = False
        DDGRD1.Rows.Add()
    End Sub

    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        'Dim totalamt, totalqty As Double
        Dim sqlstring As String
        Dim Insert(0) As String
        Dim MCODE, MNAME As String
        Dim i, j As Integer

        'Call checkValidation() '''--->Check Validation
        If boolchk = True Then Exit Sub
        If Cmd_Add.Text = "Add [F7]" Then
            sqlstring = "DELETE FROM CommitteeTransaction where  DesignationCode='" & Trim(Txt_subcategorycode.Text & "") & "' "
            gconnection.dataOperation(1, sqlstring, "CommitteeTransaction")
            For loopindex = 0 To DDGRD1.Rows.Count - 1
                MCODE = Nothing
                MNAME = Nothing
                Dim col As Integer
                Dim Row As Integer

                col = 0
                Row = loopindex
                MCODE = DDGRD1.Rows(Row).Cells(col).Value
                col = 1
                Row = loopindex
                MNAME = DDGRD1.Rows(Row).Cells(col).Value
                If IsNothing(DDGRD1.Rows(Row).Cells(col).Value) Then
                Else
                    'sqlstring = "INSERT INTO CommitteeTransaction(ID,DesignationCode ,Designation ,NoOfPost ,order_comm,Constant ,MCODE,MNAME,CCELL,CEMAIL,"
                    'sqlstring = sqlstring & "add_user,add_date,Fromdate,Todate)"
                    sqlstring = "Insert into CommitteeTransaction(DesignationCode,Designation,MCODE,MNAME,CCELL,CEMAIL,add_user,add_date,Fromdate,Todate)values('" & Trim(Txt_subcategorycode.Text & "") & "', '" & Trim(txt_SubCategoryName.Text & "") & "',"
                    ' sqlstring = sqlstring & " '" & Trim(MCODE & "") & "','" & gUsername & " ','" & Format(Date.Now, "dd-MMM-yyyy HH:mm") & "','N')"
                    sqlstring = sqlstring & " '" & Trim(MCODE & "") & "','" & Trim(MNAME & "") & "','','','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','" & Format(Frm_date.Value, "dd-MMM-yyyy hh:mm:ss") & "','" & Format(To_date.Value, "dd-MMM-yyyy hh:mm:ss") & "')"
                    gconnection.dataOperation(1, sqlstring, "CommitteeTransaction")
                End If
            Next loopindex
            'ReDim Preserve Insert(Insert.Length)
            'Insert(Insert.Length - 1) = sqlstring
            'gconnection.MoreTrans(Insert)
            MessageBox.Show("Record Add Successfully ", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Cmd_Clear_Click(sender, e)
            'Dim cfi As New CustomFilter(ssGrid .ActiveSheet)
            'Dim ccd As FarPoint.Win.Spread.FilterColumnDefinition = FpSpread1.ActiveSheet.RowFilter.GetFilterColumnDefinition(0)
            'ccd.Filters.Add(cfi)
            'FpSpread1.ActiveSheet.DefaultStyle.CellType = New FarPoint.Win.Spread.FilterColumnDefinition
            'FpSpread1.ActiveSheet.SetValue(0, 0, 10)
            'FpSpread1.ActiveSheet.SetValue(1, 0, 100)
            'FpSpread1.ActiveSheet.SetValue(2, 0, 50)
            'FpSpread1.ActiveSheet.SetValue(3, 0, 40)
            'FpSpread1.ActiveSheet.SetValue(4, 0, 80)
            'FpSpread1.ActiveSheet.SetValue(5, 0, 1)
            'FpSpread1.ActiveSheet.SetValue(6, 0, 65)
            'FpSpread1.ActiveSheet.SetValue(7, 0, 20)
            'FpSpread1.ActiveSheet.SetValue(8, 0, 30)
            'FpSpread1.ActiveSheet.SetValue(9, 0, 35)
            '  i = 1 + 1
            '    For i = 1 To ssGrid.DataRowCnt
            '        With ssGrid
            '            sqlstring = "INSERT INTO CommitteeTransaction(ID,DesignationCode ,Designation ,NoOfPost ,order_comm,Constant ,MCODE,MNAME,CCELL,CEMAIL"
            '            sqlstring = sqlstring & "add_user,add_date,Fromdate,Todate)"
            '             sqlstring = sqlstring & " VALUES('" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_FirstName.Text) & "','" & Replace(Trim(txtTypeName.Text), "'", "") & "',"
            '            sqlstring = sqlstring & " VALUES("
            '            .Row = i
            '            .Col = 1
            '            sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '            .Col = 2
            '            sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '            .Col = 3
            '            sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '            .Col = 4
            '            sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '            .Col = 5
            '            sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '            .Col = 6
            '            sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '             sqlstring = sqlstring & "'" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'," & Val(txtLimit.Text) & ")"
            '            sqlstring = sqlstring & "''" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_FirstName.Text) & "','" & Trim(txt_RA_Email.Text) & "','" & Trim(txt_RA_MobileNo.Text) & "','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','" & Format(Frm_date.Value, "dd-MMM-yyyy hh:mm:ss") & "','" & Format(To_date.Value, "dd-MMM-yyyy hh:mm:ss") & "')"
            '            ReDim Preserve Insert(Insert.Length)
            '            Insert(Insert.Length - 1) = sqlstring
            '        End With
            '    Next i
            '    gconnection.MoreTrans(Insert)
            '    Call Cmd_Clear_Click(sender, e)
            'Else
            '    sqlstring = "DELETE FROM CommitteeMaster "
            '    ReDim Preserve Insert(Insert.Length)
            '    Insert(Insert.Length - 1) = sqlstring
            '    For i = 1 To ssGrid.DataRowCnt
            '        With ssGrid
            '            sqlstring = "INSERT INTO CommitteeTransaction(ID,DesignationCode ,Designation ,NoOfPost ,order_comm,Constant ,MCODE,MNAME,CCELL,CEMAIL,"
            '            sqlstring = sqlstring & "add_user,add_date,Fromdate,Todate)"
            '             sqlstring = sqlstring & " VALUES('" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_FirstName.Text) & "','" & Replace(Trim(txtTypeName.Text), "'", "") & "',"
            '            sqlstring = sqlstring & " VALUES("
            '            .Row = i
            '            .Col = 1
            '            sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '            .Col = 2
            '            sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '            .Col = 3
            '            sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '            .Col = 4
            '            sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '            .Col = 5
            '            sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '            .Col = 6
            '            sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '             sqlstring = sqlstring & "'" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'," & Val(txtLimit.Text) & ")"
            '            sqlstring = sqlstring & "'" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_FirstName.Text) & "','" & Trim(txt_RA_Email.Text) & "','" & Trim(txt_RA_MobileNo.Text) & "','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','" & Format(Frm_date.Value, "dd-MMM-yyyy hh:mm:ss") & "','" & Format(To_date.Value, "dd-MMM-yyyy hh:mm:ss") & "')"
            '            ReDim Preserve Insert(Insert.Length)
            '            Insert(Insert.Length - 1) = sqlstring
            '        End With
            '    Next i
            '    gconnection.MoreTrans(Insert)
            '    Call Cmd_Clear_Click(sender, e)
            '   Else

            'Dim cfi As New CustomFilter(FpSpread1.ActiveSheet)
            'Dim ccd As FarPoint.Win.Spread.FilterColumnDefinition = FpSpread1.ActiveSheet.RowFilter.GetFilterColumnDefinition(0)
            'ccd.Filters.Add(cfi)
            'FpSpread1.ActiveSheet.DefaultStyle.CellType = New FarPoint.Win.Spread.FilterColumnDefinition
            'FpSpread1.ActiveSheet.SetValue(0, 0, 10)
            'FpSpread1.ActiveSheet.SetValue(1, 0, 100)
            'FpSpread1.ActiveSheet.SetValue(2, 0, 50)
            'FpSpread1.ActiveSheet.SetValue(3, 0, 40)
            'FpSpread1.ActiveSheet.SetValue(4, 0, 80)
            'FpSpread1.ActiveSheet.SetValue(5, 0, 1)
            'FpSpread1.ActiveSheet.SetValue(6, 0, 65)
            'FpSpread1.ActiveSheet.SetValue(7, 0, 20)
            'FpSpread1.ActiveSheet.SetValue(8, 0, 30)
            'FpSpread1.ActiveSheet.SetValue(9, 0, 35)

            ' If ssGrid.Row = 1 Then

            'With ssGrid
            '    .Row = .ActiveRow
            '    ' .ClearRange(1, .ActiveRow, 11, .ActiveRow, True)
            '    '.SetActiveCell(.ActiveRow, 1)
            '    ' Call Calculate()
            '    .SetActiveCell(1, ssGrid.ActiveRow)
            '    .Focus()
            'End With


            '    With ssGrid
            '        'sqlstring = sqlstring & "'" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_FirstName.Text) & "','" & Trim(txt_RA_Email.Text) & "','" & Trim(txt_RA_MobileNo.Text) & "','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','" & Format(Frm_date.Value, "dd-MMM-yyyy hh:mm:ss") & "','" & Format(To_date.Value, "dd-MMM-yyyy hh:mm:ss") & "')"
            '        For loopindex = 0 To DDGRD1.Rows.Count - 1
            '            MCODE = Nothing
            '            MNAME = Nothing
            '            Dim col As Integer
            '            Dim Row As Integer
            '            col = 0
            '            Row = loopindex
            '            MCODE = DDGRD1.Rows(Row).Cells(col).Value
            '            col = 1
            '            Row = loopindex
            '            MNAME = DDGRD1.Rows(Row).Cells(col).Value
            '            If IsNothing(DDGRD1.Rows(Row).Cells(col).Value) Then
            '            Else
            '                'If ssGrid.ActiveCol = 7 Then
            '                ssGrid.Col = ssGrid.ActiveCol
            '                i = ssGrid.ActiveRow
            '                ssGrid.Row = i
            '                'ssGrid.Lock = False
            '                .Row = .ActiveRow
            '                .SetActiveCell(1, ssGrid.ActiveRow)

            '                'i = .Row
            '                .Focus()
            '                For i = .Row To ssGrid.DataRowCnt
            '                    ' For i = 1 To 1
            '                    sqlstring = "INSERT INTO CommitteeTransaction(ID,DesignationCode ,Designation ,NoOfPost ,order_comm,Constant ,MCODE,MNAME,CCELL,CEMAIL,"
            '                    sqlstring = sqlstring & "add_user,add_date,Fromdate,Todate)"
            '                    sqlstring = sqlstring & " VALUES("
            '                    .Row = i
            '                    .Col = 1
            '                    sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '                    .Col = 2
            '                    sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '                    .Col = 3
            '                    sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '                    .Col = 4
            '                    sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '                    .Col = 5
            '                    sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '                    .Col = 6
            '                    sqlstring = sqlstring & "'" & Trim(.Text) & "',"

            '                    ' sqlstring = sqlstring & "'" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'," & Val(txtLimit.Text) & ")"
            '                    'sqlstring = sqlstring & "'" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_FirstName.Text) & "','" & Trim(txt_RA_Email.Text) & "','" & Trim(txt_RA_MobileNo.Text) & "','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','" & Format(Frm_date.Value, "dd-MMM-yyyy hh:mm:ss") & "','" & Format(To_date.Value, "dd-MMM-yyyy hh:mm:ss") & "')"
            '                    ' sqlstring = sqlstring & " '" & Trim(MCODE & "") & "','" & Trim(MCODE & "") & "','" & Trim(txt_RA_Email.Text) & "','" & Trim(gUsername) & "','" & Format(Frm_date.Value, "dd-MMM-yyyy hh:mm:ss") & "','" & Format(To_date.Value, "dd-MMM-yyyy hh:mm:ss") & "')"
            '                    sqlstring = sqlstring & " '" & Trim(MCODE & "") & "','" & Trim(MNAME & "") & "','','','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','" & Format(Frm_date.Value, "dd-MMM-yyyy hh:mm:ss") & "','" & Format(To_date.Value, "dd-MMM-yyyy hh:mm:ss") & "')"
            '                    ReDim Preserve Insert(Insert.Length)
            '                    Insert(Insert.Length - 1) = sqlstring
            '                    'ssGrid.AllowRowMove = False
            '                    'ssGrid.ClearRange(1, 1, -1, -1, True)
            '                    '.Row = .ActiveRow
            '                    '.SetActiveCell(1, ssGrid.ActiveRow)
            '                    ''i = .Row
            '                    '.Focus()
            '                Next
            '            End If
            '            ' End If
            '        Next loopindex
            '    End With
            '    gconnection.MoreTrans(Insert)
            '    Call Cmd_Clear_Click(sender, e)
            '    ' End If
            '    'If ssGrid.Row = 2 Then

            '    'End If
            '    Call Cmd_Clear_Click(sender, e)
            'End If

        Else
            sqlstring = "DELETE FROM CommitteeTransaction where  DesignationCode='" & Trim(Txt_subcategorycode.Text & "") & "' "
            gconnection.dataOperation(1, sqlstring, "CommitteeTransaction")
            For loopindex = 0 To DDGRD1.Rows.Count - 1
                MCODE = Nothing
                MNAME = Nothing
                Dim col As Integer
                Dim Row As Integer

                col = 0
                Row = loopindex
                MCODE = DDGRD1.Rows(Row).Cells(col).Value
                col = 1
                Row = loopindex
                MNAME = DDGRD1.Rows(Row).Cells(col).Value
                If IsNothing(DDGRD1.Rows(Row).Cells(col).Value) Then
                Else
                    'sqlstring = "INSERT INTO CommitteeTransaction(ID,DesignationCode ,Designation ,NoOfPost ,order_comm,Constant ,MCODE,MNAME,CCELL,CEMAIL,"
                    'sqlstring = sqlstring & "add_user,add_date,Fromdate,Todate)"
                    sqlstring = "Insert into CommitteeTransaction(DesignationCode,Designation,MCODE,MNAME,CCELL,CEMAIL,add_user,add_date,Fromdate,Todate)values('" & Trim(Txt_subcategorycode.Text & "") & "', '" & Trim(txt_SubCategoryName.Text & "") & "',"
                    ' sqlstring = sqlstring & " '" & Trim(MCODE & "") & "','" & gUsername & " ','" & Format(Date.Now, "dd-MMM-yyyy HH:mm") & "','N')"
                    sqlstring = sqlstring & " '" & Trim(MCODE & "") & "','" & Trim(MNAME & "") & "','','','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','" & Format(Frm_date.Value, "dd-MMM-yyyy hh:mm:ss") & "','" & Format(To_date.Value, "dd-MMM-yyyy hh:mm:ss") & "')"
                    gconnection.dataOperation(1, sqlstring, "CommitteeTransaction")
                End If
            Next loopindex
            'ReDim Preserve Insert(Insert.Length)
            'Insert(Insert.Length - 1) = sqlstring
            'gconnection.MoreTrans(Insert)
            MessageBox.Show("Record Add Successfully ", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Cmd_Clear_Click(sender, e)
        End If



        'For i = 1 To ssGrid.DataRowCnt
        '    With ssGrid
        '        sqlstring = "INSERT INTO CommitteeMaster(ID,DesignationCode ,Designation ,NoOfPost ,order_comm,Constant ,"
        '        sqlstring = sqlstring & "add_user,add_date)"
        '        'sqlstring = sqlstring & " VALUES('" & Trim(txtYearName.Text) & "','" & Trim(txtTypeCode.Text) & "','" & Replace(Trim(txtTypeName.Text), "'", "") & "',"
        '        sqlstring = sqlstring & " VALUES("
        '        .Row = i
        '        .Col = 1
        '        sqlstring = sqlstring & "'" & Trim(.Text) & "',"
        '        .Col = 2
        '        sqlstring = sqlstring & "'" & Trim(.Text) & "',"
        '        .Col = 3
        '        sqlstring = sqlstring & "'" & Trim(.Text) & "',"
        '        .Col = 4
        '        sqlstring = sqlstring & "'" & Trim(.Text) & "',"
        '        .Col = 5
        '        sqlstring = sqlstring & "'" & Trim(.Text) & "',"
        '        .Col = 6
        '        sqlstring = sqlstring & "'" & Trim(.Text) & "',"
        '        ' sqlstring = sqlstring & "'" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'," & Val(txtLimit.Text) & ")"
        '        sqlstring = sqlstring & "'" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
        '        ReDim Preserve Insert(Insert.Length)
        '        Insert(Insert.Length - 1) = sqlstring
        '    End With
        'Next i

        ' sqlstring = " Update membermaster set MEMIMAGE=@memimage Where Mcode='" & txt_MemberCode.Text & "' "
        'Call SaveFoto(strPhotoFilePath, Trim(txt_MemberCode.Text.Replace("'", "")), sqlstring)
    End Sub
    Public Sub checkValidation()
        boolchk = False
        If Trim(txtYearName.Text) = "" Then
            MessageBox.Show(" Year Name can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtYearName.Focus()
            Exit Sub
        End If

        If Trim(txtTypeCode.Text) = "" Then
            MessageBox.Show(" Election Type Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTypeCode.Focus()
            Exit Sub
        End If

        If Trim(txtTypeName.Text) = "" Then
            MessageBox.Show(" Election Type Name can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTypeName.Focus()
            Exit Sub
        End If

        StrString = "SELECT * FROM ELECTION_ENTRY WHERE YEARNAME = '" & Val(txtYearName.Text) & "' AND EL_CODE = '" & Trim(txtTypeCode.Text) & "'"
        gconnection.getDataSet(StrString, "CHECK")
        If gdataset.Tables("CHECK").Rows.Count > 0 Then
            MessageBox.Show("Can't Modify Vote already Exits", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        For i = 1 To ssGrid.DataRowCnt
            ssGrid.Row = i
            ssGrid.Col = 1
            If Trim(ssGrid.Text) = "" Then
                MessageBox.Show("Candidate Code can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                ssGrid.Focus()
                Exit Sub
            End If
            ssGrid.Col = 2
            If Trim(ssGrid.Text) = "" Then
                MessageBox.Show("Candidate Name can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                ssGrid.SetActiveCell(2, ssGrid.ActiveRow)
                ssGrid.Focus()
                Exit Sub
            End If
        Next i
        boolchk = True
    End Sub

    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        txtYearName.Text = ""
        txtTypeCode.Text = ""
        txtTypeName.Text = ""
        Txt_subcategorycode.Text = ""
        txt_SubCategoryName.Text = ""
        DDGRD1.DataSource = Nothing
        DDGRD1.Rows.Clear()
        'txtLimit.Text = ""
        ssGrid.ClearRange(1, 1, -1, -1, True)
        Cmd_Add.Text = "Add [F7]"
        ssGrid.SetActiveCell(1, 1)
        txtYearName.ReadOnly = False
        txtTypeCode.ReadOnly = False
        txtTypeName.ReadOnly = False
        txtYearName.Focus()
        DDGRD1.Rows.Add()
    End Sub
    Private Sub Cmd_TypeCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_TypeCodeHelp.Click
        '    gSQLString = "SELECT  Distinct ISNULL(El_Code,'') as El_Code,ISNULL(El_Name,'') AS El_Name FROM ElectionMaster "
        '    If Trim(Search) = " " Then
        '        'M_WhereCondition = " WHERE POS IN (SELECT STORECODE FROM STOREMASTER) "
        '        'HARD CODED FOR CSC 
        '        M_WhereCondition = " WHERE YearName= '" & Val(txtYearName.Text) & "' "
        '    Else
        '        'M_WhereCondition = " WHERE POS IN (SELECT STORECODE FROM STOREMASTER) "
        '        M_WhereCondition = " WHERE YearName= '" & Val(txtYearName.Text) & "' "
        '    End If
        '    Dim vform As New ListOperattion1
        '    vform.Field = "EL_CODE,EL_NAME"
        '    vform.vFormatstring = "  TYPE CODE                                      |  TYPE NAME                       "
        '    vform.vCaption = " ELECTION MASTER HELP"
        '    vform.KeyPos = 0
        '    vform.KeyPos1 = 1
        '    vform.ShowDialog(Me)
        '    If Trim(vform.keyfield & "") <> "" Then
        '        txtTypeCode.Text = Trim(vform.keyfield & "")
        ' Call txtTypeCode_Validated(txtTypeCode, e)
        '    End If
        '    vform.Close()
        '    vform = Nothing
    End Sub

    'Private Sub txtTypeCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTypeCode.Validated
    '    Dim J, K As Integer
    '    i = 0
    '    If Trim(txtYearName.Text) <> "" And Trim(txtTypeCode.Text) <> "" Then
    '        Try
    '            sqlstring = "SELECT ISNULL(YEARNAME,'') AS YEARNAME,ISNULL(EL_CODE,'') AS EL_CODE,ISNULL(EL_NAME,'') AS EL_NAME,ISNULL(C_CODE,'') AS C_CODE,"
    '            sqlstring = sqlstring & " ISNULL(C_NAME,'') AS C_NAME,ISNULL(LIMIT,0) AS LIMIT FROM ELECTIONMASTER WHERE ISNULL(YEARNAME,'')  ='" & Val(txtYearName.Text) & "' AND ISNULL(EL_CODE,'') = '" & Trim(txtTypeCode.Text) & "'"
    '            gconnection.getDataSet(sqlstring, "ELMASTER")
    '            If gdataset.Tables("ELMASTER").Rows.Count > 0 Then
    '                txtTypeCode.Text = Trim(gdataset.Tables("ELMASTER").Rows(0).Item("EL_CODE"))
    '                txtTypeName.Text = Trim(gdataset.Tables("ELMASTER").Rows(0).Item("EL_NAME"))
    '                'txtLimit.Text = Val(gdataset.Tables("ELMASTER").Rows(0).Item("LIMIT"))
    '                For J = 0 To gdataset.Tables("ELMASTER").Rows.Count - 1
    '                    ssGrid.SetText(1, J + 1, Trim(gdataset.Tables("ELMASTER").Rows(J).Item("C_CODE")))
    '                    ssGrid.SetText(2, J + 1, Trim(gdataset.Tables("ELMASTER").Rows(J).Item("C_NAME")))
    '                Next J
    '                Me.Cmd_Add.Text = "Update[F7]"
    '                txtYearName.ReadOnly = True
    '                txtTypeCode.ReadOnly = True
    '                'txtTypeName.ReadOnly = True
    '                Me.Cmd_Add.Text = "Update[F7]"
    '            Else
    '                txtTypeName.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Enter a valid TYPE CODE ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            Exit Sub
    '        End Try
    '    Else

    '    End If
    'End Sub
    Private Sub txtYearName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtYearName.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txtTypeCode.Focus()
        End If
    End Sub

    Private Sub txtTypeCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTypeCode.KeyDown
        If e.KeyCode = Keys.F4 Then
            If Cmd_TypeCodeHelp.Enabled = True Then
                Call Cmd_TypeCodeHelp_Click(Cmd_TypeCodeHelp, e)
            End If
        End If
    End Sub

    Private Sub txtTypeCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTypeCode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txtTypeCode.Text) = "" Then
                Call Cmd_TypeCodeHelp_Click(Cmd_TypeCodeHelp, e)
            Else
                'txtTypeCode_Validated(txtTypeCode, e)
            End If
        End If
    End Sub

    Private Sub txtTypeName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTypeName.KeyPress
        ssGrid.Show()
        ssGrid.SetActiveCell(1, 1)
    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub Cmd_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Delete.Click
        If Trim(txtYearName.Text) <> "" And Trim(txtTypeCode.Text) <> "" Then
            If MessageBox.Show("Do You Want Delete it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                sqlstring = "DELETE FROM ElectionMaster WHERE Yearname='" & Trim(txtYearName.Text) & "' And El_Code='" & Trim(txtTypeCode.Text) & "'"
                gconnection.dataOperation(6, sqlstring, "EL_Det")
                Call Cmd_Clear_Click(sender, e)
            Else
                Call Cmd_Clear_Click(sender, e)
            End If
        End If
    End Sub

    'Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
    'Dim FrReport As New ReportDesigner
    '    tables = " FROM ElectionMaster"
    '    Gheader = "ELECTION MASTER"
    '    FrReport.SsGridReport.SetText(2, 1, "YEARNAME")
    '    FrReport.SsGridReport.SetText(3, 1, 8)
    '    FrReport.SsGridReport.SetText(2, 2, "EL_CODE")
    '    FrReport.SsGridReport.SetText(3, 2, 10)
    '    FrReport.SsGridReport.SetText(2, 3, "EL_NAME")
    '    FrReport.SsGridReport.SetText(3, 3, 25)
    '    FrReport.SsGridReport.SetText(2, 4, "C_CODE")
    '    FrReport.SsGridReport.SetText(3, 4, 10)
    '    FrReport.SsGridReport.SetText(2, 5, "C_NAME")
    '    FrReport.SsGridReport.SetText(3, 5, 25)
    '    FrReport.Show()
    'End Sub

    Private Sub txtLimit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            Cmd_Add.Focus()
        End If
    End Sub
    Private Sub ssGrid_ButtonClicked(sender As Object, e As AxFPSpreadADO._DSpreadEvents_ButtonClickedEvent) Handles ssGrid.ButtonClicked
        Dim Addmember, ssql, NoOfPost As String
        Dim vref As String
        ' Dim Row As String
        ' If e.buttonDown = "Addmember" Then
        ' ssGrid.BackColor = Color.Red
        ssql = "select NoOfPost from CommitteeMaster"
        'Dim tota_level_1 As Integer = 1
        'NoOfPost += 1
        'ssql = "select * from CommitteeMaster where NoOfPost = '" + NoOfPost + "'"
        ' If NoOfPost = 1 Then
        ' Me.GroupBox2.Visible = True

        Me.DDGRD1.Visible = True
        ' End If
        'ElseIf e.buttonDown = "Addmember" Then
        ssGrid.ForeColor = Color.Blue

        ' End If
        'For i = 1 To ssGrid.le
        '    With ssGrid
        '        .Row = i
        '        .Col = 4
        '        vref = Trim(.Text)
        '    End With
        'Next
        'If vref = 1 Then
        '    Me.GroupBox2.Visible = True
        'ElseIf vref = 2 Then
        '    Me.GroupBox2.Visible = True
        '    Me.GroupBox3.Visible = True
        ''End If
        'If ssGrid.ActiveRow = 1 Then
        '    With ssGrid
        '        .Row = 1
        '        .Col = 4
        '        ssGrid.ac(1, 1, -1, -1)
        '    End With
        'End If
        '  ssGrid.ActiveRow = 2

    End Sub
    'Private Sub GR_test()
    '    If (ssGrid.DataRowCnt > 0) Then
    '        for (int i = 0; i < ssGrid.DataRowCnt; i++)


    '        Next
    '    End If
    'End Sub

    Private Sub ssGrid_KeyDownEvent(sender As Object, e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssGrid.KeyDownEvent
        Dim I As Integer
        Dim VSTR As Integer
        Dim vref As String

        If e.keyCode = Keys.Add Then
            For I = 1 To ssGrid.DataRowCnt
                With ssGrid
                    .Row = 1
                    .Col = 7
                    ' vref = Trim(.Text)
                End With
                ssGrid.ClearRange(2, 2, -2, -2, True)
            Next
            For I = 2 To ssGrid.DataRowCnt
                With ssGrid
                    .Row = 2
                    .Col = 7
                    ' vref = Trim(.Text)
                End With
            Next
            For I = 3 To ssGrid.DataRowCnt
                With ssGrid
                    .Row = 3
                    .Col = 7
                    ' vref = Trim(.Text)
                End With
            Next
        End If

    End Sub

    'Private Sub cmd_MemberCodeHelp_Click(sender As Object, e As EventArgs) Handles cmd_MemberCodeHelp.Click
    '    Try
    '        Dim vform As New LIST_OPERATION1
    '        gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM membermaster"
    '        M_WhereCondition = " "
    '        vform.Field = "MCODE,MNAME"
    '        vform.vCaption = "Member Master Help"
    '        vform.ShowDialog(Me)
    '        If Trim(vform.keyfield & "") <> "" Then
    '            txt_MemberCode.Text = Trim(vform.keyfield & "")
    '            txt_membercode_valid()
    '        End If
    '        vform.Close()
    '        vform = Nothing
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
    '    End Try
    'End Sub
    Public Function CheckDBNull(ByVal obj As Object, Optional ByVal ObjectType As enumObjectType = enumObjectType.StrType) As Object
        Dim objReturn As Object
        objReturn = obj
        If ObjectType = enumObjectType.StrType And IsDBNull(obj) Then
            objReturn = ""
        ElseIf ObjectType = enumObjectType.IntType And IsDBNull(obj) Then
            objReturn = 0
        ElseIf ObjectType = enumObjectType.DblType And IsDBNull(obj) Then
            objReturn = 0.0
        End If
        Return objReturn
    End Function
    Private Sub txt_membercode_valid()
        Try
            Dim I, J As Integer
            Dim paddress1, oaddress1, raddress1, caddress1 As String
            Dim paddress2, oaddress2, raddress2, caddress2 As String
            Dim paddress3, oaddress3, raddress3, caddress3 As String
            Dim Pcell, Ocell, Rcell, Ccell, sqlstring, Sqlstr As String
            If txt_MemberCode.Text <> "" Then

                Sqlstr = " SELECT isnull(religion,'')as religion,isnull(MEMBERTYPECODE,'') as MEMBERTYPECODE,salut,isnull(Prefix,'') as Prefix,isnull(FirstName,'') as FirstName,isnull(MiddleName,'') as MiddleName,isnull(Surname,'') as Surname,isnull(CurentStatus,'') as CurentStatus,isnull(billbasis,'') as billbasis,isnull(SEX,'') as SEX,"
                Sqlstr = Sqlstr & " Convert(varchar(11),isnull(DOB,''),106) as DOB,Convert(varchar(11),isnull(ApplDate,''),106) as ApplDate,isnull(ApplNo,'')as ApplNo,isnull(cardno,'')As cardno,Convert(varchar(11),isnull(SDOB,''),106) as SDOB,wedding_date,Convert(varchar(11),isnull(DOJ,''),106) as DOJ,Convert(varchar(11),isnull(Endingdate,''),106) as Endingdate,isnull(MARITALSTATUS,'') as MARITALSTATUS,isnull(spouse,'') as spouse,isnull(PADD1,'') as PADD1,isnull(PADD2,'') as PADD2,isnull(PADD3,'') as PADD3,PCITY,PSTATE,PCOUNTRY,PPIN,PPHONE1,PPHONE2,PCELL,PEMAIL,CADD1,CADD2,CADD3,CCITY,CSTATE,CCOUNTRY,CPIN,CPHONE1,CPHONE2,CCELL,CEMAIL,OADD1,OADD2,OADD3,OCITY,OSTATE,OCOUNTRY,OPIN,OPHONE1,OPHONE2,OCELL,OEMAIL,CONTADD1,CONTADD2,CONTADD3,CONTCITY,CONTSTATE,CONTPIN,CONTPHONE1,CONTPHONE2,CONTCELL,CONTEMAIL,RankNo,ICNO,UnitNo,Convert(varchar(11),isnull(DateOfCommission,''),106) as DateOfCommission,Convert(varchar(11),isnull(DateOfCreation,''),106) as DateOfCreation,Convert(varchar(11),isnull(DateOfRelease,''),106) as DateOfRelease,isnull(MDescription,'') as MDescription,RIDCardNo,ArmService,WO,NoOfDependencies,RByMemberNo,RByName,RBYMEMBERNO2,RBYMEMBERNAME2,MEMBERTYPE,PROPOSER,PROPOSERNAME,SECONDER,SECONDERNAME,isnull(RAcopyst1,'') as RAcopyst1,isnull(PAcopyst1,'')as PAcopyst1,isnull(BAcopyst1,'')as BAcopyst1,isnull(bg,'') as bg, isnull(pano,'') as pano,isnull(criditnumber,'') as criditnumber,marital_status,occupation,COMPANY,Designation,BuisnessInfo,isnull(ProfessionInfo,'')as ProfessionInfo ,Products ,AgentsDealers ,Turnover ,NoOfEmp,oldmcode,isnull(spouseprefix,'') as spouseprefix,Isnull(Corporatecode,'') as Corporatecode,Isnull(SpouseFreeze,'')as SpouseFreeze,isnull(Catlimit,0) as catlimit,isnull(memlimit,0) as memlimit,isnull(replacement,'') as replacement,ISNULL(RNO,'') AS RNO,isnull(spl_info,'') as spl_info,isnull(SECONDER1,'') as SECONDER1,isnull(SECONDERNAME1,'') as SECONDERNAME1,isnull(spousemobile,'') as spousemobile ,isnull(PASSPORTNO,'') as PASSPORTNO,ISNULL(MINYN,'') AS MINYN FROM MEMBERMASTER WHERE MCODE='" & txt_MemberCode.Text & "'"
                gconnection.getDataSet(Sqlstr, "MemMst")
                'Call loadMaritalstatus(I + 1)
                'Call loadmembertype(I + 1)
                If gdataset.Tables("MemMst").Rows.Count > 0 Then
                    txt_MemberCode.ReadOnly = True
                    txt_MemberCode.Select()
                    'Call Dependentagelimit()

                    'cbo_BillingBasis.Enabled = False
                    'Call loadmembertype(I + 1)
                    'Call loadSalutation(I + 1)
                    txt_FirstName.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("FirstName"))

                    'If Cmb_Category.Text = "INSTITUTIONAL MEMBERS" Then
                    '    Txt_Replacement.Enabled = True
                    '    Cmd_Replacement.Enabled = True
                    'Else
                    '    Txt_Replacement.Enabled = False
                    '    Cmd_Replacement.Enabled = False

                    'End If
                    'sqlstring = "select isnull(creditlimityn,'') as creditlimityn,isnull(tenures,'') as tenures from subcategorymaster where subtypedesc='" & Cmb_Category.Text & "'"
                    'gconnection.getDataSet(sqlstring, "subcategory")
                    ''If gdataset.Tables("subcategory").Rows.Count > 0 Then
                    '    CREDITYN = gdataset.Tables("subcategory").Rows(0).Item("CREDITLIMITYN")
                    '    VALIDITY = gdataset.Tables("subcategory").Rows(0).Item("tenures")

                    'End If
                    'If VALIDITY = "Y" Then
                    '    chk_EXPDT.Enabled = False
                    '    dtp_EXPDT.Enabled = False
                    'Else

                    'End If
                    Dim index As Integer
                    gconnection.getDataSet("SELECT isnull(TYPEDESC,'') as TYPEDESC,isnull(MEMBERTYPE,'') as MEMBERTYPE  FROM MEMBERTYPE WHERE ISNULL(FREEZE,'')<>'Y' and MEMBERTYPE='" & gdataset.Tables("MemMst").Rows(0).Item("MEMBERTYPECODE") & "'", "TypeMst")
                    'If gdataset.Tables("TypeMst").Rows.Count > 0 Then
                    '    Cmb_Category.Text = (gdataset.Tables("TypeMst").Rows(0).Item("TYPEDESC"))
                    'End If
                    'cbo_CurrentStatus.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CurentStatus"))
                    ''---------subscription Type-----------
                    'If Cmb_Category.Text = "INSTITUTIONAL MEMBERS" Then
                    '    If cbo_CurrentStatus.Text = "ACTIVE" Or cbo_CurrentStatus.Text = "LIVE" Then
                    '        Txt_Replacement.Enabled = True
                    '        Txt_Rno.Enabled = True
                    '        Cmd_Replacement.Enabled = True
                    '    Else
                    '        Txt_Replacement.Enabled = False
                    '        Cmd_Replacement.Enabled = False
                    '        Txt_Rno.Enabled = False

                    '    End If
                    'Else
                    '    Txt_Replacement.Enabled = False
                    '    Cmd_Replacement.Enabled = False

                    'End If
                    'validation = True
                    'index = cbo_BillingBasis.FindString((gdataset.Tables("MemMst").Rows(0).Item("billbasis")))
                    'If index < 0 Then
                    '    If Cmb_Category.Items.Count > 0 Then
                    '        cbo_BillingBasis.SelectedIndex = 0
                    '    End If
                    'Else
                    '    cbo_BillingBasis.SelectedIndex = index
                    'End If
                    'If (gdataset.Tables("MemMst").Rows(0).Item("SEX")) = "F" Then
                    '    chk_female.Checked = True
                    '    chk_male.Checked = False
                    'ElseIf (gdataset.Tables("MemMst").Rows(0).Item("SEX")) = "M" Then
                    '    chk_male.Checked = True
                    '    chk_female.Checked = False
                    'Else
                    '    chk_male.Checked = False
                    '    chk_female.Checked = False
                    'End If

                    'If (gdataset.Tables("MemMst").Rows(0).Item("DOB")) = "01 Jan 1900" Then
                    '    'dtp_DOB.Text = ""
                    '    CHK_DOB.Checked = False
                    'Else
                    '    dtp_DOB.Text = Format(CDate(gdataset.Tables("MemMst").Rows(0).Item("DOB")), "dd/MMM/yyyy")
                    '    CHK_DOB.Checked = True
                    'End If

                    'CHK_DOB_CheckedChanged(New System.EventArgs, New System.EventArgs)
                    'If (gdataset.Tables("MemMst").Rows(0).Item("Endingdate")) = "01 Jan 1900" Then
                    '    dtp_EXPDT.Text = ""
                    '    chk_EXPDT.Checked = False
                    'Else
                    '    dtp_EXPDT.Text = Format(CDate(gdataset.Tables("MemMst").Rows(0).Item("Endingdate")), "dd/MMM/yyyy")
                    '    chk_EXPDT.Checked = True
                    '    chk_EXPDT.Enabled = True
                    'End If
                    'chk_EXPDT_CheckedChanged(New System.EventArgs, New System.EventArgs)

                    'If (gdataset.Tables("MemMst").Rows(0).Item("DOJ")) = "01 Jan 1900" Then
                    '    dtp_DOJ.Text = ""
                    '    CHK_DOJ.Checked = False
                    'Else
                    '    dtp_DOJ.Text = Format(CDate(gdataset.Tables("MemMst").Rows(0).Item("DOJ")), "dd/MMM/yyyy")
                    '    CHK_DOJ.Checked = True
                    'End If
                    'If (gdataset.Tables("MemMst").Rows(0).Item("wedding_date")) = "01 Jan 1900" Then
                    '    dtp_DOW.Text = ""
                    '    CHK_WDT.Checked = False
                    'Else
                    '    dtp_DOW.Text = Format(CDate(gdataset.Tables("MemMst").Rows(0).Item("wedding_date")), "dd/MMM/yyyy")
                    '    CHK_WDT.Checked = True
                    'End If

                    'If (gdataset.Tables("MemMst").Rows(0).Item("SDOB")) = "01 Jan 1900" Then
                    '    Dtp_Spousedob.Text = ""
                    '    ChK_SDOB.Checked = False
                    'Else
                    '    Dtp_Spousedob.Text = (gdataset.Tables("MemMst").Rows(0).Item("SDOB"))
                    '    ChK_SDOB.Checked = True
                    'End If


                    txt_RA_Email.Text = CheckDBNull(gdataset.Tables("MemMst").Rows(0).Item("CEMAIL"))


                    '----Spouse Freeze------------

                    'Member Education

                    'Entrance Fee
                    Sqlstr = "SELECT memimage as memimage FROM membermaster WHERE mcode='" & Trim(txt_MemberCode.Text) & "' "
                    LoadFoto_DB(Sqlstr, Img_Photo)
                    'Sqlstr = "SELECT memimagesign as memimage FROM membermaster WHERE mcode='" & Trim(txt_MemberCode.Text) & "' "
                    'LoadFoto_DB(Sqlstr, Img_Signature)
                    'Sqlstr = "SELECT SpouseImage as memimage FROM membermaster WHERE mcode='" & Trim(txt_MemberCode.Text) & "' "
                    'LoadFoto_DB(Sqlstr, Img_Spousephoto)
                    'Sqlstr = "SELECT SpouseImageSign as memimage FROM membermaster WHERE mcode='" & Trim(txt_MemberCode.Text) & "' "
                    'LoadFoto_DB(Sqlstr, Sp_Img_Signature)
                    'btn_add.Text = "Update[F7]"
                    'paddress1 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("PADD1")))
                    'oaddress1 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("OADD1")))
                    'raddress1 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("CADD1")))
                    'caddress1 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("CONTADD1")))
                    'paddress2 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("PADD2")))
                    'oaddress2 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("OADD2")))
                    'raddress2 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("CADD2")))
                    'caddress2 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("CONTADD2")))
                    'paddress3 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("PADD3")))
                    'oaddress3 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("OADD3")))
                    'raddress3 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("CADD3")))
                    'caddress3 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("CONTADD3")))
                    'pcell = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("PCELL")))
                    'ocell = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("OCELL")))
                    'rcell = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("CCELL")))
                    'ccell = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("CONTCELL")))
                    'If paddress1 = caddress1 And paddress2 = caddress2 And paddress3 = caddress3 And Pcell = Ccell Then
                    '    chk_ContactAddress1.Checked = True
                    'ElseIf oaddress1 = caddress1 And oaddress2 = caddress2 And oaddress3 = caddress3 And Ocell = Ccell Then
                    '    chk_ContactAddress2.Checked = True
                    'ElseIf raddress1 = caddress1 And raddress2 = caddress2 And raddress3 = caddress3 And Rcell = Ccell Then
                    '    chk_ContactAddress3.Checked = True
                    'Else
                    '    chk_ContactAddress1.Checked = False
                    '    chk_ContactAddress2.Checked = False
                    '    chk_ContactAddress3.Checked = False
                    'End If
                    '    paddress1 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("PAcopyst1")))
                    '    oaddress1 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("BAcopyst1")))
                    '    raddress1 = CheckDBNull((gdataset.Tables("MemMst").Rows(0).Item("RAcopyst1")))
                    '    If paddress1 = "Y" Then
                    '        chk_ContactAddress1.Checked = True
                    '    ElseIf oaddress1 = "Y" Then
                    '        chk_ContactAddress2.Checked = True
                    '    ElseIf raddress1 = "Y" Then
                    '        chk_ContactAddress3.Checked = True
                    '    Else
                    '        chk_ContactAddress1.Checked = False
                    '        chk_ContactAddress2.Checked = False
                    '        chk_ContactAddress3.Checked = False
                    '    End If
                    '    Cbo_title.Focus()

                    'Else
                    '    txt_MemberCode.ReadOnly = False
                    '    btn_add.Text = "Add[F7]"
                    '    'Cmb_Category.SelectedIndex = 1
                    '    Cmb_Category.Focus()

                    '    'Cbo_title.Focus()
                    'Dim MEMMCODE As String
                    'MEMMCODE = txt_MemberCode.Text
                    'MessageBox.Show("INVALID MEMBER CODE", MEMMCODE)
                    'txt_MemberCode.Text = ""
                    'txt_MemberCode.Focus()
                    'Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
            ' CmdClear_Click(sender, e)
        End Try
    End Sub
    Public Sub LoadFoto_DB(ByVal quystr As String, ByVal PIC As PictureBox)
        Try
            Dim cn As New SqlConnection(strcn)
            Dim sssql As String
            'sssql = "SELECT * FROM SM_CARDFILE_HDR WHERE [16_DIGIT_CODE] ='" & Trim(CARDID.Text) & "' AND [16_DIGIT_CODE] NOT IN ( SELECT [16_DIGIT_CODE] FROM SM_CARDFILE_HDR WHERE [16_digit_code] = '" & Trim(CARDID.Text) & "' AND MEMIMAGE IS NULL)"
            Dim cmd As New SqlCommand(quystr, cn)
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "sm_image")
            Dim c As Integer = ds.Tables("SM_IMAGE").Rows.Count
            If c > 0 Then
                Dim bytMEMimage() As Byte = ds.Tables("SM_IMAGE").Rows(c - 1)("memimage")
                Dim stmMEMimage As New IO.MemoryStream(bytMEMimage)
                PIC.Image = Image.FromStream(stmMEMimage)
            Else
                PIC.Image = Nothing
            End If
        Catch ex As Exception
            '            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function check_Duplicate(ByVal Itemcode As String)
        Dim i As Integer
        Dim row As Integer
        Dim col As Integer
        row = DDGRD1.CurrentCellAddress.Y
        col = DDGRD1.CurrentCellAddress.X
        Dupchk = False
        col = 0
        For i = 0 To DDGRD1.Rows.Count - 1
            row = i
            If i <> DDGRD1.CurrentCell.RowIndex Then
                If Trim(DDGRD1.Rows(row).Cells(0).Value) = Trim(Itemcode) Then
                    MsgBox("MCODE is Already exists", MsgBoxStyle.Critical, "Duplicate")
                    Dupchk = True
                End If
            End If
        Next
    End Function
    Private Sub MemberCodeHelp()
        Dim I, J As Integer
        Dim row As Integer
        Dim col As Integer
        row = DDGRD1.CurrentCellAddress.Y
        Try
            Dim vform As New LIST_OPERATION1
            gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM membermaster"
            ' gSQLString1 = "ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME,ISNULL(CCELL,'') AS CONTACT,ISNULL(CEMAIL,'') AS EMAIL FROM membermaster WHERE MCODE='" & Trim(vform.keyfield) & "'"
            M_WhereCondition = " "
            vform.Field = "MCODE,MNAME"
            vform.vCaption = "Member Master Help"
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                gSQLString1 = "Select ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME from membermaster WHERE MCODE='" & Trim(vform.keyfield) & "'"
                ' gSQLString1 = "ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME,ISNULL(CCELL,'') AS CONTACT,ISNULL(CEMAIL,'') AS EMAIL FROM membermaster WHERE MCODE='" & Trim(vform.keyfield) & "'"
                Dim membermaster As New DataTable
                membermaster = gconnection.GetValues(gSQLString1)
                '  For I = 0 To membermaster.Rows.Count - 1
                For I = 0 To membermaster.Rows.Count - 1
                    DDGRD1.Rows(row).Cells(0).Value = membermaster.Rows(I).Item("MCODE")
                    DDGRD1.Rows(row).Cells(1).Value = membermaster.Rows(I).Item("MNAME")
                    'DDGRD1.Rows(row).Cells(2).Value = membermaster.Rows(I).Item("CCELL")
                    'DDGRD1.Rows(row).Cells(3).Value = membermaster.Rows(I).Item("CEMAIL")
                Next
                Call check_Duplicate(Trim(membermaster.Rows(0).Item("MCODE")))
                If Dupchk = True Then
                    col = 0
                    'row = DDGRD1.CurrentCell.RowIndex
                    DDGRD1.Rows(row).Cells(0).Value = ""
                    DDGRD1.Rows(row).Cells(1).Value = ""
                    DDGRD1.CurrentCell = DDGRD1(0, row)
                    DDGRD1.Focus()
                    Exit Sub
                End If
                If DDGRD1.Rows(row).Cells(J).Value <> Nothing Then
                    DDGRD1.AllowUserToAddRows = True
                    DDGRD1.Rows.Add(1)
                    DDGRD1.AllowUserToAddRows = False
                End If
                txt_MemberCode.Text = Trim(vform.keyfield & "")
                txt_membercode_valid()
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End Try
    End Sub
    Private Sub DDGRD1_KeyDown(sender As Object, e As KeyEventArgs) Handles DDGRD1.KeyDown
        Dim col As Integer
        Dim Row As Integer
        Try
            If e.KeyCode = Keys.F4 Then
                Call MemberCodeHelp()
            End If
            If e.KeyCode = Keys.F2 Then
                DDGRD1.Rows.Insert(DDGRD1.CurrentRow.Index, 1)
            End If
            If e.KeyCode = Keys.F3 Then
                ' DDGRD1.Rows.Clear()

                If DDGRD1.CurrentCell.RowIndex = 0 Then
                    If Not DDGRD1.CurrentRow.IsNewRow Then
                        DDGRD1.Rows.Remove(DDGRD1.CurrentRow)
                    End If
                    DDGRD1.Rows.Add()
                Else
                    If Not DDGRD1.CurrentRow.IsNewRow Then
                        DDGRD1.Rows.Remove(DDGRD1.CurrentRow)
                    End If
                End If
            End If
            If e.KeyCode = Keys.Enter Then
                With DDGRD1
                    If Trim(.CurrentCell.ColumnIndex) = 0 Then
                        If Trim(.CurrentCell.Value) = "" Then
                            Call MemberCodeHelp()
                        Else
                            MemberCodeHelp()
                        End If

                    ElseIf Trim(.CurrentCell.ColumnIndex) = 1 Then
                        If Trim(.CurrentCell.Value) = "" Then
                            Call MemberCodeHelp()
                        Else
                            txt_membercode_valid()
                        End If
                    End If
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function membermaster() As Object
        Throw New NotImplementedException
    End Function

    Private Function FpSpread1() As Object
        Throw New NotImplementedException
    End Function

    Private Function OperationModeRow() As FPSpreadADO.OperationModeConstants
        Throw New NotImplementedException
    End Function

    Private Function l_StrOutput() As Integer
        Throw New NotImplementedException
    End Function

    Private Sub cmd_SubCategoryCodeHelp_Click(sender As Object, e As EventArgs) Handles cmd_SubCategoryCodeHelp.Click
        Dim vform As New LIST_OPERATION1
        gSQLString = "SELECT DesignationCode ,Designation  FROM CommitteeMaster"
        M_WhereCondition = " "
        vform.Field = "DesignationCode,Designation"
        vform.vCaption = "CommitteeMaster Help "
        vform.TXT_SEARCH_TXT.Select()
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            Txt_subcategorycode.Text = Trim(vform.keyfield & "")
            txt_SubCategoryName.Text = Trim(vform.keyfield1 & "")
            Txt_subcategorycode.Select()
            Call txt_subcategorycodefill()
            vform.Close()
            vform = Nothing
            'btn_addnew.Text = "Update [F7]"
        End If
        gconnection.closeconnection()
    End Sub
    Private Sub txt_subcategorycodefill()
        Dim MEMBERTYPE As New DataTable
        Dim SUBCATEGORY As New DataTable
        Dim subsmast As New DataTable
        Dim CATEGORYDETAILS As New DataTable
        Dim SUBSCRIPTIONMASTER As New DataTable
        Dim C1 As New DataTable
        Dim ssql, SQL, SQL1 As String
        Dim i, j As Integer
        i = 0
        j = 0

        ssql = " SELECT DesignationCode ,Designation  FROM CommitteeTransaction Where DesignationCode='" & Me.Txt_subcategorycode.Text & "'"
        SUBCATEGORY = gconnection.GetValues(ssql)
        If SUBCATEGORY.Rows.Count > 0 Then
            Txt_subcategorycode.ReadOnly = True
            Me.Txt_subcategorycode.Text = SUBCATEGORY.Rows(0).Item("DesignationCode")
            Me.txt_SubCategoryName.Text = SUBCATEGORY.Rows(0).Item("Designation")
            ' Me.Cbo_ClubAccount.Text = SUBCATEGORY.Rows(0).Item("ClubAccount")
            Me.Txt_subcategorycode.Enabled = True
        End If
        gconnection.closeconnection()
        ssql = "select * from CommitteeTransaction  Where DesignationCode='" & Me.Txt_subcategorycode.Text & "' "
        subsmast = gconnection.GetValues(ssql)
        If subsmast.Rows.Count > 0 Then
            DDGRD1.Select()
            For i = 0 To subsmast.Rows.Count - 1
                DDGRD1.Rows.Insert(i, 1)
                DDGRD1.Item(0, i).Value() = subsmast.Rows(i).Item("mcode")
                DDGRD1.Item(1, i).Value() = subsmast.Rows(i).Item("mname")
            Next i
        End If
        datachk = False
        Dim MEMBERTYPE1 As New DataTable
        Dim MEMBERTYPE2 As New DataTable
        Dim STRQUERY As String
        STRQUERY = "select  distinct(DesignationCode) from CommitteeTransaction where  DesignationCode='" & Trim(Txt_subcategorycode.Text) & "' "
        MEMBERTYPE2 = gconnection.GetValues(STRQUERY)
        If MEMBERTYPE2.Rows.Count > 0 Then
            STRQUERY = "select  distinct(mcode) from CommitteeTransaction where  DesignationCode='" & Trim(Txt_subcategorycode.Text) & "'"
            MEMBERTYPE = gconnection.GetValues(STRQUERY)
            'STRQUERY = "select  distinct(MEMBERTYPECODE) from member_application_master where  MEMBERTYPECODE='" & Trim(Txt_subcategorycode.Text) & "'"
            'MEMBERTYPE1 = gconnection.GetValues(STRQUERY)
            If MEMBERTYPE.Rows.Count > 0 Or MEMBERTYPE2.Rows.Count > 0 Then
                datachk = True
            Else
                datachk = False
            End If
        Else
            datachk = False
        End If

        If datachk = True Then
            txt_SubCategoryName.ReadOnly = True
            '  MessageBox.Show("Sub Category is Already used in MEMBER Details So it cant be Change", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If gUserCategory <> "S" Then
            ' Call GetRights()
        Else
            txt_SubCategoryName.Select()
        End If
        'Call FillTypeMst()
    End Sub

    Private Function Cbo_ClubAccount() As Object
        Throw New NotImplementedException
    End Function

    Private Function Chk_subsyes() As Object
        Throw New NotImplementedException
    End Function

    Private Sub Cmd_View_Click(sender As Object, e As EventArgs) Handles Cmd_View.Click
        'If chk_photo.Checked = True Then
        If memimage = "isnull(memimage,'') as memimage" Then
        Else
            memimage = "''"
        End If
        ' Else
        'End If
        Dim txtobj1 As TextObject
        Dim Viewer As New REPORTVIEWER
        sqlstring = "select * from VW_CommitteeTransaction"
        If Txt_subcategorycode.Text = "" Then
            'sqlstring = sqlstring & ""
            sqlstring = sqlstring & " order by designationcode"
        Else
            'sqlstring = sqlstring & " WHERE DesignationCode ='" & Txt_subcategorycode.Text & "'  "
            sqlstring = sqlstring & " WHERE DesignationCode ='" & Txt_subcategorycode.Text & "' order by designationcode"
        End If
        Dim r As New Cry_Commitee
        gconnection.getDataSet(sqlstring, "VW_CommitteeTransaction")
        If gdataset.Tables("VW_CommitteeTransaction").Rows.Count > 0 Then
            Viewer.TableName = "VW_CommitteeTransaction"
            Call Viewer.GetDetails(sqlstring, "VW_CommitteeTransaction", r)
            txtobj1 = r.ReportDefinition.ReportObjects("Text1")
            txtobj1.Text = UCase(gcompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text2")
            txtobj1.Text = UCase(gCompanyAddress(0))
            txtobj1 = r.ReportDefinition.ReportObjects("Text3")
            txtobj1.Text = UCase(gCompanyAddress(1))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text4")
            'txtobj1.Text = UCase(gCompanyAddress(2))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text5")
            'txtobj1.Text = UCase(gCompanyAddress(3))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text21")
            'txtobj1.Text = UCase(gCompanyAddress(4))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text23")
            'txtobj1.Text = UCase(gCompanyAddress(5))
            txtobj1 = r.ReportDefinition.ReportObjects("Text19")
            txtobj1.Text = UCase(gFinancalyearStart)
            txtobj1 = r.ReportDefinition.ReportObjects("Text22")
            txtobj1.Text = UCase(gFinancialyearEnd)
            'txtobj1 = r.ReportDefinition.ReportObjects("Text27")
            'txtobj1.Text = UCase(gUsername)
            Viewer.Show()
        Else
            MsgBox(" NO RECORD AVAILABLE ! ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End If
    End Sub

    Private Sub Cmd_Clear1_Click(sender As Object, e As EventArgs) Handles Cmd_Clear1.Click
        txtYearName.Text = ""
        txtTypeCode.Text = ""
        txtTypeName.Text = ""
        Txt_subcategorycode.Text = ""
        txt_SubCategoryName.Text = ""
        DDGRD1.DataSource = Nothing
        DDGRD1.Rows.Clear()
        'txtLimit.Text = ""
        ssGrid.ClearRange(1, 1, -1, -1, True)
        Cmd_Add.Text = "Add [F7]"
        ssGrid.SetActiveCell(1, 1)
        txtYearName.ReadOnly = False
        txtTypeCode.ReadOnly = False
        txtTypeName.ReadOnly = False
        txtYearName.Focus()
        DDGRD1.Rows.Add()
    End Sub
    Private Sub CmdAdd1_Click(sender As Object, e As EventArgs) Handles CmdAdd1.Click
        'Dim totalamt, totalqty As Double
        Dim sqlstring As String
        Dim Insert(0) As String
        Dim MCODE, MNAME As String
        Dim i, j As Integer

        'Call checkValidation() '''--->Check Validation
        If boolchk = True Then Exit Sub
        If Cmd_Add.Text = "Add [F7]" Then
            sqlstring = "DELETE FROM CommitteeTransaction where  DesignationCode='" & Trim(Txt_subcategorycode.Text & "") & "' "
            gconnection.dataOperation(1, sqlstring, "CommitteeTransaction")
            For loopindex = 0 To DDGRD1.Rows.Count - 1
                MCODE = Nothing
                MNAME = Nothing
                Dim col As Integer
                Dim Row As Integer

                col = 0
                Row = loopindex
                MCODE = DDGRD1.Rows(Row).Cells(col).Value
                col = 1
                Row = loopindex
                MNAME = DDGRD1.Rows(Row).Cells(col).Value
                If IsNothing(DDGRD1.Rows(Row).Cells(col).Value) Then
                Else
                    'sqlstring = "INSERT INTO CommitteeTransaction(ID,DesignationCode ,Designation ,NoOfPost ,order_comm,Constant ,MCODE,MNAME,CCELL,CEMAIL,"
                    'sqlstring = sqlstring & "add_user,add_date,Fromdate,Todate)"
                    sqlstring = "Insert into CommitteeTransaction(DesignationCode,Designation,MCODE,MNAME,CCELL,CEMAIL,add_user,add_date,Fromdate,Todate)values('" & Trim(Txt_subcategorycode.Text & "") & "', '" & Trim(txt_SubCategoryName.Text & "") & "',"
                    ' sqlstring = sqlstring & " '" & Trim(MCODE & "") & "','" & gUsername & " ','" & Format(Date.Now, "dd-MMM-yyyy HH:mm") & "','N')"
                    sqlstring = sqlstring & " '" & Trim(MCODE & "") & "','" & Trim(MNAME & "") & "','','','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','" & Format(Frm_date.Value, "dd-MMM-yyyy hh:mm:ss") & "','" & Format(To_date.Value, "dd-MMM-yyyy hh:mm:ss") & "')"
                    gconnection.dataOperation(1, sqlstring, "CommitteeTransaction")
                End If
            Next loopindex
            'ReDim Preserve Insert(Insert.Length)
            'Insert(Insert.Length - 1) = sqlstring
            'gconnection.MoreTrans(Insert)
            MessageBox.Show("Record Add Successfully ", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Cmd_Clear_Click(sender, e)
            'Dim cfi As New CustomFilter(ssGrid .ActiveSheet)
            'Dim ccd As FarPoint.Win.Spread.FilterColumnDefinition = FpSpread1.ActiveSheet.RowFilter.GetFilterColumnDefinition(0)
            'ccd.Filters.Add(cfi)
            'FpSpread1.ActiveSheet.DefaultStyle.CellType = New FarPoint.Win.Spread.FilterColumnDefinition
            'FpSpread1.ActiveSheet.SetValue(0, 0, 10)
            'FpSpread1.ActiveSheet.SetValue(1, 0, 100)
            'FpSpread1.ActiveSheet.SetValue(2, 0, 50)
            'FpSpread1.ActiveSheet.SetValue(3, 0, 40)
            'FpSpread1.ActiveSheet.SetValue(4, 0, 80)
            'FpSpread1.ActiveSheet.SetValue(5, 0, 1)
            'FpSpread1.ActiveSheet.SetValue(6, 0, 65)
            'FpSpread1.ActiveSheet.SetValue(7, 0, 20)
            'FpSpread1.ActiveSheet.SetValue(8, 0, 30)
            'FpSpread1.ActiveSheet.SetValue(9, 0, 35)
            '  i = 1 + 1
            '    For i = 1 To ssGrid.DataRowCnt
            '        With ssGrid
            '            sqlstring = "INSERT INTO CommitteeTransaction(ID,DesignationCode ,Designation ,NoOfPost ,order_comm,Constant ,MCODE,MNAME,CCELL,CEMAIL"
            '            sqlstring = sqlstring & "add_user,add_date,Fromdate,Todate)"
            '             sqlstring = sqlstring & " VALUES('" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_FirstName.Text) & "','" & Replace(Trim(txtTypeName.Text), "'", "") & "',"
            '            sqlstring = sqlstring & " VALUES("
            '            .Row = i
            '            .Col = 1
            '            sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '            .Col = 2
            '            sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '            .Col = 3
            '            sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '            .Col = 4
            '            sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '            .Col = 5
            '            sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '            .Col = 6
            '            sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '             sqlstring = sqlstring & "'" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'," & Val(txtLimit.Text) & ")"
            '            sqlstring = sqlstring & "''" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_FirstName.Text) & "','" & Trim(txt_RA_Email.Text) & "','" & Trim(txt_RA_MobileNo.Text) & "','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','" & Format(Frm_date.Value, "dd-MMM-yyyy hh:mm:ss") & "','" & Format(To_date.Value, "dd-MMM-yyyy hh:mm:ss") & "')"
            '            ReDim Preserve Insert(Insert.Length)
            '            Insert(Insert.Length - 1) = sqlstring
            '        End With
            '    Next i
            '    gconnection.MoreTrans(Insert)
            '    Call Cmd_Clear_Click(sender, e)
            'Else
            '    sqlstring = "DELETE FROM CommitteeMaster "
            '    ReDim Preserve Insert(Insert.Length)
            '    Insert(Insert.Length - 1) = sqlstring
            '    For i = 1 To ssGrid.DataRowCnt
            '        With ssGrid
            '            sqlstring = "INSERT INTO CommitteeTransaction(ID,DesignationCode ,Designation ,NoOfPost ,order_comm,Constant ,MCODE,MNAME,CCELL,CEMAIL,"
            '            sqlstring = sqlstring & "add_user,add_date,Fromdate,Todate)"
            '             sqlstring = sqlstring & " VALUES('" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_FirstName.Text) & "','" & Replace(Trim(txtTypeName.Text), "'", "") & "',"
            '            sqlstring = sqlstring & " VALUES("
            '            .Row = i
            '            .Col = 1
            '            sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '            .Col = 2
            '            sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '            .Col = 3
            '            sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '            .Col = 4
            '            sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '            .Col = 5
            '            sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '            .Col = 6
            '            sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '             sqlstring = sqlstring & "'" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'," & Val(txtLimit.Text) & ")"
            '            sqlstring = sqlstring & "'" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_FirstName.Text) & "','" & Trim(txt_RA_Email.Text) & "','" & Trim(txt_RA_MobileNo.Text) & "','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','" & Format(Frm_date.Value, "dd-MMM-yyyy hh:mm:ss") & "','" & Format(To_date.Value, "dd-MMM-yyyy hh:mm:ss") & "')"
            '            ReDim Preserve Insert(Insert.Length)
            '            Insert(Insert.Length - 1) = sqlstring
            '        End With
            '    Next i
            '    gconnection.MoreTrans(Insert)
            '    Call Cmd_Clear_Click(sender, e)
            '   Else

            'Dim cfi As New CustomFilter(FpSpread1.ActiveSheet)
            'Dim ccd As FarPoint.Win.Spread.FilterColumnDefinition = FpSpread1.ActiveSheet.RowFilter.GetFilterColumnDefinition(0)
            'ccd.Filters.Add(cfi)
            'FpSpread1.ActiveSheet.DefaultStyle.CellType = New FarPoint.Win.Spread.FilterColumnDefinition
            'FpSpread1.ActiveSheet.SetValue(0, 0, 10)
            'FpSpread1.ActiveSheet.SetValue(1, 0, 100)
            'FpSpread1.ActiveSheet.SetValue(2, 0, 50)
            'FpSpread1.ActiveSheet.SetValue(3, 0, 40)
            'FpSpread1.ActiveSheet.SetValue(4, 0, 80)
            'FpSpread1.ActiveSheet.SetValue(5, 0, 1)
            'FpSpread1.ActiveSheet.SetValue(6, 0, 65)
            'FpSpread1.ActiveSheet.SetValue(7, 0, 20)
            'FpSpread1.ActiveSheet.SetValue(8, 0, 30)
            'FpSpread1.ActiveSheet.SetValue(9, 0, 35)

            ' If ssGrid.Row = 1 Then

            'With ssGrid
            '    .Row = .ActiveRow
            '    ' .ClearRange(1, .ActiveRow, 11, .ActiveRow, True)
            '    '.SetActiveCell(.ActiveRow, 1)
            '    ' Call Calculate()
            '    .SetActiveCell(1, ssGrid.ActiveRow)
            '    .Focus()
            'End With


            '    With ssGrid
            '        'sqlstring = sqlstring & "'" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_FirstName.Text) & "','" & Trim(txt_RA_Email.Text) & "','" & Trim(txt_RA_MobileNo.Text) & "','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','" & Format(Frm_date.Value, "dd-MMM-yyyy hh:mm:ss") & "','" & Format(To_date.Value, "dd-MMM-yyyy hh:mm:ss") & "')"
            '        For loopindex = 0 To DDGRD1.Rows.Count - 1
            '            MCODE = Nothing
            '            MNAME = Nothing
            '            Dim col As Integer
            '            Dim Row As Integer
            '            col = 0
            '            Row = loopindex
            '            MCODE = DDGRD1.Rows(Row).Cells(col).Value
            '            col = 1
            '            Row = loopindex
            '            MNAME = DDGRD1.Rows(Row).Cells(col).Value
            '            If IsNothing(DDGRD1.Rows(Row).Cells(col).Value) Then
            '            Else
            '                'If ssGrid.ActiveCol = 7 Then
            '                ssGrid.Col = ssGrid.ActiveCol
            '                i = ssGrid.ActiveRow
            '                ssGrid.Row = i
            '                'ssGrid.Lock = False
            '                .Row = .ActiveRow
            '                .SetActiveCell(1, ssGrid.ActiveRow)

            '                'i = .Row
            '                .Focus()
            '                For i = .Row To ssGrid.DataRowCnt
            '                    ' For i = 1 To 1
            '                    sqlstring = "INSERT INTO CommitteeTransaction(ID,DesignationCode ,Designation ,NoOfPost ,order_comm,Constant ,MCODE,MNAME,CCELL,CEMAIL,"
            '                    sqlstring = sqlstring & "add_user,add_date,Fromdate,Todate)"
            '                    sqlstring = sqlstring & " VALUES("
            '                    .Row = i
            '                    .Col = 1
            '                    sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '                    .Col = 2
            '                    sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '                    .Col = 3
            '                    sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '                    .Col = 4
            '                    sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '                    .Col = 5
            '                    sqlstring = sqlstring & "'" & Trim(.Text) & "',"
            '                    .Col = 6
            '                    sqlstring = sqlstring & "'" & Trim(.Text) & "',"

            '                    ' sqlstring = sqlstring & "'" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'," & Val(txtLimit.Text) & ")"
            '                    'sqlstring = sqlstring & "'" & Trim(txt_MemberCode.Text) & "','" & Trim(txt_FirstName.Text) & "','" & Trim(txt_RA_Email.Text) & "','" & Trim(txt_RA_MobileNo.Text) & "','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','" & Format(Frm_date.Value, "dd-MMM-yyyy hh:mm:ss") & "','" & Format(To_date.Value, "dd-MMM-yyyy hh:mm:ss") & "')"
            '                    ' sqlstring = sqlstring & " '" & Trim(MCODE & "") & "','" & Trim(MCODE & "") & "','" & Trim(txt_RA_Email.Text) & "','" & Trim(gUsername) & "','" & Format(Frm_date.Value, "dd-MMM-yyyy hh:mm:ss") & "','" & Format(To_date.Value, "dd-MMM-yyyy hh:mm:ss") & "')"
            '                    sqlstring = sqlstring & " '" & Trim(MCODE & "") & "','" & Trim(MNAME & "") & "','','','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','" & Format(Frm_date.Value, "dd-MMM-yyyy hh:mm:ss") & "','" & Format(To_date.Value, "dd-MMM-yyyy hh:mm:ss") & "')"
            '                    ReDim Preserve Insert(Insert.Length)
            '                    Insert(Insert.Length - 1) = sqlstring
            '                    'ssGrid.AllowRowMove = False
            '                    'ssGrid.ClearRange(1, 1, -1, -1, True)
            '                    '.Row = .ActiveRow
            '                    '.SetActiveCell(1, ssGrid.ActiveRow)
            '                    ''i = .Row
            '                    '.Focus()
            '                Next
            '            End If
            '            ' End If
            '        Next loopindex
            '    End With
            '    gconnection.MoreTrans(Insert)
            '    Call Cmd_Clear_Click(sender, e)
            '    ' End If
            '    'If ssGrid.Row = 2 Then

            '    'End If
            '    Call Cmd_Clear_Click(sender, e)
            'End If

        Else
            sqlstring = "DELETE FROM CommitteeTransaction where  DesignationCode='" & Trim(Txt_subcategorycode.Text & "") & "' "
            gconnection.dataOperation(1, sqlstring, "CommitteeTransaction")
            For loopindex = 0 To DDGRD1.Rows.Count - 1
                MCODE = Nothing
                MNAME = Nothing
                Dim col As Integer
                Dim Row As Integer

                col = 0
                Row = loopindex
                MCODE = DDGRD1.Rows(Row).Cells(col).Value
                col = 1
                Row = loopindex
                MNAME = DDGRD1.Rows(Row).Cells(col).Value
                If IsNothing(DDGRD1.Rows(Row).Cells(col).Value) Then
                Else
                    'sqlstring = "INSERT INTO CommitteeTransaction(ID,DesignationCode ,Designation ,NoOfPost ,order_comm,Constant ,MCODE,MNAME,CCELL,CEMAIL,"
                    'sqlstring = sqlstring & "add_user,add_date,Fromdate,Todate)"
                    sqlstring = "Insert into CommitteeTransaction(DesignationCode,Designation,MCODE,MNAME,CCELL,CEMAIL,add_user,add_date,Fromdate,Todate)values('" & Trim(Txt_subcategorycode.Text & "") & "', '" & Trim(txt_SubCategoryName.Text & "") & "',"
                    ' sqlstring = sqlstring & " '" & Trim(MCODE & "") & "','" & gUsername & " ','" & Format(Date.Now, "dd-MMM-yyyy HH:mm") & "','N')"
                    sqlstring = sqlstring & " '" & Trim(MCODE & "") & "','" & Trim(MNAME & "") & "','','','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','" & Format(Frm_date.Value, "dd-MMM-yyyy hh:mm:ss") & "','" & Format(To_date.Value, "dd-MMM-yyyy hh:mm:ss") & "')"
                    gconnection.dataOperation(1, sqlstring, "CommitteeTransaction")
                End If
            Next loopindex
            'ReDim Preserve Insert(Insert.Length)
            'Insert(Insert.Length - 1) = sqlstring
            'gconnection.MoreTrans(Insert)
            MessageBox.Show("Record Add Successfully ", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call Cmd_Clear_Click(sender, e)
        End If



        'For i = 1 To ssGrid.DataRowCnt
        '    With ssGrid
        '        sqlstring = "INSERT INTO CommitteeMaster(ID,DesignationCode ,Designation ,NoOfPost ,order_comm,Constant ,"
        '        sqlstring = sqlstring & "add_user,add_date)"
        '        'sqlstring = sqlstring & " VALUES('" & Trim(txtYearName.Text) & "','" & Trim(txtTypeCode.Text) & "','" & Replace(Trim(txtTypeName.Text), "'", "") & "',"
        '        sqlstring = sqlstring & " VALUES("
        '        .Row = i
        '        .Col = 1
        '        sqlstring = sqlstring & "'" & Trim(.Text) & "',"
        '        .Col = 2
        '        sqlstring = sqlstring & "'" & Trim(.Text) & "',"
        '        .Col = 3
        '        sqlstring = sqlstring & "'" & Trim(.Text) & "',"
        '        .Col = 4
        '        sqlstring = sqlstring & "'" & Trim(.Text) & "',"
        '        .Col = 5
        '        sqlstring = sqlstring & "'" & Trim(.Text) & "',"
        '        .Col = 6
        '        sqlstring = sqlstring & "'" & Trim(.Text) & "',"
        '        ' sqlstring = sqlstring & "'" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'," & Val(txtLimit.Text) & ")"
        '        sqlstring = sqlstring & "'" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
        '        ReDim Preserve Insert(Insert.Length)
        '        Insert(Insert.Length - 1) = sqlstring
        '    End With
        'Next i

        ' sqlstring = " Update membermaster set MEMIMAGE=@memimage Where Mcode='" & txt_MemberCode.Text & "' "
        'Call SaveFoto(strPhotoFilePath, Trim(txt_MemberCode.Text.Replace("'", "")), sqlstring)
    End Sub

    Private Sub CmdView1_Click(sender As Object, e As EventArgs) Handles CmdView1.Click
        'If chk_photo.Checked = True Then
        If memimage = "isnull(memimage,'') as memimage" Then
        Else
            memimage = "''"
        End If
        ' Else
        'End If
        Dim txtobj1 As TextObject
        Dim Viewer As New REPORTVIEWER
        sqlstring = "select * from VW_CommitteeTransaction"
        If Txt_subcategorycode.Text = "" Then
            'sqlstring = sqlstring & ""
            sqlstring = sqlstring & " order by designationcode"
        Else
            'sqlstring = sqlstring & " WHERE DesignationCode ='" & Txt_subcategorycode.Text & "'  "
            sqlstring = sqlstring & " WHERE DesignationCode ='" & Txt_subcategorycode.Text & "' order by designationcode"
        End If
        Dim r As New Cry_Commitee
        gconnection.getDataSet(sqlstring, "VW_CommitteeTransaction")
        If gdataset.Tables("VW_CommitteeTransaction").Rows.Count > 0 Then
            Viewer.TableName = "VW_CommitteeTransaction"
            Call Viewer.GetDetails(sqlstring, "VW_CommitteeTransaction", r)
            txtobj1 = r.ReportDefinition.ReportObjects("Text1")
            txtobj1.Text = UCase(gcompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text2")
            txtobj1.Text = UCase(gCompanyAddress(0))
            txtobj1 = r.ReportDefinition.ReportObjects("Text3")
            txtobj1.Text = UCase(gCompanyAddress(1))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text4")
            'txtobj1.Text = UCase(gCompanyAddress(2))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text5")
            'txtobj1.Text = UCase(gCompanyAddress(3))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text21")
            'txtobj1.Text = UCase(gCompanyAddress(4))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text23")
            'txtobj1.Text = UCase(gCompanyAddress(5))
            txtobj1 = r.ReportDefinition.ReportObjects("Text19")
            txtobj1.Text = UCase(gFinancalyearStart)
            txtobj1 = r.ReportDefinition.ReportObjects("Text22")
            txtobj1.Text = UCase(gFinancialyearEnd)
            'txtobj1 = r.ReportDefinition.ReportObjects("Text27")
            'txtobj1.Text = UCase(gUsername)
            Viewer.Show()
        Else
            MsgBox(" NO RECORD AVAILABLE ! ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End If
    End Sub

    Private Sub CmdExit1_Click(sender As Object, e As EventArgs) Handles CmdExit1.Click
        Me.Close()
    End Sub
End Class
