Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms
Imports System.Text.RegularExpressions

Public Class FRM_MKGA_AffiliatedClubDetails
    Inherits System.Windows.Forms.Form
    Dim gconnection As New GlobalClass
    Dim boolchk As Boolean
    Dim sqlstring As String
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmd_View As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents cmd_Add As System.Windows.Forms.Button
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents cmd_Freeze As System.Windows.Forms.Button
    Friend WithEvents Browse As System.Windows.Forms.Button
    Friend WithEvents Cmd_Print As System.Windows.Forms.Button
    Friend WithEvents LIST_FACILITY As System.Windows.Forms.CheckedListBox
    Friend WithEvents txtFacilities As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Gr2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_exit1 As System.Windows.Forms.Button
    Friend WithEvents CMD_WINDOWS As System.Windows.Forms.Button
    Friend WithEvents CMD_DOS As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Dim dt As DataTable

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_add2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_add1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_clubcode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_CorporateCode As System.Windows.Forms.Label
    Friend WithEvents lbl_CorporateName As System.Windows.Forms.Label
    Public WithEvents lbl_BillingBasis As System.Windows.Forms.Label
    Friend WithEvents txt_clubname As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_ClubCode As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TXT_PHONE1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_contact As System.Windows.Forms.TextBox
    Public WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_website As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_phone2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_fax As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_pincode As System.Windows.Forms.TextBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cbo_PCountry As System.Windows.Forms.ComboBox
    Friend WithEvents Cbo_PCity As System.Windows.Forms.ComboBox
    Friend WithEvents Cbo_PState As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_MKGA_AffiliatedClubDetails))
        Me.lbl_Freeze = New System.Windows.Forms.Label()
        Me.Cbo_PCountry = New System.Windows.Forms.ComboBox()
        Me.Cbo_PCity = New System.Windows.Forms.ComboBox()
        Me.Cbo_PState = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TXT_PHONE1 = New System.Windows.Forms.TextBox()
        Me.txt_contact = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_website = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_phone2 = New System.Windows.Forms.TextBox()
        Me.txt_fax = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_pincode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_add2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_add1 = New System.Windows.Forms.TextBox()
        Me.txt_clubcode = New System.Windows.Forms.TextBox()
        Me.lbl_CorporateCode = New System.Windows.Forms.Label()
        Me.lbl_CorporateName = New System.Windows.Forms.Label()
        Me.lbl_BillingBasis = New System.Windows.Forms.Label()
        Me.txt_clubname = New System.Windows.Forms.TextBox()
        Me.Cmd_ClubCode = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmd_View = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.cmd_Add = New System.Windows.Forms.Button()
        Me.cmd_Clear = New System.Windows.Forms.Button()
        Me.cmd_Freeze = New System.Windows.Forms.Button()
        Me.Browse = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Gr2 = New System.Windows.Forms.GroupBox()
        Me.cmd_exit1 = New System.Windows.Forms.Button()
        Me.CMD_WINDOWS = New System.Windows.Forms.Button()
        Me.CMD_DOS = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Gr2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.AutoSize = True
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(574, 44)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(203, 29)
        Me.lbl_Freeze.TabIndex = 119
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'Cbo_PCountry
        '
        Me.Cbo_PCountry.BackColor = System.Drawing.Color.White
        Me.Cbo_PCountry.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Cbo_PCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_PCountry.Enabled = False
        Me.Cbo_PCountry.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cbo_PCountry.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_PCountry.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Cbo_PCountry.ItemHeight = 15
        Me.Cbo_PCountry.Location = New System.Drawing.Point(370, 343)
        Me.Cbo_PCountry.Name = "Cbo_PCountry"
        Me.Cbo_PCountry.Size = New System.Drawing.Size(331, 23)
        Me.Cbo_PCountry.TabIndex = 825
        '
        'Cbo_PCity
        '
        Me.Cbo_PCity.BackColor = System.Drawing.Color.White
        Me.Cbo_PCity.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Cbo_PCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_PCity.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cbo_PCity.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_PCity.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Cbo_PCity.ItemHeight = 15
        Me.Cbo_PCity.Location = New System.Drawing.Point(370, 282)
        Me.Cbo_PCity.Name = "Cbo_PCity"
        Me.Cbo_PCity.Size = New System.Drawing.Size(331, 23)
        Me.Cbo_PCity.TabIndex = 824
        '
        'Cbo_PState
        '
        Me.Cbo_PState.BackColor = System.Drawing.Color.White
        Me.Cbo_PState.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Cbo_PState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_PState.Enabled = False
        Me.Cbo_PState.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cbo_PState.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_PState.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Cbo_PState.ItemHeight = 15
        Me.Cbo_PState.Location = New System.Drawing.Point(370, 314)
        Me.Cbo_PState.Name = "Cbo_PState"
        Me.Cbo_PState.Size = New System.Drawing.Size(331, 23)
        Me.Cbo_PState.TabIndex = 823
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(210, 346)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 172
        Me.Label3.Text = "Country :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(210, 442)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 15)
        Me.Label20.TabIndex = 171
        Me.Label20.Text = "Phone2 :"
        '
        'TXT_PHONE1
        '
        Me.TXT_PHONE1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.TXT_PHONE1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_PHONE1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PHONE1.Location = New System.Drawing.Point(370, 410)
        Me.TXT_PHONE1.MaxLength = 22
        Me.TXT_PHONE1.Name = "TXT_PHONE1"
        Me.TXT_PHONE1.Size = New System.Drawing.Size(171, 21)
        Me.TXT_PHONE1.TabIndex = 170
        '
        'txt_contact
        '
        Me.txt_contact.BackColor = System.Drawing.Color.White
        Me.txt_contact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_contact.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contact.Location = New System.Drawing.Point(370, 570)
        Me.txt_contact.MaxLength = 50
        Me.txt_contact.Name = "txt_contact"
        Me.txt_contact.Size = New System.Drawing.Size(331, 21)
        Me.txt_contact.TabIndex = 166
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(210, 570)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 15)
        Me.Label10.TabIndex = 165
        Me.Label10.Text = "Contact Person :"
        '
        'txt_website
        '
        Me.txt_website.BackColor = System.Drawing.Color.White
        Me.txt_website.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_website.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_website.Location = New System.Drawing.Point(370, 538)
        Me.txt_website.MaxLength = 50
        Me.txt_website.Name = "txt_website"
        Me.txt_website.Size = New System.Drawing.Size(331, 21)
        Me.txt_website.TabIndex = 164
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(210, 538)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 15)
        Me.Label9.TabIndex = 163
        Me.Label9.Text = "Website :"
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.White
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_email.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(370, 506)
        Me.txt_email.MaxLength = 50
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(331, 21)
        Me.txt_email.TabIndex = 162
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(210, 506)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 15)
        Me.Label8.TabIndex = 161
        Me.Label8.Text = "E.Mail :"
        '
        'txt_phone2
        '
        Me.txt_phone2.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_phone2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_phone2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_phone2.Location = New System.Drawing.Point(370, 442)
        Me.txt_phone2.MaxLength = 22
        Me.txt_phone2.Name = "txt_phone2"
        Me.txt_phone2.Size = New System.Drawing.Size(171, 21)
        Me.txt_phone2.TabIndex = 160
        '
        'txt_fax
        '
        Me.txt_fax.BackColor = System.Drawing.Color.White
        Me.txt_fax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fax.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fax.Location = New System.Drawing.Point(370, 474)
        Me.txt_fax.MaxLength = 22
        Me.txt_fax.Name = "txt_fax"
        Me.txt_fax.Size = New System.Drawing.Size(331, 21)
        Me.txt_fax.TabIndex = 159
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(210, 474)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 15)
        Me.Label7.TabIndex = 158
        Me.Label7.Text = "Fax :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(210, 410)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 15)
        Me.Label6.TabIndex = 157
        Me.Label6.Text = "Phone1 :"
        '
        'txt_pincode
        '
        Me.txt_pincode.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_pincode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pincode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pincode.Location = New System.Drawing.Point(370, 378)
        Me.txt_pincode.MaxLength = 20
        Me.txt_pincode.Name = "txt_pincode"
        Me.txt_pincode.Size = New System.Drawing.Size(171, 21)
        Me.txt_pincode.TabIndex = 156
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(210, 378)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 15)
        Me.Label5.TabIndex = 155
        Me.Label5.Text = "PinCode :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(210, 314)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 15)
        Me.Label4.TabIndex = 153
        Me.Label4.Text = "State :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(210, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 15)
        Me.Label2.TabIndex = 151
        Me.Label2.Text = "City :"
        '
        'txt_add2
        '
        Me.txt_add2.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_add2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_add2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_add2.Location = New System.Drawing.Point(370, 250)
        Me.txt_add2.MaxLength = 35
        Me.txt_add2.Name = "txt_add2"
        Me.txt_add2.Size = New System.Drawing.Size(331, 21)
        Me.txt_add2.TabIndex = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(210, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 149
        Me.Label1.Text = "Address2 :"
        '
        'txt_add1
        '
        Me.txt_add1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_add1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_add1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_add1.Location = New System.Drawing.Point(370, 218)
        Me.txt_add1.MaxLength = 35
        Me.txt_add1.Name = "txt_add1"
        Me.txt_add1.Size = New System.Drawing.Size(331, 21)
        Me.txt_add1.TabIndex = 148
        '
        'txt_clubcode
        '
        Me.txt_clubcode.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_clubcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_clubcode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_clubcode.Location = New System.Drawing.Point(370, 154)
        Me.txt_clubcode.MaxLength = 6
        Me.txt_clubcode.Name = "txt_clubcode"
        Me.txt_clubcode.Size = New System.Drawing.Size(128, 21)
        Me.txt_clubcode.TabIndex = 142
        '
        'lbl_CorporateCode
        '
        Me.lbl_CorporateCode.AutoSize = True
        Me.lbl_CorporateCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CorporateCode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CorporateCode.Location = New System.Drawing.Point(210, 154)
        Me.lbl_CorporateCode.Name = "lbl_CorporateCode"
        Me.lbl_CorporateCode.Size = New System.Drawing.Size(70, 15)
        Me.lbl_CorporateCode.TabIndex = 144
        Me.lbl_CorporateCode.Text = "Club Code :"
        '
        'lbl_CorporateName
        '
        Me.lbl_CorporateName.AutoSize = True
        Me.lbl_CorporateName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CorporateName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CorporateName.Location = New System.Drawing.Point(210, 186)
        Me.lbl_CorporateName.Name = "lbl_CorporateName"
        Me.lbl_CorporateName.Size = New System.Drawing.Size(77, 15)
        Me.lbl_CorporateName.TabIndex = 146
        Me.lbl_CorporateName.Text = "Club Name  :"
        '
        'lbl_BillingBasis
        '
        Me.lbl_BillingBasis.AutoSize = True
        Me.lbl_BillingBasis.BackColor = System.Drawing.Color.Transparent
        Me.lbl_BillingBasis.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_BillingBasis.Location = New System.Drawing.Point(210, 218)
        Me.lbl_BillingBasis.Name = "lbl_BillingBasis"
        Me.lbl_BillingBasis.Size = New System.Drawing.Size(68, 15)
        Me.lbl_BillingBasis.TabIndex = 147
        Me.lbl_BillingBasis.Text = "Address1 :"
        '
        'txt_clubname
        '
        Me.txt_clubname.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_clubname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_clubname.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_clubname.Location = New System.Drawing.Point(370, 186)
        Me.txt_clubname.MaxLength = 35
        Me.txt_clubname.Name = "txt_clubname"
        Me.txt_clubname.Size = New System.Drawing.Size(331, 21)
        Me.txt_clubname.TabIndex = 143
        '
        'Cmd_ClubCode
        '
        Me.Cmd_ClubCode.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources._400_F_9130045_3SaKfvCqFL4hRJm59cddsCnbx5YyqvYj
        Me.Cmd_ClubCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cmd_ClubCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_ClubCode.Location = New System.Drawing.Point(503, 152)
        Me.Cmd_ClubCode.Name = "Cmd_ClubCode"
        Me.Cmd_ClubCode.Size = New System.Drawing.Size(40, 23)
        Me.Cmd_ClubCode.TabIndex = 145
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(174, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(237, 27)
        Me.Label11.TabIndex = 879
        Me.Label11.Text = " AFFILIATED CLUB MASTER "
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(7, 438)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 50)
        Me.Button2.TabIndex = 884
        Me.Button2.Text = "Exit [F11]"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmd_View
        '
        Me.cmd_View.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_View.Image = CType(resources.GetObject("cmd_View.Image"), System.Drawing.Image)
        Me.cmd_View.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_View.Location = New System.Drawing.Point(7, 136)
        Me.cmd_View.Name = "cmd_View"
        Me.cmd_View.Size = New System.Drawing.Size(137, 50)
        Me.cmd_View.TabIndex = 883
        Me.cmd_View.Text = "View[F9]"
        Me.cmd_View.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_View.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(7, 261)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(137, 50)
        Me.Button4.TabIndex = 881
        Me.Button4.Text = "Print[F10]"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'cmd_Add
        '
        Me.cmd_Add.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Add.Image = CType(resources.GetObject("cmd_Add.Image"), System.Drawing.Image)
        Me.cmd_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Add.Location = New System.Drawing.Point(7, 73)
        Me.cmd_Add.Name = "cmd_Add"
        Me.cmd_Add.Size = New System.Drawing.Size(137, 50)
        Me.cmd_Add.TabIndex = 882
        Me.cmd_Add.Text = "Add[F7]"
        Me.cmd_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_Add.UseVisualStyleBackColor = True
        '
        'cmd_Clear
        '
        Me.cmd_Clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Clear.Image = CType(resources.GetObject("cmd_Clear.Image"), System.Drawing.Image)
        Me.cmd_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Clear.Location = New System.Drawing.Point(7, 10)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(137, 50)
        Me.cmd_Clear.TabIndex = 880
        Me.cmd_Clear.Text = "Clear[F6]"
        Me.cmd_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_Clear.UseVisualStyleBackColor = True
        '
        'cmd_Freeze
        '
        Me.cmd_Freeze.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Freeze.Image = CType(resources.GetObject("cmd_Freeze.Image"), System.Drawing.Image)
        Me.cmd_Freeze.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Freeze.Location = New System.Drawing.Point(7, 199)
        Me.cmd_Freeze.Name = "cmd_Freeze"
        Me.cmd_Freeze.Size = New System.Drawing.Size(137, 50)
        Me.cmd_Freeze.TabIndex = 885
        Me.cmd_Freeze.Text = "Void[F8]"
        Me.cmd_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_Freeze.UseVisualStyleBackColor = True
        '
        'Browse
        '
        Me.Browse.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Browse.Location = New System.Drawing.Point(7, 319)
        Me.Browse.Name = "Browse"
        Me.Browse.Size = New System.Drawing.Size(137, 50)
        Me.Browse.TabIndex = 886
        Me.Browse.Text = "Browse"
        Me.Browse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Browse.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(7, 380)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 50)
        Me.Button1.TabIndex = 887
        Me.Button1.Text = "Authorise"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(210, 611)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 15)
        Me.Label12.TabIndex = 888
        Me.Label12.Text = "Press [F4] for Help"
        '
        'Gr2
        '
        Me.Gr2.BackColor = System.Drawing.Color.Transparent
        Me.Gr2.Controls.Add(Me.cmd_exit1)
        Me.Gr2.Controls.Add(Me.CMD_WINDOWS)
        Me.Gr2.Controls.Add(Me.CMD_DOS)
        Me.Gr2.Location = New System.Drawing.Point(476, 506)
        Me.Gr2.Name = "Gr2"
        Me.Gr2.Size = New System.Drawing.Size(372, 85)
        Me.Gr2.TabIndex = 918
        Me.Gr2.TabStop = False
        Me.Gr2.Visible = False
        '
        'cmd_exit1
        '
        Me.cmd_exit1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_exit1.Location = New System.Drawing.Point(247, 26)
        Me.cmd_exit1.Name = "cmd_exit1"
        Me.cmd_exit1.Size = New System.Drawing.Size(100, 30)
        Me.cmd_exit1.TabIndex = 2
        Me.cmd_exit1.Text = "EXIT"
        Me.cmd_exit1.UseVisualStyleBackColor = True
        '
        'CMD_WINDOWS
        '
        Me.CMD_WINDOWS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_WINDOWS.Location = New System.Drawing.Point(134, 26)
        Me.CMD_WINDOWS.Name = "CMD_WINDOWS"
        Me.CMD_WINDOWS.Size = New System.Drawing.Size(100, 30)
        Me.CMD_WINDOWS.TabIndex = 1
        Me.CMD_WINDOWS.Text = "WINDOWS"
        Me.CMD_WINDOWS.UseVisualStyleBackColor = True
        '
        'CMD_DOS
        '
        Me.CMD_DOS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_DOS.Location = New System.Drawing.Point(17, 26)
        Me.CMD_DOS.Name = "CMD_DOS"
        Me.CMD_DOS.Size = New System.Drawing.Size(100, 30)
        Me.CMD_DOS.TabIndex = 0
        Me.CMD_DOS.Text = "DOS"
        Me.CMD_DOS.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmd_Clear)
        Me.GroupBox1.Controls.Add(Me.cmd_Add)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cmd_View)
        Me.GroupBox1.Controls.Add(Me.Browse)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.cmd_Freeze)
        Me.GroupBox1.Location = New System.Drawing.Point(854, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(152, 501)
        Me.GroupBox1.TabIndex = 919
        Me.GroupBox1.TabStop = False
        '
        'FRM_MKGA_AffiliatedClubDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Gr2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_phone2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_fax)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_add1)
        Me.Controls.Add(Me.txt_pincode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_CorporateCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_website)
        Me.Controls.Add(Me.txt_add2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_clubcode)
        Me.Controls.Add(Me.lbl_CorporateName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_BillingBasis)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txt_clubname)
        Me.Controls.Add(Me.TXT_PHONE1)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_contact)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Cbo_PState)
        Me.Controls.Add(Me.Cbo_PCountry)
        Me.Controls.Add(Me.Cbo_PCity)
        Me.Controls.Add(Me.Cmd_ClubCode)
        Me.KeyPreview = True
        Me.Name = "FRM_MKGA_AffiliatedClubDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_MKGA_AffiliatedClubDetails"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Gr2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub

#End Region
    Public Sub checkValidation()
        boolchk = False
        '''********** Check CLUB Code is blank
        If txt_clubcode.Text = "" Then
            MessageBox.Show(" Club Code can't be blank ")
            txt_clubcode.Focus()
            Exit Sub
        End If
        If txt_clubname.Text = "" Then
            MessageBox.Show(" Club Name can't be blank ")
            txt_clubname.Focus()
            Exit Sub
        End If
        '''********** Check ADDRESS1 Name is blank
        If txt_add1.Text = "" Then
            MessageBox.Show(" Club Address1 can't be blank ")
            txt_add1.Focus()
            Exit Sub
        End If
        'praba
        If lbl_Freeze.Visible = True Then
            MessageBox.Show("This Record Already Void ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'If lbl_Freeze.Text <> "" Then
        '    MessageBox.Show("This Record Already Void ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Error)

        '    Exit Sub
        'End If

        '''********** Check ADDRESS2 Name is blank
        ''' 

        '--------- CHANGES BY NITESH STATEMENT CHANGED BY MOHANRAJU 16/JULY/2013
        '' '' '' ''If txt_add2.Text = "" Then
        '' '' '' ''    MessageBox.Show(" Club Address2 can't be blank ")
        '' '' '' ''    txt_add2.Focus()
        '' '' '' ''    Exit Sub
        '' '' '' ''End If
        '---------

        If Cbo_PCity.Text = "" Then
            MessageBox.Show(" City Name can't be blank ")
            Cbo_PCity.Focus()
            Exit Sub
        End If
        '' ------Phone no.1--------------
        If TXT_PHONE1.Text = "" Then
            MessageBox.Show(" Phone No. can't be blank ")
            TXT_PHONE1.Focus()
            Exit Sub
        End If
        '--------------Contact person--------------
        If txt_contact.Text = "" Then
            MessageBox.Show(" Contact Person can't be blank ")
            txt_contact.Focus()
            Exit Sub
        End If
        boolchk = True
    End Sub
    Private Sub FRM_MKGA_AffiliatedClubDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Call Resize_Form()

        'Show()
        'AppPath = Application.StartupPath
        'gconnection.GetServer()


        txt_clubcode.Focus()
        Call facilities()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If

        'If gUserCategory <> "S" Then
        '    Call GetRights()
        'End If
        'Txt_Subcode.Focus()
        'AppPath = Application.StartupPath
        'gconnection.GetServer()
        Call City()
        Call State()
        Call Country()
        ' Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub Resize_Form()
        Dim cControl As Control
        Dim i_i As Integer
        Dim J, K, L, M, n, o, P, Q, R, S, T, U As Integer
        'If (Screen.PrimaryScreen.Bounds.Height = 768) And (Screen.PrimaryScreen.Bounds.Width = 1366) Then
        '    Exit Sub
        'End If
        J = 732
        K = 1016
        Me.ResizeRedraw = True

        T = CInt(Screen.PrimaryScreen.WorkingArea.Size.Height)
        U = CInt(Screen.PrimaryScreen.WorkingArea.Size.Width)
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        If U = 800 Then
            T = T - 20
        End If
        If U = 1280 Then
            T = T - 20
        End If
        If U = 1360 Then
            T = T - 55
        End If
        If U = 1366 Then
            T = T - 55
        End If
        Me.Width = U
        Me.Height = T
        With Me
            For i_i = 0 To .Controls.Count - 1
                ' MsgBox(Controls(i_i).Name)
                If TypeOf .Controls(i_i) Is Form Then
                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0
                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If
                ElseIf TypeOf .Controls(i_i) Is Panel Then


                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        If Controls(i_i).Name = "GroupBox1" Then
                            L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))

                            If U = 800 Then
                                L = L + 50
                            End If
                            If U = 1280 Then
                                L = L + 50
                            End If
                            If U = 1360 Then
                                L = L + 75
                            End If
                            If U = 1366 Then
                                L = L + 75
                            End If
                        Else
                            L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                            ' L = L - 5
                        End If
                    End If
                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0
                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If
                    .Controls(i_i).Left = L
                    .Controls(i_i).Top = M
                    If .Controls(i_i).Size.Width = 0 Then
                        n = 0
                    Else
                        n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Size.Height = 0 Then
                        o = 0
                    Else
                        o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If
                    .Controls(i_i).Width = n
                    .Controls(i_i).Height = o

                    For Each cControl In .Controls(i_i).Controls

                        If cControl.Location.X = 0 Then
                            R = 0
                        Else
                            R = cControl.Location.X + CInt((cControl.Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                        End If
                        If cControl.Location.Y = 0 Then
                            S = 0
                        Else
                            S = cControl.Location.Y + CInt((cControl.Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                        End If

                        cControl.Left = R
                        cControl.Top = S


                        If cControl.Size.Width = 0 Then
                            P = 0
                        Else
                            P = (cControl.Size.Width + CInt((cControl.Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width)))))
                        End If

                        If cControl.Size.Height = 0 Then
                            Q = 0
                        Else
                            Q = (cControl.Size.Height + CInt((cControl.Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height)))))
                        End If

                        cControl.Width = P
                        cControl.Height = Q
                    Next
                ElseIf TypeOf .Controls(i_i) Is GroupBox Then

                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        If Controls(i_i).Name = "GroupBox1" Then
                            L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))

                            If U = 800 Then
                                L = L + 45
                            End If
                            If U = 1280 Then
                                L = L + 45
                            End If
                            If U = 1360 Then
                                L = L + 70
                            End If
                            If U = 1366 Then
                                L = L + 70
                            End If
                        Else
                            L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                            ' L = L - 5
                        End If
                    End If

                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0
                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Left = L
                    .Controls(i_i).Top = M
                    If .Controls(i_i).Size.Width = 0 Then
                        n = 0
                    Else
                        n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Size.Height = 0 Then
                        o = 0
                    Else
                        o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Width = n
                    .Controls(i_i).Height = o

                    For Each cControl In .Controls(i_i).Controls

                        If cControl.Location.X = 0 Then
                            R = 0
                        Else
                            R = cControl.Location.X + CInt((cControl.Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                        End If
                        If cControl.Location.Y = 0 Then
                            S = 0
                        Else
                            S = cControl.Location.Y + CInt((cControl.Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                        End If

                        cControl.Left = R
                        cControl.Top = S

                        If cControl.Size.Width = 0 Then
                            P = 0
                        Else
                            P = (cControl.Size.Width + CInt((cControl.Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width)))))
                        End If

                        If cControl.Size.Height = 0 Then
                            Q = 0
                        Else
                            Q = (cControl.Size.Height + CInt((cControl.Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height)))))
                        End If

                        cControl.Width = P
                        cControl.Height = Q
                    Next
                ElseIf TypeOf .Controls(i_i) Is Label Then
                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0

                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Left = L
                    .Controls(i_i).Top = M
                    If .Controls(i_i).Size.Width = 0 Then
                        n = 0
                    Else
                        n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Size.Height = 0 Then
                        o = 0
                    Else
                        o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Width = n
                    .Controls(i_i).Height = o
                ElseIf TypeOf .Controls(i_i) Is TextBox Then
                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0

                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Left = L
                    .Controls(i_i).Top = M
                    If .Controls(i_i).Size.Width = 0 Then
                        n = 0
                    Else
                        n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Size.Height = 0 Then
                        o = 0
                    Else
                        o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Width = n
                    .Controls(i_i).Height = o
                ElseIf TypeOf .Controls(i_i) Is ComboBox Then
                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0

                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Left = L
                    .Controls(i_i).Top = M
                    If .Controls(i_i).Size.Width = 0 Then
                        n = 0
                    Else
                        n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Size.Height = 0 Then
                        o = 0
                    Else
                        o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Width = n
                    .Controls(i_i).Height = o
                ElseIf TypeOf .Controls(i_i) Is DateTimePicker Then
                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0

                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Left = L
                    .Controls(i_i).Top = M
                    If .Controls(i_i).Size.Width = 0 Then
                        n = 0
                    Else
                        n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Size.Height = 0 Then
                        o = 0
                    Else
                        o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Width = n
                    .Controls(i_i).Height = o
                ElseIf TypeOf .Controls(i_i) Is PictureBox Then
                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0

                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Left = L
                    .Controls(i_i).Top = M
                    If .Controls(i_i).Size.Width = 0 Then
                        n = 0
                    Else
                        n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Size.Height = 0 Then
                        o = 0
                    Else
                        o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Width = n
                    .Controls(i_i).Height = o
                ElseIf TypeOf .Controls(i_i) Is CheckBox Then
                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0

                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Left = L
                    .Controls(i_i).Top = M
                    If .Controls(i_i).Size.Width = 0 Then
                        n = 0
                    Else
                        n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Size.Height = 0 Then
                        o = 0
                    Else
                        o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Width = n
                    .Controls(i_i).Height = o
                ElseIf TypeOf .Controls(i_i) Is TabControl Then
                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0

                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Left = L
                    .Controls(i_i).Top = M
                    If .Controls(i_i).Size.Width = 0 Then
                        n = 0
                    Else
                        n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Size.Height = 0 Then
                        o = 0
                    Else
                        o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Width = n
                    .Controls(i_i).Height = o
                ElseIf TypeOf .Controls(i_i) Is Button Then
                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        'If Controls(i_i).Name = "Cmd_Clear" Or Controls(i_i).Name = "Cmd_Add" Or Controls(i_i).Name = "Cmd_Delete" Or Controls(i_i).Name = "Cmd_View" Or Controls(i_i).Name = "Cmd_Print" Or Controls(i_i).Name = "Cmd_Export" Or Controls(i_i).Name = "Cmd_Exit" Or Controls(i_i).Name = "Cmd_PendingBill" Or Controls(i_i).Name = "Cmd_Bill" Then
                        If Controls(i_i).Name = "cmd_Clear" Or Controls(i_i).Name = "cmd_Add" Or Controls(i_i).Name = "cmd_View" Or Controls(i_i).Name = "cmd_Freeze" Or Controls(i_i).Name = "Button4" Or Controls(i_i).Name = "Button1" Or Controls(i_i).Name = "Button2" Then
                            L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))

                            If U = 800 Then
                                L = L + 50
                            End If
                            If U = 1280 Then
                                L = L + 50
                            End If
                            If U = 1360 Then
                                L = L + 75
                            End If
                            If U = 1366 Then
                                L = L + 75
                            End If
                        Else
                            L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))

                            ' L = L - 5
                        End If
                        'L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0

                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Left = L
                    .Controls(i_i).Top = M
                    If .Controls(i_i).Size.Width = 0 Then
                        n = 0
                    Else
                        n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Size.Height = 0 Then
                        o = 0
                    Else
                        o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Width = n
                    .Controls(i_i).Height = o
                End If
            Next i_i
        End With
    End Sub


    Private Sub cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Public Function facilities()
        Dim I As Integer
        sqlstring = "select isnull(FACILITYDESCRIPTION,'')as FACILITYDESCRIPTION from Tbl_AffiliatedFacilityMaster where FREEZE='N'"
        gconnection.getDataSet(sqlstring, "Tbl_AffiliatedFacilityMaster")
        If gdataset.Tables("Tbl_AffiliatedFacilityMaster").Rows.Count > 0 Then
            For I = 0 To gdataset.Tables("Tbl_AffiliatedFacilityMaster").Rows.Count - 1
                With gdataset.Tables("Tbl_AffiliatedFacilityMaster").Rows(I)
                    ' LIST_FACILITY.Items.Add(Trim(.Item("FACILITYDESCRIPTION")))
                End With
            Next I
        End If
    End Function
    Private Sub txt_clubcode_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim vsplit(), type() As String
        Try
            If Trim(txt_clubcode.Text) <> "" Then
                sqlstring = "SELECT ISNULL(CLUBCODE,'')AS CLUBCODE,ISNULL(CLUBNAME,'')AS CLUBNAME,ISNULL(ADDRESS1,'')AS ADDRESS1,"
                sqlstring = sqlstring & "ISNULL(ADDRESS2,'')AS ADDRESS2,ISNULL(CITY,'')AS CITY,ISNULL(STATE,'')AS STATE,ISNULL(COUNTRY,'')AS COUNTRY,ISNULL(PINCODE,'')AS PINCODE,"
                sqlstring = sqlstring & "ISNULL(PHONE1,'')AS PHONE1,ISNULL(PHONE2,'')AS PHONE2,ISNULL(EMAIL,'')AS EMAIL,ISNULL(FAX,'')AS FAX,ISNULL(WEBSITE,'')AS WEBSITE,ISNULL(CONTACTPERSON,'')AS CONTACTPERSON,"
                sqlstring = sqlstring & "ISNULL(ROOM,'')AS ROOM,ISNULL(FACILITY,'') AS FACILITY,ISNULL(FREEZE,'')AS FREEZE,ISNULL(ADDUSERID,'')AS ADDUSERID,ISNULL(ADDDATETIME,'')AS ADDDATETIME,ISNULL(UPDDATETIME,'')AS UPDATEDATE,ISNULL(UPDUSERID,'')AS UPDATEUSER "
                sqlstring = sqlstring & " FROM AFFILIATEDCLUBDETAILS WHERE CLUBCODE='" & Trim(txt_clubcode.Text) & "'"
                gconnection.getDataSet(sqlstring, "AFFILIATEDCLUBDETAILS")
                If gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows.Count > 0 Then
                    txt_clubcode.Text = Trim(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("CLUBCODE"))
                    txt_clubname.Text = Trim(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("CLUBNAME"))
                    txt_add1.Text = Trim(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("ADDRESS1"))
                    txt_add2.Text = Trim(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("ADDRESS2"))
                    Cbo_PCity.Text = Trim(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("CITY"))
                    Cbo_PState.Text = Trim(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("STATE"))
                    Cbo_PCountry.Text = Trim(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("COUNTRY"))
                    TXT_PHONE1.Text = Trim(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("PHONE1"))
                    txt_phone2.Text = Trim(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("PHONE2"))
                    txt_pincode.Text = Trim(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("PINCODE"))
                    txt_fax.Text = Trim(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("FAX"))
                    txt_email.Text = Trim(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("EMAIL"))
                    txt_website.Text = Trim(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("WEBSITE"))
                    txt_contact.Text = Trim(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("CONTACTPERSON"))
                    '  txtFacilities.Text = Trim(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("FACILITY"))
                    If Trim(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("ROOM")) = "Y" Then
                        '   chk_yes.Checked = True
                    Else
                        '   chk_no.Checked = True
                    End If
                    txt_clubname.Focus()
                    txt_clubcode.ReadOnly = True
                    If gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("Freeze") = "Y" Then
                        Me.lbl_Freeze.Visible = True
                        Me.lbl_Freeze.Text = ""
                        Me.lbl_Freeze.Text = "Record Freezed  On " & Format(CDate(gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows(0).Item("UPDATEDATE")), "dd/MM/yyyy")
                        Me.cmd_Freeze.Text = "Void[F8]"
                    Else
                        Me.lbl_Freeze.Visible = False
                        Me.lbl_Freeze.Text = "Record Freezed  On "
                        Me.cmd_Freeze.Text = "Void[F8]"
                    End If
                    Me.cmd_Add.Text = "Update[F7]"
                Else
                    Me.lbl_Freeze.Visible = False
                    Me.lbl_Freeze.Text = "Record Freezed  On "
                    Me.cmd_Add.Text = "Add[F7]"
                    txt_clubcode.ReadOnly = False
                    txt_clubname.Focus()
                End If
            Else
                txt_clubcode.Text = ""
                txt_clubname.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub txt_clubcode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            If txt_clubcode.Text = "" Then
                Call Cmd_ClubCode_Click(sender, e)
            Else
                Call txt_clubcode_Validated(sender, e)
            End If
        End If
    End Sub


    Private Sub txt_clubname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txt_add1.Focus()
        End If
    End Sub

    Private Sub txt_add1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txt_add2.Focus()
        End If
    End Sub

    Private Sub txt_add2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            Cbo_PCity.Focus()
        End If
    End Sub

    Private Sub txt_city_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            Cbo_PState.Focus()
        End If
    End Sub

    Private Sub txt_state_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txt_pincode.Focus()
        End If
    End Sub

    Private Sub txt_pincode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            TXT_PHONE1.Focus()
        End If
    End Sub

    Private Sub TXT_PHONE1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_phone2.Focus()
        End If
    End Sub

    Private Sub txt_phone2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_fax.Focus()
        End If
    End Sub

    Private Sub txt_fax_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txt_email.Focus()
        End If
    End Sub

    Private Sub txt_email_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txt_website.Focus()
        End If
    End Sub

    Private Sub txt_website_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            '   chk_yes.Focus()
        End If
    End Sub

    Private Sub chk_yes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txt_contact.Focus()
    End Sub

    Private Sub chk_no_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txt_contact.Focus()
    End Sub

    Private Sub txt_contact_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            cmd_Add.Focus()
        End If
    End Sub


    Private Sub AffiliatedClubDetails_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Call cmd_Clear_Click(sender, e)
        ElseIf e.KeyCode = Keys.F7 Then
            Call cmd_Add_Click(sender, e)
        ElseIf e.KeyCode = Keys.F8 Then
            Call cmd_Freeze_Click(sender, e)
        ElseIf e.KeyCode = Keys.F9 Then
            'Call cmd_View_Click(sender, e)
            Gr2.Visible = True
        ElseIf e.KeyCode = Keys.F10 Then
            Call Cmd_Print_Click(sender, e)
        ElseIf e.KeyCode = Keys.F11 Then
            Call cmd_Exit_Click(sender, e)
        ElseIf e.KeyCode = Keys.F3 Then
            Call Button1_Click_1(sender, e)
            '  End If
            'ElseIf e.KeyCode = Keys.F4 Then
            '    Call Cmd_ClubCode_Click(sender, e)
        End If
    End Sub

    'Private Sub cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Call SHOWAFFCLUBDETAILS()
    'End Sub
    Public Sub SHOWAFFCLUBDETAILS()
        Try
            Dim SQL As String

            SQL = "SELECT * FROM VW_AFFILIATEDCLUBDETAILS WHERE CLUBCODE='" & txt_clubcode.Text & "'"

        Catch ex As Exception
            MessageBox.Show(ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

    End Sub


    Private Sub Cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call cmd_View_Click(sender, e)
    End Sub

    Private Sub txt_add2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LIST_FACILITY_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim vcount As String
        'Dim Loopindex As Long
        'Dim vsplit(), str As String
        'Dim i As Integer
        'txtFacilities.Text = ""
        'vcount = ""
        'If LIST_FACILITY.CheckedItems.Count > 0 Then
        '    For i = 0 To LIST_FACILITY.CheckedItems.Count - 1
        '        'vsplit = Split(LIST_FACILITY.CheckedItems(i), "==>")
        '        'str = str & vsplit(0) & ","
        '        str = LIST_FACILITY.Items(i) & ","

        '    Next
        '    txtFacilities.Text = Trim(str)
        'Else
        '    txtFacilities.Text = LIST_FACILITY.Items(0) & ","
        'End If

    End Sub
    Private Sub GetRights()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql, SQLSTRING As String
        Dim M1 As New MainMenu
        Dim chstr As String
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='MEMBER' AND MODULENAME LIKE '" & Trim(GmoduleName) & "%'"
        gconnection.getDataSet(SQLSTRING, "USER")
        If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                With gdataset.Tables("USER").Rows(i)
                    chstr = abcdMINUS(.Item("RIGHTS"))
                End With
            Next
        End If
        Me.cmd_Add.Enabled = False
        Me.cmd_Freeze.Enabled = False
        Me.cmd_View.Enabled = False
        ' Me.Cmd_Print.Enabled = False
        Me.Button4.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.cmd_Add.Enabled = True
                    Me.cmd_Freeze.Enabled = True
                    Me.cmd_View.Enabled = True
                    Me.Button4.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.cmd_Add.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.cmd_Add.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.cmd_Add.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    Me.cmd_Freeze.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.cmd_View.Enabled = True
                End If
                If Right(x) = "P" Then
                    Me.Cmd_Print.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub Cmd_ClubCode_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnFacility_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        '  Dim vf As New AffiliatedClubFacility
        ' vf.Show()

    End Sub


    Private Sub Cmd_ClubCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_ClubCode.Click
        Dim vform As New LIST_OPERATION1
        gSQLString = "Select isnull(CLUBCODE,'')as CLUBCODE,isnull(CLUBNAME,'')as CLUBNAME,isnull(address1,'')as Address,isnull(city,'')as City from VW_AFFILIATEDCLUBDETAILS"
        M_WhereCondition = " "
        vform.vCaption = "Affiliated club Help"
        vform.Field = "Clubcode,Clubname"

        vform.CMB_SRC_FIELDS.Select()
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_clubcode.Text = Trim(vform.keyfield & "")
            txt_clubname.Select()
            txt_clubcode_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing
        cmd_Add.Text = "Update[F7]"
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub
    Public Sub City()
        Dim i As Integer
        sqlstring = "SELECT distinct(Name) FROM Tbl_CityMaster where freeze<>'Y' and isnull(name,'')<>'' "
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            Cbo_PCity.Items.Add(dt.Rows(Itration).Item("Name"))
        Next
    End Sub
    Public Sub Country()
        Dim i As Integer
        sqlstring = "SELECT distinct(Name) FROM Tbl_CountryMaster where freeze<>'Y' and isnull(name,'')<>'' "
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            Cbo_PCountry.Items.Add(dt.Rows(Itration).Item("Name"))
        Next
    End Sub
    Public Sub State()
        Dim i As Integer
        sqlstring = "SELECT distinct(Name) FROM Tbl_StateMaster where freeze<>'Y'and isnull(name,'')<>''  "
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            Cbo_PState.Items.Add(dt.Rows(Itration).Item("Name"))
        Next
    End Sub

    Private Sub txt_pincode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pincode.TextChanged

    End Sub

    Private Sub txt_pincode_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pincode.KeyPress
        getAlphanumeric(e)
    End Sub

    Private Sub TXT_PHONE1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_PHONE1.TextChanged

    End Sub

    Private Sub TXT_PHONE1_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_PHONE1.KeyPress
        getNumeric(e)
    End Sub

    Private Sub txt_phone2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_phone2.TextChanged

    End Sub

    Private Sub txt_phone2_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_phone2.KeyPress
        getNumeric(e)
    End Sub

    Private Sub txt_clubcode_Click(sender As Object, e As EventArgs) Handles txt_clubcode.Click

    End Sub

    Private Sub txt_clubcode_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_clubcode.TextChanged

    End Sub

    Private Sub txt_clubcode_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_clubcode.KeyPress
        getAlphanumeric(e)
    End Sub

    Private Sub txt_clubcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_clubcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_clubcode.Text = "" Then
                Cmd_ClubCode_Click(sender, e)
            Else
                txt_clubcode_Validated(sender, e)
            End If
        ElseIf e.KeyCode = Keys.F4 Then
            Cmd_ClubCode_Click(sender, e)
        End If

    End Sub

    Private Sub txt_clubname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_clubname.TextChanged

    End Sub

    Private Sub txt_clubname_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_clubname.KeyPress
        getCharater(e)
    End Sub

    Private Sub txt_clubname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_clubname.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_add1.Focus()
        End If
    End Sub

    Private Sub txt_add1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_add1.TextChanged

    End Sub

    Private Sub txt_add1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_add1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_add2.Focus()
        End If
    End Sub

    Private Sub txt_add2_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_add2.TextChanged

    End Sub

    Private Sub txt_add2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_add2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cbo_PCity.Focus()
        End If
    End Sub

    Private Sub Cbo_PCity_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_PCity.SelectedIndexChanged
        Dim sqlstr As String

        'If Cbo_PState.Text = "LODZ" Then
        '    Cbo_PCountry.Text = "POLAND"
        'End If

        If Cbo_PCity.Text <> "" Then
            sqlstr = " SELECT ISNULL(STATE,'') AS STATE,ISNULL(COUNTRY,'') AS COUNTRY FROM Tbl_CityMaster WHERE NAME='" & Trim(Cbo_PCity.Text) & "'"
            gconnection.getDataSet(sqlstr, "Master")
            Dim A As String
            A = gdataset.Tables("Master").Rows(0).Item("STATE")
            Cbo_PState.Text = gdataset.Tables("Master").Rows(0).Item("STATE")
            Cbo_PCountry.Text = gdataset.Tables("Master").Rows(0).Item("COUNTRY")
        End If
    End Sub
    Public Function CheckDBNull(ByVal obj As Object, Optional ByVal ObjectType As enumObjectType = enumObjectType.StrType) As Object
        Dim objReturn As Object
        objReturn = obj
        If ObjectType = enumObjectType.StrType And IsDBNull(obj) Then
            objReturn = ""
        ElseIf ObjectType = enumObjectType.IntType And IsDBNull(obj) Then
            objReturn = 0
        ElseIf ObjectType = enumObjectType.DblType And IsDBNull(obj) Then
            objReturn = 0.0
        End If
        Return objReturn
    End Function



    Enum enumObjectType
        StrType = 0
        IntType = 1
        DblType = 2
    End Enum



    Private Sub Cbo_PCity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cbo_PCity.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_pincode.Focus()
        End If
    End Sub

    Private Sub Cbo_PState_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_PState.SelectedIndexChanged

    End Sub

    Private Sub Cbo_PState_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cbo_PState.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cbo_PCountry.Focus()
        End If
    End Sub

    Private Sub Cbo_PCountry_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_PCountry.SelectedIndexChanged
        
    End Sub

    Private Sub Cbo_PCountry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cbo_PCountry.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_pincode.Focus()
        End If
    End Sub

    Private Sub TXT_PHONE1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_PHONE1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_phone2.Focus()
        End If
    End Sub

    Private Sub txt_pincode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_pincode.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXT_PHONE1.Focus()
        End If
    End Sub

    Private Sub txt_phone2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_phone2.KeyDown
        'txt_fax.Focus()
        If e.KeyCode = Keys.Enter Then
            txt_fax.Focus()
        End If
    End Sub

    Private Sub txt_email_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_email.TextChanged

    End Sub

    Private Sub txt_fax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_fax.TextChanged

    End Sub

    Private Sub txt_fax_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_fax.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_email.Focus()
        End If
    End Sub

    Private Sub txt_email_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_email.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_website.Focus()
        End If
    End Sub

    Private Sub txt_website_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_website.TextChanged

    End Sub

    Private Sub txt_website_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_website.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_contact.Focus()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim SQL As String
            '  Dim SQL_ADDR As String
            ' Dim CATEGORY() As String
            'Dim i As Integer
            ' Dim Viewer As New ReportViwer
            ' Dim r As New AFFCLUBLIST
            SQL = "SELECT * FROM VW_AFFILIATEDCLUBDETAILS "
            '    Viewer.ssql = SQL
            '    Viewer.Report = r
            '    Viewer.TableName = "VW_AFFILIATEDCLUBDETAILS"
            ' Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
    End Sub

    Private Sub Btn_Validation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        System.Diagnostics.Process.Start(AppPath & "/STUDY/AFFILIATEDCLUBMASTER.XLS")
    End Sub

    Private Sub cmd_Clear_Click(sender As Object, e As EventArgs) Handles cmd_Clear.Click
        txt_add1.Text = ""
        txt_add2.Text = ""
        Cbo_PCity.Text = ""
        Cbo_PCity.SelectedIndex = -1
        Cbo_PState.SelectedIndex = -1
        Cbo_PCountry.SelectedIndex = -1
        txt_clubcode.Text = ""
        txt_clubname.Text = ""
        txt_contact.Text = ""
        txt_email.Text = ""
        txt_fax.Text = ""
        TXT_PHONE1.Text = ""
        txt_phone2.Text = ""
        txt_pincode.Text = ""
        Cbo_PState.Text = ""
        txt_website.Text = ""
        cmd_Add.Text = "Add[F7]"
        cmd_Freeze.Text = "Void[F8]"
        lbl_Freeze.Visible = False
        txt_clubcode.ReadOnly = False
        txt_clubcode.Focus()
        Gr2.Visible = False
        '  LIST_FACILITY.Items.Clear()
        Call facilities()
        ' txtFacilities.Text = ""
    End Sub

    Private Sub cmd_Add_Click(sender As Object, e As EventArgs) Handles cmd_Add.Click
        Dim SQLSTR As String

        Try

            If cmd_Add.Text = "Add[F7]" Then
                Call checkValidation() '''--->Check Validation
                If boolchk = False Then Exit Sub
                SQLSTR = "Insert into AFFILIATEDCLUBDETAILS (CLUBCODE,CLUBNAME,ADDRESS1,ADDRESS2,CITY,STATE,COUNTRY,PINCODE,"
                SQLSTR = SQLSTR & "PHONE1,PHONE2,FAX,EMAIL,WEBSITE,Contactperson,freeze,Adduserid,Adddatetime,UPDUSERID,UPDdatetime)"
                SQLSTR = SQLSTR & "Values('" & Trim(txt_clubcode.Text) & "','" & Trim(txt_clubname.Text) & "','" & Trim(txt_add1.Text) & "',"
                SQLSTR = SQLSTR & "'" & Trim(txt_add2.Text) & "','" & Trim(Cbo_PCity.Text) & "','" & Trim(Cbo_PState.Text) & "','" & Trim(Cbo_PCountry.Text) & "',"
                SQLSTR = SQLSTR & "'" & Trim(txt_pincode.Text) & "', '" & Trim(TXT_PHONE1.Text) & "','" & Trim(txt_phone2.Text) & "',"
                SQLSTR = SQLSTR & "'" & Trim(txt_fax.Text) & "','" & Trim(txt_email.Text) & "',"

                SQLSTR = SQLSTR & "'" & Trim(txt_website.Text) & "','" & Trim(txt_contact.Text) & "','N','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm") & "','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm") & "')"
                gconnection.dataOperation(1, SQLSTR, "AFFILIATEDCLUBDETAILS")
                MessageBox.Show("Record Saved Successfully", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf cmd_Add.Text = "Update[F7]" Then
                Call checkValidation() '''--->Check Validation
                If boolchk = False Then Exit Sub
                If Mid(Me.cmd_Add.Text, 1, 1) = "U" Then
                    If Me.lbl_Freeze.Visible = True Then
                        MessageBox.Show(" The Freezed Record Cannot Be Updated", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        boolchk = False
                        Exit Sub
                    End If
                End If
                SQLSTR = "Update AFFILIATEDCLUBDETAILS set clubcode = '" & Trim(txt_clubcode.Text) & "',clubname = '" & Trim(txt_clubname.Text) & "',address1 = '" & Trim(txt_add1.Text) & "',"
                SQLSTR = SQLSTR & "address2 = '" & Trim(txt_add2.Text) & "',City = '" & Trim(Cbo_PCity.Text) & "',State = '" & Trim(Cbo_PState.Text) & "',COUNTRY ='" & Trim(Cbo_PCountry.Text) & "',Pincode = '" & Trim(txt_pincode.Text) & "',"
                SQLSTR = SQLSTR & "Phone1='" & Trim(TXT_PHONE1.Text) & "',Phone2 = '" & Trim(txt_phone2.Text) & "',Fax = '" & Trim(txt_fax.Text) & "',"
                SQLSTR = SQLSTR & "Email='" & Trim(txt_email.Text) & "',"

                SQLSTR = SQLSTR & "Website='" & Trim(txt_website.Text) & "',Contactperson='" & Trim(txt_contact.Text) & "',"
                SQLSTR = SQLSTR & "Freeze='N',Upduserid='" & Trim(gUsername) & "',Upddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm") & "' Where Clubcode='" & Trim(txt_clubcode.Text) & "'"
                gconnection.dataOperation(2, SQLSTR, "AFFILIATEDCLUBDETAILS")
                '---------------INSERT INTO LOG--------------
                SQLSTR = "Insert into AFFILIATEDCLUBDETAILS_LOG (CLUBCODE,CLUBNAME,ADDRESS1,ADDRESS2,CITY,STATE,COUNTRY,PINCODE,"
                SQLSTR = SQLSTR & "PHONE1,PHONE2,FAX,EMAIL,WEBSITE,Contactperson,freeze,Adduserid,Adddatetime,UPDUSERID,UPDdatetime)"
                SQLSTR = SQLSTR & "Values('" & Trim(txt_clubcode.Text) & "','" & Trim(txt_clubname.Text) & "','" & Trim(txt_add1.Text) & "',"
                SQLSTR = SQLSTR & "'" & Trim(txt_add2.Text) & "','" & Trim(Cbo_PCity.Text) & "','" & Trim(Cbo_PState.Text) & "','" & Trim(Cbo_PCountry.Text) & "',"
                SQLSTR = SQLSTR & "'" & Trim(txt_pincode.Text) & "', '" & Trim(TXT_PHONE1.Text) & "','" & Trim(txt_phone2.Text) & "',"
                SQLSTR = SQLSTR & "'" & Trim(txt_fax.Text) & "','" & Trim(txt_email.Text) & "',"

                SQLSTR = SQLSTR & "'" & Trim(txt_website.Text) & "','" & Trim(txt_contact.Text) & "','N','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm") & "','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm") & "')"
                gconnection.dataOperation(1, SQLSTR, "AFFILIATEDCLUBDETAILS")
                ' MsgBox("Record Updated", MsgBoxStyle.OkOnly)
                MessageBox.Show("Record Updated Successfully", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Call cmd_Clear_Click(sender, e)
            End If
            Call cmd_Clear_Click(sender, e)

        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub cmd_View_Click(sender As Object, e As EventArgs) Handles cmd_View.Click
        Gr2.Visible = True
    End Sub

    Private Sub cmd_Freeze_Click(sender As Object, e As EventArgs) Handles cmd_Freeze.Click
        Call checkValidation() ''-->Check Validation
        If boolchk = False Then Exit Sub
        If Mid(Me.cmd_Freeze.Text, 1, 1) = "V" Then
            sqlstring = "select isnull(clubcode,'')as clubcode,isnull(clubname,'')as clubname from AFFILIATEDCLUBDETAILS where clubcode='" & Trim(txt_clubcode.Text) & "'"
            gconnection.getDataSet(sqlstring, "AFFILIATEDCLUBDETAILS")
            If gdataset.Tables("AFFILIATEDCLUBDETAILS").Rows.Count > 0 Then
                sqlstring = "UPDATE  AFFILIATEDCLUBDETAILS "
                sqlstring = sqlstring & " SET Freeze= 'Y',UpdUserid='" & gUsername & " ',Upddatetime='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
                sqlstring = sqlstring & " WHERE CLUBCODE = '" & txt_clubcode.Text & " '"
                gconnection.dataOperation(3, sqlstring, "AFFILIATEDCLUBDETAILS")
                ' MsgBox("Record Freezed", MsgBoxStyle.OkOnly)
                'INSERT INTO LOG
                sqlstring = "Insert into AFFILIATEDCLUBDETAILS_LOG (CLUBCODE,CLUBNAME,ADDRESS1,ADDRESS2,CITY,STATE,COUNTRY,PINCODE,"
                sqlstring = sqlstring & "PHONE1,PHONE2,FAX,EMAIL,WEBSITE,Contactperson,freeze,Adduserid,Adddatetime,UPDUSERID,UPDdatetime)"
                sqlstring = sqlstring & "Values('" & Trim(txt_clubcode.Text) & "','" & Trim(txt_clubname.Text) & "','" & Trim(txt_add1.Text) & "',"
                sqlstring = sqlstring & "'" & Trim(txt_add2.Text) & "','" & Trim(Cbo_PCity.Text) & "','" & Trim(Cbo_PState.Text) & "','" & Trim(Cbo_PCountry.Text) & "',"
                sqlstring = sqlstring & "'" & Trim(txt_pincode.Text) & "', '" & Trim(TXT_PHONE1.Text) & "','" & Trim(txt_phone2.Text) & "',"
                sqlstring = sqlstring & "'" & Trim(txt_fax.Text) & "','" & Trim(txt_email.Text) & "',"

                sqlstring = sqlstring & "'" & Trim(txt_website.Text) & "','" & Trim(txt_contact.Text) & "','N','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm") & "','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm") & "')"
                gconnection.dataOperation(1, sqlstring, "AFFILIATEDCLUBDETAILS")
                ' MsgBox("Record Updated", MsgBoxStyle.OkOnly)
                Me.cmd_Clear_Click(sender, e)
                cmd_Add.Text = "Add[F7]"
            Else
                MsgBox("Not A Valid CLUB CODE", MsgBoxStyle.Information)
                Me.cmd_Clear_Click(sender, e)
            End If
        ElseIf Mid(Me.cmd_Freeze.Text, 1, 1) = "U" Then
            sqlstring = "UPDATE  AFFILIATEDCLUBDETAILS"
            sqlstring = sqlstring & " SET Freeze= 'N',UpdUserid='" & gUsername & " ', UpdDatetime='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
            sqlstring = sqlstring & " WHERE CLUBCODE= '" & txt_clubcode.Text & " '"
            gconnection.dataOperation(4, sqlstring, "AFFILIATEDCLUBDETAILS")
            'INSERT INTO LOG
            sqlstring = "Insert into AFFILIATEDCLUBDETAILS_LOG (CLUBCODE,CLUBNAME,ADDRESS1,ADDRESS2,CITY,STATE,COUNTRY,PINCODE,"
            sqlstring = sqlstring & "PHONE1,PHONE2,FAX,EMAIL,WEBSITE,Contactperson,freeze,Adduserid,Adddatetime,UPDUSERID,UPDdatetime)"
            sqlstring = sqlstring & "Values('" & Trim(txt_clubcode.Text) & "','" & Trim(txt_clubname.Text) & "','" & Trim(txt_add1.Text) & "',"
            sqlstring = sqlstring & "'" & Trim(txt_add2.Text) & "','" & Trim(Cbo_PCity.Text) & "','" & Trim(Cbo_PState.Text) & "','" & Trim(Cbo_PCountry.Text) & "',"
            sqlstring = sqlstring & "'" & Trim(txt_pincode.Text) & "', '" & Trim(TXT_PHONE1.Text) & "','" & Trim(txt_phone2.Text) & "',"
            sqlstring = sqlstring & "'" & Trim(txt_fax.Text) & "','" & Trim(txt_email.Text) & "',"

            sqlstring = sqlstring & "'" & Trim(txt_website.Text) & "','" & Trim(txt_contact.Text) & "','N','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm") & "','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm") & "')"
            gconnection.dataOperation(1, sqlstring, "AFFILIATEDCLUBDETAILS")

            ' MsgBox("Record Unfreezed", MsgBoxStyle.OkOnly)
            Me.cmd_Clear_Click(sender, e)
            cmd_Add.Text = "Add[F7]"
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Browse.Click
        brows = True
        Dim VIEW1 As New VIEWHDR
        VIEW1.Show()
        VIEW1.DTGRDHDR.DataSource = Nothing
        VIEW1.DTGRDHDR.Rows.Clear()
        Dim STRQUERY As String
        STRQUERY = "SELECT * FROM VW_AFFILIATEDCLUBDETAILS"
        gconnection.getDataSet(STRQUERY, "authorize")

        Call VIEW1.LOADGRID(gdataset.Tables("authorize"), True, gcompanyname, "SELECT * FROM VW_AFFILIATEDCLUBDETAILS", "CLUBCODE", 1, Me.txt_clubcode)
        'VIEW1.Hide()
        'VIEW1.ShowDialog(Me)
        'If Trim(keyfield & "") <> "" Then
        '    txt_clubcode.Text = Trim(keyfield & "")
        '    txt_clubcode.Select()
        '    Me.txt_feeldFILL()
        '    '  DDGRD1.Select()
        '    cmd_Add.Text = "Update [F7]"
        'End If
        'gconnection.closeConnection()
    End Sub
    Private Sub txt_feeldFILL()
        'Try
        '    Dim I, J As Integer
        '    Dim MEMBERTYPE As DataTable
        '    Dim Sqlstr As String
        '    If txt_clubcode.Text <> "" Then
        '        Sqlstr = " select clubcode,clubname,address1,address2,city,state,pincode,phone1,phone2,fax,email,website,contactperson,country,freeze from AFFILIATEDCLUBDETAILS WHERE clubcode='" & Trim(txt_clubcode.Text) & "'"
        '        gconnection.getDataSet(Sqlstr, "AffMaster")
        '        If gdataset.Tables("Master").Rows.Count > 0 Then
        '            txt_clubcode.ReadOnly = True
        '            txt_clubname.Text = gdataset.Tables("AffMaster").Rows(0).Item("clubname")
        '            txt_add1.Text = gdataset.Tables("AffMaster").Rows(0).Item("address1")
        '            txt_add2.Text = gdataset.Tables("AffMaster").Rows(0).Item("address2")
        '            Cbo_PCity.Text = gdataset.Tables("AffMaster").Rows(0).Item("city")
        '            Cbo_PState.Text = gdataset.Tables("AffMaster").Rows(0).Item("state")
        '            Cbo_PCountry.Text = gdataset.Tables("AffMaster").Rows(0).Item("country")
        '            txt_pincode.Text = gdataset.Tables("AffMaster").Rows(0).Item("pincode")
        '            TXT_PHONE1.Text = gdataset.Tables("AffMaster").Rows(0).Item("phone1")
        '            txt_phone2.Text = gdataset.Tables("AffMaster").Rows(0).Item("phone2")
        '            txt_fax.Text = gdataset.Tables("AffMaster").Rows(0).Item("fax")
        '            txt_email.Text = gdataset.Tables("AffMaster").Rows(0).Item("email")
        '            txt_website.Text = gdataset.Tables("AffMaster").Rows(0).Item("website")
        '            txt_contact = gdataset.Tables("AffMaster").Rows(0).Item("contactperson")
        '            Me.lbl_Freeze.Visible = True
        '            Me.lbl_Freeze.Text = Me.lbl_Freeze.Text & Format(gdataset.Tables("Master").Rows(0).Item("voiddate"), "dd-MMM-yyyy")
        '            Me.lbl_Freeze.Text = "Void[F8]"
        '        Else
        '            Me.lbl_Freeze.Visible = False
        '            Me.lbl_Freeze.Text = "Record Voided  On "
        '            Me.lbl_Freeze.Text = "Void[F8]"
        '        End If
        '        Me.cmd_Add.Text = "Update[F7]"
        '    Else
        '        txt_clubname.Text = ""
        '    End If

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call cmd_View_Click(sender, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub txt_clubcode_Validated1(sender As Object, e As EventArgs) Handles txt_clubcode.Validated

    End Sub

    Private Sub txt_clubcode_Enter(sender As Object, e As EventArgs) Handles txt_clubcode.Enter

    End Sub

    Private Sub txt_clubcode_MouseClick(sender As Object, e As MouseEventArgs) Handles txt_clubcode.MouseClick

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SSQLSTR, SSQLSTR2 As String
        SSQLSTR2 = " SELECT * FROM AFFILIATEDCLUBDETAILS WHERE ISNULL(AUTHORISEYN,'')<>'Y' AND ISNULL(AUTHORISE1,'')=''"
        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
            gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH1USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH1USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "')"
            gconnection.getDataSet(gSQLString, "AUTHORIZE")
            If gdataset.Tables("AUTHORIZE").Rows.Count > 0 Then
                SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND ISNULL(AUTHORIZELEVEL,0)>0 "
                gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                    SSQLSTR2 = " SELECT * FROM AFFILIATEDCLUBDETAILS WHERE ISNULL(AUTHORISEYN,'')<>'Y' AND ISNULL(AUTHORISE1,'')=''"
                    gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                    If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                        Dim VIEW1 As New AUTHORISATION
                        VIEW1.Show()
                        VIEW1.DTAUTH.DataSource = Nothing
                        VIEW1.DTAUTH.Rows.Clear()
                       
                        Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE AFFILIATEDCLUBDETAILS set  ", "CLUBCode", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 1, 1)
                    End If
                Else
                    MsgBox("NO AUTHORIZATION REQUIRED FOR THE ENTRY")
                End If
            End If
        Else
            SSQLSTR2 = " SELECT * FROM AFFILIATEDCLUBDETAILS WHERE ISNULL(AUTHORISEYN,'')<>'Y' AND ISNULL(AUTHORISE2,'')=''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH2USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH2USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE1")
                If gdataset.Tables("AUTHORIZE1").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "'"
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM AFFILIATEDCLUBDETAILS WHERE ISNULL(AUTHORISEYN,'')<>'Y' AND ISNULL(AUTHORISE2,'')=''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()
                            
                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE AFFILIATEDCLUBDETAILS set  ", "CLUBCode", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 2, 1)
                        End If
                    End If
                End If
            Else
                SSQLSTR2 = " SELECT * FROM AFFILIATEDCLUBDETAILS WHERE ISNULL(AUTHORISEYN,'')<>'Y' AND ISNULL(AUTHORISE3,'')=''"
                gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                    gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH3USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH3USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "')"
                    gconnection.getDataSet(gSQLString, "AUTHORIZE2")
                    If gdataset.Tables("AUTHORIZE2").Rows.Count > 0 Then
                        SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER' AND FORMNAME='" & GmoduleName & "'"
                        gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                        If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                            SSQLSTR2 = " SELECT * FROM AFFILIATEDCLUBDETAILS WHERE ISNULL(AUTHORISEYN,'')<>'Y' AND ISNULL(AUTHORISE3,'')=''"
                            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                                Dim VIEW1 As New AUTHORISATION
                                VIEW1.Show()
                                VIEW1.DTAUTH.DataSource = Nothing
                                VIEW1.DTAUTH.Rows.Clear()
                               
                                Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE AFFILIATEDCLUBDETAILS set  ", "CLUBCode", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 3, 1)
                            End If
                        End If
                    End If
                Else
                    MsgBox("U R NOT ELIGIBLE TO AUTHORISE IN ANY LEVEL", MsgBoxStyle.Critical)
                End If
            End If
        End If
   

    End Sub

    Private Sub txt_contact_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_contact.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmd_Add.Focus()
        End If
    End Sub

    Private Sub txt_contact_TextChanged(sender As Object, e As EventArgs) Handles txt_contact.TextChanged

    End Sub

    Private Sub CMD_DOS_Click(sender As Object, e As EventArgs) Handles CMD_DOS.Click
        Dim reportdesign As New ReportDesigner
        gheader = " MASTER VIEW "
        If txt_clubcode.Text.Length > 0 Then
            tables = " FROM VW_AFFILIATEDCLUBDETAILS where clubcode = '" & Trim(txt_clubcode.Text) & "'"
        Else
            tables = " FROM VW_AFFILIATEDCLUBDETAILS"
        End If
        reportdesign.DataGridView1.ColumnCount = 2
        reportdesign.DataGridView1.Columns(0).Name = "Column Name"
        reportdesign.DataGridView1.Columns(0).Width = 380
        reportdesign.DataGridView1.Columns(1).Name = "Size"
        reportdesign.DataGridView1.Columns(1).Width = 100


        Dim row As String() = New String() {"Clubcode", "10"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"Clubname", "35"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"Address1", "35"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"Address2", "35"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"City", "35"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"State", "10"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"Adduserid", "20"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"Adddatetime", "10"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"Upduserid", "20"}
        reportdesign.DataGridView1.Rows.Add(row)
        row = New String() {"Upddatetime", "10"}
        reportdesign.DataGridView1.Rows.Add(row)
        Dim chk As New DataGridViewCheckBoxColumn()
        reportdesign.DataGridView1.Columns.Insert(0, chk)
        chk.HeaderText = "Check"
        chk.Name = "chk"

        reportdesign.ShowDialog(Me)
        Call SHOWAFFCLUBDETAILS()
    End Sub

    Private Sub CMD_WINDOWS_Click(sender As Object, e As EventArgs) Handles CMD_WINDOWS.Click
        Dim txtobj1 As TextObject
        Dim Viewer As New REPORTVIEWER
        sqlstring = "select * from VW_AFFILIATEDCLUBDETAILS "
        If txt_clubcode.Text = "" Then
            sqlstring = sqlstring & ""
        Else
            sqlstring = sqlstring & " WHERE CLUBCODE = '" & txt_clubcode.Text & "' "
        End If
        Dim r As New Cry_AFFILIATEDCLUBDETAILSmaster

        gconnection.getDataSet(sqlstring, "VW_AFFILIATEDCLUBDETAILS")

        If gdataset.Tables("VW_AFFILIATEDCLUBDETAILS").Rows.Count > 0 Then
            Viewer.TableName = "VW_AFFILIATEDCLUBDETAILS"
            Call Viewer.GetDetails(sqlstring, "VW_AFFILIATEDCLUBDETAILS", r)
            txtobj1 = r.ReportDefinition.ReportObjects("Text1")
            txtobj1.Text = UCase(gcompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text2")
            txtobj1.Text = UCase(gCompanyAddress(0))
            txtobj1 = r.ReportDefinition.ReportObjects("Text3")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text4")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text5")
            txtobj1.Text = UCase(gCompanyAddress(3))
            txtobj1 = r.ReportDefinition.ReportObjects("Text15")
            txtobj1.Text = UCase(gCompanyAddress(4))
            txtobj1 = r.ReportDefinition.ReportObjects("Text16")
            txtobj1.Text = UCase(gCompanyAddress(5))


            txtobj1 = r.ReportDefinition.ReportObjects("Text19")
            txtobj1.Text = UCase(gFinancalyearStart)
            txtobj1 = r.ReportDefinition.ReportObjects("Text22")
            txtobj1.Text = UCase(gFinancialyearEnd)
            txtobj1 = r.ReportDefinition.ReportObjects("Text27")
            txtobj1.Text = UCase(gUsername)
            Viewer.Show()
        Else
            MsgBox(" NO RECORD AVAILABLE ! ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gcompanyname)
        End If
        
    End Sub

    Private Sub cmd_exit1_Click(sender As Object, e As EventArgs) Handles cmd_exit1.Click
        Gr2.Visible = False
        txt_clubcode.Focus()
    End Sub

    Private Sub txt_email_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_email.Validating
        Dim email As String = txt_email.Text
        If EmailAddressCheck(email) = False Then

            Dim result As DialogResult _
            = MessageBox.Show("The email address you entered is not valid." & _
                                       " Do you want re-enter it?", "Invalid Email Address", _
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            If result = Windows.Forms.DialogResult.Yes Then
                e.Cancel = True
            End If

        End If
    End Sub
    Function EmailAddressCheck(ByVal emailAddress As String) As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]" & _
        "*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)
        If emailAddressMatch.Success Then
            EmailAddressCheck = True
        Else
            EmailAddressCheck = False
        End If
    End Function

End Class
'Public Class ListOperation
'    Inherits System.Windows.Forms.Form
'    Dim Loopindex As Long
'    Dim i As Integer, vIndex As Long
'    Public vCaption As String
'    Public Table As String
'    Public Field As String
'    Dim Fields() As String
'    Dim ssql As String
'    Public keyfield As String
'    Public keyfield1 As String
'    Public keyfield2 As String
'    Public keyfield3 As String
'    Public keyfield4 As String
'    Public keyfield5 As String
'    Public keyfield6 As String
'    Public keyfield7 As String
'    Public keyfield8 As String
'    Public keyfield9 As String
'    Public keyfield10 As String
'    Public keyfield11 As String
'    Public keyfield12 As String
'    Public keyfield13 As String
'    Public keyfield14 As String
'    Public keyfield15 As String
'    Public vFormatstring As String
'    Dim FormUnload As Boolean
'    Public KeyPos, KeyPos1, KeyPos2, Keypos3 As Integer
'    Public keypos4, Keypos5, Keypos6, Keypos7, Keypos8 As Integer
'    Public keypos9, Keypos10, Keypos11, Keypos12, Keypos13 As Integer
'    Public keypos14, Keypos15 As Integer
'    Dim vSelect As String
'    Public vSamleCol As String
'    Dim vColValue As String
'    Dim vCode As String
'    Dim vLastString As String
'    Dim gconnection As New globalClass
'#Region " Windows Form Designer generated code "
'    Public Sub New()
'        MyBase.New()

'        'This call is required by the Windows Form Designer.
'        ' InitializeComponent()

'        'Add any initialization after the InitializeComponent() call

'    End Sub

'    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
'        If disposing Then
'            If Not (components Is Nothing) Then
'                components.Dispose()
'            End If
'        End If
'        MyBase.Dispose(disposing)
'    End Sub

'    'Required by the Windows Form Designer
'    Private components As System.ComponentModel.IContainer

'    'NOTE: The following procedure is required by the Windows Form Designer
'    'It can be modified using the Windows Form Designer.  
'    'Do not modify it using the code editor.
'    Friend WithEvents CbxColumn As System.Windows.Forms.ComboBox
'    Friend WithEvents CbxOrderby As System.Windows.Forms.ComboBox
'    Friend WithEvents Label1 As System.Windows.Forms.Label
'    Friend WithEvents Label2 As System.Windows.Forms.Label
'    Friend WithEvents Label3 As System.Windows.Forms.Label
'    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
'    Friend WithEvents lblHeading As System.Windows.Forms.Label
'    ' Friend WithEvents POSListoperation As AxMSFlexGridLib.AxMSFlexGrid

'    ' <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

'    'POSListoperation
'    '

'    '
'    'ListOperation
'    '

'#End Region
'    Private Sub ListOperattion1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
'        If FormUnload = True Then
'            Me.Close()
'            gSQLString = ""
'            vFormatstring = ""
'            vCaption = ""
'            M_Groupby = ""
'            M_WhereCondition = ""
'        End If
'    End Sub

'    Private Sub ListOperattion1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
'        If e.KeyCode = Keys.Escape Then
'            Me.Dispose(True)
'        End If
'    End Sub
'    Private Sub txtSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress
'        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
'            If txtSearch.Text = "" Then
'                Call txtSearch_TextChanged(txtSearch, e)
'            End If
'            Microsoft.VisualBasic.ChrW(0)

'        End If
'    End Sub
'    Private Sub CbxColumn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbxColumn.KeyPress
'        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
'            CbxOrderby.Focus()
'        End If
'    End Sub
'    Private Sub CbxOrderby_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbxOrderby.KeyPress
'        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
'            txtSearch.Focus()
'        End If
'    End Sub
'    Private Sub getDetails()


'        M_Groupby = ""
'        M_WhereCondition = ""
'        Me.Hide()
'    End Sub
'    'Private Sub POSListoperation_KeyPressEvent(ByVal sender As Object, ByVal e As AxMSFlexGridLib.DMSFlexGridEvents_KeyPressEvent) Handles POSListoperation.KeyPressEvent
'    '    If e.keyAscii = 13 Then
'    '        Call getDetails()
'    '    End If
'    'End Sub
'    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
'        Dim vLen As Integer

'        ssql = ""
'        ssql = gSQLString & IIf(Trim(M_WhereCondition) = "", " Where ", M_WhereCondition & " And ")

'        Try
'            ' If listop = "" Then
'            'listop = "%'"
'            '   End If
'            If CbxColumn.Text <> "" Then
'                'vLen = Len(Trim(txtSearch.Text))
'                'ssql = ssql & Trim(CbxColumn.Text & "") & " LIKE  '%" & Trim(txtSearch.Text) & listop
'                '--------------------NEW CHANGE----
'                vLen = Len(Trim(txtSearch.Text))
'                ssql = ssql & Trim(CbxColumn.Text & "") & " LIKE '%" & Trim(txtSearch.Text) & "%'"
'            ElseIf CbxColumn.Text <> "" Then
'                MsgBox("Select the SearchField Column as it is mandatory ...", MsgBoxStyle.Information)
'                CbxColumn.Focus()
'                Exit Sub
'            End If
'            '  If SUBQQ = True Then
'            'ssql = ssql & "UNION ALL SELECT ISNULL(A.SUBSDESC,'') AS SUBSDESC,ISNULL(A.SUBSCODE,'') AS SUBSCODE,ISNULL(A.TOTAL,0) AS AMOUNT,ISNULL(A.TAXTOTAL,0) AS TAXAMOUNT FROM SUBSCRIPTIONMAST A WHERE TYPE IN('SPECIAL','Facility')"
'            'End If
'            'If vSamleCol = "Y" Then
'            '    ssql = ssql & " Order by SizeCode"
'            'ElseIf vSamleCol = "P" Then
'            '    ssql = ssql & " Order by docdate,docno"
'            'Else
'            If CbxOrderby.Text <> "MCODE" Then
'                ssql = ssql & M_Groupby
'                'ssql = ssql & " order by len('" & Trim(CbxOrderby.Text) & "'),'" & Trim(CbxOrderby.Text) & "'"
'            End If
'            If CbxOrderby.Text = "MCODE" Then
'                ssql = ssql & M_Groupby
'                ssql = ssql & " Order by MCODE,MNAME ASC"
'            End If
'            'End If
'            If ssql <> "" Then
'                gconnection.getDataSet(ssql, "mytable")
'                'DesCodeRs.Open(ssql, MainMenu.myconnection, adOpenDynamic, adLockPessimistic)
'                If gdataset.Tables("mytable").Rows.Count > 0 Then
'                    vLastString = Trim(txtSearch.Text & "")
'                    Loopindex = 1

'                    vCode = Trim(gdataset.Tables("mytable").Rows(0).Item(0) & "")
'                    'For vIndex = 0 To gdataset.Tables("mytable").Rows.Count - 1 ' While Not DesCodeRs
'                    If vSamleCol = "Y" Then
'                        If vCode = Trim(gdataset.Tables("mytable").Rows(vIndex).Item(0) & "") Then
'                            If gdataset.Tables("mytable").Rows.Count = 0 Then '      DesCodeRs.EOF Then
'                                If Trim(vColValue & "") = "" Then
'                                    vColValue = Trim(gdataset.Tables("mytable").Rows(vIndex).Item(1) & "")
'                                Else
'                                    vColValue = vColValue & " ! " & Trim(gdataset.Tables("mytable").Rows(vIndex).Item(1) & "") 'Trim(DesCodeRs(1) & "")
'                                End If
'                                'DesCodeRs.MoveNext()
'                                If gdataset.Tables("mytable").Rows.Count > 0 Then  'Not DesCodeRs.EOF Then
'                                    If vCode <> Trim(gdataset.Tables("mytable").Rows(vIndex).Item(0) & "") Then
'                                        '    POSListoperation.set_TextMatrix(Loopindex, 0, Trim(vCode & ""))
'                                        '= Trim(vCode & "")
'                                        'POSListoperation.set_TextMatrix(Loopindex, 1, Trim(vColValue & ""))
'                                        Loopindex = Loopindex + 1
'                                        vCode = Trim(gdataset.Tables("mytable").Rows(vIndex).Item(0) & "")
'                                        vColValue = ""
'                                    End If
'                                End If
'                            End If
'                        End If
'                    Else
'                        '   If POSListoperation.Rows <= Loopindex Then
'                        'POSListoperation.Rows = POSListoperation.Rows + Loopindex
'                    End If
'                    For ColIndex = 0 To gdataset.Tables("mytable").Columns.Count - 1
'                        '     POSListoperation.set_TextMatrix(Loopindex, ColIndex, Trim(gdataset.Tables("mytable").Rows(vIndex).Item(ColIndex) & ""))
'                    Next ColIndex
'                    Loopindex = Loopindex + 1
'                End If
'                '  Next
'                'POSListoperation.Focus()
'            Else
'                MsgBox("Details Not Found In The Database", MsgBoxStyle.Critical, vCaption)
'                txtSearch.Text = Trim(vLastString & "")
'                txtSearch.Focus()
'            End If
'            ssql = ""
'            ' End If
'        Catch ex As Exception
'            MsgBox(ex.Message)
'        End Try
'    End Sub
'    Private Sub ListOperattion1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
'        If e.KeyCode = Keys.Escape Then
'            Me.Dispose(True)
'        End If
'    End Sub

'End Class
