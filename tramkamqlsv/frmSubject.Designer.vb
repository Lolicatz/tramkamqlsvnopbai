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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtidsu = New System.Windows.Forms.TextBox()
        Me.txtnamesu = New System.Windows.Forms.TextBox()
        Me.txtde = New System.Windows.Forms.TextBox()
        Me.btnThemSU = New System.Windows.Forms.Button()
        Me.btnSuaSu = New System.Windows.Forms.Button()
        Me.btnXoaSu = New System.Windows.Forms.Button()
        Me.btnInSU = New System.Windows.Forms.Button()
        Me.DataSet1 = New tramkamqlsv.DataSet1()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.IDSuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameSuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDSuDataGridViewTextBoxColumn, Me.NameSuDataGridViewTextBoxColumn, Me.IDDeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataMember = "subjectHP"
        Me.DataGridView1.DataSource = Me.DataSet1
        Me.DataGridView1.Location = New System.Drawing.Point(41, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(747, 297)
        Me.DataGridView1.TabIndex = 3
        '
        'txtidsu
        '
        Me.txtidsu.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "subjectHP.ID_Su", True))
        Me.txtidsu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidsu.Location = New System.Drawing.Point(200, 358)
        Me.txtidsu.Name = "txtidsu"
        Me.txtidsu.Size = New System.Drawing.Size(334, 26)
        Me.txtidsu.TabIndex = 4
        '
        'txtnamesu
        '
        Me.txtnamesu.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "subjectHP.Name_Su", True))
        Me.txtnamesu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnamesu.Location = New System.Drawing.Point(200, 419)
        Me.txtnamesu.Name = "txtnamesu"
        Me.txtnamesu.Size = New System.Drawing.Size(334, 26)
        Me.txtnamesu.TabIndex = 4
        '
        'txtde
        '
        Me.txtde.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "subjectHP.ID_De", True))
        Me.txtde.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtde.Location = New System.Drawing.Point(200, 482)
        Me.txtde.Name = "txtde"
        Me.txtde.Size = New System.Drawing.Size(334, 26)
        Me.txtde.TabIndex = 4
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
        Me.OleDbSelectCommand1.CommandText = "SELECT        subjectHP.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            subjectHP"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO [subjectHP] ([ID_Su], [Name_Su], [ID_De]) VALUES (?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("ID_Su", System.Data.OleDb.OleDbType.VarChar, 0, "ID_Su"), New System.Data.OleDb.OleDbParameter("Name_Su", System.Data.OleDb.OleDbType.VarWChar, 0, "Name_Su"), New System.Data.OleDb.OleDbParameter("ID_De", System.Data.OleDb.OleDbType.VarChar, 0, "ID_De")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE [subjectHP] SET [ID_Su] = ?, [Name_Su] = ?, [ID_De] = ? WHERE (([ID_Su] = " &
    "?) AND ((? = 1 AND [Name_Su] IS NULL) OR ([Name_Su] = ?)) AND ([ID_De] = ?))"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("ID_Su", System.Data.OleDb.OleDbType.VarChar, 0, "ID_Su"), New System.Data.OleDb.OleDbParameter("Name_Su", System.Data.OleDb.OleDbType.VarWChar, 0, "Name_Su"), New System.Data.OleDb.OleDbParameter("ID_De", System.Data.OleDb.OleDbType.VarChar, 0, "ID_De"), New System.Data.OleDb.OleDbParameter("Original_ID_Su", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Su", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Name_Su", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Name_Su", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Name_Su", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name_Su", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ID_De", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_De", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM [subjectHP] WHERE (([ID_Su] = ?) AND ((? = 1 AND [Name_Su] IS NULL) O" &
    "R ([Name_Su] = ?)) AND ([ID_De] = ?))"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_ID_Su", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Su", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Name_Su", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Name_Su", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Name_Su", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name_Su", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ID_De", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_De", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "subjectHP", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_Su", "ID_Su"), New System.Data.Common.DataColumnMapping("Name_Su", "Name_Su"), New System.Data.Common.DataColumnMapping("ID_De", "ID_De")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=SQLOLEDB.1;Data Source=NEXUSLITE-PC;Integrated Security=SSPI;Initial Cat" &
    "alog=lt"
        '
        'IDSuDataGridViewTextBoxColumn
        '
        Me.IDSuDataGridViewTextBoxColumn.DataPropertyName = "ID_Su"
        Me.IDSuDataGridViewTextBoxColumn.HeaderText = "Subject ID"
        Me.IDSuDataGridViewTextBoxColumn.Name = "IDSuDataGridViewTextBoxColumn"
        Me.IDSuDataGridViewTextBoxColumn.Width = 200
        '
        'NameSuDataGridViewTextBoxColumn
        '
        Me.NameSuDataGridViewTextBoxColumn.DataPropertyName = "Name_Su"
        Me.NameSuDataGridViewTextBoxColumn.HeaderText = "Subject Name"
        Me.NameSuDataGridViewTextBoxColumn.Name = "NameSuDataGridViewTextBoxColumn"
        Me.NameSuDataGridViewTextBoxColumn.Width = 300
        '
        'IDDeDataGridViewTextBoxColumn
        '
        Me.IDDeDataGridViewTextBoxColumn.DataPropertyName = "ID_De"
        Me.IDDeDataGridViewTextBoxColumn.HeaderText = "Department ID"
        Me.IDDeDataGridViewTextBoxColumn.Name = "IDDeDataGridViewTextBoxColumn"
        Me.IDDeDataGridViewTextBoxColumn.Width = 200
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
        Me.Controls.Add(Me.txtde)
        Me.Controls.Add(Me.txtnamesu)
        Me.Controls.Add(Me.txtidsu)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSubject"
        Me.Text = "frmSubject"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtidsu As TextBox
    Friend WithEvents txtnamesu As TextBox
    Friend WithEvents txtde As TextBox
    Friend WithEvents btnThemSU As Button
    Friend WithEvents btnSuaSu As Button
    Friend WithEvents btnXoaSu As Button
    Friend WithEvents btnInSU As Button
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents DataSet1BindingSource As BindingSource
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents IDSuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameSuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
