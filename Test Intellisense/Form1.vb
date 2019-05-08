Public Class Form1
    Public Property ComboCustomerGroup As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Es ist " & Now.ToShortTimeString & " und Zeit für eine Pause")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Daniel trinnkt ein Bier!")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Function GetCustomerGroupNameAndCode() As DataTable
        Throw New NotImplementedException()
    End Function
End Class
