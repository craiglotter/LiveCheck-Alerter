<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Screen
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Screen))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AutoUpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Button1 = New System.Windows.Forms.Button
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LCA_Machines = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.LCA_Emails = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.ActivityLogLink = New System.Windows.Forms.LinkLabel
        Me.ErrorLogLink = New System.Windows.Forms.LinkLabel
        Me.TimerLabel = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.StatusLabel = New System.Windows.Forms.Label
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Label4 = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem1, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(449, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1, Me.AutoUpdateToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'AutoUpdateToolStripMenuItem
        '
        Me.AutoUpdateToolStripMenuItem.Name = "AutoUpdateToolStripMenuItem"
        Me.AutoUpdateToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.AutoUpdateToolStripMenuItem.Text = "AutoUpdate"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(20, 239)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Stop Timer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'LCA_Machines
        '
        Me.LCA_Machines.Location = New System.Drawing.Point(20, 129)
        Me.LCA_Machines.Name = "LCA_Machines"
        Me.LCA_Machines.Size = New System.Drawing.Size(255, 20)
        Me.LCA_Machines.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.LiveCheck_Alerter.My.Resources.Resources.Form_Banner
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(449, 69)
        Me.Panel1.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 29)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "LiveCheck Alerter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Machines to Monitor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Email Addresses to Notify:"
        '
        'LCA_Emails
        '
        Me.LCA_Emails.Location = New System.Drawing.Point(20, 168)
        Me.LCA_Emails.Name = "LCA_Emails"
        Me.LCA_Emails.Size = New System.Drawing.Size(255, 20)
        Me.LCA_Emails.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Location = New System.Drawing.Point(294, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(143, 149)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Machine List"
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(137, 130)
        Me.Panel2.TabIndex = 0
        '
        'ActivityLogLink
        '
        Me.ActivityLogLink.AutoSize = True
        Me.ActivityLogLink.Location = New System.Drawing.Point(147, 244)
        Me.ActivityLogLink.Name = "ActivityLogLink"
        Me.ActivityLogLink.Size = New System.Drawing.Size(67, 13)
        Me.ActivityLogLink.TabIndex = 16
        Me.ActivityLogLink.TabStop = True
        Me.ActivityLogLink.Text = "Activity Logs"
        '
        'ErrorLogLink
        '
        Me.ErrorLogLink.AutoSize = True
        Me.ErrorLogLink.Location = New System.Drawing.Point(220, 244)
        Me.ErrorLogLink.Name = "ErrorLogLink"
        Me.ErrorLogLink.Size = New System.Drawing.Size(55, 13)
        Me.ErrorLogLink.TabIndex = 17
        Me.ErrorLogLink.TabStop = True
        Me.ErrorLogLink.Text = "Error Logs"
        '
        'TimerLabel
        '
        Me.TimerLabel.AutoSize = True
        Me.TimerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimerLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TimerLabel.Location = New System.Drawing.Point(100, 201)
        Me.TimerLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.TimerLabel.Name = "TimerLabel"
        Me.TimerLabel.Size = New System.Drawing.Size(64, 25)
        Me.TimerLabel.TabIndex = 18
        Me.TimerLabel.Text = "0300"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Next LiveCheck:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(189, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Force LiveCheck"
        '
        'StatusLabel
        '
        Me.StatusLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StatusLabel.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.StatusLabel.Location = New System.Drawing.Point(0, 289)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.StatusLabel.Size = New System.Drawing.Size(449, 18)
        Me.StatusLabel.TabIndex = 21
        Me.StatusLabel.Text = "Application Loaded"
        Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(157, 210)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "secs"
        '
        'Main_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 307)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TimerLabel)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ErrorLogLink)
        Me.Controls.Add(Me.ActivityLogLink)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LCA_Emails)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LCA_Machines)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main_Screen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutoUpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LCA_Machines As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LCA_Emails As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ActivityLogLink As System.Windows.Forms.LinkLabel
    Friend WithEvents ErrorLogLink As System.Windows.Forms.LinkLabel
    Friend WithEvents TimerLabel As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
