
Imports Microsoft.Data.SqlClient

Public Class UserRepository

    Public Function VerifyCredentials(username As String,
                                      password As String) As Boolean

        Using connection As SqlConnection = DbConnectionFactory.CreateConnection()

            connection.Open()

            Dim query As String =
                "SELECT Password FROM dbo.Users WHERE Username = @Username"

            Using command As New SqlCommand(query, connection)

                command.Parameters.Add("@Username", SqlDbType.NVarChar, 50).Value =
                    username

                Dim result As Object = command.ExecuteScalar()

                ' Aucun utilisateur trouvé
                If result Is Nothing OrElse result Is DBNull.Value Then
                    Return False
                End If

                Dim storedPassword As String = Convert.ToString(result)

                ' Vérifier le mot de passe avec le hash stocké
                Return password = storedPassword

            End Using
        End Using

    End Function

End Class
