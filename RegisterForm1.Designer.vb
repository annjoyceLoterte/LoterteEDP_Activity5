<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterForm1
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
        Me.Textuser_Id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLoginhere = New System.Windows.Forms.LinkLabel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Textpassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Textusername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Textuser_Id
        '
        Me.Textuser_Id.BackColor = System.Drawing.Color.White
        Me.Textuser_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textuser_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textuser_Id.Location = New System.Drawing.Point(602, 272)
        Me.Textuser_Id.Name = "Textuser_Id"
        Me.Textuser_Id.Size = New System.Drawing.Size(256, 22)
        Me.Textuser_Id.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(599, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "User ID"
        '
        'LinkLoginhere
        '
        Me.LinkLoginhere.AutoSize = True
        Me.LinkLoginhere.BackColor = System.Drawing.Color.White
        Me.LinkLoginhere.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLoginhere.LinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLoginhere.Location = New System.Drawing.Point(621, 504)
        Me.LinkLoginhere.Name = "LinkLoginhere"
        Me.LinkLoginhere.Size = New System.Drawing.Size(225, 16)
        Me.LinkLoginhere.TabIndex = 22
        Me.LinkLoginhere.TabStop = True
        Me.LinkLoginhere.Text = "Already have an account?Login here"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(659, 449)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(149, 38)
        Me.btnAdd.TabIndex = 21
        Me.btnAdd.Text = "Register"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Textpassword
        '
        Me.Textpassword.BackColor = System.Drawing.Color.White
        Me.Textpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textpassword.Location = New System.Drawing.Point(602, 367)
        Me.Textpassword.Name = "Textpassword"
        Me.Textpassword.Size = New System.Drawing.Size(256, 22)
        Me.Textpassword.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(602, 341)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Password"
        '
        'Textusername
        '
        Me.Textusername.BackColor = System.Drawing.Color.White
        Me.Textusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textusername.Location = New System.Drawing.Point(602, 316)
        Me.Textusername.Name = "Textusername"
        Me.Textusername.Size = New System.Drawing.Size(256, 22)
        Me.Textusername.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(599, 297)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Username"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StartHere.My.Resources.Resources.register
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1045, 587)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'RegisterForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1038, 563)
        Me.Controls.Add(Me.Textuser_Id)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LinkLoginhere)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Textpassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Textusername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "RegisterForm1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register User"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Textuser_Id As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLoginhere As LinkLabel
    Friend WithEvents btnAdd As Button
    Friend WithEvents Textpassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Textusername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
