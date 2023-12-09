Imports System.Data.OleDb

Public Class KartuDokter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksiDb()
        conn = New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source = DataKlinik.accdb ")
        command = New OleDbCommand("select * from DataDokter where SIP = '" & TextBox1.Text & "'", conn)
        Try
            dataAdapter = New OleDbDataAdapter(command)
            Dim dataTable = New DataTable()
            dataAdapter.Fill(dataTable)
            Dim cr As New ID()
            cr.SetDataSource(dataTable)
            crv.ReportSource = cr
            crv.Refresh()
        Catch ex As Exception
            MsgBox("Error tod")
        End Try
    End Sub

    Private Sub crv_Load(sender As Object, e As EventArgs)

    End Sub
End Class