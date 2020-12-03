<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.scorelable = New System.Windows.Forms.Label()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.apple5 = New System.Windows.Forms.PictureBox()
        Me.apple4 = New System.Windows.Forms.PictureBox()
        Me.apple3 = New System.Windows.Forms.PictureBox()
        Me.apple2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.LazerBeam = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5Wall = New System.Windows.Forms.PictureBox()
        Me.PictureBox4Wall = New System.Windows.Forms.PictureBox()
        Me.PictureBox3Wall = New System.Windows.Forms.PictureBox()
        Me.PictureBox2Wall = New System.Windows.Forms.PictureBox()
        Me.Win = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.apple5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.apple4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.apple3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.apple2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LazerBeam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5Wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4Wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3Wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2Wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Win, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 5000
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        '
        'scorelable
        '
        Me.scorelable.AutoSize = True
        Me.scorelable.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.scorelable.Location = New System.Drawing.Point(400, 537)
        Me.scorelable.Name = "scorelable"
        Me.scorelable.Size = New System.Drawing.Size(39, 13)
        Me.scorelable.TabIndex = 15
        Me.scorelable.Text = "Label1"
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        Me.Timer4.Interval = 5000
        '
        'apple5
        '
        Me.apple5.Image = Global.My_Game.My.Resources.Resources.happyappleparent
        Me.apple5.Location = New System.Drawing.Point(97, 329)
        Me.apple5.Name = "apple5"
        Me.apple5.Size = New System.Drawing.Size(44, 50)
        Me.apple5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.apple5.TabIndex = 19
        Me.apple5.TabStop = False
        Me.apple5.Visible = False
        '
        'apple4
        '
        Me.apple4.Image = Global.My_Game.My.Resources.Resources.appleparent
        Me.apple4.Location = New System.Drawing.Point(97, 445)
        Me.apple4.Name = "apple4"
        Me.apple4.Size = New System.Drawing.Size(59, 47)
        Me.apple4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.apple4.TabIndex = 18
        Me.apple4.TabStop = False
        Me.apple4.Visible = False
        '
        'apple3
        '
        Me.apple3.Image = Global.My_Game.My.Resources.Resources.appleparent
        Me.apple3.Location = New System.Drawing.Point(624, 446)
        Me.apple3.Name = "apple3"
        Me.apple3.Size = New System.Drawing.Size(59, 46)
        Me.apple3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.apple3.TabIndex = 17
        Me.apple3.TabStop = False
        Me.apple3.Visible = False
        '
        'apple2
        '
        Me.apple2.Image = Global.My_Game.My.Resources.Resources.appleparent
        Me.apple2.Location = New System.Drawing.Point(624, 84)
        Me.apple2.Name = "apple2"
        Me.apple2.Size = New System.Drawing.Size(59, 48)
        Me.apple2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.apple2.TabIndex = 16
        Me.apple2.TabStop = False
        Me.apple2.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.My_Game.My.Resources.Resources.xokparent
        Me.PictureBox5.Location = New System.Drawing.Point(809, 164)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(38, 39)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 14
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.My_Game.My.Resources.Resources.images__2_
        Me.PictureBox3.Location = New System.Drawing.Point(809, 109)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(38, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.My_Game.My.Resources.Resources.ocramfixed
        Me.PictureBox4.Location = New System.Drawing.Point(809, 62)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(38, 41)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 12
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'LazerBeam
        '
        Me.LazerBeam.Image = Global.My_Game.My.Resources.Resources.lazerbeamactual
        Me.LazerBeam.Location = New System.Drawing.Point(809, 274)
        Me.LazerBeam.Name = "LazerBeam"
        Me.LazerBeam.Size = New System.Drawing.Size(73, 106)
        Me.LazerBeam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LazerBeam.TabIndex = 11
        Me.LazerBeam.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.My_Game.My.Resources.Resources.download_parent
        Me.PictureBox2.Location = New System.Drawing.Point(302, 50)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(207, 133)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox5Wall
        '
        Me.PictureBox5Wall.Image = Global.My_Game.My.Resources.Resources.R10962_image1
        Me.PictureBox5Wall.Location = New System.Drawing.Point(45, 520)
        Me.PictureBox5Wall.Name = "PictureBox5Wall"
        Me.PictureBox5Wall.Size = New System.Drawing.Size(711, 42)
        Me.PictureBox5Wall.TabIndex = 9
        Me.PictureBox5Wall.TabStop = False
        '
        'PictureBox4Wall
        '
        Me.PictureBox4Wall.Image = Global.My_Game.My.Resources.Resources.R10962_image1
        Me.PictureBox4Wall.Location = New System.Drawing.Point(756, 41)
        Me.PictureBox4Wall.Name = "PictureBox4Wall"
        Me.PictureBox4Wall.Size = New System.Drawing.Size(47, 521)
        Me.PictureBox4Wall.TabIndex = 8
        Me.PictureBox4Wall.TabStop = False
        '
        'PictureBox3Wall
        '
        Me.PictureBox3Wall.Image = Global.My_Game.My.Resources.Resources.R10962_image1
        Me.PictureBox3Wall.Location = New System.Drawing.Point(2, 41)
        Me.PictureBox3Wall.Name = "PictureBox3Wall"
        Me.PictureBox3Wall.Size = New System.Drawing.Size(46, 521)
        Me.PictureBox3Wall.TabIndex = 7
        Me.PictureBox3Wall.TabStop = False
        '
        'PictureBox2Wall
        '
        Me.PictureBox2Wall.Image = Global.My_Game.My.Resources.Resources.R10962_image1
        Me.PictureBox2Wall.Location = New System.Drawing.Point(2, 0)
        Me.PictureBox2Wall.Name = "PictureBox2Wall"
        Me.PictureBox2Wall.Size = New System.Drawing.Size(801, 44)
        Me.PictureBox2Wall.TabIndex = 6
        Me.PictureBox2Wall.TabStop = False
        '
        'Win
        '
        Me.Win.Image = Global.My_Game.My.Resources.Resources.appleparent
        Me.Win.Location = New System.Drawing.Point(97, 85)
        Me.Win.Name = "Win"
        Me.Win.Size = New System.Drawing.Size(59, 47)
        Me.Win.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Win.TabIndex = 3
        Me.Win.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.My_Game.My.Resources.Resources.xokopen
        Me.PictureBox1.Location = New System.Drawing.Point(382, 467)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(57, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Timer5
        '
        Me.Timer5.Enabled = True
        Me.Timer5.Interval = 50000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(804, 562)
        Me.Controls.Add(Me.apple5)
        Me.Controls.Add(Me.apple4)
        Me.Controls.Add(Me.apple3)
        Me.Controls.Add(Me.apple2)
        Me.Controls.Add(Me.scorelable)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.LazerBeam)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox5Wall)
        Me.Controls.Add(Me.PictureBox4Wall)
        Me.Controls.Add(Me.PictureBox3Wall)
        Me.Controls.Add(Me.PictureBox2Wall)
        Me.Controls.Add(Me.Win)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form1"
        Me.Text = "a"
        CType(Me.apple5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.apple4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.apple3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.apple2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LazerBeam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5Wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4Wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3Wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2Wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Win, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Win As PictureBox
    Friend WithEvents PictureBox2Wall As PictureBox
    Friend WithEvents PictureBox3Wall As PictureBox
    Friend WithEvents PictureBox4Wall As PictureBox
    Friend WithEvents PictureBox5Wall As PictureBox
    Friend WithEvents Timer3 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LazerBeam As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents scorelable As Label
    Friend WithEvents apple2 As PictureBox
    Friend WithEvents apple3 As PictureBox
    Friend WithEvents apple4 As PictureBox
    Friend WithEvents apple5 As PictureBox
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer5 As Timer
End Class
