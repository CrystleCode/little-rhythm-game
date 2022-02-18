Public Class Form1
    Dim Score As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub CreateAButton()
        Dim aButton As New Label
        aButton.AutoSize = False
        aButton.TextAlign = ContentAlignment.MiddleCenter
        aButton.Width = 100
        aButton.Height = 100
        aButton.BackColor = Color.Red
        aButton.Text = "A"
        aButton.Font = New Font("Microsoft Sans Serif", 27)
        aButton.Tag = "aB"
        aButton.Location = aButtonSpawn.Location
        Me.Controls.Add(aButton)
        aButton.BringToFront()
        niceTextA.BringToFront()
    End Sub
    Private Sub CreateDButton()
        Dim dButton As New Label
        dButton.AutoSize = False
        dButton.TextAlign = ContentAlignment.MiddleCenter
        dButton.Width = 100
        dButton.Height = 100
        dButton.BackColor = Color.Blue
        dButton.Text = "D"
        dButton.Font = New Font("Microsoft Sans Serif", 27)
        dButton.Tag = "dB"
        dButton.Location = dButtonSpawn.Location
        Me.Controls.Add(dButton)
        dButton.BringToFront()
    End Sub
    Private Sub UpdateScore(scoreadd As Integer)
        Score = Score + scoreadd
        scoreText.Text = "Score: " & Score
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.E Then
            CreateAButton()
        End If

        If e.KeyCode = Keys.A Then

            Dim aY As Integer = aBacking.Location.Y
            Dim under10aY As Integer = aBacking.Location.Y - 10
            Dim above10aY As Integer = aBacking.Location.Y + 10

            Dim under50aY As Integer = aBacking.Location.Y - 50
            Dim above50aY As Integer = aBacking.Location.Y + 50

            For Each i As Control In Me.Controls
                If TypeOf i Is Label Then
                    If i.Tag = "aB" Then
                        If i.Bounds.IntersectsWith(aBacking.Bounds) Then

                            If i.Location.Y >= under10aY And i.Location.Y <= above10aY Then
                                niceTextA.Text = "PERFECT!"
                                UpdateScore(100)
                            ElseIf i.Location.Y >= under50aY And i.Location.Y <= above50aY Then
                                niceTextA.Text = "NICE!"
                                UpdateScore(50)
                            Else
                                UpdateScore(10)
                                niceTextA.Text = "LAME!"
                            End If
                            Me.Controls.Remove(i)
                        End If
                    End If
                End If
            Next

        End If

        If e.KeyCode = Keys.D Then

            Dim dY As Integer = dBacking.Location.Y
            Dim under10dY As Integer = dBacking.Location.Y - 10
            Dim above10dY As Integer = dBacking.Location.Y + 10

            Dim under50dY As Integer = dBacking.Location.Y - 50
            Dim above50dY As Integer = dBacking.Location.Y + 50

            For Each i As Control In Me.Controls
                If TypeOf i Is Label Then
                    If i.Tag = "dB" Then
                        If i.Bounds.IntersectsWith(dBacking.Bounds) Then

                            If i.Location.Y >= under10dY And i.Location.Y <= above10dY Then
                                UpdateScore(100)
                                niceTextD.Text = "PERFECT!"
                            ElseIf i.Location.Y >= under50dY And i.Location.Y <= above50dY Then
                                UpdateScore(50)
                                niceTextD.Text = "NICE!"
                            Else
                                UpdateScore(10)
                                niceTextD.Text = "LAME!"
                            End If

                            Me.Controls.Remove(i)
                        End If
                    End If
                End If
            Next

        End If

    End Sub

    Private Sub moveA_Tick(sender As Object, e As EventArgs) Handles moveA.Tick
        For Each i As Control In Me.Controls
            If TypeOf i Is Label Then
                If i.Tag = "aB" Then
                    i.Top = i.Top - 5
                    If i.Bounds.IntersectsWith(failSafeA.Bounds) Then
                        Me.Controls.Remove(i)
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub createA_Tick(sender As Object, e As EventArgs) Handles createATIMER.Tick
        CreateAButton()
        Dim randy As New Random
        Dim newInterval = randy.Next(800, 1001)
        createATIMER.Interval = newInterval
    End Sub

    Private Sub moveD_Tick(sender As Object, e As EventArgs) Handles moveD.Tick
        For Each i As Control In Me.Controls
            If TypeOf i Is Label Then
                If i.Tag = "dB" Then
                    i.Top = i.Top - 5

                    If i.Bounds.IntersectsWith(failSafeD.Bounds) Then
                        Me.Controls.Remove(i)
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub createD_Timer_Tick(sender As Object, e As EventArgs) Handles createD_Timer.Tick
        CreateDButton()
        Dim randy As New Random
        Dim newInterval = randy.Next(600, 1001)
        newInterval = randy.Next(600, 1001)
        createD_Timer.Interval = newInterval
    End Sub

    Private Sub label1_Click(sender As Object, e As EventArgs) Handles label1.Click
        moveA.Start()
        moveD.Start()
        createD_Timer.Start()
        createATIMER.Start()
    End Sub
End Class
