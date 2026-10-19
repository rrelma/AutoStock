
Imports System.Drawing
Imports System.Windows.Forms

Public Class SweetAlert

    Public Shared Function Confirm(
        message As String,
        Optional titre As String = "Confirmation"
    ) As Boolean

        Return ShowAlert(
            titre,
            message,
            Color.FromArgb(243, 156, 18),
            "Confirmer",
            True
        )

    End Function

    Public Shared Sub Success(
        message As String,
        Optional titre As String = "Succès"
    )

        ShowAlert(
            titre,
            message,
            Color.FromArgb(40, 167, 69),
            "OK",
            False
        )

    End Sub

    Public Shared Sub ErrorMessage(
        message As String,
        Optional titre As String = "Erreur"
    )

        ShowAlert(
            titre,
            message,
            Color.FromArgb(220, 53, 69),
            "OK",
            False
        )

    End Sub

    Public Shared Sub Warning(
        message As String,
        Optional titre As String = "Attention"
    )

        ShowAlert(
            titre,
            message,
            Color.FromArgb(243, 156, 18),
            "OK",
            False
        )

    End Sub

    Private Shared Function ShowAlert(
        titre As String,
        message As String,
        couleur As Color,
        texteBouton As String,
        afficherAnnuler As Boolean
    ) As Boolean

        Using dialog As New Form()

            ' Fenêtre principale
            dialog.Text = titre
            dialog.StartPosition = FormStartPosition.CenterParent
            dialog.FormBorderStyle = FormBorderStyle.FixedDialog
            dialog.MaximizeBox = False
            dialog.MinimizeBox = False
            dialog.ShowInTaskbar = False
            dialog.BackColor = Color.White
            dialog.Font = New Font("Segoe UI", 10)
            dialog.ClientSize = New Size(440, 280)
            dialog.Padding = New Padding(0)

            ' Bandeau supérieur
            Dim pnlHeader As New Panel With {
                .BackColor = couleur,
                .Location = New Point(0, 0),
                .Size = New Size(440, 8)
            }

            ' Titre
            Dim lblTitre As New Label With {
                .Text = titre,
                .Font = New Font("Segoe UI", 15, FontStyle.Bold),
                .ForeColor = couleur,
                .TextAlign = ContentAlignment.MiddleCenter,
                .Location = New Point(20, 25),
                .Size = New Size(400, 35),
                .AutoEllipsis = True
            }

            ' Message
            Dim lblMessage As New Label With {
                .Text = message,
                .Font = New Font("Segoe UI", 10, FontStyle.Regular),
                .ForeColor = Color.FromArgb(65, 65, 65),
                .TextAlign = ContentAlignment.MiddleCenter,
                .Location = New Point(25, 70),
                .Size = New Size(390, 100),
                .AutoSize = False
            }

            ' Bouton principal
            Dim btnConfirm As New Button With {
                .Text = texteBouton,
                .Font = New Font("Segoe UI", 10, FontStyle.Bold),
                .BackColor = couleur,
                .ForeColor = Color.White,
                .FlatStyle = FlatStyle.Flat,
                .Size = New Size(125, 40),
                .Cursor = Cursors.Hand,
                .DialogResult = DialogResult.Yes
            }

            btnConfirm.FlatAppearance.BorderSize = 0

            ' Bouton Annuler pour les confirmations
            If afficherAnnuler Then

                btnConfirm.Location = New Point(85, 205)

                Dim btnCancel As New Button With {
                    .Text = "Annuler",
                    .Font = New Font("Segoe UI", 10),
                    .BackColor = Color.FromArgb(240, 240, 240),
                    .ForeColor = Color.FromArgb(55, 55, 55),
                    .FlatStyle = FlatStyle.Flat,
                    .Size = New Size(125, 40),
                    .Location = New Point(230, 205),
                    .Cursor = Cursors.Hand,
                    .DialogResult = DialogResult.No
                }

                btnCancel.FlatAppearance.BorderSize = 0

                dialog.Controls.Add(btnCancel)
                dialog.CancelButton = btnCancel

            Else

                btnConfirm.Location = New Point(157, 205)
                dialog.AcceptButton = btnConfirm

            End If

            ' Ajouter les contrôles
            dialog.Controls.Add(pnlHeader)
            dialog.Controls.Add(lblTitre)
            dialog.Controls.Add(lblMessage)
            dialog.Controls.Add(btnConfirm)

            Return dialog.ShowDialog() = DialogResult.Yes

        End Using

    End Function

End Class
