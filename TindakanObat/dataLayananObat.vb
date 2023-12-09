
Public Class dataLayananObat
    Sub KosongkanForm()
        txtNamaLO.Text = ""
        txtDiagnosa.Text = ""
        txtStokObat.Text = ""
        txtHarga.Text = ""
        Jenis.Text = ""
        txtLayananObat.Focus()
    End Sub
    Sub MatikanForm()
        txtLayananObat.Enabled = False
        txtNamaLO.Enabled = False
        txtDiagnosa.Enabled = False
        txtStokObat.Enabled = False
        txtHarga.Enabled = False
        Jenis.Enabled = False
        'Coding diatas untuk menutup atau mematikan form agar tidak dapat isi
    End Sub
    Sub HidupkanForm()
        txtLayananObat.Enabled = True
        txtNamaLO.Enabled = True
        txtDiagnosa.Enabled = True
        txtStokObat.Enabled = True
        txtHarga.Enabled = True
        Jenis.Enabled = True
        'Coding diatas untuk mulai menghidupkan form agar form bisa diisi
    End Sub
    Sub TampilkanData()
        Call koneksiDb()
        dataAdapter = New OleDb.OleDbDataAdapter("select * from TindakanObat", conn)
        dataSet = New DataSet
        dataAdapter.Fill(dataSet)
        DGV.DataSource = dataSet.Tables(0)
        DGV.ReadOnly = True
        'Coding diatas untuk menampilkan data dari Ms.Access yang sudah kita buat pada Data Grid View didalam form
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call HidupkanForm()
        Call KosongkanForm()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call MatikanForm()
        Call KosongkanForm()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MatikanForm()
        Call TampilkanData()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If txtLayananObat.Text = "" Or txtNamaLO.Text = "" Or txtDiagnosa.Text = "" Or txtStokObat.Text = "" Or txtHarga.Text = "" Or Jenis.Text = "" Then
            MsgBox("Data Tindakan Obat Belum Lengkap")
            Exit Sub
        Else
            Call koneksiDb()
            command = New OleDb.OleDbCommand(" select * from TindakanObat where Kode_LO ='" & txtLayananObat.Text & "'", conn)
            dataReader = command.ExecuteReader
            dataReader.Read()

            If Not dataReader.HasRows Then
                Call koneksiDb()
                ' command.Parameters.Add("@Stok", OleDbType.Integer).Value = CInt(txtStokObat.Text)
                '  command.Parameters.Add("@Harga", OleDbType.Integer).Value = CInt(txtHarga.Text)
                Dim simpan As String
                simpan = "insert into TindakanObat values ('" & txtLayananObat.Text &
               "', '" & txtDiagnosa.Text & "', '" & txtNamaLO.Text & "','" &
               txtStokObat.Text & "','" & txtHarga.Text & "','" & Jenis.Text & "' )"
                'command.Parameters.Add("")
                command = New OleDb.OleDbCommand(simpan, conn)
                command.ExecuteNonQuery()
                MsgBox("Input Data Sukses")
            Else
                MsgBox("Data Sudah Ada")
            End If
            Call MatikanForm()
            Call KosongkanForm()
            Call TampilkanData()
        End If

    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        On Error Resume Next
        txtLayananObat.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        txtNamaLO.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        txtDiagnosa.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        txtStokObat.Text = DGV.Rows(e.RowIndex).Cells(3).Value
        txtHarga.Text = DGV.Rows(e.RowIndex).Cells(4).Value
        Jenis.Text = DGV.Rows(e.RowIndex).Cells(5).Value
        'Coding ini berfungsi , ketika kita mau mengedit data ,caranya kita arahkan mouse ke salah satu cell yang di Data Grid View , maka data dari cell tersebut akan masuk ke dalam field yang ada form
        'Cell(0) , Cell(1) dst artinya : dimulai dari Cell ke O , 1 dan seterusnya
        Call HidupkanForm()
        txtLayananObat.Enabled = False 'Ketika mengedit , kita tidak bisa mengedit kode buku nya , kita hanya bisa mengedit di field2 lainnya
    End Sub
    Sub UpdateData()

        If txtLayananObat.Text = "" Or txtNamaLO.Text = "" Or txtDiagnosa.Text = "" Or txtStokObat.Text = "" Or txtHarga.Text = "" Or Jenis.Text = "" Then
            MsgBox("Data Layanan Obat Belum Lengkap")
            Exit Sub

        Else
            Call koneksiDb()
            command = New OleDb.OleDbCommand(" update TindakanObat set Nama_LO ='" & txtNamaLO.Text & "',Diagnosa = '" &
           txtDiagnosa.Text & "',Stok = '" & txtStokObat.Text & "',Harga = '" & txtHarga.Text & "',Tingkat ='" & Jenis.Text & "' where Kode_LO = '" & txtLayananObat.Text & "'", conn)

            dataReader = command.ExecuteReader
            MsgBox("Update Data Berhasil")

        End If
        Call KosongkanForm()
        'Call MatikanForm()
        Call TampilkanData()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call UpdateData()
        Call TampilkanData()
        Call MatikanForm()

    End Sub
    Sub DeleteData()
        If txtLayananObat.Text = "" Then
            MsgBox("Tidak ada data yang dipilih")
            Exit Sub

        Else
            If MessageBox.Show("Are you sure to delete this data ? ", "Konfirmasi", MessageBoxButtons.YesNoCancel) = Windows.Forms.DialogResult.Yes Then

                'Coding berfungsi untuk memberi konfirmasi ke user , apakah yakin untuk mendelete data
                'Jika yakin , maka akan berjalan coding dibawah ini untuk mendelete Data yang dipilih
                Call koneksiDb()
                command = New OleDb.OleDbCommand(" delete from TindakanObat where Kode_LO ='" & txtLayananObat.Text & "'", conn)
                dataReader = command.ExecuteReader
                MsgBox("Hapus Data Berhasil")
                Call MatikanForm()
                Call KosongkanForm()
                Call TampilkanData()
            Else
                Call KosongkanForm()
                Call TampilkanData()
            End If
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call DeleteData()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
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
            For i = 0 To DGV.RowCount - 2
                For j = 0 To DGV.ColumnCount - 1
                    For k As Integer = 1 To DGV.Columns.Count
                        xlworksheet.Cells(1, k) = DGV.Columns(k - 1).HeaderText
                        xlworksheet.Cells(i + 2, j + 1) = DGV(j, i).Value.ToString
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