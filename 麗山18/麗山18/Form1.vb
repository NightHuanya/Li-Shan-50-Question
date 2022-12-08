Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Dim b$ = LineInput(1)
        Dim ans% = 0
        For k = 2 To Len(b)
            Dim c% = 0
            Dim d% = 0
            Select Case Mid(b, k - 1, 1)
                Case "M"
                    c = 1000
                Case "D"
                    c = 500
                Case "C"
                    c = 100
                Case "L"
                    c = 50
                Case "X"
                    c = 10
                Case "V"
                    c = 5
                Case "I"
                    c = 1
            End Select
            Select Case Mid(b, k, 1)
                Case "M"
                    d = 1000
                Case "D"
                    d = 500
                Case "C"
                    d = 100
                Case "L"
                    d = 50
                Case "X"
                    d = 10
                Case "V"
                    d = 5
                Case "I"
                    d = 1
            End Select
            If c < d Then ans -= c Else ans += c
            If k = Len(b) Then ans += d
        Next
        PrintLine(2, Trim(ans))
    End Sub
End Class
