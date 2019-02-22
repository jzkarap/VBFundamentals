Imports System.Threading.Tasks

Module Module1

    Sub Main()
        Dim nums(499) As Integer
        For index = 0 To nums.Length - 1
            nums(index) = index
        Next

        For Each num In nums
            Console.WriteLine(num)
        Next

        'Splits up array, gives pieces to each processor, and writes out each num in nums to console window
        'Notice numbers not printed in order
        Parallel.ForEach(nums, Sub(num) Console.WriteLine(num))

        'Threads
        '   System.Threading
        '       Low level API for starting, stopping, and joining threads
        '       HERE BE DRAGONS -- dangerous, unpredictable, hard to debug
        '   System.Threading.Tasks
        '       High level API for concurrent and asynchronous programming
    End Sub

End Module
