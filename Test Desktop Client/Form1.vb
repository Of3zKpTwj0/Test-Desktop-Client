Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#If DEBUG Then
        Debug.WriteLine("Hello world!")
#ElseIf RELEASE Then
        Console.WriteLine("Hello world!")     
#End If
    End Sub

End Class
