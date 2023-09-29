Module Module1

    Sub Main()
        'FunCType()
        'FunCBool()
        'FunCByte()
        'FunCDbl()
        'FunCInt()
        'FunCStr()
        'FunCChar()
        'FunCDate()
        'OperadorAsignacion()
        'CicloWhile()
        'CicloDoWhile()
        CicloFor()
        Console.Read()
    End Sub

    Sub FunCType()
        Dim numero As Long = 15000.0
        Console.WriteLine(numero)

        Dim nuevoTipo As Single = CType(numero, Single)
        Console.WriteLine(nuevoTipo.GetType.ToString)

    End Sub

    Sub FunCBool()
        Dim a, b, c As Integer
        Dim validar As Boolean

        a = 7
        b = 7
        validar = CBool(a = b)
        Console.WriteLine(validar)
        c = 2
        validar = CBool(a = c)
        Console.WriteLine(validar)

    End Sub

    Sub FunCByte()
        Dim numD As Double
        Dim numB As Byte

        numD = 135.5648
        numB = CByte(numD)
        Console.WriteLine(numB)


    End Sub

    Sub FunCDbl()
        Dim numDec As Decimal
        Dim numDbl As Double

        numDec = 234.684785D

        numDbl = CDbl(numDec * 8.2D * 0.01D)
        Console.WriteLine(numDbl)

    End Sub

    Sub FunCInt()
        Dim numD As Double
        Dim numInt As Integer

        numD = 4368.54785

        numInt = CInt(numD)
        Console.WriteLine(numInt)

    End Sub

    Sub FunCStr()
        Dim numDbl As Double = 437.324
        Dim varStr As String
        varStr = CStr(numDbl)
        Console.WriteLine(varStr.GetType.ToString())


    End Sub

    Sub FunCChar()
        Dim varStr As String = "ABC"
        Dim varChar As Char

        varChar = CChar(varStr)
        Console.WriteLine(varChar)


    End Sub

    Sub FunCDate()
        Dim fechaStr, horaStr As String
        Dim fecha, hora As Date

        fechaStr = "Septiembre 26, 2023"
        horaStr = "5:57:27 PM"  ' "17:57:27"

        fecha = CDate(fechaStr)
        Console.WriteLine(fecha)

        hora = CDate(horaStr)
        Console.WriteLine(hora)

    End Sub

    Sub OperadorAsignacion()
        Dim a, b As Integer

        a = 6
        b = 5
        Console.WriteLine("Los valores de la variableas a operar son: a= " & a & " y b = " & b)
        'a = a + b
        'a += b
        'Console.WriteLine("El resultado de la suma: " & a)

        'a -= b
        'Console.WriteLine("El resultado de la resta: " & a)

        'a *= b
        'Console.WriteLine("El resultado de la multiplicación: " & a)

        'a /= b
        'Console.WriteLine("El resultado de la divición: " & a)

        a = a Mod b
        Console.WriteLine("El resultado de la resto: " & a)

    End Sub

    Sub CicloWhile()
        Dim i = 10
        'While i <= 10
        '    Console.WriteLine("El iterador = " & i)
        '    i += 1
        '    'i = i + 1

        'End While
        'Console.WriteLine(i)

        'While i >= 1
        '    Console.WriteLine("El iterador = " & i)
        '    i -= 1
        '    'i = i - 1

        'End While

        Console.WriteLine("Por favor ingresa un #")
        Dim repetir = Integer.Parse(Console.ReadLine())
        While i <= repetir
            Console.WriteLine("El iterador = " & i)
            i += 1
            'i = i + 1

        End While


    End Sub

    Sub CicloDoWhile()
        Dim i = 1
        'Do
        '    Console.WriteLine("El Interador = " & i)
        '    i += 1
        'Loop While i <= 10

        'Do
        '    Console.WriteLine("El Interador = " & i)
        '    i -= 1
        'Loop While i >= 1

        Dim ramdon = New Random()
        Dim aletorio = ramdon.Next(1, 6)
        Console.WriteLine("El valor ramdon es: " & aletorio)
        Do
            Console.WriteLine("El Interador = " & i)
            i += 1
        Loop While i <= aletorio

    End Sub

    Sub CicloFor()

        'For i = 1 To 10
        '    Console.WriteLine("El interador = " & i)

        'Next

        'For i = 1 To 10 Step 2
        '    Console.WriteLine("El interador = " & i)

        'Next

        'For i = 10 To 1 Step -1
        '    Console.WriteLine("El interador = " & i)

        'Next

        Dim a, b As Integer
        a = 10
        b = Integer.Parse(Console.ReadLine())

        For i = a To b Step 1
            Console.WriteLine("El interador = " & i)

        Next

    End Sub


End Module
