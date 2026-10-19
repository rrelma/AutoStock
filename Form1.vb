
Imports System.Globalization
Imports System.Collections.Generic

Public Class Form1

    Private ReadOnly repository As New ProductRepository()

    Private Sub Form1_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        ViderChamps()
        ChargerProduits()

    End Sub

    ' Display a status message inside the page
    Private Sub AfficherMessage(
        message As String,
        Optional succes As Boolean = True
    )

        lblStatus.Text = message

        If succes Then
            lblStatus.ForeColor = Color.FromArgb(34, 139, 94)
        Else
            lblStatus.ForeColor = Color.Firebrick
        End If

    End Sub

    ' Load products from SQL Server
    Private Sub ChargerProduits()

        Try
            Dim produits As List(Of Produit) = repository.GetAll()

            dgvProduits.Rows.Clear()

            For Each p As Produit In produits
                dgvProduits.Rows.Add(
                    p.Id,
                    p.Nom,
                    p.Prix,
                    p.Quantite
                )
            Next

            dgvProduits.ClearSelection()

            AfficherMessage(
                produits.Count.ToString() & " spare parts loaded successfully.",
                True
            )

        Catch ex As Exception
            SweetAlert.ErrorMessage(
                "Unable to load spare parts." &
                Environment.NewLine & ex.Message,
                "Database error"
            )
            AfficherMessage("Unable to load spare parts.", False)
        End Try

    End Sub

    ' Validate form inputs and build a Produit object
    Private Function LireProduit(
        ByRef produit As Produit
    ) As Boolean

        Dim nom As String = txtNom.Text.Trim()
        Dim prix As Decimal
        Dim quantite As Integer

        If String.IsNullOrWhiteSpace(nom) Then
            SweetAlert.Warning(
                "Please enter a product name.",
                "Validation error"
            )
            txtNom.Focus()
            Return False
        End If

        If nom.Length > 100 Then
            SweetAlert.Warning(
                "The product name cannot exceed 100 characters.",
                "Validation error"
            )
            txtNom.Focus()
            Return False
        End If

        Dim prixTexte As String = txtPrix.Text.Trim()

        If Not Decimal.TryParse(
            prixTexte,
            NumberStyles.Number,
            CultureInfo.CurrentCulture,
            prix
        ) AndAlso Not Decimal.TryParse(
            prixTexte,
            NumberStyles.Number,
            CultureInfo.InvariantCulture,
            prix
        ) Then

            SweetAlert.Warning(
                "Please enter a valid price.",
                "Invalid price"
            )
            txtPrix.Focus()
            Return False
        End If

        If prix < 0 Then
            SweetAlert.Warning(
                "The price cannot be negative.",
                "Invalid price"
            )
            txtPrix.Focus()
            Return False
        End If

        If Not Integer.TryParse(txtQuantite.Text.Trim(), quantite) Then
            SweetAlert.Warning(
                "Please enter a valid whole-number quantity.",
                "Invalid quantity"
            )
            txtQuantite.Focus()
            Return False
        End If

        If quantite < 0 Then
            SweetAlert.Warning(
                "The quantity cannot be negative.",
                "Invalid quantity"
            )
            txtQuantite.Focus()
            Return False
        End If

        produit = New Produit With {
            .Nom = nom,
            .Prix = prix,
            .Quantite = quantite
        }

        Return True

    End Function

    ' Get the ID of the selected product
    Private Function ObtenirIdSelectionne(
        ByRef id As Integer
    ) As Boolean

        id = 0

        If dgvProduits.CurrentRow Is Nothing OrElse
           dgvProduits.CurrentRow.IsNewRow Then
            Return False
        End If

        Dim valeur As Object =
            dgvProduits.CurrentRow.Cells("colId").Value

        If valeur Is Nothing OrElse valeur Is DBNull.Value Then
            Return False
        End If

        Return Integer.TryParse(valeur.ToString(), id)

    End Function

    ' ADD PRODUCT
    Private Sub btnAjouter_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnAjouter.Click

        Dim produit As Produit = Nothing

        If Not LireProduit(produit) Then
            Return
        End If

        Try
            repository.Add(produit)

            ChargerProduits()
            ViderChamps()

            SweetAlert.Success(
                "The product has been added successfully.",
                "Product added"
            )

        Catch ex As Exception
            SweetAlert.ErrorMessage(
                "Unable to add the product." &
                Environment.NewLine & ex.Message,
                "Add failed"
            )
        End Try

    End Sub

    ' UPDATE PRODUCT
    Private Sub btnModifier_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnModifier.Click

        Dim id As Integer

        If Not ObtenirIdSelectionne(id) Then
            SweetAlert.Warning(
                "Please select a product to update.",
                "No product selected"
            )
            Return
        End If

        Dim produit As Produit = Nothing

        If Not LireProduit(produit) Then
            Return
        End If

        Dim confirmation As Boolean = SweetAlert.Confirm(
            "Do you want to save the changes to this product?",
            "Confirm update"
        )

        If Not confirmation Then
            Return
        End If

        produit.Id = id

        Try
            repository.Update(produit)

            ChargerProduits()
            ViderChamps()

            SweetAlert.Success(
                "The product has been updated successfully.",
                "Update successful"
            )

        Catch ex As Exception
            SweetAlert.ErrorMessage(
                "Unable to update the product." &
                Environment.NewLine & ex.Message,
                "Update failed"
            )
        End Try

    End Sub

    ' DELETE PRODUCT
    Private Sub btnSupprimer_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnSupprimer.Click

        Dim id As Integer

        If Not ObtenirIdSelectionne(id) Then
            SweetAlert.Warning(
                "Please select a product to delete.",
                "No product selected"
            )
            Return
        End If

        Dim confirmation As Boolean = SweetAlert.Confirm(
            "Are you sure you want to delete this product?" &
            Environment.NewLine &
            "This action cannot be undone.",
            "Confirm deletion"
        )

        If Not confirmation Then
            Return
        End If

        Try
            repository.Delete(id)

            ChargerProduits()
            ViderChamps()

            SweetAlert.Success(
                "The product has been deleted successfully.",
                "Product deleted"
            )

        Catch ex As Exception
            SweetAlert.ErrorMessage(
                "Unable to delete the product." &
                Environment.NewLine & ex.Message,
                "Delete failed"
            )
        End Try

    End Sub

    ' Select a product from the grid
    Private Sub dgvProduits_CellClick(
        sender As Object,
        e As DataGridViewCellEventArgs
    ) Handles dgvProduits.CellClick

        If e.RowIndex < 0 Then
            Return
        End If

        Dim ligne As DataGridViewRow =
            dgvProduits.Rows(e.RowIndex)

        txtNom.Text =
            Convert.ToString(ligne.Cells("colNom").Value)

        txtPrix.Text =
            Convert.ToString(ligne.Cells("colPrix").Value)

        txtQuantite.Text =
            Convert.ToString(ligne.Cells("colQuantite").Value)

        AfficherMessage(
            "Selected product ID: " &
            Convert.ToString(ligne.Cells("colId").Value),
            True
        )

    End Sub

    ' RESET FORM
    Private Sub btnReinitialiser_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnReinitialiser.Click

        ViderChamps()
        AfficherMessage("Form cleared.", True)

    End Sub

    Private Sub ViderChamps()

        txtNom.Clear()
        txtPrix.Clear()
        txtQuantite.Clear()

        If dgvProduits IsNot Nothing Then
            dgvProduits.ClearSelection()
        End If

        txtNom.Focus()

    End Sub

End Class
