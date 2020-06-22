<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.flowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtKontak = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtPesan = New System.Windows.Forms.TextBox()
        Me.flowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnKirim = New System.Windows.Forms.Button()
        Me.txtJumlahPesan = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.tableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.flowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.chkSubscribe = New System.Windows.Forms.CheckBox()
        Me.chkAutoReplay = New System.Windows.Forms.CheckBox()
        Me.lstPesanMasuk = New System.Windows.Forms.ListBox()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.flowLayoutPanel1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.tableLayoutPanel2.SuspendLayout()
        Me.flowLayoutPanel2.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.tableLayoutPanel3.SuspendLayout()
        Me.flowLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 1
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.flowLayoutPanel1, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.groupBox1, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.groupBox2, 0, 2)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 3
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(536, 462)
        Me.tableLayoutPanel1.TabIndex = 1
        '
        'flowLayoutPanel1
        '
        Me.flowLayoutPanel1.Controls.Add(Me.btnStart)
        Me.flowLayoutPanel1.Controls.Add(Me.btnStop)
        Me.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
        Me.flowLayoutPanel1.Size = New System.Drawing.Size(530, 29)
        Me.flowLayoutPanel1.TabIndex = 0
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(3, 3)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Location = New System.Drawing.Point(84, 3)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.tableLayoutPanel2)
        Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupBox1.Location = New System.Drawing.Point(3, 38)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(530, 104)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = " [ Kirim Pesan ] "
        '
        'tableLayoutPanel2
        '
        Me.tableLayoutPanel2.ColumnCount = 2
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutPanel2.Controls.Add(Me.label1, 0, 0)
        Me.tableLayoutPanel2.Controls.Add(Me.txtKontak, 1, 0)
        Me.tableLayoutPanel2.Controls.Add(Me.label3, 0, 1)
        Me.tableLayoutPanel2.Controls.Add(Me.txtPesan, 1, 1)
        Me.tableLayoutPanel2.Controls.Add(Me.flowLayoutPanel2, 1, 2)
        Me.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
        Me.tableLayoutPanel2.RowCount = 3
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tableLayoutPanel2.Size = New System.Drawing.Size(524, 85)
        Me.tableLayoutPanel2.TabIndex = 0
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label1.Location = New System.Drawing.Point(3, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(41, 25)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Kontak"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtKontak
        '
        Me.txtKontak.Location = New System.Drawing.Point(50, 3)
        Me.txtKontak.Name = "txtKontak"
        Me.txtKontak.Size = New System.Drawing.Size(167, 20)
        Me.txtKontak.TabIndex = 0
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label3.Location = New System.Drawing.Point(3, 25)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(41, 25)
        Me.label3.TabIndex = 0
        Me.label3.Text = "Pesan"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPesan
        '
        Me.txtPesan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPesan.Location = New System.Drawing.Point(50, 28)
        Me.txtPesan.Name = "txtPesan"
        Me.txtPesan.Size = New System.Drawing.Size(471, 20)
        Me.txtPesan.TabIndex = 1
        Me.txtPesan.Text = "Tes kirim pesan dari aplikasi"
        '
        'flowLayoutPanel2
        '
        Me.flowLayoutPanel2.Controls.Add(Me.btnKirim)
        Me.flowLayoutPanel2.Controls.Add(Me.txtJumlahPesan)
        Me.flowLayoutPanel2.Controls.Add(Me.label2)
        Me.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.flowLayoutPanel2.Location = New System.Drawing.Point(50, 53)
        Me.flowLayoutPanel2.Name = "flowLayoutPanel2"
        Me.flowLayoutPanel2.Size = New System.Drawing.Size(471, 29)
        Me.flowLayoutPanel2.TabIndex = 2
        '
        'btnKirim
        '
        Me.btnKirim.Enabled = False
        Me.btnKirim.Location = New System.Drawing.Point(393, 3)
        Me.btnKirim.Name = "btnKirim"
        Me.btnKirim.Size = New System.Drawing.Size(75, 23)
        Me.btnKirim.TabIndex = 2
        Me.btnKirim.Text = "Kirim"
        Me.btnKirim.UseVisualStyleBackColor = True
        '
        'txtJumlahPesan
        '
        Me.txtJumlahPesan.Location = New System.Drawing.Point(362, 3)
        Me.txtJumlahPesan.Name = "txtJumlahPesan"
        Me.txtJumlahPesan.Size = New System.Drawing.Size(25, 20)
        Me.txtJumlahPesan.TabIndex = 1
        Me.txtJumlahPesan.Text = "1"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label2.Location = New System.Drawing.Point(283, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(73, 29)
        Me.label2.TabIndex = 0
        Me.label2.Text = "Jumlah Pesan"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.tableLayoutPanel3)
        Me.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupBox2.Location = New System.Drawing.Point(3, 148)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(530, 311)
        Me.groupBox2.TabIndex = 2
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = " [ Pesan Masuk ] "
        '
        'tableLayoutPanel3
        '
        Me.tableLayoutPanel3.ColumnCount = 1
        Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel3.Controls.Add(Me.flowLayoutPanel3, 0, 0)
        Me.tableLayoutPanel3.Controls.Add(Me.lstPesanMasuk, 0, 1)
        Me.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel3.Location = New System.Drawing.Point(3, 16)
        Me.tableLayoutPanel3.Name = "tableLayoutPanel3"
        Me.tableLayoutPanel3.RowCount = 2
        Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel3.Size = New System.Drawing.Size(524, 292)
        Me.tableLayoutPanel3.TabIndex = 0
        '
        'flowLayoutPanel3
        '
        Me.flowLayoutPanel3.Controls.Add(Me.chkSubscribe)
        Me.flowLayoutPanel3.Controls.Add(Me.chkAutoReplay)
        Me.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.flowLayoutPanel3.Name = "flowLayoutPanel3"
        Me.flowLayoutPanel3.Size = New System.Drawing.Size(518, 20)
        Me.flowLayoutPanel3.TabIndex = 0
        '
        'chkSubscribe
        '
        Me.chkSubscribe.AutoSize = True
        Me.chkSubscribe.Enabled = False
        Me.chkSubscribe.Location = New System.Drawing.Point(3, 3)
        Me.chkSubscribe.Name = "chkSubscribe"
        Me.chkSubscribe.Size = New System.Drawing.Size(73, 17)
        Me.chkSubscribe.TabIndex = 0
        Me.chkSubscribe.Text = "Subscribe"
        Me.chkSubscribe.UseVisualStyleBackColor = True
        '
        'chkAutoReplay
        '
        Me.chkAutoReplay.AutoSize = True
        Me.chkAutoReplay.Enabled = False
        Me.chkAutoReplay.Location = New System.Drawing.Point(82, 3)
        Me.chkAutoReplay.Name = "chkAutoReplay"
        Me.chkAutoReplay.Size = New System.Drawing.Size(84, 17)
        Me.chkAutoReplay.TabIndex = 1
        Me.chkAutoReplay.Text = "Auto Replay"
        Me.chkAutoReplay.UseVisualStyleBackColor = True
        '
        'lstPesanMasuk
        '
        Me.lstPesanMasuk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstPesanMasuk.FormattingEnabled = True
        Me.lstPesanMasuk.Location = New System.Drawing.Point(3, 29)
        Me.lstPesanMasuk.Name = "lstPesanMasuk"
        Me.lstPesanMasuk.Size = New System.Drawing.Size(518, 260)
        Me.lstPesanMasuk.TabIndex = 1
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 462)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Demo WhatsAppAPI untuk .NET Developer (VB.NET)"
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.flowLayoutPanel1.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.tableLayoutPanel2.ResumeLayout(False)
        Me.tableLayoutPanel2.PerformLayout()
        Me.flowLayoutPanel2.ResumeLayout(False)
        Me.flowLayoutPanel2.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.tableLayoutPanel3.ResumeLayout(False)
        Me.flowLayoutPanel3.ResumeLayout(False)
        Me.flowLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents flowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Private WithEvents btnStart As System.Windows.Forms.Button
    Private WithEvents btnStop As System.Windows.Forms.Button
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txtKontak As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents txtPesan As System.Windows.Forms.TextBox
    Private WithEvents flowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Private WithEvents btnKirim As System.Windows.Forms.Button
    Private WithEvents txtJumlahPesan As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents tableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents flowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Private WithEvents chkSubscribe As System.Windows.Forms.CheckBox
    Private WithEvents chkAutoReplay As System.Windows.Forms.CheckBox
    Private WithEvents lstPesanMasuk As System.Windows.Forms.ListBox

End Class
