
Imports Microsoft.Data.SqlClient

Public Class LoginForm

    Private ReadOnly userRepository As New UserRepository()

    Private Sub LoginForm_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        lblMessage.Text = ""
        txtUsername.Focus()

    End Sub

    Private Sub btnLogin_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnLogin.Click

        lblMessage.Text = ""

        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text

        ' Validate inputs
        If String.IsNullOrWhiteSpace(username) AndAlso
           String.IsNullOrWhiteSpace(password) Then

            AfficherErreur(
                "Please enter your username and password.")
            txtUsername.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(username) Then
            AfficherErreur("Please enter your username.")
            txtUsername.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(password) Then
            AfficherErreur("Please enter your password.")
            txtPassword.Focus()
            Return
        End If

        Try
            btnLogin.Enabled = False
            btnLogin.Text = "Signing in..."
            Me.UseWaitCursor = True

            Dim isValid As Boolean =
                userRepository.VerifyCredentials(username, password)

            If isValid Then

                Dim mainForm As New Form1()

                AddHandler mainForm.FormClosed,
                    Sub(senderForm As Object, args As FormClosedEventArgs)
                        Me.Close()
                    End Sub

                Me.Hide()
                mainForm.Show()

            Else

                AfficherErreur("Invalid username or password.")
                txtPassword.Clear()
                txtPassword.Focus()

            End If

        Catch ex As SqlException

            MessageBox.Show(
                "Unable to connect to the database." &
                Environment.NewLine &
                "Please check your database configuration.",
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        Catch ex As Exception

            MessageBox.Show(
                "An unexpected error occurred: " & ex.Message,
                "Login Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        Finally

            Me.UseWaitCursor = False
            btnLogin.Enabled = True
            btnLogin.Text = "Sign in"

        End Try

    End Sub

    Private Sub AfficherErreur(message As String)

        lblMessage.ForeColor = Color.Firebrick
        lblMessage.Text = message

    End Sub

End Class
