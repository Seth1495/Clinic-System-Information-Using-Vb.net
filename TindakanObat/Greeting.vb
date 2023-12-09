Public Class Greeting
    Private Sub GunaTransfarantPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaTransfarantPictureBox1.Click

        Dim url As String = "https://www.halodoc.com/artikel/uji-vaksin-sinovac-diklaim-efektif-hingga-80-persen"

        Process.Start(url)
    End Sub

    Private Sub GunaTransfarantPictureBox2_Click(sender As Object, e As EventArgs) Handles GunaTransfarantPictureBox2.Click
        Dim url As String = "https://health.kompas.com/read/23G06103000868/12-pemicu-gula-darah-tinggi-dari-makanan-hingga-kondisi-medis"

        Process.Start(url)
    End Sub

    Private Sub GunaTransfarantPictureBox3_Click(sender As Object, e As EventArgs) Handles GunaTransfarantPictureBox3.Click
        Dim url As String = "https://health.kompas.com/read/23G06171225168/mengenal-microbotox-manfaat-dan-potensi-efek-samping"

        Process.Start(url)
    End Sub

    Private Sub GunaTransfarantPictureBox4_Click(sender As Object, e As EventArgs) Handles GunaTransfarantPictureBox4.Click
        Dim url As String = "https://www.halodoc.com/artikel/susu-skim-vs-susu-murni-mana-yang-lebih-menyehatkan-tubuh"

        Process.Start(url)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim url As String = "https://www.idionline.org/"

        Process.Start(url)
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Dim url As String = "https://peraturan.bpk.go.id/Home/Download/28099/UU%20Nomor%2036%20Tahun%202014.pdf"

        Process.Start(url)
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Dim url As String = "https://hmti-unsoed.org/"

        Process.Start(url)
    End Sub
End Class