Public Class MenuForm3
    Private Sub addnewcourses_Click_1(sender As Object, e As EventArgs) Handles addnewcourses.Click
        Hide()
        Formcourses.Show()
    End Sub

    Private Sub addnewDepartment_Click(sender As Object, e As EventArgs) Handles addnewDepartment.Click
        Hide()
        DeptForm5.Show()
    End Sub

    Private Sub addnewCampus_Click(sender As Object, e As EventArgs) Handles addnewCampus.Click
        Hide()
        CampusForm.Show()
    End Sub

    Private Sub addstudentguardian_Click(sender As Object, e As EventArgs) Handles addstudentguardian.Click
        Hide()
        StudentGuardianForm.Show()
    End Sub

    Private Sub enrolledStudents_Click(sender As Object, e As EventArgs) Handles enrolledStudents.Click
        Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        LoginForm1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub bckupbtn_Click(sender As Object, e As EventArgs) Handles bckupbtn.Click
        ' Prompt user to select backup file location
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "SQL Files (*.sql)|*.sql"
        saveFileDialog.Title = "Select Backup File Location"
        saveFileDialog.ShowDialog()

        If saveFileDialog.FileName <> "" Then
            ' Build mysqldump command
            Dim command As String = $"mysqldump -h localhost -u joyce -p12345 student_db > ""{saveFileDialog.FileName}"""

            ' Execute mysqldump command
            Dim processInfo As New ProcessStartInfo("cmd.exe", "/c" + command)
            processInfo.CreateNoWindow = True
            processInfo.UseShellExecute = False
            processInfo.RedirectStandardError = True
            processInfo.RedirectStandardOutput = True

            Dim process As New Process()
            process.StartInfo = processInfo
            process.Start()

            ' Wait for the process to finish
            process.WaitForExit()

            ' Check if there were any errors
            If process.ExitCode <> 0 Then
                MessageBox.Show($"An error occurred while backing up the database: {process.StandardError.ReadToEnd()}")
            Else
                ' Display success message
                MessageBox.Show("Database backup created successfully.")
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Hide()
        act5Form.Show()
    End Sub
End Class