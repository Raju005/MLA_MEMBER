<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportDesigner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportDesigner))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BUT_EXIT = New System.Windows.Forms.Button()
        Me.BUT_GV_PRINT = New System.Windows.Forms.Button()
        Me.BUT_GEN_VIEW = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CHK_SELECT = New System.Windows.Forms.CheckBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(45, 92)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(562, 201)
        Me.DataGridView1.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(206, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 31)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "REPORT DESIGNER"
        '
        'BUT_EXIT
        '
        Me.BUT_EXIT.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUT_EXIT.ForeColor = System.Drawing.Color.White
        Me.BUT_EXIT.Location = New System.Drawing.Point(569, 438)
        Me.BUT_EXIT.Name = "BUT_EXIT"
        Me.BUT_EXIT.Size = New System.Drawing.Size(131, 37)
        Me.BUT_EXIT.TabIndex = 24
        Me.BUT_EXIT.Text = "Exit"
        Me.BUT_EXIT.UseVisualStyleBackColor = True
        '
        'BUT_GV_PRINT
        '
        Me.BUT_GV_PRINT.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUT_GV_PRINT.ForeColor = System.Drawing.Color.White
        Me.BUT_GV_PRINT.Location = New System.Drawing.Point(400, 438)
        Me.BUT_GV_PRINT.Name = "BUT_GV_PRINT"
        Me.BUT_GV_PRINT.Size = New System.Drawing.Size(131, 37)
        Me.BUT_GV_PRINT.TabIndex = 23
        Me.BUT_GV_PRINT.Text = "Give Print"
        Me.BUT_GV_PRINT.UseVisualStyleBackColor = True
        '
        'BUT_GEN_VIEW
        '
        Me.BUT_GEN_VIEW.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUT_GEN_VIEW.ForeColor = System.Drawing.Color.White
        Me.BUT_GEN_VIEW.Location = New System.Drawing.Point(245, 438)
        Me.BUT_GEN_VIEW.Name = "BUT_GEN_VIEW"
        Me.BUT_GEN_VIEW.Size = New System.Drawing.Size(131, 37)
        Me.BUT_GEN_VIEW.TabIndex = 22
        Me.BUT_GEN_VIEW.Text = "Generate View"
        Me.BUT_GEN_VIEW.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(402, 309)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 37)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Exit [F11]"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(255, 309)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 37)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Give Print [F10]"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(77, 310)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(165, 37)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Generate View[F9]"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CHK_SELECT
        '
        Me.CHK_SELECT.AutoSize = True
        Me.CHK_SELECT.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_SELECT.Location = New System.Drawing.Point(45, 67)
        Me.CHK_SELECT.Name = "CHK_SELECT"
        Me.CHK_SELECT.Size = New System.Drawing.Size(162, 19)
        Me.CHK_SELECT.TabIndex = 28
        Me.CHK_SELECT.Text = "Select/Unselect All [ F2 ]"
        Me.CHK_SELECT.UseVisualStyleBackColor = True
        '
        'ReportDesigner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(686, 392)
        Me.Controls.Add(Me.CHK_SELECT)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BUT_EXIT)
        Me.Controls.Add(Me.BUT_GV_PRINT)
        Me.Controls.Add(Me.BUT_GEN_VIEW)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.KeyPreview = True
        Me.Name = "ReportDesigner"
        Me.Text = "ReportDesigner"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BUT_EXIT As System.Windows.Forms.Button
    Friend WithEvents BUT_GV_PRINT As System.Windows.Forms.Button
    Friend WithEvents BUT_GEN_VIEW As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents CHK_SELECT As System.Windows.Forms.CheckBox
End Class
