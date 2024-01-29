<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaperPublication
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaperPublication))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPid = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtOrg = New System.Windows.Forms.TextBox()
        Me.txtIssn = New System.Windows.Forms.TextBox()
        Me.txtPresent = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.cmdPub = New System.Windows.Forms.ComboBox()
        Me.cmdConf = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Male = New System.Windows.Forms.RadioButton()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Female = New System.Windows.Forms.RadioButton()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkSalmon
        Me.Label1.Font = New System.Drawing.Font("Imprint MT Shadow", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(483, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PAPER PUBLICATION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.BurlyWood
        Me.Label2.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PID."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.BurlyWood
        Me.Label3.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PUBLICATION BY"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.BurlyWood
        Me.Label4.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(241, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "NAME OF THE PAPER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.BurlyWood
        Me.Label5.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ORGANIZATION"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.BurlyWood
        Me.Label6.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(37, 338)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "DATE OF PUB."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.BurlyWood
        Me.Label7.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(581, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "ISBN / ISSN NO."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.BurlyWood
        Me.Label8.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(581, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(246, 23)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "TYPE OF CONFERNCE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.BurlyWood
        Me.Label9.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(582, 236)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(177, 23)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "PRESENTED BY"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.BurlyWood
        Me.Label10.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(582, 287)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 23)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "GENDER  "
        '
        'txtPid
        '
        Me.txtPid.BackColor = System.Drawing.Color.NavajoWhite
        Me.txtPid.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPid.Location = New System.Drawing.Point(297, 129)
        Me.txtPid.Name = "txtPid"
        Me.txtPid.Size = New System.Drawing.Size(201, 27)
        Me.txtPid.TabIndex = 11
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.NavajoWhite
        Me.txtName.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(297, 238)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(201, 27)
        Me.txtName.TabIndex = 12
        '
        'txtOrg
        '
        Me.txtOrg.BackColor = System.Drawing.Color.NavajoWhite
        Me.txtOrg.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrg.Location = New System.Drawing.Point(297, 286)
        Me.txtOrg.Name = "txtOrg"
        Me.txtOrg.Size = New System.Drawing.Size(201, 27)
        Me.txtOrg.TabIndex = 13
        '
        'txtIssn
        '
        Me.txtIssn.BackColor = System.Drawing.Color.NavajoWhite
        Me.txtIssn.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIssn.Location = New System.Drawing.Point(872, 129)
        Me.txtIssn.Name = "txtIssn"
        Me.txtIssn.Size = New System.Drawing.Size(195, 27)
        Me.txtIssn.TabIndex = 14
        '
        'txtPresent
        '
        Me.txtPresent.BackColor = System.Drawing.Color.NavajoWhite
        Me.txtPresent.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPresent.Location = New System.Drawing.Point(872, 235)
        Me.txtPresent.Name = "txtPresent"
        Me.txtPresent.Size = New System.Drawing.Size(195, 27)
        Me.txtPresent.TabIndex = 15
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.NavajoWhite
        Me.TextBox6.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(872, 337)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox6.Size = New System.Drawing.Size(195, 27)
        Me.TextBox6.TabIndex = 16
        '
        'cmdPub
        '
        Me.cmdPub.BackColor = System.Drawing.Color.NavajoWhite
        Me.cmdPub.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPub.FormattingEnabled = True
        Me.cmdPub.Items.AddRange(New Object() {"STAFF", "STUDENT"})
        Me.cmdPub.Location = New System.Drawing.Point(297, 183)
        Me.cmdPub.Name = "cmdPub"
        Me.cmdPub.Size = New System.Drawing.Size(201, 27)
        Me.cmdPub.TabIndex = 17
        '
        'cmdConf
        '
        Me.cmdConf.BackColor = System.Drawing.Color.NavajoWhite
        Me.cmdConf.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConf.FormattingEnabled = True
        Me.cmdConf.Items.AddRange(New Object() {"LOCAL", "STATE", "NATIONAL", "INTERNATIONAL"})
        Me.cmdConf.Location = New System.Drawing.Point(872, 181)
        Me.cmdConf.Name = "cmdConf"
        Me.cmdConf.Size = New System.Drawing.Size(195, 27)
        Me.cmdConf.TabIndex = 18
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(297, 337)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(201, 27)
        Me.DateTimePicker1.TabIndex = 19
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.NavajoWhite
        Me.txtSearch.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(187, 469)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(359, 27)
        Me.txtSearch.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.BurlyWood
        Me.Label11.Font = New System.Drawing.Font("Imprint MT Shadow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(39, 470)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 25)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "SEARCH"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Moccasin
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(41, 522)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1014, 202)
        Me.DataGridView1.TabIndex = 22
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.IndianRed
        Me.btnAdd.Font = New System.Drawing.Font("Imprint MT Shadow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(1139, 126)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(128, 39)
        Me.btnAdd.TabIndex = 23
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.IndianRed
        Me.btnReset.Font = New System.Drawing.Font("Imprint MT Shadow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(1139, 209)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(128, 41)
        Me.btnReset.TabIndex = 24
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.IndianRed
        Me.btnUpdate.Font = New System.Drawing.Font("Imprint MT Shadow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(1139, 299)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(128, 39)
        Me.btnUpdate.TabIndex = 25
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.IndianRed
        Me.btnDelete.Font = New System.Drawing.Font("Imprint MT Shadow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(1139, 385)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(128, 39)
        Me.btnDelete.TabIndex = 26
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.IndianRed
        Me.btnPrint.Font = New System.Drawing.Font("Imprint MT Shadow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(1139, 473)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(128, 39)
        Me.btnPrint.TabIndex = 27
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.IndianRed
        Me.btnExit.Font = New System.Drawing.Font("Imprint MT Shadow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(1139, 564)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(128, 39)
        Me.btnExit.TabIndex = 28
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.IndianRed
        Me.Button8.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(775, 385)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(128, 39)
        Me.Button8.TabIndex = 30
        Me.Button8.Text = "BROWSE"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.IndianRed
        Me.Button9.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(909, 386)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(128, 39)
        Me.Button9.TabIndex = 31
        Me.Button9.Text = "UPLOAD"
        Me.Button9.UseVisualStyleBackColor = False
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
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.BurlyWood
        Me.Label12.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(582, 338)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(161, 23)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "CERTIFICATE"
        '
        'Male
        '
        Me.Male.AutoSize = True
        Me.Male.BackColor = System.Drawing.Color.NavajoWhite
        Me.Male.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Male.Location = New System.Drawing.Point(872, 286)
        Me.Male.Name = "Male"
        Me.Male.Size = New System.Drawing.Size(72, 23)
        Me.Male.TabIndex = 33
        Me.Male.TabStop = True
        Me.Male.Text = "MALE"
        Me.Male.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.NavajoWhite
        Me.ProgressBar1.Location = New System.Drawing.Point(872, 369)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(195, 10)
        Me.ProgressBar1.TabIndex = 35
        '
        'Female
        '
        Me.Female.AutoSize = True
        Me.Female.BackColor = System.Drawing.Color.NavajoWhite
        Me.Female.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Female.Location = New System.Drawing.Point(987, 286)
        Me.Female.Name = "Female"
        Me.Female.Size = New System.Drawing.Size(91, 23)
        Me.Female.TabIndex = 36
        Me.Female.TabStop = True
        Me.Female.Text = "FEMALE"
        Me.Female.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.IndianRed
        Me.btnHome.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnHome.Location = New System.Drawing.Point(12, 12)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(87, 32)
        Me.btnHome.TabIndex = 42
        Me.btnHome.Text = "HOME"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1370, 751)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 170
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        '
        'PaperPublication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.Female)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Male)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cmdConf)
        Me.Controls.Add(Me.cmdPub)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.txtPresent)
        Me.Controls.Add(Me.txtIssn)
        Me.Controls.Add(Me.txtOrg)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtPid)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Corbel", 8.25!)
        Me.Name = "PaperPublication"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPid As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtOrg As TextBox
    Friend WithEvents txtIssn As TextBox
    Friend WithEvents txtPresent As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents cmdPub As ComboBox
    Friend WithEvents cmdConf As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label12 As Label
    Friend WithEvents Male As RadioButton
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Female As RadioButton
    Friend WithEvents btnHome As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Timer1 As Timer
End Class
