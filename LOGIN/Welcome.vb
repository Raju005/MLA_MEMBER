Option Explicit On 

Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class Welcome

    Inherits System.Windows.Forms.Form


    'Private agentctrl As AgentObjects.Agent
    'Private agentchar As AgentObjects.IAgentCtlCharacter

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Welcome))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(208, 368)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 48)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(600, 328)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(264, 32)
        Me.Label2.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(528, 315)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(525, 312)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(54, 54)
        Me.Panel1.TabIndex = 4
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 5000
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(602, 407)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(288, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Loading Your Personal  Rights ....."
        Me.Label3.Visible = False
        '
        'Welcome
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1036, 780)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Welcome"
        Me.Text = "Welcome"
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
        Dim welcomeGrBrush As New LinearGradientBrush( _
               New Point(0, 0), _
               New Point(510, 0), _
               Color.FromArgb(255, 99, 158, 255), _
               Color.FromArgb(1, 15, 92, 244))
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
        'e.Graphics.FillRectangle(welcomeGrBrush, 518, 357, 500, 68)
    End Sub

    Private Sub Welcome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim login As New Form1
        'Label2.Text = gUsername
        'Me.Label3.Visible = False
        'agentctrl = New AgentObjects.Agent
        'With agentctrl
        '    .Connected = True
        '    .Characters.Load("merlin", "merlin.acs")
        '    agentchar = .Characters("merlin")
        'End With
        'With agentchar
        '    .MoveTo(CShort(Me.Location.X + 200), CShort(Me.Location.Y + 200))
        '    .Show()
        '    .Play("Announce")
        '    .Speak("Database Sofware,CLUB MAN")
        'End With
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If PictureBox1.Top < 367 Then
            PictureBox1.Top = PictureBox1.Top + 5
            Label2.Top = Label2.Top + 5
            Panel1.Top = Panel1.Top + 5
        Else
            Timer1.Enabled = False
            Timer2.Enabled = True
            Me.Label3.Visible = True
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim _frmMain As New CompanyList1
        Me.Hide()
        _frmMain.Show()
        Timer2.Enabled = False
        Me.Label3.Visible = False
    End Sub
    Private Sub Welcome_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        'With agentchar
        '    .StopAll()
        '    .Hide()
        'End With
    End Sub
End Class