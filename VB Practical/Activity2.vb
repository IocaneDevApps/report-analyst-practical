Imports System

Module Activity2
    Sub Main(args As String())

        'The loops below should print out the first 88 numbers in octal (base 8). It has a fault in the code somewhere, find and fix the problem.
        'Example of first few numbers in octal:
        '00, 01, 02, 03, 04, 05, 06, 07, 10, 11, 12, 13, 14, 15, 16, 17, 20, 21, 22, 23, 24, 25, 26, 27, 30, 31, 32...

        For base8 = 0 To 10
            For units = 0 To 7
                Console.WriteLine(base8 + units)
            Next units
        Next base8

    End Sub
End Module
