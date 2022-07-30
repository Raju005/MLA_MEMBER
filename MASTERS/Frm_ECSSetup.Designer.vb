<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ECSSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ECSSetup))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_authorize = New System.Windows.Forms.Button()
        Me.btn_addnew = New System.Windows.Forms.Button()
        Me.browse = New System.Windows.Forms.Button()
        Me.btn_freeze = New System.Windows.Forms.Button()
        Me.btn_view = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_Amount = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txt_OURMICR = New System.Windows.Forms.TextBox()
        Me.Txt_NAMEOFORG = New System.Windows.Forms.TextBox()
        Me.Txt_OURUID = New System.Windows.Forms.TextBox()
        Me.Txt_ECSTYPE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_OURBANKACNO = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Lbl_freeze = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.btn_exit)
        Me.GroupBox4.Controls.Add(Me.btn_clear)
        Me.GroupBox4.Controls.Add(Me.btn_authorize)
        Me.GroupBox4.Controls.Add(Me.btn_addnew)
        Me.GroupBox4.Controls.Add(Me.browse)
        Me.GroupBox4.Controls.Add(Me.btn_freeze)
        Me.GroupBox4.Controls.Add(Me.btn_view)
        Me.GroupBox4.Location = New System.Drawing.Point(861, 112)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(145, 422)
        Me.GroupBox4.TabIndex = 127
        Me.GroupBox4.TabStop = False
        '
        'btn_exit
        '
        Me.btn_exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Black
        Me.btn_exit.Image = CType(resources.GetObject("btn_exit.Image"), System.Drawing.Image)
        Me.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_exit.Location = New System.Drawing.Point(4, 363)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(137, 50)
        Me.btn_exit.TabIndex = 16
        Me.btn_exit.Text = "Exit [F11]"
        Me.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.Transparent
        Me.btn_clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.Color.Black
        Me.btn_clear.Image = CType(resources.GetObject("btn_clear.Image"), System.Drawing.Image)
        Me.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clear.Location = New System.Drawing.Point(4, 16)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(137, 50)
        Me.btn_clear.TabIndex = 13
        Me.btn_clear.Tag = ""
        Me.btn_clear.Text = "Clear [F6]"
        Me.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_authorize
        '
        Me.btn_authorize.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_authorize.ForeColor = System.Drawing.Color.Black
        Me.btn_authorize.Location = New System.Drawing.Point(5, 306)
        Me.btn_authorize.Name = "btn_authorize"
        Me.btn_authorize.Size = New System.Drawing.Size(137, 50)
        Me.btn_authorize.TabIndex = 18
        Me.btn_authorize.Text = "Authorize"
        Me.btn_authorize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_authorize.UseVisualStyleBackColor = True
        '
        'btn_addnew
        '
        Me.btn_addnew.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addnew.ForeColor = System.Drawing.Color.Black
        Me.btn_addnew.Image = CType(resources.GetObject("btn_addnew.Image"), System.Drawing.Image)
        Me.btn_addnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_addnew.Location = New System.Drawing.Point(5, 73)
        Me.btn_addnew.Name = "btn_addnew"
        Me.btn_addnew.Size = New System.Drawing.Size(137, 50)
        Me.btn_addnew.TabIndex = 12
        Me.btn_addnew.Text = "Add [F7]"
        Me.btn_addnew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_addnew.UseVisualStyleBackColor = True
        '
        'browse
        '
        Me.browse.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.browse.ForeColor = System.Drawing.Color.Black
        Me.browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.browse.Location = New System.Drawing.Point(5, 247)
        Me.browse.Name = "browse"
        Me.browse.Size = New System.Drawing.Size(137, 50)
        Me.browse.TabIndex = 17
        Me.browse.Text = "Browse"
        Me.browse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.browse.UseVisualStyleBackColor = True
        '
        'btn_freeze
        '
        Me.btn_freeze.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_freeze.ForeColor = System.Drawing.Color.Black
        Me.btn_freeze.Image = CType(resources.GetObject("btn_freeze.Image"), System.Drawing.Image)
        Me.btn_freeze.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_freeze.Location = New System.Drawing.Point(5, 134)
        Me.btn_freeze.Name = "btn_freeze"
        Me.btn_freeze.Size = New System.Drawing.Size(137, 50)
        Me.btn_freeze.TabIndex = 14
        Me.btn_freeze.Text = "Void [F8]"
        Me.btn_freeze.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_freeze.UseVisualStyleBackColor = True
        '
        'btn_view
        '
        Me.btn_view.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_view.ForeColor = System.Drawing.Color.Black
        Me.btn_view.Image = CType(resources.GetObject("btn_view.Image"), System.Drawing.Image)
        Me.btn_view.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_view.Location = New System.Drawing.Point(5, 191)
        Me.btn_view.Name = "btn_view"
        Me.btn_view.Size = New System.Drawing.Size(137, 50)
        Me.btn_view.TabIndex = 15
        Me.btn_view.Text = "View [F9]"
        Me.btn_view.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_view.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(190, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 129
        Me.Label2.Text = "ESC SETUP"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(8, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 18)
        Me.Label7.TabIndex = 135
        Me.Label7.Text = "AMOUNT :"
        '
        'Txt_Amount
        '
        Me.Txt_Amount.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Amount.Location = New System.Drawing.Point(295, 159)
        Me.Txt_Amount.Name = "Txt_Amount"
        Me.Txt_Amount.Size = New System.Drawing.Size(194, 21)
        Me.Txt_Amount.TabIndex = 141
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Txt_OURMICR)
        Me.GroupBox1.Controls.Add(Me.Txt_NAMEOFORG)
        Me.GroupBox1.Controls.Add(Me.Txt_OURUID)
        Me.GroupBox1.Controls.Add(Me.Txt_ECSTYPE)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Txt_OURBANKACNO)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Txt_Amount)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Location = New System.Drawing.Point(276, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(507, 195)
        Me.GroupBox1.TabIndex = 142
        Me.GroupBox1.TabStop = False
        '
        'Txt_OURMICR
        '
        Me.Txt_OURMICR.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_OURMICR.Location = New System.Drawing.Point(296, 95)
        Me.Txt_OURMICR.Name = "Txt_OURMICR"
        Me.Txt_OURMICR.Size = New System.Drawing.Size(194, 21)
        Me.Txt_OURMICR.TabIndex = 151
        '
        'Txt_NAMEOFORG
        '
        Me.Txt_NAMEOFORG.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NAMEOFORG.Location = New System.Drawing.Point(296, 65)
        Me.Txt_NAMEOFORG.Name = "Txt_NAMEOFORG"
        Me.Txt_NAMEOFORG.Size = New System.Drawing.Size(194, 21)
        Me.Txt_NAMEOFORG.TabIndex = 150
        '
        'Txt_OURUID
        '
        Me.Txt_OURUID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_OURUID.Location = New System.Drawing.Point(296, 38)
        Me.Txt_OURUID.Name = "Txt_OURUID"
        Me.Txt_OURUID.Size = New System.Drawing.Size(194, 21)
        Me.Txt_OURUID.TabIndex = 149
        '
        'Txt_ECSTYPE
        '
        Me.Txt_ECSTYPE.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ECSTYPE.Location = New System.Drawing.Point(295, 9)
        Me.Txt_ECSTYPE.Name = "Txt_ECSTYPE"
        Me.Txt_ECSTYPE.Size = New System.Drawing.Size(194, 21)
        Me.Txt_ECSTYPE.TabIndex = 148
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(8, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 18)
        Me.Label5.TabIndex = 147
        Me.Label5.Text = "OUR MICR :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(8, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(240, 18)
        Me.Label4.TabIndex = 146
        Me.Label4.Text = "NAME OF OUR ORGANISATION :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 18)
        Me.Label3.TabIndex = 145
        Me.Label3.Text = "OUR USER ID :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 18)
        Me.Label1.TabIndex = 144
        Me.Label1.Text = "ESC TYPE :"
        '
        'Txt_OURBANKACNO
        '
        Me.Txt_OURBANKACNO.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_OURBANKACNO.Location = New System.Drawing.Point(295, 125)
        Me.Txt_OURBANKACNO.Name = "Txt_OURBANKACNO"
        Me.Txt_OURBANKACNO.Size = New System.Drawing.Size(194, 21)
        Me.Txt_OURBANKACNO.TabIndex = 143
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(7, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(209, 18)
        Me.Label6.TabIndex = 142
        Me.Label6.Text = "OUR BANK ACCOUNT NO.  :"
        '
        'Lbl_freeze
        '
        Me.Lbl_freeze.AutoSize = True
        Me.Lbl_freeze.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_freeze.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_freeze.ForeColor = System.Drawing.Color.Red
        Me.Lbl_freeze.Location = New System.Drawing.Point(410, 361)
        Me.Lbl_freeze.Name = "Lbl_freeze"
        Me.Lbl_freeze.Size = New System.Drawing.Size(188, 29)
        Me.Lbl_freeze.TabIndex = 143
        Me.Lbl_freeze.Text = " Record Voided On"
        Me.Lbl_freeze.Visible = False
        '
        'Frm_ECSSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources._111in1024res
        Me.ClientSize = New System.Drawing.Size(1008, 750)
        Me.Controls.Add(Me.Lbl_freeze)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_ECSSetup"
        Me.Text = "Frm_ECSSetup"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Public WithEvents btn_exit As System.Windows.Forms.Button
    Public WithEvents btn_clear As System.Windows.Forms.Button
    Public WithEvents btn_authorize As System.Windows.Forms.Button
    Public WithEvents btn_addnew As System.Windows.Forms.Button
    Public WithEvents browse As System.Windows.Forms.Button
    Public WithEvents btn_freeze As System.Windows.Forms.Button
    Public WithEvents btn_view As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Txt_Amount As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_OURMICR As System.Windows.Forms.TextBox
    Friend WithEvents Txt_NAMEOFORG As System.Windows.Forms.TextBox
    Friend WithEvents Txt_OURUID As System.Windows.Forms.TextBox
    Friend WithEvents Txt_ECSTYPE As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt_OURBANKACNO As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Lbl_freeze As System.Windows.Forms.Label
End Class
