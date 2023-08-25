Public Class MyWatch
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If SS.Text = 59 Then
            If MM.Text = 59 Then
                HH.Text += 1
                MM.Text = 0
                SS.Text = 0
            End If
            MM.Text += 1
            SS.Text = 0
        Else
            SS.Text += 1
        End If

    End Sub

    Sub startWatch()
        Timer1.Start()

    End Sub

    Sub stopWatch()
        Timer1.Stop()
    End Sub

    Sub resetWatch()
        MM.Text = "00"
        HH.Text = "00"
        SS.Text = "00"
    End Sub

End Class
