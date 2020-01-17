<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainActivity
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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.StartInput = New System.Windows.Forms.TextBox()
        Me.Information1 = New System.Windows.Forms.RichTextBox()
        Me.segmentA = New System.Windows.Forms.Button()
        Me.segmentB = New System.Windows.Forms.Button()
        Me.segmentC = New System.Windows.Forms.Button()
        Me.segmentD = New System.Windows.Forms.Button()
        Me.segmentE = New System.Windows.Forms.Button()
        Me.segmentF = New System.Windows.Forms.Button()
        Me.segmentG = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(30, 318)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(100, 30)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(30, 354)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(100, 30)
        Me.btnStop.TabIndex = 2
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(30, 390)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 30)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'StartInput
        '
        Me.StartInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartInput.Location = New System.Drawing.Point(108, 240)
        Me.StartInput.Name = "StartInput"
        Me.StartInput.ShortcutsEnabled = False
        Me.StartInput.Size = New System.Drawing.Size(42, 23)
        Me.StartInput.TabIndex = 4
        '
        'Information1
        '
        Me.Information1.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Information1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Information1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Information1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Information1.Location = New System.Drawing.Point(18, 243)
        Me.Information1.Multiline = False
        Me.Information1.Name = "Information1"
        Me.Information1.ReadOnly = True
        Me.Information1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.Information1.Size = New System.Drawing.Size(74, 20)
        Me.Information1.TabIndex = 5
        Me.Information1.Text = "Start with #"
        '
        'segmentA
        '
        Me.segmentA.BackColor = System.Drawing.Color.White
        Me.segmentA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.segmentA.Enabled = False
        Me.segmentA.FlatAppearance.BorderSize = 0
        Me.segmentA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.segmentA.Location = New System.Drawing.Point(23, 12)
        Me.segmentA.Name = "segmentA"
        Me.segmentA.Size = New System.Drawing.Size(81, 15)
        Me.segmentA.TabIndex = 6
        Me.segmentA.UseVisualStyleBackColor = False
        '
        'segmentB
        '
        Me.segmentB.BackColor = System.Drawing.Color.White
        Me.segmentB.Enabled = False
        Me.segmentB.FlatAppearance.BorderSize = 0
        Me.segmentB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.segmentB.Location = New System.Drawing.Point(107, 12)
        Me.segmentB.Name = "segmentB"
        Me.segmentB.Size = New System.Drawing.Size(15, 81)
        Me.segmentB.TabIndex = 7
        Me.segmentB.UseVisualStyleBackColor = False
        '
        'segmentC
        '
        Me.segmentC.BackColor = System.Drawing.Color.White
        Me.segmentC.Enabled = False
        Me.segmentC.FlatAppearance.BorderSize = 0
        Me.segmentC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.segmentC.Location = New System.Drawing.Point(107, 99)
        Me.segmentC.Name = "segmentC"
        Me.segmentC.Size = New System.Drawing.Size(15, 81)
        Me.segmentC.TabIndex = 8
        Me.segmentC.UseVisualStyleBackColor = False
        '
        'segmentD
        '
        Me.segmentD.BackColor = System.Drawing.Color.White
        Me.segmentD.Enabled = False
        Me.segmentD.FlatAppearance.BorderSize = 0
        Me.segmentD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.segmentD.Location = New System.Drawing.Point(23, 165)
        Me.segmentD.Name = "segmentD"
        Me.segmentD.Size = New System.Drawing.Size(81, 15)
        Me.segmentD.TabIndex = 9
        Me.segmentD.UseVisualStyleBackColor = False
        '
        'segmentE
        '
        Me.segmentE.BackColor = System.Drawing.Color.White
        Me.segmentE.Enabled = False
        Me.segmentE.FlatAppearance.BorderSize = 0
        Me.segmentE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.segmentE.Location = New System.Drawing.Point(5, 99)
        Me.segmentE.Name = "segmentE"
        Me.segmentE.Size = New System.Drawing.Size(15, 81)
        Me.segmentE.TabIndex = 10
        Me.segmentE.UseVisualStyleBackColor = False
        '
        'segmentF
        '
        Me.segmentF.BackColor = System.Drawing.Color.White
        Me.segmentF.Enabled = False
        Me.segmentF.FlatAppearance.BorderSize = 0
        Me.segmentF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.segmentF.Location = New System.Drawing.Point(5, 12)
        Me.segmentF.Name = "segmentF"
        Me.segmentF.Size = New System.Drawing.Size(15, 81)
        Me.segmentF.TabIndex = 11
        Me.segmentF.UseVisualStyleBackColor = False
        '
        'segmentG
        '
        Me.segmentG.BackColor = System.Drawing.Color.White
        Me.segmentG.Enabled = False
        Me.segmentG.FlatAppearance.BorderSize = 0
        Me.segmentG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.segmentG.Location = New System.Drawing.Point(23, 88)
        Me.segmentG.Name = "segmentG"
        Me.segmentG.Size = New System.Drawing.Size(81, 15)
        Me.segmentG.TabIndex = 12
        Me.segmentG.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.segmentA)
        Me.Panel1.Controls.Add(Me.segmentG)
        Me.Panel1.Controls.Add(Me.segmentB)
        Me.Panel1.Controls.Add(Me.segmentF)
        Me.Panel1.Controls.Add(Me.segmentC)
        Me.Panel1.Controls.Add(Me.segmentE)
        Me.Panel1.Controls.Add(Me.segmentD)
        Me.Panel1.Location = New System.Drawing.Point(19, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(126, 190)
        Me.Panel1.TabIndex = 13
        '
        'Timer1
        '
        '
        'MainActivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(164, 441)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Information1)
        Me.Controls.Add(Me.StartInput)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MainActivity"
        Me.Text = "7-Segment Demo(dash)"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents StartInput As TextBox
    Friend WithEvents Information1 As RichTextBox
    Friend WithEvents segmentA As Button
    Friend WithEvents segmentB As Button
    Friend WithEvents segmentC As Button
    Friend WithEvents segmentD As Button
    Friend WithEvents segmentE As Button
    Friend WithEvents segmentF As Button
    Friend WithEvents segmentG As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer1 As Timer
End Class
