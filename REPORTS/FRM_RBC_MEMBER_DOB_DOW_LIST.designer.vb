<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_RKGA_MEMBER_DOB_AND_WEDDING_LIST
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_RKGA_MEMBER_DOB_AND_WEDDING_LIST))
        Me.Button4 = New System.Windows.Forms.Button()
        Me.cmd_View = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.cmd_Clear = New System.Windows.Forms.Button()
        Me.Chk_FILTER_FIELD = New System.Windows.Forms.CheckedListBox()
        Me.Chkdob = New System.Windows.Forms.CheckBox()
        Me.Chkwedding = New System.Windows.Forms.CheckBox()
        Me.Chkdep = New System.Windows.Forms.CheckBox()
        Me.Chkphoto = New System.Windows.Forms.CheckBox()
        Me.Labfromdate = New System.Windows.Forms.Label()
        Me.Lbltodate = New System.Windows.Forms.Label()
        Me.Fromdate = New System.Windows.Forms.DateTimePicker()
        Me.Todate = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.chk_PrintAll = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(868, 436)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(135, 49)
        Me.Button4.TabIndex = 913
        Me.Button4.Text = "Exit [F11]"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'cmd_View
        '
        Me.cmd_View.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_View.Image = CType(resources.GetObject("cmd_View.Image"), System.Drawing.Image)
        Me.cmd_View.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_View.Location = New System.Drawing.Point(868, 324)
        Me.cmd_View.Name = "cmd_View"
        Me.cmd_View.Size = New System.Drawing.Size(135, 52)
        Me.cmd_View.TabIndex = 912
        Me.cmd_View.Text = "View[F9]"
        Me.cmd_View.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_View.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(868, 382)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(135, 48)
        Me.Button5.TabIndex = 910
        Me.Button5.Text = "Print[F10]"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'cmd_Clear
        '
        Me.cmd_Clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Clear.Image = CType(resources.GetObject("cmd_Clear.Image"), System.Drawing.Image)
        Me.cmd_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Clear.Location = New System.Drawing.Point(868, 266)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(135, 52)
        Me.cmd_Clear.TabIndex = 909
        Me.cmd_Clear.Text = "Clear[F6]"
        Me.cmd_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_Clear.UseVisualStyleBackColor = True
        '
        'Chk_FILTER_FIELD
        '
        Me.Chk_FILTER_FIELD.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_FILTER_FIELD.FormattingEnabled = True
        Me.Chk_FILTER_FIELD.Location = New System.Drawing.Point(12, 46)
        Me.Chk_FILTER_FIELD.Name = "Chk_FILTER_FIELD"
        Me.Chk_FILTER_FIELD.Size = New System.Drawing.Size(291, 260)
        Me.Chk_FILTER_FIELD.TabIndex = 914
        '
        'Chkdob
        '
        Me.Chkdob.AutoSize = True
        Me.Chkdob.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chkdob.Location = New System.Drawing.Point(28, 30)
        Me.Chkdob.Name = "Chkdob"
        Me.Chkdob.Size = New System.Drawing.Size(96, 19)
        Me.Chkdob.TabIndex = 916
        Me.Chkdob.Text = "Date of Birth"
        Me.Chkdob.UseVisualStyleBackColor = True
        '
        'Chkwedding
        '
        Me.Chkwedding.AutoSize = True
        Me.Chkwedding.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chkwedding.Location = New System.Drawing.Point(153, 30)
        Me.Chkwedding.Name = "Chkwedding"
        Me.Chkwedding.Size = New System.Drawing.Size(119, 19)
        Me.Chkwedding.TabIndex = 917
        Me.Chkwedding.Text = "Date of Wedding"
        Me.Chkwedding.UseVisualStyleBackColor = True
        '
        'Chkdep
        '
        Me.Chkdep.AutoSize = True
        Me.Chkdep.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chkdep.Location = New System.Drawing.Point(309, 30)
        Me.Chkdep.Name = "Chkdep"
        Me.Chkdep.Size = New System.Drawing.Size(133, 19)
        Me.Chkdep.TabIndex = 918
        Me.Chkdep.Text = "Debendent/Spouse"
        Me.Chkdep.UseVisualStyleBackColor = True
        '
        'Chkphoto
        '
        Me.Chkphoto.AutoSize = True
        Me.Chkphoto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chkphoto.Location = New System.Drawing.Point(500, 30)
        Me.Chkphoto.Name = "Chkphoto"
        Me.Chkphoto.Size = New System.Drawing.Size(88, 19)
        Me.Chkphoto.TabIndex = 919
        Me.Chkphoto.Text = "With Photo"
        Me.Chkphoto.UseVisualStyleBackColor = True
        '
        'Labfromdate
        '
        Me.Labfromdate.AutoSize = True
        Me.Labfromdate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labfromdate.Location = New System.Drawing.Point(48, 31)
        Me.Labfromdate.Name = "Labfromdate"
        Me.Labfromdate.Size = New System.Drawing.Size(65, 15)
        Me.Labfromdate.TabIndex = 920
        Me.Labfromdate.Text = "From Date"
        '
        'Lbltodate
        '
        Me.Lbltodate.AutoSize = True
        Me.Lbltodate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltodate.Location = New System.Drawing.Point(306, 32)
        Me.Lbltodate.Name = "Lbltodate"
        Me.Lbltodate.Size = New System.Drawing.Size(49, 15)
        Me.Lbltodate.TabIndex = 921
        Me.Lbltodate.Text = "To Date"
        '
        'Fromdate
        '
        Me.Fromdate.CustomFormat = "dd/MM/yyyy"
        Me.Fromdate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Fromdate.Location = New System.Drawing.Point(136, 28)
        Me.Fromdate.Name = "Fromdate"
        Me.Fromdate.Size = New System.Drawing.Size(116, 21)
        Me.Fromdate.TabIndex = 922
        '
        'Todate
        '
        Me.Todate.CustomFormat = "dd/MM/yyyy"
        Me.Todate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Todate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Todate.Location = New System.Drawing.Point(407, 28)
        Me.Todate.Name = "Todate"
        Me.Todate.Size = New System.Drawing.Size(116, 21)
        Me.Todate.TabIndex = 923
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Chkdob)
        Me.GroupBox1.Controls.Add(Me.Chkwedding)
        Me.GroupBox1.Controls.Add(Me.Chkdep)
        Me.GroupBox1.Controls.Add(Me.Chkphoto)
        Me.GroupBox1.Location = New System.Drawing.Point(202, 506)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 70)
        Me.GroupBox1.TabIndex = 924
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Lbltodate)
        Me.GroupBox2.Controls.Add(Me.Labfromdate)
        Me.GroupBox2.Controls.Add(Me.Todate)
        Me.GroupBox2.Controls.Add(Me.Fromdate)
        Me.GroupBox2.Location = New System.Drawing.Point(202, 582)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(642, 62)
        Me.GroupBox2.TabIndex = 925
        Me.GroupBox2.TabStop = False
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(730, 477)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(100, 20)
        Me.txtCategory.TabIndex = 926
        Me.txtCategory.Visible = False
        '
        'chk_PrintAll
        '
        Me.chk_PrintAll.AutoSize = True
        Me.chk_PrintAll.BackColor = System.Drawing.Color.Transparent
        Me.chk_PrintAll.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PrintAll.Location = New System.Drawing.Point(15, 23)
        Me.chk_PrintAll.Name = "chk_PrintAll"
        Me.chk_PrintAll.Size = New System.Drawing.Size(131, 19)
        Me.chk_PrintAll.TabIndex = 927
        Me.chk_PrintAll.Text = "Print All Categorys"
        Me.chk_PrintAll.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(175, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(259, 25)
        Me.Label2.TabIndex = 929
        Me.Label2.Text = "MEMBER DOB/WEDDING LIST"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Chk_FILTER_FIELD)
        Me.GroupBox3.Controls.Add(Me.chk_PrintAll)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(382, 171)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(314, 326)
        Me.GroupBox3.TabIndex = 930
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Category"
        '
        'FRM_RKGA_MEMBER_DOB_AND_WEDDING_LIST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.cmd_View)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.cmd_Clear)
        Me.KeyPreview = True
        Me.Name = "FRM_RKGA_MEMBER_DOB_AND_WEDDING_LIST"
        Me.Text = "FRM_RKGA_MEMBER_DOB_AND_WEDDING_LIST"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents cmd_View As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Chk_FILTER_FIELD As System.Windows.Forms.CheckedListBox
    Friend WithEvents Chkdob As System.Windows.Forms.CheckBox
    Friend WithEvents Chkwedding As System.Windows.Forms.CheckBox
    Friend WithEvents Chkdep As System.Windows.Forms.CheckBox
    Friend WithEvents Chkphoto As System.Windows.Forms.CheckBox
    Friend WithEvents Labfromdate As System.Windows.Forms.Label
    Friend WithEvents Lbltodate As System.Windows.Forms.Label
    Friend WithEvents Fromdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Todate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox
    Friend WithEvents chk_PrintAll As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
