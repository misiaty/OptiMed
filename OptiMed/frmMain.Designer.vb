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
        Me.mnuMenu = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZamknijToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacjenciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaPacjentówToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.RejestracjaPacjentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LekarzeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaLekarzyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DodajNowegoLekarzaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAdmin = New System.Windows.Forms.ToolStripMenuItem()
        Me.PracownicyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UżytkownicyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaUżytkownikówToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ssBar = New System.Windows.Forms.StatusStrip()
        Me.slUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsNewMsg = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tbStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.tsbExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.dgView = New System.Windows.Forms.DataGridView()
        Me.mnuMenu.SuspendLayout()
        Me.ssBar.SuspendLayout()
        Me.tbStrip.SuspendLayout()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuMenu
        '
        Me.mnuMenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem, Me.PacjenciToolStripMenuItem, Me.LekarzeToolStripMenuItem, Me.mnuAdmin})
        Me.mnuMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.mnuMenu.Size = New System.Drawing.Size(789, 24)
        Me.mnuMenu.TabIndex = 0
        Me.mnuMenu.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZamknijToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(65, 22)
        Me.ProgramToolStripMenuItem.Text = "&Program"
        '
        'ZamknijToolStripMenuItem
        '
        Me.ZamknijToolStripMenuItem.Image = Global.OptiMed.My.Resources.Resources.iconfinder_Log_Out_27856
        Me.ZamknijToolStripMenuItem.Name = "ZamknijToolStripMenuItem"
        Me.ZamknijToolStripMenuItem.Size = New System.Drawing.Size(188, 30)
        Me.ZamknijToolStripMenuItem.Text = "&Zakończ"
        '
        'PacjenciToolStripMenuItem
        '
        Me.PacjenciToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaPacjentówToolStripMenuItem, Me.ToolStripSeparator3, Me.RejestracjaPacjentaToolStripMenuItem})
        Me.PacjenciToolStripMenuItem.Name = "PacjenciToolStripMenuItem"
        Me.PacjenciToolStripMenuItem.Size = New System.Drawing.Size(63, 22)
        Me.PacjenciToolStripMenuItem.Text = "Pacjenci"
        '
        'ListaPacjentówToolStripMenuItem
        '
        Me.ListaPacjentówToolStripMenuItem.Name = "ListaPacjentówToolStripMenuItem"
        Me.ListaPacjentówToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ListaPacjentówToolStripMenuItem.Text = "&Lista pacjentów"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(175, 6)
        '
        'RejestracjaPacjentaToolStripMenuItem
        '
        Me.RejestracjaPacjentaToolStripMenuItem.Name = "RejestracjaPacjentaToolStripMenuItem"
        Me.RejestracjaPacjentaToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.RejestracjaPacjentaToolStripMenuItem.Text = "&Rejestracja pacjenta"
        '
        'LekarzeToolStripMenuItem
        '
        Me.LekarzeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaLekarzyToolStripMenuItem, Me.ToolStripSeparator1, Me.DodajNowegoLekarzaToolStripMenuItem})
        Me.LekarzeToolStripMenuItem.Name = "LekarzeToolStripMenuItem"
        Me.LekarzeToolStripMenuItem.Size = New System.Drawing.Size(58, 22)
        Me.LekarzeToolStripMenuItem.Text = "&Lekarze"
        '
        'ListaLekarzyToolStripMenuItem
        '
        Me.ListaLekarzyToolStripMenuItem.Image = Global.OptiMed.My.Resources.Resources.UserSetup
        Me.ListaLekarzyToolStripMenuItem.Name = "ListaLekarzyToolStripMenuItem"
        Me.ListaLekarzyToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ListaLekarzyToolStripMenuItem.Text = "Lista lekarzy"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(187, 6)
        '
        'DodajNowegoLekarzaToolStripMenuItem
        '
        Me.DodajNowegoLekarzaToolStripMenuItem.Image = Global.OptiMed.My.Resources.Resources._New
        Me.DodajNowegoLekarzaToolStripMenuItem.Name = "DodajNowegoLekarzaToolStripMenuItem"
        Me.DodajNowegoLekarzaToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.DodajNowegoLekarzaToolStripMenuItem.Text = "&Dodaj nowego lekarza"
        '
        'mnuAdmin
        '
        Me.mnuAdmin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PracownicyToolStripMenuItem, Me.UżytkownicyToolStripMenuItem})
        Me.mnuAdmin.Name = "mnuAdmin"
        Me.mnuAdmin.Size = New System.Drawing.Size(92, 22)
        Me.mnuAdmin.Text = "&Administracja"
        '
        'PracownicyToolStripMenuItem
        '
        Me.PracownicyToolStripMenuItem.Image = Global.OptiMed.My.Resources.Resources.iconfinder_Copy_v2_27839
        Me.PracownicyToolStripMenuItem.Name = "PracownicyToolStripMenuItem"
        Me.PracownicyToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.PracownicyToolStripMenuItem.Text = "&Pracownicy"
        '
        'UżytkownicyToolStripMenuItem
        '
        Me.UżytkownicyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaUżytkownikówToolStripMenuItem, Me.ToolStripSeparator2})
        Me.UżytkownicyToolStripMenuItem.Image = Global.OptiMed.My.Resources.Resources.iconfinder_User_27887
        Me.UżytkownicyToolStripMenuItem.Name = "UżytkownicyToolStripMenuItem"
        Me.UżytkownicyToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.UżytkownicyToolStripMenuItem.Text = "&Użytkownicy"
        '
        'ListaUżytkownikówToolStripMenuItem
        '
        Me.ListaUżytkownikówToolStripMenuItem.Name = "ListaUżytkownikówToolStripMenuItem"
        Me.ListaUżytkownikówToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ListaUżytkownikówToolStripMenuItem.Text = "&Lista użytkowników"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(174, 6)
        '
        'ssBar
        '
        Me.ssBar.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ssBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slUser, Me.tsNewMsg})
        Me.ssBar.Location = New System.Drawing.Point(0, 270)
        Me.ssBar.Name = "ssBar"
        Me.ssBar.Padding = New System.Windows.Forms.Padding(1, 0, 9, 0)
        Me.ssBar.Size = New System.Drawing.Size(789, 22)
        Me.ssBar.TabIndex = 1
        Me.ssBar.Text = "StatusStrip1"
        '
        'slUser
        '
        Me.slUser.Name = "slUser"
        Me.slUser.Size = New System.Drawing.Size(120, 17)
        Me.slUser.Text = "ToolStripStatusLabel1"
        '
        'tsNewMsg
        '
        Me.tsNewMsg.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsNewMsg.ForeColor = System.Drawing.Color.Red
        Me.tsNewMsg.Name = "tsNewMsg"
        Me.tsNewMsg.Size = New System.Drawing.Size(164, 17)
        Me.tsNewMsg.Text = "MASZ NOWĄ WIADOMOŚĆ!"
        Me.tsNewMsg.Visible = False
        '
        'tbStrip
        '
        Me.tbStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.tbStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.tsbExit, Me.ToolStripButton3})
        Me.tbStrip.Location = New System.Drawing.Point(0, 24)
        Me.tbStrip.Name = "tbStrip"
        Me.tbStrip.Size = New System.Drawing.Size(789, 31)
        Me.tbStrip.TabIndex = 2
        Me.tbStrip.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(93, 28)
        Me.ToolStripButton1.Text = "Lista pacjentów"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(42, 28)
        Me.ToolStripButton2.Text = "Grafik"
        '
        'tsbExit
        '
        Me.tsbExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbExit.Image = Global.OptiMed.My.Resources.Resources.iconfinder_Log_Out_27856
        Me.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExit.Name = "tsbExit"
        Me.tsbExit.Size = New System.Drawing.Size(28, 28)
        Me.tsbExit.Text = "Wyloguj"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.Black
        Me.ToolStripButton3.Image = Global.OptiMed.My.Resources.Resources.iconfinder_Mail_27857
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(28, 28)
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
        Me.dgView.Location = New System.Drawing.Point(0, 55)
        Me.dgView.Margin = New System.Windows.Forms.Padding(2)
        Me.dgView.Name = "dgView"
        Me.dgView.ReadOnly = True
        Me.dgView.RowTemplate.Height = 28
        Me.dgView.Size = New System.Drawing.Size(789, 215)
        Me.dgView.TabIndex = 3
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 292)
        Me.Controls.Add(Me.dgView)
        Me.Controls.Add(Me.tbStrip)
        Me.Controls.Add(Me.ssBar)
        Me.Controls.Add(Me.mnuMenu)
        Me.MainMenuStrip = Me.mnuMenu
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OptiMed - zarządzanie przychodnią"
        Me.mnuMenu.ResumeLayout(False)
        Me.mnuMenu.PerformLayout()
        Me.ssBar.ResumeLayout(False)
        Me.ssBar.PerformLayout()
        Me.tbStrip.ResumeLayout(False)
        Me.tbStrip.PerformLayout()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMenu As MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ssBar As StatusStrip
    Friend WithEvents slUser As ToolStripStatusLabel
    Friend WithEvents ZamknijToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tbStrip As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents dgView As DataGridView
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents tsbExit As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents tsNewMsg As ToolStripStatusLabel
    Friend WithEvents mnuAdmin As ToolStripMenuItem
    Friend WithEvents UżytkownicyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaUżytkownikówToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents PacjenciToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaPacjentówToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents RejestracjaPacjentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LekarzeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaLekarzyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents DodajNowegoLekarzaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PracownicyToolStripMenuItem As ToolStripMenuItem
End Class
