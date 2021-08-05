Imports System

Module Activity2

    Sub Main(args As String())

        FindAndFixFault()

        'Coding()

    End Sub


    ' 2.3.1 Find and Fix Fault
    Sub FindAndFixFault()

        'The loops below should print out the first 88 numbers in octal (base 8). It has a fault in the code somewhere, find and fix the problem.
        'Example of first few numbers in octal:
        '00, 01, 02, 03, 04, 05, 06, 07, 10, 11, 12, 13, 14, 15, 16, 17, 20, 21, 22, 23, 24, 25, 26, 27, 30, 31, 32...

        For base8 = 0 To 10
            For units = 0 To 7
                Console.WriteLine(base8 + units)
            Next units
        Next base8

        Console.WriteLine("End FindAndFixFault()")
        Console.ReadLine()

    End Sub



    '2.3.2 Coding
    Sub Coding()

        Dim cells As New Dictionary(Of String, Object)()

        For i As Integer = 1 To 10
            cells(String.Format("A:{0}", i)) = String.Format("Order #{0}", i)
            cells(String.Format("B:{0}", i)) = DateTime.Now.ToString
            cells(String.Format("C:{0}", i)) = i * 18
        Next

        For Each pair As KeyValuePair(Of String, Object) In cells
            Console.WriteLine(pair)
        Next


        ' 2.3.2.1 Dates
        ' code solution here 


        ' 2.3.2.2 Cell Currency
        ' code solution here 


        ' 2.3.2.3 Switch Cells
        ' code solution here 


        ' 2.3.2.4 Print Table
        ' code solution here 


        Console.WriteLine("End Coding()")
        Console.ReadLine()

    End Sub


End Module
