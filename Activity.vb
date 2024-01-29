Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32

Public Class Activity
    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim table As New DataTable()
    Private bitmap As Bitmap

    Protected Sub updateTable()
        Dim table1 As New DataTable()
        Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=root")
        Dim adapter As New MySqlDataAdapter("select * from departmentelevate.activity", connection)
        adapter.Fill(table)
        adapter.Fill(table1)
        DataGridView1.DataSource = table
        DataGridView1.DataSource = table1
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Hide()
        Awards.Show()
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        Me.Hide()
        studentregister.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cmdRegno.Text = "" Or txtName.Text = "" Or txtCname.Text = "" Or txtEname.Text = "" Or txtDesc.Text = "" Or txtOrg.Text = "" Or DateTimePicker1.Text = "" Or cmdType.Text = "" Then
            MsgBox("Mandatory Fields!! Please fill it", vbOKOnly, "Form Activity")
            Exit Sub
        Else
            rec_open("insert into activity values('" & cmdRegno.Text & "','" & txtName.Text & "','" & txtCname.Text & "','" & txtEname.Text & "','" & txtDesc.Text & "','" & txtOrg.Text & "','" & DateTimePicker1.Text & "','" & cmdType.Text & "')")
            MsgBox("Data Inserted Successfully!!", vbOKOnly, "Status Update")
            updateTable()
        End If
    End Sub

    Private Sub Activity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con_open()
        updateTable()
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        rec_open("select Sid from student")
        While Not rs.EOF
            cmdRegno.Items.Add(rs(0).Value)
            rs.MoveNext()
        End While
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim txt
        For Each txt In Me.Controls
            If TypeOf txt Is TextBox Then
                cmdRegno.Text = ""
                txtName.Text = ""
                txtCname.Text = ""
                txtEname.Text = ""
                txtDesc.Text = ""
                txtOrg.Text = ""
                DateTimePicker1.Text = ""
                cmdType.Text = "Select"
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
        If cmdRegno.Text = "" Or txtName.Text = "" Or txtCname.Text = "" Or txtEname.Text = "" Or txtDesc.Text = "" Or txtOrg.Text = "" Or DateTimePicker1.Text = "" Or cmdType.Text = "" Then
            MsgBox("Select A Row from Gridview and then Click on Update !! ", vbOKOnly, "Form Activity")
            Exit Sub
        Else
            rec_open("update activity set Name='" & txtName.Text & "',Cname='" & txtCname.Text & "',Ename='" & txtEname.Text & "',descp='" & txtDesc.Text & "',Org='" & txtOrg.Text & "',Date='" & DateTimePicker1.Value & "',Type='" & cmdType.Text & "' where Regno='" & cmdRegno.Text & "'")
            MsgBox("Data Updated Successfully!!", vbOKOnly, "Status Update")
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
                cmdRegno.Text = row.Cells("Regno").Value.ToString()
                txtName.Text = row.Cells("Name").Value.ToString()
                txtCname.Text = row.Cells("Cname").Value.ToString()
                txtEname.Text = row.Cells("Ename").Value.ToString()
                txtDesc.Text = row.Cells("descp").Value.ToString()
                txtOrg.Text = row.Cells("Org").Value.ToString()
                DateTimePicker1.Value = row.Cells("Date").Value.ToString()
                cmdType.Text = row.Cells("Type").Value.ToString()
                'textboxTst.Text = row.Cells("Description").Value.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
        If cmdRegno.Text = "" Or txtName.Text = "" Or txtCname.Text = "" Or txtEname.Text = "" Or txtDesc.Text = "" Or txtOrg.Text = "" Or DateTimePicker1.Text = "" Or cmdType.Text = "" Then
            MsgBox("Select A Row from Gridview and then Click on Delete !! ", vbOKOnly, "Form Activity")
            Exit Sub
        Else
            rec_open("delete from activity where Regno= '" & cmdRegno.Text & "'")
            MsgBox("Data Deleted Successfully!!", vbOKOnly, "Status Update")
            updateTable()
        End If
    End Sub

    Private Sub cmdRegno_LostFocus(sender As Object, e As EventArgs) Handles cmdRegno.LostFocus
        rec_open("select Sname from student where Sid='" & cmdRegno.Text & "' ")
        txtName.Text = rs(0).Value
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub
End Class
