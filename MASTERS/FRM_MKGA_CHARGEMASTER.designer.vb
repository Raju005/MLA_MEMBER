<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_MKGA_CHARGEMASTER
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_MKGA_CHARGEMASTER))
        Me.cmd_Freeze = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.cmd_View = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.cmd_Add = New System.Windows.Forms.Button()
        Me.cmd_Clear = New System.Windows.Forms.Button()
        Me.CHARGEMASTER = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CHARGEDESC = New System.Windows.Forms.TextBox()
        Me.Textname = New System.Windows.Forms.TextBox()
        Me.Textrate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbl_freeze = New System.Windows.Forms.Label()
        Me.List_Tax = New System.Windows.Forms.CheckedListBox()
        Me.CODE_HELP = New System.Windows.Forms.Button()
        Me.ChkList_ItemTypeDet = New System.Windows.Forms.CheckedListBox()
        Me.ChkList_ItemType = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Gr2 = New System.Windows.Forms.GroupBox()
        Me.cmd_exit1 = New System.Windows.Forms.Button()
        Me.CMD_WINDOWS = New System.Windows.Forms.Button()
        Me.CMD_DOS = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Gr2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmd_Freeze
        '
        Me.cmd_Freeze.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Freeze.Image = CType(resources.GetObject("cmd_Freeze.Image"), System.Drawing.Image)
        Me.cmd_Freeze.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Freeze.Location = New System.Drawing.Point(6, 180)
        Me.cmd_Freeze.Name = "cmd_Freeze"
        Me.cmd_Freeze.Size = New System.Drawing.Size(137, 50)
        Me.cmd_Freeze.TabIndex = 898
        Me.cmd_Freeze.Text = "Void[F8]"
        Me.cmd_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_Freeze.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(6, 355)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(137, 50)
        Me.Button4.TabIndex = 897
        Me.Button4.Text = "Exit [F11]"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'cmd_View
        '
        Me.cmd_View.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_View.Image = CType(resources.GetObject("cmd_View.Image"), System.Drawing.Image)
        Me.cmd_View.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_View.Location = New System.Drawing.Point(6, 123)
        Me.cmd_View.Name = "cmd_View"
        Me.cmd_View.Size = New System.Drawing.Size(137, 50)
        Me.cmd_View.TabIndex = 896
        Me.cmd_View.Text = "View[F9]"
        Me.cmd_View.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_View.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(6, 237)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(137, 50)
        Me.Button5.TabIndex = 894
        Me.Button5.Text = "Print[F10]"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'cmd_Add
        '
        Me.cmd_Add.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Add.Image = CType(resources.GetObject("cmd_Add.Image"), System.Drawing.Image)
        Me.cmd_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Add.Location = New System.Drawing.Point(6, 64)
        Me.cmd_Add.Name = "cmd_Add"
        Me.cmd_Add.Size = New System.Drawing.Size(137, 50)
        Me.cmd_Add.TabIndex = 895
        Me.cmd_Add.Text = "Add[F7]"
        Me.cmd_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_Add.UseVisualStyleBackColor = True
        '
        'cmd_Clear
        '
        Me.cmd_Clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Clear.Image = CType(resources.GetObject("cmd_Clear.Image"), System.Drawing.Image)
        Me.cmd_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Clear.Location = New System.Drawing.Point(8, 10)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(137, 50)
        Me.cmd_Clear.TabIndex = 893
        Me.cmd_Clear.Text = "Clear[F6]"
        Me.cmd_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_Clear.UseVisualStyleBackColor = True
        '
        'CHARGEMASTER
        '
        Me.CHARGEMASTER.AutoSize = True
        Me.CHARGEMASTER.BackColor = System.Drawing.Color.Transparent
        Me.CHARGEMASTER.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHARGEMASTER.Location = New System.Drawing.Point(178, 77)
        Me.CHARGEMASTER.Name = "CHARGEMASTER"
        Me.CHARGEMASTER.Size = New System.Drawing.Size(161, 25)
        Me.CHARGEMASTER.TabIndex = 899
        Me.CHARGEMASTER.Text = "CHARGE MASTER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 900
        Me.Label1.Text = "Charge Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 16)
        Me.Label2.TabIndex = 901
        Me.Label2.Text = "Charge Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 16)
        Me.Label3.TabIndex = 902
        Me.Label3.Text = "Rate"
        '
        'CHARGEDESC
        '
        Me.CHARGEDESC.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHARGEDESC.Location = New System.Drawing.Point(155, 28)
        Me.CHARGEDESC.MaxLength = 10
        Me.CHARGEDESC.Name = "CHARGEDESC"
        Me.CHARGEDESC.Size = New System.Drawing.Size(105, 21)
        Me.CHARGEDESC.TabIndex = 903
        '
        'Textname
        '
        Me.Textname.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textname.Location = New System.Drawing.Point(155, 69)
        Me.Textname.MaxLength = 30
        Me.Textname.Name = "Textname"
        Me.Textname.Size = New System.Drawing.Size(142, 21)
        Me.Textname.TabIndex = 904
        '
        'Textrate
        '
        Me.Textrate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textrate.Location = New System.Drawing.Point(155, 110)
        Me.Textrate.MaxLength = 20
        Me.Textrate.Name = "Textrate"
        Me.Textrate.Size = New System.Drawing.Size(142, 21)
        Me.Textrate.TabIndex = 905
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(642, 277)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 907
        Me.Label4.Text = "TAX APPLY"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(5, 297)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 50)
        Me.Button1.TabIndex = 908
        Me.Button1.Text = "Browse"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbl_freeze
        '
        Me.lbl_freeze.AutoSize = True
        Me.lbl_freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_freeze.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_freeze.Location = New System.Drawing.Point(576, 40)
        Me.lbl_freeze.Name = "lbl_freeze"
        Me.lbl_freeze.Size = New System.Drawing.Size(190, 29)
        Me.lbl_freeze.TabIndex = 909
        Me.lbl_freeze.Text = "Record Freezed on"
        Me.lbl_freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'List_Tax
        '
        Me.List_Tax.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.List_Tax.FormattingEnabled = True
        Me.List_Tax.Location = New System.Drawing.Point(681, 401)
        Me.List_Tax.Name = "List_Tax"
        Me.List_Tax.Size = New System.Drawing.Size(162, 123)
        Me.List_Tax.TabIndex = 910
        Me.List_Tax.Visible = False
        '
        'CODE_HELP
        '
        Me.CODE_HELP.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources._400_F_9130045_3SaKfvCqFL4hRJm59cddsCnbx5YyqvYj
        Me.CODE_HELP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CODE_HELP.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CODE_HELP.Location = New System.Drawing.Point(267, 27)
        Me.CODE_HELP.Name = "CODE_HELP"
        Me.CODE_HELP.Size = New System.Drawing.Size(40, 23)
        Me.CODE_HELP.TabIndex = 911
        Me.CODE_HELP.UseVisualStyleBackColor = True
        '
        'ChkList_ItemTypeDet
        '
        Me.ChkList_ItemTypeDet.Enabled = False
        Me.ChkList_ItemTypeDet.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkList_ItemTypeDet.FormattingEnabled = True
        Me.ChkList_ItemTypeDet.Location = New System.Drawing.Point(162, 19)
        Me.ChkList_ItemTypeDet.Name = "ChkList_ItemTypeDet"
        Me.ChkList_ItemTypeDet.Size = New System.Drawing.Size(162, 123)
        Me.ChkList_ItemTypeDet.TabIndex = 913
        '
        'ChkList_ItemType
        '
        Me.ChkList_ItemType.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkList_ItemType.FormattingEnabled = True
        Me.ChkList_ItemType.Location = New System.Drawing.Point(11, 19)
        Me.ChkList_ItemType.Name = "ChkList_ItemType"
        Me.ChkList_ItemType.Size = New System.Drawing.Size(142, 123)
        Me.ChkList_ItemType.TabIndex = 912
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CHARGEDESC)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CODE_HELP)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Textname)
        Me.GroupBox1.Controls.Add(Me.Textrate)
        Me.GroupBox1.Location = New System.Drawing.Point(194, 300)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 154)
        Me.GroupBox1.TabIndex = 914
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.ChkList_ItemType)
        Me.GroupBox2.Controls.Add(Me.ChkList_ItemTypeDet)
        Me.GroupBox2.Location = New System.Drawing.Point(517, 301)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(332, 153)
        Me.GroupBox2.TabIndex = 915
        Me.GroupBox2.TabStop = False
        '
        'Gr2
        '
        Me.Gr2.BackColor = System.Drawing.Color.Transparent
        Me.Gr2.Controls.Add(Me.cmd_exit1)
        Me.Gr2.Controls.Add(Me.CMD_WINDOWS)
        Me.Gr2.Controls.Add(Me.CMD_DOS)
        Me.Gr2.Location = New System.Drawing.Point(332, 534)
        Me.Gr2.Name = "Gr2"
        Me.Gr2.Size = New System.Drawing.Size(371, 70)
        Me.Gr2.TabIndex = 916
        Me.Gr2.TabStop = False
        Me.Gr2.Visible = False
        '
        'cmd_exit1
        '
        Me.cmd_exit1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_exit1.Location = New System.Drawing.Point(237, 26)
        Me.cmd_exit1.Name = "cmd_exit1"
        Me.cmd_exit1.Size = New System.Drawing.Size(100, 30)
        Me.cmd_exit1.TabIndex = 2
        Me.cmd_exit1.Text = "EXIT"
        Me.cmd_exit1.UseVisualStyleBackColor = True
        '
        'CMD_WINDOWS
        '
        Me.CMD_WINDOWS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_WINDOWS.Location = New System.Drawing.Point(129, 26)
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
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.cmd_Clear)
        Me.GroupBox3.Controls.Add(Me.cmd_Add)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.cmd_View)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.cmd_Freeze)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Location = New System.Drawing.Point(855, 128)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(151, 420)
        Me.GroupBox3.TabIndex = 917
        Me.GroupBox3.TabStop = False
        '
        'FRM_MKGA_CHARGEMASTER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Gr2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.List_Tax)
        Me.Controls.Add(Me.lbl_freeze)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CHARGEMASTER)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "FRM_MKGA_CHARGEMASTER"
        Me.Text = "FRM_MKGA_CHARGEMASTER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Gr2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_Freeze As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents cmd_View As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents cmd_Add As System.Windows.Forms.Button
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents CHARGEMASTER As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CHARGEDESC As System.Windows.Forms.TextBox
    Friend WithEvents Textname As System.Windows.Forms.TextBox
    Friend WithEvents Textrate As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbl_freeze As System.Windows.Forms.Label
    Friend WithEvents List_Tax As System.Windows.Forms.CheckedListBox
    Friend WithEvents CODE_HELP As System.Windows.Forms.Button
    Friend WithEvents ChkList_ItemTypeDet As System.Windows.Forms.CheckedListBox
    Friend WithEvents ChkList_ItemType As System.Windows.Forms.CheckedListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Gr2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_exit1 As System.Windows.Forms.Button
    Friend WithEvents CMD_WINDOWS As System.Windows.Forms.Button
    Friend WithEvents CMD_DOS As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
