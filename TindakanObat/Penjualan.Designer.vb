<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Penjualan
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
        Me.PenjualanStruk3 = New TindakanObat.PenjualanStruk()
        Me.PenjualanStruk1 = New TindakanObat.PenjualanStruk()
        Me.StrukBaru1 = New TindakanObat.StrukBaru()
        Me.Cetakpenjualan1 = New TindakanObat.Cetakpenjualan()
        Me.PenjualanStruk2 = New TindakanObat.PenjualanStruk()
        Me.PictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TextBox1 = New Guna.UI.WinForms.GunaTextBox()
        Me.Button6 = New Guna.UI.WinForms.GunaButton()
        Me.Button2 = New Guna.UI.WinForms.GunaButton()
        Me.Button1 = New Guna.UI.WinForms.GunaButton()
        Me.Button3 = New Guna.UI.WinForms.GunaButton()
        Me.Button5 = New Guna.UI.WinForms.GunaButton()
        Me.Button4 = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Button8 = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.TextBox3 = New Guna.UI.WinForms.GunaTextBox()
        Me.PenjualanStruk4 = New TindakanObat.PenjualanStruk()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.BaseColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(126, 257)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(293, 293)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 118
        Me.PictureBox1.TabStop = False
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Controls.Add(Me.crv)
        Me.GunaPanel1.Location = New System.Drawing.Point(569, 12)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(764, 646)
        Me.GunaPanel1.TabIndex = 117
        '
        'crv
        '
        Me.crv.ActiveViewIndex = 0
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv.Location = New System.Drawing.Point(0, 0)
        Me.crv.Margin = New System.Windows.Forms.Padding(4)
        Me.crv.Name = "crv"
        Me.crv.ReportSource = Me.PenjualanStruk4
        Me.crv.Size = New System.Drawing.Size(764, 646)
        Me.crv.TabIndex = 1
        Me.crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Transparent
        Me.TextBox1.BaseColor = System.Drawing.Color.White
        Me.TextBox1.BorderColor = System.Drawing.Color.Silver
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox1.FocusedBaseColor = System.Drawing.Color.White
        Me.TextBox1.FocusedBorderColor = System.Drawing.Color.DarkCyan
        Me.TextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox1.Location = New System.Drawing.Point(14, 556)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox1.Radius = 15
        Me.TextBox1.SelectedText = ""
        Me.TextBox1.Size = New System.Drawing.Size(521, 40)
        Me.TextBox1.TabIndex = 116
        '
        'Button6
        '
        Me.Button6.AnimationHoverSpeed = 0.07!
        Me.Button6.AnimationSpeed = 0.03!
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.BaseColor = System.Drawing.Color.DarkCyan
        Me.Button6.BorderColor = System.Drawing.Color.Black
        Me.Button6.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Button6.FocusedColor = System.Drawing.Color.Empty
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Image = Nothing
        Me.Button6.ImageSize = New System.Drawing.Size(20, 20)
        Me.Button6.Location = New System.Drawing.Point(366, 211)
        Me.Button6.Name = "Button6"
        Me.Button6.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen
        Me.Button6.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Button6.OnHoverForeColor = System.Drawing.Color.White
        Me.Button6.OnHoverImage = Nothing
        Me.Button6.OnPressedColor = System.Drawing.Color.Black
        Me.Button6.Radius = 15
        Me.Button6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button6.Size = New System.Drawing.Size(169, 40)
        Me.Button6.TabIndex = 115
        Me.Button6.Text = "Import Image"
        Me.Button6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.Button2.Location = New System.Drawing.Point(191, 165)
        Me.Button2.Name = "Button2"
        Me.Button2.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen
        Me.Button2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Button2.OnHoverForeColor = System.Drawing.Color.White
        Me.Button2.OnHoverImage = Nothing
        Me.Button2.OnPressedColor = System.Drawing.Color.Black
        Me.Button2.Radius = 15
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button2.Size = New System.Drawing.Size(169, 40)
        Me.Button2.TabIndex = 114
        Me.Button2.Text = "Stop"
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
        Me.Button1.Location = New System.Drawing.Point(14, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen
        Me.Button1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Button1.OnHoverForeColor = System.Drawing.Color.White
        Me.Button1.OnHoverImage = Nothing
        Me.Button1.OnPressedColor = System.Drawing.Color.Black
        Me.Button1.Radius = 15
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(169, 40)
        Me.Button1.TabIndex = 113
        Me.Button1.Text = "Start"
        Me.Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button3
        '
        Me.Button3.AnimationHoverSpeed = 0.07!
        Me.Button3.AnimationSpeed = 0.03!
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BaseColor = System.Drawing.Color.DarkCyan
        Me.Button3.BorderColor = System.Drawing.Color.Black
        Me.Button3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Button3.FocusedColor = System.Drawing.Color.Empty
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = Nothing
        Me.Button3.ImageSize = New System.Drawing.Size(20, 20)
        Me.Button3.Location = New System.Drawing.Point(366, 165)
        Me.Button3.Name = "Button3"
        Me.Button3.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen
        Me.Button3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Button3.OnHoverForeColor = System.Drawing.Color.White
        Me.Button3.OnHoverImage = Nothing
        Me.Button3.OnPressedColor = System.Drawing.Color.Black
        Me.Button3.Radius = 15
        Me.Button3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button3.Size = New System.Drawing.Size(169, 40)
        Me.Button3.TabIndex = 112
        Me.Button3.Text = "Detect"
        Me.Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button5
        '
        Me.Button5.AnimationHoverSpeed = 0.07!
        Me.Button5.AnimationSpeed = 0.03!
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BaseColor = System.Drawing.Color.DarkCyan
        Me.Button5.BorderColor = System.Drawing.Color.Black
        Me.Button5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Button5.FocusedColor = System.Drawing.Color.Empty
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Image = Nothing
        Me.Button5.ImageSize = New System.Drawing.Size(20, 20)
        Me.Button5.Location = New System.Drawing.Point(191, 211)
        Me.Button5.Name = "Button5"
        Me.Button5.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen
        Me.Button5.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Button5.OnHoverForeColor = System.Drawing.Color.White
        Me.Button5.OnHoverImage = Nothing
        Me.Button5.OnPressedColor = System.Drawing.Color.Black
        Me.Button5.Radius = 15
        Me.Button5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button5.Size = New System.Drawing.Size(169, 40)
        Me.Button5.TabIndex = 111
        Me.Button5.Text = "Decode"
        Me.Button5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button4
        '
        Me.Button4.AnimationHoverSpeed = 0.07!
        Me.Button4.AnimationSpeed = 0.03!
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BaseColor = System.Drawing.Color.DarkCyan
        Me.Button4.BorderColor = System.Drawing.Color.Black
        Me.Button4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Button4.FocusedColor = System.Drawing.Color.Empty
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = Nothing
        Me.Button4.ImageSize = New System.Drawing.Size(20, 20)
        Me.Button4.Location = New System.Drawing.Point(14, 211)
        Me.Button4.Name = "Button4"
        Me.Button4.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen
        Me.Button4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Button4.OnHoverForeColor = System.Drawing.Color.White
        Me.Button4.OnHoverImage = Nothing
        Me.Button4.OnPressedColor = System.Drawing.Color.Black
        Me.Button4.Radius = 15
        Me.Button4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button4.Size = New System.Drawing.Size(169, 40)
        Me.Button4.TabIndex = 110
        Me.Button4.Text = "Save"
        Me.Button4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.DarkCyan
        Me.GunaLabel1.Location = New System.Drawing.Point(10, 137)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(120, 23)
        Me.GunaLabel1.TabIndex = 109
        Me.GunaLabel1.Text = "Scan With QR"
        '
        'Button8
        '
        Me.Button8.AnimationHoverSpeed = 0.07!
        Me.Button8.AnimationSpeed = 0.03!
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.BaseColor = System.Drawing.Color.White
        Me.Button8.BorderColor = System.Drawing.Color.DarkCyan
        Me.Button8.BorderSize = 2
        Me.Button8.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Button8.FocusedColor = System.Drawing.Color.Empty
        Me.Button8.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.DarkCyan
        Me.Button8.Image = Nothing
        Me.Button8.ImageSize = New System.Drawing.Size(20, 20)
        Me.Button8.Location = New System.Drawing.Point(366, 94)
        Me.Button8.Name = "Button8"
        Me.Button8.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen
        Me.Button8.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Button8.OnHoverForeColor = System.Drawing.Color.White
        Me.Button8.OnHoverImage = Nothing
        Me.Button8.OnPressedColor = System.Drawing.Color.Black
        Me.Button8.Radius = 15
        Me.Button8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button8.Size = New System.Drawing.Size(169, 40)
        Me.Button8.TabIndex = 108
        Me.Button8.Text = "Cetak Struk"
        Me.Button8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.ForeColor = System.Drawing.Color.DarkCyan
        Me.GunaLabel6.Location = New System.Drawing.Point(9, 66)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(129, 23)
        Me.GunaLabel6.TabIndex = 107
        Me.GunaLabel6.Text = "Kode Transaksi"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Transparent
        Me.TextBox3.BaseColor = System.Drawing.Color.White
        Me.TextBox3.BorderColor = System.Drawing.Color.Silver
        Me.TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox3.FocusedBaseColor = System.Drawing.Color.White
        Me.TextBox3.FocusedBorderColor = System.Drawing.Color.DarkCyan
        Me.TextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox3.Location = New System.Drawing.Point(14, 94)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox3.Radius = 15
        Me.TextBox3.SelectedText = ""
        Me.TextBox3.Size = New System.Drawing.Size(346, 40)
        Me.TextBox3.TabIndex = 106
        '
        'Penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1343, 670)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.TextBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Penjualan"
        Me.Text = "Penjualan"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cetakpenjualan1 As Cetakpenjualan
    Friend WithEvents StrukBaru1 As StrukBaru
    Friend WithEvents PenjualanStruk1 As PenjualanStruk
    Friend WithEvents PenjualanStruk3 As PenjualanStruk
    Friend WithEvents PenjualanStruk2 As PenjualanStruk
    Friend WithEvents PictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents PenjualanStruk4 As PenjualanStruk
    Friend WithEvents TextBox1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Button6 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Button2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Button1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Button3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Button5 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Button4 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Button8 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TextBox3 As Guna.UI.WinForms.GunaTextBox
End Class
