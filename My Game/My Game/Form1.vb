Public Class Form1
    Dim xdir As Integer
    Dim ydir As Integer
    Dim score As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        hover(PictureBox2)
        hover(PictureBox4)
        LazerBeam.Image.RotateFlip(RotateFlipType.Rotate270FlipX)
        Me.Refresh()
        scorelable.Text = score
        PictureBox1.Image = PictureBox1.Image
    End Sub
    Sub Move(p As PictureBox, x As Integer, y As Integer)
        p.Location = New Point(p.Location.X + x, p.Location.Y + y)
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.R
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                Me.Refresh()
            Case Keys.Up, Keys.W
                'MoveTo(PictureBox1, 0, -15)
                xdir = 0
                ydir = -10
            Case Keys.Down, Keys.S
                'MoveTo(PictureBox1, 0, 15)
                xdir = 0
                ydir = 10
            Case Keys.Left, Keys.A
                'MoveTo(PictureBox1, -15, 0)
                xdir = -10
                ydir = 0
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                Me.Refresh()
            Case Keys.Right, Keys.D
                'MoveTo(PictureBox1, 15, 0)
                xdir = 10
                ydir = 0
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
                Me.Refresh()
            Case Keys.Space

        End Select
    End Sub
    Sub follow(p As PictureBox)
        Static headstart As Integer
        Static c As New Collection
        c.Add(PictureBox1.Location)
        headstart = headstart + 1
        If headstart > 10 Then
            p.Location = c.Item(1)
            c.Remove(1)
        End If
    End Sub

    Public Sub chase(p As PictureBox)
        Dim x, y As Integer
        If p.Location.X > PictureBox1.Location.X Then
            x = -5
        Else
            x = 5
        End If
        MoveTo(p, x, 0)
        If p.Location.Y < PictureBox1.Location.Y Then
            y = 5
        Else
            y = -5
        End If
        MoveTo(p, x, y)
    End Sub
    Sub hover(p As PictureBox)
        Dim x As Integer
        If p.Location.X > PictureBox1.Location.X Then
            x = -7
        Else
            x = 7
        End If
        MoveTo(p, x, 0)
    End Sub

    Function Collision(p As PictureBox, t As String)
        Dim col As Boolean

        For Each c In Controls
            Dim obj As Control
            obj = c
            If p.Bounds.IntersectsWith(obj.Bounds) And (obj.Name.ToUpper.EndsWith(t.ToUpper) Or obj.Name.ToUpper.StartsWith(t.ToUpper)) Then
                col = True
            End If
        Next
        Return col
    End Function
    'Return true or false if moving to the new location is clear of objects ending with t
    Function IsClear(p As PictureBox, distx As Integer, disty As Integer, t As String) As Boolean
        Dim b As Boolean

        p.Location += New Point(distx, disty)
        b = Not Collision(p, t)
        p.Location -= New Point(distx, disty)
        Return b
    End Function
    'Moves and object (won't move onto objects containing  "wall" and shows green if object ends with "win"
    Sub MoveTo(p As PictureBox, distx As Integer, disty As Integer)
        If IsClear(p, distx, disty, "WALL") Then
            p.Location += New Point(distx, disty)
        End If

        If p.Name = "PictureBox1" And Collision(p, "LazerBeam") Then
            Me.BackColor = Color.DarkRed
            Return
        End If
        If p.Name = "PictureBox1" And Collision(p, "WIN") Then
            Win.Image = PictureBox3.Image
            score = score + 1
            apple2.Visible = True
            Win.Visible = False
            Return
        End If
        If score = 1 Then
            Win.Location = PictureBox5.Location
        End If
        If score = 2 Then
            apple2.Location = PictureBox5.Location
        End If
        If score = 3 Then
            apple3.Location = PictureBox5.Location
        End If
        If score = 4 Then
            apple4.Location = PictureBox5.Location
        End If

        If p.Name = "PictureBox1" And Collision(p, "apple2") Then
            apple2.Visible = False
            apple3.Visible = True
            score = score + 1
        End If
        If p.Name = "PictureBox1" And Collision(p, "apple3") Then
            apple3.Visible = False
            apple4.Visible = True
            score = score + 1
        End If
        If p.Name = "PictureBox1" And Collision(p, "apple4") Then
            apple4.Visible = False
            apple5.visible = True
            score = score + 1
        End If
        If p.Name = "PictureBox1" And Collision(p, "apple5") Then
            PictureBox2.Visible = True
            PictureBox1.Image = PictureBox5.Image
            apple5.Image = PictureBox3.Image
            Timer5.Enabled = True
        End If

    End Sub

    'Return true or false if moving to the new location is clear of objects ending with t

    'Moves and object (won't move onto objects containing  "wall" and shows green if object ends with "win"

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        MoveTo(PictureBox1, xdir, ydir)
        MoveTo(LazerBeam, 0, 10)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If PictureBox2.Visible Then
            LazerBeam.Location = New Point(PictureBox2.Location.X + 10, PictureBox2.Location.Y + 5)

        End If

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        PictureBox2.Image = PictureBox4.Image
        Me.Refresh()
    End Sub



    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Me.BackColor = Color.Green
        If Me.BackColor = Color.Red Then
            Timer5.Enabled = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
