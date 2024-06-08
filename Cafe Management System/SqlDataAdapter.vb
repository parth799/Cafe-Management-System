Friend Class SqlDataAdapter
    Private cmd As SqlCommand

    Public Sub New(cmd As SqlCommand)
        Me.cmd = cmd
    End Sub

    Friend Sub Fill(tbl As DataTable)
        Throw New NotImplementedException()
    End Sub
End Class
