Imports System.Data.OleDb
Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO
Imports MessagingToolkit.QRCode.Codec.Data
Imports ZXing

Public Class Penjualan

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Call koneksiDb()
        conn = New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source = DataKlinik.accdb ")
        command = New OleDb.OleDbCommand("select * from Query_StrukTransaksi where Kode_transaksi ='" & TextBox3.Text & "'", conn)


        Try
            dataAdapter = New OleDbDataAdapter(command)
            Dim dataTable = New DataTable()
            dataAdapter.Fill(dataTable)
            Dim cr As New PenjualanStruk()
            cr.SetDataSource(dataTable)
            crv.ReportSource = cr
            crv.Refresh()
        Catch ex As Exception
            MsgBox("Error tod")
        End Try
    End Sub
    WithEvents mywebcam As VideoCaptureDevice
    Dim bitmap As Bitmap
    Dim encodeqr As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
    Dim decodeqr As New MessagingToolkit.QRCode.Codec.QRCodeDecoder

    Private Sub startwebcam()
        PictureBox1.Image = Nothing
        mywebcam.Start()
    End Sub
    Private Sub stopwebcam()
        mywebcam.SignalToStop()
        mywebcam = Nothing
    End Sub

    Private Sub captured(sender As Object, eventArgs As NewFrameEventArgs)
        Try
            bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)
            PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selectwebcam As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If selectwebcam.ShowDialog() = Windows.Forms.DialogResult.OK Then
            mywebcam = selectwebcam.VideoDevice
            AddHandler mywebcam.NewFrame, New NewFrameEventHandler(AddressOf captured)
            startwebcam()
            TextBox1.Clear()
            Button2.Enabled = True
            Button3.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        stopwebcam()
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim detectimage = New BarcodeReader
        Dim result As Result

        Try
            mywebcam.Stop()
            result = detectimage.Decode(New Bitmap(PictureBox1.Image))
            If result IsNot Nothing Then
                Dim imagedecoder As String
                imagedecoder = result.ToString().Trim
                TextBox1.Text = imagedecoder
            ElseIf result Is Nothing Then
                MsgBox("Silahkan coba lagi")
                startwebcam()
            End If

        Catch ex As Exception
            MsgBox(ErrorToString)
            startwebcam()
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        Try
            If TextBox1.Text = "Hello World?" Or TextBox1.Text = " " Then
                PictureBox1.Image = Nothing
            Else
                PictureBox1.Image = encodeqr.Encode(TextBox1.Text)
                ' encode kodinga ke foto
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Not PictureBox1.Image Is Nothing Then
            Dim savefile As New SaveFileDialog
            savefile.Filter = " Image File  (*.jpeg;*jpg;*.png;*.bmp;)| *.jpeg;*jpg;*.png;*.bmp;"
            If savefile.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Try
                    PictureBox1.Image.Save(savefile.FileName, Imaging.ImageFormat.Png)

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Else
            MsgBox("Gagal save ")
        End If
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            If TextBox1.Text = "Your Type Here" Then
                PictureBox1.Image = Nothing
            Else
                PictureBox1.Image = encodeqr.Encode(TextBox1.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim openfile As New OpenFileDialog
        TextBox1.Clear()
        openfile.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
        If openfile.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                PictureBox1.Load(openfile.FileName)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim resultdecoder As Bitmap = PictureBox1.Image

        Try
            TextBox1.Text = decodeqr.decode(New QRCodeBitmapImage(resultdecoder))
            If Len(TextBox1.Text) > 0 Then
                Call koneksiDb()
                conn = New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source = DataKlinik.accdb ")
                command = New OleDb.OleDbCommand("select * from Query_StrukTransaksi where Kode_transaksi ='" & TextBox1.Text & "'", conn)
                dataAdapter = New OleDbDataAdapter(command)
                Dim dataTable = New DataTable()
                dataAdapter.Fill(dataTable)
                Dim cr As New PenjualanStruk()
                cr.SetDataSource(dataTable)
                crv.ReportSource = cr
                crv.Refresh()
            Else
                MsgBox("Pembelian Tidak Dikenali")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class