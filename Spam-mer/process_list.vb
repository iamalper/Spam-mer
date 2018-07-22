
Imports Spam_mer.SpamMer


Public Class process_list


    Private Sub process_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each p As Process In Process.GetProcesses()
            ListBox1.Items.Add(p.ProcessName)
        Next
        Button1.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Debug.WriteLine(Process.GetProcessesByName(ListBox1.SelectedItem))
    End Sub
End Class