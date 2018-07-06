


'This project made by DOSTeam
'Maybe some english word incorrect



Public Class SpamMer

    Public running As Boolean = False
    Public pidextising As Boolean = False
    Public pid As Integer
    Dim r, g, b As Integer
    Private Sub closebutton_Click(sender As Object, e As EventArgs) Handles closebutton.Click

        'closing app
        If MsgBox("Are you sure you want to leave?", MsgBoxStyle.YesNo, "Goodbye") = MsgBoxResult.Yes Then
            'press yes             
            Timer1.Stop()
            Me.Close()
        End If
    End Sub




    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles startbutton.Click

        If running = False Then

            'start

            'locking controls
            startbutton.Text = "stop"
            settingsbutton.Enabled = False
            helpbutton.Enabled = False
            rateusbutton.Enabled = False
            developersbutton.Enabled = False
            invertalnumetric.Enabled = False





            'setting invertal seconds
            Timer1.Interval = invertalnumetric.Value * 1000



            'start
            Timer1.Start()


            running = True



        Else

stp:
            'stop

            'unlocking controls

            startbutton.Text = "Start"
            settingsbutton.Enabled = True
            helpbutton.Enabled = True
            rateusbutton.Enabled = True
            developersbutton.Enabled = True
            invertalnumetric.Enabled = True

            'stopping timer
            Timer1.Stop()

            running = False

        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'randomizing

        Dim k As String() = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "v", "y", "z"}

        For i As Integer = 0 To 7

            If pidextising = True Then AppActivate(pid)

            Randomize()

            SendKeys.Send(k(Rnd() * 22))
        Next

        SendKeys.Send("{ENTER}")

    End Sub

    Private Sub Feedback(sender As Object, e As EventArgs) Handles rateusbutton.Click
        MsgBox("Please do not rate us for now :)", MsgBoxStyle.Information, "Rate Us")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles helpbutton.Click
        howuse.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles settingsbutton.Click
        settings.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles developersbutton.Click

        'Developers message
        MsgBox("Powered by DOSTeam" & vbNewLine & vbNewLine & "Developers : Meka_4756 and SPYWRD3454", MsgBoxStyle.Information, "Developers")

    End Sub



    Private Sub SpamMer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'start message

        MsgBox("This program is in alpha stage and still developing" & vbNewLine & vbNewLine & "And there can be a lot of bugs and translation errors.", MsgBoxStyle.Information, "Starting message")

    End Sub


End Class
