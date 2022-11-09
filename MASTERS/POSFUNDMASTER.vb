Public Class POSFUNDMASTER
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Heading As System.Windows.Forms.Label
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents lbl_PENALTY As System.Windows.Forms.Label
    Friend WithEvents TXTPENALTY As System.Windows.Forms.TextBox
    Friend WithEvents TXTPENALTYACCODE As System.Windows.Forms.TextBox
    Friend WithEvents TXTPENALTYACDESC As System.Windows.Forms.TextBox
    Friend WithEvents CMDPENALTYACCODE As System.Windows.Forms.Button
    Friend WithEvents TXTSWFACDESC As System.Windows.Forms.TextBox
    Friend WithEvents CMDSWFACCODE As System.Windows.Forms.Button
    Friend WithEvents LBL_SWF As System.Windows.Forms.Label
    Friend WithEvents TXTSWFACCODE As System.Windows.Forms.TextBox
    Friend WithEvents TXTSWFUND As System.Windows.Forms.TextBox
    Friend WithEvents lbl_PYMTdate As System.Windows.Forms.Label
    Friend WithEvents dtp_PYMTdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LBL_DUEDATE As System.Windows.Forms.Label
    Friend WithEvents Dtp_DueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_minbal As System.Windows.Forms.Label
    Friend WithEvents TXT_PMMINBAL As System.Windows.Forms.TextBox
    Friend WithEvents LBL_POSTEDLIST As System.Windows.Forms.Label
    Friend WithEvents Lbl_CRBAL As System.Windows.Forms.Label
    Friend WithEvents lbl_ceased As System.Windows.Forms.Label
    Friend WithEvents TXT_CMCRBAL As System.Windows.Forms.TextBox
    Friend WithEvents TXT_pOSTEDLIST As System.Windows.Forms.TextBox
    Friend WithEvents TXT_CEASED As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTP_BILLTO As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTP_BILLFROM As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DTP_INTDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents inst_post As System.Windows.Forms.Button
    Friend WithEvents DTP_MBILLDATE As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(POSFUNDMASTER))
        Me.lbl_Heading = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Cmd_View = New System.Windows.Forms.Button()
        Me.Cmd_Clear = New System.Windows.Forms.Button()
        Me.Cmd_Add = New System.Windows.Forms.Button()
        Me.Cmd_Exit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DTP_INTDATE = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTP_MBILLDATE = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTP_BILLTO = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTP_BILLFROM = New System.Windows.Forms.DateTimePicker()
        Me.lbl_ceased = New System.Windows.Forms.Label()
        Me.TXT_CEASED = New System.Windows.Forms.TextBox()
        Me.Lbl_CRBAL = New System.Windows.Forms.Label()
        Me.TXT_CMCRBAL = New System.Windows.Forms.TextBox()
        Me.LBL_POSTEDLIST = New System.Windows.Forms.Label()
        Me.TXT_pOSTEDLIST = New System.Windows.Forms.TextBox()
        Me.lbl_minbal = New System.Windows.Forms.Label()
        Me.TXT_PMMINBAL = New System.Windows.Forms.TextBox()
        Me.LBL_DUEDATE = New System.Windows.Forms.Label()
        Me.Dtp_DueDate = New System.Windows.Forms.DateTimePicker()
        Me.lbl_PYMTdate = New System.Windows.Forms.Label()
        Me.dtp_PYMTdate = New System.Windows.Forms.DateTimePicker()
        Me.TXTSWFACDESC = New System.Windows.Forms.TextBox()
        Me.CMDSWFACCODE = New System.Windows.Forms.Button()
        Me.LBL_SWF = New System.Windows.Forms.Label()
        Me.TXTSWFACCODE = New System.Windows.Forms.TextBox()
        Me.TXTSWFUND = New System.Windows.Forms.TextBox()
        Me.TXTPENALTYACCODE = New System.Windows.Forms.TextBox()
        Me.TXTPENALTYACDESC = New System.Windows.Forms.TextBox()
        Me.CMDPENALTYACCODE = New System.Windows.Forms.Button()
        Me.TXTPENALTY = New System.Windows.Forms.TextBox()
        Me.lbl_PENALTY = New System.Windows.Forms.Label()
        Me.inst_post = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Heading.Location = New System.Drawing.Point(288, 8)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(236, 25)
        Me.lbl_Heading.TabIndex = 4
        Me.lbl_Heading.Text = "POS SETUP / FUND"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.inst_post)
        Me.GroupBox2.Controls.Add(Me.Cmd_View)
        Me.GroupBox2.Controls.Add(Me.Cmd_Clear)
        Me.GroupBox2.Controls.Add(Me.Cmd_Add)
        Me.GroupBox2.Controls.Add(Me.Cmd_Exit)
        Me.GroupBox2.Location = New System.Drawing.Point(160, 360)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(596, 56)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(244, 17)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 4
        Me.Cmd_View.Text = " View[F9]"
        Me.Cmd_View.UseVisualStyleBackColor = False
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.Location = New System.Drawing.Point(16, 16)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Clear.TabIndex = 0
        Me.Cmd_Clear.Text = "Clear[F6]"
        Me.Cmd_Clear.UseVisualStyleBackColor = False
        '
        'Cmd_Add
        '
        Me.Cmd_Add.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Add.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Add.ForeColor = System.Drawing.Color.White
        Me.Cmd_Add.Image = CType(resources.GetObject("Cmd_Add.Image"), System.Drawing.Image)
        Me.Cmd_Add.Location = New System.Drawing.Point(130, 16)
        Me.Cmd_Add.Name = "Cmd_Add"
        Me.Cmd_Add.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Add.TabIndex = 1
        Me.Cmd_Add.Text = "Add[F7]"
        Me.Cmd_Add.UseVisualStyleBackColor = False
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(471, 16)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 2
        Me.Cmd_Exit.Text = "Exit[F11]"
        Me.Cmd_Exit.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DTP_INTDATE)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DTP_MBILLDATE)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DTP_BILLTO)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DTP_BILLFROM)
        Me.GroupBox1.Controls.Add(Me.lbl_ceased)
        Me.GroupBox1.Controls.Add(Me.TXT_CEASED)
        Me.GroupBox1.Controls.Add(Me.Lbl_CRBAL)
        Me.GroupBox1.Controls.Add(Me.TXT_CMCRBAL)
        Me.GroupBox1.Controls.Add(Me.LBL_POSTEDLIST)
        Me.GroupBox1.Controls.Add(Me.TXT_pOSTEDLIST)
        Me.GroupBox1.Controls.Add(Me.lbl_minbal)
        Me.GroupBox1.Controls.Add(Me.TXT_PMMINBAL)
        Me.GroupBox1.Controls.Add(Me.LBL_DUEDATE)
        Me.GroupBox1.Controls.Add(Me.Dtp_DueDate)
        Me.GroupBox1.Controls.Add(Me.lbl_PYMTdate)
        Me.GroupBox1.Controls.Add(Me.dtp_PYMTdate)
        Me.GroupBox1.Controls.Add(Me.TXTSWFACDESC)
        Me.GroupBox1.Controls.Add(Me.CMDSWFACCODE)
        Me.GroupBox1.Controls.Add(Me.LBL_SWF)
        Me.GroupBox1.Controls.Add(Me.TXTSWFACCODE)
        Me.GroupBox1.Controls.Add(Me.TXTSWFUND)
        Me.GroupBox1.Controls.Add(Me.TXTPENALTYACCODE)
        Me.GroupBox1.Controls.Add(Me.TXTPENALTYACDESC)
        Me.GroupBox1.Controls.Add(Me.CMDPENALTYACCODE)
        Me.GroupBox1.Controls.Add(Me.TXTPENALTY)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(688, 284)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(296, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "INT DATE :"
        '
        'DTP_INTDATE
        '
        Me.DTP_INTDATE.CustomFormat = "dd/MM/yyyy"
        Me.DTP_INTDATE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_INTDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_INTDATE.Location = New System.Drawing.Point(456, 184)
        Me.DTP_INTDATE.Name = "DTP_INTDATE"
        Me.DTP_INTDATE.Size = New System.Drawing.Size(104, 20)
        Me.DTP_INTDATE.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(8, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "MBILL DATE:"
        '
        'DTP_MBILLDATE
        '
        Me.DTP_MBILLDATE.CustomFormat = "dd/MM/yyyy"
        Me.DTP_MBILLDATE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_MBILLDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_MBILLDATE.Location = New System.Drawing.Point(168, 184)
        Me.DTP_MBILLDATE.Name = "DTP_MBILLDATE"
        Me.DTP_MBILLDATE.Size = New System.Drawing.Size(104, 20)
        Me.DTP_MBILLDATE.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(296, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "BILL TO :"
        '
        'DTP_BILLTO
        '
        Me.DTP_BILLTO.CustomFormat = "dd/MM/yyyy"
        Me.DTP_BILLTO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_BILLTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_BILLTO.Location = New System.Drawing.Point(456, 152)
        Me.DTP_BILLTO.Name = "DTP_BILLTO"
        Me.DTP_BILLTO.Size = New System.Drawing.Size(104, 20)
        Me.DTP_BILLTO.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "BILL FROM:"
        '
        'DTP_BILLFROM
        '
        Me.DTP_BILLFROM.CustomFormat = "dd/MM/yyyy"
        Me.DTP_BILLFROM.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_BILLFROM.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_BILLFROM.Location = New System.Drawing.Point(168, 152)
        Me.DTP_BILLFROM.Name = "DTP_BILLFROM"
        Me.DTP_BILLFROM.Size = New System.Drawing.Size(104, 20)
        Me.DTP_BILLFROM.TabIndex = 63
        '
        'lbl_ceased
        '
        Me.lbl_ceased.AutoSize = True
        Me.lbl_ceased.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ceased.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ceased.ForeColor = System.Drawing.Color.Black
        Me.lbl_ceased.Location = New System.Drawing.Point(312, 256)
        Me.lbl_ceased.Name = "lbl_ceased"
        Me.lbl_ceased.Size = New System.Drawing.Size(118, 13)
        Me.lbl_ceased.TabIndex = 61
        Me.lbl_ceased.Text = "CEASED LIST       :"
        '
        'TXT_CEASED
        '
        Me.TXT_CEASED.BackColor = System.Drawing.Color.Wheat
        Me.TXT_CEASED.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_CEASED.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CEASED.Location = New System.Drawing.Point(480, 256)
        Me.TXT_CEASED.MaxLength = 9
        Me.TXT_CEASED.Name = "TXT_CEASED"
        Me.TXT_CEASED.Size = New System.Drawing.Size(120, 20)
        Me.TXT_CEASED.TabIndex = 62
        Me.TXT_CEASED.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lbl_CRBAL
        '
        Me.Lbl_CRBAL.AutoSize = True
        Me.Lbl_CRBAL.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_CRBAL.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_CRBAL.ForeColor = System.Drawing.Color.Black
        Me.Lbl_CRBAL.Location = New System.Drawing.Point(312, 224)
        Me.Lbl_CRBAL.Name = "Lbl_CRBAL"
        Me.Lbl_CRBAL.Size = New System.Drawing.Size(122, 13)
        Me.Lbl_CRBAL.TabIndex = 59
        Me.Lbl_CRBAL.Text = "CM Cr BAL            :"
        '
        'TXT_CMCRBAL
        '
        Me.TXT_CMCRBAL.BackColor = System.Drawing.Color.Wheat
        Me.TXT_CMCRBAL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_CMCRBAL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CMCRBAL.Location = New System.Drawing.Point(480, 224)
        Me.TXT_CMCRBAL.MaxLength = 9
        Me.TXT_CMCRBAL.Name = "TXT_CMCRBAL"
        Me.TXT_CMCRBAL.Size = New System.Drawing.Size(120, 20)
        Me.TXT_CMCRBAL.TabIndex = 60
        Me.TXT_CMCRBAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LBL_POSTEDLIST
        '
        Me.LBL_POSTEDLIST.AutoSize = True
        Me.LBL_POSTEDLIST.BackColor = System.Drawing.Color.Transparent
        Me.LBL_POSTEDLIST.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_POSTEDLIST.ForeColor = System.Drawing.Color.Black
        Me.LBL_POSTEDLIST.Location = New System.Drawing.Point(8, 256)
        Me.LBL_POSTEDLIST.Name = "LBL_POSTEDLIST"
        Me.LBL_POSTEDLIST.Size = New System.Drawing.Size(129, 13)
        Me.LBL_POSTEDLIST.TabIndex = 57
        Me.LBL_POSTEDLIST.Text = "POSTED LIST DAYS :"
        '
        'TXT_pOSTEDLIST
        '
        Me.TXT_pOSTEDLIST.BackColor = System.Drawing.Color.Wheat
        Me.TXT_pOSTEDLIST.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_pOSTEDLIST.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_pOSTEDLIST.Location = New System.Drawing.Point(176, 256)
        Me.TXT_pOSTEDLIST.MaxLength = 9
        Me.TXT_pOSTEDLIST.Name = "TXT_pOSTEDLIST"
        Me.TXT_pOSTEDLIST.Size = New System.Drawing.Size(120, 20)
        Me.TXT_pOSTEDLIST.TabIndex = 58
        Me.TXT_pOSTEDLIST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_minbal
        '
        Me.lbl_minbal.AutoSize = True
        Me.lbl_minbal.BackColor = System.Drawing.Color.Transparent
        Me.lbl_minbal.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_minbal.ForeColor = System.Drawing.Color.Black
        Me.lbl_minbal.Location = New System.Drawing.Point(8, 224)
        Me.lbl_minbal.Name = "lbl_minbal"
        Me.lbl_minbal.Size = New System.Drawing.Size(128, 13)
        Me.lbl_minbal.TabIndex = 55
        Me.lbl_minbal.Text = "PM MIN BAL            :"
        '
        'TXT_PMMINBAL
        '
        Me.TXT_PMMINBAL.BackColor = System.Drawing.Color.Wheat
        Me.TXT_PMMINBAL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_PMMINBAL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PMMINBAL.Location = New System.Drawing.Point(176, 224)
        Me.TXT_PMMINBAL.MaxLength = 9
        Me.TXT_PMMINBAL.Name = "TXT_PMMINBAL"
        Me.TXT_PMMINBAL.Size = New System.Drawing.Size(120, 20)
        Me.TXT_PMMINBAL.TabIndex = 56
        Me.TXT_PMMINBAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LBL_DUEDATE
        '
        Me.LBL_DUEDATE.AutoSize = True
        Me.LBL_DUEDATE.BackColor = System.Drawing.Color.Transparent
        Me.LBL_DUEDATE.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_DUEDATE.ForeColor = System.Drawing.Color.Black
        Me.LBL_DUEDATE.Location = New System.Drawing.Point(296, 112)
        Me.LBL_DUEDATE.Name = "LBL_DUEDATE"
        Me.LBL_DUEDATE.Size = New System.Drawing.Size(74, 13)
        Me.LBL_DUEDATE.TabIndex = 54
        Me.LBL_DUEDATE.Text = "DUE DATE :"
        '
        'Dtp_DueDate
        '
        Me.Dtp_DueDate.CustomFormat = "dd/MM/yyyy"
        Me.Dtp_DueDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_DueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp_DueDate.Location = New System.Drawing.Point(456, 112)
        Me.Dtp_DueDate.Name = "Dtp_DueDate"
        Me.Dtp_DueDate.Size = New System.Drawing.Size(104, 20)
        Me.Dtp_DueDate.TabIndex = 53
        '
        'lbl_PYMTdate
        '
        Me.lbl_PYMTdate.AutoSize = True
        Me.lbl_PYMTdate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_PYMTdate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PYMTdate.ForeColor = System.Drawing.Color.Black
        Me.lbl_PYMTdate.Location = New System.Drawing.Point(8, 112)
        Me.lbl_PYMTdate.Name = "lbl_PYMTdate"
        Me.lbl_PYMTdate.Size = New System.Drawing.Size(76, 13)
        Me.lbl_PYMTdate.TabIndex = 52
        Me.lbl_PYMTdate.Text = "PYMT DATE:"
        '
        'dtp_PYMTdate
        '
        Me.dtp_PYMTdate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_PYMTdate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_PYMTdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_PYMTdate.Location = New System.Drawing.Point(168, 112)
        Me.dtp_PYMTdate.Name = "dtp_PYMTdate"
        Me.dtp_PYMTdate.Size = New System.Drawing.Size(104, 20)
        Me.dtp_PYMTdate.TabIndex = 51
        '
        'TXTSWFACDESC
        '
        Me.TXTSWFACDESC.BackColor = System.Drawing.Color.Wheat
        Me.TXTSWFACDESC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTSWFACDESC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSWFACDESC.Location = New System.Drawing.Point(448, 72)
        Me.TXTSWFACDESC.MaxLength = 35
        Me.TXTSWFACDESC.Name = "TXTSWFACDESC"
        Me.TXTSWFACDESC.ReadOnly = True
        Me.TXTSWFACDESC.Size = New System.Drawing.Size(212, 20)
        Me.TXTSWFACDESC.TabIndex = 50
        '
        'CMDSWFACCODE
        '
        Me.CMDSWFACCODE.Image = CType(resources.GetObject("CMDSWFACCODE.Image"), System.Drawing.Image)
        Me.CMDSWFACCODE.Location = New System.Drawing.Point(416, 72)
        Me.CMDSWFACCODE.Name = "CMDSWFACCODE"
        Me.CMDSWFACCODE.Size = New System.Drawing.Size(23, 26)
        Me.CMDSWFACCODE.TabIndex = 49
        '
        'LBL_SWF
        '
        Me.LBL_SWF.AutoSize = True
        Me.LBL_SWF.BackColor = System.Drawing.Color.Transparent
        Me.LBL_SWF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_SWF.ForeColor = System.Drawing.Color.Black
        Me.LBL_SWF.Location = New System.Drawing.Point(8, 72)
        Me.LBL_SWF.Name = "LBL_SWF"
        Me.LBL_SWF.Size = New System.Drawing.Size(106, 13)
        Me.LBL_SWF.TabIndex = 46
        Me.LBL_SWF.Text = "SW FUND          :"
        '
        'TXTSWFACCODE
        '
        Me.TXTSWFACCODE.BackColor = System.Drawing.Color.Wheat
        Me.TXTSWFACCODE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTSWFACCODE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSWFACCODE.Location = New System.Drawing.Point(296, 72)
        Me.TXTSWFACCODE.MaxLength = 10
        Me.TXTSWFACCODE.Name = "TXTSWFACCODE"
        Me.TXTSWFACCODE.Size = New System.Drawing.Size(120, 20)
        Me.TXTSWFACCODE.TabIndex = 48
        '
        'TXTSWFUND
        '
        Me.TXTSWFUND.BackColor = System.Drawing.Color.Wheat
        Me.TXTSWFUND.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTSWFUND.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSWFUND.Location = New System.Drawing.Point(168, 72)
        Me.TXTSWFUND.MaxLength = 9
        Me.TXTSWFUND.Name = "TXTSWFUND"
        Me.TXTSWFUND.Size = New System.Drawing.Size(120, 20)
        Me.TXTSWFUND.TabIndex = 47
        Me.TXTSWFUND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTPENALTYACCODE
        '
        Me.TXTPENALTYACCODE.BackColor = System.Drawing.Color.Wheat
        Me.TXTPENALTYACCODE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTPENALTYACCODE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPENALTYACCODE.Location = New System.Drawing.Point(296, 32)
        Me.TXTPENALTYACCODE.MaxLength = 10
        Me.TXTPENALTYACCODE.Name = "TXTPENALTYACCODE"
        Me.TXTPENALTYACCODE.Size = New System.Drawing.Size(120, 20)
        Me.TXTPENALTYACCODE.TabIndex = 31
        '
        'TXTPENALTYACDESC
        '
        Me.TXTPENALTYACDESC.BackColor = System.Drawing.Color.Wheat
        Me.TXTPENALTYACDESC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTPENALTYACDESC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPENALTYACDESC.Location = New System.Drawing.Point(448, 32)
        Me.TXTPENALTYACDESC.MaxLength = 35
        Me.TXTPENALTYACDESC.Name = "TXTPENALTYACDESC"
        Me.TXTPENALTYACDESC.ReadOnly = True
        Me.TXTPENALTYACDESC.Size = New System.Drawing.Size(208, 20)
        Me.TXTPENALTYACDESC.TabIndex = 33
        '
        'CMDPENALTYACCODE
        '
        Me.CMDPENALTYACCODE.Image = CType(resources.GetObject("CMDPENALTYACCODE.Image"), System.Drawing.Image)
        Me.CMDPENALTYACCODE.Location = New System.Drawing.Point(416, 32)
        Me.CMDPENALTYACCODE.Name = "CMDPENALTYACCODE"
        Me.CMDPENALTYACCODE.Size = New System.Drawing.Size(23, 26)
        Me.CMDPENALTYACCODE.TabIndex = 32
        '
        'TXTPENALTY
        '
        Me.TXTPENALTY.BackColor = System.Drawing.Color.Wheat
        Me.TXTPENALTY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTPENALTY.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPENALTY.Location = New System.Drawing.Point(168, 32)
        Me.TXTPENALTY.MaxLength = 9
        Me.TXTPENALTY.Name = "TXTPENALTY"
        Me.TXTPENALTY.Size = New System.Drawing.Size(120, 20)
        Me.TXTPENALTY.TabIndex = 30
        Me.TXTPENALTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_PENALTY
        '
        Me.lbl_PENALTY.AutoSize = True
        Me.lbl_PENALTY.BackColor = System.Drawing.Color.Transparent
        Me.lbl_PENALTY.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PENALTY.ForeColor = System.Drawing.Color.Black
        Me.lbl_PENALTY.Location = New System.Drawing.Point(64, 92)
        Me.lbl_PENALTY.Name = "lbl_PENALTY"
        Me.lbl_PENALTY.Size = New System.Drawing.Size(101, 13)
        Me.lbl_PENALTY.TabIndex = 6
        Me.lbl_PENALTY.Text = "PENALTY          :"
        '
        'inst_post
        '
        Me.inst_post.BackColor = System.Drawing.Color.ForestGreen
        Me.inst_post.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.inst_post.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inst_post.ForeColor = System.Drawing.Color.White
        Me.inst_post.Image = CType(resources.GetObject("inst_post.Image"), System.Drawing.Image)
        Me.inst_post.Location = New System.Drawing.Point(354, 17)
        Me.inst_post.Name = "inst_post"
        Me.inst_post.Size = New System.Drawing.Size(104, 32)
        Me.inst_post.TabIndex = 5
        Me.inst_post.Text = "Interest Post"
        Me.inst_post.UseVisualStyleBackColor = False
        '
        'POSFUNDMASTER
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(808, 428)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.lbl_PENALTY)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "POSFUNDMASTER"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS FUND"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim boolchk As Boolean
    Dim vseqno As Double
    Dim sqlstring As String
    Dim gconnection As New GlobalClass
    Private Sub POSFUNDMASTER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cmd_Add.Enabled = True
        GroupMasterbool = True
        Me.Cmd_View_Click(sender, e)
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        TXTPENALTY.Focus()
    End Sub
    Private Sub GetRights()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql, SQLSTRING As String
        Dim M1 As New MainMenu
        Dim chstr As String
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='POS' AND MODULENAME LIKE '" & Trim(GmoduleName) & "%'"
        gconnection.getDataSet(SQLSTRING, "USER")
        If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                With gdataset.Tables("USER").Rows(i)
                    chstr = abcdMINUS(.Item("RIGHTS"))
                End With
            Next
        End If
        Me.Cmd_Add.Enabled = False
        Me.Cmd_View.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.Cmd_Add.Enabled = True
                    Me.Cmd_View.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.Cmd_Add.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.Cmd_Add.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.Cmd_Add.Enabled = True
                    End If
                End If
                If Right(x) = "V" Then
                    Me.Cmd_View.Enabled = True
                End If
            Next
        End If
    End Sub
    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        TXTPENALTY.Text = ""
        TXTPENALTYACCODE.Text = ""
        TXTPENALTYACDESC.Text = ""

        TXTSWFUND.Text = ""
        TXTSWFACCODE.Text = ""
        TXTSWFACDESC.Text = ""

        Cmd_Add.Enabled = True
        Cmd_Add.Text = "Add [F7]&S"
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        TXTPENALTY.Focus()
    End Sub
    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        If Cmd_Add.Text = "Add[F7]" Then
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            sqlstring = " INSERT INTO POS_FUND_MASTER (PENALTY,PENALTYACCODE,PENALTYACDESC,SWFUND,SWFACCODE,SWFACDESC,PYMTUPTO,DUEDATE,FROMDATE,TODATE,MBILLDATE,INTDATE,CEASEDLIST,POSTEDLIST,PMONTHMINBAL,CMONTHCRBAL,ADDUSER,ADDDATE)"
            sqlstring = sqlstring & " VALUES ( " & Val(TXTPENALTY.Text) & ",'" & Trim(TXTPENALTYACCODE.Text) & "','" & Trim(TXTPENALTYACDESC.Text) & "',"
            sqlstring = sqlstring & Val(TXTSWFUND.Text) & ",'" & Trim(TXTSWFACCODE.Text) & "','" & Trim(TXTSWFACDESC.Text) & "',"
            sqlstring = sqlstring & "'" & Format(dtp_PYMTdate.Text, "dd/MMM/yyyy") & "','" & Format(Dtp_DueDate.Text, "dd/MMM/yyyy") & "','" & Format(DTP_BILLFROM.Text, "dd/MMM/yyyy") & "',"
            sqlstring = sqlstring & "'" & Format(DTP_BILLTO.Text, "dd/MMM/yyyy") & "','" & Format(DTP_MBILLDATE.Text, "dd/MMM/yyyy") & "','" & Format(DTP_INTDATE.Text, "dd/MMM/yyyy") & "',"
            sqlstring = sqlstring & Val(TXT_pOSTEDLIST.Text) & "," & Val(TXT_CEASED.Text) & "," & Val(TXT_PMMINBAL.Text) & "," & Val(TXT_CMCRBAL.Text) & ","
            sqlstring = sqlstring & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
            gconnection.dataOperation(1, sqlstring, "POS_FUND_MASTER")
            MessageBox.Show("Record Added Successfully!", "HGA Club", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Cmd_Clear_Click(sender, e)
        ElseIf Cmd_Add.Text = "Update[F7]" Then
            Call checkValidation()
            If boolchk = False Then Exit Sub
            sqlstring = "UPDATE  POS_FUND_MASTER "
            sqlstring = sqlstring & " SET PENALTY=" & Val(TXTPENALTY.Text) & ","
            sqlstring = sqlstring & " PENALTYACCODE='" & Trim(TXTPENALTYACCODE.Text) & "',"
            sqlstring = sqlstring & " PENALTYACDESC='" & Trim(TXTPENALTYACDESC.Text) & "',"

            sqlstring = sqlstring & " SWFUND=" & Val(TXTSWFUND.Text) & ","
            sqlstring = sqlstring & " SWFACCODE='" & Trim(TXTSWFACCODE.Text) & "',"
            sqlstring = sqlstring & " SWFACDESC='" & Trim(TXTSWFACDESC.Text) & "',"

            sqlstring = sqlstring & " PYMTUPTO='" & Format(dtp_PYMTdate.Value, "dd/MMM/yyyy") & "',"
            sqlstring = sqlstring & " DUEDATE='" & Format(Dtp_DueDate.Value, "dd/MMM/yyyy") & "',"

            sqlstring = sqlstring & " fromdate='" & Format(DTP_BILLFROM.Value, "dd/MMM/yyyy") & "',"
            sqlstring = sqlstring & " todate='" & Format(DTP_BILLTO.Value, "dd/MMM/yyyy") & "',"

            sqlstring = sqlstring & " mbilldate='" & Format(DTP_MBILLDATE.Value, "dd/MMM/yyyy") & "',"
            sqlstring = sqlstring & " intdate='" & Format(DTP_INTDATE.Value, "dd/MMM/yyyy") & "',"

            sqlstring = sqlstring & " PMONTHMINBAL=" & Val(TXT_PMMINBAL.Text) & ","
            sqlstring = sqlstring & " POSTEDLIST=" & Val(TXT_pOSTEDLIST.Text) & ","
            sqlstring = sqlstring & " CMONTHCRBAL=" & Val(TXT_CMCRBAL.Text) & ","
            sqlstring = sqlstring & " CEASEDLIST=" & Val(TXT_CEASED.Text) & ","

            sqlstring = sqlstring & " UPDATEUSER = '" & Trim(gUsername) & "',UPDATEDATE='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            gconnection.dataOperation(2, sqlstring, "POS_FUND_MASTER")
            MessageBox.Show("Record Updated Successfully!", "HGA Club", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Me.Cmd_Clear_Click(sender, e)
            ' Cmd_Add.Text = "Add[F7]"
        End If
    End Sub
    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub
    Private Sub POSFUNDMASTER_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        GroupMasterbool = False
    End Sub

    Private Sub POSFUNDMASTER_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Call Cmd_Clear_Click(Cmd_Clear, e)
            Exit Sub
        End If
        'If e.KeyCode = Keys.F7 Then
        '    Call Cmd_Add_Click(Cmd_Add, e)
        '    Exit Sub
        'End If
        'If e.KeyCode = Keys.F9 Then
        '    Call Cmd_View_Click(Cmd_View, e)
        '    Exit Sub
        'End If
        If e.KeyCode = Keys.F7 Then
            If Cmd_Add.Enabled = True Then
                Call Cmd_Add_Click(Cmd_Add, e)
                Exit Sub
            End If
        End If
        If e.KeyCode = Keys.F9 Then
            If Cmd_View.Enabled = True Then
                Call Cmd_View_Click(Cmd_View, e)
                Exit Sub
            End If
        End If
        If e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            Call Cmd_Exit_Click(Cmd_Exit, e)
            Exit Sub
        End If
    End Sub
    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        sqlstring = "SELECT isnull(PENALTY,0) as PENALTY,isnull(PENALTYACCODE,'') as PENALTYACCODE,isnull(PENALTYACDESC,'') as PENALTYACDESC,isnull(SWFUND,0) as SWFUND,isnull(SWFACCODE,'') as SWFACCODE,isnull(SWFACDESC,'') as SWFACDESC,isnull(PYMTUPTO,'') as PYMTUPTO,isnull(DUEDATE,'') as DUEDATE,isnull(FROMDATE,'') as FROMDATE,isnull(TODATE,'') as TODATE,isnull(MBILLDATE,'') as MBILLDATE,isnull(INTDATE,'') as INTDATE,isnull(CEASEDLIST,0) as CEASEDLIST,isnull(POSTEDLIST,0) as POSTEDLIST,isnull(PMONTHMINBAL,0) as PMONTHMINBAL,isnull(CMONTHCRBAL,0) as CMONTHCRBAL"
        sqlstring = sqlstring & " FROM POS_FUND_MASTER "
        gconnection.getDataSet(sqlstring, "POS_FUND_MASTER")
        If gdataset.Tables("POS_FUND_MASTER").Rows.Count > 0 Then
            Cmd_Add.Text = "Update[F7]"

            TXTPENALTY.Text = Format(Val(gdataset.Tables("POS_FUND_MASTER").Rows(0).Item("PENALTY")), "0.00")
            TXTPENALTYACCODE.Text = Trim(gdataset.Tables("POS_FUND_MASTER").Rows(0).Item("PENALTYACCODE"))
            TXTPENALTYACDESC.Text = Trim(gdataset.Tables("POS_FUND_MASTER").Rows(0).Item("PENALTYACDESC"))

            TXTSWFUND.Text = Format(Val(gdataset.Tables("POS_FUND_MASTER").Rows(0).Item("SWFUND")), "0.00")
            TXTSWFACCODE.Text = Trim(gdataset.Tables("POS_FUND_MASTER").Rows(0).Item("SWFACCODE"))
            TXTSWFACDESC.Text = Trim(gdataset.Tables("POS_FUND_MASTER").Rows(0).Item("SWFACDESC"))

            dtp_PYMTdate.Text = Format(gdataset.Tables("POS_FUND_MASTER").Rows(0).Item("PYMTUPTO"), "dd/MMM/yyyy")
            Dtp_DueDate.Text = Format(gdataset.Tables("POS_FUND_MASTER").Rows(0).Item("DUEDATE"), "dd/MMM/yyyy")

            DTP_MBILLDATE.Text = Format(gdataset.Tables("POS_FUND_MASTER").Rows(0).Item("MBILLDATE"), "dd/MMM/yyyy")
            DTP_INTDATE.Text = Format(gdataset.Tables("POS_FUND_MASTER").Rows(0).Item("INTDATE"), "dd/MMM/yyyy")

            DTP_BILLFROM.Text = Format(gdataset.Tables("POS_FUND_MASTER").Rows(0).Item("FROMDATE"), "dd/MMM/yyyy")
            DTP_BILLTO.Text = Format(gdataset.Tables("POS_FUND_MASTER").Rows(0).Item("TODATE"), "dd/MMM/yyyy")

            TXT_PMMINBAL.Text = Format(Val(gdataset.Tables("POS_FUND_MASTER").Rows(0).Item("PMONTHMINBAL")), "0")
            TXT_pOSTEDLIST.Text = Format(Val(gdataset.Tables("POS_FUND_MASTER").Rows(0).Item("POSTEDLIST")), "0")

            TXT_CMCRBAL.Text = Format(Val(gdataset.Tables("POS_FUND_MASTER").Rows(0).Item("CMONTHCRBAL")), "0")
            TXT_CEASED.Text = Format(Val(gdataset.Tables("POS_FUND_MASTER").Rows(0).Item("CEASEDLIST")), "0")

            Me.Cmd_Add.Text = "Update[F7]"
            Me.Cmd_Add.Enabled = True

            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            TXTPENALTY.Focus()
        Else
            MessageBox.Show("!!! ACTIVATE  !!!Till Now POS SETUP is not yet activated ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXTPENALTY.Focus()
            Cmd_Add.Text = "Add[F7]"
            Exit Sub
        End If
    End Sub
    Public Sub checkValidation()
        boolchk = False
        If Trim(TXTPENALTY.Text) = "" Then
            MessageBox.Show("Penalty Print can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TXTPENALTY.Focus()
            Exit Sub
        End If
        boolchk = True
    End Sub
    Private Sub CMDPENALTYACCODE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDPENALTYACCODE.Click
        Dim vform As New LIST_OPERATION1
        gSQLString = "SELECT ISNULL(ACCODE,'') AS ACCODE,ISNULL(ACDESC,'') AS ACDESC FROM Accountsglaccountmaster  "
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = " WHERE ISNULL(freezeflag,'') <> 'Y'"
        End If
        vform.Field = "ACCODE,ACDESC"
        vform.vCaption = "ACCOUNT MASTER HELP "
        vform.TXT_SEARCH_TXT.Select()
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            TXTPENALTYACCODE.Text = Trim(vform.keyfield & "")
            TXTPENALTYACDESC.Text = Trim(vform.keyfield1 & "")
            vform.Close()
            vform = Nothing
        End If
        gconnection.closeconnection()
    End Sub


    Private Sub CMDSWFACCODE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDSWFACCODE.Click
        Dim vform As New LIST_OPERATION1
        gSQLString = "SELECT ISNULL(ACCODE,'') AS ACCODE,ISNULL(ACDESC,'') AS ACDESC FROM Accountsglaccountmaster  "
        If Trim(Search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = " WHERE ISNULL(freezeflag,'') <> 'Y'"
        End If
        vform.Field = "ACCODE,ACDESC"
        vform.vCaption = "ACCOUNT MASTER HELP "
        vform.TXT_SEARCH_TXT.Select()
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            TXTPENALTYACCODE.Text = Trim(vform.keyfield & "")
            TXTPENALTYACDESC.Text = Trim(vform.keyfield1 & "")
            vform.Close()
            vform = Nothing
        End If
        gconnection.closeconnection()
    End Sub
    Private Sub TXTPENALTY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTPENALTY.KeyPress
        Call getNumeric(e)
        If Asc(e.KeyChar) = Keys.Enter Then
            TXTPENALTYACCODE.Focus()
        End If
    End Sub


    Private Sub TXTNEWNOOFMONTHS_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Call getNumeric(e)
        If Asc(e.KeyChar) = Keys.Enter Then
            TXTSWFUND.Focus()
        End If
    End Sub
    Private Sub TXTSWFUND_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTSWFUND.KeyPress
        Call getNumeric(e)
        If Asc(e.KeyChar) = Keys.Enter Then
            TXTSWFACCODE.Focus()
        End If
    End Sub
    Private Sub TXTPENALTYACCODE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXTPENALTYACCODE.KeyDown
        If e.KeyCode = Keys.F4 Or Trim(TXTPENALTYACCODE.Text) = "" Then
            Search = Trim(TXTPENALTYACCODE.Text)
            Call CMDPENALTYACCODE_Click(sender, e)
        End If
    End Sub
    Private Sub TXTSWFACCODE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXTSWFACCODE.KeyDown
        If e.KeyCode = Keys.F4 Or Trim(TXTSWFACCODE.Text) = "" Then
            Search = Trim(TXTSWFACCODE.Text)
            Call CMDSWFACCODE_Click(sender, e)
        End If
        If e.KeyCode = Keys.Enter Then
            dtp_PYMTdate.Focus()
        End If
    End Sub
    Private Sub TextBox3_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_CEASED.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cmd_Add.Focus()
        End If
    End Sub

    Private Sub dtp_PYMTdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_PYMTdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXT_PMMINBAL.Focus()
        End If
    End Sub


    Private Sub TXT_PMMINBAL_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_PMMINBAL.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXT_CMCRBAL.Focus()
        End If

    End Sub
    Private Sub TXT_CMCRBAL_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_CMCRBAL.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dtp_DueDate.Focus()
        End If
    End Sub

    Private Sub Dtp_DueDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Dtp_DueDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXT_pOSTEDLIST.Focus()
        End If
    End Sub
    Private Sub TXT_pOSTEDLIST_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_pOSTEDLIST.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXT_CEASED.Focus()
        End If
    End Sub

 
    Private Sub inst_post_Click(sender As Object, e As EventArgs) Handles inst_post.Click
        Try
            Dim monthdate As Integer

        monthdate = Format(DTP_MBILLDATE.Value, "MM")
        sqlstring = "select * from journalentry where MONTH(voucherdate)=" & monthdate & "  and vouchertype='INST'"
        gconnection.getDataSet(sqlstring, "POS_FUND_MASTER")
            If gdataset.Tables("POS_FUND_MASTER").Rows.Count > 0 Then
                MsgBox("Already Posted", MsgBoxStyle.OkOnly)
                Exit Sub
            End If
           
        sqlstring = "Exec  CP_MEMINTEREST "
        gconnection.ExcuteStoreProcedure(sqlstring)
            MsgBox("Posted sucessfully", MsgBoxStyle.OkOnly)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
