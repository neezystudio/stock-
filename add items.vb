Public Class add_items
    Private Sub add_items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmumaDataSet.add_items' table. You can move, or remove it, as needed.
        Me.Add_itemsTableAdapter.Fill(Me.EmumaDataSet.add_items)

    End Sub
End Class