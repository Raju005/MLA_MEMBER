<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_rkga_MemberAddressList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_rkga_MemberAddressList))
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Select_Category = New System.Windows.Forms.CheckedListBox()
        Me.Select_Status = New System.Windows.Forms.CheckedListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cbo_PCity = New System.Windows.Forms.ComboBox()
        Me.Cbo_PState = New System.Windows.Forms.ComboBox()
        Me.Cbo_PCountry = New System.Windows.Forms.ComboBox()
        Me.txt_pin = New System.Windows.Forms.TextBox()
        Me.chk_City = New System.Windows.Forms.CheckBox()
        Me.chk_State = New System.Windows.Forms.CheckBox()
        Me.chk_Country = New System.Windows.Forms.CheckBox()
        Me.chk_pin = New System.Windows.Forms.CheckBox()
        Me.rdb_wphone = New System.Windows.Forms.CheckBox()
        Me.rdb_wmobile = New System.Windows.Forms.CheckBox()
        Me.rdb_wmcode = New System.Windows.Forms.CheckBox()
        Me.rdb_wserialno = New System.Windows.Forms.CheckBox()
        Me.rbtn1 = New System.Windows.Forms.RadioButton()
        Me.rbtn2 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_mcode2 = New System.Windows.Forms.TextBox()
        Me.txt_mcode1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_view = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chk_all = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_mcodehelp1 = New System.Windows.Forms.Button()
        Me.btn_mcodehelp = New System.Windows.Forms.Button()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.txt_status = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Chk_Email = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(197, 150)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(156, 19)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Select All / UnSelect All"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(539, 149)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(156, 19)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "Select All / UnSelect All"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'Select_Category
        '
        Me.Select_Category.FormattingEnabled = True
        Me.Select_Category.Location = New System.Drawing.Point(194, 173)
        Me.Select_Category.Name = "Select_Category"
        Me.Select_Category.Size = New System.Drawing.Size(326, 229)
        Me.Select_Category.TabIndex = 2
        '
        'Select_Status
        '
        Me.Select_Status.FormattingEnabled = True
        Me.Select_Status.Items.AddRange(New Object() {"ACTIVE", "INACTIVE", "SUSPENDED", "DEFAULTER", "EXPIRED", "RESIGNED", "TERMINATED", "POSTED", "CEASED"})
        Me.Select_Status.Location = New System.Drawing.Point(536, 173)
        Me.Select_Status.Name = "Select_Status"
        Me.Select_Status.Size = New System.Drawing.Size(106, 229)
        Me.Select_Status.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(180, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Member Address List"
        '
        'Cbo_PCity
        '
        Me.Cbo_PCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_PCity.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_PCity.FormattingEnabled = True
        Me.Cbo_PCity.Location = New System.Drawing.Point(67, 38)
        Me.Cbo_PCity.Name = "Cbo_PCity"
        Me.Cbo_PCity.Size = New System.Drawing.Size(121, 23)
        Me.Cbo_PCity.TabIndex = 6
        '
        'Cbo_PState
        '
        Me.Cbo_PState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_PState.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_PState.FormattingEnabled = True
        Me.Cbo_PState.Location = New System.Drawing.Point(233, 39)
        Me.Cbo_PState.Name = "Cbo_PState"
        Me.Cbo_PState.Size = New System.Drawing.Size(117, 23)
        Me.Cbo_PState.TabIndex = 7
        '
        'Cbo_PCountry
        '
        Me.Cbo_PCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_PCountry.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_PCountry.FormattingEnabled = True
        Me.Cbo_PCountry.Location = New System.Drawing.Point(388, 39)
        Me.Cbo_PCountry.Name = "Cbo_PCountry"
        Me.Cbo_PCountry.Size = New System.Drawing.Size(106, 23)
        Me.Cbo_PCountry.TabIndex = 8
        '
        'txt_pin
        '
        Me.txt_pin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_pin.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pin.Location = New System.Drawing.Point(527, 40)
        Me.txt_pin.MaxLength = 20
        Me.txt_pin.Name = "txt_pin"
        Me.txt_pin.Size = New System.Drawing.Size(81, 21)
        Me.txt_pin.TabIndex = 9
        '
        'chk_City
        '
        Me.chk_City.AutoSize = True
        Me.chk_City.BackColor = System.Drawing.Color.Transparent
        Me.chk_City.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_City.Location = New System.Drawing.Point(70, 14)
        Me.chk_City.Name = "chk_City"
        Me.chk_City.Size = New System.Drawing.Size(47, 19)
        Me.chk_City.TabIndex = 10
        Me.chk_City.Text = "City"
        Me.chk_City.UseVisualStyleBackColor = False
        '
        'chk_State
        '
        Me.chk_State.AutoSize = True
        Me.chk_State.BackColor = System.Drawing.Color.Transparent
        Me.chk_State.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_State.Location = New System.Drawing.Point(236, 14)
        Me.chk_State.Name = "chk_State"
        Me.chk_State.Size = New System.Drawing.Size(56, 19)
        Me.chk_State.TabIndex = 11
        Me.chk_State.Text = "State"
        Me.chk_State.UseVisualStyleBackColor = False
        '
        'chk_Country
        '
        Me.chk_Country.AutoSize = True
        Me.chk_Country.BackColor = System.Drawing.Color.Transparent
        Me.chk_Country.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Country.Location = New System.Drawing.Point(389, 14)
        Me.chk_Country.Name = "chk_Country"
        Me.chk_Country.Size = New System.Drawing.Size(70, 19)
        Me.chk_Country.TabIndex = 12
        Me.chk_Country.Text = "Country"
        Me.chk_Country.UseVisualStyleBackColor = False
        '
        'chk_pin
        '
        Me.chk_pin.AutoSize = True
        Me.chk_pin.BackColor = System.Drawing.Color.Transparent
        Me.chk_pin.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_pin.Location = New System.Drawing.Point(527, 14)
        Me.chk_pin.Name = "chk_pin"
        Me.chk_pin.Size = New System.Drawing.Size(77, 19)
        Me.chk_pin.TabIndex = 13
        Me.chk_pin.Text = "PIN Code"
        Me.chk_pin.UseVisualStyleBackColor = False
        '
        'rdb_wphone
        '
        Me.rdb_wphone.AutoSize = True
        Me.rdb_wphone.BackColor = System.Drawing.Color.Transparent
        Me.rdb_wphone.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_wphone.Location = New System.Drawing.Point(341, 19)
        Me.rdb_wphone.Name = "rdb_wphone"
        Me.rdb_wphone.Size = New System.Drawing.Size(62, 19)
        Me.rdb_wphone.TabIndex = 16
        Me.rdb_wphone.Text = "Phone"
        Me.rdb_wphone.UseVisualStyleBackColor = False
        '
        'rdb_wmobile
        '
        Me.rdb_wmobile.AutoSize = True
        Me.rdb_wmobile.BackColor = System.Drawing.Color.Transparent
        Me.rdb_wmobile.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_wmobile.Location = New System.Drawing.Point(222, 19)
        Me.rdb_wmobile.Name = "rdb_wmobile"
        Me.rdb_wmobile.Size = New System.Drawing.Size(63, 19)
        Me.rdb_wmobile.TabIndex = 15
        Me.rdb_wmobile.Text = "Mobile"
        Me.rdb_wmobile.UseVisualStyleBackColor = False
        '
        'rdb_wmcode
        '
        Me.rdb_wmcode.AutoSize = True
        Me.rdb_wmcode.BackColor = System.Drawing.Color.Transparent
        Me.rdb_wmcode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_wmcode.Location = New System.Drawing.Point(105, 19)
        Me.rdb_wmcode.Name = "rdb_wmcode"
        Me.rdb_wmcode.Size = New System.Drawing.Size(65, 19)
        Me.rdb_wmcode.TabIndex = 14
        Me.rdb_wmcode.Text = "MCode"
        Me.rdb_wmcode.UseVisualStyleBackColor = False
        '
        'rdb_wserialno
        '
        Me.rdb_wserialno.AutoSize = True
        Me.rdb_wserialno.BackColor = System.Drawing.Color.Transparent
        Me.rdb_wserialno.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_wserialno.Location = New System.Drawing.Point(460, 19)
        Me.rdb_wserialno.Name = "rdb_wserialno"
        Me.rdb_wserialno.Size = New System.Drawing.Size(77, 19)
        Me.rdb_wserialno.TabIndex = 17
        Me.rdb_wserialno.Text = "Serial No"
        Me.rdb_wserialno.UseVisualStyleBackColor = False
        '
        'rbtn1
        '
        Me.rbtn1.AutoSize = True
        Me.rbtn1.BackColor = System.Drawing.Color.Transparent
        Me.rbtn1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn1.Location = New System.Drawing.Point(158, 19)
        Me.rbtn1.Name = "rbtn1"
        Me.rbtn1.Size = New System.Drawing.Size(151, 19)
        Me.rbtn1.TabIndex = 18
        Me.rbtn1.TabStop = True
        Me.rbtn1.Text = "3 Address Sticker List"
        Me.rbtn1.UseVisualStyleBackColor = False
        '
        'rbtn2
        '
        Me.rbtn2.AutoSize = True
        Me.rbtn2.BackColor = System.Drawing.Color.Transparent
        Me.rbtn2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn2.Location = New System.Drawing.Point(335, 19)
        Me.rbtn2.Name = "rbtn2"
        Me.rbtn2.Size = New System.Drawing.Size(151, 19)
        Me.rbtn2.TabIndex = 19
        Me.rbtn2.TabStop = True
        Me.rbtn2.Text = "2 Address Sticker List"
        Me.rbtn2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(106, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "MCode From"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(341, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 15)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "To"
        '
        'txt_mcode2
        '
        Me.txt_mcode2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mcode2.Location = New System.Drawing.Point(189, 19)
        Me.txt_mcode2.MaxLength = 15
        Me.txt_mcode2.Name = "txt_mcode2"
        Me.txt_mcode2.Size = New System.Drawing.Size(81, 21)
        Me.txt_mcode2.TabIndex = 22
        '
        'txt_mcode1
        '
        Me.txt_mcode1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mcode1.Location = New System.Drawing.Point(367, 19)
        Me.txt_mcode1.MaxLength = 15
        Me.txt_mcode1.Name = "txt_mcode1"
        Me.txt_mcode1.Size = New System.Drawing.Size(81, 21)
        Me.txt_mcode1.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(198, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 15)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Member Category"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(536, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 15)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Member Category"
        '
        'btn_exit
        '
        Me.btn_exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Image = CType(resources.GetObject("btn_exit.Image"), System.Drawing.Image)
        Me.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_exit.Location = New System.Drawing.Point(6, 186)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(137, 50)
        Me.btn_exit.TabIndex = 32
        Me.btn_exit.Text = "Exit [F11]"
        Me.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_view
        '
        Me.btn_view.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_view.ForeColor = System.Drawing.Color.Black
        Me.btn_view.Image = CType(resources.GetObject("btn_view.Image"), System.Drawing.Image)
        Me.btn_view.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_view.Location = New System.Drawing.Point(6, 68)
        Me.btn_view.Name = "btn_view"
        Me.btn_view.Size = New System.Drawing.Size(137, 50)
        Me.btn_view.TabIndex = 31
        Me.btn_view.Text = "View [F9]"
        Me.btn_view.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_view.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.Transparent
        Me.btn_clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.Color.Black
        Me.btn_clear.Image = CType(resources.GetObject("btn_clear.Image"), System.Drawing.Image)
        Me.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clear.Location = New System.Drawing.Point(6, 9)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(137, 50)
        Me.btn_clear.TabIndex = 30
        Me.btn_clear.Tag = ""
        Me.btn_clear.Text = "Clear [F6]"
        Me.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_print
        '
        Me.btn_print.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.ForeColor = System.Drawing.Color.Black
        Me.btn_print.Image = CType(resources.GetObject("btn_print.Image"), System.Drawing.Image)
        Me.btn_print.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_print.Location = New System.Drawing.Point(6, 127)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(137, 50)
        Me.btn_print.TabIndex = 33
        Me.btn_print.Text = "Print [F12]"
        Me.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.chk_all)
        Me.GroupBox1.Controls.Add(Me.Cbo_PState)
        Me.GroupBox1.Controls.Add(Me.Cbo_PCity)
        Me.GroupBox1.Controls.Add(Me.Cbo_PCountry)
        Me.GroupBox1.Controls.Add(Me.txt_pin)
        Me.GroupBox1.Controls.Add(Me.chk_State)
        Me.GroupBox1.Controls.Add(Me.chk_City)
        Me.GroupBox1.Controls.Add(Me.chk_Country)
        Me.GroupBox1.Controls.Add(Me.chk_pin)
        Me.GroupBox1.Location = New System.Drawing.Point(194, 448)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(641, 66)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'chk_all
        '
        Me.chk_all.AutoSize = True
        Me.chk_all.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_all.Location = New System.Drawing.Point(11, 24)
        Me.chk_all.Name = "chk_all"
        Me.chk_all.Size = New System.Drawing.Size(40, 19)
        Me.chk_all.TabIndex = 14
        Me.chk_all.Text = "All"
        Me.chk_all.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.rdb_wphone)
        Me.GroupBox2.Controls.Add(Me.rdb_wmcode)
        Me.GroupBox2.Controls.Add(Me.rdb_wmobile)
        Me.GroupBox2.Controls.Add(Me.rdb_wserialno)
        Me.GroupBox2.Location = New System.Drawing.Point(194, 520)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(641, 49)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.rbtn2)
        Me.GroupBox3.Controls.Add(Me.rbtn1)
        Me.GroupBox3.Location = New System.Drawing.Point(194, 585)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(641, 45)
        Me.GroupBox3.TabIndex = 36
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.btn_mcodehelp1)
        Me.GroupBox4.Controls.Add(Me.btn_mcodehelp)
        Me.GroupBox4.Controls.Add(Me.txt_mcode1)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txt_mcode2)
        Me.GroupBox4.Location = New System.Drawing.Point(194, 632)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(641, 50)
        Me.GroupBox4.TabIndex = 37
        Me.GroupBox4.TabStop = False
        '
        'btn_mcodehelp1
        '
        Me.btn_mcodehelp1.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources._400_F_9130045_3SaKfvCqFL4hRJm59cddsCnbx5YyqvYj
        Me.btn_mcodehelp1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_mcodehelp1.Location = New System.Drawing.Point(460, 18)
        Me.btn_mcodehelp1.Name = "btn_mcodehelp1"
        Me.btn_mcodehelp1.Size = New System.Drawing.Size(40, 23)
        Me.btn_mcodehelp1.TabIndex = 25
        Me.btn_mcodehelp1.UseVisualStyleBackColor = True
        '
        'btn_mcodehelp
        '
        Me.btn_mcodehelp.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources._400_F_9130045_3SaKfvCqFL4hRJm59cddsCnbx5YyqvYj
        Me.btn_mcodehelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_mcodehelp.Location = New System.Drawing.Point(276, 17)
        Me.btn_mcodehelp.Name = "btn_mcodehelp"
        Me.btn_mcodehelp.Size = New System.Drawing.Size(40, 23)
        Me.btn_mcodehelp.TabIndex = 24
        Me.btn_mcodehelp.UseVisualStyleBackColor = True
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(198, 432)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(322, 20)
        Me.txtCategory.TabIndex = 38
        Me.txtCategory.Visible = False
        '
        'txt_status
        '
        Me.txt_status.Location = New System.Drawing.Point(539, 432)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(103, 20)
        Me.txt_status.TabIndex = 39
        Me.txt_status.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.btn_clear)
        Me.GroupBox5.Controls.Add(Me.btn_view)
        Me.GroupBox5.Controls.Add(Me.btn_exit)
        Me.GroupBox5.Controls.Add(Me.btn_print)
        Me.GroupBox5.Location = New System.Drawing.Point(861, 173)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(146, 243)
        Me.GroupBox5.TabIndex = 40
        Me.GroupBox5.TabStop = False
        '
        'Chk_Email
        '
        Me.Chk_Email.AutoSize = True
        Me.Chk_Email.BackColor = System.Drawing.Color.Transparent
        Me.Chk_Email.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Email.Location = New System.Drawing.Point(299, 575)
        Me.Chk_Email.Name = "Chk_Email"
        Me.Chk_Email.Size = New System.Drawing.Size(57, 19)
        Me.Chk_Email.TabIndex = 18
        Me.Chk_Email.Text = "Email"
        Me.Chk_Email.UseVisualStyleBackColor = False
        '
        'frm_rkga_MemberAddressList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.Chk_Email)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.txt_status)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Select_Status)
        Me.Controls.Add(Me.Select_Category)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frm_rkga_MemberAddressList"
        Me.Text = "frm_rkga_MemberAddressList"
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Select_Category As System.Windows.Forms.CheckedListBox
    Friend WithEvents Select_Status As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cbo_PCity As System.Windows.Forms.ComboBox
    Friend WithEvents Cbo_PState As System.Windows.Forms.ComboBox
    Friend WithEvents Cbo_PCountry As System.Windows.Forms.ComboBox
    Friend WithEvents txt_pin As System.Windows.Forms.TextBox
    Friend WithEvents chk_City As System.Windows.Forms.CheckBox
    Friend WithEvents chk_State As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Country As System.Windows.Forms.CheckBox
    Friend WithEvents chk_pin As System.Windows.Forms.CheckBox
    Friend WithEvents rdb_wphone As System.Windows.Forms.CheckBox
    Friend WithEvents rdb_wmobile As System.Windows.Forms.CheckBox
    Friend WithEvents rdb_wmcode As System.Windows.Forms.CheckBox
    Friend WithEvents rdb_wserialno As System.Windows.Forms.CheckBox
    Friend WithEvents rbtn1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_mcode2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_mcode1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents btn_exit As System.Windows.Forms.Button
    Public WithEvents btn_view As System.Windows.Forms.Button
    Public WithEvents btn_clear As System.Windows.Forms.Button
    Public WithEvents btn_print As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_mcodehelp1 As System.Windows.Forms.Button
    Friend WithEvents btn_mcodehelp As System.Windows.Forms.Button
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents txt_status As System.Windows.Forms.TextBox
    Friend WithEvents chk_all As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Chk_Email As System.Windows.Forms.CheckBox
End Class
