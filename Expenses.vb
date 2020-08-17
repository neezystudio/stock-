Public Class Expenses
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Expenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmumaDataSet3.Expenses' table. You can move, or remove it, as needed.
        Me.ExpensesTableAdapter.Fill(Me.EmumaDataSet3.Expenses)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim operation As String
        Dim num1 As Double
        Dim num2 As Double
        Dim answer As Double

        operation = Me.operation.Text

        Double.TryParse(num1Textbox.Text, num1)
        Double.TryParse(num2Textbox.Text, num2)

        If operation = "A" Then
            answer = num1 + num2
        ElseIf operation = "S" Then
            answer = num1 - num2

        ElseIf operation = "M" Then
            answer = num1 * num2
        ElseIf operation = "D" Then
            answer = num1 / num2
        End If
            Dim answerLabel As Object = Nothing
        answerTextbox.Text = answer.ToString



    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles num1Textbox.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles answerTextbox.TextChanged

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class