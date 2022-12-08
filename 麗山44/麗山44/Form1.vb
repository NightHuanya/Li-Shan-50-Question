Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Dim word As New List(Of String), MH As New List(Of Integer)
        Do Until EOF(1) = True
            Dim a$() = LineInput(1).Replace(",", "").Replace(".", "").Split({" "}, StringSplitOptions.RemoveEmptyEntries)
            For k = 0 To UBound(a)
                If word.Contains(a(k)) = False Then
                    word.Add(a(k)) : MH.Add(1)
                Else
                    MH(word.IndexOf(a(k))) += 1
                End If
            Next
        Loop
        For i = 0 To word.Count - 1
            For j = i To word.Count - 1
                If MH(i) < MH(j) Then
                    Dim x$ = word(i), y% = MH(i)
                    MH(i) = MH(j) : word(i) = word(j)
                    MH(j) = y : word(j) = x
                End If
            Next
        Next
        For i = 0 To word.Count - 1
            PrintLine(2, word(i) & " = " & MH(i))
        Next
    End Sub
End Class
