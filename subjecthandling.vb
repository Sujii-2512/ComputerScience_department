Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports System.IO
Public Class subjecthandling
    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim table As New DataTable()
    Private bitmap As Bitmap

    Protected Sub updateTable()
        Dim table1 As New DataTable()
        Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=root")
        Dim adapter As New MySqlDataAdapter("select * from departmentelevate.workload", connection)
        adapter.Fill(table)
        adapter.Fill(table1)
        DataGridView1.DataSource = table
        DataGridView1.DataSource = table1
    End Sub

    Private Sub subjecthandling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con_open()
        updateTable()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtName.Text = "" Or cmdYear.Text = "" Or cmdCourse.Text = "" Or txtSub.Text = "" Or cmdSem.Text = "" Or cmdDept.Text = "" Or txtThrs.Text = "" Or txtPhrs.Text = "" Or txtTimetable.Text = "" Then
            MsgBox("Mandatory Fields!! Please fill it", vbOKOnly, "Form subjecthandling")
            Exit Sub
        Else
            rec_open("insert into workload values('" & txtName.Text & "','" & cmdYear.Text & "','" & cmdCourse.Text & "','" & txtSub.Text & "','" & cmdSem.Text & "','" & cmdDept.Text & "','" & txtThrs.Text & "','" & txtPhrs.Text & "','" & txtTimetable.Text & "')")
            MsgBox("Data Inserted Successfully!!", vbOKOnly, "Status Update")
            updateTable()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim iExit As DialogResult

        iExit = MessageBox.Show("Confirm if you want to exit", "Datagridview System", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If iExit = DialogResult.Yes Then
            Me.Hide()
            HomePage.Show()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtName.Text = "" Or cmdYear.Text = "" Or cmdCourse.Text = "" Or txtSub.Text = "" Or cmdSem.Text = "" Or cmdDept.Text = "" Or txtThrs.Text = "" Or txtPhrs.Text = "" Or txtTimetable.Text = "" Then
            MsgBox("Select A Row from Gridview And then Click on Delete !! ", vbOKOnly, "Form subjecthandling")
            Exit Sub
        Else
            rec_open("delete from workload where Name= '" & txtName.Text & "'")
            MsgBox("Data Deleted Successfully!!", vbOKOnly, "Status Update")
            updateTable()
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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.DataGridView1.Rows(e.RowIndex)
                'GlobalVariables.SelectedlineItemRowNo = e.RowIndex ' Or row
                'MsgBox("GlobalVariables.SelectedlineItemRowNo is ---> " & GlobalVariables.SelectedlineItemRowNo)
                txtName.Text = row.Cells("Name").Value.ToString()
                cmdYear.Text = row.Cells("Year").Value.ToString()
                cmdCourse.Text = row.Cells("Course").Value.ToString()
                txtSub.Text = row.Cells("Subject").Value.ToString()
                cmdSem.Text = row.Cells("Sem").Value.ToString()
                cmdDept.Text = row.Cells("Department").Value.ToString()
                txtThrs.Text = row.Cells("Theoryhrs").Value.ToString()
                txtPhrs.Text = row.Cells("Practicalhrs").Value.ToString()
                txtPhrs.Text = row.Cells("Practicalhrs").Value.ToString()
                txtTimetable.Text = row.Cells("file").Value.ToString()
                'textboxTst.Text = row.Cells("Description").Value.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim txt
        For Each txt In Me.Controls
            If TypeOf txt Is TextBox Then
                txtName.Text = ""
                cmdYear.Text = "Select"
                cmdCourse.Text = "Select"
                txtSub.Text = ""
                cmdSem.Text = "Select"
                cmdDept.Text = "Select"
                txtThrs.Text = ""
                txtPhrs.Text = ""
                txtTimetable.Text = ""
            End If
        Next
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtName.Text = "" Or cmdYear.Text = "" Or cmdCourse.Text = "" Or txtSub.Text = "" Or cmdSem.Text = "" Or cmdDept.Text = "" Or txtThrs.Text = "" Or txtPhrs.Text = "" Or txtPhrs.Text = "" Or txtTimetable.Text = "" Then
            MsgBox("Select A Row from Gridview and then Click on Update !! ", vbOKOnly, "Form subjecthandling")
            Exit Sub
        Else
            rec_open("update workload set Name='" & txtName.Text & "',Year='" & cmdYear.Text & "',Course='" & cmdCourse.Text & "',Subject='" & txtSub.Text & "',Sem='" & cmdSem.Text & "',Department='" & cmdDept.Text & "',Theoryhrs='" & txtThrs.Text & "',Practicalhrs='" & txtPhrs.Text & "' ,timetable= '" & txtTimetable.Text & "' where Name='" & txtName.Text & "'")
            MsgBox("Data Updated Successfully!!", vbOKOnly, "Status Update")
            updateTable()
        End If
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                Dim dv As DataView
                dv = table.DefaultView
                dv.RowFilter = String.Format("Name Like '%{0}%'", txtSearch.Text)
                DataGridView1.DataSource = table
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            txtTimetable.Text = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim FilenameName As String()
        ProgressBar1.Value += 1
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()

            FilenameName = OpenFileDialog1.FileName.Split("\"c)
            File.Copy(OpenFileDialog1.FileName, "subjecthandling\" + FilenameName(FilenameName.Length - 1))
            MessageBox.Show(" File Uploaded Successfully ")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Timer1.Start()
    End Sub
End Class
