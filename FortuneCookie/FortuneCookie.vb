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
            Case 1 To 10
                Console.WriteLine("Corndogs are just breakfast With extra steps.")
            Case 11 To 20
                Console.WriteLine("Hooting is the gateway drug to hollering.")
            Case 21 To 30
                Console.WriteLine("You will never reach the bannana if you do not have the courage to climb.")
            Case 31 To 40
                Console.WriteLine("Joys are often the shadows, cast by shadows.")
            Case 41 To 50
                Console.WriteLine("Everyone agrees. You are the best.")
            Case 51 To 60
                Console.WriteLine(" You will be told of your well doings.")
            Case 61 To 70
                Console.WriteLine("Anything Is possible With a willing heart.")
            Case 71 To 80
                Console.WriteLine("Never do anything halfway.")
            Case 81 To 90
                Console.WriteLine("Ignore previous cookie.")
            Case 91 To 100
                Console.WriteLine("If milk can spoil in the fridge why does'nt it spoil in the cow")
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
