<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_tkga_CategoryConversion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tkga_CategoryConversion))
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_view = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_addnew = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtmembercode = New System.Windows.Forms.TextBox()
        Me.commembertype = New System.Windows.Forms.ComboBox()
        Me.mname = New System.Windows.Forms.Label()
        Me.oldmembertype = New System.Windows.Forms.Label()
        Me.CMbo_reasons = New System.Windows.Forms.ComboBox()
        Me.dtpdate = New System.Windows.Forms.DateTimePicker()
        Me.browse = New System.Windows.Forms.Button()
        Me.btn_authorize = New System.Windows.Forms.Button()
        Me.btn_mcodehelp = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GR2 = New System.Windows.Forms.GroupBox()
        Me.BTN_EXIT_GR2 = New System.Windows.Forms.Button()
        Me.BTN_WINDOWS = New System.Windows.Forms.Button()
        Me.BTN_DOS = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GR2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_exit
        '
        Me.btn_exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Image = CType(resources.GetObject("btn_exit.Image"), System.Drawing.Image)
        Me.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_exit.Location = New System.Drawing.Point(3, 289)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_exit.Size = New System.Drawing.Size(137, 50)
        Me.btn_exit.TabIndex = 9
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
        Me.btn_view.Location = New System.Drawing.Point(3, 128)
        Me.btn_view.Name = "btn_view"
        Me.btn_view.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_view.Size = New System.Drawing.Size(137, 50)
        Me.btn_view.TabIndex = 8
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
        Me.btn_clear.Location = New System.Drawing.Point(3, 15)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_clear.Size = New System.Drawing.Size(137, 50)
        Me.btn_clear.TabIndex = 7
        Me.btn_clear.Tag = ""
        Me.btn_clear.Text = "Clear [F6]"
        Me.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_addnew
        '
        Me.btn_addnew.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addnew.ForeColor = System.Drawing.Color.Black
        Me.btn_addnew.Image = CType(resources.GetObject("btn_addnew.Image"), System.Drawing.Image)
        Me.btn_addnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_addnew.Location = New System.Drawing.Point(3, 72)
        Me.btn_addnew.Name = "btn_addnew"
        Me.btn_addnew.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_addnew.Size = New System.Drawing.Size(137, 50)
        Me.btn_addnew.TabIndex = 6
        Me.btn_addnew.Text = "Add [F7]"
        Me.btn_addnew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_addnew.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 25)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "CATEGORY CONVERSION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 15)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Member Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 15)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Member Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 15)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Member Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 15)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "New Member Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(37, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 15)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Effective From"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(37, 275)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 15)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Reason"
        '
        'txtmembercode
        '
        Me.txtmembercode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmembercode.Location = New System.Drawing.Point(160, 44)
        Me.txtmembercode.MaxLength = 15
        Me.txtmembercode.Name = "txtmembercode"
        Me.txtmembercode.Size = New System.Drawing.Size(100, 21)
        Me.txtmembercode.TabIndex = 1
        '
        'commembertype
        '
        Me.commembertype.BackColor = System.Drawing.Color.White
        Me.commembertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.commembertype.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.commembertype.FormattingEnabled = True
        Me.commembertype.Items.AddRange(New Object() {""})
        Me.commembertype.Location = New System.Drawing.Point(160, 183)
        Me.commembertype.Name = "commembertype"
        Me.commembertype.Size = New System.Drawing.Size(301, 23)
        Me.commembertype.TabIndex = 3
        '
        'mname
        '
        Me.mname.BackColor = System.Drawing.Color.White
        Me.mname.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mname.Location = New System.Drawing.Point(160, 91)
        Me.mname.Name = "mname"
        Me.mname.Size = New System.Drawing.Size(294, 21)
        Me.mname.TabIndex = 33
        Me.mname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'oldmembertype
        '
        Me.oldmembertype.BackColor = System.Drawing.Color.White
        Me.oldmembertype.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oldmembertype.Location = New System.Drawing.Point(160, 132)
        Me.oldmembertype.Name = "oldmembertype"
        Me.oldmembertype.Size = New System.Drawing.Size(294, 21)
        Me.oldmembertype.TabIndex = 34
        Me.oldmembertype.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CMbo_reasons
        '
        Me.CMbo_reasons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMbo_reasons.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMbo_reasons.FormattingEnabled = True
        Me.CMbo_reasons.Location = New System.Drawing.Point(160, 271)
        Me.CMbo_reasons.Name = "CMbo_reasons"
        Me.CMbo_reasons.Size = New System.Drawing.Size(301, 23)
        Me.CMbo_reasons.TabIndex = 5
        '
        'dtpdate
        '
        Me.dtpdate.CustomFormat = "dd/MM/yyyy"
        Me.dtpdate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdate.Location = New System.Drawing.Point(160, 229)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Size = New System.Drawing.Size(135, 21)
        Me.dtpdate.TabIndex = 4
        '
        'browse
        '
        Me.browse.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.browse.ForeColor = System.Drawing.Color.Black
        Me.browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.browse.Location = New System.Drawing.Point(3, 181)
        Me.browse.Name = "browse"
        Me.browse.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.browse.Size = New System.Drawing.Size(137, 50)
        Me.browse.TabIndex = 10
        Me.browse.Text = "Browse"
        Me.browse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.browse.UseVisualStyleBackColor = True
        '
        'btn_authorize
        '
        Me.btn_authorize.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_authorize.ForeColor = System.Drawing.Color.Black
        Me.btn_authorize.Location = New System.Drawing.Point(3, 235)
        Me.btn_authorize.Name = "btn_authorize"
        Me.btn_authorize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_authorize.Size = New System.Drawing.Size(137, 50)
        Me.btn_authorize.TabIndex = 11
        Me.btn_authorize.Text = "Authorize"
        Me.btn_authorize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_authorize.UseVisualStyleBackColor = True
        '
        'btn_mcodehelp
        '
        Me.btn_mcodehelp.BackColor = System.Drawing.Color.Transparent
        Me.btn_mcodehelp.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources._400_F_9130045_3SaKfvCqFL4hRJm59cddsCnbx5YyqvYj
        Me.btn_mcodehelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_mcodehelp.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mcodehelp.ForeColor = System.Drawing.Color.Black
        Me.btn_mcodehelp.Location = New System.Drawing.Point(265, 43)
        Me.btn_mcodehelp.Name = "btn_mcodehelp"
        Me.btn_mcodehelp.Size = New System.Drawing.Size(40, 23)
        Me.btn_mcodehelp.TabIndex = 2
        Me.btn_mcodehelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_mcodehelp.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(859, 152)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(148, 369)
        Me.Panel1.TabIndex = 41
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.mname)
        Me.GroupBox1.Controls.Add(Me.btn_mcodehelp)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpdate)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CMbo_reasons)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.oldmembertype)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.commembertype)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtmembercode)
        Me.GroupBox1.Location = New System.Drawing.Point(271, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(489, 344)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        '
        'GR2
        '
        Me.GR2.BackColor = System.Drawing.Color.Transparent
        Me.GR2.Controls.Add(Me.BTN_EXIT_GR2)
        Me.GR2.Controls.Add(Me.BTN_WINDOWS)
        Me.GR2.Controls.Add(Me.BTN_DOS)
        Me.GR2.Location = New System.Drawing.Point(271, 527)
        Me.GR2.Name = "GR2"
        Me.GR2.Size = New System.Drawing.Size(489, 77)
        Me.GR2.TabIndex = 43
        Me.GR2.TabStop = False
        '
        'BTN_EXIT_GR2
        '
        Me.BTN_EXIT_GR2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EXIT_GR2.Location = New System.Drawing.Point(317, 27)
        Me.BTN_EXIT_GR2.Name = "BTN_EXIT_GR2"
        Me.BTN_EXIT_GR2.Size = New System.Drawing.Size(100, 30)
        Me.BTN_EXIT_GR2.TabIndex = 2
        Me.BTN_EXIT_GR2.Text = "EXIT"
        Me.BTN_EXIT_GR2.UseVisualStyleBackColor = True
        '
        'BTN_WINDOWS
        '
        Me.BTN_WINDOWS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_WINDOWS.Location = New System.Drawing.Point(192, 27)
        Me.BTN_WINDOWS.Name = "BTN_WINDOWS"
        Me.BTN_WINDOWS.Size = New System.Drawing.Size(100, 30)
        Me.BTN_WINDOWS.TabIndex = 1
        Me.BTN_WINDOWS.Text = "WINDOWS"
        Me.BTN_WINDOWS.UseVisualStyleBackColor = True
        '
        'BTN_DOS
        '
        Me.BTN_DOS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DOS.Location = New System.Drawing.Point(64, 27)
        Me.BTN_DOS.Name = "BTN_DOS"
        Me.BTN_DOS.Size = New System.Drawing.Size(100, 30)
        Me.BTN_DOS.TabIndex = 0
        Me.BTN_DOS.Text = "DOS"
        Me.BTN_DOS.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btn_addnew)
        Me.GroupBox2.Controls.Add(Me.btn_clear)
        Me.GroupBox2.Controls.Add(Me.browse)
        Me.GroupBox2.Controls.Add(Me.btn_exit)
        Me.GroupBox2.Controls.Add(Me.btn_view)
        Me.GroupBox2.Controls.Add(Me.btn_authorize)
        Me.GroupBox2.Location = New System.Drawing.Point(859, 155)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(144, 341)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(187, 72)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(232, 34)
        Me.GroupBox3.TabIndex = 45
        Me.GroupBox3.TabStop = False
        '
        'frm_tkga_CategoryConversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GR2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "frm_tkga_CategoryConversion"
        Me.Text = "frm_tkga_CategoryConversion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GR2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents btn_exit As System.Windows.Forms.Button
    Public WithEvents btn_view As System.Windows.Forms.Button
    Public WithEvents btn_clear As System.Windows.Forms.Button
    Public WithEvents btn_addnew As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtmembercode As System.Windows.Forms.TextBox
    Friend WithEvents commembertype As System.Windows.Forms.ComboBox
    Friend WithEvents mname As System.Windows.Forms.Label
    Friend WithEvents oldmembertype As System.Windows.Forms.Label
    Friend WithEvents CMbo_reasons As System.Windows.Forms.ComboBox
    Friend WithEvents dtpdate As System.Windows.Forms.DateTimePicker
    Public WithEvents browse As System.Windows.Forms.Button
    Public WithEvents btn_authorize As System.Windows.Forms.Button
    Friend WithEvents btn_mcodehelp As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GR2 As System.Windows.Forms.GroupBox
    Friend WithEvents BTN_EXIT_GR2 As System.Windows.Forms.Button
    Friend WithEvents BTN_WINDOWS As System.Windows.Forms.Button
    Friend WithEvents BTN_DOS As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
