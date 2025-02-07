Public Class Form1
    Private Sub Button_Kalkulatu(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FakturaKodea As Integer = Convert.ToInt32(TextBox1.Text)

        Try
            Dim bezKalkulu As New BEZaren_Kalkulua_DatuGeruzaz_DLL.BEZKalkulu_DatuSortzaileaz(FakturaKodea)

            TextBox2.Text = bezKalkulu.TotalaBEZgabe().ToString("F2")
            TextBox3.Text = bezKalkulu.dagokionBEZ().ToString("F2")
        Catch ex As ArgumentOutOfRangeException
            MessageBox.Show(ex.Message, "Errorea", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
