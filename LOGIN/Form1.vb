Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Data.SqlClient
Public Class Form1
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtPassWord As System.Windows.Forms.TextBox
    Friend WithEvents TxtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Cbo_Usertype As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.TxtPassWord = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtUserName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Cbo_Usertype = New System.Windows.Forms.ComboBox
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(40, 696)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 24)
        Me.Button1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(80, 704)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Turn off Application"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.TxtPassWord)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TxtUserName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(576, 256)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(288, 112)
        Me.Panel1.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(45, 78)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 24)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Cancel"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(141, 78)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 24)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Login"
        '
        'TxtPassWord
        '
        Me.TxtPassWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPassWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassWord.Location = New System.Drawing.Point(122, 45)
        Me.TxtPassWord.Name = "TxtPassWord"
        Me.TxtPassWord.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassWord.Size = New System.Drawing.Size(120, 22)
        Me.TxtPassWord.TabIndex = 6
        Me.TxtPassWord.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(8, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password"
        '
        'TxtUserName
        '
        Me.TxtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUserName.Location = New System.Drawing.Point(122, 16)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(120, 20)
        Me.TxtUserName.TabIndex = 4
        Me.TxtUserName.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "User Name"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(168, 272)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(320, 184)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Welcome to    ClubMan"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(704, 376)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Invalid User"
        Me.Label5.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(568, 248)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(304, 128)
        Me.Panel2.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(625, 704)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(432, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Copyrights Reserved 2004 by Database Software"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(584, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 19)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Login as :"
        '
        'Cbo_Usertype
        '
        Me.Cbo_Usertype.BackColor = System.Drawing.Color.Wheat
        Me.Cbo_Usertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Usertype.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_Usertype.ForeColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(64, Byte), CType(0, Byte))
        Me.Cbo_Usertype.Items.AddRange(New Object() {"USER", "ADMINISTRATOR"})
        Me.Cbo_Usertype.Location = New System.Drawing.Point(712, 216)
        Me.Cbo_Usertype.Name = "Cbo_Usertype"
        Me.Cbo_Usertype.Size = New System.Drawing.Size(134, 23)
        Me.Cbo_Usertype.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1036, 780)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Cbo_Usertype)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "ClubMan Accounts LogIn"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim rectGrBrush As New LinearGradientBrush( _
               New Point(0, 0), _
               New Point(15, 0), _
               Color.FromArgb(255, 1, 61, 150), _
               Color.FromArgb(255, 1, 61, 150))
        Dim lineGrBrush As New LinearGradientBrush( _
               New Point(0, 0), _
               New Point(15, 0), _
               Color.FromArgb(255, 255, 255, 255), _
               Color.FromArgb(255, 255, 255, 255))
        Dim rectpen As New Pen(rectGrBrush)
        e.Graphics.FillRectangle(rectGrBrush, 0, 0, 1100, 80)
        Dim linepen As New Pen(lineGrBrush)
        e.Graphics.FillRectangle(lineGrBrush, 0, 80, 1100, 2)


        Dim pBrush As New LinearGradientBrush( _
               New Point(0, 0), _
               New Point(1100, 0), _
               Color.FromArgb(200, 99, 158, 248), _
               Color.FromArgb(255, 15, 92, 244))


        Dim path As New GraphicsPath
        e.Graphics.FillRectangle(pBrush, New Rectangle(0, 82, 1100, 600))
        Dim linepen1 As New Pen(lineGrBrush)
        e.Graphics.FillRectangle(lineGrBrush, 0, 680, 1100, 2)
        e.Graphics.FillRectangle(rectGrBrush, 0, 682, 1100, 90)
        e.Graphics.FillRectangle(lineGrBrush, 500, 100, 1, 550)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Trim(TxtUserName.Text) = "" Then
            MsgBox("Pls Provide the user name")
            Me.TxtUserName.Focus()
            Exit Sub
        End If
        If (TxtPassWord.Text = "") Then
            MsgBox("Please enter Password")
            Me.TxtPassWord.Focus()
            Exit Sub
        End If
        Call GetMasterConnection()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TxtUserName.Text = ""
        TxtPassWord.Text = ""
        Label5.Visible = False
        TxtUserName.Focus()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtUserName.Focus()
        AppPath = Application.StartupPath
        Me.Cbo_Usertype.SelectedIndex = 0
        Call GetServer()
        Call GetPrinter()
    End Sub
    Private Sub GetMasterConnection()
        Dim sqlcon As String
        Dim myconn As New SqlConnection
        Dim MyAdp As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Dim sql As String
        If Trim(gserver) <> "" Then
            sqlcon = "Data Source=" & gserver & ";Persist Security Info=False;User ID=sa;Initial Catalog=Master"
        Else
            sqlcon = "Data Source=(Local);Persist Security Info=False;User ID=sa;Initial Catalog=Master"
        End If
        myconn.ConnectionString = sqlcon
        Try
            myconn.Open()

            If Me.Cbo_Usertype.Text = "USER" Then
                sql = "Select * from UserAdmin where username='" & Trim(UCase(TxtUserName.Text)) & "' and userpassword ='" & Trim(GetPass(UCase(TxtPassWord.Text))) & "' and MainGroup='ACCOUNTS' and Category='U'"
            Else
                sql = "Select * from UserAdmin where username='" & Trim(UCase(TxtUserName.Text)) & "' and userpassword ='" & Trim(GetPass(UCase(TxtPassWord.Text))) & "' And Category='S'"
            End If

            MyAdp = New SqlClient.SqlDataAdapter(sql, myconn)
            MyAdp.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                myconn.Close()
                gUsername = TxtUserName.Text
                gUserCategory = ds.Tables(0).Rows(0).Item("Category")
                Dim wel As New Welcome
                Me.Hide()
                wel.Show()
            Else
                MsgBox("Invalid Username Or Password,Pls Contact to Your System Administator")
                Me.TxtPassWord.Text = ""
                Me.TxtPassWord.Focus()
            End If
        Catch ex As Exception
            myconn.Close()
        Finally

        End Try

    End Sub
    Public Sub GetServer()
        Dim ServerConn As New OleDb.OleDbConnection
        Dim servercmd As New OleDb.OleDbDataAdapter
        Dim getserver As New DataSet
        Dim sql, ssql As String
        sql = "Provider=Microsoft.Jet.OLEDB.4.0;Data source="
        sql = sql & AppPath & "\DBS_KEY.MDB"
        ServerConn.ConnectionString = sql
        Try
            ServerConn.Open()
            ssql = "SELECT SERVER FROM DBSKEY"
            servercmd = New OleDb.OleDbDataAdapter(ssql, ServerConn)
            servercmd.Fill(getserver)
            If getserver.Tables(0).Rows.Count > 0 Then
                gserver = Trim(getserver.Tables(0).Rows(0).Item(0) & "")
            Else
                MessageBox.Show("Failed to connect to Data Source")
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to connect to data source")
            MsgBox(ex.Message)
        Finally
            ServerConn.Close()
        End Try
    End Sub
    Public Sub GetPrinter()
        Dim PrinterConn As New OleDb.OleDbConnection
        Dim Printercmd As New OleDb.OleDbDataAdapter
        Dim GetPrinter As New DataSet
        Dim sql, ssql As String
        sql = "Provider=Microsoft.Jet.OLEDB.4.0;Data source="
        sql = sql & AppPath & "\DBS_KEY.MDB"
        PrinterConn.ConnectionString = sql
        Try
            PrinterConn.Open()
            ssql = "SELECT COMPUTERNAME ,PRINTERNAME FROM PrinterSetup"
            Printercmd = New OleDb.OleDbDataAdapter(ssql, PrinterConn)
            Printercmd.Fill(GetPrinter)
            If GetPrinter.Tables(0).Rows.Count > 0 Then
                computername = Trim(GetPrinter.Tables(0).Rows(0).Item(0) & "")
                Printername = Trim(GetPrinter.Tables(0).Rows(0).Item(1) & "")
            Else
                computername = ""
                Printername = ""
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to connect to data source")
            MsgBox(ex.Message)
        Finally
            PrinterConn.Close()
        End Try
    End Sub

    Private Sub TxtPassWord_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPassWord.KeyPress
        If Asc(e.KeyChar) = 13 And Trim(Me.TxtPassWord.Text) <> "" Then
            Me.Button2.Focus()
        End If
    End Sub
    Private Sub TxtUserName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtUserName.KeyPress
        If Asc(e.KeyChar) = 13 And Trim(Me.TxtUserName.Text) <> "" Then
            Me.TxtPassWord.Focus()
        End If
    End Sub
    Private Sub Cbo_Usertype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cbo_Usertype.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.TxtUserName.Focus()
        End If
    End Sub
End Class
