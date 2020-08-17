Public Class authentication






    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Panel3.Hide()
        Panel4.Show()


    End Sub

    Private Sub authentication_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel4.Hide()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Panel3.Show()
        Panel4.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox4.Text = My.Settings.USERNAME And TextBox7.Text = My.Settings.PASSWORD AndAlso TextBox8.Text = "ADMIN" Then
            MsgBox("LOGIN SUCCESSFUL", MsgBoxStyle.Information, "LOGIN")
            profile.Show()
            Me.Hide()
        Else
            If TextBox4.Text = "" And TextBox7.Text = "" And TextBox8.Text = "" Then
                MsgBox("No Username and Password", MsgBoxStyle.Exclamation, "")
            Else
                If TextBox4.Text = "" Then
                    MsgBox("USERNAME REQUIRED", MsgBoxStyle.Critical, "Error")
                Else
                    If TextBox7.Text = "" Then
                        MsgBox("PASSWORD REQUIRED", MsgBoxStyle.Critical, "Error")
                    Else
                        If TextBox8.Text = "" Then
                            MsgBox("ACCESS KEY REQUIED", MsgBoxStyle.Critical, "Error")
                        Else
                            MsgBox("Invalid USERNAME AND/PASSWORD AND/ACCESS KEY", MsgBoxStyle.OkOnly, "LOG IN")
                        End If
                    End If
                End If

            End If

        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim iExit As DialogResult

        Try
            iExit = MessageBox.Show("Confirm if you want to Exit!", "EMUMA AGROVET", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If iExit = DialogResult.No Then
            Else
                Application.Exit()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            Beep()

        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox4.Text = String.Empty
        TextBox7.Text = String.Empty
        TextBox8.Text = String.Empty

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        My.Settings.USERNAME = TextBox11.Text
        My.Settings.PASSWORD = TextBox10.Text
        My.Settings.Save()
        MsgBox("ACCOUNT CREATED!", MsgBoxStyle.Information)
        Panel3.Visible = True
        Panel4.Visible = False
    End Sub
End Class