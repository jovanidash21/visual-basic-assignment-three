Public Class CollectionForm
    Dim TasksOrder As Integer = 0
    Dim Tasks As New Collection

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        TasksOrder = TasksOrder + 1
        Dim TasksName As String
        TasksName = InputBox("Enter Task")
        Tasks.Add(TasksName)
        TaskDataGridView.Rows.Add(TasksOrder, TasksName)
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Tasks.Clear()
        TasksOrder = 0
        TaskDataGridView.Rows.Clear()
    End Sub
End Class