Public Class Game2
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        counter.Text = "Ofirst"
        Button11.Hide()
        Button10.Hide()
        Label2.Hide()
        TextBox1.Hide()
        TextBox2.Hide()
        Button1.Show()
        Button2.Show()
        Button3.Show()
        Button4.Show()
        Button5.Show()
        Button6.Show()
        Button7.Show()
        Button8.Show()
        Button9.Show()
        Label7.Hide()
        Num.Hide()

    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        counter.Text = "Xfirst"
        Button11.Hide()
        Button10.Hide()
        Label2.Hide()
        TextBox1.Hide()
        TextBox2.Hide()
        Button1.Show()
        Button2.Show()
        Button3.Show()
        Button4.Show()
        Button5.Show()
        Button6.Show()
        Button7.Show()
        Button8.Show()
        Button9.Show()
        Label7.Hide()
        Num.Hide()

    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        MainMenu.Show()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Label7.Show()
        Num.Show()
        TableLayout.Hide()
        Winner.Hide()
        TableLayout.Hide()
        Label5.Hide()
        Label6.Hide()
        Label3.Hide()
        Label4.Hide()
        Naime.Hide()
        scoore.Hide()
        Button11.Show()
        Button10.Show()
        Label2.Show()
        TextBox1.Show()
        TextBox2.Show()
        Button1.Hide()
        Button2.Hide()
        Button3.Hide()
        Button4.Hide()
        Button5.Hide()
        Button6.Hide()
        Button7.Hide()
        Button8.Hide()
        Button9.Hide()
        Won.Hide()
        Button14.Hide()
    End Sub
    Private Sub Re_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Re.Click

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
        Button8.BackColor = Color.White
        Button8.Enabled = True
        Button8.Text = ""
        Button9.Text = ""
        Button9.BackColor = Color.White
        Button9.Enabled = True
        Won.Text = ""

    End Sub
    Private Sub Won_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Won.TextChanged
        If Won.Text = TextBox2.Text & Label1.Text Then
            ScoreX.Text += 1
        ElseIf Won.Text = TextBox1.Text + Label1.Text Then
            ScoreO.Text += 1
        ElseIf ScoreX.Text = Num.Text Then
            Winner.Text = TextBox2.Text & "(X)"
        ElseIf ScoreO.Text = Num.Text Then
            Winner.Text = TextBox1.Text & "(O)"
        ElseIf ScoreO.Text = ScoreX.Text Then
            Winner.Text = "="
        End If
        Won.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        If counter.Text = "Xfirst" Then
            Button1.Text = "X"
            Button1.BackColor = Label9.BackColor
            counter.Text = "Ofirst"
        ElseIf counter.Text = "Ofirst" Then
            Button1.Text = "O"
            Button1.BackColor = Label8.BackColor
            counter.Text = "Xfirst"
        End If
        Check()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button2.Enabled = False
        If counter.Text = "Xfirst" Then
            Button2.Text = "X"
            Button2.BackColor = Label9.BackColor
            counter.Text = "Ofirst"
        ElseIf counter.Text = "Ofirst" Then
            Button2.Text = "O"
            Button2.BackColor = Label8.BackColor
            counter.Text = "Xfirst"
        End If
        Check()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button3.Enabled = False
        If counter.Text = "Xfirst" Then
            Button3.Text = "X"
            Button3.BackColor = Label9.BackColor
            counter.Text = "Ofirst"
        ElseIf counter.Text = "Ofirst" Then
            Button3.Text = "O"
            Button3.BackColor = Label8.BackColor
            counter.Text = "Xfirst"
        End If
     Check()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Button4.Enabled = False
        If counter.Text = "Xfirst" Then
            Button4.Text = "X"
            Button4.BackColor = Label9.BackColor
            counter.Text = "Ofirst"
        ElseIf counter.Text = "Ofirst" Then
            Button4.Text = "O"
            Button4.BackColor = Label8.BackColor
            counter.Text = "Xfirst"
        End If
       Check()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Button5.Enabled = False
        If counter.Text = "Xfirst" Then
            Button5.Text = "X"
            Button5.BackColor = Label9.BackColor
            counter.Text = "Ofirst"
        ElseIf counter.Text = "Ofirst" Then
            Button5.Text = "O"
            Button5.BackColor = Label8.BackColor
            counter.Text = "Xfirst"
        End If
       Check()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Button6.Enabled = False
        If counter.Text = "Xfirst" Then
            Button6.Text = "X"
            Button6.BackColor = Label9.BackColor
            counter.Text = "Ofirst"
        ElseIf counter.Text = "Ofirst" Then
            Button6.Text = "O"
            Button6.BackColor = Label8.BackColor
            counter.Text = "Xfirst"
        End If
     Check()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Button7.Enabled = False
        If counter.Text = "Xfirst" Then
            Button7.Text = "X"
            Button7.BackColor = Label9.BackColor
            counter.Text = "Ofirst"
        ElseIf counter.Text = "Ofirst" Then
            Button7.Text = "O"
            Button7.BackColor = Label8.BackColor
            counter.Text = "Xfirst"
        End If
       Check()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Button8.Enabled = False
        If counter.Text = "Xfirst" Then
            Button8.Text = "X"
            Button8.BackColor = Label9.BackColor
            counter.Text = "Ofirst"
        ElseIf counter.Text = "Ofirst" Then
            Button8.Text = "O"
            Button8.BackColor = Label8.BackColor
            counter.Text = "Xfirst"
        End If
        Check()
    End Sub


    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Button9.Enabled = False
        If counter.Text = "Xfirst" Then
            Button9.Text = "X"
            Button9.BackColor = Label9.BackColor
            counter.Text = "Ofirst"
        ElseIf counter.Text = "Ofirst" Then
            Button9.Text = "O"
            Button9.BackColor = Label8.BackColor
            counter.Text = "Xfirst"
        End If
        Check()
    End Sub

    Private Sub TextBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseClick
        TextBox1.SelectAll()
    End Sub

    Private Sub TextBox2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox2.MouseClick
        TextBox2.SelectAll()
    End Sub

    Private Sub Form4_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        If Me.Visible = True Then
            Game.Hide()
            MainMenu.Hide()
        End If
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button11.BackColor = Label8.BackColor
        Button10.BackColor = Label9.BackColor
        Won.Enabled = True
    End Sub

    Private Sub Button14_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button14.Click
        ScoreO.Text = "0"
        ScoreX.Text = "0"
    End Sub

    Public Sub Check()
        If Button1.Text = Button11.Text And Button2.Text = Button11.Text And Button3.Text = Button11.Text _
          Or Button4.Text = Button11.Text And Button5.Text = Button11.Text And Button6.Text = Button11.Text _
          Or Button7.Text = Button11.Text And Button8.Text = Button11.Text And Button9.Text = Button11.Text _
          Or Button1.Text = Button11.Text And Button4.Text = Button11.Text And Button7.Text = Button11.Text _
          Or Button2.Text = Button11.Text And Button5.Text = Button11.Text And Button8.Text = Button11.Text _
          Or Button3.Text = Button11.Text And Button6.Text = Button11.Text And Button9.Text = Button11.Text _
          Or Button1.Text = Button11.Text And Button5.Text = Button11.Text And Button9.Text = Button11.Text _
          Or Button7.Text = Button11.Text And Button5.Text = Button11.Text And Button3.Text = Button11.Text Then
            Won.Text = Label1.Text & TextBox1.Text
            ScoreO.Text += 1
            MsgBox(Label1.Text & TextBox1.Text)
            If Won.Text = TextBox1.Text + Label1.Text Then
                ScoreO.Text += 1
            ElseIf ScoreO.Text = Num.Text Then
                Winner.Text = TextBox1.Text & "(O)"
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
                Button10.Hide()
                Button11.Hide()
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
                Button14.Show()
            ElseIf ScoreO.Text = ScoreX.Text Then
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
                Button10.Hide()
                Button11.Hide()
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
                Button14.Show()
            End If
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
        If Button1.Text = Button10.Text And Button2.Text = Button10.Text And Button3.Text = Button10.Text _
         Or Button4.Text = Button10.Text And Button5.Text = Button10.Text And Button6.Text = Button10.Text _
         Or Button7.Text = Button10.Text And Button8.Text = Button10.Text And Button9.Text = Button10.Text _
         Or Button1.Text = Button10.Text And Button4.Text = Button10.Text And Button7.Text = Button10.Text _
         Or Button2.Text = Button10.Text And Button5.Text = Button10.Text And Button8.Text = Button10.Text _
         Or Button3.Text = Button10.Text And Button6.Text = Button10.Text And Button9.Text = Button10.Text _
         Or Button1.Text = Button10.Text And Button5.Text = Button10.Text And Button9.Text = Button10.Text _
         Or Button7.Text = Button10.Text And Button5.Text = Button10.Text And Button3.Text = Button10.Text Then
            Won.Text = Label1.Text & TextBox2.Text
            ScoreX.Text += 1
            MsgBox(Label1.Text & TextBox2.Text)
            If Won.Text = TextBox2.Text & Label1.Text Then
                ScoreX.Text += 1
            ElseIf ScoreX.Text = Num.Text Then
                Winner.Text = TextBox2.Text & "(X)"
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
                Button10.Hide()
                Button11.Hide()
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
                Button14.Show()
            ElseIf ScoreO.Text = ScoreX.Text Then
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
                Button10.Hide()
                Button11.Hide()
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
                Button14.Show()
            End If
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

    Private Sub WWon_Tick(sender As Object, e As EventArgs) Handles WWOn.Tick
        Check()
    End Sub

    Private Sub Winner_TextChanged(sender As Object, e As EventArgs) Handles Winner.TextChanged
        If ScoreO.Text = ScoreX.Text Then
            Winner.Text = "="
        End If
    End Sub
End Class

