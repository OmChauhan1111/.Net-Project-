Public Class Form1
    Dim black As Decimal, navy As Decimal, red As Decimal, totalorder As Decimal, totalprice As Decimal, totaldue As Decimal, total As Decimal


    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        black = Convert.ToInt16(TextBox1.Text)
        navy = Convert.ToInt16(TextBox2.Text)
        red = Convert.ToInt16(TextBox3.Text)
        totalorder = black + navy + red
        TextBox4.Text = (totalorder)
        black = black * 45.99
        navy = navy * 39.99
        red = red * 39.99

        totalprice = black + navy + red
        TextBox7.Text = (totalprice)
        TextBox6.Text = "0.00"
        If CheckBox1.Checked Then
            totaldue = totalprice * 10 / 100
            TextBox6.Text = (totaldue)
            totaldue = totalprice - totaldue
            TextBox5.Text = (totaldue)
        ElseIf totalorder > 2 Then
            total = totalprice * 5 / 100
            TextBox6.Text = (total)
            total = totalprice - total
            TextBox5.Text = (total)
        Else
            TextBox6.Text = "0.00"
            TextBox5.Text = (totalprice)

           





        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            MessageBox.Show("Enabled credit card, you get 10% discount.")
            totaldue = totalprice * 10 / 100
            TextBox6.Text = (totaldue)
            totaldue = totalprice - totaldue
            TextBox5.Text = (totaldue)
        ElseIf totalorder > 2 Then
            total = totalprice * 5 / 100
            TextBox6.Text = (total)
            total = totalprice - total
            TextBox5.Text = (total)
        Else
            TextBox6.Text = "0.00"
            TextBox5.Text = (totalprice)
            MessageBox.Show("Disabled credit card, you get 0% discount.")

        End If

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
