Public Class DatuSortzailea
    Private Shared FakturenZenbatekoakEtaBEZMotak = New Double(,) {{2500, 10}, {3150.55, 21}, {25000, 21}, {315.25, 5}}
    Private Sub New()
    End Sub
    Public Shared Function FakturarenTotala(ByVal FakturaKodea As Integer) As Double
        If FakturaKodea < 1 OrElse FakturaKodea > FakturenZenbatekoakEtaBEZMotak.GetLength(0) Then
            Throw New ArgumentOutOfRangeException("Faktura ez da existitzen.")
        End If
        Return FakturenZenbatekoakEtaBEZMotak(FakturaKodea - 1, 0)
    End Function
    Public Shared Function FakturarenBEZMota(ByVal FakturaKodea As Integer) As Byte
        If FakturaKodea < 1 OrElse FakturaKodea > FakturenZenbatekoakEtaBEZMotak.GetLength(0) Then
            Throw New ArgumentOutOfRangeException("Faktura ez da existitzen.")
        End If
        Return CByte(FakturenZenbatekoakEtaBEZMotak(FakturaKodea - 1, 1))
    End Function
End Class
