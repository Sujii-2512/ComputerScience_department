Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports System.IO
Public Class PaperPublication
    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim table As New DataTable()
    Private bitmap As Bitmap

    Protected Sub updateTable()
        Dim table1 As New DataTable()
        Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=root")
        Dim adapter As New MySqlDataAdapter("select * from departmentelevate.paperpublication", connection)
        adapter.Fill(table)
        adapter.Fill(table1)
        DataGridView1.DataSource = table
        DataGridView1.DataSource = table1
    End Sub

    Private Sub PaperPublication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        If txtPid.Text = "" Or cmdPub.Text = "" Or txtName.Text = "" Or txtOrg.Text = "" Or txtIssn.Text = "" Or cmdConf.Text = "" Or txtPresent.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Mandatory Fields!! Please fill it", vbOKOnly, "Form PaperPublication")
            Exit Sub
        Else
            rec_open("insert into paperpublication values('" & txtPid.Text & "','" & cmdPub.Text & "','" & txtName.Text & "','" & txtOrg.Text & "','" & DateTimePicker1.Text & "','" & txtIssn.Text & "','" & cmdConf.Text & "','" & txtPresent.Text & "','" & gender & "','" & TextBox6.Text & "')")
            MsgBox("Data Inserted Successfully!!", vbOKOnly, "Status Update")
            updateTable()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim iExit As DialogResult

        iExit = MessageBox.Show("Confirm if you want to exit", "Datagridview System", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtPid.Text = "" Or cmdPub.Text = "" Or txtName.Text = "" Or txtOrg.Text = "" Or txtIssn.Text = "" Or cmdConf.Text = "" Or txtPresent.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Select A Row from Gridview And then Click on Delete !! ", vbOKOnly, "Form PaperPublication")
            Exit Sub
        Else
            rec_open("delete from paperpublication where Pid= " & txtPid.Text & "")
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

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim txt
        For Each txt In Me.Controls
            If TypeOf txt Is TextBox Then
                txtPid.Text = ""
                cmdPub.Text = "Select"
                txtName.Text = ""
                txtOrg.Text = ""
                DateTimePicker1.Text = ""
                txtIssn.Text = ""
                cmdConf.Text = "Select"
                txtPresent.Text = ""
                Male.Checked = False
                Female.Checked = False
                TextBox6.Text = ""
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
        If txtPid.Text = "" Or cmdPub.Text = "" Or txtName.Text = "" Or txtOrg.Text = "" Or txtIssn.Text = "" Or cmdConf.Text = "" Or txtPresent.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Select A Row from Gridview and then Click on Update !! ", vbOKOnly, "Form PaperPublication")
            Exit Sub
        Else
            rec_open("update paperpublication set Pub='" & cmdPub.Text & "',Name='" & txtName.Text & "',Org='" & txtOrg.Text & "',doj='" & DateTimePicker1.Text & "',Issn='" & txtIssn.Text & "',Conference='" & cmdConf.Text & "',Presentation='" & txtPresent.Text & "',Gender='" & gender & "',file='" & TextBox6.Text & "' where Pid='" & txtPid.Text & "'")
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

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim gender As String
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.DataGridView1.Rows(e.RowIndex)
                'GlobalVariables.SelectedlineItemRowNo = e.RowIndex ' Or row
                'MsgBox("GlobalVariables.SelectedlineItemRowNo is ---> " & GlobalVariables.SelectedlineItemRowNo)
                txtPid.Text = row.Cells("Pid").Value.ToString()
                cmdPub.Text = row.Cells("Pub").Value.ToString()
                txtName.Text = row.Cells("Name").Value.ToString()
                txtOrg.Text = row.Cells("Org").Value.ToString()
                DateTimePicker1.Value = row.Cells("doj").Value.ToString()
                txtIssn.Text = row.Cells("Issn").Value.ToString()
                cmdConf.Text = row.Cells("Conference").Value.ToString()
                txtPresent.Text = row.Cells("Presentation").Value.ToString()
                gender = row.Cells("Gender").Value.ToString()
                If gender = "MALE" Then
                    Male.Checked = True
                ElseIf gender = "FEMALE" Then
                    Female.Checked = True
                    TextBox6.Text = row.Cells("file").Value.ToString()
                End If
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

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            TextBox6.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim FilenameName As String()
        ProgressBar1.Value += 1
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()

            FilenameName = OpenFileDialog1.FileName.Split("\"c)
            File.Copy(OpenFileDialog1.FileName, "paper\" + FilenameName(FilenameName.Length - 1))
            MessageBox.Show(" File Uploaded Successfully ")
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Timer1.Start()
    End Sub
End Class

