<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mkga_countrymaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mkga_countrymaster))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.txt_desc = New System.Windows.Forms.TextBox()
        Me.lbl_Freeze = New System.Windows.Forms.Label()
        Me.Btn_help = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_view = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_freeze = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_authorize = New System.Windows.Forms.Button()
        Me.browse = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Gr2 = New System.Windows.Forms.GroupBox()
        Me.cmd_exit1 = New System.Windows.Forms.Button()
        Me.CMD_WINDOWS = New System.Windows.Forms.Button()
        Me.CMD_DOS = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Gr2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(178, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COUNTRY MASTER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CODE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "COUNTRY NAME"
        '
        'txt_code
        '
        Me.txt_code.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_code.Location = New System.Drawing.Point(135, 38)
        Me.txt_code.MaxLength = 8
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(100, 21)
        Me.txt_code.TabIndex = 1
        '
        'txt_desc
        '
        Me.txt_desc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_desc.Location = New System.Drawing.Point(135, 93)
        Me.txt_desc.MaxLength = 50
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.Size = New System.Drawing.Size(169, 21)
        Me.txt_desc.TabIndex = 3
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.AutoSize = True
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(475, 40)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(188, 29)
        Me.lbl_Freeze.TabIndex = 5
        Me.lbl_Freeze.Text = " Record Voided On"
        Me.lbl_Freeze.Visible = False
        '
        'Btn_help
        '
        Me.Btn_help.BackColor = System.Drawing.Color.Transparent
        Me.Btn_help.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources._400_F_9130045_3SaKfvCqFL4hRJm59cddsCnbx5YyqvYj
        Me.Btn_help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_help.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_help.ForeColor = System.Drawing.Color.Black
        Me.Btn_help.Location = New System.Drawing.Point(242, 36)
        Me.Btn_help.Name = "Btn_help"
        Me.Btn_help.Size = New System.Drawing.Size(40, 23)
        Me.Btn_help.TabIndex = 2
        Me.Btn_help.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_help.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Image = CType(resources.GetObject("btn_exit.Image"), System.Drawing.Image)
        Me.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_exit.Location = New System.Drawing.Point(4, 329)
        Me.btn_exit.Name = "btn_exit"
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
        Me.btn_view.Location = New System.Drawing.Point(4, 172)
        Me.btn_view.Name = "btn_view"
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
        Me.btn_clear.Location = New System.Drawing.Point(4, 8)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(137, 50)
        Me.btn_clear.TabIndex = 6
        Me.btn_clear.Tag = ""
        Me.btn_clear.Text = "Clear [F6]"
        Me.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_freeze
        '
        Me.btn_freeze.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_freeze.ForeColor = System.Drawing.Color.Black
        Me.btn_freeze.Image = CType(resources.GetObject("btn_freeze.Image"), System.Drawing.Image)
        Me.btn_freeze.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_freeze.Location = New System.Drawing.Point(4, 118)
        Me.btn_freeze.Name = "btn_freeze"
        Me.btn_freeze.Size = New System.Drawing.Size(137, 50)
        Me.btn_freeze.TabIndex = 7
        Me.btn_freeze.Text = "Void [F8]"
        Me.btn_freeze.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_freeze.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.Black
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add.Location = New System.Drawing.Point(4, 62)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(137, 50)
        Me.btn_add.TabIndex = 5
        Me.btn_add.Text = "Add [F7]"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_authorize
        '
        Me.btn_authorize.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_authorize.ForeColor = System.Drawing.Color.Black
        Me.btn_authorize.Location = New System.Drawing.Point(4, 276)
        Me.btn_authorize.Name = "btn_authorize"
        Me.btn_authorize.Size = New System.Drawing.Size(137, 50)
        Me.btn_authorize.TabIndex = 11
        Me.btn_authorize.Text = "Authorize"
        Me.btn_authorize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_authorize.UseVisualStyleBackColor = True
        '
        'browse
        '
        Me.browse.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.browse.ForeColor = System.Drawing.Color.Black
        Me.browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.browse.Location = New System.Drawing.Point(4, 224)
        Me.browse.Name = "browse"
        Me.browse.Size = New System.Drawing.Size(137, 50)
        Me.browse.TabIndex = 10
        Me.browse.Text = "Browse"
        Me.browse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.browse.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btn_authorize)
        Me.Panel1.Controls.Add(Me.browse)
        Me.Panel1.Controls.Add(Me.btn_add)
        Me.Panel1.Controls.Add(Me.btn_exit)
        Me.Panel1.Controls.Add(Me.btn_freeze)
        Me.Panel1.Controls.Add(Me.btn_view)
        Me.Panel1.Controls.Add(Me.btn_clear)
        Me.Panel1.Location = New System.Drawing.Point(0, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(148, 392)
        Me.Panel1.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txt_code)
        Me.GroupBox1.Controls.Add(Me.Btn_help)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_desc)
        Me.GroupBox1.Location = New System.Drawing.Point(318, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 160)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(315, 360)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 15)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Press [F4] For Help"
        '
        'Gr2
        '
        Me.Gr2.BackColor = System.Drawing.Color.Transparent
        Me.Gr2.Controls.Add(Me.cmd_exit1)
        Me.Gr2.Controls.Add(Me.CMD_WINDOWS)
        Me.Gr2.Controls.Add(Me.CMD_DOS)
        Me.Gr2.Location = New System.Drawing.Point(318, 394)
        Me.Gr2.Name = "Gr2"
        Me.Gr2.Size = New System.Drawing.Size(363, 84)
        Me.Gr2.TabIndex = 26
        Me.Gr2.TabStop = False
        Me.Gr2.Visible = False
        '
        'cmd_exit1
        '
        Me.cmd_exit1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_exit1.Location = New System.Drawing.Point(247, 26)
        Me.cmd_exit1.Name = "cmd_exit1"
        Me.cmd_exit1.Size = New System.Drawing.Size(100, 30)
        Me.cmd_exit1.TabIndex = 2
        Me.cmd_exit1.Text = "EXIT"
        Me.cmd_exit1.UseVisualStyleBackColor = True
        '
        'CMD_WINDOWS
        '
        Me.CMD_WINDOWS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_WINDOWS.Location = New System.Drawing.Point(135, 26)
        Me.CMD_WINDOWS.Name = "CMD_WINDOWS"
        Me.CMD_WINDOWS.Size = New System.Drawing.Size(100, 30)
        Me.CMD_WINDOWS.TabIndex = 1
        Me.CMD_WINDOWS.Text = "WINDOWS"
        Me.CMD_WINDOWS.UseVisualStyleBackColor = True
        '
        'CMD_DOS
        '
        Me.CMD_DOS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_DOS.Location = New System.Drawing.Point(21, 26)
        Me.CMD_DOS.Name = "CMD_DOS"
        Me.CMD_DOS.Size = New System.Drawing.Size(100, 30)
        Me.CMD_DOS.TabIndex = 0
        Me.CMD_DOS.Text = "DOS"
        Me.CMD_DOS.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Location = New System.Drawing.Point(861, 150)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(143, 399)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        '
        'frm_mkga_countrymaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Gr2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frm_mkga_countrymaster"
        Me.Text = "frm_mkga_countrymaster"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Gr2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_code As System.Windows.Forms.TextBox
    Friend WithEvents txt_desc As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents Btn_help As System.Windows.Forms.Button
    Public WithEvents btn_exit As System.Windows.Forms.Button
    Public WithEvents btn_view As System.Windows.Forms.Button
    Public WithEvents btn_clear As System.Windows.Forms.Button
    Public WithEvents btn_freeze As System.Windows.Forms.Button
    Public WithEvents btn_add As System.Windows.Forms.Button
    Public WithEvents btn_authorize As System.Windows.Forms.Button
    Public WithEvents browse As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Gr2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_exit1 As System.Windows.Forms.Button
    Friend WithEvents CMD_WINDOWS As System.Windows.Forms.Button
    Friend WithEvents CMD_DOS As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
