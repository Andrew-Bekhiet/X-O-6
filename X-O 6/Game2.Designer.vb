<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game2
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Re = New System.Windows.Forms.Button()
        Me.Won = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.counter = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.TableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.scoore = New System.Windows.Forms.Label()
        Me.ScoreX = New System.Windows.Forms.Label()
        Me.ScoreO = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Naime = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Winner = New System.Windows.Forms.Label()
        Me.Num = New System.Windows.Forms.NumericUpDown()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WWOn = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayout.SuspendLayout()
        CType(Me.Num, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Honeydew
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(284, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 34)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "إختر مَن سيلعب أولًا"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.TextBox1.Location = New System.Drawing.Point(471, 176)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(136, 46)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "إكتب اسم الشخص O"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.TextBox2.Location = New System.Drawing.Point(134, 176)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(136, 46)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = "إكتب اسم الشخص X"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.OrangeRed
        Me.Button12.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button12.Location = New System.Drawing.Point(20, 177)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(98, 73)
        Me.Button12.TabIndex = 14
        Me.Button12.Text = "القائمة"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Re
        '
        Me.Re.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.Re.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Re.Location = New System.Drawing.Point(20, 91)
        Me.Re.Name = "Re"
        Me.Re.Size = New System.Drawing.Size(115, 73)
        Me.Re.TabIndex = 15
        Me.Re.Text = "إعادة / الدرجة"
        Me.Re.UseVisualStyleBackColor = False
        '
        'Won
        '
        Me.Won.BackColor = System.Drawing.Color.Purple
        Me.Won.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.Won.ForeColor = System.Drawing.Color.Yellow
        Me.Won.Location = New System.Drawing.Point(267, 59)
        Me.Won.Name = "Won"
        Me.Won.Size = New System.Drawing.Size(204, 60)
        Me.Won.TabIndex = 13
        Me.Won.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Won.Visible = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(401, 228)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(70, 58)
        Me.Button9.TabIndex = 11
        Me.Button9.UseVisualStyleBackColor = False
        Me.Button9.Visible = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(335, 228)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(70, 58)
        Me.Button8.TabIndex = 12
        Me.Button8.UseVisualStyleBackColor = False
        Me.Button8.Visible = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(268, 228)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(70, 58)
        Me.Button7.TabIndex = 10
        Me.Button7.UseVisualStyleBackColor = False
        Me.Button7.Visible = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(401, 173)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(70, 58)
        Me.Button6.TabIndex = 5
        Me.Button6.UseVisualStyleBackColor = False
        Me.Button6.Visible = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(335, 176)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(70, 55)
        Me.Button5.TabIndex = 4
        Me.Button5.UseVisualStyleBackColor = False
        Me.Button5.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(268, 176)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(70, 55)
        Me.Button4.TabIndex = 6
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(401, 119)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(70, 58)
        Me.Button3.TabIndex = 8
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(335, 119)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 58)
        Me.Button2.TabIndex = 7
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(268, 119)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 58)
        Me.Button1.TabIndex = 9
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'counter
        '
        Me.counter.Location = New System.Drawing.Point(134, 287)
        Me.counter.Multiline = True
        Me.counter.Name = "counter"
        Me.counter.Size = New System.Drawing.Size(78, 60)
        Me.counter.TabIndex = 16
        Me.counter.Visible = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Tomato
        Me.Button10.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.Button10.Location = New System.Drawing.Point(143, 89)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(104, 81)
        Me.Button10.TabIndex = 0
        Me.Button10.Text = "X"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.Label5.Location = New System.Drawing.Point(517, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 36)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "The winner"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.Label6.Location = New System.Drawing.Point(280, 311)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 36)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "الفائز"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(365, 257)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 35)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "الفورة من"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.Tomato
        Me.Button13.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.Button13.Location = New System.Drawing.Point(351, 103)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(104, 81)
        Me.Button13.TabIndex = 0
        Me.Button13.Text = "X"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button11.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.Button11.Location = New System.Drawing.Point(480, 89)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(104, 81)
        Me.Button11.TabIndex = 0
        Me.Button11.Text = "O"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'TableLayout
        '
        Me.TableLayout.ColumnCount = 2
        Me.TableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.69136!))
        Me.TableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.30864!))
        Me.TableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayout.Controls.Add(Me.scoore, 1, 0)
        Me.TableLayout.Controls.Add(Me.ScoreX, 1, 1)
        Me.TableLayout.Controls.Add(Me.ScoreO, 1, 2)
        Me.TableLayout.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayout.Controls.Add(Me.Naime, 0, 0)
        Me.TableLayout.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayout.Location = New System.Drawing.Point(303, 8)
        Me.TableLayout.Name = "TableLayout"
        Me.TableLayout.RowCount = 3
        Me.TableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.43478!))
        Me.TableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.56522!))
        Me.TableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 134.0!))
        Me.TableLayout.Size = New System.Drawing.Size(324, 300)
        Me.TableLayout.TabIndex = 24
        Me.TableLayout.Visible = False
        '
        'scoore
        '
        Me.scoore.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.scoore.Location = New System.Drawing.Point(138, 1)
        Me.scoore.Margin = New System.Windows.Forms.Padding(30, 1, 3, 0)
        Me.scoore.Name = "scoore"
        Me.scoore.Size = New System.Drawing.Size(76, 49)
        Me.scoore.TabIndex = 0
        Me.scoore.Text = "الدرجة"
        Me.scoore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.scoore.Visible = False
        '
        'ScoreX
        '
        Me.ScoreX.BackColor = System.Drawing.Color.Tomato
        Me.ScoreX.ForeColor = System.Drawing.Color.Black
        Me.ScoreX.Location = New System.Drawing.Point(138, 75)
        Me.ScoreX.Margin = New System.Windows.Forms.Padding(50, 25, 3, 0)
        Me.ScoreX.Name = "ScoreX"
        Me.ScoreX.Size = New System.Drawing.Size(56, 50)
        Me.ScoreX.TabIndex = 30
        Me.ScoreX.Text = "0"
        Me.ScoreX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ScoreO
        '
        Me.ScoreO.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ScoreO.ForeColor = System.Drawing.Color.Black
        Me.ScoreO.Location = New System.Drawing.Point(138, 190)
        Me.ScoreO.Margin = New System.Windows.Forms.Padding(50, 25, 3, 0)
        Me.ScoreO.Name = "ScoreO"
        Me.ScoreO.Size = New System.Drawing.Size(56, 50)
        Me.ScoreO.TabIndex = 30
        Me.ScoreO.Text = "0"
        Me.ScoreO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(247, 75)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 25, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 49)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "X"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label3.Visible = False
        '
        'Naime
        '
        Me.Naime.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Naime.Location = New System.Drawing.Point(247, 1)
        Me.Naime.Margin = New System.Windows.Forms.Padding(3, 1, 3, 0)
        Me.Naime.Name = "Naime"
        Me.Naime.Size = New System.Drawing.Size(74, 49)
        Me.Naime.TabIndex = 0
        Me.Naime.Text = "الإسم"
        Me.Naime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Naime.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Blue
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(247, 190)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 25, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 49)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "O"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label4.Visible = False
        '
        'Winner
        '
        Me.Winner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Winner.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.Winner.Location = New System.Drawing.Point(357, 310)
        Me.Winner.Name = "Winner"
        Me.Winner.Size = New System.Drawing.Size(147, 36)
        Me.Winner.TabIndex = 20
        Me.Winner.Visible = False
        '
        'Num
        '
        Me.Num.Location = New System.Drawing.Point(368, 311)
        Me.Num.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Num.Name = "Num"
        Me.Num.Size = New System.Drawing.Size(91, 20)
        Me.Num.TabIndex = 25
        Me.Num.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.DarkCyan
        Me.Button15.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button15.Location = New System.Drawing.Point(20, 12)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(98, 73)
        Me.Button15.TabIndex = 14
        Me.Button15.Text = "القائمة الرئيسية"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label8.Location = New System.Drawing.Point(456, 311)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 47)
        Me.Label8.TabIndex = 27
        Me.Label8.Visible = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Tomato
        Me.Label9.Location = New System.Drawing.Point(456, 365)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 47)
        Me.Label9.TabIndex = 27
        Me.Label9.Visible = False
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(435, 355)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(127, 32)
        Me.Button14.TabIndex = 28
        Me.Button14.Text = "مسح الدرجات"
        Me.Button14.UseVisualStyleBackColor = True
        Me.Button14.Visible = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(545, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 45)
        Me.Label1.TabIndex = 29
        Me.Label1.Visible = False
        '
        'WWOn
        '
        Me.WWOn.Interval = 1
        '
        'Game2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(632, 388)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Re)
        Me.Controls.Add(Me.Won)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TableLayout)
        Me.Controls.Add(Me.counter)
        Me.Controls.Add(Me.Num)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Winner)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.MaximumSize = New System.Drawing.Size(648, 426)
        Me.MinimumSize = New System.Drawing.Size(648, 426)
        Me.Name = "Game2"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "X-O 6"
        Me.TableLayout.ResumeLayout(False)
        CType(Me.Num, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Re As System.Windows.Forms.Button
    Friend WithEvents Won As System.Windows.Forms.Label
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents counter As System.Windows.Forms.TextBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents TableLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Naime As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents scoore As System.Windows.Forms.Label
    Friend WithEvents Winner As System.Windows.Forms.Label
    Friend WithEvents ScoreX As System.Windows.Forms.Label
    Friend WithEvents ScoreO As System.Windows.Forms.Label
    Friend WithEvents Num As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents WWOn As System.Windows.Forms.Timer
End Class

