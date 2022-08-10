<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtKullaniciAdi = New System.Windows.Forms.TextBox()
        Me.TxtParola = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtKullaniciAdi
        '
        Me.TxtKullaniciAdi.Location = New System.Drawing.Point(183, 94)
        Me.TxtKullaniciAdi.MaxLength = 16
        Me.TxtKullaniciAdi.Name = "TxtKullaniciAdi"
        Me.TxtKullaniciAdi.Size = New System.Drawing.Size(100, 20)
        Me.TxtKullaniciAdi.TabIndex = 0
        '
        'TxtParola
        '
        Me.TxtParola.Location = New System.Drawing.Point(183, 121)
        Me.TxtParola.MaxLength = 8
        Me.TxtParola.Name = "TxtParola"
        Me.TxtParola.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtParola.Size = New System.Drawing.Size(100, 20)
        Me.TxtParola.TabIndex = 1
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(183, 148)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(100, 23)
        Me.BtnLogin.TabIndex = 2
        Me.BtnLogin.Text = "Giriş Yap"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(113, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Kullanıcı Adı"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(113, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Parola"
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(12, 222)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 5
        Me.BtnClose.Text = "Kapat"
        Me.BtnClose.UseVisualStyleBackColor = True
        Me.BtnClose.Visible = False
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.BtnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.KuaforOtomasyonuV5.My.Resources.Resources.cartoon_hairdresser_at_work
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(352, 276)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.TxtParola)
        Me.Controls.Add(Me.TxtKullaniciAdi)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Giriş Formu"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtKullaniciAdi As TextBox
    Friend WithEvents TxtParola As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnClose As Button
End Class
