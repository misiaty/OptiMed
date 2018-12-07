<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZamknijToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ssBar = New System.Windows.Forms.StatusStrip()
        Me.slUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.dgView = New System.Windows.Forms.DataGridView()
        Me.tsNewMsg = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mnuAdmin = New System.Windows.Forms.ToolStripMenuItem()
        Me.LekarzeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaLekarzyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DodajNowegoLekarzaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.ssBar.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem, Me.mnuAdmin})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1184, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZamknijToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(93, 29)
        Me.ProgramToolStripMenuItem.Text = "&Program"
        '
        'ZamknijToolStripMenuItem
        '
        Me.ZamknijToolStripMenuItem.Name = "ZamknijToolStripMenuItem"
        Me.ZamknijToolStripMenuItem.Size = New System.Drawing.Size(158, 30)
        Me.ZamknijToolStripMenuItem.Text = "&Zamknij"
        '
        'ssBar
        '
        Me.ssBar.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ssBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slUser, Me.tsNewMsg})
        Me.ssBar.Location = New System.Drawing.Point(0, 420)
        Me.ssBar.Name = "ssBar"
        Me.ssBar.Size = New System.Drawing.Size(1184, 30)
        Me.ssBar.TabIndex = 1
        Me.ssBar.Text = "StatusStrip1"
        '
        'slUser
        '
        Me.slUser.Name = "slUser"
        Me.slUser.Size = New System.Drawing.Size(180, 25)
        Me.slUser.Text = "ToolStripStatusLabel1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton4, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 33)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1184, 32)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(137, 29)
        Me.ToolStripButton1.Text = "Lista pacjentów"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(62, 29)
        Me.ToolStripButton2.Text = "Grafik"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(82, 29)
        Me.ToolStripButton4.Text = "Wyloguj"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(67, 29)
        Me.ToolStripButton3.Text = "Poczta"
        '
        'dgView
        '
        Me.dgView.AllowUserToAddRows = False
        Me.dgView.AllowUserToDeleteRows = False
        Me.dgView.AllowUserToOrderColumns = True
        Me.dgView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgView.Location = New System.Drawing.Point(0, 65)
        Me.dgView.Name = "dgView"
        Me.dgView.ReadOnly = True
        Me.dgView.RowTemplate.Height = 28
        Me.dgView.Size = New System.Drawing.Size(1184, 355)
        Me.dgView.TabIndex = 3
        '
        'tsNewMsg
        '
        Me.tsNewMsg.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsNewMsg.ForeColor = System.Drawing.Color.Red
        Me.tsNewMsg.Name = "tsNewMsg"
        Me.tsNewMsg.Size = New System.Drawing.Size(253, 25)
        Me.tsNewMsg.Text = "MASZ NOWĄ WIADOMOŚĆ!"
        Me.tsNewMsg.Visible = False
        '
        'mnuAdmin
        '
        Me.mnuAdmin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LekarzeToolStripMenuItem})
        Me.mnuAdmin.Name = "mnuAdmin"
        Me.mnuAdmin.Size = New System.Drawing.Size(131, 29)
        Me.mnuAdmin.Text = "&Administracja"
        '
        'LekarzeToolStripMenuItem
        '
        Me.LekarzeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaLekarzyToolStripMenuItem, Me.ToolStripSeparator1, Me.DodajNowegoLekarzaToolStripMenuItem})
        Me.LekarzeToolStripMenuItem.Name = "LekarzeToolStripMenuItem"
        Me.LekarzeToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.LekarzeToolStripMenuItem.Text = "&Lekarze"
        '
        'ListaLekarzyToolStripMenuItem
        '
        Me.ListaLekarzyToolStripMenuItem.Name = "ListaLekarzyToolStripMenuItem"
        Me.ListaLekarzyToolStripMenuItem.Size = New System.Drawing.Size(273, 30)
        Me.ListaLekarzyToolStripMenuItem.Text = "Lista lekarzy"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(270, 6)
        '
        'DodajNowegoLekarzaToolStripMenuItem
        '
        Me.DodajNowegoLekarzaToolStripMenuItem.Name = "DodajNowegoLekarzaToolStripMenuItem"
        Me.DodajNowegoLekarzaToolStripMenuItem.Size = New System.Drawing.Size(273, 30)
        Me.DodajNowegoLekarzaToolStripMenuItem.Text = "&Dodaj nowego lekarza"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 450)
        Me.Controls.Add(Me.dgView)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ssBar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OptiMed - zarządzanie przychodnią"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ssBar.ResumeLayout(False)
        Me.ssBar.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ssBar As StatusStrip
    Friend WithEvents slUser As ToolStripStatusLabel
    Friend WithEvents ZamknijToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents dgView As DataGridView
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents tsNewMsg As ToolStripStatusLabel
    Friend WithEvents mnuAdmin As ToolStripMenuItem
    Friend WithEvents LekarzeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaLekarzyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents DodajNowegoLekarzaToolStripMenuItem As ToolStripMenuItem
End Class
