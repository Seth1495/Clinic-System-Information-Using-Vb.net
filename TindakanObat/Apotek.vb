Imports System.Data.OleDb
Public Class Apotek
    Sub Nomorfakturotomatis()
        Call koneksiDb()
        command = New OleDb.OleDbCommand("Select * from DataPenjualan where Kode_transaksi in (select max(Kode_transaksi) from DataPenjualan)", conn)
        Dim urutankode As String
        Dim hitung As Integer
        dataReader = command.ExecuteReader
        dataReader.Read()
        If Not dataReader.HasRows Then
            urutankode = "T" + Format(Now, "yyMMdd") + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(dataReader.GetInt32(0), 9) + 1
            urutankode = "T" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        TextBox8.Text = urutankode

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim selectedDate As DateTime = DateTimePicker1.Value.Date
        Dim formattedDate As String = selectedDate.ToShortDateString()
        TextBox2.Text = formattedDate
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksiDb()
        dataAdapter = New OleDb.OleDbDataAdapter("select Kode_LO from RekamMedis where Kode_pasien ='" & TextBox1.Text & "' AND Tanggal_periksa = '" & TextBox2.Text & "'", conn)
        dataSet = New DataSet
        dataAdapter.Fill(dataSet)
        DataGridView1.DataSource = dataSet.Tables(0)
        DataGridView1.ReadOnly = True


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        On Error Resume Next
        TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

        Call koneksiDb()
        dataAdapter = New OleDb.OleDbDataAdapter("select Nama_LO, Harga from TindakanObat where Kode_LO ='" & TextBox3.Text & "'", conn)
        dataSet = New DataSet
        dataAdapter.Fill(dataSet)

        If dataSet.Tables.Count > 0 AndAlso dataSet.Tables(0).Rows.Count > 0 Then
            Dim row As DataRow = dataSet.Tables(0).Rows(0)
            Dim namaLO As String = row("Nama_LO").ToString()
            Dim harga As Integer = Convert.ToInt32(row("Harga"))

            TextBox4.Text = namaLO
            TextBox5.Text = harga
        Else
            MsgBox("Update Nama_Lo dan Harga Gagal")
        End If

        dataAdapter = New OleDb.OleDbDataAdapter("select Kode_RM, Nama_pasien from RekamMedis where Kode_pasien ='" & TextBox1.Text & "' And Kode_LO = '" & TextBox3.Text & "' ", conn)
        dataSet = New DataSet
        dataAdapter.Fill(dataSet)

        If dataSet.Tables.Count > 0 AndAlso dataSet.Tables(0).Rows.Count > 0 Then
            Dim row As DataRow = dataSet.Tables(0).Rows(0)
            Dim Kode_RM As String = row("Kode_RM").ToString()
            Dim Nama_pasien As String = row("Nama_pasien").ToString()


            TextBox11.Text = Kode_RM
            TextBox10.Text = Nama_pasien
        Else
            MsgBox("Update kode Rm dan nama gagal")
        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Dim selectedDate As DateTime = DateTimePicker2.Value.Date
        Dim formattedDate As String = selectedDate.ToShortDateString()
        TextBox6.Text = formattedDate
    End Sub

    Private Sub Simpan_Click(sender As Object, e As EventArgs) Handles Simpan.Click
        Call koneksiDb()
        Dim simpan As String
        simpan = "insert into DataPenjualan(Kode_RM, Nama_Pasien, Kode_LO, Nama_LO, Harga, Tanggal, Jumlah, Kode_transaksi) values ('" &
       TextBox11.Text & "', '" & TextBox10.Text & "', '" &
       TextBox3.Text & "','" & TextBox4.Text & "','" &
       TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "')"
        command = New OleDb.OleDbCommand(simpan, conn)
        command.ExecuteNonQuery()
        MsgBox("Input Data Sukses")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call koneksiDb()
        ' conn = New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source = DataKlinik.accdb ")
        command = New OleDbCommand("select * from DataPenjualan where Kode_transaksi = '" & TextBox9.Text & "'", conn)

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
            DataGridView2.DataSource = SRT
        Catch ex As Exception
            MsgBox("Error tod")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Transaksi.Show()
        Me.Hide()
    End Sub

    Private Sub Apotek_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Nomorfakturotomatis()
        TextBox1.Text = Periksa.TextBox2.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Periksa.Show()

    End Sub
End Class