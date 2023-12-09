<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KartuDokter
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
        Me.IDDokter1 = New TindakanObat.IDDokter()
        Me.ID6 = New TindakanObat.ID()
        Me.ID5 = New TindakanObat.ID()
        Me.IDDokter3 = New TindakanObat.IDDokter()
        Me.IDDokter2 = New TindakanObat.IDDokter()
        Me.IDDokter4 = New TindakanObat.IDDokter()
        Me.ID2 = New TindakanObat.ID()
        Me.ID1 = New TindakanObat.ID()
        Me.ID3 = New TindakanObat.ID()
        Me.ID4 = New TindakanObat.ID()
        Me.IDDokter5 = New TindakanObat.IDDokter()
        Me.Button1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.TextBox1 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.IDDokter6 = New TindakanObat.IDDokter()
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
        Me.Button1.Location = New System.Drawing.Point(1078, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen
        Me.Button1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Button1.OnHoverForeColor = System.Drawing.Color.White
        Me.Button1.OnHoverImage = Nothing
        Me.Button1.OnPressedColor = System.Drawing.Color.Black
        Me.Button1.Radius = 21
        Me.Button1.Size = New System.Drawing.Size(246, 52)
        Me.Button1.TabIndex = 45
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
        Me.GunaLabel7.Size = New System.Drawing.Size(72, 25)
        Me.GunaLabel7.TabIndex = 44
        Me.GunaLabel7.Text = "Cari ID"
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
        Me.TextBox1.Location = New System.Drawing.Point(23, 62)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox1.Radius = 20
        Me.TextBox1.SelectedText = ""
        Me.TextBox1.Size = New System.Drawing.Size(1049, 50)
        Me.TextBox1.TabIndex = 43
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Controls.Add(Me.crv)
        Me.GunaPanel1.Location = New System.Drawing.Point(23, 129)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(1301, 518)
        Me.GunaPanel1.TabIndex = 42
        '
        'crv
        '
        Me.crv.ActiveViewIndex = 0
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crv.Location = New System.Drawing.Point(0, 0)
        Me.crv.Name = "crv"
        Me.crv.ReportSource = Me.IDDokter6
        Me.crv.Size = New System.Drawing.Size(1301, 518)
        Me.crv.TabIndex = 0
        '
        'KartuDokter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1343, 670)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GunaLabel7)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "KartuDokter"
        Me.Text = "KartuDokter"
        Me.GunaPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    ' Friend WithEvents DokterCard1 As DokterCard
    Friend WithEvents IDDokter1 As IDDokter
    Friend WithEvents IDDokter2 As IDDokter
    Friend WithEvents IDDokter3 As IDDokter
    Friend WithEvents ID1 As ID
    Friend WithEvents ID2 As ID
    Friend WithEvents ID3 As ID
    Friend WithEvents IDDokter4 As IDDokter
    Friend WithEvents ID4 As ID
    Friend WithEvents ID5 As ID
    Friend WithEvents IDDokter5 As IDDokter
    Friend WithEvents ID6 As ID
    Friend WithEvents Button1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TextBox1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents IDDokter6 As IDDokter
End Class
