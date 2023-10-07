<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudent))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtStu = New System.Windows.Forms.TextBox()
        Me.txtNameStu = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtSex = New System.Windows.Forms.TextBox()
        Me.txtBor = New System.Windows.Forms.TextBox()
        Me.txtCl = New System.Windows.Forms.TextBox()
        Me.txtDe = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.DataSet1 = New tramkamqlsv.DataSet1()
        Me.IDStDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameStDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateStDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexStDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorStDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDClDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 356)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDStDataGridViewTextBoxColumn, Me.NameStDataGridViewTextBoxColumn, Me.DateStDataGridViewTextBoxColumn, Me.SexStDataGridViewTextBoxColumn, Me.BorStDataGridViewTextBoxColumn, Me.IDClDataGridViewTextBoxColumn, Me.IDDeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataMember = "information"
        Me.DataGridView1.DataSource = Me.DataSet1
        Me.DataGridView1.Location = New System.Drawing.Point(23, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(785, 313)
        Me.DataGridView1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 397)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 445)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 493)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Sex"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(364, 356)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(364, 397)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Class"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(364, 445)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 19)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Department"
        '
        'txtStu
        '
        Me.txtStu.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "information.ID_St", True))
        Me.txtStu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStu.Location = New System.Drawing.Point(112, 353)
        Me.txtStu.Name = "txtStu"
        Me.txtStu.Size = New System.Drawing.Size(204, 26)
        Me.txtStu.TabIndex = 8
        '
        'txtNameStu
        '
        Me.txtNameStu.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "information.Name_St", True))
        Me.txtNameStu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameStu.Location = New System.Drawing.Point(112, 394)
        Me.txtNameStu.Name = "txtNameStu"
        Me.txtNameStu.Size = New System.Drawing.Size(204, 26)
        Me.txtNameStu.TabIndex = 8
        '
        'txtDate
        '
        Me.txtDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "information.Date_St", True))
        Me.txtDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(112, 442)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(204, 26)
        Me.txtDate.TabIndex = 8
        '
        'txtSex
        '
        Me.txtSex.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "information.Sex_St", True))
        Me.txtSex.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSex.Location = New System.Drawing.Point(112, 490)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Size = New System.Drawing.Size(204, 26)
        Me.txtSex.TabIndex = 8
        '
        'txtBor
        '
        Me.txtBor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "information.Bor_St", True))
        Me.txtBor.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBor.Location = New System.Drawing.Point(447, 353)
        Me.txtBor.Name = "txtBor"
        Me.txtBor.Size = New System.Drawing.Size(212, 26)
        Me.txtBor.TabIndex = 8
        '
        'txtCl
        '
        Me.txtCl.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "information.ID_Cl", True))
        Me.txtCl.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCl.Location = New System.Drawing.Point(447, 398)
        Me.txtCl.Name = "txtCl"
        Me.txtCl.Size = New System.Drawing.Size(212, 26)
        Me.txtCl.TabIndex = 8
        '
        'txtDe
        '
        Me.txtDe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "information.ID_De", True))
        Me.txtDe.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDe.Location = New System.Drawing.Point(447, 442)
        Me.txtDe.Name = "txtDe"
        Me.txtDe.Size = New System.Drawing.Size(212, 26)
        Me.txtDe.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(675, 461)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 33)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Insert"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(751, 461)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 33)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(675, 500)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(70, 33)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(751, 500)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(70, 33)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Print"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT        information.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            information"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO [information] ([ID_St], [Name_St], [Date_St], [Sex_St], [Bor_St], [ID" &
    "_Cl], [ID_De]) VALUES (?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("ID_St", System.Data.OleDb.OleDbType.VarChar, 0, "ID_St"), New System.Data.OleDb.OleDbParameter("Name_St", System.Data.OleDb.OleDbType.VarWChar, 0, "Name_St"), New System.Data.OleDb.OleDbParameter("Date_St", System.Data.OleDb.OleDbType.VarWChar, 0, "Date_St"), New System.Data.OleDb.OleDbParameter("Sex_St", System.Data.OleDb.OleDbType.VarWChar, 0, "Sex_St"), New System.Data.OleDb.OleDbParameter("Bor_St", System.Data.OleDb.OleDbType.VarWChar, 0, "Bor_St"), New System.Data.OleDb.OleDbParameter("ID_Cl", System.Data.OleDb.OleDbType.VarChar, 0, "ID_Cl"), New System.Data.OleDb.OleDbParameter("ID_De", System.Data.OleDb.OleDbType.VarChar, 0, "ID_De")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("ID_St", System.Data.OleDb.OleDbType.VarChar, 0, "ID_St"), New System.Data.OleDb.OleDbParameter("Name_St", System.Data.OleDb.OleDbType.VarWChar, 0, "Name_St"), New System.Data.OleDb.OleDbParameter("Date_St", System.Data.OleDb.OleDbType.VarWChar, 0, "Date_St"), New System.Data.OleDb.OleDbParameter("Sex_St", System.Data.OleDb.OleDbType.VarWChar, 0, "Sex_St"), New System.Data.OleDb.OleDbParameter("Bor_St", System.Data.OleDb.OleDbType.VarWChar, 0, "Bor_St"), New System.Data.OleDb.OleDbParameter("ID_Cl", System.Data.OleDb.OleDbType.VarChar, 0, "ID_Cl"), New System.Data.OleDb.OleDbParameter("ID_De", System.Data.OleDb.OleDbType.VarChar, 0, "ID_De"), New System.Data.OleDb.OleDbParameter("Original_ID_St", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_St", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Name_St", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Name_St", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Name_St", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name_St", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Date_St", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Date_St", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Date_St", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Date_St", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Sex_St", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Sex_St", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Sex_St", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Sex_St", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Bor_St", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Bor_St", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Bor_St", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Bor_St", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ID_Cl", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Cl", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ID_De", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_De", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_ID_St", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_St", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Name_St", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Name_St", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Name_St", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name_St", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Date_St", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Date_St", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Date_St", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Date_St", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Sex_St", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Sex_St", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Sex_St", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Sex_St", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Bor_St", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Bor_St", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Bor_St", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Bor_St", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ID_Cl", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Cl", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ID_De", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_De", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "information", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_St", "ID_St"), New System.Data.Common.DataColumnMapping("Name_St", "Name_St"), New System.Data.Common.DataColumnMapping("Date_St", "Date_St"), New System.Data.Common.DataColumnMapping("Sex_St", "Sex_St"), New System.Data.Common.DataColumnMapping("Bor_St", "Bor_St"), New System.Data.Common.DataColumnMapping("ID_Cl", "ID_Cl"), New System.Data.Common.DataColumnMapping("ID_De", "ID_De")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=SQLOLEDB.1;Data Source=NEXUSLITE-PC;Integrated Security=SSPI;Initial Cat" &
    "alog=lt"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IDStDataGridViewTextBoxColumn
        '
        Me.IDStDataGridViewTextBoxColumn.DataPropertyName = "ID_St"
        Me.IDStDataGridViewTextBoxColumn.HeaderText = "Student ID"
        Me.IDStDataGridViewTextBoxColumn.Name = "IDStDataGridViewTextBoxColumn"
        Me.IDStDataGridViewTextBoxColumn.Width = 150
        '
        'NameStDataGridViewTextBoxColumn
        '
        Me.NameStDataGridViewTextBoxColumn.DataPropertyName = "Name_St"
        Me.NameStDataGridViewTextBoxColumn.HeaderText = "Student Name"
        Me.NameStDataGridViewTextBoxColumn.Name = "NameStDataGridViewTextBoxColumn"
        Me.NameStDataGridViewTextBoxColumn.Width = 200
        '
        'DateStDataGridViewTextBoxColumn
        '
        Me.DateStDataGridViewTextBoxColumn.DataPropertyName = "Date_St"
        Me.DateStDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateStDataGridViewTextBoxColumn.Name = "DateStDataGridViewTextBoxColumn"
        Me.DateStDataGridViewTextBoxColumn.Width = 150
        '
        'SexStDataGridViewTextBoxColumn
        '
        Me.SexStDataGridViewTextBoxColumn.DataPropertyName = "Sex_St"
        Me.SexStDataGridViewTextBoxColumn.HeaderText = "Sex"
        Me.SexStDataGridViewTextBoxColumn.Name = "SexStDataGridViewTextBoxColumn"
        Me.SexStDataGridViewTextBoxColumn.Width = 70
        '
        'BorStDataGridViewTextBoxColumn
        '
        Me.BorStDataGridViewTextBoxColumn.DataPropertyName = "Bor_St"
        Me.BorStDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.BorStDataGridViewTextBoxColumn.Name = "BorStDataGridViewTextBoxColumn"
        Me.BorStDataGridViewTextBoxColumn.Width = 150
        '
        'IDClDataGridViewTextBoxColumn
        '
        Me.IDClDataGridViewTextBoxColumn.DataPropertyName = "ID_Cl"
        Me.IDClDataGridViewTextBoxColumn.HeaderText = "Class"
        Me.IDClDataGridViewTextBoxColumn.Name = "IDClDataGridViewTextBoxColumn"
        '
        'IDDeDataGridViewTextBoxColumn
        '
        Me.IDDeDataGridViewTextBoxColumn.DataPropertyName = "ID_De"
        Me.IDDeDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.IDDeDataGridViewTextBoxColumn.Name = "IDDeDataGridViewTextBoxColumn"
        '
        'frmStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(833, 556)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDe)
        Me.Controls.Add(Me.txtSex)
        Me.Controls.Add(Me.txtCl)
        Me.Controls.Add(Me.txtBor)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtNameStu)
        Me.Controls.Add(Me.txtStu)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmStudent"
        Me.Text = "frmStudent"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtStu As TextBox
    Friend WithEvents txtNameStu As TextBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtSex As TextBox
    Friend WithEvents txtBor As TextBox
    Friend WithEvents txtCl As TextBox
    Friend WithEvents txtDe As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents IDStDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameStDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateStDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexStDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BorStDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDClDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
