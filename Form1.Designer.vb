
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Friend WithEvents titreLabel As Label
    Friend WithEvents produit_label As Label
    Friend WithEvents prixLabel As Label
    Friend WithEvents quantiteLabel As Label

    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtPrix As TextBox
    Friend WithEvents txtQuantite As TextBox

    Friend WithEvents btnAjouter As Button
    Friend WithEvents btnModifier As Button
    Friend WithEvents btnSupprimer As Button
    Friend WithEvents btnReinitialiser As Button

    Friend WithEvents dgvProduits As DataGridView
    Friend WithEvents lblStatus As Label

    Private headerPanel As Panel
    Private editorPanel As Panel
    Private tablePanel As Panel
    Private sectionLabel As Label
    Private tableTitleLabel As Label

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

        Me.headerPanel = New Panel()
        Me.editorPanel = New Panel()
        Me.tablePanel = New Panel()

        Me.titreLabel = New Label()
        Me.sectionLabel = New Label()
        Me.tableTitleLabel = New Label()

        Me.produit_label = New Label()
        Me.prixLabel = New Label()
        Me.quantiteLabel = New Label()

        Me.txtNom = New TextBox()
        Me.txtPrix = New TextBox()
        Me.txtQuantite = New TextBox()

        Me.btnAjouter = New Button()
        Me.btnModifier = New Button()
        Me.btnSupprimer = New Button()
        Me.btnReinitialiser = New Button()

        Me.dgvProduits = New DataGridView()
        Me.lblStatus = New Label()

        CType(Me.dgvProduits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' Form
        Me.AutoScaleDimensions = New SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(1100, 760)
        Me.MinimumSize = New Size(950, 650)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.FromArgb(245, 247, 251)
        Me.Font = New Font("Segoe UI", 9.0!)
        Me.Text = "Product Management"

        ' Header
        Me.headerPanel.Dock = DockStyle.Top
        Me.headerPanel.Height = 105
        Me.headerPanel.BackColor = Color.FromArgb(24, 42, 75)

        Me.titreLabel.Text = "Product Management"
        Me.titreLabel.Font = New Font(
            "Segoe UI", 25.0!, FontStyle.Bold)
        Me.titreLabel.ForeColor = Color.White
        Me.titreLabel.AutoSize = True
        Me.titreLabel.Location = New Point(30, 20)

        Me.headerPanel.Controls.Add(Me.titreLabel)

        ' Editor panel
        Me.editorPanel.Location = New Point(25, 125)
        Me.editorPanel.Size = New Size(1050, 225)
        Me.editorPanel.Anchor =
            AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Me.editorPanel.BackColor = Color.White

        Me.sectionLabel.Text = "Add or edit a product"
        Me.sectionLabel.Font = New Font(
            "Segoe UI", 14.0!, FontStyle.Bold)
        Me.sectionLabel.ForeColor = Color.FromArgb(31, 41, 55)
        Me.sectionLabel.AutoSize = True
        Me.sectionLabel.Location = New Point(25, 18)

        Me.produit_label.Text = "Product name"
        Me.produit_label.Location = New Point(25, 60)
        Me.produit_label.AutoSize = True

        Me.prixLabel.Text = "Price (DH)"
        Me.prixLabel.Location = New Point(440, 60)
        Me.prixLabel.AutoSize = True

        Me.quantiteLabel.Text = "Quantity"
        Me.quantiteLabel.Location = New Point(695, 60)
        Me.quantiteLabel.AutoSize = True

        Me.txtNom.Location = New Point(25, 85)
        Me.txtNom.Size = New Size(390, 30)
        Me.txtNom.Font = New Font("Segoe UI", 10.0!)
        Me.txtNom.Anchor = AnchorStyles.Top Or AnchorStyles.Left

        Me.txtPrix.Location = New Point(440, 85)
        Me.txtPrix.Size = New Size(230, 30)
        Me.txtPrix.Font = New Font("Segoe UI", 10.0!)

        Me.txtQuantite.Location = New Point(695, 85)
        Me.txtQuantite.Size = New Size(160, 30)
        Me.txtQuantite.Font = New Font("Segoe UI", 10.0!)

        ' Add button
        Me.btnAjouter.Text = "Add product"
        Me.btnAjouter.Location = New Point(25, 145)
        Me.btnAjouter.Size = New Size(150, 42)
        Me.btnAjouter.BackColor = Color.FromArgb(34, 139, 94)
        Me.btnAjouter.ForeColor = Color.White
        Me.btnAjouter.FlatStyle = FlatStyle.Flat
        Me.btnAjouter.FlatAppearance.BorderSize = 0
        Me.btnAjouter.Cursor = Cursors.Hand

        ' Modify button
        Me.btnModifier.Text = "Update"
        Me.btnModifier.Location = New Point(190, 145)
        Me.btnModifier.Size = New Size(135, 42)
        Me.btnModifier.BackColor = Color.FromArgb(55, 110, 220)
        Me.btnModifier.ForeColor = Color.White
        Me.btnModifier.FlatStyle = FlatStyle.Flat
        Me.btnModifier.FlatAppearance.BorderSize = 0
        Me.btnModifier.Cursor = Cursors.Hand

        ' Delete button
        Me.btnSupprimer.Text = "Delete"
        Me.btnSupprimer.Location = New Point(340, 145)
        Me.btnSupprimer.Size = New Size(135, 42)
        Me.btnSupprimer.BackColor = Color.FromArgb(220, 53, 69)
        Me.btnSupprimer.ForeColor = Color.White
        Me.btnSupprimer.FlatStyle = FlatStyle.Flat
        Me.btnSupprimer.FlatAppearance.BorderSize = 0
        Me.btnSupprimer.Cursor = Cursors.Hand

        ' Reset button
        Me.btnReinitialiser.Text = "Reset"
        Me.btnReinitialiser.Location = New Point(490, 145)
        Me.btnReinitialiser.Size = New Size(135, 42)
        Me.btnReinitialiser.BackColor = Color.FromArgb(107, 114, 128)
        Me.btnReinitialiser.ForeColor = Color.White
        Me.btnReinitialiser.FlatStyle = FlatStyle.Flat
        Me.btnReinitialiser.FlatAppearance.BorderSize = 0
        Me.btnReinitialiser.Cursor = Cursors.Hand

        Me.editorPanel.Controls.Add(Me.sectionLabel)
        Me.editorPanel.Controls.Add(Me.produit_label)
        Me.editorPanel.Controls.Add(Me.prixLabel)
        Me.editorPanel.Controls.Add(Me.quantiteLabel)
        Me.editorPanel.Controls.Add(Me.txtNom)
        Me.editorPanel.Controls.Add(Me.txtPrix)
        Me.editorPanel.Controls.Add(Me.txtQuantite)
        Me.editorPanel.Controls.Add(Me.btnAjouter)
        Me.editorPanel.Controls.Add(Me.btnModifier)
        Me.editorPanel.Controls.Add(Me.btnSupprimer)
        Me.editorPanel.Controls.Add(Me.btnReinitialiser)

        ' Status message
        Me.lblStatus.Location = New Point(30, 358)
        Me.lblStatus.Size = New Size(1040, 30)
        Me.lblStatus.Anchor =
            AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Me.lblStatus.Font = New Font("Segoe UI", 9.5!)
        Me.lblStatus.ForeColor = Color.FromArgb(55, 110, 220)
        Me.lblStatus.TextAlign = ContentAlignment.MiddleLeft

        ' Table panel
        Me.tablePanel.Location = New Point(25, 395)
        Me.tablePanel.Size = New Size(1050, 335)
        Me.tablePanel.Anchor =
            AnchorStyles.Top Or AnchorStyles.Bottom Or
            AnchorStyles.Left Or AnchorStyles.Right
        Me.tablePanel.BackColor = Color.White

        Me.tableTitleLabel.Text = "Product list"
        Me.tableTitleLabel.Font = New Font(
            "Segoe UI", 14.0!, FontStyle.Bold)
        Me.tableTitleLabel.ForeColor = Color.FromArgb(31, 41, 55)
        Me.tableTitleLabel.AutoSize = True
        Me.tableTitleLabel.Location = New Point(20, 15)

        ' DataGridView
        Me.dgvProduits.Location = New Point(20, 55)
        Me.dgvProduits.Size = New Size(1010, 260)
        Me.dgvProduits.Anchor =
            AnchorStyles.Top Or AnchorStyles.Bottom Or
            AnchorStyles.Left Or AnchorStyles.Right

        Me.dgvProduits.AllowUserToAddRows = False
        Me.dgvProduits.AllowUserToDeleteRows = False
        Me.dgvProduits.AllowUserToResizeRows = False
        Me.dgvProduits.AutoGenerateColumns = False
        Me.dgvProduits.ReadOnly = True
        Me.dgvProduits.MultiSelect = False
        Me.dgvProduits.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect
        Me.dgvProduits.RowHeadersVisible = False
        Me.dgvProduits.BackgroundColor = Color.White
        Me.dgvProduits.BorderStyle = BorderStyle.None
        Me.dgvProduits.CellBorderStyle =
            DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvProduits.GridColor = Color.FromArgb(230, 234, 240)
        Me.dgvProduits.EnableHeadersVisualStyles = False
        Me.dgvProduits.ColumnHeadersHeight = 42
        Me.dgvProduits.RowTemplate.Height = 35
        Me.dgvProduits.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill

        Me.dgvProduits.ColumnHeadersDefaultCellStyle.BackColor =
            Color.FromArgb(24, 42, 75)
        Me.dgvProduits.ColumnHeadersDefaultCellStyle.ForeColor =
            Color.White
        Me.dgvProduits.ColumnHeadersDefaultCellStyle.Font =
            New Font("Segoe UI", 10.0!, FontStyle.Bold)
        Me.dgvProduits.ColumnHeadersDefaultCellStyle.SelectionBackColor =
            Color.FromArgb(24, 42, 75)

        Me.dgvProduits.DefaultCellStyle.Font =
            New Font("Segoe UI", 10.0!)
        Me.dgvProduits.DefaultCellStyle.ForeColor =
            Color.FromArgb(31, 41, 55)
        Me.dgvProduits.DefaultCellStyle.SelectionBackColor =
            Color.FromArgb(219, 234, 254)
        Me.dgvProduits.DefaultCellStyle.SelectionForeColor =
            Color.FromArgb(30, 41, 59)
        Me.dgvProduits.AlternatingRowsDefaultCellStyle.BackColor =
            Color.FromArgb(248, 250, 252)

        ' Columns
        Dim colId As New DataGridViewTextBoxColumn()
        colId.Name = "colId"
        colId.HeaderText = "ID"
        colId.FillWeight = 45
        colId.ReadOnly = True

        Dim colNom As New DataGridViewTextBoxColumn()
        colNom.Name = "colNom"
        colNom.HeaderText = "Product name"
        colNom.FillWeight = 200
        colNom.ReadOnly = True

        Dim colPrix As New DataGridViewTextBoxColumn()
        colPrix.Name = "colPrix"
        colPrix.HeaderText = "Price (DH)"
        colPrix.FillWeight = 100
        colPrix.ReadOnly = True

        Dim colQuantite As New DataGridViewTextBoxColumn()
        colQuantite.Name = "colQuantite"
        colQuantite.HeaderText = "Quantity"
        colQuantite.FillWeight = 90
        colQuantite.ReadOnly = True

        Me.dgvProduits.Columns.AddRange(
            New DataGridViewColumn() {
                colId, colNom, colPrix, colQuantite
            })

        Me.tablePanel.Controls.Add(Me.tableTitleLabel)
        Me.tablePanel.Controls.Add(Me.dgvProduits)

        ' Add page controls
        Me.Controls.Add(Me.headerPanel)
        Me.Controls.Add(Me.editorPanel)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.tablePanel)

        CType(Me.dgvProduits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

End Class
