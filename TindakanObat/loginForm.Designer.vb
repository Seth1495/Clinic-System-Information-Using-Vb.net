<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginForm))
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.Button2 = New Guna.UI.WinForms.GunaButton()
        Me.Button1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.pw = New Guna.UI.WinForms.GunaTextBox()
        Me.Username = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.DarkCyan
        Me.GunaLabel4.Location = New System.Drawing.Point(53, 14)
        Me.GunaLabel4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(242, 32)
        Me.GunaLabel4.TabIndex = 19
        Me.GunaLabel4.Text = "SELAMAT DATANG"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Century", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.GunaLabel3.Location = New System.Drawing.Point(22, 347)
        Me.GunaLabel3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(117, 15)
        Me.GunaLabel3.TabIndex = 17
        Me.GunaLabel3.Text = "Belum Punya Akun ?"
        '
        'Button2
        '
        Me.Button2.AnimationHoverSpeed = 0.07!
        Me.Button2.AnimationSpeed = 0.03!
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BaseColor = System.Drawing.Color.DarkCyan
        Me.Button2.BorderColor = System.Drawing.Color.Black
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Button2.FocusedColor = System.Drawing.Color.Empty
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = Nothing
        Me.Button2.ImageSize = New System.Drawing.Size(20, 20)
        Me.Button2.Location = New System.Drawing.Point(146, 328)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen
        Me.Button2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Button2.OnHoverForeColor = System.Drawing.Color.White
        Me.Button2.OnHoverImage = Nothing
        Me.Button2.OnPressedColor = System.Drawing.Color.Black
        Me.Button2.Radius = 25
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button2.Size = New System.Drawing.Size(171, 50)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "DAFTAR"
        Me.Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.AnimationHoverSpeed = 0.07!
        Me.Button1.AnimationSpeed = 0.03!
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BaseColor = System.Drawing.Color.DarkCyan
        Me.Button1.BorderColor = System.Drawing.Color.Black
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Button1.FocusedColor = System.Drawing.Color.Empty
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Nothing
        Me.Button1.ImageSize = New System.Drawing.Size(20, 20)
        Me.Button1.Location = New System.Drawing.Point(15, 256)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen
        Me.Button1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Button1.OnHoverForeColor = System.Drawing.Color.White
        Me.Button1.OnHoverImage = Nothing
        Me.Button1.OnPressedColor = System.Drawing.Color.Black
        Me.Button1.Radius = 25
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(302, 50)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "MASUK"
        Me.Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.DarkCyan
        Me.GunaLabel2.Location = New System.Drawing.Point(122, 154)
        Me.GunaLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(91, 20)
        Me.GunaLabel2.TabIndex = 14
        Me.GunaLabel2.Text = "PASSWORD"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.DarkCyan
        Me.GunaLabel1.Location = New System.Drawing.Point(122, 63)
        Me.GunaLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(91, 20)
        Me.GunaLabel1.TabIndex = 13
        Me.GunaLabel1.Text = "USERNAME"
        '
        'pw
        '
        Me.pw.BackColor = System.Drawing.Color.Transparent
        Me.pw.BaseColor = System.Drawing.Color.White
        Me.pw.BorderColor = System.Drawing.Color.Silver
        Me.pw.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pw.FocusedBaseColor = System.Drawing.Color.White
        Me.pw.FocusedBorderColor = System.Drawing.Color.DarkCyan
        Me.pw.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.pw.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pw.Location = New System.Drawing.Point(15, 188)
        Me.pw.Margin = New System.Windows.Forms.Padding(2)
        Me.pw.Name = "pw"
        Me.pw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pw.Radius = 22
        Me.pw.SelectedText = ""
        Me.pw.Size = New System.Drawing.Size(302, 46)
        Me.pw.TabIndex = 12
        Me.pw.TabStop = False
        Me.pw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Username
        '
        Me.Username.BackColor = System.Drawing.Color.Transparent
        Me.Username.BaseColor = System.Drawing.Color.White
        Me.Username.BorderColor = System.Drawing.Color.Silver
        Me.Username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Username.FocusedBaseColor = System.Drawing.Color.White
        Me.Username.FocusedBorderColor = System.Drawing.Color.DarkCyan
        Me.Username.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.Username.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.Location = New System.Drawing.Point(15, 94)
        Me.Username.Margin = New System.Windows.Forms.Padding(2)
        Me.Username.Name = "Username"
        Me.Username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Username.Radius = 22
        Me.Username.SelectedText = ""
        Me.Username.Size = New System.Drawing.Size(302, 46)
        Me.Username.TabIndex = 11
        Me.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(278, 82)
        Me.GunaPictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(430, 349)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 20
        Me.GunaPictureBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(506, -47)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 175)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(706, 397)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.pw)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "loginForm"
        Me.Text = "loginForm"
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Button2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Button1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents pw As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Username As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
