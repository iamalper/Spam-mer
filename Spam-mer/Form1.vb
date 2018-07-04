


'This project made by DOSTeam
'Maybe some english word incorrect



Public Class SpamMer

    Public running As Boolean = False
    Public pidextising As Boolean = False
    Public pid As Integer
    Dim r, g, b As Integer
    Private Sub closebutton_Click(sender As Object, e As EventArgs) Handles closebutton.Click

        'closing app
        If MsgBox("Are you sure you want to leave?", MsgBoxStyle.YesNo, "!WARN!NG! You are leaving") = MsgBoxResult.Yes Then
            'press yes             
            Timer1.Stop()
            Me.Close()
        End If
    End Sub




    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If running = False Then

            'start

            'locking controls
            Button6.Text = "stop"
            CheckBox1.Enabled = False
            TextBox1.Enabled = False
            NumericUpDown1.Enabled = False

            'checking PID

            If CheckBox1.Checked = True Then
                If TextBox1.Text = "" Then
                    GoTo stp
                Else
                    pidextising = True
                    pid = TextBox1.Text
                End If
            End If


            'setting invertal seconds
            Timer1.Interval = NumericUpDown1.Value * 1000



            'start
            Timer1.Start()


            running = True



        Else

stp:
            'stop

            'unlocking controls

            Button6.Text = "Start"
            CheckBox1.Enabled = True
            If CheckBox1.Checked = True Then TextBox1.Enabled = True
            NumericUpDown1.Enabled = True

            'stopping timer
            Timer1.Stop()

            running = False

        End If


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        'PID setting

        If CheckBox1.Checked = True Then
            TextBox1.Enabled = True
        Else
            TextBox1.Enabled = False
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'randomizing

        Dim k As String() = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "v", "y", "z"}

        For i As Integer = 0 To 7
            Randomize()
            If pidextising = True Then AppActivate(pid)
            SendKeys.Send((Rnd() * 22))
        Next

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        howuse.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub



    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub



    Private Sub SpamMer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'start message

        MsgBox("This program is in alpha stage and still developing" & vbNewLine & vbNewLine & "And there can be a lot of bugs and translation errors.", MsgBoxStyle.Information, "Starting message")

    End Sub


End Class
