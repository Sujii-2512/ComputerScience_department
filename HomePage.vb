Public Class HomePage
    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PictureBox1.Visible = True Then
            PictureBox1.Visible = False
            PictureBox2.Visible = True
        ElseIf PictureBox2.Visible = True Then
            PictureBox2.Visible = False
            PictureBox3.Visible = True
        ElseIf PictureBox3.Visible = True Then
            PictureBox3.Visible = False
            PictureBox4.Visible = True
        ElseIf PictureBox4.Visible = True Then
            PictureBox4.Visible = False
            PictureBox1.Visible = True
        End If
    End Sub

    Private Sub STUDENTToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles STUDENTToolStripMenuItem.Click
        Me.Hide()
        studentregister.Show()
    End Sub

    Private Sub FACULTYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FACULTYToolStripMenuItem.Click
        Me.Hide()
        Registeration.Show()
    End Sub

    Private Sub ABOUTPROJECTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABOUTPROJECTToolStripMenuItem.Click
        Me.Hide()
        About_us.Show()
    End Sub

    Private Sub BCAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BCAToolStripMenuItem.Click
        Me.Hide()
        BCA.Show()
    End Sub

    Private Sub BBAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BBAToolStripMenuItem.Click
        Me.Hide()
        BBA.Show()
    End Sub

    Private Sub BScToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BScToolStripMenuItem.Click
        Me.Hide()
        BSc.Show()
    End Sub

    Private Sub BComToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BComToolStripMenuItem.Click
        Me.Hide()
        Bcom.Show()
    End Sub

    Private Sub AWARDSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AWARDSToolStripMenuItem.Click
        Me.Hide()
        Awards.Show()
    End Sub

    Private Sub EVENTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EVENTSToolStripMenuItem.Click
        Me.Hide()
        Activity.Show()
    End Sub

    Private Sub PLACEMENTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PLACEMENTSToolStripMenuItem.Click
        Me.Hide()
        Placements.Show()
    End Sub

    Private Sub btnLogoff_Click(sender As Object, e As EventArgs) Handles btnLogoff.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub MINUTESOFMEETINGSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MINUTESOFMEETINGSToolStripMenuItem.Click
        Me.Hide()
        Minutes.Show()
    End Sub

    Private Sub ORGANIZEDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORGANIZEDToolStripMenuItem.Click
        Me.Hide()
        Organise.Show()
    End Sub

    Private Sub ATTENDEDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ATTENDEDToolStripMenuItem.Click
        Me.Hide()
        Attended.Show()
    End Sub

    Private Sub REPORTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REPORTToolStripMenuItem.Click
        Me.Hide()
        NAAC.Show()
    End Sub

    Private Sub PAPERPUBLICATIONToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PAPERPUBLICATIONToolStripMenuItem1.Click
        Me.Hide()
        PaperPublication.Show()
    End Sub

    Private Sub ABOUTSJRCWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABOUTSJRCWToolStripMenuItem.Click
        Me.Hide()
        aboutdept.show()
    End Sub

    Private Sub COURSEDETAILSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COURSEDETAILSToolStripMenuItem.Click
        Me.Hide()
        CourseDetails.Show()
    End Sub

    Private Sub WORKLOADToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WORKLOADToolStripMenuItem.Click
        Me.Hide()
        subjecthandling.Show()
    End Sub
End Class