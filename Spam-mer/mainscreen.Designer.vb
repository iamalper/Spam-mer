<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SpamMer
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SpamMer))
        Me.closebutton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.developersbutton = New System.Windows.Forms.Button()
        Me.helpbutton = New System.Windows.Forms.Button()
        Me.rateusbutton = New System.Windows.Forms.Button()
        Me.settingsbutton = New System.Windows.Forms.Button()
        Me.startbutton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.invertalnumetric = New System.Windows.Forms.NumericUpDown()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.feedbacklinklabel = New System.Windows.Forms.LinkLabel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.invertalnumetric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'closebutton
        '
        Me.closebutton.BackgroundImage = CType(resources.GetObject("closebutton.BackgroundImage"), System.Drawing.Image)
        Me.closebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.closebutton.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.closebutton.FlatAppearance.BorderSize = 0
        Me.closebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.closebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closebutton.Location = New System.Drawing.Point(332, 0)
        Me.closebutton.Name = "closebutton"
        Me.closebutton.Size = New System.Drawing.Size(42, 36)
        Me.closebutton.TabIndex = 0
        Me.closebutton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.closebutton)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(377, 40)
        Me.Panel1.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(208, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 26)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "We don't responsible" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      for any abuse!     "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(3, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Spam-Mer"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel2.Controls.Add(Me.developersbutton)
        Me.Panel2.Controls.Add(Me.helpbutton)
        Me.Panel2.Controls.Add(Me.rateusbutton)
        Me.Panel2.Controls.Add(Me.settingsbutton)
        Me.Panel2.Location = New System.Drawing.Point(0, 238)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(377, 88)
        Me.Panel2.TabIndex = 2
        '
        'developersbutton
        '
        Me.developersbutton.BackgroundImage = CType(resources.GetObject("developersbutton.BackgroundImage"), System.Drawing.Image)
        Me.developersbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.developersbutton.FlatAppearance.BorderSize = 0
        Me.developersbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.developersbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.developersbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.developersbutton.Location = New System.Drawing.Point(284, 0)
        Me.developersbutton.Name = "developersbutton"
        Me.developersbutton.Size = New System.Drawing.Size(93, 88)
        Me.developersbutton.TabIndex = 5
        Me.developersbutton.TabStop = False
        Me.developersbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.developersbutton.UseVisualStyleBackColor = True
        '
        'helpbutton
        '
        Me.helpbutton.BackgroundImage = CType(resources.GetObject("helpbutton.BackgroundImage"), System.Drawing.Image)
        Me.helpbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.helpbutton.FlatAppearance.BorderSize = 0
        Me.helpbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.helpbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.helpbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.helpbutton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.helpbutton.Location = New System.Drawing.Point(90, 0)
        Me.helpbutton.Name = "helpbutton"
        Me.helpbutton.Size = New System.Drawing.Size(93, 88)
        Me.helpbutton.TabIndex = 3
        Me.helpbutton.TabStop = False
        Me.helpbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.helpbutton.UseVisualStyleBackColor = True
        '
        'rateusbutton
        '
        Me.rateusbutton.BackgroundImage = CType(resources.GetObject("rateusbutton.BackgroundImage"), System.Drawing.Image)
        Me.rateusbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.rateusbutton.FlatAppearance.BorderSize = 0
        Me.rateusbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.rateusbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.rateusbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rateusbutton.Location = New System.Drawing.Point(189, 0)
        Me.rateusbutton.Name = "rateusbutton"
        Me.rateusbutton.Size = New System.Drawing.Size(93, 88)
        Me.rateusbutton.TabIndex = 4
        Me.rateusbutton.TabStop = False
        Me.rateusbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.rateusbutton.UseVisualStyleBackColor = True
        '
        'settingsbutton
        '
        Me.settingsbutton.BackgroundImage = CType(resources.GetObject("settingsbutton.BackgroundImage"), System.Drawing.Image)
        Me.settingsbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.settingsbutton.FlatAppearance.BorderSize = 0
        Me.settingsbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.settingsbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.settingsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.settingsbutton.Location = New System.Drawing.Point(0, 0)
        Me.settingsbutton.Name = "settingsbutton"
        Me.settingsbutton.Size = New System.Drawing.Size(93, 88)
        Me.settingsbutton.TabIndex = 0
        Me.settingsbutton.TabStop = False
        Me.settingsbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.settingsbutton.UseVisualStyleBackColor = True
        '
        'startbutton
        '
        Me.startbutton.Location = New System.Drawing.Point(78, 177)
        Me.startbutton.Name = "startbutton"
        Me.startbutton.Size = New System.Drawing.Size(204, 43)
        Me.startbutton.TabIndex = 3
        Me.startbutton.Text = "Start"
        Me.startbutton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(75, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Invertal seconds ="
        '
        'invertalnumetric
        '
        Me.invertalnumetric.Location = New System.Drawing.Point(177, 77)
        Me.invertalnumetric.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.invertalnumetric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.invertalnumetric.Name = "invertalnumetric"
        Me.invertalnumetric.Size = New System.Drawing.Size(62, 20)
        Me.invertalnumetric.TabIndex = 11
        Me.invertalnumetric.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'Timer1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Send random messages to active app"
        '
        'feedbacklinklabel
        '
        Me.feedbacklinklabel.AutoSize = True
        Me.feedbacklinklabel.Location = New System.Drawing.Point(313, 222)
        Me.feedbacklinklabel.Name = "feedbacklinklabel"
        Me.feedbacklinklabel.Size = New System.Drawing.Size(61, 13)
        Me.feedbacklinklabel.TabIndex = 6
        Me.feedbacklinklabel.TabStop = True
        Me.feedbacklinklabel.Text = "!Feedback!"
        '
        'SpamMer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(378, 326)
        Me.Controls.Add(Me.feedbacklinklabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.invertalnumetric)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.startbutton)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SpamMer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spam-mer"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.invertalnumetric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents closebutton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents settingsbutton As Button
    Friend WithEvents helpbutton As Button
    Friend WithEvents developersbutton As Button
    Friend WithEvents rateusbutton As Button
    Friend WithEvents startbutton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents invertalnumetric As NumericUpDown
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents feedbacklinklabel As LinkLabel
End Class
