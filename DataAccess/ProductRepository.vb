
Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class ProductRepository

    ' Récupérer tous les produits
    Public Function GetAll() As List(Of Produit)

        Dim produits As New List(Of Produit)()

        Dim query As String =
            "SELECT Id, Nom, Prix, Quantite FROM dbo.Products ORDER BY Id"

        Using connection As SqlConnection =
            DbConnectionFactory.CreateConnection()

            Using command As New SqlCommand(query, connection)

                connection.Open()

                Using reader As SqlDataReader = command.ExecuteReader()

                    While reader.Read()

                        Dim produit As New Produit With {
                            .Id = reader.GetInt32(0),
                            .Nom = reader.GetString(1),
                            .Prix = reader.GetDecimal(2),
                            .Quantite = reader.GetInt32(3)
                        }

                        produits.Add(produit)

                    End While

                End Using
            End Using
        End Using

        Return produits

    End Function


    ' Ajouter un produit
    Public Sub Add(produit As Produit)

        Dim query As String =
            "INSERT INTO dbo.Products (Nom, Prix, Quantite) " &
            "VALUES (@Nom, @Prix, @Quantite)"

        Using connection As SqlConnection =
            DbConnectionFactory.CreateConnection()

            Using command As New SqlCommand(query, connection)

                command.Parameters.Add("@Nom", SqlDbType.NVarChar, 100).Value =
                    produit.Nom

                command.Parameters.Add("@Prix", SqlDbType.Decimal).Value =
                    produit.Prix

                command.Parameters("@Prix").Precision = 10
                command.Parameters("@Prix").Scale = 2

                command.Parameters.Add("@Quantite", SqlDbType.Int).Value =
                    produit.Quantite

                connection.Open()
                command.ExecuteNonQuery()

            End Using
        End Using

    End Sub


    ' Modifier un produit
    Public Sub Update(produit As Produit)

        Dim query As String =
            "UPDATE dbo.Products " &
            "SET Nom = @Nom, Prix = @Prix, Quantite = @Quantite " &
            "WHERE Id = @Id"

        Using connection As SqlConnection =
            DbConnectionFactory.CreateConnection()

            Using command As New SqlCommand(query, connection)

                command.Parameters.Add("@Id", SqlDbType.Int).Value =
                    produit.Id

                command.Parameters.Add("@Nom", SqlDbType.NVarChar, 100).Value =
                    produit.Nom

                command.Parameters.Add("@Prix", SqlDbType.Decimal).Value =
                    produit.Prix

                command.Parameters("@Prix").Precision = 10
                command.Parameters("@Prix").Scale = 2

                command.Parameters.Add("@Quantite", SqlDbType.Int).Value =
                    produit.Quantite

                connection.Open()
                command.ExecuteNonQuery()

            End Using
        End Using

    End Sub


    ' Supprimer un produit
    Public Sub Delete(id As Integer)

        Dim query As String =
            "DELETE FROM dbo.Products WHERE Id = @Id"

        Using connection As SqlConnection =
            DbConnectionFactory.CreateConnection()

            Using command As New SqlCommand(query, connection)

                command.Parameters.Add("@Id", SqlDbType.Int).Value = id

                connection.Open()
                command.ExecuteNonQuery()

            End Using
        End Using

    End Sub

End Class
