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
        Me.btn_play = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.btn_s1 = New System.Windows.Forms.Button()
        Me.pnl_sounds = New System.Windows.Forms.Panel()
        Me.btn_s6 = New System.Windows.Forms.Button()
        Me.btn_s5 = New System.Windows.Forms.Button()
        Me.btn_s4 = New System.Windows.Forms.Button()
        Me.btn_s3 = New System.Windows.Forms.Button()
        Me.btn_s2 = New System.Windows.Forms.Button()
        Me.pnl_sounds.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_play
        '
        Me.btn_play.Location = New System.Drawing.Point(200, 124)
        Me.btn_play.Name = "btn_play"
        Me.btn_play.Size = New System.Drawing.Size(116, 42)
        Me.btn_play.TabIndex = 0
        Me.btn_play.Text = "PLAY"
        Me.btn_play.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(40, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(428, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CIENCIA AL RESCATE"
        '
        'btn_s1
        '
        Me.btn_s1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btn_s1.ForeColor = System.Drawing.Color.White
        Me.btn_s1.Location = New System.Drawing.Point(45, 31)
        Me.btn_s1.Name = "btn_s1"
        Me.btn_s1.Size = New System.Drawing.Size(54, 34)
        Me.btn_s1.TabIndex = 3
        Me.btn_s1.Text = "S1"
        Me.btn_s1.UseVisualStyleBackColor = False
        '
        'pnl_sounds
        '
        Me.pnl_sounds.BackColor = System.Drawing.Color.GreenYellow
        Me.pnl_sounds.Controls.Add(Me.btn_s6)
        Me.pnl_sounds.Controls.Add(Me.btn_s5)
        Me.pnl_sounds.Controls.Add(Me.btn_s4)
        Me.pnl_sounds.Controls.Add(Me.btn_s3)
        Me.pnl_sounds.Controls.Add(Me.btn_s2)
        Me.pnl_sounds.Controls.Add(Me.btn_s1)
        Me.pnl_sounds.Location = New System.Drawing.Point(132, 203)
        Me.pnl_sounds.Name = "pnl_sounds"
        Me.pnl_sounds.Size = New System.Drawing.Size(250, 188)
        Me.pnl_sounds.TabIndex = 4
        Me.pnl_sounds.Visible = False
        '
        'btn_s6
        '
        Me.btn_s6.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.btn_s6.ForeColor = System.Drawing.Color.White
        Me.btn_s6.Location = New System.Drawing.Point(270, 112)
        Me.btn_s6.Name = "btn_s6"
        Me.btn_s6.Size = New System.Drawing.Size(54, 34)
        Me.btn_s6.TabIndex = 8
        Me.btn_s6.Text = "S6"
        Me.btn_s6.UseVisualStyleBackColor = False
        Me.btn_s6.Visible = False
        '
        'btn_s5
        '
        Me.btn_s5.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btn_s5.ForeColor = System.Drawing.Color.White
        Me.btn_s5.Location = New System.Drawing.Point(270, 31)
        Me.btn_s5.Name = "btn_s5"
        Me.btn_s5.Size = New System.Drawing.Size(54, 34)
        Me.btn_s5.TabIndex = 7
        Me.btn_s5.Text = "S5"
        Me.btn_s5.UseVisualStyleBackColor = False
        Me.btn_s5.Visible = False
        '
        'btn_s4
        '
        Me.btn_s4.BackColor = System.Drawing.Color.Indigo
        Me.btn_s4.ForeColor = System.Drawing.Color.White
        Me.btn_s4.Location = New System.Drawing.Point(158, 112)
        Me.btn_s4.Name = "btn_s4"
        Me.btn_s4.Size = New System.Drawing.Size(54, 34)
        Me.btn_s4.TabIndex = 6
        Me.btn_s4.Text = "S4"
        Me.btn_s4.UseVisualStyleBackColor = False
        '
        'btn_s3
        '
        Me.btn_s3.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_s3.ForeColor = System.Drawing.Color.White
        Me.btn_s3.Location = New System.Drawing.Point(45, 112)
        Me.btn_s3.Name = "btn_s3"
        Me.btn_s3.Size = New System.Drawing.Size(54, 34)
        Me.btn_s3.TabIndex = 5
        Me.btn_s3.Text = "S3"
        Me.btn_s3.UseVisualStyleBackColor = False
        '
        'btn_s2
        '
        Me.btn_s2.BackColor = System.Drawing.Color.Maroon
        Me.btn_s2.ForeColor = System.Drawing.Color.White
        Me.btn_s2.Location = New System.Drawing.Point(158, 31)
        Me.btn_s2.Name = "btn_s2"
        Me.btn_s2.Size = New System.Drawing.Size(54, 34)
        Me.btn_s2.TabIndex = 4
        Me.btn_s2.Text = "S2"
        Me.btn_s2.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(505, 459)
        Me.Controls.Add(Me.btn_play)
        Me.Controls.Add(Me.pnl_sounds)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "SOUND FLOOR"
        Me.pnl_sounds.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_play As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents btn_s1 As Button
    Friend WithEvents pnl_sounds As Panel
    Friend WithEvents btn_s6 As Button
    Friend WithEvents btn_s5 As Button
    Friend WithEvents btn_s4 As Button
    Friend WithEvents btn_s3 As Button
    Friend WithEvents btn_s2 As Button
End Class
