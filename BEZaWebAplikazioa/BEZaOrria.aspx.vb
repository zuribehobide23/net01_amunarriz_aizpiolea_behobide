Public Class BEZaOrria
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnKalkulatu_Click(sender As Object, e As EventArgs)
        Try
            Dim totala As Double = Convert.ToDouble(txtTotala.Text)
            Dim bezMota As Byte = Convert.ToByte(txtMota.Text)

            Dim kalkulua As New BEZKalkulu.BEZaren_Kalkulua_DLL(totala, bezMota)

            Dim totalaBEZikGabe As Double = kalkulua.TotalaBEZikGabe()
            Dim bezZerga As Double = kalkulua.BEZa()

            lblResult.Text = $"Totala BEZik gabe: {totalaBEZikGabe:F2}€<br />BEZa: {bezZerga:F2}€"

        Catch ex As Exception
            lblResult.Text = $"Errorea: {ex.Message}"
        End Try
    End Sub
    Protected Sub ValidateMota(source As Object, args As ServerValidateEventArgs)
        Dim validValues As Integer() = {5, 10, 21}
        Dim inputValue As Integer

        If Integer.TryParse(args.Value, inputValue) AndAlso validValues.Contains(inputValue) Then
            args.IsValid = True
        Else
            args.IsValid = False
        End If
    End Sub

End Class