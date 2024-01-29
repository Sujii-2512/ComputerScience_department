<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.REGISTERATION = New System.Windows.Forms.Label()
        Me.FName = New System.Windows.Forms.Label()
        Me.FDept = New System.Windows.Forms.Label()
        Me.FDOJ = New System.Windows.Forms.Label()
        Me.FMOB = New System.Windows.Forms.Label()
        Me.FQ = New System.Windows.Forms.Label()
        Me.Femail = New System.Windows.Forms.Label()
        Me.Fdesign = New System.Windows.Forms.Label()
        Me.Fgender = New System.Windows.Forms.Label()
        Me.Fsearchh = New System.Windows.Forms.Label()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtFMOB = New System.Windows.Forms.TextBox()
        Me.txtFQ = New System.Windows.Forms.TextBox()
        Me.txtFemail = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.Male = New System.Windows.Forms.RadioButton()
        Me.female = New System.Windows.Forms.RadioButton()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cmdDept = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cmdDesignation = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFid = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'REGISTERATION
        '
        Me.REGISTERATION.AutoSize = True
        Me.REGISTERATION.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGISTERATION.Location = New System.Drawing.Point(325, 34)
        Me.REGISTERATION.Name = "REGISTERATION"
        Me.REGISTERATION.Size = New System.Drawing.Size(470, 32)
        Me.REGISTERATION.TabIndex = 0
        Me.REGISTERATION.Text = "FACULTY REGISTRATION FORM"
        '
        'FName
        '
        Me.FName.AutoSize = True
        Me.FName.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FName.Location = New System.Drawing.Point(36, 140)
        Me.FName.Name = "FName"
        Me.FName.Size = New System.Drawing.Size(186, 24)
        Me.FName.TabIndex = 2
        Me.FName.Text = "FACULTY NAME"
        '
        'FDept
        '
        Me.FDept.AutoSize = True
        Me.FDept.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FDept.Location = New System.Drawing.Point(36, 184)
        Me.FDept.Name = "FDept"
        Me.FDept.Size = New System.Drawing.Size(166, 24)
        Me.FDept.TabIndex = 3
        Me.FDept.Text = "DEPARTMENT"
        '
        'FDOJ
        '
        Me.FDOJ.AutoSize = True
        Me.FDOJ.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FDOJ.Location = New System.Drawing.Point(36, 226)
        Me.FDOJ.Name = "FDOJ"
        Me.FDOJ.Size = New System.Drawing.Size(210, 24)
        Me.FDOJ.TabIndex = 4
        Me.FDOJ.Text = "DATE OF JOINING"
        '
        'FMOB
        '
        Me.FMOB.AutoSize = True
        Me.FMOB.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FMOB.Location = New System.Drawing.Point(36, 268)
        Me.FMOB.Name = "FMOB"
        Me.FMOB.Size = New System.Drawing.Size(201, 24)
        Me.FMOB.TabIndex = 5
        Me.FMOB.Text = "MOBILE NUMBER"
        '
        'FQ
        '
        Me.FQ.AutoSize = True
        Me.FQ.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FQ.Location = New System.Drawing.Point(36, 312)
        Me.FQ.Name = "FQ"
        Me.FQ.Size = New System.Drawing.Size(189, 24)
        Me.FQ.TabIndex = 6
        Me.FQ.Text = "QUALIFICATION"
        '
        'Femail
        '
        Me.Femail.AutoSize = True
        Me.Femail.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Femail.Location = New System.Drawing.Point(36, 352)
        Me.Femail.Name = "Femail"
        Me.Femail.Size = New System.Drawing.Size(111, 24)
        Me.Femail.TabIndex = 7
        Me.Femail.Text = "EMAIL ID"
        '
        'Fdesign
        '
        Me.Fdesign.AutoSize = True
        Me.Fdesign.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fdesign.Location = New System.Drawing.Point(36, 391)
        Me.Fdesign.Name = "Fdesign"
        Me.Fdesign.Size = New System.Drawing.Size(166, 24)
        Me.Fdesign.TabIndex = 8
        Me.Fdesign.Text = "DESIGNATION"
        '
        'Fgender
        '
        Me.Fgender.AutoSize = True
        Me.Fgender.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fgender.Location = New System.Drawing.Point(36, 436)
        Me.Fgender.Name = "Fgender"
        Me.Fgender.Size = New System.Drawing.Size(105, 24)
        Me.Fgender.TabIndex = 9
        Me.Fgender.Text = "GENDER"
        '
        'Fsearchh
        '
        Me.Fsearchh.AutoSize = True
        Me.Fsearchh.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fsearchh.Location = New System.Drawing.Point(550, 89)
        Me.Fsearchh.Name = "Fsearchh"
        Me.Fsearchh.Size = New System.Drawing.Size(104, 24)
        Me.Fsearchh.TabIndex = 10
        Me.Fsearchh.Text = "SEARCH"
        '
        'btnADD
        '
        Me.btnADD.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnADD.Location = New System.Drawing.Point(68, 490)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(117, 33)
        Me.btnADD.TabIndex = 12
        Me.btnADD.Text = "ADD NEW"
        Me.btnADD.UseVisualStyleBackColor = True
        '
        'txtFName
        '
        Me.txtFName.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.Location = New System.Drawing.Point(278, 140)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(181, 26)
        Me.txtFName.TabIndex = 14
        '
        'txtFMOB
        '
        Me.txtFMOB.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFMOB.Location = New System.Drawing.Point(278, 266)
        Me.txtFMOB.Name = "txtFMOB"
        Me.txtFMOB.Size = New System.Drawing.Size(181, 26)
        Me.txtFMOB.TabIndex = 16
        '
        'txtFQ
        '
        Me.txtFQ.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFQ.Location = New System.Drawing.Point(278, 310)
        Me.txtFQ.Name = "txtFQ"
        Me.txtFQ.Size = New System.Drawing.Size(181, 26)
        Me.txtFQ.TabIndex = 17
        '
        'txtFemail
        '
        Me.txtFemail.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFemail.Location = New System.Drawing.Point(278, 350)
        Me.txtFemail.Name = "txtFemail"
        Me.txtFemail.Size = New System.Drawing.Size(181, 26)
        Me.txtFemail.TabIndex = 18
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(660, 94)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(350, 26)
        Me.txtSearch.TabIndex = 20
        '
        'DataGridView
        '
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(490, 140)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.Size = New System.Drawing.Size(520, 330)
        Me.DataGridView.TabIndex = 22
        '
        'Male
        '
        Me.Male.AutoSize = True
        Me.Male.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Male.Location = New System.Drawing.Point(246, 435)
        Me.Male.Name = "Male"
        Me.Male.Size = New System.Drawing.Size(86, 26)
        Me.Male.TabIndex = 23
        Me.Male.TabStop = True
        Me.Male.Text = "MALE"
        Me.Male.UseVisualStyleBackColor = True
        '
        'female
        '
        Me.female.AutoSize = True
        Me.female.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.female.Location = New System.Drawing.Point(363, 435)
        Me.female.Name = "female"
        Me.female.Size = New System.Drawing.Size(113, 26)
        Me.female.TabIndex = 24
        Me.female.TabStop = True
        Me.female.Text = "FEMALE"
        Me.female.UseVisualStyleBackColor = True
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubmit.Location = New System.Drawing.Point(212, 490)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(107, 33)
        Me.BtnSubmit.TabIndex = 25
        Me.BtnSubmit.Text = "RESET"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(365, 490)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(111, 33)
        Me.btnUpdate.TabIndex = 26
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(517, 490)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(121, 33)
        Me.btnDelete.TabIndex = 27
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(672, 490)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(123, 33)
        Me.btnPrint.TabIndex = 28
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(829, 490)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(123, 33)
        Me.btnExit.TabIndex = 29
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'cmdDept
        '
        Me.cmdDept.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDept.FormattingEnabled = True
        Me.cmdDept.Items.AddRange(New Object() {"English", "Kannada", "Hindi", "Sanskrit", "Physics", "Chemistry", "Mathematics", "Computer Science", "Botany", "Bio-technology", "Commerce ", "Management", "Political Science", "History", "Economics", "Psychology", "Sociology"})
        Me.cmdDept.Location = New System.Drawing.Point(278, 184)
        Me.cmdDept.Name = "cmdDept"
        Me.cmdDept.Size = New System.Drawing.Size(181, 24)
        Me.cmdDept.TabIndex = 30
        Me.cmdDept.Text = "Select"
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
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(278, 227)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(181, 23)
        Me.DateTimePicker1.TabIndex = 31
        '
        'cmdDesignation
        '
        Me.cmdDesignation.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDesignation.FormattingEnabled = True
        Me.cmdDesignation.Items.AddRange(New Object() {"Assistant Professor", "Associate Professor", "Professor"})
        Me.cmdDesignation.Location = New System.Drawing.Point(278, 391)
        Me.cmdDesignation.Name = "cmdDesignation"
        Me.cmdDesignation.Size = New System.Drawing.Size(181, 24)
        Me.cmdDesignation.TabIndex = 32
        Me.cmdDesignation.Text = "Select"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 24)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "FACULTY ID"
        '
        'txtFid
        '
        Me.txtFid.Enabled = False
        Me.txtFid.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFid.Location = New System.Drawing.Point(257, 96)
        Me.txtFid.Name = "txtFid"
        Me.txtFid.Size = New System.Drawing.Size(41, 26)
        Me.txtFid.TabIndex = 34
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 541)
        Me.Controls.Add(Me.txtFid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdDesignation)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cmdDept)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.female)
        Me.Controls.Add(Me.Male)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.txtFemail)
        Me.Controls.Add(Me.txtFQ)
        Me.Controls.Add(Me.txtFMOB)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.btnADD)
        Me.Controls.Add(Me.Fsearchh)
        Me.Controls.Add(Me.Fgender)
        Me.Controls.Add(Me.Fdesign)
        Me.Controls.Add(Me.Femail)
        Me.Controls.Add(Me.FQ)
        Me.Controls.Add(Me.FMOB)
        Me.Controls.Add(Me.FDOJ)
        Me.Controls.Add(Me.FDept)
        Me.Controls.Add(Me.FName)
        Me.Controls.Add(Me.REGISTERATION)
        Me.Name = "Register"
        Me.Text = "Register"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents REGISTERATION As Label
    Friend WithEvents FName As Label
    Friend WithEvents FDept As Label
    Friend WithEvents FDOJ As Label
    Friend WithEvents FMOB As Label
    Friend WithEvents FQ As Label
    Friend WithEvents Femail As Label
    Friend WithEvents Fdesign As Label
    Friend WithEvents Fgender As Label
    Friend WithEvents Fsearchh As Label
    Friend WithEvents btnADD As Button
    Friend WithEvents txtFName As TextBox
    Friend WithEvents txtFMOB As TextBox
    Friend WithEvents txtFQ As TextBox
    Friend WithEvents txtFemail As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents Male As RadioButton
    Friend WithEvents female As RadioButton
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents cmdDept As ComboBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cmdDesignation As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFid As TextBox
End Class
