Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports System.IO

Public Class NAAC
    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim table As New DataTable()
    Private bitmap As Bitmap

    Protected Sub updateTable()
        Dim table1 As New DataTable()
        Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=root")
        Dim adapter As New MySqlDataAdapter("select * from departmentelevate.naac", connection)
        adapter.Fill(table)
        adapter.Fill(table1)
        DataGridView1.DataSource = table
        DataGridView1.DataSource = table1
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            txtNaac.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim FilenameName As String()
        ProgressBar1.Value += 1
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()

            FilenameName = OpenFileDialog1.FileName.Split("\"c)
            File.Copy(OpenFileDialog1.FileName, "NAAC\" + FilenameName(FilenameName.Length - 1))
            MessageBox.Show(" File Uploaded Successfully ")
        End If
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btNHOME.Click
        Me.Hide()
        HomePage.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEXIT.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Confirm if you want to exit", "Datagridview System", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If iExit = DialogResult.Yes Then
            Me.Hide()
            HomePage.Show()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtAcademic.Text = "" Or txtNaac.Text = "" Then
            MsgBox("Mandatory Fields!! Please fill it", vbOKOnly, "Form NAAC")
            Exit Sub
        Else
            rec_open("delete from naac where Academic= '" & txtAcademic.Text & "'")
            MsgBox("Data Deleted Successfully!!", vbOKOnly, "Status Update")
            updateTable()
        End If
    End Sub

    Private Sub NAAC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con_open()
        updateTable()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtAcademic.Text = "" Or txtNaac.Text = "" Then
            MsgBox("Mandatory Fields!! Please fill it", vbOKOnly, "Form NAAC")
            Exit Sub
        Else
            rec_open("insert into naac values('" & txtAcademic.Text & "','" & txtNaac.Text & "')")
            MsgBox("Data Inserted Successfully!!", vbOKOnly, "Status Update")
            updateTable()
        End If
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                Dim dv As DataView
                dv.RowFilter = String.Format("Academic Like '%{0}%'", txtSearch.Text)
                DataGridView1.DataSource = table
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtAcademic.Text = "" Or txtNaac.Text = "" Then
            MsgBox("Select A Row from Gridview and then Click on Update !! ", vbOKOnly, "Form NAAC")
            Exit Sub
        Else
            rec_open("update naac set file='" & txtNaac.Text & "'where Academic='" & txtAcademic.Text & " ")
            MsgBox("Data Updated Successfully!!", vbOKOnly, "Status Update")
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
                txtAcademic.Text = row.Cells("Academic").Value.ToString()
                txtNaac.Text = row.Cells("file").Value.ToString()

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
                txtAcademic.Text = "Select"
                txtNaac.Text = ""
                ProgressBar1.Text = ""

            End If
        Next
    End Sub
End Class