Public Class Form1
    Dim random As String = 1
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        random += 1
        If random = 10 Then
            random = 1
        End If
    End Sub

    Public Sub PC()
        If random = 1 And Button1.Enabled = True Then
            Button1.Text = TextBox1.Text
            Button1.BackColor = Color.DeepSkyBlue
            Button1.Enabled = False
        End If
        If random = 2 And Button2.Enabled = True Then
            Button2.Text = TextBox1.Text
            Button2.BackColor = Color.DeepSkyBlue
            Button2.Enabled = False
        End If
        If random = 3 And Button3.Enabled = True Then
            Button3.Text = TextBox1.Text
            Button3.BackColor = Color.DeepSkyBlue
            Button3.Enabled = False
        End If
        If random = 4 And Button4.Enabled = True Then
            Button4.Text = TextBox1.Text
            Button4.BackColor = Color.DeepSkyBlue
            Button4.Enabled = False
        End If
        If random = 5 And Button5.Enabled = True Then
            Button5.Text = TextBox1.Text
            Button5.BackColor = Color.DeepSkyBlue
            Button5.Enabled = False
        End If
        If random = 6 And Button6.Enabled = True Then
            Button6.Text = TextBox1.Text
            Button6.BackColor = Color.DeepSkyBlue
            Button6.Enabled = False
        End If
        If random = 7 And Button7.Enabled = True Then
            Button7.Text = TextBox1.Text
            Button7.BackColor = Color.DeepSkyBlue
            Button7.Enabled = False
        End If
        If random = 8 And Button8.Enabled = True Then
            Button8.Text = TextBox1.Text
            Button8.BackColor = Color.DeepSkyBlue
            Button8.Enabled = False
        End If
        If random = 9 And Button9.Enabled = True Then
            Button9.Text = TextBox1.Text
            Button9.BackColor = Color.DeepSkyBlue
            Button9.Enabled = False
        End If
    End Sub
    Public Sub Options()

        'If user hits 1
        If Label1.Text = 1 Then
            If Button2.Text = TextBox2.Text And Button3.Enabled = True Then
                With Button3
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button3.Text = TextBox2.Text And Button2.Enabled = True Then
                With Button2
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button5.Text = TextBox2.Text And Button9.Enabled = True Then
                With Button9
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button9.Text = TextBox2.Text And Button5.Enabled = True Then
                With Button5
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button4.Text = TextBox2.Text And Button7.Enabled = True Then
                With Button7
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button7.Text = TextBox2.Text And Button4.Enabled = True Then
                With Button4
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button8.Text = TextBox2.Text Or Button6.Text = textbox2.text Then
                hit()
            End If

        End If
        'If user hits 2
        If Label1.Text = 2 Then
            If Button1.Text = textbox2.text And Button3.Enabled = True Then
                With Button3
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button1.Text = TextBox2.Text And Button1.Enabled = True Then
                With Button1
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button5.Text = TextBox2.Text And Button8.Enabled = True Then
                With Button8
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button8.Text = TextBox2.Text And Button5.Enabled = True Then
                With Button5
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button6.Text = TextBox2.Text Or Button4.Text = TextBox2.Text Or Button7.Text = textbox2.text Or Button9.Text = textbox2.text Then
                hit()
            End If
        End If
        'If user hits 3
        If Label1.Text = 3 Then
            If Button1.Text = textbox2.text And Button2.Enabled = True Then
                With Button2
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button2.Text = textbox2.text And Button1.Enabled = True Then
                With Button1
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button6.Text = textbox2.text And Button9.Enabled = True Then
                With Button9
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button9.Text = textbox2.text And Button6.Enabled = True Then
                With Button6
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button5.Text = textbox2.text And Button7.Enabled = True Then
                With Button7
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button7.Text = textbox2.text And Button5.Enabled = True Then
                With Button5
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button8.Text = textbox2.text Or Button4.Text = textbox2.text Then
                hit()
            End If
        End If
        'If user hits 4
        If Label1.Text = 4 Then
            If Button1.Text = textbox2.text And Button7.Enabled = True Then
                With Button7
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button7.Text = textbox2.text And Button1.Enabled = True Then
                With Button1
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button5.Text = textbox2.text And Button6.Enabled = True Then
                With Button6
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button6.Text = textbox2.text And Button5.Enabled = True Then
                With Button5
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button2.Text = textbox2.text Or Button3.Text = textbox2.text Or Button8.Text = textbox2.text Or Button9.Text = textbox2.text Then
                hit()
            End If
        End If
        'If user hits 5
        If Label1.Text = 5 Then
            If Button1.Text = textbox2.text And Button9.Enabled = True Then
                With Button9
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button9.Text = textbox2.text And Button1.Enabled = True Then
                With Button1
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button2.Text = textbox2.text And Button8.Enabled = True Then
                With Button8
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button8.Text = textbox2.text And Button2.Enabled = True Then
                With Button2
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button3.Text = textbox2.text And Button7.Enabled = True Then
                With Button7
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button7.Text = textbox2.text And Button3.Enabled = True Then
                With Button3
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button6.Text = textbox2.text And Button4.Enabled = True Then
                With Button4
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button4.Text = textbox2.text And Button6.Enabled = True Then
                With Button6
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            End If
        End If

        'If user hits 6
        If Label1.Text = 6 Then
            If Button3.Text = textbox2.text And Button9.Enabled = True Then
                With Button9
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button9.Text = textbox2.text And Button3.Enabled = True Then
                With Button3
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button5.Text = textbox2.text And Button4.Enabled = True Then
                With Button4
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button4.Text = textbox2.text And Button5.Enabled = True Then
                With Button5
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button1.Text = textbox2.text Or Button2.Text = textbox2.text Or Button7.Text = textbox2.text Or Button8.Text = textbox2.text Then
                hit()
            End If
        End If

        'If user hits 7
        If Label1.Text = 7 Then
            If Button1.Text = textbox2.text And Button4.Enabled = True Then
                With Button4
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button4.Text = textbox2.text And Button1.Enabled = True Then
                With Button1
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button5.Text = textbox2.text And Button3.Enabled = True Then
                With Button3
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button3.Text = textbox2.text And Button5.Enabled = True Then
                With Button5
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button8.Text = textbox2.text And Button9.Enabled = True Then
                With Button9
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button9.Text = textbox2.text And Button8.Enabled = True Then
                With Button8
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button6.Text = textbox2.text Or Button2.Text = textbox2.text Then
                hit()
            End If
        End If

        'If user hits 8
        If Label1.Text = 8 Then
            If Button2.Text = textbox2.text And Button5.Enabled = True Then
                With Button5
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button5.Text = textbox2.text And Button2.Enabled = True Then
                With Button2
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button9.Text = textbox2.text And Button7.Enabled = True Then
                With Button7
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button7.Text = textbox2.text And Button9.Enabled = True Then
                With Button9
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button6.Text = textbox2.text Or Button3.Text = textbox2.text Or Button1.Text = textbox2.text Or Button4.Text = textbox2.text Then
                hit()
            End If
        End If
        'If user hits 9
        If Label1.Text = 9 Then
            If Button6.Text = textbox2.text And Button3.Enabled = True Then
                With Button3
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button3.Text = textbox2.text And Button6.Enabled = True Then
                With Button6
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button5.Text = textbox2.text And Button1.Enabled = True Then
                With Button1
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button1.Text = textbox2.text And Button5.Enabled = True Then
                With Button5
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button8.Text = textbox2.text And Button7.Enabled = True Then
                With Button7
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button7.Text = textbox2.text And Button8.Enabled = True Then
                With Button8
                    .Text = TextBox1.Text
                    .BackColor = Color.DeepSkyBlue
                    .Enabled = False
                End With
            ElseIf Button2.Text = textbox2.text Or Button4.Text = textbox2.text Then
                hit()
            End If
        End If
    End Sub
    Public Sub CheckIfComputerWins()
        If Button1.Text = TextBox1.Text And Button2.Text = TextBox1.Text And Button3.Text = TextBox1.Text _
        Or Button4.Text = TextBox1.Text And Button5.Text = TextBox1.Text And Button6.Text = TextBox1.Text _
        Or Button7.Text = TextBox1.Text And Button8.Text = TextBox1.Text And Button9.Text = TextBox1.Text _
        Or Button1.Text = TextBox1.Text And Button4.Text = TextBox1.Text And Button7.Text = TextBox1.Text _
        Or Button2.Text = TextBox1.Text And Button5.Text = TextBox1.Text And Button8.Text = TextBox1.Text _
        Or Button3.Text = TextBox1.Text And Button6.Text = TextBox1.Text And Button9.Text = TextBox1.Text _
        Or Button1.Text = TextBox1.Text And Button5.Text = TextBox1.Text And Button9.Text = TextBox1.Text _
        Or Button7.Text = TextBox1.Text And Button5.Text = TextBox1.Text And Button3.Text = TextBox1.Text Then
            Won.Text = TextBox3.Text & "فاز"
            ScoreO.text += 1
                Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        ElseIf Button1.Text = textbox2.text And Button2.Text = textbox2.text And Button3.Text = textbox2.text _
        Or Button4.Text = textbox2.text And Button5.Text = textbox2.text And Button6.Text = textbox2.text _
        Or Button7.Text = textbox2.text And Button8.Text = textbox2.text And Button9.Text = textbox2.text _
        Or Button1.Text = textbox2.text And Button4.Text = textbox2.text And Button7.Text = textbox2.text _
        Or Button2.Text = textbox2.text And Button5.Text = textbox2.text And Button8.Text = textbox2.text _
        Or Button3.Text = textbox2.text And Button6.Text = textbox2.text And Button9.Text = textbox2.text _
        Or Button1.Text = textbox2.text And Button5.Text = textbox2.text And Button9.Text = textbox2.text _
        Or Button7.Text = textbox2.text And Button5.Text = textbox2.text And Button3.Text = textbox2.text Then
            Won.Text = TextBox4.Text & "فاز"
            ScoreX.Text += 1
                Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, _
Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click
        sender.Text = "X"
        sender.backcolor = Color.Tomato
        If TextBox2.Text = "X" Then
            sender.backcolor = Color.Tomato
        ElseIf TextBox2.Text = "O" Then
            sender.backcolor = Color.DeepSkyBlue
        End If
        sender.Enabled = False
        Timer1.Stop()
        Label1.Text = sender.name
        Label1.Text = Label1.Text.Replace("Button", "")
        If random = Label1.Text Then
            random = random + 1
        End If
        If random > 0 Then
            PC()
            random = 0
        ElseIf random = 0 Then
            Options()
        End If
        Label2.Text = random
        CheckIfComputerWins()
    End Sub

    Public Sub hit()
        For Each ctl As Control In Me.Controls
            If Label1.Text < 9 Then
                If (ctl.Name.StartsWith("Button" & Label1.Text + 1)) Then
                    Dim btn As Button = DirectCast(ctl, Button)
                    If btn.Enabled = True Then
                        btn.Text = TextBox1.Text
                        btn.BackColor = Color.DeepSkyBlue
                        btn.Enabled = False
                    Else
                        Label1.Text = Label1.Text + 1
                    End If
                End If
            Else
                If (ctl.Name.StartsWith("Button1")) Then
                    Dim btn As Button = DirectCast(ctl, Button)
                    If btn.Enabled = True Then
                        btn.Text = TextBox1.Text
                        btn.BackColor = Color.DeepSkyBlue
                        btn.Enabled = False
                    Else
                        Label1.Text = Label1.Text + 1
                    End If
                End If
            End If
        Next
    End Sub
    Private Sub Re_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Re.Click
        Label2.Text = ""
        Label1.Text = ""
        Button1.Text = ""
        Button1.BackColor = Color.White
        Button1.Enabled = True
        Button2.Text = ""
        Button2.BackColor = Color.White
        Button2.Enabled = True
        Button3.Text = ""
        Button3.BackColor = Color.White
        Button3.Enabled = True
        Button4.Text = ""
        Button4.BackColor = Color.White
        Button4.Enabled = True
        Button5.Text = ""
        Button5.BackColor = Color.White
        Button5.Enabled = True
        Button6.Text = ""
        Button6.BackColor = Color.White
        Button6.Enabled = True
        Button7.Text = ""
        Button7.BackColor = Color.White
        Button7.Enabled = True
        Button8.Text = ""
        Button8.BackColor = Color.White
        Button8.Enabled = True
        Button9.Text = ""
        Button9.BackColor = Color.White
        Button9.Enabled = True
        Timer1.Start()
    End Sub
End Class
