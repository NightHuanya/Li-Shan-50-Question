Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Dim a$() = LineInput(1).Split(",")
        Dim b% = Val(a(0))
        For i = 1 To UBound(a)
            b = b * Val(a(i))
        Next
        PrintLine(2, b)
    End Sub
End Class