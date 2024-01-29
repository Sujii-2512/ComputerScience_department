Public Class Login
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con_open()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim uname, pwd As String
        Dim flag As Boolean
        uname = TextBox1.Text
        pwd = TextBox2.Text
        rec_open("Select username, password from login")
        'while Not rs.EOF
        While Not rs.EOF
            'username=rs(0)
            'password=rs(1)
            'msgbox(username & password)
            If (uname = rs(0).Value And pwd = rs(1).Value) Then
                flag = True
            End If
            rs.MoveNext()
        End While
        If flag Then
            MsgBox("Valid user")
            HomePage.Show()
        Else
            MsgBox("Invalid user")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim iExit As DialogResult

        iExit = MessageBox.Show("Confirm if you want to exit", "Datagridview System", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If iExit = DialogResult.Yes Then
            Me.Hide()
            Application.Exit()
        End If
    End Sub
End Class
