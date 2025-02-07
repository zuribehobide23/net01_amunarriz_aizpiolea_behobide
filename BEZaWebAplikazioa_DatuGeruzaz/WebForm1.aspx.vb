Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnKalkulatu_Click(sender As Object, e As EventArgs)
        Dim FakturaKodea As Integer = Convert.ToInt32(txtKodea.Text)
        Try
            Dim bezKalkulu As New BEZaren_Kalkulua_DatuGeruzaz_DLL.BEZKalkulu_DatuSortzaileaz(FakturaKodea)

            Dim totalaBEZikGabe As Double = bezKalkulu.TotalaBEZgabe()
            Dim bezZerga As Double = bezKalkulu.dagokionBEZ()

            lblResult.Text = $"Totala BEZik gabe: {totalaBEZikGabe:F2}€<br />BEZa: {bezZerga:F2}€"
        Catch ex As Exception
            lblResult.Text = $"Errorea: {ex.Message}"
        End Try

    End Sub

End Class