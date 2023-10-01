<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGPA
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.BtnThemGPA = New System.Windows.Forms.Button()
        Me.BtnSuaGPA = New System.Windows.Forms.Button()
        Me.BtnXoaGPA = New System.Windows.Forms.Button()
        Me.btnInGPA = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 367)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student ID"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(786, 315)
        Me.DataGridView1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 411)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Subject ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(74, 455)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Exam Times"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(74, 502)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "GPA"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(186, 363)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(331, 26)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(186, 410)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(331, 26)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(186, 452)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(331, 26)
        Me.TextBox3.TabIndex = 5
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(186, 499)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(331, 26)
        Me.TextBox4.TabIndex = 5
        '
        'BtnThemGPA
        '
        Me.BtnThemGPA.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.BtnThemGPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnThemGPA.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnThemGPA.Location = New System.Drawing.Point(588, 403)
        Me.BtnThemGPA.Name = "BtnThemGPA"
        Me.BtnThemGPA.Size = New System.Drawing.Size(85, 39)
        Me.BtnThemGPA.TabIndex = 6
        Me.BtnThemGPA.Text = "Insert"
        Me.BtnThemGPA.UseVisualStyleBackColor = False
        '
        'BtnSuaGPA
        '
        Me.BtnSuaGPA.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.BtnSuaGPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSuaGPA.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSuaGPA.Location = New System.Drawing.Point(684, 403)
        Me.BtnSuaGPA.Name = "BtnSuaGPA"
        Me.BtnSuaGPA.Size = New System.Drawing.Size(85, 39)
        Me.BtnSuaGPA.TabIndex = 7
        Me.BtnSuaGPA.Text = "Update"
        Me.BtnSuaGPA.UseVisualStyleBackColor = False
        '
        'BtnXoaGPA
        '
        Me.BtnXoaGPA.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.BtnXoaGPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnXoaGPA.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnXoaGPA.Location = New System.Drawing.Point(588, 455)
        Me.BtnXoaGPA.Name = "BtnXoaGPA"
        Me.BtnXoaGPA.Size = New System.Drawing.Size(85, 39)
        Me.BtnXoaGPA.TabIndex = 8
        Me.BtnXoaGPA.Text = "Delete"
        Me.BtnXoaGPA.UseVisualStyleBackColor = False
        '
        'btnInGPA
        '
        Me.btnInGPA.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnInGPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInGPA.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInGPA.Location = New System.Drawing.Point(684, 455)
        Me.btnInGPA.Name = "btnInGPA"
        Me.btnInGPA.Size = New System.Drawing.Size(85, 39)
        Me.btnInGPA.TabIndex = 9
        Me.btnInGPA.Text = "Print"
        Me.btnInGPA.UseVisualStyleBackColor = False
        '
        'frmGPA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(833, 556)
        Me.Controls.Add(Me.btnInGPA)
        Me.Controls.Add(Me.BtnXoaGPA)
        Me.Controls.Add(Me.BtnSuaGPA)
        Me.Controls.Add(Me.BtnThemGPA)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmGPA"
        Me.Text = "frmGPA"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents BtnThemGPA As Button
    Friend WithEvents BtnSuaGPA As Button
    Friend WithEvents BtnXoaGPA As Button
    Friend WithEvents btnInGPA As Button
End Class
