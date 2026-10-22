Module Program
    Sub Main()
        Console.WriteLine("Contoh 1: For...Next - Tabel Perkalian 7")
        For i As Integer = 1 To 10
            Console.WriteLine("7 x " & i & " = " & (7 * i))
        Next
        Console.WriteLine()

        Console.WriteLine("Contoh 2: For...Next - Hitung Mundur (Step -2)")
        For i As Integer = 10 To 0 Step -2
            Console.Write(i & " ")
        Next
        Console.WriteLine()
        Console.WriteLine()

        Console.WriteLine("Contoh 3: While...End While - Target Tabungan")
        Dim saldo As Integer = 0
        Dim bulan As Integer = 0
        Const target As Integer = 1000000
        Const setoran As Integer = 150000

        While saldo < target
            saldo += setoran
            bulan += 1
            Console.WriteLine("Bulan ke-" & bulan & ", saldo: Rp" & saldo.ToString("N0"))
        End While
        Console.WriteLine("Target tercapai dalam " & bulan & " bulan.")
        Console.WriteLine()

        Console.WriteLine("Contoh 4: Do While...Loop - Validasi Input Nilai")
        Dim nilai As Integer = -1
        Do While nilai < 0 OrElse nilai > 100
            Console.Write("Masukkan nilai (0-100): ")
            If Not Integer.TryParse(Console.ReadLine(), nilai) Then nilai = -1
            If nilai < 0 OrElse nilai > 100 Then
                Console.WriteLine("Nilai tidak valid, silakan ulangi.")
            End If
        Loop
        Console.WriteLine("Nilai diterima: " & nilai)

        Console.WriteLine()
        Console.WriteLine("Tekan Enter untuk keluar...")
        Console.ReadLine()
    End Sub
End Module