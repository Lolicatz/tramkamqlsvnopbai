﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Pntab = New System.Windows.Forms.Panel()
        Me.pnHome = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDE = New System.Windows.Forms.Button()
        Me.btnCl = New System.Windows.Forms.Button()
        Me.btnSt = New System.Windows.Forms.Button()
        Me.btnSu = New System.Windows.Forms.Button()
        Me.btnGPA = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Pntab.SuspendLayout()
        Me.pnHome.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pntab
        '
        Me.Pntab.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Pntab.Controls.Add(Me.Label2)
        Me.Pntab.Controls.Add(Me.btnGPA)
        Me.Pntab.Controls.Add(Me.btnSt)
        Me.Pntab.Controls.Add(Me.btnSu)
        Me.Pntab.Controls.Add(Me.btnCl)
        Me.Pntab.Controls.Add(Me.btnDE)
        Me.Pntab.Controls.Add(Me.PictureBox1)
        Me.Pntab.Dock = System.Windows.Forms.DockStyle.Left
        Me.Pntab.Location = New System.Drawing.Point(0, 0)
        Me.Pntab.Name = "Pntab"
        Me.Pntab.Size = New System.Drawing.Size(191, 655)
        Me.Pntab.TabIndex = 0
        '
        'pnHome
        '
        Me.pnHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.pnHome.Controls.Add(Me.Label1)
        Me.pnHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnHome.Location = New System.Drawing.Point(191, 0)
        Me.pnHome.Name = "pnHome"
        Me.pnHome.Size = New System.Drawing.Size(849, 60)
        Me.pnHome.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(191, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(849, 595)
        Me.Panel2.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(191, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Home"
        '
        'btnDE
        '
        Me.btnDE.FlatAppearance.BorderSize = 0
        Me.btnDE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDE.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDE.Location = New System.Drawing.Point(3, 205)
        Me.btnDE.Name = "btnDE"
        Me.btnDE.Size = New System.Drawing.Size(182, 56)
        Me.btnDE.TabIndex = 1
        Me.btnDE.Text = "Deparment"
        Me.btnDE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDE.UseVisualStyleBackColor = True
        '
        'btnCl
        '
        Me.btnCl.FlatAppearance.BorderSize = 0
        Me.btnCl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCl.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCl.Location = New System.Drawing.Point(3, 258)
        Me.btnCl.Name = "btnCl"
        Me.btnCl.Size = New System.Drawing.Size(182, 56)
        Me.btnCl.TabIndex = 1
        Me.btnCl.Text = "Class"
        Me.btnCl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCl.UseVisualStyleBackColor = True
        '
        'btnSt
        '
        Me.btnSt.FlatAppearance.BorderSize = 0
        Me.btnSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSt.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSt.Location = New System.Drawing.Point(3, 311)
        Me.btnSt.Name = "btnSt"
        Me.btnSt.Size = New System.Drawing.Size(182, 56)
        Me.btnSt.TabIndex = 1
        Me.btnSt.Text = "Student"
        Me.btnSt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSt.UseVisualStyleBackColor = True
        '
        'btnSu
        '
        Me.btnSu.FlatAppearance.BorderSize = 0
        Me.btnSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSu.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSu.Location = New System.Drawing.Point(3, 364)
        Me.btnSu.Name = "btnSu"
        Me.btnSu.Size = New System.Drawing.Size(182, 56)
        Me.btnSu.TabIndex = 1
        Me.btnSu.Text = "Subject"
        Me.btnSu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSu.UseVisualStyleBackColor = True
        '
        'btnGPA
        '
        Me.btnGPA.FlatAppearance.BorderSize = 0
        Me.btnGPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGPA.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGPA.Location = New System.Drawing.Point(3, 417)
        Me.btnGPA.Name = "btnGPA"
        Me.btnGPA.Size = New System.Drawing.Size(182, 56)
        Me.btnGPA.TabIndex = 1
        Me.btnGPA.Text = "GPA"
        Me.btnGPA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGPA.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 38)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kinh Doanh và Công Nghệ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hà Nội" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 655)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnHome)
        Me.Controls.Add(Me.Pntab)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Pntab.ResumeLayout(False)
        Me.Pntab.PerformLayout()
        Me.pnHome.ResumeLayout(False)
        Me.pnHome.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pntab As Panel
    Friend WithEvents pnHome As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnGPA As Button
    Friend WithEvents btnSt As Button
    Friend WithEvents btnSu As Button
    Friend WithEvents btnCl As Button
    Friend WithEvents btnDE As Button
    Friend WithEvents Label2 As Label
End Class
