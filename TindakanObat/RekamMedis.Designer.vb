<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RekamMedis
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
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.RekamMedis23 = New TindakanObat.RekamMedis2()
        Me.Button1 = New Guna.UI.WinForms.GunaButton()
        Me.TextBox2 = New Guna.UI.WinForms.GunaTextBox()
        Me.DateTimePicker1 = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.TextBox1 = New Guna.UI.WinForms.GunaTextBox()
        Me.RekamMedis22 = New TindakanObat.RekamMedis2()
        Me.RekamMedis21 = New TindakanObat.RekamMedis2()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Controls.Add(Me.crv)
        Me.GunaPanel1.Location = New System.Drawing.Point(12, 67)
        Me.GunaPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(986, 462)
        Me.GunaPanel1.TabIndex = 91
        '
        'crv
        '
        Me.crv.ActiveViewIndex = 0
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv.Location = New System.Drawing.Point(0, 0)
        Me.crv.Name = "crv"
        Me.crv.ReportSource = Me.RekamMedis23
        Me.crv.Size = New System.Drawing.Size(986, 462)
        Me.crv.TabIndex = 1
        Me.crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Button1
        '
        Me.Button1.AnimationHoverSpeed = 0.07!
        Me.Button1.AnimationSpeed = 0.03!
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BaseColor = System.Drawing.Color.White
        Me.Button1.BorderColor = System.Drawing.Color.DarkCyan
        Me.Button1.BorderSize = 2
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Button1.FocusedColor = System.Drawing.Color.Empty
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkCyan
        Me.Button1.Image = Nothing
        Me.Button1.ImageSize = New System.Drawing.Size(20, 20)
        Me.Button1.Location = New System.Drawing.Point(938, 16)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen
        Me.Button1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Button1.OnHoverForeColor = System.Drawing.Color.White
        Me.Button1.OnHoverImage = Nothing
        Me.Button1.OnPressedColor = System.Drawing.Color.Black
        Me.Button1.Radius = 15
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(61, 32)
        Me.Button1.TabIndex = 90
        Me.Button1.Text = "Cari"
        Me.Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Transparent
        Me.TextBox2.BaseColor = System.Drawing.Color.White
        Me.TextBox2.BorderColor = System.Drawing.Color.Silver
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox2.FocusedBaseColor = System.Drawing.Color.White
        Me.TextBox2.FocusedBorderColor = System.Drawing.Color.DarkCyan
        Me.TextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox2.Location = New System.Drawing.Point(600, 16)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox2.Radius = 15
        Me.TextBox2.SelectedText = ""
        Me.TextBox2.Size = New System.Drawing.Size(333, 32)
        Me.TextBox2.TabIndex = 89
        Me.TextBox2.Text = "Cari Data Grid View"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.BackColor = System.Drawing.Color.Transparent
        Me.DateTimePicker1.BaseColor = System.Drawing.Color.White
        Me.DateTimePicker1.BorderColor = System.Drawing.Color.Silver
        Me.DateTimePicker1.CustomFormat = Nothing
        Me.DateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePicker1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DateTimePicker1.ForeColor = System.Drawing.Color.Black
        Me.DateTimePicker1.Location = New System.Drawing.Point(398, 16)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.OnHoverBaseColor = System.Drawing.Color.White
        Me.DateTimePicker1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateTimePicker1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateTimePicker1.OnPressedColor = System.Drawing.Color.Black
        Me.DateTimePicker1.Radius = 15
        Me.DateTimePicker1.Size = New System.Drawing.Size(197, 32)
        Me.DateTimePicker1.TabIndex = 88
        Me.DateTimePicker1.Text = "Wednesday, June 7, 2023"
        Me.DateTimePicker1.Value = New Date(2023, 6, 7, 0, 44, 55, 800)
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.ForeColor = System.Drawing.Color.DarkCyan
        Me.GunaLabel10.Location = New System.Drawing.Point(302, 23)
        Me.GunaLabel10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(91, 19)
        Me.GunaLabel10.TabIndex = 87
        Me.GunaLabel10.Text = "Tanggal Beli"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.DarkCyan
        Me.GunaLabel1.Location = New System.Drawing.Point(9, 23)
        Me.GunaLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(91, 19)
        Me.GunaLabel1.TabIndex = 86
        Me.GunaLabel1.Text = "Kode Pasien"
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
        Me.TextBox1.Location = New System.Drawing.Point(93, 16)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox1.Radius = 15
        Me.TextBox1.SelectedText = ""
        Me.TextBox1.Size = New System.Drawing.Size(198, 32)
        Me.TextBox1.TabIndex = 85
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.White
        Me.GunaButton1.BorderColor = System.Drawing.Color.DarkCyan
        Me.GunaButton1.BorderSize = 2
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton1.ForeColor = System.Drawing.Color.DarkCyan
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(1003, 16)
        Me.GunaButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 15
        Me.GunaButton1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GunaButton1.Size = New System.Drawing.Size(61, 32)
        Me.GunaButton1.TabIndex = 92
        Me.GunaButton1.Text = "Back"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RekamMedis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1097, 549)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.GunaLabel10)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RekamMedis"
        Me.Text = "RekamMedis"
        Me.GunaPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RekamMedis21 As RekamMedis2
    Friend WithEvents RekamMedis22 As RekamMedis2
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents RekamMedis23 As RekamMedis2
    Friend WithEvents Button1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents TextBox2 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents DateTimePicker1 As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TextBox1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
End Class
