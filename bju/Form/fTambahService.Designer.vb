<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fTambahService
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
        Dim cbJenisPoli As MetroFramework.Controls.MetroComboBox
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.bBatal = New MetroFramework.Controls.MetroButton()
        Me.bSimpan = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.tTipeService = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.tHarga = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.cbNamaPoli = New MetroFramework.Controls.MetroComboBox()
        cbJenisPoli = New MetroFramework.Controls.MetroComboBox()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(34, 41)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Jenis Poli"
        '
        'bBatal
        '
        Me.bBatal.Location = New System.Drawing.Point(34, 170)
        Me.bBatal.Name = "bBatal"
        Me.bBatal.Size = New System.Drawing.Size(101, 23)
        Me.bBatal.TabIndex = 2
        Me.bBatal.Text = "Batal"
        Me.bBatal.UseSelectable = True
        '
        'bSimpan
        '
        Me.bSimpan.Location = New System.Drawing.Point(263, 170)
        Me.bSimpan.Name = "bSimpan"
        Me.bSimpan.Size = New System.Drawing.Size(96, 23)
        Me.bSimpan.TabIndex = 3
        Me.bSimpan.Text = "Simpan"
        Me.bSimpan.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(34, 76)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(116, 19)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Nama Poli Service"
        '
        'tTipeService
        '
        '
        '
        '
        Me.tTipeService.CustomButton.Image = Nothing
        Me.tTipeService.CustomButton.Location = New System.Drawing.Point(165, 1)
        Me.tTipeService.CustomButton.Name = ""
        Me.tTipeService.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tTipeService.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tTipeService.CustomButton.TabIndex = 1
        Me.tTipeService.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tTipeService.CustomButton.UseSelectable = True
        Me.tTipeService.CustomButton.Visible = False
        Me.tTipeService.Lines = New String(-1) {}
        Me.tTipeService.Location = New System.Drawing.Point(172, 101)
        Me.tTipeService.MaxLength = 32767
        Me.tTipeService.Name = "tTipeService"
        Me.tTipeService.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tTipeService.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tTipeService.SelectedText = ""
        Me.tTipeService.SelectionLength = 0
        Me.tTipeService.SelectionStart = 0
        Me.tTipeService.ShortcutsEnabled = True
        Me.tTipeService.Size = New System.Drawing.Size(187, 23)
        Me.tTipeService.TabIndex = 11
        Me.tTipeService.UseSelectable = True
        Me.tTipeService.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tTipeService.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(34, 105)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(80, 19)
        Me.MetroLabel4.TabIndex = 10
        Me.MetroLabel4.Text = "Tipe Service"
        '
        'tHarga
        '
        '
        '
        '
        Me.tHarga.CustomButton.Image = Nothing
        Me.tHarga.CustomButton.Location = New System.Drawing.Point(165, 1)
        Me.tHarga.CustomButton.Name = ""
        Me.tHarga.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tHarga.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tHarga.CustomButton.TabIndex = 1
        Me.tHarga.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tHarga.CustomButton.UseSelectable = True
        Me.tHarga.CustomButton.Visible = False
        Me.tHarga.Lines = New String(-1) {}
        Me.tHarga.Location = New System.Drawing.Point(172, 130)
        Me.tHarga.MaxLength = 32767
        Me.tHarga.Name = "tHarga"
        Me.tHarga.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tHarga.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tHarga.SelectedText = ""
        Me.tHarga.SelectionLength = 0
        Me.tHarga.SelectionStart = 0
        Me.tHarga.ShortcutsEnabled = True
        Me.tHarga.Size = New System.Drawing.Size(187, 23)
        Me.tHarga.TabIndex = 9
        Me.tHarga.UseSelectable = True
        Me.tHarga.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tHarga.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(34, 134)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel5.TabIndex = 8
        Me.MetroLabel5.Text = "Harga"
        '
        'cbJenisPoli
        '
        cbJenisPoli.FormattingEnabled = True
        cbJenisPoli.ItemHeight = 23
        cbJenisPoli.Location = New System.Drawing.Point(172, 31)
        cbJenisPoli.Name = "cbJenisPoli"
        cbJenisPoli.Size = New System.Drawing.Size(187, 29)
        cbJenisPoli.TabIndex = 12
        cbJenisPoli.UseSelectable = True
        '
        'cbNamaPoli
        '
        Me.cbNamaPoli.FormattingEnabled = True
        Me.cbNamaPoli.ItemHeight = 23
        Me.cbNamaPoli.Location = New System.Drawing.Point(172, 66)
        Me.cbNamaPoli.Name = "cbNamaPoli"
        Me.cbNamaPoli.Size = New System.Drawing.Size(187, 29)
        Me.cbNamaPoli.TabIndex = 13
        Me.cbNamaPoli.UseSelectable = True
        '
        'fTambahService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(393, 230)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbNamaPoli)
        Me.Controls.Add(cbJenisPoli)
        Me.Controls.Add(Me.tTipeService)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.tHarga)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.bSimpan)
        Me.Controls.Add(Me.bBatal)
        Me.Controls.Add(Me.MetroLabel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fTambahService"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fTambahService"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents bBatal As MetroFramework.Controls.MetroButton
    Friend WithEvents bSimpan As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tTipeService As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tHarga As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbNamaPoli As MetroFramework.Controls.MetroComboBox
End Class
