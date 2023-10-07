Public Class frmClass

    Private Sub loaddata()
        OleDbDataAdapter1.Fill(DataSet11)

    End Sub
    Private Sub btnThemCl_Click(sender As Object, e As EventArgs) Handles btnThemCl.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "INSERT INTO Class
                         (ID_Cl, Name_Cl, ID_De)
VALUES        (N'" & TextBox1.Text & "',N'" & TextBox2.Text & "',N'" & TextBox3.Text & "')"
            OleDbDeleteCommand1.CommandText = sql
            OleDbDeleteCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet11.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnInCl_Click(sender As Object, e As EventArgs) Handles btnInCl.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "SELECT        ID_Cl, Name_Cl, ID_De
FROM            Class"
            OleDbSelectCommand1.CommandText = sql
            OleDbSelectCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet11.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnXoaCl_Click(sender As Object, e As EventArgs) Handles btnXoaCl.Click
        If (TextBox1.Text IsNot Nothing) Then
            Try
                loaddata()
                OleDbConnection1.Open()
                Dim sql As String = "DELETE FROM [dbo].[Class]
      WHERE [ID_Cl] = N'" & TextBox1.Text & "'"
                OleDbInsertCommand1.CommandText = sql
                OleDbInsertCommand1.ExecuteNonQuery()
                DataSet11.Clear()
                loaddata()
                OleDbConnection1.Close()

                loaddata()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

    End Sub

    Private Sub btnSuaCl_Click(sender As Object, e As EventArgs) Handles btnSuaCl.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "UPDATE [dbo].[Class]
   SET [ID_Cl] = N'" & TextBox1.Text & "'
      ,[Name_Cl] = N'" & TextBox2.Text & "'
 WHERE [ID_Cl] = N'" & TextBox1.Text & "'"
            OleDbUpdateCommand1.CommandText = sql
            OleDbUpdateCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet11.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class