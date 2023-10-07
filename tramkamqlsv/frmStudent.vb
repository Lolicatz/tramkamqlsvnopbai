Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmStudent
    Private Sub loaddata()
        OleDbDataAdapter1.Fill(DataSet1)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "INSERT INTO information
                         (ID_St, Name_St, Date_St, Sex_St, Bor_St, ID_Cl, ID_De)
VALUES        (N'" & txtStu.Text & "',N'" & txtNameStu.Text & "',N'" & txtDate.Text & "',N'" & txtSex.Text & "',N'" & txtBor.Text & "',N'" & txtCl.Text & "',N'" & txtDe.Text & "')"
            OleDbInsertCommand1.CommandText = sql
            OleDbInsertCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet1.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "UPDATE [dbo].[information]
   SET [ID_St] = N'" & txtStu.Text & "'
      ,[Name_St] = N'" & txtNameStu.Text & "'
      ,[Date_St] = N'" & txtDate.Text & "'
      ,[Sex_St] = N'" & txtSex.Text & "'
      ,[Bor_St] = N'" & txtBor.Text & "'
      ,[ID_Cl] = N'" & txtCl.Text & "'
      ,[ID_De] = N'" & txtDe.Text & "'
 WHERE [ID_St] = N'" & txtStu.Text & "'"
            OleDbUpdateCommand1.CommandText = sql
            OleDbUpdateCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet1.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "SELECT        ID_St, Name_St, Date_St, Sex_St, Bor_St, ID_Cl, ID_De
FROM            information"
            OleDbSelectCommand1.CommandText = sql
            OleDbSelectCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet1.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub frmStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "DELETE FROM [dbo].[information]
      WHERE [ID_St] = N'" & txtStu.Text & "'"
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