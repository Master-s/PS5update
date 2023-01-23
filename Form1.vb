Imports System.IO
Imports System.Net
Imports System.Collections.Generic
Imports System.IO.Compression
Imports System.ComponentModel
Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click

    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        If My.Settings.IP = "" Then
        Else
            TextBox1.Text = My.Settings.IP
        End If
    End Sub

    Sub sendps5update()
        Dim overwrite As Boolean = False
        Try
            Dim di As New DirectoryInfo(Application.StartupPath & "/update/" & ComboBox1.Text) ''ComboBox1

            Dim ftp As New FTP("", "")
            For Each fi As FileInfo In di.EnumerateFiles("*")
                If File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/update/" & fi.Name) And overwrite = True Then
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/update/" & fi.Name)
                ElseIf File.Exists("ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/update/" & fi.Name) And overwrite = False Then

                Else
                    ftp.UploadFile(fi.FullName, "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/update/" & fi.Name)
                End If

            Next

            MsgBox(" Default !", MsgBoxStyle.Information)
            Me.UseWaitCursor = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ps5update_Click(sender As Object, e As EventArgs) Handles ps5update.Click
        Dim overwrite = MessageBox.Show("PS5update", "PS5update", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        Dim ow As Boolean = False

        If overwrite = DialogResult.No Then

        ElseIf ow = DialogResult.Yes Then

        ElseIf TextBox1.Text = "IP Here" Or TextBox1.Text = "" Then
            MsgBox("Please enter a IP", MsgBoxStyle.Critical)
        Else
            My.Settings.IP = TextBox1.Text
            Me.UseWaitCursor = True
            sendps5update()
        End If
    End Sub

    Private Sub bFolderPS5_Click(sender As Object, e As EventArgs) Handles bFolderPS5.Click
        Process.Start("explorer.exe", "ftp://" & TextBox1.Text & ":" & TextBox2.Text & "/update/")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("update")
    End Sub
End Class
