<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubject
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btnThemSU = New System.Windows.Forms.Button()
        Me.btnSuaSu = New System.Windows.Forms.Button()
        Me.btnXoaSu = New System.Windows.Forms.Button()
        Me.btnInSU = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 356)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subject ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 417)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Subject Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 480)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Department ID"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(31, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(768, 297)
        Me.DataGridView1.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(200, 358)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(334, 26)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(200, 419)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(334, 26)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(200, 482)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(334, 26)
        Me.TextBox3.TabIndex = 4
        '
        'btnThemSU
        '
        Me.btnThemSU.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnThemSU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnThemSU.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemSU.Location = New System.Drawing.Point(590, 375)
        Me.btnThemSU.Name = "btnThemSU"
        Me.btnThemSU.Size = New System.Drawing.Size(87, 40)
        Me.btnThemSU.TabIndex = 5
        Me.btnThemSU.Text = "Insert"
        Me.btnThemSU.UseVisualStyleBackColor = False
        '
        'btnSuaSu
        '
        Me.btnSuaSu.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnSuaSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuaSu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuaSu.Location = New System.Drawing.Point(692, 375)
        Me.btnSuaSu.Name = "btnSuaSu"
        Me.btnSuaSu.Size = New System.Drawing.Size(87, 40)
        Me.btnSuaSu.TabIndex = 5
        Me.btnSuaSu.Text = "Update"
        Me.btnSuaSu.UseVisualStyleBackColor = False
        '
        'btnXoaSu
        '
        Me.btnXoaSu.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnXoaSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnXoaSu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoaSu.Location = New System.Drawing.Point(590, 435)
        Me.btnXoaSu.Name = "btnXoaSu"
        Me.btnXoaSu.Size = New System.Drawing.Size(87, 40)
        Me.btnXoaSu.TabIndex = 5
        Me.btnXoaSu.Text = "Delete"
        Me.btnXoaSu.UseVisualStyleBackColor = False
        '
        'btnInSU
        '
        Me.btnInSU.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnInSU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInSU.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInSU.Location = New System.Drawing.Point(692, 435)
        Me.btnInSU.Name = "btnInSU"
        Me.btnInSU.Size = New System.Drawing.Size(87, 40)
        Me.btnInSU.TabIndex = 5
        Me.btnInSU.Text = "Print"
        Me.btnInSU.UseVisualStyleBackColor = False
        '
        'frmSubject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(833, 556)
        Me.Controls.Add(Me.btnInSU)
        Me.Controls.Add(Me.btnXoaSu)
        Me.Controls.Add(Me.btnSuaSu)
        Me.Controls.Add(Me.btnThemSU)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSubject"
        Me.Text = "frmSubject"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents btnThemSU As Button
    Friend WithEvents btnSuaSu As Button
    Friend WithEvents btnXoaSu As Button
    Friend WithEvents btnInSU As Button
End Class
