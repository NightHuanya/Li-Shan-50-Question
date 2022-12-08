Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Dim a%() = {10, 11, 12, 13, 14, 15, 16, 17, 34, 18, 19, 20, 21, 22, 35, 23, 24, 25, 26, 27, 28, 29, 32, 30, 31, 33}
        Dim b$(25)
        For i = 0 To UBound(a)
            b(i) = Chr(65 + i)
        Next
        Dim c$ = LineInput(1)
        Dim d1$ = a(Array.IndexOf(b, Mid(c, 1, 1)))
        Dim d2$ = StrReverse(Mid(c, 2, Len(c) - 2))
        Dim d3$ = Mid(c, Len(c), 1)
        Dim che% = 0
        For i = 1 To 8
            che += Val(Mid(d2, i, 1)) * i
        Next
        che += Val(Mid(d1, 2, 1)) * 9 + Val(Mid(d1, 1, 1))
        che = 10 - che Mod 10
        If che = Val(d3) Then
            PrintLine(2, "是")
        Else
            PrintLine(2, "否")
        End If
    End Sub
End Class
