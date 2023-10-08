Imports System.Text

Public Class Form1
    Private Sub doiten(sender As Object)
        If (sender IsNot Nothing) Then
            Label1.Text = sender.text
        End If
    End Sub
    Private Sub btnDE_Click(sender As Object, e As EventArgs) Handles btnDE.Click
        doiten(sender)
        While Me.Panel2.Controls.Count > 0
            Me.Panel2.Controls(0).Dispose()
        End While
        Dim nf As New fmDe With {.TopMost = False, .AutoSize = False}
        nf.TopLevel = False
        nf.WindowState = FormWindowState.Maximized
        nf.FormBorderStyle = FormBorderStyle.None
        nf.Dock = DockStyle.Fill
        Me.Panel2.Controls.Add(nf)
        nf.Show()
    End Sub

    Private Sub btnCl_Click(sender As Object, e As EventArgs) Handles btnCl.Click
        doiten(sender)
        While Me.Panel2.Controls.Count > 0
            Me.Panel2.Controls(0).Dispose()
        End While
        Dim nf As New frmClass With {.TopMost = False, .AutoSize = False}
        nf.TopLevel = False
        nf.WindowState = FormWindowState.Maximized
        nf.FormBorderStyle = FormBorderStyle.None
        nf.Dock = DockStyle.Fill
        Me.Panel2.Controls.Add(nf)
        nf.Show()
    End Sub

    Private Sub btnSt_Click(sender As Object, e As EventArgs) Handles btnSt.Click
        doiten(sender)
        While Me.Panel2.Controls.Count > 0
            Me.Panel2.Controls(0).Dispose()
        End While
        Dim nf As New frmStudent With {.TopMost = False, .AutoSize = False}
        nf.TopLevel = False
        nf.WindowState = FormWindowState.Maximized
        nf.FormBorderStyle = FormBorderStyle.None
        nf.Dock = DockStyle.Fill
        Me.Panel2.Controls.Add(nf)
        nf.Show()
    End Sub

    Private Sub btnSu_Click(sender As Object, e As EventArgs) Handles btnSu.Click
        doiten(sender)
        While Me.Panel2.Controls.Count > 0
            Me.Panel2.Controls(0).Dispose()
        End While
        Dim nf As New frmSubject With {.TopMost = False, .AutoSize = False}
        nf.TopLevel = False
        nf.WindowState = FormWindowState.Maximized
        nf.FormBorderStyle = FormBorderStyle.None
        nf.Dock = DockStyle.Fill
        Me.Panel2.Controls.Add(nf)
        nf.Show()
    End Sub

    Private Sub btnGPA_Click(sender As Object, e As EventArgs) Handles btnGPA.Click
        doiten(sender)
        While Me.Panel2.Controls.Count > 0
            Me.Panel2.Controls(0).Dispose()
        End While
        Dim nf As New frmGPA With {.TopMost = False, .AutoSize = False}
        nf.TopLevel = False
        nf.WindowState = FormWindowState.Maximized
        nf.FormBorderStyle = FormBorderStyle.None
        nf.Dock = DockStyle.Fill
        Me.Panel2.Controls.Add(nf)
        nf.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
End Class