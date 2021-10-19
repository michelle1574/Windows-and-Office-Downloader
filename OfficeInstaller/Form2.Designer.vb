<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.verAzureStackHCIPreview = New System.Windows.Forms.RadioButton()
        Me.verServer2022 = New System.Windows.Forms.RadioButton()
        Me.ver11 = New System.Windows.Forms.RadioButton()
        Me.ver11_off = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ver1809 = New System.Windows.Forms.RadioButton()
        Me.ver19H1 = New System.Windows.Forms.RadioButton()
        Me.ver19H2 = New System.Windows.Forms.RadioButton()
        Me.ver20H1 = New System.Windows.Forms.RadioButton()
        Me.ver20h2 = New System.Windows.Forms.RadioButton()
        Me.ver21h1 = New System.Windows.Forms.RadioButton()
        Me.ver9600n = New System.Windows.Forms.RadioButton()
        Me.ver9600 = New System.Windows.Forms.RadioButton()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.downloadAMD64 = New System.Windows.Forms.Button()
        Me.download_x86 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ver11_2 = New System.Windows.Forms.RadioButton()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ver11_2)
        Me.GroupBox1.Controls.Add(Me.verAzureStackHCIPreview)
        Me.GroupBox1.Controls.Add(Me.verServer2022)
        Me.GroupBox1.Controls.Add(Me.ver11)
        Me.GroupBox1.Controls.Add(Me.ver11_off)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.ver1809)
        Me.GroupBox1.Controls.Add(Me.ver19H1)
        Me.GroupBox1.Controls.Add(Me.ver19H2)
        Me.GroupBox1.Controls.Add(Me.ver20H1)
        Me.GroupBox1.Controls.Add(Me.ver20h2)
        Me.GroupBox1.Controls.Add(Me.ver21h1)
        Me.GroupBox1.Controls.Add(Me.ver9600n)
        Me.GroupBox1.Controls.Add(Me.ver9600)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(478, 202)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dostępne wersje:"
        '
        'verAzureStackHCIPreview
        '
        Me.verAzureStackHCIPreview.AutoSize = True
        Me.verAzureStackHCIPreview.Location = New System.Drawing.Point(197, 101)
        Me.verAzureStackHCIPreview.Name = "verAzureStackHCIPreview"
        Me.verAzureStackHCIPreview.Size = New System.Drawing.Size(153, 19)
        Me.verAzureStackHCIPreview.TabIndex = 12
        Me.verAzureStackHCIPreview.TabStop = True
        Me.verAzureStackHCIPreview.Text = "Azure Stack HCI Preview"
        Me.verAzureStackHCIPreview.UseVisualStyleBackColor = True
        '
        'verServer2022
        '
        Me.verServer2022.AutoSize = True
        Me.verServer2022.Location = New System.Drawing.Point(5, 101)
        Me.verServer2022.Name = "verServer2022"
        Me.verServer2022.Size = New System.Drawing.Size(185, 19)
        Me.verServer2022.TabIndex = 11
        Me.verServer2022.TabStop = True
        Me.verServer2022.Text = "Windows Server 2022 (Finalna)"
        Me.verServer2022.UseVisualStyleBackColor = True
        '
        'ver11
        '
        Me.ver11.AutoSize = True
        Me.ver11.Location = New System.Drawing.Point(218, 76)
        Me.ver11.Name = "ver11"
        Me.ver11.Size = New System.Drawing.Size(157, 19)
        Me.ver11.TabIndex = 10
        Me.ver11.TabStop = True
        Me.ver11.Text = "Windows 11 Dev channel"
        Me.ver11.UseVisualStyleBackColor = True
        '
        'ver11_off
        '
        Me.ver11_off.AutoSize = True
        Me.ver11_off.Location = New System.Drawing.Point(131, 76)
        Me.ver11_off.Name = "ver11_off"
        Me.ver11_off.Size = New System.Drawing.Size(89, 19)
        Me.ver11_off.TabIndex = 9
        Me.ver11_off.TabStop = True
        Me.ver11_off.Text = "Windows 11"
        Me.ver11_off.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Angielski (Stany Zjednoczone)", "Polski (Polska)"})
        Me.ComboBox1.Location = New System.Drawing.Point(285, 173)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(187, 23)
        Me.ComboBox1.Sorted = True
        Me.ComboBox1.TabIndex = 5
        '
        'ver1809
        '
        Me.ver1809.AutoSize = True
        Me.ver1809.Location = New System.Drawing.Point(4, 76)
        Me.ver1809.Name = "ver1809"
        Me.ver1809.Size = New System.Drawing.Size(116, 19)
        Me.ver1809.TabIndex = 8
        Me.ver1809.TabStop = True
        Me.ver1809.Text = "Windows 10 1809"
        Me.ver1809.UseVisualStyleBackColor = True
        '
        'ver19H1
        '
        Me.ver19H1.AutoSize = True
        Me.ver19H1.Location = New System.Drawing.Point(256, 47)
        Me.ver19H1.Name = "ver19H1"
        Me.ver19H1.Size = New System.Drawing.Size(119, 19)
        Me.ver19H1.TabIndex = 7
        Me.ver19H1.TabStop = True
        Me.ver19H1.Text = "Windows 10 19H1"
        Me.ver19H1.UseVisualStyleBackColor = True
        '
        'ver19H2
        '
        Me.ver19H2.AutoSize = True
        Me.ver19H2.Location = New System.Drawing.Point(131, 47)
        Me.ver19H2.Name = "ver19H2"
        Me.ver19H2.Size = New System.Drawing.Size(119, 19)
        Me.ver19H2.TabIndex = 6
        Me.ver19H2.TabStop = True
        Me.ver19H2.Text = "Windows 10 19H2"
        Me.ver19H2.UseVisualStyleBackColor = True
        '
        'ver20H1
        '
        Me.ver20H1.AutoSize = True
        Me.ver20H1.Location = New System.Drawing.Point(6, 47)
        Me.ver20H1.Name = "ver20H1"
        Me.ver20H1.Size = New System.Drawing.Size(119, 19)
        Me.ver20H1.TabIndex = 5
        Me.ver20H1.TabStop = True
        Me.ver20H1.Text = "Windows 10 20H1"
        Me.ver20H1.UseVisualStyleBackColor = True
        '
        'ver20h2
        '
        Me.ver20h2.AutoSize = True
        Me.ver20h2.Location = New System.Drawing.Point(338, 22)
        Me.ver20h2.Name = "ver20h2"
        Me.ver20h2.Size = New System.Drawing.Size(119, 19)
        Me.ver20h2.TabIndex = 4
        Me.ver20h2.TabStop = True
        Me.ver20h2.Text = "Windows 10 20H2"
        Me.ver20h2.UseVisualStyleBackColor = True
        '
        'ver21h1
        '
        Me.ver21h1.AutoSize = True
        Me.ver21h1.Location = New System.Drawing.Point(213, 22)
        Me.ver21h1.Name = "ver21h1"
        Me.ver21h1.Size = New System.Drawing.Size(119, 19)
        Me.ver21h1.TabIndex = 0
        Me.ver21h1.TabStop = True
        Me.ver21h1.Text = "Windows 10 21H1"
        Me.ver21h1.UseVisualStyleBackColor = True
        '
        'ver9600n
        '
        Me.ver9600n.AutoSize = True
        Me.ver9600n.Location = New System.Drawing.Point(103, 22)
        Me.ver9600n.Name = "ver9600n"
        Me.ver9600n.Size = New System.Drawing.Size(104, 19)
        Me.ver9600n.TabIndex = 1
        Me.ver9600n.TabStop = True
        Me.ver9600n.Text = "Windows 8.1 N"
        Me.ver9600n.UseVisualStyleBackColor = True
        '
        'ver9600
        '
        Me.ver9600.AutoSize = True
        Me.ver9600.Location = New System.Drawing.Point(5, 22)
        Me.ver9600.Name = "ver9600"
        Me.ver9600.Size = New System.Drawing.Size(92, 19)
        Me.ver9600.TabIndex = 2
        Me.ver9600.TabStop = True
        Me.ver9600.Text = "Windows 8.1"
        Me.ver9600.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(83, 325)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(335, 228)
        Me.WebBrowser1.TabIndex = 1
        '
        'downloadAMD64
        '
        Me.downloadAMD64.Location = New System.Drawing.Point(130, 220)
        Me.downloadAMD64.Name = "downloadAMD64"
        Me.downloadAMD64.Size = New System.Drawing.Size(113, 23)
        Me.downloadAMD64.TabIndex = 2
        Me.downloadAMD64.Text = "Pobierz x64 wersje"
        Me.downloadAMD64.UseVisualStyleBackColor = True
        '
        'download_x86
        '
        Me.download_x86.Location = New System.Drawing.Point(249, 220)
        Me.download_x86.Name = "download_x86"
        Me.download_x86.Size = New System.Drawing.Size(113, 23)
        Me.download_x86.TabIndex = 3
        Me.download_x86.Text = "Pobierz x86 wersje"
        Me.download_x86.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(18, 249)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Do pobierania Office"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(341, 249)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Pokaż okno WebBrowser"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(339, 559)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Ukryj okno WebBrowser"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(17, 275)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(88, 15)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Zobacz notatkę"
        '
        'ver11_2
        '
        Me.ver11_2.AutoSize = True
        Me.ver11_2.Location = New System.Drawing.Point(4, 126)
        Me.ver11_2.Name = "ver11_2"
        Me.ver11_2.Size = New System.Drawing.Size(174, 19)
        Me.ver11_2.TabIndex = 13
        Me.ver11_2.TabStop = True
        Me.ver11_2.Text = "Windows 11 Dev channel (2)"
        Me.ver11_2.UseVisualStyleBackColor = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(384, 274)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(104, 15)
        Me.LinkLabel2.TabIndex = 8
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Odznacz wszystkie"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 298)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.download_x86)
        Me.Controls.Add(Me.downloadAMD64)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "Pobieranie Windows"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ver21h1 As RadioButton
    Friend WithEvents ver9600n As RadioButton
    Friend WithEvents ver9600 As RadioButton
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents downloadAMD64 As Button
    Friend WithEvents download_x86 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ver20h2 As RadioButton
    Friend WithEvents ver20H1 As RadioButton
    Friend WithEvents ver19H2 As RadioButton
    Friend WithEvents ver19H1 As RadioButton
    Friend WithEvents ver1809 As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button3 As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents ver11_off As RadioButton
    Friend WithEvents ver11 As RadioButton
    Friend WithEvents verServer2022 As RadioButton
    Friend WithEvents verAzureStackHCIPreview As RadioButton
    Friend WithEvents ver11_2 As RadioButton
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
