Imports System.Windows.Forms
Imports System.Text.RegularExpressions
Imports System.Data
Imports System.Data.SqlClient
Module modTools
    Function PoprawnyEmail(ByVal sAdresEmail As String) As Boolean
        Return Regex.IsMatch(sAdresEmail, "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
    End Function
    Function SprawdzPESEL(ByVal sPESEL As String) As Boolean
        Dim l1, l2 As Integer
        If Len(sPESEL) <> 11 Then Return False
        l1 = CInt(Mid(sPESEL, 11, 1))
        l2 = (CInt(Mid(sPESEL, 1, 1)) * 1 +
            CInt(Mid(sPESEL, 2, 1)) * 3 +
            CInt(Mid(sPESEL, 3, 1)) * 7 +
            CInt(Mid(sPESEL, 4, 1)) * 9 +
            CInt(Mid(sPESEL, 5, 1)) * 1 +
            CInt(Mid(sPESEL, 6, 1)) * 3 +
            CInt(Mid(sPESEL, 7, 1)) * 7 +
            CInt(Mid(sPESEL, 8, 1)) * 9 +
            CInt(Mid(sPESEL, 9, 1)) * 1 +
            CInt(Mid(sPESEL, 10, 1)) * 3) Mod 10
        l2 = 10 - l2
        If l1 <> l2 Then Return False
        Return True

    End Function
    Function DataUrodzeniaPESEL(ByVal sPESEL As String) As String

        Dim iRok As Integer
        Dim iMies As Integer
        Dim iDz As Integer
        Dim iWiek As Integer

        If Len(sPESEL) = 0 Then Exit Function

        sPESEL = Left(sPESEL, 6)
        On Error Resume Next
        iRok = CInt(Left(sPESEL, 2))
        iMies = CInt(Mid(sPESEL, 3, 2))
        iDz = CInt(Right(sPESEL, 2))
        On Error GoTo 0

        Select Case iMies
            Case 81 To 92
                iWiek = 1800
                iMies = iMies - 80
            Case 1 To 12
                iWiek = 1900
                iMies = iMies
            Case 21 To 32
                iWiek = 2000
                iMies = iMies - 20
            Case 41 To 52
                iWiek = 2100
                iMies = iMies - 40
            Case 61 To 72
                iWiek = 2200
                iMies = iMies - 60
            Case Else
                Exit Function
        End Select

        iRok = iWiek + iRok

        If (DateSerial(iRok, iMies + 1, 0).Day) >= iDz And iDz > 0 Then
            DataUrodzeniaPESEL = DateSerial(iRok, iMies, iDz)
        End If

    End Function
    Function UserExist(ByVal sUserName As String) As Boolean
        Dim cmd = New SqlCommand("SELECT * FROM optimed.Uzytkownicy WHERE (login=@login)")

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
    Function AddUser(ByVal sLogin As String, ByVal sHaslo As String, ByVal iRola As Integer) As Boolean
        Dim sql As String = "INSERT INTO optimed.Uzytkownicy(Login,Haslo,IdRoli) VALUES (@login,@password,@role_id); SELECT SCOPE_IDENTITY()"

        Dim sqlCom As New SqlCommand(sql, oAdmin.Connection)

        If Not oAdmin.Connection.State = ConnectionState.Open Then oAdmin.Connection.Open()

        sqlCom.Parameters.Add("@login", SqlDbType.VarChar).Value = sLogin
        sqlCom.Parameters.Add("@password", SqlDbType.NVarChar).Value = sHaslo
        sqlCom.Parameters.Add("@role_id", SqlDbType.Int).Value = iRola



        Try

            NewRecordID = sqlCom.ExecuteScalar()

            Return True
        Catch ex As Exception
            Return False
        End Try



    End Function
End Module


