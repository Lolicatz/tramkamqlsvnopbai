Public Class frmGPA
    Private Sub loaddata()
        OleDbDataAdapter1.Fill(DataSet1)
    End Sub
    Private Sub BtnThemGPA_Click(sender As Object, e As EventArgs) Handles BtnThemGPA.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "INSERT INTO GPA
                         (ID_St, ID_Su, Lanthi, GPA)
VALUES        (N'" & txtSuID.Text & "',N'" & txtSubID.Text & "',N'" & txtlanthi.Text & "',N'" & txtGPA.Text & "')"
            OleDbDeleteCommand1.CommandText = sql
            OleDbDeleteCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet1.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnInGPA_Click(sender As Object, e As EventArgs) Handles btnInGPA.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "SELECT [ID_St]
      ,[ID_Su]
      ,[Lanthi]
      ,[GPA]
  FROM [dbo].[GPA]"
            OleDbSelectCommand1.CommandText = sql
            OleDbSelectCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet1.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnSuaGPA_Click(sender As Object, e As EventArgs) Handles BtnSuaGPA.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "UPDATE [dbo].[GPA]
   SET [ID_St] = N'" & txtSuID.Text & "'
      ,[ID_Su] = N'" & txtSubID.Text & "'
      ,[Lanthi] = N'" & txtlanthi.Text & "'
      ,[GPA] = N'" & txtGPA.Text & "'
 WHERE [ID_St] = N'" & txtSuID.Text & "'"
            OleDbUpdateCommand1.CommandText = sql
            OleDbUpdateCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet1.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnXoaGPA_Click(sender As Object, e As EventArgs) Handles BtnXoaGPA.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "DELETE FROM [dbo].[GPA]
      WHERE [ID_St] = N'" & txtSuID.Text & "'"
            OleDbInsertCommand1.CommandText = sql
            OleDbInsertCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet1.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class