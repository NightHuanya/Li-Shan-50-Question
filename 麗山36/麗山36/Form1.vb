Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Dim a$ = ""
        Do Until EOF(1) = True
            a &= LineInput(1)
            If EOF(1) <> True Then a &= vbNewLine
        Loop
        Dim b$ = a.Replace("A", "").Replace("E", "").Replace("I", "").Replace("O", "").Replace("U", "").Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "")
        PrintLine(2, a & vbNewLine & vbNewLine & b)
    End Sub
End Class
