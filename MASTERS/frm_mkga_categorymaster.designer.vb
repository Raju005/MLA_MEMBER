<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mkga_categorymaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mkga_categorymaster))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_ccode = New System.Windows.Forms.Label()
        Me.lbl_cname = New System.Windows.Forms.Label()
        Me.txt_Categorycode = New System.Windows.Forms.TextBox()
        Me.txt_CategoryName = New System.Windows.Forms.TextBox()
        Me.Btn_help = New System.Windows.Forms.Button()
        Me.Lbl_freeze = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_limit = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_authorize = New System.Windows.Forms.Button()
        Me.browse = New System.Windows.Forms.Button()
        Me.btn_view = New System.Windows.Forms.Button()
        Me.btn_freeze = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_addnew = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gr2 = New System.Windows.Forms.GroupBox()
        Me.btn_exit_gr2 = New System.Windows.Forms.Button()
        Me.btn_windows = New System.Windows.Forms.Button()
        Me.btn_dos = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.gr2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(189, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CATEGORY MASTER"
        '
        'lbl_ccode
        '
        Me.lbl_ccode.AutoSize = True
        Me.lbl_ccode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ccode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ccode.ForeColor = System.Drawing.Color.Black
        Me.lbl_ccode.Location = New System.Drawing.Point(333, 204)
        Me.lbl_ccode.Name = "lbl_ccode"
        Me.lbl_ccode.Size = New System.Drawing.Size(90, 15)
        Me.lbl_ccode.TabIndex = 1
        Me.lbl_ccode.Text = "Category Code"
        '
        'lbl_cname
        '
        Me.lbl_cname.AutoSize = True
        Me.lbl_cname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cname.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cname.ForeColor = System.Drawing.Color.Black
        Me.lbl_cname.Location = New System.Drawing.Point(333, 246)
        Me.lbl_cname.Name = "lbl_cname"
        Me.lbl_cname.Size = New System.Drawing.Size(94, 15)
        Me.lbl_cname.TabIndex = 2
        Me.lbl_cname.Text = "Category Name"
        '
        'txt_Categorycode
        '
        Me.txt_Categorycode.AllowDrop = True
        Me.txt_Categorycode.AutoCompleteCustomSource.AddRange(New String() {"a", "aa", "aa", "b"})
        Me.txt_Categorycode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Categorycode.Location = New System.Drawing.Point(454, 203)
        Me.txt_Categorycode.MaxLength = 8
        Me.txt_Categorycode.Name = "txt_Categorycode"
        Me.txt_Categorycode.Size = New System.Drawing.Size(126, 21)
        Me.txt_Categorycode.TabIndex = 1
        '
        'txt_CategoryName
        '
        Me.txt_CategoryName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CategoryName.Location = New System.Drawing.Point(454, 240)
        Me.txt_CategoryName.MaxLength = 40
        Me.txt_CategoryName.Name = "txt_CategoryName"
        Me.txt_CategoryName.Size = New System.Drawing.Size(226, 21)
        Me.txt_CategoryName.TabIndex = 3
        '
        'Btn_help
        '
        Me.Btn_help.BackColor = System.Drawing.Color.Transparent
        Me.Btn_help.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources._400_F_9130045_3SaKfvCqFL4hRJm59cddsCnbx5YyqvYj
        Me.Btn_help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_help.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_help.ForeColor = System.Drawing.Color.Black
        Me.Btn_help.Location = New System.Drawing.Point(587, 202)
        Me.Btn_help.Name = "Btn_help"
        Me.Btn_help.Size = New System.Drawing.Size(40, 23)
        Me.Btn_help.TabIndex = 2
        Me.Btn_help.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_help.UseVisualStyleBackColor = False
        '
        'Lbl_freeze
        '
        Me.Lbl_freeze.AutoSize = True
        Me.Lbl_freeze.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_freeze.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_freeze.ForeColor = System.Drawing.Color.Red
        Me.Lbl_freeze.Location = New System.Drawing.Point(457, 40)
        Me.Lbl_freeze.Name = "Lbl_freeze"
        Me.Lbl_freeze.Size = New System.Drawing.Size(188, 29)
        Me.Lbl_freeze.TabIndex = 14
        Me.Lbl_freeze.Text = " Record Voided On"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(480, 526)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 35)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "CRYSTAL REPORT"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'txt_limit
        '
        Me.txt_limit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_limit.Location = New System.Drawing.Point(169, 133)
        Me.txt_limit.MaxLength = 5
        Me.txt_limit.Name = "txt_limit"
        Me.txt_limit.Size = New System.Drawing.Size(126, 21)
        Me.txt_limit.TabIndex = 4
        Me.txt_limit.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txt_limit)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(281, 141)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(425, 207)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(61, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Yearly Limit"
        Me.Label2.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(860, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(2, 2)
        Me.Panel1.TabIndex = 21
        '
        'btn_exit
        '
        Me.btn_exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Image = CType(resources.GetObject("btn_exit.Image"), System.Drawing.Image)
        Me.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_exit.Location = New System.Drawing.Point(4, 363)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(137, 50)
        Me.btn_exit.TabIndex = 16
        Me.btn_exit.Text = "Exit [F11]"
        Me.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_authorize
        '
        Me.btn_authorize.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_authorize.ForeColor = System.Drawing.Color.Black
        Me.btn_authorize.Location = New System.Drawing.Point(5, 306)
        Me.btn_authorize.Name = "btn_authorize"
        Me.btn_authorize.Size = New System.Drawing.Size(137, 50)
        Me.btn_authorize.TabIndex = 18
        Me.btn_authorize.Text = "Authorize"
        Me.btn_authorize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_authorize.UseVisualStyleBackColor = True
        '
        'browse
        '
        Me.browse.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.browse.ForeColor = System.Drawing.Color.Black
        Me.browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.browse.Location = New System.Drawing.Point(5, 247)
        Me.browse.Name = "browse"
        Me.browse.Size = New System.Drawing.Size(137, 50)
        Me.browse.TabIndex = 17
        Me.browse.Text = "Browse"
        Me.browse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.browse.UseVisualStyleBackColor = True
        '
        'btn_view
        '
        Me.btn_view.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_view.ForeColor = System.Drawing.Color.Black
        Me.btn_view.Image = CType(resources.GetObject("btn_view.Image"), System.Drawing.Image)
        Me.btn_view.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_view.Location = New System.Drawing.Point(5, 191)
        Me.btn_view.Name = "btn_view"
        Me.btn_view.Size = New System.Drawing.Size(137, 50)
        Me.btn_view.TabIndex = 15
        Me.btn_view.Text = "View [F9]"
        Me.btn_view.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_view.UseVisualStyleBackColor = True
        '
        'btn_freeze
        '
        Me.btn_freeze.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_freeze.ForeColor = System.Drawing.Color.Black
        Me.btn_freeze.Image = CType(resources.GetObject("btn_freeze.Image"), System.Drawing.Image)
        Me.btn_freeze.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_freeze.Location = New System.Drawing.Point(5, 134)
        Me.btn_freeze.Name = "btn_freeze"
        Me.btn_freeze.Size = New System.Drawing.Size(137, 50)
        Me.btn_freeze.TabIndex = 14
        Me.btn_freeze.Text = "Void [F8]"
        Me.btn_freeze.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_freeze.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.Transparent
        Me.btn_clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.Color.Black
        Me.btn_clear.Image = CType(resources.GetObject("btn_clear.Image"), System.Drawing.Image)
        Me.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clear.Location = New System.Drawing.Point(4, 16)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(137, 50)
        Me.btn_clear.TabIndex = 13
        Me.btn_clear.Tag = ""
        Me.btn_clear.Text = "Clear [F6]"
        Me.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_addnew
        '
        Me.btn_addnew.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addnew.ForeColor = System.Drawing.Color.Black
        Me.btn_addnew.Image = CType(resources.GetObject("btn_addnew.Image"), System.Drawing.Image)
        Me.btn_addnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_addnew.Location = New System.Drawing.Point(5, 73)
        Me.btn_addnew.Name = "btn_addnew"
        Me.btn_addnew.Size = New System.Drawing.Size(137, 50)
        Me.btn_addnew.TabIndex = 12
        Me.btn_addnew.Text = "Add [F7]"
        Me.btn_addnew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_addnew.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(288, 370)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 15)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Press [F4] For Help"
        '
        'gr2
        '
        Me.gr2.BackColor = System.Drawing.Color.Transparent
        Me.gr2.Controls.Add(Me.btn_exit_gr2)
        Me.gr2.Controls.Add(Me.btn_windows)
        Me.gr2.Controls.Add(Me.btn_dos)
        Me.gr2.Location = New System.Drawing.Point(288, 398)
        Me.gr2.Name = "gr2"
        Me.gr2.Size = New System.Drawing.Size(406, 81)
        Me.gr2.TabIndex = 23
        Me.gr2.TabStop = False
        '
        'btn_exit_gr2
        '
        Me.btn_exit_gr2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit_gr2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btn_exit_gr2.Location = New System.Drawing.Point(278, 30)
        Me.btn_exit_gr2.Name = "btn_exit_gr2"
        Me.btn_exit_gr2.Size = New System.Drawing.Size(100, 30)
        Me.btn_exit_gr2.TabIndex = 2
        Me.btn_exit_gr2.Text = "EXIT"
        Me.btn_exit_gr2.UseVisualStyleBackColor = True
        '
        'btn_windows
        '
        Me.btn_windows.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_windows.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btn_windows.Location = New System.Drawing.Point(157, 30)
        Me.btn_windows.Name = "btn_windows"
        Me.btn_windows.Size = New System.Drawing.Size(100, 30)
        Me.btn_windows.TabIndex = 1
        Me.btn_windows.Text = "WINDOWS"
        Me.btn_windows.UseVisualStyleBackColor = True
        '
        'btn_dos
        '
        Me.btn_dos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dos.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btn_dos.Location = New System.Drawing.Point(34, 30)
        Me.btn_dos.Name = "btn_dos"
        Me.btn_dos.Size = New System.Drawing.Size(100, 30)
        Me.btn_dos.TabIndex = 0
        Me.btn_dos.Text = "DOS"
        Me.btn_dos.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.btn_exit)
        Me.GroupBox4.Controls.Add(Me.btn_clear)
        Me.GroupBox4.Controls.Add(Me.btn_authorize)
        Me.GroupBox4.Controls.Add(Me.btn_addnew)
        Me.GroupBox4.Controls.Add(Me.browse)
        Me.GroupBox4.Controls.Add(Me.btn_freeze)
        Me.GroupBox4.Controls.Add(Me.btn_view)
        Me.GroupBox4.Location = New System.Drawing.Point(858, 128)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(145, 422)
        Me.GroupBox4.TabIndex = 126
        Me.GroupBox4.TabStop = False
        '
        'frm_mkga_categorymaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1015, 743)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.gr2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Lbl_freeze)
        Me.Controls.Add(Me.Btn_help)
        Me.Controls.Add(Me.txt_CategoryName)
        Me.Controls.Add(Me.txt_Categorycode)
        Me.Controls.Add(Me.lbl_cname)
        Me.Controls.Add(Me.lbl_ccode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frm_mkga_categorymaster"
        Me.Text = "CATEGORY MASTER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gr2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_ccode As System.Windows.Forms.Label
    Friend WithEvents lbl_cname As System.Windows.Forms.Label
    Friend WithEvents txt_Categorycode As System.Windows.Forms.TextBox
    Friend WithEvents txt_CategoryName As System.Windows.Forms.TextBox
    Friend WithEvents Btn_help As System.Windows.Forms.Button
    Friend WithEvents NAME1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lbl_freeze As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_limit As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents btn_exit As System.Windows.Forms.Button
    Public WithEvents btn_authorize As System.Windows.Forms.Button
    Public WithEvents browse As System.Windows.Forms.Button
    Public WithEvents btn_view As System.Windows.Forms.Button
    Public WithEvents btn_freeze As System.Windows.Forms.Button
    Public WithEvents btn_clear As System.Windows.Forms.Button
    Public WithEvents btn_addnew As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gr2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_exit_gr2 As System.Windows.Forms.Button
    Friend WithEvents btn_windows As System.Windows.Forms.Button
    Friend WithEvents btn_dos As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox

End Class
