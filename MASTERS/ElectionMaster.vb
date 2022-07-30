Imports System.Data.SqlClient
Public Class ElectionMaster
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Browse As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdAdd As System.Windows.Forms.Button
    Friend WithEvents Cmd_freeze As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLimit As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ElectionMaster))
        Me.ssGrid = New AxFPSpreadADO.AxfpSpread()
        Me.frmbut = New System.Windows.Forms.GroupBox()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLimit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Browse = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CmdClear = New System.Windows.Forms.Button()
        Me.CmdAdd = New System.Windows.Forms.Button()
        Me.Cmd_freeze = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmbut.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ssGrid
        '
        Me.ssGrid.DataSource = Nothing
        Me.ssGrid.Location = New System.Drawing.Point(192, 146)
        Me.ssGrid.Name = "ssGrid"
        Me.ssGrid.OcxState = CType(resources.GetObject("ssGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssGrid.Size = New System.Drawing.Size(602, 200)
        Me.ssGrid.TabIndex = 10
        '
        'frmbut
        '
        Me.frmbut.BackColor = System.Drawing.Color.Transparent
        Me.frmbut.Controls.Add(Me.Cmd_Clear)
        Me.frmbut.Controls.Add(Me.Cmd_View)
        Me.frmbut.Controls.Add(Me.Cmd_Delete)
        Me.frmbut.Controls.Add(Me.Cmd_Add)
        Me.frmbut.Controls.Add(Me.Cmd_Exit)
        Me.frmbut.Location = New System.Drawing.Point(238, 474)
        Me.frmbut.Name = "frmbut"
        Me.frmbut.Size = New System.Drawing.Size(592, 56)
        Me.frmbut.TabIndex = 37
        Me.frmbut.TabStop = False
        Me.frmbut.Visible = False
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.Location = New System.Drawing.Point(18, 12)
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
        Me.Cmd_View.Location = New System.Drawing.Point(362, 12)
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
        Me.Cmd_Delete.Location = New System.Drawing.Point(250, 12)
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
        Me.Cmd_Add.Location = New System.Drawing.Point(130, 12)
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
        Me.Cmd_Exit.Location = New System.Drawing.Point(474, 12)
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
        Me.GroupBox1.Location = New System.Drawing.Point(196, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 13)
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(194, 420)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 20)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "LIMIT VOTE :"
        Me.Label3.Visible = False
        '
        'txtLimit
        '
        Me.txtLimit.BackColor = System.Drawing.Color.Wheat
        Me.txtLimit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLimit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimit.Location = New System.Drawing.Point(314, 419)
        Me.txtLimit.MaxLength = 2
        Me.txtLimit.Name = "txtLimit"
        Me.txtLimit.Size = New System.Drawing.Size(104, 26)
        Me.txtLimit.TabIndex = 40
        Me.txtLimit.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(183, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(277, 25)
        Me.Label4.TabIndex = 891
        Me.Label4.Text = "Committee Designation Master "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Location = New System.Drawing.Point(181, 130)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(635, 238)
        Me.GroupBox2.TabIndex = 892
        Me.GroupBox2.TabStop = False
        '
        'Browse
        '
        Me.Browse.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Browse.Location = New System.Drawing.Point(6, 244)
        Me.Browse.Name = "Browse"
        Me.Browse.Size = New System.Drawing.Size(137, 50)
        Me.Browse.TabIndex = 898
        Me.Browse.Text = "Browse"
        Me.Browse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Browse.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(6, 300)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 50)
        Me.Button1.TabIndex = 897
        Me.Button1.Text = "Exit[F11]"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CmdClear
        '
        Me.CmdClear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdClear.Location = New System.Drawing.Point(6, 19)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(137, 50)
        Me.CmdClear.TabIndex = 893
        Me.CmdClear.Text = "Clear[F6]"
        Me.CmdClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdClear.UseVisualStyleBackColor = True
        '
        'CmdAdd
        '
        Me.CmdAdd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAdd.Image = CType(resources.GetObject("CmdAdd.Image"), System.Drawing.Image)
        Me.CmdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdAdd.Location = New System.Drawing.Point(6, 75)
        Me.CmdAdd.Name = "CmdAdd"
        Me.CmdAdd.Size = New System.Drawing.Size(137, 50)
        Me.CmdAdd.TabIndex = 894
        Me.CmdAdd.Text = "Add[F7]"
        Me.CmdAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdAdd.UseVisualStyleBackColor = True
        '
        'Cmd_freeze
        '
        Me.Cmd_freeze.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_freeze.Image = CType(resources.GetObject("Cmd_freeze.Image"), System.Drawing.Image)
        Me.Cmd_freeze.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_freeze.Location = New System.Drawing.Point(6, 131)
        Me.Cmd_freeze.Name = "Cmd_freeze"
        Me.Cmd_freeze.Size = New System.Drawing.Size(137, 50)
        Me.Cmd_freeze.TabIndex = 895
        Me.Cmd_freeze.Text = "Void[F8]"
        Me.Cmd_freeze.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_freeze.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(6, 188)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(137, 50)
        Me.Button4.TabIndex = 896
        Me.Button4.Text = "View[F9]"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.CmdClear)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Browse)
        Me.GroupBox3.Controls.Add(Me.CmdAdd)
        Me.GroupBox3.Controls.Add(Me.Cmd_freeze)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Location = New System.Drawing.Point(854, 130)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(154, 369)
        Me.GroupBox3.TabIndex = 899
        Me.GroupBox3.TabStop = False
        '
        'ElectionMaster
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources._111in1024res
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ssGrid)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLimit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.frmbut)
        Me.DoubleBuffered = True
        Me.Name = "ElectionMaster"
        Me.Text = "ElectionMaster"
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmbut.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim i As Integer
    Dim boolchk As Boolean
    Dim sqlstring, StrString As String
    Dim gconnection As New GlobalClass
    Dim vsearch, vitem, accountcode As String
    Private Sub ElectionMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Call Resize_Form()

        Dim J, K As Integer
        i = 0
        ' If Trim(txtYearName.Text) <> "" And Trim(txtTypeCode.Text) <> "" Then
        Try
            'sqlstring = "SELECT ID,DesignationCode ,Designation ,NoOfPost ,Constant ,order_comm FROM CommitteeMaster
            sqlstring = "SELECT ID,DesignationCode ,Designation FROM CommitteeMaster"
            'sqlstring = sqlstring & " ISNULL(C_NAME,'') AS C_NAME,ISNULL(LIMIT,0) AS LIMIT FROM ELECTIONMASTER WHERE ISNULL(YEARNAME,'')  ='" & Val(txtYearName.Text) & "' AND ISNULL(EL_CODE,'') = '" & Trim(txtTypeCode.Text) & "'"
            gconnection.getDataSet(sqlstring, "COMMASTER")
            If gdataset.Tables("COMMASTER").Rows.Count > 0 Then
                Me.CmdAdd.Text = "Update[F7]"
                For J = 0 To gdataset.Tables("COMMASTER").Rows.Count - 1
                    ssGrid.SetText(1, J + 1, Trim(gdataset.Tables("COMMASTER").Rows(J).Item("ID")))
                    ssGrid.SetText(2, J + 1, Trim(gdataset.Tables("COMMASTER").Rows(J).Item("DesignationCode")))
                    ssGrid.SetText(3, J + 1, Trim(gdataset.Tables("COMMASTER").Rows(J).Item("Designation")))
                    'ssGrid.SetText(4, J + 1, Trim(gdataset.Tables("COMMASTER").Rows(J).Item("NoOfPost")))
                    'ssGrid.SetText(6, J + 1, Trim(gdataset.Tables("COMMASTER").Rows(J).Item("Constant")))
                    'ssGrid.SetText(5, J + 1, Trim(gdataset.Tables("COMMASTER").Rows(J).Item("order_comm")))
                Next J
                '  Me.Cmd_Add.Text = "Update[F7]"
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
                        If Controls(i_i).Name = "CmdClear" Or Controls(i_i).Name = "CmdAdd" Or Controls(i_i).Name = "Cmd_freeze" Or Controls(i_i).Name = "Button4" Or Controls(i_i).Name = "Browse" Or Controls(i_i).Name = "Button1" Then
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


    'Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
    '    'Dim totalamt, totalqty As Double
    '    Dim sqlstring As String
    '    Dim Insert(0) As String
    '    Dim i As Integer
    '    ' Call checkValidation() '''--->Check Validation
    '    If boolchk = True Then Exit Sub
    '    If Cmd_Add.Text = "Add [F7]" Then
    '        For i = 1 To ssGrid.DataRowCnt
    '            With ssGrid
    '                ' sqlstring = "INSERT INTO CommitteeMaster(ID,DesignationCode ,Designation ,NoOfPost ,order_comm,Constant ,"
    '                sqlstring = "INSERT INTO CommitteeMaster(ID,DesignationCode ,Designation,"
    '                sqlstring = sqlstring & "add_user,add_date)"
    '                'sqlstring = sqlstring & " VALUES('" & Trim(txtYearName.Text) & "','" & Trim(txtTypeCode.Text) & "','" & Replace(Trim(txtTypeName.Text), "'", "") & "',"
    '                sqlstring = sqlstring & " VALUES("
    '                .Row = i
    '                .Col = 1
    '                sqlstring = sqlstring & "'" & Trim(.Text) & "',"
    '                .Col = 2
    '                sqlstring = sqlstring & "'" & Trim(.Text) & "',"
    '                .Col = 3
    '                sqlstring = sqlstring & "'" & Trim(.Text) & "',"
    '                '.Col = 4
    '                'sqlstring = sqlstring & "'" & Trim(.Text) & "',"
    '                '.Col = 5
    '                'sqlstring = sqlstring & "'" & Trim(.Text) & "',"
    '                '.Col = 6
    '                'sqlstring = sqlstring & "'" & Trim(.Text) & "',"
    '                ' sqlstring = sqlstring & "'" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'," & Val(txtLimit.Text) & ")"
    '                sqlstring = sqlstring & "'" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
    '                ReDim Preserve Insert(Insert.Length)
    '                Insert(Insert.Length - 1) = sqlstring
    '            End With
    '        Next i
    '        gconnection.MoreTrans(Insert)
    '        Call Cmd_Clear_Click(sender, e)
    '    Else
    '        sqlstring = "DELETE FROM CommitteeMaster "
    '        ReDim Preserve Insert(Insert.Length)
    '        Insert(Insert.Length - 1) = sqlstring
    '        For i = 1 To ssGrid.DataRowCnt
    '            With ssGrid
    '                ' sqlstring = "INSERT INTO CommitteeMaster(ID,DesignationCode ,Designation ,NoOfPost ,order_comm,Constant ,"
    '                sqlstring = "INSERT INTO CommitteeMaster(ID,DesignationCode ,Designation,"
    '                sqlstring = sqlstring & "add_user,add_date)"
    '                'sqlstring = sqlstring & " VALUES('" & Trim(txtYearName.Text) & "','" & Trim(txtTypeCode.Text) & "','" & Replace(Trim(txtTypeName.Text), "'", "") & "',"
    '                sqlstring = sqlstring & " VALUES("
    '                .Row = i
    '                .Col = 1
    '                sqlstring = sqlstring & "'" & Trim(.Text) & "',"
    '                .Col = 2
    '                sqlstring = sqlstring & "'" & Trim(.Text) & "',"
    '                .Col = 3
    '                sqlstring = sqlstring & "'" & Trim(.Text) & "',"
    '                '.Col = 4
    '                'sqlstring = sqlstring & "'" & Trim(.Text) & "',"
    '                '.Col = 5
    '                'sqlstring = sqlstring & "'" & Trim(.Text) & "',"
    '                '.Col = 6
    '                'sqlstring = sqlstring & "'" & Trim(.Text) & "',"
    '                ' sqlstring = sqlstring & "'" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'," & Val(txtLimit.Text) & ")"
    '                sqlstring = sqlstring & "'" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
    '                ReDim Preserve Insert(Insert.Length)
    '                Insert(Insert.Length - 1) = sqlstring
    '            End With
    '        Next i
    '        gconnection.MoreTrans(Insert)
    '        Call Cmd_Clear_Click(sender, e)
    '    End If
    'End Sub
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
                MessageBox.Show("ID Code can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                ssGrid.SetActiveCell(1, ssGrid.ActiveRow)
                ssGrid.Focus()
                Exit Sub
            End If
            ssGrid.Col = 2
            If Trim(ssGrid.Text) = "" Then
                MessageBox.Show("Designation Name can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                ssGrid.SetActiveCell(2, ssGrid.ActiveRow)
                ssGrid.Focus()
                Exit Sub
            End If
            ssGrid.Col = 3
            If Trim(ssGrid.Text) = "" Then
                MessageBox.Show("Desiganation Code can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
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
        txtLimit.Text = ""
        ssGrid.ClearRange(1, 1, -1, -1, True)
        Cmd_Add.Text = "Add [F7]"
        ssGrid.SetActiveCell(1, 1)
        txtYearName.ReadOnly = False
        txtTypeCode.ReadOnly = False
        txtTypeName.ReadOnly = False
        txtYearName.Focus()
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
        Call txtTypeCode_Validated(txtTypeCode, e)
        '    End If
        '    vform.Close()
        '    vform = Nothing
    End Sub

    Private Sub txtTypeCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTypeCode.Validated
        Dim J, K As Integer
        i = 0
        If Trim(txtYearName.Text) <> "" And Trim(txtTypeCode.Text) <> "" Then
            Try
                sqlstring = "SELECT ISNULL(YEARNAME,'') AS YEARNAME,ISNULL(EL_CODE,'') AS EL_CODE,ISNULL(EL_NAME,'') AS EL_NAME,ISNULL(C_CODE,'') AS C_CODE,"
                sqlstring = sqlstring & " ISNULL(C_NAME,'') AS C_NAME,ISNULL(LIMIT,0) AS LIMIT FROM ELECTIONMASTER WHERE ISNULL(YEARNAME,'')  ='" & Val(txtYearName.Text) & "' AND ISNULL(EL_CODE,'') = '" & Trim(txtTypeCode.Text) & "'"
                gconnection.getDataSet(sqlstring, "ELMASTER")
                If gdataset.Tables("ELMASTER").Rows.Count > 0 Then
                    txtTypeCode.Text = Trim(gdataset.Tables("ELMASTER").Rows(0).Item("EL_CODE"))
                    txtTypeName.Text = Trim(gdataset.Tables("ELMASTER").Rows(0).Item("EL_NAME"))
                    txtLimit.Text = Val(gdataset.Tables("ELMASTER").Rows(0).Item("LIMIT"))
                    For J = 0 To gdataset.Tables("ELMASTER").Rows.Count - 1
                        ssGrid.SetText(1, J + 1, Trim(gdataset.Tables("ELMASTER").Rows(J).Item("C_CODE")))
                        ssGrid.SetText(2, J + 1, Trim(gdataset.Tables("ELMASTER").Rows(J).Item("C_NAME")))
                    Next J
                    Me.Cmd_Add.Text = "Update[F7]"
                    txtYearName.ReadOnly = True
                    txtTypeCode.ReadOnly = True
                    'txtTypeName.ReadOnly = True
                    Me.Cmd_Add.Text = "Update[F7]"
                Else
                    txtTypeName.Focus()
                End If
            Catch ex As Exception
                MessageBox.Show("Enter a valid TYPE CODE ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        Else

        End If
    End Sub
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
                txtTypeCode_Validated(txtTypeCode, e)
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

    Private Sub txtLimit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLimit.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            Cmd_Add.Focus()
        End If
    End Sub

    Private Sub CmdClear_Click(sender As Object, e As EventArgs) Handles CmdClear.Click
        txtYearName.Text = ""
        txtTypeCode.Text = ""
        txtTypeName.Text = ""
        txtLimit.Text = ""
        ssGrid.ClearRange(1, 1, -1, -1, True)
        CmdAdd.Text = "Add [F7]"
        ssGrid.SetActiveCell(1, 1)
        txtYearName.ReadOnly = False
        txtTypeCode.ReadOnly = False
        txtTypeName.ReadOnly = False
        txtYearName.Focus()
    End Sub

    Private Sub CmdAdd_Click(sender As Object, e As EventArgs) Handles CmdAdd.Click
        'Dim totalamt, totalqty As Double
        Dim sqlstring As String
        Dim Insert(0) As String
        Dim i As Integer
        ' Call checkValidation() '''--->Check Validation
        If boolchk = True Then Exit Sub
        If CmdAdd.Text = "Add [F7]" Then
            For i = 1 To ssGrid.DataRowCnt
                With ssGrid
                    ' sqlstring = "INSERT INTO CommitteeMaster(ID,DesignationCode ,Designation ,NoOfPost ,order_comm,Constant ,"
                    sqlstring = "INSERT INTO CommitteeMaster(ID,DesignationCode ,Designation,"
                    sqlstring = sqlstring & "add_user,add_date)"
                    'sqlstring = sqlstring & " VALUES('" & Trim(txtYearName.Text) & "','" & Trim(txtTypeCode.Text) & "','" & Replace(Trim(txtTypeName.Text), "'", "") & "',"
                    sqlstring = sqlstring & " VALUES("
                    .Row = i
                    .Col = 1
                    sqlstring = sqlstring & "'" & Trim(.Text) & "',"
                    .Col = 2
                    sqlstring = sqlstring & "'" & Trim(.Text) & "',"
                    .Col = 3
                    sqlstring = sqlstring & "'" & Trim(.Text) & "',"
                    '.Col = 4
                    'sqlstring = sqlstring & "'" & Trim(.Text) & "',"
                    '.Col = 5
                    'sqlstring = sqlstring & "'" & Trim(.Text) & "',"
                    '.Col = 6
                    'sqlstring = sqlstring & "'" & Trim(.Text) & "',"
                    ' sqlstring = sqlstring & "'" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'," & Val(txtLimit.Text) & ")"
                    sqlstring = sqlstring & "'" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = sqlstring
                End With
            Next i
            gconnection.MoreTrans(Insert)
            Call Cmd_Clear_Click(sender, e)
        Else
            sqlstring = "DELETE FROM CommitteeMaster "
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = sqlstring
            For i = 1 To ssGrid.DataRowCnt
                With ssGrid
                    ' sqlstring = "INSERT INTO CommitteeMaster(ID,DesignationCode ,Designation ,NoOfPost ,order_comm,Constant ,"
                    sqlstring = "INSERT INTO CommitteeMaster(ID,DesignationCode ,Designation,"
                    sqlstring = sqlstring & "add_user,add_date)"
                    'sqlstring = sqlstring & " VALUES('" & Trim(txtYearName.Text) & "','" & Trim(txtTypeCode.Text) & "','" & Replace(Trim(txtTypeName.Text), "'", "") & "',"
                    sqlstring = sqlstring & " VALUES("
                    .Row = i
                    .Col = 1
                    sqlstring = sqlstring & "'" & Trim(.Text) & "',"
                    .Col = 2
                    sqlstring = sqlstring & "'" & Trim(.Text) & "',"
                    .Col = 3
                    sqlstring = sqlstring & "'" & Trim(.Text) & "',"
                    '.Col = 4
                    'sqlstring = sqlstring & "'" & Trim(.Text) & "',"
                    '.Col = 5
                    'sqlstring = sqlstring & "'" & Trim(.Text) & "',"
                    '.Col = 6
                    'sqlstring = sqlstring & "'" & Trim(.Text) & "',"
                    ' sqlstring = sqlstring & "'" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'," & Val(txtLimit.Text) & ")"
                    sqlstring = sqlstring & "'" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = sqlstring
                End With
            Next i
            gconnection.MoreTrans(Insert)
            'Call Cmd_Clear_Click(sender, e)
        End If
    End Sub

    Private Sub Cmd_freeze_Click(sender As Object, e As EventArgs) Handles Cmd_freeze.Click
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
