Imports System.Data.OleDb
Module Connection
    Public conn As OleDbConnection
    Public dataAdapter As OleDbDataAdapter
    Public dataSet As DataSet
    Public command As OleDbCommand
    Public dataReader As OleDbDataReader

    Sub koneksiDb()

        Try
            conn = New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source = DataKlinik.accdb ")
            conn.Open()
            MsgBox("Connected")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub releaseobject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub


End Module
