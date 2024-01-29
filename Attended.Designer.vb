<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Attended
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Attended))
        Me.cmdOrg = New System.Windows.Forms.ComboBox()
        Me.txtRperson = New System.Windows.Forms.TextBox()
        Me.cmdCategory = New System.Windows.Forms.ComboBox()
        Me.cmdType = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTopic = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdOrg
        '
        Me.cmdOrg.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdOrg.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOrg.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdOrg.FormattingEnabled = True
        Me.cmdOrg.Items.AddRange(New Object() {"LOCAL ", "STATE", "NATIONAL", "INTERNATIONAL"})
        Me.cmdOrg.Location = New System.Drawing.Point(335, 265)
        Me.cmdOrg.Name = "cmdOrg"
        Me.cmdOrg.Size = New System.Drawing.Size(269, 27)
        Me.cmdOrg.TabIndex = 72
        Me.cmdOrg.Text = "  -SELECT-"
        '
        'txtRperson
        '
        Me.txtRperson.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtRperson.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRperson.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtRperson.Location = New System.Drawing.Point(335, 213)
        Me.txtRperson.Name = "txtRperson"
        Me.txtRperson.Size = New System.Drawing.Size(269, 27)
        Me.txtRperson.TabIndex = 69
        '
        'cmdCategory
        '
        Me.cmdCategory.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdCategory.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCategory.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdCategory.FormattingEnabled = True
        Me.cmdCategory.Items.AddRange(New Object() {"FDP", "CONFERNCE", "WORKSHOP", "WEBINAR", "SDP"})
        Me.cmdCategory.Location = New System.Drawing.Point(844, 162)
        Me.cmdCategory.Name = "cmdCategory"
        Me.cmdCategory.Size = New System.Drawing.Size(243, 27)
        Me.cmdCategory.TabIndex = 68
        Me.cmdCategory.Text = "  -SELECT-"
        '
        'cmdType
        '
        Me.cmdType.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdType.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdType.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmdType.FormattingEnabled = True
        Me.cmdType.Items.AddRange(New Object() {"STAFF", "STUDENT"})
        Me.cmdType.Location = New System.Drawing.Point(844, 112)
        Me.cmdType.Name = "cmdType"
        Me.cmdType.Size = New System.Drawing.Size(243, 27)
        Me.cmdType.TabIndex = 67
        Me.cmdType.Text = "  -SELECT-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(76, 324)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 23)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "DATE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(76, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 23)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "ORGANISER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(76, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(223, 23)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "RESOURCE PERSON"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(658, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 23)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "CATEGORY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(658, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 23)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "TYPE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Imprint MT Shadow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(395, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(459, 28)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "ATTENDED BY STAFF/STUDENTS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Imprint MT Shadow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(299, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(666, 28)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "FDP/CONFERENCE/WORKSHOP/WEBINAR/SDP "
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExit.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnExit.Location = New System.Drawing.Point(1136, 572)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(128, 45)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnPrint.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnPrint.Location = New System.Drawing.Point(1136, 481)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(128, 45)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDelete.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDelete.Location = New System.Drawing.Point(1136, 388)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(128, 45)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnUpdate.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnUpdate.Location = New System.Drawing.Point(1136, 295)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(128, 45)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnReset.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnReset.Location = New System.Drawing.Point(1136, 202)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(128, 45)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAdd.Location = New System.Drawing.Point(1136, 113)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(128, 45)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(80, 446)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(995, 225)
        Me.DataGridView1.TabIndex = 76
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Location = New System.Drawing.Point(79, 403)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 22)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "SEARCH"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(335, 313)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(269, 27)
        Me.DateTimePicker1.TabIndex = 78
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
        Me.txtSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtSearch.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtSearch.Location = New System.Drawing.Point(199, 399)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(334, 27)
        Me.txtSearch.TabIndex = 79
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(76, 167)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 23)
        Me.Label9.TabIndex = 73
        Me.Label9.Text = "TOPIC"
        '
        'txtTopic
        '
        Me.txtTopic.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtTopic.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopic.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtTopic.Location = New System.Drawing.Point(335, 162)
        Me.txtTopic.Name = "txtTopic"
        Me.txtTopic.Size = New System.Drawing.Size(269, 27)
        Me.txtTopic.TabIndex = 74
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtName.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtName.Location = New System.Drawing.Point(335, 110)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(269, 27)
        Me.txtName.TabIndex = 81
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(79, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 23)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "NAME"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox2.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox2.Location = New System.Drawing.Point(844, 212)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(243, 27)
        Me.TextBox2.TabIndex = 83
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Location = New System.Drawing.Point(658, 213)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(161, 23)
        Me.Label12.TabIndex = 82
        Me.Label12.Text = "CERTIFICATE"
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBrowse.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnBrowse.Location = New System.Drawing.Point(844, 280)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(111, 34)
        Me.btnBrowse.TabIndex = 96
        Me.btnBrowse.Text = "BROWSE"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnUpload.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnUpload.Location = New System.Drawing.Point(976, 280)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(111, 34)
        Me.btnUpload.TabIndex = 94
        Me.btnUpload.Text = "UPLOAD"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.Color.Black
        Me.btnPrev.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPrev.Location = New System.Drawing.Point(21, 25)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(81, 31)
        Me.btnPrev.TabIndex = 131
        Me.btnPrev.Text = "PREV"
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1371, 721)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 97
        Me.PictureBox1.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(844, 247)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(243, 12)
        Me.ProgressBar1.TabIndex = 132
        '
        'Attended
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 707)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.TextBox2)
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
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtTopic)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmdOrg)
        Me.Controls.Add(Me.txtRperson)
        Me.Controls.Add(Me.cmdCategory)
        Me.Controls.Add(Me.cmdType)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Attended"
        Me.Text = "Attended"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdOrg As ComboBox
    Friend WithEvents txtRperson As TextBox
    Friend WithEvents cmdCategory As ComboBox
    Friend WithEvents cmdType As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTopic As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnUpload As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnPrev As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
