Public Class orders
    Private Sub orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmumaDataSet2.orders' table. You can move, or remove it, as needed.
        Me.OrdersTableAdapter1.Fill(Me.EmumaDataSet2.orders)
        'TODO: This line of code loads data into the 'EmumaDataSet1.orders' table. You can move, or remove it, as needed.
        Me.OrdersTableAdapter.Fill(Me.EmumaDataSet1.orders)

    End Sub
End Class