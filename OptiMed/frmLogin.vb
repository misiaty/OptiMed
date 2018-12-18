Public Class frmLogin

    ' TODO: Wstaw kod, aby wykonaæ niestandardowe uwierzytelnianie przy u¿yciu podanej nazwy u¿ytkownika i has³a 
    ' (Zobacz https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' Niestandardowy podmiot zabezpieczeñ mo¿e nastêpnie byæ do³¹czony do podmiotu zabezpieczeñ bie¿¹cego w¹tku g³ównego w nastêpuj¹cy sposób: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' gdzie klasa CustomPrincipal jest implementacj¹ interfejsu IPrincipal u¿ywan¹ do przeprowadzania uwierzytelniania. 
    ' Nastêpnie obiekt My.User zwróci informacjê o to¿samoœci hermetyzowan¹ w obiekcie CustomPrincipal
    ' takie jak nazwa u¿ytkownika, nazwa wyœwietlana, itp.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim oSQL As New clsSQL
        oAdmin.UserName = txtUserName.Text
        oAdmin.Password = txtPassword.Text
        If oSQL.UserExist(oAdmin.UserName, oAdmin.Password) Then
            oAdmin.IsLogged = True
            Dim oFrm As New frmMain
            oFrm.Show()
            Me.Hide()
        Else
            oAdmin.IsLogged = False

        End If
        'MsgBox(oAdmin.IsLogged)
        'Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frmP As New frmPacjent(0, 4)
        frmP.ShowDialog()
    End Sub
End Class
