Imports System

Module Test2
    Sub Main(args As String())
        Dim result As Integer = 0

        Console.WriteLine("Please enter some integers seperated by a space")

        Dim input = Console.ReadLine()
        Dim tokens As String() = input.Split(" ")

        'enter code here to find the median of the entered integers.
        'Example: If "50 2 60 3 4" is entered, the result should be 4.
        'If "87 20 34 50" is entered, the result should be 42 (add the two middle numbers and divide by 2)


        Console.WriteLine("Median is: " + result.ToString)

    End Sub
End Module
