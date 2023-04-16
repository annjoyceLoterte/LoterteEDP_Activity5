<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.enrolledStudents = New System.Windows.Forms.Button()
        Me.addstudentguardian = New System.Windows.Forms.Button()
        Me.addnewCampus = New System.Windows.Forms.Button()
        Me.addnewDepartment = New System.Windows.Forms.Button()
        Me.addnewcourses = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.bckupbtn = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(644, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "What do you want to do next?"
        '
        'enrolledStudents
        '
        Me.enrolledStudents.BackColor = System.Drawing.Color.Tan
        Me.enrolledStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enrolledStudents.Location = New System.Drawing.Point(673, 330)
        Me.enrolledStudents.Name = "enrolledStudents"
        Me.enrolledStudents.Size = New System.Drawing.Size(238, 41)
        Me.enrolledStudents.TabIndex = 17
        Me.enrolledStudents.Text = "Enroll Students"
        Me.enrolledStudents.UseVisualStyleBackColor = False
        '
        'addstudentguardian
        '
        Me.addstudentguardian.BackColor = System.Drawing.Color.SandyBrown
        Me.addstudentguardian.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addstudentguardian.Location = New System.Drawing.Point(673, 283)
        Me.addstudentguardian.Name = "addstudentguardian"
        Me.addstudentguardian.Size = New System.Drawing.Size(238, 41)
        Me.addstudentguardian.TabIndex = 16
        Me.addstudentguardian.Text = "Add New Student's  Parent"
        Me.addstudentguardian.UseVisualStyleBackColor = False
        '
        'addnewCampus
        '
        Me.addnewCampus.BackColor = System.Drawing.Color.DarkSalmon
        Me.addnewCampus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addnewCampus.Location = New System.Drawing.Point(673, 236)
        Me.addnewCampus.Name = "addnewCampus"
        Me.addnewCampus.Size = New System.Drawing.Size(238, 41)
        Me.addnewCampus.TabIndex = 15
        Me.addnewCampus.Text = "Add New Campus"
        Me.addnewCampus.UseVisualStyleBackColor = False
        '
        'addnewDepartment
        '
        Me.addnewDepartment.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.addnewDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addnewDepartment.Location = New System.Drawing.Point(673, 189)
        Me.addnewDepartment.Name = "addnewDepartment"
        Me.addnewDepartment.Size = New System.Drawing.Size(238, 41)
        Me.addnewDepartment.TabIndex = 14
        Me.addnewDepartment.Text = "Add  New Department"
        Me.addnewDepartment.UseVisualStyleBackColor = False
        '
        'addnewcourses
        '
        Me.addnewcourses.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.addnewcourses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addnewcourses.Location = New System.Drawing.Point(673, 142)
        Me.addnewcourses.Name = "addnewcourses"
        Me.addnewcourses.Size = New System.Drawing.Size(238, 41)
        Me.addnewcourses.TabIndex = 13
        Me.addnewcourses.Text = "Add New Courses Offered"
        Me.addnewcourses.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StartHere.My.Resources.Resources.OPEN
        Me.PictureBox1.Location = New System.Drawing.Point(0, -6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(563, 601)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(569, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 41)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Go Back to Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(897, 510)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 41)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Logout"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'bckupbtn
        '
        Me.bckupbtn.BackColor = System.Drawing.Color.SlateGray
        Me.bckupbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bckupbtn.Location = New System.Drawing.Point(673, 377)
        Me.bckupbtn.Name = "bckupbtn"
        Me.bckupbtn.Size = New System.Drawing.Size(238, 41)
        Me.bckupbtn.TabIndex = 23
        Me.bckupbtn.Text = "Back Up Database"
        Me.bckupbtn.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Tan
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(673, 424)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(238, 41)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Go to Importing CSV"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'MenuForm3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1038, 563)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.bckupbtn)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.enrolledStudents)
        Me.Controls.Add(Me.addstudentguardian)
        Me.Controls.Add(Me.addnewCampus)
        Me.Controls.Add(Me.addnewDepartment)
        Me.Controls.Add(Me.addnewcourses)
        Me.Name = "MenuForm3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuForm3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents enrolledStudents As Button
    Friend WithEvents addstudentguardian As Button
    Friend WithEvents addnewCampus As Button
    Friend WithEvents addnewDepartment As Button
    Friend WithEvents addnewcourses As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents bckupbtn As Button
    Friend WithEvents Button3 As Button
End Class
