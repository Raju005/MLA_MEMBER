<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RFM_RKGA_SUBSCRIPTIONDETAILS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RFM_RKGA_SUBSCRIPTIONDETAILS))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chklist_Membername = New System.Windows.Forms.CheckedListBox()
        Me.ChKLIST_Memberstatus = New System.Windows.Forms.CheckedListBox()
        Me.chklist_Membern = New System.Windows.Forms.CheckedListBox()
        Me.CHKLIST_SUBSCRIPTIONMAST = New System.Windows.Forms.CheckedListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RDB_SUB_SUMMARY = New System.Windows.Forms.RadioButton()
        Me.RDB_SUB_DETAIL = New System.Windows.Forms.RadioButton()
        Me.RDB_MEMBER_LIST_SUBS = New System.Windows.Forms.RadioButton()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.cmd_View = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.cmd_Clear = New System.Windows.Forms.Button()
        Me.CHK_MEMBERCATEGORY = New System.Windows.Forms.CheckBox()
        Me.CHK_STATUS = New System.Windows.Forms.CheckBox()
        Me.CHK_SELECT = New System.Windows.Forms.CheckBox()
        Me.CHK_SUBSCRIPTION = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RDB_Facility_List = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBXMONTH = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Rtn_gstbill = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(180, 78)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SUBSCRIPTION DETAILS"
        '
        'chklist_Membername
        '
        Me.chklist_Membername.FormattingEnabled = True
        Me.chklist_Membername.Location = New System.Drawing.Point(520, 264)
        Me.chklist_Membername.Margin = New System.Windows.Forms.Padding(4)
        Me.chklist_Membername.Name = "chklist_Membername"
        Me.chklist_Membername.Size = New System.Drawing.Size(160, 293)
        Me.chklist_Membername.TabIndex = 1
        '
        'ChKLIST_Memberstatus
        '
        Me.ChKLIST_Memberstatus.FormattingEnabled = True
        Me.ChKLIST_Memberstatus.Items.AddRange(New Object() {"1.ABSENTEE", "2.BLOCKED", "3.EXPIRED", "4.INACTIVE", "5.LIVE", "6.RESIGNED", "7.SUSPENDED", "8.TERMINATED", "9.REMOVED", "10.POSTED"})
        Me.ChKLIST_Memberstatus.Location = New System.Drawing.Point(351, 263)
        Me.ChKLIST_Memberstatus.Margin = New System.Windows.Forms.Padding(4)
        Me.ChKLIST_Memberstatus.Name = "ChKLIST_Memberstatus"
        Me.ChKLIST_Memberstatus.Size = New System.Drawing.Size(159, 293)
        Me.ChKLIST_Memberstatus.TabIndex = 2
        '
        'chklist_Membern
        '
        Me.chklist_Membern.FormattingEnabled = True
        Me.chklist_Membern.Location = New System.Drawing.Point(183, 262)
        Me.chklist_Membern.Margin = New System.Windows.Forms.Padding(4)
        Me.chklist_Membern.Name = "chklist_Membern"
        Me.chklist_Membern.Size = New System.Drawing.Size(157, 293)
        Me.chklist_Membern.TabIndex = 3
        '
        'CHKLIST_SUBSCRIPTIONMAST
        '
        Me.CHKLIST_SUBSCRIPTIONMAST.FormattingEnabled = True
        Me.CHKLIST_SUBSCRIPTIONMAST.Location = New System.Drawing.Point(687, 263)
        Me.CHKLIST_SUBSCRIPTIONMAST.Margin = New System.Windows.Forms.Padding(4)
        Me.CHKLIST_SUBSCRIPTIONMAST.Name = "CHKLIST_SUBSCRIPTIONMAST"
        Me.CHKLIST_SUBSCRIPTIONMAST.Size = New System.Drawing.Size(159, 293)
        Me.CHKLIST_SUBSCRIPTIONMAST.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.IndianRed
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(183, 245)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "CATEGORY"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.IndianRed
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(350, 245)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "MEMBER STATUS"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.IndianRed
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(522, 245)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "MEMBER LIST"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.IndianRed
        Me.Label5.Location = New System.Drawing.Point(687, 247)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "SUB TYPE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(350, 154)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "SUBSCRIPTION MONTH OF"
        '
        'RDB_SUB_SUMMARY
        '
        Me.RDB_SUB_SUMMARY.AutoSize = True
        Me.RDB_SUB_SUMMARY.BackColor = System.Drawing.Color.Transparent
        Me.RDB_SUB_SUMMARY.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDB_SUB_SUMMARY.Location = New System.Drawing.Point(62, 21)
        Me.RDB_SUB_SUMMARY.Name = "RDB_SUB_SUMMARY"
        Me.RDB_SUB_SUMMARY.Size = New System.Drawing.Size(84, 19)
        Me.RDB_SUB_SUMMARY.TabIndex = 11
        Me.RDB_SUB_SUMMARY.TabStop = True
        Me.RDB_SUB_SUMMARY.Text = "SUMMARY"
        Me.RDB_SUB_SUMMARY.UseVisualStyleBackColor = False
        '
        'RDB_SUB_DETAIL
        '
        Me.RDB_SUB_DETAIL.AutoSize = True
        Me.RDB_SUB_DETAIL.BackColor = System.Drawing.Color.Transparent
        Me.RDB_SUB_DETAIL.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDB_SUB_DETAIL.Location = New System.Drawing.Point(335, 23)
        Me.RDB_SUB_DETAIL.Name = "RDB_SUB_DETAIL"
        Me.RDB_SUB_DETAIL.Size = New System.Drawing.Size(67, 19)
        Me.RDB_SUB_DETAIL.TabIndex = 12
        Me.RDB_SUB_DETAIL.TabStop = True
        Me.RDB_SUB_DETAIL.Text = " Details"
        Me.RDB_SUB_DETAIL.UseVisualStyleBackColor = False
        Me.RDB_SUB_DETAIL.Visible = False
        '
        'RDB_MEMBER_LIST_SUBS
        '
        Me.RDB_MEMBER_LIST_SUBS.AutoSize = True
        Me.RDB_MEMBER_LIST_SUBS.BackColor = System.Drawing.Color.Transparent
        Me.RDB_MEMBER_LIST_SUBS.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDB_MEMBER_LIST_SUBS.Location = New System.Drawing.Point(157, 21)
        Me.RDB_MEMBER_LIST_SUBS.Name = "RDB_MEMBER_LIST_SUBS"
        Me.RDB_MEMBER_LIST_SUBS.Size = New System.Drawing.Size(165, 19)
        Me.RDB_MEMBER_LIST_SUBS.TabIndex = 13
        Me.RDB_MEMBER_LIST_SUBS.TabStop = True
        Me.RDB_MEMBER_LIST_SUBS.Text = "Summary Member  Wise"
        Me.RDB_MEMBER_LIST_SUBS.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(867, 450)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(135, 49)
        Me.Button4.TabIndex = 917
        Me.Button4.Text = "Exit [F11]"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'cmd_View
        '
        Me.cmd_View.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_View.Image = CType(resources.GetObject("cmd_View.Image"), System.Drawing.Image)
        Me.cmd_View.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_View.Location = New System.Drawing.Point(867, 338)
        Me.cmd_View.Name = "cmd_View"
        Me.cmd_View.Size = New System.Drawing.Size(135, 52)
        Me.cmd_View.TabIndex = 916
        Me.cmd_View.Text = "View[F9]"
        Me.cmd_View.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_View.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(867, 396)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(135, 48)
        Me.Button5.TabIndex = 915
        Me.Button5.Text = "Print[F10]"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'cmd_Clear
        '
        Me.cmd_Clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Clear.Image = CType(resources.GetObject("cmd_Clear.Image"), System.Drawing.Image)
        Me.cmd_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Clear.Location = New System.Drawing.Point(867, 277)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(135, 52)
        Me.cmd_Clear.TabIndex = 914
        Me.cmd_Clear.Text = "Clear[F6]"
        Me.cmd_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_Clear.UseVisualStyleBackColor = True
        '
        'CHK_MEMBERCATEGORY
        '
        Me.CHK_MEMBERCATEGORY.AutoSize = True
        Me.CHK_MEMBERCATEGORY.BackColor = System.Drawing.Color.Transparent
        Me.CHK_MEMBERCATEGORY.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_MEMBERCATEGORY.Location = New System.Drawing.Point(182, 221)
        Me.CHK_MEMBERCATEGORY.Name = "CHK_MEMBERCATEGORY"
        Me.CHK_MEMBERCATEGORY.Size = New System.Drawing.Size(88, 20)
        Me.CHK_MEMBERCATEGORY.TabIndex = 918
        Me.CHK_MEMBERCATEGORY.Text = "Select All"
        Me.CHK_MEMBERCATEGORY.UseVisualStyleBackColor = False
        '
        'CHK_STATUS
        '
        Me.CHK_STATUS.AutoSize = True
        Me.CHK_STATUS.BackColor = System.Drawing.Color.Transparent
        Me.CHK_STATUS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_STATUS.Location = New System.Drawing.Point(351, 221)
        Me.CHK_STATUS.Name = "CHK_STATUS"
        Me.CHK_STATUS.Size = New System.Drawing.Size(88, 20)
        Me.CHK_STATUS.TabIndex = 919
        Me.CHK_STATUS.Text = "Select All"
        Me.CHK_STATUS.UseVisualStyleBackColor = False
        '
        'CHK_SELECT
        '
        Me.CHK_SELECT.AutoSize = True
        Me.CHK_SELECT.BackColor = System.Drawing.Color.Transparent
        Me.CHK_SELECT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_SELECT.Location = New System.Drawing.Point(525, 219)
        Me.CHK_SELECT.Name = "CHK_SELECT"
        Me.CHK_SELECT.Size = New System.Drawing.Size(88, 20)
        Me.CHK_SELECT.TabIndex = 920
        Me.CHK_SELECT.Text = "Select All"
        Me.CHK_SELECT.UseVisualStyleBackColor = False
        '
        'CHK_SUBSCRIPTION
        '
        Me.CHK_SUBSCRIPTION.AutoSize = True
        Me.CHK_SUBSCRIPTION.BackColor = System.Drawing.Color.Transparent
        Me.CHK_SUBSCRIPTION.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_SUBSCRIPTION.Location = New System.Drawing.Point(690, 221)
        Me.CHK_SUBSCRIPTION.Name = "CHK_SUBSCRIPTION"
        Me.CHK_SUBSCRIPTION.Size = New System.Drawing.Size(88, 20)
        Me.CHK_SUBSCRIPTION.TabIndex = 921
        Me.CHK_SUBSCRIPTION.Text = "Select All"
        Me.CHK_SUBSCRIPTION.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(867, 529)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 48)
        Me.Button1.TabIndex = 922
        Me.Button1.Text = "Export"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'RDB_Facility_List
        '
        Me.RDB_Facility_List.AutoSize = True
        Me.RDB_Facility_List.BackColor = System.Drawing.Color.Transparent
        Me.RDB_Facility_List.Location = New System.Drawing.Point(747, 566)
        Me.RDB_Facility_List.Name = "RDB_Facility_List"
        Me.RDB_Facility_List.Size = New System.Drawing.Size(92, 20)
        Me.RDB_Facility_List.TabIndex = 923
        Me.RDB_Facility_List.TabStop = True
        Me.RDB_Facility_List.Text = "Facility Det"
        Me.RDB_Facility_List.UseVisualStyleBackColor = False
        Me.RDB_Facility_List.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(303, 661)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(406, 15)
        Me.Label7.TabIndex = 925
        Me.Label7.Text = "Press F2 to select all / Press F7 to Serch / Press ENTER key to navigate"
        Me.Label7.Visible = False
        '
        'CBXMONTH
        '
        Me.CBXMONTH.CustomFormat = "MMMMM"
        Me.CBXMONTH.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBXMONTH.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CBXMONTH.Location = New System.Drawing.Point(523, 152)
        Me.CBXMONTH.Name = "CBXMONTH"
        Me.CBXMONTH.Size = New System.Drawing.Size(154, 21)
        Me.CBXMONTH.TabIndex = 926
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Rtn_gstbill)
        Me.GroupBox1.Controls.Add(Me.RDB_MEMBER_LIST_SUBS)
        Me.GroupBox1.Controls.Add(Me.RDB_SUB_SUMMARY)
        Me.GroupBox1.Controls.Add(Me.RDB_SUB_DETAIL)
        Me.GroupBox1.Location = New System.Drawing.Point(182, 586)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(664, 54)
        Me.GroupBox1.TabIndex = 927
        Me.GroupBox1.TabStop = False
        '
        'Rtn_gstbill
        '
        Me.Rtn_gstbill.AutoSize = True
        Me.Rtn_gstbill.BackColor = System.Drawing.Color.Transparent
        Me.Rtn_gstbill.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rtn_gstbill.Location = New System.Drawing.Point(428, 21)
        Me.Rtn_gstbill.Name = "Rtn_gstbill"
        Me.Rtn_gstbill.Size = New System.Drawing.Size(145, 19)
        Me.Rtn_gstbill.TabIndex = 14
        Me.Rtn_gstbill.TabStop = True
        Me.Rtn_gstbill.Text = " GST Subs Bill Details"
        Me.Rtn_gstbill.UseVisualStyleBackColor = False
        '
        'RFM_RKGA_SUBSCRIPTIONDETAILS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CBXMONTH)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.RDB_Facility_List)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CHK_SUBSCRIPTION)
        Me.Controls.Add(Me.CHK_SELECT)
        Me.Controls.Add(Me.CHK_STATUS)
        Me.Controls.Add(Me.CHK_MEMBERCATEGORY)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.cmd_View)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.cmd_Clear)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CHKLIST_SUBSCRIPTIONMAST)
        Me.Controls.Add(Me.chklist_Membern)
        Me.Controls.Add(Me.ChKLIST_Memberstatus)
        Me.Controls.Add(Me.chklist_Membername)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "RFM_RKGA_SUBSCRIPTIONDETAILS"
        Me.Text = "RFM_RKGA_SUBSCRIPTIONDETAILS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chklist_Membername As System.Windows.Forms.CheckedListBox
    Friend WithEvents ChKLIST_Memberstatus As System.Windows.Forms.CheckedListBox
    Friend WithEvents chklist_Membern As System.Windows.Forms.CheckedListBox
    Friend WithEvents CHKLIST_SUBSCRIPTIONMAST As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents RDB_SUB_SUMMARY As System.Windows.Forms.RadioButton
    Friend WithEvents RDB_SUB_DETAIL As System.Windows.Forms.RadioButton
    Friend WithEvents RDB_MEMBER_LIST_SUBS As System.Windows.Forms.RadioButton
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents cmd_View As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents CHK_MEMBERCATEGORY As System.Windows.Forms.CheckBox
    Friend WithEvents CHK_STATUS As System.Windows.Forms.CheckBox
    Friend WithEvents CHK_SELECT As System.Windows.Forms.CheckBox
    Friend WithEvents CHK_SUBSCRIPTION As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RDB_Facility_List As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CBXMONTH As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Rtn_gstbill As System.Windows.Forms.RadioButton
End Class
