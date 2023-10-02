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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSuaDE = New System.Windows.Forms.Button()
        Me.btnXoaDE = New System.Windows.Forms.Button()
        Me.btnInDe = New System.Windows.Forms.Button()
        Me.DataSet1 = New tramkamqlsv.DataSet1()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.IDDeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "Deparment.ID_De", True))
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(222, 397)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(271, 29)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "Deparment.Name_De", True))
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(222, 459)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(271, 29)
        Me.TextBox2.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDeDataGridViewTextBoxColumn, Me.NameDeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataMember = "Deparment"
        Me.DataGridView1.DataSource = Me.DataSet1
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
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT        ID_De, Name_De" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            Deparment"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO [Deparment] ([ID_De], [Name_De]) VALUES (?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("ID_De", System.Data.OleDb.OleDbType.VarChar, 0, "ID_De"), New System.Data.OleDb.OleDbParameter("Name_De", System.Data.OleDb.OleDbType.VarWChar, 0, "Name_De")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE [Deparment] SET [ID_De] = ?, [Name_De] = ? WHERE (([ID_De] = ?) AND ((? = " &
    "1 AND [Name_De] IS NULL) OR ([Name_De] = ?)))"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("ID_De", System.Data.OleDb.OleDbType.VarChar, 0, "ID_De"), New System.Data.OleDb.OleDbParameter("Name_De", System.Data.OleDb.OleDbType.VarWChar, 0, "Name_De"), New System.Data.OleDb.OleDbParameter("Original_ID_De", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_De", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Name_De", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Name_De", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Name_De", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name_De", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM [Deparment] WHERE (([ID_De] = ?) AND ((? = 1 AND [Name_De] IS NULL) O" &
    "R ([Name_De] = ?)))"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_ID_De", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_De", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Name_De", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Name_De", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Name_De", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name_De", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Deparment", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_De", "ID_De"), New System.Data.Common.DataColumnMapping("Name_De", "Name_De")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=SQLOLEDB.1;Data Source=NEXUSLITE-PC;Integrated Security=SSPI;Initial Cat" &
    "alog=lt"
        '
        'IDDeDataGridViewTextBoxColumn
        '
        Me.IDDeDataGridViewTextBoxColumn.DataPropertyName = "ID_De"
        Me.IDDeDataGridViewTextBoxColumn.HeaderText = "ID_De"
        Me.IDDeDataGridViewTextBoxColumn.Name = "IDDeDataGridViewTextBoxColumn"
        '
        'NameDeDataGridViewTextBoxColumn
        '
        Me.NameDeDataGridViewTextBoxColumn.DataPropertyName = "Name_De"
        Me.NameDeDataGridViewTextBoxColumn.HeaderText = "Name_De"
        Me.NameDeDataGridViewTextBoxColumn.Name = "NameDeDataGridViewTextBoxColumn"
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
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataSet1BindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents IDDeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
