Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Text
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class StudentGuardianForm
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "Insert into student_guardian values('" _
                & .Textparents_code.Text & "', '" _
                & .Textmother_fullname.Text & "', '" & .Textfather_fullname.Text & "', '" _
                & .Textmother_cNum.Text & "' , '" & .Textfather_cNum.Text & "')"


                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Record Successfully Added!")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Disconnect_to_DB()
        End With
    End Sub

    Private Sub Clear_Boxes()
        With Me
            .Textparents_code.Text = ""
            .Textmother_fullname.Text = ""
            .Textfather_fullname.Text = ""
            .Textmother_cNum.Text = ""
            .Textfather_cNum.Text = ""
        End With
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "Update student_guardian set mother_fullname= ('" & .Textmother_fullname.Text & "'),
                father_fullname= ('" & .Textfather_fullname.Text & "'), 
                mother_cNum= ('" & .Textfather_cNum.Text & "'),
                father_cNum= ('" & .Textfather_cNum.Text & "') where parents_code= '" & .Textparents_code.Text & "'"
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Record Successfully Updated!")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Disconnect_to_DB()
        End With
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "Delete from student_guardian where parents_code= '" & .Textparents_code.Text & "'"
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Record Successfully Deleted!")
                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Disconnect_to_DB()
        End With
    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        Me.dgparents.Rows.Clear()
        Dim strsql As String
        Dim mycmd As New MySqlCommand
        strsql = "Select * from student_guardian"
        Connect_to_DB()
        With mycmd
            .Connection = myconn
            .CommandType = CommandType.Text
            .CommandText = strsql
        End With
        Dim myreader As MySqlDataReader
        myreader = mycmd.ExecuteReader()
        While myreader.Read()
            Me.dgparents.Rows.Add(New Object() {myreader.Item("parents_code"), myreader.Item("mother_fullname"), myreader.Item("father_fullname"), myreader.Item("mother_cNum"), myreader.Item("father_cNum")})
        End While
        Disconnect_to_DB()
    End Sub

    Private Sub gobackbtn_Click(sender As Object, e As EventArgs) Handles gobackbtn.Click
        Hide()
        MenuForm3.Show()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim tableName As String = "student_guardian"
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*"
        saveDialog.Title = "Export to CSV"
        saveDialog.FileName = tableName + ".csv"

        If saveDialog.ShowDialog() = DialogResult.OK Then
            ExportToCSV(tableName, saveDialog.FileName)
        End If
    End Sub
    Private Sub ExportToCSV(tableName As String, fileName As String)
        Dim query As String = "SELECT * FROM " + tableName
        Dim adapter As New MySqlDataAdapter(query, myconn)
        Dim dataTable As New DataTable()

        myconn.Open()
        adapter.Fill(dataTable)
        myconn.Close()

        Dim csv As New StringBuilder()

        ' Add column names to CSV file
        Dim headerLine As String = String.Empty
        For Each column As DataColumn In dataTable.Columns
            headerLine += column.ColumnName + ","
        Next
        headerLine = headerLine.TrimEnd(",")
        csv.AppendLine(headerLine)

        ' Add rows to CSV file
        For Each row As DataRow In dataTable.Rows
            Dim line As String = ""
            For i As Integer = 0 To dataTable.Columns.Count - 1
                line += row(i).ToString() + ","
            Next
            line = line.TrimEnd(",")
            csv.AppendLine(line)
        Next
        File.WriteAllText(fileName, csv.ToString())
        MessageBox.Show("Data exported to " + fileName)
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim openDialog As New OpenFileDialog()
        openDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*"
        openDialog.Title = "Upload from CSV"

        If openDialog.ShowDialog() = DialogResult.OK Then
            UploadFromCSV(openDialog.FileName)
        End If
    End Sub
    Private Sub UploadFromCSV(fileName As String)
        ' Open the CSV file
        Dim csv As New StreamReader(fileName)

        ' Read the column names from the first line
        Dim columns As String() = csv.ReadLine().Split(","c)

        ' Loop through the remaining lines
        While Not csv.EndOfStream
            ' Read the values from the line
            Dim values As String() = csv.ReadLine().Split(","c)

            ' Insert the values into the database
            myconn.Open()

            Dim query As String = "INSERT INTO student_guardian (" + String.Join(", ", columns) + ") VALUES (" + String.Join(", ", values.Select(Function(v) "'" + v + "'")) + ")"
            Dim cmd As New MySqlCommand(query, myconn)
            cmd.ExecuteNonQuery()

            myconn.Close()
        End While

        ' Close the CSV file
        csv.Close()

        ' Display a message to the user
        MessageBox.Show("Data successfully uploaded from " + fileName)
    End Sub
End Class