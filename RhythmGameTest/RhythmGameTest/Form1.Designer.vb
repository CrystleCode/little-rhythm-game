<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.aBacking = New System.Windows.Forms.PictureBox()
        Me.aButtonSpawn = New System.Windows.Forms.Label()
        Me.moveA = New System.Windows.Forms.Timer(Me.components)
        Me.createATIMER = New System.Windows.Forms.Timer(Me.components)
        Me.dButtonSpawn = New System.Windows.Forms.Label()
        Me.dBacking = New System.Windows.Forms.PictureBox()
        Me.moveD = New System.Windows.Forms.Timer(Me.components)
        Me.createD_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.niceTextA = New System.Windows.Forms.Label()
        Me.failSafeD = New System.Windows.Forms.PictureBox()
        Me.failSafeA = New System.Windows.Forms.PictureBox()
        Me.niceTextD = New System.Windows.Forms.Label()
        Me.scoreText = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.aBacking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dBacking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.failSafeD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.failSafeA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'aBacking
        '
        Me.aBacking.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.aBacking.Location = New System.Drawing.Point(143, 139)
        Me.aBacking.Name = "aBacking"
        Me.aBacking.Size = New System.Drawing.Size(100, 100)
        Me.aBacking.TabIndex = 0
        Me.aBacking.TabStop = False
        '
        'aButtonSpawn
        '
        Me.aButtonSpawn.BackColor = System.Drawing.Color.Red
        Me.aButtonSpawn.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aButtonSpawn.Location = New System.Drawing.Point(143, 404)
        Me.aButtonSpawn.Name = "aButtonSpawn"
        Me.aButtonSpawn.Size = New System.Drawing.Size(100, 100)
        Me.aButtonSpawn.TabIndex = 1
        Me.aButtonSpawn.Tag = "abz"
        Me.aButtonSpawn.Text = "A"
        Me.aButtonSpawn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.aButtonSpawn.Visible = False
        '
        'moveA
        '
        Me.moveA.Interval = 1
        '
        'createATIMER
        '
        Me.createATIMER.Interval = 700
        '
        'dButtonSpawn
        '
        Me.dButtonSpawn.BackColor = System.Drawing.Color.Blue
        Me.dButtonSpawn.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dButtonSpawn.ForeColor = System.Drawing.Color.White
        Me.dButtonSpawn.Location = New System.Drawing.Point(290, 404)
        Me.dButtonSpawn.Name = "dButtonSpawn"
        Me.dButtonSpawn.Size = New System.Drawing.Size(100, 100)
        Me.dButtonSpawn.TabIndex = 3
        Me.dButtonSpawn.Tag = "abz"
        Me.dButtonSpawn.Text = "D"
        Me.dButtonSpawn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.dButtonSpawn.Visible = False
        '
        'dBacking
        '
        Me.dBacking.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dBacking.Location = New System.Drawing.Point(290, 139)
        Me.dBacking.Name = "dBacking"
        Me.dBacking.Size = New System.Drawing.Size(100, 100)
        Me.dBacking.TabIndex = 2
        Me.dBacking.TabStop = False
        '
        'moveD
        '
        Me.moveD.Interval = 1
        '
        'createD_Timer
        '
        Me.createD_Timer.Interval = 800
        '
        'niceTextA
        '
        Me.niceTextA.AutoSize = True
        Me.niceTextA.Location = New System.Drawing.Point(140, 123)
        Me.niceTextA.Name = "niceTextA"
        Me.niceTextA.Size = New System.Drawing.Size(39, 13)
        Me.niceTextA.TabIndex = 4
        Me.niceTextA.Text = "Label1"
        '
        'failSafeD
        '
        Me.failSafeD.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.failSafeD.Location = New System.Drawing.Point(290, 12)
        Me.failSafeD.Name = "failSafeD"
        Me.failSafeD.Size = New System.Drawing.Size(100, 10)
        Me.failSafeD.TabIndex = 5
        Me.failSafeD.TabStop = False
        Me.failSafeD.Visible = False
        '
        'failSafeA
        '
        Me.failSafeA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.failSafeA.Location = New System.Drawing.Point(143, 12)
        Me.failSafeA.Name = "failSafeA"
        Me.failSafeA.Size = New System.Drawing.Size(100, 10)
        Me.failSafeA.TabIndex = 6
        Me.failSafeA.TabStop = False
        Me.failSafeA.Visible = False
        '
        'niceTextD
        '
        Me.niceTextD.Location = New System.Drawing.Point(290, 123)
        Me.niceTextD.Name = "niceTextD"
        Me.niceTextD.Size = New System.Drawing.Size(100, 13)
        Me.niceTextD.TabIndex = 7
        Me.niceTextD.Text = "Label1"
        Me.niceTextD.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'scoreText
        '
        Me.scoreText.AutoSize = True
        Me.scoreText.Location = New System.Drawing.Point(396, 139)
        Me.scoreText.Name = "scoreText"
        Me.scoreText.Size = New System.Drawing.Size(38, 13)
        Me.scoreText.TabIndex = 8
        Me.scoreText.Text = "Score:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(12, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(87, 25)
        Me.label1.TabIndex = 9
        Me.label1.Text = "START!"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 513)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.scoreText)
        Me.Controls.Add(Me.niceTextD)
        Me.Controls.Add(Me.failSafeA)
        Me.Controls.Add(Me.failSafeD)
        Me.Controls.Add(Me.niceTextA)
        Me.Controls.Add(Me.dButtonSpawn)
        Me.Controls.Add(Me.dBacking)
        Me.Controls.Add(Me.aButtonSpawn)
        Me.Controls.Add(Me.aBacking)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.aBacking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dBacking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.failSafeD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.failSafeA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents aBacking As PictureBox
    Friend WithEvents aButtonSpawn As Label
    Friend WithEvents moveA As Timer
    Friend WithEvents createATIMER As Timer
    Friend WithEvents dButtonSpawn As Label
    Friend WithEvents dBacking As PictureBox
    Friend WithEvents moveD As Timer
    Friend WithEvents createD_Timer As Timer
    Friend WithEvents niceTextA As Label
    Friend WithEvents failSafeD As PictureBox
    Friend WithEvents failSafeA As PictureBox
    Friend WithEvents niceTextD As Label
    Friend WithEvents scoreText As Label
    Friend WithEvents label1 As Label
End Class
