<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.parents_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.course_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.student_fullname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.student_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button_Load = New System.Windows.Forms.Button()
        Me.dgstudent_info = New System.Windows.Forms.DataGridView()
        Me.campus_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gobackbtn = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.Textparents_code = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Textage = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Textcampus_code = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Textcourse_code = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextAddress = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Textstudent_Fullname = New System.Windows.Forms.TextBox()
        Me.Textstudent_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        CType(Me.dgstudent_info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'parents_code
        '
        Me.parents_code.HeaderText = "Parents ID"
        Me.parents_code.Name = "parents_code"
        '
        'course_code
        '
        Me.course_code.HeaderText = "Course Code"
        Me.course_code.Name = "course_code"
        '
        'age
        '
        Me.age.HeaderText = "Age"
        Me.age.Name = "age"
        '
        'address
        '
        Me.address.HeaderText = "Address"
        Me.address.Name = "address"
        '
        'student_fullname
        '
        Me.student_fullname.HeaderText = "Student Fullname"
        Me.student_fullname.Name = "student_fullname"
        '
        'student_id
        '
        Me.student_id.HeaderText = "Student ID"
        Me.student_id.Name = "student_id"
        '
        'Button_Load
        '
        Me.Button_Load.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button_Load.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Load.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button_Load.Location = New System.Drawing.Point(905, 180)
        Me.Button_Load.Name = "Button_Load"
        Me.Button_Load.Size = New System.Drawing.Size(112, 33)
        Me.Button_Load.TabIndex = 39
        Me.Button_Load.Text = "View Students"
        Me.Button_Load.UseVisualStyleBackColor = False
        '
        'dgstudent_info
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgstudent_info.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgstudent_info.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgstudent_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgstudent_info.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.student_id, Me.student_fullname, Me.address, Me.age, Me.course_code, Me.campus_code, Me.parents_code})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgstudent_info.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgstudent_info.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgstudent_info.Location = New System.Drawing.Point(297, 228)
        Me.dgstudent_info.Name = "dgstudent_info"
        Me.dgstudent_info.Size = New System.Drawing.Size(716, 311)
        Me.dgstudent_info.TabIndex = 38
        '
        'campus_code
        '
        Me.campus_code.HeaderText = "Campus ID"
        Me.campus_code.Name = "campus_code"
        '
        'gobackbtn
        '
        Me.gobackbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gobackbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gobackbtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.gobackbtn.Location = New System.Drawing.Point(291, 11)
        Me.gobackbtn.Margin = New System.Windows.Forms.Padding(2)
        Me.gobackbtn.Name = "gobackbtn"
        Me.gobackbtn.Size = New System.Drawing.Size(276, 35)
        Me.gobackbtn.TabIndex = 37
        Me.gobackbtn.Text = "Go Back to Menu"
        Me.gobackbtn.UseVisualStyleBackColor = False
        '
        'deleteButton
        '
        Me.deleteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.deleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteButton.Location = New System.Drawing.Point(793, 180)
        Me.deleteButton.Margin = New System.Windows.Forms.Padding(2)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(115, 33)
        Me.deleteButton.TabIndex = 36
        Me.deleteButton.Text = "Delete Record"
        Me.deleteButton.UseVisualStyleBackColor = False
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.Maroon
        Me.UpdateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.UpdateButton.Location = New System.Drawing.Point(682, 180)
        Me.UpdateButton.Margin = New System.Windows.Forms.Padding(2)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(115, 33)
        Me.UpdateButton.TabIndex = 35
        Me.UpdateButton.Text = "Modify Record"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'Textparents_code
        '
        Me.Textparents_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textparents_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textparents_code.Location = New System.Drawing.Point(790, 104)
        Me.Textparents_code.Margin = New System.Windows.Forms.Padding(2)
        Me.Textparents_code.Name = "Textparents_code"
        Me.Textparents_code.Size = New System.Drawing.Size(225, 22)
        Me.Textparents_code.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(697, 113)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 16)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Parents Code"
        '
        'Textage
        '
        Me.Textage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textage.Location = New System.Drawing.Point(644, 79)
        Me.Textage.Margin = New System.Windows.Forms.Padding(2)
        Me.Textage.Name = "Textage"
        Me.Textage.Size = New System.Drawing.Size(49, 22)
        Me.Textage.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(556, 85)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Student Age"
        '
        'Textcampus_code
        '
        Me.Textcampus_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textcampus_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textcampus_code.Location = New System.Drawing.Point(790, 135)
        Me.Textcampus_code.Margin = New System.Windows.Forms.Padding(2)
        Me.Textcampus_code.Name = "Textcampus_code"
        Me.Textcampus_code.Size = New System.Drawing.Size(225, 22)
        Me.Textcampus_code.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(697, 141)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 16)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Campus Code"
        '
        'Textcourse_code
        '
        Me.Textcourse_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textcourse_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textcourse_code.Location = New System.Drawing.Point(790, 75)
        Me.Textcourse_code.Margin = New System.Windows.Forms.Padding(2)
        Me.Textcourse_code.Name = "Textcourse_code"
        Me.Textcourse_code.Size = New System.Drawing.Size(225, 22)
        Me.Textcourse_code.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(697, 83)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Course Code"
        '
        'TextAddress
        '
        Me.TextAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextAddress.Location = New System.Drawing.Point(403, 137)
        Me.TextAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.TextAddress.Name = "TextAddress"
        Me.TextAddress.Size = New System.Drawing.Size(290, 22)
        Me.TextAddress.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(292, 139)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Address"
        '
        'Textstudent_Fullname
        '
        Me.Textstudent_Fullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textstudent_Fullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textstudent_Fullname.Location = New System.Drawing.Point(403, 107)
        Me.Textstudent_Fullname.Margin = New System.Windows.Forms.Padding(2)
        Me.Textstudent_Fullname.Name = "Textstudent_Fullname"
        Me.Textstudent_Fullname.Size = New System.Drawing.Size(290, 22)
        Me.Textstudent_Fullname.TabIndex = 24
        '
        'Textstudent_id
        '
        Me.Textstudent_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textstudent_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textstudent_id.Location = New System.Drawing.Point(403, 83)
        Me.Textstudent_id.Name = "Textstudent_id"
        Me.Textstudent_id.Size = New System.Drawing.Size(148, 22)
        Me.Textstudent_id.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(291, 114)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Student Fullname"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(291, 85)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(68, 16)
        Me.lblUsername.TabIndex = 21
        Me.lblUsername.Text = "Student ID"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(568, 180)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(115, 33)
        Me.btnAdd.TabIndex = 20
        Me.btnAdd.Text = "Add Record"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StartHere.My.Resources.Resources._1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(262, 616)
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExport.Location = New System.Drawing.Point(823, 12)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(190, 33)
        Me.btnExport.TabIndex = 41
        Me.btnExport.Text = "Export Student info to CSV"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnUpload.Location = New System.Drawing.Point(559, 12)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(269, 33)
        Me.btnUpload.TabIndex = 42
        Me.btnUpload.Text = "Upload data from CSV"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1038, 563)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button_Load)
        Me.Controls.Add(Me.dgstudent_info)
        Me.Controls.Add(Me.gobackbtn)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.Textparents_code)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Textage)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Textcampus_code)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Textcourse_code)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextAddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Textstudent_Fullname)
        Me.Controls.Add(Me.Textstudent_id)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnAdd)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Information"
        CType(Me.dgstudent_info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents parents_code As DataGridViewTextBoxColumn
    Friend WithEvents course_code As DataGridViewTextBoxColumn
    Friend WithEvents age As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents student_fullname As DataGridViewTextBoxColumn
    Friend WithEvents student_id As DataGridViewTextBoxColumn
    Friend WithEvents Button_Load As Button
    Friend WithEvents dgstudent_info As DataGridView
    Friend WithEvents campus_code As DataGridViewTextBoxColumn
    Friend WithEvents gobackbtn As Button
    Friend WithEvents deleteButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents Textparents_code As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Textage As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Textcampus_code As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Textcourse_code As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextAddress As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Textstudent_Fullname As TextBox
    Friend WithEvents Textstudent_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnExport As Button
    Friend WithEvents btnUpload As Button
End Class
