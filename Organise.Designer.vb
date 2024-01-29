<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Organise
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Organise))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.txtCertificate = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.txtExpense = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtTopic = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cmdOrg = New System.Windows.Forms.ComboBox()
        Me.txtRperson = New System.Windows.Forms.TextBox()
        Me.cmdCategory = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Male = New System.Windows.Forms.RadioButton()
        Me.Female = New System.Windows.Forms.RadioButton()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(847, 364)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(243, 10)
        Me.ProgressBar1.TabIndex = 165
        '
        'txtCertificate
        '
        Me.txtCertificate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCertificate.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCertificate.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtCertificate.Location = New System.Drawing.Point(847, 332)
        Me.txtCertificate.Name = "txtCertificate"
        Me.txtCertificate.Size = New System.Drawing.Size(243, 27)
        Me.txtCertificate.TabIndex = 164
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Location = New System.Drawing.Point(661, 336)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(145, 23)
        Me.Label11.TabIndex = 163
        Me.Label11.Text = "INVITATION"
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.Color.Black
        Me.btnPrev.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPrev.Location = New System.Drawing.Point(9, 12)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(88, 31)
        Me.btnPrev.TabIndex = 162
        Me.btnPrev.Text = "HOME"
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBrowse.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnBrowse.Location = New System.Drawing.Point(847, 389)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(111, 34)
        Me.btnBrowse.TabIndex = 161
        Me.btnBrowse.Text = "BROWSE"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button6.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button6.Location = New System.Drawing.Point(979, 389)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(111, 34)
        Me.Button6.TabIndex = 159
        Me.Button6.Text = "UPLOAD"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'txtExpense
        '
        Me.txtExpense.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtExpense.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpense.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtExpense.Location = New System.Drawing.Point(1052, 221)
        Me.txtExpense.Name = "txtExpense"
        Me.txtExpense.Size = New System.Drawing.Size(71, 26)
        Me.txtExpense.TabIndex = 158
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Location = New System.Drawing.Point(913, 221)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(122, 23)
        Me.Label12.TabIndex = 157
        Me.Label12.Text = "EXPENSES"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExit.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnExit.Location = New System.Drawing.Point(1217, 666)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(128, 45)
        Me.btnExit.TabIndex = 139
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtName.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtName.Location = New System.Drawing.Point(321, 171)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(269, 27)
        Me.txtName.TabIndex = 156
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnPrint.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnPrint.Location = New System.Drawing.Point(1162, 438)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(128, 45)
        Me.btnPrint.TabIndex = 138
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(62, 175)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(165, 23)
        Me.Label8.TabIndex = 155
        Me.Label8.Text = "DEPARTMENT"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDelete.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDelete.Location = New System.Drawing.Point(1162, 345)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(128, 45)
        Me.btnDelete.TabIndex = 137
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtSearch.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtSearch.Location = New System.Drawing.Point(241, 401)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(334, 27)
        Me.txtSearch.TabIndex = 154
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnUpdate.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnUpdate.Location = New System.Drawing.Point(1162, 252)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(128, 45)
        Me.btnUpdate.TabIndex = 136
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(321, 328)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(269, 26)
        Me.DateTimePicker1.TabIndex = 153
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnReset.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnReset.Location = New System.Drawing.Point(1162, 159)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(128, 45)
        Me.btnReset.TabIndex = 135
        Me.btnReset.Text = " RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Location = New System.Drawing.Point(76, 405)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 22)
        Me.Label10.TabIndex = 152
        Me.Label10.Text = "SEARCH"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(68, 449)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(995, 205)
        Me.DataGridView1.TabIndex = 151
        '
        'txtTopic
        '
        Me.txtTopic.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtTopic.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopic.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtTopic.Location = New System.Drawing.Point(321, 121)
        Me.txtTopic.Name = "txtTopic"
        Me.txtTopic.Size = New System.Drawing.Size(269, 27)
        Me.txtTopic.TabIndex = 150
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(62, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 23)
        Me.Label9.TabIndex = 149
        Me.Label9.Text = "TOPIC"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAdd.Location = New System.Drawing.Point(1162, 70)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(128, 45)
        Me.btnAdd.TabIndex = 134
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'cmdOrg
        '
        Me.cmdOrg.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdOrg.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOrg.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdOrg.FormattingEnabled = True
        Me.cmdOrg.Items.AddRange(New Object() {"LOCAL ", "STATE", "NATIONAL", "INTERNATIONAL"})
        Me.cmdOrg.Location = New System.Drawing.Point(321, 274)
        Me.cmdOrg.Name = "cmdOrg"
        Me.cmdOrg.Size = New System.Drawing.Size(269, 27)
        Me.cmdOrg.TabIndex = 148
        Me.cmdOrg.Text = "  -SELECT-"
        '
        'txtRperson
        '
        Me.txtRperson.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtRperson.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRperson.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtRperson.Location = New System.Drawing.Point(321, 221)
        Me.txtRperson.Name = "txtRperson"
        Me.txtRperson.Size = New System.Drawing.Size(269, 27)
        Me.txtRperson.TabIndex = 147
        '
        'cmdCategory
        '
        Me.cmdCategory.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdCategory.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCategory.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdCategory.FormattingEnabled = True
        Me.cmdCategory.Items.AddRange(New Object() {"FDP", "CONFERNCE", "WORKSHOP", "WEBINAR", "SDP"})
        Me.cmdCategory.Location = New System.Drawing.Point(847, 122)
        Me.cmdCategory.Name = "cmdCategory"
        Me.cmdCategory.Size = New System.Drawing.Size(243, 27)
        Me.cmdCategory.TabIndex = 146
        Me.cmdCategory.Text = "  -SELECT-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(62, 332)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 23)
        Me.Label7.TabIndex = 145
        Me.Label7.Text = "DATE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(62, 279)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(181, 23)
        Me.Label6.TabIndex = 144
        Me.Label6.Text = "ORGANISATION"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(62, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(223, 23)
        Me.Label5.TabIndex = 143
        Me.Label5.Text = "RESOURCE PERSON"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(661, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 23)
        Me.Label4.TabIndex = 142
        Me.Label4.Text = "CATEGORY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Imprint MT Shadow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(561, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(313, 28)
        Me.Label2.TabIndex = 141
        Me.Label2.Text = "ORGANIZED BY STAFF" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Imprint MT Shadow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(386, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(666, 28)
        Me.Label1.TabIndex = 140
        Me.Label1.Text = "FDP/CONFERENCE/WORKSHOP/WEBINAR/SDP "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(661, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 23)
        Me.Label3.TabIndex = 166
        Me.Label3.Text = "GENDER"
        '
        'Male
        '
        Me.Male.AutoSize = True
        Me.Male.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Male.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Male.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Male.Location = New System.Drawing.Point(865, 171)
        Me.Male.Name = "Male"
        Me.Male.Size = New System.Drawing.Size(72, 23)
        Me.Male.TabIndex = 167
        Me.Male.TabStop = True
        Me.Male.Text = "MALE"
        Me.Male.UseVisualStyleBackColor = False
        '
        'Female
        '
        Me.Female.AutoSize = True
        Me.Female.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Female.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Female.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Female.Location = New System.Drawing.Point(986, 170)
        Me.Female.Name = "Female"
        Me.Female.Size = New System.Drawing.Size(91, 23)
        Me.Female.TabIndex = 168
        Me.Female.TabStop = True
        Me.Female.Text = "FEMALE"
        Me.Female.UseVisualStyleBackColor = False
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
        'Timer1
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label13.Location = New System.Drawing.Point(661, 279)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 23)
        Me.Label13.TabIndex = 170
        Me.Label13.Text = "BALANCE"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label14.Location = New System.Drawing.Point(661, 211)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(125, 46)
        Me.Label14.TabIndex = 171
        Me.Label14.Text = "GRANTED " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    AMT"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox1.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox1.Location = New System.Drawing.Point(812, 221)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(71, 26)
        Me.TextBox1.TabIndex = 172
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Department_Elevate_project.My.Resources.Resources.WhatsApp_Image_2022_02_14_at_7_47_56_PM
        Me.PictureBox1.Location = New System.Drawing.Point(-6, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1423, 781)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 169
        Me.PictureBox1.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox2.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox2.Location = New System.Drawing.Point(847, 279)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(90, 26)
        Me.TextBox2.TabIndex = 173
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Location = New System.Drawing.Point(966, 279)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 30)
        Me.Button1.TabIndex = 174
        Me.Button1.Text = "BAL."
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Organise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 735)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Female)
        Me.Controls.Add(Me.Male)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.txtCertificate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.txtExpense)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtTopic)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cmdOrg)
        Me.Controls.Add(Me.txtRperson)
        Me.Controls.Add(Me.cmdCategory)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Organise"
        Me.Text = "Organise"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents txtCertificate As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents txtExpense As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnReset As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtTopic As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents cmdOrg As ComboBox
    Friend WithEvents txtRperson As TextBox
    Friend WithEvents cmdCategory As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Male As RadioButton
    Friend WithEvents Female As RadioButton
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
End Class
