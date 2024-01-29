Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32

Public Class Registeration
    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim table As New DataTable()
    Private bitmap As Bitmap

    Protected Sub updateTable()
        Dim table1 As New DataTable()
        Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=root")
        Dim adapter As New MySqlDataAdapter("select * from departmentelevate.faculty", connection)
        adapter.Fill(table)
        adapter.Fill(table1)
        DataGridView1.DataSource = table
        DataGridView1.DataSource = table1
    End Sub

    Private Sub Registeration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        If txtFid.Text = "" Or txtFname.Text = "" Or cmdDept.Text = "" Or txtFmob.Text = "" Or txtFemail.Text = "" Or cmdDesignation.Text = "" Then
            MsgBox("Mandatory Fields!! Please fill it", vbOKOnly, "Form Registeration")
            Exit Sub
        Else
            rec_open("insert into faculty values('" & txtFid.Text & "','" & txtFname.Text & "','" & cmdDept.Text & "','" & DateTimePicker1.Text & "','" & txtFmob.Text & "','" & txtFq.Text & "','" & txtFemail.Text & "','" & cmdDesignation.Text & "','" & gender & "')")
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
        If txtFname.Text = "" Or cmdDept.Text = "" Or txtFmob.Text = "" Or txtFemail.Text = "" Or cmdDesignation.Text = "" Then
            MsgBox("Select A Row from Gridview And then Click on Delete !! ", vbOKOnly, "Form Registeration")
            Exit Sub
        Else
            rec_open("delete from faculty where Fid= " & txtFid.Text & "")
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
                txtFid.Text = row.Cells("fid").Value.ToString()
                txtFname.Text = row.Cells("fname").Value.ToString()
                cmdDept.Text = row.Cells("fdept").Value.ToString()
                DateTimePicker1.Value = row.Cells("doj").Value.ToString()
                txtFmob.Text = row.Cells("mob").Value.ToString()
                txtFq.Text = row.Cells("fq").Value.ToString()
                txtFemail.Text = row.Cells("email").Value.ToString()
                cmdDesignation.Text = row.Cells("desgn").Value.ToString()
                gender = row.Cells("gender").Value.ToString()
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

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim txt
        For Each txt In Me.Controls
            If TypeOf txt Is TextBox Then
                txtFid.Text = ""
                txtFname.Text = ""
                cmdDept.Text = "Select"
                DateTimePicker1.Text = ""
                txtFmob.Text = ""
                txtFname.Text = ""
                txtFq.Text = ""
                txtFemail.Text = ""
                cmdDesignation.Text = ""
                Male.Checked = False
                Female.Checked = False
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
        If txtFid.Text = "" Or txtFname.Text = "" Or cmdDept.Text = "" Or txtFmob.Text = "" Or txtFemail.Text = "" Or cmdDesignation.Text = "" Then
            MsgBox("Select A Row from Gridview and then Click on Update !! ", vbOKOnly, "Form Registeration")
            Exit Sub
        Else
            rec_open("update faculty set fname='" & txtFname.Text & "',fdept='" & cmdDept.Text & "',doj='" & DateTimePicker1.Text & "',mob='" & txtFmob.Text & "',fq='" & txtFq.Text & "',email='" & txtFemail.Text & "',desgn='" & cmdDesignation.Text & "',gender='" & gender & "' where fid='" & txtFid.Text & "'")
            MsgBox("Data Updated Successfully!!", vbOKOnly, "Status Update")
            updateTable()
        End If
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                Dim dv As DataView
                dv = table.DefaultView
                dv.RowFilter = String.Format("fname Like '%{0}%'", txtSearch.Text)
                DataGridView1.DataSource = table
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        HomePage.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        facultynext.Show()
    End Sub

    Private Sub txtFid_TextChanged(sender As Object, e As EventArgs) Handles txtFid.TextChanged

    End Sub
End Class


