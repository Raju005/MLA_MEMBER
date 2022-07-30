Imports System.Data.SqlClient
Imports System.IO
Public Class MMHELP
    Inherits System.Windows.Forms.Form
    Dim gconnection As New GlobalClass
    Dim DT As New DataSet
    Public BILLNO As String
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
    Friend WithEvents txt_BillAmount As System.Windows.Forms.TextBox
    Friend WithEvents txt_TaxValue As System.Windows.Forms.TextBox
    Friend WithEvents txt_TotalValue As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Servercode As System.Windows.Forms.Label
    Friend WithEvents txt_ServerCode As System.Windows.Forms.TextBox
    Friend WithEvents txt_ServerName As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ServerName As System.Windows.Forms.Label
    Friend WithEvents lbl_Membercode As System.Windows.Forms.Label
    Friend WithEvents txt_MemberName As System.Windows.Forms.TextBox
    Friend WithEvents txt_MemberCode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_MemberName As System.Windows.Forms.Label
    Public WithEvents SSGRID_BILLDETAILS As AxFPSpreadADO.AxfpSpread
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MMHELP))
        Me.SSGRID_BILLDETAILS = New AxFPSpreadADO.AxfpSpread()
        Me.txt_BillAmount = New System.Windows.Forms.TextBox()
        Me.txt_TaxValue = New System.Windows.Forms.TextBox()
        Me.txt_TotalValue = New System.Windows.Forms.TextBox()
        Me.lbl_Servercode = New System.Windows.Forms.Label()
        Me.txt_ServerCode = New System.Windows.Forms.TextBox()
        Me.txt_ServerName = New System.Windows.Forms.TextBox()
        Me.lbl_ServerName = New System.Windows.Forms.Label()
        Me.lbl_Membercode = New System.Windows.Forms.Label()
        Me.txt_MemberName = New System.Windows.Forms.TextBox()
        Me.txt_MemberCode = New System.Windows.Forms.TextBox()
        Me.lbl_MemberName = New System.Windows.Forms.Label()
        CType(Me.SSGRID_BILLDETAILS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SSGRID_BILLDETAILS
        '
        Me.SSGRID_BILLDETAILS.DataSource = Nothing
        Me.SSGRID_BILLDETAILS.Location = New System.Drawing.Point(6, -1)
        Me.SSGRID_BILLDETAILS.Name = "SSGRID_BILLDETAILS"
        Me.SSGRID_BILLDETAILS.OcxState = CType(resources.GetObject("SSGRID_BILLDETAILS.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSGRID_BILLDETAILS.Size = New System.Drawing.Size(790, 193)
        Me.SSGRID_BILLDETAILS.TabIndex = 48
        '
        'txt_BillAmount
        '
        Me.txt_BillAmount.BackColor = System.Drawing.Color.Wheat
        Me.txt_BillAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_BillAmount.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BillAmount.Location = New System.Drawing.Point(675, 198)
        Me.txt_BillAmount.Name = "txt_BillAmount"
        Me.txt_BillAmount.Size = New System.Drawing.Size(119, 20)
        Me.txt_BillAmount.TabIndex = 54
        Me.txt_BillAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_TaxValue
        '
        Me.txt_TaxValue.BackColor = System.Drawing.Color.Wheat
        Me.txt_TaxValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_TaxValue.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TaxValue.Location = New System.Drawing.Point(571, 198)
        Me.txt_TaxValue.Name = "txt_TaxValue"
        Me.txt_TaxValue.Size = New System.Drawing.Size(103, 20)
        Me.txt_TaxValue.TabIndex = 52
        Me.txt_TaxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_TotalValue
        '
        Me.txt_TotalValue.BackColor = System.Drawing.Color.Wheat
        Me.txt_TotalValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_TotalValue.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalValue.Location = New System.Drawing.Point(459, 198)
        Me.txt_TotalValue.Name = "txt_TotalValue"
        Me.txt_TotalValue.Size = New System.Drawing.Size(111, 20)
        Me.txt_TotalValue.TabIndex = 50
        Me.txt_TotalValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_Servercode
        '
        Me.lbl_Servercode.AutoSize = True
        Me.lbl_Servercode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Servercode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Servercode.ForeColor = System.Drawing.Color.Brown
        Me.lbl_Servercode.Location = New System.Drawing.Point(179, 151)
        Me.lbl_Servercode.Name = "lbl_Servercode"
        Me.lbl_Servercode.Size = New System.Drawing.Size(94, 15)
        Me.lbl_Servercode.TabIndex = 60
        Me.lbl_Servercode.Text = "SERVER CODE :"
        '
        'txt_ServerCode
        '
        Me.txt_ServerCode.BackColor = System.Drawing.Color.Wheat
        Me.txt_ServerCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ServerCode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ServerCode.Location = New System.Drawing.Point(280, 151)
        Me.txt_ServerCode.MaxLength = 15
        Me.txt_ServerCode.Name = "txt_ServerCode"
        Me.txt_ServerCode.Size = New System.Drawing.Size(168, 21)
        Me.txt_ServerCode.TabIndex = 57
        '
        'txt_ServerName
        '
        Me.txt_ServerName.BackColor = System.Drawing.Color.Wheat
        Me.txt_ServerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ServerName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ServerName.Location = New System.Drawing.Point(596, 151)
        Me.txt_ServerName.MaxLength = 50
        Me.txt_ServerName.Name = "txt_ServerName"
        Me.txt_ServerName.ReadOnly = True
        Me.txt_ServerName.Size = New System.Drawing.Size(200, 21)
        Me.txt_ServerName.TabIndex = 58
        '
        'lbl_ServerName
        '
        Me.lbl_ServerName.AutoSize = True
        Me.lbl_ServerName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ServerName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ServerName.ForeColor = System.Drawing.Color.Brown
        Me.lbl_ServerName.Location = New System.Drawing.Point(471, 151)
        Me.lbl_ServerName.Name = "lbl_ServerName"
        Me.lbl_ServerName.Size = New System.Drawing.Size(95, 15)
        Me.lbl_ServerName.TabIndex = 64
        Me.lbl_ServerName.Text = "SERVER NAME :"
        '
        'lbl_Membercode
        '
        Me.lbl_Membercode.AutoSize = True
        Me.lbl_Membercode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Membercode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Membercode.ForeColor = System.Drawing.Color.Brown
        Me.lbl_Membercode.Location = New System.Drawing.Point(179, 111)
        Me.lbl_Membercode.Name = "lbl_Membercode"
        Me.lbl_Membercode.Size = New System.Drawing.Size(98, 15)
        Me.lbl_Membercode.TabIndex = 59
        Me.lbl_Membercode.Text = "MEMBER CODE :"
        '
        'txt_MemberName
        '
        Me.txt_MemberName.BackColor = System.Drawing.Color.Wheat
        Me.txt_MemberName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_MemberName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MemberName.Location = New System.Drawing.Point(596, 111)
        Me.txt_MemberName.MaxLength = 50
        Me.txt_MemberName.Name = "txt_MemberName"
        Me.txt_MemberName.ReadOnly = True
        Me.txt_MemberName.Size = New System.Drawing.Size(200, 21)
        Me.txt_MemberName.TabIndex = 56
        Me.txt_MemberName.Visible = False
        '
        'txt_MemberCode
        '
        Me.txt_MemberCode.BackColor = System.Drawing.Color.Wheat
        Me.txt_MemberCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_MemberCode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MemberCode.Location = New System.Drawing.Point(280, 111)
        Me.txt_MemberCode.MaxLength = 15
        Me.txt_MemberCode.Name = "txt_MemberCode"
        Me.txt_MemberCode.Size = New System.Drawing.Size(168, 21)
        Me.txt_MemberCode.TabIndex = 55
        Me.txt_MemberCode.Visible = False
        '
        'lbl_MemberName
        '
        Me.lbl_MemberName.AutoSize = True
        Me.lbl_MemberName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MemberName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MemberName.ForeColor = System.Drawing.Color.Brown
        Me.lbl_MemberName.Location = New System.Drawing.Point(471, 111)
        Me.lbl_MemberName.Name = "lbl_MemberName"
        Me.lbl_MemberName.Size = New System.Drawing.Size(99, 15)
        Me.lbl_MemberName.TabIndex = 63
        Me.lbl_MemberName.Text = "MEMBER NAME :"
        '
        'MMHELP
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(794, 225)
        Me.Controls.Add(Me.SSGRID_BILLDETAILS)
        Me.Controls.Add(Me.lbl_Servercode)
        Me.Controls.Add(Me.txt_ServerCode)
        Me.Controls.Add(Me.txt_ServerName)
        Me.Controls.Add(Me.lbl_ServerName)
        Me.Controls.Add(Me.lbl_Membercode)
        Me.Controls.Add(Me.txt_MemberName)
        Me.Controls.Add(Me.txt_MemberCode)
        Me.Controls.Add(Me.lbl_MemberName)
        Me.Controls.Add(Me.txt_BillAmount)
        Me.Controls.Add(Me.txt_TaxValue)
        Me.Controls.Add(Me.txt_TotalValue)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "MMHELP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MMHELP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.SSGRID_BILLDETAILS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub MMHELP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'CLEARMETHOD()
    End Sub
    Private Sub txt_MemberCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_MemberCode.Validated
    End Sub
    Private Sub txt_ServerCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ServerCode.TextChanged
        Dim strstring As String
        Try
            If Trim(txt_ServerCode.Text) <> "" Then
                strstring = "SELECT * FROM servermaster WHERE ServerCode='" & Trim(txt_ServerCode.Text) & "'AND Freeze='N'"
                gconnection.getDataSet(strstring, "servermaster")
                If gdataset.Tables("servermaster").Rows.Count > 0 Then
                    txt_ServerCode.Text = gdataset.Tables("servermaster").Rows(0).Item("ServerCode")
                    txt_ServerName.Text = gdataset.Tables("servermaster").Rows(0).Item("ServerName")
                Else
                    txt_ServerCode.Text = ""
                    txt_ServerName.Text = ""
                End If
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Public Function BILLDETAILS(ByVal BILLNO As String) As String
        Dim strstring As String
        Dim I As Integer
        Try
            If Trim(BILLNO) <> "" Then
                Call CLEARMETHOD()
                strstring = "SELECT ISNULL(UPPER(MCODE),'') AS MCODE,ISNULL(SCODE,'') AS SCODE,ISNULL(BILLDETAILS,'') AS BILLDETAILS,ISNULL(ITEMCODE,'') AS ITEMCODE,ISNULL(ITEMDESC,'') AS ITEMDESC,ISNULL(RATE,0) AS RATE,sum(ISNULL(QTY,0)) AS QTY,SUM(ISNULL(AMOUNT,0)) AS AMOUNT,SUM(ISNULL(TAXAMOUNT,0)) AS TAXAMOUNT FROM BILL_DET_TAX "
                strstring = strstring & " WHERE  BILLDETAILS='" & BILLNO & "' GROUP BY MCODE,SCODE,BILLDETAILS,ITEMCODE,ITEMDESC,RATE"
                gconnection.getDataSet(strstring, "BILDET")
                txt_TaxValue.Text = 0
                txt_TotalValue.Text = 0
                txt_BillAmount.Text = 0
                If gdataset.Tables("BILDET").Rows.Count > 0 Then
                    txt_MemberCode.Text = gdataset.Tables("BILDET").Rows(0).Item("MCODE")
                    txt_ServerCode.Text = gdataset.Tables("BILDET").Rows(0).Item("SCode")
                    With SSGRID_BILLDETAILS
                        .SetActiveCell(1, 1)
                        For I = 0 To gdataset.Tables("BILDET").Rows.Count - 1
                            .Col = 1
                            .Row = I + 1
                            .Text = gdataset.Tables("BILDET").Rows(I).Item("ITEMCODE")
                            .Col = 2
                            .Row = I + 1
                            .Text = gdataset.Tables("BILDET").Rows(I).Item("ITEMDESC")
                            .Col = 3
                            .Row = I + 1
                            .Text = Format(Val(gdataset.Tables("BILDET").Rows(I).Item("QTY")), "0")
                            .Col = 4
                            .Row = I + 1
                            .Text = Format(Val(gdataset.Tables("BILDET").Rows(I).Item("RATE")), "0.00")
                            .Col = 5
                            .Row = I + 1
                            .Text = Format(Val(gdataset.Tables("BILDET").Rows(I).Item("AMOUNT")), "0.00")
                            .Col = 6
                            .Row = I + 1
                            .Text = Format(Val(gdataset.Tables("BILDET").Rows(I).Item("TAXAMOUNT")), "0.00")
                            .Col = 7
                            .Row = I + 1
                            .Text = Format(Val(gdataset.Tables("BILDET").Rows(I).Item("TAXAMOUNT")) + Val(gdataset.Tables("BILDET").Rows(I).Item("AMOUNT")), "0.00")
                            .SetActiveCell(1, I + 2)
                            Call Calculate()
                        Next
                    End With
                    'SETTLEMENT
                    'strstring = " SELECT ISNULL(A.BILLDETAILS,'') AS BILLDETAILS,ISNULL(A.BILLDATE,'') AS BILLDATE,ISNULL(A.MCODE,'') AS MCODE,ISNULL(B.MNAME,'') AS MNAME,"
                    'strstring = strstring & " ISNULL(A.AMOUNT,0) AS AMOUNT,ISNULL(A.DESCRIPTION,'') AS DESCRIPTION FROM SETTLEMENT A LEFT OUTER JOIN  MEMBERMASTER B ON A.MCODE=B.MCODE"
                    'strstring = strstring & " WHERE ISNULL(A.DELETEFLAG,'')<>'Y'  AND ISNULL(A.BILLDETAILS,'')='" & BILLNO & "'"
                    'strstring = strstring & " ORDER BY MCODE,MNAME "
                    'gconnection.getDataSet(strstring, "SETTLEMENT")
                    'If gdataset.Tables("SETTLEMENT").Rows.Count > 0 Then
                    '    With ssgrid_settlement
                    '        .SetActiveCell(1, 1)
                    '        For I = 0 To gdataset.Tables("SETTLEMENT").Rows.Count - 1
                    '            .Col = 1
                    '            .Row = I + 1
                    '            .Text = gdataset.Tables("SETTLEMENT").Rows(I).Item("MCODE")
                    '            .Col = 2
                    '            .Row = I + 1
                    '            .Text = gdataset.Tables("SETTLEMENT").Rows(I).Item("MNAME")
                    '            .Col = 3
                    '            .Row = I + 1
                    '            .Text = Format(Val(gdataset.Tables("SETTLEMENT").Rows(I).Item("AMOUNT")), "0.00")
                    '        Next
                    '    End With
                End If
            Else
                'Call CLEARMETHOD()
            End If
            ' End If
        Catch ex As Exception
            Exit Function
        End Try
    End Function
    Private Sub CLEARMETHOD()
        txt_BillAmount.Text = ""
        txt_TaxValue.Text = ""
        txt_TotalValue.Text = ""
        txt_ServerCode.Text = ""
        txt_MemberCode.Text = ""
        txt_MemberName.Text = ""
        txt_ServerCode.Text = ""
        SSGRID_BILLDETAILS.ClearRange(1, 1, -1, -1, True)
        ' ssgrid_settlement.ClearRange(1, 1, -1, -1, True)
        txt_BillAmount.Text = Format(txt_BillAmount.Text, "0.00")
        txt_TaxValue.Text = Format(txt_TaxValue.Text, "0.00")
        txt_TotalValue.Text = Format(txt_TotalValue.Text, "0.00")
    End Sub
    Private Sub MMHELP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Hide()
        End If
    End Sub
    Private Sub txt_MemberCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_MemberCode.TextChanged
        Dim strstring As String
        Try
            If Trim(txt_MemberCode.Text) <> "" Then
                strstring = "SELECT ISNULL(UPPER(MCODE),'') AS MCODE,ISNULL(MNAME,'') AS MNAME,ISNULL(CRIDITNUMBER,'') AS CRIDITNUMBER FROM membermaster WHERE MCODE='" & Trim(txt_MemberCode.Text) & "'"
                gconnection.getDataSet(strstring, "membermaster")
                If gdataset.Tables("membermaster").Rows.Count > 0 Then
                    txt_MemberCode.Text = gdataset.Tables("membermaster").Rows(0).Item("MCODE")
                    txt_MemberName.Text = gdataset.Tables("membermaster").Rows(0).Item("MNAME")
                Else
                    txt_MemberCode.Text = ""
                    txt_MemberName.Text = ""
                End If
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Private Sub SSGRID_BILLDETAILS_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles SSGRID_BILLDETAILS.Advance
    End Sub
    Private Sub Calculate()
        Dim qty, taxperc, cancel, kotstatus, rate As String
        Dim total, Taxamount, cancelamt, canceltax, Billamount As Double
        Dim i As Integer
        With SSGRID_BILLDETAILS
            If .ActiveCol = 5 Or .ActiveCol = 4 Or .ActiveCol = 1 Then
                Me.txt_TaxValue.Text = "0.00"
                Me.txt_TotalValue.Text = "0.00"
                Me.txt_BillAmount.Text = "0.00"
                For i = 1 To .DataRowCnt
                    .Col = 5
                    .Row = i
                    total = Format(Val(.Text), "0.0")
                    .Col = 6
                    .Row = i
                    Taxamount = Format(Val(.Text), "0.0")
                    .Col = 7
                    .Row = i
                    Billamount = Format(Val(.Text), "0.0")
                    Me.txt_TotalValue.Text = Format(Val(Me.txt_TotalValue.Text) + Val(total), "0.00")
                    Me.txt_TaxValue.Text = Format(Val(Me.txt_TaxValue.Text) + Val(Taxamount), "0.00")
                    txt_BillAmount.Text = Format(Val(Me.txt_BillAmount.Text) + Val(Billamount), "0.00")
                Next i
            End If
        End With
        i = i - 1
    End Sub
End Class
