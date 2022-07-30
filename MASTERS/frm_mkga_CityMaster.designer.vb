<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mkga_CityMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mkga_CityMaster))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtcode = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Cbo_PState = New System.Windows.Forms.ComboBox()
        Me.Cbo_PCountry = New System.Windows.Forms.ComboBox()
        Me.btn_help = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_view = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_freeze = New System.Windows.Forms.Button()
        Me.btn_addnew = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_Freeze = New System.Windows.Forms.Label()
        Me.btn_authorize = New System.Windows.Forms.Button()
        Me.BROWSE = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Gr2 = New System.Windows.Forms.GroupBox()
        Me.cmd_exit1 = New System.Windows.Forms.Button()
        Me.CMD_WINDOWS = New System.Windows.Forms.Button()
        Me.CMD_DOS = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Gr2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CODE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CITY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "STATE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "COUNTRY"
        '
        'Txtcode
        '
        Me.Txtcode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcode.Location = New System.Drawing.Point(115, 30)
        Me.Txtcode.MaxLength = 8
        Me.Txtcode.Name = "Txtcode"
        Me.Txtcode.Size = New System.Drawing.Size(167, 21)
        Me.Txtcode.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(115, 72)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(243, 21)
        Me.txtName.TabIndex = 2
        '
        'Cbo_PState
        '
        Me.Cbo_PState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_PState.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_PState.FormattingEnabled = True
        Me.Cbo_PState.Location = New System.Drawing.Point(115, 116)
        Me.Cbo_PState.Name = "Cbo_PState"
        Me.Cbo_PState.Size = New System.Drawing.Size(243, 23)
        Me.Cbo_PState.TabIndex = 4
        '
        'Cbo_PCountry
        '
        Me.Cbo_PCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_PCountry.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_PCountry.FormattingEnabled = True
        Me.Cbo_PCountry.Location = New System.Drawing.Point(115, 160)
        Me.Cbo_PCountry.Name = "Cbo_PCountry"
        Me.Cbo_PCountry.Size = New System.Drawing.Size(243, 23)
        Me.Cbo_PCountry.TabIndex = 5
        '
        'btn_help
        '
        Me.btn_help.BackgroundImage = CType(resources.GetObject("btn_help.BackgroundImage"), System.Drawing.Image)
        Me.btn_help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_help.Location = New System.Drawing.Point(291, 28)
        Me.btn_help.Name = "btn_help"
        Me.btn_help.Size = New System.Drawing.Size(32, 23)
        Me.btn_help.TabIndex = 8
        Me.btn_help.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Image = CType(resources.GetObject("btn_exit.Image"), System.Drawing.Image)
        Me.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_exit.Location = New System.Drawing.Point(8, 347)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(137, 50)
        Me.btn_exit.TabIndex = 10
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
        Me.btn_view.Location = New System.Drawing.Point(8, 183)
        Me.btn_view.Name = "btn_view"
        Me.btn_view.Size = New System.Drawing.Size(137, 50)
        Me.btn_view.TabIndex = 9
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
        Me.btn_clear.Location = New System.Drawing.Point(7, 19)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(137, 50)
        Me.btn_clear.TabIndex = 7
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
        Me.btn_freeze.Location = New System.Drawing.Point(6, 129)
        Me.btn_freeze.Name = "btn_freeze"
        Me.btn_freeze.Size = New System.Drawing.Size(137, 50)
        Me.btn_freeze.TabIndex = 8
        Me.btn_freeze.Text = "Void [F8]"
        Me.btn_freeze.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_freeze.UseVisualStyleBackColor = True
        '
        'btn_addnew
        '
        Me.btn_addnew.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addnew.ForeColor = System.Drawing.Color.Black
        Me.btn_addnew.Image = CType(resources.GetObject("btn_addnew.Image"), System.Drawing.Image)
        Me.btn_addnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_addnew.Location = New System.Drawing.Point(5, 75)
        Me.btn_addnew.Name = "btn_addnew"
        Me.btn_addnew.Size = New System.Drawing.Size(137, 50)
        Me.btn_addnew.TabIndex = 6
        Me.btn_addnew.Text = "Add [F7]"
        Me.btn_addnew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_addnew.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(179, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 25)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "CITY MASTER"
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.AutoSize = True
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(456, 39)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(188, 29)
        Me.lbl_Freeze.TabIndex = 27
        Me.lbl_Freeze.Text = " Record Voided On"
        Me.lbl_Freeze.Visible = False
        '
        'btn_authorize
        '
        Me.btn_authorize.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_authorize.ForeColor = System.Drawing.Color.Black
        Me.btn_authorize.Location = New System.Drawing.Point(8, 292)
        Me.btn_authorize.Name = "btn_authorize"
        Me.btn_authorize.Size = New System.Drawing.Size(137, 50)
        Me.btn_authorize.TabIndex = 12
        Me.btn_authorize.Text = "Authorize"
        Me.btn_authorize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_authorize.UseVisualStyleBackColor = True
        '
        'BROWSE
        '
        Me.BROWSE.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BROWSE.Location = New System.Drawing.Point(8, 237)
        Me.BROWSE.Name = "BROWSE"
        Me.BROWSE.Size = New System.Drawing.Size(137, 50)
        Me.BROWSE.TabIndex = 11
        Me.BROWSE.Text = "Browse"
        Me.BROWSE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BROWSE.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(867, 179)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(141, 391)
        Me.Panel1.TabIndex = 31
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btn_authorize)
        Me.GroupBox2.Controls.Add(Me.btn_clear)
        Me.GroupBox2.Controls.Add(Me.btn_view)
        Me.GroupBox2.Controls.Add(Me.btn_addnew)
        Me.GroupBox2.Controls.Add(Me.btn_freeze)
        Me.GroupBox2.Controls.Add(Me.BROWSE)
        Me.GroupBox2.Controls.Add(Me.btn_exit)
        Me.GroupBox2.Location = New System.Drawing.Point(861, 156)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(140, 426)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Txtcode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_help)
        Me.GroupBox1.Controls.Add(Me.Cbo_PCountry)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Cbo_PState)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(297, 168)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(418, 220)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(294, 404)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 15)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Press [F4] For Help"
        '
        'Gr2
        '
        Me.Gr2.BackColor = System.Drawing.Color.Transparent
        Me.Gr2.Controls.Add(Me.cmd_exit1)
        Me.Gr2.Controls.Add(Me.CMD_WINDOWS)
        Me.Gr2.Controls.Add(Me.CMD_DOS)
        Me.Gr2.Location = New System.Drawing.Point(297, 441)
        Me.Gr2.Name = "Gr2"
        Me.Gr2.Size = New System.Drawing.Size(418, 77)
        Me.Gr2.TabIndex = 52
        Me.Gr2.TabStop = False
        Me.Gr2.Visible = False
        '
        'cmd_exit1
        '
        Me.cmd_exit1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_exit1.Location = New System.Drawing.Point(282, 27)
        Me.cmd_exit1.Name = "cmd_exit1"
        Me.cmd_exit1.Size = New System.Drawing.Size(100, 30)
        Me.cmd_exit1.TabIndex = 2
        Me.cmd_exit1.Text = "EXIT"
        Me.cmd_exit1.UseVisualStyleBackColor = True
        '
        'CMD_WINDOWS
        '
        Me.CMD_WINDOWS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_WINDOWS.Location = New System.Drawing.Point(160, 26)
        Me.CMD_WINDOWS.Name = "CMD_WINDOWS"
        Me.CMD_WINDOWS.Size = New System.Drawing.Size(100, 30)
        Me.CMD_WINDOWS.TabIndex = 1
        Me.CMD_WINDOWS.Text = "WINDOWS"
        Me.CMD_WINDOWS.UseVisualStyleBackColor = True
        '
        'CMD_DOS
        '
        Me.CMD_DOS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_DOS.Location = New System.Drawing.Point(33, 26)
        Me.CMD_DOS.Name = "CMD_DOS"
        Me.CMD_DOS.Size = New System.Drawing.Size(100, 30)
        Me.CMD_DOS.TabIndex = 0
        Me.CMD_DOS.Text = "DOS"
        Me.CMD_DOS.UseVisualStyleBackColor = True
        '
        'frm_mkga_CityMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Gr2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frm_mkga_CityMaster"
        Me.Text = "frm_mkga_CityMaster"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Gr2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txtcode As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Cbo_PState As System.Windows.Forms.ComboBox
    Friend WithEvents Cbo_PCountry As System.Windows.Forms.ComboBox
    Friend WithEvents btn_help As System.Windows.Forms.Button
    Public WithEvents btn_exit As System.Windows.Forms.Button
    Public WithEvents btn_view As System.Windows.Forms.Button
    Public WithEvents btn_clear As System.Windows.Forms.Button
    Public WithEvents btn_freeze As System.Windows.Forms.Button
    Public WithEvents btn_addnew As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Public WithEvents btn_authorize As System.Windows.Forms.Button
    Friend WithEvents BROWSE As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Gr2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_exit1 As System.Windows.Forms.Button
    Friend WithEvents CMD_WINDOWS As System.Windows.Forms.Button
    Friend WithEvents CMD_DOS As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
