<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CourseDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CourseDetails))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSub = New System.Windows.Forms.TextBox()
        Me.cmdYear = New System.Windows.Forms.ComboBox()
        Me.cmdSem = New System.Windows.Forms.ComboBox()
        Me.txtSubcode = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtStrength = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Imprint MT Shadow", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(671, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COURSE DETAILS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(421, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "COURSE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(421, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "YEAR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(421, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "SEMESTER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(421, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "SUBJECTS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(421, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "SUBJECT CODE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(421, 327)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "DESCRIPTION"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(421, 372)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(224, 23)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "INTAKE-STRENGTH"
        '
        'txtSub
        '
        Me.txtSub.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSub.Location = New System.Drawing.Point(716, 234)
        Me.txtSub.Name = "txtSub"
        Me.txtSub.Size = New System.Drawing.Size(280, 27)
        Me.txtSub.TabIndex = 11
        '
        'cmdYear
        '
        Me.cmdYear.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdYear.FormattingEnabled = True
        Me.cmdYear.Items.AddRange(New Object() {"2019-2020", "2020-2021", "2021-2022"})
        Me.cmdYear.Location = New System.Drawing.Point(716, 152)
        Me.cmdYear.Name = "cmdYear"
        Me.cmdYear.Size = New System.Drawing.Size(280, 27)
        Me.cmdYear.TabIndex = 12
        Me.cmdYear.Text = "Select"
        '
        'cmdSem
        '
        Me.cmdSem.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSem.FormattingEnabled = True
        Me.cmdSem.Items.AddRange(New Object() {"I", "II", "III", "IV", "V", "VI"})
        Me.cmdSem.Location = New System.Drawing.Point(716, 191)
        Me.cmdSem.Name = "cmdSem"
        Me.cmdSem.Size = New System.Drawing.Size(280, 27)
        Me.cmdSem.TabIndex = 13
        Me.cmdSem.Text = "Select"
        '
        'txtSubcode
        '
        Me.txtSubcode.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubcode.Location = New System.Drawing.Point(716, 279)
        Me.txtSubcode.Name = "txtSubcode"
        Me.txtSubcode.Size = New System.Drawing.Size(280, 27)
        Me.txtSubcode.TabIndex = 14
        '
        'txtDesc
        '
        Me.txtDesc.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(716, 321)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(280, 27)
        Me.txtDesc.TabIndex = 15
        '
        'txtStrength
        '
        Me.txtStrength.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStrength.Location = New System.Drawing.Point(716, 366)
        Me.txtStrength.Name = "txtStrength"
        Me.txtStrength.Size = New System.Drawing.Size(280, 27)
        Me.txtStrength.TabIndex = 16
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(1124, 104)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(120, 39)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(1224, 698)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 39)
        Me.btnExit.TabIndex = 22
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(1124, 354)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(120, 39)
        Me.btnPrint.TabIndex = 21
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(1124, 271)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(120, 39)
        Me.btnDelete.TabIndex = 20
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(1124, 183)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(120, 39)
        Me.btnReset.TabIndex = 18
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 465)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 23)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "SEARCH"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(122, 461)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(280, 26)
        Me.txtSearch.TabIndex = 20
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 491)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(610, 216)
        Me.DataGridView1.TabIndex = 21
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
        'txtCourse
        '
        Me.txtCourse.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourse.Location = New System.Drawing.Point(716, 108)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(280, 27)
        Me.txtCourse.TabIndex = 22
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnHome.Font = New System.Drawing.Font("Imprint MT Shadow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.SystemColors.Control
        Me.btnHome.Location = New System.Drawing.Point(6, 7)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(87, 32)
        Me.btnHome.TabIndex = 42
        Me.btnHome.Text = "HOME"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1373, 752)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'CourseDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtCourse)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtStrength)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.txtSubcode)
        Me.Controls.Add(Me.cmdSem)
        Me.Controls.Add(Me.cmdYear)
        Me.Controls.Add(Me.txtSub)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "CourseDetails"
        Me.Text = "CourseDetails"
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
    Friend WithEvents txtSub As TextBox
    Friend WithEvents cmdYear As ComboBox
    Friend WithEvents cmdSem As ComboBox
    Friend WithEvents txtSubcode As TextBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents txtStrength As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents btnHome As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
