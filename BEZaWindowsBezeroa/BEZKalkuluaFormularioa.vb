Public Class BEZKalkuluaFormularioa
    Private Sub Button_Kalkulatu(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim totala As Double = Convert.ToDouble(TextBox1.Text)
            Dim bezMota As Byte = Convert.ToByte(TextBox2.Text)

            Dim Kalkulua As New BEZKalkulu.BEZaren_Kalkulua_DLL(totala, bezMota)

            TextBox3.Text = Format(Kalkulua.TotalaBEZikGabe(), ".##")
            TextBox4.Text = Format(Kalkulua.BEZa(), ".##")

        Catch ex As Exception
            MessageBox.Show("Errorea: " & ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
