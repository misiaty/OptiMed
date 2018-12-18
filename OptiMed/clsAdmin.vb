Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration



Public Class clsAdmin

    Dim m_oConnection As New SqlConnection(ConfigurationManager.ConnectionStrings("ConnString").ConnectionString)

    Dim sUserName As String
    Dim sPassword As String
    Dim bIsLogged As Boolean
    Dim iIdRoli As Integer

    Public Property Connection() As SqlConnection
        Get
            Return m_oConnection
        End Get
        Set(ByVal Value As SqlConnection)
            m_oConnection = Value
        End Set
    End Property

    Public Property UserName As String
        Get
            Return sUserName
        End Get
        Set(ByVal Value As String)
            sUserName = Value
        End Set
    End Property

    Public Property Password As String
        Get
            Return sPassword
        End Get
        Set(ByVal Value As String)
            sPassword = Value
        End Set
    End Property

    Public Property IsLogged As Boolean
        Get
            Return bIsLogged
        End Get
        Set(ByVal Value As Boolean)
            bIsLogged = Value
        End Set
    End Property
    Public Property IdRoli As Integer
        Get
            Return iIdRoli
        End Get
        Set(ByVal Value As Integer)
            iIdRoli = Value
        End Set
    End Property

End Class

Public Class clsSQL
    Public Function UserExist(ByVal sUserName As String, ByVal sPassword As String) As Boolean
        'Dim cmd = New SqlCommand("SELECT * FROM db_users WHERE (login=@login AND password=@password)")
        Dim cmd = New SqlCommand("SELECT * FROM optimed.Uzytkownicy WHERE (Login=@login AND Haslo=@password)")

        cmd.Connection = oAdmin.Connection
        cmd.Parameters.Add("@login", SqlDbType.VarChar).Value = sUserName
        cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = sPassword
        If oAdmin.Connection.State <> ConnectionState.Open Then
            oAdmin.Connection.Open()
        End If
        Dim result = cmd.ExecuteReader
        While result.Read
            If result.HasRows = True Then
                oAdmin.IdRoli = result(3)
                oAdmin.Connection.Close()
                Return True
            End If
        End While
        oAdmin.Connection.Close()
        Return False
    End Function
    Public Function UserList() As DataSet
        Dim sqlDA As New SqlDataAdapter
        Dim sqlComm As New SqlCommand
        Dim dbDataSet As New DataSet
        Dim cmd = New SqlCommand("SELECT * FROM optimed.Uzytkownicy u JOIN optimed.Role r ON (u.IdRoli = r.Id)")

        cmd.Connection = oAdmin.Connection


        If oAdmin.Connection.State <> ConnectionState.Open Then
            oAdmin.Connection.Open()
        End If


        sqlDA.SelectCommand = cmd
        sqlDA.Fill(dbDataSet)

        Return dbDataSet

        oAdmin.Connection.Close()
    End Function
    Public Function ListaLekarzy() As DataSet
        Dim sqlDA As New SqlDataAdapter
        Dim sqlComm As New SqlCommand
        Dim dbDataSet As New DataSet
        Dim cmd = New SqlCommand("SELECT * FROM optimed.Lekarze")

        cmd.Connection = oAdmin.Connection


        If oAdmin.Connection.State <> ConnectionState.Open Then
            oAdmin.Connection.Open()
        End If


        sqlDA.SelectCommand = cmd
        sqlDA.Fill(dbDataSet)

        Return dbDataSet

        oAdmin.Connection.Close()
    End Function
    Public Function ListaPacjentow() As DataSet
        Dim sqlDA As New SqlDataAdapter
        Dim sqlComm As New SqlCommand
        Dim dbDataSet As New DataSet
        Dim cmd = New SqlCommand("SELECT * FROM optimed.Pacjenci")

        cmd.Connection = oAdmin.Connection


        If oAdmin.Connection.State <> ConnectionState.Open Then
            oAdmin.Connection.Open()
        End If


        sqlDA.SelectCommand = cmd
        sqlDA.Fill(dbDataSet)

        Return dbDataSet

        oAdmin.Connection.Close()
    End Function
End Class