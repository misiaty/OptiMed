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
        col1.DataPropertyName = "login"
        col1.HeaderText = "Nazwa użytkownika"
        col1.Name = "UserName"
        dgView.Columns.Add(col1)
        Dim col2 As New DataGridViewTextBoxColumn
        col2.DataPropertyName = "roleDesc"
        col2.HeaderText = "Rola użytkownika"
        col2.Name = "rola"
        dgView.Columns.Add(col2)

        Dim oSQL As New clsSQL

        dgView.AutoGenerateColumns = False
        dgView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgView.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        dgView.DataSource = oSQL.UserList.Tables(0)

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

    Private Sub DodajNowegoLekarzaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DodajNowegoLekarzaToolStripMenuItem.Click
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
End Class
