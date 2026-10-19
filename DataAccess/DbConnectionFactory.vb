Imports Microsoft.Data.SqlClient

Public Class DbConnectionFactory

    Private Const ConnectionString As String =
        "Server=.;" &
        "Database=GestionProduits;" &
        "Integrated Security=True;" &
        "TrustServerCertificate=True;"

    Public Shared Function CreateConnection() As SqlConnection
        Return New SqlConnection(ConnectionString)
    End Function

End Class