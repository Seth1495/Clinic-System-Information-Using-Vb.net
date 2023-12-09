
Public Class loginForm


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksiDb()
        Dim cek As String

        cek = "Select * From loginDokter Where Username= '" & Username.Text & "'
and Password = '" & pw.Text & "'"
        'CMD = New OleDb.OleDbCommand("Select * From Pengguna Where Username=
        '" & txtuser.Text & "' and Password = '" & txtpassword.Text & "'", Conn)
        'DM = CMD.ExecuteReader
        'DM.Read()
        command = New OleDb.OleDbCommand(cek, conn)
        command.ExecuteNonQuery()
        dataReader = command.ExecuteReader

        'If cek = "admin" Then
        'MainMenu.Show()
        'ElseIf cek = "dokter" Then
        'MainMenuDokter.Show()
        'Else
        'MsgBox("mana kaga kebaca")
        'End If
        If dataReader.HasRows = True Then
            dataReader.Read()
            Dim role As String = dataReader("Role").ToString()

            ' Lakukan validasi terhadap nilai role
            If role = "admin" Then
                MainMenu.Show()
                Me.Hide()
            ElseIf role = "dokter" Then
                MainMenuDokter.Show()
                Me.Hide()
            Else
                MsgBox("Akun anda belum terkonfirmasi")
            End If
        Else
            MsgBox(" Maaf Username atau Password Anda Salah ")
            Me.Show()
        End If
        'dataDokterForm.Label2.Text = Username.Text
        'dataLayananObat.Greet.Text = Username.Text
        Greeting.user.Text = Username.Text
        '  Call validasi()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RegisterForm.Show()
    End Sub
End Class