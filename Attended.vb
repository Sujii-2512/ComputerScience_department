Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports System.IO

Public Class Attended
    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim table As New DataTable()
    Private bitmap As Bitmap

    Protected Sub updateTable()
        Dim table1 As New DataTable()
        Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=root")
        Dim adapter As New MySqlDataAdapter("select * from departmentelevate.attended", connection)
        adapter.Fill(table)
        adapter.Fill(table1)
        DataGridView1.DataSource = table
        DataGridView1.DataSource = table1
    End Sub

    Private Sub Attended_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con_open()
        updateTable()
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtName.Text = "" Or txtTopic.Text = "" Or txtRperson.Text = "" Or cmdOrg.Text = "" Or cmdType.Text = "" Or cmdCategory.Text = "" Then
            MsgBox("Mandatory Fields!! Please fill it", vbOKOnly, "Form Attended")
            Exit Sub
        Else
            rec_open("insert into attended values('" & txtName.Text & "','" & txtTopic.Text & "','" & txtRperson.Text & "','" & cmdOrg.Text & "','" & DateTimePicker1.Text & "','" & cmdType.Text & "','" & cmdCategory.Text & "','" & TextBox2.Text & "')")
            MsgBox("Data Inserted Successfully!!", vbOKOnly, "Status Update")
            updateTable()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim txt
        For Each txt In Me.Controls
            If TypeOf txt Is TextBox Then
                txtName.Text = ""
                txtTopic.Text = ""
                txtRperson.Text = ""
                cmdOrg.Text = "select"
                DateTimePicker1.Text = ""
                cmdType.Text = "Select"
                cmdCategory.Text = "select"
                TextBox2.Text = ""
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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        If txtName.Text = "" Or txtTopic.Text = "" Or txtRperson.Text = "" Or cmdOrg.Text = "" Or cmdType.Text = "" Or cmdCategory.Text = "" Then
            MsgBox("Select A Row from Gridview and then Click on Update !! ", vbOKOnly, "Form Attended")
            Exit Sub
        Else
            rec_open("update attended set Topic='" & txtTopic.Text & "',Rperson='" & txtRperson.Text & "',Organisation='" & cmdOrg.Text & "',Date='" & DateTimePicker1.Value & "',Type='" & cmdType.Text & "',Category='" & cmdCategory.Text & "',file='" & TextBox2.Text & "'  where Name='" & txtName.Text & "'")
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtName.Text = "" Or txtTopic.Text = "" Or txtRperson.Text = "" Or cmdOrg.Text = "" Or cmdType.Text = "" Or cmdCategory.Text = "" Then
            MsgBox("Select A Row from Gridview and then Click on Delete !! ", vbOKOnly, "Form Attended")
            Exit Sub
        Else
            rec_open("delete from attended where NAME= '" & txtName.Text & "'")
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
                txtName.Text = row.Cells("Name").Value.ToString()
                txtTopic.Text = row.Cells("Topic").Value.ToString()
                txtRperson.Text = row.Cells("Rperson").Value.ToString()
                cmdOrg.Text = row.Cells("Organisation").Value.ToString()
                DateTimePicker1.Value = row.Cells("Date").Value.ToString()
                cmdType.Text = row.Cells("Type").Value.ToString()
                cmdCategory.Text = row.Cells("Category").Value.ToString()
                TextBox2.Text = row.Cells("file").Value.ToString()
                'textboxTst.Text = row.Cells("Description").Value.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        Me.Hide()
        HomePage.Show()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            TextBox2.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim FilenameName As String()
        ProgressBar1.Value += 1
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()

            FilenameName = OpenFileDialog1.FileName.Split("\"c)
            File.Copy(OpenFileDialog1.FileName, "Attended\" + FilenameName(FilenameName.Length - 1))
            MessageBox.Show(" File Uploaded Successfully ")
        End If
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Timer1.Start()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
