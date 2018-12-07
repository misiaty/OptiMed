Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        slUser.Text = "Zalogowany użytkownik: " & oAdmin.UserName

        UstawPrawa()
    End Sub

    Private Sub ZamknijToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZamknijToolStripMenuItem.Click
        Me.Dispose()
        End

    End Sub
    Private Sub PokazUzytkownikow()

        dgView.Columns.Clear()

        Dim col1 As New DataGridViewTextBoxColumn
        col1.DataPropertyName = "Login"
        col1.HeaderText = "Nazwa użytkownika"
        col1.Name = "Login"
        dgView.Columns.Add(col1)
        Dim col2 As New DataGridViewTextBoxColumn
        col2.DataPropertyName = "Rola"
        col2.HeaderText = "Rola użytkownika"
        col2.Name = "Rola"
        dgView.Columns.Add(col2)

        Dim oSQL As New clsSQL

        dgView.AutoGenerateColumns = False
        dgView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgView.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        dgView.DataSource = oSQL.UserList.Tables(0)

    End Sub
    Private Sub ListaLekarzy()

        dgView.Columns.Clear()

        Dim col1 As New DataGridViewTextBoxColumn
        col1.DataPropertyName = "Id"
        col1.HeaderText = "id"
        col1.Name = "id"
        col1.Visible = False
        dgView.Columns.Add(col1)
        Dim col2 As New DataGridViewTextBoxColumn
        col2.DataPropertyName = "NrLicencji"
        col2.HeaderText = "Numer licencji"
        col2.Name = "NrLicencji"
        dgView.Columns.Add(col2)
        Dim col3 As New DataGridViewTextBoxColumn
        col3.DataPropertyName = "Imie"
        col3.HeaderText = "Imię"
        col3.Name = "Imie"
        dgView.Columns.Add(col3)
        Dim col4 As New DataGridViewTextBoxColumn
        col4.DataPropertyName = "Nazwisko"
        col4.HeaderText = "Nazwisko"
        col4.Name = "Nazwisko"
        dgView.Columns.Add(col4)
        Dim col5 As New DataGridViewTextBoxColumn
        col5.DataPropertyName = "Specjalizacja"
        col5.HeaderText = "Specjalizacja"
        col5.Name = "Specjalizacja"
        dgView.Columns.Add(col5)


        Dim oSQL As New clsSQL

        dgView.AutoGenerateColumns = False
        dgView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgView.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        dgView.DataSource = oSQL.ListaLekarzy.Tables(0)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        PokazUzytkownikow()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        NewMessage()
    End Sub

    Private Sub dgView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgView.CellContentClick

    End Sub

    Private Sub dgView_DoubleClick(sender As Object, e As EventArgs) Handles dgView.DoubleClick
        Dim frmP As New frmPatient(1, 3)
        frmP.Show()

    End Sub
    Private Sub NewMessage()
        tsNewMsg.Visible = True
        ToolStripButton3.Font = New Font(ToolStripButton3.Font, FontStyle.Bold)
        ToolStripButton3.ForeColor = Color.Red
    End Sub

    Private Sub DodajNowegoLekarzaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frmDoc As New frmDoctor
        frmDoc.ShowDialog()
    End Sub
    Private Sub UstawPrawa()
        Select Case oAdmin.IdRoli
            Case 1
                mnuAdmin.Visible = True
            Case Else
                mnuAdmin.Visible = False

        End Select
    End Sub

    Private Sub ListaUżytkownikówToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaUżytkownikówToolStripMenuItem.Click
        PokazUzytkownikow()

    End Sub

    Private Sub ListaLekarzyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaLekarzyToolStripMenuItem.Click
        ListaLekarzy()
    End Sub



    Private Sub frmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
        End
    End Sub

    Private Sub tsbExit_Click(sender As Object, e As EventArgs) Handles tsbExit.Click
        Me.Dispose()
        End
    End Sub

    Private Sub DodajNowegoLekarzaToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DodajNowegoLekarzaToolStripMenuItem.Click
        Dim frmDoc As New frmDoctor
        frmDoc.ShowDialog()
    End Sub

    Private Sub RejestracjaPacjentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RejestracjaPacjentaToolStripMenuItem.Click
        Dim frmP As New frmPatient(1, 3)
        frmP.Show()
    End Sub
End Class
