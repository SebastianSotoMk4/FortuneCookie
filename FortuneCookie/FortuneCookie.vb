'Sebastian Soto
'RCET0265
'Fall 2021
'BetterCalculator
'https://github.com/SebastianSotoMk4/FortuneCookie.git
Option Strict On
Option Explicit On
Option Compare Text
Module FortuneCookie

    Sub Main()
        Select Case RandomNumber()
            Case 1 To 34
                Console.WriteLine("You will be told of your well doings")
            Case 33 To 66
                Console.WriteLine("Rob is Cool")
            Case 67 To 100
                Console.WriteLine("You will have a good day on thursday")
            Case Else
                Console.WriteLine("if you are reading this it did work right")
        End Select
        Console.ReadLine()

    End Sub
    Function RandomNumber() As Integer
        Dim rndNum As Integer
        Randomize()
        rndNum = CInt(Rnd() * 50)
        Return rndNum
    End Function
End Module
