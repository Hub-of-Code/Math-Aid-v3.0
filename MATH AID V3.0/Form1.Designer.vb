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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.EE = New System.Windows.Forms.PictureBox()
        Me.D = New System.Windows.Forms.PictureBox()
        Me.C = New System.Windows.Forms.PictureBox()
        Me.B = New System.Windows.Forms.PictureBox()
        Me.A = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LOADER = New System.Windows.Forms.Timer(Me.components)
        Me.STOPPER = New System.Windows.Forms.Timer(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.EE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.D, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.B, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.A, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EE
        '
        Me.EE.BackColor = System.Drawing.Color.Yellow
        Me.EE.Location = New System.Drawing.Point(774, 509)
        Me.EE.Name = "EE"
        Me.EE.Size = New System.Drawing.Size(34, 33)
        Me.EE.TabIndex = 25
        Me.EE.TabStop = False
        '
        'D
        '
        Me.D.BackColor = System.Drawing.Color.Yellow
        Me.D.Location = New System.Drawing.Point(720, 509)
        Me.D.Name = "D"
        Me.D.Size = New System.Drawing.Size(34, 33)
        Me.D.TabIndex = 24
        Me.D.TabStop = False
        '
        'C
        '
        Me.C.BackColor = System.Drawing.Color.Yellow
        Me.C.Location = New System.Drawing.Point(663, 509)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(34, 33)
        Me.C.TabIndex = 23
        Me.C.TabStop = False
        '
        'B
        '
        Me.B.BackColor = System.Drawing.Color.Yellow
        Me.B.Location = New System.Drawing.Point(608, 509)
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(34, 33)
        Me.B.TabIndex = 22
        Me.B.TabStop = False
        '
        'A
        '
        Me.A.BackColor = System.Drawing.Color.Yellow
        Me.A.Location = New System.Drawing.Point(552, 509)
        Me.A.Name = "A"
        Me.A.Size = New System.Drawing.Size(34, 33)
        Me.A.TabIndex = 21
        Me.A.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-10, -82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1378, 900)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'LOADER
        '
        Me.LOADER.Enabled = True
        Me.LOADER.Interval = 300
        '
        'STOPPER
        '
        Me.STOPPER.Enabled = True
        Me.STOPPER.Interval = 6000
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Conversion of Number Bases", "Sine/Cosine Rule", "Probability", "Standard Deviation/Variance", "Arithmetic Progression"})
        Me.ComboBox1.Location = New System.Drawing.Point(54, 407)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(1245, 43)
        Me.ComboBox1.TabIndex = 27
        Me.ComboBox1.Text = "Conversion Of Number Bases"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Elephant", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 325)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(911, 45)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Choose the Mathematical Operation to Perform:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Algerian", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1025, 540)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(277, 56)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Start Operation"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Stencil", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1358, 63)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(133, 59)
        Me.ToolStripMenuItem1.Text = "     HELP     "
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(148, 59)
        Me.ToolStripMenuItem2.Text = "     ABOUT     "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1358, 737)
        Me.Controls.Add(Me.EE)
        Me.Controls.Add(Me.D)
        Me.Controls.Add(Me.C)
        Me.Controls.Add(Me.B)
        Me.Controls.Add(Me.A)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "MATH AID V3.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.EE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.D, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.B, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.A, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EE As System.Windows.Forms.PictureBox
    Friend WithEvents D As System.Windows.Forms.PictureBox
    Friend WithEvents C As System.Windows.Forms.PictureBox
    Friend WithEvents B As System.Windows.Forms.PictureBox
    Friend WithEvents A As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LOADER As System.Windows.Forms.Timer
    Friend WithEvents STOPPER As System.Windows.Forms.Timer
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem

End Class
