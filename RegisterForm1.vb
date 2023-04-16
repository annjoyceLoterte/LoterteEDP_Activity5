Imports MySql.Data.MySqlClient
Imports System.Data.Common
Imports System.Data.SqlClient

Public Class RegisterForm1
    Private Sub Clear_Boxes()
        With Me
            .Textuser_Id.Text = ""
            .Textusername.Text = ""
            .Textpassword.Text = ""
        End With
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "Insert into admin values('" & .Textuser_Id.Text & "', '" _
                & .Textusername.Text & "', '" _
                & .Textpassword.Text & "')"

                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("You are successfully registered!")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Disconnect_to_DB()
        End With
    End Sub

    Private Sub LinkLoginhere_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLoginhere.LinkClicked
        Hide()
        LoginForm1.Show()
    End Sub
End Class