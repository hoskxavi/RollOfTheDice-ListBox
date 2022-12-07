'Xavier Hoskins
'RCET 0265
'Fall 2022
'Roll of the Dice - List Box
'https://github.com/hoskxavi/RollOfTheDice-ListBox.git

Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class RollOfTheDiceForm

    'Sub will create the header when the form loads
    Private Sub RollOfTheDiceForm_Load() Handles Me.Load
        Dim rows As Integer = 1
        Dim columns As Integer = 11
        Dim header(columns + 1) As Integer
        Dim columnWidth As Integer = 9
        Dim columnSeparator As String = " |"
        Dim horizontalSeparator As String = "-"

        For i = 2 To UBound(header)
            header(i) = i
        Next

        DiceRollListBox.Items.Add(FormatArray(header, columnWidth, columnSeparator))
        DiceRollListBox.Items.Add(StrDup(76, horizontalSeparator))
    End Sub

    'Roll button will roll the dice 1000 times and list the numbers rolled
    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        Dim numberOfColumns As Integer = 11
        Dim rolls(numberOfColumns + 1) As Integer
        Dim header(numberOfColumns + 1) As Integer
        Dim columnWidth As Integer = 8
        Dim columnSeparator As String = " |"


        'roll the dice 1000 times
        For i = 0 To 1000
            rolls(DiceRoll()) += 1
        Next

        DiceRollListBox.Items.Add(FormatArray(rolls, columnWidth, columnSeparator))

    End Sub

    'Clear button will clear the rolled dice numbers
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DiceRollListBox.Items.Clear()
        RollOfTheDiceForm_Load()
    End Sub

    'Exit button simply exits the program
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        MsgBox("Have a just ok day.")
        Me.Close()
    End Sub



    'Random number generator to roll the dice and produce a value
    Function DiceRoll() As Integer
        Dim firstDie As Integer
        Dim secondDie As Integer
        Dim total As Integer

        Randomize()

        firstDie = CInt(Int(6 * Rnd() + 1))
        secondDie = CInt(Int(6 * Rnd() + 1))
        total = firstDie + secondDie

        Return total
    End Function


    'Function to format the array of dice rolls
    Function FormatArray(columns() As Integer, columnWidth As Integer, columnSeparator As String) As String
        Dim _row As String
        Dim temp As String
        For i = (LBound(columns) + 2) To UBound(columns)
            temp = columns(i) & columnSeparator
            temp = temp.PadLeft(columnWidth)
            _row &= temp
        Next
        Return _row
    End Function

End Class
