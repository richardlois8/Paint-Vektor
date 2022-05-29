<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioKotakTepi = New System.Windows.Forms.RadioButton()
        Me.ShapeIsian = New System.Windows.Forms.Panel()
        Me.ShapeTepi = New System.Windows.Forms.Panel()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.lblUkuran = New System.Windows.Forms.Label()
        Me.RadioBebas = New System.Windows.Forms.RadioButton()
        Me.RadioGaris = New System.Windows.Forms.RadioButton()
        Me.RadioKotak = New System.Windows.Forms.RadioButton()
        Me.RadioElips = New System.Windows.Forms.RadioButton()
        Me.RadioKotakIsi = New System.Windows.Forms.RadioButton()
        Me.RadioElipsIsi = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.btnBersihkan = New System.Windows.Forms.Button()
        Me.btnGbrUlang = New System.Windows.Forms.Button()
        Me.Warna6 = New System.Windows.Forms.Panel()
        Me.Warna4 = New System.Windows.Forms.Panel()
        Me.Warna5 = New System.Windows.Forms.Panel()
        Me.Warna2 = New System.Windows.Forms.Panel()
        Me.Warna3 = New System.Windows.Forms.Panel()
        Me.Warna1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BukaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioKotakTepi)
        Me.GroupBox1.Controls.Add(Me.ShapeIsian)
        Me.GroupBox1.Controls.Add(Me.ShapeTepi)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.lblUkuran)
        Me.GroupBox1.Controls.Add(Me.RadioBebas)
        Me.GroupBox1.Controls.Add(Me.RadioGaris)
        Me.GroupBox1.Controls.Add(Me.RadioKotak)
        Me.GroupBox1.Controls.Add(Me.RadioElips)
        Me.GroupBox1.Controls.Add(Me.RadioKotakIsi)
        Me.GroupBox1.Controls.Add(Me.RadioElipsIsi)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(169, 557)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tools"
        '
        'RadioKotakTepi
        '
        Me.RadioKotakTepi.AutoSize = True
        Me.RadioKotakTepi.Location = New System.Drawing.Point(37, 205)
        Me.RadioKotakTepi.Name = "RadioKotakTepi"
        Me.RadioKotakTepi.Size = New System.Drawing.Size(109, 20)
        Me.RadioKotakTepi.TabIndex = 0
        Me.RadioKotakTepi.TabStop = True
        Me.RadioKotakTepi.Text = "Kotak Isi Tepi"
        Me.RadioKotakTepi.UseVisualStyleBackColor = True
        '
        'ShapeIsian
        '
        Me.ShapeIsian.BackColor = System.Drawing.Color.White
        Me.ShapeIsian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ShapeIsian.Location = New System.Drawing.Point(90, 366)
        Me.ShapeIsian.Name = "ShapeIsian"
        Me.ShapeIsian.Size = New System.Drawing.Size(45, 46)
        Me.ShapeIsian.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.ShapeIsian, "Isian")
        '
        'ShapeTepi
        '
        Me.ShapeTepi.BackColor = System.Drawing.Color.Black
        Me.ShapeTepi.Location = New System.Drawing.Point(37, 366)
        Me.ShapeTepi.Name = "ShapeTepi"
        Me.ShapeTepi.Size = New System.Drawing.Size(45, 46)
        Me.ShapeTepi.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.ShapeTepi, "Tepi")
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(33, 282)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(113, 22)
        Me.NumericUpDown1.TabIndex = 8
        Me.NumericUpDown1.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'lblUkuran
        '
        Me.lblUkuran.AutoSize = True
        Me.lblUkuran.Location = New System.Drawing.Point(30, 251)
        Me.lblUkuran.Name = "lblUkuran"
        Me.lblUkuran.Size = New System.Drawing.Size(116, 16)
        Me.lblUkuran.TabIndex = 7
        Me.lblUkuran.Text = "Ukuran Garis Tepi"
        '
        'RadioBebas
        '
        Me.RadioBebas.AutoSize = True
        Me.RadioBebas.Checked = True
        Me.RadioBebas.Location = New System.Drawing.Point(37, 46)
        Me.RadioBebas.Name = "RadioBebas"
        Me.RadioBebas.Size = New System.Drawing.Size(68, 20)
        Me.RadioBebas.TabIndex = 1
        Me.RadioBebas.TabStop = True
        Me.RadioBebas.Text = "Bebas"
        Me.RadioBebas.UseVisualStyleBackColor = True
        '
        'RadioGaris
        '
        Me.RadioGaris.AutoSize = True
        Me.RadioGaris.Location = New System.Drawing.Point(37, 72)
        Me.RadioGaris.Name = "RadioGaris"
        Me.RadioGaris.Size = New System.Drawing.Size(60, 20)
        Me.RadioGaris.TabIndex = 2
        Me.RadioGaris.Text = "Garis"
        Me.RadioGaris.UseVisualStyleBackColor = True
        '
        'RadioKotak
        '
        Me.RadioKotak.AutoSize = True
        Me.RadioKotak.Location = New System.Drawing.Point(37, 98)
        Me.RadioKotak.Name = "RadioKotak"
        Me.RadioKotak.Size = New System.Drawing.Size(62, 20)
        Me.RadioKotak.TabIndex = 3
        Me.RadioKotak.Text = "Kotak"
        Me.RadioKotak.UseVisualStyleBackColor = True
        '
        'RadioElips
        '
        Me.RadioElips.AutoSize = True
        Me.RadioElips.Location = New System.Drawing.Point(37, 124)
        Me.RadioElips.Name = "RadioElips"
        Me.RadioElips.Size = New System.Drawing.Size(58, 20)
        Me.RadioElips.TabIndex = 4
        Me.RadioElips.Text = "Elips"
        Me.RadioElips.UseVisualStyleBackColor = True
        '
        'RadioKotakIsi
        '
        Me.RadioKotakIsi.AutoSize = True
        Me.RadioKotakIsi.Location = New System.Drawing.Point(37, 150)
        Me.RadioKotakIsi.Name = "RadioKotakIsi"
        Me.RadioKotakIsi.Size = New System.Drawing.Size(78, 20)
        Me.RadioKotakIsi.TabIndex = 5
        Me.RadioKotakIsi.Text = "Kotak Isi"
        Me.RadioKotakIsi.UseVisualStyleBackColor = True
        '
        'RadioElipsIsi
        '
        Me.RadioElipsIsi.AutoSize = True
        Me.RadioElipsIsi.Location = New System.Drawing.Point(37, 176)
        Me.RadioElipsIsi.Name = "RadioElipsIsi"
        Me.RadioElipsIsi.Size = New System.Drawing.Size(74, 20)
        Me.RadioElipsIsi.TabIndex = 6
        Me.RadioElipsIsi.Text = "Elips Isi"
        Me.RadioElipsIsi.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1057, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BaruToolStripMenuItem, Me.BukaToolStripMenuItem, Me.SimpanToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 26)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'BaruToolStripMenuItem
        '
        Me.BaruToolStripMenuItem.Name = "BaruToolStripMenuItem"
        Me.BaruToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.BaruToolStripMenuItem.Text = "Baru"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnUndo)
        Me.GroupBox2.Controls.Add(Me.btnBersihkan)
        Me.GroupBox2.Controls.Add(Me.btnGbrUlang)
        Me.GroupBox2.Controls.Add(Me.Warna6)
        Me.GroupBox2.Controls.Add(Me.Warna4)
        Me.GroupBox2.Controls.Add(Me.Warna5)
        Me.GroupBox2.Controls.Add(Me.Warna2)
        Me.GroupBox2.Controls.Add(Me.Warna3)
        Me.GroupBox2.Controls.Add(Me.Warna1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(169, 517)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(888, 68)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Warna"
        '
        'btnUndo
        '
        Me.btnUndo.Location = New System.Drawing.Point(569, 21)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(75, 32)
        Me.btnUndo.TabIndex = 3
        Me.btnUndo.Text = "Undo"
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'btnBersihkan
        '
        Me.btnBersihkan.Location = New System.Drawing.Point(650, 21)
        Me.btnBersihkan.Name = "btnBersihkan"
        Me.btnBersihkan.Size = New System.Drawing.Size(98, 32)
        Me.btnBersihkan.TabIndex = 4
        Me.btnBersihkan.Text = "Bersihkan Kanvas"
        Me.btnBersihkan.UseVisualStyleBackColor = True
        '
        'btnGbrUlang
        '
        Me.btnGbrUlang.Location = New System.Drawing.Point(754, 21)
        Me.btnGbrUlang.Name = "btnGbrUlang"
        Me.btnGbrUlang.Size = New System.Drawing.Size(122, 32)
        Me.btnGbrUlang.TabIndex = 5
        Me.btnGbrUlang.Text = "Gambar Ulang"
        Me.btnGbrUlang.UseVisualStyleBackColor = True
        '
        'Warna6
        '
        Me.Warna6.BackColor = System.Drawing.Color.White
        Me.Warna6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Warna6.Location = New System.Drawing.Point(175, 28)
        Me.Warna6.Name = "Warna6"
        Me.Warna6.Size = New System.Drawing.Size(25, 25)
        Me.Warna6.TabIndex = 6
        '
        'Warna4
        '
        Me.Warna4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Warna4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Warna4.Location = New System.Drawing.Point(113, 28)
        Me.Warna4.Name = "Warna4"
        Me.Warna4.Size = New System.Drawing.Size(25, 25)
        Me.Warna4.TabIndex = 6
        '
        'Warna5
        '
        Me.Warna5.BackColor = System.Drawing.Color.Black
        Me.Warna5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Warna5.Location = New System.Drawing.Point(144, 28)
        Me.Warna5.Name = "Warna5"
        Me.Warna5.Size = New System.Drawing.Size(25, 25)
        Me.Warna5.TabIndex = 5
        '
        'Warna2
        '
        Me.Warna2.BackColor = System.Drawing.Color.Yellow
        Me.Warna2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Warna2.Location = New System.Drawing.Point(51, 28)
        Me.Warna2.Name = "Warna2"
        Me.Warna2.Size = New System.Drawing.Size(25, 25)
        Me.Warna2.TabIndex = 4
        '
        'Warna3
        '
        Me.Warna3.BackColor = System.Drawing.Color.LawnGreen
        Me.Warna3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Warna3.Location = New System.Drawing.Point(82, 28)
        Me.Warna3.Name = "Warna3"
        Me.Warna3.Size = New System.Drawing.Size(25, 25)
        Me.Warna3.TabIndex = 5
        '
        'Warna1
        '
        Me.Warna1.BackColor = System.Drawing.Color.Red
        Me.Warna1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Warna1.Location = New System.Drawing.Point(20, 28)
        Me.Warna1.Name = "Warna1"
        Me.Warna1.Size = New System.Drawing.Size(25, 25)
        Me.Warna1.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox3.Location = New System.Drawing.Point(845, 28)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(212, 489)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Objek"
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(3, 18)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(206, 468)
        Me.TextBox1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(179, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(660, 490)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Warna"
        '
        'BukaToolStripMenuItem
        '
        Me.BukaToolStripMenuItem.Name = "BukaToolStripMenuItem"
        Me.BukaToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.BukaToolStripMenuItem.Text = "Buka"
        '
        'SimpanToolStripMenuItem
        '
        Me.SimpanToolStripMenuItem.Name = "SimpanToolStripMenuItem"
        Me.SimpanToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SimpanToolStripMenuItem.Text = "Simpan"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "txt"
        Me.OpenFileDialog1.FileName = "Gambar1"
        Me.OpenFileDialog1.Filter = "Txt | *.txt"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "txt"
        Me.SaveFileDialog1.FileName = "Gambar 1"
        Me.SaveFileDialog1.Filter = "Text | *.txt"
        Me.SaveFileDialog1.Title = "Save As"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 585)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Corat-Coret Vektor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioBebas As RadioButton
    Friend WithEvents RadioGaris As RadioButton
    Friend WithEvents RadioKotak As RadioButton
    Friend WithEvents RadioElips As RadioButton
    Friend WithEvents RadioKotakIsi As RadioButton
    Friend WithEvents RadioElipsIsi As RadioButton
    Friend WithEvents lblUkuran As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents ShapeTepi As Panel
    Friend WithEvents ShapeIsian As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Warna2 As Panel
    Friend WithEvents Warna1 As Panel
    Friend WithEvents Warna4 As Panel
    Friend WithEvents Warna3 As Panel
    Friend WithEvents Warna6 As Panel
    Friend WithEvents Warna5 As Panel
    Friend WithEvents btnUndo As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents btnGbrUlang As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BaruToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RadioKotakTepi As RadioButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BukaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
