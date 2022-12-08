Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Dim a% = LineInput(1)
        Dim ans$ = ""
        Do Until a = 0
            If a >= 1000 Then
                a -= 1000
                ans &= "M"
            ElseIf a >= 900 Then
                a -= 900
                ans &= "CM"
            ElseIf a >= 500 Then
                a -= 500
                ans &= "D"
            ElseIf a >= 400 Then
                a -= 400
                ans &= "CD"
            ElseIf a >= 100 Then
                a -= 100
                ans &= "C"
            ElseIf a >= 90 Then
                a -= 90
                ans &= "XC"
            ElseIf a >= 50 Then
                a -= 50
                ans &= "L"
            ElseIf a >= 40 Then
                a -= 40
                ans &= "XL"
            ElseIf a >= 10 Then
                a -= 10
                ans &= "X"
            ElseIf a >= 9 Then
                a -= 9
                ans &= "IX"
            ElseIf a >= 5 Then
                a -= 5
                ans &= "V"
            ElseIf a >= 4 Then
                a -= 4
                ans &= "IV"
            ElseIf a >= 1 Then
                a -= 1
                ans &= "I"
            End If
        Loop
        PrintLine(2, ans)
    End Sub
End Class
