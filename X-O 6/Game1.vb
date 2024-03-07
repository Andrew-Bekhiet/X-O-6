Public Class Game1
    Dim random As String = 1

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        MainMenu.Show()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, _
Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click
        If Button1.Text = TextBox1.Text And Button2.Text = TextBox1.Text And Button3.Text = TextBox1.Text _
            Or Button4.Text = TextBox1.Text And Button5.Text = TextBox1.Text And Button6.Text = TextBox1.Text _
            Or Button7.Text = TextBox1.Text And Button8.Text = TextBox1.Text And Button9.Text = TextBox1.Text _
            Or Button1.Text = TextBox1.Text And Button4.Text = TextBox1.Text And Button7.Text = TextBox1.Text _
            Or Button2.Text = TextBox1.Text And Button5.Text = TextBox1.Text And Button8.Text = TextBox1.Text _
            Or Button3.Text = TextBox1.Text And Button6.Text = TextBox1.Text And Button9.Text = TextBox1.Text _
            Or Button1.Text = TextBox1.Text And Button5.Text = TextBox1.Text And Button9.Text = TextBox1.Text _
            Or Button7.Text = TextBox1.Text And Button5.Text = TextBox1.Text And Button3.Text = TextBox1.Text _
        Or Button1.Text = TextBox2.Text And Button2.Text = TextBox2.Text And Button3.Text = TextBox2.Text _
Or Button4.Text = TextBox2.Text And Button5.Text = TextBox2.Text And Button6.Text = TextBox2.Text _
Or Button7.Text = TextBox2.Text And Button8.Text = TextBox2.Text And Button9.Text = TextBox2.Text _
Or Button1.Text = TextBox2.Text And Button4.Text = TextBox2.Text And Button7.Text = TextBox2.Text _
Or Button2.Text = TextBox2.Text And Button5.Text = TextBox2.Text And Button8.Text = TextBox2.Text _
Or Button3.Text = TextBox2.Text And Button6.Text = TextBox2.Text And Button9.Text = TextBox2.Text _
Or Button1.Text = TextBox2.Text And Button5.Text = TextBox2.Text And Button9.Text = TextBox2.Text _
Or Button7.Text = TextBox2.Text And Button5.Text = TextBox2.Text And Button3.Text = TextBox2.Text Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button9.Enabled = False
        Else
            sender.text = Dialog1.TextBox2.Text
            If Dialog1.TextBox2.Text = "X" Then
                sender.backcolor = Label9.BackColor
            ElseIf Dialog1.TextBox2.Text = "O" Then
                sender.backcolor = Label8.BackColor
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
        End If
    End Sub
    Private Sub Won_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Won.TextChanged
        If Won.Text = TextBox2.Text + "فاز" Then
            ScoreX.Text += 1
        ElseIf Won.Text = TextBox1.Text + "فاز" Then
            ScoreO.Text += 1
        ElseIf ScoreX.Text = Num.Text Then
            Winner.Text = TextBox4.Text
            Winner.Show()
            Button1.Hide()
            Button2.Hide()
            Button3.Hide()
            Button4.Hide()
            Button5.Hide()
            Button6.Hide()
            Button7.Hide()
            Button8.Hide()
            Button9.Hide()
            Button10.Show()
            TextBox1.Hide()
            TextBox2.Hide()
            TableLayout.Show()
            Label5.Show()
            Label6.Show()
            Label3.Show()
            Label4.Show()
            Naime.Show()
            scoore.Show()
            Won.Hide()
            Label7.Hide()
            Num.Hide()
            Del.Show()
        ElseIf ScoreO.Text = Num.Text Then
            Winner.Text = TextBox3.Text
            Winner.Show()
            Button1.Hide()
            Button2.Hide()
            Button3.Hide()
            Button4.Hide()
            Button5.Hide()
            Button6.Hide()
            Button7.Hide()
            Button8.Hide()
            Button9.Hide()
            Button10.Show()
            TextBox1.Hide()
            TextBox2.Hide()
            TableLayout.Show()
            Label5.Show()
            Label6.Show()
            Label3.Show()
            Label4.Show()
            Naime.Show()
            scoore.Show()
            Won.Hide()
            Label7.Hide()
            Num.Hide()
            Del.Show()
        End If
    End Sub

    Private Sub Form4_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            Game.Hide()
            MainMenu.Hide()
        ElseIf Me.Visible = False Then
            MainMenu.Show()
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        WWon.Enabled = False
        Won.Text = ""
        Button1.Show()
        Button2.Show()
        Button3.Show()
        Button4.Show()
        Button5.Show()
        Button6.Show()
        Button7.Show()
        Button8.Show()
        Button9.Show()
        TableLayout.Hide()
        Label5.Hide()
        Label6.Hide()
        Winner.Hide()
        Label7.Show()
        Num.Show()
        Button10.Hide()
        Del.Hide()
        Button11.Enabled = True
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        random += 1
        If random = 10 Then
            random = 1
        End If
    End Sub

    Public Sub PC()
        If Button1.Text = TextBox1.Text And Button2.Text = TextBox1.Text And Button3.Text = TextBox1.Text _
            Or Button4.Text = TextBox1.Text And Button5.Text = TextBox1.Text And Button6.Text = TextBox1.Text _
            Or Button7.Text = TextBox1.Text And Button8.Text = TextBox1.Text And Button9.Text = TextBox1.Text _
            Or Button1.Text = TextBox1.Text And Button4.Text = TextBox1.Text And Button7.Text = TextBox1.Text _
            Or Button2.Text = TextBox1.Text And Button5.Text = TextBox1.Text And Button8.Text = TextBox1.Text _
            Or Button3.Text = TextBox1.Text And Button6.Text = TextBox1.Text And Button9.Text = TextBox1.Text _
            Or Button1.Text = TextBox1.Text And Button5.Text = TextBox1.Text And Button9.Text = TextBox1.Text _
            Or Button7.Text = TextBox1.Text And Button5.Text = TextBox1.Text And Button3.Text = TextBox1.Text _
        Or Button1.Text = TextBox2.Text And Button2.Text = TextBox2.Text And Button3.Text = TextBox2.Text _
Or Button4.Text = TextBox2.Text And Button5.Text = TextBox2.Text And Button6.Text = TextBox2.Text _
Or Button7.Text = TextBox2.Text And Button8.Text = TextBox2.Text And Button9.Text = TextBox2.Text _
Or Button1.Text = TextBox2.Text And Button4.Text = TextBox2.Text And Button7.Text = TextBox2.Text _
Or Button2.Text = TextBox2.Text And Button5.Text = TextBox2.Text And Button8.Text = TextBox2.Text _
Or Button3.Text = TextBox2.Text And Button6.Text = TextBox2.Text And Button9.Text = TextBox2.Text _
Or Button1.Text = TextBox2.Text And Button5.Text = TextBox2.Text And Button9.Text = TextBox2.Text _
Or Button7.Text = TextBox2.Text And Button5.Text = TextBox2.Text And Button3.Text = TextBox2.Text Then
        Else
            If random = 1 And Button1.Enabled = True Then
                If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                    Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                    Button1.Text = "X"
                    Button1.BackColor = Label9.BackColor
                ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                    Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                    Button1.Text = "O"
                    Button1.BackColor = Label8.BackColor
                End If
                Button1.Enabled = False
            End If
            If random = 2 And Button2.Enabled = True Then
                If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                      Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                    Button2.Text = "X"
                    Button2.BackColor = Label9.BackColor
                ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                    Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                    Button2.Text = "O"
                    Button2.BackColor = Label8.BackColor
                End If
                Button2.Enabled = False
            End If
            If random = 3 And Button3.Enabled = True Then
                If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                    Button3.Text = "X"
                    Button3.BackColor = Label9.BackColor
                ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                    Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                    Button3.Text = "O"
                    Button3.BackColor = Label8.BackColor
                End If
                Button3.Enabled = False
            End If
            If random = 4 And Button4.Enabled = True Then
                If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                  Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                    Button4.Text = "X"
                    Button4.BackColor = Label9.BackColor
                ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                    Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                    Button4.Text = "O"
                    Button4.BackColor = Label8.BackColor
                End If
                Button4.Enabled = False
            End If
            If random = 5 And Button5.Enabled = True Then
                If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                      Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                    Button5.Text = "X"
                    Button5.BackColor = Label9.BackColor
                ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                    Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                    Button5.Text = "O"
                    Button5.BackColor = Label8.BackColor
                End If
                Button5.Enabled = False
            End If
            If random = 6 And Button6.Enabled = True Then
                If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                          Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                    Button6.Text = "X"
                    Button6.BackColor = Label9.BackColor
                ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                    Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                    Button6.Text = "O"
                    Button6.BackColor = Label8.BackColor
                End If
                Button6.Enabled = False
            End If
            If random = 7 And Button7.Enabled = True Then
                If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                         Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                    Button7.Text = "X"
                    Button7.BackColor = Label9.BackColor
                ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                    Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                    Button7.Text = "O"
                    Button7.BackColor = Label8.BackColor
                End If
                Button7.Enabled = False
            End If
            If random = 8 And Button8.Enabled = True Then
                If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                         Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                    Button8.Text = "X"
                    Button8.BackColor = Label9.BackColor
                ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                    Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                    Button8.Text = "O"
                    Button8.BackColor = Label8.BackColor
                End If
                Button8.Enabled = False
            End If
            If random = 9 And Button9.Enabled = True Then
                If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                    Button9.Text = "X"
                    Button9.BackColor = Label9.BackColor
                ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                    Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                    Button9.Text = "O"
                    Button9.BackColor = Label8.BackColor
                End If
                Button9.Enabled = False
            End If
        End If
    End Sub
    Public Sub Options()
        If Button1.Text = TextBox1.Text And Button2.Text = TextBox1.Text And Button3.Text = TextBox1.Text _
            Or Button4.Text = TextBox1.Text And Button5.Text = TextBox1.Text And Button6.Text = TextBox1.Text _
            Or Button7.Text = TextBox1.Text And Button8.Text = TextBox1.Text And Button9.Text = TextBox1.Text _
            Or Button1.Text = TextBox1.Text And Button4.Text = TextBox1.Text And Button7.Text = TextBox1.Text _
            Or Button2.Text = TextBox1.Text And Button5.Text = TextBox1.Text And Button8.Text = TextBox1.Text _
            Or Button3.Text = TextBox1.Text And Button6.Text = TextBox1.Text And Button9.Text = TextBox1.Text _
            Or Button1.Text = TextBox1.Text And Button5.Text = TextBox1.Text And Button9.Text = TextBox1.Text _
            Or Button7.Text = TextBox1.Text And Button5.Text = TextBox1.Text And Button3.Text = TextBox1.Text _
        Or Button1.Text = TextBox2.Text And Button2.Text = TextBox2.Text And Button3.Text = TextBox2.Text _
Or Button4.Text = TextBox2.Text And Button5.Text = TextBox2.Text And Button6.Text = TextBox2.Text _
Or Button7.Text = TextBox2.Text And Button8.Text = TextBox2.Text And Button9.Text = TextBox2.Text _
Or Button1.Text = TextBox2.Text And Button4.Text = TextBox2.Text And Button7.Text = TextBox2.Text _
Or Button2.Text = TextBox2.Text And Button5.Text = TextBox2.Text And Button8.Text = TextBox2.Text _
Or Button3.Text = TextBox2.Text And Button6.Text = TextBox2.Text And Button9.Text = TextBox2.Text _
Or Button1.Text = TextBox2.Text And Button5.Text = TextBox2.Text And Button9.Text = TextBox2.Text _
Or Button7.Text = TextBox2.Text And Button5.Text = TextBox2.Text And Button3.Text = TextBox2.Text Then
        Else

            'If user hits 1
            If Label1.Text = 1 Then
                If Button2.Text = Dialog1.TextBox2.Text And Button3.Enabled = True Then
                    With Button3
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                  Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button3.Text = Dialog1.TextBox2.Text And Button2.Enabled = True Then
                    With Button2
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                 Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button5.Text = Dialog1.TextBox2.Text And Button9.Enabled = True Then
                    With Button9
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                   Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button9.Text = Dialog1.TextBox2.Text And Button5.Enabled = True Then
                    With Button5
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                 Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button4.Text = Dialog1.TextBox2.Text And Button7.Enabled = True Then
                    With Button7
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                 Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button7.Text = Dialog1.TextBox2.Text And Button4.Enabled = True Then
                    With Button4
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                 Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button8.Text = Dialog1.TextBox2.Text Or Button6.Text = Dialog1.TextBox2.Text Then
                    hit()
                End If

            End If
            'If user hits 2
            If Label1.Text = 2 Then
                If Button1.Text = Dialog1.TextBox2.Text And Button3.Enabled = True Then
                    With Button3
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                 Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button1.Text = Dialog1.TextBox2.Text And Button1.Enabled = True Then
                    With Button1
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                  Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button5.Text = Dialog1.TextBox2.Text And Button8.Enabled = True Then
                    With Button8
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                   Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button8.Text = Dialog1.TextBox2.Text And Button5.Enabled = True Then
                    With Button5
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                  Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button6.Text = Dialog1.TextBox2.Text Or Button4.Text = Dialog1.TextBox2.Text Or Button7.Text = Dialog1.TextBox2.Text Or Button9.Text = Dialog1.TextBox2.Text Then
                    hit()
                End If
            End If
            'If user hits 3
            If Label1.Text = 3 Then
                If Button1.Text = Dialog1.TextBox2.Text And Button2.Enabled = True Then
                    With Button2
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                   Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button2.Text = Dialog1.TextBox2.Text And Button1.Enabled = True Then
                    With Button1
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                 Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button6.Text = Dialog1.TextBox2.Text And Button9.Enabled = True Then
                    With Button9
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                  Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button9.Text = Dialog1.TextBox2.Text And Button6.Enabled = True Then
                    With Button6
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                  Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button5.Text = Dialog1.TextBox2.Text And Button7.Enabled = True Then
                    With Button7
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                  Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button7.Text = Dialog1.TextBox2.Text And Button5.Enabled = True Then
                    With Button5
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                 Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button8.Text = Dialog1.TextBox2.Text Or Button4.Text = Dialog1.TextBox2.Text Then
                    hit()
                End If
            End If
            'If user hits 4
            If Label1.Text = 4 Then
                If Button1.Text = Dialog1.TextBox2.Text And Button7.Enabled = True Then
                    With Button7
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                  Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button7.Text = Dialog1.TextBox2.Text And Button1.Enabled = True Then
                    With Button1
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                 Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button5.Text = Dialog1.TextBox2.Text And Button6.Enabled = True Then
                    With Button6
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                  Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button6.Text = Dialog1.TextBox2.Text And Button5.Enabled = True Then
                    With Button5
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                  Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button2.Text = Dialog1.TextBox2.Text Or Button3.Text = Dialog1.TextBox2.Text Or Button8.Text = Dialog1.TextBox2.Text Or Button9.Text = Dialog1.TextBox2.Text Then
                    hit()
                End If
            End If
            'If user hits 5
            If Label1.Text = 5 Then
                If Button1.Text = Dialog1.TextBox2.Text And Button9.Enabled = True Then
                    With Button9
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                 Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button9.Text = Dialog1.TextBox2.Text And Button1.Enabled = True Then
                    With Button1
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                 Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button2.Text = Dialog1.TextBox2.Text And Button8.Enabled = True Then
                    With Button8
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                   Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button8.Text = Dialog1.TextBox2.Text And Button2.Enabled = True Then
                    With Button2
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                  Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button3.Text = Dialog1.TextBox2.Text And Button7.Enabled = True Then
                    With Button7
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                   Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button7.Text = Dialog1.TextBox2.Text And Button3.Enabled = True Then
                    With Button3
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                    Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button6.Text = Dialog1.TextBox2.Text And Button4.Enabled = True Then
                    With Button4
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                  Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button4.Text = Dialog1.TextBox2.Text And Button6.Enabled = True Then
                    With Button6
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                  Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                End If
            End If

            'If user hits 6
            If Label1.Text = 6 Then
                If Button3.Text = Dialog1.TextBox2.Text And Button9.Enabled = True Then
                    With Button9
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                   Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button9.Text = Dialog1.TextBox2.Text And Button3.Enabled = True Then
                    With Button3
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                 Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button5.Text = Dialog1.TextBox2.Text And Button4.Enabled = True Then
                    With Button4
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                 Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button4.Text = Dialog1.TextBox2.Text And Button5.Enabled = True Then
                    With Button5
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                 Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button1.Text = Dialog1.TextBox2.Text Or Button2.Text = Dialog1.TextBox2.Text Or Button7.Text = Dialog1.TextBox2.Text Or Button8.Text = Dialog1.TextBox2.Text Then
                    hit()
                End If
            End If

            'If user hits 7
            If Label1.Text = 7 Then
                If Button1.Text = Dialog1.TextBox2.Text And Button4.Enabled = True Then
                    With Button4
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                  Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button4.Text = Dialog1.TextBox2.Text And Button1.Enabled = True Then
                    With Button1
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                   Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button5.Text = Dialog1.TextBox2.Text And Button3.Enabled = True Then
                    With Button3
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                  Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button3.Text = Dialog1.TextBox2.Text And Button5.Enabled = True Then
                    With Button5
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                 Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button8.Text = Dialog1.TextBox2.Text And Button9.Enabled = True Then
                    With Button9
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                  Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button9.Text = Dialog1.TextBox2.Text And Button8.Enabled = True Then
                    With Button8
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                  Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button6.Text = Dialog1.TextBox2.Text Or Button2.Text = Dialog1.TextBox2.Text Then
                    hit()
                End If
            End If

            'If user hits 8
            If Label1.Text = 8 Then
                If Button2.Text = Dialog1.TextBox2.Text And Button5.Enabled = True Then
                    With Button5
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                  Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button5.Text = Dialog1.TextBox2.Text And Button2.Enabled = True Then
                    With Button2
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                 Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button9.Text = Dialog1.TextBox2.Text And Button7.Enabled = True Then
                    With Button7
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                  Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button7.Text = Dialog1.TextBox2.Text And Button9.Enabled = True Then
                    With Button9
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                 Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button6.Text = Dialog1.TextBox2.Text Or Button3.Text = Dialog1.TextBox2.Text Or Button1.Text = Dialog1.TextBox2.Text Or Button4.Text = Dialog1.TextBox2.Text Then
                    hit()
                End If
            End If
            'If user hits 9
            If Label1.Text = 9 Then
                If Button6.Text = Dialog1.TextBox2.Text And Button3.Enabled = True Then
                    With Button3
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                    Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button3.Text = Dialog1.TextBox2.Text And Button6.Enabled = True Then
                    With Button6
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                 Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button5.Text = Dialog1.TextBox2.Text And Button1.Enabled = True Then
                    With Button1
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                 Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button1.Text = Dialog1.TextBox2.Text And Button5.Enabled = True Then
                    With Button5
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                 Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button8.Text = Dialog1.TextBox2.Text And Button7.Enabled = True Then
                    With Button7
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                 Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button7.Text = Dialog1.TextBox2.Text And Button8.Enabled = True Then
                    With Button8
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                                 Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            .Text = "X"
                            .BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            .Text = "O"
                            .BackColor = Label8.BackColor
                        End If
                        .Enabled = False
                    End With
                ElseIf Button2.Text = Dialog1.TextBox2.Text Or Button4.Text = Dialog1.TextBox2.Text Then
                    hit()
                End If
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
            WWon.Enabled = True
            Won.Text = TextBox3.Text & "فاز"
            MsgBox(TextBox3.Text & "فاز")
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
        ElseIf Button1.Text = TextBox2.Text And Button2.Text = TextBox2.Text And Button3.Text = TextBox2.Text _
        Or Button4.Text = TextBox2.Text And Button5.Text = TextBox2.Text And Button6.Text = TextBox2.Text _
        Or Button7.Text = TextBox2.Text And Button8.Text = TextBox2.Text And Button9.Text = TextBox2.Text _
        Or Button1.Text = TextBox2.Text And Button4.Text = TextBox2.Text And Button7.Text = TextBox2.Text _
        Or Button2.Text = TextBox2.Text And Button5.Text = TextBox2.Text And Button8.Text = TextBox2.Text _
        Or Button3.Text = TextBox2.Text And Button6.Text = TextBox2.Text And Button9.Text = TextBox2.Text _
        Or Button1.Text = TextBox2.Text And Button5.Text = TextBox2.Text And Button9.Text = TextBox2.Text _
        Or Button7.Text = TextBox2.Text And Button5.Text = TextBox2.Text And Button3.Text = TextBox2.Text Then
            WWon.Enabled = True
            Won.Text = TextBox4.Text & "فاز"
            MsgBox(TextBox4.Text & "فاز")
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


    Public Sub hit()
        For Each ctl As Control In Me.Controls
            If Label1.Text < 9 Then
                If (ctl.Name.StartsWith("Button" & Label1.Text + 1)) Then
                    Dim btn As Button = DirectCast(ctl, Button)
                    If btn.Enabled = True Then
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                 Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            btn.Text = "X"
                            btn.BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            btn.Text = "O"
                            btn.BackColor = Label8.BackColor
                        End If
                        btn.Enabled = False
                    Else
                        Label1.Text = Label1.Text + 1
                    End If
                End If
            Else
                If (ctl.Name.StartsWith("Button1")) Then
                    Dim btn As Button = DirectCast(ctl, Button)
                    If btn.Enabled = True Then
                        If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
                 Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                            Button1.Text = "X"
                            Button1.BackColor = Label9.BackColor
                        ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                            Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                            Button1.Text = "O"
                            Button1.BackColor = Label8.BackColor
                        End If
                        btn.Enabled = False
                    Else
                        Label1.Text = Label1.Text + 1
                    End If
                End If
            End If
        Next
    End Sub
    Private Sub Re_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Re.Click
        Button10.Enabled = True
        Button15.Enabled = True
        Button11.Enabled = True
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
        Won.Text = ""
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Timer1.Stop()
        Button1.Text = Dialog1.TextBox3.Text
        Label1.Text = 1
        Button1.Enabled = False
        Button11.Enabled = False
        With Button1
            If TextBox2.Text = "X" And TextBox4.Text = "Computer" _
           Or TextBox1.Text = "X" And TextBox3.Text = "Computer" Then
                .Text = "X"
                .BackColor = Label9.BackColor
            ElseIf TextBox2.Text = "O" And TextBox4.Text = "Computer" _
                Or TextBox1.Text = "O" And TextBox3.Text = "Computer" Then
                .Text = "O"
                .BackColor = Label8.BackColor
            End If
        End With
    End Sub

    Private Sub TableLayout_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TableLayout.VisibleChanged
        Won.Text = ""
    End Sub

    Private Sub Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Del.Click
        ScoreO.Text = "0"
        ScoreX.Text = "0"
    End Sub

    Private Sub WWon_Tick(sender As Object, e As EventArgs) Handles WWon.Tick
        If Won.Text = TextBox2.Text + "فاز" Then
            ScoreX.Text += 1
        ElseIf Won.Text = TextBox1.Text + "فاز" Then
            ScoreO.Text += 1
        ElseIf ScoreX.Text = Num.Text Then
            Winner.Text = TextBox4.Text
            Winner.Show()
            Button1.Hide()
            Button2.Hide()
            Button3.Hide()
            Button4.Hide()
            Button5.Hide()
            Button6.Hide()
            Button7.Hide()
            Button8.Hide()
            Button9.Hide()
            Button10.Show()
            TextBox1.Hide()
            TextBox2.Hide()
            TableLayout.Show()
            Label5.Show()
            Label6.Show()
            Label3.Show()
            Label4.Show()
            Naime.Show()
            scoore.Show()
            Won.Hide()
            Label7.Hide()
            Num.Hide()
            Del.Show()
        ElseIf ScoreO.Text = Num.Text Then
            Winner.Text = TextBox3.Text
            Winner.Show()
            Button1.Hide()
            Button2.Hide()
            Button3.Hide()
            Button4.Hide()
            Button5.Hide()
            Button6.Hide()
            Button7.Hide()
            Button8.Hide()
            Button9.Hide()
            Button10.Show()
            TextBox1.Hide()
            TextBox2.Hide()
            TableLayout.Show()
            Label5.Show()
            Label6.Show()
            Label3.Show()
            Label4.Show()
            Naime.Show()
            scoore.Show()
            Won.Hide()
            Label7.Hide()
            Num.Hide()
            Del.Show()
        ElseIf ScoreX.Text = ScoreO.Text And _
            ScoreO.Text = Num.Text And _
            ScoreX.Text = Num.Text Then
            Winner.Text = "="
            Winner.Show()
            Button1.Hide()
            Button2.Hide()
            Button3.Hide()
            Button4.Hide()
            Button5.Hide()
            Button6.Hide()
            Button7.Hide()
            Button8.Hide()
            Button9.Hide()
            Button10.Show()
            TextBox1.Hide()
            TextBox2.Hide()
            TableLayout.Show()
            Label5.Show()
            Label6.Show()
            Label3.Show()
            Label4.Show()
            Naime.Show()
            scoore.Show()
            Won.Hide()
            Label7.Hide()
            Num.Hide()
            Del.Show()
        End If

    End Sub
End Class

