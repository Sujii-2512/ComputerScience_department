Public Class studentnext
    Private Sub btNHOME_Click(sender As Object, e As EventArgs) Handles btNHOME.Click
        Me.Hide()
        HomePage.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        studentregister.Show()
    End Sub

    Private Sub btnEXIT_Click(sender As Object, e As EventArgs) Handles btnEXIT.Click
        Me.Hide()
        HomePage.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Activity.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Awards.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Placements.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        PaperPublication.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Attended.Show()
    End Sub



End Class