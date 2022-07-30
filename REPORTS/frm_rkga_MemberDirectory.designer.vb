<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_rkga_MemberDirectory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_rkga_MemberDirectory))
        Me.txt_status = New System.Windows.Forms.TextBox()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_mcodehelp1 = New System.Windows.Forms.Button()
        Me.btn_mcodehelp = New System.Windows.Forms.Button()
        Me.txt_mcode1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_mcode2 = New System.Windows.Forms.TextBox()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_view = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Select_Status = New System.Windows.Forms.CheckedListBox()
        Me.Select_Category = New System.Windows.Forms.CheckedListBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AddressFilter = New System.Windows.Forms.Label()
        Me.Cmb_add_filter = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk_spsname = New System.Windows.Forms.CheckBox()
        Me.chk_photo = New System.Windows.Forms.CheckBox()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_status
        '
        Me.txt_status.Location = New System.Drawing.Point(542, 432)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(290, 20)
        Me.txt_status.TabIndex = 53
        Me.txt_status.Visible = False
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(201, 432)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(322, 20)
        Me.txtCategory.TabIndex = 52
        Me.txtCategory.Visible = False
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
        Me.GroupBox4.Location = New System.Drawing.Point(201, 605)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(641, 50)
        Me.GroupBox4.TabIndex = 51
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
        'txt_mcode1
        '
        Me.txt_mcode1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mcode1.Location = New System.Drawing.Point(367, 19)
        Me.txt_mcode1.MaxLength = 15
        Me.txt_mcode1.Name = "txt_mcode1"
        Me.txt_mcode1.Size = New System.Drawing.Size(81, 21)
        Me.txt_mcode1.TabIndex = 23
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
        'btn_print
        '
        Me.btn_print.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.ForeColor = System.Drawing.Color.Black
        Me.btn_print.Image = CType(resources.GetObject("btn_print.Image"), System.Drawing.Image)
        Me.btn_print.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_print.Location = New System.Drawing.Point(864, 309)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(137, 50)
        Me.btn_print.TabIndex = 50
        Me.btn_print.Text = "Print [F12]"
        Me.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Image = CType(resources.GetObject("btn_exit.Image"), System.Drawing.Image)
        Me.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_exit.Location = New System.Drawing.Point(864, 368)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(137, 50)
        Me.btn_exit.TabIndex = 49
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
        Me.btn_view.Location = New System.Drawing.Point(864, 250)
        Me.btn_view.Name = "btn_view"
        Me.btn_view.Size = New System.Drawing.Size(137, 50)
        Me.btn_view.TabIndex = 48
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
        Me.btn_clear.Location = New System.Drawing.Point(864, 191)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(137, 50)
        Me.btn_clear.TabIndex = 47
        Me.btn_clear.Tag = ""
        Me.btn_clear.Text = "Clear [F6]"
        Me.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(539, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 15)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Member Category"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(201, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 15)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Member Category"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(183, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 24)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Member Directory"
        '
        'Select_Status
        '
        Me.Select_Status.FormattingEnabled = True
        Me.Select_Status.Items.AddRange(New Object() {"ACTIVE", "INACTIVE", "SUSPENDED", "DEFAULTER", "EXPIRED", "RESIGNED", "TERMINATED", "POSTED"})
        Me.Select_Status.Location = New System.Drawing.Point(539, 173)
        Me.Select_Status.Name = "Select_Status"
        Me.Select_Status.Size = New System.Drawing.Size(308, 229)
        Me.Select_Status.TabIndex = 43
        '
        'Select_Category
        '
        Me.Select_Category.FormattingEnabled = True
        Me.Select_Category.Location = New System.Drawing.Point(197, 173)
        Me.Select_Category.Name = "Select_Category"
        Me.Select_Category.Size = New System.Drawing.Size(326, 229)
        Me.Select_Category.TabIndex = 42
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(542, 150)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(156, 19)
        Me.CheckBox2.TabIndex = 41
        Me.CheckBox2.Text = "Select All / UnSelect All"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(200, 150)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(156, 19)
        Me.CheckBox1.TabIndex = 40
        Me.CheckBox1.Text = "Select All / UnSelect All"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.AddressFilter)
        Me.GroupBox1.Controls.Add(Me.Cmb_add_filter)
        Me.GroupBox1.Location = New System.Drawing.Point(197, 481)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(641, 50)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        '
        'AddressFilter
        '
        Me.AddressFilter.AutoSize = True
        Me.AddressFilter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressFilter.Location = New System.Drawing.Point(104, 19)
        Me.AddressFilter.Name = "AddressFilter"
        Me.AddressFilter.Size = New System.Drawing.Size(86, 15)
        Me.AddressFilter.TabIndex = 1
        Me.AddressFilter.Text = "Address Filter"
        '
        'Cmb_add_filter
        '
        Me.Cmb_add_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_add_filter.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_add_filter.FormattingEnabled = True
        Me.Cmb_add_filter.Items.AddRange(New Object() {"Contact Address", "Permanent Address", "Business Address", "Residence Address"})
        Me.Cmb_add_filter.Location = New System.Drawing.Point(206, 17)
        Me.Cmb_add_filter.Name = "Cmb_add_filter"
        Me.Cmb_add_filter.Size = New System.Drawing.Size(275, 23)
        Me.Cmb_add_filter.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.chk_spsname)
        Me.GroupBox2.Controls.Add(Me.chk_photo)
        Me.GroupBox2.Location = New System.Drawing.Point(200, 546)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(641, 50)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        '
        'chk_spsname
        '
        Me.chk_spsname.AutoSize = True
        Me.chk_spsname.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_spsname.Location = New System.Drawing.Point(263, 19)
        Me.chk_spsname.Name = "chk_spsname"
        Me.chk_spsname.Size = New System.Drawing.Size(105, 19)
        Me.chk_spsname.TabIndex = 1
        Me.chk_spsname.Text = "Spouse Name"
        Me.chk_spsname.UseVisualStyleBackColor = True
        '
        'chk_photo
        '
        Me.chk_photo.AutoSize = True
        Me.chk_photo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_photo.Location = New System.Drawing.Point(104, 19)
        Me.chk_photo.Name = "chk_photo"
        Me.chk_photo.Size = New System.Drawing.Size(88, 19)
        Me.chk_photo.TabIndex = 0
        Me.chk_photo.Text = "With Photo"
        Me.chk_photo.UseVisualStyleBackColor = True
        '
        'frm_rkga_MemberDirectory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_status)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_view)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Select_Status)
        Me.Controls.Add(Me.Select_Category)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.KeyPreview = True
        Me.Name = "frm_rkga_MemberDirectory"
        Me.Text = "frm_rkga_MemberDirectory"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_status As System.Windows.Forms.TextBox
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_mcodehelp1 As System.Windows.Forms.Button
    Friend WithEvents btn_mcodehelp As System.Windows.Forms.Button
    Friend WithEvents txt_mcode1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_mcode2 As System.Windows.Forms.TextBox
    Public WithEvents btn_print As System.Windows.Forms.Button
    Public WithEvents btn_exit As System.Windows.Forms.Button
    Public WithEvents btn_view As System.Windows.Forms.Button
    Public WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Select_Status As System.Windows.Forms.CheckedListBox
    Friend WithEvents Select_Category As System.Windows.Forms.CheckedListBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AddressFilter As System.Windows.Forms.Label
    Friend WithEvents Cmb_add_filter As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_spsname As System.Windows.Forms.CheckBox
    Friend WithEvents chk_photo As System.Windows.Forms.CheckBox
End Class
