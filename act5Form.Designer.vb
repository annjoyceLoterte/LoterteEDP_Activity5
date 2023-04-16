<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class act5Form
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
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.gobackbtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnBrowse.Location = New System.Drawing.Point(143, 392)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(180, 42)
        Me.btnBrowse.TabIndex = 0
        Me.btnBrowse.Text = "Upload CSV File to Browse"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.RosyBrown
        Me.btnLoad.Location = New System.Drawing.Point(696, 390)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(115, 42)
        Me.btnLoad.TabIndex = 1
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(143, 97)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(668, 287)
        Me.DataGridView1.TabIndex = 2
        '
        'txtFilePath
        '
        Me.txtFilePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilePath.Location = New System.Drawing.Point(329, 403)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(361, 26)
        Me.txtFilePath.TabIndex = 3
        '
        'gobackbtn
        '
        Me.gobackbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gobackbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gobackbtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.gobackbtn.Location = New System.Drawing.Point(25, 22)
        Me.gobackbtn.Margin = New System.Windows.Forms.Padding(2)
        Me.gobackbtn.Name = "gobackbtn"
        Me.gobackbtn.Size = New System.Drawing.Size(148, 31)
        Me.gobackbtn.TabIndex = 58
        Me.gobackbtn.Text = "Go Back to Menu"
        Me.gobackbtn.UseVisualStyleBackColor = False
        '
        'act5Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 563)
        Me.Controls.Add(Me.gobackbtn)
        Me.Controls.Add(Me.txtFilePath)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnBrowse)
        Me.Name = "act5Form"
        Me.Text = "act5Form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents gobackbtn As Button
End Class
