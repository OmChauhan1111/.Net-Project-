Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim per As Integer
        per = Convert.ToInt16(Txtn1.Text)
        If per >= 70 Then
            MessageBox.Show("A Grade")
        ElseIf per >= 60 Then
            MessageBox.Show("B Grade")
        ElseIf per >= 50 Then
            MessageBox.Show("D Grade")
        ElseIf per >= 40 Then
            MessageBox.Show("D Grade")

        Else
            MessageBox.Show("Failed")
        End If
    End Sub
End Class
