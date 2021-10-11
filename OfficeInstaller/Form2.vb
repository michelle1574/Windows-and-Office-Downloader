Public Class Form2

    Private Sub downloadAMD64_Click(sender As Object, e As EventArgs) Handles downloadAMD64.Click
        If ver9600.Checked = True Then
            If ComboBox1.Text = "Angielski (Stany Zjednoczone)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=a49ca4d5")
            ElseIf ComboBox1.Text = "Polski (Polska)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=d9831f1a")
            End If
        ElseIf ver9600n.Checked = True Then
            If ComboBox1.Text = "Polski (Polska)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=c1ed85a4")
            ElseIf ComboBox1.Text = "Angielski (Stany Zjednoczone)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=51ed8e7e")
            End If
        ElseIf ver21h1.Checked = True Then
            If ComboBox1.Text = "Polski (Polska)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=8b34a273")
            ElseIf ComboBox1.Text = "Angielski (Stany Zjednoczone)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=fb555f3a")
            End If

        ElseIf ver20h2.Checked = True Then
            If ComboBox1.Text = "Polski (Polska)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=eb746188")
            ElseIf ComboBox1.Text = "Angielski (Stany Zjednoczone)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=659a4291")
            End If

        ElseIf ver20H1.Checked = True Then
            If ComboBox1.Text = "Polski (Polska)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=26c2d99f")
            ElseIf ComboBox1.Text = "Angielski (Stany Zjednoczone)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=ed2dc1aa")
            End If
        ElseIf ver19H2.Checked = True Then
            If ComboBox1.Text = "Polski (Polska)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=d137f4ac")
            ElseIf ComboBox1.Text = "Angielski (Stany Zjednoczone)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=981c4d21")
            End If
        ElseIf ver19H1.Checked = True Then
            If ComboBox1.Text = "Polski (Polska)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=d6395bda")
            ElseIf ComboBox1.Text = "Angielski (Stany Zjednoczone)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=ef499747")
            End If
        ElseIf ver1809.Checked = True Then
            If ComboBox1.Text = "Polski (Polska)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=569f1598")
            ElseIf ComboBox1.Text = "Angielski (Stany Zjednoczone)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=f6ab4873")
            End If
        ElseIf ver11_off.Checked = True Then
            If ComboBox1.Text = "Polski (Polska)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=b1258929")
            ElseIf ComboBox1.Text = "Angielski (Stany Zjednoczone)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=26f23bc1")
            End If
        ElseIf ver11.Checked = True Then
            If ComboBox1.Text = "Polski (Polska)" Then
                WebBrowser1.Navigate("https://link.winiso.pl/out/FPUoTxIfMG")
            ElseIf ComboBox1.Text = "Angielski (Stany Zjednoczone)" Then
                WebBrowser1.Navigate("https://anonfiles.com/15C6W2L1u0/22471.1000.210929-1415.RS_PRERELEASE_CLIENTMULTI_X64FRE_EN-US_ISO")
            End If
        ElseIf verserver2022.Checked = True Then
            If ComboBox1.Text = "Polski (Polska)" Then
                WebBrowser1.Navigate("https://anonfiles.com/t3ZdgeN9u5/20348.169.210806-1117.FE_RELEASE_SVC_PROD1_SERVER_X64FRE_PL-PL_ISO")
            ElseIf ComboBox1.Text = "Angielski (Stany Zjednoczone)" Then
                WebBrowser1.Navigate("https://anonfiles.com/baVcg3Neu9/20348.169.210806-1117.FE_RELEASE_SVC_PROD1_SERVER_X64FRE_EN-US_ISO")
            End If
        ElseIf verAzureStackHCIPreview.Checked = True Then
            If ComboBox1.Text = "Polski (Polska)" Then
                WebBrowser1.Navigate("https://anonfiles.com/L4Beh0Nbu6/22471.1000.210929-1415.RS_PRERELEASE_SERVERAZURESTACKHCI_RET_X64FRE_PL-PL_ISO")
            ElseIf ComboBox1.Text = "Angielski (Stany Zjednoczone)" Then
                WebBrowser1.Navigate("https://anonfiles.com/10r8h0N3u0/22471.1000.210929-1415.RS_PRERELEASE_SERVERAZURESTACKHCI_RET_X64FRE_EN-US_ISO")
            End If
        End If
    End Sub

    Private Sub download_x86_Click(sender As Object, e As EventArgs) Handles download_x86.Click
        If ver9600.Checked = True Then
            If ComboBox1.Text = "Polski (Polska)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=b4d78d33")
            ElseIf ComboBox1.Text = "Angielski (Stany Zjednoczone)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=6733432e")
            End If
        ElseIf ver9600n.Checked = True Then
            If ComboBox1.Text = "Polski (Polska)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=a823f6ac")
            ElseIf ComboBox1.Text = "Angielski (Stany Zjednoczone)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=2b74eb75")
            End If
        ElseIf ver21h1.Checked = True Then
            If ComboBox1.Text = "Polski (Polska)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=911c131a")
            ElseIf ComboBox1.Text = "Angielski (Stany Zjednoczone)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=45d9e3df")
            End If
        ElseIf ver20h2.Checked = True Then
            If ComboBox1.Text = "Polski (Polska)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=eb746188")
            ElseIf ComboBox1.Text = "Angielski (Stany Zjednoczone)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=4222849f")
            End If
        ElseIf ver20H1.Checked = True Then
            If ComboBox1.Text = "Polski (Polska)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=e6ce4827")
            ElseIf ComboBox1.Text = "Angielski (Stany Zjednoczone)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=ea4a6937")
            End If
        ElseIf ver19H2.Checked = True Then
            If ComboBox1.Text = "Polski (Polska)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=4c5389d3")
            ElseIf ComboBox1.Text = "Angielski (Stany Zjednoczone)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=2dbfa165")
            End If
        ElseIf ver19H1.Checked = True Then
            If ComboBox1.Text = "Polski (Polska)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=685761fb")
            ElseIf ComboBox1.Text = "Angielski (Stany Zjednoczone)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=1ff84bbb")
            End If
        ElseIf ver1809.Checked = True Then
            If ComboBox1.Text = "Polski (Polska)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=427865b8")
            ElseIf ComboBox1.Text = "Angielski (Stany Zjednoczone)" Then
                WebBrowser1.Navigate("https://tb.rg-adguard.net/dl.php?go=49cda6ac")
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form1.Show()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Height += 1
        If Me.Height = 570 Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Height -= 1
        If Me.Height = 253 Then
            Timer2.Stop()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("Notatka: przy wersji Windows server 2022, należy wcisnąć Pokaż okno WebBrowser i nacisnąć Pobierz.
Dotyczy też angielskiej wersji Windows 11 z Dev channel i Azure Stack HCI Preview.", vbOKOnly + vbInformation, "Notatka")
    End Sub

    Private Sub ver11_off_CheckedChanged(sender As Object, e As EventArgs) Handles ver11_off.CheckedChanged
        If ver11_off.Checked = True Then
            download_x86.Enabled = False
        Else
            download_x86.Enabled = True
        End If
    End Sub

    Private Sub ver11_CheckedChanged(sender As Object, e As EventArgs) Handles ver11.CheckedChanged
        If ver11.Checked = True Then
            download_x86.Enabled = False
        Else
            download_x86.Enabled = True
        End If
    End Sub

    Private Sub verServer2022_CheckedChanged(sender As Object, e As EventArgs) Handles verServer2022.CheckedChanged
        If verServer2022.Checked = True Then
            download_x86.Enabled = False
        Else
            download_x86.Enabled = True
        End If
    End Sub

    Private Sub verAzureStackHCIPreview_CheckedChanged(sender As Object, e As EventArgs) Handles verAzureStackHCIPreview.CheckedChanged
        If verAzureStackHCIPreview.Checked = True Then
            download_x86.Enabled = False
        Else
            download_x86.Enabled = True
        End If
    End Sub
End Class