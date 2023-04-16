<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formcourses
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
        Me.Textschool_deptUnicode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextTuition_fee_perSem = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Textcourse_major = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.dgcourses = New System.Windows.Forms.DataGridView()
        Me.cNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.course_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.course_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.course_major = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tuition_fee_perSem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.school_deptUniCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Textcno = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Textc_code = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Textcourse_name = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        CType(Me.dgcourses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Textschool_deptUnicode
        '
        Me.Textschool_deptUnicode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textschool_deptUnicode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textschool_deptUnicode.Location = New System.Drawing.Point(854, 129)
        Me.Textschool_deptUnicode.Margin = New System.Windows.Forms.Padding(2)
        Me.Textschool_deptUnicode.Name = "Textschool_deptUnicode"
        Me.Textschool_deptUnicode.Size = New System.Drawing.Size(113, 22)
        Me.Textschool_deptUnicode.TabIndex = 54
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(723, 136)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 16)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Department Code"
        '
        'TextTuition_fee_perSem
        '
        Me.TextTuition_fee_perSem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextTuition_fee_perSem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTuition_fee_perSem.Location = New System.Drawing.Point(854, 105)
        Me.TextTuition_fee_perSem.Margin = New System.Windows.Forms.Padding(2)
        Me.TextTuition_fee_perSem.Name = "TextTuition_fee_perSem"
        Me.TextTuition_fee_perSem.Size = New System.Drawing.Size(113, 22)
        Me.TextTuition_fee_perSem.TabIndex = 52
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(718, 112)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 16)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Tuition Fee Per Sem."
        '
        'Textcourse_major
        '
        Me.Textcourse_major.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textcourse_major.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textcourse_major.Location = New System.Drawing.Point(422, 181)
        Me.Textcourse_major.Margin = New System.Windows.Forms.Padding(2)
        Me.Textcourse_major.Name = "Textcourse_major"
        Me.Textcourse_major.Size = New System.Drawing.Size(292, 22)
        Me.Textcourse_major.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(330, 183)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 16)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Major"
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnLoad.Location = New System.Drawing.Point(852, 221)
        Me.btnLoad.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(115, 36)
        Me.btnLoad.TabIndex = 71
        Me.btnLoad.Text = "View Courses"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'dgcourses
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgcourses.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgcourses.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgcourses.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgcourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgcourses.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cNO, Me.course_code, Me.course_name, Me.course_major, Me.tuition_fee_perSem, Me.school_deptUniCode})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Goldenrod
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgcourses.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgcourses.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgcourses.Location = New System.Drawing.Point(329, 274)
        Me.dgcourses.Name = "dgcourses"
        Me.dgcourses.Size = New System.Drawing.Size(638, 258)
        Me.dgcourses.TabIndex = 70
        '
        'cNO
        '
        Me.cNO.HeaderText = "No."
        Me.cNO.Name = "cNO"
        '
        'course_code
        '
        Me.course_code.HeaderText = "Course ID"
        Me.course_code.Name = "course_code"
        '
        'course_name
        '
        Me.course_name.HeaderText = "Course"
        Me.course_name.Name = "course_name"
        '
        'course_major
        '
        Me.course_major.HeaderText = "Major "
        Me.course_major.Name = "course_major"
        '
        'tuition_fee_perSem
        '
        Me.tuition_fee_perSem.HeaderText = "Tuition Fee"
        Me.tuition_fee_perSem.Name = "tuition_fee_perSem"
        '
        'school_deptUniCode
        '
        Me.school_deptUniCode.HeaderText = "Department"
        Me.school_deptUniCode.Name = "school_deptUniCode"
        '
        'deleteButton
        '
        Me.deleteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.deleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteButton.Location = New System.Drawing.Point(740, 221)
        Me.deleteButton.Margin = New System.Windows.Forms.Padding(2)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(115, 36)
        Me.deleteButton.TabIndex = 69
        Me.deleteButton.Text = "Delete Record"
        Me.deleteButton.UseVisualStyleBackColor = False
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.Maroon
        Me.UpdateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.UpdateButton.Location = New System.Drawing.Point(628, 221)
        Me.UpdateButton.Margin = New System.Windows.Forms.Padding(2)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(115, 36)
        Me.UpdateButton.TabIndex = 68
        Me.UpdateButton.Text = "Modify Record"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(513, 221)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(115, 36)
        Me.btnAdd.TabIndex = 67
        Me.btnAdd.Text = "Add Record"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Textcno
        '
        Me.Textcno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textcno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textcno.Location = New System.Drawing.Point(421, 129)
        Me.Textcno.Margin = New System.Windows.Forms.Padding(2)
        Me.Textcno.Name = "Textcno"
        Me.Textcno.Size = New System.Drawing.Size(293, 22)
        Me.Textcno.TabIndex = 77
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(329, 136)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 16)
        Me.Label12.TabIndex = 76
        Me.Label12.Text = "Course No."
        '
        'Textc_code
        '
        Me.Textc_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textc_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textc_code.Location = New System.Drawing.Point(421, 105)
        Me.Textc_code.Margin = New System.Windows.Forms.Padding(2)
        Me.Textc_code.Name = "Textc_code"
        Me.Textc_code.Size = New System.Drawing.Size(293, 22)
        Me.Textc_code.TabIndex = 75
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(330, 112)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 16)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "Course Code"
        '
        'Textcourse_name
        '
        Me.Textcourse_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textcourse_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textcourse_name.Location = New System.Drawing.Point(422, 153)
        Me.Textcourse_name.Margin = New System.Windows.Forms.Padding(2)
        Me.Textcourse_name.Name = "Textcourse_name"
        Me.Textcourse_name.Size = New System.Drawing.Size(292, 22)
        Me.Textcourse_name.TabIndex = 73
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(328, 160)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 16)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "Course Name"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(314, 15)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(234, 36)
        Me.Button1.TabIndex = 78
        Me.Button1.Text = "Go back to menu"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StartHere.My.Resources.Resources._3
        Me.PictureBox1.Location = New System.Drawing.Point(-4, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(261, 577)
        Me.PictureBox1.TabIndex = 79
        Me.PictureBox1.TabStop = False
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExport.Location = New System.Drawing.Point(756, 15)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(211, 36)
        Me.btnExport.TabIndex = 80
        Me.btnExport.Text = "Export Courses Data to CSV"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnUpload.Location = New System.Drawing.Point(540, 15)
        Me.btnUpload.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(220, 36)
        Me.btnUpload.TabIndex = 81
        Me.btnUpload.Text = "Upload Data from CSV"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'Formcourses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1038, 563)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Textcno)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Textc_code)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Textcourse_name)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.dgcourses)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Textschool_deptUnicode)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextTuition_fee_perSem)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Textcourse_major)
        Me.Controls.Add(Me.Label7)
        Me.Name = "Formcourses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Available Courses"
        CType(Me.dgcourses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Textschool_deptUnicode As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextTuition_fee_perSem As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Textcourse_major As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnLoad As Button
    Friend WithEvents dgcourses As DataGridView
    Friend WithEvents cNO As DataGridViewTextBoxColumn
    Friend WithEvents course_code As DataGridViewTextBoxColumn
    Friend WithEvents course_name As DataGridViewTextBoxColumn
    Friend WithEvents course_major As DataGridViewTextBoxColumn
    Friend WithEvents tuition_fee_perSem As DataGridViewTextBoxColumn
    Friend WithEvents school_deptUniCode As DataGridViewTextBoxColumn
    Friend WithEvents deleteButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Textcno As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Textc_code As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Textcourse_name As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnExport As Button
    Friend WithEvents btnUpload As Button
End Class
