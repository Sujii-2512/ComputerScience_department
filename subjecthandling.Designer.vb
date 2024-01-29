<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subjecthandling
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(subjecthandling))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmdCourse = New System.Windows.Forms.ComboBox()
        Me.cmdYear = New System.Windows.Forms.ComboBox()
        Me.cmdSem = New System.Windows.Forms.ComboBox()
        Me.cmdDept = New System.Windows.Forms.ComboBox()
        Me.txtThrs = New System.Windows.Forms.TextBox()
        Me.txtPhrs = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtTimetable = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSub = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.Font = New System.Drawing.Font("Imprint MT Shadow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(78, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SUBJECT HANDLED"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(78, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "COURSE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(79, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "YEAR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(610, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "SEM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(79, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "SUBJECT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(610, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "DEPARTMENT"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(77, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "FACULTY NAME"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(610, 235)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(266, 23)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "NO. OF THEORY HOURS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(610, 285)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(301, 23)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "NO. OF PRACTICAL HOURS"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"BCA", "BCom", "BBA", "BSc1", "BA"})
        Me.ComboBox1.Location = New System.Drawing.Point(322, 240)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(233, 27)
        Me.ComboBox1.TabIndex = 10
        Me.ComboBox1.Text = "Select"
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"2019-2020", "2020-2021", "2021-2022"})
        Me.ComboBox2.Location = New System.Drawing.Point(322, 191)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(233, 27)
        Me.ComboBox2.TabIndex = 11
        Me.ComboBox2.Text = "Select"
        '
        'ComboBox4
        '
        Me.ComboBox4.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"I", "II", "III", "IV", "V", "VI"})
        Me.ComboBox4.Location = New System.Drawing.Point(923, 142)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(207, 27)
        Me.ComboBox4.TabIndex = 13
        Me.ComboBox4.Text = "Select"
        '
        'ComboBox5
        '
        Me.ComboBox5.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(923, 183)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(207, 27)
        Me.ComboBox5.TabIndex = 14
        Me.ComboBox5.Text = "Select"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Sienna
        Me.Label10.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(79, 463)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 23)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "SEARCH"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Maroon
        Me.Label11.Font = New System.Drawing.Font("Imprint MT Shadow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(515, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(233, 38)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "WORKLOAD"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Sienna
        Me.Label12.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(78, 234)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 23)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "COURSE"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Sienna
        Me.Label13.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(79, 187)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 23)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "YEAR"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Sienna
        Me.Label14.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.Control
        Me.Label14.Location = New System.Drawing.Point(610, 142)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 23)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "SEM"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Sienna
        Me.Label15.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.Control
        Me.Label15.Location = New System.Drawing.Point(79, 284)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 23)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "SUBJECT"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Sienna
        Me.Label16.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.Control
        Me.Label16.Location = New System.Drawing.Point(610, 188)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(165, 23)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "DEPARTMENT"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Sienna
        Me.Label17.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.Control
        Me.Label17.Location = New System.Drawing.Point(77, 143)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(184, 23)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "FACULTY NAME"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Sienna
        Me.Label18.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.Control
        Me.Label18.Location = New System.Drawing.Point(610, 235)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(266, 23)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "NO. OF THEORY HOURS"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Sienna
        Me.Label19.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.Control
        Me.Label19.Location = New System.Drawing.Point(610, 285)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(301, 23)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "NO. OF PRACTICAL HOURS"
        '
        'cmdCourse
        '
        Me.cmdCourse.BackColor = System.Drawing.Color.DarkRed
        Me.cmdCourse.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCourse.ForeColor = System.Drawing.SystemColors.Control
        Me.cmdCourse.FormattingEnabled = True
        Me.cmdCourse.Items.AddRange(New Object() {"BCA", "BCom", "BBA", "BSc1", "BA"})
        Me.cmdCourse.Location = New System.Drawing.Point(322, 240)
        Me.cmdCourse.Name = "cmdCourse"
        Me.cmdCourse.Size = New System.Drawing.Size(233, 27)
        Me.cmdCourse.TabIndex = 10
        Me.cmdCourse.Text = "Select"
        '
        'cmdYear
        '
        Me.cmdYear.BackColor = System.Drawing.Color.DarkRed
        Me.cmdYear.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdYear.ForeColor = System.Drawing.SystemColors.Control
        Me.cmdYear.FormattingEnabled = True
        Me.cmdYear.Items.AddRange(New Object() {"2019-2020", "2020-2021", "2021-2022"})
        Me.cmdYear.Location = New System.Drawing.Point(322, 191)
        Me.cmdYear.Name = "cmdYear"
        Me.cmdYear.Size = New System.Drawing.Size(233, 27)
        Me.cmdYear.TabIndex = 11
        Me.cmdYear.Text = "Select"
        '
        'cmdSem
        '
        Me.cmdSem.BackColor = System.Drawing.Color.DarkRed
        Me.cmdSem.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSem.ForeColor = System.Drawing.SystemColors.Control
        Me.cmdSem.FormattingEnabled = True
        Me.cmdSem.Items.AddRange(New Object() {"I", "II", "III", "IV", "V", "VI"})
        Me.cmdSem.Location = New System.Drawing.Point(923, 142)
        Me.cmdSem.Name = "cmdSem"
        Me.cmdSem.Size = New System.Drawing.Size(207, 27)
        Me.cmdSem.TabIndex = 13
        Me.cmdSem.Text = "Select"
        '
        'cmdDept
        '
        Me.cmdDept.BackColor = System.Drawing.Color.DarkRed
        Me.cmdDept.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDept.ForeColor = System.Drawing.SystemColors.Control
        Me.cmdDept.FormattingEnabled = True
        Me.cmdDept.Items.AddRange(New Object() {"Mathematics", "ComputerScience", "Biology", "Chemistry", "Physics", "Kannada", "Hindi", "Sanskrit", "English", "Management", "Commerce", "Humanitities"})
        Me.cmdDept.Location = New System.Drawing.Point(923, 183)
        Me.cmdDept.Name = "cmdDept"
        Me.cmdDept.Size = New System.Drawing.Size(207, 27)
        Me.cmdDept.TabIndex = 14
        Me.cmdDept.Text = "Select"
        '
        'txtThrs
        '
        Me.txtThrs.BackColor = System.Drawing.Color.DarkRed
        Me.txtThrs.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThrs.ForeColor = System.Drawing.SystemColors.Control
        Me.txtThrs.Location = New System.Drawing.Point(923, 230)
        Me.txtThrs.Name = "txtThrs"
        Me.txtThrs.Size = New System.Drawing.Size(136, 27)
        Me.txtThrs.TabIndex = 16
        '
        'txtPhrs
        '
        Me.txtPhrs.BackColor = System.Drawing.Color.DarkRed
        Me.txtPhrs.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhrs.ForeColor = System.Drawing.SystemColors.Control
        Me.txtPhrs.Location = New System.Drawing.Point(923, 279)
        Me.txtPhrs.Name = "txtPhrs"
        Me.txtPhrs.Size = New System.Drawing.Size(136, 27)
        Me.txtPhrs.TabIndex = 17
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.DarkRed
        Me.txtSearch.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.SystemColors.Control
        Me.txtSearch.Location = New System.Drawing.Point(204, 460)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(280, 27)
        Me.txtSearch.TabIndex = 23
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.IndianRed
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Peru
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SaddleBrown
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 506)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1047, 192)
        Me.DataGridView1.TabIndex = 24
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Maroon
        Me.Button4.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(296, 394)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(111, 34)
        Me.Button4.TabIndex = 92
        Me.Button4.Text = "BROWSE"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Maroon
        Me.Button6.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(462, 394)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(111, 34)
        Me.Button6.TabIndex = 90
        Me.Button6.Text = "UPLOAD"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Sienna
        Me.Label20.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.Control
        Me.Label20.Location = New System.Drawing.Point(77, 333)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(145, 23)
        Me.Label20.TabIndex = 93
        Me.Label20.Text = "TIME TABLE"
        '
        'txtTimetable
        '
        Me.txtTimetable.BackColor = System.Drawing.Color.DarkRed
        Me.txtTimetable.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimetable.ForeColor = System.Drawing.SystemColors.Control
        Me.txtTimetable.Location = New System.Drawing.Point(321, 330)
        Me.txtTimetable.Name = "txtTimetable"
        Me.txtTimetable.Size = New System.Drawing.Size(234, 27)
        Me.txtTimetable.TabIndex = 94
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(321, 362)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(233, 10)
        Me.ProgressBar1.TabIndex = 95
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.DarkRed
        Me.btnPrint.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnPrint.Location = New System.Drawing.Point(1194, 476)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(128, 45)
        Me.btnPrint.TabIndex = 144
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.DarkRed
        Me.btnDelete.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDelete.Location = New System.Drawing.Point(1194, 383)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(128, 45)
        Me.btnDelete.TabIndex = 143
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DarkRed
        Me.btnUpdate.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnUpdate.Location = New System.Drawing.Point(1194, 290)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(128, 45)
        Me.btnUpdate.TabIndex = 142
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.DarkRed
        Me.btnReset.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnReset.Location = New System.Drawing.Point(1194, 197)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(128, 45)
        Me.btnReset.TabIndex = 141
        Me.btnReset.Text = " RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.DarkRed
        Me.btnAdd.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAdd.Location = New System.Drawing.Point(1194, 108)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(128, 45)
        Me.btnAdd.TabIndex = 140
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.DarkRed
        Me.txtName.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.SystemColors.Control
        Me.txtName.Location = New System.Drawing.Point(320, 143)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(234, 27)
        Me.txtName.TabIndex = 145
        '
        'txtSub
        '
        Me.txtSub.BackColor = System.Drawing.Color.DarkRed
        Me.txtSub.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSub.ForeColor = System.Drawing.SystemColors.Control
        Me.txtSub.Location = New System.Drawing.Point(322, 290)
        Me.txtSub.Name = "txtSub"
        Me.txtSub.Size = New System.Drawing.Size(234, 27)
        Me.txtSub.TabIndex = 146
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DarkRed
        Me.btnExit.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnExit.Location = New System.Drawing.Point(1194, 565)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(128, 45)
        Me.btnExit.TabIndex = 147
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
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
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1373, 731)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 170
        Me.PictureBox1.TabStop = False
        '
        'subjecthandling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 727)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtSub)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.txtTimetable)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtPhrs)
        Me.Controls.Add(Me.txtThrs)
        Me.Controls.Add(Me.cmdDept)
        Me.Controls.Add(Me.cmdSem)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.cmdYear)
        Me.Controls.Add(Me.cmdCourse)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "subjecthandling"
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
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cmdCourse As ComboBox
    Friend WithEvents cmdYear As ComboBox
    Friend WithEvents cmdSem As ComboBox
    Friend WithEvents cmdDept As ComboBox
    Friend WithEvents txtThrs As TextBox
    Friend WithEvents txtPhrs As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents txtTimetable As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSub As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Timer1 As Timer
End Class
