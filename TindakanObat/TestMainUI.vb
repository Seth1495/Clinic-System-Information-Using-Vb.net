Public Class TestMainUI
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        dataDokterForm.TopLevel = False
        PanelShow.Controls.Add(dataDokterForm)
        dataDokterForm.BringToFront()
        dataDokterForm.Show()
    End Sub

    Private Sub ButtonLO_Click(sender As Object, e As EventArgs)
        dataLayananObat.TopLevel = False
        PanelShow.Controls.Add(dataLayananObat)
        dataLayananObat.BringToFront()
        dataLayananObat.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dokterreport.TopLevel = False
        PanelShow.Controls.Add(Dokterreport)
        Dokterreport.BringToFront()
        Dokterreport.Show()
    End Sub

    Private Sub DataPasienToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPasienToolStripMenuItem.Click
        Pasien.TopLevel = False
        PanelShow.Controls.Add(Pasien)
        Pasien.BringToFront()
        Pasien.Show()
    End Sub

    Private Sub DataDokterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataDokterToolStripMenuItem.Click
        dataDokterForm.TopLevel = False
        PanelShow.Controls.Add(dataDokterForm)
        dataDokterForm.BringToFront()
        dataDokterForm.Show()
    End Sub

    Private Sub DataLayananObatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataLayananObatToolStripMenuItem.Click
        dataLayananObat.TopLevel = False
        PanelShow.Controls.Add(dataLayananObat)
        dataLayananObat.BringToFront()
        dataLayananObat.Show()
    End Sub

    Private Sub ProdukReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdukReportToolStripMenuItem.Click
        Report.TopLevel = False
        PanelShow.Controls.Add(Report)
        Report.BringToFront()
        Report.Show()
    End Sub

    Private Sub IDReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IDReportToolStripMenuItem.Click
        KartuDokter.TopLevel = False
        PanelShow.Controls.Add(KartuDokter)
        KartuDokter.BringToFront()
        KartuDokter.Show()
    End Sub

    Private Sub DokterReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DokterReportToolStripMenuItem.Click
        Dokterreport.TopLevel = False
        PanelShow.Controls.Add(Dokterreport)
        Dokterreport.BringToFront()
        Dokterreport.Show()
    End Sub
    Private Sub StrukReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StrukReportToolStripMenuItem.Click
        Penjualan.TopLevel = False
        PanelShow.Controls.Add(Penjualan)
        Penjualan.BringToFront()
        Penjualan.Show()
    End Sub

    Private Sub RekamMedisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RekamMedisToolStripMenuItem.Click
        RekamMedis.TopLevel = False
        PanelShow.Controls.Add(RekamMedis)
        RekamMedis.BringToFront()
        RekamMedis.Show()
    End Sub

    Private Sub PeriksaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeriksaToolStripMenuItem.Click
        Periksa.TopLevel = False
        PanelShow.Controls.Add(Periksa)
        Periksa.BringToFront()
        Periksa.Show()
    End Sub

    Private Sub ApotikToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApotikToolStripMenuItem.Click
        Apotek.TopLevel = False
        PanelShow.Controls.Add(Apotek)
        Apotek.BringToFront()
        Apotek.Show()
    End Sub

    Private Sub TransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiToolStripMenuItem.Click
        Transaksi.TopLevel = False
        PanelShow.Controls.Add(Transaksi)
        Transaksi.BringToFront()
        Transaksi.Show()
    End Sub

    Private Sub QrScanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QrScanToolStripMenuItem.Click
        QRscan.TopLevel = False
        PanelShow.Controls.Add(QRscan)
        QRscan.BringToFront()
        QRscan.Show()
    End Sub

    Private Sub BarcodeScanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarcodeScanToolStripMenuItem.Click
        Barcodescan.TopLevel = False
        PanelShow.Controls.Add(Barcodescan)
        Barcodescan.BringToFront()
        Barcodescan.Show()
    End Sub

    Private Sub LoginToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem1.Click
        loginForm.TopLevel = False
        PanelShow.Controls.Add(loginForm)
        loginForm.BringToFront()
        loginForm.Show()
    End Sub

    Private Sub RegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterToolStripMenuItem.Click
        RegisterForm.TopLevel = False
        PanelShow.Controls.Add(RegisterForm)
        RegisterForm.BringToFront()
        RegisterForm.Show()
    End Sub
End Class