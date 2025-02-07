Public Class BEZaren_Kalkulua_DLL
    Private OrdainduBeharrekoa As Double
    Private BEZMota As Byte
    Public Sub New(ByVal OBTotala As Double, ByVal BMota As Byte)
        If OBTotala <= 0 Then
            Throw New ArgumentException("Ordaindu beharrekoa ezin da negatiboa edo zero izan.")
        End If
        If BMota <> 21 AndAlso BMota <> 10 AndAlso BMota <> 5 Then
            Throw New ArgumentException("BEZ mota baliogabea. Onartutako balioak: 21, 10, 5.")
        End If

        OrdainduBeharrekoa = OBTotala
        BEZMota = BMota
    End Sub
    Public Function TotalaBEZikGabe() As Double
        Return OrdainduBeharrekoa / (1 + (BEZMota / 100.0))
    End Function
    Public Function BEZa() As Double
        Return OrdainduBeharrekoa - TotalaBEZikGabe()
    End Function

End Class
