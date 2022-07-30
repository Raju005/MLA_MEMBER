<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_ACCOUNTPOSTING
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
        Me.cmd_Clear = New System.Windows.Forms.Button()
        Me.cmd_view = New System.Windows.Forms.Button()
        Me.Btn_close = New System.Windows.Forms.Button()
        Me.CbxMonth = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cmd_AccPosting = New System.Windows.Forms.Button()
        Me.Rdb_Monthbill = New System.Windows.Forms.RadioButton()
        Me.Rdb_Audit = New System.Windows.Forms.RadioButton()
        Me.Rdb_monthbillchk = New System.Windows.Forms.RadioButton()
        Me.Rdb_Dispatch = New System.Windows.Forms.RadioButton()
        Me.Lbl_msgbox = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account Control "
        '
        'cmd_Clear
        '
        Me.cmd_Clear.BackColor = System.Drawing.Color.Transparent
        Me.cmd_Clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Clear.ForeColor = System.Drawing.Color.Black
        Me.cmd_Clear.Image = Global.Bengal_MemberMaster.My.Resources.Resources.Clear
        Me.cmd_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Clear.Location = New System.Drawing.Point(7, 16)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(137, 50)
        Me.cmd_Clear.TabIndex = 607
        Me.cmd_Clear.Text = "Clear[F6]"
        Me.cmd_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_Clear.UseVisualStyleBackColor = False
        '
        'cmd_view
        '
        Me.cmd_view.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_view.ForeColor = System.Drawing.Color.Black
        Me.cmd_view.Image = Global.Bengal_MemberMaster.My.Resources.Resources.view
        Me.cmd_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_view.Location = New System.Drawing.Point(8, 73)
        Me.cmd_view.Name = "cmd_view"
        Me.cmd_view.Size = New System.Drawing.Size(137, 50)
        Me.cmd_view.TabIndex = 605
        Me.cmd_view.Text = "VIEW [F9]"
        Me.cmd_view.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Btn_close
        '
        Me.Btn_close.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_close.ForeColor = System.Drawing.Color.Black
        Me.Btn_close.Image = Global.Bengal_MemberMaster.My.Resources.Resources._Exit
        Me.Btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_close.Location = New System.Drawing.Point(7, 135)
        Me.Btn_close.Name = "Btn_close"
        Me.Btn_close.Size = New System.Drawing.Size(137, 50)
        Me.Btn_close.TabIndex = 606
        Me.Btn_close.Text = "Exit [F11]"
        Me.Btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CbxMonth
        '
        Me.CbxMonth.CalendarMonthBackground = System.Drawing.Color.White
        Me.CbxMonth.CustomFormat = "MMMMM"
        Me.CbxMonth.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CbxMonth.Location = New System.Drawing.Point(450, 190)
        Me.CbxMonth.Name = "CbxMonth"
        Me.CbxMonth.Size = New System.Drawing.Size(128, 22)
        Me.CbxMonth.TabIndex = 603
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(312, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 18)
        Me.Label2.TabIndex = 604
        Me.Label2.Text = "FOR THE MONTH OF : "
        '
        'Cmd_AccPosting
        '
        Me.Cmd_AccPosting.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_AccPosting.ForeColor = System.Drawing.Color.Black
        Me.Cmd_AccPosting.Image = Global.Bengal_MemberMaster.My.Resources.Resources.view
        Me.Cmd_AccPosting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_AccPosting.Location = New System.Drawing.Point(7, 72)
        Me.Cmd_AccPosting.Name = "Cmd_AccPosting"
        Me.Cmd_AccPosting.Size = New System.Drawing.Size(137, 50)
        Me.Cmd_AccPosting.TabIndex = 608
        Me.Cmd_AccPosting.Text = "Account "
        Me.Cmd_AccPosting.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Rdb_Monthbill
        '
        Me.Rdb_Monthbill.AutoSize = True
        Me.Rdb_Monthbill.BackColor = System.Drawing.Color.Transparent
        Me.Rdb_Monthbill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdb_Monthbill.ForeColor = System.Drawing.Color.Black
        Me.Rdb_Monthbill.Location = New System.Drawing.Point(501, 140)
        Me.Rdb_Monthbill.Name = "Rdb_Monthbill"
        Me.Rdb_Monthbill.Size = New System.Drawing.Size(176, 17)
        Me.Rdb_Monthbill.TabIndex = 610
        Me.Rdb_Monthbill.Text = "Before month bill checking"
        Me.Rdb_Monthbill.UseVisualStyleBackColor = False
        '
        'Rdb_Audit
        '
        Me.Rdb_Audit.AutoSize = True
        Me.Rdb_Audit.BackColor = System.Drawing.Color.Transparent
        Me.Rdb_Audit.Checked = True
        Me.Rdb_Audit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdb_Audit.ForeColor = System.Drawing.Color.Black
        Me.Rdb_Audit.Location = New System.Drawing.Point(280, 140)
        Me.Rdb_Audit.Name = "Rdb_Audit"
        Me.Rdb_Audit.Size = New System.Drawing.Size(91, 17)
        Me.Rdb_Audit.TabIndex = 611
        Me.Rdb_Audit.TabStop = True
        Me.Rdb_Audit.Text = "Audit report"
        Me.Rdb_Audit.UseVisualStyleBackColor = False
        '
        'Rdb_monthbillchk
        '
        Me.Rdb_monthbillchk.AutoSize = True
        Me.Rdb_monthbillchk.BackColor = System.Drawing.Color.Transparent
        Me.Rdb_monthbillchk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdb_monthbillchk.ForeColor = System.Drawing.Color.Black
        Me.Rdb_monthbillchk.Location = New System.Drawing.Point(280, 163)
        Me.Rdb_monthbillchk.Name = "Rdb_monthbillchk"
        Me.Rdb_monthbillchk.Size = New System.Drawing.Size(121, 17)
        Me.Rdb_monthbillchk.TabIndex = 612
        Me.Rdb_monthbillchk.Text = "Month bill chklist"
        Me.Rdb_monthbillchk.UseVisualStyleBackColor = False
        '
        'Rdb_Dispatch
        '
        Me.Rdb_Dispatch.AutoSize = True
        Me.Rdb_Dispatch.BackColor = System.Drawing.Color.Transparent
        Me.Rdb_Dispatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdb_Dispatch.ForeColor = System.Drawing.Color.Black
        Me.Rdb_Dispatch.Location = New System.Drawing.Point(501, 167)
        Me.Rdb_Dispatch.Name = "Rdb_Dispatch"
        Me.Rdb_Dispatch.Size = New System.Drawing.Size(126, 17)
        Me.Rdb_Dispatch.TabIndex = 613
        Me.Rdb_Dispatch.Text = "Dispatch Register"
        Me.Rdb_Dispatch.UseVisualStyleBackColor = False
        '
        'Lbl_msgbox
        '
        Me.Lbl_msgbox.AutoSize = True
        Me.Lbl_msgbox.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_msgbox.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Lbl_msgbox.Location = New System.Drawing.Point(426, 304)
        Me.Lbl_msgbox.Name = "Lbl_msgbox"
        Me.Lbl_msgbox.Size = New System.Drawing.Size(0, 25)
        Me.Lbl_msgbox.TabIndex = 614
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmd_Clear)
        Me.GroupBox1.Controls.Add(Me.Btn_close)
        Me.GroupBox1.Controls.Add(Me.Cmd_AccPosting)
        Me.GroupBox1.Controls.Add(Me.cmd_view)
        Me.GroupBox1.Location = New System.Drawing.Point(858, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(151, 196)
        Me.GroupBox1.TabIndex = 615
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(177, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(169, 33)
        Me.GroupBox2.TabIndex = 616
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(431, 243)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 50)
        Me.Button1.TabIndex = 617
        Me.Button1.Text = "MONTH BILL PROCESS"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.RadioButton1.Location = New System.Drawing.Point(280, 260)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(127, 17)
        Me.RadioButton1.TabIndex = 618
        Me.RadioButton1.Text = "Month Bill Posting"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'FRM_ACCOUNTPOSTING
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources._111in1024res
        Me.ClientSize = New System.Drawing.Size(1008, 633)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Lbl_msgbox)
        Me.Controls.Add(Me.Rdb_Dispatch)
        Me.Controls.Add(Me.Rdb_monthbillchk)
        Me.Controls.Add(Me.Rdb_Audit)
        Me.Controls.Add(Me.Rdb_Monthbill)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbxMonth)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRM_ACCOUNTPOSTING"
        Me.Text = "FRM_ACCOUNTPOSTING"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents cmd_view As System.Windows.Forms.Button
    Friend WithEvents Btn_close As System.Windows.Forms.Button
    Friend WithEvents CbxMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cmd_AccPosting As System.Windows.Forms.Button
    Friend WithEvents Rdb_Monthbill As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb_Audit As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb_monthbillchk As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb_Dispatch As System.Windows.Forms.RadioButton
    Friend WithEvents Lbl_msgbox As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
End Class
