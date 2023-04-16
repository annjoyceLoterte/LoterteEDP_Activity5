<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CampusForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgcampuses = New System.Windows.Forms.DataGridView()
        Me.campus_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.campus_address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.campus_dean = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Textcampus_dean = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Textcampus_address = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Textcampus_code = New System.Windows.Forms.TextBox()
        Me.buttonLoad = New System.Windows.Forms.Button()
        Me.gobackbtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        CType(Me.dgcampuses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgcampuses
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgcampuses.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgcampuses.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgcampuses.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgcampuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgcampuses.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.campus_id, Me.campus_address, Me.campus_dean})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgcampuses.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgcampuses.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgcampuses.Location = New System.Drawing.Point(344, 287)
        Me.dgcampuses.Name = "dgcampuses"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgcampuses.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgcampuses.Size = New System.Drawing.Size(609, 266)
        Me.dgcampuses.TabIndex = 63
        '
        'campus_id
        '
        Me.campus_id.HeaderText = "Campus ID"
        Me.campus_id.Name = "campus_id"
        '
        'campus_address
        '
        Me.campus_address.HeaderText = "Campus Address"
        Me.campus_address.Name = "campus_address"
        '
        'campus_dean
        '
        Me.campus_dean.HeaderText = "Dean"
        Me.campus_dean.Name = "campus_dean"
        '
        'deleteButton
        '
        Me.deleteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.deleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.deleteButton.Location = New System.Drawing.Point(683, 223)
        Me.deleteButton.Margin = New System.Windows.Forms.Padding(2)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(111, 34)
        Me.deleteButton.TabIndex = 61
        Me.deleteButton.Text = "Delete Record"
        Me.deleteButton.UseVisualStyleBackColor = False
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.Maroon
        Me.UpdateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.UpdateButton.Location = New System.Drawing.Point(575, 223)
        Me.UpdateButton.Margin = New System.Windows.Forms.Padding(2)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(111, 34)
        Me.UpdateButton.TabIndex = 60
        Me.UpdateButton.Text = "Modify Record"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Location = New System.Drawing.Point(480, 223)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 34)
        Me.btnAdd.TabIndex = 59
        Me.btnAdd.Text = "Add Record"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(412, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Campus Dean"
        '
        'Textcampus_dean
        '
        Me.Textcampus_dean.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textcampus_dean.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textcampus_dean.Location = New System.Drawing.Point(529, 177)
        Me.Textcampus_dean.Name = "Textcampus_dean"
        Me.Textcampus_dean.Size = New System.Drawing.Size(352, 22)
        Me.Textcampus_dean.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(412, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 16)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Campus Address"
        '
        'Textcampus_address
        '
        Me.Textcampus_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textcampus_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textcampus_address.Location = New System.Drawing.Point(529, 151)
        Me.Textcampus_address.Name = "Textcampus_address"
        Me.Textcampus_address.Size = New System.Drawing.Size(352, 22)
        Me.Textcampus_address.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(412, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Campus ID"
        '
        'Textcampus_code
        '
        Me.Textcampus_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textcampus_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textcampus_code.Location = New System.Drawing.Point(529, 125)
        Me.Textcampus_code.Name = "Textcampus_code"
        Me.Textcampus_code.Size = New System.Drawing.Size(96, 22)
        Me.Textcampus_code.TabIndex = 53
        '
        'buttonLoad
        '
        Me.buttonLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.buttonLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonLoad.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.buttonLoad.Location = New System.Drawing.Point(792, 223)
        Me.buttonLoad.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonLoad.Name = "buttonLoad"
        Me.buttonLoad.Size = New System.Drawing.Size(122, 34)
        Me.buttonLoad.TabIndex = 64
        Me.buttonLoad.Text = "View Campuses"
        Me.buttonLoad.UseVisualStyleBackColor = False
        '
        'gobackbtn
        '
        Me.gobackbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gobackbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gobackbtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.gobackbtn.Location = New System.Drawing.Point(344, 22)
        Me.gobackbtn.Margin = New System.Windows.Forms.Padding(2)
        Me.gobackbtn.Name = "gobackbtn"
        Me.gobackbtn.Size = New System.Drawing.Size(212, 34)
        Me.gobackbtn.TabIndex = 66
        Me.gobackbtn.Text = "Go Back to Menu"
        Me.gobackbtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StartHere.My.Resources.Resources._4
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 573)
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExport.Location = New System.Drawing.Point(755, 22)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(198, 34)
        Me.btnExport.TabIndex = 68
        Me.btnExport.Text = "Export Campus Data to CSV"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnUpload.Location = New System.Drawing.Point(553, 22)
        Me.btnUpload.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(206, 34)
        Me.btnUpload.TabIndex = 69
        Me.btnUpload.Text = "Upload Data from CSV"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'CampusForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 563)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gobackbtn)
        Me.Controls.Add(Me.dgcampuses)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Textcampus_dean)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Textcampus_address)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Textcampus_code)
        Me.Controls.Add(Me.buttonLoad)
        Me.Name = "CampusForm"
        Me.Text = "CampusForm"
        CType(Me.dgcampuses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgcampuses As DataGridView
    Friend WithEvents campus_id As DataGridViewTextBoxColumn
    Friend WithEvents campus_address As DataGridViewTextBoxColumn
    Friend WithEvents campus_dean As DataGridViewTextBoxColumn
    Friend WithEvents deleteButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Textcampus_dean As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Textcampus_address As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Textcampus_code As TextBox
    Friend WithEvents buttonLoad As Button
    Friend WithEvents gobackbtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnExport As Button
    Friend WithEvents btnUpload As Button
End Class
