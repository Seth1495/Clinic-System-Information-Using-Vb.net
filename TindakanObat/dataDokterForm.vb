﻿Public Class dataDokterForm
    Sub KosongkanForm()
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        DateTimePicker1.Text = ""
        TextBox1.Focus()
    End Sub
    Sub MatikanForm()
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        ComboBox1.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False
        TextBox8.Enabled = False
        DateTimePicker1.Enabled = False
        'Coding diatas untuk menutup atau mematikan form agar tidak dapat isi
    End Sub
    Sub HidupkanForm()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        ComboBox1.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        TextBox7.Enabled = True
        TextBox8.Enabled = True
        DateTimePicker1.Enabled = True
        'Coding diatas untuk mulai menghidupkan form agar form bisa diisi
    End Sub
    Sub TampilkanData()
        Call koneksiDb()
        dataAdapter = New OleDb.OleDbDataAdapter("select * from DataDokter ", conn)
        dataSet = New DataSet
        dataAdapter.Fill(dataSet)
        DGV2.DataSource = dataSet.Tables(0)
        DGV2.ReadOnly = True

    End Sub
    Sub foto1()
        PictureBox1.ImageLocation = ""
    End Sub
    Sub DeleteData()
        If TextBox1.Text = "" Then
            MsgBox("Tidak ada data yang dipilih")
            Exit Sub

        Else
            If MessageBox.Show("Are you sure to delete this data ? ", "Konfirmasi", MessageBoxButtons.YesNoCancel) = Windows.Forms.DialogResult.Yes Then


                Call koneksiDb()

                command = New OleDb.OleDbCommand(" delete from DataDokter where SIP ='" & TextBox1.Text & "'", conn)
                dataReader = command.ExecuteReader
                MsgBox("Hapus Data Berhasil")
                Call HidupkanForm()
                Call KosongkanForm()
                Call TampilkanData()
            Else
                Call KosongkanForm()
                Call TampilkanData()
            End If
        End If
    End Sub
    Sub UpdateData()
        TextBox7.Text = txtUsia.Text
        If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or DateTimePicker1.Text = "" Or TextBox9.Text = "" Then
            MsgBox("Data Layanan Obat Belum Lengkap")
            Exit Sub

        Else
            Call koneksiDb()

            command = New OleDb.OleDbCommand(" update DataDokter set Nama_dokter = '" &
           TextBox2.Text & "',Jenis_kelamin = '" & ComboBox1.Text & "',Spesialis = '" &
           TextBox4.Text & "',Tempat_praktek = '" & TextBox5.Text & "',Jam_praktek ='" & TextBox6.Text & "',Usia ='" & TextBox7.Text & "', Tempat_lahir ='" & TextBox8.Text & "', Tanggal_lahir ='" & DateTimePicker1.Value & "', Foto_diri ='" & TextBox9.Text & "' where SIP = '" & TextBox1.Text & "'", conn)

            dataReader = command.ExecuteReader
            MsgBox("Update Data Berhasil")

        End If
        Call KosongkanForm()
        'Call MatikanForm()
        Call TampilkanData()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or
ComboBox1.Text = "" Or TextBox4.Text = "" Or
TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Then

            MsgBox("Data Karyawan Belum Lengkap")
            Exit Sub

        Else
            Call koneksiDb()
            TextBox7.Text = txtUsia.Text
            command = New OleDb.OleDbCommand(" select * from DataDokter where
SIP ='" & TextBox1.Text & "'", conn)
            dataReader = command.ExecuteReader
            dataReader.Read()

            If Not dataReader.HasRows Then
                Call koneksiDb()
                Dim simpan As String
                simpan = "insert into DataDokter values ('" &
               TextBox1.Text & "', '" & TextBox2.Text & "', '" &
               ComboBox1.Text & "','" & TextBox4.Text & "','" &
               TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & DateTimePicker1.Value & "','" & TextBox9.Text & "' )"
                command = New OleDb.OleDbCommand(simpan, conn)
                command.ExecuteNonQuery()
                MsgBox("Input Data Sukses")
                Call foto1()
            Else
                MsgBox("Data Sudah Ada")
            End If
            Call MatikanForm()
            Call KosongkanForm()
            Call TampilkanData()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            OpenFileDialog1.Filter = " Image File  (*.jpeg;*jpg;*.png;*.bmp;*.gif)| *.jpeg;*jpg;*.png;*.bmp;*.gif" ' nampilin file
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

                PictureBox1.Image = New Bitmap(OpenFileDialog1.FileName)
                TextBox9.Text = OpenFileDialog1.FileName
            End If
        Catch ex As Exception
            Throw New ApplicationException("Gambar Gagal Masuk")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call DeleteData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call HidupkanForm()
        Call koneksiDb()
        Dim pegawai = InputBox("Silahkan Masukkan ID Karyawan")
        TextBox7.Text = txtUsia.Text
        Try
            dataSet.Tables(0).PrimaryKey = New DataColumn() {dataSet.Tables(0).Columns("SIP")}
            Dim row As DataRow
            row = dataSet.Tables(0).Rows.Find(pegawai)

            TextBox1.Text = row("SIP")
            TextBox2.Text = row("Nama_dokter")
            ComboBox1.Text = row("Jenis_kelamin")
            TextBox4.Text = row("Spesialis")
            TextBox5.Text = row("Tempat_praktek")
            TextBox6.Text = row("Jam_praktek")
            TextBox7.Text = row("Usia")
            TextBox8.Text = row("Tempat_lahir")
            DateTimePicker1.Value = row("Tanggal_lahir")
            TextBox9.Text = row("Foto_Diri")

            PictureBox1.Image = New Bitmap(TextBox9.Text)
            TextBox9.Text = OpenFileDialog1.FileName
            ' End If
            Refresh()
            MsgBox("Pencarian Sukses")
            Refresh()
        Catch ex As Exception
            MsgBox("ID kosong")
        End Try
    End Sub

    Private Sub dataDokterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilkanData()
    End Sub

    Private Sub DGV2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV2.CellContentClick
        On Error Resume Next
        TextBox1.Text = DGV2.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = DGV2.Rows(e.RowIndex).Cells(1).Value
        ComboBox1.Text = DGV2.Rows(e.RowIndex).Cells(2).Value
        TextBox4.Text = DGV2.Rows(e.RowIndex).Cells(3).Value
        TextBox5.Text = DGV2.Rows(e.RowIndex).Cells(4).Value
        TextBox6.Text = DGV2.Rows(e.RowIndex).Cells(5).Value
        TextBox7.Text = DGV2.Rows(e.RowIndex).Cells(6).Value
        TextBox8.Text = DGV2.Rows(e.RowIndex).Cells(7).Value
        DateTimePicker1.Text = DGV2.Rows(e.RowIndex).Cells(8).Value
        TextBox9.Text = DGV2.Rows(e.RowIndex).Cells(9).Value
        'Coding ini berfungsi , ketika kita mau mengedit data ,caranya kita arahkan mouse ke salah satu cell yang di Data Grid View , maka data dari cell tersebut akan masuk ke dalam field yang ada form
        'Cell(0) , Cell(1) dst artinya : dimulai dari Cell ke O , 1 dan seterusnya
        Call HidupkanForm()
        TextBox1.Enabled = False 'Ketika mengedit , kita tidak bisa mengedit kode buku nya , kita hanya bisa mengedit di field2 lainnya
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call UpdateData()
        Call TampilkanData()
        Call MatikanForm()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call MatikanForm()
        Call KosongkanForm()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Call HidupkanForm()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        Call koneksiDb()
        dataAdapter = New OleDb.OleDbDataAdapter("SELECT* from DataDokter where SIP like '%" & txtCari.Text.Replace("'", "''") & "%' or Nama_dokter like '%" & txtCari.Text.Replace("'", "''") & "%' or Jenis_kelamin like '%" & txtCari.Text.Replace("'", "''") & "%'  or Spesialis like '%" & txtCari.Text.Replace("'", "''") & "%'  or Tempat_praktek like '%" & txtCari.Text.Replace("'", "''") & "%'  or Jam_praktek like '%" & txtCari.Text.Replace("'", "''") & "%'  or usia like '%" & txtCari.Text.Replace("'", "''") & "%'  or Tempat_lahir like '%" & txtCari.Text.Replace("'", "''") & "%' or Tanggal_lahir like '%" & txtCari.Text.Replace("'", "''") & "%' or Foto_diri like '%" & txtCari.Text.Replace("'", "''") & "%' ", conn)

        dataSet = New DataSet
        'CMD = New OleDb.OleDbCommand(sq12, Conn)
        'CMD. ExecuteNonQuery()
        Dim SRT As New DataTable
        SRT.Clear()
        dataAdapter.Fill(SRT)
        DGV2.DataSource = SRT

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim tanggallahir, tanggalsekarang As Date
        Dim tahun, bulan, hari As Integer

        tanggallahir = DateTimePicker1.Value
        tanggalsekarang = Now

        tahun = DateDiff(DateInterval.Year, tanggallahir, tanggalsekarang)
        bulan = DateDiff(DateInterval.Month, tanggallahir, tanggalsekarang)
        hari = DateDiff(DateInterval.Day, tanggallahir, tanggalsekarang)

        If tahun > 0 Then
            txtUsia.Text = tahun.ToString & " Tahun"
            TextBox7.Text = txtUsia.Text
        Else
            txtUsia.Text = " "
            TextBox7.Text = " "
        End If

        If tahun < 2 Then
            txtkategori.Text = " Dokter Intern"
        ElseIf tahun > 3 And tahun < 14 Then
            txtkategori.Text = "Dokter Junior"
        ElseIf bulan > 15 Then
            txtkategori.Text = "Dokter Senior"
        Else
            txtkategori.Text = " "
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        SaveFileDialog1.Filter = "Excel Files(*.xlsx)|*.xlsx"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim xlapp As Microsoft.Office.Interop.Excel.Application
            Dim xlworkbook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlworksheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim missvalue As Object = System.Reflection.Missing.Value
            Dim i As Integer
            Dim j As Integer
            xlapp = New Microsoft.Office.Interop.Excel.Application
            xlworkbook = xlapp.Workbooks.Add(missvalue)
            xlworksheet = xlworkbook.Sheets("sheet1")
            'proses eksport
            'CEK DATAGRIDVIEWNYA ! HARUS SESUAI !
            For i = 0 To DGV2.RowCount - 2
                For j = 0 To DGV2.ColumnCount - 1
                    For k As Integer = 1 To DGV2.Columns.Count
                        xlworksheet.Cells(1, k) = DGV2.Columns(k - 1).HeaderText
                        xlworksheet.Cells(i + 2, j + 1) = DGV2(j, i).Value.ToString
                    Next
                Next
            Next
            xlworksheet.SaveAs(SaveFileDialog1.FileName)
            xlworkbook.Close()
            xlapp.Quit()
            releaseobject(xlapp)
            releaseobject(xlworkbook)
            releaseobject(xlworksheet)
            MessageBox.Show("Proses export berhasil", "Sukses", MessageBoxButtons.OK)
        End If
    End Sub
End Class