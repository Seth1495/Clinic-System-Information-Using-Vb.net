Public Class MainMenuDokter
    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Panel1.Show()
        GunaButton2.ForeColor = Color.DarkCyan
        GunaButton1.ForeColor = Color.Gray
        GunaButton3.ForeColor = Color.Gray
        GunaButton4.ForeColor = Color.Gray
        If Panel2.Visible = True Then Panel2.Hide()
        If Panel3.Visible = True Then Panel3.Hide()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Hide()
        Panel2.Hide()
        Panel3.Hide()
        Greeting.TopLevel = False
        PanelShow.Controls.Add(Greeting)
        Greeting.BringToFront()
        Greeting.Show()
    End Sub

    Private Sub GunaButton7_Click(sender As Object, e As EventArgs) Handles GunaButton7.Click
        Panel1.Hide()
        Periksa.TopLevel = False
        PanelShow.Controls.Add(Periksa)
        Periksa.BringToFront()
        Periksa.Show()
    End Sub

    Private Sub GunaButton5_Click(sender As Object, e As EventArgs) Handles GunaButton5.Click
        Panel1.Hide()
        Apotek.TopLevel = False
        PanelShow.Controls.Add(Apotek)
        Apotek.BringToFront()
        Apotek.Show()
    End Sub

    Private Sub GunaButton6_Click(sender As Object, e As EventArgs) Handles GunaButton6.Click
        Panel1.Hide()
        Transaksi.TopLevel = False
        PanelShow.Controls.Add(Transaksi)
        Transaksi.BringToFront()
        Transaksi.Show()
    End Sub

    Private Sub GunaButton10_Click(sender As Object, e As EventArgs) Handles GunaButton10.Click
        Panel2.Hide()
        Barcodescan.TopLevel = False
        PanelShow.Controls.Add(Barcodescan)
        Barcodescan.BringToFront()
        Barcodescan.Show()
    End Sub

    Private Sub GunaButton9_Click(sender As Object, e As EventArgs) Handles GunaButton9.Click
        Panel2.Hide()
        QRscan.TopLevel = False
        PanelShow.Controls.Add(QRscan)
        QRscan.BringToFront()
        QRscan.Show()
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Panel2.Show()
        GunaButton1.ForeColor = Color.DarkCyan
        GunaButton2.ForeColor = Color.Gray
        GunaButton3.ForeColor = Color.Gray
        GunaButton4.ForeColor = Color.Gray
        If Panel3.Visible = True Then Panel3.Hide()
        If Panel1.Visible = True Then Panel1.Hide()
    End Sub

    Private Sub GunaButton11_Click(sender As Object, e As EventArgs) Handles GunaButton11.Click
        Panel3.Hide()
        Report.TopLevel = False
        PanelShow.Controls.Add(Report)
        Report.BringToFront()
        Report.Show()
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        Panel3.Show()
        GunaButton3.ForeColor = Color.DarkCyan
        GunaButton2.ForeColor = Color.Gray
        GunaButton1.ForeColor = Color.Gray
        GunaButton4.ForeColor = Color.Gray
        If Panel2.Visible = True Then Panel2.Hide()
        If Panel1.Visible = True Then Panel1.Hide()
    End Sub

    Private Sub GunaButton8_Click(sender As Object, e As EventArgs) Handles GunaButton8.Click
        Panel3.Hide()
        KartuDokter.TopLevel = False
        PanelShow.Controls.Add(KartuDokter)
        KartuDokter.BringToFront()
        KartuDokter.Show()
    End Sub

    Private Sub GunaButton12_Click(sender As Object, e As EventArgs) Handles GunaButton12.Click
        Panel3.Hide()
        Dokterreport.TopLevel = False
        PanelShow.Controls.Add(Dokterreport)
        Dokterreport.BringToFront()
        Dokterreport.Show()
    End Sub

    Private Sub GunaButton13_Click(sender As Object, e As EventArgs) Handles GunaButton13.Click
        Panel3.Hide()
        Penjualan.TopLevel = False
        PanelShow.Controls.Add(Penjualan)
        Penjualan.BringToFront()
        Penjualan.Show()
    End Sub

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        GunaButton4.ForeColor = Color.DarkCyan
        GunaButton2.ForeColor = Color.Gray
        GunaButton1.ForeColor = Color.Gray
        GunaButton3.ForeColor = Color.Gray
        If Panel2.Visible = True Then Panel2.Hide()
        If Panel1.Visible = True Then Panel1.Hide()
        If Panel3.Visible = True Then Panel3.Hide()
        RekamMedis.TopLevel = False
        PanelShow.Controls.Add(RekamMedis)
        RekamMedis.BringToFront()
        RekamMedis.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Restart()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Greeting.TopLevel = False
        PanelShow.Controls.Add(Greeting)
        Greeting.BringToFront()
        Greeting.Show()
        If Panel2.Visible = True Then Panel2.Hide()
        If Panel1.Visible = True Then Panel1.Hide()
        If Panel3.Visible = True Then Panel3.Hide()
    End Sub
End Class