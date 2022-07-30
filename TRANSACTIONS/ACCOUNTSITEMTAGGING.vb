Public Class ACCOUNTSITEMTAGGING

    Inherits System.Windows.Forms.Form
    Dim Vconn As New GlobalClass
    Dim SQLSTRING As String
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmd_update As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SSMatching As AxFPSpreadADO.AxfpSpread
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ssgrid1 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ACCOUNTSITEMTAGGING))
        Me.ssgrid1 = New AxFPSpreadADO.AxfpSpread()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmd_update = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.ssgrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ssgrid1
        '
        Me.ssgrid1.DataSource = Nothing
        Me.ssgrid1.Location = New System.Drawing.Point(180, 153)
        Me.ssgrid1.Name = "ssgrid1"
        Me.ssgrid1.OcxState = CType(resources.GetObject("ssgrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid1.Size = New System.Drawing.Size(671, 362)
        Me.ssgrid1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(120, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 32)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "View"
        Me.Button2.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(211, 586)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(520, 56)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(178, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ACCOUNTS TAGGING"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Bengal_MemberMaster.My.Resources.Resources.Clear
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(5, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 50)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Clear[F6]"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmd_update
        '
        Me.cmd_update.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_update.Image = Global.Bengal_MemberMaster.My.Resources.Resources.save
        Me.cmd_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_update.Location = New System.Drawing.Point(5, 93)
        Me.cmd_update.Name = "cmd_update"
        Me.cmd_update.Size = New System.Drawing.Size(137, 50)
        Me.cmd_update.TabIndex = 5
        Me.cmd_update.Text = "Update[F7]"
        Me.cmd_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_update.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.Bengal_MemberMaster.My.Resources.Resources._Exit
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(3, 153)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(137, 50)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Exit[F11]"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.cmd_update)
        Me.GroupBox1.Location = New System.Drawing.Point(860, 208)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(144, 226)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'ACCOUNTSITEMTAGGING
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources._111in1024res
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ssgrid1)
        Me.KeyPreview = True
        Me.Name = "ACCOUNTSITEMTAGGING"
        Me.Text = "ACCOUNTS TAGGING"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ssgrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub ACCOUNTSITEMTAGGING_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F7 Then
            Call cmd_update_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F6 Then
            Call Button1_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            Call Button4_Click(sender, e)
            Exit Sub
        End If
    End Sub

    Private Sub ACCOUNTSITEMTAGGING_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i, j As Integer
        SQLSTRING = "select a.subscode,a.subsdesc,isnull(a.SUBSACCTIN,'') as accode,isnull(b.acdesc,'') as acdesc  from SUBSCRIPTIONMAST a left outer join accountsglaccountmaster b on a.subsacctin=b.accode where isnull(a.freeze,'')<>'Y' and isnull(b.freezeflag,'')<>'Y' order by b.acdesc,a.subscode "
        Vconn.getDataSet(SQLSTRING, "acctag")
        If gdataset.Tables("acctag").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("acctag").Rows.Count - 1
                j = i + 1
                With ssgrid1
                    .Row = j
                    .Col = 1
                    .Text = gdataset.Tables("acctag").Rows(i).Item("subscode")
                    .Col = 2
                    .Text = gdataset.Tables("acctag").Rows(i).Item("subsdesc")
                    .Col = 3
                    .Text = gdataset.Tables("acctag").Rows(i).Item("accode")
                    .Col = 4
                    .Text = gdataset.Tables("acctag").Rows(i).Item("acdesc")
                End With
                ssgrid1.MaxRows = ssgrid1.MaxRows + 1
            Next
        End If
    End Sub
    Private Sub SSMatching_DblClick(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_DblClickEvent) Handles SSMatching.DblClick



    End Sub

   

    Private Sub ssgrid1_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles ssgrid1.Advance

    End Sub

    'Private Sub ssgrid1_DblClick(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_DblClickEvent) Handles ssgrid1.DblClick
    '    Dim ssql As String
    '    Dim itemcode, itemdesc As String

    '    With ssgrid1
    '        .Col = 1
    '        .Row = .ActiveRow
    '        itemcode = .Text
    '        .Col = 2
    '        .Row = .ActiveRow
    '        itemdesc = .Text
    '    End With
    '    SQLSTRING = "select a.itemcode,a.itemdesc ,isnull(a.salesacctin,'') as accode,isnull(b.acdesc,'') as acdesc  from itemmaster a left outer join accountsglaccountmaster b on a.salesacctin=b.accode where isnull(a.freeze,'')<>'Y' and isnull(b.freezeflag,'')<>'Y' order by b.acdesc,a.itemcode "
    '    Vconn.getDataSet(SQLSTRING, "acctag")

    '    If gdataset.Tables("acctag").Rows.Count = 0 Then
    '        Exit Sub
    '    End If
    '    If gdataset.Tables("acctag").Rows.Count > 1 Then
    '        Exit Sub
    '    End If
    'End Sub


    Private Sub ssgrid1_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid1.KeyDownEvent
        With ssgrid1
            If .ActiveCol = 3 Then
                .Row = .ActiveRow
                If .Text = "" Then
                    Call FillMenu()
                End If
            End If
            If .Col = 4 Then
                .Row = .ActiveRow
                If .Text = "" Then
                    'Call FillMenu()
                End If
            End If
        End With
    End Sub
    Private Sub FillMenu()
        Dim vform As New LIST_OPERATION1
        Dim ssql As String
        '''******************************************************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 
        gSQLString = "select accode,acdesc from accountsglaccountmaster "

        'gSQLString = "SELECT DISTINCT I.ITEMCODE,I.ITEMDESC,I.BASERATESTD,I.ITEMTYPECODE,TL.TAXCODE,TL.TAXPERCENTAGE, ISNULL(TL.ACCOUNTCODE,'') "
        'gSQLString = gSQLString & " AS ACCOUNTCODE,ISNULL(I.GROUPCODE,'') AS GROUPCODE,ISNULL(I.OPENFACILITY,'') AS OPENFACILITY,ISNULL(I.SALESACCTIN,'') AS SALESACCTIN FROM VIEW_ITEMMASTER AS I INNER "
        'gSQLString = gSQLString & " JOIN TAXITEMLINK AS TL ON TL.ITEMTYPECODE = I.ITEMTYPECODE "
        If Trim(Search) = " " Then
            M_WhereCondition = "WHERE   category in ('I') and ISNULL(FREEZEFLAG,'') <>'Y'"
        Else
            M_WhereCondition = " WHERE (accode LIKE '%" & Search & "%' OR acdesc LIKE '%" & Search & "%') AND category in ('I') and  ISNULL(FREEZEFLAG,'') <>'Y' "
        End If
        vform.Field = "ACDESC,ACCODE"
        'vform.vFormatstring = "ACCODE     |ACDESC                        "
        vform.vCaption = "ITEM CODE HELP"
        'vform.KeyPos = 0
        'vform.KeyPos1 = 1

        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            With ssgrid1
                .Col = 3
                .Row = .ActiveRow
                .Text = vform.keyfield
                .Col = 4
                .Row = .ActiveRow
                .Text = vform.keyfield1

            End With
        Else
            ssgrid1.SetActiveCell(0, ssgrid1.ActiveRow)
            Exit Sub
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ssgrid1.ClearRange(1, 1, ssgrid1.DataColCnt, ssgrid1.DataRowCnt, False)
        Call ACCOUNTSITEMTAGGING_Load(sender, e)
    End Sub

    Private Sub cmd_update_Click(sender As Object, e As EventArgs) Handles cmd_update.Click
        Dim i As Integer
        Dim itemcd, acccd, ssql As String
        If ssgrid1.DataRowCnt <= 1 Then
            MsgBox("NO RECORD TO SAVE")
            Exit Sub
        End If
        With ssgrid1
            For i = 0 To ssgrid1.DataRowCnt - 1
                .Row = i + 1
                .Col = 1
                itemcd = .Text
                .Col = 3
                acccd = .Text
                ssql = "update subscriptionmast set subsacctin='" & acccd & "' where subscode='" & itemcd & "'"
                Vconn.dataOperation(6, ssql, "item")

            Next
        End With
        MessageBox.Show("Record Saved Successfully", gcompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class
