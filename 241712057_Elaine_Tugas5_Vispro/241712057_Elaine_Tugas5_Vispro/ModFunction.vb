Module ModFunction
    Public Function HitungTotal(berat As Decimal, isMember As Boolean,
                                 ByRef subtotal As Decimal,
                                 ByRef diskon As Decimal) As Decimal

        Const hargaPerKg As Decimal = 11000D

        subtotal = berat * hargaPerKg
        Dim persenDiskon As Decimal = 0D

        If berat >= 15 Then
            persenDiskon += 0.1D
        End If

        If isMember AndAlso berat >= 10 Then
            persenDiskon += 0.05D
        ElseIf isMember Then
            persenDiskon += 0.02D
        End If

        If persenDiskon > 0.15D Then
            persenDiskon = 0.15D
        End If

        diskon = subtotal * persenDiskon
        Return subtotal - diskon
    End Function
End Module