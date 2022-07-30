<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DESIGNATION_MASTER
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BUT_AUTHRIZE = New System.Windows.Forms.Button()
        Me.lbl_Freeze = New System.Windows.Forms.Label()
        Me.cmdMasterHelp = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Txtcode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cmd_Exit = New System.Windows.Forms.Button()
        Me.Cmd_View = New System.Windows.Forms.Button()
        Me.Cmd_Freeze = New System.Windows.Forms.Button()
        Me.Cmd_Clear = New System.Windows.Forms.Button()
        Me.Cmd_Add = New System.Windows.Forms.Button()
        Me.BUT_BROWSE = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(179, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 25)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "DESIGNATION MASTER"
        '
        'BUT_AUTHRIZE
        '
        Me.BUT_AUTHRIZE.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUT_AUTHRIZE.ForeColor = System.Drawing.Color.Black
        Me.BUT_AUTHRIZE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BUT_AUTHRIZE.Location = New System.Drawing.Point(6, 310)
        Me.BUT_AUTHRIZE.Name = "BUT_AUTHRIZE"
        Me.BUT_AUTHRIZE.Size = New System.Drawing.Size(137, 50)
        Me.BUT_AUTHRIZE.TabIndex = 49
        Me.BUT_AUTHRIZE.Text = "Authorize"
        Me.BUT_AUTHRIZE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BUT_AUTHRIZE.UseVisualStyleBackColor = True
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.AutoSize = True
        Me.lbl_Freeze.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(661, 43)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(193, 29)
        Me.lbl_Freeze.TabIndex = 48
        Me.lbl_Freeze.Text = "Record Void On"
        '
        'cmdMasterHelp
        '
        Me.cmdMasterHelp.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources._400_F_9130045_3SaKfvCqFL4hRJm59cddsCnbx5YyqvYj
        Me.cmdMasterHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdMasterHelp.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMasterHelp.Location = New System.Drawing.Point(333, 31)
        Me.cmdMasterHelp.Name = "cmdMasterHelp"
        Me.cmdMasterHelp.Size = New System.Drawing.Size(31, 23)
        Me.cmdMasterHelp.TabIndex = 42
        Me.cmdMasterHelp.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(190, 84)
        Me.txtName.MaxLength = 35
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(259, 21)
        Me.txtName.TabIndex = 41
        '
        'Txtcode
        '
        Me.Txtcode.BackColor = System.Drawing.SystemColors.Window
        Me.Txtcode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcode.Location = New System.Drawing.Point(190, 32)
        Me.Txtcode.MaxLength = 6
        Me.Txtcode.Name = "Txtcode"
        Me.Txtcode.Size = New System.Drawing.Size(138, 21)
        Me.Txtcode.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(84, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Description:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(84, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Code:"
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_Exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.Image = Global.Bengal_MemberMaster.My.Resources.Resources._Exit
        Me.Cmd_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Exit.Location = New System.Drawing.Point(6, 371)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(137, 50)
        Me.Cmd_Exit.TabIndex = 47
        Me.Cmd_Exit.Text = "Exit[F11]"
        Me.Cmd_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Exit.UseVisualStyleBackColor = True
        '
        'Cmd_View
        '
        Me.Cmd_View.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_View.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.Image = Global.Bengal_MemberMaster.My.Resources.Resources.view
        Me.Cmd_View.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_View.Location = New System.Drawing.Point(6, 193)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(137, 50)
        Me.Cmd_View.TabIndex = 46
        Me.Cmd_View.Text = " View[F9]"
        Me.Cmd_View.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_View.UseVisualStyleBackColor = True
        '
        'Cmd_Freeze
        '
        Me.Cmd_Freeze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_Freeze.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Freeze.Image = Global.Bengal_MemberMaster.My.Resources.Resources.Delete
        Me.Cmd_Freeze.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Freeze.Location = New System.Drawing.Point(6, 134)
        Me.Cmd_Freeze.Name = "Cmd_Freeze"
        Me.Cmd_Freeze.Size = New System.Drawing.Size(137, 50)
        Me.Cmd_Freeze.TabIndex = 45
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        Me.Cmd_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Freeze.UseVisualStyleBackColor = True
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_Clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.Image = Global.Bengal_MemberMaster.My.Resources.Resources.Clear
        Me.Cmd_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Clear.Location = New System.Drawing.Point(6, 19)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(137, 50)
        Me.Cmd_Clear.TabIndex = 44
        Me.Cmd_Clear.Text = "Clear[F6]"
        Me.Cmd_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Clear.UseVisualStyleBackColor = True
        '
        'Cmd_Add
        '
        Me.Cmd_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cmd_Add.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Add.Image = Global.Bengal_MemberMaster.My.Resources.Resources.save
        Me.Cmd_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Add.Location = New System.Drawing.Point(6, 75)
        Me.Cmd_Add.Name = "Cmd_Add"
        Me.Cmd_Add.Size = New System.Drawing.Size(137, 50)
        Me.Cmd_Add.TabIndex = 43
        Me.Cmd_Add.Text = "Add[F7]"
        Me.Cmd_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Add.UseVisualStyleBackColor = True
        '
        'BUT_BROWSE
        '
        Me.BUT_BROWSE.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUT_BROWSE.ForeColor = System.Drawing.Color.Black
        Me.BUT_BROWSE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BUT_BROWSE.Location = New System.Drawing.Point(6, 252)
        Me.BUT_BROWSE.Name = "BUT_BROWSE"
        Me.BUT_BROWSE.Size = New System.Drawing.Size(137, 50)
        Me.BUT_BROWSE.TabIndex = 51
        Me.BUT_BROWSE.Text = "Browse"
        Me.BUT_BROWSE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BUT_BROWSE.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Txtcode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.cmdMasterHelp)
        Me.GroupBox1.Location = New System.Drawing.Point(260, 159)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 128)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(257, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 15)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Press [F4] For Help"
        '
        'Gr2
        '
        Me.Gr2.BackColor = System.Drawing.Color.Transparent
        Me.Gr2.Controls.Add(Me.cmd_exit1)
        Me.Gr2.Controls.Add(Me.CMD_WINDOWS)
        Me.Gr2.Controls.Add(Me.CMD_DOS)
        Me.Gr2.Location = New System.Drawing.Point(260, 358)
        Me.Gr2.Name = "Gr2"
        Me.Gr2.Size = New System.Drawing.Size(520, 70)
        Me.Gr2.TabIndex = 917
        Me.Gr2.TabStop = False
        Me.Gr2.Visible = False
        '
        'cmd_exit1
        '
        Me.cmd_exit1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_exit1.Location = New System.Drawing.Point(332, 21)
        Me.cmd_exit1.Name = "cmd_exit1"
        Me.cmd_exit1.Size = New System.Drawing.Size(100, 30)
        Me.cmd_exit1.TabIndex = 2
        Me.cmd_exit1.Text = "EXIT"
        Me.cmd_exit1.UseVisualStyleBackColor = True
        '
        'CMD_WINDOWS
        '
        Me.CMD_WINDOWS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_WINDOWS.Location = New System.Drawing.Point(210, 20)
        Me.CMD_WINDOWS.Name = "CMD_WINDOWS"
        Me.CMD_WINDOWS.Size = New System.Drawing.Size(100, 30)
        Me.CMD_WINDOWS.TabIndex = 1
        Me.CMD_WINDOWS.Text = "WINDOWS"
        Me.CMD_WINDOWS.UseVisualStyleBackColor = True
        '
        'CMD_DOS
        '
        Me.CMD_DOS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_DOS.Location = New System.Drawing.Point(85, 20)
        Me.CMD_DOS.Name = "CMD_DOS"
        Me.CMD_DOS.Size = New System.Drawing.Size(100, 30)
        Me.CMD_DOS.TabIndex = 0
        Me.CMD_DOS.Text = "DOS"
        Me.CMD_DOS.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Cmd_Clear)
        Me.GroupBox2.Controls.Add(Me.Cmd_Add)
        Me.GroupBox2.Controls.Add(Me.Cmd_Freeze)
        Me.GroupBox2.Controls.Add(Me.Cmd_View)
        Me.GroupBox2.Controls.Add(Me.BUT_BROWSE)
        Me.GroupBox2.Controls.Add(Me.Cmd_Exit)
        Me.GroupBox2.Controls.Add(Me.BUT_AUTHRIZE)
        Me.GroupBox2.Location = New System.Drawing.Point(855, 159)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(153, 427)
        Me.GroupBox2.TabIndex = 918
        Me.GroupBox2.TabStop = False
        '
        'DESIGNATION_MASTER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources._111in1024res
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Gr2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "DESIGNATION_MASTER"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DESIGNATION_MASTER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Gr2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BUT_AUTHRIZE As System.Windows.Forms.Button
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Freeze As System.Windows.Forms.Button
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents cmdMasterHelp As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Txtcode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BUT_BROWSE As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Gr2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_exit1 As System.Windows.Forms.Button
    Friend WithEvents CMD_WINDOWS As System.Windows.Forms.Button
    Friend WithEvents CMD_DOS As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
