Public Class Settings

    Private Sub RadioButton3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton3.Click
        Button25.Text = "D'accord"
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        Button25.Text = "حسنًا"
    End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        Button25.Text = "OK"
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        If RadioButton1.Checked = True Then
            MainMenu.Text = "Main Menu"
            MainMenu.RightToLeft = 0
            MainMenu.RightToLeftLayout = False
            Game.RightToLeft = 0
            Game.RightToLeftLayout = False
            Game1.RightToLeft = 0
            Game1.RightToLeftLayout = False
            Game2.RightToLeft = 0
            Game2.RightToLeftLayout = False
            Dialog1.RightToLeft = 0
            Dialog1.RightToLeftLayout = False
            Me.RightToLeft = 0
            Me.RightToLeftLayout = False
            AboutBox1.RightToLeft = 0
            AboutBox1.RightToLeftLayout = False
            Me.RadioButton1.RightToLeft = 1
            AboutBox1.LabelCopyright.Text = "Andrew © Akladious © Bekhit © 2016 All rights reserved"
            AboutBox1.LabelCompanyName.Text = "Saint Mary Church in Ismailia"
            Game.Text = "The Game"
            Me.Text = "Settings"
            AboutBox1.Text = "About X-O 6"
            AboutBox1.OKButton.Text = "OK"
            MainMenu.Button1.Text = "Start"
            MainMenu.Button2.Text = "Settings"
            MainMenu.Button4.Text = "About"
            MainMenu.Button5.Text = "Exit"
            Game.Button2.Text = "Play with computer"
            Game.Button1.Text = "Play with two real players"
            Game2.TextBox1.Text = "Type the name of the person O"
            Game2.TextBox2.Text = "Type the name of the person X"
            Game1.Button11.Text = "PC Starts"
            Dialog1.Label1.Text = "You Are:"
            Dialog1.OK_Button.Text = "OK"
            Dialog1.Cancel_Button.Text = "Cancel"
            Dialog1.TextBox1.Text = "Write your name here"
            Dialog1.TextBox4.Text = "Please fill data"
            Dialog1.Text = "Fill the data"
            Me.Label1.Text = "X Color"
            Me.Label2.Text = "O Color"
            Me.Label3.Text = "Preview"
            Me.Label6.Text = "Settings"
            Me.Button25.Text = "OK"
            Game2.Button15.Text = "Main Menu"
            Game2.Re.Text = "Re"
            Game2.Button12.Text = "Menu"
            Game2.Label7.Text = "The final points are"
            Game2.Label5.Text = "The Winner"
            Game2.Button14.Text = "Remove High scores"
            Game2.Label2.Text = "Choose who plays first"
            Game2.Naime.Text = "Name"
            Game2.scoore.Text = "Score"
            Game2.Label1.Text = "Won"
            Game1.Button15.Text = "Main Menu"
            Game1.Re.Text = "Re"
            Game1.Label7.Text = "The final points are"
            Game1.Label5.Text = "The Winner"
            Game1.Del.Text = "Remove High scores"
            Game1.Label2.Text = "Choose who plays first"
            Game1.Naime.Text = "Name"
            Game1.scoore.Text = "Score"
            Game1.Label1.Text = "Won"
            Game1.Button10.Text = "Play again"
        End If
        If RadioButton2.Checked = True Then
            MainMenu.Text = "القائمة الرئيسية"
            MainMenu.RightToLeft = 1
            MainMenu.RightToLeftLayout = True
            Game.RightToLeft = 1
            Game.RightToLeftLayout = True
            Game1.RightToLeft = 1
            Game1.RightToLeftLayout = True
            Game2.RightToLeft = 1
            Game2.RightToLeftLayout = True
            Dialog1.RightToLeft = 1
            Dialog1.RightToLeftLayout = True
            Me.RightToLeft = 1
            Me.RightToLeftLayout = True
            AboutBox1.RightToLeft = 1
            AboutBox1.RightToLeftLayout = True
            Me.RadioButton1.RightToLeft = 1
            Game.Text = "اللعبة"
            Me.Text = "الإعدادات"
            AboutBox1.LabelCopyright.Text = "جميع الحقوق محفوظة أندرو© أقلديوس© بخيت© 2016"
            AboutBox1.LabelCompanyName.Text = "كنيسة السيدة العذراء مريم بالإسماعيلية"
            AboutBox1.Text = "حول X-O 6"
            AboutBox1.OKButton.Text = "حسنًا"
            MainMenu.Button1.Text = "إبدأ"
            MainMenu.Button2.Text = "الإعدادات"
            MainMenu.Button4.Text = "حول"
            MainMenu.Button5.Text = "خروج"
            Game.Button2.Text = "اللعب مع الكمبيوتر"
            Game.Button1.Text = "اللعب بلاعبان حقيقيان"
            Game2.TextBox1.Text = "إكتب اسم الشخص O"
            Game2.TextBox2.Text = "إكتب اسم الشخص X"
            Game1.Button11.Text = "الكمبيوتر يبدأ أولًا"
            Dialog1.Label1.Text = "أنت :"
            Dialog1.OK_Button.Text = "حسنًا"
            Dialog1.Cancel_Button.Text = "إلغاء الأمر"
            Dialog1.TextBox1.Text = "اكتب اسمك هنا"
            Dialog1.TextBox4.Text = "من فضلك إملأ البيانات"
            Dialog1.Text = "إملأ البيانات"
            Me.Label1.Text = "لون X"
            Me.Label2.Text = "لون O"
            Me.Label3.Text = "معاينة"
            Me.Label6.Text = "الإعدادات"
            Me.Button25.Text = "حسنًا"
            Game2.Button15.Text = "القائمة الرئيسية"
            Game2.Re.Text = "إعادة"
            Game2.Button12.Text = "القائمة"
            Game2.Label7.Text = "الفورة من"
            Game2.Button14.Text = "مسح الدرجات"
            Game2.Label2.Text = "اختر مَن سيلعب أولًا"
            Game2.Naime.Text = "الإسم"
            Game2.scoore.Text = "الدرجة"
            Game2.Label1.Text = "فاز"
            Game1.Button15.Text = "القائمة الرئيسية"
            Game1.Re.Text = "إعادة"
            Game1.Label7.Text = "الفورة من"
            Game1.Del.Text = "مسح الدرجات"
            Game1.Label2.Text = "اختر مَن سيلعب أولًا"
            Game1.Naime.Text = "الإسم"
            Game1.scoore.Text = "الدرجة"
            Game1.Label1.Text = "فاز"
            Game1.Button10.Text = "اللعب مرة أخرى"
        End If
        If RadioButton3.Checked = True Then
            MainMenu.Text = "Menu principal"
            MainMenu.RightToLeft = 0
            MainMenu.RightToLeftLayout = False
            Game.RightToLeft = 0
            Game.RightToLeftLayout = False
            Game1.RightToLeft = 0
            Game1.RightToLeftLayout = False
            Game2.RightToLeft = 0
            Game2.RightToLeftLayout = False
            Dialog1.RightToLeft = 0
            Dialog1.RightToLeftLayout = False
            Me.RightToLeft = 0
            Me.RightToLeftLayout = False
            AboutBox1.RightToLeft = 0
            AboutBox1.RightToLeftLayout = False
            Me.RadioButton1.RightToLeft = 1
            Game.Text = "Le jeu"
            Me.Text = "Paramètres"
            AboutBox1.LabelCopyright.Text = "Andrew © Akladious © Bekhit © 2016 Tous droits réservés"
            AboutBox1.LabelCompanyName.Text = "Saint Mary Church à Ismaïlia"
            AboutBox1.Text = "A propos de X-O 6"
            MainMenu.Button1.Text = "Démarrer"
            MainMenu.Button2.Text = "Paramètres"
            MainMenu.Button4.Text = "à propos"
            MainMenu.Button5.Text = "Sortie"
            Game.Button2.Text = "Jouer avec un ordinateur"
            Game.Button1.Text = "Jouez avec deux vrais joueurs"
            Game2.TextBox1.Text = "Tapez le nom de la personne O"
            Game2.TextBox2.Text = "Tapez le nom de la personne X"
            Game1.Button11.Text = "PC Démarre"
            Dialog1.Label1.Text = "Tu es :"
            Dialog1.OK_Button.Text = "D'accord"
            Dialog1.Cancel_Button.Text = "Annuler"
            Dialog1.TextBox1.Text = "Écrivez votre nom ici"
            Dialog1.TextBox4.Text = "S'il vous plaît remplir les données"
            Dialog1.Text = "Remplissez les données"
            Me.Label1.Text = "Couleur X"
            Me.Label2.Text = "Couleur O"
            Me.Label3.Text = "Aperçu"
            Me.Label6.Text = "Paramètres"
            Me.Button25.Text = "D'accord"
            Game2.Button15.Text = "Menu principal"
            Game2.Re.Text = "Re"
            Game2.Button12.Text = "Menu"
            Game2.Label7.Text = "Les points finaux sont"
            Game2.Label5.Text = "Gagnant"
            Game2.Button14.Text = "Supprimer des scores élevés"
            Game2.Label2.Text = "Choisissez qui joue en premier"
            Game2.Naime.Text = "Nom"
            Game2.scoore.Text = "Scores"
            Game2.Label1.Text = "Gagner"
            Game1.Button15.Text = "Menu principal"
            Game1.Re.Text = "Re"
            Game1.Label7.Text = "Les points finaux sont"
            Game1.Label5.Text = "Gagnant"
            Game1.Del.Text = "Supprimer des scores élevés"
            Game1.Label2.Text = "Choisissez qui joue en premier"
            Game1.Naime.Text = "Nom"
            Game1.scoore.Text = "Scores"
            Game1.Label1.Text = "Gagner"
            Game1.Button10.Text = "Jouer à nouveau"
        End If
        Me.Hide()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label4.BackColor = Button1.BackColor
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label4.BackColor = Button2.BackColor
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Label4.BackColor = Button3.BackColor
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Label4.BackColor = Button4.BackColor
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Label4.BackColor = Button5.BackColor
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Label4.BackColor = Button6.BackColor
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Label4.BackColor = Button7.BackColor
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Label4.BackColor = Button8.BackColor
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Label4.BackColor = Button9.BackColor
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Label4.BackColor = Button10.BackColor
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Label4.BackColor = Button11.BackColor
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Label4.BackColor = Button12.BackColor
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Label5.BackColor = Button13.BackColor
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Label5.BackColor = Button14.BackColor
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Label5.BackColor = Button15.BackColor
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Label5.BackColor = Button16.BackColor
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Label5.BackColor = Button17.BackColor
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Label5.BackColor = Button18.BackColor
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Label5.BackColor = Button19.BackColor
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Label5.BackColor = Button20.BackColor
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Label5.BackColor = Button21.BackColor
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Label5.BackColor = Button22.BackColor
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Label5.BackColor = Button23.BackColor
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        Label5.BackColor = Button24.BackColor
    End Sub

    Private Sub VScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs)
        Me.GetScrollState(2)
    End Sub

    Private Sub Label4_BackColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label4.BackColorChanged
        Game2.Label9.BackColor = Label4.BackColor
        Game1.Label9.BackColor = Label4.BackColor
    End Sub

    Private Sub Label5_BackColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label5.BackColorChanged
        Game2.Label8.BackColor = Label5.BackColor
        Game1.Label8.BackColor = Label5.BackColor
    End Sub

    Private Sub me_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Language.RadioButton1.Checked = True Then
            RadioButton1.Checked = True
        ElseIf Language.RadioButton2.Checked = True Then
            RadioButton2.Checked = True
        ElseIf Language.RadioButton3.Checked = True Then
            RadioButton3.Checked = True
        End If
    End Sub
End Class