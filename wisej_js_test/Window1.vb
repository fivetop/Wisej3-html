Imports Wisej.Base
Imports Wisej.Web

Public Class Window1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Call("show();", "")
    End Sub
End Class
