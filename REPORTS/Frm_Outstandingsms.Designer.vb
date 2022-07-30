<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Outstandingsms
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Outstandingsms))
        Me.lbl_Caption = New System.Windows.Forms.Label()
        Me.Select_Category = New System.Windows.Forms.CheckedListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.dtp_rec = New System.Windows.Forms.DateTimePicker()
        Me.rdo_Curr = New System.Windows.Forms.RadioButton()
        Me.cancel = New System.Windows.Forms.Button()
        Me.process = New System.Windows.Forms.Button()
        Me.Btn_close = New System.Windows.Forms.Button()
        Me.Select_Subs = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.dtp_curmonth = New System.Windows.Forms.DateTimePicker()
        Me.Dtp_premonth = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_browse = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Cbo_API = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SSGRID_OUTSMS = New AxFPSpreadADO.AxfpSpread()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Prefix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Currentmonth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lastmonth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTADD1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTADD2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTADD3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTADD4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTCELL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTCITY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTSTATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTEMAIL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTCOUNTRY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTPIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SSGRID_OUTSMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Caption
        '
        Me.lbl_Caption.AutoSize = True
        Me.lbl_Caption.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Caption.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Caption.Location = New System.Drawing.Point(187, 53)
        Me.lbl_Caption.Name = "lbl_Caption"
        Me.lbl_Caption.Size = New System.Drawing.Size(283, 29)
        Me.lbl_Caption.TabIndex = 388
        Me.lbl_Caption.Text = "Outstanding sms form :"
        Me.lbl_Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Select_Category
        '
        Me.Select_Category.BackColor = System.Drawing.Color.White
        Me.Select_Category.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Select_Category.Location = New System.Drawing.Point(253, 480)
        Me.Select_Category.Name = "Select_Category"
        Me.Select_Category.Size = New System.Drawing.Size(279, 139)
        Me.Select_Category.Sorted = True
        Me.Select_Category.TabIndex = 622
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(253, 445)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 15)
        Me.Label4.TabIndex = 621
        Me.Label4.Text = "Member Category"
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(256, 460)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(84, 21)
        Me.CheckBox1.TabIndex = 620
        Me.CheckBox1.Text = "Select All Categorys"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'dtp_rec
        '
        Me.dtp_rec.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_rec.CustomFormat = "dd/MMM/yyyy"
        Me.dtp_rec.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_rec.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_rec.Location = New System.Drawing.Point(792, 546)
        Me.dtp_rec.Name = "dtp_rec"
        Me.dtp_rec.Size = New System.Drawing.Size(99, 22)
        Me.dtp_rec.TabIndex = 623
        '
        'rdo_Curr
        '
        Me.rdo_Curr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_Curr.Location = New System.Drawing.Point(715, 448)
        Me.rdo_Curr.Name = "rdo_Curr"
        Me.rdo_Curr.Size = New System.Drawing.Size(106, 24)
        Me.rdo_Curr.TabIndex = 624
        Me.rdo_Curr.Text = "Outstaing"
        '
        'cancel
        '
        Me.cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel.ForeColor = System.Drawing.Color.Black
        Me.cancel.Location = New System.Drawing.Point(903, 280)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(104, 32)
        Me.cancel.TabIndex = 627
        Me.cancel.Text = "Clear"
        '
        'process
        '
        Me.process.BackColor = System.Drawing.Color.Transparent
        Me.process.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.process.ForeColor = System.Drawing.Color.Black
        Me.process.Location = New System.Drawing.Point(902, 242)
        Me.process.Name = "process"
        Me.process.Size = New System.Drawing.Size(104, 32)
        Me.process.TabIndex = 626
        Me.process.Text = "Send"
        Me.process.UseVisualStyleBackColor = False
        '
        'Btn_close
        '
        Me.Btn_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_close.ForeColor = System.Drawing.Color.Black
        Me.Btn_close.Location = New System.Drawing.Point(903, 318)
        Me.Btn_close.Name = "Btn_close"
        Me.Btn_close.Size = New System.Drawing.Size(104, 32)
        Me.Btn_close.TabIndex = 625
        Me.Btn_close.Text = "Exit"
        '
        'Select_Subs
        '
        Me.Select_Subs.BackColor = System.Drawing.Color.White
        Me.Select_Subs.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Select_Subs.Location = New System.Drawing.Point(538, 481)
        Me.Select_Subs.Name = "Select_Subs"
        Me.Select_Subs.Size = New System.Drawing.Size(168, 139)
        Me.Select_Subs.Sorted = True
        Me.Select_Subs.TabIndex = 630
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(536, 446)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 15)
        Me.Label1.TabIndex = 629
        Me.Label1.Text = "Detect"
        Me.Label1.Visible = False
        '
        'CheckBox2
        '
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(539, 463)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(84, 18)
        Me.CheckBox2.TabIndex = 628
        Me.CheckBox2.Text = "Select All Categorys"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'dtp_curmonth
        '
        Me.dtp_curmonth.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_curmonth.CustomFormat = "dd/MMM/yyyy"
        Me.dtp_curmonth.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_curmonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_curmonth.Location = New System.Drawing.Point(792, 485)
        Me.dtp_curmonth.Name = "dtp_curmonth"
        Me.dtp_curmonth.Size = New System.Drawing.Size(95, 22)
        Me.dtp_curmonth.TabIndex = 631
        '
        'Dtp_premonth
        '
        Me.Dtp_premonth.CalendarMonthBackground = System.Drawing.Color.White
        Me.Dtp_premonth.CustomFormat = "dd/MMM/yyyy"
        Me.Dtp_premonth.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_premonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp_premonth.Location = New System.Drawing.Point(793, 517)
        Me.Dtp_premonth.Name = "Dtp_premonth"
        Me.Dtp_premonth.Size = New System.Drawing.Size(95, 22)
        Me.Dtp_premonth.TabIndex = 633
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(712, 484)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 15)
        Me.Label2.TabIndex = 635
        Me.Label2.Text = "Current Month"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(712, 516)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 15)
        Me.Label3.TabIndex = 636
        Me.Label3.Text = "Previous Month"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(716, 549)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 15)
        Me.Label5.TabIndex = 637
        Me.Label5.Text = "Receipt Date"
        '
        'btn_browse
        '
        Me.btn_browse.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_browse.Location = New System.Drawing.Point(902, 356)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(104, 24)
        Me.btn_browse.TabIndex = 638
        Me.btn_browse.Text = "Generate View"
        Me.btn_browse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_browse.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Prefix, Me.Mcode, Me.MNAME, Me.Currentmonth, Me.Lastmonth, Me.CONTADD1, Me.CONTADD2, Me.CONTADD3, Me.CONTADD4, Me.CONTCELL, Me.CONTCITY, Me.CONTSTATE, Me.CONTEMAIL, Me.CONTCOUNTRY, Me.CONTPIN})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 60
        Me.DataGridView1.Size = New System.Drawing.Size(843, 577)
        Me.DataGridView1.TabIndex = 639
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(865, 636)
        Me.GroupBox1.TabIndex = 640
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(855, 125)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(143, 283)
        Me.GroupBox2.TabIndex = 645
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(236, 612)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(148, 23)
        Me.Button3.TabIndex = 641
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(34, 612)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 23)
        Me.Button2.TabIndex = 640
        Me.Button2.Text = "ExportToExcel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(864, 481)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 50)
        Me.Button1.TabIndex = 639
        Me.Button1.Text = "Generate View"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(79, 710)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 641
        '
        'Cbo_API
        '
        Me.Cbo_API.FormattingEnabled = True
        Me.Cbo_API.Items.AddRange(New Object() {"Celusion", "Ebiz"})
        Me.Cbo_API.Location = New System.Drawing.Point(889, 215)
        Me.Cbo_API.Name = "Cbo_API"
        Me.Cbo_API.Size = New System.Drawing.Size(121, 21)
        Me.Cbo_API.TabIndex = 642
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(918, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 16)
        Me.Label6.TabIndex = 643
        Me.Label6.Text = "GATWAY"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Mcode"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "MNAME"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "ASOUTSTANDING"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "PREOUTSTANDING"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "CONTADD1"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "CONTADD2"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "CONTADD3"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "CONTADD4"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "CONTCELL"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "CONTCITY"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "CONTSTATE"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "CONTEMAIL"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "CONTCOUNTRY"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "CONTPIN"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'SSGRID_OUTSMS
        '
        Me.SSGRID_OUTSMS.DataSource = Nothing
        Me.SSGRID_OUTSMS.Location = New System.Drawing.Point(253, 137)
        Me.SSGRID_OUTSMS.Name = "SSGRID_OUTSMS"
        Me.SSGRID_OUTSMS.OcxState = CType(resources.GetObject("SSGRID_OUTSMS.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSGRID_OUTSMS.Size = New System.Drawing.Size(615, 305)
        Me.SSGRID_OUTSMS.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(508, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 18)
        Me.Label7.TabIndex = 644
        Me.Label7.Text = "Member :"
        '
        'Prefix
        '
        Me.Prefix.HeaderText = "Prefix"
        Me.Prefix.Name = "Prefix"
        '
        'Mcode
        '
        Me.Mcode.HeaderText = "Mcode"
        Me.Mcode.MinimumWidth = 10
        Me.Mcode.Name = "Mcode"
        '
        'MNAME
        '
        Me.MNAME.HeaderText = "MNAME"
        Me.MNAME.Name = "MNAME"
        '
        'Currentmonth
        '
        Me.Currentmonth.HeaderText = "ASOUTSTANDING"
        Me.Currentmonth.Name = "Currentmonth"
        '
        'Lastmonth
        '
        Me.Lastmonth.HeaderText = "PREOUTSTANDING"
        Me.Lastmonth.Name = "Lastmonth"
        '
        'CONTADD1
        '
        Me.CONTADD1.HeaderText = "CONTADD1"
        Me.CONTADD1.Name = "CONTADD1"
        '
        'CONTADD2
        '
        Me.CONTADD2.HeaderText = "CONTADD2"
        Me.CONTADD2.Name = "CONTADD2"
        '
        'CONTADD3
        '
        Me.CONTADD3.HeaderText = "CONTADD3"
        Me.CONTADD3.Name = "CONTADD3"
        '
        'CONTADD4
        '
        Me.CONTADD4.HeaderText = "CONTADD4"
        Me.CONTADD4.Name = "CONTADD4"
        '
        'CONTCELL
        '
        Me.CONTCELL.HeaderText = "CONTCELL"
        Me.CONTCELL.Name = "CONTCELL"
        '
        'CONTCITY
        '
        Me.CONTCITY.HeaderText = "CONTCITY"
        Me.CONTCITY.Name = "CONTCITY"
        '
        'CONTSTATE
        '
        Me.CONTSTATE.HeaderText = "CONTSTATE"
        Me.CONTSTATE.Name = "CONTSTATE"
        '
        'CONTEMAIL
        '
        Me.CONTEMAIL.HeaderText = "CONTEMAIL"
        Me.CONTEMAIL.Name = "CONTEMAIL"
        '
        'CONTCOUNTRY
        '
        Me.CONTCOUNTRY.HeaderText = "CONTCOUNTRY"
        Me.CONTCOUNTRY.Name = "CONTCOUNTRY"
        '
        'CONTPIN
        '
        Me.CONTPIN.HeaderText = "CONTPIN"
        Me.CONTPIN.Name = "CONTPIN"
        '
        'Frm_Outstandingsms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources._111in1024res
        Me.ClientSize = New System.Drawing.Size(1024, 750)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Dtp_premonth)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Select_Category)
        Me.Controls.Add(Me.dtp_curmonth)
        Me.Controls.Add(Me.SSGRID_OUTSMS)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cbo_API)
        Me.Controls.Add(Me.rdo_Curr)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btn_browse)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Select_Subs)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.process)
        Me.Controls.Add(Me.Btn_close)
        Me.Controls.Add(Me.lbl_Caption)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtp_rec)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Frm_Outstandingsms"
        Me.Text = "Frm_Outstandingsms"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.SSGRID_OUTSMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Caption As System.Windows.Forms.Label
    Friend WithEvents Select_Category As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents dtp_rec As System.Windows.Forms.DateTimePicker
    Friend WithEvents SSGRID_OUTSMS As AxFPSpreadADO.AxfpSpread
    Friend WithEvents rdo_Curr As System.Windows.Forms.RadioButton
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents process As System.Windows.Forms.Button
    Friend WithEvents Btn_close As System.Windows.Forms.Button
    Friend WithEvents Select_Subs As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents dtp_curmonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dtp_premonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_browse As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cbo_API As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Prefix As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MNAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Currentmonth As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lastmonth As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONTADD1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONTADD2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONTADD3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONTADD4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONTCELL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONTCITY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONTSTATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONTEMAIL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONTCOUNTRY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONTPIN As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
