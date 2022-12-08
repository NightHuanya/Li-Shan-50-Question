Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileOpen(1, "in1.txt", 1)
        FileOpen(2, "out.txt", 2)
        Dim a% = LineInput(1)
        Dim x As New List(Of Object)
        Dim y As New List(Of String)
        QQ(x, "", a, y)
        For k = 0 To x.Count - 1
            PrintLine(2, a & "=" & Join(x(k).ToArray(), "+"))
        Next
    End Sub
    Function QQ(ByVal x As List(Of Object), ByVal y$, ByVal a%, ByVal r As List(Of String))
        Dim o As New List(Of String)
        For k = 0 To r.Count - 1
            o.Add(r(k))
        Next
        o.Sort() : o.Reverse()
        If a = 0 Then
            For Each u In x
                If u.count = o.Count Then
                    For k = 0 To u.count - 1
                        If o(k) <> u(k) Then Exit For
                        If k = o.Count - 1 Then Exit Function
                    Next
                End If
            Next
            x.Add(o)
        Else
            For i = a To 1 Step -1
                o.Add(i)
                QQ(x, y & "+" & i, a - i, o)
                o.RemoveAt(o.Count - 1)
            Next
        End If
    End Function
End Class
