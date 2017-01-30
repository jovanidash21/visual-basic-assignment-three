Public Class ArrayForm
    Dim TasksOrder(21) As String
    Dim TasksName(21) As String
    Dim DataCount As Integer = 0

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        TasksOrder(DataCount) = DataCount + 1
        TasksName(DataCount) = InputBox("Enter Task")
        TaskDataGridView.Rows.Add(TasksOrder(DataCount), TasksName(DataCount))

        DataCount = DataCount + 1
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DataCount = 0
        TaskDataGridView.Rows.Clear()
    End Sub
End Class