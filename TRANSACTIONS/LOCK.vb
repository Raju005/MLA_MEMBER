Public Class LOCK

    Inherits System.Windows.Forms.Form
    Dim Vconn As New GlobalClass
    Dim SQLSTRING As String
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmd_update As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbxMonth As System.Windows.Forms.DateTimePicker
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOCK))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmd_update = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbxMonth = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Label1.Text = "LOCK"
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
        Me.cmd_update.Text = "Lock"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(287, 303)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Lock for the month for"
        '
        'CbxMonth
        '
        Me.CbxMonth.CustomFormat = "MMMMM"
        Me.CbxMonth.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CbxMonth.Location = New System.Drawing.Point(467, 303)
        Me.CbxMonth.Name = "CbxMonth"
        Me.CbxMonth.Size = New System.Drawing.Size(115, 22)
        Me.CbxMonth.TabIndex = 9
        '
        'LOCK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Bengal_MemberMaster.My.Resources.Resources._111in1024res
        Me.ClientSize = New System.Drawing.Size(1008, 596)
        Me.Controls.Add(Me.CbxMonth)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.Name = "LOCK"
        Me.Text = "LOCK"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Private Sub ACCOUNTSITEMTAGGING_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F7 Then
            ' Call cmd_update_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F6 Then
            'Call Button1_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            Call Button4_Click(sender, e)
            Exit Sub
        End If
    End Sub

    Private Sub ACCOUNTSITEMTAGGING_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub
    


    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub cmd_update_Click(sender As Object, e As EventArgs) Handles cmd_update.Click
        Dim cmdText, billdt2 As String
        Dim duedate, membertype, TYPE(0), monthly, sql, sqlstrinG, month2, YEARly As String
        Dim opl, i As Integer
        monthly = Month(Format(CbxMonth.Value, "dd/MMM/yyyy"))
        YEARly = Year(Format(CbxMonth.Value, "dd/MMM/yyyy"))

        If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then month2 = "04" : YEARly = gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month2 = "05" : YEARly = gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month2 = "06" : YEARly = gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month2 = "07" : YEARly = gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month2 = "08" : YEARly = gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month2 = "09" : YEARly = gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month2 = "10" : YEARly = gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month2 = "11" : YEARly = gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month2 = "12" : YEARly = gFinancalyearStart
        If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month2 = "01" : YEARly = gFinancialyearEnd
        If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month2 = "02" : YEARly = gFinancialyearEnd
        If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month2 = "03" : YEARly = gFinancialyearEnd
        sqlstrinG = "SELECT * FROM JOURNALENTRY WHERE VOUCHERTYPE='MBILL' AND ISNULL(VOID,'')<>'Y' AND MONTH(VOUCHERDATE)='" & month2 & "' AND YEAR(VOUCHERDATE)='" & YEARly & "' AND ISNULL(LOCK,'')='Y'"
        gconnection.getDataSet(sqlstrinG, "member")
        If gdataset.Tables("member").Rows.Count > 0 Then
            MessageBox.Show("Month is already locked")
            Exit Sub
        Else
            sqlstrinG = "update journalentry set LOCK='Y' WHERE VOUCHERTYPE='MBILL' AND ISNULL(VOID,'')<>'Y' AND MONTH(VOUCHERDATE)='" & month2 & "' AND YEAR(VOUCHERDATE)=" & YEARly & " "
            gconnection.dataOperation(1, sqlstrinG, "JOURNALENTRY")
            MessageBox.Show("Month is Successfully locked")
        End If
    End Sub
End Class
