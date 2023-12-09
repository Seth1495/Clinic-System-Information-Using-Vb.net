Public Class Periksa
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksiDb()
        Dim SimpanRekamMedis As String

        SimpanRekamMedis = "insert into RekamMedis values ('" &
       TextBox1.Text & "', '" & TextBox2.Text & "', '" &
       TextBox3.Text & "','" & TextBox4.Text & "','" &
       TextBox5.Text & "','" & Tingkat.Text & "','" & Rujukan.Text & "','" & Keterangan.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "')"
        command = New OleDb.OleDbCommand(SimpanRekamMedis, conn)

        command.ExecuteNonQuery()
        MsgBox("Input Data Sukses")
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.Click
        Call koneksiDb()
        dataAdapter = New OleDb.OleDbDataAdapter("select Kode_Pasien,Nama_Pasien from DataPasien", conn)
        dataSet = New DataSet
        dataAdapter.Fill(dataSet)
        DataGridView1.DataSource = dataSet.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        On Error Resume Next
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.Click
        Call koneksiDb()
        dataAdapter = New OleDb.OleDbDataAdapter("select Kode_LO,Diagnosa from TindakanObat", conn)
        dataSet = New DataSet
        dataAdapter.Fill(dataSet)
        DataGridView2.DataSource = dataSet.Tables(0)
        DataGridView2.ReadOnly = True
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        TextBox4.Text = DataGridView2.Rows(e.RowIndex).Cells(0).Value
        TextBox5.Text = DataGridView2.Rows(e.RowIndex).Cells(1).Value
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim selectedDate As DateTime = DateTimePicker1.Value.Date
        Dim formattedDate As String = selectedDate.ToShortDateString()
        TextBox6.Text = formattedDate
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RekamMedis.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.Click
        Call koneksiDb()
        dataAdapter = New OleDb.OleDbDataAdapter("select SIP,Nama_dokter from DataDokter", conn)
        dataSet = New DataSet
        dataAdapter.Fill(dataSet)
        DataGridView3.DataSource = dataSet.Tables(0)
        DataGridView3.ReadOnly = True
    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        TextBox7.Text = DataGridView3.Rows(e.RowIndex).Cells(0).Value
        TextBox8.Text = DataGridView3.Rows(e.RowIndex).Cells(1).Value
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Apotek.Show()
    End Sub
End Class