<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClass
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
        Me.btnThemCl = New System.Windows.Forms.Button()
        Me.btnSuaCl = New System.Windows.Forms.Button()
        Me.btnXoaCl = New System.Windows.Forms.Button()
        Me.btnInCl = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataSet11 = New tramkamqlsv.DataSet1()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.IDClDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameClDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnThemCl
        '
        Me.btnThemCl.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnThemCl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnThemCl.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemCl.Location = New System.Drawing.Point(536, 385)
        Me.btnThemCl.Name = "btnThemCl"
        Me.btnThemCl.Size = New System.Drawing.Size(86, 38)
        Me.btnThemCl.TabIndex = 0
        Me.btnThemCl.Text = "Insert"
        Me.btnThemCl.UseVisualStyleBackColor = False
        '
        'btnSuaCl
        '
        Me.btnSuaCl.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnSuaCl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuaCl.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuaCl.Location = New System.Drawing.Point(641, 385)
        Me.btnSuaCl.Name = "btnSuaCl"
        Me.btnSuaCl.Size = New System.Drawing.Size(86, 38)
        Me.btnSuaCl.TabIndex = 0
        Me.btnSuaCl.Text = "Update"
        Me.btnSuaCl.UseVisualStyleBackColor = False
        '
        'btnXoaCl
        '
        Me.btnXoaCl.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnXoaCl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnXoaCl.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoaCl.Location = New System.Drawing.Point(536, 444)
        Me.btnXoaCl.Name = "btnXoaCl"
        Me.btnXoaCl.Size = New System.Drawing.Size(86, 38)
        Me.btnXoaCl.TabIndex = 0
        Me.btnXoaCl.Text = "Delete"
        Me.btnXoaCl.UseVisualStyleBackColor = False
        '
        'btnInCl
        '
        Me.btnInCl.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnInCl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInCl.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInCl.Location = New System.Drawing.Point(641, 444)
        Me.btnInCl.Name = "btnInCl"
        Me.btnInCl.Size = New System.Drawing.Size(86, 38)
        Me.btnInCl.TabIndex = 0
        Me.btnInCl.Text = "Print"
        Me.btnInCl.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDClDataGridViewTextBoxColumn, Me.NameClDataGridViewTextBoxColumn, Me.IDDeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataMember = "Class"
        Me.DataGridView1.DataSource = Me.DataSet11
        Me.DataGridView1.Location = New System.Drawing.Point(35, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.Size = New System.Drawing.Size(773, 314)
        Me.DataGridView1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet11, "Class.ID_Cl", True))
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(208, 366)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(250, 29)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet11, "Class.Name_Cl", True))
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(208, 414)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(250, 29)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet11, "Class.ID_De", True))
        Me.TextBox3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(208, 463)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(250, 29)
        Me.TextBox3.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 374)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Class ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 422)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Class Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 472)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Department ID"
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT        Class.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            Class"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO [Class] ([ID_Cl], [Name_Cl], [ID_De]) VALUES (?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("ID_Cl", System.Data.OleDb.OleDbType.VarChar, 0, "ID_Cl"), New System.Data.OleDb.OleDbParameter("Name_Cl", System.Data.OleDb.OleDbType.VarWChar, 0, "Name_Cl"), New System.Data.OleDb.OleDbParameter("ID_De", System.Data.OleDb.OleDbType.VarChar, 0, "ID_De")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE [Class] SET [ID_Cl] = ?, [Name_Cl] = ?, [ID_De] = ? WHERE (([ID_Cl] = ?) A" &
    "ND ((? = 1 AND [Name_Cl] IS NULL) OR ([Name_Cl] = ?)) AND ([ID_De] = ?))"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("ID_Cl", System.Data.OleDb.OleDbType.VarChar, 0, "ID_Cl"), New System.Data.OleDb.OleDbParameter("Name_Cl", System.Data.OleDb.OleDbType.VarWChar, 0, "Name_Cl"), New System.Data.OleDb.OleDbParameter("ID_De", System.Data.OleDb.OleDbType.VarChar, 0, "ID_De"), New System.Data.OleDb.OleDbParameter("Original_ID_Cl", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Cl", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Name_Cl", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Name_Cl", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Name_Cl", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name_Cl", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ID_De", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_De", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM [Class] WHERE (([ID_Cl] = ?) AND ((? = 1 AND [Name_Cl] IS NULL) OR ([" &
    "Name_Cl] = ?)) AND ([ID_De] = ?))"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_ID_Cl", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Cl", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Name_Cl", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Name_Cl", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Name_Cl", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name_Cl", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ID_De", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_De", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Class", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_Cl", "ID_Cl"), New System.Data.Common.DataColumnMapping("Name_Cl", "Name_Cl"), New System.Data.Common.DataColumnMapping("ID_De", "ID_De")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=SQLOLEDB.1;Data Source=NEXUSLITE-PC;Integrated Security=SSPI;Initial Cat" &
    "alog=lt"
        '
        'IDClDataGridViewTextBoxColumn
        '
        Me.IDClDataGridViewTextBoxColumn.DataPropertyName = "ID_Cl"
        Me.IDClDataGridViewTextBoxColumn.HeaderText = "Class ID"
        Me.IDClDataGridViewTextBoxColumn.Name = "IDClDataGridViewTextBoxColumn"
        Me.IDClDataGridViewTextBoxColumn.Width = 200
        '
        'NameClDataGridViewTextBoxColumn
        '
        Me.NameClDataGridViewTextBoxColumn.DataPropertyName = "Name_Cl"
        Me.NameClDataGridViewTextBoxColumn.HeaderText = "Class Name"
        Me.NameClDataGridViewTextBoxColumn.Name = "NameClDataGridViewTextBoxColumn"
        Me.NameClDataGridViewTextBoxColumn.Width = 300
        '
        'IDDeDataGridViewTextBoxColumn
        '
        Me.IDDeDataGridViewTextBoxColumn.DataPropertyName = "ID_De"
        Me.IDDeDataGridViewTextBoxColumn.HeaderText = "Department ID"
        Me.IDDeDataGridViewTextBoxColumn.Name = "IDDeDataGridViewTextBoxColumn"
        Me.IDDeDataGridViewTextBoxColumn.Width = 230
        '
        'frmClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(833, 556)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnInCl)
        Me.Controls.Add(Me.btnXoaCl)
        Me.Controls.Add(Me.btnSuaCl)
        Me.Controls.Add(Me.btnThemCl)
        Me.Name = "frmClass"
        Me.Text = "frmClass"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnThemCl As Button
    Friend WithEvents btnSuaCl As Button
    Friend WithEvents btnXoaCl As Button
    Friend WithEvents btnInCl As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents IDClDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameClDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
