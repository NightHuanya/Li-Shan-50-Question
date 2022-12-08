Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Dim a$ = LineInput(1)
        If InStr(a, ".") = 0 Then
            a = a.Replace("年利率", "").Replace("元", "").Replace("％", "").Replace("天", "")
            Dim b$() = a.Split("，")
            PrintLine(2, Format(Val(b(0)) * (1 + Val(b(1)) * 0.01 / 365) ^ Val(b(2)), ".000") & "元")
        Else
            a = a.Replace("年利率", "").Replace("元", "").Replace("％", "").Replace("天", "")
            Dim b$() = a.Split("，")
            PrintLine(2, CInt(Val(b(0)) / (1 + Val(b(1)) * 0.01 / 365) ^ Val(b(2))) & "元")
        End If
    End Sub
End Class
