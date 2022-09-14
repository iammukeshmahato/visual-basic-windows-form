Module Module1

    Sub Main()
        Dim a As Integer
        Console.Write("Enter the value of a: ")
        a = Int(Console.ReadLine())

        Console.WriteLine("Passing value byVal method")
        Console.WriteLine("the value of a before increment = " & a)
        incrementValueByVal(a)
        Console.WriteLine("the value of a before increment = " & a)

        Console.WriteLine()

        Console.WriteLine("Passing value byRef method")
        Console.WriteLine("the value of a before increment = " & a)
        incrementValueByRef(a)
        Console.WriteLine("the value of a before increment = " & a)
        Console.ReadKey()
    End Sub

    Function incrementValueByVal(ByVal a As Integer)
        a = a + 1
        Return a
    End Function

    Function incrementValueByRef(ByRef a As Integer)
        a = a + 1
        Return a
    End Function
End Module