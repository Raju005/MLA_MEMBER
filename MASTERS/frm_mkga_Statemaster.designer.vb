<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mkga_Statemaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mkga_Statemaster))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txtcode = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Cbo_PCountry = New System.Windows.Forms.ComboBox()
        Me.cmdMasterHelp = New System.Windows.Forms.Button()
        Me.lbl_freeze = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_view = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_freeze = New System.Windows.Forms.Button()
        Me.btn_addnew = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_authorize = New System.Windows.Forms.Button()
        Me.browse = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Gr2 = New System.Windows.Forms.GroupBox()
        Me.cmd_exit1 = New System.Windows.Forms.Button()
        Me.CMD_WINDOWS = New System.Windows.Forms.Button()
        Me.CMD_DOS = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.Gr2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CODE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "STATE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "COUNTRY"
        '
        'Txtcode
        '
        Me.Txtcode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcode.Location = New System.Drawing.Point(117, 33)
        Me.Txtcode.MaxLength = 8
        Me.Txtcode.Name = "Txtcode"
        Me.Txtcode.Size = New System.Drawing.Size(192, 21)
        Me.Txtcode.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(117, 76)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(241, 21)
        Me.txtName.TabIndex = 3
        '
        'Cbo_PCountry
        '
        Me.Cbo_PCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_PCountry.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_PCountry.FormattingEnabled = True
        Me.Cbo_PCountry.Location = New System.Drawing.Point(117, 123)
        Me.Cbo_PCountry.Name = "Cbo_PCountry"
        Me.Cbo_PCountry.Size = New System.Drawing.Size(241, 23)
        Me.Cbo_PCountry.TabIndex = 4
        '
        'cmdMasterHelp
        '
        Me.cmdMasterHelp.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources._400_F_9130045_3SaKfvCqFL4hRJm59cddsCnbx5YyqvYj
        Me.cmdMasterHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdMasterHelp.Location = New System.Drawing.Point(317, 31)
        Me.cmdMasterHelp.Name = "cmdMasterHelp"
        Me.cmdMasterHelp.Size = New System.Drawing.Size(40, 23)
        Me.cmdMasterHelp.TabIndex = 2
        Me.cmdMasterHelp.UseVisualStyleBackColor = True
        '
        'lbl_freeze
        '
        Me.lbl_freeze.AutoSize = True
        Me.lbl_freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_freeze.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_freeze.Location = New System.Drawing.Point(507, 41)
        Me.lbl_freeze.Name = "lbl_freeze"
        Me.lbl_freeze.Size = New System.Drawing.Size(188, 29)
        Me.lbl_freeze.TabIndex = 7
        Me.lbl_freeze.Text = " Record Voided On"
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.Transparent
        Me.btn_exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Image = CType(resources.GetObject("btn_exit.Image"), System.Drawing.Image)
        Me.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_exit.Location = New System.Drawing.Point(8, 355)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(137, 50)
        Me.btn_exit.TabIndex = 9
        Me.btn_exit.Text = "Exit [F11]"
        Me.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'btn_view
        '
        Me.btn_view.BackColor = System.Drawing.Color.Transparent
        Me.btn_view.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_view.ForeColor = System.Drawing.Color.Black
        Me.btn_view.Image = CType(resources.GetObject("btn_view.Image"), System.Drawing.Image)
        Me.btn_view.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_view.Location = New System.Drawing.Point(5, 185)
        Me.btn_view.Name = "btn_view"
        Me.btn_view.Size = New System.Drawing.Size(137, 50)
        Me.btn_view.TabIndex = 8
        Me.btn_view.Text = "View [F9]"
        Me.btn_view.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_view.UseVisualStyleBackColor = False
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.Transparent
        Me.btn_clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.Color.Black
        Me.btn_clear.Image = CType(resources.GetObject("btn_clear.Image"), System.Drawing.Image)
        Me.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clear.Location = New System.Drawing.Point(5, 17)
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
        Me.btn_freeze.BackColor = System.Drawing.Color.Transparent
        Me.btn_freeze.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_freeze.ForeColor = System.Drawing.Color.Black
        Me.btn_freeze.Image = CType(resources.GetObject("btn_freeze.Image"), System.Drawing.Image)
        Me.btn_freeze.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_freeze.Location = New System.Drawing.Point(5, 129)
        Me.btn_freeze.Name = "btn_freeze"
        Me.btn_freeze.Size = New System.Drawing.Size(137, 50)
        Me.btn_freeze.TabIndex = 7
        Me.btn_freeze.Text = "Void [F8]"
        Me.btn_freeze.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_freeze.UseVisualStyleBackColor = False
        '
        'btn_addnew
        '
        Me.btn_addnew.BackColor = System.Drawing.Color.Transparent
        Me.btn_addnew.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addnew.ForeColor = System.Drawing.Color.Black
        Me.btn_addnew.Image = CType(resources.GetObject("btn_addnew.Image"), System.Drawing.Image)
        Me.btn_addnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_addnew.Location = New System.Drawing.Point(5, 73)
        Me.btn_addnew.Name = "btn_addnew"
        Me.btn_addnew.Size = New System.Drawing.Size(137, 50)
        Me.btn_addnew.TabIndex = 5
        Me.btn_addnew.Text = "Add [F7]"
        Me.btn_addnew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_addnew.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(177, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 25)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "STATE MASTER"
        '
        'btn_authorize
        '
        Me.btn_authorize.BackColor = System.Drawing.Color.Transparent
        Me.btn_authorize.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_authorize.ForeColor = System.Drawing.Color.Black
        Me.btn_authorize.Location = New System.Drawing.Point(8, 297)
        Me.btn_authorize.Name = "btn_authorize"
        Me.btn_authorize.Size = New System.Drawing.Size(137, 50)
        Me.btn_authorize.TabIndex = 11
        Me.btn_authorize.Text = "Authorize"
        Me.btn_authorize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_authorize.UseVisualStyleBackColor = False
        '
        'browse
        '
        Me.browse.BackColor = System.Drawing.Color.Transparent
        Me.browse.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.browse.ForeColor = System.Drawing.Color.Black
        Me.browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.browse.Location = New System.Drawing.Point(5, 241)
        Me.browse.Name = "browse"
        Me.browse.Size = New System.Drawing.Size(137, 50)
        Me.browse.TabIndex = 10
        Me.browse.Text = "Browse"
        Me.browse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.browse.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(865, 185)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(149, 389)
        Me.Panel1.TabIndex = 48
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Txtcode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.cmdMasterHelp)
        Me.GroupBox1.Controls.Add(Me.Cbo_PCountry)
        Me.GroupBox1.Location = New System.Drawing.Point(290, 185)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(405, 174)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(287, 380)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 15)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Press [F4] For Help"
        '
        'Gr2
        '
        Me.Gr2.BackColor = System.Drawing.Color.Transparent
        Me.Gr2.Controls.Add(Me.cmd_exit1)
        Me.Gr2.Controls.Add(Me.CMD_WINDOWS)
        Me.Gr2.Controls.Add(Me.CMD_DOS)
        Me.Gr2.Location = New System.Drawing.Point(290, 417)
        Me.Gr2.Name = "Gr2"
        Me.Gr2.Size = New System.Drawing.Size(405, 85)
        Me.Gr2.TabIndex = 51
        Me.Gr2.TabStop = False
        Me.Gr2.Visible = False
        '
        'cmd_exit1
        '
        Me.cmd_exit1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_exit1.Location = New System.Drawing.Point(265, 27)
        Me.cmd_exit1.Name = "cmd_exit1"
        Me.cmd_exit1.Size = New System.Drawing.Size(100, 30)
        Me.cmd_exit1.TabIndex = 2
        Me.cmd_exit1.Text = "EXIT"
        Me.cmd_exit1.UseVisualStyleBackColor = True
        '
        'CMD_WINDOWS
        '
        Me.CMD_WINDOWS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_WINDOWS.Location = New System.Drawing.Point(154, 26)
        Me.CMD_WINDOWS.Name = "CMD_WINDOWS"
        Me.CMD_WINDOWS.Size = New System.Drawing.Size(100, 30)
        Me.CMD_WINDOWS.TabIndex = 1
        Me.CMD_WINDOWS.Text = "WINDOWS"
        Me.CMD_WINDOWS.UseVisualStyleBackColor = True
        '
        'CMD_DOS
        '
        Me.CMD_DOS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_DOS.Location = New System.Drawing.Point(43, 26)
        Me.CMD_DOS.Name = "CMD_DOS"
        Me.CMD_DOS.Size = New System.Drawing.Size(100, 30)
        Me.CMD_DOS.TabIndex = 0
        Me.CMD_DOS.Text = "DOS"
        Me.CMD_DOS.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btn_exit)
        Me.GroupBox2.Controls.Add(Me.browse)
        Me.GroupBox2.Controls.Add(Me.btn_authorize)
        Me.GroupBox2.Controls.Add(Me.btn_clear)
        Me.GroupBox2.Controls.Add(Me.btn_addnew)
        Me.GroupBox2.Controls.Add(Me.btn_freeze)
        Me.GroupBox2.Controls.Add(Me.btn_view)
        Me.GroupBox2.Location = New System.Drawing.Point(860, 163)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(151, 411)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'frm_mkga_Statemaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Gr2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_freeze)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frm_mkga_Statemaster"
        Me.Text = "frm_mkga_Statemaster"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
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
    Friend WithEvents Txtcode As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Cbo_PCountry As System.Windows.Forms.ComboBox
    Friend WithEvents cmdMasterHelp As System.Windows.Forms.Button
    Friend WithEvents lbl_freeze As System.Windows.Forms.Label
    Public WithEvents btn_exit As System.Windows.Forms.Button
    Public WithEvents btn_view As System.Windows.Forms.Button
    Public WithEvents btn_clear As System.Windows.Forms.Button
    Public WithEvents btn_freeze As System.Windows.Forms.Button
    Public WithEvents btn_addnew As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents btn_authorize As System.Windows.Forms.Button
    Public WithEvents browse As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Gr2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_exit1 As System.Windows.Forms.Button
    Friend WithEvents CMD_WINDOWS As System.Windows.Forms.Button
    Friend WithEvents CMD_DOS As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
