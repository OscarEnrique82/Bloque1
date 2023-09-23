Module Module1
    ' Oscar Enrique Mejía Chávez DSNP011423
    Sub Main()
        ' Declaracion de variables
        Dim n As Integer
        Dim i As Integer
        Dim suma As Integer
        suma = 0

        ' Ingreso del número a calcular
        Console.WriteLine("---------------------------------------")
        Console.WriteLine("Ingrese un numero positivo mayor que 0:")
        Console.WriteLine("---------------------------------------")
        n = Console.ReadLine()

        ' Evaluación del número 
        If n > 0 Then
            ' Ciclo for para n números
            For i = 1 To n
                suma += i
            Next
            Console.WriteLine("----------------------------------------------------------------")
            Console.WriteLine("La suma de los números naturales hasta " & n & " es igual a: " & suma)
            Console.WriteLine("----------------------------------------------------------------")
            Console.WriteLine()
            Console.WriteLine("Presione cualquier tecla para salir...")
            Console.ReadKey()
        Else
            ' Mensaje de error
            Console.WriteLine("---------------------------------------")
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine(" ¡¡¡El numero ingresado es invalido!!!")
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine("---------------------------------------")
            Console.WriteLine()
            Console.WriteLine("Presione cualquier tecla para salir...")
            Console.ReadKey()
        End If
    End Sub

End Module
