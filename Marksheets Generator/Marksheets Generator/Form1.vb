Public Class Form1

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p, c, f, t, per As Integer
        p = TextBox1.Text
        c = TextBox2.Text
        f = TextBox3.Text
        t = p + c + f
        TextBox4.Text = t

        per = t / 3
        TextBox5.Text = per
        If p >= 33 And c >= 33 And f < 33 Then
            TextBox5.Text = ""
            TextBox6.Text = "Back in Funda"
            TextBox7.Text = "Fail"
        ElseIf p >= 33 And c < 33 And f >= 33 Then
            TextBox5.Text = ""
            TextBox6.Text = "Back in C"
            TextBox7.Text = "Fail"
        ElseIf p < 33 And c >= 33 And f >= 33 Then
            TextBox5.Text = ""
            TextBox6.Text = "Back in PC"
            TextBox7.Text = "Fail"
        ElseIf p < 33 And c < 33 And f >= 33 Then
            TextBox5.Text = ""
            TextBox6.Text = "Back in PC & C"
            TextBox7.Text = "Fail"
        ElseIf p >= 33 And c < 33 And f < 33 Then
            TextBox5.Text = ""
            TextBox6.Text = "Back in Funda & C"
            TextBox7.Text = "Fail"
        ElseIf p < 33 And c >= 33 And f < 33 Then
            TextBox5.Text = ""
            TextBox6.Text = "Back in PC & Funda"
            TextBox7.Text = "Fail"
        ElseIf p < 33 And c < 33 And f < 33 Then
            TextBox5.Text = ""
            TextBox6.Text = "Back in all "
            TextBox7.Text = "Fail"
        Else
            If per >= 75 Then
                TextBox6.Text = "First"
                TextBox7.Text = "Pass"
            ElseIf per >= 60 Then
                TextBox6.Text = "Second"
                TextBox7.Text = "Pass"
            ElseIf per >= 33 Then
                TextBox6.Text = "Third"
                TextBox7.Text = "Pass"
            Else
                TextBox6.Text = "No Div"
                TextBox7.Text = "Fail"



            End If
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox1.Focus()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()






    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
