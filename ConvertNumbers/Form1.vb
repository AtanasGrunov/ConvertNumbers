Public Class Form1

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result = MessageBox.Show("Сигурен ли си че желаеш да спреш програмата?", "Преобразуване на числа", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        lblBinary.Text = ""
        lblDecimal.Text = ""
        lblHex.Text = ""
        lblOctal.Text = ""
        txtConverter.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If txtConverter.Text = "" Then
            MessageBox.Show("Моля въведете число", "Преобразуване на числа", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtConverter.Focus()

        Else

            Dim numConverter As Integer = Integer.Parse(txtConverter.Text)
            lblBinary.Text = Convert.ToString(numConverter, 2)
            lblDecimal.Text = numConverter.ToString()
            lblHex.Text = Convert.ToString(numConverter, 16)
            lblOctal.Text = Convert.ToString(numConverter, 8)

        End If


    End Sub

End Class
