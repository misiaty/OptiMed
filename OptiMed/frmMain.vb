Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        slUser.Text = "Zalogowany użytkownik: " & oAdmin.UserName

        UstawPrawa()
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
    Private Sub ListaPacjentow()

        dgView.Columns.Clear()

        Dim col1 As New DataGridViewTextBoxColumn
        col1.DataPropertyName = "Id"
        col1.HeaderText = "id"
        col1.Name = "id"
        col1.Visible = False
        dgView.Columns.Add(col1)
        Dim col2 As New DataGridViewTextBoxColumn
        col2.DataPropertyName = "Pesel"
        col2.HeaderText = "PESEL"
        col2.Name = "Pesel"
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
        col5.DataPropertyName = "DataUrodzenia"
        col5.HeaderText = "Data Urodzenia"
        col5.Name = "DataUrodzenia"
        dgView.Columns.Add(col5)
        Dim col6 As New DataGridViewTextBoxColumn
        col6.DataPropertyName = "KodPocztowy"
        col6.HeaderText = "Kod Pocztowy"
        col6.Name = "KodPocztowy"
        dgView.Columns.Add(col6)
        Dim col7 As New DataGridViewTextBoxColumn
        col7.DataPropertyName = "Miejscowosc"
        col7.HeaderText = "Miejscowość"
        col7.Name = "Miejscowosc"
        dgView.Columns.Add(col7)
        Dim col8 As New DataGridViewTextBoxColumn
        col8.DataPropertyName = "Ulica"
        col8.HeaderText = "Ulica"
        col8.Name = "Ulica"
        dgView.Columns.Add(col8)
        Dim col9 As New DataGridViewTextBoxColumn
        col9.DataPropertyName = "Numer"
        col9.HeaderText = "Numer"
        col9.Name = "Numer"
        dgView.Columns.Add(col9)
        Dim col10 As New DataGridViewTextBoxColumn
        col10.DataPropertyName = "Email"
        col10.HeaderText = "Email"
        col10.Name = "Email"
        dgView.Columns.Add(col10)
        Dim col11 As New DataGridViewTextBoxColumn
        col11.DataPropertyName = "Telefon"
        col11.HeaderText = "Telefon"
        col11.Name = "Telefon"
        dgView.Columns.Add(col11)
        Dim col12 As New DataGridViewTextBoxColumn
        col12.DataPropertyName = "TelKom"
        col12.HeaderText = "Telefon Komórkowy"
        col12.Name = "TelKom"
        dgView.Columns.Add(col12)



        Dim oSQL As New clsSQL

        dgView.AutoGenerateColumns = False
        dgView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgView.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        dgView.DataSource = oSQL.ListaPacjentow.Tables(0)

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
        Dim frmP As New frmPacjent(1, 3)
        frmP.Show()

    End Sub
    Private Sub NewMessage()
        tsNewMsg.Visible = True
        ToolStripButton3.Font = New Font(ToolStripButton3.Font, FontStyle.Bold)
        ToolStripButton3.ForeColor = Color.Red
    End Sub

    Private Sub DodajNowegoLekarzaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frmDoc As New frmLekarz
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
    End Sub

    Private Sub tsbExit_Click(sender As Object, e As EventArgs) Handles tsbExit.Click
        'Dim Pytanie As New Tools
        'If Pytanie.ZamknacProgram Then
        Application.Exit()
        'End If
    End Sub

    Private Sub DodajNowegoLekarzaToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DodajNowegoLekarzaToolStripMenuItem.Click
        Dim frmDoc As New frmLekarz
        frmDoc.ShowDialog()
    End Sub

    Private Sub RejestracjaPacjentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RejestracjaPacjentaToolStripMenuItem.Click
        Dim frmP As New frmPacjent(0, 3)
        frmP.Show()
    End Sub

    Private Sub ListaPacjentówToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaPacjentówToolStripMenuItem.Click
        ListaPacjentow()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim mTool As New Tools
        If Not mTool.ZamknacProgram Then
            e.Cancel = True
        Else
            Application.Exit()
        End If
    End Sub

    Private Sub ZamknijToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZamknijToolStripMenuItem.Click
        Dim Pytanie As New Tools
        If Pytanie.ZamknacProgram Then
            Application.Exit()
        End If
    End Sub
End Class
Public Class Tools

    Public Function ZamknacProgram() As Boolean
        Dim Result As Integer = MsgBox("Czy chcesz zakończyć działanie programu?", vbYesNo + vbQuestion, "Koniec")
        Select Case Result
            Case vbYes
                Return True
            Case vbNo
                Return False
        End Select
        Return False
    End Function

End Class