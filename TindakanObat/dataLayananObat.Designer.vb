<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dataLayananObat
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Button7 = New Guna.UI.WinForms.GunaButton()
        Me.Button6 = New Guna.UI.WinForms.GunaButton()
        Me.Jenis = New Guna.UI.WinForms.GunaComboBox()
        Me.DGV = New Guna.UI.WinForms.GunaDataGridView()
        Me.Button5 = New Guna.UI.WinForms.GunaButton()
        Me.Button4 = New Guna.UI.WinForms.GunaButton()
        Me.Button3 = New Guna.UI.WinForms.GunaButton()
        Me.Button2 = New Guna.UI.WinForms.GunaButton()
        Me.Button1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.l = New Guna.UI.WinForms.GunaLabel()
        Me.txtStokObat = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.txtDiagnosa = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.txtNamaLO = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.txtHarga = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.txtLayananObat = New Guna.UI.WinForms.GunaTextBox()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button7
        '
        Me.Button7.AnimationHoverSpeed = 0.07!
        Me.Button7.AnimationSpeed = 0.03!
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.BaseColor = System.Drawing.Color.White
        Me.Button7.BorderColor = System.Drawing.Color.DarkCyan
        Me.Button7.BorderSize = 2
        Me.Button7.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Button7.FocusedColor = System.Drawing.Color.Empty
        Me.Button7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.DarkCyan
        Me.Button7.Image = Nothing
        Me.Button7.ImageSize = New System.Drawing.Size(20, 20)
        Me.Button7.Location = New System.Drawing.Point(58, 281)
        Me.Button7.Name = "Button7"
        Me.Button7.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen
        Me.Button7.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Button7.OnHoverForeColor = System.Drawing.Color.White
        Me.Button7.OnHoverImage = Nothing
        Me.Button7.OnPressedColor = System.Drawing.Color.Black
        Me.Button7.Radius = 20
        Me.Button7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button7.Size = New System.Drawing.Size(310, 50)
        Me.Button7.TabIndex = 66
        Me.Button7.Text = "Transfer to Excel"
        Me.Button7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.Button6.Location = New System.Drawing.Point(1087, 218)
        Me.Button6.Name = "Button6"
        Me.Button6.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen
        Me.Button6.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Button6.OnHoverForeColor = System.Drawing.Color.White
        Me.Button6.OnHoverImage = Nothing
        Me.Button6.OnPressedColor = System.Drawing.Color.Black
        Me.Button6.Radius = 20
        Me.Button6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button6.Size = New System.Drawing.Size(199, 50)
        Me.Button6.TabIndex = 65
        Me.Button6.Text = "Exit"
        Me.Button6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Jenis
        '
        Me.Jenis.BackColor = System.Drawing.Color.Transparent
        Me.Jenis.BaseColor = System.Drawing.Color.White
        Me.Jenis.BorderColor = System.Drawing.Color.Silver
        Me.Jenis.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Jenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Jenis.FocusedColor = System.Drawing.Color.Empty
        Me.Jenis.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Jenis.ForeColor = System.Drawing.Color.Black
        Me.Jenis.FormattingEnabled = True
        Me.Jenis.ItemHeight = 42
        Me.Jenis.Items.AddRange(New Object() {"Layanan", "Obat"})
        Me.Jenis.Location = New System.Drawing.Point(882, 157)
        Me.Jenis.Name = "Jenis"
        Me.Jenis.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Jenis.OnHoverItemForeColor = System.Drawing.Color.White
        Me.Jenis.Radius = 20
        Me.Jenis.Size = New System.Drawing.Size(406, 48)
        Me.Jenis.TabIndex = 64
        '
        'DGV
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.DefaultCellStyle = DataGridViewCellStyle9
        Me.DGV.EnableHeadersVisualStyles = False
        Me.DGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV.Location = New System.Drawing.Point(42, 346)
        Me.DGV.Name = "DGV"
        Me.DGV.RowHeadersVisible = False
        Me.DGV.RowTemplate.Height = 24
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(1258, 314)
        Me.DGV.TabIndex = 63
        Me.DGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.DGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGV.ThemeStyle.BackColor = System.Drawing.SystemColors.Control
        Me.DGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV.ThemeStyle.HeaderStyle.Height = 23
        Me.DGV.ThemeStyle.ReadOnly = False
        Me.DGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV.ThemeStyle.RowsStyle.Height = 24
        Me.DGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        Me.Button5.Location = New System.Drawing.Point(882, 218)
        Me.Button5.Name = "Button5"
        Me.Button5.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen
        Me.Button5.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Button5.OnHoverForeColor = System.Drawing.Color.White
        Me.Button5.OnHoverImage = Nothing
        Me.Button5.OnPressedColor = System.Drawing.Color.Black
        Me.Button5.Radius = 20
        Me.Button5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button5.Size = New System.Drawing.Size(199, 50)
        Me.Button5.TabIndex = 62
        Me.Button5.Text = "CANCEL"
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
        Me.Button4.Location = New System.Drawing.Point(677, 218)
        Me.Button4.Name = "Button4"
        Me.Button4.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen
        Me.Button4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Button4.OnHoverForeColor = System.Drawing.Color.White
        Me.Button4.OnHoverImage = Nothing
        Me.Button4.OnPressedColor = System.Drawing.Color.Black
        Me.Button4.Radius = 20
        Me.Button4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button4.Size = New System.Drawing.Size(199, 50)
        Me.Button4.TabIndex = 61
        Me.Button4.Text = "DELETE"
        Me.Button4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.Button3.Location = New System.Drawing.Point(472, 218)
        Me.Button3.Name = "Button3"
        Me.Button3.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen
        Me.Button3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Button3.OnHoverForeColor = System.Drawing.Color.White
        Me.Button3.OnHoverImage = Nothing
        Me.Button3.OnPressedColor = System.Drawing.Color.Black
        Me.Button3.Radius = 20
        Me.Button3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button3.Size = New System.Drawing.Size(199, 50)
        Me.Button3.TabIndex = 60
        Me.Button3.Text = "EDIT"
        Me.Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.Button2.Location = New System.Drawing.Point(267, 218)
        Me.Button2.Name = "Button2"
        Me.Button2.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen
        Me.Button2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Button2.OnHoverForeColor = System.Drawing.Color.White
        Me.Button2.OnHoverImage = Nothing
        Me.Button2.OnPressedColor = System.Drawing.Color.Black
        Me.Button2.Radius = 20
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button2.Size = New System.Drawing.Size(199, 50)
        Me.Button2.TabIndex = 59
        Me.Button2.Text = "SAVE"
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
        Me.Button1.Location = New System.Drawing.Point(62, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen
        Me.Button1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Button1.OnHoverForeColor = System.Drawing.Color.White
        Me.Button1.OnHoverImage = Nothing
        Me.Button1.OnPressedColor = System.Drawing.Color.Black
        Me.Button1.Radius = 20
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(199, 50)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "INPUT"
        Me.Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.ForeColor = System.Drawing.Color.DarkCyan
        Me.GunaLabel5.Location = New System.Drawing.Point(877, 115)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(55, 25)
        Me.GunaLabel5.TabIndex = 57
        Me.GunaLabel5.Text = "Jenis"
        '
        'l
        '
        Me.l.AutoSize = True
        Me.l.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l.ForeColor = System.Drawing.Color.DarkCyan
        Me.l.Location = New System.Drawing.Point(53, 113)
        Me.l.Name = "l"
        Me.l.Size = New System.Drawing.Size(62, 25)
        Me.l.TabIndex = 56
        Me.l.Text = "Stock"
        '
        'txtStokObat
        '
        Me.txtStokObat.BackColor = System.Drawing.Color.Transparent
        Me.txtStokObat.BaseColor = System.Drawing.Color.White
        Me.txtStokObat.BorderColor = System.Drawing.Color.Silver
        Me.txtStokObat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStokObat.FocusedBaseColor = System.Drawing.Color.White
        Me.txtStokObat.FocusedBorderColor = System.Drawing.Color.DarkCyan
        Me.txtStokObat.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtStokObat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStokObat.Location = New System.Drawing.Point(58, 155)
        Me.txtStokObat.Name = "txtStokObat"
        Me.txtStokObat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStokObat.Radius = 20
        Me.txtStokObat.SelectedText = ""
        Me.txtStokObat.Size = New System.Drawing.Size(406, 50)
        Me.txtStokObat.TabIndex = 55
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.ForeColor = System.Drawing.Color.DarkCyan
        Me.GunaLabel8.Location = New System.Drawing.Point(877, 11)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(95, 25)
        Me.GunaLabel8.TabIndex = 54
        Me.GunaLabel8.Text = "Diagnosa"
        '
        'txtDiagnosa
        '
        Me.txtDiagnosa.BackColor = System.Drawing.Color.Transparent
        Me.txtDiagnosa.BaseColor = System.Drawing.Color.White
        Me.txtDiagnosa.BorderColor = System.Drawing.Color.Silver
        Me.txtDiagnosa.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDiagnosa.FocusedBaseColor = System.Drawing.Color.White
        Me.txtDiagnosa.FocusedBorderColor = System.Drawing.Color.DarkCyan
        Me.txtDiagnosa.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDiagnosa.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDiagnosa.Location = New System.Drawing.Point(882, 53)
        Me.txtDiagnosa.Name = "txtDiagnosa"
        Me.txtDiagnosa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDiagnosa.Radius = 20
        Me.txtDiagnosa.SelectedText = ""
        Me.txtDiagnosa.Size = New System.Drawing.Size(406, 50)
        Me.txtDiagnosa.TabIndex = 53
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.DarkCyan
        Me.GunaLabel4.Location = New System.Drawing.Point(465, 11)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(191, 25)
        Me.GunaLabel4.TabIndex = 52
        Me.GunaLabel4.Text = "Nama Layanan Obat"
        '
        'txtNamaLO
        '
        Me.txtNamaLO.BackColor = System.Drawing.Color.Transparent
        Me.txtNamaLO.BaseColor = System.Drawing.Color.White
        Me.txtNamaLO.BorderColor = System.Drawing.Color.Silver
        Me.txtNamaLO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNamaLO.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNamaLO.FocusedBorderColor = System.Drawing.Color.DarkCyan
        Me.txtNamaLO.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNamaLO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNamaLO.Location = New System.Drawing.Point(470, 53)
        Me.txtNamaLO.Name = "txtNamaLO"
        Me.txtNamaLO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNamaLO.Radius = 20
        Me.txtNamaLO.SelectedText = ""
        Me.txtNamaLO.Size = New System.Drawing.Size(406, 50)
        Me.txtNamaLO.TabIndex = 51
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.DarkCyan
        Me.GunaLabel2.Location = New System.Drawing.Point(465, 115)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(67, 25)
        Me.GunaLabel2.TabIndex = 50
        Me.GunaLabel2.Text = "Harga"
        '
        'txtHarga
        '
        Me.txtHarga.BackColor = System.Drawing.Color.Transparent
        Me.txtHarga.BaseColor = System.Drawing.Color.White
        Me.txtHarga.BorderColor = System.Drawing.Color.Silver
        Me.txtHarga.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHarga.FocusedBaseColor = System.Drawing.Color.White
        Me.txtHarga.FocusedBorderColor = System.Drawing.Color.DarkCyan
        Me.txtHarga.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtHarga.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtHarga.Location = New System.Drawing.Point(470, 157)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHarga.Radius = 20
        Me.txtHarga.SelectedText = ""
        Me.txtHarga.Size = New System.Drawing.Size(406, 50)
        Me.txtHarga.TabIndex = 49
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.DarkCyan
        Me.GunaLabel1.Location = New System.Drawing.Point(53, 11)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(185, 25)
        Me.GunaLabel1.TabIndex = 48
        Me.GunaLabel1.Text = "Kode Layanan Obat"
        '
        'txtLayananObat
        '
        Me.txtLayananObat.BackColor = System.Drawing.Color.Transparent
        Me.txtLayananObat.BaseColor = System.Drawing.Color.White
        Me.txtLayananObat.BorderColor = System.Drawing.Color.Silver
        Me.txtLayananObat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLayananObat.FocusedBaseColor = System.Drawing.Color.White
        Me.txtLayananObat.FocusedBorderColor = System.Drawing.Color.DarkCyan
        Me.txtLayananObat.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtLayananObat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLayananObat.Location = New System.Drawing.Point(58, 53)
        Me.txtLayananObat.Name = "txtLayananObat"
        Me.txtLayananObat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLayananObat.Radius = 20
        Me.txtLayananObat.SelectedText = ""
        Me.txtLayananObat.Size = New System.Drawing.Size(406, 50)
        Me.txtLayananObat.TabIndex = 47
        '
        'dataLayananObat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1343, 670)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Jenis)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.l)
        Me.Controls.Add(Me.txtStokObat)
        Me.Controls.Add(Me.GunaLabel8)
        Me.Controls.Add(Me.txtDiagnosa)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.txtNamaLO)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.txtLayananObat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "dataLayananObat"
        Me.Text = "     "
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Button7 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Button6 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Jenis As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents DGV As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Button5 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Button4 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Button3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Button2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Button1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents l As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtStokObat As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtDiagnosa As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtNamaLO As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtHarga As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtLayananObat As Guna.UI.WinForms.GunaTextBox
End Class
