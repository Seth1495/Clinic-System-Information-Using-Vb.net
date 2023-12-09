<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Report
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
        Me.LayananObat5 = New TindakanObat.LayananObat()
        Me.LayananObat4 = New TindakanObat.LayananObat()
        Me.LayananObat2 = New TindakanObat.LayananObat()
        Me.LayananObat1 = New TindakanObat.LayananObat()
        Me.LayananObat3 = New TindakanObat.LayananObat()
        Me.Button1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.TextBox1 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GunaPanel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Button1.Location = New System.Drawing.Point(808, 49)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen
        Me.Button1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Button1.OnHoverForeColor = System.Drawing.Color.White
        Me.Button1.OnHoverImage = Nothing
        Me.Button1.OnPressedColor = System.Drawing.Color.Black
        Me.Button1.Radius = 21
        Me.Button1.Size = New System.Drawing.Size(184, 42)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Cari"
        Me.Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.DarkCyan
        Me.GunaLabel7.Location = New System.Drawing.Point(14, 28)
        Me.GunaLabel7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(105, 20)
        Me.GunaLabel7.TabIndex = 38
        Me.GunaLabel7.Text = "Layanan Obat"
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
        Me.TextBox1.Location = New System.Drawing.Point(17, 50)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox1.Radius = 20
        Me.TextBox1.SelectedText = ""
        Me.TextBox1.Size = New System.Drawing.Size(787, 41)
        Me.TextBox1.TabIndex = 37
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Controls.Add(Me.crv)
        Me.GunaPanel1.Location = New System.Drawing.Point(17, 96)
        Me.GunaPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(976, 421)
        Me.GunaPanel1.TabIndex = 36
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv.Location = New System.Drawing.Point(0, 0)
        Me.crv.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.crv.Name = "crv"
        Me.crv.Size = New System.Drawing.Size(976, 421)
        Me.crv.TabIndex = 0
        Me.crv.ToolPanelWidth = 150
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1007, 544)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GunaLabel7)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Report"
        Me.Text = "Report"
        Me.GunaPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LayananObat1 As LayananObat
    Friend WithEvents LayananObat2 As LayananObat
    Friend WithEvents LayananObat4 As LayananObat
    Friend WithEvents LayananObat3 As LayananObat
    Friend WithEvents LayananObat5 As LayananObat
    Friend WithEvents Button1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TextBox1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
