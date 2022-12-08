Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Dim a$() = LineInput(1).Split("，")
        Dim b$ = Mid(a(1), 4, Len(a(1)) - 4)
        Dim c$() = b.Split(",")
        Dim ans$ = ""
        Dim d As New List(Of String)
        QQ(c, d, "", 0)
        Dim g$ = ""
        Dim o% = 3
        Do Until o = (UBound(c) + 1) * 2 + 1
            For k = 0 To d.Count - 1
                If Len(d(k)) = o Then g &= d(k) & ","
            Next
            o += 2
        Loop
        g &= d(UBound(c))
        g = "{}," & g
        PrintLine(2, g)
    End Sub
    Function QQ(ByVal x$(), ByVal y As List(Of String), ByVal ans$, ByVal che%)
        For i = che To UBound(x)
            If InStr(ans, x(i)) = 0 Then
                If y.Contains("{" & (ans & "," & x(i)).Trim(",") & "}") = False Then
                    y.Add("{" & (ans & "," & x(i)).Trim(",") & "}")
                    QQ(x, y, (ans & "," & x(i)).Trim(","), i + 1)
                End If
            End If
        Next
    End Function
End Class
