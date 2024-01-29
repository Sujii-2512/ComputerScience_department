<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class studentregister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(studentregister))
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnR = New System.Windows.Forms.Button()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSid = New System.Windows.Forms.TextBox()
        Me.txtSname = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtAdmin = New System.Windows.Forms.TextBox()
        Me.txtMob = New System.Windows.Forms.TextBox()
        Me.Male = New System.Windows.Forms.RadioButton()
        Me.Female = New System.Windows.Forms.RadioButton()
        Me.cmdCourse = New System.Windows.Forms.ComboBox()
        Me.cmdSem = New System.Windows.Forms.ComboBox()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Purple
        Me.Label1.Font = New System.Drawing.Font("Imprint MT Shadow", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(395, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(538, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STUDENT REGISTRATION FORM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(83, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(83, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "STUDENT NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(83, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "FATHER NAME"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(83, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ADDRESS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(83, 310)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 22)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "D.O.B"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(83, 357)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 22)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "EMAIL ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(668, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 22)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "ADMN NO."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(668, 215)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 22)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "COURSE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(668, 263)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 22)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "YEAR/SEM"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(668, 310)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 22)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "GENDER"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnExit.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.Location = New System.Drawing.Point(1141, 525)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(105, 38)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnPrint.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPrint.Location = New System.Drawing.Point(1141, 450)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(105, 38)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnDelete.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDelete.Location = New System.Drawing.Point(1141, 375)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(105, 38)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnUpdate.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUpdate.Location = New System.Drawing.Point(1141, 306)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(105, 38)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnR
        '
        Me.btnR.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnR.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnR.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnR.Location = New System.Drawing.Point(1141, 234)
        Me.btnR.Name = "btnR"
        Me.btnR.Size = New System.Drawing.Size(105, 38)
        Me.btnR.TabIndex = 1
        Me.btnR.Text = "RESET"
        Me.btnR.UseVisualStyleBackColor = False
        '
        'btnADD
        '
        Me.btnADD.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnADD.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnADD.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnADD.Location = New System.Drawing.Point(1141, 164)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(105, 38)
        Me.btnADD.TabIndex = 0
        Me.btnADD.Text = "ADD"
        Me.btnADD.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(668, 357)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(132, 22)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "MOBILE NO."
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.PaleVioletRed
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(35, 485)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1071, 189)
        Me.DataGridView1.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(42, 437)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 22)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "SEARCH"
        '
        'txtSid
        '
        Me.txtSid.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtSid.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSid.Location = New System.Drawing.Point(314, 112)
        Me.txtSid.Name = "txtSid"
        Me.txtSid.Size = New System.Drawing.Size(157, 26)
        Me.txtSid.TabIndex = 15
        '
        'txtSname
        '
        Me.txtSname.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtSname.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSname.Location = New System.Drawing.Point(314, 164)
        Me.txtSname.Name = "txtSname"
        Me.txtSname.Size = New System.Drawing.Size(227, 27)
        Me.txtSname.TabIndex = 16
        '
        'txtFname
        '
        Me.txtFname.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtFname.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname.Location = New System.Drawing.Point(314, 215)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(227, 27)
        Me.txtFname.TabIndex = 17
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtAddress.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(314, 263)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(227, 27)
        Me.txtAddress.TabIndex = 18
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(314, 312)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(227, 26)
        Me.DateTimePicker1.TabIndex = 19
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtEmail.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(314, 357)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(227, 27)
        Me.txtEmail.TabIndex = 20
        '
        'txtAdmin
        '
        Me.txtAdmin.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtAdmin.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdmin.Location = New System.Drawing.Point(826, 164)
        Me.txtAdmin.Name = "txtAdmin"
        Me.txtAdmin.Size = New System.Drawing.Size(227, 27)
        Me.txtAdmin.TabIndex = 21
        '
        'txtMob
        '
        Me.txtMob.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtMob.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMob.Location = New System.Drawing.Point(826, 353)
        Me.txtMob.Name = "txtMob"
        Me.txtMob.Size = New System.Drawing.Size(227, 26)
        Me.txtMob.TabIndex = 22
        '
        'Male
        '
        Me.Male.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.Male.AutoSize = True
        Me.Male.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Male.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Male.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Male.Location = New System.Drawing.Point(826, 308)
        Me.Male.Name = "Male"
        Me.Male.Size = New System.Drawing.Size(72, 23)
        Me.Male.TabIndex = 25
        Me.Male.TabStop = True
        Me.Male.Text = "MALE"
        Me.Male.UseVisualStyleBackColor = False
        '
        'Female
        '
        Me.Female.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.Female.AutoSize = True
        Me.Female.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Female.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Female.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Female.Location = New System.Drawing.Point(940, 306)
        Me.Female.Name = "Female"
        Me.Female.Size = New System.Drawing.Size(91, 23)
        Me.Female.TabIndex = 24
        Me.Female.TabStop = True
        Me.Female.Text = "FEMALE"
        Me.Female.UseVisualStyleBackColor = False
        '
        'cmdCourse
        '
        Me.cmdCourse.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdCourse.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCourse.FormattingEnabled = True
        Me.cmdCourse.Items.AddRange(New Object() {"BCOM", "BCA", "BSC", "BBA"})
        Me.cmdCourse.Location = New System.Drawing.Point(826, 215)
        Me.cmdCourse.Name = "cmdCourse"
        Me.cmdCourse.Size = New System.Drawing.Size(227, 27)
        Me.cmdCourse.TabIndex = 26
        Me.cmdCourse.Text = "-SELECT-"
        '
        'cmdSem
        '
        Me.cmdSem.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdSem.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSem.FormattingEnabled = True
        Me.cmdSem.Items.AddRange(New Object() {"I Yr/ I SEM", "I Yr/ II SEM           ", "II Yr/ III SEM", "II Yr/ IV SEM", "III Yr/ V SEM", "III Yr/ VI SEM"})
        Me.cmdSem.Location = New System.Drawing.Point(826, 262)
        Me.cmdSem.Name = "cmdSem"
        Me.cmdSem.Size = New System.Drawing.Size(227, 27)
        Me.cmdSem.TabIndex = 27
        Me.cmdSem.Text = "-SELECT-"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtSearch.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(173, 433)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(274, 27)
        Me.txtSearch.TabIndex = 28
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkMagenta
        Me.Button1.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 38)
        Me.Button1.TabIndex = 172
        Me.Button1.Text = "HOME"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkMagenta
        Me.Button2.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(1230, 621)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 38)
        Me.Button2.TabIndex = 173
        Me.Button2.Text = "NEXT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -91)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1348, 904)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 171
        Me.PictureBox1.TabStop = False
        '
        'studentregister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1347, 702)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.cmdSem)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.cmdCourse)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Male)
        Me.Controls.Add(Me.btnR)
        Me.Controls.Add(Me.Female)
        Me.Controls.Add(Me.btnADD)
        Me.Controls.Add(Me.txtMob)
        Me.Controls.Add(Me.txtAdmin)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.txtSname)
        Me.Controls.Add(Me.txtSid)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
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
        Me.Name = "studentregister"
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
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents txtSid As TextBox
    Friend WithEvents txtSname As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAdmin As TextBox
    Friend WithEvents txtMob As TextBox
    Friend WithEvents Male As RadioButton
    Friend WithEvents Female As RadioButton
    Friend WithEvents cmdCourse As ComboBox
    Friend WithEvents cmdSem As ComboBox
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents btnExit As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnR As Button
    Friend WithEvents btnADD As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
