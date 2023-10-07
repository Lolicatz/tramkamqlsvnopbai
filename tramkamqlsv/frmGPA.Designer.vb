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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataSet1 = New tramkamqlsv.DataSet1()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSuID = New System.Windows.Forms.TextBox()
        Me.txtSubID = New System.Windows.Forms.TextBox()
        Me.txtlanthi = New System.Windows.Forms.TextBox()
        Me.txtGPA = New System.Windows.Forms.TextBox()
        Me.BtnThemGPA = New System.Windows.Forms.Button()
        Me.BtnSuaGPA = New System.Windows.Forms.Button()
        Me.BtnXoaGPA = New System.Windows.Forms.Button()
        Me.btnInGPA = New System.Windows.Forms.Button()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.IDStDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDSuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LanthiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDStDataGridViewTextBoxColumn, Me.IDSuDataGridViewTextBoxColumn, Me.LanthiDataGridViewTextBoxColumn, Me.GPADataGridViewTextBoxColumn})
        Me.DataGridView1.DataMember = "GPA"
        Me.DataGridView1.DataSource = Me.DataSet1
        Me.DataGridView1.Location = New System.Drawing.Point(23, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(783, 315)
        Me.DataGridView1.TabIndex = 1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'txtSuID
        '
        Me.txtSuID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "GPA.ID_St", True))
        Me.txtSuID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuID.Location = New System.Drawing.Point(186, 363)
        Me.txtSuID.Name = "txtSuID"
        Me.txtSuID.Size = New System.Drawing.Size(331, 26)
        Me.txtSuID.TabIndex = 5
        '
        'txtSubID
        '
        Me.txtSubID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "GPA.ID_Su", True))
        Me.txtSubID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubID.Location = New System.Drawing.Point(186, 410)
        Me.txtSubID.Name = "txtSubID"
        Me.txtSubID.Size = New System.Drawing.Size(331, 26)
        Me.txtSubID.TabIndex = 5
        '
        'txtlanthi
        '
        Me.txtlanthi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "GPA.Lanthi", True))
        Me.txtlanthi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlanthi.Location = New System.Drawing.Point(186, 452)
        Me.txtlanthi.Name = "txtlanthi"
        Me.txtlanthi.Size = New System.Drawing.Size(331, 26)
        Me.txtlanthi.TabIndex = 5
        '
        'txtGPA
        '
        Me.txtGPA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "GPA.GPA", True))
        Me.txtGPA.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGPA.Location = New System.Drawing.Point(186, 499)
        Me.txtGPA.Name = "txtGPA"
        Me.txtGPA.Size = New System.Drawing.Size(331, 26)
        Me.txtGPA.TabIndex = 5
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
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT        GPA.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            GPA"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=SQLOLEDB.1;Data Source=NEXUSLITE-PC;Integrated Security=SSPI;Initial Cat" &
    "alog=lt"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO [GPA] ([ID_St], [ID_Su], [Lanthi], [GPA]) VALUES (?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("ID_St", System.Data.OleDb.OleDbType.VarChar, 0, "ID_St"), New System.Data.OleDb.OleDbParameter("ID_Su", System.Data.OleDb.OleDbType.VarChar, 0, "ID_Su"), New System.Data.OleDb.OleDbParameter("Lanthi", System.Data.OleDb.OleDbType.[Integer], 0, "Lanthi"), New System.Data.OleDb.OleDbParameter("GPA", System.Data.OleDb.OleDbType.[Double], 0, "GPA")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE [GPA] SET [ID_St] = ?, [ID_Su] = ?, [Lanthi] = ?, [GPA] = ? WHERE (([ID_St" &
    "] = ?) AND ([ID_Su] = ?) AND ([Lanthi] = ?) AND ((? = 1 AND [GPA] IS NULL) OR ([" &
    "GPA] = ?)))"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("ID_St", System.Data.OleDb.OleDbType.VarChar, 0, "ID_St"), New System.Data.OleDb.OleDbParameter("ID_Su", System.Data.OleDb.OleDbType.VarChar, 0, "ID_Su"), New System.Data.OleDb.OleDbParameter("Lanthi", System.Data.OleDb.OleDbType.[Integer], 0, "Lanthi"), New System.Data.OleDb.OleDbParameter("GPA", System.Data.OleDb.OleDbType.[Double], 0, "GPA"), New System.Data.OleDb.OleDbParameter("Original_ID_St", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_St", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ID_Su", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Su", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Lanthi", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lanthi", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_GPA", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GPA", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_GPA", System.Data.OleDb.OleDbType.[Double], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GPA", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM [GPA] WHERE (([ID_St] = ?) AND ([ID_Su] = ?) AND ([Lanthi] = ?) AND (" &
    "(? = 1 AND [GPA] IS NULL) OR ([GPA] = ?)))"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_ID_St", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_St", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ID_Su", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Su", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Lanthi", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lanthi", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_GPA", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "GPA", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_GPA", System.Data.OleDb.OleDbType.[Double], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GPA", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "GPA", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_St", "ID_St"), New System.Data.Common.DataColumnMapping("ID_Su", "ID_Su"), New System.Data.Common.DataColumnMapping("Lanthi", "Lanthi"), New System.Data.Common.DataColumnMapping("GPA", "GPA")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'IDStDataGridViewTextBoxColumn
        '
        Me.IDStDataGridViewTextBoxColumn.DataPropertyName = "ID_St"
        Me.IDStDataGridViewTextBoxColumn.HeaderText = "Student ID"
        Me.IDStDataGridViewTextBoxColumn.Name = "IDStDataGridViewTextBoxColumn"
        Me.IDStDataGridViewTextBoxColumn.Width = 200
        '
        'IDSuDataGridViewTextBoxColumn
        '
        Me.IDSuDataGridViewTextBoxColumn.DataPropertyName = "ID_Su"
        Me.IDSuDataGridViewTextBoxColumn.HeaderText = "Subject ID"
        Me.IDSuDataGridViewTextBoxColumn.Name = "IDSuDataGridViewTextBoxColumn"
        Me.IDSuDataGridViewTextBoxColumn.Width = 200
        '
        'LanthiDataGridViewTextBoxColumn
        '
        Me.LanthiDataGridViewTextBoxColumn.DataPropertyName = "Lanthi"
        Me.LanthiDataGridViewTextBoxColumn.HeaderText = "Exam Times"
        Me.LanthiDataGridViewTextBoxColumn.Name = "LanthiDataGridViewTextBoxColumn"
        Me.LanthiDataGridViewTextBoxColumn.Width = 140
        '
        'GPADataGridViewTextBoxColumn
        '
        Me.GPADataGridViewTextBoxColumn.DataPropertyName = "GPA"
        Me.GPADataGridViewTextBoxColumn.HeaderText = "GPA"
        Me.GPADataGridViewTextBoxColumn.Name = "GPADataGridViewTextBoxColumn"
        Me.GPADataGridViewTextBoxColumn.Width = 200
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
        Me.Controls.Add(Me.txtGPA)
        Me.Controls.Add(Me.txtlanthi)
        Me.Controls.Add(Me.txtSubID)
        Me.Controls.Add(Me.txtSuID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmGPA"
        Me.Text = "frmGPA"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSuID As TextBox
    Friend WithEvents txtSubID As TextBox
    Friend WithEvents txtlanthi As TextBox
    Friend WithEvents txtGPA As TextBox
    Friend WithEvents BtnThemGPA As Button
    Friend WithEvents BtnSuaGPA As Button
    Friend WithEvents BtnXoaGPA As Button
    Friend WithEvents btnInGPA As Button
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents DataSet1BindingSource As BindingSource
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents IDStDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDSuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LanthiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GPADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
