Imports System.Data.OleDb

Public Class Transaksi
    Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
    Dim BR_Generator As New MessagingToolkit.Barcode.BarcodeEncoder
    Dim lokasibarcodeatauQR As String
    Sub CetakBarcodeatauQR()
        BR_Generator.IncludeLabel = True
        BR_Generator.CustomLabel = Apotek.TextBox3.Text
        Try
            'jika ingin Barcode
            'PictureBox1.Image = 
            '   BR_Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128, TextBox1.Text)
            'jika ingin QR
            PictureBox1.Image = QR_Generator.Encode(TextBox1.Text)
        Catch ex As Exception
        End Try
    End Sub

    Sub join()
        Call koneksiDb()
        Dim query As String = "SELECT SIP, Nama_dokter, Kode_pasien, Nama_pasien FROM Query_DataPenjualan where Kode_transaksi ='" & TextBox1.Text & "'"
        ' command = New OleDb.OleDbCommand(" delete from DataDokter where SIP ='" & TextBox1.Text & "'", conn)
        command = New OleDb.OleDbCommand(query, conn)
        dataAdapter = New OleDb.OleDbDataAdapter(command)
        dataSet = New DataSet()
        dataAdapter.Fill(dataSet)

        Try
            Dim dataTable As DataTable = dataSet.Tables(0)
            For Each row As DataRow In dataTable.Rows
                Dim nilaiKolom1 As String = row("SIP").ToString()
                Dim nilaiKolom2 As String = row("Nama_dokter").ToString()
                Dim nilaiKolom3 As String = row("Kode_pasien").ToString()
                Dim nilaiKolom4 As String = row("Nama_pasien").ToString()
                TextBox4.Text = nilaiKolom1
                TextBox5.Text = nilaiKolom2
                TextBox17.Text = nilaiKolom3
                TextBox2.Text = nilaiKolom4
            Next
        Catch ex As Exception
            MsgBox("Data dokter gagal masuk")
        End Try

    End Sub

    Sub HitungTotal()
        Dim hitungitem As Integer = 0
        For i As Integer = 0 To DGV4.Rows.Count - 1
            hitungitem += DGV4.Rows(i).Cells(4).Value
            TextBox9.Text = hitungitem
        Next


    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim waktu As TimeSpan = DateTimePicker1.Value.TimeOfDay
        Dim formattedTime As String = waktu.ToString("hh\:mm\:ss")
        Dim selectedDate As DateTime = DateTimePicker1.Value.Date
        Dim formattedDate As String = selectedDate.ToShortDateString()

        TextBox8.Text = formattedTime
        TextBox7.Text = formattedDate


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Barcodescan.Show()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Call koneksiDb()
        Call join()
        command = New OleDbCommand("select Kode_LO, Nama_LO,Jumlah, Harga, (Jumlah * Harga) AS Total from DataPenjualan where Kode_transaksi = '" & TextBox1.Text & "'", conn)
        Try
            dataAdapter = New OleDbDataAdapter(command)
            Dim dataTable = New DataTable()
            dataAdapter.Fill(dataTable)
            'dataSet = New DataSet
            'CMD = New OleDb.OleDbCommand(sq12, Conn)
            'CMD. ExecuteNonQuery()
            Dim SRT As New DataTable
            SRT.Clear()
            dataAdapter.Fill(SRT)
            DGV4.DataSource = SRT
        Catch ex As Exception
            MsgBox("Error tod")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim bayar As Integer = TextBox15.Text
        Dim tagihan As Integer = TextBox9.Text
        Dim inputppn As String = TextBox14.Text
        Dim total As Double
        Dim ppn As Single
        ppn = Single.Parse(inputppn.TrimEnd("%")) / 100
        Dim kembali As Double

        If bayar < tagihan + (tagihan * ppn) Then
            MsgBox("Uang Pembayaran Kurang")
        ElseIf tagihan + (tagihan * ppn) < bayar Then
            kembali = bayar - (tagihan * ppn) - tagihan
            total = tagihan + (tagihan * ppn)
            Call CetakBarcodeatauQR()
        End If

        TextBox16.Text = kembali
        TextBox6.Text = total

        ''coding tambahan
        Dim SD As New SaveFileDialog
        SD.Filter = "Image File (*.jpeg;*jpg;*.png;*.bmp;)| *.jpeg;*jpg;*.png;*.bmp;"
        If SD.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                'PictureBox1 utk Barcode
                PictureBox1.Image.Save(SD.FileName, Imaging.ImageFormat.Png)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            lokasibarcodeatauQR = SD.FileName
        Else
            MsgBox("Barcode harus disimpan")
            Exit Sub
        End If


        'coding input db
        Call koneksiDb()
        command = New OleDb.OleDbCommand(" select * from DetailTransaksi where Kode_transaksi ='" & TextBox1.Text & "'", conn)
        dataReader = command.ExecuteReader
        dataReader.Read()

        Try
            If Not dataReader.HasRows Then
                Call koneksiDb()
                Dim simpan As String
                simpan = "insert into DetailTransaksi values ('" &
               TextBox1.Text & "', '" & TextBox3.Text & "', '" &
               TextBox7.Text & "','" & TextBox8.Text & "','" &
               TextBox9.Text & "','" & TextBox14.Text & "','" & TextBox6.Text & "','" & TextBox15.Text & "', '" & TextBox16.Text & "','" & lokasibarcodeatauQR & "' )"
                command = New OleDb.OleDbCommand(simpan, conn)
                command.ExecuteNonQuery()
                MsgBox("Input Data Sukses")
            Else
                MsgBox("Data Sudah Ada")
            End If
        Catch ex As Exception
            MsgBox(lokasibarcodeatauQR)
        End Try


        For baris As Integer = 0 To DGV4.Rows.Count - 2
            Call koneksiDb()
            command = New OleDb.OleDbCommand("select * from TindakanObat where Kode_LO = '" & DGV4.Rows(baris).Cells("Kode_LO").Value & "'", conn)
            dataReader = command.ExecuteReader
            dataReader.Read()
            Try
                Dim kurangistok As String = "Update TindakanObat set Stok = '" & dataReader.Item("Stok") - DGV4.Rows(baris).Cells(2).Value & "' where Kode_LO = '" & DGV4.Rows(baris).Cells(0).Value & "'"
                command = New OleDb.OleDbCommand(kurangistok, conn)
                command.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("data tersebut belum masuk")
            End Try


        Next
        MsgBox("Transaksi Telah Tersimpan")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call HitungTotal()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Apotek.Show()
    End Sub

    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Apotek.TextBox8.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Penjualan.Show()
        Me.Hide()
    End Sub
End Class