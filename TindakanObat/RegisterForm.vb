Public Class RegisterForm
    Sub Kosongkanform()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then

            MsgBox("Masukkan username dan Password")
            Exit Sub

        ElseIf TextBox2.Text <> TextBox3.Text Then
            MsgBox("Masukkan Ulang Password")

        Else


            Call koneksiDb()
            command = New OleDb.OleDbCommand(" select * from loginDokter where
Username ='" & TextBox1.Text & "'", conn)
            dataReader = command.ExecuteReader
            dataReader.Read()

            If Not dataReader.HasRows Then
                Call koneksiDb()
                Dim simpan As String
                simpan = "insert into loginDokter values ('" &
           TextBox1.Text & "', '" & TextBox2.Text & "')"
                command = New OleDb.OleDbCommand(simpan, conn)
                command.ExecuteNonQuery()
                MsgBox("Akun Sudah Tersimpan")
                loginForm.Show()
                Me.Hide()

            Else
                MsgBox("Akun Sudah Ada")
            End If
            ' Call MatikanForm()
            Call Kosongkanform()
            'Call TampilkanData()
            loginForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        loginForm.Show()
        Me.Hide()
    End Sub
End Class