Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient

Public Class frmDoctor
    Dim NewRecordID As Integer
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If UserExist(Trim(txtLogin.Text)) Then
            MsgBox("Użytkownik o takiej nazwie logowania już istnieje." & vbCrLf &
                   "Proszę wprowdzić inną nazwę", vbInformation + vbOKOnly, "Błąd")
            txtLogin.Select()
        End If
        If AddUser() Then
            If AddLekarz(NewRecordID) Then
                MsgBox("Lekarz został poprawnie dodany.")
            End If
        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Function UserExist(ByVal sUserName As String) As Boolean
        Dim cmd = New SqlCommand("SELECT * FROM optimed.Uzytkownicy WHERE (Login=@login)")

        cmd.Connection = oAdmin.Connection
        cmd.Parameters.Add("@login", SqlDbType.VarChar).Value = sUserName
        If oAdmin.Connection.State <> ConnectionState.Open Then
            oAdmin.Connection.Open()
        End If
        Dim result = cmd.ExecuteScalar
        If Not IsNothing(result) Then
            Return True

        End If
        Return False
    End Function
    Private Function AddUser() As Boolean
        Dim sql As String = "INSERT INTO optimed.Uzytkownicy(Login,Haslo,IdRoli) VALUES (@login,@password,@role_id); SELECT SCOPE_IDENTITY()"

        Dim sqlCom As New SqlCommand(sql, oAdmin.Connection)

        If Not oAdmin.Connection.State = ConnectionState.Open Then oAdmin.Connection.Open()

        sqlCom.Parameters.Add("@login", SqlDbType.VarChar).Value = txtLogin.Text
        sqlCom.Parameters.Add("@password", SqlDbType.NVarChar).Value = txtPassword.Text
        sqlCom.Parameters.Add("@role_id", SqlDbType.Int).Value = 3



        Try

            NewRecordID = sqlCom.ExecuteScalar()

            Return True
        Catch ex As Exception
            Return False
        End Try



    End Function

    Private Function AddLekarz(ByVal idUser As Integer) As Boolean

        Dim sqlLekarz As String = "INSERT INTO optimed.Lekarze(IdUzytkownika,Imie,Nazwisko,Specjalizacja,NrLicencji) VALUES (@IdUzytkownika,@Imie,@Nazwisko,@Specjalizacja,@NrLicencji);"

        Dim sqlCom As New SqlCommand(sqlLekarz, oAdmin.Connection)

        If Not oAdmin.Connection.State = ConnectionState.Open Then oAdmin.Connection.Open()

        sqlCom.Parameters.Add("@IdUzytkownika", SqlDbType.Int).Value = idUser
        sqlCom.Parameters.Add("@Imie", SqlDbType.VarChar).Value = Trim(txtImie.Text)
        sqlCom.Parameters.Add("@Nazwisko", SqlDbType.VarChar).Value = Trim(txtNazwisko.Text)
        sqlCom.Parameters.Add("@Specjalizacja", SqlDbType.VarChar).Value = cmbSpec.Text
        sqlCom.Parameters.Add("@NrLicencji", SqlDbType.VarChar).Value = mskNLicencji.Text



        Try

            Dim iCount As Integer = sqlCom.ExecuteNonQuery

            Return True
        Catch ex As Exception
            Return False
        End Try


    End Function
End Class
