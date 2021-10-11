Imports System.IO
Public Class Form1

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("Powody:
Link wygasł.
Pytanie o pobraniu zostało zminimazowane.
Błąd 403 (Brak uprawnień)
Błąd 404 (Nie znaleziono)
Inne błędy takie jak błąd serwera lub inne rzeczy.
Plik jest pobierany ale nie jest pokazane.", vbInformation + vbOKOnly, "Powody za brak pytania czy pobrać plik:")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        MsgBox("1. Pobierz Office'a
2. Wypakuj plik pobrany
3. Utwórz folder dla Office'a, dla wersji:
365: Office365
2019: Office2019
2016: Office2016
2013: Office2013.
Uwaga: aby instalator działał musi być instalator w folderze z Officem o nazwie setup.exe.
Następna uwaga: Ta aplikacja musi być w folderze z folderem Office'a aby działał.", vbOKOnly + vbInformation, "Instrukcja")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Close()

        If File.Exists("Office2016\Setup.exe") Or File.Exists("Office365\Setup.exe") Or File.Exists("Office2019\Setup.exe") Or File.Exists("Office2013\setup.exe") Then
            onlineInstall.Checked = False
        Else
            onlineInstall.Checked = True
        End If
        Ver365.Checked = True
    End Sub

    Private Sub onlineInstall_CheckedChanged(sender As Object, e As EventArgs) Handles onlineInstall.CheckedChanged
        If onlineInstall.Checked = True Then
            Button1.Enabled = True
            Button1.Text = "Pobierz"
            ComboBox1.Visible = True
        ElseIf onlineInstall.Checked = False Then
            Button1.Enabled = True
            Button1.Text = "Instaluj"
            ComboBox1.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If onlineInstall.Checked = False Then
            If Ver2013.Checked = True Then
                If File.Exists("Office2013\setup.exe") Then
                    Process.Start("Office2013\setup.exe")
                Else
                    Dim err As DialogResult
                    err = MsgBox("Nie znaleziono pliku instalatora.", vbCritical + vbRetryCancel, "Błąd")
                    If err = DialogResult.Retry Then
                        MsgBox("Aby spróbować ponownie, zrestartuj tą aplikacje.", vbOKOnly, "Informacja")
                    End If
                End If

            ElseIf Ver2019.Checked = True Then
                If File.Exists("Office2019\Setup.exe") Then
                    Process.Start("Office2019\Setup.exe")
                Else
                    Dim err As DialogResult
                    err = MsgBox("Nie znaleziono pliku instalatora.", vbCritical + vbRetryCancel, "Błąd")
                    If err = DialogResult.Retry Then
                        MsgBox("Aby spróbować ponownie, zrestartuj tą aplikacje.", vbOKOnly, "Informacja")
                    End If
                End If
            ElseIf Ver2016.Checked = True Then
                If File.Exists("Office2016\Setup.exe") Then
                    Process.Start("Office2016\Setup.exe")
                Else
                    Dim err As DialogResult
                    err = MsgBox("Nie znaleziono pliku instalatora.", vbCritical + vbRetryCancel, "Błąd")
                    If err = DialogResult.Retry Then
                        MsgBox("Aby spróbować ponownie, zrestartuj tą aplikacje.", vbOKOnly, "Informacja")
                    End If
                End If
            ElseIf Ver365.Checked = True Then
                If File.Exists("Office365\Setup.exe") Then
                    Process.Start("Office365\Setup.exe")
                Else
                    Dim err As DialogResult
                    err = MsgBox("Nie znaleziono pliku instalatora.", vbCritical + vbRetryCancel, "Błąd")
                    If err = DialogResult.Retry Then
                        MsgBox("Aby spróbować ponownie, zrestartuj tą aplikacje.", vbOKOnly, "Informacja")
                    End If
                End If
            ElseIf Ver2021.Checked = True Then
                If File.Exists("Office2021\Setup.exe") Then
                    Process.Start("Office2021\Setup.exe")
                Else
                    Dim err As DialogResult
                    err = MsgBox("Nie znaleziono pliku instalatora.", vbCritical + vbRetryCancel, "Błąd")
                    If err = DialogResult.Retry Then
                        MsgBox("Aby spróbować ponownie, zrestartuj tą aplikacje.", vbOKOnly, "Informacja")
                    End If
                End If
            Else
                MsgBox("Nie wybrano opcji. Proszę wybrać opcję aby zainstalować Office'a.", vbCritical + vbOKOnly, "Błąd")
            End If
        ElseIf onlineInstall.Checked = True Then
            If Ver2013.Checked = True Then
                If ComboBox1.Text = "Polski (Polska)" Then
                    WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=cc8d4e24")
                ElseIf combobox1.text = "Angielski (Stany Zjednoczone)" Then
                    WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=eec9cb96")
                End If
            ElseIf Ver2016.Checked = True Then
                If ComboBox1.Text = "Polski (Polska)" Then
                    WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=f44345b1")
                ElseIf combobox1.text = "Angielski (Stany Zjednoczone)" Then
                    WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=3e814823")
                End If
            ElseIf Ver2019.Checked = True Then
                If ComboBox1.Text = "Polski (Polska)" Then
                    WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=42b87161")
                ElseIf combobox1.text = "Angielski (Stany Zjednoczone)" Then
                    WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=56b3c333")
                End If
            ElseIf Ver365.Checked = True Then
                If ComboBox1.Text = "Polski (Polska)" Then
                    WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=df87496b")
                ElseIf combobox1.text = "Angielski (Stany Zjednoczone)" Then
                    WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=287bd637")
                End If
            ElseIf Ver2021.Checked = True Then
                If ComboBox1.Text = "Polski (Polska)" Then
                    WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=c3d546b3")
                ElseIf combobox1.text = "Angielski (Stany Zjednoczone)" Then
                    WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=7713396f")
                End If
            Else
                    MsgBox("Nie wybrano opcji. Proszę wybrać opcję aby pobrać Office'a.", vbCritical + vbOKOnly, "Błąd")
            End If
        Else
            MsgBox("Nie wybrano opcji. Proszę wybrać opcję aby pobrać lub zainstalować Office'a.", vbCritical + vbOKOnly, "Błąd")

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Ver2013.Checked = False
        Ver2016.Checked = False
        Ver2019.Checked = False
        Ver365.Checked = False
        Ver2021.Checked = False
        onlineInstall.Checked = False
        Label1.Text = 0
        Button1.Text = "Nie wybrano opcji"
        Button1.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()


    End Sub
End Class
