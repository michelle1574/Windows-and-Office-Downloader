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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Ver365 = New System.Windows.Forms.RadioButton()
        Me.Ver2019 = New System.Windows.Forms.RadioButton()
        Me.Ver2016 = New System.Windows.Forms.RadioButton()
        Me.Ver2013 = New System.Windows.Forms.RadioButton()
        Me.onlineInstall = New System.Windows.Forms.CheckBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Ver2021 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Ver2021)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Ver365)
        Me.GroupBox1.Controls.Add(Me.Ver2019)
        Me.GroupBox1.Controls.Add(Me.Ver2016)
        Me.GroupBox1.Controls.Add(Me.Ver2013)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 88)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dostępne wersje"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Angielski (Stany Zjednoczone)", "Polski (Polska)"})
        Me.ComboBox1.Location = New System.Drawing.Point(194, 53)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(184, 23)
        Me.ComboBox1.Sorted = True
        Me.ComboBox1.TabIndex = 4
        '
        'Ver365
        '
        Me.Ver365.AutoSize = True
        Me.Ver365.Location = New System.Drawing.Point(285, 32)
        Me.Ver365.Name = "Ver365"
        Me.Ver365.Size = New System.Drawing.Size(78, 19)
        Me.Ver365.TabIndex = 0
        Me.Ver365.TabStop = True
        Me.Ver365.Text = "Office 365"
        Me.Ver365.UseVisualStyleBackColor = True
        '
        'Ver2019
        '
        Me.Ver2019.AutoSize = True
        Me.Ver2019.Location = New System.Drawing.Point(195, 32)
        Me.Ver2019.Name = "Ver2019"
        Me.Ver2019.Size = New System.Drawing.Size(84, 19)
        Me.Ver2019.TabIndex = 1
        Me.Ver2019.TabStop = True
        Me.Ver2019.Text = "Office 2019"
        Me.Ver2019.UseVisualStyleBackColor = True
        '
        'Ver2016
        '
        Me.Ver2016.AutoSize = True
        Me.Ver2016.Location = New System.Drawing.Point(105, 32)
        Me.Ver2016.Name = "Ver2016"
        Me.Ver2016.Size = New System.Drawing.Size(84, 19)
        Me.Ver2016.TabIndex = 2
        Me.Ver2016.TabStop = True
        Me.Ver2016.Text = "Office 2016"
        Me.Ver2016.UseVisualStyleBackColor = True
        '
        'Ver2013
        '
        Me.Ver2013.AutoSize = True
        Me.Ver2013.Location = New System.Drawing.Point(15, 32)
        Me.Ver2013.Name = "Ver2013"
        Me.Ver2013.Size = New System.Drawing.Size(84, 19)
        Me.Ver2013.TabIndex = 3
        Me.Ver2013.TabStop = True
        Me.Ver2013.Text = "Office 2013"
        Me.Ver2013.UseVisualStyleBackColor = True
        '
        'onlineInstall
        '
        Me.onlineInstall.AutoSize = True
        Me.onlineInstall.Location = New System.Drawing.Point(22, 106)
        Me.onlineInstall.Name = "onlineInstall"
        Me.onlineInstall.Size = New System.Drawing.Size(300, 19)
        Me.onlineInstall.TabIndex = 4
        Me.onlineInstall.Text = "Instalacja online (pobiera plik obrazu z instalatorem)"
        Me.onlineInstall.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 274)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(335, 228)
        Me.WebBrowser1.TabIndex = 0
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 179)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(258, 15)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Nic się nie dzieje? Nie było okna z pobieraniem?"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(12, 199)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(242, 15)
        Me.LinkLabel2.TabIndex = 8
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Instrukcja robienia wersji offline instalatorów"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(12, 131)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 45)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "ff"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(181, 131)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(166, 45)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Odznacz wszystko"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(309, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "1"
        Me.Label1.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 217)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(163, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Do pobierania Windows"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Ver2021
        '
        Me.Ver2021.AutoSize = True
        Me.Ver2021.Location = New System.Drawing.Point(15, 57)
        Me.Ver2021.Name = "Ver2021"
        Me.Ver2021.Size = New System.Drawing.Size(84, 19)
        Me.Ver2021.TabIndex = 5
        Me.Ver2021.TabStop = True
        Me.Ver2021.Text = "Office 2021"
        Me.Ver2021.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 247)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.onlineInstall)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Instalator Office"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Ver365 As RadioButton
    Friend WithEvents Ver2019 As RadioButton
    Friend WithEvents Ver2016 As RadioButton
    Friend WithEvents Ver2013 As RadioButton
    Friend WithEvents onlineInstall As CheckBox
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Ver2021 As RadioButton
End Class
