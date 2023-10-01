<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmDe
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSuaDE = New System.Windows.Forms.Button()
        Me.btnXoaDE = New System.Windows.Forms.Button()
        Me.btnInDe = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(49, 405)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Department ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(49, 467)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Department Name"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(222, 397)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(271, 29)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(222, 459)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(271, 29)
        Me.TextBox2.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(37, 32)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(765, 332)
        Me.DataGridView1.TabIndex = 3
        '
        'btnThem
        '
        Me.btnThem.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnThem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(524, 391)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(85, 38)
        Me.btnThem.TabIndex = 4
        Me.btnThem.Text = "Insert"
        Me.btnThem.UseVisualStyleBackColor = False
        '
        'btnSuaDE
        '
        Me.btnSuaDE.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnSuaDE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuaDE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuaDE.Location = New System.Drawing.Point(625, 391)
        Me.btnSuaDE.Name = "btnSuaDE"
        Me.btnSuaDE.Size = New System.Drawing.Size(85, 38)
        Me.btnSuaDE.TabIndex = 5
        Me.btnSuaDE.Text = "Update"
        Me.btnSuaDE.UseVisualStyleBackColor = False
        '
        'btnXoaDE
        '
        Me.btnXoaDE.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnXoaDE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnXoaDE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoaDE.Location = New System.Drawing.Point(524, 453)
        Me.btnXoaDE.Name = "btnXoaDE"
        Me.btnXoaDE.Size = New System.Drawing.Size(85, 38)
        Me.btnXoaDE.TabIndex = 6
        Me.btnXoaDE.Text = "Delete"
        Me.btnXoaDE.UseVisualStyleBackColor = False
        '
        'btnInDe
        '
        Me.btnInDe.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnInDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInDe.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInDe.Location = New System.Drawing.Point(625, 453)
        Me.btnInDe.Name = "btnInDe"
        Me.btnInDe.Size = New System.Drawing.Size(85, 38)
        Me.btnInDe.TabIndex = 7
        Me.btnInDe.Text = "Print"
        Me.btnInDe.UseVisualStyleBackColor = False
        '
        'fmDe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(833, 556)
        Me.Controls.Add(Me.btnInDe)
        Me.Controls.Add(Me.btnXoaDE)
        Me.Controls.Add(Me.btnSuaDE)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "fmDe"
        Me.Text = "fromDE"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSuaDE As Button
    Friend WithEvents btnXoaDE As Button
    Friend WithEvents btnInDe As Button
End Class
