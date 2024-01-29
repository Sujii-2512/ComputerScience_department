Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32

Public Class studentregister
    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim table As New DataTable()
    Private bitmap As Bitmap

    Protected Sub updateTable()
        Dim table1 As New DataTable()
        Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=root")
        Dim adapter As New MySqlDataAdapter("select * from departmentelevate.student", connection)
        adapter.Fill(table)
        adapter.Fill(table1)
        DataGridView1.DataSource = table
        DataGridView1.DataSource = table1
    End Sub

    Private Sub studentregister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con_open()
        updateTable()
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
    End Sub

    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Dim gender As String
        If Male.Checked = True Then
            gender = Male.Text
        ElseIf Female.Checked = True Then
            gender = Female.Text
        End If
        If txtSid.Text = "" Or txtSname.Text = "" Or txtFname.Text = "" Or txtAddress.Text = "" Or DateTimePicker1.Text = "" Or txtEmail.Text = "" Or txtAdmin.Text = "" Or cmdCourse.Text = "" Or cmdSem.Text = "" Or gender = "" Or txtMob.Text = "" Then
            MsgBox("Mandatory Fields!! Please fill it", vbOKOnly, "Form studentregister")
            Exit Sub
        Else
            rec_open("insert into student values('" & txtSid.Text & "','" & txtSname.Text & "','" & txtFname.Text & "','" & txtAddress.Text & "','" & DateTimePicker1.Text & "','" & txtEmail.Text & "','" & txtAdmin.Text & "','" & cmdCourse.Text & "','" & cmdSem.Text & "','" & gender & "','" & txtMob.Text & "')")
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
        If txtSid.Text = "" Or txtFname.Text = "" Or txtFname.Text = "" Or txtAddress.Text = "" Or DateTimePicker1.Text = "" Or txtEmail.Text = "" Or txtAdmin.Text = "" Or cmdCourse.Text = "" Or cmdSem.Text = "" Or txtMob.Text = "" Then
            MsgBox("Select A Row from Gridview And then Click on Delete !! ", vbOKOnly, "Form studentregister")
            Exit Sub
        Else
            rec_open("delete from student where sid= '" & txtSid.Text & "'")
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
                txtSid.Text = row.Cells("Sid").Value.ToString()
                txtSname.Text = row.Cells("Sname").Value.ToString()
                txtFname.Text = row.Cells("Fname").Value.ToString()
                txtAddress.Text = row.Cells("Address").Value.ToString()
                DateTimePicker1.Text = row.Cells("DOB").Value.ToString()
                txtEmail.Text = row.Cells("Email").Value.ToString()
                txtAdmin.Text = row.Cells("Admin").Value.ToString()
                cmdCourse.Text = row.Cells("Course").Value.ToString()
                cmdSem.Text = row.Cells("Sem").Value.ToString()
                txtMob.Text = row.Cells("MOB").Value.ToString()
                gender = row.Cells("Gender").Value.ToString()
                If gender = "MALE" Then
                    Male.Checked = True
                ElseIf gender = "FEMALE" Then
                    Female.Checked = True
                End If
                'textboxTst.Text = row.Cells("Description").Value.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        Dim txt
        For Each txt In Me.Controls
            If TypeOf txt Is TextBox Then
                txtSid.Text = ""
                txtSname.Text = ""
                txtFname.Text = ""
                txtAddress.Text = ""
                DateTimePicker1.Text = ""
                txtEmail.Text = ""
                txtAdmin.Text = ""
                cmdCourse.Text = "Select"
                cmdSem.Text = "Select"
                Male.Checked = False
                Female.Checked = False
                txtMob.Text = ""
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
        If txtSid.Text = "" Or txtSname.Text = "" Or txtFname.Text = "" Or txtAddress.Text = "" Or DateTimePicker1.Text = "" Or txtEmail.Text = "" Or txtAdmin.Text = "" Or cmdCourse.Text = "" Or cmdSem.Text = "" Or gender = "" Or txtMob.Text = "" Then
            MsgBox("Select A Row from Gridview and then Click on Update !! ", vbOKOnly, "Form studentregister")
            Exit Sub
        Else
            rec_open("update student set Sname='" & txtSname.Text & "',Fname='" & txtFname.Text & "',Address='" & txtAddress.Text & "',DOB='" & DateTimePicker1.Text & "',Email='" & txtEmail.Text & "',Admin='" & txtAdmin.Text & "',Course='" & cmdCourse.Text & "',Sem='" & cmdSem.Text & "',Gender='" & gender & "' ,MOB='" & txtMob.Text & "' where Sid='" & txtSid.Text & "'")
            MsgBox("Data Updated Successfully!!", vbOKOnly, "Status Update")
            updateTable()
        End If
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                Dim dv As DataView
                dv = table.DefaultView
                dv.RowFilter = String.Format("Sname Like '%{0}%'", txtSearch.Text)
                DataGridView1.DataSource = table
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        HomePage.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        studentnext.Show()
    End Sub

    Private Sub txtMob_LostFocus(sender As Object, e As EventArgs) Handles txtMob.LostFocus
        Dim strAllowedchars As String = "0123456789() -+"
        If Len(txtMob.Text) = 0 Then
            Exit Sub
        Else
            For i = 0 To Len(txtMob.Text) - 1
                If InStr(1, strAllowedchars, txtMob.Text(i)) = 0 Then
                    MsgBox("Invalid Mobile number")
                    txtMob.Focus()
                    Exit Sub
                End If
            Next
        End If
    End Sub

    Private Sub txtMob_TextChanged(sender As Object, e As EventArgs) Handles txtMob.TextChanged

    End Sub
End Class

