Imports BEZKalkulu
Imports DatuGeruza

Public Class BEZKalkulu_DatuSortzaileaz
    Private kalkulu As BEZaren_Kalkulua_DLL
    Public Sub New(FakturaKodea As Integer)
        Dim totala As Double = DatuSortzailea.FakturarenTotala(FakturaKodea)
        Dim bezMota As Byte = DatuSortzailea.FakturarenBEZMota(FakturaKodea)
        kalkulu = New BEZKalkulu.BEZaren_Kalkulua_DLL(totala, bezMota)
    End Sub
    Public Function TotalaBEZgabe() As Double
        Return kalkulu.TotalaBEZikGabe()
    End Function

    Public Function dagokionBEZ() As Double
        Return kalkulu.BEZa()
    End Function

End Class
