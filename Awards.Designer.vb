<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Awards
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Awards))
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtClg = New System.Windows.Forms.TextBox()
        Me.txtOrg = New System.Windows.Forms.TextBox()
        Me.txtEname = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cmdType = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Male = New System.Windows.Forms.RadioButton()
        Me.Female = New System.Windows.Forms.RadioButton()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCertificate = New System.Windows.Forms.TextBox()
        Me.cmdPrize = New System.Windows.Forms.ComboBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdRegno = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Silver
        Me.DateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.White
        Me.DateTimePicker1.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(791, 172)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(219, 26)
        Me.DateTimePicker1.TabIndex = 32
        '
        'txtClg
        '
        Me.txtClg.BackColor = System.Drawing.Color.Gainsboro
        Me.txtClg.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClg.Location = New System.Drawing.Point(791, 125)
        Me.txtClg.Name = "txtClg"
        Me.txtClg.Size = New System.Drawing.Size(219, 27)
        Me.txtClg.TabIndex = 27
        '
        'txtOrg
        '
        Me.txtOrg.BackColor = System.Drawing.Color.Gainsboro
        Me.txtOrg.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrg.Location = New System.Drawing.Point(287, 314)
        Me.txtOrg.Name = "txtOrg"
        Me.txtOrg.Size = New System.Drawing.Size(219, 27)
        Me.txtOrg.TabIndex = 26
        '
        'txtEname
        '
        Me.txtEname.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEname.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEname.Location = New System.Drawing.Point(287, 267)
        Me.txtEname.Name = "txtEname"
        Me.txtEname.Size = New System.Drawing.Size(219, 27)
        Me.txtEname.TabIndex = 25
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtName.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(287, 175)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(219, 27)
        Me.txtName.TabIndex = 24
        '
        'cmdType
        '
        Me.cmdType.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdType.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdType.FormattingEnabled = True
        Me.cmdType.Items.AddRange(New Object() {"STUDENT", "STAFF"})
        Me.cmdType.Location = New System.Drawing.Point(287, 221)
        Me.cmdType.Name = "cmdType"
        Me.cmdType.Size = New System.Drawing.Size(219, 27)
        Me.cmdType.TabIndex = 23
        Me.cmdType.Text = " -SELECT-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(575, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 23)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "DATE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(575, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 23)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "COLLEGE NAME"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(70, 310)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 23)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "ORGANIZATION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(70, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 23)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "EVENT NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(70, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 23)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(70, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 23)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "TYPE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Imprint MT Shadow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(460, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(468, 38)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "AWARDS / RECOGNITION"
        '
        'btnADD
        '
        Me.btnADD.BackColor = System.Drawing.Color.Black
        Me.btnADD.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnADD.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnADD.Location = New System.Drawing.Point(1122, 133)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(146, 47)
        Me.btnADD.TabIndex = 29
        Me.btnADD.Text = "ADD"
        Me.btnADD.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Black
        Me.btnReset.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReset.Location = New System.Drawing.Point(1122, 222)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(146, 47)
        Me.btnReset.TabIndex = 30
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Black
        Me.btnUpdate.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUpdate.Location = New System.Drawing.Point(1122, 317)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(146, 47)
        Me.btnUpdate.TabIndex = 31
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Black
        Me.btnDelete.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDelete.Location = New System.Drawing.Point(1122, 410)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(146, 47)
        Me.btnDelete.TabIndex = 32
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Black
        Me.btnPrint.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPrint.Location = New System.Drawing.Point(1122, 502)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(146, 47)
        Me.btnPrint.TabIndex = 33
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DarkGoldenrod
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(74, 469)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(970, 226)
        Me.DataGridView1.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(575, 221)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 23)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "GENDER"
        '
        'Male
        '
        Me.Male.AutoSize = True
        Me.Male.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Male.Location = New System.Drawing.Point(791, 222)
        Me.Male.Name = "Male"
        Me.Male.Size = New System.Drawing.Size(65, 23)
        Me.Male.TabIndex = 38
        Me.Male.TabStop = True
        Me.Male.Text = "Male"
        Me.Male.UseVisualStyleBackColor = True
        '
        'Female
        '
        Me.Female.AutoSize = True
        Me.Female.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Female.Location = New System.Drawing.Point(927, 221)
        Me.Female.Name = "Female"
        Me.Female.Size = New System.Drawing.Size(82, 23)
        Me.Female.TabIndex = 39
        Me.Female.TabStop = True
        Me.Female.Text = "Female"
        Me.Female.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSearch.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(213, 417)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(299, 26)
        Me.txtSearch.TabIndex = 42
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(80, 421)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 23)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "SEARCH"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.Location = New System.Drawing.Point(1122, 588)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(146, 47)
        Me.btnExit.TabIndex = 34
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.Color.Black
        Me.btnPrev.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPrev.Location = New System.Drawing.Point(23, 12)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(81, 31)
        Me.btnPrev.TabIndex = 44
        Me.btnPrev.Text = "PREV"
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(70, 129)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(166, 23)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "REGISTER NO."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(575, 266)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 23)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "PRIZE"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(575, 313)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(161, 23)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "CERTIFICATE"
        '
        'txtCertificate
        '
        Me.txtCertificate.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCertificate.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCertificate.Location = New System.Drawing.Point(791, 314)
        Me.txtCertificate.Name = "txtCertificate"
        Me.txtCertificate.Size = New System.Drawing.Size(219, 27)
        Me.txtCertificate.TabIndex = 50
        '
        'cmdPrize
        '
        Me.cmdPrize.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdPrize.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrize.FormattingEnabled = True
        Me.cmdPrize.Items.AddRange(New Object() {"WINNERS", "RUNNERS", "1st  PRIZE", "2nd  PRIZE", "3rd  PRIZE"})
        Me.cmdPrize.Location = New System.Drawing.Point(791, 270)
        Me.cmdPrize.Name = "cmdPrize"
        Me.cmdPrize.Size = New System.Drawing.Size(219, 27)
        Me.cmdPrize.TabIndex = 51
        Me.cmdPrize.Text = " -SELECT-"
        '
        'btnBrowse
        '
        Me.btnBrowse.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(627, 376)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(109, 34)
        Me.btnBrowse.TabIndex = 92
        Me.btnBrowse.Text = "BROWSE"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnUpload
        '
        Me.btnUpload.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.Location = New System.Drawing.Point(765, 376)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(109, 34)
        Me.btnUpload.TabIndex = 90
        Me.btnUpload.Text = "UPLOAD"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-327, -51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1701, 783)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'cmdRegno
        '
        Me.cmdRegno.BackColor = System.Drawing.Color.Gainsboro
        Me.cmdRegno.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRegno.FormattingEnabled = True
        Me.cmdRegno.Location = New System.Drawing.Point(288, 127)
        Me.cmdRegno.Name = "cmdRegno"
        Me.cmdRegno.Size = New System.Drawing.Size(218, 27)
        Me.cmdRegno.TabIndex = 93
        Me.cmdRegno.Text = "   -SELECT-"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(791, 347)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(219, 10)
        Me.ProgressBar1.TabIndex = 94
        '
        'Awards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 723)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.cmdRegno)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.cmdPrize)
        Me.Controls.Add(Me.txtCertificate)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Female)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Male)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnADD)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtClg)
        Me.Controls.Add(Me.txtOrg)
        Me.Controls.Add(Me.txtEname)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.cmdType)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Awards"
        Me.Text = "Awards"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtClg As TextBox
    Friend WithEvents txtOrg As TextBox
    Friend WithEvents txtEname As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents cmdType As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnADD As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Male As RadioButton
    Friend WithEvents Female As RadioButton
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCertificate As TextBox
    Friend WithEvents cmdPrize As ComboBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnUpload As Button
    Friend WithEvents cmdRegno As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
