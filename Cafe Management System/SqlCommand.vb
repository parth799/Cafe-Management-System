Friend Class SqlCommand
    Private query As String
    Private con As Object

    Public Sub New(query As String, con As Object)
        Me.query = query
        Me.con = con
    End Sub

    Friend Sub ExecuteNonQuery()
        Throw New NotImplementedException()
    End Sub

    Friend Function Parameters() As Object
        Throw New NotImplementedException()
    End Function
End Class
