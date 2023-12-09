Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine

Public Class Report
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksiDb()
        conn = New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source = DataKlinik.accdb ")
        command = New OleDbCommand("select * from TindakanObat where Tingkat = @Jenis", conn)
        command.Parameters.AddWithValue("@Jenis", TextBox1.Text)

        Try
            dataAdapter = New OleDbDataAdapter(command)
            Dim dataTable = New DataTable()
            dataAdapter.Fill(dataTable)
            Dim cr As New LayananObat
            cr.SetDataSource(dataTable)
            crv.ReportSource = cr
            crv.Refresh()
        Catch ex As Exception
            MsgBox("Error tod")
        End Try

    End Sub
End Class