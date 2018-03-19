<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ticketForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ticketForm))
        Me.emailTextBox = New System.Windows.Forms.TextBox()
        Me.idTextBox = New System.Windows.Forms.TextBox()
        Me.nameeTextBox = New System.Windows.Forms.TextBox()
        Me.emailLabel = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.subjectLabel = New System.Windows.Forms.Label()
        Me.subjectTextBox = New System.Windows.Forms.TextBox()
        Me.messageLabel = New System.Windows.Forms.Label()
        Me.messageTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.trayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.closePictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.websitePictureBox = New System.Windows.Forms.PictureBox()
        Me.sendPictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.closePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.websitePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sendPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'emailTextBox
        '
        Me.emailTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.emailTextBox.Location = New System.Drawing.Point(33, 121)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.Size = New System.Drawing.Size(236, 20)
        Me.emailTextBox.TabIndex = 1
        '
        'idTextBox
        '
        Me.idTextBox.Location = New System.Drawing.Point(82, 485)
        Me.idTextBox.Name = "idTextBox"
        Me.idTextBox.Size = New System.Drawing.Size(100, 20)
        Me.idTextBox.TabIndex = 2
        Me.idTextBox.Visible = False
        '
        'nameeTextBox
        '
        Me.nameeTextBox.Location = New System.Drawing.Point(188, 485)
        Me.nameeTextBox.Name = "nameeTextBox"
        Me.nameeTextBox.Size = New System.Drawing.Size(24, 20)
        Me.nameeTextBox.TabIndex = 3
        Me.nameeTextBox.Visible = False
        '
        'emailLabel
        '
        Me.emailLabel.AutoSize = True
        Me.emailLabel.Location = New System.Drawing.Point(33, 103)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(76, 13)
        Me.emailLabel.TabIndex = 4
        Me.emailLabel.Text = "Email Address:"
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(33, 58)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(38, 13)
        Me.nameLabel.TabIndex = 6
        Me.nameLabel.Text = "Name:"
        '
        'nameTextBox
        '
        Me.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nameTextBox.Location = New System.Drawing.Point(33, 76)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(236, 20)
        Me.nameTextBox.TabIndex = 0
        '
        'subjectLabel
        '
        Me.subjectLabel.AutoSize = True
        Me.subjectLabel.Location = New System.Drawing.Point(33, 148)
        Me.subjectLabel.Name = "subjectLabel"
        Me.subjectLabel.Size = New System.Drawing.Size(46, 13)
        Me.subjectLabel.TabIndex = 8
        Me.subjectLabel.Text = "Subject:"
        '
        'subjectTextBox
        '
        Me.subjectTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.subjectTextBox.Location = New System.Drawing.Point(33, 166)
        Me.subjectTextBox.Name = "subjectTextBox"
        Me.subjectTextBox.Size = New System.Drawing.Size(236, 20)
        Me.subjectTextBox.TabIndex = 2
        '
        'messageLabel
        '
        Me.messageLabel.AutoSize = True
        Me.messageLabel.Location = New System.Drawing.Point(33, 193)
        Me.messageLabel.Name = "messageLabel"
        Me.messageLabel.Size = New System.Drawing.Size(63, 13)
        Me.messageLabel.TabIndex = 10
        Me.messageLabel.Text = "Description:"
        '
        'messageTextBox
        '
        Me.messageTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.messageTextBox.Location = New System.Drawing.Point(33, 211)
        Me.messageTextBox.Multiline = True
        Me.messageTextBox.Name = "messageTextBox"
        Me.messageTextBox.Size = New System.Drawing.Size(236, 94)
        Me.messageTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 356)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 83)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "This email address has not been registered"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'trayIcon
        '
        Me.trayIcon.Icon = CType(resources.GetObject("trayIcon.Icon"), System.Drawing.Icon)
        Me.trayIcon.Text = "TrayIcon"
        Me.trayIcon.Visible = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 30)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "KERO Support Agent"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox5, 2, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.emailTextBox, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.nameTextBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.emailLabel, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.messageLabel, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.nameLabel, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.subjectTextBox, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.subjectLabel, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.messageTextBox, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox6, 0, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 11)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 13
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(302, 468)
        Me.TableLayoutPanel1.TabIndex = 17
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PictureBox5.Image = Global.TSSupportAgent.My.Resources.Resources.corner_br_white
        Me.PictureBox5.Location = New System.Drawing.Point(272, 439)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 19
        Me.PictureBox5.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.closePictureBox, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(30, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(242, 30)
        Me.TableLayoutPanel2.TabIndex = 18
        '
        'closePictureBox
        '
        Me.closePictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.closePictureBox.BackgroundImage = Global.TSSupportAgent.My.Resources.Resources.Cancel_96px
        Me.closePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.closePictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.closePictureBox.Location = New System.Drawing.Point(212, 0)
        Me.closePictureBox.Margin = New System.Windows.Forms.Padding(0)
        Me.closePictureBox.Name = "closePictureBox"
        Me.closePictureBox.Size = New System.Drawing.Size(30, 30)
        Me.closePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.closePictureBox.TabIndex = 12
        Me.closePictureBox.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.TSSupportAgent.My.Resources.Resources.corner_tl
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.TSSupportAgent.My.Resources.Resources.corner_tr
        Me.PictureBox2.Location = New System.Drawing.Point(272, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.30387!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.69613!))
        Me.TableLayoutPanel3.Controls.Add(Me.websitePictureBox, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.sendPictureBox, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(33, 311)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(236, 42)
        Me.TableLayoutPanel3.TabIndex = 19
        '
        'websitePictureBox
        '
        Me.websitePictureBox.BackgroundImage = Global.TSSupportAgent.My.Resources.Resources.Globe_96px
        Me.websitePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.websitePictureBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.websitePictureBox.Location = New System.Drawing.Point(201, 3)
        Me.websitePictureBox.Name = "websitePictureBox"
        Me.websitePictureBox.Size = New System.Drawing.Size(32, 36)
        Me.websitePictureBox.TabIndex = 15
        Me.websitePictureBox.TabStop = False
        Me.websitePictureBox.Tag = "Send Ticket"
        '
        'sendPictureBox
        '
        Me.sendPictureBox.BackgroundImage = Global.TSSupportAgent.My.Resources.Resources.Telegram_App_96px
        Me.sendPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sendPictureBox.Location = New System.Drawing.Point(3, 3)
        Me.sendPictureBox.Name = "sendPictureBox"
        Me.sendPictureBox.Size = New System.Drawing.Size(32, 32)
        Me.sendPictureBox.TabIndex = 14
        Me.sendPictureBox.TabStop = False
        Me.sendPictureBox.Tag = "Send Ticket"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PictureBox6.Image = Global.TSSupportAgent.My.Resources.Resources.corner_bl_white
        Me.PictureBox6.Location = New System.Drawing.Point(0, 439)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 20
        Me.PictureBox6.TabStop = False
        '
        'ticketForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(302, 468)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.nameeTextBox)
        Me.Controls.Add(Me.idTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ticketForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Ticket"
        Me.TransparencyKey = System.Drawing.Color.DarkSlateGray
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.closePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.websitePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sendPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents idTextBox As TextBox
    Friend WithEvents nameeTextBox As TextBox
    Friend WithEvents emailLabel As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents subjectLabel As Label
    Friend WithEvents subjectTextBox As TextBox
    Friend WithEvents messageLabel As Label
    Friend WithEvents messageTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents trayIcon As NotifyIcon
    Friend WithEvents sendPictureBox As PictureBox
    Friend WithEvents websitePictureBox As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents closePictureBox As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents PictureBox5 As PictureBox
End Class
