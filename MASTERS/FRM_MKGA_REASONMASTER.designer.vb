<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_MKGA_REASONMASTER
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_MKGA_REASONMASTER))
        Me.Txtcode = New System.Windows.Forms.TextBox()
        Me.LBL_CODE = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.CODE_HELP = New System.Windows.Forms.Button()
        Me.CMD_CLR = New System.Windows.Forms.Button()
        Me.CMD_ADD = New System.Windows.Forms.Button()
        Me.CMD_FREEZE = New System.Windows.Forms.Button()
        Me.CMD_EXIT = New System.Windows.Forms.Button()
        Me.lbl_Freeze = New System.Windows.Forms.Label()
        Me.Cmd_view = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        'Txtcode
        '
        Me.Txtcode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcode.Location = New System.Drawing.Point(121, 32)
        Me.Txtcode.MaxLength = 10
        Me.Txtcode.Name = "Txtcode"
        Me.Txtcode.Size = New System.Drawing.Size(130, 21)
        Me.Txtcode.TabIndex = 0
        '
        'LBL_CODE
        '
        Me.LBL_CODE.AutoSize = True
        Me.LBL_CODE.BackColor = System.Drawing.Color.Transparent
        Me.LBL_CODE.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CODE.Location = New System.Drawing.Point(23, 34)
        Me.LBL_CODE.Name = "LBL_CODE"
        Me.LBL_CODE.Size = New System.Drawing.Size(39, 15)
        Me.LBL_CODE.TabIndex = 1
        Me.LBL_CODE.Text = "Code "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Description"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(121, 88)
        Me.txtName.MaxLength = 40
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(174, 21)
        Me.txtName.TabIndex = 3
        '
        'CODE_HELP
        '
        Me.CODE_HELP.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources._400_F_9130045_3SaKfvCqFL4hRJm59cddsCnbx5YyqvYj
        Me.CODE_HELP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CODE_HELP.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CODE_HELP.Location = New System.Drawing.Point(262, 31)
        Me.CODE_HELP.Name = "CODE_HELP"
        Me.CODE_HELP.Size = New System.Drawing.Size(40, 23)
        Me.CODE_HELP.TabIndex = 5
        Me.CODE_HELP.UseVisualStyleBackColor = True
        '
        'CMD_CLR
        '
        Me.CMD_CLR.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_CLR.Image = CType(resources.GetObject("CMD_CLR.Image"), System.Drawing.Image)
        Me.CMD_CLR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CMD_CLR.Location = New System.Drawing.Point(10, 11)
        Me.CMD_CLR.Name = "CMD_CLR"
        Me.CMD_CLR.Size = New System.Drawing.Size(137, 50)
        Me.CMD_CLR.TabIndex = 6
        Me.CMD_CLR.Text = "Clear[F6]"
        Me.CMD_CLR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CMD_CLR.UseVisualStyleBackColor = True
        '
        'CMD_ADD
        '
        Me.CMD_ADD.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_ADD.Image = CType(resources.GetObject("CMD_ADD.Image"), System.Drawing.Image)
        Me.CMD_ADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CMD_ADD.Location = New System.Drawing.Point(10, 80)
        Me.CMD_ADD.Name = "CMD_ADD"
        Me.CMD_ADD.Size = New System.Drawing.Size(137, 50)
        Me.CMD_ADD.TabIndex = 7
        Me.CMD_ADD.Text = "Add[F7]"
        Me.CMD_ADD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CMD_ADD.UseVisualStyleBackColor = True
        '
        'CMD_FREEZE
        '
        Me.CMD_FREEZE.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_FREEZE.Image = CType(resources.GetObject("CMD_FREEZE.Image"), System.Drawing.Image)
        Me.CMD_FREEZE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CMD_FREEZE.Location = New System.Drawing.Point(10, 222)
        Me.CMD_FREEZE.Name = "CMD_FREEZE"
        Me.CMD_FREEZE.Size = New System.Drawing.Size(137, 50)
        Me.CMD_FREEZE.TabIndex = 8
        Me.CMD_FREEZE.Text = "Void[F8]"
        Me.CMD_FREEZE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CMD_FREEZE.UseVisualStyleBackColor = True
        '
        'CMD_EXIT
        '
        Me.CMD_EXIT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_EXIT.Image = CType(resources.GetObject("CMD_EXIT.Image"), System.Drawing.Image)
        Me.CMD_EXIT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CMD_EXIT.Location = New System.Drawing.Point(10, 353)
        Me.CMD_EXIT.Name = "CMD_EXIT"
        Me.CMD_EXIT.Size = New System.Drawing.Size(137, 50)
        Me.CMD_EXIT.TabIndex = 9
        Me.CMD_EXIT.Text = "Exit[F11]"
        Me.CMD_EXIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CMD_EXIT.UseVisualStyleBackColor = True
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.AutoSize = True
        Me.lbl_Freeze.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(665, 45)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(13, 20)
        Me.lbl_Freeze.TabIndex = 10
        Me.lbl_Freeze.Text = " "
        '
        'Cmd_view
        '
        Me.Cmd_view.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_view.Image = CType(resources.GetObject("Cmd_view.Image"), System.Drawing.Image)
        Me.Cmd_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_view.Location = New System.Drawing.Point(10, 150)
        Me.Cmd_view.Name = "Cmd_view"
        Me.Cmd_view.Size = New System.Drawing.Size(137, 50)
        Me.Cmd_view.TabIndex = 11
        Me.Cmd_view.Text = "View[F9]"
        Me.Cmd_view.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_view.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(178, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 25)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "REASON MASTER"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(10, 294)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 50)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Browse"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(346, 332)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 16)
        Me.Label12.TabIndex = 889
        Me.Label12.Text = "Press [F4] for Help"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Txtcode)
        Me.GroupBox1.Controls.Add(Me.LBL_CODE)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.CODE_HELP)
        Me.GroupBox1.Location = New System.Drawing.Point(349, 171)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 143)
        Me.GroupBox1.TabIndex = 890
        Me.GroupBox1.TabStop = False
        '
        'Gr2
        '
        Me.Gr2.BackColor = System.Drawing.Color.Transparent
        Me.Gr2.Controls.Add(Me.cmd_exit1)
        Me.Gr2.Controls.Add(Me.CMD_WINDOWS)
        Me.Gr2.Controls.Add(Me.CMD_DOS)
        Me.Gr2.Location = New System.Drawing.Point(350, 370)
        Me.Gr2.Name = "Gr2"
        Me.Gr2.Size = New System.Drawing.Size(349, 70)
        Me.Gr2.TabIndex = 917
        Me.Gr2.TabStop = False
        Me.Gr2.Visible = False
        '
        'cmd_exit1
        '
        Me.cmd_exit1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_exit1.Location = New System.Drawing.Point(230, 27)
        Me.cmd_exit1.Name = "cmd_exit1"
        Me.cmd_exit1.Size = New System.Drawing.Size(100, 30)
        Me.cmd_exit1.TabIndex = 2
        Me.cmd_exit1.Text = "EXIT"
        Me.cmd_exit1.UseVisualStyleBackColor = True
        '
        'CMD_WINDOWS
        '
        Me.CMD_WINDOWS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_WINDOWS.Location = New System.Drawing.Point(125, 26)
        Me.CMD_WINDOWS.Name = "CMD_WINDOWS"
        Me.CMD_WINDOWS.Size = New System.Drawing.Size(100, 30)
        Me.CMD_WINDOWS.TabIndex = 1
        Me.CMD_WINDOWS.Text = "WINDOWS"
        Me.CMD_WINDOWS.UseVisualStyleBackColor = True
        '
        'CMD_DOS
        '
        Me.CMD_DOS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_DOS.Location = New System.Drawing.Point(19, 26)
        Me.CMD_DOS.Name = "CMD_DOS"
        Me.CMD_DOS.Size = New System.Drawing.Size(100, 30)
        Me.CMD_DOS.TabIndex = 0
        Me.CMD_DOS.Text = "DOS"
        Me.CMD_DOS.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CMD_CLR)
        Me.GroupBox2.Controls.Add(Me.CMD_ADD)
        Me.GroupBox2.Controls.Add(Me.CMD_FREEZE)
        Me.GroupBox2.Controls.Add(Me.CMD_EXIT)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Cmd_view)
        Me.GroupBox2.Location = New System.Drawing.Point(856, 171)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(157, 411)
        Me.GroupBox2.TabIndex = 918
        Me.GroupBox2.TabStop = False
        '
        'FRM_MKGA_REASONMASTER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Gr2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "FRM_MKGA_REASONMASTER"
        Me.Text = "REASON MASTER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Gr2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txtcode As System.Windows.Forms.TextBox
    Friend WithEvents LBL_CODE As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents CODE_HELP As System.Windows.Forms.Button
    Friend WithEvents CMD_CLR As System.Windows.Forms.Button
    Friend WithEvents CMD_ADD As System.Windows.Forms.Button
    Friend WithEvents CMD_FREEZE As System.Windows.Forms.Button
    Friend WithEvents CMD_EXIT As System.Windows.Forms.Button
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents Cmd_view As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Gr2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_exit1 As System.Windows.Forms.Button
    Friend WithEvents CMD_WINDOWS As System.Windows.Forms.Button
    Friend WithEvents CMD_DOS As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox

End Class
