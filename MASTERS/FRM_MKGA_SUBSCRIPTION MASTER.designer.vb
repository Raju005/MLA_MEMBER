<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_MKGA_SUBSCRIPTION_MASTER
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_MKGA_SUBSCRIPTION_MASTER))
        Me.LBL_SUB = New System.Windows.Forms.Label()
        Me.LBL_SUBCODE = New System.Windows.Forms.Label()
        Me.Lbl_subdesc = New System.Windows.Forms.Label()
        Me.Lbl_Type = New System.Windows.Forms.Label()
        Me.Lbl_typedesc = New System.Windows.Forms.Label()
        Me.Lbl_billbasis = New System.Windows.Forms.Label()
        Me.Lbl_billingmonth = New System.Windows.Forms.Label()
        Me.Lbl_Taxcode = New System.Windows.Forms.Label()
        Me.Lblpercentage = New System.Windows.Forms.Label()
        Me.Lbl_taxaccin = New System.Windows.Forms.Label()
        Me.lbl_subscriptionAmount = New System.Windows.Forms.Label()
        Me.Lbbl_taxamount = New System.Windows.Forms.Label()
        Me.Txt_Subcode = New System.Windows.Forms.TextBox()
        Me.Txt_desc = New System.Windows.Forms.TextBox()
        Me.txt_subdesc = New System.Windows.Forms.TextBox()
        Me.Txt_taxcode = New System.Windows.Forms.TextBox()
        Me.Txt_Percentage = New System.Windows.Forms.TextBox()
        Me.Txt_Taxaccountin = New System.Windows.Forms.TextBox()
        Me.Txt_subamount = New System.Windows.Forms.TextBox()
        Me.Txt_Taxamount = New System.Windows.Forms.TextBox()
        Me.Chekbillingmonth = New System.Windows.Forms.CheckedListBox()
        Me.Lbl_Basedon = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chk_billingmonth = New System.Windows.Forms.ListBox()
        Me.Lbl_Alliedon = New System.Windows.Forms.Label()
        Me.Cmd_subhelp = New System.Windows.Forms.Button()
        Me.Cmd_taxcodehelp = New System.Windows.Forms.Button()
        Me.Com_subtypecode = New System.Windows.Forms.ComboBox()
        Me.Comb_billbasis = New System.Windows.Forms.ComboBox()
        Me.Comb_appliedon = New System.Windows.Forms.ComboBox()
        Me.Cmd_view = New System.Windows.Forms.Button()
        Me.Cmd_freeze = New System.Windows.Forms.Button()
        Me.Cmd_add = New System.Windows.Forms.Button()
        Me.cmd_clear = New System.Windows.Forms.Button()
        Me.Cmd_exit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cmd_Authantication = New System.Windows.Forms.Button()
        Me.lbl_freeze = New System.Windows.Forms.Label()
        Me.Grp_Print = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Cmd_Windows = New System.Windows.Forms.Button()
        Me.Cmd_Dos = New System.Windows.Forms.Button()
        Me.Txt_luxuryTax = New System.Windows.Forms.TextBox()
        Me.Lbl_Luxurytax = New System.Windows.Forms.Label()
        Me.Comb_basedon = New System.Windows.Forms.ComboBox()
        Me.LBL_CHG = New System.Windows.Forms.Label()
        Me.CBO_FACILITY = New System.Windows.Forms.ComboBox()
        Me.LBL_APPLIEDFACILITY = New System.Windows.Forms.Label()
        Me.lbl_fromage = New System.Windows.Forms.Label()
        Me.Txt_Agefrom = New System.Windows.Forms.TextBox()
        Me.Txt_Ageto = New System.Windows.Forms.TextBox()
        Me.lbl_toage = New System.Windows.Forms.Label()
        Me.Txt_from = New System.Windows.Forms.TextBox()
        Me.Txt_to = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ChkList_ItemTypeDet = New System.Windows.Forms.CheckedListBox()
        Me.ChkList_ItemType = New System.Windows.Forms.CheckedListBox()
        Me.List_Tax = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CHARGEOCDE = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LST_FACILITY = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_Costcentre = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Grp_Print.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBL_SUB
        '
        Me.LBL_SUB.AutoSize = True
        Me.LBL_SUB.BackColor = System.Drawing.Color.Transparent
        Me.LBL_SUB.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_SUB.Location = New System.Drawing.Point(176, 77)
        Me.LBL_SUB.Name = "LBL_SUB"
        Me.LBL_SUB.Size = New System.Drawing.Size(216, 25)
        Me.LBL_SUB.TabIndex = 0
        Me.LBL_SUB.Text = "SUBSCRIPTION MASTER"
        '
        'LBL_SUBCODE
        '
        Me.LBL_SUBCODE.AutoSize = True
        Me.LBL_SUBCODE.BackColor = System.Drawing.Color.Transparent
        Me.LBL_SUBCODE.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_SUBCODE.Location = New System.Drawing.Point(192, 166)
        Me.LBL_SUBCODE.Name = "LBL_SUBCODE"
        Me.LBL_SUBCODE.Size = New System.Drawing.Size(111, 15)
        Me.LBL_SUBCODE.TabIndex = 1
        Me.LBL_SUBCODE.Text = "Subscription Code"
        '
        'Lbl_subdesc
        '
        Me.Lbl_subdesc.AutoSize = True
        Me.Lbl_subdesc.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_subdesc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_subdesc.Location = New System.Drawing.Point(507, 163)
        Me.Lbl_subdesc.Name = "Lbl_subdesc"
        Me.Lbl_subdesc.Size = New System.Drawing.Size(147, 15)
        Me.Lbl_subdesc.TabIndex = 2
        Me.Lbl_subdesc.Text = "Subscription Description"
        '
        'Lbl_Type
        '
        Me.Lbl_Type.AutoSize = True
        Me.Lbl_Type.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Type.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Type.Location = New System.Drawing.Point(192, 203)
        Me.Lbl_Type.Name = "Lbl_Type"
        Me.Lbl_Type.Size = New System.Drawing.Size(108, 15)
        Me.Lbl_Type.TabIndex = 3
        Me.Lbl_Type.Text = "Subscription Type"
        '
        'Lbl_typedesc
        '
        Me.Lbl_typedesc.AutoSize = True
        Me.Lbl_typedesc.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_typedesc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_typedesc.Location = New System.Drawing.Point(507, 203)
        Me.Lbl_typedesc.Name = "Lbl_typedesc"
        Me.Lbl_typedesc.Size = New System.Drawing.Size(101, 15)
        Me.Lbl_typedesc.TabIndex = 4
        Me.Lbl_typedesc.Text = "Type Description"
        '
        'Lbl_billbasis
        '
        Me.Lbl_billbasis.AutoSize = True
        Me.Lbl_billbasis.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_billbasis.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_billbasis.Location = New System.Drawing.Point(192, 239)
        Me.Lbl_billbasis.Name = "Lbl_billbasis"
        Me.Lbl_billbasis.Size = New System.Drawing.Size(59, 15)
        Me.Lbl_billbasis.TabIndex = 5
        Me.Lbl_billbasis.Text = "Bill Basis"
        '
        'Lbl_billingmonth
        '
        Me.Lbl_billingmonth.AutoSize = True
        Me.Lbl_billingmonth.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_billingmonth.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_billingmonth.Location = New System.Drawing.Point(507, 241)
        Me.Lbl_billingmonth.Name = "Lbl_billingmonth"
        Me.Lbl_billingmonth.Size = New System.Drawing.Size(79, 15)
        Me.Lbl_billingmonth.TabIndex = 6
        Me.Lbl_billingmonth.Text = "Billing Month"
        '
        'Lbl_Taxcode
        '
        Me.Lbl_Taxcode.AutoSize = True
        Me.Lbl_Taxcode.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Taxcode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Taxcode.Location = New System.Drawing.Point(192, 607)
        Me.Lbl_Taxcode.Name = "Lbl_Taxcode"
        Me.Lbl_Taxcode.Size = New System.Drawing.Size(55, 15)
        Me.Lbl_Taxcode.TabIndex = 7
        Me.Lbl_Taxcode.Text = "Taxcode"
        Me.Lbl_Taxcode.Visible = False
        '
        'Lblpercentage
        '
        Me.Lblpercentage.AutoSize = True
        Me.Lblpercentage.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblpercentage.Location = New System.Drawing.Point(538, 650)
        Me.Lblpercentage.Name = "Lblpercentage"
        Me.Lblpercentage.Size = New System.Drawing.Size(89, 18)
        Me.Lblpercentage.TabIndex = 8
        Me.Lblpercentage.Text = "Percentage"
        Me.Lblpercentage.Visible = False
        '
        'Lbl_taxaccin
        '
        Me.Lbl_taxaccin.AutoSize = True
        Me.Lbl_taxaccin.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_taxaccin.Location = New System.Drawing.Point(191, 625)
        Me.Lbl_taxaccin.Name = "Lbl_taxaccin"
        Me.Lbl_taxaccin.Size = New System.Drawing.Size(73, 18)
        Me.Lbl_taxaccin.TabIndex = 9
        Me.Lbl_taxaccin.Text = "Tax Accin"
        Me.Lbl_taxaccin.Visible = False
        '
        'lbl_subscriptionAmount
        '
        Me.lbl_subscriptionAmount.AutoSize = True
        Me.lbl_subscriptionAmount.BackColor = System.Drawing.Color.Transparent
        Me.lbl_subscriptionAmount.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subscriptionAmount.Location = New System.Drawing.Point(507, 491)
        Me.lbl_subscriptionAmount.Name = "lbl_subscriptionAmount"
        Me.lbl_subscriptionAmount.Size = New System.Drawing.Size(126, 15)
        Me.lbl_subscriptionAmount.TabIndex = 10
        Me.lbl_subscriptionAmount.Text = "Subscription Amount"
        '
        'Lbbl_taxamount
        '
        Me.Lbbl_taxamount.AutoSize = True
        Me.Lbbl_taxamount.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbbl_taxamount.Location = New System.Drawing.Point(191, 667)
        Me.Lbbl_taxamount.Name = "Lbbl_taxamount"
        Me.Lbbl_taxamount.Size = New System.Drawing.Size(74, 15)
        Me.Lbbl_taxamount.TabIndex = 11
        Me.Lbbl_taxamount.Text = "Tax Amount"
        Me.Lbbl_taxamount.Visible = False
        '
        'Txt_Subcode
        '
        Me.Txt_Subcode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Subcode.Location = New System.Drawing.Point(310, 163)
        Me.Txt_Subcode.Name = "Txt_Subcode"
        Me.Txt_Subcode.Size = New System.Drawing.Size(100, 21)
        Me.Txt_Subcode.TabIndex = 12
        '
        'Txt_desc
        '
        Me.Txt_desc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_desc.Location = New System.Drawing.Point(663, 163)
        Me.Txt_desc.Name = "Txt_desc"
        Me.Txt_desc.Size = New System.Drawing.Size(177, 21)
        Me.Txt_desc.TabIndex = 13
        '
        'txt_subdesc
        '
        Me.txt_subdesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_subdesc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subdesc.Location = New System.Drawing.Point(663, 203)
        Me.txt_subdesc.Name = "txt_subdesc"
        Me.txt_subdesc.Size = New System.Drawing.Size(177, 21)
        Me.txt_subdesc.TabIndex = 15
        '
        'Txt_taxcode
        '
        Me.Txt_taxcode.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Txt_taxcode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_taxcode.Location = New System.Drawing.Point(308, 602)
        Me.Txt_taxcode.Name = "Txt_taxcode"
        Me.Txt_taxcode.Size = New System.Drawing.Size(100, 22)
        Me.Txt_taxcode.TabIndex = 18
        Me.Txt_taxcode.Visible = False
        '
        'Txt_Percentage
        '
        Me.Txt_Percentage.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Percentage.Location = New System.Drawing.Point(654, 650)
        Me.Txt_Percentage.Name = "Txt_Percentage"
        Me.Txt_Percentage.Size = New System.Drawing.Size(177, 26)
        Me.Txt_Percentage.TabIndex = 19
        Me.Txt_Percentage.Visible = False
        '
        'Txt_Taxaccountin
        '
        Me.Txt_Taxaccountin.Location = New System.Drawing.Point(308, 631)
        Me.Txt_Taxaccountin.Name = "Txt_Taxaccountin"
        Me.Txt_Taxaccountin.Size = New System.Drawing.Size(140, 21)
        Me.Txt_Taxaccountin.TabIndex = 20
        Me.Txt_Taxaccountin.Visible = False
        '
        'Txt_subamount
        '
        Me.Txt_subamount.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_subamount.Location = New System.Drawing.Point(671, 488)
        Me.Txt_subamount.Name = "Txt_subamount"
        Me.Txt_subamount.Size = New System.Drawing.Size(177, 21)
        Me.Txt_subamount.TabIndex = 21
        '
        'Txt_Taxamount
        '
        Me.Txt_Taxamount.Location = New System.Drawing.Point(308, 672)
        Me.Txt_Taxamount.Name = "Txt_Taxamount"
        Me.Txt_Taxamount.Size = New System.Drawing.Size(140, 21)
        Me.Txt_Taxamount.TabIndex = 22
        Me.Txt_Taxamount.Visible = False
        '
        'Chekbillingmonth
        '
        Me.Chekbillingmonth.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chekbillingmonth.FormattingEnabled = True
        Me.Chekbillingmonth.Items.AddRange(New Object() {"1.April", "2.May", "3.June", "4.July", "5.August", "6.September", "7.October", "8.November", "9.December", "10.January", "11.February", "12.March"})
        Me.Chekbillingmonth.Location = New System.Drawing.Point(5, 19)
        Me.Chekbillingmonth.Name = "Chekbillingmonth"
        Me.Chekbillingmonth.Size = New System.Drawing.Size(150, 68)
        Me.Chekbillingmonth.TabIndex = 23
        '
        'Lbl_Basedon
        '
        Me.Lbl_Basedon.AutoSize = True
        Me.Lbl_Basedon.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Basedon.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Basedon.Location = New System.Drawing.Point(192, 455)
        Me.Lbl_Basedon.Name = "Lbl_Basedon"
        Me.Lbl_Basedon.Size = New System.Drawing.Size(62, 15)
        Me.Lbl_Basedon.TabIndex = 24
        Me.Lbl_Basedon.Text = "Based On"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(192, 281)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 15)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Selected Month"
        '
        'chk_billingmonth
        '
        Me.chk_billingmonth.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_billingmonth.FormattingEnabled = True
        Me.chk_billingmonth.ItemHeight = 15
        Me.chk_billingmonth.Location = New System.Drawing.Point(8, 20)
        Me.chk_billingmonth.Name = "chk_billingmonth"
        Me.chk_billingmonth.Size = New System.Drawing.Size(162, 64)
        Me.chk_billingmonth.TabIndex = 26
        '
        'Lbl_Alliedon
        '
        Me.Lbl_Alliedon.AutoSize = True
        Me.Lbl_Alliedon.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Alliedon.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Alliedon.Location = New System.Drawing.Point(192, 363)
        Me.Lbl_Alliedon.Name = "Lbl_Alliedon"
        Me.Lbl_Alliedon.Size = New System.Drawing.Size(68, 15)
        Me.Lbl_Alliedon.TabIndex = 27
        Me.Lbl_Alliedon.Text = "Applied On"
        '
        'Cmd_subhelp
        '
        Me.Cmd_subhelp.BackgroundImage = CType(resources.GetObject("Cmd_subhelp.BackgroundImage"), System.Drawing.Image)
        Me.Cmd_subhelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cmd_subhelp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_subhelp.Location = New System.Drawing.Point(420, 164)
        Me.Cmd_subhelp.Name = "Cmd_subhelp"
        Me.Cmd_subhelp.Size = New System.Drawing.Size(37, 21)
        Me.Cmd_subhelp.TabIndex = 30
        Me.Cmd_subhelp.UseVisualStyleBackColor = True
        '
        'Cmd_taxcodehelp
        '
        Me.Cmd_taxcodehelp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_taxcodehelp.Location = New System.Drawing.Point(411, 601)
        Me.Cmd_taxcodehelp.Name = "Cmd_taxcodehelp"
        Me.Cmd_taxcodehelp.Size = New System.Drawing.Size(37, 22)
        Me.Cmd_taxcodehelp.TabIndex = 31
        Me.Cmd_taxcodehelp.Text = "?"
        Me.Cmd_taxcodehelp.UseVisualStyleBackColor = True
        Me.Cmd_taxcodehelp.Visible = False
        '
        'Com_subtypecode
        '
        Me.Com_subtypecode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Com_subtypecode.FormattingEnabled = True
        Me.Com_subtypecode.Items.AddRange(New Object() {"GEN", "MUC", "FAC", "SPECIAL", "OTHERS"})
        Me.Com_subtypecode.Location = New System.Drawing.Point(310, 201)
        Me.Com_subtypecode.Name = "Com_subtypecode"
        Me.Com_subtypecode.Size = New System.Drawing.Size(140, 23)
        Me.Com_subtypecode.TabIndex = 32
        '
        'Comb_billbasis
        '
        Me.Comb_billbasis.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comb_billbasis.FormattingEnabled = True
        Me.Comb_billbasis.Items.AddRange(New Object() {"YEARLY", "HALF YEARLY", "QUARTERLY", "MONTHLY", "NONE"})
        Me.Comb_billbasis.Location = New System.Drawing.Point(310, 236)
        Me.Comb_billbasis.Name = "Comb_billbasis"
        Me.Comb_billbasis.Size = New System.Drawing.Size(140, 23)
        Me.Comb_billbasis.TabIndex = 33
        '
        'Comb_appliedon
        '
        Me.Comb_appliedon.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comb_appliedon.FormattingEnabled = True
        Me.Comb_appliedon.Items.AddRange(New Object() {"Member", "Dependent"})
        Me.Comb_appliedon.Location = New System.Drawing.Point(310, 359)
        Me.Comb_appliedon.Name = "Comb_appliedon"
        Me.Comb_appliedon.Size = New System.Drawing.Size(140, 23)
        Me.Comb_appliedon.TabIndex = 35
        '
        'Cmd_view
        '
        Me.Cmd_view.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_view.Image = CType(resources.GetObject("Cmd_view.Image"), System.Drawing.Image)
        Me.Cmd_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_view.Location = New System.Drawing.Point(6, 237)
        Me.Cmd_view.Name = "Cmd_view"
        Me.Cmd_view.Size = New System.Drawing.Size(137, 50)
        Me.Cmd_view.TabIndex = 39
        Me.Cmd_view.Text = "View[F9]"
        Me.Cmd_view.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_view.UseVisualStyleBackColor = True
        '
        'Cmd_freeze
        '
        Me.Cmd_freeze.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_freeze.Image = CType(resources.GetObject("Cmd_freeze.Image"), System.Drawing.Image)
        Me.Cmd_freeze.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_freeze.Location = New System.Drawing.Point(6, 173)
        Me.Cmd_freeze.Name = "Cmd_freeze"
        Me.Cmd_freeze.Size = New System.Drawing.Size(137, 50)
        Me.Cmd_freeze.TabIndex = 38
        Me.Cmd_freeze.Text = "Void[F8]"
        Me.Cmd_freeze.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_freeze.UseVisualStyleBackColor = True
        '
        'Cmd_add
        '
        Me.Cmd_add.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_add.Image = CType(resources.GetObject("Cmd_add.Image"), System.Drawing.Image)
        Me.Cmd_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_add.Location = New System.Drawing.Point(6, 109)
        Me.Cmd_add.Name = "Cmd_add"
        Me.Cmd_add.Size = New System.Drawing.Size(137, 50)
        Me.Cmd_add.TabIndex = 37
        Me.Cmd_add.Text = "Add[F7]"
        Me.Cmd_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_add.UseVisualStyleBackColor = True
        '
        'cmd_clear
        '
        Me.cmd_clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_clear.Image = CType(resources.GetObject("cmd_clear.Image"), System.Drawing.Image)
        Me.cmd_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_clear.Location = New System.Drawing.Point(6, 45)
        Me.cmd_clear.Name = "cmd_clear"
        Me.cmd_clear.Size = New System.Drawing.Size(137, 50)
        Me.cmd_clear.TabIndex = 36
        Me.cmd_clear.Text = "Clear[F6]"
        Me.cmd_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_clear.UseVisualStyleBackColor = True
        '
        'Cmd_exit
        '
        Me.Cmd_exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_exit.Image = CType(resources.GetObject("Cmd_exit.Image"), System.Drawing.Image)
        Me.Cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_exit.Location = New System.Drawing.Point(6, 365)
        Me.Cmd_exit.Name = "Cmd_exit"
        Me.Cmd_exit.Size = New System.Drawing.Size(137, 50)
        Me.Cmd_exit.TabIndex = 42
        Me.Cmd_exit.Text = "Exit[F11]"
        Me.Cmd_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_exit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Cmd_exit)
        Me.GroupBox1.Controls.Add(Me.cmd_clear)
        Me.GroupBox1.Controls.Add(Me.Cmd_add)
        Me.GroupBox1.Controls.Add(Me.Cmd_Authantication)
        Me.GroupBox1.Controls.Add(Me.Cmd_freeze)
        Me.GroupBox1.Controls.Add(Me.Cmd_view)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(860, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(146, 536)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        '
        'Cmd_Authantication
        '
        Me.Cmd_Authantication.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Authantication.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Authantication.Location = New System.Drawing.Point(6, 301)
        Me.Cmd_Authantication.Name = "Cmd_Authantication"
        Me.Cmd_Authantication.Size = New System.Drawing.Size(137, 50)
        Me.Cmd_Authantication.TabIndex = 40
        Me.Cmd_Authantication.Text = "Browse"
        Me.Cmd_Authantication.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Authantication.UseVisualStyleBackColor = True
        '
        'lbl_freeze
        '
        Me.lbl_freeze.AutoSize = True
        Me.lbl_freeze.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_freeze.Location = New System.Drawing.Point(582, 42)
        Me.lbl_freeze.Name = "lbl_freeze"
        Me.lbl_freeze.Size = New System.Drawing.Size(173, 25)
        Me.lbl_freeze.TabIndex = 43
        Me.lbl_freeze.Text = "Record Freezed on"
        Me.lbl_freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Grp_Print
        '
        Me.Grp_Print.BackColor = System.Drawing.Color.Transparent
        Me.Grp_Print.Controls.Add(Me.Button3)
        Me.Grp_Print.Controls.Add(Me.Cmd_Windows)
        Me.Grp_Print.Controls.Add(Me.Cmd_Dos)
        Me.Grp_Print.Location = New System.Drawing.Point(343, 540)
        Me.Grp_Print.Name = "Grp_Print"
        Me.Grp_Print.Size = New System.Drawing.Size(417, 60)
        Me.Grp_Print.TabIndex = 44
        Me.Grp_Print.TabStop = False
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(284, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 30)
        Me.Button3.TabIndex = 43
        Me.Button3.Text = "EXIT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Cmd_Windows
        '
        Me.Cmd_Windows.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Windows.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Windows.Location = New System.Drawing.Point(155, 16)
        Me.Cmd_Windows.Name = "Cmd_Windows"
        Me.Cmd_Windows.Size = New System.Drawing.Size(100, 30)
        Me.Cmd_Windows.TabIndex = 41
        Me.Cmd_Windows.Text = "WINDOWS"
        Me.Cmd_Windows.UseVisualStyleBackColor = True
        '
        'Cmd_Dos
        '
        Me.Cmd_Dos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Dos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Dos.Location = New System.Drawing.Point(21, 16)
        Me.Cmd_Dos.Name = "Cmd_Dos"
        Me.Cmd_Dos.Size = New System.Drawing.Size(100, 30)
        Me.Cmd_Dos.TabIndex = 40
        Me.Cmd_Dos.Text = "DOS"
        Me.Cmd_Dos.UseVisualStyleBackColor = True
        '
        'Txt_luxuryTax
        '
        Me.Txt_luxuryTax.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_luxuryTax.Location = New System.Drawing.Point(654, 621)
        Me.Txt_luxuryTax.Name = "Txt_luxuryTax"
        Me.Txt_luxuryTax.Size = New System.Drawing.Size(177, 22)
        Me.Txt_luxuryTax.TabIndex = 46
        Me.Txt_luxuryTax.Visible = False
        '
        'Lbl_Luxurytax
        '
        Me.Lbl_Luxurytax.AutoSize = True
        Me.Lbl_Luxurytax.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Luxurytax.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Luxurytax.Location = New System.Drawing.Point(706, 627)
        Me.Lbl_Luxurytax.Name = "Lbl_Luxurytax"
        Me.Lbl_Luxurytax.Size = New System.Drawing.Size(63, 16)
        Me.Lbl_Luxurytax.TabIndex = 45
        Me.Lbl_Luxurytax.Text = "Discount "
        Me.Lbl_Luxurytax.Visible = False
        '
        'Comb_basedon
        '
        Me.Comb_basedon.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comb_basedon.FormattingEnabled = True
        Me.Comb_basedon.Items.AddRange(New Object() {"Consumption", "Facility", "Member Category", "Personal Age Based", "Membership Age Based"})
        Me.Comb_basedon.Location = New System.Drawing.Point(310, 451)
        Me.Comb_basedon.Name = "Comb_basedon"
        Me.Comb_basedon.Size = New System.Drawing.Size(140, 23)
        Me.Comb_basedon.TabIndex = 47
        '
        'LBL_CHG
        '
        Me.LBL_CHG.AutoSize = True
        Me.LBL_CHG.BackColor = System.Drawing.Color.Transparent
        Me.LBL_CHG.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CHG.Location = New System.Drawing.Point(192, 410)
        Me.LBL_CHG.Name = "LBL_CHG"
        Me.LBL_CHG.Size = New System.Drawing.Size(109, 15)
        Me.LBL_CHG.TabIndex = 48
        Me.LBL_CHG.Text = "Charge Based On "
        Me.LBL_CHG.Visible = False
        '
        'CBO_FACILITY
        '
        Me.CBO_FACILITY.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBO_FACILITY.FormattingEnabled = True
        Me.CBO_FACILITY.Items.AddRange(New Object() {"INDIVIDUAL", "FAMILY"})
        Me.CBO_FACILITY.Location = New System.Drawing.Point(310, 406)
        Me.CBO_FACILITY.Name = "CBO_FACILITY"
        Me.CBO_FACILITY.Size = New System.Drawing.Size(140, 23)
        Me.CBO_FACILITY.TabIndex = 49
        Me.CBO_FACILITY.Visible = False
        '
        'LBL_APPLIEDFACILITY
        '
        Me.LBL_APPLIEDFACILITY.AutoSize = True
        Me.LBL_APPLIEDFACILITY.BackColor = System.Drawing.Color.Transparent
        Me.LBL_APPLIEDFACILITY.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_APPLIEDFACILITY.Location = New System.Drawing.Point(507, 350)
        Me.LBL_APPLIEDFACILITY.Name = "LBL_APPLIEDFACILITY"
        Me.LBL_APPLIEDFACILITY.Size = New System.Drawing.Size(116, 15)
        Me.LBL_APPLIEDFACILITY.TabIndex = 50
        Me.LBL_APPLIEDFACILITY.Text = "Applied Facility On :"
        Me.LBL_APPLIEDFACILITY.Visible = False
        '
        'lbl_fromage
        '
        Me.lbl_fromage.AutoSize = True
        Me.lbl_fromage.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fromage.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fromage.Location = New System.Drawing.Point(507, 455)
        Me.lbl_fromage.Name = "lbl_fromage"
        Me.lbl_fromage.Size = New System.Drawing.Size(61, 15)
        Me.lbl_fromage.TabIndex = 52
        Me.lbl_fromage.Text = "Age From"
        '
        'Txt_Agefrom
        '
        Me.Txt_Agefrom.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Agefrom.Location = New System.Drawing.Point(617, 452)
        Me.Txt_Agefrom.Name = "Txt_Agefrom"
        Me.Txt_Agefrom.Size = New System.Drawing.Size(69, 22)
        Me.Txt_Agefrom.TabIndex = 53
        '
        'Txt_Ageto
        '
        Me.Txt_Ageto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Ageto.Location = New System.Drawing.Point(758, 452)
        Me.Txt_Ageto.Name = "Txt_Ageto"
        Me.Txt_Ageto.Size = New System.Drawing.Size(65, 22)
        Me.Txt_Ageto.TabIndex = 54
        '
        'lbl_toage
        '
        Me.lbl_toage.AutoSize = True
        Me.lbl_toage.BackColor = System.Drawing.Color.Transparent
        Me.lbl_toage.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_toage.Location = New System.Drawing.Point(700, 455)
        Me.lbl_toage.Name = "lbl_toage"
        Me.lbl_toage.Size = New System.Drawing.Size(48, 16)
        Me.lbl_toage.TabIndex = 55
        Me.lbl_toage.Text = "Age To"
        '
        'Txt_from
        '
        Me.Txt_from.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_from.Location = New System.Drawing.Point(628, 452)
        Me.Txt_from.Name = "Txt_from"
        Me.Txt_from.Size = New System.Drawing.Size(69, 22)
        Me.Txt_from.TabIndex = 56
        Me.Txt_from.Visible = False
        '
        'Txt_to
        '
        Me.Txt_to.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_to.Location = New System.Drawing.Point(772, 452)
        Me.Txt_to.Name = "Txt_to"
        Me.Txt_to.Size = New System.Drawing.Size(65, 22)
        Me.Txt_to.TabIndex = 57
        Me.Txt_to.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(706, 491)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 914
        Me.Label4.Text = "TAX APPLIES"
        Me.Label4.Visible = False
        '
        'ChkList_ItemTypeDet
        '
        Me.ChkList_ItemTypeDet.Enabled = False
        Me.ChkList_ItemTypeDet.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkList_ItemTypeDet.FormattingEnabled = True
        Me.ChkList_ItemTypeDet.Location = New System.Drawing.Point(370, 623)
        Me.ChkList_ItemTypeDet.Name = "ChkList_ItemTypeDet"
        Me.ChkList_ItemTypeDet.Size = New System.Drawing.Size(162, 46)
        Me.ChkList_ItemTypeDet.TabIndex = 917
        Me.ChkList_ItemTypeDet.Visible = False
        '
        'ChkList_ItemType
        '
        Me.ChkList_ItemType.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkList_ItemType.FormattingEnabled = True
        Me.ChkList_ItemType.Location = New System.Drawing.Point(193, 624)
        Me.ChkList_ItemType.Name = "ChkList_ItemType"
        Me.ChkList_ItemType.Size = New System.Drawing.Size(162, 46)
        Me.ChkList_ItemType.TabIndex = 916
        Me.ChkList_ItemType.Visible = False
        '
        'List_Tax
        '
        Me.List_Tax.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.List_Tax.FormattingEnabled = True
        Me.List_Tax.Location = New System.Drawing.Point(369, 613)
        Me.List_Tax.Name = "List_Tax"
        Me.List_Tax.Size = New System.Drawing.Size(162, 46)
        Me.List_Tax.TabIndex = 915
        Me.List_Tax.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 487)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 15)
        Me.Label1.TabIndex = 918
        Me.Label1.Text = "Charge Code "
        '
        'CHARGEOCDE
        '
        Me.CHARGEOCDE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CHARGEOCDE.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHARGEOCDE.Location = New System.Drawing.Point(310, 484)
        Me.CHARGEOCDE.Name = "CHARGEOCDE"
        Me.CHARGEOCDE.Size = New System.Drawing.Size(129, 21)
        Me.CHARGEOCDE.TabIndex = 919
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(457, 484)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 22)
        Me.Button1.TabIndex = 920
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(192, 544)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 15)
        Me.Label12.TabIndex = 921
        Me.Label12.Text = "Press F4 for Help"
        '
        'LST_FACILITY
        '
        Me.LST_FACILITY.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST_FACILITY.FormattingEnabled = True
        Me.LST_FACILITY.Location = New System.Drawing.Point(8, 15)
        Me.LST_FACILITY.Name = "LST_FACILITY"
        Me.LST_FACILITY.Size = New System.Drawing.Size(177, 84)
        Me.LST_FACILITY.TabIndex = 922
        Me.LST_FACILITY.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk_billingmonth)
        Me.GroupBox2.Location = New System.Drawing.Point(301, 257)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(180, 90)
        Me.GroupBox2.TabIndex = 923
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Chekbillingmonth)
        Me.GroupBox3.Location = New System.Drawing.Point(662, 233)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(161, 100)
        Me.GroupBox3.TabIndex = 924
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LST_FACILITY)
        Me.GroupBox4.Location = New System.Drawing.Point(656, 337)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(190, 100)
        Me.GroupBox4.TabIndex = 925
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(192, 516)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 15)
        Me.Label3.TabIndex = 926
        Me.Label3.Text = "CostCentre Code "
        '
        'Txt_Costcentre
        '
        Me.Txt_Costcentre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Costcentre.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Costcentre.Location = New System.Drawing.Point(310, 516)
        Me.Txt_Costcentre.Name = "Txt_Costcentre"
        Me.Txt_Costcentre.Size = New System.Drawing.Size(129, 21)
        Me.Txt_Costcentre.TabIndex = 927
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(457, 514)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(37, 22)
        Me.Button2.TabIndex = 928
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FRM_MKGA_SUBSCRIPTION_MASTER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1008, 705)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Txt_Costcentre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CHARGEOCDE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChkList_ItemTypeDet)
        Me.Controls.Add(Me.ChkList_ItemType)
        Me.Controls.Add(Me.List_Tax)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txt_to)
        Me.Controls.Add(Me.Txt_from)
        Me.Controls.Add(Me.lbl_toage)
        Me.Controls.Add(Me.Txt_Ageto)
        Me.Controls.Add(Me.Txt_Agefrom)
        Me.Controls.Add(Me.lbl_fromage)
        Me.Controls.Add(Me.LBL_APPLIEDFACILITY)
        Me.Controls.Add(Me.CBO_FACILITY)
        Me.Controls.Add(Me.LBL_CHG)
        Me.Controls.Add(Me.Comb_basedon)
        Me.Controls.Add(Me.Txt_luxuryTax)
        Me.Controls.Add(Me.Lbl_Luxurytax)
        Me.Controls.Add(Me.Grp_Print)
        Me.Controls.Add(Me.lbl_freeze)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Comb_appliedon)
        Me.Controls.Add(Me.Comb_billbasis)
        Me.Controls.Add(Me.Com_subtypecode)
        Me.Controls.Add(Me.Cmd_taxcodehelp)
        Me.Controls.Add(Me.Cmd_subhelp)
        Me.Controls.Add(Me.Lbl_Alliedon)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lbl_Basedon)
        Me.Controls.Add(Me.Txt_Taxamount)
        Me.Controls.Add(Me.Txt_subamount)
        Me.Controls.Add(Me.Txt_Taxaccountin)
        Me.Controls.Add(Me.Txt_Percentage)
        Me.Controls.Add(Me.Txt_taxcode)
        Me.Controls.Add(Me.txt_subdesc)
        Me.Controls.Add(Me.Txt_desc)
        Me.Controls.Add(Me.Txt_Subcode)
        Me.Controls.Add(Me.Lbbl_taxamount)
        Me.Controls.Add(Me.lbl_subscriptionAmount)
        Me.Controls.Add(Me.Lbl_taxaccin)
        Me.Controls.Add(Me.Lblpercentage)
        Me.Controls.Add(Me.Lbl_Taxcode)
        Me.Controls.Add(Me.Lbl_billingmonth)
        Me.Controls.Add(Me.Lbl_billbasis)
        Me.Controls.Add(Me.Lbl_typedesc)
        Me.Controls.Add(Me.Lbl_Type)
        Me.Controls.Add(Me.Lbl_subdesc)
        Me.Controls.Add(Me.LBL_SUBCODE)
        Me.Controls.Add(Me.LBL_SUB)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FRM_MKGA_SUBSCRIPTION_MASTER"
        Me.Text = "SUBSCRIPTION_MASTER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.Grp_Print.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBL_SUB As System.Windows.Forms.Label
    Friend WithEvents LBL_SUBCODE As System.Windows.Forms.Label
    Friend WithEvents Lbl_subdesc As System.Windows.Forms.Label
    Friend WithEvents Lbl_Type As System.Windows.Forms.Label
    Friend WithEvents Lbl_typedesc As System.Windows.Forms.Label
    Friend WithEvents Lbl_billbasis As System.Windows.Forms.Label
    Friend WithEvents Lbl_billingmonth As System.Windows.Forms.Label
    Friend WithEvents Lbl_Taxcode As System.Windows.Forms.Label
    Friend WithEvents Lblpercentage As System.Windows.Forms.Label
    Friend WithEvents Lbl_taxaccin As System.Windows.Forms.Label
    Friend WithEvents lbl_subscriptionAmount As System.Windows.Forms.Label
    Friend WithEvents Lbbl_taxamount As System.Windows.Forms.Label
    Friend WithEvents Txt_Subcode As System.Windows.Forms.TextBox
    Friend WithEvents Txt_desc As System.Windows.Forms.TextBox
    Friend WithEvents txt_subdesc As System.Windows.Forms.TextBox
    Friend WithEvents Txt_taxcode As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Percentage As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Taxaccountin As System.Windows.Forms.TextBox
    Friend WithEvents Txt_subamount As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Taxamount As System.Windows.Forms.TextBox
    Friend WithEvents Chekbillingmonth As System.Windows.Forms.CheckedListBox
    Friend WithEvents Lbl_Basedon As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chk_billingmonth As System.Windows.Forms.ListBox
    Friend WithEvents Lbl_Alliedon As System.Windows.Forms.Label
    Friend WithEvents Cmd_subhelp As System.Windows.Forms.Button
    Friend WithEvents Cmd_taxcodehelp As System.Windows.Forms.Button
    Friend WithEvents Com_subtypecode As System.Windows.Forms.ComboBox
    Friend WithEvents Comb_billbasis As System.Windows.Forms.ComboBox
    Friend WithEvents Comb_appliedon As System.Windows.Forms.ComboBox
    Friend WithEvents Cmd_view As System.Windows.Forms.Button
    Friend WithEvents Cmd_freeze As System.Windows.Forms.Button
    Friend WithEvents Cmd_add As System.Windows.Forms.Button
    Friend WithEvents cmd_clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_exit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_freeze As System.Windows.Forms.Label
    Friend WithEvents Grp_Print As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Cmd_Windows As System.Windows.Forms.Button
    Friend WithEvents Cmd_Dos As System.Windows.Forms.Button
    Friend WithEvents Txt_luxuryTax As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Luxurytax As System.Windows.Forms.Label
    Friend WithEvents Comb_basedon As System.Windows.Forms.ComboBox
    Friend WithEvents LBL_CHG As System.Windows.Forms.Label
    Friend WithEvents CBO_FACILITY As System.Windows.Forms.ComboBox
    Friend WithEvents LBL_APPLIEDFACILITY As System.Windows.Forms.Label
    Friend WithEvents lbl_fromage As System.Windows.Forms.Label
    Friend WithEvents Txt_Agefrom As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Ageto As System.Windows.Forms.TextBox
    Friend WithEvents lbl_toage As System.Windows.Forms.Label
    Friend WithEvents Txt_from As System.Windows.Forms.TextBox
    Friend WithEvents Txt_to As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_Authantication As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ChkList_ItemTypeDet As System.Windows.Forms.CheckedListBox
    Friend WithEvents ChkList_ItemType As System.Windows.Forms.CheckedListBox
    Friend WithEvents List_Tax As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CHARGEOCDE As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LST_FACILITY As System.Windows.Forms.CheckedListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txt_Costcentre As System.Windows.Forms.TextBox
End Class
