<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class combotsAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(combotsAdd))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.mainHeader = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.youtubeLabel = New System.Windows.Forms.Label()
        Me.websiteLabel = New System.Windows.Forms.Label()
        Me.twitterHandle = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(323, 391)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Close"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'mainHeader
        '
        Me.mainHeader.AutoSize = True
        Me.mainHeader.Font = New System.Drawing.Font("Forte", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mainHeader.Location = New System.Drawing.Point(119, 9)
        Me.mainHeader.Name = "mainHeader"
        Me.mainHeader.Size = New System.Drawing.Size(496, 32)
        Me.mainHeader.TabIndex = 1
        Me.mainHeader.Text = "THANK YOU FOR DOWNLOADING!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(352, 233)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 281)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Winning alliance at West Virginia State Competition!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(492, 45)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(230, 261)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(649, 309)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Snap Code!"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.youtubeLabel)
        Me.GroupBox1.Controls.Add(Me.websiteLabel)
        Me.GroupBox1.Controls.Add(Me.twitterHandle)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.GroupBox1.Location = New System.Drawing.Point(522, 325)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Other Scoial Media"
        '
        'youtubeLabel
        '
        Me.youtubeLabel.AutoSize = True
        Me.youtubeLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.youtubeLabel.Location = New System.Drawing.Point(6, 71)
        Me.youtubeLabel.Name = "youtubeLabel"
        Me.youtubeLabel.Size = New System.Drawing.Size(54, 13)
        Me.youtubeLabel.TabIndex = 10
        Me.youtubeLabel.Text = "Youtube"
        '
        'websiteLabel
        '
        Me.websiteLabel.AutoSize = True
        Me.websiteLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.websiteLabel.Location = New System.Drawing.Point(6, 49)
        Me.websiteLabel.Name = "websiteLabel"
        Me.websiteLabel.Size = New System.Drawing.Size(53, 13)
        Me.websiteLabel.TabIndex = 9
        Me.websiteLabel.Text = "Website"
        '
        'twitterHandle
        '
        Me.twitterHandle.AutoSize = True
        Me.twitterHandle.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.twitterHandle.Location = New System.Drawing.Point(6, 26)
        Me.twitterHandle.Name = "twitterHandle"
        Me.twitterHandle.Size = New System.Drawing.Size(131, 13)
        Me.twitterHandle.TabIndex = 7
        Me.twitterHandle.Text = "Twitter: @FTC_10547"
        '
        'combotsAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 426)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.mainHeader)
        Me.Controls.Add(Me.btnExit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "combotsAdd"
        Me.Text = "Mortal Combots"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents mainHeader As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents twitterHandle As System.Windows.Forms.Label
    Friend WithEvents websiteLabel As System.Windows.Forms.Label
    Friend WithEvents youtubeLabel As System.Windows.Forms.Label
End Class
