Public Class profile
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        add_items.Show()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        orders.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Sales.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Expenses.Show()

    End Sub
End Class