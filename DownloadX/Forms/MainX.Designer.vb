<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainX
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
        Me.txUrl = New System.Windows.Forms.TextBox()
        Me.butDL = New System.Windows.Forms.Button()
        Me.gbCreden = New System.Windows.Forms.GroupBox()
        Me.txCredenDomain = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txCredenPass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txCredenUser = New System.Windows.Forms.TextBox()
        Me.chUseCreden = New System.Windows.Forms.CheckBox()
        Me.bgDL = New System.ComponentModel.BackgroundWorker()
        Me.LbStat = New System.Windows.Forms.Label()
        Me.fbBrowse = New System.Windows.Forms.FolderBrowserDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.butClear = New System.Windows.Forms.Button()
        Me.gbCreden.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txUrl
        '
        Me.txUrl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txUrl.BackColor = System.Drawing.Color.White
        Me.txUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txUrl.ForeColor = System.Drawing.Color.Black
        Me.txUrl.Location = New System.Drawing.Point(4, 4)
        Me.txUrl.MaxLength = 65534
        Me.txUrl.Multiline = True
        Me.txUrl.Name = "txUrl"
        Me.txUrl.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txUrl.Size = New System.Drawing.Size(355, 125)
        Me.txUrl.TabIndex = 1
        Me.txUrl.WordWrap = False
        '
        'butDL
        '
        Me.butDL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butDL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butDL.ForeColor = System.Drawing.Color.Green
        Me.butDL.Location = New System.Drawing.Point(365, 4)
        Me.butDL.MinimumSize = New System.Drawing.Size(80, 22)
        Me.butDL.Name = "butDL"
        Me.butDL.Size = New System.Drawing.Size(117, 22)
        Me.butDL.TabIndex = 2
        Me.butDL.Text = "Download!"
        Me.butDL.UseVisualStyleBackColor = True
        '
        'gbCreden
        '
        Me.gbCreden.Controls.Add(Me.txCredenDomain)
        Me.gbCreden.Controls.Add(Me.Label3)
        Me.gbCreden.Controls.Add(Me.Label2)
        Me.gbCreden.Controls.Add(Me.txCredenPass)
        Me.gbCreden.Controls.Add(Me.Label1)
        Me.gbCreden.Controls.Add(Me.txCredenUser)
        Me.gbCreden.Enabled = False
        Me.gbCreden.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbCreden.Location = New System.Drawing.Point(4, 4)
        Me.gbCreden.Name = "gbCreden"
        Me.gbCreden.Size = New System.Drawing.Size(253, 109)
        Me.gbCreden.TabIndex = 3
        Me.gbCreden.TabStop = False
        '
        'txCredenDomain
        '
        Me.txCredenDomain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txCredenDomain.BackColor = System.Drawing.Color.White
        Me.txCredenDomain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txCredenDomain.ForeColor = System.Drawing.Color.Black
        Me.txCredenDomain.Location = New System.Drawing.Point(73, 77)
        Me.txCredenDomain.Name = "txCredenDomain"
        Me.txCredenDomain.Size = New System.Drawing.Size(174, 22)
        Me.txCredenDomain.TabIndex = 7
        Me.txCredenDomain.TabStop = False
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(6, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Domain:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Location = New System.Drawing.Point(6, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txCredenPass
        '
        Me.txCredenPass.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txCredenPass.BackColor = System.Drawing.Color.White
        Me.txCredenPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txCredenPass.ForeColor = System.Drawing.Color.Black
        Me.txCredenPass.Location = New System.Drawing.Point(73, 49)
        Me.txCredenPass.Name = "txCredenPass"
        Me.txCredenPass.Size = New System.Drawing.Size(174, 22)
        Me.txCredenPass.TabIndex = 4
        Me.txCredenPass.TabStop = False
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txCredenUser
        '
        Me.txCredenUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txCredenUser.BackColor = System.Drawing.Color.White
        Me.txCredenUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txCredenUser.ForeColor = System.Drawing.Color.Black
        Me.txCredenUser.Location = New System.Drawing.Point(73, 21)
        Me.txCredenUser.Name = "txCredenUser"
        Me.txCredenUser.Size = New System.Drawing.Size(174, 22)
        Me.txCredenUser.TabIndex = 2
        Me.txCredenUser.TabStop = False
        '
        'chUseCreden
        '
        Me.chUseCreden.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chUseCreden.Location = New System.Drawing.Point(13, 4)
        Me.chUseCreden.Name = "chUseCreden"
        Me.chUseCreden.Size = New System.Drawing.Size(105, 17)
        Me.chUseCreden.TabIndex = 4
        Me.chUseCreden.TabStop = False
        Me.chUseCreden.Text = "Use Credentials"
        Me.chUseCreden.UseVisualStyleBackColor = True
        '
        'bgDL
        '
        '
        'LbStat
        '
        Me.LbStat.AutoEllipsis = True
        Me.LbStat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LbStat.ForeColor = System.Drawing.Color.Gray
        Me.LbStat.Location = New System.Drawing.Point(365, 29)
        Me.LbStat.Name = "LbStat"
        Me.LbStat.Size = New System.Drawing.Size(117, 75)
        Me.LbStat.TabIndex = 6
        Me.LbStat.Text = "Ready!"
        Me.LbStat.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'fbBrowse
        '
        Me.fbBrowse.Description = "Select a folder for bulk download..."
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(1, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(494, 159)
        Me.TabControl1.TabIndex = 7
        Me.TabControl1.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.butClear)
        Me.TabPage1.Controls.Add(Me.txUrl)
        Me.TabPage1.Controls.Add(Me.butDL)
        Me.TabPage1.Controls.Add(Me.LbStat)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabPage1.Size = New System.Drawing.Size(486, 133)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Main"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.chUseCreden)
        Me.TabPage2.Controls.Add(Me.gbCreden)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabPage2.Size = New System.Drawing.Size(486, 133)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Settings"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'butClear
        '
        Me.butClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butClear.ForeColor = System.Drawing.Color.Red
        Me.butClear.Location = New System.Drawing.Point(365, 107)
        Me.butClear.MinimumSize = New System.Drawing.Size(80, 22)
        Me.butClear.Name = "butClear"
        Me.butClear.Size = New System.Drawing.Size(117, 22)
        Me.butClear.TabIndex = 7
        Me.butClear.TabStop = False
        Me.butClear.Text = "Clear"
        Me.butClear.UseVisualStyleBackColor = True
        '
        'MainX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(496, 161)
        Me.Controls.Add(Me.TabControl1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainX"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading..."
        Me.gbCreden.ResumeLayout(False)
        Me.gbCreden.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txUrl As System.Windows.Forms.TextBox
    Friend WithEvents butDL As System.Windows.Forms.Button
    Friend WithEvents gbCreden As System.Windows.Forms.GroupBox
    Friend WithEvents chUseCreden As System.Windows.Forms.CheckBox
    Friend WithEvents bgDL As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txCredenUser As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txCredenPass As System.Windows.Forms.TextBox
    Friend WithEvents txCredenDomain As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LbStat As System.Windows.Forms.Label
    Friend WithEvents fbBrowse As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents butClear As System.Windows.Forms.Button
End Class
