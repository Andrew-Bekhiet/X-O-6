Imports System.Windows.Forms

Public Class Dialog1
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If RadioButton1.Checked = False And RadioButton2.Checked = False _
      Or TextBox1.Text = "اكتب اسمك هنا" _
      Or TextBox1.Text = "Write your name here" _
      Or TextBox1.Text = "Écrivez votre nom ici" Then
            MsgBox(TextBox4.Text)
        ElseIf RadioButton2.Checked = True Then
            Game1.TextBox4.Text = "Computer"
            Game1.TextBox3.Text = TextBox1.Text
            Game1.TextBox2.Text = "X"
            Game1.TextBox1.Text = "O"
            Game1.Show()
            Me.Hide()
        ElseIf RadioButton1.Checked = True Then
            Game1.TextBox3.Text = "Computer"
            Game1.TextBox4.Text = TextBox1.Text
            Game1.TextBox2.Text = "X"
            Game1.TextBox1.Text = "O"
            Game1.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub RadioButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        TextBox2.Text = "O"
        TextBox3.Text = "X"
    End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        TextBox2.Text = "X"
        TextBox3.Text = "O"
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Hide()
    End Sub

    Private Sub TextBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseClick
        TextBox1.SelectAll()
    End Sub

End Class
