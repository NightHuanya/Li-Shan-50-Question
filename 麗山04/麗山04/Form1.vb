Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Dim a$ = LineInput(1)
        Dim ans% = 0
        For i = 1 To Len(a)
            ans += Val(Mid(a, i, 1))
        Next
        If ans Mod 9 = 0 Then
            PrintLine(2, "是")
        Else
            PrintLine(2, "不是")
        End If
    End Sub
End Class
