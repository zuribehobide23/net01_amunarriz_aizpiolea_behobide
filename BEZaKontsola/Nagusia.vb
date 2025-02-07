Module Nagusia
    Sub Main()
        Try
            Console.Write("Sartu fakturaren totala: ")
            Dim totala As Double = Convert.ToDouble(Console.ReadLine())

            Console.Write("Sartu BEZ mota (%21, %10, %5): ")
            Dim bezMota As Byte = Convert.ToByte(Console.ReadLine())

            Dim kalkulua As New BEZKalkulu.BEZaren_Kalkulua_DLL(totala, bezMota)

            Console.WriteLine("Totala BEZik gabe: " & kalkulua.TotalaBEZikGabe().ToString("F2") & "€")
            Console.WriteLine("BEZa: " & kalkulua.BEZa().ToString("F2") & "€")

        Catch ex As Exception
            Console.WriteLine("Errorea: " & ex.Message)
        End Try

        Console.WriteLine("Sakatu enter irteteko...")
        Console.ReadLine()
    End Sub
End Module
