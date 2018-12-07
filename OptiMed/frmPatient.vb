Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient
Public Class frmPatient

    Dim NewRecordID As Integer
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
        Dim frmR As New frmRecipe
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

    Private Function UserExist(ByVal sUserName As String) As Boolean
        Dim cmd = New SqlCommand("SELECT * FROM db_users WHERE (login=@login)")

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
        Dim sql As String = "INSERT INTO db_users(login,password,role_id) VALUES (@login,@password,@role_id); SELECT SCOPE_IDENTITY()"

        Dim sqlCom As New SqlCommand(sql, oAdmin.Connection)

        If Not oAdmin.Connection.State = ConnectionState.Open Then oAdmin.Connection.Open()

        sqlCom.Parameters.Add("@login", SqlDbType.VarChar).Value = txtLogin.Text
        sqlCom.Parameters.Add("@password", SqlDbType.NVarChar).Value = txtPassword.Text
        sqlCom.Parameters.Add("@role_id", SqlDbType.Int).Value = 4



        Try

            NewRecordID = sqlCom.ExecuteScalar()

            Return True
        Catch ex As Exception
            Return False
        End Try



    End Function

    Private Function AddLekarz(ByVal idUser As Integer) As Boolean

        Dim sqlLekarz As String = "INSERT INTO Pacjenci(IdUzytkownika,Imie,Nazwisko,Specjalizacja,NrLicencji) VALUES (@IdUzytkownika,@Imie,@Nazwisko,@Specjalizacja,@NrLicencji);"
        'dokonczyc dla Pacjenta
        Dim sqlCom As New SqlCommand(sqlLekarz, oAdmin.Connection)

        If Not oAdmin.Connection.State = ConnectionState.Open Then oAdmin.Connection.Open()

        sqlCom.Parameters.Add("@IdUzytkownika", SqlDbType.Int).Value = idUser
        sqlCom.Parameters.Add("@Imie", SqlDbType.VarChar).Value = Trim(txtImie.Text)
        sqlCom.Parameters.Add("@Nazwisko", SqlDbType.VarChar).Value = Trim(txtNazwisko.Text)
        'sqlCom.Parameters.Add("@Specjalizacja", SqlDbType.VarChar).Value = cmbSpec.Text
        'sqlCom.Parameters.Add("@NrLicencji", SqlDbType.VarChar).Value = mskNLicencji.Text



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
End Class