Imports System.Data.OleDb
Public Class RekamMedis
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksiDb()
        conn = New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source = DataKlinik.accdb ")
        If Len(TextBox1.Text) > 0 And Len(TextBox2.Text) > 0 Then
            command = New OleDb.OleDbCommand("select * from RekamMedis where Kode_pasien ='" & TextBox1.Text & "' AND Tanggal_periksa = '" & TextBox2.Text & "'", conn)
        ElseIf Len(TextBox1.Text) > 0 And Len(TextBox2.Text) = 0 Then
            command = New OleDb.OleDbCommand("select * from RekamMedis where Kode_pasien ='" & TextBox1.Text & "'", conn)
        ElseIf Len(TextBox1.Text) = 0 And Len(TextBox2.Text) > 0 Then
            command = New OleDb.OleDbCommand("select * from RekamMedis where Tanggal_periksa = '" & TextBox2.Text & "'", conn)
        Else
            MsgBox("Masukkan Kode Pasien atau Tanggal Rekam Medis")
        End If

        Try
            dataAdapter = New OleDbDataAdapter(command)
            Dim dataTable = New DataTable()
            dataAdapter.Fill(dataTable)
            Dim cr As New RekamMedis2
            cr.SetDataSource(dataTable)
            crv.ReportSource = cr
            crv.Refresh()
        Catch ex As Exception
            MsgBox("Error tod")
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim selectedDate As DateTime = DateTimePicker1.Value.Date
        Dim formattedDate As String = selectedDate.ToShortDateString()
        TextBox2.Text = formattedDate
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Me.Hide()
        MainMenu.Show()
    End Sub
End Class