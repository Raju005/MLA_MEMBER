Imports System.Net.Mail
Imports System.Net
Imports System.Data.SqlClient
Imports System.IO
Imports System.Data
Imports System.Threading
Imports Microsoft.Office.Interop
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports VB = Microsoft.VisualBasic
Public Class EMAILPOSTING
    Inherits System.Windows.Forms.Form
    Dim gconnection As New GlobalClass
    Dim Sqlstring As String
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Dim i As Integer
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CbxMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Cmb_Type As System.Windows.Forms.ComboBox
    Friend WithEvents SSGRIDVIEW As AxFPSpreadADO.AxfpSpread
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EMAILPOSTING))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbxMonth = New System.Windows.Forms.DateTimePicker()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.SSGRIDVIEW = New AxFPSpreadADO.AxfpSpread()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Cmb_Type = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.SSGRIDVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(867, 150)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(120, 148)
        Me.Panel1.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(16, 100)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 32)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "EXIT"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(17, 53)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 32)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "CANCEL"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "POST"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(298, 421)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(234, 22)
        Me.TextBox2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(191, 424)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Your Gmail id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(542, 423)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(622, 422)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(64)
        Me.TextBox1.Size = New System.Drawing.Size(204, 22)
        Me.TextBox1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(182, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "For The Month"
        '
        'CbxMonth
        '
        Me.CbxMonth.CustomFormat = "MMMMM"
        Me.CbxMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CbxMonth.Location = New System.Drawing.Point(335, 113)
        Me.CbxMonth.Name = "CbxMonth"
        Me.CbxMonth.Size = New System.Drawing.Size(150, 26)
        Me.CbxMonth.TabIndex = 7
        Me.CbxMonth.Value = New Date(2009, 11, 10, 0, 0, 0, 0)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(667, 453)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(159, 22)
        Me.TextBox3.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(537, 456)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Add Attachments"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(191, 456)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Subject"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(299, 453)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(232, 22)
        Me.TextBox4.TabIndex = 10
        '
        'SSGRIDVIEW
        '
        Me.SSGRIDVIEW.DataSource = Nothing
        Me.SSGRIDVIEW.Location = New System.Drawing.Point(186, 147)
        Me.SSGRIDVIEW.Name = "SSGRIDVIEW"
        Me.SSGRIDVIEW.OcxState = CType(resources.GetObject("SSGRIDVIEW.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSGRIDVIEW.Size = New System.Drawing.Size(649, 268)
        Me.SSGRIDVIEW.TabIndex = 0
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(299, 486)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(526, 97)
        Me.TextBox5.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(180, 486)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Message Body"
        '
        'Cmb_Type
        '
        Me.Cmb_Type.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Type.FormattingEnabled = True
        Me.Cmb_Type.Location = New System.Drawing.Point(934, 541)
        Me.Cmb_Type.Name = "Cmb_Type"
        Me.Cmb_Type.Size = New System.Drawing.Size(65, 26)
        Me.Cmb_Type.TabIndex = 14
        Me.Cmb_Type.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(182, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Email Posting"
        '
        'EMAILPOSTING
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1028, 596)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Cmb_Type)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.CbxMonth)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SSGRIDVIEW)
        Me.Name = "EMAILPOSTING"
        Me.Text = "EMAILPOSTING"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.SSGRIDVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim mail As New MailMessage()
    'Dim mbill As New monthbill
    Private Sub EMAILPOSTING_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GRID_VIEW()
        'Fill_Category()
        Dim sqlstring9, COMPNAME, Dash_Pwd, Dash_Email As String
        sqlstring9 = ""
        COMPNAME = ""
        sqlstring9 = "SELECT COMPNAME,Dash_Pwd, Dash_Email FROM possetup "
        gconnection.getDataSet(sqlstring9, "possetup")
        If gdataset.Tables("possetup").Rows.Count > 0 Then
            COMPNAME = gdataset.Tables("possetup").Rows(0).Item("COMPNAME")
            Dash_Email = gdataset.Tables("possetup").Rows(0).Item("Dash_Email")
            Dash_Pwd = gdataset.Tables("possetup").Rows(0).Item("Dash_Pwd")
        End If
        

        If UCase(Mid(Trim(gCompanyAddress(0)), 1, 3)) = "UNI" Then
            TextBox2.Text = "theunitedclub@gmail.com"
            TextBox1.Text = "kswaroop"
        ElseIf UCase(Mid(Trim(gcompanyname), 1, 10)) = "THE BENGAL" Then
            TextBox2.Text = "billdesk@thebengalclub.com"
            TextBox1.Text = "37QInH1b"
        ElseIf UCase(Mid(Trim(gcompanyname), 1, 8)) = "CALCUTTA" Then
            TextBox2.Text = "ebill@calcuttaclub.in"
            TextBox1.Text = "calclub786"
        Else
            TextBox2.Text = Dash_Email
            TextBox1.Text = Dash_Pwd
            TextBox1.Enabled = False
            TextBox2.Enabled = False
        End If
        CbxMonth.Value = Now()
        'SSGRIDVIEW.ActiveRow = 1
    End Sub
    Function Fill_Category()
        Sqlstring = "SELECT TYPEDESC,MEMBERTYPE FROM MEMBERTYPE WHERE ISNULL(FREEZE,'') <> 'Y' ORDER BY MEMBERTYPE"
        Cmb_Type.Items.Clear()
        gconnection.getDataSet(Sqlstring, "TypeMaster")
        If gdataset.Tables("TypeMaster").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("TypeMaster").Rows.Count - 1
                Cmb_Type.Items.Add(gdataset.Tables("TypeMaster").Rows(i).Item("TYPEDESC") & "=>" & gdataset.Tables("TypeMaster").Rows(i).Item("MEMBERTYPE"))
            Next i
            Cmb_Type.SelectedIndex = 0
        Else
            MessageBox.Show("Plz Enter various Type into category master ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Function
    Function GRID_VIEW()
        Dim VOutputfile, Vcatefile, CateCode() As String
        Dim sout, rout As String
        Randomize()
        Vcatefile = Mid("CATE" & CStr(Int(Rnd() * 5000)), 1, 8)
        VOutputfile = Mid("SUBS" & CStr(Int(Rnd() * 5000)), 1, 8)
        'Dim rsset As ADODB.Recordset
        sout = Mid("SUS" & CStr(Int(Rnd() * 5000)), 1, 8)
        rout = Mid("REV" & CStr(Int(Rnd() * 5000)), 1, 8)
        Dim Ssql As String
        Dim vroomno As Long
        Dim vsplit() As String
        Dim vAcc As Double
        Dim Total, Debit, Credit, RowNo, I As Double
        Total = 0
        Debit = 0
        Credit = 0

        'CateCode = Split(Cmb_Type.Text, "=>")

        Ssql = "SELECT MCODE,MNAME,CONTEMAIL,membertypecode as mem_code FROM MEMBERMASTER WHERE isnull(freeze,'')<>'y' and curentstatus in('ACTIVE') and ISNULL(ltrim(rtrim(CONTEMAIL)),'') <> ''   AND ISNULL(ltrim(rtrim(CONTEMAIL)),'') <> 'x'  ORDER BY membertypecode,MCODE"

        gconnection.getDataSet(Ssql, "MONTH_VIEW")
        SSGRIDVIEW.ClearRange(1, 1, -1, -1, True)
        If gdataset.Tables("MONTH_VIEW").Rows.Count = 0 Then
            MsgBox("No Records Available ", vbInformation + vbOKOnly, "MESSAGE")
        Else
            For I = 0 To gdataset.Tables("MONTH_VIEW").Rows.Count - 1
                With SSGRIDVIEW
                    .Row = I + 1
                    .Col = 1
                    .Text = Trim(gdataset.Tables("MONTH_VIEW").Rows(I).Item("MCODE") & "")
                    .Col = 2
                    .Text = Trim(gdataset.Tables("MONTH_VIEW").Rows(I).Item("MNAME") & "")
                    .Col = 3
                    .Text = Trim(gdataset.Tables("MONTH_VIEW").Rows(I).Item("CONTEMAIL") & "")
                    .Col = 5
                    .Text = Trim(gdataset.Tables("MONTH_VIEW").Rows(I).Item("mem_code") & "")

                End With
                If SSGRIDVIEW.MaxRows < I + 20 Then
                    SSGRIDVIEW.MaxRows = SSGRIDVIEW.MaxRows + 1
                End If
            Next
        End If


    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim mcode, mailid, MEMCODE, filename, SSQL, filename1 As String
        Dim AFILE As File
        Dim cmdText, billdt2, PDFDATE As String
        Dim SQLSTRING4, SQLSTRING5, sqlstring1, BILDT3, bildt4, BILDT5, BILDT1, BILL, year As String
        Dim duedate, membertype, month, STAX, TINNO, PNO, add1, add2, add3, add4, TYPE(0) As String
        Dim opl As Integer

        If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then BILDT1 = "30-apr-" & Mid(gFinancialyearStart, 7, 4) : year = "APR_" & gFinancalyearStart : PDFDATE = "APRIL-" & gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then BILDT1 = "31-may-" & Mid(gFinancialyearStart, 7, 4) : year = "MAY_" & gFinancalyearStart : PDFDATE = "MAY-" & gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then BILDT1 = "30-jun-" & Mid(gFinancialyearStart, 7, 4) : year = "JUN_" & gFinancalyearStart : PDFDATE = "JUNE-" & gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then BILDT1 = "31-jul-" & Mid(gFinancialyearStart, 7, 4) : year = "JUL_" & gFinancalyearStart : PDFDATE = "JULY-" & gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then BILDT1 = "31-aug-" & Mid(gFinancialyearStart, 7, 4) : year = "AUG_" & gFinancalyearStart : PDFDATE = "AUGUST-" & gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then BILDT1 = "30-SEP-" & Mid(gFinancialyearStart, 7, 4) : year = "SEP_" & gFinancalyearStart : PDFDATE = "SEPTEMBER-" & gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then BILDT1 = "31-OCT-" & Mid(gFinancialyearStart, 7, 4) : year = "OCT_" & gFinancalyearStart : PDFDATE = "OCTOBER-" & gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then BILDT1 = "30-NOV-" & Mid(gFinancialyearStart, 7, 4) : year = "NOV_" & gFinancalyearStart : PDFDATE = "NOVEMBER-" & gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then BILDT1 = "31-DEC-2014" & Mid(2014, 7, 4) : year = "DEC_" & gFinancalyearStart : PDFDATE = "DECEMBER-" & gFinancalyearStart

        If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then BILDT1 = "31-JAN-" & gFinancialyearEnd : year = "JAN_" & gFinancialyearEnd : PDFDATE = "JANUARY-" & gFinancialyearEnd
        If gFinancialyearEnd Mod 4 = 0 Then
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then BILDT1 = "29-feb-" & gFinancialyearEnd : year = "FEB_" & gFinancialyearEnd : PDFDATE = "FEBRUARY-" & gFinancialyearEnd
        Else
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then BILDT1 = "28-feb-" & gFinancialyearEnd : year = "FEB_" & gFinancialyearEnd : PDFDATE = "FEBRUARY-" & gFinancialyearEnd
        End If
        If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then BILDT1 = "31-mar-" & gFinancialyearEnd : year = "MAR_" & gFinancialyearEnd : PDFDATE = "MARCH-" & gFinancialyearEnd

        If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then BILDT1 = "01/apr/" & gFinancialyearEnd : BILDT3 = "30/04/" & gFinancialyearEnd : BILDT5 = "15/04/" & gFinancialyearEnd : BILL = "01st Mar " & Mid(gFinancalyearStart, 3, 2) & " to 31st Mar " & Mid(gFinancalyearStart, 3, 2) : PDFDATE = "MARCH-" & gFinancialyearEnd

        If gpdf = "" Then
            MessageBox.Show("Pls Provide PDF Path in Dbs key")
            Exit Sub
        End If

        With SSGRIDVIEW
            For i = 1 To SSGRIDVIEW.DataRowCnt
                .Row = i
                .Col = 6
                If .Text = "Yes" Then
                    .Col = 4
                    .Text = "SENDING"
                    .Col = 1
                    mcode = .Text
                    .Col = 3
                    mailid = .Text
                    .Col = 5
                    MEMCODE = .Text
                    'mbill.CMBMONTH.Text = MonthName(Month(DateTimePicker1.Value), False)
                    If UCase(Mid(Trim(gCompanyAddress(0)), 1, 3)) = "UNI" Then
                        'filename = mbill.ordnanceclubformail(mcode)
                    ElseIf UCase(Mid(Trim(gcompanyname), 1, 10)) = "THE BENGAL" Then
                        Dim FILEPATH As String
                        FILEPATH = gpdf & "\" & year & "\" & mcode.Replace("*", " ") & "-" & PDFDATE & "bill.PDF"
                        If File.Exists(FILEPATH) Then
                            filename = FILEPATH
                        Else
                            filename = ""
                        End If
                        FILEPATH = gpdf & "\" & year & "\" & mcode.Replace("*", " ") & "-" & PDFDATE & "checklist.PDF"
                        If File.Exists(FILEPATH) Then
                            filename1 = FILEPATH
                        Else
                            filename1 = ""
                        End If
                    ElseIf Mid(UCase(Trim(gcompanyname)), 1, 3) = "MLA" Then
                        Dim FILEPATH As String
                        FILEPATH = gpdf & "\" & year & "\" & mcode.Replace("*", " ") & "-" & PDFDATE & "bill.PDF"
                        If File.Exists(FILEPATH) Then
                            filename = FILEPATH
                        Else
                            filename = ""
                        End If
                        FILEPATH = gpdf & "\" & year & "\" & mcode.Replace("*", " ") & "-" & PDFDATE & "checklist.PDF"
                        If File.Exists(FILEPATH) Then
                            filename1 = FILEPATH
                        Else
                            filename1 = ""
                        End If
                    ElseIf UCase(Mid(Trim(gcompanyname), 1, 8)) = "CALCUTTA" Then
                        Dim FILEPATH As String
                        'FILEPATH = gpdf & "\" & year & "\" & mcode.Replace("*", " ") & "-" & PDFDATE & "bill.PDF"
                        FILEPATH = gpdf & "\" & year & "\" & mcode.Replace("/", "_") & "-" & PDFDATE & "bill.PDF"
                        If File.Exists(FILEPATH) Then
                            filename = FILEPATH
                        Else
                            filename = ""
                        End If
                        'PDFDATE = "SEPTEMBER-" & gFinancalyearStart
                        'FILEPATH = gpdf & "\" & year & "\" & mcode.Replace("*", " ") & "-" & PDFDATE & "checklist.PDF"
                        FILEPATH = gpdf & "\" & year & "\" & mcode.Replace("/", "_") & "-" & PDFDATE & "checklist.PDF"
                        If File.Exists(FILEPATH) Then
                            filename1 = FILEPATH
                        Else
                            filename1 = ""
                        End If
                    Else
                        filename = ""
                        filename1 = ""
                    End If
                    If filename <> "" Then
                        Dim f As Boolean
                        If Mid(UCase(Trim(gcompanyname)), 1, 3) = "MLA" Then

                            f = sendmail(mailid, filename, filename1)
                        Else
                            f = sendmail_outlook(mailid, filename, filename1, mcode)
                        End If
                        If f Then
                            .Col = 4
                            .Text = "SENT"
                            'If UCase(Mid(Trim(gCompanyAddress(0)), 1, 3)) = "UNI" Then
                            '    SSQL = "INSERT INTO EMAILSTATUS VALUES('" & mcode & "','" & MEMCODE & "','" & month(CbxMonth.Value) & "',  GETDATE()  ,'SENT')"
                            '    gconnection.ExcuteStoreProcedure(SSQL)
                            'ElseIf UCase(Mid(Trim(gCompanyAddress(0)), 1, 4)) = "CALC" Then
                            '    SSQL = "INSERT INTO EMAILSTATUS VALUES('" & mcode & "','" & MEMCODE & "','" & month(CbxMonth.Value) & "',  GETDATE()  ,'SENT')"
                            '    gconnection.ExcuteStoreProcedure(SSQL)
                            'End If
                            If UCase(Mid(Trim(gcompanyname), 1, 8)) = "CALCUTTA" Then
                                SSQL = "INSERT INTO EMAILSTATUS VALUES('" & mcode & "','" & MEMCODE & "','" & Format((CbxMonth.Value), "dd-MMM-yyyy") & "',  GETDATE()  ,'SENT')"
                                gconnection.ExcuteStoreProcedure(SSQL)
                            End If
                        Else
                            .Col = 4
                            .Text = "Mail Sending Error"
                            'If UCase(Mid(Trim(gCompanyAddress(0)), 1, 3)) = "UNI" Then
                            '    SSQL = "INSERT INTO EMAILSTATUS VALUES('" & mcode & "','" & MEMCODE & "','" & Month(DateTimePicker1.Value) & "',  GETDATE()  ,'Mail Sending Error')"
                            '    gconnection.ExcuteStoreProcedure(SSQL)
                            'ElseIf UCase(Mid(Trim(gCompanyAddress(0)), 1, 3)) = "ORD" Then
                            '    SSQL = "INSERT INTO EMAILSTATUS VALUES('" & mcode & "','" & MEMCODE & "','" & Month(DateTimePicker1.Value) & "',  GETDATE()  ,'Mail Sending Error')"
                            '    gconnection.ExcuteStoreProcedure(SSQL)
                            'ElseIf UCase(Mid(Trim(gCompanyAddress(0)), 1, 4)) = "CALC" Then
                            '    SSQL = "INSERT INTO EMAILSTATUS VALUES('" & mcode & "','" & MEMCODE & "','" & Month(DateTimePicker1.Value) & "',  GETDATE()  ,'Mail Sending Error')"
                            '    gconnection.ExcuteStoreProcedure(SSQL)
                            'End If
                            If UCase(Mid(Trim(gcompanyname), 1, 8)) = "CALCUTTA" Then
                                SSQL = "INSERT INTO EMAILSTATUS VALUES('" & mcode & "','" & MEMCODE & "','" & Format((CbxMonth.Value), "dd-MMM-yyyy") & "',  GETDATE()  ,'Mail Sending Error')"
                                gconnection.ExcuteStoreProcedure(SSQL)
                            End If
                        End If
                    Else
                        .Col = 4
                        .Text = "File Not Found,Check in Path"
                        'If UCase(Mid(Trim(gCompanyAddress(0)), 1, 4)) = "CALC" Then
                        '    SSQL = "INSERT INTO EMAILSTATUS VALUES('" & mcode & "','" & MEMCODE & "','" & Month(DateTimePicker1.Value) & "',  GETDATE()  ,'File Not Found')"
                        '    gconnection.ExcuteStoreProcedure(SSQL)
                        'End If
                    End If
                End If
            Next
            MessageBox.Show("Message Sent Task Completed", MyCompanyName)
        End With
    End Sub
    Private Function sendmail(ByVal mailid As String, ByVal filename As String, ByVal filename1 As String) As Boolean
        Dim r As Boolean
        Dim SmtpServer As New SmtpClient()
        SmtpServer.Credentials = New Net.NetworkCredential(TextBox2.Text, TextBox1.Text)
        SmtpServer.Port = 587
        SmtpServer.Host = "smtp.gmail.com"
        ''SmtpServer.Port = 465
        ''SmtpServer.Host = "mail1441.pair.com"
        'SmtpServer.Timeout = 1000000
        SmtpServer.EnableSsl = True
        'SmtpServer.UseDefaultCredentials = False

        mail = New MailMessage()
        'Dim addr() As String = TextBox2.Text.Split(",")
        Dim addr() As String = mailid.Split(",")
        Try
            If UCase(Mid(Trim(gCompanyAddress(0)), 1, 3)) = "UNI" Then
                mail.From = New MailAddress(TextBox2.Text, "monthbill")
            ElseIf UCase(Mid(Trim(gcompanyname), 1, 6)) = "EASTER" Then
                mail.From = New MailAddress(TextBox2.Text, "EMC")
            ElseIf Mid(UCase(Trim(gcompanyname)), 1, 3) = "MLA" Then
                mail.From = New MailAddress(TextBox2.Text, "MLA'S CLUB")
            Else
                mail.From = New MailAddress(TextBox2.Text, "RCL")
            End If
            Dim i As Byte
            For i = 0 To addr.Length - 1
                mail.To.Add(addr(i))
            Next
            If UCase(Mid(Trim(gCompanyAddress(0)), 1, 3)) = "UNI" Then
                mail.Subject = " MONTHBILL FROM THE UNITED CLUB"
                mail.Body = "PLEASE FIND THE ATTACHMENT AS YOUR MONTHBILL( note: please open the attachment with wordpad for better look and feel)"
            ElseIf UCase(Mid(Trim(gcompanyname), 1, 6)) = "EASTER" Then
                mail.Subject = Trim(TextBox4.Text) '" MONTHBILL FROM THE ORDNANCE CLUB"
                mail.Body = Trim(TextBox5.Text)
            ElseIf Mid(UCase(Trim(gcompanyname)), 1, 3) = "MLA" Then
                mail.Subject = " MONTHBILL FROM MLA'S CLUB"
                mail.Body = "PLEASE FIND THE ATTACHMENT OF YOUR MONTHBILL."
            Else
                mail.Subject = TextBox4.Text
                mail.Body = "PLEASE FIND THE ATTACHMENT " & TextBox5.Text
            End If
            If filename <> "" Then
                mail.Attachments.Add(New System.Net.Mail.Attachment(filename))
            End If
            If filename1 <> "" Then
                mail.Attachments.Add(New System.Net.Mail.Attachment(filename1))
            End If
            ' Dim interval As Integer = 100000
            'Dim sw As New Stopwatch
            'sw.Start()
            'Do While sw.ElapsedMilliseconds < interval
            ' Allows UI to remain responsive
            'Application.DoEvents()
            'Loop
            'sw.Stop()
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
            mail.ReplyTo = New MailAddress(TextBox2.Text)
            r = True
            'dim  client as new SmtpClient(args[1])
            'client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
            SmtpServer.Timeout = 1000000
            SmtpServer.Send(mail)

        Catch ex As System.Exception
            MsgBox(ex.ToString())
            r = False
        End Try
        Return r

        'MsgBox("The form is setteled in real ?Environment please insure that the framework 2.0 is installed?")
    End Function
    Private Function sendmail_outlook(ByVal mailid As String, ByVal filename As Object, filename1 As Object, MemNub As String) As Boolean
        Dim r As Boolean
        Dim oApp As Outlook._Application
        Dim oMsg As Outlook._MailItem
        Try
            oApp = New Outlook.Application()
            oMsg = oApp.CreateItem(Outlook.OlItemType.olMailItem)
            oMsg.Subject = MemNub & " : Invoice For the Month " & TextBox4.Text
            oMsg.Body = TextBox5.Text & vbCr & vbCr
            oMsg.To = mailid
            Dim sSource As String = filename
            Dim sDisplayName As String
            If UCase(Mid(Trim(gcompanyname), 1, 8)) = "CALCUTTA" Then
                sDisplayName = "Culcutta Club"
            Else
                sDisplayName = "BCL"
            End If
            'Dim sDisplayName As String = "BCL"
            r = True
            Dim sBodyLen As String = oMsg.Body.Length
            Dim oAttachs As Outlook.Attachments = oMsg.Attachments
            Dim oAttach As Outlook.Attachment
            oAttach = oAttachs.Add(sSource, , sBodyLen + 1, sDisplayName)
            sSource = filename1
            oAttach = oAttachs.Add(sSource, , sBodyLen + 1, sDisplayName)
            'mail.Attachments.Add(filename)
            'mail.Attachments.Add(filename1)
            oMsg.Send()
            oApp = Nothing
            oMsg = Nothing
            oAttach = Nothing
            oAttachs = Nothing

        Catch ex As Exception
            'MsgBox(ex.ToString())
            r = False
        End Try
        Return r
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub SSGRIDVIEW_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles SSGRIDVIEW.KeyDownEvent
        Dim I As Integer
        Dim VSTR As Integer
        If e.keyCode = Keys.F2 Then
            For I = SSGRIDVIEW.ActiveRow To SSGRIDVIEW.DataRowCnt
                With SSGRIDVIEW
                    .Row = I
                    .Col = 6
                    .Text = "Yes"
                End With
            Next
        End If
        If e.keyCode = Keys.F3 Then
            For I = SSGRIDVIEW.ActiveRow To SSGRIDVIEW.DataRowCnt
                With SSGRIDVIEW
                    .Row = I
                    .Col = 6
                    .Text = "No"
                End With
            Next
        ElseIf e.keyCode = Keys.F7 Then
            'Dim frmSrc As New frmSearch
            'frmSrc.farPoint = SSGRIDVIEW
            'frmSrc.ShowDialog(Me)
        End If

    End Sub

    Private Sub DateTimePicker1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CbxMonth.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim SSQL As String
            Dim I As Integer
            SSQL = "SELECT MCODE,MEMCODE,STATUS  FROM EMAILSTATUS WHERE MONTHNO=" & Month(Me.CbxMonth.Value) & ""
            gconnection.getDataSet(SSQL, "RAU")
            If gdataset.Tables("RAU").Rows.Count > 0 Then
                'For I = 0 To gdataset.Tables("RAU").Rows.Count - 1
                '    With SSGRIDVIEW
                '        .Row = I + 1
                '        .Col = 1
                '        If .Text = Trim(gdataset.Tables("RAU").Rows(I).Item("MCODE") & "") Then
                '            .Col = 4
                '            .Text = Trim(gdataset.Tables("RAU").Rows(I).Item("STATUS") & "")
                '        End If

                '    End With
                'Next
            End If
        End If
    End Sub



    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Dim file As New OpenFileDialog

        If File.ShowDialog = DialogResult.OK Then
            TextBox3.Text = file.FileName
            'ppath = File.FileName
            'PHOTO.Checked = True
        Else
            TextBox3.Text = ""
        End If
    End Sub

    Private Sub SSGRIDVIEW_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles SSGRIDVIEW.Advance

    End Sub

    Private Sub Cmb_Type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Type.SelectedIndexChanged
        Call GRID_VIEW()
    End Sub

End Class
