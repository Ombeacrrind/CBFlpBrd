<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFlappyBird
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFlappyBird))
        Me.UpdateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblScore = New System.Windows.Forms.Label()
        Me.imgPause = New System.Windows.Forms.PictureBox()
        Me.imgGround = New System.Windows.Forms.PictureBox()
        Me.imgBird = New System.Windows.Forms.PictureBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.imgPipe1Top = New System.Windows.Forms.PictureBox()
        Me.imgPipe1Bottom = New System.Windows.Forms.PictureBox()
        Me.imgPipe2Top = New System.Windows.Forms.PictureBox()
        Me.imgPipe2Bottom = New System.Windows.Forms.PictureBox()
        Me.imgPipe3Top = New System.Windows.Forms.PictureBox()
        Me.imgPipe3Bottom = New System.Windows.Forms.PictureBox()
        Me.imgPipe4Top = New System.Windows.Forms.PictureBox()
        Me.imgPipe4Bottom = New System.Windows.Forms.PictureBox()
        Me.lblHighScore = New System.Windows.Forms.Label()
        Me.imgDeath = New System.Windows.Forms.PictureBox()
        CType(Me.imgPause, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgBird, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPipe1Top, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPipe1Bottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPipe2Top, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPipe2Bottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPipe3Top, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPipe3Bottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPipe4Top, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPipe4Bottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgDeath, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UpdateTimer
        '
        Me.UpdateTimer.Interval = 25
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Red
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(230, 30)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(25, 26)
        Me.lblScore.TabIndex = 2
        Me.lblScore.Text = "0"
        '
        'imgPause
        '
        Me.imgPause.Image = Global.FlappyBird.My.Resources.Resources.Paused
        Me.imgPause.Location = New System.Drawing.Point(12, 12)
        Me.imgPause.Name = "imgPause"
        Me.imgPause.Size = New System.Drawing.Size(25, 25)
        Me.imgPause.TabIndex = 6
        Me.imgPause.TabStop = False
        '
        'imgGround
        '
        Me.imgGround.Image = Global.FlappyBird.My.Resources.Resources.Ground
        Me.imgGround.Location = New System.Drawing.Point(0, 283)
        Me.imgGround.Name = "imgGround"
        Me.imgGround.Size = New System.Drawing.Size(1000, 20)
        Me.imgGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgGround.TabIndex = 4
        Me.imgGround.TabStop = False
        Me.imgGround.WaitOnLoad = True
        '
        'imgBird
        '
        Me.imgBird.BackColor = System.Drawing.Color.Transparent
        Me.imgBird.Image = Global.FlappyBird.My.Resources.Resources.Bird
        Me.imgBird.Location = New System.Drawing.Point(100, 132)
        Me.imgBird.Name = "imgBird"
        Me.imgBird.Size = New System.Drawing.Size(40, 40)
        Me.imgBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgBird.TabIndex = 1
        Me.imgBird.TabStop = False
        Me.imgBird.WaitOnLoad = True
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.BackColor = System.Drawing.Color.White
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblInstructions.Location = New System.Drawing.Point(31, 87)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(208, 26)
        Me.lblInstructions.TabIndex = 7
        Me.lblInstructions.Text = "Press Space to start"
        '
        'imgPipe1Top
        '
        Me.imgPipe1Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.imgPipe1Top.Image = Global.FlappyBird.My.Resources.Resources.PipeTop
        Me.imgPipe1Top.Location = New System.Drawing.Point(278, -82)
        Me.imgPipe1Top.Name = "imgPipe1Top"
        Me.imgPipe1Top.Size = New System.Drawing.Size(30, 196)
        Me.imgPipe1Top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgPipe1Top.TabIndex = 8
        Me.imgPipe1Top.TabStop = False
        Me.imgPipe1Top.WaitOnLoad = True
        '
        'imgPipe1Bottom
        '
        Me.imgPipe1Bottom.BackColor = System.Drawing.Color.LightGray
        Me.imgPipe1Bottom.Image = Global.FlappyBird.My.Resources.Resources.PipeBottom
        Me.imgPipe1Bottom.Location = New System.Drawing.Point(278, 223)
        Me.imgPipe1Bottom.Name = "imgPipe1Bottom"
        Me.imgPipe1Bottom.Size = New System.Drawing.Size(30, 196)
        Me.imgPipe1Bottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgPipe1Bottom.TabIndex = 8
        Me.imgPipe1Bottom.TabStop = False
        Me.imgPipe1Bottom.WaitOnLoad = True
        '
        'imgPipe2Top
        '
        Me.imgPipe2Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.imgPipe2Top.Image = Global.FlappyBird.My.Resources.Resources.PipeTop
        Me.imgPipe2Top.Location = New System.Drawing.Point(317, -82)
        Me.imgPipe2Top.Name = "imgPipe2Top"
        Me.imgPipe2Top.Size = New System.Drawing.Size(30, 196)
        Me.imgPipe2Top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgPipe2Top.TabIndex = 8
        Me.imgPipe2Top.TabStop = False
        Me.imgPipe2Top.WaitOnLoad = True
        '
        'imgPipe2Bottom
        '
        Me.imgPipe2Bottom.BackColor = System.Drawing.Color.LightGray
        Me.imgPipe2Bottom.Image = Global.FlappyBird.My.Resources.Resources.PipeBottom
        Me.imgPipe2Bottom.Location = New System.Drawing.Point(317, 223)
        Me.imgPipe2Bottom.Name = "imgPipe2Bottom"
        Me.imgPipe2Bottom.Size = New System.Drawing.Size(30, 196)
        Me.imgPipe2Bottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgPipe2Bottom.TabIndex = 8
        Me.imgPipe2Bottom.TabStop = False
        Me.imgPipe2Bottom.WaitOnLoad = True
        '
        'imgPipe3Top
        '
        Me.imgPipe3Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.imgPipe3Top.Image = Global.FlappyBird.My.Resources.Resources.PipeTop
        Me.imgPipe3Top.Location = New System.Drawing.Point(356, -82)
        Me.imgPipe3Top.Name = "imgPipe3Top"
        Me.imgPipe3Top.Size = New System.Drawing.Size(30, 196)
        Me.imgPipe3Top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgPipe3Top.TabIndex = 8
        Me.imgPipe3Top.TabStop = False
        Me.imgPipe3Top.WaitOnLoad = True
        '
        'imgPipe3Bottom
        '
        Me.imgPipe3Bottom.BackColor = System.Drawing.Color.LightGray
        Me.imgPipe3Bottom.Image = Global.FlappyBird.My.Resources.Resources.PipeBottom
        Me.imgPipe3Bottom.Location = New System.Drawing.Point(356, 223)
        Me.imgPipe3Bottom.Name = "imgPipe3Bottom"
        Me.imgPipe3Bottom.Size = New System.Drawing.Size(30, 196)
        Me.imgPipe3Bottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgPipe3Bottom.TabIndex = 8
        Me.imgPipe3Bottom.TabStop = False
        Me.imgPipe3Bottom.WaitOnLoad = True
        '
        'imgPipe4Top
        '
        Me.imgPipe4Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.imgPipe4Top.Image = Global.FlappyBird.My.Resources.Resources.PipeTop
        Me.imgPipe4Top.Location = New System.Drawing.Point(395, -82)
        Me.imgPipe4Top.Name = "imgPipe4Top"
        Me.imgPipe4Top.Size = New System.Drawing.Size(30, 196)
        Me.imgPipe4Top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgPipe4Top.TabIndex = 8
        Me.imgPipe4Top.TabStop = False
        Me.imgPipe4Top.WaitOnLoad = True
        '
        'imgPipe4Bottom
        '
        Me.imgPipe4Bottom.BackColor = System.Drawing.Color.LightGray
        Me.imgPipe4Bottom.Image = Global.FlappyBird.My.Resources.Resources.PipeBottom
        Me.imgPipe4Bottom.Location = New System.Drawing.Point(395, 223)
        Me.imgPipe4Bottom.Name = "imgPipe4Bottom"
        Me.imgPipe4Bottom.Size = New System.Drawing.Size(30, 196)
        Me.imgPipe4Bottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgPipe4Bottom.TabIndex = 8
        Me.imgPipe4Bottom.TabStop = False
        Me.imgPipe4Bottom.WaitOnLoad = True
        '
        'lblHighScore
        '
        Me.lblHighScore.AutoSize = True
        Me.lblHighScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.lblHighScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighScore.Location = New System.Drawing.Point(235, 9)
        Me.lblHighScore.Name = "lblHighScore"
        Me.lblHighScore.Size = New System.Drawing.Size(15, 15)
        Me.lblHighScore.TabIndex = 5
        Me.lblHighScore.Text = "0"
        '
        'imgDeath
        '
        Me.imgDeath.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.imgDeath.Location = New System.Drawing.Point(0, 0)
        Me.imgDeath.Name = "imgDeath"
        Me.imgDeath.Size = New System.Drawing.Size(20, 20)
        Me.imgDeath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.imgDeath.TabIndex = 9
        Me.imgDeath.TabStop = False
        Me.imgDeath.Visible = False
        '
        'frmFlappyBird
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FlappyBird.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(474, 302)
        Me.Controls.Add(Me.lblHighScore)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.imgGround)
        Me.Controls.Add(Me.imgPause)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.imgPipe4Bottom)
        Me.Controls.Add(Me.imgPipe3Bottom)
        Me.Controls.Add(Me.imgPipe2Bottom)
        Me.Controls.Add(Me.imgPipe1Bottom)
        Me.Controls.Add(Me.imgPipe4Top)
        Me.Controls.Add(Me.imgPipe3Top)
        Me.Controls.Add(Me.imgPipe2Top)
        Me.Controls.Add(Me.imgPipe1Top)
        Me.Controls.Add(Me.imgBird)
        Me.Controls.Add(Me.imgDeath)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(490, 340)
        Me.MinimumSize = New System.Drawing.Size(490, 340)
        Me.Name = "frmFlappyBird"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flappy Bird"
        CType(Me.imgPause, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgBird, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPipe1Top, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPipe1Bottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPipe2Top, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPipe2Bottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPipe3Top, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPipe3Bottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPipe4Top, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPipe4Bottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgDeath, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imgBird As System.Windows.Forms.PictureBox
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents imgGround As System.Windows.Forms.PictureBox
    Friend WithEvents imgPause As System.Windows.Forms.PictureBox
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents imgPipe1Top As System.Windows.Forms.PictureBox
    Friend WithEvents imgPipe1Bottom As System.Windows.Forms.PictureBox
    Friend WithEvents imgPipe2Top As System.Windows.Forms.PictureBox
    Friend WithEvents imgPipe2Bottom As System.Windows.Forms.PictureBox
    Friend WithEvents imgPipe3Top As System.Windows.Forms.PictureBox
    Friend WithEvents imgPipe3Bottom As System.Windows.Forms.PictureBox
    Friend WithEvents imgPipe4Top As System.Windows.Forms.PictureBox
    Friend WithEvents imgPipe4Bottom As System.Windows.Forms.PictureBox
    Friend WithEvents lblHighScore As System.Windows.Forms.Label
    Friend WithEvents UpdateTimer As System.Windows.Forms.Timer
    Friend WithEvents imgDeath As System.Windows.Forms.PictureBox

End Class
