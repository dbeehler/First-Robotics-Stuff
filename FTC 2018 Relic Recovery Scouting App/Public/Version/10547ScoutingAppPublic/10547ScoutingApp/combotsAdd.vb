Imports System.Threading

Public Class combotsAdd

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        btnExit.ForeColor = Color.Gray
        btnExit.BackColor = Color.DarkGray
        btnExit.Enabled = False
        For i As Integer = 0 To 5
            Threading.Thread.Sleep(1000)
            i += 1
            If i > 4 Then
                Me.Close()
            End If
        Next
    End Sub

    Private Sub combotsAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
    End Sub

    Private Sub twitterHandle_Click(sender As Object, e As EventArgs) Handles twitterHandle.Click
        System.Diagnostics.Process.Start("https://twitter.com/ftc_10547?lang=en")
    End Sub

    Private Sub websiteLabel_Click(sender As Object, e As EventArgs) Handles websiteLabel.Click
        System.Diagnostics.Process.Start("http://ftc10547.weebly.com/")
    End Sub

    Private Sub youtubeLabel_Click(sender As Object, e As EventArgs) Handles youtubeLabel.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCAOTfix3NZ2ckWA-zuk2BNw")
    End Sub
End Class