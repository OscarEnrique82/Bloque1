Module Module1
    ' Oscar Enrique Mejía Chávez DSNP011423
    Sub Main()
        ' Declaración de variables
        Dim num As Integer
        Dim tabla As Integer
        Dim i As Integer
        ' Ingresar el número
        Console.WriteLine("-------------------------------------------------------")
        Console.WriteLine("Ingrese el número del que desea la tabla de multiplicar")
        Console.WriteLine("-------------------------------------------------------")
        num = Console.ReadLine()
        Console.WriteLine()
        Console.WriteLine("-----------------------------------------")
        Console.WriteLine("La tabla de multiplicar del número " & num & " es:")
        Console.WriteLine("-----------------------------------------")
        Console.WriteLine()
        Console.WriteLine("-------------")
        For i = 1 To 10
            tabla = i * num
            Console.WriteLine(num & " x " & i & " = " & tabla)
        Next
        Console.WriteLine("-------------")
        Console.WriteLine("")
        Console.WriteLine("--------------------------------------")
        Console.WriteLine("Presione cualquier tecla para salir...")
        Console.WriteLine("--------------------------------------")
        Console.ReadKey()
    End Sub

End Module
