

Imports Spam_mer.SpamMer


Public Class settings


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            TextBox1.Enabled = True
            Label1.Enabled = True

        Else

            TextBox1.Enabled = False
            Label1.Enabled = False

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        'PID setting

        If CheckBox1.Checked = True Then

            SpamMer.pidextising = True
            SpamMer.pid = TextBox1.Text

        Else

            SpamMer.pidextising = False

        End If

        Me.Close()

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
End Class