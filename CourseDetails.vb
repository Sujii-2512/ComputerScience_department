Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32

Public Class CourseDetails
    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim table As New DataTable()
    Private bitmap As Bitmap

    Protected Sub updateTable()
        Dim table1 As New DataTable()
        Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=root")
        Dim adapter As New MySqlDataAdapter("select * from departmentelevate.course", connection)
        adapter.Fill(table)
        adapter.Fill(table1)
        DataGridView1.DataSource = table
        DataGridView1.DataSource = table1
    End Sub
    Private Sub CourseDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con_open()
        updateTable()
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtCourse.Text = "" Or cmdYear.Text = "" Or cmdSem.Text = "" Or txtSub.Text = "" Or txtSubcode.Text = "" Or txtDesc.Text = "" Or txtStrength.Text = "" Then
            MsgBox("Mandatory Fields!! Please fill it", vbOKOnly, "Form CourseDetails")
            Exit Sub
        Else
            rec_open("insert into course values('" & txtCourse.Text & "','" & cmdYear.Text & "','" & cmdSem.Text & "','" & txtSub.Text & "','" & txtSubcode.Text & "','" & txtDesc.Text & "','" & txtStrength.Text & "')")
            MsgBox("Data Inserted Successfully!!", vbOKOnly, "Status Update")
            updateTable()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim txt
        For Each txt In Me.Controls
            If TypeOf txt Is TextBox Then
                txtCourse.Text = ""
                cmdYear.Text = "select"
                cmdSem.Text = "select"
                txtSub.Text = ""
                txtSubcode.Text = ""
                txtDesc.Text = ""
                txtStrength.Text = ""
            End If
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Confirm if you want to exit", "Datagridview System", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If iExit = DialogResult.Yes Then
            Me.Hide()
            HomePage.Show()
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim imgbmp As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(imgbmp, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(imgbmp, 0, 0)
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                Dim dv As DataView
                dv = table.DefaultView
                dv.RowFilter = String.Format("COURSE '%{0}%'", txtSearch.Text)
                DataGridView1.DataSource = table
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtCourse.Text = "" Or cmdYear.Text = "" Or cmdSem.Text = "" Or txtSub.Text = "" Or txtSubcode.Text = "" Or txtDesc.Text = "" Or txtStrength.Text = "" Then
            MsgBox("Select A Row from Gridview and then Click on Delete !! ", vbOKOnly, "Form CourseDetails")
            Exit Sub
        Else
            rec_open("delete from course where Course= '" & txtCourse.Text & "'")
            MsgBox("Data Deleted Successfully!!", vbOKOnly, "Status Update")
            updateTable()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.DataGridView1.Rows(e.RowIndex)
                'GlobalVariables.SelectedlineItemRowNo = e.RowIndex ' Or row
                'MsgBox("GlobalVariables.SelectedlineItemRowNo is ---> " & GlobalVariables.SelectedlineItemRowNo)
                txtCourse.Text = row.Cells("COURSE").Value.ToString()
                cmdYear.Text = row.Cells("YEAR").Value.ToString()
                cmdSem.Text = row.Cells("SEM").Value.ToString()
                txtSub.Text = row.Cells("SUBJECT").Value.ToString()
                txtSubcode.Text = row.Cells("SUBJECTCODE").Value.ToString()
                txtDesc.Text = row.Cells("DESCRIPTION").Value.ToString()
                txtStrength.Text = row.Cells("STRENGTH").Value.ToString()
                'textboxTst.Text = row.Cells("Description").Value.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        HomePage.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class