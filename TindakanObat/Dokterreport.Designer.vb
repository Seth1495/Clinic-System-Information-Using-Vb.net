<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dokterreport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.doktercrv1 = New TindakanObat.doktercrv()
        Me.Button2 = New Guna.UI.WinForms.GunaButton()
        Me.DateTimePicker2 = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.DateTimePicker1 = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Button1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.CRV = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.doktercrv2 = New TindakanObat.doktercrv()
        Me.GunaPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.AnimationHoverSpeed = 0.07!
        Me.Button2.AnimationSpeed = 0.03!
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BaseColor = System.Drawing.Color.White
        Me.Button2.BorderColor = System.Drawing.Color.DarkCyan
        Me.Button2.BorderSize = 2
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Button2.FocusedColor = System.Drawing.Color.Empty
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DarkCyan
        Me.Button2.Image = Nothing
        Me.Button2.ImageSize = New System.Drawing.Size(20, 20)
        Me.Button2.Location = New System.Drawing.Point(1172, 70)
        Me.Button2.Name = "Button2"
        Me.Button2.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen
        Me.Button2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Button2.OnHoverForeColor = System.Drawing.Color.White
        Me.Button2.OnHoverImage = Nothing
        Me.Button2.OnPressedColor = System.Drawing.Color.Black
        Me.Button2.Radius = 20
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button2.Size = New System.Drawing.Size(152, 50)
        Me.Button2.TabIndex = 54
        Me.Button2.Text = "Next"
        Me.Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.BackColor = System.Drawing.Color.Transparent
        Me.DateTimePicker2.BaseColor = System.Drawing.Color.White
        Me.DateTimePicker2.BorderColor = System.Drawing.Color.Silver
        Me.DateTimePicker2.CustomFormat = Nothing
        Me.DateTimePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePicker2.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateTimePicker2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DateTimePicker2.ForeColor = System.Drawing.Color.Black
        Me.DateTimePicker2.Location = New System.Drawing.Point(511, 64)
        Me.DateTimePicker2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.OnHoverBaseColor = System.Drawing.Color.White
        Me.DateTimePicker2.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateTimePicker2.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateTimePicker2.OnPressedColor = System.Drawing.Color.Black
        Me.DateTimePicker2.Radius = 20
        Me.DateTimePicker2.Size = New System.Drawing.Size(451, 48)
        Me.DateTimePicker2.TabIndex = 53
        Me.DateTimePicker2.Text = "Wednesday, 07 June 2023"
        Me.DateTimePicker2.Value = New Date(2023, 6, 7, 0, 44, 55, 800)
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
        Me.DateTimePicker1.Location = New System.Drawing.Point(23, 64)
        Me.DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.OnHoverBaseColor = System.Drawing.Color.White
        Me.DateTimePicker1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateTimePicker1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateTimePicker1.OnPressedColor = System.Drawing.Color.Black
        Me.DateTimePicker1.Radius = 20
        Me.DateTimePicker1.Size = New System.Drawing.Size(451, 48)
        Me.DateTimePicker1.TabIndex = 52
        Me.DateTimePicker1.Text = "Wednesday, 07 June 2023"
        Me.DateTimePicker1.Value = New Date(2023, 6, 7, 0, 44, 55, 800)
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.DarkCyan
        Me.GunaLabel1.Location = New System.Drawing.Point(480, 70)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(25, 32)
        Me.GunaLabel1.TabIndex = 51
        Me.GunaLabel1.Text = "-"
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
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Nothing
        Me.Button1.ImageSize = New System.Drawing.Size(20, 20)
        Me.Button1.Location = New System.Drawing.Point(968, 70)
        Me.Button1.Name = "Button1"
        Me.Button1.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen
        Me.Button1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Button1.OnHoverForeColor = System.Drawing.Color.White
        Me.Button1.OnHoverImage = Nothing
        Me.Button1.OnPressedColor = System.Drawing.Color.Black
        Me.Button1.Radius = 21
        Me.Button1.Size = New System.Drawing.Size(198, 42)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "Cari"
        Me.Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.DarkCyan
        Me.GunaLabel7.Location = New System.Drawing.Point(18, 34)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(143, 25)
        Me.GunaLabel7.TabIndex = 49
        Me.GunaLabel7.Text = "Range Tanggal"
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Controls.Add(Me.CRV)
        Me.GunaPanel1.Location = New System.Drawing.Point(23, 118)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(1301, 518)
        Me.GunaPanel1.TabIndex = 48
        '
        'CRV
        '
        Me.CRV.ActiveViewIndex = 0
        Me.CRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV.Location = New System.Drawing.Point(0, 0)
        Me.CRV.Name = "CRV"
        Me.CRV.ReportSource = Me.doktercrv2
        Me.CRV.Size = New System.Drawing.Size(1301, 518)
        Me.CRV.TabIndex = 0
        '
        'Dokterreport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1343, 670)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GunaLabel7)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Dokterreport"
        Me.Text = "Dokterreport"
        Me.GunaPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents doktercrv1 As doktercrv
    Friend WithEvents Button2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents DateTimePicker2 As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents DateTimePicker1 As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Button1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents CRV As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents doktercrv2 As doktercrv
End Class
