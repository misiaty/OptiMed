Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class frmPacjent

    'Dim NewRecordID As Integer
    Dim idTryb As Integer
    Public Sub New(ByVal Tryb As Integer, ByVal Rola As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        idTryb = Tryb
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim frmR As New frmRecepta
        frmR.Show()
    End Sub
    Private Sub UstawOkno(ByVal Tryb As Integer)

        Select Case Tryb
            Case 0
                TabPage2.Enabled = False
                TabPage3.Enabled = False
                btnRegister.Visible = True
            Case Else
                btnRegister.Visible = False
        End Select
    End Sub

    Private Function DodajPacjenta(ByVal idUser As Integer) As Boolean

        Dim sqlLekarz As String = "INSERT INTO " &
            "optimed.Pacjenci(IdUzytkownika,Imie,Nazwisko,DataUrodzenia,KodPocztowy,Miejscowosc," &
            "Ulica,Numer,Pesel,Email,Telefon,TelKom) " &
            "VALUES (@IdUzytkownika,@Imie,@Nazwisko,@DataUrodzenia,@KodPocztowy,@Miejscowosc," &
            "@Ulica,@Numer,@Pesel,@Email,@Telefon,@TelKom);"
        'dokonczyc dla Pacjenta
        Dim sqlCom As New SqlCommand(sqlLekarz, oAdmin.Connection)

        If Not oAdmin.Connection.State = ConnectionState.Open Then oAdmin.Connection.Open()

        sqlCom.Parameters.Add("@IdUzytkownika", SqlDbType.Int).Value = idUser
        sqlCom.Parameters.Add("@Imie", SqlDbType.VarChar).Value = Trim(txtImie.Text)
        sqlCom.Parameters.Add("@Nazwisko", SqlDbType.VarChar).Value = Trim(txtNazwisko.Text)
        sqlCom.Parameters.Add("@DataUrodzenia", SqlDbType.Date).Value = Trim(dtDUrodzenia.Value.ToShortDateString)
        sqlCom.Parameters.Add("@KodPocztowy", SqlDbType.VarChar).Value = Trim(txtKodP.Text)
        sqlCom.Parameters.Add("@Miejscowosc", SqlDbType.VarChar).Value = Trim(txtMiasto.Text)
        sqlCom.Parameters.Add("@Ulica", SqlDbType.VarChar).Value = Trim(txtUlica.Text)
        sqlCom.Parameters.Add("@Numer", SqlDbType.VarChar).Value = Trim(txtNrDomu.Text) & "/" & Trim(txtLokal.Text)
        sqlCom.Parameters.Add("@Pesel", SqlDbType.VarChar).Value = Trim(mskPesel.Text)
        sqlCom.Parameters.Add("@Email", SqlDbType.VarChar).Value = Trim(txtEmail.Text)
        sqlCom.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = Trim(txtTel.Text)
        sqlCom.Parameters.Add("@TelKom", SqlDbType.VarChar).Value = Trim(mskTelKom.Text)

        Try

            Dim iCount As Integer = sqlCom.ExecuteNonQuery

            Return True
        Catch ex As Exception
            Return False
        End Try


    End Function

    Private Sub frmPatient_Load(sender As Object, e As EventArgs) Handles Me.Load
        UstawOkno(idTryb)
    End Sub

    Private Sub txtEmail_Validating(sender As Object, e As CancelEventArgs) Handles txtEmail.Validating
        If Not PoprawnyEmail(Trim(txtEmail.Text)) Then
            txtEmail.BackColor = Color.Red
            lblEmailError.Visible = True
            txtEmail.Select()

        Else
            txtEmail.BackColor = DefaultBackColor
            lblEmailError.Visible = False
        End If
    End Sub

    Private Sub mskPesel_Validating(sender As Object, e As CancelEventArgs) Handles mskPesel.Validating
        If Not SprawdzPESEL(mskPesel.Text) Then
            mskPesel.BackColor = Color.Red
            mskPesel.Select()
        Else
            mskPesel.BackColor = DefaultBackColor
            dtDUrodzenia.Value = DataUrodzeniaPESEL(mskPesel.Text)
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If Trim(txtPassword.Text) <> Trim(txtPassword2.Text) Then
            MsgBox("Wprowadzone hasła są różne." & vbCrLf &
                   "Proszę wprowdzić ponownie.", vbInformation + vbOKOnly, "Błąd")
            txtPassword.BackColor = Color.Red
            txtPassword2.BackColor = Color.Red
            txtPassword.Select()
        Else
            txtPassword.BackColor = DefaultBackColor
            txtPassword2.BackColor = DefaultBackColor
        End If

        If UserExist(Trim(txtLogin.Text)) Then
            MsgBox("Użytkownik o takiej nazwie logowania już istnieje." & vbCrLf &
                   "Proszę wprowdzić inną nazwę", vbInformation + vbOKOnly, "Błąd")
            txtLogin.Select()
        End If
        If AddUser(Trim(txtLogin.Text), Trim(txtPassword.Text), 4) Then
            If DodajPacjenta(NewRecordID) Then
                MsgBox("Pacjent został poprawnie dodany.")
            End If
        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class