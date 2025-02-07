Module BEZKalkulu_DatuSortzaileaz
    Sub Main()
        Console.Write("Sartu fakturaren kodea (1 eta 4 artean): ")
        Dim FakturaKodea As Integer
        Try
            FakturaKodea = Convert.ToInt32(Console.ReadLine())

            If FakturaKodea < 1 Or FakturaKodea > 4 Then
                Throw New ArgumentOutOfRangeException("Faktura kodea", "Kodea 1 eta 4 artekoa izan behar da.")
            End If

            Dim bezKalkulu As New BEZaren_Kalkulua_DatuGeruzaz_DLL.BEZKalkulu_DatuSortzaileaz(FakturaKodea)

            Console.WriteLine($"Totala BEZ gabe: {bezKalkulu.TotalaBEZgabe()}")
            Console.WriteLine($"Dagokion BEZ-a: {bezKalkulu.dagokionBEZ()}")
        Catch ex As Exception
            Console.WriteLine("Errorea: " & ex.Message)
        End Try

        Console.WriteLine("Sakatu enter irteteko...")
        Console.ReadLine()
    End Sub
End Module
