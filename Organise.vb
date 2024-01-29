Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports System.IO

Public Class Organise
    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim table As New DataTable()
    Private bitmap As Bitmap

    Protected Sub updateTable()
        Dim table1 As New DataTable()
        Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=root")
        Dim adapter As New MySqlDataAdapter("select * from departmentelevate.organise", connection)
        adapter.Fill(table)
        adapter.Fill(table1)
        DataGridView1.DataSource = table
        DataGridView1.DataSource = table1
    End Sub

    Private Sub Organise_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con_open()
        updateTable()
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim gender As String
        If Male.Checked = True Then
            gender = Male.Text
        ElseIf Female.Checked = True Then
            gender = Female.Text
        End If
        If txtTopic.Text = "" Or txtName.Text = "" Or txtRperson.Text = "" Or cmdOrg.Text = "" Or cmdCategory.Text = "" Or TextBox2.Text = "" Or txtCertificate.Text = "" Then
            MsgBox("Mandatory Fields!! Please fill it", vbOKOnly, "Form Organise")
            Exit Sub
        Else
            rec_open("insert into organise values('" & txtTopic.Text & "','" & txtName.Text & "','" & txtRperson.Text & "','" & cmdOrg.Text & "','" & DateTimePicker1.Text & "','" & cmdCategory.Text & "','" & gender & "','" & TextBox2.Text & "','" & txtCertificate.Text & "')")
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
        If txtTopic.Text = "" Or txtName.Text = "" Or txtRperson.Text = "" Or cmdOrg.Text = "" Or cmdCategory.Text = "" Or TextBox2.Text = "" Or txtCertificate.Text = "" Then
            MsgBox("Select A Row from Gridview And then Click on Delete !! ", vbOKOnly, "Form Organise")
            Exit Sub
        Else
            rec_open("delete from organise where Topic= '" & txtTopic.Text & "'")
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
        Dim gender As String
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.DataGridView1.Rows(e.RowIndex)
                'GlobalVariables.SelectedlineItemRowNo = e.RowIndex ' Or row
                'MsgBox("GlobalVariables.SelectedlineItemRowNo is ---> " & GlobalVariables.SelectedlineItemRowNo)
                txtTopic.Text = row.Cells("Topic").Value.ToString()
                txtName.Text = row.Cells("Name").Value.ToString()
                txtRperson.Text = row.Cells("Rperson").Value.ToString()
                cmdOrg.Text = row.Cells("Org").Value.ToString()
                DateTimePicker1.Value = row.Cells("doj").Value.ToString()
                cmdCategory.Text = row.Cells("Category").Value.ToString()
                gender = row.Cells("gender").Value.ToString()
                If gender = "MALE" Then
                    Male.Checked = True
                ElseIf gender = "FEMALE" Then
                    Female.Checked = True
                    txtCertificate.Text = row.Cells("file").Value.ToString()
                End If
                TextBox2.Text = row.Cells("Balance").Value.ToString()
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
                txtTopic.Text = ""
                txtName.Text = ""
                txtRperson.Text = ""
                cmdOrg.Text = "Select"
                DateTimePicker1.Text = ""
                cmdCategory.Text = "Select"
                Male.Checked = False
                Female.Checked = False
                TextBox1.Text = ""
                txtExpense.Text = ""
                TextBox2.Text = ""
                txtCertificate.Text = ""
            End If
        Next
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Dim gender As String
        If Male.Checked = True Then
            gender = Male.Text
        ElseIf Female.Checked = True Then
            gender = Female.Text
        End If
        If txtTopic.Text = "" Or txtName.Text = "" Or txtRperson.Text = "" Or cmdOrg.Text = "" Or cmdCategory.Text = "" Or TextBox2.Text = "" Or txtCertificate.Text = "" Then
            MsgBox("Select A Row from Gridview and then Click on Update !! ", vbOKOnly, "Form Organise")
            Exit Sub
        Else
            rec_open("update organise set Name='" & txtName.Text & "',Rperson='" & txtRperson.Text & "',Org='" & cmdOrg.Text & "',doj ='" & DateTimePicker1.Text & "',Category='" & cmdCategory.Text & "',gender='" & gender & "',Balance='" & TextBox2.Text & "',file='" & txtCertificate.Text & "' where Topic='" & txtTopic.Text & "'")
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

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        Me.Hide()
        HomePage.Show()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            txtCertificate.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim FilenameName As String()
        ProgressBar1.Value += 1
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()

            FilenameName = OpenFileDialog1.FileName.Split("\"c)
            File.Copy(OpenFileDialog1.FileName, "organization\" + FilenameName(FilenameName.Length - 1))
            MessageBox.Show(" File Uploaded Successfully ")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = TextBox1.Text - txtExpense.Text
    End Sub
End Class