<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestMainUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TestMainUI))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelShow = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InputPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPasienToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataDokterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataLayananObatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdukReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IDReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DokterReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StrukReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RekamMedisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProsesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeriksaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApotikToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QrScanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarcodeScanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelShow.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(150, 476)
        Me.PanelMenu.TabIndex = 0
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(150, 81)
        Me.PanelLogo.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(18, -26)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelShow
        '
        Me.PanelShow.BackColor = System.Drawing.SystemColors.Info
        Me.PanelShow.Controls.Add(Me.MenuStrip1)
        Me.PanelShow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelShow.Location = New System.Drawing.Point(150, 0)
        Me.PanelShow.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelShow.Name = "PanelShow"
        Me.PanelShow.Size = New System.Drawing.Size(848, 476)
        Me.PanelShow.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputPageToolStripMenuItem, Me.ReportToolStripMenuItem, Me.ProsesToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.LoginToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(381, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InputPageToolStripMenuItem
        '
        Me.InputPageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataPasienToolStripMenuItem, Me.DataDokterToolStripMenuItem, Me.DataLayananObatToolStripMenuItem})
        Me.InputPageToolStripMenuItem.Name = "InputPageToolStripMenuItem"
        Me.InputPageToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.InputPageToolStripMenuItem.Text = "Input Page"
        '
        'DataPasienToolStripMenuItem
        '
        Me.DataPasienToolStripMenuItem.Name = "DataPasienToolStripMenuItem"
        Me.DataPasienToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.DataPasienToolStripMenuItem.Text = "Data pasien"
        '
        'DataDokterToolStripMenuItem
        '
        Me.DataDokterToolStripMenuItem.Name = "DataDokterToolStripMenuItem"
        Me.DataDokterToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.DataDokterToolStripMenuItem.Text = "Data Dokter"
        '
        'DataLayananObatToolStripMenuItem
        '
        Me.DataLayananObatToolStripMenuItem.Name = "DataLayananObatToolStripMenuItem"
        Me.DataLayananObatToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.DataLayananObatToolStripMenuItem.Text = "Data Layanan Obat"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProdukReportToolStripMenuItem, Me.IDReportToolStripMenuItem, Me.DokterReportToolStripMenuItem, Me.StrukReportToolStripMenuItem, Me.RekamMedisToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'ProdukReportToolStripMenuItem
        '
        Me.ProdukReportToolStripMenuItem.Name = "ProdukReportToolStripMenuItem"
        Me.ProdukReportToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProdukReportToolStripMenuItem.Text = "Produk Report"
        '
        'IDReportToolStripMenuItem
        '
        Me.IDReportToolStripMenuItem.Name = "IDReportToolStripMenuItem"
        Me.IDReportToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IDReportToolStripMenuItem.Text = "ID report"
        '
        'DokterReportToolStripMenuItem
        '
        Me.DokterReportToolStripMenuItem.Name = "DokterReportToolStripMenuItem"
        Me.DokterReportToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DokterReportToolStripMenuItem.Text = "Dokter Report"
        '
        'StrukReportToolStripMenuItem
        '
        Me.StrukReportToolStripMenuItem.Name = "StrukReportToolStripMenuItem"
        Me.StrukReportToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StrukReportToolStripMenuItem.Text = "Struk Report"
        '
        'RekamMedisToolStripMenuItem
        '
        Me.RekamMedisToolStripMenuItem.Name = "RekamMedisToolStripMenuItem"
        Me.RekamMedisToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RekamMedisToolStripMenuItem.Text = "Rekam Medis "
        '
        'ProsesToolStripMenuItem
        '
        Me.ProsesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PeriksaToolStripMenuItem, Me.ApotikToolStripMenuItem, Me.TransaksiToolStripMenuItem})
        Me.ProsesToolStripMenuItem.Name = "ProsesToolStripMenuItem"
        Me.ProsesToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ProsesToolStripMenuItem.Text = "Proses "
        '
        'PeriksaToolStripMenuItem
        '
        Me.PeriksaToolStripMenuItem.Name = "PeriksaToolStripMenuItem"
        Me.PeriksaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PeriksaToolStripMenuItem.Text = "Periksa"
        '
        'ApotikToolStripMenuItem
        '
        Me.ApotikToolStripMenuItem.Name = "ApotikToolStripMenuItem"
        Me.ApotikToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ApotikToolStripMenuItem.Text = "Apotik"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QrScanToolStripMenuItem, Me.BarcodeScanToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'QrScanToolStripMenuItem
        '
        Me.QrScanToolStripMenuItem.Name = "QrScanToolStripMenuItem"
        Me.QrScanToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.QrScanToolStripMenuItem.Text = "Qr Scan"
        '
        'BarcodeScanToolStripMenuItem
        '
        Me.BarcodeScanToolStripMenuItem.Name = "BarcodeScanToolStripMenuItem"
        Me.BarcodeScanToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BarcodeScanToolStripMenuItem.Text = "Barcode Scan"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem1, Me.RegisterToolStripMenuItem})
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LoginToolStripMenuItem1
        '
        Me.LoginToolStripMenuItem1.Name = "LoginToolStripMenuItem1"
        Me.LoginToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.LoginToolStripMenuItem1.Text = "login"
        '
        'RegisterToolStripMenuItem
        '
        Me.RegisterToolStripMenuItem.Name = "RegisterToolStripMenuItem"
        Me.RegisterToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RegisterToolStripMenuItem.Text = "Register"
        '
        'TestMainUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 476)
        Me.Controls.Add(Me.PanelShow)
        Me.Controls.Add(Me.PanelMenu)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "TestMainUI"
        Me.Text = "TestMainUI"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelShow.ResumeLayout(False)
        Me.PanelShow.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelShow As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataPasienToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataDokterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataLayananObatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdukReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IDReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DokterReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StrukReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RekamMedisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProsesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PeriksaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApotikToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QrScanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarcodeScanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RegisterToolStripMenuItem As ToolStripMenuItem
End Class
