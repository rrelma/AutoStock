
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblMessage As Label

    Private mainLayout As TableLayoutPanel
    Private leftPanel As Panel
    Private rightPanel As Panel
    Private brandingPanel As Panel
    Private rightLayout As TableLayoutPanel
    Private loginPanel As Panel

    Private lblLogo As Label
    Private lblBrandTitle As Label
    Private lblBrandDescription As Label
    Private lblCopyright As Label
    Private lblDescription As Label
    Private lblFooter As Label

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()

        Me.components = New System.ComponentModel.Container()

        Me.mainLayout = New TableLayoutPanel()
        Me.leftPanel = New Panel()
        Me.rightPanel = New Panel()
        Me.brandingPanel = New Panel()
        Me.rightLayout = New TableLayoutPanel()
        Me.loginPanel = New Panel()

        Me.lblLogo = New Label()
        Me.lblBrandTitle = New Label()
        Me.lblBrandDescription = New Label()
        Me.lblCopyright = New Label()

        Me.lblTitle = New Label()
        Me.lblDescription = New Label()
        Me.lblUsername = New Label()
        Me.txtUsername = New TextBox()
        Me.lblPassword = New Label()
        Me.txtPassword = New TextBox()
        Me.btnLogin = New Button()
        Me.lblMessage = New Label()
        Me.lblFooter = New Label()

        Me.SuspendLayout()

        ' Main layout
        Me.mainLayout.Dock = DockStyle.Fill
        Me.mainLayout.ColumnCount = 2
        Me.mainLayout.RowCount = 1
        Me.mainLayout.Margin = New Padding(0)
        Me.mainLayout.Padding = New Padding(0)

        Me.mainLayout.ColumnStyles.Add(
            New ColumnStyle(SizeType.Percent, 42.0!))
        Me.mainLayout.ColumnStyles.Add(
            New ColumnStyle(SizeType.Percent, 58.0!))
        Me.mainLayout.RowStyles.Add(
            New RowStyle(SizeType.Percent, 100.0!))

        ' Left panel
        Me.leftPanel.Dock = DockStyle.Fill
        Me.leftPanel.BackColor = Color.FromArgb(24, 42, 75)
        Me.leftPanel.Padding = New Padding(45, 0, 25, 0)

        Me.brandingPanel.Dock = DockStyle.Fill
        Me.brandingPanel.BackColor = Color.FromArgb(24, 42, 75)

        ' Logo
        Me.lblLogo.Text = "AS"
        Me.lblLogo.Font = New Font("Segoe UI", 22.0!, FontStyle.Bold)
        Me.lblLogo.ForeColor = Color.White
        Me.lblLogo.BackColor = Color.FromArgb(55, 110, 220)
        Me.lblLogo.TextAlign = ContentAlignment.MiddleCenter
        Me.lblLogo.Size = New Size(75, 75)
        Me.lblLogo.Location = New Point(0, 60)

        ' Branding title
        Me.lblBrandTitle.Text = "AutoStock"
        Me.lblBrandTitle.Font = New Font(
            "Segoe UI", 27.0!, FontStyle.Bold)
        Me.lblBrandTitle.ForeColor = Color.White
        Me.lblBrandTitle.AutoSize = True
        Me.lblBrandTitle.Location = New Point(0, 175)

        ' Branding description
        Me.lblBrandDescription.Text =
            "Manage automotive products and stock" &
            Environment.NewLine &
            "simply and efficiently with AutoStock."


        Me.lblBrandDescription.Font = New Font("Segoe UI", 12.0!)
        Me.lblBrandDescription.ForeColor =
            Color.FromArgb(210, 220, 238)
        Me.lblBrandDescription.AutoSize = True
        Me.lblBrandDescription.Location = New Point(3, 240)

        ' Copyright
        Me.lblCopyright.Text = "© 2026 All rights reserved"
        Me.lblCopyright.Font = New Font("Segoe UI", 9.0!)
        Me.lblCopyright.ForeColor = Color.FromArgb(190, 202, 222)
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Dock = DockStyle.Bottom
        Me.lblCopyright.Padding = New Padding(0, 0, 0, 20)

        Me.brandingPanel.Controls.Add(Me.lblLogo)
        Me.brandingPanel.Controls.Add(Me.lblBrandTitle)
        Me.brandingPanel.Controls.Add(Me.lblBrandDescription)
        Me.brandingPanel.Controls.Add(Me.lblCopyright)

        Me.leftPanel.Controls.Add(Me.brandingPanel)

        ' Right panel
        Me.rightPanel.Dock = DockStyle.Fill
        Me.rightPanel.BackColor = Color.White
        Me.rightPanel.Padding = New Padding(25)

        ' Centering layout
        Me.rightLayout.Dock = DockStyle.Fill
        Me.rightLayout.ColumnCount = 1
        Me.rightLayout.RowCount = 1
        Me.rightLayout.Margin = New Padding(0)
        Me.rightLayout.Padding = New Padding(0)

        Me.rightLayout.ColumnStyles.Add(
            New ColumnStyle(SizeType.Percent, 100.0!))
        Me.rightLayout.RowStyles.Add(
            New RowStyle(SizeType.Percent, 100.0!))

        ' Login panel
        Me.loginPanel.Dock = DockStyle.None
        Me.loginPanel.Size = New Size(420, 450)
        Me.loginPanel.Anchor = AnchorStyles.None
        Me.loginPanel.BackColor = Color.White
        Me.loginPanel.Margin = New Padding(0)
        Me.loginPanel.Visible = True

        ' Title
        Me.lblTitle.Text = "Sign in"
        Me.lblTitle.Font = New Font(
            "Segoe UI", 27.0!, FontStyle.Bold)
        Me.lblTitle.ForeColor = Color.FromArgb(30, 41, 59)
        Me.lblTitle.Location = New Point(10, 5)
        Me.lblTitle.AutoSize = True

        ' Description
        Me.lblDescription.Text =
            "Enter your credentials to continue."
        Me.lblDescription.Font = New Font("Segoe UI", 10.0!)
        Me.lblDescription.ForeColor =
            Color.FromArgb(110, 120, 135)
        Me.lblDescription.Location = New Point(12, 57)
        Me.lblDescription.AutoSize = True

        ' Username label
        Me.lblUsername.Text = "Username"
        Me.lblUsername.Font = New Font(
            "Segoe UI", 10.0!, FontStyle.Bold)
        Me.lblUsername.Location = New Point(10, 115)
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Visible = True

        ' Username input
        Me.txtUsername.Font = New Font("Segoe UI", 11.0!)
        Me.txtUsername.Location = New Point(10, 142)
        Me.txtUsername.Size = New Size(400, 35)
        Me.txtUsername.Anchor =
            AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Me.txtUsername.TabIndex = 0
        Me.txtUsername.Visible = True

        ' Password label
        Me.lblPassword.Text = "Password"
        Me.lblPassword.Font = New Font(
            "Segoe UI", 10.0!, FontStyle.Bold)
        Me.lblPassword.Location = New Point(10, 195)
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Visible = True

        ' Password input
        Me.txtPassword.Font = New Font("Segoe UI", 11.0!)
        Me.txtPassword.Location = New Point(10, 222)
        Me.txtPassword.Size = New Size(400, 35)
        Me.txtPassword.UseSystemPasswordChar = True
        Me.txtPassword.Anchor =
            AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.Visible = True

        ' Login button
        Me.btnLogin.Text = "Sign in"
        Me.btnLogin.Font = New Font(
            "Segoe UI", 11.0!, FontStyle.Bold)
        Me.btnLogin.BackColor = Color.FromArgb(55, 110, 220)
        Me.btnLogin.ForeColor = Color.White
        Me.btnLogin.FlatStyle = FlatStyle.Flat
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.Location = New Point(10, 280)
        Me.btnLogin.Size = New Size(400, 45)
        Me.btnLogin.Cursor = Cursors.Hand
        Me.btnLogin.UseVisualStyleBackColor = False
        Me.btnLogin.Anchor =
            AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Visible = True

        ' Status message
        Me.lblMessage.AutoSize = False
        Me.lblMessage.Font = New Font("Segoe UI", 9.0!)
        Me.lblMessage.ForeColor = Color.Firebrick
        Me.lblMessage.Location = New Point(10, 335)
        Me.lblMessage.Size = New Size(400, 40)
        Me.lblMessage.Text = ""
        Me.lblMessage.TextAlign = ContentAlignment.MiddleLeft
        Me.lblMessage.Anchor =
            AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right

        ' Footer
        Me.lblFooter.Text = "Secure access to your account"
        Me.lblFooter.Font = New Font("Segoe UI", 9.0!)
        Me.lblFooter.ForeColor = Color.FromArgb(120, 130, 145)
        Me.lblFooter.AutoSize = True
        Me.lblFooter.Location = New Point(10, 395)

        ' Add controls to login panel
        Me.loginPanel.Controls.Add(Me.lblTitle)
        Me.loginPanel.Controls.Add(Me.lblDescription)
        Me.loginPanel.Controls.Add(Me.lblUsername)
        Me.loginPanel.Controls.Add(Me.txtUsername)
        Me.loginPanel.Controls.Add(Me.lblPassword)
        Me.loginPanel.Controls.Add(Me.txtPassword)
        Me.loginPanel.Controls.Add(Me.btnLogin)
        Me.loginPanel.Controls.Add(Me.lblMessage)
        Me.loginPanel.Controls.Add(Me.lblFooter)

        ' Ensure inputs are visible above other controls
        Me.txtUsername.BringToFront()
        Me.txtPassword.BringToFront()

        ' Add login panel to centering layout
        Me.rightLayout.Controls.Add(Me.loginPanel, 0, 0)
        Me.rightPanel.Controls.Add(Me.rightLayout)

        Me.mainLayout.Controls.Add(Me.leftPanel, 0, 0)
        Me.mainLayout.Controls.Add(Me.rightPanel, 1, 0)

        ' Form settings
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.White
        Me.ClientSize = New Size(1200, 700)
        Me.MinimumSize = New Size(950, 600)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Font = New Font("Segoe UI", 9.0!)
        Me.Name = "LoginForm"
        Me.Text = "AutoStock - Sign In"

        Me.Controls.Add(Me.mainLayout)

        Me.ResumeLayout(False)

    End Sub

End Class
