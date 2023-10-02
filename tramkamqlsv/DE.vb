Imports System.Data.OleDb
Imports System.Drawing.Text

Public Class fmDe

    Private Sub fmDe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub loaddata()
        OleDbDataAdapter1.Fill(DataSet1)

    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "INSERT INTO Deparment
                         (ID_De, Name_De)
VALUES        (N'" & TextBox1.Text & "',N'" & TextBox2.Text & "')"
            OleDbInsertCommand1.CommandText = sql
            OleDbInsertCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet1.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnSuaDE_Click(sender As Object, e As EventArgs) Handles btnSuaDE.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "UPDATE [dbo].[Deparment]
   SET [ID_De] = N'" & TextBox1.Text & "'
      ,[Name_De] = N'" & TextBox2.Text & "'
 WHERE [ID_De] = N'" & TextBox1.Text & "'"
            OleDbUpdateCommand1.CommandText = sql
            OleDbUpdateCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet1.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnInDe_Click(sender As Object, e As EventArgs) Handles btnInDe.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "SELECT        ID_De, Name_De
FROM            Deparment"
            OleDbSelectCommand1.CommandText = sql
            OleDbSelectCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet1.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnXoaDE_Click(sender As Object, e As EventArgs) Handles btnXoaDE.Click
        If (TextBox1.Text IsNot Nothing) Then
            Try
                loaddata()
                OleDbConnection1.Open()
                Dim sql As String = "DELETE FROM [dbo].[Deparment]
      WHERE [ID_De] = N'" & TextBox1.Text & "'"
                OleDbDeleteCommand1.CommandText = sql
                OleDbDeleteCommand1.ExecuteNonQuery()
                DataSet1.Clear()
                loaddata()
                OleDbConnection1.Close()
                DataSet1.Clear()
                loaddata()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

    End Sub
End Class