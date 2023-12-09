Public Class ExcelTransfer

    Sub tampilkandata()


    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
            For i = 0 To dgvPO.RowCount - 2
                For j = 0 To dgvPO.ColumnCount - 1
                    For k As Integer = 1 To dgvPO.Columns.Count
                        xlworksheet.Cells(1, k) = dgvPO.Columns(k - 1).HeaderText
                        xlworksheet.Cells(i + 2, j + 1) = dgvPO(j, i).Value.ToString
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