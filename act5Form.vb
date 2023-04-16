Imports System.IO

Public Class act5Form

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        ' Open file dialog to allow user to select CSV file
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "CSV Files (*.csv)|*.csv"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Display selected file path in text box
            txtFilePath.Text = openFileDialog.FileName
        End If
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        ' Load CSV file data into DataTable
        If String.IsNullOrEmpty(txtFilePath.Text) Then
            MessageBox.Show("Please select a CSV file to load.")
            Return
        End If
        Dim dt As New DataTable()
        Dim lineCount As Integer = 0
        Using sr As New StreamReader(txtFilePath.Text)
            While Not sr.EndOfStream
                Dim line As String = sr.ReadLine()
                Dim values As String() = line.Split(","c)
                If lineCount = 0 Then
                    ' Add columns to DataTable based on header row
                    For Each value As String In values
                        dt.Columns.Add(value)
                    Next
                Else
                    ' Add data rows to DataTable
                    Dim dr As DataRow = dt.NewRow()
                    For i As Integer = 0 To values.Length - 1
                        dr(i) = values(i)
                    Next
                    dt.Rows.Add(dr)
                End If
                lineCount += 1
            End While
        End Using

        ' Bind DataTable to DataGrid tool
        DataGridView1.DataSource = dt
    End Sub
    Private Sub gobackbtn_Click(sender As Object, e As EventArgs) Handles gobackbtn.Click
        Hide()
        MenuForm3.Show()
    End Sub
End Class
