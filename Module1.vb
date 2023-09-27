Module Module1

    Sub Main()
        'FunCType()
        'FunCBool()
        'FunCByte()
        'FunCDbl()
        'FunCInt()
        'FunCStr()
        'FunCChar()
        FunCDate()
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

End Module
