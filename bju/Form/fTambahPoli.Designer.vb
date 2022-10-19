<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fTambahPoli
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
        Me.bSimpan = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.tNamaPoli = New MetroFramework.Controls.MetroTextBox()
        Me.bBatal = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'bSimpan
        '
        Me.bSimpan.Location = New System.Drawing.Point(183, 79)
        Me.bSimpan.Name = "bSimpan"
        Me.bSimpan.Size = New System.Drawing.Size(93, 23)
        Me.bSimpan.TabIndex = 0
        Me.bSimpan.Text = "Simpan"
        Me.bSimpan.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(31, 37)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(70, 19)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Nama Poli"
        '
        'tNamaPoli
        '
        '
        '
        '
        Me.tNamaPoli.CustomButton.Image = Nothing
        Me.tNamaPoli.CustomButton.Location = New System.Drawing.Point(127, 1)
        Me.tNamaPoli.CustomButton.Name = ""
        Me.tNamaPoli.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tNamaPoli.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tNamaPoli.CustomButton.TabIndex = 1
        Me.tNamaPoli.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tNamaPoli.CustomButton.UseSelectable = True
        Me.tNamaPoli.CustomButton.Visible = False
        Me.tNamaPoli.Lines = New String(-1) {}
        Me.tNamaPoli.Location = New System.Drawing.Point(127, 37)
        Me.tNamaPoli.MaxLength = 32767
        Me.tNamaPoli.Name = "tNamaPoli"
        Me.tNamaPoli.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tNamaPoli.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tNamaPoli.SelectedText = ""
        Me.tNamaPoli.SelectionLength = 0
        Me.tNamaPoli.SelectionStart = 0
        Me.tNamaPoli.ShortcutsEnabled = True
        Me.tNamaPoli.Size = New System.Drawing.Size(149, 23)
        Me.tNamaPoli.TabIndex = 2
        Me.tNamaPoli.UseSelectable = True
        Me.tNamaPoli.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tNamaPoli.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'bBatal
        '
        Me.bBatal.Location = New System.Drawing.Point(31, 79)
        Me.bBatal.Name = "bBatal"
        Me.bBatal.Size = New System.Drawing.Size(93, 23)
        Me.bBatal.TabIndex = 3
        Me.bBatal.Text = "Batal"
        Me.bBatal.UseSelectable = True
        '
        'fTambahPoli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(311, 156)
        Me.ControlBox = False
        Me.Controls.Add(Me.bBatal)
        Me.Controls.Add(Me.tNamaPoli)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.bSimpan)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fTambahPoli"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fTambahPoli"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bSimpan As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tNamaPoli As MetroFramework.Controls.MetroTextBox
    Friend WithEvents bBatal As MetroFramework.Controls.MetroButton
End Class
