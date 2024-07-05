Public Class Form1

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then

            TextBox1.Enabled = True

        Else
            TextBox1.Enabled = False

        End If

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim h As Integer, vs As Integer, m As Integer, en As Integer
        Dim sum As Integer
       

        h = Convert.ToInt16(TextBox1.Text)
        vs = Convert.ToInt16(TextBox2.Text)
        m = Convert.ToInt16(TextBox3.Text)
        en = Convert.ToInt16(TextBox4.Text)
        Const hindi As Integer = 100
        Const evs As Integer = 200
        Const maths As Integer = 300
        Const english As Integer = 400
        If CheckBox1.Checked = True Then
            sum = sum + hindi * h
        Else
            h = 0
            sum = sum + hindi * h
        End If
        If CheckBox2.Checked = True Then
            sum = sum + evs * vs
        Else
            vs = 0
            sum = sum + evs * vs
        End If
        If CheckBox3.Checked = True Then
            sum = sum + maths * m
           
        Else
            m = 0
            sum = sum + maths * m

        End If
        If CheckBox4.Checked = True Then
            sum = sum + english * en
        Else
            en = 0
            sum = sum + english * en
        End If

        TextBox5.Text = (sum)



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged



    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            TextBox2.Enabled = True
        Else
        TextBox2.Enabled = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            TextBox3.Enabled = True

        Else
        TextBox3.Enabled = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            TextBox4.Enabled = True

        Else
            TextBox4.Enabled = False

        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox1.Text = ""
    End Sub
End Class
