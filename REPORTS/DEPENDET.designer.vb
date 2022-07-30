<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DEPENDET
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DEPENDET))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CHK_DEPENDET = New System.Windows.Forms.CheckedListBox()
        Me.Chk_SelectALLDep = New System.Windows.Forms.CheckBox()
        Me.Cmb_FromDate = New System.Windows.Forms.DateTimePicker()
        Me.year = New System.Windows.Forms.CheckBox()
        Me.txt_dependent = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FROMAGE = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TOAGE = New System.Windows.Forms.TextBox()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.btn_view = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(179, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DEPENDENT DETAILS"
        '
        'CHK_DEPENDET
        '
        Me.CHK_DEPENDET.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_DEPENDET.FormattingEnabled = True
        Me.CHK_DEPENDET.Items.AddRange(New Object() {"Spouse", "Son", "Daughter", "Father", "Mother", "Others"})
        Me.CHK_DEPENDET.Location = New System.Drawing.Point(14, 32)
        Me.CHK_DEPENDET.Name = "CHK_DEPENDET"
        Me.CHK_DEPENDET.Size = New System.Drawing.Size(307, 228)
        Me.CHK_DEPENDET.TabIndex = 1
        '
        'Chk_SelectALLDep
        '
        Me.Chk_SelectALLDep.AutoSize = True
        Me.Chk_SelectALLDep.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_SelectALLDep.Location = New System.Drawing.Point(17, 11)
        Me.Chk_SelectALLDep.Name = "Chk_SelectALLDep"
        Me.Chk_SelectALLDep.Size = New System.Drawing.Size(95, 19)
        Me.Chk_SelectALLDep.TabIndex = 2
        Me.Chk_SelectALLDep.Text = "SELECT ALL"
        Me.Chk_SelectALLDep.UseVisualStyleBackColor = True
        '
        'Cmb_FromDate
        '
        Me.Cmb_FromDate.Location = New System.Drawing.Point(701, 31)
        Me.Cmb_FromDate.Name = "Cmb_FromDate"
        Me.Cmb_FromDate.Size = New System.Drawing.Size(200, 20)
        Me.Cmb_FromDate.TabIndex = 892
        Me.Cmb_FromDate.Visible = False
        '
        'year
        '
        Me.year.AutoSize = True
        Me.year.Location = New System.Drawing.Point(701, 57)
        Me.year.Name = "year"
        Me.year.Size = New System.Drawing.Size(105, 17)
        Me.year.TabIndex = 894
        Me.year.Text = "DEP_DOBWISE"
        Me.year.UseVisualStyleBackColor = True
        Me.year.Visible = False
        '
        'txt_dependent
        '
        Me.txt_dependent.Location = New System.Drawing.Point(17, 259)
        Me.txt_dependent.Name = "txt_dependent"
        Me.txt_dependent.Size = New System.Drawing.Size(304, 20)
        Me.txt_dependent.TabIndex = 893
        Me.txt_dependent.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 15)
        Me.Label5.TabIndex = 895
        Me.Label5.Text = "FROM AGE"
        '
        'FROMAGE
        '
        Me.FROMAGE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FROMAGE.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FROMAGE.Location = New System.Drawing.Point(80, 40)
        Me.FROMAGE.Name = "FROMAGE"
        Me.FROMAGE.Size = New System.Drawing.Size(100, 21)
        Me.FROMAGE.TabIndex = 896
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(190, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 15)
        Me.Label6.TabIndex = 897
        Me.Label6.Text = "TO AGE"
        '
        'TOAGE
        '
        Me.TOAGE.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOAGE.Location = New System.Drawing.Point(244, 38)
        Me.TOAGE.Name = "TOAGE"
        Me.TOAGE.Size = New System.Drawing.Size(100, 21)
        Me.TOAGE.TabIndex = 898
        '
        'btn_exit
        '
        Me.btn_exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Image = CType(resources.GetObject("btn_exit.Image"), System.Drawing.Image)
        Me.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_exit.Location = New System.Drawing.Point(866, 399)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(137, 50)
        Me.btn_exit.TabIndex = 902
        Me.btn_exit.Text = "Exit[F11]"
        Me.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.Image = CType(resources.GetObject("btn_clear.Image"), System.Drawing.Image)
        Me.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clear.Location = New System.Drawing.Point(866, 221)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(137, 50)
        Me.btn_clear.TabIndex = 899
        Me.btn_clear.Text = "Clear[F6]"
        Me.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_print
        '
        Me.btn_print.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_print.Location = New System.Drawing.Point(865, 341)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(137, 50)
        Me.btn_print.TabIndex = 900
        Me.btn_print.Text = "Print[F12]"
        Me.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'btn_view
        '
        Me.btn_view.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_view.Image = CType(resources.GetObject("btn_view.Image"), System.Drawing.Image)
        Me.btn_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_view.Location = New System.Drawing.Point(865, 282)
        Me.btn_view.Name = "btn_view"
        Me.btn_view.Size = New System.Drawing.Size(137, 50)
        Me.btn_view.TabIndex = 901
        Me.btn_view.Text = "View[F9]"
        Me.btn_view.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_view.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CHK_DEPENDET)
        Me.GroupBox1.Controls.Add(Me.Chk_SelectALLDep)
        Me.GroupBox1.Controls.Add(Me.txt_dependent)
        Me.GroupBox1.Location = New System.Drawing.Point(352, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 309)
        Me.GroupBox1.TabIndex = 903
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.FROMAGE)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TOAGE)
        Me.GroupBox2.Location = New System.Drawing.Point(352, 462)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(349, 100)
        Me.GroupBox2.TabIndex = 904
        Me.GroupBox2.TabStop = False
        '
        'DEPENDET
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources._111in1024res
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.btn_view)
        Me.Controls.Add(Me.year)
        Me.Controls.Add(Me.Cmb_FromDate)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.Name = "DEPENDET"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DEPENDENT DETALS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CHK_DEPENDET As System.Windows.Forms.CheckedListBox
    Friend WithEvents Chk_SelectALLDep As System.Windows.Forms.CheckBox
    Friend WithEvents Cmb_FromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents year As System.Windows.Forms.CheckBox
    Friend WithEvents txt_dependent As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FROMAGE As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TOAGE As System.Windows.Forms.TextBox
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btn_print As System.Windows.Forms.Button
    Friend WithEvents btn_view As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
