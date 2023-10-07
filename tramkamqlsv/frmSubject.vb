Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmSubject
    Private Sub loaddata()
        OleDbDataAdapter1.Fill(DataSet1)
    End Sub
    Private Sub btnThemSU_Click(sender As Object, e As EventArgs) Handles btnThemSU.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "INSERT INTO subjectHP
                         (ID_Su, Name_Su, ID_De)
VALUES        (N'" & txtidsu.Text & "',N'" & txtnamesu.Text & "',N'" & txtde.Text & "')"
            OleDbDeleteCommand1.CommandText = sql
            OleDbDeleteCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet1.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnSuaSu_Click(sender As Object, e As EventArgs) Handles btnSuaSu.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "UPDATE [dbo].[subjectHP]
   SET [ID_Su] = N'" & txtidsu.Text & "'
      ,[Name_Su] = N'" & txtnamesu.Text & "'
      ,[ID_De] = N'" & txtde.Text & "'
 WHERE [ID_Su] = N'" & txtidsu.Text & "'"
            OleDbUpdateCommand1.CommandText = sql
            OleDbUpdateCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet1.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnInSU_Click(sender As Object, e As EventArgs) Handles btnInSU.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "SELECT        ID_Su, Name_Su, ID_De
FROM            subjectHP"
            OleDbSelectCommand1.CommandText = sql
            OleDbSelectCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet1.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnXoaSu_Click(sender As Object, e As EventArgs) Handles btnXoaSu.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "DELETE FROM [dbo].[subjectHP]
      WHERE [ID_Su] = N'" & txtidsu.Text & "'"
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