Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32

Public Class Register
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
        DataGridView.DataSource = table
        DataGridView.DataSource = table1
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con_open()
        updateTable()
    End Sub
    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Dim gender As String
        If Male.Checked = True Then
            gender = Male.Text
        ElseIf female.Checked = True Then
            gender = female.Text
        End If
        If txtFName.Text = "" Or cmdDept.Text = "" Or txtFMOB.Text = "" Or txtFemail.Text = "" Or cmdDesignation.Text = "" Then
            MsgBox("Mandatory Fields!! Please fill it", vbOKOnly, "Form Registration")
            Exit Sub
        Else
            rec_open("insert into faculty values(null,'" & txtFName.Text & "','" & cmdDept.Text & "','" & DateTimePicker1.Text & "','" & txtFMOB.Text & "','" & txtFQ.Text & "','" & txtFemail.Text & "','" & cmdDesignation.Text & "','" & gender & "')")
            MsgBox("Data Inserted Successfully!!", vbOKOnly, "Status Update")
            updateTable()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MessageBox.Show("Exit the Application?", "MySQL Connector", MessageBoxButtons.OK, MessageBoxIcon.None)
        Application.Exit()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim gender As String
        If Male.Checked = True Then
            gender = Male.Text
        ElseIf female.Checked = True Then
            gender = female.Text
        End If
        If txtFName.Text = "" Or cmdDept.Text = "" Or txtFMOB.Text = "" Or txtFemail.Text = "" Or cmdDesignation.Text = "" Then
            MsgBox("Select A Row from Gridview and then Click on Update !! ", vbOKOnly, "Form Registration")
            Exit Sub
        Else
            rec_open("update faculty set fname='" & txtFName.Text & "',fdept='" & cmdDept.Text & "',doj='" & DateTimePicker1.Value & "',mob='" & txtFMOB.Text & "',fq='" & txtFQ.Text & "',email='" & txtFemail.Text & "',desgn='" & cmdDesignation.Text & "',gender='" & gender & "' where fid='" & txtFid.Text & "' ")
            MsgBox("Data Updated Successfully!!", vbOKOnly, "Status Update")
            updateTable()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtFName.Text = "" Or cmdDept.Text = "" Or txtFMOB.Text = "" Or txtFemail.Text = "" Or cmdDesignation.Text = "" Then
            MsgBox("Select A Row from Gridview And then Click on Delete !! ", vbOKOnly, "Form Registration")
            Exit Sub
        Else
            rec_open("delete from faculty where Fid= " & txtFid.Text & "")
            MsgBox("Data Deleted Successfully!!", vbOKOnly, "Status Update")
            updateTable()
        End If

    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim height As Integer = DataGridView.Height
        DataGridView.Height = DataGridView.RowCount * DataGridView.RowTemplate.Height
        bitmap = New Bitmap(Me.DataGridView.Height, Me.DataGridView.Width)
        DataGridView.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.DataGridView.Height, Me.DataGridView.Width))
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
        DataGridView.Height = height
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 0, 0)
        Dim recP As RectangleF = e.PageSettings.PrintableArea
        If Me.DataGridView.Height - recP.Height > 0 Then e.HasMorePages = True
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                Dim dv As DataView
                dv = table.DefaultView
                dv.RowFilter = String.Format("Fname Like '%{0}%'", txtSearch.Text)
                DataGridView.DataSource = table
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        txtFid.Text = ""
        txtFName.Text = ""
        DateTimePicker1.Value = Now
        cmdDept.Text = "Select"
        txtFMOB.Text = ""
        txtFQ.Text = ""
        txtFemail.Text = ""
    End Sub

    Private Sub DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellClick
        Dim gender As String
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.DataGridView.Rows(e.RowIndex)
                'GlobalVariables.SelectedlineItemRowNo = e.RowIndex ' Or row
                'MsgBox("GlobalVariables.SelectedlineItemRowNo is ---> " & GlobalVariables.SelectedlineItemRowNo)
                txtFid.Text = row.Cells("fid").Value.ToString()
                txtFName.Text = row.Cells("fname").Value.ToString()
                cmdDept.Text = row.Cells("fdept").Value.ToString()
                DateTimePicker1.Value = row.Cells("doj").Value.ToString()
                txtFMOB.Text = row.Cells("mob").Value.ToString()
                txtFQ.Text = row.Cells("fq").Value.ToString()
                txtFemail.Text = row.Cells("mob").Value.ToString()
                cmdDesignation.Text = row.Cells("desgn").Value.ToString()
                gender = row.Cells("gender").Value.ToString()
                If gender = "MALE" Then
                    Male.Checked = True
                ElseIf gender = "FEMALE" Then
                    female.Checked = True
                End If
                'textboxTst.Text = row.Cells("Description").Value.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtFid_TextChanged(sender As Object, e As EventArgs) Handles txtFid.TextChanged

    End Sub

    Private Sub DataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellContentClick

    End Sub

    Private Sub txtFMOB_TextChanged(sender As Object, e As EventArgs) Handles txtFMOB.TextChanged

    End Sub

    Private Sub txtFQ_TextChanged(sender As Object, e As EventArgs) Handles txtFQ.TextChanged

    End Sub
End Class