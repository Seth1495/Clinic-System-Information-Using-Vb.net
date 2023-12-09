Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine

Class Dokterreport

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Call koneksiDb()
        conn = New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source = DataKlinik.accdb ")
        command = New OleDbCommand("select * from DataDokter where Tanggal_lahir between @date1 And @date2 Order By Tanggal_lahir Desc", conn)
        command.Parameters.Add("date1", OleDbType.DBDate).Value = DateTimePicker1.Value
        command.Parameters.Add("date2", OleDbType.DBDate).Value = DateTimePicker2.Value

        Try

            dataAdapter = New OleDbDataAdapter(command)
            Dim dataTable = New DataTable()
            dataAdapter.Fill(dataTable)
            Dim cr As New doktercrv
            cr.SetDataSource(dataTable)
            CRV.ReportSource = cr
            CRV.Refresh()
        Catch ex As Exception
            MsgBox("Error tod")
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Report.Show()
    End Sub


End Class